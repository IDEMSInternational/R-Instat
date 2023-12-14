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
    Private clsRaesLineFunction As New RFunction
    Private clsRaesRibFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsGeomLineFunction As New RFunction
    Private bResetSubdialog As Boolean = True
    Private clsGeomRibbonFunction As New RFunction
    Private clsRggplotFunction As New RFunction
    Private clsRggplotRibFunction As New RFunction
    Private clsRggplotLineFunction As New RFunction
    Private clsOptionsFunction As New RFunction
    Private lstSelectedVariables As New List(Of ucrCore)

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
        clsOptionsFunction = New RFunction
        clsRggplotFunction = New RFunction
        clsRggplotRibFunction = New RFunction
        clsRggplotLineFunction = New RFunction
        clsGeomLineFunction = New RFunction
        clsRaesFunction = New RFunction
        clsRaesLineFunction = New RFunction
        clsRaesRibFunction = New RFunction
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

        clsOptionsFunction.SetPackageName("ggplot2")
        clsOptionsFunction.SetRCommand("geom_line")

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

        clsRggplotLineFunction.SetPackageName("ggplot2")
        clsRggplotLineFunction.SetRCommand("ggplot")
        clsRggplotLineFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesLineFunction, iPosition:=1)

        clsRaesLineFunction.SetPackageName("ggplot2")
        clsRaesLineFunction.SetRCommand("aes")

        clsRggplotRibFunction.SetPackageName("ggplot2")
        clsRggplotRibFunction.SetRCommand("ggplot")
        clsRggplotRibFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesRibFunction, iPosition:=0)

        clsRaesRibFunction.SetPackageName("ggplot2")
        clsRaesRibFunction.SetRCommand("aes")

        clsGeomRibbonFunction.SetPackageName("ggplot2")
        clsGeomRibbonFunction.SetRCommand("geom_ribbon")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorForSeasonalGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrReceiverLines.AddAdditionalCodeParameterPair(clsRaesLineFunction, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=1)

        ucrSelectorForSeasonalGraph.SetRCode(clsRggplotFunction, bReset)
        ucrReceiverX.SetRCode(clsRaesFunction, bReset)
        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseOperator, bReset)
        ucrSave.SetRCode(clsBaseOperator, bReset)

        If bReset Then
            ucrReceiverRibbons.SetRCode(clsRaesRibFunction, bReset)
            ucrChkRibbons.SetRCode(clsGeomRibbonFunction, bReset)
            ucrReceiverLines.SetRCode(clsRaesFunction, bReset)

        End If
    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrChkRibbons_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRibbons.ControlValueChanged, ucrReceiverRibbons.ControlValueChanged
        If ucrChkRibbons.Checked Then
            ucrReceiverRibbons.Visible = True
            ucrReceiverRibbons.SetMeAsReceiver()
            If Not ucrReceiverRibbons.IsEmpty Then
                clsRaesRibFunction.AddParameter("y", ucrReceiverRibbons.GetVariableNames(False), iPosition:=1)
                clsGeomRibbonFunction.AddParameter("var", clsRFunctionParameter:=clsRggplotRibFunction, bIncludeArgumentName:=False, iPosition:=0)
            Else
                clsGeomRibbonFunction.RemoveParameterByName("var")
            End If
            clsBaseOperator.AddParameter("geom_ribbon", clsRFunctionParameter:=clsGeomRibbonFunction)
        Else
            ucrReceiverRibbons.Visible = False
            clsBaseOperator.RemoveParameterByName("geom_ribbon")
        End If
    End Sub

    Private Sub AllControl_ControlContentsChanged() Handles ucrReceiverX.ControlContentsChanged, ucrReceiverRibbons.ControlContentsChanged, ucrReceiverLines.ControlContentsChanged, ucrSave.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ListGeom()
        If Not ucrReceiverLines.IsEmpty AndAlso ucrReceiverLines.lstSelectedVariables.Items.Count > 0 Then
            'clsRaesFunction.AddParameter("y", ucrReceiverLines.lstSelectedVariables.Items(0).Text)
            'For i = 1 To lstSelectedVariables.Count - 1
            '    Select Case i
            '        Case 0
            '            clsOptionsFunction.AddParameter("y", ucrReceiverLines.lstSelectedVariables.Items(0).Text)
            '            'clsGeomLineFunction.AddParameter("y", ucrReceiverLines.lstSelectedVariables.Items(0).Text)
            '            clsOptionsFunction.AddParameter("var", clsRFunctionParameter:=clsRggplotLineFunction, bIncludeArgumentName:=False, iPosition:=0)
            '            clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsOptionsFunction)

            '        Case 1
            '            clsOptionsFunction.AddParameter("y", ucrReceiverLines.lstSelectedVariables.Items(1).Text)
            '            'clsGeomLineFunction.AddParameter("y", ucrReceiverLines.lstSelectedVariables.Items(1).Text)
            '            clsOptionsFunction.AddParameter("var", clsRFunctionParameter:=clsRggplotLineFunction, bIncludeArgumentName:=False, iPosition:=0)
            '            clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsOptionsFunction)
            '        Case 2
            '            clsOptionsFunction.AddParameter("y", ucrReceiverLines.lstSelectedVariables.Items(2).Text)
            '            'clsGeomLineFunction.AddParameter("y", ucrReceiverLines.lstSelectedVariables.Items(2).Text)
            '            clsOptionsFunction.AddParameter("var", clsRFunctionParameter:=clsRggplotLineFunction, bIncludeArgumentName:=False, iPosition:=0)
            '            clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsOptionsFunction)

            '    End Select
            'Next
            For i = 0 To lstSelectedVariables.Count - 1
                Select Case i
                    Case 0
                        clsRaesFunction.AddParameter("y", ucrReceiverLines.lstSelectedVariables.Items(0).Text)
                        'clsRaesLineFunction.AddParameter("y", ucrReceiverLines.lstSelectedVariables.Items(0).Text)
                    Case 1
                        clsRaesLineFunction.AddParameter("y", ucrReceiverLines.lstSelectedVariables.Items(1).Text)

                    Case 2
                        clsGeomLineFunction.AddParameter("y", ucrReceiverLines.lstSelectedVariables.Items(2).Text)
                End Select
            Next
        End If

    End Sub

    Private Sub ucrReceiverLines_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLines.ControlValueChanged
        ListGeom()
    End Sub
End Class