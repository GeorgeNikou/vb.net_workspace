Public Class Character : Inherits Label

    Private position As Point
    Private parent As Form

    Public Sub New(name As String, location As Point, image As Image, size As Size, parent As Form)
        Me.Name = name
        Me.Location = location
        Me.Image = image
        Me.Size = size
        Me.position = location
        Me.parent = parent
    End Sub


    Public Sub move(direction As String)
        Select Case direction
            Case "right"
                'Me.position.X += Me.Size.Width
                If (Me.position.X < parent.Width - 10) Then
                    Me.position.X += 30

                End If
            Case "left"
                'Me.position.X -= Me.Size.Width
                If (Me.position.X > 10) Then
                    Me.position.X -= 30

                End If
            Case "up"
                'Me.position.Y -= Me.Size.Height
                If (Me.position.Y > 10) Then
                    Me.position.Y -= 30

                End If
            Case "down"
                'Me.position.X += Me.Size.Height
                If (Me.position.Y < parent.Height - 10) Then
                    Me.position.Y += 30

                End If
        End Select
        Me.Location = position
    End Sub

End Class
