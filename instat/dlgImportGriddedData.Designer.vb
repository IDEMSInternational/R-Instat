<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgImportGriddedData
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
        Me.ucrNudMinLat = New instat.ucrNud()
        Me.ucrNudMinLon = New instat.ucrNud()
        Me.ucrNudMaxLon = New instat.ucrNud()
        Me.ucrNudMaxLat = New instat.ucrNud()
        Me.lblMinLat = New System.Windows.Forms.Label()
        Me.lblMaxLat = New System.Windows.Forms.Label()
        Me.lblMinLon = New System.Windows.Forms.Label()
        Me.lblMaxLon = New System.Windows.Forms.Label()
        Me.lblDataName = New System.Windows.Forms.Label()
        Me.ucrInputDataName = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 197)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(402, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrNudMinLat
        '
        Me.ucrNudMinLat.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLat.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinLat.Location = New System.Drawing.Point(115, 89)
        Me.ucrNudMinLat.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinLat.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLat.Name = "ucrNudMinLat"
        Me.ucrNudMinLat.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinLat.TabIndex = 2
        Me.ucrNudMinLat.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMinLon
        '
        Me.ucrNudMinLon.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLon.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinLon.Location = New System.Drawing.Point(115, 120)
        Me.ucrNudMinLon.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinLon.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLon.Name = "ucrNudMinLon"
        Me.ucrNudMinLon.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinLon.TabIndex = 3
        Me.ucrNudMinLon.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaxLon
        '
        Me.ucrNudMaxLon.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLon.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxLon.Location = New System.Drawing.Point(304, 127)
        Me.ucrNudMaxLon.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxLon.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLon.Name = "ucrNudMaxLon"
        Me.ucrNudMaxLon.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxLon.TabIndex = 4
        Me.ucrNudMaxLon.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaxLat
        '
        Me.ucrNudMaxLat.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLat.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxLat.Location = New System.Drawing.Point(304, 96)
        Me.ucrNudMaxLat.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxLat.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLat.Name = "ucrNudMaxLat"
        Me.ucrNudMaxLat.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxLat.TabIndex = 5
        Me.ucrNudMaxLat.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMinLat
        '
        Me.lblMinLat.AutoSize = True
        Me.lblMinLat.Location = New System.Drawing.Point(12, 89)
        Me.lblMinLat.Name = "lblMinLat"
        Me.lblMinLat.Size = New System.Drawing.Size(89, 13)
        Me.lblMinLat.TabIndex = 6
        Me.lblMinLat.Text = "Minimum Latitude"
        '
        'lblMaxLat
        '
        Me.lblMaxLat.AutoSize = True
        Me.lblMaxLat.Location = New System.Drawing.Point(177, 96)
        Me.lblMaxLat.Name = "lblMaxLat"
        Me.lblMaxLat.Size = New System.Drawing.Size(92, 13)
        Me.lblMaxLat.TabIndex = 7
        Me.lblMaxLat.Text = "Maximum Latitude"
        '
        'lblMinLon
        '
        Me.lblMinLon.AutoSize = True
        Me.lblMinLon.Location = New System.Drawing.Point(7, 127)
        Me.lblMinLon.Name = "lblMinLon"
        Me.lblMinLon.Size = New System.Drawing.Size(98, 13)
        Me.lblMinLon.TabIndex = 8
        Me.lblMinLon.Text = "Minimum Longitude"
        '
        'lblMaxLon
        '
        Me.lblMaxLon.AutoSize = True
        Me.lblMaxLon.Location = New System.Drawing.Point(177, 127)
        Me.lblMaxLon.Name = "lblMaxLon"
        Me.lblMaxLon.Size = New System.Drawing.Size(101, 13)
        Me.lblMaxLon.TabIndex = 9
        Me.lblMaxLon.Text = "Maximum Longitude"
        '
        'lblDataName
        '
        Me.lblDataName.AutoSize = True
        Me.lblDataName.Location = New System.Drawing.Point(45, 21)
        Me.lblDataName.Name = "lblDataName"
        Me.lblDataName.Size = New System.Drawing.Size(64, 13)
        Me.lblDataName.TabIndex = 10
        Me.lblDataName.Text = "Data Name:"
        '
        'ucrInputDataName
        '
        Me.ucrInputDataName.AddQuotesIfUnrecognised = True
        Me.ucrInputDataName.IsMultiline = False
        Me.ucrInputDataName.IsReadOnly = False
        Me.ucrInputDataName.Location = New System.Drawing.Point(115, 21)
        Me.ucrInputDataName.Name = "ucrInputDataName"
        Me.ucrInputDataName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDataName.TabIndex = 11
        '
        'dlgImportGriddedData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 261)
        Me.Controls.Add(Me.ucrInputDataName)
        Me.Controls.Add(Me.lblDataName)
        Me.Controls.Add(Me.lblMaxLon)
        Me.Controls.Add(Me.lblMinLon)
        Me.Controls.Add(Me.lblMaxLat)
        Me.Controls.Add(Me.lblMinLat)
        Me.Controls.Add(Me.ucrNudMaxLat)
        Me.Controls.Add(Me.ucrNudMaxLon)
        Me.Controls.Add(Me.ucrNudMinLon)
        Me.Controls.Add(Me.ucrNudMinLat)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportGriddedData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Gridded Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrNudMinLat As ucrNud
    Friend WithEvents ucrNudMinLon As ucrNud
    Friend WithEvents ucrNudMaxLon As ucrNud
    Friend WithEvents ucrNudMaxLat As ucrNud
    Friend WithEvents lblMinLat As Label
    Friend WithEvents lblMaxLat As Label
    Friend WithEvents lblMinLon As Label
    Friend WithEvents lblMaxLon As Label
    Friend WithEvents lblDataName As Label
    Friend WithEvents ucrInputDataName As ucrInputTextBox
End Class
