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
        Me.nudSampleSize = New System.Windows.Forms.NumericUpDown()
        Me.nudNumberOfColumns = New System.Windows.Forms.NumericUpDown()
        Me.chkWithReplacement = New System.Windows.Forms.CheckBox()
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.nudSeed = New System.Windows.Forms.NumericUpDown()
        Me.chkSeed = New System.Windows.Forms.CheckBox()
        Me.ucrNewDataFrameName = New instat.ucrInputComboBox()
        Me.ucrReceiverSelected = New instat.ucrReceiverSingle()
        Me.ucrSelectorRandomSubsets = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudSampleSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberOfColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(260, 81)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(49, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Tag = "Selected"
        Me.lblSelected.Text = "Selected"
        '
        'lblSampleSize
        '
        Me.lblSampleSize.AutoSize = True
        Me.lblSampleSize.Location = New System.Drawing.Point(10, 217)
        Me.lblSampleSize.Name = "lblSampleSize"
        Me.lblSampleSize.Size = New System.Drawing.Size(65, 13)
        Me.lblSampleSize.TabIndex = 6
        Me.lblSampleSize.Tag = "Sample_Size"
        Me.lblSampleSize.Text = "Sample Size"
        '
        'lblNumberOfColumns
        '
        Me.lblNumberOfColumns.AutoSize = True
        Me.lblNumberOfColumns.Location = New System.Drawing.Point(198, 215)
        Me.lblNumberOfColumns.Name = "lblNumberOfColumns"
        Me.lblNumberOfColumns.Size = New System.Drawing.Size(101, 13)
        Me.lblNumberOfColumns.TabIndex = 8
        Me.lblNumberOfColumns.Tag = "Number_Of_Columns"
        Me.lblNumberOfColumns.Text = "Number Of Columns"
        '
        'nudSampleSize
        '
        Me.nudSampleSize.Location = New System.Drawing.Point(85, 209)
        Me.nudSampleSize.Name = "nudSampleSize"
        Me.nudSampleSize.Size = New System.Drawing.Size(53, 20)
        Me.nudSampleSize.TabIndex = 11
        '
        'nudNumberOfColumns
        '
        Me.nudNumberOfColumns.Location = New System.Drawing.Point(301, 207)
        Me.nudNumberOfColumns.Name = "nudNumberOfColumns"
        Me.nudNumberOfColumns.Size = New System.Drawing.Size(49, 20)
        Me.nudNumberOfColumns.TabIndex = 12
        '
        'chkWithReplacement
        '
        Me.chkWithReplacement.AutoSize = True
        Me.chkWithReplacement.Location = New System.Drawing.Point(10, 242)
        Me.chkWithReplacement.Name = "chkWithReplacement"
        Me.chkWithReplacement.Size = New System.Drawing.Size(114, 17)
        Me.chkWithReplacement.TabIndex = 13
        Me.chkWithReplacement.Tag = "With_Replacement"
        Me.chkWithReplacement.Text = "With Replacement"
        Me.chkWithReplacement.UseVisualStyleBackColor = True
        '
        'lblNewDataFrameName
        '
        Me.lblNewDataFrameName.AutoSize = True
        Me.lblNewDataFrameName.Location = New System.Drawing.Point(10, 273)
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        Me.lblNewDataFrameName.Size = New System.Drawing.Size(115, 13)
        Me.lblNewDataFrameName.TabIndex = 15
        Me.lblNewDataFrameName.Tag = "New_DataFrame_Name"
        Me.lblNewDataFrameName.Text = "New DataFrame Name"
        '
        'nudSeed
        '
        Me.nudSeed.Location = New System.Drawing.Point(321, 129)
        Me.nudSeed.Name = "nudSeed"
        Me.nudSeed.Size = New System.Drawing.Size(50, 20)
        Me.nudSeed.TabIndex = 16
        '
        'chkSeed
        '
        Me.chkSeed.AutoSize = True
        Me.chkSeed.Location = New System.Drawing.Point(255, 131)
        Me.chkSeed.Name = "chkSeed"
        Me.chkSeed.Size = New System.Drawing.Size(51, 17)
        Me.chkSeed.TabIndex = 17
        Me.chkSeed.Tag = "Seed"
        Me.chkSeed.Text = "Seed"
        Me.chkSeed.UseVisualStyleBackColor = True
        '
        'ucrNewDataFrameName
        '
        Me.ucrNewDataFrameName.Location = New System.Drawing.Point(146, 264)
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        Me.ucrNewDataFrameName.Size = New System.Drawing.Size(137, 21)
        Me.ucrNewDataFrameName.TabIndex = 18
        '
        'ucrReceiverSelected
        '
        Me.ucrReceiverSelected.Location = New System.Drawing.Point(255, 97)
        Me.ucrReceiverSelected.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelected.Name = "ucrReceiverSelected"
        Me.ucrReceiverSelected.Selector = Nothing
        Me.ucrReceiverSelected.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverSelected.TabIndex = 2
        '
        'ucrSelectorRandomSubsets
        '
        Me.ucrSelectorRandomSubsets.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorRandomSubsets.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorRandomSubsets.Name = "ucrSelectorRandomSubsets"
        Me.ucrSelectorRandomSubsets.Size = New System.Drawing.Size(242, 194)
        Me.ucrSelectorRandomSubsets.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 299)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(400, 53)
        Me.ucrBase.TabIndex = 10
        '
        'dlgRandomSubsets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 363)
        Me.Controls.Add(Me.ucrNewDataFrameName)
        Me.Controls.Add(Me.chkSeed)
        Me.Controls.Add(Me.nudSeed)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.chkWithReplacement)
        Me.Controls.Add(Me.nudNumberOfColumns)
        Me.Controls.Add(Me.nudSampleSize)
        Me.Controls.Add(Me.lblNumberOfColumns)
        Me.Controls.Add(Me.lblSampleSize)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrReceiverSelected)
        Me.Controls.Add(Me.ucrSelectorRandomSubsets)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgRandomSubsets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Random_Subsets"
        Me.Text = "Random Subsets"
        CType(Me.nudSampleSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberOfColumns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorRandomSubsets As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverSelected As ucrReceiverSingle
    Friend WithEvents lblSelected As Label
    Friend WithEvents lblSampleSize As Label
    Friend WithEvents lblNumberOfColumns As Label
    Friend WithEvents nudSampleSize As NumericUpDown
    Friend WithEvents nudNumberOfColumns As NumericUpDown
    Friend WithEvents chkWithReplacement As CheckBox
    Friend WithEvents lblNewDataFrameName As Label
    Friend WithEvents nudSeed As NumericUpDown
    Friend WithEvents chkSeed As CheckBox
    Friend WithEvents ucrNewDataFrameName As ucrInputComboBox
End Class
