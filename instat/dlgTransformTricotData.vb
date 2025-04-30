Imports RDotNet

Public Class dlgTransformTricotData
    Private clsOutputDataLevel, clsCheckDataLevel, clsCreateTricotData, clsIDColsFunction, clsVarietyColsFunction, clsTraitColsFunction As New RFunction
    Private clsOutputLevelsOperator, OverallSymbolOperator As New ROperator
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
        clsOutputLevelsOperator = New ROperator
        OverallSymbolOperator = New ROperator
        bUniqueChecked = False
        bResetSubdialog = True
        ucrSelectorTricotData.Reset()
        ucrInputTricotData.SetText("")
        ucrInputTricotData.txtInput.BackColor = Color.White

        ucrReceiverTricotData.SetMeAsReceiver()
        clsOutputDataLevel.SetPackageName("instatExtras")
        clsOutputDataLevel.SetRCommand("summarise_data_levels")

        clsCreateTricotData.SetPackageName("databook")
        clsCreateTricotData.SetRCommand("create_tricot_data")
        clsCreateTricotData.AddParameter("output_data_levels", clsRFunctionParameter:=clsOutputDataLevel)

        clsOutputLevelsOperator.SetOperation("$")
        clsOutputLevelsOperator.AddParameter("left", clsROperatorParameter:=OverallSymbolOperator, iPosition:=0)
        clsOutputLevelsOperator.AddParameter("right", "print", iPosition:=1)
        clsOutputLevelsOperator.bSpaceAroundOperation = False

        OverallSymbolOperator.SetOperation("[")
        OverallSymbolOperator.AddParameter("left", clsRFunctionParameter:=clsOutputDataLevel, iPosition:=0)
        OverallSymbolOperator.AddParameter("right", "1,]", iPosition:=1)
        OverallSymbolOperator.bSpaceAroundOperation = False

        ucrBase.clsRsyntax.SetBaseRFunction(clsCreateTricotData)
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

        sdgTransformations.SetRFunction(clsNewRFunction:=clsOutputDataLevel, clsNewDefaultFunction:=clsCreateTricotData, clsNewIDColsFunction:=clsIDColsFunction, clsNewVarietyColsFunction:=clsVarietyColsFunction, clsNewTraitColsFunction:=clsTraitColsFunction, ucrNewBaseSelector:=ucrSelectorTricotData, bReset:=bResetSubdialog)
        sdgTransformations.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(Not ucrReceiverTricotData.IsEmpty AndAlso bUniqueChecked)
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
        clsPackageCheck.AddParameter("x", clsRFunctionParameter:=clsOutputDataLevel)

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
                ucrInputTricotData.SetText("Need ID level data to proceed. If you have an ID variable, are they all unique?")
                ucrInputTricotData.txtInput.BackColor = Color.LightCoral
            Case "1"
                bUniqueChecked = False
                ucrInputTricotData.SetText("Multiple data frames given at ID level. Should only have one data frame at each level.")
                ucrInputTricotData.txtInput.BackColor = Color.LightCoral
            Case "2"
                bUniqueChecked = False
                ucrInputTricotData.SetText("Tricot Data not found. Try using Options.")
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
                                             txtPopUpErrorDetail.Text = "Need ID level data to proceed. If you have an ID variable, are they all unique? Check in Tricot > Tidy > Duplicate (Rows). Otherwise, change ID variable under Options to a unique variable."
                                         ElseIf levelCode = "1" Then
                                             txtPopUpErrorDetail.Text = "Multiple data frames given at ID level. Should only have one data frame at each level. You can merge data frames in the Prepare > Data Reshape > Merge (Join) Dialog"
                                         ElseIf levelCode = "2" Then
                                             txtPopUpErrorDetail.Text = "Tricot Data not found. Try using Options to define ID variables and click Check again."
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
End Class