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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgCorruptionCalculatedColumns))
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
        Me.ucrCalculatedColumnsSelector.bShowHiddenColumns = False
        Me.ucrCalculatedColumnsSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrCalculatedColumnsSelector, "ucrCalculatedColumnsSelector")
        Me.ucrCalculatedColumnsSelector.Name = "ucrCalculatedColumnsSelector"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'lblProcedureType
        '
        resources.ApplyResources(Me.lblProcedureType, "lblProcedureType")
        Me.lblProcedureType.Name = "lblProcedureType"
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
        'lblAwardYear
        '
        resources.ApplyResources(Me.lblAwardYear, "lblAwardYear")
        Me.lblAwardYear.Name = "lblAwardYear"
        '
        'lblWinnerID
        '
        resources.ApplyResources(Me.lblWinnerID, "lblWinnerID")
        Me.lblWinnerID.Name = "lblWinnerID"
        '
        'ucrReceiverWinnerID
        '
        Me.ucrReceiverWinnerID.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWinnerID, "ucrReceiverWinnerID")
        Me.ucrReceiverWinnerID.Name = "ucrReceiverWinnerID"
        Me.ucrReceiverWinnerID.Selector = Nothing
        Me.ucrReceiverWinnerID.strNcFilePath = ""
        Me.ucrReceiverWinnerID.ucrSelector = Nothing
        '
        'ucrReceiverAwardYear
        '
        Me.ucrReceiverAwardYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverAwardYear, "ucrReceiverAwardYear")
        Me.ucrReceiverAwardYear.Name = "ucrReceiverAwardYear"
        Me.ucrReceiverAwardYear.Selector = Nothing
        Me.ucrReceiverAwardYear.strNcFilePath = ""
        Me.ucrReceiverAwardYear.ucrSelector = Nothing
        '
        'lblProcuringAuthority
        '
        resources.ApplyResources(Me.lblProcuringAuthority, "lblProcuringAuthority")
        Me.lblProcuringAuthority.Name = "lblProcuringAuthority"
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
        'ucrReceiverForeignWinner
        '
        Me.ucrReceiverForeignWinner.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverForeignWinner, "ucrReceiverForeignWinner")
        Me.ucrReceiverForeignWinner.Name = "ucrReceiverForeignWinner"
        Me.ucrReceiverForeignWinner.Selector = Nothing
        Me.ucrReceiverForeignWinner.strNcFilePath = ""
        Me.ucrReceiverForeignWinner.ucrSelector = Nothing
        '
        'lblForeignWinner
        '
        resources.ApplyResources(Me.lblForeignWinner, "lblForeignWinner")
        Me.lblForeignWinner.Name = "lblForeignWinner"
        '
        'lblProcurementTypeCat
        '
        resources.ApplyResources(Me.lblProcurementTypeCat, "lblProcurementTypeCat")
        Me.lblProcurementTypeCat.Name = "lblProcurementTypeCat"
        '
        'ucrReceiverProcurementTypeCat
        '
        Me.ucrReceiverProcurementTypeCat.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverProcurementTypeCat, "ucrReceiverProcurementTypeCat")
        Me.ucrReceiverProcurementTypeCat.Name = "ucrReceiverProcurementTypeCat"
        Me.ucrReceiverProcurementTypeCat.Selector = Nothing
        Me.ucrReceiverProcurementTypeCat.strNcFilePath = ""
        Me.ucrReceiverProcurementTypeCat.ucrSelector = Nothing
        '
        'lblContractValueCategories
        '
        resources.ApplyResources(Me.lblContractValueCategories, "lblContractValueCategories")
        Me.lblContractValueCategories.Name = "lblContractValueCategories"
        '
        'lblProcurementType3
        '
        resources.ApplyResources(Me.lblProcurementType3, "lblProcurementType3")
        Me.lblProcurementType3.Name = "lblProcurementType3"
        '
        'ucrReceiverProcurementType3
        '
        Me.ucrReceiverProcurementType3.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverProcurementType3, "ucrReceiverProcurementType3")
        Me.ucrReceiverProcurementType3.Name = "ucrReceiverProcurementType3"
        Me.ucrReceiverProcurementType3.Selector = Nothing
        Me.ucrReceiverProcurementType3.strNcFilePath = ""
        Me.ucrReceiverProcurementType3.ucrSelector = Nothing
        '
        'ucrReceiverContractValueCategories
        '
        Me.ucrReceiverContractValueCategories.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverContractValueCategories, "ucrReceiverContractValueCategories")
        Me.ucrReceiverContractValueCategories.Name = "ucrReceiverContractValueCategories"
        Me.ucrReceiverContractValueCategories.Selector = Nothing
        Me.ucrReceiverContractValueCategories.strNcFilePath = ""
        Me.ucrReceiverContractValueCategories.ucrSelector = Nothing
        '
        'lblProcurementType2
        '
        resources.ApplyResources(Me.lblProcurementType2, "lblProcurementType2")
        Me.lblProcurementType2.Name = "lblProcurementType2"
        '
        'ucrReceiverProcurementType2
        '
        Me.ucrReceiverProcurementType2.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverProcurementType2, "ucrReceiverProcurementType2")
        Me.ucrReceiverProcurementType2.Name = "ucrReceiverProcurementType2"
        Me.ucrReceiverProcurementType2.Selector = Nothing
        Me.ucrReceiverProcurementType2.strNcFilePath = ""
        Me.ucrReceiverProcurementType2.ucrSelector = Nothing
        '
        'ucrReceiverSignaturePeriod
        '
        Me.ucrReceiverSignaturePeriod.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSignaturePeriod, "ucrReceiverSignaturePeriod")
        Me.ucrReceiverSignaturePeriod.Name = "ucrReceiverSignaturePeriod"
        Me.ucrReceiverSignaturePeriod.Selector = Nothing
        Me.ucrReceiverSignaturePeriod.strNcFilePath = ""
        Me.ucrReceiverSignaturePeriod.ucrSelector = Nothing
        '
        'lblSignaturePeriod
        '
        resources.ApplyResources(Me.lblSignaturePeriod, "lblSignaturePeriod")
        Me.lblSignaturePeriod.Name = "lblSignaturePeriod"
        '
        'lblRollSumWinner
        '
        resources.ApplyResources(Me.lblRollSumWinner, "lblRollSumWinner")
        Me.lblRollSumWinner.Name = "lblRollSumWinner"
        '
        'ucrReceiverValueSumWinner
        '
        Me.ucrReceiverValueSumWinner.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverValueSumWinner, "ucrReceiverValueSumWinner")
        Me.ucrReceiverValueSumWinner.Name = "ucrReceiverValueSumWinner"
        Me.ucrReceiverValueSumWinner.Selector = Nothing
        Me.ucrReceiverValueSumWinner.strNcFilePath = ""
        Me.ucrReceiverValueSumWinner.ucrSelector = Nothing
        '
        'lblRollNumIssuer
        '
        resources.ApplyResources(Me.lblRollNumIssuer, "lblRollNumIssuer")
        Me.lblRollNumIssuer.Name = "lblRollNumIssuer"
        '
        'lblRollShareWinner
        '
        resources.ApplyResources(Me.lblRollShareWinner, "lblRollShareWinner")
        Me.lblRollShareWinner.Name = "lblRollShareWinner"
        '
        'ucrReceiverValueShareWinner
        '
        Me.ucrReceiverValueShareWinner.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverValueShareWinner, "ucrReceiverValueShareWinner")
        Me.ucrReceiverValueShareWinner.Name = "ucrReceiverValueShareWinner"
        Me.ucrReceiverValueShareWinner.Selector = Nothing
        Me.ucrReceiverValueShareWinner.strNcFilePath = ""
        Me.ucrReceiverValueShareWinner.ucrSelector = Nothing
        '
        'ucrReceiverRollingNumberIssuer
        '
        Me.ucrReceiverRollingNumberIssuer.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverRollingNumberIssuer, "ucrReceiverRollingNumberIssuer")
        Me.ucrReceiverRollingNumberIssuer.Name = "ucrReceiverRollingNumberIssuer"
        Me.ucrReceiverRollingNumberIssuer.Selector = Nothing
        Me.ucrReceiverRollingNumberIssuer.strNcFilePath = ""
        Me.ucrReceiverRollingNumberIssuer.ucrSelector = Nothing
        '
        'lblRollSumIssuer
        '
        resources.ApplyResources(Me.lblRollSumIssuer, "lblRollSumIssuer")
        Me.lblRollSumIssuer.Name = "lblRollSumIssuer"
        '
        'ucrReceiverValueSumIssuer
        '
        Me.ucrReceiverValueSumIssuer.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverValueSumIssuer, "ucrReceiverValueSumIssuer")
        Me.ucrReceiverValueSumIssuer.Name = "ucrReceiverValueSumIssuer"
        Me.ucrReceiverValueSumIssuer.Selector = Nothing
        Me.ucrReceiverValueSumIssuer.strNcFilePath = ""
        Me.ucrReceiverValueSumIssuer.ucrSelector = Nothing
        '
        'ucrReceiverSingleBidder
        '
        Me.ucrReceiverSingleBidder.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSingleBidder, "ucrReceiverSingleBidder")
        Me.ucrReceiverSingleBidder.Name = "ucrReceiverSingleBidder"
        Me.ucrReceiverSingleBidder.Selector = Nothing
        Me.ucrReceiverSingleBidder.strNcFilePath = ""
        Me.ucrReceiverSingleBidder.ucrSelector = Nothing
        '
        'lblSingleBidder
        '
        resources.ApplyResources(Me.lblSingleBidder, "lblSingleBidder")
        Me.lblSingleBidder.Name = "lblSingleBidder"
        '
        'lblSignaturePeriod5
        '
        resources.ApplyResources(Me.lblSignaturePeriod5, "lblSignaturePeriod5")
        Me.lblSignaturePeriod5.Name = "lblSignaturePeriod5"
        '
        'ucrReceiverPeriod5
        '
        Me.ucrReceiverPeriod5.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverPeriod5, "ucrReceiverPeriod5")
        Me.ucrReceiverPeriod5.Name = "ucrReceiverPeriod5"
        Me.ucrReceiverPeriod5.Selector = Nothing
        Me.ucrReceiverPeriod5.strNcFilePath = ""
        Me.ucrReceiverPeriod5.ucrSelector = Nothing
        '
        'lblSignaturePeriodCorrected
        '
        resources.ApplyResources(Me.lblSignaturePeriodCorrected, "lblSignaturePeriodCorrected")
        Me.lblSignaturePeriodCorrected.Name = "lblSignaturePeriodCorrected"
        '
        'lblSignaturePeriodCat
        '
        resources.ApplyResources(Me.lblSignaturePeriodCat, "lblSignaturePeriodCat")
        Me.lblSignaturePeriodCat.Name = "lblSignaturePeriodCat"
        '
        'ucrReceiverPeriodCat
        '
        Me.ucrReceiverPeriodCat.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverPeriodCat, "ucrReceiverPeriodCat")
        Me.ucrReceiverPeriodCat.Name = "ucrReceiverPeriodCat"
        Me.ucrReceiverPeriodCat.Selector = Nothing
        Me.ucrReceiverPeriodCat.strNcFilePath = ""
        Me.ucrReceiverPeriodCat.ucrSelector = Nothing
        '
        'ucrReceiverSignaturePeriodCorrected
        '
        Me.ucrReceiverSignaturePeriodCorrected.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSignaturePeriodCorrected, "ucrReceiverSignaturePeriodCorrected")
        Me.ucrReceiverSignaturePeriodCorrected.Name = "ucrReceiverSignaturePeriodCorrected"
        Me.ucrReceiverSignaturePeriodCorrected.Selector = Nothing
        Me.ucrReceiverSignaturePeriodCorrected.strNcFilePath = ""
        Me.ucrReceiverSignaturePeriodCorrected.ucrSelector = Nothing
        '
        'lblSignaturePeriod25
        '
        resources.ApplyResources(Me.lblSignaturePeriod25, "lblSignaturePeriod25")
        Me.lblSignaturePeriod25.Name = "lblSignaturePeriod25"
        '
        'ucrReceiverPeriod25
        '
        Me.ucrReceiverPeriod25.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverPeriod25, "ucrReceiverPeriod25")
        Me.ucrReceiverPeriod25.Name = "ucrReceiverPeriod25"
        Me.ucrReceiverPeriod25.Selector = Nothing
        Me.ucrReceiverPeriod25.strNcFilePath = ""
        Me.ucrReceiverPeriod25.ucrSelector = Nothing
        '
        'ucrReceiverRollingNumberWinner
        '
        Me.ucrReceiverRollingNumberWinner.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverRollingNumberWinner, "ucrReceiverRollingNumberWinner")
        Me.ucrReceiverRollingNumberWinner.Name = "ucrReceiverRollingNumberWinner"
        Me.ucrReceiverRollingNumberWinner.Selector = Nothing
        Me.ucrReceiverRollingNumberWinner.strNcFilePath = ""
        Me.ucrReceiverRollingNumberWinner.ucrSelector = Nothing
        '
        'lblRollNumWinner
        '
        resources.ApplyResources(Me.lblRollNumWinner, "lblRollNumWinner")
        Me.lblRollNumWinner.Name = "lblRollNumWinner"
        '
        'lblWinnerCountryISO3
        '
        resources.ApplyResources(Me.lblWinnerCountryISO3, "lblWinnerCountryISO3")
        Me.lblWinnerCountryISO3.Name = "lblWinnerCountryISO3"
        '
        'ucrReceiverWinnerCountryISO3
        '
        Me.ucrReceiverWinnerCountryISO3.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWinnerCountryISO3, "ucrReceiverWinnerCountryISO3")
        Me.ucrReceiverWinnerCountryISO3.Name = "ucrReceiverWinnerCountryISO3"
        Me.ucrReceiverWinnerCountryISO3.Selector = Nothing
        Me.ucrReceiverWinnerCountryISO3.strNcFilePath = ""
        Me.ucrReceiverWinnerCountryISO3.ucrSelector = Nothing
        '
        'lblWinnerCountryISO2
        '
        resources.ApplyResources(Me.lblWinnerCountryISO2, "lblWinnerCountryISO2")
        Me.lblWinnerCountryISO2.Name = "lblWinnerCountryISO2"
        '
        'lblWBPPP
        '
        resources.ApplyResources(Me.lblWBPPP, "lblWBPPP")
        Me.lblWBPPP.Name = "lblWBPPP"
        '
        'ucrReceiverPPPAdjustedContractValue
        '
        Me.ucrReceiverPPPAdjustedContractValue.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverPPPAdjustedContractValue, "ucrReceiverPPPAdjustedContractValue")
        Me.ucrReceiverPPPAdjustedContractValue.Name = "ucrReceiverPPPAdjustedContractValue"
        Me.ucrReceiverPPPAdjustedContractValue.Selector = Nothing
        Me.ucrReceiverPPPAdjustedContractValue.strNcFilePath = ""
        Me.ucrReceiverPPPAdjustedContractValue.ucrSelector = Nothing
        '
        'ucrReceiverWinnerCountryISO2
        '
        Me.ucrReceiverWinnerCountryISO2.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWinnerCountryISO2, "ucrReceiverWinnerCountryISO2")
        Me.ucrReceiverWinnerCountryISO2.Name = "ucrReceiverWinnerCountryISO2"
        Me.ucrReceiverWinnerCountryISO2.Selector = Nothing
        Me.ucrReceiverWinnerCountryISO2.strNcFilePath = ""
        Me.ucrReceiverWinnerCountryISO2.ucrSelector = Nothing
        '
        'lblPPPAdjustedContractValue
        '
        resources.ApplyResources(Me.lblPPPAdjustedContractValue, "lblPPPAdjustedContractValue")
        Me.lblPPPAdjustedContractValue.Name = "lblPPPAdjustedContractValue"
        '
        'ucrReceiverWBPPP
        '
        Me.ucrReceiverWBPPP.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWBPPP, "ucrReceiverWBPPP")
        Me.ucrReceiverWBPPP.Name = "ucrReceiverWBPPP"
        Me.ucrReceiverWBPPP.Selector = Nothing
        Me.ucrReceiverWBPPP.strNcFilePath = ""
        Me.ucrReceiverWBPPP.ucrSelector = Nothing
        '
        'ucrReceiverSecrecyScore
        '
        Me.ucrReceiverSecrecyScore.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSecrecyScore, "ucrReceiverSecrecyScore")
        Me.ucrReceiverSecrecyScore.Name = "ucrReceiverSecrecyScore"
        Me.ucrReceiverSecrecyScore.Selector = Nothing
        Me.ucrReceiverSecrecyScore.strNcFilePath = ""
        Me.ucrReceiverSecrecyScore.ucrSelector = Nothing
        '
        'lblSecrecyScore
        '
        resources.ApplyResources(Me.lblSecrecyScore, "lblSecrecyScore")
        Me.lblSecrecyScore.Name = "lblSecrecyScore"
        '
        'lblCountryISO2
        '
        resources.ApplyResources(Me.lblCountryISO2, "lblCountryISO2")
        Me.lblCountryISO2.Name = "lblCountryISO2"
        '
        'ucrReceiverCountryISO2
        '
        Me.ucrReceiverCountryISO2.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverCountryISO2, "ucrReceiverCountryISO2")
        Me.ucrReceiverCountryISO2.Name = "ucrReceiverCountryISO2"
        Me.ucrReceiverCountryISO2.Selector = Nothing
        Me.ucrReceiverCountryISO2.strNcFilePath = ""
        Me.ucrReceiverCountryISO2.ucrSelector = Nothing
        '
        'lblContractValueShareOverThreshold
        '
        resources.ApplyResources(Me.lblContractValueShareOverThreshold, "lblContractValueShareOverThreshold")
        Me.lblContractValueShareOverThreshold.Name = "lblContractValueShareOverThreshold"
        '
        'lblAddBids
        '
        resources.ApplyResources(Me.lblAddBids, "lblAddBids")
        Me.lblAddBids.Name = "lblAddBids"
        '
        'ucrReceiverAllBids
        '
        Me.ucrReceiverAllBids.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverAllBids, "ucrReceiverAllBids")
        Me.ucrReceiverAllBids.Name = "ucrReceiverAllBids"
        Me.ucrReceiverAllBids.Selector = Nothing
        Me.ucrReceiverAllBids.strNcFilePath = ""
        Me.ucrReceiverAllBids.ucrSelector = Nothing
        '
        'ucrReceiverContractShareThreshold
        '
        Me.ucrReceiverContractShareThreshold.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverContractShareThreshold, "ucrReceiverContractShareThreshold")
        Me.ucrReceiverContractShareThreshold.Name = "ucrReceiverContractShareThreshold"
        Me.ucrReceiverContractShareThreshold.Selector = Nothing
        Me.ucrReceiverContractShareThreshold.strNcFilePath = ""
        Me.ucrReceiverContractShareThreshold.ucrSelector = Nothing
        '
        'lblCountryISO3
        '
        resources.ApplyResources(Me.lblCountryISO3, "lblCountryISO3")
        Me.lblCountryISO3.Name = "lblCountryISO3"
        '
        'ucrReceiverCountryISO3
        '
        Me.ucrReceiverCountryISO3.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverCountryISO3, "ucrReceiverCountryISO3")
        Me.ucrReceiverCountryISO3.Name = "ucrReceiverCountryISO3"
        Me.ucrReceiverCountryISO3.Selector = Nothing
        Me.ucrReceiverCountryISO3.strNcFilePath = ""
        Me.ucrReceiverCountryISO3.ucrSelector = Nothing
        '
        'ucrReceiverAllBidsTrimmed
        '
        Me.ucrReceiverAllBidsTrimmed.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverAllBidsTrimmed, "ucrReceiverAllBidsTrimmed")
        Me.ucrReceiverAllBidsTrimmed.Name = "ucrReceiverAllBidsTrimmed"
        Me.ucrReceiverAllBidsTrimmed.Selector = Nothing
        Me.ucrReceiverAllBidsTrimmed.strNcFilePath = ""
        Me.ucrReceiverAllBidsTrimmed.ucrSelector = Nothing
        '
        'lblAllBidsTrimmed
        '
        resources.ApplyResources(Me.lblAllBidsTrimmed, "lblAllBidsTrimmed")
        Me.lblAllBidsTrimmed.Name = "lblAllBidsTrimmed"
        '
        'lblTaxHaven2
        '
        resources.ApplyResources(Me.lblTaxHaven2, "lblTaxHaven2")
        Me.lblTaxHaven2.Name = "lblTaxHaven2"
        '
        'ucrReceiverTaxHaven2
        '
        Me.ucrReceiverTaxHaven2.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverTaxHaven2, "ucrReceiverTaxHaven2")
        Me.ucrReceiverTaxHaven2.Name = "ucrReceiverTaxHaven2"
        Me.ucrReceiverTaxHaven2.Selector = Nothing
        Me.ucrReceiverTaxHaven2.strNcFilePath = ""
        Me.ucrReceiverTaxHaven2.ucrSelector = Nothing
        '
        'lblTaxHaven
        '
        resources.ApplyResources(Me.lblTaxHaven, "lblTaxHaven")
        Me.lblTaxHaven.Name = "lblTaxHaven"
        '
        'lblTaxHaven3bi
        '
        resources.ApplyResources(Me.lblTaxHaven3bi, "lblTaxHaven3bi")
        Me.lblTaxHaven3bi.Name = "lblTaxHaven3bi"
        '
        'ucrReceiverTaxHaven3bi
        '
        Me.ucrReceiverTaxHaven3bi.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverTaxHaven3bi, "ucrReceiverTaxHaven3bi")
        Me.ucrReceiverTaxHaven3bi.Name = "ucrReceiverTaxHaven3bi"
        Me.ucrReceiverTaxHaven3bi.Selector = Nothing
        Me.ucrReceiverTaxHaven3bi.strNcFilePath = ""
        Me.ucrReceiverTaxHaven3bi.ucrSelector = Nothing
        '
        'ucrReceiverTaxHaven
        '
        Me.ucrReceiverTaxHaven.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverTaxHaven, "ucrReceiverTaxHaven")
        Me.ucrReceiverTaxHaven.Name = "ucrReceiverTaxHaven"
        Me.ucrReceiverTaxHaven.Selector = Nothing
        Me.ucrReceiverTaxHaven.strNcFilePath = ""
        Me.ucrReceiverTaxHaven.ucrSelector = Nothing
        '
        'lblTaxHaven3
        '
        resources.ApplyResources(Me.lblTaxHaven3, "lblTaxHaven3")
        Me.lblTaxHaven3.Name = "lblTaxHaven3"
        '
        'ucrReceiverTaxHaven3
        '
        Me.ucrReceiverTaxHaven3.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverTaxHaven3, "ucrReceiverTaxHaven3")
        Me.ucrReceiverTaxHaven3.Name = "ucrReceiverTaxHaven3"
        Me.ucrReceiverTaxHaven3.Selector = Nothing
        Me.ucrReceiverTaxHaven3.strNcFilePath = ""
        Me.ucrReceiverTaxHaven3.ucrSelector = Nothing
        '
        'sdgCorruptionCalculatedColumns
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
