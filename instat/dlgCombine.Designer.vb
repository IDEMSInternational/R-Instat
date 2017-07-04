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
Partial Class dlgCombine
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
        Me.ucrSelectorCombineFactors = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrFactorsReceiver = New instat.ucrReceiverMultiple()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkDropUnusedLevels = New instat.ucrCheck()
        Me.ucrNewColName = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'ucrSelectorCombineFactors
        '
        Me.ucrSelectorCombineFactors.bShowHiddenColumns = False
        Me.ucrSelectorCombineFactors.bUseCurrentFilter = True
        Me.ucrSelectorCombineFactors.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorCombineFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCombineFactors.Name = "ucrSelectorCombineFactors"
        Me.ucrSelectorCombineFactors.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorCombineFactors.TabIndex = 0
        '
        'ucrFactorsReceiver
        '
        Me.ucrFactorsReceiver.frmParent = Me
        Me.ucrFactorsReceiver.Location = New System.Drawing.Point(273, 50)
        Me.ucrFactorsReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorsReceiver.Name = "ucrFactorsReceiver"
        Me.ucrFactorsReceiver.Selector = Nothing
        Me.ucrFactorsReceiver.Size = New System.Drawing.Size(120, 100)
        Me.ucrFactorsReceiver.TabIndex = 2
        '
        'lblFactors
        '
        Me.lblFactors.Location = New System.Drawing.Point(273, 34)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(100, 15)
        Me.lblFactors.TabIndex = 1
        Me.lblFactors.Tag = "Factors_Selected:"
        Me.lblFactors.Text = "Factors Selected:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 225)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 5
        '
        'ucrChkDropUnusedLevels
        '
        Me.ucrChkDropUnusedLevels.Checked = False
        Me.ucrChkDropUnusedLevels.Location = New System.Drawing.Point(273, 153)
        Me.ucrChkDropUnusedLevels.Name = "ucrChkDropUnusedLevels"
        Me.ucrChkDropUnusedLevels.Size = New System.Drawing.Size(133, 20)
        Me.ucrChkDropUnusedLevels.TabIndex = 3
        '
        'ucrNewColName
        '
        Me.ucrNewColName.Location = New System.Drawing.Point(10, 197)
        Me.ucrNewColName.Name = "ucrNewColName"
        Me.ucrNewColName.Size = New System.Drawing.Size(294, 24)
        Me.ucrNewColName.TabIndex = 4
        '
        'dlgCombine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 285)
        Me.Controls.Add(Me.ucrNewColName)
        Me.Controls.Add(Me.ucrChkDropUnusedLevels)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrFactorsReceiver)
        Me.Controls.Add(Me.ucrSelectorCombineFactors)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCombine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Combine_Factors"
        Me.Text = "Combine Factors"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrSelectorCombineFactors As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFactorsReceiver As ucrReceiverMultiple
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrNewColName As ucrSave
    Friend WithEvents ucrChkDropUnusedLevels As ucrCheck
End Class
