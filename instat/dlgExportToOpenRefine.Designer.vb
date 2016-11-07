<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgExportToOpenRefine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.lblNameDataSet = New System.Windows.Forms.Label()
        Me.chkRefineBrowser = New System.Windows.Forms.CheckBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputDatasetName = New instat.ucrInputTextBox()
        Me.ucrOpenRefineDataFrame = New instat.ucrDataFrame()
        Me.UcrDialogDisabled1 = New instat.ucrDialogDisabled()
        Me.SuspendLayout()
        '
        'lblNameDataSet
        '
        Me.lblNameDataSet.AutoSize = True
        Me.lblNameDataSet.Location = New System.Drawing.Point(218, 14)
        Me.lblNameDataSet.Name = "lblNameDataSet"
        Me.lblNameDataSet.Size = New System.Drawing.Size(78, 13)
        Me.lblNameDataSet.TabIndex = 8
        Me.lblNameDataSet.Text = "Dataset Name:"
        '
        'chkRefineBrowser
        '
        Me.chkRefineBrowser.AutoSize = True
        Me.chkRefineBrowser.Location = New System.Drawing.Point(10, 76)
        Me.chkRefineBrowser.Name = "chkRefineBrowser"
        Me.chkRefineBrowser.Size = New System.Drawing.Size(93, 17)
        Me.chkRefineBrowser.TabIndex = 9
        Me.chkRefineBrowser.Text = "Open Browser"
        Me.chkRefineBrowser.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 99)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(407, 52)
        Me.ucrBase.TabIndex = 7
        '
        'ucrInputDatasetName
        '
        Me.ucrInputDatasetName.IsReadOnly = False
        Me.ucrInputDatasetName.Location = New System.Drawing.Point(217, 29)
        Me.ucrInputDatasetName.Name = "ucrInputDatasetName"
        Me.ucrInputDatasetName.Size = New System.Drawing.Size(149, 21)
        Me.ucrInputDatasetName.TabIndex = 5
        '
        'ucrOpenRefineDataFrame
        '
        Me.ucrOpenRefineDataFrame.bUseCurrentFilter = True
        Me.ucrOpenRefineDataFrame.Location = New System.Drawing.Point(10, 10)
        Me.ucrOpenRefineDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrOpenRefineDataFrame.Name = "ucrOpenRefineDataFrame"
        Me.ucrOpenRefineDataFrame.Size = New System.Drawing.Size(160, 40)
        Me.ucrOpenRefineDataFrame.TabIndex = 0
        '
        'UcrDialogDisabled1
        '
        Me.UcrDialogDisabled1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcrDialogDisabled1.Location = New System.Drawing.Point(91, 46)
        Me.UcrDialogDisabled1.Name = "UcrDialogDisabled1"
        Me.UcrDialogDisabled1.Size = New System.Drawing.Size(240, 50)
        Me.UcrDialogDisabled1.TabIndex = 10
        '
        'dlgExportToOpenRefine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 162)
        Me.Controls.Add(Me.UcrDialogDisabled1)
        Me.Controls.Add(Me.chkRefineBrowser)
        Me.Controls.Add(Me.lblNameDataSet)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrInputDatasetName)
        Me.Controls.Add(Me.ucrOpenRefineDataFrame)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportToOpenRefine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export to OpenRefine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrOpenRefineDataFrame As ucrDataFrame
    Friend WithEvents ucrInputDatasetName As ucrInputTextBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblNameDataSet As Label
    Friend WithEvents chkRefineBrowser As CheckBox
    Friend WithEvents UcrDialogDisabled1 As ucrDialogDisabled
End Class
