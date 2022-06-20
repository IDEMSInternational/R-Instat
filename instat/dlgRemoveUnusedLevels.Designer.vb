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
Partial Class dlgRemoveUnusedLevels
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
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrRemoveUnusedFactorLevels = New instat.ucrFactor()
        Me.ucrReceiverFactorColumn = New instat.ucrReceiverSingle()
        Me.ucrSelectorFactorColumn = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputUnusedLevels = New instat.ucrInputTextBox()
        Me.lblLevelsPreview = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(239, 13)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(85, 13)
        Me.lblFactor.TabIndex = 1
        Me.lblFactor.Tag = "Factor_Selected:"
        Me.lblFactor.Text = "Factor Selected:"
        '
        'ucrRemoveUnusedFactorLevels
        '
        Me.ucrRemoveUnusedFactorLevels.AutoSize = True
        Me.ucrRemoveUnusedFactorLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrRemoveUnusedFactorLevels.Location = New System.Drawing.Point(239, 72)
        Me.ucrRemoveUnusedFactorLevels.Name = "ucrRemoveUnusedFactorLevels"
        Me.ucrRemoveUnusedFactorLevels.Size = New System.Drawing.Size(255, 175)
        Me.ucrRemoveUnusedFactorLevels.TabIndex = 4
        '
        'ucrReceiverFactorColumn
        '
        Me.ucrReceiverFactorColumn.AutoSize = True
        Me.ucrReceiverFactorColumn.frmParent = Me
        Me.ucrReceiverFactorColumn.Location = New System.Drawing.Point(239, 29)
        Me.ucrReceiverFactorColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactorColumn.Name = "ucrReceiverFactorColumn"
        Me.ucrReceiverFactorColumn.Selector = Nothing
        Me.ucrReceiverFactorColumn.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverFactorColumn.strNcFilePath = ""
        Me.ucrReceiverFactorColumn.TabIndex = 2
        Me.ucrReceiverFactorColumn.ucrSelector = Nothing
        '
        'ucrSelectorFactorColumn
        '
        Me.ucrSelectorFactorColumn.AutoSize = True
        Me.ucrSelectorFactorColumn.bDropUnusedFilterLevels = False
        Me.ucrSelectorFactorColumn.bShowHiddenColumns = False
        Me.ucrSelectorFactorColumn.bUseCurrentFilter = True
        Me.ucrSelectorFactorColumn.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorFactorColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFactorColumn.Name = "ucrSelectorFactorColumn"
        Me.ucrSelectorFactorColumn.Size = New System.Drawing.Size(242, 200)
        Me.ucrSelectorFactorColumn.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 293)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 7
        '
        'ucrInputUnusedLevels
        '
        Me.ucrInputUnusedLevels.AddQuotesIfUnrecognised = True
        Me.ucrInputUnusedLevels.AutoSize = True
        Me.ucrInputUnusedLevels.IsMultiline = False
        Me.ucrInputUnusedLevels.IsReadOnly = True
        Me.ucrInputUnusedLevels.Location = New System.Drawing.Point(100, 268)
        Me.ucrInputUnusedLevels.Name = "ucrInputUnusedLevels"
        Me.ucrInputUnusedLevels.Size = New System.Drawing.Size(380, 21)
        Me.ucrInputUnusedLevels.TabIndex = 6
        '
        'lblLevelsPreview
        '
        Me.lblLevelsPreview.AutoSize = True
        Me.lblLevelsPreview.Location = New System.Drawing.Point(239, 56)
        Me.lblLevelsPreview.Name = "lblLevelsPreview"
        Me.lblLevelsPreview.Size = New System.Drawing.Size(82, 13)
        Me.lblLevelsPreview.TabIndex = 3
        Me.lblLevelsPreview.Text = "Levels Preview:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Unused Levels:"
        '
        'dlgRemoveUnusedLevels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(504, 352)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLevelsPreview)
        Me.Controls.Add(Me.ucrInputUnusedLevels)
        Me.Controls.Add(Me.ucrRemoveUnusedFactorLevels)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrReceiverFactorColumn)
        Me.Controls.Add(Me.ucrSelectorFactorColumn)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRemoveUnusedLevels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Remove_Unused_Factor_Levels"
        Me.Text = "Remove Unused Levels"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorFactorColumn As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactorColumn As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrRemoveUnusedFactorLevels As ucrFactor
    Friend WithEvents ucrInputUnusedLevels As ucrInputTextBox
    Friend WithEvents lblLevelsPreview As Label
    Friend WithEvents Label1 As Label
End Class