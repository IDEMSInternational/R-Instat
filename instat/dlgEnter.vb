' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Imports RDotNet
Public Class dlgEnter
    Dim dataset As DataFrame
    Dim clsAttach As New RFunction
    Dim clsDetach As New RFunction
    Dim clsLength As New RFunction
    Public bFirstLoad As Boolean = True
    Public strOutput As String
    Public clsCommands As New RFunction

    Private Sub dlgEnter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub
    Private Sub SetEntryHistory()
        ucrReceiverForEnterCalculation.AddtoCombobox(ucrReceiverForEnterCalculation.GetText)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 458
        clsAttach.SetRCommand("attach")
        clsDetach.SetRCommand("detach")
        clsDetach.AddParameter("unload", "TRUE")
        ucrBase.clsRsyntax.SetCommandString("")
        ucrSaveEnterResultInto.SetItemsTypeAsColumns()
        ucrSaveEnterResultInto.SetDefaultTypeAsColumn()
        ucrSaveEnterResultInto.SetDataFrameSelector(ucrDataFrameEnter)
        ucrSaveEnterResultInto.SetValidationTypeAsRVariable()
        cmdTry.Enabled = False
    End Sub
    Private Sub SetDefaults()
        chkShowEnterArguments.Checked = False
        ucrDataFrameEnter.Reset()
        chkSaveEnterResultInto.Checked = True
        ucrSaveEnterResultInto.SetPrefix("Enter")
        ucrReceiverForEnterCalculation.Clear()
    End Sub
    Private Sub ReopenDialog()
        SaveResults()
    End Sub
    Private Sub TestOKEnabled()
        If Not ucrReceiverForEnterCalculation.IsEmpty Then
            If chkSaveEnterResultInto.Checked AndAlso Not ucrSaveEnterResultInto.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SaveResults()
        If chkSaveEnterResultInto.Checked Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveEnterResultInto.GetText(), strTempColumn:=ucrSaveEnterResultInto.GetText(), strTempDataframe:=ucrDataFrameEnter.cboAvailableDataFrames.Text)
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
            ucrBase.clsRsyntax.iCallType = 0
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
            ucrBase.clsRsyntax.iCallType = 2
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        Dim strScript As String = ""
        Dim strFunc As String
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrDataFrameEnter.clsCurrDataFrame)
        strFunc = clsAttach.ToScript(strScript)
        frmMain.clsRLink.RunScript(strScript & strFunc)
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strScript As String = ""
        Dim strFunc As String
        clsDetach.AddParameter("name", clsRFunctionParameter:=ucrDataFrameEnter.clsCurrDataFrame)
        strFunc = clsDetach.ToScript(strScript)
        frmMain.clsRLink.RunScript(strScript & strFunc)
        SetEntryHistory()
    End Sub

    Private Sub ucrReceiverForCalculation_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForEnterCalculation.SelectionChanged
        ucrBase.clsRsyntax.SetCommandString(ucrReceiverForEnterCalculation.GetVariableNames(False))
        ucrInputTryMessage.SetName("")
        cmdTry.Enabled = Not ucrReceiverForEnterCalculation.IsEmpty()
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub
    Private Sub cmd0_Click(sender As Object, e As EventArgs) Handles cmd0.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("0")
        TestOKEnabled()
    End Sub
    Private Sub cmd1_Click(sender As Object, e As EventArgs) Handles cmd1.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("1")
        TestOKEnabled()
    End Sub

    Private Sub md2_Click(sender As Object, e As EventArgs) Handles cmd2.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("2")
        TestOKEnabled()
    End Sub

    Private Sub cmd3_Click(sender As Object, e As EventArgs) Handles cmd3.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("3")
        TestOKEnabled()
    End Sub

    Private Sub cmd4_Click(sender As Object, e As EventArgs) Handles cmd4.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("4")
        TestOKEnabled()
    End Sub

    Private Sub cmd5_Click(sender As Object, e As EventArgs) Handles cmd5.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("5")
        TestOKEnabled()
    End Sub

    Private Sub cmd6_Click(sender As Object, e As EventArgs) Handles cmd6.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("6")
        TestOKEnabled()
    End Sub

    Private Sub cmd7_Click(sender As Object, e As EventArgs) Handles cmd7.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("7")
        TestOKEnabled()
    End Sub

    Private Sub cmd8_Click(sender As Object, e As EventArgs) Handles cmd8.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("8")
        TestOKEnabled()
    End Sub

    Private Sub cmd9_Click(sender As Object, e As EventArgs) Handles cmd9.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("9")
        TestOKEnabled()
    End Sub

    Private Sub cmdColon_Click(sender As Object, e As EventArgs) Handles cmdColon.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition(":")
        TestOKEnabled()
    End Sub
    Private Sub cmdMissingValues_Click(sender As Object, e As EventArgs)
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("NA")
        TestOKEnabled()
    End Sub
    Private Sub cmdDot_Click(sender As Object, e As EventArgs) Handles cmdDot.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition(".")
        TestOKEnabled()
    End Sub

    Private Sub cmdBrackets_Click(sender As Object, e As EventArgs) Handles cmdBrackets.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("( )", 2)
        TestOKEnabled()
    End Sub
    Private Sub cmdMinus_Click(sender As Object, e As EventArgs) Handles cmdMinus.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("-")
        TestOKEnabled()
    End Sub

    Private Sub cmdComma_Click(sender As Object, e As EventArgs) Handles cmdComma.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition(",")
        TestOKEnabled()
    End Sub
    Private Sub cmdDelete_Click_1(sender As Object, e As EventArgs) Handles cmdDelete.Click
        ucrReceiverForEnterCalculation.Backspace()
        TestOKEnabled()
    End Sub
    Private Sub cmdPi_Click(sender As Object, e As EventArgs) Handles cmdPi.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("pi")
        TestOKEnabled()
    End Sub

    Private Sub cmdMissingValues_Click_1(sender As Object, e As EventArgs) Handles cmdMissingValues.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("NA")
    End Sub

    Private Sub cmdSquareBrackets_Click_1(sender As Object, e As EventArgs) Handles cmdSquareBrackets.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("[ ]", 2)
        TestOKEnabled()
    End Sub

    Private Sub cmdExponential_Click_1(sender As Object, e As EventArgs) Handles cmdExponential.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("E")
        TestOKEnabled()
    End Sub
    Private Sub cmdConcantenateFunction_Click_1(sender As Object, e As EventArgs) Handles cmdConcantenateFunction.Click
        If chkShowEnterArguments.Checked Then
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("c( ,recursive=FALSE)", 17)
        Else
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("c( )", 2)
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdRepelicationFunction_Click_1(sender As Object, e As EventArgs) Handles cmdRepelicationFunction.Click
        If chkShowEnterArguments.Checked Then
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("rep(x= ,times= ,length= ,each= )", 25)
        Else ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("rep( )", 2)
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdSequenceFunction_Click_1(sender As Object, e As EventArgs) Handles cmdSequenceFunction.Click
        If chkShowEnterArguments.Checked Then
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("seq(from= ,to= ,by= )", 11)
        Else ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("seq( )", 2)
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdSequence2_Click_1(sender As Object, e As EventArgs) Handles cmdSequence2.Click
        Dim length As Integer = ucrDataFrameEnter.iDataFrameLength
        If chkShowEnterArguments.Checked Then
            ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("seq(from= ,to= ,length= )", 15)
        Else ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("seq( )", 2)
        End If
        TestOKEnabled()
    End Sub
    Private Sub cmdClear_Click_1(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrReceiverForEnterCalculation.Clear()
        TestOKEnabled()
    End Sub

    Private Sub cmdLETTERS_Click(sender As Object, e As EventArgs) Handles cmdLETTERS.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("LETTERS")
        TestOKEnabled()
    End Sub

    Private Sub cmdLetters2_Click(sender As Object, e As EventArgs) Handles cmdLetters2.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("letters")
        TestOKEnabled()
    End Sub

    Private Sub cmdMonthMinus_Click(sender As Object, e As EventArgs) Handles cmdMonthMinus.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("month.abb")
        TestOKEnabled()
    End Sub

    Private Sub cmdMonthPlus_Click(sender As Object, e As EventArgs) Handles cmdMonthPlus.Click
        ucrReceiverForEnterCalculation.AddToReceiverAtCursorPosition("month.name")
        TestOKEnabled()
    End Sub

    Private Sub ucrSaveEnterResultInto_NameChanged() Handles ucrSaveEnterResultInto.NameChanged
        SaveResults()
    End Sub

    Private Sub ucrSaveEnterResultInto_ContentsChanged() Handles ucrSaveEnterResultInto.ContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub chkSaveEnterResultInto_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveEnterResultInto.CheckedChanged
        If chkSaveEnterResultInto.Checked Then
            ucrSaveEnterResultInto.Visible = True
        Else
            ucrSaveEnterResultInto.Visible = False
        End If
        SaveResults()
    End Sub

    Private Sub TryScript()
        Dim strOutPut As String
        Dim strAttach As String
        Dim strDetach As String
        Dim strTempScript As String = ""
        Dim strVecOutput As CharacterVector
        Dim bIsAssigned As Boolean
        Dim bToBeAssigned As Boolean
        Dim strAssignTo As String
        Dim strAssignToColumn As String
        Dim strAssignToDataFrame As String

        'First store the RSyntax settings temporarily, as these will be modified in the Try process. 
        'Task: could use a clone RSyntax method

        bIsAssigned = ucrBase.clsRsyntax.GetbIsAssigned()
        bToBeAssigned = ucrBase.clsRsyntax.GetbToBeAssigned()
        strAssignTo = ucrBase.clsRsyntax.GetstrAssignTo()
        strAssignToColumn = ucrBase.clsRsyntax.GetstrAssignToColumn()
        strAssignToDataFrame = ucrBase.clsRsyntax.GetstrAssignToDataFrame()

        Try
            If ucrReceiverForEnterCalculation.IsEmpty Then
                ucrInputTryMessage.SetName("")
            Else
                strAttach = clsAttach.ToScript(strTempScript)
                frmMain.clsRLink.RunInternalScript(strTempScript & strAttach, bSilent:=True)
                ucrBase.clsRsyntax.RemoveAssignTo()
                strOutPut = ucrBase.clsRsyntax.GetScript
                strVecOutput = frmMain.clsRLink.RunInternalScriptGetOutput(strOutPut, bSilent:=True)
                'Mid does only take Strings And strVecOutput Is a CharacterVector (a custom type from RDotNet), 
                'but each element of strVecOutput i.e. strVecOutput(0) Is a String.
                'It doesn't show all the output, just the output from the first line you would get in the R console. So strVecOutput(1) would give you the next line.
                If strVecOutput IsNot Nothing Then
                    If strVecOutput.Length > 1 Then
                        ucrInputTryMessage.SetName(Mid(strVecOutput(0), 5) & "...")
                    Else
                        ucrInputTryMessage.SetName(Mid(strVecOutput(0), 5))
                    End If
                Else
                    ucrInputTryMessage.SetName("Command produced an error or no output to display.")
                End If
            End If
        Catch ex As Exception
            ucrInputTryMessage.SetName("Command produced an error. Modify input before running.")
        Finally

            strTempScript = ""
            strDetach = clsDetach.ToScript(strTempScript)
            frmMain.clsRLink.RunInternalScript(strTempScript & strDetach, bSilent:=True)
            ucrBase.clsRsyntax.SetbIsAssigned(bIsAssigned)
            ucrBase.clsRsyntax.SetbToBeAssigned(bToBeAssigned)
            ucrBase.clsRsyntax.SetstrAssignTo(strAssignTo)
            ucrBase.clsRsyntax.SetstrAssignToColumn(strAssignToColumn)
            ucrBase.clsRsyntax.SetstrAssignToDataFrame(strAssignToDataFrame)
        End Try
    End Sub


    Private Sub cmdTry_Click(sender As Object, e As EventArgs) Handles cmdTry.Click
        TryScript()
    End Sub
End Class
