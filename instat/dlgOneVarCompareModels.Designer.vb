<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgOneVarCompareModels
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
        Me.UcrReceiver = New instat.ucrReceiverMultiple()
        Me.ucrSelectorOneVarCompModels = New instat.ucrSelectorByDataFrameAddRemove()
        Me.cmdDisplayObjects = New System.Windows.Forms.Button()
        Me.lblReceiver = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 204)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'UcrReceiver
        '
        Me.UcrReceiver.Location = New System.Drawing.Point(251, 60)
        Me.UcrReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiver.Name = "UcrReceiver"
        Me.UcrReceiver.Selector = Nothing
        Me.UcrReceiver.Size = New System.Drawing.Size(120, 100)
        Me.UcrReceiver.TabIndex = 1
        '
        'ucrSelectorOneVarCompModels
        '
        Me.ucrSelectorOneVarCompModels.bShowHiddenColumns = False
        Me.ucrSelectorOneVarCompModels.bUseCurrentFilter = True
        Me.ucrSelectorOneVarCompModels.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorOneVarCompModels.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOneVarCompModels.Name = "ucrSelectorOneVarCompModels"
        Me.ucrSelectorOneVarCompModels.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorOneVarCompModels.TabIndex = 2
        '
        'cmdDisplayObjects
        '
        Me.cmdDisplayObjects.Location = New System.Drawing.Point(280, 167)
        Me.cmdDisplayObjects.Name = "cmdDisplayObjects"
        Me.cmdDisplayObjects.Size = New System.Drawing.Size(91, 23)
        Me.cmdDisplayObjects.TabIndex = 3
        Me.cmdDisplayObjects.Text = "Display Objects"
        Me.cmdDisplayObjects.UseVisualStyleBackColor = True
        '
        'lblReceiver
        '
        Me.lblReceiver.AutoSize = True
        Me.lblReceiver.Location = New System.Drawing.Point(250, 44)
        Me.lblReceiver.Name = "lblReceiver"
        Me.lblReceiver.Size = New System.Drawing.Size(97, 13)
        Me.lblReceiver.TabIndex = 4
        Me.lblReceiver.Text = "Selected Object(s):"
        '
        'dlgOneVarCompareModels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 262)
        Me.Controls.Add(Me.lblReceiver)
        Me.Controls.Add(Me.cmdDisplayObjects)
        Me.Controls.Add(Me.ucrSelectorOneVarCompModels)
        Me.Controls.Add(Me.UcrReceiver)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneVarCompareModels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compare Models for One Variable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents UcrReceiver As ucrReceiverMultiple
    Friend WithEvents ucrSelectorOneVarCompModels As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdDisplayObjects As Button
    Friend WithEvents lblReceiver As Label
End Class
