Public Class InformeService

  Public Function ObtenerInformesDeProyecto(idProyecto As Integer) As IList(Of Informe)
    Using db = New SupraReportsContext
      Return db.Informes.AsNoTracking().
            Where(Function(x) x.Proyecto.Id = idProyecto).
            ToList()
    End Using
  End Function

  Public Function ObtenerInformesPersonalesDeUsuario(nombreUsuario As String) As IList(Of Informe)
    Using db = New SupraReportsContext()
      Return db.Informes.AsNoTracking().
            Where(Function(x) x.NombreUsuario = Environment.UserName AndAlso x.Proyecto Is Nothing).
            ToList()
    End Using
  End Function

  Public Function ObtenerProgramacionesDeUsuario(nombreUsuario As String) As IList(Of Programacion)
    Using db = New SupraReportsContext()
      Return db.Programaciones.Include("Informe.Consultas.Parametros").Include("Informe.Proyecto").
        Where(Function(x) (x.Informe.NombreUsuario = nombreUsuario AndAlso x.Informe.Proyecto Is Nothing) OrElse
                          (x.Informe.Proyecto.Permisos.Any(Function(xx) xx.NombreUsuario = nombreUsuario))).
        ToList()
    End Using
  End Function

  Public Sub GuardarProgramaciones(programaciones As IEnumerable(Of Programacion))
    Using db = New SupraReportsContext()
      For Each programacion As Programacion In programaciones
        db.Entry(programacion).State = Entity.EntityState.Modified
      Next
      db.SaveChanges()
    End Using
  End Sub

  Public Sub ExportarAExcel(informe As Informe, ficheroSalida As String, maximoNumeroFilas As Integer)
    Dim erroresInforme As List(Of String) = New List(Of String)()
    Using excelBuilder = New ExcelBuilder(ficheroSalida)
      For Each consulta In informe.Consultas.Where(Function(x) x.Habilitada)
        Using dao = New GeneralDao(GeneralDao.CrearConexionMySql())
          Dim sql As String = consulta.ComponerSqlResultado()
          If maximoNumeroFilas > 0 Then
            sql = sql & " LIMIT " & maximoNumeroFilas
          End If
          Try
            Dim contents As DataTable = dao.EjecutarSelect(sql)
            If contents.Rows.Count = maximoNumeroFilas Then
              excelBuilder.AddWorksheet(consulta.Nombre, contents, {"Los resultados se han truncado"})
            Else
              excelBuilder.AddWorksheet(consulta.Nombre, contents, Nothing)
            End If
          Catch ex As Exception
            erroresInforme.Add(ex.Message)
            excelBuilder.AddWorksheet(consulta.Nombre, Nothing, {ex.Message})
          End Try
        End Using
      Next
      Try
        excelBuilder.Build()
      Catch ex As Exception
        erroresInforme.Add(ex.Message)
      End Try
    End Using

    ' Guardar resultado
    Dim resultado As String = "Ok"
    If erroresInforme.Any() Then
      resultado = String.Join(" - ", erroresInforme)
    End If
    Using db = New SupraReportsContext()
      db.Informes.Find(informe.Id).AnadirEjecucion(informe.Programacion.Hora, resultado, ficheroSalida)
      db.SaveChanges()
    End Using
  End Sub

End Class
