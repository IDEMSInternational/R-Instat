<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrOtherStyles
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblFormats = New System.Windows.Forms.Label()
        Me.btnClearStyles = New System.Windows.Forms.Button()
        Me.btnEnterStyle = New System.Windows.Forms.Button()
        Me.dataGridStyles = New System.Windows.Forms.DataGridView()
        Me.colLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStyles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dataGridStyles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboLocation
        '
        Me.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Items.AddRange(New Object() {"Foot Notes", "Souce Notes"})
        Me.cboLocation.Location = New System.Drawing.Point(7, 20)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(127, 21)
        Me.cboLocation.TabIndex = 311
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLocation.Location = New System.Drawing.Point(5, 3)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(84, 13)
        Me.lblLocation.TabIndex = 310
        Me.lblLocation.Text = "Select Location:"
        '
        'lblFormats
        '
        Me.lblFormats.AutoSize = True
        Me.lblFormats.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFormats.Location = New System.Drawing.Point(5, 83)
        Me.lblFormats.Name = "lblFormats"
        Me.lblFormats.Size = New System.Drawing.Size(38, 13)
        Me.lblFormats.TabIndex = 330
        Me.lblFormats.Text = "Styles:"
        '
        'btnClearStyles
        '
        Me.btnClearStyles.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClearStyles.Location = New System.Drawing.Point(244, 74)
        Me.btnClearStyles.Name = "btnClearStyles"
        Me.btnClearStyles.Size = New System.Drawing.Size(75, 23)
        Me.btnClearStyles.TabIndex = 328
        Me.btnClearStyles.Tag = ""
        Me.btnClearStyles.Text = "Clear"
        Me.btnClearStyles.UseVisualStyleBackColor = True
        '
        'btnEnterStyle
        '
        Me.btnEnterStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnEnterStyle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEnterStyle.Location = New System.Drawing.Point(8, 50)
        Me.btnEnterStyle.Name = "btnEnterStyle"
        Me.btnEnterStyle.Size = New System.Drawing.Size(126, 23)
        Me.btnEnterStyle.TabIndex = 327
        Me.btnEnterStyle.Tag = ""
        Me.btnEnterStyle.Text = "Enter Style"
        Me.btnEnterStyle.UseVisualStyleBackColor = True
        '
        'dataGridStyles
        '
        Me.dataGridStyles.AllowUserToAddRows = False
        Me.dataGridStyles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridStyles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLocation, Me.colStyles})
        Me.dataGridStyles.Location = New System.Drawing.Point(8, 100)
        Me.dataGridStyles.Name = "dataGridStyles"
        Me.dataGridStyles.RowHeadersWidth = 62
        Me.dataGridStyles.Size = New System.Drawing.Size(315, 73)
        Me.dataGridStyles.TabIndex = 329
        '
        'colLocation
        '
        Me.colLocation.HeaderText = "Location"
        Me.colLocation.Name = "colLocation"
        '
        'colStyles
        '
        Me.colStyles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colStyles.HeaderText = "Style Expressions"
        Me.colStyles.MinimumWidth = 8
        Me.colStyles.Name = "colStyles"
        '
        'ucrOtherStyles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblFormats)
        Me.Controls.Add(Me.btnClearStyles)
        Me.Controls.Add(Me.btnEnterStyle)
        Me.Controls.Add(Me.dataGridStyles)
        Me.Controls.Add(Me.cboLocation)
        Me.Controls.Add(Me.lblLocation)
        Me.Name = "ucrOtherStyles"
        Me.Size = New System.Drawing.Size(326, 179)
        CType(Me.dataGridStyles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboLocation As ComboBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblFormats As Label
    Friend WithEvents btnClearStyles As Button
    Friend WithEvents btnEnterStyle As Button
    Friend WithEvents dataGridStyles As DataGridView
    Friend WithEvents colLocation As DataGridViewTextBoxColumn
    Friend WithEvents colStyles As DataGridViewTextBoxColumn
End Class
