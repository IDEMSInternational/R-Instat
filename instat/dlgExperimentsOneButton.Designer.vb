<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgExperimentsOneButton
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
        Me.rdoGeneral = New System.Windows.Forms.RadioButton()
        Me.rdoSpecial = New System.Windows.Forms.RadioButton()
        Me.rdoFactorial = New System.Windows.Forms.RadioButton()
        Me.rdorbd = New System.Windows.Forms.RadioButton()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.lblRep = New System.Windows.Forms.Label()
        Me.lblFactorA = New System.Windows.Forms.Label()
        Me.lblFactorB = New System.Windows.Forms.Label()
        Me.lblDesign = New System.Windows.Forms.Label()
        Me.lblApha = New System.Windows.Forms.Label()
        Me.lblTreat = New System.Windows.Forms.Label()
        Me.UcrBaseExperimentsOneButton = New instat.ucrButtons()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrReceiverResponse = New instat.ucrReceiverSingle()
        Me.ucrRep = New instat.ucrReceiverSingle()
        Me.ucrReceiverFactorA = New instat.ucrReceiverSingle()
        Me.ucrReceiverFactorB = New instat.ucrReceiverSingle()
        Me.ucrChkPlot = New instat.ucrCheck()
        Me.ucrAlpha = New instat.ucrInputComboBox()
        Me.ucrSelectorForRank = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlExperimentsOneButtonOptions = New instat.UcrPanel()
        Me.UcrReceiverTreat = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'rdoGeneral
        '
        Me.rdoGeneral.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGeneral.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGeneral.FlatAppearance.BorderSize = 2
        Me.rdoGeneral.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGeneral.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGeneral.Location = New System.Drawing.Point(56, 12)
        Me.rdoGeneral.Name = "rdoGeneral"
        Me.rdoGeneral.Size = New System.Drawing.Size(129, 27)
        Me.rdoGeneral.TabIndex = 21
        Me.rdoGeneral.TabStop = True
        Me.rdoGeneral.Text = "General"
        Me.rdoGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGeneral.UseVisualStyleBackColor = True
        '
        'rdoSpecial
        '
        Me.rdoSpecial.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSpecial.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSpecial.FlatAppearance.BorderSize = 2
        Me.rdoSpecial.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSpecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSpecial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSpecial.Location = New System.Drawing.Point(183, 12)
        Me.rdoSpecial.Name = "rdoSpecial"
        Me.rdoSpecial.Size = New System.Drawing.Size(129, 27)
        Me.rdoSpecial.TabIndex = 20
        Me.rdoSpecial.TabStop = True
        Me.rdoSpecial.Text = "Special"
        Me.rdoSpecial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSpecial.UseVisualStyleBackColor = True
        '
        'rdoFactorial
        '
        Me.rdoFactorial.AutoSize = True
        Me.rdoFactorial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFactorial.Location = New System.Drawing.Point(115, 54)
        Me.rdoFactorial.Name = "rdoFactorial"
        Me.rdoFactorial.Size = New System.Drawing.Size(65, 17)
        Me.rdoFactorial.TabIndex = 70
        Me.rdoFactorial.TabStop = True
        Me.rdoFactorial.Text = "Factorial"
        Me.rdoFactorial.UseVisualStyleBackColor = True
        '
        'rdorbd
        '
        Me.rdorbd.AutoSize = True
        Me.rdorbd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdorbd.Location = New System.Drawing.Point(67, 54)
        Me.rdorbd.Name = "rdorbd"
        Me.rdorbd.Size = New System.Drawing.Size(40, 17)
        Me.rdorbd.TabIndex = 69
        Me.rdorbd.TabStop = True
        Me.rdorbd.Text = "rbd"
        Me.rdorbd.UseVisualStyleBackColor = True
        '
        'lblResponse
        '
        Me.lblResponse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResponse.Location = New System.Drawing.Point(246, 76)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(60, 18)
        Me.lblResponse.TabIndex = 74
        Me.lblResponse.Text = "Response:"
        '
        'lblRep
        '
        Me.lblRep.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRep.Location = New System.Drawing.Point(246, 197)
        Me.lblRep.Name = "lblRep"
        Me.lblRep.Size = New System.Drawing.Size(124, 13)
        Me.lblRep.TabIndex = 80
        Me.lblRep.Text = "Rep :"
        '
        'lblFactorA
        '
        Me.lblFactorA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorA.Location = New System.Drawing.Point(246, 117)
        Me.lblFactorA.Name = "lblFactorA"
        Me.lblFactorA.Size = New System.Drawing.Size(60, 16)
        Me.lblFactorA.TabIndex = 76
        Me.lblFactorA.Text = "Factor A:"
        '
        'lblFactorB
        '
        Me.lblFactorB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorB.Location = New System.Drawing.Point(246, 155)
        Me.lblFactorB.Name = "lblFactorB"
        Me.lblFactorB.Size = New System.Drawing.Size(60, 17)
        Me.lblFactorB.TabIndex = 78
        Me.lblFactorB.Text = "Factor B:"
        '
        'lblDesign
        '
        Me.lblDesign.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDesign.Location = New System.Drawing.Point(10, 56)
        Me.lblDesign.Name = "lblDesign"
        Me.lblDesign.Size = New System.Drawing.Size(43, 13)
        Me.lblDesign.TabIndex = 84
        Me.lblDesign.Text = "Design:"
        '
        'lblApha
        '
        Me.lblApha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblApha.Location = New System.Drawing.Point(9, 276)
        Me.lblApha.Name = "lblApha"
        Me.lblApha.Size = New System.Drawing.Size(43, 13)
        Me.lblApha.TabIndex = 85
        Me.lblApha.Text = "Alpha:"
        '
        'lblTreat
        '
        Me.lblTreat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTreat.Location = New System.Drawing.Point(246, 119)
        Me.lblTreat.Name = "lblTreat"
        Me.lblTreat.Size = New System.Drawing.Size(60, 16)
        Me.lblTreat.TabIndex = 88
        Me.lblTreat.Text = "Treat :"
        '
        'UcrBaseExperimentsOneButton
        '
        Me.UcrBaseExperimentsOneButton.AutoSize = True
        Me.UcrBaseExperimentsOneButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrBaseExperimentsOneButton.Location = New System.Drawing.Point(9, 336)
        Me.UcrBaseExperimentsOneButton.Margin = New System.Windows.Forms.Padding(4)
        Me.UcrBaseExperimentsOneButton.Name = "UcrBaseExperimentsOneButton"
        Me.UcrBaseExperimentsOneButton.Size = New System.Drawing.Size(408, 52)
        Me.UcrBaseExperimentsOneButton.TabIndex = 83
        '
        'ucrSave
        '
        Me.ucrSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSave.Location = New System.Drawing.Point(9, 308)
        Me.ucrSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSave.Name = "ucrSave"
        Me.ucrSave.Size = New System.Drawing.Size(388, 24)
        Me.ucrSave.TabIndex = 82
        '
        'ucrReceiverResponse
        '
        Me.ucrReceiverResponse.AutoSize = True
        Me.ucrReceiverResponse.frmParent = Me
        Me.ucrReceiverResponse.Location = New System.Drawing.Point(246, 97)
        Me.ucrReceiverResponse.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverResponse.Name = "ucrReceiverResponse"
        Me.ucrReceiverResponse.Selector = Nothing
        Me.ucrReceiverResponse.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverResponse.strNcFilePath = ""
        Me.ucrReceiverResponse.TabIndex = 75
        Me.ucrReceiverResponse.ucrSelector = Nothing
        '
        'ucrRep
        '
        Me.ucrRep.AutoSize = True
        Me.ucrRep.frmParent = Me
        Me.ucrRep.Location = New System.Drawing.Point(246, 213)
        Me.ucrRep.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrRep.Name = "ucrRep"
        Me.ucrRep.Selector = Nothing
        Me.ucrRep.Size = New System.Drawing.Size(123, 20)
        Me.ucrRep.strNcFilePath = ""
        Me.ucrRep.TabIndex = 81
        Me.ucrRep.ucrSelector = Nothing
        '
        'ucrReceiverFactorA
        '
        Me.ucrReceiverFactorA.AutoSize = True
        Me.ucrReceiverFactorA.frmParent = Me
        Me.ucrReceiverFactorA.Location = New System.Drawing.Point(246, 137)
        Me.ucrReceiverFactorA.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactorA.Name = "ucrReceiverFactorA"
        Me.ucrReceiverFactorA.Selector = Nothing
        Me.ucrReceiverFactorA.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverFactorA.strNcFilePath = ""
        Me.ucrReceiverFactorA.TabIndex = 77
        Me.ucrReceiverFactorA.ucrSelector = Nothing
        '
        'ucrReceiverFactorB
        '
        Me.ucrReceiverFactorB.AutoSize = True
        Me.ucrReceiverFactorB.frmParent = Me
        Me.ucrReceiverFactorB.Location = New System.Drawing.Point(246, 174)
        Me.ucrReceiverFactorB.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactorB.Name = "ucrReceiverFactorB"
        Me.ucrReceiverFactorB.Selector = Nothing
        Me.ucrReceiverFactorB.Size = New System.Drawing.Size(123, 20)
        Me.ucrReceiverFactorB.strNcFilePath = ""
        Me.ucrReceiverFactorB.TabIndex = 79
        Me.ucrReceiverFactorB.ucrSelector = Nothing
        '
        'ucrChkPlot
        '
        Me.ucrChkPlot.AutoSize = True
        Me.ucrChkPlot.Checked = False
        Me.ucrChkPlot.Location = New System.Drawing.Point(246, 260)
        Me.ucrChkPlot.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkPlot.Name = "ucrChkPlot"
        Me.ucrChkPlot.Size = New System.Drawing.Size(120, 23)
        Me.ucrChkPlot.TabIndex = 91
        '
        'ucrAlpha
        '
        Me.ucrAlpha.AddQuotesIfUnrecognised = True
        Me.ucrAlpha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrAlpha.GetSetSelectedIndex = -1
        Me.ucrAlpha.IsReadOnly = False
        Me.ucrAlpha.Location = New System.Drawing.Point(60, 271)
        Me.ucrAlpha.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrAlpha.Name = "ucrAlpha"
        Me.ucrAlpha.Size = New System.Drawing.Size(72, 20)
        Me.ucrAlpha.TabIndex = 73
        '
        'ucrSelectorForRank
        '
        Me.ucrSelectorForRank.AutoSize = True
        Me.ucrSelectorForRank.bDropUnusedFilterLevels = False
        Me.ucrSelectorForRank.bShowHiddenColumns = False
        Me.ucrSelectorForRank.bUseCurrentFilter = True
        Me.ucrSelectorForRank.Location = New System.Drawing.Point(9, 75)
        Me.ucrSelectorForRank.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForRank.Name = "ucrSelectorForRank"
        Me.ucrSelectorForRank.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForRank.TabIndex = 71
        '
        'ucrPnlExperimentsOneButtonOptions
        '
        Me.ucrPnlExperimentsOneButtonOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlExperimentsOneButtonOptions.Location = New System.Drawing.Point(12, 4)
        Me.ucrPnlExperimentsOneButtonOptions.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlExperimentsOneButtonOptions.Name = "ucrPnlExperimentsOneButtonOptions"
        Me.ucrPnlExperimentsOneButtonOptions.Size = New System.Drawing.Size(404, 42)
        Me.ucrPnlExperimentsOneButtonOptions.TabIndex = 90
        '
        'UcrReceiverTreat
        '
        Me.UcrReceiverTreat.AutoSize = True
        Me.UcrReceiverTreat.frmParent = Me
        Me.UcrReceiverTreat.Location = New System.Drawing.Point(246, 138)
        Me.UcrReceiverTreat.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverTreat.Name = "UcrReceiverTreat"
        Me.UcrReceiverTreat.Selector = Nothing
        Me.UcrReceiverTreat.Size = New System.Drawing.Size(123, 20)
        Me.UcrReceiverTreat.strNcFilePath = ""
        Me.UcrReceiverTreat.TabIndex = 89
        Me.UcrReceiverTreat.ucrSelector = Nothing
        '
        'dlgExperimentsOneButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(423, 398)
        Me.Controls.Add(Me.lblApha)
        Me.Controls.Add(Me.lblDesign)
        Me.Controls.Add(Me.UcrBaseExperimentsOneButton)
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.ucrReceiverResponse)
        Me.Controls.Add(Me.lblRep)
        Me.Controls.Add(Me.ucrRep)
        Me.Controls.Add(Me.lblFactorA)
        Me.Controls.Add(Me.ucrReceiverFactorA)
        Me.Controls.Add(Me.lblFactorB)
        Me.Controls.Add(Me.ucrReceiverFactorB)
        Me.Controls.Add(Me.ucrChkPlot)
        Me.Controls.Add(Me.ucrAlpha)
        Me.Controls.Add(Me.ucrSelectorForRank)
        Me.Controls.Add(Me.rdoFactorial)
        Me.Controls.Add(Me.rdorbd)
        Me.Controls.Add(Me.rdoGeneral)
        Me.Controls.Add(Me.rdoSpecial)
        Me.Controls.Add(Me.ucrPnlExperimentsOneButtonOptions)
        Me.Controls.Add(Me.lblTreat)
        Me.Controls.Add(Me.UcrReceiverTreat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExperimentsOneButton"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Button"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorExperimentsOneButton As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverFirstVariables As ucrReceiverMultiple
    Friend WithEvents lblFirstVariables As Label
    Friend WithEvents ucrSaveExperimentsOneButton As ucrSave
    Friend WithEvents rdoGeneral As RadioButton
    Friend WithEvents rdoSpecial As RadioButton
    Friend WithEvents rdoFactorial As RadioButton
    Friend WithEvents rdorbd As RadioButton
    Friend WithEvents ucrSelectorForRank As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrAlpha As ucrInputComboBox
    Friend WithEvents lblResponse As Label
    Friend WithEvents ucrReceiverResponse As ucrReceiverSingle
    Friend WithEvents lblRep As Label
    Friend WithEvents ucrRep As ucrReceiverSingle
    Friend WithEvents lblFactorA As Label
    Friend WithEvents ucrReceiverFactorA As ucrReceiverSingle
    Friend WithEvents lblFactorB As Label
    Friend WithEvents ucrReceiverFactorB As ucrReceiverSingle
    Friend WithEvents ucrChkPlot As ucrCheck
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents UcrBaseExperimentsOneButton As ucrButtons
    Friend WithEvents lblDesign As Label
    Friend WithEvents lblApha As Label
    Friend WithEvents lblTreat As Label
    Friend WithEvents UcrReceiverTreat As ucrReceiverSingle
    Friend WithEvents ucrPnlExperimentsOneButtonOptions As UcrPanel
End Class