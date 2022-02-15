<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPasteNewColumns
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Me.lblConfirmText = New System.Windows.Forms.Label()
        Me.grdDataPreview = New unvell.ReoGrid.ReoGridControl()
        Me.btnRefreshPreview = New System.Windows.Forms.Button()
        Me.panelNoDataPreview = New System.Windows.Forms.Panel()
        Me.lblNoDataPreview = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkRowHeader = New instat.ucrCheck()
        Me.ucrDataFrameSelected = New instat.ucrDataFrame()
        Me.lblLinesToPreview = New System.Windows.Forms.Label()
        Me.ucrNudPreviewLines = New instat.ucrNud()
        Me.lblPreviewHeader = New System.Windows.Forms.Label()
        Me.panelNoDataPreview.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblConfirmText
        '
        Me.lblConfirmText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConfirmText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConfirmText.Location = New System.Drawing.Point(7, 95)
        Me.lblConfirmText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConfirmText.Name = "lblConfirmText"
        Me.lblConfirmText.Size = New System.Drawing.Size(201, 108)
        Me.lblConfirmText.TabIndex = 5
        Me.lblConfirmText.Text = "Click Ok to paste data to new columns"
        '
        'grdDataPreview
        '
        Me.grdDataPreview.BackColor = System.Drawing.Color.White
        Me.grdDataPreview.ColumnHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.LeadHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.Location = New System.Drawing.Point(228, 37)
        Me.grdDataPreview.Name = "grdDataPreview"
        Me.grdDataPreview.Readonly = True
        Me.grdDataPreview.RowHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.Script = Nothing
        Me.grdDataPreview.SheetTabContextMenuStrip = Nothing
        Me.grdDataPreview.SheetTabNewButtonVisible = False
        Me.grdDataPreview.SheetTabVisible = True
        Me.grdDataPreview.SheetTabWidth = 60
        Me.grdDataPreview.ShowScrollEndSpacing = True
        Me.grdDataPreview.Size = New System.Drawing.Size(404, 166)
        Me.grdDataPreview.TabIndex = 13
        '
        'btnRefreshPreview
        '
        Me.btnRefreshPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRefreshPreview.Location = New System.Drawing.Point(531, 11)
        Me.btnRefreshPreview.Name = "btnRefreshPreview"
        Me.btnRefreshPreview.Size = New System.Drawing.Size(100, 23)
        Me.btnRefreshPreview.TabIndex = 17
        Me.btnRefreshPreview.Text = "Refresh Preview"
        Me.btnRefreshPreview.UseVisualStyleBackColor = True
        '
        'panelNoDataPreview
        '
        Me.panelNoDataPreview.Controls.Add(Me.lblNoDataPreview)
        Me.panelNoDataPreview.Location = New System.Drawing.Point(228, 37)
        Me.panelNoDataPreview.Name = "panelNoDataPreview"
        Me.panelNoDataPreview.Size = New System.Drawing.Size(402, 166)
        Me.panelNoDataPreview.TabIndex = 18
        '
        'lblNoDataPreview
        '
        Me.lblNoDataPreview.AutoSize = True
        Me.lblNoDataPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoDataPreview.Location = New System.Drawing.Point(121, 64)
        Me.lblNoDataPreview.Name = "lblNoDataPreview"
        Me.lblNoDataPreview.Size = New System.Drawing.Size(168, 25)
        Me.lblNoDataPreview.TabIndex = 0
        Me.lblNoDataPreview.Text = "No Data Loaded"
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 214)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 6
        '
        'ucrChkRowHeader
        '
        Me.ucrChkRowHeader.AutoSize = True
        Me.ucrChkRowHeader.Checked = False
        Me.ucrChkRowHeader.Location = New System.Drawing.Point(10, 65)
        Me.ucrChkRowHeader.Name = "ucrChkRowHeader"
        Me.ucrChkRowHeader.Size = New System.Drawing.Size(198, 23)
        Me.ucrChkRowHeader.TabIndex = 1
        '
        'ucrDataFrameSelected
        '
        Me.ucrDataFrameSelected.AutoSize = True
        Me.ucrDataFrameSelected.bDropUnusedFilterLevels = False
        Me.ucrDataFrameSelected.bUseCurrentFilter = True
        Me.ucrDataFrameSelected.Location = New System.Drawing.Point(10, 9)
        Me.ucrDataFrameSelected.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameSelected.Name = "ucrDataFrameSelected"
        Me.ucrDataFrameSelected.Size = New System.Drawing.Size(151, 50)
        Me.ucrDataFrameSelected.TabIndex = 0
        '
        'lblLinesToPreview
        '
        Me.lblLinesToPreview.AutoSize = True
        Me.lblLinesToPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLinesToPreview.Location = New System.Drawing.Point(374, 17)
        Me.lblLinesToPreview.Name = "lblLinesToPreview"
        Me.lblLinesToPreview.Size = New System.Drawing.Size(88, 13)
        Me.lblLinesToPreview.TabIndex = 19
        Me.lblLinesToPreview.Text = "Lines to Preview:"
        '
        'ucrNudPreviewLines
        '
        Me.ucrNudPreviewLines.AutoSize = True
        Me.ucrNudPreviewLines.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreviewLines.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPreviewLines.Location = New System.Drawing.Point(473, 13)
        Me.ucrNudPreviewLines.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudPreviewLines.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.ucrNudPreviewLines.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ucrNudPreviewLines.Name = "ucrNudPreviewLines"
        Me.ucrNudPreviewLines.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPreviewLines.TabIndex = 20
        Me.ucrNudPreviewLines.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblPreviewHeader
        '
        Me.lblPreviewHeader.AutoSize = True
        Me.lblPreviewHeader.Location = New System.Drawing.Point(228, 17)
        Me.lblPreviewHeader.Name = "lblPreviewHeader"
        Me.lblPreviewHeader.Size = New System.Drawing.Size(119, 13)
        Me.lblPreviewHeader.TabIndex = 21
        Me.lblPreviewHeader.Text = "Preview of copied data:"
        '
        'dlgPasteNewColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(637, 273)
        Me.Controls.Add(Me.lblPreviewHeader)
        Me.Controls.Add(Me.lblLinesToPreview)
        Me.Controls.Add(Me.ucrNudPreviewLines)
        Me.Controls.Add(Me.btnRefreshPreview)
        Me.Controls.Add(Me.panelNoDataPreview)
        Me.Controls.Add(Me.grdDataPreview)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblConfirmText)
        Me.Controls.Add(Me.ucrChkRowHeader)
        Me.Controls.Add(Me.ucrDataFrameSelected)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "dlgPasteNewColumns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paste Data to New Column(s)"
        Me.panelNoDataPreview.ResumeLayout(False)
        Me.panelNoDataPreview.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrDataFrameSelected As ucrDataFrame
    Friend WithEvents ucrChkRowHeader As ucrCheck
    Friend WithEvents lblConfirmText As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grdDataPreview As unvell.ReoGrid.ReoGridControl
    Friend WithEvents btnRefreshPreview As Button
    Friend WithEvents panelNoDataPreview As Panel
    Friend WithEvents lblNoDataPreview As Label
    Friend WithEvents lblLinesToPreview As Label
    Friend WithEvents ucrNudPreviewLines As ucrNud
    Friend WithEvents lblPreviewHeader As Label
End Class
