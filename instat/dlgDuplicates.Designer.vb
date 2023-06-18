<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDuplicateRows
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
        Me.ucrInputOmitValues = New instat.ucrInputTextBox()
        Me.ucrInputTolerance = New instat.ucrInputTextBox()
        Me.ucrChkTolerance = New instat.ucrCheck()
        Me.ucrChkOmitValues = New instat.ucrCheck()
        Me.ucrInputConditions = New instat.ucrInputComboBox()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.lblVariablesToDuplicate = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.ucrChkIncludeSummary = New instat.ucrCheck()
        Me.ucrInputComboType = New instat.ucrInputComboBox()
        Me.ucrReceiverForSelectedVariables = New instat.ucrReceiverMultiple()
        Me.ucrReceiverForSuccessiveValues = New instat.ucrReceiverSingle()
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
        Me.rdoDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDataFrame.Location = New System.Drawing.Point(142, 12)
        Me.rdoDataFrame.Name = "rdoDataFrame"
        Me.rdoDataFrame.Size = New System.Drawing.Size(135, 27)
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
        Me.rdoSelectedVariables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSelectedVariables.Location = New System.Drawing.Point(11, 12)
        Me.rdoSelectedVariables.Name = "rdoSelectedVariables"
        Me.rdoSelectedVariables.Size = New System.Drawing.Size(135, 27)
        Me.rdoSelectedVariables.TabIndex = 2
        Me.rdoSelectedVariables.TabStop = True
        Me.rdoSelectedVariables.Text = "Selected Variables"
        Me.rdoSelectedVariables.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSelectedVariables.UseVisualStyleBackColor = True
        '
        'rdoIndexNumberOfDuplicates
        '
        Me.rdoIndexNumberOfDuplicates.AutoSize = True
        Me.rdoIndexNumberOfDuplicates.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoIndexNumberOfDuplicates.Location = New System.Drawing.Point(12, 295)
        Me.rdoIndexNumberOfDuplicates.Name = "rdoIndexNumberOfDuplicates"
        Me.rdoIndexNumberOfDuplicates.Size = New System.Drawing.Size(156, 17)
        Me.rdoIndexNumberOfDuplicates.TabIndex = 12
        Me.rdoIndexNumberOfDuplicates.TabStop = True
        Me.rdoIndexNumberOfDuplicates.Text = "Index Number of Duplicates"
        Me.rdoIndexNumberOfDuplicates.UseVisualStyleBackColor = True
        '
        'rdoDuplicatesOnly
        '
        Me.rdoDuplicatesOnly.AutoSize = True
        Me.rdoDuplicatesOnly.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDuplicatesOnly.Location = New System.Drawing.Point(12, 272)
        Me.rdoDuplicatesOnly.Name = "rdoDuplicatesOnly"
        Me.rdoDuplicatesOnly.Size = New System.Drawing.Size(99, 17)
        Me.rdoDuplicatesOnly.TabIndex = 11
        Me.rdoDuplicatesOnly.TabStop = True
        Me.rdoDuplicatesOnly.Text = "Duplicates Only"
        Me.rdoDuplicatesOnly.UseVisualStyleBackColor = True
        '
        'rdoAllDuplicateCases
        '
        Me.rdoAllDuplicateCases.AutoSize = True
        Me.rdoAllDuplicateCases.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAllDuplicateCases.Location = New System.Drawing.Point(12, 249)
        Me.rdoAllDuplicateCases.Name = "rdoAllDuplicateCases"
        Me.rdoAllDuplicateCases.Size = New System.Drawing.Size(116, 17)
        Me.rdoAllDuplicateCases.TabIndex = 10
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
        Me.rdoSuccessiveValues.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSuccessiveValues.Location = New System.Drawing.Point(277, 12)
        Me.rdoSuccessiveValues.Name = "rdoSuccessiveValues"
        Me.rdoSuccessiveValues.Size = New System.Drawing.Size(135, 27)
        Me.rdoSuccessiveValues.TabIndex = 3
        Me.rdoSuccessiveValues.TabStop = True
        Me.rdoSuccessiveValues.Text = "Successive Values"
        Me.rdoSuccessiveValues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSuccessiveValues.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrInputOmitValues)
        Me.grpOptions.Controls.Add(Me.ucrInputTolerance)
        Me.grpOptions.Controls.Add(Me.ucrChkTolerance)
        Me.grpOptions.Controls.Add(Me.ucrChkOmitValues)
        Me.grpOptions.Controls.Add(Me.ucrInputConditions)
        Me.grpOptions.Location = New System.Drawing.Point(10, 230)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(288, 124)
        Me.grpOptions.TabIndex = 13
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'ucrInputOmitValues
        '
        Me.ucrInputOmitValues.AddQuotesIfUnrecognised = True
        Me.ucrInputOmitValues.AutoSize = True
        Me.ucrInputOmitValues.IsMultiline = False
        Me.ucrInputOmitValues.IsReadOnly = False
        Me.ucrInputOmitValues.Location = New System.Drawing.Point(145, 45)
        Me.ucrInputOmitValues.Name = "ucrInputOmitValues"
        Me.ucrInputOmitValues.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputOmitValues.TabIndex = 5
        '
        'ucrInputTolerance
        '
        Me.ucrInputTolerance.AddQuotesIfUnrecognised = True
        Me.ucrInputTolerance.AutoSize = True
        Me.ucrInputTolerance.IsMultiline = False
        Me.ucrInputTolerance.IsReadOnly = False
        Me.ucrInputTolerance.Location = New System.Drawing.Point(6, 97)
        Me.ucrInputTolerance.Name = "ucrInputTolerance"
        Me.ucrInputTolerance.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTolerance.TabIndex = 4
        '
        'ucrChkTolerance
        '
        Me.ucrChkTolerance.AutoSize = True
        Me.ucrChkTolerance.Checked = False
        Me.ucrChkTolerance.Location = New System.Drawing.Point(6, 72)
        Me.ucrChkTolerance.Name = "ucrChkTolerance"
        Me.ucrChkTolerance.Size = New System.Drawing.Size(135, 23)
        Me.ucrChkTolerance.TabIndex = 3
        '
        'ucrChkOmitValues
        '
        Me.ucrChkOmitValues.AutoSize = True
        Me.ucrChkOmitValues.Checked = False
        Me.ucrChkOmitValues.Location = New System.Drawing.Point(6, 19)
        Me.ucrChkOmitValues.Name = "ucrChkOmitValues"
        Me.ucrChkOmitValues.Size = New System.Drawing.Size(135, 23)
        Me.ucrChkOmitValues.TabIndex = 0
        '
        'ucrInputConditions
        '
        Me.ucrInputConditions.AddQuotesIfUnrecognised = True
        Me.ucrInputConditions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputConditions.GetSetSelectedIndex = -1
        Me.ucrInputConditions.IsReadOnly = False
        Me.ucrInputConditions.Location = New System.Drawing.Point(6, 45)
        Me.ucrInputConditions.Name = "ucrInputConditions"
        Me.ucrInputConditions.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputConditions.TabIndex = 1
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectedVariable.Location = New System.Drawing.Point(277, 82)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(94, 13)
        Me.lblSelectedVariable.TabIndex = 5
        Me.lblSelectedVariable.Tag = ""
        Me.lblSelectedVariable.Text = "Variable to Check:"
        '
        'lblVariablesToDuplicate
        '
        Me.lblVariablesToDuplicate.AutoSize = True
        Me.lblVariablesToDuplicate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVariablesToDuplicate.Location = New System.Drawing.Point(277, 82)
        Me.lblVariablesToDuplicate.Name = "lblVariablesToDuplicate"
        Me.lblVariablesToDuplicate.Size = New System.Drawing.Size(99, 13)
        Me.lblVariablesToDuplicate.TabIndex = 7
        Me.lblVariablesToDuplicate.Tag = ""
        Me.lblVariablesToDuplicate.Text = "Variables to Check:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblType.Location = New System.Drawing.Point(178, 297)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(34, 13)
        Me.lblType.TabIndex = 17
        Me.lblType.Text = "Type:"
        '
        'ucrChkIncludeSummary
        '
        Me.ucrChkIncludeSummary.AutoSize = True
        Me.ucrChkIncludeSummary.Checked = False
        Me.ucrChkIncludeSummary.Location = New System.Drawing.Point(10, 360)
        Me.ucrChkIncludeSummary.Name = "ucrChkIncludeSummary"
        Me.ucrChkIncludeSummary.Size = New System.Drawing.Size(135, 23)
        Me.ucrChkIncludeSummary.TabIndex = 14
        '
        'ucrInputComboType
        '
        Me.ucrInputComboType.AddQuotesIfUnrecognised = True
        Me.ucrInputComboType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboType.GetSetSelectedIndex = -1
        Me.ucrInputComboType.IsReadOnly = False
        Me.ucrInputComboType.Location = New System.Drawing.Point(212, 295)
        Me.ucrInputComboType.Name = "ucrInputComboType"
        Me.ucrInputComboType.Size = New System.Drawing.Size(84, 21)
        Me.ucrInputComboType.TabIndex = 16
        '
        'ucrReceiverForSelectedVariables
        '
        Me.ucrReceiverForSelectedVariables.AutoSize = True
        Me.ucrReceiverForSelectedVariables.frmParent = Me
        Me.ucrReceiverForSelectedVariables.Location = New System.Drawing.Point(277, 97)
        Me.ucrReceiverForSelectedVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForSelectedVariables.Name = "ucrReceiverForSelectedVariables"
        Me.ucrReceiverForSelectedVariables.Selector = Nothing
        Me.ucrReceiverForSelectedVariables.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverForSelectedVariables.strNcFilePath = ""
        Me.ucrReceiverForSelectedVariables.TabIndex = 8
        Me.ucrReceiverForSelectedVariables.ucrSelector = Nothing
        '
        'ucrReceiverForSuccessiveValues
        '
        Me.ucrReceiverForSuccessiveValues.AutoSize = True
        Me.ucrReceiverForSuccessiveValues.frmParent = Me
        Me.ucrReceiverForSuccessiveValues.Location = New System.Drawing.Point(277, 97)
        Me.ucrReceiverForSuccessiveValues.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForSuccessiveValues.Name = "ucrReceiverForSuccessiveValues"
        Me.ucrReceiverForSuccessiveValues.Selector = Nothing
        Me.ucrReceiverForSuccessiveValues.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverForSuccessiveValues.strNcFilePath = ""
        Me.ucrReceiverForSuccessiveValues.TabIndex = 6
        Me.ucrReceiverForSuccessiveValues.ucrSelector = Nothing
        '
        'ucrPnlDuplicates
        '
        Me.ucrPnlDuplicates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDuplicates.Location = New System.Drawing.Point(10, 245)
        Me.ucrPnlDuplicates.Name = "ucrPnlDuplicates"
        Me.ucrPnlDuplicates.Size = New System.Drawing.Size(298, 77)
        Me.ucrPnlDuplicates.TabIndex = 9
        '
        'ucrNewColumnName
        '
        Me.ucrNewColumnName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrNewColumnName.Location = New System.Drawing.Point(10, 388)
        Me.ucrNewColumnName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        Me.ucrNewColumnName.Size = New System.Drawing.Size(281, 22)
        Me.ucrNewColumnName.TabIndex = 15
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(6, 8)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(410, 36)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 416)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 16
        '
        'ucrSelectorDuplicateswithVariables
        '
        Me.ucrSelectorDuplicateswithVariables.AutoSize = True
        Me.ucrSelectorDuplicateswithVariables.bDropUnusedFilterLevels = False
        Me.ucrSelectorDuplicateswithVariables.bShowHiddenColumns = False
        Me.ucrSelectorDuplicateswithVariables.bUseCurrentFilter = True
        Me.ucrSelectorDuplicateswithVariables.Location = New System.Drawing.Point(10, 47)
        Me.ucrSelectorDuplicateswithVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDuplicateswithVariables.Name = "ucrSelectorDuplicateswithVariables"
        Me.ucrSelectorDuplicateswithVariables.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorDuplicateswithVariables.TabIndex = 4
        '
        'dlgDuplicateRows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(421, 473)
        Me.Controls.Add(Me.ucrChkIncludeSummary)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblVariablesToDuplicate)
        Me.Controls.Add(Me.ucrInputComboType)
        Me.Controls.Add(Me.ucrReceiverForSelectedVariables)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.rdoSuccessiveValues)
        Me.Controls.Add(Me.ucrReceiverForSuccessiveValues)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDuplicateRows"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Duplicate Rows"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
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
    Friend WithEvents rdoSuccessiveValues As RadioButton
    Friend WithEvents ucrChkOmitValues As ucrCheck
    Friend WithEvents ucrInputConditions As ucrInputComboBox
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrInputTolerance As ucrInputTextBox
    Friend WithEvents ucrChkTolerance As ucrCheck
    Friend WithEvents ucrReceiverForSuccessiveValues As ucrReceiverSingle
    Friend WithEvents ucrReceiverForSelectedVariables As ucrReceiverMultiple
    Friend WithEvents lblVariablesToDuplicate As Label
    Friend WithEvents ucrInputOmitValues As ucrInputTextBox
    Friend WithEvents lblType As Label
    Friend WithEvents ucrInputComboType As ucrInputComboBox
    Friend WithEvents ucrChkIncludeSummary As ucrCheck
End Class
