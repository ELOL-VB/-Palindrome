Module Module1

    Sub Main()
        Dim i As Integer
        Dim a(10) As String
        Dim num As String
        Dim maybe As Integer
        Console.Write("請輸入數字")
        num = Console.Read()
        num = a(10)
        For i = 1 To Len(num)
            a(i - 1) = Mid(num, i, 1)

        Next



        For i = 1 To Len(num)
            If a(i - 1) = Mid(Len(num), i, 1) Then
                maybe = 1


            End If
        Next
        For i = 1 To Len(num) - 1
            If a(i) <> a(Len(num) - 1 - i) Then
                maybe = 0
                Exit For

            End If
        Next

        If maybe = 0 Then
            Console.WriteLine("不是迴紋針")
            Console.Read()

        ElseIf maybe = 1 Then
            Console.WriteLine("是迴紋針")
            Console.Read()


        End If
        Console.Read()
        Console.Read()
        Console.Read()
        Console.Read()
        Console.Read()
        Console.Read()
        Console.Read()

    End Sub

End Module
