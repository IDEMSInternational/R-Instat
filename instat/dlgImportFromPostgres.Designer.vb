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
        Me.ucrSelectorForDatabase = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverColumns = New instat.ucrReceiverMultiple()
        Me.lblTables = New System.Windows.Forms.Label()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.cmdEstablishConnection = New System.Windows.Forms.Button()
        Me.ucrReceiverTable = New instat.ucrReceiverSingle()
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
        'ucrReceiverColumns
        '
        Me.ucrReceiverColumns.AutoSize = True
        Me.ucrReceiverColumns.frmParent = Me
        Me.ucrReceiverColumns.Location = New System.Drawing.Point(257, 142)
        Me.ucrReceiverColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumns.Name = "ucrReceiverColumns"
        Me.ucrReceiverColumns.Selector = Nothing
        Me.ucrReceiverColumns.Size = New System.Drawing.Size(137, 100)
        Me.ucrReceiverColumns.strNcFilePath = ""
        Me.ucrReceiverColumns.TabIndex = 23
        Me.ucrReceiverColumns.ucrSelector = Nothing
        '
        'lblTables
        '
        Me.lblTables.AutoSize = True
        Me.lblTables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTables.Location = New System.Drawing.Point(260, 54)
        Me.lblTables.Name = "lblTables"
        Me.lblTables.Size = New System.Drawing.Size(87, 13)
        Me.lblTables.TabIndex = 19
        Me.lblTables.Text = "Selected Tables:"
        Me.lblTables.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(259, 122)
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
        'ucrReceiverTable
        '
        Me.ucrReceiverTable.AutoSize = True
        Me.ucrReceiverTable.frmParent = Me
        Me.ucrReceiverTable.Location = New System.Drawing.Point(257, 75)
        Me.ucrReceiverTable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTable.Name = "ucrReceiverTable"
        Me.ucrReceiverTable.Selector = Nothing
        Me.ucrReceiverTable.Size = New System.Drawing.Size(137, 21)
        Me.ucrReceiverTable.strNcFilePath = ""
        Me.ucrReceiverTable.TabIndex = 25
        Me.ucrReceiverTable.ucrSelector = Nothing
        '
        'dlgImportFromPostgres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 351)
        Me.Controls.Add(Me.ucrReceiverTable)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.ucrSelectorForDatabase)
        Me.Controls.Add(Me.ucrReceiverColumns)
        Me.Controls.Add(Me.lblTables)
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
    Friend WithEvents ucrSelectorForDatabase As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverColumns As ucrReceiverMultiple
    Friend WithEvents lblTables As Label
    Friend WithEvents lblColumns As Label
    Friend WithEvents cmdEstablishConnection As Button
    Friend WithEvents ucrReceiverTable As ucrReceiverSingle
End Class
