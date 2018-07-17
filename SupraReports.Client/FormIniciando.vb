Imports SupraReports.Model
Imports System.Text.RegularExpressions
Imports System.IO

Public Class FormIniciando

  Private Const identificadorTicket As String = "IDMPRO"
  Private WithEvents MitKerberosProcess As Process

  Private Async Sub FormIniciando_ShownAsync(sender As Object, e As EventArgs) Handles MyBase.Shown
    Await Task.WhenAll(
        {
            Task.Run(Sub() ComprobarConexionRmis()),
            Task.Run(Sub() ComprobarConexionSupra())
        }
    )
    Threading.Thread.Sleep(1000)
    Close()
  End Sub

  Private Sub ComprobarConexionRmis()
    Using dao = GeneralDao.Crear(SupraReportsContext.DatabaseTypes.MySql)
      If dao.ComprobarConexion() Then
        PicIconoConexionRmis.Image = IconosConexion.Images("icono_ok")
      Else
        PicIconoConexionRmis.Image = IconosConexion.Images("icono_fail")
      End If
    End Using
  End Sub

  Private Sub ComprobarConexionSupra()
    'If NecesitaAutenticacion() Then
    '  EjecutarMitKerberos()
    'End If
  End Sub

  Private Sub EjecutarMitKerberos()
    Dim psi As ProcessStartInfo = New ProcessStartInfo("MIT Kerberos", "-i")
    Dim mitKerberosProcess As Process = Process.Start(psi)
    mitKerberosProcess.WaitForExit(60000)
    If NecesitaAutenticacion() Then
      PicIconoConexionSupra.Image = IconosConexion.Images("icono_fail")
      MessageBox.Show("No hay conexión con Supra, se podrán guardar consultas, pero no ejecutarlas",
                      "Aviso",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning)
    Else
      PicIconoConexionSupra.Image = IconosConexion.Images("icono_ok")
    End If
  End Sub

  Private Function EjecutarKlist() As String
    Dim rutaEjecutable = Path.Combine(ObtenerRutaDirectorioKerberos(), "klist.exe")
    Dim psi As ProcessStartInfo = New ProcessStartInfo(rutaEjecutable)
    psi.UseShellExecute = False
    psi.RedirectStandardOutput = True

    Dim p As Process = Process.Start(psi)
    Using oStreamReader As System.IO.StreamReader = p.StandardOutput
      Return oStreamReader.ReadToEnd()
    End Using
  End Function

  Private Function NecesitaAutenticacion() As Boolean
    Dim resultadoKlist = EjecutarKlist()
    Return Not resultadoKlist.Contains(identificadorTicket)
  End Function

  Private Function ObtenerRutaDirectorioKerberos() As String
    Dim match As Match = Regex.Match(Environment.GetEnvironmentVariable("PATH"), ";([^;]*Kerberos[^;]*);")
    If match Is Nothing Then Return String.Empty
    Return match.Groups(1).Value
  End Function

End Class