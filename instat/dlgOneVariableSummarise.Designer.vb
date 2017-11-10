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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgOneVariableSummarise))
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
        resources.ApplyResources(Me.lblSelectedVariable, "lblSelectedVariable")
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Tag = "Selected_Variable"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverOneVarSummarise
        '
        Me.ucrReceiverOneVarSummarise.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverOneVarSummarise, "ucrReceiverOneVarSummarise")
        Me.ucrReceiverOneVarSummarise.Name = "ucrReceiverOneVarSummarise"
        Me.ucrReceiverOneVarSummarise.Selector = Nothing
        Me.ucrReceiverOneVarSummarise.strNcFilePath = ""
        Me.ucrReceiverOneVarSummarise.ucrSelector = Nothing
        '
        'ucrSelectorOneVarSummarise
        '
        Me.ucrSelectorOneVarSummarise.bShowHiddenColumns = False
        Me.ucrSelectorOneVarSummarise.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorOneVarSummarise, "ucrSelectorOneVarSummarise")
        Me.ucrSelectorOneVarSummarise.Name = "ucrSelectorOneVarSummarise"
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.Checked = False
        resources.ApplyResources(Me.ucrChkOmitMissing, "ucrChkOmitMissing")
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        '
        'ucrChkSaveResult
        '
        Me.ucrChkSaveResult.Checked = False
        resources.ApplyResources(Me.ucrChkSaveResult, "ucrChkSaveResult")
        Me.ucrChkSaveResult.Name = "ucrChkSaveResult"
        '
        'ucrChkCustomise
        '
        Me.ucrChkCustomise.Checked = False
        resources.ApplyResources(Me.ucrChkCustomise, "ucrChkCustomise")
        Me.ucrChkCustomise.Name = "ucrChkCustomise"
        '
        'lblMaxSum
        '
        resources.ApplyResources(Me.lblMaxSum, "lblMaxSum")
        Me.lblMaxSum.Name = "lblMaxSum"
        '
        'ucrNudMaxSum
        '
        Me.ucrNudMaxSum.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxSum.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMaxSum, "ucrNudMaxSum")
        Me.ucrNudMaxSum.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxSum.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxSum.Name = "ucrNudMaxSum"
        Me.ucrNudMaxSum.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmdSummaries
        '
        resources.ApplyResources(Me.cmdSummaries, "cmdSummaries")
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'dlgOneVariableSummarise
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Tag = "One_Variable_summarise"
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