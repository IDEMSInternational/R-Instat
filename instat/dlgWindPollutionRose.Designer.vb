<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgWindPollutionRose
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
        Me.ucrWindPollutionRoseSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverWindDirection = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindSpeed = New instat.ucrReceiverSingle()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.ucrChkCompare = New instat.ucrCheck()
        Me.ucrReceiverWindSpeed2 = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindDirection2 = New instat.ucrReceiverSingle()
        Me.lblWindSpeed2 = New System.Windows.Forms.Label()
        Me.lblWindDirection2 = New System.Windows.Forms.Label()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.cmdWindroseOptions = New System.Windows.Forms.Button()
        Me.ucrChkPaddle = New instat.ucrCheck()
        Me.ucrChkNormalise = New instat.ucrCheck()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.ucrInputSummary = New instat.ucrInputComboBox()
        Me.ucrReceiverFacet = New instat.ucrReceiverSingle()
        Me.lblFacet = New System.Windows.Forms.Label()
        Me.ucrReceiverFacet2 = New instat.ucrReceiverSingle()
        Me.lblFacet2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 350)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 1
        '
        'ucrWindPollutionRoseSelector
        '
        Me.ucrWindPollutionRoseSelector.bDropUnusedFilterLevels = False
        Me.ucrWindPollutionRoseSelector.bShowHiddenColumns = False
        Me.ucrWindPollutionRoseSelector.bUseCurrentFilter = True
        Me.ucrWindPollutionRoseSelector.Location = New System.Drawing.Point(9, 9)
        Me.ucrWindPollutionRoseSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrWindPollutionRoseSelector.Name = "ucrWindPollutionRoseSelector"
        Me.ucrWindPollutionRoseSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrWindPollutionRoseSelector.TabIndex = 2
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.frmParent = Me
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(265, 93)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindDirection.strNcFilePath = ""
        Me.ucrReceiverWindDirection.TabIndex = 9
        Me.ucrReceiverWindDirection.ucrSelector = Nothing
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.frmParent = Me
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(265, 45)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindSpeed.strNcFilePath = ""
        Me.ucrReceiverWindSpeed.TabIndex = 7
        Me.ucrReceiverWindSpeed.ucrSelector = Nothing
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.Location = New System.Drawing.Point(265, 78)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(80, 13)
        Me.lblYVariable.TabIndex = 8
        Me.lblYVariable.Text = "Wind Direction:"
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.Location = New System.Drawing.Point(265, 30)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(69, 13)
        Me.lblXVariable.TabIndex = 6
        Me.lblXVariable.Text = "Wind Speed:"
        '
        'ucrChkCompare
        '
        Me.ucrChkCompare.Checked = False
        Me.ucrChkCompare.Location = New System.Drawing.Point(268, 118)
        Me.ucrChkCompare.Name = "ucrChkCompare"
        Me.ucrChkCompare.Size = New System.Drawing.Size(120, 20)
        Me.ucrChkCompare.TabIndex = 10
        '
        'ucrReceiverWindSpeed2
        '
        Me.ucrReceiverWindSpeed2.frmParent = Me
        Me.ucrReceiverWindSpeed2.Location = New System.Drawing.Point(265, 155)
        Me.ucrReceiverWindSpeed2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed2.Name = "ucrReceiverWindSpeed2"
        Me.ucrReceiverWindSpeed2.Selector = Nothing
        Me.ucrReceiverWindSpeed2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindSpeed2.strNcFilePath = ""
        Me.ucrReceiverWindSpeed2.TabIndex = 11
        Me.ucrReceiverWindSpeed2.ucrSelector = Nothing
        '
        'ucrReceiverWindDirection2
        '
        Me.ucrReceiverWindDirection2.frmParent = Me
        Me.ucrReceiverWindDirection2.Location = New System.Drawing.Point(265, 196)
        Me.ucrReceiverWindDirection2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection2.Name = "ucrReceiverWindDirection2"
        Me.ucrReceiverWindDirection2.Selector = Nothing
        Me.ucrReceiverWindDirection2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindDirection2.strNcFilePath = ""
        Me.ucrReceiverWindDirection2.TabIndex = 12
        Me.ucrReceiverWindDirection2.ucrSelector = Nothing
        '
        'lblWindSpeed2
        '
        Me.lblWindSpeed2.AutoSize = True
        Me.lblWindSpeed2.Location = New System.Drawing.Point(265, 140)
        Me.lblWindSpeed2.Name = "lblWindSpeed2"
        Me.lblWindSpeed2.Size = New System.Drawing.Size(78, 13)
        Me.lblWindSpeed2.TabIndex = 13
        Me.lblWindSpeed2.Text = "Wind Speed 2:"
        '
        'lblWindDirection2
        '
        Me.lblWindDirection2.AutoSize = True
        Me.lblWindDirection2.Location = New System.Drawing.Point(265, 181)
        Me.lblWindDirection2.Name = "lblWindDirection2"
        Me.lblWindDirection2.Size = New System.Drawing.Size(89, 13)
        Me.lblWindDirection2.TabIndex = 14
        Me.lblWindDirection2.Text = "Wind Direction 2:"
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(13, 317)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(304, 24)
        Me.ucrSaveGraph.TabIndex = 15
        '
        'cmdWindroseOptions
        '
        Me.cmdWindroseOptions.Location = New System.Drawing.Point(10, 201)
        Me.cmdWindroseOptions.Name = "cmdWindroseOptions"
        Me.cmdWindroseOptions.Size = New System.Drawing.Size(105, 23)
        Me.cmdWindroseOptions.TabIndex = 16
        Me.cmdWindroseOptions.Text = "Windrose Options"
        Me.cmdWindroseOptions.UseVisualStyleBackColor = True
        '
        'ucrChkPaddle
        '
        Me.ucrChkPaddle.Checked = False
        Me.ucrChkPaddle.Location = New System.Drawing.Point(10, 232)
        Me.ucrChkPaddle.Name = "ucrChkPaddle"
        Me.ucrChkPaddle.Size = New System.Drawing.Size(139, 20)
        Me.ucrChkPaddle.TabIndex = 17
        '
        'ucrChkNormalise
        '
        Me.ucrChkNormalise.Checked = False
        Me.ucrChkNormalise.Location = New System.Drawing.Point(10, 258)
        Me.ucrChkNormalise.Name = "ucrChkNormalise"
        Me.ucrChkNormalise.Size = New System.Drawing.Size(139, 20)
        Me.ucrChkNormalise.TabIndex = 18
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Location = New System.Drawing.Point(6, 289)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(53, 13)
        Me.lblSummary.TabIndex = 19
        Me.lblSummary.Text = "Summary:"
        '
        'ucrInputSummary
        '
        Me.ucrInputSummary.AddQuotesIfUnrecognised = True
        Me.ucrInputSummary.GetSetSelectedIndex = -1
        Me.ucrInputSummary.IsReadOnly = False
        Me.ucrInputSummary.Location = New System.Drawing.Point(66, 285)
        Me.ucrInputSummary.Name = "ucrInputSummary"
        Me.ucrInputSummary.Size = New System.Drawing.Size(92, 21)
        Me.ucrInputSummary.TabIndex = 20
        '
        'ucrReceiverFacet
        '
        Me.ucrReceiverFacet.frmParent = Me
        Me.ucrReceiverFacet.Location = New System.Drawing.Point(264, 235)
        Me.ucrReceiverFacet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacet.Name = "ucrReceiverFacet"
        Me.ucrReceiverFacet.Selector = Nothing
        Me.ucrReceiverFacet.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFacet.strNcFilePath = ""
        Me.ucrReceiverFacet.TabIndex = 22
        Me.ucrReceiverFacet.ucrSelector = Nothing
        '
        'lblFacet
        '
        Me.lblFacet.AutoSize = True
        Me.lblFacet.Location = New System.Drawing.Point(265, 222)
        Me.lblFacet.Name = "lblFacet"
        Me.lblFacet.Size = New System.Drawing.Size(37, 13)
        Me.lblFacet.TabIndex = 21
        Me.lblFacet.Text = "Facet:"
        '
        'ucrReceiverFacet2
        '
        Me.ucrReceiverFacet2.frmParent = Me
        Me.ucrReceiverFacet2.Location = New System.Drawing.Point(263, 270)
        Me.ucrReceiverFacet2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFacet2.Name = "ucrReceiverFacet2"
        Me.ucrReceiverFacet2.Selector = Nothing
        Me.ucrReceiverFacet2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFacet2.strNcFilePath = ""
        Me.ucrReceiverFacet2.TabIndex = 24
        Me.ucrReceiverFacet2.ucrSelector = Nothing
        '
        'lblFacet2
        '
        Me.lblFacet2.AutoSize = True
        Me.lblFacet2.Location = New System.Drawing.Point(265, 257)
        Me.lblFacet2.Name = "lblFacet2"
        Me.lblFacet2.Size = New System.Drawing.Size(37, 13)
        Me.lblFacet2.TabIndex = 23
        Me.lblFacet2.Text = "Facet:"
        '
        'dlgWindPollutionRose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 405)
        Me.Controls.Add(Me.ucrReceiverFacet2)
        Me.Controls.Add(Me.lblFacet2)
        Me.Controls.Add(Me.ucrReceiverFacet)
        Me.Controls.Add(Me.lblFacet)
        Me.Controls.Add(Me.ucrInputSummary)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.ucrChkNormalise)
        Me.Controls.Add(Me.ucrChkPaddle)
        Me.Controls.Add(Me.cmdWindroseOptions)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.lblWindDirection2)
        Me.Controls.Add(Me.lblWindSpeed2)
        Me.Controls.Add(Me.ucrReceiverWindDirection2)
        Me.Controls.Add(Me.ucrReceiverWindSpeed2)
        Me.Controls.Add(Me.ucrChkCompare)
        Me.Controls.Add(Me.ucrReceiverWindDirection)
        Me.Controls.Add(Me.ucrReceiverWindSpeed)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrWindPollutionRoseSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgWindPollutionRose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wind/Pollution Rose"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrWindPollutionRoseSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverWindDirection As ucrReceiverSingle
    Friend WithEvents ucrReceiverWindSpeed As ucrReceiverSingle
    Friend WithEvents lblYVariable As Label
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrChkCompare As ucrCheck
    Friend WithEvents lblWindDirection2 As Label
    Friend WithEvents lblWindSpeed2 As Label
    Friend WithEvents ucrReceiverWindDirection2 As ucrReceiverSingle
    Friend WithEvents ucrReceiverWindSpeed2 As ucrReceiverSingle
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents cmdWindroseOptions As Button
    Friend WithEvents ucrChkPaddle As ucrCheck
    Friend WithEvents ucrInputSummary As ucrInputComboBox
    Friend WithEvents lblSummary As Label
    Friend WithEvents ucrChkNormalise As ucrCheck
    Friend WithEvents ucrReceiverFacet As ucrReceiverSingle
    Friend WithEvents lblFacet As Label
    Friend WithEvents ucrReceiverFacet2 As ucrReceiverSingle
    Friend WithEvents lblFacet2 As Label
End Class
