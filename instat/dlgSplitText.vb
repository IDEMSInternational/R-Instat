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
Public Class dlgSplitText
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsTextComponentsFixed, clsTextComponentsMaximum, clsStringCollFunction As New RFunction
    Private clsBinaryColumns As New RFunction
    Private clsSplitDummyFunction As New RFunction
    Private clsPatternDummyFunction As New RFunction
    Private dctPatternPairs As New Dictionary(Of String, String)

    Private Sub dlgSplitText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 344

        ucrPnlSplitText.AddRadioButton(rdoTextComponents)
        ucrPnlSplitText.AddRadioButton(rdoBinaryColumns)

        ucrPnlSplitText.AddFunctionNamesCondition(rdoBinaryColumns, "multi.split", True)
        ucrPnlSplitText.AddFunctionNamesCondition(rdoTextComponents, "multi.split", False)

        ucrPnlTextComponents.AddRadioButton(rdoFixedNumberOfComponents)
        ucrPnlTextComponents.AddRadioButton(rdoMaximumNumberOfComponents)

        ucrPnlTextComponents.AddFunctionNamesCondition(rdoMaximumNumberOfComponents, "str_split")
        ucrPnlTextComponents.AddFunctionNamesCondition(rdoFixedNumberOfComponents, "str_split_fixed")

        ucrPnlTextComponents.AddToLinkedControls(ucrNudPieces, {rdoFixedNumberOfComponents}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=2, bNewLinkedChangeParameterValue:=True)
        ucrPnlSplitText.AddToLinkedControls(ucrSaveColumn, {rdoTextComponents}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSplitText.AddToLinkedControls(ucrChkIncludeRegularExpressions, {rdoTextComponents}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSplitText.AddToLinkedControls(ucrPnlTextComponents, {rdoTextComponents}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoFixedNumberOfComponents)
        ucrNudPieces.SetLinkedDisplayControl(lblNumberofPiecesToReturn)

        ucrReceiverSplitTextColumn.SetParameter(New RParameter("string", 0))
        ucrReceiverSplitTextColumn.SetParameterIsRFunction()
        ucrReceiverSplitTextColumn.Selector = ucrSelectorSplitTextColumn
        ucrReceiverSplitTextColumn.SetMeAsReceiver()
        ucrReceiverSplitTextColumn.bUseFilteredData = False

        ucrInputPattern.SetParameter(New RParameter("pattern", 1))
        dctPatternPairs.Add("Space ( )", Chr(34) & " " & Chr(34))
        dctPatternPairs.Add("Period .", Chr(34) & "." & Chr(34))
        dctPatternPairs.Add("Comma ,", Chr(34) & "," & Chr(34))
        dctPatternPairs.Add("Colon :", Chr(34) & ":" & Chr(34))
        dctPatternPairs.Add("Semicolon ;", Chr(34) & ";" & Chr(34))
        dctPatternPairs.Add("Hyphen -", Chr(34) & "-" & Chr(34))
        dctPatternPairs.Add("Underscore _", Chr(34) & "_" & Chr(34))
        ucrInputPattern.SetItems(dctPatternPairs)
        ucrInputPattern.SetRDefault(Chr(34) & "," & Chr(34))

        ucrNudPieces.SetParameter(New RParameter("n", 2))
        ucrNudPieces.SetMinMax(2, Integer.MaxValue)

        ucrChkIncludeRegularExpressions.SetText("Include Regular Expressions")
        ucrChkIncludeRegularExpressions.SetParameter(New RParameter("checked", 0))
        ucrChkIncludeRegularExpressions.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkIncludeRegularExpressions.SetRDefault("FALSE")

        'This is not yet implemented
        ucrChkAddKeyboard.SetText("Add keyboard")
        ucrChkAddKeyboard.Enabled = False
        ucrChkAddKeyboard.Visible = False

        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetDataFrameSelector(ucrSelectorSplitTextColumn.ucrAvailableDataFrames)
        ucrSaveColumn.SetLabelText("Prefix for New Columns:")
        ucrSaveColumn.SetIsComboBox()
        ucrSaveColumn.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
        ucrSaveColumn.setLinkedReceiver(ucrReceiverSplitTextColumn)
    End Sub

    Private Sub SetDefaults()
        clsTextComponentsFixed = New RFunction
        clsTextComponentsMaximum = New RFunction
        clsBinaryColumns = New RFunction
        clsStringCollFunction = New RFunction
        clsSplitDummyFunction = New RFunction
        clsPatternDummyFunction = New RFunction

        ucrSelectorSplitTextColumn.Reset()

        clsStringCollFunction.SetPackageName("stringr")
        clsStringCollFunction.SetRCommand("coll")
        clsStringCollFunction.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=0)

        clsBinaryColumns.SetPackageName("questionr")
        clsBinaryColumns.SetRCommand("multi.split")

        clsTextComponentsFixed.SetPackageName("stringr")
        clsTextComponentsFixed.SetRCommand("str_split_fixed")
        clsTextComponentsFixed.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
        clsTextComponentsFixed.AddParameter("n", strParameterValue:=2, iPosition:=2)

        clsTextComponentsMaximum.SetPackageName("stringr")
        clsTextComponentsMaximum.SetRCommand("str_split")
        clsTextComponentsMaximum.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
        clsTextComponentsMaximum.AddParameter("n", "Inf", iPosition:=2)
        clsTextComponentsMaximum.AddParameter("simplify", "TRUE", iPosition:=3)

        clsTextComponentsFixed.SetAssignTo(strTemp:="split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="split", bAssignToIsPrefix:=True)
        clsTextComponentsMaximum.SetAssignTo("split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="split", bAssignToIsPrefix:=True)
        clsBinaryColumns.SetAssignTo("split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToColumnWithoutNames:=True)
        ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponentsFixed)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverSplitTextColumn.AddAdditionalCodeParameterPair(clsTextComponentsMaximum, New RParameter("string", 0), iAdditionalPairNo:=1)
        ucrReceiverSplitTextColumn.AddAdditionalCodeParameterPair(clsBinaryColumns, New RParameter("var", 0), iAdditionalPairNo:=2)
        ucrSaveColumn.AddAdditionalRCode(clsTextComponentsMaximum, bReset)
        ucrReceiverSplitTextColumn.SetRCode(clsTextComponentsFixed, bReset)
        ucrInputPattern.SetRCode(clsPatternDummyFunction, bReset)
        ucrNudPieces.SetRCode(clsTextComponentsFixed, bReset)
        ucrChkIncludeRegularExpressions.SetRCode(clsSplitDummyFunction, bReset)
        ucrPnlSplitText.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlTextComponents.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSaveColumn.SetRCode(clsTextComponentsFixed, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverSplitTextColumn.IsEmpty() AndAlso Not ucrInputPattern.IsEmpty AndAlso ((rdoTextComponents.Checked AndAlso ucrNudPieces.GetText <> "" AndAlso ucrSaveColumn.IsComplete()) OrElse rdoBinaryColumns.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlSplitText_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSplitText.ControlValueChanged
        If rdoBinaryColumns.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsBinaryColumns)
        ElseIf rdoTextComponents.Checked Then
            SplitTextOptions()
        End If
        ChangeParametersValues()
    End Sub

    Private Sub ucrPnlTextComponents_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlTextComponents.ControlValueChanged
        SplitTextOptions()
        ChangeParametersValues()
    End Sub

    Private Sub ChangeParametersValues()
        Dim strPattern As String

        If dctPatternPairs.ContainsKey(ucrInputPattern.GetText) Then
            strPattern = dctPatternPairs(ucrInputPattern.GetText)
        Else
            strPattern = Chr(34) & ucrInputPattern.GetText & Chr(34)
        End If
        clsTextComponentsFixed.RemoveParameterByName("pattern")
        clsTextComponentsMaximum.RemoveParameterByName("pattern")
        clsBinaryColumns.AddParameter("split.char", strPattern, iPosition:=1)
        If ucrChkIncludeRegularExpressions.Checked Then
            clsTextComponentsFixed.AddParameter("pattern", strPattern, iPosition:=1)
            clsTextComponentsMaximum.AddParameter("pattern", strPattern, iPosition:=1)
        Else
            clsStringCollFunction.AddParameter("pattern", strPattern, iPosition:=0)
            clsTextComponentsFixed.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, iPosition:=1)
            clsTextComponentsMaximum.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, iPosition:=1)
        End If
    End Sub

    Private Sub SplitTextOptions()
        If rdoFixedNumberOfComponents.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponentsFixed)
        ElseIf rdoMaximumNumberOfComponents.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponentsMaximum)
        End If
    End Sub

    Private Sub ucrChkIncludeRegularExpressions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeRegularExpressions.ControlValueChanged, ucrReceiverSplitTextColumn.ControlValueChanged, ucrInputPattern.ControlValueChanged
        ChangeParametersValues()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputPattern.ControlContentsChanged, ucrReceiverSplitTextColumn.ControlContentsChanged, ucrNudPieces.ControlContentsChanged, ucrSaveColumn.ControlContentsChanged, ucrPnlSplitText.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class