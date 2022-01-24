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
        Me.ucrChkIgnoreMissingValues = New instat.ucrCheck()
        Me.ucrSaveResults = New instat.ucrSave()
        Me.ucrSelectorForRowSummaries = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverForRowSummaries = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpStatistic.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelected.Location = New System.Drawing.Point(250, 45)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(53, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Tag = "Rows_to_Summarise:"
        Me.lblSelected.Text = "Variables:"
        '
        'cmdUserDefined
        '
        Me.cmdUserDefined.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdUserDefined.Location = New System.Drawing.Point(308, 271)
        Me.cmdUserDefined.Name = "cmdUserDefined"
        Me.cmdUserDefined.Size = New System.Drawing.Size(100, 23)
        Me.cmdUserDefined.TabIndex = 6
        Me.cmdUserDefined.Tag = "User_Define"
        Me.cmdUserDefined.Text = "User Define"
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
        Me.grpStatistic.Location = New System.Drawing.Point(10, 195)
        Me.grpStatistic.Name = "grpStatistic"
        Me.grpStatistic.Size = New System.Drawing.Size(398, 70)
        Me.grpStatistic.TabIndex = 4
        Me.grpStatistic.TabStop = False
        Me.grpStatistic.Tag = "Statistic"
        Me.grpStatistic.Text = "Row Statistic"
        '
        'rdoMinimum
        '
        Me.rdoMinimum.AutoSize = True
        Me.rdoMinimum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMinimum.Location = New System.Drawing.Point(327, 19)
        Me.rdoMinimum.Name = "rdoMinimum"
        Me.rdoMinimum.Size = New System.Drawing.Size(66, 17)
        Me.rdoMinimum.TabIndex = 7
        Me.rdoMinimum.TabStop = True
        Me.rdoMinimum.Tag = "Minimum"
        Me.rdoMinimum.Text = "Minimum"
        Me.rdoMinimum.UseVisualStyleBackColor = True
        '
        'rdoMaximum
        '
        Me.rdoMaximum.AutoSize = True
        Me.rdoMaximum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMaximum.Location = New System.Drawing.Point(327, 42)
        Me.rdoMaximum.Name = "rdoMaximum"
        Me.rdoMaximum.Size = New System.Drawing.Size(69, 17)
        Me.rdoMaximum.TabIndex = 8
        Me.rdoMaximum.TabStop = True
        Me.rdoMaximum.Tag = "Maximum"
        Me.rdoMaximum.Text = "Maximum"
        Me.rdoMaximum.UseVisualStyleBackColor = True
        '
        'rdoCount
        '
        Me.rdoCount.AutoSize = True
        Me.rdoCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCount.Location = New System.Drawing.Point(197, 19)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(53, 17)
        Me.rdoCount.TabIndex = 5
        Me.rdoCount.TabStop = True
        Me.rdoCount.Tag = "Count"
        Me.rdoCount.Text = "Count"
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'rdoMean
        '
        Me.rdoMean.AutoSize = True
        Me.rdoMean.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMean.Location = New System.Drawing.Point(6, 19)
        Me.rdoMean.Name = "rdoMean"
        Me.rdoMean.Size = New System.Drawing.Size(52, 17)
        Me.rdoMean.TabIndex = 1
        Me.rdoMean.TabStop = True
        Me.rdoMean.Tag = "Mean"
        Me.rdoMean.Text = "Mean"
        Me.rdoMean.UseVisualStyleBackColor = True
        '
        'rdoStandardDeviation
        '
        Me.rdoStandardDeviation.AutoSize = True
        Me.rdoStandardDeviation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStandardDeviation.Location = New System.Drawing.Point(77, 42)
        Me.rdoStandardDeviation.Name = "rdoStandardDeviation"
        Me.rdoStandardDeviation.Size = New System.Drawing.Size(116, 17)
        Me.rdoStandardDeviation.TabIndex = 4
        Me.rdoStandardDeviation.TabStop = True
        Me.rdoStandardDeviation.Tag = "Standard_Deviation"
        Me.rdoStandardDeviation.Text = "Standard Deviation"
        Me.rdoStandardDeviation.UseVisualStyleBackColor = True
        '
        'rdoNumberofMissing
        '
        Me.rdoNumberofMissing.AutoSize = True
        Me.rdoNumberofMissing.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNumberofMissing.Location = New System.Drawing.Point(196, 42)
        Me.rdoNumberofMissing.Name = "rdoNumberofMissing"
        Me.rdoNumberofMissing.Size = New System.Drawing.Size(112, 17)
        Me.rdoNumberofMissing.TabIndex = 6
        Me.rdoNumberofMissing.TabStop = True
        Me.rdoNumberofMissing.Tag = "Number_of_Missing"
        Me.rdoNumberofMissing.Text = "Number of Missing"
        Me.rdoNumberofMissing.UseVisualStyleBackColor = True
        '
        'rdoMedian
        '
        Me.rdoMedian.AutoSize = True
        Me.rdoMedian.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMedian.Location = New System.Drawing.Point(6, 42)
        Me.rdoMedian.Name = "rdoMedian"
        Me.rdoMedian.Size = New System.Drawing.Size(60, 17)
        Me.rdoMedian.TabIndex = 2
        Me.rdoMedian.TabStop = True
        Me.rdoMedian.Tag = "Median"
        Me.rdoMedian.Text = "Median"
        Me.rdoMedian.UseVisualStyleBackColor = True
        '
        'rdoSum
        '
        Me.rdoSum.AutoSize = True
        Me.rdoSum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSum.Location = New System.Drawing.Point(77, 19)
        Me.rdoSum.Name = "rdoSum"
        Me.rdoSum.Size = New System.Drawing.Size(46, 17)
        Me.rdoSum.TabIndex = 3
        Me.rdoSum.TabStop = True
        Me.rdoSum.Tag = "Sum"
        Me.rdoSum.Text = "Sum"
        Me.rdoSum.UseVisualStyleBackColor = True
        '
        'ucrPanelStatistics
        '
        Me.ucrPanelStatistics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPanelStatistics.Location = New System.Drawing.Point(3, 12)
        Me.ucrPanelStatistics.Name = "ucrPanelStatistics"
        Me.ucrPanelStatistics.Size = New System.Drawing.Size(393, 56)
        Me.ucrPanelStatistics.TabIndex = 0
        '
        'ucrChkIgnoreMissingValues
        '
        Me.ucrChkIgnoreMissingValues.AutoSize = True
        Me.ucrChkIgnoreMissingValues.Checked = False
        Me.ucrChkIgnoreMissingValues.Location = New System.Drawing.Point(230, 170)
        Me.ucrChkIgnoreMissingValues.Name = "ucrChkIgnoreMissingValues"
        Me.ucrChkIgnoreMissingValues.Size = New System.Drawing.Size(190, 23)
        Me.ucrChkIgnoreMissingValues.TabIndex = 3
        '
        'ucrSaveResults
        '
        Me.ucrSaveResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveResults.Location = New System.Drawing.Point(10, 271)
        Me.ucrSaveResults.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveResults.Name = "ucrSaveResults"
        Me.ucrSaveResults.Size = New System.Drawing.Size(269, 22)
        Me.ucrSaveResults.TabIndex = 5
        '
        'ucrSelectorForRowSummaries
        '
        Me.ucrSelectorForRowSummaries.AutoSize = True
        Me.ucrSelectorForRowSummaries.bDropUnusedFilterLevels = False
        Me.ucrSelectorForRowSummaries.bShowHiddenColumns = False
        Me.ucrSelectorForRowSummaries.bUseCurrentFilter = True
        Me.ucrSelectorForRowSummaries.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForRowSummaries.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForRowSummaries.Name = "ucrSelectorForRowSummaries"
        Me.ucrSelectorForRowSummaries.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForRowSummaries.TabIndex = 0
        '
        'ucrReceiverForRowSummaries
        '
        Me.ucrReceiverForRowSummaries.AutoSize = True
        Me.ucrReceiverForRowSummaries.frmParent = Me
        Me.ucrReceiverForRowSummaries.Location = New System.Drawing.Point(250, 60)
        Me.ucrReceiverForRowSummaries.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForRowSummaries.Name = "ucrReceiverForRowSummaries"
        Me.ucrReceiverForRowSummaries.Selector = Nothing
        Me.ucrReceiverForRowSummaries.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverForRowSummaries.strNcFilePath = ""
        Me.ucrReceiverForRowSummaries.TabIndex = 2
        Me.ucrReceiverForRowSummaries.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 300)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 7
        '
        'dlgRowSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(419, 357)
        Me.Controls.Add(Me.ucrChkIgnoreMissingValues)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Row_Summaries"
        Me.Text = "Row Summaries"
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
    Friend WithEvents ucrChkIgnoreMissingValues As ucrCheck
End Class
