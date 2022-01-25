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
Partial Class dlgClimaticSummary
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
        Me.rdoAnnual = New System.Windows.Forms.RadioButton()
        Me.rdoWithinYear = New System.Windows.Forms.RadioButton()
        Me.rdoAnnualWithinYear = New System.Windows.Forms.RadioButton()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.cmdSummary = New System.Windows.Forms.Button()
        Me.lblWithinYear = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.cmdMissingOptions = New System.Windows.Forms.Button()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrChkAddDateColumn = New instat.ucrCheck()
        Me.ucrChkStoreResults = New instat.ucrCheck()
        Me.ucrChkPrintOutput = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevels = New instat.ucrCheck()
        Me.cmdDoyRange = New System.Windows.Forms.Button()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.rdoStation = New System.Windows.Forms.RadioButton()
        Me.rdoDaily = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverElements = New instat.ucrReceiverMultiple()
        Me.ucrInputFilterPreview = New instat.ucrInputTextBox()
        Me.ucrSelectorVariable = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverWithinYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlAnnualWithin = New instat.UcrPanel()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoAnnual
        '
        Me.rdoAnnual.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoAnnual.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAnnual.FlatAppearance.BorderSize = 2
        Me.rdoAnnual.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAnnual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoAnnual.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAnnual.Location = New System.Drawing.Point(71, 14)
        Me.rdoAnnual.Name = "rdoAnnual"
        Me.rdoAnnual.Size = New System.Drawing.Size(67, 27)
        Me.rdoAnnual.TabIndex = 1
        Me.rdoAnnual.TabStop = True
        Me.rdoAnnual.Text = "Annual"
        Me.rdoAnnual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoAnnual.UseVisualStyleBackColor = True
        '
        'rdoWithinYear
        '
        Me.rdoWithinYear.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoWithinYear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWithinYear.FlatAppearance.BorderSize = 2
        Me.rdoWithinYear.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWithinYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoWithinYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoWithinYear.Location = New System.Drawing.Point(222, 14)
        Me.rdoWithinYear.Name = "rdoWithinYear"
        Me.rdoWithinYear.Size = New System.Drawing.Size(88, 27)
        Me.rdoWithinYear.TabIndex = 3
        Me.rdoWithinYear.TabStop = True
        Me.rdoWithinYear.Text = "Within Year"
        Me.rdoWithinYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoWithinYear.UseVisualStyleBackColor = True
        '
        'rdoAnnualWithinYear
        '
        Me.rdoAnnualWithinYear.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoAnnualWithinYear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAnnualWithinYear.FlatAppearance.BorderSize = 2
        Me.rdoAnnualWithinYear.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAnnualWithinYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoAnnualWithinYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAnnualWithinYear.Location = New System.Drawing.Point(136, 14)
        Me.rdoAnnualWithinYear.Name = "rdoAnnualWithinYear"
        Me.rdoAnnualWithinYear.Size = New System.Drawing.Size(88, 27)
        Me.rdoAnnualWithinYear.TabIndex = 2
        Me.rdoAnnualWithinYear.TabStop = True
        Me.rdoAnnualWithinYear.Text = "Annual+Within"
        Me.rdoAnnualWithinYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoAnnualWithinYear.UseVisualStyleBackColor = True
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(288, 68)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 5
        Me.lblStation.Text = "Station:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(288, 109)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "Date:"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDay.Location = New System.Drawing.Point(288, 245)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(66, 13)
        Me.lblDay.TabIndex = 11
        Me.lblDay.Text = "Day of Year:"
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblElement.Location = New System.Drawing.Point(288, 150)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(48, 13)
        Me.lblElement.TabIndex = 9
        Me.lblElement.Text = "Element:"
        '
        'cmdSummary
        '
        Me.cmdSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSummary.Location = New System.Drawing.Point(288, 371)
        Me.cmdSummary.Name = "cmdSummary"
        Me.cmdSummary.Size = New System.Drawing.Size(120, 26)
        Me.cmdSummary.TabIndex = 17
        Me.cmdSummary.Tag = "Summaries"
        Me.cmdSummary.Text = "Summaries"
        Me.cmdSummary.UseVisualStyleBackColor = True
        '
        'lblWithinYear
        '
        Me.lblWithinYear.AutoSize = True
        Me.lblWithinYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWithinYear.Location = New System.Drawing.Point(288, 327)
        Me.lblWithinYear.Name = "lblWithinYear"
        Me.lblWithinYear.Size = New System.Drawing.Size(65, 13)
        Me.lblWithinYear.TabIndex = 15
        Me.lblWithinYear.Text = "Within Year:"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.cmdMissingOptions)
        Me.grpOptions.Controls.Add(Me.ucrChkOmitMissing)
        Me.grpOptions.Controls.Add(Me.ucrChkAddDateColumn)
        Me.grpOptions.Controls.Add(Me.ucrChkStoreResults)
        Me.grpOptions.Controls.Add(Me.ucrChkPrintOutput)
        Me.grpOptions.Controls.Add(Me.ucrChkDropUnusedLevels)
        Me.grpOptions.Location = New System.Drawing.Point(5, 233)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(280, 136)
        Me.grpOptions.TabIndex = 18
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'cmdMissingOptions
        '
        Me.cmdMissingOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMissingOptions.Location = New System.Drawing.Point(217, 83)
        Me.cmdMissingOptions.Name = "cmdMissingOptions"
        Me.cmdMissingOptions.Size = New System.Drawing.Size(60, 26)
        Me.cmdMissingOptions.TabIndex = 19
        Me.cmdMissingOptions.Tag = "MissingOptions"
        Me.cmdMissingOptions.Text = "Options"
        Me.cmdMissingOptions.UseVisualStyleBackColor = True
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.AutoSize = True
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(6, 86)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(178, 23)
        Me.ucrChkOmitMissing.TabIndex = 5
        '
        'ucrChkAddDateColumn
        '
        Me.ucrChkAddDateColumn.AutoSize = True
        Me.ucrChkAddDateColumn.Checked = False
        Me.ucrChkAddDateColumn.Location = New System.Drawing.Point(6, 109)
        Me.ucrChkAddDateColumn.Name = "ucrChkAddDateColumn"
        Me.ucrChkAddDateColumn.Size = New System.Drawing.Size(219, 23)
        Me.ucrChkAddDateColumn.TabIndex = 4
        '
        'ucrChkStoreResults
        '
        Me.ucrChkStoreResults.AutoSize = True
        Me.ucrChkStoreResults.Checked = False
        Me.ucrChkStoreResults.Location = New System.Drawing.Point(6, 17)
        Me.ucrChkStoreResults.Name = "ucrChkStoreResults"
        Me.ucrChkStoreResults.Size = New System.Drawing.Size(255, 23)
        Me.ucrChkStoreResults.TabIndex = 0
        '
        'ucrChkPrintOutput
        '
        Me.ucrChkPrintOutput.AutoSize = True
        Me.ucrChkPrintOutput.Checked = False
        Me.ucrChkPrintOutput.Location = New System.Drawing.Point(6, 40)
        Me.ucrChkPrintOutput.Name = "ucrChkPrintOutput"
        Me.ucrChkPrintOutput.Size = New System.Drawing.Size(254, 23)
        Me.ucrChkPrintOutput.TabIndex = 1
        '
        'ucrChkDropUnusedLevels
        '
        Me.ucrChkDropUnusedLevels.AutoSize = True
        Me.ucrChkDropUnusedLevels.Checked = False
        Me.ucrChkDropUnusedLevels.Location = New System.Drawing.Point(6, 63)
        Me.ucrChkDropUnusedLevels.Name = "ucrChkDropUnusedLevels"
        Me.ucrChkDropUnusedLevels.Size = New System.Drawing.Size(148, 23)
        Me.ucrChkDropUnusedLevels.TabIndex = 2
        '
        'cmdDoyRange
        '
        Me.cmdDoyRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoyRange.Location = New System.Drawing.Point(5, 397)
        Me.cmdDoyRange.Name = "cmdDoyRange"
        Me.cmdDoyRange.Size = New System.Drawing.Size(105, 26)
        Me.cmdDoyRange.TabIndex = 19
        Me.cmdDoyRange.Tag = ""
        Me.cmdDoyRange.Text = "Day Range"
        Me.cmdDoyRange.UseVisualStyleBackColor = True
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYear.Location = New System.Drawing.Point(288, 286)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 13
        Me.lblYear.Text = "Year:"
        '
        'rdoStation
        '
        Me.rdoStation.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStation.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStation.FlatAppearance.BorderSize = 2
        Me.rdoStation.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStation.Location = New System.Drawing.Point(12, 14)
        Me.rdoStation.Name = "rdoStation"
        Me.rdoStation.Size = New System.Drawing.Size(61, 27)
        Me.rdoStation.TabIndex = 22
        Me.rdoStation.TabStop = True
        Me.rdoStation.Text = "Station"
        Me.rdoStation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStation.UseVisualStyleBackColor = True
        '
        'rdoDaily
        '
        Me.rdoDaily.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDaily.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDaily.FlatAppearance.BorderSize = 2
        Me.rdoDaily.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDaily.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDaily.Location = New System.Drawing.Point(308, 14)
        Me.rdoDaily.Name = "rdoDaily"
        Me.rdoDaily.Size = New System.Drawing.Size(88, 27)
        Me.rdoDaily.TabIndex = 23
        Me.rdoDaily.TabStop = True
        Me.rdoDaily.Text = "Daily"
        Me.rdoDaily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDaily.UseVisualStyleBackColor = True
        '
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.AutoSize = True
        Me.ucrReceiverElements.frmParent = Me
        Me.ucrReceiverElements.Location = New System.Drawing.Point(288, 164)
        Me.ucrReceiverElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElements.Name = "ucrReceiverElements"
        Me.ucrReceiverElements.Selector = Nothing
        Me.ucrReceiverElements.Size = New System.Drawing.Size(123, 78)
        Me.ucrReceiverElements.strNcFilePath = ""
        Me.ucrReceiverElements.TabIndex = 10
        Me.ucrReceiverElements.ucrSelector = Nothing
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.AutoSize = True
        Me.ucrInputFilterPreview.IsMultiline = False
        Me.ucrInputFilterPreview.IsReadOnly = True
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(115, 400)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(242, 22)
        Me.ucrInputFilterPreview.TabIndex = 20
        '
        'ucrSelectorVariable
        '
        Me.ucrSelectorVariable.AutoSize = True
        Me.ucrSelectorVariable.bDropUnusedFilterLevels = False
        Me.ucrSelectorVariable.bShowHiddenColumns = False
        Me.ucrSelectorVariable.bUseCurrentFilter = True
        Me.ucrSelectorVariable.Location = New System.Drawing.Point(5, 48)
        Me.ucrSelectorVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVariable.Name = "ucrSelectorVariable"
        Me.ucrSelectorVariable.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorVariable.TabIndex = 4
        '
        'ucrReceiverWithinYear
        '
        Me.ucrReceiverWithinYear.AutoSize = True
        Me.ucrReceiverWithinYear.frmParent = Me
        Me.ucrReceiverWithinYear.Location = New System.Drawing.Point(288, 342)
        Me.ucrReceiverWithinYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWithinYear.Name = "ucrReceiverWithinYear"
        Me.ucrReceiverWithinYear.Selector = Nothing
        Me.ucrReceiverWithinYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWithinYear.strNcFilePath = ""
        Me.ucrReceiverWithinYear.TabIndex = 16
        Me.ucrReceiverWithinYear.ucrSelector = Nothing
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.AutoSize = True
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(288, 262)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 12
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(288, 302)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 14
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(288, 124)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 8
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(288, 84)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 6
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(5, 422)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 21
        '
        'ucrPnlAnnualWithin
        '
        Me.ucrPnlAnnualWithin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlAnnualWithin.Location = New System.Drawing.Point(9, 10)
        Me.ucrPnlAnnualWithin.Name = "ucrPnlAnnualWithin"
        Me.ucrPnlAnnualWithin.Size = New System.Drawing.Size(396, 35)
        Me.ucrPnlAnnualWithin.TabIndex = 0
        '
        'dlgClimaticSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(414, 480)
        Me.Controls.Add(Me.rdoDaily)
        Me.Controls.Add(Me.rdoStation)
        Me.Controls.Add(Me.ucrReceiverElements)
        Me.Controls.Add(Me.ucrInputFilterPreview)
        Me.Controls.Add(Me.cmdDoyRange)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.ucrSelectorVariable)
        Me.Controls.Add(Me.ucrReceiverWithinYear)
        Me.Controls.Add(Me.lblWithinYear)
        Me.Controls.Add(Me.cmdSummary)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverDOY)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.rdoAnnualWithinYear)
        Me.Controls.Add(Me.rdoWithinYear)
        Me.Controls.Add(Me.rdoAnnual)
        Me.Controls.Add(Me.ucrPnlAnnualWithin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Climatic Summary"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoAnnual As RadioButton
    Friend WithEvents rdoWithinYear As RadioButton
    Friend WithEvents rdoAnnualWithinYear As RadioButton
    Friend WithEvents ucrPnlAnnualWithin As UcrPanel
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblStation As Label
    Friend WithEvents lblElement As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents cmdSummary As Button
    Friend WithEvents lblWithinYear As Label
    Friend WithEvents ucrReceiverWithinYear As ucrReceiverSingle
    Friend WithEvents ucrSelectorVariable As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents ucrChkStoreResults As ucrCheck
    Friend WithEvents ucrChkPrintOutput As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevels As ucrCheck
    Friend WithEvents cmdDoyRange As Button
    Friend WithEvents ucrInputFilterPreview As ucrInputTextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrChkAddDateColumn As ucrCheck
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents cmdMissingOptions As Button
    Friend WithEvents ucrReceiverElements As ucrReceiverMultiple
    Friend WithEvents rdoStation As RadioButton
    Friend WithEvents rdoDaily As RadioButton
End Class
