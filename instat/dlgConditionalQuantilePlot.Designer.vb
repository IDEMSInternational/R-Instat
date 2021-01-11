<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgConditionalQuantilePlot
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
        Me.components = New System.ComponentModel.Container()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrConditionalQuantilePlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverObservations = New instat.ucrReceiverSingle()
        Me.lblObservations = New System.Windows.Forms.Label()
        Me.lblPredictions = New System.Windows.Forms.Label()
        Me.ucrReceiverPredictions = New instat.ucrReceiverSingle()
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.ucrNudBin = New instat.ucrNud()
        Me.ucrSavePlot = New instat.ucrSave()
        Me.lblType = New System.Windows.Forms.Label()
        Me.ucrReceiverMultipleFacet = New instat.ucrReceiverMultiple()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrNudKeyColumns = New instat.ucrNud()
        Me.ucrInputMinBin = New instat.ucrInputTextBox()
        Me.ttConditionalQuatilePlot = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(8, 378)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrConditionalQuantilePlotSelector
        '
        Me.ucrConditionalQuantilePlotSelector.bDropUnusedFilterLevels = False
        Me.ucrConditionalQuantilePlotSelector.bShowHiddenColumns = False
        Me.ucrConditionalQuantilePlotSelector.bUseCurrentFilter = True
        Me.ucrConditionalQuantilePlotSelector.Location = New System.Drawing.Point(9, 19)
        Me.ucrConditionalQuantilePlotSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrConditionalQuantilePlotSelector.Name = "ucrConditionalQuantilePlotSelector"
        Me.ucrConditionalQuantilePlotSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrConditionalQuantilePlotSelector.TabIndex = 4
        '
        'ucrReceiverObservations
        '
        Me.ucrReceiverObservations.frmParent = Me
        Me.ucrReceiverObservations.Location = New System.Drawing.Point(265, 68)
        Me.ucrReceiverObservations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverObservations.Name = "ucrReceiverObservations"
        Me.ucrReceiverObservations.Selector = Nothing
        Me.ucrReceiverObservations.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverObservations.strNcFilePath = ""
        Me.ucrReceiverObservations.TabIndex = 62
        Me.ucrReceiverObservations.ucrSelector = Nothing
        '
        'lblObservations
        '
        Me.lblObservations.AutoSize = True
        Me.lblObservations.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblObservations.Location = New System.Drawing.Point(267, 50)
        Me.lblObservations.Name = "lblObservations"
        Me.lblObservations.Size = New System.Drawing.Size(72, 13)
        Me.lblObservations.TabIndex = 63
        Me.lblObservations.Text = "Observations:"
        '
        'lblPredictions
        '
        Me.lblPredictions.AutoSize = True
        Me.lblPredictions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPredictions.Location = New System.Drawing.Point(267, 112)
        Me.lblPredictions.Name = "lblPredictions"
        Me.lblPredictions.Size = New System.Drawing.Size(62, 13)
        Me.lblPredictions.TabIndex = 64
        Me.lblPredictions.Text = "Predictions:"
        '
        'ucrReceiverPredictions
        '
        Me.ucrReceiverPredictions.frmParent = Me
        Me.ucrReceiverPredictions.Location = New System.Drawing.Point(265, 131)
        Me.ucrReceiverPredictions.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPredictions.Name = "ucrReceiverPredictions"
        Me.ucrReceiverPredictions.Selector = Nothing
        Me.ucrReceiverPredictions.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPredictions.strNcFilePath = ""
        Me.ucrReceiverPredictions.TabIndex = 65
        Me.ucrReceiverPredictions.ucrSelector = Nothing
        '
        'cmdPlotOptions
        '
        Me.cmdPlotOptions.Enabled = False
        Me.cmdPlotOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlotOptions.Location = New System.Drawing.Point(9, 211)
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdPlotOptions.TabIndex = 66
        Me.cmdPlotOptions.Text = "Plot Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'ucrNudBin
        '
        Me.ucrNudBin.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBin.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBin.Location = New System.Drawing.Point(44, 246)
        Me.ucrNudBin.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBin.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBin.Name = "ucrNudBin"
        Me.ucrNudBin.Size = New System.Drawing.Size(40, 20)
        Me.ucrNudBin.TabIndex = 68
        Me.ucrNudBin.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSavePlot
        '
        Me.ucrSavePlot.Location = New System.Drawing.Point(9, 352)
        Me.ucrSavePlot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSavePlot.Name = "ucrSavePlot"
        Me.ucrSavePlot.Size = New System.Drawing.Size(251, 24)
        Me.ucrSavePlot.TabIndex = 72
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblType.Location = New System.Drawing.Point(267, 176)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(100, 13)
        Me.lblType.TabIndex = 66
        Me.lblType.Text = "Facet By (Optional):"
        '
        'ucrReceiverMultipleFacet
        '
        Me.ucrReceiverMultipleFacet.frmParent = Me
        Me.ucrReceiverMultipleFacet.Location = New System.Drawing.Point(265, 196)
        Me.ucrReceiverMultipleFacet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleFacet.Name = "ucrReceiverMultipleFacet"
        Me.ucrReceiverMultipleFacet.Selector = Nothing
        Me.ucrReceiverMultipleFacet.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleFacet.strNcFilePath = ""
        Me.ucrReceiverMultipleFacet.TabIndex = 73
        Me.ucrReceiverMultipleFacet.ucrSelector = Nothing
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(95, 299)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(98, 21)
        Me.ucrInputLegendPosition.TabIndex = 75
        '
        'ucrNudKeyColumns
        '
        Me.ucrNudKeyColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudKeyColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudKeyColumns.Location = New System.Drawing.Point(95, 327)
        Me.ucrNudKeyColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudKeyColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudKeyColumns.Name = "ucrNudKeyColumns"
        Me.ucrNudKeyColumns.Size = New System.Drawing.Size(40, 20)
        Me.ucrNudKeyColumns.TabIndex = 76
        Me.ucrNudKeyColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputMinBin
        '
        Me.ucrInputMinBin.AddQuotesIfUnrecognised = True
        Me.ucrInputMinBin.IsMultiline = False
        Me.ucrInputMinBin.IsReadOnly = False
        Me.ucrInputMinBin.Location = New System.Drawing.Point(148, 271)
        Me.ucrInputMinBin.Name = "ucrInputMinBin"
        Me.ucrInputMinBin.Size = New System.Drawing.Size(64, 21)
        Me.ucrInputMinBin.TabIndex = 78
        '
        'ttConditionalQuatilePlot
        '
        Me.ttConditionalQuatilePlot.AutoPopDelay = 10000
        Me.ttConditionalQuatilePlot.InitialDelay = 500
        Me.ttConditionalQuatilePlot.ReshowDelay = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(9, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Bins:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(9, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Minimum Number of Points:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(9, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Key Position:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(9, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Key Column(s):"
        '
        'dlgConditionalQuantilePlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 430)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrInputMinBin)
        Me.Controls.Add(Me.ucrNudKeyColumns)
        Me.Controls.Add(Me.ucrInputLegendPosition)
        Me.Controls.Add(Me.ucrReceiverMultipleFacet)
        Me.Controls.Add(Me.ucrSavePlot)
        Me.Controls.Add(Me.ucrNudBin)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.lblPredictions)
        Me.Controls.Add(Me.ucrReceiverPredictions)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.ucrReceiverObservations)
        Me.Controls.Add(Me.lblObservations)
        Me.Controls.Add(Me.ucrConditionalQuantilePlotSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgConditionalQuantilePlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conditional Quantile Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrConditionalQuantilePlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverObservations As ucrReceiverSingle
    Friend WithEvents lblObservations As Label
    Friend WithEvents lblPredictions As Label
    Friend WithEvents ucrReceiverPredictions As ucrReceiverSingle
    Friend WithEvents cmdPlotOptions As Button
    Friend WithEvents ucrNudBin As ucrNud
    Friend WithEvents ucrSavePlot As ucrSave
    Friend WithEvents lblType As Label
    Friend WithEvents ucrReceiverMultipleFacet As ucrReceiverMultiple
    Friend WithEvents ucrNudKeyColumns As ucrNud
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrInputMinBin As ucrInputTextBox
    Friend WithEvents ttConditionalQuatilePlot As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
