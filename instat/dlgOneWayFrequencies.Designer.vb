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
Partial Class dlgOneWayFrequencies
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
        Me.grpSort = New System.Windows.Forms.GroupBox()
        Me.rdoDescendingFrequencies = New System.Windows.Forms.RadioButton()
        Me.rdoAscendingFrequencies = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSort = New instat.UcrPanel()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.rdoBoth = New System.Windows.Forms.RadioButton()
        Me.ucrNudGroups = New instat.ucrNud()
        Me.ucrPnlFrequencies = New instat.UcrPanel()
        Me.ucrChkGroupData = New instat.ucrCheck()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorOneWayFreq = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverOneWayFreq = New instat.ucrReceiverMultiple()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.grpSort.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSort
        '
        Me.grpSort.Controls.Add(Me.rdoDescendingFrequencies)
        Me.grpSort.Controls.Add(Me.rdoAscendingFrequencies)
        Me.grpSort.Controls.Add(Me.rdoNone)
        Me.grpSort.Controls.Add(Me.ucrPnlSort)
        Me.grpSort.Location = New System.Drawing.Point(269, 201)
        Me.grpSort.Name = "grpSort"
        Me.grpSort.Size = New System.Drawing.Size(163, 95)
        Me.grpSort.TabIndex = 7
        Me.grpSort.TabStop = False
        Me.grpSort.Text = "Sort"
        '
        'rdoDescendingFrequencies
        '
        Me.rdoDescendingFrequencies.AutoSize = True
        Me.rdoDescendingFrequencies.Location = New System.Drawing.Point(10, 65)
        Me.rdoDescendingFrequencies.Name = "rdoDescendingFrequencies"
        Me.rdoDescendingFrequencies.Size = New System.Drawing.Size(143, 17)
        Me.rdoDescendingFrequencies.TabIndex = 3
        Me.rdoDescendingFrequencies.TabStop = True
        Me.rdoDescendingFrequencies.Text = "Descending Frequencies"
        Me.rdoDescendingFrequencies.UseVisualStyleBackColor = True
        '
        'rdoAscendingFrequencies
        '
        Me.rdoAscendingFrequencies.AutoSize = True
        Me.rdoAscendingFrequencies.Location = New System.Drawing.Point(10, 43)
        Me.rdoAscendingFrequencies.Name = "rdoAscendingFrequencies"
        Me.rdoAscendingFrequencies.Size = New System.Drawing.Size(136, 17)
        Me.rdoAscendingFrequencies.TabIndex = 2
        Me.rdoAscendingFrequencies.TabStop = True
        Me.rdoAscendingFrequencies.Text = "Ascending Frequencies"
        Me.rdoAscendingFrequencies.UseVisualStyleBackColor = True
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.Location = New System.Drawing.Point(10, 21)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(51, 17)
        Me.rdoNone.TabIndex = 1
        Me.rdoNone.TabStop = True
        Me.rdoNone.Text = "None"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'ucrPnlSort
        '
        Me.ucrPnlSort.Location = New System.Drawing.Point(3, 16)
        Me.ucrPnlSort.Name = "ucrPnlSort"
        Me.ucrPnlSort.Size = New System.Drawing.Size(154, 69)
        Me.ucrPnlSort.TabIndex = 0
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 228)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(87, 23)
        Me.cmdOptions.TabIndex = 8
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.Location = New System.Drawing.Point(269, 80)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(93, 13)
        Me.lblSelectedVariable.TabIndex = 5
        Me.lblSelectedVariable.Text = "Selected Variable:"
        '
        'rdoGraph
        '
        Me.rdoGraph.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGraph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatAppearance.BorderSize = 2
        Me.rdoGraph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGraph.Location = New System.Drawing.Point(160, 10)
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.Size = New System.Drawing.Size(100, 28)
        Me.rdoGraph.TabIndex = 2
        Me.rdoGraph.Text = "Graph"
        Me.rdoGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'rdoTable
        '
        Me.rdoTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTable.Location = New System.Drawing.Point(62, 10)
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.Size = New System.Drawing.Size(100, 28)
        Me.rdoTable.TabIndex = 1
        Me.rdoTable.Text = "Table"
        Me.rdoTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'rdoBoth
        '
        Me.rdoBoth.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBoth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatAppearance.BorderSize = 2
        Me.rdoBoth.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBoth.Location = New System.Drawing.Point(258, 10)
        Me.rdoBoth.Name = "rdoBoth"
        Me.rdoBoth.Size = New System.Drawing.Size(100, 28)
        Me.rdoBoth.TabIndex = 3
        Me.rdoBoth.Text = "Both"
        Me.rdoBoth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBoth.UseVisualStyleBackColor = True
        '
        'ucrNudGroups
        '
        Me.ucrNudGroups.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudGroups.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudGroups.Location = New System.Drawing.Point(131, 279)
        Me.ucrNudGroups.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudGroups.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudGroups.Name = "ucrNudGroups"
        Me.ucrNudGroups.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudGroups.TabIndex = 12
        Me.ucrNudGroups.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlFrequencies
        '
        Me.ucrPnlFrequencies.Location = New System.Drawing.Point(53, 6)
        Me.ucrPnlFrequencies.Name = "ucrPnlFrequencies"
        Me.ucrPnlFrequencies.Size = New System.Drawing.Size(315, 35)
        Me.ucrPnlFrequencies.TabIndex = 0
        '
        'ucrChkGroupData
        '
        Me.ucrChkGroupData.Checked = False
        Me.ucrChkGroupData.Location = New System.Drawing.Point(10, 280)
        Me.ucrChkGroupData.Name = "ucrChkGroupData"
        Me.ucrChkGroupData.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkGroupData.TabIndex = 11
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(131, 256)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.TabIndex = 10
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.Checked = False
        Me.ucrChkWeights.Location = New System.Drawing.Point(10, 256)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(114, 20)
        Me.ucrChkWeights.TabIndex = 9
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.Checked = False
        Me.ucrChkFlip.Location = New System.Drawing.Point(10, 304)
        Me.ucrChkFlip.Name = "ucrChkFlip"
        Me.ucrChkFlip.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkFlip.TabIndex = 13
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 352)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 15
        '
        'ucrSelectorOneWayFreq
        '
        Me.ucrSelectorOneWayFreq.bShowHiddenColumns = False
        Me.ucrSelectorOneWayFreq.bUseCurrentFilter = True
        Me.ucrSelectorOneWayFreq.Location = New System.Drawing.Point(10, 45)
        Me.ucrSelectorOneWayFreq.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOneWayFreq.Name = "ucrSelectorOneWayFreq"
        Me.ucrSelectorOneWayFreq.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorOneWayFreq.TabIndex = 4
        '
        'ucrReceiverOneWayFreq
        '
        Me.ucrReceiverOneWayFreq.frmParent = Me
        Me.ucrReceiverOneWayFreq.Location = New System.Drawing.Point(269, 95)
        Me.ucrReceiverOneWayFreq.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOneWayFreq.Name = "ucrReceiverOneWayFreq"
        Me.ucrReceiverOneWayFreq.Selector = Nothing
        Me.ucrReceiverOneWayFreq.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverOneWayFreq.strNcFilePath = ""
        Me.ucrReceiverOneWayFreq.TabIndex = 6
        Me.ucrReceiverOneWayFreq.ucrSelector = Nothing
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 328)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveGraph.TabIndex = 14
        '
        'dlgOneWayFrequencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 408)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrReceiverOneWayFreq)
        Me.Controls.Add(Me.rdoBoth)
        Me.Controls.Add(Me.rdoGraph)
        Me.Controls.Add(Me.ucrNudGroups)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.ucrPnlFrequencies)
        Me.Controls.Add(Me.ucrChkGroupData)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.ucrChkFlip)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.grpSort)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorOneWayFreq)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneWayFrequencies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Way Frequencies"
        Me.grpSort.ResumeLayout(False)
        Me.grpSort.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorOneWayFreq As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpSort As GroupBox
    Friend WithEvents rdoDescendingFrequencies As RadioButton
    Friend WithEvents rdoAscendingFrequencies As RadioButton
    Friend WithEvents rdoNone As RadioButton
    Friend WithEvents ucrPnlSort As UcrPanel
    Friend WithEvents cmdOptions As Button
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrChkFlip As ucrCheck
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents ucrChkWeights As ucrCheck
    Friend WithEvents ucrNudGroups As ucrNud
    Friend WithEvents ucrChkGroupData As ucrCheck
    Friend WithEvents rdoGraph As RadioButton
    Friend WithEvents rdoTable As RadioButton
    Friend WithEvents ucrPnlFrequencies As UcrPanel
    Friend WithEvents rdoBoth As RadioButton
    Friend WithEvents ucrReceiverOneWayFreq As ucrReceiverMultiple
    Friend WithEvents ucrSaveGraph As ucrSave
End Class
