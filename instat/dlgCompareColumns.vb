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

Public Class dlgCompareColumns

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsCompareColumns As New RFunction
    Private clsYinXOperator As New ROperator

    Private Sub dlgCompareColumns_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 546
        ucrReceiverFirst.SetParameter(New RParameter("x", 0))
        ucrReceiverFirst.Selector = ucrSelectorCompareColumns
        ucrReceiverFirst.SetParameterIsRFunction()
        ucrReceiverFirst.bAttachedToPrimaryDataFrame = False
        ucrReceiverFirst.bOnlyLinkedToPrimaryDataFrames = False
        ucrReceiverFirst.bIncludeDataFrameInAssignment = True

        ucrReceiverSecond.SetParameter(New RParameter("y", 1))
        ucrReceiverSecond.Selector = ucrSelectorCompareColumns
        ucrReceiverSecond.SetParameterIsRFunction()
        ucrReceiverSecond.bAttachedToPrimaryDataFrame = False
        ucrReceiverSecond.bOnlyLinkedToPrimaryDataFrames = False
        ucrReceiverSecond.bIncludeDataFrameInAssignment = True

        ucrChkUnique.SetParameter(New RParameter("use_unique", 2), bNewChangeParameterValue:=True)
        ucrChkUnique.SetText("Use unique values for comparison")
        ucrChkUnique.SetRDefault("TRUE")

        ucrChkSort.SetParameter(New RParameter("sort_values", 3), bNewChangeParameterValue:=True)
        ucrChkSort.SetText("Sort values")
        ucrChkSort.SetRDefault("TRUE")

        ucrChkFirstNotSecond.SetParameter(New RParameter("firstnotsecond", 4), bNewChangeParameterValue:=True)
        ucrChkFirstNotSecond.SetText("Values in first column not in second")
        ucrChkFirstNotSecond.SetRDefault("TRUE")

        ucrChkSecondNotFirst.SetParameter(New RParameter("secondnotfirst", 5), bNewChangeParameterValue:=True)
        ucrChkSecondNotFirst.SetText("Values in second column not in first")
        ucrChkSecondNotFirst.SetRDefault("TRUE")

        ucrChkIntersection.SetParameter(New RParameter("display_intersection", 6), bNewChangeParameterValue:=True)
        ucrChkIntersection.SetText("Values in both columns (intersection)")
        ucrChkIntersection.SetRDefault("FALSE")

        ucrChkUnion.SetParameter(New RParameter("display_union", 7), bNewChangeParameterValue:=True)
        ucrChkUnion.SetText("Values in either column (union)")
        ucrChkUnion.SetRDefault("FALSE")

        ucrChkAllValues.SetParameter(New RParameter("display_values", 8), bNewChangeParameterValue:=True)
        ucrChkAllValues.SetText("All values if columns are equal")
        ucrChkAllValues.SetRDefault("TRUE")

        ' Not setting data frame selector or prefix here because we need save control only linked to data frame of second selector which is not yet implemented
        ucrSaveLogical.SetCheckBoxText("Save logical values for second column")
        ucrSaveLogical.SetSaveTypeAsColumn()
        ucrSaveLogical.SetIsTextBox()
        ' This ensures the assign text is correctly cleared when resetting
        ucrSaveLogical.bUpdateRCodeFromControl = False
    End Sub

    Private Sub SetDefaults()
        clsCompareColumns = New RFunction
        clsYinXOperator = New ROperator

        ucrBase.clsRsyntax.ClearCodes()

        ucrSelectorCompareColumns.Reset()
        ucrReceiverFirst.SetMeAsReceiver()
        ucrSaveLogical.Reset()

        clsCompareColumns.SetRCommand("compare_columns")
        clsYinXOperator.SetOperation("%in%")
        ucrBase.clsRsyntax.SetBaseRFunction(clsCompareColumns)
        ucrBase.clsRsyntax.iCallType = 2
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverFirst.AddAdditionalCodeParameterPair(clsYinXOperator, New RParameter("right", iNewPosition:=1), iAdditionalPairNo:=1)
        ucrReceiverSecond.AddAdditionalCodeParameterPair(clsYinXOperator, New RParameter("left", iNewPosition:=0), iAdditionalPairNo:=1)

        ucrReceiverFirst.SetRCode(clsCompareColumns, bReset)
        ucrReceiverSecond.SetRCode(clsCompareColumns, bReset)
        ucrChkUnique.SetRCode(clsCompareColumns, bReset)
        ucrChkSort.SetRCode(clsCompareColumns, bReset)
        ucrChkFirstNotSecond.SetRCode(clsCompareColumns, bReset)
        ucrChkSecondNotFirst.SetRCode(clsCompareColumns, bReset)
        ucrChkIntersection.SetRCode(clsCompareColumns, bReset)
        ucrChkUnion.SetRCode(clsCompareColumns, bReset)
        ucrChkAllValues.SetRCode(clsCompareColumns, bReset)

        ucrSaveLogical.SetRCode(clsYinXOperator, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverFirst.IsEmpty AndAlso Not ucrReceiverSecond.IsEmpty AndAlso ucrSaveLogical.IsComplete() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirst.ControlContentsChanged, ucrReceiverSecond.ControlContentsChanged, ucrSaveLogical.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverSecond_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecond.ControlValueChanged
        ' Needs to be done manually because data frame name should only be the data frame name from the second receiver's variable.
        ucrSaveLogical.SetGlobalDataName(ucrReceiverSecond.GetDataName())
    End Sub

    Private Sub ucrSaveLogical_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveLogical.ControlValueChanged
        If ucrSaveLogical.ucrChkSave.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsYinXOperator, iPosition:=1)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsYinXOperator)
        End If
    End Sub

    Private Sub ucrReceiverFirst_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirst.ControlValueChanged
        If Not ucrSaveLogical.bUserTyped Then
            If ucrReceiverFirst.IsEmpty Then
                ucrSaveLogical.SetName("")
            Else
                ucrSaveLogical.SetName("in_" & ucrReceiverFirst.GetVariableNames(False))
            End If
        End If
    End Sub
End Class