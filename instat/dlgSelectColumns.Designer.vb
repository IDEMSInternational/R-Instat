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
        Me.cmdCombineWithAndOr = New System.Windows.Forms.Button()
        Me.lblNewSelectName = New System.Windows.Forms.Label()
        Me.cmdClearConditions = New System.Windows.Forms.Button()
        Me.lblSelectPreview = New System.Windows.Forms.Label()
        Me.lstColumnSelections = New System.Windows.Forms.ListView()
        Me.cmdAddCondition = New System.Windows.Forms.Button()
        Me.lblSelectBy = New System.Windows.Forms.Label()
        Me.lblSeclectedColumns = New System.Windows.Forms.Label()
        Me.lblString = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblColumnType = New System.Windows.Forms.Label()
        Me.ucrInputColumnType = New instat.ucrInputComboBox()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.ucrChkIgnoreCase = New instat.ucrCheck()
        Me.ucrInputSelectOperation = New instat.ucrInputComboBox()
        Me.ucrInputSelectName = New instat.ucrInputComboBox()
        Me.ucrSelectPreview = New instat.ucrInputTextBox()
        Me.ucrSelectorForColumnSelection = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputText = New instat.ucrInputTextBox()
        Me.ucrReceiverMultipleVariables = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'cmdCombineWithAndOr
        '
        Me.cmdCombineWithAndOr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdCombineWithAndOr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCombineWithAndOr.Location = New System.Drawing.Point(264, 231)
        Me.cmdCombineWithAndOr.Name = "cmdCombineWithAndOr"
        Me.cmdCombineWithAndOr.Size = New System.Drawing.Size(142, 30)
        Me.cmdCombineWithAndOr.TabIndex = 14
        Me.cmdCombineWithAndOr.Tag = "Clear_Conditions"
        Me.cmdCombineWithAndOr.Text = "All Combined With |"
        Me.cmdCombineWithAndOr.UseVisualStyleBackColor = True
        '
        'lblNewSelectName
        '
        Me.lblNewSelectName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNewSelectName.Location = New System.Drawing.Point(13, 401)
        Me.lblNewSelectName.Name = "lblNewSelectName"
        Me.lblNewSelectName.Size = New System.Drawing.Size(158, 19)
        Me.lblNewSelectName.TabIndex = 18
        Me.lblNewSelectName.Text = "New Selection Name:"
        '
        'cmdClearConditions
        '
        Me.cmdClearConditions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClearConditions.Location = New System.Drawing.Point(264, 332)
        Me.cmdClearConditions.Name = "cmdClearConditions"
        Me.cmdClearConditions.Size = New System.Drawing.Size(142, 30)
        Me.cmdClearConditions.TabIndex = 15
        Me.cmdClearConditions.Tag = "Clear_Conditions"
        Me.cmdClearConditions.Text = "Clear Conditions"
        Me.cmdClearConditions.UseVisualStyleBackColor = True
        '
        'lblSelectPreview
        '
        Me.lblSelectPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectPreview.Location = New System.Drawing.Point(13, 374)
        Me.lblSelectPreview.Name = "lblSelectPreview"
        Me.lblSelectPreview.Size = New System.Drawing.Size(143, 19)
        Me.lblSelectPreview.TabIndex = 16
        Me.lblSelectPreview.Text = "Selection Preview:"
        Me.lblSelectPreview.Visible = False
        '
        'lstColumnSelections
        '
        Me.lstColumnSelections.HideSelection = False
        Me.lstColumnSelections.Location = New System.Drawing.Point(13, 230)
        Me.lstColumnSelections.Name = "lstColumnSelections"
        Me.lstColumnSelections.Size = New System.Drawing.Size(247, 132)
        Me.lstColumnSelections.TabIndex = 13
        Me.lstColumnSelections.UseCompatibleStateImageBehavior = False
        Me.lstColumnSelections.View = System.Windows.Forms.View.Details
        '
        'cmdAddCondition
        '
        Me.cmdAddCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdAddCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAddCondition.Location = New System.Drawing.Point(275, 85)
        Me.cmdAddCondition.Name = "cmdAddCondition"
        Me.cmdAddCondition.Size = New System.Drawing.Size(112, 30)
        Me.cmdAddCondition.TabIndex = 12
        Me.cmdAddCondition.Tag = "Add_condition"
        Me.cmdAddCondition.Text = "Add Condition"
        Me.cmdAddCondition.UseVisualStyleBackColor = True
        '
        'lblSelectBy
        '
        Me.lblSelectBy.AutoSize = True
        Me.lblSelectBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectBy.Location = New System.Drawing.Point(273, 38)
        Me.lblSelectBy.Name = "lblSelectBy"
        Me.lblSelectBy.Size = New System.Drawing.Size(55, 13)
        Me.lblSelectBy.TabIndex = 1
        Me.lblSelectBy.Text = "Select By:"
        '
        'lblSeclectedColumns
        '
        Me.lblSeclectedColumns.AutoSize = True
        Me.lblSeclectedColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSeclectedColumns.Location = New System.Drawing.Point(392, 38)
        Me.lblSeclectedColumns.Name = "lblSeclectedColumns"
        Me.lblSeclectedColumns.Size = New System.Drawing.Size(95, 13)
        Me.lblSeclectedColumns.TabIndex = 8
        Me.lblSeclectedColumns.Text = "Selected Columns:"
        '
        'lblString
        '
        Me.lblString.AutoSize = True
        Me.lblString.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblString.Location = New System.Drawing.Point(393, 38)
        Me.lblString.Name = "lblString"
        Me.lblString.Size = New System.Drawing.Size(36, 13)
        Me.lblString.TabIndex = 3
        Me.lblString.Text = "Prefix:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTo.Location = New System.Drawing.Point(388, 107)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 6
        Me.lblTo.Text = "To:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFrom.Location = New System.Drawing.Point(388, 81)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 4
        Me.lblFrom.Text = "From:"
        '
        'lblColumnType
        '
        Me.lblColumnType.AutoSize = True
        Me.lblColumnType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumnType.Location = New System.Drawing.Point(390, 38)
        Me.lblColumnType.Name = "lblColumnType"
        Me.lblColumnType.Size = New System.Drawing.Size(72, 13)
        Me.lblColumnType.TabIndex = 22
        Me.lblColumnType.Text = "Column Type:"
        Me.lblColumnType.Visible = False
        '
        'ucrInputColumnType
        '
        Me.ucrInputColumnType.AddQuotesIfUnrecognised = True
        Me.ucrInputColumnType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputColumnType.GetSetSelectedIndex = -1
        Me.ucrInputColumnType.IsReadOnly = False
        Me.ucrInputColumnType.Location = New System.Drawing.Point(391, 54)
        Me.ucrInputColumnType.Name = "ucrInputColumnType"
        Me.ucrInputColumnType.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputColumnType.TabIndex = 21
        Me.ucrInputColumnType.Visible = False
        '
        'ucrNudTo
        '
        Me.ucrNudTo.AutoSize = True
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Location = New System.Drawing.Point(423, 103)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTo.TabIndex = 7
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.AutoSize = True
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Location = New System.Drawing.Point(423, 80)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFrom.TabIndex = 5
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.Location = New System.Drawing.Point(180, 429)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(224, 30)
        Me.ucrBase.TabIndex = 20
        '
        'ucrChkIgnoreCase
        '
        Me.ucrChkIgnoreCase.AutoSize = True
        Me.ucrChkIgnoreCase.Checked = False
        Me.ucrChkIgnoreCase.Location = New System.Drawing.Point(393, 77)
        Me.ucrChkIgnoreCase.Name = "ucrChkIgnoreCase"
        Me.ucrChkIgnoreCase.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkIgnoreCase.TabIndex = 11
        '
        'ucrInputSelectOperation
        '
        Me.ucrInputSelectOperation.AddQuotesIfUnrecognised = True
        Me.ucrInputSelectOperation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSelectOperation.GetSetSelectedIndex = -1
        Me.ucrInputSelectOperation.IsReadOnly = False
        Me.ucrInputSelectOperation.Location = New System.Drawing.Point(276, 54)
        Me.ucrInputSelectOperation.Name = "ucrInputSelectOperation"
        Me.ucrInputSelectOperation.Size = New System.Drawing.Size(112, 21)
        Me.ucrInputSelectOperation.TabIndex = 2
        '
        'ucrInputSelectName
        '
        Me.ucrInputSelectName.AddQuotesIfUnrecognised = True
        Me.ucrInputSelectName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSelectName.GetSetSelectedIndex = -1
        Me.ucrInputSelectName.IsReadOnly = False
        Me.ucrInputSelectName.Location = New System.Drawing.Point(177, 397)
        Me.ucrInputSelectName.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputSelectName.Name = "ucrInputSelectName"
        Me.ucrInputSelectName.Size = New System.Drawing.Size(176, 21)
        Me.ucrInputSelectName.TabIndex = 19
        '
        'ucrSelectPreview
        '
        Me.ucrSelectPreview.AddQuotesIfUnrecognised = True
        Me.ucrSelectPreview.AutoSize = True
        Me.ucrSelectPreview.IsMultiline = False
        Me.ucrSelectPreview.IsReadOnly = False
        Me.ucrSelectPreview.Location = New System.Drawing.Point(158, 372)
        Me.ucrSelectPreview.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrSelectPreview.Name = "ucrSelectPreview"
        Me.ucrSelectPreview.Size = New System.Drawing.Size(248, 21)
        Me.ucrSelectPreview.TabIndex = 17
        Me.ucrSelectPreview.Visible = False
        '
        'ucrSelectorForColumnSelection
        '
        Me.ucrSelectorForColumnSelection.AutoSize = True
        Me.ucrSelectorForColumnSelection.bDropUnusedFilterLevels = False
        Me.ucrSelectorForColumnSelection.bShowHiddenColumns = False
        Me.ucrSelectorForColumnSelection.bUseCurrentFilter = True
        Me.ucrSelectorForColumnSelection.Location = New System.Drawing.Point(9, 28)
        Me.ucrSelectorForColumnSelection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForColumnSelection.Name = "ucrSelectorForColumnSelection"
        Me.ucrSelectorForColumnSelection.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForColumnSelection.TabIndex = 0
        '
        'ucrInputText
        '
        Me.ucrInputText.AddQuotesIfUnrecognised = True
        Me.ucrInputText.AutoSize = True
        Me.ucrInputText.IsMultiline = False
        Me.ucrInputText.IsReadOnly = False
        Me.ucrInputText.Location = New System.Drawing.Point(391, 54)
        Me.ucrInputText.Name = "ucrInputText"
        Me.ucrInputText.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputText.TabIndex = 9
        '
        'ucrReceiverMultipleVariables
        '
        Me.ucrReceiverMultipleVariables.AutoSize = True
        Me.ucrReceiverMultipleVariables.frmParent = Me
        Me.ucrReceiverMultipleVariables.Location = New System.Drawing.Point(391, 54)
        Me.ucrReceiverMultipleVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleVariables.Name = "ucrReceiverMultipleVariables"
        Me.ucrReceiverMultipleVariables.Selector = Nothing
        Me.ucrReceiverMultipleVariables.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleVariables.strNcFilePath = ""
        Me.ucrReceiverMultipleVariables.TabIndex = 10
        Me.ucrReceiverMultipleVariables.ucrSelector = Nothing
        '
        'dlgSelectColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(518, 464)
        Me.Controls.Add(Me.lblColumnType)
        Me.Controls.Add(Me.ucrInputColumnType)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Define New Column Selection"
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
    Friend WithEvents ucrInputColumnType As ucrInputComboBox
    Friend WithEvents lblColumnType As Label
End Class
