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
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrInputPolynomial = New instat.ucrInputComboBox()
        Me.ucrSelectorForPolynomial = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverPolynomial = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.nudDegree = New instat.ucrNud()
        Me.grpType.SuspendLayout()
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
        Me.rdoSimple.TabIndex = 0
        Me.rdoSimple.Tag = "Simple"
        Me.rdoSimple.Text = "Simple"
        Me.rdoSimple.UseVisualStyleBackColor = True
        '
        'lblDegree
        '
        Me.lblDegree.AutoSize = True
        Me.lblDegree.Location = New System.Drawing.Point(258, 78)
        Me.lblDegree.Name = "lblDegree"
        Me.lblDegree.Size = New System.Drawing.Size(45, 13)
        Me.lblDegree.TabIndex = 3
        Me.lblDegree.Tag = "Degree"
        Me.lblDegree.Text = "Degree:"
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.rdoOrthogonal)
        Me.grpType.Controls.Add(Me.rdoSimple)
        Me.grpType.Controls.Add(Me.rdoCentered)
        Me.grpType.Location = New System.Drawing.Point(258, 100)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(120, 92)
        Me.grpType.TabIndex = 5
        Me.grpType.TabStop = False
        Me.grpType.Tag = "Type"
        Me.grpType.Text = "Type"
        '
        'rdoOrthogonal
        '
        Me.rdoOrthogonal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoOrthogonal.AutoSize = True
        Me.rdoOrthogonal.Location = New System.Drawing.Point(11, 69)
        Me.rdoOrthogonal.Name = "rdoOrthogonal"
        Me.rdoOrthogonal.Size = New System.Drawing.Size(77, 17)
        Me.rdoOrthogonal.TabIndex = 2
        Me.rdoOrthogonal.Tag = "Orthogonal"
        Me.rdoOrthogonal.Text = "Orthogonal"
        Me.rdoOrthogonal.UseVisualStyleBackColor = True
        '
        'rdoCentered
        '
        Me.rdoCentered.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoCentered.AutoSize = True
        Me.rdoCentered.Location = New System.Drawing.Point(11, 44)
        Me.rdoCentered.Name = "rdoCentered"
        Me.rdoCentered.Size = New System.Drawing.Size(68, 17)
        Me.rdoCentered.TabIndex = 1
        Me.rdoCentered.Tag = "Centered"
        Me.rdoCentered.Text = "Centered"
        Me.rdoCentered.UseVisualStyleBackColor = True
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(259, 34)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(93, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Tag = "Selected"
        Me.lblSelected.Text = "Selected Variable:"
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(9, 207)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(101, 13)
        Me.lblNewColumnName.TabIndex = 6
        Me.lblNewColumnName.Tag = "New_Column_Name:"
        Me.lblNewColumnName.Text = "New Column Name:"
        '
        'ucrInputPolynomial
        '
        Me.ucrInputPolynomial.IsReadOnly = False
        Me.ucrInputPolynomial.Location = New System.Drawing.Point(113, 204)
        Me.ucrInputPolynomial.Name = "ucrInputPolynomial"
        Me.ucrInputPolynomial.Size = New System.Drawing.Size(145, 21)
        Me.ucrInputPolynomial.TabIndex = 7
        '
        'ucrSelectorForPolynomial
        '
        Me.ucrSelectorForPolynomial.bShowHiddenColumns = False
        Me.ucrSelectorForPolynomial.bUseCurrentFilter = True
        Me.ucrSelectorForPolynomial.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForPolynomial.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForPolynomial.Name = "ucrSelectorForPolynomial"
        Me.ucrSelectorForPolynomial.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForPolynomial.TabIndex = 0
        '
        'ucrReceiverPolynomial
        '
        Me.ucrReceiverPolynomial.Location = New System.Drawing.Point(258, 49)
        Me.ucrReceiverPolynomial.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPolynomial.Name = "ucrReceiverPolynomial"
        Me.ucrReceiverPolynomial.Selector = Nothing
        Me.ucrReceiverPolynomial.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPolynomial.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 230)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 8
        '
        'nudDegree
        '
        Me.nudDegree.Location = New System.Drawing.Point(309, 76)
        Me.nudDegree.Maximum = 100
        Me.nudDegree.Minimum = 0
        Me.nudDegree.Name = "nudDegree"
        Me.nudDegree.Size = New System.Drawing.Size(50, 20)
        Me.nudDegree.TabIndex = 4
        Me.nudDegree.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgPolynomials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 289)
        Me.Controls.Add(Me.nudDegree)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrInputPolynomial)
        Me.Controls.Add(Me.ucrSelectorForPolynomial)
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
        Me.Tag = "Polynomials"
        Me.Text = "Polynomials"
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
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
    Friend WithEvents ucrSelectorForPolynomial As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputPolynomial As ucrInputComboBox
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents nudDegree As ucrNud
End Class
