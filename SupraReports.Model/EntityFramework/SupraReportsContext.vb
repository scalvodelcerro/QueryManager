Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration

Public MustInherit Class SupraReportsContext
  Inherits DbContext

  Public Enum DatabaseTypes
    MySql
    Oracle
  End Enum

  Friend Class Naming
    Friend Const TABLA_CONSULTA As String = "NECA_CONSULTA"
    Friend Const TABLA_EJECUCION As String = "NECA_EJECUCION"
    Friend Const TABLA_INFORME As String = "NECA_INFORME"
    Friend Const TABLA_PARAMETRO As String = "NECA_PARAMETRO"
    Friend Const TABLA_PERMISO_USUARIO As String = "NECA_PERMISO_USUARIO"
    Friend Const TABLA_PROYECTO As String = "NECA_PROYECTO"
    Friend Const TABLA_USUARIO As String = "NECA_USUARIO"

    Friend Const CAMPO_COD_USUARIO As String = "CDUSUARIO"
    Friend Const CAMPO_FLAG_ADMINISTRADOR As String = "SWADMIN"
    Friend Const CAMPO_FLAG_HABILITADA As String = "SWHABILITADA"
    Friend Const CAMPO_FLAG_LUNES As String = "SWLUNES"
    Friend Const CAMPO_FLAG_MARTES As String = "SWMARTES"
    Friend Const CAMPO_FLAG_MIERCOLES As String = "SWMIERCOLES"
    Friend Const CAMPO_FLAG_JUEVES As String = "SWJUEVES"
    Friend Const CAMPO_FLAG_VIERNES As String = "SWVIERNES"
    Friend Const CAMPO_FLAG_SABADO As String = "SWSABADO"
    Friend Const CAMPO_FLAG_DOMINGO As String = "SWDOMINGO"
    Friend Const CAMPO_FECHA_EJECUCION As String = "FEEJECUCION"
    Friend Const CAMPO_HORA As String = "TXHORA"
    Friend Const CAMPO_ID_INFORME As String = "IDINFORME"
    Friend Const CAMPO_ID_PROYECTO As String = "IDPROYECTO"
    Friend Const CAMPO_ID_CONSULTA As String = "IDCONSULTA"
    Friend Const CAMPO_ID_EJECUCION As String = "IDEJECUCION"
    Friend Const CAMPO_ID_PARAMETRO As String = "IDPARAMETRO"
    Friend Const CAMPO_NOMBRE As String = "TXNOMBRE"
    Friend Const CAMPO_NUMERO_MAXIMO_FILAS As String = "NUMAXFILAS"
    Friend Const CAMPO_RESULTADO As String = "TXRESULTADO"
    Friend Const CAMPO_RUTA_FICHERO As String = "TXRUTAFICHERO"
    Friend Const CAMPO_SQL As String = "TXSQL"
    Friend Const CAMPO_VALOR As String = "TXVALOR"
  End Class

  Public Shared Function Crear(databaseType As DatabaseTypes) As SupraReportsContext
    Select Case databaseType
      Case DatabaseTypes.MySql
        Return New SupraReportsContextMySql()
      Case DatabaseTypes.Oracle
        Return New SupraReportsContextOracle()
      Case Else
        Return Nothing
    End Select
  End Function

  Protected Sub New(nameOrConnectionString As String)
    MyBase.New(nameOrConnectionString)
    If Not Database.Exists() Then
      Database.Create()
      InsertarDatosIniciales()
    End If
  End Sub

  Public Property Usuarios As DbSet(Of Usuario)
  Public Property Informes As DbSet(Of Informe)
  Public Property Consultas As DbSet(Of Consulta)
  Public Property Parametros As DbSet(Of Parametro)
  Public Property Programaciones As DbSet(Of Programacion)
  Public Property Ejecuciones As DbSet(Of Ejecucion)
  Public Property Proyectos As DbSet(Of Proyecto)

  Protected Sub InsertarDatosIniciales()
    Usuarios.Add(New Usuario("Sergio"))
    Usuarios.Add(New Usuario("Fulanito"))
    Usuarios.Add(New Usuario("Menganito"))
    Dim proyecto1 = Proyecto.Crear("Proyecto 1")
    proyecto1.Permisos.Add(New PermisoUsuario("Sergio", True, proyecto1.Id))
    Proyectos.Add(proyecto1)
    Dim proyecto2 As Proyecto = Proyecto.Crear("Proyecto 2")
    Proyectos.Add(proyecto2)
    Dim proyecto3 As Proyecto = Proyecto.Crear("Proyecto 3")
    proyecto3.Permisos.Add(New PermisoUsuario("Sergio", False, proyecto3.Id))
    Proyectos.Add(proyecto3)
    SaveChanges()
  End Sub

  Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
    MyBase.OnModelCreating(modelBuilder)
    ConfigurarEntity(modelBuilder.Entity(Of Usuario)())
    ConfigurarEntity(modelBuilder.Entity(Of Informe)())
    ConfigurarEntity(modelBuilder.Entity(Of Consulta)())
    ConfigurarEntity(modelBuilder.Entity(Of Parametro)())
    ConfigurarEntity(modelBuilder.Entity(Of Programacion)())
    ConfigurarEntity(modelBuilder.Entity(Of Ejecucion)())
    ConfigurarEntity(modelBuilder.Entity(Of Proyecto)())
    ConfigurarEntity(modelBuilder.Entity(Of PermisoUsuario)())
  End Sub

  Private Shared Sub ConfigurarEntity(entityUsuario As EntityTypeConfiguration(Of Usuario))
    entityUsuario.
      ToTable(Naming.TABLA_USUARIO).
      HasKey(Function(x) x.Nombre)
    entityUsuario.
      HasMany(Function(x) x.Permisos).
      WithRequired(Function(x) x.Usuario).
      HasForeignKey(Function(x) x.NombreUsuario).
      WillCascadeOnDelete()
    entityUsuario.
      Property(Function(x) x.Nombre).
        HasColumnName(Naming.CAMPO_COD_USUARIO)
    entityUsuario.
      Property(Function(x) x.MaximoNumeroFilasConsulta).
        HasColumnName(Naming.CAMPO_NUMERO_MAXIMO_FILAS)
  End Sub

  Private Shared Sub ConfigurarEntity(entityInforme As EntityTypeConfiguration(Of Informe))
    entityInforme.
      ToTable(Naming.TABLA_INFORME).
      HasKey(Function(x) x.Id)
    entityInforme.
      HasRequired(Function(x) x.Usuario).
      WithMany(Function(x) x.Informes).
      HasForeignKey(Function(x) x.NombreUsuario).
      WillCascadeOnDelete()
    entityInforme.
      HasMany(Function(x) x.Consultas).
      WithRequired(Function(x) x.Informe).
      Map(Function(m) m.MapKey(Naming.CAMPO_ID_INFORME)).
      WillCascadeOnDelete()
    entityInforme.
      HasRequired(Function(x) x.Programacion).
      WithRequiredPrincipal(Function(x) x.Informe).
      WillCascadeOnDelete()
    entityInforme.
      HasMany(Function(x) x.Ejecuciones).
      WithRequired(Function(x) x.Informe).
      Map(Function(m) m.MapKey(Naming.CAMPO_ID_INFORME)).
      WillCascadeOnDelete()
    entityInforme.
      HasOptional(Function(x) x.Proyecto).
      WithMany(Function(x) x.Informes).
      Map(Function(x) x.MapKey(Naming.CAMPO_ID_PROYECTO))
    entityInforme.
      Property(Function(p) p.Id).
        HasColumnName(Naming.CAMPO_ID_INFORME).
        HasColumnOrder(1)
    entityInforme.
      Property(Function(p) p.Nombre).
      HasColumnName(Naming.CAMPO_NOMBRE).
      HasMaxLength(100)
    entityInforme.
      Property(Function(p) p.NombreUsuario).
      HasColumnName(Naming.CAMPO_COD_USUARIO)
  End Sub

  Private Shared Sub ConfigurarEntity(entityConsulta As EntityTypeConfiguration(Of Consulta))
    entityConsulta.
      ToTable(Naming.TABLA_CONSULTA).
      HasMany(Function(x) x.Parametros).
      WithRequired(Function(x) x.Consulta).
      Map(Function(m) m.MapKey(Naming.CAMPO_ID_CONSULTA)).
      WillCascadeOnDelete()
    entityConsulta.
      Property(Function(p) p.Id).
        HasColumnName(Naming.CAMPO_ID_CONSULTA).
        HasColumnOrder(1)
    entityConsulta.
      Property(Function(p) p.Nombre).
        HasColumnName(Naming.CAMPO_NOMBRE).
        HasMaxLength(100)
    entityConsulta.
      Property(Function(p) p.TextoSql).
        HasColumnName(Naming.CAMPO_SQL)
    entityConsulta.
        Property(Function(p) p.Habilitada).
        HasColumnName(Naming.CAMPO_FLAG_HABILITADA)
  End Sub

  Private Shared Sub ConfigurarEntity(entityParametro As EntityTypeConfiguration(Of Parametro))
    entityParametro.
      ToTable(Naming.TABLA_PARAMETRO)
    entityParametro.
      Property(Function(p) p.Id).
        HasColumnName(Naming.CAMPO_ID_PARAMETRO).
        HasColumnOrder(1)
    entityParametro.
      Property(Function(p) p.Nombre).
        HasColumnName(Naming.CAMPO_NOMBRE).
        HasMaxLength(25)
    entityParametro.
      Property(Function(p) p.Valor).
        HasColumnName(Naming.CAMPO_VALOR)
  End Sub

  Private Sub ConfigurarEntity(entityProgramacion As EntityTypeConfiguration(Of Programacion))
    entityProgramacion.
      ToTable(Naming.TABLA_INFORME).
      HasKey(Function(x) x.Id)
    entityProgramacion.
      Property(Function(p) p.Id).
        HasColumnName(Naming.CAMPO_ID_INFORME)
    entityProgramacion.
      Property(Function(p) p.Hora).
        HasColumnName(Naming.CAMPO_HORA).
      HasMaxLength(10)
    entityProgramacion.
      Property(Function(p) p.Lunes).
        HasColumnName(Naming.CAMPO_FLAG_LUNES)
    entityProgramacion.
      Property(Function(p) p.Martes).
        HasColumnName(Naming.CAMPO_FLAG_MARTES)
    entityProgramacion.
      Property(Function(p) p.Miercoles).
        HasColumnName(Naming.CAMPO_FLAG_MIERCOLES)
    entityProgramacion.
      Property(Function(p) p.Jueves).
        HasColumnName(Naming.CAMPO_FLAG_JUEVES)
    entityProgramacion.
      Property(Function(p) p.Viernes).
        HasColumnName(Naming.CAMPO_FLAG_VIERNES)
    entityProgramacion.
      Property(Function(p) p.Sabado).
        HasColumnName(Naming.CAMPO_FLAG_SABADO)
    entityProgramacion.
      Property(Function(p) p.Domingo).
        HasColumnName(Naming.CAMPO_FLAG_DOMINGO)
  End Sub

  Private Shared Sub ConfigurarEntity(entityEjecucion As EntityTypeConfiguration(Of Ejecucion))
    entityEjecucion.
      ToTable(Naming.TABLA_EJECUCION)
    entityEjecucion.
      Property(Function(p) p.Id).
        HasColumnName(Naming.CAMPO_ID_EJECUCION).
        HasColumnOrder(1)
    entityEjecucion.
      Property(Function(p) p.HoraEjecucion).
        HasColumnName(Naming.CAMPO_FECHA_EJECUCION)
    entityEjecucion.
      Property(Function(p) p.RutaFichero).
        HasColumnName(Naming.CAMPO_RUTA_FICHERO)
    entityEjecucion.
      Property(Function(p) p.Resultado).
        HasColumnName(Naming.CAMPO_RESULTADO)
  End Sub

  Private Shared Sub ConfigurarEntity(entityProyecto As EntityTypeConfiguration(Of Proyecto))
    entityProyecto.
      ToTable(Naming.TABLA_PROYECTO)
    entityProyecto.
      HasMany(Function(x) x.Permisos).
      WithRequired(Function(x) x.Proyecto).
      HasForeignKey(Function(x) x.IdProyecto).
      WillCascadeOnDelete()
    entityProyecto.
      Property(Function(p) p.Id).
        HasColumnName(Naming.CAMPO_ID_PROYECTO).
        HasColumnOrder(1)
    entityProyecto.
      Property(Function(p) p.Nombre).
        HasColumnName(Naming.CAMPO_NOMBRE)
  End Sub

  Private Shared Sub ConfigurarEntity(entityPermisoUsuario As EntityTypeConfiguration(Of PermisoUsuario))
    entityPermisoUsuario.
      ToTable(Naming.TABLA_PERMISO_USUARIO).
      HasKey(Function(x) New With {x.IdProyecto, x.NombreUsuario})
    entityPermisoUsuario.
      Property(Function(p) p.IdProyecto).
        HasColumnName(Naming.CAMPO_ID_PROYECTO)
    entityPermisoUsuario.
      Property(Function(p) p.NombreUsuario).
        HasColumnName(Naming.CAMPO_COD_USUARIO)
    entityPermisoUsuario.
      Property(Function(p) p.Administrador).
        HasColumnName(Naming.CAMPO_FLAG_ADMINISTRADOR)
  End Sub

End Class

