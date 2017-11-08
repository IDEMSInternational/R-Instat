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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgOneVariableGraph))
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
        resources.ApplyResources(Me.lblSelectedVariables, "lblSelectedVariables")
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        '
        'cmdGraphOptions
        '
        resources.ApplyResources(Me.cmdGraphOptions, "cmdGraphOptions")
        Me.cmdGraphOptions.Name = "cmdGraphOptions"
        Me.cmdGraphOptions.UseVisualStyleBackColor = True
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.rdoSingleGraphs)
        Me.grpOutput.Controls.Add(Me.rdoCombine)
        Me.grpOutput.Controls.Add(Me.rdoFacets)
        Me.grpOutput.Controls.Add(Me.ucrPnlOutput)
        resources.ApplyResources(Me.grpOutput, "grpOutput")
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.TabStop = False
        '
        'rdoSingleGraphs
        '
        resources.ApplyResources(Me.rdoSingleGraphs, "rdoSingleGraphs")
        Me.rdoSingleGraphs.Name = "rdoSingleGraphs"
        Me.rdoSingleGraphs.TabStop = True
        Me.rdoSingleGraphs.UseVisualStyleBackColor = True
        '
        'rdoCombine
        '
        resources.ApplyResources(Me.rdoCombine, "rdoCombine")
        Me.rdoCombine.Name = "rdoCombine"
        Me.rdoCombine.TabStop = True
        Me.rdoCombine.UseVisualStyleBackColor = True
        '
        'rdoFacets
        '
        resources.ApplyResources(Me.rdoFacets, "rdoFacets")
        Me.rdoFacets.Name = "rdoFacets"
        Me.rdoFacets.TabStop = True
        Me.rdoFacets.UseVisualStyleBackColor = True
        '
        'ucrPnlOutput
        '
        resources.ApplyResources(Me.ucrPnlOutput, "ucrPnlOutput")
        Me.ucrPnlOutput.Name = "ucrPnlOutput"
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.Checked = False
        resources.ApplyResources(Me.ucrChkFlip, "ucrChkFlip")
        Me.ucrChkFlip.Name = "ucrChkFlip"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverOneVarGraph
        '
        Me.ucrReceiverOneVarGraph.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverOneVarGraph, "ucrReceiverOneVarGraph")
        Me.ucrReceiverOneVarGraph.Name = "ucrReceiverOneVarGraph"
        Me.ucrReceiverOneVarGraph.Selector = Nothing
        Me.ucrReceiverOneVarGraph.strNcFilePath = ""
        Me.ucrReceiverOneVarGraph.ucrSelector = Nothing
        '
        'ucrSelectorOneVarGraph
        '
        Me.ucrSelectorOneVarGraph.bShowHiddenColumns = False
        Me.ucrSelectorOneVarGraph.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorOneVarGraph, "ucrSelectorOneVarGraph")
        Me.ucrSelectorOneVarGraph.Name = "ucrSelectorOneVarGraph"
        '
        'ucrSaveGraph
        '
        resources.ApplyResources(Me.ucrSaveGraph, "ucrSaveGraph")
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        '
        'dlgOneVariableGraph
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.ucrChkFlip)
        Me.Controls.Add(Me.cmdGraphOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrReceiverOneVarGraph)
        Me.Controls.Add(Me.ucrSelectorOneVarGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneVariableGraph"
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
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
