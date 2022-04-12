Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class clsPageElementDisplay
    Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub NotifyPropertyChanged(<CallerMemberName> ByVal Optional propertyName As String = "")
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub


    '  Private _typeVisible As ValueWrapper(Of Boolean)
    ' Private _selectionMode As ValueWrapper(Of PageSelectionMode)
    '   Private _groupSelected As ValueWrapper(Of Boolean)
    Private _visible As Boolean
    Private _isReadOnly As Boolean
    Private _pageElement As clsPageElement
    Private _displayType As OutputDisplayElementType
    Private _exists As Boolean
    Public Property Visible() As Boolean
        Get
            If _exists AndAlso _pageElement.PageGroup.Page.IsElementTypeVisible(_displayType) AndAlso
                _pageElement.PageGroup.Page.IsScriptTypeVisible(_pageElement.OutputScript.ScriptType) Then
                Return _visible
            Else
                Return False
            End If
        End Get
        Set(ByVal value As Boolean)
            _visible = value
            NotifyPropertyChanged()
        End Set
    End Property

    Private _selected As Boolean
    Public Property Selected() As Boolean
        Get
            Select Case _pageElement.PageGroup.Page.SelectionMode
                Case PageSelectionMode.Edit
                    Return False
                Case PageSelectionMode.Element
                    Return _selected
                Case PageSelectionMode.Group
                    Return _pageElement.PageGroup.Selected
                Case Else
                    Return False
            End Select
        End Get
        Set(ByVal value As Boolean)
            If _pageElement.PageGroup.Page.SelectionMode = PageSelectionMode.Element Then
                _selected = value
                NotifyPropertyChanged()
                NotifyPropertyChanged(NameOf(BackColour))
            ElseIf _pageElement.PageGroup.Page.SelectionMode = PageSelectionMode.Group Then
                _pageElement.PageGroup.Selected = value
            End If
        End Set
    End Property

    Private _backColour As Color

    Public Sub New(pageElement As clsPageElement, displayType As OutputDisplayElementType, exists As Boolean)
        _displayType = displayType
        'To do remove type visible and pass in the type
        '  _typeVisible = typeVisible
        ' _selectionMode = selectionMode
        ' _groupSelected = groupSelected
        _exists = exists
        If _displayType = OutputDisplayElementType.Comment OrElse _displayType = OutputDisplayElementType.OutputComment Then
            _isReadOnly = False
        Else
            _isReadOnly = True
        End If
        _pageElement = pageElement
    End Sub

    Public Property BackColour() As Color
        Get
            If Selected Then
                Return Color.LightBlue
            Else
                Return Color.White
            End If
        End Get
        'Todo Can this be bound and readonly
        Set(ByVal value As Color)
            _backColour = value
        End Set
    End Property

    Public ReadOnly Property IsReadOnly As Boolean
        Get
            If _isReadOnly Then
                Return True
            Else
                Return _pageElement.PageGroup.Page.SelectionMode <> PageSelectionMode.Edit
            End If
        End Get
    End Property
End Class
