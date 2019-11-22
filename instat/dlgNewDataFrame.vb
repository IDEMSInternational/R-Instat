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
Imports RDotNet

Public Class dlgNewDataFrame
    Private clsEmptyOverallFunction, clsEmptyMatrixFunction As New RFunction
    Private clsConstructFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgNewDataFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 6

        ucrInputCommand.txtInput.WordWrap = False
        ucrInputCommand.txtInput.ScrollBars = ScrollBars.Both

        'nudRows
        ucrNudRows.SetParameter(New RParameter("nrow", iNewPosition:=1))
        ucrNudRows.SetMinMax(1, Integer.MaxValue)

        'nudCols
        ucrNudCols.SetParameter(New RParameter("ncol", iNewPosition:=2))
        ucrNudCols.SetMinMax(1, Integer.MaxValue)

        ' ucrNewSheetName
        ucrNewDFName.SetIsTextBox()
        ucrNewDFName.SetSaveTypeAsDataFrame()
        ucrNewDFName.SetLabelText("New Data Frame Name:")
        ucrNewDFName.SetPrefix("data")

        'ucrRdoOptions
        ucrPnlDataFrame.AddRadioButton(rdoConstruct)
        ucrPnlDataFrame.AddRadioButton(rdoCommand)
        ucrPnlDataFrame.AddRadioButton(rdoRandom)
        ucrPnlDataFrame.AddRadioButton(rdoEmpty)

        'TODO:Providing conditions here may not be easy, find a way to do this properly!
        ucrPnlDataFrame.AddFunctionNamesCondition(rdoConstruct, "data.frame")
        'ucrPnlDataFrame.AddFunctionNamesCondition(rdoCommand, ucrInputCommand.GetText())
        'ucrPnlDataFrame.AddFunctionNamesCondition(rdoRandom, "")
        'ucrPnlDataFrame.AddFunctionNamesCondition(rdoEmpty, "")

        ucrPnlDataFrame.AddToLinkedControls(ucrNudCols, {rdoEmpty}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)
        ucrPnlDataFrame.AddToLinkedControls(ucrNudRows, {rdoEmpty}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10)
        ucrPnlDataFrame.AddToLinkedControls(ucrInputCommand, {rdoCommand, rdoRandom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudRows.SetLinkedDisplayControl(lblRows)
        ucrNudCols.SetLinkedDisplayControl(lblColumns)
        ucrInputCommand.SetLinkedDisplayControl(New List(Of Control)({lblCommand, btnExample}))
    End Sub

    Private Sub SetDefaults()
        clsConstructFunction = New RFunction
        'Empty option functions
        clsEmptyOverallFunction = New RFunction
        clsEmptyMatrixFunction = New RFunction

        'reset the controls
        ucrNewDFName.Reset()

        'e.g of Function to be constructed . data.frame(data=matrix(data = NA,nrow = 10, ncol = 2))
        clsEmptyOverallFunction.SetRCommand("data.frame")
        clsEmptyOverallFunction.AddParameter("data", clsRFunctionParameter:=clsEmptyMatrixFunction, iPosition:=0)

        'matrix(data = NA,nrow = 10, ncol = 2)
        clsEmptyMatrixFunction.SetRCommand("matrix")
        clsEmptyMatrixFunction.AddParameter("data", "NA", iPosition:=0)
        clsEmptyMatrixFunction.AddParameter("nrow", 10, iPosition:=1)
        clsEmptyMatrixFunction.AddParameter("ncol", 2, iPosition:=2)

        'Construct option function
        clsConstructFunction.SetRCommand("data.frame")

        'empty and create 5 (+1) default rows
        dataGridView.Rows.Clear()
        dataGridView.Rows.Add(5)

        ucrBase.clsRsyntax.SetBaseRFunction(clsConstructFunction)
    End Sub

    Private Sub TestOKEnabled()
        If rdoConstruct.Checked Then
            'validate the datagrid rows 
            ucrBase.OKEnabled(False)
            If ucrNewDFName.IsComplete Then
                Dim bValid As Boolean = True
                Dim lstUserColumnNames As New List(Of String)
                Dim inputValidation As New ucrInput 'temporarily use validation functions for ucrInput
                inputValidation.SetValidationTypeAsRVariable()
                For Each row As DataGridViewRow In dataGridView.Rows

                    row.Cells("colName").Style.BackColor = Color.White
                    row.Cells("colExpression").Style.BackColor = Color.White

                    'if column has a value then validate first
                    If Not String.IsNullOrEmpty(row.Cells("colName").Value) Then
                        If Not inputValidation.ValidateText(row.Cells("colName").Value) Then
                            row.Cells("colName").Style.BackColor = Color.Red
                            ucrBase.OKEnabled(False)
                            'Exit For ' if not valid text then exit for
                            bValid = False
                        End If

                        'check for duplicates
                        If lstUserColumnNames.Contains(row.Cells("colName").Value) Then
                            row.Cells("colName").Style.BackColor = Color.Yellow
                            ucrBase.OKEnabled(False)
                            MessageBox.Show(Me, "Duplicate column names are not allowed", "Construct", MessageBoxButtons.OK)
                            'Exit For
                            bValid = False
                        Else
                            lstUserColumnNames.Add(row.Cells("colName").Value)
                        End If
                    End If

                    'disable if column name is there but expression is not 
                    If Not String.IsNullOrEmpty(row.Cells("colName").Value) AndAlso String.IsNullOrEmpty(row.Cells("colExpression").Value) Then
                        row.Cells("colExpression").Style.BackColor = Color.Yellow
                        ucrBase.OKEnabled(False)
                        'Exit For
                        bValid = False
                    End If

                    'disable if expression is there but column name is not 
                    If String.IsNullOrEmpty(row.Cells("colName").Value) AndAlso Not String.IsNullOrEmpty(row.Cells("colExpression").Value) Then
                        row.Cells("colName").Style.BackColor = Color.Yellow
                        ucrBase.OKEnabled(False)
                        'Exit For
                        bValid = False
                    End If

                    If bValid Then
                        'if both the column name and expression exist then enable
                        If Not String.IsNullOrEmpty(row.Cells("colName").Value) AndAlso Not String.IsNullOrEmpty(row.Cells("colExpression").Value) Then
                            ucrBase.OKEnabled(True)
                        End If
                    End If

                Next
            End If
        ElseIf rdoCommand.Checked Then
            'enable if there is text in the input textbox
            ucrBase.OKEnabled(ucrNewDFName.IsComplete AndAlso Not ucrInputCommand.IsEmpty)
        ElseIf rdoRandom.Checked Then
            'enable if there is text in the input textbox
            ucrBase.OKEnabled(ucrNewDFName.IsComplete AndAlso Not ucrInputCommand.IsEmpty)
        ElseIf rdoEmpty.Checked Then
            If ucrNewDFName.IsComplete AndAlso ucrNudCols.GetText <> "" AndAlso ucrNudRows.GetText <> "" Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrNudCols.SetRCode(clsEmptyMatrixFunction, bReset)
        ucrNudRows.SetRCode(clsEmptyMatrixFunction, bReset)

        ucrNewDFName.AddAdditionalRCode(clsEmptyOverallFunction, iAdditionalPairNo:=1)
        ucrNewDFName.SetRCode(clsConstructFunction, bReset)

        If bReset Then
            ucrPnlDataFrame.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudRows.ControlContentsChanged, ucrNudCols.ControlContentsChanged, ucrNewDFName.ControlContentsChanged, ucrPnlDataFrame.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlDataFrame_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDataFrame.ControlValueChanged
        If rdoConstruct.Checked Then
            dataGridView.Visible = True
            btnTry.Visible = True
            ucrInputTryMessage.Visible = True
            ucrInputTryMessage.SetText("")
            ucrInputTryMessage.txtInput.BackColor = Color.White
            ucrBase.clsRsyntax.SetBaseRFunction(clsConstructFunction)
        ElseIf rdoCommand.Checked OrElse rdoRandom.Checked Then
            If rdoCommand.Checked Then
                btnExample.Text = "Command Examples"
                If ucrInputCommand.GetText = "data.frame(data=matrix(data=NA, nrow=10, ncol=2))" OrElse ucrInputCommand.GetText = "wakefield::r_data_theme(n = 100, data_theme = ""the_works"")" Then
                    ucrInputCommand.SetText("data.frame(data=matrix(data=NA, nrow=10, ncol=2))")
                End If
            Else
                btnExample.Text = "Random Examples"
                If ucrInputCommand.GetText = "data.frame(data=matrix(data=NA, nrow=10, ncol=2))" OrElse ucrInputCommand.GetText = "wakefield::r_data_theme(n = 100, data_theme = ""the_works"")" Then
                    ucrInputCommand.SetText("wakefield::r_data_theme(n = 100, data_theme = ""the_works"")")
                End If

            End If

            dataGridView.Visible = False
            btnTry.Visible = True
            ucrInputTryMessage.Visible = True
            ucrInputTryMessage.SetText("")
            ucrInputTryMessage.txtInput.BackColor = Color.White
            ucrBase.clsRsyntax.SetCommandString(ucrInputCommand.GetText())
            ucrBase.clsRsyntax.SetAssignTo(ucrNewDFName.GetText(), strTempDataframe:=ucrNewDFName.GetText())

        ElseIf rdoEmpty.Checked Then
            btnTry.Visible = False
            ucrInputTryMessage.Visible = False
            dataGridView.Visible = False
            ucrBase.clsRsyntax.SetBaseRFunction(clsEmptyOverallFunction)
        End If
    End Sub

    Private Sub ucrNewDFName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNewDFName.ControlValueChanged
        If rdoCommand.Checked OrElse rdoRandom.Checked Then
            ucrBase.clsRsyntax.SetAssignTo(ucrNewDFName.GetText(), strTempDataframe:=ucrNewDFName.GetText())
        End If
    End Sub

    Private Sub ucrInputCommand_ContentsChanged() Handles ucrInputCommand.ContentsChanged
        ucrInputTryMessage.SetText("")
        ucrInputTryMessage.txtInput.BackColor = Color.White
        ucrBase.clsRsyntax.SetCommandString(ucrInputCommand.GetText())
        TestOKEnabled()
    End Sub

    Private Sub dataGridView_ValueChanged(sender As Object, e As EventArgs) Handles dataGridView.CellValueChanged
        ucrInputTryMessage.SetText("")
        ucrInputTryMessage.txtInput.BackColor = Color.White
        TestOKEnabled()
    End Sub

    Private Sub dataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView.CellEndEdit
        Dim iPosition As Integer = 0
        'clear the previous parameters which acted as the columns then add the new ones
        clsConstructFunction.ClearParameters()
        For Each row As DataGridViewRow In dataGridView.Rows
            If row.Cells("colName").Value <> "" AndAlso row.Cells("colExpression").Value <> "" Then
                clsConstructFunction.AddParameter(row.Cells("colName").Value, row.Cells("colExpression").Value, iPosition:=iPosition)
                iPosition = iPosition + 1
            End If
        Next
    End Sub

    Private Sub dataGridView_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dataGridView.RowsAdded
        'used column index instead of column name because of argument exception
        For i As Integer = 0 To dataGridView.Rows.Count - 1
            dataGridView.Rows.Item(i).Cells(0).Value = i + 1
        Next
    End Sub

    Private Sub btnExample_Click(sender As Object, e As EventArgs) Handles btnExample.Click
        'shows a popup that displays the example commands
        Dim frm As New Form
        Dim lstView As New ListView
        frm.ShowInTaskbar = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Size = New Size(ucrInputCommand.Width, ucrInputCommand.Height)
        frm.Controls.Add(lstView)

        'Set the listview properties
        lstView.Dock = DockStyle.Fill
        lstView.Scrollable = True
        lstView.View = View.Details
        lstView.FullRowSelect = True

        'add columns
        lstView.Columns.Add("Command", 450)
        'lstView.Columns.Add("Comment", 200)

        'add the appropraite rows with the commands based on the option selected
        If rdoCommand.Checked Then
            lstView.Items.Add(New ListViewItem({"data.frame()"}))
            lstView.Items.Add(New ListViewItem({"data.frame(data = matrix(data = NA, nrow = 10, ncol = 2))"}))

            lstView.Items.Add(New ListViewItem({"data.frame(x=1:30, s=rep(""Reading"",30),r=seq(1, 6.8, length=30),t=seq(1,60,2))"}))
            lstView.Items.Add(New ListViewItem({"data.frame(l=1:31,d=seq(as.Date(""2013-1-1""),as.Date(""2013-1-31""),""day""))"}))
            lstView.Items.Add(New ListViewItem({"data.frame(n=1:12,h=seq(as.POSIXct(""2010-1-1 3: 0:0""),by=""2 hours"",length=12))"}))
            lstView.Items.Add(New ListViewItem({"data.frame(block = gl(4, 3), treat = c(""C"", ""A"", ""B"", ""B"", ""C"", ""A"", ""A"", ""B"", ""C"", ""A"", ""C"", ""B""), yield = c(74, 68,  50, 62, 68, 57, 70, 56, 83, 67, 67, 59))"}))

        ElseIf rdoRandom.Checked Then
            lstView.Items.Add(New ListViewItem({"data.frame(x = 1:30, y = rnorm(30, mean = 100, sd = 15), z = runif(30, min = 10, max = 30))"}))
            lstView.Items.Add(New ListViewItem({"data.frame(data = replicate(20,rbinom(n=25, p=0.4,size=1)))"}))
            lstView.Items.Add(New ListViewItem({"data.frame(data = matrix(data=c(rbinom(7300,p=0.4,size=1)*rexp(7300,0.1)), nrow = 365, ncol = 20))"}))
            lstView.Items.Add(New ListViewItem({"data.frame(replicate(10,(sample(c(TRUE,FALSE),size=50,replace=TRUE,prob=c(0.3,0.7)))))"}))

            lstView.Items.Add(New ListViewItem({"wakefield::r_data_theme(n = 100, data_theme = ""the_works"")"}))
            lstView.Items.Add(New ListViewItem({"wakefield::r_data_frame(n = 30, id, race, age, sex, hour, iq, height, died, Scoring = rnorm, Smoker = valid)"}))
            lstView.Items.Add(New ListViewItem({"wakefield::r_data_theme(n = 200, data_theme = ""survey"")"}))
            lstView.Items.Add(New ListViewItem({"wakefield::r_data_theme(n=500, data_theme = ""survey2"") %>% r_na(prob=0.1)"}))
            lstView.Items.Add(New ListViewItem({"wakefield::r_data_frame(n = 50,id, r_dummy(color),r_series(likert,3),grade,grade,grade)"}))


        ElseIf rdoConstruct.Checked Then
            'TODO
        End If

        'set respective handlers
        AddHandler lstView.LostFocus, Sub()
                                          frm.Close()
                                      End Sub
        AddHandler lstView.DoubleClick, Sub()
                                            If lstView.SelectedItems.Count < 1 Then
                                                Exit Sub
                                            End If

                                            If rdoConstruct.Checked Then
                                                'TODO. 
                                            Else
                                                ucrInputCommand.SetText(lstView.SelectedItems.Item(0).SubItems(0).Text)
                                            End If

                                            frm.Close()
                                        End Sub

        Dim ctlpos As Point = btnExample.PointToScreen(New Point(0, 0)) 'Point.Empty is not function so use Point(0, 0)
        frm.StartPosition = FormStartPosition.Manual 'set it to manual
        frm.Location = New Point(ctlpos.X - 2, ctlpos.Y - frm.Height - 2) 'set location to show the form just above the examples button
        frm.Show()
    End Sub

    Private Sub cmdTry_Click(sender As Object, e As EventArgs) Handles btnTry.Click
        Dim bValid As Boolean = False
        Dim vecOutput As CharacterVector
        Dim strScript As String
        Try

            If rdoConstruct.Checked Then
                strScript = clsConstructFunction.ToScript
                vecOutput = frmMain.clsRLink.RunInternalScriptGetOutput(strScript, bSilent:=True)
                bValid = (Not IsNothing(vecOutput) AndAlso vecOutput.Length > 0)
            ElseIf rdoCommand.Checked OrElse rdoRandom.Checked Then
                Dim lstScriptCommands As New List(Of String)
                strScript = ucrInputCommand.GetText
                lstScriptCommands.AddRange(strScript.Split(New String() {Environment.NewLine}, StringSplitOptions.None))
                For Each str As String In lstScriptCommands
                    If Not String.IsNullOrWhiteSpace(str) Then
                        vecOutput = frmMain.clsRLink.RunInternalScriptGetOutput(str, bSilent:=True)
                        If vecOutput IsNot Nothing AndAlso vecOutput.Length > 0 Then
                            bValid = True
                            'don't break the if, we probably want to loop through to the last command checking validity? 
                        End If
                    End If
                Next

            End If


            If bValid Then
                ucrInputTryMessage.SetText("Command Ok.")
                ucrInputTryMessage.txtInput.BackColor = Color.LightGreen
            Else
                ucrInputTryMessage.SetText("Command produced an error or no output to display.")
                ucrInputTryMessage.txtInput.BackColor = Color.LightCoral
            End If


        Catch ex As Exception
            ucrInputTryMessage.SetText("Command produced an error.")
            ucrInputTryMessage.txtInput.BackColor = Color.LightCoral
        End Try
    End Sub

End Class
