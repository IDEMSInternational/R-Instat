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
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.grpSheetSelection = New System.Windows.Forms.GroupBox()
        Me.ucrAvailableSheets = New instat.ucrDataFrame()
        Me.grpSaveOptions.SuspendLayout()
        Me.grpSheetSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucrBase.Location = New System.Drawing.Point(12, 141)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(409, 53)
        Me.ucrBase.TabIndex = 0
        '
        'grpSaveOptions
        '
        Me.grpSaveOptions.Controls.Add(Me.ucrInputExportFile)
        Me.grpSaveOptions.Controls.Add(Me.cmdBrowse)
        Me.grpSaveOptions.Controls.Add(Me.lblExport)
        Me.grpSaveOptions.Location = New System.Drawing.Point(8, 69)
        Me.grpSaveOptions.Name = "grpSaveOptions"
        Me.grpSaveOptions.Size = New System.Drawing.Size(398, 56)
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
        Me.grpSheetSelection.Size = New System.Drawing.Size(398, 59)
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
        Me.ClientSize = New System.Drawing.Size(418, 206)
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
        Me.grpSheetSelection.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpSaveOptions As GroupBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents lblExport As Label
    Friend WithEvents grpSheetSelection As GroupBox
    Friend WithEvents ucrAvailableSheets As ucrDataFrame
    Friend WithEvents ucrInputExportFile As ucrInputTextBox
End Class
