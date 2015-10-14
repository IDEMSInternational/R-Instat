Public Class Line
    Private mstrLine As String

    Property Line() As String
        Get
            Return mstrLine
        End Get
        Set(ByVal Value As String)
            mstrLine = Value
        End Set
    End Property

    ReadOnly Property Length() As Integer
        Get
            Return mstrLine.Length
        End Get
    End Property

    Public Function GetWord() As String
        Dim astrWords() As String

        astrWords = mstrLine.Split(" ".ToCharArray())

        Return astrWords(0)
    End Function
End Class