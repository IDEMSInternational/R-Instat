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
        Me.lblNoBidsReceived = New System.Windows.Forms.Label()
        Me.ucrReceiverNoBids = New instat.ucrReceiverSingle()
        Me.ucrReceiverProcedureType = New instat.ucrReceiverSingle()
        Me.lblProcedureType = New System.Windows.Forms.Label()
        Me.ucrReceiverContractValue = New instat.ucrReceiverSingle()
        Me.lblContractValue = New System.Windows.Forms.Label()
        Me.ucrReceiverNoConsideredBids = New instat.ucrReceiverSingle()
        Me.ucrReceiverWinnerCountry = New instat.ucrReceiverSingle()
        Me.lblNoConsideredBids = New System.Windows.Forms.Label()
        Me.lblWinnerCountry = New System.Windows.Forms.Label()
        Me.ucrReceiverProcuringAuthority = New instat.ucrReceiverSingle()
        Me.lblProcuringAuthority = New System.Windows.Forms.Label()
        Me.ucrReceiverCountry = New instat.ucrReceiverSingle()
        Me.ucrReceiverSignatureDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverContractSector = New instat.ucrReceiverSingle()
        Me.ucrReceiverProcurementCategory = New instat.ucrReceiverSingle()
        Me.ucrReceiverWinnerName = New instat.ucrReceiverSingle()
        Me.lblWinnerName = New System.Windows.Forms.Label()
        Me.lblContractSector = New System.Windows.Forms.Label()
        Me.lblProcurementCategory = New System.Windows.Forms.Label()
        Me.lblContractTitle = New System.Windows.Forms.Label()
        Me.ucrReceiverAwardDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverContractTitle = New instat.ucrReceiverSingle()
        Me.lblAwardDate = New System.Windows.Forms.Label()
        Me.lblSignatureDate = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblFiscalYear = New System.Windows.Forms.Label()
        Me.ucrReceiverFiscalYear = New instat.ucrReceiverSingle()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.ucrReceiverRegion = New instat.ucrReceiverSingle()
        Me.ucrChkAutoGenerate = New instat.ucrCheck()
        Me.cmdCountryLevel = New System.Windows.Forms.Button()
        Me.cmdCalculatedColumns = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrDefineCorruptionSelector
        '
        Me.ucrDefineCorruptionSelector.AutoSize = True
        Me.ucrDefineCorruptionSelector.bDropUnusedFilterLevels = False
        Me.ucrDefineCorruptionSelector.bShowHiddenColumns = False
        Me.ucrDefineCorruptionSelector.bUseCurrentFilter = True
        Me.ucrDefineCorruptionSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrDefineCorruptionSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDefineCorruptionSelector.Name = "ucrDefineCorruptionSelector"
        Me.ucrDefineCorruptionSelector.Size = New System.Drawing.Size(213, 183)
        Me.ucrDefineCorruptionSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 377)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 34
        '
        'lblNoBidsReceived
        '
        Me.lblNoBidsReceived.AutoSize = True
        Me.lblNoBidsReceived.Location = New System.Drawing.Point(414, 27)
        Me.lblNoBidsReceived.Name = "lblNoBidsReceived"
        Me.lblNoBidsReceived.Size = New System.Drawing.Size(99, 13)
        Me.lblNoBidsReceived.TabIndex = 17
        Me.lblNoBidsReceived.Text = "No. Bids Received:"
        '
        'ucrReceiverNoBids
        '
        Me.ucrReceiverNoBids.AutoSize = True
        Me.ucrReceiverNoBids.frmParent = Me
        Me.ucrReceiverNoBids.Location = New System.Drawing.Point(414, 42)
        Me.ucrReceiverNoBids.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverNoBids.Name = "ucrReceiverNoBids"
        Me.ucrReceiverNoBids.Selector = Nothing
        Me.ucrReceiverNoBids.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverNoBids.strNcFilePath = ""
        Me.ucrReceiverNoBids.TabIndex = 18
        Me.ucrReceiverNoBids.ucrSelector = Nothing
        '
        'ucrReceiverProcedureType
        '
        Me.ucrReceiverProcedureType.AutoSize = True
        Me.ucrReceiverProcedureType.frmParent = Me
        Me.ucrReceiverProcedureType.Location = New System.Drawing.Point(414, 128)
        Me.ucrReceiverProcedureType.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverProcedureType.Name = "ucrReceiverProcedureType"
        Me.ucrReceiverProcedureType.Selector = Nothing
        Me.ucrReceiverProcedureType.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverProcedureType.strNcFilePath = ""
        Me.ucrReceiverProcedureType.TabIndex = 22
        Me.ucrReceiverProcedureType.ucrSelector = Nothing
        '
        'lblProcedureType
        '
        Me.lblProcedureType.AutoSize = True
        Me.lblProcedureType.Location = New System.Drawing.Point(414, 113)
        Me.lblProcedureType.Name = "lblProcedureType"
        Me.lblProcedureType.Size = New System.Drawing.Size(86, 13)
        Me.lblProcedureType.TabIndex = 21
        Me.lblProcedureType.Text = "Procedure Type:"
        '
        'ucrReceiverContractValue
        '
        Me.ucrReceiverContractValue.AutoSize = True
        Me.ucrReceiverContractValue.frmParent = Me
        Me.ucrReceiverContractValue.Location = New System.Drawing.Point(414, 257)
        Me.ucrReceiverContractValue.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContractValue.Name = "ucrReceiverContractValue"
        Me.ucrReceiverContractValue.Selector = Nothing
        Me.ucrReceiverContractValue.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverContractValue.strNcFilePath = ""
        Me.ucrReceiverContractValue.TabIndex = 28
        Me.ucrReceiverContractValue.ucrSelector = Nothing
        '
        'lblContractValue
        '
        Me.lblContractValue.AutoSize = True
        Me.lblContractValue.Location = New System.Drawing.Point(414, 242)
        Me.lblContractValue.Name = "lblContractValue"
        Me.lblContractValue.Size = New System.Drawing.Size(80, 13)
        Me.lblContractValue.TabIndex = 27
        Me.lblContractValue.Text = "Contract Value:"
        '
        'ucrReceiverNoConsideredBids
        '
        Me.ucrReceiverNoConsideredBids.AutoSize = True
        Me.ucrReceiverNoConsideredBids.frmParent = Me
        Me.ucrReceiverNoConsideredBids.Location = New System.Drawing.Point(414, 85)
        Me.ucrReceiverNoConsideredBids.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverNoConsideredBids.Name = "ucrReceiverNoConsideredBids"
        Me.ucrReceiverNoConsideredBids.Selector = Nothing
        Me.ucrReceiverNoConsideredBids.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverNoConsideredBids.strNcFilePath = ""
        Me.ucrReceiverNoConsideredBids.TabIndex = 20
        Me.ucrReceiverNoConsideredBids.ucrSelector = Nothing
        '
        'ucrReceiverWinnerCountry
        '
        Me.ucrReceiverWinnerCountry.AutoSize = True
        Me.ucrReceiverWinnerCountry.frmParent = Me
        Me.ucrReceiverWinnerCountry.Location = New System.Drawing.Point(414, 214)
        Me.ucrReceiverWinnerCountry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWinnerCountry.Name = "ucrReceiverWinnerCountry"
        Me.ucrReceiverWinnerCountry.Selector = Nothing
        Me.ucrReceiverWinnerCountry.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWinnerCountry.strNcFilePath = ""
        Me.ucrReceiverWinnerCountry.TabIndex = 26
        Me.ucrReceiverWinnerCountry.ucrSelector = Nothing
        '
        'lblNoConsideredBids
        '
        Me.lblNoConsideredBids.AutoSize = True
        Me.lblNoConsideredBids.Location = New System.Drawing.Point(414, 70)
        Me.lblNoConsideredBids.Name = "lblNoConsideredBids"
        Me.lblNoConsideredBids.Size = New System.Drawing.Size(106, 13)
        Me.lblNoConsideredBids.TabIndex = 19
        Me.lblNoConsideredBids.Text = "No. Considered Bids:"
        '
        'lblWinnerCountry
        '
        Me.lblWinnerCountry.AutoSize = True
        Me.lblWinnerCountry.Location = New System.Drawing.Point(414, 199)
        Me.lblWinnerCountry.Name = "lblWinnerCountry"
        Me.lblWinnerCountry.Size = New System.Drawing.Size(83, 13)
        Me.lblWinnerCountry.TabIndex = 25
        Me.lblWinnerCountry.Text = "Winner Country:"
        '
        'ucrReceiverProcuringAuthority
        '
        Me.ucrReceiverProcuringAuthority.AutoSize = True
        Me.ucrReceiverProcuringAuthority.frmParent = Me
        Me.ucrReceiverProcuringAuthority.Location = New System.Drawing.Point(251, 128)
        Me.ucrReceiverProcuringAuthority.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverProcuringAuthority.Name = "ucrReceiverProcuringAuthority"
        Me.ucrReceiverProcuringAuthority.Selector = Nothing
        Me.ucrReceiverProcuringAuthority.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverProcuringAuthority.strNcFilePath = ""
        Me.ucrReceiverProcuringAuthority.TabIndex = 6
        Me.ucrReceiverProcuringAuthority.ucrSelector = Nothing
        '
        'lblProcuringAuthority
        '
        Me.lblProcuringAuthority.AutoSize = True
        Me.lblProcuringAuthority.Location = New System.Drawing.Point(251, 113)
        Me.lblProcuringAuthority.Name = "lblProcuringAuthority"
        Me.lblProcuringAuthority.Size = New System.Drawing.Size(99, 13)
        Me.lblProcuringAuthority.TabIndex = 5
        Me.lblProcuringAuthority.Text = "Procuring Authority:"
        '
        'ucrReceiverCountry
        '
        Me.ucrReceiverCountry.AutoSize = True
        Me.ucrReceiverCountry.frmParent = Me
        Me.ucrReceiverCountry.Location = New System.Drawing.Point(251, 42)
        Me.ucrReceiverCountry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCountry.Name = "ucrReceiverCountry"
        Me.ucrReceiverCountry.Selector = Nothing
        Me.ucrReceiverCountry.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverCountry.strNcFilePath = ""
        Me.ucrReceiverCountry.TabIndex = 2
        Me.ucrReceiverCountry.ucrSelector = Nothing
        '
        'ucrReceiverSignatureDate
        '
        Me.ucrReceiverSignatureDate.AutoSize = True
        Me.ucrReceiverSignatureDate.frmParent = Me
        Me.ucrReceiverSignatureDate.Location = New System.Drawing.Point(251, 214)
        Me.ucrReceiverSignatureDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSignatureDate.Name = "ucrReceiverSignatureDate"
        Me.ucrReceiverSignatureDate.Selector = Nothing
        Me.ucrReceiverSignatureDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSignatureDate.strNcFilePath = ""
        Me.ucrReceiverSignatureDate.TabIndex = 10
        Me.ucrReceiverSignatureDate.ucrSelector = Nothing
        '
        'ucrReceiverContractSector
        '
        Me.ucrReceiverContractSector.AutoSize = True
        Me.ucrReceiverContractSector.frmParent = Me
        Me.ucrReceiverContractSector.Location = New System.Drawing.Point(251, 300)
        Me.ucrReceiverContractSector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContractSector.Name = "ucrReceiverContractSector"
        Me.ucrReceiverContractSector.Selector = Nothing
        Me.ucrReceiverContractSector.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverContractSector.strNcFilePath = ""
        Me.ucrReceiverContractSector.TabIndex = 14
        Me.ucrReceiverContractSector.ucrSelector = Nothing
        '
        'ucrReceiverProcurementCategory
        '
        Me.ucrReceiverProcurementCategory.AutoSize = True
        Me.ucrReceiverProcurementCategory.frmParent = Me
        Me.ucrReceiverProcurementCategory.Location = New System.Drawing.Point(251, 346)
        Me.ucrReceiverProcurementCategory.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverProcurementCategory.Name = "ucrReceiverProcurementCategory"
        Me.ucrReceiverProcurementCategory.Selector = Nothing
        Me.ucrReceiverProcurementCategory.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverProcurementCategory.strNcFilePath = ""
        Me.ucrReceiverProcurementCategory.TabIndex = 16
        Me.ucrReceiverProcurementCategory.ucrSelector = Nothing
        '
        'ucrReceiverWinnerName
        '
        Me.ucrReceiverWinnerName.AutoSize = True
        Me.ucrReceiverWinnerName.frmParent = Me
        Me.ucrReceiverWinnerName.Location = New System.Drawing.Point(414, 171)
        Me.ucrReceiverWinnerName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWinnerName.Name = "ucrReceiverWinnerName"
        Me.ucrReceiverWinnerName.Selector = Nothing
        Me.ucrReceiverWinnerName.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWinnerName.strNcFilePath = ""
        Me.ucrReceiverWinnerName.TabIndex = 24
        Me.ucrReceiverWinnerName.ucrSelector = Nothing
        '
        'lblWinnerName
        '
        Me.lblWinnerName.AutoSize = True
        Me.lblWinnerName.Location = New System.Drawing.Point(414, 156)
        Me.lblWinnerName.Name = "lblWinnerName"
        Me.lblWinnerName.Size = New System.Drawing.Size(75, 13)
        Me.lblWinnerName.TabIndex = 23
        Me.lblWinnerName.Text = "Winner Name:"
        '
        'lblContractSector
        '
        Me.lblContractSector.AutoSize = True
        Me.lblContractSector.Location = New System.Drawing.Point(251, 285)
        Me.lblContractSector.Name = "lblContractSector"
        Me.lblContractSector.Size = New System.Drawing.Size(84, 13)
        Me.lblContractSector.TabIndex = 13
        Me.lblContractSector.Text = "Contract Sector:"
        '
        'lblProcurementCategory
        '
        Me.lblProcurementCategory.AutoSize = True
        Me.lblProcurementCategory.Location = New System.Drawing.Point(251, 331)
        Me.lblProcurementCategory.Name = "lblProcurementCategory"
        Me.lblProcurementCategory.Size = New System.Drawing.Size(115, 13)
        Me.lblProcurementCategory.TabIndex = 15
        Me.lblProcurementCategory.Text = "Procurement Category:"
        '
        'lblContractTitle
        '
        Me.lblContractTitle.AutoSize = True
        Me.lblContractTitle.Location = New System.Drawing.Point(251, 242)
        Me.lblContractTitle.Name = "lblContractTitle"
        Me.lblContractTitle.Size = New System.Drawing.Size(73, 13)
        Me.lblContractTitle.TabIndex = 11
        Me.lblContractTitle.Text = "Contract Title:"
        '
        'ucrReceiverAwardDate
        '
        Me.ucrReceiverAwardDate.AutoSize = True
        Me.ucrReceiverAwardDate.frmParent = Me
        Me.ucrReceiverAwardDate.Location = New System.Drawing.Point(251, 171)
        Me.ucrReceiverAwardDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAwardDate.Name = "ucrReceiverAwardDate"
        Me.ucrReceiverAwardDate.Selector = Nothing
        Me.ucrReceiverAwardDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverAwardDate.strNcFilePath = ""
        Me.ucrReceiverAwardDate.TabIndex = 8
        Me.ucrReceiverAwardDate.ucrSelector = Nothing
        '
        'ucrReceiverContractTitle
        '
        Me.ucrReceiverContractTitle.AutoSize = True
        Me.ucrReceiverContractTitle.frmParent = Me
        Me.ucrReceiverContractTitle.Location = New System.Drawing.Point(251, 257)
        Me.ucrReceiverContractTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContractTitle.Name = "ucrReceiverContractTitle"
        Me.ucrReceiverContractTitle.Selector = Nothing
        Me.ucrReceiverContractTitle.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverContractTitle.strNcFilePath = ""
        Me.ucrReceiverContractTitle.TabIndex = 12
        Me.ucrReceiverContractTitle.ucrSelector = Nothing
        '
        'lblAwardDate
        '
        Me.lblAwardDate.AutoSize = True
        Me.lblAwardDate.Location = New System.Drawing.Point(251, 156)
        Me.lblAwardDate.Name = "lblAwardDate"
        Me.lblAwardDate.Size = New System.Drawing.Size(66, 13)
        Me.lblAwardDate.TabIndex = 7
        Me.lblAwardDate.Text = "Award Date:"
        '
        'lblSignatureDate
        '
        Me.lblSignatureDate.AutoSize = True
        Me.lblSignatureDate.Location = New System.Drawing.Point(251, 199)
        Me.lblSignatureDate.Name = "lblSignatureDate"
        Me.lblSignatureDate.Size = New System.Drawing.Size(81, 13)
        Me.lblSignatureDate.TabIndex = 9
        Me.lblSignatureDate.Text = "Signature Date:"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(251, 27)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(46, 13)
        Me.lblCountry.TabIndex = 1
        Me.lblCountry.Text = "Country:"
        '
        'lblFiscalYear
        '
        Me.lblFiscalYear.AutoSize = True
        Me.lblFiscalYear.Location = New System.Drawing.Point(414, 285)
        Me.lblFiscalYear.Name = "lblFiscalYear"
        Me.lblFiscalYear.Size = New System.Drawing.Size(62, 13)
        Me.lblFiscalYear.TabIndex = 29
        Me.lblFiscalYear.Text = "Fiscal Year:"
        '
        'ucrReceiverFiscalYear
        '
        Me.ucrReceiverFiscalYear.AutoSize = True
        Me.ucrReceiverFiscalYear.frmParent = Me
        Me.ucrReceiverFiscalYear.Location = New System.Drawing.Point(414, 300)
        Me.ucrReceiverFiscalYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFiscalYear.Name = "ucrReceiverFiscalYear"
        Me.ucrReceiverFiscalYear.Selector = Nothing
        Me.ucrReceiverFiscalYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFiscalYear.strNcFilePath = ""
        Me.ucrReceiverFiscalYear.TabIndex = 30
        Me.ucrReceiverFiscalYear.ucrSelector = Nothing
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Location = New System.Drawing.Point(251, 70)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(44, 13)
        Me.lblRegion.TabIndex = 3
        Me.lblRegion.Text = "Region:"
        '
        'ucrReceiverRegion
        '
        Me.ucrReceiverRegion.AutoSize = True
        Me.ucrReceiverRegion.frmParent = Me
        Me.ucrReceiverRegion.Location = New System.Drawing.Point(251, 85)
        Me.ucrReceiverRegion.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRegion.Name = "ucrReceiverRegion"
        Me.ucrReceiverRegion.Selector = Nothing
        Me.ucrReceiverRegion.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRegion.strNcFilePath = ""
        Me.ucrReceiverRegion.TabIndex = 4
        Me.ucrReceiverRegion.ucrSelector = Nothing
        '
        'ucrChkAutoGenerate
        '
        Me.ucrChkAutoGenerate.AutoSize = True
        Me.ucrChkAutoGenerate.Checked = False
        Me.ucrChkAutoGenerate.Location = New System.Drawing.Point(10, 265)
        Me.ucrChkAutoGenerate.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkAutoGenerate.Name = "ucrChkAutoGenerate"
        Me.ucrChkAutoGenerate.Size = New System.Drawing.Size(120, 23)
        Me.ucrChkAutoGenerate.TabIndex = 31
        '
        'cmdCountryLevel
        '
        Me.cmdCountryLevel.Location = New System.Drawing.Point(10, 203)
        Me.cmdCountryLevel.Name = "cmdCountryLevel"
        Me.cmdCountryLevel.Size = New System.Drawing.Size(119, 23)
        Me.cmdCountryLevel.TabIndex = 32
        Me.cmdCountryLevel.Text = "Country Level"
        Me.cmdCountryLevel.UseVisualStyleBackColor = True
        '
        'cmdCalculatedColumns
        '
        Me.cmdCalculatedColumns.Location = New System.Drawing.Point(10, 233)
        Me.cmdCalculatedColumns.Name = "cmdCalculatedColumns"
        Me.cmdCalculatedColumns.Size = New System.Drawing.Size(119, 23)
        Me.cmdCalculatedColumns.TabIndex = 33
        Me.cmdCalculatedColumns.Text = "Calculated Columns"
        Me.cmdCalculatedColumns.UseVisualStyleBackColor = True
        '
        'dlgDefineCorruption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(553, 437)
        Me.Controls.Add(Me.cmdCalculatedColumns)
        Me.Controls.Add(Me.cmdCountryLevel)
        Me.Controls.Add(Me.ucrChkAutoGenerate)
        Me.Controls.Add(Me.lblRegion)
        Me.Controls.Add(Me.ucrReceiverRegion)
        Me.Controls.Add(Me.lblFiscalYear)
        Me.Controls.Add(Me.ucrReceiverFiscalYear)
        Me.Controls.Add(Me.ucrReceiverContractValue)
        Me.Controls.Add(Me.lblContractValue)
        Me.Controls.Add(Me.lblNoBidsReceived)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrDefineCorruptionSelector)
        Me.Controls.Add(Me.ucrReceiverNoBids)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.lblSignatureDate)
        Me.Controls.Add(Me.ucrReceiverProcedureType)
        Me.Controls.Add(Me.lblAwardDate)
        Me.Controls.Add(Me.lblProcedureType)
        Me.Controls.Add(Me.ucrReceiverContractTitle)
        Me.Controls.Add(Me.ucrReceiverAwardDate)
        Me.Controls.Add(Me.lblContractTitle)
        Me.Controls.Add(Me.ucrReceiverSignatureDate)
        Me.Controls.Add(Me.ucrReceiverNoConsideredBids)
        Me.Controls.Add(Me.lblNoConsideredBids)
        Me.Controls.Add(Me.ucrReceiverCountry)
        Me.Controls.Add(Me.ucrReceiverWinnerCountry)
        Me.Controls.Add(Me.lblProcuringAuthority)
        Me.Controls.Add(Me.ucrReceiverProcuringAuthority)
        Me.Controls.Add(Me.lblWinnerCountry)
        Me.Controls.Add(Me.lblContractSector)
        Me.Controls.Add(Me.ucrReceiverContractSector)
        Me.Controls.Add(Me.lblProcurementCategory)
        Me.Controls.Add(Me.ucrReceiverProcurementCategory)
        Me.Controls.Add(Me.lblWinnerName)
        Me.Controls.Add(Me.ucrReceiverWinnerName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDefineCorruption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Define Procurement Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrDefineCorruptionSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblNoBidsReceived As Label
    Friend WithEvents ucrReceiverNoBids As ucrReceiverSingle
    Friend WithEvents ucrReceiverProcedureType As ucrReceiverSingle
    Friend WithEvents lblProcedureType As Label
    Friend WithEvents ucrReceiverContractValue As ucrReceiverSingle
    Friend WithEvents lblContractValue As Label
    Friend WithEvents ucrReceiverNoConsideredBids As ucrReceiverSingle
    Friend WithEvents ucrReceiverWinnerCountry As ucrReceiverSingle
    Friend WithEvents lblNoConsideredBids As Label
    Friend WithEvents lblWinnerCountry As Label
    Friend WithEvents ucrReceiverProcuringAuthority As ucrReceiverSingle
    Friend WithEvents lblProcuringAuthority As Label
    Friend WithEvents ucrReceiverCountry As ucrReceiverSingle
    Friend WithEvents ucrReceiverSignatureDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverContractSector As ucrReceiverSingle
    Friend WithEvents ucrReceiverProcurementCategory As ucrReceiverSingle
    Friend WithEvents ucrReceiverWinnerName As ucrReceiverSingle
    Friend WithEvents lblWinnerName As Label
    Friend WithEvents lblContractSector As Label
    Friend WithEvents lblProcurementCategory As Label
    Friend WithEvents lblContractTitle As Label
    Friend WithEvents ucrReceiverAwardDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverContractTitle As ucrReceiverSingle
    Friend WithEvents lblAwardDate As Label
    Friend WithEvents lblSignatureDate As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents lblRegion As Label
    Friend WithEvents ucrReceiverRegion As ucrReceiverSingle
    Friend WithEvents lblFiscalYear As Label
    Friend WithEvents ucrReceiverFiscalYear As ucrReceiverSingle
    Friend WithEvents ucrChkAutoGenerate As ucrCheck
    Friend WithEvents cmdCalculatedColumns As Button
    Friend WithEvents cmdCountryLevel As Button
End Class
