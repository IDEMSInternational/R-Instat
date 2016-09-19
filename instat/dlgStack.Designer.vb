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
        Me.lblColumnsTostack = New System.Windows.Forms.Label()
        Me.lblStackDataInto = New System.Windows.Forms.Label()
        Me.lblFactorInto = New System.Windows.Forms.Label()
        Me.chkColumnsToCarry = New System.Windows.Forms.CheckBox()
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.ucrNewDataName = New instat.ucrInputTextBox()
        Me.ucrStackDataInto = New instat.ucrInputTextBox()
        Me.ucrFactorInto = New instat.ucrInputTextBox()
        Me.ucrColumnsToCarryReceiver = New instat.ucrReceiverMultiple()
        Me.ucrSelectorStack = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverColumnsToBeStack = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'lblColumnsTostack
        '
        Me.lblColumnsTostack.AutoSize = True
        Me.lblColumnsTostack.Location = New System.Drawing.Point(288, 25)
        Me.lblColumnsTostack.Name = "lblColumnsTostack"
        Me.lblColumnsTostack.Size = New System.Drawing.Size(93, 13)
        Me.lblColumnsTostack.TabIndex = 1
        Me.lblColumnsTostack.Tag = "Columns_to_Stack"
        Me.lblColumnsTostack.Text = "Columns to Stack:"
        '
        'lblStackDataInto
        '
        Me.lblStackDataInto.AutoSize = True
        Me.lblStackDataInto.Location = New System.Drawing.Point(41, 255)
        Me.lblStackDataInto.Name = "lblStackDataInto"
        Me.lblStackDataInto.Size = New System.Drawing.Size(85, 13)
        Me.lblStackDataInto.TabIndex = 9
        Me.lblStackDataInto.Tag = "Stack_Data_Into"
        Me.lblStackDataInto.Text = "Stack Data Into:"
        '
        'lblFactorInto
        '
        Me.lblFactorInto.AutoSize = True
        Me.lblFactorInto.Location = New System.Drawing.Point(65, 229)
        Me.lblFactorInto.Name = "lblFactorInto"
        Me.lblFactorInto.Size = New System.Drawing.Size(61, 13)
        Me.lblFactorInto.TabIndex = 7
        Me.lblFactorInto.Tag = "Factor_Into"
        Me.lblFactorInto.Text = "Factor Into:"
        '
        'chkColumnsToCarry
        '
        Me.chkColumnsToCarry.AutoSize = True
        Me.chkColumnsToCarry.Location = New System.Drawing.Point(288, 153)
        Me.chkColumnsToCarry.Name = "chkColumnsToCarry"
        Me.chkColumnsToCarry.Size = New System.Drawing.Size(93, 17)
        Me.chkColumnsToCarry.TabIndex = 3
        Me.chkColumnsToCarry.Tag = "Carry_Columns"
        Me.chkColumnsToCarry.Text = "Carry Columns"
        Me.chkColumnsToCarry.UseVisualStyleBackColor = True
        '
        'lblNewDataFrameName
        '
        Me.lblNewDataFrameName.AutoSize = True
        Me.lblNewDataFrameName.Location = New System.Drawing.Point(5, 203)
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        Me.lblNewDataFrameName.Size = New System.Drawing.Size(121, 13)
        Me.lblNewDataFrameName.TabIndex = 5
        Me.lblNewDataFrameName.Tag = "New_Data_Frame_Name:"
        Me.lblNewDataFrameName.Text = "New Data Frame Name:"
        '
        'ucrNewDataName
        '
        Me.ucrNewDataName.IsReadOnly = False
        Me.ucrNewDataName.Location = New System.Drawing.Point(130, 201)
        Me.ucrNewDataName.Name = "ucrNewDataName"
        Me.ucrNewDataName.Size = New System.Drawing.Size(145, 21)
        Me.ucrNewDataName.TabIndex = 14
        '
        'ucrStackDataInto
        '
        Me.ucrStackDataInto.IsReadOnly = False
        Me.ucrStackDataInto.Location = New System.Drawing.Point(130, 252)
        Me.ucrStackDataInto.Name = "ucrStackDataInto"
        Me.ucrStackDataInto.Size = New System.Drawing.Size(145, 21)
        Me.ucrStackDataInto.TabIndex = 13
        '
        'ucrFactorInto
        '
        Me.ucrFactorInto.IsReadOnly = False
        Me.ucrFactorInto.Location = New System.Drawing.Point(130, 227)
        Me.ucrFactorInto.Name = "ucrFactorInto"
        Me.ucrFactorInto.Size = New System.Drawing.Size(145, 21)
        Me.ucrFactorInto.TabIndex = 12
        '
        'ucrColumnsToCarryReceiver
        '
        Me.ucrColumnsToCarryReceiver.Location = New System.Drawing.Point(288, 173)
        Me.ucrColumnsToCarryReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrColumnsToCarryReceiver.Name = "ucrColumnsToCarryReceiver"
        Me.ucrColumnsToCarryReceiver.Selector = Nothing
        Me.ucrColumnsToCarryReceiver.Size = New System.Drawing.Size(120, 100)
        Me.ucrColumnsToCarryReceiver.TabIndex = 4
        '
        'ucrSelectorStack
        '
        Me.ucrSelectorStack.bShowHiddenColumns = False
        Me.ucrSelectorStack.bUseCurrentFilter = False
        Me.ucrSelectorStack.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorStack.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStack.Name = "ucrSelectorStack"
        Me.ucrSelectorStack.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorStack.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 278)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 11
        '
        'ucrReceiverColumnsToBeStack
        '
        Me.ucrReceiverColumnsToBeStack.Location = New System.Drawing.Point(288, 41)
        Me.ucrReceiverColumnsToBeStack.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToBeStack.Name = "ucrReceiverColumnsToBeStack"
        Me.ucrReceiverColumnsToBeStack.Selector = Nothing
        Me.ucrReceiverColumnsToBeStack.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverColumnsToBeStack.TabIndex = 2
        '
        'dlgStack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 331)
        Me.Controls.Add(Me.ucrNewDataName)
        Me.Controls.Add(Me.ucrStackDataInto)
        Me.Controls.Add(Me.ucrFactorInto)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.ucrColumnsToCarryReceiver)
        Me.Controls.Add(Me.chkColumnsToCarry)
        Me.Controls.Add(Me.ucrSelectorStack)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblFactorInto)
        Me.Controls.Add(Me.lblStackDataInto)
        Me.Controls.Add(Me.lblColumnsTostack)
        Me.Controls.Add(Me.ucrReceiverColumnsToBeStack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Stack_join_columns"
        Me.Text = "Stack (melt) columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverColumnsToBeStack As ucrReceiverMultiple
    Friend WithEvents lblColumnsTostack As Label
    Friend WithEvents lblStackDataInto As Label
    Friend WithEvents lblFactorInto As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorStack As ucrSelectorByDataFrameAddRemove
    Friend WithEvents chkColumnsToCarry As CheckBox
    Friend WithEvents ucrColumnsToCarryReceiver As ucrReceiverMultiple
    Friend WithEvents lblNewDataFrameName As Label
    Friend WithEvents ucrFactorInto As ucrInputTextBox
    Friend WithEvents ucrStackDataInto As ucrInputTextBox
    Friend WithEvents ucrNewDataName As ucrInputTextBox
End Class
