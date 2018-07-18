<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgClimaticLengthOfSeason
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
        Me.ucrSelectorLengthofSeason = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverStartofRains = New instat.ucrReceiverSingle()
        Me.ucrReceiverEndofRains = New instat.ucrReceiverSingle()
        Me.ucrReceiverEndofRainsLogical = New instat.ucrReceiverSingle()
        Me.ucrReceiverStartofRainsLogical = New instat.ucrReceiverSingle()
        Me.lblStartofRains = New System.Windows.Forms.Label()
        Me.lblStartofRainsLogical = New System.Windows.Forms.Label()
        Me.lblEndofRains = New System.Windows.Forms.Label()
        Me.lblEndofRainsLogical = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 254)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorLengthofSeason
        '
        Me.ucrSelectorLengthofSeason.bDropUnusedFilterLevels = False
        Me.ucrSelectorLengthofSeason.bShowHiddenColumns = False
        Me.ucrSelectorLengthofSeason.bUseCurrentFilter = True
        Me.ucrSelectorLengthofSeason.Location = New System.Drawing.Point(12, 33)
        Me.ucrSelectorLengthofSeason.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorLengthofSeason.Name = "ucrSelectorLengthofSeason"
        Me.ucrSelectorLengthofSeason.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorLengthofSeason.TabIndex = 1
        '
        'ucrReceiverStartofRains
        '
        Me.ucrReceiverStartofRains.frmParent = Me
        Me.ucrReceiverStartofRains.Location = New System.Drawing.Point(302, 47)
        Me.ucrReceiverStartofRains.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStartofRains.Name = "ucrReceiverStartofRains"
        Me.ucrReceiverStartofRains.Selector = Nothing
        Me.ucrReceiverStartofRains.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStartofRains.strNcFilePath = ""
        Me.ucrReceiverStartofRains.TabIndex = 2
        Me.ucrReceiverStartofRains.ucrSelector = Nothing
        '
        'ucrReceiverEndofRains
        '
        Me.ucrReceiverEndofRains.frmParent = Me
        Me.ucrReceiverEndofRains.Location = New System.Drawing.Point(302, 152)
        Me.ucrReceiverEndofRains.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEndofRains.Name = "ucrReceiverEndofRains"
        Me.ucrReceiverEndofRains.Selector = Nothing
        Me.ucrReceiverEndofRains.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverEndofRains.strNcFilePath = ""
        Me.ucrReceiverEndofRains.TabIndex = 3
        Me.ucrReceiverEndofRains.ucrSelector = Nothing
        '
        'ucrReceiverEndofRainsLogical
        '
        Me.ucrReceiverEndofRainsLogical.frmParent = Me
        Me.ucrReceiverEndofRainsLogical.Location = New System.Drawing.Point(302, 198)
        Me.ucrReceiverEndofRainsLogical.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEndofRainsLogical.Name = "ucrReceiverEndofRainsLogical"
        Me.ucrReceiverEndofRainsLogical.Selector = Nothing
        Me.ucrReceiverEndofRainsLogical.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverEndofRainsLogical.strNcFilePath = ""
        Me.ucrReceiverEndofRainsLogical.TabIndex = 4
        Me.ucrReceiverEndofRainsLogical.ucrSelector = Nothing
        '
        'ucrReceiverStartofRainsLogical
        '
        Me.ucrReceiverStartofRainsLogical.frmParent = Me
        Me.ucrReceiverStartofRainsLogical.Location = New System.Drawing.Point(302, 103)
        Me.ucrReceiverStartofRainsLogical.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStartofRainsLogical.Name = "ucrReceiverStartofRainsLogical"
        Me.ucrReceiverStartofRainsLogical.Selector = Nothing
        Me.ucrReceiverStartofRainsLogical.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStartofRainsLogical.strNcFilePath = ""
        Me.ucrReceiverStartofRainsLogical.TabIndex = 5
        Me.ucrReceiverStartofRainsLogical.ucrSelector = Nothing
        '
        'lblStartofRains
        '
        Me.lblStartofRains.AutoSize = True
        Me.lblStartofRains.Location = New System.Drawing.Point(304, 31)
        Me.lblStartofRains.Name = "lblStartofRains"
        Me.lblStartofRains.Size = New System.Drawing.Size(32, 13)
        Me.lblStartofRains.TabIndex = 6
        Me.lblStartofRains.Text = "Start:"
        '
        'lblStartofRainsLogical
        '
        Me.lblStartofRainsLogical.AutoSize = True
        Me.lblStartofRainsLogical.Location = New System.Drawing.Point(303, 86)
        Me.lblStartofRainsLogical.Name = "lblStartofRainsLogical"
        Me.lblStartofRainsLogical.Size = New System.Drawing.Size(44, 13)
        Me.lblStartofRainsLogical.TabIndex = 7
        Me.lblStartofRainsLogical.Text = "Start(L):"
        '
        'lblEndofRains
        '
        Me.lblEndofRains.AutoSize = True
        Me.lblEndofRains.Location = New System.Drawing.Point(304, 136)
        Me.lblEndofRains.Name = "lblEndofRains"
        Me.lblEndofRains.Size = New System.Drawing.Size(29, 13)
        Me.lblEndofRains.TabIndex = 8
        Me.lblEndofRains.Text = "End:"
        '
        'lblEndofRainsLogical
        '
        Me.lblEndofRainsLogical.AutoSize = True
        Me.lblEndofRainsLogical.Location = New System.Drawing.Point(304, 182)
        Me.lblEndofRainsLogical.Name = "lblEndofRainsLogical"
        Me.lblEndofRainsLogical.Size = New System.Drawing.Size(41, 13)
        Me.lblEndofRainsLogical.TabIndex = 9
        Me.lblEndofRainsLogical.Text = "End(L):"
        '
        'dlgClimaticLengthOfSeason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 314)
        Me.Controls.Add(Me.lblEndofRainsLogical)
        Me.Controls.Add(Me.lblEndofRains)
        Me.Controls.Add(Me.lblStartofRainsLogical)
        Me.Controls.Add(Me.lblStartofRains)
        Me.Controls.Add(Me.ucrReceiverStartofRainsLogical)
        Me.Controls.Add(Me.ucrReceiverEndofRainsLogical)
        Me.Controls.Add(Me.ucrReceiverEndofRains)
        Me.Controls.Add(Me.ucrReceiverStartofRains)
        Me.Controls.Add(Me.ucrSelectorLengthofSeason)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgClimaticLengthOfSeason"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Length of Season"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorLengthofSeason As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverStartofRains As ucrReceiverSingle
    Friend WithEvents ucrReceiverStartofRainsLogical As ucrReceiverSingle
    Friend WithEvents ucrReceiverEndofRainsLogical As ucrReceiverSingle
    Friend WithEvents ucrReceiverEndofRains As ucrReceiverSingle
    Friend WithEvents lblEndofRainsLogical As Label
    Friend WithEvents lblEndofRains As Label
    Friend WithEvents lblStartofRainsLogical As Label
    Friend WithEvents lblStartofRains As Label
End Class
