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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgClimaticDataEntryOptions))
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
        resources.ApplyResources(Me.grpRestrictEntry, "grpRestrictEntry")
        Me.grpRestrictEntry.Name = "grpRestrictEntry"
        Me.grpRestrictEntry.TabStop = False
        '
        'ucrChkAllowTrace
        '
        Me.ucrChkAllowTrace.Checked = False
        resources.ApplyResources(Me.ucrChkAllowTrace, "ucrChkAllowTrace")
        Me.ucrChkAllowTrace.Name = "ucrChkAllowTrace"
        '
        'ucrChkNoDecimal
        '
        Me.ucrChkNoDecimal.Checked = False
        resources.ApplyResources(Me.ucrChkNoDecimal, "ucrChkNoDecimal")
        Me.ucrChkNoDecimal.Name = "ucrChkNoDecimal"
        '
        'ttDefaultValue
        '
        Me.ttDefaultValue.AutoPopDelay = 10000
        Me.ttDefaultValue.InitialDelay = 500
        Me.ttDefaultValue.ReshowDelay = 100
        '
        'lblDefault
        '
        resources.ApplyResources(Me.lblDefault, "lblDefault")
        Me.lblDefault.Name = "lblDefault"
        Me.ttDefaultValue.SetToolTip(Me.lblDefault, resources.GetString("lblDefault.ToolTip"))
        '
        'ucrInputDefaultValue
        '
        Me.ucrInputDefaultValue.AddQuotesIfUnrecognised = True
        Me.ucrInputDefaultValue.GetSetSelectedIndex = -1
        Me.ucrInputDefaultValue.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDefaultValue, "ucrInputDefaultValue")
        Me.ucrInputDefaultValue.Name = "ucrInputDefaultValue"
        Me.ttDefaultValue.SetToolTip(Me.ucrInputDefaultValue, resources.GetString("ucrInputDefaultValue.ToolTip"))
        '
        'lblBefore
        '
        resources.ApplyResources(Me.lblBefore, "lblBefore")
        Me.lblBefore.Name = "lblBefore"
        '
        'lblAfter
        '
        resources.ApplyResources(Me.lblAfter, "lblAfter")
        Me.lblAfter.Name = "lblAfter"
        '
        'ttucrChkTransform
        '
        Me.ttucrChkTransform.AutoPopDelay = 10000
        Me.ttucrChkTransform.InitialDelay = 500
        Me.ttucrChkTransform.ReshowDelay = 100
        '
        'ucrChkIncludeFirstNextMonth
        '
        Me.ucrChkIncludeFirstNextMonth.Checked = False
        resources.ApplyResources(Me.ucrChkIncludeFirstNextMonth, "ucrChkIncludeFirstNextMonth")
        Me.ucrChkIncludeFirstNextMonth.Name = "ucrChkIncludeFirstNextMonth"
        Me.ttucrChkTransform.SetToolTip(Me.ucrChkIncludeFirstNextMonth, resources.GetString("ucrChkIncludeFirstNextMonth.ToolTip"))
        '
        'ucrChkEditNAOnly
        '
        Me.ucrChkEditNAOnly.Checked = False
        resources.ApplyResources(Me.ucrChkEditNAOnly, "ucrChkEditNAOnly")
        Me.ucrChkEditNAOnly.Name = "ucrChkEditNAOnly"
        Me.ttucrChkTransform.SetToolTip(Me.ucrChkEditNAOnly, resources.GetString("ucrChkEditNAOnly.ToolTip"))
        '
        'ucrChkTransform
        '
        Me.ucrChkTransform.Checked = False
        resources.ApplyResources(Me.ucrChkTransform, "ucrChkTransform")
        Me.ucrChkTransform.Name = "ucrChkTransform"
        Me.ttucrChkTransform.SetToolTip(Me.ucrChkTransform, resources.GetString("ucrChkTransform.ToolTip"))
        '
        'ucrChkExtraRows
        '
        Me.ucrChkExtraRows.Checked = False
        resources.ApplyResources(Me.ucrChkExtraRows, "ucrChkExtraRows")
        Me.ucrChkExtraRows.Name = "ucrChkExtraRows"
        '
        'ucrNudAfter
        '
        Me.ucrNudAfter.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAfter.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudAfter, "ucrNudAfter")
        Me.ucrNudAfter.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAfter.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAfter.Name = "ucrNudAfter"
        Me.ucrNudAfter.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudBefore
        '
        Me.ucrNudBefore.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBefore.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudBefore, "ucrNudBefore")
        Me.ucrNudBefore.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBefore.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBefore.Name = "ucrNudBefore"
        Me.ucrNudBefore.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSdgPICSARainfalbuttons
        '
        resources.ApplyResources(Me.ucrSdgPICSARainfalbuttons, "ucrSdgPICSARainfalbuttons")
        Me.ucrSdgPICSARainfalbuttons.Name = "ucrSdgPICSARainfalbuttons"
        '
        'ucrInputTransform
        '
        Me.ucrInputTransform.AddQuotesIfUnrecognised = True
        Me.ucrInputTransform.GetSetSelectedIndex = -1
        Me.ucrInputTransform.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTransform, "ucrInputTransform")
        Me.ucrInputTransform.Name = "ucrInputTransform"
        '
        'sdgClimaticDataEntryOptions
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.grpRestrictEntry.ResumeLayout(False)
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
