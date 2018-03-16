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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDefineCorruption))
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
        Me.ucrDefineCorruptionSelector.bShowHiddenColumns = False
        Me.ucrDefineCorruptionSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrDefineCorruptionSelector, "ucrDefineCorruptionSelector")
        Me.ucrDefineCorruptionSelector.Name = "ucrDefineCorruptionSelector"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'lblNoBidsReceived
        '
        resources.ApplyResources(Me.lblNoBidsReceived, "lblNoBidsReceived")
        Me.lblNoBidsReceived.Name = "lblNoBidsReceived"
        '
        'ucrReceiverNoBids
        '
        Me.ucrReceiverNoBids.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverNoBids, "ucrReceiverNoBids")
        Me.ucrReceiverNoBids.Name = "ucrReceiverNoBids"
        Me.ucrReceiverNoBids.Selector = Nothing
        Me.ucrReceiverNoBids.strNcFilePath = ""
        Me.ucrReceiverNoBids.ucrSelector = Nothing
        '
        'ucrReceiverProcedureType
        '
        Me.ucrReceiverProcedureType.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverProcedureType, "ucrReceiverProcedureType")
        Me.ucrReceiverProcedureType.Name = "ucrReceiverProcedureType"
        Me.ucrReceiverProcedureType.Selector = Nothing
        Me.ucrReceiverProcedureType.strNcFilePath = ""
        Me.ucrReceiverProcedureType.ucrSelector = Nothing
        '
        'lblProcedureType
        '
        resources.ApplyResources(Me.lblProcedureType, "lblProcedureType")
        Me.lblProcedureType.Name = "lblProcedureType"
        '
        'ucrReceiverContractValue
        '
        Me.ucrReceiverContractValue.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverContractValue, "ucrReceiverContractValue")
        Me.ucrReceiverContractValue.Name = "ucrReceiverContractValue"
        Me.ucrReceiverContractValue.Selector = Nothing
        Me.ucrReceiverContractValue.strNcFilePath = ""
        Me.ucrReceiverContractValue.ucrSelector = Nothing
        '
        'lblContractValue
        '
        resources.ApplyResources(Me.lblContractValue, "lblContractValue")
        Me.lblContractValue.Name = "lblContractValue"
        '
        'ucrReceiverNoConsideredBids
        '
        Me.ucrReceiverNoConsideredBids.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverNoConsideredBids, "ucrReceiverNoConsideredBids")
        Me.ucrReceiverNoConsideredBids.Name = "ucrReceiverNoConsideredBids"
        Me.ucrReceiverNoConsideredBids.Selector = Nothing
        Me.ucrReceiverNoConsideredBids.strNcFilePath = ""
        Me.ucrReceiverNoConsideredBids.ucrSelector = Nothing
        '
        'ucrReceiverWinnerCountry
        '
        Me.ucrReceiverWinnerCountry.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWinnerCountry, "ucrReceiverWinnerCountry")
        Me.ucrReceiverWinnerCountry.Name = "ucrReceiverWinnerCountry"
        Me.ucrReceiverWinnerCountry.Selector = Nothing
        Me.ucrReceiverWinnerCountry.strNcFilePath = ""
        Me.ucrReceiverWinnerCountry.ucrSelector = Nothing
        '
        'lblNoConsideredBids
        '
        resources.ApplyResources(Me.lblNoConsideredBids, "lblNoConsideredBids")
        Me.lblNoConsideredBids.Name = "lblNoConsideredBids"
        '
        'lblWinnerCountry
        '
        resources.ApplyResources(Me.lblWinnerCountry, "lblWinnerCountry")
        Me.lblWinnerCountry.Name = "lblWinnerCountry"
        '
        'ucrReceiverProcuringAuthority
        '
        Me.ucrReceiverProcuringAuthority.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverProcuringAuthority, "ucrReceiverProcuringAuthority")
        Me.ucrReceiverProcuringAuthority.Name = "ucrReceiverProcuringAuthority"
        Me.ucrReceiverProcuringAuthority.Selector = Nothing
        Me.ucrReceiverProcuringAuthority.strNcFilePath = ""
        Me.ucrReceiverProcuringAuthority.ucrSelector = Nothing
        '
        'lblProcuringAuthority
        '
        resources.ApplyResources(Me.lblProcuringAuthority, "lblProcuringAuthority")
        Me.lblProcuringAuthority.Name = "lblProcuringAuthority"
        '
        'ucrReceiverCountry
        '
        Me.ucrReceiverCountry.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverCountry, "ucrReceiverCountry")
        Me.ucrReceiverCountry.Name = "ucrReceiverCountry"
        Me.ucrReceiverCountry.Selector = Nothing
        Me.ucrReceiverCountry.strNcFilePath = ""
        Me.ucrReceiverCountry.ucrSelector = Nothing
        '
        'ucrReceiverSignatureDate
        '
        Me.ucrReceiverSignatureDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSignatureDate, "ucrReceiverSignatureDate")
        Me.ucrReceiverSignatureDate.Name = "ucrReceiverSignatureDate"
        Me.ucrReceiverSignatureDate.Selector = Nothing
        Me.ucrReceiverSignatureDate.strNcFilePath = ""
        Me.ucrReceiverSignatureDate.ucrSelector = Nothing
        '
        'ucrReceiverContractSector
        '
        Me.ucrReceiverContractSector.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverContractSector, "ucrReceiverContractSector")
        Me.ucrReceiverContractSector.Name = "ucrReceiverContractSector"
        Me.ucrReceiverContractSector.Selector = Nothing
        Me.ucrReceiverContractSector.strNcFilePath = ""
        Me.ucrReceiverContractSector.ucrSelector = Nothing
        '
        'ucrReceiverProcurementCategory
        '
        Me.ucrReceiverProcurementCategory.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverProcurementCategory, "ucrReceiverProcurementCategory")
        Me.ucrReceiverProcurementCategory.Name = "ucrReceiverProcurementCategory"
        Me.ucrReceiverProcurementCategory.Selector = Nothing
        Me.ucrReceiverProcurementCategory.strNcFilePath = ""
        Me.ucrReceiverProcurementCategory.ucrSelector = Nothing
        '
        'ucrReceiverWinnerName
        '
        Me.ucrReceiverWinnerName.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWinnerName, "ucrReceiverWinnerName")
        Me.ucrReceiverWinnerName.Name = "ucrReceiverWinnerName"
        Me.ucrReceiverWinnerName.Selector = Nothing
        Me.ucrReceiverWinnerName.strNcFilePath = ""
        Me.ucrReceiverWinnerName.ucrSelector = Nothing
        '
        'lblWinnerName
        '
        resources.ApplyResources(Me.lblWinnerName, "lblWinnerName")
        Me.lblWinnerName.Name = "lblWinnerName"
        '
        'lblContractSector
        '
        resources.ApplyResources(Me.lblContractSector, "lblContractSector")
        Me.lblContractSector.Name = "lblContractSector"
        '
        'lblProcurementCategory
        '
        resources.ApplyResources(Me.lblProcurementCategory, "lblProcurementCategory")
        Me.lblProcurementCategory.Name = "lblProcurementCategory"
        '
        'lblContractTitle
        '
        resources.ApplyResources(Me.lblContractTitle, "lblContractTitle")
        Me.lblContractTitle.Name = "lblContractTitle"
        '
        'ucrReceiverAwardDate
        '
        Me.ucrReceiverAwardDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverAwardDate, "ucrReceiverAwardDate")
        Me.ucrReceiverAwardDate.Name = "ucrReceiverAwardDate"
        Me.ucrReceiverAwardDate.Selector = Nothing
        Me.ucrReceiverAwardDate.strNcFilePath = ""
        Me.ucrReceiverAwardDate.ucrSelector = Nothing
        '
        'ucrReceiverContractTitle
        '
        Me.ucrReceiverContractTitle.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverContractTitle, "ucrReceiverContractTitle")
        Me.ucrReceiverContractTitle.Name = "ucrReceiverContractTitle"
        Me.ucrReceiverContractTitle.Selector = Nothing
        Me.ucrReceiverContractTitle.strNcFilePath = ""
        Me.ucrReceiverContractTitle.ucrSelector = Nothing
        '
        'lblAwardDate
        '
        resources.ApplyResources(Me.lblAwardDate, "lblAwardDate")
        Me.lblAwardDate.Name = "lblAwardDate"
        '
        'lblSignatureDate
        '
        resources.ApplyResources(Me.lblSignatureDate, "lblSignatureDate")
        Me.lblSignatureDate.Name = "lblSignatureDate"
        '
        'lblCountry
        '
        resources.ApplyResources(Me.lblCountry, "lblCountry")
        Me.lblCountry.Name = "lblCountry"
        '
        'lblFiscalYear
        '
        resources.ApplyResources(Me.lblFiscalYear, "lblFiscalYear")
        Me.lblFiscalYear.Name = "lblFiscalYear"
        '
        'ucrReceiverFiscalYear
        '
        Me.ucrReceiverFiscalYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFiscalYear, "ucrReceiverFiscalYear")
        Me.ucrReceiverFiscalYear.Name = "ucrReceiverFiscalYear"
        Me.ucrReceiverFiscalYear.Selector = Nothing
        Me.ucrReceiverFiscalYear.strNcFilePath = ""
        Me.ucrReceiverFiscalYear.ucrSelector = Nothing
        '
        'lblRegion
        '
        resources.ApplyResources(Me.lblRegion, "lblRegion")
        Me.lblRegion.Name = "lblRegion"
        '
        'ucrReceiverRegion
        '
        Me.ucrReceiverRegion.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverRegion, "ucrReceiverRegion")
        Me.ucrReceiverRegion.Name = "ucrReceiverRegion"
        Me.ucrReceiverRegion.Selector = Nothing
        Me.ucrReceiverRegion.strNcFilePath = ""
        Me.ucrReceiverRegion.ucrSelector = Nothing
        '
        'ucrChkAutoGenerate
        '
        Me.ucrChkAutoGenerate.Checked = False
        resources.ApplyResources(Me.ucrChkAutoGenerate, "ucrChkAutoGenerate")
        Me.ucrChkAutoGenerate.Name = "ucrChkAutoGenerate"
        '
        'cmdCountryLevel
        '
        resources.ApplyResources(Me.cmdCountryLevel, "cmdCountryLevel")
        Me.cmdCountryLevel.Name = "cmdCountryLevel"
        Me.cmdCountryLevel.UseVisualStyleBackColor = True
        '
        'cmdCalculatedColumns
        '
        resources.ApplyResources(Me.cmdCalculatedColumns, "cmdCalculatedColumns")
        Me.cmdCalculatedColumns.Name = "cmdCalculatedColumns"
        Me.cmdCalculatedColumns.UseVisualStyleBackColor = True
        '
        'dlgDefineCorruption
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
