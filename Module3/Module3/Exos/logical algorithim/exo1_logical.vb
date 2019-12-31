Module exo1_logical

    Dim arr() As Integer = {3, 20, 15, 7, 8, 9, 29, 1, 43}
    Dim tmp As Integer
    Dim count As Integer = 1
    Dim bool As Boolean = True

    'teachers code
    Dim data(49) As Integer

    Sub main()
        'While (bool)
        '    If (arr.Length - 1 < arr.Length) Then
        '        bool = False
        '    Else
        '        For i As Integer = 0 To arr.Length - 1
        '            If (arr(i) > arr(i + 1)) Then
        '                tmp = arr(i + 1)
        '                arr(i + 1) = arr(i)
        '                arr(i) = tmp
        '            End If
        '        Next
        '    End If
        'End While

        'For Each i In arr
        '    Console.WriteLine(i)
        'Next



        populate_array(data)
        display_array(data, "unordered array")
        sort_array(data)
        display_array(data, "ordered array")




        Console.Read()
    End Sub

    ''' <summary>
    ''' function to randomly populate the array
    ''' </summary>
    ''' <param name="data"></param>
    Private Sub populate_array(ByRef data() As Integer)
        Randomize()
        For i As Integer = 0 To data.Length - 1
            data(i) = Rnd() * 10
        Next
    End Sub


    ''' <summary>
    ''' function to display the array called data
    ''' </summary>
    ''' <param name="data"></param>
    Private Sub display_array(ByRef data() As Integer, ByVal msg As String)
        For Each i In data
            Console.Write(i & ", ")
        Next
        Console.WriteLine()
    End Sub


    Private Sub sort_array(ByRef data() As Integer)
        Dim swapped = False
        Dim temp As Integer
        Do
            swapped = False
            For i As Integer = 0 To data.Length - 2
                If (data(i) > data(i + 1)) Then
                    temp = data(i + 1)
                    data(i + 1) = data(i)
                    data(i) = temp
                    swapped = True
                End If
            Next
        Loop While swapped
    End Sub

End Module
