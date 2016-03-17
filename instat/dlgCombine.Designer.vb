<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCombine
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
        Me.txtSelectedFactors = New System.Windows.Forms.TextBox()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.lblSaveInto = New System.Windows.Forms.Label()
        Me.rdoCreateInteractionVariable = New System.Windows.Forms.RadioButton()
        Me.rdoCombineToNewFactor = New System.Windows.Forms.RadioButton()
        Me.ucrBase = New instat.ucrButtons()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.lstAvailableColumns = New System.Windows.Forms.ListBox()
        Me.txtTobeSavedFactors = New System.Windows.Forms.TextBox()
        Me.chkWithLabel = New System.Windows.Forms.CheckBox()
        Me.chkUseExitingFactorLevelCombinations = New System.Windows.Forms.CheckBox()
        Me.cboAvailableLabels = New System.Windows.Forms.ComboBox()
        Me.lblToImplement = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSelectedFactors
        '
        Me.txtSelectedFactors.Location = New System.Drawing.Point(12, 36)
        Me.txtSelectedFactors.Multiline = True
        Me.txtSelectedFactors.Name = "txtSelectedFactors"
        Me.txtSelectedFactors.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSelectedFactors.Size = New System.Drawing.Size(106, 43)
        Me.txtSelectedFactors.TabIndex = 9
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(12, 9)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(42, 13)
        Me.lblFactors.TabIndex = 11
        Me.lblFactors.Tag = "Factors"
        Me.lblFactors.Text = "Factors"
        '
        'lblSaveInto
        '
        Me.lblSaveInto.AutoSize = True
        Me.lblSaveInto.Location = New System.Drawing.Point(241, 9)
        Me.lblSaveInto.Name = "lblSaveInto"
        Me.lblSaveInto.Size = New System.Drawing.Size(52, 13)
        Me.lblSaveInto.TabIndex = 12
        Me.lblSaveInto.Tag = "Save_into"
        Me.lblSaveInto.Text = "Save into"
        '
        'rdoCreateInteractionVariable
        '
        Me.rdoCreateInteractionVariable.AutoSize = True
        Me.rdoCreateInteractionVariable.Checked = True
        Me.rdoCreateInteractionVariable.Location = New System.Drawing.Point(12, 198)
        Me.rdoCreateInteractionVariable.Name = "rdoCreateInteractionVariable"
        Me.rdoCreateInteractionVariable.Size = New System.Drawing.Size(149, 17)
        Me.rdoCreateInteractionVariable.TabIndex = 15
        Me.rdoCreateInteractionVariable.TabStop = True
        Me.rdoCreateInteractionVariable.Tag = "Create_Interaction_variable"
        Me.rdoCreateInteractionVariable.Text = "Create Interaction variable"
        Me.rdoCreateInteractionVariable.UseVisualStyleBackColor = True
        '
        'rdoCombineToNewFactor
        '
        Me.rdoCombineToNewFactor.AutoSize = True
        Me.rdoCombineToNewFactor.Enabled = False
        Me.rdoCombineToNewFactor.Location = New System.Drawing.Point(12, 221)
        Me.rdoCombineToNewFactor.Name = "rdoCombineToNewFactor"
        Me.rdoCombineToNewFactor.Size = New System.Drawing.Size(183, 17)
        Me.rdoCombineToNewFactor.TabIndex = 16
        Me.rdoCombineToNewFactor.Tag = "Combine_factors_into_a_new_factor"
        Me.rdoCombineToNewFactor.Text = "Combine factors into a new factor"
        Me.rdoCombineToNewFactor.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ucrBase.Location = New System.Drawing.Point(0, 304)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(404, 50)
        Me.ucrBase.TabIndex = 17
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(124, 47)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(37, 23)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Tag = "Add"
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(356, 47)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(37, 23)
        Me.cmdAdd.TabIndex = 22
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'lstAvailableColumns
        '
        Me.lstAvailableColumns.FormattingEnabled = True
        Me.lstAvailableColumns.Location = New System.Drawing.Point(244, 85)
        Me.lstAvailableColumns.Name = "lstAvailableColumns"
        Me.lstAvailableColumns.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstAvailableColumns.Size = New System.Drawing.Size(149, 95)
        Me.lstAvailableColumns.Sorted = True
        Me.lstAvailableColumns.TabIndex = 21
        '
        'txtTobeSavedFactors
        '
        Me.txtTobeSavedFactors.Location = New System.Drawing.Point(244, 36)
        Me.txtTobeSavedFactors.Multiline = True
        Me.txtTobeSavedFactors.Name = "txtTobeSavedFactors"
        Me.txtTobeSavedFactors.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTobeSavedFactors.Size = New System.Drawing.Size(106, 43)
        Me.txtTobeSavedFactors.TabIndex = 20
        '
        'chkWithLabel
        '
        Me.chkWithLabel.AutoSize = True
        Me.chkWithLabel.Enabled = False
        Me.chkWithLabel.Location = New System.Drawing.Point(37, 244)
        Me.chkWithLabel.Name = "chkWithLabel"
        Me.chkWithLabel.Size = New System.Drawing.Size(77, 17)
        Me.chkWithLabel.TabIndex = 23
        Me.chkWithLabel.Text = "With Label"
        Me.chkWithLabel.UseVisualStyleBackColor = True
        '
        'chkUseExitingFactorLevelCombinations
        '
        Me.chkUseExitingFactorLevelCombinations.AutoSize = True
        Me.chkUseExitingFactorLevelCombinations.Enabled = False
        Me.chkUseExitingFactorLevelCombinations.Location = New System.Drawing.Point(37, 267)
        Me.chkUseExitingFactorLevelCombinations.Name = "chkUseExitingFactorLevelCombinations"
        Me.chkUseExitingFactorLevelCombinations.Size = New System.Drawing.Size(225, 17)
        Me.chkUseExitingFactorLevelCombinations.TabIndex = 24
        Me.chkUseExitingFactorLevelCombinations.Tag = "Only_use_existing_factor_level_combinations"
        Me.chkUseExitingFactorLevelCombinations.Text = "Only use existing factor level combinations"
        Me.chkUseExitingFactorLevelCombinations.UseVisualStyleBackColor = True
        '
        'cboAvailableLabels
        '
        Me.cboAvailableLabels.Enabled = False
        Me.cboAvailableLabels.FormattingEnabled = True
        Me.cboAvailableLabels.Location = New System.Drawing.Point(145, 240)
        Me.cboAvailableLabels.Name = "cboAvailableLabels"
        Me.cboAvailableLabels.Size = New System.Drawing.Size(100, 21)
        Me.cboAvailableLabels.Sorted = True
        Me.cboAvailableLabels.TabIndex = 25
        '
        'lblToImplement
        '
        Me.lblToImplement.AutoSize = True
        Me.lblToImplement.Location = New System.Drawing.Point(9, 97)
        Me.lblToImplement.Name = "lblToImplement"
        Me.lblToImplement.Size = New System.Drawing.Size(167, 13)
        Me.lblToImplement.TabIndex = 26
        Me.lblToImplement.Text = "To implement selector with factors"
        '
        'dlgInteractions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 354)
        Me.Controls.Add(Me.lblToImplement)
        Me.Controls.Add(Me.cboAvailableLabels)
        Me.Controls.Add(Me.chkUseExitingFactorLevelCombinations)
        Me.Controls.Add(Me.chkWithLabel)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lstAvailableColumns)
        Me.Controls.Add(Me.txtTobeSavedFactors)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.rdoCombineToNewFactor)
        Me.Controls.Add(Me.rdoCreateInteractionVariable)
        Me.Controls.Add(Me.lblSaveInto)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.txtSelectedFactors)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgInteractions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Interactions"
        Me.Text = "Interactions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSelectedFactors As TextBox
    Friend WithEvents lblFactors As Label
    Friend WithEvents lblSaveInto As Label
    Friend WithEvents rdoCreateInteractionVariable As RadioButton
    Friend WithEvents rdoCombineToNewFactor As RadioButton
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents btnAdd As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents lstAvailableColumns As ListBox
    Friend WithEvents txtTobeSavedFactors As TextBox
    Friend WithEvents chkWithLabel As CheckBox
    Friend WithEvents chkUseExitingFactorLevelCombinations As CheckBox
    Friend WithEvents cboAvailableLabels As ComboBox
    Friend WithEvents lblToImplement As Label
End Class
