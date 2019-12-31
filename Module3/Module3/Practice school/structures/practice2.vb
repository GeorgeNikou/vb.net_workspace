Module practice2

    Sub main()
        Dim book1 As book

        book1.id = 1
        book1.title = "this awesome book for george"
        book1.author = "George"
        book1.pages = 100
        book1.rate = 3


        Dim books(3) As book

        books(0).id = 1
        books(0).title = "second hand book"
        books(0).author = "George again"
        books(0).pages = 2
        books(0).rate = 10

        Console.WriteLine(books(0).title)

    End Sub

    Structure book
        Dim id As Integer
        Dim title As String
        Dim author As String
        Dim pages As String
        Dim rate As Integer
    End Structure


End Module
