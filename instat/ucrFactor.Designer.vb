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
Partial Class ucrFactor
    Inherits instat.ucrCore

    'UserControl overrides dispose to clean up the component list.
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
        Me.grdFactorData = New unvell.ReoGrid.ReoGridControl()
        Me.SuspendLayout()
        '
        'grdFactorData
        '
        Me.grdFactorData.BackColor = System.Drawing.Color.White
        Me.grdFactorData.ColumnHeaderContextMenuStrip = Nothing
        Me.grdFactorData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFactorData.LeadHeaderContextMenuStrip = Nothing
        Me.grdFactorData.Location = New System.Drawing.Point(0, 0)
        Me.grdFactorData.Name = "grdFactorData"
        Me.grdFactorData.RowHeaderContextMenuStrip = Nothing
        Me.grdFactorData.Script = Nothing
        Me.grdFactorData.SheetTabContextMenuStrip = Nothing
        Me.grdFactorData.SheetTabNewButtonVisible = False
        Me.grdFactorData.SheetTabVisible = True
        Me.grdFactorData.SheetTabWidth = 60
        Me.grdFactorData.Size = New System.Drawing.Size(270, 208)
        Me.grdFactorData.TabIndex = 32
        '
        'ucrFactor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.grdFactorData)
        Me.Name = "ucrFactor"
        Me.Size = New System.Drawing.Size(270, 208)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdFactorData As unvell.ReoGrid.ReoGridControl
End Class
