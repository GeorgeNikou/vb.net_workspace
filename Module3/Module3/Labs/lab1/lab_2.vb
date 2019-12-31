Module lab_2
    Sub main()


        '2. Mini Calculator

        Dim bool As Boolean = True
        Dim bool2 As Boolean = True
        Dim var1 As String, var2 As String
        Dim input2 As String



        While (bool)

            Console.WriteLine("Please select a letter corresponding to an operation.")
            Console.WriteLine()
            Console.WriteLine(menu())

            Dim input As String = Console.ReadLine()

            'Checks the users input option for select menu
            If (input.ToLower() = "a") Then
                Console.WriteLine("Please select a number: ")
                var1 = Console.ReadLine()
                Console.WriteLine("Please select a second number: ")
                var2 = Console.ReadLine()

                If (IsNumeric(var1) And IsNumeric(var2)) Then
                    Console.WriteLine("Chosen operation (Addition) " & var1 & " + " & var2 & " = " & add(var1, var2))

                    'checks if user would like to continue
                    Console.WriteLine("would you like to continue?")
                    input2 = Console.ReadLine()
                    If (input2.ToLower() <> "yes") Then
                        Console.WriteLine("This program is terminated. Goodbye!")
                        bool = False
                    End If
                Else
                    Console.WriteLine("Invalid entry. Your choices must be a number between 0 - 99")
                End If
            End If

            If (input.ToLower() = "s") Then
                Console.WriteLine("Please select a number: ")
                var1 = Console.ReadLine()
                Console.WriteLine("Please select a second number: ")
                var2 = Console.ReadLine()
                If (IsNumeric(var1) And IsNumeric(var2)) Then
                    Console.WriteLine("Chosen operation (Subtraction) " & var1 & " - " & var2 & " = " & subtract(var1, var2))
                    Console.WriteLine()

                    'checks if user would like to continue
                    Console.WriteLine("would you like to continue?")
                    input2 = Console.ReadLine()
                    If (input2.ToLower() <> "yes") Then
                        Console.WriteLine("This program is terminated. Goodbye!")
                        bool = False
                    End If
                Else
                    Console.WriteLine("Invalid entry. Your choices must be a number between 0 - 99")
                End If
            End If


            If (input.ToLower() = "m") Then
                Console.WriteLine("Please select a number: ")
                var1 = Console.ReadLine()
                Console.WriteLine("Please select a second number: ")
                var2 = Console.ReadLine()
                If (IsNumeric(var1) And IsNumeric(var2)) Then
                    Console.WriteLine("Chosen operation (Multiplication) " & var1 & " * " & var2 & " = " & multiply(var1, var2))
                    Console.WriteLine()

                    'checks if user would like to continue
                    Console.WriteLine("would you like to continue?")
                    input2 = Console.ReadLine()
                    If (input2.ToLower() <> "yes") Then
                        Console.WriteLine("This program is terminated. Goodbye!")
                        bool = False
                    End If
                Else
                    Console.WriteLine("Invalid entry. Your choices must be a number between 0 - 99")
                End If
            End If

            If (input.ToLower() = "d") Then
                Console.WriteLine("Please select a number: ")
                var1 = Console.ReadLine()
                Console.WriteLine("Please select a second number: ")
                var2 = Console.ReadLine()
                If (IsNumeric(var1) And IsNumeric(var2)) Then
                    Console.WriteLine("Chosen operation (Divide) " & var1 & " / " & var2 & " = " & divide(var1, var2))
                    Console.WriteLine()

                    'checks if user would like to continue
                    Console.WriteLine("would you like to continue?")
                    input2 = Console.ReadLine()
                    If (input2.ToLower() <> "yes") Then
                        Console.WriteLine("This program is terminated. Goodbye!")
                        bool = False
                    End If
                Else
                    Console.WriteLine("Invalid entry. Your choices must be a number between 0 - 99")
                End If
            End If

            If (input.ToLower() = "mod") Then
                Console.WriteLine("Please select a number: ")
                var1 = Console.ReadLine()
                Console.WriteLine("Please select a second number: ")
                var2 = Console.ReadLine()
                If (IsNumeric(var1) And IsNumeric(var2)) Then
                    Console.WriteLine("Chosen operation (Modulo) " & var1 & " modulo " & var2 & " = " & modulo(var1, var2))
                    Console.WriteLine()

                    'checks if user would like to continue
                    Console.WriteLine("would you like to continue?")
                    input2 = Console.ReadLine()
                    If (input2.ToLower() <> "yes") Then
                        Console.WriteLine("This program is terminated. Goodbye!")
                        bool = False
                    End If
                Else
                    Console.WriteLine("Invalid entry. Your choices must be a number between 0 - 99")
                End If
            End If

            If (input.ToLower() = "ex") Then
                Console.WriteLine("Please select a number: ")
                var1 = Console.ReadLine()
                Console.WriteLine("Please select a second number: ")
                var2 = Console.ReadLine()
                If (IsNumeric(var1) And IsNumeric(var2)) Then
                    Console.WriteLine("Chosen operation (Exponent) " & var1 & " ^ " & var2 & " = " & exponent(var1, var2))
                    Console.WriteLine()


                    'checks if user would like to continue
                    Console.WriteLine("would you like to continue?")
                    input2 = Console.ReadLine()
                    If (input2.ToLower() <> "yes") Then
                        Console.WriteLine("This program is terminated. Goodbye!")
                        bool = False
                    End If
                Else
                    Console.WriteLine("Invalid entry. Your choices must be a number between 0 - 99")
                End If
            End If

            If (input.ToLower() = "e") Then
                Console.WriteLine("You have exited my crappy program. Goodbye!")
                bool = False
            End If

            'validates if the user entered a letter thats does not match the menu provided
            If (input.ToLower() <> "a" And input.ToLower() <> "s" And input.ToLower() <> "m" And input.ToLower() <> "d" And input.ToLower() <> "ex" And input.ToLower() <> "mod" And input.ToLower() <> "e") Then
                Console.WriteLine("Clearly you're an incompetent moron who cannot read between the lines. Go away...")
                bool = False
            End If

        End While





        Console.Read()

    End Sub

    Function menu() As String
        Dim menu_operators As String
        menu_operators = "Add | A " & vbCrLf & "Subtract | S " & vbCrLf & "Multiply | M " & vbCrLf & "Divide | D " & vbCrLf & "Modulos | Mod " & vbCrLf & "Exponent | ex " & vbCrLf & "Exit | E"
        Return menu_operators
    End Function
    Function add(num1 As Double, num2 As Double) As Double
        Dim result As Double
        result = num1 + num2
        Return result
    End Function
    Function subtract(num1 As Double, num2 As Double) As Double
        Dim result As Double
        result = num1 - num2
        Return result
    End Function
    Function multiply(num1 As Double, num2 As Double) As Double
        Dim result As Double
        result = num1 * num2
        Return result
    End Function
    Function divide(num1 As Double, num2 As Double) As Double
        Dim result As Double
        result = num1 / num2
        Return result
    End Function
    Function modulo(num1 As Double, num2 As Double) As Double
        Dim result As Double
        result = num1 Mod num2
        Return result
    End Function
    Function exponent(num1 As Double, num2 As Double) As Double
        Dim result As Double
        result = num1 ^ num2
        Return result
    End Function

End Module
