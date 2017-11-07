<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDuplicates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDuplicates))
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
        Me.ucrReceiverForSelectedVariables = New instat.ucrReceiverMultiple()
        Me.ucrReceiverForSuccessiveValues = New instat.ucrReceiverSingle()
        Me.ucrNewColumnName = New instat.ucrSave()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorDuplicateswithVariables = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlDuplicates = New instat.UcrPanel()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoDataFrame
        '
        resources.ApplyResources(Me.rdoDataFrame, "rdoDataFrame")
        Me.rdoDataFrame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataFrame.FlatAppearance.BorderSize = 2
        Me.rdoDataFrame.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataFrame.Name = "rdoDataFrame"
        Me.rdoDataFrame.TabStop = True
        Me.rdoDataFrame.UseVisualStyleBackColor = True
        '
        'rdoSelectedVariables
        '
        resources.ApplyResources(Me.rdoSelectedVariables, "rdoSelectedVariables")
        Me.rdoSelectedVariables.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSelectedVariables.FlatAppearance.BorderSize = 2
        Me.rdoSelectedVariables.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSelectedVariables.Name = "rdoSelectedVariables"
        Me.rdoSelectedVariables.TabStop = True
        Me.rdoSelectedVariables.UseVisualStyleBackColor = True
        '
        'rdoIndexNumberOfDuplicates
        '
        resources.ApplyResources(Me.rdoIndexNumberOfDuplicates, "rdoIndexNumberOfDuplicates")
        Me.rdoIndexNumberOfDuplicates.Name = "rdoIndexNumberOfDuplicates"
        Me.rdoIndexNumberOfDuplicates.TabStop = True
        Me.rdoIndexNumberOfDuplicates.UseVisualStyleBackColor = True
        '
        'rdoDuplicatesOnly
        '
        resources.ApplyResources(Me.rdoDuplicatesOnly, "rdoDuplicatesOnly")
        Me.rdoDuplicatesOnly.Name = "rdoDuplicatesOnly"
        Me.rdoDuplicatesOnly.TabStop = True
        Me.rdoDuplicatesOnly.UseVisualStyleBackColor = True
        '
        'rdoAllDuplicateCases
        '
        resources.ApplyResources(Me.rdoAllDuplicateCases, "rdoAllDuplicateCases")
        Me.rdoAllDuplicateCases.Name = "rdoAllDuplicateCases"
        Me.rdoAllDuplicateCases.TabStop = True
        Me.rdoAllDuplicateCases.UseVisualStyleBackColor = True
        '
        'rdoSuccessiveValues
        '
        resources.ApplyResources(Me.rdoSuccessiveValues, "rdoSuccessiveValues")
        Me.rdoSuccessiveValues.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSuccessiveValues.FlatAppearance.BorderSize = 2
        Me.rdoSuccessiveValues.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSuccessiveValues.Name = "rdoSuccessiveValues"
        Me.rdoSuccessiveValues.TabStop = True
        Me.rdoSuccessiveValues.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrInputOmitValues)
        Me.grpOptions.Controls.Add(Me.ucrInputTolerance)
        Me.grpOptions.Controls.Add(Me.ucrChkTolerance)
        Me.grpOptions.Controls.Add(Me.ucrChkOmitValues)
        Me.grpOptions.Controls.Add(Me.ucrInputConditions)
        resources.ApplyResources(Me.grpOptions, "grpOptions")
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.TabStop = False
        '
        'ucrInputOmitValues
        '
        Me.ucrInputOmitValues.AddQuotesIfUnrecognised = True
        Me.ucrInputOmitValues.IsMultiline = False
        Me.ucrInputOmitValues.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputOmitValues, "ucrInputOmitValues")
        Me.ucrInputOmitValues.Name = "ucrInputOmitValues"
        '
        'ucrInputTolerance
        '
        Me.ucrInputTolerance.AddQuotesIfUnrecognised = True
        Me.ucrInputTolerance.IsMultiline = False
        Me.ucrInputTolerance.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTolerance, "ucrInputTolerance")
        Me.ucrInputTolerance.Name = "ucrInputTolerance"
        '
        'ucrChkTolerance
        '
        Me.ucrChkTolerance.Checked = False
        resources.ApplyResources(Me.ucrChkTolerance, "ucrChkTolerance")
        Me.ucrChkTolerance.Name = "ucrChkTolerance"
        '
        'ucrChkOmitValues
        '
        Me.ucrChkOmitValues.Checked = False
        resources.ApplyResources(Me.ucrChkOmitValues, "ucrChkOmitValues")
        Me.ucrChkOmitValues.Name = "ucrChkOmitValues"
        '
        'ucrInputConditions
        '
        Me.ucrInputConditions.AddQuotesIfUnrecognised = True
        Me.ucrInputConditions.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputConditions, "ucrInputConditions")
        Me.ucrInputConditions.Name = "ucrInputConditions"
        '
        'lblSelectedVariable
        '
        resources.ApplyResources(Me.lblSelectedVariable, "lblSelectedVariable")
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Tag = ""
        '
        'lblVariablesToDuplicate
        '
        resources.ApplyResources(Me.lblVariablesToDuplicate, "lblVariablesToDuplicate")
        Me.lblVariablesToDuplicate.Name = "lblVariablesToDuplicate"
        Me.lblVariablesToDuplicate.Tag = ""
        '
        'ucrReceiverForSelectedVariables
        '
        Me.ucrReceiverForSelectedVariables.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverForSelectedVariables, "ucrReceiverForSelectedVariables")
        Me.ucrReceiverForSelectedVariables.Name = "ucrReceiverForSelectedVariables"
        Me.ucrReceiverForSelectedVariables.Selector = Nothing
        Me.ucrReceiverForSelectedVariables.strNcFilePath = ""
        Me.ucrReceiverForSelectedVariables.ucrSelector = Nothing
        '
        'ucrReceiverForSuccessiveValues
        '
        Me.ucrReceiverForSuccessiveValues.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverForSuccessiveValues, "ucrReceiverForSuccessiveValues")
        Me.ucrReceiverForSuccessiveValues.Name = "ucrReceiverForSuccessiveValues"
        Me.ucrReceiverForSuccessiveValues.Selector = Nothing
        Me.ucrReceiverForSuccessiveValues.strNcFilePath = ""
        Me.ucrReceiverForSuccessiveValues.ucrSelector = Nothing
        '
        'ucrNewColumnName
        '
        resources.ApplyResources(Me.ucrNewColumnName, "ucrNewColumnName")
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        '
        'ucrPnlOptions
        '
        resources.ApplyResources(Me.ucrPnlOptions, "ucrPnlOptions")
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorDuplicateswithVariables
        '
        Me.ucrSelectorDuplicateswithVariables.bShowHiddenColumns = False
        Me.ucrSelectorDuplicateswithVariables.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorDuplicateswithVariables, "ucrSelectorDuplicateswithVariables")
        Me.ucrSelectorDuplicateswithVariables.Name = "ucrSelectorDuplicateswithVariables"
        '
        'ucrPnlDuplicates
        '
        resources.ApplyResources(Me.ucrPnlDuplicates, "ucrPnlDuplicates")
        Me.ucrPnlDuplicates.Name = "ucrPnlDuplicates"
        '
        'dlgDuplicates
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblVariablesToDuplicate)
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
        Me.Controls.Add(Me.grpOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDuplicates"
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
End Class
