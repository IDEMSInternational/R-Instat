<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRandomSubsets
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
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblSampleSize = New System.Windows.Forms.Label()
        Me.lblNumberOfColumns = New System.Windows.Forms.Label()
        Me.ucrReceiverSelected = New instat.ucrReceiverSingle()
        Me.ucrSelectorRandomSubsets = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveRandoSubsets = New instat.ucrSave()
        Me.ucrNudSampleSize = New instat.ucrNud()
        Me.ucrNudNumberOfColumns = New instat.ucrNud()
        Me.ucrNudSetSeed = New instat.ucrNud()
        Me.ucrChkWithReplacement = New instat.ucrCheck()
        Me.ucrChkSetSeed = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(258, 30)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(93, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Tag = "Selected_Variable:"
        Me.lblSelected.Text = "Selected Variable:"
        '
        'lblSampleSize
        '
        Me.lblSampleSize.AutoSize = True
        Me.lblSampleSize.Location = New System.Drawing.Point(258, 87)
        Me.lblSampleSize.Name = "lblSampleSize"
        Me.lblSampleSize.Size = New System.Drawing.Size(68, 13)
        Me.lblSampleSize.TabIndex = 6
        Me.lblSampleSize.Tag = "Sample_Size:"
        Me.lblSampleSize.Text = "Sample Size:"
        '
        'lblNumberOfColumns
        '
        Me.lblNumberOfColumns.AutoSize = True
        Me.lblNumberOfColumns.Location = New System.Drawing.Point(258, 131)
        Me.lblNumberOfColumns.Name = "lblNumberOfColumns"
        Me.lblNumberOfColumns.Size = New System.Drawing.Size(102, 13)
        Me.lblNumberOfColumns.TabIndex = 8
        Me.lblNumberOfColumns.Tag = "Number_of_Columns:"
        Me.lblNumberOfColumns.Text = "Number of Columns:"
        '
        'ucrReceiverSelected
        '
        Me.ucrReceiverSelected.bAddRemoveParameter = True
        Me.ucrReceiverSelected.bChangeParameterValue = True
        Me.ucrReceiverSelected.frmParent = Me
        Me.ucrReceiverSelected.Location = New System.Drawing.Point(257, 44)
        Me.ucrReceiverSelected.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelected.Name = "ucrReceiverSelected"
        Me.ucrReceiverSelected.Selector = Nothing
        Me.ucrReceiverSelected.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverSelected.TabIndex = 2
        '
        'ucrSelectorRandomSubsets
        '
        Me.ucrSelectorRandomSubsets.bAddRemoveParameter = True
        Me.ucrSelectorRandomSubsets.bChangeParameterValue = True
        Me.ucrSelectorRandomSubsets.bShowHiddenColumns = False
        Me.ucrSelectorRandomSubsets.bUseCurrentFilter = True
        Me.ucrSelectorRandomSubsets.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorRandomSubsets.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorRandomSubsets.Name = "ucrSelectorRandomSubsets"
        Me.ucrSelectorRandomSubsets.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorRandomSubsets.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 269)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 10
        '
        'ucrSaveRandoSubsets
        '
        Me.ucrSaveRandoSubsets.bAddRemoveParameter = True
        Me.ucrSaveRandoSubsets.bChangeParameterValue = True
        Me.ucrSaveRandoSubsets.Location = New System.Drawing.Point(10, 236)
        Me.ucrSaveRandoSubsets.Name = "ucrSaveRandoSubsets"
        Me.ucrSaveRandoSubsets.Size = New System.Drawing.Size(275, 24)
        Me.ucrSaveRandoSubsets.TabIndex = 18
        '
        'ucrNudSampleSize
        '
        Me.ucrNudSampleSize.bAddRemoveParameter = True
        Me.ucrNudSampleSize.bChangeParameterValue = True
        Me.ucrNudSampleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSampleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSampleSize.Location = New System.Drawing.Point(363, 85)
        Me.ucrNudSampleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSampleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSampleSize.Name = "ucrNudSampleSize"
        Me.ucrNudSampleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSampleSize.TabIndex = 19
        Me.ucrNudSampleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNumberOfColumns
        '
        Me.ucrNudNumberOfColumns.bAddRemoveParameter = True
        Me.ucrNudNumberOfColumns.bChangeParameterValue = True
        Me.ucrNudNumberOfColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Location = New System.Drawing.Point(363, 130)
        Me.ucrNudNumberOfColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfColumns.Name = "ucrNudNumberOfColumns"
        Me.ucrNudNumberOfColumns.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberOfColumns.TabIndex = 20
        Me.ucrNudNumberOfColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSetSeed
        '
        Me.ucrNudSetSeed.bAddRemoveParameter = True
        Me.ucrNudSetSeed.bChangeParameterValue = True
        Me.ucrNudSetSeed.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSetSeed.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSetSeed.Location = New System.Drawing.Point(363, 170)
        Me.ucrNudSetSeed.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSetSeed.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSetSeed.Name = "ucrNudSetSeed"
        Me.ucrNudSetSeed.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSetSeed.TabIndex = 21
        Me.ucrNudSetSeed.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkWithReplacement
        '
        Me.ucrChkWithReplacement.bAddRemoveParameter = True
        Me.ucrChkWithReplacement.bChangeParameterValue = True
        Me.ucrChkWithReplacement.Checked = False
        Me.ucrChkWithReplacement.Location = New System.Drawing.Point(257, 210)
        Me.ucrChkWithReplacement.Name = "ucrChkWithReplacement"
        Me.ucrChkWithReplacement.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkWithReplacement.TabIndex = 22
        '
        'ucrChkSetSeed
        '
        Me.ucrChkSetSeed.bAddRemoveParameter = True
        Me.ucrChkSetSeed.bChangeParameterValue = True
        Me.ucrChkSetSeed.Checked = False
        Me.ucrChkSetSeed.Location = New System.Drawing.Point(257, 170)
        Me.ucrChkSetSeed.Name = "ucrChkSetSeed"
        Me.ucrChkSetSeed.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSetSeed.TabIndex = 23
        '
        'dlgRandomSubsets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 328)
        Me.Controls.Add(Me.ucrChkSetSeed)
        Me.Controls.Add(Me.ucrChkWithReplacement)
        Me.Controls.Add(Me.ucrNudSetSeed)
        Me.Controls.Add(Me.ucrNudNumberOfColumns)
        Me.Controls.Add(Me.ucrNudSampleSize)
        Me.Controls.Add(Me.ucrSaveRandoSubsets)
        Me.Controls.Add(Me.lblNumberOfColumns)
        Me.Controls.Add(Me.lblSampleSize)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrReceiverSelected)
        Me.Controls.Add(Me.ucrSelectorRandomSubsets)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRandomSubsets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Random_Subsets"
        Me.Text = "Random Subsets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorRandomSubsets As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverSelected As ucrReceiverSingle
    Friend WithEvents lblSelected As Label
    Friend WithEvents lblSampleSize As Label
    Friend WithEvents lblNumberOfColumns As Label
    Friend WithEvents nudSetSeed As NumericUpDown
    Friend WithEvents ucrSaveRandoSubsets As ucrSave
    Friend WithEvents ucrNudSampleSize As ucrNud
    Friend WithEvents ucrNudNumberOfColumns As ucrNud
    Friend WithEvents ucrChkWithReplacement As ucrCheck
    Friend WithEvents ucrNudSetSeed As ucrNud
    Friend WithEvents ucrChkSetSeed As ucrCheck
End Class
