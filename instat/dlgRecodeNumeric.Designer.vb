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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRecodeNumeric))
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.lblBreakPoints = New System.Windows.Forms.Label()
        Me.grpClosedOn = New System.Windows.Forms.GroupBox()
        Me.rdoRight = New System.Windows.Forms.RadioButton()
        Me.rdoLeft = New System.Windows.Forms.RadioButton()
        Me.ucrPnlClosedOn = New instat.UcrPanel()
        Me.ucrSaveRecodeNumeric = New instat.ucrSave()
        Me.ucrChkAddLabel = New instat.ucrCheck()
        Me.ucrInputMultipleNumericRecode = New instat.ucrInputTextBox()
        Me.ucrInputMultipleLabels = New instat.ucrInputTextBox()
        Me.ucrReceiverRecode = New instat.ucrReceiverSingle()
        Me.ucrSelectorRecode = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
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
        Me.grpClosedOn.Controls.Add(Me.rdoRight)
        Me.grpClosedOn.Controls.Add(Me.rdoLeft)
        Me.grpClosedOn.Controls.Add(Me.ucrPnlClosedOn)
        resources.ApplyResources(Me.grpClosedOn, "grpClosedOn")
        Me.grpClosedOn.Name = "grpClosedOn"
        Me.grpClosedOn.TabStop = False
        Me.grpClosedOn.Tag = "Closed_On"
        '
        'rdoRight
        '
        resources.ApplyResources(Me.rdoRight, "rdoRight")
        Me.rdoRight.Name = "rdoRight"
        Me.rdoRight.Tag = "Right"
        Me.rdoRight.UseVisualStyleBackColor = True
        '
        'rdoLeft
        '
        resources.ApplyResources(Me.rdoLeft, "rdoLeft")
        Me.rdoLeft.Name = "rdoLeft"
        Me.rdoLeft.Tag = "Left"
        Me.rdoLeft.UseVisualStyleBackColor = True
        '
        'ucrPnlClosedOn
        '
        resources.ApplyResources(Me.ucrPnlClosedOn, "ucrPnlClosedOn")
        Me.ucrPnlClosedOn.Name = "ucrPnlClosedOn"
        '
        'ucrSaveRecodeNumeric
        '
        resources.ApplyResources(Me.ucrSaveRecodeNumeric, "ucrSaveRecodeNumeric")
        Me.ucrSaveRecodeNumeric.Name = "ucrSaveRecodeNumeric"
        '
        'ucrChkAddLabel
        '
        Me.ucrChkAddLabel.Checked = False
        resources.ApplyResources(Me.ucrChkAddLabel, "ucrChkAddLabel")
        Me.ucrChkAddLabel.Name = "ucrChkAddLabel"
        '
        'ucrInputMultipleNumericRecode
        '
        Me.ucrInputMultipleNumericRecode.AddQuotesIfUnrecognised = True
        Me.ucrInputMultipleNumericRecode.IsMultiline = False
        Me.ucrInputMultipleNumericRecode.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMultipleNumericRecode, "ucrInputMultipleNumericRecode")
        Me.ucrInputMultipleNumericRecode.Name = "ucrInputMultipleNumericRecode"
        '
        'ucrInputMultipleLabels
        '
        Me.ucrInputMultipleLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputMultipleLabels.IsMultiline = False
        Me.ucrInputMultipleLabels.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMultipleLabels, "ucrInputMultipleLabels")
        Me.ucrInputMultipleLabels.Name = "ucrInputMultipleLabels"
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
        'ucrSelectorRecode
        '
        Me.ucrSelectorRecode.bDropUnusedFilterLevels = False
        Me.ucrSelectorRecode.bShowHiddenColumns = False
        Me.ucrSelectorRecode.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorRecode, "ucrSelectorRecode")
        Me.ucrSelectorRecode.Name = "ucrSelectorRecode"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgRecodeNumeric
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveRecodeNumeric)
        Me.Controls.Add(Me.ucrChkAddLabel)
        Me.Controls.Add(Me.ucrInputMultipleNumericRecode)
        Me.Controls.Add(Me.ucrInputMultipleLabels)
        Me.Controls.Add(Me.grpClosedOn)
        Me.Controls.Add(Me.lblBreakPoints)
        Me.Controls.Add(Me.ucrReceiverRecode)
        Me.Controls.Add(Me.ucrSelectorRecode)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.ucrBase)
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
    Friend WithEvents ucrSelectorRecode As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRecode As ucrReceiverSingle
    Friend WithEvents lblBreakPoints As Label
    Friend WithEvents grpClosedOn As GroupBox
    Friend WithEvents ucrInputMultipleLabels As ucrInputTextBox
    Friend WithEvents ucrInputMultipleNumericRecode As ucrInputTextBox
    Friend WithEvents rdoRight As RadioButton
    Friend WithEvents rdoLeft As RadioButton
    Friend WithEvents ucrPnlClosedOn As UcrPanel
    Friend WithEvents ucrChkAddLabel As ucrCheck
    Friend WithEvents ucrSaveRecodeNumeric As ucrSave
End Class
