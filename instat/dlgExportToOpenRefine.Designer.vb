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
        Me.ucrInputDatasetName = New instat.ucrInputTextBox()
        Me.ucrOpenRefineDataFrame = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblNameDataSet = New System.Windows.Forms.Label()
        Me.chkRefineBrowser = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ucrInputDatasetName
        '
        Me.ucrInputDatasetName.IsReadOnly = False
        Me.ucrInputDatasetName.Location = New System.Drawing.Point(29, 89)
        Me.ucrInputDatasetName.Name = "ucrInputDatasetName"
        Me.ucrInputDatasetName.Size = New System.Drawing.Size(149, 21)
        Me.ucrInputDatasetName.TabIndex = 5
        '
        'ucrOpenRefineDataFrame
        '
        Me.ucrOpenRefineDataFrame.bUseCurrentFilter = False
        Me.ucrOpenRefineDataFrame.Location = New System.Drawing.Point(9, 9)
        Me.ucrOpenRefineDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrOpenRefineDataFrame.Name = "ucrOpenRefineDataFrame"
        Me.ucrOpenRefineDataFrame.Size = New System.Drawing.Size(160, 40)
        Me.ucrOpenRefineDataFrame.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 134)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(407, 52)
        Me.ucrBase.TabIndex = 7
        '
        'lblNameDataSet
        '
        Me.lblNameDataSet.AutoSize = True
        Me.lblNameDataSet.Location = New System.Drawing.Point(31, 73)
        Me.lblNameDataSet.Name = "lblNameDataSet"
        Me.lblNameDataSet.Size = New System.Drawing.Size(75, 13)
        Me.lblNameDataSet.TabIndex = 8
        Me.lblNameDataSet.Text = "Dataset Name"
        '
        'chkRefineBrowser
        '
        Me.chkRefineBrowser.AutoSize = True
        Me.chkRefineBrowser.Location = New System.Drawing.Point(242, 27)
        Me.chkRefineBrowser.Name = "chkRefineBrowser"
        Me.chkRefineBrowser.Size = New System.Drawing.Size(93, 17)
        Me.chkRefineBrowser.TabIndex = 9
        Me.chkRefineBrowser.Text = "Open Browser"
        Me.chkRefineBrowser.UseVisualStyleBackColor = True
        '
        'dlgExportToOpenRefine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 198)
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
End Class
