﻿Public Class TipoDeportivo

    Inherits carro
    Private cilindros As Integer

    Public Sub New(_matricula As String, _marca As String, _modelo As String, _cilindros As Integer)
        MyBase.New(_matricula, _marca, _modelo)
        cilindros = _cilindros
    End Sub
    Private Function retornarDatos()
        Return "Matricula=" & getMatricula() & "Marca=" & getMarca() & "Modelo" & getModelo() & "Cilindros=" & cilindros
    End Function

End Class
