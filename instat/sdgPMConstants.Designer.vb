<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgPMConstants
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
        Me.ucrInputAs = New instat.ucrInputTextBox()
        Me.ucrInputBS = New instat.ucrInputTextBox()
        Me.lblBS = New System.Windows.Forms.Label()
        Me.lblAS = New System.Windows.Forms.Label()
        Me.ucrNudHeigth = New instat.ucrNud()
        Me.ucrInputSoilFlux = New instat.ucrInputTextBox()
        Me.ucrInputSolarConstant = New instat.ucrInputTextBox()
        Me.ucrInputLambda = New instat.ucrInputTextBox()
        Me.ucrInputSigma = New instat.ucrInputTextBox()
        Me.lblSoilUnit = New System.Windows.Forms.Label()
        Me.lblSoilFlux = New System.Windows.Forms.Label()
        Me.lblSigma = New System.Windows.Forms.Label()
        Me.lblHeigthUnit = New System.Windows.Forms.Label()
        Me.lblSolarUnit = New System.Windows.Forms.Label()
        Me.lblSigmaUnit = New System.Windows.Forms.Label()
        Me.lblHeigth = New System.Windows.Forms.Label()
        Me.lblLambdaUnit = New System.Windows.Forms.Label()
        Me.lblSolarConstant = New System.Windows.Forms.Label()
        Me.lblLambda = New System.Windows.Forms.Label()
        Me.UcrButtonsSubdialogue1 = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'ucrInputAs
        '
        Me.ucrInputAs.AddQuotesIfUnrecognised = True
        Me.ucrInputAs.AutoSize = True
        Me.ucrInputAs.IsMultiline = False
        Me.ucrInputAs.IsReadOnly = False
        Me.ucrInputAs.Location = New System.Drawing.Point(135, 149)
        Me.ucrInputAs.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputAs.Name = "ucrInputAs"
        Me.ucrInputAs.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputAs.TabIndex = 62
        '
        'ucrInputBS
        '
        Me.ucrInputBS.AddQuotesIfUnrecognised = True
        Me.ucrInputBS.AutoSize = True
        Me.ucrInputBS.IsMultiline = False
        Me.ucrInputBS.IsReadOnly = False
        Me.ucrInputBS.Location = New System.Drawing.Point(135, 178)
        Me.ucrInputBS.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputBS.Name = "ucrInputBS"
        Me.ucrInputBS.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputBS.TabIndex = 61
        '
        'lblBS
        '
        Me.lblBS.AutoSize = True
        Me.lblBS.Location = New System.Drawing.Point(5, 186)
        Me.lblBS.Name = "lblBS"
        Me.lblBS.Size = New System.Drawing.Size(18, 13)
        Me.lblBS.TabIndex = 60
        Me.lblBS.Text = "bs"
        '
        'lblAS
        '
        Me.lblAS.AutoSize = True
        Me.lblAS.Location = New System.Drawing.Point(5, 153)
        Me.lblAS.Name = "lblAS"
        Me.lblAS.Size = New System.Drawing.Size(18, 13)
        Me.lblAS.TabIndex = 59
        Me.lblAS.Text = "as"
        '
        'ucrNudHeigth
        '
        Me.ucrNudHeigth.AutoSize = True
        Me.ucrNudHeigth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHeigth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHeigth.Location = New System.Drawing.Point(135, 71)
        Me.ucrNudHeigth.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudHeigth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHeigth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHeigth.Name = "ucrNudHeigth"
        Me.ucrNudHeigth.Size = New System.Drawing.Size(63, 20)
        Me.ucrNudHeigth.TabIndex = 58
        Me.ucrNudHeigth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputSoilFlux
        '
        Me.ucrInputSoilFlux.AddQuotesIfUnrecognised = True
        Me.ucrInputSoilFlux.AutoSize = True
        Me.ucrInputSoilFlux.IsMultiline = False
        Me.ucrInputSoilFlux.IsReadOnly = False
        Me.ucrInputSoilFlux.Location = New System.Drawing.Point(135, 122)
        Me.ucrInputSoilFlux.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSoilFlux.Name = "ucrInputSoilFlux"
        Me.ucrInputSoilFlux.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputSoilFlux.TabIndex = 57
        '
        'ucrInputSolarConstant
        '
        Me.ucrInputSolarConstant.AddQuotesIfUnrecognised = True
        Me.ucrInputSolarConstant.AutoSize = True
        Me.ucrInputSolarConstant.IsMultiline = False
        Me.ucrInputSolarConstant.IsReadOnly = False
        Me.ucrInputSolarConstant.Location = New System.Drawing.Point(135, 43)
        Me.ucrInputSolarConstant.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSolarConstant.Name = "ucrInputSolarConstant"
        Me.ucrInputSolarConstant.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputSolarConstant.TabIndex = 56
        '
        'ucrInputLambda
        '
        Me.ucrInputLambda.AddQuotesIfUnrecognised = True
        Me.ucrInputLambda.AutoSize = True
        Me.ucrInputLambda.IsMultiline = False
        Me.ucrInputLambda.IsReadOnly = False
        Me.ucrInputLambda.Location = New System.Drawing.Point(135, 11)
        Me.ucrInputLambda.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputLambda.Name = "ucrInputLambda"
        Me.ucrInputLambda.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputLambda.TabIndex = 55
        '
        'ucrInputSigma
        '
        Me.ucrInputSigma.AddQuotesIfUnrecognised = True
        Me.ucrInputSigma.AutoSize = True
        Me.ucrInputSigma.IsMultiline = False
        Me.ucrInputSigma.IsReadOnly = False
        Me.ucrInputSigma.Location = New System.Drawing.Point(135, 96)
        Me.ucrInputSigma.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSigma.Name = "ucrInputSigma"
        Me.ucrInputSigma.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputSigma.TabIndex = 54
        '
        'lblSoilUnit
        '
        Me.lblSoilUnit.AutoSize = True
        Me.lblSoilUnit.Location = New System.Drawing.Point(213, 126)
        Me.lblSoilUnit.Name = "lblSoilUnit"
        Me.lblSoilUnit.Size = New System.Drawing.Size(82, 13)
        Me.lblSoilUnit.TabIndex = 53
        Me.lblSoilUnit.Text = "MJ.m^-2.day^-1"
        '
        'lblSoilFlux
        '
        Me.lblSoilFlux.AutoSize = True
        Me.lblSoilFlux.Location = New System.Drawing.Point(5, 127)
        Me.lblSoilFlux.Name = "lblSoilFlux"
        Me.lblSoilFlux.Size = New System.Drawing.Size(72, 13)
        Me.lblSoilFlux.TabIndex = 52
        Me.lblSoilFlux.Text = "Soil Heat Flux"
        '
        'lblSigma
        '
        Me.lblSigma.AutoSize = True
        Me.lblSigma.Location = New System.Drawing.Point(5, 101)
        Me.lblSigma.Name = "lblSigma"
        Me.lblSigma.Size = New System.Drawing.Size(36, 13)
        Me.lblSigma.TabIndex = 51
        Me.lblSigma.Text = "Sigma"
        '
        'lblHeigthUnit
        '
        Me.lblHeigthUnit.AutoSize = True
        Me.lblHeigthUnit.Location = New System.Drawing.Point(213, 73)
        Me.lblHeigthUnit.Name = "lblHeigthUnit"
        Me.lblHeigthUnit.Size = New System.Drawing.Size(39, 13)
        Me.lblHeigthUnit.TabIndex = 50
        Me.lblHeigthUnit.Text = "Meters"
        '
        'lblSolarUnit
        '
        Me.lblSolarUnit.AutoSize = True
        Me.lblSolarUnit.Location = New System.Drawing.Point(213, 47)
        Me.lblSolarUnit.Name = "lblSolarUnit"
        Me.lblSolarUnit.Size = New System.Drawing.Size(81, 13)
        Me.lblSolarUnit.TabIndex = 49
        Me.lblSolarUnit.Text = "MJ.m^-2.min^-1"
        '
        'lblSigmaUnit
        '
        Me.lblSigmaUnit.AutoSize = True
        Me.lblSigmaUnit.Location = New System.Drawing.Point(213, 100)
        Me.lblSigmaUnit.Name = "lblSigmaUnit"
        Me.lblSigmaUnit.Size = New System.Drawing.Size(107, 13)
        Me.lblSigmaUnit.TabIndex = 48
        Me.lblSigmaUnit.Text = "MJ.K^-4.m^-2.day^-1"
        '
        'lblHeigth
        '
        Me.lblHeigth.AutoSize = True
        Me.lblHeigth.Location = New System.Drawing.Point(5, 73)
        Me.lblHeigth.Name = "lblHeigth"
        Me.lblHeigth.Size = New System.Drawing.Size(130, 13)
        Me.lblHeigth.TabIndex = 47
        Me.lblHeigth.Text = "Height of Wind Instrument"
        '
        'lblLambdaUnit
        '
        Me.lblLambdaUnit.AutoSize = True
        Me.lblLambdaUnit.Location = New System.Drawing.Point(213, 15)
        Me.lblLambdaUnit.Name = "lblLambdaUnit"
        Me.lblLambdaUnit.Size = New System.Drawing.Size(51, 13)
        Me.lblLambdaUnit.TabIndex = 46
        Me.lblLambdaUnit.Text = "MJ.kg^-1"
        '
        'lblSolarConstant
        '
        Me.lblSolarConstant.AutoSize = True
        Me.lblSolarConstant.Location = New System.Drawing.Point(5, 48)
        Me.lblSolarConstant.Name = "lblSolarConstant"
        Me.lblSolarConstant.Size = New System.Drawing.Size(101, 13)
        Me.lblSolarConstant.TabIndex = 45
        Me.lblSolarConstant.Text = "Solar Constant(Gsc)"
        '
        'lblLambda
        '
        Me.lblLambda.AutoSize = True
        Me.lblLambda.Location = New System.Drawing.Point(5, 16)
        Me.lblLambda.Name = "lblLambda"
        Me.lblLambda.Size = New System.Drawing.Size(45, 13)
        Me.lblLambda.TabIndex = 44
        Me.lblLambda.Text = "Lambda"
        '
        'UcrButtonsSubdialogue1
        '
        Me.UcrButtonsSubdialogue1.AutoSize = True
        Me.UcrButtonsSubdialogue1.Location = New System.Drawing.Point(28, 207)
        Me.UcrButtonsSubdialogue1.Margin = New System.Windows.Forms.Padding(4)
        Me.UcrButtonsSubdialogue1.Name = "UcrButtonsSubdialogue1"
        Me.UcrButtonsSubdialogue1.Size = New System.Drawing.Size(259, 29)
        Me.UcrButtonsSubdialogue1.TabIndex = 43
        '
        'sdgPMConstants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 246)
        Me.Controls.Add(Me.ucrInputAs)
        Me.Controls.Add(Me.ucrInputBS)
        Me.Controls.Add(Me.lblBS)
        Me.Controls.Add(Me.lblAS)
        Me.Controls.Add(Me.ucrNudHeigth)
        Me.Controls.Add(Me.ucrInputSoilFlux)
        Me.Controls.Add(Me.ucrInputSolarConstant)
        Me.Controls.Add(Me.ucrInputLambda)
        Me.Controls.Add(Me.ucrInputSigma)
        Me.Controls.Add(Me.lblSoilUnit)
        Me.Controls.Add(Me.lblSoilFlux)
        Me.Controls.Add(Me.lblSigma)
        Me.Controls.Add(Me.lblHeigthUnit)
        Me.Controls.Add(Me.lblSolarUnit)
        Me.Controls.Add(Me.lblSigmaUnit)
        Me.Controls.Add(Me.lblHeigth)
        Me.Controls.Add(Me.lblLambdaUnit)
        Me.Controls.Add(Me.lblSolarConstant)
        Me.Controls.Add(Me.lblLambda)
        Me.Controls.Add(Me.UcrButtonsSubdialogue1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPMConstants"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penman Monteith Constants"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputAs As ucrInputTextBox
    Friend WithEvents ucrInputBS As ucrInputTextBox
    Friend WithEvents lblBS As Label
    Friend WithEvents lblAS As Label
    Friend WithEvents ucrNudHeigth As ucrNud
    Friend WithEvents ucrInputSoilFlux As ucrInputTextBox
    Friend WithEvents ucrInputSolarConstant As ucrInputTextBox
    Friend WithEvents ucrInputLambda As ucrInputTextBox
    Friend WithEvents ucrInputSigma As ucrInputTextBox
    Friend WithEvents lblSoilUnit As Label
    Friend WithEvents lblSoilFlux As Label
    Friend WithEvents lblSigma As Label
    Friend WithEvents lblHeigthUnit As Label
    Friend WithEvents lblSolarUnit As Label
    Friend WithEvents lblSigmaUnit As Label
    Friend WithEvents lblHeigth As Label
    Friend WithEvents lblLambdaUnit As Label
    Friend WithEvents lblSolarConstant As Label
    Friend WithEvents lblLambda As Label
    Friend WithEvents UcrButtonsSubdialogue1 As ucrButtonsSubdialogue
End Class
