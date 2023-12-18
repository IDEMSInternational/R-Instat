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

Imports instat.TranslationsPublic Class dlgSeasonalGraph    Private clsRaesFunction As New RFunction    Private clsRaesGeomLineFunction As New RFunction    Private clsRaesRibFunction As New RFunction    Private clsBaseOperator As New ROperator    Private bFirstLoad As Boolean = True    Private bReset As Boolean = True    Private clsGeomLineFunction As New RFunction    Private bResetSubdialog As Boolean = True    Private clsGeomRibbonFunction As New RFunction    Private clsRggplotFunction As New RFunction    Private clsRggplotRibFunction As New RFunction    Private clsRggplotLineFunction As New RFunction    Private clsFacetFunction As New RFunction
    Private clsFacetOperator As New ROperator
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator
    Private clsGroupByFunction As New RFunction
    Private clsPipeOperator As New ROperator

    Private bUpdatingParameters As Boolean = False
    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"    Private lstSelectedVariables As New List(Of ucrCore)

    'Parameter names for geoms
    Private strFirstParameterName As String = "geomLine"    Private strgeomRibbonParameterName As String = "geom_ribbon"    Private strGeomParameterNames() As String = {strFirstParameterName, strgeomRibbonParameterName}    Private Sub dlgSeasonalGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load        If bFirstLoad Then            InitialiseDialog()            bFirstLoad = False        End If        If bReset Then            SetDefaults()        End If        SetRCodeForControls(bReset)        bReset = False        autoTranslate(Me)        TestOkEnabled()    End Sub    Private Sub InitialiseDialog()        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False        ucrBase.clsRsyntax.iCallType = 3        ucrSelectorForSeasonalGraph.SetParameter(New RParameter("data", 0))        ucrSelectorForSeasonalGraph.SetParameterIsrfunction()        ucrPnlOptions.AddRadioButton(rdoLine)        ucrPnlOptions.AddRadioButton(rdoBar)        ucrPnlOptions.AddParameterValueFunctionNamesCondition(rdoLine, strFirstParameterName, {"geom_line", "geom_ribbon"})        ucrPnlOptions.AddParameterValueFunctionNamesCondition(rdoBar, strgeomRibbonParameterName, {"geom_Bar"})

        'ucrReceiverLines.SetParameter(New RParameter("y", 1))
        ucrReceiverLines.Selector = ucrSelectorForSeasonalGraph        ucrReceiverLines.strSelectorHeading = "Variables"        ucrReceiverLines.SetParameterIsString()        ucrReceiverLines.SetLinkedDisplayControl(lblLines)        ucrReceiverLines.bWithQuotes = False        ucrReceiverX.SetParameter(New RParameter("x", 3))        ucrReceiverX.Selector = ucrSelectorForSeasonalGraph        ucrReceiverX.strSelectorHeading = "Variables"        ucrReceiverX.bWithQuotes = False        ucrReceiverX.SetParameterIsString()
        'ucrReceiverX.SetValuesToIgnore({Chr(34) & Chr(34)})
        'ucrReceiverX.bAddParameterIfEmpty = True
        ucrReceiverX.SetClimaticType("month")        ucrReceiverX.bAutoFill = True

        ' ucrChkRibbons.SetParameter(New RParameter("geom_ribbon", 2))
        ucrChkRibbons.SetText("Ribbon(s):")        ucrChkRibbons.AddParameterPresentCondition(True, "geom_ribbon")        ucrChkRibbons.AddParameterPresentCondition(False, "geom_ribbon", False)        ucrChkRibbons.AddToLinkedControls(ucrReceiverRibbons, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverRibbons.SetParameter(New RParameter("y", 2))
        ucrReceiverRibbons.Selector = ucrSelectorForSeasonalGraph        ucrReceiverRibbons.strSelectorHeading = "Variables"        ucrReceiverRibbons.SetParameterIsString()        ucrReceiverRibbons.bWithQuotes = False

        ucrReceiverFacetBy.SetParameter(New RParameter(""))
        ucrReceiverFacetBy.Selector = ucrSelectorForSeasonalGraph
        ucrReceiverFacetBy.SetIncludedDataTypes({"factor"})
        ucrReceiverFacetBy.strSelectorHeading = "Factors"
        ucrReceiverFacetBy.bWithQuotes = False
        ucrReceiverFacetBy.SetParameterIsString()
        ucrReceiverFacetBy.SetValuesToIgnore({"."})        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()        ucrSave.SetPrefix("Seasonal_Graph")        ucrSave.SetIsComboBox()        ucrSave.SetSaveTypeAsGraph()        ucrSave.SetCheckBoxText("Save Graph")        ucrSave.SetDataFrameSelector(ucrSelectorForSeasonalGraph.ucrAvailableDataFrames)        ucrSave.SetAssignToIfUncheckedValue("last_graph")    End Sub    Private Sub SetDefaults()        clsRggplotFunction = New RFunction        clsRggplotRibFunction = New RFunction        clsRggplotLineFunction = New RFunction        clsGeomLineFunction = New RFunction        clsRaesFunction = New RFunction        clsRaesGeomLineFunction = New RFunction        clsRaesRibFunction = New RFunction        clsBaseOperator = New ROperator        clsGeomLineFunction = New RFunction        clsGeomRibbonFunction = New RFunction
        clsFacetFunction = New RFunction
        clsFacetOperator = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator        clsPipeOperator = New ROperator        ucrSelectorForSeasonalGraph.Reset()        ucrSelectorForSeasonalGraph.SetGgplotFunction(clsBaseOperator)        ucrSave.Reset()        ucrReceiverLines.SetMeAsReceiver()        bResetSubdialog = True        clsBaseOperator.SetOperation("+")        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)        clsRggplotFunction.SetPackageName("ggplot2")        clsRggplotFunction.SetRCommand("ggplot")        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)        clsRaesFunction.SetPackageName("ggplot2")        clsRaesFunction.SetRCommand("aes")

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetRowOp.SetOperation("+")
        clsFacetRowOp.bBrackets = False
        clsFacetColOp.SetOperation("+")
        clsFacetColOp.bBrackets = False
        clsFacetOperator.SetOperation("~")
        clsFacetOperator.bForceIncludeOperation = True
        clsFacetOperator.bBrackets = False
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetOperator, iPosition:=0)

        clsPipeOperator.SetOperation("%>%")
        SetPipeAssignTo()

        ucrInputStation.SetName(strFacetWrap)
        ucrInputStation.bUpdateRCodeFromControl = True

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorForSeasonalGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)    End Sub    Private Sub SetRCodeForControls(bReset)
        ' ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseOperator, bReset)
        ucrSelectorForSeasonalGraph.SetRCode(clsRggplotFunction, bReset)        ucrReceiverX.SetRCode(clsRaesFunction, bReset)        ucrSave.SetRCode(clsBaseOperator, bReset)
        If bReset Then
            ucrReceiverRibbons.SetRCode(clsRaesRibFunction, bReset)
            ucrChkRibbons.SetRCode(clsGeomRibbonFunction, bReset)
        End If
    End Sub    Private Sub TestOkEnabled()    End Sub

    Private Sub ucrChkRibbons_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRibbons.ControlValueChanged, ucrReceiverRibbons.ControlValueChanged        If ucrChkRibbons.Checked Then            ucrReceiverRibbons.Visible = True            ucrReceiverRibbons.SetMeAsReceiver()
            If ucrReceiverRibbons.lstSelectedVariables.Items.Count > 0 Then
                For i = 0 To ucrReceiverRibbons.lstSelectedVariables.Items.Count - 1
                    Dim clsRaesRibFunction As New RFunction
                    clsRaesRibFunction.SetPackageName("ggplot2")
                    clsRaesRibFunction.SetRCommand("aes")
                    clsRaesRibFunction.AddParameter("y", ucrReceiverRibbons.lstSelectedVariables.Items(i).Text)
                    Dim clsGeomRibbonFunction As New RFunction
                    clsGeomRibbonFunction.SetPackageName("ggplot2")
                    clsGeomRibbonFunction.SetRCommand("geom_ribbon")
                    clsGeomRibbonFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesRibFunction, iPosition:=1)
                    clsBaseOperator.AddParameter(strgeomRibbonParameterName & i, clsRFunctionParameter:=clsGeomRibbonFunction, iPosition:=3)
                Next
            End If
        Else            ucrReceiverRibbons.Visible = False            clsBaseOperator.RemoveParameterByName("geom_ribbon")        End If    End Sub    Private Sub AllControl_ControlContentsChanged() Handles ucrReceiverX.ControlContentsChanged, ucrReceiverRibbons.ControlContentsChanged, ucrReceiverLines.ControlContentsChanged, ucrSave.ControlContentsChanged        TestOkEnabled()    End Sub    Private Sub ListGeomLine()        If ucrReceiverLines.lstSelectedVariables.Items.Count > 0 Then            clsRaesFunction.AddParameter("y", ucrReceiverLines.lstSelectedVariables.Items(0).Text)            For i = 1 To ucrReceiverLines.lstSelectedVariables.Items.Count - 1                Dim clsRaesGeomLineFunction As New RFunction                clsRaesGeomLineFunction.SetPackageName("ggplot2")                clsRaesGeomLineFunction.SetRCommand("aes")                clsRaesGeomLineFunction.AddParameter("y", ucrReceiverLines.lstSelectedVariables.Items(i).Text)                Dim clsGeomLineFunction As New RFunction                clsGeomLineFunction.SetPackageName("ggplot2")                clsGeomLineFunction.SetRCommand("geom_line")                clsGeomLineFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesGeomLineFunction, iPosition:=1)                clsBaseOperator.AddParameter(strFirstParameterName & i, clsRFunctionParameter:=clsGeomLineFunction, iPosition:=2)            Next        End If    End Sub    Private Sub UpdateParameters()
        clsFacetOperator.RemoveParameterByName("wrap" & ucrInputStation.Name)
        clsFacetColOp.RemoveParameterByName("col" & ucrInputStation.Name)
        clsFacetRowOp.RemoveParameterByName("row" & ucrInputStation.Name)

        clsBaseOperator.RemoveParameterByName("facets")
        bUpdatingParameters = True
        ucrReceiverFacetBy.SetRCode(Nothing)
        Select Case ucrInputStation.GetText()
            Case strFacetWrap
                ucrReceiverFacetBy.ChangeParameterName("wrap" & ucrInputStation.Name)
                ucrReceiverFacetBy.SetRCode(clsFacetOperator)
            Case strFacetCol
                ucrReceiverFacetBy.ChangeParameterName("col" & ucrInputStation.Name)
                ucrReceiverFacetBy.SetRCode(clsFacetColOp)
            Case strFacetRow
                ucrReceiverFacetBy.ChangeParameterName("row" & ucrInputStation.Name)
                ucrReceiverFacetBy.SetRCode(clsFacetRowOp)
        End Select
        If Not clsRaesFunction.ContainsParameter("x") Then
            clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
        End If
        bUpdatingParameters = False
    End Sub

    Private Sub AddRemoveFacets()
        Dim bWrap As Boolean = False
        Dim bCol As Boolean = False
        Dim bRow As Boolean = False

        If bUpdatingParameters Then
            Exit Sub
        End If

        clsBaseOperator.RemoveParameterByName("facets")
        If Not ucrReceiverFacetBy.IsEmpty Then
            Select Case ucrInputStation.GetText()
                Case strFacetWrap
                    bWrap = True
                Case strFacetCol
                    bCol = True
                Case strFacetRow
                    bRow = True
            End Select
        End If

        If bWrap OrElse bRow OrElse bCol Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction)
        End If
        If bWrap Then
            clsFacetFunction.SetRCommand("facet_wrap")
        End If
        If bRow OrElse bCol Then
            clsFacetFunction.SetRCommand("facet_grid")
        End If
        If bRow Then
            clsFacetOperator.AddParameter("left", clsROperatorParameter:=clsFacetRowOp, iPosition:=0)
        ElseIf bCol AndAlso bWrap = False Then
            clsFacetOperator.AddParameter("left", ".", iPosition:=0)
        Else
            clsFacetOperator.RemoveParameterByName("left")
        End If
        If bCol Then
            clsFacetOperator.AddParameter("right", clsROperatorParameter:=clsFacetColOp, iPosition:=1)
        ElseIf bRow AndAlso bWrap = False Then
            clsFacetOperator.AddParameter("right", ".", iPosition:=1)
        Else
            clsFacetOperator.RemoveParameterByName("right")
        End If
    End Sub

    Private Sub AddRemoveGroupBy()

        If clsPipeOperator.ContainsParameter("mutate") Then
            clsGroupByFunction.ClearParameters()
            If clsBaseOperator.ContainsParameter("facets") Then
                Select Case ucrInputStation.GetText()
                    Case strFacetWrap
                        GetParameterValue(clsFacetOperator)
                    Case strFacetCol
                        GetParameterValue(clsFacetColOp)
                    Case strFacetRow
                        GetParameterValue(clsFacetRowOp)
                End Select
            End If

            If clsRaesFunction.ContainsParameter("colour") Then
                clsGroupByFunction.AddParameter("colour", ucrReceiverColourBy.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=0)
            End If

            If clsGroupByFunction.iParameterCount > 0 Then
                clsPipeOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1)
            Else
                clsPipeOperator.RemoveParameterByName("group_by")
            End If
        Else
            clsPipeOperator.RemoveParameterByName("group_by")
        End If

        SetPipeAssignTo()
    End Sub

    Private Sub GetParameterValue(clsOperator As ROperator)
        Dim i As Integer = 0
        For Each clsTempParam As RParameter In clsOperator.clsParameters
            If clsTempParam.strArgumentValue <> "" AndAlso clsTempParam.strArgumentValue <> "." Then
                clsGroupByFunction.AddParameter(i, clsTempParam.strArgumentValue, bIncludeArgumentName:=False, iPosition:=i)
                i = i + 1
            End If
        Next
    End Sub

    Private Sub SetPipeAssignTo()
        If ucrSelectorForSeasonalGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator.clsParameters.Count > 1 Then
            clsPipeOperator.SetAssignTo(ucrSelectorForSeasonalGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrReceiverFacetBy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFacetBy.ControlValueChanged, ucrReceiverColourBy.ControlValueChanged, ucrReceiverX.ControlValueChanged
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub AutoFacetStation()
        Dim ucrCurrentReceiver As ucrReceiver = Nothing

        If ucrSelectorForSeasonalGraph.CurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver = ucrSelectorForSeasonalGraph.CurrentReceiver
        End If
        ucrReceiverFacetBy.AddItemsWithMetadataProperty(ucrSelectorForSeasonalGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Climatic_Type", {"station_label"})
        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If
        AddRemoveGroupBy()
    End Sub    Private Sub ucrReceiverLines_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLines.ControlValueChanged        ListGeomLine()    End SubEnd Class