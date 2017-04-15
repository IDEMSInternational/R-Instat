<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDefineRedFlags
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
        Me.ucrReceiverRedFlag = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDefineRedFlag = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblRedFlags = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 206)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 3
        '
        'ucrReceiverRedFlag
        '
        Me.ucrReceiverRedFlag.frmParent = Me
        Me.ucrReceiverRedFlag.Location = New System.Drawing.Point(271, 60)
        Me.ucrReceiverRedFlag.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRedFlag.Name = "ucrReceiverRedFlag"
        Me.ucrReceiverRedFlag.Selector = Nothing
        Me.ucrReceiverRedFlag.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverRedFlag.TabIndex = 2
        '
        'ucrSelectorDefineRedFlag
        '
        Me.ucrSelectorDefineRedFlag.bShowHiddenColumns = False
        Me.ucrSelectorDefineRedFlag.bUseCurrentFilter = True
        Me.ucrSelectorDefineRedFlag.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorDefineRedFlag.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDefineRedFlag.Name = "ucrSelectorDefineRedFlag"
        Me.ucrSelectorDefineRedFlag.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDefineRedFlag.TabIndex = 0
        '
        'lblRedFlags
        '
        Me.lblRedFlags.AutoSize = True
        Me.lblRedFlags.Location = New System.Drawing.Point(268, 44)
        Me.lblRedFlags.Name = "lblRedFlags"
        Me.lblRedFlags.Size = New System.Drawing.Size(58, 13)
        Me.lblRedFlags.TabIndex = 1
        Me.lblRedFlags.Text = "Red Flags:"
        '
        'dlgDefineRedFlags
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 266)
        Me.Controls.Add(Me.lblRedFlags)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverRedFlag)
        Me.Controls.Add(Me.ucrSelectorDefineRedFlag)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDefineRedFlags"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Define Red Flags"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorDefineRedFlag As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRedFlag As ucrReceiverMultiple
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblRedFlags As Label
End Class
