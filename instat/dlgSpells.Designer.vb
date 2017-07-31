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
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.grpRainParameters = New System.Windows.Forms.GroupBox()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrInputNewColumnName = New instat.ucrInputTextBox()
        Me.ucrChkConditional = New instat.ucrCheck()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.ucrInputSpellLower = New instat.ucrInputTextBox()
        Me.ucrInputCondition = New instat.ucrInputComboBox()
        Me.ucrInputSpellUpper = New instat.ucrInputTextBox()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrSelectorForSpells = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpRainParameters.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(243, 200)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(48, 13)
        Me.lblElement.TabIndex = 9
        Me.lblElement.Text = "Element:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(247, 70)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(248, 114)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 5
        Me.lblYear.Text = "Year:"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.Location = New System.Drawing.Point(247, 154)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(66, 13)
        Me.lblDOY.TabIndex = 7
        Me.lblDOY.Text = "Day of Year:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(186, 16)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(45, 13)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Tag = ""
        Me.lblTo.Text = "To Day:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(6, 16)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(55, 13)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From Day:"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(6, 47)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(54, 13)
        Me.lblThreshold.TabIndex = 4
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Condition:"
        '
        'grpRainParameters
        '
        Me.grpRainParameters.Controls.Add(Me.ucrNudTo)
        Me.grpRainParameters.Controls.Add(Me.ucrNudFrom)
        Me.grpRainParameters.Controls.Add(Me.ucrInputSpellLower)
        Me.grpRainParameters.Controls.Add(Me.ucrInputCondition)
        Me.grpRainParameters.Controls.Add(Me.ucrInputSpellUpper)
        Me.grpRainParameters.Controls.Add(Me.lblThreshold)
        Me.grpRainParameters.Controls.Add(Me.lblFrom)
        Me.grpRainParameters.Controls.Add(Me.lblTo)
        Me.grpRainParameters.Location = New System.Drawing.Point(9, 244)
        Me.grpRainParameters.Name = "grpRainParameters"
        Me.grpRainParameters.Size = New System.Drawing.Size(380, 74)
        Me.grpRainParameters.TabIndex = 11
        Me.grpRainParameters.TabStop = False
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(247, 30)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 1
        Me.lblStation.Text = "Station:"
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(6, 352)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(101, 13)
        Me.lblNewColumnName.TabIndex = 13
        Me.lblNewColumnName.Text = "New Column Name:"
        '
        'ucrInputNewColumnName
        '
        Me.ucrInputNewColumnName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewColumnName.IsMultiline = False
        Me.ucrInputNewColumnName.IsReadOnly = False
        Me.ucrInputNewColumnName.Location = New System.Drawing.Point(113, 350)
        Me.ucrInputNewColumnName.Name = "ucrInputNewColumnName"
        Me.ucrInputNewColumnName.Size = New System.Drawing.Size(187, 21)
        Me.ucrInputNewColumnName.TabIndex = 14
        '
        'ucrChkConditional
        '
        Me.ucrChkConditional.Checked = False
        Me.ucrChkConditional.Location = New System.Drawing.Point(9, 323)
        Me.ucrChkConditional.Name = "ucrChkConditional"
        Me.ucrChkConditional.Size = New System.Drawing.Size(193, 20)
        Me.ucrChkConditional.TabIndex = 12
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(246, 45)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(246, 169)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 8
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(246, 128)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 6
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(246, 85)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(143, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 4
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrNudTo
        '
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Location = New System.Drawing.Point(237, 14)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTo.TabIndex = 3
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Location = New System.Drawing.Point(63, 14)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFrom.TabIndex = 1
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputSpellLower
        '
        Me.ucrInputSpellLower.AddQuotesIfUnrecognised = True
        Me.ucrInputSpellLower.IsMultiline = False
        Me.ucrInputSpellLower.IsReadOnly = False
        Me.ucrInputSpellLower.Location = New System.Drawing.Point(63, 44)
        Me.ucrInputSpellLower.Name = "ucrInputSpellLower"
        Me.ucrInputSpellLower.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputSpellLower.TabIndex = 5
        '
        'ucrInputCondition
        '
        Me.ucrInputCondition.AddQuotesIfUnrecognised = True
        Me.ucrInputCondition.IsReadOnly = False
        Me.ucrInputCondition.Location = New System.Drawing.Point(132, 44)
        Me.ucrInputCondition.Name = "ucrInputCondition"
        Me.ucrInputCondition.Size = New System.Drawing.Size(155, 21)
        Me.ucrInputCondition.TabIndex = 6
        '
        'ucrInputSpellUpper
        '
        Me.ucrInputSpellUpper.AddQuotesIfUnrecognised = True
        Me.ucrInputSpellUpper.IsMultiline = False
        Me.ucrInputSpellUpper.IsReadOnly = False
        Me.ucrInputSpellUpper.Location = New System.Drawing.Point(293, 44)
        Me.ucrInputSpellUpper.Name = "ucrInputSpellUpper"
        Me.ucrInputSpellUpper.Size = New System.Drawing.Size(63, 21)
        Me.ucrInputSpellUpper.TabIndex = 7
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(243, 215)
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
        Me.ucrSelectorForSpells.bShowHiddenColumns = False
        Me.ucrSelectorForSpells.bUseCurrentFilter = True
        Me.ucrSelectorForSpells.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorForSpells.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForSpells.Name = "ucrSelectorForSpells"
        Me.ucrSelectorForSpells.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForSpells.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 372)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 15
        '
        'dlgSpells
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 428)
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
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrInputSpellLower As ucrInputTextBox
    Friend WithEvents ucrInputSpellUpper As ucrInputTextBox
    Friend WithEvents ucrNudTo As ucrNud
    Friend WithEvents ucrNudFrom As ucrNud
    Friend WithEvents ucrChkConditional As ucrCheck
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents ucrInputNewColumnName As ucrInputTextBox
End Class
