Public Module program

    Public Sub main(asgs As String())

        Dim c = New carro(3) {}
        c(0) = New carro("654654", "Nissan", 2015)
        c(1) = New TipoTurismo("TT65464", "Nissan", 2010, 3)
        c(2) = New TipoDeportivo("DD6549/9", "Nissan", 2020, 8)
        c(3) = New TipoFurgoneta("FFF54", "Nissan", 2021, 500)

        For Each elemento In c
            Console.WriteLine(elemento.retornarDatos)
        Next
        Console.Read()
    End Sub
End Module
