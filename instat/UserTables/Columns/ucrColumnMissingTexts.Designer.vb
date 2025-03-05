<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrColumnMissingTexts
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblMissingTexts = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ucrSelectorCols = New instat.ucrSelectorByDataFrameAddRemove()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.colMissingTexts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ucrReceiverMultipleCols = New instat.ucrReceiverMultiple()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMissingText = New System.Windows.Forms.Label()
        Me.ucrTxtMissingText = New instat.ucrInputTextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMissingTexts
        '
        Me.lblMissingTexts.AutoSize = True
        Me.lblMissingTexts.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMissingTexts.Location = New System.Drawing.Point(347, 303)
        Me.lblMissingTexts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMissingTexts.Name = "lblMissingTexts"
        Me.lblMissingTexts.Size = New System.Drawing.Size(108, 20)
        Me.lblMissingTexts.TabIndex = 359
        Me.lblMissingTexts.Text = "Missing Texts:"
        '
        'btnClear
        '
        Me.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClear.Location = New System.Drawing.Point(773, 290)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 35)
        Me.btnClear.TabIndex = 358
        Me.btnClear.Tag = ""
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'ucrSelectorCols
        '
        Me.ucrSelectorCols.AutoSize = True
        Me.ucrSelectorCols.bDropUnusedFilterLevels = False
        Me.ucrSelectorCols.bShowHiddenColumns = False
        Me.ucrSelectorCols.bUseCurrentFilter = True
        Me.ucrSelectorCols.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCols.Name = "ucrSelectorCols"
        Me.ucrSelectorCols.Size = New System.Drawing.Size(320, 282)
        Me.ucrSelectorCols.TabIndex = 356
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMissingTexts})
        Me.dataGrid.Location = New System.Drawing.Point(352, 329)
        Me.dataGrid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.RowHeadersWidth = 62
        Me.dataGrid.Size = New System.Drawing.Size(542, 112)
        Me.dataGrid.TabIndex = 355
        '
        'colMissingTexts
        '
        Me.colMissingTexts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMissingTexts.HeaderText = "Missing Text Expressions"
        Me.colMissingTexts.MinimumWidth = 8
        Me.colMissingTexts.Name = "colMissingTexts"
        '
        'ucrReceiverMultipleCols
        '
        Me.ucrReceiverMultipleCols.AutoSize = True
        Me.ucrReceiverMultipleCols.frmParent = Nothing
        Me.ucrReceiverMultipleCols.Location = New System.Drawing.Point(359, 38)
        Me.ucrReceiverMultipleCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleCols.Name = "ucrReceiverMultipleCols"
        Me.ucrReceiverMultipleCols.Selector = Nothing
        Me.ucrReceiverMultipleCols.Size = New System.Drawing.Size(180, 123)
        Me.ucrReceiverMultipleCols.strNcFilePath = ""
        Me.ucrReceiverMultipleCols.TabIndex = 362
        Me.ucrReceiverMultipleCols.ucrSelector = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(364, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 363
        Me.Label1.Text = "Column(s):"
        '
        'lblMissingText
        '
        Me.lblMissingText.AutoSize = True
        Me.lblMissingText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMissingText.Location = New System.Drawing.Point(363, 183)
        Me.lblMissingText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMissingText.Name = "lblMissingText"
        Me.lblMissingText.Size = New System.Drawing.Size(163, 25)
        Me.lblMissingText.TabIndex = 361
        Me.lblMissingText.Text = "Replace NA with:"
        '
        'ucrTxtMissingText
        '
        Me.ucrTxtMissingText.AddQuotesIfUnrecognised = True
        Me.ucrTxtMissingText.AutoSize = True
        Me.ucrTxtMissingText.IsMultiline = False
        Me.ucrTxtMissingText.IsReadOnly = False
        Me.ucrTxtMissingText.Location = New System.Drawing.Point(359, 207)
        Me.ucrTxtMissingText.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrTxtMissingText.Name = "ucrTxtMissingText"
        Me.ucrTxtMissingText.Size = New System.Drawing.Size(180, 32)
        Me.ucrTxtMissingText.TabIndex = 360
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAdd.Location = New System.Drawing.Point(359, 250)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(124, 35)
        Me.btnAdd.TabIndex = 357
        Me.btnAdd.Tag = ""
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'ucrColumnMissingTexts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblMissingTexts)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.ucrSelectorCols)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.ucrReceiverMultipleCols)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMissingText)
        Me.Controls.Add(Me.ucrTxtMissingText)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "ucrColumnMissingTexts"
        Me.Size = New System.Drawing.Size(903, 452)
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMissingTexts As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents ucrSelectorCols As ucrSelectorByDataFrameAddRemove
    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents colMissingTexts As DataGridViewTextBoxColumn
    Friend WithEvents ucrReceiverMultipleCols As ucrReceiverMultiple
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMissingText As Label
    Friend WithEvents ucrTxtMissingText As ucrInputTextBox
    Friend WithEvents btnAdd As Button
End Class
