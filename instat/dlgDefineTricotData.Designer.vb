﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.grpIDLevel = New System.Windows.Forms.GroupBox()
        Me.lblPlantingDate = New System.Windows.Forms.Label()
        Me.ucrInputCheckInputIDLevel = New instat.ucrInputTextBox()
        Me.UcrInput1 = New instat.ucrInput()
        Me.btnckeckduplicatesIDLevel = New System.Windows.Forms.Button()
        Me.lblTraits = New System.Windows.Forms.Label()
        Me.ucrReceiverLevelOverallTraits = New instat.ucrReceiverMultiple()
        Me.ucrReceiverLevelVarieties = New instat.ucrReceiverMultiple()
        Me.lblVarieties = New System.Windows.Forms.Label()
        Me.lblLon = New System.Windows.Forms.Label()
        Me.ucrReceiverLevelPlantingDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverLevelLongitude = New instat.ucrReceiverSingle()
        Me.lblLat = New System.Windows.Forms.Label()
        Me.ucrReceiverLevelLatitude = New instat.ucrReceiverSingle()
        Me.lblID = New System.Windows.Forms.Label()
        Me.ucrReceiverLevelID = New instat.ucrReceiverSingle()
        Me.ucrSelectorIDLevelData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpVarietyLevel = New System.Windows.Forms.GroupBox()
        Me.ucrInputCheckInputVarietyLevel = New instat.ucrInputTextBox()
        Me.btncheckduplicatesvarietylevel = New System.Windows.Forms.Button()
        Me.ucrSelectorVarietyLevelData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblVVariety = New System.Windows.Forms.Label()
        Me.ucrReceiverVarietyLevelVariety = New instat.ucrReceiverSingle()
        Me.grpIDVarietyLevel = New System.Windows.Forms.GroupBox()
        Me.ucrInputCheckInputIDVarietyLevel = New instat.ucrInputTextBox()
        Me.btncheckduplicatesIDVarietyLevel = New System.Windows.Forms.Button()
        Me.lblIVTraits = New System.Windows.Forms.Label()
        Me.ucrReceiverIDVarietyLevelTraits = New instat.ucrReceiverMultiple()
        Me.ucrReceiverIDVarietyLevelID = New instat.ucrReceiverSingle()
        Me.lblIVID = New System.Windows.Forms.Label()
        Me.ucrSelectorIDVarietyLevel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblIVVariety = New System.Windows.Forms.Label()
        Me.ucrReceiverIDVarietyLevelVariety = New instat.ucrReceiverSingle()
        Me.ucrChkDefineIDLevel = New instat.ucrCheck()
        Me.ucrChkDefineVarietyLevel = New instat.ucrCheck()
        Me.grpIDLevel.SuspendLayout()
        Me.grpVarietyLevel.SuspendLayout()
        Me.grpIDVarietyLevel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(14, 694)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 14
        '
        'grpIDLevel
        '
        Me.grpIDLevel.Controls.Add(Me.lblPlantingDate)
        Me.grpIDLevel.Controls.Add(Me.ucrInputCheckInputIDLevel)
        Me.grpIDLevel.Controls.Add(Me.UcrInput1)
        Me.grpIDLevel.Controls.Add(Me.btnckeckduplicatesIDLevel)
        Me.grpIDLevel.Controls.Add(Me.lblTraits)
        Me.grpIDLevel.Controls.Add(Me.ucrReceiverLevelOverallTraits)
        Me.grpIDLevel.Controls.Add(Me.ucrReceiverLevelVarieties)
        Me.grpIDLevel.Controls.Add(Me.lblVarieties)
        Me.grpIDLevel.Controls.Add(Me.lblLon)
        Me.grpIDLevel.Controls.Add(Me.ucrReceiverLevelPlantingDate)
        Me.grpIDLevel.Controls.Add(Me.ucrReceiverLevelLongitude)
        Me.grpIDLevel.Controls.Add(Me.lblLat)
        Me.grpIDLevel.Controls.Add(Me.ucrReceiverLevelLatitude)
        Me.grpIDLevel.Controls.Add(Me.lblID)
        Me.grpIDLevel.Controls.Add(Me.ucrReceiverLevelID)
        Me.grpIDLevel.Controls.Add(Me.ucrSelectorIDLevelData)
        Me.grpIDLevel.Location = New System.Drawing.Point(14, 357)
        Me.grpIDLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpIDLevel.Name = "grpIDLevel"
        Me.grpIDLevel.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpIDLevel.Size = New System.Drawing.Size(821, 338)
        Me.grpIDLevel.TabIndex = 0
        Me.grpIDLevel.TabStop = False
        Me.grpIDLevel.Tag = ""
        Me.grpIDLevel.Text = "ID-Level Data"
        '
        'lblPlantingDate
        '
        Me.lblPlantingDate.AutoSize = True
        Me.lblPlantingDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPlantingDate.Location = New System.Drawing.Point(350, 198)
        Me.lblPlantingDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlantingDate.Name = "lblPlantingDate"
        Me.lblPlantingDate.Size = New System.Drawing.Size(109, 20)
        Me.lblPlantingDate.TabIndex = 8
        Me.lblPlantingDate.Text = "Planting Date:"
        '
        'ucrInputCheckInputIDLevel
        '
        Me.ucrInputCheckInputIDLevel.AddQuotesIfUnrecognised = True
        Me.ucrInputCheckInputIDLevel.AutoSize = True
        Me.ucrInputCheckInputIDLevel.IsMultiline = False
        Me.ucrInputCheckInputIDLevel.IsReadOnly = False
        Me.ucrInputCheckInputIDLevel.Location = New System.Drawing.Point(186, 302)
        Me.ucrInputCheckInputIDLevel.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputCheckInputIDLevel.Name = "ucrInputCheckInputIDLevel"
        Me.ucrInputCheckInputIDLevel.Size = New System.Drawing.Size(564, 32)
        Me.ucrInputCheckInputIDLevel.TabIndex = 15
        '
        'UcrInput1
        '
        Me.UcrInput1.AddQuotesIfUnrecognised = True
        Me.UcrInput1.AutoSize = True
        Me.UcrInput1.IsReadOnly = False
        Me.UcrInput1.Location = New System.Drawing.Point(204, 316)
        Me.UcrInput1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.UcrInput1.Name = "UcrInput1"
        Me.UcrInput1.Size = New System.Drawing.Size(228, 26)
        Me.UcrInput1.TabIndex = 14
        '
        'btnckeckduplicatesIDLevel
        '
        Me.btnckeckduplicatesIDLevel.Location = New System.Drawing.Point(10, 298)
        Me.btnckeckduplicatesIDLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnckeckduplicatesIDLevel.Name = "btnckeckduplicatesIDLevel"
        Me.btnckeckduplicatesIDLevel.Size = New System.Drawing.Size(172, 34)
        Me.btnckeckduplicatesIDLevel.TabIndex = 13
        Me.btnckeckduplicatesIDLevel.Text = "Check Duplicates"
        Me.btnckeckduplicatesIDLevel.UseVisualStyleBackColor = True
        '
        'lblTraits
        '
        Me.lblTraits.AutoSize = True
        Me.lblTraits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTraits.Location = New System.Drawing.Point(576, 160)
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
        Me.ucrReceiverLevelOverallTraits.Location = New System.Drawing.Point(572, 184)
        Me.ucrReceiverLevelOverallTraits.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLevelOverallTraits.Name = "ucrReceiverLevelOverallTraits"
        Me.ucrReceiverLevelOverallTraits.Selector = Nothing
        Me.ucrReceiverLevelOverallTraits.Size = New System.Drawing.Size(232, 105)
        Me.ucrReceiverLevelOverallTraits.strNcFilePath = ""
        Me.ucrReceiverLevelOverallTraits.TabIndex = 7
        Me.ucrReceiverLevelOverallTraits.ucrSelector = Nothing
        '
        'ucrReceiverLevelVarieties
        '
        Me.ucrReceiverLevelVarieties.AutoSize = True
        Me.ucrReceiverLevelVarieties.frmParent = Me
        Me.ucrReceiverLevelVarieties.Location = New System.Drawing.Point(572, 46)
        Me.ucrReceiverLevelVarieties.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLevelVarieties.Name = "ucrReceiverLevelVarieties"
        Me.ucrReceiverLevelVarieties.Selector = Nothing
        Me.ucrReceiverLevelVarieties.Size = New System.Drawing.Size(232, 105)
        Me.ucrReceiverLevelVarieties.strNcFilePath = ""
        Me.ucrReceiverLevelVarieties.TabIndex = 6
        Me.ucrReceiverLevelVarieties.ucrSelector = Nothing
        '
        'lblVarieties
        '
        Me.lblVarieties.AutoSize = True
        Me.lblVarieties.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVarieties.Location = New System.Drawing.Point(576, 22)
        Me.lblVarieties.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVarieties.Name = "lblVarieties"
        Me.lblVarieties.Size = New System.Drawing.Size(75, 20)
        Me.lblVarieties.TabIndex = 10
        Me.lblVarieties.Text = "Varieties:"
        '
        'lblLon
        '
        Me.lblLon.AutoSize = True
        Me.lblLon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLon.Location = New System.Drawing.Point(350, 142)
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
        Me.ucrReceiverLevelPlantingDate.Location = New System.Drawing.Point(354, 218)
        Me.ucrReceiverLevelPlantingDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLevelPlantingDate.Name = "ucrReceiverLevelPlantingDate"
        Me.ucrReceiverLevelPlantingDate.Selector = Nothing
        Me.ucrReceiverLevelPlantingDate.Size = New System.Drawing.Size(198, 30)
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
        Me.ucrReceiverLevelLongitude.Size = New System.Drawing.Size(198, 30)
        Me.ucrReceiverLevelLongitude.strNcFilePath = ""
        Me.ucrReceiverLevelLongitude.TabIndex = 4
        Me.ucrReceiverLevelLongitude.Tag = "longitude"
        Me.ucrReceiverLevelLongitude.ucrSelector = Nothing
        '
        'lblLat
        '
        Me.lblLat.AutoSize = True
        Me.lblLat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLat.Location = New System.Drawing.Point(350, 84)
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
        Me.ucrReceiverLevelLatitude.Location = New System.Drawing.Point(354, 106)
        Me.ucrReceiverLevelLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLevelLatitude.Name = "ucrReceiverLevelLatitude"
        Me.ucrReceiverLevelLatitude.Selector = Nothing
        Me.ucrReceiverLevelLatitude.Size = New System.Drawing.Size(198, 30)
        Me.ucrReceiverLevelLatitude.strNcFilePath = ""
        Me.ucrReceiverLevelLatitude.TabIndex = 3
        Me.ucrReceiverLevelLatitude.Tag = "latitude"
        Me.ucrReceiverLevelLatitude.ucrSelector = Nothing
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblID.Location = New System.Drawing.Point(350, 26)
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
        Me.ucrReceiverLevelID.Location = New System.Drawing.Point(354, 46)
        Me.ucrReceiverLevelID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLevelID.Name = "ucrReceiverLevelID"
        Me.ucrReceiverLevelID.Selector = Nothing
        Me.ucrReceiverLevelID.Size = New System.Drawing.Size(198, 30)
        Me.ucrReceiverLevelID.strNcFilePath = ""
        Me.ucrReceiverLevelID.TabIndex = 2
        Me.ucrReceiverLevelID.Tag = "id"
        Me.ucrReceiverLevelID.ucrSelector = Nothing
        '
        'ucrSelectorIDLevelData
        '
        Me.ucrSelectorIDLevelData.AutoSize = True
        Me.ucrSelectorIDLevelData.bDropUnusedFilterLevels = False
        Me.ucrSelectorIDLevelData.bShowHiddenColumns = False
        Me.ucrSelectorIDLevelData.bUseCurrentFilter = True
        Me.ucrSelectorIDLevelData.Location = New System.Drawing.Point(10, 22)
        Me.ucrSelectorIDLevelData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorIDLevelData.Name = "ucrSelectorIDLevelData"
        Me.ucrSelectorIDLevelData.Size = New System.Drawing.Size(318, 274)
        Me.ucrSelectorIDLevelData.TabIndex = 1
        '
        'grpVarietyLevel
        '
        Me.grpVarietyLevel.Controls.Add(Me.ucrInputCheckInputVarietyLevel)
        Me.grpVarietyLevel.Controls.Add(Me.btncheckduplicatesvarietylevel)
        Me.grpVarietyLevel.Controls.Add(Me.ucrSelectorVarietyLevelData)
        Me.grpVarietyLevel.Controls.Add(Me.lblVVariety)
        Me.grpVarietyLevel.Controls.Add(Me.ucrReceiverVarietyLevelVariety)
        Me.grpVarietyLevel.Location = New System.Drawing.Point(843, 357)
        Me.grpVarietyLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpVarietyLevel.Name = "grpVarietyLevel"
        Me.grpVarietyLevel.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpVarietyLevel.Size = New System.Drawing.Size(541, 338)
        Me.grpVarietyLevel.TabIndex = 1
        Me.grpVarietyLevel.TabStop = False
        Me.grpVarietyLevel.Tag = ""
        Me.grpVarietyLevel.Text = "Variety-Level Data"
        '
        'ucrInputCheckInputVarietyLevel
        '
        Me.ucrInputCheckInputVarietyLevel.AddQuotesIfUnrecognised = True
        Me.ucrInputCheckInputVarietyLevel.AutoSize = True
        Me.ucrInputCheckInputVarietyLevel.IsMultiline = False
        Me.ucrInputCheckInputVarietyLevel.IsReadOnly = False
        Me.ucrInputCheckInputVarietyLevel.Location = New System.Drawing.Point(188, 302)
        Me.ucrInputCheckInputVarietyLevel.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputCheckInputVarietyLevel.Name = "ucrInputCheckInputVarietyLevel"
        Me.ucrInputCheckInputVarietyLevel.Size = New System.Drawing.Size(341, 32)
        Me.ucrInputCheckInputVarietyLevel.TabIndex = 15
        '
        'btncheckduplicatesvarietylevel
        '
        Me.btncheckduplicatesvarietylevel.Location = New System.Drawing.Point(10, 298)
        Me.btncheckduplicatesvarietylevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btncheckduplicatesvarietylevel.Name = "btncheckduplicatesvarietylevel"
        Me.btncheckduplicatesvarietylevel.Size = New System.Drawing.Size(172, 34)
        Me.btncheckduplicatesvarietylevel.TabIndex = 14
        Me.btncheckduplicatesvarietylevel.Text = "Check Duplicates"
        Me.btncheckduplicatesvarietylevel.UseVisualStyleBackColor = True
        '
        'ucrSelectorVarietyLevelData
        '
        Me.ucrSelectorVarietyLevelData.AutoSize = True
        Me.ucrSelectorVarietyLevelData.bDropUnusedFilterLevels = False
        Me.ucrSelectorVarietyLevelData.bShowHiddenColumns = False
        Me.ucrSelectorVarietyLevelData.bUseCurrentFilter = True
        Me.ucrSelectorVarietyLevelData.Location = New System.Drawing.Point(10, 22)
        Me.ucrSelectorVarietyLevelData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVarietyLevelData.Name = "ucrSelectorVarietyLevelData"
        Me.ucrSelectorVarietyLevelData.Size = New System.Drawing.Size(330, 274)
        Me.ucrSelectorVarietyLevelData.TabIndex = 8
        '
        'lblVVariety
        '
        Me.lblVVariety.AutoSize = True
        Me.lblVVariety.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVVariety.Location = New System.Drawing.Point(351, 74)
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
        Me.ucrReceiverVarietyLevelVariety.Location = New System.Drawing.Point(347, 98)
        Me.ucrReceiverVarietyLevelVariety.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVarietyLevelVariety.Name = "ucrReceiverVarietyLevelVariety"
        Me.ucrReceiverVarietyLevelVariety.Selector = Nothing
        Me.ucrReceiverVarietyLevelVariety.Size = New System.Drawing.Size(182, 30)
        Me.ucrReceiverVarietyLevelVariety.strNcFilePath = ""
        Me.ucrReceiverVarietyLevelVariety.TabIndex = 9
        Me.ucrReceiverVarietyLevelVariety.Tag = "variety"
        Me.ucrReceiverVarietyLevelVariety.ucrSelector = Nothing
        '
        'grpIDVarietyLevel
        '
        Me.grpIDVarietyLevel.Controls.Add(Me.ucrInputCheckInputIDVarietyLevel)
        Me.grpIDVarietyLevel.Controls.Add(Me.btncheckduplicatesIDVarietyLevel)
        Me.grpIDVarietyLevel.Controls.Add(Me.lblIVTraits)
        Me.grpIDVarietyLevel.Controls.Add(Me.ucrReceiverIDVarietyLevelTraits)
        Me.grpIDVarietyLevel.Controls.Add(Me.ucrReceiverIDVarietyLevelID)
        Me.grpIDVarietyLevel.Controls.Add(Me.lblIVID)
        Me.grpIDVarietyLevel.Controls.Add(Me.ucrSelectorIDVarietyLevel)
        Me.grpIDVarietyLevel.Controls.Add(Me.lblIVVariety)
        Me.grpIDVarietyLevel.Controls.Add(Me.ucrReceiverIDVarietyLevelVariety)
        Me.grpIDVarietyLevel.Location = New System.Drawing.Point(14, 14)
        Me.grpIDVarietyLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpIDVarietyLevel.Name = "grpIDVarietyLevel"
        Me.grpIDVarietyLevel.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpIDVarietyLevel.Size = New System.Drawing.Size(821, 338)
        Me.grpIDVarietyLevel.TabIndex = 15
        Me.grpIDVarietyLevel.TabStop = False
        Me.grpIDVarietyLevel.Tag = ""
        Me.grpIDVarietyLevel.Text = "ID-Variety Level Data"
        '
        'ucrInputCheckInputIDVarietyLevel
        '
        Me.ucrInputCheckInputIDVarietyLevel.AddQuotesIfUnrecognised = True
        Me.ucrInputCheckInputIDVarietyLevel.AutoSize = True
        Me.ucrInputCheckInputIDVarietyLevel.IsMultiline = False
        Me.ucrInputCheckInputIDVarietyLevel.IsReadOnly = False
        Me.ucrInputCheckInputIDVarietyLevel.Location = New System.Drawing.Point(186, 302)
        Me.ucrInputCheckInputIDVarietyLevel.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputCheckInputIDVarietyLevel.Name = "ucrInputCheckInputIDVarietyLevel"
        Me.ucrInputCheckInputIDVarietyLevel.Size = New System.Drawing.Size(564, 32)
        Me.ucrInputCheckInputIDVarietyLevel.TabIndex = 20
        '
        'btncheckduplicatesIDVarietyLevel
        '
        Me.btncheckduplicatesIDVarietyLevel.Location = New System.Drawing.Point(10, 298)
        Me.btncheckduplicatesIDVarietyLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btncheckduplicatesIDVarietyLevel.Name = "btncheckduplicatesIDVarietyLevel"
        Me.btncheckduplicatesIDVarietyLevel.Size = New System.Drawing.Size(172, 34)
        Me.btncheckduplicatesIDVarietyLevel.TabIndex = 19
        Me.btncheckduplicatesIDVarietyLevel.Text = "Check Duplicates"
        Me.btncheckduplicatesIDVarietyLevel.UseVisualStyleBackColor = True
        '
        'lblIVTraits
        '
        Me.lblIVTraits.AutoSize = True
        Me.lblIVTraits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIVTraits.Location = New System.Drawing.Point(354, 162)
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
        Me.ucrReceiverIDVarietyLevelTraits.Location = New System.Drawing.Point(354, 184)
        Me.ucrReceiverIDVarietyLevelTraits.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIDVarietyLevelTraits.Name = "ucrReceiverIDVarietyLevelTraits"
        Me.ucrReceiverIDVarietyLevelTraits.Selector = Nothing
        Me.ucrReceiverIDVarietyLevelTraits.Size = New System.Drawing.Size(225, 105)
        Me.ucrReceiverIDVarietyLevelTraits.strNcFilePath = ""
        Me.ucrReceiverIDVarietyLevelTraits.TabIndex = 13
        Me.ucrReceiverIDVarietyLevelTraits.ucrSelector = Nothing
        '
        'ucrReceiverIDVarietyLevelID
        '
        Me.ucrReceiverIDVarietyLevelID.AutoSize = True
        Me.ucrReceiverIDVarietyLevelID.frmParent = Me
        Me.ucrReceiverIDVarietyLevelID.Location = New System.Drawing.Point(354, 69)
        Me.ucrReceiverIDVarietyLevelID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIDVarietyLevelID.Name = "ucrReceiverIDVarietyLevelID"
        Me.ucrReceiverIDVarietyLevelID.Selector = Nothing
        Me.ucrReceiverIDVarietyLevelID.Size = New System.Drawing.Size(225, 30)
        Me.ucrReceiverIDVarietyLevelID.strNcFilePath = ""
        Me.ucrReceiverIDVarietyLevelID.TabIndex = 11
        Me.ucrReceiverIDVarietyLevelID.Tag = "id"
        Me.ucrReceiverIDVarietyLevelID.ucrSelector = Nothing
        '
        'lblIVID
        '
        Me.lblIVID.AutoSize = True
        Me.lblIVID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIVID.Location = New System.Drawing.Point(354, 46)
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
        Me.ucrSelectorIDVarietyLevel.Location = New System.Drawing.Point(10, 22)
        Me.ucrSelectorIDVarietyLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorIDVarietyLevel.Name = "ucrSelectorIDVarietyLevel"
        Me.ucrSelectorIDVarietyLevel.Size = New System.Drawing.Size(338, 274)
        Me.ucrSelectorIDVarietyLevel.TabIndex = 10
        '
        'lblIVVariety
        '
        Me.lblIVVariety.AutoSize = True
        Me.lblIVVariety.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIVVariety.Location = New System.Drawing.Point(354, 104)
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
        Me.ucrReceiverIDVarietyLevelVariety.Location = New System.Drawing.Point(354, 126)
        Me.ucrReceiverIDVarietyLevelVariety.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIDVarietyLevelVariety.Name = "ucrReceiverIDVarietyLevelVariety"
        Me.ucrReceiverIDVarietyLevelVariety.Selector = Nothing
        Me.ucrReceiverIDVarietyLevelVariety.Size = New System.Drawing.Size(225, 30)
        Me.ucrReceiverIDVarietyLevelVariety.strNcFilePath = ""
        Me.ucrReceiverIDVarietyLevelVariety.TabIndex = 12
        Me.ucrReceiverIDVarietyLevelVariety.Tag = "variety"
        Me.ucrReceiverIDVarietyLevelVariety.ucrSelector = Nothing
        '
        'ucrChkDefineIDLevel
        '
        Me.ucrChkDefineIDLevel.AutoSize = True
        Me.ucrChkDefineIDLevel.Checked = False
        Me.ucrChkDefineIDLevel.Location = New System.Drawing.Point(845, 276)
        Me.ucrChkDefineIDLevel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkDefineIDLevel.Name = "ucrChkDefineIDLevel"
        Me.ucrChkDefineIDLevel.Size = New System.Drawing.Size(302, 34)
        Me.ucrChkDefineIDLevel.TabIndex = 16
        '
        'ucrChkDefineVarietyLevel
        '
        Me.ucrChkDefineVarietyLevel.AutoSize = True
        Me.ucrChkDefineVarietyLevel.Checked = False
        Me.ucrChkDefineVarietyLevel.Location = New System.Drawing.Point(845, 318)
        Me.ucrChkDefineVarietyLevel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkDefineVarietyLevel.Name = "ucrChkDefineVarietyLevel"
        Me.ucrChkDefineVarietyLevel.Size = New System.Drawing.Size(302, 34)
        Me.ucrChkDefineVarietyLevel.TabIndex = 17
        '
        'dlgDefineTricotData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1401, 782)
        Me.Controls.Add(Me.ucrChkDefineVarietyLevel)
        Me.Controls.Add(Me.ucrChkDefineIDLevel)
        Me.Controls.Add(Me.grpIDVarietyLevel)
        Me.Controls.Add(Me.grpVarietyLevel)
        Me.Controls.Add(Me.grpIDLevel)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDefineTricotData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Define_Tricot_Data"
        Me.Text = "Define Tricot Data"
        Me.grpIDLevel.ResumeLayout(False)
        Me.grpIDLevel.PerformLayout()
        Me.grpVarietyLevel.ResumeLayout(False)
        Me.grpVarietyLevel.PerformLayout()
        Me.grpIDVarietyLevel.ResumeLayout(False)
        Me.grpIDVarietyLevel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpIDLevel As GroupBox
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
    Friend WithEvents grpVarietyLevel As GroupBox
    Friend WithEvents ucrSelectorVarietyLevelData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblVVariety As Label
    Friend WithEvents ucrReceiverVarietyLevelVariety As ucrReceiverSingle
    Friend WithEvents grpIDVarietyLevel As GroupBox
    Friend WithEvents ucrSelectorIDVarietyLevel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblIVVariety As Label
    Friend WithEvents ucrReceiverIDVarietyLevelVariety As ucrReceiverSingle
    Friend WithEvents ucrReceiverIDVarietyLevelID As ucrReceiverSingle
    Friend WithEvents lblIVID As Label
    Friend WithEvents lblIVTraits As Label
    Friend WithEvents ucrReceiverIDVarietyLevelTraits As ucrReceiverMultiple
    Friend WithEvents btnckeckduplicatesIDLevel As Button
    Friend WithEvents btncheckduplicatesIDVarietyLevel As Button
    Friend WithEvents btncheckduplicatesvarietylevel As Button
    Friend WithEvents UcrInput1 As ucrInput
    Friend WithEvents ucrInputCheckInputIDVarietyLevel As ucrInputTextBox
    Friend WithEvents ucrInputCheckInputIDLevel As ucrInputTextBox
    Friend WithEvents ucrInputCheckInputVarietyLevel As ucrInputTextBox
    Friend WithEvents ucrChkDefineVarietyLevel As ucrCheck
    Friend WithEvents ucrChkDefineIDLevel As ucrCheck
End Class
