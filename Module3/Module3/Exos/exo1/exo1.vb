Module student_main
    Sub main()

        'declare variables
        Dim input1, input2, result1 As Double

        'calculate the sum of two given numbers by the user 
        Console.WriteLine("Please select a number")
        input1 = Console.ReadLine()
        Console.WriteLine("Please select another number")
        input2 = Console.ReadLine()
        result1 = input1 + input2
        Console.WriteLine(input1 & " + " & input2 & " = " & result1)

        'declaring variables
        Dim ferein, celcius, convert1, convert2, result2 As Double

        'calculating fereinheit to celcius
        Console.WriteLine("Please provide the temperature in Fereinheit")
        ferein = Console.ReadLine()
        convert1 = Math.Round((ferein - 32) * 5 / 9, 2)
        Console.WriteLine(ferein & " in fereinheit is equal to " & convert1 & " celcius")


        'calculating celcius to fereinheit
        Console.WriteLine("Please provide the temperature in celcius")
        celcius = Console.ReadLine()
        convert2 = Math.Round((celcius * 9 / 5) + 32, 2)
        Console.WriteLine(celcius & " in celcius is equal to " & convert2 & " Fereinheit")

        Console.Read()
    End Sub

End Module
