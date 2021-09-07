<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDisplayTopN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDisplayTopN))
        Me.lbOrder = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrInputDisplay = New instat.ucrInputComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrInputLayout = New instat.ucrInputComboBox()
        Me.lblLayout = New System.Windows.Forms.Label()
        Me.ucrInputOrder = New instat.ucrInputComboBox()
        Me.ucrInputSymbol = New instat.ucrInputTextBox()
        Me.lblSymbol = New System.Windows.Forms.Label()
        Me.ucrSaveDisplay = New instat.ucrSave()
        Me.ucrChkIsCurrency = New instat.ucrCheck()
        Me.rdoPrimary = New System.Windows.Forms.RadioButton()
        Me.rdoSummary = New System.Windows.Forms.RadioButton()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblWeightBy = New System.Windows.Forms.Label()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.ucrReceiverWeightBy = New instat.ucrReceiverSingle()
        Me.ucrReceiverVariable = New instat.ucrReceiverSingle()
        Me.ucrSelectorDisplayTopN = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlDataType = New instat.UcrPanel()
        Me.ucrInputNLevels = New instat.ucrInputTextBox()
        Me.lblTopLevels = New System.Windows.Forms.Label()
        Me.ucrInputSummary = New instat.ucrInputComboBox()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbOrder
        '
        resources.ApplyResources(Me.lbOrder, "lbOrder")
        Me.lbOrder.Name = "lbOrder"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrInputDisplay)
        Me.grpOptions.Controls.Add(Me.Label1)
        Me.grpOptions.Controls.Add(Me.ucrInputLayout)
        Me.grpOptions.Controls.Add(Me.lblLayout)
        resources.ApplyResources(Me.grpOptions, "grpOptions")
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.TabStop = False
        '
        'ucrInputDisplay
        '
        Me.ucrInputDisplay.AddQuotesIfUnrecognised = True
        Me.ucrInputDisplay.GetSetSelectedIndex = -1
        Me.ucrInputDisplay.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDisplay, "ucrInputDisplay")
        Me.ucrInputDisplay.Name = "ucrInputDisplay"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'ucrInputLayout
        '
        Me.ucrInputLayout.AddQuotesIfUnrecognised = True
        Me.ucrInputLayout.GetSetSelectedIndex = -1
        Me.ucrInputLayout.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLayout, "ucrInputLayout")
        Me.ucrInputLayout.Name = "ucrInputLayout"
        '
        'lblLayout
        '
        resources.ApplyResources(Me.lblLayout, "lblLayout")
        Me.lblLayout.Name = "lblLayout"
        '
        'ucrInputOrder
        '
        Me.ucrInputOrder.AddQuotesIfUnrecognised = True
        Me.ucrInputOrder.GetSetSelectedIndex = -1
        Me.ucrInputOrder.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputOrder, "ucrInputOrder")
        Me.ucrInputOrder.Name = "ucrInputOrder"
        '
        'ucrInputSymbol
        '
        Me.ucrInputSymbol.AddQuotesIfUnrecognised = True
        Me.ucrInputSymbol.IsMultiline = False
        Me.ucrInputSymbol.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSymbol, "ucrInputSymbol")
        Me.ucrInputSymbol.Name = "ucrInputSymbol"
        '
        'lblSymbol
        '
        resources.ApplyResources(Me.lblSymbol, "lblSymbol")
        Me.lblSymbol.Name = "lblSymbol"
        '
        'ucrSaveDisplay
        '
        resources.ApplyResources(Me.ucrSaveDisplay, "ucrSaveDisplay")
        Me.ucrSaveDisplay.Name = "ucrSaveDisplay"
        '
        'ucrChkIsCurrency
        '
        Me.ucrChkIsCurrency.Checked = False
        resources.ApplyResources(Me.ucrChkIsCurrency, "ucrChkIsCurrency")
        Me.ucrChkIsCurrency.Name = "ucrChkIsCurrency"
        '
        'rdoPrimary
        '
        resources.ApplyResources(Me.rdoPrimary, "rdoPrimary")
        Me.rdoPrimary.BackColor = System.Drawing.SystemColors.Control
        Me.rdoPrimary.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPrimary.FlatAppearance.BorderSize = 2
        Me.rdoPrimary.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPrimary.Name = "rdoPrimary"
        Me.rdoPrimary.TabStop = True
        Me.rdoPrimary.Tag = ""
        Me.rdoPrimary.UseVisualStyleBackColor = False
        '
        'rdoSummary
        '
        resources.ApplyResources(Me.rdoSummary, "rdoSummary")
        Me.rdoSummary.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSummary.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummary.FlatAppearance.BorderSize = 2
        Me.rdoSummary.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummary.Name = "rdoSummary"
        Me.rdoSummary.TabStop = True
        Me.rdoSummary.Tag = "Pie_Chart"
        Me.rdoSummary.UseVisualStyleBackColor = False
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Plot_Options..."
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblWeightBy
        '
        resources.ApplyResources(Me.lblWeightBy, "lblWeightBy")
        Me.lblWeightBy.Name = "lblWeightBy"
        Me.lblWeightBy.Tag = ""
        '
        'lblVariable
        '
        resources.ApplyResources(Me.lblVariable, "lblVariable")
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Tag = ""
        '
        'ucrReceiverWeightBy
        '
        Me.ucrReceiverWeightBy.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWeightBy, "ucrReceiverWeightBy")
        Me.ucrReceiverWeightBy.Name = "ucrReceiverWeightBy"
        Me.ucrReceiverWeightBy.Selector = Nothing
        Me.ucrReceiverWeightBy.strNcFilePath = ""
        Me.ucrReceiverWeightBy.ucrSelector = Nothing
        '
        'ucrReceiverVariable
        '
        Me.ucrReceiverVariable.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverVariable, "ucrReceiverVariable")
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        Me.ucrReceiverVariable.strNcFilePath = ""
        Me.ucrReceiverVariable.ucrSelector = Nothing
        '
        'ucrSelectorDisplayTopN
        '
        Me.ucrSelectorDisplayTopN.bDropUnusedFilterLevels = False
        Me.ucrSelectorDisplayTopN.bShowHiddenColumns = False
        Me.ucrSelectorDisplayTopN.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorDisplayTopN, "ucrSelectorDisplayTopN")
        Me.ucrSelectorDisplayTopN.Name = "ucrSelectorDisplayTopN"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrPnlDataType
        '
        resources.ApplyResources(Me.ucrPnlDataType, "ucrPnlDataType")
        Me.ucrPnlDataType.Name = "ucrPnlDataType"
        '
        'ucrInputNLevels
        '
        Me.ucrInputNLevels.AddQuotesIfUnrecognised = True
        Me.ucrInputNLevels.IsMultiline = False
        Me.ucrInputNLevels.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNLevels, "ucrInputNLevels")
        Me.ucrInputNLevels.Name = "ucrInputNLevels"
        '
        'lblTopLevels
        '
        resources.ApplyResources(Me.lblTopLevels, "lblTopLevels")
        Me.lblTopLevels.Name = "lblTopLevels"
        '
        'ucrInputSummary
        '
        Me.ucrInputSummary.AddQuotesIfUnrecognised = True
        Me.ucrInputSummary.GetSetSelectedIndex = -1
        Me.ucrInputSummary.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSummary, "ucrInputSummary")
        Me.ucrInputSummary.Name = "ucrInputSummary"
        '
        'lblSummary
        '
        resources.ApplyResources(Me.lblSummary, "lblSummary")
        Me.lblSummary.Name = "lblSummary"
        '
        'dlgDisplayTopN
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputSummary)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.ucrInputNLevels)
        Me.Controls.Add(Me.ucrInputOrder)
        Me.Controls.Add(Me.lblTopLevels)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.lbOrder)
        Me.Controls.Add(Me.ucrInputSymbol)
        Me.Controls.Add(Me.lblSymbol)
        Me.Controls.Add(Me.ucrSaveDisplay)
        Me.Controls.Add(Me.ucrChkIsCurrency)
        Me.Controls.Add(Me.rdoPrimary)
        Me.Controls.Add(Me.rdoSummary)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblWeightBy)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrReceiverWeightBy)
        Me.Controls.Add(Me.ucrReceiverVariable)
        Me.Controls.Add(Me.ucrSelectorDisplayTopN)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlDataType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplayTopN"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbOrder As Label
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents ucrInputSymbol As ucrInputTextBox
    Friend WithEvents lblSymbol As Label
    Friend WithEvents ucrSaveDisplay As ucrSave
    Friend WithEvents ucrChkIsCurrency As ucrCheck
    Friend WithEvents rdoPrimary As RadioButton
    Friend WithEvents rdoSummary As RadioButton
    Friend WithEvents cmdOptions As Button
    Friend WithEvents lblWeightBy As Label
    Friend WithEvents lblVariable As Label
    Friend WithEvents ucrReceiverWeightBy As ucrReceiverSingle
    Friend WithEvents ucrReceiverVariable As ucrReceiverSingle
    Friend WithEvents ucrSelectorDisplayTopN As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPnlDataType As UcrPanel
    Friend WithEvents ucrInputLayout As ucrInputComboBox
    Friend WithEvents ucrInputOrder As ucrInputComboBox
    Friend WithEvents lblLayout As Label
    Friend WithEvents ucrInputNLevels As ucrInputTextBox
    Friend WithEvents lblTopLevels As Label
    Friend WithEvents ucrInputDisplay As ucrInputComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrInputSummary As ucrInputComboBox
    Friend WithEvents lblSummary As Label
End Class
