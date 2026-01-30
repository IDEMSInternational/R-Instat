<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCheckSummary
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
        Me.UcrButtons1 = New instat.ucrButtons()
        Me.rdoOutliers = New System.Windows.Forms.RadioButton()
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.rdoTrend = New System.Windows.Forms.RadioButton()
        Me.rdoRecent = New System.Windows.Forms.RadioButton()
        Me.pnlRecent = New System.Windows.Forms.Panel()
        Me.ucrSaveNewColumn = New instat.ucrSave()
        Me.lblYearVariable = New System.Windows.Forms.Label()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.grdRecent = New unvell.ReoGrid.ReoGridControl()
        Me.ucrSelectorForRecode = New instat.ucrSelectorByDataFrameAddRemove()
        Me.pnlRecent.SuspendLayout()
        Me.SuspendLayout()
        '
        'UcrButtons1
        '
        Me.UcrButtons1.AutoSize = True
        Me.UcrButtons1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrButtons1.Location = New System.Drawing.Point(35, 386)
        Me.UcrButtons1.Name = "UcrButtons1"
        Me.UcrButtons1.Size = New System.Drawing.Size(408, 52)
        Me.UcrButtons1.TabIndex = 5
        '
        'rdoOutliers
        '
        Me.rdoOutliers.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoOutliers.BackColor = System.Drawing.SystemColors.Control
        Me.rdoOutliers.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOutliers.FlatAppearance.BorderSize = 2
        Me.rdoOutliers.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOutliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoOutliers.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoOutliers.Location = New System.Drawing.Point(210, 12)
        Me.rdoOutliers.Name = "rdoOutliers"
        Me.rdoOutliers.Size = New System.Drawing.Size(80, 28)
        Me.rdoOutliers.TabIndex = 7
        Me.rdoOutliers.TabStop = True
        Me.rdoOutliers.Tag = "Outliers"
        Me.rdoOutliers.Text = "Outliers"
        Me.rdoOutliers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoOutliers.UseVisualStyleBackColor = False
        '
        'rdoTable
        '
        Me.rdoTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTable.BackColor = System.Drawing.SystemColors.Control
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTable.Location = New System.Drawing.Point(286, 12)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(75, 28)
        Me.rdoTable.TabIndex = 8
        Me.rdoTable.TabStop = True
        Me.rdoTable.Tag = "Table"
        Me.rdoTable.Text = "Table"
        Me.rdoTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTable.UseVisualStyleBackColor = False
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(138, 23)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(286, 36)
        Me.ucrPnlOptions.TabIndex = 13
        '
        'rdoTrend
        '
        Me.rdoTrend.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTrend.BackColor = System.Drawing.SystemColors.Control
        Me.rdoTrend.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTrend.FlatAppearance.BorderSize = 2
        Me.rdoTrend.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTrend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTrend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTrend.Location = New System.Drawing.Point(356, 12)
        Me.rdoTrend.Name = "rdoTrend"
        Me.rdoTrend.Size = New System.Drawing.Size(68, 28)
        Me.rdoTrend.TabIndex = 6
        Me.rdoTrend.TabStop = True
        Me.rdoTrend.Tag = "Trend"
        Me.rdoTrend.Text = "Trend"
        Me.rdoTrend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTrend.UseVisualStyleBackColor = False
        '
        'rdoRecent
        '
        Me.rdoRecent.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRecent.BackColor = System.Drawing.SystemColors.Control
        Me.rdoRecent.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRecent.FlatAppearance.BorderSize = 2
        Me.rdoRecent.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRecent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRecent.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRecent.Location = New System.Drawing.Point(138, 12)
        Me.rdoRecent.Name = "rdoRecent"
        Me.rdoRecent.Size = New System.Drawing.Size(75, 28)
        Me.rdoRecent.TabIndex = 9
        Me.rdoRecent.TabStop = True
        Me.rdoRecent.Tag = "Recent"
        Me.rdoRecent.Text = "Recent"
        Me.rdoRecent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRecent.UseVisualStyleBackColor = False
        '
        'pnlRecent
        '
        Me.pnlRecent.Controls.Add(Me.ucrSaveNewColumn)
        Me.pnlRecent.Controls.Add(Me.lblYearVariable)
        Me.pnlRecent.Controls.Add(Me.ucrReceiverYear)
        Me.pnlRecent.Controls.Add(Me.grdRecent)
        Me.pnlRecent.Controls.Add(Me.ucrSelectorForRecode)
        Me.pnlRecent.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlRecent.Location = New System.Drawing.Point(0, 46)
        Me.pnlRecent.Name = "pnlRecent"
        Me.pnlRecent.Size = New System.Drawing.Size(589, 404)
        Me.pnlRecent.TabIndex = 14
        Me.pnlRecent.Visible = False
        '
        'ucrSaveNewColumn
        '
        Me.ucrSaveNewColumn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewColumn.Location = New System.Drawing.Point(35, 310)
        Me.ucrSaveNewColumn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveNewColumn.Name = "ucrSaveNewColumn"
        Me.ucrSaveNewColumn.Size = New System.Drawing.Size(389, 22)
        Me.ucrSaveNewColumn.TabIndex = 23
        '
        'lblYearVariable
        '
        Me.lblYearVariable.AutoSize = True
        Me.lblYearVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYearVariable.Location = New System.Drawing.Point(283, 19)
        Me.lblYearVariable.Name = "lblYearVariable"
        Me.lblYearVariable.Size = New System.Drawing.Size(73, 13)
        Me.lblYearVariable.TabIndex = 8
        Me.lblYearVariable.Text = "Year Variable:"
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(283, 34)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 9
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'grdRecent
        '
        Me.grdRecent.BackColor = System.Drawing.Color.White
        Me.grdRecent.ColumnHeaderContextMenuStrip = Nothing
        Me.grdRecent.LeadHeaderContextMenuStrip = Nothing
        Me.grdRecent.Location = New System.Drawing.Point(286, 69)
        Me.grdRecent.Name = "grdRecent"
        Me.grdRecent.RowHeaderContextMenuStrip = Nothing
        Me.grdRecent.Script = Nothing
        Me.grdRecent.SheetTabContextMenuStrip = Nothing
        Me.grdRecent.SheetTabNewButtonVisible = False
        Me.grdRecent.SheetTabVisible = False
        Me.grdRecent.SheetTabWidth = 60
        Me.grdRecent.ShowScrollEndSpacing = True
        Me.grdRecent.Size = New System.Drawing.Size(274, 125)
        Me.grdRecent.TabIndex = 1
        Me.grdRecent.Text = "ReoGridControl1"
        '
        'ucrSelectorForRecode
        '
        Me.ucrSelectorForRecode.AutoSize = True
        Me.ucrSelectorForRecode.bDropUnusedFilterLevels = False
        Me.ucrSelectorForRecode.bShowHiddenColumns = False
        Me.ucrSelectorForRecode.bUseCurrentFilter = True
        Me.ucrSelectorForRecode.Location = New System.Drawing.Point(9, 19)
        Me.ucrSelectorForRecode.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForRecode.Name = "ucrSelectorForRecode"
        Me.ucrSelectorForRecode.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForRecode.TabIndex = 6
        '
        'dlgCheckSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(589, 450)
        Me.Controls.Add(Me.rdoTrend)
        Me.Controls.Add(Me.rdoRecent)
        Me.Controls.Add(Me.rdoOutliers)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.UcrButtons1)
        Me.Controls.Add(Me.pnlRecent)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCheckSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Summary"
        Me.pnlRecent.ResumeLayout(False)
        Me.pnlRecent.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcrButtons1 As ucrButtons
    Friend WithEvents rdoOutliers As RadioButton
    Friend WithEvents rdoTable As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents rdoTrend As RadioButton
    Friend WithEvents rdoRecent As RadioButton
    Friend WithEvents pnlRecent As Panel
    Friend WithEvents ucrSelectorForRecode As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grdRecent As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblYearVariable As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrSaveNewColumn As ucrSave
End Class
