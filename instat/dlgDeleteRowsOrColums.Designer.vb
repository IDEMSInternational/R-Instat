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
Partial Class dlgDeleteRowsOrColums
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDeleteRowsOrColums))
        Me.lblNumberofRows = New System.Windows.Forms.Label()
        Me.lblColumnsToDelete = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.rdoColumns = New System.Windows.Forms.RadioButton()
        Me.rdoRows = New System.Windows.Forms.RadioButton()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrPnlColumnsOrRows = New instat.UcrPanel()
        Me.ucrDataFrameLengthForDeleteRows = New instat.ucrDataFrameLength()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.ucrSelectorForDeleteColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverForColumnsToDelete = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblNumberofRows
        '
        resources.ApplyResources(Me.lblNumberofRows, "lblNumberofRows")
        Me.lblNumberofRows.Name = "lblNumberofRows"
        Me.lblNumberofRows.Tag = "Number_of_Rows:"
        '
        'lblColumnsToDelete
        '
        resources.ApplyResources(Me.lblColumnsToDelete, "lblColumnsToDelete")
        Me.lblColumnsToDelete.Name = "lblColumnsToDelete"
        Me.lblColumnsToDelete.Tag = "Columns_to_Delete"
        '
        'lblFrom
        '
        resources.ApplyResources(Me.lblFrom, "lblFrom")
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Tag = ""
        '
        'rdoColumns
        '
        resources.ApplyResources(Me.rdoColumns, "rdoColumns")
        Me.rdoColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColumns.FlatAppearance.BorderSize = 2
        Me.rdoColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColumns.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoColumns.Name = "rdoColumns"
        Me.rdoColumns.UseVisualStyleBackColor = True
        '
        'rdoRows
        '
        resources.ApplyResources(Me.rdoRows, "rdoRows")
        Me.rdoRows.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRows.FlatAppearance.BorderSize = 2
        Me.rdoRows.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRows.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoRows.Name = "rdoRows"
        Me.rdoRows.UseVisualStyleBackColor = True
        '
        'lblTo
        '
        resources.ApplyResources(Me.lblTo, "lblTo")
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Tag = ""
        '
        'ucrNudTo
        '
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudTo, "ucrNudTo")
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlColumnsOrRows
        '
        resources.ApplyResources(Me.ucrPnlColumnsOrRows, "ucrPnlColumnsOrRows")
        Me.ucrPnlColumnsOrRows.Name = "ucrPnlColumnsOrRows"
        '
        'ucrDataFrameLengthForDeleteRows
        '
        resources.ApplyResources(Me.ucrDataFrameLengthForDeleteRows, "ucrDataFrameLengthForDeleteRows")
        Me.ucrDataFrameLengthForDeleteRows.Name = "ucrDataFrameLengthForDeleteRows"
        Me.ucrDataFrameLengthForDeleteRows.ucrDataFrameSelector = Nothing
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudFrom, "ucrNudFrom")
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSelectorForDeleteColumns
        '
        Me.ucrSelectorForDeleteColumns.bShowHiddenColumns = False
        Me.ucrSelectorForDeleteColumns.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForDeleteColumns, "ucrSelectorForDeleteColumns")
        Me.ucrSelectorForDeleteColumns.Name = "ucrSelectorForDeleteColumns"
        '
        'ucrReceiverForColumnsToDelete
        '
        Me.ucrReceiverForColumnsToDelete.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverForColumnsToDelete, "ucrReceiverForColumnsToDelete")
        Me.ucrReceiverForColumnsToDelete.Name = "ucrReceiverForColumnsToDelete"
        Me.ucrReceiverForColumnsToDelete.Selector = Nothing
        Me.ucrReceiverForColumnsToDelete.strNcFilePath = ""
        Me.ucrReceiverForColumnsToDelete.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgDeleteRowsOrColums
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.ucrNudTo)
        Me.Controls.Add(Me.rdoColumns)
        Me.Controls.Add(Me.rdoRows)
        Me.Controls.Add(Me.ucrPnlColumnsOrRows)
        Me.Controls.Add(Me.ucrDataFrameLengthForDeleteRows)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lblNumberofRows)
        Me.Controls.Add(Me.ucrNudFrom)
        Me.Controls.Add(Me.ucrSelectorForDeleteColumns)
        Me.Controls.Add(Me.lblColumnsToDelete)
        Me.Controls.Add(Me.ucrReceiverForColumnsToDelete)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDeleteRowsOrColums"
        Me.Tag = "Delete_Rows_Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblNumberofRows As Label
    Friend WithEvents ucrDataFrameLengthForDeleteRows As ucrDataFrameLength
    Friend WithEvents ucrSelectorForDeleteColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverForColumnsToDelete As ucrReceiverMultiple
    Friend WithEvents lblColumnsToDelete As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents ucrNudFrom As ucrNud
    Friend WithEvents rdoColumns As RadioButton
    Friend WithEvents rdoRows As RadioButton
    Friend WithEvents ucrPnlColumnsOrRows As UcrPanel
    Friend WithEvents lblTo As Label
    Friend WithEvents ucrNudTo As ucrNud
End Class
