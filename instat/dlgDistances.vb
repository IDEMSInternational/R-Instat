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

Imports System.IO
Imports instat.Translations

Public Class dlgDistances
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsConcFunction, clsConc2Function, clsDummyFunction, clsDistFunction As New RFunction
    Private clsOpeningOperator, clsClosingOperator As New ROperator
    Private Sub dlgDistances_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ucrSelectorDistance.SetParameter(New RParameter("df", 0))
        ucrSelectorDistance.SetParameterIsrfunction()

        ucrReceiverLong.SetParameter(New RParameter("long", 1, bNewIncludeArgumentName:=False))
        ucrReceiverLong.Selector = ucrSelectorDistance
        ucrReceiverLong.SetParameterIsRFunction()
        ucrReceiverLong.SetClimaticType("lon")
        ucrReceiverLong.bAutoFill = True
        ucrReceiverLong.SetLinkedDisplayControl(lblLon)

        ucrReceiverLat.SetParameter(New RParameter("lat", 2, bNewIncludeArgumentName:=False))
        ucrReceiverLat.Selector = ucrSelectorDistance
        ucrReceiverLat.SetParameterIsRFunction()
        ucrReceiverLat.SetClimaticType("lat")
        ucrReceiverLat.bAutoFill = True
        ucrReceiverLat.SetLinkedDisplayControl(lblLat)

        ucrPnlFrom.AddRadioButton(rdoValue)
        ucrPnlFrom.AddRadioButton(rdoVariable)
        ucrPnlFrom.AddParameterValuesCondition(rdoValue, "checked", "value")
        ucrPnlFrom.AddParameterValuesCondition(rdoVariable, "checked", "variable")

        ucrNudLon.SetParameter(New RParameter("lon", 0, bNewIncludeArgumentName:=False))
        ucrNudLon.SetMinMax(-180, 180)
        ucrNudLon.DecimalPlaces = 2
        ucrNudLon.Increment = 0.05
        ucrNudLon.SetLinkedDisplayControl(lblLongFrom)

        ucrNudLat.SetParameter(New RParameter("lat", 1, bNewIncludeArgumentName:=False))
        ucrNudLat.SetMinMax(-90, 90)
        ucrNudLat.Increment = 0.05
        ucrNudLat.DecimalPlaces = 2
        ucrNudLat.SetLinkedDisplayControl(lblLatFrom)

        ucrPnlFrom.AddToLinkedControls(ucrNudLon, {rdoValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.00)
        ucrPnlFrom.AddToLinkedControls(ucrNudLat, {rdoValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.00)
        ucrPnlFrom.AddToLinkedControls({ucrReceiverVariable, ucrInputVariable}, {rdoVariable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveDistance.SetLabelText("New Column Name:")
        ucrSaveDistance.SetDataFrameSelector(ucrSelectorDistance.ucrAvailableDataFrames)
        ucrSaveDistance.SetIsComboBox()
        ucrSaveDistance.SetSaveTypeAsColumn()
        ucrSaveDistance.SetPrefix("distances")

        rdoVariable.Enabled = False
    End Sub
    Private Sub SetDefaults()
        clsConc2Function = New RFunction
        clsConcFunction = New RFunction
        clsDistFunction = New RFunction
        clsDummyFunction = New RFunction
        clsOpeningOperator = New ROperator
        clsClosingOperator = New ROperator

        ucrSelectorDistance.Reset()
        ucrSaveDistance.Reset()
        ucrReceiverLong.SetMeAsReceiver()

        clsDummyFunction.AddParameter("checked", "value", iPosition:=0)

        clsConcFunction.SetRCommand("c")
        clsConcFunction.SetAssignTo("citycenter")
        clsConc2Function.SetRCommand("c")

        clsClosingOperator.SetOperation("]")
        clsClosingOperator.AddParameter("left", clsRFunctionParameter:=clsConc2Function, iPosition:=0)
        clsClosingOperator.AddParameter("right", "", iPosition:=1)

        clsOpeningOperator.SetOperation("[,")
        clsOpeningOperator.AddParameter("right", clsROperatorParameter:=clsClosingOperator, iPosition:=1)

        clsDistFunction.SetPackageName("geosphere")
        clsDistFunction.SetRCommand("distGeo")
        clsDistFunction.AddParameter("city", clsRFunctionParameter:=clsConcFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsDistFunction.AddParameter("para", clsROperatorParameter:=clsOpeningOperator, iPosition:=2, bIncludeArgumentName:=False)

        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrSaveDistance.GetText, strTempDataframe:=ucrSelectorDistance.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveDistance.GetText)

        ucrBase.clsRsyntax.SetBaseRFunction(clsDistFunction)

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrNudLat.SetRCode(clsConcFunction, bReset)
        ucrNudLon.SetRCode(clsConcFunction, bReset)
        ucrPnlFrom.SetRCode(clsDummyFunction, bReset)
        ucrSaveDistance.SetRCode(clsDistFunction, bReset)
        If bReset Then
            ucrReceiverLong.SetRCode(clsConc2Function, bReset)
            ucrReceiverLat.SetRCode(clsConc2Function, bReset)
        End If
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverLong.IsEmpty AndAlso Not ucrReceiverLat.IsEmpty AndAlso ucrSaveDistance.IsComplete AndAlso Not ucrNudLat.IsEmpty Then
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

    Private Sub ucrSelectorDistance_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDistance.ControlValueChanged
        clsOpeningOperator.AddParameter("left", clsRFunctionParameter:=ucrSelectorDistance.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
    End Sub

    Private Sub ucrReceiverLat_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLat.ControlValueChanged

        If Not ucrReceiverLat.IsEmpty Then
            clsConc2Function.AddParameter("lat", ucrReceiverLat.GetVariableNames, iPosition:=1, bIncludeArgumentName:=False)
        Else
            clsConc2Function.RemoveParameterByName("lat")
        End If
    End Sub

    Private Sub ucrReceiverLong_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLong.ControlValueChanged
        If Not ucrReceiverLong.IsEmpty Then
            clsConc2Function.AddParameter("long", ucrReceiverLong.GetVariableNames, iPosition:=0, bIncludeArgumentName:=False)
        Else
            clsConc2Function.RemoveParameterByName("long")
        End If
    End Sub

    Private Sub ucrReceiverLat_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLat.ControlContentsChanged, ucrReceiverLong.ControlContentsChanged, ucrSaveDistance.ControlContentsChanged, ucrNudLat.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class