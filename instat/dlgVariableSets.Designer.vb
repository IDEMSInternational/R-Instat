<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgVariableSets
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
        Me.ucrReceiverSelectedSet = New instat.ucrReceiverSingle()
        Me.ucrVariableSetsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblSelectedSet = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.rdoDelete = New System.Windows.Forms.RadioButton()
        Me.rdoEdit = New System.Windows.Forms.RadioButton()
        Me.rdoMake = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'ucrReceiverSelectedSet
        '
        Me.ucrReceiverSelectedSet.frmParent = Me
        Me.ucrReceiverSelectedSet.Location = New System.Drawing.Point(380, 128)
        Me.ucrReceiverSelectedSet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedSet.Name = "ucrReceiverSelectedSet"
        Me.ucrReceiverSelectedSet.Selector = Nothing
        Me.ucrReceiverSelectedSet.Size = New System.Drawing.Size(188, 31)
        Me.ucrReceiverSelectedSet.strNcFilePath = ""
        Me.ucrReceiverSelectedSet.TabIndex = 15
        Me.ucrReceiverSelectedSet.ucrSelector = Nothing
        '
        'ucrVariableSetsSelector
        '
        Me.ucrVariableSetsSelector.bShowHiddenColumns = False
        Me.ucrVariableSetsSelector.bUseCurrentFilter = True
        Me.ucrVariableSetsSelector.Location = New System.Drawing.Point(7, 72)
        Me.ucrVariableSetsSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrVariableSetsSelector.Name = "ucrVariableSetsSelector"
        Me.ucrVariableSetsSelector.Size = New System.Drawing.Size(315, 277)
        Me.ucrVariableSetsSelector.TabIndex = 13
        '
        'lblSelectedSet
        '
        Me.lblSelectedSet.AutoSize = True
        Me.lblSelectedSet.Location = New System.Drawing.Point(376, 98)
        Me.lblSelectedSet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectedSet.Name = "lblSelectedSet"
        Me.lblSelectedSet.Size = New System.Drawing.Size(105, 20)
        Me.lblSelectedSet.TabIndex = 14
        Me.lblSelectedSet.Tag = ""
        Me.lblSelectedSet.Text = "Selected Set:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 369)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(615, 80)
        Me.ucrBase.TabIndex = 16
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(6, 6)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(597, 65)
        Me.ucrPnlOptions.TabIndex = 12
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
        'dlgVariableSets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 459)
        Me.Controls.Add(Me.rdoDelete)
        Me.Controls.Add(Me.rdoEdit)
        Me.Controls.Add(Me.rdoMake)
        Me.Controls.Add(Me.ucrReceiverSelectedSet)
        Me.Controls.Add(Me.ucrVariableSetsSelector)
        Me.Controls.Add(Me.lblSelectedSet)
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
    Friend WithEvents ucrVariableSetsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSelectedSet As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents rdoDelete As RadioButton
    Friend WithEvents rdoEdit As RadioButton
    Friend WithEvents rdoMake As RadioButton
End Class
