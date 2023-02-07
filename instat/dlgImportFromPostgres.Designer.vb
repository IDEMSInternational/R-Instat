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
        Me.components = New System.ComponentModel.Container()
        Me.ucrBase = New instat.ucrButtons()
        Me.ttRDBMS = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.ucrComboBoxColumns = New instat.ucrInputComboBox()
        Me.ucrComboBoxDatabase = New instat.ucrInputComboBox()
        Me.ucrSelectorForDatabase = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverMultipleColumns = New instat.ucrReceiverMultiple()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.cmdEstablishConnection = New System.Windows.Forms.Button()
        Me.ucrReceiverDatabase = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 296)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 12
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConnection.Location = New System.Drawing.Point(164, 30)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(78, 13)
        Me.lblConnection.TabIndex = 24
        Me.lblConnection.Text = "No Connection"
        '
        'ucrComboBoxColumns
        '
        Me.ucrComboBoxColumns.AddQuotesIfUnrecognised = True
        Me.ucrComboBoxColumns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrComboBoxColumns.GetSetSelectedIndex = -1
        Me.ucrComboBoxColumns.IsReadOnly = False
        Me.ucrComboBoxColumns.Location = New System.Drawing.Point(257, 157)
        Me.ucrComboBoxColumns.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrComboBoxColumns.Name = "ucrComboBoxColumns"
        Me.ucrComboBoxColumns.Size = New System.Drawing.Size(137, 21)
        Me.ucrComboBoxColumns.TabIndex = 22
        '
        'ucrComboBoxDatabase
        '
        Me.ucrComboBoxDatabase.AddQuotesIfUnrecognised = True
        Me.ucrComboBoxDatabase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrComboBoxDatabase.GetSetSelectedIndex = -1
        Me.ucrComboBoxDatabase.IsReadOnly = False
        Me.ucrComboBoxDatabase.Location = New System.Drawing.Point(260, 69)
        Me.ucrComboBoxDatabase.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrComboBoxDatabase.Name = "ucrComboBoxDatabase"
        Me.ucrComboBoxDatabase.Size = New System.Drawing.Size(137, 21)
        Me.ucrComboBoxDatabase.TabIndex = 20
        '
        'ucrSelectorForDatabase
        '
        Me.ucrSelectorForDatabase.AutoSize = True
        Me.ucrSelectorForDatabase.bShowHiddenColumns = False
        Me.ucrSelectorForDatabase.Location = New System.Drawing.Point(14, 63)
        Me.ucrSelectorForDatabase.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDatabase.Name = "ucrSelectorForDatabase"
        Me.ucrSelectorForDatabase.Size = New System.Drawing.Size(216, 147)
        Me.ucrSelectorForDatabase.TabIndex = 18
        '
        'ucrReceiverMultipleColumns
        '
        Me.ucrReceiverMultipleColumns.AutoSize = True
        Me.ucrReceiverMultipleColumns.frmParent = Me
        Me.ucrReceiverMultipleColumns.Location = New System.Drawing.Point(257, 181)
        Me.ucrReceiverMultipleColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleColumns.Name = "ucrReceiverMultipleColumns"
        Me.ucrReceiverMultipleColumns.Selector = Nothing
        Me.ucrReceiverMultipleColumns.Size = New System.Drawing.Size(137, 100)
        Me.ucrReceiverMultipleColumns.strNcFilePath = ""
        Me.ucrReceiverMultipleColumns.TabIndex = 23
        Me.ucrReceiverMultipleColumns.ucrSelector = Nothing
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDatabase.Location = New System.Drawing.Point(260, 54)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(106, 13)
        Me.lblDatabase.TabIndex = 19
        Me.lblDatabase.Text = "Selected Databases:"
        Me.lblDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(259, 141)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(95, 13)
        Me.lblColumns.TabIndex = 21
        Me.lblColumns.Text = "Selected Columns:"
        '
        'cmdEstablishConnection
        '
        Me.cmdEstablishConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEstablishConnection.Location = New System.Drawing.Point(17, 24)
        Me.cmdEstablishConnection.Name = "cmdEstablishConnection"
        Me.cmdEstablishConnection.Size = New System.Drawing.Size(142, 23)
        Me.cmdEstablishConnection.TabIndex = 17
        Me.cmdEstablishConnection.Text = "Establish Connection..."
        Me.cmdEstablishConnection.UseVisualStyleBackColor = True
        '
        'ucrReceiverDatabase
        '
        Me.ucrReceiverDatabase.AutoSize = True
        Me.ucrReceiverDatabase.frmParent = Me
        Me.ucrReceiverDatabase.Location = New System.Drawing.Point(260, 93)
        Me.ucrReceiverDatabase.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDatabase.Name = "ucrReceiverDatabase"
        Me.ucrReceiverDatabase.Selector = Nothing
        Me.ucrReceiverDatabase.Size = New System.Drawing.Size(137, 21)
        Me.ucrReceiverDatabase.strNcFilePath = ""
        Me.ucrReceiverDatabase.TabIndex = 25
        Me.ucrReceiverDatabase.ucrSelector = Nothing
        '
        'dlgImportFromPostgres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 351)
        Me.Controls.Add(Me.ucrReceiverDatabase)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.ucrComboBoxColumns)
        Me.Controls.Add(Me.ucrComboBoxDatabase)
        Me.Controls.Add(Me.ucrSelectorForDatabase)
        Me.Controls.Add(Me.ucrReceiverMultipleColumns)
        Me.Controls.Add(Me.lblDatabase)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.cmdEstablishConnection)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportFromPostgres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import From RDBMS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ttRDBMS As ToolTip
    Friend WithEvents lblConnection As Label
    Friend WithEvents ucrComboBoxColumns As ucrInputComboBox
    Friend WithEvents ucrComboBoxDatabase As ucrInputComboBox
    Friend WithEvents ucrSelectorForDatabase As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverMultipleColumns As ucrReceiverMultiple
    Friend WithEvents lblDatabase As Label
    Friend WithEvents lblColumns As Label
    Friend WithEvents cmdEstablishConnection As Button
    Friend WithEvents ucrReceiverDatabase As ucrReceiverSingle
End Class
