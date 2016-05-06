<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrFilter
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblSelectLevels = New System.Windows.Forms.Label()
        Me.cmdAddFilter = New System.Windows.Forms.Button()
        Me.cmdToggleSelectAll = New System.Windows.Forms.Button()
        Me.lstFilters = New System.Windows.Forms.ListView()
        Me.lblFilterPreview = New System.Windows.Forms.Label()
        Me.chkAsVariable = New System.Windows.Forms.CheckBox()
        Me.lblVariableToFilter = New System.Windows.Forms.Label()
        Me.ucrSecondValue = New instat.ucrInputTextBox()
        Me.ucrFilterPreview = New instat.ucrInputTextBox()
        Me.ucrSecondFilterVariable = New instat.ucrReceiverSingle()
        Me.ucrOperation = New instat.ucrInputComboBox()
        Me.ucrFactorLevels = New instat.ucrFactor()
        Me.ucrFilterVariable = New instat.ucrReceiverSingle()
        Me.ucrSelectorForFitler = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblSelectLevels
        '
        Me.lblSelectLevels.AutoSize = True
        Me.lblSelectLevels.Location = New System.Drawing.Point(413, 42)
        Me.lblSelectLevels.Name = "lblSelectLevels"
        Me.lblSelectLevels.Size = New System.Drawing.Size(71, 13)
        Me.lblSelectLevels.TabIndex = 3
        Me.lblSelectLevels.Text = "Select Levels"
        '
        'cmdAddFilter
        '
        Me.cmdAddFilter.Location = New System.Drawing.Point(274, 77)
        Me.cmdAddFilter.Name = "cmdAddFilter"
        Me.cmdAddFilter.Size = New System.Drawing.Size(93, 23)
        Me.cmdAddFilter.TabIndex = 4
        Me.cmdAddFilter.Text = "Add Filter"
        Me.cmdAddFilter.UseVisualStyleBackColor = True
        '
        'cmdToggleSelectAll
        '
        Me.cmdToggleSelectAll.Location = New System.Drawing.Point(416, 283)
        Me.cmdToggleSelectAll.Name = "cmdToggleSelectAll"
        Me.cmdToggleSelectAll.Size = New System.Drawing.Size(93, 23)
        Me.cmdToggleSelectAll.TabIndex = 7
        Me.cmdToggleSelectAll.Text = "Select All"
        Me.cmdToggleSelectAll.UseVisualStyleBackColor = True
        '
        'lstFilters
        '
        Me.lstFilters.Location = New System.Drawing.Point(4, 217)
        Me.lstFilters.Name = "lstFilters"
        Me.lstFilters.Size = New System.Drawing.Size(268, 132)
        Me.lstFilters.TabIndex = 8
        Me.lstFilters.UseCompatibleStateImageBehavior = False
        Me.lstFilters.View = System.Windows.Forms.View.Details
        '
        'lblFilterPreview
        '
        Me.lblFilterPreview.AutoSize = True
        Me.lblFilterPreview.Location = New System.Drawing.Point(6, 367)
        Me.lblFilterPreview.Name = "lblFilterPreview"
        Me.lblFilterPreview.Size = New System.Drawing.Size(70, 13)
        Me.lblFilterPreview.TabIndex = 9
        Me.lblFilterPreview.Text = "Fliter Preview"
        '
        'chkAsVariable
        '
        Me.chkAsVariable.AutoSize = True
        Me.chkAsVariable.Location = New System.Drawing.Point(491, 18)
        Me.chkAsVariable.Name = "chkAsVariable"
        Me.chkAsVariable.Size = New System.Drawing.Size(79, 17)
        Me.chkAsVariable.TabIndex = 12
        Me.chkAsVariable.Text = "As Variable"
        Me.chkAsVariable.UseVisualStyleBackColor = True
        '
        'lblVariableToFilter
        '
        Me.lblVariableToFilter.AutoSize = True
        Me.lblVariableToFilter.Location = New System.Drawing.Point(271, 22)
        Me.lblVariableToFilter.Name = "lblVariableToFilter"
        Me.lblVariableToFilter.Size = New System.Drawing.Size(101, 13)
        Me.lblVariableToFilter.TabIndex = 13
        Me.lblVariableToFilter.Text = "Variable To Filter By"
        '
        'ucrSecondValue
        '
        Me.ucrSecondValue.Location = New System.Drawing.Point(491, 41)
        Me.ucrSecondValue.Name = "ucrSecondValue"
        Me.ucrSecondValue.Size = New System.Drawing.Size(120, 21)
        Me.ucrSecondValue.TabIndex = 11
        '
        'ucrFilterPreview
        '
        Me.ucrFilterPreview.Location = New System.Drawing.Point(94, 364)
        Me.ucrFilterPreview.Name = "ucrFilterPreview"
        Me.ucrFilterPreview.Size = New System.Drawing.Size(204, 21)
        Me.ucrFilterPreview.TabIndex = 10
        '
        'ucrSecondFilterVariable
        '
        Me.ucrSecondFilterVariable.Location = New System.Drawing.Point(491, 41)
        Me.ucrSecondFilterVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondFilterVariable.Name = "ucrSecondFilterVariable"
        Me.ucrSecondFilterVariable.Selector = Nothing
        Me.ucrSecondFilterVariable.Size = New System.Drawing.Size(120, 20)
        Me.ucrSecondFilterVariable.TabIndex = 6
        '
        'ucrOperation
        '
        Me.ucrOperation.Location = New System.Drawing.Point(421, 41)
        Me.ucrOperation.Name = "ucrOperation"
        Me.ucrOperation.Size = New System.Drawing.Size(44, 21)
        Me.ucrOperation.TabIndex = 5
        '
        'ucrFactorLevels
        '
        Me.ucrFactorLevels.AutoSize = True
        Me.ucrFactorLevels.clsReceiver = Nothing
        Me.ucrFactorLevels.Location = New System.Drawing.Point(413, 61)
        Me.ucrFactorLevels.Name = "ucrFactorLevels"
        Me.ucrFactorLevels.shtCurrSheet = Nothing
        Me.ucrFactorLevels.Size = New System.Drawing.Size(354, 216)
        Me.ucrFactorLevels.TabIndex = 2
        '
        'ucrFilterVariable
        '
        Me.ucrFilterVariable.Location = New System.Drawing.Point(274, 41)
        Me.ucrFilterVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFilterVariable.Name = "ucrFilterVariable"
        Me.ucrFilterVariable.Selector = Nothing
        Me.ucrFilterVariable.Size = New System.Drawing.Size(120, 20)
        Me.ucrFilterVariable.TabIndex = 1
        '
        'ucrSelectorForFitler
        '
        Me.ucrSelectorForFitler.Location = New System.Drawing.Point(4, 4)
        Me.ucrSelectorForFitler.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForFitler.Name = "ucrSelectorForFitler"
        Me.ucrSelectorForFitler.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForFitler.TabIndex = 0
        '
        'ucrFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblVariableToFilter)
        Me.Controls.Add(Me.chkAsVariable)
        Me.Controls.Add(Me.ucrSecondValue)
        Me.Controls.Add(Me.ucrFilterPreview)
        Me.Controls.Add(Me.lblFilterPreview)
        Me.Controls.Add(Me.lstFilters)
        Me.Controls.Add(Me.cmdToggleSelectAll)
        Me.Controls.Add(Me.ucrSecondFilterVariable)
        Me.Controls.Add(Me.ucrOperation)
        Me.Controls.Add(Me.cmdAddFilter)
        Me.Controls.Add(Me.lblSelectLevels)
        Me.Controls.Add(Me.ucrFactorLevels)
        Me.Controls.Add(Me.ucrFilterVariable)
        Me.Controls.Add(Me.ucrSelectorForFitler)
        Me.Name = "ucrFilter"
        Me.Size = New System.Drawing.Size(770, 395)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorForFitler As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFilterVariable As ucrReceiverSingle
    Friend WithEvents ucrFactorLevels As ucrFactor
    Friend WithEvents lblSelectLevels As Label
    Friend WithEvents cmdAddFilter As Button
    Friend WithEvents ucrOperation As ucrInputComboBox
    Friend WithEvents ucrSecondFilterVariable As ucrReceiverSingle
    Friend WithEvents cmdToggleSelectAll As Button
    Friend WithEvents lstFilters As ListView
    Friend WithEvents lblFilterPreview As Label
    Friend WithEvents ucrFilterPreview As ucrInputTextBox
    Friend WithEvents ucrSecondValue As ucrInputTextBox
    Friend WithEvents chkAsVariable As CheckBox
    Friend WithEvents lblVariableToFilter As Label
End Class
