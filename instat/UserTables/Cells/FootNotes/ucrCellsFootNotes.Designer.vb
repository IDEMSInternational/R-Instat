<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrCellsFootNotes
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
        Me.lblRowExpression = New System.Windows.Forms.Label()
        Me.lblFooteNotes = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.ucrSelectorByDF = New instat.ucrSelectorByDataFrameAddRemove()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.colStyles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ucrReceiverSingleCol = New instat.ucrReceiverSingle()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ucrTxtFootNote = New instat.ucrInputTextBox()
        Me.lblFootNote = New System.Windows.Forms.Label()
        Me.ucrSelectorByTableDF = New instat.ucrSelectorByOutputObject()
        Me.ucrRowExpression = New instat.ucrRowExpression()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRowExpression
        '
        Me.lblRowExpression.AutoSize = True
        Me.lblRowExpression.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRowExpression.Location = New System.Drawing.Point(238, 46)
        Me.lblRowExpression.Name = "lblRowExpression"
        Me.lblRowExpression.Size = New System.Drawing.Size(86, 13)
        Me.lblRowExpression.TabIndex = 338
        Me.lblRowExpression.Text = "Row Expression:"
        '
        'lblFooteNotes
        '
        Me.lblFooteNotes.AutoSize = True
        Me.lblFooteNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFooteNotes.Location = New System.Drawing.Point(233, 171)
        Me.lblFooteNotes.Name = "lblFooteNotes"
        Me.lblFooteNotes.Size = New System.Drawing.Size(62, 13)
        Me.lblFooteNotes.TabIndex = 336
        Me.lblFooteNotes.Text = "Foot Notes:"
        '
        'btnClear
        '
        Me.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClear.Location = New System.Drawing.Point(517, 162)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 335
        Me.btnClear.Tag = ""
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(238, 0)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(45, 13)
        Me.lblColumns.TabIndex = 334
        Me.lblColumns.Text = "Column:"
        '
        'ucrSelectorByDF
        '
        Me.ucrSelectorByDF.AutoSize = True
        Me.ucrSelectorByDF.bDropUnusedFilterLevels = False
        Me.ucrSelectorByDF.bShowHiddenColumns = False
        Me.ucrSelectorByDF.bUseCurrentFilter = True
        Me.ucrSelectorByDF.Location = New System.Drawing.Point(5, 0)
        Me.ucrSelectorByDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDF.Name = "ucrSelectorByDF"
        Me.ucrSelectorByDF.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorByDF.TabIndex = 332
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colStyles})
        Me.dataGrid.Location = New System.Drawing.Point(236, 188)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.RowHeadersWidth = 62
        Me.dataGrid.Size = New System.Drawing.Size(361, 73)
        Me.dataGrid.TabIndex = 331
        '
        'colStyles
        '
        Me.colStyles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colStyles.HeaderText = "Foot Note Expressions"
        Me.colStyles.MinimumWidth = 8
        Me.colStyles.Name = "colStyles"
        '
        'ucrReceiverSingleCol
        '
        Me.ucrReceiverSingleCol.AutoSize = True
        Me.ucrReceiverSingleCol.frmParent = Nothing
        Me.ucrReceiverSingleCol.Location = New System.Drawing.Point(240, 13)
        Me.ucrReceiverSingleCol.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleCol.Name = "ucrReceiverSingleCol"
        Me.ucrReceiverSingleCol.Selector = Nothing
        Me.ucrReceiverSingleCol.Size = New System.Drawing.Size(142, 20)
        Me.ucrReceiverSingleCol.strNcFilePath = ""
        Me.ucrReceiverSingleCol.TabIndex = 339
        Me.ucrReceiverSingleCol.ucrSelector = Nothing
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAdd.Location = New System.Drawing.Point(241, 135)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(83, 23)
        Me.btnAdd.TabIndex = 333
        Me.btnAdd.Tag = ""
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'ucrTxtFootNote
        '
        Me.ucrTxtFootNote.AddQuotesIfUnrecognised = True
        Me.ucrTxtFootNote.AutoSize = True
        Me.ucrTxtFootNote.IsMultiline = False
        Me.ucrTxtFootNote.IsReadOnly = False
        Me.ucrTxtFootNote.Location = New System.Drawing.Point(241, 107)
        Me.ucrTxtFootNote.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrTxtFootNote.Name = "ucrTxtFootNote"
        Me.ucrTxtFootNote.Size = New System.Drawing.Size(299, 21)
        Me.ucrTxtFootNote.TabIndex = 340
        '
        'lblFootNote
        '
        Me.lblFootNote.AutoSize = True
        Me.lblFootNote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFootNote.Location = New System.Drawing.Point(243, 91)
        Me.lblFootNote.Name = "lblFootNote"
        Me.lblFootNote.Size = New System.Drawing.Size(81, 13)
        Me.lblFootNote.TabIndex = 341
        Me.lblFootNote.Text = "Foot Note Text:"
        '
        'ucrSelectorByTableDF
        '
        Me.ucrSelectorByTableDF.AutoSize = True
        Me.ucrSelectorByTableDF.bShowHiddenColumns = False
        Me.ucrSelectorByTableDF.Location = New System.Drawing.Point(2, 5)
        Me.ucrSelectorByTableDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByTableDF.Name = "ucrSelectorByTableDF"
        Me.ucrSelectorByTableDF.Size = New System.Drawing.Size(216, 194)
        Me.ucrSelectorByTableDF.TabIndex = 376
        '
        'ucrRowExpression
        '
        Me.ucrRowExpression.Location = New System.Drawing.Point(241, 62)
        Me.ucrRowExpression.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrRowExpression.Name = "ucrRowExpression"
        Me.ucrRowExpression.Size = New System.Drawing.Size(141, 25)
        Me.ucrRowExpression.TabIndex = 377
        '
        'ucrCellsFootNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrRowExpression)
        Me.Controls.Add(Me.lblFootNote)
        Me.Controls.Add(Me.ucrTxtFootNote)
        Me.Controls.Add(Me.lblRowExpression)
        Me.Controls.Add(Me.lblFooteNotes)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.ucrReceiverSingleCol)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ucrSelectorByDF)
        Me.Controls.Add(Me.ucrSelectorByTableDF)
        Me.Name = "ucrCellsFootNotes"
        Me.Size = New System.Drawing.Size(602, 265)
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRowExpression As Label
    Friend WithEvents lblFooteNotes As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrSelectorByDF As ucrSelectorByDataFrameAddRemove
    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents colStyles As DataGridViewTextBoxColumn
    Friend WithEvents ucrReceiverSingleCol As ucrReceiverSingle
    Friend WithEvents btnAdd As Button
    Friend WithEvents ucrTxtFootNote As ucrInputTextBox
    Friend WithEvents lblFootNote As Label
    Friend WithEvents ucrSelectorByTableDF As ucrSelectorByOutputObject
    Friend WithEvents ucrRowExpression As ucrRowExpression
End Class
