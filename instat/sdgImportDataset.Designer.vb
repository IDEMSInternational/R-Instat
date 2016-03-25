<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgImportExcel
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
        Me.cboAvailableSheets = New System.Windows.Forms.ComboBox()
        Me.lblSelectSheet = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.grdPreview = New unvell.ReoGrid.ReoGridControl()
        Me.lblDataFrame = New System.Windows.Forms.Label()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.lblStartRow = New System.Windows.Forms.Label()
        Me.lblColNames = New System.Windows.Forms.Label()
        Me.lblDetectDates = New System.Windows.Forms.Label()
        Me.lblSkipEmptyRows = New System.Windows.Forms.Label()
        Me.lblCheckNames = New System.Windows.Forms.Label()
        Me.lblNamedRegion = New System.Windows.Forms.Label()
        Me.nudStartRow = New System.Windows.Forms.NumericUpDown()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.txtRegionName = New System.Windows.Forms.TextBox()
        Me.chkSkipEmptyRows = New System.Windows.Forms.CheckBox()
        Me.chkColumnNames = New System.Windows.Forms.CheckBox()
        Me.chkDates = New System.Windows.Forms.CheckBox()
        Me.chkNames = New System.Windows.Forms.CheckBox()
        CType(Me.nudStartRow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboAvailableSheets
        '
        Me.cboAvailableSheets.FormattingEnabled = True
        Me.cboAvailableSheets.Location = New System.Drawing.Point(129, 65)
        Me.cboAvailableSheets.Name = "cboAvailableSheets"
        Me.cboAvailableSheets.Size = New System.Drawing.Size(121, 21)
        Me.cboAvailableSheets.TabIndex = 0
        '
        'lblSelectSheet
        '
        Me.lblSelectSheet.AutoSize = True
        Me.lblSelectSheet.Location = New System.Drawing.Point(12, 65)
        Me.lblSelectSheet.Name = "lblSelectSheet"
        Me.lblSelectSheet.Size = New System.Drawing.Size(101, 13)
        Me.lblSelectSheet.TabIndex = 2
        Me.lblSelectSheet.Text = "Select sheet to load"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(268, 258)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 3
        '
        'grdPreview
        '
        Me.grdPreview.BackColor = System.Drawing.Color.White
        Me.grdPreview.ColumnHeaderContextMenuStrip = Nothing
        Me.grdPreview.LeadHeaderContextMenuStrip = Nothing
        Me.grdPreview.Location = New System.Drawing.Point(256, 27)
        Me.grdPreview.Name = "grdPreview"
        Me.grdPreview.Readonly = True
        Me.grdPreview.RowHeaderContextMenuStrip = Nothing
        Me.grdPreview.Script = Nothing
        Me.grdPreview.SheetTabContextMenuStrip = Nothing
        Me.grdPreview.SheetTabNewButtonVisible = False
        Me.grdPreview.SheetTabVisible = True
        Me.grdPreview.SheetTabWidth = 60
        Me.grdPreview.Size = New System.Drawing.Size(422, 225)
        Me.grdPreview.TabIndex = 30
        '
        'lblDataFrame
        '
        Me.lblDataFrame.AutoSize = True
        Me.lblDataFrame.Location = New System.Drawing.Point(253, 10)
        Me.lblDataFrame.Name = "lblDataFrame"
        Me.lblDataFrame.Size = New System.Drawing.Size(62, 13)
        Me.lblDataFrame.TabIndex = 29
        Me.lblDataFrame.Tag = "Data_Frame"
        Me.lblDataFrame.Text = "Data Frame"
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(12, 27)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(23, 13)
        Me.lblFile.TabIndex = 31
        Me.lblFile.Text = "File"
        '
        'lblStartRow
        '
        Me.lblStartRow.AutoSize = True
        Me.lblStartRow.Location = New System.Drawing.Point(12, 95)
        Me.lblStartRow.Name = "lblStartRow"
        Me.lblStartRow.Size = New System.Drawing.Size(61, 13)
        Me.lblStartRow.TabIndex = 32
        Me.lblStartRow.Text = "Start at row"
        '
        'lblColNames
        '
        Me.lblColNames.AutoSize = True
        Me.lblColNames.Location = New System.Drawing.Point(12, 127)
        Me.lblColNames.Name = "lblColNames"
        Me.lblColNames.Size = New System.Drawing.Size(76, 13)
        Me.lblColNames.TabIndex = 33
        Me.lblColNames.Text = "Column names"
        '
        'lblDetectDates
        '
        Me.lblDetectDates.AutoSize = True
        Me.lblDetectDates.Location = New System.Drawing.Point(12, 150)
        Me.lblDetectDates.Name = "lblDetectDates"
        Me.lblDetectDates.Size = New System.Drawing.Size(68, 13)
        Me.lblDetectDates.TabIndex = 35
        Me.lblDetectDates.Text = "Detect dates"
        '
        'lblSkipEmptyRows
        '
        Me.lblSkipEmptyRows.AutoSize = True
        Me.lblSkipEmptyRows.Location = New System.Drawing.Point(12, 181)
        Me.lblSkipEmptyRows.Name = "lblSkipEmptyRows"
        Me.lblSkipEmptyRows.Size = New System.Drawing.Size(90, 13)
        Me.lblSkipEmptyRows.TabIndex = 36
        Me.lblSkipEmptyRows.Text = "Skip Empty Rows"
        '
        'lblCheckNames
        '
        Me.lblCheckNames.AutoSize = True
        Me.lblCheckNames.Location = New System.Drawing.Point(12, 206)
        Me.lblCheckNames.Name = "lblCheckNames"
        Me.lblCheckNames.Size = New System.Drawing.Size(81, 13)
        Me.lblCheckNames.TabIndex = 39
        Me.lblCheckNames.Text = "Validate Names"
        '
        'lblNamedRegion
        '
        Me.lblNamedRegion.AutoSize = True
        Me.lblNamedRegion.Location = New System.Drawing.Point(12, 232)
        Me.lblNamedRegion.Name = "lblNamedRegion"
        Me.lblNamedRegion.Size = New System.Drawing.Size(119, 13)
        Me.lblNamedRegion.TabIndex = 40
        Me.lblNamedRegion.Text = "Named Region to load?"
        '
        'nudStartRow
        '
        Me.nudStartRow.Location = New System.Drawing.Point(204, 97)
        Me.nudStartRow.Name = "nudStartRow"
        Me.nudStartRow.Size = New System.Drawing.Size(46, 20)
        Me.nudStartRow.TabIndex = 43
        Me.nudStartRow.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(41, 20)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(206, 20)
        Me.txtFilePath.TabIndex = 44
        '
        'txtRegionName
        '
        Me.txtRegionName.Location = New System.Drawing.Point(150, 232)
        Me.txtRegionName.Name = "txtRegionName"
        Me.txtRegionName.ReadOnly = True
        Me.txtRegionName.Size = New System.Drawing.Size(100, 20)
        Me.txtRegionName.TabIndex = 45
        '
        'chkSkipEmptyRows
        '
        Me.chkSkipEmptyRows.AutoSize = True
        Me.chkSkipEmptyRows.Location = New System.Drawing.Point(169, 177)
        Me.chkSkipEmptyRows.Name = "chkSkipEmptyRows"
        Me.chkSkipEmptyRows.Size = New System.Drawing.Size(15, 14)
        Me.chkSkipEmptyRows.TabIndex = 46
        Me.chkSkipEmptyRows.UseVisualStyleBackColor = True
        '
        'chkColumnNames
        '
        Me.chkColumnNames.AutoSize = True
        Me.chkColumnNames.Location = New System.Drawing.Point(169, 123)
        Me.chkColumnNames.Name = "chkColumnNames"
        Me.chkColumnNames.Size = New System.Drawing.Size(15, 14)
        Me.chkColumnNames.TabIndex = 47
        Me.chkColumnNames.UseVisualStyleBackColor = True
        '
        'chkDates
        '
        Me.chkDates.AutoSize = True
        Me.chkDates.Location = New System.Drawing.Point(169, 146)
        Me.chkDates.Name = "chkDates"
        Me.chkDates.Size = New System.Drawing.Size(15, 14)
        Me.chkDates.TabIndex = 49
        Me.chkDates.UseVisualStyleBackColor = True
        '
        'chkNames
        '
        Me.chkNames.AutoSize = True
        Me.chkNames.Location = New System.Drawing.Point(169, 206)
        Me.chkNames.Name = "chkNames"
        Me.chkNames.Size = New System.Drawing.Size(15, 14)
        Me.chkNames.TabIndex = 50
        Me.chkNames.UseVisualStyleBackColor = True
        '
        'sdgImportExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(682, 316)
        Me.Controls.Add(Me.chkNames)
        Me.Controls.Add(Me.chkDates)
        Me.Controls.Add(Me.chkColumnNames)
        Me.Controls.Add(Me.chkSkipEmptyRows)
        Me.Controls.Add(Me.txtRegionName)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.nudStartRow)
        Me.Controls.Add(Me.lblNamedRegion)
        Me.Controls.Add(Me.lblCheckNames)
        Me.Controls.Add(Me.lblSkipEmptyRows)
        Me.Controls.Add(Me.lblDetectDates)
        Me.Controls.Add(Me.lblColNames)
        Me.Controls.Add(Me.lblStartRow)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.grdPreview)
        Me.Controls.Add(Me.lblDataFrame)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblSelectSheet)
        Me.Controls.Add(Me.cboAvailableSheets)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgImportExcel"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Open Excel File"
        CType(Me.nudStartRow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboAvailableSheets As ComboBox
    Friend WithEvents lblSelectSheet As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grdPreview As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblDataFrame As Label
    Friend WithEvents lblFile As Label
    Friend WithEvents lblStartRow As Label
    Friend WithEvents lblColNames As Label
    Friend WithEvents lblDetectDates As Label
    Friend WithEvents lblSkipEmptyRows As Label
    Friend WithEvents lblCheckNames As Label
    Friend WithEvents lblNamedRegion As Label
    Friend WithEvents nudStartRow As NumericUpDown
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents txtRegionName As TextBox
    Friend WithEvents chkSkipEmptyRows As CheckBox
    Friend WithEvents chkColumnNames As CheckBox
    Friend WithEvents chkDates As CheckBox
    Friend WithEvents chkNames As CheckBox
End Class
