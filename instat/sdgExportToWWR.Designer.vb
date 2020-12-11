<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgExportToWWR
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
        Me.lblStationName = New System.Windows.Forms.Label()
        Me.lblWMONumber = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblStationHeight = New System.Windows.Forms.Label()
        Me.lblBarometerHeight = New System.Windows.Forms.Label()
        Me.ucrButtonsSdg = New instat.ucrButtonsSubdialogue()
        Me.ucrReceiverStationHeight = New instat.ucrReceiverSingle()
        Me.ucrReceiverBarometerHeight = New instat.ucrReceiverSingle()
        Me.ucrReceiverCountry = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverLongitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverStationName = New instat.ucrReceiverSingle()
        Me.ucrReceiverWNONumber = New instat.ucrReceiverSingle()
        Me.ucrSelectorStationMetadata = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblStationName
        '
        Me.lblStationName.AutoSize = True
        Me.lblStationName.Location = New System.Drawing.Point(248, 37)
        Me.lblStationName.Name = "lblStationName"
        Me.lblStationName.Size = New System.Drawing.Size(74, 13)
        Me.lblStationName.TabIndex = 1
        Me.lblStationName.Text = "Station Name:"
        '
        'lblWMONumber
        '
        Me.lblWMONumber.AutoSize = True
        Me.lblWMONumber.Location = New System.Drawing.Point(248, 77)
        Me.lblWMONumber.Name = "lblWMONumber"
        Me.lblWMONumber.Size = New System.Drawing.Size(78, 13)
        Me.lblWMONumber.TabIndex = 3
        Me.lblWMONumber.Text = "WMO Number:"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(248, 117)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(46, 13)
        Me.lblCountry.TabIndex = 5
        Me.lblCountry.Text = "Country:"
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.Location = New System.Drawing.Point(248, 156)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(48, 13)
        Me.lblLatitude.TabIndex = 7
        Me.lblLatitude.Text = "Latitude:"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.Location = New System.Drawing.Point(248, 195)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(57, 13)
        Me.lblLongitude.TabIndex = 9
        Me.lblLongitude.Text = "Longitude:"
        '
        'lblStationHeight
        '
        Me.lblStationHeight.AutoSize = True
        Me.lblStationHeight.Location = New System.Drawing.Point(248, 235)
        Me.lblStationHeight.Name = "lblStationHeight"
        Me.lblStationHeight.Size = New System.Drawing.Size(74, 13)
        Me.lblStationHeight.TabIndex = 11
        Me.lblStationHeight.Text = "StationHeight:"
        '
        'lblBarometerHeight
        '
        Me.lblBarometerHeight.AutoSize = True
        Me.lblBarometerHeight.Location = New System.Drawing.Point(248, 282)
        Me.lblBarometerHeight.Name = "lblBarometerHeight"
        Me.lblBarometerHeight.Size = New System.Drawing.Size(86, 13)
        Me.lblBarometerHeight.TabIndex = 13
        Me.lblBarometerHeight.Text = "BarometerHeight"
        '
        'ucrButtonsSdg
        '
        Me.ucrButtonsSdg.Location = New System.Drawing.Point(127, 330)
        Me.ucrButtonsSdg.Name = "ucrButtonsSdg"
        Me.ucrButtonsSdg.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsSdg.TabIndex = 15
        '
        'ucrReceiverStationHeight
        '
        Me.ucrReceiverStationHeight.frmParent = Me
        Me.ucrReceiverStationHeight.Location = New System.Drawing.Point(248, 248)
        Me.ucrReceiverStationHeight.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationHeight.Name = "ucrReceiverStationHeight"
        Me.ucrReceiverStationHeight.Selector = Nothing
        Me.ucrReceiverStationHeight.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStationHeight.strNcFilePath = ""
        Me.ucrReceiverStationHeight.TabIndex = 12
        Me.ucrReceiverStationHeight.ucrSelector = Nothing
        '
        'ucrReceiverBarometerHeight
        '
        Me.ucrReceiverBarometerHeight.frmParent = Me
        Me.ucrReceiverBarometerHeight.Location = New System.Drawing.Point(248, 295)
        Me.ucrReceiverBarometerHeight.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverBarometerHeight.Name = "ucrReceiverBarometerHeight"
        Me.ucrReceiverBarometerHeight.Selector = Nothing
        Me.ucrReceiverBarometerHeight.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverBarometerHeight.strNcFilePath = ""
        Me.ucrReceiverBarometerHeight.TabIndex = 14
        Me.ucrReceiverBarometerHeight.ucrSelector = Nothing
        '
        'ucrReceiverCountry
        '
        Me.ucrReceiverCountry.frmParent = Me
        Me.ucrReceiverCountry.Location = New System.Drawing.Point(248, 130)
        Me.ucrReceiverCountry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCountry.Name = "ucrReceiverCountry"
        Me.ucrReceiverCountry.Selector = Nothing
        Me.ucrReceiverCountry.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverCountry.strNcFilePath = ""
        Me.ucrReceiverCountry.TabIndex = 6
        Me.ucrReceiverCountry.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.frmParent = Me
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(248, 169)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 8
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.frmParent = Me
        Me.ucrReceiverLongitude.Location = New System.Drawing.Point(248, 208)
        Me.ucrReceiverLongitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.TabIndex = 10
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrReceiverStationName
        '
        Me.ucrReceiverStationName.frmParent = Me
        Me.ucrReceiverStationName.Location = New System.Drawing.Point(248, 52)
        Me.ucrReceiverStationName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationName.Name = "ucrReceiverStationName"
        Me.ucrReceiverStationName.Selector = Nothing
        Me.ucrReceiverStationName.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStationName.strNcFilePath = ""
        Me.ucrReceiverStationName.TabIndex = 2
        Me.ucrReceiverStationName.ucrSelector = Nothing
        '
        'ucrReceiverWNONumber
        '
        Me.ucrReceiverWNONumber.frmParent = Me
        Me.ucrReceiverWNONumber.Location = New System.Drawing.Point(248, 90)
        Me.ucrReceiverWNONumber.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWNONumber.Name = "ucrReceiverWNONumber"
        Me.ucrReceiverWNONumber.Selector = Nothing
        Me.ucrReceiverWNONumber.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWNONumber.strNcFilePath = ""
        Me.ucrReceiverWNONumber.TabIndex = 4
        Me.ucrReceiverWNONumber.ucrSelector = Nothing
        '
        'ucrSelectorStationMetadata
        '
        Me.ucrSelectorStationMetadata.bDropUnusedFilterLevels = False
        Me.ucrSelectorStationMetadata.bShowHiddenColumns = False
        Me.ucrSelectorStationMetadata.bUseCurrentFilter = True
        Me.ucrSelectorStationMetadata.Location = New System.Drawing.Point(12, 20)
        Me.ucrSelectorStationMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStationMetadata.Name = "ucrSelectorStationMetadata"
        Me.ucrSelectorStationMetadata.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorStationMetadata.TabIndex = 0
        '
        'sdgExportToWWR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 365)
        Me.Controls.Add(Me.ucrButtonsSdg)
        Me.Controls.Add(Me.lblBarometerHeight)
        Me.Controls.Add(Me.lblStationHeight)
        Me.Controls.Add(Me.lblLongitude)
        Me.Controls.Add(Me.lblLatitude)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.lblWMONumber)
        Me.Controls.Add(Me.lblStationName)
        Me.Controls.Add(Me.ucrReceiverStationHeight)
        Me.Controls.Add(Me.ucrReceiverBarometerHeight)
        Me.Controls.Add(Me.ucrReceiverCountry)
        Me.Controls.Add(Me.ucrReceiverLatitude)
        Me.Controls.Add(Me.ucrReceiverLongitude)
        Me.Controls.Add(Me.ucrReceiverStationName)
        Me.Controls.Add(Me.ucrReceiverWNONumber)
        Me.Controls.Add(Me.ucrSelectorStationMetadata)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgExportToWWR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Station Metadata"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorStationMetadata As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverWNONumber As ucrReceiverSingle
    Friend WithEvents ucrReceiverStationName As ucrReceiverSingle
    Friend WithEvents lblStationName As Label
    Friend WithEvents ucrReceiverStationHeight As ucrReceiverSingle
    Friend WithEvents ucrReceiverBarometerHeight As ucrReceiverSingle
    Friend WithEvents ucrReceiverCountry As ucrReceiverSingle
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverLongitude As ucrReceiverSingle
    Friend WithEvents lblBarometerHeight As Label
    Friend WithEvents lblStationHeight As Label
    Friend WithEvents lblLongitude As Label
    Friend WithEvents lblLatitude As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents lblWMONumber As Label
    Friend WithEvents ucrButtonsSdg As ucrButtonsSubdialogue
End Class
