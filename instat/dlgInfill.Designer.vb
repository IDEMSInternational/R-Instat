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
Partial Class dlgInfill
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInfillSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverFactors = New instat.ucrReceiverMultiple()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 209)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 5
        '
        'ucrInfillSelector
        '
        Me.ucrInfillSelector.bAddRemoveParameter = True
        Me.ucrInfillSelector.bChangeParameterValue = True
        Me.ucrInfillSelector.bShowHiddenColumns = False
        Me.ucrInfillSelector.bUseCurrentFilter = True
        Me.ucrInfillSelector.Location = New System.Drawing.Point(9, 9)
        Me.ucrInfillSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInfillSelector.Name = "ucrInfillSelector"
        Me.ucrInfillSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrInfillSelector.TabIndex = 0
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.bAddRemoveParameter = True
        Me.ucrReceiverDate.bChangeParameterValue = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(278, 37)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.TabIndex = 2
        '
        'ucrReceiverFactors
        '
        Me.ucrReceiverFactors.bAddRemoveParameter = True
        Me.ucrReceiverFactors.bChangeParameterValue = True
        Me.ucrReceiverFactors.frmParent = Me
        Me.ucrReceiverFactors.Location = New System.Drawing.Point(278, 90)
        Me.ucrReceiverFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactors.Name = "ucrReceiverFactors"
        Me.ucrReceiverFactors.Selector = Nothing
        Me.ucrReceiverFactors.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverFactors.TabIndex = 4
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(282, 18)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date:"
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(278, 73)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(45, 13)
        Me.lblFactors.TabIndex = 3
        Me.lblFactors.Text = "Factors:"
        '
        'dlgInfill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 270)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverFactors)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrInfillSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInfill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Infill"
        Me.Text = "Infill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInfillSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverFactors As ucrReceiverMultiple
    Friend WithEvents lblDate As Label
    Friend WithEvents lblFactors As Label
End Class
