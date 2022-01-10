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
Partial Class dlgSplitText
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
        Me.lblSelectedFactor = New System.Windows.Forms.Label()
        Me.lblSplitBy = New System.Windows.Forms.Label()
        Me.lblNumberofPiecesToReturn = New System.Windows.Forms.Label()
        Me.rdoTextComponents = New System.Windows.Forms.RadioButton()
        Me.rdoBinaryColumns = New System.Windows.Forms.RadioButton()
        Me.rdoMaximumNumberOfComponents = New System.Windows.Forms.RadioButton()
        Me.rdoFixedNumberOfComponents = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSplitText = New instat.UcrPanel()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.ucrNudPieces = New instat.ucrNud()
        Me.ucrInputPattern = New instat.ucrInputComboBox()
        Me.ucrReceiverSplitTextColumn = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlTextComponents = New instat.UcrPanel()
        Me.ucrChkAddKeyboard = New instat.ucrCheck()
        Me.ucrChkIncludeRegularExpressions = New instat.ucrCheck()
        Me.ucrSelectorSplitTextColumn = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblSelectedFactor
        '
        Me.lblSelectedFactor.AutoSize = True
        Me.lblSelectedFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectedFactor.Location = New System.Drawing.Point(257, 62)
        Me.lblSelectedFactor.Name = "lblSelectedFactor"
        Me.lblSelectedFactor.Size = New System.Drawing.Size(80, 13)
        Me.lblSelectedFactor.TabIndex = 4
        Me.lblSelectedFactor.Tag = "Selected_Factor"
        Me.lblSelectedFactor.Text = "Column to Split:"
        '
        'lblSplitBy
        '
        Me.lblSplitBy.AutoSize = True
        Me.lblSplitBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSplitBy.Location = New System.Drawing.Point(255, 109)
        Me.lblSplitBy.Name = "lblSplitBy"
        Me.lblSplitBy.Size = New System.Drawing.Size(44, 13)
        Me.lblSplitBy.TabIndex = 6
        Me.lblSplitBy.Tag = ""
        Me.lblSplitBy.Text = "Split by:"
        '
        'lblNumberofPiecesToReturn
        '
        Me.lblNumberofPiecesToReturn.AutoSize = True
        Me.lblNumberofPiecesToReturn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumberofPiecesToReturn.Location = New System.Drawing.Point(255, 225)
        Me.lblNumberofPiecesToReturn.Name = "lblNumberofPiecesToReturn"
        Me.lblNumberofPiecesToReturn.Size = New System.Drawing.Size(141, 13)
        Me.lblNumberofPiecesToReturn.TabIndex = 11
        Me.lblNumberofPiecesToReturn.Tag = "Number_of_Pieces_to_Return"
        Me.lblNumberofPiecesToReturn.Text = "Number of Pieces to Return:"
        '
        'rdoTextComponents
        '
        Me.rdoTextComponents.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTextComponents.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTextComponents.FlatAppearance.BorderSize = 2
        Me.rdoTextComponents.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTextComponents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTextComponents.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTextComponents.Location = New System.Drawing.Point(98, 4)
        Me.rdoTextComponents.Name = "rdoTextComponents"
        Me.rdoTextComponents.Size = New System.Drawing.Size(125, 45)
        Me.rdoTextComponents.TabIndex = 1
        Me.rdoTextComponents.TabStop = True
        Me.rdoTextComponents.Text = "Into Text Components"
        Me.rdoTextComponents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTextComponents.UseVisualStyleBackColor = True
        '
        'rdoBinaryColumns
        '
        Me.rdoBinaryColumns.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBinaryColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBinaryColumns.FlatAppearance.BorderSize = 2
        Me.rdoBinaryColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBinaryColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBinaryColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBinaryColumns.Location = New System.Drawing.Point(222, 4)
        Me.rdoBinaryColumns.Name = "rdoBinaryColumns"
        Me.rdoBinaryColumns.Size = New System.Drawing.Size(125, 45)
        Me.rdoBinaryColumns.TabIndex = 2
        Me.rdoBinaryColumns.TabStop = True
        Me.rdoBinaryColumns.Text = "Into Binary Columns"
        Me.rdoBinaryColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBinaryColumns.UseVisualStyleBackColor = True
        '
        'rdoMaximumNumberOfComponents
        '
        Me.rdoMaximumNumberOfComponents.AutoSize = True
        Me.rdoMaximumNumberOfComponents.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMaximumNumberOfComponents.Location = New System.Drawing.Point(257, 164)
        Me.rdoMaximumNumberOfComponents.Name = "rdoMaximumNumberOfComponents"
        Me.rdoMaximumNumberOfComponents.Size = New System.Drawing.Size(183, 17)
        Me.rdoMaximumNumberOfComponents.TabIndex = 9
        Me.rdoMaximumNumberOfComponents.TabStop = True
        Me.rdoMaximumNumberOfComponents.Text = "Maximum Number of Components"
        Me.rdoMaximumNumberOfComponents.UseVisualStyleBackColor = True
        '
        'rdoFixedNumberOfComponents
        '
        Me.rdoFixedNumberOfComponents.AutoSize = True
        Me.rdoFixedNumberOfComponents.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFixedNumberOfComponents.Location = New System.Drawing.Point(257, 189)
        Me.rdoFixedNumberOfComponents.Name = "rdoFixedNumberOfComponents"
        Me.rdoFixedNumberOfComponents.Size = New System.Drawing.Size(164, 17)
        Me.rdoFixedNumberOfComponents.TabIndex = 10
        Me.rdoFixedNumberOfComponents.TabStop = True
        Me.rdoFixedNumberOfComponents.Text = "Fixed Number of Components"
        Me.rdoFixedNumberOfComponents.UseVisualStyleBackColor = True
        '
        'ucrPnlSplitText
        '
        Me.ucrPnlSplitText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSplitText.Location = New System.Drawing.Point(55, 4)
        Me.ucrPnlSplitText.Name = "ucrPnlSplitText"
        Me.ucrPnlSplitText.Size = New System.Drawing.Size(309, 45)
        Me.ucrPnlSplitText.TabIndex = 0
        '
        'ucrSaveColumn
        '
        Me.ucrSaveColumn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveColumn.Location = New System.Drawing.Point(9, 304)
        Me.ucrSaveColumn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        Me.ucrSaveColumn.Size = New System.Drawing.Size(292, 21)
        Me.ucrSaveColumn.TabIndex = 13
        '
        'ucrNudPieces
        '
        Me.ucrNudPieces.AutoSize = True
        Me.ucrNudPieces.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPieces.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPieces.Location = New System.Drawing.Point(257, 241)
        Me.ucrNudPieces.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPieces.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPieces.Name = "ucrNudPieces"
        Me.ucrNudPieces.Size = New System.Drawing.Size(44, 20)
        Me.ucrNudPieces.TabIndex = 12
        Me.ucrNudPieces.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputPattern
        '
        Me.ucrInputPattern.AddQuotesIfUnrecognised = True
        Me.ucrInputPattern.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPattern.GetSetSelectedIndex = -1
        Me.ucrInputPattern.IsReadOnly = False
        Me.ucrInputPattern.Location = New System.Drawing.Point(257, 124)
        Me.ucrInputPattern.Name = "ucrInputPattern"
        Me.ucrInputPattern.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPattern.TabIndex = 7
        '
        'ucrReceiverSplitTextColumn
        '
        Me.ucrReceiverSplitTextColumn.AutoSize = True
        Me.ucrReceiverSplitTextColumn.frmParent = Me
        Me.ucrReceiverSplitTextColumn.Location = New System.Drawing.Point(257, 78)
        Me.ucrReceiverSplitTextColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSplitTextColumn.Name = "ucrReceiverSplitTextColumn"
        Me.ucrReceiverSplitTextColumn.Selector = Nothing
        Me.ucrReceiverSplitTextColumn.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverSplitTextColumn.strNcFilePath = ""
        Me.ucrReceiverSplitTextColumn.TabIndex = 5
        Me.ucrReceiverSplitTextColumn.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 336)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 14
        '
        'ucrPnlTextComponents
        '
        Me.ucrPnlTextComponents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlTextComponents.Location = New System.Drawing.Point(236, 151)
        Me.ucrPnlTextComponents.Name = "ucrPnlTextComponents"
        Me.ucrPnlTextComponents.Size = New System.Drawing.Size(205, 63)
        Me.ucrPnlTextComponents.TabIndex = 8
        '
        'ucrChkAddKeyboard
        '
        Me.ucrChkAddKeyboard.AutoSize = True
        Me.ucrChkAddKeyboard.Checked = False
        Me.ucrChkAddKeyboard.Location = New System.Drawing.Point(249, 273)
        Me.ucrChkAddKeyboard.Name = "ucrChkAddKeyboard"
        Me.ucrChkAddKeyboard.Size = New System.Drawing.Size(158, 23)
        Me.ucrChkAddKeyboard.TabIndex = 23
        '
        'ucrChkIncludeRegularExpressions
        '
        Me.ucrChkIncludeRegularExpressions.AutoSize = True
        Me.ucrChkIncludeRegularExpressions.Checked = False
        Me.ucrChkIncludeRegularExpressions.Location = New System.Drawing.Point(9, 273)
        Me.ucrChkIncludeRegularExpressions.Name = "ucrChkIncludeRegularExpressions"
        Me.ucrChkIncludeRegularExpressions.Size = New System.Drawing.Size(239, 23)
        Me.ucrChkIncludeRegularExpressions.TabIndex = 22
        '
        'ucrSelectorSplitTextColumn
        '
        Me.ucrSelectorSplitTextColumn.AutoSize = True
        Me.ucrSelectorSplitTextColumn.bDropUnusedFilterLevels = False
        Me.ucrSelectorSplitTextColumn.bShowHiddenColumns = False
        Me.ucrSelectorSplitTextColumn.bUseCurrentFilter = True
        Me.ucrSelectorSplitTextColumn.Location = New System.Drawing.Point(10, 52)
        Me.ucrSelectorSplitTextColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSplitTextColumn.Name = "ucrSelectorSplitTextColumn"
        Me.ucrSelectorSplitTextColumn.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorSplitTextColumn.TabIndex = 24
        '
        'dlgSplitText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(453, 392)
        Me.Controls.Add(Me.ucrSelectorSplitTextColumn)
        Me.Controls.Add(Me.ucrChkAddKeyboard)
        Me.Controls.Add(Me.ucrChkIncludeRegularExpressions)
        Me.Controls.Add(Me.rdoFixedNumberOfComponents)
        Me.Controls.Add(Me.rdoMaximumNumberOfComponents)
        Me.Controls.Add(Me.rdoTextComponents)
        Me.Controls.Add(Me.rdoBinaryColumns)
        Me.Controls.Add(Me.ucrPnlSplitText)
        Me.Controls.Add(Me.ucrSaveColumn)
        Me.Controls.Add(Me.ucrNudPieces)
        Me.Controls.Add(Me.ucrInputPattern)
        Me.Controls.Add(Me.ucrReceiverSplitTextColumn)
        Me.Controls.Add(Me.lblNumberofPiecesToReturn)
        Me.Controls.Add(Me.lblSplitBy)
        Me.Controls.Add(Me.lblSelectedFactor)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlTextComponents)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSplitText"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Split_Text_Column"
        Me.Text = "Split Text Column"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblSelectedFactor As Label
    Friend WithEvents lblSplitBy As Label
    Friend WithEvents lblNumberofPiecesToReturn As Label
    Friend WithEvents ucrReceiverSplitTextColumn As ucrReceiverSingle
    Friend WithEvents ucrInputPattern As ucrInputComboBox
    Friend WithEvents ucrSaveColumn As ucrSave
    Friend WithEvents ucrNudPieces As ucrNud
    Friend WithEvents rdoTextComponents As RadioButton
    Friend WithEvents rdoBinaryColumns As RadioButton
    Friend WithEvents ucrPnlSplitText As UcrPanel
    Friend WithEvents rdoFixedNumberOfComponents As RadioButton
    Friend WithEvents rdoMaximumNumberOfComponents As RadioButton
    Friend WithEvents ucrPnlTextComponents As UcrPanel
    Friend WithEvents ucrChkAddKeyboard As ucrCheck
    Friend WithEvents ucrChkIncludeRegularExpressions As ucrCheck
    Friend WithEvents ucrSelectorSplitTextColumn As ucrSelectorByDataFrameAddRemove
End Class