<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblNumberofRows = New System.Windows.Forms.Label()
        Me.rdoColumns = New System.Windows.Forms.RadioButton()
        Me.rdoRows = New System.Windows.Forms.RadioButton()
        Me.lblColumnsToDelete = New System.Windows.Forms.Label()
        Me.grpRowsToDelete = New System.Windows.Forms.GroupBox()
        Me.nudNumberofRows = New System.Windows.Forms.NumericUpDown()
        Me.lblNumOfRows = New System.Windows.Forms.Label()
        Me.nudStart = New System.Windows.Forms.NumericUpDown()
        Me.lblStartPosition = New System.Windows.Forms.Label()
        Me.ucrReceiverForColumnsToDelete = New instat.ucrReceiverMultiple()
        Me.ucrSelectorForDeleteColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrDataFrameLengthForDeleteRows = New instat.ucrDataFrameLength()
        Me.ucrSelectorForDeleteRows = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpRowsToDelete.SuspendLayout()
        CType(Me.nudNumberofRows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNumberofRows
        '
        Me.lblNumberofRows.AutoSize = True
        Me.lblNumberofRows.Location = New System.Drawing.Point(10, 91)
        Me.lblNumberofRows.Name = "lblNumberofRows"
        Me.lblNumberofRows.Size = New System.Drawing.Size(86, 13)
        Me.lblNumberofRows.TabIndex = 3
        Me.lblNumberofRows.Tag = "Number_of_Rows"
        Me.lblNumberofRows.Text = "Number of Rows"
        '
        'rdoColumns
        '
        Me.rdoColumns.AutoSize = True
        Me.rdoColumns.Location = New System.Drawing.Point(10, 10)
        Me.rdoColumns.Name = "rdoColumns"
        Me.rdoColumns.Size = New System.Drawing.Size(65, 17)
        Me.rdoColumns.TabIndex = 7
        Me.rdoColumns.TabStop = True
        Me.rdoColumns.Tag = "Columns"
        Me.rdoColumns.Text = "Columns"
        Me.rdoColumns.UseVisualStyleBackColor = True
        '
        'rdoRows
        '
        Me.rdoRows.AutoSize = True
        Me.rdoRows.Location = New System.Drawing.Point(247, 10)
        Me.rdoRows.Name = "rdoRows"
        Me.rdoRows.Size = New System.Drawing.Size(52, 17)
        Me.rdoRows.TabIndex = 8
        Me.rdoRows.TabStop = True
        Me.rdoRows.Tag = "Rows"
        Me.rdoRows.Text = "Rows"
        Me.rdoRows.UseVisualStyleBackColor = True
        '
        'lblColumnsToDelete
        '
        Me.lblColumnsToDelete.AutoSize = True
        Me.lblColumnsToDelete.Location = New System.Drawing.Point(249, 45)
        Me.lblColumnsToDelete.Name = "lblColumnsToDelete"
        Me.lblColumnsToDelete.Size = New System.Drawing.Size(93, 13)
        Me.lblColumnsToDelete.TabIndex = 14
        Me.lblColumnsToDelete.Tag = "Columns_to_Delete"
        Me.lblColumnsToDelete.Text = "Columns to Delete"
        '
        'grpRowsToDelete
        '
        Me.grpRowsToDelete.Controls.Add(Me.nudNumberofRows)
        Me.grpRowsToDelete.Controls.Add(Me.lblNumOfRows)
        Me.grpRowsToDelete.Controls.Add(Me.nudStart)
        Me.grpRowsToDelete.Controls.Add(Me.lblStartPosition)
        Me.grpRowsToDelete.Location = New System.Drawing.Point(247, 45)
        Me.grpRowsToDelete.Name = "grpRowsToDelete"
        Me.grpRowsToDelete.Size = New System.Drawing.Size(160, 70)
        Me.grpRowsToDelete.TabIndex = 15
        Me.grpRowsToDelete.TabStop = False
        Me.grpRowsToDelete.Text = "Rows to Delete"
        '
        'nudNumberofRows
        '
        Me.nudNumberofRows.Location = New System.Drawing.Point(105, 44)
        Me.nudNumberofRows.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumberofRows.Name = "nudNumberofRows"
        Me.nudNumberofRows.Size = New System.Drawing.Size(43, 20)
        Me.nudNumberofRows.TabIndex = 3
        Me.nudNumberofRows.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblNumOfRows
        '
        Me.lblNumOfRows.AutoSize = True
        Me.lblNumOfRows.Location = New System.Drawing.Point(6, 46)
        Me.lblNumOfRows.Name = "lblNumOfRows"
        Me.lblNumOfRows.Size = New System.Drawing.Size(86, 13)
        Me.lblNumOfRows.TabIndex = 2
        Me.lblNumOfRows.Text = "Number of Rows"
        '
        'nudStart
        '
        Me.nudStart.Location = New System.Drawing.Point(105, 18)
        Me.nudStart.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStart.Name = "nudStart"
        Me.nudStart.Size = New System.Drawing.Size(39, 20)
        Me.nudStart.TabIndex = 1
        Me.nudStart.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblStartPosition
        '
        Me.lblStartPosition.AutoSize = True
        Me.lblStartPosition.Location = New System.Drawing.Point(6, 20)
        Me.lblStartPosition.Name = "lblStartPosition"
        Me.lblStartPosition.Size = New System.Drawing.Size(55, 13)
        Me.lblStartPosition.TabIndex = 0
        Me.lblStartPosition.Tag = "From_Row"
        Me.lblStartPosition.Text = "From Row"
        '
        'ucrReceiverForColumnsToDelete
        '
        Me.ucrReceiverForColumnsToDelete.Location = New System.Drawing.Point(247, 72)
        Me.ucrReceiverForColumnsToDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForColumnsToDelete.Name = "ucrReceiverForColumnsToDelete"
        Me.ucrReceiverForColumnsToDelete.Selector = Nothing
        Me.ucrReceiverForColumnsToDelete.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverForColumnsToDelete.TabIndex = 13
        '
        'ucrSelectorForDeleteColumns
        '
        Me.ucrSelectorForDeleteColumns.bShowHiddenColumns = False
        Me.ucrSelectorForDeleteColumns.bUseCurrentFilter = False
        Me.ucrSelectorForDeleteColumns.Location = New System.Drawing.Point(10, 38)
        Me.ucrSelectorForDeleteColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDeleteColumns.Name = "ucrSelectorForDeleteColumns"
        Me.ucrSelectorForDeleteColumns.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForDeleteColumns.TabIndex = 12
        '
        'ucrDataFrameLengthForDeleteRows
        '
        Me.ucrDataFrameLengthForDeleteRows.clsDataFrameSelector = Nothing
        Me.ucrDataFrameLengthForDeleteRows.Location = New System.Drawing.Point(112, 85)
        Me.ucrDataFrameLengthForDeleteRows.Name = "ucrDataFrameLengthForDeleteRows"
        Me.ucrDataFrameLengthForDeleteRows.Size = New System.Drawing.Size(53, 23)
        Me.ucrDataFrameLengthForDeleteRows.TabIndex = 9
        '
        'ucrSelectorForDeleteRows
        '
        Me.ucrSelectorForDeleteRows.bUseCurrentFilter = False
        Me.ucrSelectorForDeleteRows.Location = New System.Drawing.Point(10, 38)
        Me.ucrSelectorForDeleteRows.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDeleteRows.Name = "ucrSelectorForDeleteRows"
        Me.ucrSelectorForDeleteRows.Size = New System.Drawing.Size(127, 41)
        Me.ucrSelectorForDeleteRows.TabIndex = 6
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 241)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 5
        '
        'dlgDeleteRowsOrColums
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 295)
        Me.Controls.Add(Me.lblColumnsToDelete)
        Me.Controls.Add(Me.grpRowsToDelete)
        Me.Controls.Add(Me.ucrReceiverForColumnsToDelete)
        Me.Controls.Add(Me.ucrSelectorForDeleteColumns)
        Me.Controls.Add(Me.ucrDataFrameLengthForDeleteRows)
        Me.Controls.Add(Me.rdoRows)
        Me.Controls.Add(Me.rdoColumns)
        Me.Controls.Add(Me.ucrSelectorForDeleteRows)
        Me.Controls.Add(Me.lblNumberofRows)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDeleteRowsOrColums"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Delete_Rows_Columns"
        Me.Text = "Delete Rows/Columns"
        Me.grpRowsToDelete.ResumeLayout(False)
        Me.grpRowsToDelete.PerformLayout()
        CType(Me.nudNumberofRows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblNumberofRows As Label
    Friend WithEvents ucrSelectorForDeleteRows As ucrDataFrame
    Friend WithEvents rdoColumns As RadioButton
    Friend WithEvents rdoRows As RadioButton
    Friend WithEvents ucrDataFrameLengthForDeleteRows As ucrDataFrameLength
    Friend WithEvents ucrSelectorForDeleteColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverForColumnsToDelete As ucrReceiverMultiple
    Friend WithEvents lblColumnsToDelete As Label
    Friend WithEvents grpRowsToDelete As GroupBox
    Friend WithEvents nudNumberofRows As NumericUpDown
    Friend WithEvents lblNumOfRows As Label
    Friend WithEvents nudStart As NumericUpDown
    Friend WithEvents lblStartPosition As Label
End Class
