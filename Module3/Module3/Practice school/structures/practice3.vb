Module practice3

    Dim entry As String
    Dim entry2 As String

    Sub main()
        entry = MsgBox("Please click on this button", MsgBoxStyle.YesNoCancel, "MsgBox test")

        entry2 = InputBox("Please type your name.")


        Console.WriteLine(entry)
        Console.WriteLine(entry2)
        Console.Read()
    End Sub

End Module
