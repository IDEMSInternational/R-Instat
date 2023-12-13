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

Public Class dlgSeasonalGraph
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsGeomLineFunction As New RFunction
    Private bResetSubdialog As Boolean = True
    Private clsGeomRibbonFunction As New RFunction
    Private clsRggplotFunction As New RFunction
    'Private clsOptionsFunction As New RFunction

    'Parameter names for geoms
    Private strFirstParameterName As String = "geomLine"
    Private strgeomRibbonParameterName As String = "geom_ribbon"
    Private strGeomParameterNames() As String = {strFirstParameterName, strgeomRibbonParameterName}

    Private Sub dlgSeasonalGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorForSeasonalGraph.SetParameter(New RParameter("data", 0))
        ucrSelectorForSeasonalGraph.SetParameterIsrfunction()

        ucrPnlOptions.AddRadioButton(rdoLine)
        ucrPnlOptions.AddRadioButton(rdoBar)

        ucrPnlOptions.AddParameterValueFunctionNamesCondition(rdoLine, strFirstParameterName, {"geom_line", "geom_ribbon"})
        ucrPnlOptions.AddParameterValueFunctionNamesCondition(rdoBar, strgeomRibbonParameterName, {"geom_Bar"})

        ucrReceiverLines.SetParameter(New RParameter("y", 1))
        ucrReceiverLines.Selector = ucrSelectorForSeasonalGraph
        ucrReceiverLines.strSelectorHeading = "Variables"
        ucrReceiverLines.SetParameterIsString()
        ucrReceiverLines.SetLinkedDisplayControl(lblLines)
        ucrReceiverLines.bWithQuotes = False

        ucrReceiverX.SetParameter(New RParameter("x", 3))
        ucrReceiverX.Selector = ucrSelectorForSeasonalGraph
        ucrReceiverX.strSelectorHeading = "Variables"
        ucrReceiverX.bWithQuotes = False
        ucrReceiverX.SetParameterIsString()
        'ucrReceiverX.SetValuesToIgnore({Chr(34) & Chr(34)})
        'ucrReceiverX.bAddParameterIfEmpty = True
        ucrReceiverX.SetClimaticType("month")
        ucrReceiverX.bAutoFill = True

        ' ucrChkRibbons.SetParameter(New RParameter("geom_ribbon", 2))
        ucrChkRibbons.SetText("Ribbon(s):")
        ucrChkRibbons.AddParameterPresentCondition(True, "geom_ribbon")
        ucrChkRibbons.AddParameterPresentCondition(False, "geom_ribbon", False)
        ucrChkRibbons.AddToLinkedControls(ucrReceiverRibbons, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverRibbons.SetParameter(New RParameter("y", 2))
        ucrReceiverRibbons.Selector = ucrSelectorForSeasonalGraph
        ucrReceiverRibbons.strSelectorHeading = "Variables"
        ucrReceiverRibbons.SetParameterIsString()
        ucrReceiverRibbons.bWithQuotes = False

        ucrSave.SetPrefix("Seasonal_Graph")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Save Graph")
        ucrSave.SetDataFrameSelector(ucrSelectorForSeasonalGraph.ucrAvailableDataFrames)
        ucrSave.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsRggplotFunction = New RFunction
        clsGeomLineFunction = New RFunction
        clsRaesFunction = New RFunction
        clsBaseOperator = New ROperator
        clsGeomLineFunction = New RFunction
        clsGeomRibbonFunction = New RFunction

        ucrSelectorForSeasonalGraph.Reset()
        ucrSelectorForSeasonalGraph.SetGgplotFunction(clsBaseOperator)
        ucrSave.Reset()
        ucrReceiverLines.SetMeAsReceiver()
        bResetSubdialog = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsGeomLineFunction, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsGeomLineFunction.SetPackageName("ggplot2")
        clsGeomLineFunction.SetRCommand("geom_line")

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorForSeasonalGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrSelectorForSeasonalGraph.SetRCode(clsRggplotFunction, bReset)
        ucrReceiverLines.SetRCode(clsRaesFunction, bReset)
        ucrReceiverRibbons.SetRCode(clsRaesFunction, bReset)
        ucrReceiverX.SetRCode(clsRaesFunction, bReset)
        ucrChkRibbons.SetRCode(clsBaseOperator, bReset)
        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseOperator, bReset)

    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrChkRibbons_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRibbons.ControlValueChanged, ucrReceiverRibbons.ControlValueChanged
        If ucrChkRibbons.Checked Then
            ucrReceiverRibbons.Visible = True
            ucrReceiverRibbons.SetMeAsReceiver()
            If Not ucrReceiverRibbons.IsEmpty Then
                clsRaesFunction.AddParameter("y", ucrReceiverRibbons.GetVariableNames(False), iPosition:=1)
            End If
            clsBaseOperator.AddParameter("geom_ribbon", clsRFunctionParameter:=clsGeomRibbonFunction)
            Else
                ucrReceiverRibbons.Visible = False
            clsBaseOperator.RemoveParameterByName("geom_ribbon")
        End If
    End Sub
End Class