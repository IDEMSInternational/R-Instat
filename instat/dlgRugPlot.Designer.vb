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
Partial Class dlgRugPlot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRugPlot))
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdRugPlotOptions = New System.Windows.Forms.Button()
        Me.lblFactorOptional = New System.Windows.Forms.Label()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrVariablesAsFactorForRugPlot = New instat.ucrVariablesAsFactor()
        Me.ucrFactorOptionalReceiver = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrRugPlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdRugPlotOptions
        '
        resources.ApplyResources(Me.cmdRugPlotOptions, "cmdRugPlotOptions")
        Me.cmdRugPlotOptions.Name = "cmdRugPlotOptions"
        Me.cmdRugPlotOptions.Tag = "Rug_Plot_Options"
        Me.cmdRugPlotOptions.UseVisualStyleBackColor = True
        '
        'lblFactorOptional
        '
        resources.ApplyResources(Me.lblFactorOptional, "lblFactorOptional")
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Tag = "By_Variable_Optional:"
        '
        'lblXVariable
        '
        resources.ApplyResources(Me.lblXVariable, "lblXVariable")
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Tag = "X_Variable:"
        '
        'ucrSaveGraph
        '
        resources.ApplyResources(Me.ucrSaveGraph, "ucrSaveGraph")
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        '
        'ucrVariablesAsFactorForRugPlot
        '
        Me.ucrVariablesAsFactorForRugPlot.frmParent = Me
        resources.ApplyResources(Me.ucrVariablesAsFactorForRugPlot, "ucrVariablesAsFactorForRugPlot")
        Me.ucrVariablesAsFactorForRugPlot.Name = "ucrVariablesAsFactorForRugPlot"
        Me.ucrVariablesAsFactorForRugPlot.Selector = Nothing
        Me.ucrVariablesAsFactorForRugPlot.strNcFilePath = ""
        Me.ucrVariablesAsFactorForRugPlot.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForRugPlot.ucrVariableSelector = Nothing
        '
        'ucrFactorOptionalReceiver
        '
        Me.ucrFactorOptionalReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrFactorOptionalReceiver, "ucrFactorOptionalReceiver")
        Me.ucrFactorOptionalReceiver.Name = "ucrFactorOptionalReceiver"
        Me.ucrFactorOptionalReceiver.Selector = Nothing
        Me.ucrFactorOptionalReceiver.strNcFilePath = ""
        Me.ucrFactorOptionalReceiver.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverX, "ucrReceiverX")
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrRugPlotSelector
        '
        Me.ucrRugPlotSelector.bShowHiddenColumns = False
        Me.ucrRugPlotSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrRugPlotSelector, "ucrRugPlotSelector")
        Me.ucrRugPlotSelector.Name = "ucrRugPlotSelector"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgRugPlot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrVariablesAsFactorForRugPlot)
        Me.Controls.Add(Me.ucrFactorOptionalReceiver)
        Me.Controls.Add(Me.lblFactorOptional)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cmdRugPlotOptions)
        Me.Controls.Add(Me.ucrRugPlotSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRugPlot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdRugPlotOptions As Button
    Friend WithEvents ucrRugPlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrVariablesAsFactorForRugPlot As ucrVariablesAsFactor
    Friend WithEvents ucrFactorOptionalReceiver As ucrReceiverSingle
    Friend WithEvents lblFactorOptional As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrSaveGraph As ucrSave
End Class
