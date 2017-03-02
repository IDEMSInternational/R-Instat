<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDefineRedFlags
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
        Me.ucrSelectorDefineRedFlag = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverRedFlag = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
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
        'ucrReceiverRedFlag
        '
        Me.ucrReceiverRedFlag.frmParent = Me
        Me.ucrReceiverRedFlag.Location = New System.Drawing.Point(271, 60)
        Me.ucrReceiverRedFlag.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRedFlag.Name = "ucrReceiverRedFlag"
        Me.ucrReceiverRedFlag.Selector = Nothing
        Me.ucrReceiverRedFlag.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverRedFlag.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 206)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 2
        '
        'dlgDefineRedFlags
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 266)
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

    End Sub

    Friend WithEvents ucrSelectorDefineRedFlag As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRedFlag As ucrReceiverMultiple
    Friend WithEvents ucrBase As ucrButtons
End Class
