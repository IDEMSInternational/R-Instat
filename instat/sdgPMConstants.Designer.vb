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
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.rdoEst = New instat.ucrRadio()
        Me.ucrRadioNorth = New instat.ucrRadio()
        Me.ucrRadioWest = New instat.ucrRadio()
        Me.ucrNudLongitude = New instat.ucrNud()
        Me.ucrNudLatitude = New instat.ucrNud()
        Me.ucrNudElevation = New instat.ucrNud()
        Me.lblDegreesLon = New System.Windows.Forms.Label()
        Me.lblDegreesLat = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblElevationunit = New System.Windows.Forms.Label()
        Me.lblElevation = New System.Windows.Forms.Label()
        Me.gprConstants = New System.Windows.Forms.GroupBox()
        Me.ucrInputSigma = New instat.ucrInputTextBox()
        Me.ucrNudSoil = New instat.ucrNud()
        Me.ucrNudHeigth = New instat.ucrNud()
        Me.ucrNudSolarconstant = New instat.ucrNud()
        Me.ucrNudLambda = New instat.ucrNud()
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
        Me.ucrNudBS = New instat.ucrNud()
        Me.ucrNudAS = New instat.ucrNud()
        Me.lblBS = New System.Windows.Forms.Label()
        Me.lblAS = New System.Windows.Forms.Label()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.gprLocation.SuspendLayout()
        Me.gprConstants.SuspendLayout()
        Me.gprRadiation.SuspendLayout()
        Me.SuspendLayout()
        '
        'gprLocation
        '
        Me.gprLocation.Controls.Add(Me.RadioButton1)
        Me.gprLocation.Controls.Add(Me.rdoEst)
        Me.gprLocation.Controls.Add(Me.ucrRadioNorth)
        Me.gprLocation.Controls.Add(Me.ucrRadioWest)
        Me.gprLocation.Controls.Add(Me.ucrNudLongitude)
        Me.gprLocation.Controls.Add(Me.ucrNudLatitude)
        Me.gprLocation.Controls.Add(Me.ucrNudElevation)
        Me.gprLocation.Controls.Add(Me.lblDegreesLon)
        Me.gprLocation.Controls.Add(Me.lblDegreesLat)
        Me.gprLocation.Controls.Add(Me.lblLongitude)
        Me.gprLocation.Controls.Add(Me.lblLatitude)
        Me.gprLocation.Controls.Add(Me.lblElevationunit)
        Me.gprLocation.Controls.Add(Me.lblElevation)
        Me.gprLocation.Location = New System.Drawing.Point(18, 18)
        Me.gprLocation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gprLocation.Name = "gprLocation"
        Me.gprLocation.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gprLocation.Size = New System.Drawing.Size(465, 203)
        Me.gprLocation.TabIndex = 0
        Me.gprLocation.TabStop = False
        Me.gprLocation.Text = "Location"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(296, 169)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton1.TabIndex = 15
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'rdoEst
        '
        Me.rdoEst.AutoSize = True
        Me.rdoEst.Location = New System.Drawing.Point(296, 57)
        Me.rdoEst.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.rdoEst.Name = "rdoEst"
        Me.rdoEst.Size = New System.Drawing.Size(150, 31)
        Me.rdoEst.TabIndex = 12
        '
        'ucrRadioNorth
        '
        Me.ucrRadioNorth.AutoSize = True
        Me.ucrRadioNorth.Location = New System.Drawing.Point(296, 129)
        Me.ucrRadioNorth.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrRadioNorth.Name = "ucrRadioNorth"
        Me.ucrRadioNorth.Size = New System.Drawing.Size(150, 31)
        Me.ucrRadioNorth.TabIndex = 10
        '
        'ucrRadioWest
        '
        Me.ucrRadioWest.AutoSize = True
        Me.ucrRadioWest.Location = New System.Drawing.Point(296, 89)
        Me.ucrRadioWest.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrRadioWest.Name = "ucrRadioWest"
        Me.ucrRadioWest.Size = New System.Drawing.Size(150, 31)
        Me.ucrRadioWest.TabIndex = 9
        '
        'ucrNudLongitude
        '
        Me.ucrNudLongitude.AutoSize = True
        Me.ucrNudLongitude.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLongitude.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLongitude.Location = New System.Drawing.Point(98, 146)
        Me.ucrNudLongitude.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudLongitude.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLongitude.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLongitude.Name = "ucrNudLongitude"
        Me.ucrNudLongitude.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudLongitude.TabIndex = 8
        Me.ucrNudLongitude.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLatitude
        '
        Me.ucrNudLatitude.AutoSize = True
        Me.ucrNudLatitude.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLatitude.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLatitude.Location = New System.Drawing.Point(98, 78)
        Me.ucrNudLatitude.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudLatitude.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLatitude.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLatitude.Name = "ucrNudLatitude"
        Me.ucrNudLatitude.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudLatitude.TabIndex = 7
        Me.ucrNudLatitude.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudElevation
        '
        Me.ucrNudElevation.AutoSize = True
        Me.ucrNudElevation.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudElevation.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudElevation.Location = New System.Drawing.Point(98, 28)
        Me.ucrNudElevation.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudElevation.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudElevation.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudElevation.Name = "ucrNudElevation"
        Me.ucrNudElevation.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudElevation.TabIndex = 6
        Me.ucrNudElevation.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblDegreesLon
        '
        Me.lblDegreesLon.AutoSize = True
        Me.lblDegreesLon.Location = New System.Drawing.Point(196, 152)
        Me.lblDegreesLon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDegreesLon.Name = "lblDegreesLon"
        Me.lblDegreesLon.Size = New System.Drawing.Size(70, 20)
        Me.lblDegreesLon.TabIndex = 5
        Me.lblDegreesLon.Text = "Degrees"
        '
        'lblDegreesLat
        '
        Me.lblDegreesLat.AutoSize = True
        Me.lblDegreesLat.Location = New System.Drawing.Point(196, 78)
        Me.lblDegreesLat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDegreesLat.Name = "lblDegreesLat"
        Me.lblDegreesLat.Size = New System.Drawing.Size(70, 20)
        Me.lblDegreesLat.TabIndex = 4
        Me.lblDegreesLat.Text = "Degrees"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.Location = New System.Drawing.Point(9, 152)
        Me.lblLongitude.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(80, 20)
        Me.lblLongitude.TabIndex = 3
        Me.lblLongitude.Text = "Longitude"
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.Location = New System.Drawing.Point(10, 78)
        Me.lblLatitude.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(67, 20)
        Me.lblLatitude.TabIndex = 2
        Me.lblLatitude.Text = "Latitude"
        '
        'lblElevationunit
        '
        Me.lblElevationunit.AutoSize = True
        Me.lblElevationunit.Location = New System.Drawing.Point(196, 31)
        Me.lblElevationunit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblElevationunit.Name = "lblElevationunit"
        Me.lblElevationunit.Size = New System.Drawing.Size(58, 20)
        Me.lblElevationunit.TabIndex = 1
        Me.lblElevationunit.Text = "Meters"
        '
        'lblElevation
        '
        Me.lblElevation.AutoSize = True
        Me.lblElevation.Location = New System.Drawing.Point(10, 31)
        Me.lblElevation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblElevation.Name = "lblElevation"
        Me.lblElevation.Size = New System.Drawing.Size(74, 20)
        Me.lblElevation.TabIndex = 0
        Me.lblElevation.Text = "Elevation"
        '
        'gprConstants
        '
        Me.gprConstants.Controls.Add(Me.ucrInputSigma)
        Me.gprConstants.Controls.Add(Me.ucrNudSoil)
        Me.gprConstants.Controls.Add(Me.ucrNudHeigth)
        Me.gprConstants.Controls.Add(Me.ucrNudSolarconstant)
        Me.gprConstants.Controls.Add(Me.ucrNudLambda)
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
        Me.gprConstants.Location = New System.Drawing.Point(18, 231)
        Me.gprConstants.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gprConstants.Name = "gprConstants"
        Me.gprConstants.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gprConstants.Size = New System.Drawing.Size(542, 248)
        Me.gprConstants.TabIndex = 1
        Me.gprConstants.TabStop = False
        Me.gprConstants.Text = "Constants"
        '
        'ucrInputSigma
        '
        Me.ucrInputSigma.AddQuotesIfUnrecognised = True
        Me.ucrInputSigma.AutoSize = True
        Me.ucrInputSigma.IsMultiline = False
        Me.ucrInputSigma.IsReadOnly = False
        Me.ucrInputSigma.Location = New System.Drawing.Point(231, 151)
        Me.ucrInputSigma.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputSigma.Name = "ucrInputSigma"
        Me.ucrInputSigma.Size = New System.Drawing.Size(75, 32)
        Me.ucrInputSigma.TabIndex = 14
        '
        'ucrNudSoil
        '
        Me.ucrNudSoil.AutoSize = True
        Me.ucrNudSoil.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSoil.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSoil.Location = New System.Drawing.Point(231, 192)
        Me.ucrNudSoil.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudSoil.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSoil.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSoil.Name = "ucrNudSoil"
        Me.ucrNudSoil.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudSoil.TabIndex = 13
        Me.ucrNudSoil.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudHeigth
        '
        Me.ucrNudHeigth.AutoSize = True
        Me.ucrNudHeigth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHeigth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHeigth.Location = New System.Drawing.Point(231, 108)
        Me.ucrNudHeigth.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudHeigth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHeigth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHeigth.Name = "ucrNudHeigth"
        Me.ucrNudHeigth.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudHeigth.TabIndex = 12
        Me.ucrNudHeigth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSolarconstant
        '
        Me.ucrNudSolarconstant.AutoSize = True
        Me.ucrNudSolarconstant.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSolarconstant.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSolarconstant.Location = New System.Drawing.Point(231, 65)
        Me.ucrNudSolarconstant.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudSolarconstant.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSolarconstant.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSolarconstant.Name = "ucrNudSolarconstant"
        Me.ucrNudSolarconstant.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudSolarconstant.TabIndex = 11
        Me.ucrNudSolarconstant.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLambda
        '
        Me.ucrNudLambda.AutoSize = True
        Me.ucrNudLambda.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLambda.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLambda.Location = New System.Drawing.Point(231, 22)
        Me.ucrNudLambda.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudLambda.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLambda.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLambda.Name = "ucrNudLambda"
        Me.ucrNudLambda.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudLambda.TabIndex = 10
        Me.ucrNudLambda.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSoilFluxUnit
        '
        Me.lblSoilFluxUnit.AutoSize = True
        Me.lblSoilFluxUnit.Location = New System.Drawing.Point(360, 203)
        Me.lblSoilFluxUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSoilFluxUnit.Name = "lblSoilFluxUnit"
        Me.lblSoilFluxUnit.Size = New System.Drawing.Size(122, 20)
        Me.lblSoilFluxUnit.TabIndex = 9
        Me.lblSoilFluxUnit.Text = " MJ.m^-2.day^-1"
        '
        'lblSoilHeatFlux
        '
        Me.lblSoilHeatFlux.AutoSize = True
        Me.lblSoilHeatFlux.Location = New System.Drawing.Point(9, 203)
        Me.lblSoilHeatFlux.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSoilHeatFlux.Name = "lblSoilHeatFlux"
        Me.lblSoilHeatFlux.Size = New System.Drawing.Size(107, 20)
        Me.lblSoilHeatFlux.TabIndex = 8
        Me.lblSoilHeatFlux.Text = "Soil Heat Flux"
        '
        'lblSigma
        '
        Me.lblSigma.AutoSize = True
        Me.lblSigma.Location = New System.Drawing.Point(10, 163)
        Me.lblSigma.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSigma.Name = "lblSigma"
        Me.lblSigma.Size = New System.Drawing.Size(54, 20)
        Me.lblSigma.TabIndex = 7
        Me.lblSigma.Text = "Sigma"
        '
        'lblZUnit
        '
        Me.lblZUnit.AutoSize = True
        Me.lblZUnit.Location = New System.Drawing.Point(360, 120)
        Me.lblZUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblZUnit.Name = "lblZUnit"
        Me.lblZUnit.Size = New System.Drawing.Size(58, 20)
        Me.lblZUnit.TabIndex = 6
        Me.lblZUnit.Text = "Meters"
        '
        'lblGSCUnit
        '
        Me.lblGSCUnit.AutoSize = True
        Me.lblGSCUnit.Location = New System.Drawing.Point(360, 82)
        Me.lblGSCUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGSCUnit.Name = "lblGSCUnit"
        Me.lblGSCUnit.Size = New System.Drawing.Size(118, 20)
        Me.lblGSCUnit.TabIndex = 5
        Me.lblGSCUnit.Text = "MJ.m^-2.min^-1"
        '
        'lblSigmaUnit
        '
        Me.lblSigmaUnit.AutoSize = True
        Me.lblSigmaUnit.Location = New System.Drawing.Point(360, 154)
        Me.lblSigmaUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSigmaUnit.Name = "lblSigmaUnit"
        Me.lblSigmaUnit.Size = New System.Drawing.Size(153, 20)
        Me.lblSigmaUnit.TabIndex = 4
        Me.lblSigmaUnit.Text = "MJ.K^-4.m^-2.day^-1"
        '
        'lblHeightWindInstrument
        '
        Me.lblHeightWindInstrument.AutoSize = True
        Me.lblHeightWindInstrument.Location = New System.Drawing.Point(10, 120)
        Me.lblHeightWindInstrument.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeightWindInstrument.Name = "lblHeightWindInstrument"
        Me.lblHeightWindInstrument.Size = New System.Drawing.Size(195, 20)
        Me.lblHeightWindInstrument.TabIndex = 3
        Me.lblHeightWindInstrument.Text = "Height of Wind Instrument"
        '
        'lblLambaUnit
        '
        Me.lblLambaUnit.AutoSize = True
        Me.lblLambaUnit.Location = New System.Drawing.Point(360, 32)
        Me.lblLambaUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLambaUnit.Name = "lblLambaUnit"
        Me.lblLambaUnit.Size = New System.Drawing.Size(72, 20)
        Me.lblLambaUnit.TabIndex = 2
        Me.lblLambaUnit.Text = "MJ.kg^-1"
        '
        'lblSolarConstant
        '
        Me.lblSolarConstant.AutoSize = True
        Me.lblSolarConstant.Location = New System.Drawing.Point(9, 82)
        Me.lblSolarConstant.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSolarConstant.Name = "lblSolarConstant"
        Me.lblSolarConstant.Size = New System.Drawing.Size(154, 20)
        Me.lblSolarConstant.TabIndex = 1
        Me.lblSolarConstant.Text = "Solar Constant(Gsc)"
        '
        'lbllambda
        '
        Me.lbllambda.AutoSize = True
        Me.lbllambda.Location = New System.Drawing.Point(10, 32)
        Me.lbllambda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbllambda.Name = "lbllambda"
        Me.lbllambda.Size = New System.Drawing.Size(67, 20)
        Me.lbllambda.TabIndex = 0
        Me.lbllambda.Text = "Lambda"
        '
        'gprRadiation
        '
        Me.gprRadiation.Controls.Add(Me.ucrNudBS)
        Me.gprRadiation.Controls.Add(Me.ucrNudAS)
        Me.gprRadiation.Controls.Add(Me.lblBS)
        Me.gprRadiation.Controls.Add(Me.lblAS)
        Me.gprRadiation.Location = New System.Drawing.Point(492, 38)
        Me.gprRadiation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gprRadiation.Name = "gprRadiation"
        Me.gprRadiation.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gprRadiation.Size = New System.Drawing.Size(164, 145)
        Me.gprRadiation.TabIndex = 0
        Me.gprRadiation.TabStop = False
        Me.gprRadiation.Text = "Radiation Constants"
        '
        'ucrNudBS
        '
        Me.ucrNudBS.AutoSize = True
        Me.ucrNudBS.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBS.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBS.Location = New System.Drawing.Point(74, 102)
        Me.ucrNudBS.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudBS.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBS.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBS.Name = "ucrNudBS"
        Me.ucrNudBS.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudBS.TabIndex = 3
        Me.ucrNudBS.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudAS
        '
        Me.ucrNudAS.AutoSize = True
        Me.ucrNudAS.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAS.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAS.Location = New System.Drawing.Point(74, 62)
        Me.ucrNudAS.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudAS.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAS.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAS.Name = "ucrNudAS"
        Me.ucrNudAS.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudAS.TabIndex = 2
        Me.ucrNudAS.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblBS
        '
        Me.lblBS.AutoSize = True
        Me.lblBS.Location = New System.Drawing.Point(21, 112)
        Me.lblBS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBS.Name = "lblBS"
        Me.lblBS.Size = New System.Drawing.Size(26, 20)
        Me.lblBS.TabIndex = 1
        Me.lblBS.Text = "bs"
        '
        'lblAS
        '
        Me.lblAS.AutoSize = True
        Me.lblAS.Location = New System.Drawing.Point(21, 62)
        Me.lblAS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAS.Name = "lblAS"
        Me.lblAS.Size = New System.Drawing.Size(26, 20)
        Me.lblAS.TabIndex = 0
        Me.lblAS.Text = "as"
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.AutoSize = True
        Me.ucrSdgButtons.Location = New System.Drawing.Point(116, 486)
        Me.ucrSdgButtons.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(388, 45)
        Me.ucrSdgButtons.TabIndex = 5
        '
        'sdgPMConstants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 542)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.Controls.Add(Me.gprRadiation)
        Me.Controls.Add(Me.gprConstants)
        Me.Controls.Add(Me.gprLocation)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "sdgPMConstants"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sdgPMConstants"
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
    Friend WithEvents ucrNudElevation As ucrNud
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
    Friend WithEvents ucrNudLongitude As ucrNud
    Friend WithEvents ucrNudLatitude As ucrNud
    Friend WithEvents ucrNudSoil As ucrNud
    Friend WithEvents ucrNudHeigth As ucrNud
    Friend WithEvents ucrNudSolarconstant As ucrNud
    Friend WithEvents ucrNudLambda As ucrNud
    Friend WithEvents ucrNudBS As ucrNud
    Friend WithEvents ucrNudAS As ucrNud
    Friend WithEvents ucrInputSigma As ucrInputTextBox
    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents rdoEst As ucrRadio
    Friend WithEvents ucrRadioNorth As ucrRadio
    Friend WithEvents ucrRadioWest As ucrRadio
    Friend WithEvents RadioButton1 As RadioButton
End Class
