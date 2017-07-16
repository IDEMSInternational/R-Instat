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
    Private clsTextComponents As New RFunction
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

        ucrPnlSplitText.AddFunctionNamesCondition(rdoTextComponents, "str_split_fixed")
        ucrPnlSplitText.AddFunctionNamesCondition(rdoBinaryColumns, "multi.split")

        ucrPnlSplitText.AddToLinkedControls(ucrNudPieces, {rdoTextComponents}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)
        ucrPnlSplitText.AddToLinkedControls(ucrSaveColumn, {rdoTextComponents}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudPieces.SetLinkedDisplayControl(lblNumberofPiecesToReturn)

        ucrReceiverSplitTextColumn.SetParameter(New RParameter("string", 0))
        ucrReceiverSplitTextColumn.SetParameterIsRFunction()
        ucrReceiverSplitTextColumn.Selector = ucrSelectorSplitTextColumn
        ucrReceiverSplitTextColumn.SetMeAsReceiver()
        ucrReceiverSplitTextColumn.bUseFilteredData = False

        ucrInputPattern.SetParameter(New RParameter("pattern", 1))
        dctPatternPairs.Add("Space ( )", Chr(34) & " " & Chr(34))
        dctPatternPairs.Add("Period .", "fixed(" & Chr(34) & "." & Chr(34) & ")")
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
        clsBinaryColumns = New RFunction

        ucrSelectorSplitTextColumn.Reset()

        clsBinaryColumns.SetPackageName("questionr")
        clsBinaryColumns.SetRCommand("multi.split")

        clsTextComponents.SetPackageName("stringr")
        clsTextComponents.SetRCommand("str_split_fixed")
        clsTextComponents.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
        clsTextComponents.AddParameter("n", strParameterValue:=2, iPosition:=2)
        clsTextComponents.SetAssignTo(strTemp:="Split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="Split", bAssignToIsPrefix:=True)

        ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponents)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverSplitTextColumn.AddAdditionalCodeParameterPair(clsBinaryColumns, New RParameter("var", 0), iAdditionalPairNo:=1)
        ucrInputPattern.AddAdditionalCodeParameterPair(clsBinaryColumns, New RParameter("split.char", 1), iAdditionalPairNo:=1)
        ucrReceiverSplitTextColumn.SetRCode(clsTextComponents, bReset)
        ucrInputPattern.SetRCode(clsTextComponents, bReset)
        ucrNudPieces.SetRCode(clsTextComponents, bReset)
        ucrPnlSplitText.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
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
            ucrBase.clsRsyntax.SetBaseRFunction(clsBinaryColumns)
            clsBinaryColumns.SetAssignTo("Split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToColumnWithoutNames:=True)
        ElseIf rdoTextComponents.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponents)
            clsTextComponents.SetAssignTo("Split", strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="Split", bAssignToIsPrefix:=True)
            ucrSaveColumn.SetName("Split")
        Else
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputPattern.ControlContentsChanged, ucrReceiverSplitTextColumn.ControlContentsChanged, ucrNudPieces.ControlContentsChanged, ucrSaveColumn.ControlContentsChanged, ucrPnlSplitText.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class