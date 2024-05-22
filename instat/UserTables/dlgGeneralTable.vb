Imports instat.Translations

Public Class dlgGeneralTable
    Private clsBaseOperator As New ROperator
    Private clsHeadRFunction, clsGtRFunction As New RFunction
    Private clsGtHeaderRFunction, clsGtTitleRFunction, clsGtSubtitleRFunction As New RFunction

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
    End Sub

    Private Sub ucrInputHeaderTitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputHeaderTitle.ControlValueChanged
        'If no title providded, then just remove the tab_header command from the operator
        If ucrInputHeaderTitle.IsEmpty() Then
            clsBaseOperator.RemoveParameterByName("tab_header_func_name")
        Else
            clsBaseOperator.AddParameter("tab_header_func_name", clsRFunctionParameter:=clsGtHeaderRFunction, iPosition:=3, bIncludeArgumentName:=False)
        End If
    End Sub

    Private Sub ucrInputHeaderSubtitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputHeaderSubtitle.ControlValueChanged
        ' Subtitle is optional, so remove the parameter when empty
        If ucrInputHeaderSubtitle.IsEmpty() Then
            clsGtHeaderRFunction.RemoveParameterByName("subtitle")
        Else
            clsGtHeaderRFunction.AddParameter("subtitle", clsRFunctionParameter:=clsGtSubtitleRFunction, iPosition:=1)
        End If
    End Sub

    Private Sub btnHeaderTitleFormat_Click(sender As Object, e As EventArgs) Handles btnHeaderTitleFormat.Click
        clsTablesUtils.ShowTextFormatSubDialog(Me, clsGtTitleRFunction)
    End Sub

    Private Sub btnHeaderSubtitleFormat_Click(sender As Object, e As EventArgs) Handles btnHeaderSubTitleFormat.Click
        clsTablesUtils.ShowTextFormatSubDialog(Me, clsGtSubtitleRFunction)
    End Sub

    Private Sub btnMoreOptions_Click(sender As Object, e As EventArgs) Handles btnMoreOptions.Click
        sdgTableOptions.Setup(clsBaseOperator)
        sdgTableOptions.ShowDialog(Me)
    End Sub

    Private Sub ucrControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputHeaderTitle.ControlContentsChanged, ucrInputHeaderSubtitle.ControlContentsChanged, ucrReceiverMultipleCols.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub


    Private Sub initialiseDialog()

        ucrInputHeaderTitle.SetParameter(New RParameter("title_text_param", 0, bNewIncludeArgumentName:=False))
        ucrInputHeaderTitle.SetLinkedDisplayControl(New List(Of Control)({lblHeaderTitle, btnHeaderTitleFormat}))

        ucrInputHeaderSubtitle.SetParameter(New RParameter("subtitle_text_param", 0, bNewIncludeArgumentName:=False))
        ucrInputHeaderSubtitle.SetLinkedDisplayControl(New List(Of Control)({lblHeaderSubtitle, btnHeaderSubTitleFormat}))

        ucrReceiverMultipleCols.SetParameter(New RParameter("df_columns_to_use_param", 0, bNewIncludeArgumentName:=False))
        ucrReceiverMultipleCols.SetParameterIsRFunction()
        ucrReceiverMultipleCols.Selector = ucrSelectorCols
        ucrReceiverMultipleCols.SetLinkedDisplayControl(lblColumns)

        ucrReceiverSingleRowName.SetParameter(New RParameter("rowname_col", 0))
        ucrReceiverSingleRowName.SetParameterIsString()
        ucrReceiverSingleRowName.Selector = ucrSelectorCols
        ucrReceiverSingleRowName.SetLinkedDisplayControl(lblRowName)

        ucrReceiverSingleGroupByCol.SetParameter(New RParameter("groupname_col", 1))
        ucrReceiverSingleGroupByCol.SetParameterIsString()
        ucrReceiverSingleGroupByCol.Selector = ucrSelectorCols
        ucrReceiverSingleGroupByCol.SetLinkedDisplayControl(lblGroupByCol)

        ucrChkPreview.SetText("Preview")
        ucrChkPreview.AddParameterPresentCondition(True, "head", bNewIsPositive:=True)
        ucrChkPreview.AddParameterPresentCondition(False, "head", bNewIsPositive:=False)
        ucrChkPreview.AddToLinkedControls(ucrNudPreview, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrNudPreview.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrNudPreview.Minimum = 6
        ucrNudPreview.SetRDefault(6)

        ucrSaveTable.SetPrefix("table")
        ucrSaveTable.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
        ucrSaveTable.SetDataFrameSelector(ucrSelectorCols.ucrAvailableDataFrames)
        ucrSaveTable.SetIsComboBox()
        ucrSaveTable.SetCheckBoxText("Save Table")
        ucrSaveTable.SetAssignToIfUncheckedValue("last_table")
    End Sub


    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsHeadRFunction = New RFunction
        clsGtRFunction = New RFunction

        clsGtHeaderRFunction = New RFunction
        clsGtTitleRFunction = New RFunction
        clsGtSubtitleRFunction = New RFunction

        ucrSelectorCols.Reset()
        ucrReceiverMultipleCols.SetMeAsReceiver()
        ucrSaveTable.Reset()
        ucrChkPreview.Checked = True

        clsBaseOperator.SetOperation("%>%")
        clsBaseOperator.bBrackets = False

        clsHeadRFunction.SetPackageName("utils")
        clsHeadRFunction.SetRCommand("head")
        clsBaseOperator.AddParameter(strParameterName:="head", clsRFunctionParameter:=clsHeadRFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsGtRFunction.SetPackageName("gt")
        clsGtRFunction.SetRCommand("gt")
        clsBaseOperator.AddParameter(strParameterName:="gt", clsRFunctionParameter:=clsGtRFunction, iPosition:=2, bIncludeArgumentName:=False)

        '-----------------------------------------
        ' HEADER  
        clsGtHeaderRFunction.SetPackageName("gt")
        clsGtHeaderRFunction.SetRCommand("tab_header")

        ' Title related R functions
        clsGtTitleRFunction = clsTablesUtils.GetNewHtmlSpanRFunction()
        clsGtHeaderRFunction.AddParameter("title", clsRFunctionParameter:=clsGtTitleRFunction, iPosition:=0)

        ' Subtitle related R functions
        clsGtSubtitleRFunction = clsTablesUtils.GetNewHtmlSpanRFunction()

        '-----------------------------------------

        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)

    End Sub



    Private Sub SetRCodeForControls(bReset As Boolean)

        ucrInputHeaderTitle.SetRCode(clsGtTitleRFunction, bReset)
        ucrInputHeaderSubtitle.SetRCode(clsGtSubtitleRFunction, bReset)
        ucrReceiverMultipleCols.SetRCode(clsBaseOperator, bReset)
        ucrSaveTable.SetRCode(clsBaseOperator, bReset)

        ucrReceiverSingleRowName.SetRCode(clsGtRFunction, bReset)
        ucrReceiverSingleGroupByCol.SetRCode(clsGtRFunction, bReset)

        ucrChkPreview.SetRCode(clsBaseOperator, bReset)
        ucrNudPreview.SetRCode(clsHeadRFunction, bReset)

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrInputHeaderSubtitle.IsEmpty AndAlso ucrInputHeaderTitle.IsEmpty Then
            'If title not provided then subtitle should not be provided
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(Not ucrReceiverMultipleCols.IsEmpty AndAlso ucrSaveTable.IsComplete)
        End If
    End Sub

    Private Sub ucrChkPreview_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPreview.ControlValueChanged
        If ucrChkPreview.Checked Then
            clsBaseOperator.AddParameter(strParameterName:="head", clsRFunctionParameter:=clsHeadRFunction, iPosition:=1, bIncludeArgumentName:=False)
        Else
            clsBaseOperator.RemoveParameterByName("head")
        End If
    End Sub
End Class