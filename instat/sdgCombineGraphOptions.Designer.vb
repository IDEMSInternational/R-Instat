﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgCombineGraphOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbcLayout = New System.Windows.Forms.TabControl()
        Me.tbpLayout = New System.Windows.Forms.TabPage()
        Me.txtLayoutMessage = New System.Windows.Forms.TextBox()
        Me.grdLayout = New unvell.ReoGrid.ReoGridControl()
        Me.lblSelectedgrpahs = New System.Windows.Forms.Label()
        Me.lstGraphs = New System.Windows.Forms.ListBox()
        Me.lblNumberofColumns = New System.Windows.Forms.Label()
        Me.lblNumberofRows = New System.Windows.Forms.Label()
        Me.tbpLabels = New System.Windows.Forms.TabPage()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.LblRight = New System.Windows.Forms.Label()
        Me.lblBottom = New System.Windows.Forms.Label()
        Me.lblTop = New System.Windows.Forms.Label()
        Me.ucrsdgLayoutBase = New instat.ucrButtonsSubdialogue()
        Me.ucrChkSpecifyOrder = New instat.ucrCheck()
        Me.ucrNudColumns = New instat.ucrNud()
        Me.ucrNudRows = New instat.ucrNud()
        Me.ucrInputLeft = New instat.ucrInputTextBox()
        Me.ucrInputRight = New instat.ucrInputTextBox()
        Me.ucrInputBottom = New instat.ucrInputTextBox()
        Me.ucrInputTop = New instat.ucrInputTextBox()
        Me.tbcLayout.SuspendLayout()
        Me.tbpLayout.SuspendLayout()
        Me.tbpLabels.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcLayout
        '
        Me.tbcLayout.Controls.Add(Me.tbpLayout)
        Me.tbcLayout.Controls.Add(Me.tbpLabels)
        Me.tbcLayout.Location = New System.Drawing.Point(13, 13)
        Me.tbcLayout.Name = "tbcLayout"
        Me.tbcLayout.SelectedIndex = 0
        Me.tbcLayout.Size = New System.Drawing.Size(379, 419)
        Me.tbcLayout.TabIndex = 0
        '
        'tbpLayout
        '
        Me.tbpLayout.Controls.Add(Me.ucrChkSpecifyOrder)
        Me.tbpLayout.Controls.Add(Me.ucrNudColumns)
        Me.tbpLayout.Controls.Add(Me.ucrNudRows)
        Me.tbpLayout.Controls.Add(Me.txtLayoutMessage)
        Me.tbpLayout.Controls.Add(Me.grdLayout)
        Me.tbpLayout.Controls.Add(Me.lblSelectedgrpahs)
        Me.tbpLayout.Controls.Add(Me.lstGraphs)
        Me.tbpLayout.Controls.Add(Me.lblNumberofColumns)
        Me.tbpLayout.Controls.Add(Me.lblNumberofRows)
        Me.tbpLayout.Location = New System.Drawing.Point(4, 22)
        Me.tbpLayout.Name = "tbpLayout"
        Me.tbpLayout.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLayout.Size = New System.Drawing.Size(371, 393)
        Me.tbpLayout.TabIndex = 0
        Me.tbpLayout.Text = "Layout"
        Me.tbpLayout.UseVisualStyleBackColor = True
        '
        'txtLayoutMessage
        '
        Me.txtLayoutMessage.Location = New System.Drawing.Point(11, 367)
        Me.txtLayoutMessage.Name = "txtLayoutMessage"
        Me.txtLayoutMessage.ReadOnly = True
        Me.txtLayoutMessage.Size = New System.Drawing.Size(342, 20)
        Me.txtLayoutMessage.TabIndex = 6
        '
        'grdLayout
        '
        Me.grdLayout.BackColor = System.Drawing.Color.White
        Me.grdLayout.ColumnHeaderContextMenuStrip = Nothing
        Me.grdLayout.LeadHeaderContextMenuStrip = Nothing
        Me.grdLayout.Location = New System.Drawing.Point(10, 179)
        Me.grdLayout.Name = "grdLayout"
        Me.grdLayout.RowHeaderContextMenuStrip = Nothing
        Me.grdLayout.Script = Nothing
        Me.grdLayout.SheetTabContextMenuStrip = Nothing
        Me.grdLayout.SheetTabNewButtonVisible = True
        Me.grdLayout.SheetTabVisible = True
        Me.grdLayout.SheetTabWidth = 60
        Me.grdLayout.Size = New System.Drawing.Size(343, 179)
        Me.grdLayout.TabIndex = 5
        Me.grdLayout.Text = "ReoGridControl1"
        '
        'lblSelectedgrpahs
        '
        Me.lblSelectedgrpahs.AutoSize = True
        Me.lblSelectedgrpahs.Location = New System.Drawing.Point(232, 19)
        Me.lblSelectedgrpahs.Name = "lblSelectedgrpahs"
        Me.lblSelectedgrpahs.Size = New System.Drawing.Size(89, 13)
        Me.lblSelectedgrpahs.TabIndex = 2
        Me.lblSelectedgrpahs.Text = "Selected Graphs:"
        '
        'lstGraphs
        '
        Me.lstGraphs.FormattingEnabled = True
        Me.lstGraphs.Location = New System.Drawing.Point(233, 34)
        Me.lstGraphs.Name = "lstGraphs"
        Me.lstGraphs.Size = New System.Drawing.Size(120, 134)
        Me.lstGraphs.TabIndex = 3
        '
        'lblNumberofColumns
        '
        Me.lblNumberofColumns.AutoSize = True
        Me.lblNumberofColumns.Location = New System.Drawing.Point(8, 50)
        Me.lblNumberofColumns.Name = "lblNumberofColumns"
        Me.lblNumberofColumns.Size = New System.Drawing.Size(102, 13)
        Me.lblNumberofColumns.TabIndex = 1
        Me.lblNumberofColumns.Text = "Number of Columns:"
        '
        'lblNumberofRows
        '
        Me.lblNumberofRows.AutoSize = True
        Me.lblNumberofRows.Location = New System.Drawing.Point(8, 24)
        Me.lblNumberofRows.Name = "lblNumberofRows"
        Me.lblNumberofRows.Size = New System.Drawing.Size(89, 13)
        Me.lblNumberofRows.TabIndex = 1
        Me.lblNumberofRows.Text = "Number of Rows:"
        '
        'tbpLabels
        '
        Me.tbpLabels.Controls.Add(Me.ucrInputLeft)
        Me.tbpLabels.Controls.Add(Me.ucrInputRight)
        Me.tbpLabels.Controls.Add(Me.ucrInputBottom)
        Me.tbpLabels.Controls.Add(Me.ucrInputTop)
        Me.tbpLabels.Controls.Add(Me.lblLeft)
        Me.tbpLabels.Controls.Add(Me.LblRight)
        Me.tbpLabels.Controls.Add(Me.lblBottom)
        Me.tbpLabels.Controls.Add(Me.lblTop)
        Me.tbpLabels.Location = New System.Drawing.Point(4, 22)
        Me.tbpLabels.Name = "tbpLabels"
        Me.tbpLabels.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLabels.Size = New System.Drawing.Size(371, 393)
        Me.tbpLabels.TabIndex = 1
        Me.tbpLabels.Text = "Labels"
        Me.tbpLabels.UseVisualStyleBackColor = True
        '
        'lblLeft
        '
        Me.lblLeft.AutoSize = True
        Me.lblLeft.Location = New System.Drawing.Point(15, 104)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(28, 13)
        Me.lblLeft.TabIndex = 6
        Me.lblLeft.Text = "Left:"
        '
        'LblRight
        '
        Me.LblRight.AutoSize = True
        Me.LblRight.Location = New System.Drawing.Point(15, 73)
        Me.LblRight.Name = "LblRight"
        Me.LblRight.Size = New System.Drawing.Size(35, 13)
        Me.LblRight.TabIndex = 4
        Me.LblRight.Text = "Right:"
        '
        'lblBottom
        '
        Me.lblBottom.AutoSize = True
        Me.lblBottom.Location = New System.Drawing.Point(15, 46)
        Me.lblBottom.Name = "lblBottom"
        Me.lblBottom.Size = New System.Drawing.Size(43, 13)
        Me.lblBottom.TabIndex = 2
        Me.lblBottom.Text = "Bottom:"
        '
        'lblTop
        '
        Me.lblTop.AutoSize = True
        Me.lblTop.Location = New System.Drawing.Point(15, 18)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.Size = New System.Drawing.Size(29, 13)
        Me.lblTop.TabIndex = 0
        Me.lblTop.Text = "Top:"
        '
        'ucrsdgLayoutBase
        '
        Me.ucrsdgLayoutBase.Location = New System.Drawing.Point(121, 438)
        Me.ucrsdgLayoutBase.Name = "ucrsdgLayoutBase"
        Me.ucrsdgLayoutBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrsdgLayoutBase.TabIndex = 3
        '
        'ucrChkSpecifyOrder
        '
        Me.ucrChkSpecifyOrder.Checked = False
        Me.ucrChkSpecifyOrder.Location = New System.Drawing.Point(11, 148)
        Me.ucrChkSpecifyOrder.Name = "ucrChkSpecifyOrder"
        Me.ucrChkSpecifyOrder.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSpecifyOrder.TabIndex = 8
        '
        'ucrNudColumns
        '
        Me.ucrNudColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudColumns.Location = New System.Drawing.Point(111, 47)
        Me.ucrNudColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumns.Name = "ucrNudColumns"
        Me.ucrNudColumns.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudColumns.TabIndex = 7
        Me.ucrNudColumns.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'ucrNudRows
        '
        Me.ucrNudRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRows.Location = New System.Drawing.Point(111, 20)
        Me.ucrNudRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRows.Name = "ucrNudRows"
        Me.ucrNudRows.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudRows.TabIndex = 7
        Me.ucrNudRows.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'ucrInputLeft
        '
        Me.ucrInputLeft.IsMultiline = False
        Me.ucrInputLeft.IsReadOnly = False
        Me.ucrInputLeft.Location = New System.Drawing.Point(60, 100)
        Me.ucrInputLeft.Name = "ucrInputLeft"
        Me.ucrInputLeft.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLeft.TabIndex = 7
        '
        'ucrInputRight
        '
        Me.ucrInputRight.IsMultiline = False
        Me.ucrInputRight.IsReadOnly = False
        Me.ucrInputRight.Location = New System.Drawing.Point(60, 70)
        Me.ucrInputRight.Name = "ucrInputRight"
        Me.ucrInputRight.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputRight.TabIndex = 5
        '
        'ucrInputBottom
        '
        Me.ucrInputBottom.IsMultiline = False
        Me.ucrInputBottom.IsReadOnly = False
        Me.ucrInputBottom.Location = New System.Drawing.Point(60, 42)
        Me.ucrInputBottom.Name = "ucrInputBottom"
        Me.ucrInputBottom.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputBottom.TabIndex = 3
        '
        'ucrInputTop
        '
        Me.ucrInputTop.IsMultiline = False
        Me.ucrInputTop.IsReadOnly = False
        Me.ucrInputTop.Location = New System.Drawing.Point(60, 15)
        Me.ucrInputTop.Name = "ucrInputTop"
        Me.ucrInputTop.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTop.TabIndex = 1
        '
        'sdgCombineGraphOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 469)
        Me.Controls.Add(Me.ucrsdgLayoutBase)
        Me.Controls.Add(Me.tbcLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCombineGraphOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        Me.tbcLayout.ResumeLayout(False)
        Me.tbpLayout.ResumeLayout(False)
        Me.tbpLayout.PerformLayout()
        Me.tbpLabels.ResumeLayout(False)
        Me.tbpLabels.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcLayout As TabControl
    Friend WithEvents tbpLayout As TabPage
    Friend WithEvents lblNumberofColumns As Label
    Friend WithEvents lblNumberofRows As Label
    Friend WithEvents tbpLabels As TabPage
    Friend WithEvents ucrInputLeft As ucrInputTextBox
    Friend WithEvents ucrInputRight As ucrInputTextBox
    Friend WithEvents ucrInputBottom As ucrInputTextBox
    Friend WithEvents ucrInputTop As ucrInputTextBox
    Friend WithEvents lblLeft As Label
    Friend WithEvents LblRight As Label
    Friend WithEvents lblBottom As Label
    Friend WithEvents lblTop As Label
    Friend WithEvents ucrsdgLayoutBase As ucrButtonsSubdialogue
    Friend WithEvents lstGraphs As ListBox
    Friend WithEvents lblSelectedgrpahs As Label
    Friend WithEvents grdLayout As unvell.ReoGrid.ReoGridControl
    Friend WithEvents txtLayoutMessage As TextBox
    Friend WithEvents ucrNudColumns As ucrNud
    Friend WithEvents ucrNudRows As ucrNud
    Friend WithEvents ucrChkSpecifyOrder As ucrCheck
End Class