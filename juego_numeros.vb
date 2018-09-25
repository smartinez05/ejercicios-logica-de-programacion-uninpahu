Imports System

Module Program
    Sub Main()
        Juego()
    End Sub

    Public Sub Juego()
        Dim nuser As Integer
        Dim npc As Integer
        Dim ac_user As Integer = 0
        Dim ac_pc As Integer = 0
        Dim ac_emp As Integer = 0
        Dim n_aleatorio As New Random()

        For i = 1 To 6 Step 1
            Console.WriteLine("Inserte un numero de 1 a 1000")
            nuser = Console.ReadLine()
            npc = n_aleatorio.Next(1, 1000)
            If nuser < npc Then
                Console.WriteLine("Gana pc")
                ac_pc = ac_pc + 1
            ElseIf nuser > npc Then
                Console.WriteLine("Gana usuario")
                ac_user = ac_user + 1
            Else
                Console.WriteLine("Hay empate")
                ac_emp = ac_emp + 1
            End If
            Console.WriteLine("El numero del usuario fue " & nuser & ", el numero del pc fue " & npc & ".")
        Next
        Console.WriteLine("El usuario ha ganado " & ac_user & " veces, el pc ha ganado " & ac_pc & " veces y han empatado " & ac_emp & " veces")
        Console.ReadLine()
    End Sub
End Module
