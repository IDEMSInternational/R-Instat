<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgRecodeNumeric
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
        Me.chkAddLabels = New System.Windows.Forms.CheckBox()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.lblBreakPoints = New System.Windows.Forms.Label()
        Me.grpClosedOn = New System.Windows.Forms.GroupBox()
        Me.rdoLeft = New System.Windows.Forms.RadioButton()
        Me.rdoRight = New System.Windows.Forms.RadioButton()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrInputRecode = New instat.ucrInputComboBox()
        Me.ucrReceiverRecode = New instat.ucrReceiverSingle()
        Me.ucrSelectorForRecode = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrMultipleLabels = New instat.ucrInputTextBox()
        Me.ucrMultipleNumericRecode = New instat.ucrInputTextBox()
        Me.grpClosedOn.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkAddLabels
        '
        Me.chkAddLabels.AutoSize = True
        Me.chkAddLabels.Location = New System.Drawing.Point(10, 211)
        Me.chkAddLabels.Name = "chkAddLabels"
        Me.chkAddLabels.Size = New System.Drawing.Size(79, 17)
        Me.chkAddLabels.TabIndex = 2
        Me.chkAddLabels.Tag = "Add_Labels"
        Me.chkAddLabels.Text = "Add Labels"
        Me.chkAddLabels.UseVisualStyleBackColor = True
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.Location = New System.Drawing.Point(255, 25)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(90, 13)
        Me.lblSelectedVariable.TabIndex = 17
        Me.lblSelectedVariable.Tag = "Selected_Variable"
        Me.lblSelectedVariable.Text = "Selected Variable"
        '
        'lblBreakPoints
        '
        Me.lblBreakPoints.AutoSize = True
        Me.lblBreakPoints.Location = New System.Drawing.Point(255, 76)
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
        Me.grpClosedOn.Location = New System.Drawing.Point(255, 126)
        Me.grpClosedOn.Name = "grpClosedOn"
        Me.grpClosedOn.Size = New System.Drawing.Size(115, 74)
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
        Me.rdoRight.Location = New System.Drawing.Point(7, 44)
        Me.rdoRight.Name = "rdoRight"
        Me.rdoRight.Size = New System.Drawing.Size(50, 17)
        Me.rdoRight.TabIndex = 0
        Me.rdoRight.Tag = "Right"
        Me.rdoRight.Text = "Right"
        Me.rdoRight.UseVisualStyleBackColor = True
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(10, 242)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(98, 13)
        Me.lblNewColumnName.TabIndex = 26
        Me.lblNewColumnName.Tag = "New_Column_Name"
        Me.lblNewColumnName.Text = "New Column Name"
        '
        'ucrInputRecode
        '
        Me.ucrInputRecode.IsReadOnly = False
        Me.ucrInputRecode.Location = New System.Drawing.Point(114, 234)
        Me.ucrInputRecode.Name = "ucrInputRecode"
        Me.ucrInputRecode.Size = New System.Drawing.Size(145, 21)
        Me.ucrInputRecode.TabIndex = 27
        '
        'ucrReceiverRecode
        '
        Me.ucrReceiverRecode.Location = New System.Drawing.Point(255, 43)
        Me.ucrReceiverRecode.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRecode.Name = "ucrReceiverRecode"
        Me.ucrReceiverRecode.Selector = Nothing
        Me.ucrReceiverRecode.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRecode.TabIndex = 19
        '
        'ucrSelectorForRecode
        '
        Me.ucrSelectorForRecode.bShowHiddenColumns = False
        Me.ucrSelectorForRecode.bUseCurrentFilter = False
        Me.ucrSelectorForRecode.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForRecode.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForRecode.Name = "ucrSelectorForRecode"
        Me.ucrSelectorForRecode.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForRecode.TabIndex = 18
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 263)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 1
        '
        'ucrMultipleLabels
        '
        Me.ucrMultipleLabels.IsReadOnly = False
        Me.ucrMultipleLabels.Location = New System.Drawing.Point(114, 207)
        Me.ucrMultipleLabels.Name = "ucrMultipleLabels"
        Me.ucrMultipleLabels.Size = New System.Drawing.Size(145, 21)
        Me.ucrMultipleLabels.TabIndex = 28
        '
        'ucrMultipleNumericRecode
        '
        Me.ucrMultipleNumericRecode.IsReadOnly = False
        Me.ucrMultipleNumericRecode.Location = New System.Drawing.Point(255, 92)
        Me.ucrMultipleNumericRecode.Name = "ucrMultipleNumericRecode"
        Me.ucrMultipleNumericRecode.Size = New System.Drawing.Size(120, 21)
        Me.ucrMultipleNumericRecode.TabIndex = 29
        '
        'dlgRecodeNumeric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 316)
        Me.Controls.Add(Me.ucrMultipleNumericRecode)
        Me.Controls.Add(Me.ucrMultipleLabels)
        Me.Controls.Add(Me.ucrInputRecode)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.grpClosedOn)
        Me.Controls.Add(Me.lblBreakPoints)
        Me.Controls.Add(Me.ucrReceiverRecode)
        Me.Controls.Add(Me.ucrSelectorForRecode)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.chkAddLabels)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRecodeNumeric"
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
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrSelectorForRecode As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRecode As ucrReceiverSingle
    Friend WithEvents lblBreakPoints As Label
    Friend WithEvents grpClosedOn As GroupBox
    Friend WithEvents rdoLeft As RadioButton
    Friend WithEvents rdoRight As RadioButton
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents ucrInputRecode As ucrInputComboBox
    Friend WithEvents ucrMultipleLabels As ucrInputTextBox
    Friend WithEvents ucrMultipleNumericRecode As ucrInputTextBox
End Class
