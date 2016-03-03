<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgStack
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.lblColumnsToBestack = New System.Windows.Forms.Label()
        Me.txtStackDataInto = New System.Windows.Forms.TextBox()
        Me.lblStackDataInto = New System.Windows.Forms.Label()
        Me.lblFactorInto = New System.Windows.Forms.Label()
        Me.txtFactorInto = New System.Windows.Forms.TextBox()
        Me.chkIDVariables = New System.Windows.Forms.CheckBox()
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.ucrNewDataFrameName = New instat.ucrVariableName()
        Me.ucrIDVariablesReceiver = New instat.ucrReceiverMultiple()
        Me.ucrSelectorStack = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverColumnsToBeStack = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'lblColumnsToBestack
        '
        Me.lblColumnsToBestack.AutoSize = True
        Me.lblColumnsToBestack.Location = New System.Drawing.Point(275, 4)
        Me.lblColumnsToBestack.Name = "lblColumnsToBestack"
        Me.lblColumnsToBestack.Size = New System.Drawing.Size(103, 13)
        Me.lblColumnsToBestack.TabIndex = 1
        Me.lblColumnsToBestack.Tag = "Columns_to_be_stack"
        Me.lblColumnsToBestack.Text = "Columns to be stack"
        '
        'txtStackDataInto
        '
        Me.txtStackDataInto.Location = New System.Drawing.Point(100, 253)
        Me.txtStackDataInto.Name = "txtStackDataInto"
        Me.txtStackDataInto.Size = New System.Drawing.Size(100, 20)
        Me.txtStackDataInto.TabIndex = 10
        Me.txtStackDataInto.Tag = ""
        '
        'lblStackDataInto
        '
        Me.lblStackDataInto.AutoSize = True
        Me.lblStackDataInto.Location = New System.Drawing.Point(7, 256)
        Me.lblStackDataInto.Name = "lblStackDataInto"
        Me.lblStackDataInto.Size = New System.Drawing.Size(79, 13)
        Me.lblStackDataInto.TabIndex = 9
        Me.lblStackDataInto.Tag = "Stack_data_into"
        Me.lblStackDataInto.Text = "Stack data into"
        '
        'lblFactorInto
        '
        Me.lblFactorInto.AutoSize = True
        Me.lblFactorInto.Location = New System.Drawing.Point(7, 230)
        Me.lblFactorInto.Name = "lblFactorInto"
        Me.lblFactorInto.Size = New System.Drawing.Size(57, 13)
        Me.lblFactorInto.TabIndex = 7
        Me.lblFactorInto.Tag = "Factor_into"
        Me.lblFactorInto.Text = "Factor into"
        '
        'txtFactorInto
        '
        Me.txtFactorInto.Location = New System.Drawing.Point(100, 227)
        Me.txtFactorInto.Name = "txtFactorInto"
        Me.txtFactorInto.Size = New System.Drawing.Size(100, 20)
        Me.txtFactorInto.TabIndex = 8
        '
        'chkIDVariables
        '
        Me.chkIDVariables.AutoSize = True
        Me.chkIDVariables.Location = New System.Drawing.Point(272, 133)
        Me.chkIDVariables.Name = "chkIDVariables"
        Me.chkIDVariables.Size = New System.Drawing.Size(83, 17)
        Me.chkIDVariables.TabIndex = 3
        Me.chkIDVariables.Tag = "ID_Variables"
        Me.chkIDVariables.Text = "ID Variables"
        Me.chkIDVariables.UseVisualStyleBackColor = True
        '
        'lblNewDataFrameName
        '
        Me.lblNewDataFrameName.AutoSize = True
        Me.lblNewDataFrameName.Location = New System.Drawing.Point(7, 202)
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        Me.lblNewDataFrameName.Size = New System.Drawing.Size(121, 13)
        Me.lblNewDataFrameName.TabIndex = 5
        Me.lblNewDataFrameName.Tag = "New_Data_Frame_Name:"
        Me.lblNewDataFrameName.Text = "New Data Frame Name:"
        '
        'ucrNewDataFrameName
        '
        Me.ucrNewDataFrameName.Location = New System.Drawing.Point(134, 198)
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        Me.ucrNewDataFrameName.Size = New System.Drawing.Size(132, 23)
        Me.ucrNewDataFrameName.TabIndex = 6
        '
        'ucrIDVariablesReceiver
        '
        Me.ucrIDVariablesReceiver.Location = New System.Drawing.Point(272, 156)
        Me.ucrIDVariablesReceiver.Name = "ucrIDVariablesReceiver"
        Me.ucrIDVariablesReceiver.Selector = Nothing
        Me.ucrIDVariablesReceiver.Size = New System.Drawing.Size(121, 113)
        Me.ucrIDVariablesReceiver.TabIndex = 4
        '
        'ucrSelectorStack
        '
        Me.ucrSelectorStack.Location = New System.Drawing.Point(1, 2)
        Me.ucrSelectorStack.Name = "ucrSelectorStack"
        Me.ucrSelectorStack.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorStack.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 344)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 65)
        Me.ucrBase.TabIndex = 11
        '
        'ucrReceiverColumnsToBeStack
        '
        Me.ucrReceiverColumnsToBeStack.Location = New System.Drawing.Point(272, 18)
        Me.ucrReceiverColumnsToBeStack.Name = "ucrReceiverColumnsToBeStack"
        Me.ucrReceiverColumnsToBeStack.Selector = Nothing
        Me.ucrReceiverColumnsToBeStack.Size = New System.Drawing.Size(121, 132)
        Me.ucrReceiverColumnsToBeStack.TabIndex = 2
        '
        'dlgStack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 398)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.ucrNewDataFrameName)
        Me.Controls.Add(Me.ucrIDVariablesReceiver)
        Me.Controls.Add(Me.chkIDVariables)
        Me.Controls.Add(Me.ucrSelectorStack)
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
        Me.Text = "Stack (melt) columns"
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
    Friend WithEvents ucrSelectorStack As ucrSelectorByDataFrameAddRemove
    Friend WithEvents chkIDVariables As CheckBox
    Friend WithEvents ucrIDVariablesReceiver As ucrReceiverMultiple
    Friend WithEvents ucrNewDataFrameName As ucrVariableName
    Friend WithEvents lblNewDataFrameName As Label
End Class
