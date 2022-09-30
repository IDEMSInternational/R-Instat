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
        Me.cmdGetData = New System.Windows.Forms.Button()
        Me.ucrInputChooseDataset = New instat.ucrInputComboBox()
        Me.ucrInputUsername = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblChooseDataset = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.ucrInputDatabase = New instat.ucrInputTextBox()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.UcrInputHost = New instat.ucrInputTextBox()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.UcrInputPort = New instat.ucrInputTextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdGetData
        '
        Me.cmdGetData.Location = New System.Drawing.Point(34, 197)
        Me.cmdGetData.Name = "cmdGetData"
        Me.cmdGetData.Size = New System.Drawing.Size(121, 23)
        Me.cmdGetData.TabIndex = 9
        Me.cmdGetData.Text = "Get Data"
        Me.cmdGetData.UseVisualStyleBackColor = True
        '
        'ucrInputChooseDataset
        '
        Me.ucrInputChooseDataset.AddQuotesIfUnrecognised = True
        Me.ucrInputChooseDataset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputChooseDataset.GetSetSelectedIndex = -1
        Me.ucrInputChooseDataset.IsReadOnly = False
        Me.ucrInputChooseDataset.Location = New System.Drawing.Point(189, 236)
        Me.ucrInputChooseDataset.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputChooseDataset.Name = "ucrInputChooseDataset"
        Me.ucrInputChooseDataset.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputChooseDataset.TabIndex = 11
        '
        'ucrInputUsername
        '
        Me.ucrInputUsername.AddQuotesIfUnrecognised = True
        Me.ucrInputUsername.AutoSize = True
        Me.ucrInputUsername.IsMultiline = False
        Me.ucrInputUsername.IsReadOnly = False
        Me.ucrInputUsername.Location = New System.Drawing.Point(149, 40)
        Me.ucrInputUsername.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputUsername.Name = "ucrInputUsername"
        Me.ucrInputUsername.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputUsername.TabIndex = 8
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(24, 270)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 12
        '
        'lblChooseDataset
        '
        Me.lblChooseDataset.Location = New System.Drawing.Point(83, 240)
        Me.lblChooseDataset.Name = "lblChooseDataset"
        Me.lblChooseDataset.Size = New System.Drawing.Size(112, 13)
        Me.lblChooseDataset.TabIndex = 10
        Me.lblChooseDataset.Text = "Choose Dataset:"
        '
        'lblUsername
        '
        Me.lblUsername.Location = New System.Drawing.Point(43, 42)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(112, 13)
        Me.lblUsername.TabIndex = 7
        Me.lblUsername.Text = "Username:"
        '
        'ucrInputDatabase
        '
        Me.ucrInputDatabase.AddQuotesIfUnrecognised = True
        Me.ucrInputDatabase.AutoSize = True
        Me.ucrInputDatabase.IsMultiline = False
        Me.ucrInputDatabase.IsReadOnly = False
        Me.ucrInputDatabase.Location = New System.Drawing.Point(149, 77)
        Me.ucrInputDatabase.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputDatabase.Name = "ucrInputDatabase"
        Me.ucrInputDatabase.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputDatabase.TabIndex = 14
        '
        'lblDatabase
        '
        Me.lblDatabase.Location = New System.Drawing.Point(43, 79)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(112, 13)
        Me.lblDatabase.TabIndex = 13
        Me.lblDatabase.Text = "Database:"
        '
        'UcrInputHost
        '
        Me.UcrInputHost.AddQuotesIfUnrecognised = True
        Me.UcrInputHost.AutoSize = True
        Me.UcrInputHost.IsMultiline = False
        Me.UcrInputHost.IsReadOnly = False
        Me.UcrInputHost.Location = New System.Drawing.Point(149, 114)
        Me.UcrInputHost.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcrInputHost.Name = "UcrInputHost"
        Me.UcrInputHost.Size = New System.Drawing.Size(167, 21)
        Me.UcrInputHost.TabIndex = 16
        '
        'lblHost
        '
        Me.lblHost.Location = New System.Drawing.Point(43, 116)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(112, 13)
        Me.lblHost.TabIndex = 15
        Me.lblHost.Text = "Host:"
        '
        'UcrInputPort
        '
        Me.UcrInputPort.AddQuotesIfUnrecognised = True
        Me.UcrInputPort.AutoSize = True
        Me.UcrInputPort.IsMultiline = False
        Me.UcrInputPort.IsReadOnly = False
        Me.UcrInputPort.Location = New System.Drawing.Point(149, 151)
        Me.UcrInputPort.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcrInputPort.Name = "UcrInputPort"
        Me.UcrInputPort.Size = New System.Drawing.Size(167, 21)
        Me.UcrInputPort.TabIndex = 18
        '
        'lblPort
        '
        Me.lblPort.Location = New System.Drawing.Point(43, 153)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(112, 13)
        Me.lblPort.TabIndex = 17
        Me.lblPort.Text = "Port:"
        '
        'dlgImportFromPostgres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 327)
        Me.Controls.Add(Me.UcrInputPort)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.UcrInputHost)
        Me.Controls.Add(Me.lblHost)
        Me.Controls.Add(Me.ucrInputDatabase)
        Me.Controls.Add(Me.lblDatabase)
        Me.Controls.Add(Me.cmdGetData)
        Me.Controls.Add(Me.ucrInputChooseDataset)
        Me.Controls.Add(Me.ucrInputUsername)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblChooseDataset)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "dlgImportFromPostgres"
        Me.Text = "dlgImportFromPostgres"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdGetData As Button
    Friend WithEvents ucrInputChooseDataset As ucrInputComboBox
    Friend WithEvents ucrInputUsername As ucrInputTextBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblChooseDataset As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents ucrInputDatabase As ucrInputTextBox
    Friend WithEvents lblDatabase As Label
    Friend WithEvents UcrInputHost As ucrInputTextBox
    Friend WithEvents lblHost As Label
    Friend WithEvents UcrInputPort As ucrInputTextBox
    Friend WithEvents lblPort As Label
End Class
