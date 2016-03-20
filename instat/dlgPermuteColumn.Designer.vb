<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPermuteColumn
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
        Me.chkSetSeed = New System.Windows.Forms.CheckBox()
        Me.lblNumberOfPermColumns = New System.Windows.Forms.Label()
        Me.nudNumberOfPerColumns = New System.Windows.Forms.NumericUpDown()
        Me.nudSetSeed = New System.Windows.Forms.NumericUpDown()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrInputPermuteRows = New instat.ucrInputComboBox()
        Me.ucrReceiverPermuteRows = New instat.ucrReceiverSingle()
        Me.ucrPermuteRowsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudNumberOfPerColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSetSeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(261, 25)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(49, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Tag = "Selected"
        Me.lblSelected.Text = "Selected"
        '
        'chkSetSeed
        '
        Me.chkSetSeed.AutoSize = True
        Me.chkSetSeed.Location = New System.Drawing.Point(269, 73)
        Me.chkSetSeed.Name = "chkSetSeed"
        Me.chkSetSeed.Size = New System.Drawing.Size(70, 17)
        Me.chkSetSeed.TabIndex = 3
        Me.chkSetSeed.Tag = "Set_Seed"
        Me.chkSetSeed.Text = "Set Seed"
        Me.chkSetSeed.UseVisualStyleBackColor = True
        '
        'lblNumberOfPermColumns
        '
        Me.lblNumberOfPermColumns.AutoSize = True
        Me.lblNumberOfPermColumns.Location = New System.Drawing.Point(18, 207)
        Me.lblNumberOfPermColumns.Name = "lblNumberOfPermColumns"
        Me.lblNumberOfPermColumns.Size = New System.Drawing.Size(158, 13)
        Me.lblNumberOfPermColumns.TabIndex = 5
        Me.lblNumberOfPermColumns.Tag = "Number_of_Permutation_Colums"
        Me.lblNumberOfPermColumns.Text = "Number of Permutation Columns"
        '
        'nudNumberOfPerColumns
        '
        Me.nudNumberOfPerColumns.Location = New System.Drawing.Point(182, 198)
        Me.nudNumberOfPerColumns.Name = "nudNumberOfPerColumns"
        Me.nudNumberOfPerColumns.Size = New System.Drawing.Size(61, 20)
        Me.nudNumberOfPerColumns.TabIndex = 6
        Me.nudNumberOfPerColumns.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudSetSeed
        '
        Me.nudSetSeed.Location = New System.Drawing.Point(269, 96)
        Me.nudSetSeed.Name = "nudSetSeed"
        Me.nudSetSeed.Size = New System.Drawing.Size(61, 20)
        Me.nudSetSeed.TabIndex = 4
        Me.nudSetSeed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(21, 238)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(98, 13)
        Me.lblNewColumnName.TabIndex = 7
        Me.lblNewColumnName.Tag = "New_Column_Name"
        Me.lblNewColumnName.Text = "New Column Name"
        '
        'ucrInputPermuteRows
        '
        Me.ucrInputPermuteRows.Location = New System.Drawing.Point(182, 238)
        Me.ucrInputPermuteRows.Name = "ucrInputPermuteRows"
        Me.ucrInputPermuteRows.Size = New System.Drawing.Size(137, 25)
        Me.ucrInputPermuteRows.TabIndex = 8
        '
        'ucrReceiverPermuteRows
        '
        Me.ucrReceiverPermuteRows.Location = New System.Drawing.Point(264, 41)
        Me.ucrReceiverPermuteRows.Name = "ucrReceiverPermuteRows"
        Me.ucrReceiverPermuteRows.Selector = Nothing
        Me.ucrReceiverPermuteRows.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverPermuteRows.TabIndex = 2
        '
        'ucrPermuteRowsSelector
        '
        Me.ucrPermuteRowsSelector.Location = New System.Drawing.Point(13, 13)
        Me.ucrPermuteRowsSelector.Name = "ucrPermuteRowsSelector"
        Me.ucrPermuteRowsSelector.Size = New System.Drawing.Size(242, 179)
        Me.ucrPermuteRowsSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 269)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 9
        '
        'dlgPermuteColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 321)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrInputPermuteRows)
        Me.Controls.Add(Me.nudSetSeed)
        Me.Controls.Add(Me.nudNumberOfPerColumns)
        Me.Controls.Add(Me.lblNumberOfPermColumns)
        Me.Controls.Add(Me.chkSetSeed)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrReceiverPermuteRows)
        Me.Controls.Add(Me.ucrPermuteRowsSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgPermuteColumn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Permute_Column"
        Me.Text = "Permute Column"
        CType(Me.nudNumberOfPerColumns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSetSeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPermuteRowsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverPermuteRows As ucrReceiverSingle
    Friend WithEvents lblSelected As Label
    Friend WithEvents chkSetSeed As CheckBox
    Friend WithEvents lblNumberOfPermColumns As Label
    Friend WithEvents nudNumberOfPerColumns As NumericUpDown
    Friend WithEvents nudSetSeed As NumericUpDown
    Friend WithEvents ucrInputPermuteRows As ucrInputComboBox
    Friend WithEvents lblNewColumnName As Label
End Class
