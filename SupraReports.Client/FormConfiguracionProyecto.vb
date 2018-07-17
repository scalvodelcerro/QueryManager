Imports SupraReports.Model

Public Class FormConfiguracionProyecto
    Private proyecto As Proyecto
    Private proyectoService As ProyectoService

    Public Sub New(proyecto As Proyecto)
        InitializeComponent()
        Me.proyecto = proyecto
        Me.proyectoService = New ProyectoService()
    End Sub

    Private Sub FormConfiguracionProyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtos As IList(Of PermisoUsuarioDto) = New List(Of PermisoUsuarioDto)
        Dim dt = proyectoService.ObtenerPermisosUsuarios(proyecto.Id)
        For Each row In dt.Rows
            Dim dto = New PermisoUsuarioDto()
            dto.NombreUsuario = row("nombreUsuario")
            dto.TienePermiso = row("tienePermiso")
            dto.EsAdministrador = row("esAdministrador")
            dtos.Add(dto)
        Next
        PermisoUsuarioDtoBindingSource.DataSource = dtos
    End Sub

    Private Sub DgPermisosUsuario_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgPermisosUsuario.CellValueChanged
        If e.RowIndex >= 0 Then
            Dim nombreUsuario As String = DgPermisosUsuario.Rows(e.RowIndex).Cells(NombreUsuarioColumn.Index).Value
            Dim tienePermiso As Boolean = DgPermisosUsuario.Rows(e.RowIndex).Cells(TienePermisoColumn.Index).Value
            Dim esAdministrador As Boolean = DgPermisosUsuario.Rows(e.RowIndex).Cells(EsAdministradorColumn.Index).Value
            If tienePermiso Then
                proyectoService.GuardarPermisoUsuario(proyecto.Id, nombreUsuario, esAdministrador)
            Else
                proyectoService.EliminarPermisoUsuario(proyecto.Id, nombreUsuario)
            End If
            Console.WriteLine("Row:{0}, Col:{1}", e.RowIndex, e.ColumnIndex)
        End If
    End Sub

    Private Sub DgPermisosUsuario_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgPermisosUsuario.CellMouseUp
        If e.ColumnIndex = TienePermisoColumn.Index OrElse e.ColumnIndex = EsAdministradorColumn.Index Then
            DgPermisosUsuario.EndEdit()
        End If
    End Sub
End Class