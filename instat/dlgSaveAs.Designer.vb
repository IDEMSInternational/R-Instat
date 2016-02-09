<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSaveAs
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
        Me.chkOutput = New System.Windows.Forms.CheckBox()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.lblSavePath = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.txtEditorSave = New System.Windows.Forms.TextBox()
        Me.cmdEditorSave = New System.Windows.Forms.Button()
        Me.lblSaveDataGrid = New System.Windows.Forms.Label()
        Me.grpLog = New System.Windows.Forms.GroupBox()
        Me.chkLog = New System.Windows.Forms.CheckBox()
        Me.txtLogSave = New System.Windows.Forms.TextBox()
        Me.cmdLogSave = New System.Windows.Forms.Button()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.txtOutputSave = New System.Windows.Forms.TextBox()
        Me.cmdOutputSave = New System.Windows.Forms.Button()
        Me.grpOptions.SuspendLayout()
        Me.grpLog.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkOutput
        '
        Me.chkOutput.AutoSize = True
        Me.chkOutput.Location = New System.Drawing.Point(8, 38)
        Me.chkOutput.Name = "chkOutput"
        Me.chkOutput.Size = New System.Drawing.Size(146, 17)
        Me.chkOutput.TabIndex = 2
        Me.chkOutput.Text = "Save the Output Window"
        Me.chkOutput.UseVisualStyleBackColor = True
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.Location = New System.Drawing.Point(5, 3)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(160, 13)
        Me.lblChoose.TabIndex = 10
        Me.lblChoose.Text = "Choose what and where to save"
        Me.lblChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.grpOutput)
        Me.grpOptions.Controls.Add(Me.lblSavePath)
        Me.grpOptions.Controls.Add(Me.grpLog)
        Me.grpOptions.Controls.Add(Me.chkOutput)
        Me.grpOptions.Controls.Add(Me.chkLog)
        Me.grpOptions.Location = New System.Drawing.Point(8, 80)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(533, 126)
        Me.grpOptions.TabIndex = 14
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Available Options"
        '
        'lblSavePath
        '
        Me.lblSavePath.AutoSize = True
        Me.lblSavePath.Location = New System.Drawing.Point(155, 12)
        Me.lblSavePath.Name = "lblSavePath"
        Me.lblSavePath.Size = New System.Drawing.Size(57, 13)
        Me.lblSavePath.TabIndex = 15
        Me.lblSavePath.Text = "Save Path"
        '
        'ucrBase
        '
        Me.ucrBase.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ucrBase.Location = New System.Drawing.Point(45, 215)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'txtEditorSave
        '
        Me.txtEditorSave.Location = New System.Drawing.Point(166, 35)
        Me.txtEditorSave.Name = "txtEditorSave"
        Me.txtEditorSave.ReadOnly = True
        Me.txtEditorSave.Size = New System.Drawing.Size(311, 20)
        Me.txtEditorSave.TabIndex = 16
        '
        'cmdEditorSave
        '
        Me.cmdEditorSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEditorSave.Location = New System.Drawing.Point(513, 35)
        Me.cmdEditorSave.Name = "cmdEditorSave"
        Me.cmdEditorSave.Size = New System.Drawing.Size(31, 20)
        Me.cmdEditorSave.TabIndex = 17
        Me.cmdEditorSave.Text = "..."
        Me.cmdEditorSave.UseVisualStyleBackColor = True
        '
        'lblSaveDataGrid
        '
        Me.lblSaveDataGrid.AutoSize = True
        Me.lblSaveDataGrid.Location = New System.Drawing.Point(12, 42)
        Me.lblSaveDataGrid.Name = "lblSaveDataGrid"
        Me.lblSaveDataGrid.Size = New System.Drawing.Size(98, 13)
        Me.lblSaveDataGrid.TabIndex = 18
        Me.lblSaveDataGrid.Text = "Save the Data Grid"
        '
        'grpLog
        '
        Me.grpLog.Controls.Add(Me.txtLogSave)
        Me.grpLog.Controls.Add(Me.cmdLogSave)
        Me.grpLog.Location = New System.Drawing.Point(165, 76)
        Me.grpLog.Name = "grpLog"
        Me.grpLog.Size = New System.Drawing.Size(362, 40)
        Me.grpLog.TabIndex = 19
        Me.grpLog.TabStop = False
        '
        'chkLog
        '
        Me.chkLog.AutoSize = True
        Me.chkLog.Location = New System.Drawing.Point(8, 99)
        Me.chkLog.Name = "chkLog"
        Me.chkLog.Size = New System.Drawing.Size(132, 17)
        Me.chkLog.TabIndex = 3
        Me.chkLog.Text = "Save the Log Window"
        Me.chkLog.UseVisualStyleBackColor = True
        '
        'txtLogSave
        '
        Me.txtLogSave.Location = New System.Drawing.Point(6, 13)
        Me.txtLogSave.Name = "txtLogSave"
        Me.txtLogSave.ReadOnly = True
        Me.txtLogSave.Size = New System.Drawing.Size(311, 20)
        Me.txtLogSave.TabIndex = 8
        '
        'cmdLogSave
        '
        Me.cmdLogSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLogSave.Location = New System.Drawing.Point(319, 13)
        Me.cmdLogSave.Name = "cmdLogSave"
        Me.cmdLogSave.Size = New System.Drawing.Size(31, 20)
        Me.cmdLogSave.TabIndex = 9
        Me.cmdLogSave.Text = "..."
        Me.cmdLogSave.UseVisualStyleBackColor = True
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.txtOutputSave)
        Me.grpOutput.Controls.Add(Me.cmdOutputSave)
        Me.grpOutput.Location = New System.Drawing.Point(163, 28)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(364, 41)
        Me.grpOutput.TabIndex = 16
        Me.grpOutput.TabStop = False
        '
        'txtOutputSave
        '
        Me.txtOutputSave.Location = New System.Drawing.Point(7, 14)
        Me.txtOutputSave.Name = "txtOutputSave"
        Me.txtOutputSave.ReadOnly = True
        Me.txtOutputSave.Size = New System.Drawing.Size(311, 20)
        Me.txtOutputSave.TabIndex = 9
        '
        'cmdOutputSave
        '
        Me.cmdOutputSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOutputSave.Location = New System.Drawing.Point(323, 14)
        Me.cmdOutputSave.Name = "cmdOutputSave"
        Me.cmdOutputSave.Size = New System.Drawing.Size(31, 20)
        Me.cmdOutputSave.TabIndex = 10
        Me.cmdOutputSave.Text = "..."
        Me.cmdOutputSave.UseVisualStyleBackColor = True
        '
        'dlgSaveAs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 280)
        Me.Controls.Add(Me.lblSaveDataGrid)
        Me.Controls.Add(Me.txtEditorSave)
        Me.Controls.Add(Me.cmdEditorSave)
        Me.Controls.Add(Me.lblChoose)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgSaveAs"
        Me.Tag = "Save_As"
        Me.Text = "Save As"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpLog.ResumeLayout(False)
        Me.grpLog.PerformLayout()
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkOutput As CheckBox
    Friend WithEvents lblChoose As Label
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents lblSavePath As Label
    Friend WithEvents lblSaveDataGrid As Label
    Friend WithEvents cmdEditorSave As Button
    Friend WithEvents txtEditorSave As TextBox
    Friend WithEvents grpOutput As GroupBox
    Friend WithEvents grpLog As GroupBox
    Friend WithEvents chkLog As CheckBox
    Friend WithEvents cmdLogSave As Button
    Friend WithEvents txtLogSave As TextBox
    Friend WithEvents cmdOutputSave As Button
    Friend WithEvents txtOutputSave As TextBox
End Class
