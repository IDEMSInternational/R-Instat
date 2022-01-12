<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgDoyRange
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
        Me.rdoFromFixed = New System.Windows.Forms.RadioButton()
        Me.rdoFromVariable = New System.Windows.Forms.RadioButton()
        Me.grpFrom = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverFrom = New instat.ucrReceiverSingle()
        Me.ucrDoyFrom = New instat.ucrDayOfYear()
        Me.ucrPnlFrom = New instat.UcrPanel()
        Me.grpTo = New System.Windows.Forms.GroupBox()
        Me.lblToDays = New System.Windows.Forms.Label()
        Me.ucrNudToDiff = New instat.ucrNud()
        Me.lblToPlus = New System.Windows.Forms.Label()
        Me.rdoLength = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverTo = New instat.ucrReceiverSingle()
        Me.ucrDoyTo = New instat.ucrDayOfYear()
        Me.rdoToVariable = New System.Windows.Forms.RadioButton()
        Me.rdoToFixed = New System.Windows.Forms.RadioButton()
        Me.ucrPnlTo = New instat.UcrPanel()
        Me.ucrSelectorDoy = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseSub = New instat.ucrButtonsSubdialogue()
        Me.grpFrom.SuspendLayout()
        Me.grpTo.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoFromFixed
        '
        Me.rdoFromFixed.AutoSize = True
        Me.rdoFromFixed.Location = New System.Drawing.Point(36, 26)
        Me.rdoFromFixed.Name = "rdoFromFixed"
        Me.rdoFromFixed.Size = New System.Drawing.Size(72, 17)
        Me.rdoFromFixed.TabIndex = 1
        Me.rdoFromFixed.TabStop = True
        Me.rdoFromFixed.Text = "Fixed Day"
        Me.rdoFromFixed.UseVisualStyleBackColor = True
        '
        'rdoFromVariable
        '
        Me.rdoFromVariable.AutoSize = True
        Me.rdoFromVariable.Location = New System.Drawing.Point(120, 26)
        Me.rdoFromVariable.Name = "rdoFromVariable"
        Me.rdoFromVariable.Size = New System.Drawing.Size(85, 17)
        Me.rdoFromVariable.TabIndex = 2
        Me.rdoFromVariable.TabStop = True
        Me.rdoFromVariable.Text = "Variable Day"
        Me.rdoFromVariable.UseVisualStyleBackColor = True
        '
        'grpFrom
        '
        Me.grpFrom.Controls.Add(Me.ucrReceiverFrom)
        Me.grpFrom.Controls.Add(Me.ucrDoyFrom)
        Me.grpFrom.Controls.Add(Me.rdoFromVariable)
        Me.grpFrom.Controls.Add(Me.rdoFromFixed)
        Me.grpFrom.Controls.Add(Me.ucrPnlFrom)
        Me.grpFrom.Location = New System.Drawing.Point(10, 206)
        Me.grpFrom.Name = "grpFrom"
        Me.grpFrom.Size = New System.Drawing.Size(254, 103)
        Me.grpFrom.TabIndex = 1
        Me.grpFrom.TabStop = False
        Me.grpFrom.Text = "From"
        '
        'ucrReceiverFrom
        '
        Me.ucrReceiverFrom.AutoSize = True
        Me.ucrReceiverFrom.frmParent = Me
        Me.ucrReceiverFrom.Location = New System.Drawing.Point(36, 68)
        Me.ucrReceiverFrom.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFrom.Name = "ucrReceiverFrom"
        Me.ucrReceiverFrom.Selector = Nothing
        Me.ucrReceiverFrom.Size = New System.Drawing.Size(124, 20)
        Me.ucrReceiverFrom.strNcFilePath = ""
        Me.ucrReceiverFrom.TabIndex = 5
        Me.ucrReceiverFrom.ucrSelector = Nothing
        '
        'ucrDoyFrom
        '
        Me.ucrDoyFrom.AutoSize = True
        Me.ucrDoyFrom.Location = New System.Drawing.Point(36, 67)
        Me.ucrDoyFrom.Name = "ucrDoyFrom"
        Me.ucrDoyFrom.Size = New System.Drawing.Size(209, 24)
        Me.ucrDoyFrom.TabIndex = 5
        '
        'ucrPnlFrom
        '
        Me.ucrPnlFrom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlFrom.Location = New System.Drawing.Point(28, 17)
        Me.ucrPnlFrom.Name = "ucrPnlFrom"
        Me.ucrPnlFrom.Size = New System.Drawing.Size(186, 36)
        Me.ucrPnlFrom.TabIndex = 3
        '
        'grpTo
        '
        Me.grpTo.Controls.Add(Me.lblToDays)
        Me.grpTo.Controls.Add(Me.ucrNudToDiff)
        Me.grpTo.Controls.Add(Me.lblToPlus)
        Me.grpTo.Controls.Add(Me.rdoLength)
        Me.grpTo.Controls.Add(Me.ucrReceiverTo)
        Me.grpTo.Controls.Add(Me.ucrDoyTo)
        Me.grpTo.Controls.Add(Me.rdoToVariable)
        Me.grpTo.Controls.Add(Me.rdoToFixed)
        Me.grpTo.Controls.Add(Me.ucrPnlTo)
        Me.grpTo.Location = New System.Drawing.Point(269, 206)
        Me.grpTo.Name = "grpTo"
        Me.grpTo.Size = New System.Drawing.Size(314, 103)
        Me.grpTo.TabIndex = 2
        Me.grpTo.TabStop = False
        Me.grpTo.Text = "To"
        '
        'lblToDays
        '
        Me.lblToDays.AutoSize = True
        Me.lblToDays.BackColor = System.Drawing.Color.Transparent
        Me.lblToDays.Location = New System.Drawing.Point(102, 72)
        Me.lblToDays.Name = "lblToDays"
        Me.lblToDays.Size = New System.Drawing.Size(29, 13)
        Me.lblToDays.TabIndex = 9
        Me.lblToDays.Text = "days"
        '
        'ucrNudToDiff
        '
        Me.ucrNudToDiff.AutoSize = True
        Me.ucrNudToDiff.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudToDiff.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudToDiff.Location = New System.Drawing.Point(50, 68)
        Me.ucrNudToDiff.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudToDiff.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudToDiff.Name = "ucrNudToDiff"
        Me.ucrNudToDiff.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudToDiff.TabIndex = 7
        Me.ucrNudToDiff.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblToPlus
        '
        Me.lblToPlus.AutoSize = True
        Me.lblToPlus.BackColor = System.Drawing.Color.Transparent
        Me.lblToPlus.Location = New System.Drawing.Point(16, 72)
        Me.lblToPlus.Name = "lblToPlus"
        Me.lblToPlus.Size = New System.Drawing.Size(30, 13)
        Me.lblToPlus.TabIndex = 8
        Me.lblToPlus.Text = "Plus:"
        '
        'rdoLength
        '
        Me.rdoLength.AutoSize = True
        Me.rdoLength.Location = New System.Drawing.Point(189, 28)
        Me.rdoLength.Name = "rdoLength"
        Me.rdoLength.Size = New System.Drawing.Size(58, 17)
        Me.rdoLength.TabIndex = 6
        Me.rdoLength.TabStop = True
        Me.rdoLength.Text = "Length"
        Me.rdoLength.UseVisualStyleBackColor = True
        '
        'ucrReceiverTo
        '
        Me.ucrReceiverTo.AutoSize = True
        Me.ucrReceiverTo.frmParent = Me
        Me.ucrReceiverTo.Location = New System.Drawing.Point(14, 67)
        Me.ucrReceiverTo.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTo.Name = "ucrReceiverTo"
        Me.ucrReceiverTo.Selector = Nothing
        Me.ucrReceiverTo.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTo.strNcFilePath = ""
        Me.ucrReceiverTo.TabIndex = 5
        Me.ucrReceiverTo.ucrSelector = Nothing
        '
        'ucrDoyTo
        '
        Me.ucrDoyTo.AutoSize = True
        Me.ucrDoyTo.Location = New System.Drawing.Point(16, 67)
        Me.ucrDoyTo.Name = "ucrDoyTo"
        Me.ucrDoyTo.Size = New System.Drawing.Size(209, 24)
        Me.ucrDoyTo.TabIndex = 5
        '
        'rdoToVariable
        '
        Me.rdoToVariable.AutoSize = True
        Me.rdoToVariable.Location = New System.Drawing.Point(98, 28)
        Me.rdoToVariable.Name = "rdoToVariable"
        Me.rdoToVariable.Size = New System.Drawing.Size(85, 17)
        Me.rdoToVariable.TabIndex = 2
        Me.rdoToVariable.TabStop = True
        Me.rdoToVariable.Text = "Variable Day"
        Me.rdoToVariable.UseVisualStyleBackColor = True
        '
        'rdoToFixed
        '
        Me.rdoToFixed.AutoSize = True
        Me.rdoToFixed.Location = New System.Drawing.Point(16, 28)
        Me.rdoToFixed.Name = "rdoToFixed"
        Me.rdoToFixed.Size = New System.Drawing.Size(72, 17)
        Me.rdoToFixed.TabIndex = 1
        Me.rdoToFixed.TabStop = True
        Me.rdoToFixed.Text = "Fixed Day"
        Me.rdoToFixed.UseVisualStyleBackColor = True
        '
        'ucrPnlTo
        '
        Me.ucrPnlTo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlTo.Location = New System.Drawing.Point(6, 17)
        Me.ucrPnlTo.Name = "ucrPnlTo"
        Me.ucrPnlTo.Size = New System.Drawing.Size(295, 36)
        Me.ucrPnlTo.TabIndex = 3
        '
        'ucrSelectorDoy
        '
        Me.ucrSelectorDoy.AutoSize = True
        Me.ucrSelectorDoy.bDropUnusedFilterLevels = False
        Me.ucrSelectorDoy.bShowHiddenColumns = False
        Me.ucrSelectorDoy.bUseCurrentFilter = True
        Me.ucrSelectorDoy.Location = New System.Drawing.Point(10, 9)
        Me.ucrSelectorDoy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDoy.Name = "ucrSelectorDoy"
        Me.ucrSelectorDoy.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorDoy.TabIndex = 0
        '
        'ucrBaseSub
        '
        Me.ucrBaseSub.AutoSize = True
        Me.ucrBaseSub.Location = New System.Drawing.Point(213, 324)
        Me.ucrBaseSub.Name = "ucrBaseSub"
        Me.ucrBaseSub.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseSub.TabIndex = 3
        '
        'sdgDoyRange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(587, 357)
        Me.Controls.Add(Me.grpTo)
        Me.Controls.Add(Me.ucrSelectorDoy)
        Me.Controls.Add(Me.grpFrom)
        Me.Controls.Add(Me.ucrBaseSub)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDoyRange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Day of Year Range"
        Me.grpFrom.ResumeLayout(False)
        Me.grpFrom.PerformLayout()
        Me.grpTo.ResumeLayout(False)
        Me.grpTo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSub As ucrButtonsSubdialogue
    Friend WithEvents rdoFromFixed As RadioButton
    Friend WithEvents rdoFromVariable As RadioButton
    Friend WithEvents ucrPnlFrom As UcrPanel
    Friend WithEvents grpFrom As GroupBox
    Friend WithEvents ucrReceiverFrom As ucrReceiverSingle
    Friend WithEvents grpTo As GroupBox
    Friend WithEvents ucrNudToDiff As ucrNud
    Friend WithEvents lblToPlus As Label
    Friend WithEvents rdoLength As RadioButton
    Friend WithEvents ucrReceiverTo As ucrReceiverSingle
    Friend WithEvents ucrDoyTo As ucrDayOfYear
    Friend WithEvents rdoToVariable As RadioButton
    Friend WithEvents rdoToFixed As RadioButton
    Friend WithEvents ucrPnlTo As UcrPanel
    Friend WithEvents ucrSelectorDoy As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrDoyFrom As ucrDayOfYear
    Friend WithEvents lblToDays As Label
End Class
