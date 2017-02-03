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
        Me.ucrInputExportFile = New instat.ucrInputTextBox()
        Me.ucrChkOptions = New instat.ucrCheck()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrInputCols = New instat.ucrInputTextBox()
        Me.ucrInputRows = New instat.ucrInputTextBox()
        Me.ucrInputSheetName = New instat.ucrInputTextBox()
        Me.ucrInputAuthor = New instat.ucrInputTextBox()
        Me.ucrChkUseRowNames = New instat.ucrCheck()
        Me.ucrChkUseColumnNames = New instat.ucrCheck()
        Me.lblCols = New System.Windows.Forms.Label()
        Me.lblRows = New System.Windows.Forms.Label()
        Me.lblSheetName = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
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
        Me.ucrBase.Location = New System.Drawing.Point(11, 267)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(409, 53)
        Me.ucrBase.TabIndex = 0
        '
        'grpSaveOptions
        '
        Me.grpSaveOptions.Controls.Add(Me.ucrInputExportFile)
        Me.grpSaveOptions.Controls.Add(Me.ucrChkOptions)
        Me.grpSaveOptions.Controls.Add(Me.grpOptions)
        Me.grpSaveOptions.Controls.Add(Me.cmdBrowse)
        Me.grpSaveOptions.Controls.Add(Me.lblExport)
        Me.grpSaveOptions.Location = New System.Drawing.Point(10, 89)
        Me.grpSaveOptions.Name = "grpSaveOptions"
        Me.grpSaveOptions.Size = New System.Drawing.Size(398, 171)
        Me.grpSaveOptions.TabIndex = 1
        Me.grpSaveOptions.TabStop = False
        '
        'ucrInputExportFile
        '
        Me.ucrInputExportFile.IsMultiline = False
        Me.ucrInputExportFile.IsReadOnly = False
        Me.ucrInputExportFile.Location = New System.Drawing.Point(69, 24)
        Me.ucrInputExportFile.Name = "ucrInputExportFile"
        Me.ucrInputExportFile.Size = New System.Drawing.Size(251, 21)
        Me.ucrInputExportFile.TabIndex = 8
        '
        'ucrChkOptions
        '
        Me.ucrChkOptions.Checked = False
        Me.ucrChkOptions.Location = New System.Drawing.Point(14, 50)
        Me.ucrChkOptions.Name = "ucrChkOptions"
        Me.ucrChkOptions.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkOptions.TabIndex = 7
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrInputCols)
        Me.grpOptions.Controls.Add(Me.ucrInputRows)
        Me.grpOptions.Controls.Add(Me.ucrInputSheetName)
        Me.grpOptions.Controls.Add(Me.ucrInputAuthor)
        Me.grpOptions.Controls.Add(Me.ucrChkUseRowNames)
        Me.grpOptions.Controls.Add(Me.ucrChkUseColumnNames)
        Me.grpOptions.Controls.Add(Me.lblCols)
        Me.grpOptions.Controls.Add(Me.lblRows)
        Me.grpOptions.Controls.Add(Me.lblSheetName)
        Me.grpOptions.Controls.Add(Me.lblAuthor)
        Me.grpOptions.Location = New System.Drawing.Point(6, 72)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(386, 93)
        Me.grpOptions.TabIndex = 6
        Me.grpOptions.TabStop = False
        '
        'ucrInputCols
        '
        Me.ucrInputCols.IsMultiline = False
        Me.ucrInputCols.IsReadOnly = False
        Me.ucrInputCols.Location = New System.Drawing.Point(269, 35)
        Me.ucrInputCols.Name = "ucrInputCols"
        Me.ucrInputCols.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputCols.TabIndex = 15
        '
        'ucrInputRows
        '
        Me.ucrInputRows.IsMultiline = False
        Me.ucrInputRows.IsReadOnly = False
        Me.ucrInputRows.Location = New System.Drawing.Point(269, 9)
        Me.ucrInputRows.Name = "ucrInputRows"
        Me.ucrInputRows.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputRows.TabIndex = 14
        '
        'ucrInputSheetName
        '
        Me.ucrInputSheetName.IsMultiline = False
        Me.ucrInputSheetName.IsReadOnly = False
        Me.ucrInputSheetName.Location = New System.Drawing.Point(74, 35)
        Me.ucrInputSheetName.Name = "ucrInputSheetName"
        Me.ucrInputSheetName.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputSheetName.TabIndex = 13
        '
        'ucrInputAuthor
        '
        Me.ucrInputAuthor.IsMultiline = False
        Me.ucrInputAuthor.IsReadOnly = False
        Me.ucrInputAuthor.Location = New System.Drawing.Point(74, 9)
        Me.ucrInputAuthor.Name = "ucrInputAuthor"
        Me.ucrInputAuthor.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputAuthor.TabIndex = 12
        '
        'ucrChkUseRowNames
        '
        Me.ucrChkUseRowNames.Checked = False
        Me.ucrChkUseRowNames.Location = New System.Drawing.Point(188, 62)
        Me.ucrChkUseRowNames.Name = "ucrChkUseRowNames"
        Me.ucrChkUseRowNames.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkUseRowNames.TabIndex = 11
        '
        'ucrChkUseColumnNames
        '
        Me.ucrChkUseColumnNames.Checked = False
        Me.ucrChkUseColumnNames.Location = New System.Drawing.Point(8, 62)
        Me.ucrChkUseColumnNames.Name = "ucrChkUseColumnNames"
        Me.ucrChkUseColumnNames.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkUseColumnNames.TabIndex = 10
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
        'lblSheetName
        '
        Me.lblSheetName.AutoSize = True
        Me.lblSheetName.Location = New System.Drawing.Point(5, 39)
        Me.lblSheetName.Name = "lblSheetName"
        Me.lblSheetName.Size = New System.Drawing.Size(67, 13)
        Me.lblSheetName.TabIndex = 2
        Me.lblSheetName.Text = "Sheet name:"
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
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(331, 23)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(62, 23)
        Me.cmdBrowse.TabIndex = 2
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
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
        Me.grpSheetSelection.Location = New System.Drawing.Point(8, 4)
        Me.grpSheetSelection.Name = "grpSheetSelection"
        Me.grpSheetSelection.Size = New System.Drawing.Size(398, 69)
        Me.grpSheetSelection.TabIndex = 0
        Me.grpSheetSelection.TabStop = False
        Me.grpSheetSelection.Text = "Select Data Frame to Export"
        '
        'ucrAvailableSheets
        '
        Me.ucrAvailableSheets.bUseCurrentFilter = True
        Me.ucrAvailableSheets.Location = New System.Drawing.Point(3, 16)
        Me.ucrAvailableSheets.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAvailableSheets.Name = "ucrAvailableSheets"
        Me.ucrAvailableSheets.Size = New System.Drawing.Size(127, 41)
        Me.ucrAvailableSheets.TabIndex = 0
        '
        'dlgExportDataset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 332)
        Me.Controls.Add(Me.grpSheetSelection)
        Me.Controls.Add(Me.grpSaveOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportDataset"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents lblExport As Label
    Friend WithEvents grpSheetSelection As GroupBox
    Friend WithEvents ucrAvailableSheets As ucrDataFrame
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents lblCols As Label
    Friend WithEvents lblRows As Label
    Friend WithEvents lblSheetName As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents ucrChkOptions As ucrCheck
    Friend WithEvents ucrChkUseRowNames As ucrCheck
    Friend WithEvents ucrChkUseColumnNames As ucrCheck
    Friend WithEvents ucrInputExportFile As ucrInputTextBox
    Friend WithEvents ucrInputCols As ucrInputTextBox
    Friend WithEvents ucrInputRows As ucrInputTextBox
    Friend WithEvents ucrInputSheetName As ucrInputTextBox
    Friend WithEvents ucrInputAuthor As ucrInputTextBox
End Class
