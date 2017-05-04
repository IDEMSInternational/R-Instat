<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgExportRWorkspace
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
        Me.ucrSelectorForDataFrames = New instat.ucrSelector()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.ucrChkMetadata = New instat.ucrCheck()
        Me.ucrChkModels = New instat.ucrCheck()
        Me.ucrChkGraphs = New instat.ucrCheck()
        Me.ucrInputExportFile = New instat.ucrInputTextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(5, 260)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(398, 52)
        Me.ucrBase.TabIndex = 2
        '
        'ucrSelectorForDataFrames
        '
        Me.ucrSelectorForDataFrames.bShowHiddenColumns = False
        Me.ucrSelectorForDataFrames.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForDataFrames.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDataFrames.Name = "ucrSelectorForDataFrames"
        Me.ucrSelectorForDataFrames.Size = New System.Drawing.Size(120, 130)
        Me.ucrSelectorForDataFrames.TabIndex = 3
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.frmParent = Me
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(230, 25)
        Me.ucrReceiverMultiple.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Selector = Nothing
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultiple.TabIndex = 4
        Me.ucrReceiverMultiple.ucrSelector = Nothing
        '
        'ucrChkMetadata
        '
        Me.ucrChkMetadata.Checked = False
        Me.ucrChkMetadata.Location = New System.Drawing.Point(10, 155)
        Me.ucrChkMetadata.Name = "ucrChkMetadata"
        Me.ucrChkMetadata.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMetadata.TabIndex = 5
        '
        'ucrChkModels
        '
        Me.ucrChkModels.Checked = False
        Me.ucrChkModels.Location = New System.Drawing.Point(10, 207)
        Me.ucrChkModels.Name = "ucrChkModels"
        Me.ucrChkModels.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkModels.TabIndex = 6
        '
        'ucrChkGraphs
        '
        Me.ucrChkGraphs.Checked = False
        Me.ucrChkGraphs.Location = New System.Drawing.Point(10, 181)
        Me.ucrChkGraphs.Name = "ucrChkGraphs"
        Me.ucrChkGraphs.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkGraphs.TabIndex = 7
        '
        'ucrInputExportFile
        '
        Me.ucrInputExportFile.AddQuotesIfUnrecognised = True
        Me.ucrInputExportFile.IsMultiline = False
        Me.ucrInputExportFile.IsReadOnly = False
        Me.ucrInputExportFile.Location = New System.Drawing.Point(64, 233)
        Me.ucrInputExportFile.Name = "ucrInputExportFile"
        Me.ucrInputExportFile.Size = New System.Drawing.Size(269, 21)
        Me.ucrInputExportFile.TabIndex = 13
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(339, 231)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(62, 23)
        Me.cmdBrowse.TabIndex = 14
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.Location = New System.Drawing.Point(2, 237)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(56, 13)
        Me.lblExport.TabIndex = 12
        Me.lblExport.Text = "Export file:"
        '
        'dlgExportRWorkspace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 316)
        Me.Controls.Add(Me.ucrInputExportFile)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.lblExport)
        Me.Controls.Add(Me.ucrChkGraphs)
        Me.Controls.Add(Me.ucrChkModels)
        Me.Controls.Add(Me.ucrChkMetadata)
        Me.Controls.Add(Me.ucrReceiverMultiple)
        Me.Controls.Add(Me.ucrSelectorForDataFrames)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportRWorkspace"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export R Workspace"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForDataFrames As ucrSelector
    Friend WithEvents ucrReceiverMultiple As ucrReceiverMultiple
    Friend WithEvents ucrChkGraphs As ucrCheck
    Friend WithEvents ucrChkModels As ucrCheck
    Friend WithEvents ucrChkMetadata As ucrCheck
    Friend WithEvents ucrInputExportFile As ucrInputTextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents lblExport As Label
End Class
