<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgClimograph
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ucrReceiverAbsolute = New instat.ucrReceiverSingle()
        Me.lblAbsolute = New System.Windows.Forms.Label()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucr1stFactorReceiver = New instat.ucrReceiverSingle()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.ucrReceiverRain = New instat.ucrReceiverSingle()
        Me.lblRain = New System.Windows.Forms.Label()
        Me.ucrReceiverMaxtem = New instat.ucrReceiverSingle()
        Me.lblMaxtem = New System.Windows.Forms.Label()
        Me.ucrReceiverMintemp = New instat.ucrReceiverSingle()
        Me.lblMintem = New System.Windows.Forms.Label()
        Me.rdoClimograph = New System.Windows.Forms.RadioButton()
        Me.rdoWalterLieth = New System.Windows.Forms.RadioButton()
        Me.ucrPnlClimograph = New instat.UcrPanel()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.ucrSelectorClimograph = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'ucrReceiverAbsolute
        '
        Me.ucrReceiverAbsolute.AutoSize = True
        Me.ucrReceiverAbsolute.frmParent = Me
        Me.ucrReceiverAbsolute.Location = New System.Drawing.Point(267, 280)
        Me.ucrReceiverAbsolute.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAbsolute.Name = "ucrReceiverAbsolute"
        Me.ucrReceiverAbsolute.Selector = Nothing
        Me.ucrReceiverAbsolute.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverAbsolute.strNcFilePath = ""
        Me.ucrReceiverAbsolute.TabIndex = 77
        Me.ucrReceiverAbsolute.ucrSelector = Nothing
        '
        'lblAbsolute
        '
        Me.lblAbsolute.AutoSize = True
        Me.lblAbsolute.Location = New System.Drawing.Point(267, 264)
        Me.lblAbsolute.Name = "lblAbsolute"
        Me.lblAbsolute.Size = New System.Drawing.Size(111, 13)
        Me.lblAbsolute.TabIndex = 76
        Me.lblAbsolute.Text = "Temperature min, min:"
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(379, 68)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(86, 21)
        Me.ucrInputStation.TabIndex = 65
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.AutoSize = True
        Me.ucr1stFactorReceiver.frmParent = Me
        Me.ucr1stFactorReceiver.Location = New System.Drawing.Point(267, 68)
        Me.ucr1stFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.Size = New System.Drawing.Size(109, 26)
        Me.ucr1stFactorReceiver.strNcFilePath = ""
        Me.ucr1stFactorReceiver.TabIndex = 64
        Me.ucr1stFactorReceiver.ucrSelector = Nothing
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(267, 53)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(43, 13)
        Me.lblFacetBy.TabIndex = 63
        Me.lblFacetBy.Tag = ""
        Me.lblFacetBy.Text = "Station:"
        '
        'ucrReceiverRain
        '
        Me.ucrReceiverRain.AutoSize = True
        Me.ucrReceiverRain.frmParent = Me
        Me.ucrReceiverRain.Location = New System.Drawing.Point(267, 150)
        Me.ucrReceiverRain.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRain.Name = "ucrReceiverRain"
        Me.ucrReceiverRain.Selector = Nothing
        Me.ucrReceiverRain.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRain.strNcFilePath = ""
        Me.ucrReceiverRain.TabIndex = 69
        Me.ucrReceiverRain.ucrSelector = Nothing
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.Location = New System.Drawing.Point(267, 134)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(48, 13)
        Me.lblRain.TabIndex = 68
        Me.lblRain.Text = "RainFall:"
        '
        'ucrReceiverMaxtem
        '
        Me.ucrReceiverMaxtem.AutoSize = True
        Me.ucrReceiverMaxtem.frmParent = Me
        Me.ucrReceiverMaxtem.Location = New System.Drawing.Point(267, 193)
        Me.ucrReceiverMaxtem.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMaxtem.Name = "ucrReceiverMaxtem"
        Me.ucrReceiverMaxtem.Selector = Nothing
        Me.ucrReceiverMaxtem.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMaxtem.strNcFilePath = ""
        Me.ucrReceiverMaxtem.TabIndex = 71
        Me.ucrReceiverMaxtem.ucrSelector = Nothing
        '
        'lblMaxtem
        '
        Me.lblMaxtem.AutoSize = True
        Me.lblMaxtem.Location = New System.Drawing.Point(267, 177)
        Me.lblMaxtem.Name = "lblMaxtem"
        Me.lblMaxtem.Size = New System.Drawing.Size(93, 13)
        Me.lblMaxtem.TabIndex = 70
        Me.lblMaxtem.Text = "Temperature Max:"
        '
        'ucrReceiverMintemp
        '
        Me.ucrReceiverMintemp.AutoSize = True
        Me.ucrReceiverMintemp.frmParent = Me
        Me.ucrReceiverMintemp.Location = New System.Drawing.Point(267, 234)
        Me.ucrReceiverMintemp.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMintemp.Name = "ucrReceiverMintemp"
        Me.ucrReceiverMintemp.Selector = Nothing
        Me.ucrReceiverMintemp.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMintemp.strNcFilePath = ""
        Me.ucrReceiverMintemp.TabIndex = 73
        Me.ucrReceiverMintemp.ucrSelector = Nothing
        '
        'lblMintem
        '
        Me.lblMintem.AutoSize = True
        Me.lblMintem.Location = New System.Drawing.Point(267, 218)
        Me.lblMintem.Name = "lblMintem"
        Me.lblMintem.Size = New System.Drawing.Size(90, 13)
        Me.lblMintem.TabIndex = 72
        Me.lblMintem.Text = "Temperature Min:"
        '
        'rdoClimograph
        '
        Me.rdoClimograph.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoClimograph.BackColor = System.Drawing.SystemColors.Control
        Me.rdoClimograph.Enabled = False
        Me.rdoClimograph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoClimograph.FlatAppearance.BorderSize = 2
        Me.rdoClimograph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoClimograph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoClimograph.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoClimograph.Location = New System.Drawing.Point(195, 13)
        Me.rdoClimograph.Name = "rdoClimograph"
        Me.rdoClimograph.Size = New System.Drawing.Size(119, 28)
        Me.rdoClimograph.TabIndex = 62
        Me.rdoClimograph.TabStop = True
        Me.rdoClimograph.Tag = ""
        Me.rdoClimograph.Text = "Ordinary Climograph"
        Me.rdoClimograph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoClimograph.UseVisualStyleBackColor = False
        '
        'rdoWalterLieth
        '
        Me.rdoWalterLieth.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoWalterLieth.BackColor = System.Drawing.SystemColors.Control
        Me.rdoWalterLieth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWalterLieth.FlatAppearance.BorderSize = 2
        Me.rdoWalterLieth.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWalterLieth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoWalterLieth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoWalterLieth.Location = New System.Drawing.Point(117, 13)
        Me.rdoWalterLieth.Name = "rdoWalterLieth"
        Me.rdoWalterLieth.Size = New System.Drawing.Size(80, 28)
        Me.rdoWalterLieth.TabIndex = 61
        Me.rdoWalterLieth.TabStop = True
        Me.rdoWalterLieth.Tag = ""
        Me.rdoWalterLieth.Text = "Walter Lieth"
        Me.rdoWalterLieth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoWalterLieth.UseVisualStyleBackColor = False
        '
        'ucrPnlClimograph
        '
        Me.ucrPnlClimograph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlClimograph.Location = New System.Drawing.Point(107, 5)
        Me.ucrPnlClimograph.Name = "ucrPnlClimograph"
        Me.ucrPnlClimograph.Size = New System.Drawing.Size(236, 41)
        Me.ucrPnlClimograph.TabIndex = 60
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 332)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 75
        '
        'ucrSave
        '
        Me.ucrSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSave.Location = New System.Drawing.Point(12, 305)
        Me.ucrSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSave.Name = "ucrSave"
        Me.ucrSave.Size = New System.Drawing.Size(282, 24)
        Me.ucrSave.TabIndex = 74
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.AutoSize = True
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(267, 109)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 67
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(267, 93)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 66
        Me.lblMonth.Text = "Month:"
        '
        'ucrSelectorClimograph
        '
        Me.ucrSelectorClimograph.AutoSize = True
        Me.ucrSelectorClimograph.bDropUnusedFilterLevels = False
        Me.ucrSelectorClimograph.bShowHiddenColumns = False
        Me.ucrSelectorClimograph.bUseCurrentFilter = True
        Me.ucrSelectorClimograph.Location = New System.Drawing.Point(11, 48)
        Me.ucrSelectorClimograph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClimograph.Name = "ucrSelectorClimograph"
        Me.ucrSelectorClimograph.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorClimograph.TabIndex = 59
        '
        'dlgClimograph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 388)
        Me.Controls.Add(Me.ucrReceiverAbsolute)
        Me.Controls.Add(Me.lblAbsolute)
        Me.Controls.Add(Me.ucrInputStation)
        Me.Controls.Add(Me.ucr1stFactorReceiver)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.ucrReceiverRain)
        Me.Controls.Add(Me.lblRain)
        Me.Controls.Add(Me.ucrReceiverMaxtem)
        Me.Controls.Add(Me.lblMaxtem)
        Me.Controls.Add(Me.ucrReceiverMintemp)
        Me.Controls.Add(Me.lblMintem)
        Me.Controls.Add(Me.rdoClimograph)
        Me.Controls.Add(Me.rdoWalterLieth)
        Me.Controls.Add(Me.ucrPnlClimograph)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.ucrSelectorClimograph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimograph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Climograph"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrReceiverAbsolute As ucrReceiverSingle
    Friend WithEvents lblAbsolute As Label
    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents ucr1stFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFacetBy As Label
    Friend WithEvents ucrReceiverRain As ucrReceiverSingle
    Friend WithEvents lblRain As Label
    Friend WithEvents ucrReceiverMaxtem As ucrReceiverSingle
    Friend WithEvents lblMaxtem As Label
    Friend WithEvents ucrReceiverMintemp As ucrReceiverSingle
    Friend WithEvents lblMintem As Label
    Friend WithEvents rdoClimograph As RadioButton
    Friend WithEvents rdoWalterLieth As RadioButton
    Friend WithEvents ucrPnlClimograph As UcrPanel
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents lblMonth As Label
    Friend WithEvents ucrSelectorClimograph As ucrSelectorByDataFrameAddRemove
End Class
