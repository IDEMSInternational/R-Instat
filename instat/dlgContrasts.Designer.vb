<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgContrasts
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
        Me.ucrSelectorForContrast = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverForContrasts = New instat.ucrReceiverSingle()
        Me.lblFactorReceiver = New System.Windows.Forms.Label()
        Me.ucrFactorLevelsAndLabels = New instat.ucrFactor()
        Me.chkOverwriteExistContrast = New System.Windows.Forms.CheckBox()
        Me.grpCodingSystems = New System.Windows.Forms.GroupBox()
        Me.rdoUserDefined = New System.Windows.Forms.RadioButton()
        Me.rdoSumToZero = New System.Windows.Forms.RadioButton()
        Me.rdoHemert = New System.Windows.Forms.RadioButton()
        Me.rdoPolynomials = New System.Windows.Forms.RadioButton()
        Me.rdoTreatControl = New System.Windows.Forms.RadioButton()
        Me.rdoCurrentContrasts = New System.Windows.Forms.RadioButton()
        Me.grpCodingSystems.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 304)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 60)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorForContrast
        '
        Me.ucrSelectorForContrast.bShowHiddenColumns = False
        Me.ucrSelectorForContrast.bUseCurrentFilter = False
        Me.ucrSelectorForContrast.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorForContrast.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForContrast.Name = "ucrSelectorForContrast"
        Me.ucrSelectorForContrast.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForContrast.TabIndex = 1
        '
        'ucrReceiverForContrasts
        '
        Me.ucrReceiverForContrasts.Location = New System.Drawing.Point(223, 32)
        Me.ucrReceiverForContrasts.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForContrasts.Name = "ucrReceiverForContrasts"
        Me.ucrReceiverForContrasts.Selector = Nothing
        Me.ucrReceiverForContrasts.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverForContrasts.TabIndex = 2
        '
        'lblFactorReceiver
        '
        Me.lblFactorReceiver.AutoSize = True
        Me.lblFactorReceiver.Location = New System.Drawing.Point(223, 13)
        Me.lblFactorReceiver.Name = "lblFactorReceiver"
        Me.lblFactorReceiver.Size = New System.Drawing.Size(90, 13)
        Me.lblFactorReceiver.TabIndex = 3
        Me.lblFactorReceiver.Text = "Selected Variable"
        '
        'ucrFactorLevelsAndLabels
        '
        Me.ucrFactorLevelsAndLabels.AutoSize = True
        Me.ucrFactorLevelsAndLabels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrFactorLevelsAndLabels.clsReceiver = Nothing
        Me.ucrFactorLevelsAndLabels.Location = New System.Drawing.Point(226, 74)
        Me.ucrFactorLevelsAndLabels.Name = "ucrFactorLevelsAndLabels"
        Me.ucrFactorLevelsAndLabels.shtCurrSheet = Nothing
        Me.ucrFactorLevelsAndLabels.Size = New System.Drawing.Size(184, 119)
        Me.ucrFactorLevelsAndLabels.TabIndex = 4
        '
        'chkOverwriteExistContrast
        '
        Me.chkOverwriteExistContrast.AutoSize = True
        Me.chkOverwriteExistContrast.Location = New System.Drawing.Point(13, 281)
        Me.chkOverwriteExistContrast.Name = "chkOverwriteExistContrast"
        Me.chkOverwriteExistContrast.Size = New System.Drawing.Size(192, 17)
        Me.chkOverwriteExistContrast.TabIndex = 11
        Me.chkOverwriteExistContrast.Text = "Overwrite existing contrast columns"
        Me.chkOverwriteExistContrast.UseVisualStyleBackColor = True
        '
        'grpCodingSystems
        '
        Me.grpCodingSystems.Controls.Add(Me.rdoUserDefined)
        Me.grpCodingSystems.Controls.Add(Me.rdoSumToZero)
        Me.grpCodingSystems.Controls.Add(Me.rdoHemert)
        Me.grpCodingSystems.Controls.Add(Me.rdoPolynomials)
        Me.grpCodingSystems.Controls.Add(Me.rdoTreatControl)
        Me.grpCodingSystems.Controls.Add(Me.rdoCurrentContrasts)
        Me.grpCodingSystems.Location = New System.Drawing.Point(12, 199)
        Me.grpCodingSystems.Name = "grpCodingSystems"
        Me.grpCodingSystems.Size = New System.Drawing.Size(398, 66)
        Me.grpCodingSystems.TabIndex = 12
        Me.grpCodingSystems.TabStop = False
        '
        'rdoUserDefined
        '
        Me.rdoUserDefined.AutoSize = True
        Me.rdoUserDefined.Location = New System.Drawing.Point(227, 40)
        Me.rdoUserDefined.Name = "rdoUserDefined"
        Me.rdoUserDefined.Size = New System.Drawing.Size(145, 17)
        Me.rdoUserDefined.TabIndex = 16
        Me.rdoUserDefined.TabStop = True
        Me.rdoUserDefined.Text = ". User Defined (overwrite)"
        Me.rdoUserDefined.UseVisualStyleBackColor = True
        '
        'rdoSumToZero
        '
        Me.rdoSumToZero.AutoSize = True
        Me.rdoSumToZero.Location = New System.Drawing.Point(118, 40)
        Me.rdoSumToZero.Name = "rdoSumToZero"
        Me.rdoSumToZero.Size = New System.Drawing.Size(83, 17)
        Me.rdoSumToZero.TabIndex = 15
        Me.rdoSumToZero.TabStop = True
        Me.rdoSumToZero.Text = "Sum to Zero"
        Me.rdoSumToZero.UseVisualStyleBackColor = True
        '
        'rdoHemert
        '
        Me.rdoHemert.AutoSize = True
        Me.rdoHemert.Location = New System.Drawing.Point(118, 17)
        Me.rdoHemert.Name = "rdoHemert"
        Me.rdoHemert.Size = New System.Drawing.Size(61, 17)
        Me.rdoHemert.TabIndex = 14
        Me.rdoHemert.TabStop = True
        Me.rdoHemert.Text = "Helmert"
        Me.rdoHemert.UseVisualStyleBackColor = True
        '
        'rdoPolynomials
        '
        Me.rdoPolynomials.AutoSize = True
        Me.rdoPolynomials.Location = New System.Drawing.Point(227, 17)
        Me.rdoPolynomials.Name = "rdoPolynomials"
        Me.rdoPolynomials.Size = New System.Drawing.Size(80, 17)
        Me.rdoPolynomials.TabIndex = 13
        Me.rdoPolynomials.TabStop = True
        Me.rdoPolynomials.Text = "Polynomials"
        Me.rdoPolynomials.UseVisualStyleBackColor = True
        '
        'rdoTreatControl
        '
        Me.rdoTreatControl.AutoSize = True
        Me.rdoTreatControl.Location = New System.Drawing.Point(7, 41)
        Me.rdoTreatControl.Name = "rdoTreatControl"
        Me.rdoTreatControl.Size = New System.Drawing.Size(111, 17)
        Me.rdoTreatControl.TabIndex = 12
        Me.rdoTreatControl.TabStop = True
        Me.rdoTreatControl.Text = "Treatment/Control"
        Me.rdoTreatControl.UseVisualStyleBackColor = True
        '
        'rdoCurrentContrasts
        '
        Me.rdoCurrentContrasts.AutoSize = True
        Me.rdoCurrentContrasts.Location = New System.Drawing.Point(7, 17)
        Me.rdoCurrentContrasts.Name = "rdoCurrentContrasts"
        Me.rdoCurrentContrasts.Size = New System.Drawing.Size(108, 17)
        Me.rdoCurrentContrasts.TabIndex = 11
        Me.rdoCurrentContrasts.TabStop = True
        Me.rdoCurrentContrasts.Text = "Current contrasts "
        Me.rdoCurrentContrasts.UseVisualStyleBackColor = True
        '
        'dlgContrasts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 364)
        Me.Controls.Add(Me.grpCodingSystems)
        Me.Controls.Add(Me.chkOverwriteExistContrast)
        Me.Controls.Add(Me.ucrFactorLevelsAndLabels)
        Me.Controls.Add(Me.lblFactorReceiver)
        Me.Controls.Add(Me.ucrReceiverForContrasts)
        Me.Controls.Add(Me.ucrSelectorForContrast)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgContrasts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Contrasts"
        Me.Text = "Contrasts"
        Me.grpCodingSystems.ResumeLayout(False)
        Me.grpCodingSystems.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForContrast As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverForContrasts As ucrReceiverSingle
    Friend WithEvents lblFactorReceiver As Label
    Friend WithEvents ucrFactorLevelsAndLabels As ucrFactor
    Friend WithEvents chkOverwriteExistContrast As CheckBox
    Friend WithEvents grpCodingSystems As GroupBox
    Friend WithEvents rdoUserDefined As RadioButton
    Friend WithEvents rdoSumToZero As RadioButton
    Friend WithEvents rdoHemert As RadioButton
    Friend WithEvents rdoPolynomials As RadioButton
    Friend WithEvents rdoTreatControl As RadioButton
    Friend WithEvents rdoCurrentContrasts As RadioButton
End Class
