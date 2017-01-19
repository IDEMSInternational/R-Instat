<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ucrBase = New instat.ucrButtons()
        Me.rdoRow = New System.Windows.Forms.RadioButton()
        Me.rdoCell = New System.Windows.Forms.RadioButton()
        Me.ucrDataFrame = New instat.ucrDataFrame()
        Me.ucrSelectorAddComment = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverRow = New instat.ucrReceiverSingle()
        Me.lblRow = New System.Windows.Forms.Label()
        Me.ucrReceiverColumn = New instat.ucrReceiverSingle()
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 260)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 1
        '
        'rdoRow
        '
        Me.rdoRow.AutoSize = True
        Me.rdoRow.Location = New System.Drawing.Point(12, 15)
        Me.rdoRow.Name = "rdoRow"
        Me.rdoRow.Size = New System.Drawing.Size(47, 17)
        Me.rdoRow.TabIndex = 5
        Me.rdoRow.TabStop = True
        Me.rdoRow.Text = "Row"
        Me.rdoRow.UseVisualStyleBackColor = True
        '
        'rdoCell
        '
        Me.rdoCell.AutoSize = True
        Me.rdoCell.Location = New System.Drawing.Point(161, 15)
        Me.rdoCell.Name = "rdoCell"
        Me.rdoCell.Size = New System.Drawing.Size(42, 17)
        Me.rdoCell.TabIndex = 6
        Me.rdoCell.TabStop = True
        Me.rdoCell.Text = "Cell"
        Me.rdoCell.UseVisualStyleBackColor = True
        '
        'ucrDataFrame
        '
        Me.ucrDataFrame.bUseCurrentFilter = True
        Me.ucrDataFrame.Location = New System.Drawing.Point(9, 55)
        Me.ucrDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrame.Name = "ucrDataFrame"
        Me.ucrDataFrame.Size = New System.Drawing.Size(120, 50)
        Me.ucrDataFrame.TabIndex = 7
        '
        'ucrSelectorAddComment
        '
        Me.ucrSelectorAddComment.bShowHiddenColumns = False
        Me.ucrSelectorAddComment.bUseCurrentFilter = True
        Me.ucrSelectorAddComment.Location = New System.Drawing.Point(9, 57)
        Me.ucrSelectorAddComment.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorAddComment.Name = "ucrSelectorAddComment"
        Me.ucrSelectorAddComment.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorAddComment.TabIndex = 8
        '
        'ucrReceiverRow
        '
        Me.ucrReceiverRow.frmParent = Me
        Me.ucrReceiverRow.Location = New System.Drawing.Point(266, 69)
        Me.ucrReceiverRow.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRow.Name = "ucrReceiverRow"
        Me.ucrReceiverRow.Selector = Nothing
        Me.ucrReceiverRow.Size = New System.Drawing.Size(129, 20)
        Me.ucrReceiverRow.TabIndex = 9
        '
        'lblRow
        '
        Me.lblRow.AutoSize = True
        Me.lblRow.Location = New System.Drawing.Point(266, 49)
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(32, 13)
        Me.lblRow.TabIndex = 10
        Me.lblRow.Text = "Row:"
        '
        'ucrReceiverColumn
        '
        Me.ucrReceiverColumn.frmParent = Me
        Me.ucrReceiverColumn.Location = New System.Drawing.Point(266, 134)
        Me.ucrReceiverColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumn.Name = "ucrReceiverColumn"
        Me.ucrReceiverColumn.Selector = Nothing
        Me.ucrReceiverColumn.Size = New System.Drawing.Size(129, 20)
        Me.ucrReceiverColumn.TabIndex = 11
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.Location = New System.Drawing.Point(266, 113)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(45, 13)
        Me.lblColumn.TabIndex = 12
        Me.lblColumn.Text = "Column:"
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(266, 193)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(100, 20)
        Me.txtComment.TabIndex = 13
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Location = New System.Drawing.Point(266, 172)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(54, 13)
        Me.lblComment.TabIndex = 14
        Me.lblComment.Text = "Comment:"
        '
        'dlgAddComment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 320)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.lblColumn)
        Me.Controls.Add(Me.ucrReceiverColumn)
        Me.Controls.Add(Me.lblRow)
        Me.Controls.Add(Me.ucrReceiverRow)
        Me.Controls.Add(Me.ucrSelectorAddComment)
        Me.Controls.Add(Me.ucrDataFrame)
        Me.Controls.Add(Me.rdoCell)
        Me.Controls.Add(Me.rdoRow)
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
    Friend WithEvents rdoRow As RadioButton
    Friend WithEvents rdoCell As RadioButton
    Friend WithEvents ucrDataFrame As ucrDataFrame
    Friend WithEvents ucrSelectorAddComment As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRow As ucrReceiverSingle
    Friend WithEvents lblRow As Label
    Friend WithEvents lblColumn As Label
    Friend WithEvents ucrReceiverColumn As ucrReceiverSingle
    Friend WithEvents lblComment As Label
    Friend WithEvents txtComment As TextBox
End Class
