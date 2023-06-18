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
Partial Class dlgReorderColumns
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
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.ucrReorderColumns = New instat.ucrReorder()
        Me.ucrDataFrameSelect = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.Location = New System.Drawing.Point(175, 13)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(103, 13)
        Me.lblColumns.TabIndex = 1
        Me.lblColumns.Text = "Columns to Reorder:"
        '
        'ucrReorderColumns
        '
        Me.ucrReorderColumns.Location = New System.Drawing.Point(173, 29)
        Me.ucrReorderColumns.Name = "ucrReorderColumns"
        Me.ucrReorderColumns.Size = New System.Drawing.Size(211, 174)
        Me.ucrReorderColumns.TabIndex = 2
        Me.ucrReorderColumns.ucrDataFrameList = Nothing
        Me.ucrReorderColumns.ucrReceiver = Nothing
        '
        'ucrDataFrameSelect
        '
        Me.ucrDataFrameSelect.AutoSize = True
        Me.ucrDataFrameSelect.bDropUnusedFilterLevels = False
        Me.ucrDataFrameSelect.bUseCurrentFilter = True
        Me.ucrDataFrameSelect.Location = New System.Drawing.Point(10, 10)
        Me.ucrDataFrameSelect.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameSelect.Name = "ucrDataFrameSelect"
        Me.ucrDataFrameSelect.Size = New System.Drawing.Size(157, 45)
        Me.ucrDataFrameSelect.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 209)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 3
        '
        'dlgReorderColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(415, 266)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReorderColumns)
        Me.Controls.Add(Me.ucrDataFrameSelect)
        Me.Controls.Add(Me.lblColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReorderColumns"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reorder Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameSelect As ucrDataFrame
    Friend WithEvents ucrReorderColumns As ucrReorder
End Class
