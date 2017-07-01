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
        Me.lblRow = New System.Windows.Forms.Label()
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.rdoCell = New System.Windows.Forms.RadioButton()
        Me.rdoRow = New System.Windows.Forms.RadioButton()
        Me.UcrDialogDisabled1 = New instat.ucrDialogDisabled()
        Me.ucrPnlCellOrRow = New instat.UcrPanel()
        Me.ucrInputComment = New instat.ucrInputTextBox()
        Me.ucrReceiverColumn = New instat.ucrReceiverSingle()
        Me.ucrReceiverRow = New instat.ucrReceiverSingle()
        Me.ucrSelectorAddComment = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrDataFrame = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblRow
        '
        Me.lblRow.AutoSize = True
        Me.lblRow.Location = New System.Drawing.Point(266, 90)
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(32, 13)
        Me.lblRow.TabIndex = 4
        Me.lblRow.Text = "Row:"
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.Location = New System.Drawing.Point(266, 139)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(45, 13)
        Me.lblColumn.TabIndex = 6
        Me.lblColumn.Text = "Column:"
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Location = New System.Drawing.Point(12, 253)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(54, 13)
        Me.lblComment.TabIndex = 8
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
        Me.rdoCell.Location = New System.Drawing.Point(115, 12)
        Me.rdoCell.Name = "rdoCell"
        Me.rdoCell.Size = New System.Drawing.Size(100, 28)
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
        Me.rdoRow.Location = New System.Drawing.Point(213, 12)
        Me.rdoRow.Name = "rdoRow"
        Me.rdoRow.Size = New System.Drawing.Size(100, 28)
        Me.rdoRow.TabIndex = 2
        Me.rdoRow.Text = "Row"
        Me.rdoRow.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdoRow.UseVisualStyleBackColor = True
        '
        'UcrDialogDisabled1
        '
        Me.UcrDialogDisabled1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcrDialogDisabled1.Location = New System.Drawing.Point(66, 147)
        Me.UcrDialogDisabled1.Name = "UcrDialogDisabled1"
        Me.UcrDialogDisabled1.Size = New System.Drawing.Size(295, 96)
        Me.UcrDialogDisabled1.TabIndex = 20
        '
        'ucrPnlCellOrRow
        '
        Me.ucrPnlCellOrRow.Location = New System.Drawing.Point(108, 12)
        Me.ucrPnlCellOrRow.Name = "ucrPnlCellOrRow"
        Me.ucrPnlCellOrRow.Size = New System.Drawing.Size(219, 29)
        Me.ucrPnlCellOrRow.TabIndex = 0
        '
        'ucrInputComment
        '
        Me.ucrInputComment.AddQuotesIfUnrecognised = True
        Me.ucrInputComment.IsMultiline = False
        Me.ucrInputComment.IsReadOnly = False
        Me.ucrInputComment.Location = New System.Drawing.Point(92, 249)
        Me.ucrInputComment.Name = "ucrInputComment"
        Me.ucrInputComment.Size = New System.Drawing.Size(316, 21)
        Me.ucrInputComment.TabIndex = 9
        '
        'ucrReceiverColumn
        '
        Me.ucrReceiverColumn.frmParent = Me
        Me.ucrReceiverColumn.Location = New System.Drawing.Point(266, 154)
        Me.ucrReceiverColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumn.Name = "ucrReceiverColumn"
        Me.ucrReceiverColumn.Selector = Nothing
        Me.ucrReceiverColumn.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverColumn.strNcFilePath = ""
        Me.ucrReceiverColumn.TabIndex = 7
        Me.ucrReceiverColumn.ucrSelector = Nothing
        '
        'ucrReceiverRow
        '
        Me.ucrReceiverRow.frmParent = Me
        Me.ucrReceiverRow.Location = New System.Drawing.Point(266, 105)
        Me.ucrReceiverRow.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRow.Name = "ucrReceiverRow"
        Me.ucrReceiverRow.Selector = Nothing
        Me.ucrReceiverRow.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverRow.strNcFilePath = ""
        Me.ucrReceiverRow.TabIndex = 5
        Me.ucrReceiverRow.ucrSelector = Nothing
        '
        'ucrSelectorAddComment
        '
        Me.ucrSelectorAddComment.bShowHiddenColumns = False
        Me.ucrSelectorAddComment.bUseCurrentFilter = True
        Me.ucrSelectorAddComment.Location = New System.Drawing.Point(10, 55)
        Me.ucrSelectorAddComment.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorAddComment.Name = "ucrSelectorAddComment"
        Me.ucrSelectorAddComment.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorAddComment.TabIndex = 3
        '
        'ucrDataFrame
        '
        Me.ucrDataFrame.bUseCurrentFilter = True
        Me.ucrDataFrame.Location = New System.Drawing.Point(10, 55)
        Me.ucrDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrame.Name = "ucrDataFrame"
        Me.ucrDataFrame.Size = New System.Drawing.Size(120, 50)
        Me.ucrDataFrame.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 276)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 10
        '
        'dlgAddComment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 330)
        Me.Controls.Add(Me.UcrDialogDisabled1)
        Me.Controls.Add(Me.rdoCell)
        Me.Controls.Add(Me.rdoRow)
        Me.Controls.Add(Me.ucrPnlCellOrRow)
        Me.Controls.Add(Me.ucrInputComment)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.lblColumn)
        Me.Controls.Add(Me.ucrReceiverColumn)
        Me.Controls.Add(Me.lblRow)
        Me.Controls.Add(Me.ucrReceiverRow)
        Me.Controls.Add(Me.ucrSelectorAddComment)
        Me.Controls.Add(Me.ucrDataFrame)
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
    Friend WithEvents ucrDataFrame As ucrDataFrame
    Friend WithEvents ucrSelectorAddComment As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRow As ucrReceiverSingle
    Friend WithEvents lblRow As Label
    Friend WithEvents lblColumn As Label
    Friend WithEvents ucrReceiverColumn As ucrReceiverSingle
    Friend WithEvents lblComment As Label
    Friend WithEvents ucrInputComment As ucrInputTextBox
    Friend WithEvents rdoCell As RadioButton
    Friend WithEvents rdoRow As RadioButton
    Friend WithEvents ucrPnlCellOrRow As UcrPanel
    Friend WithEvents UcrDialogDisabled1 As ucrDialogDisabled
End Class
