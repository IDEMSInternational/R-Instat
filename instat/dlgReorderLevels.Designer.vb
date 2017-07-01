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
Partial Class dlgReorderLevels
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
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrReorderFactor = New instat.ucrReorder()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.ucrSelectorFactorLevelsToReorder = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(258, 27)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(85, 13)
        Me.lblFactor.TabIndex = 1
        Me.lblFactor.Tag = "Factor_Selected:"
        Me.lblFactor.Text = "Factor Selected:"
        '
        'ucrReorderFactor
        '
        Me.ucrReorderFactor.Location = New System.Drawing.Point(255, 66)
        Me.ucrReorderFactor.Name = "ucrReorderFactor"
        Me.ucrReorderFactor.Size = New System.Drawing.Size(154, 139)
        Me.ucrReorderFactor.TabIndex = 3
        Me.ucrReorderFactor.ucrDataFrameList = Nothing
        Me.ucrReorderFactor.ucrReceiver = Nothing
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(259, 42)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(119, 26)
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.TabIndex = 2
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'ucrSelectorFactorLevelsToReorder
        '
        Me.ucrSelectorFactorLevelsToReorder.bShowHiddenColumns = False
        Me.ucrSelectorFactorLevelsToReorder.bUseCurrentFilter = True
        Me.ucrSelectorFactorLevelsToReorder.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorFactorLevelsToReorder.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFactorLevelsToReorder.Name = "ucrSelectorFactorLevelsToReorder"
        Me.ucrSelectorFactorLevelsToReorder.Size = New System.Drawing.Size(242, 193)
        Me.ucrSelectorFactorLevelsToReorder.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 211)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 4
        '
        'dlgReorderLevels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 268)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrReorderFactor)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrSelectorFactorLevelsToReorder)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReorderLevels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Reorder_Levels"
        Me.Text = "Reorder Levels"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorFactorLevelsToReorder As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents ucrReorderFactor As ucrReorder
    Friend WithEvents lblFactor As Label
End Class
