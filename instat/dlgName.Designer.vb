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
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCurrentName = New System.Windows.Forms.Label()
        Me.ucrInputNewName = New instat.ucrInputTextBox()
        Me.ucrSelectVariables = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverName = New instat.ucrReceiverSingle()
        Me.lblVariableLabel = New System.Windows.Forms.Label()
        Me.ucrInputVariableLabel = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(258, 91)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 23)
        Me.lblName.TabIndex = 3
        Me.lblName.Tag = "New_Name"
        Me.lblName.Text = "New Name:"
        '
        'lblCurrentName
        '
        Me.lblCurrentName.Location = New System.Drawing.Point(258, 45)
        Me.lblCurrentName.Name = "lblCurrentName"
        Me.lblCurrentName.Size = New System.Drawing.Size(100, 21)
        Me.lblCurrentName.TabIndex = 1
        Me.lblCurrentName.Text = "Current Name:"
        '
        'ucrInputNewName
        '
        Me.ucrInputNewName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewName.IsMultiline = False
        Me.ucrInputNewName.IsReadOnly = False
        Me.ucrInputNewName.Location = New System.Drawing.Point(258, 107)
        Me.ucrInputNewName.Name = "ucrInputNewName"
        Me.ucrInputNewName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputNewName.TabIndex = 4
        '
        'ucrSelectVariables
        '
        Me.ucrSelectVariables.bShowHiddenColumns = False
        Me.ucrSelectVariables.bUseCurrentFilter = True
        Me.ucrSelectVariables.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectVariables.Name = "ucrSelectVariables"
        Me.ucrSelectVariables.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectVariables.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 199)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 7
        '
        'ucrReceiverName
        '
        Me.ucrReceiverName.frmParent = Me
        Me.ucrReceiverName.Location = New System.Drawing.Point(258, 60)
        Me.ucrReceiverName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverName.Name = "ucrReceiverName"
        Me.ucrReceiverName.Selector = Nothing
        Me.ucrReceiverName.Size = New System.Drawing.Size(137, 21)
        Me.ucrReceiverName.TabIndex = 2
        Me.ucrReceiverName.ucrSelector = Nothing
        '
        'lblVariableLabel
        '
        Me.lblVariableLabel.AutoSize = True
        Me.lblVariableLabel.Location = New System.Drawing.Point(258, 139)
        Me.lblVariableLabel.Name = "lblVariableLabel"
        Me.lblVariableLabel.Size = New System.Drawing.Size(74, 13)
        Me.lblVariableLabel.TabIndex = 5
        Me.lblVariableLabel.Text = "Column Label:"
        '
        'ucrInputVariableLabel
        '
        Me.ucrInputVariableLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputVariableLabel.IsMultiline = False
        Me.ucrInputVariableLabel.IsReadOnly = False
        Me.ucrInputVariableLabel.Location = New System.Drawing.Point(258, 154)
        Me.ucrInputVariableLabel.Name = "ucrInputVariableLabel"
        Me.ucrInputVariableLabel.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputVariableLabel.TabIndex = 6
        '
        'dlgName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 256)
        Me.Controls.Add(Me.ucrInputVariableLabel)
        Me.Controls.Add(Me.lblVariableLabel)
        Me.Controls.Add(Me.ucrReceiverName)
        Me.Controls.Add(Me.ucrInputNewName)
        Me.Controls.Add(Me.lblCurrentName)
        Me.Controls.Add(Me.ucrSelectVariables)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgName"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Rename_Data_Column"
        Me.Text = "Rename Column"
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
End Class
