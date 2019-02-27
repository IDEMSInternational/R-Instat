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
Imports instat.Translations
Public Class dlgSplitText
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsTextComponents, clsTextComponents2 As New RFunction
    Private clsBinaryColumns As New RFunction

    Private Sub dlgSplitText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
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
    End Sub

    Private Sub InitialiseDialog()
        Dim dctPatternPairs As New Dictionary(Of String, String)
        ucrBase.iHelpTopicID = 344

        ucrPnlSplitText.AddRadioButton(rdoTextComponents)
        ucrPnlSplitText.AddRadioButton(rdoBinaryColumns)

        ucrPnlSplitText.AddFunctionNamesCondition(rdoBinaryColumns, "multi.split", True)
        ucrPnlSplitText.AddFunctionNamesCondition(rdoTextComponents, "multi.split", False)

        ucrPnlTextComponents.AddRadioButton(rdoFixedNumberOfComponents)
        ucrPnlTextComponents.AddRadioButton(rdoMaximumNumberOfComponents)

        ucrPnlTextComponents.AddFunctionNamesCondition(rdoMaximumNumberOfComponents, "str_split")
        ucrPnlTextComponents.AddFunctionNamesCondition(rdoFixedNumberOfComponents, "str_split_fixed")

        ucrPnlTextComponents.AddToLinkedControls(ucrNudPieces, {rdoFixedNumberOfComponents}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)
        ucrPnlSplitText.AddToLinkedControls(ucrSaveColumn, {rdoTextComponents}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSplitText.AddToLinkedControls(ucrPnlTextComponents, {rdoTextComponents}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlSplitText.AddToLinkedControls(ucrSaveColumn, {rdoTextComponents}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudPieces.SetLinkedDisplayControl(lblNumberofPiecesToReturn)


        ucrReceiverSplitTextColumn.SetParameter(New RParameter("string", 0))
        ucrReceiverSplitTextColumn.SetParameterIsRFunction()
        ucrReceiverSplitTextColumn.Selector = ucrSelectorSplitTextColumn
        ucrReceiverSplitTextColumn.SetMeAsReceiver()
        ucrReceiverSplitTextColumn.bUseFilteredData = False

        ucrInputPattern.SetParameter(New RParameter("pattern", 1))
        dctPatternPairs.Add("Space ( )", Chr(34) & " " & Chr(34))
        dctPatternPairs.Add("Period .", "stringr::fixed(" & Chr(34) & "." & Chr(34) & ")")
        dctPatternPairs.Add("Comma ,", Chr(34) & "," & Chr(34))
        dctPatternPairs.Add("Colon :", Chr(34) & ":" & Chr(34))
        dctPatternPairs.Add("Semicolon ;", Chr(34) & ";" & Chr(34))
        dctPatternPairs.Add("Hyphen -", Chr(34) & "-" & Chr(34))
        dctPatternPairs.Add("Underscore _", Chr(34) & "_" & Chr(34))
        ucrInputPattern.SetItems(dctPatternPairs)
        'ucrInputPattern.SetRDefault(Chr(34) & " " & Chr(34)) 'This is the default for clsTextComponents
        ucrInputPattern.bAllowNonConditionValues = True

        ucrNudPieces.SetParameter(New RParameter("n", 2))
        ucrNudPieces.SetMinMax(2, Integer.MaxValue)

        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetDataFrameSelector(ucrSelectorSplitTextColumn.ucrAvailableDataFrames)
        ucrSaveColumn.SetLabelText("Prefix for New Columns:")
        ucrSaveColumn.SetIsTextBox()
        ucrSaveColumn.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
    End Sub

    Private Sub SetDefaults()
        clsTextComponents = New RFunction
        clsTextComponents2 = New RFunction
        clsBinaryColumns = New RFunction

        ucrSelectorSplitTextColumn.Reset()

        clsBinaryColumns.SetPackageName("questionr")
        clsBinaryColumns.SetRCommand("multi.split")

        clsTextComponents.SetPackageName("stringr")
        clsTextComponents.SetRCommand("str_split_fixed")
        clsTextComponents.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
        clsTextComponents.AddParameter("n", strParameterValue:=2, iPosition:=2)

        clsTextComponents2.SetPackageName("stringr")
        clsTextComponents2.SetRCommand("str_split")
        clsTextComponents2.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
        clsTextComponents2.AddParameter("n", "Inf", iPosition:=2)
        clsTextComponents2.AddParameter("simplify", "TRUE", iPosition:=3)

        clsTextComponents.SetAssignTo(strTemp:="Split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="Split", bAssignToIsPrefix:=True)
        ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponents)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverSplitTextColumn.AddAdditionalCodeParameterPair(clsTextComponents2, New RParameter("string", 0), iAdditionalPairNo:=1)
        ucrReceiverSplitTextColumn.AddAdditionalCodeParameterPair(clsBinaryColumns, New RParameter("var", 0), iAdditionalPairNo:=2)
        ucrInputPattern.AddAdditionalCodeParameterPair(clsTextComponents2, New RParameter("pattern", 1), iAdditionalPairNo:=1)
        ucrInputPattern.AddAdditionalCodeParameterPair(clsBinaryColumns, New RParameter("split.char", 1), iAdditionalPairNo:=2)
        ucrReceiverSplitTextColumn.SetRCode(clsTextComponents, bReset)
        ucrInputPattern.SetRCode(clsTextComponents, bReset)
        ucrNudPieces.SetRCode(clsTextComponents, bReset)
        ucrPnlSplitText.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlTextComponents.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSaveColumn.SetRCode(clsTextComponents, bReset)
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

    Private Sub ucrPnlSplitText_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlSplitText.ControlContentsChanged
        If rdoBinaryColumns.Checked Then
            'rdoMaximumNumberOfComponents.Hide()
            'rdoFixedNumberOfComponents.Hide()
            ucrBase.clsRsyntax.SetBaseRFunction(clsBinaryColumns)
            clsBinaryColumns.SetAssignTo("Split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToColumnWithoutNames:=True)
        ElseIf rdoTextComponents.Checked Then
            'rdoMaximumNumberOfComponents.Show()
            'rdoFixedNumberOfComponents.Show()
            ' ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponents)
            '  clsTextComponents.SetAssignTo("Split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="Split", bAssignToIsPrefix:=True)
            SplitTextOptions()
            ucrSaveColumn.SetName("Split")
        Else
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputPattern.ControlContentsChanged, ucrReceiverSplitTextColumn.ControlContentsChanged, ucrNudPieces.ControlContentsChanged, ucrSaveColumn.ControlContentsChanged, ucrPnlSplitText.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub rdoFixedNumberOfComponents_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFixedNumberOfComponents.CheckedChanged
        ucrNudPieces.Show()
    End Sub

    Private Sub rdoMaximumNumberOfComponents_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMaximumNumberOfComponents.CheckedChanged
        ucrNudPieces.Hide()
    End Sub

    Private Sub ucrPnlTextComponents_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlTextComponents.ControlValueChanged
        SplitTextOptions()
    End Sub

    Private Sub SplitTextOptions()
        If rdoFixedNumberOfComponents.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponents)
            clsTextComponents.SetAssignTo("Split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="Split", bAssignToIsPrefix:=True)
        ElseIf rdoMaximumNumberOfComponents.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponents2)
            clsTextComponents2.SetAssignTo("Split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="Split", bAssignToIsPrefix:=True)
        End If
    End Sub
End Class