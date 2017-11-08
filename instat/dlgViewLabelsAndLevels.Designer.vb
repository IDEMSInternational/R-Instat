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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgViewFactorLabels))
        Me.lblFactorColumns = New System.Windows.Forms.Label()
        Me.grpSummaryStatistics = New System.Windows.Forms.GroupBox()
        Me.grpDisplayOptions = New System.Windows.Forms.GroupBox()
        Me.grpLabels = New System.Windows.Forms.GroupBox()
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
        resources.ApplyResources(Me.lblFactorColumns, "lblFactorColumns")
        Me.lblFactorColumns.Name = "lblFactorColumns"
        '
        'grpSummaryStatistics
        '
        Me.grpSummaryStatistics.Controls.Add(Me.ucrChkShowPercentage)
        Me.grpSummaryStatistics.Controls.Add(Me.ucrChkShowFrequencies)
        Me.grpSummaryStatistics.Controls.Add(Me.ucrChkShowMissingValues)
        resources.ApplyResources(Me.grpSummaryStatistics, "grpSummaryStatistics")
        Me.grpSummaryStatistics.Name = "grpSummaryStatistics"
        Me.grpSummaryStatistics.TabStop = False
        '
        'grpDisplayOptions
        '
        Me.grpDisplayOptions.Controls.Add(Me.ucrChkSortByName)
        Me.grpDisplayOptions.Controls.Add(Me.ucrChkAlternateColour)
        Me.grpDisplayOptions.Controls.Add(Me.ucrChkShowId)
        resources.ApplyResources(Me.grpDisplayOptions, "grpDisplayOptions")
        Me.grpDisplayOptions.Name = "grpDisplayOptions"
        Me.grpDisplayOptions.TabStop = False
        '
        'grpLabels
        '
        Me.grpLabels.Controls.Add(Me.ucrChkShowType)
        Me.grpLabels.Controls.Add(Me.ucrChkShowValues)
        Me.grpLabels.Controls.Add(Me.ucrChkShowLabels)
        resources.ApplyResources(Me.grpLabels, "grpLabels")
        Me.grpLabels.Name = "grpLabels"
        Me.grpLabels.TabStop = False
        '
        'ucrChkShowType
        '
        Me.ucrChkShowType.Checked = False
        resources.ApplyResources(Me.ucrChkShowType, "ucrChkShowType")
        Me.ucrChkShowType.Name = "ucrChkShowType"
        '
        'ucrChkShowValues
        '
        Me.ucrChkShowValues.Checked = False
        resources.ApplyResources(Me.ucrChkShowValues, "ucrChkShowValues")
        Me.ucrChkShowValues.Name = "ucrChkShowValues"
        '
        'ucrChkShowLabels
        '
        Me.ucrChkShowLabels.Checked = False
        resources.ApplyResources(Me.ucrChkShowLabels, "ucrChkShowLabels")
        Me.ucrChkShowLabels.Name = "ucrChkShowLabels"
        '
        'ucrChkSortByName
        '
        Me.ucrChkSortByName.Checked = False
        resources.ApplyResources(Me.ucrChkSortByName, "ucrChkSortByName")
        Me.ucrChkSortByName.Name = "ucrChkSortByName"
        '
        'ucrChkAlternateColour
        '
        Me.ucrChkAlternateColour.Checked = False
        resources.ApplyResources(Me.ucrChkAlternateColour, "ucrChkAlternateColour")
        Me.ucrChkAlternateColour.Name = "ucrChkAlternateColour"
        '
        'ucrChkShowId
        '
        Me.ucrChkShowId.Checked = False
        resources.ApplyResources(Me.ucrChkShowId, "ucrChkShowId")
        Me.ucrChkShowId.Name = "ucrChkShowId"
        '
        'ucrChkShowPercentage
        '
        Me.ucrChkShowPercentage.Checked = False
        resources.ApplyResources(Me.ucrChkShowPercentage, "ucrChkShowPercentage")
        Me.ucrChkShowPercentage.Name = "ucrChkShowPercentage"
        '
        'ucrChkShowFrequencies
        '
        Me.ucrChkShowFrequencies.Checked = False
        resources.ApplyResources(Me.ucrChkShowFrequencies, "ucrChkShowFrequencies")
        Me.ucrChkShowFrequencies.Name = "ucrChkShowFrequencies"
        '
        'ucrChkShowMissingValues
        '
        Me.ucrChkShowMissingValues.Checked = False
        resources.ApplyResources(Me.ucrChkShowMissingValues, "ucrChkShowMissingValues")
        Me.ucrChkShowMissingValues.Name = "ucrChkShowMissingValues"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverVariables
        '
        Me.ucrReceiverVariables.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverVariables, "ucrReceiverVariables")
        Me.ucrReceiverVariables.Name = "ucrReceiverVariables"
        Me.ucrReceiverVariables.Selector = Nothing
        Me.ucrReceiverVariables.strNcFilePath = ""
        Me.ucrReceiverVariables.ucrSelector = Nothing
        '
        'ucrSelectorViewLabelsAndLevels
        '
        Me.ucrSelectorViewLabelsAndLevels.bShowHiddenColumns = False
        Me.ucrSelectorViewLabelsAndLevels.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorViewLabelsAndLevels, "ucrSelectorViewLabelsAndLevels")
        Me.ucrSelectorViewLabelsAndLevels.Name = "ucrSelectorViewLabelsAndLevels"
        '
        'dlgViewFactorLabels
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpLabels)
        Me.Controls.Add(Me.grpDisplayOptions)
        Me.Controls.Add(Me.grpSummaryStatistics)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblFactorColumns)
        Me.Controls.Add(Me.ucrReceiverVariables)
        Me.Controls.Add(Me.ucrSelectorViewLabelsAndLevels)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgViewFactorLabels"
        Me.grpSummaryStatistics.ResumeLayout(False)
        Me.grpDisplayOptions.ResumeLayout(False)
        Me.grpLabels.ResumeLayout(False)
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
