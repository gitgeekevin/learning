Public Class Person

    Private _FirstName As String
    Private _LastName As String
    Private _City As String

    Public ReadOnly Property FullName As String

    Sub New(FirstName As String, LastName As String, City As String)
        _FirstName = FirstName
        _LastName = LastName
        _City = City
        FullName = $"{_FirstName} {_LastName}"
    End Sub

    Public Property FirstName As String
        Get
            Return _FirstName
        End Get
        Set(value As String)
            _FirstName = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _LastName
        End Get
        Set(value As String)
            _LastName = value
        End Set
    End Property

    Public Property City As String
        Get
            Return _City
        End Get
        Set(value As String)
            _City = value
        End Set
    End Property
End Class
