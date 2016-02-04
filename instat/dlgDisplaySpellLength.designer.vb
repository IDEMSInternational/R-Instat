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
        Me.txtDayDisplay = New System.Windows.Forms.TextBox()
        Me.txtColunmName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblColunmName = New System.Windows.Forms.Label()
        Me.lblDayDisplay = New System.Windows.Forms.Label()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.nudThreshold = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 227)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'chkMonthAbbreviations
        '
        Me.chkMonthAbbreviations.AutoSize = True
        Me.chkMonthAbbreviations.Location = New System.Drawing.Point(132, 174)
        Me.chkMonthAbbreviations.Name = "chkMonthAbbreviations"
        Me.chkMonthAbbreviations.Size = New System.Drawing.Size(81, 17)
        Me.chkMonthAbbreviations.TabIndex = 1
        Me.chkMonthAbbreviations.Tag = "Month_Abbreviations"
        Me.chkMonthAbbreviations.Text = "CheckBox1"
        Me.chkMonthAbbreviations.UseVisualStyleBackColor = True
        '
        'chkRemoveNA
        '
        Me.chkRemoveNA.AutoSize = True
        Me.chkRemoveNA.Location = New System.Drawing.Point(309, 174)
        Me.chkRemoveNA.Name = "chkRemoveNA"
        Me.chkRemoveNA.Size = New System.Drawing.Size(81, 17)
        Me.chkRemoveNA.TabIndex = 2
        Me.chkRemoveNA.Tag = "Remove_NA"
        Me.chkRemoveNA.Text = "CheckBox2"
        Me.chkRemoveNA.UseVisualStyleBackColor = True
        '
        'txtDayDisplay
        '
        Me.txtDayDisplay.Location = New System.Drawing.Point(132, 76)
        Me.txtDayDisplay.Name = "txtDayDisplay"
        Me.txtDayDisplay.Size = New System.Drawing.Size(100, 20)
        Me.txtDayDisplay.TabIndex = 3
        Me.txtDayDisplay.Tag = ""
        '
        'txtColunmName
        '
        Me.txtColunmName.Location = New System.Drawing.Point(132, 37)
        Me.txtColunmName.Name = "txtColunmName"
        Me.txtColunmName.Size = New System.Drawing.Size(100, 20)
        Me.txtColunmName.TabIndex = 4
        Me.txtColunmName.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'lblColunmName
        '
        Me.lblColunmName.AutoSize = True
        Me.lblColunmName.Location = New System.Drawing.Point(50, 40)
        Me.lblColunmName.Name = "lblColunmName"
        Me.lblColunmName.Size = New System.Drawing.Size(39, 13)
        Me.lblColunmName.TabIndex = 6
        Me.lblColunmName.Tag = "Colunm_Name"
        Me.lblColunmName.Text = "Label2"
        '
        'lblDayDisplay
        '
        Me.lblDayDisplay.AutoSize = True
        Me.lblDayDisplay.Location = New System.Drawing.Point(50, 76)
        Me.lblDayDisplay.Name = "lblDayDisplay"
        Me.lblDayDisplay.Size = New System.Drawing.Size(39, 13)
        Me.lblDayDisplay.TabIndex = 7
        Me.lblDayDisplay.Tag = "Day_Display"
        Me.lblDayDisplay.Text = "Label3"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(48, 124)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(39, 13)
        Me.lblThreshold.TabIndex = 8
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Label4"
        '
        'nudThreshold
        '
        Me.nudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudThreshold.Location = New System.Drawing.Point(132, 122)
        Me.nudThreshold.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(56, 20)
        Me.nudThreshold.TabIndex = 9
        '
        'dlgDisplaySpellLength
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 260)
        Me.Controls.Add(Me.nudThreshold)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.lblDayDisplay)
        Me.Controls.Add(Me.lblColunmName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtColunmName)
        Me.Controls.Add(Me.txtDayDisplay)
        Me.Controls.Add(Me.chkRemoveNA)
        Me.Controls.Add(Me.chkMonthAbbreviations)
        Me.Controls.Add(Me.ucrBase)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplaySpellLength"
        Me.Tag = "Display_Spell_Length"
        Me.Text = "Display Spell Length"
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkMonthAbbreviations As CheckBox
    Friend WithEvents chkRemoveNA As CheckBox
    Friend WithEvents txtDayDisplay As TextBox
    Friend WithEvents txtColunmName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblColunmName As Label
    Friend WithEvents lblDayDisplay As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents nudThreshold As NumericUpDown
End Class
