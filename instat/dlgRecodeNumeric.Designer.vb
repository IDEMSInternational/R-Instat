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
        Me.chkAddLabels = New System.Windows.Forms.CheckBox()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.lblBreakPoints = New System.Windows.Forms.Label()
        Me.grpClosedOn = New System.Windows.Forms.GroupBox()
        Me.rdoLeft = New System.Windows.Forms.RadioButton()
        Me.rdoRight = New System.Windows.Forms.RadioButton()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrInputRecode = New instat.ucrInputComboBox()
        Me.ucrReceiverRecode = New instat.ucrReceiverSingle()
        Me.ucrSelectorForRecode = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrMultipleLabels = New instat.ucrInputTextBox()
        Me.ucrMultipleNumericRecode = New instat.ucrInputTextBox()
        Me.grpClosedOn.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkAddLabels
        '
        Me.chkAddLabels.AutoSize = True
        Me.chkAddLabels.Location = New System.Drawing.Point(10, 206)
        Me.chkAddLabels.Name = "chkAddLabels"
        Me.chkAddLabels.Size = New System.Drawing.Size(79, 17)
        Me.chkAddLabels.TabIndex = 6
        Me.chkAddLabels.Tag = "Add_Labels"
        Me.chkAddLabels.Text = "Add Labels"
        Me.chkAddLabels.UseVisualStyleBackColor = True
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
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
        Me.lblBreakPoints.Location = New System.Drawing.Point(249, 92)
        Me.lblBreakPoints.Name = "lblBreakPoints"
        Me.lblBreakPoints.Size = New System.Drawing.Size(70, 13)
        Me.lblBreakPoints.TabIndex = 3
        Me.lblBreakPoints.Tag = "Break_Points"
        Me.lblBreakPoints.Text = "Break Points:"
        '
        'grpClosedOn
        '
        Me.grpClosedOn.Controls.Add(Me.rdoLeft)
        Me.grpClosedOn.Controls.Add(Me.rdoRight)
        Me.grpClosedOn.Location = New System.Drawing.Point(247, 134)
        Me.grpClosedOn.Name = "grpClosedOn"
        Me.grpClosedOn.Size = New System.Drawing.Size(120, 66)
        Me.grpClosedOn.TabIndex = 5
        Me.grpClosedOn.TabStop = False
        Me.grpClosedOn.Tag = "Closed_On"
        Me.grpClosedOn.Text = "Closed On"
        '
        'rdoLeft
        '
        Me.rdoLeft.AutoSize = True
        Me.rdoLeft.Location = New System.Drawing.Point(7, 20)
        Me.rdoLeft.Name = "rdoLeft"
        Me.rdoLeft.Size = New System.Drawing.Size(43, 17)
        Me.rdoLeft.TabIndex = 0
        Me.rdoLeft.Tag = "Left"
        Me.rdoLeft.Text = "Left"
        Me.rdoLeft.UseVisualStyleBackColor = True
        '
        'rdoRight
        '
        Me.rdoRight.AutoSize = True
        Me.rdoRight.Location = New System.Drawing.Point(7, 43)
        Me.rdoRight.Name = "rdoRight"
        Me.rdoRight.Size = New System.Drawing.Size(50, 17)
        Me.rdoRight.TabIndex = 1
        Me.rdoRight.Tag = "Right"
        Me.rdoRight.Text = "Right"
        Me.rdoRight.UseVisualStyleBackColor = True
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(7, 237)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(101, 13)
        Me.lblNewColumnName.TabIndex = 8
        Me.lblNewColumnName.Tag = "New_Column_Name:"
        Me.lblNewColumnName.Text = "New Column Name:"
        '
        'ucrInputRecode
        '
        Me.ucrInputRecode.IsReadOnly = False
        Me.ucrInputRecode.Location = New System.Drawing.Point(114, 233)
        Me.ucrInputRecode.Name = "ucrInputRecode"
        Me.ucrInputRecode.Size = New System.Drawing.Size(145, 21)
        Me.ucrInputRecode.TabIndex = 9
        '
        'ucrReceiverRecode
        '
        Me.ucrReceiverRecode.Location = New System.Drawing.Point(247, 61)
        Me.ucrReceiverRecode.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRecode.Name = "ucrReceiverRecode"
        Me.ucrReceiverRecode.Selector = Nothing
        Me.ucrReceiverRecode.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRecode.TabIndex = 2
        '
        'ucrSelectorForRecode
        '
        Me.ucrSelectorForRecode.bShowHiddenColumns = False
        Me.ucrSelectorForRecode.bUseCurrentFilter = True
        Me.ucrSelectorForRecode.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForRecode.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForRecode.Name = "ucrSelectorForRecode"
        Me.ucrSelectorForRecode.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForRecode.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 261)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 10
        '
        'ucrMultipleLabels
        '
        Me.ucrMultipleLabels.IsReadOnly = False
        Me.ucrMultipleLabels.Location = New System.Drawing.Point(114, 206)
        Me.ucrMultipleLabels.Name = "ucrMultipleLabels"
        Me.ucrMultipleLabels.Size = New System.Drawing.Size(145, 21)
        Me.ucrMultipleLabels.TabIndex = 7
        '
        'ucrMultipleNumericRecode
        '
        Me.ucrMultipleNumericRecode.IsReadOnly = False
        Me.ucrMultipleNumericRecode.Location = New System.Drawing.Point(247, 107)
        Me.ucrMultipleNumericRecode.Name = "ucrMultipleNumericRecode"
        Me.ucrMultipleNumericRecode.Size = New System.Drawing.Size(120, 21)
        Me.ucrMultipleNumericRecode.TabIndex = 4
        '
        'dlgRecodeNumeric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 316)
        Me.Controls.Add(Me.ucrMultipleNumericRecode)
        Me.Controls.Add(Me.ucrMultipleLabels)
        Me.Controls.Add(Me.ucrInputRecode)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.grpClosedOn)
        Me.Controls.Add(Me.lblBreakPoints)
        Me.Controls.Add(Me.ucrReceiverRecode)
        Me.Controls.Add(Me.ucrSelectorForRecode)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.chkAddLabels)
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
    Friend WithEvents chkAddLabels As CheckBox
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrSelectorForRecode As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRecode As ucrReceiverSingle
    Friend WithEvents lblBreakPoints As Label
    Friend WithEvents grpClosedOn As GroupBox
    Friend WithEvents rdoLeft As RadioButton
    Friend WithEvents rdoRight As RadioButton
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents ucrInputRecode As ucrInputComboBox
    Friend WithEvents ucrMultipleLabels As ucrInputTextBox
    Friend WithEvents ucrMultipleNumericRecode As ucrInputTextBox
End Class
