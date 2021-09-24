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
Partial Class dlgAlignment
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
        Me.lstAlignment = New System.Windows.Forms.ListBox()
        Me.lblAlignment = New System.Windows.Forms.Label()
        Me.lblColumnWidth = New System.Windows.Forms.Label()
        Me.txtColumnWidth = New System.Windows.Forms.TextBox()
        Me.lblSelectedColumns = New System.Windows.Forms.Label()
        Me.ucrMultiple = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorAlignment = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lstAlignment
        '
        Me.lstAlignment.FormattingEnabled = True
        Me.lstAlignment.Items.AddRange(New Object() {"Left", "Centre", "Right", "General"})
        Me.lstAlignment.Location = New System.Drawing.Point(256, 190)
        Me.lstAlignment.Name = "lstAlignment"
        Me.lstAlignment.Size = New System.Drawing.Size(127, 56)
        Me.lstAlignment.TabIndex = 1
        '
        'lblAlignment
        '
        Me.lblAlignment.AutoSize = True
        Me.lblAlignment.Location = New System.Drawing.Point(258, 174)
        Me.lblAlignment.Name = "lblAlignment"
        Me.lblAlignment.Size = New System.Drawing.Size(56, 13)
        Me.lblAlignment.TabIndex = 3
        Me.lblAlignment.Tag = "Alignment:"
        Me.lblAlignment.Text = "Alignment:"
        '
        'lblColumnWidth
        '
        Me.lblColumnWidth.AutoSize = True
        Me.lblColumnWidth.Location = New System.Drawing.Point(258, 259)
        Me.lblColumnWidth.Name = "lblColumnWidth"
        Me.lblColumnWidth.Size = New System.Drawing.Size(76, 13)
        Me.lblColumnWidth.TabIndex = 4
        Me.lblColumnWidth.Tag = "Column_Width:"
        Me.lblColumnWidth.Text = "Column Width:"
        '
        'txtColumnWidth
        '
        Me.txtColumnWidth.Location = New System.Drawing.Point(340, 256)
        Me.txtColumnWidth.Name = "txtColumnWidth"
        Me.txtColumnWidth.Size = New System.Drawing.Size(43, 20)
        Me.txtColumnWidth.TabIndex = 5
        '
        'lblSelectedColumns
        '
        Me.lblSelectedColumns.AutoSize = True
        Me.lblSelectedColumns.Location = New System.Drawing.Point(253, 45)
        Me.lblSelectedColumns.Name = "lblSelectedColumns"
        Me.lblSelectedColumns.Size = New System.Drawing.Size(95, 13)
        Me.lblSelectedColumns.TabIndex = 7
        Me.lblSelectedColumns.Tag = "Selected_Columns:"
        Me.lblSelectedColumns.Text = "Selected Columns:"
        '
        'ucrMultiple
        '
        Me.ucrMultiple.frmParent = Me
        Me.ucrMultiple.Location = New System.Drawing.Point(256, 60)
        Me.ucrMultiple.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrMultiple.Name = "ucrMultiple"
        Me.ucrMultiple.Selector = Nothing
        Me.ucrMultiple.Size = New System.Drawing.Size(127, 106)
        Me.ucrMultiple.TabIndex = 6
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 282)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 8
        '
        'ucrSelectorAlignment
        '
        Me.ucrSelectorAlignment.bShowHiddenColumns = False
        Me.ucrSelectorAlignment.bUseCurrentFilter = True
        Me.ucrSelectorAlignment.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorAlignment.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorAlignment.Name = "ucrSelectorAlignment"
        Me.ucrSelectorAlignment.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorAlignment.TabIndex = 9
        '
        'dlgAlignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 340)
        Me.Controls.Add(Me.ucrSelectorAlignment)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblSelectedColumns)
        Me.Controls.Add(Me.ucrMultiple)
        Me.Controls.Add(Me.txtColumnWidth)
        Me.Controls.Add(Me.lblColumnWidth)
        Me.Controls.Add(Me.lblAlignment)
        Me.Controls.Add(Me.lstAlignment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAlignment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Format Current or Selected Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAlignment As ListBox
    Friend WithEvents lblAlignment As Label
    Friend WithEvents lblColumnWidth As Label
    Friend WithEvents txtColumnWidth As TextBox
    Friend WithEvents ucrMultiple As ucrReceiverMultiple
    Friend WithEvents lblSelectedColumns As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorAlignment As ucrSelectorByDataFrameAddRemove
End Class
