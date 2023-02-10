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
        Me.ucrCboPort = New instat.ucrInputComboBox()
        Me.ucrTxtHost = New instat.ucrInputTextBox()
        Me.ucrCboName = New instat.ucrInputComboBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.chkRememberCredentials = New System.Windows.Forms.CheckBox()
        Me.ucrBaseSdgDatabase = New instat.ucrButtonsSubdialogue()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.ucrTxtUserName = New instat.ucrInputTextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.lblDatabaseName = New System.Windows.Forms.Label()
        Me.ucrCboType = New instat.ucrInputComboBox()
        Me.lblDataBaseType = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrCboPort
        '
        Me.ucrCboPort.AddQuotesIfUnrecognised = False
        Me.ucrCboPort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboPort.GetSetSelectedIndex = -1
        Me.ucrCboPort.IsReadOnly = False
        Me.ucrCboPort.Location = New System.Drawing.Point(104, 109)
        Me.ucrCboPort.Name = "ucrCboPort"
        Me.ucrCboPort.Size = New System.Drawing.Size(153, 21)
        Me.ucrCboPort.TabIndex = 13
        '
        'ucrTxtHost
        '
        Me.ucrTxtHost.AddQuotesIfUnrecognised = True
        Me.ucrTxtHost.AutoSize = True
        Me.ucrTxtHost.IsMultiline = False
        Me.ucrTxtHost.IsReadOnly = False
        Me.ucrTxtHost.Location = New System.Drawing.Point(104, 81)
        Me.ucrTxtHost.Name = "ucrTxtHost"
        Me.ucrTxtHost.Size = New System.Drawing.Size(153, 21)
        Me.ucrTxtHost.TabIndex = 11
        '
        'ucrCboName
        '
        Me.ucrCboName.AddQuotesIfUnrecognised = True
        Me.ucrCboName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboName.GetSetSelectedIndex = -1
        Me.ucrCboName.IsReadOnly = False
        Me.ucrCboName.Location = New System.Drawing.Point(104, 53)
        Me.ucrCboName.Name = "ucrCboName"
        Me.ucrCboName.Size = New System.Drawing.Size(153, 21)
        Me.ucrCboName.TabIndex = 10
        '
        'btnConnect
        '
        Me.btnConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConnect.Location = New System.Drawing.Point(105, 191)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(76, 22)
        Me.btnConnect.TabIndex = 17
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'chkRememberCredentials
        '
        Me.chkRememberCredentials.AutoSize = True
        Me.chkRememberCredentials.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkRememberCredentials.Location = New System.Drawing.Point(104, 161)
        Me.chkRememberCredentials.Name = "chkRememberCredentials"
        Me.chkRememberCredentials.Size = New System.Drawing.Size(132, 17)
        Me.chkRememberCredentials.TabIndex = 16
        Me.chkRememberCredentials.Text = "Remember Credentials"
        Me.chkRememberCredentials.UseVisualStyleBackColor = True
        '
        'ucrBaseSdgDatabase
        '
        Me.ucrBaseSdgDatabase.AutoSize = True
        Me.ucrBaseSdgDatabase.Location = New System.Drawing.Point(23, 224)
        Me.ucrBaseSdgDatabase.Name = "ucrBaseSdgDatabase"
        Me.ucrBaseSdgDatabase.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseSdgDatabase.TabIndex = 19
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnection.Location = New System.Drawing.Point(186, 196)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(78, 13)
        Me.lblConnection.TabIndex = 20
        Me.lblConnection.Text = "No Connection"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUserName.Location = New System.Drawing.Point(37, 138)
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
        Me.ucrTxtUserName.Location = New System.Drawing.Point(104, 134)
        Me.ucrTxtUserName.Name = "ucrTxtUserName"
        Me.ucrTxtUserName.Size = New System.Drawing.Size(153, 21)
        Me.ucrTxtUserName.TabIndex = 14
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPort.Location = New System.Drawing.Point(66, 112)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(29, 13)
        Me.lblPort.TabIndex = 15
        Me.lblPort.Text = "Port:"
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHost.Location = New System.Drawing.Point(63, 85)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(32, 13)
        Me.lblHost.TabIndex = 12
        Me.lblHost.Text = "Host:"
        '
        'lblDatabaseName
        '
        Me.lblDatabaseName.AutoSize = True
        Me.lblDatabaseName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDatabaseName.Location = New System.Drawing.Point(58, 56)
        Me.lblDatabaseName.Name = "lblDatabaseName"
        Me.lblDatabaseName.Size = New System.Drawing.Size(38, 13)
        Me.lblDatabaseName.TabIndex = 9
        Me.lblDatabaseName.Text = "Name:"
        '
        'ucrCboType
        '
        Me.ucrCboType.AddQuotesIfUnrecognised = True
        Me.ucrCboType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboType.GetSetSelectedIndex = -1
        Me.ucrCboType.IsReadOnly = False
        Me.ucrCboType.Location = New System.Drawing.Point(104, 20)
        Me.ucrCboType.Name = "ucrCboType"
        Me.ucrCboType.Size = New System.Drawing.Size(153, 21)
        Me.ucrCboType.TabIndex = 22
        '
        'lblDataBaseType
        '
        Me.lblDataBaseType.AutoSize = True
        Me.lblDataBaseType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataBaseType.Location = New System.Drawing.Point(58, 23)
        Me.lblDataBaseType.Name = "lblDataBaseType"
        Me.lblDataBaseType.Size = New System.Drawing.Size(34, 13)
        Me.lblDataBaseType.TabIndex = 21
        Me.lblDataBaseType.Text = "Type:"
        '
        'sdgImportfromRDBMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 264)
        Me.Controls.Add(Me.ucrCboType)
        Me.Controls.Add(Me.lblDataBaseType)
        Me.Controls.Add(Me.ucrCboPort)
        Me.Controls.Add(Me.ucrTxtHost)
        Me.Controls.Add(Me.ucrCboName)
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
        Me.Text = "Import from RDBMS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrCboPort As ucrInputComboBox
    Friend WithEvents ucrTxtHost As ucrInputTextBox
    Friend WithEvents ucrCboName As ucrInputComboBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents chkRememberCredentials As CheckBox
    Friend WithEvents ucrBaseSdgDatabase As ucrButtonsSubdialogue
    Friend WithEvents lblConnection As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents ucrTxtUserName As ucrInputTextBox
    Friend WithEvents lblPort As Label
    Friend WithEvents lblHost As Label
    Friend WithEvents lblDatabaseName As Label
    Friend WithEvents ucrCboType As ucrInputComboBox
    Friend WithEvents lblDataBaseType As Label
End Class
