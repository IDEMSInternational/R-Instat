<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgBivariateANOVA
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
        Me.UcrReceiverSingle1 = New instat.ucrReceiverSingle()
        Me.UcrReciverSingleB1 = New instat.ucrReciverSingleB()
        Me.UcrReceiverSingle2 = New instat.ucrReceiverSingle()
        Me.UcrReciverSingleB2 = New instat.ucrReciverSingleB()
        Me.UcrButtons1 = New instat.ucrButtons()
        Me.lblResponsevariable = New System.Windows.Forms.Label()
        Me.lblTreatmentfactor = New System.Windows.Forms.Label()
        Me.lblBlockingfactor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkContrasts = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(2, 12)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 0
        '
        'UcrReceiverSingle1
        '
        Me.UcrReceiverSingle1.Location = New System.Drawing.Point(281, 29)
        Me.UcrReceiverSingle1.Name = "UcrReceiverSingle1"
        Me.UcrReceiverSingle1.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle1.TabIndex = 1
        '
        'UcrReciverSingleB1
        '
        Me.UcrReciverSingleB1.Location = New System.Drawing.Point(281, 71)
        Me.UcrReciverSingleB1.Name = "UcrReciverSingleB1"
        Me.UcrReciverSingleB1.Size = New System.Drawing.Size(106, 26)
        Me.UcrReciverSingleB1.TabIndex = 2
        '
        'UcrReceiverSingle2
        '
        Me.UcrReceiverSingle2.Location = New System.Drawing.Point(281, 113)
        Me.UcrReceiverSingle2.Name = "UcrReceiverSingle2"
        Me.UcrReceiverSingle2.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle2.TabIndex = 3
        '
        'UcrReciverSingleB2
        '
        Me.UcrReciverSingleB2.Location = New System.Drawing.Point(281, 160)
        Me.UcrReciverSingleB2.Name = "UcrReciverSingleB2"
        Me.UcrReciverSingleB2.Size = New System.Drawing.Size(106, 26)
        Me.UcrReciverSingleB2.TabIndex = 4
        '
        'UcrButtons1
        '
        Me.UcrButtons1.Location = New System.Drawing.Point(2, 272)
        Me.UcrButtons1.Name = "UcrButtons1"
        Me.UcrButtons1.Size = New System.Drawing.Size(410, 32)
        Me.UcrButtons1.TabIndex = 5
        '
        'lblResponsevariable
        '
        Me.lblResponsevariable.AutoSize = True
        Me.lblResponsevariable.Location = New System.Drawing.Point(282, 61)
        Me.lblResponsevariable.Name = "lblResponsevariable"
        Me.lblResponsevariable.Size = New System.Drawing.Size(117, 13)
        Me.lblResponsevariable.TabIndex = 7
        Me.lblResponsevariable.Tag = "Response_variable"
        Me.lblResponsevariable.Text = "2nd Response Variable"
        '
        'lblTreatmentfactor
        '
        Me.lblTreatmentfactor.AutoSize = True
        Me.lblTreatmentfactor.Location = New System.Drawing.Point(282, 103)
        Me.lblTreatmentfactor.Name = "lblTreatmentfactor"
        Me.lblTreatmentfactor.Size = New System.Drawing.Size(85, 13)
        Me.lblTreatmentfactor.TabIndex = 8
        Me.lblTreatmentfactor.Tag = "Treatment_factor"
        Me.lblTreatmentfactor.Text = "Treatment factor"
        '
        'lblBlockingfactor
        '
        Me.lblBlockingfactor.AutoSize = True
        Me.lblBlockingfactor.Location = New System.Drawing.Point(285, 149)
        Me.lblBlockingfactor.Name = "lblBlockingfactor"
        Me.lblBlockingfactor.Size = New System.Drawing.Size(78, 13)
        Me.lblBlockingfactor.TabIndex = 9
        Me.lblBlockingfactor.Tag = "Blocking_factor"
        Me.lblBlockingfactor.Text = "Blocking factor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(281, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "1st Response Variable"
        '
        'chkContrasts
        '
        Me.chkContrasts.AutoSize = True
        Me.chkContrasts.Location = New System.Drawing.Point(11, 168)
        Me.chkContrasts.Name = "chkContrasts"
        Me.chkContrasts.Size = New System.Drawing.Size(70, 17)
        Me.chkContrasts.TabIndex = 11
        Me.chkContrasts.Text = "Contrasts"
        Me.chkContrasts.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(11, 207)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(89, 17)
        Me.CheckBox2.TabIndex = 12
        Me.CheckBox2.Text = "Save Results"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'dlgBivariateANOVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 300)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.chkContrasts)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblBlockingfactor)
        Me.Controls.Add(Me.lblTreatmentfactor)
        Me.Controls.Add(Me.lblResponsevariable)
        Me.Controls.Add(Me.UcrButtons1)
        Me.Controls.Add(Me.UcrReciverSingleB2)
        Me.Controls.Add(Me.UcrReceiverSingle2)
        Me.Controls.Add(Me.UcrReciverSingleB1)
        Me.Controls.Add(Me.UcrReceiverSingle1)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Name = "dlgBivariateANOVA"
        Me.Text = "dlgBivariateANOVA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents UcrReceiverSingle1 As ucrReceiverSingle
    Friend WithEvents UcrReciverSingleB1 As ucrReciverSingleB
    Friend WithEvents UcrReceiverSingle2 As ucrReceiverSingle
    Friend WithEvents UcrReciverSingleB2 As ucrReciverSingleB
    Friend WithEvents UcrButtons1 As ucrButtons
    Friend WithEvents lblResponsevariable As Label
    Friend WithEvents lblTreatmentfactor As Label
    Friend WithEvents lblBlockingfactor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkContrasts As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
End Class
