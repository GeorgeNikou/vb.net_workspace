Module exo2_logical
    'teachers code
    Dim data(49) As Integer
    Sub main()

        populate_array(data)
        display_array(data, "unordered array")
        sort_array()
        display_array(data, "ordered array")
    End Sub


    Private Sub sort_array()
        Dim temp, min_index As Integer
        'loop through each index of the array
        For i = 0 To data.Length - 1
            min_index = i
            'search for the min of the array
            For j = 0 To data.Length - 1
                If (data(j) < data(min_index)) Then
                    min_index = j
                End If
            Next
            'swap
            temp = data(min_index)
            data(min_index) = data(i)
            data(i) = temp
        Next
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

End Module
