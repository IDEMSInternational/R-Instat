<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRecode
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
        Me.dgvRecode = New System.Windows.Forms.DataGridView()
        Me.RangeStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RangeEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ucrBase = New instat.ucrButtons()
        Me.chkMakeResultFactor = New System.Windows.Forms.CheckBox()
        Me.chkWithaLabel = New System.Windows.Forms.CheckBox()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.ucrSelectorAddRemove = New instat.ucrSelectorAddRemove()
        CType(Me.dgvRecode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRecode
        '
        Me.dgvRecode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecode.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RangeStart, Me.RangeEnd, Me.NewValue})
        Me.dgvRecode.Location = New System.Drawing.Point(320, 10)
        Me.dgvRecode.Name = "dgvRecode"
        Me.dgvRecode.Size = New System.Drawing.Size(303, 157)
        Me.dgvRecode.TabIndex = 0
        '
        'RangeStart
        '
        Me.RangeStart.HeaderText = "Range Start"
        Me.RangeStart.Name = "RangeStart"
        '
        'RangeEnd
        '
        Me.RangeEnd.HeaderText = "RangeEnd"
        Me.RangeEnd.Name = "RangeEnd"
        '
        'NewValue
        '
        Me.NewValue.HeaderText = "New Value "
        Me.NewValue.Name = "NewValue"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(92, 221)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 1
        '
        'chkMakeResultFactor
        '
        Me.chkMakeResultFactor.AutoSize = True
        Me.chkMakeResultFactor.Location = New System.Drawing.Point(12, 198)
        Me.chkMakeResultFactor.Name = "chkMakeResultFactor"
        Me.chkMakeResultFactor.Size = New System.Drawing.Size(125, 17)
        Me.chkMakeResultFactor.TabIndex = 2
        Me.chkMakeResultFactor.Tag = "Make_Result_a_factor"
        Me.chkMakeResultFactor.Text = "Make Result a factor"
        Me.chkMakeResultFactor.UseVisualStyleBackColor = True
        '
        'chkWithaLabel
        '
        Me.chkWithaLabel.AutoSize = True
        Me.chkWithaLabel.Location = New System.Drawing.Point(143, 198)
        Me.chkWithaLabel.Name = "chkWithaLabel"
        Me.chkWithaLabel.Size = New System.Drawing.Size(86, 17)
        Me.chkWithaLabel.TabIndex = 2
        Me.chkWithaLabel.Tag = "With_a_Label"
        Me.chkWithaLabel.Text = "With a Label"
        Me.chkWithaLabel.UseVisualStyleBackColor = True
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(169, 12)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(95, 13)
        Me.lblSelectedVariables.TabIndex = 17
        Me.lblSelectedVariables.Text = "Selected Variables"
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(189, 25)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(124, 142)
        Me.ucrReceiverMultiple.TabIndex = 16
        '
        'ucrSelectorAddRemove
        '
        Me.ucrSelectorAddRemove.Location = New System.Drawing.Point(1, 12)
        Me.ucrSelectorAddRemove.Name = "ucrSelectorAddRemove"
        Me.ucrSelectorAddRemove.Size = New System.Drawing.Size(197, 155)
        Me.ucrSelectorAddRemove.TabIndex = 15
        '
        'dlgRecode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 256)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrReceiverMultiple)
        Me.Controls.Add(Me.ucrSelectorAddRemove)
        Me.Controls.Add(Me.chkWithaLabel)
        Me.Controls.Add(Me.chkMakeResultFactor)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.dgvRecode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgRecode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dlgRecode"
        CType(Me.dgvRecode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRecode As DataGridView
    Friend WithEvents RangeStart As DataGridViewTextBoxColumn
    Friend WithEvents RangeEnd As DataGridViewTextBoxColumn
    Friend WithEvents NewValue As DataGridViewTextBoxColumn
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkMakeResultFactor As CheckBox
    Friend WithEvents chkWithaLabel As CheckBox
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents ucrReceiverMultiple As ucrReceiverMultiple
    Friend WithEvents ucrSelectorAddRemove As ucrSelectorAddRemove
End Class
