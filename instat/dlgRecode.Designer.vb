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
        Me.ucrSelectorNewColumnName = New instat.ucrNewColumnName()
        Me.ucrReceiverRecode = New instat.ucrReceiverSingle()
        Me.ucrSelectorForRecode = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
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
        Me.grpClosedOn.Location = New System.Drawing.Point(298, 107)
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
        Me.rdoRight.Location = New System.Drawing.Point(6, 55)
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
        'ucrSelectorNewColumnName
        '
        Me.ucrSelectorNewColumnName.Location = New System.Drawing.Point(12, 220)
        Me.ucrSelectorNewColumnName.Name = "ucrSelectorNewColumnName"
        Me.ucrSelectorNewColumnName.Size = New System.Drawing.Size(367, 35)
        Me.ucrSelectorNewColumnName.TabIndex = 23
        Me.ucrSelectorNewColumnName.ucrDataFrameSelector = Nothing
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
        Me.ucrBase.Location = New System.Drawing.Point(12, 261)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 58)
        Me.ucrBase.TabIndex = 1
        '
        'dlgRecode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 324)
        Me.Controls.Add(Me.ucrMultipleLabels)
        Me.Controls.Add(Me.ucrMultipleNumericRecode)
        Me.Controls.Add(Me.ucrSelectorNewColumnName)
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
    Friend WithEvents ucrSelectorNewColumnName As ucrNewColumnName
    Friend WithEvents ucrMultipleNumericRecode As ucrMultipleInput
    Friend WithEvents ucrMultipleLabels As ucrMultipleInput
End Class
