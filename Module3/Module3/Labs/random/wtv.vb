Module wtv



    Dim person(9) As people
        Dim tmp As String = "george"
        Dim arr_sort As New ArrayList
        Dim arr_tmp As New ArrayList
        Dim minimum_number As String
        Dim maximum_number As String

        Sub main()

            'person 1
            person(0).fname = "George"
            person(0).lname = "Nikou"
        person(0).age = 118
        person(0).gender = "male"

            'person 2
            person(1).fname = "Tina"
            person(1).lname = "lakas"
            person(1).age = 35
            person(1).gender = "female"

            'person 3
            person(2).fname = "Jerry"
            person(2).lname = "seinfield"
            person(2).age = 56
            person(2).gender = "male"

            'person 4
            person(3).fname = "Terry"
            person(3).lname = "Cruz"
        person(3).age = 18
        person(3).gender = "male"


        'arr_sort.Sort()

        'adding numbers to our arraylist
        For i As Integer = 0 To person.Length - 1
            arr_sort.Add(person(i).age)
        Next

        arr_sort.Sort()
        Console.WriteLine(vbNewLine)


            'this code finds the minimum number in the arraylist
            Console.WriteLine()
            arr_sort.Sort()
            For i = 0 To arr_sort.Count - 1
                If (arr_sort(i) = 0) Then
                    'do nothing
                Else
                    minimum_number = arr_sort(i)
                    i = arr_sort.Count - 1 'break out of the loop
                End If
            Next


            arr_sort.Sort()
            maximum_number = arr_sort(arr_sort.Count - 1)
            Console.WriteLine("Maximum number: " & maximum_number & vbNewLine & "Minimum number: " & minimum_number)





            'this code finds the person by their full name
            Try
                For i As Integer = 0 To person.Length - 1
                    If (person(i).fname.ToLower.Contains(tmp.ToLower)) Then
                        Console.WriteLine("Found the name!!" & vbNewLine & "Name is: " & person(i).fname)
                    End If
                Next
            Catch ex As Exception
            End Try




            Console.Read()

        End Sub

        Private Sub display()
            For i As Integer = 0 To person.Length - 1
                Console.WriteLine(i & ". " & person(i).fname & "/ " & person(i).lname & "/ " & person(i).age & "/ " & person(i).gender)
            Next
        End Sub

        Private Structure people
            Dim fname As String
            Dim lname As String
            Dim age As Integer
            Dim gender As String
        End Structure

    End Module


