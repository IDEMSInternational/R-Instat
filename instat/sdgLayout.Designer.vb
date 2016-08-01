<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgLayout
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
        Me.tbcLayout = New System.Windows.Forms.TabControl()
        Me.tbpLayout = New System.Windows.Forms.TabPage()
        Me.ucrGridForCombine = New instat.ucrFactor()
        Me.lblNumberofColumns = New System.Windows.Forms.Label()
        Me.lblNumberofRows = New System.Windows.Forms.Label()
        Me.nudColumns = New System.Windows.Forms.NumericUpDown()
        Me.nudRows = New System.Windows.Forms.NumericUpDown()
        Me.tbpLabels = New System.Windows.Forms.TabPage()
        Me.ucrInputLeft = New instat.ucrInputTextBox()
        Me.ucrInputRight = New instat.ucrInputTextBox()
        Me.ucrInputBottom = New instat.ucrInputTextBox()
        Me.ucrInputTop = New instat.ucrInputTextBox()
        Me.lblleft = New System.Windows.Forms.Label()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.lblBottom = New System.Windows.Forms.Label()
        Me.lblTop = New System.Windows.Forms.Label()
        Me.ucrsdgLayoutBase = New instat.ucrButtonsSubdialogue()
        Me.tbcLayout.SuspendLayout()
        Me.tbpLayout.SuspendLayout()
        CType(Me.nudColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpLabels.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcLayout
        '
        Me.tbcLayout.Controls.Add(Me.tbpLayout)
        Me.tbcLayout.Controls.Add(Me.tbpLabels)
        Me.tbcLayout.Location = New System.Drawing.Point(13, 13)
        Me.tbcLayout.Name = "tbcLayout"
        Me.tbcLayout.SelectedIndex = 0
        Me.tbcLayout.Size = New System.Drawing.Size(362, 303)
        Me.tbcLayout.TabIndex = 0
        '
        'tbpLayout
        '
        Me.tbpLayout.Controls.Add(Me.ucrGridForCombine)
        Me.tbpLayout.Controls.Add(Me.lblNumberofColumns)
        Me.tbpLayout.Controls.Add(Me.lblNumberofRows)
        Me.tbpLayout.Controls.Add(Me.nudColumns)
        Me.tbpLayout.Controls.Add(Me.nudRows)
        Me.tbpLayout.Location = New System.Drawing.Point(4, 22)
        Me.tbpLayout.Name = "tbpLayout"
        Me.tbpLayout.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLayout.Size = New System.Drawing.Size(354, 277)
        Me.tbpLayout.TabIndex = 0
        Me.tbpLayout.Text = "Layout"
        Me.tbpLayout.UseVisualStyleBackColor = True
        '
        'ucrGridForCombine
        '
        Me.ucrGridForCombine.AutoSize = True
        Me.ucrGridForCombine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrGridForCombine.clsReceiver = Nothing
        Me.ucrGridForCombine.Location = New System.Drawing.Point(23, 99)
        Me.ucrGridForCombine.Name = "ucrGridForCombine"
        Me.ucrGridForCombine.shtCurrSheet = Nothing
        Me.ucrGridForCombine.Size = New System.Drawing.Size(2, 2)
        Me.ucrGridForCombine.TabIndex = 2
        '
        'lblNumberofColumns
        '
        Me.lblNumberofColumns.AutoSize = True
        Me.lblNumberofColumns.Location = New System.Drawing.Point(8, 61)
        Me.lblNumberofColumns.Name = "lblNumberofColumns"
        Me.lblNumberofColumns.Size = New System.Drawing.Size(99, 13)
        Me.lblNumberofColumns.TabIndex = 1
        Me.lblNumberofColumns.Text = "Number of Columns"
        '
        'lblNumberofRows
        '
        Me.lblNumberofRows.AutoSize = True
        Me.lblNumberofRows.Location = New System.Drawing.Point(7, 22)
        Me.lblNumberofRows.Name = "lblNumberofRows"
        Me.lblNumberofRows.Size = New System.Drawing.Size(86, 13)
        Me.lblNumberofRows.TabIndex = 1
        Me.lblNumberofRows.Text = "Number of Rows"
        '
        'nudColumns
        '
        Me.nudColumns.Location = New System.Drawing.Point(117, 59)
        Me.nudColumns.Name = "nudColumns"
        Me.nudColumns.Size = New System.Drawing.Size(95, 20)
        Me.nudColumns.TabIndex = 0
        Me.nudColumns.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'nudRows
        '
        Me.nudRows.Location = New System.Drawing.Point(117, 20)
        Me.nudRows.Name = "nudRows"
        Me.nudRows.Size = New System.Drawing.Size(95, 20)
        Me.nudRows.TabIndex = 0
        Me.nudRows.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'tbpLabels
        '
        Me.tbpLabels.Controls.Add(Me.ucrInputLeft)
        Me.tbpLabels.Controls.Add(Me.ucrInputRight)
        Me.tbpLabels.Controls.Add(Me.ucrInputBottom)
        Me.tbpLabels.Controls.Add(Me.ucrInputTop)
        Me.tbpLabels.Controls.Add(Me.lblleft)
        Me.tbpLabels.Controls.Add(Me.lblRight)
        Me.tbpLabels.Controls.Add(Me.lblBottom)
        Me.tbpLabels.Controls.Add(Me.lblTop)
        Me.tbpLabels.Location = New System.Drawing.Point(4, 22)
        Me.tbpLabels.Name = "tbpLabels"
        Me.tbpLabels.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLabels.Size = New System.Drawing.Size(354, 277)
        Me.tbpLabels.TabIndex = 3
        Me.tbpLabels.Text = "Labels"
        Me.tbpLabels.UseVisualStyleBackColor = True
        '
        'ucrInputLeft
        '
        Me.ucrInputLeft.IsReadOnly = False
        Me.ucrInputLeft.Location = New System.Drawing.Point(77, 102)
        Me.ucrInputLeft.Name = "ucrInputLeft"
        Me.ucrInputLeft.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLeft.TabIndex = 1
        '
        'ucrInputRight
        '
        Me.ucrInputRight.IsReadOnly = False
        Me.ucrInputRight.Location = New System.Drawing.Point(77, 75)
        Me.ucrInputRight.Name = "ucrInputRight"
        Me.ucrInputRight.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputRight.TabIndex = 1
        '
        'ucrInputBottom
        '
        Me.ucrInputBottom.IsReadOnly = False
        Me.ucrInputBottom.Location = New System.Drawing.Point(77, 48)
        Me.ucrInputBottom.Name = "ucrInputBottom"
        Me.ucrInputBottom.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputBottom.TabIndex = 1
        '
        'ucrInputTop
        '
        Me.ucrInputTop.IsReadOnly = False
        Me.ucrInputTop.Location = New System.Drawing.Point(77, 21)
        Me.ucrInputTop.Name = "ucrInputTop"
        Me.ucrInputTop.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTop.TabIndex = 1
        '
        'lblleft
        '
        Me.lblleft.AutoSize = True
        Me.lblleft.Location = New System.Drawing.Point(7, 111)
        Me.lblleft.Name = "lblleft"
        Me.lblleft.Size = New System.Drawing.Size(25, 13)
        Me.lblleft.TabIndex = 0
        Me.lblleft.Text = "Left"
        '
        'lblRight
        '
        Me.lblRight.AutoSize = True
        Me.lblRight.Location = New System.Drawing.Point(7, 79)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(32, 13)
        Me.lblRight.TabIndex = 0
        Me.lblRight.Text = "Right"
        '
        'lblBottom
        '
        Me.lblBottom.AutoSize = True
        Me.lblBottom.Location = New System.Drawing.Point(7, 48)
        Me.lblBottom.Name = "lblBottom"
        Me.lblBottom.Size = New System.Drawing.Size(40, 13)
        Me.lblBottom.TabIndex = 0
        Me.lblBottom.Text = "Bottom"
        '
        'lblTop
        '
        Me.lblTop.AutoSize = True
        Me.lblTop.Location = New System.Drawing.Point(7, 21)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.Size = New System.Drawing.Size(26, 13)
        Me.lblTop.TabIndex = 0
        Me.lblTop.Text = "Top"
        '
        'ucrsdgLayoutBase
        '
        Me.ucrsdgLayoutBase.Location = New System.Drawing.Point(66, 322)
        Me.ucrsdgLayoutBase.Name = "ucrsdgLayoutBase"
        Me.ucrsdgLayoutBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrsdgLayoutBase.TabIndex = 1
        '
        'sdgLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 364)
        Me.Controls.Add(Me.ucrsdgLayoutBase)
        Me.Controls.Add(Me.tbcLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgLayout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Layout"
        Me.tbcLayout.ResumeLayout(False)
        Me.tbpLayout.ResumeLayout(False)
        Me.tbpLayout.PerformLayout()
        CType(Me.nudColumns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpLabels.ResumeLayout(False)
        Me.tbpLabels.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcLayout As TabControl
    Friend WithEvents tbpLayout As TabPage
    Friend WithEvents lblNumberofColumns As Label
    Friend WithEvents lblNumberofRows As Label
    Friend WithEvents nudColumns As NumericUpDown
    Friend WithEvents nudRows As NumericUpDown
    Friend WithEvents ucrsdgLayoutBase As ucrButtonsSubdialogue
    Friend WithEvents tbpLabels As TabPage
    Friend WithEvents ucrInputLeft As ucrInputTextBox
    Friend WithEvents ucrInputRight As ucrInputTextBox
    Friend WithEvents ucrInputBottom As ucrInputTextBox
    Friend WithEvents ucrInputTop As ucrInputTextBox
    Friend WithEvents lblleft As Label
    Friend WithEvents lblRight As Label
    Friend WithEvents lblBottom As Label
    Friend WithEvents lblTop As Label
    Friend WithEvents ucrGridForCombine As ucrFactor
End Class
