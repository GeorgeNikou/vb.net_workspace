Module console_colors


    Dim bool As Boolean = True
    Dim var1 As String
    Sub main()

        ' Console.Clear()


        While (bool)
            Console.WriteLine("Please select a color: (green:g, red: r, yellow: y, pink: p)")
            var1 = Console.ReadLine()

            Select Case var1
                Case "g"
                    Console.BackgroundColor = ConsoleColor.Green
                    Console.Clear()
                Case "r"
                    Console.BackgroundColor = ConsoleColor.Red
                    Console.Clear()
                Case "y"
                    Console.BackgroundColor = ConsoleColor.Yellow
                    Console.Clear()
                Case "p"
                    Console.BackgroundColor = ConsoleColor.Magenta
                    Console.Clear()
                Case Else
                    Console.WriteLine(vbNewLine)
                    Console.WriteLine("Invalid color. Reverting back to the main console color...")
                    Console.BackgroundColor = ConsoleColor.Black
                    Console.Clear()
            End Select
        End While


        Console.Read()
    End Sub


End Module
