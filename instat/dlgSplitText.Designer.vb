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
        Me.ucrBase = New instat.ucrButtons()
        Me.rdoTextComponents = New System.Windows.Forms.RadioButton()
        Me.rdoBinaryColumns = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSplitText = New instat.UcrPanel()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.ucrNudPieces = New instat.ucrNud()
        Me.ucrInputPattern = New instat.ucrInputComboBox()
        Me.ucrReceiverSplitTextColumn = New instat.ucrReceiverSingle()
        Me.ucrSelectorSplitTextColumn = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblSelectedFactor
        '
        Me.lblSelectedFactor.AutoSize = True
        Me.lblSelectedFactor.Location = New System.Drawing.Point(252, 77)
        Me.lblSelectedFactor.Name = "lblSelectedFactor"
        Me.lblSelectedFactor.Size = New System.Drawing.Size(80, 13)
        Me.lblSelectedFactor.TabIndex = 4
        Me.lblSelectedFactor.Tag = "Selected_Factor"
        Me.lblSelectedFactor.Text = "Column to Split:"
        '
        'lblSplitBy
        '
        Me.lblSplitBy.AutoSize = True
        Me.lblSplitBy.Location = New System.Drawing.Point(252, 120)
        Me.lblSplitBy.Name = "lblSplitBy"
        Me.lblSplitBy.Size = New System.Drawing.Size(44, 13)
        Me.lblSplitBy.TabIndex = 6
        Me.lblSplitBy.Tag = ""
        Me.lblSplitBy.Text = "Split by:"
        '
        'lblNumberofPiecesToReturn
        '
        Me.lblNumberofPiecesToReturn.AutoSize = True
        Me.lblNumberofPiecesToReturn.Location = New System.Drawing.Point(252, 170)
        Me.lblNumberofPiecesToReturn.Name = "lblNumberofPiecesToReturn"
        Me.lblNumberofPiecesToReturn.Size = New System.Drawing.Size(141, 13)
        Me.lblNumberofPiecesToReturn.TabIndex = 8
        Me.lblNumberofPiecesToReturn.Tag = "Number_of_Pieces_to_Return"
        Me.lblNumberofPiecesToReturn.Text = "Number of Pieces to Return:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 259)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 11
        '
        'rdoTextComponents
        '
        Me.rdoTextComponents.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTextComponents.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTextComponents.FlatAppearance.BorderSize = 2
        Me.rdoTextComponents.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTextComponents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTextComponents.Location = New System.Drawing.Point(91, 12)
        Me.rdoTextComponents.Name = "rdoTextComponents"
        Me.rdoTextComponents.Size = New System.Drawing.Size(125, 27)
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
        Me.rdoBinaryColumns.Location = New System.Drawing.Point(214, 12)
        Me.rdoBinaryColumns.Name = "rdoBinaryColumns"
        Me.rdoBinaryColumns.Size = New System.Drawing.Size(125, 27)
        Me.rdoBinaryColumns.TabIndex = 2
        Me.rdoBinaryColumns.TabStop = True
        Me.rdoBinaryColumns.Text = "Into Binary Columns"
        Me.rdoBinaryColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBinaryColumns.UseVisualStyleBackColor = True
        '
        'ucrPnlSplitText
        '
        Me.ucrPnlSplitText.Location = New System.Drawing.Point(47, 8)
        Me.ucrPnlSplitText.Name = "ucrPnlSplitText"
        Me.ucrPnlSplitText.Size = New System.Drawing.Size(309, 36)
        Me.ucrPnlSplitText.TabIndex = 0
        '
        'ucrSaveColumn
        '
        Me.ucrSaveColumn.Location = New System.Drawing.Point(10, 232)
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        Me.ucrSaveColumn.Size = New System.Drawing.Size(305, 24)
        Me.ucrSaveColumn.TabIndex = 10
        '
        'ucrNudPieces
        '
        Me.ucrNudPieces.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPieces.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPieces.Location = New System.Drawing.Point(252, 186)
        Me.ucrNudPieces.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPieces.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPieces.Name = "ucrNudPieces"
        Me.ucrNudPieces.Size = New System.Drawing.Size(44, 20)
        Me.ucrNudPieces.TabIndex = 9
        Me.ucrNudPieces.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputPattern
        '
        Me.ucrInputPattern.AddQuotesIfUnrecognised = True
        Me.ucrInputPattern.IsReadOnly = False
        Me.ucrInputPattern.Location = New System.Drawing.Point(252, 135)
        Me.ucrInputPattern.Name = "ucrInputPattern"
        Me.ucrInputPattern.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPattern.TabIndex = 7
        '
        'ucrReceiverSplitTextColumn
        '
        Me.ucrReceiverSplitTextColumn.frmParent = Me
        Me.ucrReceiverSplitTextColumn.Location = New System.Drawing.Point(252, 92)
        Me.ucrReceiverSplitTextColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSplitTextColumn.Name = "ucrReceiverSplitTextColumn"
        Me.ucrReceiverSplitTextColumn.Selector = Nothing
        Me.ucrReceiverSplitTextColumn.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverSplitTextColumn.strNcFilePath = ""
        Me.ucrReceiverSplitTextColumn.TabIndex = 5
        Me.ucrReceiverSplitTextColumn.ucrSelector = Nothing
        '
        'ucrSelectorSplitTextColumn
        '
        Me.ucrSelectorSplitTextColumn.bShowHiddenColumns = False
        Me.ucrSelectorSplitTextColumn.bUseCurrentFilter = True
        Me.ucrSelectorSplitTextColumn.Location = New System.Drawing.Point(10, 42)
        Me.ucrSelectorSplitTextColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSplitTextColumn.Name = "ucrSelectorSplitTextColumn"
        Me.ucrSelectorSplitTextColumn.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorSplitTextColumn.TabIndex = 3
        '
        'dlgSplitText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 316)
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
        Me.Controls.Add(Me.ucrSelectorSplitTextColumn)
        Me.Controls.Add(Me.ucrBase)
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
    Friend WithEvents ucrSelectorSplitTextColumn As ucrSelectorByDataFrameAddRemove
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
End Class