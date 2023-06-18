<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgGlance
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
        Me.lblModels = New System.Windows.Forms.Label()
        Me.ucrModelSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrModelReceiver = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.rdoDisplayInOutput = New System.Windows.Forms.RadioButton()
        Me.rdoNewDataFrameName = New System.Windows.Forms.RadioButton()
        Me.ucrSaveNewDataFrame = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'lblModels
        '
        Me.lblModels.AutoSize = True
        Me.lblModels.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblModels.Location = New System.Drawing.Point(260, 26)
        Me.lblModels.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblModels.Name = "lblModels"
        Me.lblModels.Size = New System.Drawing.Size(44, 13)
        Me.lblModels.TabIndex = 3
        Me.lblModels.Text = "Models:"
        '
        'ucrModelSelector
        '
        Me.ucrModelSelector.AutoSize = True
        Me.ucrModelSelector.bDropUnusedFilterLevels = False
        Me.ucrModelSelector.bShowHiddenColumns = False
        Me.ucrModelSelector.bUseCurrentFilter = True
        Me.ucrModelSelector.Location = New System.Drawing.Point(4, 9)
        Me.ucrModelSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrModelSelector.Name = "ucrModelSelector"
        Me.ucrModelSelector.Size = New System.Drawing.Size(221, 192)
        Me.ucrModelSelector.TabIndex = 6
        '
        'ucrModelReceiver
        '
        Me.ucrModelReceiver.AutoSize = True
        Me.ucrModelReceiver.frmParent = Me
        Me.ucrModelReceiver.Location = New System.Drawing.Point(259, 43)
        Me.ucrModelReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrModelReceiver.Name = "ucrModelReceiver"
        Me.ucrModelReceiver.Selector = Nothing
        Me.ucrModelReceiver.Size = New System.Drawing.Size(130, 105)
        Me.ucrModelReceiver.strNcFilePath = ""
        Me.ucrModelReceiver.TabIndex = 2
        Me.ucrModelReceiver.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(7, 292)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(4, 211)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(221, 68)
        Me.ucrPnlOptions.TabIndex = 7
        '
        'rdoDisplayInOutput
        '
        Me.rdoDisplayInOutput.AutoSize = True
        Me.rdoDisplayInOutput.Location = New System.Drawing.Point(11, 219)
        Me.rdoDisplayInOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.rdoDisplayInOutput.Name = "rdoDisplayInOutput"
        Me.rdoDisplayInOutput.Size = New System.Drawing.Size(106, 17)
        Me.rdoDisplayInOutput.TabIndex = 8
        Me.rdoDisplayInOutput.TabStop = True
        Me.rdoDisplayInOutput.Text = "Display In Output"
        Me.rdoDisplayInOutput.UseVisualStyleBackColor = True
        '
        'rdoNewDataFrameName
        '
        Me.rdoNewDataFrameName.AutoSize = True
        Me.rdoNewDataFrameName.Location = New System.Drawing.Point(11, 249)
        Me.rdoNewDataFrameName.Margin = New System.Windows.Forms.Padding(2)
        Me.rdoNewDataFrameName.Name = "rdoNewDataFrameName"
        Me.rdoNewDataFrameName.Size = New System.Drawing.Size(139, 17)
        Me.rdoNewDataFrameName.TabIndex = 9
        Me.rdoNewDataFrameName.TabStop = True
        Me.rdoNewDataFrameName.Text = "New Data Frame Name:"
        Me.rdoNewDataFrameName.UseVisualStyleBackColor = True
        '
        'ucrSaveNewDataFrame
        '
        Me.ucrSaveNewDataFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewDataFrame.Location = New System.Drawing.Point(228, 245)
        Me.ucrSaveNewDataFrame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveNewDataFrame.Name = "ucrSaveNewDataFrame"
        Me.ucrSaveNewDataFrame.Size = New System.Drawing.Size(161, 34)
        Me.ucrSaveNewDataFrame.TabIndex = 10
        '
        'dlgGlance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(414, 348)
        Me.Controls.Add(Me.ucrSaveNewDataFrame)
        Me.Controls.Add(Me.rdoNewDataFrameName)
        Me.Controls.Add(Me.rdoDisplayInOutput)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrModelSelector)
        Me.Controls.Add(Me.lblModels)
        Me.Controls.Add(Me.ucrModelReceiver)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgGlance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Glance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrModelReceiver As ucrReceiverMultiple
    Friend WithEvents lblModels As Label
    Friend WithEvents ucrModelSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents rdoDisplayInOutput As RadioButton
    Friend WithEvents rdoNewDataFrameName As RadioButton
    Friend WithEvents ucrSaveNewDataFrame As ucrSave
End Class
