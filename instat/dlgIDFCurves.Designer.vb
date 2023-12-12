<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgIDFCurves
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
        Me.ucrIDFCurvesSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverDateTime = New instat.ucrReceiverSingle()
        Me.ucrReceiverPrec = New instat.ucrReceiverSingle()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblRain = New System.Windows.Forms.Label()
        Me.ucrStationName = New instat.ucrInputTextBox()
        Me.lblStationName = New System.Windows.Forms.Label()
        Me.ucrNudMaxPrec = New instat.ucrNud()
        Me.lblMinimumProp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(6, 298)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrIDFCurvesSelector
        '
        Me.ucrIDFCurvesSelector.AutoSize = True
        Me.ucrIDFCurvesSelector.bDropUnusedFilterLevels = False
        Me.ucrIDFCurvesSelector.bShowHiddenColumns = False
        Me.ucrIDFCurvesSelector.bUseCurrentFilter = True
        Me.ucrIDFCurvesSelector.Location = New System.Drawing.Point(6, 16)
        Me.ucrIDFCurvesSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrIDFCurvesSelector.Name = "ucrIDFCurvesSelector"
        Me.ucrIDFCurvesSelector.Size = New System.Drawing.Size(213, 183)
        Me.ucrIDFCurvesSelector.TabIndex = 1
        '
        'ucrReceiverDateTime
        '
        Me.ucrReceiverDateTime.AutoSize = True
        Me.ucrReceiverDateTime.frmParent = Me
        Me.ucrReceiverDateTime.Location = New System.Drawing.Point(279, 72)
        Me.ucrReceiverDateTime.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDateTime.Name = "ucrReceiverDateTime"
        Me.ucrReceiverDateTime.Selector = Nothing
        Me.ucrReceiverDateTime.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDateTime.strNcFilePath = ""
        Me.ucrReceiverDateTime.TabIndex = 2
        Me.ucrReceiverDateTime.ucrSelector = Nothing
        '
        'ucrReceiverPrec
        '
        Me.ucrReceiverPrec.AutoSize = True
        Me.ucrReceiverPrec.frmParent = Me
        Me.ucrReceiverPrec.Location = New System.Drawing.Point(279, 105)
        Me.ucrReceiverPrec.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPrec.Name = "ucrReceiverPrec"
        Me.ucrReceiverPrec.Selector = Nothing
        Me.ucrReceiverPrec.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPrec.strNcFilePath = ""
        Me.ucrReceiverPrec.TabIndex = 3
        Me.ucrReceiverPrec.ucrSelector = Nothing
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Location = New System.Drawing.Point(276, 52)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(56, 13)
        Me.lblDateTime.TabIndex = 4
        Me.lblDateTime.Text = "Date-Time"
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.Location = New System.Drawing.Point(285, 92)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(29, 13)
        Me.lblRain.TabIndex = 5
        Me.lblRain.Text = "Rain"
        '
        'ucrStationName
        '
        Me.ucrStationName.AddQuotesIfUnrecognised = True
        Me.ucrStationName.AutoSize = True
        Me.ucrStationName.IsMultiline = False
        Me.ucrStationName.IsReadOnly = False
        Me.ucrStationName.Location = New System.Drawing.Point(279, 152)
        Me.ucrStationName.Name = "ucrStationName"
        Me.ucrStationName.Size = New System.Drawing.Size(137, 21)
        Me.ucrStationName.TabIndex = 6
        '
        'lblStationName
        '
        Me.lblStationName.AutoSize = True
        Me.lblStationName.Location = New System.Drawing.Point(281, 135)
        Me.lblStationName.Name = "lblStationName"
        Me.lblStationName.Size = New System.Drawing.Size(71, 13)
        Me.lblStationName.TabIndex = 7
        Me.lblStationName.Text = "Station Name"
        '
        'ucrNudMaxPrec
        '
        Me.ucrNudMaxPrec.AutoSize = True
        Me.ucrNudMaxPrec.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxPrec.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxPrec.Location = New System.Drawing.Point(365, 191)
        Me.ucrNudMaxPrec.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxPrec.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxPrec.Name = "ucrNudMaxPrec"
        Me.ucrNudMaxPrec.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxPrec.TabIndex = 8
        Me.ucrNudMaxPrec.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMinimumProp
        '
        Me.lblMinimumProp.AutoSize = True
        Me.lblMinimumProp.Location = New System.Drawing.Point(261, 194)
        Me.lblMinimumProp.Name = "lblMinimumProp"
        Me.lblMinimumProp.Size = New System.Drawing.Size(99, 13)
        Me.lblMinimumProp.TabIndex = 9
        Me.lblMinimumProp.Text = "Minimum Proportion"
        '
        'dlgIDFCurves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 355)
        Me.Controls.Add(Me.lblMinimumProp)
        Me.Controls.Add(Me.ucrNudMaxPrec)
        Me.Controls.Add(Me.lblStationName)
        Me.Controls.Add(Me.ucrStationName)
        Me.Controls.Add(Me.lblRain)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.ucrReceiverPrec)
        Me.Controls.Add(Me.ucrReceiverDateTime)
        Me.Controls.Add(Me.ucrIDFCurvesSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgIDFCurves"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IDF Curves"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrIDFCurvesSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverDateTime As ucrReceiverSingle
    Friend WithEvents lblStationName As Label
    Friend WithEvents ucrStationName As ucrInputTextBox
    Friend WithEvents lblRain As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents ucrReceiverPrec As ucrReceiverSingle
    Friend WithEvents lblMinimumProp As Label
    Friend WithEvents ucrNudMaxPrec As ucrNud
End Class
