<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrColumnFootNote
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
        Me.lblFooteNotes = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ucrSelectorByDF = New instat.ucrSelectorByDataFrameAddRemove()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.colStyles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblFootNote = New System.Windows.Forms.Label()
        Me.ucrTxtFootNote = New instat.ucrInputTextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ucrReceiverMultipleCols = New instat.ucrReceiverMultiple()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrSelectorByTableDF = New instat.ucrSelectorByOutputObject()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFooteNotes
        '
        Me.lblFooteNotes.AutoSize = True
        Me.lblFooteNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFooteNotes.Location = New System.Drawing.Point(231, 196)
        Me.lblFooteNotes.Name = "lblFooteNotes"
        Me.lblFooteNotes.Size = New System.Drawing.Size(62, 13)
        Me.lblFooteNotes.TabIndex = 347
        Me.lblFooteNotes.Text = "Foot Notes:"
        '
        'btnClear
        '
        Me.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClear.Location = New System.Drawing.Point(515, 188)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 346
        Me.btnClear.Tag = ""
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'ucrSelectorByDF
        '
        Me.ucrSelectorByDF.AutoSize = True
        Me.ucrSelectorByDF.bDropUnusedFilterLevels = False
        Me.ucrSelectorByDF.bShowHiddenColumns = False
        Me.ucrSelectorByDF.bUseCurrentFilter = True
        Me.ucrSelectorByDF.Location = New System.Drawing.Point(4, 4)
        Me.ucrSelectorByDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDF.Name = "ucrSelectorByDF"
        Me.ucrSelectorByDF.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorByDF.TabIndex = 343
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colStyles})
        Me.dataGrid.Location = New System.Drawing.Point(234, 213)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.RowHeadersWidth = 62
        Me.dataGrid.Size = New System.Drawing.Size(361, 73)
        Me.dataGrid.TabIndex = 342
        '
        'colStyles
        '
        Me.colStyles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colStyles.HeaderText = "Foot Note Expressions"
        Me.colStyles.MinimumWidth = 8
        Me.colStyles.Name = "colStyles"
        '
        'lblFootNote
        '
        Me.lblFootNote.AutoSize = True
        Me.lblFootNote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFootNote.Location = New System.Drawing.Point(241, 118)
        Me.lblFootNote.Name = "lblFootNote"
        Me.lblFootNote.Size = New System.Drawing.Size(81, 13)
        Me.lblFootNote.TabIndex = 352
        Me.lblFootNote.Text = "Foot Note Text:"
        '
        'ucrTxtFootNote
        '
        Me.ucrTxtFootNote.AddQuotesIfUnrecognised = True
        Me.ucrTxtFootNote.AutoSize = True
        Me.ucrTxtFootNote.IsMultiline = False
        Me.ucrTxtFootNote.IsReadOnly = False
        Me.ucrTxtFootNote.Location = New System.Drawing.Point(239, 134)
        Me.ucrTxtFootNote.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrTxtFootNote.Name = "ucrTxtFootNote"
        Me.ucrTxtFootNote.Size = New System.Drawing.Size(305, 21)
        Me.ucrTxtFootNote.TabIndex = 351
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAdd.Location = New System.Drawing.Point(239, 162)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(83, 23)
        Me.btnAdd.TabIndex = 344
        Me.btnAdd.Tag = ""
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'ucrReceiverMultipleCols
        '
        Me.ucrReceiverMultipleCols.AutoSize = True
        Me.ucrReceiverMultipleCols.frmParent = Nothing
        Me.ucrReceiverMultipleCols.Location = New System.Drawing.Point(239, 24)
        Me.ucrReceiverMultipleCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleCols.Name = "ucrReceiverMultipleCols"
        Me.ucrReceiverMultipleCols.Selector = Nothing
        Me.ucrReceiverMultipleCols.Size = New System.Drawing.Size(120, 80)
        Me.ucrReceiverMultipleCols.strNcFilePath = ""
        Me.ucrReceiverMultipleCols.TabIndex = 353
        Me.ucrReceiverMultipleCols.ucrSelector = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(242, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 354
        Me.Label1.Text = "Column(s):"
        '
        'ucrSelectorByTableDF
        '
        Me.ucrSelectorByTableDF.AutoSize = True
        Me.ucrSelectorByTableDF.bShowHiddenColumns = False
        Me.ucrSelectorByTableDF.Location = New System.Drawing.Point(3, 0)
        Me.ucrSelectorByTableDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByTableDF.Name = "ucrSelectorByTableDF"
        Me.ucrSelectorByTableDF.Size = New System.Drawing.Size(216, 194)
        Me.ucrSelectorByTableDF.TabIndex = 360
        '
        'ucrColumnFootNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrReceiverMultipleCols)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFooteNotes)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.lblFootNote)
        Me.Controls.Add(Me.ucrTxtFootNote)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ucrSelectorByTableDF)
        Me.Controls.Add(Me.ucrSelectorByDF)
        Me.Name = "ucrColumnFootNote"
        Me.Size = New System.Drawing.Size(600, 289)
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFooteNotes As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents ucrSelectorByDF As ucrSelectorByDataFrameAddRemove
    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents colStyles As DataGridViewTextBoxColumn
    Friend WithEvents lblFootNote As Label
    Friend WithEvents ucrTxtFootNote As ucrInputTextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents ucrReceiverMultipleCols As ucrReceiverMultiple
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrSelectorByTableDF As ucrSelectorByOutputObject
End Class
