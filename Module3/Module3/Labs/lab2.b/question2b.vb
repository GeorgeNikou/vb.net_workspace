Module question2b

    Dim people As New ArrayList
    Dim options As New ArrayList
    Dim bool As Boolean = True
    Dim input_options As String
    Dim input_name As String
    Dim input_number As String
    Dim input_final As String
    Dim tmp As String


    Sub main()

        option_items()
        person_tmp()

        While (bool)
            person_greet()
            menu_display()
            input_options = Console.ReadLine()

            If (IsNumeric(input_options) = False) Then
                Console.WriteLine()
                Console.WriteLine("Entry must be numeric. Please try again...")

            ElseIf (input_options < 0 Or input_options > options.Count - 1) Then
                Console.WriteLine()
                Console.WriteLine("Invalid entry. Pease be sure to select one of the following options. ex: 0-4")

            Else
                'ADD
                If (input_options = 0) Then
                    Console.WriteLine("Please enter the name of the person: ")
                    input_name = Console.ReadLine()

                    Console.WriteLine("Please enter the phone number associated with this person: ")
                    input_number = Console.ReadLine()

                    If (IsNumeric(input_name) = True Or IsNumeric(input_number) = False) Then
                        Console.WriteLine()
                        Console.WriteLine("Invalid entry. Please try again...")
                    Else
                        input_final = input_name & " " & input_number
                        person_add(input_final)
                        Console.WriteLine(vbNewLine)
                        Console.WriteLine("Id number" & "[" & people.Count - 1 & "] " & input_name & " has been successfully added to the phonebook.")
                    End If
                End If

                'EDIT
                If (input_options = 1) Then
                    Console.WriteLine("Please enter the id of the person you wish to edit: ")
                    tmp = Console.ReadLine()

                    Console.WriteLine("Please enter the new name: ")
                    input_name = Console.ReadLine()

                    Console.WriteLine("Please enter the new number: ")
                    input_number = Console.ReadLine()
                    If (IsNumeric(tmp) = False) Then
                        Console.WriteLine("Invalid entry. Option must be numeric. Please try again...")

                    ElseIf (tmp < 0 Or tmp > people.Count - 1) Then
                        Console.WriteLine()
                        Console.WriteLine("This id of the person you entered does not exist. Please try again...")

                    ElseIf (IsNumeric(input_name) = True) Then
                        Console.WriteLine()
                        Console.WriteLine("The name of the person must contain alphabetical letters. Please try again...")

                    ElseIf (IsNumeric(input_number) = False) Then
                        Console.WriteLine()
                        Console.WriteLine("The number that you have entered contains one or more letters. Please try again...")

                    Else
                        input_final = input_name & " " & input_number
                        person_edit(tmp, input_final)
                        Console.WriteLine()
                        Console.WriteLine("Person id number" & "[" & tmp & "]" & " has been successfully edited.")
                    End If
                End If

                'DELETE
                If (input_options = 2) Then
                    Console.WriteLine("Enter the id: ")
                    input_number = Console.ReadLine()

                    Console.WriteLine("Are you sure you want to delete person id number " & "[" & input_number & "]" & "? This change is permanent: (y/n)")
                    tmp = Console.ReadLine()

                    If (input_number < 0 Or input_number > people.Count - 1) Then
                        Console.WriteLine()
                        Console.WriteLine("Id number does not exist. Please try again...")
                    Else
                        If (tmp = "n") Then
                            Console.WriteLine()
                            Console.WriteLine("No changes were made...")

                        ElseIf (tmp = "y") Then
                            Console.WriteLine()
                            person_delete(input_number)
                            Console.WriteLine("person id number" & "[" & input_number & "]" & " has been successfully deleted .")
                        Else
                            Console.WriteLine()
                            Console.WriteLine("Invalid entry. Resuming to options screen...")
                        End If
                    End If
                End If

                'DISPLAY
                If (input_options = 3) Then
                    person_show()
                End If

                'EXIT
                If (input_options = 4) Then
                    person_goodbye()
                End If
            End If
        End While


        Console.Read()

    End Sub

    ''' <summary>
    ''' This function adds items to the option arraylist
    ''' </summary>
    Private Sub option_items()
        options.Add("Add")
        options.Add("Edit")
        options.Add("Delete")
        options.Add("Display")
        options.Add("Exit")
    End Sub

    ''' <summary>
    ''' 'This functions pre-populates arraylist with names and numbers
    ''' </summary>
    Private Sub person_tmp()
        people.Add("George 555-5555")
        people.Add("Lucy 444-4444")
        people.Add("Melissa 666-6666")
        people.Add("David 777-7777")
    End Sub

    ''' <summary>
    ''' This functions display the options menu to the user
    ''' </summary>
    Private Sub menu_display()
        Console.WriteLine(vbNewLine)
        For i As Integer = 0 To options.Count - 1
            Console.WriteLine("[" & i & "]" & options(i))
        Next
    End Sub

    ''' <summary>
    ''' This function displays the phonebook
    ''' </summary>
    Private Sub person_show()
        For i As Integer = 0 To people.Count - 1
            Console.WriteLine("id:(" & i & ") " & people(i))
        Next
    End Sub

    ''' <summary>
    ''' This function adds a new person to the phonebook
    ''' </summary>
    ''' <param name="var"> This parameter is the users input variable</param>
    Private Sub person_add(ByRef var As String)
        people.Add(var)
    End Sub

    ''' <summary>
    ''' This function delete an existing person from the phonebook
    ''' </summary>
    ''' <param name="var">This Parameter is the users selected index position</param>
    Private Sub person_delete(ByVal var As Integer)
        people.RemoveAt(var)
    End Sub

    ''' <summary>
    ''' This function edits an existing person in the phonebook
    ''' </summary>
    ''' <param name="var">This parameter is the index position selected by the user</param>
    ''' <param name="input">This parameter is the new name and number replacing old values</param>
    Private Sub person_edit(ByRef var As Integer, ByVal input As String)
        people.RemoveAt(var)
        people.Insert(var, input)
    End Sub

    ''' <summary>
    ''' Greets the user and displays the menu
    ''' </summary>
    Private Sub person_greet()
        Console.WriteLine()
        Console.WriteLine("Please select one of the following options: ")
    End Sub

    ''' <summary>
    ''' This function halts the program
    ''' </summary>
    Private Sub person_goodbye()
        Console.WriteLine(vbNewLine)
        Console.WriteLine("This program will now terminate. Goodbye...")
        bool = False
    End Sub

End Module
