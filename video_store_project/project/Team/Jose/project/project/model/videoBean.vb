Public Class videoBean

    'properties
    Private _videoID As String
    Private _photo As String
    Private _title As String
    Private _year As String
    Private _country As String
    Private _language As String
    Private _length As Integer
    Private _resume As String
    Private _genre As String
    Private _actor As String
    Private _director As String
    Private _status As Integer

    Public Sub New()

    End Sub

    'constructor
    Public Sub New(videoID As String, photo As String, title As String, year As String, country As String, language As String, length As Integer, [resume] As String, genre As String, actor As String, director As String, status As Integer)
        _videoID = videoID
        _photo = photo
        _title = title
        _year = year
        _country = country
        _language = language
        _length = length
        _resume = [resume]
        _genre = genre
        _actor = actor
        _director = director
        _status = status
    End Sub

    ''' <summary>
    ''' toString method (display info)
    ''' </summary>
    ''' <returns></returns>
    Public Overrides Function ToString() As String
        Return "ID: " & _videoID & vbNewLine &
               "Title: " & _title & vbNewLine &
               "Year: " & _year & vbNewLine &
               "Country: " & _country & vbNewLine &
               "Language: " & _language & vbNewLine &
               "length: " & _length & vbNewLine &
               "Resume: " & _resume & vbNewLine &
               "Genre: " & _genre & vbNewLine &
               "Actor: " & _actor & vbNewLine &
               "Director: " & _director
    End Function

    ''' <summary>
    ''' GETTERS AND SETTERS
    ''' </summary>
    ''' <returns></returns>
    Public Property VideoID As Long
        Get
            Return _videoID
        End Get
        Set(value As Long)
            _videoID = value
        End Set
    End Property

    Public Property Photo As String
        Get
            Return _photo
        End Get
        Set(value As String)
            _photo = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public Property Year As String
        Get
            Return _year
        End Get
        Set(value As String)
            _year = value
        End Set
    End Property

    Public Property Country As String
        Get
            Return _country
        End Get
        Set(value As String)
            _country = value
        End Set
    End Property

    Public Property Language As String
        Get
            Return _language
        End Get
        Set(value As String)
            _language = value
        End Set
    End Property

    Public Property Length As Integer
        Get
            Return _length
        End Get
        Set(value As Integer)
            _length = value
        End Set
    End Property

    Public Property [Resume] As String
        Get
            Return _resume
        End Get
        Set(value As String)
            _resume = value
        End Set
    End Property

    Public Property Genre As String
        Get
            Return _genre
        End Get
        Set(value As String)
            _genre = value
        End Set
    End Property

    Public Property Actor As String
        Get
            Return _actor
        End Get
        Set(value As String)
            _actor = value
        End Set
    End Property

    Public Property Director As String
        Get
            Return _director
        End Get
        Set(value As String)
            _director = value
        End Set
    End Property

    Public Property Status As Integer
        Get
            Return _status
        End Get
        Set(value As Integer)
            _status = value
        End Set
    End Property
End Class
