<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgStack
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
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverStack = New instat.ucrReceiverMultiple()
        Me.lblVariablesToBestack = New System.Windows.Forms.Label()
        Me.txtStackDataInto = New System.Windows.Forms.TextBox()
        Me.chkRepeatColumns = New System.Windows.Forms.CheckBox()
        Me.chkFactor = New System.Windows.Forms.CheckBox()
        Me.chkOmitValue = New System.Windows.Forms.CheckBox()
        Me.lblStackDataInto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 245)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(426, 41)
        Me.ucrBase.TabIndex = 0
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(12, 12)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 1
        '
        'ucrReceiverStack
        '
        Me.ucrReceiverStack.Location = New System.Drawing.Point(241, 37)
        Me.ucrReceiverStack.Name = "ucrReceiverStack"
        Me.ucrReceiverStack.Size = New System.Drawing.Size(121, 114)
        Me.ucrReceiverStack.TabIndex = 2
        '
        'lblVariablesToBestack
        '
        Me.lblVariablesToBestack.AutoSize = True
        Me.lblVariablesToBestack.Location = New System.Drawing.Point(249, 9)
        Me.lblVariablesToBestack.Name = "lblVariablesToBestack"
        Me.lblVariablesToBestack.Size = New System.Drawing.Size(106, 13)
        Me.lblVariablesToBestack.TabIndex = 3
        Me.lblVariablesToBestack.Tag = "Variables_to_be_stack"
        Me.lblVariablesToBestack.Text = "Variables to be stack"
        '
        'txtStackDataInto
        '
        Me.txtStackDataInto.Location = New System.Drawing.Point(12, 186)
        Me.txtStackDataInto.Name = "txtStackDataInto"
        Me.txtStackDataInto.Size = New System.Drawing.Size(100, 20)
        Me.txtStackDataInto.TabIndex = 4
        '
        'chkRepeatColumns
        '
        Me.chkRepeatColumns.AutoSize = True
        Me.chkRepeatColumns.Location = New System.Drawing.Point(12, 212)
        Me.chkRepeatColumns.Name = "chkRepeatColumns"
        Me.chkRepeatColumns.Size = New System.Drawing.Size(103, 17)
        Me.chkRepeatColumns.TabIndex = 5
        Me.chkRepeatColumns.Tag = "Repeat_columns"
        Me.chkRepeatColumns.Text = "Repeat columns"
        Me.chkRepeatColumns.UseVisualStyleBackColor = True
        '
        'chkFactor
        '
        Me.chkFactor.AutoSize = True
        Me.chkFactor.Location = New System.Drawing.Point(241, 174)
        Me.chkFactor.Name = "chkFactor"
        Me.chkFactor.Size = New System.Drawing.Size(56, 17)
        Me.chkFactor.TabIndex = 5
        Me.chkFactor.Tag = "Factor"
        Me.chkFactor.Text = "Factor"
        Me.chkFactor.UseVisualStyleBackColor = True
        '
        'chkOmitValue
        '
        Me.chkOmitValue.AutoSize = True
        Me.chkOmitValue.Location = New System.Drawing.Point(241, 212)
        Me.chkOmitValue.Name = "chkOmitValue"
        Me.chkOmitValue.Size = New System.Drawing.Size(76, 17)
        Me.chkOmitValue.TabIndex = 5
        Me.chkOmitValue.Tag = "Omit_value"
        Me.chkOmitValue.Text = "Omit value"
        Me.chkOmitValue.UseVisualStyleBackColor = True
        '
        'lblStackDataInto
        '
        Me.lblStackDataInto.AutoSize = True
        Me.lblStackDataInto.Location = New System.Drawing.Point(12, 154)
        Me.lblStackDataInto.Name = "lblStackDataInto"
        Me.lblStackDataInto.Size = New System.Drawing.Size(79, 13)
        Me.lblStackDataInto.TabIndex = 3
        Me.lblStackDataInto.Tag = "Stack_data_into"
        Me.lblStackDataInto.Text = "Stack data into"
        '
        'dlgStack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 298)
        Me.Controls.Add(Me.chkOmitValue)
        Me.Controls.Add(Me.chkFactor)
        Me.Controls.Add(Me.chkRepeatColumns)
        Me.Controls.Add(Me.txtStackDataInto)
        Me.Controls.Add(Me.lblStackDataInto)
        Me.Controls.Add(Me.lblVariablesToBestack)
        Me.Controls.Add(Me.ucrReceiverStack)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgStack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Stack_join_columns"
        Me.Text = "Stack (Join) columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverStack As ucrReceiverMultiple
    Friend WithEvents lblVariablesToBestack As Label
    Friend WithEvents txtStackDataInto As TextBox
    Friend WithEvents chkRepeatColumns As CheckBox
    Friend WithEvents chkFactor As CheckBox
    Friend WithEvents chkOmitValue As CheckBox
    Friend WithEvents lblStackDataInto As Label
End Class
