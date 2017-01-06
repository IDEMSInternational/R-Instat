<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgAddKey
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
        Me.lblKeyName = New System.Windows.Forms.Label()
        Me.cmdCheckUnique = New System.Windows.Forms.Button()
        Me.lblKeyColumns = New System.Windows.Forms.Label()
        Me.ucrInputCheckInput = New instat.ucrInputTextBox()
        Me.ucrInputKeyName = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorKeyColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverKeyColumns = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'lblKeyName
        '
        Me.lblKeyName.AutoSize = True
        Me.lblKeyName.Location = New System.Drawing.Point(10, 215)
        Me.lblKeyName.Name = "lblKeyName"
        Me.lblKeyName.Size = New System.Drawing.Size(59, 13)
        Me.lblKeyName.TabIndex = 4
        Me.lblKeyName.Text = "Key Name:"
        '
        'cmdCheckUnique
        '
        Me.cmdCheckUnique.Location = New System.Drawing.Point(10, 249)
        Me.cmdCheckUnique.Name = "cmdCheckUnique"
        Me.cmdCheckUnique.Size = New System.Drawing.Size(98, 23)
        Me.cmdCheckUnique.TabIndex = 5
        Me.cmdCheckUnique.Text = "Check Unique"
        Me.cmdCheckUnique.UseVisualStyleBackColor = True
        '
        'lblKeyColumns
        '
        Me.lblKeyColumns.AutoSize = True
        Me.lblKeyColumns.Location = New System.Drawing.Point(270, 32)
        Me.lblKeyColumns.Name = "lblKeyColumns"
        Me.lblKeyColumns.Size = New System.Drawing.Size(71, 13)
        Me.lblKeyColumns.TabIndex = 7
        Me.lblKeyColumns.Text = "Key Columns:"
        '
        'ucrInputCheckInput
        '
        Me.ucrInputCheckInput.IsReadOnly = False
        Me.ucrInputCheckInput.Location = New System.Drawing.Point(114, 250)
        Me.ucrInputCheckInput.Name = "ucrInputCheckInput"
        Me.ucrInputCheckInput.Size = New System.Drawing.Size(288, 21)
        Me.ucrInputCheckInput.TabIndex = 6
        '
        'ucrInputKeyName
        '
        Me.ucrInputKeyName.IsReadOnly = False
        Me.ucrInputKeyName.Location = New System.Drawing.Point(77, 214)
        Me.ucrInputKeyName.Name = "ucrInputKeyName"
        Me.ucrInputKeyName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputKeyName.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 285)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(438, 52)
        Me.ucrBase.TabIndex = 2
        '
        'ucrSelectorKeyColumns
        '
        Me.ucrSelectorKeyColumns.bShowHiddenColumns = False
        Me.ucrSelectorKeyColumns.bUseCurrentFilter = True
        Me.ucrSelectorKeyColumns.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorKeyColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorKeyColumns.Name = "ucrSelectorKeyColumns"
        Me.ucrSelectorKeyColumns.Size = New System.Drawing.Size(241, 180)
        Me.ucrSelectorKeyColumns.TabIndex = 1
        '
        'ucrReceiverKeyColumns
        '
        Me.ucrReceiverKeyColumns.Location = New System.Drawing.Point(273, 56)
        Me.ucrReceiverKeyColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverKeyColumns.Name = "ucrReceiverKeyColumns"
        Me.ucrReceiverKeyColumns.Selector = Nothing
        Me.ucrReceiverKeyColumns.Size = New System.Drawing.Size(132, 133)
        Me.ucrReceiverKeyColumns.TabIndex = 0
        '
        'dlgAddKey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 340)
        Me.Controls.Add(Me.lblKeyColumns)
        Me.Controls.Add(Me.ucrInputCheckInput)
        Me.Controls.Add(Me.cmdCheckUnique)
        Me.Controls.Add(Me.lblKeyName)
        Me.Controls.Add(Me.ucrInputKeyName)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorKeyColumns)
        Me.Controls.Add(Me.ucrReceiverKeyColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAddKey"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Key"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverKeyColumns As instat.ucrReceiverMultiple
    Friend WithEvents ucrSelectorKeyColumns As instat.ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As instat.ucrButtons
    Friend WithEvents ucrInputKeyName As instat.ucrInputTextBox
    Friend WithEvents lblKeyName As System.Windows.Forms.Label
    Friend WithEvents cmdCheckUnique As System.Windows.Forms.Button
    Friend WithEvents ucrInputCheckInput As instat.ucrInputTextBox
    Friend WithEvents lblKeyColumns As System.Windows.Forms.Label
End Class