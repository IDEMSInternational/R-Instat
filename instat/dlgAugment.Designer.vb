<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAugment
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
        Me.ucrModelSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblModels = New System.Windows.Forms.Label()
        Me.ucrModelReceiver = New instat.ucrReceiverMultiple()
        Me.ucrChkDisplayInOutput = New instat.ucrCheck()
        Me.ucrSaveNewDataFrame = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 288)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrModelSelector
        '
        Me.ucrModelSelector.bDropUnusedFilterLevels = False
        Me.ucrModelSelector.bShowHiddenColumns = False
        Me.ucrModelSelector.bUseCurrentFilter = True
        Me.ucrModelSelector.Location = New System.Drawing.Point(9, 9)
        Me.ucrModelSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrModelSelector.Name = "ucrModelSelector"
        Me.ucrModelSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrModelSelector.TabIndex = 1
        '
        'lblModels
        '
        Me.lblModels.AutoSize = True
        Me.lblModels.Location = New System.Drawing.Point(318, 13)
        Me.lblModels.Name = "lblModels"
        Me.lblModels.Size = New System.Drawing.Size(41, 13)
        Me.lblModels.TabIndex = 2
        Me.lblModels.Text = "Models"
        '
        'ucrModelReceiver
        '
        Me.ucrModelReceiver.frmParent = Me
        Me.ucrModelReceiver.Location = New System.Drawing.Point(294, 35)
        Me.ucrModelReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrModelReceiver.Name = "ucrModelReceiver"
        Me.ucrModelReceiver.Selector = Nothing
        Me.ucrModelReceiver.Size = New System.Drawing.Size(120, 100)
        Me.ucrModelReceiver.strNcFilePath = ""
        Me.ucrModelReceiver.TabIndex = 3
        Me.ucrModelReceiver.ucrSelector = Nothing
        '
        'ucrChkDisplayInOutput
        '
        Me.ucrChkDisplayInOutput.Checked = False
        Me.ucrChkDisplayInOutput.Location = New System.Drawing.Point(13, 206)
        Me.ucrChkDisplayInOutput.Name = "ucrChkDisplayInOutput"
        Me.ucrChkDisplayInOutput.Size = New System.Drawing.Size(287, 20)
        Me.ucrChkDisplayInOutput.TabIndex = 4
        '
        'ucrSaveNewDataFrame
        '
        Me.ucrSaveNewDataFrame.Location = New System.Drawing.Point(13, 245)
        Me.ucrSaveNewDataFrame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveNewDataFrame.Name = "ucrSaveNewDataFrame"
        Me.ucrSaveNewDataFrame.Size = New System.Drawing.Size(287, 34)
        Me.ucrSaveNewDataFrame.TabIndex = 5
        '
        'dlgAugment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 347)
        Me.Controls.Add(Me.ucrSaveNewDataFrame)
        Me.Controls.Add(Me.ucrChkDisplayInOutput)
        Me.Controls.Add(Me.ucrModelReceiver)
        Me.Controls.Add(Me.lblModels)
        Me.Controls.Add(Me.ucrModelSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents ucrModelReceiver As ucrReceiverMultiple
    Friend WithEvents ucrSaveNewDataFrame As ucrSave
    Friend WithEvents ucrChkDisplayInOutput As ucrCheck
End Class
