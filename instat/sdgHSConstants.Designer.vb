<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgHSConstants
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.ucrInputSolarConstant = New instat.ucrInputTextBox()
        Me.ucrInputLambda = New instat.ucrInputTextBox()
        Me.lblGSCUnit = New System.Windows.Forms.Label()
        Me.lblLambaUnit = New System.Windows.Forms.Label()
        Me.lblSolarConstant = New System.Windows.Forms.Label()
        Me.lbllambda = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.AutoSize = True
        Me.ucrSdgButtons.Location = New System.Drawing.Point(8, 89)
        Me.ucrSdgButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(259, 29)
        Me.ucrSdgButtons.TabIndex = 9
        '
        'ucrInputSolarConstant
        '
        Me.ucrInputSolarConstant.AddQuotesIfUnrecognised = True
        Me.ucrInputSolarConstant.AutoSize = True
        Me.ucrInputSolarConstant.IsMultiline = False
        Me.ucrInputSolarConstant.IsReadOnly = False
        Me.ucrInputSolarConstant.Location = New System.Drawing.Point(116, 35)
        Me.ucrInputSolarConstant.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSolarConstant.Name = "ucrInputSolarConstant"
        Me.ucrInputSolarConstant.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputSolarConstant.TabIndex = 16
        '
        'ucrInputLambda
        '
        Me.ucrInputLambda.AddQuotesIfUnrecognised = True
        Me.ucrInputLambda.AutoSize = True
        Me.ucrInputLambda.IsMultiline = False
        Me.ucrInputLambda.IsReadOnly = False
        Me.ucrInputLambda.Location = New System.Drawing.Point(116, 9)
        Me.ucrInputLambda.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputLambda.Name = "ucrInputLambda"
        Me.ucrInputLambda.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputLambda.TabIndex = 15
        '
        'lblGSCUnit
        '
        Me.lblGSCUnit.AutoSize = True
        Me.lblGSCUnit.Location = New System.Drawing.Point(180, 39)
        Me.lblGSCUnit.Name = "lblGSCUnit"
        Me.lblGSCUnit.Size = New System.Drawing.Size(81, 13)
        Me.lblGSCUnit.TabIndex = 5
        Me.lblGSCUnit.Text = "MJ.m^-2.min^-1"
        '
        'lblLambaUnit
        '
        Me.lblLambaUnit.AutoSize = True
        Me.lblLambaUnit.Location = New System.Drawing.Point(180, 13)
        Me.lblLambaUnit.Name = "lblLambaUnit"
        Me.lblLambaUnit.Size = New System.Drawing.Size(51, 13)
        Me.lblLambaUnit.TabIndex = 2
        Me.lblLambaUnit.Text = "MJ.kg^-1"
        '
        'lblSolarConstant
        '
        Me.lblSolarConstant.AutoSize = True
        Me.lblSolarConstant.Location = New System.Drawing.Point(5, 39)
        Me.lblSolarConstant.Name = "lblSolarConstant"
        Me.lblSolarConstant.Size = New System.Drawing.Size(101, 13)
        Me.lblSolarConstant.TabIndex = 1
        Me.lblSolarConstant.Text = "Solar Constant(Gsc)"
        '
        'lbllambda
        '
        Me.lbllambda.AutoSize = True
        Me.lbllambda.Location = New System.Drawing.Point(5, 13)
        Me.lbllambda.Name = "lbllambda"
        Me.lbllambda.Size = New System.Drawing.Size(45, 13)
        Me.lbllambda.TabIndex = 0
        Me.lbllambda.Text = "Lambda"
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

    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents ucrInputSolarConstant As ucrInputTextBox
    Friend WithEvents ucrInputLambda As ucrInputTextBox
    Friend WithEvents lblGSCUnit As Label
    Friend WithEvents lblLambaUnit As Label
    Friend WithEvents lblSolarConstant As Label
    Friend WithEvents lbllambda As Label
End Class
