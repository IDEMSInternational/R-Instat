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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgOneWayFrequencies))
        Me.grpSort = New System.Windows.Forms.GroupBox()
        Me.rdoDescending = New System.Windows.Forms.RadioButton()
        Me.rdoAscending = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.rdoBoth = New System.Windows.Forms.RadioButton()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.rdoAsHtml = New System.Windows.Forms.RadioButton()
        Me.rdoAsText = New System.Windows.Forms.RadioButton()
        Me.grpSort.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSort
        '
        Me.grpSort.Controls.Add(Me.rdoDescending)
        Me.grpSort.Controls.Add(Me.rdoAscending)
        Me.grpSort.Controls.Add(Me.rdoNone)
        resources.ApplyResources(Me.grpSort, "grpSort")
        Me.grpSort.Name = "grpSort"
        Me.grpSort.TabStop = False
        '
        'rdoDescending
        '
        resources.ApplyResources(Me.rdoDescending, "rdoDescending")
        Me.rdoDescending.Name = "rdoDescending"
        Me.rdoDescending.TabStop = True
        Me.rdoDescending.UseVisualStyleBackColor = True
        '
        'rdoAscending
        '
        resources.ApplyResources(Me.rdoAscending, "rdoAscending")
        Me.rdoAscending.Name = "rdoAscending"
        Me.rdoAscending.TabStop = True
        Me.rdoAscending.UseVisualStyleBackColor = True
        '
        'rdoNone
        '
        resources.ApplyResources(Me.rdoNone, "rdoNone")
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.TabStop = True
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblSelectedVariable
        '
        resources.ApplyResources(Me.lblSelectedVariable, "lblSelectedVariable")
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        '
        'rdoGraph
        '
        resources.ApplyResources(Me.rdoGraph, "rdoGraph")
        Me.rdoGraph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatAppearance.BorderSize = 2
        Me.rdoGraph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'rdoTable
        '
        resources.ApplyResources(Me.rdoTable, "rdoTable")
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'rdoBoth
        '
        resources.ApplyResources(Me.rdoBoth, "rdoBoth")
        Me.rdoBoth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatAppearance.BorderSize = 2
        Me.rdoBoth.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.Name = "rdoBoth"
        Me.rdoBoth.UseVisualStyleBackColor = True
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.rdoAsHtml)
        Me.grpOutput.Controls.Add(Me.rdoAsText)
        resources.ApplyResources(Me.grpOutput, "grpOutput")
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.TabStop = False
        '
        'rdoAsHtml
        '
        resources.ApplyResources(Me.rdoAsHtml, "rdoAsHtml")
        Me.rdoAsHtml.Name = "rdoAsHtml"
        Me.rdoAsHtml.UseVisualStyleBackColor = True
        '
        'rdoAsText
        '
        resources.ApplyResources(Me.rdoAsText, "rdoAsText")
        Me.rdoAsText.Name = "rdoAsText"
        Me.rdoAsText.UseVisualStyleBackColor = True
        '
        'dlgOneWayFrequencies
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.rdoBoth)
        Me.Controls.Add(Me.rdoGraph)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.grpSort)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneWayFrequencies"
        Me.grpSort.ResumeLayout(False)
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorOneWayFreq As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpSort As GroupBox
    Friend WithEvents rdoDescending As RadioButton
    Friend WithEvents rdoAscending As RadioButton
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
    Friend WithEvents grpOutput As GroupBox
    Friend WithEvents rdoAsHtml As RadioButton
    Friend WithEvents rdoAsText As RadioButton
    Friend WithEvents ucrPnlOutput As UcrPanel
End Class
