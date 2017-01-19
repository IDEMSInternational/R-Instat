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
        Me.ucrReceiverKeyColumn = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 240)
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
        Me.rdoCell.Location = New System.Drawing.Point(177, 15)
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
        'ucrReceiverKeyColumn
        '
        Me.ucrReceiverKeyColumn.frmParent = Me
        Me.ucrReceiverKeyColumn.Location = New System.Drawing.Point(266, 69)
        Me.ucrReceiverKeyColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverKeyColumn.Name = "ucrReceiverKeyColumn"
        Me.ucrReceiverKeyColumn.Selector = Nothing
        Me.ucrReceiverKeyColumn.Size = New System.Drawing.Size(129, 20)
        Me.ucrReceiverKeyColumn.TabIndex = 9
        '
        'dlgAddComment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 304)
        Me.Controls.Add(Me.ucrReceiverKeyColumn)
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
    Friend WithEvents ucrReceiverKeyColumn As ucrReceiverSingle
End Class
