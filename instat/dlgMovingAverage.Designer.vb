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
Partial Class dlgMovingAverage
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
        Me.lblDataToAverage = New System.Windows.Forms.Label()
        Me.ucrReceiverDataToAverage = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrSaveResultsInto = New instat.ucrSave()
        Me.ucrChkPlot = New instat.ucrCheck()
        Me.ucrChkLag = New instat.ucrCheck()
        Me.ucrChkSaveResiduals = New instat.ucrCheck()
        Me.ucrChkDisplayResults = New instat.ucrCheck()
        Me.ucrInputLag = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'lblDataToAverage
        '
        Me.lblDataToAverage.AutoSize = True
        Me.lblDataToAverage.Location = New System.Drawing.Point(233, 26)
        Me.lblDataToAverage.Name = "lblDataToAverage"
        Me.lblDataToAverage.Size = New System.Drawing.Size(109, 13)
        Me.lblDataToAverage.TabIndex = 3
        Me.lblDataToAverage.Tag = ""
        Me.lblDataToAverage.Text = "Data to be Averaged:"
        '
        'ucrReceiverDataToAverage
        '
        Me.ucrReceiverDataToAverage.bAddRemoveParameter = True
        Me.ucrReceiverDataToAverage.bChangeParameterValue = True
        Me.ucrReceiverDataToAverage.frmParent = Me
        Me.ucrReceiverDataToAverage.Location = New System.Drawing.Point(236, 41)
        Me.ucrReceiverDataToAverage.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataToAverage.Name = "ucrReceiverDataToAverage"
        Me.ucrReceiverDataToAverage.Selector = Nothing
        Me.ucrReceiverDataToAverage.Size = New System.Drawing.Size(137, 26)
        Me.ucrReceiverDataToAverage.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 281)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 54)
        Me.ucrBase.TabIndex = 1
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bAddRemoveParameter = True
        Me.ucrAddRemove.bChangeParameterValue = True
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.Location = New System.Drawing.Point(9, 41)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 155)
        Me.ucrAddRemove.TabIndex = 0
        '
        'ucrSaveResultsInto
        '
        Me.ucrSaveResultsInto.bAddRemoveParameter = True
        Me.ucrSaveResultsInto.bChangeParameterValue = True
        Me.ucrSaveResultsInto.Location = New System.Drawing.Point(10, 251)
        Me.ucrSaveResultsInto.Name = "ucrSaveResultsInto"
        Me.ucrSaveResultsInto.Size = New System.Drawing.Size(333, 24)
        Me.ucrSaveResultsInto.TabIndex = 11
        '
        'ucrChkPlot
        '
        Me.ucrChkPlot.bAddRemoveParameter = True
        Me.ucrChkPlot.bChangeParameterValue = True
        Me.ucrChkPlot.Checked = False
        Me.ucrChkPlot.Location = New System.Drawing.Point(140, 199)
        Me.ucrChkPlot.Name = "ucrChkPlot"
        Me.ucrChkPlot.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkPlot.TabIndex = 13
        '
        'ucrChkLag
        '
        Me.ucrChkLag.bAddRemoveParameter = True
        Me.ucrChkLag.bChangeParameterValue = True
        Me.ucrChkLag.Checked = False
        Me.ucrChkLag.Location = New System.Drawing.Point(140, 225)
        Me.ucrChkLag.Name = "ucrChkLag"
        Me.ucrChkLag.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkLag.TabIndex = 14
        '
        'ucrChkSaveResiduals
        '
        Me.ucrChkSaveResiduals.bAddRemoveParameter = True
        Me.ucrChkSaveResiduals.bChangeParameterValue = True
        Me.ucrChkSaveResiduals.Checked = False
        Me.ucrChkSaveResiduals.Location = New System.Drawing.Point(10, 199)
        Me.ucrChkSaveResiduals.Name = "ucrChkSaveResiduals"
        Me.ucrChkSaveResiduals.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSaveResiduals.TabIndex = 15
        '
        'ucrChkDisplayResults
        '
        Me.ucrChkDisplayResults.bAddRemoveParameter = True
        Me.ucrChkDisplayResults.bChangeParameterValue = True
        Me.ucrChkDisplayResults.Checked = False
        Me.ucrChkDisplayResults.Location = New System.Drawing.Point(10, 225)
        Me.ucrChkDisplayResults.Name = "ucrChkDisplayResults"
        Me.ucrChkDisplayResults.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkDisplayResults.TabIndex = 16
        '
        'ucrInputLag
        '
        Me.ucrInputLag.bAddRemoveParameter = True
        Me.ucrInputLag.bChangeParameterValue = True
        Me.ucrInputLag.IsMultiline = False
        Me.ucrInputLag.IsReadOnly = False
        Me.ucrInputLag.Location = New System.Drawing.Point(241, 224)
        Me.ucrInputLag.Name = "ucrInputLag"
        Me.ucrInputLag.Size = New System.Drawing.Size(80, 21)
        Me.ucrInputLag.TabIndex = 17
        '
        'dlgMovingAverage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(442, 347)
        Me.Controls.Add(Me.ucrInputLag)
        Me.Controls.Add(Me.ucrChkDisplayResults)
        Me.Controls.Add(Me.ucrChkSaveResiduals)
        Me.Controls.Add(Me.ucrChkLag)
        Me.Controls.Add(Me.ucrChkPlot)
        Me.Controls.Add(Me.ucrSaveResultsInto)
        Me.Controls.Add(Me.lblDataToAverage)
        Me.Controls.Add(Me.ucrReceiverDataToAverage)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMovingAverage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Moving_Averages"
        Me.Text = "Moving Averages"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverDataToAverage As ucrReceiverSingle
    Friend WithEvents lblDataToAverage As Label
    Friend WithEvents ucrInputLag As ucrInputTextBox
    Friend WithEvents ucrChkDisplayResults As ucrCheck
    Friend WithEvents ucrChkSaveResiduals As ucrCheck
    Friend WithEvents ucrChkLag As ucrCheck
    Friend WithEvents ucrChkPlot As ucrCheck
    Friend WithEvents ucrSaveResultsInto As ucrSave
End Class
