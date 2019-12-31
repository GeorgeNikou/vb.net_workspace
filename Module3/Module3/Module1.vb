Module Module1

    Sub Main()

        Dim person1 = New student("George", "wtv@gmail.com", "555-5555", "123 fake street", "arts", "herzing")
        Dim person2 = New student("jim", "123@gmail.com", "1111111", "456 fake street", "programming", "Crapschool high")
        Dim person3 = New student("Tina", "qwdqwd@gmail.com", "666-6666", "667 fake street", "math", "Verdun garbage")



        Console.WriteLine(person1.display)
        Console.WriteLine(person2.display)
        Console.WriteLine(person3.display)

        'Dim arr = My.Resources

        Console.ReadLine()



    End Sub

End Module
