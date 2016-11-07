<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgExportDataset
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
        Me.ucrBase = New instat.ucrButtons()
        Me.grpSaveOptions = New System.Windows.Forms.GroupBox()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.txtCols = New System.Windows.Forms.TextBox()
        Me.txtRows = New System.Windows.Forms.TextBox()
        Me.lblCols = New System.Windows.Forms.Label()
        Me.lblRows = New System.Windows.Forms.Label()
        Me.chkRowNames = New System.Windows.Forms.CheckBox()
        Me.chkColNames = New System.Windows.Forms.CheckBox()
        Me.txtSheetName = New System.Windows.Forms.TextBox()
        Me.lblSheetName = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.chkOptions = New System.Windows.Forms.CheckBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.txtExportFile = New System.Windows.Forms.TextBox()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.grpSheetSelection = New System.Windows.Forms.GroupBox()
        Me.ucrAvailableSheets = New instat.ucrDataFrame()
        Me.grpSaveOptions.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.grpSheetSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucrBase.Location = New System.Drawing.Point(11, 264)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(409, 53)
        Me.ucrBase.TabIndex = 0
        '
        'grpSaveOptions
        '
        Me.grpSaveOptions.Controls.Add(Me.grpOptions)
        Me.grpSaveOptions.Controls.Add(Me.chkOptions)
        Me.grpSaveOptions.Controls.Add(Me.cmdBrowse)
        Me.grpSaveOptions.Controls.Add(Me.txtExportFile)
        Me.grpSaveOptions.Controls.Add(Me.lblExport)
        Me.grpSaveOptions.Location = New System.Drawing.Point(10, 89)
        Me.grpSaveOptions.Name = "grpSaveOptions"
        Me.grpSaveOptions.Size = New System.Drawing.Size(398, 171)
        Me.grpSaveOptions.TabIndex = 1
        Me.grpSaveOptions.TabStop = False
        Me.grpSaveOptions.Text = ""
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.txtCols)
        Me.grpOptions.Controls.Add(Me.txtRows)
        Me.grpOptions.Controls.Add(Me.lblCols)
        Me.grpOptions.Controls.Add(Me.lblRows)
        Me.grpOptions.Controls.Add(Me.chkRowNames)
        Me.grpOptions.Controls.Add(Me.chkColNames)
        Me.grpOptions.Controls.Add(Me.txtSheetName)
        Me.grpOptions.Controls.Add(Me.lblSheetName)
        Me.grpOptions.Controls.Add(Me.txtAuthor)
        Me.grpOptions.Controls.Add(Me.lblAuthor)
        Me.grpOptions.Location = New System.Drawing.Point(6, 72)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(386, 93)
        Me.grpOptions.TabIndex = 6
        Me.grpOptions.TabStop = False
        '
        'txtCols
        '
        Me.txtCols.Location = New System.Drawing.Point(269, 36)
        Me.txtCols.Name = "txtCols"
        Me.txtCols.Size = New System.Drawing.Size(100, 20)
        Me.txtCols.TabIndex = 9
        '
        'txtRows
        '
        Me.txtRows.Location = New System.Drawing.Point(269, 13)
        Me.txtRows.Name = "txtRows"
        Me.txtRows.Size = New System.Drawing.Size(100, 20)
        Me.txtRows.TabIndex = 8
        '
        'lblCols
        '
        Me.lblCols.AutoSize = True
        Me.lblCols.Location = New System.Drawing.Point(185, 39)
        Me.lblCols.Name = "lblCols"
        Me.lblCols.Size = New System.Drawing.Size(70, 13)
        Me.lblCols.TabIndex = 7
        Me.lblCols.Text = "Start Column:"
        '
        'lblRows
        '
        Me.lblRows.AutoSize = True
        Me.lblRows.Location = New System.Drawing.Point(185, 16)
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Size = New System.Drawing.Size(57, 13)
        Me.lblRows.TabIndex = 6
        Me.lblRows.Text = "Start Row:"
        '
        'chkRowNames
        '
        Me.chkRowNames.AutoSize = True
        Me.chkRowNames.Location = New System.Drawing.Point(188, 62)
        Me.chkRowNames.Name = "chkRowNames"
        Me.chkRowNames.Size = New System.Drawing.Size(106, 17)
        Me.chkRowNames.TabIndex = 5
        Me.chkRowNames.Text = "Use Row Names"
        Me.chkRowNames.UseVisualStyleBackColor = True
        '
        'chkColNames
        '
        Me.chkColNames.AutoSize = True
        Me.chkColNames.Location = New System.Drawing.Point(6, 62)
        Me.chkColNames.Name = "chkColNames"
        Me.chkColNames.Size = New System.Drawing.Size(119, 17)
        Me.chkColNames.TabIndex = 4
        Me.chkColNames.Text = "Use Column Names"
        Me.chkColNames.UseVisualStyleBackColor = True
        '
        'txtSheetName
        '
        Me.txtSheetName.Location = New System.Drawing.Point(74, 36)
        Me.txtSheetName.Name = "txtSheetName"
        Me.txtSheetName.Size = New System.Drawing.Size(100, 20)
        Me.txtSheetName.TabIndex = 3
        '
        'lblSheetName
        '
        Me.lblSheetName.AutoSize = True
        Me.lblSheetName.Location = New System.Drawing.Point(5, 39)
        Me.lblSheetName.Name = "lblSheetName"
        Me.lblSheetName.Size = New System.Drawing.Size(67, 13)
        Me.lblSheetName.TabIndex = 2
        Me.lblSheetName.Text = "Sheet name:"
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(74, 13)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(100, 20)
        Me.txtAuthor.TabIndex = 1
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(5, 16)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(41, 13)
        Me.lblAuthor.TabIndex = 0
        Me.lblAuthor.Text = "Author:"
        '
        'chkOptions
        '
        Me.chkOptions.AutoSize = True
        Me.chkOptions.Location = New System.Drawing.Point(12, 50)
        Me.chkOptions.Name = "chkOptions"
        Me.chkOptions.Size = New System.Drawing.Size(109, 17)
        Me.chkOptions.TabIndex = 5
        Me.chkOptions.Text = "Additional options"
        Me.chkOptions.UseVisualStyleBackColor = True
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(331, 23)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(62, 23)
        Me.cmdBrowse.TabIndex = 2
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'txtExportFile
        '
        Me.txtExportFile.Location = New System.Drawing.Point(68, 24)
        Me.txtExportFile.Name = "txtExportFile"
        Me.txtExportFile.Size = New System.Drawing.Size(257, 20)
        Me.txtExportFile.TabIndex = 4
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.Location = New System.Drawing.Point(11, 27)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(56, 13)
        Me.lblExport.TabIndex = 3
        Me.lblExport.Text = "Export file:"
        '
        'grpSheetSelection
        '
        Me.grpSheetSelection.Controls.Add(Me.ucrAvailableSheets)
        Me.grpSheetSelection.Location = New System.Drawing.Point(10, 10)
        Me.grpSheetSelection.Name = "grpSheetSelection"
        Me.grpSheetSelection.Size = New System.Drawing.Size(398, 69)
        Me.grpSheetSelection.TabIndex = 0
        Me.grpSheetSelection.TabStop = False
        Me.grpSheetSelection.Text = "Select Data Frame to Export"
        '
        'ucrAvailableSheets
        '
        Me.ucrAvailableSheets.bUseCurrentFilter = True
        Me.ucrAvailableSheets.Location = New System.Drawing.Point(6, 19)
        Me.ucrAvailableSheets.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAvailableSheets.Name = "ucrAvailableSheets"
        Me.ucrAvailableSheets.Size = New System.Drawing.Size(127, 41)
        Me.ucrAvailableSheets.TabIndex = 0
        '
        'dlgExportDataset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 329)
        Me.Controls.Add(Me.grpSheetSelection)
        Me.Controls.Add(Me.grpSaveOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportDataset"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Export Datasets"
        Me.grpSaveOptions.ResumeLayout(False)
        Me.grpSaveOptions.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpSheetSelection.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpSaveOptions As GroupBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents txtExportFile As TextBox
    Friend WithEvents lblExport As Label
    Friend WithEvents grpSheetSelection As GroupBox
    Friend WithEvents ucrAvailableSheets As ucrDataFrame
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents txtCols As TextBox
    Friend WithEvents txtRows As TextBox
    Friend WithEvents lblCols As Label
    Friend WithEvents lblRows As Label
    Friend WithEvents chkRowNames As CheckBox
    Friend WithEvents chkColNames As CheckBox
    Friend WithEvents txtSheetName As TextBox
    Friend WithEvents lblSheetName As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents lblAuthor As Label
    Friend WithEvents chkOptions As CheckBox
End Class
