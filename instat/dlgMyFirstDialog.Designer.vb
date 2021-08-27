<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMyFirstDialog
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
        Me.ucrSelectorMyFirstDialog = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrReceiverY = New instat.ucrReceiverSingle()
        Me.lblVariableX = New System.Windows.Forms.Label()
        Me.lblVariableY = New System.Windows.Forms.Label()
        Me.rdoLinePlot = New instat.ucrRadio()
        Me.rdoBarPlot = New instat.ucrRadio()
        Me.grpPlotType = New System.Windows.Forms.GroupBox()
        Me.ucrNumber = New instat.ucrNud()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.ucrInputColour = New System.Windows.Forms.ComboBox()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.ucrSaveGraph = New instat.ucrSaveGraph()
        Me.ucrChkLeftAlign = New instat.ucrCheck()
        Me.grpPlotType.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 328)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorMyFirstDialog
        '
        Me.ucrSelectorMyFirstDialog.bDropUnusedFilterLevels = False
        Me.ucrSelectorMyFirstDialog.bShowHiddenColumns = False
        Me.ucrSelectorMyFirstDialog.bUseCurrentFilter = True
        Me.ucrSelectorMyFirstDialog.Location = New System.Drawing.Point(12, 19)
        Me.ucrSelectorMyFirstDialog.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorMyFirstDialog.Name = "ucrSelectorMyFirstDialog"
        Me.ucrSelectorMyFirstDialog.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorMyFirstDialog.TabIndex = 1
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(272, 47)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 2
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrReceiverY
        '
        Me.ucrReceiverY.frmParent = Me
        Me.ucrReceiverY.Location = New System.Drawing.Point(272, 108)
        Me.ucrReceiverY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverY.Name = "ucrReceiverY"
        Me.ucrReceiverY.Selector = Nothing
        Me.ucrReceiverY.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverY.strNcFilePath = ""
        Me.ucrReceiverY.TabIndex = 3
        Me.ucrReceiverY.ucrSelector = Nothing
        '
        'lblVariableX
        '
        Me.lblVariableX.AutoSize = True
        Me.lblVariableX.Location = New System.Drawing.Point(272, 34)
        Me.lblVariableX.Name = "lblVariableX"
        Me.lblVariableX.Size = New System.Drawing.Size(55, 13)
        Me.lblVariableX.TabIndex = 4
        Me.lblVariableX.Text = "Variable X"
        '
        'lblVariableY
        '
        Me.lblVariableY.AutoSize = True
        Me.lblVariableY.Location = New System.Drawing.Point(272, 95)
        Me.lblVariableY.Name = "lblVariableY"
        Me.lblVariableY.Size = New System.Drawing.Size(55, 13)
        Me.lblVariableY.TabIndex = 5
        Me.lblVariableY.Text = "Variable Y"
        '
        'rdoLinePlot
        '
        Me.rdoLinePlot.Location = New System.Drawing.Point(13, 19)
        Me.rdoLinePlot.Name = "rdoLinePlot"
        Me.rdoLinePlot.Size = New System.Drawing.Size(100, 20)
        Me.rdoLinePlot.TabIndex = 6
        '
        'rdoBarPlot
        '
        Me.rdoBarPlot.Location = New System.Drawing.Point(13, 45)
        Me.rdoBarPlot.Name = "rdoBarPlot"
        Me.rdoBarPlot.Size = New System.Drawing.Size(100, 20)
        Me.rdoBarPlot.TabIndex = 7
        '
        'grpPlotType
        '
        Me.grpPlotType.Controls.Add(Me.rdoLinePlot)
        Me.grpPlotType.Controls.Add(Me.rdoBarPlot)
        Me.grpPlotType.Location = New System.Drawing.Point(12, 216)
        Me.grpPlotType.Name = "grpPlotType"
        Me.grpPlotType.Size = New System.Drawing.Size(161, 79)
        Me.grpPlotType.TabIndex = 8
        Me.grpPlotType.TabStop = False
        Me.grpPlotType.Text = "Plot Type"
        '
        'ucrNumber
        '
        Me.ucrNumber.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNumber.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNumber.Location = New System.Drawing.Point(322, 159)
        Me.ucrNumber.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNumber.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNumber.Name = "ucrNumber"
        Me.ucrNumber.Size = New System.Drawing.Size(50, 20)
        Me.ucrNumber.TabIndex = 9
        Me.ucrNumber.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(269, 159)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(47, 13)
        Me.lblNumber.TabIndex = 10
        Me.lblNumber.Text = "Number:"
        '
        'ucrInputColour
        '
        Me.ucrInputColour.FormattingEnabled = True
        Me.ucrInputColour.Location = New System.Drawing.Point(310, 199)
        Me.ucrInputColour.Name = "ucrInputColour"
        Me.ucrInputColour.Size = New System.Drawing.Size(121, 21)
        Me.ucrInputColour.TabIndex = 11
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(269, 202)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(40, 13)
        Me.lblColour.TabIndex = 12
        Me.lblColour.Text = "Colour:"
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(272, 272)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(154, 32)
        Me.ucrSaveGraph.TabIndex = 13
        '
        'ucrChkLeftAlign
        '
        Me.ucrChkLeftAlign.Checked = False
        Me.ucrChkLeftAlign.Location = New System.Drawing.Point(272, 235)
        Me.ucrChkLeftAlign.Name = "ucrChkLeftAlign"
        Me.ucrChkLeftAlign.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkLeftAlign.TabIndex = 14
        '
        'dlgMyFirstDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 392)
        Me.Controls.Add(Me.ucrChkLeftAlign)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.ucrInputColour)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.ucrNumber)
        Me.Controls.Add(Me.lblVariableY)
        Me.Controls.Add(Me.lblVariableX)
        Me.Controls.Add(Me.ucrReceiverY)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrSelectorMyFirstDialog)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpPlotType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMyFirstDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My First Dialog"
        Me.grpPlotType.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorMyFirstDialog As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents ucrChkLeftAlign As ucrCheck
    Friend WithEvents ucrSaveGraph As ucrSaveGraph
    Friend WithEvents lblColour As Label
    Friend WithEvents ucrInputColour As ComboBox
    Friend WithEvents lblNumber As Label
    Friend WithEvents ucrNumber As ucrNud
    Friend WithEvents lblVariableY As Label
    Friend WithEvents lblVariableX As Label
    Friend WithEvents ucrReceiverY As ucrReceiverSingle
    Friend WithEvents grpPlotType As GroupBox
    Friend WithEvents rdoLinePlot As ucrRadio
    Friend WithEvents rdoBarPlot As ucrRadio
End Class
