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
        Me.lblStartofRains = New System.Windows.Forms.Label()
        Me.lblStartofRainsLogical = New System.Windows.Forms.Label()
        Me.lblEndofRains = New System.Windows.Forms.Label()
        Me.lblEndofRainsLogical = New System.Windows.Forms.Label()
        Me.ucrChkType = New instat.ucrCheck()
        Me.ucrChkLengthofSeason = New instat.ucrCheck()
        Me.ucrInputTextType = New instat.ucrInputTextBox()
        Me.ucrInputLengthofSeason = New instat.ucrInputTextBox()
        Me.ucrReceiverStartofRainsLogical = New instat.ucrReceiverSingle()
        Me.ucrReceiverEndofRainsLogical = New instat.ucrReceiverSingle()
        Me.ucrReceiverEndofRains = New instat.ucrReceiverSingle()
        Me.ucrReceiverStartofRains = New instat.ucrReceiverSingle()
        Me.ucrSelectorLengthofSeason = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkLengthmore = New instat.ucrCheck()
        Me.lblEndFilled = New System.Windows.Forms.Label()
        Me.ucrReceiverEndFilled = New instat.ucrReceiverSingle()
        Me.ucrInputTextLengthmore = New instat.ucrInputTextBox()
        Me.ucrSaveDefinition = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'lblStartofRains
        '
        Me.lblStartofRains.AutoSize = True
        Me.lblStartofRains.Location = New System.Drawing.Point(422, 40)
        Me.lblStartofRains.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartofRains.Name = "lblStartofRains"
        Me.lblStartofRains.Size = New System.Drawing.Size(48, 20)
        Me.lblStartofRains.TabIndex = 1
        Me.lblStartofRains.Text = "Start:"
        '
        'lblStartofRainsLogical
        '
        Me.lblStartofRainsLogical.AutoSize = True
        Me.lblStartofRainsLogical.Location = New System.Drawing.Point(422, 102)
        Me.lblStartofRainsLogical.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartofRainsLogical.Name = "lblStartofRainsLogical"
        Me.lblStartofRainsLogical.Size = New System.Drawing.Size(122, 20)
        Me.lblStartofRainsLogical.TabIndex = 3
        Me.lblStartofRainsLogical.Text = "Start Status (L):"
        '
        'lblEndofRains
        '
        Me.lblEndofRains.AutoSize = True
        Me.lblEndofRains.Location = New System.Drawing.Point(420, 168)
        Me.lblEndofRains.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndofRains.Name = "lblEndofRains"
        Me.lblEndofRains.Size = New System.Drawing.Size(42, 20)
        Me.lblEndofRains.TabIndex = 5
        Me.lblEndofRains.Text = "End:"
        '
        'lblEndofRainsLogical
        '
        Me.lblEndofRainsLogical.AutoSize = True
        Me.lblEndofRainsLogical.Location = New System.Drawing.Point(420, 234)
        Me.lblEndofRainsLogical.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndofRainsLogical.Name = "lblEndofRainsLogical"
        Me.lblEndofRainsLogical.Size = New System.Drawing.Size(116, 20)
        Me.lblEndofRainsLogical.TabIndex = 7
        Me.lblEndofRainsLogical.Text = "End Status (L):"
        '
        'ucrChkType
        '
        Me.ucrChkType.AutoSize = True
        Me.ucrChkType.Checked = False
        Me.ucrChkType.Location = New System.Drawing.Point(8, 399)
        Me.ucrChkType.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkType.Name = "ucrChkType"
        Me.ucrChkType.Size = New System.Drawing.Size(130, 34)
        Me.ucrChkType.TabIndex = 11
        '
        'ucrChkLengthofSeason
        '
        Me.ucrChkLengthofSeason.AutoSize = True
        Me.ucrChkLengthofSeason.Checked = False
        Me.ucrChkLengthofSeason.Location = New System.Drawing.Point(8, 351)
        Me.ucrChkLengthofSeason.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkLengthofSeason.Name = "ucrChkLengthofSeason"
        Me.ucrChkLengthofSeason.Size = New System.Drawing.Size(214, 34)
        Me.ucrChkLengthofSeason.TabIndex = 9
        '
        'ucrInputTextType
        '
        Me.ucrInputTextType.AddQuotesIfUnrecognised = True
        Me.ucrInputTextType.AutoSize = True
        Me.ucrInputTextType.IsMultiline = False
        Me.ucrInputTextType.IsReadOnly = False
        Me.ucrInputTextType.Location = New System.Drawing.Point(224, 398)
        Me.ucrInputTextType.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputTextType.Name = "ucrInputTextType"
        Me.ucrInputTextType.Size = New System.Drawing.Size(192, 32)
        Me.ucrInputTextType.TabIndex = 12
        '
        'ucrInputLengthofSeason
        '
        Me.ucrInputLengthofSeason.AddQuotesIfUnrecognised = True
        Me.ucrInputLengthofSeason.AutoSize = True
        Me.ucrInputLengthofSeason.IsMultiline = False
        Me.ucrInputLengthofSeason.IsReadOnly = False
        Me.ucrInputLengthofSeason.Location = New System.Drawing.Point(224, 350)
        Me.ucrInputLengthofSeason.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputLengthofSeason.Name = "ucrInputLengthofSeason"
        Me.ucrInputLengthofSeason.Size = New System.Drawing.Size(192, 32)
        Me.ucrInputLengthofSeason.TabIndex = 10
        '
        'ucrReceiverStartofRainsLogical
        '
        Me.ucrReceiverStartofRainsLogical.AutoSize = True
        Me.ucrReceiverStartofRainsLogical.frmParent = Me
        Me.ucrReceiverStartofRainsLogical.Location = New System.Drawing.Point(424, 128)
        Me.ucrReceiverStartofRainsLogical.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStartofRainsLogical.Name = "ucrReceiverStartofRainsLogical"
        Me.ucrReceiverStartofRainsLogical.Selector = Nothing
        Me.ucrReceiverStartofRainsLogical.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverStartofRainsLogical.strNcFilePath = ""
        Me.ucrReceiverStartofRainsLogical.TabIndex = 4
        Me.ucrReceiverStartofRainsLogical.ucrSelector = Nothing
        '
        'ucrReceiverEndofRainsLogical
        '
        Me.ucrReceiverEndofRainsLogical.AutoSize = True
        Me.ucrReceiverEndofRainsLogical.frmParent = Me
        Me.ucrReceiverEndofRainsLogical.Location = New System.Drawing.Point(424, 258)
        Me.ucrReceiverEndofRainsLogical.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEndofRainsLogical.Name = "ucrReceiverEndofRainsLogical"
        Me.ucrReceiverEndofRainsLogical.Selector = Nothing
        Me.ucrReceiverEndofRainsLogical.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverEndofRainsLogical.strNcFilePath = ""
        Me.ucrReceiverEndofRainsLogical.TabIndex = 8
        Me.ucrReceiverEndofRainsLogical.ucrSelector = Nothing
        '
        'ucrReceiverEndofRains
        '
        Me.ucrReceiverEndofRains.AutoSize = True
        Me.ucrReceiverEndofRains.frmParent = Me
        Me.ucrReceiverEndofRains.Location = New System.Drawing.Point(424, 192)
        Me.ucrReceiverEndofRains.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEndofRains.Name = "ucrReceiverEndofRains"
        Me.ucrReceiverEndofRains.Selector = Nothing
        Me.ucrReceiverEndofRains.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverEndofRains.strNcFilePath = ""
        Me.ucrReceiverEndofRains.TabIndex = 6
        Me.ucrReceiverEndofRains.ucrSelector = Nothing
        '
        'ucrReceiverStartofRains
        '
        Me.ucrReceiverStartofRains.AutoSize = True
        Me.ucrReceiverStartofRains.frmParent = Me
        Me.ucrReceiverStartofRains.Location = New System.Drawing.Point(424, 64)
        Me.ucrReceiverStartofRains.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStartofRains.Name = "ucrReceiverStartofRains"
        Me.ucrReceiverStartofRains.Selector = Nothing
        Me.ucrReceiverStartofRains.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverStartofRains.strNcFilePath = ""
        Me.ucrReceiverStartofRains.TabIndex = 2
        Me.ucrReceiverStartofRains.ucrSelector = Nothing
        '
        'ucrSelectorLengthofSeason
        '
        Me.ucrSelectorLengthofSeason.AutoSize = True
        Me.ucrSelectorLengthofSeason.bDropUnusedFilterLevels = False
        Me.ucrSelectorLengthofSeason.bShowHiddenColumns = False
        Me.ucrSelectorLengthofSeason.bUseCurrentFilter = True
        Me.ucrSelectorLengthofSeason.Location = New System.Drawing.Point(8, 50)
        Me.ucrSelectorLengthofSeason.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorLengthofSeason.Name = "ucrSelectorLengthofSeason"
        Me.ucrSelectorLengthofSeason.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorLengthofSeason.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(8, 539)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 13
        '
        'ucrChkLengthmore
        '
        Me.ucrChkLengthmore.AutoSize = True
        Me.ucrChkLengthmore.Checked = False
        Me.ucrChkLengthmore.Location = New System.Drawing.Point(8, 448)
        Me.ucrChkLengthmore.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkLengthmore.Name = "ucrChkLengthmore"
        Me.ucrChkLengthmore.Size = New System.Drawing.Size(214, 34)
        Me.ucrChkLengthmore.TabIndex = 14
        '
        'lblEndFilled
        '
        Me.lblEndFilled.AutoSize = True
        Me.lblEndFilled.Location = New System.Drawing.Point(422, 298)
        Me.lblEndFilled.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndFilled.Name = "lblEndFilled"
        Me.lblEndFilled.Size = New System.Drawing.Size(83, 20)
        Me.lblEndFilled.TabIndex = 16
        Me.lblEndFilled.Text = "End Filled:"
        '
        'ucrReceiverEndFilled
        '
        Me.ucrReceiverEndFilled.AutoSize = True
        Me.ucrReceiverEndFilled.frmParent = Me
        Me.ucrReceiverEndFilled.Location = New System.Drawing.Point(426, 322)
        Me.ucrReceiverEndFilled.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverEndFilled.Name = "ucrReceiverEndFilled"
        Me.ucrReceiverEndFilled.Selector = Nothing
        Me.ucrReceiverEndFilled.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverEndFilled.strNcFilePath = ""
        Me.ucrReceiverEndFilled.TabIndex = 17
        Me.ucrReceiverEndFilled.ucrSelector = Nothing
        '
        'ucrInputTextLengthmore
        '
        Me.ucrInputTextLengthmore.AddQuotesIfUnrecognised = True
        Me.ucrInputTextLengthmore.AutoSize = True
        Me.ucrInputTextLengthmore.IsMultiline = False
        Me.ucrInputTextLengthmore.IsReadOnly = False
        Me.ucrInputTextLengthmore.Location = New System.Drawing.Point(224, 444)
        Me.ucrInputTextLengthmore.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputTextLengthmore.Name = "ucrInputTextLengthmore"
        Me.ucrInputTextLengthmore.Size = New System.Drawing.Size(192, 32)
        Me.ucrInputTextLengthmore.TabIndex = 18
        '
        'ucrSaveDefinition
        '
        Me.ucrSaveDefinition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDefinition.Location = New System.Drawing.Point(8, 493)
        Me.ucrSaveDefinition.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveDefinition.Name = "ucrSaveDefinition"
        Me.ucrSaveDefinition.Size = New System.Drawing.Size(480, 36)
        Me.ucrSaveDefinition.TabIndex = 52
        '
        'dlgClimaticLengthOfSeason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(624, 620)
        Me.Controls.Add(Me.ucrSaveDefinition)
        Me.Controls.Add(Me.ucrInputTextLengthmore)
        Me.Controls.Add(Me.lblEndFilled)
        Me.Controls.Add(Me.ucrReceiverEndFilled)
        Me.Controls.Add(Me.ucrChkLengthmore)
        Me.Controls.Add(Me.ucrChkType)
        Me.Controls.Add(Me.ucrChkLengthofSeason)
        Me.Controls.Add(Me.ucrInputTextType)
        Me.Controls.Add(Me.ucrInputLengthofSeason)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents ucrChkType As ucrCheck
    Friend WithEvents ucrChkLengthofSeason As ucrCheck
    Friend WithEvents ucrInputTextType As ucrInputTextBox
    Friend WithEvents ucrInputLengthofSeason As ucrInputTextBox
    Friend WithEvents ucrChkLengthmore As ucrCheck
    Friend WithEvents ucrInputTextLengthmore As ucrInputTextBox
    Friend WithEvents lblEndFilled As Label
    Friend WithEvents ucrReceiverEndFilled As ucrReceiverSingle
    Friend WithEvents ucrSaveDefinition As ucrSave
End Class
