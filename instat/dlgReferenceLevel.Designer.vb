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
Partial Class dlgReferenceLevel
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
        Me.lblFactorSelected = New System.Windows.Forms.Label()
        Me.ucrReceiverReferenceLevels = New instat.ucrReceiverSingle()
        Me.ucrSelectorForReferenceLevels = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrFactorReferenceLevels = New instat.ucrFactor()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblFactorSelected
        '
        Me.lblFactorSelected.AutoSize = True
        Me.lblFactorSelected.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorSelected.Location = New System.Drawing.Point(255, 12)
        Me.lblFactorSelected.Name = "lblFactorSelected"
        Me.lblFactorSelected.Size = New System.Drawing.Size(85, 13)
        Me.lblFactorSelected.TabIndex = 1
        Me.lblFactorSelected.Tag = "Factor_Selected:"
        Me.lblFactorSelected.Text = "Factor Selected:"
        '
        'ucrReceiverReferenceLevels
        '
        Me.ucrReceiverReferenceLevels.AutoSize = True
        Me.ucrReceiverReferenceLevels.frmParent = Me
        Me.ucrReceiverReferenceLevels.Location = New System.Drawing.Point(255, 28)
        Me.ucrReceiverReferenceLevels.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverReferenceLevels.Name = "ucrReceiverReferenceLevels"
        Me.ucrReceiverReferenceLevels.Selector = Nothing
        Me.ucrReceiverReferenceLevels.Size = New System.Drawing.Size(127, 26)
        Me.ucrReceiverReferenceLevels.strNcFilePath = ""
        Me.ucrReceiverReferenceLevels.TabIndex = 2
        Me.ucrReceiverReferenceLevels.ucrSelector = Nothing
        '
        'ucrSelectorForReferenceLevels
        '
        Me.ucrSelectorForReferenceLevels.AutoSize = True
        Me.ucrSelectorForReferenceLevels.bDropUnusedFilterLevels = False
        Me.ucrSelectorForReferenceLevels.bShowHiddenColumns = False
        Me.ucrSelectorForReferenceLevels.bUseCurrentFilter = True
        Me.ucrSelectorForReferenceLevels.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForReferenceLevels.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForReferenceLevels.Name = "ucrSelectorForReferenceLevels"
        Me.ucrSelectorForReferenceLevels.Size = New System.Drawing.Size(242, 194)
        Me.ucrSelectorForReferenceLevels.TabIndex = 0
        '
        'ucrFactorReferenceLevels
        '
        Me.ucrFactorReferenceLevels.AutoSize = True
        Me.ucrFactorReferenceLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrFactorReferenceLevels.clsReceiver = Nothing
        Me.ucrFactorReferenceLevels.Location = New System.Drawing.Point(255, 58)
        Me.ucrFactorReferenceLevels.Name = "ucrFactorReferenceLevels"
        Me.ucrFactorReferenceLevels.shtCurrSheet = Nothing
        Me.ucrFactorReferenceLevels.Size = New System.Drawing.Size(267, 181)
        Me.ucrFactorReferenceLevels.TabIndex = 3
        Me.ucrFactorReferenceLevels.ucrChkLevels = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 250)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 4
        '
        'dlgReferenceLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(531, 305)
        Me.Controls.Add(Me.ucrReceiverReferenceLevels)
        Me.Controls.Add(Me.ucrSelectorForReferenceLevels)
        Me.Controls.Add(Me.ucrFactorReferenceLevels)
        Me.Controls.Add(Me.lblFactorSelected)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReferenceLevel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Reference_Level"
        Me.Text = "Reference Level"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblFactorSelected As Label
    Friend WithEvents ucrSelectorForReferenceLevels As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverReferenceLevels As ucrReceiverSingle
    Friend WithEvents ucrFactorReferenceLevels As ucrFactor
End Class