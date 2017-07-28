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
        Me.components = New System.ComponentModel.Container()
        Me.rdoDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoSelectedVariables = New System.Windows.Forms.RadioButton()
        Me.rdoIndexNumberOfDuplicates = New System.Windows.Forms.RadioButton()
        Me.rdoDuplicatesOnly = New System.Windows.Forms.RadioButton()
        Me.rdoAllDuplicateCases = New System.Windows.Forms.RadioButton()
        Me.ttDuplicates = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrPnlDuplicates = New instat.UcrPanel()
        Me.ucrNewColumnName = New instat.ucrSave()
        Me.ucrReceiverMultipleForDuplicates = New instat.ucrReceiverMultiple()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorDuplicateswithVariables = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'rdoDataFrame
        '
        Me.rdoDataFrame.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDataFrame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataFrame.FlatAppearance.BorderSize = 2
        Me.rdoDataFrame.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDataFrame.Location = New System.Drawing.Point(99, 12)
        Me.rdoDataFrame.Name = "rdoDataFrame"
        Me.rdoDataFrame.Size = New System.Drawing.Size(109, 27)
        Me.rdoDataFrame.TabIndex = 1
        Me.rdoDataFrame.TabStop = True
        Me.rdoDataFrame.Text = "Data Frame"
        Me.rdoDataFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDataFrame.UseVisualStyleBackColor = True
        '
        'rdoSelectedVariables
        '
        Me.rdoSelectedVariables.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSelectedVariables.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSelectedVariables.FlatAppearance.BorderSize = 2
        Me.rdoSelectedVariables.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSelectedVariables.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSelectedVariables.Location = New System.Drawing.Point(206, 12)
        Me.rdoSelectedVariables.Name = "rdoSelectedVariables"
        Me.rdoSelectedVariables.Size = New System.Drawing.Size(109, 27)
        Me.rdoSelectedVariables.TabIndex = 2
        Me.rdoSelectedVariables.TabStop = True
        Me.rdoSelectedVariables.Text = "Selected Variables"
        Me.rdoSelectedVariables.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSelectedVariables.UseVisualStyleBackColor = True
        '
        'rdoIndexNumberOfDuplicates
        '
        Me.rdoIndexNumberOfDuplicates.AutoSize = True
        Me.rdoIndexNumberOfDuplicates.Location = New System.Drawing.Point(17, 284)
        Me.rdoIndexNumberOfDuplicates.Name = "rdoIndexNumberOfDuplicates"
        Me.rdoIndexNumberOfDuplicates.Size = New System.Drawing.Size(156, 17)
        Me.rdoIndexNumberOfDuplicates.TabIndex = 8
        Me.rdoIndexNumberOfDuplicates.TabStop = True
        Me.rdoIndexNumberOfDuplicates.Text = "Index Number of Duplicates"
        Me.rdoIndexNumberOfDuplicates.UseVisualStyleBackColor = True
        '
        'rdoDuplicatesOnly
        '
        Me.rdoDuplicatesOnly.AutoSize = True
        Me.rdoDuplicatesOnly.Location = New System.Drawing.Point(17, 262)
        Me.rdoDuplicatesOnly.Name = "rdoDuplicatesOnly"
        Me.rdoDuplicatesOnly.Size = New System.Drawing.Size(99, 17)
        Me.rdoDuplicatesOnly.TabIndex = 7
        Me.rdoDuplicatesOnly.TabStop = True
        Me.rdoDuplicatesOnly.Text = "Duplicates Only"
        Me.rdoDuplicatesOnly.UseVisualStyleBackColor = True
        '
        'rdoAllDuplicateCases
        '
        Me.rdoAllDuplicateCases.AutoSize = True
        Me.rdoAllDuplicateCases.Location = New System.Drawing.Point(17, 240)
        Me.rdoAllDuplicateCases.Name = "rdoAllDuplicateCases"
        Me.rdoAllDuplicateCases.Size = New System.Drawing.Size(116, 17)
        Me.rdoAllDuplicateCases.TabIndex = 6
        Me.rdoAllDuplicateCases.TabStop = True
        Me.rdoAllDuplicateCases.Text = "All Duplicate Cases"
        Me.rdoAllDuplicateCases.UseVisualStyleBackColor = True
        '
        'ucrPnlDuplicates
        '
        Me.ucrPnlDuplicates.Location = New System.Drawing.Point(10, 235)
        Me.ucrPnlDuplicates.Name = "ucrPnlDuplicates"
        Me.ucrPnlDuplicates.Size = New System.Drawing.Size(154, 69)
        Me.ucrPnlDuplicates.TabIndex = 5
        '
        'ucrNewColumnName
        '
        Me.ucrNewColumnName.Location = New System.Drawing.Point(10, 322)
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        Me.ucrNewColumnName.Size = New System.Drawing.Size(294, 24)
        Me.ucrNewColumnName.TabIndex = 9
        '
        'ucrReceiverMultipleForDuplicates
        '
        Me.ucrReceiverMultipleForDuplicates.frmParent = Me
        Me.ucrReceiverMultipleForDuplicates.Location = New System.Drawing.Point(254, 97)
        Me.ucrReceiverMultipleForDuplicates.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleForDuplicates.Name = "ucrReceiverMultipleForDuplicates"
        Me.ucrReceiverMultipleForDuplicates.Selector = Nothing
        Me.ucrReceiverMultipleForDuplicates.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleForDuplicates.strNcFilePath = ""
        Me.ucrReceiverMultipleForDuplicates.TabIndex = 4
        Me.ucrReceiverMultipleForDuplicates.ucrSelector = Nothing
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(89, 8)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(254, 36)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 349)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(401, 52)
        Me.ucrBase.TabIndex = 10
        '
        'ucrSelectorDuplicateswithVariables
        '
        Me.ucrSelectorDuplicateswithVariables.bShowHiddenColumns = False
        Me.ucrSelectorDuplicateswithVariables.bUseCurrentFilter = True
        Me.ucrSelectorDuplicateswithVariables.Location = New System.Drawing.Point(17, 47)
        Me.ucrSelectorDuplicateswithVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDuplicateswithVariables.Name = "ucrSelectorDuplicateswithVariables"
        Me.ucrSelectorDuplicateswithVariables.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDuplicateswithVariables.TabIndex = 3
        '
        'dlgDuplicatesConstructed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 407)
        Me.Controls.Add(Me.rdoIndexNumberOfDuplicates)
        Me.Controls.Add(Me.rdoDuplicatesOnly)
        Me.Controls.Add(Me.rdoAllDuplicateCases)
        Me.Controls.Add(Me.ucrPnlDuplicates)
        Me.Controls.Add(Me.ucrNewColumnName)
        Me.Controls.Add(Me.ucrReceiverMultipleForDuplicates)
        Me.Controls.Add(Me.rdoDataFrame)
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
    Friend WithEvents rdoDataFrame As RadioButton
    Friend WithEvents rdoSelectedVariables As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrSelectorDuplicateswithVariables As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverMultipleForDuplicates As ucrReceiverMultiple
    Friend WithEvents ucrNewColumnName As ucrSave
    Friend WithEvents rdoIndexNumberOfDuplicates As RadioButton
    Friend WithEvents rdoDuplicatesOnly As RadioButton
    Friend WithEvents rdoAllDuplicateCases As RadioButton
    Friend WithEvents ucrPnlDuplicates As UcrPanel
    Friend WithEvents ttDuplicates As ToolTip
End Class
