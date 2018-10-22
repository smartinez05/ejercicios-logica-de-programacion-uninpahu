Module Module1

    Sub Main()
        Dim muser As Integer 'muser = mazo jugador
        Dim mpc As Integer 'mpc = mazo de la casa
        Dim guser As Integer = 0 'guser = juegos ganados del jugador
        Dim gpc As Integer = 0 'gpc = juegos ganados de la casa
        Dim gemp As Integer = 0 'gemp = juegos empatados
        Dim respuesta As String
        Dim random As Random = New Random

        Console.WriteLine("Bienvenido a Blackjack, presiona Entrar para jugar.")
        Console.ReadLine()

        For i = 1 To 150 Step 1
            muser = 0
            mpc = 0

            muser = muser + random.Next(1, 12)
            muser = muser + random.Next(1, 12)
            mpc = mpc + random.Next(1, 12)
            mpc = mpc + random.Next(1, 12)

            Console.Clear()

            'Turno del Jugador
            While True
                If muser = 21 Then
                    Console.WriteLine("¡Ha ganado el jugador!")
                    guser = guser + 1
                    Exit While
                End If
                Console.WriteLine("Tu mazo suma " & muser & ". ¿Quieres tomar otra carta? (s/n)")
                respuesta = Console.ReadLine()
                If respuesta = "s" Then
                    muser = muser + random.Next(1, 12)
                    If muser > 21 Then
                        Console.WriteLine("Te has pasado de 21, perdiste.")
                        Exit While
                    Else
                        Continue While
                    End If
                ElseIf respuesta = "n" Then
                    Exit While
                Else
                    Console.WriteLine("Respuesta incorrecta. Intenta de nuevo.")
                    Continue While
                End If
            End While

            'Turno de la casa
            If muser <= 21 Then
                While mpc < 21 And mpc < muser
                    mpc = mpc + random.Next(1, 12)
                End While
                If muser = mpc Then
                    Console.WriteLine("¡El jugador y la casa han empatado!")
                    gemp = gemp + 1
                ElseIf muser < mpc And mpc <= 21 Then
                    Console.WriteLine("¡Ha ganado la casa!")
                    gpc = gpc + 1
                ElseIf mpc > 21 Then
                    Console.WriteLine("La casa se ha pasado de 21 y ha perdido.")
                    Console.WriteLine("¡Ha ganado el jugador!")
                    guser = guser + 1
                ElseIf mpc = 21 Then
                    Console.WriteLine("¡Ha ganado la casa!")
                    gpc = gpc + 1
                End If
            Else
                Console.WriteLine("¡Ha ganado la casa!")
                gpc = gpc + 1
            End If
            Console.WriteLine("El mazo del jugador fue " & muser & ".")
            Console.WriteLine("El mazo de la casa fue " & mpc & ".")
            Console.WriteLine("Presione Entrar para volver a jugar.")
            Console.ReadLine()
        Next
        Console.WriteLine("El jugador ha ganado " & guser & " veces.")
        Console.WriteLine("La casa ha ganado " & gpc & " veces.")
        Console.WriteLine("El jugador y la casa han empatado " & gemp & " veces.")
        If guser = gpc Then
            Console.WriteLine("La casa y el jugador han empatado en juegos.")
        ElseIf guser < gpc Then
            Console.WriteLine("La casa ha ganado mas juegos que el jugador.")
        Else
            Console.WriteLine("El jugador ha ganado mas juegos que la casa.")
        End If
        Console.WriteLine("Presione Entrar para salir del juego.")
        Console.ReadLine()
    End Sub
End Module
