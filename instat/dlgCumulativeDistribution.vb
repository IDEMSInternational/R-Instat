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
    Private clsRgeomCumDistFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsAesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private bFirstLoad As Boolean = True
    Private clsLabsFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private bResetSubdialog As Boolean = True
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private clsSequence As New RFunction
    Private clsYScalesFunc As New RFunction
    Private clsYlabFunc As New RFunction
    Private bReset As Boolean = True

    Private strFirstParameterName As String = "stat_ecdf"
    Private strYScleParameterName As String = "YscaleContinous"
    Private strGeomParameterNames() As String = {strFirstParameterName, strYScleParameterName}

    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    'Parameter names for geoms
    Private strPointFirstParameterName As String = "geomfunc"
    Private strPointsParameterName As String = "geom_point"
    Private strGeomPointParameterNames() As String = {strPointFirstParameterName, strPointsParameterName}

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
        Dim clsGeomPointFunc As New RFunction
        Dim clsGeomPointParam As New RParameter
        Dim dctScalesPairs As New Dictionary(Of String, String)

        ucrChkCountsOnYAxis.Enabled = False ' temporary What should this do?

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 453

        ucrPnlOption.AddRadioButton(rdoCumulative)
        ucrPnlOption.AddRadioButton(rdoExceedance)

        ucrPnlOption.AddParameterPresentCondition(rdoCumulative, "y", bNewIsPositive:=False)
        ucrPnlOption.AddParameterPresentCondition(rdoExceedance, "y")

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
        dctScalesPairs.Add("proportion", "scales::comma")
        dctScalesPairs.Add("percent", "scales::percent")
        ucrInputComboScales.SetItems(dctScalesPairs)
        ucrInputComboScales.SetDropDownStyleAsNonEditable()
        ucrInputComboScales.SetRDefault("scales::comma")

        ucrNudBy.SetParameter(New RParameter("by"))
        ucrNudBy.DecimalPlaces = 2
        ucrNudBy.Increment = 0.01
        ucrNudBy.Minimum = 0
        ucrNudBy.Maximum = 1

        ucrChkCountsOnYAxis.SetText("Counts on Y Axis")

        clsGeomPointFunc.SetPackageName("ggplot2")
        clsGeomPointFunc.SetRCommand("geom_point")
        clsGeomPointFunc.AddParameter("stat", Chr(34) & "ecdf" & Chr(34))
        clsGeomPointParam.SetArgumentName(strPointsParameterName)
        clsGeomPointParam.SetArgument(clsGeomPointFunc)
        ucrChkIncludePoints.SetText("Include Points")
        ucrChkIncludePoints.SetParameter(clsGeomPointParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        'ucrInputComboPad.SetParameter(New RParameter("pad"))
        'ucrInputComboPad.SetItems({"TRUE", "FALSE"})
        'ucrInputComboPad.SetDropDownStyleAsNonEditable()
        'ucrInputComboPad.SetRDefault("TRUE")

        ucrSaveCumDist.SetPrefix("cumulative_dist")
        ucrSaveCumDist.SetSaveTypeAsGraph()
        ucrSaveCumDist.SetIsComboBox()
        ucrSaveCumDist.SetCheckBoxText("Save Graph")
        ucrSaveCumDist.SetAssignToIfUncheckedValue("last_graph")
        ucrSaveCumDist.SetDataFrameSelector(ucrCumDistSelector.ucrAvailableDataFrames)
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRaesFunction = New RFunction
        clsRgeomCumDistFunction = New RFunction
        clsRggplotFunction = New RFunction
        clsYScalesFunc = New RFunction

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

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("labs", clsRFunctionParameter:=clsLabsFunction)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRgeomCumDistFunction.SetPackageName("ggplot2")
        clsRgeomCumDistFunction.SetRCommand("stat_ecdf")
        clsRgeomCumDistFunction.AddParameter("pad", "FALSE")

        clsAesFunction.SetPackageName("ggplot2")
        clsAesFunction.SetRCommand("aes")

        clsYScalecontinuousFunction.AddParameter("labels", "scales::comma")

        clsLabsFunction.SetRCommand("labs")
        clsLabsFunction.AddParameter("y", "NULL")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone

        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)

        clsYScalecontinuousFunction.AddParameter("breaks", clsRFunctionParameter:=clsSequence)

        clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsRgeomCumDistFunction, iPosition:=1)
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

        ucrPnlOption.SetRCode(clsAesFunction, bReset)
        ucrInputComboScales.SetRCode(clsYScalecontinuousFunction, bReset)

        'ucrInputComboPad.SetRCode(clsRgeomCumDistFunction, bReset)

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
        sdgPlots.SetRCode(clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesFunction, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrCumDistSelector, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, strMainDialogGeomParameterNames:=strGeomParameterNames, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub CoreControls_ControlContentsChanged() Handles ucrVariablesAsFactorforCumDist.ControlContentsChanged, ucrSaveCumDist.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlOption_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOption.ControlValueChanged
        If rdoExceedance.Checked Then
            ' add y = ..y.. to aes()
            clsAesFunction.AddParameter("y", "1 - ..y..")
            ' add aes()
            clsRgeomCumDistFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesFunction, iPosition:=1)
        ElseIf rdoCumulative.Checked Then
            ' remove y from aes()
            clsAesFunction.RemoveParameterByName("y")
            ' remove aes() if no parameters
            If clsAesFunction.iParameterCount > 0 Then
                clsRgeomCumDistFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesFunction, iPosition:=1)
            Else
                clsRgeomCumDistFunction.RemoveParameterByName("mapping")
            End If
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrVariablesAsFactorforCumDist.ControlContentsChanged, ucrSaveCumDist.ControlContentsChanged

    End Sub
End Class