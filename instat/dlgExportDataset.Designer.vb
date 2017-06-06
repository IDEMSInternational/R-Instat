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
        Me.ucrInputExportFile = New instat.ucrInputTextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.ucrAvailableSheets = New instat.ucrDataFrame()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(8, 83)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(406, 53)
        Me.ucrBase.TabIndex = 4
        '
        'ucrInputExportFile
        '
        Me.ucrInputExportFile.AddQuotesIfUnrecognised = True
        Me.ucrInputExportFile.IsMultiline = False
        Me.ucrInputExportFile.IsReadOnly = False
        Me.ucrInputExportFile.Location = New System.Drawing.Point(89, 56)
        Me.ucrInputExportFile.Name = "ucrInputExportFile"
        Me.ucrInputExportFile.Size = New System.Drawing.Size(251, 21)
        Me.ucrInputExportFile.TabIndex = 2
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(343, 55)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(62, 23)
        Me.cmdBrowse.TabIndex = 3
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.Location = New System.Drawing.Point(8, 59)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(59, 13)
        Me.lblExport.TabIndex = 1
        Me.lblExport.Text = "Export File:"
        '
        'ucrAvailableSheets
        '
        Me.ucrAvailableSheets.bUseCurrentFilter = True
        Me.ucrAvailableSheets.Location = New System.Drawing.Point(8, 9)
        Me.ucrAvailableSheets.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAvailableSheets.Name = "ucrAvailableSheets"
        Me.ucrAvailableSheets.Size = New System.Drawing.Size(128, 41)
        Me.ucrAvailableSheets.TabIndex = 0
        '
        'dlgExportDataset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 138)
        Me.Controls.Add(Me.lblExport)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.ucrInputExportFile)
        Me.Controls.Add(Me.ucrAvailableSheets)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportDataset"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Datasets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents lblExport As Label
    Friend WithEvents ucrAvailableSheets As ucrDataFrame
    Friend WithEvents ucrInputExportFile As ucrInputTextBox
End Class
