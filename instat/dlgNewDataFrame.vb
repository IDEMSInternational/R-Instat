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
        SetRCode(bReset)
        bReset = False
        'temporary fix for autoTranslate(Me) which overwrites the label text to Label1
        ucrNewDFName.SetLabelText("New Data Frame Name:")
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 6

        'nudRows
        ucrNudRows.SetParameter(New RParameter("nrow", iNewPosition:=1))
        ucrNudRows.SetMinMax(1, Integer.MaxValue)
        ucrNudRows.SetLinkedDisplayControl(lblRows)

        'nudCols
        ucrNudCols.SetParameter(New RParameter("ncol", iNewPosition:=2))
        ucrNudCols.SetMinMax(1, Integer.MaxValue)
        ucrNudCols.SetLinkedDisplayControl(lblColumns)

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

    End Sub

    Private Sub SetDefaults()

        'Empty option functions
        clsEmptyOverallFunction = New RFunction
        clsEmptyMatrixFunction = New RFunction
        'e.g of Function to be constructed . data.frame(data=matrix(data = NA,nrow = 10, ncol = 2))
        clsEmptyOverallFunction.SetRCommand("data.frame")
        'matrix(data = NA,nrow = 10, ncol = 2)
        clsEmptyMatrixFunction.SetRCommand("matrix")
        clsEmptyMatrixFunction.AddParameter("data", "NA", iPosition:=0)
        clsEmptyMatrixFunction.AddParameter("nrow", 10, iPosition:=1)
        clsEmptyMatrixFunction.AddParameter("ncol", 2, iPosition:=2)

        clsEmptyOverallFunction.AddParameter("data", clsRFunctionParameter:=clsEmptyMatrixFunction, iPosition:=0)
        'ucrBase.clsRsyntax.SetBaseRFunction(clsEmptyOverallFunction)

        'Construct option function
        clsConstructFunction = New RFunction
        clsConstructFunction.SetRCommand("data.frame")

        'reset the controls
        ucrNewDFName.Reset()
        txtCommand.Text = "data.frame(data=matrix(data=NA, nrow=10, ncol=2))"
        'empty and create 6 default rows
        dataGridView.Rows.Clear()
        For i As Integer = 1 To 6
            dataGridView.Rows.Add()
        Next

        rdoConstruct.Checked = True
        rdoRandom.Enabled = False 'TODO remove this later
    End Sub

    Private Sub TestOKEnabled()
        If rdoConstruct.Checked Then
            'validate the datagrid rows 
            ucrBase.OKEnabled(False)
            If ucrNewDFName.IsComplete Then
                Dim inputValidation As New ucrInput 'temporarily use validation functions for ucrInput
                inputValidation.SetValidationTypeAsRVariable()
                For Each row As DataGridViewRow In dataGridView.Rows
                    'if column has a value then validate first
                    If Not String.IsNullOrEmpty(row.Cells("colName").Value) Then
                        If Not inputValidation.ValidateText(row.Cells("colName").Value) Then
                            row.Selected = True
                            ucrBase.OKEnabled(False)
                            Exit For ' if not valid text then exit for
                        End If
                    End If

                    'if both the column name and expression exist then enable
                    If Not String.IsNullOrEmpty(row.Cells("colName").Value) AndAlso Not String.IsNullOrEmpty(row.Cells("colExpression").Value) Then
                        ucrBase.OKEnabled(True)
                        'Exit For
                    End If
                Next
            End If

        ElseIf rdoCommand.Checked Then
            'enable if there is text in the input textbox
            ucrBase.OKEnabled(ucrNewDFName.IsComplete AndAlso txtCommand.TextLength > 0)
        ElseIf rdoRandom.Checked Then
            'TODO
            ucrBase.OKEnabled(False)
        ElseIf rdoEmpty.Checked Then
            If ucrNewDFName.IsComplete AndAlso ucrNudCols.GetText <> "" AndAlso ucrNudRows.GetText <> "" Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub SetRCode(bReset As Boolean)
        ucrNudCols.SetRCode(clsEmptyMatrixFunction, bReset)
        ucrNudRows.SetRCode(clsEmptyMatrixFunction, bReset)

        ucrNewDFName.AddAdditionalRCode(clsConstructFunction, iAdditionalPairNo:=1)
        ucrNewDFName.SetRCode(clsEmptyOverallFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCode(True)
    End Sub

    Private Sub controls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudRows.ControlValueChanged, ucrNudCols.ControlValueChanged, ucrNewDFName.ControlValueChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlDataFrame_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDataFrame.ControlValueChanged
        If rdoConstruct.Checked Then
            ucrNudCols.Visible = False
            ucrNudRows.Visible = False
            txtCommand.Visible = False
            dataGridView.Visible = True
            lblCommand.Visible = True
            btnExample.Visible = False
            lblCommand.Text = "Construct:"
            ucrBase.clsRsyntax.SetBaseRFunction(clsConstructFunction)
        ElseIf rdoCommand.Checked Then
            ucrNudCols.Visible = False
            ucrNudRows.Visible = False
            txtCommand.Visible = True
            dataGridView.Visible = False
            lblCommand.Visible = True
            btnExample.Visible = True
            lblCommand.Text = "Command:"
            ucrBase.clsRsyntax.SetCommandString(txtCommand.Text)
            ucrBase.clsRsyntax.SetAssignTo(ucrNewDFName.GetText(), strTempDataframe:=ucrNewDFName.GetText())
        ElseIf rdoRandom.Checked Then
            'TODO 
        ElseIf rdoEmpty.Checked Then
            ucrNudCols.Visible = True
            ucrNudRows.Visible = True
            txtCommand.Visible = False
            dataGridView.Visible = False
            lblCommand.Visible = False
            btnExample.Visible = False
            ucrBase.clsRsyntax.SetBaseRFunction(clsEmptyOverallFunction)
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrNewDFName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNewDFName.ControlValueChanged
        If rdoCommand.Checked Then
            ucrBase.clsRsyntax.SetAssignTo(ucrNewDFName.GetText(), strTempDataframe:=ucrNewDFName.GetText())
        End If
    End Sub

    Private Sub txtCommandAndDataGridView_ValueChanged(sender As Object, e As EventArgs) Handles txtCommand.TextChanged, dataGridView.CellValueChanged
        TestOKEnabled()
    End Sub

    Private Sub txtCommand_Leave(sender As Object, e As EventArgs) Handles txtCommand.TextChanged
        ucrBase.clsRsyntax.SetCommandString(txtCommand.Text)
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

    Private Sub mnuItemCut_Click(sender As Object, e As EventArgs) Handles mnuItemCut.Click
        txtCommand.Cut()
    End Sub

    Private Sub mnuItemCopy_Click(sender As Object, e As EventArgs) Handles mnuItemCopy.Click
        txtCommand.Copy()
    End Sub

    Private Sub mnuItemPaste_Click(sender As Object, e As EventArgs) Handles mnuItemPaste.Click
        txtCommand.Paste()
    End Sub

    Private Sub mnuItemUndo_Click(sender As Object, e As EventArgs) Handles mnuItemUndo.Click
        'Determine if last operation can be undone in text box.   
        If txtCommand.CanUndo Then
            'Undo the last operation.
            txtCommand.Undo()
            'Clear the undo buffer to prevent last action from being redone.
            txtCommand.ClearUndo()
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        txtCommand.SelectAll()
    End Sub

    Private Sub btnExample_Click(sender As Object, e As EventArgs) Handles btnExample.Click
        'shows a popup that displays the example commands
        Dim frm As New Form
        Dim lstView As New ListView
        frm.ShowInTaskbar = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Size = New Size(txtCommand.Width, txtCommand.Height)
        frm.Controls.Add(lstView)

        'Set the listview properties
        lstView.Dock = DockStyle.Fill
        lstView.Scrollable = True
        lstView.View = View.Details
        lstView.FullRowSelect = True

        'add columns
        lstView.Columns.Add("Command", 250)
        lstView.Columns.Add("Comment", 200)

        lstView.Items.Add(New ListViewItem({"data.frame()", "Empty data frame"}))
        lstView.Items.Add(New ListViewItem({"data.frame(data = matrix(data = NA, nrow = 10, ncol = 2)", "10 rows and 2 columns filled with missing values"}))
        lstView.Items.Add(New ListViewItem({"data.frame(x=1:30, y=rnorm(30,mean = 100, sd = 15), z = runif(30, min = 10, max = 30))", " "}))
        lstView.Items.Add(New ListViewItem({"data.frame( block = gl(4,3), treat = c(""C"",""A"",""B"",""B"",""C"",""A"",""A"",""B"",""C"",""A"",""C"",""B""), yield = c(74, 68, 50,62,68,57,70,56,83, 67, 67,59))", " "}))
        'lstView.Items.Add(New ListViewItem({"wakefield::r_data_theme(n = 100, data_theme = ""the_works"")", " "}))

        'set respective handlers
        AddHandler lstView.LostFocus, Sub()
                                          frm.Close()
                                      End Sub
        AddHandler lstView.Click, Sub()
                                      If lstView.SelectedItems.Count > 0 Then
                                          txtCommand.Text = lstView.SelectedItems.Item(0).SubItems(0).Text
                                          frm.Close()
                                      End If
                                  End Sub

        Dim ctlpos As Point = btnExample.PointToScreen(New Point(0, 0)) 'Point.Empty is not function so use Point(0, 0)
        frm.StartPosition = FormStartPosition.Manual 'set it to manual
        frm.Location = New Point(ctlpos.X - 2, ctlpos.Y - frm.Height - 2) 'set location to show the form just above the examples button
        frm.Show()
    End Sub
End Class