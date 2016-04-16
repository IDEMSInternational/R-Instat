<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCombine
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
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.chkDropUnusedLevels = New System.Windows.Forms.CheckBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrFactorsReceiver = New instat.ucrReceiverMultiple()
        Me.ucrSelectorCombineFactors = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrInputColName = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(263, 55)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(42, 13)
        Me.lblFactors.TabIndex = 1
        Me.lblFactors.Tag = "Factors"
        Me.lblFactors.Text = "Factors"
        '
        'chkDropUnusedLevels
        '
        Me.chkDropUnusedLevels.AutoSize = True
        Me.chkDropUnusedLevels.Location = New System.Drawing.Point(9, 191)
        Me.chkDropUnusedLevels.Name = "chkDropUnusedLevels"
        Me.chkDropUnusedLevels.Size = New System.Drawing.Size(126, 17)
        Me.chkDropUnusedLevels.TabIndex = 3
        Me.chkDropUnusedLevels.Tag = "Drop_Unused_Levels "
        Me.chkDropUnusedLevels.Text = "Drop Unused Levels "
        Me.chkDropUnusedLevels.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(4, 248)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Padding = New System.Windows.Forms.Padding(10, 0, 0, 10)
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 6
        '
        'ucrFactorsReceiver
        '
        Me.ucrFactorsReceiver.Location = New System.Drawing.Point(253, 66)
        Me.ucrFactorsReceiver.Name = "ucrFactorsReceiver"
        Me.ucrFactorsReceiver.Selector = Nothing
        Me.ucrFactorsReceiver.Size = New System.Drawing.Size(121, 104)
        Me.ucrFactorsReceiver.TabIndex = 2
        '
        'ucrSelectorCombineFactors
        '
        Me.ucrSelectorCombineFactors.Location = New System.Drawing.Point(6, 6)
        Me.ucrSelectorCombineFactors.Name = "ucrSelectorCombineFactors"
        Me.ucrSelectorCombineFactors.Padding = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.ucrSelectorCombineFactors.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorCombineFactors.TabIndex = 0
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(9, 220)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(98, 13)
        Me.lblNewColumnName.TabIndex = 4
        Me.lblNewColumnName.Tag = "New_Column_Name"
        Me.lblNewColumnName.Text = "New Column Name"
        '
        'ucrInputColName
        '
        Me.ucrInputColName.Location = New System.Drawing.Point(118, 216)
        Me.ucrInputColName.Name = "ucrInputColName"
        Me.ucrInputColName.Size = New System.Drawing.Size(171, 25)
        Me.ucrInputColName.TabIndex = 5
        '
        'dlgCombine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 308)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrInputColName)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.chkDropUnusedLevels)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrFactorsReceiver)
        Me.Controls.Add(Me.ucrSelectorCombineFactors)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgCombine"
        Me.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Combine_Factors"
        Me.Text = "Combine Factors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSelectorCombineFactors As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFactorsReceiver As ucrReceiverMultiple
    Friend WithEvents lblFactors As Label
    Friend WithEvents chkDropUnusedLevels As CheckBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents ucrInputColName As ucrInputComboBox
End Class
