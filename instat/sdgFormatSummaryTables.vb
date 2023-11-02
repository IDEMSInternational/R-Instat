﻿' R- Instat
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

Public Class sdgFormatSummaryTables
    Private clsTableTitleFunction, clsStubFunction, clsTabFootnoteTitleFunction, clsStubFootnoteFunction, clsStubCellsFunction, clsTableSourcenoteFunction, clsFootnoteCellFunction,
        clsFootnoteTitleLocationFunction, clsFootnoteSubtitleLocationFunction, clsTabFootnoteSubtitleFunction,
        clsFootnoteCellBodyFunction, clsSecondFootnoteCellFunction, clsSecondFootnoteCellBodyFunction,
        clsTabStyleFunction, clsTabStyleCellTextFunction, clsTabStylePxFunction As New RFunction
    'The dummy Function is used by input controls that add the parameter manually,
    'when opening the subdialogue from multiple dialogues
    Private clsDummyFunction As New RFunction
    Public clsThemesTabOptionsFunction, clsgtExtrasThemesFunction As New RFunction
    Private clsPipeOperator, clsJoiningOperator As New ROperator
    Private bControlsInitialised As Boolean = False
    Private bRCodeSet As Boolean = False
    Private bResetThemes As Boolean = True

    Private Sub sdgFormatSummaryTables_load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctgtExtraThemes As New Dictionary(Of String, String)

        'Themes
        ucrPnlThemesPanel.AddRadioButton(rdoSelectTheme)
        ucrPnlThemesPanel.AddRadioButton(rdoManualTheme)
        ucrPnlThemesPanel.AddParameterValuesCondition(rdoSelectTheme, "theme", "select")
        ucrPnlThemesPanel.AddParameterValuesCondition(rdoManualTheme, "theme", "manual")

        ucrInputSelectThemes.SetItems({"Dark Theme", "538 Theme", "Dot Matrix Theme", "Espn Theme", "Excel Theme",
                                      "Guardian Theme", "NY Times Theme", "PFF Theme"})
        ucrInputSelectThemes.SetDropDownStyleAsNonEditable()

        ucrPnlThemesPanel.AddToLinkedControls(ucrInputSelectThemes, {rdoSelectTheme}, bNewLinkedHideIfParameterMissing:=True)

        'Titles
        ucrInputTitle.SetParameter(New RParameter("title", iNewPosition:=0))
        ucrInputTitle.SetLinkedDisplayControl(lblTitle)

        ucrInputSubtitle.SetParameter(New RParameter("subtitle", iNewPosition:=1))
        ucrInputSubtitle.SetLinkedDisplayControl(lblSubtitle)

        ucrInputTitleFootnote.SetParameter(New RParameter("title_footnote", iNewPosition:=2))

        ucrChkTitleFootnote.SetText("Add title footnote")
        ucrChkTitleFootnote.AddToLinkedControls(ucrInputTitleFootnote, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTitleFootnote.SetLinkedDisplayControl(grpTitle)

        ucrChkTitleFootnote.AddParameterPresentCondition(True, "title_footnote")
        ucrChkTitleFootnote.AddParameterPresentCondition(False, "title_footnote", False)

        ucrChkStubFootnote.SetText("Add footnote")
        ucrChkStubFootnote.AddToLinkedControls(ucrInputStubFootnote, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkStubFootnote.SetLinkedDisplayControl(grpStub)

        ucrChkStubFootnote.AddParameterPresentCondition(True, "title_stub_footnote")
        ucrChkStubFootnote.AddParameterPresentCondition(False, "title_stub_footnote", False)


        ucrInputSubtitleFootnote.SetParameter(New RParameter("subtitle_footnote", iNewPosition:=3))
        ucrChkSubtitleFootnote.SetText("Add subtitle footnote")
        ucrChkSubtitleFootnote.AddToLinkedControls(ucrInputSubtitleFootnote, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSubtitleFootnote.SetLinkedDisplayControl(grpSubtitle)
        ucrChkSubtitleFootnote.AddParameterPresentCondition(True, "subtitle_footnote")
        ucrChkSubtitleFootnote.AddParameterPresentCondition(False, "subtitle_footnote", False)

        ucrChkIncludeTitles.SetText("Include titles")
        ucrChkIncludeTitles.AddToLinkedControls({ucrInputTitle, ucrInputSubtitle, ucrChkTitleFootnote, ucrChkSubtitleFootnote}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputTitleFootnote.SetLinkedDisplayControl(lblTitleFootnote)


        ucrChkIncludeTitles.AddParameterPresentCondition(True, "title_subtitle")
        ucrChkIncludeTitles.AddParameterPresentCondition(False, "title_subtitle", False)
        ucrInputSubtitleFootnote.SetLinkedDisplayControl(lblSubtitleFootnote)

        ucrChkStub.SetText("Include Stub")
        ucrChkStub.AddToLinkedControls({ucrInputStub, ucrChkStubFootnote}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkStub.AddParameterPresentCondition(True, "title_stub")
        ucrChkStub.AddParameterPresentCondition(False, "title_stub", False)

        ucrInputStub.SetParameter(New RParameter("Stub", iNewPosition:=0))
        ucrInputStub.SetLinkedDisplayControl(lblStubs)


        ucrInputStubFootnote.SetParameter(New RParameter("Stub_footnote", iNewPosition:=0))
        ucrInputStubFootnote.SetLinkedDisplayControl(lblStubFootnote)

        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(bReset As Boolean, clsNewStubFunction As RFunction, clsNewTableTitleFunction As RFunction, clsNewStubFootnoteFunction As RFunction, clsNewStubCellsFunction As RFunction, clsNewTabFootnoteTitleFunction As RFunction, clsNewFootnoteCellFunction As RFunction,
                        clsNewTableSourcenoteFunction As RFunction, clsNewTabStyleFunction As RFunction, clsNewMutableOPerator As ROperator,
                        clsNewPipeOperator As ROperator, clsNewFootnoteTitleLocationFunction As RFunction, clsNewFootnoteSubtitleLocationFunction As RFunction,
                        clsNewTabFootnoteSubtitleFunction As RFunction, clsNewFootnoteCellBodyFunction As RFunction, clsNewJoiningOperator As ROperator,
                        clsNewSecondFootnoteCellFunction As RFunction, clsNewTabStyleCellTextFunction As RFunction,
                        clsNewSecondFootnoteCellBodyFunction As RFunction, clsNewTabStylePxFunction As RFunction, clsNewDummyFunction As RFunction,
                        clsNewThemesTabOptionFunction As RFunction, clsNewgtExtraThemesFunction As RFunction)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        AddRemoveManualTheme()

        bRCodeSet = False
        clsTableTitleFunction = clsNewTableTitleFunction
        clsStubFunction = clsNewStubFunction
        clsTabFootnoteTitleFunction = clsNewTabFootnoteTitleFunction
        clsStubFootnoteFunction = clsNewStubFootnoteFunction
        clsStubCellsFunction = clsNewStubCellsFunction
        clsTabFootnoteSubtitleFunction = clsNewTabFootnoteSubtitleFunction
        clsTableSourcenoteFunction = clsNewTableSourcenoteFunction
        clsFootnoteSubtitleLocationFunction = clsNewFootnoteSubtitleLocationFunction
        clsFootnoteTitleLocationFunction = clsNewFootnoteTitleLocationFunction
        clsPipeOperator = clsNewPipeOperator
        clsFootnoteCellFunction = clsNewFootnoteCellFunction
        clsFootnoteCellBodyFunction = clsNewFootnoteCellBodyFunction
        clsJoiningOperator = clsNewJoiningOperator
        clsSecondFootnoteCellFunction = clsNewSecondFootnoteCellFunction
        clsSecondFootnoteCellBodyFunction = clsNewSecondFootnoteCellBodyFunction
        clsTabStyleFunction = clsNewTabStyleFunction
        clsTabStyleCellTextFunction = clsNewTabStyleCellTextFunction
        clsTabStylePxFunction = clsNewTabStylePxFunction
        clsDummyFunction = clsNewDummyFunction
        clsThemesTabOptionsFunction = clsNewThemesTabOptionFunction
        clsgtExtrasThemesFunction = clsNewgtExtraThemesFunction

        If bReset Then
            ucrInputSelectThemes.SetText("Dark Theme")
        End If

        ucrChkIncludeTitles.SetRCode(clsPipeOperator, bReset, bCloneIfNeeded:=True)
        ucrChkTitleFootnote.SetRCode(clsPipeOperator, bReset, bCloneIfNeeded:=True)

        ucrChkStub.SetRCode(clsPipeOperator, bReset, bCloneIfNeeded:=True)
        ucrChkStubFootnote.SetRCode(clsPipeOperator, bReset, bCloneIfNeeded:=True)

        ucrChkSubtitleFootnote.SetRCode(clsPipeOperator, bReset, bCloneIfNeeded:=True)

        ucrInputTitle.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSubtitle.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)

        ucrInputTitleFootnote.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSubtitleFootnote.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrPnlThemesPanel.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)

        ucrInputStub.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputStubFootnote.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)

        bRCodeSet = True
    End Sub

    Private Sub ucrChkAddTitleSubtitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeTitles.ControlValueChanged
        AddTableTitle()
        AddFootnote()
    End Sub

    Private Sub AddTableTitle()
        If ucrChkIncludeTitles.Checked AndAlso Not ucrInputTitle.IsEmpty Then
            cmdTitleFont.Visible = True
        Else
            cmdTitleFont.Visible = False
        End If
        If ucrChkIncludeTitles.Checked AndAlso Not ucrInputTitleFootnote.IsEmpty Then
            cmdTitleFormat.Visible = True
        Else
            cmdTitleFormat.Visible = False
        End If
    End Sub

    Private Sub AddSubtitle()
        If ucrChkIncludeTitles.Checked AndAlso Not ucrInputSubtitle.IsEmpty Then
            cmdSubtitleFont.Visible = True
        Else
            cmdSubtitleFont.Visible = False
        End If
        If ucrChkIncludeTitles.Checked AndAlso Not ucrInputStubFootnote.IsEmpty Then
            cmdSubtitleFormat.Visible = True
        Else
            cmdSubtitleFormat.Visible = False
        End If
    End Sub

    Private Sub AddStub()
        If ucrChkStub.Checked AndAlso Not ucrInputStub.IsEmpty Then
            clsPipeOperator.AddParameter("title_stub", clsRFunctionParameter:=clsStubFunction, iPosition:=1)
            cmdStubFont.Visible = True
        Else
            cmdStubFont.Visible = False
            clsPipeOperator.RemoveParameterByName("title_stub")
        End If
    End Sub

    Private Sub AddStubFootnote()
        If Not bRCodeSet Then
            Exit Sub
        End If
        If ucrChkStub.Checked Then
            If ucrChkStubFootnote.Checked AndAlso Not ucrInputStubFootnote.IsEmpty Then
                cmdStubFormat.Visible = True
                clsPipeOperator.AddParameter("title_stub_footnote", clsRFunctionParameter:=clsStubFootnoteFunction, iPosition:=1)
            Else
                cmdStubFormat.Visible = False
            End If
        Else
            clsPipeOperator.RemoveParameterByName("title_stub_footnote")
        End If
        AddRemoveOperatorStub()
    End Sub

    Private Sub ucrInputTitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTitle.ControlValueChanged
        AddTableTitle()
        If ucrChkIncludeTitles.Checked Then
            If Not ucrInputTitle.IsEmpty Then
                clsTableTitleFunction.AddParameter("title", Chr(34) & ucrInputTitle.GetText() & Chr(34), iPosition:=0)
            Else
                clsTableTitleFunction.RemoveParameterByName("title")
            End If
        End If
    End Sub

    Private Sub ucrInputSubtitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSubtitle.ControlValueChanged
        AddTableTitle()
        If ucrChkIncludeTitles.Checked Then
            If Not ucrInputSubtitle.IsEmpty Then
                clsTableTitleFunction.AddParameter("subtitle", Chr(34) & ucrInputSubtitle.GetText() & Chr(34), iPosition:=1)
            Else
                clsTableTitleFunction.RemoveParameterByName("subtitle")
            End If
        End If
    End Sub

    Private Sub AddFootnote()
        If Not bRCodeSet Then
            Exit Sub
        End If
        If ucrChkIncludeTitles.Checked Then
            If ucrChkTitleFootnote.Checked AndAlso Not ucrInputTitleFootnote.IsEmpty Then
                clsPipeOperator.AddParameter("title_footnote", clsRFunctionParameter:=clsTabFootnoteTitleFunction, iPosition:=2)
            End If
            If ucrChkSubtitleFootnote.Checked AndAlso Not ucrInputSubtitleFootnote.IsEmpty Then
                clsPipeOperator.AddParameter("subtitle_footnote", clsRFunctionParameter:=clsTabFootnoteSubtitleFunction, iPosition:=2)
            End If
        Else
            clsPipeOperator.RemoveParameterByName("title_footnote")
            clsPipeOperator.RemoveParameterByName("subtitle_footnote")
        End If
    End Sub

    Private Sub cmdManualTheme_Click(sender As Object, e As EventArgs) Handles cmdManualTheme.Click
        sdgSummaryThemes.SetRCode(bReset:=bResetThemes, clsNewThemesTabOption:=clsThemesTabOptionsFunction)
        Me.SendToBack()
        sdgSummaryThemes.ShowDialog()
        bResetThemes = False
    End Sub

    Private Sub ucrChkTitleFootnote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTitleFootnote.ControlValueChanged
        If ucrChkTitleFootnote.Checked Then
            clsTabFootnoteTitleFunction.AddParameter("locations", clsRFunctionParameter:=clsFootnoteTitleLocationFunction, iPosition:=2)
            clsFootnoteTitleLocationFunction.AddParameter("groups", Chr(34) & "title" & Chr(34), iPosition:=0)
        Else
            clsFootnoteTitleLocationFunction.RemoveParameterByName("groups")
            clsTabFootnoteTitleFunction.RemoveParameterByName("locations")
        End If
        AddFootnote()
    End Sub

    Private Sub ucrInputTitleFootnote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTitleFootnote.ControlValueChanged
        If ucrChkIncludeTitles.Checked Then
            If Not ucrInputTitleFootnote.IsEmpty Then
                clsTabFootnoteTitleFunction.AddParameter("footnote", Chr(34) & ucrInputTitleFootnote.GetText() & Chr(34), iPosition:=1)
            Else
                clsTabFootnoteTitleFunction.RemoveParameterByName("footnote")
            End If
        End If
        AddFootnote()
    End Sub

    Private Sub ucrInputSubtitleFootnote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSubtitleFootnote.ControlValueChanged
        If ucrChkIncludeTitles.Checked Then
            If Not ucrInputSubtitleFootnote.IsEmpty Then
                clsTabFootnoteSubtitleFunction.AddParameter("footnote", Chr(34) & ucrInputSubtitleFootnote.GetText & Chr(34), iPosition:=1)
            Else
                clsTabFootnoteSubtitleFunction.RemoveParameterByName("footnote")
            End If
        End If
        AddFootnote()
    End Sub

    Private Sub PipeOperator_controlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeTitles.ControlContentsChanged,
            ucrInputTitle.ControlContentsChanged, ucrInputTitleFootnote.ControlContentsChanged, ucrInputSubtitleFootnote.ControlContentsChanged,
            ucrInputSubtitle.ControlContentsChanged, ucrChkSubtitleFootnote.ControlContentsChanged, ucrChkTitleFootnote.ControlContentsChanged
        If ucrChkIncludeTitles.Checked Then
            If Not ucrInputTitle.IsEmpty AndAlso Not ucrInputSubtitle.IsEmpty Then
                clsJoiningOperator.AddParameter("pipe", clsROperatorParameter:=clsPipeOperator, iPosition:=1)
            Else
                clsJoiningOperator.RemoveParameterByName("pipe")
            End If
            If ucrChkTitleFootnote.Checked AndAlso ucrChkIncludeTitles.Checked Then
                If Not ucrInputTitleFootnote.IsEmpty Then
                    clsJoiningOperator.AddParameter("pipe", clsROperatorParameter:=clsPipeOperator, iPosition:=1)
                Else
                    clsJoiningOperator.RemoveParameterByName("pipe")
                End If
                If ucrChkSubtitleFootnote.Checked AndAlso ucrChkIncludeTitles.Checked Then
                    clsJoiningOperator.AddParameter("pipe", clsROperatorParameter:=clsPipeOperator, iPosition:=1)
                Else
                    clsJoiningOperator.RemoveParameterByName("pipe")
                End If
            End If
        End If
    End Sub

    Private Sub AddRemoveOperatorStub()
        If ucrChkStub.Checked Then
            If ucrInputStub.IsEmpty Then
                clsJoiningOperator.RemoveParameterByName("pipe")
            Else
                clsJoiningOperator.AddParameter("pipe", clsROperatorParameter:=clsPipeOperator, iPosition:=1)
            End If
            If ucrChkStubFootnote.Checked AndAlso Not ucrInputStubFootnote.IsEmpty Then
                clsJoiningOperator.AddParameter("pipe", clsROperatorParameter:=clsPipeOperator, iPosition:=1)
            Else
                clsJoiningOperator.RemoveParameterByName("pipe")
            End If
        Else
            clsPipeOperator.RemoveParameterByName("title_stub_footnote")
        End If

    End Sub

    Private Sub ucrThemesPanel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlThemesPanel.ControlValueChanged,
        ucrInputSelectThemes.ControlValueChanged
        If rdoManualTheme.Checked Then
            clsDummyFunction.AddParameter("theme", "manual", iPosition:=11)
            ucrInputSelectThemes.Visible = False
            clsJoiningOperator.AddParameter("theme_format", clsRFunctionParameter:=clsThemesTabOptionsFunction, iPosition:=6)
        Else
            cmdManualTheme.Visible = False
            clsDummyFunction.AddParameter("theme", "select", iPosition:=11)
            clsJoiningOperator.AddParameter("theme_format", clsRFunctionParameter:=clsgtExtrasThemesFunction, iPosition:=6)
            Select Case ucrInputSelectThemes.GetText
                Case "Dark Theme"
                    clsgtExtrasThemesFunction.SetRCommand("gt_theme_dark")
                Case "538 Theme"
                    clsgtExtrasThemesFunction.SetRCommand("gt_theme_538")
                Case "Dot Matrix Theme"
                    clsgtExtrasThemesFunction.SetRCommand("gt_theme_dot_matrix")
                Case "Espn Theme"
                    clsgtExtrasThemesFunction.SetRCommand("gt_theme_espn")
                Case "Excel Theme"
                    clsgtExtrasThemesFunction.SetRCommand("gt_theme_excel")
                Case "Guardian Theme"
                    clsgtExtrasThemesFunction.SetRCommand("gt_theme_guardian")
                Case "NY Times Theme"
                    clsgtExtrasThemesFunction.SetRCommand("gt_theme_nytimes")
                Case "PFF Theme"
                    clsgtExtrasThemesFunction.SetRCommand("gt_theme_pff")
            End Select
        End If
        AddRemoveManualTheme()
    End Sub

    Private Sub AddRemoveManualTheme()
        cmdManualTheme.Visible = rdoManualTheme.Checked
    End Sub

    Private Sub ucrInputStubs_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputStub.ControlValueChanged
        If ucrChkStub.Visible Then
            If Not ucrInputStub.IsEmpty Then
                clsStubFunction.AddParameter("label", Chr(34) & ucrInputStub.GetText() & Chr(34), iPosition:=0)
            Else
                clsStubFunction.RemoveParameterByName("label")
            End If
        End If
        AddStub()
    End Sub

    Private Sub ucrInputStubsFootNote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputStubFootnote.ControlValueChanged
        If ucrChkStub.Checked Then
            If Not ucrInputStubFootnote.IsEmpty Then
                clsStubFootnoteFunction.AddParameter("footnote", Chr(34) & ucrInputStubFootnote.GetText() & Chr(34), iPosition:=0)
            Else
                clsStubFootnoteFunction.RemoveParameterByName("footnote")
            End If
        End If
        AddStubFootnote()
        AddRemoveOperatorStub()
    End Sub

    Private Sub ucrChkFootNote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkStubFootnote.ControlValueChanged
        If ucrChkStubFootnote.Checked Then
            clsStubFootnoteFunction.AddParameter("locations", clsRFunctionParameter:=clsStubCellsFunction, iPosition:=1)
        Else
            clsStubFootnoteFunction.RemoveParameterByName("locations")
        End If
        AddStubFootnote()
    End Sub

    Private Sub ucrChkStubs_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkStub.ControlValueChanged
        AddStub()
        AddRemoveOperatorStub()
    End Sub
End Class