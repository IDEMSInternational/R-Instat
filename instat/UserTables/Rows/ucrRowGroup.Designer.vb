<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrRowGroup
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dataGridGroups = New System.Windows.Forms.DataGridView()
        Me.btnClearGroups = New System.Windows.Forms.Button()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.btnAddCondition = New System.Windows.Forms.Button()
        Me.lblGroups = New System.Windows.Forms.Label()
        Me.lblGroupCondition = New System.Windows.Forms.Label()
        Me.cboConditionOperator = New System.Windows.Forms.ComboBox()
        Me.cboConditionValue = New System.Windows.Forms.ComboBox()
        Me.lblCondition = New System.Windows.Forms.Label()
        Me.ucrReceiverSingleCol = New instat.ucrReceiverSingle()
        Me.ucrSelectorCols = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputGroupLabel = New instat.ucrInputTextBox()
        Me.colLabel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodnition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFormat = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dataGridGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridGroups
        '
        Me.dataGridGroups.AllowUserToAddRows = False
        Me.dataGridGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridGroups.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLabel, Me.colCodnition, Me.colFormat})
        Me.dataGridGroups.Location = New System.Drawing.Point(229, 204)
        Me.dataGridGroups.Name = "dataGridGroups"
        Me.dataGridGroups.ReadOnly = True
        Me.dataGridGroups.RowHeadersWidth = 62
        Me.dataGridGroups.Size = New System.Drawing.Size(323, 95)
        Me.dataGridGroups.TabIndex = 11
        '
        'btnClearGroups
        '
        Me.btnClearGroups.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearGroups.Location = New System.Drawing.Point(467, 175)
        Me.btnClearGroups.Name = "btnClearGroups"
        Me.btnClearGroups.Size = New System.Drawing.Size(79, 23)
        Me.btnClearGroups.TabIndex = 30
        Me.btnClearGroups.Tag = ""
        Me.btnClearGroups.Text = "Clear"
        Me.btnClearGroups.UseVisualStyleBackColor = True
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(224, 11)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(45, 13)
        Me.lblColumns.TabIndex = 28
        Me.lblColumns.Text = "Column:"
        '
        'btnAddCondition
        '
        Me.btnAddCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAddCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddCondition.Location = New System.Drawing.Point(230, 153)
        Me.btnAddCondition.Name = "btnAddCondition"
        Me.btnAddCondition.Size = New System.Drawing.Size(96, 23)
        Me.btnAddCondition.TabIndex = 25
        Me.btnAddCondition.Tag = ""
        Me.btnAddCondition.Text = "Add"
        Me.btnAddCondition.UseVisualStyleBackColor = True
        '
        'lblGroups
        '
        Me.lblGroups.AutoSize = True
        Me.lblGroups.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroups.Location = New System.Drawing.Point(226, 185)
        Me.lblGroups.Name = "lblGroups"
        Me.lblGroups.Size = New System.Drawing.Size(44, 13)
        Me.lblGroups.TabIndex = 32
        Me.lblGroups.Text = "Groups:"
        '
        'lblGroupCondition
        '
        Me.lblGroupCondition.AutoSize = True
        Me.lblGroupCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroupCondition.Location = New System.Drawing.Point(227, 109)
        Me.lblGroupCondition.Name = "lblGroupCondition"
        Me.lblGroupCondition.Size = New System.Drawing.Size(86, 13)
        Me.lblGroupCondition.TabIndex = 33
        Me.lblGroupCondition.Text = "Group Condition:"
        '
        'cboConditionOperator
        '
        Me.cboConditionOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConditionOperator.FormattingEnabled = True
        Me.cboConditionOperator.Items.AddRange(New Object() {"==", "<", "<=", ">", ">=", "!=", "Expression"})
        Me.cboConditionOperator.Location = New System.Drawing.Point(229, 126)
        Me.cboConditionOperator.Name = "cboConditionOperator"
        Me.cboConditionOperator.Size = New System.Drawing.Size(78, 21)
        Me.cboConditionOperator.TabIndex = 279
        '
        'cboConditionValue
        '
        Me.cboConditionValue.FormattingEnabled = True
        Me.cboConditionValue.Location = New System.Drawing.Point(313, 126)
        Me.cboConditionValue.Name = "cboConditionValue"
        Me.cboConditionValue.Size = New System.Drawing.Size(106, 21)
        Me.cboConditionValue.TabIndex = 280
        '
        'lblCondition
        '
        Me.lblCondition.AutoSize = True
        Me.lblCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCondition.Location = New System.Drawing.Point(227, 58)
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Size = New System.Drawing.Size(68, 13)
        Me.lblCondition.TabIndex = 282
        Me.lblCondition.Text = "Group Label:"
        '
        'ucrReceiverSingleCol
        '
        Me.ucrReceiverSingleCol.AutoSize = True
        Me.ucrReceiverSingleCol.frmParent = Nothing
        Me.ucrReceiverSingleCol.Location = New System.Drawing.Point(226, 27)
        Me.ucrReceiverSingleCol.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleCol.Name = "ucrReceiverSingleCol"
        Me.ucrReceiverSingleCol.Selector = Nothing
        Me.ucrReceiverSingleCol.Size = New System.Drawing.Size(120, 21)
        Me.ucrReceiverSingleCol.strNcFilePath = ""
        Me.ucrReceiverSingleCol.TabIndex = 24
        Me.ucrReceiverSingleCol.ucrSelector = Nothing
        '
        'ucrSelectorCols
        '
        Me.ucrSelectorCols.AutoSize = True
        Me.ucrSelectorCols.bDropUnusedFilterLevels = False
        Me.ucrSelectorCols.bShowHiddenColumns = False
        Me.ucrSelectorCols.bUseCurrentFilter = True
        Me.ucrSelectorCols.Location = New System.Drawing.Point(3, 5)
        Me.ucrSelectorCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCols.Name = "ucrSelectorCols"
        Me.ucrSelectorCols.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorCols.TabIndex = 23
        '
        'ucrInputGroupLabel
        '
        Me.ucrInputGroupLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputGroupLabel.AutoSize = True
        Me.ucrInputGroupLabel.IsMultiline = False
        Me.ucrInputGroupLabel.IsReadOnly = False
        Me.ucrInputGroupLabel.Location = New System.Drawing.Point(226, 75)
        Me.ucrInputGroupLabel.Name = "ucrInputGroupLabel"
        Me.ucrInputGroupLabel.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputGroupLabel.TabIndex = 308
        '
        'colLabel
        '
        Me.colLabel.HeaderText = "Label"
        Me.colLabel.MinimumWidth = 8
        Me.colLabel.Name = "colLabel"
        Me.colLabel.ReadOnly = True
        Me.colLabel.Width = 80
        '
        'colCodnition
        '
        Me.colCodnition.HeaderText = "Condition"
        Me.colCodnition.MinimumWidth = 8
        Me.colCodnition.Name = "colCodnition"
        Me.colCodnition.ReadOnly = True
        Me.colCodnition.Width = 90
        '
        'colFormat
        '
        Me.colFormat.HeaderText = ""
        Me.colFormat.MinimumWidth = 8
        Me.colFormat.Name = "colFormat"
        Me.colFormat.ReadOnly = True
        Me.colFormat.Text = "Style"
        Me.colFormat.UseColumnTextForButtonValue = True
        Me.colFormat.Width = 55
        '
        'ucrRowGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputGroupLabel)
        Me.Controls.Add(Me.lblCondition)
        Me.Controls.Add(Me.cboConditionValue)
        Me.Controls.Add(Me.cboConditionOperator)
        Me.Controls.Add(Me.lblGroupCondition)
        Me.Controls.Add(Me.lblGroups)
        Me.Controls.Add(Me.btnClearGroups)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.btnAddCondition)
        Me.Controls.Add(Me.ucrReceiverSingleCol)
        Me.Controls.Add(Me.ucrSelectorCols)
        Me.Controls.Add(Me.dataGridGroups)
        Me.Name = "ucrRowGroup"
        Me.Size = New System.Drawing.Size(557, 301)
        CType(Me.dataGridGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataGridGroups As DataGridView
    Friend WithEvents ucrSelectorCols As ucrSelectorByDataFrameAddRemove
    Friend WithEvents btnClearGroups As Button
    Friend WithEvents lblColumns As Label
    Friend WithEvents btnAddCondition As Button
    Friend WithEvents ucrReceiverSingleCol As ucrReceiverSingle
    Friend WithEvents lblGroups As Label
    Friend WithEvents lblGroupCondition As Label
    Friend WithEvents cboConditionOperator As ComboBox
    Friend WithEvents cboConditionValue As ComboBox
    Friend WithEvents lblCondition As Label
    Friend WithEvents ucrInputGroupLabel As ucrInputTextBox
    Friend WithEvents colLabel As DataGridViewTextBoxColumn
    Friend WithEvents colCodnition As DataGridViewTextBoxColumn
    Friend WithEvents colFormat As DataGridViewButtonColumn
End Class
