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
        Me.grpDisplayFrom = New System.Windows.Forms.GroupBox()
        Me.rdoBottom = New System.Windows.Forms.RadioButton()
        Me.rdoTop = New System.Windows.Forms.RadioButton()
        Me.nudNumberRows = New System.Windows.Forms.NumericUpDown()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblNumberofRows = New System.Windows.Forms.Label()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.rdoDispSepOutputWindow = New System.Windows.Forms.RadioButton()
        Me.rdoDispOutputWindow = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverView = New instat.ucrReceiverMultiple()
        Me.ucrSelctorForView = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpDisplayFrom.SuspendLayout()
        CType(Me.nudNumberRows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDisplayFrom
        '
        Me.grpDisplayFrom.Controls.Add(Me.rdoBottom)
        Me.grpDisplayFrom.Controls.Add(Me.rdoTop)
        Me.grpDisplayFrom.Location = New System.Drawing.Point(248, 230)
        Me.grpDisplayFrom.Name = "grpDisplayFrom"
        Me.grpDisplayFrom.Size = New System.Drawing.Size(167, 43)
        Me.grpDisplayFrom.TabIndex = 6
        Me.grpDisplayFrom.TabStop = False
        Me.grpDisplayFrom.Tag = "Display_from"
        Me.grpDisplayFrom.Text = "Display from"
        '
        'rdoBottom
        '
        Me.rdoBottom.AutoSize = True
        Me.rdoBottom.Location = New System.Drawing.Point(92, 17)
        Me.rdoBottom.Name = "rdoBottom"
        Me.rdoBottom.Size = New System.Drawing.Size(58, 17)
        Me.rdoBottom.TabIndex = 1
        Me.rdoBottom.TabStop = True
        Me.rdoBottom.Tag = "Bottom"
        Me.rdoBottom.Text = "Bottom"
        Me.rdoBottom.UseVisualStyleBackColor = True
        '
        'rdoTop
        '
        Me.rdoTop.AutoSize = True
        Me.rdoTop.Location = New System.Drawing.Point(8, 17)
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
        Me.nudNumberRows.Location = New System.Drawing.Point(355, 205)
        Me.nudNumberRows.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudNumberRows.Name = "nudNumberRows"
        Me.nudNumberRows.Size = New System.Drawing.Size(47, 20)
        Me.nudNumberRows.TabIndex = 5
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(255, 14)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(104, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Tag = ""
        Me.lblSelected.Text = "Selected Variable(s):"
        '
        'lblNumberofRows
        '
        Me.lblNumberofRows.AutoSize = True
        Me.lblNumberofRows.Location = New System.Drawing.Point(245, 207)
        Me.lblNumberofRows.Name = "lblNumberofRows"
        Me.lblNumberofRows.Size = New System.Drawing.Size(89, 13)
        Me.lblNumberofRows.TabIndex = 4
        Me.lblNumberofRows.Tag = "Number_of_rows"
        Me.lblNumberofRows.Text = "Number of Rows:"
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.rdoDispSepOutputWindow)
        Me.grpDisplay.Controls.Add(Me.rdoDispOutputWindow)
        Me.grpDisplay.Location = New System.Drawing.Point(248, 123)
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
        Me.rdoDispOutputWindow.Location = New System.Drawing.Point(8, 46)
        Me.rdoDispOutputWindow.Name = "rdoDispOutputWindow"
        Me.rdoDispOutputWindow.Size = New System.Drawing.Size(147, 17)
        Me.rdoDispOutputWindow.TabIndex = 1
        Me.rdoDispOutputWindow.TabStop = True
        Me.rdoDispOutputWindow.Text = "Display in Output Window"
        Me.rdoDispOutputWindow.UseVisualStyleBackColor = True
        '
        'ucrReceiverView
        '
        Me.ucrReceiverView.Location = New System.Drawing.Point(255, 32)
        Me.ucrReceiverView.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverView.Name = "ucrReceiverView"
        Me.ucrReceiverView.Selector = Nothing
        Me.ucrReceiverView.Size = New System.Drawing.Size(120, 86)
        Me.ucrReceiverView.TabIndex = 2
        '
        'ucrSelctorForView
        '
        Me.ucrSelctorForView.bShowHiddenColumns = False
        Me.ucrSelctorForView.bUseCurrentFilter = True
        Me.ucrSelctorForView.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelctorForView.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelctorForView.Name = "ucrSelctorForView"
        Me.ucrSelctorForView.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelctorForView.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 279)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 7
        '
        'dlgView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 337)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.lblNumberofRows)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.nudNumberRows)
        Me.Controls.Add(Me.ucrReceiverView)
        Me.Controls.Add(Me.ucrSelctorForView)
        Me.Controls.Add(Me.grpDisplayFrom)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "View Data"
        Me.Text = "View Data"
        Me.grpDisplayFrom.ResumeLayout(False)
        Me.grpDisplayFrom.PerformLayout()
        CType(Me.nudNumberRows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpDisplayFrom As GroupBox
    Friend WithEvents rdoBottom As RadioButton
    Friend WithEvents rdoTop As RadioButton
    Friend WithEvents ucrSelctorForView As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverView As ucrReceiverMultiple
    Friend WithEvents lblSelected As Label
    Friend WithEvents nudNumberRows As NumericUpDown
    Friend WithEvents lblNumberofRows As Label
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents rdoDispSepOutputWindow As RadioButton
    Friend WithEvents rdoDispOutputWindow As RadioButton
End Class
