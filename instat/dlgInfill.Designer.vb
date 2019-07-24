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
        Me.rdoDataLimits = New System.Windows.Forms.RadioButton()
        Me.rdoFixedLimits = New System.Windows.Forms.RadioButton()
        Me.ucrDtpEndDate = New instat.ucrDateTimePicker()
        Me.ucrChkEndDate = New instat.ucrCheck()
        Me.ucrChkStartDate = New instat.ucrCheck()
        Me.ucrChkResort = New instat.ucrCheck()
        Me.ucrReceiverFactors = New instat.ucrReceiverMultiple()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrInfillSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlDateOptions = New instat.UcrPanel()
        Me.ucrDtpStartDate = New instat.ucrDateTimePicker()
        Me.ucrInputComboMonth = New instat.ucrInputComboBox()
        Me.ucrChkCompleteYears = New instat.ucrCheck()
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
        'rdoDataLimits
        '
        resources.ApplyResources(Me.rdoDataLimits, "rdoDataLimits")
        Me.rdoDataLimits.BackColor = System.Drawing.SystemColors.Control
        Me.rdoDataLimits.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataLimits.FlatAppearance.BorderSize = 2
        Me.rdoDataLimits.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataLimits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoDataLimits.Name = "rdoDataLimits"
        Me.rdoDataLimits.UseVisualStyleBackColor = True
        '
        'rdoFixedLimits
        '
        resources.ApplyResources(Me.rdoFixedLimits, "rdoFixedLimits")
        Me.rdoFixedLimits.BackColor = System.Drawing.SystemColors.Control
        Me.rdoFixedLimits.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFixedLimits.FlatAppearance.BorderSize = 2
        Me.rdoFixedLimits.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFixedLimits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoFixedLimits.Name = "rdoFixedLimits"
        Me.rdoFixedLimits.UseVisualStyleBackColor = True
        '
        'ucrDtpEndDate
        '
        resources.ApplyResources(Me.ucrDtpEndDate, "ucrDtpEndDate")
        Me.ucrDtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpEndDate.Name = "ucrDtpEndDate"
        '
        'ucrChkEndDate
        '
        Me.ucrChkEndDate.Checked = False
        resources.ApplyResources(Me.ucrChkEndDate, "ucrChkEndDate")
        Me.ucrChkEndDate.Name = "ucrChkEndDate"
        '
        'ucrChkStartDate
        '
        Me.ucrChkStartDate.Checked = False
        resources.ApplyResources(Me.ucrChkStartDate, "ucrChkStartDate")
        Me.ucrChkStartDate.Name = "ucrChkStartDate"
        '
        'ucrChkResort
        '
        Me.ucrChkResort.Checked = False
        resources.ApplyResources(Me.ucrChkResort, "ucrChkResort")
        Me.ucrChkResort.Name = "ucrChkResort"
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
        'ucrPnlDateOptions
        '
        resources.ApplyResources(Me.ucrPnlDateOptions, "ucrPnlDateOptions")
        Me.ucrPnlDateOptions.Name = "ucrPnlDateOptions"
        '
        'ucrDtpStartDate
        '
        resources.ApplyResources(Me.ucrDtpStartDate, "ucrDtpStartDate")
        Me.ucrDtpStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpStartDate.Name = "ucrDtpStartDate"
        '
        'ucrInputComboMonth
        '
        Me.ucrInputComboMonth.AddQuotesIfUnrecognised = True
        Me.ucrInputComboMonth.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboMonth, "ucrInputComboMonth")
        Me.ucrInputComboMonth.Name = "ucrInputComboMonth"
        '
        'ucrChkCompleteYears
        '
        Me.ucrChkCompleteYears.Checked = False
        resources.ApplyResources(Me.ucrChkCompleteYears, "ucrChkCompleteYears")
        Me.ucrChkCompleteYears.Name = "ucrChkCompleteYears"
        '
        'dlgInfill
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rdoFixedLimits)
        Me.Controls.Add(Me.ucrDtpEndDate)
        Me.Controls.Add(Me.ucrChkEndDate)
        Me.Controls.Add(Me.ucrChkStartDate)
        Me.Controls.Add(Me.rdoDataLimits)
        Me.Controls.Add(Me.ucrChkResort)
        Me.Controls.Add(Me.lblByFactors)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverFactors)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrInfillSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlDateOptions)
        Me.Controls.Add(Me.ucrDtpStartDate)
        Me.Controls.Add(Me.ucrInputComboMonth)
        Me.Controls.Add(Me.ucrChkCompleteYears)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInfill"
        Me.Tag = "Infill"
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
    Friend WithEvents rdoDataLimits As RadioButton
    Friend WithEvents ucrPnlDateOptions As UcrPanel
    Friend WithEvents ucrChkEndDate As ucrCheck
    Friend WithEvents ucrChkStartDate As ucrCheck
    Friend WithEvents ucrChkCompleteYears As ucrCheck
    Friend WithEvents ucrInputComboMonth As ucrInputComboBox
    Friend WithEvents ucrDtpEndDate As ucrDateTimePicker
    Friend WithEvents ucrDtpStartDate As ucrDateTimePicker
    Friend WithEvents rdoFixedLimits As RadioButton
End Class
