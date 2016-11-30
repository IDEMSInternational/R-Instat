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
        Me.lblNumberOfColumns = New System.Windows.Forms.Label()
        Me.nudNumberOfColumns = New System.Windows.Forms.NumericUpDown()
        Me.nudSetSeed = New System.Windows.Forms.NumericUpDown()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrInputPermuteRows = New instat.ucrInputComboBox()
        Me.ucrReceiverPermuteRows = New instat.ucrReceiverSingle()
        Me.ucrPermuteRowsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudNumberOfColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSetSeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(248, 30)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(93, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Tag = "Selected"
        Me.lblSelected.Text = "Selected Variable:"
        '
        'chkSetSeed
        '
        Me.chkSetSeed.AutoSize = True
        Me.chkSetSeed.Location = New System.Drawing.Point(247, 84)
        Me.chkSetSeed.Name = "chkSetSeed"
        Me.chkSetSeed.Size = New System.Drawing.Size(70, 17)
        Me.chkSetSeed.TabIndex = 3
        Me.chkSetSeed.Tag = "Set_Seed"
        Me.chkSetSeed.Text = "Set Seed"
        Me.chkSetSeed.UseVisualStyleBackColor = True
        '
        'lblNumberOfColumns
        '
        Me.lblNumberOfColumns.AutoSize = True
        Me.lblNumberOfColumns.Location = New System.Drawing.Point(245, 112)
        Me.lblNumberOfColumns.Name = "lblNumberOfColumns"
        Me.lblNumberOfColumns.Size = New System.Drawing.Size(102, 13)
        Me.lblNumberOfColumns.TabIndex = 5
        Me.lblNumberOfColumns.Tag = "Number_of_Colums"
        Me.lblNumberOfColumns.Text = "Number of Columns:"
        '
        'nudNumberOfColumns
        '
        Me.nudNumberOfColumns.Location = New System.Drawing.Point(350, 109)
        Me.nudNumberOfColumns.Name = "nudNumberOfColumns"
        Me.nudNumberOfColumns.Size = New System.Drawing.Size(47, 20)
        Me.nudNumberOfColumns.TabIndex = 6
        Me.nudNumberOfColumns.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudSetSeed
        '
        Me.nudSetSeed.Location = New System.Drawing.Point(323, 82)
        Me.nudSetSeed.Name = "nudSetSeed"
        Me.nudSetSeed.Size = New System.Drawing.Size(44, 20)
        Me.nudSetSeed.TabIndex = 4
        Me.nudSetSeed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(10, 205)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(101, 13)
        Me.lblNewColumnName.TabIndex = 7
        Me.lblNewColumnName.Tag = "New_Column_Name"
        Me.lblNewColumnName.Text = "New Column Name:"
        '
        'ucrInputPermuteRows
        '
        Me.ucrInputPermuteRows.IsReadOnly = False
        Me.ucrInputPermuteRows.Location = New System.Drawing.Point(117, 202)
        Me.ucrInputPermuteRows.Name = "ucrInputPermuteRows"
        Me.ucrInputPermuteRows.Size = New System.Drawing.Size(145, 21)
        Me.ucrInputPermuteRows.TabIndex = 8
        '
        'ucrReceiverPermuteRows
        '
        Me.ucrReceiverPermuteRows.Location = New System.Drawing.Point(247, 45)
        Me.ucrReceiverPermuteRows.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPermuteRows.Name = "ucrReceiverPermuteRows"
        Me.ucrReceiverPermuteRows.Selector = Nothing
        Me.ucrReceiverPermuteRows.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPermuteRows.TabIndex = 2
        '
        'ucrPermuteRowsSelector
        '
        Me.ucrPermuteRowsSelector.bShowHiddenColumns = False
        Me.ucrPermuteRowsSelector.bUseCurrentFilter = True
        Me.ucrPermuteRowsSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrPermuteRowsSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrPermuteRowsSelector.Name = "ucrPermuteRowsSelector"
        Me.ucrPermuteRowsSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrPermuteRowsSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 229)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 9
        '
        'dlgPermuteColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 289)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrInputPermuteRows)
        Me.Controls.Add(Me.nudSetSeed)
        Me.Controls.Add(Me.nudNumberOfColumns)
        Me.Controls.Add(Me.lblNumberOfColumns)
        Me.Controls.Add(Me.chkSetSeed)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrReceiverPermuteRows)
        Me.Controls.Add(Me.ucrPermuteRowsSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPermuteColumn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Permute_Column"
        Me.Text = "Permute Column"
        CType(Me.nudNumberOfColumns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSetSeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPermuteRowsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverPermuteRows As ucrReceiverSingle
    Friend WithEvents lblSelected As Label
    Friend WithEvents chkSetSeed As CheckBox
    Friend WithEvents lblNumberOfColumns As Label
    Friend WithEvents nudNumberOfColumns As NumericUpDown
    Friend WithEvents nudSetSeed As NumericUpDown
    Friend WithEvents ucrInputPermuteRows As ucrInputComboBox
    Friend WithEvents lblNewColumnName As Label
End Class
