Module exo3
    Sub main()

        Dim array_numbers(100) As Integer
        Dim occ(array_numbers.Length + 1) As Integer
        Dim sum As Integer = 0
        Dim el As Integer

        'create array and display random numbers associated with index and then sum the duplicates
        For i = 0 To array_numbers.Length - 1
            el = Rnd(1) * 100
            sum += array_numbers(i)
            array_numbers(i) = Math.Round(Rnd(1) * 100)
            Console.WriteLine("Random number: " & array_numbers(i) & "  array index: " & i & "  Duplicates: " & occ(i))
            occ(el) += 1
        Next
    End Sub

End Module
