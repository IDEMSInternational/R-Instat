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
        Me.ucrReceiverView = New instat.ucrReceiverMultiple()
        Me.ucrSelctorForView = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.rdoViewOutputWindow = New System.Windows.Forms.RadioButton()
        Me.rdoViewDataFrame = New System.Windows.Forms.RadioButton()
        Me.grpDisplayFrom.SuspendLayout()
        CType(Me.nudNumberRows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpDisplayFrom
        '
        Me.grpDisplayFrom.Controls.Add(Me.rdoBottom)
        Me.grpDisplayFrom.Controls.Add(Me.rdoTop)
        Me.grpDisplayFrom.Location = New System.Drawing.Point(255, 182)
        Me.grpDisplayFrom.Name = "grpDisplayFrom"
        Me.grpDisplayFrom.Size = New System.Drawing.Size(152, 43)
        Me.grpDisplayFrom.TabIndex = 4
        Me.grpDisplayFrom.TabStop = False
        Me.grpDisplayFrom.Tag = "Display_from"
        Me.grpDisplayFrom.Text = "Display from"
        '
        'rdoBottom
        '
        Me.rdoBottom.AutoSize = True
        Me.rdoBottom.Location = New System.Drawing.Point(78, 17)
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
        Me.rdoTop.Location = New System.Drawing.Point(9, 17)
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
        Me.nudNumberRows.Location = New System.Drawing.Point(360, 155)
        Me.nudNumberRows.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudNumberRows.Name = "nudNumberRows"
        Me.nudNumberRows.Size = New System.Drawing.Size(47, 20)
        Me.nudNumberRows.TabIndex = 4
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(255, 14)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(104, 13)
        Me.lblSelected.TabIndex = 7
        Me.lblSelected.Tag = ""
        Me.lblSelected.Text = "Selected Variable(s):"
        '
        'lblNumberofRows
        '
        Me.lblNumberofRows.AutoSize = True
        Me.lblNumberofRows.Location = New System.Drawing.Point(255, 158)
        Me.lblNumberofRows.Name = "lblNumberofRows"
        Me.lblNumberofRows.Size = New System.Drawing.Size(89, 13)
        Me.lblNumberofRows.TabIndex = 8
        Me.lblNumberofRows.Tag = "Number_of_rows"
        Me.lblNumberofRows.Text = "Number of Rows:"
        '
        'ucrReceiverView
        '
        Me.ucrReceiverView.Location = New System.Drawing.Point(255, 32)
        Me.ucrReceiverView.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverView.Name = "ucrReceiverView"
        Me.ucrReceiverView.Selector = Nothing
        Me.ucrReceiverView.Size = New System.Drawing.Size(120, 86)
        Me.ucrReceiverView.TabIndex = 6
        '
        'ucrSelctorForView
        '
        Me.ucrSelctorForView.bShowHiddenColumns = False
        Me.ucrSelctorForView.bUseCurrentFilter = True
        Me.ucrSelctorForView.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelctorForView.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelctorForView.Name = "ucrSelctorForView"
        Me.ucrSelctorForView.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelctorForView.TabIndex = 5
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 267)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 1
        '
        'rdoViewOutputWindow
        '
        Me.rdoViewOutputWindow.AutoSize = True
        Me.rdoViewOutputWindow.Location = New System.Drawing.Point(255, 130)
        Me.rdoViewOutputWindow.Name = "rdoViewOutputWindow"
        Me.rdoViewOutputWindow.Size = New System.Drawing.Size(136, 17)
        Me.rdoViewOutputWindow.TabIndex = 10
        Me.rdoViewOutputWindow.TabStop = True
        Me.rdoViewOutputWindow.Text = "View in Output Window"
        Me.rdoViewOutputWindow.UseVisualStyleBackColor = True
        '
        'rdoViewDataFrame
        '
        Me.rdoViewDataFrame.AutoSize = True
        Me.rdoViewDataFrame.Location = New System.Drawing.Point(255, 237)
        Me.rdoViewDataFrame.Name = "rdoViewDataFrame"
        Me.rdoViewDataFrame.Size = New System.Drawing.Size(147, 17)
        Me.rdoViewDataFrame.TabIndex = 11
        Me.rdoViewDataFrame.TabStop = True
        Me.rdoViewDataFrame.Text = "View in Separate Window"
        Me.rdoViewDataFrame.UseVisualStyleBackColor = True
        '
        'dlgView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 326)
        Me.Controls.Add(Me.rdoViewDataFrame)
        Me.Controls.Add(Me.rdoViewOutputWindow)
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
    Friend WithEvents rdoViewOutputWindow As RadioButton
    Friend WithEvents rdoViewDataFrame As RadioButton
End Class
