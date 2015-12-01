<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgOutputforCDT
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
        Me.ucrBase = New instat.ucrButtons()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.lblInterestedVariables = New System.Windows.Forms.Label()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.txtInterestedVariables = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(24, 229)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data list not implemented"
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.Location = New System.Drawing.Point(21, 64)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(39, 13)
        Me.lblFilename.TabIndex = 2
        Me.lblFilename.Tag = "Filename"
        Me.lblFilename.Text = "Label2"
        '
        'lblInterestedVariables
        '
        Me.lblInterestedVariables.AutoSize = True
        Me.lblInterestedVariables.Location = New System.Drawing.Point(21, 140)
        Me.lblInterestedVariables.Name = "lblInterestedVariables"
        Me.lblInterestedVariables.Size = New System.Drawing.Size(39, 13)
        Me.lblInterestedVariables.TabIndex = 3
        Me.lblInterestedVariables.Tag = "Interested_Variables"
        Me.lblInterestedVariables.Text = "Label3"
        '
        'txtFilename
        '
        Me.txtFilename.Location = New System.Drawing.Point(125, 61)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(197, 20)
        Me.txtFilename.TabIndex = 4
        '
        'txtInterestedVariables
        '
        Me.txtInterestedVariables.Location = New System.Drawing.Point(125, 133)
        Me.txtInterestedVariables.Name = "txtInterestedVariables"
        Me.txtInterestedVariables.Size = New System.Drawing.Size(197, 20)
        Me.txtInterestedVariables.TabIndex = 5
        Me.txtInterestedVariables.Tag = ""
        '
        'dlgOutputforCDT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 262)
        Me.Controls.Add(Me.txtInterestedVariables)
        Me.Controls.Add(Me.txtFilename)
        Me.Controls.Add(Me.lblInterestedVariables)
        Me.Controls.Add(Me.lblFilename)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOutputforCDT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Output_for_CDT"
        Me.Text = "Output for CDT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFilename As Label
    Friend WithEvents lblInterestedVariables As Label
    Friend WithEvents txtFilename As TextBox
    Friend WithEvents txtInterestedVariables As TextBox
End Class
