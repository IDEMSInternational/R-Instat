<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSort
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
        Me.ucrBase = New instat.ucrButtons()
        Me.grpOrderType = New System.Windows.Forms.GroupBox()
        Me.rdoDescending = New System.Windows.Forms.RadioButton()
        Me.rdoAscending = New System.Windows.Forms.RadioButton()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrMultiple = New instat.ucrReceiverMultiple()
        Me.lblColumnsToSort = New System.Windows.Forms.Label()
        Me.chkWriteBack = New System.Windows.Forms.CheckBox()
        Me.grpOrderType.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(1, 155)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(402, 35)
        Me.ucrBase.TabIndex = 0
        '
        'grpOrderType
        '
        Me.grpOrderType.Controls.Add(Me.rdoDescending)
        Me.grpOrderType.Controls.Add(Me.rdoAscending)
        Me.grpOrderType.Location = New System.Drawing.Point(284, 12)
        Me.grpOrderType.Name = "grpOrderType"
        Me.grpOrderType.Size = New System.Drawing.Size(102, 116)
        Me.grpOrderType.TabIndex = 2
        Me.grpOrderType.TabStop = False
        Me.grpOrderType.Text = "Order Type"
        '
        'rdoDescending
        '
        Me.rdoDescending.AutoSize = True
        Me.rdoDescending.Location = New System.Drawing.Point(6, 61)
        Me.rdoDescending.Name = "rdoDescending"
        Me.rdoDescending.Size = New System.Drawing.Size(82, 17)
        Me.rdoDescending.TabIndex = 0
        Me.rdoDescending.TabStop = True
        Me.rdoDescending.Tag = "Descending"
        Me.rdoDescending.Text = "Descending"
        Me.rdoDescending.UseVisualStyleBackColor = True
        '
        'rdoAscending
        '
        Me.rdoAscending.AutoSize = True
        Me.rdoAscending.Location = New System.Drawing.Point(7, 20)
        Me.rdoAscending.Name = "rdoAscending"
        Me.rdoAscending.Size = New System.Drawing.Size(75, 17)
        Me.rdoAscending.TabIndex = 0
        Me.rdoAscending.TabStop = True
        Me.rdoAscending.Tag = "Ascending"
        Me.rdoAscending.Text = "Ascending"
        Me.rdoAscending.UseVisualStyleBackColor = True
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(1, 7)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(180, 118)
        Me.ucrAddRemove.TabIndex = 3
        '
        'ucrMultiple
        '
        Me.ucrMultiple.Location = New System.Drawing.Point(187, 22)
        Me.ucrMultiple.Name = "ucrMultiple"
        Me.ucrMultiple.Size = New System.Drawing.Size(91, 101)
        Me.ucrMultiple.TabIndex = 4
        '
        'lblColumnsToSort
        '
        Me.lblColumnsToSort.AutoSize = True
        Me.lblColumnsToSort.Location = New System.Drawing.Point(187, 7)
        Me.lblColumnsToSort.Name = "lblColumnsToSort"
        Me.lblColumnsToSort.Size = New System.Drawing.Size(85, 13)
        Me.lblColumnsToSort.TabIndex = 5
        Me.lblColumnsToSort.Tag = "Columns_To_Sort"
        Me.lblColumnsToSort.Text = "Columns To Sort"
        '
        'chkWriteBack
        '
        Me.chkWriteBack.AutoSize = True
        Me.chkWriteBack.Location = New System.Drawing.Point(13, 132)
        Me.chkWriteBack.Name = "chkWriteBack"
        Me.chkWriteBack.Size = New System.Drawing.Size(134, 17)
        Me.chkWriteBack.TabIndex = 6
        Me.chkWriteBack.Text = "Write back to the Data"
        Me.chkWriteBack.UseVisualStyleBackColor = True
        '
        'dlgSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 191)
        Me.Controls.Add(Me.chkWriteBack)
        Me.Controls.Add(Me.lblColumnsToSort)
        Me.Controls.Add(Me.ucrMultiple)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.grpOrderType)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSort"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sort"
        Me.grpOrderType.ResumeLayout(False)
        Me.grpOrderType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpOrderType As GroupBox
    Friend WithEvents rdoDescending As RadioButton
    Friend WithEvents rdoAscending As RadioButton
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrMultiple As ucrReceiverMultiple
    Friend WithEvents lblColumnsToSort As Label
    Friend WithEvents chkWriteBack As CheckBox
End Class
