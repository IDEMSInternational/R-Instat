<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTimeSeriesPlot
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
        Me.ucrDataSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblReference = New System.Windows.Forms.Label()
        Me.ucrReceiverReference = New instat.ucrReceiverSingle()
        Me.UcrReceiverSingle2 = New instat.ucrReceiverSingle()
        Me.lblEstimate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.UcrReceiverSingle4 = New instat.ucrReceiverSingle()
        Me.ucrChkValues = New instat.ucrCheck()
        Me.ucrChkIncludeMeanLines = New instat.ucrCheck()
        Me.ucrChkIncludePoints = New instat.ucrCheck()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.ucrSavePlot = New instat.ucrSaveGraph()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 425)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrDataSelector
        '
        Me.ucrDataSelector.bDropUnusedFilterLevels = False
        Me.ucrDataSelector.bShowHiddenColumns = False
        Me.ucrDataSelector.bUseCurrentFilter = True
        Me.ucrDataSelector.Location = New System.Drawing.Point(12, 9)
        Me.ucrDataSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataSelector.Name = "ucrDataSelector"
        Me.ucrDataSelector.Size = New System.Drawing.Size(218, 180)
        Me.ucrDataSelector.TabIndex = 1
        '
        'lblReference
        '
        Me.lblReference.AutoSize = True
        Me.lblReference.Location = New System.Drawing.Point(286, 15)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(60, 13)
        Me.lblReference.TabIndex = 2
        Me.lblReference.Text = "Reference:"
        '
        'ucrReceiverReference
        '
        Me.ucrReceiverReference.frmParent = Me
        Me.ucrReceiverReference.Location = New System.Drawing.Point(286, 39)
        Me.ucrReceiverReference.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverReference.Name = "ucrReceiverReference"
        Me.ucrReceiverReference.Selector = Nothing
        Me.ucrReceiverReference.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverReference.strNcFilePath = ""
        Me.ucrReceiverReference.TabIndex = 3
        Me.ucrReceiverReference.ucrSelector = Nothing
        '
        'UcrReceiverSingle2
        '
        Me.UcrReceiverSingle2.frmParent = Me
        Me.UcrReceiverSingle2.Location = New System.Drawing.Point(286, 92)
        Me.UcrReceiverSingle2.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle2.Name = "UcrReceiverSingle2"
        Me.UcrReceiverSingle2.Selector = Nothing
        Me.UcrReceiverSingle2.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverSingle2.strNcFilePath = ""
        Me.UcrReceiverSingle2.TabIndex = 4
        Me.UcrReceiverSingle2.ucrSelector = Nothing
        '
        'lblEstimate
        '
        Me.lblEstimate.AutoSize = True
        Me.lblEstimate.Location = New System.Drawing.Point(286, 67)
        Me.lblEstimate.Name = "lblEstimate"
        Me.lblEstimate.Size = New System.Drawing.Size(50, 13)
        Me.lblEstimate.TabIndex = 5
        Me.lblEstimate.Text = "Estimate:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(286, 119)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 6
        Me.lblYear.Text = "Year:"
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(286, 151)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 7
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(286, 180)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 8
        Me.lblStation.Text = "Station:"
        '
        'UcrReceiverSingle4
        '
        Me.UcrReceiverSingle4.frmParent = Me
        Me.UcrReceiverSingle4.Location = New System.Drawing.Point(286, 208)
        Me.UcrReceiverSingle4.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle4.Name = "UcrReceiverSingle4"
        Me.UcrReceiverSingle4.Selector = Nothing
        Me.UcrReceiverSingle4.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverSingle4.strNcFilePath = ""
        Me.UcrReceiverSingle4.TabIndex = 9
        Me.UcrReceiverSingle4.ucrSelector = Nothing
        '
        'ucrChkValues
        '
        Me.ucrChkValues.Checked = False
        Me.ucrChkValues.Location = New System.Drawing.Point(12, 235)
        Me.ucrChkValues.Name = "ucrChkValues"
        Me.ucrChkValues.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkValues.TabIndex = 10
        '
        'ucrChkIncludeMeanLines
        '
        Me.ucrChkIncludeMeanLines.Checked = False
        Me.ucrChkIncludeMeanLines.Location = New System.Drawing.Point(12, 310)
        Me.ucrChkIncludeMeanLines.Name = "ucrChkIncludeMeanLines"
        Me.ucrChkIncludeMeanLines.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkIncludeMeanLines.TabIndex = 11
        '
        'ucrChkIncludePoints
        '
        Me.ucrChkIncludePoints.Checked = False
        Me.ucrChkIncludePoints.Location = New System.Drawing.Point(12, 274)
        Me.ucrChkIncludePoints.Name = "ucrChkIncludePoints"
        Me.ucrChkIncludePoints.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkIncludePoints.TabIndex = 12
        '
        'cmdSummaries
        '
        Me.cmdSummaries.Location = New System.Drawing.Point(12, 336)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(115, 32)
        Me.cmdSummaries.TabIndex = 13
        Me.cmdSummaries.Text = "Summaries"
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'ucrSavePlot
        '
        Me.ucrSavePlot.Location = New System.Drawing.Point(12, 385)
        Me.ucrSavePlot.Name = "ucrSavePlot"
        Me.ucrSavePlot.Size = New System.Drawing.Size(265, 20)
        Me.ucrSavePlot.TabIndex = 14
        '
        'dlgTimeSeriesPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 482)
        Me.Controls.Add(Me.ucrSavePlot)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.ucrChkIncludePoints)
        Me.Controls.Add(Me.ucrChkIncludeMeanLines)
        Me.Controls.Add(Me.ucrChkValues)
        Me.Controls.Add(Me.UcrReceiverSingle4)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblEstimate)
        Me.Controls.Add(Me.UcrReceiverSingle2)
        Me.Controls.Add(Me.ucrReceiverReference)
        Me.Controls.Add(Me.lblReference)
        Me.Controls.Add(Me.ucrDataSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTimeSeriesPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time Series Comparisons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblReference As Label
    Friend WithEvents ucrReceiverReference As ucrReceiverSingle
    Friend WithEvents ucrSavePlot As ucrSaveGraph
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents ucrChkIncludePoints As ucrCheck
    Friend WithEvents ucrChkIncludeMeanLines As ucrCheck
    Friend WithEvents ucrChkValues As ucrCheck
    Friend WithEvents UcrReceiverSingle4 As ucrReceiverSingle
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblYear As Label
    Friend WithEvents lblEstimate As Label
    Friend WithEvents UcrReceiverSingle2 As ucrReceiverSingle
End Class
