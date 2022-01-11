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
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.lblBreakPoints = New System.Windows.Forms.Label()
        Me.grpClosedOn = New System.Windows.Forms.GroupBox()
        Me.rdoRight = New System.Windows.Forms.RadioButton()
        Me.rdoLeft = New System.Windows.Forms.RadioButton()
        Me.ucrPnlClosedOn = New instat.UcrPanel()
        Me.ucrSaveRecode = New instat.ucrSave()
        Me.ucrMultipleNumericRecode = New instat.ucrInputTextBox()
        Me.ucrInputMultipleLabels = New instat.ucrInputTextBox()
        Me.ucrReceiverRecode = New instat.ucrReceiverSingle()
        Me.ucrSelectorForRecode = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkAddLabels = New instat.ucrCheck()
        Me.grpClosedOn.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectedVariable.Location = New System.Drawing.Point(249, 46)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(93, 13)
        Me.lblSelectedVariable.TabIndex = 1
        Me.lblSelectedVariable.Tag = "Selected_Variable"
        Me.lblSelectedVariable.Text = "Selected Variable:"
        '
        'lblBreakPoints
        '
        Me.lblBreakPoints.AutoSize = True
        Me.lblBreakPoints.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBreakPoints.Location = New System.Drawing.Point(249, 92)
        Me.lblBreakPoints.Name = "lblBreakPoints"
        Me.lblBreakPoints.Size = New System.Drawing.Size(70, 13)
        Me.lblBreakPoints.TabIndex = 3
        Me.lblBreakPoints.Tag = "Break_Points"
        Me.lblBreakPoints.Text = "Break Points:"
        '
        'grpClosedOn
        '
        Me.grpClosedOn.Controls.Add(Me.rdoRight)
        Me.grpClosedOn.Controls.Add(Me.rdoLeft)
        Me.grpClosedOn.Controls.Add(Me.ucrPnlClosedOn)
        Me.grpClosedOn.Location = New System.Drawing.Point(247, 134)
        Me.grpClosedOn.Name = "grpClosedOn"
        Me.grpClosedOn.Size = New System.Drawing.Size(146, 89)
        Me.grpClosedOn.TabIndex = 5
        Me.grpClosedOn.TabStop = False
        Me.grpClosedOn.Tag = "Closed_On"
        Me.grpClosedOn.Text = "Closed On"
        '
        'rdoRight
        '
        Me.rdoRight.AutoSize = True
        Me.rdoRight.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRight.Location = New System.Drawing.Point(6, 48)
        Me.rdoRight.Name = "rdoRight"
        Me.rdoRight.Size = New System.Drawing.Size(50, 17)
        Me.rdoRight.TabIndex = 23
        Me.rdoRight.TabStop = True
        Me.rdoRight.Text = "Right"
        Me.rdoRight.UseVisualStyleBackColor = True
        '
        'rdoLeft
        '
        Me.rdoLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLeft.Location = New System.Drawing.Point(6, 25)
        Me.rdoLeft.Name = "rdoLeft"
        Me.rdoLeft.Size = New System.Drawing.Size(90, 17)
        Me.rdoLeft.TabIndex = 0
        Me.rdoLeft.TabStop = True
        Me.rdoLeft.Text = "Left"
        Me.rdoLeft.UseVisualStyleBackColor = True
        '
        'ucrPnlClosedOn
        '
        Me.ucrPnlClosedOn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlClosedOn.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlClosedOn.Name = "ucrPnlClosedOn"
        Me.ucrPnlClosedOn.Size = New System.Drawing.Size(128, 59)
        Me.ucrPnlClosedOn.TabIndex = 21
        '
        'ucrSaveRecode
        '
        Me.ucrSaveRecode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveRecode.Location = New System.Drawing.Point(9, 232)
        Me.ucrSaveRecode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveRecode.Name = "ucrSaveRecode"
        Me.ucrSaveRecode.Size = New System.Drawing.Size(328, 22)
        Me.ucrSaveRecode.TabIndex = 20
        '
        'ucrMultipleNumericRecode
        '
        Me.ucrMultipleNumericRecode.AddQuotesIfUnrecognised = True
        Me.ucrMultipleNumericRecode.AutoSize = True
        Me.ucrMultipleNumericRecode.IsMultiline = False
        Me.ucrMultipleNumericRecode.IsReadOnly = False
        Me.ucrMultipleNumericRecode.Location = New System.Drawing.Point(247, 107)
        Me.ucrMultipleNumericRecode.Name = "ucrMultipleNumericRecode"
        Me.ucrMultipleNumericRecode.Size = New System.Drawing.Size(120, 21)
        Me.ucrMultipleNumericRecode.TabIndex = 4
        '
        'ucrInputMultipleLabels
        '
        Me.ucrInputMultipleLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputMultipleLabels.AutoSize = True
        Me.ucrInputMultipleLabels.IsMultiline = False
        Me.ucrInputMultipleLabels.IsReadOnly = False
        Me.ucrInputMultipleLabels.Location = New System.Drawing.Point(118, 203)
        Me.ucrInputMultipleLabels.Name = "ucrInputMultipleLabels"
        Me.ucrInputMultipleLabels.Size = New System.Drawing.Size(123, 21)
        Me.ucrInputMultipleLabels.TabIndex = 7
        '
        'ucrReceiverRecode
        '
        Me.ucrReceiverRecode.AutoSize = True
        Me.ucrReceiverRecode.frmParent = Me
        Me.ucrReceiverRecode.Location = New System.Drawing.Point(247, 61)
        Me.ucrReceiverRecode.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRecode.Name = "ucrReceiverRecode"
        Me.ucrReceiverRecode.Selector = Nothing
        Me.ucrReceiverRecode.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRecode.strNcFilePath = ""
        Me.ucrReceiverRecode.TabIndex = 2
        Me.ucrReceiverRecode.ucrSelector = Nothing
        '
        'ucrSelectorForRecode
        '
        Me.ucrSelectorForRecode.AutoSize = True
        Me.ucrSelectorForRecode.bDropUnusedFilterLevels = False
        Me.ucrSelectorForRecode.bShowHiddenColumns = False
        Me.ucrSelectorForRecode.bUseCurrentFilter = True
        Me.ucrSelectorForRecode.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForRecode.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForRecode.Name = "ucrSelectorForRecode"
        Me.ucrSelectorForRecode.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForRecode.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 261)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 10
        '
        'ucrChkAddLabels
        '
        Me.ucrChkAddLabels.AutoSize = True
        Me.ucrChkAddLabels.Checked = False
        Me.ucrChkAddLabels.Location = New System.Drawing.Point(12, 204)
        Me.ucrChkAddLabels.Name = "ucrChkAddLabels"
        Me.ucrChkAddLabels.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkAddLabels.TabIndex = 21
        '
        'dlgRecodeNumeric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(418, 316)
        Me.Controls.Add(Me.ucrChkAddLabels)
        Me.Controls.Add(Me.ucrSaveRecode)
        Me.Controls.Add(Me.ucrMultipleNumericRecode)
        Me.Controls.Add(Me.ucrInputMultipleLabels)
        Me.Controls.Add(Me.grpClosedOn)
        Me.Controls.Add(Me.lblBreakPoints)
        Me.Controls.Add(Me.ucrReceiverRecode)
        Me.Controls.Add(Me.ucrSelectorForRecode)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRecodeNumeric"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Recode_Numeric"
        Me.Text = "Recode Numeric"
        Me.grpClosedOn.ResumeLayout(False)
        Me.grpClosedOn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrSelectorForRecode As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRecode As ucrReceiverSingle
    Friend WithEvents lblBreakPoints As Label
    Friend WithEvents grpClosedOn As GroupBox
    Friend WithEvents ucrInputMultipleLabels As ucrInputTextBox
    Friend WithEvents ucrMultipleNumericRecode As ucrInputTextBox
    Friend WithEvents ucrSaveRecode As ucrSave
    Friend WithEvents ucrPnlClosedOn As UcrPanel
    Friend WithEvents rdoRight As RadioButton
    Friend WithEvents rdoLeft As RadioButton
    Friend WithEvents ucrChkAddLabels As ucrCheck
End Class
