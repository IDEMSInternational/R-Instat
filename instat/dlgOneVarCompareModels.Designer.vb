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
Partial Class dlgOneVarCompareModels
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
        Me.ucrReceiverCompareModels = New instat.ucrReceiverMultiple()
        Me.ucrSelectorOneVarCompModels = New instat.ucrSelectorByDataFrameAddRemove()
        Me.cmdDisplayObjects = New System.Windows.Forms.Button()
        Me.lblReceiver = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 204)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 4
        '
        'ucrReceiverCompareModels
        '
        Me.ucrReceiverCompareModels.AutoSize = True
        Me.ucrReceiverCompareModels.frmParent = Me
        Me.ucrReceiverCompareModels.Location = New System.Drawing.Point(250, 60)
        Me.ucrReceiverCompareModels.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCompareModels.Name = "ucrReceiverCompareModels"
        Me.ucrReceiverCompareModels.Selector = Nothing
        Me.ucrReceiverCompareModels.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverCompareModels.strNcFilePath = ""
        Me.ucrReceiverCompareModels.TabIndex = 2
        Me.ucrReceiverCompareModels.ucrSelector = Nothing
        '
        'ucrSelectorOneVarCompModels
        '
        Me.ucrSelectorOneVarCompModels.AutoSize = True
        Me.ucrSelectorOneVarCompModels.bDropUnusedFilterLevels = False
        Me.ucrSelectorOneVarCompModels.bShowHiddenColumns = False
        Me.ucrSelectorOneVarCompModels.bUseCurrentFilter = True
        Me.ucrSelectorOneVarCompModels.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorOneVarCompModels.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOneVarCompModels.Name = "ucrSelectorOneVarCompModels"
        Me.ucrSelectorOneVarCompModels.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorOneVarCompModels.TabIndex = 0
        '
        'cmdDisplayObjects
        '
        Me.cmdDisplayObjects.Location = New System.Drawing.Point(283, 176)
        Me.cmdDisplayObjects.Name = "cmdDisplayObjects"
        Me.cmdDisplayObjects.Size = New System.Drawing.Size(125, 23)
        Me.cmdDisplayObjects.TabIndex = 3
        Me.cmdDisplayObjects.Text = "Display Objects..."
        Me.cmdDisplayObjects.UseVisualStyleBackColor = True
        '
        'lblReceiver
        '
        Me.lblReceiver.AutoSize = True
        Me.lblReceiver.Location = New System.Drawing.Point(250, 45)
        Me.lblReceiver.Name = "lblReceiver"
        Me.lblReceiver.Size = New System.Drawing.Size(97, 13)
        Me.lblReceiver.TabIndex = 1
        Me.lblReceiver.Text = "Selected Object(s):"
        '
        'dlgOneVarCompareModels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(417, 262)
        Me.Controls.Add(Me.lblReceiver)
        Me.Controls.Add(Me.cmdDisplayObjects)
        Me.Controls.Add(Me.ucrSelectorOneVarCompModels)
        Me.Controls.Add(Me.ucrReceiverCompareModels)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneVarCompareModels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Variable Compare Models"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverCompareModels As ucrReceiverMultiple
    Friend WithEvents ucrSelectorOneVarCompModels As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdDisplayObjects As Button
    Friend WithEvents lblReceiver As Label
End Class
