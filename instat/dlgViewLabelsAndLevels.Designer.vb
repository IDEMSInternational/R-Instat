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
Partial Class dlgViewFactorLabels
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
        Me.lblFactorColumns = New System.Windows.Forms.Label()
        Me.grpSummaryStatistics = New System.Windows.Forms.GroupBox()
        Me.grpDisplayOptions = New System.Windows.Forms.GroupBox()
        Me.grpLabels = New System.Windows.Forms.GroupBox()
        Me.rdoDeleteValueLabels = New System.Windows.Forms.RadioButton()
        Me.rdoViewLabels = New System.Windows.Forms.RadioButton()
        Me.rdoSelectedColumn = New System.Windows.Forms.RadioButton()
        Me.rdoWholeDataFrame = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSelectData = New instat.UcrPanel()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrChkShowType = New instat.ucrCheck()
        Me.ucrChkShowValues = New instat.ucrCheck()
        Me.ucrChkShowLabels = New instat.ucrCheck()
        Me.ucrChkSortByName = New instat.ucrCheck()
        Me.ucrChkAlternateColour = New instat.ucrCheck()
        Me.ucrChkShowId = New instat.ucrCheck()
        Me.ucrChkShowPercentage = New instat.ucrCheck()
        Me.ucrChkShowFrequencies = New instat.ucrCheck()
        Me.ucrChkShowMissingValues = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverVariables = New instat.ucrReceiverMultiple()
        Me.ucrSelectorViewLabelsAndLevels = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpSummaryStatistics.SuspendLayout()
        Me.grpDisplayOptions.SuspendLayout()
        Me.grpLabels.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactorColumns
        '
        Me.lblFactorColumns.AutoSize = True
        Me.lblFactorColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorColumns.Location = New System.Drawing.Point(295, 67)
        Me.lblFactorColumns.Name = "lblFactorColumns"
        Me.lblFactorColumns.Size = New System.Drawing.Size(97, 13)
        Me.lblFactorColumns.TabIndex = 1
        Me.lblFactorColumns.Text = "Variable(s) to View:"
        '
        'grpSummaryStatistics
        '
        Me.grpSummaryStatistics.Controls.Add(Me.ucrChkShowPercentage)
        Me.grpSummaryStatistics.Controls.Add(Me.ucrChkShowFrequencies)
        Me.grpSummaryStatistics.Controls.Add(Me.ucrChkShowMissingValues)
        Me.grpSummaryStatistics.Location = New System.Drawing.Point(202, 242)
        Me.grpSummaryStatistics.Name = "grpSummaryStatistics"
        Me.grpSummaryStatistics.Size = New System.Drawing.Size(166, 95)
        Me.grpSummaryStatistics.TabIndex = 4
        Me.grpSummaryStatistics.TabStop = False
        Me.grpSummaryStatistics.Text = "Summary Statistics"
        '
        'grpDisplayOptions
        '
        Me.grpDisplayOptions.Controls.Add(Me.ucrChkSortByName)
        Me.grpDisplayOptions.Controls.Add(Me.ucrChkAlternateColour)
        Me.grpDisplayOptions.Controls.Add(Me.ucrChkShowId)
        Me.grpDisplayOptions.Location = New System.Drawing.Point(374, 242)
        Me.grpDisplayOptions.Name = "grpDisplayOptions"
        Me.grpDisplayOptions.Size = New System.Drawing.Size(152, 95)
        Me.grpDisplayOptions.TabIndex = 5
        Me.grpDisplayOptions.TabStop = False
        Me.grpDisplayOptions.Text = "Display Options"
        '
        'grpLabels
        '
        Me.grpLabels.Controls.Add(Me.ucrChkShowType)
        Me.grpLabels.Controls.Add(Me.ucrChkShowValues)
        Me.grpLabels.Controls.Add(Me.ucrChkShowLabels)
        Me.grpLabels.Location = New System.Drawing.Point(2, 242)
        Me.grpLabels.Name = "grpLabels"
        Me.grpLabels.Size = New System.Drawing.Size(194, 95)
        Me.grpLabels.TabIndex = 3
        Me.grpLabels.TabStop = False
        Me.grpLabels.Text = "Variable Options"
        '
        'rdoDeleteValueLabels
        '
        Me.rdoDeleteValueLabels.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDeleteValueLabels.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDeleteValueLabels.FlatAppearance.BorderSize = 2
        Me.rdoDeleteValueLabels.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDeleteValueLabels.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDeleteValueLabels.Location = New System.Drawing.Point(267, 12)
        Me.rdoDeleteValueLabels.Name = "rdoDeleteValueLabels"
        Me.rdoDeleteValueLabels.Size = New System.Drawing.Size(121, 28)
        Me.rdoDeleteValueLabels.TabIndex = 9
        Me.rdoDeleteValueLabels.TabStop = True
        Me.rdoDeleteValueLabels.Text = "Delete Value Labels"
        Me.rdoDeleteValueLabels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDeleteValueLabels.UseVisualStyleBackColor = True
        '
        'rdoViewLabels
        '
        Me.rdoViewLabels.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoViewLabels.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoViewLabels.FlatAppearance.BorderSize = 2
        Me.rdoViewLabels.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoViewLabels.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoViewLabels.Location = New System.Drawing.Point(151, 12)
        Me.rdoViewLabels.Name = "rdoViewLabels"
        Me.rdoViewLabels.Size = New System.Drawing.Size(121, 28)
        Me.rdoViewLabels.TabIndex = 8
        Me.rdoViewLabels.TabStop = True
        Me.rdoViewLabels.Text = "View Labels/Levels"
        Me.rdoViewLabels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoViewLabels.UseVisualStyleBackColor = True
        '
        'rdoSelectedColumn
        '
        Me.rdoSelectedColumn.Location = New System.Drawing.Point(302, 82)
        Me.rdoSelectedColumn.Name = "rdoSelectedColumn"
        Me.rdoSelectedColumn.Size = New System.Drawing.Size(174, 24)
        Me.rdoSelectedColumn.TabIndex = 12
        Me.rdoSelectedColumn.TabStop = True
        Me.rdoSelectedColumn.Text = "Selected Variables:"
        Me.rdoSelectedColumn.UseVisualStyleBackColor = True
        '
        'rdoWholeDataFrame
        '
        Me.rdoWholeDataFrame.AutoSize = True
        Me.rdoWholeDataFrame.Location = New System.Drawing.Point(302, 59)
        Me.rdoWholeDataFrame.Name = "rdoWholeDataFrame"
        Me.rdoWholeDataFrame.Size = New System.Drawing.Size(80, 17)
        Me.rdoWholeDataFrame.TabIndex = 11
        Me.rdoWholeDataFrame.TabStop = True
        Me.rdoWholeDataFrame.Text = "Data Frame"
        Me.rdoWholeDataFrame.UseVisualStyleBackColor = True
        '
        'ucrPnlSelectData
        '
        Me.ucrPnlSelectData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSelectData.Location = New System.Drawing.Point(300, 59)
        Me.ucrPnlSelectData.Name = "ucrPnlSelectData"
        Me.ucrPnlSelectData.Size = New System.Drawing.Size(142, 49)
        Me.ucrPnlSelectData.TabIndex = 10
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(145, 2)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(250, 46)
        Me.ucrPnlOptions.TabIndex = 7
        '
        'ucrChkShowType
        '
        Me.ucrChkShowType.AutoSize = True
        Me.ucrChkShowType.Checked = False
        Me.ucrChkShowType.Location = New System.Drawing.Point(4, 66)
        Me.ucrChkShowType.Name = "ucrChkShowType"
        Me.ucrChkShowType.Size = New System.Drawing.Size(174, 23)
        Me.ucrChkShowType.TabIndex = 2
        '
        'ucrChkShowValues
        '
        Me.ucrChkShowValues.AutoSize = True
        Me.ucrChkShowValues.Checked = False
        Me.ucrChkShowValues.Location = New System.Drawing.Point(4, 18)
        Me.ucrChkShowValues.Name = "ucrChkShowValues"
        Me.ucrChkShowValues.Size = New System.Drawing.Size(174, 23)
        Me.ucrChkShowValues.TabIndex = 0
        '
        'ucrChkShowLabels
        '
        Me.ucrChkShowLabels.AutoSize = True
        Me.ucrChkShowLabels.Checked = False
        Me.ucrChkShowLabels.Location = New System.Drawing.Point(3, 42)
        Me.ucrChkShowLabels.Name = "ucrChkShowLabels"
        Me.ucrChkShowLabels.Size = New System.Drawing.Size(190, 23)
        Me.ucrChkShowLabels.TabIndex = 1
        '
        'ucrChkSortByName
        '
        Me.ucrChkSortByName.AutoSize = True
        Me.ucrChkSortByName.Checked = False
        Me.ucrChkSortByName.Location = New System.Drawing.Point(4, 42)
        Me.ucrChkSortByName.Name = "ucrChkSortByName"
        Me.ucrChkSortByName.Size = New System.Drawing.Size(133, 23)
        Me.ucrChkSortByName.TabIndex = 1
        '
        'ucrChkAlternateColour
        '
        Me.ucrChkAlternateColour.AutoSize = True
        Me.ucrChkAlternateColour.Checked = False
        Me.ucrChkAlternateColour.Location = New System.Drawing.Point(4, 66)
        Me.ucrChkAlternateColour.Name = "ucrChkAlternateColour"
        Me.ucrChkAlternateColour.Size = New System.Drawing.Size(142, 23)
        Me.ucrChkAlternateColour.TabIndex = 2
        '
        'ucrChkShowId
        '
        Me.ucrChkShowId.AutoSize = True
        Me.ucrChkShowId.Checked = False
        Me.ucrChkShowId.Location = New System.Drawing.Point(4, 18)
        Me.ucrChkShowId.Name = "ucrChkShowId"
        Me.ucrChkShowId.Size = New System.Drawing.Size(133, 23)
        Me.ucrChkShowId.TabIndex = 0
        '
        'ucrChkShowPercentage
        '
        Me.ucrChkShowPercentage.AutoSize = True
        Me.ucrChkShowPercentage.Checked = False
        Me.ucrChkShowPercentage.Location = New System.Drawing.Point(7, 41)
        Me.ucrChkShowPercentage.Name = "ucrChkShowPercentage"
        Me.ucrChkShowPercentage.Size = New System.Drawing.Size(154, 23)
        Me.ucrChkShowPercentage.TabIndex = 1
        '
        'ucrChkShowFrequencies
        '
        Me.ucrChkShowFrequencies.AutoSize = True
        Me.ucrChkShowFrequencies.Checked = False
        Me.ucrChkShowFrequencies.Location = New System.Drawing.Point(7, 17)
        Me.ucrChkShowFrequencies.Name = "ucrChkShowFrequencies"
        Me.ucrChkShowFrequencies.Size = New System.Drawing.Size(143, 23)
        Me.ucrChkShowFrequencies.TabIndex = 0
        '
        'ucrChkShowMissingValues
        '
        Me.ucrChkShowMissingValues.AutoSize = True
        Me.ucrChkShowMissingValues.Checked = False
        Me.ucrChkShowMissingValues.Location = New System.Drawing.Point(7, 65)
        Me.ucrChkShowMissingValues.Name = "ucrChkShowMissingValues"
        Me.ucrChkShowMissingValues.Size = New System.Drawing.Size(143, 23)
        Me.ucrChkShowMissingValues.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 345)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 6
        '
        'ucrReceiverVariables
        '
        Me.ucrReceiverVariables.AutoSize = True
        Me.ucrReceiverVariables.frmParent = Me
        Me.ucrReceiverVariables.Location = New System.Drawing.Point(295, 84)
        Me.ucrReceiverVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariables.Name = "ucrReceiverVariables"
        Me.ucrReceiverVariables.Selector = Nothing
        Me.ucrReceiverVariables.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverVariables.strNcFilePath = ""
        Me.ucrReceiverVariables.TabIndex = 2
        Me.ucrReceiverVariables.ucrSelector = Nothing
        '
        'ucrSelectorViewLabelsAndLevels
        '
        Me.ucrSelectorViewLabelsAndLevels.AutoSize = True
        Me.ucrSelectorViewLabelsAndLevels.bDropUnusedFilterLevels = False
        Me.ucrSelectorViewLabelsAndLevels.bShowHiddenColumns = False
        Me.ucrSelectorViewLabelsAndLevels.bUseCurrentFilter = True
        Me.ucrSelectorViewLabelsAndLevels.Location = New System.Drawing.Point(10, 52)
        Me.ucrSelectorViewLabelsAndLevels.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorViewLabelsAndLevels.Name = "ucrSelectorViewLabelsAndLevels"
        Me.ucrSelectorViewLabelsAndLevels.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorViewLabelsAndLevels.TabIndex = 0
        '
        'dlgViewFactorLabels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(528, 401)
        Me.Controls.Add(Me.rdoSelectedColumn)
        Me.Controls.Add(Me.rdoWholeDataFrame)
        Me.Controls.Add(Me.ucrPnlSelectData)
        Me.Controls.Add(Me.rdoDeleteValueLabels)
        Me.Controls.Add(Me.rdoViewLabels)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.grpLabels)
        Me.Controls.Add(Me.grpDisplayOptions)
        Me.Controls.Add(Me.grpSummaryStatistics)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblFactorColumns)
        Me.Controls.Add(Me.ucrReceiverVariables)
        Me.Controls.Add(Me.ucrSelectorViewLabelsAndLevels)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgViewFactorLabels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View/Delete Labels"
        Me.grpSummaryStatistics.ResumeLayout(False)
        Me.grpSummaryStatistics.PerformLayout()
        Me.grpDisplayOptions.ResumeLayout(False)
        Me.grpDisplayOptions.PerformLayout()
        Me.grpLabels.ResumeLayout(False)
        Me.grpLabels.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorViewLabelsAndLevels As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverVariables As ucrReceiverMultiple
    Friend WithEvents lblFactorColumns As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpSummaryStatistics As GroupBox
    Friend WithEvents ucrChkShowId As ucrCheck
    Friend WithEvents ucrChkShowPercentage As ucrCheck
    Friend WithEvents ucrChkSortByName As ucrCheck
    Friend WithEvents ucrChkShowValues As ucrCheck
    Friend WithEvents ucrChkShowFrequencies As ucrCheck
    Friend WithEvents ucrChkShowLabels As ucrCheck
    Friend WithEvents ucrChkShowType As ucrCheck
    Friend WithEvents ucrChkShowMissingValues As ucrCheck
    Friend WithEvents ucrChkAlternateColour As ucrCheck
    Friend WithEvents grpLabels As GroupBox
    Friend WithEvents grpDisplayOptions As GroupBox
    Friend WithEvents rdoDeleteValueLabels As RadioButton
    Friend WithEvents rdoViewLabels As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents rdoSelectedColumn As RadioButton
    Friend WithEvents rdoWholeDataFrame As RadioButton
    Friend WithEvents ucrPnlSelectData As UcrPanel
End Class
