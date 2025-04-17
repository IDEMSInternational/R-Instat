<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDefineTricotData
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
        Me.ucrBase = New instat.ucrButtons()
        Me.grpDateTime = New System.Windows.Forms.GroupBox()
        Me.lblTraits = New System.Windows.Forms.Label()
        Me.ucrReceiverLevelOverallTraits = New instat.ucrReceiverMultiple()
        Me.ucrReceiverLevelVarieties = New instat.ucrReceiverMultiple()
        Me.lblVarieties = New System.Windows.Forms.Label()
        Me.lblPlantingDate = New System.Windows.Forms.Label()
        Me.lblLon = New System.Windows.Forms.Label()
        Me.ucrReceiverLevelPlantingDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverLevelLongitude = New instat.ucrReceiverSingle()
        Me.lblLat = New System.Windows.Forms.Label()
        Me.ucrReceiverLevelLatitude = New instat.ucrReceiverSingle()
        Me.ucrSelectorIDLevelData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblID = New System.Windows.Forms.Label()
        Me.ucrReceiverLevelID = New instat.ucrReceiverSingle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucrSelectorVarietyLevelData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblVVariety = New System.Windows.Forms.Label()
        Me.ucrReceiverVarietyLevelVariety = New instat.ucrReceiverSingle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblIVTraits = New System.Windows.Forms.Label()
        Me.ucrReceiverIDVarietyLevelTraits = New instat.ucrReceiverMultiple()
        Me.ucrReceiverIDVarietyLevelID = New instat.ucrReceiverSingle()
        Me.lblIVID = New System.Windows.Forms.Label()
        Me.ucrSelectorIDVarietyLevel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblIVVariety = New System.Windows.Forms.Label()
        Me.ucrReceiverIDVarietyLevelVariety = New instat.ucrReceiverSingle()
        Me.grpDateTime.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(13, 614)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 14
        '
        'grpDateTime
        '
        Me.grpDateTime.Controls.Add(Me.lblTraits)
        Me.grpDateTime.Controls.Add(Me.ucrReceiverLevelOverallTraits)
        Me.grpDateTime.Controls.Add(Me.ucrReceiverLevelVarieties)
        Me.grpDateTime.Controls.Add(Me.lblVarieties)
        Me.grpDateTime.Controls.Add(Me.lblPlantingDate)
        Me.grpDateTime.Controls.Add(Me.lblLon)
        Me.grpDateTime.Controls.Add(Me.ucrReceiverLevelPlantingDate)
        Me.grpDateTime.Controls.Add(Me.ucrReceiverLevelLongitude)
        Me.grpDateTime.Controls.Add(Me.lblLat)
        Me.grpDateTime.Controls.Add(Me.ucrReceiverLevelLatitude)
        Me.grpDateTime.Controls.Add(Me.ucrSelectorIDLevelData)
        Me.grpDateTime.Controls.Add(Me.lblID)
        Me.grpDateTime.Controls.Add(Me.ucrReceiverLevelID)
        Me.grpDateTime.Location = New System.Drawing.Point(13, 7)
        Me.grpDateTime.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDateTime.Name = "grpDateTime"
        Me.grpDateTime.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDateTime.Size = New System.Drawing.Size(710, 300)
        Me.grpDateTime.TabIndex = 0
        Me.grpDateTime.TabStop = False
        Me.grpDateTime.Tag = ""
        Me.grpDateTime.Text = "ID-Level Data"
        '
        'lblTraits
        '
        Me.lblTraits.AutoSize = True
        Me.lblTraits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTraits.Location = New System.Drawing.Point(523, 142)
        Me.lblTraits.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTraits.Name = "lblTraits"
        Me.lblTraits.Size = New System.Drawing.Size(52, 20)
        Me.lblTraits.TabIndex = 12
        Me.lblTraits.Text = "Traits:"
        '
        'ucrReceiverLevelOverallTraits
        '
        Me.ucrReceiverLevelOverallTraits.AutoSize = True
        Me.ucrReceiverLevelOverallTraits.frmParent = Me
        Me.ucrReceiverLevelOverallTraits.Location = New System.Drawing.Point(519, 162)
        Me.ucrReceiverLevelOverallTraits.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLevelOverallTraits.Name = "ucrReceiverLevelOverallTraits"
        Me.ucrReceiverLevelOverallTraits.Selector = Nothing
        Me.ucrReceiverLevelOverallTraits.Size = New System.Drawing.Size(180, 124)
        Me.ucrReceiverLevelOverallTraits.strNcFilePath = ""
        Me.ucrReceiverLevelOverallTraits.TabIndex = 7
        Me.ucrReceiverLevelOverallTraits.ucrSelector = Nothing
        '
        'ucrReceiverLevelVarieties
        '
        Me.ucrReceiverLevelVarieties.AutoSize = True
        Me.ucrReceiverLevelVarieties.frmParent = Me
        Me.ucrReceiverLevelVarieties.Location = New System.Drawing.Point(519, 47)
        Me.ucrReceiverLevelVarieties.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLevelVarieties.Name = "ucrReceiverLevelVarieties"
        Me.ucrReceiverLevelVarieties.Selector = Nothing
        Me.ucrReceiverLevelVarieties.Size = New System.Drawing.Size(180, 88)
        Me.ucrReceiverLevelVarieties.strNcFilePath = ""
        Me.ucrReceiverLevelVarieties.TabIndex = 6
        Me.ucrReceiverLevelVarieties.ucrSelector = Nothing
        '
        'lblVarieties
        '
        Me.lblVarieties.AutoSize = True
        Me.lblVarieties.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVarieties.Location = New System.Drawing.Point(523, 27)
        Me.lblVarieties.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVarieties.Name = "lblVarieties"
        Me.lblVarieties.Size = New System.Drawing.Size(75, 20)
        Me.lblVarieties.TabIndex = 10
        Me.lblVarieties.Text = "Varieties:"
        '
        'lblPlantingDate
        '
        Me.lblPlantingDate.AutoSize = True
        Me.lblPlantingDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPlantingDate.Location = New System.Drawing.Point(351, 199)
        Me.lblPlantingDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlantingDate.Name = "lblPlantingDate"
        Me.lblPlantingDate.Size = New System.Drawing.Size(109, 20)
        Me.lblPlantingDate.TabIndex = 8
        Me.lblPlantingDate.Text = "Planting Date:"
        '
        'lblLon
        '
        Me.lblLon.AutoSize = True
        Me.lblLon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLon.Location = New System.Drawing.Point(351, 142)
        Me.lblLon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLon.Name = "lblLon"
        Me.lblLon.Size = New System.Drawing.Size(84, 20)
        Me.lblLon.TabIndex = 6
        Me.lblLon.Text = "Longitude:"
        '
        'ucrReceiverLevelPlantingDate
        '
        Me.ucrReceiverLevelPlantingDate.AutoSize = True
        Me.ucrReceiverLevelPlantingDate.frmParent = Me
        Me.ucrReceiverLevelPlantingDate.Location = New System.Drawing.Point(354, 219)
        Me.ucrReceiverLevelPlantingDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLevelPlantingDate.Name = "ucrReceiverLevelPlantingDate"
        Me.ucrReceiverLevelPlantingDate.Selector = Nothing
        Me.ucrReceiverLevelPlantingDate.Size = New System.Drawing.Size(147, 30)
        Me.ucrReceiverLevelPlantingDate.strNcFilePath = ""
        Me.ucrReceiverLevelPlantingDate.TabIndex = 5
        Me.ucrReceiverLevelPlantingDate.Tag = "planting_date"
        Me.ucrReceiverLevelPlantingDate.ucrSelector = Nothing
        '
        'ucrReceiverLevelLongitude
        '
        Me.ucrReceiverLevelLongitude.AutoSize = True
        Me.ucrReceiverLevelLongitude.frmParent = Me
        Me.ucrReceiverLevelLongitude.Location = New System.Drawing.Point(354, 162)
        Me.ucrReceiverLevelLongitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLevelLongitude.Name = "ucrReceiverLevelLongitude"
        Me.ucrReceiverLevelLongitude.Selector = Nothing
        Me.ucrReceiverLevelLongitude.Size = New System.Drawing.Size(147, 30)
        Me.ucrReceiverLevelLongitude.strNcFilePath = ""
        Me.ucrReceiverLevelLongitude.TabIndex = 4
        Me.ucrReceiverLevelLongitude.Tag = "longitude"
        Me.ucrReceiverLevelLongitude.ucrSelector = Nothing
        '
        'lblLat
        '
        Me.lblLat.AutoSize = True
        Me.lblLat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLat.Location = New System.Drawing.Point(351, 84)
        Me.lblLat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLat.Name = "lblLat"
        Me.lblLat.Size = New System.Drawing.Size(71, 20)
        Me.lblLat.TabIndex = 4
        Me.lblLat.Text = "Latitude:"
        '
        'ucrReceiverLevelLatitude
        '
        Me.ucrReceiverLevelLatitude.AutoSize = True
        Me.ucrReceiverLevelLatitude.frmParent = Me
        Me.ucrReceiverLevelLatitude.Location = New System.Drawing.Point(354, 105)
        Me.ucrReceiverLevelLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLevelLatitude.Name = "ucrReceiverLevelLatitude"
        Me.ucrReceiverLevelLatitude.Selector = Nothing
        Me.ucrReceiverLevelLatitude.Size = New System.Drawing.Size(147, 30)
        Me.ucrReceiverLevelLatitude.strNcFilePath = ""
        Me.ucrReceiverLevelLatitude.TabIndex = 3
        Me.ucrReceiverLevelLatitude.Tag = "latitude"
        Me.ucrReceiverLevelLatitude.ucrSelector = Nothing
        '
        'ucrSelectorIDLevelData
        '
        Me.ucrSelectorIDLevelData.AutoSize = True
        Me.ucrSelectorIDLevelData.bDropUnusedFilterLevels = False
        Me.ucrSelectorIDLevelData.bShowHiddenColumns = False
        Me.ucrSelectorIDLevelData.bUseCurrentFilter = True
        Me.ucrSelectorIDLevelData.Location = New System.Drawing.Point(11, 23)
        Me.ucrSelectorIDLevelData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorIDLevelData.Name = "ucrSelectorIDLevelData"
        Me.ucrSelectorIDLevelData.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorIDLevelData.TabIndex = 1
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblID.Location = New System.Drawing.Point(351, 27)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(30, 20)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "ID:"
        '
        'ucrReceiverLevelID
        '
        Me.ucrReceiverLevelID.AutoSize = True
        Me.ucrReceiverLevelID.frmParent = Me
        Me.ucrReceiverLevelID.Location = New System.Drawing.Point(354, 47)
        Me.ucrReceiverLevelID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLevelID.Name = "ucrReceiverLevelID"
        Me.ucrReceiverLevelID.Selector = Nothing
        Me.ucrReceiverLevelID.Size = New System.Drawing.Size(147, 30)
        Me.ucrReceiverLevelID.strNcFilePath = ""
        Me.ucrReceiverLevelID.TabIndex = 2
        Me.ucrReceiverLevelID.Tag = "id"
        Me.ucrReceiverLevelID.ucrSelector = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucrSelectorVarietyLevelData)
        Me.GroupBox1.Controls.Add(Me.lblVVariety)
        Me.GroupBox1.Controls.Add(Me.ucrReceiverVarietyLevelVariety)
        Me.GroupBox1.Location = New System.Drawing.Point(731, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(504, 300)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = ""
        Me.GroupBox1.Text = "Variety-Level Data"
        '
        'ucrSelectorVarietyLevelData
        '
        Me.ucrSelectorVarietyLevelData.AutoSize = True
        Me.ucrSelectorVarietyLevelData.bDropUnusedFilterLevels = False
        Me.ucrSelectorVarietyLevelData.bShowHiddenColumns = False
        Me.ucrSelectorVarietyLevelData.bUseCurrentFilter = True
        Me.ucrSelectorVarietyLevelData.Location = New System.Drawing.Point(11, 23)
        Me.ucrSelectorVarietyLevelData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVarietyLevelData.Name = "ucrSelectorVarietyLevelData"
        Me.ucrSelectorVarietyLevelData.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorVarietyLevelData.TabIndex = 8
        '
        'lblVVariety
        '
        Me.lblVVariety.AutoSize = True
        Me.lblVVariety.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVVariety.Location = New System.Drawing.Point(343, 28)
        Me.lblVVariety.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVVariety.Name = "lblVVariety"
        Me.lblVVariety.Size = New System.Drawing.Size(62, 20)
        Me.lblVVariety.TabIndex = 0
        Me.lblVVariety.Text = "Variety:"
        '
        'ucrReceiverVarietyLevelVariety
        '
        Me.ucrReceiverVarietyLevelVariety.AutoSize = True
        Me.ucrReceiverVarietyLevelVariety.frmParent = Me
        Me.ucrReceiverVarietyLevelVariety.Location = New System.Drawing.Point(345, 48)
        Me.ucrReceiverVarietyLevelVariety.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVarietyLevelVariety.Name = "ucrReceiverVarietyLevelVariety"
        Me.ucrReceiverVarietyLevelVariety.Selector = Nothing
        Me.ucrReceiverVarietyLevelVariety.Size = New System.Drawing.Size(147, 30)
        Me.ucrReceiverVarietyLevelVariety.strNcFilePath = ""
        Me.ucrReceiverVarietyLevelVariety.TabIndex = 9
        Me.ucrReceiverVarietyLevelVariety.Tag = "variety"
        Me.ucrReceiverVarietyLevelVariety.ucrSelector = Nothing
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblIVTraits)
        Me.GroupBox2.Controls.Add(Me.ucrReceiverIDVarietyLevelTraits)
        Me.GroupBox2.Controls.Add(Me.ucrReceiverIDVarietyLevelID)
        Me.GroupBox2.Controls.Add(Me.lblIVID)
        Me.GroupBox2.Controls.Add(Me.ucrSelectorIDVarietyLevel)
        Me.GroupBox2.Controls.Add(Me.lblIVVariety)
        Me.GroupBox2.Controls.Add(Me.ucrReceiverIDVarietyLevelVariety)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 304)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(725, 305)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = ""
        Me.GroupBox2.Text = "ID-Variety Level Data"
        '
        'lblIVTraits
        '
        Me.lblIVTraits.AutoSize = True
        Me.lblIVTraits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIVTraits.Location = New System.Drawing.Point(364, 150)
        Me.lblIVTraits.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIVTraits.Name = "lblIVTraits"
        Me.lblIVTraits.Size = New System.Drawing.Size(52, 20)
        Me.lblIVTraits.TabIndex = 18
        Me.lblIVTraits.Text = "Traits:"
        '
        'ucrReceiverIDVarietyLevelTraits
        '
        Me.ucrReceiverIDVarietyLevelTraits.AutoSize = True
        Me.ucrReceiverIDVarietyLevelTraits.frmParent = Me
        Me.ucrReceiverIDVarietyLevelTraits.Location = New System.Drawing.Point(363, 171)
        Me.ucrReceiverIDVarietyLevelTraits.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIDVarietyLevelTraits.Name = "ucrReceiverIDVarietyLevelTraits"
        Me.ucrReceiverIDVarietyLevelTraits.Selector = Nothing
        Me.ucrReceiverIDVarietyLevelTraits.Size = New System.Drawing.Size(180, 86)
        Me.ucrReceiverIDVarietyLevelTraits.strNcFilePath = ""
        Me.ucrReceiverIDVarietyLevelTraits.TabIndex = 13
        Me.ucrReceiverIDVarietyLevelTraits.ucrSelector = Nothing
        '
        'ucrReceiverIDVarietyLevelID
        '
        Me.ucrReceiverIDVarietyLevelID.AutoSize = True
        Me.ucrReceiverIDVarietyLevelID.frmParent = Me
        Me.ucrReceiverIDVarietyLevelID.Location = New System.Drawing.Point(363, 55)
        Me.ucrReceiverIDVarietyLevelID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIDVarietyLevelID.Name = "ucrReceiverIDVarietyLevelID"
        Me.ucrReceiverIDVarietyLevelID.Selector = Nothing
        Me.ucrReceiverIDVarietyLevelID.Size = New System.Drawing.Size(147, 30)
        Me.ucrReceiverIDVarietyLevelID.strNcFilePath = ""
        Me.ucrReceiverIDVarietyLevelID.TabIndex = 11
        Me.ucrReceiverIDVarietyLevelID.Tag = "id"
        Me.ucrReceiverIDVarietyLevelID.ucrSelector = Nothing
        '
        'lblIVID
        '
        Me.lblIVID.AutoSize = True
        Me.lblIVID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIVID.Location = New System.Drawing.Point(364, 35)
        Me.lblIVID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIVID.Name = "lblIVID"
        Me.lblIVID.Size = New System.Drawing.Size(30, 20)
        Me.lblIVID.TabIndex = 3
        Me.lblIVID.Text = "ID:"
        '
        'ucrSelectorIDVarietyLevel
        '
        Me.ucrSelectorIDVarietyLevel.AutoSize = True
        Me.ucrSelectorIDVarietyLevel.bDropUnusedFilterLevels = False
        Me.ucrSelectorIDVarietyLevel.bShowHiddenColumns = False
        Me.ucrSelectorIDVarietyLevel.bUseCurrentFilter = True
        Me.ucrSelectorIDVarietyLevel.Location = New System.Drawing.Point(11, 23)
        Me.ucrSelectorIDVarietyLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorIDVarietyLevel.Name = "ucrSelectorIDVarietyLevel"
        Me.ucrSelectorIDVarietyLevel.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorIDVarietyLevel.TabIndex = 10
        '
        'lblIVVariety
        '
        Me.lblIVVariety.AutoSize = True
        Me.lblIVVariety.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIVVariety.Location = New System.Drawing.Point(364, 92)
        Me.lblIVVariety.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIVVariety.Name = "lblIVVariety"
        Me.lblIVVariety.Size = New System.Drawing.Size(62, 20)
        Me.lblIVVariety.TabIndex = 0
        Me.lblIVVariety.Text = "Variety:"
        '
        'ucrReceiverIDVarietyLevelVariety
        '
        Me.ucrReceiverIDVarietyLevelVariety.AutoSize = True
        Me.ucrReceiverIDVarietyLevelVariety.frmParent = Me
        Me.ucrReceiverIDVarietyLevelVariety.Location = New System.Drawing.Point(363, 113)
        Me.ucrReceiverIDVarietyLevelVariety.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIDVarietyLevelVariety.Name = "ucrReceiverIDVarietyLevelVariety"
        Me.ucrReceiverIDVarietyLevelVariety.Selector = Nothing
        Me.ucrReceiverIDVarietyLevelVariety.Size = New System.Drawing.Size(147, 30)
        Me.ucrReceiverIDVarietyLevelVariety.strNcFilePath = ""
        Me.ucrReceiverIDVarietyLevelVariety.TabIndex = 12
        Me.ucrReceiverIDVarietyLevelVariety.Tag = "variety"
        Me.ucrReceiverIDVarietyLevelVariety.ucrSelector = Nothing
        '
        'dlgDefineTricotData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1247, 715)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpDateTime)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDefineTricotData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Define_Tricot_Data"
        Me.Text = "Define Tricot Data"
        Me.grpDateTime.ResumeLayout(False)
        Me.grpDateTime.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpDateTime As GroupBox
    Friend WithEvents lblID As Label
    Friend WithEvents ucrReceiverLevelID As ucrReceiverSingle
    Friend WithEvents ucrSelectorIDLevelData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblPlantingDate As Label
    Friend WithEvents lblLon As Label
    Friend WithEvents ucrReceiverLevelPlantingDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverLevelLongitude As ucrReceiverSingle
    Friend WithEvents lblLat As Label
    Friend WithEvents ucrReceiverLevelLatitude As ucrReceiverSingle
    Friend WithEvents lblVarieties As Label
    Friend WithEvents lblTraits As Label
    Friend WithEvents ucrReceiverLevelOverallTraits As ucrReceiverMultiple
    Friend WithEvents ucrReceiverLevelVarieties As ucrReceiverMultiple
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ucrSelectorVarietyLevelData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblVVariety As Label
    Friend WithEvents ucrReceiverVarietyLevelVariety As ucrReceiverSingle
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ucrSelectorIDVarietyLevel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblIVVariety As Label
    Friend WithEvents ucrReceiverIDVarietyLevelVariety As ucrReceiverSingle
    Friend WithEvents ucrReceiverIDVarietyLevelID As ucrReceiverSingle
    Friend WithEvents lblIVID As Label
    Friend WithEvents lblIVTraits As Label
    Friend WithEvents ucrReceiverIDVarietyLevelTraits As ucrReceiverMultiple
End Class
