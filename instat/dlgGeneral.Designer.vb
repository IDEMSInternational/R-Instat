<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgGeneral
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
        Me.ucrSelectorGeneralANOVA = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverYVariable = New instat.ucrReceiverSingle()
        Me.ucrReceiverTreatmentFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverLayout = New instat.ucrReceiverSingle()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.lblTreatmentStructure = New System.Windows.Forms.Label()
        Me.lblLayout = New System.Windows.Forms.Label()
        Me.rdoReplicates = New System.Windows.Forms.RadioButton()
        Me.rdoAnalysis = New System.Windows.Forms.RadioButton()
        Me.chkSaveModel = New System.Windows.Forms.CheckBox()
        Me.ucrModelName = New instat.ucrVariableName()
        Me.cmdGeneralANOVAOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 278)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 51)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorGeneralANOVA
        '
        Me.ucrSelectorGeneralANOVA.Location = New System.Drawing.Point(0, 31)
        Me.ucrSelectorGeneralANOVA.Name = "ucrSelectorGeneralANOVA"
        Me.ucrSelectorGeneralANOVA.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorGeneralANOVA.TabIndex = 1
        '
        'ucrReceiverYVariable
        '
        Me.ucrReceiverYVariable.Location = New System.Drawing.Point(278, 65)
        Me.ucrReceiverYVariable.Name = "ucrReceiverYVariable"
        Me.ucrReceiverYVariable.Selector = Nothing
        Me.ucrReceiverYVariable.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverYVariable.TabIndex = 2
        '
        'ucrReceiverTreatmentFactor
        '
        Me.ucrReceiverTreatmentFactor.Location = New System.Drawing.Point(278, 114)
        Me.ucrReceiverTreatmentFactor.Name = "ucrReceiverTreatmentFactor"
        Me.ucrReceiverTreatmentFactor.Selector = Nothing
        Me.ucrReceiverTreatmentFactor.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverTreatmentFactor.TabIndex = 3
        '
        'ucrReceiverLayout
        '
        Me.ucrReceiverLayout.Location = New System.Drawing.Point(278, 164)
        Me.ucrReceiverLayout.Name = "ucrReceiverLayout"
        Me.ucrReceiverLayout.Selector = Nothing
        Me.ucrReceiverLayout.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverLayout.TabIndex = 4
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.Location = New System.Drawing.Point(284, 53)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(55, 13)
        Me.lblYVariable.TabIndex = 5
        Me.lblYVariable.Tag = "Y Variable"
        Me.lblYVariable.Text = "Y Variable"
        '
        'lblTreatmentStructure
        '
        Me.lblTreatmentStructure.AutoSize = True
        Me.lblTreatmentStructure.Location = New System.Drawing.Point(284, 101)
        Me.lblTreatmentStructure.Name = "lblTreatmentStructure"
        Me.lblTreatmentStructure.Size = New System.Drawing.Size(101, 13)
        Me.lblTreatmentStructure.TabIndex = 6
        Me.lblTreatmentStructure.Tag = "Treatment_Structure"
        Me.lblTreatmentStructure.Text = "Treatment Structure"
        '
        'lblLayout
        '
        Me.lblLayout.AutoSize = True
        Me.lblLayout.Location = New System.Drawing.Point(284, 152)
        Me.lblLayout.Name = "lblLayout"
        Me.lblLayout.Size = New System.Drawing.Size(39, 13)
        Me.lblLayout.TabIndex = 7
        Me.lblLayout.Tag = "Layout"
        Me.lblLayout.Text = "Layout"
        '
        'rdoReplicates
        '
        Me.rdoReplicates.AutoSize = True
        Me.rdoReplicates.Location = New System.Drawing.Point(223, 8)
        Me.rdoReplicates.Name = "rdoReplicates"
        Me.rdoReplicates.Size = New System.Drawing.Size(75, 17)
        Me.rdoReplicates.TabIndex = 8
        Me.rdoReplicates.TabStop = True
        Me.rdoReplicates.Tag = "Replicates"
        Me.rdoReplicates.Text = "Replicates"
        Me.rdoReplicates.UseVisualStyleBackColor = True
        '
        'rdoAnalysis
        '
        Me.rdoAnalysis.AutoSize = True
        Me.rdoAnalysis.Location = New System.Drawing.Point(47, 8)
        Me.rdoAnalysis.Name = "rdoAnalysis"
        Me.rdoAnalysis.Size = New System.Drawing.Size(63, 17)
        Me.rdoAnalysis.TabIndex = 9
        Me.rdoAnalysis.TabStop = True
        Me.rdoAnalysis.Tag = "Analysis"
        Me.rdoAnalysis.Text = "Analysis"
        Me.rdoAnalysis.UseVisualStyleBackColor = True
        '
        'chkSaveModel
        '
        Me.chkSaveModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkSaveModel.Location = New System.Drawing.Point(17, 225)
        Me.chkSaveModel.Name = "chkSaveModel"
        Me.chkSaveModel.Size = New System.Drawing.Size(104, 24)
        Me.chkSaveModel.TabIndex = 10
        Me.chkSaveModel.Tag = "Save_Model"
        Me.chkSaveModel.Text = "Save Model"
        Me.chkSaveModel.UseVisualStyleBackColor = True
        '
        'ucrModelName
        '
        Me.ucrModelName.Location = New System.Drawing.Point(125, 223)
        Me.ucrModelName.Name = "ucrModelName"
        Me.ucrModelName.Size = New System.Drawing.Size(149, 23)
        Me.ucrModelName.TabIndex = 11
        '
        'cmdGeneralANOVAOptions
        '
        Me.cmdGeneralANOVAOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGeneralANOVAOptions.Location = New System.Drawing.Point(280, 223)
        Me.cmdGeneralANOVAOptions.Name = "cmdGeneralANOVAOptions"
        Me.cmdGeneralANOVAOptions.Size = New System.Drawing.Size(142, 23)
        Me.cmdGeneralANOVAOptions.TabIndex = 12
        Me.cmdGeneralANOVAOptions.Tag = "General_ANOVA_Options..."
        Me.cmdGeneralANOVAOptions.Text = "General ANOVA Options..."
        Me.cmdGeneralANOVAOptions.UseVisualStyleBackColor = True
        '
        'dlgGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 332)
        Me.Controls.Add(Me.chkSaveModel)
        Me.Controls.Add(Me.ucrModelName)
        Me.Controls.Add(Me.cmdGeneralANOVAOptions)
        Me.Controls.Add(Me.rdoAnalysis)
        Me.Controls.Add(Me.rdoReplicates)
        Me.Controls.Add(Me.lblLayout)
        Me.Controls.Add(Me.lblTreatmentStructure)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.ucrReceiverLayout)
        Me.Controls.Add(Me.ucrReceiverTreatmentFactor)
        Me.Controls.Add(Me.ucrReceiverYVariable)
        Me.Controls.Add(Me.ucrSelectorGeneralANOVA)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "General_ANOVA"
        Me.Text = "General ANOVA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorGeneralANOVA As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverYVariable As ucrReceiverSingle
    Friend WithEvents ucrReceiverTreatmentFactor As ucrReceiverSingle
    Friend WithEvents ucrReceiverLayout As ucrReceiverSingle
    Friend WithEvents lblYVariable As Label
    Friend WithEvents lblTreatmentStructure As Label
    Friend WithEvents lblLayout As Label
    Friend WithEvents rdoReplicates As RadioButton
    Friend WithEvents rdoAnalysis As RadioButton
    Friend WithEvents chkSaveModel As CheckBox
    Friend WithEvents ucrModelName As ucrVariableName
    Friend WithEvents cmdGeneralANOVAOptions As Button
End Class
