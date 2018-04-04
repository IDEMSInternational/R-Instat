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
        Me.ucrBaseSub = New instat.ucrButtonsSubdialogue()
        Me.rdoFromFixed = New System.Windows.Forms.RadioButton()
        Me.rdoFromVariable = New System.Windows.Forms.RadioButton()
        Me.ucrPnlFrom = New instat.UcrPanel()
        Me.grpFrom = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverFrom = New instat.ucrReceiverSingle()
        Me.ucrDoyFrom = New instat.ucrDayOfYear()
        Me.ucrSelectorDoy = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpTo = New System.Windows.Forms.GroupBox()
        Me.ucrNudToDiff = New instat.ucrNud()
        Me.lblToPlus = New System.Windows.Forms.Label()
        Me.rdoToFixedDiff = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverTo = New instat.ucrReceiverSingle()
        Me.ucrDoyTo = New instat.ucrDayOfYear()
        Me.rdoToVariable = New System.Windows.Forms.RadioButton()
        Me.rdoToFixed = New System.Windows.Forms.RadioButton()
        Me.ucrPnlTo = New instat.UcrPanel()
        Me.lblToDays = New System.Windows.Forms.Label()
        Me.grpFrom.SuspendLayout()
        Me.grpTo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBaseSub
        '
        Me.ucrBaseSub.Location = New System.Drawing.Point(236, 357)
        Me.ucrBaseSub.Name = "ucrBaseSub"
        Me.ucrBaseSub.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSub.TabIndex = 0
        '
        'rdoFromFixed
        '
        Me.rdoFromFixed.AutoSize = True
        Me.rdoFromFixed.Location = New System.Drawing.Point(16, 32)
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
        Me.rdoFromVariable.Location = New System.Drawing.Point(100, 32)
        Me.rdoFromVariable.Name = "rdoFromVariable"
        Me.rdoFromVariable.Size = New System.Drawing.Size(85, 17)
        Me.rdoFromVariable.TabIndex = 2
        Me.rdoFromVariable.TabStop = True
        Me.rdoFromVariable.Text = "Variable Day"
        Me.rdoFromVariable.UseVisualStyleBackColor = True
        '
        'ucrPnlFrom
        '
        Me.ucrPnlFrom.Location = New System.Drawing.Point(8, 23)
        Me.ucrPnlFrom.Name = "ucrPnlFrom"
        Me.ucrPnlFrom.Size = New System.Drawing.Size(186, 36)
        Me.ucrPnlFrom.TabIndex = 3
        '
        'grpFrom
        '
        Me.grpFrom.Controls.Add(Me.ucrReceiverFrom)
        Me.grpFrom.Controls.Add(Me.ucrDoyFrom)
        Me.grpFrom.Controls.Add(Me.rdoFromVariable)
        Me.grpFrom.Controls.Add(Me.rdoFromFixed)
        Me.grpFrom.Controls.Add(Me.ucrPnlFrom)
        Me.grpFrom.Location = New System.Drawing.Point(9, 206)
        Me.grpFrom.Name = "grpFrom"
        Me.grpFrom.Size = New System.Drawing.Size(232, 124)
        Me.grpFrom.TabIndex = 4
        Me.grpFrom.TabStop = False
        Me.grpFrom.Text = "From"
        '
        'ucrReceiverFrom
        '
        Me.ucrReceiverFrom.frmParent = Me
        Me.ucrReceiverFrom.Location = New System.Drawing.Point(17, 84)
        Me.ucrReceiverFrom.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFrom.Name = "ucrReceiverFrom"
        Me.ucrReceiverFrom.Selector = Nothing
        Me.ucrReceiverFrom.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFrom.strNcFilePath = ""
        Me.ucrReceiverFrom.TabIndex = 5
        Me.ucrReceiverFrom.ucrSelector = Nothing
        '
        'ucrDoyFrom
        '
        Me.ucrDoyFrom.Location = New System.Drawing.Point(16, 84)
        Me.ucrDoyFrom.Name = "ucrDoyFrom"
        Me.ucrDoyFrom.Size = New System.Drawing.Size(209, 21)
        Me.ucrDoyFrom.TabIndex = 5
        '
        'ucrSelectorDoy
        '
        Me.ucrSelectorDoy.bShowHiddenColumns = False
        Me.ucrSelectorDoy.bUseCurrentFilter = True
        Me.ucrSelectorDoy.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorDoy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDoy.Name = "ucrSelectorDoy"
        Me.ucrSelectorDoy.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDoy.TabIndex = 5
        '
        'grpTo
        '
        Me.grpTo.Controls.Add(Me.lblToDays)
        Me.grpTo.Controls.Add(Me.ucrNudToDiff)
        Me.grpTo.Controls.Add(Me.lblToPlus)
        Me.grpTo.Controls.Add(Me.rdoToFixedDiff)
        Me.grpTo.Controls.Add(Me.ucrReceiverTo)
        Me.grpTo.Controls.Add(Me.ucrDoyTo)
        Me.grpTo.Controls.Add(Me.rdoToVariable)
        Me.grpTo.Controls.Add(Me.rdoToFixed)
        Me.grpTo.Controls.Add(Me.ucrPnlTo)
        Me.grpTo.Location = New System.Drawing.Point(301, 206)
        Me.grpTo.Name = "grpTo"
        Me.grpTo.Size = New System.Drawing.Size(307, 124)
        Me.grpTo.TabIndex = 6
        Me.grpTo.TabStop = False
        Me.grpTo.Text = "To"
        '
        'ucrNudToDiff
        '
        Me.ucrNudToDiff.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudToDiff.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudToDiff.Location = New System.Drawing.Point(53, 83)
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
        Me.lblToPlus.Location = New System.Drawing.Point(19, 87)
        Me.lblToPlus.Name = "lblToPlus"
        Me.lblToPlus.Size = New System.Drawing.Size(26, 13)
        Me.lblToPlus.TabIndex = 8
        Me.lblToPlus.Text = "plus"
        '
        'rdoToFixedDiff
        '
        Me.rdoToFixedDiff.AutoSize = True
        Me.rdoToFixedDiff.Location = New System.Drawing.Point(191, 32)
        Me.rdoToFixedDiff.Name = "rdoToFixedDiff"
        Me.rdoToFixedDiff.Size = New System.Drawing.Size(102, 17)
        Me.rdoToFixedDiff.TabIndex = 6
        Me.rdoToFixedDiff.TabStop = True
        Me.rdoToFixedDiff.Text = "Fixed Difference"
        Me.rdoToFixedDiff.UseVisualStyleBackColor = True
        '
        'ucrReceiverTo
        '
        Me.ucrReceiverTo.frmParent = Me
        Me.ucrReceiverTo.Location = New System.Drawing.Point(17, 84)
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
        Me.ucrDoyTo.Location = New System.Drawing.Point(16, 84)
        Me.ucrDoyTo.Name = "ucrDoyTo"
        Me.ucrDoyTo.Size = New System.Drawing.Size(209, 21)
        Me.ucrDoyTo.TabIndex = 5
        '
        'rdoToVariable
        '
        Me.rdoToVariable.AutoSize = True
        Me.rdoToVariable.Location = New System.Drawing.Point(100, 32)
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
        Me.rdoToFixed.Location = New System.Drawing.Point(16, 32)
        Me.rdoToFixed.Name = "rdoToFixed"
        Me.rdoToFixed.Size = New System.Drawing.Size(72, 17)
        Me.rdoToFixed.TabIndex = 1
        Me.rdoToFixed.TabStop = True
        Me.rdoToFixed.Text = "Fixed Day"
        Me.rdoToFixed.UseVisualStyleBackColor = True
        '
        'ucrPnlTo
        '
        Me.ucrPnlTo.Location = New System.Drawing.Point(8, 23)
        Me.ucrPnlTo.Name = "ucrPnlTo"
        Me.ucrPnlTo.Size = New System.Drawing.Size(296, 36)
        Me.ucrPnlTo.TabIndex = 3
        '
        'lblToDays
        '
        Me.lblToDays.AutoSize = True
        Me.lblToDays.BackColor = System.Drawing.Color.Transparent
        Me.lblToDays.Location = New System.Drawing.Point(109, 87)
        Me.lblToDays.Name = "lblToDays"
        Me.lblToDays.Size = New System.Drawing.Size(29, 13)
        Me.lblToDays.TabIndex = 9
        Me.lblToDays.Text = "days"
        '
        'sdgDoyRange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 395)
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
    Friend WithEvents rdoToFixedDiff As RadioButton
    Friend WithEvents ucrReceiverTo As ucrReceiverSingle
    Friend WithEvents ucrDoyTo As ucrDayOfYear
    Friend WithEvents rdoToVariable As RadioButton
    Friend WithEvents rdoToFixed As RadioButton
    Friend WithEvents ucrPnlTo As UcrPanel
    Friend WithEvents ucrSelectorDoy As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrDoyFrom As ucrDayOfYear
    Friend WithEvents lblToDays As Label
End Class
