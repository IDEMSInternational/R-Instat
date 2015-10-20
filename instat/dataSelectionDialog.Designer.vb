<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dataSelectionDialog
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
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.lblFactorVariable = New System.Windows.Forms.Label()
        Me.cboFactoVariable = New System.Windows.Forms.ComboBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.lstSelectedVariables = New System.Windows.Forms.ListBox()
        Me.lblAvailableVariables = New System.Windows.Forms.Label()
        Me.lstAvailableVariable = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(7, 358)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 78
        Me.cmdOk.Tag = "Ok "
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(187, 358)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 77
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel "
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(106, 358)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdReset.TabIndex = 76
        Me.cmdReset.Tag = "Reset"
        Me.cmdReset.Text = "Reset "
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(268, 358)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdHelp.TabIndex = 75
        Me.cmdHelp.Tag = "Help"
        Me.cmdHelp.Text = "Help "
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'lblFactorVariable
        '
        Me.lblFactorVariable.AutoSize = True
        Me.lblFactorVariable.Location = New System.Drawing.Point(281, 6)
        Me.lblFactorVariable.Name = "lblFactorVariable"
        Me.lblFactorVariable.Size = New System.Drawing.Size(78, 13)
        Me.lblFactorVariable.TabIndex = 74
        Me.lblFactorVariable.Tag = "Factor_Variable"
        Me.lblFactorVariable.Text = "Factor Variable"
        '
        'cboFactoVariable
        '
        Me.cboFactoVariable.FormattingEnabled = True
        Me.cboFactoVariable.Location = New System.Drawing.Point(278, 26)
        Me.cboFactoVariable.Name = "cboFactoVariable"
        Me.cboFactoVariable.Size = New System.Drawing.Size(81, 21)
        Me.cboFactoVariable.TabIndex = 73
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(97, 79)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 72
        Me.btnRemove.Tag = "Remove"
        Me.btnRemove.Text = "Remove "
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(97, 41)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 71
        Me.btnAdd.Tag = "Add"
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(180, 6)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(95, 13)
        Me.lblSelectedVariables.TabIndex = 70
        Me.lblSelectedVariables.Tag = "Selected_Variables"
        Me.lblSelectedVariables.Text = "Selected Variables"
        '
        'lstSelectedVariables
        '
        Me.lstSelectedVariables.FormattingEnabled = True
        Me.lstSelectedVariables.Location = New System.Drawing.Point(187, 26)
        Me.lstSelectedVariables.Name = "lstSelectedVariables"
        Me.lstSelectedVariables.Size = New System.Drawing.Size(84, 95)
        Me.lstSelectedVariables.TabIndex = 69
        '
        'lblAvailableVariables
        '
        Me.lblAvailableVariables.AutoSize = True
        Me.lblAvailableVariables.Location = New System.Drawing.Point(0, 6)
        Me.lblAvailableVariables.Name = "lblAvailableVariables"
        Me.lblAvailableVariables.Size = New System.Drawing.Size(102, 13)
        Me.lblAvailableVariables.TabIndex = 68
        Me.lblAvailableVariables.Tag = "Available _Variables "
        Me.lblAvailableVariables.Text = "Available  Variables "
        '
        'lstAvailableVariable
        '
        Me.lstAvailableVariable.FormattingEnabled = True
        Me.lstAvailableVariable.Location = New System.Drawing.Point(7, 26)
        Me.lstAvailableVariable.Name = "lstAvailableVariable"
        Me.lstAvailableVariable.Size = New System.Drawing.Size(84, 95)
        Me.lstAvailableVariable.TabIndex = 67
        '
        'dataSelectionDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 390)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.lblFactorVariable)
        Me.Controls.Add(Me.cboFactoVariable)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.lstSelectedVariables)
        Me.Controls.Add(Me.lblAvailableVariables)
        Me.Controls.Add(Me.lstAvailableVariable)
        Me.Name = "dataSelectionDialog"
        Me.Text = "Data Selection Template"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdReset As Button
    Friend WithEvents cmdHelp As Button
    Friend WithEvents lblFactorVariable As Label
    Friend WithEvents cboFactoVariable As ComboBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents lstSelectedVariables As ListBox
    Friend WithEvents lblAvailableVariables As Label
    Friend WithEvents lstAvailableVariable As ListBox
End Class
