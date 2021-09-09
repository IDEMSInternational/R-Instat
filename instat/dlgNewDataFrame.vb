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
        'autoTranslate(Me) this subroutine was causing a bug in the button examples
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
        ucrNewDFName.SetSaveTypeAsDataFrame()
        ucrNewDFName.SetLabelText("New Data Frame Name:")
        ucrNewDFName.SetIsTextBox()
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

        ucrTryNewDataFrame.SetIsCommand()
        ucrTryNewDataFrame.RunCommandAsMultipleLines = True

    End Sub

    Private Sub SetDefaults()
        clsConstructFunction = New RFunction
        'Empty option functions
        clsEmptyOverallFunction = New RFunction
        clsEmptyMatrixFunction = New RFunction

        'reset the controls
        ucrNewDFName.Reset()
        ucrTryNewDataFrame.SetRSyntax(ucrBase.clsRsyntax)

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
            btnExample.Text = "Construct Examples" 'this is being done here cause of the datagridview. We don't have its custom control
            lblCommand.Visible = True
            btnExample.Visible = True
            dataGridView.Visible = True
            ucrTryNewDataFrame.Visible = True
            ucrTryNewDataFrame.ClearTryText()
            ucrBase.clsRsyntax.SetBaseRFunction(clsConstructFunction)
        ElseIf rdoCommand.Checked OrElse rdoRandom.Checked Then
            If rdoCommand.Checked Then
                btnExample.Text = "Command Examples"
                If ucrInputCommand.GetText = "" OrElse ucrInputCommand.GetText = "data.frame(data=matrix(data=NA, nrow=10, ncol=2))" OrElse ucrInputCommand.GetText = "wakefield::r_data_theme(n = 100, data_theme = ""the_works"")" Then
                    ucrInputCommand.SetText("data.frame(data=matrix(data=NA, nrow=10, ncol=2))")
                End If
            Else
                btnExample.Text = "Random Examples"
                If ucrInputCommand.GetText = "" OrElse ucrInputCommand.GetText = "data.frame(data=matrix(data=NA, nrow=10, ncol=2))" OrElse ucrInputCommand.GetText = "wakefield::r_data_theme(n = 100, data_theme = ""the_works"")" Then
                    ucrInputCommand.SetText("wakefield::r_data_theme(n = 100, data_theme = ""the_works"")")
                End If
            End If
            lblCommand.Visible = True 'this is being done here cause of the datagridview. We don't have its custom control
            btnExample.Visible = True
            dataGridView.Visible = False
            ucrTryNewDataFrame.Visible = True
            ucrTryNewDataFrame.ClearTryText()

            ucrBase.clsRsyntax.SetCommandString(ucrInputCommand.GetText())
            ucrBase.clsRsyntax.SetAssignTo(ucrNewDFName.GetText(), strTempDataframe:=ucrNewDFName.GetText())
        ElseIf rdoEmpty.Checked Then
            lblCommand.Visible = False 'this is being done here cause of the datagridview. We don't have its custom control
            btnExample.Visible = False
            ucrTryNewDataFrame.Visible = False
            dataGridView.Visible = False
            ucrBase.clsRsyntax.SetBaseRFunction(clsEmptyOverallFunction)
        End If
        autoTranslate(Me)
    End Sub

    Private Sub ucrNewDFName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNewDFName.ControlValueChanged
        If rdoCommand.Checked OrElse rdoRandom.Checked Then
            ucrBase.clsRsyntax.SetAssignTo(ucrNewDFName.GetText(), strTempDataframe:=ucrNewDFName.GetText())
        End If
    End Sub

    Private Sub ucrInputCommand_ContentsChanged() Handles ucrInputCommand.ContentsChanged
        ucrTryNewDataFrame.ClearTryText()
        ucrBase.clsRsyntax.SetCommandString(ucrInputCommand.GetText())
        TestOKEnabled()
    End Sub

    Private Sub dataGridView_ValueChanged(sender As Object, e As EventArgs) Handles dataGridView.CellValueChanged
        Dim iPosition As Integer = 0

        clsConstructFunction.ClearParameters() 'clear the previous parameters which acted as the columns then add the new ones
        For Each row As DataGridViewRow In dataGridView.Rows
            'check for colName for the colName and colExpression which is column index 1 & 2
            'used column index instead of column name because of argument exception
            If Not String.IsNullOrEmpty(row.Cells(1).Value) OrElse Not String.IsNullOrEmpty(row.Cells(2).Value) Then
                clsConstructFunction.AddParameter(row.Cells(1).Value, row.Cells(2).Value, iPosition:=iPosition)
                iPosition = iPosition + 1
            End If
        Next

        ucrTryNewDataFrame.ClearTryText()
        TestOKEnabled()
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
        lstView.ShowItemToolTips = True

        'add the appropriate columns and rows with the commands based on the option selected
        If rdoCommand.Checked Then
            lstView.Columns.Add("Command", 450)  'add columns

            lstView.Items.Add(New ListViewItem({"data.frame(row = 1:100)"}))
            lstView.Items.Item(0).ToolTipText = "Data frame with a single variable to build on."

            lstView.Items.Add(New ListViewItem({"data.frame(data = matrix(data = NA, nrow = 10, ncol = 2))"}))
            lstView.Items.Item(1).ToolTipText = "The same data frame as the default from the Empty option of this dialogue."

            lstView.Items.Add(New ListViewItem({"data.frame(x = 1:30, s = rep(""Reading"",30), r = seq(1, 6.8, length=30), t = seq(1, 60, 2))"}))
            lstView.Items.Item(2).ToolTipText = "4 variables, showing use of seq and rep function"

            lstView.Items.Add(New ListViewItem({"data.frame(date = seq(as.Date(""2021-1-1""), as.Date(""2021-1-31""), ""day""), rain = as.numeric(NA))"}))
            lstView.Items.Item(3).ToolTipText = "Two variables with daily dates and rainfall, ready for climatic data entry."

            lstView.Items.Add(New ListViewItem({"data.frame(date = seq(as.Date(""2019-1-1""), as.Date(""2020-12-31""), ""month""), rain = NA_real_, tmin = NA_real_, tmax = NA_real_)"}))
            lstView.Items.Item(4).ToolTipText = "Four variables including monthly dates. Or use Prepare > Column: Date > Generate Dates to include a date variable."

            lstView.Items.Add(New ListViewItem({"data.frame(n = 1:12, h = seq(as.POSIXct(""2010-1-1 3: 0:0""), by = ""2 hours"",length = 12))"}))
            lstView.Items.Item(5).ToolTipText = "2 variables including generating a sequence of times"

            lstView.Items.Add(New ListViewItem({"data.frame(block = gl(4, 3), treat = c(""C"", ""A"", ""B"", ""B"", ""C"", ""A"", ""A"", ""B"", ""C"", ""A"", ""C"", ""B""), yield = c(74, 68,  50, 62, 68, 57, 70, 56, 83, 67, 67, 59))"}))
            lstView.Items.Item(6).ToolTipText = "Illustrates the gl function and generates data for a simple experiment on 12 plots"

        ElseIf rdoRandom.Checked Then
            lstView.Columns.Add("Command", 450)  'add columns

            lstView.Items.Add(New ListViewItem({"data.frame(x = 1:30, y = rnorm(30, mean = 100, sd = 15), z = runif(30, min = 10, max = 30))"}))
            lstView.Items.Item(0).ToolTipText = "3 variables including both random normal and uniform data"

            lstView.Items.Add(New ListViewItem({"data.frame(data = replicate(20, rbinom(n = 25, p = 0.4,size = 1)))"}))
            lstView.Items.Item(1).ToolTipText = "20 variables, each a random sample from a binomial distribution"

            lstView.Items.Add(New ListViewItem({"data.frame(year = matrix(data = c(rbinom(7300, p = 0.4, size = 1) * rexp(7300, 0.1)), nrow = 365, ncol = 20))"}))
            lstView.Items.Item(2).ToolTipText = "20 years of rainfall-type data using binomial (p = 0.4) and exponential (mean = 10) variables"

            lstView.Items.Add(New ListViewItem({"data.frame(replicate(10,(sample(c(TRUE,FALSE), size = 50,replace = TRUE,prob = c(0.3,0.7)))))"}))
            lstView.Items.Item(3).ToolTipText = "10 variables and 50 observations, sampling with replacement and probability 0.3 of TRUE"

            'wakefield commands
            lstView.Items.Add(New ListViewItem({"wakefield::r_data_theme(n = 100, data_theme = ""the_works"")"}))
            lstView.Items.Item(4).ToolTipText = "49 variables, illustrating most of the types of data in the Wakefield package"

            lstView.Items.Add(New ListViewItem({"wakefield::r_data_frame(n = 30, id, race, age, sex, hour, iq, height, died, Scoring = rnorm, Smoker = valid)"}))
            lstView.Items.Item(5).ToolTipText = "10 variables from the Wakefield package"

            lstView.Items.Add(New ListViewItem({"wakefield::r_data_theme(n = 200, data_theme = ""survey"")"}))
            lstView.Items.Item(6).ToolTipText = "ID plus 10 categorical variables each with 5 levels"

            lstView.Items.Add(New ListViewItem({"wakefield::r_data_theme(n = 500, data_theme = ""survey2"") %>% r_na(prob = 0.1)"}))
            lstView.Items.Item(7).ToolTipText = "ID plus 10 categorical variables (as factors) and 10% of missing values"

            lstView.Items.Add(New ListViewItem({"wakefield::r_data_frame(n = 50,id, r_dummy(color), r_series(likert, 3), grade, grade, grade)"}))
            lstView.Items.Item(8).ToolTipText = "ID, plus 12 variables. 6 are indicator (dummy) variables, 3 Likert and 3 grades"

        ElseIf rdoConstruct.Checked Then
            lstView.Columns.Add("Column Name", 150)  'add columns
            lstView.Columns.Add("Expression", 300)  'add columns

            lstView.Items.Add(New ListViewItem({"no", "c(0, 0.5, 1, 2:28)"}))
            lstView.Items.Item(0).ToolTipText = "c( ) produces a vector. Here it produces a variable (column) of 30 values between 0 and 28 seq produces a regular sequence. Here from 30 down to 1 in steps of -1"

            lstView.Items.Add(New ListViewItem({"seq", "seq(30, 1, -1)"}))
            lstView.Items.Item(1).ToolTipText = "seq produces a regular sequence. Here from 30 down to 1 in steps of -1"

            lstView.Items.Add(New ListViewItem({"place", "rep(""Kisumu"", 30)"}))
            lstView.Items.Item(2).ToolTipText = "rep repeats one or more values as shown here. Try also rep(1:5, each =6) and rep((1:5,length = 30)"

            lstView.Items.Add(New ListViewItem({"place2", "c(rep(""Mombasa"", 10), rep(""Nairobi"", 20))"}))
            lstView.Items.Item(3).ToolTipText = "c( ) and rep or seq can be combined as shown here. Try also c(rep(1:5,each=2),seq(6,100,length=20)) regular sequence of dates. Alternatively use Prepare > Column: Date > Generate Dates"

            lstView.Items.Add(New ListViewItem({"days", "seq(as.Date(""2020/4/1""), as.Date(""2020/4/30""), ""days"")"}))
            lstView.Items.Item(4).ToolTipText = "regular sequence of dates. Alternatively use Prepare > Column: Date > Generate Dates"

            lstView.Items.Add(New ListViewItem({"occasions", "seq(as.Date(""1970/1/1""), by = ""4 months"", length = 30)"}))
            lstView.Items.Item(4).ToolTipText = "Regular sequence of monthly data"

            lstView.Items.Add(New ListViewItem({"prob1", "c(0.01, 0.05, 0.1, 0.2, 0.5, 0.8, 0.9, 0.95, 0.99)"}))
            lstView.Items.Add(New ListViewItem({"prob2", "c(0.5, 0.8, 0.9, 0.95, 0.98, 0.99, 0.995, 0.998, 0.999)"}))
            lstView.Items.Add(New ListViewItem({"quant1", "seq(-4, 4)"}))
            lstView.Items.Add(New ListViewItem({"quant2", "c(40, 50, 60, 80, 100, 130, 160, 200, 250)"}))

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
                                                'fill in the empty rows with the selected example or replace existing column names since R doesn't accept duplicate column names
                                                For Each row As DataGridViewRow In dataGridView.Rows
                                                    If String.IsNullOrEmpty(row.Cells("colName").Value) AndAlso String.IsNullOrEmpty(row.Cells("colExpression").Value) Then
                                                        row.Cells("colName").Value = lstView.SelectedItems.Item(0).SubItems(0).Text
                                                        row.Cells("colExpression").Value = lstView.SelectedItems.Item(0).SubItems(1).Text
                                                        dataGridView.Rows.Add(1)
                                                        Exit For
                                                    ElseIf row.Cells("colName").Value = lstView.SelectedItems.Item(0).SubItems(0).Text Then
                                                        row.Cells("colName").Value = lstView.SelectedItems.Item(0).SubItems(0).Text
                                                        row.Cells("colExpression").Value = lstView.SelectedItems.Item(0).SubItems(1).Text
                                                        Exit For
                                                    End If
                                                Next
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

End Class
