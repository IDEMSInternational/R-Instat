<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgfactor
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
        Me.ucrFactorDataSelector = New instat.ucrSelectorAddRemove()
        Me.lblSelectedColumn = New System.Windows.Forms.Label()
        Me.ucrFactorSingleReceiver = New instat.ucrReceiverSingle()
        Me.grpFactor = New System.Windows.Forms.GroupBox()
        Me.cboAttachtoExistingLabelColumn = New System.Windows.Forms.ComboBox()
        Me.rdoMakeFactorOrdinaryVariable = New System.Windows.Forms.RadioButton()
        Me.rdoAttachtoNewLabelColumn = New System.Windows.Forms.RadioButton()
        Me.rdoAttachtoExistingLabelColumn = New System.Windows.Forms.RadioButton()
        Me.rdoDetachLabelColumn = New System.Windows.Forms.RadioButton()
        Me.chkCopyResultsintoaNewColumn = New System.Windows.Forms.CheckBox()
        Me.grpFactor.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(-1, 294)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'ucrFactorDataSelector
        '
        Me.ucrFactorDataSelector.Location = New System.Drawing.Point(-2, 12)
        Me.ucrFactorDataSelector.Name = "ucrFactorDataSelector"
        Me.ucrFactorDataSelector.Size = New System.Drawing.Size(203, 127)
        Me.ucrFactorDataSelector.TabIndex = 1
        '
        'lblSelectedColumn
        '
        Me.lblSelectedColumn.AutoSize = True
        Me.lblSelectedColumn.Location = New System.Drawing.Point(221, 30)
        Me.lblSelectedColumn.Name = "lblSelectedColumn"
        Me.lblSelectedColumn.Size = New System.Drawing.Size(87, 13)
        Me.lblSelectedColumn.TabIndex = 2
        Me.lblSelectedColumn.Tag = "Selected_Column"
        Me.lblSelectedColumn.Text = "Selected Column"
        '
        'ucrFactorSingleReceiver
        '
        Me.ucrFactorSingleReceiver.Location = New System.Drawing.Point(216, 46)
        Me.ucrFactorSingleReceiver.Name = "ucrFactorSingleReceiver"
        Me.ucrFactorSingleReceiver.Size = New System.Drawing.Size(130, 26)
        Me.ucrFactorSingleReceiver.TabIndex = 3
        '
        'grpFactor
        '
        Me.grpFactor.Controls.Add(Me.cboAttachtoExistingLabelColumn)
        Me.grpFactor.Controls.Add(Me.rdoMakeFactorOrdinaryVariable)
        Me.grpFactor.Controls.Add(Me.rdoAttachtoNewLabelColumn)
        Me.grpFactor.Controls.Add(Me.rdoAttachtoExistingLabelColumn)
        Me.grpFactor.Controls.Add(Me.rdoDetachLabelColumn)
        Me.grpFactor.Location = New System.Drawing.Point(13, 146)
        Me.grpFactor.Name = "grpFactor"
        Me.grpFactor.Size = New System.Drawing.Size(231, 115)
        Me.grpFactor.TabIndex = 4
        Me.grpFactor.TabStop = False
        Me.grpFactor.Tag = "Change_An_Existing_Factor"
        Me.grpFactor.Text = "Change An Existing Factor"
        '
        'cboAttachtoExistingLabelColumn
        '
        Me.cboAttachtoExistingLabelColumn.FormattingEnabled = True
        Me.cboAttachtoExistingLabelColumn.Items.AddRange(New Object() {"L1", "L2", "L3", "L4"})
        Me.cboAttachtoExistingLabelColumn.Location = New System.Drawing.Point(178, 43)
        Me.cboAttachtoExistingLabelColumn.Name = "cboAttachtoExistingLabelColumn"
        Me.cboAttachtoExistingLabelColumn.Size = New System.Drawing.Size(50, 21)
        Me.cboAttachtoExistingLabelColumn.TabIndex = 1
        '
        'rdoMakeFactorOrdinaryVariable
        '
        Me.rdoMakeFactorOrdinaryVariable.AutoSize = True
        Me.rdoMakeFactorOrdinaryVariable.Location = New System.Drawing.Point(6, 89)
        Me.rdoMakeFactorOrdinaryVariable.Name = "rdoMakeFactorOrdinaryVariable"
        Me.rdoMakeFactorOrdinaryVariable.Size = New System.Drawing.Size(183, 17)
        Me.rdoMakeFactorOrdinaryVariable.TabIndex = 0
        Me.rdoMakeFactorOrdinaryVariable.TabStop = True
        Me.rdoMakeFactorOrdinaryVariable.Tag = "Make_Factor_an_Ordinary_Variable"
        Me.rdoMakeFactorOrdinaryVariable.Text = "Make Factor an Ordinary Variable"
        Me.rdoMakeFactorOrdinaryVariable.UseVisualStyleBackColor = True
        '
        'rdoAttachtoNewLabelColumn
        '
        Me.rdoAttachtoNewLabelColumn.AutoSize = True
        Me.rdoAttachtoNewLabelColumn.Location = New System.Drawing.Point(6, 66)
        Me.rdoAttachtoNewLabelColumn.Name = "rdoAttachtoNewLabelColumn"
        Me.rdoAttachtoNewLabelColumn.Size = New System.Drawing.Size(160, 17)
        Me.rdoAttachtoNewLabelColumn.TabIndex = 0
        Me.rdoAttachtoNewLabelColumn.TabStop = True
        Me.rdoAttachtoNewLabelColumn.Tag = "Attach_to_New_Label_Column"
        Me.rdoAttachtoNewLabelColumn.Text = "Attach to New Label Column"
        Me.rdoAttachtoNewLabelColumn.UseVisualStyleBackColor = True
        '
        'rdoAttachtoExistingLabelColumn
        '
        Me.rdoAttachtoExistingLabelColumn.AutoSize = True
        Me.rdoAttachtoExistingLabelColumn.Location = New System.Drawing.Point(6, 43)
        Me.rdoAttachtoExistingLabelColumn.Name = "rdoAttachtoExistingLabelColumn"
        Me.rdoAttachtoExistingLabelColumn.Size = New System.Drawing.Size(174, 17)
        Me.rdoAttachtoExistingLabelColumn.TabIndex = 0
        Me.rdoAttachtoExistingLabelColumn.TabStop = True
        Me.rdoAttachtoExistingLabelColumn.Tag = "Attach_to_Existing_Label_Column"
        Me.rdoAttachtoExistingLabelColumn.Text = "Attach to Existing Label Column"
        Me.rdoAttachtoExistingLabelColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoAttachtoExistingLabelColumn.UseVisualStyleBackColor = True
        '
        'rdoDetachLabelColumn
        '
        Me.rdoDetachLabelColumn.AutoSize = True
        Me.rdoDetachLabelColumn.Location = New System.Drawing.Point(7, 20)
        Me.rdoDetachLabelColumn.Name = "rdoDetachLabelColumn"
        Me.rdoDetachLabelColumn.Size = New System.Drawing.Size(127, 17)
        Me.rdoDetachLabelColumn.TabIndex = 0
        Me.rdoDetachLabelColumn.TabStop = True
        Me.rdoDetachLabelColumn.Tag = "Detach_Label_Column"
        Me.rdoDetachLabelColumn.Text = "Detach Label Column"
        Me.rdoDetachLabelColumn.UseVisualStyleBackColor = True
        '
        'chkCopyResultsintoaNewColumn
        '
        Me.chkCopyResultsintoaNewColumn.AutoSize = True
        Me.chkCopyResultsintoaNewColumn.Location = New System.Drawing.Point(13, 268)
        Me.chkCopyResultsintoaNewColumn.Name = "chkCopyResultsintoaNewColumn"
        Me.chkCopyResultsintoaNewColumn.Size = New System.Drawing.Size(180, 17)
        Me.chkCopyResultsintoaNewColumn.TabIndex = 5
        Me.chkCopyResultsintoaNewColumn.Tag = "Copy_Results_into_a_New_Column"
        Me.chkCopyResultsintoaNewColumn.Text = "Copy Results into a New Column"
        Me.chkCopyResultsintoaNewColumn.UseVisualStyleBackColor = True
        '
        'dlgfactor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 329)
        Me.Controls.Add(Me.chkCopyResultsintoaNewColumn)
        Me.Controls.Add(Me.grpFactor)
        Me.Controls.Add(Me.ucrFactorSingleReceiver)
        Me.Controls.Add(Me.lblSelectedColumn)
        Me.Controls.Add(Me.ucrFactorDataSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgfactor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factor"
        Me.grpFactor.ResumeLayout(False)
        Me.grpFactor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrFactorDataSelector As ucrSelectorAddRemove
    Friend WithEvents lblSelectedColumn As Label
    Friend WithEvents ucrFactorSingleReceiver As ucrReceiverSingle
    Friend WithEvents grpFactor As GroupBox
    Friend WithEvents cboAttachtoExistingLabelColumn As ComboBox
    Friend WithEvents rdoMakeFactorOrdinaryVariable As RadioButton
    Friend WithEvents rdoAttachtoNewLabelColumn As RadioButton
    Friend WithEvents rdoAttachtoExistingLabelColumn As RadioButton
    Friend WithEvents rdoDetachLabelColumn As RadioButton
    Friend WithEvents chkCopyResultsintoaNewColumn As CheckBox
End Class
