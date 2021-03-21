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
Partial Class dlgReplaceValues
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgReplaceValues))
        Me.grpOld = New System.Windows.Forms.GroupBox()
        Me.rdoOldValue = New System.Windows.Forms.RadioButton()
        Me.lblRangeMax = New System.Windows.Forms.Label()
        Me.rdoOldMissing = New System.Windows.Forms.RadioButton()
        Me.rdoOldInterval = New System.Windows.Forms.RadioButton()
        Me.lblRangeMin = New System.Windows.Forms.Label()
        Me.ucrChkMax = New instat.ucrCheck()
        Me.ucrInputRangeTo = New instat.ucrInputTextBox()
        Me.ucrChkMin = New instat.ucrCheck()
        Me.ucrInputRangeFrom = New instat.ucrInputTextBox()
        Me.ucrInputOldValue = New instat.ucrInputTextBox()
        Me.ucrPnlOld = New instat.UcrPanel()
        Me.grpNew = New System.Windows.Forms.GroupBox()
        Me.rdoNewFromAbove = New System.Windows.Forms.RadioButton()
        Me.rdoNewFromBelow = New System.Windows.Forms.RadioButton()
        Me.ucrInputNewValue = New instat.ucrInputTextBox()
        Me.rdoNewMissing = New System.Windows.Forms.RadioButton()
        Me.rdoNewValue = New System.Windows.Forms.RadioButton()
        Me.ucrPnlNew = New instat.UcrPanel()
        Me.lblSelectedColumns = New System.Windows.Forms.Label()
        Me.ucrReceiverReplace = New instat.ucrReceiverMultiple()
        Me.ucrSelectorReplace = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpOld.SuspendLayout()
        Me.grpNew.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOld
        '
        Me.grpOld.Controls.Add(Me.rdoOldValue)
        Me.grpOld.Controls.Add(Me.lblRangeMax)
        Me.grpOld.Controls.Add(Me.rdoOldMissing)
        Me.grpOld.Controls.Add(Me.rdoOldInterval)
        Me.grpOld.Controls.Add(Me.lblRangeMin)
        Me.grpOld.Controls.Add(Me.ucrChkMax)
        Me.grpOld.Controls.Add(Me.ucrInputRangeTo)
        Me.grpOld.Controls.Add(Me.ucrChkMin)
        Me.grpOld.Controls.Add(Me.ucrInputRangeFrom)
        Me.grpOld.Controls.Add(Me.ucrInputOldValue)
        Me.grpOld.Controls.Add(Me.ucrPnlOld)
        resources.ApplyResources(Me.grpOld, "grpOld")
        Me.grpOld.Name = "grpOld"
        Me.grpOld.TabStop = False
        Me.grpOld.Tag = "Old"
        '
        'rdoOldValue
        '
        resources.ApplyResources(Me.rdoOldValue, "rdoOldValue")
        Me.rdoOldValue.Name = "rdoOldValue"
        Me.rdoOldValue.TabStop = True
        Me.rdoOldValue.UseVisualStyleBackColor = True
        '
        'lblRangeMax
        '
        resources.ApplyResources(Me.lblRangeMax, "lblRangeMax")
        Me.lblRangeMax.Name = "lblRangeMax"
        Me.lblRangeMax.Tag = "Maximum"
        '
        'rdoOldMissing
        '
        resources.ApplyResources(Me.rdoOldMissing, "rdoOldMissing")
        Me.rdoOldMissing.Name = "rdoOldMissing"
        Me.rdoOldMissing.TabStop = True
        Me.rdoOldMissing.UseVisualStyleBackColor = True
        '
        'rdoOldInterval
        '
        resources.ApplyResources(Me.rdoOldInterval, "rdoOldInterval")
        Me.rdoOldInterval.Name = "rdoOldInterval"
        Me.rdoOldInterval.TabStop = True
        Me.rdoOldInterval.UseVisualStyleBackColor = True
        '
        'lblRangeMin
        '
        resources.ApplyResources(Me.lblRangeMin, "lblRangeMin")
        Me.lblRangeMin.Name = "lblRangeMin"
        Me.lblRangeMin.Tag = "Minimum"
        '
        'ucrChkMax
        '
        Me.ucrChkMax.Checked = False
        resources.ApplyResources(Me.ucrChkMax, "ucrChkMax")
        Me.ucrChkMax.Name = "ucrChkMax"
        '
        'ucrInputRangeTo
        '
        Me.ucrInputRangeTo.AddQuotesIfUnrecognised = True
        Me.ucrInputRangeTo.IsMultiline = False
        Me.ucrInputRangeTo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputRangeTo, "ucrInputRangeTo")
        Me.ucrInputRangeTo.Name = "ucrInputRangeTo"
        '
        'ucrChkMin
        '
        Me.ucrChkMin.Checked = False
        resources.ApplyResources(Me.ucrChkMin, "ucrChkMin")
        Me.ucrChkMin.Name = "ucrChkMin"
        '
        'ucrInputRangeFrom
        '
        Me.ucrInputRangeFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputRangeFrom.IsMultiline = False
        Me.ucrInputRangeFrom.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputRangeFrom, "ucrInputRangeFrom")
        Me.ucrInputRangeFrom.Name = "ucrInputRangeFrom"
        '
        'ucrInputOldValue
        '
        Me.ucrInputOldValue.AddQuotesIfUnrecognised = True
        Me.ucrInputOldValue.IsMultiline = False
        Me.ucrInputOldValue.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputOldValue, "ucrInputOldValue")
        Me.ucrInputOldValue.Name = "ucrInputOldValue"
        '
        'ucrPnlOld
        '
        resources.ApplyResources(Me.ucrPnlOld, "ucrPnlOld")
        Me.ucrPnlOld.Name = "ucrPnlOld"
        '
        'grpNew
        '
        Me.grpNew.Controls.Add(Me.rdoNewFromAbove)
        Me.grpNew.Controls.Add(Me.rdoNewFromBelow)
        Me.grpNew.Controls.Add(Me.ucrInputNewValue)
        Me.grpNew.Controls.Add(Me.rdoNewMissing)
        Me.grpNew.Controls.Add(Me.rdoNewValue)
        Me.grpNew.Controls.Add(Me.ucrPnlNew)
        resources.ApplyResources(Me.grpNew, "grpNew")
        Me.grpNew.Name = "grpNew"
        Me.grpNew.TabStop = False
        Me.grpNew.Tag = "New"
        '
        'rdoNewFromAbove
        '
        resources.ApplyResources(Me.rdoNewFromAbove, "rdoNewFromAbove")
        Me.rdoNewFromAbove.Name = "rdoNewFromAbove"
        Me.rdoNewFromAbove.TabStop = True
        Me.rdoNewFromAbove.UseVisualStyleBackColor = True
        '
        'rdoNewFromBelow
        '
        resources.ApplyResources(Me.rdoNewFromBelow, "rdoNewFromBelow")
        Me.rdoNewFromBelow.Name = "rdoNewFromBelow"
        Me.rdoNewFromBelow.TabStop = True
        Me.rdoNewFromBelow.UseVisualStyleBackColor = True
        '
        'ucrInputNewValue
        '
        Me.ucrInputNewValue.AddQuotesIfUnrecognised = True
        Me.ucrInputNewValue.IsMultiline = False
        Me.ucrInputNewValue.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNewValue, "ucrInputNewValue")
        Me.ucrInputNewValue.Name = "ucrInputNewValue"
        '
        'rdoNewMissing
        '
        resources.ApplyResources(Me.rdoNewMissing, "rdoNewMissing")
        Me.rdoNewMissing.Name = "rdoNewMissing"
        Me.rdoNewMissing.TabStop = True
        Me.rdoNewMissing.UseVisualStyleBackColor = True
        '
        'rdoNewValue
        '
        resources.ApplyResources(Me.rdoNewValue, "rdoNewValue")
        Me.rdoNewValue.Name = "rdoNewValue"
        Me.rdoNewValue.TabStop = True
        Me.rdoNewValue.UseVisualStyleBackColor = True
        '
        'ucrPnlNew
        '
        resources.ApplyResources(Me.ucrPnlNew, "ucrPnlNew")
        Me.ucrPnlNew.Name = "ucrPnlNew"
        '
        'lblSelectedColumns
        '
        resources.ApplyResources(Me.lblSelectedColumns, "lblSelectedColumns")
        Me.lblSelectedColumns.Name = "lblSelectedColumns"
        Me.lblSelectedColumns.Tag = "Selected_Column(s)"
        '
        'ucrReceiverReplace
        '
        Me.ucrReceiverReplace.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverReplace, "ucrReceiverReplace")
        Me.ucrReceiverReplace.Name = "ucrReceiverReplace"
        Me.ucrReceiverReplace.Selector = Nothing
        Me.ucrReceiverReplace.strNcFilePath = ""
        Me.ucrReceiverReplace.ucrSelector = Nothing
        '
        'ucrSelectorReplace
        '
        Me.ucrSelectorReplace.bShowHiddenColumns = False
        Me.ucrSelectorReplace.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorReplace, "ucrSelectorReplace")
        Me.ucrSelectorReplace.Name = "ucrSelectorReplace"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgReplaceValues
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpOld)
        Me.Controls.Add(Me.lblSelectedColumns)
        Me.Controls.Add(Me.grpNew)
        Me.Controls.Add(Me.ucrReceiverReplace)
        Me.Controls.Add(Me.ucrSelectorReplace)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReplaceValues"
        Me.Tag = "Replace"
        Me.grpOld.ResumeLayout(False)
        Me.grpOld.PerformLayout()
        Me.grpNew.ResumeLayout(False)
        Me.grpNew.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorReplace As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverReplace As ucrReceiverMultiple
    Friend WithEvents grpOld As GroupBox
    Friend WithEvents grpNew As GroupBox
    Friend WithEvents lblSelectedColumns As Label
    Friend WithEvents lblRangeMax As Label
    Friend WithEvents lblRangeMin As Label
    Friend WithEvents rdoOldValue As RadioButton
    Friend WithEvents rdoOldMissing As RadioButton
    Friend WithEvents rdoOldInterval As RadioButton
    Friend WithEvents ucrChkMax As ucrCheck
    Friend WithEvents ucrInputRangeTo As ucrInputTextBox
    Friend WithEvents ucrChkMin As ucrCheck
    Friend WithEvents ucrInputRangeFrom As ucrInputTextBox
    Friend WithEvents ucrInputOldValue As ucrInputTextBox
    Friend WithEvents ucrPnlOld As UcrPanel
    Friend WithEvents ucrInputNewValue As ucrInputTextBox
    Friend WithEvents rdoNewMissing As RadioButton
    Friend WithEvents rdoNewValue As RadioButton
    Friend WithEvents ucrPnlNew As UcrPanel
    Friend WithEvents rdoNewFromBelow As RadioButton
    Friend WithEvents rdoNewFromAbove As RadioButton
End Class
