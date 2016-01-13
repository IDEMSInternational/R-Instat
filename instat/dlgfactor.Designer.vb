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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.lblDataColumn = New System.Windows.Forms.Label()
        Me.grpMakeVariableIntoFactor = New System.Windows.Forms.GroupBox()
        Me.rdoNumberOfLevels = New System.Windows.Forms.RadioButton()
        Me.rdoAttachToExistingLabelColumn = New System.Windows.Forms.RadioButton()
        Me.rdoAttchToNewLabelColumn = New System.Windows.Forms.RadioButton()
        Me.chkCopyResultIntoNewColumn = New System.Windows.Forms.CheckBox()
        Me.txtNumberOfLevels = New System.Windows.Forms.TextBox()
        Me.rdoGenerateNewLabelColumn = New System.Windows.Forms.RadioButton()
        Me.grpMakeVariableIntoFactor.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(2, 284)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(12, 12)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 1
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(244, 36)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverFactor.TabIndex = 2
        '
        'lblDataColumn
        '
        Me.lblDataColumn.AutoSize = True
        Me.lblDataColumn.Location = New System.Drawing.Point(244, 12)
        Me.lblDataColumn.Name = "lblDataColumn"
        Me.lblDataColumn.Size = New System.Drawing.Size(67, 13)
        Me.lblDataColumn.TabIndex = 3
        Me.lblDataColumn.Tag = "Data_column"
        Me.lblDataColumn.Text = "Data column"
        '
        'grpMakeVariableIntoFactor
        '
        Me.grpMakeVariableIntoFactor.Controls.Add(Me.txtNumberOfLevels)
        Me.grpMakeVariableIntoFactor.Controls.Add(Me.rdoGenerateNewLabelColumn)
        Me.grpMakeVariableIntoFactor.Controls.Add(Me.rdoAttchToNewLabelColumn)
        Me.grpMakeVariableIntoFactor.Controls.Add(Me.rdoAttachToExistingLabelColumn)
        Me.grpMakeVariableIntoFactor.Controls.Add(Me.rdoNumberOfLevels)
        Me.grpMakeVariableIntoFactor.Location = New System.Drawing.Point(12, 145)
        Me.grpMakeVariableIntoFactor.Name = "grpMakeVariableIntoFactor"
        Me.grpMakeVariableIntoFactor.Size = New System.Drawing.Size(323, 110)
        Me.grpMakeVariableIntoFactor.TabIndex = 4
        Me.grpMakeVariableIntoFactor.TabStop = False
        Me.grpMakeVariableIntoFactor.Tag = "Make_variable_into _a_factor"
        Me.grpMakeVariableIntoFactor.Text = "Make variable into a factor"
        '
        'rdoNumberOfLevels
        '
        Me.rdoNumberOfLevels.AutoSize = True
        Me.rdoNumberOfLevels.Location = New System.Drawing.Point(6, 19)
        Me.rdoNumberOfLevels.Name = "rdoNumberOfLevels"
        Me.rdoNumberOfLevels.Size = New System.Drawing.Size(104, 17)
        Me.rdoNumberOfLevels.TabIndex = 0
        Me.rdoNumberOfLevels.TabStop = True
        Me.rdoNumberOfLevels.Tag = "Number_of_levels"
        Me.rdoNumberOfLevels.Text = "Number of levels"
        Me.rdoNumberOfLevels.UseVisualStyleBackColor = True
        '
        'rdoAttachToExistingLabelColumn
        '
        Me.rdoAttachToExistingLabelColumn.AutoSize = True
        Me.rdoAttachToExistingLabelColumn.Location = New System.Drawing.Point(6, 42)
        Me.rdoAttachToExistingLabelColumn.Name = "rdoAttachToExistingLabelColumn"
        Me.rdoAttachToExistingLabelColumn.Size = New System.Drawing.Size(168, 17)
        Me.rdoAttachToExistingLabelColumn.TabIndex = 0
        Me.rdoAttachToExistingLabelColumn.TabStop = True
        Me.rdoAttachToExistingLabelColumn.Tag = "Attach_to_existing_label_column"
        Me.rdoAttachToExistingLabelColumn.Text = "Attach to existing label column"
        Me.rdoAttachToExistingLabelColumn.UseVisualStyleBackColor = True
        '
        'rdoAttchToNewLabelColumn
        '
        Me.rdoAttchToNewLabelColumn.AutoSize = True
        Me.rdoAttchToNewLabelColumn.Location = New System.Drawing.Point(6, 65)
        Me.rdoAttchToNewLabelColumn.Name = "rdoAttchToNewLabelColumn"
        Me.rdoAttchToNewLabelColumn.Size = New System.Drawing.Size(162, 17)
        Me.rdoAttchToNewLabelColumn.TabIndex = 0
        Me.rdoAttchToNewLabelColumn.TabStop = True
        Me.rdoAttchToNewLabelColumn.Tag = "Attach_to_a_new_label_column"
        Me.rdoAttchToNewLabelColumn.Text = "Attach to a new label column"
        Me.rdoAttchToNewLabelColumn.UseVisualStyleBackColor = True
        '
        'chkCopyResultIntoNewColumn
        '
        Me.chkCopyResultIntoNewColumn.AutoSize = True
        Me.chkCopyResultIntoNewColumn.Location = New System.Drawing.Point(12, 261)
        Me.chkCopyResultIntoNewColumn.Name = "chkCopyResultIntoNewColumn"
        Me.chkCopyResultIntoNewColumn.Size = New System.Drawing.Size(167, 17)
        Me.chkCopyResultIntoNewColumn.TabIndex = 5
        Me.chkCopyResultIntoNewColumn.Tag = "Copy_result_into_a_new_column"
        Me.chkCopyResultIntoNewColumn.Text = "Copy result into a new column"
        Me.chkCopyResultIntoNewColumn.UseVisualStyleBackColor = True
        '
        'txtNumberOfLevels
        '
        Me.txtNumberOfLevels.Location = New System.Drawing.Point(116, 19)
        Me.txtNumberOfLevels.Name = "txtNumberOfLevels"
        Me.txtNumberOfLevels.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberOfLevels.TabIndex = 1
        '
        'rdoGenerateNewLabelColumn
        '
        Me.rdoGenerateNewLabelColumn.AutoSize = True
        Me.rdoGenerateNewLabelColumn.Location = New System.Drawing.Point(6, 87)
        Me.rdoGenerateNewLabelColumn.Name = "rdoGenerateNewLabelColumn"
        Me.rdoGenerateNewLabelColumn.Size = New System.Drawing.Size(201, 17)
        Me.rdoGenerateNewLabelColumn.TabIndex = 0
        Me.rdoGenerateNewLabelColumn.TabStop = True
        Me.rdoGenerateNewLabelColumn.Tag = "Generate_new_label_column_from_data"
        Me.rdoGenerateNewLabelColumn.Text = "Generate new label column from data"
        Me.rdoGenerateNewLabelColumn.UseVisualStyleBackColor = True
        '
        'dlgfactor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 328)
        Me.Controls.Add(Me.chkCopyResultIntoNewColumn)
        Me.Controls.Add(Me.grpMakeVariableIntoFactor)
        Me.Controls.Add(Me.lblDataColumn)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgfactor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Factor"
        Me.Text = "Factor"
        Me.grpMakeVariableIntoFactor.ResumeLayout(False)
        Me.grpMakeVariableIntoFactor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents lblDataColumn As Label
    Friend WithEvents grpMakeVariableIntoFactor As GroupBox
    Friend WithEvents rdoNumberOfLevels As RadioButton
    Friend WithEvents txtNumberOfLevels As TextBox
    Friend WithEvents rdoGenerateNewLabelColumn As RadioButton
    Friend WithEvents rdoAttchToNewLabelColumn As RadioButton
    Friend WithEvents rdoAttachToExistingLabelColumn As RadioButton
    Friend WithEvents chkCopyResultIntoNewColumn As CheckBox
End Class
