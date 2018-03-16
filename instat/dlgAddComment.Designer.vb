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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgAddComment))
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
        resources.ApplyResources(Me.lblRow, "lblRow")
        Me.lblRow.Name = "lblRow"
        '
        'lblColumn
        '
        resources.ApplyResources(Me.lblColumn, "lblColumn")
        Me.lblColumn.Name = "lblColumn"
        '
        'lblComment
        '
        resources.ApplyResources(Me.lblComment, "lblComment")
        Me.lblComment.Name = "lblComment"
        '
        'rdoCell
        '
        resources.ApplyResources(Me.rdoCell, "rdoCell")
        Me.rdoCell.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCell.FlatAppearance.BorderSize = 2
        Me.rdoCell.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoCell.Name = "rdoCell"
        Me.rdoCell.UseVisualStyleBackColor = True
        '
        'rdoRow
        '
        resources.ApplyResources(Me.rdoRow, "rdoRow")
        Me.rdoRow.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRow.FlatAppearance.BorderSize = 2
        Me.rdoRow.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoRow.Name = "rdoRow"
        Me.rdoRow.UseVisualStyleBackColor = True
        '
        'UcrDialogDisabled1
        '
        Me.UcrDialogDisabled1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.UcrDialogDisabled1, "UcrDialogDisabled1")
        Me.UcrDialogDisabled1.Name = "UcrDialogDisabled1"
        '
        'ucrPnlCellOrRow
        '
        resources.ApplyResources(Me.ucrPnlCellOrRow, "ucrPnlCellOrRow")
        Me.ucrPnlCellOrRow.Name = "ucrPnlCellOrRow"
        '
        'ucrInputComment
        '
        Me.ucrInputComment.AddQuotesIfUnrecognised = True
        Me.ucrInputComment.IsMultiline = False
        Me.ucrInputComment.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComment, "ucrInputComment")
        Me.ucrInputComment.Name = "ucrInputComment"
        '
        'ucrReceiverColumn
        '
        Me.ucrReceiverColumn.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverColumn, "ucrReceiverColumn")
        Me.ucrReceiverColumn.Name = "ucrReceiverColumn"
        Me.ucrReceiverColumn.Selector = Nothing
        Me.ucrReceiverColumn.strNcFilePath = ""
        Me.ucrReceiverColumn.ucrSelector = Nothing
        '
        'ucrReceiverRow
        '
        Me.ucrReceiverRow.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverRow, "ucrReceiverRow")
        Me.ucrReceiverRow.Name = "ucrReceiverRow"
        Me.ucrReceiverRow.Selector = Nothing
        Me.ucrReceiverRow.strNcFilePath = ""
        Me.ucrReceiverRow.ucrSelector = Nothing
        '
        'ucrSelectorAddComment
        '
        Me.ucrSelectorAddComment.bShowHiddenColumns = False
        Me.ucrSelectorAddComment.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorAddComment, "ucrSelectorAddComment")
        Me.ucrSelectorAddComment.Name = "ucrSelectorAddComment"
        '
        'ucrDataFrame
        '
        Me.ucrDataFrame.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrDataFrame, "ucrDataFrame")
        Me.ucrDataFrame.Name = "ucrDataFrame"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgAddComment
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
