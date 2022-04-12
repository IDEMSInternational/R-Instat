Public Class clsPages


    Private _pages As List(Of clsPage)


    Public Sub New()
        _pages = New List(Of clsPage)
    End Sub

    Public Property Pages() As List(Of clsPage)
        Get
            Return _pages
        End Get
        Set(ByVal value As List(Of clsPage))
            _pages = value
        End Set
    End Property

    Event NewPageAdded(page As clsPage)


    Private _selectedPage As clsPage
    Public Property SelectedPage() As clsPage
        Get
            Return _selectedPage
        End Get
        Set(ByVal value As clsPage)
            _selectedPage = value
        End Set
    End Property


    Public Sub AddNewPage(page As clsPage)
        _pages.Add(page)
        'ToDo selected page should work from ucrControl
        _selectedPage = page
        RaiseEvent NewPageAdded(page)
    End Sub

    Public Sub NewGroupAdded(outputGroup As clsOutputGroup)
        For Each page In _pages
            page.AddPageGroup(outputGroup)
        Next
    End Sub

    Public Sub NewElementAdded(outputElement As clsOutputScript)
        For Each page In _pages
            page.AddPageElement(outputElement)
        Next
    End Sub

    Public Sub MoveSelectedToPage(sourcePage As clsPage)
        _selectedPage.FillFromSourcePage(sourcePage)

        'For Each group In _selectedPage.PageGroups
        '    If group.Selected = True Then
        '        '  newPage.A
        '    End If
        'Next
    End Sub
End Class
