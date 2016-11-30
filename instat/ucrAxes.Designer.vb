<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrAxes
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
        Me.grpAxisTitle = New System.Windows.Forms.GroupBox()
        Me.rdoTitleCustom = New System.Windows.Forms.RadioButton()
        Me.rdoTitleAuto = New System.Windows.Forms.RadioButton()
        Me.chkOverwriteTitle = New System.Windows.Forms.CheckBox()
        Me.chkDisplayTitle = New System.Windows.Forms.CheckBox()
        Me.grpTickMarkers = New System.Windows.Forms.GroupBox()
        Me.lblTickMarkersNoOfDecimalPlaces = New System.Windows.Forms.Label()
        Me.nudTickMarkersNoOfDecimalPlaces = New System.Windows.Forms.NumericUpDown()
        Me.rdoTickMarkersAuto = New System.Windows.Forms.RadioButton()
        Me.rdoTickMarkersCustom = New System.Windows.Forms.RadioButton()
        Me.nudInStepsOf = New System.Windows.Forms.NumericUpDown()
        Me.lblInStepsOf = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.nudFrom = New System.Windows.Forms.NumericUpDown()
        Me.nudTo = New System.Windows.Forms.NumericUpDown()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.grpScales = New System.Windows.Forms.GroupBox()
        Me.nudScalesNoOfDecimalPlaces = New System.Windows.Forms.NumericUpDown()
        Me.lblScalesNoDecimalPlaces = New System.Windows.Forms.Label()
        Me.nudUpperLimit = New System.Windows.Forms.NumericUpDown()
        Me.nudLowerLimit = New System.Windows.Forms.NumericUpDown()
        Me.lblUpperLimit = New System.Windows.Forms.Label()
        Me.lblLowerLimit = New System.Windows.Forms.Label()
        Me.rdoScalesCustom = New System.Windows.Forms.RadioButton()
        Me.rdoScalesAuto = New System.Windows.Forms.RadioButton()
        Me.ucrTickMarkers = New instat.ucrInputComboBox()
        Me.ucrSpecificValues = New instat.ucrInputTextBox()
        Me.ucrOverwriteTitle = New instat.ucrInputTextBox()
        Me.grpAxisTitle.SuspendLayout()
        Me.grpTickMarkers.SuspendLayout()
        CType(Me.nudTickMarkersNoOfDecimalPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudInStepsOf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpScales.SuspendLayout()
        CType(Me.nudScalesNoOfDecimalPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudUpperLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLowerLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpAxisTitle
        '
        Me.grpAxisTitle.Controls.Add(Me.rdoTitleCustom)
        Me.grpAxisTitle.Controls.Add(Me.rdoTitleAuto)
        Me.grpAxisTitle.Controls.Add(Me.ucrOverwriteTitle)
        Me.grpAxisTitle.Controls.Add(Me.chkOverwriteTitle)
        Me.grpAxisTitle.Controls.Add(Me.chkDisplayTitle)
        Me.grpAxisTitle.Location = New System.Drawing.Point(3, 18)
        Me.grpAxisTitle.Name = "grpAxisTitle"
        Me.grpAxisTitle.Size = New System.Drawing.Size(251, 116)
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
        'chkOverwriteTitle
        '
        Me.chkOverwriteTitle.AutoSize = True
        Me.chkOverwriteTitle.Location = New System.Drawing.Point(6, 80)
        Me.chkOverwriteTitle.Name = "chkOverwriteTitle"
        Me.chkOverwriteTitle.Size = New System.Drawing.Size(94, 17)
        Me.chkOverwriteTitle.TabIndex = 1
        Me.chkOverwriteTitle.Text = "Overwrite Title"
        Me.chkOverwriteTitle.UseVisualStyleBackColor = True
        '
        'chkDisplayTitle
        '
        Me.chkDisplayTitle.AutoSize = True
        Me.chkDisplayTitle.Location = New System.Drawing.Point(6, 51)
        Me.chkDisplayTitle.Name = "chkDisplayTitle"
        Me.chkDisplayTitle.Size = New System.Drawing.Size(60, 17)
        Me.chkDisplayTitle.TabIndex = 1
        Me.chkDisplayTitle.Text = "Display"
        Me.chkDisplayTitle.UseVisualStyleBackColor = True
        '
        'grpTickMarkers
        '
        Me.grpTickMarkers.Controls.Add(Me.ucrTickMarkers)
        Me.grpTickMarkers.Controls.Add(Me.lblTickMarkersNoOfDecimalPlaces)
        Me.grpTickMarkers.Controls.Add(Me.nudTickMarkersNoOfDecimalPlaces)
        Me.grpTickMarkers.Controls.Add(Me.rdoTickMarkersAuto)
        Me.grpTickMarkers.Controls.Add(Me.ucrSpecificValues)
        Me.grpTickMarkers.Controls.Add(Me.rdoTickMarkersCustom)
        Me.grpTickMarkers.Controls.Add(Me.nudInStepsOf)
        Me.grpTickMarkers.Controls.Add(Me.lblInStepsOf)
        Me.grpTickMarkers.Controls.Add(Me.lblFrom)
        Me.grpTickMarkers.Controls.Add(Me.nudFrom)
        Me.grpTickMarkers.Controls.Add(Me.nudTo)
        Me.grpTickMarkers.Controls.Add(Me.lblTo)
        Me.grpTickMarkers.Location = New System.Drawing.Point(269, 18)
        Me.grpTickMarkers.Name = "grpTickMarkers"
        Me.grpTickMarkers.Size = New System.Drawing.Size(194, 254)
        Me.grpTickMarkers.TabIndex = 1
        Me.grpTickMarkers.TabStop = False
        Me.grpTickMarkers.Text = "Tick Marks"
        '
        'lblTickMarkersNoOfDecimalPlaces
        '
        Me.lblTickMarkersNoOfDecimalPlaces.AutoSize = True
        Me.lblTickMarkersNoOfDecimalPlaces.Location = New System.Drawing.Point(3, 118)
        Me.lblTickMarkersNoOfDecimalPlaces.Name = "lblTickMarkersNoOfDecimalPlaces"
        Me.lblTickMarkersNoOfDecimalPlaces.Size = New System.Drawing.Size(135, 13)
        Me.lblTickMarkersNoOfDecimalPlaces.TabIndex = 10
        Me.lblTickMarkersNoOfDecimalPlaces.Text = "Number of Decimal Places:"
        '
        'nudTickMarkersNoOfDecimalPlaces
        '
        Me.nudTickMarkersNoOfDecimalPlaces.Location = New System.Drawing.Point(141, 115)
        Me.nudTickMarkersNoOfDecimalPlaces.Name = "nudTickMarkersNoOfDecimalPlaces"
        Me.nudTickMarkersNoOfDecimalPlaces.Size = New System.Drawing.Size(38, 20)
        Me.nudTickMarkersNoOfDecimalPlaces.TabIndex = 11
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
        'nudInStepsOf
        '
        Me.nudInStepsOf.Location = New System.Drawing.Point(68, 219)
        Me.nudInStepsOf.Name = "nudInStepsOf"
        Me.nudInStepsOf.Size = New System.Drawing.Size(46, 20)
        Me.nudInStepsOf.TabIndex = 8
        '
        'lblInStepsOf
        '
        Me.lblInStepsOf.AutoSize = True
        Me.lblInStepsOf.Location = New System.Drawing.Point(6, 221)
        Me.lblInStepsOf.Name = "lblInStepsOf"
        Me.lblInStepsOf.Size = New System.Drawing.Size(61, 13)
        Me.lblInStepsOf.TabIndex = 9
        Me.lblInStepsOf.Text = "In Steps of:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(6, 149)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 5
        Me.lblFrom.Text = "From:"
        '
        'nudFrom
        '
        Me.nudFrom.Location = New System.Drawing.Point(68, 146)
        Me.nudFrom.Name = "nudFrom"
        Me.nudFrom.Size = New System.Drawing.Size(46, 20)
        Me.nudFrom.TabIndex = 4
        '
        'nudTo
        '
        Me.nudTo.Location = New System.Drawing.Point(68, 183)
        Me.nudTo.Name = "nudTo"
        Me.nudTo.Size = New System.Drawing.Size(46, 20)
        Me.nudTo.TabIndex = 7
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(6, 186)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 6
        Me.lblTo.Text = "To:"
        '
        'grpScales
        '
        Me.grpScales.Controls.Add(Me.nudScalesNoOfDecimalPlaces)
        Me.grpScales.Controls.Add(Me.lblScalesNoDecimalPlaces)
        Me.grpScales.Controls.Add(Me.nudUpperLimit)
        Me.grpScales.Controls.Add(Me.nudLowerLimit)
        Me.grpScales.Controls.Add(Me.lblUpperLimit)
        Me.grpScales.Controls.Add(Me.lblLowerLimit)
        Me.grpScales.Controls.Add(Me.rdoScalesCustom)
        Me.grpScales.Controls.Add(Me.rdoScalesAuto)
        Me.grpScales.Location = New System.Drawing.Point(3, 147)
        Me.grpScales.Name = "grpScales"
        Me.grpScales.Size = New System.Drawing.Size(251, 145)
        Me.grpScales.TabIndex = 2
        Me.grpScales.TabStop = False
        Me.grpScales.Text = "Scales"
        '
        'nudScalesNoOfDecimalPlaces
        '
        Me.nudScalesNoOfDecimalPlaces.Location = New System.Drawing.Point(140, 118)
        Me.nudScalesNoOfDecimalPlaces.Name = "nudScalesNoOfDecimalPlaces"
        Me.nudScalesNoOfDecimalPlaces.Size = New System.Drawing.Size(39, 20)
        Me.nudScalesNoOfDecimalPlaces.TabIndex = 7
        '
        'lblScalesNoDecimalPlaces
        '
        Me.lblScalesNoDecimalPlaces.AutoSize = True
        Me.lblScalesNoDecimalPlaces.Location = New System.Drawing.Point(3, 121)
        Me.lblScalesNoDecimalPlaces.Name = "lblScalesNoDecimalPlaces"
        Me.lblScalesNoDecimalPlaces.Size = New System.Drawing.Size(135, 13)
        Me.lblScalesNoDecimalPlaces.TabIndex = 6
        Me.lblScalesNoDecimalPlaces.Text = "Number of Decimal Places:"
        '
        'nudUpperLimit
        '
        Me.nudUpperLimit.Location = New System.Drawing.Point(69, 85)
        Me.nudUpperLimit.Name = "nudUpperLimit"
        Me.nudUpperLimit.Size = New System.Drawing.Size(46, 20)
        Me.nudUpperLimit.TabIndex = 3
        '
        'nudLowerLimit
        '
        Me.nudLowerLimit.Location = New System.Drawing.Point(69, 52)
        Me.nudLowerLimit.Name = "nudLowerLimit"
        Me.nudLowerLimit.Size = New System.Drawing.Size(46, 20)
        Me.nudLowerLimit.TabIndex = 3
        '
        'lblUpperLimit
        '
        Me.lblUpperLimit.AutoSize = True
        Me.lblUpperLimit.Location = New System.Drawing.Point(3, 87)
        Me.lblUpperLimit.Name = "lblUpperLimit"
        Me.lblUpperLimit.Size = New System.Drawing.Size(66, 13)
        Me.lblUpperLimit.TabIndex = 5
        Me.lblUpperLimit.Text = "Upper Limit :"
        '
        'lblLowerLimit
        '
        Me.lblLowerLimit.AutoSize = True
        Me.lblLowerLimit.Location = New System.Drawing.Point(3, 54)
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
        'ucrTickMarkers
        '
        Me.ucrTickMarkers.IsReadOnly = False
        Me.ucrTickMarkers.Location = New System.Drawing.Point(6, 51)
        Me.ucrTickMarkers.Name = "ucrTickMarkers"
        Me.ucrTickMarkers.Size = New System.Drawing.Size(137, 21)
        Me.ucrTickMarkers.TabIndex = 16
        '
        'ucrSpecificValues
        '
        Me.ucrSpecificValues.IsReadOnly = False
        Me.ucrSpecificValues.Location = New System.Drawing.Point(6, 78)
        Me.ucrSpecificValues.Name = "ucrSpecificValues"
        Me.ucrSpecificValues.Size = New System.Drawing.Size(173, 21)
        Me.ucrSpecificValues.TabIndex = 15
        '
        'ucrOverwriteTitle
        '
        Me.ucrOverwriteTitle.IsReadOnly = False
        Me.ucrOverwriteTitle.Location = New System.Drawing.Point(106, 78)
        Me.ucrOverwriteTitle.Name = "ucrOverwriteTitle"
        Me.ucrOverwriteTitle.Size = New System.Drawing.Size(131, 21)
        Me.ucrOverwriteTitle.TabIndex = 1
        '
        'ucrAxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpScales)
        Me.Controls.Add(Me.grpTickMarkers)
        Me.Controls.Add(Me.grpAxisTitle)
        Me.Name = "ucrAxes"
        Me.Size = New System.Drawing.Size(470, 300)
        Me.grpAxisTitle.ResumeLayout(False)
        Me.grpAxisTitle.PerformLayout()
        Me.grpTickMarkers.ResumeLayout(False)
        Me.grpTickMarkers.PerformLayout()
        CType(Me.nudTickMarkersNoOfDecimalPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudInStepsOf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpScales.ResumeLayout(False)
        Me.grpScales.PerformLayout()
        CType(Me.nudScalesNoOfDecimalPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudUpperLimit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLowerLimit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpAxisTitle As GroupBox
    Friend WithEvents chkDisplayTitle As CheckBox
    Friend WithEvents chkOverwriteTitle As CheckBox
    Friend WithEvents ucrOverwriteTitle As ucrInputTextBox
    Friend WithEvents grpTickMarkers As GroupBox
    Friend WithEvents lblFrom As Label
    Friend WithEvents nudFrom As NumericUpDown
    Friend WithEvents rdoTickMarkersCustom As RadioButton
    Friend WithEvents rdoTickMarkersAuto As RadioButton
    Friend WithEvents nudTo As NumericUpDown
    Friend WithEvents lblTo As Label
    Friend WithEvents nudTickMarkersNoOfDecimalPlaces As NumericUpDown
    Friend WithEvents lblTickMarkersNoOfDecimalPlaces As Label
    Friend WithEvents lblInStepsOf As Label
    Friend WithEvents nudInStepsOf As NumericUpDown
    Friend WithEvents ucrSpecificValues As ucrInputTextBox
    Friend WithEvents grpScales As GroupBox
    Friend WithEvents rdoScalesCustom As RadioButton
    Friend WithEvents rdoScalesAuto As RadioButton
    Friend WithEvents lblScalesNoDecimalPlaces As Label
    Friend WithEvents nudUpperLimit As NumericUpDown
    Friend WithEvents nudLowerLimit As NumericUpDown
    Friend WithEvents lblUpperLimit As Label
    Friend WithEvents lblLowerLimit As Label
    Friend WithEvents nudScalesNoOfDecimalPlaces As NumericUpDown
    Friend WithEvents rdoTitleCustom As RadioButton
    Friend WithEvents rdoTitleAuto As RadioButton
    Friend WithEvents ucrTickMarkers As ucrInputComboBox
End Class
