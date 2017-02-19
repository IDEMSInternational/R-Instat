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
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.ucrChkCarryColumns = New instat.ucrCheck()
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
        Me.lblColumnsTostack.Location = New System.Drawing.Point(381, 32)
        Me.lblColumnsTostack.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColumnsTostack.Name = "lblColumnsTostack"
        Me.lblColumnsTostack.Size = New System.Drawing.Size(121, 17)
        Me.lblColumnsTostack.TabIndex = 1
        Me.lblColumnsTostack.Tag = "Columns_to_Stack:"
        Me.lblColumnsTostack.Text = "Columns to Stack:"
        '
        'lblStackDataInto
        '
        Me.lblStackDataInto.AutoSize = True
        Me.lblStackDataInto.Location = New System.Drawing.Point(13, 316)
        Me.lblStackDataInto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStackDataInto.Name = "lblStackDataInto"
        Me.lblStackDataInto.Size = New System.Drawing.Size(108, 17)
        Me.lblStackDataInto.TabIndex = 9
        Me.lblStackDataInto.Tag = "Stack_Data_Into"
        Me.lblStackDataInto.Text = "Stack Data Into:"
        '
        'lblFactorInto
        '
        Me.lblFactorInto.AutoSize = True
        Me.lblFactorInto.Location = New System.Drawing.Point(13, 284)
        Me.lblFactorInto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFactorInto.Name = "lblFactorInto"
        Me.lblFactorInto.Size = New System.Drawing.Size(79, 17)
        Me.lblFactorInto.TabIndex = 7
        Me.lblFactorInto.Tag = "Factor_Into"
        Me.lblFactorInto.Text = "Factor Into:"
        '
        'lblNewDataFrameName
        '
        Me.lblNewDataFrameName.AutoSize = True
        Me.lblNewDataFrameName.Location = New System.Drawing.Point(13, 252)
        Me.lblNewDataFrameName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        Me.lblNewDataFrameName.Size = New System.Drawing.Size(158, 17)
        Me.lblNewDataFrameName.TabIndex = 5
        Me.lblNewDataFrameName.Tag = "New_Data_Frame_Name:"
        Me.lblNewDataFrameName.Text = "New Data Frame Name:"
        '
        'ucrChkCarryColumns
        '
        Me.ucrChkCarryColumns.Checked = False
        Me.ucrChkCarryColumns.Location = New System.Drawing.Point(380, 185)
        Me.ucrChkCarryColumns.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkCarryColumns.Name = "ucrChkCarryColumns"
        Me.ucrChkCarryColumns.Size = New System.Drawing.Size(133, 25)
        Me.ucrChkCarryColumns.TabIndex = 3
        '
        'ucrNewDataName
        '
        Me.ucrNewDataName.IsMultiline = False
        Me.ucrNewDataName.IsReadOnly = False
        Me.ucrNewDataName.Location = New System.Drawing.Point(175, 250)
        Me.ucrNewDataName.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrNewDataName.Name = "ucrNewDataName"
        Me.ucrNewDataName.Size = New System.Drawing.Size(193, 26)
        Me.ucrNewDataName.TabIndex = 6
        '
        'ucrStackDataInto
        '
        Me.ucrStackDataInto.IsMultiline = False
        Me.ucrStackDataInto.IsReadOnly = False
        Me.ucrStackDataInto.Location = New System.Drawing.Point(175, 311)
        Me.ucrStackDataInto.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrStackDataInto.Name = "ucrStackDataInto"
        Me.ucrStackDataInto.Size = New System.Drawing.Size(193, 26)
        Me.ucrStackDataInto.TabIndex = 10
        '
        'ucrFactorInto
        '
        Me.ucrFactorInto.IsMultiline = False
        Me.ucrFactorInto.IsReadOnly = False
        Me.ucrFactorInto.Location = New System.Drawing.Point(175, 281)
        Me.ucrFactorInto.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrFactorInto.Name = "ucrFactorInto"
        Me.ucrFactorInto.Size = New System.Drawing.Size(193, 26)
        Me.ucrFactorInto.TabIndex = 8
        '
        'ucrColumnsToCarryReceiver
        '
        Me.ucrColumnsToCarryReceiver.frmParent = Me
        Me.ucrColumnsToCarryReceiver.Location = New System.Drawing.Point(380, 213)
        Me.ucrColumnsToCarryReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrColumnsToCarryReceiver.Name = "ucrColumnsToCarryReceiver"
        Me.ucrColumnsToCarryReceiver.Selector = Nothing
        Me.ucrColumnsToCarryReceiver.Size = New System.Drawing.Size(160, 123)
        Me.ucrColumnsToCarryReceiver.TabIndex = 4
        '
        'ucrSelectorStack
        '
        Me.ucrSelectorStack.bShowHiddenColumns = False
        Me.ucrSelectorStack.bUseCurrentFilter = True
        Me.ucrSelectorStack.Location = New System.Drawing.Point(13, 12)
        Me.ucrSelectorStack.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStack.Name = "ucrSelectorStack"
        Me.ucrSelectorStack.Size = New System.Drawing.Size(280, 222)
        Me.ucrSelectorStack.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 345)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(547, 64)
        Me.ucrBase.TabIndex = 11
        '
        'ucrReceiverColumnsToBeStack
        '
        Me.ucrReceiverColumnsToBeStack.frmParent = Me
        Me.ucrReceiverColumnsToBeStack.Location = New System.Drawing.Point(380, 50)
        Me.ucrReceiverColumnsToBeStack.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToBeStack.Name = "ucrReceiverColumnsToBeStack"
        Me.ucrReceiverColumnsToBeStack.Selector = Nothing
        Me.ucrReceiverColumnsToBeStack.Size = New System.Drawing.Size(160, 123)
        Me.ucrReceiverColumnsToBeStack.TabIndex = 2
        '
        'dlgStack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 417)
        Me.Controls.Add(Me.ucrChkCarryColumns)
        Me.Controls.Add(Me.ucrNewDataName)
        Me.Controls.Add(Me.ucrStackDataInto)
        Me.Controls.Add(Me.ucrFactorInto)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.ucrColumnsToCarryReceiver)
        Me.Controls.Add(Me.ucrSelectorStack)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblFactorInto)
        Me.Controls.Add(Me.lblStackDataInto)
        Me.Controls.Add(Me.lblColumnsTostack)
        Me.Controls.Add(Me.ucrReceiverColumnsToBeStack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents lblNewDataFrameName As Label
    Friend WithEvents ucrFactorInto As ucrInputTextBox
    Friend WithEvents ucrStackDataInto As ucrInputTextBox
    Friend WithEvents ucrNewDataName As ucrInputTextBox
    Friend WithEvents ucrChkCarryColumns As ucrCheck
End Class
