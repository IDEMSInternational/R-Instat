Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class clsPageElement
    Implements INotifyPropertyChanged

    Private _id As Guid

    ' Private _visible As Boolean

    Private _pageGroup As clsPageGroup
    Public Property PageGroup() As clsPageGroup
        Get
            Return _pageGroup
        End Get
        Set(ByVal value As clsPageGroup)
            _pageGroup = value
        End Set
    End Property

    Private _outputScript As clsOutputScript
    Public ReadOnly Property OutputScript() As clsOutputScript
        Get
            Return _outputScript
        End Get
    End Property

    'Public Property Visible() As Boolean
    '    Get
    '        Return _visible
    '    End Get
    '    Set(ByVal value As Boolean)
    '        _visible = value
    '    End Set
    'End Property

    Private _scriptComment As String
    Public Property ScriptComment() As String
        Get
            Return _scriptComment
        End Get
        Set(ByVal value As String)

            _scriptComment = AddHashtoEachNewLine(value)
            NotifyPropertyChanged()
        End Set
    End Property

    Private _outputComment As String


    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged



    Private Sub NotifyPropertyChanged(<CallerMemberName> ByVal Optional propertyName As String = "")
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Public Property OutputComment() As String
        Get
            Return _outputComment
        End Get
        Set(ByVal value As String)
            _outputComment = AddHashtoEachNewLine(value)
            NotifyPropertyChanged()
        End Set
    End Property


    Private _commentDisplay As clsPageElementDisplay
    Public Property CommentDisplay() As clsPageElementDisplay
        Get
            Return _commentDisplay
        End Get
        Set(ByVal value As clsPageElementDisplay)
            _commentDisplay = value
        End Set
    End Property
    Private _scriptDisplay As clsPageElementDisplay
    Public Property ScriptDisplay() As clsPageElementDisplay
        Get
            Return _scriptDisplay
        End Get
        Set(ByVal value As clsPageElementDisplay)
            _scriptDisplay = value
        End Set
    End Property
    Private _outputCommentDisplay As clsPageElementDisplay
    Public Property OutputCommentDisplay() As clsPageElementDisplay
        Get
            Return _outputCommentDisplay
        End Get
        Set(ByVal value As clsPageElementDisplay)
            _outputCommentDisplay = value
        End Set
    End Property
    Private _outputTextDisplay As clsPageElementDisplay
    Public Property OutputTextDisplay() As clsPageElementDisplay
        Get
            Return _outputTextDisplay
        End Get
        Set(ByVal value As clsPageElementDisplay)
            _outputTextDisplay = value
        End Set
    End Property

    Private _outputImageDisplay As clsPageElementDisplay
    Public Property OutputImageDisplay() As clsPageElementDisplay
        Get
            Return _outputImageDisplay
        End Get
        Set(ByVal value As clsPageElementDisplay)
            _outputImageDisplay = value
        End Set
    End Property

    Private Function AddHashtoEachNewLine(text As String) As String
        Dim temp As String = ""
        text = text.TrimEnd(Environment.NewLine.ToCharArray())
        For Each line In text.Split(Environment.NewLine.ToCharArray())
            If line.Length = 0 OrElse line(0) = "#" Then
                temp += line + Environment.NewLine.ToCharArray()
            Else
                temp += "#" + line + Environment.NewLine.ToCharArray()
            End If
        Next
        temp = temp.TrimEnd(Environment.NewLine.ToCharArray())
        Return temp
    End Function

    Private Function CreatePageElementDisplay(displayType As OutputDisplayElementType, Optional exists As Boolean = True) As clsPageElementDisplay
        Return New clsPageElementDisplay(Me, displayType, exists)
    End Function


    Public Function Clone() As clsPageElement
        Return Me.MemberwiseClone
    End Function

    Public Sub New(outputScript As clsOutputScript, parentGroup As clsPageGroup,
                        Optional commentVisible As Boolean = True,
                        Optional scriptVisible As Boolean = True,
                        Optional outputCommentVisible As Boolean = True,
                        Optional outputTextVisible As Boolean = True,
                        Optional outputImageVisible As Boolean = True)


        _id = Guid.NewGuid


        _outputScript = outputScript
        _pageGroup = parentGroup
        _scriptComment = outputScript.Comment.TrimEnd(Environment.NewLine.ToCharArray())
        _outputComment = outputScript.OutputComment.TrimEnd(Environment.NewLine.ToCharArray())

        _commentDisplay = CreatePageElementDisplay(OutputDisplayElementType.Comment)
        _scriptDisplay = CreatePageElementDisplay(OutputDisplayElementType.Script)
        _outputCommentDisplay = CreatePageElementDisplay(OutputDisplayElementType.OutputComment, outputScript.OutputCommentExists)
        _outputTextDisplay = CreatePageElementDisplay(OutputDisplayElementType.OutputText, outputScript.OutputTextExists)
        _outputImageDisplay = CreatePageElementDisplay(OutputDisplayElementType.OutputImage, outputScript.OutputImageExists)



        _commentDisplay.Visible = commentVisible
        _scriptDisplay.Visible = scriptVisible
        _outputCommentDisplay.Visible = outputCommentVisible
        _outputTextDisplay.Visible = outputTextVisible
        _outputImageDisplay.Visible = outputImageVisible
    End Sub



    ReadOnly Property Script As String
        Get
            Return _outputScript.Script
        End Get
    End Property

    ReadOnly Property OutputText As String
        Get
            Return _outputScript.OutputText
        End Get
    End Property

    ReadOnly Property OutputImage As Image
        Get
            Return _outputScript.OutputImage
        End Get
    End Property

End Class
