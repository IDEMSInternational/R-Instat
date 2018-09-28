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
Partial Class dlgSubset
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFrameAddRemove = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverSubset = New instat.ucrReceiverMultiple()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.lblDrop = New System.Windows.Forms.Label()
        Me.cboDrop = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(0, 0)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 5
        '
        'ucrDataFrameAddRemove
        '
        Me.ucrDataFrameAddRemove.bShowHiddenColumns = False
        Me.ucrDataFrameAddRemove.bUseCurrentFilter = True
        Me.ucrDataFrameAddRemove.Location = New System.Drawing.Point(0, 0)
        Me.ucrDataFrameAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameAddRemove.Name = "ucrDataFrameAddRemove"
        Me.ucrDataFrameAddRemove.Size = New System.Drawing.Size(210, 180)
        Me.ucrDataFrameAddRemove.TabIndex = 4
        '
        'ucrReceiverSubset
        '
        Me.ucrReceiverSubset.Location = New System.Drawing.Point(0, 0)
        Me.ucrReceiverSubset.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSubset.Name = "ucrReceiverSubset"
        Me.ucrReceiverSubset.Selector = Nothing
        Me.ucrReceiverSubset.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverSubset.TabIndex = 3
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.Location = New System.Drawing.Point(0, 0)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(100, 23)
        Me.lblSelectedVariables.TabIndex = 2
        Me.lblSelectedVariables.Tag = "Selected_variables"
        '
        'lblDrop
        '
        Me.lblDrop.Location = New System.Drawing.Point(0, 0)
        Me.lblDrop.Name = "lblDrop"
        Me.lblDrop.Size = New System.Drawing.Size(100, 23)
        Me.lblDrop.TabIndex = 1
        Me.lblDrop.Tag = "Drop"
        '
        'cboDrop
        '
        Me.cboDrop.FormattingEnabled = True
        Me.cboDrop.Location = New System.Drawing.Point(0, 0)
        Me.cboDrop.Name = "cboDrop"
        Me.cboDrop.Size = New System.Drawing.Size(121, 21)
        Me.cboDrop.TabIndex = 0
        '
        'dlgSubset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.cboDrop)
        Me.Controls.Add(Me.lblDrop)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrReceiverSubset)
        Me.Controls.Add(Me.ucrDataFrameAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSubset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Subset"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameAddRemove As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverSubset As ucrReceiverMultiple
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents lblDrop As Label
    Friend WithEvents cboDrop As ComboBox
End Class
