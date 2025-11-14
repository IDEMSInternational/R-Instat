<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrTableOptions
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
        Me.lblMissingText = New System.Windows.Forms.Label()
        Me.btnAddReplaceNaExpression = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSelectFormat = New System.Windows.Forms.ComboBox()
        Me.btnAddFormatExpression = New System.Windows.Forms.Button()
        Me.lblExpressions = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.colExpressions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ucrTxtMissingText = New instat.ucrInputTextBox()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMissingText
        '
        Me.lblMissingText.AutoSize = True
        Me.lblMissingText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMissingText.Location = New System.Drawing.Point(9, 11)
        Me.lblMissingText.Name = "lblMissingText"
        Me.lblMissingText.Size = New System.Drawing.Size(90, 13)
        Me.lblMissingText.TabIndex = 364
        Me.lblMissingText.Text = "Replace NA with:"
        '
        'btnAddReplaceNaExpression
        '
        Me.btnAddReplaceNaExpression.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAddReplaceNaExpression.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddReplaceNaExpression.Location = New System.Drawing.Point(147, 25)
        Me.btnAddReplaceNaExpression.Name = "btnAddReplaceNaExpression"
        Me.btnAddReplaceNaExpression.Size = New System.Drawing.Size(123, 23)
        Me.btnAddReplaceNaExpression.TabIndex = 362
        Me.btnAddReplaceNaExpression.Tag = ""
        Me.btnAddReplaceNaExpression.Text = "Add Expression"
        Me.btnAddReplaceNaExpression.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(3, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 367
        Me.Label2.Text = "Select Format:"
        '
        'cboSelectFormat
        '
        Me.cboSelectFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelectFormat.FormattingEnabled = True
        Me.cboSelectFormat.Items.AddRange(New Object() {"Text", "Number", "Date"})
        Me.cboSelectFormat.Location = New System.Drawing.Point(6, 80)
        Me.cboSelectFormat.Name = "cboSelectFormat"
        Me.cboSelectFormat.Size = New System.Drawing.Size(132, 21)
        Me.cboSelectFormat.TabIndex = 366
        '
        'btnAddFormatExpression
        '
        Me.btnAddFormatExpression.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAddFormatExpression.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddFormatExpression.Location = New System.Drawing.Point(147, 78)
        Me.btnAddFormatExpression.Name = "btnAddFormatExpression"
        Me.btnAddFormatExpression.Size = New System.Drawing.Size(126, 23)
        Me.btnAddFormatExpression.TabIndex = 365
        Me.btnAddFormatExpression.Tag = ""
        Me.btnAddFormatExpression.Text = "Add Expression"
        Me.btnAddFormatExpression.UseVisualStyleBackColor = True
        '
        'lblExpressions
        '
        Me.lblExpressions.AutoSize = True
        Me.lblExpressions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExpressions.Location = New System.Drawing.Point(4, 135)
        Me.lblExpressions.Name = "lblExpressions"
        Me.lblExpressions.Size = New System.Drawing.Size(66, 13)
        Me.lblExpressions.TabIndex = 370
        Me.lblExpressions.Text = "Expressions:"
        '
        'btnClear
        '
        Me.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClear.Location = New System.Drawing.Point(288, 126)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 369
        Me.btnClear.Tag = ""
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colExpressions})
        Me.dataGrid.Location = New System.Drawing.Point(8, 152)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.RowHeadersWidth = 62
        Me.dataGrid.Size = New System.Drawing.Size(361, 95)
        Me.dataGrid.TabIndex = 368
        '
        'colExpressions
        '
        Me.colExpressions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colExpressions.HeaderText = "Expressions"
        Me.colExpressions.MinimumWidth = 8
        Me.colExpressions.Name = "colExpressions"
        '
        'ucrTxtMissingText
        '
        Me.ucrTxtMissingText.AddQuotesIfUnrecognised = True
        Me.ucrTxtMissingText.AutoSize = True
        Me.ucrTxtMissingText.IsMultiline = False
        Me.ucrTxtMissingText.IsReadOnly = False
        Me.ucrTxtMissingText.Location = New System.Drawing.Point(6, 27)
        Me.ucrTxtMissingText.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrTxtMissingText.Name = "ucrTxtMissingText"
        Me.ucrTxtMissingText.Size = New System.Drawing.Size(132, 21)
        Me.ucrTxtMissingText.TabIndex = 363
        '
        'ucrTableOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblExpressions)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSelectFormat)
        Me.Controls.Add(Me.btnAddFormatExpression)
        Me.Controls.Add(Me.lblMissingText)
        Me.Controls.Add(Me.ucrTxtMissingText)
        Me.Controls.Add(Me.btnAddReplaceNaExpression)
        Me.Name = "ucrTableOptions"
        Me.Size = New System.Drawing.Size(377, 252)
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMissingText As Label
    Friend WithEvents ucrTxtMissingText As ucrInputTextBox
    Friend WithEvents btnAddReplaceNaExpression As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cboSelectFormat As ComboBox
    Friend WithEvents btnAddFormatExpression As Button
    Friend WithEvents lblExpressions As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents dataGrid As DataGridView
    Friend WithEvents colExpressions As DataGridViewTextBoxColumn
End Class
