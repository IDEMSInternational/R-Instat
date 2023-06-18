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
Partial Class dlgRecodeNumeric
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
        Me.components = New System.ComponentModel.Container()
        Me.ucrReceiverRecode = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.rdoBreakPoints = New System.Windows.Forms.RadioButton()
        Me.rdoMinimum = New System.Windows.Forms.RadioButton()
        Me.rdoLevels = New System.Windows.Forms.RadioButton()
        Me.ucrMultipleNumericRecode = New instat.ucrInputTextBox()
        Me.ucrNudMinimum = New instat.ucrNud()
        Me.ucrNudLevels = New instat.ucrNud()
        Me.ucrChkAddLabels = New instat.ucrCheck()
        Me.ucrSaveRecode = New instat.ucrSave()
        Me.ttMinimum = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrPnlRadioButtons = New instat.UcrPanel()
        Me.ucrSelectorForRecode = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpQuantileGroups = New System.Windows.Forms.GroupBox()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.ttBreakpoint = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttLevels = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpQuantileGroups.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrReceiverRecode
        '
        Me.ucrReceiverRecode.AutoSize = True
        Me.ucrReceiverRecode.frmParent = Me
        Me.ucrReceiverRecode.Location = New System.Drawing.Point(232, 59)
        Me.ucrReceiverRecode.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRecode.Name = "ucrReceiverRecode"
        Me.ucrReceiverRecode.Selector = Nothing
        Me.ucrReceiverRecode.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRecode.strNcFilePath = ""
        Me.ucrReceiverRecode.TabIndex = 9
        Me.ucrReceiverRecode.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(5, 254)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 13
        '
        'rdoBreakPoints
        '
        Me.rdoBreakPoints.AutoSize = True
        Me.rdoBreakPoints.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBreakPoints.Location = New System.Drawing.Point(6, 71)
        Me.rdoBreakPoints.Name = "rdoBreakPoints"
        Me.rdoBreakPoints.Size = New System.Drawing.Size(88, 17)
        Me.rdoBreakPoints.TabIndex = 30
        Me.rdoBreakPoints.TabStop = True
        Me.rdoBreakPoints.Text = "Break Points:"
        Me.rdoBreakPoints.UseVisualStyleBackColor = True
        '
        'rdoMinimum
        '
        Me.rdoMinimum.AutoSize = True
        Me.rdoMinimum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMinimum.Location = New System.Drawing.Point(6, 48)
        Me.rdoMinimum.Name = "rdoMinimum"
        Me.rdoMinimum.Size = New System.Drawing.Size(69, 17)
        Me.rdoMinimum.TabIndex = 29
        Me.rdoMinimum.TabStop = True
        Me.rdoMinimum.Text = "Minimum:"
        Me.rdoMinimum.UseVisualStyleBackColor = True
        '
        'rdoLevels
        '
        Me.rdoLevels.AutoSize = True
        Me.rdoLevels.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLevels.Location = New System.Drawing.Point(6, 25)
        Me.rdoLevels.Name = "rdoLevels"
        Me.rdoLevels.Size = New System.Drawing.Size(59, 17)
        Me.rdoLevels.TabIndex = 28
        Me.rdoLevels.TabStop = True
        Me.rdoLevels.Text = "Levels:"
        Me.rdoLevels.UseVisualStyleBackColor = True
        '
        'ucrMultipleNumericRecode
        '
        Me.ucrMultipleNumericRecode.AddQuotesIfUnrecognised = True
        Me.ucrMultipleNumericRecode.AutoSize = True
        Me.ucrMultipleNumericRecode.IsMultiline = False
        Me.ucrMultipleNumericRecode.IsReadOnly = False
        Me.ucrMultipleNumericRecode.Location = New System.Drawing.Point(99, 71)
        Me.ucrMultipleNumericRecode.Name = "ucrMultipleNumericRecode"
        Me.ucrMultipleNumericRecode.Size = New System.Drawing.Size(120, 21)
        Me.ucrMultipleNumericRecode.TabIndex = 4
        '
        'ucrNudMinimum
        '
        Me.ucrNudMinimum.AutoSize = True
        Me.ucrNudMinimum.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinimum.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinimum.Location = New System.Drawing.Point(99, 45)
        Me.ucrNudMinimum.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinimum.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinimum.Name = "ucrNudMinimum"
        Me.ucrNudMinimum.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinimum.TabIndex = 23
        Me.ucrNudMinimum.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLevels
        '
        Me.ucrNudLevels.AutoSize = True
        Me.ucrNudLevels.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLevels.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLevels.Location = New System.Drawing.Point(99, 22)
        Me.ucrNudLevels.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLevels.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLevels.Name = "ucrNudLevels"
        Me.ucrNudLevels.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLevels.TabIndex = 22
        Me.ucrNudLevels.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkAddLabels
        '
        Me.ucrChkAddLabels.AutoSize = True
        Me.ucrChkAddLabels.Checked = False
        Me.ucrChkAddLabels.Location = New System.Drawing.Point(5, 201)
        Me.ucrChkAddLabels.Name = "ucrChkAddLabels"
        Me.ucrChkAddLabels.Size = New System.Drawing.Size(149, 23)
        Me.ucrChkAddLabels.TabIndex = 11
        '
        'ucrSaveRecode
        '
        Me.ucrSaveRecode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveRecode.Location = New System.Drawing.Point(5, 229)
        Me.ucrSaveRecode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveRecode.Name = "ucrSaveRecode"
        Me.ucrSaveRecode.Size = New System.Drawing.Size(328, 22)
        Me.ucrSaveRecode.TabIndex = 12
        '
        'ucrPnlRadioButtons
        '
        Me.ucrPnlRadioButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlRadioButtons.Location = New System.Drawing.Point(5, 19)
        Me.ucrPnlRadioButtons.Name = "ucrPnlRadioButtons"
        Me.ucrPnlRadioButtons.Size = New System.Drawing.Size(213, 73)
        Me.ucrPnlRadioButtons.TabIndex = 27
        '
        'ucrSelectorForRecode
        '
        Me.ucrSelectorForRecode.AutoSize = True
        Me.ucrSelectorForRecode.bDropUnusedFilterLevels = False
        Me.ucrSelectorForRecode.bShowHiddenColumns = False
        Me.ucrSelectorForRecode.bUseCurrentFilter = True
        Me.ucrSelectorForRecode.Location = New System.Drawing.Point(5, 10)
        Me.ucrSelectorForRecode.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForRecode.Name = "ucrSelectorForRecode"
        Me.ucrSelectorForRecode.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForRecode.TabIndex = 7
        '
        'grpQuantileGroups
        '
        Me.grpQuantileGroups.Controls.Add(Me.rdoBreakPoints)
        Me.grpQuantileGroups.Controls.Add(Me.rdoMinimum)
        Me.grpQuantileGroups.Controls.Add(Me.rdoLevels)
        Me.grpQuantileGroups.Controls.Add(Me.ucrMultipleNumericRecode)
        Me.grpQuantileGroups.Controls.Add(Me.ucrNudMinimum)
        Me.grpQuantileGroups.Controls.Add(Me.ucrNudLevels)
        Me.grpQuantileGroups.Controls.Add(Me.ucrPnlRadioButtons)
        Me.grpQuantileGroups.Location = New System.Drawing.Point(233, 84)
        Me.grpQuantileGroups.Name = "grpQuantileGroups"
        Me.grpQuantileGroups.Size = New System.Drawing.Size(226, 106)
        Me.grpQuantileGroups.TabIndex = 10
        Me.grpQuantileGroups.TabStop = False
        Me.grpQuantileGroups.Text = "Groups"
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectedVariable.Location = New System.Drawing.Point(235, 44)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(93, 13)
        Me.lblSelectedVariable.TabIndex = 8
        Me.lblSelectedVariable.Tag = "Selected_Variable"
        Me.lblSelectedVariable.Text = "Selected Variable:"
        '
        'dlgRecodeNumeric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(463, 316)
        Me.Controls.Add(Me.ucrReceiverRecode)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrChkAddLabels)
        Me.Controls.Add(Me.ucrSaveRecode)
        Me.Controls.Add(Me.ucrSelectorForRecode)
        Me.Controls.Add(Me.grpQuantileGroups)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRecodeNumeric"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Recode_Numeric"
        Me.Text = "Recode Numeric"
        Me.grpQuantileGroups.ResumeLayout(False)
        Me.grpQuantileGroups.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrReceiverRecode As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkAddLabels As ucrCheck
    Friend WithEvents ucrSaveRecode As ucrSave
    Friend WithEvents ucrSelectorForRecode As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpQuantileGroups As GroupBox
    Friend WithEvents rdoBreakPoints As RadioButton
    Friend WithEvents rdoMinimum As RadioButton
    Friend WithEvents rdoLevels As RadioButton
    Friend WithEvents ucrMultipleNumericRecode As ucrInputTextBox
    Friend WithEvents ucrNudMinimum As ucrNud
    Friend WithEvents ucrNudLevels As ucrNud
    Friend WithEvents ucrPnlRadioButtons As UcrPanel
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ttMinimum As ToolTip
    Friend WithEvents ttBreakpoint As ToolTip
    Friend WithEvents ttLevels As ToolTip
End Class
