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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.chkContrasts = New System.Windows.Forms.CheckBox()
        Me.chkSaveResults = New System.Windows.Forms.CheckBox()
        Me.lbl1stRespVar = New System.Windows.Forms.Label()
        Me.lbl2ndRespVar = New System.Windows.Forms.Label()
        Me.lblTreatmentFactor = New System.Windows.Forms.Label()
        Me.lblBlockingFactor = New System.Windows.Forms.Label()
        Me.ucrReceiverBlockingFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverTreatmentFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiver2ndResponseVariable = New instat.ucrReceiverSingle()
        Me.ucrReceiver1stResponseVariable = New instat.ucrReceiverSingle()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'chkContrasts
        '
        Me.chkContrasts.AutoSize = True
        Me.chkContrasts.Location = New System.Drawing.Point(22, 216)
        Me.chkContrasts.Name = "chkContrasts"
        Me.chkContrasts.Size = New System.Drawing.Size(70, 17)
        Me.chkContrasts.TabIndex = 6
        Me.chkContrasts.Tag = "Contrasts"
        Me.chkContrasts.Text = "Contrasts"
        Me.chkContrasts.UseVisualStyleBackColor = True
        '
        'chkSaveResults
        '
        Me.chkSaveResults.AutoSize = True
        Me.chkSaveResults.Location = New System.Drawing.Point(22, 258)
        Me.chkSaveResults.Name = "chkSaveResults"
        Me.chkSaveResults.Size = New System.Drawing.Size(84, 17)
        Me.chkSaveResults.TabIndex = 7
        Me.chkSaveResults.Tag = "Save_results"
        Me.chkSaveResults.Text = "Save results"
        Me.chkSaveResults.UseVisualStyleBackColor = True
        '
        'lbl1stRespVar
        '
        Me.lbl1stRespVar.AutoSize = True
        Me.lbl1stRespVar.Location = New System.Drawing.Point(271, 36)
        Me.lbl1stRespVar.Name = "lbl1stRespVar"
        Me.lbl1stRespVar.Size = New System.Drawing.Size(112, 13)
        Me.lbl1stRespVar.TabIndex = 8
        Me.lbl1stRespVar.Tag = "Response_variable1"
        Me.lbl1stRespVar.Text = "1st Response variable"
        '
        'lbl2ndRespVar
        '
        Me.lbl2ndRespVar.AutoSize = True
        Me.lbl2ndRespVar.Location = New System.Drawing.Point(271, 80)
        Me.lbl2ndRespVar.Name = "lbl2ndRespVar"
        Me.lbl2ndRespVar.Size = New System.Drawing.Size(116, 13)
        Me.lbl2ndRespVar.TabIndex = 9
        Me.lbl2ndRespVar.Tag = "Response_variable2"
        Me.lbl2ndRespVar.Text = "2nd Response variable"
        '
        'lblTreatmentFactor
        '
        Me.lblTreatmentFactor.AutoSize = True
        Me.lblTreatmentFactor.Location = New System.Drawing.Point(271, 125)
        Me.lblTreatmentFactor.Name = "lblTreatmentFactor"
        Me.lblTreatmentFactor.Size = New System.Drawing.Size(85, 13)
        Me.lblTreatmentFactor.TabIndex = 10
        Me.lblTreatmentFactor.Tag = "Treatment_factor"
        Me.lblTreatmentFactor.Text = "Treatment factor"
        '
        'lblBlockingFactor
        '
        Me.lblBlockingFactor.AutoSize = True
        Me.lblBlockingFactor.Location = New System.Drawing.Point(271, 170)
        Me.lblBlockingFactor.Name = "lblBlockingFactor"
        Me.lblBlockingFactor.Size = New System.Drawing.Size(78, 13)
        Me.lblBlockingFactor.TabIndex = 11
        Me.lblBlockingFactor.Tag = "Blocking_factor"
        Me.lblBlockingFactor.Text = "Blocking factor"
        '
        'ucrReceiverBlockingFactor
        '
        Me.ucrReceiverBlockingFactor.Location = New System.Drawing.Point(271, 181)
        Me.ucrReceiverBlockingFactor.Name = "ucrReceiverBlockingFactor"
        Me.ucrReceiverBlockingFactor.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverBlockingFactor.TabIndex = 5
        '
        'ucrReceiverTreatmentFactor
        '
        Me.ucrReceiverTreatmentFactor.Location = New System.Drawing.Point(271, 137)
        Me.ucrReceiverTreatmentFactor.Name = "ucrReceiverTreatmentFactor"
        Me.ucrReceiverTreatmentFactor.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverTreatmentFactor.TabIndex = 4
        '
        'ucrReceiver2ndResponseVariable
        '
        Me.ucrReceiver2ndResponseVariable.Location = New System.Drawing.Point(271, 92)
        Me.ucrReceiver2ndResponseVariable.Name = "ucrReceiver2ndResponseVariable"
        Me.ucrReceiver2ndResponseVariable.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiver2ndResponseVariable.TabIndex = 3
        '
        'ucrReceiver1stResponseVariable
        '
        Me.ucrReceiver1stResponseVariable.Location = New System.Drawing.Point(271, 47)
        Me.ucrReceiver1stResponseVariable.Name = "ucrReceiver1stResponseVariable"
        Me.ucrReceiver1stResponseVariable.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiver1stResponseVariable.TabIndex = 2
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(12, 38)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(0, 297)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 54)
        Me.ucrBase.TabIndex = 0
        '
        'dlgBivariateANOVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 351)
        Me.Controls.Add(Me.lblBlockingFactor)
        Me.Controls.Add(Me.lblTreatmentFactor)
        Me.Controls.Add(Me.lbl2ndRespVar)
        Me.Controls.Add(Me.lbl1stRespVar)
        Me.Controls.Add(Me.chkSaveResults)
        Me.Controls.Add(Me.chkContrasts)
        Me.Controls.Add(Me.ucrReceiverBlockingFactor)
        Me.Controls.Add(Me.ucrReceiverTreatmentFactor)
        Me.Controls.Add(Me.ucrReceiver2ndResponseVariable)
        Me.Controls.Add(Me.ucrReceiver1stResponseVariable)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgBivariateANOVA"
        Me.Tag = "Bivariate_ANOVA"
        Me.Text = "Bivariate ANOVA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiver1stResponseVariable As ucrReceiverSingle
    Friend WithEvents ucrReceiver2ndResponseVariable As ucrReceiverSingle
    Friend WithEvents ucrReceiverTreatmentFactor As ucrReceiverSingle
    Friend WithEvents ucrReceiverBlockingFactor As ucrReceiverSingle
    Friend WithEvents chkContrasts As CheckBox
    Friend WithEvents chkSaveResults As CheckBox
    Friend WithEvents lbl1stRespVar As Label
    Friend WithEvents lbl2ndRespVar As Label
    Friend WithEvents lblTreatmentFactor As Label
    Friend WithEvents lblBlockingFactor As Label
End Class
