Module Module1
    Sub Main()
        Dim Matrix(4, 4) As String
        For index0 = 0 To Matrix.GetUpperBound(0)
            For index1 = 0 To Matrix.GetUpperBound(1)
                Matrix(index0, index1) = "-"
            Next
            Debug.WriteLine("")
        Next
        Dim UbicacionX As String
        Dim UbicacionY As String
        Dim Marca As String = "X"
        Dim ContadorFX As Integer = 0
        Dim ContadorFO As Integer = 0
        Dim ContadorCX As Integer = 0
        Dim ContadorCO As Integer = 0

        For index = 1 To 25
            Console.WriteLine("Digite la ubicacion de la marca " & Marca & " (X), Maximo (5)")

            UbicacionX = Console.ReadLine

            If Val(UbicacionX) <= 5 Then
                If UbicacionX <> "" Then
                    Console.WriteLine("Digite la ubicacion de la marca " & Marca & " (Y), Maximo (5)")
                    UbicacionY = Console.ReadLine
                    If Val(UbicacionY) <= 5 Then
                        If UbicacionY <> "" Then
                            If Matrix(UbicacionX, UbicacionY) = "-" Then
                                Matrix(UbicacionX, UbicacionY) = Marca
                                If Marca = "X" Then
                                    Marca = "O"
                                Else
                                    Marca = "X"
                                End If
                            Else
                                Console.WriteLine("Posicion ya asignada")
                                index = index - 1
                            End If


                            For index0 = 0 To Matrix.GetUpperBound(0)
                                For index1 = 0 To Matrix.GetUpperBound(1)
                                    If Matrix(index0, index1) = "X" Then
                                        ContadorFX = ContadorFX + 1
                                    ElseIf Matrix(index0, index1) = "O" Then
                                        ContadorFO = ContadorFO + 1
                                    End If

                                    Console.Write(Matrix(index0, index1).ToString & " ")
                                    If ContadorFX = 5 Then
                                        Console.WriteLine("Gano X")
                                    ElseIf ContadorFO = 5 Then
                                        Console.WriteLine("Gano O")

                                    End If
                                Next
                                Console.WriteLine("")
                            Next
                        Else
                            Console.WriteLine("Marca no valida")
                        End If
                    End If
                Else
                    Console.WriteLine("Marca no valida")

                End If
            Else
                Console.WriteLine("Limite no valido")
            End If
        Next

        Console.ReadLine()




    End Sub

End Module
