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
Partial Class dlgDotPlot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDotPlot))
        Me.cmdDotPlotOptions = New System.Windows.Forms.Button()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblOtherAxis = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.grpBinAxis = New System.Windows.Forms.GroupBox()
        Me.rdoYBinAxis = New System.Windows.Forms.RadioButton()
        Me.rdoXBinAxis = New System.Windows.Forms.RadioButton()
        Me.ucrPnlBinAxis = New instat.UcrPanel()
        Me.ucrSaveDotPlot = New instat.ucrSave()
        Me.ucrVariablesAsFactorDotPlot = New instat.ucrVariablesAsFactor()
        Me.ucrDotPlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrOtherAxisReceiver = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpBinAxis.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdDotPlotOptions
        '
        resources.ApplyResources(Me.cmdDotPlotOptions, "cmdDotPlotOptions")
        Me.cmdDotPlotOptions.Name = "cmdDotPlotOptions"
        Me.cmdDotPlotOptions.Tag = "Dot_Plot_Options"
        Me.cmdDotPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblOtherAxis
        '
        resources.ApplyResources(Me.lblOtherAxis, "lblOtherAxis")
        Me.lblOtherAxis.Name = "lblOtherAxis"
        Me.lblOtherAxis.Tag = "Other_Axis_(optional):"
        '
        'lblFactor
        '
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Tag = "Factor_(optional):"
        '
        'grpBinAxis
        '
        Me.grpBinAxis.Controls.Add(Me.rdoYBinAxis)
        Me.grpBinAxis.Controls.Add(Me.rdoXBinAxis)
        Me.grpBinAxis.Controls.Add(Me.ucrPnlBinAxis)
        resources.ApplyResources(Me.grpBinAxis, "grpBinAxis")
        Me.grpBinAxis.Name = "grpBinAxis"
        Me.grpBinAxis.TabStop = False
        Me.grpBinAxis.Tag = "Bin_Axis:"
        '
        'rdoYBinAxis
        '
        resources.ApplyResources(Me.rdoYBinAxis, "rdoYBinAxis")
        Me.rdoYBinAxis.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYBinAxis.FlatAppearance.BorderSize = 2
        Me.rdoYBinAxis.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYBinAxis.Name = "rdoYBinAxis"
        Me.rdoYBinAxis.TabStop = True
        Me.rdoYBinAxis.UseVisualStyleBackColor = True
        '
        'rdoXBinAxis
        '
        resources.ApplyResources(Me.rdoXBinAxis, "rdoXBinAxis")
        Me.rdoXBinAxis.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoXBinAxis.FlatAppearance.BorderSize = 2
        Me.rdoXBinAxis.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoXBinAxis.Name = "rdoXBinAxis"
        Me.rdoXBinAxis.TabStop = True
        Me.rdoXBinAxis.UseVisualStyleBackColor = True
        '
        'ucrPnlBinAxis
        '
        resources.ApplyResources(Me.ucrPnlBinAxis, "ucrPnlBinAxis")
        Me.ucrPnlBinAxis.Name = "ucrPnlBinAxis"
        '
        'ucrSaveDotPlot
        '
        resources.ApplyResources(Me.ucrSaveDotPlot, "ucrSaveDotPlot")
        Me.ucrSaveDotPlot.Name = "ucrSaveDotPlot"
        '
        'ucrVariablesAsFactorDotPlot
        '
        Me.ucrVariablesAsFactorDotPlot.frmParent = Me
        resources.ApplyResources(Me.ucrVariablesAsFactorDotPlot, "ucrVariablesAsFactorDotPlot")
        Me.ucrVariablesAsFactorDotPlot.Name = "ucrVariablesAsFactorDotPlot"
        Me.ucrVariablesAsFactorDotPlot.Selector = Nothing
        Me.ucrVariablesAsFactorDotPlot.strNcFilePath = ""
        Me.ucrVariablesAsFactorDotPlot.ucrSelector = Nothing
        Me.ucrVariablesAsFactorDotPlot.ucrVariableSelector = Nothing
        '
        'ucrDotPlotSelector
        '
        Me.ucrDotPlotSelector.bShowHiddenColumns = False
        Me.ucrDotPlotSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrDotPlotSelector, "ucrDotPlotSelector")
        Me.ucrDotPlotSelector.Name = "ucrDotPlotSelector"
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrFactorReceiver, "ucrFactorReceiver")
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.strNcFilePath = ""
        Me.ucrFactorReceiver.ucrSelector = Nothing
        '
        'ucrOtherAxisReceiver
        '
        Me.ucrOtherAxisReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrOtherAxisReceiver, "ucrOtherAxisReceiver")
        Me.ucrOtherAxisReceiver.Name = "ucrOtherAxisReceiver"
        Me.ucrOtherAxisReceiver.Selector = Nothing
        Me.ucrOtherAxisReceiver.strNcFilePath = ""
        Me.ucrOtherAxisReceiver.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgDotPlot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveDotPlot)
        Me.Controls.Add(Me.grpBinAxis)
        Me.Controls.Add(Me.ucrVariablesAsFactorDotPlot)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cmdDotPlotOptions)
        Me.Controls.Add(Me.ucrDotPlotSelector)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblOtherAxis)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.ucrOtherAxisReceiver)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDotPlot"
        Me.Tag = "Dot_Plot"
        Me.grpBinAxis.ResumeLayout(False)
        Me.grpBinAxis.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDotPlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdDotPlotOptions As Button
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrOtherAxisReceiver As ucrReceiverSingle
    Friend WithEvents lblOtherAxis As Label
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrVariablesAsFactorDotPlot As ucrVariablesAsFactor
    Friend WithEvents grpBinAxis As GroupBox
    Friend WithEvents rdoYBinAxis As RadioButton
    Friend WithEvents rdoXBinAxis As RadioButton
    Friend WithEvents ucrSaveDotPlot As ucrSave
    Friend WithEvents ucrPnlBinAxis As UcrPanel
End Class
