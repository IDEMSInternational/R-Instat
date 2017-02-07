<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgPermuteColumn
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
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.chkSetSeed = New System.Windows.Forms.CheckBox()
        Me.lblNumberOfColumns = New System.Windows.Forms.Label()
        Me.ucrReceiverPermuteRows = New instat.ucrReceiverSingle()
        Me.ucrPermuteRowsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.nudSetSeed = New System.Windows.Forms.NumericUpDown()
        Me.ucrSavePermute = New instat.ucrSave()
        Me.ucrNudNumberofColumns = New instat.ucrNud()
        CType(Me.nudSetSeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(249, 46)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(93, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Tag = "Selected_Variable:"
        Me.lblSelected.Text = "Selected Variable:"
        '
        'chkSetSeed
        '
        Me.chkSetSeed.AutoSize = True
        Me.chkSetSeed.Location = New System.Drawing.Point(247, 97)
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
        Me.lblNumberOfColumns.Location = New System.Drawing.Point(245, 125)
        Me.lblNumberOfColumns.Name = "lblNumberOfColumns"
        Me.lblNumberOfColumns.Size = New System.Drawing.Size(102, 13)
        Me.lblNumberOfColumns.TabIndex = 5
        Me.lblNumberOfColumns.Tag = "Number_of_Colums"
        Me.lblNumberOfColumns.Text = "Number of Columns:"
        '
        'ucrReceiverPermuteRows
        '
        Me.ucrReceiverPermuteRows.bAddRemoveParameter = True
        Me.ucrReceiverPermuteRows.bChangeParameterValue = True
        Me.ucrReceiverPermuteRows.frmParent = Me
        Me.ucrReceiverPermuteRows.Location = New System.Drawing.Point(247, 61)
        Me.ucrReceiverPermuteRows.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPermuteRows.Name = "ucrReceiverPermuteRows"
        Me.ucrReceiverPermuteRows.Selector = Nothing
        Me.ucrReceiverPermuteRows.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPermuteRows.TabIndex = 2
        '
        'ucrPermuteRowsSelector
        '
        Me.ucrPermuteRowsSelector.bAddRemoveParameter = True
        Me.ucrPermuteRowsSelector.bChangeParameterValue = True
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
        'nudSetSeed
        '
        Me.nudSetSeed.Location = New System.Drawing.Point(323, 95)
        Me.nudSetSeed.Name = "nudSetSeed"
        Me.nudSetSeed.Size = New System.Drawing.Size(44, 20)
        Me.nudSetSeed.TabIndex = 10
        '
        'ucrSavePermute
        '
        Me.ucrSavePermute.bAddRemoveParameter = True
        Me.ucrSavePermute.bChangeParameterValue = True
        Me.ucrSavePermute.Location = New System.Drawing.Point(13, 199)
        Me.ucrSavePermute.Name = "ucrSavePermute"
        Me.ucrSavePermute.Size = New System.Drawing.Size(294, 24)
        Me.ucrSavePermute.TabIndex = 12
        '
        'ucrNudNumberofColumns
        '
        Me.ucrNudNumberofColumns.bAddRemoveParameter = True
        Me.ucrNudNumberofColumns.bChangeParameterValue = True
        Me.ucrNudNumberofColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberofColumns.Location = New System.Drawing.Point(353, 120)
        Me.ucrNudNumberofColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberofColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofColumns.Name = "ucrNudNumberofColumns"
        Me.ucrNudNumberofColumns.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberofColumns.TabIndex = 13
        Me.ucrNudNumberofColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgPermuteColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 289)
        Me.Controls.Add(Me.ucrNudNumberofColumns)
        Me.Controls.Add(Me.ucrSavePermute)
        Me.Controls.Add(Me.nudSetSeed)
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
    Friend WithEvents nudSetSeed As NumericUpDown
    Friend WithEvents ucrSavePermute As ucrSave
    Friend WithEvents ucrNudNumberofColumns As ucrNud
End Class
