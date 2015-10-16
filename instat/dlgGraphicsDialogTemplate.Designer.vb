<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgGraphicsDialogTemplate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgGraphicsDialogTemplate))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblPlotTitle = New System.Windows.Forms.Label()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(72, 323)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(306, 20)
        Me.TextBox1.TabIndex = 41
        '
        'lblPlotTitle
        '
        Me.lblPlotTitle.AutoSize = True
        Me.lblPlotTitle.Location = New System.Drawing.Point(9, 326)
        Me.lblPlotTitle.Name = "lblPlotTitle"
        Me.lblPlotTitle.Size = New System.Drawing.Size(48, 13)
        Me.lblPlotTitle.TabIndex = 40
        Me.lblPlotTitle.Tag = "Plot_Title"
        Me.lblPlotTitle.Text = "Plot Title"
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(38, 372)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 39
        Me.cmdOk.Tag = "Ok"
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(200, 372)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 38
        Me.btnCancel.Tag = "Cancel"
        Me.btnCancel.Text = "Cancel "
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(119, 372)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdReset.TabIndex = 37
        Me.cmdReset.Tag = "Reset"
        Me.cmdReset.Text = "Reset "
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(281, 372)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdHelp.TabIndex = 36
        Me.cmdHelp.Tag = "Help"
        Me.cmdHelp.Text = "Help "
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 362)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Splitter1.Size = New System.Drawing.Size(390, 43)
        Me.Splitter1.TabIndex = 35
        Me.Splitter1.TabStop = False
        '
        'dlgGraphicsDialogTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 405)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblPlotTitle)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.Splitter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgGraphicsDialogTemplate"
        Me.Text = "Graphics Dialog Template"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblPlotTitle As Label
    Friend WithEvents cmdOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents cmdReset As Button
    Friend WithEvents cmdHelp As Button
    Friend WithEvents Splitter1 As Splitter
End Class
