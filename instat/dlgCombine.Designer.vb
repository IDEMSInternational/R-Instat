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
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.ucrChkLexOrder = New instat.ucrCheck()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.ucrNewColName = New instat.ucrSave()
        Me.ucrChkDropUnusedLevels = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrFactorsReceiver = New instat.ucrReceiverMultiple()
        Me.ucrSelectorCombineFactors = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblFactors
        '
        Me.lblFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactors.Location = New System.Drawing.Point(247, 44)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(100, 15)
        Me.lblFactors.TabIndex = 1
        Me.lblFactors.Tag = "Factors_Selected:"
        Me.lblFactors.Text = "Factors Selected:"
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSeparator.Location = New System.Drawing.Point(250, 194)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(56, 13)
        Me.lblSeparator.TabIndex = 4
        Me.lblSeparator.Text = "Separator:"
        '
        'ucrChkLexOrder
        '
        Me.ucrChkLexOrder.AutoSize = True
        Me.ucrChkLexOrder.Checked = False
        Me.ucrChkLexOrder.Location = New System.Drawing.Point(250, 218)
        Me.ucrChkLexOrder.Name = "ucrChkLexOrder"
        Me.ucrChkLexOrder.Size = New System.Drawing.Size(133, 23)
        Me.ucrChkLexOrder.TabIndex = 6
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.AddQuotesIfUnrecognised = True
        Me.ucrInputSeparator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSeparator.GetSetSelectedIndex = -1
        Me.ucrInputSeparator.IsReadOnly = False
        Me.ucrInputSeparator.Location = New System.Drawing.Point(321, 192)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(87, 21)
        Me.ucrInputSeparator.TabIndex = 5
        '
        'ucrNewColName
        '
        Me.ucrNewColName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrNewColName.Location = New System.Drawing.Point(10, 246)
        Me.ucrNewColName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNewColName.Name = "ucrNewColName"
        Me.ucrNewColName.Size = New System.Drawing.Size(294, 22)
        Me.ucrNewColName.TabIndex = 7
        '
        'ucrChkDropUnusedLevels
        '
        Me.ucrChkDropUnusedLevels.AutoSize = True
        Me.ucrChkDropUnusedLevels.Checked = False
        Me.ucrChkDropUnusedLevels.Location = New System.Drawing.Point(250, 166)
        Me.ucrChkDropUnusedLevels.Name = "ucrChkDropUnusedLevels"
        Me.ucrChkDropUnusedLevels.Size = New System.Drawing.Size(170, 23)
        Me.ucrChkDropUnusedLevels.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 278)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 8
        '
        'ucrFactorsReceiver
        '
        Me.ucrFactorsReceiver.AutoSize = True
        Me.ucrFactorsReceiver.frmParent = Me
        Me.ucrFactorsReceiver.Location = New System.Drawing.Point(250, 59)
        Me.ucrFactorsReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorsReceiver.Name = "ucrFactorsReceiver"
        Me.ucrFactorsReceiver.Selector = Nothing
        Me.ucrFactorsReceiver.Size = New System.Drawing.Size(120, 100)
        Me.ucrFactorsReceiver.strNcFilePath = ""
        Me.ucrFactorsReceiver.TabIndex = 2
        Me.ucrFactorsReceiver.ucrSelector = Nothing
        '
        'ucrSelectorCombineFactors
        '
        Me.ucrSelectorCombineFactors.AutoSize = True
        Me.ucrSelectorCombineFactors.bDropUnusedFilterLevels = False
        Me.ucrSelectorCombineFactors.bShowHiddenColumns = False
        Me.ucrSelectorCombineFactors.bUseCurrentFilter = True
        Me.ucrSelectorCombineFactors.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorCombineFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCombineFactors.Name = "ucrSelectorCombineFactors"
        Me.ucrSelectorCombineFactors.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorCombineFactors.TabIndex = 0
        '
        'dlgCombine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(420, 333)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.ucrChkLexOrder)
        Me.Controls.Add(Me.ucrInputSeparator)
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
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSelectorCombineFactors As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFactorsReceiver As ucrReceiverMultiple
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrNewColName As ucrSave
    Friend WithEvents ucrChkDropUnusedLevels As ucrCheck
    Friend WithEvents ucrChkLexOrder As ucrCheck
    Friend WithEvents ucrInputSeparator As ucrInputComboBox
    Friend WithEvents lblSeparator As Label
End Class
