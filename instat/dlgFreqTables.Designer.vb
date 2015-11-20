<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFreqTables
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
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.cboPercentFactor = New System.Windows.Forms.ComboBox()
        Me.rdoPercentFactor = New System.Windows.Forms.RadioButton()
        Me.rdoPercentOverallTotal = New System.Windows.Forms.RadioButton()
        Me.rdoCounts = New System.Windows.Forms.RadioButton()
        Me.chkWeights = New System.Windows.Forms.CheckBox()
        Me.cboWeights = New System.Windows.Forms.ComboBox()
        Me.grpTwoways = New System.Windows.Forms.GroupBox()
        Me.lblDecimals = New System.Windows.Forms.Label()
        Me.nudDecimals = New System.Windows.Forms.NumericUpDown()
        Me.lblColumnFactors = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.chkDisplayMargins = New System.Windows.Forms.CheckBox()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpDisplay.SuspendLayout()
        Me.grpTwoways.SuspendLayout()
        CType(Me.nudDecimals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(21, 14)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(42, 13)
        Me.lblFactors.TabIndex = 2
        Me.lblFactors.Tag = "Factors"
        Me.lblFactors.Text = "Factors"
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.cboPercentFactor)
        Me.grpDisplay.Controls.Add(Me.rdoPercentFactor)
        Me.grpDisplay.Controls.Add(Me.rdoPercentOverallTotal)
        Me.grpDisplay.Controls.Add(Me.rdoCounts)
        Me.grpDisplay.Location = New System.Drawing.Point(12, 163)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(226, 117)
        Me.grpDisplay.TabIndex = 4
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Tag = "Display"
        Me.grpDisplay.Text = "Display"
        '
        'cboPercentFactor
        '
        Me.cboPercentFactor.FormattingEnabled = True
        Me.cboPercentFactor.Location = New System.Drawing.Point(140, 95)
        Me.cboPercentFactor.Name = "cboPercentFactor"
        Me.cboPercentFactor.Size = New System.Drawing.Size(80, 21)
        Me.cboPercentFactor.TabIndex = 3
        '
        'rdoPercentFactor
        '
        Me.rdoPercentFactor.AutoSize = True
        Me.rdoPercentFactor.Location = New System.Drawing.Point(12, 99)
        Me.rdoPercentFactor.Name = "rdoPercentFactor"
        Me.rdoPercentFactor.Size = New System.Drawing.Size(122, 17)
        Me.rdoPercentFactor.TabIndex = 2
        Me.rdoPercentFactor.TabStop = True
        Me.rdoPercentFactor.Tag = "Percentage_of_Factor"
        Me.rdoPercentFactor.Text = "Percentage of factor"
        Me.rdoPercentFactor.UseVisualStyleBackColor = True
        '
        'rdoPercentOverallTotal
        '
        Me.rdoPercentOverallTotal.AutoSize = True
        Me.rdoPercentOverallTotal.Location = New System.Drawing.Point(12, 67)
        Me.rdoPercentOverallTotal.Name = "rdoPercentOverallTotal"
        Me.rdoPercentOverallTotal.Size = New System.Drawing.Size(154, 17)
        Me.rdoPercentOverallTotal.TabIndex = 1
        Me.rdoPercentOverallTotal.TabStop = True
        Me.rdoPercentOverallTotal.Text = "Percentages of overall total"
        Me.rdoPercentOverallTotal.UseVisualStyleBackColor = True
        '
        'rdoCounts
        '
        Me.rdoCounts.AutoSize = True
        Me.rdoCounts.Location = New System.Drawing.Point(12, 33)
        Me.rdoCounts.Name = "rdoCounts"
        Me.rdoCounts.Size = New System.Drawing.Size(58, 17)
        Me.rdoCounts.TabIndex = 0
        Me.rdoCounts.TabStop = True
        Me.rdoCounts.Tag = "Counts"
        Me.rdoCounts.Text = "Counts"
        Me.rdoCounts.UseVisualStyleBackColor = True
        '
        'chkWeights
        '
        Me.chkWeights.AutoSize = True
        Me.chkWeights.Location = New System.Drawing.Point(313, 49)
        Me.chkWeights.Name = "chkWeights"
        Me.chkWeights.Size = New System.Drawing.Size(65, 17)
        Me.chkWeights.TabIndex = 5
        Me.chkWeights.Tag = "Weights"
        Me.chkWeights.Text = "Weights"
        Me.chkWeights.UseVisualStyleBackColor = True
        '
        'cboWeights
        '
        Me.cboWeights.FormattingEnabled = True
        Me.cboWeights.Location = New System.Drawing.Point(384, 45)
        Me.cboWeights.Name = "cboWeights"
        Me.cboWeights.Size = New System.Drawing.Size(83, 21)
        Me.cboWeights.TabIndex = 6
        '
        'grpTwoways
        '
        Me.grpTwoways.Controls.Add(Me.lblDecimals)
        Me.grpTwoways.Controls.Add(Me.nudDecimals)
        Me.grpTwoways.Controls.Add(Me.lblColumnFactors)
        Me.grpTwoways.Controls.Add(Me.TextBox1)
        Me.grpTwoways.Controls.Add(Me.chkDisplayMargins)
        Me.grpTwoways.Location = New System.Drawing.Point(244, 163)
        Me.grpTwoways.Name = "grpTwoways"
        Me.grpTwoways.Size = New System.Drawing.Size(200, 117)
        Me.grpTwoways.TabIndex = 7
        Me.grpTwoways.TabStop = False
        Me.grpTwoways.Tag = "Two_way_table(s)"
        Me.grpTwoways.Text = "Two way tables(s)"
        '
        'lblDecimals
        '
        Me.lblDecimals.AutoSize = True
        Me.lblDecimals.Location = New System.Drawing.Point(6, 83)
        Me.lblDecimals.Name = "lblDecimals"
        Me.lblDecimals.Size = New System.Drawing.Size(50, 13)
        Me.lblDecimals.TabIndex = 9
        Me.lblDecimals.Tag = "Decimals"
        Me.lblDecimals.Text = "Decimals"
        '
        'nudDecimals
        '
        Me.nudDecimals.AllowDrop = True
        Me.nudDecimals.Location = New System.Drawing.Point(105, 76)
        Me.nudDecimals.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudDecimals.Name = "nudDecimals"
        Me.nudDecimals.Size = New System.Drawing.Size(44, 20)
        Me.nudDecimals.TabIndex = 8
        '
        'lblColumnFactors
        '
        Me.lblColumnFactors.AutoSize = True
        Me.lblColumnFactors.Location = New System.Drawing.Point(6, 46)
        Me.lblColumnFactors.Name = "lblColumnFactors"
        Me.lblColumnFactors.Size = New System.Drawing.Size(77, 13)
        Me.lblColumnFactors.TabIndex = 7
        Me.lblColumnFactors.Tag = "Column_factors"
        Me.lblColumnFactors.Text = "Column factors"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(105, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(29, 20)
        Me.TextBox1.TabIndex = 6
        '
        'chkDisplayMargins
        '
        Me.chkDisplayMargins.AutoSize = True
        Me.chkDisplayMargins.Location = New System.Drawing.Point(24, 19)
        Me.chkDisplayMargins.Name = "chkDisplayMargins"
        Me.chkDisplayMargins.Size = New System.Drawing.Size(99, 17)
        Me.chkDisplayMargins.TabIndex = 5
        Me.chkDisplayMargins.Tag = "Display_margins"
        Me.chkDisplayMargins.Text = "Display margins"
        Me.chkDisplayMargins.UseVisualStyleBackColor = True
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(205, 30)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(95, 13)
        Me.lblSelectedVariables.TabIndex = 8
        Me.lblSelectedVariables.Tag = "Selected_Variable"
        Me.lblSelectedVariables.Text = "Selected Variables"
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(209, 47)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(91, 101)
        Me.ucrReceiverMultiple.TabIndex = 3
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(3, 30)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(200, 118)
        Me.ucrAddRemove.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(34, 298)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'dlgFreqTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 342)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.grpTwoways)
        Me.Controls.Add(Me.cboWeights)
        Me.Controls.Add(Me.chkWeights)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.ucrReceiverMultiple)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgFreqTables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Frequency_table"
        Me.Text = "Frequency Tables"
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
        Me.grpTwoways.ResumeLayout(False)
        Me.grpTwoways.PerformLayout()
        CType(Me.nudDecimals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrReceiverMultiple As ucrReceiverMultiple
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents rdoPercentFactor As RadioButton
    Friend WithEvents rdoPercentOverallTotal As RadioButton
    Friend WithEvents rdoCounts As RadioButton
    Friend WithEvents chkWeights As CheckBox
    Friend WithEvents cboWeights As ComboBox
    Friend WithEvents grpTwoways As GroupBox
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents cboPercentFactor As ComboBox
    Friend WithEvents lblDecimals As Label
    Friend WithEvents nudDecimals As NumericUpDown
    Friend WithEvents lblColumnFactors As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents chkDisplayMargins As CheckBox
End Class
