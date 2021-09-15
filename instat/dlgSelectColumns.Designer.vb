<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSelectColumns
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgSelectColumns))
        Me.ucrSelectorForColumnSelection = New instat.ucrSelectorByDataFrameAddRemove()
        Me.cmdCombineWithAndOr = New System.Windows.Forms.Button()
        Me.ucrInputSelectName = New instat.ucrInputComboBox()
        Me.lblNewSelectName = New System.Windows.Forms.Label()
        Me.cmdClearConditions = New System.Windows.Forms.Button()
        Me.ucrSelectPreview = New instat.ucrInputTextBox()
        Me.lblSelectPreview = New System.Windows.Forms.Label()
        Me.lstColumnSelections = New System.Windows.Forms.ListView()
        Me.cmdAddCondition = New System.Windows.Forms.Button()
        Me.lblSelectBy = New System.Windows.Forms.Label()
        Me.ucrInputSelectOperation = New instat.ucrInputComboBox()
        Me.ucrReceiverMultipleVariables = New instat.ucrReceiverMultiple()
        Me.lblSeclectedColumns = New System.Windows.Forms.Label()
        Me.ucrInputText = New instat.ucrInputTextBox()
        Me.lblString = New System.Windows.Forms.Label()
        Me.ucrChkIgnoreCase = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.ucrNudTo = New instat.ucrNud()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrSelectorForColumnSelection
        '
        Me.ucrSelectorForColumnSelection.bDropUnusedFilterLevels = False
        Me.ucrSelectorForColumnSelection.bShowHiddenColumns = False
        Me.ucrSelectorForColumnSelection.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForColumnSelection, "ucrSelectorForColumnSelection")
        Me.ucrSelectorForColumnSelection.Name = "ucrSelectorForColumnSelection"
        '
        'cmdCombineWithAndOr
        '
        resources.ApplyResources(Me.cmdCombineWithAndOr, "cmdCombineWithAndOr")
        Me.cmdCombineWithAndOr.Name = "cmdCombineWithAndOr"
        Me.cmdCombineWithAndOr.Tag = "Clear_Conditions"
        Me.cmdCombineWithAndOr.UseVisualStyleBackColor = True
        '
        'ucrInputSelectName
        '
        Me.ucrInputSelectName.AddQuotesIfUnrecognised = True
        Me.ucrInputSelectName.GetSetSelectedIndex = -1
        Me.ucrInputSelectName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSelectName, "ucrInputSelectName")
        Me.ucrInputSelectName.Name = "ucrInputSelectName"
        '
        'lblNewSelectName
        '
        resources.ApplyResources(Me.lblNewSelectName, "lblNewSelectName")
        Me.lblNewSelectName.Name = "lblNewSelectName"
        '
        'cmdClearConditions
        '
        resources.ApplyResources(Me.cmdClearConditions, "cmdClearConditions")
        Me.cmdClearConditions.Name = "cmdClearConditions"
        Me.cmdClearConditions.Tag = "Clear_Conditions"
        Me.cmdClearConditions.UseVisualStyleBackColor = True
        '
        'ucrSelectPreview
        '
        Me.ucrSelectPreview.AddQuotesIfUnrecognised = True
        Me.ucrSelectPreview.IsMultiline = False
        Me.ucrSelectPreview.IsReadOnly = False
        resources.ApplyResources(Me.ucrSelectPreview, "ucrSelectPreview")
        Me.ucrSelectPreview.Name = "ucrSelectPreview"
        '
        'lblSelectPreview
        '
        resources.ApplyResources(Me.lblSelectPreview, "lblSelectPreview")
        Me.lblSelectPreview.Name = "lblSelectPreview"
        '
        'lstColumnSelections
        '
        Me.lstColumnSelections.HideSelection = False
        resources.ApplyResources(Me.lstColumnSelections, "lstColumnSelections")
        Me.lstColumnSelections.Name = "lstColumnSelections"
        Me.lstColumnSelections.UseCompatibleStateImageBehavior = False
        Me.lstColumnSelections.View = System.Windows.Forms.View.Details
        '
        'cmdAddCondition
        '
        resources.ApplyResources(Me.cmdAddCondition, "cmdAddCondition")
        Me.cmdAddCondition.Name = "cmdAddCondition"
        Me.cmdAddCondition.Tag = "Add_condition"
        Me.cmdAddCondition.UseVisualStyleBackColor = True
        '
        'lblSelectBy
        '
        resources.ApplyResources(Me.lblSelectBy, "lblSelectBy")
        Me.lblSelectBy.Name = "lblSelectBy"
        '
        'ucrInputSelectOperation
        '
        Me.ucrInputSelectOperation.AddQuotesIfUnrecognised = True
        Me.ucrInputSelectOperation.GetSetSelectedIndex = -1
        Me.ucrInputSelectOperation.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSelectOperation, "ucrInputSelectOperation")
        Me.ucrInputSelectOperation.Name = "ucrInputSelectOperation"
        '
        'ucrReceiverMultipleVariables
        '
        Me.ucrReceiverMultipleVariables.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMultipleVariables, "ucrReceiverMultipleVariables")
        Me.ucrReceiverMultipleVariables.Name = "ucrReceiverMultipleVariables"
        Me.ucrReceiverMultipleVariables.Selector = Nothing
        Me.ucrReceiverMultipleVariables.strNcFilePath = ""
        Me.ucrReceiverMultipleVariables.ucrSelector = Nothing
        '
        'lblSeclectedColumns
        '
        resources.ApplyResources(Me.lblSeclectedColumns, "lblSeclectedColumns")
        Me.lblSeclectedColumns.Name = "lblSeclectedColumns"
        '
        'ucrInputText
        '
        Me.ucrInputText.AddQuotesIfUnrecognised = True
        Me.ucrInputText.IsMultiline = False
        Me.ucrInputText.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputText, "ucrInputText")
        Me.ucrInputText.Name = "ucrInputText"
        '
        'lblString
        '
        resources.ApplyResources(Me.lblString, "lblString")
        Me.lblString.Name = "lblString"
        '
        'ucrChkIgnoreCase
        '
        Me.ucrChkIgnoreCase.Checked = False
        resources.ApplyResources(Me.ucrChkIgnoreCase, "ucrChkIgnoreCase")
        Me.ucrChkIgnoreCase.Name = "ucrChkIgnoreCase"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudFrom, "ucrNudFrom")
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTo
        '
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudTo, "ucrNudTo")
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTo
        '
        resources.ApplyResources(Me.lblTo, "lblTo")
        Me.lblTo.Name = "lblTo"
        '
        'lblFrom
        '
        resources.ApplyResources(Me.lblFrom, "lblFrom")
        Me.lblFrom.Name = "lblFrom"
        '
        'dlgSelectColumns
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.ucrNudTo)
        Me.Controls.Add(Me.ucrNudFrom)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrChkIgnoreCase)
        Me.Controls.Add(Me.lblString)
        Me.Controls.Add(Me.lblSeclectedColumns)
        Me.Controls.Add(Me.ucrInputSelectOperation)
        Me.Controls.Add(Me.lblSelectBy)
        Me.Controls.Add(Me.cmdAddCondition)
        Me.Controls.Add(Me.cmdCombineWithAndOr)
        Me.Controls.Add(Me.ucrInputSelectName)
        Me.Controls.Add(Me.lblNewSelectName)
        Me.Controls.Add(Me.cmdClearConditions)
        Me.Controls.Add(Me.ucrSelectPreview)
        Me.Controls.Add(Me.lblSelectPreview)
        Me.Controls.Add(Me.lstColumnSelections)
        Me.Controls.Add(Me.ucrSelectorForColumnSelection)
        Me.Controls.Add(Me.ucrInputText)
        Me.Controls.Add(Me.ucrReceiverMultipleVariables)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSelectColumns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorForColumnSelection As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdCombineWithAndOr As Button
    Friend WithEvents ucrInputSelectName As ucrInputComboBox
    Friend WithEvents lblNewSelectName As Label
    Friend WithEvents cmdClearConditions As Button
    Friend WithEvents ucrSelectPreview As ucrInputTextBox
    Friend WithEvents lblSelectPreview As Label
    Friend WithEvents lstColumnSelections As ListView
    Friend WithEvents cmdAddCondition As Button
    Friend WithEvents lblSelectBy As Label
    Friend WithEvents ucrInputSelectOperation As ucrInputComboBox
    Friend WithEvents ucrReceiverMultipleVariables As ucrReceiverMultiple
    Friend WithEvents lblSeclectedColumns As Label
    Friend WithEvents ucrInputText As ucrInputTextBox
    Friend WithEvents lblString As Label
    Friend WithEvents ucrChkIgnoreCase As ucrCheck
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents ucrNudTo As ucrNud
    Friend WithEvents ucrNudFrom As ucrNud
End Class
