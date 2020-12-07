<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgPolarCluster
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
        Me.lblPollutant = New System.Windows.Forms.Label()
        Me.lblWindDirection = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblNumberOfClusters = New System.Windows.Forms.Label()
        Me.lblAngularScale = New System.Windows.Forms.Label()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrInputColor = New instat.ucrInputComboBox()
        Me.ucrNudNoOfClusters = New instat.ucrNud()
        Me.ucrNudAngularScale = New instat.ucrNud()
        Me.ucrReceiverPollutant = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindDirection = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrSelectorPolarCluster = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'lblPollutant
        '
        Me.lblPollutant.AutoSize = True
        Me.lblPollutant.Location = New System.Drawing.Point(267, 21)
        Me.lblPollutant.Name = "lblPollutant"
        Me.lblPollutant.Size = New System.Drawing.Size(51, 13)
        Me.lblPollutant.TabIndex = 5
        Me.lblPollutant.Text = "Pollutant:"
        '
        'lblWindDirection
        '
        Me.lblWindDirection.AutoSize = True
        Me.lblWindDirection.Location = New System.Drawing.Point(267, 104)
        Me.lblWindDirection.Name = "lblWindDirection"
        Me.lblWindDirection.Size = New System.Drawing.Size(80, 13)
        Me.lblWindDirection.TabIndex = 7
        Me.lblWindDirection.Text = "Wind Direction:"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(267, 147)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(119, 13)
        Me.lblX.TabIndex = 8
        Me.lblX.Text = "Variable to Plot Against:"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(199, 224)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(34, 13)
        Me.lblColor.TabIndex = 12
        Me.lblColor.Text = "Color:"
        '
        'lblNumberOfClusters
        '
        Me.lblNumberOfClusters.AutoSize = True
        Me.lblNumberOfClusters.Location = New System.Drawing.Point(5, 224)
        Me.lblNumberOfClusters.Name = "lblNumberOfClusters"
        Me.lblNumberOfClusters.Size = New System.Drawing.Size(76, 13)
        Me.lblNumberOfClusters.TabIndex = 13
        Me.lblNumberOfClusters.Text = "No of Clusters:"
        '
        'lblAngularScale
        '
        Me.lblAngularScale.AutoSize = True
        Me.lblAngularScale.Location = New System.Drawing.Point(5, 246)
        Me.lblAngularScale.Name = "lblAngularScale"
        Me.lblAngularScale.Size = New System.Drawing.Size(76, 13)
        Me.lblAngularScale.TabIndex = 14
        Me.lblAngularScale.Text = "Angular Scale:"
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(6, 280)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(403, 34)
        Me.ucrSaveGraph.TabIndex = 15
        '
        'ucrInputColor
        '
        Me.ucrInputColor.AddQuotesIfUnrecognised = True
        Me.ucrInputColor.GetSetSelectedIndex = -1
        Me.ucrInputColor.IsReadOnly = False
        Me.ucrInputColor.Location = New System.Drawing.Point(270, 218)
        Me.ucrInputColor.Name = "ucrInputColor"
        Me.ucrInputColor.Size = New System.Drawing.Size(101, 21)
        Me.ucrInputColor.TabIndex = 9
        '
        'ucrNudNoOfClusters
        '
        Me.ucrNudNoOfClusters.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfClusters.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNoOfClusters.Location = New System.Drawing.Point(127, 219)
        Me.ucrNudNoOfClusters.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNoOfClusters.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoOfClusters.Name = "ucrNudNoOfClusters"
        Me.ucrNudNoOfClusters.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNoOfClusters.TabIndex = 10
        Me.ucrNudNoOfClusters.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudAngularScale
        '
        Me.ucrNudAngularScale.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAngularScale.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAngularScale.Location = New System.Drawing.Point(127, 243)
        Me.ucrNudAngularScale.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAngularScale.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAngularScale.Name = "ucrNudAngularScale"
        Me.ucrNudAngularScale.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAngularScale.TabIndex = 11
        Me.ucrNudAngularScale.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverPollutant
        '
        Me.ucrReceiverPollutant.frmParent = Me
        Me.ucrReceiverPollutant.Location = New System.Drawing.Point(270, 34)
        Me.ucrReceiverPollutant.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPollutant.Name = "ucrReceiverPollutant"
        Me.ucrReceiverPollutant.Selector = Nothing
        Me.ucrReceiverPollutant.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPollutant.strNcFilePath = ""
        Me.ucrReceiverPollutant.TabIndex = 1
        Me.ucrReceiverPollutant.ucrSelector = Nothing
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.frmParent = Me
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(270, 121)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindDirection.strNcFilePath = ""
        Me.ucrReceiverWindDirection.TabIndex = 3
        Me.ucrReceiverWindDirection.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(270, 163)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 4
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrSelectorPolarCluster
        '
        Me.ucrSelectorPolarCluster.bDropUnusedFilterLevels = False
        Me.ucrSelectorPolarCluster.bShowHiddenColumns = False
        Me.ucrSelectorPolarCluster.bUseCurrentFilter = True
        Me.ucrSelectorPolarCluster.Location = New System.Drawing.Point(6, 8)
        Me.ucrSelectorPolarCluster.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPolarCluster.Name = "ucrSelectorPolarCluster"
        Me.ucrSelectorPolarCluster.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorPolarCluster.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(6, 317)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 16
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(267, 62)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Date:"
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(270, 75)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 2
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'dlgPolarCluster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 374)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrInputColor)
        Me.Controls.Add(Me.ucrNudNoOfClusters)
        Me.Controls.Add(Me.ucrNudAngularScale)
        Me.Controls.Add(Me.lblAngularScale)
        Me.Controls.Add(Me.lblNumberOfClusters)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.lblWindDirection)
        Me.Controls.Add(Me.lblPollutant)
        Me.Controls.Add(Me.ucrReceiverPollutant)
        Me.Controls.Add(Me.ucrReceiverWindDirection)
        Me.Controls.Add(Me.ucrReceiverX)
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
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents ucrInputColor As ucrInputComboBox
    Friend WithEvents ucrNudNoOfClusters As ucrNud
    Friend WithEvents ucrNudAngularScale As ucrNud
    Friend WithEvents lblAngularScale As Label
    Friend WithEvents lblNumberOfClusters As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lblX As Label
    Friend WithEvents lblWindDirection As Label
    Friend WithEvents lblPollutant As Label
    Friend WithEvents ucrReceiverPollutant As ucrReceiverSingle
    Friend WithEvents ucrReceiverWindDirection As ucrReceiverSingle
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
End Class
