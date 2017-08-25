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
        Me.rdoSuccessiveValues = New System.Windows.Forms.RadioButton()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrInputTolerance = New instat.ucrInputTextBox()
        Me.ucrChkTolerance = New instat.ucrCheck()
        Me.ucrNudOmit = New instat.ucrNud()
        Me.ucrChkOmitValues = New instat.ucrCheck()
        Me.ucrInputConditions = New instat.ucrInputComboBox()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.ucrReceiverForDuplicates = New instat.ucrReceiverSingle()
        Me.ucrPnlDuplicates = New instat.UcrPanel()
        Me.ucrNewColumnName = New instat.ucrSave()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorDuplicateswithVariables = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoDataFrame
        '
        Me.rdoDataFrame.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDataFrame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataFrame.FlatAppearance.BorderSize = 2
        Me.rdoDataFrame.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDataFrame.Location = New System.Drawing.Point(22, 12)
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
        Me.rdoSelectedVariables.Location = New System.Drawing.Point(129, 12)
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
        Me.rdoIndexNumberOfDuplicates.Location = New System.Drawing.Point(10, 284)
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
        Me.rdoDuplicatesOnly.Location = New System.Drawing.Point(10, 262)
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
        Me.rdoAllDuplicateCases.Location = New System.Drawing.Point(10, 240)
        Me.rdoAllDuplicateCases.Name = "rdoAllDuplicateCases"
        Me.rdoAllDuplicateCases.Size = New System.Drawing.Size(116, 17)
        Me.rdoAllDuplicateCases.TabIndex = 6
        Me.rdoAllDuplicateCases.TabStop = True
        Me.rdoAllDuplicateCases.Text = "All Duplicate Cases"
        Me.rdoAllDuplicateCases.UseVisualStyleBackColor = True
        '
        'rdoSuccessiveValues
        '
        Me.rdoSuccessiveValues.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSuccessiveValues.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSuccessiveValues.FlatAppearance.BorderSize = 2
        Me.rdoSuccessiveValues.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSuccessiveValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSuccessiveValues.Location = New System.Drawing.Point(238, 12)
        Me.rdoSuccessiveValues.Name = "rdoSuccessiveValues"
        Me.rdoSuccessiveValues.Size = New System.Drawing.Size(109, 27)
        Me.rdoSuccessiveValues.TabIndex = 12
        Me.rdoSuccessiveValues.TabStop = True
        Me.rdoSuccessiveValues.Text = "Successive Values"
        Me.rdoSuccessiveValues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSuccessiveValues.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrInputTolerance)
        Me.grpOptions.Controls.Add(Me.ucrChkTolerance)
        Me.grpOptions.Controls.Add(Me.ucrNudOmit)
        Me.grpOptions.Controls.Add(Me.ucrChkOmitValues)
        Me.grpOptions.Controls.Add(Me.ucrInputConditions)
        Me.grpOptions.Location = New System.Drawing.Point(10, 240)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(337, 124)
        Me.grpOptions.TabIndex = 19
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'ucrInputTolerance
        '
        Me.ucrInputTolerance.AddQuotesIfUnrecognised = True
        Me.ucrInputTolerance.IsMultiline = False
        Me.ucrInputTolerance.IsReadOnly = False
        Me.ucrInputTolerance.Location = New System.Drawing.Point(6, 86)
        Me.ucrInputTolerance.Name = "ucrInputTolerance"
        Me.ucrInputTolerance.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTolerance.TabIndex = 20
        '
        'ucrChkTolerance
        '
        Me.ucrChkTolerance.Checked = False
        Me.ucrChkTolerance.Location = New System.Drawing.Point(6, 62)
        Me.ucrChkTolerance.Name = "ucrChkTolerance"
        Me.ucrChkTolerance.Size = New System.Drawing.Size(135, 20)
        Me.ucrChkTolerance.TabIndex = 19
        '
        'ucrNudOmit
        '
        Me.ucrNudOmit.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOmit.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudOmit.Location = New System.Drawing.Point(148, 38)
        Me.ucrNudOmit.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudOmit.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOmit.Name = "ucrNudOmit"
        Me.ucrNudOmit.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudOmit.TabIndex = 18
        Me.ucrNudOmit.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkOmitValues
        '
        Me.ucrChkOmitValues.Checked = False
        Me.ucrChkOmitValues.Location = New System.Drawing.Point(6, 12)
        Me.ucrChkOmitValues.Name = "ucrChkOmitValues"
        Me.ucrChkOmitValues.Size = New System.Drawing.Size(135, 20)
        Me.ucrChkOmitValues.TabIndex = 16
        '
        'ucrInputConditions
        '
        Me.ucrInputConditions.AddQuotesIfUnrecognised = True
        Me.ucrInputConditions.IsReadOnly = False
        Me.ucrInputConditions.Location = New System.Drawing.Point(6, 38)
        Me.ucrInputConditions.Name = "ucrInputConditions"
        Me.ucrInputConditions.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputConditions.TabIndex = 17
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.Location = New System.Drawing.Point(252, 119)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(45, 13)
        Me.lblSelectedVariable.TabIndex = 20
        Me.lblSelectedVariable.Tag = ""
        Me.lblSelectedVariable.Text = "Variable"
        '
        'ucrReceiverForDuplicates
        '
        Me.ucrReceiverForDuplicates.frmParent = Me
        Me.ucrReceiverForDuplicates.Location = New System.Drawing.Point(252, 136)
        Me.ucrReceiverForDuplicates.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForDuplicates.Name = "ucrReceiverForDuplicates"
        Me.ucrReceiverForDuplicates.Selector = Nothing
        Me.ucrReceiverForDuplicates.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverForDuplicates.strNcFilePath = ""
        Me.ucrReceiverForDuplicates.TabIndex = 11
        Me.ucrReceiverForDuplicates.ucrSelector = Nothing
        '
        'ucrPnlDuplicates
        '
        Me.ucrPnlDuplicates.Location = New System.Drawing.Point(3, 235)
        Me.ucrPnlDuplicates.Name = "ucrPnlDuplicates"
        Me.ucrPnlDuplicates.Size = New System.Drawing.Size(180, 69)
        Me.ucrPnlDuplicates.TabIndex = 5
        '
        'ucrNewColumnName
        '
        Me.ucrNewColumnName.Location = New System.Drawing.Point(12, 378)
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        Me.ucrNewColumnName.Size = New System.Drawing.Size(294, 24)
        Me.ucrNewColumnName.TabIndex = 9
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(10, 8)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(360, 36)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 408)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(401, 52)
        Me.ucrBase.TabIndex = 10
        '
        'ucrSelectorDuplicateswithVariables
        '
        Me.ucrSelectorDuplicateswithVariables.bShowHiddenColumns = False
        Me.ucrSelectorDuplicateswithVariables.bUseCurrentFilter = True
        Me.ucrSelectorDuplicateswithVariables.Location = New System.Drawing.Point(10, 47)
        Me.ucrSelectorDuplicateswithVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDuplicateswithVariables.Name = "ucrSelectorDuplicateswithVariables"
        Me.ucrSelectorDuplicateswithVariables.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDuplicateswithVariables.TabIndex = 3
        '
        'dlgDuplicatesConstructed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 472)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.rdoSuccessiveValues)
        Me.Controls.Add(Me.ucrReceiverForDuplicates)
        Me.Controls.Add(Me.rdoIndexNumberOfDuplicates)
        Me.Controls.Add(Me.rdoDuplicatesOnly)
        Me.Controls.Add(Me.rdoAllDuplicateCases)
        Me.Controls.Add(Me.ucrPnlDuplicates)
        Me.Controls.Add(Me.ucrNewColumnName)
        Me.Controls.Add(Me.rdoDataFrame)
        Me.Controls.Add(Me.rdoSelectedVariables)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorDuplicateswithVariables)
        Me.Controls.Add(Me.grpOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDuplicatesConstructed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Duplicates"
        Me.grpOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoDataFrame As RadioButton
    Friend WithEvents rdoSelectedVariables As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrSelectorDuplicateswithVariables As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrNewColumnName As ucrSave
    Friend WithEvents rdoIndexNumberOfDuplicates As RadioButton
    Friend WithEvents rdoDuplicatesOnly As RadioButton
    Friend WithEvents rdoAllDuplicateCases As RadioButton
    Friend WithEvents ucrPnlDuplicates As UcrPanel
    Friend WithEvents ttDuplicates As ToolTip
    Friend WithEvents ucrReceiverForDuplicates As ucrReceiverSingle
    Friend WithEvents rdoSuccessiveValues As RadioButton
    Friend WithEvents ucrChkOmitValues As ucrCheck
    Friend WithEvents ucrNudOmit As ucrNud
    Friend WithEvents ucrInputConditions As ucrInputComboBox
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrInputTolerance As ucrInputTextBox
    Friend WithEvents ucrChkTolerance As ucrCheck
End Class
