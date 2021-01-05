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
Public Class dlgConditionalQuantilePlot
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsConditionalQuantileFunction As New RFunction
    Private Sub dlgConditionalQuantilePlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRcodeForControls(bReset)

        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctLegendPosition As New Dictionary(Of String, String)
        ucrBase.clsRsyntax.iCallType = 3

        ucrConditionalQuantilePlotSelector.SetParameter(New RParameter("mydata", 0))
        ucrConditionalQuantilePlotSelector.SetParameterIsrfunction()

        ucrReceiverObservations.SetParameter(New RParameter("obs", 0))
        ucrReceiverObservations.Selector = ucrConditionalQuantilePlotSelector
        ucrReceiverObservations.SetParameterIsString()
        ucrReceiverObservations.SetIncludedDataTypes({"numeric"})
        ucrReceiverObservations.bAutoFill = True

        ucrReceiverPredictions.SetParameter(New RParameter("mod", 1))
        ucrReceiverPredictions.Selector = ucrConditionalQuantilePlotSelector
        ucrReceiverPredictions.SetParameterIsString()
        ucrReceiverPredictions.SetIncludedDataTypes({"numeric"})

        ucrReceiverMultipleFacet.SetParameter(New RParameter("type", 2))
        ucrReceiverMultipleFacet.Selector = ucrConditionalQuantilePlotSelector
        ucrReceiverMultipleFacet.SetParameterIsString()
        ucrReceiverMultipleFacet.SetIncludedDataTypes({"factor", "character"})
        ucrReceiverMultipleFacet.bExcludeFromSelector = True

        'ucrReceiverType.SetParameter(New RParameter("type", 2))
        'ucrReceiverType.Selector = ucrConditionalQuantilePlotSelector
        'ucrReceiverType.SetParameterIsString()
        'ucrReceiverType.bExcludeFromSelector = True
        'ucrReceiverType.SetClimaticType("station")

        ucrChkBin.SetText("Bins")
        ucrChkBin.SetParameter(New RParameter("bins", 3), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrNudBin.SetParameter(New RParameter("bins", 3))
        ucrChkBin.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrNudBin.Minimum = 1
        ' ucrChkBin.SetRDefault("TRUE")

        ucrChkMinBin.SetText("Min.bin")
        ucrChkMinBin.SetParameter(New RParameter("min.bin", 4), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrNudMinBin.SetParameter(New RParameter("min.bin", 4))
        ucrNudMinBin.Minimum = 1
        ' ucrChkMinBin.SetRDefault("TRUE")

        ucrChkKeyColumns.SetText("Key.columns")
        ucrChkKeyColumns.SetParameter(New RParameter("key.columns", 5), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrNudKeyColumns.SetParameter(New RParameter("key.columns", 5))
        ucrNudKeyColumns.Minimum = 1

        ucrChkKeyColumns.AddToLinkedControls(ucrNudKeyColumns, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)

        ucrChkBin.AddToLinkedControls(ucrNudBin, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=31)
        ucrChkMinBin.AddToLinkedControls(ucrNudMinBin, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10)

        ucrChkLegendPosition.SetText("Key.position")
        ucrChkLegendPosition.AddToLinkedControls(ucrInputLegendPosition, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Bottom")
        ucrInputLegendPosition.SetDropDownStyleAsNonEditable()
        ucrInputLegendPosition.SetParameter(New RParameter("key.position", 6))
        ' dctLegendPosition.Add("None", Chr(34) & "none" & Chr(34))
        dctLegendPosition.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        ucrInputLegendPosition.SetItems(dctLegendPosition)
        ucrChkLegendPosition.AddParameterPresentCondition(True, "key.position")
        ucrChkLegendPosition.AddParameterPresentCondition(False, "key.position", False)

        ucrSavePlot.SetPrefix("conditionalquantile")
        ucrSavePlot.SetCheckBoxText("Save Graph")
        ucrSavePlot.SetIsComboBox()
        ucrSavePlot.SetSaveTypeAsGraph()
        ucrSavePlot.SetDataFrameSelector(ucrConditionalQuantilePlotSelector.ucrAvailableDataFrames)
        ucrSavePlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsConditionalQuantileFunction = New RFunction

        ucrConditionalQuantilePlotSelector.Reset()
        ucrSavePlot.Reset()
        ucrReceiverObservations.SetMeAsReceiver()

        clsConditionalQuantileFunction.SetPackageName("openair")
        clsConditionalQuantileFunction.SetRCommand("conditionalQuantile")

        ucrBase.clsRsyntax.SetBaseRFunction(clsConditionalQuantileFunction)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverObservations.IsEmpty() OrElse ucrReceiverPredictions.IsEmpty() OrElse Not ucrSavePlot.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrReceiverObservations_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverObservations.ControlContentsChanged, ucrSavePlot.ControlContentsChanged, ucrReceiverPredictions.ControlContentsChanged
        TestOkEnabled()
    End Sub

End Class