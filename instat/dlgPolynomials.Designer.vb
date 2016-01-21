<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPolynomials
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
        Me.nmdOrder = New System.Windows.Forms.NumericUpDown()
        Me.rdoSimple = New System.Windows.Forms.RadioButton()
        Me.lstPasteInto = New System.Windows.Forms.ListBox()
        Me.cmdAddTo = New System.Windows.Forms.Button()
        Me.txtInto = New System.Windows.Forms.TextBox()
        Me.lblInto = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.rdoOrthogonal = New System.Windows.Forms.RadioButton()
        Me.rdoCentered = New System.Windows.Forms.RadioButton()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.chkWeights = New System.Windows.Forms.CheckBox()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nmdOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpType.SuspendLayout()
        Me.SuspendLayout()
        '
        'nmdOrder
        '
        Me.nmdOrder.Location = New System.Drawing.Point(226, 81)
        Me.nmdOrder.Name = "nmdOrder"
        Me.nmdOrder.Size = New System.Drawing.Size(46, 20)
        Me.nmdOrder.TabIndex = 0
        Me.nmdOrder.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rdoSimple
        '
        Me.rdoSimple.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoSimple.AutoSize = True
        Me.rdoSimple.Checked = True
        Me.rdoSimple.Location = New System.Drawing.Point(17, 19)
        Me.rdoSimple.Name = "rdoSimple"
        Me.rdoSimple.Size = New System.Drawing.Size(54, 17)
        Me.rdoSimple.TabIndex = 1
        Me.rdoSimple.TabStop = True
        Me.rdoSimple.Tag = "simple"
        Me.rdoSimple.Text = "simple"
        Me.rdoSimple.UseVisualStyleBackColor = True
        '
        'lstPasteInto
        '
        Me.lstPasteInto.FormattingEnabled = True
        Me.lstPasteInto.Location = New System.Drawing.Point(290, 117)
        Me.lstPasteInto.Name = "lstPasteInto"
        Me.lstPasteInto.Size = New System.Drawing.Size(120, 82)
        Me.lstPasteInto.Sorted = True
        Me.lstPasteInto.TabIndex = 2
        '
        'cmdAddTo
        '
        Me.cmdAddTo.Location = New System.Drawing.Point(387, 79)
        Me.cmdAddTo.Name = "cmdAddTo"
        Me.cmdAddTo.Size = New System.Drawing.Size(23, 23)
        Me.cmdAddTo.TabIndex = 3
        Me.cmdAddTo.Text = "<"
        Me.cmdAddTo.UseVisualStyleBackColor = True
        '
        'txtInto
        '
        Me.txtInto.Location = New System.Drawing.Point(290, 81)
        Me.txtInto.Multiline = True
        Me.txtInto.Name = "txtInto"
        Me.txtInto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInto.Size = New System.Drawing.Size(100, 34)
        Me.txtInto.TabIndex = 4
        '
        'lblInto
        '
        Me.lblInto.AutoSize = True
        Me.lblInto.Location = New System.Drawing.Point(287, 65)
        Me.lblInto.Name = "lblInto"
        Me.lblInto.Size = New System.Drawing.Size(25, 13)
        Me.lblInto.TabIndex = 5
        Me.lblInto.Tag = "Into"
        Me.lblInto.Text = "Into"
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Location = New System.Drawing.Point(223, 65)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(33, 13)
        Me.lblOrder.TabIndex = 6
        Me.lblOrder.Tag = "Order"
        Me.lblOrder.Text = "Order"
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.rdoOrthogonal)
        Me.grpType.Controls.Add(Me.rdoSimple)
        Me.grpType.Controls.Add(Me.rdoCentered)
        Me.grpType.Location = New System.Drawing.Point(12, 12)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(398, 47)
        Me.grpType.TabIndex = 7
        Me.grpType.TabStop = False
        Me.grpType.Tag = "Type"
        Me.grpType.Text = "Type"
        '
        'rdoOrthogonal
        '
        Me.rdoOrthogonal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoOrthogonal.AutoSize = True
        Me.rdoOrthogonal.Location = New System.Drawing.Point(296, 19)
        Me.rdoOrthogonal.Name = "rdoOrthogonal"
        Me.rdoOrthogonal.Size = New System.Drawing.Size(75, 17)
        Me.rdoOrthogonal.TabIndex = 9
        Me.rdoOrthogonal.Tag = "orthogonal"
        Me.rdoOrthogonal.Text = "orthogonal"
        Me.rdoOrthogonal.UseVisualStyleBackColor = True
        '
        'rdoCentered
        '
        Me.rdoCentered.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoCentered.AutoSize = True
        Me.rdoCentered.Location = New System.Drawing.Point(147, 19)
        Me.rdoCentered.Name = "rdoCentered"
        Me.rdoCentered.Size = New System.Drawing.Size(67, 17)
        Me.rdoCentered.TabIndex = 8
        Me.rdoCentered.Tag = "centered"
        Me.rdoCentered.Text = "centered"
        Me.rdoCentered.UseVisualStyleBackColor = True
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(12, 65)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(205, 127)
        Me.ucrAddRemove.TabIndex = 8
        '
        'chkWeights
        '
        Me.chkWeights.AutoSize = True
        Me.chkWeights.Enabled = False
        Me.chkWeights.Location = New System.Drawing.Point(12, 198)
        Me.chkWeights.Name = "chkWeights"
        Me.chkWeights.Size = New System.Drawing.Size(65, 17)
        Me.chkWeights.TabIndex = 10
        Me.chkWeights.Tag = "Weights"
        Me.chkWeights.Text = "Weights"
        Me.chkWeights.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 221)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(403, 53)
        Me.ucrBase.TabIndex = 11
        '
        'dlgPolynomials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 278)
        Me.Controls.Add(Me.chkWeights)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.lblInto)
        Me.Controls.Add(Me.txtInto)
        Me.Controls.Add(Me.cmdAddTo)
        Me.Controls.Add(Me.lstPasteInto)
        Me.Controls.Add(Me.nmdOrder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgPolynomials"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Generate_polynomial_terms"
        Me.Text = "Generate polynomial terms"
        CType(Me.nmdOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nmdOrder As NumericUpDown
    Friend WithEvents rdoSimple As RadioButton
    Friend WithEvents lstPasteInto As ListBox
    Friend WithEvents cmdAddTo As Button
    Friend WithEvents txtInto As TextBox
    Friend WithEvents lblInto As Label
    Friend WithEvents lblOrder As Label
    Friend WithEvents grpType As GroupBox
    Friend WithEvents rdoOrthogonal As RadioButton
    Friend WithEvents rdoCentered As RadioButton
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents chkWeights As CheckBox
    Friend WithEvents ucrBase As ucrButtons
End Class
