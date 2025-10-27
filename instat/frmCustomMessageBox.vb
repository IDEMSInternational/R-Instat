Imports instat.Translations

''' <summary>
''' Custom message box form that supports translatable buttons
''' </summary>
Public Class frmCustomMessageBox
    Private _result As DialogResult = DialogResult.None
    Private _buttons As MessageBoxButtons = MessageBoxButtons.OK
    Private _icon As MessageBoxIcon = MessageBoxIcon.None

    ''' <summary>
    ''' Gets the dialog result from the message box
    ''' </summary>
    Public ReadOnly Property Result As DialogResult
        Get
            Return _result
        End Get
    End Property

    ''' <summary>
    ''' Shows a custom message box with translated buttons
    ''' </summary>
    Public Shared Function Show(prompt As String,
                                Optional title As String = Nothing,
                                Optional buttons As MessageBoxButtons = MessageBoxButtons.OK,
                                Optional icon As MessageBoxIcon = MessageBoxIcon.None,
                                Optional defaultButton As MessageBoxDefaultButton = MessageBoxDefaultButton.Button1) As DialogResult
        Using frm As New frmCustomMessageBox()
            frm.SetupMessageBox(prompt, title, buttons, icon, defaultButton)
            frm.ShowDialog()
            Return frm.Result
        End Using
    End Function

    ''' <summary>
    ''' Configures the message box with the specified parameters
    ''' </summary>
    Private Sub SetupMessageBox(prompt As String,
                                title As String,
                                buttons As MessageBoxButtons,
                                icon As MessageBoxIcon,
                                defaultButton As MessageBoxDefaultButton)
        ' Set the message and title
        lblMessage.Text = prompt
        If Not String.IsNullOrEmpty(title) Then
            Me.Text = title
        End If

        _buttons = buttons
        _icon = icon

        ' Set up icon
        SetupIcon(icon)

        ' Set up buttons
        SetupButtons(buttons, defaultButton)

        ' Apply translations
        autoTranslate(Me)
    End Sub

    ''' <summary>
    ''' Sets up the icon for the message box
    ''' </summary>
    Private Sub SetupIcon(icon As MessageBoxIcon)
        Select Case icon
            Case MessageBoxIcon.Error, MessageBoxIcon.Hand, MessageBoxIcon.Stop
                picIcon.Image = SystemIcons.Error.ToBitmap()
            Case MessageBoxIcon.Question
                picIcon.Image = SystemIcons.Question.ToBitmap()
            Case MessageBoxIcon.Warning, MessageBoxIcon.Exclamation
                picIcon.Image = SystemIcons.Warning.ToBitmap()
            Case MessageBoxIcon.Information, MessageBoxIcon.Asterisk
                picIcon.Image = SystemIcons.Information.ToBitmap()
            Case Else
                picIcon.Visible = False
                ' Adjust layout when no icon
                lblMessage.Left = 12
                lblMessage.Width = Me.ClientSize.Width - 24
        End Select
    End Sub

    ''' <summary>
    ''' Sets up the buttons based on the MessageBoxButtons value
    ''' </summary>
    Private Sub SetupButtons(buttons As MessageBoxButtons, defaultButton As MessageBoxDefaultButton)
        ' Hide all buttons initially
        btnButton1.Visible = False
        btnButton2.Visible = False
        btnButton3.Visible = False

        Select Case buttons
            Case MessageBoxButtons.OK
                ConfigureButton(btnButton1, GetTranslation("OK"), DialogResult.OK, True)
                SetDefaultButton(btnButton1, defaultButton, MessageBoxDefaultButton.Button1)

            Case MessageBoxButtons.OKCancel
                ConfigureButton(btnButton1, GetTranslation("OK"), DialogResult.OK, True)
                ConfigureButton(btnButton2, GetTranslation("Cancel"), DialogResult.Cancel, True)
                SetDefaultButton(If(defaultButton = MessageBoxDefaultButton.Button2, btnButton2, btnButton1), defaultButton, MessageBoxDefaultButton.Button1)
                Me.CancelButton = btnButton2

            Case MessageBoxButtons.YesNo
                ConfigureButton(btnButton1, GetTranslation("Yes"), DialogResult.Yes, True)
                ConfigureButton(btnButton2, GetTranslation("No"), DialogResult.No, True)
                SetDefaultButton(If(defaultButton = MessageBoxDefaultButton.Button2, btnButton2, btnButton1), defaultButton, MessageBoxDefaultButton.Button1)

            Case MessageBoxButtons.YesNoCancel
                ConfigureButton(btnButton1, GetTranslation("Yes"), DialogResult.Yes, True)
                ConfigureButton(btnButton2, GetTranslation("No"), DialogResult.No, True)
                ConfigureButton(btnButton3, GetTranslation("Cancel"), DialogResult.Cancel, True)
                Dim defBtn As Button = btnButton1
                If defaultButton = MessageBoxDefaultButton.Button2 Then
                    defBtn = btnButton2
                ElseIf defaultButton = MessageBoxDefaultButton.Button3 Then
                    defBtn = btnButton3
                End If
                SetDefaultButton(defBtn, defaultButton, MessageBoxDefaultButton.Button1)
                Me.CancelButton = btnButton3

            Case MessageBoxButtons.RetryCancel
                ConfigureButton(btnButton1, GetTranslation("Retry"), DialogResult.Retry, True)
                ConfigureButton(btnButton2, GetTranslation("Cancel"), DialogResult.Cancel, True)
                SetDefaultButton(If(defaultButton = MessageBoxDefaultButton.Button2, btnButton2, btnButton1), defaultButton, MessageBoxDefaultButton.Button1)
                Me.CancelButton = btnButton2

            Case MessageBoxButtons.AbortRetryIgnore
                ConfigureButton(btnButton1, GetTranslation("Abort"), DialogResult.Abort, True)
                ConfigureButton(btnButton2, GetTranslation("Retry"), DialogResult.Retry, True)
                ConfigureButton(btnButton3, GetTranslation("Ignore"), DialogResult.Ignore, True)
                Dim defBtn As Button = btnButton1
                If defaultButton = MessageBoxDefaultButton.Button2 Then
                    defBtn = btnButton2
                ElseIf defaultButton = MessageBoxDefaultButton.Button3 Then
                    defBtn = btnButton3
                End If
                SetDefaultButton(defBtn, defaultButton, MessageBoxDefaultButton.Button1)
        End Select
    End Sub

    ''' <summary>
    ''' Configures a button with text and dialog result
    ''' </summary>
    Private Sub ConfigureButton(btn As Button, text As String, result As DialogResult, visible As Boolean)
        btn.Text = text
        btn.Tag = result
        btn.Visible = visible
    End Sub

    ''' <summary>
    ''' Sets the default button
    ''' </summary>
    Private Sub SetDefaultButton(btn As Button, defaultButton As MessageBoxDefaultButton, expectedDefault As MessageBoxDefaultButton)
        If defaultButton = expectedDefault Then
            Me.AcceptButton = btn
        End If
    End Sub

    ''' <summary>
    ''' Handles button clicks
    ''' </summary>
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btnButton1.Click, btnButton2.Click, btnButton3.Click
        Dim btn As Button = DirectCast(sender, Button)
        _result = DirectCast(btn.Tag, DialogResult)
        Me.Close()
    End Sub

    ''' <summary>
    ''' Handles form closing to ensure a result is set
    ''' </summary>
    Private Sub frmCustomMessageBox_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' If no button was clicked (e.g., user closed the form), set appropriate default result
        If _result = DialogResult.None Then
            Select Case _buttons
                Case MessageBoxButtons.OK
                    _result = DialogResult.OK
                Case MessageBoxButtons.OKCancel, MessageBoxButtons.YesNoCancel, MessageBoxButtons.RetryCancel
                    _result = DialogResult.Cancel
                Case MessageBoxButtons.YesNo
                    _result = DialogResult.No
                Case MessageBoxButtons.AbortRetryIgnore
                    _result = DialogResult.Abort
                Case Else
                    _result = DialogResult.Cancel
            End Select
        End If
    End Sub
End Class
