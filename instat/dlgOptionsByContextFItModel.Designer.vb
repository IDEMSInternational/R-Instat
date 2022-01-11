<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgOptionsByContextFitModel
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
        Me.ucrSaveModel = New instat.ucrSave()
        Me.ucrChkConvertToNumeric = New instat.ucrCheck()
        Me.ucrReceiverResponse = New instat.ucrReceiverSingle()
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.ucrModelPreview = New instat.ucrInputTextBox()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.ucrDistributionChoice = New instat.ucrDistributions()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.ucrSelectorFitModel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpContexts = New System.Windows.Forms.GroupBox()
        Me.lblContext1 = New System.Windows.Forms.Label()
        Me.lblContext4 = New System.Windows.Forms.Label()
        Me.lblContextsOther = New System.Windows.Forms.Label()
        Me.ucrReceiverContext4 = New instat.ucrReceiverSingle()
        Me.ucrReceiverContextOther = New instat.ucrReceiverMultiple()
        Me.lblContext3 = New System.Windows.Forms.Label()
        Me.ucrReceiverContext1 = New instat.ucrReceiverSingle()
        Me.ucrReceiverContext3 = New instat.ucrReceiverSingle()
        Me.ucrReceiverContext2 = New instat.ucrReceiverSingle()
        Me.lblContext2 = New System.Windows.Forms.Label()
        Me.ucrReceiverBlocking = New instat.ucrReceiverMultiple()
        Me.lblBlockingVariables = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.ucrReceiverOptions = New instat.ucrReceiverMultiple()
        Me.grpContexts.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveModel.Location = New System.Drawing.Point(10, 403)
        Me.ucrSaveModel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(319, 24)
        Me.ucrSaveModel.TabIndex = 15
        '
        'ucrChkConvertToNumeric
        '
        Me.ucrChkConvertToNumeric.AutoSize = True
        Me.ucrChkConvertToNumeric.Checked = False
        Me.ucrChkConvertToNumeric.Location = New System.Drawing.Point(242, 85)
        Me.ucrChkConvertToNumeric.Name = "ucrChkConvertToNumeric"
        Me.ucrChkConvertToNumeric.Size = New System.Drawing.Size(136, 23)
        Me.ucrChkConvertToNumeric.TabIndex = 3
        '
        'ucrReceiverResponse
        '
        Me.ucrReceiverResponse.AutoSize = True
        Me.ucrReceiverResponse.frmParent = Me
        Me.ucrReceiverResponse.Location = New System.Drawing.Point(242, 60)
        Me.ucrReceiverResponse.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverResponse.Name = "ucrReceiverResponse"
        Me.ucrReceiverResponse.Selector = Nothing
        Me.ucrReceiverResponse.Size = New System.Drawing.Size(121, 20)
        Me.ucrReceiverResponse.strNcFilePath = ""
        Me.ucrReceiverResponse.TabIndex = 2
        Me.ucrReceiverResponse.ucrSelector = Nothing
        '
        'cmdModelOptions
        '
        Me.cmdModelOptions.Location = New System.Drawing.Point(415, 374)
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Size = New System.Drawing.Size(120, 23)
        Me.cmdModelOptions.TabIndex = 13
        Me.cmdModelOptions.Tag = "Model_Options"
        Me.cmdModelOptions.Text = "Model Options..."
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'lblModelPreview
        '
        Me.lblModelPreview.AutoSize = True
        Me.lblModelPreview.Location = New System.Drawing.Point(10, 378)
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Size = New System.Drawing.Size(80, 13)
        Me.lblModelPreview.TabIndex = 11
        Me.lblModelPreview.Tag = "Model_Preview"
        Me.lblModelPreview.Text = "Model Preview:"
        '
        'ucrModelPreview
        '
        Me.ucrModelPreview.AddQuotesIfUnrecognised = True
        Me.ucrModelPreview.AutoSize = True
        Me.ucrModelPreview.IsMultiline = False
        Me.ucrModelPreview.IsReadOnly = False
        Me.ucrModelPreview.Location = New System.Drawing.Point(120, 376)
        Me.ucrModelPreview.Name = "ucrModelPreview"
        Me.ucrModelPreview.Size = New System.Drawing.Size(289, 21)
        Me.ucrModelPreview.TabIndex = 12
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(415, 403)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(120, 23)
        Me.cmdDisplayOptions.TabIndex = 14
        Me.cmdDisplayOptions.Tag = "Display_Options"
        Me.cmdDisplayOptions.Text = "Display Options..."
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'ucrDistributionChoice
        '
        Me.ucrDistributionChoice.AutoSize = True
        Me.ucrDistributionChoice.Location = New System.Drawing.Point(10, 207)
        Me.ucrDistributionChoice.Name = "ucrDistributionChoice"
        Me.ucrDistributionChoice.Size = New System.Drawing.Size(213, 31)
        Me.ucrDistributionChoice.TabIndex = 8
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResponse.Location = New System.Drawing.Point(242, 45)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(99, 13)
        Me.lblResponse.TabIndex = 1
        Me.lblResponse.Tag = "Response_Variable"
        Me.lblResponse.Text = "Response Variable:"
        '
        'ucrSelectorFitModel
        '
        Me.ucrSelectorFitModel.AutoSize = True
        Me.ucrSelectorFitModel.bDropUnusedFilterLevels = False
        Me.ucrSelectorFitModel.bShowHiddenColumns = False
        Me.ucrSelectorFitModel.bUseCurrentFilter = True
        Me.ucrSelectorFitModel.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorFitModel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFitModel.Name = "ucrSelectorFitModel"
        Me.ucrSelectorFitModel.Size = New System.Drawing.Size(214, 185)
        Me.ucrSelectorFitModel.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 429)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'grpContexts
        '
        Me.grpContexts.Controls.Add(Me.lblContext1)
        Me.grpContexts.Controls.Add(Me.lblContext4)
        Me.grpContexts.Controls.Add(Me.lblContextsOther)
        Me.grpContexts.Controls.Add(Me.ucrReceiverContext4)
        Me.grpContexts.Controls.Add(Me.ucrReceiverContextOther)
        Me.grpContexts.Controls.Add(Me.lblContext3)
        Me.grpContexts.Controls.Add(Me.ucrReceiverContext1)
        Me.grpContexts.Controls.Add(Me.ucrReceiverContext3)
        Me.grpContexts.Controls.Add(Me.ucrReceiverContext2)
        Me.grpContexts.Controls.Add(Me.lblContext2)
        Me.grpContexts.Location = New System.Drawing.Point(407, 23)
        Me.grpContexts.Name = "grpContexts"
        Me.grpContexts.Size = New System.Drawing.Size(136, 308)
        Me.grpContexts.TabIndex = 10
        Me.grpContexts.TabStop = False
        Me.grpContexts.Text = "Contexts"
        '
        'lblContext1
        '
        Me.lblContext1.AutoSize = True
        Me.lblContext1.Location = New System.Drawing.Point(8, 22)
        Me.lblContext1.Name = "lblContext1"
        Me.lblContext1.Size = New System.Drawing.Size(72, 13)
        Me.lblContext1.TabIndex = 0
        Me.lblContext1.Text = "Main Context:"
        '
        'lblContext4
        '
        Me.lblContext4.AutoSize = True
        Me.lblContext4.Location = New System.Drawing.Point(8, 144)
        Me.lblContext4.Name = "lblContext4"
        Me.lblContext4.Size = New System.Drawing.Size(79, 13)
        Me.lblContext4.TabIndex = 6
        Me.lblContext4.Text = "Fourth Context:"
        '
        'lblContextsOther
        '
        Me.lblContextsOther.AutoSize = True
        Me.lblContextsOther.Location = New System.Drawing.Point(8, 187)
        Me.lblContextsOther.Name = "lblContextsOther"
        Me.lblContextsOther.Size = New System.Drawing.Size(80, 13)
        Me.lblContextsOther.TabIndex = 8
        Me.lblContextsOther.Text = "Other Contexts:"
        '
        'ucrReceiverContext4
        '
        Me.ucrReceiverContext4.AutoSize = True
        Me.ucrReceiverContext4.frmParent = Me
        Me.ucrReceiverContext4.Location = New System.Drawing.Point(8, 159)
        Me.ucrReceiverContext4.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContext4.Name = "ucrReceiverContext4"
        Me.ucrReceiverContext4.Selector = Nothing
        Me.ucrReceiverContext4.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverContext4.strNcFilePath = ""
        Me.ucrReceiverContext4.TabIndex = 7
        Me.ucrReceiverContext4.ucrSelector = Nothing
        '
        'ucrReceiverContextOther
        '
        Me.ucrReceiverContextOther.AutoSize = True
        Me.ucrReceiverContextOther.frmParent = Me
        Me.ucrReceiverContextOther.Location = New System.Drawing.Point(8, 202)
        Me.ucrReceiverContextOther.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContextOther.Name = "ucrReceiverContextOther"
        Me.ucrReceiverContextOther.Selector = Nothing
        Me.ucrReceiverContextOther.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverContextOther.strNcFilePath = ""
        Me.ucrReceiverContextOther.TabIndex = 9
        Me.ucrReceiverContextOther.ucrSelector = Nothing
        '
        'lblContext3
        '
        Me.lblContext3.AutoSize = True
        Me.lblContext3.Location = New System.Drawing.Point(8, 104)
        Me.lblContext3.Name = "lblContext3"
        Me.lblContext3.Size = New System.Drawing.Size(73, 13)
        Me.lblContext3.TabIndex = 4
        Me.lblContext3.Text = "Third Context:"
        '
        'ucrReceiverContext1
        '
        Me.ucrReceiverContext1.AutoSize = True
        Me.ucrReceiverContext1.frmParent = Me
        Me.ucrReceiverContext1.Location = New System.Drawing.Point(8, 37)
        Me.ucrReceiverContext1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContext1.Name = "ucrReceiverContext1"
        Me.ucrReceiverContext1.Selector = Nothing
        Me.ucrReceiverContext1.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverContext1.strNcFilePath = ""
        Me.ucrReceiverContext1.TabIndex = 1
        Me.ucrReceiverContext1.ucrSelector = Nothing
        '
        'ucrReceiverContext3
        '
        Me.ucrReceiverContext3.AutoSize = True
        Me.ucrReceiverContext3.frmParent = Me
        Me.ucrReceiverContext3.Location = New System.Drawing.Point(8, 119)
        Me.ucrReceiverContext3.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContext3.Name = "ucrReceiverContext3"
        Me.ucrReceiverContext3.Selector = Nothing
        Me.ucrReceiverContext3.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverContext3.strNcFilePath = ""
        Me.ucrReceiverContext3.TabIndex = 5
        Me.ucrReceiverContext3.ucrSelector = Nothing
        '
        'ucrReceiverContext2
        '
        Me.ucrReceiverContext2.AutoSize = True
        Me.ucrReceiverContext2.frmParent = Me
        Me.ucrReceiverContext2.Location = New System.Drawing.Point(8, 79)
        Me.ucrReceiverContext2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContext2.Name = "ucrReceiverContext2"
        Me.ucrReceiverContext2.Selector = Nothing
        Me.ucrReceiverContext2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverContext2.strNcFilePath = ""
        Me.ucrReceiverContext2.TabIndex = 3
        Me.ucrReceiverContext2.ucrSelector = Nothing
        '
        'lblContext2
        '
        Me.lblContext2.AutoSize = True
        Me.lblContext2.Location = New System.Drawing.Point(8, 64)
        Me.lblContext2.Name = "lblContext2"
        Me.lblContext2.Size = New System.Drawing.Size(86, 13)
        Me.lblContext2.TabIndex = 2
        Me.lblContext2.Text = "Second Context:"
        '
        'ucrReceiverBlocking
        '
        Me.ucrReceiverBlocking.AutoSize = True
        Me.ucrReceiverBlocking.frmParent = Me
        Me.ucrReceiverBlocking.Location = New System.Drawing.Point(242, 134)
        Me.ucrReceiverBlocking.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverBlocking.Name = "ucrReceiverBlocking"
        Me.ucrReceiverBlocking.Selector = Nothing
        Me.ucrReceiverBlocking.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverBlocking.strNcFilePath = ""
        Me.ucrReceiverBlocking.TabIndex = 5
        Me.ucrReceiverBlocking.ucrSelector = Nothing
        '
        'lblBlockingVariables
        '
        Me.lblBlockingVariables.AutoSize = True
        Me.lblBlockingVariables.Location = New System.Drawing.Point(242, 119)
        Me.lblBlockingVariables.Name = "lblBlockingVariables"
        Me.lblBlockingVariables.Size = New System.Drawing.Size(97, 13)
        Me.lblBlockingVariables.TabIndex = 4
        Me.lblBlockingVariables.Text = "Blocking Variables:"
        '
        'lblOptions
        '
        Me.lblOptions.AutoSize = True
        Me.lblOptions.Location = New System.Drawing.Point(242, 242)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(46, 13)
        Me.lblOptions.TabIndex = 6
        Me.lblOptions.Text = "Options:"
        '
        'ucrReceiverOptions
        '
        Me.ucrReceiverOptions.AutoSize = True
        Me.ucrReceiverOptions.frmParent = Me
        Me.ucrReceiverOptions.Location = New System.Drawing.Point(242, 257)
        Me.ucrReceiverOptions.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOptions.Name = "ucrReceiverOptions"
        Me.ucrReceiverOptions.Selector = Nothing
        Me.ucrReceiverOptions.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverOptions.strNcFilePath = ""
        Me.ucrReceiverOptions.TabIndex = 7
        Me.ucrReceiverOptions.ucrSelector = Nothing
        '
        'dlgOptionsByContextFitModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(553, 486)
        Me.Controls.Add(Me.lblOptions)
        Me.Controls.Add(Me.ucrReceiverOptions)
        Me.Controls.Add(Me.lblBlockingVariables)
        Me.Controls.Add(Me.ucrReceiverBlocking)
        Me.Controls.Add(Me.grpContexts)
        Me.Controls.Add(Me.ucrSaveModel)
        Me.Controls.Add(Me.ucrChkConvertToNumeric)
        Me.Controls.Add(Me.ucrReceiverResponse)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.ucrModelPreview)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrDistributionChoice)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.ucrSelectorFitModel)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOptionsByContextFitModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FIt Model"
        Me.grpContexts.ResumeLayout(False)
        Me.grpContexts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSaveModel As ucrSave
    Friend WithEvents ucrReceiverSecondExplanatory As ucrReceiverSingle
    Friend WithEvents ucrReceiverFirstExplanatory As ucrReceiverSingle
    Friend WithEvents ucrChkConvertToNumeric As ucrCheck
    Friend WithEvents ucrReceiverResponse As ucrReceiverSingle
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents ucrModelPreview As ucrInputTextBox
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents ucrDistributionChoice As ucrDistributions
    Friend WithEvents lblSecondExplanatoryVariable As Label
    Friend WithEvents lblFirstExplanatoryVariable As Label
    Friend WithEvents lblResponse As Label
    Friend WithEvents ucrSelectorFitModel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpContexts As GroupBox
    Friend WithEvents lblContext1 As Label
    Friend WithEvents lblContext4 As Label
    Friend WithEvents lblContextsOther As Label
    Friend WithEvents ucrReceiverContext4 As ucrReceiverSingle
    Friend WithEvents ucrReceiverContextOther As ucrReceiverMultiple
    Friend WithEvents lblContext3 As Label
    Friend WithEvents ucrReceiverContext1 As ucrReceiverSingle
    Friend WithEvents ucrReceiverContext3 As ucrReceiverSingle
    Friend WithEvents ucrReceiverContext2 As ucrReceiverSingle
    Friend WithEvents lblContext2 As Label
    Friend WithEvents lblBlockingVariables As Label
    Friend WithEvents ucrReceiverBlocking As ucrReceiverMultiple
    Friend WithEvents lblOptions As Label
    Friend WithEvents ucrReceiverOptions As ucrReceiverMultiple
End Class
