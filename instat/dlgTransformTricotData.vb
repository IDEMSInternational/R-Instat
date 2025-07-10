Imports RDotNet

Public Class dlgTransformTricotData
    Private clsOutputDataLevel, clsConcFunction, clsSetNameFunction, clsGetDataFrameFunction,
        clsListFunction, clsAddLinkFunction, clsGetVariablesPlotFunction, clsGetColumnSelectionFunction,
        clsGetVariablesVarietyFunction, clsOutputDataLevelForCheck, clsDefineTricotDataFunction, clsAddFunction, clsAddGroupedFunction,
        clsCheckDataLevel, clsRankingFunction, clsRankingGroupedFunction, clsUnameFunction,
        clsCreateTricotData, clsIDColsFunction, clsVarietyColsFunction, clsTraitColsFunction As New RFunction
    Private clsOutputLevelsOperator, clsIdVarietyOperator, clsIdOperator, clsTraitsOperator, clsPlotPullOperator, clsVarietyPullOperator, clsPlotOperator, clsVarietyOperator, OverallSymbolOperator As New ROperator
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = True
    Private bUniqueChecked As Boolean = False

    Private Sub dlgTransformTricotData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        TestOKEnabled()
        bUniqueChecked = False
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 671
        ucrReceiverTricotData.SetParameter(New RParameter("data_list", 0))
        ucrReceiverTricotData.SetParameterIsString()
        ucrReceiverTricotData.Selector = ucrSelectorTricotData
        ucrReceiverTricotData.strSelectorHeading = "Data Frames"
        ucrReceiverTricotData.SetItemType("dataframe")
    End Sub

    Private Sub SetDefaults()
        clsOutputDataLevel = New RFunction
        clsCreateTricotData = New RFunction
        clsIDColsFunction = New RFunction
        clsVarietyColsFunction = New RFunction
        clsTraitColsFunction = New RFunction
        clsDefineTricotDataFunction = New RFunction
        clsGetVariablesPlotFunction = New RFunction
        clsGetVariablesVarietyFunction = New RFunction
        clsAddLinkFunction = New RFunction
        clsConcFunction = New RFunction
        clsSetNameFunction = New RFunction
        clsListFunction = New RFunction
        clsRankingFunction = New RFunction
        clsRankingGroupedFunction = New RFunction
        clsGetColumnSelectionFunction = New RFunction
        clsGetDataFrameFunction = New RFunction
        clsAddFunction = New RFunction
        clsUnameFunction = New RFunction
        clsOutputDataLevelForCheck = New RFunction
        clsAddGroupedFunction = New RFunction
        clsOutputLevelsOperator = New ROperator
        OverallSymbolOperator = New ROperator
        clsPlotOperator = New ROperator
        clsVarietyPullOperator = New ROperator
        clsPlotPullOperator = New ROperator
        clsVarietyOperator = New ROperator
        clsTraitsOperator = New ROperator
        clsIdOperator = New ROperator
        clsIdVarietyOperator = New ROperator

        bUniqueChecked = False
        bResetSubdialog = True
        ucrBase.clsRsyntax.iCallType = 2
        ucrSelectorTricotData.Reset()
        ucrInputTricotData.SetText("")
        ucrInputTricotData.txtInput.BackColor = Color.White

        ucrReceiverTricotData.SetMeAsReceiver()

        clsOutputDataLevelForCheck.SetPackageName("instatExtras")
        clsOutputDataLevelForCheck.SetRCommand("summarise_data_levels")

        clsOutputDataLevel.SetPackageName("instatExtras")
        clsOutputDataLevel.SetRCommand("summarise_data_levels")
        clsOutputDataLevel.SetAssignTo("output_data_levels")

        clsCreateTricotData.SetPackageName("databook")
        clsCreateTricotData.SetRCommand("create_tricot_datasets")
        clsCreateTricotData.AddParameter("output_data_levels", clsRFunctionParameter:=clsOutputDataLevel, iPosition:=0, bIncludeArgumentName:=False)
        clsCreateTricotData.SetAssignTo("output_data_levels")

        OverallSymbolOperator.SetOperation("[")
        OverallSymbolOperator.AddParameter("left", clsRFunctionParameter:=clsOutputDataLevelForCheck, iPosition:=0)
        OverallSymbolOperator.AddParameter("right", "1,]", iPosition:=1)
        OverallSymbolOperator.bSpaceAroundOperation = False

        clsOutputLevelsOperator.SetOperation("$")
        clsOutputLevelsOperator.AddParameter("left", clsROperatorParameter:=OverallSymbolOperator, iPosition:=0)
        clsOutputLevelsOperator.AddParameter("right", "print", iPosition:=1)
        clsOutputLevelsOperator.bSpaceAroundOperation = False

        clsDefineTricotDataFunction.SetRCommand("define_tricot_data")
        clsDefineTricotDataFunction.AddParameter("output_data_levels", clsRFunctionParameter:=clsCreateTricotData, iPosition:=0, bIncludeArgumentName:=False)

        clsPlotOperator.SetOperation("%>%")
        clsPlotOperator.AddParameter("left", "output_data_levels", iPosition:=0)
        clsPlotOperator.AddParameter("right", "dplyr::filter(level == ""plot"")", iPosition:=1)
        clsPlotOperator.SetAssignTo("plot_data")

        clsVarietyOperator.SetOperation("%>%")
        clsVarietyOperator.AddParameter("left", "output_data_levels", iPosition:=0)
        clsVarietyOperator.AddParameter("right", "dplyr::filter(level == ""variety"")", iPosition:=1)
        clsVarietyOperator.SetAssignTo("variety_data")

        clsPlotPullOperator.SetOperation("%>%")
        clsPlotPullOperator.AddParameter("left", clsROperatorParameter:=clsPlotOperator, iPosition:=0)
        clsPlotPullOperator.AddParameter("right", "dplyr::pull(dataset)", iPosition:=1)
        clsPlotPullOperator.SetAssignTo("plot_data_name")

        clsVarietyPullOperator.SetOperation("%>%")
        clsVarietyPullOperator.AddParameter("left", clsROperatorParameter:=clsVarietyOperator, iPosition:=0)
        clsVarietyPullOperator.AddParameter("right", "dplyr::pull(dataset)", iPosition:=1)
        clsVarietyPullOperator.SetAssignTo("variety_data_name")

        clsGetVariablesPlotFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_from_metadata")
        clsGetVariablesPlotFunction.AddParameter("plot", clsROperatorParameter:=clsPlotPullOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsGetVariablesPlotFunction.AddParameter("Tricot", Chr(34) & "Tricot_Type" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsGetVariablesPlotFunction.AddParameter("variety", Chr(34) & "variety" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsGetVariablesPlotFunction.SetAssignTo("plot_data_type")

        clsGetVariablesVarietyFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_from_metadata")
        clsGetVariablesVarietyFunction.AddParameter("plot", clsROperatorParameter:=clsVarietyPullOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsGetVariablesVarietyFunction.AddParameter("Tricot", Chr(34) & "Tricot_Type" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsGetVariablesVarietyFunction.AddParameter("variety", Chr(34) & "variety" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsGetVariablesVarietyFunction.SetAssignTo("variety_data_type")

        clsListFunction.SetRCommand("list")
        clsListFunction.AddParameter("plot", clsRFunctionParameter:=clsGetVariablesPlotFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsSetNameFunction.SetRCommand("setNames")
        clsSetNameFunction.AddParameter("list", clsRFunctionParameter:=clsListFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsSetNameFunction.AddParameter("var", clsRFunctionParameter:=clsGetVariablesVarietyFunction, bIncludeArgumentName:=False, iPosition:=1)

        clsConcFunction.SetRCommand("c")
        clsConcFunction.AddParameter("name", clsRFunctionParameter:=clsSetNameFunction, bIncludeArgumentName:=False, iPosition:=0)

        clsAddLinkFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_link")
        clsAddLinkFunction.AddParameter("from_data_frame", "plot_data_name", iPosition:=0)
        clsAddLinkFunction.AddParameter("to_data_frame", "variety_data_name", iPosition:=1)
        clsAddLinkFunction.AddParameter("link_pairs", clsRFunctionParameter:=clsConcFunction, iPosition:=2)
        clsAddLinkFunction.AddParameter("type", Chr(34) & "keyed_link" & Chr(34), iPosition:=3)
        clsAddLinkFunction.AddParameter("link_name", Chr(34) & "link" & Chr(34), iPosition:=4)

        'creating ranking objects
        clsGetColumnSelectionFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_selection")
        clsGetColumnSelectionFunction.AddParameter("name", Chr(34) & "traits_selection" & Chr(34), iPosition:=0)
        clsGetColumnSelectionFunction.AddParameter("data_name", "plot_data_name", iPosition:=0)
        clsGetColumnSelectionFunction.SetAssignTo("traits")

        clsTraitsOperator.SetOperation("$")
        clsTraitsOperator.AddParameter("left", clsRFunctionParameter:=clsGetColumnSelectionFunction, iPosition:=0)
        clsTraitsOperator.AddParameter("right", "conditions$C0$parameters$x", iPosition:=1)

        clsUnameFunction.SetRCommand("unname")
        clsUnameFunction.AddParameter("trait", clsROperatorParameter:=clsTraitsOperator, bIncludeArgumentName:=False)
        clsUnameFunction.SetAssignTo("traits")

        clsGetDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetDataFrameFunction.AddParameter("plot", "plot_data_name", bIncludeArgumentName:=False)
        clsGetDataFrameFunction.SetAssignTo("plot_data_name_data")

        clsIdOperator.SetOperation("%>%")
        clsIdOperator.AddParameter("left", "plot_data", iPosition:=0)
        clsIdOperator.AddParameter("right", "dplyr::pull(c(id_col))", iPosition:=1)
        clsIdOperator.SetAssignTo("plot_data_id_var")

        clsIdVarietyOperator.SetOperation("%>%")
        clsIdVarietyOperator.AddParameter("left", "plot_data", iPosition:=0)
        clsIdVarietyOperator.AddParameter("right", "pull(c(variety_col))", iPosition:=1)
        clsIdVarietyOperator.SetAssignTo("plot_data_variety_var")

        clsRankingFunction.SetPackageName("instatExtras")
        clsRankingFunction.SetRCommand("create_rankings_list")
        clsRankingFunction.AddParameter("data", clsRFunctionParameter:=clsGetDataFrameFunction, iPosition:=0)
        clsRankingFunction.AddParameter("traits", clsRFunctionParameter:=clsUnameFunction, iPosition:=1)
        clsRankingFunction.AddParameter("id", clsROperatorParameter:=clsIdOperator, iPosition:=2)
        clsRankingFunction.AddParameter("variety", clsROperatorParameter:=clsIdVarietyOperator, iPosition:=3)
        clsRankingFunction.AddParameter("false", "FALSE", bIncludeArgumentName:=False, iPosition:=4)
        clsRankingFunction.SetAssignTo("rankings_list")

        clsAddFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_object")
        clsAddFunction.AddParameter("data_name", "plot_data_name", iPosition:=0)
        clsAddFunction.AddParameter("object_name", Chr(34) & "rankings_list" & Chr(34), iPosition:=1)
        clsAddFunction.AddParameter("object_type_label", Chr(34) & "structure" & Chr(34), iPosition:=2)
        clsAddFunction.AddParameter("object_format", Chr(34) & "text" & Chr(34), iPosition:=3)
        clsAddFunction.AddParameter("object", clsRFunctionParameter:=clsRankingFunction, iPosition:=4)

        clsRankingGroupedFunction.SetPackageName("instatExtras")
        clsRankingGroupedFunction.SetRCommand("create_rankings_list")
        clsRankingGroupedFunction.AddParameter("data", "plot_data_name_data", iPosition:=0)
        clsRankingGroupedFunction.AddParameter("traits", "traits", iPosition:=1)
        clsRankingGroupedFunction.AddParameter("id", "plot_data_id_var", iPosition:=2)
        clsRankingGroupedFunction.AddParameter("variety", "plot_data_variety_var", iPosition:=3)
        clsRankingGroupedFunction.AddParameter("true", "TRUE", bIncludeArgumentName:=False, iPosition:=4)
        clsRankingGroupedFunction.SetAssignTo("grouped_rankings_list")

        clsAddGroupedFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_object")
        clsAddGroupedFunction.AddParameter("data_name", "plot_data_name", iPosition:=0)
        clsAddGroupedFunction.AddParameter("object_name", Chr(34) & "grouped_rankings_list" & Chr(34), iPosition:=1)
        clsAddGroupedFunction.AddParameter("object_type_label", Chr(34) & "structure" & Chr(34), iPosition:=2)
        clsAddGroupedFunction.AddParameter("object_format", Chr(34) & "text" & Chr(34), iPosition:=3)
        clsAddGroupedFunction.AddParameter("object", clsRFunctionParameter:=clsRankingGroupedFunction, iPosition:=4)

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToAfterCodes(clsDefineTricotDataFunction, 0)
        ucrBase.clsRsyntax.AddToAfterCodes(clsAddLinkFunction, 1)
        ucrBase.clsRsyntax.AddToAfterCodes(clsAddFunction, 2)
        ucrBase.clsRsyntax.AddToAfterCodes(clsAddGroupedFunction, 3)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverTricotData.SetRCode(clsOutputDataLevel, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click

        ' Only add parameters if it is clicked, otherwise we take the defaults
        clsOutputDataLevel.AddParameter("id_cols", clsRFunctionParameter:=clsIDColsFunction)
        clsOutputDataLevel.AddParameter("variety_cols", clsRFunctionParameter:=clsVarietyColsFunction)
        clsOutputDataLevel.AddParameter("trait_cols", clsRFunctionParameter:=clsTraitColsFunction)
        clsIDColsFunction.SetRCommand("c")
        clsIDColsFunction.AddParameter("id_1", Chr(34) & "ID" & Chr(34), bIncludeArgumentName:=False)
        clsIDColsFunction.AddParameter("id_2", Chr(34) & "id" & Chr(34), bIncludeArgumentName:=False)
        clsIDColsFunction.AddParameter("id_3", Chr(34) & "participant_name" & Chr(34), bIncludeArgumentName:=False)
        clsIDColsFunction.AddParameter("id_4", Chr(34) & "participant_id" & Chr(34), bIncludeArgumentName:=False)
        clsVarietyColsFunction.SetRCommand("c")
        clsVarietyColsFunction.AddParameter("var_1", Chr(34) & "variety" & Chr(34), bIncludeArgumentName:=False)
        clsVarietyColsFunction.AddParameter("var_2", Chr(34) & "varieties" & Chr(34), bIncludeArgumentName:=False)
        clsVarietyColsFunction.AddParameter("var_3", Chr(34) & "item" & Chr(34), bIncludeArgumentName:=False)
        clsVarietyColsFunction.AddParameter("var_4", Chr(34) & "items" & Chr(34), bIncludeArgumentName:=False)
        clsVarietyColsFunction.AddParameter("var_5", Chr(34) & "Genotype" & Chr(34), bIncludeArgumentName:=False)
        clsVarietyColsFunction.AddParameter("var_6", Chr(34) & "genotype" & Chr(34), bIncludeArgumentName:=False)
        clsTraitColsFunction.SetRCommand("c")
        clsTraitColsFunction.AddParameter("trait_1", Chr(34) & "trait" & Chr(34), bIncludeArgumentName:=False)
        clsTraitColsFunction.AddParameter("trait_2", Chr(34) & "traits" & Chr(34), bIncludeArgumentName:=False)

        sdgTransformations.SetRFunction(clsNewRFunction:=clsOutputDataLevel, clsNewDefaultFunction:=clsCreateTricotData, clsNewIDColsFunction:=clsIDColsFunction, clsNewVarietyColsFunction:=clsVarietyColsFunction, clsNewTraitColsFunction:=clsTraitColsFunction, clsNewDefineTricotDataFunction:=clsDefineTricotDataFunction, ucrNewBaseSelector:=ucrSelectorTricotData, bReset:=bResetSubdialog)
        sdgTransformations.ShowDialog()
        ClearCheckOnSdgClose()
        TestOKEnabled()
        bResetSubdialog = False
    End Sub

    Private Sub ClearCheckOnSdgClose()
        bUniqueChecked = False
        ucrInputTricotData.SetText("")
        ucrInputTricotData.txtInput.BackColor = Color.White
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverTricotData.IsEmpty AndAlso bUniqueChecked Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub


    Private Sub cmdCheckTricotData_click(sender As Object, e As EventArgs) Handles cmdCheckTricotData.Click
        Check()
    End Sub

    Private Sub Check()
        Dim clsPackageCheck As New RFunction
        Dim expOutput As SymbolicExpression
        Dim chrOutput As CharacterVector
        Dim strFormNames() As String
        Dim expTemp As SymbolicExpression

        clsPackageCheck.SetPackageName("instatExtras")
        clsPackageCheck.SetRCommand("check_data_levels")
        clsPackageCheck.AddParameter("x", clsRFunctionParameter:=clsOutputDataLevelForCheck)

        expOutput = frmMain.clsRLink.RunInternalScriptGetValue(clsPackageCheck.ToScript(), bSilent:=True)

        If expOutput Is Nothing OrElse expOutput.Type = Internals.SymbolicExpressionType.Null Then
            ucrInputTricotData.SetText("Cannot get data information.")
            ucrInputTricotData.txtInput.BackColor = Color.White
            Exit Sub
        End If

        chrOutput = expOutput.AsCharacter
        If chrOutput.Count < 1 Then
            ucrInputTricotData.SetText("Cannot get data information.")
            ucrInputTricotData.txtInput.BackColor = Color.White
            Exit Sub
        End If

        Select Case chrOutput(0)
            Case "0"
                bUniqueChecked = False
                ucrInputTricotData.SetText("No ID variable found. Click for more information.")
                ucrInputTricotData.txtInput.BackColor = Color.LightCoral
            Case "1"
                bUniqueChecked = False
                ucrInputTricotData.SetText("Multiple data frames given at ID level. Click for more information.")
                ucrInputTricotData.txtInput.BackColor = Color.LightCoral
            Case "2"
                bUniqueChecked = False
                ucrInputTricotData.SetText("No ID variable found. Click for more information.")
                ucrInputTricotData.txtInput.BackColor = Color.LightCoral
            Case "4"
                bUniqueChecked = False
                ucrInputTricotData.SetText("ID-Level Data found, but no traits found. Click for more.")
                ucrInputTricotData.txtInput.BackColor = Color.LightCoral
            Case Else
                bUniqueChecked = True
                Cursor = Cursors.WaitCursor
                expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsOutputLevelsOperator.ToScript(), bSeparateThread:=False, bShowWaitDialogOverride:=False)
                Cursor = Cursors.Default
                If expTemp IsNot Nothing Then
                    strFormNames = expTemp.AsCharacter().ToArray()
                    ucrInputTricotData.SetName(String.Join(", ", strFormNames))
                End If
                ucrInputTricotData.txtInput.BackColor = Color.LightGreen
        End Select

        ' Pass the output code into the popup logic
        AddButtonInTryTextBox(chrOutput(0))
        TestOKEnabled()
    End Sub

    Private Sub AddButtonInTryTextBox(Optional levelCode As String = "")
        Dim strDetails() As String
        Dim expTemp As SymbolicExpression

        ' Remove old button if it exists
        For Each ctrl As Control In ucrInputTricotData.Controls.OfType(Of Button).ToList()
            If ctrl.Name = "btnTricotDetails" Then
                ucrInputTricotData.Controls.Remove(ctrl)
                ctrl.Dispose()
            End If
        Next

        ' Add new button
        Dim btnDetails As New Button With {
            .Name = "btnTricotDetails"
        }
        ucrInputTricotData.Controls.Add(btnDetails)

        btnDetails.Text = ":::"
        btnDetails.Size = New Size(25, ucrInputTricotData.ClientSize.Height + 2)
        btnDetails.TextAlign = ContentAlignment.TopCenter
        btnDetails.FlatStyle = FlatStyle.Standard
        btnDetails.FlatAppearance.BorderSize = 0
        btnDetails.Cursor = Cursors.Default
        btnDetails.Dock = DockStyle.Right
        btnDetails.UseVisualStyleBackColor = True

        AddHandler btnDetails.Click, Sub()
                                         Dim frmPopUp As New Form
                                         Dim txtPopUpErrorDetail As New TextBox

                                         frmPopUp.ShowInTaskbar = False
                                         frmPopUp.FormBorderStyle = FormBorderStyle.None
                                         frmPopUp.Size = New Size(ucrInputTricotData.Width, 120)
                                         frmPopUp.Controls.Add(txtPopUpErrorDetail)

                                         txtPopUpErrorDetail.Dock = DockStyle.Fill
                                         txtPopUpErrorDetail.Multiline = True
                                         txtPopUpErrorDetail.ScrollBars = ScrollBars.Vertical
                                         txtPopUpErrorDetail.WordWrap = True

                                         AddHandler txtPopUpErrorDetail.LostFocus, Sub() frmPopUp.Close()
                                         AddHandler txtPopUpErrorDetail.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                                                                     If e.Control AndAlso e.KeyCode = Keys.Enter Then frmPopUp.Close()
                                                                                 End Sub

                                         Dim ctlpos As Point = ucrInputTricotData.PointToScreen(New Point(0, 0))
                                         frmPopUp.StartPosition = FormStartPosition.Manual
                                         frmPopUp.Location = New Point(ctlpos.X - 2, ctlpos.Y - frmPopUp.Height - 2)
                                         frmPopUp.Show()

                                         ' Handle different cases
                                         If levelCode = "0" Then
                                             txtPopUpErrorDetail.Text = "Need ID level data to proceed. Tricot data is not found. Do you have an ID variable? If you have an ID variable, are they all unique? Check in Tricot > Tidy > Duplicate (Rows). Otherwise, change ID variable under Options to a unique variable."
                                         ElseIf levelCode = "1" Then
                                             txtPopUpErrorDetail.Text = "Multiple data frames given at ID level. Should only have one data frame at each level. You can merge data frames in the Prepare > Data Reshape > Merge (Join) Dialog"
                                         ElseIf levelCode = "2" Then
                                             txtPopUpErrorDetail.Text = "Need ID level data to proceed. Try using Options to define ID variables and click Check again. If you have an ID variable, are they all unique? Check in Tricot > Tidy > Duplicate (Rows). Otherwise, change ID variable under Options to a unique variable."
                                         ElseIf levelCode = "4" Then
                                             txtPopUpErrorDetail.Text = "No traits variables found for ID-level data. If only ID-level data is supplied, the data needs the traits to have a double-barreled name for the traits variable, e.g., `yield_best`."
                                         Else
                                             expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsOutputLevelsOperator.ToScript(), bSeparateThread:=False, bShowWaitDialogOverride:=False)
                                             If expTemp IsNot Nothing Then
                                                 strDetails = expTemp.AsCharacter().ToArray()
                                                 txtPopUpErrorDetail.Text = String.Join(", ", strDetails)
                                             Else
                                                 txtPopUpErrorDetail.Text = "No output."
                                             End If
                                         End If

                                         txtPopUpErrorDetail.SelectionStart = txtPopUpErrorDetail.TextLength
                                     End Sub
    End Sub

    Private Sub ucrReceiverTricotData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverTricotData.ControlValueChanged
        clsOutputDataLevelForCheck.AddParameter("data_list", ucrReceiverTricotData.GetVariableNames())
    End Sub

    Private Sub ucrReceiverTricotData_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverTricotData.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class