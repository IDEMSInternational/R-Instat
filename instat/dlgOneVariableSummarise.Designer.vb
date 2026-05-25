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
        Me.rdoSkim = New System.Windows.Forms.RadioButton()
        Me.cmdMissingOptions = New System.Windows.Forms.Button()
        Me.rdoNoColumnFactor = New System.Windows.Forms.RadioButton()
        Me.rdoVariable = New System.Windows.Forms.RadioButton()
        Me.rdoSummary = New System.Windows.Forms.RadioButton()
        Me.grpColumns = New System.Windows.Forms.GroupBox()
        Me.ucrPnlColumnFactor = New instat.UcrPanel()
        Me.ucrReorderSummary = New instat.ucrReorder()
        Me.ucrSaveSummary = New instat.ucrSave()
        Me.ucrPnlSummaries = New instat.UcrPanel()
        Me.ucrNudMaxSum = New instat.ucrNud()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrSelectorOneVarSummarise = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverOneVarSummarise = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkDisplayMissing = New instat.ucrCheck()
        Me.ucrInputDisplayMissing = New instat.ucrInputComboBox()
        Me.cmdTableOptions = New System.Windows.Forms.Button()
        Me.grpColumns.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectedVariable.Location = New System.Drawing.Point(299, 64)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(142, 14)
        Me.lblSelectedVariable.TabIndex = 1
        Me.lblSelectedVariable.Tag = "Selected_Variable"
        Me.lblSelectedVariable.Text = "Variable(s) to Summarise:"
        '
        'lblMaxSum
        '
        Me.lblMaxSum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxSum.Location = New System.Drawing.Point(10, 248)
        Me.lblMaxSum.Name = "lblMaxSum"
        Me.lblMaxSum.Size = New System.Drawing.Size(189, 24)
        Me.lblMaxSum.TabIndex = 7
        Me.lblMaxSum.Text = "Maximum Factor Levels Shown:"
        '
        'cmdSummaries
        '
        Me.cmdSummaries.AutoSize = True
        Me.cmdSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSummaries.Location = New System.Drawing.Point(301, 202)
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
        Me.rdoCustomised.Location = New System.Drawing.Point(268, 13)
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
        Me.rdoDefault.Location = New System.Drawing.Point(103, 13)
        Me.rdoDefault.Name = "rdoDefault"
        Me.rdoDefault.Size = New System.Drawing.Size(83, 27)
        Me.rdoDefault.TabIndex = 21
        Me.rdoDefault.TabStop = True
        Me.rdoDefault.Text = "Defaults"
        Me.rdoDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDefault.UseVisualStyleBackColor = True
        '
        'rdoSkim
        '
        Me.rdoSkim.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSkim.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSkim.FlatAppearance.BorderSize = 2
        Me.rdoSkim.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSkim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSkim.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSkim.Location = New System.Drawing.Point(183, 13)
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
        Me.cmdMissingOptions.Location = New System.Drawing.Point(201, 278)
        Me.cmdMissingOptions.Name = "cmdMissingOptions"
        Me.cmdMissingOptions.Size = New System.Drawing.Size(62, 26)
        Me.cmdMissingOptions.TabIndex = 27
        Me.cmdMissingOptions.Tag = "MissingOptions"
        Me.cmdMissingOptions.Text = "Options"
        Me.cmdMissingOptions.UseVisualStyleBackColor = True
        '
        'rdoNoColumnFactor
        '
        Me.rdoNoColumnFactor.AutoSize = True
        Me.rdoNoColumnFactor.Location = New System.Drawing.Point(8, 58)
        Me.rdoNoColumnFactor.Name = "rdoNoColumnFactor"
        Me.rdoNoColumnFactor.Size = New System.Drawing.Size(110, 17)
        Me.rdoNoColumnFactor.TabIndex = 30
        Me.rdoNoColumnFactor.TabStop = True
        Me.rdoNoColumnFactor.Text = "No Column Factor"
        Me.rdoNoColumnFactor.UseVisualStyleBackColor = True
        '
        'rdoVariable
        '
        Me.rdoVariable.AutoSize = True
        Me.rdoVariable.Location = New System.Drawing.Point(8, 37)
        Me.rdoVariable.Name = "rdoVariable"
        Me.rdoVariable.Size = New System.Drawing.Size(63, 17)
        Me.rdoVariable.TabIndex = 31
        Me.rdoVariable.TabStop = True
        Me.rdoVariable.Text = "Variable"
        Me.rdoVariable.UseVisualStyleBackColor = True
        '
        'rdoSummary
        '
        Me.rdoSummary.AutoSize = True
        Me.rdoSummary.Location = New System.Drawing.Point(8, 16)
        Me.rdoSummary.Name = "rdoSummary"
        Me.rdoSummary.Size = New System.Drawing.Size(68, 17)
        Me.rdoSummary.TabIndex = 32
        Me.rdoSummary.TabStop = True
        Me.rdoSummary.Text = "Summary"
        Me.rdoSummary.UseVisualStyleBackColor = True
        '
        'grpColumns
        '
        Me.grpColumns.Controls.Add(Me.rdoNoColumnFactor)
        Me.grpColumns.Controls.Add(Me.rdoVariable)
        Me.grpColumns.Controls.Add(Me.rdoSummary)
        Me.grpColumns.Controls.Add(Me.ucrPnlColumnFactor)
        Me.grpColumns.Location = New System.Drawing.Point(2, 324)
        Me.grpColumns.Name = "grpColumns"
        Me.grpColumns.Size = New System.Drawing.Size(200, 83)
        Me.grpColumns.TabIndex = 33
        Me.grpColumns.TabStop = False
        Me.grpColumns.Text = "Columns:"
        '
        'ucrPnlColumnFactor
        '
        Me.ucrPnlColumnFactor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlColumnFactor.Location = New System.Drawing.Point(6, 12)
        Me.ucrPnlColumnFactor.Name = "ucrPnlColumnFactor"
        Me.ucrPnlColumnFactor.Size = New System.Drawing.Size(162, 65)
        Me.ucrPnlColumnFactor.TabIndex = 29
        '
        'ucrReorderSummary
        '
        Me.ucrReorderSummary.AutoSize = True
        Me.ucrReorderSummary.Location = New System.Drawing.Point(267, 231)
        Me.ucrReorderSummary.Name = "ucrReorderSummary"
        Me.ucrReorderSummary.Size = New System.Drawing.Size(200, 156)
        Me.ucrReorderSummary.TabIndex = 36
        Me.ucrReorderSummary.ucrDataFrameList = Nothing
        Me.ucrReorderSummary.ucrReceiver = Nothing
        '
        'ucrSaveSummary
        '
        Me.ucrSaveSummary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveSummary.Location = New System.Drawing.Point(10, 418)
        Me.ucrSaveSummary.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveSummary.Name = "ucrSaveSummary"
        Me.ucrSaveSummary.Size = New System.Drawing.Size(406, 24)
        Me.ucrSaveSummary.TabIndex = 28
        '
        'ucrPnlSummaries
        '
        Me.ucrPnlSummaries.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSummaries.Location = New System.Drawing.Point(82, 11)
        Me.ucrPnlSummaries.Name = "ucrPnlSummaries"
        Me.ucrPnlSummaries.Size = New System.Drawing.Size(286, 29)
        Me.ucrPnlSummaries.TabIndex = 20
        '
        'ucrNudMaxSum
        '
        Me.ucrNudMaxSum.AutoSize = True
        Me.ucrNudMaxSum.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxSum.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxSum.Location = New System.Drawing.Point(224, 249)
        Me.ucrNudMaxSum.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxSum.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxSum.Name = "ucrNudMaxSum"
        Me.ucrNudMaxSum.Size = New System.Drawing.Size(57, 20)
        Me.ucrNudMaxSum.TabIndex = 8
        Me.ucrNudMaxSum.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.AutoSize = True
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(8, 280)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(187, 23)
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
        Me.ucrReceiverOneVarSummarise.Location = New System.Drawing.Point(301, 78)
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
        Me.ucrBase.Location = New System.Drawing.Point(9, 444)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 11
        '
        'ucrChkDisplayMissing
        '
        Me.ucrChkDisplayMissing.AutoSize = True
        Me.ucrChkDisplayMissing.Checked = False
        Me.ucrChkDisplayMissing.Enabled = False
        Me.ucrChkDisplayMissing.Location = New System.Drawing.Point(8, 247)
        Me.ucrChkDisplayMissing.Name = "ucrChkDisplayMissing"
        Me.ucrChkDisplayMissing.Size = New System.Drawing.Size(173, 23)
        Me.ucrChkDisplayMissing.TabIndex = 34
        '
        'ucrInputDisplayMissing
        '
        Me.ucrInputDisplayMissing.AddQuotesIfUnrecognised = True
        Me.ucrInputDisplayMissing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDisplayMissing.GetSetSelectedIndex = -1
        Me.ucrInputDisplayMissing.IsReadOnly = False
        Me.ucrInputDisplayMissing.Location = New System.Drawing.Point(189, 248)
        Me.ucrInputDisplayMissing.Name = "ucrInputDisplayMissing"
        Me.ucrInputDisplayMissing.Size = New System.Drawing.Size(74, 21)
        Me.ucrInputDisplayMissing.TabIndex = 35
        '
        'cmdTableOptions
        '
        Me.cmdTableOptions.AutoSize = True
        Me.cmdTableOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTableOptions.Location = New System.Drawing.Point(302, 393)
        Me.cmdTableOptions.Name = "cmdTableOptions"
        Me.cmdTableOptions.Size = New System.Drawing.Size(114, 23)
        Me.cmdTableOptions.TabIndex = 38
        Me.cmdTableOptions.Tag = "Format Table"
        Me.cmdTableOptions.Text = "Table Options..."
        Me.cmdTableOptions.UseVisualStyleBackColor = True
        '
        'dlgOneVariableSummarise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(470, 495)
        Me.Controls.Add(Me.cmdTableOptions)
        Me.Controls.Add(Me.ucrReorderSummary)
        Me.Controls.Add(Me.ucrSaveSummary)
        Me.Controls.Add(Me.cmdMissingOptions)
        Me.Controls.Add(Me.rdoSkim)
        Me.Controls.Add(Me.rdoCustomised)
        Me.Controls.Add(Me.rdoDefault)
        Me.Controls.Add(Me.ucrPnlSummaries)
        Me.Controls.Add(Me.ucrNudMaxSum)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.ucrSelectorOneVarSummarise)
        Me.Controls.Add(Me.ucrReceiverOneVarSummarise)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.lblMaxSum)
        Me.Controls.Add(Me.grpColumns)
        Me.Controls.Add(Me.ucrChkDisplayMissing)
        Me.Controls.Add(Me.ucrInputDisplayMissing)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneVariableSummarise"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "One_Variable_summarise"
        Me.Text = "One Variable Summarise"
        Me.grpColumns.ResumeLayout(False)
        Me.grpColumns.PerformLayout()
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
    Friend WithEvents ucrPnlSummaries As UcrPanel
    Friend WithEvents rdoCustomised As RadioButton
    Friend WithEvents rdoDefault As RadioButton
    Friend WithEvents rdoSkim As RadioButton
    Friend WithEvents cmdMissingOptions As Button
    Friend WithEvents ucrSaveSummary As ucrSave
    Friend WithEvents rdoNoColumnFactor As RadioButton
    Friend WithEvents ucrPnlColumnFactor As UcrPanel
    Friend WithEvents rdoSummary As RadioButton
    Friend WithEvents rdoVariable As RadioButton
    Friend WithEvents ucrInputDisplayMissing As ucrInputComboBox
    Friend WithEvents ucrChkDisplayMissing As ucrCheck
    Friend WithEvents grpColumns As GroupBox
    Friend WithEvents ucrReorderSummary As ucrReorder
    Friend WithEvents cmdTableOptions As Button
End Class