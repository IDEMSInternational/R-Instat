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
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.lblLongitudeUnit = New System.Windows.Forms.Label()
        Me.lblAltitudeUnit = New System.Windows.Forms.Label()
        Me.lblLatitudeUnit = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblAltitude = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.ucrNudLongitude = New instat.ucrNud()
        Me.ucrNudLatitude = New instat.ucrNud()
        Me.ucrNudAltitude = New instat.ucrNud()
        Me.grpConstants = New System.Windows.Forms.GroupBox()
        Me.ucrInputSigma = New instat.ucrInputTextBox()
        Me.ucrNudSoil = New instat.ucrNud()
        Me.ucrNudSolar = New instat.ucrNud()
        Me.ucrNudLambda = New instat.ucrNud()
        Me.ucrNudHeith = New instat.ucrNud()
        Me.lblSoilHeatFluxUnit = New System.Windows.Forms.Label()
        Me.lblHeightUnit = New System.Windows.Forms.Label()
        Me.lblSoilHeatFlux = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblSolarConstantUnit = New System.Windows.Forms.Label()
        Me.lblSigmaUnit = New System.Windows.Forms.Label()
        Me.lbllambdaUnit = New System.Windows.Forms.Label()
        Me.lblSolarConstant = New System.Windows.Forms.Label()
        Me.lblSigma = New System.Windows.Forms.Label()
        Me.lblLambda = New System.Windows.Forms.Label()
        Me.grpRadiationConstants = New System.Windows.Forms.GroupBox()
        Me.ucrNudBS = New instat.ucrNud()
        Me.ucrNudAS = New instat.ucrNud()
        Me.lblBS = New System.Windows.Forms.Label()
        Me.lblAS = New System.Windows.Forms.Label()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.grpLocation.SuspendLayout()
        Me.grpConstants.SuspendLayout()
        Me.grpRadiationConstants.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.lblLongitudeUnit)
        Me.grpLocation.Controls.Add(Me.lblAltitudeUnit)
        Me.grpLocation.Controls.Add(Me.lblLatitudeUnit)
        Me.grpLocation.Controls.Add(Me.lblLongitude)
        Me.grpLocation.Controls.Add(Me.lblAltitude)
        Me.grpLocation.Controls.Add(Me.lblLatitude)
        Me.grpLocation.Controls.Add(Me.ucrNudLongitude)
        Me.grpLocation.Controls.Add(Me.ucrNudLatitude)
        Me.grpLocation.Controls.Add(Me.ucrNudAltitude)
        Me.grpLocation.Location = New System.Drawing.Point(12, 12)
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.Size = New System.Drawing.Size(290, 137)
        Me.grpLocation.TabIndex = 0
        Me.grpLocation.TabStop = False
        Me.grpLocation.Text = "Location"
        '
        'lblLongitudeUnit
        '
        Me.lblLongitudeUnit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLongitudeUnit.Location = New System.Drawing.Point(145, 58)
        Me.lblLongitudeUnit.Name = "lblLongitudeUnit"
        Me.lblLongitudeUnit.Size = New System.Drawing.Size(63, 20)
        Me.lblLongitudeUnit.TabIndex = 47
        Me.lblLongitudeUnit.Text = "Radians"
        '
        'lblAltitudeUnit
        '
        Me.lblAltitudeUnit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAltitudeUnit.Location = New System.Drawing.Point(148, 105)
        Me.lblAltitudeUnit.Name = "lblAltitudeUnit"
        Me.lblAltitudeUnit.Size = New System.Drawing.Size(63, 20)
        Me.lblAltitudeUnit.TabIndex = 46
        Me.lblAltitudeUnit.Text = "Meters"
        '
        'lblLatitudeUnit
        '
        Me.lblLatitudeUnit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLatitudeUnit.Location = New System.Drawing.Point(145, 19)
        Me.lblLatitudeUnit.Name = "lblLatitudeUnit"
        Me.lblLatitudeUnit.Size = New System.Drawing.Size(63, 20)
        Me.lblLatitudeUnit.TabIndex = 45
        Me.lblLatitudeUnit.Text = "Radians"
        '
        'lblLongitude
        '
        Me.lblLongitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLongitude.Location = New System.Drawing.Point(16, 58)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(64, 20)
        Me.lblLongitude.TabIndex = 43
        Me.lblLongitude.Text = "Longitude"
        '
        'lblAltitude
        '
        Me.lblAltitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAltitude.Location = New System.Drawing.Point(16, 105)
        Me.lblAltitude.Name = "lblAltitude"
        Me.lblAltitude.Size = New System.Drawing.Size(64, 20)
        Me.lblAltitude.TabIndex = 41
        Me.lblAltitude.Text = "Altitude"
        '
        'lblLatitude
        '
        Me.lblLatitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLatitude.Location = New System.Drawing.Point(16, 25)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(64, 20)
        Me.lblLatitude.TabIndex = 39
        Me.lblLatitude.Text = "Latitude"
        '
        'ucrNudLongitude
        '
        Me.ucrNudLongitude.AutoSize = True
        Me.ucrNudLongitude.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLongitude.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLongitude.Location = New System.Drawing.Point(89, 58)
        Me.ucrNudLongitude.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLongitude.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLongitude.Name = "ucrNudLongitude"
        Me.ucrNudLongitude.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLongitude.TabIndex = 44
        Me.ucrNudLongitude.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLatitude
        '
        Me.ucrNudLatitude.AutoSize = True
        Me.ucrNudLatitude.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLatitude.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLatitude.Location = New System.Drawing.Point(89, 19)
        Me.ucrNudLatitude.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLatitude.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLatitude.Name = "ucrNudLatitude"
        Me.ucrNudLatitude.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLatitude.TabIndex = 40
        Me.ucrNudLatitude.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudAltitude
        '
        Me.ucrNudAltitude.AutoSize = True
        Me.ucrNudAltitude.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAltitude.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAltitude.Location = New System.Drawing.Point(89, 105)
        Me.ucrNudAltitude.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAltitude.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAltitude.Name = "ucrNudAltitude"
        Me.ucrNudAltitude.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAltitude.TabIndex = 42
        Me.ucrNudAltitude.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'grpConstants
        '
        Me.grpConstants.Controls.Add(Me.ucrInputSigma)
        Me.grpConstants.Controls.Add(Me.ucrNudSoil)
        Me.grpConstants.Controls.Add(Me.ucrNudSolar)
        Me.grpConstants.Controls.Add(Me.ucrNudLambda)
        Me.grpConstants.Controls.Add(Me.ucrNudHeith)
        Me.grpConstants.Controls.Add(Me.lblSoilHeatFluxUnit)
        Me.grpConstants.Controls.Add(Me.lblHeightUnit)
        Me.grpConstants.Controls.Add(Me.lblSoilHeatFlux)
        Me.grpConstants.Controls.Add(Me.lblHeight)
        Me.grpConstants.Controls.Add(Me.lblSolarConstantUnit)
        Me.grpConstants.Controls.Add(Me.lblSigmaUnit)
        Me.grpConstants.Controls.Add(Me.lbllambdaUnit)
        Me.grpConstants.Controls.Add(Me.lblSolarConstant)
        Me.grpConstants.Controls.Add(Me.lblSigma)
        Me.grpConstants.Controls.Add(Me.lblLambda)
        Me.grpConstants.Location = New System.Drawing.Point(12, 155)
        Me.grpConstants.Name = "grpConstants"
        Me.grpConstants.Size = New System.Drawing.Size(421, 141)
        Me.grpConstants.TabIndex = 1
        Me.grpConstants.TabStop = False
        Me.grpConstants.Text = "Constants"
        '
        'ucrInputSigma
        '
        Me.ucrInputSigma.AddQuotesIfUnrecognised = True
        Me.ucrInputSigma.AutoSize = True
        Me.ucrInputSigma.IsMultiline = False
        Me.ucrInputSigma.IsReadOnly = False
        Me.ucrInputSigma.Location = New System.Drawing.Point(186, 41)
        Me.ucrInputSigma.Name = "ucrInputSigma"
        Me.ucrInputSigma.Size = New System.Drawing.Size(49, 19)
        Me.ucrInputSigma.TabIndex = 79
        '
        'ucrNudSoil
        '
        Me.ucrNudSoil.AutoSize = True
        Me.ucrNudSoil.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSoil.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSoil.Location = New System.Drawing.Point(186, 112)
        Me.ucrNudSoil.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSoil.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSoil.Name = "ucrNudSoil"
        Me.ucrNudSoil.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSoil.TabIndex = 78
        Me.ucrNudSoil.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSolar
        '
        Me.ucrNudSolar.AutoSize = True
        Me.ucrNudSolar.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSolar.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSolar.Location = New System.Drawing.Point(186, 66)
        Me.ucrNudSolar.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSolar.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSolar.Name = "ucrNudSolar"
        Me.ucrNudSolar.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSolar.TabIndex = 77
        Me.ucrNudSolar.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLambda
        '
        Me.ucrNudLambda.AutoSize = True
        Me.ucrNudLambda.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLambda.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLambda.Location = New System.Drawing.Point(186, 15)
        Me.ucrNudLambda.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLambda.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLambda.Name = "ucrNudLambda"
        Me.ucrNudLambda.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLambda.TabIndex = 75
        Me.ucrNudLambda.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudHeith
        '
        Me.ucrNudHeith.AutoSize = True
        Me.ucrNudHeith.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHeith.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHeith.Location = New System.Drawing.Point(186, 89)
        Me.ucrNudHeith.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHeith.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHeith.Name = "ucrNudHeith"
        Me.ucrNudHeith.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudHeith.TabIndex = 74
        Me.ucrNudHeith.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSoilHeatFluxUnit
        '
        Me.lblSoilHeatFluxUnit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSoilHeatFluxUnit.Location = New System.Drawing.Point(259, 112)
        Me.lblSoilHeatFluxUnit.Name = "lblSoilHeatFluxUnit"
        Me.lblSoilHeatFluxUnit.Size = New System.Drawing.Size(88, 20)
        Me.lblSoilHeatFluxUnit.TabIndex = 64
        Me.lblSoilHeatFluxUnit.Text = "MJ.m^-2.day^-1"
        '
        'lblHeightUnit
        '
        Me.lblHeightUnit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeightUnit.Location = New System.Drawing.Point(259, 89)
        Me.lblHeightUnit.Name = "lblHeightUnit"
        Me.lblHeightUnit.Size = New System.Drawing.Size(88, 20)
        Me.lblHeightUnit.TabIndex = 63
        Me.lblHeightUnit.Text = "Meters(m)"
        '
        'lblSoilHeatFlux
        '
        Me.lblSoilHeatFlux.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSoilHeatFlux.Location = New System.Drawing.Point(18, 112)
        Me.lblSoilHeatFlux.Name = "lblSoilHeatFlux"
        Me.lblSoilHeatFlux.Size = New System.Drawing.Size(88, 20)
        Me.lblSoilHeatFlux.TabIndex = 59
        Me.lblSoilHeatFlux.Text = "Soil Heat Flux"
        '
        'lblHeight
        '
        Me.lblHeight.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeight.Location = New System.Drawing.Point(18, 89)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(147, 20)
        Me.lblHeight.TabIndex = 57
        Me.lblHeight.Text = "Height Of Wind Instrument(z)"
        '
        'lblSolarConstantUnit
        '
        Me.lblSolarConstantUnit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSolarConstantUnit.Location = New System.Drawing.Point(259, 66)
        Me.lblSolarConstantUnit.Name = "lblSolarConstantUnit"
        Me.lblSolarConstantUnit.Size = New System.Drawing.Size(88, 20)
        Me.lblSolarConstantUnit.TabIndex = 56
        Me.lblSolarConstantUnit.Text = "MJ.m^-2.min^-1"
        '
        'lblSigmaUnit
        '
        Me.lblSigmaUnit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSigmaUnit.Location = New System.Drawing.Point(259, 42)
        Me.lblSigmaUnit.Name = "lblSigmaUnit"
        Me.lblSigmaUnit.Size = New System.Drawing.Size(118, 24)
        Me.lblSigmaUnit.TabIndex = 55
        Me.lblSigmaUnit.Text = "MJ.K^-4.m^-2.day^-1"
        '
        'lbllambdaUnit
        '
        Me.lbllambdaUnit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbllambdaUnit.Location = New System.Drawing.Point(259, 19)
        Me.lbllambdaUnit.Name = "lbllambdaUnit"
        Me.lbllambdaUnit.Size = New System.Drawing.Size(88, 20)
        Me.lbllambdaUnit.TabIndex = 54
        Me.lbllambdaUnit.Text = "MJ.kg^-1"
        '
        'lblSolarConstant
        '
        Me.lblSolarConstant.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSolarConstant.Location = New System.Drawing.Point(18, 66)
        Me.lblSolarConstant.Name = "lblSolarConstant"
        Me.lblSolarConstant.Size = New System.Drawing.Size(110, 20)
        Me.lblSolarConstant.TabIndex = 52
        Me.lblSolarConstant.Text = "Solar Constant(Gsc)"
        '
        'lblSigma
        '
        Me.lblSigma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSigma.Location = New System.Drawing.Point(18, 42)
        Me.lblSigma.Name = "lblSigma"
        Me.lblSigma.Size = New System.Drawing.Size(110, 20)
        Me.lblSigma.TabIndex = 50
        Me.lblSigma.Text = "Sigma"
        '
        'lblLambda
        '
        Me.lblLambda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLambda.Location = New System.Drawing.Point(18, 19)
        Me.lblLambda.Name = "lblLambda"
        Me.lblLambda.Size = New System.Drawing.Size(110, 20)
        Me.lblLambda.TabIndex = 48
        Me.lblLambda.Text = "Lambda"
        '
        'grpRadiationConstants
        '
        Me.grpRadiationConstants.Controls.Add(Me.ucrNudBS)
        Me.grpRadiationConstants.Controls.Add(Me.ucrNudAS)
        Me.grpRadiationConstants.Controls.Add(Me.lblBS)
        Me.grpRadiationConstants.Controls.Add(Me.lblAS)
        Me.grpRadiationConstants.Location = New System.Drawing.Point(318, 16)
        Me.grpRadiationConstants.Name = "grpRadiationConstants"
        Me.grpRadiationConstants.Size = New System.Drawing.Size(113, 98)
        Me.grpRadiationConstants.TabIndex = 75
        Me.grpRadiationConstants.TabStop = False
        Me.grpRadiationConstants.Text = "Radiation Constants"
        '
        'ucrNudBS
        '
        Me.ucrNudBS.AutoSize = True
        Me.ucrNudBS.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBS.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBS.Location = New System.Drawing.Point(53, 63)
        Me.ucrNudBS.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBS.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBS.Name = "ucrNudBS"
        Me.ucrNudBS.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudBS.TabIndex = 67
        Me.ucrNudBS.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudAS
        '
        Me.ucrNudAS.AutoSize = True
        Me.ucrNudAS.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAS.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAS.Location = New System.Drawing.Point(53, 37)
        Me.ucrNudAS.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAS.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAS.Name = "ucrNudAS"
        Me.ucrNudAS.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAS.TabIndex = 48
        Me.ucrNudAS.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblBS
        '
        Me.lblBS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBS.Location = New System.Drawing.Point(17, 63)
        Me.lblBS.Name = "lblBS"
        Me.lblBS.Size = New System.Drawing.Size(29, 20)
        Me.lblBS.TabIndex = 66
        Me.lblBS.Text = "bs"
        '
        'lblAS
        '
        Me.lblAS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAS.Location = New System.Drawing.Point(17, 37)
        Me.lblAS.Name = "lblAS"
        Me.lblAS.Size = New System.Drawing.Size(29, 20)
        Me.lblAS.TabIndex = 61
        Me.lblAS.Text = "as"
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.AutoSize = True
        Me.ucrSdgButtons.Location = New System.Drawing.Point(12, 306)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(304, 29)
        Me.ucrSdgButtons.TabIndex = 33
        '
        'sdgPMConstants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 347)
        Me.Controls.Add(Me.grpRadiationConstants)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.Controls.Add(Me.grpConstants)
        Me.Controls.Add(Me.grpLocation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPMConstants"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penman Monteith Constants"
        Me.grpLocation.ResumeLayout(False)
        Me.grpLocation.PerformLayout()
        Me.grpConstants.ResumeLayout(False)
        Me.grpConstants.PerformLayout()
        Me.grpRadiationConstants.ResumeLayout(False)
        Me.grpRadiationConstants.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpLocation As GroupBox
    Friend WithEvents grpConstants As GroupBox
    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents lblAltitudeUnit As Label
    Friend WithEvents lblLatitudeUnit As Label
    Friend WithEvents lblAltitude As Label
    Friend WithEvents lblLatitude As Label
    Friend WithEvents ucrNudLatitude As ucrNud
    Friend WithEvents ucrNudAltitude As ucrNud
    Friend WithEvents lblSoilHeatFluxUnit As Label
    Friend WithEvents lblHeightUnit As Label
    Friend WithEvents lblSoilHeatFlux As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblSolarConstantUnit As Label
    Friend WithEvents lblSigmaUnit As Label
    Friend WithEvents lbllambdaUnit As Label
    Friend WithEvents lblSolarConstant As Label
    Friend WithEvents lblSigma As Label
    Friend WithEvents lblLambda As Label
    Friend WithEvents lblLongitudeUnit As Label
    Friend WithEvents lblLongitude As Label
    Friend WithEvents ucrNudLongitude As ucrNud
    Friend WithEvents ucrNudHeith As ucrNud
    Friend WithEvents grpRadiationConstants As GroupBox
    Friend WithEvents lblBS As Label
    Friend WithEvents lblAS As Label
    Friend WithEvents ucrNudBS As ucrNud
    Friend WithEvents ucrNudAS As ucrNud
    Friend WithEvents ucrNudLambda As ucrNud
    Friend WithEvents ucrNudSoil As ucrNud
    Friend WithEvents ucrNudSolar As ucrNud
    Friend WithEvents ucrInputSigma As ucrInputTextBox
End Class
