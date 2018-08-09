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
Public Class sdgPICSARainfallGraph
    Private bControlsInitialised As Boolean = False
    Public clsBaseOperator As ROperator
    Public clsYLabFunction, clsXLabFunction, clsLabsFunction As RFunction
    Public clsXScalecontinuousFunction, clsYScalecontinuousFunction, clsXAxisLabels, clsYAxisLabels, clsElementXAxisText, clsElementYAxisText As New RFunction
    Public clsMeanLine, clsMedianLine, clsTretile As New RFunction
    Public clsThemeFunction, clsPnlBackgroundFunction, clsPnlGridLinesFunction As RFunction
    Public dctThemeFunctions As New Dictionary(Of String, RFunction)

    Private Sub sdgPICSARainfallGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()

        ucrInputYAxisTitle.SetParameter(New RParameter("label"))
        ucrInputXAxisTitle.SetParameter(New RParameter("label"))

        ucrInputGraphTitle.SetParameter(New RParameter("title"))
        ucrInputGraphSubTitle.SetParameter(New RParameter("subtitle"))
        ucrInputGraphcCaption.SetParameter(New RParameter("caption"))

        UcrChkTitleSize.SetText("Size")
        UcrNudTitleSize.SetParameter(New RParameter("size"))
        UcrNudTitleSize.Increment = 0.1
        UcrNudTitleSize.Minimum = 0
        UcrChkTitleSize.AddParameterPresentCondition(True, "size")
        UcrChkTitleSize.AddParameterPresentCondition(False, "size", False)

        UcrChkSubTitleSize.SetText("Size")
        UcrNudSubTitleSize.SetParameter(New RParameter("size"))
        UcrNudSubTitleSize.Increment = 0.1
        UcrNudSubTitleSize.Minimum = 0
        UcrChkSubTitleSize.AddParameterPresentCondition(True, "size")
        UcrChkSubTitleSize.AddParameterPresentCondition(False, "size", False)

        ucrChkCaptionSize.SetText("Size")
        UcrNudCaptionSize.SetParameter(New RParameter("size"))
        UcrNudCaptionSize.Increment = 0.1
        UcrNudCaptionSize.Minimum = 0
        ucrChkCaptionSize.AddParameterPresentCondition(True, "size")
        ucrChkCaptionSize.AddParameterPresentCondition(False, "size", False)

        UcrChkXAxisTitleSzie.SetText("Size")
        UcrNudXAxisTitleSzie.SetParameter(New RParameter("size"))
        UcrNudXAxisTitleSzie.Increment = 0.1
        UcrNudXAxisTitleSzie.Minimum = 0
        UcrChkXAxisTitleSzie.AddParameterPresentCondition(True, "size")
        UcrChkXAxisTitleSzie.AddParameterPresentCondition(False, "size", False)

        UcrChkYAxisTitleSzie.SetText("Size")
        UcrNudYAxisTitleSzie.SetParameter(New RParameter("size"))
        UcrNudYAxisTitleSzie.Increment = 0.1
        UcrNudYAxisTitleSzie.Minimum = 0
        UcrChkYAxisTitleSzie.AddParameterPresentCondition(True, "size")
        UcrChkYAxisTitleSzie.AddParameterPresentCondition(False, "size", False)

        ucrChkXAxisAngle.SetText("Angle")
        ucrNudXAxisAngle.SetParameter(New RParameter("angle"))
        ucrNudXAxisAngle.SetMinMax(0, 360)
        ucrChkXAxisAngle.AddParameterPresentCondition(True, "angle")
        ucrChkXAxisAngle.AddParameterPresentCondition(False, "angle", False)

        ucrChkYAxisAngle.SetText("Angle")
        ucrNudYAxisAngle.SetParameter(New RParameter("angle"))
        ucrNudYAxisAngle.SetMinMax(0, 360)
        ucrChkYAxisAngle.AddParameterPresentCondition(True, "angle")
        ucrChkYAxisAngle.AddParameterPresentCondition(False, "angle", False)

        ucrChkSpecifyXAxisTickMarks.SetText("Specify Tick Marks")
        ucrChkSpecifyXAxisTickMarks.SetParameter(New RParameter("breaks"))
        ucrInputXFrom.SetParameter(New RParameter("from"))
        ucrInputXTo.SetParameter(New RParameter("to"))
        ucrInputXInStepsOf.SetParameter(New RParameter("step"))

        ucrChkSpecifyYAxisTickMarks.SetText("Specify Tick Marks")
        ucrChkSpecifyYAxisTickMarks.SetParameter(New RParameter("breaks"))
        ucrInputYFrom.SetParameter(New RParameter("from"))
        ucrInputYTo.SetParameter(New RParameter("to"))
        ucrInputYInStepsOf.SetParameter(New RParameter("step"))

        ucrChkLabelForDays.SetText("Labels for Days in Year")
        'ucrChkLabelForDays - set parameter
        'ucrInputLabelForDays -set parameter
        'ucrInputLabelForDays - set dictonary 
        'dctLabelForDays  - set items   

        ucrChkPnlBackgroundColour.SetText("Colour")
        ucrChkPnlBackgroundColour.SetParameter(New RParameter("Colour"))
        UcrInputPnlBackgroundColour.SetParameter(New RParameter("colour"))
        'UcrInputPnlBackgroundColour add dictonary for colours 

        UcrChkPnlBackgroundFill.SetText("Fill")
        UcrChkPnlBackgroundFill.SetParameter(New RParameter("Fill"))
        UcrInputPnlBackgroundFill.SetParameter(New RParameter("fill"))
        'UcrInputPnlBackgroundFill add dictonary for colours 

        UcrChkPnlBackgroundLineType.SetText("Line Type")
        UcrChkPnlBackgroundLineType.SetParameter(New RParameter("Linetype"))
        UcrInputGridLineLinetype.SetParameter(New RParameter("linetype"))

        UcrChkPnlBackgroundSize.SetText("Size")
        UcrNudYAxisTitleSzie.SetParameter(New RParameter("size"))
        ucrNudPnlBackgroundSize.Increment = 0.1
        ucrNudPnlBackgroundSize.Minimum = 0
        UcrChkPnlBackgroundSize.AddParameterPresentCondition(True, "size")
        UcrChkPnlBackgroundSize.AddParameterPresentCondition(False, "size", False)

        UcrChkGridLineColour.SetText("Colour")
        UcrChkGridLineColour.SetParameter(New RParameter("Colour"))
        UcrInputGridLineColour.SetParameter(New RParameter("colour"))
        'UcrInputGridLineColour add dictonary for colours 

        UcrChkGridLinetype.SetText("Line Type")
        UcrChkGridLinetype.SetParameter(New RParameter("Linetype"))
        UcrInputGridLineColour.SetParameter(New RParameter("linetype"))


        ' Line tab 
        ucrChkAddMean.SetText("Add Mean")
        ucrChkAddMedian.SetText("Add Median")
        ucrChkAddTerciles.SetText("Add Terciles")

        ' Title tab 


        ' Labels tab

        ucrChkYAxisAngle.AddToLinkedControls(ucrNudYAxisAngle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkYAxisLabelSize.AddToLinkedControls(ucrNudYAxisLabelSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSpecifyYAxisTickMarks.AddToLinkedControls({ucrInputYFrom, ucrInputYTo, ucrInputYInStepsOf}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputYFrom.SetLinkedDisplayControl(lblYFrom)
        ucrInputYTo.SetLinkedDisplayControl(lblYTo)
        ucrInputYInStepsOf.SetLinkedDisplayControl(lblYInStepsOf)

        ucrChkXAxisAngle.AddToLinkedControls(ucrNudXAxisAngle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkXAxisLabelSize.AddToLinkedControls(ucrNudXaxisLabelSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLabelForDays.AddToLinkedControls(ucrInputLabelForDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSpecifyXAxisTickMarks.AddToLinkedControls({ucrInputXFrom, ucrInputXTo, ucrInputXInStepsOf}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputXFrom.SetLinkedDisplayControl(lblXFrom)
        ucrInputXTo.SetLinkedDisplayControl(lblXTo)
        ucrInputXInStepsOf.SetLinkedDisplayControl(lblXInStepsOf)

        ' Panel tab 
        ucrChkPnlBackgroundColour.AddToLinkedControls(UcrInputPnlBackgroundColour, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrChkPnlBackgroundFill.AddToLinkedControls(UcrInputPnlBackgroundFill, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrChkPnlBackgroundLineType.AddToLinkedControls(UcrInputPnlBackgroundLinetype, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrChkPnlBackgroundSize.AddToLinkedControls(ucrNudPnlBackgroundSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        UcrChkGridLineColour.AddToLinkedControls(UcrInputGridLineColour, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrChkGridLinetype.AddToLinkedControls(UcrInputGridLineLinetype, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewOperator As ROperator, Optional clsNewYLabTitleFunction As RFunction = Nothing, Optional clsNewXLabsTitleFunction As RFunction = Nothing, Optional clsNewLabsFunction As RFunction = Nothing, Optional clsNewElemenXAxisText As RFunction = Nothing, Optional clsNewElemenYAxisText As RFunction = Nothing, Optional clsNewXScalecontinuousFunction As RFunction = Nothing, Optional clsNewYScalecontinuousFunction As RFunction = Nothing, Optional clsNewThemeFunction As RFunction = Nothing, Optional dctNewThemeFunctions As Dictionary(Of String, RFunction) = Nothing, Optional clsNewPnlGridLinesFunction As RFunction = Nothing, Optional clsNewPnlBackgroundFunction As RFunction = Nothing, Optional bReset As Boolean = False)

        Dim clsPlotElementTitle As New RFunction
        Dim clsPlotElementSubTitle As New RFunction
        Dim clsPlotElementCaption As New RFunction
        Dim clsXElementTitle As New RFunction
        Dim clsYElementTitle As New RFunction
        Dim clsXElementLabels As New RFunction
        Dim clsYElementLabels As New RFunction
        Dim clsElementPanelGrid As New RFunction
        Dim clsPnlBackgroundElementRect As New RFunction
        Dim clsElementPanelBackGround As New RFunction
        Dim clsElementBorder As New RFunction

        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsThemeFunction = clsNewThemeFunction
        ' The position MUST be larger than the position of the theme_* argument
        ' Otherwise the choice of theme will overwrite the options selected here.
        ' Currently set to large value as no reason this cannot be at the end currently
        clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=100)

        dctThemeFunctions = dctNewThemeFunctions
        dctThemeFunctions.TryGetValue("axis.text.x", clsXElementLabels)
        dctThemeFunctions.TryGetValue("axis.text.y", clsXElementLabels)
        dctThemeFunctions.TryGetValue("axis.title.x", clsXElementTitle)
        dctThemeFunctions.TryGetValue("axis.title.y", clsYElementTitle)

        dctThemeFunctions.TryGetValue("panel.grid", clsElementPanelGrid)
        dctThemeFunctions.TryGetValue("panel.background", clsElementPanelBackGround)
        dctThemeFunctions.TryGetValue("panel.border", clsElementBorder)

        ucrNudXAxisAngle.SetRCode(clsXElementLabels, bCloneIfNeeded:=True)
        'ucrNudXAxisAngle.SetRCode(clsXElementLabels) clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        clsXLabFunction = clsNewXLabsTitleFunction
        clsYLabFunction = clsNewYLabTitleFunction
        clsElementXAxisText = clsNewElemenXAxisText
        clsElementYAxisText = clsNewElemenYAxisText
        clsXScalecontinuousFunction = clsNewXScalecontinuousFunction
        clsYScalecontinuousFunction = clsNewYScalecontinuousFunction
        clsPnlBackgroundFunction = clsNewPnlBackgroundFunction
        clsPnlGridLinesFunction = clsNewPnlGridLinesFunction
        clsThemeFunction = clsNewThemeFunction
        dctThemeFunctions = dctNewThemeFunctions
        clsBaseOperator = clsNewOperator

        ' Graph Titles 
        If clsNewLabsFunction IsNot Nothing Then
            clsLabsFunction = clsNewLabsFunction
        Else
            clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        End If

        ucrInputGraphTitle.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputGraphSubTitle.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputGraphcCaption.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)

        'Axes Titles 
        If clsNewXLabsTitleFunction IsNot Nothing Then
            clsXLabFunction = clsNewXLabsTitleFunction
        Else
            clsXLabFunction = GgplotDefaults.clsDefaultLabs.Clone()
        End If

        If clsNewYLabTitleFunction IsNot Nothing Then
            clsYLabFunction = clsNewXLabsTitleFunction
        Else
            clsYLabFunction = GgplotDefaults.clsDefaultLabs.Clone()
        End If

        ucrInputYAxisTitle.SetRCode(clsYLabFunction, bReset)
        ucrInputXAxisTitle.SetRCode(clsXLabFunction, bReset)
    End Sub


End Class