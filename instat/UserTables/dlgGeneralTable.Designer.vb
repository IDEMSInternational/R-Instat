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
        Me.lblRowName = New System.Windows.Forms.Label()
        Me.ucrReceiverSingleRowName = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'btnHeaderSubTitleFormat
        '
        Me.btnHeaderSubTitleFormat.Location = New System.Drawing.Point(590, 109)
        Me.btnHeaderSubTitleFormat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHeaderSubTitleFormat.Name = "btnHeaderSubTitleFormat"
        Me.btnHeaderSubTitleFormat.Size = New System.Drawing.Size(112, 35)
        Me.btnHeaderSubTitleFormat.TabIndex = 19
        Me.btnHeaderSubTitleFormat.Text = "Format"
        Me.btnHeaderSubTitleFormat.UseVisualStyleBackColor = True
        '
        'btnHeaderTitleFormat
        '
        Me.btnHeaderTitleFormat.Location = New System.Drawing.Point(590, 45)
        Me.btnHeaderTitleFormat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHeaderTitleFormat.Name = "btnHeaderTitleFormat"
        Me.btnHeaderTitleFormat.Size = New System.Drawing.Size(118, 35)
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
        Me.ucrInputHeaderSubtitle.Location = New System.Drawing.Point(374, 112)
        Me.ucrInputHeaderSubtitle.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputHeaderSubtitle.Name = "ucrInputHeaderSubtitle"
        Me.ucrInputHeaderSubtitle.Size = New System.Drawing.Size(213, 32)
        Me.ucrInputHeaderSubtitle.TabIndex = 17
        '
        'ucrInputHeaderTitle
        '
        Me.ucrInputHeaderTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputHeaderTitle.AutoSize = True
        Me.ucrInputHeaderTitle.IsMultiline = False
        Me.ucrInputHeaderTitle.IsReadOnly = False
        Me.ucrInputHeaderTitle.Location = New System.Drawing.Point(374, 45)
        Me.ucrInputHeaderTitle.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputHeaderTitle.Name = "ucrInputHeaderTitle"
        Me.ucrInputHeaderTitle.Size = New System.Drawing.Size(213, 32)
        Me.ucrInputHeaderTitle.TabIndex = 16
        '
        'lblHeaderSubtitle
        '
        Me.lblHeaderSubtitle.AutoSize = True
        Me.lblHeaderSubtitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeaderSubtitle.Location = New System.Drawing.Point(369, 86)
        Me.lblHeaderSubtitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeaderSubtitle.Name = "lblHeaderSubtitle"
        Me.lblHeaderSubtitle.Size = New System.Drawing.Size(67, 20)
        Me.lblHeaderSubtitle.TabIndex = 15
        Me.lblHeaderSubtitle.Text = "Subtitle:"
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeaderTitle.Location = New System.Drawing.Point(369, 14)
        Me.lblHeaderTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(42, 20)
        Me.lblHeaderTitle.TabIndex = 14
        Me.lblHeaderTitle.Text = "Title:"
        '
        'ucrSelectorCols
        '
        Me.ucrSelectorCols.AutoSize = True
        Me.ucrSelectorCols.bDropUnusedFilterLevels = False
        Me.ucrSelectorCols.bShowHiddenColumns = False
        Me.ucrSelectorCols.bUseCurrentFilter = True
        Me.ucrSelectorCols.Location = New System.Drawing.Point(14, 14)
        Me.ucrSelectorCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCols.Name = "ucrSelectorCols"
        Me.ucrSelectorCols.Size = New System.Drawing.Size(320, 282)
        Me.ucrSelectorCols.TabIndex = 22
        '
        'ucrReceiverMultipleCols
        '
        Me.ucrReceiverMultipleCols.AutoSize = True
        Me.ucrReceiverMultipleCols.frmParent = Me
        Me.ucrReceiverMultipleCols.Location = New System.Drawing.Point(375, 174)
        Me.ucrReceiverMultipleCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleCols.Name = "ucrReceiverMultipleCols"
        Me.ucrReceiverMultipleCols.Selector = Nothing
        Me.ucrReceiverMultipleCols.Size = New System.Drawing.Size(212, 154)
        Me.ucrReceiverMultipleCols.strNcFilePath = ""
        Me.ucrReceiverMultipleCols.TabIndex = 23
        Me.ucrReceiverMultipleCols.ucrSelector = Nothing
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(370, 154)
        Me.lblColumns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(75, 20)
        Me.lblColumns.TabIndex = 24
        Me.lblColumns.Text = "Columns:"
        '
        'btnMoreOptions
        '
        Me.btnMoreOptions.Location = New System.Drawing.Point(2, 419)
        Me.btnMoreOptions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMoreOptions.Name = "btnMoreOptions"
        Me.btnMoreOptions.Size = New System.Drawing.Size(171, 35)
        Me.btnMoreOptions.TabIndex = 25
        Me.btnMoreOptions.Text = "More Options"
        Me.btnMoreOptions.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(14, 524)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(615, 80)
        Me.ucrBase.TabIndex = 26
        '
        'ucrSaveTable
        '
        Me.ucrSaveTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTable.Location = New System.Drawing.Point(14, 477)
        Me.ucrSaveTable.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveTable.Name = "ucrSaveTable"
        Me.ucrSaveTable.Size = New System.Drawing.Size(478, 37)
        Me.ucrSaveTable.TabIndex = 27
        '
        'ucrReceiverSingleGroupByCol
        '
        Me.ucrReceiverSingleGroupByCol.AutoSize = True
        Me.ucrReceiverSingleGroupByCol.frmParent = Me
        Me.ucrReceiverSingleGroupByCol.Location = New System.Drawing.Point(374, 423)
        Me.ucrReceiverSingleGroupByCol.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleGroupByCol.Name = "ucrReceiverSingleGroupByCol"
        Me.ucrReceiverSingleGroupByCol.Selector = Nothing
        Me.ucrReceiverSingleGroupByCol.Size = New System.Drawing.Size(213, 31)
        Me.ucrReceiverSingleGroupByCol.strNcFilePath = ""
        Me.ucrReceiverSingleGroupByCol.TabIndex = 28
        Me.ucrReceiverSingleGroupByCol.ucrSelector = Nothing
        '
        'lblGroupByCol
        '
        Me.lblGroupByCol.AutoSize = True
        Me.lblGroupByCol.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroupByCol.Location = New System.Drawing.Point(370, 402)
        Me.lblGroupByCol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGroupByCol.Name = "lblGroupByCol"
        Me.lblGroupByCol.Size = New System.Drawing.Size(120, 30)
        Me.lblGroupByCol.TabIndex = 29
        Me.lblGroupByCol.Text = "Group By:"
        '
        'ucrChkPreview
        '
        Me.ucrChkPreview.AutoSize = True
        Me.ucrChkPreview.Checked = False
        Me.ucrChkPreview.Location = New System.Drawing.Point(14, 323)
        Me.ucrChkPreview.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkPreview.Name = "ucrChkPreview"
        Me.ucrChkPreview.Size = New System.Drawing.Size(216, 35)
        Me.ucrChkPreview.TabIndex = 30
        '
        'ucrNudPreview
        '
        Me.ucrNudPreview.AutoSize = True
        Me.ucrNudPreview.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreview.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPreview.Location = New System.Drawing.Point(238, 323)
        Me.ucrNudPreview.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudPreview.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPreview.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreview.Name = "ucrNudPreview"
        Me.ucrNudPreview.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudPreview.TabIndex = 31
        Me.ucrNudPreview.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblRowName
        '
        Me.lblRowName.AutoSize = True
        Me.lblRowName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRowName.Location = New System.Drawing.Point(371, 338)
        Me.lblRowName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRowName.Name = "lblRowName"
        Me.lblRowName.Size = New System.Drawing.Size(137, 30)
        Me.lblRowName.TabIndex = 33
        Me.lblRowName.Text = "Row Name:"
        '
        'ucrReceiverSingleRowName
        '
        Me.ucrReceiverSingleRowName.AutoSize = True
        Me.ucrReceiverSingleRowName.frmParent = Me
        Me.ucrReceiverSingleRowName.Location = New System.Drawing.Point(375, 359)
        Me.ucrReceiverSingleRowName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleRowName.Name = "ucrReceiverSingleRowName"
        Me.ucrReceiverSingleRowName.Selector = Nothing
        Me.ucrReceiverSingleRowName.Size = New System.Drawing.Size(213, 31)
        Me.ucrReceiverSingleRowName.strNcFilePath = ""
        Me.ucrReceiverSingleRowName.TabIndex = 32
        Me.ucrReceiverSingleRowName.ucrSelector = Nothing
        '
        'dlgGeneralTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 615)
        Me.Controls.Add(Me.lblRowName)
        Me.Controls.Add(Me.ucrReceiverSingleRowName)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents lblRowName As Label
    Friend WithEvents ucrReceiverSingleRowName As ucrReceiverSingle
End Class
