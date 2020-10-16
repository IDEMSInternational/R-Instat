<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPolarCluster
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
        Me.ucrSelectorPolarCluster = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverPollutant = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindDirection = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.lblpollutant = New System.Windows.Forms.Label()
        Me.lblWindDirection = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblAngularScale = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNoOfClusters = New System.Windows.Forms.Label()
        Me.ucrNudNoOfClusters = New instat.ucrNud()
        Me.ucrNudAngularScale = New instat.ucrNud()
        Me.ucrInputColor = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(6, 264)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorPolarCluster
        '
        Me.ucrSelectorPolarCluster.bDropUnusedFilterLevels = False
        Me.ucrSelectorPolarCluster.bShowHiddenColumns = False
        Me.ucrSelectorPolarCluster.bUseCurrentFilter = True
        Me.ucrSelectorPolarCluster.Location = New System.Drawing.Point(15, 9)
        Me.ucrSelectorPolarCluster.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPolarCluster.Name = "ucrSelectorPolarCluster"
        Me.ucrSelectorPolarCluster.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorPolarCluster.TabIndex = 1
        '
        'ucrReceiverPollutant
        '
        Me.ucrReceiverPollutant.frmParent = Me
        Me.ucrReceiverPollutant.Location = New System.Drawing.Point(263, 53)
        Me.ucrReceiverPollutant.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPollutant.Name = "ucrReceiverPollutant"
        Me.ucrReceiverPollutant.Selector = Nothing
        Me.ucrReceiverPollutant.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverPollutant.strNcFilePath = ""
        Me.ucrReceiverPollutant.TabIndex = 2
        Me.ucrReceiverPollutant.ucrSelector = Nothing
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.frmParent = Me
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(263, 101)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverWindDirection.strNcFilePath = ""
        Me.ucrReceiverWindDirection.TabIndex = 3
        Me.ucrReceiverWindDirection.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(263, 151)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 4
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'lblpollutant
        '
        Me.lblpollutant.AutoSize = True
        Me.lblpollutant.Location = New System.Drawing.Point(260, 34)
        Me.lblpollutant.Name = "lblpollutant"
        Me.lblpollutant.Size = New System.Drawing.Size(51, 13)
        Me.lblpollutant.TabIndex = 5
        Me.lblpollutant.Text = "Pollutant:"
        '
        'lblWindDirection
        '
        Me.lblWindDirection.AutoSize = True
        Me.lblWindDirection.Location = New System.Drawing.Point(260, 85)
        Me.lblWindDirection.Name = "lblWindDirection"
        Me.lblWindDirection.Size = New System.Drawing.Size(80, 13)
        Me.lblWindDirection.TabIndex = 7
        Me.lblWindDirection.Text = "Wind Direction:"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(264, 133)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(14, 13)
        Me.lblX.TabIndex = 8
        Me.lblX.Text = "X"
        '
        'lblAngularScale
        '
        Me.lblAngularScale.AutoSize = True
        Me.lblAngularScale.Location = New System.Drawing.Point(260, 205)
        Me.lblAngularScale.Name = "lblAngularScale"
        Me.lblAngularScale.Size = New System.Drawing.Size(76, 13)
        Me.lblAngularScale.TabIndex = 9
        Me.lblAngularScale.Text = "Angular Scale:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Color:"
        '
        'lblNoOfClusters
        '
        Me.lblNoOfClusters.AutoSize = True
        Me.lblNoOfClusters.Location = New System.Drawing.Point(12, 228)
        Me.lblNoOfClusters.Name = "lblNoOfClusters"
        Me.lblNoOfClusters.Size = New System.Drawing.Size(76, 13)
        Me.lblNoOfClusters.TabIndex = 11
        Me.lblNoOfClusters.Text = "No of Clusters:"
        '
        'ucrNudNoOfClusters
        '
        Me.ucrNudNoOfClusters.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfClusters.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNoOfClusters.Location = New System.Drawing.Point(138, 224)
        Me.ucrNudNoOfClusters.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNoOfClusters.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfClusters.Name = "ucrNudNoOfClusters"
        Me.ucrNudNoOfClusters.Size = New System.Drawing.Size(39, 20)
        Me.ucrNudNoOfClusters.TabIndex = 12
        Me.ucrNudNoOfClusters.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudAngularScale
        '
        Me.ucrNudAngularScale.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAngularScale.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAngularScale.Location = New System.Drawing.Point(355, 201)
        Me.ucrNudAngularScale.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAngularScale.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAngularScale.Name = "ucrNudAngularScale"
        Me.ucrNudAngularScale.Size = New System.Drawing.Size(40, 20)
        Me.ucrNudAngularScale.TabIndex = 13
        Me.ucrNudAngularScale.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputColor
        '
        Me.ucrInputColor.AddQuotesIfUnrecognised = True
        Me.ucrInputColor.GetSetSelectedIndex = -1
        Me.ucrInputColor.IsReadOnly = False
        Me.ucrInputColor.Location = New System.Drawing.Point(101, 201)
        Me.ucrInputColor.Name = "ucrInputColor"
        Me.ucrInputColor.Size = New System.Drawing.Size(76, 21)
        Me.ucrInputColor.TabIndex = 14
        '
        'dlgPolarCluster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 332)
        Me.Controls.Add(Me.ucrInputColor)
        Me.Controls.Add(Me.ucrNudAngularScale)
        Me.Controls.Add(Me.ucrNudNoOfClusters)
        Me.Controls.Add(Me.lblNoOfClusters)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblAngularScale)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.lblWindDirection)
        Me.Controls.Add(Me.lblpollutant)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrReceiverWindDirection)
        Me.Controls.Add(Me.ucrReceiverPollutant)
        Me.Controls.Add(Me.ucrSelectorPolarCluster)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPolarCluster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Polar Cluster"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorPolarCluster As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverPollutant As ucrReceiverSingle
    Friend WithEvents ucrInputColor As ucrInputComboBox
    Friend WithEvents ucrNudAngularScale As ucrNud
    Friend WithEvents ucrNudNoOfClusters As ucrNud
    Friend WithEvents lblNoOfClusters As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblAngularScale As Label
    Friend WithEvents lblX As Label
    Friend WithEvents lblWindDirection As Label
    Friend WithEvents lblpollutant As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents ucrReceiverWindDirection As ucrReceiverSingle
End Class
