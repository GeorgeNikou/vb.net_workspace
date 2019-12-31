Module exam




    ' Creator: George nikou
    ' Student number: 5188029
    ' Date: 09/25/2019
    ' Elapsed  time: 5 hours
    ' Exam: Gym program
    ' incomplete: editing validation & original value upon empty user input (ran out of time), validating date format   


    ' Information needed for logging into the pre-determined members
    ' nickname: george_rocks  |  password:  12345
    ' nickname: Kitty  |  password: 54321
    ' nickname


    'Declared global boolean flow variables
    Dim member(9) As gym_member
        Dim main_switch As Boolean = True
        Dim switch As Boolean = True
        Dim switch2 As Boolean = False
        Dim switch3 As Boolean = True
        Dim switch4 As Boolean = True

        'Declare global user input variables
        Dim input_nickname As String
        Dim input_fname As String
        Dim input_lname As String
        Dim input_password As String
        Dim input_dob As String
        Dim input_address As String
        Dim input_phone_number As String
        Dim input_weight As String
        Dim input_height As String

        'Misc variables
        Dim input As String
        Dim index As Integer
        Dim tmp As String
        Dim count As Integer = 3

        'Option items array
        Dim options_array(2) As String

        Sub Main()

            'Adding 3 members to our array
            pre_add()

            While (main_switch)

                switch3 = True
                switch4 = True
                color_green()
                greet()
                System.Threading.Thread.Sleep(3000)
                color_revert()

                While (switch4)
                    Console.WriteLine("Would you like to register? If you're already a member type n to continue. (y/n)" & vbNewLine & "Type 'E' to exit.")
                    input = Console.ReadLine()

                    If (input.ToLower = "y") Then
                        'Storing user values into instanced variables
                        Console.WriteLine("Please enter your nickname: ")
                        input_nickname = Console.ReadLine()

                        Console.WriteLine("Please enter your password: ")
                        input_password = Console.ReadLine()

                        Console.WriteLine("Please enter your first name: ")
                        input_fname = Console.ReadLine()

                        Console.WriteLine("Please enter your last name: ")
                        input_lname = Console.ReadLine()

                        Console.WriteLine("Please enter your date of birth: ")
                        input_dob = Console.ReadLine()

                        Console.WriteLine("Please enter your address: ")
                        input_address = Console.ReadLine()

                        Console.WriteLine("Please enter your phone number: ")
                        input_phone_number = Console.ReadLine()

                        Console.WriteLine("Please enter your weight: ")
                        input_weight = Console.ReadLine()

                        Console.WriteLine("Please enter your height: ")
                        input_height = Console.ReadLine()


                        'Validating whether information meets requirements
                        If (input_nickname.Length < 5) Then
                            color_red()
                            Console.WriteLine("Nickname must be minimum 5 characters long.")
                            System.Threading.Thread.Sleep(2000)
                            color_revert()

                        ElseIf (input_password.Length < 5) Then
                            color_red()
                            Console.WriteLine("Password must be minimum 5 characters long.")
                            System.Threading.Thread.Sleep(2000)
                            color_revert()

                        ElseIf (input_fname.Length < 5 OrElse IsNumeric(input_fname) = True) Then
                            color_red()
                            Console.WriteLine("First name must be minimum 5 characters long.")
                            System.Threading.Thread.Sleep(2000)
                            color_revert()

                        ElseIf (input_lname.Length < 5 OrElse IsNumeric(input_lname) = True) Then
                            color_red()
                            Console.WriteLine("Last name must be minimum 5 characters long and cannot be numeric.")
                            System.Threading.Thread.Sleep(2000)
                            color_revert()

                        ElseIf (input_phone_number.Length <> 10 OrElse IsNumeric(input_phone_number) = False) Then
                            color_red()
                            Console.WriteLine("Phone number must be 10 characters and should not include dashes (-)")
                            System.Threading.Thread.Sleep(2000)
                            color_revert()

                        ElseIf (IsNumeric(input_weight) = False OrElse input_weight < 0) Then
                            color_red()
                            Console.WriteLine("Weight must be numeric and not a negative number.")
                            System.Threading.Thread.Sleep(2000)
                            color_revert()

                        ElseIf (IsNumeric(input_height) = False OrElse input_height < 0) Then
                            color_red()
                            Console.WriteLine("Height must be numeric and not a negative number.")
                            System.Threading.Thread.Sleep(2000)
                            color_revert()

                        Else
                            'Adding new user to the array
                            member(count).nickname = input_nickname
                            member(count).password = input_password
                            member(count).fname = input_fname
                            member(count).lname = input_lname
                            member(count).dob = input_dob
                            member(count).address = input_address
                            member(count).phone_num = input_phone_number
                            member(count).weight = input_weight
                            member(count).height = input_height

                            'Revising registration addition for user friendlyness
                            count += 1
                            color_green()
                            Console.WriteLine("Congratulations! " & input_fname & ", you're now registered to the Douchebag Gym. Welcome to the family of douch-baggery.")
                            input = ""
                            System.Threading.Thread.Sleep(6000)
                            color_revert()
                            switch4 = False
                        End If

                    ElseIf (input.ToLower = "n") Then
                        resuming()
                        switch4 = False

                    ElseIf (input.ToLower = "e") Then
                        color_green()
                        Console.WriteLine("This program will now exit. Goodbye and have a nice day.")
                        System.Threading.Thread.Sleep(3000)
                        color_revert()
                        switch2 = False
                        switch3 = False
                        switch4 = False
                        main_switch = False

                    Else
                        color_red()
                        Console.WriteLine("Invalid entry.")
                        System.Threading.Thread.Sleep(2000)
                        color_revert()
                    End If

                End While

                While (switch3)

                    switch3 = True
                    switch2 = False
                    switch = True

                    'login prompt the user
                    color_revert()
                    display_login()
                    Console.WriteLine("Please enter your nickname: ")
                    input_nickname = Console.ReadLine()
                    Console.WriteLine("Please enter your password: ")
                    input_password = Console.ReadLine()


                    'Attempt login - scans through array to find member and validates nickname & password
                    For i As Integer = 0 To member.Count - 1
                        If (member(i).nickname = "") Then
                            'do nothing
                        ElseIf (member(i).nickname.ToLower = input_nickname AndAlso member(i).password = input_password) Then
                            color_green()
                            Console.WriteLine("You have successfully logged in to your account. Welcome " & input_nickname)
                            input_fname = member(i).fname
                            input_lname = member(i).lname
                            index = i
                            System.Threading.Thread.Sleep(2000)
                            switch2 = True
                            switch = False
                            switch3 = False
                        End If
                    Next

                    'Invalid message loop will run only if above code did not find the user and password
                    While (switch)
                        color_red()
                        Console.WriteLine("Invalid entry")
                        System.Threading.Thread.Sleep(2000)
                        color_revert()
                        switch = False
                    End While
                End While

                'Member login information display successfully
                While (switch2)
                    color_revert()
                    Console.WriteLine("|| =================================================================================== ||")
                    Console.WriteLine("                       " & input_fname & "'s" & " Membership information")
                    Console.WriteLine("|| =================================================================================== ||")
                    Console.WriteLine()
                    display_member(input_nickname, input_password)

                    Console.WriteLine(vbNewLine)
                    Console.WriteLine()
                    Console.WriteLine("Select one of the following options below: ")
                    display_options()
                    input = Console.ReadLine()

                    'Requesting new information from the user
                    If (input = 1) Then
                        Console.Clear()

                        Console.WriteLine("Enter your kickass nickname: ")
                        input_nickname = Console.ReadLine()

                        Console.WriteLine("Enter your new password: ")
                        input_password = Console.ReadLine()

                        Console.WriteLine("Enter your first name: ")
                        input_fname = Console.ReadLine()

                        Console.WriteLine("Enter your last name: ")
                        input_lname = Console.ReadLine()

                        Console.WriteLine("Enter the address: ")
                        input_address = Console.ReadLine()

                        Console.WriteLine("Enter your phone number: ")
                        input_phone_number = Console.ReadLine()

                        Console.WriteLine("Enter your weight: ")
                        input_weight = Console.ReadLine()

                        Console.WriteLine("Enter your height: ")
                        input_height = Console.ReadLine()


                        'assigning user entered to array member array row(index)
                        member(index).nickname = input_nickname
                        member(index).password = input_password
                        member(index).fname = input_fname
                        member(index).lname = input_lname
                        member(index).dob = input_dob
                        member(index).address = input_address
                        member(index).phone_num = input_phone_number
                        member(index).weight = input_weight
                        member(index).height = input_height

                        'Reassigning updated values to instanced variables
                        input_nickname = member(index).nickname
                        input_fname = member(index).fname
                        input_lname = member(index).lname
                        input_password = member(index).password
                        input_dob = member(index).dob
                        input_address = member(index).address
                        input_phone_number = member(index).phone_num
                        input_weight = member(index).weight
                        input_height = member(index).height

                        'displaying result outcome success
                        color_green()
                        Console.WriteLine("Account has been successfully updated! Reverting to membership information now...")
                        System.Threading.Thread.Sleep(2000)
                        color_revert()

                    ElseIf (input = 2) Then
                        Console.WriteLine("For verification purposes, please enter your password: ")
                        tmp = Console.ReadLine()

                        'reassuring the user's final decision for deallocation
                        If (member(index).password = tmp) Then
                            Console.WriteLine("Are you sure you want to delete your account? These changes are permanent and cannot be reversed. (y/n)")
                            input = Console.ReadLine()

                            'Filling user account settings to empty string values (deleted)
                            If (input.ToLower = "y") Then
                                member(index).nickname = ""
                                member(index).password = ""
                                member(index).fname = ""
                                member(index).lname = ""
                                member(index).dob = ""
                                member(index).address = ""
                                member(index).phone_num = ""
                                member(index).weight = ""
                                member(index).height = ""

                                color_green()
                                Console.WriteLine("You account has been deleted successfully. We thank you for being a douchebag and hope you join us again in the future.")
                                System.Threading.Thread.Sleep(4000)
                                switch2 = False
                                color_revert()
                            Else
                                Console.WriteLine("No changes were made.")
                                System.Threading.Thread.Sleep(2000)
                            End If
                        Else
                            color_red()
                            Console.WriteLine("Inccorrect password. Please check your spelling.")
                            input = ""
                            System.Threading.Thread.Sleep(2000)
                            color_revert()
                        End If


                    ElseIf (input = 3) Then
                        color_green()
                        Console.WriteLine("Goodbye " & input_fname)
                        System.Threading.Thread.Sleep(2000)
                        switch3 = True
                        switch2 = False
                    End If

                End While

            End While

        End Sub


        ''' <summary>
        ''' This structure creates a new gym member 
        ''' </summary>
        Private Structure gym_member
            Dim nickname As String
            Dim password As String
            Dim fname As String
            Dim lname As String
            Dim dob As String
            Dim address As String
            Dim phone_num As String
            Dim weight As String
            Dim height As String
        End Structure

        ''' <summary>
        ''' This function adds a few members to the member array structure
        ''' </summary>
        Private Sub pre_add()
            member(0).nickname = "George_rocks"
            member(0).password = 12345
            member(0).fname = "George"
            member(0).lname = "thebest"
            member(0).dob = "March 28 1943"
            member(0).address = "123 street"
            member(0).phone_num = "5142666454"
            member(0).weight = 2000
            member(0).height = "67"

            member(1).nickname = "Kitty"
            member(1).password = 54321
            member(1).fname = "Kathy"
            member(1).lname = "Bombs"
            member(1).dob = "June 13 2001"
            member(1).address = "321 street"
            member(1).phone_num = "5145456698"
            member(1).weight = 110
            member(1).height = "54"

            member(2).nickname = "Billy-Bob"
            member(2).password = 45678
            member(2).fname = "Billy"
            member(2).lname = "Bob"
            member(2).dob = "April 03 1952"
            member(2).address = "456 street"
            member(2).phone_num = "5142268891"
            member(2).weight = 224
            member(2).height = "57"
        End Sub

        ''' <summary>
        ''' this function greets the user before logging in
        ''' </summary>
        Private Sub greet()
            Console.Clear()
            Console.WriteLine()
            Console.WriteLine(" || ========================================== DOUCHEBAGS ========================================= ||")
            Console.WriteLine()
            Console.WriteLine(" Welcome to Douchebag Gym. We pride ourselves on being the biggest douchebags the world has to offer! ")
            Console.WriteLine()
            Console.WriteLine("|| ================================================================================================= ||")
        End Sub

        ''' <summary>
        ''' this function checks and validates whether the user exists and is using the correct password
        ''' </summary>
        ''' <param name="nickname">"this parameter takes the users nickname and runs it in the for loop to verify its authenticity"</param>
        ''' <param name="password">this parameter takes the users passwords and verify whether it is valid</param>
        Private Sub display_member(ByVal nickname As String, ByVal password As Integer)
            For i = 0 To member.Count - 1
                If (member(i).nickname = "") Then
                    'do nothing
                ElseIf (member(i).nickname.ToLower = nickname And member(i).password = password) Then
                    Console.WriteLine("Nickname: " & member(i).nickname & vbNewLine &
                                  "Firstname: " & member(i).fname & vbNewLine &
                                  "Lastname: " & member(i).lname & vbNewLine &
                                  "d.o.b: " & member(i).dob & vbNewLine &
                                  "Address: " & member(i).address & vbNewLine &
                                  "Phone number: " & member(i).phone_num & vbNewLine &
                                  "Weight: " & member(i).weight & vbNewLine &
                                  "Height: " & member(i).height)
                End If
            Next
        End Sub


        ''' <summary>
        ''' this function displays the login page
        ''' </summary>
        Private Sub display_login()
            Console.WriteLine("||====================||")
            Console.WriteLine("||---- Login page ----||")
            Console.WriteLine("||====================||")
            Console.WriteLine(vbNewLine)
        End Sub

        ''' <summary>
        ''' this functions shows the multiple options after successful login
        ''' </summary>
        Private Sub display_options()
            Console.WriteLine(vbNewLine)

            options_array(0) = "Edit information"
            options_array(1) = "Delete account"
            options_array(2) = "Exit"

            For i = 0 To options_array.Length - 1
                Console.WriteLine(i + 1 & ". " & options_array(i))
            Next
        End Sub


        ''' <summary>
        ''' this function reverts to original foreground color of white
        ''' </summary>
        Private Sub color_revert()
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.White
        End Sub

        ''' <summary>
        ''' this function to changes the foreground color to green for success!
        ''' </summary>
        Private Sub color_green()
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
        End Sub

        ''' <summary>
        ''' this function to changes the foreground color to red indicating an error
        ''' </summary>
        Private Sub color_red()
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Red
        End Sub


        ''' <summary>
        ''' this function is purely for aesthetics and serves no other purpose
        ''' Runs a tiny animation to immerse progression
        ''' </summary>
        Private Sub resuming()
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("resuming to login.")
            System.Threading.Thread.Sleep(1000)

            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("resuming to login..")
            System.Threading.Thread.Sleep(1000)

            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("resuming to login...")
            System.Threading.Thread.Sleep(1000)

            Console.ForegroundColor = ConsoleColor.White
        End Sub




End Module
