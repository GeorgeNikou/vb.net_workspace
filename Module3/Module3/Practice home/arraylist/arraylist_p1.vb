Module arraylist_p1

    Dim test As New ArrayList
    Dim input As String
    Dim bool As Boolean = True
    Dim found As Boolean


    Sub main()

        'this practice was to search through an arraylist using a regular for loop
        'and state whether the user name was found Or Not.

        test.Add("George")
        test.Add("David")
        test.Add("Peter")
        test.Add("Mellissa")
        test.Add("Jessica")


        While (bool)
            found = False
            Console.WriteLine("Please enter the name you want us to find: ")
            input = Console.ReadLine()

            For i As Integer = 0 To test.Count - 1
                If (test(i).ToString.ToLower = input.ToLower) Then
                    Console.WriteLine("Name has been found : " & input)
                    found = True
                    i = test.Count - 1
                End If
            Next

            If (found = False) Then
                Console.WriteLine("Sorry. That name NOT found. Please try again...")
            End If
        End While


        Console.Read()
    End Sub

End Module
