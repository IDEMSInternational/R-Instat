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

Imports instat.Translations
Imports RDotNet

Public Class dlgCalculator
    Dim strCalcHistory As List(Of String)
    Dim dataset As DataFrame
    Dim clsAttach As New RFunction
    Dim clsDetach As New RFunction
    Public bFirstLoad As Boolean = True
    Public iHelpCalcID As Integer
    Private iBasicWidth As Integer

    Private Sub dlgCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            iBasicWidth = Me.Width
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrCalc.ucrReceiverForCalculation.IsEmpty Then
            If ucrCalc.chkSaveResultInto.Checked AndAlso ucrCalc.ucrSaveResultInto.IsEmpty Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        ucrCalc.ucrSaveResultInto.SetPrefix("Calc")
        ucrCalc.ucrInputCalOptions.SetName("Basic")
        ucrCalc.Reset()
        ucrCalc.chkShowArguments.Checked = False
        ucrCalc.chkSaveResultInto.Checked = True
        SaveResults()
        ucrCalc.ucrSelectorForCalculations.bUseCurrentFilter = False
        ucrBase.Visible = True
    End Sub

    Private Sub ReopenDialog()
        SaveResults()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 14
        ucrCalc.ucrReceiverForCalculation.SetMeAsReceiver()
        clsAttach.SetRCommand("attach")
        clsDetach.SetRCommand("detach")
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrCalc.ucrSelectorForCalculations.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("name", clsRFunctionParameter:=ucrCalc.ucrSelectorForCalculations.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("unload", "TRUE")
        ucrBase.clsRsyntax.SetCommandString("")
        ucrCalc.ucrSaveResultInto.SetItemsTypeAsColumns()
        ucrCalc.ucrSaveResultInto.SetDefaultTypeAsColumn()
        ucrCalc.ucrSaveResultInto.SetDataFrameSelector(ucrCalc.ucrSelectorForCalculations.ucrAvailableDataFrames)
        ucrCalc.ucrSelectorForCalculations.Reset()
        ucrCalc.ucrSaveResultInto.SetValidationTypeAsRVariable()
    End Sub

    Private Sub ucrCalc_SaveNameChanged() Handles ucrCalc.SaveNameChanged
        SaveResults()
        TestOKEnabled()
    End Sub

    Private Sub SaveResults()
        If ucrCalc.chkSaveResultInto.Checked Then
            ucrBase.clsRsyntax.SetAssignTo(ucrCalc.ucrSaveResultInto.GetText(), strTempColumn:=ucrCalc.ucrSaveResultInto.GetText(), strTempDataframe:=ucrCalc.ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
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
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrCalc.ucrSelectorForCalculations.ucrAvailableDataFrames.clsCurrDataFrame)
        strFunc = clsAttach.ToScript(strScript)
        frmMain.clsRLink.RunScript(strScript & strFunc)
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strScript As String = ""
        Dim strFunc As String
        strFunc = clsDetach.ToScript(strScript)
        frmMain.clsRLink.RunScript(strScript & strFunc)
        ucrCalc.SetCalculationHistory()
    End Sub

    Private Sub ucrCalc_SelectionChanged() Handles ucrCalc.SelectionChanged
        ucrBase.clsRsyntax.SetCommandString(ucrCalc.ucrReceiverForCalculation.GetVariableNames(False))
        ucrCalc.ucrInputTryMessage.SetName("")
        ucrCalc.cmdTry.Enabled = Not ucrCalc.ucrReceiverForCalculation.IsEmpty()
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputCalOptions_NameChanged() Handles ucrCalc.NameChanged
        CalculationsOptions()
    End Sub

    Private Sub CalculationsOptions()
        Select Case ucrCalc.ucrInputCalOptions.GetText
            Case "Maths"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.33, Me.Height)
            Case "Logical and Symbols"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.23, Me.Height)
            Case "Statistics"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.15, Me.Height)
            Case "Strings (Character Columns)"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.24, Me.Height)
            Case "Probability"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.59, Me.Height)
            Case "Dates"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.3, Me.Height)
            Case "Rows"
                Me.Size = New System.Drawing.Size(iBasicWidth * 1.21, Me.Height)
            Case Else
                Me.Size = New System.Drawing.Size(iBasicWidth, Me.Height)
        End Select
    End Sub

    Private Sub chkSaveResultInto_CheckedChanged() Handles ucrCalc.SaveResultsCheckedChanged
        SaveResults()
        ShowControl()
    End Sub

    Private Sub ucrSelectorForCalculations_DataframeChanged() Handles ucrCalc.DataFrameChanged
        ucrCalc.ucrInputTryMessage.SetName("")
        SaveResults()
    End Sub

    Private Sub ShowControl()
        If ucrCalc.chkSaveResultInto.Checked Then
            ucrCalc.ucrSaveResultInto.Visible = True
        Else
            ucrCalc.ucrSaveResultInto.Visible = False
        End If
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

        bIsAssigned = ucrBase.clsRsyntax.GetbIsAssigned()
        bToBeAssigned = ucrBase.clsRsyntax.GetbToBeAssigned()
        strAssignTo = ucrBase.clsRsyntax.GetstrAssignTo()
        'These should really be done through RSyntax methods as above
        strAssignToColumn = ucrBase.clsRsyntax.GetstrAssignToColumn()
        strAssignToDataFrame = ucrBase.clsRsyntax.GetstrAssignToDataFrame()

        Try
            If ucrCalc.ucrReceiverForCalculation.IsEmpty Then
                ucrCalc.ucrInputTryMessage.SetName("")
            Else
                'get strScript here
                strAttach = clsAttach.ToScript(strTempScript)
                frmMain.clsRLink.RunInternalScript(strTempScript & strAttach, bSilent:=True)
                ucrBase.clsRsyntax.RemoveAssignTo()
                strOutPut = ucrBase.clsRsyntax.GetScript
                strVecOutput = frmMain.clsRLink.RunInternalScriptGetOutput(strOutPut, bSilent:=True)
                If strVecOutput IsNot Nothing Then
                    If strVecOutput.Length > 1 Then
                        ucrCalc.ucrInputTryMessage.SetName(Mid(strVecOutput(0), 5) & "...")
                    Else
                        ucrCalc.ucrInputTryMessage.SetName(Mid(strVecOutput(0), 5))
                    End If
                Else
                    ucrCalc.ucrInputTryMessage.SetName("Command produced an error or no output to display.")
                End If
            End If
        Catch ex As Exception
            ucrCalc.ucrInputTryMessage.SetName("Command produced an error. Modify input before running.")
        Finally
            strTempScript = ""
            strDetach = clsDetach.ToScript(strTempScript)
            frmMain.clsRLink.RunInternalScript(strTempScript & strDetach, bSilent:=True)
            ucrBase.clsRsyntax.SetbIsAssigned(bIsAssigned)
            ucrBase.clsRsyntax.SetbToBeAssigned(bToBeAssigned)
            ucrBase.clsRsyntax.SetstrAssignTo(strAssignTo)
            'These should really be done through RSyntax methods as above
            ucrBase.clsRsyntax.SetstrAssignToColumn(strAssignToColumn)
            ucrBase.clsRsyntax.SetstrAssignToDataFrame(strAssignToDataFrame)
        End Try
    End Sub

    Private Sub cmdTry_Click() Handles ucrCalc.TryCommadClick
        TryScript()
    End Sub
End Class