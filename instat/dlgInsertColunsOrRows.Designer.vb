<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgInsertColunsOrRows
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
        Me.rdoColumns = New System.Windows.Forms.RadioButton()
        Me.ucrBase = New instat.ucrButtons()
        Me.rdoRows = New System.Windows.Forms.RadioButton()
        Me.ucrDataframeSelector = New instat.ucrDataFrame()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.txtColumns = New System.Windows.Forms.TextBox()
        Me.txtRows = New System.Windows.Forms.TextBox()
        Me.lblRows = New System.Windows.Forms.Label()
        Me.nudNumbertoInsert = New System.Windows.Forms.NumericUpDown()
        Me.lblNumbertoInsert = New System.Windows.Forms.Label()
        Me.grpPosition = New System.Windows.Forms.GroupBox()
        Me.rdoStart = New System.Windows.Forms.RadioButton()
        Me.rdoEnd = New System.Windows.Forms.RadioButton()
        Me.rdoPosition = New System.Windows.Forms.RadioButton()
        Me.nudPosition = New System.Windows.Forms.NumericUpDown()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        CType(Me.nudNumbertoInsert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPosition.SuspendLayout()
        CType(Me.nudPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdoColumns
        '
        Me.rdoColumns.AutoSize = True
        Me.rdoColumns.Location = New System.Drawing.Point(12, 12)
        Me.rdoColumns.Name = "rdoColumns"
        Me.rdoColumns.Size = New System.Drawing.Size(65, 17)
        Me.rdoColumns.TabIndex = 0
        Me.rdoColumns.TabStop = True
        Me.rdoColumns.Tag = "Columns"
        Me.rdoColumns.Text = "Columns"
        Me.rdoColumns.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(3, 232)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 1
        '
        'rdoRows
        '
        Me.rdoRows.AutoSize = True
        Me.rdoRows.Location = New System.Drawing.Point(174, 12)
        Me.rdoRows.Name = "rdoRows"
        Me.rdoRows.Size = New System.Drawing.Size(52, 17)
        Me.rdoRows.TabIndex = 2
        Me.rdoRows.TabStop = True
        Me.rdoRows.Tag = "Rows"
        Me.rdoRows.Text = "Rows"
        Me.rdoRows.UseVisualStyleBackColor = True
        '
        'ucrDataframeSelector
        '
        Me.ucrDataframeSelector.Location = New System.Drawing.Point(12, 53)
        Me.ucrDataframeSelector.Name = "ucrDataframeSelector"
        Me.ucrDataframeSelector.Size = New System.Drawing.Size(127, 41)
        Me.ucrDataframeSelector.TabIndex = 3
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.Location = New System.Drawing.Point(188, 53)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(47, 13)
        Me.lblColumns.TabIndex = 4
        Me.lblColumns.Text = "Columns"
        '
        'txtColumns
        '
        Me.txtColumns.Location = New System.Drawing.Point(191, 73)
        Me.txtColumns.Name = "txtColumns"
        Me.txtColumns.Size = New System.Drawing.Size(50, 20)
        Me.txtColumns.TabIndex = 5
        '
        'txtRows
        '
        Me.txtRows.Location = New System.Drawing.Point(293, 73)
        Me.txtRows.Name = "txtRows"
        Me.txtRows.Size = New System.Drawing.Size(50, 20)
        Me.txtRows.TabIndex = 7
        '
        'lblRows
        '
        Me.lblRows.AutoSize = True
        Me.lblRows.Location = New System.Drawing.Point(290, 53)
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Size = New System.Drawing.Size(34, 13)
        Me.lblRows.TabIndex = 6
        Me.lblRows.Text = "Rows"
        '
        'nudNumbertoInsert
        '
        Me.nudNumbertoInsert.Location = New System.Drawing.Point(104, 110)
        Me.nudNumbertoInsert.Name = "nudNumbertoInsert"
        Me.nudNumbertoInsert.Size = New System.Drawing.Size(37, 20)
        Me.nudNumbertoInsert.TabIndex = 8
        '
        'lblNumbertoInsert
        '
        Me.lblNumbertoInsert.AutoSize = True
        Me.lblNumbertoInsert.Location = New System.Drawing.Point(13, 112)
        Me.lblNumbertoInsert.Name = "lblNumbertoInsert"
        Me.lblNumbertoInsert.Size = New System.Drawing.Size(85, 13)
        Me.lblNumbertoInsert.TabIndex = 9
        Me.lblNumbertoInsert.Text = "Number to Insert"
        '
        'grpPosition
        '
        Me.grpPosition.Controls.Add(Me.nudPosition)
        Me.grpPosition.Controls.Add(Me.rdoPosition)
        Me.grpPosition.Controls.Add(Me.rdoEnd)
        Me.grpPosition.Controls.Add(Me.rdoStart)
        Me.grpPosition.Location = New System.Drawing.Point(16, 141)
        Me.grpPosition.Name = "grpPosition"
        Me.grpPosition.Size = New System.Drawing.Size(383, 53)
        Me.grpPosition.TabIndex = 10
        Me.grpPosition.TabStop = False
        Me.grpPosition.Text = "At Position"
        '
        'rdoStart
        '
        Me.rdoStart.AutoSize = True
        Me.rdoStart.Location = New System.Drawing.Point(7, 20)
        Me.rdoStart.Name = "rdoStart"
        Me.rdoStart.Size = New System.Drawing.Size(47, 17)
        Me.rdoStart.TabIndex = 0
        Me.rdoStart.TabStop = True
        Me.rdoStart.Text = "Start"
        Me.rdoStart.UseVisualStyleBackColor = True
        '
        'rdoEnd
        '
        Me.rdoEnd.AutoSize = True
        Me.rdoEnd.Location = New System.Drawing.Point(88, 20)
        Me.rdoEnd.Name = "rdoEnd"
        Me.rdoEnd.Size = New System.Drawing.Size(44, 17)
        Me.rdoEnd.TabIndex = 0
        Me.rdoEnd.TabStop = True
        Me.rdoEnd.Text = "End"
        Me.rdoEnd.UseVisualStyleBackColor = True
        '
        'rdoPosition
        '
        Me.rdoPosition.AutoSize = True
        Me.rdoPosition.Location = New System.Drawing.Point(175, 20)
        Me.rdoPosition.Name = "rdoPosition"
        Me.rdoPosition.Size = New System.Drawing.Size(62, 17)
        Me.rdoPosition.TabIndex = 1
        Me.rdoPosition.TabStop = True
        Me.rdoPosition.Text = "Position"
        Me.rdoPosition.UseVisualStyleBackColor = True
        '
        'nudPosition
        '
        Me.nudPosition.Location = New System.Drawing.Point(252, 20)
        Me.nudPosition.Name = "nudPosition"
        Me.nudPosition.Size = New System.Drawing.Size(37, 20)
        Me.nudPosition.TabIndex = 9
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(16, 204)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(34, 13)
        Me.lblValue.TabIndex = 11
        Me.lblValue.Text = "Value"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(80, 202)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(68, 20)
        Me.txtValue.TabIndex = 12
        '
        'dlgInsertColunsOrRows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 289)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.grpPosition)
        Me.Controls.Add(Me.lblNumbertoInsert)
        Me.Controls.Add(Me.nudNumbertoInsert)
        Me.Controls.Add(Me.txtRows)
        Me.Controls.Add(Me.lblRows)
        Me.Controls.Add(Me.txtColumns)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrDataframeSelector)
        Me.Controls.Add(Me.rdoRows)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.rdoColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgInsertColunsOrRows"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Coluns Or Rows"
        CType(Me.nudNumbertoInsert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPosition.ResumeLayout(False)
        Me.grpPosition.PerformLayout()
        CType(Me.nudPosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdoColumns As RadioButton
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoRows As RadioButton
    Friend WithEvents ucrDataframeSelector As ucrDataFrame
    Friend WithEvents lblColumns As Label
    Friend WithEvents txtColumns As TextBox
    Friend WithEvents txtRows As TextBox
    Friend WithEvents lblRows As Label
    Friend WithEvents nudNumbertoInsert As NumericUpDown
    Friend WithEvents lblNumbertoInsert As Label
    Friend WithEvents grpPosition As GroupBox
    Friend WithEvents nudPosition As NumericUpDown
    Friend WithEvents rdoPosition As RadioButton
    Friend WithEvents rdoEnd As RadioButton
    Friend WithEvents rdoStart As RadioButton
    Friend WithEvents lblValue As Label
    Friend WithEvents txtValue As TextBox
End Class
