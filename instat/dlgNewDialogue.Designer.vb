<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgNewDialogue
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
        Me.ucrSelectorByDataFrameAddRemove1 = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverSingle1 = New instat.ucrReceiverSingle()
        Me.ucrReceiverFactors = New instat.ucrReceiverMultiple()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 263)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(399, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorByDataFrameAddRemove1
        '
        Me.ucrSelectorByDataFrameAddRemove1.bShowHiddenColumns = False
        Me.ucrSelectorByDataFrameAddRemove1.bUseCurrentFilter = True
        Me.ucrSelectorByDataFrameAddRemove1.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorByDataFrameAddRemove1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDataFrameAddRemove1.Name = "ucrSelectorByDataFrameAddRemove1"
        Me.ucrSelectorByDataFrameAddRemove1.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorByDataFrameAddRemove1.TabIndex = 2
        '
        'ucrReceiverSingle1
        '
        Me.ucrReceiverSingle1.frmParent = Me
        Me.ucrReceiverSingle1.Location = New System.Drawing.Point(321, 88)
        Me.ucrReceiverSingle1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingle1.Name = "ucrReceiverSingle1"
        Me.ucrReceiverSingle1.Selector = Nothing
        Me.ucrReceiverSingle1.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSingle1.TabIndex = 3
        '
        'ucrReceiverFactors
        '
        Me.ucrReceiverFactors.frmParent = Me
        Me.ucrReceiverFactors.Location = New System.Drawing.Point(309, 138)
        Me.ucrReceiverFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactors.Name = "ucrReceiverFactors"
        Me.ucrReceiverFactors.Selector = Nothing
        Me.ucrReceiverFactors.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverFactors.TabIndex = 4
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(324, 72)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(45, 13)
        Me.lblFactors.TabIndex = 5
        Me.lblFactors.Text = "Factors:"
        '
        'dlgNewDialogue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(463, 327)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrReceiverFactors)
        Me.Controls.Add(Me.ucrReceiverSingle1)
        Me.Controls.Add(Me.ucrSelectorByDataFrameAddRemove1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgNewDialogue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Dialogue"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorByDataFrameAddRemove1 As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverSingle1 As ucrReceiverSingle
    Friend WithEvents ucrReceiverFactors As ucrReceiverMultiple
    Friend WithEvents lblFactors As Label
End Class
