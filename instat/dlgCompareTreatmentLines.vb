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

Imports instat
Imports instat.Translations

Public Class dlgCompareTreatmentLines
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = True
    Private bResetBoxLayerSubdialog As Boolean = True

    ' Main functions and operator for ggplot
    Private clsBaseOperator As New ROperator
    Private clsRggplotFunction As New RFunction
    Private clsRaesGlobalFunction As New RFunction
    Private clsRaesLineFunction As New RFunction

    ' Geoms (layers)
    Private clsLineGeom As New RFunction
    Private clsBoxplotGeom As New RFunction
    Private clsHlineGeom As New RFunction

    ' Additional functions for plot subdialog
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScaleContinuousFunction As New RFunction
    Private clsYScaleContinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)

    ' Data unstacking, diff calculation and merge codes
    Private clsLeftJoin As New RFunction
    Private clsDCast As New RFunction
    Private clsDCastFormula As New ROperator
    Private clsPipeOperator As New ROperator
    Private clsMutate As New RFunction
    Private clsDiffOperator As New ROperator
    Private clsCut As New RFunction
    Private clsCutBreaks As New RFunction
    Private clsCutLabels As New RFunction

    Private strDiff As String = "diff"
    Private strDiffCode As String = "diff_code"

    Private Sub dlgCompareTreatmentLines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        'autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        'ucrBase.iHelpTopicID = 
        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorPlot.SetParameter(New RParameter("x", 0))
        ucrSelectorPlot.SetParameterIsrfunction()

        ucrReceiverMeasurement.SetParameter(New RParameter("y", 1))
        ucrReceiverMeasurement.Selector = ucrSelectorPlot
        ucrReceiverMeasurement.SetIncludedDataTypes({"numeric"})
        ucrReceiverMeasurement.strSelectorHeading = "Numerics"
        ucrReceiverMeasurement.SetParameterIsString()
        ucrReceiverMeasurement.bWithQuotes = False

        ucrReceiverTreatments.SetParameter(New RParameter("right", 1))
        ucrReceiverTreatments.Selector = ucrSelectorPlot
        ucrReceiverTreatments.SetIncludedDataTypes({"factor"})
        ucrReceiverTreatments.strSelectorHeading = "Factors"
        ucrReceiverTreatments.SetParameterIsString()
        ucrReceiverTreatments.bWithQuotes = False

        ucrInputFactorTreatment1.SetParameter(New RParameter("left", 0))
        ucrInputFactorTreatment1.SetFactorReceiver(ucrReceiverTreatments)
        ucrInputFactorTreatment1.bLevelsWithQuotes = False

        ucrInputFactorTreatment2.SetParameter(New RParameter("right", 1))
        ucrInputFactorTreatment2.SetFactorReceiver(ucrReceiverTreatments)
        ucrInputFactorTreatment2.AddQuotesIfUnrecognised = False
        ucrInputFactorTreatment2.bLevelsWithQuotes = False

        ucrReceiverID.SetParameter(New RParameter("left", 0))
        ucrReceiverID.Selector = ucrSelectorPlot
        ucrReceiverID.SetParameterIsString()
        ucrReceiverID.bWithQuotes = False

        ucrSavePlot.SetPrefix("line")
        ucrSavePlot.SetIsComboBox()
        ucrSavePlot.SetCheckBoxText("Save Graph")
        ucrSavePlot.SetSaveTypeAsGraph()
        ucrSavePlot.SetDataFrameSelector(ucrSelectorPlot.ucrAvailableDataFrames)
        ucrSavePlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRaesGlobalFunction = New RFunction
        clsRaesLineFunction = New RFunction

        clsLineGeom = New RFunction
        clsBoxplotGeom = New RFunction
        clsHlineGeom = New RFunction

        ucrSelectorPlot.Reset()
        ucrSelectorPlot.SetGgplotFunction(clsBaseOperator)
        ucrReceiverMeasurement.SetMeAsReceiver()

        ucrSavePlot.Reset()
        sdgPlots.Reset()

        bResetSubdialog = True
        bResetBoxLayerSubdialog = True

        ' Data manipulation code
        clsLeftJoin = New RFunction
        clsPipeOperator = New ROperator
        clsDCast = New RFunction
        clsDCastFormula = New ROperator
        clsMutate = New RFunction
        clsDiffOperator = New ROperator
        clsCut = New RFunction
        clsCutBreaks = New RFunction
        clsCutLabels = New RFunction

        clsLeftJoin.SetPackageName("dplyr")
        clsLeftJoin.SetRCommand("left_join")
        SetLeftJoinAssignTo()

        clsLeftJoin.AddParameter("y", clsROperatorParameter:=clsPipeOperator, iPosition:=1)

        clsPipeOperator.SetOperation("%>%")

        clsPipeOperator.AddParameter("1", clsRFunctionParameter:=clsDCast, iPosition:=1)
        clsPipeOperator.AddParameter("2", clsRFunctionParameter:=clsMutate, iPosition:=2)

        clsDCast.SetPackageName("reshape2")
        clsDCast.SetRCommand("dcast")
        clsDCast.AddParameter("formula", clsROperatorParameter:=clsDCastFormula, iPosition:=1)

        clsDCastFormula.SetOperation("~")

        clsMutate.SetPackageName("dplyr")
        clsMutate.SetRCommand("mutate")

        clsMutate.AddParameter(strDiff, clsROperatorParameter:=clsDiffOperator, iPosition:=0)
        clsMutate.AddParameter(strDiffCode, clsRFunctionParameter:=clsCut, iPosition:=1)

        clsDiffOperator.SetOperation("-")

        clsCut.SetRCommand("cut")
        clsCut.AddParameter("x", strDiff, iPosition:=0)
        clsCut.AddParameter("breaks", clsRFunctionParameter:=clsCutBreaks, iPosition:=1)
        clsCut.AddParameter("labels", clsRFunctionParameter:=clsCutLabels, iPosition:=2)

        clsCutBreaks.SetRCommand("c")
        clsCutBreaks.AddParameter("0", "-Inf, -10, 10, Inf", bIncludeArgumentName:=False)

        clsCutLabels.SetRCommand("c")
        clsCutLabels.AddParameter("0", Chr(34) & "Decrease" & Chr(34) & ", " & Chr(34) & "Same" & Chr(34) & ", " & Chr(34) & "Increase" & Chr(34), bIncludeArgumentName:=False)

        ' ggplot code
        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsLineGeom, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=clsLeftJoin, iPosition:=0)
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesGlobalFunction, iPosition:=1)

        clsRaesGlobalFunction.SetPackageName("ggplot2")
        clsRaesGlobalFunction.SetRCommand("aes")

        clsLineGeom.SetPackageName("ggplot2")
        clsLineGeom.SetRCommand("geom_line")
        clsLineGeom.AddParameter("mapping", clsRFunctionParameter:=clsRaesLineFunction, iPosition:=0)

        clsRaesLineFunction.SetPackageName("ggplot2")
        clsRaesLineFunction.SetRCommand("aes")
        clsRaesLineFunction.AddParameter("colour", strDiffCode)

        clsBoxplotGeom.SetPackageName("ggplot2")
        clsBoxplotGeom.SetRCommand("geom_boxplot")
        clsBoxplotGeom.AddParameter("outlier.colour", Chr(34) & "red" & Chr(34), iPosition:=1)

        clsHlineGeom.SetPackageName("ggplot2")
        clsHlineGeom.SetRCommand("geom_hline")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub SetRCodeforControls(bResetControls As Boolean)
        ucrSelectorPlot.AddAdditionalCodeParameterPair(clsPipeOperator, ucrSelectorPlot.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverTreatments.AddAdditionalCodeParameterPair(clsRaesGlobalFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=1)
        ucrReceiverID.AddAdditionalCodeParameterPair(clsRaesLineFunction, New RParameter("group", iNewPosition:=0), iAdditionalPairNo:=1)

        ucrInputFactorTreatment1.SetRCode(clsDiffOperator, bReset)
        ucrInputFactorTreatment2.SetRCode(clsDiffOperator, bReset)
        ucrReceiverMeasurement.SetRCode(clsRaesGlobalFunction, bResetControls)
        ucrReceiverTreatments.SetRCode(clsDCastFormula, bResetControls)
        ucrReceiverID.SetRCode(clsDCastFormula, bResetControls)
        ucrSelectorPlot.SetRCode(clsLeftJoin, bResetControls)
    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorPlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorPlot.ControlValueChanged
        SetLeftJoinAssignTo()
    End Sub

    Private Sub SetLeftJoinAssignTo()
        If ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            clsLeftJoin.SetAssignTo(ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_with_diff")
        Else
            clsPipeOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrReceiverMeasurement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMeasurement.ControlValueChanged
        If ucrReceiverMeasurement.IsEmpty() Then
            clsDCast.RemoveParameterByName("value.var")
        Else
            clsDCast.AddParameter("value.var", ucrReceiverMeasurement.GetVariableNames(), iPosition:=7)
        End If
    End Sub

    Private Sub ucrReceiverID_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverID.ControlValueChanged
        If ucrReceiverID.IsEmpty() Then
            clsLeftJoin.RemoveParameterByName("by")
        Else
            clsLeftJoin.AddParameter("by", ucrReceiverID.GetVariableNames(), iPosition:=2)
        End If
    End Sub
End Class