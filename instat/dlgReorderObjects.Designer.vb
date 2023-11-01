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
        Me.rdoOutputObjects = New System.Windows.Forms.RadioButton()
        Me.rdoDataObjects = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(6, 270)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 3
        '
        'lblObjectsToReoder
        '
        Me.lblObjectsToReoder.AutoSize = True
        Me.lblObjectsToReoder.Location = New System.Drawing.Point(178, 67)
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
        Me.ucrDataFrameReorder.Location = New System.Drawing.Point(6, 49)
        Me.ucrDataFrameReorder.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameReorder.Name = "ucrDataFrameReorder"
        Me.ucrDataFrameReorder.Size = New System.Drawing.Size(153, 43)
        Me.ucrDataFrameReorder.TabIndex = 0
        '
        'ucrReorderObjects
        '
        Me.ucrReorderObjects.Location = New System.Drawing.Point(178, 85)
        Me.ucrReorderObjects.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrReorderObjects.Name = "ucrReorderObjects"
        Me.ucrReorderObjects.Size = New System.Drawing.Size(209, 178)
        Me.ucrReorderObjects.TabIndex = 2
        Me.ucrReorderObjects.ucrDataFrameList = Nothing
        Me.ucrReorderObjects.ucrReceiver = Nothing
        '
        'rdoOutputObjects
        '
        Me.rdoOutputObjects.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoOutputObjects.BackColor = System.Drawing.SystemColors.Control
        Me.rdoOutputObjects.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOutputObjects.FlatAppearance.BorderSize = 2
        Me.rdoOutputObjects.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOutputObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoOutputObjects.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoOutputObjects.Location = New System.Drawing.Point(93, 7)
        Me.rdoOutputObjects.Name = "rdoOutputObjects"
        Me.rdoOutputObjects.Size = New System.Drawing.Size(120, 28)
        Me.rdoOutputObjects.TabIndex = 18
        Me.rdoOutputObjects.TabStop = True
        Me.rdoOutputObjects.Tag = ""
        Me.rdoOutputObjects.Text = "Output Objects"
        Me.rdoOutputObjects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoOutputObjects.UseVisualStyleBackColor = False
        '
        'rdoDataObjects
        '
        Me.rdoDataObjects.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDataObjects.BackColor = System.Drawing.SystemColors.Control
        Me.rdoDataObjects.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataObjects.FlatAppearance.BorderSize = 2
        Me.rdoDataObjects.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDataObjects.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDataObjects.Location = New System.Drawing.Point(213, 7)
        Me.rdoDataObjects.Name = "rdoDataObjects"
        Me.rdoDataObjects.Size = New System.Drawing.Size(120, 28)
        Me.rdoDataObjects.TabIndex = 19
        Me.rdoDataObjects.TabStop = True
        Me.rdoDataObjects.Tag = ""
        Me.rdoDataObjects.Text = "Data Objects"
        Me.rdoDataObjects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDataObjects.UseVisualStyleBackColor = False
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(2, 5)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(401, 36)
        Me.ucrPnlOptions.TabIndex = 17
        '
        'dlgReorderObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(418, 325)
        Me.Controls.Add(Me.rdoOutputObjects)
        Me.Controls.Add(Me.rdoDataObjects)
        Me.Controls.Add(Me.ucrPnlOptions)
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
    Friend WithEvents rdoOutputObjects As RadioButton
    Friend WithEvents rdoDataObjects As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
End Class
