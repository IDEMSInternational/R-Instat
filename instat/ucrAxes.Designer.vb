<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrAxes
    Inherits instat.ucrCore

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
        Me.grpAxisTitle = New System.Windows.Forms.GroupBox()
        Me.rdoTitleCustom = New System.Windows.Forms.RadioButton()
        Me.rdoTitleAuto = New System.Windows.Forms.RadioButton()
        Me.ucrOverwriteTitle = New instat.ucrInputTextBox()
        Me.grpTickMarkers = New System.Windows.Forms.GroupBox()
        Me.ucrTickMarkers = New instat.ucrInputComboBox()
        Me.lblTickMarkersNoOfDecimalPlaces = New System.Windows.Forms.Label()
        Me.rdoTickMarkersAuto = New System.Windows.Forms.RadioButton()
        Me.ucrSpecificValues = New instat.ucrInputTextBox()
        Me.rdoTickMarkersCustom = New System.Windows.Forms.RadioButton()
        Me.lblInStepsOf = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.grpScales = New System.Windows.Forms.GroupBox()
        Me.lblScalesNoDecimalPlaces = New System.Windows.Forms.Label()
        Me.lblUpperLimit = New System.Windows.Forms.Label()
        Me.lblLowerLimit = New System.Windows.Forms.Label()
        Me.rdoScalesCustom = New System.Windows.Forms.RadioButton()
        Me.rdoScalesAuto = New System.Windows.Forms.RadioButton()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrNudInStepsOf = New instat.ucrNud()
        Me.ucrNudTickMarkersNoOfDecimalPlaces = New instat.ucrNud()
        Me.ucrNudLowerLimit = New instat.ucrNud()
        Me.ucrNudUpperLimit = New instat.ucrNud()
        Me.ucrNudScalesNoOfDecimalPlaces = New instat.ucrNud()
        Me.ucrPnlTickmarkers = New instat.UcrPanel()
        Me.ucrPnlAxisTitle = New instat.UcrPanel()
        Me.ucrPnlScales = New instat.UcrPanel()
        Me.ucrChkDisplayTitle = New instat.ucrCheck()
        Me.ucrChkOverwriteTitle = New instat.ucrCheck()
        Me.grpAxisTitle.SuspendLayout()
        Me.grpTickMarkers.SuspendLayout()
        Me.grpScales.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAxisTitle
        '
        Me.grpAxisTitle.Controls.Add(Me.ucrChkOverwriteTitle)
        Me.grpAxisTitle.Controls.Add(Me.ucrChkDisplayTitle)
        Me.grpAxisTitle.Controls.Add(Me.rdoTitleCustom)
        Me.grpAxisTitle.Controls.Add(Me.rdoTitleAuto)
        Me.grpAxisTitle.Controls.Add(Me.ucrOverwriteTitle)
        Me.grpAxisTitle.Controls.Add(Me.ucrPnlAxisTitle)
        Me.grpAxisTitle.Location = New System.Drawing.Point(3, 18)
        Me.grpAxisTitle.Name = "grpAxisTitle"
        Me.grpAxisTitle.Size = New System.Drawing.Size(251, 109)
        Me.grpAxisTitle.TabIndex = 0
        Me.grpAxisTitle.TabStop = False
        Me.grpAxisTitle.Text = "Axis Title"
        '
        'rdoTitleCustom
        '
        Me.rdoTitleCustom.AutoSize = True
        Me.rdoTitleCustom.Location = New System.Drawing.Point(62, 21)
        Me.rdoTitleCustom.Name = "rdoTitleCustom"
        Me.rdoTitleCustom.Size = New System.Drawing.Size(60, 17)
        Me.rdoTitleCustom.TabIndex = 3
        Me.rdoTitleCustom.TabStop = True
        Me.rdoTitleCustom.Text = "Custom"
        Me.rdoTitleCustom.UseVisualStyleBackColor = True
        '
        'rdoTitleAuto
        '
        Me.rdoTitleAuto.AutoSize = True
        Me.rdoTitleAuto.Location = New System.Drawing.Point(6, 21)
        Me.rdoTitleAuto.Name = "rdoTitleAuto"
        Me.rdoTitleAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoTitleAuto.TabIndex = 2
        Me.rdoTitleAuto.TabStop = True
        Me.rdoTitleAuto.Text = "Auto"
        Me.rdoTitleAuto.UseVisualStyleBackColor = True
        '
        'ucrOverwriteTitle
        '
        Me.ucrOverwriteTitle.AddQuotesIfUnrecognised = True
        Me.ucrOverwriteTitle.IsMultiline = False
        Me.ucrOverwriteTitle.IsReadOnly = False
        Me.ucrOverwriteTitle.Location = New System.Drawing.Point(109, 70)
        Me.ucrOverwriteTitle.Name = "ucrOverwriteTitle"
        Me.ucrOverwriteTitle.Size = New System.Drawing.Size(131, 21)
        Me.ucrOverwriteTitle.TabIndex = 1
        '
        'grpTickMarkers
        '
        Me.grpTickMarkers.Controls.Add(Me.ucrNudInStepsOf)
        Me.grpTickMarkers.Controls.Add(Me.ucrNudTo)
        Me.grpTickMarkers.Controls.Add(Me.ucrNudTickMarkersNoOfDecimalPlaces)
        Me.grpTickMarkers.Controls.Add(Me.ucrNudFrom)
        Me.grpTickMarkers.Controls.Add(Me.ucrTickMarkers)
        Me.grpTickMarkers.Controls.Add(Me.lblTickMarkersNoOfDecimalPlaces)
        Me.grpTickMarkers.Controls.Add(Me.rdoTickMarkersAuto)
        Me.grpTickMarkers.Controls.Add(Me.ucrSpecificValues)
        Me.grpTickMarkers.Controls.Add(Me.rdoTickMarkersCustom)
        Me.grpTickMarkers.Controls.Add(Me.lblInStepsOf)
        Me.grpTickMarkers.Controls.Add(Me.lblFrom)
        Me.grpTickMarkers.Controls.Add(Me.lblTo)
        Me.grpTickMarkers.Controls.Add(Me.ucrPnlTickmarkers)
        Me.grpTickMarkers.Location = New System.Drawing.Point(269, 18)
        Me.grpTickMarkers.Name = "grpTickMarkers"
        Me.grpTickMarkers.Size = New System.Drawing.Size(194, 241)
        Me.grpTickMarkers.TabIndex = 1
        Me.grpTickMarkers.TabStop = False
        Me.grpTickMarkers.Text = "Tick Marks"
        '
        'ucrTickMarkers
        '
        Me.ucrTickMarkers.AddQuotesIfUnrecognised = True
        Me.ucrTickMarkers.IsReadOnly = False
        Me.ucrTickMarkers.Location = New System.Drawing.Point(6, 47)
        Me.ucrTickMarkers.Name = "ucrTickMarkers"
        Me.ucrTickMarkers.Size = New System.Drawing.Size(137, 21)
        Me.ucrTickMarkers.TabIndex = 16
        '
        'lblTickMarkersNoOfDecimalPlaces
        '
        Me.lblTickMarkersNoOfDecimalPlaces.AutoSize = True
        Me.lblTickMarkersNoOfDecimalPlaces.Location = New System.Drawing.Point(3, 102)
        Me.lblTickMarkersNoOfDecimalPlaces.Name = "lblTickMarkersNoOfDecimalPlaces"
        Me.lblTickMarkersNoOfDecimalPlaces.Size = New System.Drawing.Size(135, 13)
        Me.lblTickMarkersNoOfDecimalPlaces.TabIndex = 10
        Me.lblTickMarkersNoOfDecimalPlaces.Text = "Number of Decimal Places:"
        '
        'rdoTickMarkersAuto
        '
        Me.rdoTickMarkersAuto.AutoSize = True
        Me.rdoTickMarkersAuto.Location = New System.Drawing.Point(6, 21)
        Me.rdoTickMarkersAuto.Name = "rdoTickMarkersAuto"
        Me.rdoTickMarkersAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoTickMarkersAuto.TabIndex = 2
        Me.rdoTickMarkersAuto.TabStop = True
        Me.rdoTickMarkersAuto.Text = "Auto"
        Me.rdoTickMarkersAuto.UseVisualStyleBackColor = True
        '
        'ucrSpecificValues
        '
        Me.ucrSpecificValues.AddQuotesIfUnrecognised = True
        Me.ucrSpecificValues.IsMultiline = False
        Me.ucrSpecificValues.IsReadOnly = False
        Me.ucrSpecificValues.Location = New System.Drawing.Point(6, 73)
        Me.ucrSpecificValues.Name = "ucrSpecificValues"
        Me.ucrSpecificValues.Size = New System.Drawing.Size(173, 21)
        Me.ucrSpecificValues.TabIndex = 15
        '
        'rdoTickMarkersCustom
        '
        Me.rdoTickMarkersCustom.AutoSize = True
        Me.rdoTickMarkersCustom.Location = New System.Drawing.Point(61, 21)
        Me.rdoTickMarkersCustom.Name = "rdoTickMarkersCustom"
        Me.rdoTickMarkersCustom.Size = New System.Drawing.Size(60, 17)
        Me.rdoTickMarkersCustom.TabIndex = 3
        Me.rdoTickMarkersCustom.TabStop = True
        Me.rdoTickMarkersCustom.Text = "Custom"
        Me.rdoTickMarkersCustom.UseVisualStyleBackColor = True
        '
        'lblInStepsOf
        '
        Me.lblInStepsOf.AutoSize = True
        Me.lblInStepsOf.Location = New System.Drawing.Point(3, 185)
        Me.lblInStepsOf.Name = "lblInStepsOf"
        Me.lblInStepsOf.Size = New System.Drawing.Size(61, 13)
        Me.lblInStepsOf.TabIndex = 9
        Me.lblInStepsOf.Text = "In Steps of:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(3, 133)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 5
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(3, 159)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 6
        Me.lblTo.Text = "To:"
        '
        'grpScales
        '
        Me.grpScales.Controls.Add(Me.ucrNudScalesNoOfDecimalPlaces)
        Me.grpScales.Controls.Add(Me.ucrNudUpperLimit)
        Me.grpScales.Controls.Add(Me.ucrNudLowerLimit)
        Me.grpScales.Controls.Add(Me.lblScalesNoDecimalPlaces)
        Me.grpScales.Controls.Add(Me.lblUpperLimit)
        Me.grpScales.Controls.Add(Me.lblLowerLimit)
        Me.grpScales.Controls.Add(Me.rdoScalesCustom)
        Me.grpScales.Controls.Add(Me.rdoScalesAuto)
        Me.grpScales.Controls.Add(Me.ucrPnlScales)
        Me.grpScales.Location = New System.Drawing.Point(3, 127)
        Me.grpScales.Name = "grpScales"
        Me.grpScales.Size = New System.Drawing.Size(251, 132)
        Me.grpScales.TabIndex = 2
        Me.grpScales.TabStop = False
        Me.grpScales.Text = "Scales"
        '
        'lblScalesNoDecimalPlaces
        '
        Me.lblScalesNoDecimalPlaces.AutoSize = True
        Me.lblScalesNoDecimalPlaces.Location = New System.Drawing.Point(3, 102)
        Me.lblScalesNoDecimalPlaces.Name = "lblScalesNoDecimalPlaces"
        Me.lblScalesNoDecimalPlaces.Size = New System.Drawing.Size(135, 13)
        Me.lblScalesNoDecimalPlaces.TabIndex = 6
        Me.lblScalesNoDecimalPlaces.Text = "Number of Decimal Places:"
        '
        'lblUpperLimit
        '
        Me.lblUpperLimit.AutoSize = True
        Me.lblUpperLimit.Location = New System.Drawing.Point(3, 75)
        Me.lblUpperLimit.Name = "lblUpperLimit"
        Me.lblUpperLimit.Size = New System.Drawing.Size(66, 13)
        Me.lblUpperLimit.TabIndex = 5
        Me.lblUpperLimit.Text = "Upper Limit :"
        '
        'lblLowerLimit
        '
        Me.lblLowerLimit.AutoSize = True
        Me.lblLowerLimit.Location = New System.Drawing.Point(3, 48)
        Me.lblLowerLimit.Name = "lblLowerLimit"
        Me.lblLowerLimit.Size = New System.Drawing.Size(66, 13)
        Me.lblLowerLimit.TabIndex = 3
        Me.lblLowerLimit.Text = "Lower Limit :"
        '
        'rdoScalesCustom
        '
        Me.rdoScalesCustom.AutoSize = True
        Me.rdoScalesCustom.Location = New System.Drawing.Point(62, 20)
        Me.rdoScalesCustom.Name = "rdoScalesCustom"
        Me.rdoScalesCustom.Size = New System.Drawing.Size(60, 17)
        Me.rdoScalesCustom.TabIndex = 4
        Me.rdoScalesCustom.TabStop = True
        Me.rdoScalesCustom.Text = "Custom"
        Me.rdoScalesCustom.UseVisualStyleBackColor = True
        '
        'rdoScalesAuto
        '
        Me.rdoScalesAuto.AutoSize = True
        Me.rdoScalesAuto.Location = New System.Drawing.Point(6, 20)
        Me.rdoScalesAuto.Name = "rdoScalesAuto"
        Me.rdoScalesAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoScalesAuto.TabIndex = 3
        Me.rdoScalesAuto.TabStop = True
        Me.rdoScalesAuto.Text = "Auto"
        Me.rdoScalesAuto.UseVisualStyleBackColor = True
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Location = New System.Drawing.Point(120, 126)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFrom.TabIndex = 17
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTo
        '
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Location = New System.Drawing.Point(120, 152)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTo.TabIndex = 17
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudInStepsOf
        '
        Me.ucrNudInStepsOf.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudInStepsOf.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudInStepsOf.Location = New System.Drawing.Point(120, 182)
        Me.ucrNudInStepsOf.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudInStepsOf.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudInStepsOf.Name = "ucrNudInStepsOf"
        Me.ucrNudInStepsOf.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudInStepsOf.TabIndex = 17
        Me.ucrNudInStepsOf.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTickMarkersNoOfDecimalPlaces
        '
        Me.ucrNudTickMarkersNoOfDecimalPlaces.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTickMarkersNoOfDecimalPlaces.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTickMarkersNoOfDecimalPlaces.Location = New System.Drawing.Point(138, 100)
        Me.ucrNudTickMarkersNoOfDecimalPlaces.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTickMarkersNoOfDecimalPlaces.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTickMarkersNoOfDecimalPlaces.Name = "ucrNudTickMarkersNoOfDecimalPlaces"
        Me.ucrNudTickMarkersNoOfDecimalPlaces.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTickMarkersNoOfDecimalPlaces.TabIndex = 17
        Me.ucrNudTickMarkersNoOfDecimalPlaces.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLowerLimit
        '
        Me.ucrNudLowerLimit.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLowerLimit.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLowerLimit.Location = New System.Drawing.Point(75, 48)
        Me.ucrNudLowerLimit.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLowerLimit.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLowerLimit.Name = "ucrNudLowerLimit"
        Me.ucrNudLowerLimit.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLowerLimit.TabIndex = 8
        Me.ucrNudLowerLimit.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudUpperLimit
        '
        Me.ucrNudUpperLimit.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperLimit.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudUpperLimit.Location = New System.Drawing.Point(75, 73)
        Me.ucrNudUpperLimit.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudUpperLimit.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperLimit.Name = "ucrNudUpperLimit"
        Me.ucrNudUpperLimit.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudUpperLimit.TabIndex = 8
        Me.ucrNudUpperLimit.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudScalesNoOfDecimalPlaces
        '
        Me.ucrNudScalesNoOfDecimalPlaces.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudScalesNoOfDecimalPlaces.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudScalesNoOfDecimalPlaces.Location = New System.Drawing.Point(144, 102)
        Me.ucrNudScalesNoOfDecimalPlaces.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudScalesNoOfDecimalPlaces.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudScalesNoOfDecimalPlaces.Name = "ucrNudScalesNoOfDecimalPlaces"
        Me.ucrNudScalesNoOfDecimalPlaces.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudScalesNoOfDecimalPlaces.TabIndex = 8
        Me.ucrNudScalesNoOfDecimalPlaces.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlTickmarkers
        '
        Me.ucrPnlTickmarkers.Location = New System.Drawing.Point(6, 18)
        Me.ucrPnlTickmarkers.Name = "ucrPnlTickmarkers"
        Me.ucrPnlTickmarkers.Size = New System.Drawing.Size(132, 23)
        Me.ucrPnlTickmarkers.TabIndex = 18
        '
        'ucrPnlAxisTitle
        '
        Me.ucrPnlAxisTitle.Location = New System.Drawing.Point(6, 18)
        Me.ucrPnlAxisTitle.Name = "ucrPnlAxisTitle"
        Me.ucrPnlAxisTitle.Size = New System.Drawing.Size(132, 23)
        Me.ucrPnlAxisTitle.TabIndex = 19
        '
        'ucrPnlScales
        '
        Me.ucrPnlScales.Location = New System.Drawing.Point(0, 17)
        Me.ucrPnlScales.Name = "ucrPnlScales"
        Me.ucrPnlScales.Size = New System.Drawing.Size(132, 23)
        Me.ucrPnlScales.TabIndex = 20
        '
        'ucrChkDisplayTitle
        '
        Me.ucrChkDisplayTitle.Checked = False
        Me.ucrChkDisplayTitle.Location = New System.Drawing.Point(6, 44)
        Me.ucrChkDisplayTitle.Name = "ucrChkDisplayTitle"
        Me.ucrChkDisplayTitle.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkDisplayTitle.TabIndex = 20
        '
        'ucrChkOverwriteTitle
        '
        Me.ucrChkOverwriteTitle.Checked = False
        Me.ucrChkOverwriteTitle.Location = New System.Drawing.Point(6, 70)
        Me.ucrChkOverwriteTitle.Name = "ucrChkOverwriteTitle"
        Me.ucrChkOverwriteTitle.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkOverwriteTitle.TabIndex = 21
        '
        'ucrAxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpScales)
        Me.Controls.Add(Me.grpTickMarkers)
        Me.Controls.Add(Me.grpAxisTitle)
        Me.Name = "ucrAxes"
        Me.Size = New System.Drawing.Size(470, 269)
        Me.grpAxisTitle.ResumeLayout(False)
        Me.grpAxisTitle.PerformLayout()
        Me.grpTickMarkers.ResumeLayout(False)
        Me.grpTickMarkers.PerformLayout()
        Me.grpScales.ResumeLayout(False)
        Me.grpScales.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpAxisTitle As GroupBox
    Friend WithEvents ucrOverwriteTitle As ucrInputTextBox
    Friend WithEvents grpTickMarkers As GroupBox
    Friend WithEvents lblFrom As Label
    Friend WithEvents rdoTickMarkersCustom As RadioButton
    Friend WithEvents rdoTickMarkersAuto As RadioButton
    Friend WithEvents lblTo As Label
    Friend WithEvents lblTickMarkersNoOfDecimalPlaces As Label
    Friend WithEvents lblInStepsOf As Label
    Friend WithEvents ucrSpecificValues As ucrInputTextBox
    Friend WithEvents grpScales As GroupBox
    Friend WithEvents rdoScalesCustom As RadioButton
    Friend WithEvents rdoScalesAuto As RadioButton
    Friend WithEvents lblScalesNoDecimalPlaces As Label
    Friend WithEvents lblUpperLimit As Label
    Friend WithEvents lblLowerLimit As Label
    Friend WithEvents rdoTitleCustom As RadioButton
    Friend WithEvents rdoTitleAuto As RadioButton
    Friend WithEvents ucrTickMarkers As ucrInputComboBox
    Friend WithEvents ucrNudInStepsOf As ucrNud
    Friend WithEvents ucrNudTo As ucrNud
    Friend WithEvents ucrNudTickMarkersNoOfDecimalPlaces As ucrNud
    Friend WithEvents ucrNudFrom As ucrNud
    Friend WithEvents ucrPnlAxisTitle As UcrPanel
    Friend WithEvents ucrPnlTickmarkers As UcrPanel
    Friend WithEvents ucrNudScalesNoOfDecimalPlaces As ucrNud
    Friend WithEvents ucrNudUpperLimit As ucrNud
    Friend WithEvents ucrNudLowerLimit As ucrNud
    Friend WithEvents ucrPnlScales As UcrPanel
    Friend WithEvents ucrChkDisplayTitle As ucrCheck
    Friend WithEvents ucrChkOverwriteTitle As ucrCheck
End Class
