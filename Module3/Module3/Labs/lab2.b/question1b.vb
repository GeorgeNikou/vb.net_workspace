Module question1b

    'Declaing arraylist menu items
    Dim menu_items_q1b As ArrayList = New ArrayList
    Dim user_input As String
    Dim item_name As String
    Dim item_price As String
    Dim item_stock As String
    Dim tmp_q1b As String
    Dim bool As Boolean = True

    Sub main()

        'Pre-adding items to menu items arraylist 
        menu_items_q1b.Add("Kebab  9.99  5")
        menu_items_q1b.Add("Beef  6.99  7")
        menu_items_q1b.Add("Kebab  4.0  9")
        menu_items_q1b.Add("Beer  0.99  10")

        While (bool)

            'Show the menu items
            show_menu()
            Console.WriteLine(vbNewLine)
            Console.WriteLine("Would you like to add new items to my shitlist? (y/n)")
            user_input = Console.ReadLine()
            If (user_input = "n") Then
                Console.WriteLine("Program will now terminate. Goodbye...")
                bool = False

            ElseIf (user_input = "y") Then

                Console.WriteLine("Please enter the new item you wish to add: ")
                item_name = Console.ReadLine()

                Console.WriteLine("Please enter the price of the item: ")
                item_price = Console.ReadLine()

                Console.WriteLine("Please enter the stock level: ")
                item_stock = Console.ReadLine()


                If (IsNumeric(item_name) = True Or item_name = "") Then
                    Console.WriteLine("Menu item cannot be numeric or empty. Please try again...")
                ElseIf (IsNumeric(item_price) = False Or item_price = "") Then
                    Console.WriteLine("Entry must be numeric. Please try again...")
                ElseIf (IsNumeric(item_stock) = False Or item_price = "") Then
                    Console.WriteLine("Entry must be numeric. Please try again...")
                Else
                    tmp_q1b = item_name & " " & item_price & " " & item_stock
                    menu_items_q1b.Add(tmp_q1b)
                End If
            End If


        End While

        Console.Read()
    End Sub

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

End Module
