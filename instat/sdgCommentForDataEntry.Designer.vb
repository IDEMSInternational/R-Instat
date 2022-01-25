<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgCommentForDataEntry
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
        Me.components = New System.ComponentModel.Container()
        Me.rdoColumn = New System.Windows.Forms.RadioButton()
        Me.rdoDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoCell = New System.Windows.Forms.RadioButton()
        Me.rdoRow = New System.Windows.Forms.RadioButton()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.lblRow = New System.Windows.Forms.Label()
        Me.ucrInputRow = New instat.ucrInputTextBox()
        Me.ucrPnlCellRowColumnDataFrame = New instat.UcrPanel()
        Me.ucrInputComment = New instat.ucrInputTextBox()
        Me.ucrReceiverColumn = New instat.ucrReceiverSingle()
        Me.ucrSdgBaseButtons = New instat.ucrButtonsSubdialogue()
        Me.cmdAddComment = New System.Windows.Forms.Button()
        Me.ttcmdAddComment = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrSelectorAddComment = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
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
        Me.rdoColumn.Location = New System.Drawing.Point(205, 8)
        Me.rdoColumn.Name = "rdoColumn"
        Me.rdoColumn.Size = New System.Drawing.Size(100, 28)
        Me.rdoColumn.TabIndex = 92
        Me.rdoColumn.Text = "Column"
        Me.rdoColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColumn.UseVisualStyleBackColor = True
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
        Me.rdoDataFrame.Location = New System.Drawing.Point(303, 8)
        Me.rdoDataFrame.Name = "rdoDataFrame"
        Me.rdoDataFrame.Size = New System.Drawing.Size(100, 28)
        Me.rdoDataFrame.TabIndex = 93
        Me.rdoDataFrame.Text = "Data Frame"
        Me.rdoDataFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDataFrame.UseVisualStyleBackColor = True
        '
        'rdoCell
        '
        Me.rdoCell.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCell.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCell.FlatAppearance.BorderSize = 2
        Me.rdoCell.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoCell.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCell.Location = New System.Drawing.Point(9, 8)
        Me.rdoCell.Name = "rdoCell"
        Me.rdoCell.Size = New System.Drawing.Size(100, 28)
        Me.rdoCell.TabIndex = 90
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
        Me.rdoRow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRow.Location = New System.Drawing.Point(107, 8)
        Me.rdoRow.Name = "rdoRow"
        Me.rdoRow.Size = New System.Drawing.Size(100, 28)
        Me.rdoRow.TabIndex = 91
        Me.rdoRow.Text = "Row"
        Me.rdoRow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRow.UseVisualStyleBackColor = True
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblComment.Location = New System.Drawing.Point(13, 238)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(54, 13)
        Me.lblComment.TabIndex = 99
        Me.lblComment.Text = "Comment:"
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumn.Location = New System.Drawing.Point(265, 110)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(45, 13)
        Me.lblColumn.TabIndex = 97
        Me.lblColumn.Text = "Column:"
        '
        'lblRow
        '
        Me.lblRow.AutoSize = True
        Me.lblRow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRow.Location = New System.Drawing.Point(265, 68)
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(32, 13)
        Me.lblRow.TabIndex = 95
        Me.lblRow.Text = "Row:"
        '
        'ucrInputRow
        '
        Me.ucrInputRow.AddQuotesIfUnrecognised = True
        Me.ucrInputRow.AutoSize = True
        Me.ucrInputRow.IsMultiline = False
        Me.ucrInputRow.IsReadOnly = False
        Me.ucrInputRow.Location = New System.Drawing.Point(301, 64)
        Me.ucrInputRow.Name = "ucrInputRow"
        Me.ucrInputRow.Size = New System.Drawing.Size(80, 21)
        Me.ucrInputRow.TabIndex = 96
        '
        'ucrPnlCellRowColumnDataFrame
        '
        Me.ucrPnlCellRowColumnDataFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlCellRowColumnDataFrame.Location = New System.Drawing.Point(-5, 8)
        Me.ucrPnlCellRowColumnDataFrame.Name = "ucrPnlCellRowColumnDataFrame"
        Me.ucrPnlCellRowColumnDataFrame.Size = New System.Drawing.Size(422, 29)
        Me.ucrPnlCellRowColumnDataFrame.TabIndex = 89
        '
        'ucrInputComment
        '
        Me.ucrInputComment.AddQuotesIfUnrecognised = True
        Me.ucrInputComment.AutoSize = True
        Me.ucrInputComment.IsMultiline = False
        Me.ucrInputComment.IsReadOnly = False
        Me.ucrInputComment.Location = New System.Drawing.Point(71, 235)
        Me.ucrInputComment.Name = "ucrInputComment"
        Me.ucrInputComment.Size = New System.Drawing.Size(336, 47)
        Me.ucrInputComment.TabIndex = 100
        '
        'ucrReceiverColumn
        '
        Me.ucrReceiverColumn.AutoSize = True
        Me.ucrReceiverColumn.frmParent = Me
        Me.ucrReceiverColumn.Location = New System.Drawing.Point(265, 125)
        Me.ucrReceiverColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumn.Name = "ucrReceiverColumn"
        Me.ucrReceiverColumn.Selector = Nothing
        Me.ucrReceiverColumn.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverColumn.strNcFilePath = ""
        Me.ucrReceiverColumn.TabIndex = 98
        Me.ucrReceiverColumn.ucrSelector = Nothing
        '
        'ucrSdgBaseButtons
        '
        Me.ucrSdgBaseButtons.AutoSize = True
        Me.ucrSdgBaseButtons.Location = New System.Drawing.Point(178, 291)
        Me.ucrSdgBaseButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrSdgBaseButtons.Name = "ucrSdgBaseButtons"
        Me.ucrSdgBaseButtons.Size = New System.Drawing.Size(224, 30)
        Me.ucrSdgBaseButtons.TabIndex = 88
        '
        'cmdAddComment
        '
        Me.cmdAddComment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAddComment.Location = New System.Drawing.Point(62, 293)
        Me.cmdAddComment.Name = "cmdAddComment"
        Me.cmdAddComment.Size = New System.Drawing.Size(90, 24)
        Me.cmdAddComment.TabIndex = 101
        Me.cmdAddComment.Text = "Add Comment"
        Me.cmdAddComment.UseVisualStyleBackColor = True
        '
        'ttcmdAddComment
        '
        Me.ttcmdAddComment.AutoPopDelay = 10000
        Me.ttcmdAddComment.InitialDelay = 500
        Me.ttcmdAddComment.ReshowDelay = 100
        '
        'ucrSelectorAddComment
        '
        Me.ucrSelectorAddComment.AutoSize = True
        Me.ucrSelectorAddComment.bDropUnusedFilterLevels = False
        Me.ucrSelectorAddComment.bShowHiddenColumns = False
        Me.ucrSelectorAddComment.bUseCurrentFilter = True
        Me.ucrSelectorAddComment.Location = New System.Drawing.Point(16, 39)
        Me.ucrSelectorAddComment.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorAddComment.Name = "ucrSelectorAddComment"
        Me.ucrSelectorAddComment.Size = New System.Drawing.Size(213, 188)
        Me.ucrSelectorAddComment.TabIndex = 102
        '
        'sdgCommentForDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(418, 328)
        Me.Controls.Add(Me.ucrSelectorAddComment)
        Me.Controls.Add(Me.cmdAddComment)
        Me.Controls.Add(Me.rdoColumn)
        Me.Controls.Add(Me.rdoDataFrame)
        Me.Controls.Add(Me.ucrInputRow)
        Me.Controls.Add(Me.rdoCell)
        Me.Controls.Add(Me.rdoRow)
        Me.Controls.Add(Me.ucrPnlCellRowColumnDataFrame)
        Me.Controls.Add(Me.ucrInputComment)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.lblColumn)
        Me.Controls.Add(Me.ucrReceiverColumn)
        Me.Controls.Add(Me.lblRow)
        Me.Controls.Add(Me.ucrSdgBaseButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCommentForDataEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Comment For Data Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSdgBaseButtons As ucrButtonsSubdialogue
    Friend WithEvents rdoColumn As RadioButton
    Friend WithEvents rdoDataFrame As RadioButton
    Friend WithEvents ucrInputRow As ucrInputTextBox
    Friend WithEvents rdoCell As RadioButton
    Friend WithEvents rdoRow As RadioButton
    Friend WithEvents ucrPnlCellRowColumnDataFrame As UcrPanel
    Friend WithEvents ucrInputComment As ucrInputTextBox
    Friend WithEvents lblComment As Label
    Friend WithEvents lblColumn As Label
    Friend WithEvents ucrReceiverColumn As ucrReceiverSingle
    Friend WithEvents lblRow As Label
    Friend WithEvents cmdAddComment As Button
    Friend WithEvents ttcmdAddComment As ToolTip
    Friend WithEvents ucrSelectorAddComment As ucrSelectorByDataFrameAddRemove
End Class
