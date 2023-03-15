Public Class TipoTurismo

    Inherits carro

    Private numeropuertas As Integer

    Public Sub New(_matricula As String, _marca As String, _modelo As String, _numeropuesrtas As Integer)
        MyBase.New(_matricula, _marca, _modelo)
        numeropuertas = _numeropuesrtas
    End Sub
    Private Function retornarDatos()
        Return "Matricula=" & getMatricula() & "Marca=" & getMarca() & "Modelo" & getModelo() & "Numero puertas=" & numeropuertas
    End Function

End Class
