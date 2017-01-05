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
        Me.grpDuplicatedColumn = New System.Windows.Forms.GroupBox()
        Me.rdoBefore = New System.Windows.Forms.RadioButton()
        Me.rdoEnd = New System.Windows.Forms.RadioButton()
        Me.rdoAfter = New System.Windows.Forms.RadioButton()
        Me.rdoBeginning = New System.Windows.Forms.RadioButton()
        Me.grpDuplicatedColumn.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.Location = New System.Drawing.Point(226, 13)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(107, 13)
        Me.lblColumns.TabIndex = 7
        Me.lblColumns.Text = "Column to be copied:"
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(12, 221)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(101, 13)
        Me.lblNewColumnName.TabIndex = 11
        Me.lblNewColumnName.Text = "New Column Name:"
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
        'grpDuplicatedColumn
        '
        Me.grpDuplicatedColumn.Controls.Add(Me.rdoBefore)
        Me.grpDuplicatedColumn.Controls.Add(Me.rdoEnd)
        Me.grpDuplicatedColumn.Controls.Add(Me.rdoAfter)
        Me.grpDuplicatedColumn.Controls.Add(Me.rdoBeginning)
        Me.grpDuplicatedColumn.Location = New System.Drawing.Point(227, 54)
        Me.grpDuplicatedColumn.Name = "grpDuplicatedColumn"
        Me.grpDuplicatedColumn.Size = New System.Drawing.Size(174, 115)
        Me.grpDuplicatedColumn.TabIndex = 12
        Me.grpDuplicatedColumn.TabStop = False
        Me.grpDuplicatedColumn.Text = "Position of Duplicated Column"
        '
        'rdoBefore
        '
        Me.rdoBefore.AutoSize = True
        Me.rdoBefore.Location = New System.Drawing.Point(6, 42)
        Me.rdoBefore.Name = "rdoBefore"
        Me.rdoBefore.Size = New System.Drawing.Size(56, 17)
        Me.rdoBefore.TabIndex = 3
        Me.rdoBefore.TabStop = True
        Me.rdoBefore.Text = "Before"
        Me.rdoBefore.UseVisualStyleBackColor = True
        '
        'rdoEnd
        '
        Me.rdoEnd.AutoSize = True
        Me.rdoEnd.Location = New System.Drawing.Point(6, 88)
        Me.rdoEnd.Name = "rdoEnd"
        Me.rdoEnd.Size = New System.Drawing.Size(44, 17)
        Me.rdoEnd.TabIndex = 2
        Me.rdoEnd.TabStop = True
        Me.rdoEnd.Text = "End"
        Me.rdoEnd.UseVisualStyleBackColor = True
        '
        'rdoAfter
        '
        Me.rdoAfter.AutoSize = True
        Me.rdoAfter.Location = New System.Drawing.Point(6, 65)
        Me.rdoAfter.Name = "rdoAfter"
        Me.rdoAfter.Size = New System.Drawing.Size(47, 17)
        Me.rdoAfter.TabIndex = 1
        Me.rdoAfter.TabStop = True
        Me.rdoAfter.Text = "After"
        Me.rdoAfter.UseVisualStyleBackColor = True
        '
        'rdoBeginning
        '
        Me.rdoBeginning.AutoSize = True
        Me.rdoBeginning.Location = New System.Drawing.Point(6, 19)
        Me.rdoBeginning.Name = "rdoBeginning"
        Me.rdoBeginning.Size = New System.Drawing.Size(72, 17)
        Me.rdoBeginning.TabIndex = 0
        Me.rdoBeginning.TabStop = True
        Me.rdoBeginning.Text = "Beginning"
        Me.rdoBeginning.UseVisualStyleBackColor = True
        '
        'dlgDuplicateColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 309)
        Me.Controls.Add(Me.grpDuplicatedColumn)
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
        Me.grpDuplicatedColumn.ResumeLayout(False)
        Me.grpDuplicatedColumn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForDuplicateColumn As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverForCopyColumns As ucrReceiverSingle
    Friend WithEvents ucrInputColumnName As ucrInputComboBox
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents grpDuplicatedColumn As GroupBox
    Friend WithEvents rdoBefore As RadioButton
    Friend WithEvents rdoEnd As RadioButton
    Friend WithEvents rdoAfter As RadioButton
    Friend WithEvents rdoBeginning As RadioButton
End Class
