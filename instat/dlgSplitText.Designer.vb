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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgSplitText))
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
        resources.ApplyResources(Me.lblSelectedFactor, "lblSelectedFactor")
        Me.lblSelectedFactor.Name = "lblSelectedFactor"
        Me.lblSelectedFactor.Tag = "Selected_Factor"
        '
        'lblSplitBy
        '
        resources.ApplyResources(Me.lblSplitBy, "lblSplitBy")
        Me.lblSplitBy.Name = "lblSplitBy"
        Me.lblSplitBy.Tag = ""
        '
        'lblNumberofPiecesToReturn
        '
        resources.ApplyResources(Me.lblNumberofPiecesToReturn, "lblNumberofPiecesToReturn")
        Me.lblNumberofPiecesToReturn.Name = "lblNumberofPiecesToReturn"
        Me.lblNumberofPiecesToReturn.Tag = "Number_of_Pieces_to_Return"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'rdoTextComponents
        '
        resources.ApplyResources(Me.rdoTextComponents, "rdoTextComponents")
        Me.rdoTextComponents.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTextComponents.FlatAppearance.BorderSize = 2
        Me.rdoTextComponents.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTextComponents.Name = "rdoTextComponents"
        Me.rdoTextComponents.TabStop = True
        Me.rdoTextComponents.UseVisualStyleBackColor = True
        '
        'rdoBinaryColumns
        '
        resources.ApplyResources(Me.rdoBinaryColumns, "rdoBinaryColumns")
        Me.rdoBinaryColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBinaryColumns.FlatAppearance.BorderSize = 2
        Me.rdoBinaryColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBinaryColumns.Name = "rdoBinaryColumns"
        Me.rdoBinaryColumns.TabStop = True
        Me.rdoBinaryColumns.UseVisualStyleBackColor = True
        '
        'ucrPnlSplitText
        '
        resources.ApplyResources(Me.ucrPnlSplitText, "ucrPnlSplitText")
        Me.ucrPnlSplitText.Name = "ucrPnlSplitText"
        '
        'ucrSaveColumn
        '
        resources.ApplyResources(Me.ucrSaveColumn, "ucrSaveColumn")
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        '
        'ucrNudPieces
        '
        Me.ucrNudPieces.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPieces.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudPieces, "ucrNudPieces")
        Me.ucrNudPieces.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPieces.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPieces.Name = "ucrNudPieces"
        Me.ucrNudPieces.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputPattern
        '
        Me.ucrInputPattern.AddQuotesIfUnrecognised = True
        Me.ucrInputPattern.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPattern, "ucrInputPattern")
        Me.ucrInputPattern.Name = "ucrInputPattern"
        '
        'ucrReceiverSplitTextColumn
        '
        Me.ucrReceiverSplitTextColumn.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSplitTextColumn, "ucrReceiverSplitTextColumn")
        Me.ucrReceiverSplitTextColumn.Name = "ucrReceiverSplitTextColumn"
        Me.ucrReceiverSplitTextColumn.Selector = Nothing
        Me.ucrReceiverSplitTextColumn.strNcFilePath = ""
        Me.ucrReceiverSplitTextColumn.ucrSelector = Nothing
        '
        'ucrSelectorSplitTextColumn
        '
        Me.ucrSelectorSplitTextColumn.bShowHiddenColumns = False
        Me.ucrSelectorSplitTextColumn.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorSplitTextColumn, "ucrSelectorSplitTextColumn")
        Me.ucrSelectorSplitTextColumn.Name = "ucrSelectorSplitTextColumn"
        '
        'dlgSplitText
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Tag = "Split_Text_Column"
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