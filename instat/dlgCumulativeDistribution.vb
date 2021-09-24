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
Public Class dlgCumulativeDistribution
    Private clsRggplotFunction As New RFunction
    Private clsStatECDFFunction As New RFunction
    Private clsStatECDFPointFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsStatECDFAesFunction As New RFunction
    Private clsStatECDFPointAesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private bFirstLoad As Boolean = True
    Private clsLabsFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private bResetSubdialog As Boolean = True
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private clsSequence As New RFunction
    Private bReset As Boolean = True

    Private strFirstParameterName As String = "stat_ecdf"
    Private strFirstPointParameterName As String = "stat_ecdf2"
    Private strYScleParameterName As String = "YscaleContinous"
    Private strGeomParameterNames() As String = {strFirstParameterName, strFirstPointParameterName, strYScleParameterName}

    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator

    Private Sub dlgCumulativeDistribution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitaliseDialog()
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

    Private Sub InitaliseDialog()
        Dim dctScalesPairs As New Dictionary(Of String, String)

        ucrChkCountsOnYAxis.Enabled = False ' temporary What should this do?

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 453

        ucrPnlOption.AddRadioButton(rdoCumulative)
        ucrPnlOption.AddRadioButton(rdoExceedance)

        ucrPnlOption.AddParameterPresentCondition(rdoCumulative, "mapping", bNewIsPositive:=False)
        ucrPnlOption.AddParameterPresentCondition(rdoExceedance, "mapping")

        ucrCumDistSelector.SetParameter(New RParameter("data", 0))
        ucrCumDistSelector.SetParameterIsrfunction()

        ucrFactorReceiver.SetParameter(New RParameter("colour", 1))
        ucrFactorReceiver.Selector = ucrCumDistSelector
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorReceiver.strSelectorHeading = "Factors"
        ucrFactorReceiver.SetParameterIsString()
        ucrFactorReceiver.bWithQuotes = False

        ucrVariablesAsFactorforCumDist.SetParameter(New RParameter("x", 0))
        ucrVariablesAsFactorforCumDist.SetFactorReceiver(ucrFactorReceiver)
        ucrVariablesAsFactorforCumDist.Selector = ucrCumDistSelector
        ucrVariablesAsFactorforCumDist.SetIncludedDataTypes({"numeric"})
        ucrVariablesAsFactorforCumDist.strSelectorHeading = "Numerics"
        ucrVariablesAsFactorforCumDist.SetParameterIsString()
        ucrVariablesAsFactorforCumDist.bWithQuotes = False

        ucrInputComboScales.SetParameter(New RParameter("labels"))
        dctScalesPairs.Add("Proportion", "scales::comma")
        dctScalesPairs.Add("Percent", "scales::percent")
        ucrInputComboScales.SetItems(dctScalesPairs)
        ucrInputComboScales.SetDropDownStyleAsNonEditable()
        ucrInputComboScales.SetRDefault("scales::comma")

        ucrNudBy.SetParameter(New RParameter("by"))
        ucrNudBy.DecimalPlaces = 2
        ucrNudBy.Increment = 0.01
        ucrNudBy.Minimum = 0
        ucrNudBy.Maximum = 1

        ucrChkCountsOnYAxis.SetText("Counts on Y Axis")

        ucrChkIncludePoints.SetText("Include Points")
        ucrChkIncludePoints.SetParameter(New RParameter("geom"), bNewChangeParameterValue:=False)
        ucrChkIncludePoints.SetParameterValue(Chr(34) & "point" & Chr(34))

        'ucrInputComboPad.SetParameter(New RParameter("pad"))
        'ucrInputComboPad.SetItems({"TRUE", "FALSE"})
        'ucrInputComboPad.SetDropDownStyleAsNonEditable()
        'ucrInputComboPad.SetRDefault("TRUE")

        ucrSaveCumDist.SetSaveTypeAsGraph()
        ucrSaveCumDist.SetDataFrameSelector(ucrCumDistSelector.ucrAvailableDataFrames)
        ucrSaveCumDist.SetCheckBoxText("Save Graph")
        ucrSaveCumDist.SetIsComboBox()
        ucrSaveCumDist.SetPrefix("cumulative_dist")
        ucrSaveCumDist.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRaesFunction = New RFunction
        clsStatECDFFunction = New RFunction
        clsStatECDFPointFunction = New RFunction
        clsRggplotFunction = New RFunction
        clsStatECDFAesFunction = New RFunction
        clsStatECDFPointAesFunction = New RFunction

        clsSequence = New RFunction
        clsSequence.SetRCommand("seq")
        clsSequence.AddParameter("from", "0", iPosition:=0)
        clsSequence.AddParameter("to", "1", iPosition:=1)
        clsSequence.AddParameter("by", "0.25", iPosition:=2)

        ucrCumDistSelector.Reset()
        ucrCumDistSelector.SetGgplotFunction(clsBaseOperator)
        ucrCumDistSelector.Focus()
        ucrSaveCumDist.Reset()
        ucrVariablesAsFactorforCumDist.SetMeAsReceiver()
        sdgPlots.Reset()
        bResetSubdialog = True


        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsStatECDFFunction.SetPackageName("ggplot2")
        clsStatECDFFunction.SetRCommand("stat_ecdf")
        clsStatECDFFunction.AddParameter("pad", "FALSE", iPosition:=0)

        clsStatECDFPointFunction.SetPackageName("ggplot2")
        clsStatECDFPointFunction.SetRCommand("stat_ecdf")
        clsStatECDFPointFunction.AddParameter("pad", "FALSE", iPosition:=0)

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("labs", clsRFunctionParameter:=clsLabsFunction, iPosition:=1)

        clsStatECDFAesFunction.SetPackageName("ggplot2")
        clsStatECDFAesFunction.SetRCommand("aes")
        clsStatECDFAesFunction.AddParameter("y", "1 - ..y..", iPosition:=0)

        clsStatECDFPointAesFunction.SetPackageName("ggplot2")
        clsStatECDFPointAesFunction.SetRCommand("aes")
        clsStatECDFPointAesFunction.AddParameter("y", "1 - ..y..", iPosition:=0)


        clsYScalecontinuousFunction.AddParameter("labels", "scales::comma")

        clsLabsFunction.SetRCommand("labs")
        clsLabsFunction.AddParameter("y", "NULL")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)

        clsYScalecontinuousFunction.AddParameter("breaks", clsRFunctionParameter:=clsSequence)

        clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsStatECDFFunction, iPosition:=2)
        clsBaseOperator.AddParameter(strYScleParameterName, clsRFunctionParameter:=clsYScalecontinuousFunction, bIncludeArgumentName:=False)

        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrCumDistSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrFactorReceiver.SetRCode(clsRaesFunction, bReset)
        ucrVariablesAsFactorforCumDist.SetRCode(clsRaesFunction, bReset)
        ucrSaveCumDist.SetRCode(clsBaseOperator, bReset)
        ucrCumDistSelector.SetRCode(clsRggplotFunction, bReset)

        ucrPnlOption.SetRCode(clsStatECDFFunction, bReset)
        ucrInputComboScales.SetRCode(clsYScalecontinuousFunction, bReset)

        ucrChkIncludePoints.SetRCode(clsStatECDFPointFunction, bReset)

        ucrNudBy.SetRCode(clsSequence, bReset)

    End Sub

    Private Sub TestOkEnabled()
        If ucrVariablesAsFactorforCumDist.IsEmpty OrElse Not ucrSaveCumDist.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdPlotOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesFunction,
                          clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction,
                          clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction,
                          clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, ucrNewBaseSelector:=ucrCumDistSelector, clsNewCoordPolarFunction:=clsCoordPolarFunction,
                          clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction,
                           clsNewAnnotateFunction:=clsAnnotateFunction, strMainDialogGeomParameterNames:=strGeomParameterNames, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub CoreControls_ControlContentsChanged() Handles ucrVariablesAsFactorforCumDist.ControlContentsChanged, ucrSaveCumDist.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlOption_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOption.ControlValueChanged
        If rdoExceedance.Checked Then
            clsStatECDFFunction.AddParameter("mapping", clsRFunctionParameter:=clsStatECDFAesFunction, iPosition:=2)
            clsStatECDFPointFunction.AddParameter("mapping", clsRFunctionParameter:=clsStatECDFPointAesFunction, iPosition:=2)

        ElseIf rdoCumulative.Checked Then
            clsStatECDFFunction.RemoveParameterByName("mapping")
            clsStatECDFPointFunction.RemoveParameterByName("mapping")
        End If
    End Sub

    Private Sub ucrChkIncludePoints_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludePoints.ControlValueChanged
        If ucrChkIncludePoints.Checked Then
            clsBaseOperator.AddParameter(strFirstPointParameterName, clsRFunctionParameter:=clsStatECDFPointFunction, iPosition:=3)
        Else
            clsBaseOperator.RemoveParameterByName(strFirstPointParameterName)
        End If
    End Sub
End Class