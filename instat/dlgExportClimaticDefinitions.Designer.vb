<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgExportClimaticDefinitions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.btnConnection = New System.Windows.Forms.Button()
        Me.ucrSelectorExportToEPicsa = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblAnnualRainfallSummaries = New System.Windows.Forms.Label()
        Me.ucrReceiverAnnualRainfallSummaries = New instat.ucrReceiverSingle()
        Me.lblMonthlyTempSummaries = New System.Windows.Forms.Label()
        Me.ucrReceiverMonthlyTempSummaries = New instat.ucrReceiverSingle()
        Me.lblAnnualTempSummaries = New System.Windows.Forms.Label()
        Me.ucrReceiverAnnualTempSummaries = New instat.ucrReceiverSingle()
        Me.lblMonthlyRainfallSummaries = New System.Windows.Forms.Label()
        Me.ucrReceiverMonthlyRainfallSummaries = New instat.ucrReceiverSingle()
        Me.grpDefinitionsProducts = New System.Windows.Forms.GroupBox()
        Me.lblPropDefinition = New System.Windows.Forms.Label()
        Me.lblCropDefinition = New System.Windows.Forms.Label()
        Me.ucrReceiverPropDefinition = New instat.ucrReceiverSingle()
        Me.lblAnnualMonthlyTemp = New System.Windows.Forms.Label()
        Me.ucrReceiverCropDefinition = New instat.ucrReceiverSingle()
        Me.ucrReceiverMultipleAnnualMonthlyTemp = New instat.ucrReceiverMultiple()
        Me.lblMonthlyRainfall = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleMonthlyRainfall = New instat.ucrReceiverMultiple()
        Me.lblMonthlyTemp = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleMonthlyTemp = New instat.ucrReceiverMultiple()
        Me.lblAnnualTemp = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleAnnualTemp = New instat.ucrReceiverMultiple()
        Me.lblAnnualRainfall = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleAnnualRainfall = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblAnnualMonthlyTempSummaries = New System.Windows.Forms.Label()
        Me.ucrReceiverAnnualMonthlyTempSummaries = New instat.ucrReceiverSingle()
        Me.lblDataframes = New System.Windows.Forms.Label()
        Me.ucrSelectorDataFramesExportToEPicsa = New instat.ucrSelectorAddRemove()
        Me.lblPropSummaries = New System.Windows.Forms.Label()
        Me.ucrReceiverPropSummaries = New instat.ucrReceiverSingle()
        Me.lblCropSummaries = New System.Windows.Forms.Label()
        Me.ucrReceiverCropSummaries = New instat.ucrReceiverSingle()
        Me.rdoStationMetadata = New System.Windows.Forms.RadioButton()
        Me.rdoSummaryData = New System.Windows.Forms.RadioButton()
        Me.ucrPnlExportToEPicsa = New instat.UcrPanel()
        Me.ucrSelectorStationMetadata = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblDistrict = New System.Windows.Forms.Label()
        Me.ucrReceiverDistrict = New instat.ucrReceiverSingle()
        Me.lblCountryCode = New System.Windows.Forms.Label()
        Me.ucrReceiverCountryCode = New instat.ucrReceiverSingle()
        Me.lblElevation = New System.Windows.Forms.Label()
        Me.ucrReceiverElevation = New instat.ucrReceiverSingle()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.ucrReceiverLongitude = New instat.ucrReceiverSingle()
        Me.lblStationName = New System.Windows.Forms.Label()
        Me.ucrReceiverStationName = New instat.ucrReceiverSingle()
        Me.lblLatitiude = New System.Windows.Forms.Label()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.lblStationID = New System.Windows.Forms.Label()
        Me.ucrReceiverStationID = New instat.ucrReceiverSingle()
        Me.grpDefinitionsProducts.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnection.Location = New System.Drawing.Point(265, 79)
        Me.lblConnection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(114, 20)
        Me.lblConnection.TabIndex = 18
        Me.lblConnection.Text = "No Connection"
        '
        'btnConnection
        '
        Me.btnConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConnection.Location = New System.Drawing.Point(29, 71)
        Me.btnConnection.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConnection.Name = "btnConnection"
        Me.btnConnection.Size = New System.Drawing.Size(220, 34)
        Me.btnConnection.TabIndex = 17
        Me.btnConnection.Text = "Connect to Database"
        Me.btnConnection.UseVisualStyleBackColor = True
        '
        'ucrSelectorExportToEPicsa
        '
        Me.ucrSelectorExportToEPicsa.AutoSize = True
        Me.ucrSelectorExportToEPicsa.bDropUnusedFilterLevels = False
        Me.ucrSelectorExportToEPicsa.bShowHiddenColumns = False
        Me.ucrSelectorExportToEPicsa.bUseCurrentFilter = True
        Me.ucrSelectorExportToEPicsa.Location = New System.Drawing.Point(29, 113)
        Me.ucrSelectorExportToEPicsa.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorExportToEPicsa.Name = "ucrSelectorExportToEPicsa"
        Me.ucrSelectorExportToEPicsa.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorExportToEPicsa.TabIndex = 19
        '
        'lblAnnualRainfallSummaries
        '
        Me.lblAnnualRainfallSummaries.AutoSize = True
        Me.lblAnnualRainfallSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAnnualRainfallSummaries.Location = New System.Drawing.Point(403, 119)
        Me.lblAnnualRainfallSummaries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnnualRainfallSummaries.Name = "lblAnnualRainfallSummaries"
        Me.lblAnnualRainfallSummaries.Size = New System.Drawing.Size(204, 20)
        Me.lblAnnualRainfallSummaries.TabIndex = 20
        Me.lblAnnualRainfallSummaries.Tag = "By_Factor:"
        Me.lblAnnualRainfallSummaries.Text = "Annual Rainfall Summaries:"
        '
        'ucrReceiverAnnualRainfallSummaries
        '
        Me.ucrReceiverAnnualRainfallSummaries.AutoSize = True
        Me.ucrReceiverAnnualRainfallSummaries.frmParent = Me
        Me.ucrReceiverAnnualRainfallSummaries.Location = New System.Drawing.Point(407, 141)
        Me.ucrReceiverAnnualRainfallSummaries.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAnnualRainfallSummaries.Name = "ucrReceiverAnnualRainfallSummaries"
        Me.ucrReceiverAnnualRainfallSummaries.Selector = Nothing
        Me.ucrReceiverAnnualRainfallSummaries.Size = New System.Drawing.Size(294, 30)
        Me.ucrReceiverAnnualRainfallSummaries.strNcFilePath = ""
        Me.ucrReceiverAnnualRainfallSummaries.TabIndex = 21
        Me.ucrReceiverAnnualRainfallSummaries.ucrSelector = Nothing
        '
        'lblMonthlyTempSummaries
        '
        Me.lblMonthlyTempSummaries.AutoSize = True
        Me.lblMonthlyTempSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonthlyTempSummaries.Location = New System.Drawing.Point(403, 290)
        Me.lblMonthlyTempSummaries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonthlyTempSummaries.Name = "lblMonthlyTempSummaries"
        Me.lblMonthlyTempSummaries.Size = New System.Drawing.Size(247, 20)
        Me.lblMonthlyTempSummaries.TabIndex = 24
        Me.lblMonthlyTempSummaries.Tag = "By_Factor:"
        Me.lblMonthlyTempSummaries.Text = "Monthly Temperature Summaries:"
        '
        'ucrReceiverMonthlyTempSummaries
        '
        Me.ucrReceiverMonthlyTempSummaries.AutoSize = True
        Me.ucrReceiverMonthlyTempSummaries.frmParent = Me
        Me.ucrReceiverMonthlyTempSummaries.Location = New System.Drawing.Point(407, 312)
        Me.ucrReceiverMonthlyTempSummaries.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonthlyTempSummaries.Name = "ucrReceiverMonthlyTempSummaries"
        Me.ucrReceiverMonthlyTempSummaries.Selector = Nothing
        Me.ucrReceiverMonthlyTempSummaries.Size = New System.Drawing.Size(294, 30)
        Me.ucrReceiverMonthlyTempSummaries.strNcFilePath = ""
        Me.ucrReceiverMonthlyTempSummaries.TabIndex = 24
        Me.ucrReceiverMonthlyTempSummaries.ucrSelector = Nothing
        '
        'lblAnnualTempSummaries
        '
        Me.lblAnnualTempSummaries.AutoSize = True
        Me.lblAnnualTempSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAnnualTempSummaries.Location = New System.Drawing.Point(403, 176)
        Me.lblAnnualTempSummaries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnnualTempSummaries.Name = "lblAnnualTempSummaries"
        Me.lblAnnualTempSummaries.Size = New System.Drawing.Size(242, 20)
        Me.lblAnnualTempSummaries.TabIndex = 26
        Me.lblAnnualTempSummaries.Tag = "By_Factor:"
        Me.lblAnnualTempSummaries.Text = "Annual Temperature Summaries:"
        '
        'ucrReceiverAnnualTempSummaries
        '
        Me.ucrReceiverAnnualTempSummaries.AutoSize = True
        Me.ucrReceiverAnnualTempSummaries.frmParent = Me
        Me.ucrReceiverAnnualTempSummaries.Location = New System.Drawing.Point(407, 198)
        Me.ucrReceiverAnnualTempSummaries.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAnnualTempSummaries.Name = "ucrReceiverAnnualTempSummaries"
        Me.ucrReceiverAnnualTempSummaries.Selector = Nothing
        Me.ucrReceiverAnnualTempSummaries.Size = New System.Drawing.Size(294, 30)
        Me.ucrReceiverAnnualTempSummaries.strNcFilePath = ""
        Me.ucrReceiverAnnualTempSummaries.TabIndex = 22
        Me.ucrReceiverAnnualTempSummaries.ucrSelector = Nothing
        '
        'lblMonthlyRainfallSummaries
        '
        Me.lblMonthlyRainfallSummaries.AutoSize = True
        Me.lblMonthlyRainfallSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonthlyRainfallSummaries.Location = New System.Drawing.Point(403, 233)
        Me.lblMonthlyRainfallSummaries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonthlyRainfallSummaries.Name = "lblMonthlyRainfallSummaries"
        Me.lblMonthlyRainfallSummaries.Size = New System.Drawing.Size(209, 20)
        Me.lblMonthlyRainfallSummaries.TabIndex = 28
        Me.lblMonthlyRainfallSummaries.Tag = "By_Factor:"
        Me.lblMonthlyRainfallSummaries.Text = "Monthly Rainfall Summaries:"
        '
        'ucrReceiverMonthlyRainfallSummaries
        '
        Me.ucrReceiverMonthlyRainfallSummaries.AutoSize = True
        Me.ucrReceiverMonthlyRainfallSummaries.frmParent = Me
        Me.ucrReceiverMonthlyRainfallSummaries.Location = New System.Drawing.Point(407, 255)
        Me.ucrReceiverMonthlyRainfallSummaries.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonthlyRainfallSummaries.Name = "ucrReceiverMonthlyRainfallSummaries"
        Me.ucrReceiverMonthlyRainfallSummaries.Selector = Nothing
        Me.ucrReceiverMonthlyRainfallSummaries.Size = New System.Drawing.Size(294, 30)
        Me.ucrReceiverMonthlyRainfallSummaries.strNcFilePath = ""
        Me.ucrReceiverMonthlyRainfallSummaries.TabIndex = 23
        Me.ucrReceiverMonthlyRainfallSummaries.ucrSelector = Nothing
        '
        'grpDefinitionsProducts
        '
        Me.grpDefinitionsProducts.Controls.Add(Me.lblPropDefinition)
        Me.grpDefinitionsProducts.Controls.Add(Me.lblCropDefinition)
        Me.grpDefinitionsProducts.Controls.Add(Me.ucrReceiverPropDefinition)
        Me.grpDefinitionsProducts.Controls.Add(Me.lblAnnualMonthlyTemp)
        Me.grpDefinitionsProducts.Controls.Add(Me.ucrReceiverCropDefinition)
        Me.grpDefinitionsProducts.Controls.Add(Me.ucrReceiverMultipleAnnualMonthlyTemp)
        Me.grpDefinitionsProducts.Controls.Add(Me.lblMonthlyRainfall)
        Me.grpDefinitionsProducts.Controls.Add(Me.ucrReceiverMultipleMonthlyRainfall)
        Me.grpDefinitionsProducts.Controls.Add(Me.lblMonthlyTemp)
        Me.grpDefinitionsProducts.Controls.Add(Me.ucrReceiverMultipleMonthlyTemp)
        Me.grpDefinitionsProducts.Controls.Add(Me.lblAnnualTemp)
        Me.grpDefinitionsProducts.Controls.Add(Me.ucrReceiverMultipleAnnualTemp)
        Me.grpDefinitionsProducts.Controls.Add(Me.lblAnnualRainfall)
        Me.grpDefinitionsProducts.Controls.Add(Me.ucrReceiverMultipleAnnualRainfall)
        Me.grpDefinitionsProducts.Location = New System.Drawing.Point(19, 521)
        Me.grpDefinitionsProducts.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDefinitionsProducts.Name = "grpDefinitionsProducts"
        Me.grpDefinitionsProducts.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDefinitionsProducts.Size = New System.Drawing.Size(769, 349)
        Me.grpDefinitionsProducts.TabIndex = 32
        Me.grpDefinitionsProducts.TabStop = False
        Me.grpDefinitionsProducts.Tag = ""
        Me.grpDefinitionsProducts.Text = "Definitions Products"
        '
        'lblPropDefinition
        '
        Me.lblPropDefinition.AutoSize = True
        Me.lblPropDefinition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPropDefinition.Location = New System.Drawing.Point(537, 284)
        Me.lblPropDefinition.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPropDefinition.Name = "lblPropDefinition"
        Me.lblPropDefinition.Size = New System.Drawing.Size(113, 20)
        Me.lblPropDefinition.TabIndex = 61
        Me.lblPropDefinition.Tag = "By_Factor:"
        Me.lblPropDefinition.Text = "Prop Definition"
        '
        'lblCropDefinition
        '
        Me.lblCropDefinition.AutoSize = True
        Me.lblCropDefinition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCropDefinition.Location = New System.Drawing.Point(537, 191)
        Me.lblCropDefinition.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCropDefinition.Name = "lblCropDefinition"
        Me.lblCropDefinition.Size = New System.Drawing.Size(114, 20)
        Me.lblCropDefinition.TabIndex = 63
        Me.lblCropDefinition.Tag = "By_Factor:"
        Me.lblCropDefinition.Text = "Crop Definition"
        '
        'ucrReceiverPropDefinition
        '
        Me.ucrReceiverPropDefinition.AutoSize = True
        Me.ucrReceiverPropDefinition.frmParent = Me
        Me.ucrReceiverPropDefinition.Location = New System.Drawing.Point(541, 307)
        Me.ucrReceiverPropDefinition.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPropDefinition.Name = "ucrReceiverPropDefinition"
        Me.ucrReceiverPropDefinition.Selector = Nothing
        Me.ucrReceiverPropDefinition.Size = New System.Drawing.Size(213, 30)
        Me.ucrReceiverPropDefinition.strNcFilePath = ""
        Me.ucrReceiverPropDefinition.TabIndex = 34
        Me.ucrReceiverPropDefinition.ucrSelector = Nothing
        '
        'lblAnnualMonthlyTemp
        '
        Me.lblAnnualMonthlyTemp.AutoSize = True
        Me.lblAnnualMonthlyTemp.Location = New System.Drawing.Point(537, 29)
        Me.lblAnnualMonthlyTemp.Name = "lblAnnualMonthlyTemp"
        Me.lblAnnualMonthlyTemp.Size = New System.Drawing.Size(217, 20)
        Me.lblAnnualMonthlyTemp.TabIndex = 14
        Me.lblAnnualMonthlyTemp.Text = "Annual Monthly Temperature:"
        '
        'ucrReceiverCropDefinition
        '
        Me.ucrReceiverCropDefinition.AutoSize = True
        Me.ucrReceiverCropDefinition.frmParent = Me
        Me.ucrReceiverCropDefinition.Location = New System.Drawing.Point(541, 214)
        Me.ucrReceiverCropDefinition.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCropDefinition.Name = "ucrReceiverCropDefinition"
        Me.ucrReceiverCropDefinition.Selector = Nothing
        Me.ucrReceiverCropDefinition.Size = New System.Drawing.Size(213, 30)
        Me.ucrReceiverCropDefinition.strNcFilePath = ""
        Me.ucrReceiverCropDefinition.TabIndex = 33
        Me.ucrReceiverCropDefinition.ucrSelector = Nothing
        '
        'ucrReceiverMultipleAnnualMonthlyTemp
        '
        Me.ucrReceiverMultipleAnnualMonthlyTemp.AutoSize = True
        Me.ucrReceiverMultipleAnnualMonthlyTemp.frmParent = Me
        Me.ucrReceiverMultipleAnnualMonthlyTemp.Location = New System.Drawing.Point(541, 52)
        Me.ucrReceiverMultipleAnnualMonthlyTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleAnnualMonthlyTemp.Name = "ucrReceiverMultipleAnnualMonthlyTemp"
        Me.ucrReceiverMultipleAnnualMonthlyTemp.Selector = Nothing
        Me.ucrReceiverMultipleAnnualMonthlyTemp.Size = New System.Drawing.Size(213, 127)
        Me.ucrReceiverMultipleAnnualMonthlyTemp.strNcFilePath = ""
        Me.ucrReceiverMultipleAnnualMonthlyTemp.TabIndex = 30
        Me.ucrReceiverMultipleAnnualMonthlyTemp.ucrSelector = Nothing
        '
        'lblMonthlyRainfall
        '
        Me.lblMonthlyRainfall.AutoSize = True
        Me.lblMonthlyRainfall.Location = New System.Drawing.Point(10, 187)
        Me.lblMonthlyRainfall.Name = "lblMonthlyRainfall"
        Me.lblMonthlyRainfall.Size = New System.Drawing.Size(125, 20)
        Me.lblMonthlyRainfall.TabIndex = 12
        Me.lblMonthlyRainfall.Text = "Monthly Rainfall:"
        '
        'ucrReceiverMultipleMonthlyRainfall
        '
        Me.ucrReceiverMultipleMonthlyRainfall.AutoSize = True
        Me.ucrReceiverMultipleMonthlyRainfall.frmParent = Me
        Me.ucrReceiverMultipleMonthlyRainfall.Location = New System.Drawing.Point(14, 210)
        Me.ucrReceiverMultipleMonthlyRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleMonthlyRainfall.Name = "ucrReceiverMultipleMonthlyRainfall"
        Me.ucrReceiverMultipleMonthlyRainfall.Selector = Nothing
        Me.ucrReceiverMultipleMonthlyRainfall.Size = New System.Drawing.Size(213, 127)
        Me.ucrReceiverMultipleMonthlyRainfall.strNcFilePath = ""
        Me.ucrReceiverMultipleMonthlyRainfall.TabIndex = 31
        Me.ucrReceiverMultipleMonthlyRainfall.ucrSelector = Nothing
        '
        'lblMonthlyTemp
        '
        Me.lblMonthlyTemp.AutoSize = True
        Me.lblMonthlyTemp.Location = New System.Drawing.Point(274, 187)
        Me.lblMonthlyTemp.Name = "lblMonthlyTemp"
        Me.lblMonthlyTemp.Size = New System.Drawing.Size(163, 20)
        Me.lblMonthlyTemp.TabIndex = 10
        Me.lblMonthlyTemp.Text = "Monthly Temperature:"
        '
        'ucrReceiverMultipleMonthlyTemp
        '
        Me.ucrReceiverMultipleMonthlyTemp.AutoSize = True
        Me.ucrReceiverMultipleMonthlyTemp.frmParent = Me
        Me.ucrReceiverMultipleMonthlyTemp.Location = New System.Drawing.Point(278, 210)
        Me.ucrReceiverMultipleMonthlyTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleMonthlyTemp.Name = "ucrReceiverMultipleMonthlyTemp"
        Me.ucrReceiverMultipleMonthlyTemp.Selector = Nothing
        Me.ucrReceiverMultipleMonthlyTemp.Size = New System.Drawing.Size(213, 127)
        Me.ucrReceiverMultipleMonthlyTemp.strNcFilePath = ""
        Me.ucrReceiverMultipleMonthlyTemp.TabIndex = 32
        Me.ucrReceiverMultipleMonthlyTemp.ucrSelector = Nothing
        '
        'lblAnnualTemp
        '
        Me.lblAnnualTemp.AutoSize = True
        Me.lblAnnualTemp.Location = New System.Drawing.Point(274, 29)
        Me.lblAnnualTemp.Name = "lblAnnualTemp"
        Me.lblAnnualTemp.Size = New System.Drawing.Size(158, 20)
        Me.lblAnnualTemp.TabIndex = 8
        Me.lblAnnualTemp.Text = "Annual Temperature:"
        '
        'ucrReceiverMultipleAnnualTemp
        '
        Me.ucrReceiverMultipleAnnualTemp.AutoSize = True
        Me.ucrReceiverMultipleAnnualTemp.frmParent = Me
        Me.ucrReceiverMultipleAnnualTemp.Location = New System.Drawing.Point(278, 52)
        Me.ucrReceiverMultipleAnnualTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleAnnualTemp.Name = "ucrReceiverMultipleAnnualTemp"
        Me.ucrReceiverMultipleAnnualTemp.Selector = Nothing
        Me.ucrReceiverMultipleAnnualTemp.Size = New System.Drawing.Size(213, 127)
        Me.ucrReceiverMultipleAnnualTemp.strNcFilePath = ""
        Me.ucrReceiverMultipleAnnualTemp.TabIndex = 29
        Me.ucrReceiverMultipleAnnualTemp.ucrSelector = Nothing
        '
        'lblAnnualRainfall
        '
        Me.lblAnnualRainfall.AutoSize = True
        Me.lblAnnualRainfall.Location = New System.Drawing.Point(10, 29)
        Me.lblAnnualRainfall.Name = "lblAnnualRainfall"
        Me.lblAnnualRainfall.Size = New System.Drawing.Size(120, 20)
        Me.lblAnnualRainfall.TabIndex = 6
        Me.lblAnnualRainfall.Text = "Annual Rainfall:"
        '
        'ucrReceiverMultipleAnnualRainfall
        '
        Me.ucrReceiverMultipleAnnualRainfall.AutoSize = True
        Me.ucrReceiverMultipleAnnualRainfall.frmParent = Me
        Me.ucrReceiverMultipleAnnualRainfall.Location = New System.Drawing.Point(14, 52)
        Me.ucrReceiverMultipleAnnualRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleAnnualRainfall.Name = "ucrReceiverMultipleAnnualRainfall"
        Me.ucrReceiverMultipleAnnualRainfall.Selector = Nothing
        Me.ucrReceiverMultipleAnnualRainfall.Size = New System.Drawing.Size(213, 127)
        Me.ucrReceiverMultipleAnnualRainfall.strNcFilePath = ""
        Me.ucrReceiverMultipleAnnualRainfall.TabIndex = 28
        Me.ucrReceiverMultipleAnnualRainfall.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(19, 878)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 52
        '
        'lblAnnualMonthlyTempSummaries
        '
        Me.lblAnnualMonthlyTempSummaries.AutoSize = True
        Me.lblAnnualMonthlyTempSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAnnualMonthlyTempSummaries.Location = New System.Drawing.Point(403, 346)
        Me.lblAnnualMonthlyTempSummaries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnnualMonthlyTempSummaries.Name = "lblAnnualMonthlyTempSummaries"
        Me.lblAnnualMonthlyTempSummaries.Size = New System.Drawing.Size(302, 20)
        Me.lblAnnualMonthlyTempSummaries.TabIndex = 53
        Me.lblAnnualMonthlyTempSummaries.Tag = "By_Factor:"
        Me.lblAnnualMonthlyTempSummaries.Text = "Annual-Monthly Temperature Summaries:"
        '
        'ucrReceiverAnnualMonthlyTempSummaries
        '
        Me.ucrReceiverAnnualMonthlyTempSummaries.AutoSize = True
        Me.ucrReceiverAnnualMonthlyTempSummaries.frmParent = Me
        Me.ucrReceiverAnnualMonthlyTempSummaries.Location = New System.Drawing.Point(407, 369)
        Me.ucrReceiverAnnualMonthlyTempSummaries.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAnnualMonthlyTempSummaries.Name = "ucrReceiverAnnualMonthlyTempSummaries"
        Me.ucrReceiverAnnualMonthlyTempSummaries.Selector = Nothing
        Me.ucrReceiverAnnualMonthlyTempSummaries.Size = New System.Drawing.Size(294, 30)
        Me.ucrReceiverAnnualMonthlyTempSummaries.strNcFilePath = ""
        Me.ucrReceiverAnnualMonthlyTempSummaries.TabIndex = 25
        Me.ucrReceiverAnnualMonthlyTempSummaries.ucrSelector = Nothing
        '
        'lblDataframes
        '
        Me.lblDataframes.AutoSize = True
        Me.lblDataframes.Location = New System.Drawing.Point(29, 116)
        Me.lblDataframes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataframes.Name = "lblDataframes"
        Me.lblDataframes.Size = New System.Drawing.Size(106, 20)
        Me.lblDataframes.TabIndex = 55
        Me.lblDataframes.Text = "Data Frames:"
        '
        'ucrSelectorDataFramesExportToEPicsa
        '
        Me.ucrSelectorDataFramesExportToEPicsa.AutoSize = True
        Me.ucrSelectorDataFramesExportToEPicsa.bShowHiddenColumns = False
        Me.ucrSelectorDataFramesExportToEPicsa.Location = New System.Drawing.Point(29, 141)
        Me.ucrSelectorDataFramesExportToEPicsa.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataFramesExportToEPicsa.Name = "ucrSelectorDataFramesExportToEPicsa"
        Me.ucrSelectorDataFramesExportToEPicsa.Size = New System.Drawing.Size(324, 212)
        Me.ucrSelectorDataFramesExportToEPicsa.TabIndex = 56
        '
        'lblPropSummaries
        '
        Me.lblPropSummaries.AutoSize = True
        Me.lblPropSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPropSummaries.Location = New System.Drawing.Point(403, 460)
        Me.lblPropSummaries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPropSummaries.Name = "lblPropSummaries"
        Me.lblPropSummaries.Size = New System.Drawing.Size(130, 20)
        Me.lblPropSummaries.TabIndex = 57
        Me.lblPropSummaries.Tag = "By_Factor:"
        Me.lblPropSummaries.Text = "Prop Summaries:"
        '
        'ucrReceiverPropSummaries
        '
        Me.ucrReceiverPropSummaries.AutoSize = True
        Me.ucrReceiverPropSummaries.frmParent = Me
        Me.ucrReceiverPropSummaries.Location = New System.Drawing.Point(407, 483)
        Me.ucrReceiverPropSummaries.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPropSummaries.Name = "ucrReceiverPropSummaries"
        Me.ucrReceiverPropSummaries.Selector = Nothing
        Me.ucrReceiverPropSummaries.Size = New System.Drawing.Size(294, 30)
        Me.ucrReceiverPropSummaries.strNcFilePath = ""
        Me.ucrReceiverPropSummaries.TabIndex = 27
        Me.ucrReceiverPropSummaries.ucrSelector = Nothing
        '
        'lblCropSummaries
        '
        Me.lblCropSummaries.AutoSize = True
        Me.lblCropSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCropSummaries.Location = New System.Drawing.Point(403, 403)
        Me.lblCropSummaries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCropSummaries.Name = "lblCropSummaries"
        Me.lblCropSummaries.Size = New System.Drawing.Size(131, 20)
        Me.lblCropSummaries.TabIndex = 59
        Me.lblCropSummaries.Tag = "By_Factor:"
        Me.lblCropSummaries.Text = "Crop Summaries:"
        '
        'ucrReceiverCropSummaries
        '
        Me.ucrReceiverCropSummaries.AutoSize = True
        Me.ucrReceiverCropSummaries.frmParent = Me
        Me.ucrReceiverCropSummaries.Location = New System.Drawing.Point(407, 426)
        Me.ucrReceiverCropSummaries.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCropSummaries.Name = "ucrReceiverCropSummaries"
        Me.ucrReceiverCropSummaries.Selector = Nothing
        Me.ucrReceiverCropSummaries.Size = New System.Drawing.Size(294, 30)
        Me.ucrReceiverCropSummaries.strNcFilePath = ""
        Me.ucrReceiverCropSummaries.TabIndex = 26
        Me.ucrReceiverCropSummaries.ucrSelector = Nothing
        '
        'rdoStationMetadata
        '
        Me.rdoStationMetadata.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStationMetadata.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStationMetadata.FlatAppearance.BorderSize = 2
        Me.rdoStationMetadata.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStationMetadata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStationMetadata.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStationMetadata.Location = New System.Drawing.Point(389, 14)
        Me.rdoStationMetadata.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoStationMetadata.Name = "rdoStationMetadata"
        Me.rdoStationMetadata.Size = New System.Drawing.Size(174, 40)
        Me.rdoStationMetadata.TabIndex = 62
        Me.rdoStationMetadata.Text = "Station Metadata"
        Me.rdoStationMetadata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStationMetadata.UseVisualStyleBackColor = True
        '
        'rdoSummaryData
        '
        Me.rdoSummaryData.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSummaryData.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummaryData.FlatAppearance.BorderSize = 2
        Me.rdoSummaryData.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummaryData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSummaryData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSummaryData.Location = New System.Drawing.Point(219, 14)
        Me.rdoSummaryData.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSummaryData.Name = "rdoSummaryData"
        Me.rdoSummaryData.Size = New System.Drawing.Size(174, 40)
        Me.rdoSummaryData.TabIndex = 61
        Me.rdoSummaryData.Text = "Summary Data"
        Me.rdoSummaryData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSummaryData.UseVisualStyleBackColor = True
        '
        'ucrPnlExportToEPicsa
        '
        Me.ucrPnlExportToEPicsa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlExportToEPicsa.Location = New System.Drawing.Point(207, 9)
        Me.ucrPnlExportToEPicsa.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrPnlExportToEPicsa.Name = "ucrPnlExportToEPicsa"
        Me.ucrPnlExportToEPicsa.Size = New System.Drawing.Size(370, 51)
        Me.ucrPnlExportToEPicsa.TabIndex = 60
        '
        'ucrSelectorStationMetadata
        '
        Me.ucrSelectorStationMetadata.AutoSize = True
        Me.ucrSelectorStationMetadata.bDropUnusedFilterLevels = False
        Me.ucrSelectorStationMetadata.bShowHiddenColumns = False
        Me.ucrSelectorStationMetadata.bUseCurrentFilter = True
        Me.ucrSelectorStationMetadata.Location = New System.Drawing.Point(29, 113)
        Me.ucrSelectorStationMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStationMetadata.Name = "ucrSelectorStationMetadata"
        Me.ucrSelectorStationMetadata.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorStationMetadata.TabIndex = 63
        '
        'lblDistrict
        '
        Me.lblDistrict.AutoSize = True
        Me.lblDistrict.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDistrict.Location = New System.Drawing.Point(403, 403)
        Me.lblDistrict.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDistrict.Name = "lblDistrict"
        Me.lblDistrict.Size = New System.Drawing.Size(62, 20)
        Me.lblDistrict.TabIndex = 77
        Me.lblDistrict.Tag = "By_Factor:"
        Me.lblDistrict.Text = "District:"
        '
        'ucrReceiverDistrict
        '
        Me.ucrReceiverDistrict.AutoSize = True
        Me.ucrReceiverDistrict.frmParent = Me
        Me.ucrReceiverDistrict.Location = New System.Drawing.Point(407, 426)
        Me.ucrReceiverDistrict.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDistrict.Name = "ucrReceiverDistrict"
        Me.ucrReceiverDistrict.Selector = Nothing
        Me.ucrReceiverDistrict.Size = New System.Drawing.Size(294, 30)
        Me.ucrReceiverDistrict.strNcFilePath = ""
        Me.ucrReceiverDistrict.TabIndex = 71
        Me.ucrReceiverDistrict.ucrSelector = Nothing
        '
        'lblCountryCode
        '
        Me.lblCountryCode.AutoSize = True
        Me.lblCountryCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCountryCode.Location = New System.Drawing.Point(403, 460)
        Me.lblCountryCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountryCode.Name = "lblCountryCode"
        Me.lblCountryCode.Size = New System.Drawing.Size(110, 20)
        Me.lblCountryCode.TabIndex = 76
        Me.lblCountryCode.Tag = "By_Factor:"
        Me.lblCountryCode.Text = "Country Code:"
        '
        'ucrReceiverCountryCode
        '
        Me.ucrReceiverCountryCode.AutoSize = True
        Me.ucrReceiverCountryCode.frmParent = Me
        Me.ucrReceiverCountryCode.Location = New System.Drawing.Point(407, 483)
        Me.ucrReceiverCountryCode.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCountryCode.Name = "ucrReceiverCountryCode"
        Me.ucrReceiverCountryCode.Selector = Nothing
        Me.ucrReceiverCountryCode.Size = New System.Drawing.Size(294, 30)
        Me.ucrReceiverCountryCode.strNcFilePath = ""
        Me.ucrReceiverCountryCode.TabIndex = 73
        Me.ucrReceiverCountryCode.ucrSelector = Nothing
        '
        'lblElevation
        '
        Me.lblElevation.AutoSize = True
        Me.lblElevation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElevation.Location = New System.Drawing.Point(403, 346)
        Me.lblElevation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblElevation.Name = "lblElevation"
        Me.lblElevation.Size = New System.Drawing.Size(78, 20)
        Me.lblElevation.TabIndex = 75
        Me.lblElevation.Tag = "By_Factor:"
        Me.lblElevation.Text = "Elevation:"
        '
        'ucrReceiverElevation
        '
        Me.ucrReceiverElevation.AutoSize = True
        Me.ucrReceiverElevation.frmParent = Me
        Me.ucrReceiverElevation.Location = New System.Drawing.Point(407, 369)
        Me.ucrReceiverElevation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElevation.Name = "ucrReceiverElevation"
        Me.ucrReceiverElevation.Selector = Nothing
        Me.ucrReceiverElevation.Size = New System.Drawing.Size(294, 30)
        Me.ucrReceiverElevation.strNcFilePath = ""
        Me.ucrReceiverElevation.TabIndex = 70
        Me.ucrReceiverElevation.ucrSelector = Nothing
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLongitude.Location = New System.Drawing.Point(403, 233)
        Me.lblLongitude.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(84, 20)
        Me.lblLongitude.TabIndex = 74
        Me.lblLongitude.Tag = "By_Factor:"
        Me.lblLongitude.Text = "Longitude:"
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.AutoSize = True
        Me.ucrReceiverLongitude.frmParent = Me
        Me.ucrReceiverLongitude.Location = New System.Drawing.Point(407, 255)
        Me.ucrReceiverLongitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.Size = New System.Drawing.Size(294, 30)
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.TabIndex = 67
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'lblStationName
        '
        Me.lblStationName.AutoSize = True
        Me.lblStationName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStationName.Location = New System.Drawing.Point(403, 176)
        Me.lblStationName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStationName.Name = "lblStationName"
        Me.lblStationName.Size = New System.Drawing.Size(110, 20)
        Me.lblStationName.TabIndex = 72
        Me.lblStationName.Tag = ""
        Me.lblStationName.Text = "Station Name:"
        '
        'ucrReceiverStationName
        '
        Me.ucrReceiverStationName.AutoSize = True
        Me.ucrReceiverStationName.frmParent = Me
        Me.ucrReceiverStationName.Location = New System.Drawing.Point(407, 198)
        Me.ucrReceiverStationName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationName.Name = "ucrReceiverStationName"
        Me.ucrReceiverStationName.Selector = Nothing
        Me.ucrReceiverStationName.Size = New System.Drawing.Size(294, 30)
        Me.ucrReceiverStationName.strNcFilePath = ""
        Me.ucrReceiverStationName.TabIndex = 66
        Me.ucrReceiverStationName.ucrSelector = Nothing
        '
        'lblLatitiude
        '
        Me.lblLatitiude.AutoSize = True
        Me.lblLatitiude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLatitiude.Location = New System.Drawing.Point(403, 290)
        Me.lblLatitiude.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLatitiude.Name = "lblLatitiude"
        Me.lblLatitiude.Size = New System.Drawing.Size(71, 20)
        Me.lblLatitiude.TabIndex = 68
        Me.lblLatitiude.Tag = "By_Factor:"
        Me.lblLatitiude.Text = "Latitude:"
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.AutoSize = True
        Me.ucrReceiverLatitude.frmParent = Me
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(407, 312)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(294, 30)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 69
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'lblStationID
        '
        Me.lblStationID.AutoSize = True
        Me.lblStationID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStationID.Location = New System.Drawing.Point(403, 119)
        Me.lblStationID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStationID.Name = "lblStationID"
        Me.lblStationID.Size = New System.Drawing.Size(85, 20)
        Me.lblStationID.TabIndex = 64
        Me.lblStationID.Tag = ""
        Me.lblStationID.Text = "Station ID:"
        '
        'ucrReceiverStationID
        '
        Me.ucrReceiverStationID.AutoSize = True
        Me.ucrReceiverStationID.frmParent = Me
        Me.ucrReceiverStationID.Location = New System.Drawing.Point(407, 141)
        Me.ucrReceiverStationID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationID.Name = "ucrReceiverStationID"
        Me.ucrReceiverStationID.Selector = Nothing
        Me.ucrReceiverStationID.Size = New System.Drawing.Size(294, 30)
        Me.ucrReceiverStationID.strNcFilePath = ""
        Me.ucrReceiverStationID.TabIndex = 65
        Me.ucrReceiverStationID.ucrSelector = Nothing
        '
        'dlgExportClimaticDefinitions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(804, 958)
        Me.Controls.Add(Me.lblDistrict)
        Me.Controls.Add(Me.ucrReceiverDistrict)
        Me.Controls.Add(Me.lblCountryCode)
        Me.Controls.Add(Me.ucrReceiverCountryCode)
        Me.Controls.Add(Me.lblElevation)
        Me.Controls.Add(Me.ucrReceiverElevation)
        Me.Controls.Add(Me.lblLongitude)
        Me.Controls.Add(Me.ucrReceiverLongitude)
        Me.Controls.Add(Me.lblStationName)
        Me.Controls.Add(Me.ucrReceiverStationName)
        Me.Controls.Add(Me.lblLatitiude)
        Me.Controls.Add(Me.ucrReceiverLatitude)
        Me.Controls.Add(Me.lblStationID)
        Me.Controls.Add(Me.ucrReceiverStationID)
        Me.Controls.Add(Me.rdoStationMetadata)
        Me.Controls.Add(Me.rdoSummaryData)
        Me.Controls.Add(Me.ucrPnlExportToEPicsa)
        Me.Controls.Add(Me.lblCropSummaries)
        Me.Controls.Add(Me.ucrReceiverCropSummaries)
        Me.Controls.Add(Me.lblPropSummaries)
        Me.Controls.Add(Me.ucrReceiverPropSummaries)
        Me.Controls.Add(Me.lblDataframes)
        Me.Controls.Add(Me.lblAnnualMonthlyTempSummaries)
        Me.Controls.Add(Me.ucrReceiverAnnualMonthlyTempSummaries)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpDefinitionsProducts)
        Me.Controls.Add(Me.lblMonthlyRainfallSummaries)
        Me.Controls.Add(Me.ucrReceiverMonthlyRainfallSummaries)
        Me.Controls.Add(Me.lblAnnualTempSummaries)
        Me.Controls.Add(Me.ucrReceiverAnnualTempSummaries)
        Me.Controls.Add(Me.lblMonthlyTempSummaries)
        Me.Controls.Add(Me.ucrReceiverMonthlyTempSummaries)
        Me.Controls.Add(Me.lblAnnualRainfallSummaries)
        Me.Controls.Add(Me.ucrReceiverAnnualRainfallSummaries)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.btnConnection)
        Me.Controls.Add(Me.ucrSelectorStationMetadata)
        Me.Controls.Add(Me.ucrSelectorDataFramesExportToEPicsa)
        Me.Controls.Add(Me.ucrSelectorExportToEPicsa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportClimaticDefinitions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export to EPicsa"
        Me.grpDefinitionsProducts.ResumeLayout(False)
        Me.grpDefinitionsProducts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblConnection As Label
    Friend WithEvents btnConnection As Button
    Friend WithEvents ucrSelectorExportToEPicsa As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblAnnualRainfallSummaries As Label
    Friend WithEvents ucrReceiverAnnualRainfallSummaries As ucrReceiverSingle
    Friend WithEvents lblMonthlyRainfallSummaries As Label
    Friend WithEvents ucrReceiverMonthlyRainfallSummaries As ucrReceiverSingle
    Friend WithEvents lblAnnualTempSummaries As Label
    Friend WithEvents ucrReceiverAnnualTempSummaries As ucrReceiverSingle
    Friend WithEvents lblMonthlyTempSummaries As Label
    Friend WithEvents ucrReceiverMonthlyTempSummaries As ucrReceiverSingle
    Friend WithEvents grpDefinitionsProducts As GroupBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblMonthlyRainfall As Label
    Friend WithEvents ucrReceiverMultipleMonthlyRainfall As ucrReceiverMultiple
    Friend WithEvents lblMonthlyTemp As Label
    Friend WithEvents ucrReceiverMultipleMonthlyTemp As ucrReceiverMultiple
    Friend WithEvents lblAnnualTemp As Label
    Friend WithEvents ucrReceiverMultipleAnnualTemp As ucrReceiverMultiple
    Friend WithEvents lblAnnualRainfall As Label
    Friend WithEvents ucrReceiverMultipleAnnualRainfall As ucrReceiverMultiple
    Friend WithEvents lblAnnualMonthlyTempSummaries As Label
    Friend WithEvents ucrReceiverAnnualMonthlyTempSummaries As ucrReceiverSingle
    Friend WithEvents lblAnnualMonthlyTemp As Label
    Friend WithEvents ucrReceiverMultipleAnnualMonthlyTemp As ucrReceiverMultiple
    Friend WithEvents lblDataframes As Label
    Friend WithEvents ucrSelectorDataFramesExportToEPicsa As ucrSelectorAddRemove
    Friend WithEvents lblCropSummaries As Label
    Friend WithEvents ucrReceiverCropSummaries As ucrReceiverSingle
    Friend WithEvents lblPropSummaries As Label
    Friend WithEvents ucrReceiverPropSummaries As ucrReceiverSingle
    Friend WithEvents lblPropDefinition As Label
    Friend WithEvents lblCropDefinition As Label
    Friend WithEvents ucrReceiverPropDefinition As ucrReceiverSingle
    Friend WithEvents ucrReceiverCropDefinition As ucrReceiverSingle
    Friend WithEvents rdoStationMetadata As RadioButton
    Friend WithEvents rdoSummaryData As RadioButton
    Friend WithEvents ucrPnlExportToEPicsa As UcrPanel
    Friend WithEvents ucrSelectorStationMetadata As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblDistrict As Label
    Friend WithEvents ucrReceiverDistrict As ucrReceiverSingle
    Friend WithEvents lblCountryCode As Label
    Friend WithEvents ucrReceiverCountryCode As ucrReceiverSingle
    Friend WithEvents lblElevation As Label
    Friend WithEvents ucrReceiverElevation As ucrReceiverSingle
    Friend WithEvents lblLongitude As Label
    Friend WithEvents ucrReceiverLongitude As ucrReceiverSingle
    Friend WithEvents lblStationName As Label
    Friend WithEvents ucrReceiverStationName As ucrReceiverSingle
    Friend WithEvents lblLatitiude As Label
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents lblStationID As Label
    Friend WithEvents ucrReceiverStationID As ucrReceiverSingle
End Class
