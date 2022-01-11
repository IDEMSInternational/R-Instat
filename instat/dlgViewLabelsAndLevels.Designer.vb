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
        Me.ucrChkShowPercentage = New instat.ucrCheck()
        Me.ucrChkShowFrequencies = New instat.ucrCheck()
        Me.ucrChkShowMissingValues = New instat.ucrCheck()
        Me.grpDisplayOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkSortByName = New instat.ucrCheck()
        Me.ucrChkAlternateColour = New instat.ucrCheck()
        Me.ucrChkShowId = New instat.ucrCheck()
        Me.grpLabels = New System.Windows.Forms.GroupBox()
        Me.ucrChkShowType = New instat.ucrCheck()
        Me.ucrChkShowValues = New instat.ucrCheck()
        Me.ucrChkShowLabels = New instat.ucrCheck()
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
        Me.lblFactorColumns.Location = New System.Drawing.Point(303, 45)
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
        Me.grpSummaryStatistics.Location = New System.Drawing.Point(202, 199)
        Me.grpSummaryStatistics.Name = "grpSummaryStatistics"
        Me.grpSummaryStatistics.Size = New System.Drawing.Size(166, 90)
        Me.grpSummaryStatistics.TabIndex = 4
        Me.grpSummaryStatistics.TabStop = False
        Me.grpSummaryStatistics.Text = "Summary Statistics"
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
        'grpDisplayOptions
        '
        Me.grpDisplayOptions.Controls.Add(Me.ucrChkSortByName)
        Me.grpDisplayOptions.Controls.Add(Me.ucrChkAlternateColour)
        Me.grpDisplayOptions.Controls.Add(Me.ucrChkShowId)
        Me.grpDisplayOptions.Location = New System.Drawing.Point(374, 199)
        Me.grpDisplayOptions.Name = "grpDisplayOptions"
        Me.grpDisplayOptions.Size = New System.Drawing.Size(152, 90)
        Me.grpDisplayOptions.TabIndex = 5
        Me.grpDisplayOptions.TabStop = False
        Me.grpDisplayOptions.Text = "Display Options"
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
        'grpLabels
        '
        Me.grpLabels.Controls.Add(Me.ucrChkShowType)
        Me.grpLabels.Controls.Add(Me.ucrChkShowValues)
        Me.grpLabels.Controls.Add(Me.ucrChkShowLabels)
        Me.grpLabels.Location = New System.Drawing.Point(2, 199)
        Me.grpLabels.Name = "grpLabels"
        Me.grpLabels.Size = New System.Drawing.Size(194, 90)
        Me.grpLabels.TabIndex = 3
        Me.grpLabels.TabStop = False
        Me.grpLabels.Text = "Variable Options"
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
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 295)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 6
        '
        'ucrReceiverVariables
        '
        Me.ucrReceiverVariables.AutoSize = True
        Me.ucrReceiverVariables.frmParent = Me
        Me.ucrReceiverVariables.Location = New System.Drawing.Point(300, 60)
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
        Me.ucrSelectorViewLabelsAndLevels.Location = New System.Drawing.Point(10, 10)
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
        Me.ClientSize = New System.Drawing.Size(528, 351)
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
        Me.Text = "View Labels/Levels"
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
End Class
