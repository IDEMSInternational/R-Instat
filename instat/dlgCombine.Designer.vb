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
        Me.chkDropUnusedLevels = New System.Windows.Forms.CheckBox()
        Me.ucrInputColName = New instat.ucrInputComboBox()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'ucrSelectorCombineFactors
        '
        Me.ucrSelectorCombineFactors.bShowHiddenColumns = False
        Me.ucrSelectorCombineFactors.bUseCurrentFilter = False
        Me.ucrSelectorCombineFactors.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorCombineFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCombineFactors.Name = "ucrSelectorCombineFactors"
        Me.ucrSelectorCombineFactors.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorCombineFactors.TabIndex = 6
        '
        'ucrFactorsReceiver
        '
        Me.ucrFactorsReceiver.Location = New System.Drawing.Point(271, 60)
        Me.ucrFactorsReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorsReceiver.Name = "ucrFactorsReceiver"
        Me.ucrFactorsReceiver.Selector = Nothing
        Me.ucrFactorsReceiver.Size = New System.Drawing.Size(120, 100)
        Me.ucrFactorsReceiver.TabIndex = 5
        '
        'lblFactors
        '
        Me.lblFactors.Location = New System.Drawing.Point(270, 35)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(100, 23)
        Me.lblFactors.TabIndex = 4
        Me.lblFactors.Tag = "Factors"
        Me.lblFactors.Text = "Factors:"
        '
        'chkDropUnusedLevels
        '
        Me.chkDropUnusedLevels.Location = New System.Drawing.Point(271, 165)
        Me.chkDropUnusedLevels.Name = "chkDropUnusedLevels"
        Me.chkDropUnusedLevels.Size = New System.Drawing.Size(127, 24)
        Me.chkDropUnusedLevels.TabIndex = 3
        Me.chkDropUnusedLevels.Tag = "Drop_Unused_Levels "
        Me.chkDropUnusedLevels.Text = "Drop Unused Levels"
        Me.chkDropUnusedLevels.UseVisualStyleBackColor = True
        '
        'ucrInputColName
        '
        Me.ucrInputColName.IsReadOnly = False
        Me.ucrInputColName.Location = New System.Drawing.Point(119, 196)
        Me.ucrInputColName.Name = "ucrInputColName"
        Me.ucrInputColName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputColName.TabIndex = 2
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.Location = New System.Drawing.Point(12, 199)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(107, 23)
        Me.lblNewColumnName.TabIndex = 1
        Me.lblNewColumnName.Tag = "New_Column_Name"
        Me.lblNewColumnName.Text = "New Column Name:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 221)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgCombine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 285)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrInputColName)
        Me.Controls.Add(Me.chkDropUnusedLevels)
        Me.Controls.Add(Me.ucrFactorsReceiver)
        Me.Controls.Add(Me.ucrSelectorCombineFactors)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCombine"
        Me.Tag = "Combine_Factors"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrSelectorCombineFactors As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFactorsReceiver As ucrReceiverMultiple
    Friend WithEvents lblFactors As Label
    Friend WithEvents chkDropUnusedLevels As CheckBox
    Friend WithEvents ucrInputColName As ucrInputComboBox
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents ucrBase As ucrButtons
End Class
