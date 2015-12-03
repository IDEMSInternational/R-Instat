<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgIndicatorVariable
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
        Me.lblAvailableFactors = New System.Windows.Forms.Label()
        Me.cboAvailableFactors = New System.Windows.Forms.ComboBox()
        Me.cboNonFactors = New System.Windows.Forms.ComboBox()
        Me.chkWithX = New System.Windows.Forms.CheckBox()
        Me.lstPasteInto = New System.Windows.Forms.ListBox()
        Me.lblInto = New System.Windows.Forms.Label()
        Me.grpLeveltobeOmiited = New System.Windows.Forms.GroupBox()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.rdoLevelNumber = New System.Windows.Forms.RadioButton()
        Me.rdoLast = New System.Windows.Forms.RadioButton()
        Me.rdoFirst = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.ucrBase = New instat.ucrButtons()
        Me.txtInto = New System.Windows.Forms.TextBox()
        Me.grpLeveltobeOmiited.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAvailableFactors
        '
        Me.lblAvailableFactors.AutoSize = True
        Me.lblAvailableFactors.Location = New System.Drawing.Point(8, 9)
        Me.lblAvailableFactors.Name = "lblAvailableFactors"
        Me.lblAvailableFactors.Size = New System.Drawing.Size(85, 13)
        Me.lblAvailableFactors.TabIndex = 0
        Me.lblAvailableFactors.Tag = "Available_factors"
        Me.lblAvailableFactors.Text = "Available factors"
        '
        'cboAvailableFactors
        '
        Me.cboAvailableFactors.FormattingEnabled = True
        Me.cboAvailableFactors.Location = New System.Drawing.Point(11, 25)
        Me.cboAvailableFactors.Name = "cboAvailableFactors"
        Me.cboAvailableFactors.Size = New System.Drawing.Size(163, 21)
        Me.cboAvailableFactors.TabIndex = 1
        '
        'cboNonFactors
        '
        Me.cboNonFactors.Enabled = False
        Me.cboNonFactors.FormattingEnabled = True
        Me.cboNonFactors.Location = New System.Drawing.Point(11, 75)
        Me.cboNonFactors.Name = "cboNonFactors"
        Me.cboNonFactors.Size = New System.Drawing.Size(163, 21)
        Me.cboNonFactors.Sorted = True
        Me.cboNonFactors.TabIndex = 2
        '
        'chkWithX
        '
        Me.chkWithX.AutoSize = True
        Me.chkWithX.Location = New System.Drawing.Point(11, 52)
        Me.chkWithX.Name = "chkWithX"
        Me.chkWithX.Size = New System.Drawing.Size(111, 17)
        Me.chkWithX.TabIndex = 3
        Me.chkWithX.Tag = "With_an_x_variable"
        Me.chkWithX.Text = "With an x variable"
        Me.chkWithX.UseVisualStyleBackColor = True
        '
        'lstPasteInto
        '
        Me.lstPasteInto.FormattingEnabled = True
        Me.lstPasteInto.Location = New System.Drawing.Point(200, 75)
        Me.lstPasteInto.Name = "lstPasteInto"
        Me.lstPasteInto.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstPasteInto.Size = New System.Drawing.Size(149, 134)
        Me.lstPasteInto.Sorted = True
        Me.lstPasteInto.TabIndex = 4
        '
        'lblInto
        '
        Me.lblInto.AutoSize = True
        Me.lblInto.Location = New System.Drawing.Point(197, 9)
        Me.lblInto.Name = "lblInto"
        Me.lblInto.Size = New System.Drawing.Size(25, 13)
        Me.lblInto.TabIndex = 5
        Me.lblInto.Tag = "Into"
        Me.lblInto.Text = "Into"
        '
        'grpLeveltobeOmiited
        '
        Me.grpLeveltobeOmiited.Controls.Add(Me.txtLevel)
        Me.grpLeveltobeOmiited.Controls.Add(Me.rdoLevelNumber)
        Me.grpLeveltobeOmiited.Controls.Add(Me.rdoLast)
        Me.grpLeveltobeOmiited.Controls.Add(Me.rdoFirst)
        Me.grpLeveltobeOmiited.Controls.Add(Me.rdoNone)
        Me.grpLeveltobeOmiited.Location = New System.Drawing.Point(12, 102)
        Me.grpLeveltobeOmiited.Name = "grpLeveltobeOmiited"
        Me.grpLeveltobeOmiited.Size = New System.Drawing.Size(162, 117)
        Me.grpLeveltobeOmiited.TabIndex = 6
        Me.grpLeveltobeOmiited.TabStop = False
        Me.grpLeveltobeOmiited.Tag = "Level_to_be_omitted"
        Me.grpLeveltobeOmiited.Text = "Level to be omitted"
        '
        'txtLevel
        '
        Me.txtLevel.Enabled = False
        Me.txtLevel.Location = New System.Drawing.Point(103, 89)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Size = New System.Drawing.Size(42, 20)
        Me.txtLevel.TabIndex = 4
        '
        'rdoLevelNumber
        '
        Me.rdoLevelNumber.AutoSize = True
        Me.rdoLevelNumber.Location = New System.Drawing.Point(6, 90)
        Me.rdoLevelNumber.Name = "rdoLevelNumber"
        Me.rdoLevelNumber.Size = New System.Drawing.Size(91, 17)
        Me.rdoLevelNumber.TabIndex = 3
        Me.rdoLevelNumber.TabStop = True
        Me.rdoLevelNumber.Tag = "Level_Number"
        Me.rdoLevelNumber.Text = "Level Number"
        Me.rdoLevelNumber.UseVisualStyleBackColor = True
        '
        'rdoLast
        '
        Me.rdoLast.AutoSize = True
        Me.rdoLast.Location = New System.Drawing.Point(6, 67)
        Me.rdoLast.Name = "rdoLast"
        Me.rdoLast.Size = New System.Drawing.Size(45, 17)
        Me.rdoLast.TabIndex = 2
        Me.rdoLast.TabStop = True
        Me.rdoLast.Tag = "Last"
        Me.rdoLast.Text = "Last"
        Me.rdoLast.UseVisualStyleBackColor = True
        '
        'rdoFirst
        '
        Me.rdoFirst.AutoSize = True
        Me.rdoFirst.Location = New System.Drawing.Point(6, 44)
        Me.rdoFirst.Name = "rdoFirst"
        Me.rdoFirst.Size = New System.Drawing.Size(44, 17)
        Me.rdoFirst.TabIndex = 1
        Me.rdoFirst.TabStop = True
        Me.rdoFirst.Tag = "First"
        Me.rdoFirst.Text = "First"
        Me.rdoFirst.UseVisualStyleBackColor = True
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.Location = New System.Drawing.Point(6, 21)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(51, 17)
        Me.rdoNone.TabIndex = 0
        Me.rdoNone.TabStop = True
        Me.rdoNone.Tag = "None"
        Me.rdoNone.Text = "None"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ucrBase.Location = New System.Drawing.Point(0, 222)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(402, 32)
        Me.ucrBase.TabIndex = 7
        '
        'txtInto
        '
        Me.txtInto.Location = New System.Drawing.Point(200, 26)
        Me.txtInto.Multiline = True
        Me.txtInto.Name = "txtInto"
        Me.txtInto.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInto.Size = New System.Drawing.Size(190, 43)
        Me.txtInto.TabIndex = 8
        '
        'dlgIndicatorVariable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 254)
        Me.Controls.Add(Me.txtInto)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpLeveltobeOmiited)
        Me.Controls.Add(Me.lblInto)
        Me.Controls.Add(Me.lstPasteInto)
        Me.Controls.Add(Me.chkWithX)
        Me.Controls.Add(Me.cboNonFactors)
        Me.Controls.Add(Me.cboAvailableFactors)
        Me.Controls.Add(Me.lblAvailableFactors)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgIndicatorVariable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Indicator (dummy) Variable"
        Me.grpLeveltobeOmiited.ResumeLayout(False)
        Me.grpLeveltobeOmiited.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAvailableFactors As Label
    Friend WithEvents cboAvailableFactors As ComboBox
    Friend WithEvents cboNonFactors As ComboBox
    Friend WithEvents chkWithX As CheckBox
    Friend WithEvents lstPasteInto As ListBox
    Friend WithEvents lblInto As Label
    Friend WithEvents grpLeveltobeOmiited As GroupBox
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents rdoLevelNumber As RadioButton
    Friend WithEvents rdoLast As RadioButton
    Friend WithEvents rdoFirst As RadioButton
    Friend WithEvents rdoNone As RadioButton
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents txtInto As TextBox
End Class
