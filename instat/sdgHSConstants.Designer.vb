<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgHSConstants
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblGSCUnit = New System.Windows.Forms.Label()
        Me.ucrInputSolarConstant = New instat.ucrInputTextBox()
        Me.lblLambaUnit = New System.Windows.Forms.Label()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.ucrInputLambda = New instat.ucrInputTextBox()
        Me.lbllambda = New System.Windows.Forms.Label()
        Me.lblSolarConstant = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGSCUnit
        '
        Me.lblGSCUnit.AutoSize = True
        Me.lblGSCUnit.Location = New System.Drawing.Point(177, 37)
        Me.lblGSCUnit.Name = "lblGSCUnit"
        Me.lblGSCUnit.Size = New System.Drawing.Size(81, 13)
        Me.lblGSCUnit.TabIndex = 20
        Me.lblGSCUnit.Text = "MJ.m^-2.min^-1"
        '
        'ucrInputSolarConstant
        '
        Me.ucrInputSolarConstant.AddQuotesIfUnrecognised = True
        Me.ucrInputSolarConstant.AutoSize = True
        Me.ucrInputSolarConstant.IsMultiline = False
        Me.ucrInputSolarConstant.IsReadOnly = False
        Me.ucrInputSolarConstant.Location = New System.Drawing.Point(113, 33)
        Me.ucrInputSolarConstant.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSolarConstant.Name = "ucrInputSolarConstant"
        Me.ucrInputSolarConstant.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputSolarConstant.TabIndex = 23
        '
        'lblLambaUnit
        '
        Me.lblLambaUnit.AutoSize = True
        Me.lblLambaUnit.Location = New System.Drawing.Point(177, 11)
        Me.lblLambaUnit.Name = "lblLambaUnit"
        Me.lblLambaUnit.Size = New System.Drawing.Size(51, 13)
        Me.lblLambaUnit.TabIndex = 19
        Me.lblLambaUnit.Text = "MJ.kg^-1"
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.AutoSize = True
        Me.ucrSdgButtons.Location = New System.Drawing.Point(5, 87)
        Me.ucrSdgButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(259, 29)
        Me.ucrSdgButtons.TabIndex = 21
        '
        'ucrInputLambda
        '
        Me.ucrInputLambda.AddQuotesIfUnrecognised = True
        Me.ucrInputLambda.AutoSize = True
        Me.ucrInputLambda.IsMultiline = False
        Me.ucrInputLambda.IsReadOnly = False
        Me.ucrInputLambda.Location = New System.Drawing.Point(113, 7)
        Me.ucrInputLambda.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputLambda.Name = "ucrInputLambda"
        Me.ucrInputLambda.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputLambda.TabIndex = 22
        '
        'lbllambda
        '
        Me.lbllambda.AutoSize = True
        Me.lbllambda.Location = New System.Drawing.Point(2, 11)
        Me.lbllambda.Name = "lbllambda"
        Me.lbllambda.Size = New System.Drawing.Size(45, 13)
        Me.lbllambda.TabIndex = 17
        Me.lbllambda.Text = "Lambda"
        '
        'lblSolarConstant
        '
        Me.lblSolarConstant.AutoSize = True
        Me.lblSolarConstant.Location = New System.Drawing.Point(2, 37)
        Me.lblSolarConstant.Name = "lblSolarConstant"
        Me.lblSolarConstant.Size = New System.Drawing.Size(101, 13)
        Me.lblSolarConstant.TabIndex = 18
        Me.lblSolarConstant.Text = "Solar Constant(Gsc)"
        '
        'sdgHSConstants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 123)
        Me.Controls.Add(Me.lblGSCUnit)
        Me.Controls.Add(Me.ucrInputSolarConstant)
        Me.Controls.Add(Me.lblLambaUnit)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.Controls.Add(Me.ucrInputLambda)
        Me.Controls.Add(Me.lbllambda)
        Me.Controls.Add(Me.lblSolarConstant)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgHSConstants"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hargreaves Samani Constants"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGSCUnit As Label
    Friend WithEvents ucrInputSolarConstant As ucrInputTextBox
    Friend WithEvents lblLambaUnit As Label
    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents ucrInputLambda As ucrInputTextBox
    Friend WithEvents lbllambda As Label
    Friend WithEvents lblSolarConstant As Label
End Class
