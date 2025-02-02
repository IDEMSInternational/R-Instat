Imports instat.Translations

Public Class dlgGeneralTable
    '    Public Event HeaderUpdated()

    Private clsBaseOperator As New ROperator
    Private clsHeadRFunction, clsTitleLocationRFunction, clsTitleFooterRFunction, clsHeaderRFunction, clsGtRFunction, clsThemeRFunction As New RFunction

    Private bFirstload As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgGeneralTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            initialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub


    'Public Sub UpdateHeader2()
    'Dim strTitle As String = sdgTableOptions.ucrHeader.GetTitle()
    'Dim strTitleFooter As String = sdgTableOptions.ucrHeader.GetTitleFooter()
    ' Update dlgGeneralTable UI or properties accordingly
    '   ucrInputTitle2.SetName(strTitle)
    '  ucrInputTitleFooter.SetName(strTitleFooter)

    ' Now send the updated information to ucrHeader (if applicable)

    'End Sub

    'Public Function GeneralGetTitle() As String
    'Return ucrInputTitle2.GetText()
    'End Function


    'Public Function GeneralGetTitleFooter() As String
    '    Return ucrInputTitleFooter.GetText()
    'End Function

    'Public Sub ucrInputControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputTitle2.ControlContentsChanged, ucrInputTitleFooter.ControlContentsChanged
    '    ucrInputTitleFooter.Enabled = Not ucrInputTitle2.IsEmpty()
    '    'ucrInputSubtitle.Enabled = Not ucrInputTitle.IsEmpty()
    '    'ucrInputSubtitleFooter.Enabled = ucrInputSubtitle.Enabled AndAlso Not ucrInputSubtitle.IsEmpty()

    '    ' Raise specific events with the new values
    '    'RaiseEvent TitleChanged(ucrInputTitle.GetText())
    '    'RaiseEvent TitleFooterChanged(ucrInputTitleFooter.GetText())

    '    RaiseEvent HeaderUpdated() ' Notify dlgGeneralTable when values change
    'End Sub

    ''Public Function GetSubtitleFooter() As String
    ''    Return ucrInputSubtitleFooter.GetText()
    ''End Function


    ''Public Sub UpdateHeader()
    ''    Dim strTitle As String = sdgTableOptions.ucrHeader.GetTitle()
    ''    Dim strTitleFooter As String = sdgTableOptions.ucrHeader.GetTitleFooter()

    ''    ' Update dlgGeneralTable UI or properties accordingly
    ''    ucrInputTitle.SetName(strTitle)
    ''    ucrInputTitleFooter.SetName(strTitleFooter)

    ''    ' Now send the updated information to ucrHeader (if applicable)
    ''    'sdgTableOptions.ucrHeader.GetTitle(strTitle) ' Ensure ucrHeader has a method for this
    ''    'sdgTableOptions.ucrHeader.GetTitleFooter(strTitleFooter) ' Ensure ucrHeader has a method for this
    ''End Sub



    ''    ucrInputTitle.SetName(strTitle)
    ''    ucrInputTitleFooter.SetName(strTitleFooter)

    ''    sdgTableOptions.ucrHeader.SetTitle(strTitle, False) 'Do not raise event
    ''    sdgTableOptions.ucrHeader.SetTitleFooter(strTitleFooter, False) 'Do not raise event
    ''End Sub


    Private Sub btnMoreOptions_Click(sender As Object, e As EventArgs) Handles btnMoreOptions.Click
        sdgTableOptions.Setup(ucrSelectorCols.strCurrentDataFrame, clsBaseOperator)
        sdgTableOptions.ShowDialog(Me)
    End Sub

    Private Sub ucrControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleCols.ControlContentsChanged
            TestOKEnabled()
        End Sub

        Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
            SetDefaults()
            SetRCodeForControls(True)
            TestOKEnabled()
        End Sub

        Private Sub initialiseDialog()
            ucrBase.iHelpTopicID = 419

            ucrReceiverMultipleCols.SetParameter(New RParameter("df_columns_to_use_param", 0, bNewIncludeArgumentName:=False))
            ucrReceiverMultipleCols.SetParameterIsRFunction()
            ucrReceiverMultipleCols.Selector = ucrSelectorCols
            ucrReceiverMultipleCols.SetLinkedDisplayControl(lblColumns)

            ucrChkPreview.SetText("Preview")
            ucrChkPreview.AddParameterPresentCondition(True, "head", bNewIsPositive:=True)
            ucrChkPreview.AddParameterPresentCondition(False, "head", bNewIsPositive:=False)
            ucrChkPreview.AddToLinkedControls(ucrNudPreview, {True}, bNewLinkedHideIfParameterMissing:=True)

            ucrNudPreview.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
            ucrNudPreview.Minimum = 6
            ucrNudPreview.Maximum = Decimal.MaxValue
            ucrNudPreview.SetRDefault(6)

            ucrSaveTable.SetPrefix("presentation_table")
            ucrSaveTable.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
            ucrSaveTable.SetDataFrameSelector(ucrSelectorCols.ucrAvailableDataFrames)
            ucrSaveTable.SetIsComboBox()
            ucrSaveTable.SetCheckBoxText("Store Table")
            ucrSaveTable.SetAssignToIfUncheckedValue("last_table")

            ucrChkSelectTheme.Checked = True
            ucrChkSelectTheme.SetText("Select Theme")
            ucrCboSelectThemes.SetItems({"None", "Dark Theme", "538 Theme", "Dot Matrix Theme", "Espn Theme", "Excel Theme", "Guardian Theme", "NY Times Theme", "PFF Theme"})
            ucrCboSelectThemes.SetDropDownStyleAsNonEditable()

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
    End Sub


    Private Sub SetDefaults()
            clsBaseOperator = New ROperator
            ' clsOperator = New ROperator
            clsHeadRFunction = New RFunction
            clsGtRFunction = New RFunction
        ' UpdateHeader2()
        ' Setup()

        ucrSelectorCols.Reset()
            ucrReceiverMultipleCols.SetMeAsReceiver()
            ucrSaveTable.Reset()
            ucrChkPreview.Checked = True

            clsBaseOperator.SetOperation("%>%")
            clsBaseOperator.bBrackets = False

            clsHeadRFunction.SetPackageName("utils")
            clsHeadRFunction.SetRCommand("head")
            clsHeadRFunction.AddParameter(strParameterName:="x", strParameterValue:=100, iPosition:=0, bIncludeArgumentName:=False)
            clsBaseOperator.AddParameter(strParameterName:="head", clsRFunctionParameter:=clsHeadRFunction, iPosition:=1, bIncludeArgumentName:=False)


            ' If clsTitleFooterRFunction Is Nothing Then
            '   clsTitleLocationRFunction = GetNewCellsTitleRFunction("title")
            '  clsTitleFooterRFunction = New RFunction

            'clsTitleFooterRFunction.SetPackageName("gt")
            '    clsTitleFooterRFunction.SetRCommand("tab_footnote")
            '    clsTitleFooterRFunction.AddParameter(strParameterName:="locations", clsRFunctionParameter:=clsTitleLocationRFunction, iPosition:=1)
            '    clsBaseOperator.AddParameter(strParameterName:="locations", clsRFunctionParameter:=clsTitleFooterRFunction, bIncludeArgumentName:=False, iPosition:=1)


            '  End If

            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
            '  End Sub

            'Private Function GetNewCellsTitleRFunction(strGroupParamValue As String)
            '    Dim clsCellsTitleRFunction As New RFunction
            '    clsCellsTitleRFunction.SetPackageName("gt")
            '    clsCellsTitleRFunction.SetRCommand("cells_title")
            '    clsCellsTitleRFunction.AddParameter(strParameterName:="groups", strParameterValue:=Chr(34) & strGroupParamValue & Chr(34), iPosition:=0)
            '    Return clsCellsTitleRFunction
            'End Function

            clsGtRFunction.SetPackageName("gt")
            clsGtRFunction.SetRCommand("gt")
            clsBaseOperator.AddParameter(strParameterName:="gt", clsRFunctionParameter:=clsGtRFunction, iPosition:=2, bIncludeArgumentName:=False)

            Dim strCommand As String = ""
            clsThemeRFunction.SetPackageName("gtExtras")
            clsThemeRFunction.SetRCommand(strCommand)
            clsBaseOperator.AddParameter("theme_format", clsRFunctionParameter:=clsThemeRFunction)

            clsHeaderRFunction.SetPackageName("gt")
            'clsHeaderRFunction.SetRCommand("tab_header")
            'clsBaseOperator.AddParameter("title", clsRFunctionParameter:=clsHeaderRFunction)


            'clsTitleFooterRFunction.SetPackageName("gt")
            'clsTitleFooterRFunction.SetRCommand("tab_footnote")
            'clsTitleFooterRFunction.AddParameter(strParameterName:="locations", clsRFunctionParameter:=clsTitleLocationRFunction, iPosition:=1)
            'clsBaseOperator.AddParameter(strParameterName:="locations", clsRFunctionParameter:=clsTitleFooterRFunction, bIncludeArgumentName:=False, iPosition:=1)


            clsBaseOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                                      strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                                      strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                                      strRDataFrameNameToAddObjectTo:=ucrSelectorCols.strCurrentDataFrame,
                                                      strObjectName:="last_table")

            'clsOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
            '                                          strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
            '                                          strRObjectFormatToAssignTo:=RObjectFormat.Html,
            '                                          strRDataFrameNameToAddObjectTo:=ucrSelectorCols.strCurrentDataFrame,
            '                                          strObjectName:="last_table")

            ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        End Sub

    '    Public Sub Setup()
    '    AddHandler sdgTableOptions.ucrHeader.HeaderUpdated, AddressOf UpdateHeader2
    'End Sub

    'Public Sub UpdateHeader()
    '    Dim strTitle As String = sdgTableOptions.ucrHeader.GetTitle()
    '    ' Dim strSubtitle As String = ucrHeader.GetSubtitle()
    '    Dim strTitleFooter As String = sdgTableOptions.ucrHeader.GetTitleFooter()
    '    '  Dim strSubtitleFooter As String = ucrHeader.GetSubtitleFooter()

    '    ' Update dlgGeneralTable UI or properties accordingly
    '    ucrInputTitle.SetName(strTitle)
    '    ' ucrInputTableSubtitle.SetName(strSubtitle)
    '    ucrInputTitleFooter.SetName(strTitleFooter)
    '    'ucrInputTableSubtitleFooter.SetName(strSubtitleFooter)
    'End Sub


    Private Sub SetRCodeForControls(bReset As Boolean)
            ucrReceiverMultipleCols.SetRCode(clsBaseOperator, bReset)
            ucrSaveTable.SetRCode(clsBaseOperator, bReset)

            ucrChkPreview.SetRCode(clsBaseOperator, bReset)
            ucrNudPreview.SetRCode(clsHeadRFunction, bReset)
        End Sub

        Private Sub SetupTheme() '(clsOperator As ROperator)
            If clsBaseOperator.ContainsParameter("theme_format") Then
                clsThemeRFunction = clsBaseOperator.GetParameter("theme_format").clsArgumentCodeStructure
            Else
                clsThemeRFunction = New RFunction
                clsThemeRFunction.SetPackageName("gtExtras")
            End If
        End Sub

        'Private Sub ucrChkSelectTheme_Load(sender As Object, e As EventArgs) Handles ucrChkSelectTheme.Load
        '    'sdgTableOptions.ShowDialog(Me)

        '    If ucrChkSelectTheme.Checked Then
        '        ucrCboSelectThemes.Visible = True
        '        sdgTableOptions.clsOperator.AddParameter("theme_format", clsRFunctionParameter:=clsThemeRFunction)
        '    Else
        '        '   sdgTableOptions.clsOperator.RemoveParameterByName("theme_format")
        '        '     ucrCboSelectThemes.Visible = False
        '        ' clsThemeRFunction.ClearParameters()
        '    End If
        'End Sub

        Private Sub TestOKEnabled()
            ucrBase.OKEnabled(Not ucrReceiverMultipleCols.IsEmpty AndAlso ucrSaveTable.IsComplete)
        End Sub

        Private Sub ucrChkPreview_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPreview.ControlValueChanged
            If ucrChkPreview.Checked Then
                clsBaseOperator.AddParameter(strParameterName:="head", clsRFunctionParameter:=clsHeadRFunction, iPosition:=1, bIncludeArgumentName:=False)
            Else
                clsBaseOperator.RemoveParameterByName("head")
            End If
        End Sub

        Private Sub ucrChkSelectTheme_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSelectTheme.ControlValueChanged
        If ucrChkSelectTheme.Checked Then
            UpdateThemeSelection(ucrChkSelectTheme.Checked)
            sdgTableOptions.ucrChkSelectTheme.Checked = True
            ucrCboSelectThemes.Visible = True
        Else
            ucrCboSelectThemes.Visible = False
            sdgTableOptions.ucrChkSelectTheme.Checked = False
        End If


    End Sub

    Public Sub ucrCboSelectThemes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCboSelectThemes.ControlValueChanged
        UpdateThemeRCommand(ucrCboSelectThemes.GetText)
    End Sub

        ' Shared method to handle enabling/disabling theme selection
        Public Sub UpdateThemeSelection(isChecked As Boolean)
            ucrCboSelectThemes.Visible = isChecked
            If isChecked Then
                clsBaseOperator.AddParameter("theme_format", clsRFunctionParameter:=clsThemeRFunction)
            Else
                clsBaseOperator.RemoveParameterByName("theme_format")
            End If
        ' Sync state with sub-dialog
        UpdateThemeSelectionState(isChecked)
    End Sub

    Public Sub UpdateThemeSelectionState(isChecked As Boolean)
        ucrChkSelectTheme.Checked = isChecked
        ucrCboSelectThemes.Visible = isChecked
    End Sub
    ' Shared method to handle theme command setting
    Public Sub UpdateThemeRCommand(selectedTheme As String)
            If clsThemeRFunction Is Nothing Then Exit Sub

            Dim strCommand As String = GetThemeRCommand(selectedTheme)
            If strCommand <> "" Then
                clsThemeRFunction.SetRCommand(strCommand)
            End If

            ' Sync selected theme with sub-dialog
            sdgTableOptions.UpdateSelectedTheme(selectedTheme)
        End Sub

    Public Sub UpdateSelectedTheme(selectedTheme As String)
        'If ucrCboSelectThemes.GetText = selectedTheme Then
        'sdgTableOptions.ucrCboSelectThemes2.SetText(selectedTheme)
        'End If

        ucrCboSelectThemes.SetText(selectedTheme)
    End Sub

    ' Shared logic for mapping themes to commands
    Private Function GetThemeRCommand(themeName As String) As String
            Select Case themeName
                Case "Dark Theme" : Return "gt_theme_dark"
                Case "538 Theme" : Return "gt_theme_538"
                Case "Dot Matrix Theme" : Return "gt_theme_dot_matrix"
                Case "Espn Theme" : Return "gt_theme_espn"
                Case "Excel Theme" : Return "gt_theme_excel"
                Case "Guardian Theme" : Return "gt_theme_guardian"
                Case "NY Times Theme" : Return "gt_theme_nytimes"
                Case "PFF Theme" : Return "gt_theme_pff"
                Case Else : Return ""
            End Select
        End Function

        'Private Sub ucrCboSelectThemes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCboSelectThemes.ControlValueChanged

        '    If clsThemeRFunction Is Nothing Then
        '        Exit Sub
        '    End If

        '    Dim strCommand As String = ""
        '    Select Case ucrCboSelectThemes.GetText
        '        Case "Dark Theme"
        '            strCommand = "gt_theme_dark"
        '        Case "538 Theme"
        '            strCommand = "gt_theme_538"
        '        Case "Dot Matrix Theme"
        '            strCommand = "gt_theme_dot_matrix"
        '        Case "Espn Theme"
        '            strCommand = "gt_theme_espn"
        '        Case "Excel Theme"
        '            strCommand = "gt_theme_excel"
        '        Case "Guardian Theme"
        '            strCommand = "gt_theme_guardian"
        '        Case "NY Times Theme"
        '            strCommand = "gt_theme_nytimes"
        '        Case "PFF Theme"
        '            strCommand = "gt_theme_pff"
        '    End Select

        '    clsThemeRFunction.SetRCommand(strCommand)
        'End Sub

        Private Sub SetThemeValuesOnReturn() '(clsOperator As ROperator)
            ' Set the themes parameter if there was a theme selected
            If clsThemeRFunction IsNot Nothing AndAlso Not String.IsNullOrEmpty(clsThemeRFunction.strRCommand) Then
                clsBaseOperator.AddParameter("theme_format", clsRFunctionParameter:=clsThemeRFunction)
            Else
                clsBaseOperator.RemoveParameterByName("theme_format")
            End If
        End Sub

    End Class