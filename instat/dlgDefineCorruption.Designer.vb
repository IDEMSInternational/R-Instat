<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDefineCorruption
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ucrDefineCorruptionSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.panClimateType = New System.Windows.Forms.Panel()
        Me.lblPPPConversionRate = New System.Windows.Forms.Label()
        Me.lblNoBids = New System.Windows.Forms.Label()
        Me.ucrReceiverPPPConversionRate = New instat.ucrReceiverSingle()
        Me.ucrReceiverNoBids = New instat.ucrReceiverSingle()
        Me.ucrReceiverForeignWinner = New instat.ucrReceiverSingle()
        Me.ucrReceiverProcedureType = New instat.ucrReceiverSingle()
        Me.lblForeignWinner = New System.Windows.Forms.Label()
        Me.lblProcedureType = New System.Windows.Forms.Label()
        Me.ucrReceiverCountryISO = New instat.ucrReceiverSingle()
        Me.ucrReceiverOriginalContractValue = New instat.ucrReceiverSingle()
        Me.lblCountryISO = New System.Windows.Forms.Label()
        Me.lblOriginalContractValue = New System.Windows.Forms.Label()
        Me.ucrReceiverNoConsideredBids = New instat.ucrReceiverSingle()
        Me.ucrReceiverWinnerCountry = New instat.ucrReceiverSingle()
        Me.lblNoConsideredBids = New System.Windows.Forms.Label()
        Me.lblWinnerCountry = New System.Windows.Forms.Label()
        Me.ucrReceiverProcuringAuthority = New instat.ucrReceiverSingle()
        Me.lblProcuringAuthority = New System.Windows.Forms.Label()
        Me.ucrReceiverCountry = New instat.ucrReceiverSingle()
        Me.ucrReceiverProcuringAuthorityID = New instat.ucrReceiverSingle()
        Me.ucrReceiverSignatureDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverSector = New instat.ucrReceiverSingle()
        Me.ucrReceiverProcurementCategory = New instat.ucrReceiverSingle()
        Me.ucrReceiverWinnerName = New instat.ucrReceiverSingle()
        Me.ucrReceiverWinnerID = New instat.ucrReceiverSingle()
        Me.lblWinnerID = New System.Windows.Forms.Label()
        Me.lblWinnerName = New System.Windows.Forms.Label()
        Me.lblSector = New System.Windows.Forms.Label()
        Me.lblProcurementCategory = New System.Windows.Forms.Label()
        Me.lblContractName = New System.Windows.Forms.Label()
        Me.ucrReceiverAwardDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverContractName = New instat.ucrReceiverSingle()
        Me.lblProcuringAuthorityID = New System.Windows.Forms.Label()
        Me.lblAwardDate = New System.Windows.Forms.Label()
        Me.lblSignatureDate = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.panClimateType.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrDefineCorruptionSelector
        '
        Me.ucrDefineCorruptionSelector.bShowHiddenColumns = False
        Me.ucrDefineCorruptionSelector.bUseCurrentFilter = True
        Me.ucrDefineCorruptionSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrDefineCorruptionSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDefineCorruptionSelector.Name = "ucrDefineCorruptionSelector"
        Me.ucrDefineCorruptionSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrDefineCorruptionSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 281)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 1
        '
        'panClimateType
        '
        Me.panClimateType.AutoScroll = True
        Me.panClimateType.Controls.Add(Me.lblPPPConversionRate)
        Me.panClimateType.Controls.Add(Me.lblNoBids)
        Me.panClimateType.Controls.Add(Me.ucrReceiverPPPConversionRate)
        Me.panClimateType.Controls.Add(Me.ucrReceiverNoBids)
        Me.panClimateType.Controls.Add(Me.ucrReceiverForeignWinner)
        Me.panClimateType.Controls.Add(Me.ucrReceiverProcedureType)
        Me.panClimateType.Controls.Add(Me.lblForeignWinner)
        Me.panClimateType.Controls.Add(Me.lblProcedureType)
        Me.panClimateType.Controls.Add(Me.ucrReceiverCountryISO)
        Me.panClimateType.Controls.Add(Me.ucrReceiverOriginalContractValue)
        Me.panClimateType.Controls.Add(Me.lblCountryISO)
        Me.panClimateType.Controls.Add(Me.lblOriginalContractValue)
        Me.panClimateType.Controls.Add(Me.ucrReceiverNoConsideredBids)
        Me.panClimateType.Controls.Add(Me.ucrReceiverWinnerCountry)
        Me.panClimateType.Controls.Add(Me.lblNoConsideredBids)
        Me.panClimateType.Controls.Add(Me.lblWinnerCountry)
        Me.panClimateType.Controls.Add(Me.ucrReceiverProcuringAuthority)
        Me.panClimateType.Controls.Add(Me.lblProcuringAuthority)
        Me.panClimateType.Controls.Add(Me.ucrReceiverCountry)
        Me.panClimateType.Controls.Add(Me.ucrReceiverProcuringAuthorityID)
        Me.panClimateType.Controls.Add(Me.ucrReceiverSignatureDate)
        Me.panClimateType.Controls.Add(Me.ucrReceiverSector)
        Me.panClimateType.Controls.Add(Me.ucrReceiverProcurementCategory)
        Me.panClimateType.Controls.Add(Me.ucrReceiverWinnerName)
        Me.panClimateType.Controls.Add(Me.ucrReceiverWinnerID)
        Me.panClimateType.Controls.Add(Me.lblWinnerID)
        Me.panClimateType.Controls.Add(Me.lblWinnerName)
        Me.panClimateType.Controls.Add(Me.lblSector)
        Me.panClimateType.Controls.Add(Me.lblProcurementCategory)
        Me.panClimateType.Controls.Add(Me.lblContractName)
        Me.panClimateType.Controls.Add(Me.ucrReceiverAwardDate)
        Me.panClimateType.Controls.Add(Me.ucrReceiverContractName)
        Me.panClimateType.Controls.Add(Me.lblProcuringAuthorityID)
        Me.panClimateType.Controls.Add(Me.lblAwardDate)
        Me.panClimateType.Controls.Add(Me.lblSignatureDate)
        Me.panClimateType.Controls.Add(Me.lblCountry)
        Me.panClimateType.Location = New System.Drawing.Point(238, 10)
        Me.panClimateType.Name = "panClimateType"
        Me.panClimateType.Size = New System.Drawing.Size(172, 265)
        Me.panClimateType.TabIndex = 2
        '
        'lblPPPConversionRate
        '
        Me.lblPPPConversionRate.AutoSize = True
        Me.lblPPPConversionRate.Location = New System.Drawing.Point(13, 740)
        Me.lblPPPConversionRate.Name = "lblPPPConversionRate"
        Me.lblPPPConversionRate.Size = New System.Drawing.Size(113, 13)
        Me.lblPPPConversionRate.TabIndex = 26
        Me.lblPPPConversionRate.Text = "PPP Conversion Rate:"
        '
        'lblNoBids
        '
        Me.lblNoBids.AutoSize = True
        Me.lblNoBids.Location = New System.Drawing.Point(13, 568)
        Me.lblNoBids.Name = "lblNoBids"
        Me.lblNoBids.Size = New System.Drawing.Size(50, 13)
        Me.lblNoBids.TabIndex = 26
        Me.lblNoBids.Text = "No. Bids:"
        '
        'ucrReceiverPPPConversionRate
        '
        Me.ucrReceiverPPPConversionRate.frmParent = Me
        Me.ucrReceiverPPPConversionRate.Location = New System.Drawing.Point(13, 758)
        Me.ucrReceiverPPPConversionRate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPPPConversionRate.Name = "ucrReceiverPPPConversionRate"
        Me.ucrReceiverPPPConversionRate.Selector = Nothing
        Me.ucrReceiverPPPConversionRate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPPPConversionRate.TabIndex = 27
        '
        'ucrReceiverNoBids
        '
        Me.ucrReceiverNoBids.frmParent = Me
        Me.ucrReceiverNoBids.Location = New System.Drawing.Point(13, 586)
        Me.ucrReceiverNoBids.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverNoBids.Name = "ucrReceiverNoBids"
        Me.ucrReceiverNoBids.Selector = Nothing
        Me.ucrReceiverNoBids.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverNoBids.TabIndex = 27
        '
        'ucrReceiverForeignWinner
        '
        Me.ucrReceiverForeignWinner.frmParent = Me
        Me.ucrReceiverForeignWinner.Location = New System.Drawing.Point(13, 715)
        Me.ucrReceiverForeignWinner.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForeignWinner.Name = "ucrReceiverForeignWinner"
        Me.ucrReceiverForeignWinner.Selector = Nothing
        Me.ucrReceiverForeignWinner.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverForeignWinner.TabIndex = 25
        '
        'ucrReceiverProcedureType
        '
        Me.ucrReceiverProcedureType.frmParent = Me
        Me.ucrReceiverProcedureType.Location = New System.Drawing.Point(13, 543)
        Me.ucrReceiverProcedureType.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverProcedureType.Name = "ucrReceiverProcedureType"
        Me.ucrReceiverProcedureType.Selector = Nothing
        Me.ucrReceiverProcedureType.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverProcedureType.TabIndex = 25
        '
        'lblForeignWinner
        '
        Me.lblForeignWinner.AutoSize = True
        Me.lblForeignWinner.Location = New System.Drawing.Point(13, 697)
        Me.lblForeignWinner.Name = "lblForeignWinner"
        Me.lblForeignWinner.Size = New System.Drawing.Size(82, 13)
        Me.lblForeignWinner.TabIndex = 24
        Me.lblForeignWinner.Text = "Foreign Winner:"
        '
        'lblProcedureType
        '
        Me.lblProcedureType.AutoSize = True
        Me.lblProcedureType.Location = New System.Drawing.Point(13, 525)
        Me.lblProcedureType.Name = "lblProcedureType"
        Me.lblProcedureType.Size = New System.Drawing.Size(86, 13)
        Me.lblProcedureType.TabIndex = 24
        Me.lblProcedureType.Text = "Procedure Type:"
        '
        'ucrReceiverCountryISO
        '
        Me.ucrReceiverCountryISO.frmParent = Me
        Me.ucrReceiverCountryISO.Location = New System.Drawing.Point(13, 672)
        Me.ucrReceiverCountryISO.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCountryISO.Name = "ucrReceiverCountryISO"
        Me.ucrReceiverCountryISO.Selector = Nothing
        Me.ucrReceiverCountryISO.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverCountryISO.TabIndex = 23
        '
        'ucrReceiverOriginalContractValue
        '
        Me.ucrReceiverOriginalContractValue.frmParent = Me
        Me.ucrReceiverOriginalContractValue.Location = New System.Drawing.Point(13, 500)
        Me.ucrReceiverOriginalContractValue.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOriginalContractValue.Name = "ucrReceiverOriginalContractValue"
        Me.ucrReceiverOriginalContractValue.Selector = Nothing
        Me.ucrReceiverOriginalContractValue.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverOriginalContractValue.TabIndex = 23
        '
        'lblCountryISO
        '
        Me.lblCountryISO.AutoSize = True
        Me.lblCountryISO.Location = New System.Drawing.Point(13, 654)
        Me.lblCountryISO.Name = "lblCountryISO"
        Me.lblCountryISO.Size = New System.Drawing.Size(67, 13)
        Me.lblCountryISO.TabIndex = 22
        Me.lblCountryISO.Text = "Country ISO:"
        '
        'lblOriginalContractValue
        '
        Me.lblOriginalContractValue.AutoSize = True
        Me.lblOriginalContractValue.Location = New System.Drawing.Point(13, 482)
        Me.lblOriginalContractValue.Name = "lblOriginalContractValue"
        Me.lblOriginalContractValue.Size = New System.Drawing.Size(118, 13)
        Me.lblOriginalContractValue.TabIndex = 22
        Me.lblOriginalContractValue.Text = "Original Contract Value:"
        '
        'ucrReceiverNoConsideredBids
        '
        Me.ucrReceiverNoConsideredBids.frmParent = Me
        Me.ucrReceiverNoConsideredBids.Location = New System.Drawing.Point(13, 629)
        Me.ucrReceiverNoConsideredBids.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverNoConsideredBids.Name = "ucrReceiverNoConsideredBids"
        Me.ucrReceiverNoConsideredBids.Selector = Nothing
        Me.ucrReceiverNoConsideredBids.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverNoConsideredBids.TabIndex = 21
        '
        'ucrReceiverWinnerCountry
        '
        Me.ucrReceiverWinnerCountry.frmParent = Me
        Me.ucrReceiverWinnerCountry.Location = New System.Drawing.Point(13, 457)
        Me.ucrReceiverWinnerCountry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWinnerCountry.Name = "ucrReceiverWinnerCountry"
        Me.ucrReceiverWinnerCountry.Selector = Nothing
        Me.ucrReceiverWinnerCountry.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWinnerCountry.TabIndex = 21
        '
        'lblNoConsideredBids
        '
        Me.lblNoConsideredBids.AutoSize = True
        Me.lblNoConsideredBids.Location = New System.Drawing.Point(13, 611)
        Me.lblNoConsideredBids.Name = "lblNoConsideredBids"
        Me.lblNoConsideredBids.Size = New System.Drawing.Size(106, 13)
        Me.lblNoConsideredBids.TabIndex = 20
        Me.lblNoConsideredBids.Text = "No. Considered Bids:"
        '
        'lblWinnerCountry
        '
        Me.lblWinnerCountry.AutoSize = True
        Me.lblWinnerCountry.Location = New System.Drawing.Point(13, 439)
        Me.lblWinnerCountry.Name = "lblWinnerCountry"
        Me.lblWinnerCountry.Size = New System.Drawing.Size(83, 13)
        Me.lblWinnerCountry.TabIndex = 20
        Me.lblWinnerCountry.Text = "Winner Country:"
        '
        'ucrReceiverProcuringAuthority
        '
        Me.ucrReceiverProcuringAuthority.frmParent = Me
        Me.ucrReceiverProcuringAuthority.Location = New System.Drawing.Point(13, 70)
        Me.ucrReceiverProcuringAuthority.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverProcuringAuthority.Name = "ucrReceiverProcuringAuthority"
        Me.ucrReceiverProcuringAuthority.Selector = Nothing
        Me.ucrReceiverProcuringAuthority.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverProcuringAuthority.TabIndex = 3
        '
        'lblProcuringAuthority
        '
        Me.lblProcuringAuthority.AutoSize = True
        Me.lblProcuringAuthority.Location = New System.Drawing.Point(13, 52)
        Me.lblProcuringAuthority.Name = "lblProcuringAuthority"
        Me.lblProcuringAuthority.Size = New System.Drawing.Size(99, 13)
        Me.lblProcuringAuthority.TabIndex = 2
        Me.lblProcuringAuthority.Text = "Procuring Authority:"
        '
        'ucrReceiverCountry
        '
        Me.ucrReceiverCountry.frmParent = Me
        Me.ucrReceiverCountry.Location = New System.Drawing.Point(13, 27)
        Me.ucrReceiverCountry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCountry.Name = "ucrReceiverCountry"
        Me.ucrReceiverCountry.Selector = Nothing
        Me.ucrReceiverCountry.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverCountry.TabIndex = 1
        '
        'ucrReceiverProcuringAuthorityID
        '
        Me.ucrReceiverProcuringAuthorityID.frmParent = Me
        Me.ucrReceiverProcuringAuthorityID.Location = New System.Drawing.Point(13, 113)
        Me.ucrReceiverProcuringAuthorityID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverProcuringAuthorityID.Name = "ucrReceiverProcuringAuthorityID"
        Me.ucrReceiverProcuringAuthorityID.Selector = Nothing
        Me.ucrReceiverProcuringAuthorityID.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverProcuringAuthorityID.TabIndex = 5
        '
        'ucrReceiverSignatureDate
        '
        Me.ucrReceiverSignatureDate.frmParent = Me
        Me.ucrReceiverSignatureDate.Location = New System.Drawing.Point(13, 199)
        Me.ucrReceiverSignatureDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSignatureDate.Name = "ucrReceiverSignatureDate"
        Me.ucrReceiverSignatureDate.Selector = Nothing
        Me.ucrReceiverSignatureDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSignatureDate.TabIndex = 9
        '
        'ucrReceiverSector
        '
        Me.ucrReceiverSector.frmParent = Me
        Me.ucrReceiverSector.Location = New System.Drawing.Point(13, 285)
        Me.ucrReceiverSector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSector.Name = "ucrReceiverSector"
        Me.ucrReceiverSector.Selector = Nothing
        Me.ucrReceiverSector.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSector.TabIndex = 13
        '
        'ucrReceiverProcurementCategory
        '
        Me.ucrReceiverProcurementCategory.frmParent = Me
        Me.ucrReceiverProcurementCategory.Location = New System.Drawing.Point(13, 328)
        Me.ucrReceiverProcurementCategory.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverProcurementCategory.Name = "ucrReceiverProcurementCategory"
        Me.ucrReceiverProcurementCategory.Selector = Nothing
        Me.ucrReceiverProcurementCategory.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverProcurementCategory.TabIndex = 15
        '
        'ucrReceiverWinnerName
        '
        Me.ucrReceiverWinnerName.frmParent = Me
        Me.ucrReceiverWinnerName.Location = New System.Drawing.Point(13, 371)
        Me.ucrReceiverWinnerName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWinnerName.Name = "ucrReceiverWinnerName"
        Me.ucrReceiverWinnerName.Selector = Nothing
        Me.ucrReceiverWinnerName.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWinnerName.TabIndex = 17
        '
        'ucrReceiverWinnerID
        '
        Me.ucrReceiverWinnerID.frmParent = Me
        Me.ucrReceiverWinnerID.Location = New System.Drawing.Point(13, 414)
        Me.ucrReceiverWinnerID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWinnerID.Name = "ucrReceiverWinnerID"
        Me.ucrReceiverWinnerID.Selector = Nothing
        Me.ucrReceiverWinnerID.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWinnerID.TabIndex = 19
        '
        'lblWinnerID
        '
        Me.lblWinnerID.AutoSize = True
        Me.lblWinnerID.Location = New System.Drawing.Point(13, 396)
        Me.lblWinnerID.Name = "lblWinnerID"
        Me.lblWinnerID.Size = New System.Drawing.Size(58, 13)
        Me.lblWinnerID.TabIndex = 18
        Me.lblWinnerID.Text = "Winner ID:"
        '
        'lblWinnerName
        '
        Me.lblWinnerName.AutoSize = True
        Me.lblWinnerName.Location = New System.Drawing.Point(13, 353)
        Me.lblWinnerName.Name = "lblWinnerName"
        Me.lblWinnerName.Size = New System.Drawing.Size(75, 13)
        Me.lblWinnerName.TabIndex = 16
        Me.lblWinnerName.Text = "Winner Name:"
        '
        'lblSector
        '
        Me.lblSector.AutoSize = True
        Me.lblSector.Location = New System.Drawing.Point(13, 267)
        Me.lblSector.Name = "lblSector"
        Me.lblSector.Size = New System.Drawing.Size(41, 13)
        Me.lblSector.TabIndex = 12
        Me.lblSector.Text = "Sector:"
        '
        'lblProcurementCategory
        '
        Me.lblProcurementCategory.AutoSize = True
        Me.lblProcurementCategory.Location = New System.Drawing.Point(13, 310)
        Me.lblProcurementCategory.Name = "lblProcurementCategory"
        Me.lblProcurementCategory.Size = New System.Drawing.Size(115, 13)
        Me.lblProcurementCategory.TabIndex = 14
        Me.lblProcurementCategory.Text = "Procurement Category:"
        '
        'lblContractName
        '
        Me.lblContractName.AutoSize = True
        Me.lblContractName.Location = New System.Drawing.Point(13, 224)
        Me.lblContractName.Name = "lblContractName"
        Me.lblContractName.Size = New System.Drawing.Size(81, 13)
        Me.lblContractName.TabIndex = 10
        Me.lblContractName.Text = "Contract Name:"
        '
        'ucrReceiverAwardDate
        '
        Me.ucrReceiverAwardDate.frmParent = Me
        Me.ucrReceiverAwardDate.Location = New System.Drawing.Point(13, 156)
        Me.ucrReceiverAwardDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAwardDate.Name = "ucrReceiverAwardDate"
        Me.ucrReceiverAwardDate.Selector = Nothing
        Me.ucrReceiverAwardDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverAwardDate.TabIndex = 7
        '
        'ucrReceiverContractName
        '
        Me.ucrReceiverContractName.frmParent = Me
        Me.ucrReceiverContractName.Location = New System.Drawing.Point(13, 242)
        Me.ucrReceiverContractName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContractName.Name = "ucrReceiverContractName"
        Me.ucrReceiverContractName.Selector = Nothing
        Me.ucrReceiverContractName.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverContractName.TabIndex = 11
        '
        'lblProcuringAuthorityID
        '
        Me.lblProcuringAuthorityID.AutoSize = True
        Me.lblProcuringAuthorityID.Location = New System.Drawing.Point(13, 95)
        Me.lblProcuringAuthorityID.Name = "lblProcuringAuthorityID"
        Me.lblProcuringAuthorityID.Size = New System.Drawing.Size(113, 13)
        Me.lblProcuringAuthorityID.TabIndex = 4
        Me.lblProcuringAuthorityID.Text = "Procuring Authority ID:"
        '
        'lblAwardDate
        '
        Me.lblAwardDate.AutoSize = True
        Me.lblAwardDate.Location = New System.Drawing.Point(13, 138)
        Me.lblAwardDate.Name = "lblAwardDate"
        Me.lblAwardDate.Size = New System.Drawing.Size(66, 13)
        Me.lblAwardDate.TabIndex = 6
        Me.lblAwardDate.Text = "Award Date:"
        '
        'lblSignatureDate
        '
        Me.lblSignatureDate.AutoSize = True
        Me.lblSignatureDate.Location = New System.Drawing.Point(13, 181)
        Me.lblSignatureDate.Name = "lblSignatureDate"
        Me.lblSignatureDate.Size = New System.Drawing.Size(81, 13)
        Me.lblSignatureDate.TabIndex = 8
        Me.lblSignatureDate.Text = "Signature Date:"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(13, 9)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(46, 13)
        Me.lblCountry.TabIndex = 0
        Me.lblCountry.Text = "Country:"
        '
        'dlgDefineCorruption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 338)
        Me.Controls.Add(Me.panClimateType)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrDefineCorruptionSelector)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDefineCorruption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Define Corruption"
        Me.panClimateType.ResumeLayout(False)
        Me.panClimateType.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrDefineCorruptionSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents panClimateType As Panel
    Friend WithEvents lblPPPConversionRate As Label
    Friend WithEvents lblNoBids As Label
    Friend WithEvents ucrReceiverPPPConversionRate As ucrReceiverSingle
    Friend WithEvents ucrReceiverNoBids As ucrReceiverSingle
    Friend WithEvents ucrReceiverForeignWinner As ucrReceiverSingle
    Friend WithEvents ucrReceiverProcedureType As ucrReceiverSingle
    Friend WithEvents lblForeignWinner As Label
    Friend WithEvents lblProcedureType As Label
    Friend WithEvents ucrReceiverCountryISO As ucrReceiverSingle
    Friend WithEvents ucrReceiverOriginalContractValue As ucrReceiverSingle
    Friend WithEvents lblCountryISO As Label
    Friend WithEvents lblOriginalContractValue As Label
    Friend WithEvents ucrReceiverNoConsideredBids As ucrReceiverSingle
    Friend WithEvents ucrReceiverWinnerCountry As ucrReceiverSingle
    Friend WithEvents lblNoConsideredBids As Label
    Friend WithEvents lblWinnerCountry As Label
    Friend WithEvents ucrReceiverProcuringAuthority As ucrReceiverSingle
    Friend WithEvents lblProcuringAuthority As Label
    Friend WithEvents ucrReceiverCountry As ucrReceiverSingle
    Friend WithEvents ucrReceiverProcuringAuthorityID As ucrReceiverSingle
    Friend WithEvents ucrReceiverSignatureDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverSector As ucrReceiverSingle
    Friend WithEvents ucrReceiverProcurementCategory As ucrReceiverSingle
    Friend WithEvents ucrReceiverWinnerName As ucrReceiverSingle
    Friend WithEvents ucrReceiverWinnerID As ucrReceiverSingle
    Friend WithEvents lblWinnerID As Label
    Friend WithEvents lblWinnerName As Label
    Friend WithEvents lblSector As Label
    Friend WithEvents lblProcurementCategory As Label
    Friend WithEvents lblContractName As Label
    Friend WithEvents ucrReceiverAwardDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverContractName As ucrReceiverSingle
    Friend WithEvents lblProcuringAuthorityID As Label
    Friend WithEvents lblAwardDate As Label
    Friend WithEvents lblSignatureDate As Label
    Friend WithEvents lblCountry As Label
End Class
