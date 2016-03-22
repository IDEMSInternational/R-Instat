<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRecode
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
        Me.chkAddLabels = New System.Windows.Forms.CheckBox()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.lblBreakPoints = New System.Windows.Forms.Label()
        Me.grpClosedOn = New System.Windows.Forms.GroupBox()
        Me.rdoLeft = New System.Windows.Forms.RadioButton()
        Me.rdoRight = New System.Windows.Forms.RadioButton()
        Me.ucrMultipleLabels = New instat.ucrMultipleInput()
        Me.ucrMultipleNumericRecode = New instat.ucrMultipleInput()
        Me.ucrReceiverRecode = New instat.ucrReceiverSingle()
        Me.ucrSelectorForRecode = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrInputRecode = New instat.ucrInputComboBox()
        Me.ucrFactorRecode = New instat.ucrFactor()
        Me.grpClosedOn.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkAddLabels
        '
        Me.chkAddLabels.AutoSize = True
        Me.chkAddLabels.Location = New System.Drawing.Point(12, 197)
        Me.chkAddLabels.Name = "chkAddLabels"
        Me.chkAddLabels.Size = New System.Drawing.Size(79, 17)
        Me.chkAddLabels.TabIndex = 2
        Me.chkAddLabels.Tag = "Add_Labels"
        Me.chkAddLabels.Text = "Add Labels"
        Me.chkAddLabels.UseVisualStyleBackColor = True
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(295, 12)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(95, 13)
        Me.lblSelectedVariables.TabIndex = 17
        Me.lblSelectedVariables.Text = "Selected Variables"
        '
        'lblBreakPoints
        '
        Me.lblBreakPoints.AutoSize = True
        Me.lblBreakPoints.Location = New System.Drawing.Point(298, 62)
        Me.lblBreakPoints.Name = "lblBreakPoints"
        Me.lblBreakPoints.Size = New System.Drawing.Size(70, 13)
        Me.lblBreakPoints.TabIndex = 20
        Me.lblBreakPoints.Tag = "Break_Points"
        Me.lblBreakPoints.Text = "Break Points:"
        '
        'grpClosedOn
        '
        Me.grpClosedOn.Controls.Add(Me.rdoLeft)
        Me.grpClosedOn.Controls.Add(Me.rdoRight)
        Me.grpClosedOn.Location = New System.Drawing.Point(448, 12)
        Me.grpClosedOn.Name = "grpClosedOn"
        Me.grpClosedOn.Size = New System.Drawing.Size(106, 84)
        Me.grpClosedOn.TabIndex = 22
        Me.grpClosedOn.TabStop = False
        Me.grpClosedOn.Tag = "Closed_on"
        Me.grpClosedOn.Text = "Closed on"
        '
        'rdoLeft
        '
        Me.rdoLeft.AutoSize = True
        Me.rdoLeft.Location = New System.Drawing.Point(7, 20)
        Me.rdoLeft.Name = "rdoLeft"
        Me.rdoLeft.Size = New System.Drawing.Size(43, 17)
        Me.rdoLeft.TabIndex = 1
        Me.rdoLeft.Tag = "Left"
        Me.rdoLeft.Text = "Left"
        Me.rdoLeft.UseVisualStyleBackColor = True
        '
        'rdoRight
        '
        Me.rdoRight.AutoSize = True
        Me.rdoRight.Location = New System.Drawing.Point(7, 43)
        Me.rdoRight.Name = "rdoRight"
        Me.rdoRight.Size = New System.Drawing.Size(50, 17)
        Me.rdoRight.TabIndex = 0
        Me.rdoRight.Tag = "Right"
        Me.rdoRight.Text = "Right"
        Me.rdoRight.UseVisualStyleBackColor = True
        '
        'ucrMultipleLabels
        '
        Me.ucrMultipleLabels.Location = New System.Drawing.Point(115, 192)
        Me.ucrMultipleLabels.Name = "ucrMultipleLabels"
        Me.ucrMultipleLabels.Size = New System.Drawing.Size(150, 29)
        Me.ucrMultipleLabels.TabIndex = 25
        '
        'ucrMultipleNumericRecode
        '
        Me.ucrMultipleNumericRecode.Location = New System.Drawing.Point(298, 78)
        Me.ucrMultipleNumericRecode.Name = "ucrMultipleNumericRecode"
        Me.ucrMultipleNumericRecode.Size = New System.Drawing.Size(106, 29)
        Me.ucrMultipleNumericRecode.TabIndex = 24
        '
        'ucrReceiverRecode
        '
        Me.ucrReceiverRecode.Location = New System.Drawing.Point(298, 29)
        Me.ucrReceiverRecode.Name = "ucrReceiverRecode"
        Me.ucrReceiverRecode.Selector = Nothing
        Me.ucrReceiverRecode.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverRecode.TabIndex = 19
        '
        'ucrSelectorForRecode
        '
        Me.ucrSelectorForRecode.Location = New System.Drawing.Point(12, 12)
        Me.ucrSelectorForRecode.Name = "ucrSelectorForRecode"
        Me.ucrSelectorForRecode.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorForRecode.TabIndex = 18
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 289)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 58)
        Me.ucrBase.TabIndex = 1
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(9, 270)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(98, 13)
        Me.lblNewColumnName.TabIndex = 26
        Me.lblNewColumnName.Tag = "New_Column_Name"
        Me.lblNewColumnName.Text = "New Column Name"
        '
        'ucrInputRecode
        '
        Me.ucrInputRecode.Location = New System.Drawing.Point(212, 258)
        Me.ucrInputRecode.Name = "ucrInputRecode"
        Me.ucrInputRecode.Size = New System.Drawing.Size(137, 25)
        Me.ucrInputRecode.TabIndex = 27
        '
        'ucrFactorRecode
        '
        Me.ucrFactorRecode.AutoSize = True
        Me.ucrFactorRecode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrFactorRecode.clsReceiver = Nothing
        Me.ucrFactorRecode.Location = New System.Drawing.Point(355, 102)
        Me.ucrFactorRecode.Name = "ucrFactorRecode"
        Me.ucrFactorRecode.shtCurrSheet = Nothing
        Me.ucrFactorRecode.Size = New System.Drawing.Size(267, 181)
        Me.ucrFactorRecode.TabIndex = 28
        '
        'dlgRecode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 359)
        Me.Controls.Add(Me.ucrFactorRecode)
        Me.Controls.Add(Me.ucrInputRecode)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrMultipleLabels)
        Me.Controls.Add(Me.ucrMultipleNumericRecode)
        Me.Controls.Add(Me.grpClosedOn)
        Me.Controls.Add(Me.lblBreakPoints)
        Me.Controls.Add(Me.ucrReceiverRecode)
        Me.Controls.Add(Me.ucrSelectorForRecode)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.chkAddLabels)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgRecode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Recode"
        Me.Text = "Recode"
        Me.grpClosedOn.ResumeLayout(False)
        Me.grpClosedOn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkAddLabels As CheckBox
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents ucrSelectorForRecode As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRecode As ucrReceiverSingle
    Friend WithEvents lblBreakPoints As Label
    Friend WithEvents grpClosedOn As GroupBox
    Friend WithEvents rdoLeft As RadioButton
    Friend WithEvents rdoRight As RadioButton
    Friend WithEvents ucrMultipleNumericRecode As ucrMultipleInput
    Friend WithEvents ucrMultipleLabels As ucrMultipleInput
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents ucrInputRecode As ucrInputComboBox
    Friend WithEvents ucrFactorRecode As ucrFactor
End Class
