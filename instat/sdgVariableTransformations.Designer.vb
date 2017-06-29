<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgVariableTransformations
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
        Me.grpGeneralFunctions = New System.Windows.Forms.GroupBox()
        Me.ucrNudPower = New instat.ucrNud()
        Me.rdoIdentity = New System.Windows.Forms.RadioButton()
        Me.rdoNaturallog = New System.Windows.Forms.RadioButton()
        Me.rdoPower = New System.Windows.Forms.RadioButton()
        Me.rdoSquareroot = New System.Windows.Forms.RadioButton()
        Me.rdoLogBase10 = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGenerateFunctions = New instat.UcrPanel()
        Me.ucrButtonsSDGVarTransform = New instat.ucrButtonsSubdialogue()
        Me.grpGeneralFunctions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpGeneralFunctions
        '
        Me.grpGeneralFunctions.Controls.Add(Me.ucrNudPower)
        Me.grpGeneralFunctions.Controls.Add(Me.rdoIdentity)
        Me.grpGeneralFunctions.Controls.Add(Me.rdoNaturallog)
        Me.grpGeneralFunctions.Controls.Add(Me.rdoPower)
        Me.grpGeneralFunctions.Controls.Add(Me.rdoSquareroot)
        Me.grpGeneralFunctions.Controls.Add(Me.rdoLogBase10)
        Me.grpGeneralFunctions.Controls.Add(Me.ucrPnlGenerateFunctions)
        Me.grpGeneralFunctions.Location = New System.Drawing.Point(10, 10)
        Me.grpGeneralFunctions.Name = "grpGeneralFunctions"
        Me.grpGeneralFunctions.Size = New System.Drawing.Size(151, 153)
        Me.grpGeneralFunctions.TabIndex = 1
        Me.grpGeneralFunctions.TabStop = False
        Me.grpGeneralFunctions.Tag = "General_Functions"
        Me.grpGeneralFunctions.Text = "General Functions"
        '
        'ucrNudPower
        '
        Me.ucrNudPower.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPower.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPower.Location = New System.Drawing.Point(83, 118)
        Me.ucrNudPower.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPower.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPower.Name = "ucrNudPower"
        Me.ucrNudPower.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPower.TabIndex = 17
        Me.ucrNudPower.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoIdentity
        '
        Me.rdoIdentity.AutoSize = True
        Me.rdoIdentity.Location = New System.Drawing.Point(22, 23)
        Me.rdoIdentity.Name = "rdoIdentity"
        Me.rdoIdentity.Size = New System.Drawing.Size(59, 17)
        Me.rdoIdentity.TabIndex = 17
        Me.rdoIdentity.TabStop = True
        Me.rdoIdentity.Tag = "Identity"
        Me.rdoIdentity.Text = "Identity"
        Me.rdoIdentity.UseVisualStyleBackColor = True
        '
        'rdoNaturallog
        '
        Me.rdoNaturallog.AutoSize = True
        Me.rdoNaturallog.Location = New System.Drawing.Point(22, 48)
        Me.rdoNaturallog.Name = "rdoNaturallog"
        Me.rdoNaturallog.Size = New System.Drawing.Size(76, 17)
        Me.rdoNaturallog.TabIndex = 12
        Me.rdoNaturallog.TabStop = True
        Me.rdoNaturallog.Tag = "Natural_log"
        Me.rdoNaturallog.Text = "Natural log"
        Me.rdoNaturallog.UseVisualStyleBackColor = True
        '
        'rdoPower
        '
        Me.rdoPower.AutoSize = True
        Me.rdoPower.Location = New System.Drawing.Point(22, 118)
        Me.rdoPower.Name = "rdoPower"
        Me.rdoPower.Size = New System.Drawing.Size(55, 17)
        Me.rdoPower.TabIndex = 15
        Me.rdoPower.TabStop = True
        Me.rdoPower.Tag = "Power"
        Me.rdoPower.Text = "Power"
        Me.rdoPower.UseVisualStyleBackColor = True
        '
        'rdoSquareroot
        '
        Me.rdoSquareroot.AutoSize = True
        Me.rdoSquareroot.Location = New System.Drawing.Point(22, 95)
        Me.rdoSquareroot.Name = "rdoSquareroot"
        Me.rdoSquareroot.Size = New System.Drawing.Size(80, 17)
        Me.rdoSquareroot.TabIndex = 14
        Me.rdoSquareroot.TabStop = True
        Me.rdoSquareroot.Tag = "Square_root"
        Me.rdoSquareroot.Text = "Square root"
        Me.rdoSquareroot.UseVisualStyleBackColor = True
        '
        'rdoLogBase10
        '
        Me.rdoLogBase10.AutoSize = True
        Me.rdoLogBase10.Location = New System.Drawing.Point(22, 70)
        Me.rdoLogBase10.Name = "rdoLogBase10"
        Me.rdoLogBase10.Size = New System.Drawing.Size(85, 17)
        Me.rdoLogBase10.TabIndex = 13
        Me.rdoLogBase10.TabStop = True
        Me.rdoLogBase10.Tag = "Log_Base_10"
        Me.rdoLogBase10.Text = "Log Base 10"
        Me.rdoLogBase10.UseVisualStyleBackColor = True
        '
        'ucrPnlGenerateFunctions
        '
        Me.ucrPnlGenerateFunctions.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlGenerateFunctions.Name = "ucrPnlGenerateFunctions"
        Me.ucrPnlGenerateFunctions.Size = New System.Drawing.Size(136, 128)
        Me.ucrPnlGenerateFunctions.TabIndex = 3
        '
        'ucrButtonsSDGVarTransform
        '
        Me.ucrButtonsSDGVarTransform.Location = New System.Drawing.Point(10, 169)
        Me.ucrButtonsSDGVarTransform.Name = "ucrButtonsSDGVarTransform"
        Me.ucrButtonsSDGVarTransform.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsSDGVarTransform.TabIndex = 2
        '
        'sdgVariableTransformations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(171, 211)
        Me.Controls.Add(Me.ucrButtonsSDGVarTransform)
        Me.Controls.Add(Me.grpGeneralFunctions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgVariableTransformations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Variable _Transformations"
        Me.Text = "Variable Transformations"
        Me.grpGeneralFunctions.ResumeLayout(False)
        Me.grpGeneralFunctions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpGeneralFunctions As GroupBox
    Friend WithEvents ucrButtonsSDGVarTransform As ucrButtonsSubdialogue
    Friend WithEvents ucrNudPower As ucrNud
    Friend WithEvents rdoIdentity As RadioButton
    Friend WithEvents rdoNaturallog As RadioButton
    Friend WithEvents rdoPower As RadioButton
    Friend WithEvents rdoSquareroot As RadioButton
    Friend WithEvents rdoLogBase10 As RadioButton
    Friend WithEvents ucrPnlGenerateFunctions As UcrPanel
End Class
