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

Public Class dlgFindNonnumericValues
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private clsIsNaFunction, clsIsNaNumericFunction, clsAsNumericFunction As New RFunction
    Private clsNotEqualToOperator As New ROperator

    Private Sub dlgShowNonnumericValues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverColumn.Selector = ucrSelectorShowNonNumericValues
        ucrSelectorShowNonNumericValues.bUseCurrentFilter = False

        ucrReceiverColumn.SetParameter(New RParameter("x", 1))
        ucrReceiverColumn.SetParameterIsRFunction()
        ucrReceiverColumn.SetExcludedDataTypes({"numeric"})

        ucrSaveLogicalColumn.SetPrefix("nonnum")
        ucrSaveLogicalColumn.SetSaveTypeAsColumn()
        ucrSaveLogicalColumn.SetDataFrameSelector(ucrSelectorShowNonNumericValues.ucrAvailableDataFrames)
        ucrSaveLogicalColumn.SetIsTextBox()
        ucrSaveLogicalColumn.SetLabelText("Logical column:")
    End Sub

    Private Sub SetDefaults()
        clsIsNaFunction = New RFunction
        clsIsNaNumericFunction = New RFunction
        clsNotEqualToOperator = New ROperator

        ucrReceiverColumn.SetMeAsReceiver()
        ucrSaveLogicalColumn.Reset()

        ucrSelectorShowNonNumericValues.Reset()

        clsIsNaFunction.SetRCommand("is.na")

        clsNotEqualToOperator.SetOperation("!=")
        clsNotEqualToOperator.AddParameter("left", bIncludeArgumentName:=False, clsRFunctionParameter:=clsIsNaFunction, iPosition:=0)
        clsNotEqualToOperator.AddParameter("right", bIncludeArgumentName:=False, clsRFunctionParameter:=clsIsNaNumericFunction, iPosition:=1)

        clsIsNaNumericFunction.SetRCommand("is.na")
        clsIsNaNumericFunction.AddParameter("numeric", bIncludeArgumentName:=False, clsRFunctionParameter:=clsAsNumericFunction)

        clsAsNumericFunction.SetRCommand("as.numeric")

        ucrBase.clsRsyntax.SetBaseROperator(clsNotEqualToOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverColumn.AddAdditionalCodeParameterPair(clsAsNumericFunction, New RParameter("x", 1), iAdditionalPairNo:=1)
        ucrReceiverColumn.SetRCode(clsIsNaFunction, bReset)
        ucrSaveLogicalColumn.SetRCode(clsNotEqualToOperator, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverColumn.IsEmpty AndAlso ucrSaveLogicalColumn.IsComplete Then
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

    Private Sub ucrReceiverColumn_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumn.ControlContentsChanged, ucrSaveLogicalColumn.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class