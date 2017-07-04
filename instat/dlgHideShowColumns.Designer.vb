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
Partial Class dlgHideShowColumns
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
        Me.ucrSelectorForHiddenColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverHiddenColumns = New instat.ucrReceiverMultiple()
        Me.lblHiddenColumns = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 200)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 3
        '
        'ucrSelectorForHiddenColumns
        '
        Me.ucrSelectorForHiddenColumns.bShowHiddenColumns = False
        Me.ucrSelectorForHiddenColumns.bUseCurrentFilter = True
        Me.ucrSelectorForHiddenColumns.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForHiddenColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForHiddenColumns.Name = "ucrSelectorForHiddenColumns"
        Me.ucrSelectorForHiddenColumns.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForHiddenColumns.TabIndex = 0
        '
        'ucrReceiverHiddenColumns
        '
        Me.ucrReceiverHiddenColumns.frmParent = Me
        Me.ucrReceiverHiddenColumns.Location = New System.Drawing.Point(252, 60)
        Me.ucrReceiverHiddenColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverHiddenColumns.Name = "ucrReceiverHiddenColumns"
        Me.ucrReceiverHiddenColumns.Selector = Nothing
        Me.ucrReceiverHiddenColumns.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverHiddenColumns.strNcFilePath = ""
        Me.ucrReceiverHiddenColumns.TabIndex = 2
        Me.ucrReceiverHiddenColumns.ucrSelector = Nothing
        '
        'lblHiddenColumns
        '
        Me.lblHiddenColumns.AutoSize = True
        Me.lblHiddenColumns.Location = New System.Drawing.Point(249, 45)
        Me.lblHiddenColumns.Name = "lblHiddenColumns"
        Me.lblHiddenColumns.Size = New System.Drawing.Size(93, 13)
        Me.lblHiddenColumns.TabIndex = 1
        Me.lblHiddenColumns.Text = "Hidden Column(s):"
        '
        'dlgHideShowColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 259)
        Me.Controls.Add(Me.lblHiddenColumns)
        Me.Controls.Add(Me.ucrReceiverHiddenColumns)
        Me.Controls.Add(Me.ucrSelectorForHiddenColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgHideShowColumns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Hidden_Columns"
        Me.Text = "Hidden Column(s)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForHiddenColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverHiddenColumns As ucrReceiverMultiple
    Friend WithEvents lblHiddenColumns As Label
End Class
