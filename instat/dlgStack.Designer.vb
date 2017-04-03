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
        Me.ucrChkCarryColumns = New instat.ucrCheck()
        Me.ucrStackDataInto = New instat.ucrInputTextBox()
        Me.ucrFactorInto = New instat.ucrInputTextBox()
        Me.ucrColumnsToCarryReceiver = New instat.ucrReceiverMultiple()
        Me.ucrSelectorStack = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverColumnsToBeStack = New instat.ucrReceiverMultiple()
        Me.ucrSaveNewDataName = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'lblColumnsTostack
        '
        Me.lblColumnsTostack.AutoSize = True
        Me.lblColumnsTostack.Location = New System.Drawing.Point(285, 26)
        Me.lblColumnsTostack.Name = "lblColumnsTostack"
        Me.lblColumnsTostack.Size = New System.Drawing.Size(93, 13)
        Me.lblColumnsTostack.TabIndex = 1
        Me.lblColumnsTostack.Tag = "Columns_to_Stack:"
        Me.lblColumnsTostack.Text = "Columns to Stack:"
        '
        'lblStackDataInto
        '
        Me.lblStackDataInto.AutoSize = True
        Me.lblStackDataInto.Location = New System.Drawing.Point(10, 263)
        Me.lblStackDataInto.Name = "lblStackDataInto"
        Me.lblStackDataInto.Size = New System.Drawing.Size(85, 13)
        Me.lblStackDataInto.TabIndex = 8
        Me.lblStackDataInto.Tag = "Stack_Data_Into"
        Me.lblStackDataInto.Text = "Stack Data Into:"
        '
        'lblFactorInto
        '
        Me.lblFactorInto.AutoSize = True
        Me.lblFactorInto.Location = New System.Drawing.Point(10, 234)
        Me.lblFactorInto.Name = "lblFactorInto"
        Me.lblFactorInto.Size = New System.Drawing.Size(61, 13)
        Me.lblFactorInto.TabIndex = 6
        Me.lblFactorInto.Tag = "Factor_Into"
        Me.lblFactorInto.Text = "Factor Into:"
        '
        'ucrChkCarryColumns
        '
        Me.ucrChkCarryColumns.Checked = False
        Me.ucrChkCarryColumns.Location = New System.Drawing.Point(285, 147)
        Me.ucrChkCarryColumns.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrChkCarryColumns.Name = "ucrChkCarryColumns"
        Me.ucrChkCarryColumns.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkCarryColumns.TabIndex = 3
        '
        'ucrStackDataInto
        '
        Me.ucrStackDataInto.AddQuotesIfUnrecognised = True
        Me.ucrStackDataInto.IsMultiline = False
        Me.ucrStackDataInto.IsReadOnly = False
        Me.ucrStackDataInto.Location = New System.Drawing.Point(131, 259)
        Me.ucrStackDataInto.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrStackDataInto.Name = "ucrStackDataInto"
        Me.ucrStackDataInto.Size = New System.Drawing.Size(145, 21)
        Me.ucrStackDataInto.TabIndex = 9
        '
        'ucrFactorInto
        '
        Me.ucrFactorInto.AddQuotesIfUnrecognised = True
        Me.ucrFactorInto.IsMultiline = False
        Me.ucrFactorInto.IsReadOnly = False
        Me.ucrFactorInto.Location = New System.Drawing.Point(131, 230)
        Me.ucrFactorInto.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrFactorInto.Name = "ucrFactorInto"
        Me.ucrFactorInto.Size = New System.Drawing.Size(145, 21)
        Me.ucrFactorInto.TabIndex = 7
        '
        'ucrColumnsToCarryReceiver
        '
        Me.ucrColumnsToCarryReceiver.frmParent = Me
        Me.ucrColumnsToCarryReceiver.Location = New System.Drawing.Point(285, 173)
        Me.ucrColumnsToCarryReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrColumnsToCarryReceiver.Name = "ucrColumnsToCarryReceiver"
        Me.ucrColumnsToCarryReceiver.Selector = Nothing
        Me.ucrColumnsToCarryReceiver.Size = New System.Drawing.Size(120, 107)
        Me.ucrColumnsToCarryReceiver.TabIndex = 4
        '
        'ucrSelectorStack
        '
        Me.ucrSelectorStack.bShowHiddenColumns = False
        Me.ucrSelectorStack.bUseCurrentFilter = True
        Me.ucrSelectorStack.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorStack.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStack.Name = "ucrSelectorStack"
        Me.ucrSelectorStack.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorStack.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 286)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 10
        '
        'ucrReceiverColumnsToBeStack
        '
        Me.ucrReceiverColumnsToBeStack.frmParent = Me
        Me.ucrReceiverColumnsToBeStack.Location = New System.Drawing.Point(285, 41)
        Me.ucrReceiverColumnsToBeStack.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToBeStack.Name = "ucrReceiverColumnsToBeStack"
        Me.ucrReceiverColumnsToBeStack.Selector = Nothing
        Me.ucrReceiverColumnsToBeStack.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverColumnsToBeStack.TabIndex = 2
        '
        'ucrSaveNewDataName
        '
        Me.ucrSaveNewDataName.Location = New System.Drawing.Point(10, 200)
        Me.ucrSaveNewDataName.Name = "ucrSaveNewDataName"
        Me.ucrSaveNewDataName.Size = New System.Drawing.Size(266, 20)
        Me.ucrSaveNewDataName.TabIndex = 5
        '
        'dlgStack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 349)
        Me.Controls.Add(Me.ucrSaveNewDataName)
        Me.Controls.Add(Me.ucrChkCarryColumns)
        Me.Controls.Add(Me.ucrStackDataInto)
        Me.Controls.Add(Me.ucrFactorInto)
        Me.Controls.Add(Me.ucrColumnsToCarryReceiver)
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
        Me.Text = "Stack (melt) Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverColumnsToBeStack As ucrReceiverMultiple
    Friend WithEvents lblColumnsTostack As Label
    Friend WithEvents lblStackDataInto As Label
    Friend WithEvents lblFactorInto As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorStack As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrColumnsToCarryReceiver As ucrReceiverMultiple
    Friend WithEvents ucrFactorInto As ucrInputTextBox
    Friend WithEvents ucrStackDataInto As ucrInputTextBox
    Friend WithEvents ucrChkCarryColumns As ucrCheck
    Friend WithEvents ucrSaveNewDataName As ucrSave
End Class
