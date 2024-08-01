<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrRowSummary
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
        Me.dataGridSummaries = New System.Windows.Forms.DataGridView()
        Me.colLabel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodnition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStyleExpression = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnStyle = New System.Windows.Forms.Button()
        Me.lblSummaryTypes = New System.Windows.Forms.Label()
        Me.lblSummaries = New System.Windows.Forms.Label()
        Me.btnClearSummaries = New System.Windows.Forms.Button()
        Me.btnAddSummaries = New System.Windows.Forms.Button()
        Me.lblSummaryLabel = New System.Windows.Forms.Label()
        Me.lblReplaceWith = New System.Windows.Forms.Label()
        Me.UcrInputTextBox2 = New instat.ucrInputTextBox()
        Me.UcrInputComboBox1 = New instat.ucrInputComboBox()
        Me.UcrInputTextBox1 = New instat.ucrInputTextBox()
        Me.btnFormat = New System.Windows.Forms.Button()
        CType(Me.dataGridSummaries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridSummaries
        '
        Me.dataGridSummaries.AllowUserToAddRows = False
        Me.dataGridSummaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridSummaries.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLabel, Me.colCodnition, Me.colStyleExpression})
        Me.dataGridSummaries.Location = New System.Drawing.Point(4, 320)
        Me.dataGridSummaries.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dataGridSummaries.Name = "dataGridSummaries"
        Me.dataGridSummaries.ReadOnly = True
        Me.dataGridSummaries.RowHeadersWidth = 62
        Me.dataGridSummaries.Size = New System.Drawing.Size(484, 146)
        Me.dataGridSummaries.TabIndex = 335
        '
        'colLabel
        '
        Me.colLabel.HeaderText = "Label"
        Me.colLabel.MinimumWidth = 8
        Me.colLabel.Name = "colLabel"
        Me.colLabel.ReadOnly = True
        Me.colLabel.Width = 70
        '
        'colCodnition
        '
        Me.colCodnition.HeaderText = "Condition"
        Me.colCodnition.MinimumWidth = 8
        Me.colCodnition.Name = "colCodnition"
        Me.colCodnition.ReadOnly = True
        Me.colCodnition.Width = 90
        '
        'colStyleExpression
        '
        Me.colStyleExpression.HeaderText = "Style Expression"
        Me.colStyleExpression.MinimumWidth = 8
        Me.colStyleExpression.Name = "colStyleExpression"
        Me.colStyleExpression.ReadOnly = True
        Me.colStyleExpression.Width = 90
        '
        'btnStyle
        '
        Me.btnStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnStyle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnStyle.Location = New System.Drawing.Point(154, 158)
        Me.btnStyle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStyle.Name = "btnStyle"
        Me.btnStyle.Size = New System.Drawing.Size(126, 35)
        Me.btnStyle.TabIndex = 341
        Me.btnStyle.Tag = ""
        Me.btnStyle.Text = "Style"
        Me.btnStyle.UseVisualStyleBackColor = True
        '
        'lblSummaryTypes
        '
        Me.lblSummaryTypes.AutoSize = True
        Me.lblSummaryTypes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummaryTypes.Location = New System.Drawing.Point(11, 9)
        Me.lblSummaryTypes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSummaryTypes.Name = "lblSummaryTypes"
        Me.lblSummaryTypes.Size = New System.Drawing.Size(118, 20)
        Me.lblSummaryTypes.TabIndex = 339
        Me.lblSummaryTypes.Text = "Summary Type:"
        '
        'lblSummaries
        '
        Me.lblSummaries.AutoSize = True
        Me.lblSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummaries.Location = New System.Drawing.Point(6, 295)
        Me.lblSummaries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSummaries.Name = "lblSummaries"
        Me.lblSummaries.Size = New System.Drawing.Size(93, 20)
        Me.lblSummaries.TabIndex = 338
        Me.lblSummaries.Text = "Summaries:"
        '
        'btnClearSummaries
        '
        Me.btnClearSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearSummaries.Location = New System.Drawing.Point(366, 271)
        Me.btnClearSummaries.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClearSummaries.Name = "btnClearSummaries"
        Me.btnClearSummaries.Size = New System.Drawing.Size(118, 35)
        Me.btnClearSummaries.TabIndex = 337
        Me.btnClearSummaries.Tag = ""
        Me.btnClearSummaries.Text = "Clear"
        Me.btnClearSummaries.UseVisualStyleBackColor = True
        '
        'btnAddSummaries
        '
        Me.btnAddSummaries.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAddSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddSummaries.Location = New System.Drawing.Point(10, 246)
        Me.btnAddSummaries.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddSummaries.Name = "btnAddSummaries"
        Me.btnAddSummaries.Size = New System.Drawing.Size(144, 35)
        Me.btnAddSummaries.TabIndex = 336
        Me.btnAddSummaries.Tag = ""
        Me.btnAddSummaries.Text = "Add"
        Me.btnAddSummaries.UseVisualStyleBackColor = True
        '
        'lblSummaryLabel
        '
        Me.lblSummaryLabel.AutoSize = True
        Me.lblSummaryLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSummaryLabel.Location = New System.Drawing.Point(11, 81)
        Me.lblSummaryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSummaryLabel.Name = "lblSummaryLabel"
        Me.lblSummaryLabel.Size = New System.Drawing.Size(123, 20)
        Me.lblSummaryLabel.TabIndex = 342
        Me.lblSummaryLabel.Text = "Summary Label:"
        '
        'lblReplaceWith
        '
        Me.lblReplaceWith.AutoSize = True
        Me.lblReplaceWith.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblReplaceWith.Location = New System.Drawing.Point(255, 9)
        Me.lblReplaceWith.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReplaceWith.Name = "lblReplaceWith"
        Me.lblReplaceWith.Size = New System.Drawing.Size(130, 20)
        Me.lblReplaceWith.TabIndex = 346
        Me.lblReplaceWith.Text = "Replace NA with:"
        '
        'UcrInputTextBox2
        '
        Me.UcrInputTextBox2.AddQuotesIfUnrecognised = True
        Me.UcrInputTextBox2.AutoSize = True
        Me.UcrInputTextBox2.IsMultiline = False
        Me.UcrInputTextBox2.IsReadOnly = False
        Me.UcrInputTextBox2.Location = New System.Drawing.Point(254, 35)
        Me.UcrInputTextBox2.Margin = New System.Windows.Forms.Padding(14)
        Me.UcrInputTextBox2.Name = "UcrInputTextBox2"
        Me.UcrInputTextBox2.Size = New System.Drawing.Size(180, 32)
        Me.UcrInputTextBox2.TabIndex = 347
        '
        'UcrInputComboBox1
        '
        Me.UcrInputComboBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrInputComboBox1.GetSetSelectedIndex = -1
        Me.UcrInputComboBox1.IsReadOnly = False
        Me.UcrInputComboBox1.Location = New System.Drawing.Point(14, 32)
        Me.UcrInputComboBox1.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.UcrInputComboBox1.Name = "UcrInputComboBox1"
        Me.UcrInputComboBox1.Size = New System.Drawing.Size(176, 40)
        Me.UcrInputComboBox1.TabIndex = 345
        '
        'UcrInputTextBox1
        '
        Me.UcrInputTextBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputTextBox1.AutoSize = True
        Me.UcrInputTextBox1.IsMultiline = False
        Me.UcrInputTextBox1.IsReadOnly = False
        Me.UcrInputTextBox1.Location = New System.Drawing.Point(10, 107)
        Me.UcrInputTextBox1.Margin = New System.Windows.Forms.Padding(14)
        Me.UcrInputTextBox1.Name = "UcrInputTextBox1"
        Me.UcrInputTextBox1.Size = New System.Drawing.Size(180, 32)
        Me.UcrInputTextBox1.TabIndex = 343
        '
        'btnFormat
        '
        Me.btnFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFormat.Location = New System.Drawing.Point(10, 158)
        Me.btnFormat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFormat.Name = "btnFormat"
        Me.btnFormat.Size = New System.Drawing.Size(136, 35)
        Me.btnFormat.TabIndex = 348
        Me.btnFormat.Tag = ""
        Me.btnFormat.Text = "Format"
        Me.btnFormat.UseVisualStyleBackColor = True
        '
        'ucrRowSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnFormat)
        Me.Controls.Add(Me.UcrInputTextBox2)
        Me.Controls.Add(Me.lblReplaceWith)
        Me.Controls.Add(Me.UcrInputComboBox1)
        Me.Controls.Add(Me.UcrInputTextBox1)
        Me.Controls.Add(Me.lblSummaryLabel)
        Me.Controls.Add(Me.dataGridSummaries)
        Me.Controls.Add(Me.btnStyle)
        Me.Controls.Add(Me.lblSummaryTypes)
        Me.Controls.Add(Me.lblSummaries)
        Me.Controls.Add(Me.btnClearSummaries)
        Me.Controls.Add(Me.btnAddSummaries)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ucrRowSummary"
        Me.Size = New System.Drawing.Size(530, 471)
        CType(Me.dataGridSummaries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataGridSummaries As DataGridView
    Friend WithEvents colLabel As DataGridViewTextBoxColumn
    Friend WithEvents colCodnition As DataGridViewTextBoxColumn
    Friend WithEvents colStyleExpression As DataGridViewTextBoxColumn
    Friend WithEvents btnStyle As Button
    Friend WithEvents lblSummaryTypes As Label
    Friend WithEvents lblSummaries As Label
    Friend WithEvents btnClearSummaries As Button
    Friend WithEvents btnAddSummaries As Button
    Friend WithEvents UcrInputTextBox1 As ucrInputTextBox
    Friend WithEvents lblSummaryLabel As Label
    Friend WithEvents UcrInputComboBox1 As ucrInputComboBox
    Friend WithEvents UcrInputTextBox2 As ucrInputTextBox
    Friend WithEvents lblReplaceWith As Label
    Friend WithEvents btnFormat As Button
End Class
