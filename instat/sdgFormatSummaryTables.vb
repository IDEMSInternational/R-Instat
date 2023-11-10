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

Public Class sdgFormatSummaryTables
    Private clsTableTitleFunction, clsTabFootnoteTitleFunction, clsTableSourcenoteFunction, clsFootnoteCellFunction,
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
        ucrChkTitleFootnote.SetLinkedDisplayControl(grpTitleSubtitle)

        ucrChkTitleFootnote.AddParameterPresentCondition(True, "title_footnote")
        ucrChkTitleFootnote.AddParameterPresentCondition(False, "title_footnote", False)

        ucrInputSubtitleFootnote.SetParameter(New RParameter("subtitle_footnote", iNewPosition:=3))

        ucrChkSubtitleFootnote.SetText("Add subtitle footnote")
        ucrChkSubtitleFootnote.AddToLinkedControls(ucrInputSubtitleFootnote, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkSubtitleFootnote.AddParameterPresentCondition(True, "subtitle_footnote")
        ucrChkSubtitleFootnote.AddParameterPresentCondition(False, "subtitle_footnote", False)

        ucrInputTitleFont.SetParameter(New RParameter("font", iNewPosition:=0))
        ucrInputTitleFont.SetRDefault("NULL")
        ucrInputTitleFont.SetLinkedDisplayControl(lblTitleFont)

        ucrNudTitleSize.SetParameter(New RParameter("size", iNewPosition:=0, bNewIncludeArgumentName:=False))
        ucrNudTitleSize.Increment = 1
        ucrNudTitleSize.SetMinMax(1)
        ucrNudTitleSize.SetLinkedDisplayControl(lblTitleSize)

        ucrChkAddTitleSubtitle.SetText("Add title/subtitle")
        ucrChkAddTitleSubtitle.AddToLinkedControls({ucrInputTitle, ucrInputSubtitle, ucrChkTitleFootnote, ucrChkSubtitleFootnote, ucrInputTitleFont, ucrNudTitleSize}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddTitleSubtitle.AddParameterPresentCondition(True, "title_subtitle")
        ucrChkAddTitleSubtitle.AddParameterPresentCondition(False, "title_subtitle", False)

        ucrInputFootnoteColumnLocation.SetParameter(New RParameter("col_location", 5))
        ucrInputFootnoteColumnLocation.SetValidationTypeAsNumericList()

        ucrInputFootnoteRowLocation.SetParameter(New RParameter("row_location", iNewPosition:=6))
        ucrInputFootnoteRowLocation.SetValidationTypeAsNumericList()
        ucrInputFootnoteRowLocation.SetLinkedDisplayControl(grpLocation)

        ucrInputCellFootnote.SetParameter(New RParameter("cell_footnote", iNewPosition:=4))
        ucrInputCellFootnote.SetLinkedDisplayControl(lblFootnote)

        ucrChkAddFootnote.SetText("Add footnote")
        ucrChkAddFootnote.AddToLinkedControls({ucrInputCellFootnote, ucrInputFootnoteColumnLocation, ucrInputFootnoteRowLocation}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddFootnote.AddParameterPresentCondition(True, "cell_footnote")
        ucrChkAddFootnote.AddParameterPresentCondition(False, "cell_footnote", False)

        ucrChKAddSecondFootnote.SetText("Add second footnote")
        ucrChKAddSecondFootnote.AddToLinkedControls({ucrInputSecondCellFootnote, ucrInputSecondFootnoteColumnLocation, ucrInputSecondFootnoteRowLocation}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputSecondFootnoteRowLocation.SetParameter(New RParameter("second_row_location", iNewPosition:=7))
        ucrInputSecondFootnoteRowLocation.SetValidationTypeAsNumericList()

        ucrInputSecondFootnoteColumnLocation.SetParameter(New RParameter("second_col_location", iNewPosition:=6))
        ucrInputSecondFootnoteColumnLocation.SetValidationTypeAsNumericList()

        ucrInputSecondCellFootnote.SetParameter(New RParameter("second_footnote", iNewPosition:=4))
        ucrInputSecondCellFootnote.SetLinkedDisplayControl(lblSecondFootnote)

        ucrInputSecondFootnoteColumnLocation.SetLinkedDisplayControl(grpSecondFootnote)

        ucrChKAddSecondFootnote.AddParameterPresentCondition(True, "second_cellfootnote")
        ucrChKAddSecondFootnote.AddParameterPresentCondition(False, "second_cellfootnote", False)

        ucrInputAddSourceNote.SetParameter(New RParameter("source_note", iNewPosition:=8))

        ucrChkAddSourcenote.SetText("Add source")
        ucrChkAddSourcenote.AddToLinkedControls(ucrInputAddSourceNote, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddSourcenote.AddParameterPresentCondition(True, "source_note")
        ucrChkAddSourcenote.AddParameterPresentCondition(False, "source_note", False)

        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(bReset As Boolean, clsNewTableTitleFunction As RFunction, clsNewTabFootnoteTitleFunction As RFunction, clsNewFootnoteCellFunction As RFunction,
                        clsNewTableSourcenoteFunction As RFunction, clsNewTabStyleFunction As RFunction, clsNewMutableOperator As ROperator,
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
        clsTabFootnoteTitleFunction = clsNewTabFootnoteTitleFunction
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

        ucrChkAddTitleSubtitle.SetRCode(clsPipeOperator, bReset, bCloneIfNeeded:=True)
        ucrChkTitleFootnote.SetRCode(clsPipeOperator, bReset, bCloneIfNeeded:=True)
        ucrChkAddFootnote.SetRCode(clsPipeOperator, bReset, bCloneIfNeeded:=True)
        ucrChKAddSecondFootnote.SetRCode(clsPipeOperator, bReset, bCloneIfNeeded:=True)
        ucrChkSubtitleFootnote.SetRCode(clsPipeOperator, bReset, bCloneIfNeeded:=True)
        ucrChkAddSourcenote.SetRCode(clsPipeOperator, bReset, bCloneIfNeeded:=True)
        ucrInputTitleFont.SetRCode(clsTabStyleCellTextFunction, bReset, bCloneIfNeeded:=True)
        ucrNudTitleSize.SetRCode(clsTabStylePxFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTitle.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSubtitle.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputCellFootnote.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSecondCellFootnote.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputFootnoteColumnLocation.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputFootnoteRowLocation.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSecondFootnoteColumnLocation.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSecondFootnoteRowLocation.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputAddSourceNote.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTitleFootnote.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSubtitleFootnote.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrPnlThemesPanel.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)

        bRCodeSet = True
    End Sub

    Private Sub ucrChkAddTitleSubtitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddTitleSubtitle.ControlValueChanged
        AddTableTitle()
        AddFootnote()
    End Sub

    Private Sub AddTableTitle()
        If ucrChkAddTitleSubtitle.Checked AndAlso (Not ucrInputTitle.IsEmpty OrElse Not ucrInputSubtitle.IsEmpty) Then
            clsPipeOperator.AddParameter("title_subtitle", clsRFunctionParameter:=clsTableTitleFunction, iPosition:=1)
            clsPipeOperator.AddParameter("title_font", clsRFunctionParameter:=clsTabStyleFunction, iPosition:=5)
        Else
            clsPipeOperator.RemoveParameterByName("title_subtitle")
            clsPipeOperator.RemoveParameterByName("title_font")
        End If
    End Sub

    Private Sub ucrInputTitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTitle.ControlValueChanged
        AddTableTitle()
        If Not ucrInputTitle.IsEmpty Then
            clsTableTitleFunction.AddParameter("title", Chr(34) & ucrInputTitle.GetText() & Chr(34), iPosition:=0)
        Else
            clsTableTitleFunction.RemoveParameterByName("title")
        End If
    End Sub

    Private Sub ucrInputSubtitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSubtitle.ControlValueChanged
        AddTableTitle()
        If Not ucrInputSubtitle.IsEmpty Then
            clsTableTitleFunction.AddParameter("subtitle", Chr(34) & ucrInputSubtitle.GetText() & Chr(34), iPosition:=1)
        Else
            clsTableTitleFunction.RemoveParameterByName("subtitle")
        End If
    End Sub

    Private Sub AddFootnote()
        If Not bRCodeSet Then
            Exit Sub
        End If
        If ucrChkTitleFootnote.Checked AndAlso Not ucrInputTitleFootnote.IsEmpty Then
            clsPipeOperator.AddParameter("title_footnote", clsRFunctionParameter:=clsTabFootnoteTitleFunction, iPosition:=1)
        Else
            clsPipeOperator.RemoveParameterByName("title_footnote")
        End If

        If ucrChkSubtitleFootnote.Checked AndAlso Not ucrInputSubtitleFootnote.IsEmpty Then
            clsPipeOperator.AddParameter("subtitle_footnote", clsRFunctionParameter:=clsTabFootnoteSubtitleFunction, iPosition:=2)
        Else
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

    Private Sub ucrChkSubtitleFootnote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSubtitleFootnote.ControlValueChanged
        If ucrChkSubtitleFootnote.Checked Then
            clsTabFootnoteSubtitleFunction.AddParameter("locations", clsRFunctionParameter:=clsFootnoteSubtitleLocationFunction, iPosition:=2)
            clsFootnoteSubtitleLocationFunction.AddParameter("groups", Chr(34) & "subtitle" & Chr(34), iPosition:=0)
        Else
            clsFootnoteSubtitleLocationFunction.RemoveParameterByName("groups")
            clsTabFootnoteSubtitleFunction.RemoveParameterByName("locations")
        End If
        AddFootnote()
    End Sub

    Private Sub ucrInputTitleFootnote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTitleFootnote.ControlValueChanged
        If Not ucrInputTitleFootnote.IsEmpty Then
            clsTabFootnoteTitleFunction.AddParameter("footnote", Chr(34) & ucrInputTitleFootnote.GetText() & Chr(34), iPosition:=1)
        Else
            clsTabFootnoteTitleFunction.RemoveParameterByName("footnote")
        End If
        AddFootnote()
    End Sub

    Private Sub ucrInputSubtitleFootnote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSubtitleFootnote.ControlValueChanged
        If Not ucrInputSubtitleFootnote.IsEmpty Then
            clsTabFootnoteSubtitleFunction.AddParameter("footnote", Chr(34) & ucrInputSubtitleFootnote.GetText & Chr(34), iPosition:=1)
        Else
            clsTabFootnoteSubtitleFunction.RemoveParameterByName("footnote")
        End If
        AddFootnote()
    End Sub

    Private Sub ucrInputAddSourceNote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputAddSourceNote.ControlValueChanged
        AddRemoveSourceNoteParameter()
        AddSourceNote()
    End Sub

    Private Sub PipeOperator_controlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkAddTitleSubtitle.ControlContentsChanged,
            ucrChkAddFootnote.ControlContentsChanged, ucrChKAddSecondFootnote.ControlContentsChanged, ucrChkAddSourcenote.ControlContentsChanged,
            ucrInputTitle.ControlContentsChanged, ucrInputSubtitle.ControlContentsChanged, ucrInputTitleFootnote.ControlContentsChanged,
            ucrInputSubtitleFootnote.ControlContentsChanged, ucrInputAddSourceNote.ControlContentsChanged,
            ucrInputCellFootnote.ControlContentsChanged, ucrInputSecondCellFootnote.ControlContentsChanged

        If ucrChkAddTitleSubtitle.Checked OrElse ucrChkAddFootnote.Checked OrElse ucrChKAddSecondFootnote.Checked OrElse ucrChkAddSourcenote.Checked OrElse
            ucrChKAddSecondFootnote.Checked Then
            If ucrInputTitle.IsEmpty AndAlso ucrInputSubtitle.IsEmpty AndAlso ucrInputTitleFootnote.IsEmpty AndAlso
                ucrInputSubtitleFootnote.IsEmpty AndAlso ucrInputAddSourceNote.IsEmpty AndAlso ucrInputCellFootnote.IsEmpty AndAlso ucrInputSecondCellFootnote.IsEmpty Then
                clsJoiningOperator.RemoveParameterByName("pipe")
            Else
                clsJoiningOperator.AddParameter("pipe", clsROperatorParameter:=clsPipeOperator, iPosition:=1)
            End If
        Else
            clsJoiningOperator.RemoveParameterByName("pipe")
        End If
    End Sub

    Private Sub AddCellFootnote()
        If Not bRCodeSet Then
            Exit Sub
        End If
        If ucrChkAddFootnote.Checked AndAlso Not ucrInputCellFootnote.IsEmpty Then
            clsPipeOperator.AddParameter("cell_footnote", clsRFunctionParameter:=clsFootnoteCellFunction, iPosition:=3)
        Else
            clsPipeOperator.RemoveParameterByName("cell_footnote")
        End If

        If ucrChKAddSecondFootnote.Checked AndAlso Not ucrInputSecondCellFootnote.IsEmpty Then
            clsPipeOperator.AddParameter("second_cellfootnote", clsRFunctionParameter:=clsSecondFootnoteCellFunction, iPosition:=3)
        Else
            clsPipeOperator.RemoveParameterByName("second_cellfootnote")
        End If
    End Sub

    Private Sub AddFootnote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddFootnote.ControlValueChanged, ucrChKAddSecondFootnote.ControlValueChanged
        If ucrChkAddFootnote.Checked Then
            clsFootnoteCellFunction.AddParameter("locations", clsRFunctionParameter:=clsFootnoteCellBodyFunction, iPosition:=3)
        Else
            clsFootnoteCellFunction.RemoveParameterByName("locations")
        End If

        If ucrChKAddSecondFootnote.Checked Then
            clsSecondFootnoteCellFunction.AddParameter("locations", clsRFunctionParameter:=clsSecondFootnoteCellBodyFunction, iPosition:=3)
        Else
            clsSecondFootnoteCellFunction.RemoveParameterByName("locations")
        End If
        AddRemoveFootnote()
        AddCellFootnote()
    End Sub

    Private Sub ColumnLocation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputFootnoteColumnLocation.ControlValueChanged, ucrInputSecondFootnoteColumnLocation.ControlValueChanged
        If Not ucrInputFootnoteColumnLocation.IsEmpty Then
            clsFootnoteCellBodyFunction.AddParameter("columns", clsRFunctionParameter:=ucrInputFootnoteColumnLocation.clsRList, iPosition:=0)
        Else
            clsFootnoteCellBodyFunction.AddParameter("columns", "everything()", iPosition:=0)
        End If

        If Not ucrInputSecondFootnoteColumnLocation.IsEmpty Then
            clsSecondFootnoteCellBodyFunction.AddParameter("columns", clsRFunctionParameter:=ucrInputSecondFootnoteColumnLocation.clsRList, iPosition:=0)
        Else
            clsSecondFootnoteCellBodyFunction.AddParameter("columns", "everything()", iPosition:=0)
        End If
    End Sub

    Private Sub RowLocation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputFootnoteRowLocation.ControlValueChanged, ucrInputSecondFootnoteRowLocation.ControlValueChanged
        If Not ucrInputFootnoteRowLocation.IsEmpty Then
            clsFootnoteCellBodyFunction.AddParameter("rows", clsRFunctionParameter:=ucrInputFootnoteRowLocation.clsRList, iPosition:=1)
        Else
            clsFootnoteCellBodyFunction.AddParameter("rows", "everything()", iPosition:=1)
        End If

        If Not ucrInputSecondFootnoteRowLocation.IsEmpty Then
            clsSecondFootnoteCellBodyFunction.AddParameter("rows", clsRFunctionParameter:=ucrInputSecondFootnoteRowLocation.clsRList, iPosition:=1)
        Else
            clsSecondFootnoteCellBodyFunction.AddParameter("rows", "everything()", iPosition:=1)
        End If
    End Sub

    Private Sub Footnote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputCellFootnote.ControlValueChanged, ucrInputSecondCellFootnote.ControlValueChanged
        AddRemoveFootnote()
        AddCellFootnote()
    End Sub

    Private Sub AddRemoveFootnote()
        If Not ucrInputCellFootnote.IsEmpty Then
            clsFootnoteCellFunction.AddParameter("footnote", Chr(34) & ucrInputCellFootnote.GetText() & Chr(34), iPosition:=2)
        Else
            clsFootnoteCellFunction.RemoveParameterByName("footnote")
        End If

        If Not ucrInputSecondCellFootnote.IsEmpty Then
            clsSecondFootnoteCellFunction.AddParameter("footnote", Chr(34) & ucrInputSecondCellFootnote.GetText() & Chr(34), iPosition:=2)
        Else
            clsSecondFootnoteCellFunction.RemoveParameterByName("footnote")
        End If
    End Sub

    Private Sub AddSourceNote()
        If ucrChkAddSourcenote.Checked AndAlso Not ucrInputAddSourceNote.IsEmpty Then
            clsPipeOperator.AddParameter("source_note", iPosition:=4, clsRFunctionParameter:=clsTableSourcenoteFunction)
        Else
            clsPipeOperator.RemoveParameterByName("source_note")
        End If
    End Sub

    Private Sub ucrChkAddSourcenote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddSourcenote.ControlValueChanged
        AddSourceNote()
        AddRemoveSourceNoteParameter()
    End Sub

    Private Sub AddRemoveSourceNoteParameter()
        If Not ucrInputAddSourceNote.IsEmpty Then
            clsTableSourcenoteFunction.AddParameter("source_note", Chr(34) & ucrInputAddSourceNote.GetText() & Chr(34), iPosition:=1)
        Else
            clsTableSourcenoteFunction.RemoveParameterByName("source_note")
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

    Private Sub tbpFormatOptions_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tbpFormatOptions.Selecting
        If e.TabPageIndex = 1 Or e.TabPageIndex = 2 Or e.TabPageIndex = 3 Then
            e.Cancel = True
        End If
    End Sub
End Class