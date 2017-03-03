<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgImportFromClimSoft
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
        Me.ucrInputDatabaseName = New instat.ucrInputTextBox()
        Me.lblDatabaseName = New System.Windows.Forms.Label()
        Me.ucrInputHost = New instat.ucrInputTextBox()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.ucrInputPart = New instat.ucrInputTextBox()
        Me.lblPart = New System.Windows.Forms.Label()
        Me.ucrInputUserName = New instat.ucrInputTextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.ucrBaseSdgClimSoft = New instat.ucrButtonsSubdialogue()
        Me.cmdEnterPassword = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrInputDatabaseName
        '
        Me.ucrInputDatabaseName.AddQuotesIfUnrecognised = True
        Me.ucrInputDatabaseName.IsMultiline = False
        Me.ucrInputDatabaseName.IsReadOnly = False
        Me.ucrInputDatabaseName.Location = New System.Drawing.Point(101, 12)
        Me.ucrInputDatabaseName.Name = "ucrInputDatabaseName"
        Me.ucrInputDatabaseName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDatabaseName.TabIndex = 1
        '
        'lblDatabaseName
        '
        Me.lblDatabaseName.AutoSize = True
        Me.lblDatabaseName.Location = New System.Drawing.Point(10, 15)
        Me.lblDatabaseName.Name = "lblDatabaseName"
        Me.lblDatabaseName.Size = New System.Drawing.Size(87, 13)
        Me.lblDatabaseName.TabIndex = 0
        Me.lblDatabaseName.Text = "Database Name:"
        '
        'ucrInputHost
        '
        Me.ucrInputHost.AddQuotesIfUnrecognised = True
        Me.ucrInputHost.IsMultiline = False
        Me.ucrInputHost.IsReadOnly = False
        Me.ucrInputHost.Location = New System.Drawing.Point(101, 46)
        Me.ucrInputHost.Name = "ucrInputHost"
        Me.ucrInputHost.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputHost.TabIndex = 3
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.Location = New System.Drawing.Point(10, 50)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(32, 13)
        Me.lblHost.TabIndex = 2
        Me.lblHost.Text = "Host:"
        '
        'ucrInputPart
        '
        Me.ucrInputPart.AddQuotesIfUnrecognised = True
        Me.ucrInputPart.IsMultiline = False
        Me.ucrInputPart.IsReadOnly = False
        Me.ucrInputPart.Location = New System.Drawing.Point(101, 80)
        Me.ucrInputPart.Name = "ucrInputPart"
        Me.ucrInputPart.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPart.TabIndex = 5
        '
        'lblPart
        '
        Me.lblPart.AutoSize = True
        Me.lblPart.Location = New System.Drawing.Point(10, 85)
        Me.lblPart.Name = "lblPart"
        Me.lblPart.Size = New System.Drawing.Size(29, 13)
        Me.lblPart.TabIndex = 4
        Me.lblPart.Text = "Part:"
        '
        'ucrInputUserName
        '
        Me.ucrInputUserName.AddQuotesIfUnrecognised = True
        Me.ucrInputUserName.IsMultiline = False
        Me.ucrInputUserName.IsReadOnly = False
        Me.ucrInputUserName.Location = New System.Drawing.Point(101, 114)
        Me.ucrInputUserName.Name = "ucrInputUserName"
        Me.ucrInputUserName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputUserName.TabIndex = 7
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(10, 119)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(58, 13)
        Me.lblUserName.TabIndex = 6
        Me.lblUserName.Text = "Username:"
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.Location = New System.Drawing.Point(162, 148)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(78, 13)
        Me.lblConnection.TabIndex = 9
        Me.lblConnection.Text = "No Connection"
        '
        'ucrBaseSdgClimSoft
        '
        Me.ucrBaseSdgClimSoft.Location = New System.Drawing.Point(72, 178)
        Me.ucrBaseSdgClimSoft.Name = "ucrBaseSdgClimSoft"
        Me.ucrBaseSdgClimSoft.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSdgClimSoft.TabIndex = 10
        '
        'cmdEnterPassword
        '
        Me.cmdEnterPassword.Location = New System.Drawing.Point(10, 148)
        Me.cmdEnterPassword.Name = "cmdEnterPassword"
        Me.cmdEnterPassword.Size = New System.Drawing.Size(107, 22)
        Me.cmdEnterPassword.TabIndex = 8
        Me.cmdEnterPassword.Text = "Enter Password"
        Me.cmdEnterPassword.UseVisualStyleBackColor = True
        '
        'sdgImportFromClimSoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 220)
        Me.Controls.Add(Me.ucrBaseSdgClimSoft)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.cmdEnterPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.ucrInputUserName)
        Me.Controls.Add(Me.lblPart)
        Me.Controls.Add(Me.ucrInputPart)
        Me.Controls.Add(Me.lblHost)
        Me.Controls.Add(Me.ucrInputHost)
        Me.Controls.Add(Me.lblDatabaseName)
        Me.Controls.Add(Me.ucrInputDatabaseName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgImportFromClimSoft"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connect To ClimSoft Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputDatabaseName As ucrInputTextBox
    Friend WithEvents lblDatabaseName As Label
    Friend WithEvents ucrInputHost As ucrInputTextBox
    Friend WithEvents lblHost As Label
    Friend WithEvents ucrInputPart As ucrInputTextBox
    Friend WithEvents lblPart As Label
    Friend WithEvents ucrInputUserName As ucrInputTextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblConnection As Label
    Friend WithEvents ucrBaseSdgClimSoft As ucrButtonsSubdialogue
    Friend WithEvents cmdEnterPassword As Button
End Class
