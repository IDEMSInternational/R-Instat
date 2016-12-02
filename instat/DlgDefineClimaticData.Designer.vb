<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DlgDefineClimaticData
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
        Me.ucrSelectorDefineClimaticData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpClimaticType = New System.Windows.Forms.GroupBox()
        Me.lblCloudCover = New System.Windows.Forms.Label()
        Me.ucrReceiverCloudCover = New instat.ucrReceiverSingle()
        Me.lblRadiation = New System.Windows.Forms.Label()
        Me.ucrReceiverRadiation = New instat.ucrReceiverSingle()
        Me.lblWindDirection = New System.Windows.Forms.Label()
        Me.ucrReceiverWindDirection = New instat.ucrReceiverSingle()
        Me.lblSunshine = New System.Windows.Forms.Label()
        Me.ucrReceiverSunshine = New instat.ucrReceiverSingle()
        Me.lblWindSpeed = New System.Windows.Forms.Label()
        Me.lblRain = New System.Windows.Forms.Label()
        Me.lblMinTemp = New System.Windows.Forms.Label()
        Me.lblMaxTemp = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.ucrReceiverRain = New instat.ucrReceiverSingle()
        Me.ucrReceiverMinTemp = New instat.ucrReceiverSingle()
        Me.ucrReceiverMaxTemp = New instat.ucrReceiverSingle()
        Me.ucrReceiverWind = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.grpClimaticType.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSelectorDefineClimaticData
        '
        Me.ucrSelectorDefineClimaticData.bShowHiddenColumns = False
        Me.ucrSelectorDefineClimaticData.bUseCurrentFilter = True
        Me.ucrSelectorDefineClimaticData.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorDefineClimaticData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDefineClimaticData.Name = "ucrSelectorDefineClimaticData"
        Me.ucrSelectorDefineClimaticData.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDefineClimaticData.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 428)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 13
        '
        'grpClimaticType
        '
        Me.grpClimaticType.Controls.Add(Me.lblCloudCover)
        Me.grpClimaticType.Controls.Add(Me.ucrReceiverCloudCover)
        Me.grpClimaticType.Controls.Add(Me.lblRadiation)
        Me.grpClimaticType.Controls.Add(Me.ucrReceiverRadiation)
        Me.grpClimaticType.Controls.Add(Me.lblWindDirection)
        Me.grpClimaticType.Controls.Add(Me.ucrReceiverWindDirection)
        Me.grpClimaticType.Controls.Add(Me.lblSunshine)
        Me.grpClimaticType.Controls.Add(Me.ucrReceiverSunshine)
        Me.grpClimaticType.Controls.Add(Me.lblWindSpeed)
        Me.grpClimaticType.Controls.Add(Me.lblRain)
        Me.grpClimaticType.Controls.Add(Me.lblMinTemp)
        Me.grpClimaticType.Controls.Add(Me.lblMaxTemp)
        Me.grpClimaticType.Controls.Add(Me.lblDate)
        Me.grpClimaticType.Controls.Add(Me.ucrReceiverRain)
        Me.grpClimaticType.Controls.Add(Me.ucrReceiverMinTemp)
        Me.grpClimaticType.Controls.Add(Me.ucrReceiverMaxTemp)
        Me.grpClimaticType.Controls.Add(Me.ucrReceiverWind)
        Me.grpClimaticType.Controls.Add(Me.ucrReceiverDate)
        Me.grpClimaticType.Location = New System.Drawing.Point(234, 9)
        Me.grpClimaticType.Name = "grpClimaticType"
        Me.grpClimaticType.Size = New System.Drawing.Size(161, 413)
        Me.grpClimaticType.TabIndex = 20
        Me.grpClimaticType.TabStop = False
        Me.grpClimaticType.Text = "Climatic Type"
        '
        'lblCloudCover
        '
        Me.lblCloudCover.AutoSize = True
        Me.lblCloudCover.Location = New System.Drawing.Point(21, 368)
        Me.lblCloudCover.Name = "lblCloudCover"
        Me.lblCloudCover.Size = New System.Drawing.Size(55, 13)
        Me.lblCloudCover.TabIndex = 37
        Me.lblCloudCover.Text = "Radiation:"
        '
        'ucrReceiverCloudCover
        '
        Me.ucrReceiverCloudCover.Location = New System.Drawing.Point(21, 386)
        Me.ucrReceiverCloudCover.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCloudCover.Name = "ucrReceiverCloudCover"
        Me.ucrReceiverCloudCover.Selector = Nothing
        Me.ucrReceiverCloudCover.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverCloudCover.TabIndex = 36
        '
        'lblRadiation
        '
        Me.lblRadiation.AutoSize = True
        Me.lblRadiation.Location = New System.Drawing.Point(21, 325)
        Me.lblRadiation.Name = "lblRadiation"
        Me.lblRadiation.Size = New System.Drawing.Size(55, 13)
        Me.lblRadiation.TabIndex = 35
        Me.lblRadiation.Text = "Radiation:"
        '
        'ucrReceiverRadiation
        '
        Me.ucrReceiverRadiation.Location = New System.Drawing.Point(21, 343)
        Me.ucrReceiverRadiation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRadiation.Name = "ucrReceiverRadiation"
        Me.ucrReceiverRadiation.Selector = Nothing
        Me.ucrReceiverRadiation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRadiation.TabIndex = 34
        '
        'lblWindDirection
        '
        Me.lblWindDirection.AutoSize = True
        Me.lblWindDirection.Location = New System.Drawing.Point(21, 239)
        Me.lblWindDirection.Name = "lblWindDirection"
        Me.lblWindDirection.Size = New System.Drawing.Size(80, 13)
        Me.lblWindDirection.TabIndex = 33
        Me.lblWindDirection.Text = "Wind Direction:"
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(21, 257)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindDirection.TabIndex = 32
        '
        'lblSunshine
        '
        Me.lblSunshine.AutoSize = True
        Me.lblSunshine.Location = New System.Drawing.Point(21, 282)
        Me.lblSunshine.Name = "lblSunshine"
        Me.lblSunshine.Size = New System.Drawing.Size(85, 13)
        Me.lblSunshine.TabIndex = 31
        Me.lblSunshine.Text = "Sunshine Hours:"
        '
        'ucrReceiverSunshine
        '
        Me.ucrReceiverSunshine.Location = New System.Drawing.Point(21, 300)
        Me.ucrReceiverSunshine.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSunshine.Name = "ucrReceiverSunshine"
        Me.ucrReceiverSunshine.Selector = Nothing
        Me.ucrReceiverSunshine.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSunshine.TabIndex = 30
        '
        'lblWindSpeed
        '
        Me.lblWindSpeed.AutoSize = True
        Me.lblWindSpeed.Location = New System.Drawing.Point(21, 196)
        Me.lblWindSpeed.Name = "lblWindSpeed"
        Me.lblWindSpeed.Size = New System.Drawing.Size(69, 13)
        Me.lblWindSpeed.TabIndex = 29
        Me.lblWindSpeed.Text = "Wind Speed:"
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.Location = New System.Drawing.Point(21, 67)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(32, 13)
        Me.lblRain.TabIndex = 28
        Me.lblRain.Text = "Rain:"
        '
        'lblMinTemp
        '
        Me.lblMinTemp.AutoSize = True
        Me.lblMinTemp.Location = New System.Drawing.Point(21, 110)
        Me.lblMinTemp.Name = "lblMinTemp"
        Me.lblMinTemp.Size = New System.Drawing.Size(118, 13)
        Me.lblMinTemp.TabIndex = 27
        Me.lblMinTemp.Text = "Temperature Manimum:"
        '
        'lblMaxTemp
        '
        Me.lblMaxTemp.AutoSize = True
        Me.lblMaxTemp.Location = New System.Drawing.Point(21, 153)
        Me.lblMaxTemp.Name = "lblMaxTemp"
        Me.lblMaxTemp.Size = New System.Drawing.Size(117, 13)
        Me.lblMaxTemp.TabIndex = 26
        Me.lblMaxTemp.Text = "Temperature Maximum:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(21, 24)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 25
        Me.lblDate.Text = "Date:"
        '
        'ucrReceiverRain
        '
        Me.ucrReceiverRain.Location = New System.Drawing.Point(21, 85)
        Me.ucrReceiverRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRain.Name = "ucrReceiverRain"
        Me.ucrReceiverRain.Selector = Nothing
        Me.ucrReceiverRain.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRain.TabIndex = 24
        '
        'ucrReceiverMinTemp
        '
        Me.ucrReceiverMinTemp.Location = New System.Drawing.Point(21, 128)
        Me.ucrReceiverMinTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMinTemp.Name = "ucrReceiverMinTemp"
        Me.ucrReceiverMinTemp.Selector = Nothing
        Me.ucrReceiverMinTemp.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMinTemp.TabIndex = 23
        '
        'ucrReceiverMaxTemp
        '
        Me.ucrReceiverMaxTemp.Location = New System.Drawing.Point(21, 171)
        Me.ucrReceiverMaxTemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxTemp.Name = "ucrReceiverMaxTemp"
        Me.ucrReceiverMaxTemp.Selector = Nothing
        Me.ucrReceiverMaxTemp.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMaxTemp.TabIndex = 22
        '
        'ucrReceiverWind
        '
        Me.ucrReceiverWind.Location = New System.Drawing.Point(21, 214)
        Me.ucrReceiverWind.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWind.Name = "ucrReceiverWind"
        Me.ucrReceiverWind.Selector = Nothing
        Me.ucrReceiverWind.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWind.TabIndex = 21
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.Location = New System.Drawing.Point(21, 42)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.TabIndex = 20
        '
        'DlgDefineClimaticData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 492)
        Me.Controls.Add(Me.grpClimaticType)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorDefineClimaticData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DlgDefineClimaticData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Define Climatic Data"
        Me.grpClimaticType.ResumeLayout(False)
        Me.grpClimaticType.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSelectorDefineClimaticData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpClimaticType As GroupBox
    Friend WithEvents lblCloudCover As Label
    Friend WithEvents ucrReceiverCloudCover As ucrReceiverSingle
    Friend WithEvents lblRadiation As Label
    Friend WithEvents ucrReceiverRadiation As ucrReceiverSingle
    Friend WithEvents lblWindDirection As Label
    Friend WithEvents ucrReceiverWindDirection As ucrReceiverSingle
    Friend WithEvents lblSunshine As Label
    Friend WithEvents ucrReceiverSunshine As ucrReceiverSingle
    Friend WithEvents lblWindSpeed As Label
    Friend WithEvents lblRain As Label
    Friend WithEvents lblMinTemp As Label
    Friend WithEvents lblMaxTemp As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverRain As ucrReceiverSingle
    Friend WithEvents ucrReceiverMinTemp As ucrReceiverSingle
    Friend WithEvents ucrReceiverMaxTemp As ucrReceiverSingle
    Friend WithEvents ucrReceiverWind As ucrReceiverSingle
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
End Class
