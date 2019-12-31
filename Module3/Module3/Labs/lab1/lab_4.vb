Module lab_4

    Sub main()

        '4. (a,b) Christmas Tree

        Dim bool As Boolean = True
        Dim user_input As String
        Dim row As Integer = 0
        Dim tmp As Integer = 1
        Dim count As Integer = 1

        Dim num_stars As Integer
        Dim total As Integer

        'constant validation for an integer
        While (bool)

            Console.WriteLine("Please enter a number :")
            user_input = Console.ReadLine()
            If IsNumeric(user_input) Then
                num_stars = user_input

                'size of tree depends on number given by the user
                Do While total + tmp < num_stars
                    total = total + tmp
                    tmp = tmp + 2
                    row = row + 1
                Loop

                'loop # 1
                For i = 1 To row

                    'loop # 2
                    For y = row - i To 0 Step -1
                        Console.Write(" ")
                    Next

                    'loop # 3
                    For j = 1 To count
                        Console.Write("*")
                    Next

                    Console.WriteLine()
                    count = count + 2
                Next
                Console.WriteLine(" HAPPY HANUKKAH!!! ")
                bool = False

            Else
                Console.WriteLine("Invalid entry.")
            End If
        End While

        Console.Read()

    End Sub




    Function right_side() As String
        'Right side of the christmas tree
        For i = 10 To 0 Step -1
            Console.WriteLine("*")
            For j = 10 To i Step -1
                Console.Write("*")
                If (j = 0) Then
                    Console.Write("*")
                End If
            Next
        Next
    End Function 'Right side of the christmas tree



End Module
