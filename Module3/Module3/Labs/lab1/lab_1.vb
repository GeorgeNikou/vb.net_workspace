Module lab_1
    Sub main()

        '1.  Average
        'Ask user to enter 3 numbers
        'Display the total of all the numbers entered
        'Display the average of all the numbers entered.

        Dim invalid As String = "Invalid entry. Please try again."
        Dim num1 As String, num2 As String, num3 As String
        Dim bool As Boolean = True

        While (bool)
            Console.WriteLine("Please enter the first number: ")
            num1 = Console.ReadLine()
            Console.WriteLine("Please enter the second number: ")
            num2 = Console.ReadLine()
            Console.WriteLine("Please enter the third number: ")
            num3 = Console.ReadLine()

            If (IsNumeric(num1) And IsNumeric(num2) And IsNumeric(num3)) Then
                Console.WriteLine("First number: " & num1 & "  |  " & " Second number: " & num2 & "  |  " & " Third number: " & num3)
                Console.Write("Average: " & calculate_average(num1, num2, num3))
                bool = False
            Else
                Console.WriteLine(invalid)
            End If

        End While

        Console.Read()

    End Sub

    ''' <summary>
    ''' This function calculates the average
    ''' </summary>
    ''' <param name="var1"></param>
    ''' <param name="var2"></param>
    ''' <param name="var3"></param>
    ''' <returns></returns>
    Function calculate_average(var1 As Double, var2 As Double, var3 As Double) As String
        Dim result As Double
        result = (var1 + var2 + var3) / 3
        Return Math.Round(result, 2)
    End Function

End Module
