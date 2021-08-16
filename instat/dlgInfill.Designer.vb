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
Partial Class dlgInfill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgInfill))
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblByFactors = New System.Windows.Forms.Label()
        Me.lblLimits = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrDtpStartDate = New instat.ucrDateTimePicker()
        Me.lblStartingFrom = New System.Windows.Forms.Label()
        Me.ucrChkResort = New instat.ucrCheck()
        Me.ucrInputComboMonth = New instat.ucrInputComboBox()
        Me.ucrInputLimitOptions = New instat.ucrInputComboBox()
        Me.ucrDtpEndDate = New instat.ucrDateTimePicker()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.ucrChkCompleteYears = New instat.ucrCheck()
        Me.ucrReceiverFactors = New instat.ucrReceiverMultiple()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrInfillSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
        '
        'lblByFactors
        '
        resources.ApplyResources(Me.lblByFactors, "lblByFactors")
        Me.lblByFactors.Name = "lblByFactors"
        '
        'lblLimits
        '
        resources.ApplyResources(Me.lblLimits, "lblLimits")
        Me.lblLimits.Name = "lblLimits"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.lblStartingFrom)
        Me.grpOptions.Controls.Add(Me.ucrChkResort)
        Me.grpOptions.Controls.Add(Me.ucrInputComboMonth)
        Me.grpOptions.Controls.Add(Me.ucrInputLimitOptions)
        Me.grpOptions.Controls.Add(Me.ucrDtpEndDate)
        Me.grpOptions.Controls.Add(Me.lblLimits)
        Me.grpOptions.Controls.Add(Me.lblEndDate)
        Me.grpOptions.Controls.Add(Me.lblStartDate)
        Me.grpOptions.Controls.Add(Me.ucrDtpStartDate)
        Me.grpOptions.Controls.Add(Me.ucrChkCompleteYears)
        resources.ApplyResources(Me.grpOptions, "grpOptions")
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.TabStop = False
        '
        'ucrDtpStartDate
        '
        Me.ucrDtpStartDate.DateValue = New Date(2021, 5, 19, 13, 58, 51, 387)
        Me.ucrDtpStartDate.Format = "dd MMM yyyy"
        resources.ApplyResources(Me.ucrDtpStartDate, "ucrDtpStartDate")
        Me.ucrDtpStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpStartDate.Name = "ucrDtpStartDate"
        '
        'lblStartingFrom
        '
        resources.ApplyResources(Me.lblStartingFrom, "lblStartingFrom")
        Me.lblStartingFrom.Name = "lblStartingFrom"
        '
        'ucrChkResort
        '
        Me.ucrChkResort.Checked = False
        resources.ApplyResources(Me.ucrChkResort, "ucrChkResort")
        Me.ucrChkResort.Name = "ucrChkResort"
        '
        'ucrInputComboMonth
        '
        Me.ucrInputComboMonth.AddQuotesIfUnrecognised = True
        Me.ucrInputComboMonth.GetSetSelectedIndex = -1
        Me.ucrInputComboMonth.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboMonth, "ucrInputComboMonth")
        Me.ucrInputComboMonth.Name = "ucrInputComboMonth"
        '
        'ucrInputLimitOptions
        '
        Me.ucrInputLimitOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputLimitOptions.GetSetSelectedIndex = -1
        Me.ucrInputLimitOptions.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLimitOptions, "ucrInputLimitOptions")
        Me.ucrInputLimitOptions.Name = "ucrInputLimitOptions"
        '
        'ucrDtpEndDate
        '
        Me.ucrDtpEndDate.DateValue = New Date(2021, 5, 19, 13, 58, 51, 375)
        Me.ucrDtpEndDate.Format = "dd MMM yyyy"
        resources.ApplyResources(Me.ucrDtpEndDate, "ucrDtpEndDate")
        Me.ucrDtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpEndDate.Name = "ucrDtpEndDate"
        '
        'lblEndDate
        '
        resources.ApplyResources(Me.lblEndDate, "lblEndDate")
        Me.lblEndDate.Name = "lblEndDate"
        '
        'lblStartDate
        '
        resources.ApplyResources(Me.lblStartDate, "lblStartDate")
        Me.lblStartDate.Name = "lblStartDate"
        '
        'ucrChkCompleteYears
        '
        Me.ucrChkCompleteYears.Checked = False
        resources.ApplyResources(Me.ucrChkCompleteYears, "ucrChkCompleteYears")
        Me.ucrChkCompleteYears.Name = "ucrChkCompleteYears"
        '
        'ucrReceiverFactors
        '
        Me.ucrReceiverFactors.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFactors, "ucrReceiverFactors")
        Me.ucrReceiverFactors.Name = "ucrReceiverFactors"
        Me.ucrReceiverFactors.Selector = Nothing
        Me.ucrReceiverFactors.strNcFilePath = ""
        Me.ucrReceiverFactors.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDate, "ucrReceiverDate")
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrInfillSelector
        '
        Me.ucrInfillSelector.bDropUnusedFilterLevels = False
        Me.ucrInfillSelector.bShowHiddenColumns = False
        Me.ucrInfillSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrInfillSelector, "ucrInfillSelector")
        Me.ucrInfillSelector.Name = "ucrInfillSelector"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgInfill
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblByFactors)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverFactors)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrInfillSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInfill"
        Me.Tag = "Infill"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInfillSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverFactors As ucrReceiverMultiple
    Friend WithEvents lblDate As Label
    Friend WithEvents lblByFactors As Label
    Friend WithEvents ucrChkResort As ucrCheck
    Friend WithEvents ucrInputComboMonth As ucrInputComboBox
    Friend WithEvents ucrDtpEndDate As ucrDateTimePicker
    Friend WithEvents ucrDtpStartDate As ucrDateTimePicker
    Friend WithEvents lblLimits As Label
    Friend WithEvents ucrInputLimitOptions As ucrInputComboBox
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents ucrChkCompleteYears As ucrCheck
    Friend WithEvents lblStartingFrom As Label
End Class
