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

Public Class dlgClimograph
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsAstibleFunction, clsCFunction, clsRepFunction0, clsRepFunction1, clsRbindFunction, clsAsdataframeFunction, clsTFunction, clsAsfactorFunction, clsGgwalterliethFunction As RFunction
    Private clsFacetFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsFacetVariablesOperator As New ROperator
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator
    Private clsPipeOperator As New ROperator
    Private clsGroupByFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private strDatLong As String = "dat_long"
    Private strDatLongmonth As String = "dat_long$month"
    Private strDatLong1 As String = "dat_long1"
    Private strDatLong1station As String = "dat_long1$station"
    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"
    Private ReadOnly strNone As String = "None"

    Private bUpdateComboOptions As Boolean = True
    Private bUpdatingParameters As Boolean = False

    Private Sub dlgClimograph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
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
        ucrPnlClimograph.AddRadioButton(rdoClimograph)
        ucrPnlClimograph.AddRadioButton(rdoWalterLieth)

        ucrSelectorClimograph.SetParameter(New RParameter("data", 0))
        'ucrSelectorClimograph.SetParameterIsString()
        ucrSelectorClimograph.SetParameterIsrfunction()
        ucrSelectorClimograph.bUseCurrentFilter = False

        ucrReceiverMonth.SetParameter(New RParameter("month", 1))
        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.Selector = ucrSelectorClimograph
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True
        ucrReceiverMonth.strSelectorHeading = "Month Variables"
        ucrReceiverMonth.SetLinkedDisplayControl(lblMonth)
        ucrReceiverMonth.SetMeAsReceiver()

        ucrReceiverRain.SetParameter(New RParameter("p_mes", 3))
        ucrReceiverRain.SetParameterIsString()
        ucrReceiverRain.Selector = ucrSelectorClimograph
        ucrReceiverRain.SetClimaticType("rain")
        ucrReceiverRain.bAutoFill = True
        ucrReceiverRain.strSelectorHeading = "Rain Variables"
        ucrReceiverRain.SetLinkedDisplayControl(lblRain)

        ucrReceiverMaxtem.SetParameter(New RParameter("tm_max", 4))
        ucrReceiverMaxtem.SetParameterIsString()
        ucrReceiverMaxtem.Selector = ucrSelectorClimograph
        ucrReceiverMaxtem.SetClimaticType("temp_max")
        ucrReceiverMaxtem.bAutoFill = True
        ucrReceiverMaxtem.strSelectorHeading = "Variables"
        ucrReceiverMaxtem.SetLinkedDisplayControl(lblMaxtem)

        ucrReceiverMintemp.SetParameter(New RParameter("tm_min", 5))
        ucrReceiverMintemp.SetParameterIsString()
        ucrReceiverMintemp.Selector = ucrSelectorClimograph
        ucrReceiverMintemp.SetClimaticType("temp_min")
        ucrReceiverMintemp.bAutoFill = True
        ucrReceiverMintemp.strSelectorHeading = "Variables"
        ucrReceiverMintemp.SetLinkedDisplayControl(lblMintem)

        ucrReceiverAbsolutetem.SetParameter(New RParameter("ta_min", 6))
        ucrReceiverAbsolutetem.SetParameterIsString()
        ucrReceiverAbsolutetem.Selector = ucrSelectorClimograph
        ucrReceiverAbsolutetem.strSelectorHeading = "Variables"
        ucrReceiverAbsolutetem.SetLinkedDisplayControl(lblAbsoluteTemp)

        ucrReceiverStation.SetParameter(New RParameter("station", 2))
        ucrReceiverStation.Selector = ucrSelectorClimograph
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Factors"
        ucrReceiverStation.SetParameterIsString()

        ucrPnlClimograph.AddParameterValuesCondition(rdoWalterLieth, "checked", "WalterLieth")
        ucrPnlClimograph.AddParameterValuesCondition(rdoClimograph, "checked", "Climograph")
        ucrPnlClimograph.SetRDefault(rdoWalterLieth)

        ucrSave.SetPrefix("graph")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Save")
        ucrSave.SetDataFrameSelector(ucrSelectorClimograph.ucrAvailableDataFrames)
        ucrSave.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsGgwalterliethFunction = New RFunction
        clsTFunction = New RFunction
        clsAsdataframeFunction = New RFunction
        clsAstibleFunction = New RFunction
        clsAsfactorFunction = New RFunction
        clsRbindFunction = New RFunction
        clsRepFunction0 = New RFunction
        clsRepFunction1 = New RFunction
        clsCFunction = New RFunction
        clsDummyFunction = New RFunction
        'clsBaseOperator.SetOperation("+")
        'clsBaseOperator.AddParameter("ggwalter_lieth", clsRFunctionParameter:=clsGgwalterliethFunction, iPosition:=0)
        'clsDummyFunction.AddParameter("checked", "walterLieth", iPosition:=0)

        ucrSelectorClimograph.Reset()
        ucrSave.Reset()

        clsGgwalterliethFunction.SetRCommand("ggwalter_lieth")
        clsGgwalterliethFunction.AddParameter("data", strDatLong1, iPosition:=0)
        'clsGgwalterliethFunction.AddParameter("month", Chr(34) & "" & Chr(34), iPosition:=1)
        'clsGgwalterliethFunction.AddParameter("station", Chr(34) & "" & Chr(34), iPosition:=2)
        'clsGgwalterliethFunction.AddParameter("rain", Chr(34) & "" & Chr(34), iPosition:=3)
        'clsGgwalterliethFunction.AddParameter("Tmax", Chr(34) & "" & Chr(34), iPosition:=4)
        'clsGgwalterliethFunction.AddParameter("Tmin", Chr(34) & "" & Chr(34), iPosition:=5)
        'clsGgwalterliethFunction.AddParameter("station", Chr(34) & "" & Chr(34), iPosition:=6)

        clsAstibleFunction.SetPackageName("tibble")
        clsAstibleFunction.SetRCommand("as_tibble")
        clsAstibleFunction.AddParameter("as.data.frame", clsRFunctionParameter:=clsAsdataframeFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsAstibleFunction.SetAssignTo(strDatLong)

        clsAsdataframeFunction.SetRCommand("as.data.frame")
        clsAsdataframeFunction.AddParameter("t", clsRFunctionParameter:=clsTFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsTFunction.SetRCommand("t")
        clsTFunction.AddParameter("dat", clsRFunctionParameter:=ucrSelectorClimograph.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0, bIncludeArgumentName:=False)

        clsAsfactorFunction.SetPackageName("forcats")
        clsAsfactorFunction.SetRCommand("as_factor")
        clsAsfactorFunction.AddParameter("month", , iPosition:=0, bIncludeArgumentName:=False)
        clsAsfactorFunction.SetAssignTo(strDatLongmonth)

        clsRbindFunction.SetRCommand("rbind")
        clsRbindFunction.AddParameter("bind0", strDatLong, iPosition:=0, bIncludeArgumentName:=False)
        clsRbindFunction.AddParameter("bind1", strDatLong, iPosition:=0, bIncludeArgumentName:=False)
        clsRbindFunction.SetAssignTo(strDatLong1)

        clsCFunction.SetRCommand("c")
        clsCFunction.AddParameter("x", clsRFunctionParameter:=clsRepFunction0, iPosition:=0, bIncludeArgumentName:=False)
        clsCFunction.AddParameter("y", clsRFunctionParameter:=clsRepFunction1, iPosition:=1, bIncludeArgumentName:=False)
        clsCFunction.SetAssignTo(strDatLong1station)

        clsRepFunction0.SetRCommand("rep")
        clsRepFunction0.AddParameter("A", Chr(34) & "A" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsRepFunction0.AddParameter("12", Chr(34) & "12" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)

        clsRepFunction1.SetRCommand("rep")
        clsRepFunction1.AddParameter("B", Chr(34) & "B" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsRepFunction1.AddParameter("12", Chr(34) & "12" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)


        ucrBase.clsRsyntax.SetBaseRFunction(clsGgwalterliethFunction)
        'clsGgwalterliethFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
    End Sub

    Private Sub SetRCodeForControls(bReset)
        'ucrPnlClimograph.SetRCode(clsDummyFunction, bReset)

        ucrSelectorClimograph.SetRCode(clsTFunction, bReset)
        ucrReceiverMonth.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverRain.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverMintemp.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverMaxtem.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverAbsolutetem.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverStation.SetRCode(clsGgwalterliethFunction, bReset)
        ucrSave.SetRCode(clsGgwalterliethFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If rdoWalterLieth.Checked Then
            If (Not ucrReceiverAbsolutetem.IsEmpty AndAlso Not ucrReceiverMaxtem.IsEmpty AndAlso Not ucrReceiverMintemp.IsEmpty AndAlso Not ucrReceiverMonth.IsEmpty AndAlso Not ucrReceiverRain.IsEmpty) OrElse Not ucrSave.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub



    Private Sub AllControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlClimograph.ControlContentsChanged, ucrReceiverRain.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrReceiverAbsolutetem.ControlContentsChanged, ucrReceiverMaxtem.ControlContentsChanged, ucrReceiverMintemp.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged, ucrSave.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlClimograph_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlClimograph.ControlValueChanged
        If rdoWalterLieth.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsGgwalterliethFunction)
        End If
    End Sub
End Class