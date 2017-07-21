<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDuplicatesConstructed
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
        Me.rdoDataframe = New System.Windows.Forms.RadioButton()
        Me.rdoSelectedVariables = New System.Windows.Forms.RadioButton()
        Me.rdoIndexnumberofduplicates = New System.Windows.Forms.RadioButton()
        Me.rdoDuplicatesonly = New System.Windows.Forms.RadioButton()
        Me.rdoAllduplicatecases = New System.Windows.Forms.RadioButton()
        Me.ucrPnlDuplicates = New instat.UcrPanel()
        Me.ucrNewColumnName = New instat.ucrSave()
        Me.ucrReceiverMultipleForDuplicates = New instat.ucrReceiverMultiple()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorDuplicateswithVariables = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'rdoDataframe
        '
        Me.rdoDataframe.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDataframe.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataframe.FlatAppearance.BorderSize = 2
        Me.rdoDataframe.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataframe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDataframe.Location = New System.Drawing.Point(57, 12)
        Me.rdoDataframe.Name = "rdoDataframe"
        Me.rdoDataframe.Size = New System.Drawing.Size(118, 27)
        Me.rdoDataframe.TabIndex = 15
        Me.rdoDataframe.TabStop = True
        Me.rdoDataframe.Text = "Data Frame"
        Me.rdoDataframe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDataframe.UseVisualStyleBackColor = True
        '
        'rdoSelectedVariables
        '
        Me.rdoSelectedVariables.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSelectedVariables.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSelectedVariables.FlatAppearance.BorderSize = 2
        Me.rdoSelectedVariables.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSelectedVariables.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSelectedVariables.Location = New System.Drawing.Point(174, 12)
        Me.rdoSelectedVariables.Name = "rdoSelectedVariables"
        Me.rdoSelectedVariables.Size = New System.Drawing.Size(128, 27)
        Me.rdoSelectedVariables.TabIndex = 16
        Me.rdoSelectedVariables.TabStop = True
        Me.rdoSelectedVariables.Text = "Selected Variables"
        Me.rdoSelectedVariables.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSelectedVariables.UseVisualStyleBackColor = True
        '
        'rdoIndexnumberofduplicates
        '
        Me.rdoIndexnumberofduplicates.AutoSize = True
        Me.rdoIndexnumberofduplicates.Location = New System.Drawing.Point(17, 284)
        Me.rdoIndexnumberofduplicates.Name = "rdoIndexnumberofduplicates"
        Me.rdoIndexnumberofduplicates.Size = New System.Drawing.Size(155, 17)
        Me.rdoIndexnumberofduplicates.TabIndex = 25
        Me.rdoIndexnumberofduplicates.TabStop = True
        Me.rdoIndexnumberofduplicates.Text = " Index number of duplicates"
        Me.rdoIndexnumberofduplicates.UseVisualStyleBackColor = True
        '
        'rdoDuplicatesonly
        '
        Me.rdoDuplicatesonly.AutoSize = True
        Me.rdoDuplicatesonly.Location = New System.Drawing.Point(17, 262)
        Me.rdoDuplicatesonly.Name = "rdoDuplicatesonly"
        Me.rdoDuplicatesonly.Size = New System.Drawing.Size(97, 17)
        Me.rdoDuplicatesonly.TabIndex = 24
        Me.rdoDuplicatesonly.TabStop = True
        Me.rdoDuplicatesonly.Text = "Duplicates only"
        Me.rdoDuplicatesonly.UseVisualStyleBackColor = True
        '
        'rdoAllduplicatecases
        '
        Me.rdoAllduplicatecases.AutoSize = True
        Me.rdoAllduplicatecases.Location = New System.Drawing.Point(17, 240)
        Me.rdoAllduplicatecases.Name = "rdoAllduplicatecases"
        Me.rdoAllduplicatecases.Size = New System.Drawing.Size(113, 17)
        Me.rdoAllduplicatecases.TabIndex = 23
        Me.rdoAllduplicatecases.TabStop = True
        Me.rdoAllduplicatecases.Text = "All duplicate cases"
        Me.rdoAllduplicatecases.UseVisualStyleBackColor = True
        '
        'ucrPnlDuplicates
        '
        Me.ucrPnlDuplicates.Location = New System.Drawing.Point(10, 235)
        Me.ucrPnlDuplicates.Name = "ucrPnlDuplicates"
        Me.ucrPnlDuplicates.Size = New System.Drawing.Size(154, 69)
        Me.ucrPnlDuplicates.TabIndex = 22
        '
        'ucrNewColumnName
        '
        Me.ucrNewColumnName.Location = New System.Drawing.Point(10, 324)
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        Me.ucrNewColumnName.Size = New System.Drawing.Size(294, 24)
        Me.ucrNewColumnName.TabIndex = 21
        '
        'ucrReceiverMultipleForDuplicates
        '
        Me.ucrReceiverMultipleForDuplicates.frmParent = Me
        Me.ucrReceiverMultipleForDuplicates.Location = New System.Drawing.Point(241, 67)
        Me.ucrReceiverMultipleForDuplicates.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleForDuplicates.Name = "ucrReceiverMultipleForDuplicates"
        Me.ucrReceiverMultipleForDuplicates.Selector = Nothing
        Me.ucrReceiverMultipleForDuplicates.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleForDuplicates.strNcFilePath = ""
        Me.ucrReceiverMultipleForDuplicates.TabIndex = 20
        Me.ucrReceiverMultipleForDuplicates.ucrSelector = Nothing
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(57, 8)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(254, 36)
        Me.ucrPnlOptions.TabIndex = 17
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 352)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(388, 52)
        Me.ucrBase.TabIndex = 12
        '
        'ucrSelectorDuplicateswithVariables
        '
        Me.ucrSelectorDuplicateswithVariables.bShowHiddenColumns = False
        Me.ucrSelectorDuplicateswithVariables.bUseCurrentFilter = True
        Me.ucrSelectorDuplicateswithVariables.Location = New System.Drawing.Point(17, 47)
        Me.ucrSelectorDuplicateswithVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDuplicateswithVariables.Name = "ucrSelectorDuplicateswithVariables"
        Me.ucrSelectorDuplicateswithVariables.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDuplicateswithVariables.TabIndex = 18
        '
        'dlgDuplicatesConstructed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 412)
        Me.Controls.Add(Me.rdoIndexnumberofduplicates)
        Me.Controls.Add(Me.rdoDuplicatesonly)
        Me.Controls.Add(Me.rdoAllduplicatecases)
        Me.Controls.Add(Me.ucrPnlDuplicates)
        Me.Controls.Add(Me.ucrNewColumnName)
        Me.Controls.Add(Me.ucrReceiverMultipleForDuplicates)
        Me.Controls.Add(Me.rdoDataframe)
        Me.Controls.Add(Me.rdoSelectedVariables)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorDuplicateswithVariables)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDuplicatesConstructed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Duplicates Constructed"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoDataframe As RadioButton
    Friend WithEvents rdoSelectedVariables As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrSelectorDuplicateswithVariables As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverMultipleForDuplicates As ucrReceiverMultiple
    Friend WithEvents ucrNewColumnName As ucrSave
    Friend WithEvents rdoIndexnumberofduplicates As RadioButton
    Friend WithEvents rdoDuplicatesonly As RadioButton
    Friend WithEvents rdoAllduplicatecases As RadioButton
    Friend WithEvents ucrPnlDuplicates As UcrPanel
End Class
