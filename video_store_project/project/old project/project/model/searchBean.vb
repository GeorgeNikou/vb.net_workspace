Public Class searchBean

    'properties
    Private _searchTitle As String
    Private _searchYear As Date
    Private _searchCountry As String
    Private _searchLanguage As String
    Private _searchLength As Double
    Private _searchResume As String
    Private _searchGenre As String
    Private _searchActors As String
    Private _searchDirector As String

    'constructor
    Public Sub New(searchTitle As String, searchYear As Date, searchCountry As String, searchLanguage As String, searchLength As Double, searchResume As String, searchGenre As String, searchActors As String, searchDirector As String)
        _searchTitle = searchTitle
        _searchYear = searchYear
        _searchCountry = searchCountry
        _searchLanguage = searchLanguage
        _searchLength = searchLength
        _searchResume = searchResume
        _searchGenre = searchGenre
        _searchActors = searchActors
        _searchDirector = searchDirector
    End Sub

    ''' <summary>
    ''' GETTERS AND SETTERS
    ''' </summary>
    ''' <returns></returns>
    Public Property SearchTitle As String
        Get
            Return _searchTitle
        End Get
        Set(value As String)
            _searchTitle = value
        End Set
    End Property

    Public Property SearchYear As Date
        Get
            Return _searchYear
        End Get
        Set(value As Date)
            _searchYear = value
        End Set
    End Property

    Public Property SearchCountry As String
        Get
            Return _searchCountry
        End Get
        Set(value As String)
            _searchCountry = value
        End Set
    End Property

    Public Property SearchLanguage As String
        Get
            Return _searchLanguage
        End Get
        Set(value As String)
            _searchLanguage = value
        End Set
    End Property

    Public Property SearchLength As Double
        Get
            Return _searchLength
        End Get
        Set(value As Double)
            _searchLength = value
        End Set
    End Property

    Public Property SearchResume As String
        Get
            Return _searchResume
        End Get
        Set(value As String)
            _searchResume = value
        End Set
    End Property

    Public Property SearchGenre As String
        Get
            Return _searchGenre
        End Get
        Set(value As String)
            _searchGenre = value
        End Set
    End Property

    Public Property SearchActors As String
        Get
            Return _searchActors
        End Get
        Set(value As String)
            _searchActors = value
        End Set
    End Property

    Public Property SearchDirector As String
        Get
            Return _searchDirector
        End Get
        Set(value As String)
            _searchDirector = value
        End Set
    End Property
End Class
