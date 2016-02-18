<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPermuteRows
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
        Me.ucrSelectorDataFrameAddRemove = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorNewColumnName = New instat.ucrNewColumnName()
        Me.ucrReceiverPermuteRows = New instat.ucrReceiverSingle()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.chkSetSeed = New System.Windows.Forms.CheckBox()
        Me.txtSetSeed = New System.Windows.Forms.TextBox()
        Me.txtNumberOfPerColumns = New System.Windows.Forms.TextBox()
        Me.lblNumberOfPermColumns = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 269)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorDataFrameAddRemove
        '
        Me.ucrSelectorDataFrameAddRemove.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorDataFrameAddRemove.Name = "ucrSelectorDataFrameAddRemove"
        Me.ucrSelectorDataFrameAddRemove.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorDataFrameAddRemove.TabIndex = 1
        '
        'ucrSelectorNewColumnName
        '
        Me.ucrSelectorNewColumnName.Location = New System.Drawing.Point(13, 228)
        Me.ucrSelectorNewColumnName.Name = "ucrSelectorNewColumnName"
        Me.ucrSelectorNewColumnName.Size = New System.Drawing.Size(367, 35)
        Me.ucrSelectorNewColumnName.TabIndex = 2
        Me.ucrSelectorNewColumnName.ucrDataFrameSelector = Nothing
        '
        'ucrReceiverPermuteRows
        '
        Me.ucrReceiverPermuteRows.Location = New System.Drawing.Point(264, 41)
        Me.ucrReceiverPermuteRows.Name = "ucrReceiverPermuteRows"
        Me.ucrReceiverPermuteRows.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverPermuteRows.TabIndex = 3
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(261, 25)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(49, 13)
        Me.lblSelected.TabIndex = 4
        Me.lblSelected.Tag = "Selected"
        Me.lblSelected.Text = "Selected"
        '
        'chkSetSeed
        '
        Me.chkSetSeed.AutoSize = True
        Me.chkSetSeed.Location = New System.Drawing.Point(273, 121)
        Me.chkSetSeed.Name = "chkSetSeed"
        Me.chkSetSeed.Size = New System.Drawing.Size(70, 17)
        Me.chkSetSeed.TabIndex = 5
        Me.chkSetSeed.Tag = "Set_Seed"
        Me.chkSetSeed.Text = "Set Seed"
        Me.chkSetSeed.UseVisualStyleBackColor = True
        '
        'txtSetSeed
        '
        Me.txtSetSeed.Location = New System.Drawing.Point(361, 121)
        Me.txtSetSeed.Name = "txtSetSeed"
        Me.txtSetSeed.Size = New System.Drawing.Size(61, 20)
        Me.txtSetSeed.TabIndex = 6
        '
        'txtNumberOfPerColumns
        '
        Me.txtNumberOfPerColumns.Location = New System.Drawing.Point(321, 200)
        Me.txtNumberOfPerColumns.Name = "txtNumberOfPerColumns"
        Me.txtNumberOfPerColumns.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberOfPerColumns.TabIndex = 7
        Me.txtNumberOfPerColumns.Tag = ""
        '
        'lblNumberOfPermColumns
        '
        Me.lblNumberOfPermColumns.AutoSize = True
        Me.lblNumberOfPermColumns.Location = New System.Drawing.Point(29, 207)
        Me.lblNumberOfPermColumns.Name = "lblNumberOfPermColumns"
        Me.lblNumberOfPermColumns.Size = New System.Drawing.Size(158, 13)
        Me.lblNumberOfPermColumns.TabIndex = 8
        Me.lblNumberOfPermColumns.Tag = "Number_of_Permutation_Colums"
        Me.lblNumberOfPermColumns.Text = "Number of Permutation Columns"
        '
        'dlgPermuteRows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 334)
        Me.Controls.Add(Me.lblNumberOfPermColumns)
        Me.Controls.Add(Me.txtNumberOfPerColumns)
        Me.Controls.Add(Me.txtSetSeed)
        Me.Controls.Add(Me.chkSetSeed)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrReceiverPermuteRows)
        Me.Controls.Add(Me.ucrSelectorNewColumnName)
        Me.Controls.Add(Me.ucrSelectorDataFrameAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgPermuteRows"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Permute_Rows"
        Me.Text = "Permute Rows"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDataFrameAddRemove As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorNewColumnName As ucrNewColumnName
    Friend WithEvents ucrReceiverPermuteRows As ucrReceiverSingle
    Friend WithEvents lblSelected As Label
    Friend WithEvents chkSetSeed As CheckBox
    Friend WithEvents txtSetSeed As TextBox
    Friend WithEvents txtNumberOfPerColumns As TextBox
    Friend WithEvents lblNumberOfPermColumns As Label
End Class
