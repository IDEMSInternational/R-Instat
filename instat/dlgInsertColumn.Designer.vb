<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgInsertColumn
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
        Me.txtDefaultData = New System.Windows.Forms.TextBox()
        Me.lblDefaultValues = New System.Windows.Forms.Label()
        Me.lblNumberCols = New System.Windows.Forms.Label()
        Me.nudPos = New System.Windows.Forms.NumericUpDown()
        Me.nudNumCols = New System.Windows.Forms.NumericUpDown()
        Me.rdoColumns = New System.Windows.Forms.RadioButton()
        Me.rdoRows = New System.Windows.Forms.RadioButton()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.lblRows = New System.Windows.Forms.Label()
        Me.grpPosition = New System.Windows.Forms.GroupBox()
        Me.rdoPosition = New System.Windows.Forms.RadioButton()
        Me.rdoEnd = New System.Windows.Forms.RadioButton()
        Me.rdoStart = New System.Windows.Forms.RadioButton()
        Me.ucrInputColumns = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFramesList = New instat.ucrDataFrame()
        Me.ucrDataFrameLength = New instat.ucrDataFrameLength()
        CType(Me.nudPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumCols, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPosition.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDefaultData
        '
        Me.txtDefaultData.Location = New System.Drawing.Point(112, 214)
        Me.txtDefaultData.Name = "txtDefaultData"
        Me.txtDefaultData.ReadOnly = True
        Me.txtDefaultData.Size = New System.Drawing.Size(100, 20)
        Me.txtDefaultData.TabIndex = 3
        '
        'lblDefaultValues
        '
        Me.lblDefaultValues.AutoSize = True
        Me.lblDefaultValues.Location = New System.Drawing.Point(12, 217)
        Me.lblDefaultValues.Name = "lblDefaultValues"
        Me.lblDefaultValues.Size = New System.Drawing.Size(75, 13)
        Me.lblDefaultValues.TabIndex = 2
        Me.lblDefaultValues.Text = "Default values"
        '
        'lblNumberCols
        '
        Me.lblNumberCols.AutoSize = True
        Me.lblNumberCols.Location = New System.Drawing.Point(9, 111)
        Me.lblNumberCols.Name = "lblNumberCols"
        Me.lblNumberCols.Size = New System.Drawing.Size(138, 13)
        Me.lblNumberCols.TabIndex = 0
        Me.lblNumberCols.Text = "Number of columns to insert"
        '
        'nudPos
        '
        Me.nudPos.Location = New System.Drawing.Point(244, 20)
        Me.nudPos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPos.Name = "nudPos"
        Me.nudPos.Size = New System.Drawing.Size(36, 20)
        Me.nudPos.TabIndex = 7
        Me.nudPos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudNumCols
        '
        Me.nudNumCols.Location = New System.Drawing.Point(160, 111)
        Me.nudNumCols.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumCols.Name = "nudNumCols"
        Me.nudNumCols.Size = New System.Drawing.Size(52, 20)
        Me.nudNumCols.TabIndex = 1
        Me.nudNumCols.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rdoColumns
        '
        Me.rdoColumns.AutoSize = True
        Me.rdoColumns.Location = New System.Drawing.Point(22, 13)
        Me.rdoColumns.Name = "rdoColumns"
        Me.rdoColumns.Size = New System.Drawing.Size(65, 17)
        Me.rdoColumns.TabIndex = 9
        Me.rdoColumns.TabStop = True
        Me.rdoColumns.Text = "Columns"
        Me.rdoColumns.UseVisualStyleBackColor = True
        '
        'rdoRows
        '
        Me.rdoRows.AutoSize = True
        Me.rdoRows.Location = New System.Drawing.Point(160, 13)
        Me.rdoRows.Name = "rdoRows"
        Me.rdoRows.Size = New System.Drawing.Size(52, 17)
        Me.rdoRows.TabIndex = 9
        Me.rdoRows.TabStop = True
        Me.rdoRows.Text = "Rows"
        Me.rdoRows.UseVisualStyleBackColor = True
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.Location = New System.Drawing.Point(178, 58)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(47, 13)
        Me.lblColumns.TabIndex = 10
        Me.lblColumns.Text = "Columns"
        '
        'lblRows
        '
        Me.lblRows.AutoSize = True
        Me.lblRows.Location = New System.Drawing.Point(281, 58)
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Size = New System.Drawing.Size(34, 13)
        Me.lblRows.TabIndex = 11
        Me.lblRows.Text = "Rows"
        '
        'grpPosition
        '
        Me.grpPosition.Controls.Add(Me.rdoPosition)
        Me.grpPosition.Controls.Add(Me.rdoEnd)
        Me.grpPosition.Controls.Add(Me.rdoStart)
        Me.grpPosition.Controls.Add(Me.nudPos)
        Me.grpPosition.Location = New System.Drawing.Point(15, 148)
        Me.grpPosition.Name = "grpPosition"
        Me.grpPosition.Size = New System.Drawing.Size(344, 53)
        Me.grpPosition.TabIndex = 14
        Me.grpPosition.TabStop = False
        Me.grpPosition.Text = "At Position"
        '
        'rdoPosition
        '
        Me.rdoPosition.AutoSize = True
        Me.rdoPosition.Location = New System.Drawing.Point(156, 20)
        Me.rdoPosition.Name = "rdoPosition"
        Me.rdoPosition.Size = New System.Drawing.Size(62, 17)
        Me.rdoPosition.TabIndex = 2
        Me.rdoPosition.TabStop = True
        Me.rdoPosition.Text = "Position"
        Me.rdoPosition.UseVisualStyleBackColor = True
        '
        'rdoEnd
        '
        Me.rdoEnd.AutoSize = True
        Me.rdoEnd.Location = New System.Drawing.Point(80, 19)
        Me.rdoEnd.Name = "rdoEnd"
        Me.rdoEnd.Size = New System.Drawing.Size(44, 17)
        Me.rdoEnd.TabIndex = 1
        Me.rdoEnd.TabStop = True
        Me.rdoEnd.Text = "End"
        Me.rdoEnd.UseVisualStyleBackColor = True
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
        'ucrInputColumns
        '
        Me.ucrInputColumns.Location = New System.Drawing.Point(178, 75)
        Me.ucrInputColumns.Name = "ucrInputColumns"
        Me.ucrInputColumns.Size = New System.Drawing.Size(75, 21)
        Me.ucrInputColumns.TabIndex = 12
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 243)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 8
        '
        'ucrDataFramesList
        '
        Me.ucrDataFramesList.Location = New System.Drawing.Point(6, 58)
        Me.ucrDataFramesList.Name = "ucrDataFramesList"
        Me.ucrDataFramesList.Size = New System.Drawing.Size(127, 41)
        Me.ucrDataFramesList.TabIndex = 0
        '
        'ucrDataFrameLength
        '
        Me.ucrDataFrameLength.clsDataFrameSelector = Nothing
        Me.ucrDataFrameLength.Location = New System.Drawing.Point(284, 75)
        Me.ucrDataFrameLength.Name = "ucrDataFrameLength"
        Me.ucrDataFrameLength.Size = New System.Drawing.Size(53, 23)
        Me.ucrDataFrameLength.TabIndex = 15
        '
        'dlgInsertColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 299)
        Me.Controls.Add(Me.ucrDataFrameLength)
        Me.Controls.Add(Me.grpPosition)
        Me.Controls.Add(Me.ucrInputColumns)
        Me.Controls.Add(Me.lblRows)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.rdoRows)
        Me.Controls.Add(Me.rdoColumns)
        Me.Controls.Add(Me.nudNumCols)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblNumberCols)
        Me.Controls.Add(Me.lblDefaultValues)
        Me.Controls.Add(Me.txtDefaultData)
        Me.Controls.Add(Me.ucrDataFramesList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgInsertColumn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Columns or Rows"
        CType(Me.nudPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumCols, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPosition.ResumeLayout(False)
        Me.grpPosition.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrDataFramesList As ucrDataFrame
    Friend WithEvents txtDefaultData As TextBox
    Friend WithEvents lblDefaultValues As Label
    Friend WithEvents lblNumberCols As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents nudPos As NumericUpDown
    Friend WithEvents nudNumCols As NumericUpDown
    Friend WithEvents rdoColumns As RadioButton
    Friend WithEvents rdoRows As RadioButton
    Friend WithEvents lblColumns As Label
    Friend WithEvents lblRows As Label
    Friend WithEvents ucrInputColumns As ucrInputTextBox
    Friend WithEvents grpPosition As GroupBox
    Friend WithEvents rdoPosition As RadioButton
    Friend WithEvents rdoEnd As RadioButton
    Friend WithEvents rdoStart As RadioButton
    Friend WithEvents ucrDataFrameLength As ucrDataFrameLength
End Class
