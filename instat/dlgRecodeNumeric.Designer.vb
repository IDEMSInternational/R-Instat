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
Partial Class dlgRecodeNumeric
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRecodeNumeric))
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.lblBreakPoints = New System.Windows.Forms.Label()
        Me.grpClosedOn = New System.Windows.Forms.GroupBox()
        Me.ucrChkAddLabels = New instat.ucrCheck()
        Me.ucrSaveRecode = New instat.ucrSave()
        Me.ucrReceiverRecode = New instat.ucrReceiverSingle()
        Me.ucrSelectorForRecode = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkMinimum = New instat.ucrCheck()
        Me.ucrChkQuantiles = New instat.ucrCheck()
        Me.ucrMultipleNumericRecode = New instat.ucrInputTextBox()
        Me.ucrNudMinimum = New instat.ucrNud()
        Me.ucrNudQuantiles = New instat.ucrNud()
        Me.ttBreakpoint = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttQuantiles = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttMinimum = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpClosedOn.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedVariable
        '
        resources.ApplyResources(Me.lblSelectedVariable, "lblSelectedVariable")
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Tag = "Selected_Variable"
        '
        'lblBreakPoints
        '
        resources.ApplyResources(Me.lblBreakPoints, "lblBreakPoints")
        Me.lblBreakPoints.Name = "lblBreakPoints"
        Me.lblBreakPoints.Tag = "Break_Points"
        '
        'grpClosedOn
        '
        Me.grpClosedOn.Controls.Add(Me.ucrChkMinimum)
        Me.grpClosedOn.Controls.Add(Me.ucrChkQuantiles)
        Me.grpClosedOn.Controls.Add(Me.ucrMultipleNumericRecode)
        Me.grpClosedOn.Controls.Add(Me.lblBreakPoints)
        Me.grpClosedOn.Controls.Add(Me.ucrNudMinimum)
        Me.grpClosedOn.Controls.Add(Me.ucrNudQuantiles)
        resources.ApplyResources(Me.grpClosedOn, "grpClosedOn")
        Me.grpClosedOn.Name = "grpClosedOn"
        Me.grpClosedOn.TabStop = False
        '
        'ucrChkAddLabels
        '
        Me.ucrChkAddLabels.Checked = False
        resources.ApplyResources(Me.ucrChkAddLabels, "ucrChkAddLabels")
        Me.ucrChkAddLabels.Name = "ucrChkAddLabels"
        '
        'ucrSaveRecode
        '
        resources.ApplyResources(Me.ucrSaveRecode, "ucrSaveRecode")
        Me.ucrSaveRecode.Name = "ucrSaveRecode"
        '
        'ucrReceiverRecode
        '
        Me.ucrReceiverRecode.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverRecode, "ucrReceiverRecode")
        Me.ucrReceiverRecode.Name = "ucrReceiverRecode"
        Me.ucrReceiverRecode.Selector = Nothing
        Me.ucrReceiverRecode.strNcFilePath = ""
        Me.ucrReceiverRecode.ucrSelector = Nothing
        '
        'ucrSelectorForRecode
        '
        Me.ucrSelectorForRecode.bDropUnusedFilterLevels = False
        Me.ucrSelectorForRecode.bShowHiddenColumns = False
        Me.ucrSelectorForRecode.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForRecode, "ucrSelectorForRecode")
        Me.ucrSelectorForRecode.Name = "ucrSelectorForRecode"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrChkMinimum
        '
        Me.ucrChkMinimum.Checked = False
        resources.ApplyResources(Me.ucrChkMinimum, "ucrChkMinimum")
        Me.ucrChkMinimum.Name = "ucrChkMinimum"
        '
        'ucrChkQuantiles
        '
        Me.ucrChkQuantiles.Checked = False
        resources.ApplyResources(Me.ucrChkQuantiles, "ucrChkQuantiles")
        Me.ucrChkQuantiles.Name = "ucrChkQuantiles"
        '
        'ucrMultipleNumericRecode
        '
        Me.ucrMultipleNumericRecode.AddQuotesIfUnrecognised = True
        Me.ucrMultipleNumericRecode.IsMultiline = False
        Me.ucrMultipleNumericRecode.IsReadOnly = False
        resources.ApplyResources(Me.ucrMultipleNumericRecode, "ucrMultipleNumericRecode")
        Me.ucrMultipleNumericRecode.Name = "ucrMultipleNumericRecode"
        '
        'ucrNudMinimum
        '
        Me.ucrNudMinimum.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinimum.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMinimum, "ucrNudMinimum")
        Me.ucrNudMinimum.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinimum.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinimum.Name = "ucrNudMinimum"
        Me.ucrNudMinimum.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudQuantiles
        '
        Me.ucrNudQuantiles.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudQuantiles.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudQuantiles, "ucrNudQuantiles")
        Me.ucrNudQuantiles.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudQuantiles.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudQuantiles.Name = "ucrNudQuantiles"
        Me.ucrNudQuantiles.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgRecodeNumeric
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkAddLabels)
        Me.Controls.Add(Me.ucrSaveRecode)
        Me.Controls.Add(Me.ucrReceiverRecode)
        Me.Controls.Add(Me.ucrSelectorForRecode)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpClosedOn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRecodeNumeric"
        Me.Tag = "Recode_Numeric"
        Me.grpClosedOn.ResumeLayout(False)
        Me.grpClosedOn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrSelectorForRecode As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRecode As ucrReceiverSingle
    Friend WithEvents lblBreakPoints As Label
    Friend WithEvents ucrMultipleNumericRecode As ucrInputTextBox
    Friend WithEvents ucrSaveRecode As ucrSave
    Friend WithEvents ucrChkAddLabels As ucrCheck
    Friend WithEvents ucrNudMinimum As ucrNud
    Friend WithEvents ucrNudQuantiles As ucrNud
    Friend WithEvents grpClosedOn As GroupBox
    Friend WithEvents ucrChkMinimum As ucrCheck
    Friend WithEvents ucrChkQuantiles As ucrCheck
    Friend WithEvents ttBreakpoint As ToolTip
    Friend WithEvents ttQuantiles As ToolTip
    Friend WithEvents ttMinimum As ToolTip
End Class
