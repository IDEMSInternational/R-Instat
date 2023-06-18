<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPasteNewDataFrame
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
        Me.grdDataPreview = New unvell.ReoGrid.ReoGridControl()
        Me.lblPreviewHeader = New System.Windows.Forms.Label()
        Me.btnRefreshPreview = New System.Windows.Forms.Button()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblLinesToPreview = New System.Windows.Forms.Label()
        Me.ucrNudPreviewLines = New instat.ucrNud()
        Me.ucrChkRowHeader = New instat.ucrCheck()
        Me.lblConfirmText = New System.Windows.Forms.Label()
        Me.ucrSaveNewDFName = New instat.ucrSave()
        Me.panelNoDataPreview = New System.Windows.Forms.Panel()
        Me.lblNoDataPreview = New System.Windows.Forms.Label()
        Me.panelNoDataPreview.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdDataPreview
        '
        Me.grdDataPreview.BackColor = System.Drawing.Color.White
        Me.grdDataPreview.ColumnHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.LeadHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.Location = New System.Drawing.Point(10, 35)
        Me.grdDataPreview.Name = "grdDataPreview"
        Me.grdDataPreview.Readonly = True
        Me.grdDataPreview.RowHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.Script = Nothing
        Me.grdDataPreview.SheetTabContextMenuStrip = Nothing
        Me.grdDataPreview.SheetTabNewButtonVisible = False
        Me.grdDataPreview.SheetTabVisible = True
        Me.grdDataPreview.SheetTabWidth = 60
        Me.grdDataPreview.ShowScrollEndSpacing = True
        Me.grdDataPreview.Size = New System.Drawing.Size(572, 166)
        Me.grdDataPreview.TabIndex = 14
        '
        'lblPreviewHeader
        '
        Me.lblPreviewHeader.AutoSize = True
        Me.lblPreviewHeader.Location = New System.Drawing.Point(10, 15)
        Me.lblPreviewHeader.Name = "lblPreviewHeader"
        Me.lblPreviewHeader.Size = New System.Drawing.Size(119, 13)
        Me.lblPreviewHeader.TabIndex = 18
        Me.lblPreviewHeader.Text = "Preview of copied data:"
        '
        'btnRefreshPreview
        '
        Me.btnRefreshPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRefreshPreview.Location = New System.Drawing.Point(470, 10)
        Me.btnRefreshPreview.Name = "btnRefreshPreview"
        Me.btnRefreshPreview.Size = New System.Drawing.Size(100, 23)
        Me.btnRefreshPreview.TabIndex = 3
        Me.btnRefreshPreview.Text = "Refresh Preview"
        Me.btnRefreshPreview.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 276)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 5
        '
        'lblLinesToPreview
        '
        Me.lblLinesToPreview.AutoSize = True
        Me.lblLinesToPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLinesToPreview.Location = New System.Drawing.Point(320, 15)
        Me.lblLinesToPreview.Name = "lblLinesToPreview"
        Me.lblLinesToPreview.Size = New System.Drawing.Size(88, 13)
        Me.lblLinesToPreview.TabIndex = 22
        Me.lblLinesToPreview.Text = "Lines to Preview:"
        '
        'ucrNudPreviewLines
        '
        Me.ucrNudPreviewLines.AutoSize = True
        Me.ucrNudPreviewLines.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreviewLines.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPreviewLines.Location = New System.Drawing.Point(413, 10)
        Me.ucrNudPreviewLines.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudPreviewLines.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.ucrNudPreviewLines.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ucrNudPreviewLines.Name = "ucrNudPreviewLines"
        Me.ucrNudPreviewLines.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPreviewLines.TabIndex = 2
        Me.ucrNudPreviewLines.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'ucrChkRowHeader
        '
        Me.ucrChkRowHeader.AutoSize = True
        Me.ucrChkRowHeader.Checked = False
        Me.ucrChkRowHeader.Location = New System.Drawing.Point(146, 12)
        Me.ucrChkRowHeader.Name = "ucrChkRowHeader"
        Me.ucrChkRowHeader.Size = New System.Drawing.Size(169, 23)
        Me.ucrChkRowHeader.TabIndex = 1
        '
        'lblConfirmText
        '
        Me.lblConfirmText.AutoSize = True
        Me.lblConfirmText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConfirmText.Location = New System.Drawing.Point(10, 215)
        Me.lblConfirmText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConfirmText.Name = "lblConfirmText"
        Me.lblConfirmText.Size = New System.Drawing.Size(189, 13)
        Me.lblConfirmText.TabIndex = 24
        Me.lblConfirmText.Text = "Click Ok to paste data to new columns"
        '
        'ucrSaveNewDFName
        '
        Me.ucrSaveNewDFName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewDFName.Location = New System.Drawing.Point(10, 243)
        Me.ucrSaveNewDFName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveNewDFName.Name = "ucrSaveNewDFName"
        Me.ucrSaveNewDFName.Size = New System.Drawing.Size(246, 24)
        Me.ucrSaveNewDFName.TabIndex = 4
        '
        'panelNoDataPreview
        '
        Me.panelNoDataPreview.Controls.Add(Me.lblNoDataPreview)
        Me.panelNoDataPreview.Location = New System.Drawing.Point(10, 35)
        Me.panelNoDataPreview.Name = "panelNoDataPreview"
        Me.panelNoDataPreview.Size = New System.Drawing.Size(572, 166)
        Me.panelNoDataPreview.TabIndex = 26
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
        'dlgPasteNewDataFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(599, 339)
        Me.Controls.Add(Me.panelNoDataPreview)
        Me.Controls.Add(Me.ucrSaveNewDFName)
        Me.Controls.Add(Me.lblConfirmText)
        Me.Controls.Add(Me.lblLinesToPreview)
        Me.Controls.Add(Me.ucrNudPreviewLines)
        Me.Controls.Add(Me.ucrChkRowHeader)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblPreviewHeader)
        Me.Controls.Add(Me.btnRefreshPreview)
        Me.Controls.Add(Me.grdDataPreview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "dlgPasteNewDataFrame"
        Me.Text = "Paste Data to New Data Frame"
        Me.panelNoDataPreview.ResumeLayout(False)
        Me.panelNoDataPreview.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdDataPreview As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblPreviewHeader As Label
    Friend WithEvents btnRefreshPreview As Button
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblLinesToPreview As Label
    Friend WithEvents ucrNudPreviewLines As ucrNud
    Friend WithEvents ucrChkRowHeader As ucrCheck
    Friend WithEvents lblConfirmText As Label
    Friend WithEvents ucrSaveNewDFName As ucrSave
    Friend WithEvents panelNoDataPreview As Panel
    Friend WithEvents lblNoDataPreview As Label
End Class
