<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgClimaticDataEntryOptions
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
        Me.components = New System.ComponentModel.Container()
        Me.grpRestrictEntry = New System.Windows.Forms.GroupBox()
        Me.ucrChkAllowTrace = New instat.ucrCheck()
        Me.ucrChkNoDecimal = New instat.ucrCheck()
        Me.ttDefaultValue = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblDefault = New System.Windows.Forms.Label()
        Me.ucrInputDefaultValue = New instat.ucrInputComboBox()
        Me.lblBefore = New System.Windows.Forms.Label()
        Me.lblAfter = New System.Windows.Forms.Label()
        Me.ttucrChkTransform = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrChkIncludeFirstNextMonth = New instat.ucrCheck()
        Me.ucrChkEditNAOnly = New instat.ucrCheck()
        Me.ucrChkTransform = New instat.ucrCheck()
        Me.ucrChkExtraRows = New instat.ucrCheck()
        Me.ucrNudAfter = New instat.ucrNud()
        Me.ucrNudBefore = New instat.ucrNud()
        Me.ucrSdgPICSARainfalbuttons = New instat.ucrButtonsSubdialogue()
        Me.ucrInputTransform = New instat.ucrInputComboBox()
        Me.grpRestrictEntry.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpRestrictEntry
        '
        Me.grpRestrictEntry.Controls.Add(Me.ucrChkAllowTrace)
        Me.grpRestrictEntry.Controls.Add(Me.ucrChkNoDecimal)
        Me.grpRestrictEntry.Location = New System.Drawing.Point(15, 163)
        Me.grpRestrictEntry.Name = "grpRestrictEntry"
        Me.grpRestrictEntry.Size = New System.Drawing.Size(289, 40)
        Me.grpRestrictEntry.TabIndex = 90
        Me.grpRestrictEntry.TabStop = False
        Me.grpRestrictEntry.Text = "Restrict Entry"
        '
        'ucrChkAllowTrace
        '
        Me.ucrChkAllowTrace.AutoSize = True
        Me.ucrChkAllowTrace.Checked = False
        Me.ucrChkAllowTrace.Location = New System.Drawing.Point(109, 14)
        Me.ucrChkAllowTrace.Name = "ucrChkAllowTrace"
        Me.ucrChkAllowTrace.Size = New System.Drawing.Size(127, 23)
        Me.ucrChkAllowTrace.TabIndex = 66
        '
        'ucrChkNoDecimal
        '
        Me.ucrChkNoDecimal.AutoSize = True
        Me.ucrChkNoDecimal.Checked = False
        Me.ucrChkNoDecimal.Location = New System.Drawing.Point(7, 14)
        Me.ucrChkNoDecimal.Name = "ucrChkNoDecimal"
        Me.ucrChkNoDecimal.Size = New System.Drawing.Size(113, 23)
        Me.ucrChkNoDecimal.TabIndex = 65
        '
        'ttDefaultValue
        '
        Me.ttDefaultValue.AutoPopDelay = 10000
        Me.ttDefaultValue.InitialDelay = 500
        Me.ttDefaultValue.ReshowDelay = 100
        '
        'lblDefault
        '
        Me.lblDefault.AutoSize = True
        Me.lblDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDefault.Location = New System.Drawing.Point(9, 15)
        Me.lblDefault.Name = "lblDefault"
        Me.lblDefault.Size = New System.Drawing.Size(113, 13)
        Me.lblDefault.TabIndex = 102
        Me.lblDefault.Text = "Missing/Default value:"
        Me.ttDefaultValue.SetToolTip(Me.lblDefault, "Default value for missing values")
        '
        'ucrInputDefaultValue
        '
        Me.ucrInputDefaultValue.AddQuotesIfUnrecognised = True
        Me.ucrInputDefaultValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDefaultValue.GetSetSelectedIndex = -1
        Me.ucrInputDefaultValue.IsReadOnly = False
        Me.ucrInputDefaultValue.Location = New System.Drawing.Point(130, 10)
        Me.ucrInputDefaultValue.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputDefaultValue.Name = "ucrInputDefaultValue"
        Me.ucrInputDefaultValue.Size = New System.Drawing.Size(73, 21)
        Me.ucrInputDefaultValue.TabIndex = 101
        Me.ttDefaultValue.SetToolTip(Me.ucrInputDefaultValue, "Select default value for missing values")
        '
        'lblBefore
        '
        Me.lblBefore.AutoSize = True
        Me.lblBefore.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBefore.Location = New System.Drawing.Point(102, 132)
        Me.lblBefore.Name = "lblBefore"
        Me.lblBefore.Size = New System.Drawing.Size(41, 13)
        Me.lblBefore.TabIndex = 98
        Me.lblBefore.Text = "Before:"
        Me.lblBefore.Visible = False
        '
        'lblAfter
        '
        Me.lblAfter.AutoSize = True
        Me.lblAfter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAfter.Location = New System.Drawing.Point(197, 132)
        Me.lblAfter.Name = "lblAfter"
        Me.lblAfter.Size = New System.Drawing.Size(32, 13)
        Me.lblAfter.TabIndex = 99
        Me.lblAfter.Text = "After:"
        Me.lblAfter.Visible = False
        '
        'ttucrChkTransform
        '
        Me.ttucrChkTransform.AutoPopDelay = 10000
        Me.ttucrChkTransform.InitialDelay = 500
        Me.ttucrChkTransform.ReshowDelay = 100
        '
        'ucrChkIncludeFirstNextMonth
        '
        Me.ucrChkIncludeFirstNextMonth.AutoSize = True
        Me.ucrChkIncludeFirstNextMonth.Checked = False
        Me.ucrChkIncludeFirstNextMonth.Location = New System.Drawing.Point(12, 96)
        Me.ucrChkIncludeFirstNextMonth.Name = "ucrChkIncludeFirstNextMonth"
        Me.ucrChkIncludeFirstNextMonth.Size = New System.Drawing.Size(192, 23)
        Me.ucrChkIncludeFirstNextMonth.TabIndex = 104
        Me.ttucrChkTransform.SetToolTip(Me.ucrChkIncludeFirstNextMonth, "The values written to the data frame are transformed, usually multiplied, by the " &
        "value given here.")
        '
        'ucrChkEditNAOnly
        '
        Me.ucrChkEditNAOnly.AutoSize = True
        Me.ucrChkEditNAOnly.Checked = False
        Me.ucrChkEditNAOnly.Location = New System.Drawing.Point(12, 44)
        Me.ucrChkEditNAOnly.Name = "ucrChkEditNAOnly"
        Me.ucrChkEditNAOnly.Size = New System.Drawing.Size(192, 23)
        Me.ucrChkEditNAOnly.TabIndex = 103
        Me.ttucrChkTransform.SetToolTip(Me.ucrChkEditNAOnly, "The values written to the data frame are transformed, usually multiplied, by the " &
        "value given here.")
        '
        'ucrChkTransform
        '
        Me.ucrChkTransform.AutoSize = True
        Me.ucrChkTransform.Checked = False
        Me.ucrChkTransform.Location = New System.Drawing.Point(12, 70)
        Me.ucrChkTransform.Name = "ucrChkTransform"
        Me.ucrChkTransform.Size = New System.Drawing.Size(83, 23)
        Me.ucrChkTransform.TabIndex = 88
        Me.ttucrChkTransform.SetToolTip(Me.ucrChkTransform, "The values written to the data frame are transformed, usually multiplied, by the " &
        "value given here.")
        '
        'ucrChkExtraRows
        '
        Me.ucrChkExtraRows.AutoSize = True
        Me.ucrChkExtraRows.Checked = False
        Me.ucrChkExtraRows.Enabled = False
        Me.ucrChkExtraRows.Location = New System.Drawing.Point(12, 129)
        Me.ucrChkExtraRows.Name = "ucrChkExtraRows"
        Me.ucrChkExtraRows.Size = New System.Drawing.Size(93, 23)
        Me.ucrChkExtraRows.TabIndex = 97
        '
        'ucrNudAfter
        '
        Me.ucrNudAfter.AutoSize = True
        Me.ucrNudAfter.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAfter.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAfter.Location = New System.Drawing.Point(233, 129)
        Me.ucrNudAfter.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAfter.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAfter.Name = "ucrNudAfter"
        Me.ucrNudAfter.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAfter.TabIndex = 96
        Me.ucrNudAfter.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAfter.Visible = False
        '
        'ucrNudBefore
        '
        Me.ucrNudBefore.AutoSize = True
        Me.ucrNudBefore.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBefore.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBefore.Location = New System.Drawing.Point(143, 129)
        Me.ucrNudBefore.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBefore.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBefore.Name = "ucrNudBefore"
        Me.ucrNudBefore.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudBefore.TabIndex = 95
        Me.ucrNudBefore.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBefore.Visible = False
        '
        'ucrSdgPICSARainfalbuttons
        '
        Me.ucrSdgPICSARainfalbuttons.AutoSize = True
        Me.ucrSdgPICSARainfalbuttons.Location = New System.Drawing.Point(71, 210)
        Me.ucrSdgPICSARainfalbuttons.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrSdgPICSARainfalbuttons.Name = "ucrSdgPICSARainfalbuttons"
        Me.ucrSdgPICSARainfalbuttons.Size = New System.Drawing.Size(224, 30)
        Me.ucrSdgPICSARainfalbuttons.TabIndex = 93
        '
        'ucrInputTransform
        '
        Me.ucrInputTransform.AddQuotesIfUnrecognised = True
        Me.ucrInputTransform.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTransform.GetSetSelectedIndex = -1
        Me.ucrInputTransform.IsReadOnly = False
        Me.ucrInputTransform.Location = New System.Drawing.Point(130, 69)
        Me.ucrInputTransform.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputTransform.Name = "ucrInputTransform"
        Me.ucrInputTransform.Size = New System.Drawing.Size(74, 21)
        Me.ucrInputTransform.TabIndex = 91
        '
        'sdgClimaticDataEntryOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(304, 247)
        Me.Controls.Add(Me.ucrChkIncludeFirstNextMonth)
        Me.Controls.Add(Me.ucrChkEditNAOnly)
        Me.Controls.Add(Me.lblDefault)
        Me.Controls.Add(Me.ucrInputDefaultValue)
        Me.Controls.Add(Me.lblAfter)
        Me.Controls.Add(Me.lblBefore)
        Me.Controls.Add(Me.ucrChkExtraRows)
        Me.Controls.Add(Me.ucrNudAfter)
        Me.Controls.Add(Me.ucrNudBefore)
        Me.Controls.Add(Me.ucrSdgPICSARainfalbuttons)
        Me.Controls.Add(Me.ucrInputTransform)
        Me.Controls.Add(Me.grpRestrictEntry)
        Me.Controls.Add(Me.ucrChkTransform)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgClimaticDataEntryOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        Me.grpRestrictEntry.ResumeLayout(False)
        Me.grpRestrictEntry.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrInputTransform As ucrInputComboBox
    Friend WithEvents grpRestrictEntry As GroupBox
    Friend WithEvents ucrChkAllowTrace As ucrCheck
    Friend WithEvents ucrChkNoDecimal As ucrCheck
    Friend WithEvents ucrChkTransform As ucrCheck
    Friend WithEvents ucrSdgPICSARainfalbuttons As ucrButtonsSubdialogue
    Friend WithEvents ucrNudBefore As ucrNud
    Friend WithEvents ucrNudAfter As ucrNud
    Friend WithEvents ttDefaultValue As ToolTip
    Friend WithEvents ucrChkExtraRows As ucrCheck
    Friend WithEvents lblBefore As Label
    Friend WithEvents lblAfter As Label
    Friend WithEvents ttucrChkTransform As ToolTip
    Friend WithEvents ucrInputDefaultValue As ucrInputComboBox
    Friend WithEvents lblDefault As Label
    Friend WithEvents ucrChkEditNAOnly As ucrCheck
    Friend WithEvents ucrChkIncludeFirstNextMonth As ucrCheck
End Class
