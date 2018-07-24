Public Class InformeService
  Private loggingService As ILoggingService

  Public Sub New()
  End Sub

  Public Sub New(loggingService As ILoggingService)
    Me.loggingService = loggingService
  End Sub

  Public Function ObtenerInformesDeProyecto(idProyecto As Integer) As IList(Of Informe)
    Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
      Return db.Informes.AsNoTracking().
            Where(Function(x) x.Proyecto.Id = idProyecto).
            OrderBy(Function(x) x.Nombre).
            ToList()
    End Using
  End Function

  Public Function ObtenerInformesDeUsuario(nombreUsuario As String) As Object
    Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
      Dim informes =
        From q As PermisoUsuario In db.PermisosUsuario
        Join i As Informe In db.Informes
               On i.Proyecto.Id Equals q.IdProyecto
        Where q.NombreUsuario = nombreUsuario
        Select i

      Return informes.ToList()
    End Using
  End Function

  Public Function ObtenerProgramacionesDeUsuario(nombreUsuario As String) As IList(Of Programacion)
    Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
      Return db.Programaciones.
        Include("Informe.Proyecto").
        Include("Informe.Consultas.Parametros").
        AsNoTracking().
        Where(Function(x) (x.NombreUsuario = nombreUsuario)).
        ToList()
    End Using
  End Function

  Public Function ObtenerConfiguracionInforme(idInforme As Integer, nombreUsuario As String) As ConfiguracionInforme
    Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
      Return db.ConfiguracionesInforme.
          SingleOrDefault(Function(x) x.IdInforme = idInforme AndAlso x.NombreUsuario = nombreUsuario)
    End Using
  End Function

  Public Sub GuardarConfiguracionInforme(configuracionInforme As ConfiguracionInforme)
    Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
      Dim entity = db.ConfiguracionesInforme.Find(configuracionInforme.IdInforme, configuracionInforme.NombreUsuario)
      If entity Is Nothing Then
        db.ConfiguracionesInforme.Add(configuracionInforme)
      Else
        entity.RutaFichero = configuracionInforme.RutaFichero
      End If
      db.SaveChanges()
    End Using
  End Sub

  Public Sub GuardarProgramaciones(programaciones As IEnumerable(Of Programacion), nombreUsuario As String)
    Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
      'Eliminar borradas
      Dim idsProgramaciones = programaciones.Select(Function(x) x.Id).Distinct()
      Dim entitiesBorradas = db.Programaciones.
        Where(Function(x) x.NombreUsuario = nombreUsuario AndAlso Not idsProgramaciones.Contains(x.Id))
      db.Programaciones.RemoveRange(entitiesBorradas)

      'Actualizar/añadir
      For Each programacion As Programacion In programaciones
        Dim informe = db.Informes.Find(programacion.IdInforme)
        programacion.Informe = informe
        programacion.NombreUsuario = nombreUsuario
        If programacion.Id = 0 Then
          db.Entry(programacion).State = Entity.EntityState.Added
        Else
          db.Entry(programacion).State = Entity.EntityState.Modified
        End If
      Next
      db.SaveChanges()
    End Using
  End Sub

  Public Sub ExportarAExcel(informe As Informe, ficheroSalida As String, nombreUsuarioEjecucion As String, maximoNumeroFilas As Integer, guardarEjecucion As Boolean)
    OnProgresoExportar(1)
    Dim erroresInforme As List(Of String) = New List(Of String)()
    Dim procesados As Integer = 0
    Using excelBuilder = New ExcelBuilder(ficheroSalida)
      Dim consultasHabilitadas = informe.Consultas.Where(Function(x) x.Habilitada).ToList()
      For Each consulta In consultasHabilitadas.AsParallel()
        'Using dao = GeneralDao.Crear(SupraReportsContext.DatabaseTypes.Impala)
        Using dao = GeneralDao.Crear(SupraReportsContext.DatabaseTypes.MySql)
          Dim sql As String = consulta.ComponerSqlResultado()
          If maximoNumeroFilas > 0 Then
            sql = sql & " LIMIT " & maximoNumeroFilas
          End If
          Try
            Dim start = Date.Now
            RegistrarLog(String.Format("Consulta: {0}, Inicio: {1}", consulta.Id, start.ToShortTimeString()))
            Dim contents As DataTable = dao.EjecutarSelect(sql)
            If maximoNumeroFilas > 0 AndAlso contents.Rows.Count = maximoNumeroFilas Then
              excelBuilder.AddWorksheet(consulta.Nombre, contents, {String.Format("Superado el límite máximo de {0} registros", maximoNumeroFilas)})
            Else
              excelBuilder.AddWorksheet(consulta.Nombre, contents, Nothing)
            End If
            Dim finish = Date.Now
            RegistrarLog(String.Format("Consulta: {0}, Fin: {1}, T. ejecución: {2}ms, N. resultados: {3}",
                                         consulta.Id,
                                         Date.Now.ToShortTimeString(),
                                         (finish - start).TotalMilliseconds,
                                         contents.Rows.Count))
          Catch ex As Exception
            RegistrarLog(String.Format("Error de ejecución. Consulta: {0}, Mensaje: {1}", consulta.Id, ex.Message))
            erroresInforme.Add(ex.Message)
            excelBuilder.AddWorksheet(consulta.Nombre, Nothing, {ex.Message})
          End Try
        End Using
        procesados += 1
        OnProgresoExportar(procesados / consultasHabilitadas.Count() * 100)
      Next
      Try
        excelBuilder.Build()
      Catch ex As Exception
        erroresInforme.Add(ex.Message)
      End Try
    End Using

    If guardarEjecucion Then
      ' Guardar resultado
      Dim resultado As String = "Ok"
      If erroresInforme.Any() Then
        resultado = String.Join(" - ", erroresInforme)
      End If
      Using db = SupraReportsContext.Crear(SupraReportsContext.DatabaseTypes.MySql)
        db.Ejecuciones.Add(Ejecucion.Crear(resultado, ficheroSalida, informe.Id, nombreUsuarioEjecucion))
        db.SaveChanges()
      End Using
    End If
  End Sub

  Public Event ProgresoExportar As EventHandler(Of ProgresoEventArgs)
  Protected Overridable Sub OnProgresoExportar(progreso As Integer)
    RaiseEvent ProgresoExportar(Me, New ProgresoEventArgs(progreso))
  End Sub

  Private Sub RegistrarLog(texto As String)
    If loggingService IsNot Nothing Then
      loggingService.Log(texto)
    End If
  End Sub

End Class

Public Class ProgresoEventArgs
  Inherits EventArgs

  Public Property Progress As Integer

  Public Sub New(progress As Integer)
    Me.Progress = progress
  End Sub
End Class
