Module p1

    Sub main()

        'Dim test As String
        'Dim num1 As Decimal = 5
        'Dim num2 As Decimal = 10

        'test = "Hello friend //"

        'test = test.Replace("Hello", "goodbye")
        'test = test.Trim("/")
        'Console.WriteLine(test)
        'Console.WriteLine(Date.Now())
        'Console.WriteLine(Date.Now.ToLongDateString())
        'Console.WriteLine(Date.Now.ToShortDateString())
        'Console.WriteLine(Date.Now.ToShortTimeString())
        'Console.WriteLine(Date.Now.ToLongTimeString())
        'Console.WriteLine(Date.Now.ToString("dddd d yyyy"))
        ''Console.WriteLine(test.Equals("me"))

        'Console.WriteLine()


        ''display the current time
        'While (True)
        '    Console.WriteLine(Date.Now.ToLongTimeString())
        '    System.Threading.Thread.Sleep(1000)
        '    Console.Clear()
        'End While


        'num1 ^= num2 'exponent
        'num1 *= num2 'multiplication
        'num1 /= num2 'division
        'num1 \= num2 'integer division
        'num1 += num2 'addition
        'num1 -= num2 'subtraction
        'num1 &= num2 'concatenation

        'Console.WriteLine(num1)

        'Console.WriteLine("Hello world." & test)
        'test = Console.ReadLine()


        'Dim array1(25) As Integer

        'For i = 0 To array1.Length - 1
        '    Console.WriteLine(array1(i))
        'Next

        'Console.WriteLine()

        'For i = 0 To array1.Length - 1
        '    Console.WriteLine(array1(i) = Rnd(1) * 10)
        'Next


        Dim array_numbers(100) As Integer
        Dim occ(array_numbers.Length + 1) As Integer
        Dim sum As Integer = 0
        Dim el As Integer

        For i = 0 To array_numbers.Length - 1
            el = Rnd(1) * 100
            sum += array_numbers(i)
            array_numbers(i) = Math.Round(Rnd(1) * 100)
            Console.WriteLine("Random number: " & array_numbers(i) & "  array index: " & i & "  Duplicates: " & occ(i))
            occ(el) += 1
        Next

        Console.WriteLine(vbNewLine)

        For i = 0 To occ.Length - 1
            el = Rnd(1) * 100
            sum += array_numbers(i)
            array_numbers(i) = Math.Round(Rnd(1) * 100)
            occ(el) += 1

            If (occ(i) + 1 > 0) Then
                Console.WriteLine("Random number: " & array_numbers(i) & "  array index: " & i & "  Duplicates: " & occ(i))
            End If
        Next



        Console.Read()
    End Sub

End Module
