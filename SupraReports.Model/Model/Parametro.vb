Imports System.ComponentModel

Public Class Parametro
    Implements INotifyPropertyChanged

    Public Shared Function Crear(nombre As String, valor As String, consulta As Consulta) As Parametro
        Return New Parametro(nombre, valor, consulta)
    End Function

    Public Shared Function Copiar(parametro As Parametro) As Parametro
        Dim copiaParametro As Parametro = Crear(parametro.Nombre, parametro.Valor, Nothing)
        Return copiaParametro
    End Function

    Protected Sub New()
    End Sub

    Private Sub New(nombre As String, valor As String, consulta As Consulta)
        Me.Nombre = nombre
        Me.Valor = valor
        Me.Consulta = consulta
    End Sub

    Public Property Id As Integer
    Public Overridable Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            Me._nombre = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Nombre"))
        End Set
    End Property
    Private _nombre As String

    Public Overridable Property Valor As String
        Get
            Return _valor
        End Get
        Set(value As String)
            Me._valor = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Valor"))
        End Set
    End Property
    Private _valor As String

    Public Property Consulta As Consulta

    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged
End Class
