<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgOpenNetCDF
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
        Me.ucrInputMinLong = New instat.ucrInputTextBox()
        Me.ucrInputMinLat = New instat.ucrInputTextBox()
        Me.ucrInputMinZ = New instat.ucrInputTextBox()
        Me.ucrInputMinTime = New instat.ucrInputTextBox()
        Me.ucrInputMaxLong = New instat.ucrInputTextBox()
        Me.ucrInputMaxLat = New instat.ucrInputTextBox()
        Me.ucrInputMaxZ = New instat.ucrInputTextBox()
        Me.ucrInputMaxTime = New instat.ucrInputTextBox()
        Me.ucrInputFileDetails = New instat.ucrInputTextBox()
        Me.lblMinimumLongitude = New System.Windows.Forms.Label()
        Me.lblMinimumLatitude = New System.Windows.Forms.Label()
        Me.lblMinZ = New System.Windows.Forms.Label()
        Me.lblMinTime = New System.Windows.Forms.Label()
        Me.lblMaxTime = New System.Windows.Forms.Label()
        Me.lblMaxZ = New System.Windows.Forms.Label()
        Me.lblMaxLatitude = New System.Windows.Forms.Label()
        Me.lblMaxLongitude = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrInputMinLong
        '
        Me.ucrInputMinLong.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLong.IsMultiline = False
        Me.ucrInputMinLong.IsReadOnly = False
        Me.ucrInputMinLong.Location = New System.Drawing.Point(106, 200)
        Me.ucrInputMinLong.Name = "ucrInputMinLong"
        Me.ucrInputMinLong.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMinLong.TabIndex = 22
        '
        'ucrInputMinLat
        '
        Me.ucrInputMinLat.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLat.IsMultiline = False
        Me.ucrInputMinLat.IsReadOnly = False
        Me.ucrInputMinLat.Location = New System.Drawing.Point(106, 227)
        Me.ucrInputMinLat.Name = "ucrInputMinLat"
        Me.ucrInputMinLat.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMinLat.TabIndex = 21
        '
        'ucrInputMinZ
        '
        Me.ucrInputMinZ.AddQuotesIfUnrecognised = True
        Me.ucrInputMinZ.IsMultiline = False
        Me.ucrInputMinZ.IsReadOnly = False
        Me.ucrInputMinZ.Location = New System.Drawing.Point(106, 254)
        Me.ucrInputMinZ.Name = "ucrInputMinZ"
        Me.ucrInputMinZ.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMinZ.TabIndex = 20
        '
        'ucrInputMinTime
        '
        Me.ucrInputMinTime.AddQuotesIfUnrecognised = True
        Me.ucrInputMinTime.IsMultiline = False
        Me.ucrInputMinTime.IsReadOnly = False
        Me.ucrInputMinTime.Location = New System.Drawing.Point(106, 281)
        Me.ucrInputMinTime.Name = "ucrInputMinTime"
        Me.ucrInputMinTime.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMinTime.TabIndex = 19
        '
        'ucrInputMaxLong
        '
        Me.ucrInputMaxLong.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLong.IsMultiline = False
        Me.ucrInputMaxLong.IsReadOnly = False
        Me.ucrInputMaxLong.Location = New System.Drawing.Point(271, 200)
        Me.ucrInputMaxLong.Name = "ucrInputMaxLong"
        Me.ucrInputMaxLong.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMaxLong.TabIndex = 18
        '
        'ucrInputMaxLat
        '
        Me.ucrInputMaxLat.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLat.IsMultiline = False
        Me.ucrInputMaxLat.IsReadOnly = False
        Me.ucrInputMaxLat.Location = New System.Drawing.Point(271, 227)
        Me.ucrInputMaxLat.Name = "ucrInputMaxLat"
        Me.ucrInputMaxLat.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMaxLat.TabIndex = 17
        '
        'ucrInputMaxZ
        '
        Me.ucrInputMaxZ.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxZ.IsMultiline = False
        Me.ucrInputMaxZ.IsReadOnly = False
        Me.ucrInputMaxZ.Location = New System.Drawing.Point(271, 254)
        Me.ucrInputMaxZ.Name = "ucrInputMaxZ"
        Me.ucrInputMaxZ.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMaxZ.TabIndex = 16
        '
        'ucrInputMaxTime
        '
        Me.ucrInputMaxTime.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxTime.IsMultiline = False
        Me.ucrInputMaxTime.IsReadOnly = False
        Me.ucrInputMaxTime.Location = New System.Drawing.Point(271, 281)
        Me.ucrInputMaxTime.Name = "ucrInputMaxTime"
        Me.ucrInputMaxTime.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMaxTime.TabIndex = 15
        '
        'ucrInputFileDetails
        '
        Me.ucrInputFileDetails.AddQuotesIfUnrecognised = True
        Me.ucrInputFileDetails.IsMultiline = True
        Me.ucrInputFileDetails.IsReadOnly = True
        Me.ucrInputFileDetails.Location = New System.Drawing.Point(7, 35)
        Me.ucrInputFileDetails.Name = "ucrInputFileDetails"
        Me.ucrInputFileDetails.Size = New System.Drawing.Size(320, 159)
        Me.ucrInputFileDetails.TabIndex = 14
        '
        'lblMinimumLongitude
        '
        Me.lblMinimumLongitude.AutoSize = True
        Me.lblMinimumLongitude.Location = New System.Drawing.Point(4, 203)
        Me.lblMinimumLongitude.Name = "lblMinimumLongitude"
        Me.lblMinimumLongitude.Size = New System.Drawing.Size(101, 13)
        Me.lblMinimumLongitude.TabIndex = 23
        Me.lblMinimumLongitude.Text = "Minimum Longitude:"
        '
        'lblMinimumLatitude
        '
        Me.lblMinimumLatitude.AutoSize = True
        Me.lblMinimumLatitude.Location = New System.Drawing.Point(4, 230)
        Me.lblMinimumLatitude.Name = "lblMinimumLatitude"
        Me.lblMinimumLatitude.Size = New System.Drawing.Size(92, 13)
        Me.lblMinimumLatitude.TabIndex = 24
        Me.lblMinimumLatitude.Text = "Minimum Latitude:"
        '
        'lblMinZ
        '
        Me.lblMinZ.AutoSize = True
        Me.lblMinZ.Location = New System.Drawing.Point(4, 257)
        Me.lblMinZ.Name = "lblMinZ"
        Me.lblMinZ.Size = New System.Drawing.Size(61, 13)
        Me.lblMinZ.TabIndex = 25
        Me.lblMinZ.Text = "Minimum Z:"
        '
        'lblMinTime
        '
        Me.lblMinTime.AutoSize = True
        Me.lblMinTime.Location = New System.Drawing.Point(4, 284)
        Me.lblMinTime.Name = "lblMinTime"
        Me.lblMinTime.Size = New System.Drawing.Size(77, 13)
        Me.lblMinTime.TabIndex = 26
        Me.lblMinTime.Text = "Minimum Time:"
        '
        'lblMaxTime
        '
        Me.lblMaxTime.AutoSize = True
        Me.lblMaxTime.Location = New System.Drawing.Point(164, 284)
        Me.lblMaxTime.Name = "lblMaxTime"
        Me.lblMaxTime.Size = New System.Drawing.Size(80, 13)
        Me.lblMaxTime.TabIndex = 30
        Me.lblMaxTime.Text = "Maximum Time:"
        '
        'lblMaxZ
        '
        Me.lblMaxZ.AutoSize = True
        Me.lblMaxZ.Location = New System.Drawing.Point(164, 257)
        Me.lblMaxZ.Name = "lblMaxZ"
        Me.lblMaxZ.Size = New System.Drawing.Size(64, 13)
        Me.lblMaxZ.TabIndex = 29
        Me.lblMaxZ.Text = "Maximum Z:"
        '
        'lblMaxLatitude
        '
        Me.lblMaxLatitude.AutoSize = True
        Me.lblMaxLatitude.Location = New System.Drawing.Point(164, 230)
        Me.lblMaxLatitude.Name = "lblMaxLatitude"
        Me.lblMaxLatitude.Size = New System.Drawing.Size(95, 13)
        Me.lblMaxLatitude.TabIndex = 28
        Me.lblMaxLatitude.Text = "Maximum Latitude:"
        '
        'lblMaxLongitude
        '
        Me.lblMaxLongitude.AutoSize = True
        Me.lblMaxLongitude.Location = New System.Drawing.Point(164, 203)
        Me.lblMaxLongitude.Name = "lblMaxLongitude"
        Me.lblMaxLongitude.Size = New System.Drawing.Size(104, 13)
        Me.lblMaxLongitude.TabIndex = 27
        Me.lblMaxLongitude.Text = "Maximum Longitude:"
        '
        'sdgOpenNetCDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 306)
        Me.Controls.Add(Me.lblMaxTime)
        Me.Controls.Add(Me.lblMaxZ)
        Me.Controls.Add(Me.lblMaxLatitude)
        Me.Controls.Add(Me.lblMaxLongitude)
        Me.Controls.Add(Me.lblMinTime)
        Me.Controls.Add(Me.lblMinZ)
        Me.Controls.Add(Me.lblMinimumLatitude)
        Me.Controls.Add(Me.lblMinimumLongitude)
        Me.Controls.Add(Me.ucrInputMinLong)
        Me.Controls.Add(Me.ucrInputMinLat)
        Me.Controls.Add(Me.ucrInputMinZ)
        Me.Controls.Add(Me.ucrInputMinTime)
        Me.Controls.Add(Me.ucrInputMaxLong)
        Me.Controls.Add(Me.ucrInputMaxLat)
        Me.Controls.Add(Me.ucrInputMaxZ)
        Me.Controls.Add(Me.ucrInputMaxTime)
        Me.Controls.Add(Me.ucrInputFileDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOpenNetCDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "NetCDF Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputFileDetails As ucrInputTextBox
    Friend WithEvents ucrInputMaxTime As ucrInputTextBox
    Friend WithEvents ucrInputMaxZ As ucrInputTextBox
    Friend WithEvents ucrInputMaxLat As ucrInputTextBox
    Friend WithEvents ucrInputMaxLong As ucrInputTextBox
    Friend WithEvents ucrInputMinTime As ucrInputTextBox
    Friend WithEvents ucrInputMinZ As ucrInputTextBox
    Friend WithEvents ucrInputMinLat As ucrInputTextBox
    Friend WithEvents ucrInputMinLong As ucrInputTextBox
    Friend WithEvents lblMinimumLongitude As Label
    Friend WithEvents lblMinimumLatitude As Label
    Friend WithEvents lblMinZ As Label
    Friend WithEvents lblMinTime As Label
    Friend WithEvents lblMaxTime As Label
    Friend WithEvents lblMaxZ As Label
    Friend WithEvents lblMaxLatitude As Label
    Friend WithEvents lblMaxLongitude As Label
End Class
