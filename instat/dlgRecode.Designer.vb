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
        Me.chkWithALabel = New System.Windows.Forms.CheckBox()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.ucrRecodeRececeiver = New instat.ucrReceiverMultiple()
        Me.ucrRecodeSelector = New instat.ucrSelectorAddRemove()
        CType(Me.dgvRecode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRecode
        '
        Me.dgvRecode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecode.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RangeStart, Me.RangeEnd, Me.NewValue})
        Me.dgvRecode.Location = New System.Drawing.Point(343, 12)
        Me.dgvRecode.Name = "dgvRecode"
        Me.dgvRecode.Size = New System.Drawing.Size(330, 157)
        Me.dgvRecode.TabIndex = 0
        Me.dgvRecode.Tag = "Recode"
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
        Me.ucrBase.Location = New System.Drawing.Point(92, 203)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 1
        '
        'chkMakeResultFactor
        '
        Me.chkMakeResultFactor.AutoSize = True
        Me.chkMakeResultFactor.Location = New System.Drawing.Point(9, 173)
        Me.chkMakeResultFactor.Name = "chkMakeResultFactor"
        Me.chkMakeResultFactor.Size = New System.Drawing.Size(125, 17)
        Me.chkMakeResultFactor.TabIndex = 2
        Me.chkMakeResultFactor.Tag = "Make_Result_a_factor"
        Me.chkMakeResultFactor.Text = "Make Result a factor"
        Me.chkMakeResultFactor.UseVisualStyleBackColor = True
        '
        'chkWithALabel
        '
        Me.chkWithALabel.AutoSize = True
        Me.chkWithALabel.Location = New System.Drawing.Point(140, 173)
        Me.chkWithALabel.Name = "chkWithALabel"
        Me.chkWithALabel.Size = New System.Drawing.Size(86, 17)
        Me.chkWithALabel.TabIndex = 2
        Me.chkWithALabel.Tag = "With_a_Label"
        Me.chkWithALabel.Text = "With a Label"
        Me.chkWithALabel.UseVisualStyleBackColor = True
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(213, 3)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(95, 13)
        Me.lblSelectedVariables.TabIndex = 17
        Me.lblSelectedVariables.Text = "Selected Variables"
        '
        'ucrRecodeRececeiver
        '
        Me.ucrRecodeRececeiver.Location = New System.Drawing.Point(208, 22)
        Me.ucrRecodeRececeiver.Name = "ucrRecodeRececeiver"
        Me.ucrRecodeRececeiver.Size = New System.Drawing.Size(129, 131)
        Me.ucrRecodeRececeiver.TabIndex = 16
        '
        'ucrRecodeSelector
        '
        Me.ucrRecodeSelector.Location = New System.Drawing.Point(-5, 2)
        Me.ucrRecodeSelector.Name = "ucrRecodeSelector"
        Me.ucrRecodeSelector.Size = New System.Drawing.Size(207, 136)
        Me.ucrRecodeSelector.TabIndex = 15
        '
        'dlgRecode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 240)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrRecodeRececeiver)
        Me.Controls.Add(Me.ucrRecodeSelector)
        Me.Controls.Add(Me.chkWithALabel)
        Me.Controls.Add(Me.chkMakeResultFactor)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.dgvRecode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgRecode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Recode"
        Me.Text = "Recode"
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
    Friend WithEvents chkWithALabel As CheckBox
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents ucrRecodeRececeiver As ucrReceiverMultiple
    Friend WithEvents ucrRecodeSelector As ucrSelectorAddRemove
End Class
