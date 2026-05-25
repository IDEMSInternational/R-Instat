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
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.lblFilterPreview = New System.Windows.Forms.Label()
        Me.grpApplyOptions = New System.Windows.Forms.GroupBox()
        Me.rdoSavefilter = New System.Windows.Forms.RadioButton()
        Me.rdoApplyAsSubset = New System.Windows.Forms.RadioButton()
        Me.rdoApplyAsFilter = New System.Windows.Forms.RadioButton()
        Me.cmdEditFilter = New System.Windows.Forms.Button()
        Me.cmdFilterFromFactors = New System.Windows.Forms.Button()
        Me.ucrInputFilterPreview = New instat.ucrInputTextBox()
        Me.ucrReceiverFilter = New instat.ucrReceiverSingle()
        Me.ucrSelectorFilter = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNewDataFrameName = New instat.ucrSave()
        Me.grpApplyOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdDefineNewFilter
        '
        Me.cmdDefineNewFilter.Location = New System.Drawing.Point(249, 88)
        Me.cmdDefineNewFilter.Name = "cmdDefineNewFilter"
        Me.cmdDefineNewFilter.Size = New System.Drawing.Size(129, 30)
        Me.cmdDefineNewFilter.TabIndex = 3
        Me.cmdDefineNewFilter.Tag = "Define_New_Filter"
        Me.cmdDefineNewFilter.Text = "Define New Filter"
        Me.cmdDefineNewFilter.UseVisualStyleBackColor = True
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(249, 45)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(57, 13)
        Me.lblFilter.TabIndex = 1
        Me.lblFilter.Text = "Filter rows:"
        '
        'lblFilterPreview
        '
        Me.lblFilterPreview.Location = New System.Drawing.Point(10, 285)
        Me.lblFilterPreview.Name = "lblFilterPreview"
        Me.lblFilterPreview.Size = New System.Drawing.Size(118, 22)
        Me.lblFilterPreview.TabIndex = 6
        Me.lblFilterPreview.Text = "Filter Preview:"
        '
        'grpApplyOptions
        '
        Me.grpApplyOptions.Controls.Add(Me.rdoSavefilter)
        Me.grpApplyOptions.Controls.Add(Me.rdoApplyAsSubset)
        Me.grpApplyOptions.Controls.Add(Me.rdoApplyAsFilter)
        Me.grpApplyOptions.Location = New System.Drawing.Point(10, 197)
        Me.grpApplyOptions.Name = "grpApplyOptions"
        Me.grpApplyOptions.Size = New System.Drawing.Size(396, 53)
        Me.grpApplyOptions.TabIndex = 4
        Me.grpApplyOptions.TabStop = False
        Me.grpApplyOptions.Text = "Apply"
        '
        'rdoSavefilter
        '
        Me.rdoSavefilter.AutoSize = True
        Me.rdoSavefilter.Location = New System.Drawing.Point(316, 19)
        Me.rdoSavefilter.Margin = New System.Windows.Forms.Padding(2)
        Me.rdoSavefilter.Name = "rdoSavefilter"
        Me.rdoSavefilter.Size = New System.Drawing.Size(75, 17)
        Me.rdoSavefilter.TabIndex = 4
        Me.rdoSavefilter.TabStop = True
        Me.rdoSavefilter.Text = "Store Filter"
        Me.rdoSavefilter.UseVisualStyleBackColor = True
        '
        'rdoApplyAsSubset
        '
        Me.rdoApplyAsSubset.Location = New System.Drawing.Point(158, 19)
        Me.rdoApplyAsSubset.Name = "rdoApplyAsSubset"
        Me.rdoApplyAsSubset.Size = New System.Drawing.Size(151, 17)
        Me.rdoApplyAsSubset.TabIndex = 1
        Me.rdoApplyAsSubset.TabStop = True
        Me.rdoApplyAsSubset.Text = "As Subset"
        Me.rdoApplyAsSubset.UseVisualStyleBackColor = True
        '
        'rdoApplyAsFilter
        '
        Me.rdoApplyAsFilter.Location = New System.Drawing.Point(6, 21)
        Me.rdoApplyAsFilter.Name = "rdoApplyAsFilter"
        Me.rdoApplyAsFilter.Size = New System.Drawing.Size(131, 17)
        Me.rdoApplyAsFilter.TabIndex = 0
        Me.rdoApplyAsFilter.TabStop = True
        Me.rdoApplyAsFilter.Text = "As Filter"
        Me.rdoApplyAsFilter.UseVisualStyleBackColor = True
        '
        'cmdEditFilter
        '
        Me.cmdEditFilter.Enabled = False
        Me.cmdEditFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEditFilter.Location = New System.Drawing.Point(249, 167)
        Me.cmdEditFilter.Name = "cmdEditFilter"
        Me.cmdEditFilter.Size = New System.Drawing.Size(129, 23)
        Me.cmdEditFilter.TabIndex = 9
        Me.cmdEditFilter.Tag = "Define_New_Filter"
        Me.cmdEditFilter.Text = "Edit Filter"
        Me.cmdEditFilter.UseVisualStyleBackColor = True
        '
        'cmdFilterFromFactors
        '
        Me.cmdFilterFromFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFilterFromFactors.Location = New System.Drawing.Point(249, 123)
        Me.cmdFilterFromFactors.Name = "cmdFilterFromFactors"
        Me.cmdFilterFromFactors.Size = New System.Drawing.Size(129, 38)
        Me.cmdFilterFromFactors.TabIndex = 10
        Me.cmdFilterFromFactors.Tag = "Define_New_Filter"
        Me.cmdFilterFromFactors.Text = "Filter From Factors"
        Me.cmdFilterFromFactors.UseVisualStyleBackColor = True
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.AutoSize = True
        Me.ucrInputFilterPreview.IsMultiline = True
        Me.ucrInputFilterPreview.IsReadOnly = False
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(129, 284)
        Me.ucrInputFilterPreview.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(277, 43)
        Me.ucrInputFilterPreview.TabIndex = 7
        '
        'ucrReceiverFilter
        '
        Me.ucrReceiverFilter.AutoSize = True
        Me.ucrReceiverFilter.frmParent = Me
        Me.ucrReceiverFilter.Location = New System.Drawing.Point(250, 60)
        Me.ucrReceiverFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFilter.Name = "ucrReceiverFilter"
        Me.ucrReceiverFilter.Selector = Nothing
        Me.ucrReceiverFilter.Size = New System.Drawing.Size(129, 20)
        Me.ucrReceiverFilter.strNcFilePath = ""
        Me.ucrReceiverFilter.TabIndex = 2
        Me.ucrReceiverFilter.ucrSelector = Nothing
        '
        'ucrSelectorFilter
        '
        Me.ucrSelectorFilter.AutoSize = True
        Me.ucrSelectorFilter.bDropUnusedFilterLevels = False
        Me.ucrSelectorFilter.bShowHiddenColumns = False
        Me.ucrSelectorFilter.bUseCurrentFilter = True
        Me.ucrSelectorFilter.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFilter.Name = "ucrSelectorFilter"
        Me.ucrSelectorFilter.Size = New System.Drawing.Size(214, 183)
        Me.ucrSelectorFilter.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 333)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 8
        '
        'ucrNewDataFrameName
        '
        Me.ucrNewDataFrameName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrNewDataFrameName.Location = New System.Drawing.Point(10, 254)
        Me.ucrNewDataFrameName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        Me.ucrNewDataFrameName.Size = New System.Drawing.Size(368, 24)
        Me.ucrNewDataFrameName.TabIndex = 5
        '
        'dlgRestrict
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(418, 388)
        Me.Controls.Add(Me.cmdFilterFromFactors)
        Me.Controls.Add(Me.cmdEditFilter)
        Me.Controls.Add(Me.grpApplyOptions)
        Me.Controls.Add(Me.ucrInputFilterPreview)
        Me.Controls.Add(Me.lblFilterPreview)
        Me.Controls.Add(Me.ucrReceiverFilter)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.ucrSelectorFilter)
        Me.Controls.Add(Me.cmdDefineNewFilter)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrNewDataFrameName)
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
    Friend WithEvents cmdEditFilter As Button
    Friend WithEvents cmdFilterFromFactors As Button
    Friend WithEvents rdoSavefilter As RadioButton
End Class