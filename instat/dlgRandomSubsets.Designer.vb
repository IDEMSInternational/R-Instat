<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRandomSubsets
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
        Me.ucrSelectorRandomSubsets = New instat.ucrSelectorByDataFrameAddRemove()
        Me.UcrReceiverSingle1 = New instat.ucrReceiverSingle()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.chkSetSeed = New System.Windows.Forms.CheckBox()
        Me.rdoWithReplacement = New System.Windows.Forms.RadioButton()
        Me.rdoWithoutReplacement = New System.Windows.Forms.RadioButton()
        Me.lblSampleSize = New System.Windows.Forms.Label()
        Me.txtSampleSize = New System.Windows.Forms.TextBox()
        Me.lblNumberOfColumns = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 243)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorRandomSubsets
        '
        Me.ucrSelectorRandomSubsets.Location = New System.Drawing.Point(3, 3)
        Me.ucrSelectorRandomSubsets.Name = "ucrSelectorRandomSubsets"
        Me.ucrSelectorRandomSubsets.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorRandomSubsets.TabIndex = 1
        '
        'UcrReceiverSingle1
        '
        Me.UcrReceiverSingle1.Location = New System.Drawing.Point(262, 47)
        Me.UcrReceiverSingle1.Name = "UcrReceiverSingle1"
        Me.UcrReceiverSingle1.Selector = Nothing
        Me.UcrReceiverSingle1.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle1.TabIndex = 2
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(267, 31)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(49, 13)
        Me.lblSelected.TabIndex = 3
        Me.lblSelected.Tag = "Selected"
        Me.lblSelected.Text = "Selected"
        '
        'chkSetSeed
        '
        Me.chkSetSeed.AutoSize = True
        Me.chkSetSeed.Location = New System.Drawing.Point(266, 80)
        Me.chkSetSeed.Name = "chkSetSeed"
        Me.chkSetSeed.Size = New System.Drawing.Size(70, 17)
        Me.chkSetSeed.TabIndex = 4
        Me.chkSetSeed.Tag = "Set_Seed"
        Me.chkSetSeed.Text = "Set Seed"
        Me.chkSetSeed.UseVisualStyleBackColor = True
        '
        'rdoWithReplacement
        '
        Me.rdoWithReplacement.AutoSize = True
        Me.rdoWithReplacement.Location = New System.Drawing.Point(13, 182)
        Me.rdoWithReplacement.Name = "rdoWithReplacement"
        Me.rdoWithReplacement.Size = New System.Drawing.Size(113, 17)
        Me.rdoWithReplacement.TabIndex = 5
        Me.rdoWithReplacement.TabStop = True
        Me.rdoWithReplacement.Tag = "With_Replacement"
        Me.rdoWithReplacement.Text = "With Replacement"
        Me.rdoWithReplacement.UseVisualStyleBackColor = True
        '
        'rdoWithoutReplacement
        '
        Me.rdoWithoutReplacement.AutoSize = True
        Me.rdoWithoutReplacement.Location = New System.Drawing.Point(186, 182)
        Me.rdoWithoutReplacement.Name = "rdoWithoutReplacement"
        Me.rdoWithoutReplacement.Size = New System.Drawing.Size(128, 17)
        Me.rdoWithoutReplacement.TabIndex = 5
        Me.rdoWithoutReplacement.TabStop = True
        Me.rdoWithoutReplacement.Tag = "Without_Replacement"
        Me.rdoWithoutReplacement.Text = "Without Replacement"
        Me.rdoWithoutReplacement.UseVisualStyleBackColor = True
        '
        'lblSampleSize
        '
        Me.lblSampleSize.AutoSize = True
        Me.lblSampleSize.Location = New System.Drawing.Point(13, 214)
        Me.lblSampleSize.Name = "lblSampleSize"
        Me.lblSampleSize.Size = New System.Drawing.Size(65, 13)
        Me.lblSampleSize.TabIndex = 6
        Me.lblSampleSize.Tag = "Sample_Size"
        Me.lblSampleSize.Text = "Sample Size"
        '
        'txtSampleSize
        '
        Me.txtSampleSize.Location = New System.Drawing.Point(91, 213)
        Me.txtSampleSize.Name = "txtSampleSize"
        Me.txtSampleSize.Size = New System.Drawing.Size(78, 20)
        Me.txtSampleSize.TabIndex = 7
        '
        'lblNumberOfColumns
        '
        Me.lblNumberOfColumns.AutoSize = True
        Me.lblNumberOfColumns.Location = New System.Drawing.Point(186, 215)
        Me.lblNumberOfColumns.Name = "lblNumberOfColumns"
        Me.lblNumberOfColumns.Size = New System.Drawing.Size(101, 13)
        Me.lblNumberOfColumns.TabIndex = 6
        Me.lblNumberOfColumns.Tag = "Number_Of_Columns"
        Me.lblNumberOfColumns.Text = "Number Of Columns"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(293, 214)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 20)
        Me.TextBox1.TabIndex = 7
        '
        'dlgRandomSubsets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 308)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblNumberOfColumns)
        Me.Controls.Add(Me.txtSampleSize)
        Me.Controls.Add(Me.lblSampleSize)
        Me.Controls.Add(Me.rdoWithoutReplacement)
        Me.Controls.Add(Me.rdoWithReplacement)
        Me.Controls.Add(Me.chkSetSeed)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.UcrReceiverSingle1)
        Me.Controls.Add(Me.ucrSelectorRandomSubsets)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgRandomSubsets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Random_Subsets"
        Me.Text = "Random Subsets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorRandomSubsets As ucrSelectorByDataFrameAddRemove
    Friend WithEvents UcrReceiverSingle1 As ucrReceiverSingle
    Friend WithEvents lblSelected As Label
    Friend WithEvents chkSetSeed As CheckBox
    Friend WithEvents rdoWithReplacement As RadioButton
    Friend WithEvents rdoWithoutReplacement As RadioButton
    Friend WithEvents lblSampleSize As Label
    Friend WithEvents txtSampleSize As TextBox
    Friend WithEvents lblNumberOfColumns As Label
    Friend WithEvents TextBox1 As TextBox
End Class
