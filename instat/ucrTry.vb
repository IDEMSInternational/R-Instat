' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat
Imports RDotNet
Public Class ucrTry
    Public bFirstLoad As Boolean = False
    Private bIsCommand As Boolean = False
    Private CommandModel As String = ""
    Private bIsModel As Boolean
    Private strError As String
    Private WithEvents ucrReceiverScript As New ucrReceiverExpression
    Private WithEvents ucrModelPreview As New ucrInputTextBox
    Private clsRSyntax As RSyntax
    Private bstrVecOutput As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bFirstLoad = True
        strError = ""
        clsRSyntax = New RSyntax
        bstrVecOutput = False
    End Sub

    Public Sub SetReceiver(Optional ucrNewReceiverScript As ucrReceiverExpression = Nothing, Optional ucrNewInputTextBox As ucrInputTextBox = Nothing)
        If ucrNewReceiverScript IsNot Nothing Then
            ucrReceiverScript = ucrNewReceiverScript
        End If

        If ucrNewInputTextBox IsNot Nothing Then
            ucrModelPreview = ucrNewInputTextBox
        End If
    End Sub

    Public Sub SetRSyntax(clsNewRSyntax As RSyntax)
        clsRSyntax = clsNewRSyntax
    End Sub

    Public Sub StrvecOutputRequired()
        bstrVecOutput = True
    End Sub

    Public Sub SetIsModel()
        bIsModel = True
    End Sub

    Public Sub SetIsCommand()
        bIsCommand = True
    End Sub

    Private Sub setToCommandOrModel()
        If bIsCommand Then
            CommandModel = "Command"
        ElseIf bIsModel Then
            CommandModel = "Model"
        End If
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


    Private Sub TryScript()
        Dim strTempScript As String = ""
        Dim strErrorDetail As String = ""
        Dim strVecOutput As CharacterVector

        Dim lstScripts As New List(Of String)
        Dim strBeforeAfterScript As String
        Dim strBeforeAfterTemp As String
        Dim clsCodeClone As RCodeStructure

        Dim strTemp As String = ""
        Dim strScript As String = ""
        Dim clsMainCode As RCodeStructure = Nothing

        ucrInputTryMessage.txtInput.Controls.Clear()

        Try
            setToCommandOrModel()
            If (ucrReceiverScript.IsEmpty() AndAlso ucrModelPreview.IsEmpty()) Then
                ucrInputTryMessage.SetName("")
            Else

                For Each clsTempCode In clsRSyntax.lstBeforeCodes
                    clsCodeClone = clsTempCode.Clone()
                    strBeforeAfterScript = ""
                    strBeforeAfterTemp = clsCodeClone.ToScript(strBeforeAfterScript)
                    'Sometimes the output of the R-command we deal with should not be part of the script... That's only the case when this output has already been assigned.
                    If clsCodeClone.bExcludeAssignedFunctionOutput AndAlso clsCodeClone.bIsAssigned Then
                        lstScripts.Add(strBeforeAfterScript)
                    Else
                        lstScripts.Add(strBeforeAfterScript & strBeforeAfterTemp)
                    End If
                Next
                If lstScripts.Count > 0 Then
                    strTempScript = String.Join(vbNewLine, lstScripts)
                    frmMain.clsRLink.RunInternalScript(strTempScript, bSilent:=True)
                End If

                If clsRSyntax.bUseBaseFunction Then
                    clsMainCode = clsRSyntax.clsBaseFunction.Clone()
                ElseIf clsRSyntax.bUseBaseOperator Then
                    clsMainCode = clsRSyntax.clsBaseOperator.Clone()
                ElseIf clsRSyntax.bUseCommandString Then
                    clsMainCode = clsRSyntax.clsBaseCommandString.Clone()
                End If
                If clsMainCode IsNot Nothing Then
                    clsMainCode.RemoveAssignTo()
                    strTemp = clsMainCode.ToScript(strScript, clsRSyntax.strCommandString)
                    strVecOutput = frmMain.clsRLink.RunInternalScriptGetOutput(strTemp, bSilent:=True, strError:=strErrorDetail)
                    If strVecOutput IsNot Nothing Then
                        If bstrVecOutput Then
                            If strVecOutput.Length > 1 Then
                                ucrInputTryMessage.SetName(Mid(strVecOutput(0), 5) & "...")
                            Else
                                ucrInputTryMessage.SetName(Mid(strVecOutput(0), 5))
                            End If
                        Else
                            If strVecOutput.Length > 1 Then
                                ucrInputTryMessage.SetName(CommandModel & " runs without error")
                                ucrInputTryMessage.txtInput.BackColor = Color.LightGreen
                            End If
                        End If

                    Else
                        ucrInputTryMessage.SetName(CommandModel & " produced an error or no output to display.")
                        ucrInputTryMessage.txtInput.BackColor = Color.LightCoral
                        strError = strErrorDetail
                        AddButtonInTryTextBox()
                    End If
                End If
            End If
        Catch ex As Exception
            ucrInputTryMessage.SetName(CommandModel & "produced an error. Modify input before running.")
            strError = strErrorDetail
            ucrInputTryMessage.txtInput.BackColor = Color.LightCoral
            AddButtonInTryTextBox()
        Finally
            lstScripts = New List(Of String)
            For Each clsTempCode In clsRSyntax.lstAfterCodes
                clsCodeClone = clsTempCode.Clone()
                strBeforeAfterScript = ""
                strBeforeAfterTemp = clsCodeClone.ToScript(strBeforeAfterScript)
                'Sometimes the output of the R-command we deal with should not be part of the script... That's only the case when this output has already been assigned.
                If clsCodeClone.bExcludeAssignedFunctionOutput AndAlso clsCodeClone.bIsAssigned Then
                    lstScripts.Add(strBeforeAfterScript)
                Else
                    lstScripts.Add(strBeforeAfterScript & strBeforeAfterTemp)
                End If
            Next
            If lstScripts.Count > 0 Then
                strTempScript = String.Join(vbNewLine, lstScripts)
                frmMain.clsRLink.RunInternalScriptGetOutput(strTempScript, bSilent:=True)
            End If
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
                                                                                     If e.Control AndAlso e.KeyCode = Keys.Enter Then
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

    Private Sub ucrReceiverScript_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverScript.SelectionChanged
        ResetInputTryMessage()
    End Sub
    Private Sub ucrModelPreview_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrModelPreview.ControlValueChanged
        ResetInputTryMessage()
    End Sub


    '''--------------------------------------------------------------------------------------------
    ''' <summary> Clears the ucrInputTryMessage textbox and sets its colour to white incase the 
    ''' ucrReceiverScript selection changes on the value for the ucrModelPreview changes    </summary>
    '''--------------------------------------------------------------------------------------------
    Public Sub ResetInputTryMessage()
        ucrInputTryMessage.SetName("")
        ucrInputTryMessage.txtInput.BackColor = Color.White
        ucrInputTryMessage.txtInput.Controls.Clear()
    End Sub
End Class
