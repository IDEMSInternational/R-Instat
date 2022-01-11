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
Partial Class dlgReorderObjects
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
        Me.ucrBase = New instat.ucrButtons()
        Me.lblObjectsToReoder = New System.Windows.Forms.Label()
        Me.ucrDataFrameReorder = New instat.ucrDataFrame()
        Me.ucrReorderObjects = New instat.ucrReorder()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 229)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 3
        '
        'lblObjectsToReoder
        '
        Me.lblObjectsToReoder.AutoSize = True
        Me.lblObjectsToReoder.Location = New System.Drawing.Point(182, 28)
        Me.lblObjectsToReoder.Name = "lblObjectsToReoder"
        Me.lblObjectsToReoder.Size = New System.Drawing.Size(99, 13)
        Me.lblObjectsToReoder.TabIndex = 1
        Me.lblObjectsToReoder.Tag = "Objects_to_Reorder"
        Me.lblObjectsToReoder.Text = "Objects to Reorder:"
        '
        'ucrDataFrameReorder
        '
        Me.ucrDataFrameReorder.AutoSize = True
        Me.ucrDataFrameReorder.bDropUnusedFilterLevels = False
        Me.ucrDataFrameReorder.bUseCurrentFilter = True
        Me.ucrDataFrameReorder.Location = New System.Drawing.Point(10, 10)
        Me.ucrDataFrameReorder.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameReorder.Name = "ucrDataFrameReorder"
        Me.ucrDataFrameReorder.Size = New System.Drawing.Size(153, 43)
        Me.ucrDataFrameReorder.TabIndex = 0
        '
        'ucrReorderObjects
        '
        Me.ucrReorderObjects.Location = New System.Drawing.Point(182, 45)
        Me.ucrReorderObjects.Name = "ucrReorderObjects"
        Me.ucrReorderObjects.Size = New System.Drawing.Size(209, 178)
        Me.ucrReorderObjects.TabIndex = 2
        Me.ucrReorderObjects.ucrDataFrameList = Nothing
        Me.ucrReorderObjects.ucrReceiver = Nothing
        '
        'dlgReorderObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(418, 287)
        Me.Controls.Add(Me.lblObjectsToReoder)
        Me.Controls.Add(Me.ucrDataFrameReorder)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReorderObjects)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReorderObjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Reorder_Objects"
        Me.Text = "Reorder Objects"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblObjectsToReoder As Label
    Friend WithEvents ucrDataFrameReorder As ucrDataFrame
    Friend WithEvents ucrReorderObjects As ucrReorder
End Class
