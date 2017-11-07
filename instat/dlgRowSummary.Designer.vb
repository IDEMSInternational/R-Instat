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
Partial Class dlgRowSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRowSummary))
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.cmdUserDefined = New System.Windows.Forms.Button()
        Me.grpStatistic = New System.Windows.Forms.GroupBox()
        Me.rdoMinimum = New System.Windows.Forms.RadioButton()
        Me.rdoMaximum = New System.Windows.Forms.RadioButton()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.rdoMean = New System.Windows.Forms.RadioButton()
        Me.rdoStandardDeviation = New System.Windows.Forms.RadioButton()
        Me.rdoNumberofMissing = New System.Windows.Forms.RadioButton()
        Me.rdoMedian = New System.Windows.Forms.RadioButton()
        Me.rdoSum = New System.Windows.Forms.RadioButton()
        Me.ucrPanelStatistics = New instat.UcrPanel()
        Me.ucrSaveResults = New instat.ucrSave()
        Me.ucrSelectorForRowSummaries = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverForRowSummaries = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpStatistic.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        resources.ApplyResources(Me.lblSelected, "lblSelected")
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Tag = "Rows_to_Summarise:"
        '
        'cmdUserDefined
        '
        resources.ApplyResources(Me.cmdUserDefined, "cmdUserDefined")
        Me.cmdUserDefined.Name = "cmdUserDefined"
        Me.cmdUserDefined.Tag = "User_Define"
        Me.cmdUserDefined.UseVisualStyleBackColor = True
        '
        'grpStatistic
        '
        Me.grpStatistic.Controls.Add(Me.rdoMinimum)
        Me.grpStatistic.Controls.Add(Me.rdoMaximum)
        Me.grpStatistic.Controls.Add(Me.rdoCount)
        Me.grpStatistic.Controls.Add(Me.rdoMean)
        Me.grpStatistic.Controls.Add(Me.rdoStandardDeviation)
        Me.grpStatistic.Controls.Add(Me.rdoNumberofMissing)
        Me.grpStatistic.Controls.Add(Me.rdoMedian)
        Me.grpStatistic.Controls.Add(Me.rdoSum)
        Me.grpStatistic.Controls.Add(Me.ucrPanelStatistics)
        resources.ApplyResources(Me.grpStatistic, "grpStatistic")
        Me.grpStatistic.Name = "grpStatistic"
        Me.grpStatistic.TabStop = False
        Me.grpStatistic.Tag = "Statistic"
        '
        'rdoMinimum
        '
        resources.ApplyResources(Me.rdoMinimum, "rdoMinimum")
        Me.rdoMinimum.Name = "rdoMinimum"
        Me.rdoMinimum.TabStop = True
        Me.rdoMinimum.Tag = "Minimum"
        Me.rdoMinimum.UseVisualStyleBackColor = True
        '
        'rdoMaximum
        '
        resources.ApplyResources(Me.rdoMaximum, "rdoMaximum")
        Me.rdoMaximum.Name = "rdoMaximum"
        Me.rdoMaximum.TabStop = True
        Me.rdoMaximum.Tag = "Maximum"
        Me.rdoMaximum.UseVisualStyleBackColor = True
        '
        'rdoCount
        '
        resources.ApplyResources(Me.rdoCount, "rdoCount")
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.TabStop = True
        Me.rdoCount.Tag = "Count"
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'rdoMean
        '
        resources.ApplyResources(Me.rdoMean, "rdoMean")
        Me.rdoMean.Name = "rdoMean"
        Me.rdoMean.TabStop = True
        Me.rdoMean.Tag = "Mean"
        Me.rdoMean.UseVisualStyleBackColor = True
        '
        'rdoStandardDeviation
        '
        resources.ApplyResources(Me.rdoStandardDeviation, "rdoStandardDeviation")
        Me.rdoStandardDeviation.Name = "rdoStandardDeviation"
        Me.rdoStandardDeviation.TabStop = True
        Me.rdoStandardDeviation.Tag = "Standard_Deviation"
        Me.rdoStandardDeviation.UseVisualStyleBackColor = True
        '
        'rdoNumberofMissing
        '
        resources.ApplyResources(Me.rdoNumberofMissing, "rdoNumberofMissing")
        Me.rdoNumberofMissing.Name = "rdoNumberofMissing"
        Me.rdoNumberofMissing.TabStop = True
        Me.rdoNumberofMissing.Tag = "Number_of_Missing"
        Me.rdoNumberofMissing.UseVisualStyleBackColor = True
        '
        'rdoMedian
        '
        resources.ApplyResources(Me.rdoMedian, "rdoMedian")
        Me.rdoMedian.Name = "rdoMedian"
        Me.rdoMedian.TabStop = True
        Me.rdoMedian.Tag = "Median"
        Me.rdoMedian.UseVisualStyleBackColor = True
        '
        'rdoSum
        '
        resources.ApplyResources(Me.rdoSum, "rdoSum")
        Me.rdoSum.Name = "rdoSum"
        Me.rdoSum.TabStop = True
        Me.rdoSum.Tag = "Sum"
        Me.rdoSum.UseVisualStyleBackColor = True
        '
        'ucrPanelStatistics
        '
        resources.ApplyResources(Me.ucrPanelStatistics, "ucrPanelStatistics")
        Me.ucrPanelStatistics.Name = "ucrPanelStatistics"
        '
        'ucrSaveResults
        '
        resources.ApplyResources(Me.ucrSaveResults, "ucrSaveResults")
        Me.ucrSaveResults.Name = "ucrSaveResults"
        '
        'ucrSelectorForRowSummaries
        '
        Me.ucrSelectorForRowSummaries.bShowHiddenColumns = False
        Me.ucrSelectorForRowSummaries.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForRowSummaries, "ucrSelectorForRowSummaries")
        Me.ucrSelectorForRowSummaries.Name = "ucrSelectorForRowSummaries"
        '
        'ucrReceiverForRowSummaries
        '
        Me.ucrReceiverForRowSummaries.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverForRowSummaries, "ucrReceiverForRowSummaries")
        Me.ucrReceiverForRowSummaries.Name = "ucrReceiverForRowSummaries"
        Me.ucrReceiverForRowSummaries.Selector = Nothing
        Me.ucrReceiverForRowSummaries.strNcFilePath = ""
        Me.ucrReceiverForRowSummaries.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgRowSummary
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveResults)
        Me.Controls.Add(Me.grpStatistic)
        Me.Controls.Add(Me.cmdUserDefined)
        Me.Controls.Add(Me.ucrSelectorForRowSummaries)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrReceiverForRowSummaries)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRowSummary"
        Me.Tag = "Row_Summaries"
        Me.grpStatistic.ResumeLayout(False)
        Me.grpStatistic.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverForRowSummaries As ucrReceiverMultiple
    Friend WithEvents lblSelected As Label
    Friend WithEvents ucrSelectorForRowSummaries As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdUserDefined As Button
    Friend WithEvents grpStatistic As GroupBox
    Friend WithEvents rdoMinimum As RadioButton
    Friend WithEvents rdoMaximum As RadioButton
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents rdoMean As RadioButton
    Friend WithEvents rdoStandardDeviation As RadioButton
    Friend WithEvents rdoNumberofMissing As RadioButton
    Friend WithEvents rdoMedian As RadioButton
    Friend WithEvents rdoSum As RadioButton
    Friend WithEvents ucrPanelStatistics As UcrPanel
    Friend WithEvents ucrSaveResults As ucrSave
End Class
