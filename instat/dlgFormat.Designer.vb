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
Partial Class dlgFormat
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
        Me.lstRequiredFormat = New System.Windows.Forms.ListBox()
        Me.lblRequiredFormat = New System.Windows.Forms.Label()
        Me.ucrMultiple = New instat.ucrReceiverMultiple()
        Me.lblSelectedColumns = New System.Windows.Forms.Label()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lstRequiredFormat
        '
        Me.lstRequiredFormat.FormattingEnabled = True
        Me.lstRequiredFormat.Items.AddRange(New Object() {"""0"".000E+", "0.0", "0.00", "0.000", "0.0000", "1 sig fig", "2 sig figs", "3 sig figs", "4 sig figs", "Day of year", "Fixed", "General Date", "General Number", "Long Date", "Medium Date", "Percentage", "Scientific", "Short Date", "Standard", "True/False", "Yes/No"})
        Me.lstRequiredFormat.Location = New System.Drawing.Point(334, 22)
        Me.lstRequiredFormat.Name = "lstRequiredFormat"
        Me.lstRequiredFormat.ScrollAlwaysVisible = True
        Me.lstRequiredFormat.Size = New System.Drawing.Size(97, 121)
        Me.lstRequiredFormat.Sorted = True
        Me.lstRequiredFormat.TabIndex = 1
        '
        'lblRequiredFormat
        '
        Me.lblRequiredFormat.AutoSize = True
        Me.lblRequiredFormat.Location = New System.Drawing.Point(329, 4)
        Me.lblRequiredFormat.Name = "lblRequiredFormat"
        Me.lblRequiredFormat.Size = New System.Drawing.Size(85, 13)
        Me.lblRequiredFormat.TabIndex = 2
        Me.lblRequiredFormat.Tag = "Required_Format"
        Me.lblRequiredFormat.Text = "Required Format"
        '
        'ucrMultiple
        '
        Me.ucrMultiple.AutoSize = True
        Me.ucrMultiple.frmParent = Me
        Me.ucrMultiple.Location = New System.Drawing.Point(211, 19)
        Me.ucrMultiple.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrMultiple.Name = "ucrMultiple"
        Me.ucrMultiple.Selector = Nothing
        Me.ucrMultiple.Size = New System.Drawing.Size(121, 131)
        Me.ucrMultiple.strNcFilePath = ""
        Me.ucrMultiple.TabIndex = 3
        Me.ucrMultiple.ucrSelector = Nothing
        '
        'lblSelectedColumns
        '
        Me.lblSelectedColumns.AutoSize = True
        Me.lblSelectedColumns.Location = New System.Drawing.Point(205, 3)
        Me.lblSelectedColumns.Name = "lblSelectedColumns"
        Me.lblSelectedColumns.Size = New System.Drawing.Size(124, 13)
        Me.lblSelectedColumns.TabIndex = 4
        Me.lblSelectedColumns.Tag = "Selected_Columns"
        Me.lblSelectedColumns.Text = "Columns to be formatted "
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.AutoSize = True
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.Dock = System.Windows.Forms.DockStyle.Left
        Me.ucrAddRemove.Location = New System.Drawing.Point(0, 0)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(213, 214)
        Me.ucrAddRemove.TabIndex = 5
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(13, 156)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 6
        '
        'dlgFormat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(435, 214)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.lblSelectedColumns)
        Me.Controls.Add(Me.ucrMultiple)
        Me.Controls.Add(Me.lblRequiredFormat)
        Me.Controls.Add(Me.lstRequiredFormat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFormat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Format_Data"
        Me.Text = "Format Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstRequiredFormat As ListBox
    Friend WithEvents lblRequiredFormat As Label
    Friend WithEvents ucrMultiple As ucrReceiverMultiple
    Friend WithEvents lblSelectedColumns As Label
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrBase As ucrButtons
End Class
