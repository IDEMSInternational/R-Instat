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
Partial Class dlgMakeDate
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgMakeDate))
        Me.grpTwoColumns = New System.Windows.Forms.GroupBox()
        Me.ucrChkTwoDigitYear = New instat.ucrCheck()
        Me.ucrNudCutoff = New instat.ucrNud()
        Me.lblCutOffTwo = New System.Windows.Forms.Label()
        Me.ucrInputComboBoxMonthTwo = New instat.ucrInputComboBox()
        Me.lblYearTwo = New System.Windows.Forms.Label()
        Me.ucrReceiverYearTwo = New instat.ucrReceiverSingle()
        Me.lblDayofYear = New System.Windows.Forms.Label()
        Me.ucrReceiverDayTwo = New instat.ucrReceiverSingle()
        Me.grpSingleColumn = New System.Windows.Forms.GroupBox()
        Me.grpFormatField = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UcrInputComboBox1 = New instat.ucrInputComboBox()
        Me.UcrInputComboBox2 = New instat.ucrInputComboBox()
        Me.UcrInputComboBox3 = New instat.ucrInputComboBox()
        Me.UcrInputComboBox4 = New instat.ucrInputComboBox()
        Me.rdoSpecifyFormat = New System.Windows.Forms.RadioButton()
        Me.rdoSpecifyOrigin = New System.Windows.Forms.RadioButton()
        Me.rdoDefaultFormat = New System.Windows.Forms.RadioButton()
        Me.ucrPnlFormat = New instat.UcrPanel()
        Me.ucrReceiverForDate = New instat.ucrReceiverSingle()
        Me.ucrInputFormat = New instat.ucrInputComboBox()
        Me.ucrInputOrigin = New instat.ucrInputComboBox()
        Me.grpThreeColumns = New System.Windows.Forms.GroupBox()
        Me.lblYearOption = New System.Windows.Forms.Label()
        Me.lblMonthOption = New System.Windows.Forms.Label()
        Me.ucrInputMonthOption = New instat.ucrInputComboBox()
        Me.ucrInputYearOption = New instat.ucrInputComboBox()
        Me.lblDayofMonth = New System.Windows.Forms.Label()
        Me.lblMonthThree = New System.Windows.Forms.Label()
        Me.lblYearThree = New System.Windows.Forms.Label()
        Me.ucrReceiverYearThree = New instat.ucrReceiverSingle()
        Me.ucrReceiverDayThree = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonthThree = New instat.ucrReceiverSingle()
        Me.rdoThreeColumns = New System.Windows.Forms.RadioButton()
        Me.rdoTwoColumns = New System.Windows.Forms.RadioButton()
        Me.rdoSingleColumn = New System.Windows.Forms.RadioButton()
        Me.grpFormats = New System.Windows.Forms.GroupBox()
        Me.txtTextDateFormats = New System.Windows.Forms.RichTextBox()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.ucrPnlDate = New instat.UcrPanel()
        Me.ucrSaveDate = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorMakeDate = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ttMakeDate = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpTwoColumns.SuspendLayout()
        Me.grpSingleColumn.SuspendLayout()
        Me.grpFormatField.SuspendLayout()
        Me.grpThreeColumns.SuspendLayout()
        Me.grpFormats.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTwoColumns
        '
        Me.grpTwoColumns.Controls.Add(Me.ucrChkTwoDigitYear)
        Me.grpTwoColumns.Controls.Add(Me.ucrNudCutoff)
        Me.grpTwoColumns.Controls.Add(Me.lblCutOffTwo)
        Me.grpTwoColumns.Controls.Add(Me.ucrInputComboBoxMonthTwo)
        Me.grpTwoColumns.Controls.Add(Me.lblYearTwo)
        Me.grpTwoColumns.Controls.Add(Me.ucrReceiverYearTwo)
        Me.grpTwoColumns.Controls.Add(Me.lblDayofYear)
        Me.grpTwoColumns.Controls.Add(Me.ucrReceiverDayTwo)
        resources.ApplyResources(Me.grpTwoColumns, "grpTwoColumns")
        Me.grpTwoColumns.Name = "grpTwoColumns"
        Me.grpTwoColumns.TabStop = False
        '
        'ucrChkTwoDigitYear
        '
        Me.ucrChkTwoDigitYear.Checked = False
        resources.ApplyResources(Me.ucrChkTwoDigitYear, "ucrChkTwoDigitYear")
        Me.ucrChkTwoDigitYear.Name = "ucrChkTwoDigitYear"
        '
        'ucrNudCutoff
        '
        Me.ucrNudCutoff.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCutoff.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudCutoff, "ucrNudCutoff")
        Me.ucrNudCutoff.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCutoff.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCutoff.Name = "ucrNudCutoff"
        Me.ucrNudCutoff.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblCutOffTwo
        '
        resources.ApplyResources(Me.lblCutOffTwo, "lblCutOffTwo")
        Me.lblCutOffTwo.Name = "lblCutOffTwo"
        '
        'ucrInputComboBoxMonthTwo
        '
        Me.ucrInputComboBoxMonthTwo.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxMonthTwo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboBoxMonthTwo, "ucrInputComboBoxMonthTwo")
        Me.ucrInputComboBoxMonthTwo.Name = "ucrInputComboBoxMonthTwo"
        '
        'lblYearTwo
        '
        resources.ApplyResources(Me.lblYearTwo, "lblYearTwo")
        Me.lblYearTwo.Name = "lblYearTwo"
        '
        'ucrReceiverYearTwo
        '
        Me.ucrReceiverYearTwo.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYearTwo, "ucrReceiverYearTwo")
        Me.ucrReceiverYearTwo.Name = "ucrReceiverYearTwo"
        Me.ucrReceiverYearTwo.Selector = Nothing
        Me.ucrReceiverYearTwo.strNcFilePath = ""
        Me.ucrReceiverYearTwo.ucrSelector = Nothing
        '
        'lblDayofYear
        '
        resources.ApplyResources(Me.lblDayofYear, "lblDayofYear")
        Me.lblDayofYear.Name = "lblDayofYear"
        '
        'ucrReceiverDayTwo
        '
        Me.ucrReceiverDayTwo.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDayTwo, "ucrReceiverDayTwo")
        Me.ucrReceiverDayTwo.Name = "ucrReceiverDayTwo"
        Me.ucrReceiverDayTwo.Selector = Nothing
        Me.ucrReceiverDayTwo.strNcFilePath = ""
        Me.ucrReceiverDayTwo.ucrSelector = Nothing
        '
        'grpSingleColumn
        '
        Me.grpSingleColumn.Controls.Add(Me.grpFormatField)
        Me.grpSingleColumn.Controls.Add(Me.rdoSpecifyFormat)
        Me.grpSingleColumn.Controls.Add(Me.rdoSpecifyOrigin)
        Me.grpSingleColumn.Controls.Add(Me.rdoDefaultFormat)
        Me.grpSingleColumn.Controls.Add(Me.ucrPnlFormat)
        Me.grpSingleColumn.Controls.Add(Me.ucrReceiverForDate)
        Me.grpSingleColumn.Controls.Add(Me.ucrInputFormat)
        Me.grpSingleColumn.Controls.Add(Me.ucrInputOrigin)
        resources.ApplyResources(Me.grpSingleColumn, "grpSingleColumn")
        Me.grpSingleColumn.Name = "grpSingleColumn"
        Me.grpSingleColumn.TabStop = False
        '
        'grpFormatField
        '
        Me.grpFormatField.Controls.Add(Me.Label1)
        Me.grpFormatField.Controls.Add(Me.Label2)
        Me.grpFormatField.Controls.Add(Me.Label3)
        Me.grpFormatField.Controls.Add(Me.Label4)
        Me.grpFormatField.Controls.Add(Me.UcrInputComboBox1)
        Me.grpFormatField.Controls.Add(Me.UcrInputComboBox2)
        Me.grpFormatField.Controls.Add(Me.UcrInputComboBox3)
        Me.grpFormatField.Controls.Add(Me.UcrInputComboBox4)
        resources.ApplyResources(Me.grpFormatField, "grpFormatField")
        Me.grpFormatField.Name = "grpFormatField"
        Me.grpFormatField.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'UcrInputComboBox1
        '
        Me.UcrInputComboBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox1.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputComboBox1, "UcrInputComboBox1")
        Me.UcrInputComboBox1.Name = "UcrInputComboBox1"
        '
        'UcrInputComboBox2
        '
        Me.UcrInputComboBox2.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox2.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputComboBox2, "UcrInputComboBox2")
        Me.UcrInputComboBox2.Name = "UcrInputComboBox2"
        '
        'UcrInputComboBox3
        '
        Me.UcrInputComboBox3.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox3.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputComboBox3, "UcrInputComboBox3")
        Me.UcrInputComboBox3.Name = "UcrInputComboBox3"
        '
        'UcrInputComboBox4
        '
        Me.UcrInputComboBox4.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox4.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputComboBox4, "UcrInputComboBox4")
        Me.UcrInputComboBox4.Name = "UcrInputComboBox4"
        '
        'rdoSpecifyFormat
        '
        resources.ApplyResources(Me.rdoSpecifyFormat, "rdoSpecifyFormat")
        Me.rdoSpecifyFormat.Name = "rdoSpecifyFormat"
        Me.rdoSpecifyFormat.TabStop = True
        Me.rdoSpecifyFormat.UseVisualStyleBackColor = True
        '
        'rdoSpecifyOrigin
        '
        resources.ApplyResources(Me.rdoSpecifyOrigin, "rdoSpecifyOrigin")
        Me.rdoSpecifyOrigin.Name = "rdoSpecifyOrigin"
        Me.rdoSpecifyOrigin.TabStop = True
        Me.rdoSpecifyOrigin.UseVisualStyleBackColor = True
        '
        'rdoDefaultFormat
        '
        resources.ApplyResources(Me.rdoDefaultFormat, "rdoDefaultFormat")
        Me.rdoDefaultFormat.Name = "rdoDefaultFormat"
        Me.rdoDefaultFormat.TabStop = True
        Me.rdoDefaultFormat.UseVisualStyleBackColor = True
        '
        'ucrPnlFormat
        '
        resources.ApplyResources(Me.ucrPnlFormat, "ucrPnlFormat")
        Me.ucrPnlFormat.Name = "ucrPnlFormat"
        '
        'ucrReceiverForDate
        '
        Me.ucrReceiverForDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverForDate, "ucrReceiverForDate")
        Me.ucrReceiverForDate.Name = "ucrReceiverForDate"
        Me.ucrReceiverForDate.Selector = Nothing
        Me.ucrReceiverForDate.strNcFilePath = ""
        Me.ucrReceiverForDate.ucrSelector = Nothing
        '
        'ucrInputFormat
        '
        Me.ucrInputFormat.AddQuotesIfUnrecognised = True
        Me.ucrInputFormat.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFormat, "ucrInputFormat")
        Me.ucrInputFormat.Name = "ucrInputFormat"
        '
        'ucrInputOrigin
        '
        Me.ucrInputOrigin.AddQuotesIfUnrecognised = True
        Me.ucrInputOrigin.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputOrigin, "ucrInputOrigin")
        Me.ucrInputOrigin.Name = "ucrInputOrigin"
        '
        'grpThreeColumns
        '
        Me.grpThreeColumns.Controls.Add(Me.lblYearOption)
        Me.grpThreeColumns.Controls.Add(Me.lblMonthOption)
        Me.grpThreeColumns.Controls.Add(Me.ucrInputMonthOption)
        Me.grpThreeColumns.Controls.Add(Me.ucrInputYearOption)
        Me.grpThreeColumns.Controls.Add(Me.lblDayofMonth)
        Me.grpThreeColumns.Controls.Add(Me.lblMonthThree)
        Me.grpThreeColumns.Controls.Add(Me.lblYearThree)
        Me.grpThreeColumns.Controls.Add(Me.ucrReceiverYearThree)
        Me.grpThreeColumns.Controls.Add(Me.ucrReceiverDayThree)
        Me.grpThreeColumns.Controls.Add(Me.ucrReceiverMonthThree)
        resources.ApplyResources(Me.grpThreeColumns, "grpThreeColumns")
        Me.grpThreeColumns.Name = "grpThreeColumns"
        Me.grpThreeColumns.TabStop = False
        '
        'lblYearOption
        '
        resources.ApplyResources(Me.lblYearOption, "lblYearOption")
        Me.lblYearOption.Name = "lblYearOption"
        '
        'lblMonthOption
        '
        resources.ApplyResources(Me.lblMonthOption, "lblMonthOption")
        Me.lblMonthOption.Name = "lblMonthOption"
        '
        'ucrInputMonthOption
        '
        Me.ucrInputMonthOption.AddQuotesIfUnrecognised = True
        Me.ucrInputMonthOption.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMonthOption, "ucrInputMonthOption")
        Me.ucrInputMonthOption.Name = "ucrInputMonthOption"
        '
        'ucrInputYearOption
        '
        Me.ucrInputYearOption.AddQuotesIfUnrecognised = True
        Me.ucrInputYearOption.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYearOption, "ucrInputYearOption")
        Me.ucrInputYearOption.Name = "ucrInputYearOption"
        '
        'lblDayofMonth
        '
        resources.ApplyResources(Me.lblDayofMonth, "lblDayofMonth")
        Me.lblDayofMonth.Name = "lblDayofMonth"
        '
        'lblMonthThree
        '
        resources.ApplyResources(Me.lblMonthThree, "lblMonthThree")
        Me.lblMonthThree.Name = "lblMonthThree"
        '
        'lblYearThree
        '
        resources.ApplyResources(Me.lblYearThree, "lblYearThree")
        Me.lblYearThree.Name = "lblYearThree"
        '
        'ucrReceiverYearThree
        '
        Me.ucrReceiverYearThree.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYearThree, "ucrReceiverYearThree")
        Me.ucrReceiverYearThree.Name = "ucrReceiverYearThree"
        Me.ucrReceiverYearThree.Selector = Nothing
        Me.ucrReceiverYearThree.strNcFilePath = ""
        Me.ucrReceiverYearThree.ucrSelector = Nothing
        '
        'ucrReceiverDayThree
        '
        Me.ucrReceiverDayThree.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDayThree, "ucrReceiverDayThree")
        Me.ucrReceiverDayThree.Name = "ucrReceiverDayThree"
        Me.ucrReceiverDayThree.Selector = Nothing
        Me.ucrReceiverDayThree.strNcFilePath = ""
        Me.ucrReceiverDayThree.ucrSelector = Nothing
        '
        'ucrReceiverMonthThree
        '
        Me.ucrReceiverMonthThree.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMonthThree, "ucrReceiverMonthThree")
        Me.ucrReceiverMonthThree.Name = "ucrReceiverMonthThree"
        Me.ucrReceiverMonthThree.Selector = Nothing
        Me.ucrReceiverMonthThree.strNcFilePath = ""
        Me.ucrReceiverMonthThree.ucrSelector = Nothing
        '
        'rdoThreeColumns
        '
        resources.ApplyResources(Me.rdoThreeColumns, "rdoThreeColumns")
        Me.rdoThreeColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreeColumns.FlatAppearance.BorderSize = 2
        Me.rdoThreeColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreeColumns.Name = "rdoThreeColumns"
        Me.rdoThreeColumns.UseVisualStyleBackColor = True
        '
        'rdoTwoColumns
        '
        resources.ApplyResources(Me.rdoTwoColumns, "rdoTwoColumns")
        Me.rdoTwoColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoColumns.FlatAppearance.BorderSize = 2
        Me.rdoTwoColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoColumns.Name = "rdoTwoColumns"
        Me.rdoTwoColumns.UseVisualStyleBackColor = True
        '
        'rdoSingleColumn
        '
        resources.ApplyResources(Me.rdoSingleColumn, "rdoSingleColumn")
        Me.rdoSingleColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingleColumn.FlatAppearance.BorderSize = 2
        Me.rdoSingleColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingleColumn.Name = "rdoSingleColumn"
        Me.rdoSingleColumn.UseVisualStyleBackColor = True
        '
        'grpFormats
        '
        Me.grpFormats.Controls.Add(Me.txtTextDateFormats)
        resources.ApplyResources(Me.grpFormats, "grpFormats")
        Me.grpFormats.Name = "grpFormats"
        Me.grpFormats.TabStop = False
        '
        'txtTextDateFormats
        '
        resources.ApplyResources(Me.txtTextDateFormats, "txtTextDateFormats")
        Me.txtTextDateFormats.Name = "txtTextDateFormats"
        '
        'cmdHelp
        '
        resources.ApplyResources(Me.cmdHelp, "cmdHelp")
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'ucrPnlDate
        '
        resources.ApplyResources(Me.ucrPnlDate, "ucrPnlDate")
        Me.ucrPnlDate.Name = "ucrPnlDate"
        '
        'ucrSaveDate
        '
        resources.ApplyResources(Me.ucrSaveDate, "ucrSaveDate")
        Me.ucrSaveDate.Name = "ucrSaveDate"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorMakeDate
        '
        Me.ucrSelectorMakeDate.bShowHiddenColumns = False
        Me.ucrSelectorMakeDate.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorMakeDate, "ucrSelectorMakeDate")
        Me.ucrSelectorMakeDate.Name = "ucrSelectorMakeDate"
        '
        'dlgMakeDate
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.grpFormats)
        Me.Controls.Add(Me.rdoThreeColumns)
        Me.Controls.Add(Me.rdoTwoColumns)
        Me.Controls.Add(Me.rdoSingleColumn)
        Me.Controls.Add(Me.ucrPnlDate)
        Me.Controls.Add(Me.ucrSaveDate)
        Me.Controls.Add(Me.grpSingleColumn)
        Me.Controls.Add(Me.grpTwoColumns)
        Me.Controls.Add(Me.grpThreeColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorMakeDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMakeDate"
        Me.grpTwoColumns.ResumeLayout(False)
        Me.grpTwoColumns.PerformLayout()
        Me.grpSingleColumn.ResumeLayout(False)
        Me.grpSingleColumn.PerformLayout()
        Me.grpFormatField.ResumeLayout(False)
        Me.grpFormatField.PerformLayout()
        Me.grpThreeColumns.ResumeLayout(False)
        Me.grpThreeColumns.PerformLayout()
        Me.grpFormats.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSelectorMakeDate As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpTwoColumns As GroupBox
    Friend WithEvents grpThreeColumns As GroupBox
    Friend WithEvents grpSingleColumn As GroupBox
    Friend WithEvents ucrSaveDate As ucrSave
    Friend WithEvents lblCutOffTwo As Label
    Friend WithEvents ucrInputComboBoxMonthTwo As ucrInputComboBox
    Friend WithEvents lblYearTwo As Label
    Friend WithEvents ucrReceiverYearTwo As ucrReceiverSingle
    Friend WithEvents lblDayofYear As Label
    Friend WithEvents ucrReceiverDayTwo As ucrReceiverSingle
    Friend WithEvents lblYearOption As Label
    Friend WithEvents lblMonthOption As Label
    Friend WithEvents ucrInputMonthOption As ucrInputComboBox
    Friend WithEvents ucrInputYearOption As ucrInputComboBox
    Friend WithEvents lblDayofMonth As Label
    Friend WithEvents lblMonthThree As Label
    Friend WithEvents lblYearThree As Label
    Friend WithEvents ucrReceiverYearThree As ucrReceiverSingle
    Friend WithEvents ucrReceiverDayThree As ucrReceiverSingle
    Friend WithEvents ucrReceiverMonthThree As ucrReceiverSingle
    Friend WithEvents ucrChkTwoDigitYear As ucrCheck
    Friend WithEvents ucrNudCutoff As ucrNud
    Friend WithEvents ucrInputFormat As ucrInputComboBox
    Friend WithEvents ucrInputOrigin As ucrInputComboBox
    Friend WithEvents ucrReceiverForDate As ucrReceiverSingle
    Friend WithEvents rdoSpecifyFormat As RadioButton
    Friend WithEvents rdoSpecifyOrigin As RadioButton
    Friend WithEvents rdoDefaultFormat As RadioButton
    Friend WithEvents ucrPnlFormat As UcrPanel
    Friend WithEvents grpFormatField As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UcrInputComboBox1 As ucrInputComboBox
    Friend WithEvents UcrInputComboBox2 As ucrInputComboBox
    Friend WithEvents UcrInputComboBox3 As ucrInputComboBox
    Friend WithEvents UcrInputComboBox4 As ucrInputComboBox
    Friend WithEvents rdoThreeColumns As RadioButton
    Friend WithEvents rdoTwoColumns As RadioButton
    Friend WithEvents rdoSingleColumn As RadioButton
    Friend WithEvents ucrPnlDate As UcrPanel
    Friend WithEvents grpFormats As GroupBox
    Friend WithEvents txtTextDateFormats As RichTextBox
    Friend WithEvents cmdHelp As Button
    Friend WithEvents ttMakeDate As ToolTip
End Class