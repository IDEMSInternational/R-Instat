' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgCorruptionCalculatedColumns
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
        Me.ucrCalculatedColumnsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.lblProcedureType = New System.Windows.Forms.Label()
        Me.ucrReceiverProcedureType = New instat.ucrReceiverSingle()
        Me.lblAwardYear = New System.Windows.Forms.Label()
        Me.lblWinnerID = New System.Windows.Forms.Label()
        Me.ucrReceiverWinnerID = New instat.ucrReceiverSingle()
        Me.ucrReceiverAwardYear = New instat.ucrReceiverSingle()
        Me.lblProcuringAuthority = New System.Windows.Forms.Label()
        Me.ucrReceiverProcuringAuthority = New instat.ucrReceiverSingle()
        Me.ucrReceiverForeignWinner = New instat.ucrReceiverSingle()
        Me.lblForeignWinner = New System.Windows.Forms.Label()
        Me.lblProcurementTypeCat = New System.Windows.Forms.Label()
        Me.ucrReceiverProcurementTypeCat = New instat.ucrReceiverSingle()
        Me.lblContractValueCategories = New System.Windows.Forms.Label()
        Me.lblProcurementType3 = New System.Windows.Forms.Label()
        Me.ucrReceiverProcurementType3 = New instat.ucrReceiverSingle()
        Me.ucrReceiverContractValueCategories = New instat.ucrReceiverSingle()
        Me.lblProcurementType2 = New System.Windows.Forms.Label()
        Me.ucrReceiverProcurementType2 = New instat.ucrReceiverSingle()
        Me.ucrReceiverSignaturePeriod = New instat.ucrReceiverSingle()
        Me.lblSignaturePeriod = New System.Windows.Forms.Label()
        Me.lblRollSumWinner = New System.Windows.Forms.Label()
        Me.ucrReceiverValueSumWinner = New instat.ucrReceiverSingle()
        Me.lblRollNumIssuer = New System.Windows.Forms.Label()
        Me.lblRollShareWinner = New System.Windows.Forms.Label()
        Me.ucrReceiverValueShareWinner = New instat.ucrReceiverSingle()
        Me.ucrReceiverRollingNumberIssuer = New instat.ucrReceiverSingle()
        Me.lblRollSumIssuer = New System.Windows.Forms.Label()
        Me.ucrReceiverValueSumIssuer = New instat.ucrReceiverSingle()
        Me.ucrReceiverSingleBidder = New instat.ucrReceiverSingle()
        Me.lblSingleBidder = New System.Windows.Forms.Label()
        Me.lblSignaturePeriod5 = New System.Windows.Forms.Label()
        Me.ucrReceiverPeriod5 = New instat.ucrReceiverSingle()
        Me.lblSignaturePeriodCorrected = New System.Windows.Forms.Label()
        Me.lblSignaturePeriodCat = New System.Windows.Forms.Label()
        Me.ucrReceiverPeriodCat = New instat.ucrReceiverSingle()
        Me.ucrReceiverSignaturePeriodCorrected = New instat.ucrReceiverSingle()
        Me.lblSignaturePeriod25 = New System.Windows.Forms.Label()
        Me.ucrReceiverPeriod25 = New instat.ucrReceiverSingle()
        Me.ucrReceiverRollingNumberWinner = New instat.ucrReceiverSingle()
        Me.lblRollNumWinner = New System.Windows.Forms.Label()
        Me.lblWinnerCountryISO3 = New System.Windows.Forms.Label()
        Me.ucrReceiverWinnerCountryISO3 = New instat.ucrReceiverSingle()
        Me.lblWinnerCountryISO2 = New System.Windows.Forms.Label()
        Me.lblWBPPP = New System.Windows.Forms.Label()
        Me.ucrReceiverPPPAdjustedContractValue = New instat.ucrReceiverSingle()
        Me.ucrReceiverWinnerCountryISO2 = New instat.ucrReceiverSingle()
        Me.lblPPPAdjustedContractValue = New System.Windows.Forms.Label()
        Me.ucrReceiverWBPPP = New instat.ucrReceiverSingle()
        Me.ucrReceiverSecrecyScore = New instat.ucrReceiverSingle()
        Me.lblSecrecyScore = New System.Windows.Forms.Label()
        Me.lblCountryISO2 = New System.Windows.Forms.Label()
        Me.ucrReceiverCountryISO2 = New instat.ucrReceiverSingle()
        Me.lblContractValueShareOverThreshold = New System.Windows.Forms.Label()
        Me.lblAddBids = New System.Windows.Forms.Label()
        Me.ucrReceiverAllBids = New instat.ucrReceiverSingle()
        Me.ucrReceiverContractShareThreshold = New instat.ucrReceiverSingle()
        Me.lblCountryISO3 = New System.Windows.Forms.Label()
        Me.ucrReceiverCountryISO3 = New instat.ucrReceiverSingle()
        Me.ucrReceiverAllBidsTrimmed = New instat.ucrReceiverSingle()
        Me.lblAllBidsTrimmed = New System.Windows.Forms.Label()
        Me.lblTaxHaven2 = New System.Windows.Forms.Label()
        Me.ucrReceiverTaxHaven2 = New instat.ucrReceiverSingle()
        Me.lblTaxHaven = New System.Windows.Forms.Label()
        Me.lblTaxHaven3bi = New System.Windows.Forms.Label()
        Me.ucrReceiverTaxHaven3bi = New instat.ucrReceiverSingle()
        Me.ucrReceiverTaxHaven = New instat.ucrReceiverSingle()
        Me.lblTaxHaven3 = New System.Windows.Forms.Label()
        Me.ucrReceiverTaxHaven3 = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'ucrCalculatedColumnsSelector
        '
        Me.ucrCalculatedColumnsSelector.AutoSize = True
        Me.ucrCalculatedColumnsSelector.bDropUnusedFilterLevels = False
        Me.ucrCalculatedColumnsSelector.bShowHiddenColumns = False
        Me.ucrCalculatedColumnsSelector.bUseCurrentFilter = True
        Me.ucrCalculatedColumnsSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrCalculatedColumnsSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrCalculatedColumnsSelector.Name = "ucrCalculatedColumnsSelector"
        Me.ucrCalculatedColumnsSelector.Size = New System.Drawing.Size(213, 183)
        Me.ucrCalculatedColumnsSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.Location = New System.Drawing.Point(367, 462)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(224, 30)
        Me.ucrBase.TabIndex = 69
        '
        'lblProcedureType
        '
        Me.lblProcedureType.AutoSize = True
        Me.lblProcedureType.Location = New System.Drawing.Point(234, 54)
        Me.lblProcedureType.Name = "lblProcedureType"
        Me.lblProcedureType.Size = New System.Drawing.Size(86, 13)
        Me.lblProcedureType.TabIndex = 3
        Me.lblProcedureType.Text = "Procedure Type:"
        '
        'ucrReceiverProcedureType
        '
        Me.ucrReceiverProcedureType.AutoSize = True
        Me.ucrReceiverProcedureType.frmParent = Me
        Me.ucrReceiverProcedureType.Location = New System.Drawing.Point(234, 69)
        Me.ucrReceiverProcedureType.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverProcedureType.Name = "ucrReceiverProcedureType"
        Me.ucrReceiverProcedureType.Selector = Nothing
        Me.ucrReceiverProcedureType.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverProcedureType.strNcFilePath = ""
        Me.ucrReceiverProcedureType.TabIndex = 4
        Me.ucrReceiverProcedureType.ucrSelector = Nothing
        '
        'lblAwardYear
        '
        Me.lblAwardYear.AutoSize = True
        Me.lblAwardYear.Location = New System.Drawing.Point(234, 11)
        Me.lblAwardYear.Name = "lblAwardYear"
        Me.lblAwardYear.Size = New System.Drawing.Size(65, 13)
        Me.lblAwardYear.TabIndex = 1
        Me.lblAwardYear.Text = "Award Year:"
        '
        'lblWinnerID
        '
        Me.lblWinnerID.AutoSize = True
        Me.lblWinnerID.Location = New System.Drawing.Point(234, 140)
        Me.lblWinnerID.Name = "lblWinnerID"
        Me.lblWinnerID.Size = New System.Drawing.Size(58, 13)
        Me.lblWinnerID.TabIndex = 7
        Me.lblWinnerID.Text = "Winner ID:"
        '
        'ucrReceiverWinnerID
        '
        Me.ucrReceiverWinnerID.AutoSize = True
        Me.ucrReceiverWinnerID.frmParent = Me
        Me.ucrReceiverWinnerID.Location = New System.Drawing.Point(234, 155)
        Me.ucrReceiverWinnerID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWinnerID.Name = "ucrReceiverWinnerID"
        Me.ucrReceiverWinnerID.Selector = Nothing
        Me.ucrReceiverWinnerID.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWinnerID.strNcFilePath = ""
        Me.ucrReceiverWinnerID.TabIndex = 8
        Me.ucrReceiverWinnerID.ucrSelector = Nothing
        '
        'ucrReceiverAwardYear
        '
        Me.ucrReceiverAwardYear.AutoSize = True
        Me.ucrReceiverAwardYear.frmParent = Me
        Me.ucrReceiverAwardYear.Location = New System.Drawing.Point(234, 26)
        Me.ucrReceiverAwardYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAwardYear.Name = "ucrReceiverAwardYear"
        Me.ucrReceiverAwardYear.Selector = Nothing
        Me.ucrReceiverAwardYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverAwardYear.strNcFilePath = ""
        Me.ucrReceiverAwardYear.TabIndex = 2
        Me.ucrReceiverAwardYear.ucrSelector = Nothing
        '
        'lblProcuringAuthority
        '
        Me.lblProcuringAuthority.AutoSize = True
        Me.lblProcuringAuthority.Location = New System.Drawing.Point(234, 97)
        Me.lblProcuringAuthority.Name = "lblProcuringAuthority"
        Me.lblProcuringAuthority.Size = New System.Drawing.Size(113, 13)
        Me.lblProcuringAuthority.TabIndex = 5
        Me.lblProcuringAuthority.Text = "Procuring Authority ID:"
        '
        'ucrReceiverProcuringAuthority
        '
        Me.ucrReceiverProcuringAuthority.AutoSize = True
        Me.ucrReceiverProcuringAuthority.frmParent = Me
        Me.ucrReceiverProcuringAuthority.Location = New System.Drawing.Point(234, 112)
        Me.ucrReceiverProcuringAuthority.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverProcuringAuthority.Name = "ucrReceiverProcuringAuthority"
        Me.ucrReceiverProcuringAuthority.Selector = Nothing
        Me.ucrReceiverProcuringAuthority.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverProcuringAuthority.strNcFilePath = ""
        Me.ucrReceiverProcuringAuthority.TabIndex = 6
        Me.ucrReceiverProcuringAuthority.ucrSelector = Nothing
        '
        'ucrReceiverForeignWinner
        '
        Me.ucrReceiverForeignWinner.AutoSize = True
        Me.ucrReceiverForeignWinner.frmParent = Me
        Me.ucrReceiverForeignWinner.Location = New System.Drawing.Point(234, 200)
        Me.ucrReceiverForeignWinner.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForeignWinner.Name = "ucrReceiverForeignWinner"
        Me.ucrReceiverForeignWinner.Selector = Nothing
        Me.ucrReceiverForeignWinner.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverForeignWinner.strNcFilePath = ""
        Me.ucrReceiverForeignWinner.TabIndex = 10
        Me.ucrReceiverForeignWinner.ucrSelector = Nothing
        '
        'lblForeignWinner
        '
        Me.lblForeignWinner.AutoSize = True
        Me.lblForeignWinner.Location = New System.Drawing.Point(234, 185)
        Me.lblForeignWinner.Name = "lblForeignWinner"
        Me.lblForeignWinner.Size = New System.Drawing.Size(82, 13)
        Me.lblForeignWinner.TabIndex = 9
        Me.lblForeignWinner.Text = "Foreign Winner:"
        '
        'lblProcurementTypeCat
        '
        Me.lblProcurementTypeCat.AutoSize = True
        Me.lblProcurementTypeCat.Location = New System.Drawing.Point(234, 268)
        Me.lblProcurementTypeCat.Name = "lblProcurementTypeCat"
        Me.lblProcurementTypeCat.Size = New System.Drawing.Size(150, 13)
        Me.lblProcurementTypeCat.TabIndex = 13
        Me.lblProcurementTypeCat.Text = "Procurement Type Categories:"
        '
        'ucrReceiverProcurementTypeCat
        '
        Me.ucrReceiverProcurementTypeCat.AutoSize = True
        Me.ucrReceiverProcurementTypeCat.frmParent = Me
        Me.ucrReceiverProcurementTypeCat.Location = New System.Drawing.Point(234, 283)
        Me.ucrReceiverProcurementTypeCat.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverProcurementTypeCat.Name = "ucrReceiverProcurementTypeCat"
        Me.ucrReceiverProcurementTypeCat.Selector = Nothing
        Me.ucrReceiverProcurementTypeCat.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverProcurementTypeCat.strNcFilePath = ""
        Me.ucrReceiverProcurementTypeCat.TabIndex = 14
        Me.ucrReceiverProcurementTypeCat.ucrSelector = Nothing
        '
        'lblContractValueCategories
        '
        Me.lblContractValueCategories.AutoSize = True
        Me.lblContractValueCategories.Location = New System.Drawing.Point(234, 225)
        Me.lblContractValueCategories.Name = "lblContractValueCategories"
        Me.lblContractValueCategories.Size = New System.Drawing.Size(133, 13)
        Me.lblContractValueCategories.TabIndex = 11
        Me.lblContractValueCategories.Text = "Contract Value Categories:"
        '
        'lblProcurementType3
        '
        Me.lblProcurementType3.AutoSize = True
        Me.lblProcurementType3.Location = New System.Drawing.Point(234, 354)
        Me.lblProcurementType3.Name = "lblProcurementType3"
        Me.lblProcurementType3.Size = New System.Drawing.Size(106, 13)
        Me.lblProcurementType3.TabIndex = 17
        Me.lblProcurementType3.Text = "Procurement Type 3:"
        '
        'ucrReceiverProcurementType3
        '
        Me.ucrReceiverProcurementType3.AutoSize = True
        Me.ucrReceiverProcurementType3.frmParent = Me
        Me.ucrReceiverProcurementType3.Location = New System.Drawing.Point(234, 369)
        Me.ucrReceiverProcurementType3.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverProcurementType3.Name = "ucrReceiverProcurementType3"
        Me.ucrReceiverProcurementType3.Selector = Nothing
        Me.ucrReceiverProcurementType3.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverProcurementType3.strNcFilePath = ""
        Me.ucrReceiverProcurementType3.TabIndex = 18
        Me.ucrReceiverProcurementType3.ucrSelector = Nothing
        '
        'ucrReceiverContractValueCategories
        '
        Me.ucrReceiverContractValueCategories.AutoSize = True
        Me.ucrReceiverContractValueCategories.frmParent = Me
        Me.ucrReceiverContractValueCategories.Location = New System.Drawing.Point(234, 240)
        Me.ucrReceiverContractValueCategories.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContractValueCategories.Name = "ucrReceiverContractValueCategories"
        Me.ucrReceiverContractValueCategories.Selector = Nothing
        Me.ucrReceiverContractValueCategories.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverContractValueCategories.strNcFilePath = ""
        Me.ucrReceiverContractValueCategories.TabIndex = 12
        Me.ucrReceiverContractValueCategories.ucrSelector = Nothing
        '
        'lblProcurementType2
        '
        Me.lblProcurementType2.AutoSize = True
        Me.lblProcurementType2.Location = New System.Drawing.Point(234, 311)
        Me.lblProcurementType2.Name = "lblProcurementType2"
        Me.lblProcurementType2.Size = New System.Drawing.Size(106, 13)
        Me.lblProcurementType2.TabIndex = 15
        Me.lblProcurementType2.Text = "Procurement Type 2:"
        '
        'ucrReceiverProcurementType2
        '
        Me.ucrReceiverProcurementType2.AutoSize = True
        Me.ucrReceiverProcurementType2.frmParent = Me
        Me.ucrReceiverProcurementType2.Location = New System.Drawing.Point(234, 326)
        Me.ucrReceiverProcurementType2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverProcurementType2.Name = "ucrReceiverProcurementType2"
        Me.ucrReceiverProcurementType2.Selector = Nothing
        Me.ucrReceiverProcurementType2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverProcurementType2.strNcFilePath = ""
        Me.ucrReceiverProcurementType2.TabIndex = 16
        Me.ucrReceiverProcurementType2.ucrSelector = Nothing
        '
        'ucrReceiverSignaturePeriod
        '
        Me.ucrReceiverSignaturePeriod.AutoSize = True
        Me.ucrReceiverSignaturePeriod.frmParent = Me
        Me.ucrReceiverSignaturePeriod.Location = New System.Drawing.Point(399, 26)
        Me.ucrReceiverSignaturePeriod.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSignaturePeriod.Name = "ucrReceiverSignaturePeriod"
        Me.ucrReceiverSignaturePeriod.Selector = Nothing
        Me.ucrReceiverSignaturePeriod.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSignaturePeriod.strNcFilePath = ""
        Me.ucrReceiverSignaturePeriod.TabIndex = 22
        Me.ucrReceiverSignaturePeriod.ucrSelector = Nothing
        '
        'lblSignaturePeriod
        '
        Me.lblSignaturePeriod.AutoSize = True
        Me.lblSignaturePeriod.Location = New System.Drawing.Point(399, 11)
        Me.lblSignaturePeriod.Name = "lblSignaturePeriod"
        Me.lblSignaturePeriod.Size = New System.Drawing.Size(88, 13)
        Me.lblSignaturePeriod.TabIndex = 21
        Me.lblSignaturePeriod.Text = "Signature Period:"
        '
        'lblRollSumWinner
        '
        Me.lblRollSumWinner.AutoSize = True
        Me.lblRollSumWinner.Location = New System.Drawing.Point(399, 311)
        Me.lblRollSumWinner.Name = "lblRollSumWinner"
        Me.lblRollSumWinner.Size = New System.Drawing.Size(146, 13)
        Me.lblRollSumWinner.TabIndex = 35
        Me.lblRollSumWinner.Text = "Rolling Contract Sum Winner:"
        '
        'ucrReceiverValueSumWinner
        '
        Me.ucrReceiverValueSumWinner.AutoSize = True
        Me.ucrReceiverValueSumWinner.frmParent = Me
        Me.ucrReceiverValueSumWinner.Location = New System.Drawing.Point(399, 326)
        Me.ucrReceiverValueSumWinner.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverValueSumWinner.Name = "ucrReceiverValueSumWinner"
        Me.ucrReceiverValueSumWinner.Selector = Nothing
        Me.ucrReceiverValueSumWinner.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverValueSumWinner.strNcFilePath = ""
        Me.ucrReceiverValueSumWinner.TabIndex = 36
        Me.ucrReceiverValueSumWinner.ucrSelector = Nothing
        '
        'lblRollNumIssuer
        '
        Me.lblRollNumIssuer.AutoSize = True
        Me.lblRollNumIssuer.Location = New System.Drawing.Point(399, 268)
        Me.lblRollNumIssuer.Name = "lblRollNumIssuer"
        Me.lblRollNumIssuer.Size = New System.Drawing.Size(156, 13)
        Me.lblRollNumIssuer.TabIndex = 33
        Me.lblRollNumIssuer.Text = "Rolling Contract Number Issuer:"
        '
        'lblRollShareWinner
        '
        Me.lblRollShareWinner.AutoSize = True
        Me.lblRollShareWinner.Location = New System.Drawing.Point(399, 397)
        Me.lblRollShareWinner.Name = "lblRollShareWinner"
        Me.lblRollShareWinner.Size = New System.Drawing.Size(153, 13)
        Me.lblRollShareWinner.TabIndex = 39
        Me.lblRollShareWinner.Text = "Rolling Contract Share Winner:"
        '
        'ucrReceiverValueShareWinner
        '
        Me.ucrReceiverValueShareWinner.AutoSize = True
        Me.ucrReceiverValueShareWinner.frmParent = Me
        Me.ucrReceiverValueShareWinner.Location = New System.Drawing.Point(399, 412)
        Me.ucrReceiverValueShareWinner.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverValueShareWinner.Name = "ucrReceiverValueShareWinner"
        Me.ucrReceiverValueShareWinner.Selector = Nothing
        Me.ucrReceiverValueShareWinner.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverValueShareWinner.strNcFilePath = ""
        Me.ucrReceiverValueShareWinner.TabIndex = 40
        Me.ucrReceiverValueShareWinner.ucrSelector = Nothing
        '
        'ucrReceiverRollingNumberIssuer
        '
        Me.ucrReceiverRollingNumberIssuer.AutoSize = True
        Me.ucrReceiverRollingNumberIssuer.frmParent = Me
        Me.ucrReceiverRollingNumberIssuer.Location = New System.Drawing.Point(399, 283)
        Me.ucrReceiverRollingNumberIssuer.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRollingNumberIssuer.Name = "ucrReceiverRollingNumberIssuer"
        Me.ucrReceiverRollingNumberIssuer.Selector = Nothing
        Me.ucrReceiverRollingNumberIssuer.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRollingNumberIssuer.strNcFilePath = ""
        Me.ucrReceiverRollingNumberIssuer.TabIndex = 34
        Me.ucrReceiverRollingNumberIssuer.ucrSelector = Nothing
        '
        'lblRollSumIssuer
        '
        Me.lblRollSumIssuer.AutoSize = True
        Me.lblRollSumIssuer.Location = New System.Drawing.Point(399, 354)
        Me.lblRollSumIssuer.Name = "lblRollSumIssuer"
        Me.lblRollSumIssuer.Size = New System.Drawing.Size(140, 13)
        Me.lblRollSumIssuer.TabIndex = 37
        Me.lblRollSumIssuer.Text = "Rolling Contract Sum Issuer:"
        '
        'ucrReceiverValueSumIssuer
        '
        Me.ucrReceiverValueSumIssuer.AutoSize = True
        Me.ucrReceiverValueSumIssuer.frmParent = Me
        Me.ucrReceiverValueSumIssuer.Location = New System.Drawing.Point(399, 369)
        Me.ucrReceiverValueSumIssuer.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverValueSumIssuer.Name = "ucrReceiverValueSumIssuer"
        Me.ucrReceiverValueSumIssuer.Selector = Nothing
        Me.ucrReceiverValueSumIssuer.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverValueSumIssuer.strNcFilePath = ""
        Me.ucrReceiverValueSumIssuer.TabIndex = 38
        Me.ucrReceiverValueSumIssuer.ucrSelector = Nothing
        '
        'ucrReceiverSingleBidder
        '
        Me.ucrReceiverSingleBidder.AutoSize = True
        Me.ucrReceiverSingleBidder.frmParent = Me
        Me.ucrReceiverSingleBidder.Location = New System.Drawing.Point(234, 412)
        Me.ucrReceiverSingleBidder.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleBidder.Name = "ucrReceiverSingleBidder"
        Me.ucrReceiverSingleBidder.Selector = Nothing
        Me.ucrReceiverSingleBidder.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSingleBidder.strNcFilePath = ""
        Me.ucrReceiverSingleBidder.TabIndex = 20
        Me.ucrReceiverSingleBidder.ucrSelector = Nothing
        '
        'lblSingleBidder
        '
        Me.lblSingleBidder.AutoSize = True
        Me.lblSingleBidder.Location = New System.Drawing.Point(234, 397)
        Me.lblSingleBidder.Name = "lblSingleBidder"
        Me.lblSingleBidder.Size = New System.Drawing.Size(72, 13)
        Me.lblSingleBidder.TabIndex = 19
        Me.lblSingleBidder.Text = "Single Bidder:"
        '
        'lblSignaturePeriod5
        '
        Me.lblSignaturePeriod5.AutoSize = True
        Me.lblSignaturePeriod5.Location = New System.Drawing.Point(396, 97)
        Me.lblSignaturePeriod5.Name = "lblSignaturePeriod5"
        Me.lblSignaturePeriod5.Size = New System.Drawing.Size(147, 13)
        Me.lblSignaturePeriod5.TabIndex = 25
        Me.lblSignaturePeriod5.Text = "Signature Period (5 Quartiles):"
        '
        'ucrReceiverPeriod5
        '
        Me.ucrReceiverPeriod5.AutoSize = True
        Me.ucrReceiverPeriod5.frmParent = Me
        Me.ucrReceiverPeriod5.Location = New System.Drawing.Point(399, 112)
        Me.ucrReceiverPeriod5.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPeriod5.Name = "ucrReceiverPeriod5"
        Me.ucrReceiverPeriod5.Selector = Nothing
        Me.ucrReceiverPeriod5.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPeriod5.strNcFilePath = ""
        Me.ucrReceiverPeriod5.TabIndex = 26
        Me.ucrReceiverPeriod5.ucrSelector = Nothing
        '
        'lblSignaturePeriodCorrected
        '
        Me.lblSignaturePeriodCorrected.AutoSize = True
        Me.lblSignaturePeriodCorrected.Location = New System.Drawing.Point(399, 54)
        Me.lblSignaturePeriodCorrected.Name = "lblSignaturePeriodCorrected"
        Me.lblSignaturePeriodCorrected.Size = New System.Drawing.Size(137, 13)
        Me.lblSignaturePeriodCorrected.TabIndex = 23
        Me.lblSignaturePeriodCorrected.Text = "Signature Period Corrected:"
        '
        'lblSignaturePeriodCat
        '
        Me.lblSignaturePeriodCat.AutoSize = True
        Me.lblSignaturePeriodCat.Location = New System.Drawing.Point(399, 183)
        Me.lblSignaturePeriodCat.Name = "lblSignaturePeriodCat"
        Me.lblSignaturePeriodCat.Size = New System.Drawing.Size(141, 13)
        Me.lblSignaturePeriodCat.TabIndex = 29
        Me.lblSignaturePeriodCat.Text = "Signature Period Categories:"
        '
        'ucrReceiverPeriodCat
        '
        Me.ucrReceiverPeriodCat.AutoSize = True
        Me.ucrReceiverPeriodCat.frmParent = Me
        Me.ucrReceiverPeriodCat.Location = New System.Drawing.Point(399, 198)
        Me.ucrReceiverPeriodCat.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPeriodCat.Name = "ucrReceiverPeriodCat"
        Me.ucrReceiverPeriodCat.Selector = Nothing
        Me.ucrReceiverPeriodCat.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPeriodCat.strNcFilePath = ""
        Me.ucrReceiverPeriodCat.TabIndex = 30
        Me.ucrReceiverPeriodCat.ucrSelector = Nothing
        '
        'ucrReceiverSignaturePeriodCorrected
        '
        Me.ucrReceiverSignaturePeriodCorrected.AutoSize = True
        Me.ucrReceiverSignaturePeriodCorrected.frmParent = Me
        Me.ucrReceiverSignaturePeriodCorrected.Location = New System.Drawing.Point(399, 69)
        Me.ucrReceiverSignaturePeriodCorrected.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSignaturePeriodCorrected.Name = "ucrReceiverSignaturePeriodCorrected"
        Me.ucrReceiverSignaturePeriodCorrected.Selector = Nothing
        Me.ucrReceiverSignaturePeriodCorrected.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSignaturePeriodCorrected.strNcFilePath = ""
        Me.ucrReceiverSignaturePeriodCorrected.TabIndex = 24
        Me.ucrReceiverSignaturePeriodCorrected.ucrSelector = Nothing
        '
        'lblSignaturePeriod25
        '
        Me.lblSignaturePeriod25.AutoSize = True
        Me.lblSignaturePeriod25.Location = New System.Drawing.Point(398, 140)
        Me.lblSignaturePeriod25.Name = "lblSignaturePeriod25"
        Me.lblSignaturePeriod25.Size = New System.Drawing.Size(153, 13)
        Me.lblSignaturePeriod25.TabIndex = 27
        Me.lblSignaturePeriod25.Text = "Signature Period (25 Quartiles):"
        '
        'ucrReceiverPeriod25
        '
        Me.ucrReceiverPeriod25.AutoSize = True
        Me.ucrReceiverPeriod25.frmParent = Me
        Me.ucrReceiverPeriod25.Location = New System.Drawing.Point(399, 155)
        Me.ucrReceiverPeriod25.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPeriod25.Name = "ucrReceiverPeriod25"
        Me.ucrReceiverPeriod25.Selector = Nothing
        Me.ucrReceiverPeriod25.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPeriod25.strNcFilePath = ""
        Me.ucrReceiverPeriod25.TabIndex = 28
        Me.ucrReceiverPeriod25.ucrSelector = Nothing
        '
        'ucrReceiverRollingNumberWinner
        '
        Me.ucrReceiverRollingNumberWinner.AutoSize = True
        Me.ucrReceiverRollingNumberWinner.frmParent = Me
        Me.ucrReceiverRollingNumberWinner.Location = New System.Drawing.Point(399, 243)
        Me.ucrReceiverRollingNumberWinner.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRollingNumberWinner.Name = "ucrReceiverRollingNumberWinner"
        Me.ucrReceiverRollingNumberWinner.Selector = Nothing
        Me.ucrReceiverRollingNumberWinner.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRollingNumberWinner.strNcFilePath = ""
        Me.ucrReceiverRollingNumberWinner.TabIndex = 32
        Me.ucrReceiverRollingNumberWinner.ucrSelector = Nothing
        '
        'lblRollNumWinner
        '
        Me.lblRollNumWinner.AutoSize = True
        Me.lblRollNumWinner.Location = New System.Drawing.Point(399, 228)
        Me.lblRollNumWinner.Name = "lblRollNumWinner"
        Me.lblRollNumWinner.Size = New System.Drawing.Size(162, 13)
        Me.lblRollNumWinner.TabIndex = 31
        Me.lblRollNumWinner.Text = "Rolling Contract Number Winner:"
        '
        'lblWinnerCountryISO3
        '
        Me.lblWinnerCountryISO3.AutoSize = True
        Me.lblWinnerCountryISO3.Location = New System.Drawing.Point(567, 268)
        Me.lblWinnerCountryISO3.Name = "lblWinnerCountryISO3"
        Me.lblWinnerCountryISO3.Size = New System.Drawing.Size(110, 13)
        Me.lblWinnerCountryISO3.TabIndex = 53
        Me.lblWinnerCountryISO3.Text = "Winner Country ISO3:"
        '
        'ucrReceiverWinnerCountryISO3
        '
        Me.ucrReceiverWinnerCountryISO3.AutoSize = True
        Me.ucrReceiverWinnerCountryISO3.frmParent = Me
        Me.ucrReceiverWinnerCountryISO3.Location = New System.Drawing.Point(567, 283)
        Me.ucrReceiverWinnerCountryISO3.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWinnerCountryISO3.Name = "ucrReceiverWinnerCountryISO3"
        Me.ucrReceiverWinnerCountryISO3.Selector = Nothing
        Me.ucrReceiverWinnerCountryISO3.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWinnerCountryISO3.strNcFilePath = ""
        Me.ucrReceiverWinnerCountryISO3.TabIndex = 54
        Me.ucrReceiverWinnerCountryISO3.ucrSelector = Nothing
        '
        'lblWinnerCountryISO2
        '
        Me.lblWinnerCountryISO2.AutoSize = True
        Me.lblWinnerCountryISO2.Location = New System.Drawing.Point(567, 225)
        Me.lblWinnerCountryISO2.Name = "lblWinnerCountryISO2"
        Me.lblWinnerCountryISO2.Size = New System.Drawing.Size(110, 13)
        Me.lblWinnerCountryISO2.TabIndex = 51
        Me.lblWinnerCountryISO2.Text = "Winner Country ISO2:"
        '
        'lblWBPPP
        '
        Me.lblWBPPP.AutoSize = True
        Me.lblWBPPP.Location = New System.Drawing.Point(568, 311)
        Me.lblWBPPP.Name = "lblWBPPP"
        Me.lblWBPPP.Size = New System.Drawing.Size(52, 13)
        Me.lblWBPPP.TabIndex = 55
        Me.lblWBPPP.Text = "WB PPP:"
        '
        'ucrReceiverPPPAdjustedContractValue
        '
        Me.ucrReceiverPPPAdjustedContractValue.AutoSize = True
        Me.ucrReceiverPPPAdjustedContractValue.frmParent = Me
        Me.ucrReceiverPPPAdjustedContractValue.Location = New System.Drawing.Point(567, 369)
        Me.ucrReceiverPPPAdjustedContractValue.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPPPAdjustedContractValue.Name = "ucrReceiverPPPAdjustedContractValue"
        Me.ucrReceiverPPPAdjustedContractValue.Selector = Nothing
        Me.ucrReceiverPPPAdjustedContractValue.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPPPAdjustedContractValue.strNcFilePath = ""
        Me.ucrReceiverPPPAdjustedContractValue.TabIndex = 58
        Me.ucrReceiverPPPAdjustedContractValue.ucrSelector = Nothing
        '
        'ucrReceiverWinnerCountryISO2
        '
        Me.ucrReceiverWinnerCountryISO2.AutoSize = True
        Me.ucrReceiverWinnerCountryISO2.frmParent = Me
        Me.ucrReceiverWinnerCountryISO2.Location = New System.Drawing.Point(567, 240)
        Me.ucrReceiverWinnerCountryISO2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWinnerCountryISO2.Name = "ucrReceiverWinnerCountryISO2"
        Me.ucrReceiverWinnerCountryISO2.Selector = Nothing
        Me.ucrReceiverWinnerCountryISO2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWinnerCountryISO2.strNcFilePath = ""
        Me.ucrReceiverWinnerCountryISO2.TabIndex = 52
        Me.ucrReceiverWinnerCountryISO2.ucrSelector = Nothing
        '
        'lblPPPAdjustedContractValue
        '
        Me.lblPPPAdjustedContractValue.AutoSize = True
        Me.lblPPPAdjustedContractValue.Location = New System.Drawing.Point(567, 354)
        Me.lblPPPAdjustedContractValue.Name = "lblPPPAdjustedContractValue"
        Me.lblPPPAdjustedContractValue.Size = New System.Drawing.Size(148, 13)
        Me.lblPPPAdjustedContractValue.TabIndex = 57
        Me.lblPPPAdjustedContractValue.Text = "PPP Adjusted Contract Value:"
        '
        'ucrReceiverWBPPP
        '
        Me.ucrReceiverWBPPP.AutoSize = True
        Me.ucrReceiverWBPPP.frmParent = Me
        Me.ucrReceiverWBPPP.Location = New System.Drawing.Point(567, 326)
        Me.ucrReceiverWBPPP.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWBPPP.Name = "ucrReceiverWBPPP"
        Me.ucrReceiverWBPPP.Selector = Nothing
        Me.ucrReceiverWBPPP.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWBPPP.strNcFilePath = ""
        Me.ucrReceiverWBPPP.TabIndex = 56
        Me.ucrReceiverWBPPP.ucrSelector = Nothing
        '
        'ucrReceiverSecrecyScore
        '
        Me.ucrReceiverSecrecyScore.AutoSize = True
        Me.ucrReceiverSecrecyScore.frmParent = Me
        Me.ucrReceiverSecrecyScore.Location = New System.Drawing.Point(567, 414)
        Me.ucrReceiverSecrecyScore.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecrecyScore.Name = "ucrReceiverSecrecyScore"
        Me.ucrReceiverSecrecyScore.Selector = Nothing
        Me.ucrReceiverSecrecyScore.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSecrecyScore.strNcFilePath = ""
        Me.ucrReceiverSecrecyScore.TabIndex = 60
        Me.ucrReceiverSecrecyScore.ucrSelector = Nothing
        '
        'lblSecrecyScore
        '
        Me.lblSecrecyScore.AutoSize = True
        Me.lblSecrecyScore.Location = New System.Drawing.Point(567, 399)
        Me.lblSecrecyScore.Name = "lblSecrecyScore"
        Me.lblSecrecyScore.Size = New System.Drawing.Size(80, 13)
        Me.lblSecrecyScore.TabIndex = 59
        Me.lblSecrecyScore.Text = "Secrecy Score:"
        '
        'lblCountryISO2
        '
        Me.lblCountryISO2.AutoSize = True
        Me.lblCountryISO2.Location = New System.Drawing.Point(567, 54)
        Me.lblCountryISO2.Name = "lblCountryISO2"
        Me.lblCountryISO2.Size = New System.Drawing.Size(73, 13)
        Me.lblCountryISO2.TabIndex = 43
        Me.lblCountryISO2.Text = "Country ISO2:"
        '
        'ucrReceiverCountryISO2
        '
        Me.ucrReceiverCountryISO2.AutoSize = True
        Me.ucrReceiverCountryISO2.frmParent = Me
        Me.ucrReceiverCountryISO2.Location = New System.Drawing.Point(567, 69)
        Me.ucrReceiverCountryISO2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCountryISO2.Name = "ucrReceiverCountryISO2"
        Me.ucrReceiverCountryISO2.Selector = Nothing
        Me.ucrReceiverCountryISO2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverCountryISO2.strNcFilePath = ""
        Me.ucrReceiverCountryISO2.TabIndex = 44
        Me.ucrReceiverCountryISO2.ucrSelector = Nothing
        '
        'lblContractValueShareOverThreshold
        '
        Me.lblContractValueShareOverThreshold.AutoSize = True
        Me.lblContractValueShareOverThreshold.Location = New System.Drawing.Point(567, 11)
        Me.lblContractValueShareOverThreshold.Name = "lblContractValueShareOverThreshold"
        Me.lblContractValueShareOverThreshold.Size = New System.Drawing.Size(161, 13)
        Me.lblContractValueShareOverThreshold.TabIndex = 41
        Me.lblContractValueShareOverThreshold.Text = "Contract Value Share Threshold:"
        '
        'lblAddBids
        '
        Me.lblAddBids.AutoSize = True
        Me.lblAddBids.Location = New System.Drawing.Point(567, 140)
        Me.lblAddBids.Name = "lblAddBids"
        Me.lblAddBids.Size = New System.Drawing.Size(44, 13)
        Me.lblAddBids.TabIndex = 47
        Me.lblAddBids.Text = "All Bids:"
        '
        'ucrReceiverAllBids
        '
        Me.ucrReceiverAllBids.AutoSize = True
        Me.ucrReceiverAllBids.frmParent = Me
        Me.ucrReceiverAllBids.Location = New System.Drawing.Point(567, 155)
        Me.ucrReceiverAllBids.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAllBids.Name = "ucrReceiverAllBids"
        Me.ucrReceiverAllBids.Selector = Nothing
        Me.ucrReceiverAllBids.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverAllBids.strNcFilePath = ""
        Me.ucrReceiverAllBids.TabIndex = 48
        Me.ucrReceiverAllBids.ucrSelector = Nothing
        '
        'ucrReceiverContractShareThreshold
        '
        Me.ucrReceiverContractShareThreshold.AutoSize = True
        Me.ucrReceiverContractShareThreshold.frmParent = Me
        Me.ucrReceiverContractShareThreshold.Location = New System.Drawing.Point(567, 26)
        Me.ucrReceiverContractShareThreshold.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContractShareThreshold.Name = "ucrReceiverContractShareThreshold"
        Me.ucrReceiverContractShareThreshold.Selector = Nothing
        Me.ucrReceiverContractShareThreshold.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverContractShareThreshold.strNcFilePath = ""
        Me.ucrReceiverContractShareThreshold.TabIndex = 42
        Me.ucrReceiverContractShareThreshold.ucrSelector = Nothing
        '
        'lblCountryISO3
        '
        Me.lblCountryISO3.AutoSize = True
        Me.lblCountryISO3.Location = New System.Drawing.Point(567, 97)
        Me.lblCountryISO3.Name = "lblCountryISO3"
        Me.lblCountryISO3.Size = New System.Drawing.Size(73, 13)
        Me.lblCountryISO3.TabIndex = 45
        Me.lblCountryISO3.Text = "Country ISO3:"
        '
        'ucrReceiverCountryISO3
        '
        Me.ucrReceiverCountryISO3.AutoSize = True
        Me.ucrReceiverCountryISO3.frmParent = Me
        Me.ucrReceiverCountryISO3.Location = New System.Drawing.Point(567, 112)
        Me.ucrReceiverCountryISO3.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCountryISO3.Name = "ucrReceiverCountryISO3"
        Me.ucrReceiverCountryISO3.Selector = Nothing
        Me.ucrReceiverCountryISO3.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverCountryISO3.strNcFilePath = ""
        Me.ucrReceiverCountryISO3.TabIndex = 46
        Me.ucrReceiverCountryISO3.ucrSelector = Nothing
        '
        'ucrReceiverAllBidsTrimmed
        '
        Me.ucrReceiverAllBidsTrimmed.AutoSize = True
        Me.ucrReceiverAllBidsTrimmed.frmParent = Me
        Me.ucrReceiverAllBidsTrimmed.Location = New System.Drawing.Point(567, 200)
        Me.ucrReceiverAllBidsTrimmed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAllBidsTrimmed.Name = "ucrReceiverAllBidsTrimmed"
        Me.ucrReceiverAllBidsTrimmed.Selector = Nothing
        Me.ucrReceiverAllBidsTrimmed.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverAllBidsTrimmed.strNcFilePath = ""
        Me.ucrReceiverAllBidsTrimmed.TabIndex = 50
        Me.ucrReceiverAllBidsTrimmed.ucrSelector = Nothing
        '
        'lblAllBidsTrimmed
        '
        Me.lblAllBidsTrimmed.AutoSize = True
        Me.lblAllBidsTrimmed.Location = New System.Drawing.Point(567, 185)
        Me.lblAllBidsTrimmed.Name = "lblAllBidsTrimmed"
        Me.lblAllBidsTrimmed.Size = New System.Drawing.Size(93, 13)
        Me.lblAllBidsTrimmed.TabIndex = 49
        Me.lblAllBidsTrimmed.Text = "All Bids (Trimmed):"
        '
        'lblTaxHaven2
        '
        Me.lblTaxHaven2.AutoSize = True
        Me.lblTaxHaven2.Location = New System.Drawing.Point(731, 54)
        Me.lblTaxHaven2.Name = "lblTaxHaven2"
        Me.lblTaxHaven2.Size = New System.Drawing.Size(72, 13)
        Me.lblTaxHaven2.TabIndex = 63
        Me.lblTaxHaven2.Text = "Tax Haven 2:"
        '
        'ucrReceiverTaxHaven2
        '
        Me.ucrReceiverTaxHaven2.AutoSize = True
        Me.ucrReceiverTaxHaven2.frmParent = Me
        Me.ucrReceiverTaxHaven2.Location = New System.Drawing.Point(731, 69)
        Me.ucrReceiverTaxHaven2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTaxHaven2.Name = "ucrReceiverTaxHaven2"
        Me.ucrReceiverTaxHaven2.Selector = Nothing
        Me.ucrReceiverTaxHaven2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTaxHaven2.strNcFilePath = ""
        Me.ucrReceiverTaxHaven2.TabIndex = 64
        Me.ucrReceiverTaxHaven2.ucrSelector = Nothing
        '
        'lblTaxHaven
        '
        Me.lblTaxHaven.AutoSize = True
        Me.lblTaxHaven.Location = New System.Drawing.Point(731, 11)
        Me.lblTaxHaven.Name = "lblTaxHaven"
        Me.lblTaxHaven.Size = New System.Drawing.Size(63, 13)
        Me.lblTaxHaven.TabIndex = 61
        Me.lblTaxHaven.Text = "Tax Haven:"
        '
        'lblTaxHaven3bi
        '
        Me.lblTaxHaven3bi.AutoSize = True
        Me.lblTaxHaven3bi.Location = New System.Drawing.Point(731, 140)
        Me.lblTaxHaven3bi.Name = "lblTaxHaven3bi"
        Me.lblTaxHaven3bi.Size = New System.Drawing.Size(80, 13)
        Me.lblTaxHaven3bi.TabIndex = 67
        Me.lblTaxHaven3bi.Text = "Tax Haven 3bi:"
        '
        'ucrReceiverTaxHaven3bi
        '
        Me.ucrReceiverTaxHaven3bi.AutoSize = True
        Me.ucrReceiverTaxHaven3bi.frmParent = Me
        Me.ucrReceiverTaxHaven3bi.Location = New System.Drawing.Point(731, 155)
        Me.ucrReceiverTaxHaven3bi.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTaxHaven3bi.Name = "ucrReceiverTaxHaven3bi"
        Me.ucrReceiverTaxHaven3bi.Selector = Nothing
        Me.ucrReceiverTaxHaven3bi.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTaxHaven3bi.strNcFilePath = ""
        Me.ucrReceiverTaxHaven3bi.TabIndex = 68
        Me.ucrReceiverTaxHaven3bi.ucrSelector = Nothing
        '
        'ucrReceiverTaxHaven
        '
        Me.ucrReceiverTaxHaven.AutoSize = True
        Me.ucrReceiverTaxHaven.frmParent = Me
        Me.ucrReceiverTaxHaven.Location = New System.Drawing.Point(731, 26)
        Me.ucrReceiverTaxHaven.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTaxHaven.Name = "ucrReceiverTaxHaven"
        Me.ucrReceiverTaxHaven.Selector = Nothing
        Me.ucrReceiverTaxHaven.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTaxHaven.strNcFilePath = ""
        Me.ucrReceiverTaxHaven.TabIndex = 62
        Me.ucrReceiverTaxHaven.ucrSelector = Nothing
        '
        'lblTaxHaven3
        '
        Me.lblTaxHaven3.AutoSize = True
        Me.lblTaxHaven3.Location = New System.Drawing.Point(731, 97)
        Me.lblTaxHaven3.Name = "lblTaxHaven3"
        Me.lblTaxHaven3.Size = New System.Drawing.Size(72, 13)
        Me.lblTaxHaven3.TabIndex = 65
        Me.lblTaxHaven3.Text = "Tax Haven 3:"
        '
        'ucrReceiverTaxHaven3
        '
        Me.ucrReceiverTaxHaven3.AutoSize = True
        Me.ucrReceiverTaxHaven3.frmParent = Me
        Me.ucrReceiverTaxHaven3.Location = New System.Drawing.Point(731, 112)
        Me.ucrReceiverTaxHaven3.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTaxHaven3.Name = "ucrReceiverTaxHaven3"
        Me.ucrReceiverTaxHaven3.Selector = Nothing
        Me.ucrReceiverTaxHaven3.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTaxHaven3.strNcFilePath = ""
        Me.ucrReceiverTaxHaven3.TabIndex = 66
        Me.ucrReceiverTaxHaven3.ucrSelector = Nothing
        '
        'sdgCorruptionCalculatedColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(860, 495)
        Me.Controls.Add(Me.lblTaxHaven2)
        Me.Controls.Add(Me.ucrReceiverTaxHaven2)
        Me.Controls.Add(Me.lblTaxHaven)
        Me.Controls.Add(Me.lblTaxHaven3bi)
        Me.Controls.Add(Me.ucrReceiverTaxHaven3bi)
        Me.Controls.Add(Me.ucrReceiverTaxHaven)
        Me.Controls.Add(Me.lblTaxHaven3)
        Me.Controls.Add(Me.ucrReceiverTaxHaven3)
        Me.Controls.Add(Me.lblWinnerCountryISO3)
        Me.Controls.Add(Me.ucrReceiverWinnerCountryISO3)
        Me.Controls.Add(Me.lblWinnerCountryISO2)
        Me.Controls.Add(Me.lblWBPPP)
        Me.Controls.Add(Me.ucrReceiverPPPAdjustedContractValue)
        Me.Controls.Add(Me.ucrReceiverWinnerCountryISO2)
        Me.Controls.Add(Me.lblPPPAdjustedContractValue)
        Me.Controls.Add(Me.ucrReceiverWBPPP)
        Me.Controls.Add(Me.ucrReceiverSecrecyScore)
        Me.Controls.Add(Me.lblSecrecyScore)
        Me.Controls.Add(Me.lblCountryISO2)
        Me.Controls.Add(Me.ucrReceiverCountryISO2)
        Me.Controls.Add(Me.lblContractValueShareOverThreshold)
        Me.Controls.Add(Me.lblAddBids)
        Me.Controls.Add(Me.ucrReceiverAllBids)
        Me.Controls.Add(Me.ucrReceiverContractShareThreshold)
        Me.Controls.Add(Me.lblCountryISO3)
        Me.Controls.Add(Me.ucrReceiverCountryISO3)
        Me.Controls.Add(Me.ucrReceiverAllBidsTrimmed)
        Me.Controls.Add(Me.lblAllBidsTrimmed)
        Me.Controls.Add(Me.lblRollSumWinner)
        Me.Controls.Add(Me.ucrReceiverValueSumWinner)
        Me.Controls.Add(Me.lblRollNumIssuer)
        Me.Controls.Add(Me.lblRollShareWinner)
        Me.Controls.Add(Me.ucrReceiverValueShareWinner)
        Me.Controls.Add(Me.ucrReceiverRollingNumberIssuer)
        Me.Controls.Add(Me.lblRollSumIssuer)
        Me.Controls.Add(Me.ucrReceiverValueSumIssuer)
        Me.Controls.Add(Me.ucrReceiverSingleBidder)
        Me.Controls.Add(Me.lblSingleBidder)
        Me.Controls.Add(Me.lblSignaturePeriod5)
        Me.Controls.Add(Me.ucrReceiverPeriod5)
        Me.Controls.Add(Me.lblSignaturePeriodCorrected)
        Me.Controls.Add(Me.lblSignaturePeriodCat)
        Me.Controls.Add(Me.ucrReceiverPeriodCat)
        Me.Controls.Add(Me.ucrReceiverSignaturePeriodCorrected)
        Me.Controls.Add(Me.lblSignaturePeriod25)
        Me.Controls.Add(Me.ucrReceiverPeriod25)
        Me.Controls.Add(Me.ucrReceiverRollingNumberWinner)
        Me.Controls.Add(Me.lblRollNumWinner)
        Me.Controls.Add(Me.lblProcurementTypeCat)
        Me.Controls.Add(Me.ucrReceiverProcurementTypeCat)
        Me.Controls.Add(Me.lblContractValueCategories)
        Me.Controls.Add(Me.lblProcurementType3)
        Me.Controls.Add(Me.ucrReceiverProcurementType3)
        Me.Controls.Add(Me.ucrReceiverContractValueCategories)
        Me.Controls.Add(Me.lblProcurementType2)
        Me.Controls.Add(Me.ucrReceiverProcurementType2)
        Me.Controls.Add(Me.ucrReceiverSignaturePeriod)
        Me.Controls.Add(Me.lblSignaturePeriod)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblProcedureType)
        Me.Controls.Add(Me.ucrReceiverProcedureType)
        Me.Controls.Add(Me.lblAwardYear)
        Me.Controls.Add(Me.lblWinnerID)
        Me.Controls.Add(Me.ucrReceiverWinnerID)
        Me.Controls.Add(Me.ucrReceiverAwardYear)
        Me.Controls.Add(Me.lblProcuringAuthority)
        Me.Controls.Add(Me.ucrReceiverProcuringAuthority)
        Me.Controls.Add(Me.ucrReceiverForeignWinner)
        Me.Controls.Add(Me.lblForeignWinner)
        Me.Controls.Add(Me.ucrCalculatedColumnsSelector)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCorruptionCalculatedColumns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Calculated Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrCalculatedColumnsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents lblProcedureType As Label
    Friend WithEvents ucrReceiverProcedureType As ucrReceiverSingle
    Friend WithEvents lblTaxHaven2 As Label
    Friend WithEvents ucrReceiverTaxHaven2 As ucrReceiverSingle
    Friend WithEvents lblTaxHaven As Label
    Friend WithEvents lblTaxHaven3bi As Label
    Friend WithEvents ucrReceiverTaxHaven3bi As ucrReceiverSingle
    Friend WithEvents ucrReceiverTaxHaven As ucrReceiverSingle
    Friend WithEvents lblTaxHaven3 As Label
    Friend WithEvents lblWinnerCountryISO3 As Label
    Friend WithEvents ucrReceiverWinnerCountryISO3 As ucrReceiverSingle
    Friend WithEvents lblWinnerCountryISO2 As Label
    Friend WithEvents lblWBPPP As Label
    Friend WithEvents ucrReceiverPPPAdjustedContractValue As ucrReceiverSingle
    Friend WithEvents ucrReceiverWinnerCountryISO2 As ucrReceiverSingle
    Friend WithEvents lblPPPAdjustedContractValue As Label
    Friend WithEvents ucrReceiverWBPPP As ucrReceiverSingle
    Friend WithEvents ucrReceiverSecrecyScore As ucrReceiverSingle
    Friend WithEvents lblSecrecyScore As Label
    Friend WithEvents lblCountryISO2 As Label
    Friend WithEvents ucrReceiverCountryISO2 As ucrReceiverSingle
    Friend WithEvents lblContractValueShareOverThreshold As Label
    Friend WithEvents lblAddBids As Label
    Friend WithEvents ucrReceiverAllBids As ucrReceiverSingle
    Friend WithEvents ucrReceiverContractShareThreshold As ucrReceiverSingle
    Friend WithEvents lblCountryISO3 As Label
    Friend WithEvents ucrReceiverCountryISO3 As ucrReceiverSingle
    Friend WithEvents ucrReceiverAllBidsTrimmed As ucrReceiverSingle
    Friend WithEvents lblAllBidsTrimmed As Label
    Friend WithEvents lblRollSumWinner As Label
    Friend WithEvents ucrReceiverValueSumWinner As ucrReceiverSingle
    Friend WithEvents lblRollNumIssuer As Label
    Friend WithEvents lblRollShareWinner As Label
    Friend WithEvents ucrReceiverValueShareWinner As ucrReceiverSingle
    Friend WithEvents ucrReceiverRollingNumberIssuer As ucrReceiverSingle
    Friend WithEvents lblRollSumIssuer As Label
    Friend WithEvents ucrReceiverValueSumIssuer As ucrReceiverSingle
    Friend WithEvents ucrReceiverSingleBidder As ucrReceiverSingle
    Friend WithEvents lblSingleBidder As Label
    Friend WithEvents lblSignaturePeriod5 As Label
    Friend WithEvents ucrReceiverPeriod5 As ucrReceiverSingle
    Friend WithEvents lblSignaturePeriodCorrected As Label
    Friend WithEvents lblSignaturePeriodCat As Label
    Friend WithEvents ucrReceiverPeriodCat As ucrReceiverSingle
    Friend WithEvents ucrReceiverSignaturePeriodCorrected As ucrReceiverSingle
    Friend WithEvents lblSignaturePeriod25 As Label
    Friend WithEvents ucrReceiverPeriod25 As ucrReceiverSingle
    Friend WithEvents ucrReceiverRollingNumberWinner As ucrReceiverSingle
    Friend WithEvents lblRollNumWinner As Label
    Friend WithEvents lblProcurementTypeCat As Label
    Friend WithEvents ucrReceiverProcurementTypeCat As ucrReceiverSingle
    Friend WithEvents lblContractValueCategories As Label
    Friend WithEvents lblProcurementType3 As Label
    Friend WithEvents ucrReceiverProcurementType3 As ucrReceiverSingle
    Friend WithEvents ucrReceiverContractValueCategories As ucrReceiverSingle
    Friend WithEvents lblProcurementType2 As Label
    Friend WithEvents ucrReceiverProcurementType2 As ucrReceiverSingle
    Friend WithEvents ucrReceiverSignaturePeriod As ucrReceiverSingle
    Friend WithEvents lblSignaturePeriod As Label
    Friend WithEvents lblAwardYear As Label
    Friend WithEvents lblWinnerID As Label
    Friend WithEvents ucrReceiverWinnerID As ucrReceiverSingle
    Friend WithEvents ucrReceiverAwardYear As ucrReceiverSingle
    Friend WithEvents lblProcuringAuthority As Label
    Friend WithEvents ucrReceiverProcuringAuthority As ucrReceiverSingle
    Friend WithEvents ucrReceiverForeignWinner As ucrReceiverSingle
    Friend WithEvents lblForeignWinner As Label
    Friend WithEvents ucrReceiverTaxHaven3 As ucrReceiverSingle
End Class
