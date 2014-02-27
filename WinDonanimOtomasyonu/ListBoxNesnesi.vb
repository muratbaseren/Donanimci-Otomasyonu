Public Class ListBoxNesnesi
    Private mValue As String
    Private mID As Integer

    Public Sub New(ByVal strValue As String, ByVal intID As Integer)
        mValue = strValue
        mID = intID
    End Sub

    Public Sub New()
        mValue = ""
        mID = 0
    End Sub

    Public Property Value() As String
        Get
            Return mValue
        End Get
        Set(ByVal Value As String)
            mValue = Value
        End Set
    End Property

    Public Property ID() As Integer
        Get
            Return mID
        End Get
        Set(ByVal Value As Integer)
            mID = Value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return mValue
    End Function
End Class
