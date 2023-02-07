<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgImportfromRDBMS
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
        Me.ucrComboBoxPort = New instat.ucrInputComboBox()
        Me.ucrTxtHost = New instat.ucrInputTextBox()
        Me.ucrComboBoxDatabaseName = New instat.ucrInputComboBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.chkRememberCredentials = New System.Windows.Forms.CheckBox()
        Me.ucrBaseSdgDatabase = New instat.ucrButtonsSubdialogue()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.ucrTxtUserName = New instat.ucrInputTextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.lblDatabaseName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrComboBoxPort
        '
        Me.ucrComboBoxPort.AddQuotesIfUnrecognised = False
        Me.ucrComboBoxPort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrComboBoxPort.GetSetSelectedIndex = -1
        Me.ucrComboBoxPort.IsReadOnly = False
        Me.ucrComboBoxPort.Location = New System.Drawing.Point(104, 73)
        Me.ucrComboBoxPort.Name = "ucrComboBoxPort"
        Me.ucrComboBoxPort.Size = New System.Drawing.Size(153, 21)
        Me.ucrComboBoxPort.TabIndex = 13
        '
        'ucrTxtHost
        '
        Me.ucrTxtHost.AddQuotesIfUnrecognised = True
        Me.ucrTxtHost.AutoSize = True
        Me.ucrTxtHost.IsMultiline = False
        Me.ucrTxtHost.IsReadOnly = False
        Me.ucrTxtHost.Location = New System.Drawing.Point(104, 45)
        Me.ucrTxtHost.Name = "ucrTxtHost"
        Me.ucrTxtHost.Size = New System.Drawing.Size(153, 21)
        Me.ucrTxtHost.TabIndex = 11
        '
        'ucrComboBoxDatabaseName
        '
        Me.ucrComboBoxDatabaseName.AddQuotesIfUnrecognised = True
        Me.ucrComboBoxDatabaseName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrComboBoxDatabaseName.GetSetSelectedIndex = -1
        Me.ucrComboBoxDatabaseName.IsReadOnly = False
        Me.ucrComboBoxDatabaseName.Location = New System.Drawing.Point(104, 17)
        Me.ucrComboBoxDatabaseName.Name = "ucrComboBoxDatabaseName"
        Me.ucrComboBoxDatabaseName.Size = New System.Drawing.Size(153, 21)
        Me.ucrComboBoxDatabaseName.TabIndex = 10
        '
        'btnConnect
        '
        Me.btnConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConnect.Location = New System.Drawing.Point(105, 148)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(76, 22)
        Me.btnConnect.TabIndex = 17
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'chkRememberCredentials
        '
        Me.chkRememberCredentials.AutoSize = True
        Me.chkRememberCredentials.Checked = True
        Me.chkRememberCredentials.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRememberCredentials.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkRememberCredentials.Location = New System.Drawing.Point(104, 125)
        Me.chkRememberCredentials.Name = "chkRememberCredentials"
        Me.chkRememberCredentials.Size = New System.Drawing.Size(132, 17)
        Me.chkRememberCredentials.TabIndex = 16
        Me.chkRememberCredentials.Text = "Remember Credentials"
        Me.chkRememberCredentials.UseVisualStyleBackColor = True
        '
        'ucrBaseSdgDatabase
        '
        Me.ucrBaseSdgDatabase.AutoSize = True
        Me.ucrBaseSdgDatabase.Location = New System.Drawing.Point(23, 188)
        Me.ucrBaseSdgDatabase.Name = "ucrBaseSdgDatabase"
        Me.ucrBaseSdgDatabase.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseSdgDatabase.TabIndex = 19
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnection.Location = New System.Drawing.Point(186, 153)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(78, 13)
        Me.lblConnection.TabIndex = 20
        Me.lblConnection.Text = "No Connection"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUserName.Location = New System.Drawing.Point(37, 102)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(58, 13)
        Me.lblUserName.TabIndex = 18
        Me.lblUserName.Text = "Username:"
        '
        'ucrTxtUserName
        '
        Me.ucrTxtUserName.AddQuotesIfUnrecognised = True
        Me.ucrTxtUserName.AutoSize = True
        Me.ucrTxtUserName.IsMultiline = False
        Me.ucrTxtUserName.IsReadOnly = False
        Me.ucrTxtUserName.Location = New System.Drawing.Point(104, 98)
        Me.ucrTxtUserName.Name = "ucrTxtUserName"
        Me.ucrTxtUserName.Size = New System.Drawing.Size(153, 21)
        Me.ucrTxtUserName.TabIndex = 14
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPort.Location = New System.Drawing.Point(66, 76)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(29, 13)
        Me.lblPort.TabIndex = 15
        Me.lblPort.Text = "Port:"
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHost.Location = New System.Drawing.Point(63, 49)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(32, 13)
        Me.lblHost.TabIndex = 12
        Me.lblHost.Text = "Host:"
        '
        'lblDatabaseName
        '
        Me.lblDatabaseName.AutoSize = True
        Me.lblDatabaseName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDatabaseName.Location = New System.Drawing.Point(13, 20)
        Me.lblDatabaseName.Name = "lblDatabaseName"
        Me.lblDatabaseName.Size = New System.Drawing.Size(87, 13)
        Me.lblDatabaseName.TabIndex = 9
        Me.lblDatabaseName.Text = "Database Name:"
        '
        'sdgImportfromRDBMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 234)
        Me.Controls.Add(Me.ucrComboBoxPort)
        Me.Controls.Add(Me.ucrTxtHost)
        Me.Controls.Add(Me.ucrComboBoxDatabaseName)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.chkRememberCredentials)
        Me.Controls.Add(Me.ucrBaseSdgDatabase)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.ucrTxtUserName)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lblHost)
        Me.Controls.Add(Me.lblDatabaseName)
        Me.Name = "sdgImportfromRDBMS"
        Me.Text = "ImportfromRDBS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrComboBoxPort As ucrInputComboBox
    Friend WithEvents ucrTxtHost As ucrInputTextBox
    Friend WithEvents ucrComboBoxDatabaseName As ucrInputComboBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents chkRememberCredentials As CheckBox
    Friend WithEvents ucrBaseSdgDatabase As ucrButtonsSubdialogue
    Friend WithEvents lblConnection As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents ucrTxtUserName As ucrInputTextBox
    Friend WithEvents lblPort As Label
    Friend WithEvents lblHost As Label
    Friend WithEvents lblDatabaseName As Label
End Class
