<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgAdvOptions
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
        Me.lblDist = New System.Windows.Forms.Label()
        Me.ucrInputDist = New instat.ucrInputComboBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.ucrNudDays = New instat.ucrNud()
        Me.ucrNudCount = New instat.ucrNud()
        Me.lblBins = New System.Windows.Forms.Label()
        Me.ucrInputBins = New instat.ucrInputComboBox()
        Me.ucrButtonsOptions = New instat.ucrButtonsSubdialogue()
        Me.ucrChkCalcByMonth = New instat.ucrCheck()
        Me.ucrNudBins = New instat.ucrNud()
        Me.lblNumberBins = New System.Windows.Forms.Label()
        Me.rdoAutoCalculate = New System.Windows.Forms.RadioButton()
        Me.rdoSpecifyBins = New System.Windows.Forms.RadioButton()
        Me.ucrPnlBins = New instat.UcrPanel()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'lblDist
        '
        Me.lblDist.AutoSize = True
        Me.lblDist.Location = New System.Drawing.Point(275, 107)
        Me.lblDist.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDist.Name = "lblDist"
        Me.lblDist.Size = New System.Drawing.Size(62, 13)
        Me.lblDist.TabIndex = 29
        Me.lblDist.Text = "Distribution:"
        '
        'ucrInputDist
        '
        Me.ucrInputDist.AddQuotesIfUnrecognised = True
        Me.ucrInputDist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDist.GetSetSelectedIndex = -1
        Me.ucrInputDist.IsReadOnly = False
        Me.ucrInputDist.Location = New System.Drawing.Point(339, 103)
        Me.ucrInputDist.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputDist.Name = "ucrInputDist"
        Me.ucrInputDist.Size = New System.Drawing.Size(77, 21)
        Me.ucrInputDist.TabIndex = 30
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(15, 106)
        Me.lblCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(38, 13)
        Me.lblCount.TabIndex = 25
        Me.lblCount.Text = "Count:"
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(135, 106)
        Me.lblDays.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(34, 13)
        Me.lblDays.TabIndex = 27
        Me.lblDays.Text = "Days:"
        '
        'ucrNudDays
        '
        Me.ucrNudDays.AutoSize = True
        Me.ucrNudDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDays.Location = New System.Drawing.Point(172, 103)
        Me.ucrNudDays.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrNudDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDays.Name = "ucrNudDays"
        Me.ucrNudDays.Size = New System.Drawing.Size(50, 21)
        Me.ucrNudDays.TabIndex = 28
        Me.ucrNudDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudCount
        '
        Me.ucrNudCount.AutoSize = True
        Me.ucrNudCount.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCount.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCount.Location = New System.Drawing.Point(55, 103)
        Me.ucrNudCount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrNudCount.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCount.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCount.Name = "ucrNudCount"
        Me.ucrNudCount.Size = New System.Drawing.Size(50, 23)
        Me.ucrNudCount.TabIndex = 26
        Me.ucrNudCount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblBins
        '
        Me.lblBins.AutoSize = True
        Me.lblBins.Location = New System.Drawing.Point(159, 58)
        Me.lblBins.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBins.Name = "lblBins"
        Me.lblBins.Size = New System.Drawing.Size(30, 13)
        Me.lblBins.TabIndex = 23
        Me.lblBins.Text = "Bins:"
        '
        'ucrInputBins
        '
        Me.ucrInputBins.AddQuotesIfUnrecognised = True
        Me.ucrInputBins.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBins.GetSetSelectedIndex = -1
        Me.ucrInputBins.IsReadOnly = False
        Me.ucrInputBins.Location = New System.Drawing.Point(191, 55)
        Me.ucrInputBins.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputBins.Name = "ucrInputBins"
        Me.ucrInputBins.Size = New System.Drawing.Size(132, 21)
        Me.ucrInputBins.TabIndex = 24
        '
        'ucrButtonsOptions
        '
        Me.ucrButtonsOptions.AutoSize = True
        Me.ucrButtonsOptions.Location = New System.Drawing.Point(93, 130)
        Me.ucrButtonsOptions.Name = "ucrButtonsOptions"
        Me.ucrButtonsOptions.Size = New System.Drawing.Size(224, 29)
        Me.ucrButtonsOptions.TabIndex = 31
        '
        'ucrChkCalcByMonth
        '
        Me.ucrChkCalcByMonth.AutoSize = True
        Me.ucrChkCalcByMonth.Checked = False
        Me.ucrChkCalcByMonth.Location = New System.Drawing.Point(159, 25)
        Me.ucrChkCalcByMonth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrChkCalcByMonth.Name = "ucrChkCalcByMonth"
        Me.ucrChkCalcByMonth.Size = New System.Drawing.Size(125, 23)
        Me.ucrChkCalcByMonth.TabIndex = 34
        '
        'ucrNudBins
        '
        Me.ucrNudBins.AutoSize = True
        Me.ucrNudBins.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBins.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBins.Location = New System.Drawing.Point(366, 27)
        Me.ucrNudBins.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrNudBins.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBins.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBins.Name = "ucrNudBins"
        Me.ucrNudBins.Size = New System.Drawing.Size(50, 21)
        Me.ucrNudBins.TabIndex = 36
        Me.ucrNudBins.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumberBins
        '
        Me.lblNumberBins.AutoSize = True
        Me.lblNumberBins.Location = New System.Drawing.Point(285, 29)
        Me.lblNumberBins.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumberBins.Name = "lblNumberBins"
        Me.lblNumberBins.Size = New System.Drawing.Size(79, 13)
        Me.lblNumberBins.TabIndex = 37
        Me.lblNumberBins.Text = "Number of Bins"
        '
        'rdoAutoCalculate
        '
        Me.rdoAutoCalculate.AutoSize = True
        Me.rdoAutoCalculate.Location = New System.Drawing.Point(27, 27)
        Me.rdoAutoCalculate.Name = "rdoAutoCalculate"
        Me.rdoAutoCalculate.Size = New System.Drawing.Size(116, 17)
        Me.rdoAutoCalculate.TabIndex = 83
        Me.rdoAutoCalculate.TabStop = True
        Me.rdoAutoCalculate.Text = "Autocalculate Bins:"
        Me.rdoAutoCalculate.UseVisualStyleBackColor = True
        '
        'rdoSpecifyBins
        '
        Me.rdoSpecifyBins.AutoSize = True
        Me.rdoSpecifyBins.Location = New System.Drawing.Point(27, 57)
        Me.rdoSpecifyBins.Name = "rdoSpecifyBins"
        Me.rdoSpecifyBins.Size = New System.Drawing.Size(86, 17)
        Me.rdoSpecifyBins.TabIndex = 84
        Me.rdoSpecifyBins.TabStop = True
        Me.rdoSpecifyBins.Text = "Specify Bins:"
        Me.rdoSpecifyBins.UseVisualStyleBackColor = True
        '
        'ucrPnlBins
        '
        Me.ucrPnlBins.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlBins.Location = New System.Drawing.Point(17, 27)
        Me.ucrPnlBins.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrPnlBins.Name = "ucrPnlBins"
        Me.ucrPnlBins.Size = New System.Drawing.Size(124, 47)
        Me.ucrPnlBins.TabIndex = 85
        '
        'grpDisplay
        '
        Me.grpDisplay.Location = New System.Drawing.Point(14, 6)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(411, 84)
        Me.grpDisplay.TabIndex = 86
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Bins"
        '
        'sdgAdvOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 167)
        Me.Controls.Add(Me.rdoSpecifyBins)
        Me.Controls.Add(Me.rdoAutoCalculate)
        Me.Controls.Add(Me.lblNumberBins)
        Me.Controls.Add(Me.ucrNudBins)
        Me.Controls.Add(Me.ucrChkCalcByMonth)
        Me.Controls.Add(Me.ucrButtonsOptions)
        Me.Controls.Add(Me.lblDist)
        Me.Controls.Add(Me.ucrInputDist)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.ucrNudDays)
        Me.Controls.Add(Me.ucrNudCount)
        Me.Controls.Add(Me.lblBins)
        Me.Controls.Add(Me.ucrInputBins)
        Me.Controls.Add(Me.ucrPnlBins)
        Me.Controls.Add(Me.grpDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgAdvOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDist As Label
    Friend WithEvents ucrInputDist As ucrInputComboBox
    Friend WithEvents lblCount As Label
    Friend WithEvents lblDays As Label
    Friend WithEvents ucrNudDays As ucrNud
    Friend WithEvents ucrNudCount As ucrNud
    Friend WithEvents lblBins As Label
    Friend WithEvents ucrInputBins As ucrInputComboBox
    Friend WithEvents ucrButtonsOptions As ucrButtonsSubdialogue
    Friend WithEvents ucrChkCalcByMonth As ucrCheck
    Friend WithEvents ucrNudBins As ucrNud
    Friend WithEvents lblNumberBins As Label
    Friend WithEvents rdoAutoCalculate As RadioButton
    Friend WithEvents rdoSpecifyBins As RadioButton
    Friend WithEvents ucrPnlBins As UcrPanel
    Friend WithEvents grpDisplay As GroupBox
End Class
