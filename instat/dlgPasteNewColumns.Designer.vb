<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgPasteNewColumns
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
        Me.ucrDFSelected = New instat.ucrDataFrame()
        Me.panelNoDataPreview = New System.Windows.Forms.Panel()
        Me.lblNoDataPreview = New System.Windows.Forms.Label()
        Me.lblConfirmText = New System.Windows.Forms.Label()
        Me.lblLinesToPreview = New System.Windows.Forms.Label()
        Me.lblPreviewHeader = New System.Windows.Forms.Label()
        Me.btnRefreshPreview = New System.Windows.Forms.Button()
        Me.grdDataPreview = New unvell.ReoGrid.ReoGridControl()
        Me.ucrSaveNewDFName = New instat.ucrSave()
        Me.ucrNudPreviewLines = New instat.ucrNud()
        Me.ucrChkRowHeader = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.rdoColumns = New System.Windows.Forms.RadioButton()
        Me.rdoDataFrame = New System.Windows.Forms.RadioButton()
        Me.ucrPnl = New instat.UcrPanel()
        Me.ucrChkKeepExstingCols = New instat.ucrCheck()
        Me.panelNoDataPreview.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrDFSelected
        '
        Me.ucrDFSelected.AutoSize = True
        Me.ucrDFSelected.bDropUnusedFilterLevels = False
        Me.ucrDFSelected.bUseCurrentFilter = True
        Me.ucrDFSelected.Location = New System.Drawing.Point(5, 265)
        Me.ucrDFSelected.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDFSelected.Name = "ucrDFSelected"
        Me.ucrDFSelected.Size = New System.Drawing.Size(177, 50)
        Me.ucrDFSelected.TabIndex = 0
        '
        'panelNoDataPreview
        '
        Me.panelNoDataPreview.Controls.Add(Me.lblNoDataPreview)
        Me.panelNoDataPreview.Location = New System.Drawing.Point(5, 70)
        Me.panelNoDataPreview.Name = "panelNoDataPreview"
        Me.panelNoDataPreview.Size = New System.Drawing.Size(572, 186)
        Me.panelNoDataPreview.TabIndex = 36
        '
        'lblNoDataPreview
        '
        Me.lblNoDataPreview.AutoSize = True
        Me.lblNoDataPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoDataPreview.Location = New System.Drawing.Point(201, 66)
        Me.lblNoDataPreview.Name = "lblNoDataPreview"
        Me.lblNoDataPreview.Size = New System.Drawing.Size(168, 25)
        Me.lblNoDataPreview.TabIndex = 0
        Me.lblNoDataPreview.Text = "No Data Loaded"
        '
        'lblConfirmText
        '
        Me.lblConfirmText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConfirmText.Location = New System.Drawing.Point(358, 271)
        Me.lblConfirmText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConfirmText.Name = "lblConfirmText"
        Me.lblConfirmText.Size = New System.Drawing.Size(219, 46)
        Me.lblConfirmText.TabIndex = 35
        Me.lblConfirmText.Text = "Click Ok to paste data to new data frame"
        '
        'lblLinesToPreview
        '
        Me.lblLinesToPreview.AutoSize = True
        Me.lblLinesToPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLinesToPreview.Location = New System.Drawing.Point(315, 50)
        Me.lblLinesToPreview.Name = "lblLinesToPreview"
        Me.lblLinesToPreview.Size = New System.Drawing.Size(88, 13)
        Me.lblLinesToPreview.TabIndex = 34
        Me.lblLinesToPreview.Text = "Lines to Preview:"
        '
        'lblPreviewHeader
        '
        Me.lblPreviewHeader.AutoSize = True
        Me.lblPreviewHeader.Location = New System.Drawing.Point(5, 50)
        Me.lblPreviewHeader.Name = "lblPreviewHeader"
        Me.lblPreviewHeader.Size = New System.Drawing.Size(119, 13)
        Me.lblPreviewHeader.TabIndex = 33
        Me.lblPreviewHeader.Text = "Preview of copied data:"
        '
        'btnRefreshPreview
        '
        Me.btnRefreshPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRefreshPreview.Location = New System.Drawing.Point(477, 45)
        Me.btnRefreshPreview.Name = "btnRefreshPreview"
        Me.btnRefreshPreview.Size = New System.Drawing.Size(100, 23)
        Me.btnRefreshPreview.TabIndex = 29
        Me.btnRefreshPreview.Text = "Refresh Preview"
        Me.btnRefreshPreview.UseVisualStyleBackColor = True
        '
        'grdDataPreview
        '
        Me.grdDataPreview.BackColor = System.Drawing.Color.White
        Me.grdDataPreview.ColumnHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.LeadHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.Location = New System.Drawing.Point(5, 70)
        Me.grdDataPreview.Name = "grdDataPreview"
        Me.grdDataPreview.Readonly = True
        Me.grdDataPreview.RowHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.Script = Nothing
        Me.grdDataPreview.SheetTabContextMenuStrip = Nothing
        Me.grdDataPreview.SheetTabNewButtonVisible = False
        Me.grdDataPreview.SheetTabVisible = True
        Me.grdDataPreview.SheetTabWidth = 60
        Me.grdDataPreview.ShowScrollEndSpacing = True
        Me.grdDataPreview.Size = New System.Drawing.Size(572, 186)
        Me.grdDataPreview.TabIndex = 32
        '
        'ucrSaveNewDFName
        '
        Me.ucrSaveNewDFName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewDFName.Location = New System.Drawing.Point(5, 269)
        Me.ucrSaveNewDFName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveNewDFName.Name = "ucrSaveNewDFName"
        Me.ucrSaveNewDFName.Size = New System.Drawing.Size(263, 24)
        Me.ucrSaveNewDFName.TabIndex = 30
        '
        'ucrNudPreviewLines
        '
        Me.ucrNudPreviewLines.AutoSize = True
        Me.ucrNudPreviewLines.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreviewLines.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPreviewLines.Location = New System.Drawing.Point(420, 45)
        Me.ucrNudPreviewLines.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudPreviewLines.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.ucrNudPreviewLines.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ucrNudPreviewLines.Name = "ucrNudPreviewLines"
        Me.ucrNudPreviewLines.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPreviewLines.TabIndex = 28
        Me.ucrNudPreviewLines.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'ucrChkRowHeader
        '
        Me.ucrChkRowHeader.AutoSize = True
        Me.ucrChkRowHeader.Checked = False
        Me.ucrChkRowHeader.Location = New System.Drawing.Point(141, 47)
        Me.ucrChkRowHeader.Name = "ucrChkRowHeader"
        Me.ucrChkRowHeader.Size = New System.Drawing.Size(169, 23)
        Me.ucrChkRowHeader.TabIndex = 27
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(62, 323)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 31
        '
        'rdoColumns
        '
        Me.rdoColumns.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColumns.FlatAppearance.BorderSize = 2
        Me.rdoColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoColumns.Location = New System.Drawing.Point(278, 9)
        Me.rdoColumns.Name = "rdoColumns"
        Me.rdoColumns.Size = New System.Drawing.Size(99, 27)
        Me.rdoColumns.TabIndex = 39
        Me.rdoColumns.TabStop = True
        Me.rdoColumns.Text = "Columns"
        Me.rdoColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColumns.UseVisualStyleBackColor = True
        '
        'rdoDataFrame
        '
        Me.rdoDataFrame.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDataFrame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataFrame.FlatAppearance.BorderSize = 2
        Me.rdoDataFrame.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDataFrame.Location = New System.Drawing.Point(176, 9)
        Me.rdoDataFrame.Name = "rdoDataFrame"
        Me.rdoDataFrame.Size = New System.Drawing.Size(105, 27)
        Me.rdoDataFrame.TabIndex = 38
        Me.rdoDataFrame.TabStop = True
        Me.rdoDataFrame.Text = "Data Frame"
        Me.rdoDataFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDataFrame.UseVisualStyleBackColor = True
        '
        'ucrPnl
        '
        Me.ucrPnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnl.Location = New System.Drawing.Point(134, 7)
        Me.ucrPnl.Name = "ucrPnl"
        Me.ucrPnl.Size = New System.Drawing.Size(286, 29)
        Me.ucrPnl.TabIndex = 37
        '
        'ucrChkKeepExstingCols
        '
        Me.ucrChkKeepExstingCols.AutoSize = True
        Me.ucrChkKeepExstingCols.Checked = False
        Me.ucrChkKeepExstingCols.Location = New System.Drawing.Point(170, 287)
        Me.ucrChkKeepExstingCols.Name = "ucrChkKeepExstingCols"
        Me.ucrChkKeepExstingCols.Size = New System.Drawing.Size(183, 23)
        Me.ucrChkKeepExstingCols.TabIndex = 40
        '
        'dlgPasteNewColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(585, 383)
        Me.Controls.Add(Me.ucrChkKeepExstingCols)
        Me.Controls.Add(Me.rdoColumns)
        Me.Controls.Add(Me.rdoDataFrame)
        Me.Controls.Add(Me.ucrPnl)
        Me.Controls.Add(Me.panelNoDataPreview)
        Me.Controls.Add(Me.lblConfirmText)
        Me.Controls.Add(Me.lblLinesToPreview)
        Me.Controls.Add(Me.lblPreviewHeader)
        Me.Controls.Add(Me.btnRefreshPreview)
        Me.Controls.Add(Me.grdDataPreview)
        Me.Controls.Add(Me.ucrSaveNewDFName)
        Me.Controls.Add(Me.ucrNudPreviewLines)
        Me.Controls.Add(Me.ucrChkRowHeader)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrDFSelected)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "dlgPasteNewColumns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paste New"
        Me.panelNoDataPreview.ResumeLayout(False)
        Me.panelNoDataPreview.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrDFSelected As ucrDataFrame
    Friend WithEvents panelNoDataPreview As Panel
    Friend WithEvents lblNoDataPreview As Label
    Friend WithEvents lblConfirmText As Label
    Friend WithEvents lblLinesToPreview As Label
    Friend WithEvents lblPreviewHeader As Label
    Friend WithEvents btnRefreshPreview As Button
    Friend WithEvents grdDataPreview As unvell.ReoGrid.ReoGridControl
    Friend WithEvents ucrSaveNewDFName As ucrSave
    Friend WithEvents ucrNudPreviewLines As ucrNud
    Friend WithEvents ucrChkRowHeader As ucrCheck
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoColumns As RadioButton
    Friend WithEvents rdoDataFrame As RadioButton
    Friend WithEvents ucrPnl As UcrPanel
    Friend WithEvents ucrChkKeepExstingCols As ucrCheck
End Class
