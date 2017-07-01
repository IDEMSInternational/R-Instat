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
Partial Class dlgStack
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
        Me.lblColumnsTostack = New System.Windows.Forms.Label()
        Me.lblStackDataInto = New System.Windows.Forms.Label()
        Me.lblFactorInto = New System.Windows.Forms.Label()
        Me.ucrNudNoSets = New instat.ucrNud()
        Me.ucrChkStackMultipleSets = New instat.ucrCheck()
        Me.ucrSaveNewDataName = New instat.ucrSave()
        Me.ucrChkCarryColumns = New instat.ucrCheck()
        Me.ucrStackDataInto = New instat.ucrInputTextBox()
        Me.ucrFactorInto = New instat.ucrInputTextBox()
        Me.ucrColumnsToCarryReceiver = New instat.ucrReceiverMultiple()
        Me.ucrSelectorStack = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverColumnsToBeStack = New instat.ucrReceiverMultiple()
        Me.lblSets = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblColumnsTostack
        '
        Me.lblColumnsTostack.AutoSize = True
        Me.lblColumnsTostack.Location = New System.Drawing.Point(278, 45)
        Me.lblColumnsTostack.Name = "lblColumnsTostack"
        Me.lblColumnsTostack.Size = New System.Drawing.Size(93, 13)
        Me.lblColumnsTostack.TabIndex = 1
        Me.lblColumnsTostack.Tag = "Columns_to_Stack:"
        Me.lblColumnsTostack.Text = "Columns to Stack:"
        '
        'lblStackDataInto
        '
        Me.lblStackDataInto.AutoSize = True
        Me.lblStackDataInto.Location = New System.Drawing.Point(10, 275)
        Me.lblStackDataInto.Name = "lblStackDataInto"
        Me.lblStackDataInto.Size = New System.Drawing.Size(85, 13)
        Me.lblStackDataInto.TabIndex = 7
        Me.lblStackDataInto.Tag = "Stack_Data_Into"
        Me.lblStackDataInto.Text = "Stack Data Into:"
        '
        'lblFactorInto
        '
        Me.lblFactorInto.AutoSize = True
        Me.lblFactorInto.Location = New System.Drawing.Point(10, 243)
        Me.lblFactorInto.Name = "lblFactorInto"
        Me.lblFactorInto.Size = New System.Drawing.Size(61, 13)
        Me.lblFactorInto.TabIndex = 5
        Me.lblFactorInto.Tag = "Factor_Into"
        Me.lblFactorInto.Text = "Factor Into:"
        '
        'ucrNudNoSets
        '
        Me.ucrNudNoSets.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoSets.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNoSets.Location = New System.Drawing.Point(210, 209)
        Me.ucrNudNoSets.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNoSets.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoSets.Name = "ucrNudNoSets"
        Me.ucrNudNoSets.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNoSets.TabIndex = 12
        Me.ucrNudNoSets.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkStackMultipleSets
        '
        Me.ucrChkStackMultipleSets.Checked = False
        Me.ucrChkStackMultipleSets.Location = New System.Drawing.Point(10, 209)
        Me.ucrChkStackMultipleSets.Name = "ucrChkStackMultipleSets"
        Me.ucrChkStackMultipleSets.Size = New System.Drawing.Size(148, 20)
        Me.ucrChkStackMultipleSets.TabIndex = 11
        '
        'ucrSaveNewDataName
        '
        Me.ucrSaveNewDataName.Location = New System.Drawing.Point(10, 301)
        Me.ucrSaveNewDataName.Name = "ucrSaveNewDataName"
        Me.ucrSaveNewDataName.Size = New System.Drawing.Size(266, 20)
        Me.ucrSaveNewDataName.TabIndex = 9
        '
        'ucrChkCarryColumns
        '
        Me.ucrChkCarryColumns.Checked = False
        Me.ucrChkCarryColumns.Location = New System.Drawing.Point(278, 170)
        Me.ucrChkCarryColumns.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrChkCarryColumns.Name = "ucrChkCarryColumns"
        Me.ucrChkCarryColumns.Size = New System.Drawing.Size(120, 20)
        Me.ucrChkCarryColumns.TabIndex = 3
        '
        'ucrStackDataInto
        '
        Me.ucrStackDataInto.AddQuotesIfUnrecognised = True
        Me.ucrStackDataInto.IsMultiline = False
        Me.ucrStackDataInto.IsReadOnly = False
        Me.ucrStackDataInto.Location = New System.Drawing.Point(95, 272)
        Me.ucrStackDataInto.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrStackDataInto.Name = "ucrStackDataInto"
        Me.ucrStackDataInto.Size = New System.Drawing.Size(165, 21)
        Me.ucrStackDataInto.TabIndex = 8
        '
        'ucrFactorInto
        '
        Me.ucrFactorInto.AddQuotesIfUnrecognised = True
        Me.ucrFactorInto.IsMultiline = False
        Me.ucrFactorInto.IsReadOnly = False
        Me.ucrFactorInto.Location = New System.Drawing.Point(95, 241)
        Me.ucrFactorInto.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrFactorInto.Name = "ucrFactorInto"
        Me.ucrFactorInto.Size = New System.Drawing.Size(165, 21)
        Me.ucrFactorInto.TabIndex = 6
        '
        'ucrColumnsToCarryReceiver
        '
        Me.ucrColumnsToCarryReceiver.frmParent = Me
        Me.ucrColumnsToCarryReceiver.Location = New System.Drawing.Point(278, 194)
        Me.ucrColumnsToCarryReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrColumnsToCarryReceiver.Name = "ucrColumnsToCarryReceiver"
        Me.ucrColumnsToCarryReceiver.Selector = Nothing
        Me.ucrColumnsToCarryReceiver.Size = New System.Drawing.Size(120, 100)
        Me.ucrColumnsToCarryReceiver.strNcFilePath = ""
        Me.ucrColumnsToCarryReceiver.TabIndex = 4
        Me.ucrColumnsToCarryReceiver.ucrSelector = Nothing
        '
        'ucrSelectorStack
        '
        Me.ucrSelectorStack.bShowHiddenColumns = False
        Me.ucrSelectorStack.bUseCurrentFilter = True
        Me.ucrSelectorStack.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorStack.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStack.Name = "ucrSelectorStack"
        Me.ucrSelectorStack.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorStack.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 331)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 10
        '
        'ucrReceiverColumnsToBeStack
        '
        Me.ucrReceiverColumnsToBeStack.frmParent = Me
        Me.ucrReceiverColumnsToBeStack.Location = New System.Drawing.Point(278, 60)
        Me.ucrReceiverColumnsToBeStack.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToBeStack.Name = "ucrReceiverColumnsToBeStack"
        Me.ucrReceiverColumnsToBeStack.Selector = Nothing
        Me.ucrReceiverColumnsToBeStack.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverColumnsToBeStack.strNcFilePath = ""
        Me.ucrReceiverColumnsToBeStack.TabIndex = 2
        Me.ucrReceiverColumnsToBeStack.ucrSelector = Nothing
        '
        'lblSets
        '
        Me.lblSets.AutoSize = True
        Me.lblSets.Location = New System.Drawing.Point(176, 212)
        Me.lblSets.Name = "lblSets"
        Me.lblSets.Size = New System.Drawing.Size(31, 13)
        Me.lblSets.TabIndex = 13
        Me.lblSets.Text = "Sets:"
        '
        'dlgStack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 386)
        Me.Controls.Add(Me.lblSets)
        Me.Controls.Add(Me.ucrNudNoSets)
        Me.Controls.Add(Me.ucrChkStackMultipleSets)
        Me.Controls.Add(Me.ucrSaveNewDataName)
        Me.Controls.Add(Me.ucrChkCarryColumns)
        Me.Controls.Add(Me.ucrStackDataInto)
        Me.Controls.Add(Me.ucrFactorInto)
        Me.Controls.Add(Me.ucrColumnsToCarryReceiver)
        Me.Controls.Add(Me.ucrSelectorStack)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblFactorInto)
        Me.Controls.Add(Me.lblStackDataInto)
        Me.Controls.Add(Me.lblColumnsTostack)
        Me.Controls.Add(Me.ucrReceiverColumnsToBeStack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Stack_join_columns"
        Me.Text = "Stack (melt) Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverColumnsToBeStack As ucrReceiverMultiple
    Friend WithEvents lblColumnsTostack As Label
    Friend WithEvents lblStackDataInto As Label
    Friend WithEvents lblFactorInto As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorStack As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrColumnsToCarryReceiver As ucrReceiverMultiple
    Friend WithEvents ucrFactorInto As ucrInputTextBox
    Friend WithEvents ucrStackDataInto As ucrInputTextBox
    Friend WithEvents ucrChkCarryColumns As ucrCheck
    Friend WithEvents ucrSaveNewDataName As ucrSave
    Friend WithEvents ucrNudNoSets As ucrNud
    Friend WithEvents ucrChkStackMultipleSets As ucrCheck
    Friend WithEvents lblSets As Label
End Class
