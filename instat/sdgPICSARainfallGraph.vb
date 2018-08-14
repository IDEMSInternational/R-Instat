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
    Public clsLabsFunction As RFunction
    Public clsXScalecontinuousFunction, clsYScalecontinuousFunction As New RFunction
    Public clsXScalecontinuousSeqFunction, clsYScalecontinuousSeqFunction As New RFunction
    Public clsMeanLine, clsMedianLine, clsTretile As New RFunction
    Public clsThemeFunction As RFunction
    Public dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private bRCodeSet As Boolean = False

    Private Sub sdgPICSARainfallGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()

        ucrInputYAxisTitle.SetParameter(New RParameter("y"))
        ucrInputXAxisTitle.SetParameter(New RParameter("x"))

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

        ' to remove x-axis title we have scale_x_continuous(name = "")
        ucrChkRemoveXAxisTitle.SetText("Remove Title")
        ucrChkRemoveXAxisTitle.SetParameter(New RParameter("name"))
        ucrChkRemoveXAxisTitle.AddParameterPresentCondition(True, "name")
        ucrChkRemoveXAxisTitle.AddParameterPresentCondition(False, "name", False)

        ' to remove y-axis title we have scale_y_continuous(name = "")
        ucrChkRemoveYAxisTitle.SetText("Remove Title")
        ucrChkRemoveYAxisTitle.SetParameter(New RParameter("name"))
        ucrChkRemoveYAxisTitle.AddParameterPresentCondition(True, "name")
        ucrChkRemoveYAxisTitle.AddParameterPresentCondition(False, "name", False)
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

    Public Sub SetRCode(clsNewOperator As ROperator, Optional clsNewLabsFunction As RFunction = Nothing, Optional clsNewXScalecontinuousFunction As RFunction = Nothing, Optional clsNewYScalecontinuousFunction As RFunction = Nothing, Optional clsNewThemeFunction As RFunction = Nothing, Optional dctNewThemeFunctions As Dictionary(Of String, RFunction) = Nothing, Optional bReset As Boolean = False)

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

        clsBaseOperator = clsNewOperator

        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsThemeFunction = clsNewThemeFunction
        ' The position MUST be larger than the position of the theme_* argument
        ' Otherwise the choice of theme will overwrite the options selected here.
        ' Currently set to large value as no reason this cannot be at the end currently
        'clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=100)

        dctThemeFunctions = dctNewThemeFunctions
        dctThemeFunctions.TryGetValue("axis.text.x", clsXElementLabels)
        dctThemeFunctions.TryGetValue("axis.text.y", clsXElementLabels)

        dctThemeFunctions.TryGetValue("title", clsPlotElementTitle)
        dctThemeFunctions.TryGetValue("sub.title", clsPlotElementSubTitle)
        dctThemeFunctions.TryGetValue("caption", clsPlotElementCaption)
        dctThemeFunctions.TryGetValue("axis.title.x", clsXElementTitle)
        dctThemeFunctions.TryGetValue("axis.title.y", clsYElementTitle)

        dctThemeFunctions.TryGetValue("panel.grid", clsElementPanelGrid)
        dctThemeFunctions.TryGetValue("panel.background", clsElementPanelBackGround)
        dctThemeFunctions.TryGetValue("panel.border", clsElementBorder)

        UcrNudTitleSize.SetRCode(clsPlotElementTitle, bCloneIfNeeded:=True)
        UcrNudSubTitleSize.SetRCode(clsPlotElementSubTitle, bCloneIfNeeded:=True)
        UcrNudCaptionSize.SetRCode(clsPlotElementCaption, bCloneIfNeeded:=True)
        UcrNudXAxisTitleSzie.SetRCode(clsXElementTitle, bCloneIfNeeded:=True)
        UcrNudYAxisTitleSzie.SetRCode(clsYElementTitle, bCloneIfNeeded:=True)

        ucrNudXAxisAngle.SetRCode(clsXElementLabels, bCloneIfNeeded:=True)
        ucrNudXaxisLabelSize.SetRCode(clsXElementLabels, bCloneIfNeeded:=True)

        ucrNudYAxisAngle.SetRCode(clsYElementLabels, bCloneIfNeeded:=True)
        ucrNudYAxisLabelSize.SetRCode(clsYElementLabels, bCloneIfNeeded:=True)

        UcrInputPnlBackgroundColour.SetRCode(clsPnlBackgroundElementRect, bCloneIfNeeded:=True)
        UcrInputPnlBackgroundFill.SetRCode(clsPnlBackgroundElementRect, bCloneIfNeeded:=True)
        UcrInputPnlBackgroundLinetype.SetRCode(clsPnlBackgroundElementRect, bCloneIfNeeded:=True)
        ucrNudPnlBackgroundSize.SetRCode(clsPnlBackgroundElementRect, bCloneIfNeeded:=True)

        UcrInputGridLineColour.SetRCode(clsElementPanelGrid, bCloneIfNeeded:=True)
        UcrInputGridLineLinetype.SetRCode(clsElementPanelGrid, bCloneIfNeeded:=True)

        clsXScalecontinuousFunction = clsNewXScalecontinuousFunction
        clsYScalecontinuousFunction = clsNewYScalecontinuousFunction

        If clsNewXScalecontinuousFunction IsNot Nothing Then
            clsXScalecontinuousFunction = clsNewXScalecontinuousFunction
        Else
            clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        End If

        If clsNewYScalecontinuousFunction IsNot Nothing Then
            clsYScalecontinuousFunction = clsNewYScalecontinuousFunction
        Else
            clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        End If

        ucrChkRemoveXAxisTitle.SetRCode(clsXScalecontinuousFunction, bReset, bCloneIfNeeded:=True)
        ucrChkRemoveXAxisTitle.SetRCode(clsYScalecontinuousFunction, bReset, bCloneIfNeeded:=True)

        'set r code for to, from and in steps of for x and y labels - clsXScalecontinuousSeqFunction and clsYScalecontinuousSeqFunction

        ' Graph Titles 
        If clsNewLabsFunction IsNot Nothing Then
            clsLabsFunction = clsNewLabsFunction
        Else
            clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        End If

        ucrInputGraphTitle.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputGraphSubTitle.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputGraphcCaption.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputYAxisTitle.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputXAxisTitle.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)

        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction.iParameterCount > 0 Then
            ' The position MUST be larger than the position of the theme_* argument
            ' Otherwise the choice of theme will overwrite the options selected here.
            ' Currently set to large value as no reason this cannot be at the end currently
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=100)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub AddRemoveLabs()
        If bRCodeSet Then
            If Not ucrInputGraphTitle.IsEmpty() OrElse Not ucrInputGraphSubTitle.IsEmpty() OrElse Not ucrInputGraphcCaption.IsEmpty() OrElse Not ucrInputXAxisTitle.IsEmpty() OrElse Not ucrInputYAxisTitle.IsEmpty() Then
                clsBaseOperator.AddParameter("labs", clsRFunctionParameter:=clsLabsFunction)
            Else
                clsBaseOperator.RemoveParameterByName("labs")
            End If
        End If
    End Sub

    Private Sub LabsControls_ControlValueChanged() Handles ucrInputGraphTitle.ControlValueChanged, ucrInputGraphSubTitle.ControlValueChanged, ucrInputGraphcCaption.ControlValueChanged, ucrInputXAxisTitle.ControlValueChanged, ucrInputYAxisTitle.ControlValueChanged
        AddRemoveLabs()
    End Sub

    Private Sub AddRemoveAxisLabels()
        If bRCodeSet Then
            If Not (UcrChkTitleSize.Checked AndAlso UcrNudTitleSize.GetText <> "") OrElse (UcrChkSubTitleSize.Checked AndAlso UcrNudSubTitleSize.GetText <> "") OrElse (ucrChkCaptionSize.Checked AndAlso UcrNudCaptionSize.GetText <> "") OrElse (UcrChkXAxisTitleSzie.Checked AndAlso UcrNudXAxisTitleSzie.GetText <> "") OrElse (UcrChkYAxisTitleSzie.Checked AndAlso UcrNudYAxisTitleSzie.GetText <> "") OrElse (ucrChkXAxisAngle.Checked AndAlso ucrNudXAxisAngle.GetText <> "") OrElse (ucrChkYAxisAngle.Checked AndAlso ucrNudYAxisAngle.GetText <> "") OrElse (ucrChkYAxisLabelSize.Checked AndAlso ucrNudYAxisLabelSize.GetText <> "") OrElse (ucrChkXAxisLabelSize.Checked AndAlso ucrNudXaxisLabelSize.GetText <> "") OrElse (ucrChkPnlBackgroundColour.Checked AndAlso Not UcrInputPnlBackgroundColour.IsEmpty()) OrElse (UcrChkPnlBackgroundFill.Checked AndAlso Not UcrInputPnlBackgroundFill.IsEmpty()) OrElse (UcrChkPnlBackgroundLineType.Checked AndAlso Not UcrInputPnlBackgroundLinetype.IsEmpty()) OrElse (UcrChkGridLineColour.Checked AndAlso Not UcrInputGridLineColour.IsEmpty()) OrElse (UcrChkGridLinetype.Checked AndAlso Not UcrInputGridLineLinetype.IsEmpty()) Then
                clsBaseOperator.AddParameter("themes", clsRFunctionParameter:=clsThemeFunction)
            Else
                clsBaseOperator.RemoveParameterByName("themes")
            End If
        End If
    End Sub
End Class