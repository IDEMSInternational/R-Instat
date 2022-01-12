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
Partial Class sdgRestrict
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
        Me.ucrSubDialogBase = New instat.ucrButtonsSubdialogue()
        Me.tbcOptions = New System.Windows.Forms.TabControl()
        Me.tbpFactor_Level = New System.Windows.Forms.TabPage()
        Me.tbpCondition = New System.Windows.Forms.TabPage()
        Me.rdoExclude = New System.Windows.Forms.RadioButton()
        Me.rdoInclude = New System.Windows.Forms.RadioButton()
        Me.lblSelectedColumn = New System.Windows.Forms.Label()
        Me.ucrReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelector = New instat.ucrSelectorAddRemove()
        Me.txtGreaterThan = New System.Windows.Forms.TextBox()
        Me.txtEqualTo = New System.Windows.Forms.TextBox()
        Me.txtLessThan = New System.Windows.Forms.TextBox()
        Me.rdoGreaterThan = New System.Windows.Forms.RadioButton()
        Me.rdoEqualTo = New System.Windows.Forms.RadioButton()
        Me.rdoLessThan = New System.Windows.Forms.RadioButton()
        Me.tbcOptions.SuspendLayout()
        Me.tbpCondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSubDialogBase
        '
        Me.ucrSubDialogBase.AutoSize = True
        Me.ucrSubDialogBase.Location = New System.Drawing.Point(48, 259)
        Me.ucrSubDialogBase.Name = "ucrSubDialogBase"
        Me.ucrSubDialogBase.Size = New System.Drawing.Size(225, 30)
        Me.ucrSubDialogBase.TabIndex = 1
        '
        'tbcOptions
        '
        Me.tbcOptions.Controls.Add(Me.tbpFactor_Level)
        Me.tbcOptions.Controls.Add(Me.tbpCondition)
        Me.tbcOptions.Location = New System.Drawing.Point(12, 13)
        Me.tbcOptions.Name = "tbcOptions"
        Me.tbcOptions.SelectedIndex = 0
        Me.tbcOptions.Size = New System.Drawing.Size(353, 239)
        Me.tbcOptions.TabIndex = 2
        Me.tbcOptions.Tag = ""
        '
        'tbpFactor_Level
        '
        Me.tbpFactor_Level.Location = New System.Drawing.Point(4, 22)
        Me.tbpFactor_Level.Name = "tbpFactor_Level"
        Me.tbpFactor_Level.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpFactor_Level.Size = New System.Drawing.Size(345, 213)
        Me.tbpFactor_Level.TabIndex = 0
        Me.tbpFactor_Level.Tag = "Factor_Level"
        Me.tbpFactor_Level.Text = "Factor Level"
        Me.tbpFactor_Level.UseVisualStyleBackColor = True
        '
        'tbpCondition
        '
        Me.tbpCondition.Controls.Add(Me.rdoExclude)
        Me.tbpCondition.Controls.Add(Me.rdoInclude)
        Me.tbpCondition.Controls.Add(Me.lblSelectedColumn)
        Me.tbpCondition.Controls.Add(Me.ucrReceiver)
        Me.tbpCondition.Controls.Add(Me.ucrSelector)
        Me.tbpCondition.Controls.Add(Me.txtGreaterThan)
        Me.tbpCondition.Controls.Add(Me.txtEqualTo)
        Me.tbpCondition.Controls.Add(Me.txtLessThan)
        Me.tbpCondition.Controls.Add(Me.rdoGreaterThan)
        Me.tbpCondition.Controls.Add(Me.rdoEqualTo)
        Me.tbpCondition.Controls.Add(Me.rdoLessThan)
        Me.tbpCondition.Location = New System.Drawing.Point(4, 22)
        Me.tbpCondition.Name = "tbpCondition"
        Me.tbpCondition.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCondition.Size = New System.Drawing.Size(345, 213)
        Me.tbpCondition.TabIndex = 1
        Me.tbpCondition.Tag = "Condition"
        Me.tbpCondition.Text = "Condition"
        Me.tbpCondition.UseVisualStyleBackColor = True
        '
        'rdoExclude
        '
        Me.rdoExclude.AutoSize = True
        Me.rdoExclude.Location = New System.Drawing.Point(279, 75)
        Me.rdoExclude.Name = "rdoExclude"
        Me.rdoExclude.Size = New System.Drawing.Size(63, 17)
        Me.rdoExclude.TabIndex = 6
        Me.rdoExclude.TabStop = True
        Me.rdoExclude.Tag = "Exclude"
        Me.rdoExclude.Text = "Exclude"
        Me.rdoExclude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoExclude.UseVisualStyleBackColor = True
        '
        'rdoInclude
        '
        Me.rdoInclude.AutoSize = True
        Me.rdoInclude.Location = New System.Drawing.Point(222, 75)
        Me.rdoInclude.Name = "rdoInclude"
        Me.rdoInclude.Size = New System.Drawing.Size(60, 17)
        Me.rdoInclude.TabIndex = 6
        Me.rdoInclude.TabStop = True
        Me.rdoInclude.Tag = "Include"
        Me.rdoInclude.Text = "Include"
        Me.rdoInclude.UseVisualStyleBackColor = True
        '
        'lblSelectedColumn
        '
        Me.lblSelectedColumn.AutoSize = True
        Me.lblSelectedColumn.Location = New System.Drawing.Point(233, 12)
        Me.lblSelectedColumn.Name = "lblSelectedColumn"
        Me.lblSelectedColumn.Size = New System.Drawing.Size(87, 13)
        Me.lblSelectedColumn.TabIndex = 5
        Me.lblSelectedColumn.Tag = "Selected_Column"
        Me.lblSelectedColumn.Text = "Selected Column"
        '
        'ucrReceiver
        '
        Me.ucrReceiver.AutoSize = True
        Me.ucrReceiver.frmParent = Nothing
        Me.ucrReceiver.Location = New System.Drawing.Point(233, 31)
        Me.ucrReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiver.Name = "ucrReceiver"
        Me.ucrReceiver.Selector = Nothing
        Me.ucrReceiver.Size = New System.Drawing.Size(112, 26)
        Me.ucrReceiver.strNcFilePath = ""
        Me.ucrReceiver.TabIndex = 4
        Me.ucrReceiver.ucrSelector = Nothing
        '
        'ucrSelector
        '
        Me.ucrSelector.AutoSize = True
        Me.ucrSelector.bShowHiddenColumns = False
        Me.ucrSelector.Location = New System.Drawing.Point(7, 5)
        Me.ucrSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelector.Name = "ucrSelector"
        Me.ucrSelector.Size = New System.Drawing.Size(3408, 982)
        Me.ucrSelector.TabIndex = 3
        '
        'txtGreaterThan
        '
        Me.txtGreaterThan.Location = New System.Drawing.Point(290, 183)
        Me.txtGreaterThan.Name = "txtGreaterThan"
        Me.txtGreaterThan.Size = New System.Drawing.Size(49, 20)
        Me.txtGreaterThan.TabIndex = 2
        '
        'txtEqualTo
        '
        Me.txtEqualTo.Location = New System.Drawing.Point(290, 159)
        Me.txtEqualTo.Name = "txtEqualTo"
        Me.txtEqualTo.Size = New System.Drawing.Size(49, 20)
        Me.txtEqualTo.TabIndex = 2
        '
        'txtLessThan
        '
        Me.txtLessThan.Location = New System.Drawing.Point(290, 136)
        Me.txtLessThan.Name = "txtLessThan"
        Me.txtLessThan.Size = New System.Drawing.Size(49, 20)
        Me.txtLessThan.TabIndex = 2
        '
        'rdoGreaterThan
        '
        Me.rdoGreaterThan.AutoSize = True
        Me.rdoGreaterThan.Location = New System.Drawing.Point(194, 182)
        Me.rdoGreaterThan.Name = "rdoGreaterThan"
        Me.rdoGreaterThan.Size = New System.Drawing.Size(88, 17)
        Me.rdoGreaterThan.TabIndex = 1
        Me.rdoGreaterThan.TabStop = True
        Me.rdoGreaterThan.Tag = "Greater_Than"
        Me.rdoGreaterThan.Text = "Greater Than"
        Me.rdoGreaterThan.UseVisualStyleBackColor = True
        '
        'rdoEqualTo
        '
        Me.rdoEqualTo.AutoSize = True
        Me.rdoEqualTo.Location = New System.Drawing.Point(194, 159)
        Me.rdoEqualTo.Name = "rdoEqualTo"
        Me.rdoEqualTo.Size = New System.Drawing.Size(68, 17)
        Me.rdoEqualTo.TabIndex = 1
        Me.rdoEqualTo.TabStop = True
        Me.rdoEqualTo.Tag = "Equal_To"
        Me.rdoEqualTo.Text = "Equal To"
        Me.rdoEqualTo.UseVisualStyleBackColor = True
        '
        'rdoLessThan
        '
        Me.rdoLessThan.AutoSize = True
        Me.rdoLessThan.Location = New System.Drawing.Point(194, 136)
        Me.rdoLessThan.Name = "rdoLessThan"
        Me.rdoLessThan.Size = New System.Drawing.Size(75, 17)
        Me.rdoLessThan.TabIndex = 1
        Me.rdoLessThan.TabStop = True
        Me.rdoLessThan.Tag = "Less_Than"
        Me.rdoLessThan.Text = "Less Than"
        Me.rdoLessThan.UseVisualStyleBackColor = True
        '
        'sdgRestrict
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(369, 291)
        Me.Controls.Add(Me.tbcOptions)
        Me.Controls.Add(Me.ucrSubDialogBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgRestrict"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Control Options"
        Me.tbcOptions.ResumeLayout(False)
        Me.tbpCondition.ResumeLayout(False)
        Me.tbpCondition.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSubDialogBase As ucrButtonsSubdialogue
    Friend WithEvents tbcOptions As TabControl
    Friend WithEvents tbpFactor_Level As TabPage
    Friend WithEvents tbpCondition As TabPage
    Friend WithEvents rdoGreaterThan As RadioButton
    Friend WithEvents rdoEqualTo As RadioButton
    Friend WithEvents rdoLessThan As RadioButton
    Friend WithEvents ucrSelector As ucrSelectorAddRemove
    Friend WithEvents txtGreaterThan As TextBox
    Friend WithEvents txtEqualTo As TextBox
    Friend WithEvents txtLessThan As TextBox
    Friend WithEvents lblSelectedColumn As Label
    Friend WithEvents ucrReceiver As ucrReceiverSingle
    Friend WithEvents rdoExclude As RadioButton
    Friend WithEvents rdoInclude As RadioButton
End Class
