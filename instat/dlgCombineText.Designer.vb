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
Partial Class dlgCombineText
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
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblColumnsToCobine = New System.Windows.Forms.Label()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.ucrReceiverCombineText = New instat.ucrReceiverMultiple()
        Me.ucrSelectorForCombineText = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(248, 167)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(56, 13)
        Me.lblSeparator.TabIndex = 3
        Me.lblSeparator.Text = "Separator:"
        '
        'lblColumnsToCobine
        '
        Me.lblColumnsToCobine.AutoSize = True
        Me.lblColumnsToCobine.Location = New System.Drawing.Point(248, 46)
        Me.lblColumnsToCobine.Name = "lblColumnsToCobine"
        Me.lblColumnsToCobine.Size = New System.Drawing.Size(106, 13)
        Me.lblColumnsToCobine.TabIndex = 1
        Me.lblColumnsToCobine.Tag = "Columns_to_Combine:"
        Me.lblColumnsToCobine.Text = "Columns to Combine:"
        '
        'ucrSaveColumn
        '
        Me.ucrSaveColumn.Location = New System.Drawing.Point(10, 209)
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        Me.ucrSaveColumn.Size = New System.Drawing.Size(305, 24)
        Me.ucrSaveColumn.TabIndex = 5
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.IsReadOnly = False
        Me.ucrInputSeparator.Location = New System.Drawing.Point(247, 182)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputSeparator.TabIndex = 4
        '
        'ucrReceiverCombineText
        '
        Me.ucrReceiverCombineText.frmParent = Me
        Me.ucrReceiverCombineText.Location = New System.Drawing.Point(247, 61)
        Me.ucrReceiverCombineText.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCombineText.Name = "ucrReceiverCombineText"
        Me.ucrReceiverCombineText.Selector = Nothing
        Me.ucrReceiverCombineText.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverCombineText.TabIndex = 2
        '
        'ucrSelectorForCombineText
        '
        Me.ucrSelectorForCombineText.bShowHiddenColumns = False
        Me.ucrSelectorForCombineText.bUseCurrentFilter = True
        Me.ucrSelectorForCombineText.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForCombineText.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForCombineText.Name = "ucrSelectorForCombineText"
        Me.ucrSelectorForCombineText.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForCombineText.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 236)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 6
        '
        'dlgCombineText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 297)
        Me.Controls.Add(Me.ucrSaveColumn)
        Me.Controls.Add(Me.ucrInputSeparator)
        Me.Controls.Add(Me.lblColumnsToCobine)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.ucrReceiverCombineText)
        Me.Controls.Add(Me.ucrSelectorForCombineText)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCombineText"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Combine_Text_Columns"
        Me.Text = "Combine Text Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForCombineText As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverCombineText As ucrReceiverMultiple
    Friend WithEvents lblSeparator As Label
    Friend WithEvents lblColumnsToCobine As Label
    Friend WithEvents ucrInputSeparator As ucrInputComboBox
    Friend WithEvents ucrSaveColumn As ucrSave
End Class
