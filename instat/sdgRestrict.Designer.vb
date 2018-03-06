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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgRestrict))
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
        resources.ApplyResources(Me.ucrSubDialogBase, "ucrSubDialogBase")
        Me.ucrSubDialogBase.Name = "ucrSubDialogBase"
        '
        'tbcOptions
        '
        Me.tbcOptions.Controls.Add(Me.tbpFactor_Level)
        Me.tbcOptions.Controls.Add(Me.tbpCondition)
        resources.ApplyResources(Me.tbcOptions, "tbcOptions")
        Me.tbcOptions.Name = "tbcOptions"
        Me.tbcOptions.SelectedIndex = 0
        Me.tbcOptions.Tag = ""
        '
        'tbpFactor_Level
        '
        resources.ApplyResources(Me.tbpFactor_Level, "tbpFactor_Level")
        Me.tbpFactor_Level.Name = "tbpFactor_Level"
        Me.tbpFactor_Level.Tag = "Factor_Level"
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
        resources.ApplyResources(Me.tbpCondition, "tbpCondition")
        Me.tbpCondition.Name = "tbpCondition"
        Me.tbpCondition.Tag = "Condition"
        Me.tbpCondition.UseVisualStyleBackColor = True
        '
        'rdoExclude
        '
        resources.ApplyResources(Me.rdoExclude, "rdoExclude")
        Me.rdoExclude.Name = "rdoExclude"
        Me.rdoExclude.TabStop = True
        Me.rdoExclude.Tag = "Exclude"
        Me.rdoExclude.UseVisualStyleBackColor = True
        '
        'rdoInclude
        '
        resources.ApplyResources(Me.rdoInclude, "rdoInclude")
        Me.rdoInclude.Name = "rdoInclude"
        Me.rdoInclude.TabStop = True
        Me.rdoInclude.Tag = "Include"
        Me.rdoInclude.UseVisualStyleBackColor = True
        '
        'lblSelectedColumn
        '
        resources.ApplyResources(Me.lblSelectedColumn, "lblSelectedColumn")
        Me.lblSelectedColumn.Name = "lblSelectedColumn"
        Me.lblSelectedColumn.Tag = "Selected_Column"
        '
        'ucrReceiver
        '
        Me.ucrReceiver.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiver, "ucrReceiver")
        Me.ucrReceiver.Name = "ucrReceiver"
        Me.ucrReceiver.Selector = Nothing
        Me.ucrReceiver.strNcFilePath = ""
        Me.ucrReceiver.ucrSelector = Nothing
        '
        'ucrSelector
        '
        Me.ucrSelector.bShowHiddenColumns = False
        resources.ApplyResources(Me.ucrSelector, "ucrSelector")
        Me.ucrSelector.Name = "ucrSelector"
        '
        'txtGreaterThan
        '
        resources.ApplyResources(Me.txtGreaterThan, "txtGreaterThan")
        Me.txtGreaterThan.Name = "txtGreaterThan"
        '
        'txtEqualTo
        '
        resources.ApplyResources(Me.txtEqualTo, "txtEqualTo")
        Me.txtEqualTo.Name = "txtEqualTo"
        '
        'txtLessThan
        '
        resources.ApplyResources(Me.txtLessThan, "txtLessThan")
        Me.txtLessThan.Name = "txtLessThan"
        '
        'rdoGreaterThan
        '
        resources.ApplyResources(Me.rdoGreaterThan, "rdoGreaterThan")
        Me.rdoGreaterThan.Name = "rdoGreaterThan"
        Me.rdoGreaterThan.TabStop = True
        Me.rdoGreaterThan.Tag = "Greater_Than"
        Me.rdoGreaterThan.UseVisualStyleBackColor = True
        '
        'rdoEqualTo
        '
        resources.ApplyResources(Me.rdoEqualTo, "rdoEqualTo")
        Me.rdoEqualTo.Name = "rdoEqualTo"
        Me.rdoEqualTo.TabStop = True
        Me.rdoEqualTo.Tag = "Equal_To"
        Me.rdoEqualTo.UseVisualStyleBackColor = True
        '
        'rdoLessThan
        '
        resources.ApplyResources(Me.rdoLessThan, "rdoLessThan")
        Me.rdoLessThan.Name = "rdoLessThan"
        Me.rdoLessThan.TabStop = True
        Me.rdoLessThan.Tag = "Less_Than"
        Me.rdoLessThan.UseVisualStyleBackColor = True
        '
        'sdgRestrict
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbcOptions)
        Me.Controls.Add(Me.ucrSubDialogBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgRestrict"
        Me.tbcOptions.ResumeLayout(False)
        Me.tbpCondition.ResumeLayout(False)
        Me.tbpCondition.PerformLayout()
        Me.ResumeLayout(False)

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
