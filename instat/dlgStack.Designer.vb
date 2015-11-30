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
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverStack = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.chkFactor = New System.Windows.Forms.CheckBox()
        Me.chkOmitValue = New System.Windows.Forms.CheckBox()
        Me.chkRepeatColumns = New System.Windows.Forms.CheckBox()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.lblStackDataInto = New System.Windows.Forms.Label()
        Me.txtStackDataInto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(12, 12)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 0
        '
        'ucrReceiverStack
        '
        Me.ucrReceiverStack.Location = New System.Drawing.Point(246, 32)
        Me.ucrReceiverStack.Name = "ucrReceiverStack"
        Me.ucrReceiverStack.Size = New System.Drawing.Size(121, 93)
        Me.ucrReceiverStack.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 260)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 2
        '
        'chkFactor
        '
        Me.chkFactor.AutoSize = True
        Me.chkFactor.Location = New System.Drawing.Point(246, 179)
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
        Me.chkOmitValue.Location = New System.Drawing.Point(246, 217)
        Me.chkOmitValue.Name = "chkOmitValue"
        Me.chkOmitValue.Size = New System.Drawing.Size(77, 17)
        Me.chkOmitValue.TabIndex = 5
        Me.chkOmitValue.Tag = "Omit_value"
        Me.chkOmitValue.Text = "Omit Value"
        Me.chkOmitValue.UseVisualStyleBackColor = True
        '
        'chkRepeatColumns
        '
        Me.chkRepeatColumns.AutoSize = True
        Me.chkRepeatColumns.Location = New System.Drawing.Point(12, 217)
        Me.chkRepeatColumns.Name = "chkRepeatColumns"
        Me.chkRepeatColumns.Size = New System.Drawing.Size(104, 17)
        Me.chkRepeatColumns.TabIndex = 5
        Me.chkRepeatColumns.Tag = "Repeat_Columns"
        Me.chkRepeatColumns.Text = "Repeat Columns"
        Me.chkRepeatColumns.UseVisualStyleBackColor = True
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(243, 12)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(95, 13)
        Me.lblSelectedVariables.TabIndex = 6
        Me.lblSelectedVariables.Tag = "Selected_Variables"
        Me.lblSelectedVariables.Text = "Selected Variables"
        '
        'lblStackDataInto
        '
        Me.lblStackDataInto.AutoSize = True
        Me.lblStackDataInto.Location = New System.Drawing.Point(9, 163)
        Me.lblStackDataInto.Name = "lblStackDataInto"
        Me.lblStackDataInto.Size = New System.Drawing.Size(79, 13)
        Me.lblStackDataInto.TabIndex = 7
        Me.lblStackDataInto.Tag = "Stack_data_into"
        Me.lblStackDataInto.Text = "Stack data into"
        '
        'txtStackDataInto
        '
        Me.txtStackDataInto.Location = New System.Drawing.Point(12, 179)
        Me.txtStackDataInto.Name = "txtStackDataInto"
        Me.txtStackDataInto.Size = New System.Drawing.Size(100, 20)
        Me.txtStackDataInto.TabIndex = 8
        '
        'dlgStack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 304)
        Me.Controls.Add(Me.txtStackDataInto)
        Me.Controls.Add(Me.lblStackDataInto)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.chkRepeatColumns)
        Me.Controls.Add(Me.chkOmitValue)
        Me.Controls.Add(Me.chkFactor)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverStack)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgStack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Stack_join_column"
        Me.Text = "Stack (Join) column"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverStack As ucrReceiverMultiple
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkFactor As CheckBox
    Friend WithEvents chkOmitValue As CheckBox
    Friend WithEvents chkRepeatColumns As CheckBox
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents lblStackDataInto As Label
    Friend WithEvents txtStackDataInto As TextBox
End Class
