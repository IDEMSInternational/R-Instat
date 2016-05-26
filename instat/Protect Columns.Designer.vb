<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgProtectColumns
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
        Me.ucrSelectorforProtectedColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblProtectedColumns = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleforProtectedColumns = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'ucrSelectorforProtectedColumns
        '
        Me.ucrSelectorforProtectedColumns.Location = New System.Drawing.Point(19, 9)
        Me.ucrSelectorforProtectedColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorforProtectedColumns.Name = "ucrSelectorforProtectedColumns"
        Me.ucrSelectorforProtectedColumns.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorforProtectedColumns.TabIndex = 0
        '
        'lblProtectedColumns
        '
        Me.lblProtectedColumns.AutoSize = True
        Me.lblProtectedColumns.Location = New System.Drawing.Point(251, 71)
        Me.lblProtectedColumns.Name = "lblProtectedColumns"
        Me.lblProtectedColumns.Size = New System.Drawing.Size(96, 13)
        Me.lblProtectedColumns.TabIndex = 1
        Me.lblProtectedColumns.Text = "Protected Columns"
        '
        'ucrReceiverMultipleforProtectedColumns
        '
        Me.ucrReceiverMultipleforProtectedColumns.Location = New System.Drawing.Point(254, 89)
        Me.ucrReceiverMultipleforProtectedColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleforProtectedColumns.Name = "ucrReceiverMultipleforProtectedColumns"
        Me.ucrReceiverMultipleforProtectedColumns.Selector = Nothing
        Me.ucrReceiverMultipleforProtectedColumns.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleforProtectedColumns.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(6, 212)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(402, 52)
        Me.ucrBase.TabIndex = 3
        '
        'dlgProtectColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 271)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverMultipleforProtectedColumns)
        Me.Controls.Add(Me.lblProtectedColumns)
        Me.Controls.Add(Me.ucrSelectorforProtectedColumns)
        Me.Name = "dlgProtectColumns"
        Me.Text = "Protect Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorforProtectedColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblProtectedColumns As Label
    Friend WithEvents ucrReceiverMultipleforProtectedColumns As ucrReceiverMultiple
    Friend WithEvents ucrBase As ucrButtons
End Class
