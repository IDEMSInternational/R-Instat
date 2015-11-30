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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverUnstack = New instat.ucrReceiverMultiple()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.cboColumnToBeSplit = New System.Windows.Forms.ComboBox()
        Me.chkRowsDefinedBy = New System.Windows.Forms.CheckBox()
        Me.chkCarryFurtherColumns = New System.Windows.Forms.CheckBox()
        Me.cboUsingLevelsOf = New System.Windows.Forms.ComboBox()
        Me.lblInto = New System.Windows.Forms.Label()
        Me.lblColumnToBeSplit = New System.Windows.Forms.Label()
        Me.lblUsingLevelsOf = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 287)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(415, 36)
        Me.ucrBase.TabIndex = 0
        '
        'ucrReceiverUnstack
        '
        Me.ucrReceiverUnstack.Location = New System.Drawing.Point(228, 37)
        Me.ucrReceiverUnstack.Name = "ucrReceiverUnstack"
        Me.ucrReceiverUnstack.Size = New System.Drawing.Size(121, 103)
        Me.ucrReceiverUnstack.TabIndex = 1
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(12, 13)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 2
        '
        'cboColumnToBeSplit
        '
        Me.cboColumnToBeSplit.FormattingEnabled = True
        Me.cboColumnToBeSplit.Location = New System.Drawing.Point(12, 178)
        Me.cboColumnToBeSplit.Name = "cboColumnToBeSplit"
        Me.cboColumnToBeSplit.Size = New System.Drawing.Size(121, 21)
        Me.cboColumnToBeSplit.TabIndex = 3
        '
        'chkRowsDefinedBy
        '
        Me.chkRowsDefinedBy.AutoSize = True
        Me.chkRowsDefinedBy.Location = New System.Drawing.Point(228, 161)
        Me.chkRowsDefinedBy.Name = "chkRowsDefinedBy"
        Me.chkRowsDefinedBy.Size = New System.Drawing.Size(105, 17)
        Me.chkRowsDefinedBy.TabIndex = 4
        Me.chkRowsDefinedBy.Tag = "Rows_defined_by"
        Me.chkRowsDefinedBy.Text = "Rows defined by"
        Me.chkRowsDefinedBy.UseVisualStyleBackColor = True
        '
        'chkCarryFurtherColumns
        '
        Me.chkCarryFurtherColumns.AutoSize = True
        Me.chkCarryFurtherColumns.Location = New System.Drawing.Point(228, 202)
        Me.chkCarryFurtherColumns.Name = "chkCarryFurtherColumns"
        Me.chkCarryFurtherColumns.Size = New System.Drawing.Size(125, 17)
        Me.chkCarryFurtherColumns.TabIndex = 4
        Me.chkCarryFurtherColumns.Tag = "Carry_further_columns"
        Me.chkCarryFurtherColumns.Text = "Carry further columns"
        Me.chkCarryFurtherColumns.UseVisualStyleBackColor = True
        '
        'cboUsingLevelsOf
        '
        Me.cboUsingLevelsOf.FormattingEnabled = True
        Me.cboUsingLevelsOf.Location = New System.Drawing.Point(12, 243)
        Me.cboUsingLevelsOf.Name = "cboUsingLevelsOf"
        Me.cboUsingLevelsOf.Size = New System.Drawing.Size(121, 21)
        Me.cboUsingLevelsOf.TabIndex = 3
        '
        'lblInto
        '
        Me.lblInto.AutoSize = True
        Me.lblInto.Location = New System.Drawing.Point(225, 21)
        Me.lblInto.Name = "lblInto"
        Me.lblInto.Size = New System.Drawing.Size(25, 13)
        Me.lblInto.TabIndex = 5
        Me.lblInto.Tag = "Into"
        Me.lblInto.Text = "Into"
        '
        'lblColumnToBeSplit
        '
        Me.lblColumnToBeSplit.AutoSize = True
        Me.lblColumnToBeSplit.Location = New System.Drawing.Point(9, 143)
        Me.lblColumnToBeSplit.Name = "lblColumnToBeSplit"
        Me.lblColumnToBeSplit.Size = New System.Drawing.Size(90, 13)
        Me.lblColumnToBeSplit.TabIndex = 6
        Me.lblColumnToBeSplit.Tag = "Column_to_be_split"
        Me.lblColumnToBeSplit.Text = "Column to be split"
        '
        'lblUsingLevelsOf
        '
        Me.lblUsingLevelsOf.AutoSize = True
        Me.lblUsingLevelsOf.Location = New System.Drawing.Point(9, 218)
        Me.lblUsingLevelsOf.Name = "lblUsingLevelsOf"
        Me.lblUsingLevelsOf.Size = New System.Drawing.Size(76, 13)
        Me.lblUsingLevelsOf.TabIndex = 6
        Me.lblUsingLevelsOf.Tag = "Using_levels_of"
        Me.lblUsingLevelsOf.Text = "Using levels of"
        '
        'dlgUnstack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 335)
        Me.Controls.Add(Me.lblUsingLevelsOf)
        Me.Controls.Add(Me.lblColumnToBeSplit)
        Me.Controls.Add(Me.lblInto)
        Me.Controls.Add(Me.chkCarryFurtherColumns)
        Me.Controls.Add(Me.chkRowsDefinedBy)
        Me.Controls.Add(Me.cboUsingLevelsOf)
        Me.Controls.Add(Me.cboColumnToBeSplit)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrReceiverUnstack)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgUnstack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Unstack _split_columns"
        Me.Text = "Unstack (split) columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverUnstack As ucrReceiverMultiple
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents cboColumnToBeSplit As ComboBox
    Friend WithEvents chkRowsDefinedBy As CheckBox
    Friend WithEvents chkCarryFurtherColumns As CheckBox
    Friend WithEvents cboUsingLevelsOf As ComboBox
    Friend WithEvents lblInto As Label
    Friend WithEvents lblColumnToBeSplit As Label
    Friend WithEvents lblUsingLevelsOf As Label
End Class
