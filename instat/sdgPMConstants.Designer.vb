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
        Me.gprLocation = New System.Windows.Forms.GroupBox()
        Me.lblDegreesLon = New System.Windows.Forms.Label()
        Me.lblDegreesLat = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblElevationunit = New System.Windows.Forms.Label()
        Me.lblElevation = New System.Windows.Forms.Label()
        Me.gprConstants = New System.Windows.Forms.GroupBox()
        Me.lblSoilFluxUnit = New System.Windows.Forms.Label()
        Me.lblSoilHeatFlux = New System.Windows.Forms.Label()
        Me.lblSigma = New System.Windows.Forms.Label()
        Me.lblZUnit = New System.Windows.Forms.Label()
        Me.lblGSCUnit = New System.Windows.Forms.Label()
        Me.lblSigmaUnit = New System.Windows.Forms.Label()
        Me.lblHeightWindInstrument = New System.Windows.Forms.Label()
        Me.lblLambaUnit = New System.Windows.Forms.Label()
        Me.lblSolarConstant = New System.Windows.Forms.Label()
        Me.lbllambda = New System.Windows.Forms.Label()
        Me.gprRadiation = New System.Windows.Forms.GroupBox()
        Me.lblBS = New System.Windows.Forms.Label()
        Me.lblAS = New System.Windows.Forms.Label()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.ucrInputAS = New instat.ucrInputTextBox()
        Me.ucrInputBS = New instat.ucrInputTextBox()
        Me.ucrNudHeigth = New instat.ucrNud()
        Me.ucrInputSoilFlux = New instat.ucrInputTextBox()
        Me.ucrInputSolarConstant = New instat.ucrInputTextBox()
        Me.ucrInputLambda = New instat.ucrInputTextBox()
        Me.ucrInputSigma = New instat.ucrInputTextBox()
        Me.ucrInputLongitude = New instat.ucrInputTextBox()
        Me.ucrInputLatitude = New instat.ucrInputTextBox()
        Me.ucrNudElevation = New instat.ucrNud()
        Me.gprLocation.SuspendLayout()
        Me.gprConstants.SuspendLayout()
        Me.gprRadiation.SuspendLayout()
        Me.SuspendLayout()
        '
        'gprLocation
        '
        Me.gprLocation.Controls.Add(Me.ucrInputLongitude)
        Me.gprLocation.Controls.Add(Me.ucrInputLatitude)
        Me.gprLocation.Controls.Add(Me.ucrNudElevation)
        Me.gprLocation.Controls.Add(Me.lblDegreesLon)
        Me.gprLocation.Controls.Add(Me.lblDegreesLat)
        Me.gprLocation.Controls.Add(Me.lblLongitude)
        Me.gprLocation.Controls.Add(Me.lblLatitude)
        Me.gprLocation.Controls.Add(Me.lblElevationunit)
        Me.gprLocation.Controls.Add(Me.lblElevation)
        Me.gprLocation.Location = New System.Drawing.Point(12, 12)
        Me.gprLocation.Name = "gprLocation"
        Me.gprLocation.Size = New System.Drawing.Size(182, 117)
        Me.gprLocation.TabIndex = 0
        Me.gprLocation.TabStop = False
        Me.gprLocation.Text = "Location"
        '
        'lblDegreesLon
        '
        Me.lblDegreesLon.AutoSize = True
        Me.lblDegreesLon.Location = New System.Drawing.Point(131, 86)
        Me.lblDegreesLon.Name = "lblDegreesLon"
        Me.lblDegreesLon.Size = New System.Drawing.Size(46, 13)
        Me.lblDegreesLon.TabIndex = 5
        Me.lblDegreesLon.Text = "Radians"
        '
        'lblDegreesLat
        '
        Me.lblDegreesLat.AutoSize = True
        Me.lblDegreesLat.Location = New System.Drawing.Point(131, 51)
        Me.lblDegreesLat.Name = "lblDegreesLat"
        Me.lblDegreesLat.Size = New System.Drawing.Size(46, 13)
        Me.lblDegreesLat.TabIndex = 4
        Me.lblDegreesLat.Text = "Radians"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.Location = New System.Drawing.Point(6, 86)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(54, 13)
        Me.lblLongitude.TabIndex = 3
        Me.lblLongitude.Text = "Longitude"
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.Location = New System.Drawing.Point(7, 51)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(45, 13)
        Me.lblLatitude.TabIndex = 2
        Me.lblLatitude.Text = "Latitude"
        '
        'lblElevationunit
        '
        Me.lblElevationunit.AutoSize = True
        Me.lblElevationunit.Location = New System.Drawing.Point(131, 20)
        Me.lblElevationunit.Name = "lblElevationunit"
        Me.lblElevationunit.Size = New System.Drawing.Size(39, 13)
        Me.lblElevationunit.TabIndex = 1
        Me.lblElevationunit.Text = "Meters"
        '
        'lblElevation
        '
        Me.lblElevation.AutoSize = True
        Me.lblElevation.Location = New System.Drawing.Point(7, 20)
        Me.lblElevation.Name = "lblElevation"
        Me.lblElevation.Size = New System.Drawing.Size(51, 13)
        Me.lblElevation.TabIndex = 0
        Me.lblElevation.Text = "Elevation"
        '
        'gprConstants
        '
        Me.gprConstants.Controls.Add(Me.ucrNudHeigth)
        Me.gprConstants.Controls.Add(Me.ucrInputSoilFlux)
        Me.gprConstants.Controls.Add(Me.ucrInputSolarConstant)
        Me.gprConstants.Controls.Add(Me.ucrInputLambda)
        Me.gprConstants.Controls.Add(Me.ucrInputSigma)
        Me.gprConstants.Controls.Add(Me.lblSoilFluxUnit)
        Me.gprConstants.Controls.Add(Me.lblSoilHeatFlux)
        Me.gprConstants.Controls.Add(Me.lblSigma)
        Me.gprConstants.Controls.Add(Me.lblZUnit)
        Me.gprConstants.Controls.Add(Me.lblGSCUnit)
        Me.gprConstants.Controls.Add(Me.lblSigmaUnit)
        Me.gprConstants.Controls.Add(Me.lblHeightWindInstrument)
        Me.gprConstants.Controls.Add(Me.lblLambaUnit)
        Me.gprConstants.Controls.Add(Me.lblSolarConstant)
        Me.gprConstants.Controls.Add(Me.lbllambda)
        Me.gprConstants.Location = New System.Drawing.Point(12, 135)
        Me.gprConstants.Name = "gprConstants"
        Me.gprConstants.Size = New System.Drawing.Size(324, 161)
        Me.gprConstants.TabIndex = 1
        Me.gprConstants.TabStop = False
        Me.gprConstants.Text = "Constants"
        '
        'lblSoilFluxUnit
        '
        Me.lblSoilFluxUnit.AutoSize = True
        Me.lblSoilFluxUnit.Location = New System.Drawing.Point(222, 136)
        Me.lblSoilFluxUnit.Name = "lblSoilFluxUnit"
        Me.lblSoilFluxUnit.Size = New System.Drawing.Size(85, 13)
        Me.lblSoilFluxUnit.TabIndex = 9
        Me.lblSoilFluxUnit.Text = " MJ.m^-2.day^-1"
        '
        'lblSoilHeatFlux
        '
        Me.lblSoilHeatFlux.AutoSize = True
        Me.lblSoilHeatFlux.Location = New System.Drawing.Point(6, 137)
        Me.lblSoilHeatFlux.Name = "lblSoilHeatFlux"
        Me.lblSoilHeatFlux.Size = New System.Drawing.Size(72, 13)
        Me.lblSoilHeatFlux.TabIndex = 8
        Me.lblSoilHeatFlux.Text = "Soil Heat Flux"
        '
        'lblSigma
        '
        Me.lblSigma.AutoSize = True
        Me.lblSigma.Location = New System.Drawing.Point(7, 111)
        Me.lblSigma.Name = "lblSigma"
        Me.lblSigma.Size = New System.Drawing.Size(36, 13)
        Me.lblSigma.TabIndex = 7
        Me.lblSigma.Text = "Sigma"
        '
        'lblZUnit
        '
        Me.lblZUnit.AutoSize = True
        Me.lblZUnit.Location = New System.Drawing.Point(222, 83)
        Me.lblZUnit.Name = "lblZUnit"
        Me.lblZUnit.Size = New System.Drawing.Size(39, 13)
        Me.lblZUnit.TabIndex = 6
        Me.lblZUnit.Text = "Meters"
        '
        'lblGSCUnit
        '
        Me.lblGSCUnit.AutoSize = True
        Me.lblGSCUnit.Location = New System.Drawing.Point(222, 57)
        Me.lblGSCUnit.Name = "lblGSCUnit"
        Me.lblGSCUnit.Size = New System.Drawing.Size(81, 13)
        Me.lblGSCUnit.TabIndex = 5
        Me.lblGSCUnit.Text = "MJ.m^-2.min^-1"
        '
        'lblSigmaUnit
        '
        Me.lblSigmaUnit.AutoSize = True
        Me.lblSigmaUnit.Location = New System.Drawing.Point(222, 110)
        Me.lblSigmaUnit.Name = "lblSigmaUnit"
        Me.lblSigmaUnit.Size = New System.Drawing.Size(107, 13)
        Me.lblSigmaUnit.TabIndex = 4
        Me.lblSigmaUnit.Text = "MJ.K^-4.m^-2.day^-1"
        '
        'lblHeightWindInstrument
        '
        Me.lblHeightWindInstrument.AutoSize = True
        Me.lblHeightWindInstrument.Location = New System.Drawing.Point(7, 83)
        Me.lblHeightWindInstrument.Name = "lblHeightWindInstrument"
        Me.lblHeightWindInstrument.Size = New System.Drawing.Size(130, 13)
        Me.lblHeightWindInstrument.TabIndex = 3
        Me.lblHeightWindInstrument.Text = "Height of Wind Instrument"
        '
        'lblLambaUnit
        '
        Me.lblLambaUnit.AutoSize = True
        Me.lblLambaUnit.Location = New System.Drawing.Point(222, 25)
        Me.lblLambaUnit.Name = "lblLambaUnit"
        Me.lblLambaUnit.Size = New System.Drawing.Size(51, 13)
        Me.lblLambaUnit.TabIndex = 2
        Me.lblLambaUnit.Text = "MJ.kg^-1"
        '
        'lblSolarConstant
        '
        Me.lblSolarConstant.AutoSize = True
        Me.lblSolarConstant.Location = New System.Drawing.Point(6, 58)
        Me.lblSolarConstant.Name = "lblSolarConstant"
        Me.lblSolarConstant.Size = New System.Drawing.Size(101, 13)
        Me.lblSolarConstant.TabIndex = 1
        Me.lblSolarConstant.Text = "Solar Constant(Gsc)"
        '
        'lbllambda
        '
        Me.lbllambda.AutoSize = True
        Me.lbllambda.Location = New System.Drawing.Point(7, 26)
        Me.lbllambda.Name = "lbllambda"
        Me.lbllambda.Size = New System.Drawing.Size(45, 13)
        Me.lbllambda.TabIndex = 0
        Me.lbllambda.Text = "Lambda"
        '
        'gprRadiation
        '
        Me.gprRadiation.Controls.Add(Me.ucrInputAS)
        Me.gprRadiation.Controls.Add(Me.ucrInputBS)
        Me.gprRadiation.Controls.Add(Me.lblBS)
        Me.gprRadiation.Controls.Add(Me.lblAS)
        Me.gprRadiation.Location = New System.Drawing.Point(227, 12)
        Me.gprRadiation.Name = "gprRadiation"
        Me.gprRadiation.Size = New System.Drawing.Size(109, 117)
        Me.gprRadiation.TabIndex = 0
        Me.gprRadiation.TabStop = False
        Me.gprRadiation.Text = "Radiation Constants"
        '
        'lblBS
        '
        Me.lblBS.AutoSize = True
        Me.lblBS.Location = New System.Drawing.Point(14, 75)
        Me.lblBS.Name = "lblBS"
        Me.lblBS.Size = New System.Drawing.Size(18, 13)
        Me.lblBS.TabIndex = 1
        Me.lblBS.Text = "bs"
        '
        'lblAS
        '
        Me.lblAS.AutoSize = True
        Me.lblAS.Location = New System.Drawing.Point(14, 40)
        Me.lblAS.Name = "lblAS"
        Me.lblAS.Size = New System.Drawing.Size(18, 13)
        Me.lblAS.TabIndex = 0
        Me.lblAS.Text = "as"
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.AutoSize = True
        Me.ucrSdgButtons.Location = New System.Drawing.Point(46, 303)
        Me.ucrSdgButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(259, 29)
        Me.ucrSdgButtons.TabIndex = 5
        '
        'ucrInputAS
        '
        Me.ucrInputAS.AddQuotesIfUnrecognised = True
        Me.ucrInputAS.AutoSize = True
        Me.ucrInputAS.IsMultiline = False
        Me.ucrInputAS.IsReadOnly = False
        Me.ucrInputAS.Location = New System.Drawing.Point(41, 40)
        Me.ucrInputAS.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputAS.Name = "ucrInputAS"
        Me.ucrInputAS.Size = New System.Drawing.Size(50, 21)
        Me.ucrInputAS.TabIndex = 16
        '
        'ucrInputBS
        '
        Me.ucrInputBS.AddQuotesIfUnrecognised = True
        Me.ucrInputBS.AutoSize = True
        Me.ucrInputBS.IsMultiline = False
        Me.ucrInputBS.IsReadOnly = False
        Me.ucrInputBS.Location = New System.Drawing.Point(41, 75)
        Me.ucrInputBS.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputBS.Name = "ucrInputBS"
        Me.ucrInputBS.Size = New System.Drawing.Size(50, 21)
        Me.ucrInputBS.TabIndex = 15
        '
        'ucrNudHeigth
        '
        Me.ucrNudHeigth.AutoSize = True
        Me.ucrNudHeigth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHeigth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHeigth.Location = New System.Drawing.Point(144, 81)
        Me.ucrNudHeigth.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudHeigth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHeigth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHeigth.Name = "ucrNudHeigth"
        Me.ucrNudHeigth.Size = New System.Drawing.Size(63, 20)
        Me.ucrNudHeigth.TabIndex = 19
        Me.ucrNudHeigth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputSoilFlux
        '
        Me.ucrInputSoilFlux.AddQuotesIfUnrecognised = True
        Me.ucrInputSoilFlux.AutoSize = True
        Me.ucrInputSoilFlux.IsMultiline = False
        Me.ucrInputSoilFlux.IsReadOnly = False
        Me.ucrInputSoilFlux.Location = New System.Drawing.Point(144, 132)
        Me.ucrInputSoilFlux.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSoilFlux.Name = "ucrInputSoilFlux"
        Me.ucrInputSoilFlux.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputSoilFlux.TabIndex = 18
        '
        'ucrInputSolarConstant
        '
        Me.ucrInputSolarConstant.AddQuotesIfUnrecognised = True
        Me.ucrInputSolarConstant.AutoSize = True
        Me.ucrInputSolarConstant.IsMultiline = False
        Me.ucrInputSolarConstant.IsReadOnly = False
        Me.ucrInputSolarConstant.Location = New System.Drawing.Point(144, 53)
        Me.ucrInputSolarConstant.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSolarConstant.Name = "ucrInputSolarConstant"
        Me.ucrInputSolarConstant.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputSolarConstant.TabIndex = 16
        '
        'ucrInputLambda
        '
        Me.ucrInputLambda.AddQuotesIfUnrecognised = True
        Me.ucrInputLambda.AutoSize = True
        Me.ucrInputLambda.IsMultiline = False
        Me.ucrInputLambda.IsReadOnly = False
        Me.ucrInputLambda.Location = New System.Drawing.Point(144, 21)
        Me.ucrInputLambda.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputLambda.Name = "ucrInputLambda"
        Me.ucrInputLambda.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputLambda.TabIndex = 15
        '
        'ucrInputSigma
        '
        Me.ucrInputSigma.AddQuotesIfUnrecognised = True
        Me.ucrInputSigma.AutoSize = True
        Me.ucrInputSigma.IsMultiline = False
        Me.ucrInputSigma.IsReadOnly = False
        Me.ucrInputSigma.Location = New System.Drawing.Point(144, 106)
        Me.ucrInputSigma.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSigma.Name = "ucrInputSigma"
        Me.ucrInputSigma.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputSigma.TabIndex = 14
        '
        'ucrInputLongitude
        '
        Me.ucrInputLongitude.AddQuotesIfUnrecognised = True
        Me.ucrInputLongitude.AutoSize = True
        Me.ucrInputLongitude.IsMultiline = False
        Me.ucrInputLongitude.IsReadOnly = False
        Me.ucrInputLongitude.Location = New System.Drawing.Point(64, 82)
        Me.ucrInputLongitude.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputLongitude.Name = "ucrInputLongitude"
        Me.ucrInputLongitude.Size = New System.Drawing.Size(50, 21)
        Me.ucrInputLongitude.TabIndex = 16
        '
        'ucrInputLatitude
        '
        Me.ucrInputLatitude.AddQuotesIfUnrecognised = True
        Me.ucrInputLatitude.AutoSize = True
        Me.ucrInputLatitude.IsMultiline = False
        Me.ucrInputLatitude.IsReadOnly = False
        Me.ucrInputLatitude.Location = New System.Drawing.Point(64, 51)
        Me.ucrInputLatitude.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputLatitude.Name = "ucrInputLatitude"
        Me.ucrInputLatitude.Size = New System.Drawing.Size(50, 21)
        Me.ucrInputLatitude.TabIndex = 15
        '
        'ucrNudElevation
        '
        Me.ucrNudElevation.AutoSize = True
        Me.ucrNudElevation.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudElevation.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudElevation.Location = New System.Drawing.Point(65, 18)
        Me.ucrNudElevation.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudElevation.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudElevation.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudElevation.Name = "ucrNudElevation"
        Me.ucrNudElevation.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudElevation.TabIndex = 6
        Me.ucrNudElevation.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'sdgPMConstants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 340)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.Controls.Add(Me.gprRadiation)
        Me.Controls.Add(Me.gprConstants)
        Me.Controls.Add(Me.gprLocation)
        Me.Name = "sdgPMConstants"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penman Monteith Constants"
        Me.gprLocation.ResumeLayout(False)
        Me.gprLocation.PerformLayout()
        Me.gprConstants.ResumeLayout(False)
        Me.gprConstants.PerformLayout()
        Me.gprRadiation.ResumeLayout(False)
        Me.gprRadiation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gprLocation As GroupBox
    Friend WithEvents lblDegreesLon As Label
    Friend WithEvents lblDegreesLat As Label
    Friend WithEvents lblLongitude As Label
    Friend WithEvents lblLatitude As Label
    Friend WithEvents lblElevationunit As Label
    Friend WithEvents lblElevation As Label
    Friend WithEvents gprConstants As GroupBox
    Friend WithEvents lblSoilFluxUnit As Label
    Friend WithEvents lblSoilHeatFlux As Label
    Friend WithEvents lblSigma As Label
    Friend WithEvents lblZUnit As Label
    Friend WithEvents lblGSCUnit As Label
    Friend WithEvents lblSigmaUnit As Label
    Friend WithEvents lblHeightWindInstrument As Label
    Friend WithEvents lblLambaUnit As Label
    Friend WithEvents lblSolarConstant As Label
    Friend WithEvents lbllambda As Label
    Friend WithEvents gprRadiation As GroupBox
    Friend WithEvents lblBS As Label
    Friend WithEvents lblAS As Label
    Friend WithEvents ucrInputSigma As ucrInputTextBox
    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents ucrInputLongitude As ucrInputTextBox
    Friend WithEvents ucrInputLatitude As ucrInputTextBox
    Friend WithEvents ucrNudElevation As ucrNud
    Friend WithEvents ucrInputSoilFlux As ucrInputTextBox
    Friend WithEvents ucrInputSolarConstant As ucrInputTextBox
    Friend WithEvents ucrInputLambda As ucrInputTextBox
    Friend WithEvents ucrInputAS As ucrInputTextBox
    Friend WithEvents ucrInputBS As ucrInputTextBox
    Friend WithEvents ucrNudHeigth As ucrNud
End Class
