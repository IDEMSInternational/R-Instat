<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrAxes
    Inherits instat.ucrCore

    'UserControl overrides dispose to clean up the component list.
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
        Me.grpAxisTitle = New System.Windows.Forms.GroupBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.rdoSpecifyTitle = New System.Windows.Forms.RadioButton()
        Me.rdoNoTitle = New System.Windows.Forms.RadioButton()
        Me.rdoTitleAuto = New System.Windows.Forms.RadioButton()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrPnlAxisTitle = New instat.UcrPanel()
        Me.grpTickMarkers = New System.Windows.Forms.GroupBox()
        Me.ucrNudInStepsOf = New instat.ucrNud()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrNudTickMarkersNoOfDecimalPlaces = New instat.ucrNud()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.ucrTickMarkers = New instat.ucrInputComboBox()
        Me.lblTickMarkersNoOfDecimalPlaces = New System.Windows.Forms.Label()
        Me.rdoTickMarkersAuto = New System.Windows.Forms.RadioButton()
        Me.ucrSpecificValues = New instat.ucrInputTextBox()
        Me.rdoTickMarkersCustom = New System.Windows.Forms.RadioButton()
        Me.lblInStepsOf = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.ucrPnlTickmarkers = New instat.UcrPanel()
        Me.grpScales = New System.Windows.Forms.GroupBox()
        Me.ucrInputUpperLimit = New instat.ucrInputTextBox()
        Me.ucrInputLowerLimit = New instat.ucrInputTextBox()
        Me.lblUpperLimit = New System.Windows.Forms.Label()
        Me.lblLowerLimit = New System.Windows.Forms.Label()
        Me.rdoScalesCustom = New System.Windows.Forms.RadioButton()
        Me.rdoScalesAuto = New System.Windows.Forms.RadioButton()
        Me.ucrPnlScales = New instat.UcrPanel()
        Me.grpAxisTitle.SuspendLayout()
        Me.grpTickMarkers.SuspendLayout()
        Me.grpScales.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAxisTitle
        '
        Me.grpAxisTitle.Controls.Add(Me.lblTitle)
        Me.grpAxisTitle.Controls.Add(Me.rdoSpecifyTitle)
        Me.grpAxisTitle.Controls.Add(Me.rdoNoTitle)
        Me.grpAxisTitle.Controls.Add(Me.rdoTitleAuto)
        Me.grpAxisTitle.Controls.Add(Me.ucrInputTitle)
        Me.grpAxisTitle.Controls.Add(Me.ucrPnlAxisTitle)
        Me.grpAxisTitle.Location = New System.Drawing.Point(3, 18)
        Me.grpAxisTitle.Name = "grpAxisTitle"
        Me.grpAxisTitle.Size = New System.Drawing.Size(251, 109)
        Me.grpAxisTitle.TabIndex = 0
        Me.grpAxisTitle.TabStop = False
        Me.grpAxisTitle.Text = "Axis Title"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(3, 62)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Title"
        '
        'rdoSpecifyTitle
        '
        Me.rdoSpecifyTitle.AutoSize = True
        Me.rdoSpecifyTitle.Location = New System.Drawing.Point(132, 21)
        Me.rdoSpecifyTitle.Name = "rdoSpecifyTitle"
        Me.rdoSpecifyTitle.Size = New System.Drawing.Size(83, 17)
        Me.rdoSpecifyTitle.TabIndex = 3
        Me.rdoSpecifyTitle.TabStop = True
        Me.rdoSpecifyTitle.Text = "Specify Title"
        Me.rdoSpecifyTitle.UseVisualStyleBackColor = True
        '
        'rdoNoTitle
        '
        Me.rdoNoTitle.AutoSize = True
        Me.rdoNoTitle.Location = New System.Drawing.Point(62, 21)
        Me.rdoNoTitle.Name = "rdoNoTitle"
        Me.rdoNoTitle.Size = New System.Drawing.Size(62, 17)
        Me.rdoNoTitle.TabIndex = 3
        Me.rdoNoTitle.TabStop = True
        Me.rdoNoTitle.Text = "No Title"
        Me.rdoNoTitle.UseVisualStyleBackColor = True
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
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        Me.ucrInputTitle.Location = New System.Drawing.Point(62, 62)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(131, 21)
        Me.ucrInputTitle.TabIndex = 1
        '
        'ucrPnlAxisTitle
        '
        Me.ucrPnlAxisTitle.Location = New System.Drawing.Point(4, 18)
        Me.ucrPnlAxisTitle.Name = "ucrPnlAxisTitle"
        Me.ucrPnlAxisTitle.Size = New System.Drawing.Size(209, 23)
        Me.ucrPnlAxisTitle.TabIndex = 19
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
        'ucrPnlTickmarkers
        '
        Me.ucrPnlTickmarkers.Location = New System.Drawing.Point(6, 18)
        Me.ucrPnlTickmarkers.Name = "ucrPnlTickmarkers"
        Me.ucrPnlTickmarkers.Size = New System.Drawing.Size(132, 23)
        Me.ucrPnlTickmarkers.TabIndex = 18
        '
        'grpScales
        '
        Me.grpScales.Controls.Add(Me.ucrInputUpperLimit)
        Me.grpScales.Controls.Add(Me.ucrInputLowerLimit)
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
        'ucrInputUpperLimit
        '
        Me.ucrInputUpperLimit.AddQuotesIfUnrecognised = True
        Me.ucrInputUpperLimit.IsMultiline = False
        Me.ucrInputUpperLimit.IsReadOnly = False
        Me.ucrInputUpperLimit.Location = New System.Drawing.Point(75, 76)
        Me.ucrInputUpperLimit.Name = "ucrInputUpperLimit"
        Me.ucrInputUpperLimit.Size = New System.Drawing.Size(50, 21)
        Me.ucrInputUpperLimit.TabIndex = 22
        '
        'ucrInputLowerLimit
        '
        Me.ucrInputLowerLimit.AddQuotesIfUnrecognised = True
        Me.ucrInputLowerLimit.IsMultiline = False
        Me.ucrInputLowerLimit.IsReadOnly = False
        Me.ucrInputLowerLimit.Location = New System.Drawing.Point(75, 46)
        Me.ucrInputLowerLimit.Name = "ucrInputLowerLimit"
        Me.ucrInputLowerLimit.Size = New System.Drawing.Size(50, 21)
        Me.ucrInputLowerLimit.TabIndex = 22
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
        'ucrPnlScales
        '
        Me.ucrPnlScales.Location = New System.Drawing.Point(0, 17)
        Me.ucrPnlScales.Name = "ucrPnlScales"
        Me.ucrPnlScales.Size = New System.Drawing.Size(132, 23)
        Me.ucrPnlScales.TabIndex = 20
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
    Friend WithEvents ucrInputTitle As ucrInputTextBox
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
    Friend WithEvents lblUpperLimit As Label
    Friend WithEvents lblLowerLimit As Label
    Friend WithEvents rdoNoTitle As RadioButton
    Friend WithEvents rdoTitleAuto As RadioButton
    Friend WithEvents ucrTickMarkers As ucrInputComboBox
    Friend WithEvents ucrNudInStepsOf As ucrNud
    Friend WithEvents ucrNudTo As ucrNud
    Friend WithEvents ucrNudTickMarkersNoOfDecimalPlaces As ucrNud
    Friend WithEvents ucrNudFrom As ucrNud
    Friend WithEvents ucrPnlAxisTitle As UcrPanel
    Friend WithEvents ucrPnlTickmarkers As UcrPanel
    Friend WithEvents ucrPnlScales As UcrPanel
    Friend WithEvents ucrInputUpperLimit As ucrInputTextBox
    Friend WithEvents ucrInputLowerLimit As ucrInputTextBox
    Friend WithEvents rdoSpecifyTitle As RadioButton
    Friend WithEvents lblTitle As Label
End Class
