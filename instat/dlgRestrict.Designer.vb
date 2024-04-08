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
        Me.cmdDefineNewFilter.Location = New System.Drawing.Point(311, 110)
        Me.cmdDefineNewFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDefineNewFilter.Name = "cmdDefineNewFilter"
        Me.cmdDefineNewFilter.Size = New System.Drawing.Size(161, 38)
        Me.cmdDefineNewFilter.TabIndex = 3
        Me.cmdDefineNewFilter.Tag = "Define_New_Filter"
        Me.cmdDefineNewFilter.Text = "Define New Filter"
        Me.cmdDefineNewFilter.UseVisualStyleBackColor = True
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(311, 56)
        Me.lblFilter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(70, 16)
        Me.lblFilter.TabIndex = 1
        Me.lblFilter.Text = "Filter rows:"
        '
        'lblFilterPreview
        '
        Me.lblFilterPreview.Location = New System.Drawing.Point(12, 356)
        Me.lblFilterPreview.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFilterPreview.Name = "lblFilterPreview"
        Me.lblFilterPreview.Size = New System.Drawing.Size(148, 28)
        Me.lblFilterPreview.TabIndex = 6
        Me.lblFilterPreview.Text = "Filter Preview:"
        '
        'grpApplyOptions
        '
        Me.grpApplyOptions.Controls.Add(Me.rdoSavefilter)
        Me.grpApplyOptions.Controls.Add(Me.rdoApplyAsSubset)
        Me.grpApplyOptions.Controls.Add(Me.rdoApplyAsFilter)
        Me.grpApplyOptions.Location = New System.Drawing.Point(12, 246)
        Me.grpApplyOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.grpApplyOptions.Name = "grpApplyOptions"
        Me.grpApplyOptions.Padding = New System.Windows.Forms.Padding(4)
        Me.grpApplyOptions.Size = New System.Drawing.Size(495, 66)
        Me.grpApplyOptions.TabIndex = 4
        Me.grpApplyOptions.TabStop = False
        Me.grpApplyOptions.Text = "Apply"
        '
        'rdoSavefilter
        '
        Me.rdoSavefilter.AutoSize = True
        Me.rdoSavefilter.Location = New System.Drawing.Point(377, 24)
        Me.rdoSavefilter.Margin = New System.Windows.Forms.Padding(2)
        Me.rdoSavefilter.Name = "rdoSavefilter"
        Me.rdoSavefilter.Size = New System.Drawing.Size(92, 20)
        Me.rdoSavefilter.TabIndex = 4
        Me.rdoSavefilter.TabStop = True
        Me.rdoSavefilter.Text = "Save Filter"
        Me.rdoSavefilter.UseVisualStyleBackColor = True
        '
        'rdoApplyAsSubset
        '
        Me.rdoApplyAsSubset.Location = New System.Drawing.Point(200, 24)
        Me.rdoApplyAsSubset.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoApplyAsSubset.Name = "rdoApplyAsSubset"
        Me.rdoApplyAsSubset.Size = New System.Drawing.Size(153, 21)
        Me.rdoApplyAsSubset.TabIndex = 1
        Me.rdoApplyAsSubset.TabStop = True
        Me.rdoApplyAsSubset.Text = "As Subset"
        Me.rdoApplyAsSubset.UseVisualStyleBackColor = True
        '
        'rdoApplyAsFilter
        '
        Me.rdoApplyAsFilter.Location = New System.Drawing.Point(8, 26)
        Me.rdoApplyAsFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoApplyAsFilter.Name = "rdoApplyAsFilter"
        Me.rdoApplyAsFilter.Size = New System.Drawing.Size(164, 21)
        Me.rdoApplyAsFilter.TabIndex = 0
        Me.rdoApplyAsFilter.TabStop = True
        Me.rdoApplyAsFilter.Text = "As Filter"
        Me.rdoApplyAsFilter.UseVisualStyleBackColor = True
        '
        'cmdEditFilter
        '
        Me.cmdEditFilter.Enabled = False
        Me.cmdEditFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEditFilter.Location = New System.Drawing.Point(311, 209)
        Me.cmdEditFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEditFilter.Name = "cmdEditFilter"
        Me.cmdEditFilter.Size = New System.Drawing.Size(161, 29)
        Me.cmdEditFilter.TabIndex = 9
        Me.cmdEditFilter.Tag = "Define_New_Filter"
        Me.cmdEditFilter.Text = "Edit Filter"
        Me.cmdEditFilter.UseVisualStyleBackColor = True
        '
        'cmdFilterFromFactors
        '
        Me.cmdFilterFromFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFilterFromFactors.Location = New System.Drawing.Point(311, 154)
        Me.cmdFilterFromFactors.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFilterFromFactors.Name = "cmdFilterFromFactors"
        Me.cmdFilterFromFactors.Size = New System.Drawing.Size(161, 48)
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
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(161, 355)
        Me.ucrInputFilterPreview.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(346, 54)
        Me.ucrInputFilterPreview.TabIndex = 7
        '
        'ucrReceiverFilter
        '
        Me.ucrReceiverFilter.AutoSize = True
        Me.ucrReceiverFilter.frmParent = Me
        Me.ucrReceiverFilter.Location = New System.Drawing.Point(312, 75)
        Me.ucrReceiverFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFilter.Name = "ucrReceiverFilter"
        Me.ucrReceiverFilter.Selector = Nothing
        Me.ucrReceiverFilter.Size = New System.Drawing.Size(161, 25)
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
        Me.ucrSelectorFilter.Location = New System.Drawing.Point(12, 12)
        Me.ucrSelectorFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFilter.Name = "ucrSelectorFilter"
        Me.ucrSelectorFilter.Size = New System.Drawing.Size(267, 229)
        Me.ucrSelectorFilter.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 416)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(511, 65)
        Me.ucrBase.TabIndex = 8
        '
        'ucrNewDataFrameName
        '
        Me.ucrNewDataFrameName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrNewDataFrameName.Location = New System.Drawing.Point(12, 318)
        Me.ucrNewDataFrameName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        Me.ucrNewDataFrameName.Size = New System.Drawing.Size(460, 30)
        Me.ucrNewDataFrameName.TabIndex = 5
        '
        'dlgRestrict
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(522, 485)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
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