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
        Me.ucrInputNewColumnName = New instat.ucrInputTextBox()
        Me.ucrChkConditional = New instat.ucrCheck()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrSelectorForSpells = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpRainParameters.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(247, 197)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(48, 13)
        Me.lblElement.TabIndex = 9
        Me.lblElement.Text = "Element:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(247, 71)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(247, 113)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 3
        Me.lblYear.Text = "Year:"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.Location = New System.Drawing.Point(247, 154)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(66, 13)
        Me.lblDOY.TabIndex = 5
        Me.lblDOY.Text = "Day of Year:"
        '
        'lblAnd
        '
        Me.lblAnd.AutoSize = True
        Me.lblAnd.Location = New System.Drawing.Point(239, 59)
        Me.lblAnd.Name = "lblAnd"
        Me.lblAnd.Size = New System.Drawing.Size(25, 13)
        Me.lblAnd.TabIndex = 4
        Me.lblAnd.Tag = ""
        Me.lblAnd.Text = "and"
        '
        'grpRainParameters
        '
        Me.grpRainParameters.Controls.Add(Me.ucrInputFilterPreview)
        Me.grpRainParameters.Controls.Add(Me.cmdDoyRange)
        Me.grpRainParameters.Controls.Add(Me.ucrInputSpellLower)
        Me.grpRainParameters.Controls.Add(Me.ucrInputCondition)
        Me.grpRainParameters.Controls.Add(Me.ucrInputSpellUpper)
        Me.grpRainParameters.Controls.Add(Me.lblAnd)
        Me.grpRainParameters.Location = New System.Drawing.Point(10, 236)
        Me.grpRainParameters.Name = "grpRainParameters"
        Me.grpRainParameters.Size = New System.Drawing.Size(380, 86)
        Me.grpRainParameters.TabIndex = 12
        Me.grpRainParameters.TabStop = False
        Me.grpRainParameters.Text = "Options"
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.IsMultiline = False
        Me.ucrInputFilterPreview.IsReadOnly = True
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(124, 25)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(242, 22)
        Me.ucrInputFilterPreview.TabIndex = 27
        '
        'cmdDoyRange
        '
        Me.cmdDoyRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoyRange.Location = New System.Drawing.Point(13, 23)
        Me.cmdDoyRange.Name = "cmdDoyRange"
        Me.cmdDoyRange.Size = New System.Drawing.Size(105, 26)
        Me.cmdDoyRange.TabIndex = 0
        Me.cmdDoyRange.Tag = ""
        Me.cmdDoyRange.Text = "Day Range"
        Me.cmdDoyRange.UseVisualStyleBackColor = True
        '
        'ucrInputSpellLower
        '
        Me.ucrInputSpellLower.AddQuotesIfUnrecognised = True
        Me.ucrInputSpellLower.IsMultiline = False
        Me.ucrInputSpellLower.IsReadOnly = False
        Me.ucrInputSpellLower.Location = New System.Drawing.Point(168, 55)
        Me.ucrInputSpellLower.Name = "ucrInputSpellLower"
        Me.ucrInputSpellLower.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputSpellLower.TabIndex = 5
        '
        'ucrInputCondition
        '
        Me.ucrInputCondition.AddQuotesIfUnrecognised = True
        Me.ucrInputCondition.GetSetSelectedIndex = -1
        Me.ucrInputCondition.IsReadOnly = False
        Me.ucrInputCondition.Location = New System.Drawing.Point(13, 55)
        Me.ucrInputCondition.Name = "ucrInputCondition"
        Me.ucrInputCondition.Size = New System.Drawing.Size(141, 21)
        Me.ucrInputCondition.TabIndex = 6
        '
        'ucrInputSpellUpper
        '
        Me.ucrInputSpellUpper.AddQuotesIfUnrecognised = True
        Me.ucrInputSpellUpper.IsMultiline = False
        Me.ucrInputSpellUpper.IsReadOnly = False
        Me.ucrInputSpellUpper.Location = New System.Drawing.Point(272, 55)
        Me.ucrInputSpellUpper.Name = "ucrInputSpellUpper"
        Me.ucrInputSpellUpper.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputSpellUpper.TabIndex = 7
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(247, 29)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 7
        Me.lblStation.Text = "Station:"
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(6, 352)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(101, 13)
        Me.lblNewColumnName.TabIndex = 14
        Me.lblNewColumnName.Text = "New Column Name:"
        '
        'ucrInputNewColumnName
        '
        Me.ucrInputNewColumnName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewColumnName.IsMultiline = False
        Me.ucrInputNewColumnName.IsReadOnly = False
        Me.ucrInputNewColumnName.Location = New System.Drawing.Point(171, 349)
        Me.ucrInputNewColumnName.Name = "ucrInputNewColumnName"
        Me.ucrInputNewColumnName.Size = New System.Drawing.Size(187, 21)
        Me.ucrInputNewColumnName.TabIndex = 15
        '
        'ucrChkConditional
        '
        Me.ucrChkConditional.Checked = False
        Me.ucrChkConditional.Location = New System.Drawing.Point(10, 325)
        Me.ucrChkConditional.Name = "ucrChkConditional"
        Me.ucrChkConditional.Size = New System.Drawing.Size(366, 20)
        Me.ucrChkConditional.TabIndex = 13
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(247, 45)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 8
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(247, 171)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 6
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(247, 129)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 4
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(247, 87)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 2
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(247, 213)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.TabIndex = 10
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrSelectorForSpells
        '
        Me.ucrSelectorForSpells.bDropUnusedFilterLevels = False
        Me.ucrSelectorForSpells.bShowHiddenColumns = False
        Me.ucrSelectorForSpells.bUseCurrentFilter = True
        Me.ucrSelectorForSpells.Location = New System.Drawing.Point(10, 22)
        Me.ucrSelectorForSpells.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForSpells.Name = "ucrSelectorForSpells"
        Me.ucrSelectorForSpells.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForSpells.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 376)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgSpells
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 432)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrInputNewColumnName)
        Me.Controls.Add(Me.ucrChkConditional)
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
    Friend WithEvents ucrChkConditional As ucrCheck
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents ucrInputNewColumnName As ucrInputTextBox
    Friend WithEvents cmdDoyRange As Button
    Friend WithEvents ucrInputFilterPreview As ucrInputTextBox
End Class
