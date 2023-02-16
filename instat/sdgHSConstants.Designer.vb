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
        Me.ucrNudElevation = New instat.ucrNud()
        Me.gprLocation = New System.Windows.Forms.GroupBox()
        Me.ucrInputLongitude = New instat.ucrInputTextBox()
        Me.ucrInputLatitude = New instat.ucrInputTextBox()
        Me.lblDegreesLon = New System.Windows.Forms.Label()
        Me.lblDegreesLat = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblElevationunit = New System.Windows.Forms.Label()
        Me.lblElevation = New System.Windows.Forms.Label()
        Me.lblGSCUnit = New System.Windows.Forms.Label()
        Me.lblLambaUnit = New System.Windows.Forms.Label()
        Me.lblSolarConstant = New System.Windows.Forms.Label()
        Me.lbllambda = New System.Windows.Forms.Label()
        Me.gprConstants = New System.Windows.Forms.GroupBox()
        Me.gprLocation.SuspendLayout()
        Me.gprConstants.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.AutoSize = True
        Me.ucrSdgButtons.Location = New System.Drawing.Point(32, 244)
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
        Me.ucrInputSolarConstant.Location = New System.Drawing.Point(108, 53)
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
        Me.ucrInputLambda.Location = New System.Drawing.Point(108, 21)
        Me.ucrInputLambda.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputLambda.Name = "ucrInputLambda"
        Me.ucrInputLambda.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputLambda.TabIndex = 15
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
        Me.gprLocation.Location = New System.Drawing.Point(8, 12)
        Me.gprLocation.Name = "gprLocation"
        Me.gprLocation.Size = New System.Drawing.Size(171, 117)
        Me.gprLocation.TabIndex = 7
        Me.gprLocation.TabStop = False
        Me.gprLocation.Text = "Location"
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
        'lblDegreesLon
        '
        Me.lblDegreesLon.AutoSize = True
        Me.lblDegreesLon.Location = New System.Drawing.Point(120, 86)
        Me.lblDegreesLon.Name = "lblDegreesLon"
        Me.lblDegreesLon.Size = New System.Drawing.Size(46, 13)
        Me.lblDegreesLon.TabIndex = 5
        Me.lblDegreesLon.Text = "Radians"
        '
        'lblDegreesLat
        '
        Me.lblDegreesLat.AutoSize = True
        Me.lblDegreesLat.Location = New System.Drawing.Point(120, 51)
        Me.lblDegreesLat.Name = "lblDegreesLat"
        Me.lblDegreesLat.Size = New System.Drawing.Size(46, 13)
        Me.lblDegreesLat.TabIndex = 4
        Me.lblDegreesLat.Text = "Radians"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.Location = New System.Drawing.Point(5, 86)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(54, 13)
        Me.lblLongitude.TabIndex = 3
        Me.lblLongitude.Text = "Longitude"
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.Location = New System.Drawing.Point(5, 51)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(45, 13)
        Me.lblLatitude.TabIndex = 2
        Me.lblLatitude.Text = "Latitude"
        '
        'lblElevationunit
        '
        Me.lblElevationunit.AutoSize = True
        Me.lblElevationunit.Location = New System.Drawing.Point(120, 20)
        Me.lblElevationunit.Name = "lblElevationunit"
        Me.lblElevationunit.Size = New System.Drawing.Size(39, 13)
        Me.lblElevationunit.TabIndex = 1
        Me.lblElevationunit.Text = "Meters"
        '
        'lblElevation
        '
        Me.lblElevation.AutoSize = True
        Me.lblElevation.Location = New System.Drawing.Point(5, 20)
        Me.lblElevation.Name = "lblElevation"
        Me.lblElevation.Size = New System.Drawing.Size(51, 13)
        Me.lblElevation.TabIndex = 0
        Me.lblElevation.Text = "Elevation"
        '
        'lblGSCUnit
        '
        Me.lblGSCUnit.AutoSize = True
        Me.lblGSCUnit.Location = New System.Drawing.Point(167, 57)
        Me.lblGSCUnit.Name = "lblGSCUnit"
        Me.lblGSCUnit.Size = New System.Drawing.Size(81, 13)
        Me.lblGSCUnit.TabIndex = 5
        Me.lblGSCUnit.Text = "MJ.m^-2.min^-1"
        '
        'lblLambaUnit
        '
        Me.lblLambaUnit.AutoSize = True
        Me.lblLambaUnit.Location = New System.Drawing.Point(167, 25)
        Me.lblLambaUnit.Name = "lblLambaUnit"
        Me.lblLambaUnit.Size = New System.Drawing.Size(51, 13)
        Me.lblLambaUnit.TabIndex = 2
        Me.lblLambaUnit.Text = "MJ.kg^-1"
        '
        'lblSolarConstant
        '
        Me.lblSolarConstant.AutoSize = True
        Me.lblSolarConstant.Location = New System.Drawing.Point(5, 58)
        Me.lblSolarConstant.Name = "lblSolarConstant"
        Me.lblSolarConstant.Size = New System.Drawing.Size(101, 13)
        Me.lblSolarConstant.TabIndex = 1
        Me.lblSolarConstant.Text = "Solar Constant(Gsc)"
        '
        'lbllambda
        '
        Me.lbllambda.AutoSize = True
        Me.lbllambda.Location = New System.Drawing.Point(5, 26)
        Me.lbllambda.Name = "lbllambda"
        Me.lbllambda.Size = New System.Drawing.Size(45, 13)
        Me.lbllambda.TabIndex = 0
        Me.lbllambda.Text = "Lambda"
        '
        'gprConstants
        '
        Me.gprConstants.Controls.Add(Me.ucrInputSolarConstant)
        Me.gprConstants.Controls.Add(Me.ucrInputLambda)
        Me.gprConstants.Controls.Add(Me.lblGSCUnit)
        Me.gprConstants.Controls.Add(Me.lblLambaUnit)
        Me.gprConstants.Controls.Add(Me.lblSolarConstant)
        Me.gprConstants.Controls.Add(Me.lbllambda)
        Me.gprConstants.Location = New System.Drawing.Point(8, 135)
        Me.gprConstants.Name = "gprConstants"
        Me.gprConstants.Size = New System.Drawing.Size(250, 110)
        Me.gprConstants.TabIndex = 8
        Me.gprConstants.TabStop = False
        Me.gprConstants.Text = "Constants"
        '
        'sdgHSConstants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 277)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.Controls.Add(Me.gprLocation)
        Me.Controls.Add(Me.gprConstants)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgHSConstants"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hargreaves Samani Constants"
        Me.gprLocation.ResumeLayout(False)
        Me.gprLocation.PerformLayout()
        Me.gprConstants.ResumeLayout(False)
        Me.gprConstants.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents ucrInputSolarConstant As ucrInputTextBox
    Friend WithEvents ucrInputLambda As ucrInputTextBox
    Friend WithEvents ucrNudElevation As ucrNud
    Friend WithEvents gprLocation As GroupBox
    Friend WithEvents ucrInputLongitude As ucrInputTextBox
    Friend WithEvents ucrInputLatitude As ucrInputTextBox
    Friend WithEvents lblDegreesLon As Label
    Friend WithEvents lblDegreesLat As Label
    Friend WithEvents lblLongitude As Label
    Friend WithEvents lblLatitude As Label
    Friend WithEvents lblElevationunit As Label
    Friend WithEvents lblElevation As Label
    Friend WithEvents lblGSCUnit As Label
    Friend WithEvents lblLambaUnit As Label
    Friend WithEvents lblSolarConstant As Label
    Friend WithEvents lbllambda As Label
    Friend WithEvents gprConstants As GroupBox
End Class
