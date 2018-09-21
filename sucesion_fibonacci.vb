Public Sub FibonacciWhile()
        Dim ciclo As Integer = 1
        Dim a As Integer = 0
        Dim b As Integer = 1

        Console.WriteLine(a)
        Console.WriteLine(b)

        While ciclo <= 30
            Dim c As Integer = a + b
            ciclo = ciclo + 1

            Console.WriteLine(c)

            a = b
            b = c
        End While
        Console.ReadLine()
    End Sub

    Public Sub FibonacciFor()
        Dim a As Integer = 0
        Dim b As Integer = 1
        Dim c As Integer = 0

        For i = 1 To 30 Step 1
            Console.WriteLine(c)
            a = b
            b = c
            c = a + b
        Next
        Console.ReadLine()
    End Sub
