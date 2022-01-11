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
Partial Class dlgOneVariableGraph
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.cmdGraphOptions = New System.Windows.Forms.Button()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.rdoSingleGraphs = New System.Windows.Forms.RadioButton()
        Me.rdoCombine = New System.Windows.Forms.RadioButton()
        Me.rdoFacets = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOutput = New instat.UcrPanel()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverOneVarGraph = New instat.ucrReceiverMultiple()
        Me.ucrSelectorOneVarGraph = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.grpOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(245, 43)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(98, 13)
        Me.lblSelectedVariables.TabIndex = 1
        Me.lblSelectedVariables.Text = "Selected Variables:"
        '
        'cmdGraphOptions
        '
        Me.cmdGraphOptions.Location = New System.Drawing.Point(10, 201)
        Me.cmdGraphOptions.Name = "cmdGraphOptions"
        Me.cmdGraphOptions.Size = New System.Drawing.Size(145, 23)
        Me.cmdGraphOptions.TabIndex = 3
        Me.cmdGraphOptions.Text = "Graph Options"
        Me.cmdGraphOptions.UseVisualStyleBackColor = True
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.rdoSingleGraphs)
        Me.grpOutput.Controls.Add(Me.rdoCombine)
        Me.grpOutput.Controls.Add(Me.rdoFacets)
        Me.grpOutput.Controls.Add(Me.ucrPnlOutput)
        Me.grpOutput.Location = New System.Drawing.Point(248, 172)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(142, 91)
        Me.grpOutput.TabIndex = 4
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output"
        '
        'rdoSingleGraphs
        '
        Me.rdoSingleGraphs.Enabled = False
        Me.rdoSingleGraphs.Location = New System.Drawing.Point(10, 65)
        Me.rdoSingleGraphs.Name = "rdoSingleGraphs"
        Me.rdoSingleGraphs.Size = New System.Drawing.Size(130, 17)
        Me.rdoSingleGraphs.TabIndex = 3
        Me.rdoSingleGraphs.TabStop = True
        Me.rdoSingleGraphs.Text = "Single Graphs"
        Me.rdoSingleGraphs.UseVisualStyleBackColor = True
        '
        'rdoCombine
        '
        Me.rdoCombine.Location = New System.Drawing.Point(10, 43)
        Me.rdoCombine.Name = "rdoCombine"
        Me.rdoCombine.Size = New System.Drawing.Size(126, 17)
        Me.rdoCombine.TabIndex = 2
        Me.rdoCombine.TabStop = True
        Me.rdoCombine.Text = "Combined Graph"
        Me.rdoCombine.UseVisualStyleBackColor = True
        '
        'rdoFacets
        '
        Me.rdoFacets.Location = New System.Drawing.Point(10, 21)
        Me.rdoFacets.Name = "rdoFacets"
        Me.rdoFacets.Size = New System.Drawing.Size(130, 17)
        Me.rdoFacets.TabIndex = 1
        Me.rdoFacets.TabStop = True
        Me.rdoFacets.Text = "Facets"
        Me.rdoFacets.UseVisualStyleBackColor = True
        '
        'ucrPnlOutput
        '
        Me.ucrPnlOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOutput.Location = New System.Drawing.Point(3, 16)
        Me.ucrPnlOutput.Name = "ucrPnlOutput"
        Me.ucrPnlOutput.Size = New System.Drawing.Size(137, 69)
        Me.ucrPnlOutput.TabIndex = 0
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.AutoSize = True
        Me.ucrChkFlip.Checked = False
        Me.ucrChkFlip.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucrChkFlip.Location = New System.Drawing.Point(10, 238)
        Me.ucrChkFlip.Name = "ucrChkFlip"
        Me.ucrChkFlip.Size = New System.Drawing.Size(210, 23)
        Me.ucrChkFlip.TabIndex = 5
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(4, 292)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 7
        '
        'ucrReceiverOneVarGraph
        '
        Me.ucrReceiverOneVarGraph.AutoSize = True
        Me.ucrReceiverOneVarGraph.frmParent = Me
        Me.ucrReceiverOneVarGraph.Location = New System.Drawing.Point(248, 60)
        Me.ucrReceiverOneVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOneVarGraph.Name = "ucrReceiverOneVarGraph"
        Me.ucrReceiverOneVarGraph.Selector = Nothing
        Me.ucrReceiverOneVarGraph.Size = New System.Drawing.Size(123, 110)
        Me.ucrReceiverOneVarGraph.strNcFilePath = ""
        Me.ucrReceiverOneVarGraph.TabIndex = 2
        Me.ucrReceiverOneVarGraph.ucrSelector = Nothing
        '
        'ucrSelectorOneVarGraph
        '
        Me.ucrSelectorOneVarGraph.AutoSize = True
        Me.ucrSelectorOneVarGraph.bDropUnusedFilterLevels = False
        Me.ucrSelectorOneVarGraph.bShowHiddenColumns = False
        Me.ucrSelectorOneVarGraph.bUseCurrentFilter = True
        Me.ucrSelectorOneVarGraph.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorOneVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOneVarGraph.Name = "ucrSelectorOneVarGraph"
        Me.ucrSelectorOneVarGraph.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorOneVarGraph.TabIndex = 0
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 265)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(361, 24)
        Me.ucrSaveGraph.TabIndex = 6
        '
        'dlgOneVariableGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(409, 348)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.ucrChkFlip)
        Me.Controls.Add(Me.cmdGraphOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrReceiverOneVarGraph)
        Me.Controls.Add(Me.ucrSelectorOneVarGraph)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneVariableGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Variable Graph"
        Me.grpOutput.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorOneVarGraph As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverOneVarGraph As ucrReceiverMultiple
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdGraphOptions As Button
    Friend WithEvents ucrChkFlip As ucrCheck
    Friend WithEvents grpOutput As GroupBox
    Friend WithEvents rdoSingleGraphs As RadioButton
    Friend WithEvents rdoCombine As RadioButton
    Friend WithEvents rdoFacets As RadioButton
    Friend WithEvents ucrPnlOutput As UcrPanel
    Friend WithEvents ucrSaveGraph As ucrSave
End Class
