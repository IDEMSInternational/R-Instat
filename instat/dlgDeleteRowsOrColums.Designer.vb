<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDeleteRowsOrColums
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
        Me.lblNumberofRows = New System.Windows.Forms.Label()
        Me.lblColumnsToDelete = New System.Windows.Forms.Label()
        Me.lblRowNames = New System.Windows.Forms.Label()
        Me.rdoColumns = New System.Windows.Forms.RadioButton()
        Me.grpRows = New System.Windows.Forms.GroupBox()
        Me.rdoRows = New System.Windows.Forms.RadioButton()
        Me.ucrPnlRows = New instat.UcrPanel()
        Me.ucrNudRowsToDelete = New instat.ucrNud()
        Me.ucrSelectorForDeleteColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverForColumnsToDelete = New instat.ucrReceiverMultiple()
        Me.ucrDataFrameLengthForDeleteRows = New instat.ucrDataFrameLength()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpRows.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNumberofRows
        '
        Me.lblNumberofRows.AutoSize = True
        Me.lblNumberofRows.Location = New System.Drawing.Point(7, 133)
        Me.lblNumberofRows.Name = "lblNumberofRows"
        Me.lblNumberofRows.Size = New System.Drawing.Size(89, 13)
        Me.lblNumberofRows.TabIndex = 5
        Me.lblNumberofRows.Tag = "Number_of_Rows:"
        Me.lblNumberofRows.Text = "Number of Rows:"
        '
        'lblColumnsToDelete
        '
        Me.lblColumnsToDelete.AutoSize = True
        Me.lblColumnsToDelete.Location = New System.Drawing.Point(267, 73)
        Me.lblColumnsToDelete.Name = "lblColumnsToDelete"
        Me.lblColumnsToDelete.Size = New System.Drawing.Size(96, 13)
        Me.lblColumnsToDelete.TabIndex = 3
        Me.lblColumnsToDelete.Tag = "Columns_to_Delete"
        Me.lblColumnsToDelete.Text = "Columns to Delete:"
        '
        'lblRowNames
        '
        Me.lblRowNames.AutoSize = True
        Me.lblRowNames.Location = New System.Drawing.Point(9, 166)
        Me.lblRowNames.Name = "lblRowNames"
        Me.lblRowNames.Size = New System.Drawing.Size(78, 13)
        Me.lblRowNames.TabIndex = 7
        Me.lblRowNames.Tag = ""
        Me.lblRowNames.Text = "Row to Delete:"
        '
        'rdoColumns
        '
        Me.rdoColumns.AutoSize = True
        Me.rdoColumns.Location = New System.Drawing.Point(6, 10)
        Me.rdoColumns.Name = "rdoColumns"
        Me.rdoColumns.Size = New System.Drawing.Size(65, 17)
        Me.rdoColumns.TabIndex = 1
        Me.rdoColumns.TabStop = True
        Me.rdoColumns.Text = "Columns"
        Me.rdoColumns.UseVisualStyleBackColor = True
        '
        'grpRows
        '
        Me.grpRows.Controls.Add(Me.rdoColumns)
        Me.grpRows.Controls.Add(Me.rdoRows)
        Me.grpRows.Controls.Add(Me.ucrPnlRows)
        Me.grpRows.Location = New System.Drawing.Point(10, 2)
        Me.grpRows.Name = "grpRows"
        Me.grpRows.Size = New System.Drawing.Size(478, 36)
        Me.grpRows.TabIndex = 15
        Me.grpRows.TabStop = False
        '
        'rdoRows
        '
        Me.rdoRows.AutoSize = True
        Me.rdoRows.Location = New System.Drawing.Point(278, 13)
        Me.rdoRows.Name = "rdoRows"
        Me.rdoRows.Size = New System.Drawing.Size(52, 17)
        Me.rdoRows.TabIndex = 1
        Me.rdoRows.TabStop = True
        Me.rdoRows.Text = "Rows"
        Me.rdoRows.UseVisualStyleBackColor = True
        '
        'ucrPnlRows
        '
        Me.ucrPnlRows.bAddRemoveParameter = True
        Me.ucrPnlRows.bChangeParameterValue = True
        Me.ucrPnlRows.Location = New System.Drawing.Point(3, 10)
        Me.ucrPnlRows.Name = "ucrPnlRows"
        Me.ucrPnlRows.Size = New System.Drawing.Size(469, 20)
        Me.ucrPnlRows.TabIndex = 0
        '
        'ucrNudRowsToDelete
        '
        Me.ucrNudRowsToDelete.bAddRemoveParameter = True
        Me.ucrNudRowsToDelete.bChangeParameterValue = True
        Me.ucrNudRowsToDelete.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRowsToDelete.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRowsToDelete.Location = New System.Drawing.Point(100, 163)
        Me.ucrNudRowsToDelete.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRowsToDelete.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRowsToDelete.Name = "ucrNudRowsToDelete"
        Me.ucrNudRowsToDelete.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudRowsToDelete.TabIndex = 16
        Me.ucrNudRowsToDelete.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSelectorForDeleteColumns
        '
        Me.ucrSelectorForDeleteColumns.bAddRemoveParameter = True
        Me.ucrSelectorForDeleteColumns.bChangeParameterValue = True
        Me.ucrSelectorForDeleteColumns.bShowHiddenColumns = False
        Me.ucrSelectorForDeleteColumns.bUseCurrentFilter = True
        Me.ucrSelectorForDeleteColumns.Location = New System.Drawing.Point(10, 56)
        Me.ucrSelectorForDeleteColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDeleteColumns.Name = "ucrSelectorForDeleteColumns"
        Me.ucrSelectorForDeleteColumns.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForDeleteColumns.TabIndex = 2
        '
        'ucrReceiverForColumnsToDelete
        '
        Me.ucrReceiverForColumnsToDelete.bAddRemoveParameter = True
        Me.ucrReceiverForColumnsToDelete.bChangeParameterValue = True
        Me.ucrReceiverForColumnsToDelete.frmParent = Me
        Me.ucrReceiverForColumnsToDelete.Location = New System.Drawing.Point(264, 88)
        Me.ucrReceiverForColumnsToDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForColumnsToDelete.Name = "ucrReceiverForColumnsToDelete"
        Me.ucrReceiverForColumnsToDelete.Selector = Nothing
        Me.ucrReceiverForColumnsToDelete.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverForColumnsToDelete.TabIndex = 4
        '
        'ucrDataFrameLengthForDeleteRows
        '
        Me.ucrDataFrameLengthForDeleteRows.ucrDataFrameSelector = Nothing
        Me.ucrDataFrameLengthForDeleteRows.Location = New System.Drawing.Point(100, 129)
        Me.ucrDataFrameLengthForDeleteRows.Name = "ucrDataFrameLengthForDeleteRows"
        Me.ucrDataFrameLengthForDeleteRows.Size = New System.Drawing.Size(55, 24)
        Me.ucrDataFrameLengthForDeleteRows.TabIndex = 6
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(0, 261)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 9
        '
        'dlgDeleteRowsOrColums
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 315)
        Me.Controls.Add(Me.ucrDataFrameLengthForDeleteRows)
        Me.Controls.Add(Me.lblRowNames)
        Me.Controls.Add(Me.lblNumberofRows)
        Me.Controls.Add(Me.ucrNudRowsToDelete)
        Me.Controls.Add(Me.grpRows)
        Me.Controls.Add(Me.ucrSelectorForDeleteColumns)
        Me.Controls.Add(Me.lblColumnsToDelete)
        Me.Controls.Add(Me.ucrReceiverForColumnsToDelete)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDeleteRowsOrColums"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Delete_Rows_Columns"
        Me.Text = "Delete Rows/Columns"
        Me.grpRows.ResumeLayout(False)
        Me.grpRows.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblNumberofRows As Label
    Friend WithEvents ucrDataFrameLengthForDeleteRows As ucrDataFrameLength
    Friend WithEvents ucrSelectorForDeleteColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverForColumnsToDelete As ucrReceiverMultiple
    Friend WithEvents lblColumnsToDelete As Label
    Friend WithEvents lblRowNames As Label
    Friend WithEvents grpRows As GroupBox
    Friend WithEvents rdoRows As RadioButton
    Friend WithEvents ucrPnlRows As UcrPanel
    Friend WithEvents rdoColumns As RadioButton
    Friend WithEvents ucrNudRowsToDelete As ucrNud
End Class
