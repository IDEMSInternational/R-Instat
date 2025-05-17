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
Partial Class dlgSpells
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
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDOY = New System.Windows.Forms.Label()
        Me.lblAnd = New System.Windows.Forms.Label()
        Me.grpRainParameters = New System.Windows.Forms.GroupBox()
        Me.ucrInputFilterPreview = New instat.ucrInputTextBox()
        Me.cmdDoyRange = New System.Windows.Forms.Button()
        Me.ucrInputSpellLower = New instat.ucrInputTextBox()
        Me.ucrInputCondition = New instat.ucrInputComboBox()
        Me.ucrInputSpellUpper = New instat.ucrInputTextBox()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.rdoAnnuel = New System.Windows.Forms.RadioButton()
        Me.rdoSpells = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrInputNewColumnName = New instat.ucrInputTextBox()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrSelectorForSpells = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkDayRange = New instat.ucrCheck()
        Me.grpRainParameters.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(370, 336)
        Me.lblElement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(72, 20)
        Me.lblElement.TabIndex = 12
        Me.lblElement.Text = "Element:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(370, 147)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 20)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Date:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(370, 210)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(47, 20)
        Me.lblYear.TabIndex = 8
        Me.lblYear.Text = "Year:"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.Location = New System.Drawing.Point(370, 272)
        Me.lblDOY.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(97, 20)
        Me.lblDOY.TabIndex = 10
        Me.lblDOY.Text = "Day of Year:"
        '
        'lblAnd
        '
        Me.lblAnd.AutoSize = True
        Me.lblAnd.Location = New System.Drawing.Point(358, 88)
        Me.lblAnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnd.Name = "lblAnd"
        Me.lblAnd.Size = New System.Drawing.Size(36, 20)
        Me.lblAnd.TabIndex = 19
        Me.lblAnd.Tag = ""
        Me.lblAnd.Text = "and"
        '
        'grpRainParameters
        '
        Me.grpRainParameters.Controls.Add(Me.ucrChkDayRange)
        Me.grpRainParameters.Controls.Add(Me.ucrInputFilterPreview)
        Me.grpRainParameters.Controls.Add(Me.cmdDoyRange)
        Me.grpRainParameters.Controls.Add(Me.ucrInputSpellLower)
        Me.grpRainParameters.Controls.Add(Me.ucrInputCondition)
        Me.grpRainParameters.Controls.Add(Me.ucrInputSpellUpper)
        Me.grpRainParameters.Controls.Add(Me.lblAnd)
        Me.grpRainParameters.Location = New System.Drawing.Point(15, 394)
        Me.grpRainParameters.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpRainParameters.Name = "grpRainParameters"
        Me.grpRainParameters.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpRainParameters.Size = New System.Drawing.Size(626, 129)
        Me.grpRainParameters.TabIndex = 14
        Me.grpRainParameters.TabStop = False
        Me.grpRainParameters.Text = "Options"
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.AutoSize = True
        Me.ucrInputFilterPreview.IsMultiline = False
        Me.ucrInputFilterPreview.IsReadOnly = True
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(135, 38)
        Me.ucrInputFilterPreview.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(363, 33)
        Me.ucrInputFilterPreview.TabIndex = 16
        '
        'cmdDoyRange
        '
        Me.cmdDoyRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoyRange.Location = New System.Drawing.Point(12, 34)
        Me.cmdDoyRange.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdDoyRange.Name = "cmdDoyRange"
        Me.cmdDoyRange.Size = New System.Drawing.Size(125, 39)
        Me.cmdDoyRange.TabIndex = 15
        Me.cmdDoyRange.Tag = ""
        Me.cmdDoyRange.Text = "Day Range"
        Me.cmdDoyRange.UseVisualStyleBackColor = True
        '
        'ucrInputSpellLower
        '
        Me.ucrInputSpellLower.AddQuotesIfUnrecognised = True
        Me.ucrInputSpellLower.AutoSize = True
        Me.ucrInputSpellLower.IsMultiline = False
        Me.ucrInputSpellLower.IsReadOnly = False
        Me.ucrInputSpellLower.Location = New System.Drawing.Point(252, 82)
        Me.ucrInputSpellLower.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputSpellLower.Name = "ucrInputSpellLower"
        Me.ucrInputSpellLower.Size = New System.Drawing.Size(94, 32)
        Me.ucrInputSpellLower.TabIndex = 18
        '
        'ucrInputCondition
        '
        Me.ucrInputCondition.AddQuotesIfUnrecognised = True
        Me.ucrInputCondition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCondition.GetSetSelectedIndex = -1
        Me.ucrInputCondition.IsReadOnly = False
        Me.ucrInputCondition.Location = New System.Drawing.Point(20, 82)
        Me.ucrInputCondition.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputCondition.Name = "ucrInputCondition"
        Me.ucrInputCondition.Size = New System.Drawing.Size(212, 32)
        Me.ucrInputCondition.TabIndex = 17
        '
        'ucrInputSpellUpper
        '
        Me.ucrInputSpellUpper.AddQuotesIfUnrecognised = True
        Me.ucrInputSpellUpper.AutoSize = True
        Me.ucrInputSpellUpper.IsMultiline = False
        Me.ucrInputSpellUpper.IsReadOnly = False
        Me.ucrInputSpellUpper.Location = New System.Drawing.Point(408, 82)
        Me.ucrInputSpellUpper.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputSpellUpper.Name = "ucrInputSpellUpper"
        Me.ucrInputSpellUpper.Size = New System.Drawing.Size(94, 32)
        Me.ucrInputSpellUpper.TabIndex = 20
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(370, 84)
        Me.lblStation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(64, 20)
        Me.lblStation.TabIndex = 4
        Me.lblStation.Text = "Station:"
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(9, 544)
        Me.lblNewColumnName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(148, 20)
        Me.lblNewColumnName.TabIndex = 21
        Me.lblNewColumnName.Text = "New Column Name:"
        '
        'rdoAnnuel
        '
        Me.rdoAnnuel.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoAnnuel.BackColor = System.Drawing.SystemColors.Control
        Me.rdoAnnuel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAnnuel.FlatAppearance.BorderSize = 2
        Me.rdoAnnuel.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAnnuel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoAnnuel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAnnuel.Location = New System.Drawing.Point(136, 12)
        Me.rdoAnnuel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoAnnuel.Name = "rdoAnnuel"
        Me.rdoAnnuel.Size = New System.Drawing.Size(195, 42)
        Me.rdoAnnuel.TabIndex = 1
        Me.rdoAnnuel.Tag = "Annual_Longest_Spell"
        Me.rdoAnnuel.Text = "Annual Longest Spell"
        Me.rdoAnnuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoAnnuel.UseVisualStyleBackColor = False
        '
        'rdoSpells
        '
        Me.rdoSpells.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSpells.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSpells.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSpells.FlatAppearance.BorderSize = 2
        Me.rdoSpells.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSpells.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSpells.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSpells.Location = New System.Drawing.Point(330, 12)
        Me.rdoSpells.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoSpells.Name = "rdoSpells"
        Me.rdoSpells.Size = New System.Drawing.Size(165, 42)
        Me.rdoSpells.TabIndex = 2
        Me.rdoSpells.Tag = "All_Spells"
        Me.rdoSpells.Text = "All Spells"
        Me.rdoSpells.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSpells.UseVisualStyleBackColor = False
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(135, 4)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(364, 54)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'ucrInputNewColumnName
        '
        Me.ucrInputNewColumnName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewColumnName.AutoSize = True
        Me.ucrInputNewColumnName.IsMultiline = False
        Me.ucrInputNewColumnName.IsReadOnly = False
        Me.ucrInputNewColumnName.Location = New System.Drawing.Point(256, 540)
        Me.ucrInputNewColumnName.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputNewColumnName.Name = "ucrInputNewColumnName"
        Me.ucrInputNewColumnName.Size = New System.Drawing.Size(280, 32)
        Me.ucrInputNewColumnName.TabIndex = 22
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(370, 108)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(214, 30)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 5
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.AutoSize = True
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(370, 297)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(214, 30)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 11
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(370, 234)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(214, 30)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 9
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(370, 171)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(214, 30)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 7
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.AutoSize = True
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(370, 360)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(214, 30)
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.TabIndex = 13
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrSelectorForSpells
        '
        Me.ucrSelectorForSpells.AutoSize = True
        Me.ucrSelectorForSpells.bDropUnusedFilterLevels = False
        Me.ucrSelectorForSpells.bShowHiddenColumns = False
        Me.ucrSelectorForSpells.bUseCurrentFilter = True
        Me.ucrSelectorForSpells.Location = New System.Drawing.Point(15, 74)
        Me.ucrSelectorForSpells.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForSpells.Name = "ucrSelectorForSpells"
        Me.ucrSelectorForSpells.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorForSpells.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 580)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 23
        '
        'ucrChkDayRange
        '
        Me.ucrChkDayRange.AutoSize = True
        Me.ucrChkDayRange.Checked = False
        Me.ucrChkDayRange.Location = New System.Drawing.Point(502, 36)
        Me.ucrChkDayRange.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkDayRange.Name = "ucrChkDayRange"
        Me.ucrChkDayRange.Size = New System.Drawing.Size(120, 34)
        Me.ucrChkDayRange.TabIndex = 21
        '
        'dlgSpells
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(670, 662)
        Me.Controls.Add(Me.rdoAnnuel)
        Me.Controls.Add(Me.rdoSpells)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrInputNewColumnName)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverDOY)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.lblDOY)
        Me.Controls.Add(Me.grpRainParameters)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrSelectorForSpells)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSpells"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spells"
        Me.grpRainParameters.ResumeLayout(False)
        Me.grpRainParameters.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForSpells As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents lblElement As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDOY As Label
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents grpRainParameters As GroupBox
    Friend WithEvents ucrInputCondition As ucrInputComboBox
    Friend WithEvents lblAnd As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrInputSpellLower As ucrInputTextBox
    Friend WithEvents ucrInputSpellUpper As ucrInputTextBox
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents ucrInputNewColumnName As ucrInputTextBox
    Friend WithEvents cmdDoyRange As Button
    Friend WithEvents ucrInputFilterPreview As ucrInputTextBox
    Friend WithEvents rdoAnnuel As RadioButton
    Friend WithEvents rdoSpells As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrChkDayRange As ucrCheck
End Class
