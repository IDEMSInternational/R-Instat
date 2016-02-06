<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgReferenceLevel
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
        Me.ucrDataFrameSelector = New instat.ucrDataFrame()
        Me.ucrFactorSelected = New instat.ucrReceiverSingle()
        Me.lblFactorSelected = New System.Windows.Forms.Label()
        Me.lblInfo2 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(4, 295)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrDataFrameSelector
        '
        Me.ucrDataFrameSelector.Location = New System.Drawing.Point(1, 1)
        Me.ucrDataFrameSelector.Name = "ucrDataFrameSelector"
        Me.ucrDataFrameSelector.Size = New System.Drawing.Size(127, 41)
        Me.ucrDataFrameSelector.TabIndex = 1
        '
        'ucrFactorSelected
        '
        Me.ucrFactorSelected.Location = New System.Drawing.Point(247, 84)
        Me.ucrFactorSelected.Name = "ucrFactorSelected"
        Me.ucrFactorSelected.Size = New System.Drawing.Size(106, 26)
        Me.ucrFactorSelected.TabIndex = 3
        '
        'lblFactorSelected
        '
        Me.lblFactorSelected.AutoSize = True
        Me.lblFactorSelected.Location = New System.Drawing.Point(253, 69)
        Me.lblFactorSelected.Name = "lblFactorSelected"
        Me.lblFactorSelected.Size = New System.Drawing.Size(80, 13)
        Me.lblFactorSelected.TabIndex = 4
        Me.lblFactorSelected.Tag = "Factor_selected"
        Me.lblFactorSelected.Text = "Factor selected"
        '
        'lblInfo2
        '
        Me.lblInfo2.AutoSize = True
        Me.lblInfo2.Location = New System.Drawing.Point(201, 167)
        Me.lblInfo2.Name = "lblInfo2"
        Me.lblInfo2.Size = New System.Drawing.Size(215, 13)
        Me.lblInfo2.TabIndex = 5
        Me.lblInfo2.Tag = "REQUIRES_A_FACTOR_LEVEL_SELECTOR"
        Me.lblInfo2.Text = "REQUIRES A FACTOR LEVEL SELECTOR"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(12, 84)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(179, 13)
        Me.lblInfo.TabIndex = 6
        Me.lblInfo.Tag = "REQUIRES_A_FACTOR_SELECTOR"
        Me.lblInfo.Text = "REQUIRES A FACTOR SELECTOR"
        '
        'dlgReferenceLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 350)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblInfo2)
        Me.Controls.Add(Me.lblFactorSelected)
        Me.Controls.Add(Me.ucrFactorSelected)
        Me.Controls.Add(Me.ucrDataFrameSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgReferenceLevel"
        Me.Tag = "Reference_Level"
        Me.Text = "Reference Level"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameSelector As ucrDataFrame
    Friend WithEvents ucrFactorSelected As ucrReceiverSingle
    Friend WithEvents lblFactorSelected As Label
    Friend WithEvents lblInfo2 As Label
    Friend WithEvents lblInfo As Label
End Class
