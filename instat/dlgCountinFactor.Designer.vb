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
Partial Class dlgCountinFactor
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
        Me.lblSelectedFactor = New System.Windows.Forms.Label()
        Me.ucrNewColName = New instat.ucrSave()
        Me.ucrCountReceiver = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrCountSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblSelectedFactor
        '
        Me.lblSelectedFactor.AutoSize = True
        Me.lblSelectedFactor.Location = New System.Drawing.Point(267, 45)
        Me.lblSelectedFactor.Name = "lblSelectedFactor"
        Me.lblSelectedFactor.Size = New System.Drawing.Size(85, 13)
        Me.lblSelectedFactor.TabIndex = 1
        Me.lblSelectedFactor.Text = "Selected Factor:"
        '
        'ucrNewColName
        '
        Me.ucrNewColName.Location = New System.Drawing.Point(9, 210)
        Me.ucrNewColName.Name = "ucrNewColName"
        Me.ucrNewColName.Size = New System.Drawing.Size(255, 24)
        Me.ucrNewColName.TabIndex = 3
        '
        'ucrCountReceiver
        '
        Me.ucrCountReceiver.frmParent = Me
        Me.ucrCountReceiver.Location = New System.Drawing.Point(267, 60)
        Me.ucrCountReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrCountReceiver.Name = "ucrCountReceiver"
        Me.ucrCountReceiver.Selector = Nothing
        Me.ucrCountReceiver.Size = New System.Drawing.Size(130, 20)
        Me.ucrCountReceiver.strNcFilePath = ""
        Me.ucrCountReceiver.TabIndex = 2
        Me.ucrCountReceiver.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 240)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 4
        '
        'ucrCountSelector
        '
        Me.ucrCountSelector.bShowHiddenColumns = False
        Me.ucrCountSelector.bUseCurrentFilter = True
        Me.ucrCountSelector.Location = New System.Drawing.Point(9, 9)
        Me.ucrCountSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrCountSelector.Name = "ucrCountSelector"
        Me.ucrCountSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrCountSelector.TabIndex = 0
        '
        'dlgCountinFactor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 297)
        Me.Controls.Add(Me.ucrNewColName)
        Me.Controls.Add(Me.lblSelectedFactor)
        Me.Controls.Add(Me.ucrCountReceiver)
        Me.Controls.Add(Me.ucrCountSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCountinFactor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Count_in_Factor"
        Me.Text = "Count in Factor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrCountSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrCountReceiver As ucrReceiverSingle
    Friend WithEvents lblSelectedFactor As Label
    Friend WithEvents ucrNewColName As ucrSave
End Class
