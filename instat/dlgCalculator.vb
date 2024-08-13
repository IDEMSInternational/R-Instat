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

Imports System.ComponentModel
Imports instat.Translations

Public Class dlgCalculator
    Public enumCalculatorMode As String = CalculatorMode.Prepare
    Public Enum CalculatorMode
        Prepare
        Structured
    End Enum

    Private clsAttachFunction As New RFunction
    Private clsDetachFunction As New RFunction
    Private clsRemoveLabelsFunction As New RFunction
    Private clsScalarsDataFuntion, clsAddScalarFunction As New RFunction
    Private clsAttachScalarsFunction, clsDetachScalarsFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Public iHelpCalcID As Integer
    'holds the original width of the form
    Private iBasicWidth As Integer
    Private strDefaultKeyboard As String
    ' Note: This list needs to be updated when a new keyboard is added.
    Private strKeyboards() As String = {"Basic", "Maths", "Logical and Symbols", "Transform", "Summary", "Probability", "Factor", "Text/Strings (Character Columns)", "Dates/Times", "Circular", "Wakefield", "Goodness of Fit", "List", "Complex", "Integer", "Functions"}

    Private Sub dlgCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            iBasicWidth = Me.Width
            SetDefaults()
            bFirstLoad = False
        End If
        SetStructuredMenu()
        ReopenDialog()
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(Not ucrCalc.ucrReceiverForCalculation.IsEmpty)
    End Sub

    Private Sub SetDefaults()
        ucrCalc.ucrInputCalOptions.SetName("Basic")

        ucrCalc.Reset()
        ucrCalc.ucrSelectorForCalculations.Reset()
        ucrCalc.ucrSaveResultInto.Reset()
        ucrCalc.ucrSaveResultInto.ucrChkSave.Checked = True
        ucrCalc.chkShowParameters.Checked = False
        ucrCalc.ucrChkStoreScalar.Checked = False
        ucrCalc.ucrSelectorForCalculations.ResetCheckBoxScalar()
        ucrCalc.ucrSaveResultInto.SetRCode(ucrBase.clsRsyntax.clsBaseCommandString)
        SaveResults()
        ucrCalc.ucrSelectorForCalculations.bUseCurrentFilter = False
        ucrCalc.ucrTryCalculator.SetRSyntax(ucrBase.clsRsyntax)
        ucrBase.clsRsyntax.SetAssignTo(ucrCalc.ucrSaveResultInto.GetText(), strTempColumn:=ucrCalc.ucrSaveResultInto.GetText(),
                                           strTempDataframe:=ucrCalc.ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.Text,
                                           bAssignToIsPrefix:=ucrBase.clsRsyntax.clsBaseCommandString.bAssignToIsPrefix,
                                           bAssignToColumnWithoutNames:=ucrBase.clsRsyntax.clsBaseCommandString.bAssignToColumnWithoutNames,
                                           bInsertColumnBefore:=ucrBase.clsRsyntax.clsBaseCommandString.bInsertColumnBefore,
                                           bRequireCorrectLength:=ucrBase.clsRsyntax.clsBaseCommandString.bRequireCorrectLength)
        ucrBase.Visible = True
        SetStructuredMenu()
    End Sub

    Private Sub ReopenDialog()
        SaveResults()
        ucrCalc.ucrSelectorForCalculations.ShowCheckBoxScalar(True)
        ucrCalc.ucrChkStoreScalar.Checked = False
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 14

        ucrCalc.ucrReceiverForCalculation.SetMeAsReceiver()
        ucrCalc.ucrTryCalculator.SetIsCommand()
        ucrCalc.ucrTryCalculator.SetReceiver(ucrCalc.ucrReceiverForCalculation)

        ucrCalc.ucrSelectorForCalculations.SetItemType("column")
        ucrCalc.ucrReceiverForCalculation.strSelectorHeading = "Variables"

        clsAddScalarFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_scalar")

        clsScalarsDataFuntion.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_scalars")
        clsScalarsDataFuntion.SetAssignTo("scalars")

        clsRemoveLabelsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$append_to_variables_metadata")
        clsRemoveLabelsFunction.AddParameter("property", Chr(34) & "labels" & Chr(34), iPosition:=2)
        clsRemoveLabelsFunction.AddParameter("new_val", Chr(34) & Chr(34), iPosition:=3)

        clsAttachFunction.SetRCommand("attach")
        clsDetachFunction.SetRCommand("detach")
        clsAttachFunction.AddParameter("what", clsRFunctionParameter:=ucrCalc.ucrSelectorForCalculations.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetachFunction.AddParameter("unload", "TRUE")

        clsAttachScalarsFunction.SetRCommand("attach")
        clsDetachScalarsFunction.SetRCommand("detach")
        clsAttachScalarsFunction.AddParameter("what", clsRFunctionParameter:=clsScalarsDataFuntion)
        clsDetachScalarsFunction.AddParameter("name", "scalars")
        clsDetachScalarsFunction.AddParameter("unload", "TRUE")

        ucrBase.clsRsyntax.AddToBeforeCodes(clsAttachFunction, 0)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsAttachScalarsFunction, 1)

        ucrBase.clsRsyntax.AddToAfterCodes(clsDetachFunction, 1)
        ucrBase.clsRsyntax.AddToAfterCodes(clsDetachScalarsFunction, 2)

        ucrBase.clsRsyntax.SetCommandString("")

        ucrCalc.ucrSaveResultInto.SetPrefix("calc")
        ucrCalc.ucrSaveResultInto.SetSaveTypeAsColumn()
        ucrCalc.ucrSaveResultInto.SetIsComboBox()
        ucrCalc.ucrSaveResultInto.SetCheckBoxText("Store Result")
        ucrCalc.ucrSaveResultInto.SetAssignToIfUncheckedValue("last_calc")

        ucrCalc.ucrSaveResultInto.SetDataFrameSelector(ucrCalc.ucrSelectorForCalculations.ucrAvailableDataFrames)
        ucrCalc.ucrTryCalculator.StrvecOutputRequired()

        AddHandler ucrCalc.ucrSelectorForCalculations.checkBoxScalar.CheckedChanged, AddressOf checkBoxScalar_CheckedChanged

    End Sub

    Private Sub checkBoxScalar_CheckedChanged()
        SetItemType()
    End Sub

    Private Sub SetItemType()
        If Not String.IsNullOrEmpty(ucrCalc.ucrSelectorForCalculations.strCurrentDataFrame) Then
            If ucrCalc.ucrSelectorForCalculations.checkBoxScalar.Checked Then
                ucrCalc.ucrReceiverForCalculation.strSelectorHeading = "Scalars"
                ucrCalc.ucrSelectorForCalculations.SetItemType("scalar")
            Else
                ucrCalc.ucrReceiverForCalculation.strSelectorHeading = "Variables"
                ucrCalc.ucrSelectorForCalculations.SetItemType("column")
            End If
        End If
    End Sub

    Public Sub SetDefaultKeyboard(strNewDefaultKeyboard As String)
        If Not strKeyboards.Contains(strNewDefaultKeyboard) Then
            MsgBox("Developer error: there is no Calculator keyboard called" & Chr(34) & strNewDefaultKeyboard & Chr(34) & vbNewLine & "Default keyboard will be selected.")
            strDefaultKeyboard = ""
        Else
            strDefaultKeyboard = strNewDefaultKeyboard
        End If
    End Sub

    Private Sub ucrCalc_SaveNameChanged() Handles ucrCalc.SaveNameChanged
        SaveResults()
    End Sub

    Private Sub ucrCalc_ControlValueChanged() Handles ucrCalc.ControlValueChanged
        SaveResults()
    End Sub

    ''' <summary>
    ''' Determines where the results will be saved; to a column or output window
    ''' </summary>
    Private Sub SaveResults()
        If ucrCalc.ucrSaveResultInto.ucrChkSave.Checked AndAlso ucrCalc.ucrSaveResultInto.IsComplete Then
            clsRemoveLabelsFunction.AddParameter("col_names", Chr(34) & ucrCalc.ucrSaveResultInto.GetText() & Chr(34), iPosition:=1)
            ucrBase.clsRsyntax.AddToAfterCodes(clsRemoveLabelsFunction, 3)
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
            ucrBase.clsRsyntax.iCallType = 0
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRemoveLabelsFunction)
            ucrBase.clsRsyntax.RemoveAssignTo()
            ucrBase.clsRsyntax.iCallType = 5
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
        ManageScalarStorage()
    End Sub

    Private Sub ManageScalarStorage()

        Dim dataFrameName As String = ucrCalc.ucrSelectorForCalculations.strCurrentDataFrame

        ' Check if scalar should be stored
        If ucrCalc.ucrChkStoreScalar.Checked AndAlso Not ucrCalc.ucrReceiverForCalculation.IsEmpty _
        AndAlso ucrCalc.ucrSaveResultInto.GetText <> "" _
        AndAlso Not String.IsNullOrEmpty(dataFrameName) Then
            Dim strResut As String = ucrCalc.ucrSaveResultInto.GetText
            clsAddScalarFunction.AddParameter("scalar_name", Chr(34) & strResut & Chr(34), iPosition:=1)
            clsAddScalarFunction.AddParameter("scalar_value", strResut, iPosition:=2)
            ucrBase.clsRsyntax.AddToAfterCodes(clsAddScalarFunction, 0)
            ucrBase.clsRsyntax.SetAssignTo(strResut)
            ucrCalc.ucrSaveResultInto.btnColumnPosition.Enabled = False
            ucrCalc.ucrSaveResultInto.btnColumnPosition.Visible = True
            ucrCalc.ucrSaveResultInto.ucrChkSave.Checked = False
            ucrCalc.ucrSaveResultInto.ucrChkSave.Enabled = False
            ucrCalc.ucrSaveResultInto.ucrInputComboSave.Visible = True
            ucrCalc.ucrSaveResultInto.ucrInputComboSave.Enabled = True
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsAddScalarFunction)
            ucrCalc.ucrSaveResultInto.btnColumnPosition.Enabled = True
            ucrCalc.ucrSaveResultInto.btnColumnPosition.Visible = True
            ucrCalc.ucrSaveResultInto.ucrChkSave.Enabled = True
            ucrCalc.ucrSaveResultInto.ucrInputComboSave.Visible = True
            ucrCalc.ucrSaveResultInto.ucrInputComboSave.Enabled = True

        End If

        ' Update command string and clear input try message name
        ucrBase.clsRsyntax.SetCommandString(ucrCalc.ucrReceiverForCalculation.GetVariableNames(False))

        ' Test if OK button can be enabled
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        ucrCalc.SetCalculationHistory()
    End Sub

    Private Sub ucrCalc_SelectionChanged() Handles ucrCalc.SelectionChanged
        ucrCalc.ucrChkStoreScalar.Checked = False
        ManageScalarStorage()
        SaveResults()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorForCalculation_DataframeChanged() Handles ucrCalc.DataFrameChanged
        If Not String.IsNullOrEmpty(ucrCalc.ucrSelectorForCalculations.strCurrentDataFrame) Then
            Dim strDataFrame As String = ucrCalc.ucrSelectorForCalculations.strCurrentDataFrame
            ucrCalc.ucrTryCalculator.ucrInputTryMessage.SetName("")
            clsScalarsDataFuntion.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34))
            clsDetachFunction.AddParameter("name", strDataFrame)
            clsAddScalarFunction.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
            clsRemoveLabelsFunction.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
            SaveResults()
            ucrBase.clsRsyntax.AddToBeforeCodes(clsAttachFunction, 0)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsAttachScalarsFunction, 1)

            ucrBase.clsRsyntax.AddToAfterCodes(clsDetachFunction, 1)
            ucrBase.clsRsyntax.AddToAfterCodes(clsDetachScalarsFunction, 2)
            ucrCalc.ucrSaveResultInto.Enabled = True
            ucrCalc.ucrChkStoreScalar.Visible = True
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsAttachFunction)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsAttachScalarsFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDetachFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDetachScalarsFunction)
            ucrCalc.ucrSelectorForCalculations.ResetCheckBoxScalar()
            ucrCalc.ucrSaveResultInto.Enabled = False
            ucrCalc.ucrChkStoreScalar.Visible = False
            ucrCalc.ucrChkStoreScalar.Checked = False
        End If
    End Sub

    Private Sub SetStructuredMenu()
        Select Case enumCalculatorMode
            Case CalculatorMode.Structured
                ucrCalc.ucrInputCalOptions.SetName("Circular")
                ucrBase.iHelpTopicID = 677
        End Select
    End Sub

    Private Sub ucrCalc_Click() Handles ucrCalc.CheckBoxClick
        ManageScalarStorage()
    End Sub

    Private Sub ucrCalc_ClearClick() Handles ucrCalc.ClearClick
        ucrCalc.ucrChkStoreScalar.Checked = False
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputCalOptions_NameChanged() Handles ucrCalc.NameChanged
        Select Case ucrCalc.ucrInputCalOptions.GetText
            Case "Functions"
                Me.Width = iBasicWidth * 1.4
                ucrBase.iHelpTopicID = 167
            Case "Maths"
                Me.Width = iBasicWidth * 1.38
                ucrBase.iHelpTopicID = 126
            Case "Logical and Symbols"
                Me.Width = iBasicWidth * 1.4
                ucrBase.iHelpTopicID = 127
            Case "Summary"
                Me.Width = iBasicWidth * 1.46
                ucrBase.iHelpTopicID = 128
            Case "Text/Strings (Character Columns)"
                Me.Width = iBasicWidth * 1.49
                ucrBase.iHelpTopicID = 338
            Case "Factor"
                Me.Width = iBasicWidth * 1.4
                ucrBase.iHelpTopicID = 44
            Case "Probability"
                Me.Width = iBasicWidth * 1.5
                ucrBase.iHelpTopicID = 129
            Case "Dates/Times"
                Me.Width = iBasicWidth * 1.37
                ucrBase.iHelpTopicID = 130
            Case "Transform"
                Me.Width = iBasicWidth * 1.48
                ucrBase.iHelpTopicID = 166
            Case "Circular"
                Me.Width = iBasicWidth * 1.36
                ucrBase.iHelpTopicID = 596
            Case "Wakefield"
                Me.Width = iBasicWidth * 1.73
                ucrBase.iHelpTopicID = 444
            Case "Modifier"
                Me.Width = iBasicWidth * 1.39
            Case "Symbols"
                Me.Width = iBasicWidth * 2.56
            Case "Goodness of Fit"
                Me.Width = iBasicWidth * 1.25
                ucrBase.iHelpTopicID = 717
            Case "Integer"
                Me.Width = iBasicWidth * 1.5
                ucrBase.iHelpTopicID = 463
            Case "Complex"
                Me.Width = iBasicWidth * 1.5
                ucrBase.iHelpTopicID = 455
            Case "List"
                Me.Width = iBasicWidth * 1.5
                ucrBase.iHelpTopicID = 439
            Case Else
                Me.Width = iBasicWidth
                ucrBase.iHelpTopicID = 14
        End Select
    End Sub
End Class


