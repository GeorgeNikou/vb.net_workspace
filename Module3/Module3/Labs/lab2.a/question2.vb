Module question2

    Dim input_q2b As String
    Dim bool_q2b As Boolean = True
    Sub main()

        Do
            Console.WriteLine("Please enter a number to be converted to word: ")
            input_q2b = Console.ReadLine()
            If (input_q2b.ToLower = "e") Then
                Console.Clear()
                bool_q2b = False
            Else
                If (IsNumeric(input_q2b) = False) Then
                    Console.WriteLine()
                    Console.WriteLine("Invalid entry. User input must be numeric. Please try again...")
                    Console.WriteLine()
                Else
                    Console.WriteLine()
                    Console.WriteLine("Number: " & input_q2b & "    Word: " & NumberToText(input_q2b))
                    Console.WriteLine()
                End If

            End If
        Loop While bool_q2b


        'Console.Read()
        Console.WriteLine("Exiting program now. Goodbye...")
        System.Threading.Thread.Sleep(2500)
    End Sub

    Function NumberToText(ByVal n As Integer) As String

        Select Case n
            Case 0
                Return ""

            Case 1 To 19
                Dim arr() As String = {"One", "Two", "Three", "Four", "Five", "Six", "Seven",
                  "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
                    "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Return arr(n - 1) & " "

            Case 20 To 99
                Dim arr() As String = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                Return arr(n \ 10 - 2) & " " & NumberToText(n Mod 10)

            Case 100 To 199
                Return "One Hundred " & NumberToText(n Mod 100)

            Case 200 To 999
                Return NumberToText(n \ 100) & "Hundred and " & NumberToText(n Mod 100)

            Case 1000 To 1999
                Return "One Thousand " & NumberToText(n Mod 1000)

            Case 2000 To 999999
                Return NumberToText(n \ 1000) & "Thousand " & NumberToText(n Mod 1000)

            Case 1000000 To 1999999
                Return "One Millio " & NumberToText(n Mod 1000000)

            Case 1000000 To 999999999
                Return NumberToText(n \ 1000000) & "Millions " & NumberToText(n Mod 1000000)

            Case 1000000000 To 1999999999
                Return "One Billion " & NumberToText(n Mod 1000000000)

            Case Else
                Return NumberToText(n \ 1000000000) & "Billion " _
                  & NumberToText(n Mod 1000000000)
        End Select
    End Function

End Module
