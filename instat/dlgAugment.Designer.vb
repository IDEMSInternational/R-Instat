<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgAugment
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
        Me.lblModels = New System.Windows.Forms.Label()
        Me.rdoAddToDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoDisplayInOutput = New System.Windows.Forms.RadioButton()
        Me.rdoNewDataFrame = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrSaveNewDataFrame = New instat.ucrSave()
        Me.ucrModelReceiver = New instat.ucrReceiverSingle()
        Me.ucrModelSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblModels
        '
        Me.lblModels.AutoSize = True
        Me.lblModels.Location = New System.Drawing.Point(259, 37)
        Me.lblModels.Name = "lblModels"
        Me.lblModels.Size = New System.Drawing.Size(39, 13)
        Me.lblModels.TabIndex = 2
        Me.lblModels.Text = "Model:"
        '
        'rdoAddToDataFrame
        '
        Me.rdoAddToDataFrame.AutoSize = True
        Me.rdoAddToDataFrame.Location = New System.Drawing.Point(13, 200)
        Me.rdoAddToDataFrame.Name = "rdoAddToDataFrame"
        Me.rdoAddToDataFrame.Size = New System.Drawing.Size(117, 17)
        Me.rdoAddToDataFrame.TabIndex = 9
        Me.rdoAddToDataFrame.TabStop = True
        Me.rdoAddToDataFrame.Text = "Add to Data Frame:"
        Me.rdoAddToDataFrame.UseVisualStyleBackColor = True
        '
        'rdoDisplayInOutput
        '
        Me.rdoDisplayInOutput.AutoSize = True
        Me.rdoDisplayInOutput.Location = New System.Drawing.Point(13, 237)
        Me.rdoDisplayInOutput.Name = "rdoDisplayInOutput"
        Me.rdoDisplayInOutput.Size = New System.Drawing.Size(106, 17)
        Me.rdoDisplayInOutput.TabIndex = 10
        Me.rdoDisplayInOutput.TabStop = True
        Me.rdoDisplayInOutput.Text = "Display In Output"
        Me.rdoDisplayInOutput.UseVisualStyleBackColor = True
        '
        'rdoNewDataFrame
        '
        Me.rdoNewDataFrame.AutoSize = True
        Me.rdoNewDataFrame.Location = New System.Drawing.Point(13, 278)
        Me.rdoNewDataFrame.Name = "rdoNewDataFrame"
        Me.rdoNewDataFrame.Size = New System.Drawing.Size(139, 17)
        Me.rdoNewDataFrame.TabIndex = 11
        Me.rdoNewDataFrame.TabStop = True
        Me.rdoNewDataFrame.Text = "New Data Frame Name:"
        Me.rdoNewDataFrame.UseVisualStyleBackColor = True
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(10, 198)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(209, 106)
        Me.ucrPnlOptions.TabIndex = 8
        '
        'ucrSaveNewDataFrame
        '
        Me.ucrSaveNewDataFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewDataFrame.Location = New System.Drawing.Point(235, 278)
        Me.ucrSaveNewDataFrame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveNewDataFrame.Name = "ucrSaveNewDataFrame"
        Me.ucrSaveNewDataFrame.Size = New System.Drawing.Size(158, 26)
        Me.ucrSaveNewDataFrame.TabIndex = 7
        '
        'ucrModelReceiver
        '
        Me.ucrModelReceiver.AutoSize = True
        Me.ucrModelReceiver.frmParent = Me
        Me.ucrModelReceiver.Location = New System.Drawing.Point(259, 53)
        Me.ucrModelReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrModelReceiver.Name = "ucrModelReceiver"
        Me.ucrModelReceiver.Selector = Nothing
        Me.ucrModelReceiver.Size = New System.Drawing.Size(134, 20)
        Me.ucrModelReceiver.strNcFilePath = ""
        Me.ucrModelReceiver.TabIndex = 6
        Me.ucrModelReceiver.ucrSelector = Nothing
        '
        'ucrModelSelector
        '
        Me.ucrModelSelector.AutoSize = True
        Me.ucrModelSelector.bDropUnusedFilterLevels = False
        Me.ucrModelSelector.bShowHiddenColumns = False
        Me.ucrModelSelector.bUseCurrentFilter = True
        Me.ucrModelSelector.Location = New System.Drawing.Point(9, 9)
        Me.ucrModelSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrModelSelector.Name = "ucrModelSelector"
        Me.ucrModelSelector.Size = New System.Drawing.Size(213, 183)
        Me.ucrModelSelector.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 331)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgAugment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(421, 394)
        Me.Controls.Add(Me.rdoNewDataFrame)
        Me.Controls.Add(Me.rdoDisplayInOutput)
        Me.Controls.Add(Me.rdoAddToDataFrame)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrSaveNewDataFrame)
        Me.Controls.Add(Me.ucrModelReceiver)
        Me.Controls.Add(Me.lblModels)
        Me.Controls.Add(Me.ucrModelSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAugment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Augment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrModelSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblModels As Label
    Friend WithEvents ucrModelReceiver As ucrReceiverSingle
    Friend WithEvents ucrSaveNewDataFrame As ucrSave
    Friend WithEvents rdoNewDataFrame As RadioButton
    Friend WithEvents rdoDisplayInOutput As RadioButton
    Friend WithEvents rdoAddToDataFrame As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
End Class
