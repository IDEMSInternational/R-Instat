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
Partial Class dlgRestrict
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
        Me.cmdDefineNewFilter = New System.Windows.Forms.Button()
        Me.ucrSelectorFilter = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.ucrReceiverFilter = New instat.ucrReceiverSingle()
        Me.lblFilterPreview = New System.Windows.Forms.Label()
        Me.ucrInputFilterPreview = New instat.ucrInputTextBox()
        Me.grpApplyOptions = New System.Windows.Forms.GroupBox()
        Me.rdoApplyAsSubset = New System.Windows.Forms.RadioButton()
        Me.rdoApplyAsFilter = New System.Windows.Forms.RadioButton()
        Me.ucrNewDataFrameName = New instat.ucrSave()
        Me.grpApplyOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdDefineNewFilter
        '
        Me.cmdDefineNewFilter.Location = New System.Drawing.Point(259, 95)
        Me.cmdDefineNewFilter.Name = "cmdDefineNewFilter"
        Me.cmdDefineNewFilter.Size = New System.Drawing.Size(120, 23)
        Me.cmdDefineNewFilter.TabIndex = 3
        Me.cmdDefineNewFilter.Tag = "Define_New_Filter"
        Me.cmdDefineNewFilter.Text = "Define New Filter"
        Me.cmdDefineNewFilter.UseVisualStyleBackColor = True
        '
        'ucrSelectorFilter
        '
        Me.ucrSelectorFilter.bShowHiddenColumns = False
        Me.ucrSelectorFilter.bUseCurrentFilter = True
        Me.ucrSelectorFilter.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFilter.Name = "ucrSelectorFilter"
        Me.ucrSelectorFilter.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorFilter.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 307)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 8
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(249, 45)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(32, 13)
        Me.lblFilter.TabIndex = 1
        Me.lblFilter.Text = "Filter:"
        '
        'ucrReceiverFilter
        '
        Me.ucrReceiverFilter.frmParent = Me
        Me.ucrReceiverFilter.Location = New System.Drawing.Point(250, 60)
        Me.ucrReceiverFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFilter.Name = "ucrReceiverFilter"
        Me.ucrReceiverFilter.Selector = Nothing
        Me.ucrReceiverFilter.Size = New System.Drawing.Size(129, 20)
        Me.ucrReceiverFilter.TabIndex = 2
        '
        'lblFilterPreview
        '
        Me.lblFilterPreview.AutoSize = True
        Me.lblFilterPreview.Location = New System.Drawing.Point(10, 285)
        Me.lblFilterPreview.Name = "lblFilterPreview"
        Me.lblFilterPreview.Size = New System.Drawing.Size(118, 13)
        Me.lblFilterPreview.TabIndex = 6
        Me.lblFilterPreview.Text = "Selected Filter Preview:"
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.IsMultiline = False
        Me.ucrInputFilterPreview.IsReadOnly = False
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(131, 281)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(277, 21)
        Me.ucrInputFilterPreview.TabIndex = 7
        '
        'grpApplyOptions
        '
        Me.grpApplyOptions.Controls.Add(Me.rdoApplyAsSubset)
        Me.grpApplyOptions.Controls.Add(Me.rdoApplyAsFilter)
        Me.grpApplyOptions.Location = New System.Drawing.Point(10, 197)
        Me.grpApplyOptions.Name = "grpApplyOptions"
        Me.grpApplyOptions.Size = New System.Drawing.Size(232, 53)
        Me.grpApplyOptions.TabIndex = 4
        Me.grpApplyOptions.TabStop = False
        Me.grpApplyOptions.Text = "Apply Options"
        '
        'rdoApplyAsSubset
        '
        Me.rdoApplyAsSubset.AutoSize = True
        Me.rdoApplyAsSubset.Location = New System.Drawing.Point(120, 22)
        Me.rdoApplyAsSubset.Name = "rdoApplyAsSubset"
        Me.rdoApplyAsSubset.Size = New System.Drawing.Size(102, 17)
        Me.rdoApplyAsSubset.TabIndex = 1
        Me.rdoApplyAsSubset.TabStop = True
        Me.rdoApplyAsSubset.Text = "Apply As Subset"
        Me.rdoApplyAsSubset.UseVisualStyleBackColor = True
        '
        'rdoApplyAsFilter
        '
        Me.rdoApplyAsFilter.AutoSize = True
        Me.rdoApplyAsFilter.Location = New System.Drawing.Point(6, 22)
        Me.rdoApplyAsFilter.Name = "rdoApplyAsFilter"
        Me.rdoApplyAsFilter.Size = New System.Drawing.Size(91, 17)
        Me.rdoApplyAsFilter.TabIndex = 0
        Me.rdoApplyAsFilter.TabStop = True
        Me.rdoApplyAsFilter.Text = "Apply As Filter"
        Me.rdoApplyAsFilter.UseVisualStyleBackColor = True
        '
        'ucrNewDataFrameName
        '
        Me.ucrNewDataFrameName.Location = New System.Drawing.Point(10, 256)
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        Me.ucrNewDataFrameName.Size = New System.Drawing.Size(291, 24)
        Me.ucrNewDataFrameName.TabIndex = 5
        '
        'dlgRestrict
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 366)
        Me.Controls.Add(Me.ucrNewDataFrameName)
        Me.Controls.Add(Me.grpApplyOptions)
        Me.Controls.Add(Me.ucrInputFilterPreview)
        Me.Controls.Add(Me.lblFilterPreview)
        Me.Controls.Add(Me.ucrReceiverFilter)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.ucrSelectorFilter)
        Me.Controls.Add(Me.cmdDefineNewFilter)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRestrict"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Filter"
        Me.Text = "Filter"
        Me.grpApplyOptions.ResumeLayout(False)
        Me.grpApplyOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdDefineNewFilter As Button
    Friend WithEvents ucrSelectorFilter As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFilter As Label
    Friend WithEvents ucrReceiverFilter As ucrReceiverSingle
    Friend WithEvents lblFilterPreview As Label
    Friend WithEvents ucrInputFilterPreview As ucrInputTextBox
    Friend WithEvents grpApplyOptions As GroupBox
    Friend WithEvents rdoApplyAsSubset As RadioButton
    Friend WithEvents rdoApplyAsFilter As RadioButton
    Friend WithEvents ucrNewDataFrameName As ucrSave
End Class