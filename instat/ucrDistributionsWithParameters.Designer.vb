<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrDistributionsWithParameters
    Inherits instat.ucrDistributions

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblDistributionParameters = New System.Windows.Forms.Label()
        Me.lblParameter1 = New System.Windows.Forms.Label()
        Me.lblParameter2 = New System.Windows.Forms.Label()
        Me.lblParameter3 = New System.Windows.Forms.Label()
        Me.txtParameter1 = New System.Windows.Forms.TextBox()
        Me.txtParameter2 = New System.Windows.Forms.TextBox()
        Me.txtParameter3 = New System.Windows.Forms.TextBox()
        Me.txtParameter4 = New System.Windows.Forms.TextBox()
        Me.lblParameter4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDistributionParameters
        '
        Me.lblDistributionParameters.AutoSize = True
        Me.lblDistributionParameters.Location = New System.Drawing.Point(6, 45)
        Me.lblDistributionParameters.Name = "lblDistributionParameters"
        Me.lblDistributionParameters.Size = New System.Drawing.Size(118, 13)
        Me.lblDistributionParameters.TabIndex = 2
        Me.lblDistributionParameters.Tag = "distribution_parameters:"
        Me.lblDistributionParameters.Text = "Distribution Parameters:"
        '
        'lblParameter1
        '
        Me.lblParameter1.AutoSize = True
        Me.lblParameter1.Location = New System.Drawing.Point(9, 76)
        Me.lblParameter1.Name = "lblParameter1"
        Me.lblParameter1.Size = New System.Drawing.Size(0, 13)
        Me.lblParameter1.TabIndex = 3
        '
        'lblParameter2
        '
        Me.lblParameter2.AutoSize = True
        Me.lblParameter2.Location = New System.Drawing.Point(9, 105)
        Me.lblParameter2.Name = "lblParameter2"
        Me.lblParameter2.Size = New System.Drawing.Size(0, 13)
        Me.lblParameter2.TabIndex = 4
        '
        'lblParameter3
        '
        Me.lblParameter3.AutoSize = True
        Me.lblParameter3.Location = New System.Drawing.Point(9, 135)
        Me.lblParameter3.Name = "lblParameter3"
        Me.lblParameter3.Size = New System.Drawing.Size(0, 13)
        Me.lblParameter3.TabIndex = 5
        '
        'txtParameter1
        '
        Me.txtParameter1.Location = New System.Drawing.Point(95, 73)
        Me.txtParameter1.Name = "txtParameter1"
        Me.txtParameter1.Size = New System.Drawing.Size(100, 20)
        Me.txtParameter1.TabIndex = 6
        '
        'txtParameter2
        '
        Me.txtParameter2.Location = New System.Drawing.Point(95, 102)
        Me.txtParameter2.Name = "txtParameter2"
        Me.txtParameter2.Size = New System.Drawing.Size(100, 20)
        Me.txtParameter2.TabIndex = 7
        '
        'txtParameter3
        '
        Me.txtParameter3.Location = New System.Drawing.Point(95, 132)
        Me.txtParameter3.Name = "txtParameter3"
        Me.txtParameter3.Size = New System.Drawing.Size(100, 20)
        Me.txtParameter3.TabIndex = 8
        '
        'txtParameter4
        '
        Me.txtParameter4.Location = New System.Drawing.Point(95, 158)
        Me.txtParameter4.Name = "txtParameter4"
        Me.txtParameter4.Size = New System.Drawing.Size(100, 20)
        Me.txtParameter4.TabIndex = 10
        '
        'lblParameter4
        '
        Me.lblParameter4.AutoSize = True
        Me.lblParameter4.Location = New System.Drawing.Point(9, 165)
        Me.lblParameter4.Name = "lblParameter4"
        Me.lblParameter4.Size = New System.Drawing.Size(0, 13)
        Me.lblParameter4.TabIndex = 9
        '
        'ucrDistributionsWithParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtParameter4)
        Me.Controls.Add(Me.lblParameter4)
        Me.Controls.Add(Me.txtParameter3)
        Me.Controls.Add(Me.txtParameter2)
        Me.Controls.Add(Me.txtParameter1)
        Me.Controls.Add(Me.lblParameter3)
        Me.Controls.Add(Me.lblParameter2)
        Me.Controls.Add(Me.lblParameter1)
        Me.Controls.Add(Me.lblDistributionParameters)
        Me.Name = "ucrDistributionsWithParameters"
        Me.Size = New System.Drawing.Size(221, 194)
        Me.Controls.SetChildIndex(Me.lblDistributionParameters, 0)
        Me.Controls.SetChildIndex(Me.lblParameter1, 0)
        Me.Controls.SetChildIndex(Me.lblParameter2, 0)
        Me.Controls.SetChildIndex(Me.lblParameter3, 0)
        Me.Controls.SetChildIndex(Me.txtParameter1, 0)
        Me.Controls.SetChildIndex(Me.txtParameter2, 0)
        Me.Controls.SetChildIndex(Me.txtParameter3, 0)
        Me.Controls.SetChildIndex(Me.lblParameter4, 0)
        Me.Controls.SetChildIndex(Me.txtParameter4, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDistributionParameters As Label
    Friend WithEvents lblParameter1 As Label
    Friend WithEvents lblParameter2 As Label
    Friend WithEvents lblParameter3 As Label
    Friend WithEvents txtParameter1 As TextBox
    Friend WithEvents txtParameter2 As TextBox
    Friend WithEvents txtParameter3 As TextBox
    Friend WithEvents txtParameter4 As TextBox
    Friend WithEvents lblParameter4 As Label
End Class
