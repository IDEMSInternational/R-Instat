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
Partial Class dlgDisplayDOYofYear
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
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDayDisplay = New System.Windows.Forms.Label()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.lblNAString = New System.Windows.Forms.Label()
        Me.lblFontSize = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblHeaderFontSize = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrInputDisplayDaily = New instat.ucrInputTextBox()
        Me.ucrInputFile = New instat.ucrInputTextBox()
        Me.ucrInputMissingValues = New instat.ucrInputTextBox()
        Me.ucrChkRowNames = New instat.ucrCheck()
        Me.ucrChkMonthAbbreviations = New instat.ucrCheck()
        Me.ucrChkSaveTable = New instat.ucrCheck()
        Me.ucrNudFontSize = New instat.ucrNud()
        Me.ucrNudHeaderFontSize = New instat.ucrNud()
        Me.ucrNudHeight = New instat.ucrNud()
        Me.ucrNudWidth = New instat.ucrNud()
        Me.SuspendLayout()
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(18, 201)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(41, 13)
        Me.lblHeight.TabIndex = 6
        Me.lblHeight.Tag = "Height"
        Me.lblHeight.Text = "Height:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(18, 14)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Title:"
        '
        'lblDayDisplay
        '
        Me.lblDayDisplay.AutoSize = True
        Me.lblDayDisplay.Location = New System.Drawing.Point(18, 43)
        Me.lblDayDisplay.Name = "lblDayDisplay"
        Me.lblDayDisplay.Size = New System.Drawing.Size(66, 13)
        Me.lblDayDisplay.TabIndex = 8
        Me.lblDayDisplay.Tag = "Display_Day"
        Me.lblDayDisplay.Text = "Display Day:"
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(18, 70)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(26, 13)
        Me.lblFile.TabIndex = 9
        Me.lblFile.Tag = "File"
        Me.lblFile.Text = "File:"
        '
        'lblNAString
        '
        Me.lblNAString.AutoSize = True
        Me.lblNAString.Location = New System.Drawing.Point(18, 96)
        Me.lblNAString.Name = "lblNAString"
        Me.lblNAString.Size = New System.Drawing.Size(80, 13)
        Me.lblNAString.TabIndex = 10
        Me.lblNAString.Tag = "Missing_Values"
        Me.lblNAString.Text = "Missing Values:"
        '
        'lblFontSize
        '
        Me.lblFontSize.AutoSize = True
        Me.lblFontSize.Location = New System.Drawing.Point(18, 127)
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(54, 13)
        Me.lblFontSize.TabIndex = 11
        Me.lblFontSize.Tag = "Font_Size"
        Me.lblFontSize.Text = "Font Size:"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(18, 152)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(38, 13)
        Me.lblWidth.TabIndex = 12
        Me.lblWidth.Tag = "Width"
        Me.lblWidth.Text = "Width:"
        '
        'lblHeaderFontSize
        '
        Me.lblHeaderFontSize.AutoSize = True
        Me.lblHeaderFontSize.Location = New System.Drawing.Point(18, 175)
        Me.lblHeaderFontSize.Name = "lblHeaderFontSize"
        Me.lblHeaderFontSize.Size = New System.Drawing.Size(92, 13)
        Me.lblHeaderFontSize.TabIndex = 13
        Me.lblHeaderFontSize.Tag = "Header_Font_Size"
        Me.lblHeaderFontSize.Text = "Header Font Size:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(16, 247)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 57)
        Me.ucrBase.TabIndex = 0
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.bAddRemoveParameter = True
        Me.ucrInputTitle.bChangeParameterValue = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        Me.ucrInputTitle.Location = New System.Drawing.Point(111, 12)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputTitle.TabIndex = 21
        '
        'ucrInputDisplayDaily
        '
        Me.ucrInputDisplayDaily.bAddRemoveParameter = True
        Me.ucrInputDisplayDaily.bChangeParameterValue = True
        Me.ucrInputDisplayDaily.IsMultiline = False
        Me.ucrInputDisplayDaily.IsReadOnly = False
        Me.ucrInputDisplayDaily.Location = New System.Drawing.Point(111, 39)
        Me.ucrInputDisplayDaily.Name = "ucrInputDisplayDaily"
        Me.ucrInputDisplayDaily.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputDisplayDaily.TabIndex = 22
        '
        'ucrInputFile
        '
        Me.ucrInputFile.bAddRemoveParameter = True
        Me.ucrInputFile.bChangeParameterValue = True
        Me.ucrInputFile.IsMultiline = False
        Me.ucrInputFile.IsReadOnly = False
        Me.ucrInputFile.Location = New System.Drawing.Point(111, 66)
        Me.ucrInputFile.Name = "ucrInputFile"
        Me.ucrInputFile.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputFile.TabIndex = 22
        '
        'ucrInputMissingValues
        '
        Me.ucrInputMissingValues.bAddRemoveParameter = True
        Me.ucrInputMissingValues.bChangeParameterValue = True
        Me.ucrInputMissingValues.IsMultiline = False
        Me.ucrInputMissingValues.IsReadOnly = False
        Me.ucrInputMissingValues.Location = New System.Drawing.Point(111, 93)
        Me.ucrInputMissingValues.Name = "ucrInputMissingValues"
        Me.ucrInputMissingValues.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputMissingValues.TabIndex = 22
        '
        'ucrChkRowNames
        '
        Me.ucrChkRowNames.bAddRemoveParameter = True
        Me.ucrChkRowNames.bChangeParameterValue = True
        Me.ucrChkRowNames.Checked = False
        Me.ucrChkRowNames.Location = New System.Drawing.Point(16, 224)
        Me.ucrChkRowNames.Name = "ucrChkRowNames"
        Me.ucrChkRowNames.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkRowNames.TabIndex = 23
        '
        'ucrChkMonthAbbreviations
        '
        Me.ucrChkMonthAbbreviations.bAddRemoveParameter = True
        Me.ucrChkMonthAbbreviations.bChangeParameterValue = True
        Me.ucrChkMonthAbbreviations.Checked = False
        Me.ucrChkMonthAbbreviations.Location = New System.Drawing.Point(153, 221)
        Me.ucrChkMonthAbbreviations.Name = "ucrChkMonthAbbreviations"
        Me.ucrChkMonthAbbreviations.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkMonthAbbreviations.TabIndex = 24
        '
        'ucrChkSaveTable
        '
        Me.ucrChkSaveTable.bAddRemoveParameter = True
        Me.ucrChkSaveTable.bChangeParameterValue = True
        Me.ucrChkSaveTable.Checked = False
        Me.ucrChkSaveTable.Location = New System.Drawing.Point(316, 221)
        Me.ucrChkSaveTable.Name = "ucrChkSaveTable"
        Me.ucrChkSaveTable.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSaveTable.TabIndex = 25
        '
        'ucrNudFontSize
        '
        Me.ucrNudFontSize.bAddRemoveParameter = True
        Me.ucrNudFontSize.bChangeParameterValue = True
        Me.ucrNudFontSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFontSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFontSize.Location = New System.Drawing.Point(111, 120)
        Me.ucrNudFontSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFontSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFontSize.Name = "ucrNudFontSize"
        Me.ucrNudFontSize.Size = New System.Drawing.Size(62, 20)
        Me.ucrNudFontSize.TabIndex = 26
        Me.ucrNudFontSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudHeaderFontSize
        '
        Me.ucrNudHeaderFontSize.bAddRemoveParameter = True
        Me.ucrNudHeaderFontSize.bChangeParameterValue = True
        Me.ucrNudHeaderFontSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHeaderFontSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHeaderFontSize.Location = New System.Drawing.Point(111, 172)
        Me.ucrNudHeaderFontSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHeaderFontSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHeaderFontSize.Name = "ucrNudHeaderFontSize"
        Me.ucrNudHeaderFontSize.Size = New System.Drawing.Size(62, 20)
        Me.ucrNudHeaderFontSize.TabIndex = 28
        Me.ucrNudHeaderFontSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudHeight
        '
        Me.ucrNudHeight.bAddRemoveParameter = True
        Me.ucrNudHeight.bChangeParameterValue = True
        Me.ucrNudHeight.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHeight.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHeight.Location = New System.Drawing.Point(111, 198)
        Me.ucrNudHeight.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHeight.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHeight.Name = "ucrNudHeight"
        Me.ucrNudHeight.Size = New System.Drawing.Size(62, 20)
        Me.ucrNudHeight.TabIndex = 29
        Me.ucrNudHeight.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudWidth
        '
        Me.ucrNudWidth.bAddRemoveParameter = True
        Me.ucrNudWidth.bChangeParameterValue = True
        Me.ucrNudWidth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWidth.Location = New System.Drawing.Point(111, 146)
        Me.ucrNudWidth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWidth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Name = "ucrNudWidth"
        Me.ucrNudWidth.Size = New System.Drawing.Size(62, 20)
        Me.ucrNudWidth.TabIndex = 27
        Me.ucrNudWidth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgDisplayDOYofYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 307)
        Me.Controls.Add(Me.ucrNudHeight)
        Me.Controls.Add(Me.ucrNudHeaderFontSize)
        Me.Controls.Add(Me.ucrNudWidth)
        Me.Controls.Add(Me.ucrNudFontSize)
        Me.Controls.Add(Me.ucrChkSaveTable)
        Me.Controls.Add(Me.ucrChkMonthAbbreviations)
        Me.Controls.Add(Me.ucrChkRowNames)
        Me.Controls.Add(Me.ucrInputMissingValues)
        Me.Controls.Add(Me.ucrInputFile)
        Me.Controls.Add(Me.ucrInputDisplayDaily)
        Me.Controls.Add(Me.ucrInputTitle)
        Me.Controls.Add(Me.lblHeaderFontSize)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblFontSize)
        Me.Controls.Add(Me.lblNAString)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.lblDayDisplay)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplayDOYofYear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Display_DOY_of_Year"
        Me.Text = "Display Day Of Year"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDayDisplay As Label
    Friend WithEvents lblFile As Label
    Friend WithEvents lblNAString As Label
    Friend WithEvents lblFontSize As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblHeaderFontSize As Label
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents ucrInputDisplayDaily As ucrInputTextBox
    Friend WithEvents ucrInputFile As ucrInputTextBox
    Friend WithEvents ucrInputMissingValues As ucrInputTextBox
    Friend WithEvents ucrChkRowNames As ucrCheck
    Friend WithEvents ucrChkMonthAbbreviations As ucrCheck
    Friend WithEvents ucrChkSaveTable As ucrCheck
    Friend WithEvents ucrNudFontSize As ucrNud
    Friend WithEvents ucrNudHeaderFontSize As ucrNud
    Friend WithEvents ucrNudHeight As ucrNud
    Friend WithEvents ucrNudWidth As ucrNud
End Class
