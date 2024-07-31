<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgMetadataGoogleBuckets
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
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.ucrSelectorMetadata = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverDistrict = New instat.ucrReceiverSingle()
        Me.ucrReceiverElavation = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverLongititude = New instat.ucrReceiverSingle()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblElavation = New System.Windows.Forms.Label()
        Me.lblDistrict = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.Location = New System.Drawing.Point(90, 501)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(335, 42)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorMetadata
        '
        Me.ucrSelectorMetadata.AutoSize = True
        Me.ucrSelectorMetadata.bDropUnusedFilterLevels = False
        Me.ucrSelectorMetadata.bShowHiddenColumns = False
        Me.ucrSelectorMetadata.bUseCurrentFilter = True
        Me.ucrSelectorMetadata.Location = New System.Drawing.Point(15, 24)
        Me.ucrSelectorMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorMetadata.Name = "ucrSelectorMetadata"
        Me.ucrSelectorMetadata.Size = New System.Drawing.Size(318, 274)
        Me.ucrSelectorMetadata.TabIndex = 1
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(436, 62)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 2
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverDistrict
        '
        Me.ucrReceiverDistrict.AutoSize = True
        Me.ucrReceiverDistrict.frmParent = Me
        Me.ucrReceiverDistrict.Location = New System.Drawing.Point(459, 320)
        Me.ucrReceiverDistrict.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDistrict.Name = "ucrReceiverDistrict"
        Me.ucrReceiverDistrict.Selector = Nothing
        Me.ucrReceiverDistrict.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverDistrict.strNcFilePath = ""
        Me.ucrReceiverDistrict.TabIndex = 4
        Me.ucrReceiverDistrict.ucrSelector = Nothing
        '
        'ucrReceiverElavation
        '
        Me.ucrReceiverElavation.AutoSize = True
        Me.ucrReceiverElavation.frmParent = Me
        Me.ucrReceiverElavation.Location = New System.Drawing.Point(458, 258)
        Me.ucrReceiverElavation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElavation.Name = "ucrReceiverElavation"
        Me.ucrReceiverElavation.Selector = Nothing
        Me.ucrReceiverElavation.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverElavation.strNcFilePath = ""
        Me.ucrReceiverElavation.TabIndex = 5
        Me.ucrReceiverElavation.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.AutoSize = True
        Me.ucrReceiverLatitude.frmParent = Me
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(452, 198)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 6
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrReceiverLongititude
        '
        Me.ucrReceiverLongititude.AutoSize = True
        Me.ucrReceiverLongititude.frmParent = Me
        Me.ucrReceiverLongititude.Location = New System.Drawing.Point(439, 129)
        Me.ucrReceiverLongititude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongititude.Name = "ucrReceiverLongititude"
        Me.ucrReceiverLongititude.Selector = Nothing
        Me.ucrReceiverLongititude.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverLongititude.strNcFilePath = ""
        Me.ucrReceiverLongititude.TabIndex = 7
        Me.ucrReceiverLongititude.ucrSelector = Nothing
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(439, 34)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(106, 20)
        Me.lblStation.TabIndex = 8
        Me.lblStation.Text = "Station Name"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.Location = New System.Drawing.Point(445, 103)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(84, 20)
        Me.lblLongitude.TabIndex = 9
        Me.lblLongitude.Text = "Longitude "
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.Location = New System.Drawing.Point(448, 165)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(67, 20)
        Me.lblLatitude.TabIndex = 10
        Me.lblLatitude.Text = "Latitude"
        '
        'lblElavation
        '
        Me.lblElavation.AutoSize = True
        Me.lblElavation.Location = New System.Drawing.Point(462, 231)
        Me.lblElavation.Name = "lblElavation"
        Me.lblElavation.Size = New System.Drawing.Size(74, 20)
        Me.lblElavation.TabIndex = 11
        Me.lblElavation.Text = "Elavation"
        '
        'lblDistrict
        '
        Me.lblDistrict.AutoSize = True
        Me.lblDistrict.Location = New System.Drawing.Point(457, 292)
        Me.lblDistrict.Name = "lblDistrict"
        Me.lblDistrict.Size = New System.Drawing.Size(58, 20)
        Me.lblDistrict.TabIndex = 12
        Me.lblDistrict.Text = "District"
        '
        'sdgMetadataGoogleBuckets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 560)
        Me.Controls.Add(Me.lblDistrict)
        Me.Controls.Add(Me.lblElavation)
        Me.Controls.Add(Me.lblLatitude)
        Me.Controls.Add(Me.lblLongitude)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverLongititude)
        Me.Controls.Add(Me.ucrReceiverLatitude)
        Me.Controls.Add(Me.ucrReceiverElavation)
        Me.Controls.Add(Me.ucrReceiverDistrict)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorMetadata)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgMetadataGoogleBuckets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Metadata Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents ucrSelectorMetadata As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblDistrict As Label
    Friend WithEvents lblElavation As Label
    Friend WithEvents lblLatitude As Label
    Friend WithEvents lblLongitude As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverLongititude As ucrReceiverSingle
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverElavation As ucrReceiverSingle
    Friend WithEvents ucrReceiverDistrict As ucrReceiverSingle
End Class
