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
        Me.lblNumberofRows = New System.Windows.Forms.Label()
        Me.lblColumnsToDelete = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.rdoColumns = New System.Windows.Forms.RadioButton()
        Me.rdoRows = New System.Windows.Forms.RadioButton()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.rdoEmpty = New System.Windows.Forms.RadioButton()
        Me.ucrChkEmptyRows = New instat.ucrCheck()
        Me.ucrChkEmptyColumns = New instat.ucrCheck()
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
        Me.lblNumberofRows.AutoSize = True
        Me.lblNumberofRows.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumberofRows.Location = New System.Drawing.Point(10, 162)
        Me.lblNumberofRows.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumberofRows.Name = "lblNumberofRows"
        Me.lblNumberofRows.Size = New System.Drawing.Size(131, 20)
        Me.lblNumberofRows.TabIndex = 6
        Me.lblNumberofRows.Tag = "Number_of_Rows:"
        Me.lblNumberofRows.Text = "Number of Rows:"
        '
        'lblColumnsToDelete
        '
        Me.lblColumnsToDelete.AutoSize = True
        Me.lblColumnsToDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumnsToDelete.Location = New System.Drawing.Point(381, 134)
        Me.lblColumnsToDelete.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColumnsToDelete.Name = "lblColumnsToDelete"
        Me.lblColumnsToDelete.Size = New System.Drawing.Size(144, 20)
        Me.lblColumnsToDelete.TabIndex = 5
        Me.lblColumnsToDelete.Tag = "Columns_to_Delete"
        Me.lblColumnsToDelete.Text = "Columns to Delete:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFrom.Location = New System.Drawing.Point(10, 214)
        Me.lblFrom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(101, 20)
        Me.lblFrom.TabIndex = 8
        Me.lblFrom.Tag = ""
        Me.lblFrom.Text = "Delete From:"
        '
        'rdoColumns
        '
        Me.rdoColumns.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColumns.FlatAppearance.BorderSize = 2
        Me.rdoColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoColumns.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoColumns.Location = New System.Drawing.Point(87, 18)
        Me.rdoColumns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoColumns.Name = "rdoColumns"
        Me.rdoColumns.Size = New System.Drawing.Size(150, 42)
        Me.rdoColumns.TabIndex = 1
        Me.rdoColumns.Text = "Columns"
        Me.rdoColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColumns.UseVisualStyleBackColor = True
        '
        'rdoRows
        '
        Me.rdoRows.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoRows.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRows.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRows.FlatAppearance.BorderSize = 2
        Me.rdoRows.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRows.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoRows.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRows.Location = New System.Drawing.Point(237, 18)
        Me.rdoRows.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoRows.Name = "rdoRows"
        Me.rdoRows.Size = New System.Drawing.Size(150, 42)
        Me.rdoRows.TabIndex = 2
        Me.rdoRows.Text = "Rows"
        Me.rdoRows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRows.UseVisualStyleBackColor = True
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTo.Location = New System.Drawing.Point(76, 254)
        Me.lblTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(31, 20)
        Me.lblTo.TabIndex = 12
        Me.lblTo.Tag = ""
        Me.lblTo.Text = "To:"
        '
        'rdoEmpty
        '
        Me.rdoEmpty.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoEmpty.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEmpty.FlatAppearance.BorderSize = 2
        Me.rdoEmpty.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoEmpty.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoEmpty.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoEmpty.Location = New System.Drawing.Point(387, 18)
        Me.rdoEmpty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoEmpty.Name = "rdoEmpty"
        Me.rdoEmpty.Size = New System.Drawing.Size(150, 42)
        Me.rdoEmpty.TabIndex = 3
        Me.rdoEmpty.Text = "Empty"
        Me.rdoEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoEmpty.UseVisualStyleBackColor = True
        '
        'ucrChkEmptyRows
        '
        Me.ucrChkEmptyRows.AutoSize = True
        Me.ucrChkEmptyRows.Checked = False
        Me.ucrChkEmptyRows.Location = New System.Drawing.Point(16, 212)
        Me.ucrChkEmptyRows.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkEmptyRows.Name = "ucrChkEmptyRows"
        Me.ucrChkEmptyRows.Size = New System.Drawing.Size(164, 34)
        Me.ucrChkEmptyRows.TabIndex = 10
        '
        'ucrChkEmptyColumns
        '
        Me.ucrChkEmptyColumns.AutoSize = True
        Me.ucrChkEmptyColumns.Checked = False
        Me.ucrChkEmptyColumns.Location = New System.Drawing.Point(16, 159)
        Me.ucrChkEmptyColumns.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkEmptyColumns.Name = "ucrChkEmptyColumns"
        Me.ucrChkEmptyColumns.Size = New System.Drawing.Size(162, 34)
        Me.ucrChkEmptyColumns.TabIndex = 7
        '
        'ucrNudTo
        '
        Me.ucrNudTo.AutoSize = True
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Location = New System.Drawing.Point(120, 248)
        Me.ucrNudTo.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(123, 30)
        Me.ucrNudTo.TabIndex = 13
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlColumnsOrRows
        '
        Me.ucrPnlColumnsOrRows.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlColumnsOrRows.Location = New System.Drawing.Point(80, 16)
        Me.ucrPnlColumnsOrRows.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrPnlColumnsOrRows.Name = "ucrPnlColumnsOrRows"
        Me.ucrPnlColumnsOrRows.Size = New System.Drawing.Size(482, 44)
        Me.ucrPnlColumnsOrRows.TabIndex = 0
        '
        'ucrDataFrameLengthForDeleteRows
        '
        Me.ucrDataFrameLengthForDeleteRows.AddQuotesIfUnrecognised = True
        Me.ucrDataFrameLengthForDeleteRows.AutoSize = True
        Me.ucrDataFrameLengthForDeleteRows.IsMultiline = False
        Me.ucrDataFrameLengthForDeleteRows.IsReadOnly = True
        Me.ucrDataFrameLengthForDeleteRows.Location = New System.Drawing.Point(150, 156)
        Me.ucrDataFrameLengthForDeleteRows.Margin = New System.Windows.Forms.Padding(21, 21, 21, 21)
        Me.ucrDataFrameLengthForDeleteRows.Name = "ucrDataFrameLengthForDeleteRows"
        Me.ucrDataFrameLengthForDeleteRows.Size = New System.Drawing.Size(93, 36)
        Me.ucrDataFrameLengthForDeleteRows.TabIndex = 8
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.AutoSize = True
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Location = New System.Drawing.Point(120, 208)
        Me.ucrNudFrom.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(123, 30)
        Me.ucrNudFrom.TabIndex = 11
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSelectorForDeleteColumns
        '
        Me.ucrSelectorForDeleteColumns.AutoSize = True
        Me.ucrSelectorForDeleteColumns.bDropUnusedFilterLevels = False
        Me.ucrSelectorForDeleteColumns.bShowHiddenColumns = False
        Me.ucrSelectorForDeleteColumns.bUseCurrentFilter = True
        Me.ucrSelectorForDeleteColumns.Location = New System.Drawing.Point(14, 64)
        Me.ucrSelectorForDeleteColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDeleteColumns.Name = "ucrSelectorForDeleteColumns"
        Me.ucrSelectorForDeleteColumns.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorForDeleteColumns.TabIndex = 4
        '
        'ucrReceiverForColumnsToDelete
        '
        Me.ucrReceiverForColumnsToDelete.AutoSize = True
        Me.ucrReceiverForColumnsToDelete.frmParent = Me
        Me.ucrReceiverForColumnsToDelete.Location = New System.Drawing.Point(381, 156)
        Me.ucrReceiverForColumnsToDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForColumnsToDelete.Name = "ucrReceiverForColumnsToDelete"
        Me.ucrReceiverForColumnsToDelete.Selector = Nothing
        Me.ucrReceiverForColumnsToDelete.Size = New System.Drawing.Size(180, 150)
        Me.ucrReceiverForColumnsToDelete.strNcFilePath = ""
        Me.ucrReceiverForColumnsToDelete.TabIndex = 6
        Me.ucrReceiverForColumnsToDelete.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(8, 357)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 14
        '
        'dlgDeleteRowsOrColums
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.ucrChkEmptyRows)
        Me.Controls.Add(Me.ucrChkEmptyColumns)
        Me.Controls.Add(Me.rdoEmpty)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDeleteRowsOrColums"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Delete_Rows_Columns"
        Me.Text = "Delete Columns or Rows"
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
    Friend WithEvents rdoEmpty As RadioButton
    Friend WithEvents ucrChkEmptyRows As ucrCheck
    Friend WithEvents ucrChkEmptyColumns As ucrCheck
End Class
