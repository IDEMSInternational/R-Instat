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
    Private clsAstibleFunction, clsAsdataframeFunction, clsAsfactorFunction, clsGgwalterliethFunction As RFunction
    Private clsFacetFunction As New RFunction
    Private clsFacetVariablesOperator As New ROperator
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator
    Private clsPipeOperator As New ROperator
    Private clsGroupByFunction As New RFunction
    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"
    Private ReadOnly strNone As String = "None"

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
        ucrSelectorClimograph.SetParameter(New RParameter("data", 0, False))
        ucrSelectorClimograph.SetParameterIsString()

        ucrReceiverMonth.SetParameter(New RParameter("month", 1, False))
        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.Selector = ucrSelectorClimograph
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True
        ucrReceiverMonth.strSelectorHeading = "Month Variables"
        ucrReceiverMonth.SetMeAsReceiver()

        ucrReceiverRain.SetParameter(New RParameter("rain", 2, False))
        ucrReceiverRain.SetParameterIsString()
        ucrReceiverRain.Selector = ucrSelectorClimograph
        ucrReceiverRain.SetClimaticType("rain")
        ucrReceiverRain.bAutoFill = True
        ucrReceiverRain.strSelectorHeading = "Rain Variables"

        ucrReceiverMaxtem.SetParameter(New RParameter("Tmax", 3, False))
        ucrReceiverMaxtem.SetParameterIsString()
        ucrReceiverMaxtem.Selector = ucrSelectorClimograph
        ucrReceiverMaxtem.SetClimaticType("temp_max")
        ucrReceiverMaxtem.bAutoFill = True
        ucrReceiverMaxtem.strSelectorHeading = "Variables"

        ucrReceiverMintemp.SetParameter(New RParameter("Tmin", 4, False))
        ucrReceiverMintemp.SetParameterIsString()
        ucrReceiverMintemp.Selector = ucrSelectorClimograph
        ucrReceiverMintemp.SetClimaticType("temp_min")
        ucrReceiverMintemp.bAutoFill = True
        ucrReceiverMintemp.strSelectorHeading = "Variables"

        ucr1stFactorReceiver.SetParameter(New RParameter("var1"))
        ucr1stFactorReceiver.Selector = ucrSelectorClimograph
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.SetValuesToIgnore({"."})
        ucr1stFactorReceiver.SetParameterPosition(1)

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrSave.SetPrefix("graph")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Save")
        ucrSave.SetDataFrameSelector(ucrSelectorClimograph.ucrAvailableDataFrames)
        ucrSave.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()


    End Sub

    Private Sub SetRCodeForControls(bReset)

    End Sub

    Private Sub TestOKEnabled()

    End Sub
End Class