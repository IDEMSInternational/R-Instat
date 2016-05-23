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
        Me.lblFilterBy = New System.Windows.Forms.Label()
        Me.ucrValueForFilter = New instat.ucrInputTextBox()
        Me.ucrFilterPreview = New instat.ucrInputTextBox()
        Me.ucrFilterOperation = New instat.ucrInputComboBox()
        Me.ucrFactorLevels = New instat.ucrFactor()
        Me.ucrFilterByReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorForFitler = New instat.ucrSelectorByDataFrameAddRemove()
        Me.cmdClearConditions = New System.Windows.Forms.Button()
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
        'lblFilterBy
        '
        Me.lblFilterBy.AutoSize = True
        Me.lblFilterBy.Location = New System.Drawing.Point(271, 22)
        Me.lblFilterBy.Name = "lblFilterBy"
        Me.lblFilterBy.Size = New System.Drawing.Size(44, 13)
        Me.lblFilterBy.TabIndex = 13
        Me.lblFilterBy.Text = "Filter By"
        '
        'ucrValueForFilter
        '
        Me.ucrValueForFilter.Location = New System.Drawing.Point(490, 40)
        Me.ucrValueForFilter.Name = "ucrValueForFilter"
        Me.ucrValueForFilter.Size = New System.Drawing.Size(120, 21)
        Me.ucrValueForFilter.TabIndex = 11
        '
        'ucrFilterPreview
        '
        Me.ucrFilterPreview.Location = New System.Drawing.Point(94, 364)
        Me.ucrFilterPreview.Name = "ucrFilterPreview"
        Me.ucrFilterPreview.Size = New System.Drawing.Size(204, 21)
        Me.ucrFilterPreview.TabIndex = 10
        '
        'ucrFilterOperation
        '
        Me.ucrFilterOperation.Location = New System.Drawing.Point(421, 41)
        Me.ucrFilterOperation.Name = "ucrFilterOperation"
        Me.ucrFilterOperation.Size = New System.Drawing.Size(44, 21)
        Me.ucrFilterOperation.TabIndex = 5
        '
        'ucrFactorLevels
        '
        Me.ucrFactorLevels.AutoSize = True
        Me.ucrFactorLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrFactorLevels.clsReceiver = Nothing
        Me.ucrFactorLevels.Location = New System.Drawing.Point(413, 61)
        Me.ucrFactorLevels.Name = "ucrFactorLevels"
        Me.ucrFactorLevels.shtCurrSheet = Nothing
        Me.ucrFactorLevels.Size = New System.Drawing.Size(354, 216)
        Me.ucrFactorLevels.TabIndex = 2
        '
        'ucrFilterByReceiver
        '
        Me.ucrFilterByReceiver.Location = New System.Drawing.Point(274, 41)
        Me.ucrFilterByReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFilterByReceiver.Name = "ucrFilterByReceiver"
        Me.ucrFilterByReceiver.Selector = Nothing
        Me.ucrFilterByReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrFilterByReceiver.TabIndex = 1
        '
        'ucrSelectorForFitler
        '
        Me.ucrSelectorForFitler.Location = New System.Drawing.Point(4, 4)
        Me.ucrSelectorForFitler.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForFitler.Name = "ucrSelectorForFitler"
        Me.ucrSelectorForFitler.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForFitler.TabIndex = 0
        '
        'cmdClearConditions
        '
        Me.cmdClearConditions.Location = New System.Drawing.Point(317, 362)
        Me.cmdClearConditions.Name = "cmdClearConditions"
        Me.cmdClearConditions.Size = New System.Drawing.Size(94, 23)
        Me.cmdClearConditions.TabIndex = 14
        Me.cmdClearConditions.Tag = "Clear_Conditions"
        Me.cmdClearConditions.Text = "Clear Conditions"
        Me.cmdClearConditions.UseVisualStyleBackColor = True
        '
        'ucrFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdClearConditions)
        Me.Controls.Add(Me.lblFilterBy)
        Me.Controls.Add(Me.ucrValueForFilter)
        Me.Controls.Add(Me.ucrFilterPreview)
        Me.Controls.Add(Me.lblFilterPreview)
        Me.Controls.Add(Me.lstFilters)
        Me.Controls.Add(Me.cmdToggleSelectAll)
        Me.Controls.Add(Me.ucrFilterOperation)
        Me.Controls.Add(Me.cmdAddFilter)
        Me.Controls.Add(Me.lblSelectLevels)
        Me.Controls.Add(Me.ucrFactorLevels)
        Me.Controls.Add(Me.ucrFilterByReceiver)
        Me.Controls.Add(Me.ucrSelectorForFitler)
        Me.Name = "ucrFilter"
        Me.Size = New System.Drawing.Size(770, 395)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorForFitler As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFilterByReceiver As ucrReceiverSingle
    Friend WithEvents ucrFactorLevels As ucrFactor
    Friend WithEvents lblSelectLevels As Label
    Friend WithEvents cmdAddFilter As Button
    Friend WithEvents ucrFilterOperation As ucrInputComboBox
    Friend WithEvents cmdToggleSelectAll As Button
    Friend WithEvents lstFilters As ListView
    Friend WithEvents lblFilterPreview As Label
    Friend WithEvents ucrFilterPreview As ucrInputTextBox
    Friend WithEvents ucrValueForFilter As ucrInputTextBox
    Friend WithEvents lblFilterBy As Label
    Friend WithEvents cmdClearConditions As Button
End Class
