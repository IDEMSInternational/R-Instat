<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFreezeColumns
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
        Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverMultipleforFreezeColumns = New instat.ucrReceiverMultiple()
        Me.ucrBaseforFreezeColumns = New instat.ucrButtons()
        Me.lblFreezeColumns = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrSelectorByDataFrameAddRemoveforFreezeColumns
        '
        Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns.bShowHiddenColumns = False
        Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns.bUseCurrentFilter = False
        Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns.Location = New System.Drawing.Point(12, 0)
        Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns.Name = "ucrSelectorByDataFrameAddRemoveforFreezeColumns"
        Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns.TabIndex = 0
        '
        'ucrReceiverMultipleforFreezeColumns
        '
        Me.ucrReceiverMultipleforFreezeColumns.Location = New System.Drawing.Point(240, 28)
        Me.ucrReceiverMultipleforFreezeColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleforFreezeColumns.Name = "ucrReceiverMultipleforFreezeColumns"
        Me.ucrReceiverMultipleforFreezeColumns.Selector = Nothing
        Me.ucrReceiverMultipleforFreezeColumns.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleforFreezeColumns.TabIndex = 1
        '
        'ucrBaseforFreezeColumns
        '
        Me.ucrBaseforFreezeColumns.Location = New System.Drawing.Point(12, 198)
        Me.ucrBaseforFreezeColumns.Name = "ucrBaseforFreezeColumns"
        Me.ucrBaseforFreezeColumns.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseforFreezeColumns.TabIndex = 2
        '
        'lblFreezeColumns
        '
        Me.lblFreezeColumns.AutoSize = True
        Me.lblFreezeColumns.Location = New System.Drawing.Point(237, 9)
        Me.lblFreezeColumns.Name = "lblFreezeColumns"
        Me.lblFreezeColumns.Size = New System.Drawing.Size(82, 13)
        Me.lblFreezeColumns.TabIndex = 3
        Me.lblFreezeColumns.Text = "Freeze Columns"
        '
        'dlgFreezeColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 250)
        Me.Controls.Add(Me.lblFreezeColumns)
        Me.Controls.Add(Me.ucrBaseforFreezeColumns)
        Me.Controls.Add(Me.ucrReceiverMultipleforFreezeColumns)
        Me.Controls.Add(Me.ucrSelectorByDataFrameAddRemoveforFreezeColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFreezeColumns"
        Me.Text = "Freeze Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorByDataFrameAddRemoveforFreezeColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverMultipleforFreezeColumns As ucrReceiverMultiple
    Friend WithEvents ucrBaseforFreezeColumns As ucrButtons
    Friend WithEvents lblFreezeColumns As Label
End Class
