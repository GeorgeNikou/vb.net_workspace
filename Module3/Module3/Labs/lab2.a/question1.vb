Module question1

    Sub main()
        'Dim arr1(3) As String
        'Dim input_item As String
        'Dim input_price As String

        'arr1(0) = "item 1"
        'arr1(1) = "item 2"
        'arr1(2) = "item 3"
        'arr1(3) = "item 4"

        'While (True)
        '    Console.WriteLine("Enter the new item.")
        '    input_item = Console.ReadLine()

        '    Console.WriteLine("Enter the items price.")
        '    input_price = Console.ReadLine()

        'ReDim Preserve arr1(arr1.Length)
        'input_item += input_price
        'arr1(arr1.Length - 1) = input_item

        '    For i = 0 To arr1.Length - 1
        '        Console.WriteLine(arr1(i))
        '    Next
        'End While

        'arr2 = {{"item 0", "5.99", "5"}, {"item 1", "7.99", "50"}, {"item 2", "3.99", "7"}, {"item 3", "9.99", "80"}}

        '---------------------------------------------------------------------------------------------------------------------


        '2D array(limited rows)
        Dim input_item As String
        Dim input_price As String
        Dim input_stock As String
        Dim count As Integer = 4
        Dim arr2(8, 2) As String
        Dim check As Boolean = True
        Dim bool2 As Boolean = True


        While (check)

            If (count <= 8) Then

                While (input_item <> "0" And input_price <> "0" And input_stock <> "0")

                    Dim bool As Boolean = True
                    Do While (bool)

                        arr2(0, 0) = "Kebab"
                        arr2(0, 1) = "9.99"
                        arr2(0, 2) = "5"

                        arr2(1, 0) = "Beef"
                        arr2(1, 1) = "6.99"
                        arr2(1, 2) = "7"

                        arr2(2, 0) = "Chicken"
                        arr2(2, 1) = "4.00"
                        arr2(2, 2) = "9"

                        arr2(3, 0) = "Beer"
                        arr2(3, 1) = "0.99"
                        arr2(3, 2) = "10"


                        'Displays the menu
                        Console.WriteLine("menu items and prices below: " & vbNewLine)
                        For i = 0 To arr2.GetUpperBound(0)
                            For j = 0 To arr2.GetUpperBound(1)
                                Console.Write(arr2(i, j) & "    ")
                            Next
                            Console.WriteLine()
                        Next
                        bool = False
                    Loop
                    Exit While
                End While


                'Requesting input for new items from the user
                Console.WriteLine("Enter the new item.")
                input_item = Console.ReadLine()

                Console.WriteLine("Enter the items price.")
                input_price = Console.ReadLine()

                Console.WriteLine("Enter the items stock level.")
                input_stock = Console.ReadLine()

                If (input_item = "" Or IsNumeric(input_item) = True Or IsNumeric(input_price) = False Or IsNumeric(input_stock) = False) Then
                    Console.WriteLine("Invalid entry. Do your job jackass")
                    input_item = "0"
                    input_price = "0"
                    input_stock = "0"
                Else
                    bool2 = False
                    'Adding users input items into the 2d array                       
                    arr2(count, 0) = input_item
                    arr2(count, 1) = input_price
                    arr2(count, 2) = input_stock
                    count += 1
                End If

                'Reaching the maximum number of items in the menu triggers a warning
            Else

                'Displays the menu
                Console.WriteLine("menu items and prices below: " & vbNewLine)
                For i = 0 To arr2.GetUpperBound(0)
                    For j = 0 To arr2.GetUpperBound(1)
                        Console.Write(arr2(i, j) & "    ")
                    Next
                    Console.WriteLine()
                Next
                Console.WriteLine("You have reached the maximum capacity for entering items.")
                check = False
            End If
        End While

        '--------------------------------------------------------------------------------------------------------------------

        'Dim arr(2, 4) As String
        'Dim input_item As String
        'Dim input_price As String
        'Dim input_stock As String
        'Dim bool As Boolean = True
        'Dim count = 4

        'arr(0, 0) = "Beer"
        'arr(1, 0) = "6.99"
        'arr(2, 0) = "5"

        'arr(0, 1) = "Cheese"
        'arr(1, 1) = "4.99"
        'arr(2, 1) = "10"

        'arr(0, 2) = "Candy"
        'arr(1, 2) = "9.90"
        'arr(2, 2) = "50"

        'arr(0, 3) = "sugar"
        'arr(1, 3) = "12.99"
        'arr(2, 3) = "2"

        'arr(0, 4) = "pickles"
        'arr(1, 4) = "0.99"
        'arr(2, 4) = "12"

        'Console.WriteLine("||===== Menu =====||")
        'Console.WriteLine()
        'For x = 0 To arr.GetUpperBound(1)
        '    For y = 0 To arr.GetUpperBound(0)
        '        Console.Write(arr(y, x) & "   ")
        '    Next
        '    Console.WriteLine()
        'Next


        'While (bool)
        '    Console.WriteLine("-------------------------")
        '    Console.WriteLine("Please enter a new item: ")
        '    input_item = Console.ReadLine()

        '    Console.WriteLine("Please enter the item's price: ")
        '    input_price = Console.ReadLine()

        '    Console.WriteLine("Please enter the total in stock: ")
        '    input_stock = Console.ReadLine()

        '    If (IsNumeric(input_item) = True Or input_item = "" Or IsNumeric(input_price) = False Or input_price = "" Or IsNumeric(input_stock) = False Or input_stock = "") Then
        '        Console.WriteLine("Invalid entry. Please try again...")
        '    Else
        '        ReDim Preserve arr(2, count + 1)
        '        arr(0, 0) = "Beer"
        '        arr(1, 0) = "6.99"
        '        arr(2, 0) = "5"

        '        arr(0, 1) = "Cheese"
        '        arr(1, 1) = "4.99"
        '        arr(2, 1) = "10"

        '        arr(0, 2) = "Candy"
        '        arr(1, 2) = "9.90"
        '        arr(2, 2) = "50"

        '        arr(0, 3) = "sugar"
        '        arr(1, 3) = "12.99"
        '        arr(2, 3) = "2"

        '        arr(0, 4) = "pickles"
        '        arr(1, 4) = "0.99"
        '        arr(2, 4) = "12"

        '        arr(0, count) = input_item
        '        arr(1, count) = input_price
        '        arr(2, count) = input_stock
        '        count += 1
        '    End If

        '    Console.WriteLine()
        '    Console.WriteLine("||===== Menu =====||")
        '    Console.WriteLine()
        '    For x = 0 To arr.GetUpperBound(1)
        '        For y = 0 To arr.GetUpperBound(0)
        '            Console.Write(arr(y, x) & "   ")
        '        Next
        '        Console.WriteLine()
        '    Next
        'End While

        Console.Read()


    End Sub

End Module
