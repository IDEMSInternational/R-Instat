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
        Me.ucrSelectorCombineFactors = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrFactorsReceiver = New instat.ucrReceiverMultiple()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.UcrInputComboBox1 = New instat.ucrInputComboBox()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'ucrSelectorCombineFactors
        '
        Me.ucrSelectorCombineFactors.Location = New System.Drawing.Point(3, 4)
        Me.ucrSelectorCombineFactors.Name = "ucrSelectorCombineFactors"
        Me.ucrSelectorCombineFactors.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorCombineFactors.TabIndex = 26
        '
        'ucrFactorsReceiver
        '
        Me.ucrFactorsReceiver.Location = New System.Drawing.Point(246, 54)
        Me.ucrFactorsReceiver.Name = "ucrFactorsReceiver"
        Me.ucrFactorsReceiver.Selector = Nothing
        Me.ucrFactorsReceiver.Size = New System.Drawing.Size(121, 104)
        Me.ucrFactorsReceiver.TabIndex = 27
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(251, 30)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(42, 13)
        Me.lblFactors.TabIndex = 28
        Me.lblFactors.Tag = "Factors"
        Me.lblFactors.Text = "Factors"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(13, 190)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(126, 17)
        Me.CheckBox1.TabIndex = 29
        Me.CheckBox1.Tag = "Drop_Unused_Levels "
        Me.CheckBox1.Text = "Drop Unused Levels "
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'UcrInputComboBox1
        '
        Me.UcrInputComboBox1.Location = New System.Drawing.Point(165, 214)
        Me.UcrInputComboBox1.Name = "UcrInputComboBox1"
        Me.UcrInputComboBox1.Size = New System.Drawing.Size(171, 25)
        Me.UcrInputComboBox1.TabIndex = 30
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(13, 219)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(98, 13)
        Me.lblNewColumnName.TabIndex = 31
        Me.lblNewColumnName.Tag = "New_Column_Name"
        Me.lblNewColumnName.Text = "New Column Name"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(0, 241)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 32
        '
        'dlgCombine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 304)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.UcrInputComboBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrFactorsReceiver)
        Me.Controls.Add(Me.ucrSelectorCombineFactors)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgCombine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Combine_Factors"
        Me.Text = "Combine Factors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSelectorCombineFactors As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFactorsReceiver As ucrReceiverMultiple
    Friend WithEvents lblFactors As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents UcrInputComboBox1 As ucrInputComboBox
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents ucrBase As ucrButtons
End Class
