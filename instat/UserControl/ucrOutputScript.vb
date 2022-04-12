Public Class ucrOutputScript
    Private _outputScriptViewModel As clsPageElement


    Private _backColour = Color.White
    Private _highlighted = Color.LightBlue
    Private _commentFont = New Font("Calibri", 14)
    Private _commentForeColour = Color.RoyalBlue
    Private _scriptFont = New Font("Calibri", 14)
    Private _scriptForeColour = Color.Black
    Private _outputFont = New Font("Calibri", 14)
    Private _outputForeColour = Color.Black


    Private _imageMinWidth As Integer = 500
    Private _imageMaxHeight As Integer = 500

    Private _reSizeImageMode As Boolean


    Private Sub AddBindingToRichTextBox(richTextBox As RichTextBox, displayViewModel As clsPageElementDisplay, text As String)
        richTextBox.DataBindings.Add(New Binding(NameOf(richTextBox.Text), _outputScriptViewModel,
                text, True, DataSourceUpdateMode.OnValidation))
        richTextBox.DataBindings.Add(New Binding(NameOf(richTextBox.Visible), displayViewModel,
                NameOf(displayViewModel.Visible), True, DataSourceUpdateMode.OnValidation))
        richTextBox.DataBindings.Add(New Binding(NameOf(richTextBox.BackColor), displayViewModel,
                NameOf(displayViewModel.BackColour)))
        'use tag for selected
        richTextBox.DataBindings.Add(New Binding(NameOf(richTextBox.ReadOnly), displayViewModel, NameOf(displayViewModel.IsReadOnly)))
        richTextBox.Tag = displayViewModel
    End Sub

    Public Sub New(outputScriptViewModel As clsPageElement)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _outputScriptViewModel = outputScriptViewModel

        _ReSizeImageMode = False

        rtbComment.Font = _commentFont
        rtbComment.ForeColor = _commentForeColour
        AddBindingToRichTextBox(rtbComment, _outputScriptViewModel.CommentDisplay,
                                            NameOf(_outputScriptViewModel.ScriptComment))

        rtbScript.Font = _scriptFont
        rtbScript.ForeColor = _scriptForeColour
        AddBindingToRichTextBox(rtbScript, _outputScriptViewModel.ScriptDisplay,
                                            NameOf(_outputScriptViewModel.Script))

        rtbOutputComment.BackColor = _backColour
        rtbOutputComment.Font = _commentFont
        rtbOutputComment.ForeColor = _commentForeColour
        AddBindingToRichTextBox(rtbOutputComment, _outputScriptViewModel.OutputCommentDisplay,
                                            NameOf(_outputScriptViewModel.OutputComment))

        rtbOutputText.BackColor = _backColour
        rtbOutputText.Font = _outputFont
        rtbOutputText.ForeColor = _outputForeColour
        AddBindingToRichTextBox(rtbOutputText, _outputScriptViewModel.OutputTextDisplay,
                                            NameOf(_outputScriptViewModel.OutputText))


        spbOutputImage.BackColor = _backColour
        spbOutputImage.Image = _outputScriptViewModel.OutputImage
        spbOutputImage.SizeMode = PictureBoxSizeMode.Zoom
        If spbOutputImage.Image IsNot Nothing Then
            _imageMaxHeight = imagePanel.Width / (spbOutputImage.Image.Width / spbOutputImage.Image.Height)
            imagePanel.Height = _imageMaxHeight
            spbOutputImage.Width = imagePanel.Width
            spbOutputImage.Height = spbOutputImage.Width / (spbOutputImage.Image.Width / spbOutputImage.Image.Height)
        End If


        imagePanel.DataBindings.Add(New Binding(NameOf(imagePanel.Visible), _outputScriptViewModel.OutputImageDisplay,
                NameOf(_outputScriptViewModel.OutputImageDisplay.Visible), True, DataSourceUpdateMode.OnValidation))

        spbOutputImage.DataBindings.Add(New Binding(NameOf(spbOutputImage.BackColor), _outputScriptViewModel.OutputImageDisplay,
                NameOf(_outputScriptViewModel.OutputImageDisplay.BackColour)))



        spbOutputImage.Tag = _outputScriptViewModel.OutputImageDisplay

    End Sub

    Private Sub rtbComment_ContentsResized(sender As Object, e As ContentsResizedEventArgs) Handles rtbComment.ContentsResized, rtbScript.ContentsResized, rtbOutputText.ContentsResized, rtbOutputComment.ContentsResized
        CType(sender, RichTextBox).Height = e.NewRectangle.Height + 5
    End Sub

    Private Sub rtbOutputComment_Click(sender As Object, e As EventArgs) Handles rtbScript.Click, rtbOutputComment.Click, rtbComment.Click


        Dim rtb As RichTextBox = CType(sender, RichTextBox)
        Dim display As clsPageElementDisplay = CType(rtb.Tag, clsPageElementDisplay)
        display.Selected = Not display.Selected

    End Sub

    Private Sub rtbScript_TextChanged(sender As Object, e As EventArgs) Handles rtbScript.TextChanged
        '  _outputScriptViewModel.BackColor = Color.Blue
    End Sub

    Private Sub rtbScript_DoubleClick(sender As Object, e As EventArgs) Handles rtbScript.DoubleClick
        '  _outputScriptViewModel.BackColor = Color.Blue
    End Sub

    Private Sub rtbComment_Validated(sender As Object, e As EventArgs) Handles rtbComment.Validated, rtbOutputComment.Validated
        rtbComment.DataBindings.Item(0).ReadValue()

        'rtbComment.Text = _outputScriptViewModel.ScriptComment
    End Sub

    Private Sub spbOutputImage_DoubleClick(sender As Object, e As EventArgs) Handles spbOutputImage.DoubleClick
        If _outputScriptViewModel.PageGroup.Page.SelectionMode = PageSelectionMode.Edit Then
            imagePanel.Height = _imageMaxHeight
            spbOutputImage.Left = 0
            spbOutputImage.Top = 0
            spbOutputImage.CanReSize = True
        End If
    End Sub

    Private Sub spbOutputImage_Resize(sender As Object, e As EventArgs) Handles spbOutputImage.Resize

    End Sub

    Private Sub ucrOutputScript_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If spbOutputImage.Image IsNot Nothing Then
            _imageMaxHeight = imagePanel.Width / (spbOutputImage.Image.Width / spbOutputImage.Image.Height)

            If spbOutputImage.Height > _imageMaxHeight Then
                imagePanel.Height = _imageMaxHeight
                spbOutputImage.Width = imagePanel.Width
                spbOutputImage.Height = spbOutputImage.Width / (spbOutputImage.Image.Width / spbOutputImage.Image.Height)
            End If
            spbOutputImage.Left = 0
            spbOutputImage.Top = 0
            spbOutputImage.CanReSize = False
        End If

    End Sub

    Private Sub imagePanel_Leave(sender As Object, e As EventArgs) Handles imagePanel.Leave

    End Sub

    Private Sub ucrOutputScript_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        spbOutputImage.CanReSize = False
        imagePanel.Height = spbOutputImage.Height
        '   spbOutputImage.Left = 0
        ' spbOutputImage.Top = 0
    End Sub
End Class
