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
Partial Class dlgName
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCurrentName = New System.Windows.Forms.Label()
        Me.lblVariableLabel = New System.Windows.Forms.Label()
        Me.rdoMultiple = New System.Windows.Forms.RadioButton()
        Me.rdoSingle = New System.Windows.Forms.RadioButton()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.rdoToLower = New System.Windows.Forms.RadioButton()
        Me.rdoMakeCleanNames = New System.Windows.Forms.RadioButton()
        Me.lblCase = New System.Windows.Forms.Label()
        Me.ucrInputCase = New instat.ucrInputComboBox()
        Me.ucrReceiverColumns = New instat.ucrReceiverMultiple()
        Me.ucrInputVariableLabel = New instat.ucrInputTextBox()
        Me.ucrReceiverName = New instat.ucrReceiverSingle()
        Me.ucrInputNewName = New instat.ucrInputTextBox()
        Me.ucrSelectVariables = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrPnlCase = New instat.UcrPanel()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(317, 112)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 23)
        Me.lblName.TabIndex = 9
        Me.lblName.Tag = "New_Name"
        Me.lblName.Text = "New Name:"
        '
        'lblCurrentName
        '
        Me.lblCurrentName.Location = New System.Drawing.Point(317, 66)
        Me.lblCurrentName.Name = "lblCurrentName"
        Me.lblCurrentName.Size = New System.Drawing.Size(100, 15)
        Me.lblCurrentName.TabIndex = 5
        Me.lblCurrentName.Text = "Current Name:"
        '
        'lblVariableLabel
        '
        Me.lblVariableLabel.AutoSize = True
        Me.lblVariableLabel.Location = New System.Drawing.Point(317, 160)
        Me.lblVariableLabel.Name = "lblVariableLabel"
        Me.lblVariableLabel.Size = New System.Drawing.Size(74, 13)
        Me.lblVariableLabel.TabIndex = 10
        Me.lblVariableLabel.Text = "Column Label:"
        '
        'rdoMultiple
        '
        Me.rdoMultiple.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMultiple.BackColor = System.Drawing.SystemColors.Control
        Me.rdoMultiple.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatAppearance.BorderSize = 2
        Me.rdoMultiple.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMultiple.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMultiple.Location = New System.Drawing.Point(269, 12)
        Me.rdoMultiple.Name = "rdoMultiple"
        Me.rdoMultiple.Size = New System.Drawing.Size(110, 28)
        Me.rdoMultiple.TabIndex = 2
        Me.rdoMultiple.TabStop = True
        Me.rdoMultiple.Tag = ""
        Me.rdoMultiple.Text = "Multiple"
        Me.rdoMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMultiple.UseVisualStyleBackColor = False
        '
        'rdoSingle
        '
        Me.rdoSingle.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSingle.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSingle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingle.FlatAppearance.BorderSize = 2
        Me.rdoSingle.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSingle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSingle.Location = New System.Drawing.Point(159, 12)
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Size = New System.Drawing.Size(110, 28)
        Me.rdoSingle.TabIndex = 1
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.Tag = ""
        Me.rdoSingle.Text = "Single"
        Me.rdoSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSingle.UseVisualStyleBackColor = False
        '
        'lblColumns
        '
        Me.lblColumns.Location = New System.Drawing.Point(317, 66)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(55, 15)
        Me.lblColumns.TabIndex = 4
        Me.lblColumns.Text = "Columns:"
        '
        'rdoToLower
        '
        Me.rdoToLower.AutoSize = True
        Me.rdoToLower.Location = New System.Drawing.Point(10, 18)
        Me.rdoToLower.Name = "rdoToLower"
        Me.rdoToLower.Size = New System.Drawing.Size(70, 17)
        Me.rdoToLower.TabIndex = 12
        Me.rdoToLower.TabStop = True
        Me.rdoToLower.Text = "To Lower"
        Me.rdoToLower.UseVisualStyleBackColor = True
        '
        'rdoMakeCleanNames
        '
        Me.rdoMakeCleanNames.AutoSize = True
        Me.rdoMakeCleanNames.Location = New System.Drawing.Point(10, 42)
        Me.rdoMakeCleanNames.Name = "rdoMakeCleanNames"
        Me.rdoMakeCleanNames.Size = New System.Drawing.Size(88, 17)
        Me.rdoMakeCleanNames.TabIndex = 19
        Me.rdoMakeCleanNames.TabStop = True
        Me.rdoMakeCleanNames.Text = "Clean Names"
        Me.rdoMakeCleanNames.UseVisualStyleBackColor = True
        '
        'lblCase
        '
        Me.lblCase.Location = New System.Drawing.Point(109, 43)
        Me.lblCase.Name = "lblCase"
        Me.lblCase.Size = New System.Drawing.Size(37, 16)
        Me.lblCase.TabIndex = 21
        Me.lblCase.Text = "Case:"
        '
        'ucrInputCase
        '
        Me.ucrInputCase.AddQuotesIfUnrecognised = True
        Me.ucrInputCase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCase.GetSetSelectedIndex = -1
        Me.ucrInputCase.IsReadOnly = False
        Me.ucrInputCase.Location = New System.Drawing.Point(148, 41)
        Me.ucrInputCase.Name = "ucrInputCase"
        Me.ucrInputCase.Size = New System.Drawing.Size(106, 21)
        Me.ucrInputCase.TabIndex = 20
        '
        'ucrReceiverColumns
        '
        Me.ucrReceiverColumns.AutoSize = True
        Me.ucrReceiverColumns.frmParent = Me
        Me.ucrReceiverColumns.Location = New System.Drawing.Point(317, 81)
        Me.ucrReceiverColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumns.Name = "ucrReceiverColumns"
        Me.ucrReceiverColumns.Selector = Nothing
        Me.ucrReceiverColumns.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverColumns.strNcFilePath = ""
        Me.ucrReceiverColumns.TabIndex = 8
        Me.ucrReceiverColumns.ucrSelector = Nothing
        '
        'ucrInputVariableLabel
        '
        Me.ucrInputVariableLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputVariableLabel.AutoSize = True
        Me.ucrInputVariableLabel.IsMultiline = False
        Me.ucrInputVariableLabel.IsReadOnly = False
        Me.ucrInputVariableLabel.Location = New System.Drawing.Point(317, 175)
        Me.ucrInputVariableLabel.Name = "ucrInputVariableLabel"
        Me.ucrInputVariableLabel.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputVariableLabel.TabIndex = 7
        '
        'ucrReceiverName
        '
        Me.ucrReceiverName.AutoSize = True
        Me.ucrReceiverName.frmParent = Me
        Me.ucrReceiverName.Location = New System.Drawing.Point(317, 81)
        Me.ucrReceiverName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverName.Name = "ucrReceiverName"
        Me.ucrReceiverName.Selector = Nothing
        Me.ucrReceiverName.Size = New System.Drawing.Size(137, 21)
        Me.ucrReceiverName.strNcFilePath = ""
        Me.ucrReceiverName.TabIndex = 5
        Me.ucrReceiverName.ucrSelector = Nothing
        '
        'ucrInputNewName
        '
        Me.ucrInputNewName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewName.AutoSize = True
        Me.ucrInputNewName.IsMultiline = False
        Me.ucrInputNewName.IsReadOnly = False
        Me.ucrInputNewName.Location = New System.Drawing.Point(317, 128)
        Me.ucrInputNewName.Name = "ucrInputNewName"
        Me.ucrInputNewName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputNewName.TabIndex = 6
        '
        'ucrSelectVariables
        '
        Me.ucrSelectVariables.AutoSize = True
        Me.ucrSelectVariables.bDropUnusedFilterLevels = False
        Me.ucrSelectVariables.bShowHiddenColumns = False
        Me.ucrSelectVariables.bUseCurrentFilter = True
        Me.ucrSelectVariables.Location = New System.Drawing.Point(10, 50)
        Me.ucrSelectVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectVariables.Name = "ucrSelectVariables"
        Me.ucrSelectVariables.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectVariables.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 291)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 12
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(134, 4)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(303, 44)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'ucrPnlCase
        '
        Me.ucrPnlCase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlCase.Location = New System.Drawing.Point(3, 13)
        Me.ucrPnlCase.Name = "ucrPnlCase"
        Me.ucrPnlCase.Size = New System.Drawing.Size(251, 58)
        Me.ucrPnlCase.TabIndex = 17
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrInputCase)
        Me.grpOptions.Controls.Add(Me.lblCase)
        Me.grpOptions.Controls.Add(Me.rdoMakeCleanNames)
        Me.grpOptions.Controls.Add(Me.rdoToLower)
        Me.grpOptions.Controls.Add(Me.ucrPnlCase)
        Me.grpOptions.Location = New System.Drawing.Point(257, 199)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(259, 77)
        Me.grpOptions.TabIndex = 11
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'dlgName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(538, 346)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrReceiverColumns)
        Me.Controls.Add(Me.rdoSingle)
        Me.Controls.Add(Me.rdoMultiple)
        Me.Controls.Add(Me.ucrInputVariableLabel)
        Me.Controls.Add(Me.lblVariableLabel)
        Me.Controls.Add(Me.ucrReceiverName)
        Me.Controls.Add(Me.ucrInputNewName)
        Me.Controls.Add(Me.lblCurrentName)
        Me.Controls.Add(Me.ucrSelectVariables)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.grpOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgName"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Rename_Data_Column"
        Me.Text = "Rename Columns"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverName As ucrReceiverSingle
    Friend WithEvents lblName As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectVariables As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblCurrentName As Label
    Friend WithEvents ucrInputNewName As ucrInputTextBox
    Friend WithEvents ucrInputVariableLabel As ucrInputTextBox
    Friend WithEvents lblVariableLabel As Label
    Friend WithEvents rdoSingle As RadioButton
    Friend WithEvents rdoMultiple As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrReceiverColumns As ucrReceiverMultiple
    Friend WithEvents rdoToLower As RadioButton
    Friend WithEvents ucrPnlCase As UcrPanel
    Friend WithEvents rdoMakeCleanNames As RadioButton
    Friend WithEvents ucrInputCase As ucrInputComboBox
    Friend WithEvents lblCase As Label
    Friend WithEvents grpOptions As GroupBox
End Class
