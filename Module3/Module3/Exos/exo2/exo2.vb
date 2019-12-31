Module exo2

    Sub Main()
        'Dim month_number As Integer
        'Console.WriteLine("Please select a number")
        'month_number = Console.ReadLine()

        'Select Case month_number
        '    Case 1
        '        Console.WriteLine("January")
        '    Case 2
        '        Console.WriteLine("Febuary")
        '    Case 3
        '        Console.WriteLine("March")
        '    Case 4
        '        Console.WriteLine("April")
        '    Case 5
        '        Console.WriteLine("May")
        '    Case 6
        '        Console.WriteLine("June")
        '    Case 7
        '        Console.WriteLine("July")
        '    Case 8
        '        Console.WriteLine("August")
        '    Case 9
        '        Console.WriteLine("September")
        '    Case 10
        '        Console.WriteLine("October")
        '    Case 11
        '        Console.WriteLine("November")
        '    Case 12
        '        Console.WriteLine("December")
        '    Case Else
        '        Console.WriteLine("invalid entry")
        'End Select
        'Console.ReadLine()



        'Dim var1 As Integer
        'var1 = 1
        'While var1 <= 10
        '    Console.WriteLine(var1)
        '    var1 = var1 + 1
        'End While

        'Dim counter As Integer
        'counter = 10
        'For x = 1 To counter
        '    Console.WriteLine(x)
        'Next

        'For x As Integer = 1 To 10 Step 2
        '    Console.WriteLine("x")
        'Next


        'declaring variables
        Dim ferein, celcius, convert1, convert2, result2 As String
        Dim tmp As Integer = 1
        Dim tmp2 As Integer = 1



        'calculating fereinheit to celcius
        While tmp = 1
            Console.WriteLine("Please provide the temperature in Fereinheit")
            ferein = Console.ReadLine()
            'Check if user input is a number
            If IsNumeric(ferein) Then
                Double.Parse(ferein)
                convert1 = Math.Round((ferein - 32) * 5 / 9, 2)
                Console.WriteLine(ferein & " in fereinheit is equal to " & convert1 & " celcius")
                tmp = 0
            Else
                Console.WriteLine("Invalid entry. Please try again.")
            End If
        End While



        'calculating celcius to fereinheit
        While tmp2 = 1
            Console.WriteLine("Please provide the temperature in celcius")
            celcius = Console.ReadLine()
            'Check if user input is a number
            If IsNumeric(celcius) Then
                Double.Parse(celcius)
                convert2 = Math.Round((celcius * 9 / 5) + 32, 2)
                Console.WriteLine(celcius & " in celcius is equal to " & convert2 & " Fereinheit")
                tmp2 = 0
            Else
                Console.WriteLine("Invalid entry. Please try again.")
            End If
        End While



        Console.Read()
    End Sub

End Module
