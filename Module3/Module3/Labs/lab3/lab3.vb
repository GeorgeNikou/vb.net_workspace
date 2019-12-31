Module lab3

    'lab 3 variables
    Dim main_input_option As String
    Dim main_bool As Boolean = True

    'lab 1 (get the average) variables
    Dim invalid_lab1 As String = "Invalid entry. Please try again."
    Dim num1_lab1 As String, num2 As String, num3 As String

    ' lab 2 (Calculator) variables
    Dim var1_lab2 As String, var2_lab2 As String
    Dim input2_lab2 As String

    ' lab3 (Cash Register) variables
    Dim input_item_lab3 As String, input_quantity_lab3 As String, result_lab3 As String

    ' lab 4 (Christmas tree (Happy hanuka)) variables
    Dim user_input_lab4 As String
    Dim row_lab4 As Integer = 0
    Dim tmp_lab4 As Integer = 1
    Dim count_lab4 As Integer = 1
    Dim num_stars_lab4 As Integer
    Dim total_lab4 As Integer

    ' lab 5 (item menu) variables
    Dim menu_items_q1b As ArrayList = New ArrayList
    Dim user_input_q1b As String
    Dim item_name_q1b As String
    Dim item_price_q1b As String
    Dim item_stock_q1b As String
    Dim tmp_q1b As String

    'lab6 (number to letters) variables
    Dim input_q2b As String

    ' lab7 (phonebook) variables
    Dim people As New ArrayList
    Dim options As New ArrayList
    Dim input_options As String
    Dim input_name As String
    Dim input_number As String
    Dim input_final As String
    Dim tmp As String

    Dim switch As Boolean
    Sub main()



        'Pre-adding items to menu items program
        menu_items_q1b.Add("Kebab  9.99  5")
        menu_items_q1b.Add("Beef  6.99  7")
        menu_items_q1b.Add("Kebab  4.0  9")
        menu_items_q1b.Add("Beer  0.99  10")

        'Pre-adding people to phonebook program
        people.Add("George 555-5555")
        people.Add("Lucy 444-4444")
        people.Add("Melissa 666-6666")
        people.Add("David 777-7777")

        ' adding option items to phonebook program
        options.Add("Add")
        options.Add("Edit")
        options.Add("Delete")
        options.Add("Display")
        options.Add("Exit")


        While (main_bool)
            switch = True
            color_revert()
            show_main_menu()
            main_input_option = Console.ReadLine()

            If (IsNumeric(main_input_option) = False) Then
                color_error()
                Console.WriteLine("Invalid entry. User input must be a number...")
                System.Threading.Thread.Sleep(2000)

            ElseIf (main_input_option < 1 Or main_input_option > 8) Then
                color_error()
                Console.WriteLine("Option does not exist. Please try again...")
                System.Threading.Thread.Sleep(2000)

            Else
                If (main_input_option = 1) Then
                    Console.Clear()
                    lab2()
                    System.Threading.Thread.Sleep(2500)
                End If

                If (main_input_option = 2) Then
                    Console.Clear()
                    lab1()
                    System.Threading.Thread.Sleep(2500)
                End If

                If (main_input_option = 3) Then
                    Console.Clear()
                    lab4()
                    System.Threading.Thread.Sleep(2500)
                End If

                If (main_input_option = 4) Then
                    Console.Clear()
                    lab3()
                    System.Threading.Thread.Sleep(2500)
                End If

                If (main_input_option = 5) Then
                    Console.Clear()
                    lab5()
                    System.Threading.Thread.Sleep(2500)
                End If

                If (main_input_option = 6) Then
                    Console.Clear()
                    lab6()
                    System.Threading.Thread.Sleep(2500)
                End If

                If (main_input_option = 7) Then
                    Console.Clear()
                    lab7()
                    'person_show()
                    System.Threading.Thread.Sleep(4000)
                End If

                If (main_input_option = 8) Then
                    Console.WriteLine()
                    Console.WriteLine("This program will now terminate. Goodbye...")
                    System.Threading.Thread.Sleep(2000)
                    main_bool = False
                End If
            End If
        End While

    End Sub

    ''' <summary>
    ''' These functions belong to lab2 (Calculator) - BEGIN
    ''' </summary>
    ''' <returns></returns>
    Private Function menu_lab2() As String
        Dim menu_operators As String
        menu_operators = "Add | A " & vbCrLf & "Subtract | S " & vbCrLf & "Multiply | M " & vbCrLf & "Divide | D " & vbCrLf & "Modulos | Mod " & vbCrLf & "Exponent | ex " & vbCrLf & "Exit | E"
        Return menu_operators
    End Function
    Private Function add(num1 As Double, num2 As Double) As Double
        Dim result As Double
        result = num1 + num2
        Return result
    End Function
    Private Function subtract(num1 As Double, num2 As Double) As Double
        Dim result As Double
        result = num1 - num2
        Return result
    End Function
    Private Function multiply(num1 As Double, num2 As Double) As Double
        Dim result As Double
        result = num1 * num2
        Return result
    End Function
    Private Function divide(num1 As Double, num2 As Double) As Double
        Dim result As Double
        result = num1 / num2
        Return result
    End Function
    Private Function modulo(num1 As Double, num2 As Double) As Double
        Dim result As Double
        result = num1 Mod num2
        Return result
    End Function
    Private Function exponent(num1 As Double, num2 As Double) As Double
        Dim result As Double
        result = num1 ^ num2
        Return result
    End Function
    ''' These functions belong to lab2 (Calculator) - END

    ''' <summary>
    ''' This function shows the menu of items available
    ''' </summary>
    Private Sub show_menu()
        Console.WriteLine()
        Console.WriteLine("||====== MENU =====||")
        Console.WriteLine()
        For i = 0 To menu_items_q1b.Count - 1
            Console.WriteLine("Item " & i + 1 & " " & menu_items_q1b(i))
        Next
    End Sub

    ''' <summary>
    ''' This function calls the main menu to the console
    ''' </summary>
    Private Sub show_main_menu()

        Dim main_menu() As String = {"Calculator",
                                    "Average Numbers",
                                    "Christmas Tree",
                                    "Cash Register",
                                    "Food menu",
                                    "Number conversion",
                                    "Phonebook", "Exit"
                                    }

        Console.WriteLine("Please choose from the following options: ")
        Console.WriteLine()

        For i = 0 To main_menu.Length - 1
            Console.WriteLine(i + 1 & ". " & main_menu(i))
        Next

    End Sub

    ''' <summary>
    ''' Changes the console text color to red
    ''' </summary>
    Private Sub color_error()
        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.Red
        Console.Clear()
    End Sub

    ''' <summary>
    ''' changes the console text color to original
    ''' </summary>
    Private Sub color_revert()
        Console.ForegroundColor = ConsoleColor.White
        Console.Clear()
    End Sub

    ''' <summary>
    ''' This functions runs the average program
    ''' </summary>
    Private Sub lab1()
        Console.WriteLine("Please enter the first number: ")
        num1_lab1 = Console.ReadLine()
        Console.WriteLine("Please enter the second number: ")
        num2 = Console.ReadLine()
        Console.WriteLine("Please enter the third number: ")
        num3 = Console.ReadLine()

        If (IsNumeric(num1_lab1) And IsNumeric(num2) And IsNumeric(num3)) Then
            Console.WriteLine("First number: " & num1_lab1 & "  |  " & " Second number: " & num2 & "  |  " & " Third number: " & num3)
            Console.Write("Average: " & calculate_average(num1_lab1, num2, num3))
        Else
            Console.WriteLine(invalid_lab1)
        End If
    End Sub

    ''' <summary>
    ''' This functions runs the calculator program
    ''' </summary>
    Private Sub lab2()
        Console.WriteLine("Please select a letter corresponding to an operation.")
        Console.WriteLine()
        Console.WriteLine(menu_lab2())

        Dim input As String = Console.ReadLine()

        'Checks the users input option for select menu
        If (input.ToLower() = "a") Then
            Console.WriteLine("Please select a number: ")
            var1_lab2 = Console.ReadLine()
            Console.WriteLine("Please select a second number: ")
            var2_lab2 = Console.ReadLine()

            If (IsNumeric(var1_lab2) And IsNumeric(var2_lab2)) Then
                Console.WriteLine("Chosen operation (Addition) " & var1_lab2 & " + " & var2_lab2 & " = " & add(var1_lab2, var2_lab2))
            Else
                Console.WriteLine("Invalid entry. Your choices must be a number between 0 - 99")
            End If
        End If

        If (input.ToLower() = "s") Then
            Console.WriteLine("Please select a number: ")
            var1_lab2 = Console.ReadLine()
            Console.WriteLine("Please select a second number: ")
            var2_lab2 = Console.ReadLine()
            If (IsNumeric(var1_lab2) And IsNumeric(var2_lab2)) Then
                Console.WriteLine("Chosen operation (Subtraction) " & var1_lab2 & " - " & var2_lab2 & " = " & subtract(var1_lab2, var2_lab2))
                Console.WriteLine()
            Else
                Console.WriteLine("Invalid entry. Your choices must be a number between 0 - 99")
            End If
        End If


        If (input.ToLower() = "m") Then
            Console.WriteLine("Please select a number: ")
            var1_lab2 = Console.ReadLine()
            Console.WriteLine("Please select a second number: ")
            var2_lab2 = Console.ReadLine()
            If (IsNumeric(var1_lab2) And IsNumeric(var2_lab2)) Then
                Console.WriteLine("Chosen operation (Multiplication) " & var1_lab2 & " * " & var2_lab2 & " = " & multiply(var1_lab2, var2_lab2))
                Console.WriteLine()
            Else
                Console.WriteLine("Invalid entry. Your choices must be a number between 0 - 99")
            End If
        End If

        If (input.ToLower() = "d") Then
            Console.WriteLine("Please select a number: ")
            var1_lab2 = Console.ReadLine()
            Console.WriteLine("Please select a second number: ")
            var2_lab2 = Console.ReadLine()
            If (IsNumeric(var1_lab2) And IsNumeric(var2_lab2)) Then
                Console.WriteLine("Chosen operation (Divide) " & var1_lab2 & " / " & var2_lab2 & " = " & divide(var1_lab2, var2_lab2))
                Console.WriteLine()
            Else
                Console.WriteLine("Invalid entry. Your choices must be a number between 0 - 99")
            End If
        End If

        If (input.ToLower() = "mod") Then
            Console.WriteLine("Please select a number: ")
            var1_lab2 = Console.ReadLine()
            Console.WriteLine("Please select a second number: ")
            var2_lab2 = Console.ReadLine()
            If (IsNumeric(var1_lab2) And IsNumeric(var2_lab2)) Then
                Console.WriteLine("Chosen operation (Modulo) " & var1_lab2 & " modulo " & var2_lab2 & " = " & modulo(var1_lab2, var2_lab2))
                Console.WriteLine()
            Else
                Console.WriteLine("Invalid entry. Your choices must be a number between 0 - 99")
            End If
        End If

        If (input.ToLower() = "ex") Then
            Console.WriteLine("Please select a number: ")
            var1_lab2 = Console.ReadLine()
            Console.WriteLine("Please select a second number: ")
            var2_lab2 = Console.ReadLine()
            If (IsNumeric(var1_lab2) And IsNumeric(var2_lab2)) Then
                Console.WriteLine("Chosen operation (Exponent) " & var1_lab2 & " ^ " & var2_lab2 & " = " & exponent(var1_lab2, var2_lab2))
                Console.WriteLine()
            Else
                Console.WriteLine("Invalid entry. Your choices must be a number between 0 - 99")
            End If
        End If

        If (input.ToLower() = "e") Then
            Console.WriteLine("You have exited my crappy program. Goodbye!")
        End If

        'validates if the user entered a letter thats does not match the menu provided
        If (input.ToLower() <> "a" And input.ToLower() <> "s" And input.ToLower() <> "m" And input.ToLower() <> "d" And input.ToLower() <> "ex" And input.ToLower() <> "mod" And input.ToLower() <> "e") Then
            Console.WriteLine("Clearly you're an incompetent moron who cannot read between the lines. Go away...")
        End If
    End Sub

    ''' <summary>
    ''' This functions runs the cash register program
    ''' </summary>
    Private Sub lab3()
        While (switch)

            Console.WriteLine("Please select any of the following items below. ex: 1, 2, 3 etc...")
            Console.WriteLine(menu_items())
            input_item_lab3 = Console.ReadLine()

            'check if item selected is a number
            If (IsNumeric(input_item_lab3)) Then

                If (input_item_lab3 = 1) Then
                    input_item_lab3 = 10.99

                    'ask the user for the quantity
                    Console.WriteLine("Please select a quantity.")
                    input_quantity_lab3 = Console.ReadLine()

                    'check if item quantity is an number 
                    If (IsNumeric(input_quantity_lab3)) Then
                        If (IsNumeric(input_quantity_lab3) And input_quantity_lab3 >= 1 And input_quantity_lab3 <= 15) Then
                            result_lab3 = input_item_lab3 * input_quantity_lab3
                            Console.WriteLine("item 1: " & "$" & input_item_lab3 & " | " & "quantity: " & input_quantity_lab3 & " | " & "Total: " & "$" & result_lab3)
                            Console.WriteLine()
                        Else
                            Console.WriteLine("Invalid entry for quantity. Please try again.")
                            Console.WriteLine()
                        End If
                    End If
                End If


                If (input_item_lab3 = 2) Then
                    input_item_lab3 = 5.66

                    'ask the user for the quantity
                    Console.WriteLine("Please select a quantity.")
                    input_quantity_lab3 = Console.ReadLine()

                    'check if the item quantity is a number
                    If (IsNumeric(input_quantity_lab3)) Then
                        If (IsNumeric(input_quantity_lab3) And input_quantity_lab3 >= 1 And input_quantity_lab3 <= 15) Then
                            result_lab3 = input_item_lab3 * input_quantity_lab3
                            Console.WriteLine("item 2: " & "$" & input_item_lab3 & " | " & "quantity: " & input_quantity_lab3 & " | " & "Total: " & "$" & result_lab3)
                            Console.WriteLine()
                        Else
                            Console.WriteLine("Invalid entry for quantity. Please try again.")
                            Console.WriteLine()
                        End If
                    End If
                End If

                If (input_item_lab3 = 3) Then
                    input_item_lab3 = 7.65
                    'ask the user for the quantity

                    Console.WriteLine("Please select a quantity.")
                    input_quantity_lab3 = Console.ReadLine()

                    'check if item quantity is an number 
                    If (IsNumeric(input_quantity_lab3)) Then
                        If (IsNumeric(input_quantity_lab3) And input_quantity_lab3 >= 1 And input_quantity_lab3 <= 15) Then
                            result_lab3 = input_item_lab3 * input_quantity_lab3
                            Console.WriteLine("item 3: " & "$" & input_item_lab3 & " | " & "quantity: " & input_quantity_lab3 & " | " & "Total: " & "$" & result_lab3)
                            Console.WriteLine()
                        Else
                            Console.WriteLine("Invalid entry for quantity. Please try again.")
                        End If
                    End If
                End If

                If (input_item_lab3 = 4) Then
                    input_item_lab3 = 8.64

                    'ask the user for the quantity
                    Console.WriteLine("Please select a quantity.")
                    input_quantity_lab3 = Console.ReadLine()

                    'check if item quantity is an number 
                    If (IsNumeric(input_quantity_lab3)) Then
                        If (IsNumeric(input_quantity_lab3) And input_quantity_lab3 >= 1 And input_quantity_lab3 <= 15) Then
                            result_lab3 = input_item_lab3 * input_quantity_lab3
                            Console.WriteLine("item 4: " & "$" & input_item_lab3 & " | " & "quantity: " & input_quantity_lab3 & " | " & "Total: " & "$" & result_lab3)
                            Console.WriteLine()
                        Else
                            Console.WriteLine("Invalid entry for quantity. Please try again.")
                            Console.WriteLine()
                        End If
                    End If
                End If

                If (input_item_lab3 = 5) Then
                    input_item_lab3 = 5.0

                    'ask the user for the quantity
                    Console.WriteLine("Please select a quantity.")
                    input_quantity_lab3 = Console.ReadLine()

                    'check if item quantity is an number 
                    If (IsNumeric(input_quantity_lab3)) Then
                        If (IsNumeric(input_quantity_lab3) And input_quantity_lab3 >= 1 And input_quantity_lab3 <= 15) Then
                            result_lab3 = input_item_lab3 * input_quantity_lab3
                            Console.WriteLine("item 5: " & "$" & input_item_lab3 & " | " & "quantity: " & input_quantity_lab3 & " | " & "Total: " & "$" & result_lab3)
                            Console.WriteLine()
                        Else
                            Console.WriteLine("Invalid entry for quantity. Please try again.")
                            Console.WriteLine()
                        End If
                    End If
                End If

                If (input_item_lab3 = 6) Then
                    input_item_lab3 = 7.2

                    'ask the user for the quantity
                    Console.WriteLine("Please select a quantity.")
                    input_quantity_lab3 = Console.ReadLine()

                    'check if item quantity is an number 
                    If (IsNumeric(input_quantity_lab3)) Then
                        If (IsNumeric(input_quantity_lab3) And input_quantity_lab3 >= 1 And input_quantity_lab3 <= 15) Then
                            result_lab3 = input_item_lab3 * input_quantity_lab3
                            Console.WriteLine("item 6: " & "$" & input_item_lab3 & " | " & "quantity: " & input_quantity_lab3 & " | " & "Total: " & "$" & result_lab3)
                            Console.WriteLine()
                        Else
                            Console.WriteLine("Invalid entry for quantity. Please try again.")
                            Console.WriteLine()
                        End If
                    End If
                End If

                If (input_item_lab3 = 7) Then
                    input_item_lab3 = 10.0

                    'ask the user for the quantity
                    Console.WriteLine("Please select a quantity.")
                    input_quantity_lab3 = Console.ReadLine()

                    'check if item quantity is an number 
                    If (IsNumeric(input_quantity_lab3)) Then
                        If (IsNumeric(input_quantity_lab3) And input_quantity_lab3 >= 1 And input_quantity_lab3 <= 15) Then
                            result_lab3 = input_item_lab3 * input_quantity_lab3
                            Console.WriteLine("item 7: " & "$" & input_item_lab3 & " | " & "quantity: " & input_quantity_lab3 & " | " & "Total: " & "$" & result_lab3)
                            Console.WriteLine()
                        Else
                            Console.WriteLine("Invalid entry for quantity. Please try again.")
                            Console.WriteLine()
                        End If
                    End If
                End If
            ElseIf (input_item_lab3.ToLower = "b") Then
                Console.Clear()
                Console.WriteLine("Exiting register program.")
                switch = False
            Else
                Console.WriteLine("invalid entry. Please try again (be sure to select a number).")
                Console.WriteLine()
            End If
        End While
    End Sub

    ''' <summary>
    ''' This functions runs the christmas tree program
    ''' </summary>
    Private Sub lab4()

        Console.WriteLine("Please enter a number :")
        user_input_lab4 = Console.ReadLine()
        If IsNumeric(user_input_lab4) Then
            Console.Clear()
            num_stars_lab4 = user_input_lab4

            'size of tree depends on number given by the user
            Do While total_lab4 + tmp_lab4 < num_stars_lab4
                total_lab4 = total_lab4 + tmp_lab4
                tmp_lab4 = tmp_lab4 + 2
                row_lab4 = row_lab4 + 1
            Loop

            'loop # 1
            For i = 1 To row_lab4

                'loop # 2
                For y = row_lab4 - i To 0 Step -1
                    Console.Write(" ")
                Next

                'loop # 3
                For j = 1 To count_lab4
                    Console.Write("*")
                Next

                Console.WriteLine()
                count_lab4 = count_lab4 + 2
            Next
            Console.WriteLine(" HAPPY HANUKKAH!!! ")

        Else
            Console.WriteLine("Invalid entry.")
        End If

    End Sub

    ''' <summary>
    ''' This functions runs the food menu program
    ''' </summary>
    Private Sub lab5()
        While (switch)
            'Show the menu items
            Console.Clear()
            show_menu()
            Console.WriteLine(vbNewLine)
            Console.WriteLine("Would you like to add new items to the food list? (y/n)")
            user_input_q1b = Console.ReadLine()
            If (user_input_q1b = "n") Then
                Console.WriteLine("Program will now terminate. Goodbye...")
                switch = False
            ElseIf (user_input_q1b = "y") Then

                Console.WriteLine("Please enter the new item you wish to add: ")
                item_name_q1b = Console.ReadLine()

                Console.WriteLine("Please enter the price of the item: ")
                item_price_q1b = Console.ReadLine()

                Console.WriteLine("Please enter the stock level: ")
                item_stock_q1b = Console.ReadLine()

                If (IsNumeric(item_name_q1b) = True Or item_name_q1b = "") Then
                    color_error()
                    Console.Clear()
                    Console.WriteLine("Menu item cannot be numeric or empty. Please try again...")
                ElseIf (IsNumeric(item_price_q1b) = False Or item_price_q1b = "") Then
                    color_error()
                    Console.Clear()
                    Console.WriteLine("Entry must be numeric. Please try again...")
                ElseIf (IsNumeric(item_stock_q1b) = False Or item_price_q1b = "") Then
                    color_error()
                    Console.Clear()
                    Console.WriteLine("Entry must be numeric. Please try again...")
                Else
                    tmp_q1b = item_name_q1b & " " & item_price_q1b & " " & item_stock_q1b
                    menu_items_q1b.Add(tmp_q1b)
                    show_menu()
                End If
            End If
        End While
    End Sub

    ''' <summary>
    ''' this functions belongs to the number to word lab
    ''' this functions converts numbers into words
    ''' </summary>
    Private Sub lab6()
        While (switch)
            Console.WriteLine("Please enter a number to be converted to word: ")
            input_q2b = Console.ReadLine()
            If (input_q2b.ToLower = "e") Then
                Console.Clear()
            ElseIf (input_q2b = "b") Then
                switch = False
                Console.Clear()
                Console.WriteLine("Exiting the number to word program.")
            Else
            If (IsNumeric(input_q2b) = False) Then
                Console.WriteLine()
                Console.WriteLine("Invalid entry. User input must be numeric. Please try again...")
                Console.WriteLine()
            Else
                Console.WriteLine()
                Console.WriteLine("Number: " & input_q2b & "    Word: " & NumberToText(input_q2b))
                Console.WriteLine()
            End If
        End If
        End While
    End Sub

    ''' <summary>
    ''' This function runs the phonebook program
    ''' </summary>
    Private Sub lab7()
        While (switch)
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
                    switch = False
                End If
            End If
        End While
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
    End Sub

End Module
