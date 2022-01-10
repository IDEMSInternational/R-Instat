<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClusterAnalysis
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
        Me.rdoHierarchicalData = New System.Windows.Forms.RadioButton()
        Me.rdoPartitioningData = New System.Windows.Forms.RadioButton()
        Me.rdoNumericVariables = New System.Windows.Forms.RadioButton()
        Me.rdoDataFrame = New System.Windows.Forms.RadioButton()
        Me.ucrChkHierarcPlot = New instat.ucrCheck()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrChkPartitionPlot = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputMetric = New instat.ucrInputComboBox()
        Me.ucrInputMethod = New instat.ucrInputComboBox()
        Me.ucrNudPamCluster = New instat.ucrNud()
        Me.ucrChkMethod = New instat.ucrCheck()
        Me.ucrChkStand = New instat.ucrCheck()
        Me.ucrChkMetric = New instat.ucrCheck()
        Me.ucrReceiverClusterData = New instat.ucrReceiverMultiple()
        Me.ucrSelectorClusterData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlClusterData = New instat.UcrPanel()
        Me.ucrPnlSelectData = New instat.UcrPanel()
        Me.ucrChkCluster = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'rdoHierarchicalData
        '
        Me.rdoHierarchicalData.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoHierarchicalData.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHierarchicalData.FlatAppearance.BorderSize = 2
        Me.rdoHierarchicalData.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHierarchicalData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoHierarchicalData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHierarchicalData.Location = New System.Drawing.Point(239, 7)
        Me.rdoHierarchicalData.Name = "rdoHierarchicalData"
        Me.rdoHierarchicalData.Size = New System.Drawing.Size(100, 28)
        Me.rdoHierarchicalData.TabIndex = 2
        Me.rdoHierarchicalData.Text = "Hierarchical"
        Me.rdoHierarchicalData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoHierarchicalData.UseVisualStyleBackColor = True
        '
        'rdoPartitioningData
        '
        Me.rdoPartitioningData.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPartitioningData.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPartitioningData.FlatAppearance.BorderSize = 2
        Me.rdoPartitioningData.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPartitioningData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPartitioningData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPartitioningData.Location = New System.Drawing.Point(141, 7)
        Me.rdoPartitioningData.Name = "rdoPartitioningData"
        Me.rdoPartitioningData.Size = New System.Drawing.Size(100, 28)
        Me.rdoPartitioningData.TabIndex = 3
        Me.rdoPartitioningData.Text = "Partitioning"
        Me.rdoPartitioningData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPartitioningData.UseVisualStyleBackColor = True
        '
        'rdoNumericVariables
        '
        Me.rdoNumericVariables.AutoSize = True
        Me.rdoNumericVariables.Location = New System.Drawing.Point(288, 59)
        Me.rdoNumericVariables.Name = "rdoNumericVariables"
        Me.rdoNumericVariables.Size = New System.Drawing.Size(110, 17)
        Me.rdoNumericVariables.TabIndex = 6
        Me.rdoNumericVariables.TabStop = True
        Me.rdoNumericVariables.Text = "Numeric Variables"
        Me.rdoNumericVariables.UseVisualStyleBackColor = True
        '
        'rdoDataFrame
        '
        Me.rdoDataFrame.AutoSize = True
        Me.rdoDataFrame.Location = New System.Drawing.Point(289, 78)
        Me.rdoDataFrame.Name = "rdoDataFrame"
        Me.rdoDataFrame.Size = New System.Drawing.Size(113, 17)
        Me.rdoDataFrame.TabIndex = 7
        Me.rdoDataFrame.TabStop = True
        Me.rdoDataFrame.Text = "Data Frame/Matrix"
        Me.rdoDataFrame.UseVisualStyleBackColor = True
        '
        'ucrChkHierarcPlot
        '
        Me.ucrChkHierarcPlot.Checked = False
        Me.ucrChkHierarcPlot.Location = New System.Drawing.Point(7, 295)
        Me.ucrChkHierarcPlot.Name = "ucrChkHierarcPlot"
        Me.ucrChkHierarcPlot.Size = New System.Drawing.Size(120, 20)
        Me.ucrChkHierarcPlot.TabIndex = 29
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(8, 324)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(339, 24)
        Me.ucrSaveGraph.TabIndex = 28
        '
        'ucrChkPartitionPlot
        '
        Me.ucrChkPartitionPlot.Checked = False
        Me.ucrChkPartitionPlot.Location = New System.Drawing.Point(7, 269)
        Me.ucrChkPartitionPlot.Name = "ucrChkPartitionPlot"
        Me.ucrChkPartitionPlot.Size = New System.Drawing.Size(120, 20)
        Me.ucrChkPartitionPlot.TabIndex = 26
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(4, 358)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 25
        '
        'ucrInputMetric
        '
        Me.ucrInputMetric.AddQuotesIfUnrecognised = True
        Me.ucrInputMetric.GetSetSelectedIndex = -1
        Me.ucrInputMetric.IsReadOnly = False
        Me.ucrInputMetric.Location = New System.Drawing.Point(127, 224)
        Me.ucrInputMetric.Name = "ucrInputMetric"
        Me.ucrInputMetric.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMetric.TabIndex = 24
        '
        'ucrInputMethod
        '
        Me.ucrInputMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputMethod.GetSetSelectedIndex = -1
        Me.ucrInputMethod.IsReadOnly = False
        Me.ucrInputMethod.Location = New System.Drawing.Point(127, 269)
        Me.ucrInputMethod.Name = "ucrInputMethod"
        Me.ucrInputMethod.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMethod.TabIndex = 23
        '
        'ucrNudPamCluster
        '
        Me.ucrNudPamCluster.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPamCluster.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPamCluster.Location = New System.Drawing.Point(127, 294)
        Me.ucrNudPamCluster.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPamCluster.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPamCluster.Name = "ucrNudPamCluster"
        Me.ucrNudPamCluster.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPamCluster.TabIndex = 22
        Me.ucrNudPamCluster.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkMethod
        '
        Me.ucrChkMethod.Checked = False
        Me.ucrChkMethod.Location = New System.Drawing.Point(7, 269)
        Me.ucrChkMethod.Name = "ucrChkMethod"
        Me.ucrChkMethod.Size = New System.Drawing.Size(120, 20)
        Me.ucrChkMethod.TabIndex = 20
        '
        'ucrChkStand
        '
        Me.ucrChkStand.Checked = False
        Me.ucrChkStand.Location = New System.Drawing.Point(7, 246)
        Me.ucrChkStand.Name = "ucrChkStand"
        Me.ucrChkStand.Size = New System.Drawing.Size(120, 20)
        Me.ucrChkStand.TabIndex = 19
        '
        'ucrChkMetric
        '
        Me.ucrChkMetric.Checked = False
        Me.ucrChkMetric.Location = New System.Drawing.Point(7, 223)
        Me.ucrChkMetric.Name = "ucrChkMetric"
        Me.ucrChkMetric.Size = New System.Drawing.Size(120, 20)
        Me.ucrChkMetric.TabIndex = 18
        '
        'ucrReceiverClusterData
        '
        Me.ucrReceiverClusterData.frmParent = Me
        Me.ucrReceiverClusterData.Location = New System.Drawing.Point(298, 111)
        Me.ucrReceiverClusterData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverClusterData.Name = "ucrReceiverClusterData"
        Me.ucrReceiverClusterData.Selector = Nothing
        Me.ucrReceiverClusterData.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverClusterData.strNcFilePath = ""
        Me.ucrReceiverClusterData.TabIndex = 5
        Me.ucrReceiverClusterData.ucrSelector = Nothing
        '
        'ucrSelectorClusterData
        '
        Me.ucrSelectorClusterData.bDropUnusedFilterLevels = False
        Me.ucrSelectorClusterData.bShowHiddenColumns = False
        Me.ucrSelectorClusterData.bUseCurrentFilter = True
        Me.ucrSelectorClusterData.Location = New System.Drawing.Point(7, 41)
        Me.ucrSelectorClusterData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClusterData.Name = "ucrSelectorClusterData"
        Me.ucrSelectorClusterData.Size = New System.Drawing.Size(212, 182)
        Me.ucrSelectorClusterData.TabIndex = 0
        '
        'ucrPnlClusterData
        '
        Me.ucrPnlClusterData.Location = New System.Drawing.Point(127, -2)
        Me.ucrPnlClusterData.Name = "ucrPnlClusterData"
        Me.ucrPnlClusterData.Size = New System.Drawing.Size(236, 40)
        Me.ucrPnlClusterData.TabIndex = 4
        '
        'ucrPnlSelectData
        '
        Me.ucrPnlSelectData.Location = New System.Drawing.Point(243, 55)
        Me.ucrPnlSelectData.Name = "ucrPnlSelectData"
        Me.ucrPnlSelectData.Size = New System.Drawing.Size(183, 49)
        Me.ucrPnlSelectData.TabIndex = 8
        '
        'ucrChkCluster
        '
        Me.ucrChkCluster.Checked = False
        Me.ucrChkCluster.Location = New System.Drawing.Point(8, 295)
        Me.ucrChkCluster.Name = "ucrChkCluster"
        Me.ucrChkCluster.Size = New System.Drawing.Size(120, 20)
        Me.ucrChkCluster.TabIndex = 21
        '
        'dlgClusterAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 426)
        Me.Controls.Add(Me.ucrChkHierarcPlot)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrChkPartitionPlot)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrInputMetric)
        Me.Controls.Add(Me.ucrInputMethod)
        Me.Controls.Add(Me.ucrNudPamCluster)
        Me.Controls.Add(Me.ucrChkMethod)
        Me.Controls.Add(Me.ucrChkStand)
        Me.Controls.Add(Me.ucrChkMetric)
        Me.Controls.Add(Me.rdoDataFrame)
        Me.Controls.Add(Me.rdoNumericVariables)
        Me.Controls.Add(Me.ucrReceiverClusterData)
        Me.Controls.Add(Me.rdoPartitioningData)
        Me.Controls.Add(Me.rdoHierarchicalData)
        Me.Controls.Add(Me.ucrSelectorClusterData)
        Me.Controls.Add(Me.ucrPnlClusterData)
        Me.Controls.Add(Me.ucrPnlSelectData)
        Me.Controls.Add(Me.ucrChkCluster)
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(613, 450)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClusterAnalysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cluster Analysis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorClusterData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoHierarchicalData As RadioButton
    Friend WithEvents rdoPartitioningData As RadioButton
    Friend WithEvents ucrPnlClusterData As UcrPanel
    Friend WithEvents ucrReceiverClusterData As ucrReceiverMultiple
    Friend WithEvents rdoDataFrame As RadioButton
    Friend WithEvents rdoNumericVariables As RadioButton
    Friend WithEvents ucrPnlSelectData As UcrPanel
    Friend WithEvents ucrInputMetric As ucrInputComboBox
    Friend WithEvents ucrInputMethod As ucrInputComboBox
    Friend WithEvents ucrNudPamCluster As ucrNud
    Friend WithEvents ucrChkCluster As ucrCheck
    Friend WithEvents ucrChkMethod As ucrCheck
    Friend WithEvents ucrChkStand As ucrCheck
    Friend WithEvents ucrChkMetric As ucrCheck
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkPartitionPlot As ucrCheck
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrChkHierarcPlot As ucrCheck
End Class
