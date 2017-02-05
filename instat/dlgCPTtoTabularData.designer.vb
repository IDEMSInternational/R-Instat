<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCPTtoTabularData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpDomain = New System.Windows.Forms.GroupBox()
        Me.lblMaxLon = New System.Windows.Forms.Label()
        Me.lblMinLon = New System.Windows.Forms.Label()
        Me.lblMaxLat = New System.Windows.Forms.Label()
        Me.lblMinLat = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkWestEast = New instat.ucrCheck()
        Me.ucrNudMaxLong = New instat.ucrNud()
        Me.ucrNudMinLat = New instat.ucrNud()
        Me.ucrNudMaxLat = New instat.ucrNud()
        Me.ucrNudMinLong = New instat.ucrNud()
        Me.grpDomain.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDomain
        '
        Me.grpDomain.Controls.Add(Me.ucrNudMinLong)
        Me.grpDomain.Controls.Add(Me.ucrNudMaxLat)
        Me.grpDomain.Controls.Add(Me.ucrNudMinLat)
        Me.grpDomain.Controls.Add(Me.ucrNudMaxLong)
        Me.grpDomain.Controls.Add(Me.lblMaxLon)
        Me.grpDomain.Controls.Add(Me.lblMinLon)
        Me.grpDomain.Controls.Add(Me.lblMaxLat)
        Me.grpDomain.Controls.Add(Me.lblMinLat)
        Me.grpDomain.Location = New System.Drawing.Point(10, 34)
        Me.grpDomain.Name = "grpDomain"
        Me.grpDomain.Size = New System.Drawing.Size(203, 139)
        Me.grpDomain.TabIndex = 1
        Me.grpDomain.TabStop = False
        Me.grpDomain.Tag = "Domain"
        Me.grpDomain.Text = "Domain"
        '
        'lblMaxLon
        '
        Me.lblMaxLon.AutoSize = True
        Me.lblMaxLon.Location = New System.Drawing.Point(8, 109)
        Me.lblMaxLon.Name = "lblMaxLon"
        Me.lblMaxLon.Size = New System.Drawing.Size(104, 13)
        Me.lblMaxLon.TabIndex = 7
        Me.lblMaxLon.Tag = "Maximum_Logitude"
        Me.lblMaxLon.Text = "Maximum Longitude:"
        '
        'lblMinLon
        '
        Me.lblMinLon.AutoSize = True
        Me.lblMinLon.Location = New System.Drawing.Point(8, 83)
        Me.lblMinLon.Name = "lblMinLon"
        Me.lblMinLon.Size = New System.Drawing.Size(101, 13)
        Me.lblMinLon.TabIndex = 6
        Me.lblMinLon.Tag = "Minimum_Longitude"
        Me.lblMinLon.Text = "Minimum Longitude:"
        '
        'lblMaxLat
        '
        Me.lblMaxLat.AutoSize = True
        Me.lblMaxLat.Location = New System.Drawing.Point(8, 57)
        Me.lblMaxLat.Name = "lblMaxLat"
        Me.lblMaxLat.Size = New System.Drawing.Size(95, 13)
        Me.lblMaxLat.TabIndex = 5
        Me.lblMaxLat.Tag = "Maximum_Latitude"
        Me.lblMaxLat.Text = "Maximum Latitude:"
        '
        'lblMinLat
        '
        Me.lblMinLat.AutoSize = True
        Me.lblMinLat.Location = New System.Drawing.Point(8, 30)
        Me.lblMinLat.Name = "lblMinLat"
        Me.lblMinLat.Size = New System.Drawing.Size(92, 13)
        Me.lblMinLat.TabIndex = 4
        Me.lblMinLat.Tag = "Minimum_Latitude"
        Me.lblMinLat.Text = "Minimum Latitude:"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(249, 88)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(86, 13)
        Me.lbl.TabIndex = 8
        Me.lbl.Tag = ""
        Me.lbl.Text = "Not implemented"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 213)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 60)
        Me.ucrBase.TabIndex = 0
        '
        'ucrChkWestEast
        '
        Me.ucrChkWestEast.bAddRemoveParameter = True
        Me.ucrChkWestEast.bChangeParameterValue = True
        Me.ucrChkWestEast.Checked = False
        Me.ucrChkWestEast.Location = New System.Drawing.Point(10, 187)
        Me.ucrChkWestEast.Name = "ucrChkWestEast"
        Me.ucrChkWestEast.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkWestEast.TabIndex = 9
        '
        'ucrNudMaxLong
        '
        Me.ucrNudMaxLong.bAddRemoveParameter = True
        Me.ucrNudMaxLong.bChangeParameterValue = True
        Me.ucrNudMaxLong.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLong.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxLong.Location = New System.Drawing.Point(118, 106)
        Me.ucrNudMaxLong.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxLong.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLong.Name = "ucrNudMaxLong"
        Me.ucrNudMaxLong.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxLong.TabIndex = 8
        Me.ucrNudMaxLong.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMinLat
        '
        Me.ucrNudMinLat.bAddRemoveParameter = True
        Me.ucrNudMinLat.bChangeParameterValue = True
        Me.ucrNudMinLat.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLat.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinLat.Location = New System.Drawing.Point(118, 28)
        Me.ucrNudMinLat.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinLat.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLat.Name = "ucrNudMinLat"
        Me.ucrNudMinLat.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinLat.TabIndex = 9
        Me.ucrNudMinLat.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaxLat
        '
        Me.ucrNudMaxLat.bAddRemoveParameter = True
        Me.ucrNudMaxLat.bChangeParameterValue = True
        Me.ucrNudMaxLat.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLat.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxLat.Location = New System.Drawing.Point(118, 54)
        Me.ucrNudMaxLat.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxLat.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLat.Name = "ucrNudMaxLat"
        Me.ucrNudMaxLat.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxLat.TabIndex = 10
        Me.ucrNudMaxLat.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMinLong
        '
        Me.ucrNudMinLong.bAddRemoveParameter = True
        Me.ucrNudMinLong.bChangeParameterValue = True
        Me.ucrNudMinLong.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLong.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinLong.Location = New System.Drawing.Point(118, 80)
        Me.ucrNudMinLong.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinLong.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLong.Name = "ucrNudMinLong"
        Me.ucrNudMinLong.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinLong.TabIndex = 11
        Me.ucrNudMinLong.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgCPTtoTabularData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 276)
        Me.Controls.Add(Me.ucrChkWestEast)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.grpDomain)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCPTtoTabularData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CPT_to_Tabular_Data"
        Me.Text = "CPT to Tabular Data"
        Me.grpDomain.ResumeLayout(False)
        Me.grpDomain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpDomain As GroupBox
    Friend WithEvents lblMaxLon As Label
    Friend WithEvents lblMinLon As Label
    Friend WithEvents lblMaxLat As Label
    Friend WithEvents lblMinLat As Label
    Friend WithEvents lbl As Label
    Friend WithEvents ucrChkWestEast As ucrCheck
    Friend WithEvents ucrNudMinLong As ucrNud
    Friend WithEvents ucrNudMaxLat As ucrNud
    Friend WithEvents ucrNudMinLat As ucrNud
    Friend WithEvents ucrNudMaxLong As ucrNud
End Class