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
Partial Class dlgDescribeTwoVariable
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
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.lblFirstVariable = New System.Windows.Forms.Label()
        Me.lbSecondVariable = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.lblFirstType = New System.Windows.Forms.Label()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.lblSecondType = New System.Windows.Forms.Label()
        Me.lblSummaryName = New System.Windows.Forms.Label()
        Me.grpSummaries = New System.Windows.Forms.GroupBox()
        Me.rdoCustomize = New System.Windows.Forms.RadioButton()
        Me.rdoSkim = New System.Windows.Forms.RadioButton()
        Me.lbSecondOpt = New System.Windows.Forms.Label()
        Me.lblSecondFactor = New System.Windows.Forms.Label()
        Me.ucrReceiverSecondFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverSecondOpt = New instat.ucrReceiverSingle()
        Me.ucrPnlDescribe = New instat.UcrPanel()
        Me.ucrReceiverSecondVar = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstVars = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDescribeTwoVar = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverNumericVariable = New instat.ucrReceiverSingle()
        Me.lblNumericVariable = New System.Windows.Forms.Label()
        Me.grpOptions.SuspendLayout()
        Me.grpSummaries.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSummaries
        '
        Me.cmdSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSummaries.Location = New System.Drawing.Point(6, 45)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(105, 23)
        Me.cmdSummaries.TabIndex = 1
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.Text = "Summaries"
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'lblFirstVariable
        '
        Me.lblFirstVariable.AutoSize = True
        Me.lblFirstVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstVariable.Location = New System.Drawing.Point(268, 74)
        Me.lblFirstVariable.Name = "lblFirstVariable"
        Me.lblFirstVariable.Size = New System.Drawing.Size(75, 13)
        Me.lblFirstVariable.TabIndex = 4
        Me.lblFirstVariable.Tag = ""
        Me.lblFirstVariable.Text = "First Variables:"
        '
        'lbSecondVariable
        '
        Me.lbSecondVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSecondVariable.Location = New System.Drawing.Point(268, 184)
        Me.lbSecondVariable.Name = "lbSecondVariable"
        Me.lbSecondVariable.Size = New System.Drawing.Size(100, 15)
        Me.lbSecondVariable.TabIndex = 3
        Me.lbSecondVariable.Tag = ""
        Me.lbSecondVariable.Text = "Second Variable:"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrChkOmitMissing)
        Me.grpOptions.Controls.Add(Me.cmdSummaries)
        Me.grpOptions.Location = New System.Drawing.Point(252, 281)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(155, 76)
        Me.grpOptions.TabIndex = 12
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.AutoSize = True
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(9, 19)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(143, 23)
        Me.ucrChkOmitMissing.TabIndex = 0
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummary.Location = New System.Drawing.Point(6, 43)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(53, 13)
        Me.lblSummary.TabIndex = 4
        Me.lblSummary.Text = "Summary:"
        '
        'lblFirstType
        '
        Me.lblFirstType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFirstType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstType.Location = New System.Drawing.Point(6, 16)
        Me.lblFirstType.Name = "lblFirstType"
        Me.lblFirstType.Size = New System.Drawing.Size(55, 13)
        Me.lblFirstType.TabIndex = 0
        Me.lblFirstType.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBy.Location = New System.Drawing.Point(64, 16)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(18, 13)
        Me.lblBy.TabIndex = 1
        Me.lblBy.Text = "by"
        '
        'lblSecondType
        '
        Me.lblSecondType.AutoSize = True
        Me.lblSecondType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondType.Location = New System.Drawing.Point(82, 16)
        Me.lblSecondType.Name = "lblSecondType"
        Me.lblSecondType.Size = New System.Drawing.Size(0, 13)
        Me.lblSecondType.TabIndex = 2
        '
        'lblSummaryName
        '
        Me.lblSummaryName.AutoSize = True
        Me.lblSummaryName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummaryName.Location = New System.Drawing.Point(60, 43)
        Me.lblSummaryName.Name = "lblSummaryName"
        Me.lblSummaryName.Size = New System.Drawing.Size(0, 13)
        Me.lblSummaryName.TabIndex = 3
        '
        'grpSummaries
        '
        Me.grpSummaries.Controls.Add(Me.lblFirstType)
        Me.grpSummaries.Controls.Add(Me.lblSummaryName)
        Me.grpSummaries.Controls.Add(Me.lblSummary)
        Me.grpSummaries.Controls.Add(Me.lblBy)
        Me.grpSummaries.Controls.Add(Me.lblSecondType)
        Me.grpSummaries.Location = New System.Drawing.Point(10, 287)
        Me.grpSummaries.Name = "grpSummaries"
        Me.grpSummaries.Size = New System.Drawing.Size(210, 72)
        Me.grpSummaries.TabIndex = 11
        Me.grpSummaries.TabStop = False
        '
        'rdoCustomize
        '
        Me.rdoCustomize.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCustomize.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCustomize.FlatAppearance.BorderSize = 2
        Me.rdoCustomize.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCustomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCustomize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCustomize.Location = New System.Drawing.Point(201, 12)
        Me.rdoCustomize.Name = "rdoCustomize"
        Me.rdoCustomize.Size = New System.Drawing.Size(100, 28)
        Me.rdoCustomize.TabIndex = 2
        Me.rdoCustomize.Text = "Customize"
        Me.rdoCustomize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCustomize.UseVisualStyleBackColor = True
        '
        'rdoSkim
        '
        Me.rdoSkim.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSkim.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSkim.FlatAppearance.BorderSize = 2
        Me.rdoSkim.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSkim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSkim.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSkim.Location = New System.Drawing.Point(106, 12)
        Me.rdoSkim.Name = "rdoSkim"
        Me.rdoSkim.Size = New System.Drawing.Size(100, 28)
        Me.rdoSkim.TabIndex = 1
        Me.rdoSkim.Text = "Skim"
        Me.rdoSkim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSkim.UseVisualStyleBackColor = True
        '
        'lbSecondOpt
        '
        Me.lbSecondOpt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbSecondOpt.Location = New System.Drawing.Point(269, 183)
        Me.lbSecondOpt.Name = "lbSecondOpt"
        Me.lbSecondOpt.Size = New System.Drawing.Size(100, 15)
        Me.lbSecondOpt.TabIndex = 6
        Me.lbSecondOpt.Tag = ""
        Me.lbSecondOpt.Text = "Factor (Optional) :"
        '
        'lblSecondFactor
        '
        Me.lblSecondFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondFactor.Location = New System.Drawing.Point(270, 224)
        Me.lblSecondFactor.Name = "lblSecondFactor"
        Me.lblSecondFactor.Size = New System.Drawing.Size(137, 15)
        Me.lblSecondFactor.TabIndex = 8
        Me.lblSecondFactor.Tag = ""
        Me.lblSecondFactor.Text = "Second Factor (Optional) :"
        '
        'ucrReceiverSecondFactor
        '
        Me.ucrReceiverSecondFactor.AutoSize = True
        Me.ucrReceiverSecondFactor.frmParent = Me
        Me.ucrReceiverSecondFactor.Location = New System.Drawing.Point(272, 240)
        Me.ucrReceiverSecondFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondFactor.Name = "ucrReceiverSecondFactor"
        Me.ucrReceiverSecondFactor.Selector = Nothing
        Me.ucrReceiverSecondFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSecondFactor.strNcFilePath = ""
        Me.ucrReceiverSecondFactor.TabIndex = 9
        Me.ucrReceiverSecondFactor.ucrSelector = Nothing
        '
        'ucrReceiverSecondOpt
        '
        Me.ucrReceiverSecondOpt.AutoSize = True
        Me.ucrReceiverSecondOpt.frmParent = Me
        Me.ucrReceiverSecondOpt.Location = New System.Drawing.Point(271, 199)
        Me.ucrReceiverSecondOpt.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondOpt.Name = "ucrReceiverSecondOpt"
        Me.ucrReceiverSecondOpt.Selector = Nothing
        Me.ucrReceiverSecondOpt.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSecondOpt.strNcFilePath = ""
        Me.ucrReceiverSecondOpt.TabIndex = 7
        Me.ucrReceiverSecondOpt.ucrSelector = Nothing
        '
        'ucrPnlDescribe
        '
        Me.ucrPnlDescribe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDescribe.Location = New System.Drawing.Point(95, 9)
        Me.ucrPnlDescribe.Name = "ucrPnlDescribe"
        Me.ucrPnlDescribe.Size = New System.Drawing.Size(211, 34)
        Me.ucrPnlDescribe.TabIndex = 0
        '
        'ucrReceiverSecondVar
        '
        Me.ucrReceiverSecondVar.AutoSize = True
        Me.ucrReceiverSecondVar.frmParent = Me
        Me.ucrReceiverSecondVar.Location = New System.Drawing.Point(271, 199)
        Me.ucrReceiverSecondVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondVar.Name = "ucrReceiverSecondVar"
        Me.ucrReceiverSecondVar.Selector = Nothing
        Me.ucrReceiverSecondVar.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSecondVar.strNcFilePath = ""
        Me.ucrReceiverSecondVar.TabIndex = 2
        Me.ucrReceiverSecondVar.ucrSelector = Nothing
        '
        'ucrReceiverFirstVars
        '
        Me.ucrReceiverFirstVars.AutoSize = True
        Me.ucrReceiverFirstVars.frmParent = Me
        Me.ucrReceiverFirstVars.Location = New System.Drawing.Point(271, 92)
        Me.ucrReceiverFirstVars.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstVars.Name = "ucrReceiverFirstVars"
        Me.ucrReceiverFirstVars.Selector = Nothing
        Me.ucrReceiverFirstVars.Size = New System.Drawing.Size(120, 87)
        Me.ucrReceiverFirstVars.strNcFilePath = ""
        Me.ucrReceiverFirstVars.TabIndex = 5
        Me.ucrReceiverFirstVars.ucrSelector = Nothing
        '
        'ucrSelectorDescribeTwoVar
        '
        Me.ucrSelectorDescribeTwoVar.AutoSize = True
        Me.ucrSelectorDescribeTwoVar.bDropUnusedFilterLevels = False
        Me.ucrSelectorDescribeTwoVar.bShowHiddenColumns = False
        Me.ucrSelectorDescribeTwoVar.bUseCurrentFilter = True
        Me.ucrSelectorDescribeTwoVar.Location = New System.Drawing.Point(10, 39)
        Me.ucrSelectorDescribeTwoVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDescribeTwoVar.Name = "ucrSelectorDescribeTwoVar"
        Me.ucrSelectorDescribeTwoVar.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorDescribeTwoVar.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 363)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 13
        '
        'ucrReceiverNumericVariable
        '
        Me.ucrReceiverNumericVariable.AutoSize = True
        Me.ucrReceiverNumericVariable.frmParent = Me
        Me.ucrReceiverNumericVariable.Location = New System.Drawing.Point(272, 240)
        Me.ucrReceiverNumericVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverNumericVariable.Name = "ucrReceiverNumericVariable"
        Me.ucrReceiverNumericVariable.Selector = Nothing
        Me.ucrReceiverNumericVariable.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverNumericVariable.strNcFilePath = ""
        Me.ucrReceiverNumericVariable.TabIndex = 11
        Me.ucrReceiverNumericVariable.ucrSelector = Nothing
        '
        'lblNumericVariable
        '
        Me.lblNumericVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumericVariable.Location = New System.Drawing.Point(269, 222)
        Me.lblNumericVariable.Name = "lblNumericVariable"
        Me.lblNumericVariable.Size = New System.Drawing.Size(154, 15)
        Me.lblNumericVariable.TabIndex = 10
        Me.lblNumericVariable.Tag = ""
        Me.lblNumericVariable.Text = "Numeric Variable (Optional):)"
        '
        'dlgDescribeTwoVariable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(419, 421)
        Me.Controls.Add(Me.lblNumericVariable)
        Me.Controls.Add(Me.ucrReceiverNumericVariable)
        Me.Controls.Add(Me.lblSecondFactor)
        Me.Controls.Add(Me.ucrReceiverSecondFactor)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.lbSecondOpt)
        Me.Controls.Add(Me.ucrReceiverSecondOpt)
        Me.Controls.Add(Me.rdoSkim)
        Me.Controls.Add(Me.rdoCustomize)
        Me.Controls.Add(Me.ucrPnlDescribe)
        Me.Controls.Add(Me.grpSummaries)
        Me.Controls.Add(Me.lbSecondVariable)
        Me.Controls.Add(Me.lblFirstVariable)
        Me.Controls.Add(Me.ucrReceiverSecondVar)
        Me.Controls.Add(Me.ucrReceiverFirstVars)
        Me.Controls.Add(Me.ucrSelectorDescribeTwoVar)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeTwoVariable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Describe_Two_Variable"
        Me.Text = "Describe Two Variables"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpSummaries.ResumeLayout(False)
        Me.grpSummaries.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDescribeTwoVar As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFirstVars As ucrReceiverMultiple
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents ucrReceiverSecondVar As ucrReceiverSingle
    Friend WithEvents lblFirstVariable As Label
    Friend WithEvents lbSecondVariable As Label
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents lblSecondType As Label
    Friend WithEvents lblBy As Label
    Friend WithEvents lblFirstType As Label
    Friend WithEvents lblSummary As Label
    Friend WithEvents lblSummaryName As Label
    Friend WithEvents grpSummaries As GroupBox
    Friend WithEvents ucrPnlDescribe As UcrPanel
    Friend WithEvents ucrReceiverSecondOpt As ucrReceiverSingle
    Friend WithEvents rdoSkim As RadioButton
    Friend WithEvents rdoCustomize As RadioButton
    Friend WithEvents lbSecondOpt As Label
    Friend WithEvents lblSecondFactor As Label
    Friend WithEvents ucrReceiverSecondFactor As ucrReceiverSingle
    Friend WithEvents lblNumericVariable As Label
    Friend WithEvents ucrReceiverNumericVariable As ucrReceiverSingle
End Class
