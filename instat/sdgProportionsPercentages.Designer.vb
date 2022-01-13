<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgProportionsPercentages
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
        Me.rdoByFactors = New System.Windows.Forms.RadioButton()
        Me.rdoByFilter = New System.Windows.Forms.RadioButton()
        Me.rdoByColumn = New System.Windows.Forms.RadioButton()
        Me.lblByFactors = New System.Windows.Forms.Label()
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkDisplayAsDecimal = New instat.ucrCheck()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.ucrReceiverFilter = New instat.ucrReceiverSingle()
        Me.ucrReceiverColumn = New instat.ucrReceiverSingle()
        Me.ucrButtonsProportionsPercentiles = New instat.ucrButtonsSubdialogue()
        Me.ucrReceiverByFactor = New instat.ucrReceiverMultiple()
        Me.ucrSelectorProportionsPercentiles = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlBY = New instat.UcrPanel()
        Me.ucrChkProportionsPercentages = New instat.ucrCheck()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoByFactors
        '
        Me.rdoByFactors.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoByFactors.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByFactors.FlatAppearance.BorderSize = 2
        Me.rdoByFactors.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByFactors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoByFactors.Location = New System.Drawing.Point(49, 40)
        Me.rdoByFactors.Name = "rdoByFactors"
        Me.rdoByFactors.Size = New System.Drawing.Size(103, 27)
        Me.rdoByFactors.TabIndex = 2
        Me.rdoByFactors.TabStop = True
        Me.rdoByFactors.Text = "By Factor(s)"
        Me.rdoByFactors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoByFactors.UseVisualStyleBackColor = True
        '
        'rdoByFilter
        '
        Me.rdoByFilter.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoByFilter.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByFilter.FlatAppearance.BorderSize = 2
        Me.rdoByFilter.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoByFilter.Location = New System.Drawing.Point(149, 40)
        Me.rdoByFilter.Name = "rdoByFilter"
        Me.rdoByFilter.Size = New System.Drawing.Size(103, 27)
        Me.rdoByFilter.TabIndex = 3
        Me.rdoByFilter.TabStop = True
        Me.rdoByFilter.Text = "By Filter"
        Me.rdoByFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoByFilter.UseVisualStyleBackColor = True
        '
        'rdoByColumn
        '
        Me.rdoByColumn.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoByColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByColumn.FlatAppearance.BorderSize = 2
        Me.rdoByColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoByColumn.Location = New System.Drawing.Point(250, 40)
        Me.rdoByColumn.Name = "rdoByColumn"
        Me.rdoByColumn.Size = New System.Drawing.Size(103, 27)
        Me.rdoByColumn.TabIndex = 4
        Me.rdoByColumn.TabStop = True
        Me.rdoByColumn.Text = "By Column"
        Me.rdoByColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoByColumn.UseVisualStyleBackColor = True
        '
        'lblByFactors
        '
        Me.lblByFactors.AutoSize = True
        Me.lblByFactors.Location = New System.Drawing.Point(238, 115)
        Me.lblByFactors.Name = "lblByFactors"
        Me.lblByFactors.Size = New System.Drawing.Size(171, 13)
        Me.lblByFactors.TabIndex = 6
        Me.lblByFactors.Text = "As Proportion of Factors (Optional):"
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.Location = New System.Drawing.Point(238, 115)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(45, 13)
        Me.lblColumn.TabIndex = 10
        Me.lblColumn.Text = "Column:"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrChkDisplayAsDecimal)
        Me.grpOptions.Location = New System.Drawing.Point(9, 265)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(210, 88)
        Me.grpOptions.TabIndex = 12
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'ucrChkDisplayAsDecimal
        '
        Me.ucrChkDisplayAsDecimal.AutoSize = True
        Me.ucrChkDisplayAsDecimal.Checked = False
        Me.ucrChkDisplayAsDecimal.Location = New System.Drawing.Point(7, 21)
        Me.ucrChkDisplayAsDecimal.Name = "ucrChkDisplayAsDecimal"
        Me.ucrChkDisplayAsDecimal.Size = New System.Drawing.Size(214, 23)
        Me.ucrChkDisplayAsDecimal.TabIndex = 1
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(239, 115)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(32, 13)
        Me.lblFilter.TabIndex = 11
        Me.lblFilter.Text = "Filter:"
        Me.lblFilter.UseMnemonic = False
        '
        'ucrReceiverFilter
        '
        Me.ucrReceiverFilter.AutoSize = True
        Me.ucrReceiverFilter.frmParent = Me
        Me.ucrReceiverFilter.Location = New System.Drawing.Point(239, 130)
        Me.ucrReceiverFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFilter.Name = "ucrReceiverFilter"
        Me.ucrReceiverFilter.Selector = Nothing
        Me.ucrReceiverFilter.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFilter.strNcFilePath = ""
        Me.ucrReceiverFilter.TabIndex = 9
        Me.ucrReceiverFilter.ucrSelector = Nothing
        '
        'ucrReceiverColumn
        '
        Me.ucrReceiverColumn.AutoSize = True
        Me.ucrReceiverColumn.frmParent = Me
        Me.ucrReceiverColumn.Location = New System.Drawing.Point(239, 130)
        Me.ucrReceiverColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumn.Name = "ucrReceiverColumn"
        Me.ucrReceiverColumn.Selector = Nothing
        Me.ucrReceiverColumn.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverColumn.strNcFilePath = ""
        Me.ucrReceiverColumn.TabIndex = 11
        Me.ucrReceiverColumn.ucrSelector = Nothing
        '
        'ucrButtonsProportionsPercentiles
        '
        Me.ucrButtonsProportionsPercentiles.AutoSize = True
        Me.ucrButtonsProportionsPercentiles.Location = New System.Drawing.Point(124, 368)
        Me.ucrButtonsProportionsPercentiles.Name = "ucrButtonsProportionsPercentiles"
        Me.ucrButtonsProportionsPercentiles.Size = New System.Drawing.Size(224, 30)
        Me.ucrButtonsProportionsPercentiles.TabIndex = 13
        '
        'ucrReceiverByFactor
        '
        Me.ucrReceiverByFactor.AutoSize = True
        Me.ucrReceiverByFactor.frmParent = Me
        Me.ucrReceiverByFactor.Location = New System.Drawing.Point(239, 130)
        Me.ucrReceiverByFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverByFactor.Name = "ucrReceiverByFactor"
        Me.ucrReceiverByFactor.Selector = Nothing
        Me.ucrReceiverByFactor.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverByFactor.strNcFilePath = ""
        Me.ucrReceiverByFactor.TabIndex = 8
        Me.ucrReceiverByFactor.ucrSelector = Nothing
        '
        'ucrSelectorProportionsPercentiles
        '
        Me.ucrSelectorProportionsPercentiles.AutoSize = True
        Me.ucrSelectorProportionsPercentiles.bDropUnusedFilterLevels = False
        Me.ucrSelectorProportionsPercentiles.bShowHiddenColumns = False
        Me.ucrSelectorProportionsPercentiles.bUseCurrentFilter = True
        Me.ucrSelectorProportionsPercentiles.Location = New System.Drawing.Point(9, 79)
        Me.ucrSelectorProportionsPercentiles.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorProportionsPercentiles.Name = "ucrSelectorProportionsPercentiles"
        Me.ucrSelectorProportionsPercentiles.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorProportionsPercentiles.TabIndex = 5
        '
        'ucrPnlBY
        '
        Me.ucrPnlBY.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlBY.Location = New System.Drawing.Point(37, 32)
        Me.ucrPnlBY.Name = "ucrPnlBY"
        Me.ucrPnlBY.Size = New System.Drawing.Size(336, 44)
        Me.ucrPnlBY.TabIndex = 1
        '
        'ucrChkProportionsPercentages
        '
        Me.ucrChkProportionsPercentages.AutoSize = True
        Me.ucrChkProportionsPercentages.Checked = False
        Me.ucrChkProportionsPercentages.Location = New System.Drawing.Point(10, 14)
        Me.ucrChkProportionsPercentages.Name = "ucrChkProportionsPercentages"
        Me.ucrChkProportionsPercentages.Size = New System.Drawing.Size(343, 23)
        Me.ucrChkProportionsPercentages.TabIndex = 0
        '
        'sdgProportionsPercentages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(410, 397)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.ucrReceiverFilter)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.lblColumn)
        Me.Controls.Add(Me.ucrReceiverColumn)
        Me.Controls.Add(Me.ucrButtonsProportionsPercentiles)
        Me.Controls.Add(Me.ucrReceiverByFactor)
        Me.Controls.Add(Me.lblByFactors)
        Me.Controls.Add(Me.ucrSelectorProportionsPercentiles)
        Me.Controls.Add(Me.rdoByColumn)
        Me.Controls.Add(Me.rdoByFactors)
        Me.Controls.Add(Me.rdoByFilter)
        Me.Controls.Add(Me.ucrPnlBY)
        Me.Controls.Add(Me.ucrChkProportionsPercentages)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgProportionsPercentages"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proportions or Percentages"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrChkProportionsPercentages As ucrCheck
    Friend WithEvents rdoByFactors As RadioButton
    Friend WithEvents rdoByFilter As RadioButton
    Friend WithEvents ucrPnlBY As UcrPanel
    Friend WithEvents rdoByColumn As RadioButton
    Friend WithEvents ucrSelectorProportionsPercentiles As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverByFactor As ucrReceiverMultiple
    Friend WithEvents lblByFactors As Label
    Friend WithEvents ucrButtonsProportionsPercentiles As ucrButtonsSubdialogue
    Friend WithEvents ucrReceiverColumn As ucrReceiverSingle
    Friend WithEvents lblColumn As Label
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents ucrChkDisplayAsDecimal As ucrCheck
    Friend WithEvents lblFilter As Label
    Friend WithEvents ucrReceiverFilter As ucrReceiverSingle
End Class
