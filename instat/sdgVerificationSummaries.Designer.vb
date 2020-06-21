<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgVerificationSummaries
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
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.tbSummaries = New System.Windows.Forms.TabControl()
        Me.tbContinuous = New System.Windows.Forms.TabPage()
        Me.ucrContinuousVerification = New instat.ucrContinuousVerification()
        Me.tbBinary = New System.Windows.Forms.TabPage()
        Me.UcrCheck9 = New instat.ucrCheck()
        Me.UcrCheck8 = New instat.ucrCheck()
        Me.UcrCheck7 = New instat.ucrCheck()
        Me.UcrCheck6 = New instat.ucrCheck()
        Me.tbCategorical = New System.Windows.Forms.TabPage()
        Me.UcrCheck13 = New instat.ucrCheck()
        Me.UcrCheck12 = New instat.ucrCheck()
        Me.UcrCheck11 = New instat.ucrCheck()
        Me.UcrCheck10 = New instat.ucrCheck()
        Me.tbSummaries.SuspendLayout()
        Me.tbContinuous.SuspendLayout()
        Me.tbBinary.SuspendLayout()
        Me.tbCategorical.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(161, 323)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(154, 30)
        Me.ucrBase.TabIndex = 0
        '
        'tbSummaries
        '
        Me.tbSummaries.Controls.Add(Me.tbContinuous)
        Me.tbSummaries.Controls.Add(Me.tbBinary)
        Me.tbSummaries.Controls.Add(Me.tbCategorical)
        Me.tbSummaries.Location = New System.Drawing.Point(12, 12)
        Me.tbSummaries.Name = "tbSummaries"
        Me.tbSummaries.SelectedIndex = 0
        Me.tbSummaries.Size = New System.Drawing.Size(443, 305)
        Me.tbSummaries.TabIndex = 1
        '
        'tbContinuous
        '
        Me.tbContinuous.Controls.Add(Me.ucrContinuousVerification)
        Me.tbContinuous.Location = New System.Drawing.Point(4, 22)
        Me.tbContinuous.Name = "tbContinuous"
        Me.tbContinuous.Padding = New System.Windows.Forms.Padding(3)
        Me.tbContinuous.Size = New System.Drawing.Size(435, 279)
        Me.tbContinuous.TabIndex = 0
        Me.tbContinuous.Text = "Continuous"
        Me.tbContinuous.UseVisualStyleBackColor = True
        '
        'ucrContinuousVerification
        '
        Me.ucrContinuousVerification.Location = New System.Drawing.Point(-1, 6)
        Me.ucrContinuousVerification.Name = "ucrContinuousVerification"
        Me.ucrContinuousVerification.Size = New System.Drawing.Size(430, 265)
        Me.ucrContinuousVerification.TabIndex = 0
        '
        'tbBinary
        '
        Me.tbBinary.Controls.Add(Me.UcrCheck9)
        Me.tbBinary.Controls.Add(Me.UcrCheck8)
        Me.tbBinary.Controls.Add(Me.UcrCheck7)
        Me.tbBinary.Controls.Add(Me.UcrCheck6)
        Me.tbBinary.Location = New System.Drawing.Point(4, 22)
        Me.tbBinary.Name = "tbBinary"
        Me.tbBinary.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBinary.Size = New System.Drawing.Size(435, 279)
        Me.tbBinary.TabIndex = 1
        Me.tbBinary.Text = "Binary"
        Me.tbBinary.UseVisualStyleBackColor = True
        '
        'UcrCheck9
        '
        Me.UcrCheck9.Checked = False
        Me.UcrCheck9.Location = New System.Drawing.Point(6, 20)
        Me.UcrCheck9.Name = "UcrCheck9"
        Me.UcrCheck9.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck9.TabIndex = 4
        '
        'UcrCheck8
        '
        Me.UcrCheck8.Checked = False
        Me.UcrCheck8.Location = New System.Drawing.Point(6, 46)
        Me.UcrCheck8.Name = "UcrCheck8"
        Me.UcrCheck8.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck8.TabIndex = 3
        '
        'UcrCheck7
        '
        Me.UcrCheck7.Checked = False
        Me.UcrCheck7.Location = New System.Drawing.Point(127, 20)
        Me.UcrCheck7.Name = "UcrCheck7"
        Me.UcrCheck7.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck7.TabIndex = 2
        '
        'UcrCheck6
        '
        Me.UcrCheck6.Checked = False
        Me.UcrCheck6.Location = New System.Drawing.Point(127, 46)
        Me.UcrCheck6.Name = "UcrCheck6"
        Me.UcrCheck6.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck6.TabIndex = 1
        '
        'tbCategorical
        '
        Me.tbCategorical.Controls.Add(Me.UcrCheck13)
        Me.tbCategorical.Controls.Add(Me.UcrCheck12)
        Me.tbCategorical.Controls.Add(Me.UcrCheck11)
        Me.tbCategorical.Controls.Add(Me.UcrCheck10)
        Me.tbCategorical.Location = New System.Drawing.Point(4, 22)
        Me.tbCategorical.Name = "tbCategorical"
        Me.tbCategorical.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCategorical.Size = New System.Drawing.Size(435, 279)
        Me.tbCategorical.TabIndex = 2
        Me.tbCategorical.Text = "Categorical"
        Me.tbCategorical.UseVisualStyleBackColor = True
        '
        'UcrCheck13
        '
        Me.UcrCheck13.Checked = False
        Me.UcrCheck13.Location = New System.Drawing.Point(6, 18)
        Me.UcrCheck13.Name = "UcrCheck13"
        Me.UcrCheck13.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck13.TabIndex = 4
        '
        'UcrCheck12
        '
        Me.UcrCheck12.Checked = False
        Me.UcrCheck12.Location = New System.Drawing.Point(6, 44)
        Me.UcrCheck12.Name = "UcrCheck12"
        Me.UcrCheck12.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck12.TabIndex = 3
        '
        'UcrCheck11
        '
        Me.UcrCheck11.Checked = False
        Me.UcrCheck11.Location = New System.Drawing.Point(127, 18)
        Me.UcrCheck11.Name = "UcrCheck11"
        Me.UcrCheck11.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck11.TabIndex = 2
        '
        'UcrCheck10
        '
        Me.UcrCheck10.Checked = False
        Me.UcrCheck10.Location = New System.Drawing.Point(127, 44)
        Me.UcrCheck10.Name = "UcrCheck10"
        Me.UcrCheck10.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck10.TabIndex = 1
        '
        'sdgVerificationSummaries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 356)
        Me.Controls.Add(Me.tbSummaries)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgVerificationSummaries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summaries"
        Me.tbSummaries.ResumeLayout(False)
        Me.tbContinuous.ResumeLayout(False)
        Me.tbBinary.ResumeLayout(False)
        Me.tbCategorical.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents tbSummaries As TabControl
    Friend WithEvents tbContinuous As TabPage
    Friend WithEvents tbBinary As TabPage
    Friend WithEvents tbCategorical As TabPage
    Friend WithEvents UcrCheck9 As ucrCheck
    Friend WithEvents UcrCheck8 As ucrCheck
    Friend WithEvents UcrCheck7 As ucrCheck
    Friend WithEvents UcrCheck6 As ucrCheck
    Friend WithEvents UcrCheck13 As ucrCheck
    Friend WithEvents UcrCheck12 As ucrCheck
    Friend WithEvents UcrCheck11 As ucrCheck
    Friend WithEvents UcrCheck10 As ucrCheck
    Friend WithEvents ucrContinuousVerification As ucrContinuousVerification
End Class
