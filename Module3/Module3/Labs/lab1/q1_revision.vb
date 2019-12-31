Module q1_revision

    Dim bool_rev As Boolean = True
    Dim bool_rev2 As Boolean = True
    Dim continue_rev As String
    Dim number_rev As String = ""
    Dim input_rev As Integer = 0
    Dim sum_rev As Decimal = 0

    Sub main()

        While (bool_rev)
            red_to_default()
            Console.WriteLine("This program will take in as many numbers provided by you and add them. I will then provide you with the average rounded to two decimal places.
" & vbNewLine & "Let's get started! Please type 'c' to continue.")
            continue_rev = Console.ReadLine()
            If (continue_rev = "c") Then
                color_to_green()
                Console.WriteLine("Program initializing...")
                System.Threading.Thread.Sleep(2500)
                red_to_default()
                While (bool_rev2)
                    If (number_rev.ToLower = "e") Then
                        white_to_red()
                        Console.WriteLine("exiting now...")
                        System.Threading.Thread.Sleep(3000)
                        bool_rev2 = False
                    Else
                        Console.WriteLine("Please select the total numbers you wish to provide: ")
                        number_rev = Console.ReadLine()

                        If (IsNumeric(number_rev) = True) Then
                            For i As Integer = 1 To number_rev.ToString
                                Console.WriteLine("Please enter a number: ")
                                input_rev = Console.ReadLine()
                                sum_rev += input_rev
                            Next
                            Console.WriteLine("Sum: " & sum_rev & "  Average: " & sum_rev \ number_rev)
                            System.Threading.Thread.Sleep(3500)
                            Console.Clear()
                            sum_rev = 0
                            number_rev = 0
                        Else
                            Console.WriteLine("Invalid entry. Please try again...")
                        End If
                    End If
                End While
            ElseIf (continue_rev.ToLower = "e") Then
                Console.Clear()
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Closing...")
                System.Threading.Thread.Sleep(1000)
                bool_rev = false
            Else
                white_to_red()
                Console.WriteLine("Invalid entry. Please try again")
                System.Threading.Thread.Sleep(2000)
            End If

        End While

    End Sub


    Private Sub red_to_default()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.White
    End Sub

    Private Sub white_to_red()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Red
    End Sub

    Private Sub color_to_green()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green
    End Sub



End Module
