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
        Me.lblSummaries = New System.Windows.Forms.Label()
        Me.rdoDefault = New System.Windows.Forms.RadioButton()
        Me.rdoCustomised = New System.Windows.Forms.RadioButton()
        Me.ucrNudMaxSum = New instat.ucrNud()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrSelectorOneVarSummarise = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverOneVarSummarise = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlSummaries = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectedVariable.Location = New System.Drawing.Point(258, 46)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(142, 14)
        Me.lblSelectedVariable.TabIndex = 1
        Me.lblSelectedVariable.Tag = "Selected_Variable"
        Me.lblSelectedVariable.Text = "Variable(s) to Summarise:"
        '
        'lblMaxSum
        '
        Me.lblMaxSum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaxSum.Location = New System.Drawing.Point(10, 236)
        Me.lblMaxSum.Name = "lblMaxSum"
        Me.lblMaxSum.Size = New System.Drawing.Size(187, 19)
        Me.lblMaxSum.TabIndex = 7
        Me.lblMaxSum.Text = "Maximum Factor Levels Shown:"
        '
        'cmdSummaries
        '
        Me.cmdSummaries.AutoSize = True
        Me.cmdSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSummaries.Location = New System.Drawing.Point(261, 197)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(120, 23)
        Me.cmdSummaries.TabIndex = 6
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.Text = "Choose Summaries..."
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'lblSummaries
        '
        Me.lblSummaries.AutoSize = True
        Me.lblSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummaries.Location = New System.Drawing.Point(10, 205)
        Me.lblSummaries.Name = "lblSummaries"
        Me.lblSummaries.Size = New System.Drawing.Size(61, 13)
        Me.lblSummaries.TabIndex = 3
        Me.lblSummaries.Text = "Summaries:"
        '
        'rdoDefault
        '
        Me.rdoDefault.AutoSize = True
        Me.rdoDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDefault.Location = New System.Drawing.Point(79, 203)
        Me.rdoDefault.Name = "rdoDefault"
        Me.rdoDefault.Size = New System.Drawing.Size(59, 17)
        Me.rdoDefault.TabIndex = 4
        Me.rdoDefault.TabStop = True
        Me.rdoDefault.Text = "Default"
        Me.rdoDefault.UseVisualStyleBackColor = True
        '
        'rdoCustomised
        '
        Me.rdoCustomised.AutoSize = True
        Me.rdoCustomised.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCustomised.Location = New System.Drawing.Point(157, 203)
        Me.rdoCustomised.Name = "rdoCustomised"
        Me.rdoCustomised.Size = New System.Drawing.Size(79, 17)
        Me.rdoCustomised.TabIndex = 5
        Me.rdoCustomised.TabStop = True
        Me.rdoCustomised.Text = "Customised"
        Me.rdoCustomised.UseVisualStyleBackColor = True
        '
        'ucrNudMaxSum
        '
        Me.ucrNudMaxSum.AutoSize = True
        Me.ucrNudMaxSum.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxSum.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxSum.Location = New System.Drawing.Point(261, 235)
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
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(14, 235)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(241, 23)
        Me.ucrChkOmitMissing.TabIndex = 9
        '
        'ucrSelectorOneVarSummarise
        '
        Me.ucrSelectorOneVarSummarise.AutoSize = True
        Me.ucrSelectorOneVarSummarise.bDropUnusedFilterLevels = False
        Me.ucrSelectorOneVarSummarise.bShowHiddenColumns = False
        Me.ucrSelectorOneVarSummarise.bUseCurrentFilter = True
        Me.ucrSelectorOneVarSummarise.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorOneVarSummarise.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOneVarSummarise.Name = "ucrSelectorOneVarSummarise"
        Me.ucrSelectorOneVarSummarise.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorOneVarSummarise.TabIndex = 0
        '
        'ucrReceiverOneVarSummarise
        '
        Me.ucrReceiverOneVarSummarise.AutoSize = True
        Me.ucrReceiverOneVarSummarise.frmParent = Me
        Me.ucrReceiverOneVarSummarise.Location = New System.Drawing.Point(261, 60)
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
        Me.ucrBase.Location = New System.Drawing.Point(10, 273)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 11
        '
        'ucrPnlSummaries
        '
        Me.ucrPnlSummaries.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSummaries.Location = New System.Drawing.Point(10, 192)
        Me.ucrPnlSummaries.Name = "ucrPnlSummaries"
        Me.ucrPnlSummaries.Size = New System.Drawing.Size(352, 37)
        Me.ucrPnlSummaries.TabIndex = 12
        '
        'dlgOneVariableSummarise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(421, 327)
        Me.Controls.Add(Me.rdoCustomised)
        Me.Controls.Add(Me.rdoDefault)
        Me.Controls.Add(Me.lblSummaries)
        Me.Controls.Add(Me.ucrNudMaxSum)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.ucrSelectorOneVarSummarise)
        Me.Controls.Add(Me.ucrReceiverOneVarSummarise)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.ucrPnlSummaries)
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
    Friend WithEvents rdoCustomised As RadioButton
    Friend WithEvents rdoDefault As RadioButton
    Friend WithEvents lblSummaries As Label
    Friend WithEvents ucrPnlSummaries As UcrPanel
End Class