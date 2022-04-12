Imports RScript

Public Class clsOutputScript
    Private _comment As String
    Private _script As String
    Private _formatedRScript As List(Of clsRScriptElement)
    Private _outputComment As String
    Private _scriptType As ScriptType

    Private _outputCommentExists As Boolean
    Private _outputTextExists As Boolean
    Private _outputImageExists As Boolean

    Public ReadOnly Property OutputCommentExists() As String
        Get
            Return _outputCommentExists
        End Get
    End Property

    Public ReadOnly Property OutputTextExists() As String
        Get
            Return _outputTextExists
        End Get
    End Property

    Public ReadOnly Property OutputImageExists() As String
        Get
            Return _outputImageExists
        End Get
    End Property

    Public ReadOnly Property ScriptType() As ScriptType
        Get
            Return _scriptType
        End Get
    End Property

    Public ReadOnly Property OutputComment() As String
        Get
            Return _outputComment
        End Get
    End Property

    Private _outputImage As Image
    Public ReadOnly Property OutputImage() As Image
        Get
            Return _outputImage
        End Get
    End Property

    Private _outputText As String
    Public ReadOnly Property OutputText() As String
        Get
            Return _outputText
        End Get
    End Property

    Public ReadOnly Property Comment() As String
        Get
            Return _comment
        End Get
    End Property

    Public ReadOnly Property Script() As String
        Get
            Return _script
        End Get
    End Property

    Public Sub New(scriptType As ScriptType, strScript As String)
        _comment = ""
        _script = ""
        _outputComment = ""
        _outputCommentExists = False
        _outputTextExists = False
        _outputImageExists = False
        _formatedRScript = New List(Of clsRScriptElement)
        _scriptType = scriptType
        SetFormatedRScript(strScript)
    End Sub

    Public Sub New(scriptType As ScriptType, strScript As String, outputText As String)
        Me.New(scriptType, strScript)
        _outputText = outputText

        _outputCommentExists = True
        _outputTextExists = True
    End Sub

    Public Sub New(scriptType As ScriptType, strScript As String, outputImage As Image)
        Me.New(scriptType, strScript)
        _outputImage = outputImage

        _outputCommentExists = True
        _outputImageExists = True

        '   _outputImage.Save("C:\Users\Christopher Marsh\AppData\Local\Temp\R_Instat_Temp_Graphs\test2.png")
    End Sub



    Private Sub SetFormatedRScript(strScript As String)
        Dim rScript As New clsRScript(strScript)
        Try
            Dim lstTokens As List(Of clsRToken) = rScript.GetLstTokens(rScript.GetLstLexemes(strScript))
            If lstTokens Is Nothing Then
                Exit Sub
            End If
            For Each rToken In lstTokens
                _formatedRScript.Add(New clsRScriptElement With
                {
                    .Text = rToken.strTxt,
                    .Type = rToken.enuToken
                })
            Next
            SetScriptAndCommentFromFormatedRScript()
        Catch
            _script = strScript
        End Try
    End Sub
    Private Sub SetScriptAndCommentFromFormatedRScript()
        Dim fillingInComment = True
        For Each line In _formatedRScript
            If fillingInComment And Not (line.Type = clsRToken.typToken.RComment Or line.Type = clsRToken.typToken.RNewLine) Then
                fillingInComment = False
            End If
            If fillingInComment Then
                _comment &= line.Text
            Else
                _script &= line.Text
            End If
        Next
    End Sub

End Class
