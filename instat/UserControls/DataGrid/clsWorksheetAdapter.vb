Imports unvell.ReoGrid

Public Class clsWorksheetAdapter
    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Sub New(worksheet As Worksheet)
        _name = worksheet.Name
    End Sub

    Public Sub New(tab As TabPage)
        _name = tab.Text
    End Sub
End Class
