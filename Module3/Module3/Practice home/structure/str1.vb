Module str1

    Sub main()

        Dim person1 As people
        Dim person2 As people
        Dim person3(2) As people

        ' structure loose
        person1.fname = "Mary"
        person1.lname = "Tza"
        person1.pass = 12345

        person2.fname = "Jimmy"
        person2.lname = "Baba"
        person2.pass = 123

        ' structure array
        person3(0).fname = "George"
        person3(0).lname = "Nik"
        person3(0).pass = "555"

        person3(1).fname = "Nick"
        person3(1).lname = "Amber"
        person3(1).pass = "2323"

        person3(2).fname = "Lisa"
        person3(2).lname = "lima"
        person3(2).pass = "999"


        Console.WriteLine()

        For i As Integer = 0 To person3.Length - 1
            Console.WriteLine(person3(i).fname & " " & person3(i).lname & " " & person3(i).pass & "  ")
        Next

        Console.WriteLine()
        Console.WriteLine(person1.fname & " " & person1.lname & "  password: " & person1.pass)
        Console.WriteLine(vbNewLine)
        Console.WriteLine(person2.fname & " " & person2.lname & "  password: " & person2.pass)

        Console.Read()

    End Sub

    Structure people
        Dim fname As String
        Dim lname As String
        Dim pass As Integer
    End Structure

End Module
