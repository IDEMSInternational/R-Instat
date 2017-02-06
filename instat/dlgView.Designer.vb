<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgView
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
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.rdoDispSepOutputWindow = New System.Windows.Forms.RadioButton()
        Me.rdoDispOutputWindow = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverView = New instat.ucrReceiverMultiple()
        Me.ucrSelectorForView = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlDisplayWindow = New instat.UcrPanel()
        Me.ucrNudNumberRows = New instat.ucrNud()
        Me.rdoBottom = New System.Windows.Forms.RadioButton()
        Me.rdoTop = New System.Windows.Forms.RadioButton()
        Me.ucrPnlDisplayFrom = New instat.UcrPanel()
        Me.ucrSpecifyRows = New instat.ucrCheck()
        Me.lblDisplayFrom = New System.Windows.Forms.Label()
        Me.lblNumberofRows = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(254, 10)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(104, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Tag = ""
        Me.lblSelected.Text = "Selected Variable(s):"
        '
        'rdoDispSepOutputWindow
        '
        Me.rdoDispSepOutputWindow.AutoSize = True
        Me.rdoDispSepOutputWindow.Location = New System.Drawing.Point(10, 200)
        Me.rdoDispSepOutputWindow.Name = "rdoDispSepOutputWindow"
        Me.rdoDispSepOutputWindow.Size = New System.Drawing.Size(158, 17)
        Me.rdoDispSepOutputWindow.TabIndex = 0
        Me.rdoDispSepOutputWindow.TabStop = True
        Me.rdoDispSepOutputWindow.Text = "Display in Separate Window"
        Me.rdoDispSepOutputWindow.UseVisualStyleBackColor = True
        '
        'rdoDispOutputWindow
        '
        Me.rdoDispOutputWindow.AutoSize = True
        Me.rdoDispOutputWindow.Location = New System.Drawing.Point(10, 222)
        Me.rdoDispOutputWindow.Name = "rdoDispOutputWindow"
        Me.rdoDispOutputWindow.Size = New System.Drawing.Size(147, 17)
        Me.rdoDispOutputWindow.TabIndex = 1
        Me.rdoDispOutputWindow.TabStop = True
        Me.rdoDispOutputWindow.Text = "Display in Output Window"
        Me.rdoDispOutputWindow.UseVisualStyleBackColor = True
        '
        'ucrReceiverView
        '
        Me.ucrReceiverView.bAddRemoveParameter = True
        Me.ucrReceiverView.bChangeParameterValue = True
        Me.ucrReceiverView.frmParent = Me
        Me.ucrReceiverView.Location = New System.Drawing.Point(248, 23)
        Me.ucrReceiverView.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverView.Name = "ucrReceiverView"
        Me.ucrReceiverView.Selector = Nothing
        Me.ucrReceiverView.Size = New System.Drawing.Size(120, 142)
        Me.ucrReceiverView.TabIndex = 2
        '
        'ucrSelectorForView
        '
        Me.ucrSelectorForView.bAddRemoveParameter = True
        Me.ucrSelectorForView.bChangeParameterValue = True
        Me.ucrSelectorForView.bShowHiddenColumns = False
        Me.ucrSelectorForView.bUseCurrentFilter = True
        Me.ucrSelectorForView.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForView.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForView.Name = "ucrSelectorForView"
        Me.ucrSelectorForView.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForView.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 319)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 5
        '
        'ucrPnlDisplayWindow
        '
        Me.ucrPnlDisplayWindow.bAddRemoveParameter = True
        Me.ucrPnlDisplayWindow.bChangeParameterValue = True
        Me.ucrPnlDisplayWindow.Location = New System.Drawing.Point(10, 200)
        Me.ucrPnlDisplayWindow.Name = "ucrPnlDisplayWindow"
        Me.ucrPnlDisplayWindow.Size = New System.Drawing.Size(170, 46)
        Me.ucrPnlDisplayWindow.TabIndex = 6
        '
        'ucrNudNumberRows
        '
        Me.ucrNudNumberRows.bAddRemoveParameter = True
        Me.ucrNudNumberRows.bChangeParameterValue = True
        Me.ucrNudNumberRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberRows.Location = New System.Drawing.Point(318, 217)
        Me.ucrNudNumberRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberRows.Name = "ucrNudNumberRows"
        Me.ucrNudNumberRows.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberRows.TabIndex = 17
        Me.ucrNudNumberRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoBottom
        '
        Me.rdoBottom.AutoSize = True
        Me.rdoBottom.Location = New System.Drawing.Point(299, 265)
        Me.rdoBottom.Name = "rdoBottom"
        Me.rdoBottom.Size = New System.Drawing.Size(58, 17)
        Me.rdoBottom.TabIndex = 15
        Me.rdoBottom.TabStop = True
        Me.rdoBottom.Text = "Bottom"
        Me.rdoBottom.UseVisualStyleBackColor = True
        '
        'rdoTop
        '
        Me.rdoTop.AutoSize = True
        Me.rdoTop.Location = New System.Drawing.Point(299, 243)
        Me.rdoTop.Name = "rdoTop"
        Me.rdoTop.Size = New System.Drawing.Size(44, 17)
        Me.rdoTop.TabIndex = 14
        Me.rdoTop.TabStop = True
        Me.rdoTop.Text = "Top"
        Me.rdoTop.UseVisualStyleBackColor = True
        '
        'ucrPnlDisplayFrom
        '
        Me.ucrPnlDisplayFrom.bAddRemoveParameter = True
        Me.ucrPnlDisplayFrom.bChangeParameterValue = True
        Me.ucrPnlDisplayFrom.Location = New System.Drawing.Point(299, 243)
        Me.ucrPnlDisplayFrom.Name = "ucrPnlDisplayFrom"
        Me.ucrPnlDisplayFrom.Size = New System.Drawing.Size(66, 40)
        Me.ucrPnlDisplayFrom.TabIndex = 16
        '
        'ucrSpecifyRows
        '
        Me.ucrSpecifyRows.bAddRemoveParameter = True
        Me.ucrSpecifyRows.bChangeParameterValue = True
        Me.ucrSpecifyRows.Checked = False
        Me.ucrSpecifyRows.Location = New System.Drawing.Point(226, 195)
        Me.ucrSpecifyRows.Name = "ucrSpecifyRows"
        Me.ucrSpecifyRows.Size = New System.Drawing.Size(100, 20)
        Me.ucrSpecifyRows.TabIndex = 11
        '
        'lblDisplayFrom
        '
        Me.lblDisplayFrom.AutoSize = True
        Me.lblDisplayFrom.Location = New System.Drawing.Point(223, 244)
        Me.lblDisplayFrom.Name = "lblDisplayFrom"
        Me.lblDisplayFrom.Size = New System.Drawing.Size(70, 13)
        Me.lblDisplayFrom.TabIndex = 13
        Me.lblDisplayFrom.Tag = ""
        Me.lblDisplayFrom.Text = "Display From:"
        '
        'lblNumberofRows
        '
        Me.lblNumberofRows.AutoSize = True
        Me.lblNumberofRows.Location = New System.Drawing.Point(223, 221)
        Me.lblNumberofRows.Name = "lblNumberofRows"
        Me.lblNumberofRows.Size = New System.Drawing.Size(89, 13)
        Me.lblNumberofRows.TabIndex = 12
        Me.lblNumberofRows.Tag = "Number_of_rows"
        Me.lblNumberofRows.Text = "Number of Rows:"
        '
        'dlgView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 374)
        Me.Controls.Add(Me.ucrNudNumberRows)
        Me.Controls.Add(Me.rdoBottom)
        Me.Controls.Add(Me.rdoTop)
        Me.Controls.Add(Me.ucrPnlDisplayFrom)
        Me.Controls.Add(Me.ucrSpecifyRows)
        Me.Controls.Add(Me.lblDisplayFrom)
        Me.Controls.Add(Me.lblNumberofRows)
        Me.Controls.Add(Me.rdoDispOutputWindow)
        Me.Controls.Add(Me.rdoDispSepOutputWindow)
        Me.Controls.Add(Me.ucrPnlDisplayWindow)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrReceiverView)
        Me.Controls.Add(Me.ucrSelectorForView)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "View Data"
        Me.Text = "View Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForView As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverView As ucrReceiverMultiple
    Friend WithEvents lblSelected As Label
    Friend WithEvents rdoDispSepOutputWindow As RadioButton
    Friend WithEvents rdoDispOutputWindow As RadioButton
    Friend WithEvents ucrPnlDisplayWindow As UcrPanel
    Friend WithEvents ucrNudNumberRows As ucrNud
    Friend WithEvents rdoBottom As RadioButton
    Friend WithEvents rdoTop As RadioButton
    Friend WithEvents ucrPnlDisplayFrom As UcrPanel
    Friend WithEvents ucrSpecifyRows As ucrCheck
    Friend WithEvents lblDisplayFrom As Label
    Friend WithEvents lblNumberofRows As Label
End Class
