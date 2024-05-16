<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgGeneralTable
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnHeaderSubTitleFormat = New System.Windows.Forms.Button()
        Me.btnHeaderTitleFormat = New System.Windows.Forms.Button()
        Me.ucrInputHeaderSubtitle = New instat.ucrInputTextBox()
        Me.ucrInputHeaderTitle = New instat.ucrInputTextBox()
        Me.lblHeaderSubtitle = New System.Windows.Forms.Label()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.ucrSelectorCols = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverMultipleCols = New instat.ucrReceiverMultiple()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.btnMoreOptions = New System.Windows.Forms.Button()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrReceiverSingleGroupByCol = New instat.ucrReceiverSingle()
        Me.lblGroupByCol = New System.Windows.Forms.Label()
        Me.ucrChkPreview = New instat.ucrCheck()
        Me.ucrNudPreview = New instat.ucrNud()
        Me.SuspendLayout()
        '
        'btnHeaderSubTitleFormat
        '
        Me.btnHeaderSubTitleFormat.Location = New System.Drawing.Point(393, 71)
        Me.btnHeaderSubTitleFormat.Name = "btnHeaderSubTitleFormat"
        Me.btnHeaderSubTitleFormat.Size = New System.Drawing.Size(75, 23)
        Me.btnHeaderSubTitleFormat.TabIndex = 19
        Me.btnHeaderSubTitleFormat.Text = "Format"
        Me.btnHeaderSubTitleFormat.UseVisualStyleBackColor = True
        '
        'btnHeaderTitleFormat
        '
        Me.btnHeaderTitleFormat.Location = New System.Drawing.Point(393, 29)
        Me.btnHeaderTitleFormat.Name = "btnHeaderTitleFormat"
        Me.btnHeaderTitleFormat.Size = New System.Drawing.Size(79, 23)
        Me.btnHeaderTitleFormat.TabIndex = 18
        Me.btnHeaderTitleFormat.Text = "Format"
        Me.btnHeaderTitleFormat.UseVisualStyleBackColor = True
        '
        'ucrInputHeaderSubtitle
        '
        Me.ucrInputHeaderSubtitle.AddQuotesIfUnrecognised = True
        Me.ucrInputHeaderSubtitle.AutoSize = True
        Me.ucrInputHeaderSubtitle.IsMultiline = False
        Me.ucrInputHeaderSubtitle.IsReadOnly = False
        Me.ucrInputHeaderSubtitle.Location = New System.Drawing.Point(249, 73)
        Me.ucrInputHeaderSubtitle.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputHeaderSubtitle.Name = "ucrInputHeaderSubtitle"
        Me.ucrInputHeaderSubtitle.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputHeaderSubtitle.TabIndex = 17
        '
        'ucrInputHeaderTitle
        '
        Me.ucrInputHeaderTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputHeaderTitle.AutoSize = True
        Me.ucrInputHeaderTitle.IsMultiline = False
        Me.ucrInputHeaderTitle.IsReadOnly = False
        Me.ucrInputHeaderTitle.Location = New System.Drawing.Point(249, 29)
        Me.ucrInputHeaderTitle.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputHeaderTitle.Name = "ucrInputHeaderTitle"
        Me.ucrInputHeaderTitle.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputHeaderTitle.TabIndex = 16
        '
        'lblHeaderSubtitle
        '
        Me.lblHeaderSubtitle.AutoSize = True
        Me.lblHeaderSubtitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeaderSubtitle.Location = New System.Drawing.Point(246, 56)
        Me.lblHeaderSubtitle.Name = "lblHeaderSubtitle"
        Me.lblHeaderSubtitle.Size = New System.Drawing.Size(45, 13)
        Me.lblHeaderSubtitle.TabIndex = 15
        Me.lblHeaderSubtitle.Text = "Subtitle:"
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeaderTitle.Location = New System.Drawing.Point(246, 9)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblHeaderTitle.TabIndex = 14
        Me.lblHeaderTitle.Text = "Title:"
        '
        'ucrSelectorCols
        '
        Me.ucrSelectorCols.AutoSize = True
        Me.ucrSelectorCols.bDropUnusedFilterLevels = False
        Me.ucrSelectorCols.bShowHiddenColumns = False
        Me.ucrSelectorCols.bUseCurrentFilter = True
        Me.ucrSelectorCols.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCols.Name = "ucrSelectorCols"
        Me.ucrSelectorCols.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorCols.TabIndex = 22
        '
        'ucrReceiverMultipleCols
        '
        Me.ucrReceiverMultipleCols.AutoSize = True
        Me.ucrReceiverMultipleCols.frmParent = Me
        Me.ucrReceiverMultipleCols.Location = New System.Drawing.Point(250, 113)
        Me.ucrReceiverMultipleCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleCols.Name = "ucrReceiverMultipleCols"
        Me.ucrReceiverMultipleCols.Selector = Nothing
        Me.ucrReceiverMultipleCols.Size = New System.Drawing.Size(141, 100)
        Me.ucrReceiverMultipleCols.strNcFilePath = ""
        Me.ucrReceiverMultipleCols.TabIndex = 23
        Me.ucrReceiverMultipleCols.ucrSelector = Nothing
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(247, 100)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(50, 13)
        Me.lblColumns.TabIndex = 24
        Me.lblColumns.Text = "Columns:"
        '
        'btnMoreOptions
        '
        Me.btnMoreOptions.Location = New System.Drawing.Point(9, 246)
        Me.btnMoreOptions.Name = "btnMoreOptions"
        Me.btnMoreOptions.Size = New System.Drawing.Size(114, 23)
        Me.btnMoreOptions.TabIndex = 25
        Me.btnMoreOptions.Text = "More Options"
        Me.btnMoreOptions.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 320)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 26
        '
        'ucrSaveTable
        '
        Me.ucrSaveTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTable.Location = New System.Drawing.Point(9, 289)
        Me.ucrSaveTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveTable.Name = "ucrSaveTable"
        Me.ucrSaveTable.Size = New System.Drawing.Size(319, 24)
        Me.ucrSaveTable.TabIndex = 27
        '
        'ucrReceiverSingleGroupByCol
        '
        Me.ucrReceiverSingleGroupByCol.AutoSize = True
        Me.ucrReceiverSingleGroupByCol.frmParent = Me
        Me.ucrReceiverSingleGroupByCol.Location = New System.Drawing.Point(249, 236)
        Me.ucrReceiverSingleGroupByCol.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleGroupByCol.Name = "ucrReceiverSingleGroupByCol"
        Me.ucrReceiverSingleGroupByCol.Selector = Nothing
        Me.ucrReceiverSingleGroupByCol.Size = New System.Drawing.Size(142, 20)
        Me.ucrReceiverSingleGroupByCol.strNcFilePath = ""
        Me.ucrReceiverSingleGroupByCol.TabIndex = 28
        Me.ucrReceiverSingleGroupByCol.ucrSelector = Nothing
        '
        'lblGroupByCol
        '
        Me.lblGroupByCol.AutoSize = True
        Me.lblGroupByCol.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroupByCol.Location = New System.Drawing.Point(247, 222)
        Me.lblGroupByCol.Name = "lblGroupByCol"
        Me.lblGroupByCol.Size = New System.Drawing.Size(92, 13)
        Me.lblGroupByCol.TabIndex = 29
        Me.lblGroupByCol.Text = "Group By Column:"
        '
        'ucrChkPreview
        '
        Me.ucrChkPreview.AutoSize = True
        Me.ucrChkPreview.Checked = False
        Me.ucrChkPreview.Location = New System.Drawing.Point(9, 210)
        Me.ucrChkPreview.Name = "ucrChkPreview"
        Me.ucrChkPreview.Size = New System.Drawing.Size(144, 23)
        Me.ucrChkPreview.TabIndex = 30
        '
        'ucrNudPreview
        '
        Me.ucrNudPreview.AutoSize = True
        Me.ucrNudPreview.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreview.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPreview.Location = New System.Drawing.Point(159, 210)
        Me.ucrNudPreview.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPreview.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreview.Name = "ucrNudPreview"
        Me.ucrNudPreview.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPreview.TabIndex = 31
        Me.ucrNudPreview.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgGeneralTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 378)
        Me.Controls.Add(Me.ucrNudPreview)
        Me.Controls.Add(Me.ucrChkPreview)
        Me.Controls.Add(Me.lblGroupByCol)
        Me.Controls.Add(Me.ucrReceiverSingleGroupByCol)
        Me.Controls.Add(Me.ucrSaveTable)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.btnMoreOptions)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrReceiverMultipleCols)
        Me.Controls.Add(Me.ucrSelectorCols)
        Me.Controls.Add(Me.btnHeaderSubTitleFormat)
        Me.Controls.Add(Me.btnHeaderTitleFormat)
        Me.Controls.Add(Me.ucrInputHeaderSubtitle)
        Me.Controls.Add(Me.ucrInputHeaderTitle)
        Me.Controls.Add(Me.lblHeaderSubtitle)
        Me.Controls.Add(Me.lblHeaderTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgGeneralTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Table"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHeaderSubTitleFormat As Button
    Friend WithEvents btnHeaderTitleFormat As Button
    Friend WithEvents ucrInputHeaderSubtitle As ucrInputTextBox
    Friend WithEvents ucrInputHeaderTitle As ucrInputTextBox
    Friend WithEvents lblHeaderSubtitle As Label
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents ucrSelectorCols As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverMultipleCols As ucrReceiverMultiple
    Friend WithEvents btnMoreOptions As Button
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSaveTable As ucrSave
    Friend WithEvents lblGroupByCol As Label
    Friend WithEvents ucrReceiverSingleGroupByCol As ucrReceiverSingle
    Friend WithEvents ucrNudPreview As ucrNud
    Friend WithEvents ucrChkPreview As ucrCheck
End Class
