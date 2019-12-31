Module question3

    'Global variable declaration
    Dim bool As Boolean = True
    Dim people(1, 4) As String
    Dim input_menu As String
    Dim input_number As String
    Dim input_index As String
    Dim input_name As String
    Dim input_final As String
    Dim counter As Integer = 5
    Dim menu() As String = {"1.Add", "2.Delete", "3.Edit", "4.Show", "5.Exit"}

    Sub main()



        'Pre-Populating the phonebook with users
        people(0, 0) = "David - "
        people(1, 0) = "111-1111"
        people(0, 1) = "Lucy - "
        people(1, 1) = "222-2222"
        people(0, 2) = "Peter - "
        people(1, 2) = "999-9999"
        people(0, 3) = "Britany - "
        people(1, 3) = "333-3333"
        people(0, 4) = "Terrance - "
        people(1, 4) = "555-5555"



        While (bool)

            Console.WriteLine(vbNewLine)
            Console.WriteLine("Please select one of the following options below: ")
            Console.WriteLine()

            'shows the menu
            show_menu()

            input_menu = Console.ReadLine()

            If (input_menu <= 0 Or input_menu > 5) Then
                Console.WriteLine()
                Console.WriteLine("Invalid entry. Please try again..." & vbNewLine)
            Else
                If (input_menu = 1) Then

                    Console.WriteLine("Please enter the name you wish to add: ")
                    input_name = Console.ReadLine()
                    Console.WriteLine("Please enter the number associated with this name: ")
                    input_number = Console.ReadLine()

                    If (IsNumeric(input_name) = True Or input_name = "") Then
                        Console.WriteLine("Invalid entry. Name must contain alphabetical letters. Please try again...")
                    ElseIf (IsNumeric(input_number) = False) Then
                        Console.WriteLine("Invalid entry. Phone number must include numeric values. Pease try again...")
                    ElseIf (input_number.length > 10) Then
                        Console.WriteLine("Invalid entry. Too many numbers! Please try again...")
                    Else
                        ReDim Preserve people(1, counter)
                        input_name += " - "
                        people(0, counter) = input_name
                        people(1, counter) = input_number
                        counter += 1
                    End If

                End If

                    If (input_menu = 2) Then
                    show_phonebook()
                    Console.WriteLine(vbNewLine)
                    Console.WriteLine("Please select the person you would like to delete: ")
                    input_index = Console.ReadLine()
                    If (IsNumeric(input_index) = False) Then
                        Console.WriteLine("Entry must be numeric. Please try again...")
                    ElseIf (input_index < 0 Or input_index > counter) Then
                        Console.WriteLine("Invalid entry. Please make sure to select one of the following numbers for proper deletion.")
                    Else
                        Console.WriteLine()
                        Console.WriteLine(people(0, input_index) & " has been successfully deleted.")

                        people(0, input_index) = ""
                        people(1, input_index) = ""
                    End If
                End If

                If (input_menu = 3) Then

                    Console.WriteLine(vbNewLine)
                    show_phonebook()
                    Console.WriteLine(vbNewLine)

                    Console.WriteLine("Select the number associated with the person you wish to edit: ")
                    input_index = Console.ReadLine()
                    If (IsNumeric(input_index) = False) Then
                        Console.WriteLine()
                        Console.WriteLine("Invalid entry. Please try again...")

                    ElseIf (input_index < 0 Or input_index > counter) Then
                        Console.WriteLine()
                        Console.WriteLine(counter)
                        Console.WriteLine("This number does not exist. Please try again...")

                    Else
                        Console.WriteLine("Please enter the new name: ")
                        input_name = Console.ReadLine()
                        Console.WriteLine("Please enter the number associated with this new name: ")
                        input_number = Console.ReadLine()

                        If (IsNumeric(input_number) = False) Then
                            Console.WriteLine("invalid phone number. Please try again...")
                        Else
                            Console.WriteLine(people(0, input_index) & " has been successfully edited.")
                            people(0, input_index) = input_name + " - "
                            people(1, input_index) = input_number
                        End If
                    End If
                    End If

                If (input_menu = 4) Then
                    Console.WriteLine()
                    show_phonebook()
                End If

                If (input_menu = 5) Then
                    Console.WriteLine("This program will now terminate. Goodbye...")
                    bool = False
                End If
            End If
        End While


        Console.Read()

    End Sub

    ''' <summary>
    ''' Shows all phonebook entries
    ''' </summary>
    Private Sub show_phonebook()
        Console.WriteLine("||====== Phonebook ======||")
        For i = 0 To people.GetUpperBound(1)
            Console.WriteLine()
            For j = 0 To people.GetUpperBound(0)
                Console.Write(i & ". " & people(j, i))
            Next
        Next
    End Sub

    ''' <summary>
    ''' Shows all menu options
    ''' </summary>
    Private Sub show_menu()
        For Each i As String In menu
            Console.WriteLine(i)
        Next
    End Sub
End Module
