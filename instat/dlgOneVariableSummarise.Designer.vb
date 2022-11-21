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
Partial Class dlgOneVariableSummarise
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
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.lblMaxSum = New System.Windows.Forms.Label()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.rdoCustomised = New System.Windows.Forms.RadioButton()
        Me.rdoDefault = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSummaries = New instat.UcrPanel()
        Me.ucrChkDisplaySummariesAsRows = New instat.ucrCheck()
        Me.ucrChkDisplayVariablesAsRows = New instat.ucrCheck()
        Me.ucrNudMaxSum = New instat.ucrNud()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrSelectorOneVarSummarise = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverOneVarSummarise = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputMarginName = New instat.ucrInputTextBox()
        Me.lblMarginName = New System.Windows.Forms.Label()
        Me.ucrChkDisplayMargins = New instat.ucrCheck()
        Me.rdoSkim = New System.Windows.Forms.RadioButton()
        Me.cmdMissingOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectedVariable.Location = New System.Drawing.Point(258, 64)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(142, 14)
        Me.lblSelectedVariable.TabIndex = 1
        Me.lblSelectedVariable.Tag = "Selected_Variable"
        Me.lblSelectedVariable.Text = "Variable(s) to Summarise:"
        '
        'lblMaxSum
        '
        Me.lblMaxSum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxSum.Location = New System.Drawing.Point(13, 253)
        Me.lblMaxSum.Name = "lblMaxSum"
        Me.lblMaxSum.Size = New System.Drawing.Size(189, 24)
        Me.lblMaxSum.TabIndex = 7
        Me.lblMaxSum.Text = "Maximum Factor Levels Shown:"
        '
        'cmdSummaries
        '
        Me.cmdSummaries.AutoSize = True
        Me.cmdSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSummaries.Location = New System.Drawing.Point(261, 215)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(120, 23)
        Me.cmdSummaries.TabIndex = 6
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.Text = "Choose Summaries..."
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'rdoCustomised
        '
        Me.rdoCustomised.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCustomised.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCustomised.FlatAppearance.BorderSize = 2
        Me.rdoCustomised.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCustomised.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCustomised.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCustomised.Location = New System.Drawing.Point(247, 13)
        Me.rdoCustomised.Name = "rdoCustomised"
        Me.rdoCustomised.Size = New System.Drawing.Size(90, 27)
        Me.rdoCustomised.TabIndex = 22
        Me.rdoCustomised.TabStop = True
        Me.rdoCustomised.Text = "Customised"
        Me.rdoCustomised.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCustomised.UseVisualStyleBackColor = True
        '
        'rdoDefault
        '
        Me.rdoDefault.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDefault.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDefault.FlatAppearance.BorderSize = 2
        Me.rdoDefault.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDefault.Location = New System.Drawing.Point(82, 13)
        Me.rdoDefault.Name = "rdoDefault"
        Me.rdoDefault.Size = New System.Drawing.Size(83, 27)
        Me.rdoDefault.TabIndex = 21
        Me.rdoDefault.TabStop = True
        Me.rdoDefault.Text = "Defaults"
        Me.rdoDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDefault.UseVisualStyleBackColor = True
        '
        'ucrPnlSummaries
        '
        Me.ucrPnlSummaries.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSummaries.Location = New System.Drawing.Point(73, 11)
        Me.ucrPnlSummaries.Name = "ucrPnlSummaries"
        Me.ucrPnlSummaries.Size = New System.Drawing.Size(275, 29)
        Me.ucrPnlSummaries.TabIndex = 20
        '
        'ucrChkDisplaySummariesAsRows
        '
        Me.ucrChkDisplaySummariesAsRows.AutoSize = True
        Me.ucrChkDisplaySummariesAsRows.Checked = False
        Me.ucrChkDisplaySummariesAsRows.Location = New System.Drawing.Point(10, 267)
        Me.ucrChkDisplaySummariesAsRows.Name = "ucrChkDisplaySummariesAsRows"
        Me.ucrChkDisplaySummariesAsRows.Size = New System.Drawing.Size(241, 23)
        Me.ucrChkDisplaySummariesAsRows.TabIndex = 19
        '
        'ucrChkDisplayVariablesAsRows
        '
        Me.ucrChkDisplayVariablesAsRows.AutoSize = True
        Me.ucrChkDisplayVariablesAsRows.Checked = False
        Me.ucrChkDisplayVariablesAsRows.Location = New System.Drawing.Point(10, 290)
        Me.ucrChkDisplayVariablesAsRows.Name = "ucrChkDisplayVariablesAsRows"
        Me.ucrChkDisplayVariablesAsRows.Size = New System.Drawing.Size(227, 23)
        Me.ucrChkDisplayVariablesAsRows.TabIndex = 18
        '
        'ucrNudMaxSum
        '
        Me.ucrNudMaxSum.AutoSize = True
        Me.ucrNudMaxSum.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxSum.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxSum.Location = New System.Drawing.Point(261, 248)
        Me.ucrNudMaxSum.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxSum.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxSum.Name = "ucrNudMaxSum"
        Me.ucrNudMaxSum.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxSum.TabIndex = 8
        Me.ucrNudMaxSum.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.AutoSize = True
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(10, 314)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(162, 23)
        Me.ucrChkOmitMissing.TabIndex = 9
        '
        'ucrSelectorOneVarSummarise
        '
        Me.ucrSelectorOneVarSummarise.AutoSize = True
        Me.ucrSelectorOneVarSummarise.bDropUnusedFilterLevels = False
        Me.ucrSelectorOneVarSummarise.bShowHiddenColumns = False
        Me.ucrSelectorOneVarSummarise.bUseCurrentFilter = True
        Me.ucrSelectorOneVarSummarise.Location = New System.Drawing.Point(10, 55)
        Me.ucrSelectorOneVarSummarise.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOneVarSummarise.Name = "ucrSelectorOneVarSummarise"
        Me.ucrSelectorOneVarSummarise.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorOneVarSummarise.TabIndex = 0
        '
        'ucrReceiverOneVarSummarise
        '
        Me.ucrReceiverOneVarSummarise.AutoSize = True
        Me.ucrReceiverOneVarSummarise.frmParent = Me
        Me.ucrReceiverOneVarSummarise.Location = New System.Drawing.Point(261, 82)
        Me.ucrReceiverOneVarSummarise.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOneVarSummarise.Name = "ucrReceiverOneVarSummarise"
        Me.ucrReceiverOneVarSummarise.Selector = Nothing
        Me.ucrReceiverOneVarSummarise.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverOneVarSummarise.strNcFilePath = ""
        Me.ucrReceiverOneVarSummarise.TabIndex = 2
        Me.ucrReceiverOneVarSummarise.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(8, 346)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 11
        '
        'ucrInputMarginName
        '
        Me.ucrInputMarginName.AddQuotesIfUnrecognised = True
        Me.ucrInputMarginName.AutoSize = True
        Me.ucrInputMarginName.IsMultiline = False
        Me.ucrInputMarginName.IsReadOnly = False
        Me.ucrInputMarginName.Location = New System.Drawing.Point(206, 243)
        Me.ucrInputMarginName.Name = "ucrInputMarginName"
        Me.ucrInputMarginName.Size = New System.Drawing.Size(74, 21)
        Me.ucrInputMarginName.TabIndex = 25
        '
        'lblMarginName
        '
        Me.lblMarginName.AutoSize = True
        Me.lblMarginName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarginName.Location = New System.Drawing.Point(159, 246)
        Me.lblMarginName.Name = "lblMarginName"
        Me.lblMarginName.Size = New System.Drawing.Size(41, 13)
        Me.lblMarginName.TabIndex = 24
        Me.lblMarginName.Text = "Name :"
        '
        'ucrChkDisplayMargins
        '
        Me.ucrChkDisplayMargins.AutoSize = True
        Me.ucrChkDisplayMargins.Checked = False
        Me.ucrChkDisplayMargins.Location = New System.Drawing.Point(10, 246)
        Me.ucrChkDisplayMargins.Name = "ucrChkDisplayMargins"
        Me.ucrChkDisplayMargins.Size = New System.Drawing.Size(150, 23)
        Me.ucrChkDisplayMargins.TabIndex = 23
        '
        'rdoSkim
        '
        Me.rdoSkim.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSkim.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSkim.FlatAppearance.BorderSize = 2
        Me.rdoSkim.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSkim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSkim.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSkim.Location = New System.Drawing.Point(162, 13)
        Me.rdoSkim.Name = "rdoSkim"
        Me.rdoSkim.Size = New System.Drawing.Size(87, 27)
        Me.rdoSkim.TabIndex = 26
        Me.rdoSkim.TabStop = True
        Me.rdoSkim.Text = "Skim"
        Me.rdoSkim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSkim.UseVisualStyleBackColor = True
        '
        'cmdMissingOptions
        '
        Me.cmdMissingOptions.Enabled = False
        Me.cmdMissingOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMissingOptions.Location = New System.Drawing.Point(165, 311)
        Me.cmdMissingOptions.Name = "cmdMissingOptions"
        Me.cmdMissingOptions.Size = New System.Drawing.Size(62, 26)
        Me.cmdMissingOptions.TabIndex = 27
        Me.cmdMissingOptions.Tag = "MissingOptions"
        Me.cmdMissingOptions.Text = "Options"
        Me.cmdMissingOptions.UseVisualStyleBackColor = True
        '
        'dlgOneVariableSummarise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(421, 402)
        Me.Controls.Add(Me.cmdMissingOptions)
        Me.Controls.Add(Me.rdoSkim)
        Me.Controls.Add(Me.ucrInputMarginName)
        Me.Controls.Add(Me.lblMarginName)
        Me.Controls.Add(Me.ucrChkDisplayMargins)
        Me.Controls.Add(Me.rdoCustomised)
        Me.Controls.Add(Me.rdoDefault)
        Me.Controls.Add(Me.ucrPnlSummaries)
        Me.Controls.Add(Me.ucrChkDisplaySummariesAsRows)
        Me.Controls.Add(Me.ucrChkDisplayVariablesAsRows)
        Me.Controls.Add(Me.ucrNudMaxSum)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.ucrSelectorOneVarSummarise)
        Me.Controls.Add(Me.ucrReceiverOneVarSummarise)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.lblMaxSum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneVariableSummarise"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "One_Variable_summarise"
        Me.Text = "One Variable Summarise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverOneVarSummarise As ucrReceiverMultiple
    Friend WithEvents ucrSelectorOneVarSummarise As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents lblMaxSum As Label
    Friend WithEvents ucrNudMaxSum As ucrNud
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents ucrChkDisplaySummariesAsRows As ucrCheck
    Friend WithEvents ucrChkDisplayVariablesAsRows As ucrCheck
    Friend WithEvents ucrPnlSummaries As UcrPanel
    Friend WithEvents rdoCustomised As RadioButton
    Friend WithEvents rdoDefault As RadioButton
    Friend WithEvents ucrInputMarginName As ucrInputTextBox
    Friend WithEvents lblMarginName As Label
    Friend WithEvents ucrChkDisplayMargins As ucrCheck
    Friend WithEvents rdoSkim As RadioButton
    Friend WithEvents cmdMissingOptions As Button
End Class