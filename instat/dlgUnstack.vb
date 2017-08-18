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

Public Class dlgUnstack
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsFormula As New ROperator
    Private clsIDColumns As New ROperator
    Dim clsDefaultFunction As New RFunction

    Private Sub dlgunstack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 58

        'ucrSelector
        ucrSelectorForUnstack.SetParameter(New RParameter("data", 0))
        ucrSelectorForUnstack.SetParameterIsrfunction()

        'ucrFactor
        ucrFactorToUnstackReceiver.SetParameter(New RParameter("y", 2))
        ucrFactorToUnstackReceiver.SetParameterIsString()
        ucrFactorToUnstackReceiver.bWithQuotes = False
        ucrFactorToUnstackReceiver.Selector = ucrSelectorForUnstack
        ucrFactorToUnstackReceiver.SetDataType("factor")
        ucrFactorToUnstackReceiver.strSelectorHeading = "Factors"

        'ucrColumn
        ucrColumnToUnstackReceiver.SetParameter(New RParameter("value.var", 4))
        ucrColumnToUnstackReceiver.SetParameterIsString()
        ucrColumnToUnstackReceiver.Selector = ucrSelectorForUnstack

        'ucrID
        ucrIDColumns.SetParameter(New RParameter("x", 1))
        ucrIDColumns.SetParameterIsString()
        ucrIDColumns.Selector = ucrSelectorForUnstack

        ' Operations
        clsFormula.SetOperation("~")
        clsFormula.AddParameter("formula", clsROperatorParameter:=clsIDColumns, iPosition:=0)
        clsFormula.bBrackets = False
        clsIDColumns.bBrackets = False

        'chkbox
        ucrChkDropMissingCombinations.SetParameter(New RParameter("drop", 3))
        ucrChkDropMissingCombinations.SetText("Drop Missing Combinations")
        ucrChkDropMissingCombinations.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDropMissingCombinations.SetRDefault("TRUE")

        'ucrSave
        ucrNewDFName.SetIsTextBox()
        ucrNewDFName.SetSaveTypeAsDataFrame()
        ucrNewDFName.SetDataFrameSelector(ucrSelectorForUnstack.ucrAvailableDataFrames)
        ucrNewDFName.SetLabelText("New Data Frame Name:")
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction

        ucrSelectorForUnstack.Reset()
        ucrNewDFName.Reset()
        ucrFactorToUnstackReceiver.SetMeAsReceiver()

        clsDefaultFunction.SetPackageName("reshape2")
        clsDefaultFunction.SetRCommand("dcast")
        clsDefaultFunction.SetAssignTo(ucrSelectorForUnstack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked", strTempDataframe:=ucrSelectorForUnstack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrSelectorForUnstack.SetRCode(clsDefaultFunction, bReset)
        ucrColumnToUnstackReceiver.SetRCode(clsDefaultFunction, bReset)
        ucrNewDFName.SetRCode(clsDefaultFunction, bReset)
        ucrChkDropMissingCombinations.SetRCode(clsDefaultFunction, bReset)
        ucrFactorToUnstackReceiver.SetRCode(clsFormula, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrFactorToUnstackReceiver.IsEmpty() AndAlso Not ucrColumnToUnstackReceiver.IsEmpty() AndAlso Not ucrIDColumns.IsEmpty() AndAlso ucrNewDFName.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub NewDefaultName()
        If (Not ucrNewDFName.bUserTyped) AndAlso ucrSelectorForUnstack.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDFName.SetName(ucrSelectorForUnstack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_unstacked")
        End If
    End Sub

    Private Sub SetFormula()
        Dim i As Integer = 0
        If Not ucrFactorToUnstackReceiver.IsEmpty AndAlso Not ucrIDColumns.IsEmpty Then
            clsDefaultFunction.AddParameter("formula", clsROperatorParameter:=clsFormula)
            clsIDColumns.SetOperation("+")
            clsIDColumns.ClearParameters()
            For Each strIndicatorVar As String In ucrIDColumns.GetVariableNamesAsList
                clsIDColumns.AddParameter(i, strIndicatorVar, iPosition:=i)
                i = i + 1
            Next
        End If
    End Sub

    Private Sub ucrSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForUnstack.ControlValueChanged
        NewDefaultName()
    End Sub

    Private Sub ucrReceiverFormula_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrIDColumns.ControlValueChanged, ucrFactorToUnstackReceiver.ControlValueChanged
        SetFormula()
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewDFName.ControlContentsChanged, ucrColumnToUnstackReceiver.ControlContentsChanged, ucrFactorToUnstackReceiver.ControlContentsChanged, ucrIDColumns.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class