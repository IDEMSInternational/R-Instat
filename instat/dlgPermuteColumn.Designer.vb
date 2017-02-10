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
        Me.lblNumberOfColumns = New System.Windows.Forms.Label()
        Me.ucrChkSetSeed = New instat.ucrCheck()
        Me.ucrNudSetSeed = New instat.ucrNud()
        Me.ucrNudNumberofColumns = New instat.ucrNud()
        Me.ucrSavePermute = New instat.ucrSave()
        Me.ucrReceiverPermuteRows = New instat.ucrReceiverSingle()
        Me.ucrPermuteRowsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(246, 42)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(93, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Tag = "Selected_Variable:"
        Me.lblSelected.Text = "Selected Variable:"
        '
        'lblNumberOfColumns
        '
        Me.lblNumberOfColumns.AutoSize = True
        Me.lblNumberOfColumns.Location = New System.Drawing.Point(244, 117)
        Me.lblNumberOfColumns.Name = "lblNumberOfColumns"
        Me.lblNumberOfColumns.Size = New System.Drawing.Size(102, 13)
        Me.lblNumberOfColumns.TabIndex = 5
        Me.lblNumberOfColumns.Tag = "Number_of_Colums"
        Me.lblNumberOfColumns.Text = "Number of Columns:"
        '
        'ucrChkSetSeed
        '
        Me.ucrChkSetSeed.bAddRemoveParameter = True
        Me.ucrChkSetSeed.bChangeParameterValue = True
        Me.ucrChkSetSeed.Checked = False
        Me.ucrChkSetSeed.Location = New System.Drawing.Point(247, 90)
        Me.ucrChkSetSeed.Name = "ucrChkSetSeed"
        Me.ucrChkSetSeed.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSetSeed.TabIndex = 3
        '
        'ucrNudSetSeed
        '
        Me.ucrNudSetSeed.bAddRemoveParameter = True
        Me.ucrNudSetSeed.bChangeParameterValue = True
        Me.ucrNudSetSeed.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSetSeed.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSetSeed.Location = New System.Drawing.Point(352, 88)
        Me.ucrNudSetSeed.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSetSeed.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSetSeed.Name = "ucrNudSetSeed"
        Me.ucrNudSetSeed.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSetSeed.TabIndex = 4
        Me.ucrNudSetSeed.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNumberofColumns
        '
        Me.ucrNudNumberofColumns.bAddRemoveParameter = True
        Me.ucrNudNumberofColumns.bChangeParameterValue = True
        Me.ucrNudNumberofColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberofColumns.Location = New System.Drawing.Point(352, 117)
        Me.ucrNudNumberofColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberofColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofColumns.Name = "ucrNudNumberofColumns"
        Me.ucrNudNumberofColumns.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberofColumns.TabIndex = 6
        Me.ucrNudNumberofColumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSavePermute
        '
        Me.ucrSavePermute.bAddRemoveParameter = True
        Me.ucrSavePermute.bChangeParameterValue = True
        Me.ucrSavePermute.Location = New System.Drawing.Point(10, 199)
        Me.ucrSavePermute.Name = "ucrSavePermute"
        Me.ucrSavePermute.Size = New System.Drawing.Size(207, 24)
        Me.ucrSavePermute.TabIndex = 7
        '
        'ucrReceiverPermuteRows
        '
        Me.ucrReceiverPermuteRows.bAddRemoveParameter = True
        Me.ucrReceiverPermuteRows.bChangeParameterValue = True
        Me.ucrReceiverPermuteRows.frmParent = Me
        Me.ucrReceiverPermuteRows.Location = New System.Drawing.Point(247, 60)
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
        Me.ucrBase.Location = New System.Drawing.Point(10, 229)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 8
        '
        'dlgPermuteColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 289)
        Me.Controls.Add(Me.ucrChkSetSeed)
        Me.Controls.Add(Me.ucrNudSetSeed)
        Me.Controls.Add(Me.ucrNudNumberofColumns)
        Me.Controls.Add(Me.ucrSavePermute)
        Me.Controls.Add(Me.lblNumberOfColumns)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPermuteRowsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverPermuteRows As ucrReceiverSingle
    Friend WithEvents lblSelected As Label
    Friend WithEvents lblNumberOfColumns As Label
    Friend WithEvents ucrSavePermute As ucrSave
    Friend WithEvents ucrNudNumberofColumns As ucrNud
    Friend WithEvents ucrNudSetSeed As ucrNud
    Friend WithEvents ucrChkSetSeed As ucrCheck
End Class
