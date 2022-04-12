Public Class clsPageGroup
    Private _outputGroup As clsOutputGroup
    Private _visible As Boolean

    Private _scripts As List(Of clsPageElement)

    Private _selected As Boolean
    Public Property Selected() As Boolean
        Get
            Return _selected
        End Get
        Set(ByVal value As Boolean)
            _selected = value
            NotifySelectionChanged()
        End Set
    End Property

    Public ReadOnly Property OutputGroup() As clsOutputGroup
        Get
            Return _outputGroup
        End Get
    End Property

    Public Function Clone() As clsPageGroup
        Dim newPage As clsPageGroup
        newPage = Me.MemberwiseClone
        newPage.Scripts = New List(Of clsPageElement)

        ' newPage.Script = newPage.Script.Clone
        'ToDo clone all other classes
        Return newPage
    End Function


    Public Property Scripts() As List(Of clsPageElement)
        Get
            Return _scripts
        End Get
        Set(ByVal value As List(Of clsPageElement))
            _scripts = value
        End Set
    End Property


    Private _page As clsPage
    Public Property Page() As clsPage
        Get
            Return _page
        End Get
        Set(ByVal value As clsPage)
            _page = value
        End Set
    End Property


    Public Event AddAScript()
    '  Public Event AddACleanUpScript()
    ''  Public Event AddAPreScript()
    '  Public Event AddAPostScript()

    Public Sub NotifyVisibleChanged()
        For Each element In Scripts
            element.CommentDisplay.NotifyPropertyChanged(NameOf(element.CommentDisplay.Visible))
            element.OutputCommentDisplay.NotifyPropertyChanged(NameOf(element.OutputCommentDisplay.Visible))
            element.ScriptDisplay.NotifyPropertyChanged(NameOf(element.ScriptDisplay.Visible))
            element.OutputImageDisplay.NotifyPropertyChanged(NameOf(element.OutputImageDisplay.Visible))
            element.OutputTextDisplay.NotifyPropertyChanged(NameOf(element.OutputTextDisplay.Visible))
        Next
    End Sub

    Public Sub NotifySelectionChanged()
        For Each element In Scripts
            element.CommentDisplay.NotifyPropertyChanged(NameOf(element.CommentDisplay.BackColour))
            element.OutputCommentDisplay.NotifyPropertyChanged(NameOf(element.OutputCommentDisplay.BackColour))
            element.ScriptDisplay.NotifyPropertyChanged(NameOf(element.ScriptDisplay.BackColour))
            element.OutputImageDisplay.NotifyPropertyChanged(NameOf(element.OutputImageDisplay.BackColour))
            element.OutputTextDisplay.NotifyPropertyChanged(NameOf(element.OutputTextDisplay.BackColour))

            element.CommentDisplay.NotifyPropertyChanged(NameOf(element.CommentDisplay.IsReadOnly))
            element.OutputCommentDisplay.NotifyPropertyChanged(NameOf(element.OutputCommentDisplay.IsReadOnly))
        Next
    End Sub

    Public Sub New(outputGroup As clsOutputGroup, parentPage As clsPage, visible As Boolean)
        _outputGroup = outputGroup

        _page = parentPage

        _scripts = New List(Of clsPageElement)

        _visible = visible

        _selected = False 'New ValueWrapper(Of Boolean)(False)
    End Sub

    Public Sub AddElement(outputElement As clsOutputScript)
        _scripts.Add(New clsPageElement(outputElement, Me))
        RaiseEvent AddAScript()
    End Sub

    Public Sub RaiseAddScriptEvent()
        'To do this should change
        RaiseEvent AddAScript()
    End Sub







End Class
