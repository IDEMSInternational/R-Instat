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
Partial Class dlgOneVariableSummarise
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
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverOneVarSummarise = New instat.ucrReceiverMultiple()
        Me.ucrSelectorOneVarSummarise = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrChkSaveResult = New instat.ucrCheck()
        Me.ucrChkCustomise = New instat.ucrCheck()
        Me.lblMaxSum = New System.Windows.Forms.Label()
        Me.ucrNudMaxSum = New instat.ucrNud()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.Location = New System.Drawing.Point(258, 44)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(145, 14)
        Me.lblSelectedVariable.TabIndex = 1
        Me.lblSelectedVariable.Tag = "Selected_Variable"
        Me.lblSelectedVariable.Text = "Variable(s) to Summarise:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 288)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 9
        '
        'ucrReceiverOneVarSummarise
        '
        Me.ucrReceiverOneVarSummarise.frmParent = Me
        Me.ucrReceiverOneVarSummarise.Location = New System.Drawing.Point(258, 60)
        Me.ucrReceiverOneVarSummarise.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOneVarSummarise.Name = "ucrReceiverOneVarSummarise"
        Me.ucrReceiverOneVarSummarise.Selector = Nothing
        Me.ucrReceiverOneVarSummarise.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverOneVarSummarise.strNcFilePath = ""
        Me.ucrReceiverOneVarSummarise.TabIndex = 2
        Me.ucrReceiverOneVarSummarise.ucrSelector = Nothing
        '
        'ucrSelectorOneVarSummarise
        '
        Me.ucrSelectorOneVarSummarise.bShowHiddenColumns = False
        Me.ucrSelectorOneVarSummarise.bUseCurrentFilter = True
        Me.ucrSelectorOneVarSummarise.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorOneVarSummarise.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOneVarSummarise.Name = "ucrSelectorOneVarSummarise"
        Me.ucrSelectorOneVarSummarise.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorOneVarSummarise.TabIndex = 0
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(10, 235)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(166, 20)
        Me.ucrChkOmitMissing.TabIndex = 7
        '
        'ucrChkSaveResult
        '
        Me.ucrChkSaveResult.Checked = False
        Me.ucrChkSaveResult.Location = New System.Drawing.Point(10, 262)
        Me.ucrChkSaveResult.Name = "ucrChkSaveResult"
        Me.ucrChkSaveResult.Size = New System.Drawing.Size(166, 20)
        Me.ucrChkSaveResult.TabIndex = 8
        '
        'ucrChkCustomise
        '
        Me.ucrChkCustomise.Checked = False
        Me.ucrChkCustomise.Location = New System.Drawing.Point(258, 163)
        Me.ucrChkCustomise.Name = "ucrChkCustomise"
        Me.ucrChkCustomise.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkCustomise.TabIndex = 3
        '
        'lblMaxSum
        '
        Me.lblMaxSum.AutoSize = True
        Me.lblMaxSum.Location = New System.Drawing.Point(7, 210)
        Me.lblMaxSum.Name = "lblMaxSum"
        Me.lblMaxSum.Size = New System.Drawing.Size(157, 13)
        Me.lblMaxSum.TabIndex = 5
        Me.lblMaxSum.Text = "Maximum Factor Levels Shown:"
        '
        'ucrNudMaxSum
        '
        Me.ucrNudMaxSum.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxSum.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxSum.Location = New System.Drawing.Point(168, 207)
        Me.ucrNudMaxSum.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxSum.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxSum.Name = "ucrNudMaxSum"
        Me.ucrNudMaxSum.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxSum.TabIndex = 6
        Me.ucrNudMaxSum.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmdSummaries
        '
        Me.cmdSummaries.AutoSize = True
        Me.cmdSummaries.Location = New System.Drawing.Point(305, 189)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(77, 23)
        Me.cmdSummaries.TabIndex = 4
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.Text = "Summaries..."
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'dlgOneVariableSummarise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 345)
        Me.Controls.Add(Me.lblMaxSum)
        Me.Controls.Add(Me.ucrNudMaxSum)
        Me.Controls.Add(Me.ucrChkCustomise)
        Me.Controls.Add(Me.ucrChkSaveResult)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.ucrSelectorOneVarSummarise)
        Me.Controls.Add(Me.ucrReceiverOneVarSummarise)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.cmdSummaries)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneVariableSummarise"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Describe_One_Variable"
        Me.Text = "One Variable Summarise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverOneVarSummarise As ucrReceiverMultiple
    Friend WithEvents ucrSelectorOneVarSummarise As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrChkSaveResult As ucrCheck
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents ucrChkCustomise As ucrCheck
    Friend WithEvents lblMaxSum As Label
    Friend WithEvents ucrNudMaxSum As ucrNud
    Friend WithEvents cmdSummaries As Button
End Class