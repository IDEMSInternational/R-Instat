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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgCommentForDataEntry))
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
        resources.ApplyResources(Me.rdoColumn, "rdoColumn")
        Me.rdoColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColumn.FlatAppearance.BorderSize = 2
        Me.rdoColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColumn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoColumn.Name = "rdoColumn"
        Me.rdoColumn.UseVisualStyleBackColor = True
        '
        'rdoDataFrame
        '
        resources.ApplyResources(Me.rdoDataFrame, "rdoDataFrame")
        Me.rdoDataFrame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataFrame.FlatAppearance.BorderSize = 2
        Me.rdoDataFrame.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataFrame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoDataFrame.Name = "rdoDataFrame"
        Me.rdoDataFrame.UseVisualStyleBackColor = True
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
        'lblComment
        '
        resources.ApplyResources(Me.lblComment, "lblComment")
        Me.lblComment.Name = "lblComment"
        '
        'lblColumn
        '
        resources.ApplyResources(Me.lblColumn, "lblColumn")
        Me.lblColumn.Name = "lblColumn"
        '
        'lblRow
        '
        resources.ApplyResources(Me.lblRow, "lblRow")
        Me.lblRow.Name = "lblRow"
        '
        'ucrInputRow
        '
        Me.ucrInputRow.AddQuotesIfUnrecognised = True
        Me.ucrInputRow.IsMultiline = False
        Me.ucrInputRow.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputRow, "ucrInputRow")
        Me.ucrInputRow.Name = "ucrInputRow"
        '
        'ucrPnlCellRowColumnDataFrame
        '
        resources.ApplyResources(Me.ucrPnlCellRowColumnDataFrame, "ucrPnlCellRowColumnDataFrame")
        Me.ucrPnlCellRowColumnDataFrame.Name = "ucrPnlCellRowColumnDataFrame"
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
        'ucrSdgBaseButtons
        '
        resources.ApplyResources(Me.ucrSdgBaseButtons, "ucrSdgBaseButtons")
        Me.ucrSdgBaseButtons.Name = "ucrSdgBaseButtons"
        '
        'cmdAddComment
        '
        resources.ApplyResources(Me.cmdAddComment, "cmdAddComment")
        Me.cmdAddComment.Name = "cmdAddComment"
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
        Me.ucrSelectorAddComment.bDropUnusedFilterLevels = False
        Me.ucrSelectorAddComment.bShowHiddenColumns = False
        Me.ucrSelectorAddComment.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorAddComment, "ucrSelectorAddComment")
        Me.ucrSelectorAddComment.Name = "ucrSelectorAddComment"
        '
        'sdgCommentForDataEntry
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
