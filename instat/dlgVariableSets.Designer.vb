<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgVariableSets
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.lblSelectedSet = New System.Windows.Forms.Label()
        Me.rdoDelete = New System.Windows.Forms.RadioButton()
        Me.rdoEdit = New System.Windows.Forms.RadioButton()
        Me.rdoMake = New System.Windows.Forms.RadioButton()
        Me.lblSetName = New System.Windows.Forms.Label()
        Me.lblVariables = New System.Windows.Forms.Label()
        Me.ucrInputSetNewName = New instat.ucrInputTextBox()
        Me.ucrReceiverSelectedSet = New instat.ucrReceiverSingle()
        Me.ucrReceiverMultipleVariables = New instat.ucrReceiverMultiple()
        Me.ucrSelectorVariableSets = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'lblSelectedSet
        '
        Me.lblSelectedSet.AutoSize = True
        Me.lblSelectedSet.Location = New System.Drawing.Point(351, 72)
        Me.lblSelectedSet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectedSet.Name = "lblSelectedSet"
        Me.lblSelectedSet.Size = New System.Drawing.Size(105, 20)
        Me.lblSelectedSet.TabIndex = 14
        Me.lblSelectedSet.Tag = ""
        Me.lblSelectedSet.Text = "Selected Set:"
        '
        'rdoDelete
        '
        Me.rdoDelete.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDelete.FlatAppearance.BorderSize = 2
        Me.rdoDelete.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDelete.Location = New System.Drawing.Point(380, 14)
        Me.rdoDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoDelete.Name = "rdoDelete"
        Me.rdoDelete.Size = New System.Drawing.Size(166, 43)
        Me.rdoDelete.TabIndex = 19
        Me.rdoDelete.TabStop = True
        Me.rdoDelete.Tag = ""
        Me.rdoDelete.Text = "Delete"
        Me.rdoDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDelete.UseVisualStyleBackColor = True
        '
        'rdoEdit
        '
        Me.rdoEdit.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEdit.FlatAppearance.BorderSize = 2
        Me.rdoEdit.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoEdit.Location = New System.Drawing.Point(217, 14)
        Me.rdoEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoEdit.Name = "rdoEdit"
        Me.rdoEdit.Size = New System.Drawing.Size(166, 43)
        Me.rdoEdit.TabIndex = 18
        Me.rdoEdit.TabStop = True
        Me.rdoEdit.Tag = ""
        Me.rdoEdit.Text = "Edit"
        Me.rdoEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoEdit.UseVisualStyleBackColor = True
        '
        'rdoMake
        '
        Me.rdoMake.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMake.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMake.FlatAppearance.BorderSize = 2
        Me.rdoMake.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMake.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMake.Location = New System.Drawing.Point(54, 14)
        Me.rdoMake.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoMake.Name = "rdoMake"
        Me.rdoMake.Size = New System.Drawing.Size(166, 43)
        Me.rdoMake.TabIndex = 17
        Me.rdoMake.TabStop = True
        Me.rdoMake.Tag = ""
        Me.rdoMake.Text = "Make"
        Me.rdoMake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMake.UseVisualStyleBackColor = True
        '
        'lblSetName
        '
        Me.lblSetName.AutoSize = True
        Me.lblSetName.Location = New System.Drawing.Point(351, 336)
        Me.lblSetName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSetName.Name = "lblSetName"
        Me.lblSetName.Size = New System.Drawing.Size(119, 20)
        Me.lblSetName.TabIndex = 20
        Me.lblSetName.Tag = ""
        Me.lblSetName.Text = "Set New Name:"
        '
        'lblVariables
        '
        Me.lblVariables.AutoSize = True
        Me.lblVariables.Location = New System.Drawing.Point(356, 135)
        Me.lblVariables.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVariables.Name = "lblVariables"
        Me.lblVariables.Size = New System.Drawing.Size(75, 20)
        Me.lblVariables.TabIndex = 23
        Me.lblVariables.Tag = ""
        Me.lblVariables.Text = "Variables"
        '
        'ucrInputSetNewName
        '
        Me.ucrInputSetNewName.AddQuotesIfUnrecognised = True
        Me.ucrInputSetNewName.IsMultiline = False
        Me.ucrInputSetNewName.IsReadOnly = False
        Me.ucrInputSetNewName.Location = New System.Drawing.Point(355, 360)
        Me.ucrInputSetNewName.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputSetNewName.Name = "ucrInputSetNewName"
        Me.ucrInputSetNewName.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputSetNewName.TabIndex = 24
        '
        'ucrReceiverSelectedSet
        '
        Me.ucrReceiverSelectedSet.frmParent = Nothing
        Me.ucrReceiverSelectedSet.Location = New System.Drawing.Point(355, 96)
        Me.ucrReceiverSelectedSet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedSet.Name = "ucrReceiverSelectedSet"
        Me.ucrReceiverSelectedSet.Selector = Nothing
        Me.ucrReceiverSelectedSet.Size = New System.Drawing.Size(188, 31)
        Me.ucrReceiverSelectedSet.strNcFilePath = ""
        Me.ucrReceiverSelectedSet.TabIndex = 15
        Me.ucrReceiverSelectedSet.ucrSelector = Nothing
        '
        'ucrReceiverMultipleVariables
        '
        Me.ucrReceiverMultipleVariables.frmParent = Nothing
        Me.ucrReceiverMultipleVariables.Location = New System.Drawing.Point(355, 163)
        Me.ucrReceiverMultipleVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleVariables.Name = "ucrReceiverMultipleVariables"
        Me.ucrReceiverMultipleVariables.Selector = Nothing
        Me.ucrReceiverMultipleVariables.Size = New System.Drawing.Size(180, 154)
        Me.ucrReceiverMultipleVariables.strNcFilePath = ""
        Me.ucrReceiverMultipleVariables.TabIndex = 21
        Me.ucrReceiverMultipleVariables.ucrSelector = Nothing
        '
        'ucrVariableSetsSelector
        '
        Me.ucrSelectorVariableSets.bShowHiddenColumns = False
        Me.ucrSelectorVariableSets.bUseCurrentFilter = True
        Me.ucrSelectorVariableSets.Location = New System.Drawing.Point(10, 72)
        Me.ucrSelectorVariableSets.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVariableSets.Name = "ucrVariableSetsSelector"
        Me.ucrSelectorVariableSets.Size = New System.Drawing.Size(315, 277)
        Me.ucrSelectorVariableSets.TabIndex = 13
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 422)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(615, 80)
        Me.ucrBase.TabIndex = 16
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(23, 5)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(575, 60)
        Me.ucrPnlOptions.TabIndex = 12
        '
        'dlgVariableSets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 508)
        Me.Controls.Add(Me.lblSelectedSet)
        Me.Controls.Add(Me.ucrInputSetNewName)
        Me.Controls.Add(Me.ucrReceiverSelectedSet)
        Me.Controls.Add(Me.lblSetName)
        Me.Controls.Add(Me.rdoDelete)
        Me.Controls.Add(Me.lblVariables)
        Me.Controls.Add(Me.rdoEdit)
        Me.Controls.Add(Me.ucrReceiverMultipleVariables)
        Me.Controls.Add(Me.rdoMake)
        Me.Controls.Add(Me.ucrSelectorVariableSets)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgVariableSets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Variable Sets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrReceiverSelectedSet As ucrReceiverSingle
    Friend WithEvents ucrSelectorVariableSets As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSelectedSet As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents rdoDelete As RadioButton
    Friend WithEvents rdoEdit As RadioButton
    Friend WithEvents rdoMake As RadioButton
    Friend WithEvents ucrReceiverMultipleVariables As ucrReceiverMultiple
    Friend WithEvents lblSetName As Label
    Friend WithEvents lblVariables As Label
    Friend WithEvents ucrInputSetNewName As ucrInputTextBox
End Class
