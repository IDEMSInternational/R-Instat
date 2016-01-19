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
        Me.ucrReceiverColumnsToBeStack = New instat.ucrReceiverMultiple()
        Me.lblColumnsToBestack = New System.Windows.Forms.Label()
        Me.txtStackDataInto = New System.Windows.Forms.TextBox()
        Me.chkOmitValue = New System.Windows.Forms.CheckBox()
        Me.lblStackDataInto = New System.Windows.Forms.Label()
        Me.ucrDataFrameStack = New instat.ucrDataFrame()
        Me.ucrReceiverIdVariable = New instat.ucrReceiverSingle()
        Me.lblIdVariable = New System.Windows.Forms.Label()
        Me.lblFactorInto = New System.Windows.Forms.Label()
        Me.txtFactorInto = New System.Windows.Forms.TextBox()
        Me.grpOutputOptions = New System.Windows.Forms.GroupBox()
        Me.rdoNewWorksheet = New System.Windows.Forms.RadioButton()
        Me.lblSheetName = New System.Windows.Forms.Label()
        Me.rdoExistingWorksheet = New System.Windows.Forms.RadioButton()
        Me.txtSheetName = New System.Windows.Forms.TextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFrameAddRemove = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpOutputOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrReceiverColumnsToBeStack
        '
        Me.ucrReceiverColumnsToBeStack.Location = New System.Drawing.Point(261, 68)
        Me.ucrReceiverColumnsToBeStack.Name = "ucrReceiverColumnsToBeStack"
        Me.ucrReceiverColumnsToBeStack.Size = New System.Drawing.Size(121, 111)
        Me.ucrReceiverColumnsToBeStack.TabIndex = 2
        '
        'lblColumnsToBestack
        '
        Me.lblColumnsToBestack.AutoSize = True
        Me.lblColumnsToBestack.Location = New System.Drawing.Point(258, 52)
        Me.lblColumnsToBestack.Name = "lblColumnsToBestack"
        Me.lblColumnsToBestack.Size = New System.Drawing.Size(103, 13)
        Me.lblColumnsToBestack.TabIndex = 3
        Me.lblColumnsToBestack.Tag = "Columns_to_be_stack"
        Me.lblColumnsToBestack.Text = "Columns to be stack"
        '
        'txtStackDataInto
        '
        Me.txtStackDataInto.Location = New System.Drawing.Point(118, 263)
        Me.txtStackDataInto.Name = "txtStackDataInto"
        Me.txtStackDataInto.Size = New System.Drawing.Size(100, 20)
        Me.txtStackDataInto.TabIndex = 4
        Me.txtStackDataInto.Tag = ""
        '
        'chkOmitValue
        '
        Me.chkOmitValue.AutoSize = True
        Me.chkOmitValue.Location = New System.Drawing.Point(21, 286)
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
        Me.lblStackDataInto.Location = New System.Drawing.Point(18, 270)
        Me.lblStackDataInto.Name = "lblStackDataInto"
        Me.lblStackDataInto.Size = New System.Drawing.Size(79, 13)
        Me.lblStackDataInto.TabIndex = 3
        Me.lblStackDataInto.Tag = "Stack_data_into"
        Me.lblStackDataInto.Text = "Stack data into"
        '
        'ucrDataFrameStack
        '
        Me.ucrDataFrameStack.Location = New System.Drawing.Point(12, 10)
        Me.ucrDataFrameStack.Name = "ucrDataFrameStack"
        Me.ucrDataFrameStack.Size = New System.Drawing.Size(150, 57)
        Me.ucrDataFrameStack.TabIndex = 6
        '
        'ucrReceiverIdVariable
        '
        Me.ucrReceiverIdVariable.Location = New System.Drawing.Point(261, 228)
        Me.ucrReceiverIdVariable.Name = "ucrReceiverIdVariable"
        Me.ucrReceiverIdVariable.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverIdVariable.TabIndex = 7
        '
        'lblIdVariable
        '
        Me.lblIdVariable.AutoSize = True
        Me.lblIdVariable.Location = New System.Drawing.Point(258, 212)
        Me.lblIdVariable.Name = "lblIdVariable"
        Me.lblIdVariable.Size = New System.Drawing.Size(58, 13)
        Me.lblIdVariable.TabIndex = 8
        Me.lblIdVariable.Tag = "ID_variable"
        Me.lblIdVariable.Text = "ID variable"
        '
        'lblFactorInto
        '
        Me.lblFactorInto.AutoSize = True
        Me.lblFactorInto.Location = New System.Drawing.Point(18, 244)
        Me.lblFactorInto.Name = "lblFactorInto"
        Me.lblFactorInto.Size = New System.Drawing.Size(57, 13)
        Me.lblFactorInto.TabIndex = 9
        Me.lblFactorInto.Tag = "Factor_into"
        Me.lblFactorInto.Text = "Factor into"
        '
        'txtFactorInto
        '
        Me.txtFactorInto.Location = New System.Drawing.Point(118, 237)
        Me.txtFactorInto.Name = "txtFactorInto"
        Me.txtFactorInto.Size = New System.Drawing.Size(100, 20)
        Me.txtFactorInto.TabIndex = 4
        '
        'grpOutputOptions
        '
        Me.grpOutputOptions.Controls.Add(Me.rdoNewWorksheet)
        Me.grpOutputOptions.Controls.Add(Me.lblSheetName)
        Me.grpOutputOptions.Controls.Add(Me.rdoExistingWorksheet)
        Me.grpOutputOptions.Controls.Add(Me.txtSheetName)
        Me.grpOutputOptions.Location = New System.Drawing.Point(12, 309)
        Me.grpOutputOptions.Name = "grpOutputOptions"
        Me.grpOutputOptions.Size = New System.Drawing.Size(200, 100)
        Me.grpOutputOptions.TabIndex = 10
        Me.grpOutputOptions.TabStop = False
        Me.grpOutputOptions.Tag = "Output_options"
        Me.grpOutputOptions.Text = "Output Options"
        '
        'rdoNewWorksheet
        '
        Me.rdoNewWorksheet.AutoSize = True
        Me.rdoNewWorksheet.Location = New System.Drawing.Point(9, 43)
        Me.rdoNewWorksheet.Name = "rdoNewWorksheet"
        Me.rdoNewWorksheet.Size = New System.Drawing.Size(99, 17)
        Me.rdoNewWorksheet.TabIndex = 0
        Me.rdoNewWorksheet.TabStop = True
        Me.rdoNewWorksheet.Tag = "New_worksheet"
        Me.rdoNewWorksheet.Text = "New worksheet"
        Me.rdoNewWorksheet.UseVisualStyleBackColor = True
        '
        'lblSheetName
        '
        Me.lblSheetName.AutoSize = True
        Me.lblSheetName.Location = New System.Drawing.Point(6, 66)
        Me.lblSheetName.Name = "lblSheetName"
        Me.lblSheetName.Size = New System.Drawing.Size(64, 13)
        Me.lblSheetName.TabIndex = 9
        Me.lblSheetName.Tag = "Sheet_name"
        Me.lblSheetName.Text = "Sheet name"
        '
        'rdoExistingWorksheet
        '
        Me.rdoExistingWorksheet.AutoSize = True
        Me.rdoExistingWorksheet.Location = New System.Drawing.Point(9, 19)
        Me.rdoExistingWorksheet.Name = "rdoExistingWorksheet"
        Me.rdoExistingWorksheet.Size = New System.Drawing.Size(113, 17)
        Me.rdoExistingWorksheet.TabIndex = 0
        Me.rdoExistingWorksheet.TabStop = True
        Me.rdoExistingWorksheet.Tag = "Existing_worksheet"
        Me.rdoExistingWorksheet.Text = "Existing worksheet"
        Me.rdoExistingWorksheet.UseVisualStyleBackColor = True
        '
        'txtSheetName
        '
        Me.txtSheetName.Location = New System.Drawing.Point(84, 66)
        Me.txtSheetName.Name = "txtSheetName"
        Me.txtSheetName.Size = New System.Drawing.Size(100, 20)
        Me.txtSheetName.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(15, 415)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 11
        '
        'ucrDataFrameAddRemove
        '
        Me.ucrDataFrameAddRemove.Location = New System.Drawing.Point(10, 52)
        Me.ucrDataFrameAddRemove.Name = "ucrDataFrameAddRemove"
        Me.ucrDataFrameAddRemove.Size = New System.Drawing.Size(242, 179)
        Me.ucrDataFrameAddRemove.TabIndex = 12
        '
        'dlgStack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 480)
        Me.Controls.Add(Me.ucrDataFrameAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpOutputOptions)
        Me.Controls.Add(Me.lblFactorInto)
        Me.Controls.Add(Me.lblIdVariable)
        Me.Controls.Add(Me.ucrReceiverIdVariable)
        Me.Controls.Add(Me.ucrDataFrameStack)
        Me.Controls.Add(Me.chkOmitValue)
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
        Me.grpOutputOptions.ResumeLayout(False)
        Me.grpOutputOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverColumnsToBeStack As ucrReceiverMultiple
    Friend WithEvents lblColumnsToBestack As Label
    Friend WithEvents txtStackDataInto As TextBox
    Friend WithEvents chkOmitValue As CheckBox
    Friend WithEvents lblStackDataInto As Label
    Friend WithEvents ucrDataFrameStack As ucrDataFrame
    Friend WithEvents ucrReceiverIdVariable As ucrReceiverSingle
    Friend WithEvents lblIdVariable As Label
    Friend WithEvents lblFactorInto As Label
    Friend WithEvents txtFactorInto As TextBox
    Friend WithEvents grpOutputOptions As GroupBox
    Friend WithEvents rdoNewWorksheet As RadioButton
    Friend WithEvents lblSheetName As Label
    Friend WithEvents rdoExistingWorksheet As RadioButton
    Friend WithEvents txtSheetName As TextBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameAddRemove As ucrSelectorByDataFrameAddRemove
End Class
