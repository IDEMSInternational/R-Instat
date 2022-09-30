<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgImportFromPostgres
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

        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.ucrInputUsername = New instat.ucrInputTextBox()
        Me.ucrInputDatabase = New instat.ucrInputTextBox()
        Me.ucrInputHost = New instat.ucrInputTextBox()
        Me.ucrInputPort = New instat.ucrInputTextBox()
        Me.lblChooseDataset = New System.Windows.Forms.Label()
        Me.ucrInputChooseDataset = New instat.ucrInputComboBox()
        Me.cmdGetData = New System.Windows.Forms.Button()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.Location = New System.Drawing.Point(43, 33)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(112, 13)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username:"
        '
        'lblDatabase
        '
        Me.lblDatabase.Location = New System.Drawing.Point(43, 60)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(112, 13)
        Me.lblDatabase.TabIndex = 3
        Me.lblDatabase.Text = "Database:"
        '
        'lblHost
        '
        Me.lblHost.Location = New System.Drawing.Point(43, 94)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(112, 13)
        Me.lblHost.TabIndex = 4
        Me.lblHost.Text = "Host:"
        '
        'lblPort
        '
        Me.lblPort.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPort.Location = New System.Drawing.Point(43, 130)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(112, 13)
        Me.lblPort.TabIndex = 5
        Me.lblPort.Text = "Port:"
        '
        'ucrInputUsername
        '
        Me.ucrInputUsername.AddQuotesIfUnrecognised = True
        Me.ucrInputUsername.AutoSize = True
        Me.ucrInputUsername.IsMultiline = False
        Me.ucrInputUsername.IsReadOnly = False
        Me.ucrInputUsername.Location = New System.Drawing.Point(164, 25)
        Me.ucrInputUsername.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputUsername.Name = "ucrInputUsername"
        Me.ucrInputUsername.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputUsername.TabIndex = 7
        '
        'ucrInputDatabase
        '
        Me.ucrInputDatabase.AddQuotesIfUnrecognised = True
        Me.ucrInputDatabase.AutoSize = True
        Me.ucrInputDatabase.IsMultiline = False
        Me.ucrInputDatabase.IsReadOnly = False
        Me.ucrInputDatabase.Location = New System.Drawing.Point(164, 57)
        Me.ucrInputDatabase.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputDatabase.Name = "ucrInputDatabase"
        Me.ucrInputDatabase.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputDatabase.TabIndex = 8
        '
        'ucrInputHost
        '
        Me.ucrInputHost.AddQuotesIfUnrecognised = True
        Me.ucrInputHost.AutoSize = True
        Me.ucrInputHost.IsMultiline = False
        Me.ucrInputHost.IsReadOnly = False
        Me.ucrInputHost.Location = New System.Drawing.Point(164, 91)
        Me.ucrInputHost.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputHost.Name = "ucrInputHost"
        Me.ucrInputHost.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputHost.TabIndex = 9
        '
        'ucrInputPort
        '
        Me.ucrInputPort.AddQuotesIfUnrecognised = True
        Me.ucrInputPort.AutoSize = True
        Me.ucrInputPort.IsMultiline = False
        Me.ucrInputPort.IsReadOnly = False
        Me.ucrInputPort.Location = New System.Drawing.Point(164, 126)
        Me.ucrInputPort.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputPort.Name = "ucrInputPort"
        Me.ucrInputPort.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputPort.TabIndex = 10
        '
        'lblChooseDataset
        '
        Me.lblChooseDataset.Location = New System.Drawing.Point(98, 220)
        Me.lblChooseDataset.Name = "lblChooseDataset"
        Me.lblChooseDataset.Size = New System.Drawing.Size(112, 13)
        Me.lblChooseDataset.TabIndex = 12
        Me.lblChooseDataset.Text = "Choose Dataset:"
        '
        'ucrInputChooseDataset
        '
        Me.ucrInputChooseDataset.AddQuotesIfUnrecognised = True
        Me.ucrInputChooseDataset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputChooseDataset.GetSetSelectedIndex = -1
        Me.ucrInputChooseDataset.IsReadOnly = False
        Me.ucrInputChooseDataset.Location = New System.Drawing.Point(194, 216)
        Me.ucrInputChooseDataset.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputChooseDataset.Name = "ucrInputChooseDataset"
        Me.ucrInputChooseDataset.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputChooseDataset.TabIndex = 13
        '
        'cmdGetData
        '
        Me.cmdGetData.Location = New System.Drawing.Point(50, 171)
        Me.cmdGetData.Name = "cmdGetData"
        Me.cmdGetData.Size = New System.Drawing.Size(121, 23)
        Me.cmdGetData.TabIndex = 14
        Me.cmdGetData.Text = "Get Data"
        Me.cmdGetData.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(23, 274)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 15
        '

        Me.SuspendLayout()
        '

        'dlgImportFromPostgres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font

        Me.ClientSize = New System.Drawing.Size(451, 339)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.cmdGetData)
        Me.Controls.Add(Me.ucrInputChooseDataset)
        Me.Controls.Add(Me.lblChooseDataset)
        Me.Controls.Add(Me.ucrInputPort)
        Me.Controls.Add(Me.ucrInputHost)
        Me.Controls.Add(Me.ucrInputDatabase)
        Me.Controls.Add(Me.ucrInputUsername)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lblHost)
        Me.Controls.Add(Me.lblDatabase)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "dlgImportFromPostgres"
        Me.Text = "dlgImportFromPostgres"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblDatabase As Label
    Friend WithEvents lblHost As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents ucrInputUsername As ucrInputTextBox
    Friend WithEvents ucrInputDatabase As ucrInputTextBox
    Friend WithEvents ucrInputHost As ucrInputTextBox
    Friend WithEvents ucrInputPort As ucrInputTextBox
    Friend WithEvents ucrInputChooseDataset As ucrInputComboBox
    Friend WithEvents cmdGetData As Button
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblChooseDataset As Label

        Me.ClientSize = New System.Drawing.Size(395, 450)
        Me.Name = "dlgImportFromPostgres"
        Me.Text = "dlgImportFromPostgres"
        Me.ResumeLayout(False)

    End Sub

End Class
