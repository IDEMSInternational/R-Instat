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
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblByFactors = New System.Windows.Forms.Label()
        Me.lblLimits = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.lblStartingFrom = New System.Windows.Forms.Label()
        Me.ucrChkResort = New instat.ucrCheck()
        Me.ucrInputComboMonth = New instat.ucrInputComboBox()
        Me.ucrInputLimitOptions = New instat.ucrInputComboBox()
        Me.ucrDtpEndDate = New instat.ucrDateTimePicker()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.ucrDtpStartDate = New instat.ucrDateTimePicker()
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
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(278, 15)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date:"
        '
        'lblByFactors
        '
        Me.lblByFactors.AutoSize = True
        Me.lblByFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblByFactors.Location = New System.Drawing.Point(278, 66)
        Me.lblByFactors.Name = "lblByFactors"
        Me.lblByFactors.Size = New System.Drawing.Size(60, 13)
        Me.lblByFactors.TabIndex = 3
        Me.lblByFactors.Text = "By Factors:"
        '
        'lblLimits
        '
        Me.lblLimits.AutoSize = True
        Me.lblLimits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLimits.Location = New System.Drawing.Point(5, 23)
        Me.lblLimits.Name = "lblLimits"
        Me.lblLimits.Size = New System.Drawing.Size(36, 13)
        Me.lblLimits.TabIndex = 30
        Me.lblLimits.Text = "Limits:"
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
        Me.grpOptions.Location = New System.Drawing.Point(9, 196)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(429, 104)
        Me.grpOptions.TabIndex = 5
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'lblStartingFrom
        '
        Me.lblStartingFrom.AutoSize = True
        Me.lblStartingFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStartingFrom.Location = New System.Drawing.Point(218, 49)
        Me.lblStartingFrom.Name = "lblStartingFrom"
        Me.lblStartingFrom.Size = New System.Drawing.Size(69, 13)
        Me.lblStartingFrom.TabIndex = 35
        Me.lblStartingFrom.Text = "Starting from:"
        '
        'ucrChkResort
        '
        Me.ucrChkResort.AutoSize = True
        Me.ucrChkResort.Checked = False
        Me.ucrChkResort.Location = New System.Drawing.Point(176, 21)
        Me.ucrChkResort.Name = "ucrChkResort"
        Me.ucrChkResort.Size = New System.Drawing.Size(250, 23)
        Me.ucrChkResort.TabIndex = 5
        '
        'ucrInputComboMonth
        '
        Me.ucrInputComboMonth.AddQuotesIfUnrecognised = True
        Me.ucrInputComboMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboMonth.GetSetSelectedIndex = -1
        Me.ucrInputComboMonth.IsReadOnly = False
        Me.ucrInputComboMonth.Location = New System.Drawing.Point(293, 46)
        Me.ucrInputComboMonth.Name = "ucrInputComboMonth"
        Me.ucrInputComboMonth.Size = New System.Drawing.Size(92, 21)
        Me.ucrInputComboMonth.TabIndex = 26
        '
        'ucrInputLimitOptions
        '
        Me.ucrInputLimitOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputLimitOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLimitOptions.GetSetSelectedIndex = -1
        Me.ucrInputLimitOptions.IsReadOnly = False
        Me.ucrInputLimitOptions.Location = New System.Drawing.Point(44, 19)
        Me.ucrInputLimitOptions.Name = "ucrInputLimitOptions"
        Me.ucrInputLimitOptions.Size = New System.Drawing.Size(127, 21)
        Me.ucrInputLimitOptions.TabIndex = 29
        '
        'ucrDtpEndDate
        '
        Me.ucrDtpEndDate.AutoSize = True
        Me.ucrDtpEndDate.DateValue = New Date(2021, 5, 19, 13, 58, 51, 375)
        Me.ucrDtpEndDate.Format = "dd MMM yyyy"
        Me.ucrDtpEndDate.Location = New System.Drawing.Point(102, 73)
        Me.ucrDtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpEndDate.Name = "ucrDtpEndDate"
        Me.ucrDtpEndDate.Size = New System.Drawing.Size(200, 20)
        Me.ucrDtpEndDate.TabIndex = 28
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEndDate.Location = New System.Drawing.Point(12, 76)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(53, 13)
        Me.lblEndDate.TabIndex = 33
        Me.lblEndDate.Text = "End date:"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStartDate.Location = New System.Drawing.Point(12, 49)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(56, 13)
        Me.lblStartDate.TabIndex = 32
        Me.lblStartDate.Text = "Start date:"
        '
        'ucrDtpStartDate
        '
        Me.ucrDtpStartDate.AutoSize = True
        Me.ucrDtpStartDate.DateValue = New Date(2021, 5, 19, 13, 58, 51, 387)
        Me.ucrDtpStartDate.Format = "dd MMM yyyy"
        Me.ucrDtpStartDate.Location = New System.Drawing.Point(102, 47)
        Me.ucrDtpStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpStartDate.Name = "ucrDtpStartDate"
        Me.ucrDtpStartDate.Size = New System.Drawing.Size(200, 20)
        Me.ucrDtpStartDate.TabIndex = 27
        '
        'ucrChkCompleteYears
        '
        Me.ucrChkCompleteYears.AutoSize = True
        Me.ucrChkCompleteYears.Checked = False
        Me.ucrChkCompleteYears.Location = New System.Drawing.Point(16, 47)
        Me.ucrChkCompleteYears.Name = "ucrChkCompleteYears"
        Me.ucrChkCompleteYears.Size = New System.Drawing.Size(271, 23)
        Me.ucrChkCompleteYears.TabIndex = 34
        '
        'ucrReceiverFactors
        '
        Me.ucrReceiverFactors.AutoSize = True
        Me.ucrReceiverFactors.frmParent = Me
        Me.ucrReceiverFactors.Location = New System.Drawing.Point(278, 83)
        Me.ucrReceiverFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactors.Name = "ucrReceiverFactors"
        Me.ucrReceiverFactors.Selector = Nothing
        Me.ucrReceiverFactors.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverFactors.strNcFilePath = ""
        Me.ucrReceiverFactors.TabIndex = 4
        Me.ucrReceiverFactors.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(278, 31)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 2
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrInfillSelector
        '
        Me.ucrInfillSelector.AutoSize = True
        Me.ucrInfillSelector.bDropUnusedFilterLevels = False
        Me.ucrInfillSelector.bShowHiddenColumns = False
        Me.ucrInfillSelector.bUseCurrentFilter = True
        Me.ucrInfillSelector.Location = New System.Drawing.Point(9, 9)
        Me.ucrInfillSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInfillSelector.Name = "ucrInfillSelector"
        Me.ucrInfillSelector.Size = New System.Drawing.Size(213, 183)
        Me.ucrInfillSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 306)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 6
        '
        'dlgInfill
        '
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(450, 363)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Infill"
        Me.Text = "Fill Date Gaps"
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
