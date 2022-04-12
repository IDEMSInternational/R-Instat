'Public Class ValueWrapper(Of T As Structure)
'    Public Property Value As T

'    Public Sub New(ByVal value As T)
'        Me.Value = value
'    End Sub

'End Class



Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class clsPage
    Implements INotifyPropertyChanged

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
            NotifyPropertyChanged()
        End Set
    End Property

    Private _pageGroups As List(Of clsPageGroup)

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub NotifyPropertyChanged(<CallerMemberName> ByVal Optional propertyName As String = "")
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Public Sub New(name As String)
        _name = name
        _pageGroups = New List(Of clsPageGroup)

        _showComments = True 'New ValueWrapper(Of Boolean)(True)
        _showScripts = True 'New ValueWrapper(Of Boolean)(True)
        _showTextOutputs = True 'New ValueWrapper(Of Boolean)(True)
        _showImages = True 'ValueWrapper(Of Boolean)(True)
        _showCleanUpScripts = True 'New ValueWrapper(Of Boolean)(True)

        _selectionMode = PageSelectionMode.Edit 'New ValueWrapper(Of PageSelectionMode)(PageSelectionMode.Edit)

    End Sub

    Public Function IsScriptTypeVisible(scriptType As ScriptType) As Boolean
        Select Case scriptType
            Case ScriptType.CleanUpScript
                Return _showCleanUpScripts
            Case Else
                Return True
        End Select
    End Function

    Public Function IsElementTypeVisible(displayType As OutputDisplayElementType) As Boolean
        Select Case displayType
            Case OutputDisplayElementType.Comment
                Return _showComments
            Case OutputDisplayElementType.Script
                Return _showScripts
            Case OutputDisplayElementType.OutputComment
                Return _showComments
            Case OutputDisplayElementType.OutputText
                Return _showTextOutputs
            Case OutputDisplayElementType.OutputImage
                Return _showImages
            Case Else
                Return True
        End Select
    End Function

    Public Property PageGroups() As List(Of clsPageGroup)
        Get
            Return _pageGroups
        End Get
        Set(ByVal value As List(Of clsPageGroup))
            _pageGroups = value
        End Set
    End Property


    Private _updateFromLogger As Boolean

    Public Property UpdateFromLogger As Boolean
        Get
            Return _updateFromLogger
        End Get
        Set(value As Boolean)
            _updateFromLogger = value
        End Set
    End Property

    Private _lastPageGroup As clsPageGroup

    Public Sub AddPageElement(outputElement As clsOutputScript)
        _lastPageGroup.AddElement(outputElement)
    End Sub

    Private Sub AddPageElement(outputElement As clsPageElement)
        ' _lastPageGroup.AddElement(outputElement.Clone)
    End Sub

    Public Event PageGroupAdded(outputGroup As clsPageGroup)

    Public Sub AddPageGroup(outputGroup As clsOutputGroup)
        _lastPageGroup = New clsPageGroup(outputGroup, Me, _updateFromLogger)
        _pageGroups.Add(_lastPageGroup)
        RaiseEvent PageGroupAdded(_lastPageGroup)
    End Sub

    Private Sub CopyPageGroup(pageGroup As clsPageGroup)
        AddPageGroup(pageGroup.OutputGroup)
        For Each script In pageGroup.Scripts
            _lastPageGroup.AddElement(script.OutputScript)
        Next
    End Sub

    Public Sub FillFromSourcePage(source As clsPage)
        For Each group In source.PageGroups
            CopyPageGroup(group)
        Next
    End Sub

    Public HideAllComments As Boolean


    Private Sub NotifyVisibleChanged()
        For Each group In _pageGroups
            group.NotifyVisibleChanged()
        Next
    End Sub

    Private Sub NotifySelectionChanged()
        For Each group In _pageGroups
            group.NotifySelectionChanged()
        Next
    End Sub

    Private _selectionMode As PageSelectionMode
    Public Property SelectionMode() As PageSelectionMode
        Get
            Return _selectionMode
        End Get
        Set(ByVal value As PageSelectionMode)
            _selectionMode = value
            NotifySelectionChanged()
        End Set
    End Property

    Private _showComments As Boolean
    Public Property ShowComments() As Boolean
        Get
            Return _showComments
        End Get
        Set(ByVal value As Boolean)
            _showComments = value
            NotifyVisibleChanged()
        End Set
    End Property

    'Public ReadOnly Property SelectionModeByReference As ValueWrapper(Of PageSelectionMode)
    '    Get
    '        Return _selectionMode
    '    End Get
    'End Property

    'Public ReadOnly Property ShowCommentsByReference As ValueWrapper(Of Boolean)
    '    Get
    '        Return _showComments
    '    End Get
    'End Property

    'Public ReadOnly Property ShowScriptsByReference As ValueWrapper(Of Boolean)
    '    Get
    '        Return _showScripts
    '    End Get
    'End Property

    'Public ReadOnly Property ShowTextOutputsByReference As ValueWrapper(Of Boolean)
    '    Get
    '        Return _showTextOutputs
    '    End Get
    'End Property
    'Public ReadOnly Property ShowImagesByReference As ValueWrapper(Of Boolean)
    '    Get
    '        Return _showImages
    '    End Get
    'End Property
    'Public ReadOnly Property ShowCleanUpScriptsByReference As ValueWrapper(Of Boolean)
    '    Get
    '        Return _showCleanUpScripts
    '    End Get
    'End Property


    Private _showScripts As Boolean
    Public Property ShowScripts() As Boolean
        Get
            Return _showScripts
        End Get
        Set(ByVal value As Boolean)
            _showScripts = value
            NotifyVisibleChanged()
        End Set
    End Property

    Private _showImages As Boolean
    Public Property ShowImages() As Boolean
        Get
            Return _showImages
        End Get
        Set(ByVal value As Boolean)
            _showImages = value
            NotifyVisibleChanged()
        End Set
    End Property
    Private _showTextOutputs As Boolean
    Public Property ShowTextOutputs() As Boolean
        Get
            Return _showTextOutputs
        End Get
        Set(ByVal value As Boolean)
            _showTextOutputs = value
            NotifyVisibleChanged()
        End Set
    End Property
    Private _showCleanUpScripts As Boolean
    Public Property ShowCleanUpScripts() As Boolean
        Get
            Return _showCleanUpScripts
        End Get
        Set(ByVal value As Boolean)
            _showCleanUpScripts = value
            NotifyVisibleChanged()
        End Set
    End Property


    Public Sub Save(fileLocation As String)
        'Dim richText As New RichTextBox
        'For Each checkbox In _checkBoxes
        '    Dim element As clsOutputElement = checkbox.Tag
        '    AddElementToRichTextBox(element, richText)

        '    Select Case element.OutputType
        '        Case OutputType.Script
        '            FillRichTextBoxWithFormatedRScript(richText, element.FormatedRScript)
        '        Case OutputType.TextOutput
        '            AddFormatedTextToRichTextBox(richText, element.StringOutput, OutputFont.ROutputFont, OutputFont.ROutputColour)
        '        Case OutputType.ImageOutput
        '            Clipboard.Clear()
        '            Clipboard.SetImage(element.ImageOutput)
        '            richText.Paste()
        '    End Select
        '    richText.AppendText(Environment.NewLine)
        '    richText.AppendText(Environment.NewLine)


        'Next
        'richText.SaveFile(path)
    End Sub

    Public Sub ResetView()

    End Sub
End Class
