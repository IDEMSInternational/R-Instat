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
        Me.rdoSimple = New System.Windows.Forms.RadioButton()
        Me.lblDegree = New System.Windows.Forms.Label()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.rdoOrthogonal = New System.Windows.Forms.RadioButton()
        Me.rdoCentered = New System.Windows.Forms.RadioButton()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.nudDegree = New System.Windows.Forms.NumericUpDown()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrInputPolynomial = New instat.ucrInputComboBox()
        Me.ucrSelectorForPolynomial = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverPolynomial = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpType.SuspendLayout()
        CType(Me.nudDegree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdoSimple
        '
        Me.rdoSimple.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoSimple.AutoSize = True
        Me.rdoSimple.Location = New System.Drawing.Point(11, 19)
        Me.rdoSimple.Name = "rdoSimple"
        Me.rdoSimple.Size = New System.Drawing.Size(56, 17)
        Me.rdoSimple.TabIndex = 1
        Me.rdoSimple.Tag = "Simple"
        Me.rdoSimple.Text = "Simple"
        Me.rdoSimple.UseVisualStyleBackColor = True
        '
        'lblDegree
        '
        Me.lblDegree.AutoSize = True
        Me.lblDegree.Location = New System.Drawing.Point(271, 74)
        Me.lblDegree.Name = "lblDegree"
        Me.lblDegree.Size = New System.Drawing.Size(42, 13)
        Me.lblDegree.TabIndex = 6
        Me.lblDegree.Tag = "Degree"
        Me.lblDegree.Text = "Degree"
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.rdoOrthogonal)
        Me.grpType.Controls.Add(Me.rdoSimple)
        Me.grpType.Controls.Add(Me.rdoCentered)
        Me.grpType.Location = New System.Drawing.Point(271, 100)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(127, 106)
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
        Me.rdoOrthogonal.Location = New System.Drawing.Point(11, 75)
        Me.rdoOrthogonal.Name = "rdoOrthogonal"
        Me.rdoOrthogonal.Size = New System.Drawing.Size(77, 17)
        Me.rdoOrthogonal.TabIndex = 9
        Me.rdoOrthogonal.Tag = "Orthogonal"
        Me.rdoOrthogonal.Text = "Orthogonal"
        Me.rdoOrthogonal.UseVisualStyleBackColor = True
        '
        'rdoCentered
        '
        Me.rdoCentered.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoCentered.AutoSize = True
        Me.rdoCentered.Location = New System.Drawing.Point(11, 47)
        Me.rdoCentered.Name = "rdoCentered"
        Me.rdoCentered.Size = New System.Drawing.Size(68, 17)
        Me.rdoCentered.TabIndex = 8
        Me.rdoCentered.Tag = "Centered"
        Me.rdoCentered.Text = "Centered"
        Me.rdoCentered.UseVisualStyleBackColor = True
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(255, 25)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(49, 13)
        Me.lblSelected.TabIndex = 14
        Me.lblSelected.Tag = "Selected"
        Me.lblSelected.Text = "Selected"
        '
        'nudDegree
        '
        Me.nudDegree.AllowDrop = True
        Me.nudDegree.AutoSize = True
        Me.nudDegree.Location = New System.Drawing.Point(319, 72)
        Me.nudDegree.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudDegree.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDegree.Name = "nudDegree"
        Me.nudDegree.Size = New System.Drawing.Size(44, 20)
        Me.nudDegree.TabIndex = 18
        Me.nudDegree.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(10, 215)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(98, 13)
        Me.lblNewColumnName.TabIndex = 21
        Me.lblNewColumnName.Tag = "New_Column_Name"
        Me.lblNewColumnName.Text = "New Column Name"
        '
        'ucrInputPolynomial
        '
        Me.ucrInputPolynomial.IsReadOnly = False
        Me.ucrInputPolynomial.Location = New System.Drawing.Point(116, 207)
        Me.ucrInputPolynomial.Name = "ucrInputPolynomial"
        Me.ucrInputPolynomial.Size = New System.Drawing.Size(145, 21)
        Me.ucrInputPolynomial.TabIndex = 20
        '
        'ucrSelectorForPolynomial
        '
        Me.ucrSelectorForPolynomial.bShowHiddenColumns = False
        Me.ucrSelectorForPolynomial.bUseCurrentFilter = False
        Me.ucrSelectorForPolynomial.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForPolynomial.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForPolynomial.Name = "ucrSelectorForPolynomial"
        Me.ucrSelectorForPolynomial.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForPolynomial.TabIndex = 19
        '
        'ucrReceiverPolynomial
        '
        Me.ucrReceiverPolynomial.Location = New System.Drawing.Point(255, 41)
        Me.ucrReceiverPolynomial.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPolynomial.Name = "ucrReceiverPolynomial"
        Me.ucrReceiverPolynomial.Selector = Nothing
        Me.ucrReceiverPolynomial.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPolynomial.TabIndex = 16
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 239)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 11
        '
        'dlgPolynomials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 292)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrInputPolynomial)
        Me.Controls.Add(Me.ucrSelectorForPolynomial)
        Me.Controls.Add(Me.nudDegree)
        Me.Controls.Add(Me.ucrReceiverPolynomial)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.lblDegree)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPolynomials"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Polynomial"
        Me.Text = "Polynomial "
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        CType(Me.nudDegree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdoSimple As RadioButton
    Friend WithEvents lblDegree As Label
    Friend WithEvents grpType As GroupBox
    Friend WithEvents rdoOrthogonal As RadioButton
    Friend WithEvents rdoCentered As RadioButton
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblSelected As Label
    Friend WithEvents ucrReceiverPolynomial As ucrReceiverSingle
    Friend WithEvents nudDegree As NumericUpDown
    Friend WithEvents ucrSelectorForPolynomial As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputPolynomial As ucrInputComboBox
    Friend WithEvents lblNewColumnName As Label
End Class
