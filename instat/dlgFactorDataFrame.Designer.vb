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
Partial Class dlgFactorDataFrame
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
        Me.lblSelectedFactor = New System.Windows.Forms.Label()
        Me.lblFactorNames = New System.Windows.Forms.Label()
        Me.ucrChkAddCurrentContrasts = New instat.ucrCheck()
        Me.ucrChkReplaceIfAlreadyExists = New instat.ucrCheck()
        Me.ucrInputFactorNames = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverFactorDataFrame = New instat.ucrReceiverSingle()
        Me.ucrSelectorFactorDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblSelectedFactor
        '
        Me.lblSelectedFactor.AutoSize = True
        Me.lblSelectedFactor.Location = New System.Drawing.Point(253, 34)
        Me.lblSelectedFactor.Name = "lblSelectedFactor"
        Me.lblSelectedFactor.Size = New System.Drawing.Size(85, 13)
        Me.lblSelectedFactor.TabIndex = 1
        Me.lblSelectedFactor.Text = "Selected Factor:"
        '
        'lblFactorNames
        '
        Me.lblFactorNames.AutoSize = True
        Me.lblFactorNames.Location = New System.Drawing.Point(249, 81)
        Me.lblFactorNames.Name = "lblFactorNames"
        Me.lblFactorNames.Size = New System.Drawing.Size(121, 13)
        Me.lblFactorNames.TabIndex = 3
        Me.lblFactorNames.Text = "New Data Frame Name:"
        '
        'ucrChkAddCurrentContrasts
        '
        Me.ucrChkAddCurrentContrasts.Checked = False
        Me.ucrChkAddCurrentContrasts.Location = New System.Drawing.Point(251, 149)
        Me.ucrChkAddCurrentContrasts.Name = "ucrChkAddCurrentContrasts"
        Me.ucrChkAddCurrentContrasts.Size = New System.Drawing.Size(165, 20)
        Me.ucrChkAddCurrentContrasts.TabIndex = 6
        '
        'ucrChkReplaceIfAlreadyExists
        '
        Me.ucrChkReplaceIfAlreadyExists.Checked = False
        Me.ucrChkReplaceIfAlreadyExists.Location = New System.Drawing.Point(251, 123)
        Me.ucrChkReplaceIfAlreadyExists.Name = "ucrChkReplaceIfAlreadyExists"
        Me.ucrChkReplaceIfAlreadyExists.Size = New System.Drawing.Size(165, 20)
        Me.ucrChkReplaceIfAlreadyExists.TabIndex = 5
        '
        'ucrInputFactorNames
        '
        Me.ucrInputFactorNames.IsMultiline = False
        Me.ucrInputFactorNames.IsReadOnly = False
        Me.ucrInputFactorNames.Location = New System.Drawing.Point(251, 96)
        Me.ucrInputFactorNames.Name = "ucrInputFactorNames"
        Me.ucrInputFactorNames.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputFactorNames.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 205)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 7
        '
        'ucrReceiverFactorDataFrame
        '
        Me.ucrReceiverFactorDataFrame.frmParent = Me
        Me.ucrReceiverFactorDataFrame.Location = New System.Drawing.Point(252, 49)
        Me.ucrReceiverFactorDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactorDataFrame.Name = "ucrReceiverFactorDataFrame"
        Me.ucrReceiverFactorDataFrame.Selector = Nothing
        Me.ucrReceiverFactorDataFrame.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFactorDataFrame.TabIndex = 2
        '
        'ucrSelectorFactorDataFrame
        '
        Me.ucrSelectorFactorDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorFactorDataFrame.bUseCurrentFilter = True
        Me.ucrSelectorFactorDataFrame.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorFactorDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFactorDataFrame.Name = "ucrSelectorFactorDataFrame"
        Me.ucrSelectorFactorDataFrame.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorFactorDataFrame.TabIndex = 0
        '
        'dlgFactorDataFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 264)
        Me.Controls.Add(Me.ucrChkAddCurrentContrasts)
        Me.Controls.Add(Me.ucrChkReplaceIfAlreadyExists)
        Me.Controls.Add(Me.ucrInputFactorNames)
        Me.Controls.Add(Me.lblFactorNames)
        Me.Controls.Add(Me.lblSelectedFactor)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverFactorDataFrame)
        Me.Controls.Add(Me.ucrSelectorFactorDataFrame)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFactorDataFrame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factor Data Frame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorFactorDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactorDataFrame As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblSelectedFactor As Label
    Friend WithEvents lblFactorNames As Label
    Friend WithEvents ucrInputFactorNames As ucrInputTextBox
    Friend WithEvents ucrChkAddCurrentContrasts As ucrCheck
    Friend WithEvents ucrChkReplaceIfAlreadyExists As ucrCheck
End Class
