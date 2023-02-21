<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgLocation
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
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblAltitude = New System.Windows.Forms.Label()
        Me.Station = New System.Windows.Forms.Label()
        Me.ucrReceiverAltitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverLongitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSubDialogueBase = New instat.ucrButtonsSubdialogue()
        Me.ucrSelectorLocation = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.lblDegreesLon = New System.Windows.Forms.Label()
        Me.lblDegreesLat = New System.Windows.Forms.Label()
        Me.lblElevationunit = New System.Windows.Forms.Label()
        Me.ucrInputLongitude = New instat.ucrInputTextBox()
        Me.lblLongitude1 = New System.Windows.Forms.Label()
        Me.lblLatitude1 = New System.Windows.Forms.Label()
        Me.ucrInputLatitude = New instat.ucrInputTextBox()
        Me.ucrInputElevation = New instat.ucrInputTextBox()
        Me.lblAltitude1 = New System.Windows.Forms.Label()
        Me.grpLocation.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.Location = New System.Drawing.Point(250, 80)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(45, 13)
        Me.lblLatitude.TabIndex = 0
        Me.lblLatitude.Text = "Latitude"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.Location = New System.Drawing.Point(250, 118)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(54, 13)
        Me.lblLongitude.TabIndex = 1
        Me.lblLongitude.Text = "Longitude"
        '
        'lblAltitude
        '
        Me.lblAltitude.AutoSize = True
        Me.lblAltitude.Location = New System.Drawing.Point(250, 43)
        Me.lblAltitude.Name = "lblAltitude"
        Me.lblAltitude.Size = New System.Drawing.Size(42, 13)
        Me.lblAltitude.TabIndex = 2
        Me.lblAltitude.Text = "Altitude"
        '
        'Station
        '
        Me.Station.AutoSize = True
        Me.Station.Location = New System.Drawing.Point(250, 9)
        Me.Station.Name = "Station"
        Me.Station.Size = New System.Drawing.Size(40, 13)
        Me.Station.TabIndex = 3
        Me.Station.Text = "Station"
        '
        'ucrReceiverAltitude
        '
        Me.ucrReceiverAltitude.AutoSize = True
        Me.ucrReceiverAltitude.frmParent = Me
        Me.ucrReceiverAltitude.Location = New System.Drawing.Point(250, 56)
        Me.ucrReceiverAltitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAltitude.Name = "ucrReceiverAltitude"
        Me.ucrReceiverAltitude.Selector = Nothing
        Me.ucrReceiverAltitude.Size = New System.Drawing.Size(89, 20)
        Me.ucrReceiverAltitude.strNcFilePath = ""
        Me.ucrReceiverAltitude.TabIndex = 6
        Me.ucrReceiverAltitude.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.AutoSize = True
        Me.ucrReceiverLatitude.frmParent = Me
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(250, 93)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(89, 20)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 7
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.AutoSize = True
        Me.ucrReceiverLongitude.frmParent = Me
        Me.ucrReceiverLongitude.Location = New System.Drawing.Point(250, 132)
        Me.ucrReceiverLongitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.Size = New System.Drawing.Size(89, 20)
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.TabIndex = 8
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(250, 22)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(89, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 9
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSubDialogueBase
        '
        Me.ucrSubDialogueBase.AutoSize = True
        Me.ucrSubDialogueBase.Location = New System.Drawing.Point(66, 195)
        Me.ucrSubDialogueBase.Name = "ucrSubDialogueBase"
        Me.ucrSubDialogueBase.Size = New System.Drawing.Size(224, 30)
        Me.ucrSubDialogueBase.TabIndex = 10
        '
        'ucrSelectorLocation
        '
        Me.ucrSelectorLocation.AutoSize = True
        Me.ucrSelectorLocation.bDropUnusedFilterLevels = False
        Me.ucrSelectorLocation.bShowHiddenColumns = False
        Me.ucrSelectorLocation.bUseCurrentFilter = True
        Me.ucrSelectorLocation.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorLocation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorLocation.Name = "ucrSelectorLocation"
        Me.ucrSelectorLocation.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorLocation.TabIndex = 11
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.lblAltitude1)
        Me.grpLocation.Controls.Add(Me.ucrInputElevation)
        Me.grpLocation.Controls.Add(Me.ucrInputLatitude)
        Me.grpLocation.Controls.Add(Me.lblLatitude1)
        Me.grpLocation.Controls.Add(Me.lblLongitude1)
        Me.grpLocation.Controls.Add(Me.ucrInputLongitude)
        Me.grpLocation.Controls.Add(Me.lblDegreesLon)
        Me.grpLocation.Controls.Add(Me.lblDegreesLat)
        Me.grpLocation.Controls.Add(Me.lblElevationunit)
        Me.grpLocation.Location = New System.Drawing.Point(10, 15)
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.Size = New System.Drawing.Size(212, 116)
        Me.grpLocation.TabIndex = 18
        Me.grpLocation.TabStop = False
        Me.grpLocation.Text = "Location"
        '
        'lblDegreesLon
        '
        Me.lblDegreesLon.AutoSize = True
        Me.lblDegreesLon.Location = New System.Drawing.Point(164, 87)
        Me.lblDegreesLon.Name = "lblDegreesLon"
        Me.lblDegreesLon.Size = New System.Drawing.Size(46, 13)
        Me.lblDegreesLon.TabIndex = 8
        Me.lblDegreesLon.Text = "Radians"
        '
        'lblDegreesLat
        '
        Me.lblDegreesLat.AutoSize = True
        Me.lblDegreesLat.Location = New System.Drawing.Point(164, 58)
        Me.lblDegreesLat.Name = "lblDegreesLat"
        Me.lblDegreesLat.Size = New System.Drawing.Size(46, 13)
        Me.lblDegreesLat.TabIndex = 7
        Me.lblDegreesLat.Text = "Radians"
        '
        'lblElevationunit
        '
        Me.lblElevationunit.AutoSize = True
        Me.lblElevationunit.Location = New System.Drawing.Point(164, 30)
        Me.lblElevationunit.Name = "lblElevationunit"
        Me.lblElevationunit.Size = New System.Drawing.Size(39, 13)
        Me.lblElevationunit.TabIndex = 6
        Me.lblElevationunit.Text = "Meters"
        '
        'ucrInputLongitude
        '
        Me.ucrInputLongitude.AddQuotesIfUnrecognised = True
        Me.ucrInputLongitude.AutoSize = True
        Me.ucrInputLongitude.IsMultiline = False
        Me.ucrInputLongitude.IsReadOnly = False
        Me.ucrInputLongitude.Location = New System.Drawing.Point(67, 81)
        Me.ucrInputLongitude.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputLongitude.Name = "ucrInputLongitude"
        Me.ucrInputLongitude.Size = New System.Drawing.Size(89, 21)
        Me.ucrInputLongitude.TabIndex = 17
        '
        'lblLongitude1
        '
        Me.lblLongitude1.AutoSize = True
        Me.lblLongitude1.Location = New System.Drawing.Point(9, 87)
        Me.lblLongitude1.Name = "lblLongitude1"
        Me.lblLongitude1.Size = New System.Drawing.Size(54, 13)
        Me.lblLongitude1.TabIndex = 19
        Me.lblLongitude1.Text = "Longitude"
        '
        'lblLatitude1
        '
        Me.lblLatitude1.AutoSize = True
        Me.lblLatitude1.Location = New System.Drawing.Point(9, 58)
        Me.lblLatitude1.Name = "lblLatitude1"
        Me.lblLatitude1.Size = New System.Drawing.Size(45, 13)
        Me.lblLatitude1.TabIndex = 20
        Me.lblLatitude1.Text = "Latitude"
        '
        'ucrInputLatitude
        '
        Me.ucrInputLatitude.AddQuotesIfUnrecognised = True
        Me.ucrInputLatitude.AutoSize = True
        Me.ucrInputLatitude.IsMultiline = False
        Me.ucrInputLatitude.IsReadOnly = False
        Me.ucrInputLatitude.Location = New System.Drawing.Point(67, 54)
        Me.ucrInputLatitude.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputLatitude.Name = "ucrInputLatitude"
        Me.ucrInputLatitude.Size = New System.Drawing.Size(89, 20)
        Me.ucrInputLatitude.TabIndex = 21
        '
        'ucrInputElevation
        '
        Me.ucrInputElevation.AddQuotesIfUnrecognised = True
        Me.ucrInputElevation.AutoSize = True
        Me.ucrInputElevation.IsMultiline = False
        Me.ucrInputElevation.IsReadOnly = False
        Me.ucrInputElevation.Location = New System.Drawing.Point(67, 25)
        Me.ucrInputElevation.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputElevation.Name = "ucrInputElevation"
        Me.ucrInputElevation.Size = New System.Drawing.Size(89, 21)
        Me.ucrInputElevation.TabIndex = 19
        '
        'lblAltitude1
        '
        Me.lblAltitude1.AutoSize = True
        Me.lblAltitude1.Location = New System.Drawing.Point(9, 30)
        Me.lblAltitude1.Name = "lblAltitude1"
        Me.lblAltitude1.Size = New System.Drawing.Size(42, 13)
        Me.lblAltitude1.TabIndex = 22
        Me.lblAltitude1.Text = "Altitude"
        '
        'sdgLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 236)
        Me.Controls.Add(Me.ucrSelectorLocation)
        Me.Controls.Add(Me.ucrSubDialogueBase)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.Station)
        Me.Controls.Add(Me.ucrReceiverLongitude)
        Me.Controls.Add(Me.lblLongitude)
        Me.Controls.Add(Me.lblLatitude)
        Me.Controls.Add(Me.ucrReceiverLatitude)
        Me.Controls.Add(Me.ucrReceiverAltitude)
        Me.Controls.Add(Me.lblAltitude)
        Me.Controls.Add(Me.grpLocation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgLocation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Location"
        Me.grpLocation.ResumeLayout(False)
        Me.grpLocation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLatitude As Label
    Friend WithEvents lblLongitude As Label
    Friend WithEvents lblAltitude As Label
    Friend WithEvents Station As Label
    Friend WithEvents ucrReceiverAltitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverLongitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents ucrSelectorLocation As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSubDialogueBase As ucrButtonsSubdialogue
    Friend WithEvents grpLocation As GroupBox
    Friend WithEvents lblAltitude1 As Label
    Friend WithEvents ucrInputElevation As ucrInputTextBox
    Friend WithEvents ucrInputLatitude As ucrInputTextBox
    Friend WithEvents lblLatitude1 As Label
    Friend WithEvents lblLongitude1 As Label
    Friend WithEvents ucrInputLongitude As ucrInputTextBox
    Friend WithEvents lblDegreesLon As Label
    Friend WithEvents lblDegreesLat As Label
    Friend WithEvents lblElevationunit As Label
End Class
