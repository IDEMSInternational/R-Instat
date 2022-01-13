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
Partial Class dlgAddComment
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
        Me.lblRow = New System.Windows.Forms.Label()
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.rdoCell = New System.Windows.Forms.RadioButton()
        Me.rdoRow = New System.Windows.Forms.RadioButton()
        Me.ucrPnlCellRowColumnDataFrame = New instat.UcrPanel()
        Me.ucrInputComment = New instat.ucrInputTextBox()
        Me.ucrReceiverColumn = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorAddComment = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputRow = New instat.ucrInputTextBox()
        Me.rdoDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoColumn = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblRow
        '
        Me.lblRow.AutoSize = True
        Me.lblRow.Location = New System.Drawing.Point(266, 72)
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(32, 13)
        Me.lblRow.TabIndex = 6
        Me.lblRow.Text = "Row:"
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.Location = New System.Drawing.Point(266, 114)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(45, 13)
        Me.lblColumn.TabIndex = 8
        Me.lblColumn.Text = "Column:"
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Location = New System.Drawing.Point(14, 242)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(54, 13)
        Me.lblComment.TabIndex = 10
        Me.lblComment.Text = "Comment:"
        '
        'rdoCell
        '
        Me.rdoCell.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCell.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCell.FlatAppearance.BorderSize = 2
        Me.rdoCell.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoCell.Location = New System.Drawing.Point(10, 3)
        Me.rdoCell.Name = "rdoCell"
        Me.rdoCell.Size = New System.Drawing.Size(100, 42)
        Me.rdoCell.TabIndex = 1
        Me.rdoCell.Text = "Cell"
        Me.rdoCell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCell.UseVisualStyleBackColor = True
        '
        'rdoRow
        '
        Me.rdoRow.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoRow.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRow.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRow.FlatAppearance.BorderSize = 2
        Me.rdoRow.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoRow.Location = New System.Drawing.Point(108, 3)
        Me.rdoRow.Name = "rdoRow"
        Me.rdoRow.Size = New System.Drawing.Size(100, 42)
        Me.rdoRow.TabIndex = 2
        Me.rdoRow.Text = "Row"
        Me.rdoRow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRow.UseVisualStyleBackColor = True
        '
        'ucrPnlCellRowColumnDataFrame
        '
        Me.ucrPnlCellRowColumnDataFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlCellRowColumnDataFrame.Location = New System.Drawing.Point(-4, 1)
        Me.ucrPnlCellRowColumnDataFrame.Name = "ucrPnlCellRowColumnDataFrame"
        Me.ucrPnlCellRowColumnDataFrame.Size = New System.Drawing.Size(422, 44)
        Me.ucrPnlCellRowColumnDataFrame.TabIndex = 0
        '
        'ucrInputComment
        '
        Me.ucrInputComment.AddQuotesIfUnrecognised = True
        Me.ucrInputComment.AutoSize = True
        Me.ucrInputComment.IsMultiline = False
        Me.ucrInputComment.IsReadOnly = False
        Me.ucrInputComment.Location = New System.Drawing.Point(83, 239)
        Me.ucrInputComment.Name = "ucrInputComment"
        Me.ucrInputComment.Size = New System.Drawing.Size(325, 47)
        Me.ucrInputComment.TabIndex = 11
        '
        'ucrReceiverColumn
        '
        Me.ucrReceiverColumn.AutoSize = True
        Me.ucrReceiverColumn.frmParent = Me
        Me.ucrReceiverColumn.Location = New System.Drawing.Point(266, 129)
        Me.ucrReceiverColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumn.Name = "ucrReceiverColumn"
        Me.ucrReceiverColumn.Selector = Nothing
        Me.ucrReceiverColumn.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverColumn.strNcFilePath = ""
        Me.ucrReceiverColumn.TabIndex = 9
        Me.ucrReceiverColumn.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 293)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 12
        '
        'ucrSelectorAddComment
        '
        Me.ucrSelectorAddComment.AutoSize = True
        Me.ucrSelectorAddComment.bDropUnusedFilterLevels = False
        Me.ucrSelectorAddComment.bShowHiddenColumns = False
        Me.ucrSelectorAddComment.bUseCurrentFilter = True
        Me.ucrSelectorAddComment.Location = New System.Drawing.Point(10, 48)
        Me.ucrSelectorAddComment.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorAddComment.Name = "ucrSelectorAddComment"
        Me.ucrSelectorAddComment.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorAddComment.TabIndex = 5
        '
        'ucrInputRow
        '
        Me.ucrInputRow.AddQuotesIfUnrecognised = True
        Me.ucrInputRow.AutoSize = True
        Me.ucrInputRow.IsMultiline = False
        Me.ucrInputRow.IsReadOnly = False
        Me.ucrInputRow.Location = New System.Drawing.Point(302, 68)
        Me.ucrInputRow.Name = "ucrInputRow"
        Me.ucrInputRow.Size = New System.Drawing.Size(80, 21)
        Me.ucrInputRow.TabIndex = 7
        '
        'rdoDataFrame
        '
        Me.rdoDataFrame.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDataFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoDataFrame.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDataFrame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataFrame.FlatAppearance.BorderSize = 2
        Me.rdoDataFrame.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDataFrame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDataFrame.Location = New System.Drawing.Point(304, 3)
        Me.rdoDataFrame.Name = "rdoDataFrame"
        Me.rdoDataFrame.Size = New System.Drawing.Size(100, 42)
        Me.rdoDataFrame.TabIndex = 4
        Me.rdoDataFrame.Text = "Data Frame"
        Me.rdoDataFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDataFrame.UseVisualStyleBackColor = True
        '
        'rdoColumn
        '
        Me.rdoColumn.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoColumn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoColumn.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColumn.FlatAppearance.BorderSize = 2
        Me.rdoColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoColumn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoColumn.Location = New System.Drawing.Point(206, 3)
        Me.rdoColumn.Name = "rdoColumn"
        Me.rdoColumn.Size = New System.Drawing.Size(100, 42)
        Me.rdoColumn.TabIndex = 3
        Me.rdoColumn.Text = "Column"
        Me.rdoColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColumn.UseVisualStyleBackColor = True
        '
        'dlgAddComment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(418, 346)
        Me.Controls.Add(Me.rdoColumn)
        Me.Controls.Add(Me.rdoDataFrame)
        Me.Controls.Add(Me.ucrInputRow)
        Me.Controls.Add(Me.ucrSelectorAddComment)
        Me.Controls.Add(Me.rdoCell)
        Me.Controls.Add(Me.rdoRow)
        Me.Controls.Add(Me.ucrPnlCellRowColumnDataFrame)
        Me.Controls.Add(Me.ucrInputComment)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.lblColumn)
        Me.Controls.Add(Me.ucrReceiverColumn)
        Me.Controls.Add(Me.lblRow)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAddComment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Comment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblRow As Label
    Friend WithEvents lblColumn As Label
    Friend WithEvents ucrReceiverColumn As ucrReceiverSingle
    Friend WithEvents lblComment As Label
    Friend WithEvents ucrInputComment As ucrInputTextBox
    Friend WithEvents rdoCell As RadioButton
    Friend WithEvents rdoRow As RadioButton
    Friend WithEvents ucrPnlCellRowColumnDataFrame As UcrPanel
    Friend WithEvents ucrInputRow As ucrInputTextBox
    Friend WithEvents ucrSelectorAddComment As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoColumn As RadioButton
    Friend WithEvents rdoDataFrame As RadioButton
End Class
