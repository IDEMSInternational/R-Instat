<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgUnstack
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
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.UcrReceiverUnstack = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.chkRowsDefinedBy = New System.Windows.Forms.CheckBox()
        Me.chkCarryFurtherColumns = New System.Windows.Forms.CheckBox()
        Me.lblColumnToBeSplit = New System.Windows.Forms.Label()
        Me.lblInto = New System.Windows.Forms.Label()
        Me.lblUsingLevelsOf = New System.Windows.Forms.Label()
        Me.txtInto = New System.Windows.Forms.TextBox()
        Me.txtUsingLevelsOf = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(0, 0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 0
        '
        'UcrReceiverUnstack
        '
        Me.UcrReceiverUnstack.Location = New System.Drawing.Point(245, 22)
        Me.UcrReceiverUnstack.Name = "UcrReceiverUnstack"
        Me.UcrReceiverUnstack.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverUnstack.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(0, 246)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 2
        '
        'chkRowsDefinedBy
        '
        Me.chkRowsDefinedBy.AutoSize = True
        Me.chkRowsDefinedBy.Location = New System.Drawing.Point(12, 157)
        Me.chkRowsDefinedBy.Name = "chkRowsDefinedBy"
        Me.chkRowsDefinedBy.Size = New System.Drawing.Size(105, 17)
        Me.chkRowsDefinedBy.TabIndex = 3
        Me.chkRowsDefinedBy.Tag = "Rows_defined_by"
        Me.chkRowsDefinedBy.Text = "Rows defined by"
        Me.chkRowsDefinedBy.UseVisualStyleBackColor = True
        '
        'chkCarryFurtherColumns
        '
        Me.chkCarryFurtherColumns.AutoSize = True
        Me.chkCarryFurtherColumns.Location = New System.Drawing.Point(12, 203)
        Me.chkCarryFurtherColumns.Name = "chkCarryFurtherColumns"
        Me.chkCarryFurtherColumns.Size = New System.Drawing.Size(125, 17)
        Me.chkCarryFurtherColumns.TabIndex = 3
        Me.chkCarryFurtherColumns.Tag = "Carry_Further_Columns"
        Me.chkCarryFurtherColumns.Text = "Carry further columns"
        Me.chkCarryFurtherColumns.UseVisualStyleBackColor = True
        '
        'lblColumnToBeSplit
        '
        Me.lblColumnToBeSplit.AutoSize = True
        Me.lblColumnToBeSplit.Location = New System.Drawing.Point(254, 0)
        Me.lblColumnToBeSplit.Name = "lblColumnToBeSplit"
        Me.lblColumnToBeSplit.Size = New System.Drawing.Size(90, 13)
        Me.lblColumnToBeSplit.TabIndex = 4
        Me.lblColumnToBeSplit.Tag = "Column_to_be_split"
        Me.lblColumnToBeSplit.Text = "Column to be split"
        '
        'lblInto
        '
        Me.lblInto.AutoSize = True
        Me.lblInto.Location = New System.Drawing.Point(251, 74)
        Me.lblInto.Name = "lblInto"
        Me.lblInto.Size = New System.Drawing.Size(25, 13)
        Me.lblInto.TabIndex = 4
        Me.lblInto.Tag = "Into"
        Me.lblInto.Text = "Into"
        '
        'lblUsingLevelsOf
        '
        Me.lblUsingLevelsOf.AutoSize = True
        Me.lblUsingLevelsOf.Location = New System.Drawing.Point(251, 161)
        Me.lblUsingLevelsOf.Name = "lblUsingLevelsOf"
        Me.lblUsingLevelsOf.Size = New System.Drawing.Size(76, 13)
        Me.lblUsingLevelsOf.TabIndex = 4
        Me.lblUsingLevelsOf.Tag = "Using_levels_of"
        Me.lblUsingLevelsOf.Text = "Using levels of"
        '
        'txtInto
        '
        Me.txtInto.Location = New System.Drawing.Point(245, 106)
        Me.txtInto.Name = "txtInto"
        Me.txtInto.Size = New System.Drawing.Size(100, 20)
        Me.txtInto.TabIndex = 5
        '
        'txtUsingLevelsOf
        '
        Me.txtUsingLevelsOf.Location = New System.Drawing.Point(245, 200)
        Me.txtUsingLevelsOf.Name = "txtUsingLevelsOf"
        Me.txtUsingLevelsOf.Size = New System.Drawing.Size(100, 20)
        Me.txtUsingLevelsOf.TabIndex = 5
        '
        'dlgUnstack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 290)
        Me.Controls.Add(Me.txtUsingLevelsOf)
        Me.Controls.Add(Me.txtInto)
        Me.Controls.Add(Me.lblUsingLevelsOf)
        Me.Controls.Add(Me.lblInto)
        Me.Controls.Add(Me.lblColumnToBeSplit)
        Me.Controls.Add(Me.chkCarryFurtherColumns)
        Me.Controls.Add(Me.chkRowsDefinedBy)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.UcrReceiverUnstack)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgUnstack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Unstack_split_columns"
        Me.Text = "Unstack(Split) columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents UcrReceiverUnstack As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkRowsDefinedBy As CheckBox
    Friend WithEvents chkCarryFurtherColumns As CheckBox
    Friend WithEvents lblColumnToBeSplit As Label
    Friend WithEvents lblInto As Label
    Friend WithEvents lblUsingLevelsOf As Label
    Friend WithEvents txtInto As TextBox
    Friend WithEvents txtUsingLevelsOf As TextBox
End Class
