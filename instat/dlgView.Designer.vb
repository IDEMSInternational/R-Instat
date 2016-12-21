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
        Me.grpDisplayOptions = New System.Windows.Forms.GroupBox()
        Me.lblDisplayFrom = New System.Windows.Forms.Label()
        Me.rdoBottom = New System.Windows.Forms.RadioButton()
        Me.lblNumberofRows = New System.Windows.Forms.Label()
        Me.rdoTop = New System.Windows.Forms.RadioButton()
        Me.nudNumberRows = New System.Windows.Forms.NumericUpDown()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.rdoDispSepOutputWindow = New System.Windows.Forms.RadioButton()
        Me.rdoDispOutputWindow = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverView = New instat.ucrReceiverMultiple()
        Me.ucrSelectorForView = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSpecifyRows = New instat.ucrCheck()
        Me.grpDisplayOptions.SuspendLayout()
        CType(Me.nudNumberRows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDisplayOptions
        '
        Me.grpDisplayOptions.Controls.Add(Me.ucrSpecifyRows)
        Me.grpDisplayOptions.Controls.Add(Me.lblDisplayFrom)
        Me.grpDisplayOptions.Controls.Add(Me.rdoBottom)
        Me.grpDisplayOptions.Controls.Add(Me.lblNumberofRows)
        Me.grpDisplayOptions.Controls.Add(Me.rdoTop)
        Me.grpDisplayOptions.Controls.Add(Me.nudNumberRows)
        Me.grpDisplayOptions.Location = New System.Drawing.Point(186, 200)
        Me.grpDisplayOptions.Name = "grpDisplayOptions"
        Me.grpDisplayOptions.Size = New System.Drawing.Size(191, 113)
        Me.grpDisplayOptions.TabIndex = 6
        Me.grpDisplayOptions.TabStop = False
        Me.grpDisplayOptions.Tag = "Display_Options"
        Me.grpDisplayOptions.Text = "Display Options"
        '
        'lblDisplayFrom
        '
        Me.lblDisplayFrom.AutoSize = True
        Me.lblDisplayFrom.Location = New System.Drawing.Point(12, 68)
        Me.lblDisplayFrom.Name = "lblDisplayFrom"
        Me.lblDisplayFrom.Size = New System.Drawing.Size(70, 13)
        Me.lblDisplayFrom.TabIndex = 8
        Me.lblDisplayFrom.Tag = ""
        Me.lblDisplayFrom.Text = "Display From:"
        '
        'rdoBottom
        '
        Me.rdoBottom.AutoSize = True
        Me.rdoBottom.Location = New System.Drawing.Point(107, 88)
        Me.rdoBottom.Name = "rdoBottom"
        Me.rdoBottom.Size = New System.Drawing.Size(58, 17)
        Me.rdoBottom.TabIndex = 1
        Me.rdoBottom.TabStop = True
        Me.rdoBottom.Tag = "Bottom"
        Me.rdoBottom.Text = "Bottom"
        Me.rdoBottom.UseVisualStyleBackColor = True
        '
        'lblNumberofRows
        '
        Me.lblNumberofRows.AutoSize = True
        Me.lblNumberofRows.Location = New System.Drawing.Point(12, 45)
        Me.lblNumberofRows.Name = "lblNumberofRows"
        Me.lblNumberofRows.Size = New System.Drawing.Size(89, 13)
        Me.lblNumberofRows.TabIndex = 4
        Me.lblNumberofRows.Tag = "Number_of_rows"
        Me.lblNumberofRows.Text = "Number of Rows:"
        '
        'rdoTop
        '
        Me.rdoTop.AutoSize = True
        Me.rdoTop.Location = New System.Drawing.Point(107, 67)
        Me.rdoTop.Name = "rdoTop"
        Me.rdoTop.Size = New System.Drawing.Size(44, 17)
        Me.rdoTop.TabIndex = 0
        Me.rdoTop.TabStop = True
        Me.rdoTop.Tag = "Top"
        Me.rdoTop.Text = "Top"
        Me.rdoTop.UseVisualStyleBackColor = True
        '
        'nudNumberRows
        '
        Me.nudNumberRows.Location = New System.Drawing.Point(107, 42)
        Me.nudNumberRows.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudNumberRows.Name = "nudNumberRows"
        Me.nudNumberRows.Size = New System.Drawing.Size(47, 20)
        Me.nudNumberRows.TabIndex = 5
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(257, 30)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(104, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Tag = ""
        Me.lblSelected.Text = "Selected Variable(s):"
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.rdoDispSepOutputWindow)
        Me.grpDisplay.Controls.Add(Me.rdoDispOutputWindow)
        Me.grpDisplay.Location = New System.Drawing.Point(10, 200)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(167, 73)
        Me.grpDisplay.TabIndex = 3
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Display Window"
        '
        'rdoDispSepOutputWindow
        '
        Me.rdoDispSepOutputWindow.AutoSize = True
        Me.rdoDispSepOutputWindow.Location = New System.Drawing.Point(8, 18)
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
        Me.rdoDispOutputWindow.Location = New System.Drawing.Point(8, 41)
        Me.rdoDispOutputWindow.Name = "rdoDispOutputWindow"
        Me.rdoDispOutputWindow.Size = New System.Drawing.Size(147, 17)
        Me.rdoDispOutputWindow.TabIndex = 1
        Me.rdoDispOutputWindow.TabStop = True
        Me.rdoDispOutputWindow.Text = "Display in Output Window"
        Me.rdoDispOutputWindow.UseVisualStyleBackColor = True
        '
        'ucrReceiverView
        '
        Me.ucrReceiverView.Location = New System.Drawing.Point(257, 48)
        Me.ucrReceiverView.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverView.Name = "ucrReceiverView"
        Me.ucrReceiverView.Selector = Nothing
        Me.ucrReceiverView.Size = New System.Drawing.Size(120, 142)
        Me.ucrReceiverView.TabIndex = 2
        '
        'ucrSelectorForView
        '
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
        Me.ucrBase.Location = New System.Drawing.Point(10, 319)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 7
        '
        'ucrSpecifyRows
        '
        Me.ucrSpecifyRows.Checked = False
        Me.ucrSpecifyRows.Location = New System.Drawing.Point(15, 19)
        Me.ucrSpecifyRows.Name = "ucrSpecifyRows"
        Me.ucrSpecifyRows.Size = New System.Drawing.Size(100, 20)
        Me.ucrSpecifyRows.TabIndex = 9
        '
        'dlgView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 407)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrReceiverView)
        Me.Controls.Add(Me.ucrSelectorForView)
        Me.Controls.Add(Me.grpDisplayOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "View Data"
        Me.Text = "View Data"
        Me.grpDisplayOptions.ResumeLayout(False)
        Me.grpDisplayOptions.PerformLayout()
        CType(Me.nudNumberRows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpDisplayOptions As GroupBox
    Friend WithEvents rdoBottom As RadioButton
    Friend WithEvents rdoTop As RadioButton
    Friend WithEvents ucrSelectorForView As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverView As ucrReceiverMultiple
    Friend WithEvents lblSelected As Label
    Friend WithEvents nudNumberRows As NumericUpDown
    Friend WithEvents lblNumberofRows As Label
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents rdoDispSepOutputWindow As RadioButton
    Friend WithEvents rdoDispOutputWindow As RadioButton
    Friend WithEvents lblDisplayFrom As Label
    Friend WithEvents ucrSpecifyRows As ucrCheck
End Class
