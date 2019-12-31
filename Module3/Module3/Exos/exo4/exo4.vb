Module exo4

    Dim bool As Boolean = True
    Dim person As New ArrayList
    Dim counter As Integer = 1
    Dim input As String
    Dim answer As String
    Dim tmp As String
    Sub main()

        add_person("George")
        add_person("Lucy")
        add_person("jack")
        add_person("Mellissa")
        add_person("David")


        While (bool)
            Console.WriteLine()
            menu()
            Console.WriteLine()
            Console.WriteLine("What would you like to do today?")
            input = Console.ReadLine()

            If (input < 1 Or input > 6) Then
                Console.WriteLine("You have entered an invalid option. Please try again")
                Console.WriteLine()
            Else


                If (input = 1) Then
                    Console.WriteLine("Please enter the person you would like to add: ")
                    answer = Console.ReadLine()
                    add_person(answer)
                End If

                If (input = 2) Then
                    Console.WriteLine("Please enter the person you would like to delete: ")
                    answer = Console.ReadLine()
                    delete_person(answer)
                End If

                If (input = 3) Then
                    Console.WriteLine("Name of the new person: ")
                    answer = Console.ReadLine()
                    Console.WriteLine("Please enter the position: ")
                    tmp = Console.ReadLine()
                    edit_person(tmp, answer)
                End If

                If (input = 4) Then
                    Console.WriteLine("Count: " & counting() & " people in this array.")
                End If

                If (input = 5) Then
                    Console.WriteLine("count longest: " & count_longest())
                End If

                If (input = 6) Then
                    show_person_list()
                End If
            End If
        End While

        Console.Read()
    End Sub

    ''' <summary>
    ''' This sub adds a new user to the person array
    ''' </summary>
    ''' <param name="var1">takes in a user name</param>
    Sub add_person(ByRef var1 As String)
        person.Add(var1)
    End Sub


    ''' <summary>
    ''' this sub edits a existing user from the person array
    ''' </summary>
    ''' <param name="var1">this parameter holds the index position of user</param>
    ''' <param name="var2">this parameter contains the new name given by the user to replace old</param>
    Sub edit_person(ByRef var1 As Integer, ByVal var2 As String)
        person.Item(var1) = var2
    End Sub

    ''' <summary>
    ''' this sub deletes a user
    ''' </summary>
    ''' <param name="var1">this parameter holds the user name that needs to be removed</param>
    Sub delete_person(ByRef var1 As String)
        person.Remove(var1)
    End Sub

    ''' <summary>
    ''' this sub displays all the users in the person array
    ''' </summary>
    ''' <param name="var1"></param>
    Sub show_person_list()
        For i = 0 To person.Count - 1
            Console.WriteLine(i + 1 & ". " & person(i))
        Next
    End Sub

    ''' <summary>
    ''' counts the numbers or people in the person array
    ''' </summary>
    ''' <returns></returns>
    Function counting()
        Return person.Count
    End Function


    ''' <summary>
    ''' </summary>
    ''' <returns></returns>
    Function count_longest()
        person.Sort()
        Return person(person.Count - 1)
    End Function

    ''' <summary>
    ''' displays the menu of people
    ''' </summary>
    Sub menu()
        Console.WriteLine("1. Add" & vbCrLf & "2. delete" & vbCrLf & "3. edit" & vbCrLf & "4. count" & vbCrLf & "5. count longest" & vbCrLf & "6. show" & vbCrLf)
    End Sub


End Module
