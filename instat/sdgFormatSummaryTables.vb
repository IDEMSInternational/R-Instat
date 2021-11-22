Imports instat.Translations
Public Class sdgFormatSummaryTables
    Private clsTableTitleFunction, clsTabFootnoteFunction, clsTableSourcenoteFunction, clsCellTilteFunction,
        clsCellTextFunction, clsCellBorderFunction, clsCellFillFunction, clsCellHeaderFormatFunction,
        clsTabOptionsFunction As New RFunction

    Private Sub sdgFormatSummaryTables_load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        'Titles
        ucrInputTitle.SetLinkedDisplayControl(lblTitle)
        ucrInputSubtitle.SetLinkedDisplayControl(lblSubtitle)

        ucrChkTitleFootnote.SetText("Add title footnote")
        ucrChkTitleFootnote.AddToLinkedControls(ucrInputTitleFootnote, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkSubtitleFootnote.SetText("Add subtitle footnote")
        ucrChkSubtitleFootnote.AddToLinkedControls(ucrInputSubtitleFootnote, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddTitleSubtitle.SetText("Add title/subtitle")
        ucrChkAddTitleSubtitle.AddToLinkedControls({ucrInputTitle, ucrInputSubtitle, ucrChkTitleFootnote, ucrChkSubtitleFootnote}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAddTitleSubtitle.SetLinkedDisplayControl(grpTitleSubtitle)

        ucrInputFootnoteColumnLocation.SetLinkedDisplayControl(lblColumns)
        ucrInputFootnoteRowLocation.SetLinkedDisplayControl(lblRows)

        ucrChkAddFootnote.SetText("Add footnote")
        ucrChkAddFootnote.SetLinkedDisplayControl(grpLocation)
        ucrChkAddFootnote.AddToLinkedControls({ucrInputFootnoteColumnLocation, ucrInputFootnoteRowLocation}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddSourcenote.SetText("Add sourcenote")
        ucrChkAddSourcenote.AddToLinkedControls(ucrInputAddSourceNote, {True}, bNewLinkedHideIfParameterMissing:=True)

        'Header
        ucrPnlHeader.SetLinkedDisplayControl(lblHeader)
        ucrPnlHeader.AddRadioButton(rdoAllColumns)
        ucrPnlHeader.AddRadioButton(rdoAllRows)



    End Sub

    Public Sub SetRCode()

    End Sub

End Class