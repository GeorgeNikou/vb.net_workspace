Module structure_lab

    'auction row data
    Dim artist_name As String
    Dim picture_title As String
    Dim rank As Integer
    Dim price As String
    Dim sold As String
    Dim minimum As String
    Dim maximum As String
    Dim tmp_arr As New ArrayList
    Dim arr_count = 5
    Dim input As String
    Dim edit_price As String
    Dim edit_status As String
    Dim password As String
    Dim password_original As String
    Dim bool As Boolean = True
    Dim bool2 As Boolean = True
    Dim bool3 As Boolean = True
    Dim pass_counter As Integer
    Dim not_found As Boolean = False
    Dim a_menu() As String = {"add items", "delete items", "edit items", "display", "Min and Max items", "find item", "exit"}


    'structured auction array
    Dim auction(19) As auction_structure
    'Dim list As New List(Of auction_structure) 'tmp
    Sub main()

        'Dim test As auction_structure 'tmp
        'test.name = "George" 'tmp
        'List.Add(test) 'tmp
        'Console.WriteLine(List.Item(0).price) 'tmp


        pass_counter = 0
        password_original = 12345
        pre_fill()

        'login validation below
        While (bool)
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.White
            If (pass_counter = 3) Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.Clear()
                Console.WriteLine("You have entered an invalid password three times and therefore cannot continue.")
                Console.Read()
            Else
                Console.WriteLine("Please enter your password: ")
                password = Console.ReadLine()
                Console.WriteLine()

                If (IsNumeric(password) = False) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.Clear()
                    Console.WriteLine("Invalid entry.")
                    System.Threading.Thread.Sleep(1500)
                    pass_counter += 1

                ElseIf (password <> password_original) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.Clear()
                    Console.WriteLine("Invalid entry.")
                    System.Threading.Thread.Sleep(1500)
                    pass_counter += 1

                ElseIf (password = password_original) Then
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.Clear()
                    Console.WriteLine("you have logged in successfully. Welcome to the auction program!")
                    System.Threading.Thread.Sleep(3000)
                    bool = False
                End If
            End If
        End While

        While (bool2)
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.Clear()
            Console.WriteLine()
            auction_menu()
            Console.WriteLine(vbNewLine)
            Console.WriteLine("Please select one of the following options above: ")
            input = Console.ReadLine()

            If (IsNumeric(input) = False) Then
                Console.Clear()
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Error. Input must be numeric. Please try again.")
                System.Threading.Thread.Sleep(2000)
            Else


                If (input = 0) Then 'ADD ROW

                    Console.WriteLine("Please enter the name of the artist: ")
                    artist_name = Console.ReadLine()
                    Console.WriteLine("Please enter the picture title: ")
                    picture_title = Console.ReadLine()
                    Console.WriteLine("Please enter the rank: ")
                    rank = Console.ReadLine()
                    Console.WriteLine("Please enter the price: ")
                    price = Console.ReadLine()
                    Console.WriteLine("Please enter if the item was sold: ")
                    sold = Console.ReadLine()

                    If (IsNumeric(rank) = False) Then
                        Console.Clear()
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine("One or more user inputs was invalid. Please try again...")
                    Else

                        processing()

                        auction(arr_count).name = artist_name
                        auction(arr_count).title = picture_title
                        auction(arr_count).rank = rank
                        auction(arr_count).price = "$" & price
                        auction(arr_count).sold = sold
                        arr_count += 1

                        Console.WriteLine("Artist: " & artist_name & " has been successfully added!")
                        System.Threading.Thread.Sleep(3500)
                    End If

                ElseIf (input = 1) Then 'DELETE ROW
                    Console.Clear()
                    display()
                    Console.WriteLine(vbNewLine)
                    Console.WriteLine("Select the number you wish you delete: ")
                    input = Console.ReadLine()

                    If (auction(input - 1).sold.ToLower = "not sold") Then
                        auction(input - 1).name = ""
                        auction(input - 1).title = ""
                        auction(input - 1).rank = ""
                        auction(input - 1).price = ""
                        auction(input - 1).sold = ""

                        processing()

                        Console.Clear()
                        Console.ForegroundColor = ConsoleColor.Cyan
                        Console.WriteLine("You have successfully deleted " & " row " & input & ".")
                        System.Threading.Thread.Sleep(2000)
                    Else
                        Console.Clear()
                        Console.WriteLine("This item has been sold and therefore cannot be deleted.")
                        System.Threading.Thread.Sleep(2000)
                    End If


                ElseIf (input = 2) Then 'EDIT ROW
                    Console.Clear()
                    display()
                    Console.WriteLine(vbNewLine)
                    Console.WriteLine("Select the row you wish to edit: ")
                    input = Console.ReadLine()
                    Console.WriteLine("select the new price: ")
                    edit_price = Console.ReadLine()
                    Console.WriteLine("select the new status: ")
                    edit_status = Console.ReadLine()

                    If (auction(input - 1).sold.ToLower = "not sold") Then
                        auction(input - 1).price = "$" & edit_price
                        auction(input - 1).sold = "$" & edit_status

                        processing()

                        Console.Clear()
                        Console.ForegroundColor = ConsoleColor.Cyan
                        Console.WriteLine("You have successfully edited " & " row " & input & ".")
                        System.Threading.Thread.Sleep(2000)
                    Else
                        Console.Clear()
                        Console.WriteLine("This item has been sold and therefore cannot be edited.")
                        System.Threading.Thread.Sleep(2000)
                    End If

                ElseIf (input = 3) Then 'DISPLAY ALL ELEMENTS IN STRUCTURED ARRAY
                    Console.Clear()
                    display()
                    input = Console.ReadLine()
                    While (bool3)
                        If (input = "b") Then
                            bool3 = False
                        Else
                            Console.Clear()
                            display()
                            input = Console.ReadLine()
                        End If
                    End While
                ElseIf (input = 4) Then 'FIND MIN AND MAX PRICE

                    'add rank data into new arraylist
                    For i As Integer = 0 To auction.Length - 1
                        If (auction(i).rank = 0) Then
                            'do nothing
                        Else
                            tmp_arr.Add((auction(i).rank))
                        End If
                    Next

                    'sort new arraylist and store first (minimum) index value into variable
                    For i As Integer = 0 To tmp_arr.Count - 1
                        tmp_arr.Sort()
                        minimum = tmp_arr(i)
                        i = tmp_arr.Count - 1
                    Next

                    'stores the last (maximum) index value into variable
                    maximum = tmp_arr(tmp_arr.Count - 1)

                    Console.Clear()
                    Console.WriteLine("Minimum Rank: " & minimum & vbNewLine & "Maximum  Rank: " & maximum)

                    System.Threading.Thread.Sleep(2500)

                ElseIf (input = 5) Then  'FIND ROW BY NAME

                    bool3 = True
                    While (bool3)
                        If (input = "b") Then
                            bool3 = False
                        Else
                            Console.Clear()
                            Console.ForegroundColor = ConsoleColor.Cyan
                            Console.WriteLine("Who would you like to find? ")
                            input = Console.ReadLine()

                            If (IsNumeric(input) = True) Then
                                Console.Clear()
                                Console.ForegroundColor = ConsoleColor.Red
                                Console.WriteLine("Invalid entry. Numbers will not be accepted. Please try again.")
                                System.Threading.Thread.Sleep(2500)
                            Else
                                Console.Clear()
                                Console.ForegroundColor = ConsoleColor.Cyan
                                Try
                                    For i As Integer = 0 To auction.Length - 1
                                        If (auction(i).name.ToLower.Contains(input.ToLower)) Then
                                            Console.WriteLine(auction(i).name & "  " & auction(i).title & "  " & auction(i).rank & " " & auction(i).price & " " & auction(i).sold)
                                            i = auction.Length - 1
                                        End If
                                    Next
                                Catch ex As Exception
                                End Try

                                input = Console.ReadLine()

                            End If
                        End If
                    End While

                ElseIf (input = 6) Then
                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("exiting the auction program...")
                    System.Threading.Thread.Sleep(2000)
                    bool2 = False
                Else
                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Invalid entry. Please try again...")
                    System.Threading.Thread.Sleep(2000)
                End If
            End If
        End While

    End Sub

    ''' <summary>
    ''' this function prefills structure array with data
    ''' </summary>
    ''' <returns></returns>
    Private Function pre_fill()
        auction(0).name = "Michael Angel"
        auction(0).title = "Mon Li"
        auction(0).rank = 1
        auction(0).price = "$50,0000"
        auction(0).sold = "not sold"

        auction(1).name = "James Higher"
        auction(1).title = "the flower"
        auction(1).rank = 5
        auction(1).price = "$1000"
        auction(1).sold = "$200"

        auction(2).name = "Alysha Lowery"
        auction(2).title = "Masterpiece"
        auction(2).rank = 10
        auction(2).price = "$50,0000"
        auction(2).sold = "not sold"

        auction(3).name = "Taylor Bird"
        auction(3).title = "TheRainbow"
        auction(3).rank = 7
        auction(3).price = "$45,0000"
        auction(3).sold = "not sold"

        auction(4).name = "Robert Hockey"
        auction(4).title = "Scribble"
        auction(4).rank = 2
        auction(4).price = "$100"
        auction(4).sold = "not sold"
    End Function

    ''' <summary>
    ''' this functions displays our data
    ''' </summary>
    Private Sub display()
        Console.WriteLine("========================================================")
        Console.WriteLine(" NO " & "    " & " NAME " & "    " & " TITLE " & "    " & " RANK " & "    " & " PRICE " & "    " & " SOLD " & "    ")
        Console.WriteLine("========================================================")
        For i As Integer = 0 To auction.Length - 1
            If (auction(i).name = "") Then
                'do nothing
            Else
                Console.WriteLine(i + 1 & "." & auction(i).name & "    " & auction(i).title & "    " & auction(i).rank & "    " & auction(i).price & "    " & auction(i).sold & "    ")
            End If
        Next
    End Sub

    ''' <summary>
    ''' this is our auction data structure 
    ''' </summary>
    Structure auction_structure
        Dim name As String
        Dim title As String
        Dim rank As String
        Dim price As String
        Dim sold As String
    End Structure

    ''' <summary>
    ''' this function displays the main menu
    ''' </summary>
    Private Sub auction_menu()
        Console.WriteLine("==========================================")
        Console.WriteLine("           " & "Painting Auction Menu" & "           ")
        Console.WriteLine("==========================================")
        For i As Integer = 0 To a_menu.Length - 1
            Console.WriteLine("             " & i & ". " & a_menu(i))
        Next
    End Sub


    Private Function sort_array_function()
        tmp_arr.Sort()
        Return tmp_arr
    End Function

    Private Sub processing()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Gray
        Console.WriteLine("Processing.")
        System.Threading.Thread.Sleep(500)

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Gray
        Console.WriteLine("Processing..")
        System.Threading.Thread.Sleep(500)

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Gray
        Console.WriteLine("Processing...")
        System.Threading.Thread.Sleep(500)

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Cyan
    End Sub

End Module
