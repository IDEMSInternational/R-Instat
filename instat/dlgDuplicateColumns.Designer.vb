<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDuplicateColumns
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
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrInputColumnName = New instat.ucrInputComboBox()
        Me.ucrReceiverForCopyColumns = New instat.ucrReceiverSingle()
        Me.ucrSelectorForDuplicateColumn = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.Location = New System.Drawing.Point(226, 13)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(104, 13)
        Me.lblColumns.TabIndex = 7
        Me.lblColumns.Text = "Column to be copied"
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(12, 221)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(98, 13)
        Me.lblNewColumnName.TabIndex = 11
        Me.lblNewColumnName.Text = "New Column Name"
        '
        'ucrInputColumnName
        '
        Me.ucrInputColumnName.IsReadOnly = False
        Me.ucrInputColumnName.Location = New System.Drawing.Point(149, 213)
        Me.ucrInputColumnName.Name = "ucrInputColumnName"
        Me.ucrInputColumnName.Size = New System.Drawing.Size(200, 21)
        Me.ucrInputColumnName.TabIndex = 10
        '
        'ucrReceiverForCopyColumns
        '
        Me.ucrReceiverForCopyColumns.Location = New System.Drawing.Point(229, 30)
        Me.ucrReceiverForCopyColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForCopyColumns.Name = "ucrReceiverForCopyColumns"
        Me.ucrReceiverForCopyColumns.Selector = Nothing
        Me.ucrReceiverForCopyColumns.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverForCopyColumns.TabIndex = 9
        '
        'ucrSelectorForDuplicateColumn
        '
        Me.ucrSelectorForDuplicateColumn.bShowHiddenColumns = False
        Me.ucrSelectorForDuplicateColumn.bUseCurrentFilter = True
        Me.ucrSelectorForDuplicateColumn.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorForDuplicateColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDuplicateColumn.Name = "ucrSelectorForDuplicateColumn"
        Me.ucrSelectorForDuplicateColumn.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForDuplicateColumn.TabIndex = 8
        '
        'ucrBase
        '
        Me.ucrBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucrBase.Location = New System.Drawing.Point(12, 244)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(403, 53)
        Me.ucrBase.TabIndex = 6
        '
        'dlgDuplicateColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 309)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrInputColumnName)
        Me.Controls.Add(Me.ucrReceiverForCopyColumns)
        Me.Controls.Add(Me.ucrSelectorForDuplicateColumn)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDuplicateColumns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Duplicate Column"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForDuplicateColumn As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverForCopyColumns As ucrReceiverSingle
    Friend WithEvents ucrInputColumnName As ucrInputComboBox
    Friend WithEvents lblNewColumnName As Label
End Class
