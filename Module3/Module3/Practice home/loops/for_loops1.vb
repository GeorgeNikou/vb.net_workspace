Module for_loops1

    Sub main()

        ''global variable
        'Dim winner As String

        ''user created integer array
        'Dim array1(5) As Integer
        'array1(0) = 10
        'array1(1) = 200
        'array1(2) = 330
        'array1(3) = 450
        'array1(4) = 330400
        'array1(5) = 1890000000

        ''user created string array
        'Dim employee(5) As String
        'employee(0) = "Mary"
        'employee(1) = "Billy"
        'employee(2) = "Bob"
        'employee(3) = "Popo"
        'employee(4) = "Felicia"
        'employee(5) = "tester"

        ''declare and assign array
        'Dim declare_set_array() = {"George", "1234", "male", "1"}

        ''shows the datatype of a variable
        'Console.WriteLine(declare_set_array.GetType())

        'For i = 0 To declare_set_array.Length - 1
        '    Console.Write(declare_set_array(i))
        '    Console.WriteLine()
        'Next

        ''counts numbers array
        'For i = 0 To array1.Length - 1
        '    Console.WriteLine(array1(i))
        'Next

        'Console.WriteLine()

        ''
        'For i = 0 To employee.Length - 1
        '    If (employee(i).ToLower = "bob") Then
        '        Console.WriteLine(employee(i) & " is our favorite employee of the year! Congradulations to " & employee(i) & ".")
        '        winner = employee(i)
        '    End If
        'Next

        'Console.WriteLine(winner.ToUpper & "  " & winner.ToUpper & "  " & winner.ToUpper)

        'Console.WriteLine()


        'Dim loop_array(10) As String

        'For i = 0 To loop_array.Length - 1
        '    'Console.WriteLine("item " & i)
        '    loop_array(i) = "item" & i
        'Next

        ''display our array of items
        'For i = 0 To loop_array.Length - 1
        '    Console.WriteLine(loop_array(i))
        'Next


        Dim library1(4, 1) As String
        library1(0, 0) = "Adeventures of neverland"
        library1(0, 1) = "Josh Gram"

        library1(1, 0) = "House Creek"
        library1(1, 1) = "Melissa Burns"

        library1(2, 0) = "The Carpenter"
        library1(2, 1) = "Eric Van-Brimstein"

        library1(3, 0) = "Woodpecker"
        library1(3, 1) = "Alice Chains"

        library1(4, 0) = "The Witcher series"
        library1(4, 1) = "Tom Chanlice"

        'For i = 0 To library1.GetUpperBound(0)
        '    Console.WriteLine()
        '    For j = 0 To library1.GetUpperBound(1)
        '        If (library1(j) = "woodpecker") Then
        '            Console.WriteLine(library1(i, j))
        '        End If


        '    Next
        'Next


        'Dim library2(2, 3) As String

        'library2(0, 0) = "George"
        'library2(1, 0) = "Nikou"
        'library2(2, 0) = "12345"

        'library2(0, 1) = "David"
        'library2(1, 1) = "Manchetta"
        'library2(2, 1) = "12567"

        'library2(0, 2) = "Mel"
        'library2(1, 2) = "Bee"
        'library2(2, 2) = "9090"

        'library2(0, 3) = "Lucy"
        'library2(1, 3) = "Lu"
        'library2(2, 3) = "1111"




        'For i = 0 To library2.Length - 1
        '    Console.WriteLine()
        '    For j = 0 To 3
        '        Console.WriteLine(library2(i, j))

        '    Next
        'Next


        'lab2 number 2 done right

        Dim entry As String = "5"
        Dim one, ten As Integer

        Dim below20() As String = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "ninteen"}
        Dim tens() As String = {"", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"}

        If (entry < 20) Then
            Console.WriteLine(below20(entry))
        Else
            one = entry Mod 10
            ten = (entry - one) / 10

            Console.WriteLine(tens(ten) & " " & below20(one))

            If (one > 0) Then
                Console.WriteLine("" & below20(one))
            End If
        End If

        Console.WriteLine("one: " & one & " " & "ten: " & ten)
        Console.Read()
    End Sub

End Module
