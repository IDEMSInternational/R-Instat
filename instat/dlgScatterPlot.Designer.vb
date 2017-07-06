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
Partial Class dlgScatterPlot
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
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblFactorOptional = New System.Windows.Forms.Label()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.cmdScatterPlotOptions = New System.Windows.Forms.Button()
        Me.ucrChkLineofBestFit = New instat.ucrCheck()
        Me.ucrSaveScatterPlot = New instat.ucrSave()
        Me.ucrSelectorForScatter = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrVariablesAsFactorForScatter = New instat.ucrVariablesAsFactor()
        Me.ucrFactorOptionalReceiver = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 229)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdOptions.TabIndex = 7
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblFactorOptional
        '
        Me.lblFactorOptional.AutoSize = True
        Me.lblFactorOptional.Location = New System.Drawing.Point(262, 219)
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Size = New System.Drawing.Size(111, 13)
        Me.lblFactorOptional.TabIndex = 4
        Me.lblFactorOptional.Tag = "By_Variable_Optional:"
        Me.lblFactorOptional.Text = "By Variable (Optional):"
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.Location = New System.Drawing.Point(262, 172)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(58, 13)
        Me.lblXVariable.TabIndex = 2
        Me.lblXVariable.Tag = "X_Variable:"
        Me.lblXVariable.Text = "X Variable:"
        '
        'cmdScatterPlotOptions
        '
        Me.cmdScatterPlotOptions.Location = New System.Drawing.Point(10, 198)
        Me.cmdScatterPlotOptions.Name = "cmdScatterPlotOptions"
        Me.cmdScatterPlotOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdScatterPlotOptions.TabIndex = 6
        Me.cmdScatterPlotOptions.Tag = "ScatterPlot_Options"
        Me.cmdScatterPlotOptions.Text = "Scatter Plot Options"
        Me.cmdScatterPlotOptions.UseVisualStyleBackColor = True
        '
        'ucrChkLineofBestFit
        '
        Me.ucrChkLineofBestFit.Checked = False
        Me.ucrChkLineofBestFit.Location = New System.Drawing.Point(10, 260)
        Me.ucrChkLineofBestFit.Name = "ucrChkLineofBestFit"
        Me.ucrChkLineofBestFit.Size = New System.Drawing.Size(173, 20)
        Me.ucrChkLineofBestFit.TabIndex = 10
        '
        'ucrSaveScatterPlot
        '
        Me.ucrSaveScatterPlot.Location = New System.Drawing.Point(10, 285)
        Me.ucrSaveScatterPlot.Name = "ucrSaveScatterPlot"
        Me.ucrSaveScatterPlot.Size = New System.Drawing.Size(250, 24)
        Me.ucrSaveScatterPlot.TabIndex = 8
        '
        'ucrSelectorForScatter
        '
        Me.ucrSelectorForScatter.bShowHiddenColumns = False
        Me.ucrSelectorForScatter.bUseCurrentFilter = True
        Me.ucrSelectorForScatter.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForScatter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForScatter.Name = "ucrSelectorForScatter"
        Me.ucrSelectorForScatter.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForScatter.TabIndex = 0
        '
        'ucrVariablesAsFactorForScatter
        '
        Me.ucrVariablesAsFactorForScatter.frmParent = Me
        Me.ucrVariablesAsFactorForScatter.Location = New System.Drawing.Point(262, 30)
        Me.ucrVariablesAsFactorForScatter.Name = "ucrVariablesAsFactorForScatter"
        Me.ucrVariablesAsFactorForScatter.Selector = Nothing
        Me.ucrVariablesAsFactorForScatter.Size = New System.Drawing.Size(125, 136)
        Me.ucrVariablesAsFactorForScatter.strNcFilePath = ""
        Me.ucrVariablesAsFactorForScatter.TabIndex = 1
        Me.ucrVariablesAsFactorForScatter.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForScatter.ucrVariableSelector = Nothing
        '
        'ucrFactorOptionalReceiver
        '
        Me.ucrFactorOptionalReceiver.frmParent = Me
        Me.ucrFactorOptionalReceiver.Location = New System.Drawing.Point(262, 234)
        Me.ucrFactorOptionalReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorOptionalReceiver.Name = "ucrFactorOptionalReceiver"
        Me.ucrFactorOptionalReceiver.Selector = Nothing
        Me.ucrFactorOptionalReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrFactorOptionalReceiver.strNcFilePath = ""
        Me.ucrFactorOptionalReceiver.TabIndex = 5
        Me.ucrFactorOptionalReceiver.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(262, 187)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 3
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 312)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 9
        '
        'dlgScatterPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 368)
        Me.Controls.Add(Me.ucrChkLineofBestFit)
        Me.Controls.Add(Me.ucrSaveScatterPlot)
        Me.Controls.Add(Me.ucrSelectorForScatter)
        Me.Controls.Add(Me.ucrVariablesAsFactorForScatter)
        Me.Controls.Add(Me.cmdScatterPlotOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrFactorOptionalReceiver)
        Me.Controls.Add(Me.lblFactorOptional)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgScatterPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scatter Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrFactorOptionalReceiver As ucrReceiverSingle
    Friend WithEvents lblFactorOptional As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblXVariable As Label
    Friend WithEvents cmdScatterPlotOptions As Button
    Friend WithEvents ucrVariablesAsFactorForScatter As ucrVariablesAsFactor
    Friend WithEvents ucrSelectorForScatter As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSaveScatterPlot As ucrSave
    Friend WithEvents ucrChkLineofBestFit As ucrCheck
End Class
