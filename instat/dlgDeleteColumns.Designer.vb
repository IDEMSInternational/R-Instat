<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDeleteColumns
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
        Me.ucrReceiverDeleteColumns = New instat.ucrReceiverMultiple()
        Me.lblColumnsToDelete = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.txtSubset = New System.Windows.Forms.TextBox()
        Me.lblSubset = New System.Windows.Forms.Label()
        Me.txtSelect = New System.Windows.Forms.TextBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(3, 12)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 0
        '
        'ucrReceiverDeleteColumns
        '
        Me.ucrReceiverDeleteColumns.Location = New System.Drawing.Point(225, 35)
        Me.ucrReceiverDeleteColumns.Name = "ucrReceiverDeleteColumns"
        Me.ucrReceiverDeleteColumns.Size = New System.Drawing.Size(122, 136)
        Me.ucrReceiverDeleteColumns.TabIndex = 1
        '
        'lblColumnsToDelete
        '
        Me.lblColumnsToDelete.AutoSize = True
        Me.lblColumnsToDelete.Location = New System.Drawing.Point(222, 12)
        Me.lblColumnsToDelete.Name = "lblColumnsToDelete"
        Me.lblColumnsToDelete.Size = New System.Drawing.Size(91, 13)
        Me.lblColumnsToDelete.TabIndex = 2
        Me.lblColumnsToDelete.Tag = "Columns_to_delete"
        Me.lblColumnsToDelete.Text = "Columns to delete"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 259)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 56)
        Me.ucrBase.TabIndex = 3
        '
        'txtSubset
        '
        Me.txtSubset.Location = New System.Drawing.Point(22, 187)
        Me.txtSubset.Name = "txtSubset"
        Me.txtSubset.Size = New System.Drawing.Size(100, 20)
        Me.txtSubset.TabIndex = 4
        '
        'lblSubset
        '
        Me.lblSubset.AutoSize = True
        Me.lblSubset.Location = New System.Drawing.Point(19, 159)
        Me.lblSubset.Name = "lblSubset"
        Me.lblSubset.Size = New System.Drawing.Size(40, 13)
        Me.lblSubset.TabIndex = 2
        Me.lblSubset.Tag = "Subset"
        Me.lblSubset.Text = "Subset"
        '
        'txtSelect
        '
        Me.txtSelect.Location = New System.Drawing.Point(260, 197)
        Me.txtSelect.Name = "txtSelect"
        Me.txtSelect.Size = New System.Drawing.Size(100, 20)
        Me.txtSelect.TabIndex = 4
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Location = New System.Drawing.Point(257, 174)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(37, 13)
        Me.lblSelect.TabIndex = 2
        Me.lblSelect.Tag = "Select"
        Me.lblSelect.Text = "Select"
        '
        'dlgDeleteColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 318)
        Me.Controls.Add(Me.txtSelect)
        Me.Controls.Add(Me.txtSubset)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.lblSubset)
        Me.Controls.Add(Me.lblColumnsToDelete)
        Me.Controls.Add(Me.ucrReceiverDeleteColumns)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgDeleteColumns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Delete_Columns"
        Me.Text = "Delete Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverDeleteColumns As ucrReceiverMultiple
    Friend WithEvents lblColumnsToDelete As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents txtSubset As TextBox
    Friend WithEvents lblSubset As Label
    Friend WithEvents txtSelect As TextBox
    Friend WithEvents lblSelect As Label
End Class
