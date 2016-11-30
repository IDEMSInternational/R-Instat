<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDisplaySpellLength
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
        Me.chkMonthAbbreviations = New System.Windows.Forms.CheckBox()
        Me.chkRemoveNA = New System.Windows.Forms.CheckBox()
        Me.lblColunmName = New System.Windows.Forms.Label()
        Me.lblDayDisplay = New System.Windows.Forms.Label()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.nudThreshold = New System.Windows.Forms.NumericUpDown()
        Me.ucrInputColumnName = New instat.ucrInputTextBox()
        Me.ucrInputDisplayDay = New instat.ucrInputTextBox()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 115)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 60)
        Me.ucrBase.TabIndex = 0
        '
        'chkMonthAbbreviations
        '
        Me.chkMonthAbbreviations.AutoSize = True
        Me.chkMonthAbbreviations.Location = New System.Drawing.Point(12, 92)
        Me.chkMonthAbbreviations.Name = "chkMonthAbbreviations"
        Me.chkMonthAbbreviations.Size = New System.Drawing.Size(123, 17)
        Me.chkMonthAbbreviations.TabIndex = 1
        Me.chkMonthAbbreviations.Tag = "Month_Abbreviations"
        Me.chkMonthAbbreviations.Text = "Month Abbreviations"
        Me.chkMonthAbbreviations.UseVisualStyleBackColor = True
        '
        'chkRemoveNA
        '
        Me.chkRemoveNA.AutoSize = True
        Me.chkRemoveNA.Location = New System.Drawing.Point(141, 92)
        Me.chkRemoveNA.Name = "chkRemoveNA"
        Me.chkRemoveNA.Size = New System.Drawing.Size(139, 17)
        Me.chkRemoveNA.TabIndex = 2
        Me.chkRemoveNA.Tag = "Remove_Missing_Values"
        Me.chkRemoveNA.Text = "Remove Missing Values"
        Me.chkRemoveNA.UseVisualStyleBackColor = True
        '
        'lblColunmName
        '
        Me.lblColunmName.AutoSize = True
        Me.lblColunmName.Location = New System.Drawing.Point(9, 20)
        Me.lblColunmName.Name = "lblColunmName"
        Me.lblColunmName.Size = New System.Drawing.Size(73, 13)
        Me.lblColunmName.TabIndex = 6
        Me.lblColunmName.Tag = "Colunm_Name"
        Me.lblColunmName.Text = "Column Name"
        '
        'lblDayDisplay
        '
        Me.lblDayDisplay.AutoSize = True
        Me.lblDayDisplay.Location = New System.Drawing.Point(9, 47)
        Me.lblDayDisplay.Name = "lblDayDisplay"
        Me.lblDayDisplay.Size = New System.Drawing.Size(63, 13)
        Me.lblDayDisplay.TabIndex = 7
        Me.lblDayDisplay.Tag = "Day_Display"
        Me.lblDayDisplay.Text = "Display Day"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(9, 73)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(54, 13)
        Me.lblThreshold.TabIndex = 8
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Threshold"
        '
        'nudThreshold
        '
        Me.nudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudThreshold.Location = New System.Drawing.Point(89, 66)
        Me.nudThreshold.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(56, 20)
        Me.nudThreshold.TabIndex = 9
        '
        'ucrInputColumnName
        '
        Me.ucrInputColumnName.Location = New System.Drawing.Point(89, 12)
        Me.ucrInputColumnName.Name = "ucrInputColumnName"
        Me.ucrInputColumnName.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputColumnName.TabIndex = 10
        '
        'ucrInputDisplayDay
        '
        Me.ucrInputDisplayDay.Location = New System.Drawing.Point(89, 39)
        Me.ucrInputDisplayDay.Name = "ucrInputDisplayDay"
        Me.ucrInputDisplayDay.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputDisplayDay.TabIndex = 11
        '
        'dlgDisplaySpellLength
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 179)
        Me.Controls.Add(Me.ucrInputDisplayDay)
        Me.Controls.Add(Me.ucrInputColumnName)
        Me.Controls.Add(Me.nudThreshold)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.lblDayDisplay)
        Me.Controls.Add(Me.lblColunmName)
        Me.Controls.Add(Me.chkRemoveNA)
        Me.Controls.Add(Me.chkMonthAbbreviations)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplaySpellLength"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Display_Spell_Length"
        Me.Text = "Display Spell Length"
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkMonthAbbreviations As CheckBox
    Friend WithEvents chkRemoveNA As CheckBox
    Friend WithEvents lblColunmName As Label
    Friend WithEvents lblDayDisplay As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents nudThreshold As NumericUpDown
    Friend WithEvents ucrInputColumnName As ucrInputTextBox
    Friend WithEvents ucrInputDisplayDay As ucrInputTextBox
End Class
