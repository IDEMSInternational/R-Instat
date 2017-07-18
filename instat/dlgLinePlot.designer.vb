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
Partial Class dlgLinePlot
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
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdLineOptions = New System.Windows.Forms.Button()
        Me.lblFactorOptional = New System.Windows.Forms.Label()
        Me.ucrVariablesAsFactorForLinePlot = New instat.ucrVariablesAsFactor()
        Me.ucrLinePlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrFactorOptionalReceiver = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrChkPoints = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.Location = New System.Drawing.Point(249, 189)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(58, 13)
        Me.lblXVariable.TabIndex = 2
        Me.lblXVariable.Tag = "X_Variable:"
        Me.lblXVariable.Text = "X Variable:"
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Location = New System.Drawing.Point(27, 15)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(0, 13)
        Me.lblAvailable.TabIndex = 1
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 227)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(119, 23)
        Me.cmdOptions.TabIndex = 6
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdLineOptions
        '
        Me.cmdLineOptions.Location = New System.Drawing.Point(10, 198)
        Me.cmdLineOptions.Name = "cmdLineOptions"
        Me.cmdLineOptions.Size = New System.Drawing.Size(119, 23)
        Me.cmdLineOptions.TabIndex = 7
        Me.cmdLineOptions.Tag = "Line_Options"
        Me.cmdLineOptions.Text = "Line Options"
        Me.cmdLineOptions.UseVisualStyleBackColor = True
        '
        'lblFactorOptional
        '
        Me.lblFactorOptional.AutoSize = True
        Me.lblFactorOptional.Location = New System.Drawing.Point(249, 233)
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Size = New System.Drawing.Size(88, 13)
        Me.lblFactorOptional.TabIndex = 4
        Me.lblFactorOptional.Tag = "Factor_Optional:"
        Me.lblFactorOptional.Text = "Factor (Optional):"
        '
        'ucrVariablesAsFactorForLinePlot
        '
        Me.ucrVariablesAsFactorForLinePlot.frmParent = Me
        Me.ucrVariablesAsFactorForLinePlot.Location = New System.Drawing.Point(249, 30)
        Me.ucrVariablesAsFactorForLinePlot.Name = "ucrVariablesAsFactorForLinePlot"
        Me.ucrVariablesAsFactorForLinePlot.Selector = Nothing
        Me.ucrVariablesAsFactorForLinePlot.Size = New System.Drawing.Size(125, 136)
        Me.ucrVariablesAsFactorForLinePlot.TabIndex = 1
        Me.ucrVariablesAsFactorForLinePlot.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForLinePlot.ucrVariableSelector = Nothing
        '
        'ucrLinePlotSelector
        '
        Me.ucrLinePlotSelector.bShowHiddenColumns = False
        Me.ucrLinePlotSelector.bUseCurrentFilter = True
        Me.ucrLinePlotSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrLinePlotSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrLinePlotSelector.Name = "ucrLinePlotSelector"
        Me.ucrLinePlotSelector.Size = New System.Drawing.Size(242, 189)
        Me.ucrLinePlotSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 308)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 10
        '
        'ucrFactorOptionalReceiver
        '
        Me.ucrFactorOptionalReceiver.frmParent = Me
        Me.ucrFactorOptionalReceiver.Location = New System.Drawing.Point(249, 248)
        Me.ucrFactorOptionalReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorOptionalReceiver.Name = "ucrFactorOptionalReceiver"
        Me.ucrFactorOptionalReceiver.Selector = Nothing
        Me.ucrFactorOptionalReceiver.Size = New System.Drawing.Size(125, 26)
        Me.ucrFactorOptionalReceiver.TabIndex = 5
        Me.ucrFactorOptionalReceiver.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(249, 204)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(125, 26)
        Me.ucrReceiverX.TabIndex = 3
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrSave
        '
        Me.ucrSave.Location = New System.Drawing.Point(10, 282)
        Me.ucrSave.Name = "ucrSave"
        Me.ucrSave.Size = New System.Drawing.Size(254, 24)
        Me.ucrSave.TabIndex = 9
        '
        'ucrChkPoints
        '
        Me.ucrChkPoints.Checked = False
        Me.ucrChkPoints.Location = New System.Drawing.Point(10, 256)
        Me.ucrChkPoints.Name = "ucrChkPoints"
        Me.ucrChkPoints.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkPoints.TabIndex = 8
        '
        'dlgPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 364)
        Me.Controls.Add(Me.ucrChkPoints)
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.ucrVariablesAsFactorForLinePlot)
        Me.Controls.Add(Me.cmdLineOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrLinePlotSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrFactorOptionalReceiver)
        Me.Controls.Add(Me.lblFactorOptional)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.lblAvailable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Line_Plot"
        Me.Text = "Line Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblXVariable As Label
    Friend WithEvents lblAvailable As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrLinePlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdLineOptions As Button
    Friend WithEvents lblFactorOptional As Label
    Friend WithEvents ucrFactorOptionalReceiver As ucrReceiverSingle
    Friend WithEvents ucrVariablesAsFactorForLinePlot As ucrVariablesAsFactor
    Friend WithEvents ucrChkPoints As ucrCheck
    Friend WithEvents ucrSave As ucrSave
End Class
