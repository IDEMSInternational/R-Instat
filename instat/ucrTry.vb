Imports RDotNet
Public Class ucrTry
    Public bFirstLoad As Boolean
    Private strError As String
    Private bReceiverExpressionIsEmpty As Boolean
    Private baseCommandString As RCodeStructure
    Private commandStr As String
    Public clsAttachNameRFunctionParam As RFunction
    Public clsAttach As RFunction
    Public clsDetach As RFunction
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bFirstLoad = True
        clsAttach = New RFunction
        clsDetach = New RFunction

    End Sub

    Private Sub cmdTry_Click(sender As Object, e As EventArgs) Handles cmdTry.Click
        TryScript()
    End Sub

    Private Sub ucrTry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            bFirstLoad = False
            ucrInputTryMessage.txtInput.Controls.Clear()
        End If
    End Sub

    'Ckecks if the ucrReceiverExpression is empty
    Public Sub ReceiverExpressionIsEmpty(IsEmpty As Boolean)
        bReceiverExpressionIsEmpty = IsEmpty
    End Sub

    Public Sub SetCommandStringAsRCode(commandString As RCodeStructure)
        baseCommandString = commandString
    End Sub

    Public Sub SetCommandStringAsString(commandString As String)
        commandStr = commandString
    End Sub

    Public Sub setclsAttachNameRFunctionParam(RFunctionParamName As RFunction)
        clsAttachNameRFunctionParam = RFunctionParamName
    End Sub
    Private Sub TryScript()
        Dim strOutPut As String
        Dim strAttach As String
        Dim strDetach As String
        Dim strTempScript As String = ""
        Dim strErrorDetail As String = ""
        Dim strVecOutput As CharacterVector
        Dim clsCommandString As RCodeStructure

        clsAttach.SetRCommand("attach")
        clsAttach.AddParameter("what", clsRFunctionParameter:=clsAttachNameRFunctionParam, iPosition:=0)

        clsDetach.SetRCommand("detach")
        clsDetach.AddParameter("name", clsRFunctionParameter:=clsAttachNameRFunctionParam, iPosition:=0)
        clsDetach.AddParameter("unload", "TRUE", iPosition:=1)


        ucrInputTryMessage.txtInput.Controls.Clear()

        Try
            If bReceiverExpressionIsEmpty Then
                ucrInputTryMessage.SetName("")
            Else
                'get strScript here
                strAttach = clsAttach.Clone().ToScript(strTempScript)
                frmMain.clsRLink.RunInternalScript(strTempScript & strAttach, bSilent:=True)
                strTempScript = ""
                clsCommandString = baseCommandString
                clsCommandString.RemoveAssignTo()
                strOutPut = clsCommandString.ToScript(strTempScript, commandStr)
                strVecOutput = frmMain.clsRLink.RunInternalScriptGetOutput(strTempScript & strOutPut, bSilent:=True, strError:=strErrorDetail)
                If strVecOutput IsNot Nothing Then
                    If strVecOutput.Length > 1 Then
                        ucrInputTryMessage.SetName("Model runs without error")
                        ucrInputTryMessage.txtInput.BackColor = Color.LightGreen
                    End If
                Else
                    ucrInputTryMessage.SetName("Command produced an error or no output to display.")
                    ucrInputTryMessage.txtInput.BackColor = Color.LightCoral
                    AddButtonInTryTextBox()
                    strError = strErrorDetail

                End If
            End If
        Catch ex As Exception
            ucrInputTryMessage.SetName("Command produced an error. Modify input before running.")
            ucrInputTryMessage.txtInput.BackColor = Color.LightCoral
            AddButtonInTryTextBox()
            'Finally
            strTempScript = ""
            strDetach = clsDetach.Clone().ToScript(strTempScript)
            frmMain.clsRLink.RunInternalScript(strTempScript & strDetach, bSilent:=True)
        End Try
    End Sub

    Private Sub AddButtonInTryTextBox()
        Dim btnDetails As New Button
        'Add the button to the try textbox first
        ucrInputTryMessage.txtInput.Controls.Add(btnDetails)
        'setting button properties
        btnDetails.Text = ":::"
        btnDetails.Size = New Size(25, ucrInputTryMessage.txtInput.ClientSize.Height + 2)
        btnDetails.TextAlign = ContentAlignment.TopCenter
        btnDetails.FlatStyle = FlatStyle.Standard
        btnDetails.FlatAppearance.BorderSize = 0
        btnDetails.Cursor = Cursors.Default
        btnDetails.Dock = DockStyle.Right
        btnDetails.BackColor = cmdTry.BackColor
        btnDetails.UseVisualStyleBackColor = True

        'set the btn eventHandler
        AddHandler btnDetails.Click, Sub()
                                         'Shows a pop up that displays the error
                                         Dim frmPopUp As New Form
                                         Dim txtPopUpErrorDetail As New TextBox
                                         frmPopUp.ShowInTaskbar = False
                                         frmPopUp.FormBorderStyle = FormBorderStyle.None
                                         frmPopUp.Size = New Size(ucrInputTryMessage.Width, 120)
                                         frmPopUp.Controls.Add(txtPopUpErrorDetail)

                                         'set the text properties
                                         txtPopUpErrorDetail.Dock = DockStyle.Fill
                                         txtPopUpErrorDetail.Multiline = True
                                         txtPopUpErrorDetail.ScrollBars = ScrollBars.Vertical
                                         txtPopUpErrorDetail.WordWrap = True

                                         AddHandler txtPopUpErrorDetail.LostFocus, Sub()
                                                                                       frmPopUp.Close()
                                                                                   End Sub
                                         AddHandler txtPopUpErrorDetail.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                                                                     If e.Control AndAlso e.KeyCode = Keys.KeyCode.Enter Then
                                                                                         frmPopUp.Close()
                                                                                     End If
                                                                                 End Sub
                                         Dim ctlpos As Point = ucrInputTryMessage.PointToScreen(New Point(0, 0))
                                         frmPopUp.StartPosition = FormStartPosition.Manual
                                         frmPopUp.Location = New Point(ctlpos.X - 2, ctlpos.Y - frmPopUp.Height - 2)
                                         frmPopUp.Show()
                                         txtPopUpErrorDetail.Text = strError
                                         txtPopUpErrorDetail.SelectionStart = txtPopUpErrorDetail.TextLength

                                     End Sub
    End Sub


End Class
