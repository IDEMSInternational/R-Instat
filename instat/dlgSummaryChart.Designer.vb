<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSummaryChart
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
        Me.ucrSummaryChartSelector = New instat.ucrSelectorAddRemove()
        Me.lblSummaryVariable = New System.Windows.Forms.Label()
        Me.ucrSummaryVariableReceiver = New instat.ucrReceiverSingle()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblCategoryFactor = New System.Windows.Forms.Label()
        Me.grpSummaryStatistics = New System.Windows.Forms.GroupBox()
        Me.rdoCases = New System.Windows.Forms.RadioButton()
        Me.rdoVariance = New System.Windows.Forms.RadioButton()
        Me.rdoStdDeviation = New System.Windows.Forms.RadioButton()
        Me.rdoMedian = New System.Windows.Forms.RadioButton()
        Me.rdoMaximum = New System.Windows.Forms.RadioButton()
        Me.rdoMinimum = New System.Windows.Forms.RadioButton()
        Me.rdoMean = New System.Windows.Forms.RadioButton()
        Me.rdoTotal = New System.Windows.Forms.RadioButton()
        Me.rdoNumberofCases = New System.Windows.Forms.RadioButton()
        Me.chkClusterBy = New System.Windows.Forms.CheckBox()
        Me.cboClusterBy = New System.Windows.Forms.ComboBox()
        Me.lblChartType = New System.Windows.Forms.Label()
        Me.cboChartType = New System.Windows.Forms.ComboBox()
        Me.lblWeights = New System.Windows.Forms.Label()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.txtWeights = New System.Windows.Forms.TextBox()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.grpSummaryStatistics.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(3, 270)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSummaryChartSelector
        '
        Me.ucrSummaryChartSelector.Location = New System.Drawing.Point(3, 5)
        Me.ucrSummaryChartSelector.Name = "ucrSummaryChartSelector"
        Me.ucrSummaryChartSelector.Size = New System.Drawing.Size(203, 127)
        Me.ucrSummaryChartSelector.TabIndex = 1
        '
        'lblSummaryVariable
        '
        Me.lblSummaryVariable.AutoSize = True
        Me.lblSummaryVariable.Location = New System.Drawing.Point(219, 17)
        Me.lblSummaryVariable.Name = "lblSummaryVariable"
        Me.lblSummaryVariable.Size = New System.Drawing.Size(91, 13)
        Me.lblSummaryVariable.TabIndex = 2
        Me.lblSummaryVariable.Tag = "Summary_Variable"
        Me.lblSummaryVariable.Text = "Summary Variable"
        '
        'ucrSummaryVariableReceiver
        '
        Me.ucrSummaryVariableReceiver.Location = New System.Drawing.Point(216, 40)
        Me.ucrSummaryVariableReceiver.Name = "ucrSummaryVariableReceiver"
        Me.ucrSummaryVariableReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrSummaryVariableReceiver.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(352, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(89, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'lblCategoryFactor
        '
        Me.lblCategoryFactor.AutoSize = True
        Me.lblCategoryFactor.Location = New System.Drawing.Point(350, 17)
        Me.lblCategoryFactor.Name = "lblCategoryFactor"
        Me.lblCategoryFactor.Size = New System.Drawing.Size(82, 13)
        Me.lblCategoryFactor.TabIndex = 2
        Me.lblCategoryFactor.Tag = "Category_Factor"
        Me.lblCategoryFactor.Text = "Category Factor"
        '
        'grpSummaryStatistics
        '
        Me.grpSummaryStatistics.Controls.Add(Me.rdoCases)
        Me.grpSummaryStatistics.Controls.Add(Me.rdoVariance)
        Me.grpSummaryStatistics.Controls.Add(Me.rdoStdDeviation)
        Me.grpSummaryStatistics.Controls.Add(Me.rdoMedian)
        Me.grpSummaryStatistics.Controls.Add(Me.rdoMaximum)
        Me.grpSummaryStatistics.Controls.Add(Me.rdoMinimum)
        Me.grpSummaryStatistics.Controls.Add(Me.rdoMean)
        Me.grpSummaryStatistics.Controls.Add(Me.rdoTotal)
        Me.grpSummaryStatistics.Controls.Add(Me.rdoNumberofCases)
        Me.grpSummaryStatistics.Location = New System.Drawing.Point(222, 66)
        Me.grpSummaryStatistics.Name = "grpSummaryStatistics"
        Me.grpSummaryStatistics.Size = New System.Drawing.Size(226, 159)
        Me.grpSummaryStatistics.TabIndex = 5
        Me.grpSummaryStatistics.TabStop = False
        Me.grpSummaryStatistics.Tag = "Summary_Statistics"
        Me.grpSummaryStatistics.Text = "Summary Statistics"
        '
        'rdoCases
        '
        Me.rdoCases.AutoSize = True
        Me.rdoCases.Location = New System.Drawing.Point(6, 35)
        Me.rdoCases.Name = "rdoCases"
        Me.rdoCases.Size = New System.Drawing.Size(65, 17)
        Me.rdoCases.TabIndex = 0
        Me.rdoCases.TabStop = True
        Me.rdoCases.Tag = "%_Cases"
        Me.rdoCases.Text = "% Cases"
        Me.rdoCases.UseVisualStyleBackColor = True
        '
        'rdoVariance
        '
        Me.rdoVariance.AutoSize = True
        Me.rdoVariance.Location = New System.Drawing.Point(131, 42)
        Me.rdoVariance.Name = "rdoVariance"
        Me.rdoVariance.Size = New System.Drawing.Size(67, 17)
        Me.rdoVariance.TabIndex = 0
        Me.rdoVariance.TabStop = True
        Me.rdoVariance.Tag = "Variance"
        Me.rdoVariance.Text = "Variance"
        Me.rdoVariance.UseVisualStyleBackColor = True
        '
        'rdoStdDeviation
        '
        Me.rdoStdDeviation.AutoSize = True
        Me.rdoStdDeviation.Location = New System.Drawing.Point(130, 20)
        Me.rdoStdDeviation.Name = "rdoStdDeviation"
        Me.rdoStdDeviation.Size = New System.Drawing.Size(89, 17)
        Me.rdoStdDeviation.TabIndex = 0
        Me.rdoStdDeviation.TabStop = True
        Me.rdoStdDeviation.Tag = "Std_Deviation"
        Me.rdoStdDeviation.Text = "Std Deviation"
        Me.rdoStdDeviation.UseVisualStyleBackColor = True
        '
        'rdoMedian
        '
        Me.rdoMedian.AutoSize = True
        Me.rdoMedian.Location = New System.Drawing.Point(6, 141)
        Me.rdoMedian.Name = "rdoMedian"
        Me.rdoMedian.Size = New System.Drawing.Size(60, 17)
        Me.rdoMedian.TabIndex = 0
        Me.rdoMedian.TabStop = True
        Me.rdoMedian.Tag = "Median"
        Me.rdoMedian.Text = "Median"
        Me.rdoMedian.UseVisualStyleBackColor = True
        '
        'rdoMaximum
        '
        Me.rdoMaximum.AutoSize = True
        Me.rdoMaximum.Location = New System.Drawing.Point(6, 118)
        Me.rdoMaximum.Name = "rdoMaximum"
        Me.rdoMaximum.Size = New System.Drawing.Size(69, 17)
        Me.rdoMaximum.TabIndex = 0
        Me.rdoMaximum.TabStop = True
        Me.rdoMaximum.Tag = "Maximum"
        Me.rdoMaximum.Text = "Maximum"
        Me.rdoMaximum.UseVisualStyleBackColor = True
        '
        'rdoMinimum
        '
        Me.rdoMinimum.AutoSize = True
        Me.rdoMinimum.Location = New System.Drawing.Point(6, 95)
        Me.rdoMinimum.Name = "rdoMinimum"
        Me.rdoMinimum.Size = New System.Drawing.Size(66, 17)
        Me.rdoMinimum.TabIndex = 0
        Me.rdoMinimum.TabStop = True
        Me.rdoMinimum.Tag = "Minimum"
        Me.rdoMinimum.Text = "Minimum"
        Me.rdoMinimum.UseVisualStyleBackColor = True
        '
        'rdoMean
        '
        Me.rdoMean.AutoSize = True
        Me.rdoMean.Location = New System.Drawing.Point(7, 72)
        Me.rdoMean.Name = "rdoMean"
        Me.rdoMean.Size = New System.Drawing.Size(52, 17)
        Me.rdoMean.TabIndex = 0
        Me.rdoMean.TabStop = True
        Me.rdoMean.Tag = "Mean"
        Me.rdoMean.Text = "Mean"
        Me.rdoMean.UseVisualStyleBackColor = True
        '
        'rdoTotal
        '
        Me.rdoTotal.AutoSize = True
        Me.rdoTotal.Location = New System.Drawing.Point(6, 52)
        Me.rdoTotal.Name = "rdoTotal"
        Me.rdoTotal.Size = New System.Drawing.Size(49, 17)
        Me.rdoTotal.TabIndex = 0
        Me.rdoTotal.TabStop = True
        Me.rdoTotal.Tag = "Total"
        Me.rdoTotal.Text = "Total"
        Me.rdoTotal.UseVisualStyleBackColor = True
        '
        'rdoNumberofCases
        '
        Me.rdoNumberofCases.AutoSize = True
        Me.rdoNumberofCases.Location = New System.Drawing.Point(7, 17)
        Me.rdoNumberofCases.Name = "rdoNumberofCases"
        Me.rdoNumberofCases.Size = New System.Drawing.Size(106, 17)
        Me.rdoNumberofCases.TabIndex = 0
        Me.rdoNumberofCases.TabStop = True
        Me.rdoNumberofCases.Tag = "Number_of_Cases"
        Me.rdoNumberofCases.Text = "Number of Cases"
        Me.rdoNumberofCases.UseVisualStyleBackColor = True
        '
        'chkClusterBy
        '
        Me.chkClusterBy.AutoSize = True
        Me.chkClusterBy.Location = New System.Drawing.Point(13, 139)
        Me.chkClusterBy.Name = "chkClusterBy"
        Me.chkClusterBy.Size = New System.Drawing.Size(73, 17)
        Me.chkClusterBy.TabIndex = 6
        Me.chkClusterBy.Tag = "Cluster_By"
        Me.chkClusterBy.Text = "Cluster By"
        Me.chkClusterBy.UseVisualStyleBackColor = True
        '
        'cboClusterBy
        '
        Me.cboClusterBy.FormattingEnabled = True
        Me.cboClusterBy.Location = New System.Drawing.Point(13, 162)
        Me.cboClusterBy.Name = "cboClusterBy"
        Me.cboClusterBy.Size = New System.Drawing.Size(89, 21)
        Me.cboClusterBy.TabIndex = 4
        '
        'lblChartType
        '
        Me.lblChartType.AutoSize = True
        Me.lblChartType.Location = New System.Drawing.Point(115, 139)
        Me.lblChartType.Name = "lblChartType"
        Me.lblChartType.Size = New System.Drawing.Size(59, 13)
        Me.lblChartType.TabIndex = 2
        Me.lblChartType.Tag = "Chart_Type"
        Me.lblChartType.Text = "Chart Type"
        '
        'cboChartType
        '
        Me.cboChartType.FormattingEnabled = True
        Me.cboChartType.Items.AddRange(New Object() {"Bar", "HBar", "Pie", "Line"})
        Me.cboChartType.Location = New System.Drawing.Point(117, 162)
        Me.cboChartType.Name = "cboChartType"
        Me.cboChartType.Size = New System.Drawing.Size(89, 21)
        Me.cboChartType.TabIndex = 4
        '
        'lblWeights
        '
        Me.lblWeights.AutoSize = True
        Me.lblWeights.Location = New System.Drawing.Point(13, 190)
        Me.lblWeights.Name = "lblWeights"
        Me.lblWeights.Size = New System.Drawing.Size(46, 13)
        Me.lblWeights.TabIndex = 7
        Me.lblWeights.Tag = "Weights"
        Me.lblWeights.Text = "Weights"
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(16, 218)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(29, 13)
        Me.lblFilter.TabIndex = 8
        Me.lblFilter.Tag = "Filter"
        Me.lblFilter.Text = "Filter"
        '
        'txtWeights
        '
        Me.txtWeights.Location = New System.Drawing.Point(65, 190)
        Me.txtWeights.Name = "txtWeights"
        Me.txtWeights.Size = New System.Drawing.Size(37, 20)
        Me.txtWeights.TabIndex = 9
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(65, 215)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(37, 20)
        Me.txtFilter.TabIndex = 9
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(16, 244)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Title"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(65, 241)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(383, 20)
        Me.TextBox1.TabIndex = 9
        '
        'dlgSummaryChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 302)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtWeights)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.lblWeights)
        Me.Controls.Add(Me.chkClusterBy)
        Me.Controls.Add(Me.grpSummaryStatistics)
        Me.Controls.Add(Me.cboClusterBy)
        Me.Controls.Add(Me.cboChartType)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblChartType)
        Me.Controls.Add(Me.ucrSummaryVariableReceiver)
        Me.Controls.Add(Me.lblCategoryFactor)
        Me.Controls.Add(Me.lblSummaryVariable)
        Me.Controls.Add(Me.ucrSummaryChartSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgSummaryChart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Summary_Chart"
        Me.Text = "Summary Chart"
        Me.grpSummaryStatistics.ResumeLayout(False)
        Me.grpSummaryStatistics.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSummaryChartSelector As ucrSelectorAddRemove
    Friend WithEvents lblSummaryVariable As Label
    Friend WithEvents ucrSummaryVariableReceiver As ucrReceiverSingle
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblCategoryFactor As Label
    Friend WithEvents grpSummaryStatistics As GroupBox
    Friend WithEvents rdoCases As RadioButton
    Friend WithEvents rdoVariance As RadioButton
    Friend WithEvents rdoStdDeviation As RadioButton
    Friend WithEvents rdoMedian As RadioButton
    Friend WithEvents rdoMaximum As RadioButton
    Friend WithEvents rdoMinimum As RadioButton
    Friend WithEvents rdoMean As RadioButton
    Friend WithEvents rdoTotal As RadioButton
    Friend WithEvents rdoNumberofCases As RadioButton
    Friend WithEvents chkClusterBy As CheckBox
    Friend WithEvents cboClusterBy As ComboBox
    Friend WithEvents lblChartType As Label
    Friend WithEvents cboChartType As ComboBox
    Friend WithEvents lblWeights As Label
    Friend WithEvents lblFilter As Label
    Friend WithEvents txtWeights As TextBox
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents TextBox1 As TextBox
End Class
