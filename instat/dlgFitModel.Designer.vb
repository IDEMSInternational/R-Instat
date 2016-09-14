<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFitModel
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
        Me.ucrSelectorByDataFrameAddRemoveForFitModel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblResponseVariable = New System.Windows.Forms.Label()
        Me.ucrReceiverResponseVar = New instat.ucrReceiverSingle()
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.ucrDistributionForFitModel = New instat.ucrDistributions()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.ucrInputModelPreview = New instat.ucrInputTextBox()
        Me.ucrSaveModel = New instat.ucrSaveModel()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 300)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorByDataFrameAddRemoveForFitModel
        '
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.bShowHiddenColumns = False
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.bUseCurrentFilter = False
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.Name = "ucrSelectorByDataFrameAddRemoveForFitModel"
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorByDataFrameAddRemoveForFitModel.TabIndex = 1
        '
        'lblResponseVariable
        '
        Me.lblResponseVariable.AutoSize = True
        Me.lblResponseVariable.Location = New System.Drawing.Point(240, 26)
        Me.lblResponseVariable.Name = "lblResponseVariable"
        Me.lblResponseVariable.Size = New System.Drawing.Size(96, 13)
        Me.lblResponseVariable.TabIndex = 2
        Me.lblResponseVariable.Text = "Response Variable"
        '
        'ucrReceiverResponseVar
        '
        Me.ucrReceiverResponseVar.Location = New System.Drawing.Point(243, 43)
        Me.ucrReceiverResponseVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverResponseVar.Name = "ucrReceiverResponseVar"
        Me.ucrReceiverResponseVar.Selector = Nothing
        Me.ucrReceiverResponseVar.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverResponseVar.TabIndex = 3
        '
        'cmdModelOptions
        '
        Me.cmdModelOptions.Location = New System.Drawing.Point(284, 203)
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Size = New System.Drawing.Size(105, 23)
        Me.cmdModelOptions.TabIndex = 4
        Me.cmdModelOptions.Text = "Model options"
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'ucrDistributionForFitModel
        '
        Me.ucrDistributionForFitModel.Location = New System.Drawing.Point(12, 192)
        Me.ucrDistributionForFitModel.Name = "ucrDistributionForFitModel"
        Me.ucrDistributionForFitModel.Size = New System.Drawing.Size(207, 43)
        Me.ucrDistributionForFitModel.TabIndex = 5
        '
        'lblModelPreview
        '
        Me.lblModelPreview.AutoSize = True
        Me.lblModelPreview.Location = New System.Drawing.Point(9, 242)
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Size = New System.Drawing.Size(79, 13)
        Me.lblModelPreview.TabIndex = 6
        Me.lblModelPreview.Text = "Model preview:"
        '
        'ucrInputModelPreview
        '
        Me.ucrInputModelPreview.IsReadOnly = False
        Me.ucrInputModelPreview.Location = New System.Drawing.Point(94, 236)
        Me.ucrInputModelPreview.Name = "ucrInputModelPreview"
        Me.ucrInputModelPreview.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputModelPreview.TabIndex = 7
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.Location = New System.Drawing.Point(9, 268)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(265, 20)
        Me.ucrSaveModel.TabIndex = 8
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(284, 265)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(105, 23)
        Me.cmdDisplayOptions.TabIndex = 9
        Me.cmdDisplayOptions.Text = "Display options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'dlgFitModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 368)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrSaveModel)
        Me.Controls.Add(Me.ucrInputModelPreview)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.ucrDistributionForFitModel)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.ucrReceiverResponseVar)
        Me.Controls.Add(Me.lblResponseVariable)
        Me.Controls.Add(Me.ucrSelectorByDataFrameAddRemoveForFitModel)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFitModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Fit_Model"
        Me.Text = "Fit Model"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorByDataFrameAddRemoveForFitModel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblResponseVariable As Label
    Friend WithEvents ucrReceiverResponseVar As ucrReceiverSingle
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents ucrDistributionForFitModel As ucrDistributions
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents ucrInputModelPreview As ucrInputTextBox
    Friend WithEvents ucrSaveModel As ucrSaveModel
    Friend WithEvents cmdDisplayOptions As Button
End Class
