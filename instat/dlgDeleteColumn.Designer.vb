<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDeleteColumn
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
        Me.ucrSelectColumnsToDelete = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiveColumnsToDelete = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucrBase.Location = New System.Drawing.Point(0, 188)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 2
        '
        'ucrSelectColumnsToDelete
        '
        Me.ucrSelectColumnsToDelete.Location = New System.Drawing.Point(0, 3)
        Me.ucrSelectColumnsToDelete.Name = "ucrSelectColumnsToDelete"
        Me.ucrSelectColumnsToDelete.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectColumnsToDelete.TabIndex = 0
        '
        'ucrReceiveColumnsToDelete
        '
        Me.ucrReceiveColumnsToDelete.Location = New System.Drawing.Point(261, 74)
        Me.ucrReceiveColumnsToDelete.Name = "ucrReceiveColumnsToDelete"
        Me.ucrReceiveColumnsToDelete.Selector = Nothing
        Me.ucrReceiveColumnsToDelete.Size = New System.Drawing.Size(121, 105)
        Me.ucrReceiveColumnsToDelete.TabIndex = 1
        '
        'dlgDeleteColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 244)
        Me.Controls.Add(Me.ucrSelectColumnsToDelete)
        Me.Controls.Add(Me.ucrReceiveColumnsToDelete)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgDeleteColumn"
        Me.Text = "Delete Column (s)"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectColumnsToDelete As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiveColumnsToDelete As ucrReceiverMultiple
End Class
