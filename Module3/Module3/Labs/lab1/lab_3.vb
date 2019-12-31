Module lab_3
    Sub main()

        'declaring variables
        Dim input_item As String, input_quantity As String, result As String
        Dim bool As Boolean = True


        While (bool)
            Console.WriteLine("Please select any of the following items below. ex: 1, 2, 3 etc...")
            Console.WriteLine(menu_items())
            input_item = Console.ReadLine()

            'check if item selected is a number
            If (IsNumeric(input_item)) Then

                If (input_item = 1) Then
                    input_item = 10.99

                    'ask the user for the quantity
                    Console.WriteLine("Please select a quantity.")
                    input_quantity = Console.ReadLine()

                    'check if item quantity is an number 
                    If (IsNumeric(input_quantity)) Then
                        If (IsNumeric(input_quantity) And input_quantity >= 1 And input_quantity <= 15) Then
                            result = input_item * input_quantity
                            Console.WriteLine("item 1: " & "$" & input_item & " | " & "quantity: " & input_quantity & " | " & "Total: " & "$" & result)
                            Console.WriteLine()

                            'ask user if he/she would like to continue
                            Console.WriteLine("Would you like to select a new item? y/n")
                            Dim answer As String = Console.ReadLine()
                            If (answer.ToLower() = "y") Then
                            ElseIf (answer.ToLower() = "n") Then
                                Console.WriteLine("Porgram terminated. Goodbye!")
                                bool = False
                            Else
                                Console.WriteLine()
                                Console.WriteLine("Invalid entry. Porgram restarting...")
                            End If
                        Else
                            Console.WriteLine("Invalid entry for quantity. Please try again.")
                            Console.WriteLine()
                        End If
                    End If
                End If


                If (input_item = 2) Then
                    input_item = 5.66

                    'ask the user for the quantity
                    Console.WriteLine("Please select a quantity.")
                    input_quantity = Console.ReadLine()

                    'check if the item quantity is a number
                    If (IsNumeric(input_quantity)) Then
                        If (IsNumeric(input_quantity) And input_quantity >= 1 And input_quantity <= 15) Then
                            result = input_item * input_quantity
                            Console.WriteLine("item 2: " & "$" & input_item & " | " & "quantity: " & input_quantity & " | " & "Total: " & "$" & result)
                            Console.WriteLine()

                            'ask user if he/she would like to continue
                            Console.WriteLine("Would you like to select a new item? y/n")
                            Dim answer As String = Console.ReadLine()
                            If (answer.ToLower() = "y") Then
                            ElseIf (answer.ToLower() = "n") Then
                                Console.WriteLine("Porgram terminated. Goodbye!")
                                bool = False
                            Else
                                Console.WriteLine()
                                Console.WriteLine("Invalid entry. Porgram restarting...")
                            End If
                        Else
                            Console.WriteLine("Invalid entry for quantity. Please try again.")
                            Console.WriteLine()
                        End If
                    End If
                End If

                If (input_item = 3) Then
                    input_item = 7.65
                    'ask the user for the quantity

                    Console.WriteLine("Please select a quantity.")
                    input_quantity = Console.ReadLine()

                    'check if item quantity is an number 
                    If (IsNumeric(input_quantity)) Then
                        If (IsNumeric(input_quantity) And input_quantity >= 1 And input_quantity <= 15) Then
                            result = input_item * input_quantity
                            Console.WriteLine("item 3: " & "$" & input_item & " | " & "quantity: " & input_quantity & " | " & "Total: " & "$" & result)
                            Console.WriteLine()

                            'ask user if he/she would like to continue
                            Console.WriteLine("Would you like to select a new item? y/n")
                            Dim answer As String = Console.ReadLine()
                            If (answer.ToLower() = "y") Then
                            ElseIf (answer.ToLower() = "n") Then
                                Console.WriteLine("Porgram terminated. Goodbye!")
                                bool = False
                            Else
                                Console.WriteLine()
                                Console.WriteLine("Invalid entry. Porgram restarting...")
                            End If
                        Else
                            Console.WriteLine("Invalid entry for quantity. Please try again.")
                        End If
                    End If
                End If

                If (input_item = 4) Then
                    input_item = 8.64

                    'ask the user for the quantity
                    Console.WriteLine("Please select a quantity.")
                    input_quantity = Console.ReadLine()

                    'check if item quantity is an number 
                    If (IsNumeric(input_quantity)) Then
                        If (IsNumeric(input_quantity) And input_quantity >= 1 And input_quantity <= 15) Then
                            result = input_item * input_quantity
                            Console.WriteLine("item 4: " & "$" & input_item & " | " & "quantity: " & input_quantity & " | " & "Total: " & "$" & result)
                            Console.WriteLine()

                            'ask user if he/she would like to continue
                            Console.WriteLine("Would you like to select a new item? y/n")
                            Dim answer As String = Console.ReadLine()
                            If (answer.ToLower() = "y") Then
                            ElseIf (answer.ToLower() = "n") Then
                                Console.WriteLine("Porgram terminated. Goodbye!")
                                bool = False
                            Else
                                Console.WriteLine()
                                Console.WriteLine("Invalid entry. Porgram restarting...")
                            End If
                        Else
                            Console.WriteLine("Invalid entry for quantity. Please try again.")
                            Console.WriteLine()
                        End If
                    End If
                End If

                    If (input_item = 5) Then
                    input_item = 5.0

                    'ask the user for the quantity
                    Console.WriteLine("Please select a quantity.")
                    input_quantity = Console.ReadLine()

                    'check if item quantity is an number 
                    If (IsNumeric(input_quantity)) Then
                        If (IsNumeric(input_quantity) And input_quantity >= 1 And input_quantity <= 15) Then
                            result = input_item * input_quantity
                            Console.WriteLine("item 5: " & "$" & input_item & " | " & "quantity: " & input_quantity & " | " & "Total: " & "$" & result)
                            Console.WriteLine()

                            'ask user if he/she would like to continue
                            Console.WriteLine("Would you like to select a new item? y/n")
                            Dim answer As String = Console.ReadLine()
                            If (answer.ToLower() = "y") Then
                            ElseIf (answer.ToLower() = "n") Then
                                Console.WriteLine("Porgram terminated. Goodbye!")
                                bool = False
                            Else
                                Console.WriteLine()
                                Console.WriteLine("Invalid entry. Porgram restarting...")
                            End If
                        Else
                            Console.WriteLine("Invalid entry for quantity. Please try again.")
                            Console.WriteLine()
                        End If
                    End If
                End If

                    If (input_item = 6) Then
                    input_item = 7.2

                    'ask the user for the quantity
                    Console.WriteLine("Please select a quantity.")
                    input_quantity = Console.ReadLine()

                    'check if item quantity is an number 
                    If (IsNumeric(input_quantity)) Then
                        If (IsNumeric(input_quantity) And input_quantity >= 1 And input_quantity <= 15) Then
                            result = input_item * input_quantity
                            Console.WriteLine("item 6: " & "$" & input_item & " | " & "quantity: " & input_quantity & " | " & "Total: " & "$" & result)
                            Console.WriteLine()

                            'ask user if he/she would like to continue
                            Console.WriteLine("Would you like to select a new item? y/n")
                            Dim answer As String = Console.ReadLine()
                            If (answer.ToLower() = "y") Then
                            ElseIf (answer.ToLower() = "n") Then
                                Console.WriteLine("Porgram terminated. Goodbye!")
                                bool = False
                            Else
                                Console.WriteLine()
                                Console.WriteLine("Invalid entry. Porgram restarting...")
                            End If
                        Else
                            Console.WriteLine("Invalid entry for quantity. Please try again.")
                            Console.WriteLine()
                        End If
                    End If
                End If

                    If (input_item = 7) Then
                    input_item = 10.0

                    'ask the user for the quantity
                    Console.WriteLine("Please select a quantity.")
                    input_quantity = Console.ReadLine()

                    'check if item quantity is an number 
                    If (IsNumeric(input_quantity)) Then
                        If (IsNumeric(input_quantity) And input_quantity >= 1 And input_quantity <= 15) Then
                            result = input_item * input_quantity
                            Console.WriteLine("item 7: " & "$" & input_item & " | " & "quantity: " & input_quantity & " | " & "Total: " & "$" & result)
                            Console.WriteLine()

                            'ask user if he/she would like to continue
                            Console.WriteLine("Would you like to select a new item? y/n")
                            Dim answer As String = Console.ReadLine()
                            If (answer.ToLower() = "y") Then
                            ElseIf (answer.ToLower() = "n") Then
                                Console.WriteLine("Porgram terminated. Goodbye!")
                                bool = False
                            Else
                                Console.WriteLine()
                                Console.WriteLine("Invalid entry. Porgram restarting...")
                            End If
                        Else
                            Console.WriteLine("Invalid entry for quantity. Please try again.")
                            Console.WriteLine()
                        End If
                    End If
                End If
                Else
                Console.WriteLine("invalid entry. Please try again (be sure to select a number).")
                Console.WriteLine()
            End If



        End While

        Console.Read()

    End Sub


    Function menu_items() As String
        Dim items As String
        items = "item 1 : 10.99 " & vbCrLf & "item 2 : 5.66 " & vbCrLf & "item 3 : 7.65 " & vbCrLf & "item 4 : 8.64 " & vbCrLf & "item 5 : 5.00 " & vbCrLf & "items 6 : 7.20 " & vbCrLf & "items 7 : 10.00"
        Return items
    End Function


End Module
