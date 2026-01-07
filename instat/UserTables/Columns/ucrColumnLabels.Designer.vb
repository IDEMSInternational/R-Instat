<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrColumnLabels
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
        Me.dataGridColLabels = New System.Windows.Forms.DataGridView()
        Me.colLabel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodnition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ucrInputColLabel = New instat.ucrInputTextBox()
        Me.lblCondition = New System.Windows.Forms.Label()
        Me.lblColLabels = New System.Windows.Forms.Label()
        Me.btnClearLabels = New System.Windows.Forms.Button()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.btnAddLabel = New System.Windows.Forms.Button()
        Me.ucrReceiverSingleCol = New instat.ucrReceiverSingle()
        Me.ucrSelectorByDF = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorByTableDF = New instat.ucrSelectorByOutputObject()
        CType(Me.dataGridColLabels, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridColLabels
        '
        Me.dataGridColLabels.AllowUserToAddRows = False
        Me.dataGridColLabels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridColLabels.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLabel, Me.colCodnition})
        Me.dataGridColLabels.Location = New System.Drawing.Point(230, 159)
        Me.dataGridColLabels.Name = "dataGridColLabels"
        Me.dataGridColLabels.RowHeadersWidth = 62
        Me.dataGridColLabels.Size = New System.Drawing.Size(266, 95)
        Me.dataGridColLabels.TabIndex = 309
        '
        'colLabel
        '
        Me.colLabel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colLabel.HeaderText = "Column"
        Me.colLabel.MinimumWidth = 8
        Me.colLabel.Name = "colLabel"
        '
        'colCodnition
        '
        Me.colCodnition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colCodnition.HeaderText = "Label"
        Me.colCodnition.MinimumWidth = 8
        Me.colCodnition.Name = "colCodnition"
        '
        'ucrInputColLabel
        '
        Me.ucrInputColLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputColLabel.AutoSize = True
        Me.ucrInputColLabel.IsMultiline = False
        Me.ucrInputColLabel.IsReadOnly = False
        Me.ucrInputColLabel.Location = New System.Drawing.Point(230, 73)
        Me.ucrInputColLabel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputColLabel.Name = "ucrInputColLabel"
        Me.ucrInputColLabel.Size = New System.Drawing.Size(119, 21)
        Me.ucrInputColLabel.TabIndex = 320
        '
        'lblCondition
        '
        Me.lblCondition.AutoSize = True
        Me.lblCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCondition.Location = New System.Drawing.Point(227, 57)
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Size = New System.Drawing.Size(36, 13)
        Me.lblCondition.TabIndex = 319
        Me.lblCondition.Text = "Label:"
        '
        'lblColLabels
        '
        Me.lblColLabels.AutoSize = True
        Me.lblColLabels.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColLabels.Location = New System.Drawing.Point(227, 140)
        Me.lblColLabels.Name = "lblColLabels"
        Me.lblColLabels.Size = New System.Drawing.Size(79, 13)
        Me.lblColLabels.TabIndex = 315
        Me.lblColLabels.Text = "Column Labels:"
        '
        'btnClearLabels
        '
        Me.btnClearLabels.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearLabels.Location = New System.Drawing.Point(414, 135)
        Me.btnClearLabels.Name = "btnClearLabels"
        Me.btnClearLabels.Size = New System.Drawing.Size(79, 23)
        Me.btnClearLabels.TabIndex = 314
        Me.btnClearLabels.Tag = ""
        Me.btnClearLabels.Text = "Clear"
        Me.btnClearLabels.UseVisualStyleBackColor = True
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(227, 11)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(45, 13)
        Me.lblColumns.TabIndex = 313
        Me.lblColumns.Text = "Column:"
        '
        'btnAddLabel
        '
        Me.btnAddLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAddLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddLabel.Location = New System.Drawing.Point(230, 100)
        Me.btnAddLabel.Name = "btnAddLabel"
        Me.btnAddLabel.Size = New System.Drawing.Size(78, 23)
        Me.btnAddLabel.TabIndex = 312
        Me.btnAddLabel.Tag = ""
        Me.btnAddLabel.Text = "Add"
        Me.btnAddLabel.UseVisualStyleBackColor = True
        '
        'ucrReceiverSingleCol
        '
        Me.ucrReceiverSingleCol.AutoSize = True
        Me.ucrReceiverSingleCol.frmParent = Nothing
        Me.ucrReceiverSingleCol.Location = New System.Drawing.Point(229, 27)
        Me.ucrReceiverSingleCol.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleCol.Name = "ucrReceiverSingleCol"
        Me.ucrReceiverSingleCol.Selector = Nothing
        Me.ucrReceiverSingleCol.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverSingleCol.strNcFilePath = ""
        Me.ucrReceiverSingleCol.TabIndex = 311
        Me.ucrReceiverSingleCol.ucrSelector = Nothing
        '
        'ucrSelectorByDF
        '
        Me.ucrSelectorByDF.AutoSize = True
        Me.ucrSelectorByDF.bDropUnusedFilterLevels = False
        Me.ucrSelectorByDF.bShowHiddenColumns = False
        Me.ucrSelectorByDF.bUseCurrentFilter = True
        Me.ucrSelectorByDF.Location = New System.Drawing.Point(6, 5)
        Me.ucrSelectorByDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDF.Name = "ucrSelectorByDF"
        Me.ucrSelectorByDF.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorByDF.TabIndex = 310
        '
        'ucrSelectorByTableDF
        '
        Me.ucrSelectorByTableDF.AutoSize = True
        Me.ucrSelectorByTableDF.bShowHiddenColumns = False
        Me.ucrSelectorByTableDF.Location = New System.Drawing.Point(0, 0)
        Me.ucrSelectorByTableDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByTableDF.Name = "ucrSelectorByTableDF"
        Me.ucrSelectorByTableDF.Size = New System.Drawing.Size(216, 194)
        Me.ucrSelectorByTableDF.TabIndex = 359
        '
        'ucrColumnLabels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dataGridColLabels)
        Me.Controls.Add(Me.ucrInputColLabel)
        Me.Controls.Add(Me.lblCondition)
        Me.Controls.Add(Me.lblColLabels)
        Me.Controls.Add(Me.btnClearLabels)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.btnAddLabel)
        Me.Controls.Add(Me.ucrReceiverSingleCol)
        Me.Controls.Add(Me.ucrSelectorByDF)
        Me.Controls.Add(Me.ucrSelectorByTableDF)
        Me.Name = "ucrColumnLabels"
        Me.Size = New System.Drawing.Size(499, 257)
        CType(Me.dataGridColLabels, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataGridColLabels As DataGridView
    Friend WithEvents ucrInputColLabel As ucrInputTextBox
    Friend WithEvents lblCondition As Label
    Friend WithEvents lblColLabels As Label
    Friend WithEvents btnClearLabels As Button
    Friend WithEvents lblColumns As Label
    Friend WithEvents btnAddLabel As Button
    Friend WithEvents ucrReceiverSingleCol As ucrReceiverSingle
    Friend WithEvents ucrSelectorByDF As ucrSelectorByDataFrameAddRemove
    Friend WithEvents colLabel As DataGridViewTextBoxColumn
    Friend WithEvents colCodnition As DataGridViewTextBoxColumn
    Friend WithEvents ucrSelectorByTableDF As ucrSelectorByOutputObject
End Class
