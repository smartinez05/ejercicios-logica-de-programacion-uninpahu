Dim Mamiferos() As String = {"Perro", "Gato", "Leon", "Puma", "Rinoceronte"}

        Mamiferos(0) = "Perro"
        Mamiferos(1) = "Gato"
        Mamiferos(2) = "Leon"
        Mamiferos(3) = "Puma"
        Mamiferos(4) = "Rinoceronte"


        Dim NotasEstudiante(4) As Double
        
        NotasEstudiante(0) = 4.5
        NotasEstudiante(1) = 4.5
        NotasEstudiante(2) = 4.5
        NotasEstudiante(3) = 4.5
        NotasEstudiante(4) = 4.5

        Dim NotasEstudiante() As Double = {4.5, 3.0, 5.0, 5.4, 1.5}

        Dim ValorFacturas() As Int32 = {12000,
                                        13000,
                                        21000,
                                        20000,
                                        19980,
                                        12000,
                                        13000,
                                        21000,
                                        20000,
                                        19980,
                                        20000,
                                        21400,
                                        12000,
                                        13000,
                                        21000,
                                        20000,
                                        19980,
                                        12000,
                                        13000,
                                        21000,
                                        20000,
                                        19980,
                                        20000,
                                        21400,
                                        12000,
                                        13000,
                                        21000,
                                        20000,
                                        19980,
                                        12000,
                                        13000,
                                        21000,
                                        20000,
                                        19980,
                                        20000,
                                        21400}
        Dim ValordeFacturas As Int32 = Val(ValorFacturas(0) + ValorFacturas(1) + ValorFacturas(2) +
           ValorFacturas(3) + ValorFacturas(4) + ValorFacturas(5) + ValorFacturas(6) + ValorFacturas(7) +
        ValorFacturas(8) + ValorFacturas(9) + ValorFacturas(10) + ValorFacturas(11))

        For index As Integer = 1 To 10 Step 1

        Next

        Dim ValordeFacturas As Int32 = 0

        For Each MiVar As Int32 In ValorFacturas
            ValordeFacturas = ValordeFacturas + Val(MiVar)
        Next


        Console.WriteLine(ValordeFacturas)
        Console.ReadLine()

        Dim CuboMagico(2, 2) As Integer


        CuboMagico(0, 0) = 2
        CuboMagico(0, 1) = 7
        CuboMagico(0, 2) = 6
        CuboMagico(1, 0) = 9
        CuboMagico(1, 1) = 5
        CuboMagico(1, 2) = 1
        CuboMagico(2, 0) = 4
        CuboMagico(2, 1) = 3
        CuboMagico(2, 2) = 8
