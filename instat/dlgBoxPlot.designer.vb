<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgBoxPlot
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblYlab = New System.Windows.Forms.Label()
        Me.lblXLabel = New System.Windows.Forms.Label()
        Me.txtYLabel = New System.Windows.Forms.TextBox()
        Me.txtXLabel = New System.Windows.Forms.TextBox()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.lblVariablesToBePlotted = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(35, 200)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Title"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(165, 193)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(208, 20)
        Me.txtTitle.TabIndex = 3
        Me.txtTitle.Tag = ""
        '
        'lblYlab
        '
        Me.lblYlab.AutoSize = True
        Me.lblYlab.Location = New System.Drawing.Point(26, 148)
        Me.lblYlab.Name = "lblYlab"
        Me.lblYlab.Size = New System.Drawing.Size(43, 13)
        Me.lblYlab.TabIndex = 8
        Me.lblYlab.Tag = "YLabel"
        Me.lblYlab.Text = "Y Label"
        '
        'lblXLabel
        '
        Me.lblXLabel.AutoSize = True
        Me.lblXLabel.Location = New System.Drawing.Point(219, 144)
        Me.lblXLabel.Name = "lblXLabel"
        Me.lblXLabel.Size = New System.Drawing.Size(43, 13)
        Me.lblXLabel.TabIndex = 9
        Me.lblXLabel.Tag = "XLabel"
        Me.lblXLabel.Text = "X Label"
        '
        'txtYLabel
        '
        Me.txtYLabel.Location = New System.Drawing.Point(96, 141)
        Me.txtYLabel.Name = "txtYLabel"
        Me.txtYLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtYLabel.TabIndex = 10
        '
        'txtXLabel
        '
        Me.txtXLabel.Location = New System.Drawing.Point(273, 141)
        Me.txtXLabel.Name = "txtXLabel"
        Me.txtXLabel.Size = New System.Drawing.Size(100, 20)
        Me.txtXLabel.TabIndex = 10
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(26, 5)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(186, 129)
        Me.ucrAddRemove.TabIndex = 6
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 219)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 4
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(273, 30)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(121, 69)
        Me.ucrReceiverMultiple.TabIndex = 11
        '
        'lblVariablesToBePlotted
        '
        Me.lblVariablesToBePlotted.AutoSize = True
        Me.lblVariablesToBePlotted.Location = New System.Drawing.Point(270, 5)
        Me.lblVariablesToBePlotted.Name = "lblVariablesToBePlotted"
        Me.lblVariablesToBePlotted.Size = New System.Drawing.Size(112, 13)
        Me.lblVariablesToBePlotted.TabIndex = 12
        Me.lblVariablesToBePlotted.Tag = "Variables_to_be_plotted"
        Me.lblVariablesToBePlotted.Text = "Variables to be plotted"
        '
        'dlgBoxPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 269)
        Me.Controls.Add(Me.lblVariablesToBePlotted)
        Me.Controls.Add(Me.ucrReceiverMultiple)
        Me.Controls.Add(Me.txtXLabel)
        Me.Controls.Add(Me.txtYLabel)
        Me.Controls.Add(Me.lblXLabel)
        Me.Controls.Add(Me.lblYlab)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBoxPlot"
        Me.ShowIcon = False
        Me.Text = "Boxplot"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents lblYlab As Label
    Friend WithEvents lblXLabel As Label
    Friend WithEvents txtYLabel As TextBox
    Friend WithEvents txtXLabel As TextBox
    Friend WithEvents ucrReceiverMultiple As ucrReceiverMultiple
    Friend WithEvents lblVariablesToBePlotted As Label
End Class
