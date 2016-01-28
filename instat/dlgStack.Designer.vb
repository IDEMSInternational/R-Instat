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
        Me.lblColumnsToBestack = New System.Windows.Forms.Label()
        Me.txtStackDataInto = New System.Windows.Forms.TextBox()
        Me.lblStackDataInto = New System.Windows.Forms.Label()
        Me.lblFactorInto = New System.Windows.Forms.Label()
        Me.txtFactorInto = New System.Windows.Forms.TextBox()
        Me.chkIDVariables = New System.Windows.Forms.CheckBox()
        Me.ucrNewColumnName = New instat.ucrNewColumnName()
        Me.ucrIDVariablesReceiver = New instat.ucrReceiverMultiple()
        Me.ucrDataFrameAddRemove = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverColumnsToBeStack = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'lblColumnsToBestack
        '
        Me.lblColumnsToBestack.AutoSize = True
        Me.lblColumnsToBestack.Location = New System.Drawing.Point(258, 12)
        Me.lblColumnsToBestack.Name = "lblColumnsToBestack"
        Me.lblColumnsToBestack.Size = New System.Drawing.Size(103, 13)
        Me.lblColumnsToBestack.TabIndex = 3
        Me.lblColumnsToBestack.Tag = "Columns_to_be_stack"
        Me.lblColumnsToBestack.Text = "Columns to be stack"
        '
        'txtStackDataInto
        '
        Me.txtStackDataInto.Location = New System.Drawing.Point(118, 223)
        Me.txtStackDataInto.Name = "txtStackDataInto"
        Me.txtStackDataInto.Size = New System.Drawing.Size(100, 20)
        Me.txtStackDataInto.TabIndex = 4
        Me.txtStackDataInto.Tag = ""
        '
        'lblStackDataInto
        '
        Me.lblStackDataInto.AutoSize = True
        Me.lblStackDataInto.Location = New System.Drawing.Point(25, 230)
        Me.lblStackDataInto.Name = "lblStackDataInto"
        Me.lblStackDataInto.Size = New System.Drawing.Size(79, 13)
        Me.lblStackDataInto.TabIndex = 3
        Me.lblStackDataInto.Tag = "Stack_data_into"
        Me.lblStackDataInto.Text = "Stack data into"
        '
        'lblFactorInto
        '
        Me.lblFactorInto.AutoSize = True
        Me.lblFactorInto.Location = New System.Drawing.Point(25, 204)
        Me.lblFactorInto.Name = "lblFactorInto"
        Me.lblFactorInto.Size = New System.Drawing.Size(57, 13)
        Me.lblFactorInto.TabIndex = 9
        Me.lblFactorInto.Tag = "Factor_into"
        Me.lblFactorInto.Text = "Factor into"
        '
        'txtFactorInto
        '
        Me.txtFactorInto.Location = New System.Drawing.Point(118, 197)
        Me.txtFactorInto.Name = "txtFactorInto"
        Me.txtFactorInto.Size = New System.Drawing.Size(100, 20)
        Me.txtFactorInto.TabIndex = 4
        '
        'chkIDVariables
        '
        Me.chkIDVariables.AutoSize = True
        Me.chkIDVariables.Location = New System.Drawing.Point(264, 167)
        Me.chkIDVariables.Name = "chkIDVariables"
        Me.chkIDVariables.Size = New System.Drawing.Size(83, 17)
        Me.chkIDVariables.TabIndex = 13
        Me.chkIDVariables.Tag = "ID_Variables"
        Me.chkIDVariables.Text = "ID Variables"
        Me.chkIDVariables.UseVisualStyleBackColor = True
        '
        'ucrNewColumnName
        '
        Me.ucrNewColumnName.Location = New System.Drawing.Point(17, 322)
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        Me.ucrNewColumnName.Size = New System.Drawing.Size(367, 35)
        Me.ucrNewColumnName.TabIndex = 15
        '
        'ucrIDVariablesReceiver
        '
        Me.ucrIDVariablesReceiver.Location = New System.Drawing.Point(264, 191)
        Me.ucrIDVariablesReceiver.Name = "ucrIDVariablesReceiver"
        Me.ucrIDVariablesReceiver.Size = New System.Drawing.Size(121, 128)
        Me.ucrIDVariablesReceiver.TabIndex = 14
        '
        'ucrDataFrameAddRemove
        '
        Me.ucrDataFrameAddRemove.Location = New System.Drawing.Point(15, 12)
        Me.ucrDataFrameAddRemove.Name = "ucrDataFrameAddRemove"
        Me.ucrDataFrameAddRemove.Size = New System.Drawing.Size(242, 179)
        Me.ucrDataFrameAddRemove.TabIndex = 12
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(15, 374)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 11
        '
        'ucrReceiverColumnsToBeStack
        '
        Me.ucrReceiverColumnsToBeStack.Location = New System.Drawing.Point(264, 28)
        Me.ucrReceiverColumnsToBeStack.Name = "ucrReceiverColumnsToBeStack"
        Me.ucrReceiverColumnsToBeStack.Size = New System.Drawing.Size(121, 132)
        Me.ucrReceiverColumnsToBeStack.TabIndex = 2
        '
        'dlgStack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 429)
        Me.Controls.Add(Me.ucrNewColumnName)
        Me.Controls.Add(Me.ucrIDVariablesReceiver)
        Me.Controls.Add(Me.chkIDVariables)
        Me.Controls.Add(Me.ucrDataFrameAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblFactorInto)
        Me.Controls.Add(Me.txtFactorInto)
        Me.Controls.Add(Me.txtStackDataInto)
        Me.Controls.Add(Me.lblStackDataInto)
        Me.Controls.Add(Me.lblColumnsToBestack)
        Me.Controls.Add(Me.ucrReceiverColumnsToBeStack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgStack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Stack_join_columns"
        Me.Text = "Stack (Join) columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverColumnsToBeStack As ucrReceiverMultiple
    Friend WithEvents lblColumnsToBestack As Label
    Friend WithEvents txtStackDataInto As TextBox
    Friend WithEvents lblStackDataInto As Label
    Friend WithEvents lblFactorInto As Label
    Friend WithEvents txtFactorInto As TextBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameAddRemove As ucrSelectorByDataFrameAddRemove
    Friend WithEvents chkIDVariables As CheckBox
    Friend WithEvents ucrIDVariablesReceiver As ucrReceiverMultiple
    Friend WithEvents ucrNewColumnName As ucrNewColumnName
End Class
