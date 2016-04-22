<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgInsertColumn
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
        Me.lblDefaultValues = New System.Windows.Forms.Label()
        Me.lblNumberCols = New System.Windows.Forms.Label()
        Me.lblStartPos = New System.Windows.Forms.Label()
        Me.nudPos = New System.Windows.Forms.NumericUpDown()
        Me.nudNumCols = New System.Windows.Forms.NumericUpDown()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFramesList = New instat.ucrDataFrame()
        Me.ucrInputDefaultData = New instat.ucrInputTextBox()
        Me.rdoInsertRows = New System.Windows.Forms.RadioButton()
        Me.rdoInsertColumns = New System.Windows.Forms.RadioButton()
        Me.grpParameters = New System.Windows.Forms.GroupBox()
        Me.lblNumberOfRowsToInsert = New System.Windows.Forms.Label()
        Me.grpRowsOrColumns = New System.Windows.Forms.GroupBox()
        CType(Me.nudPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumCols, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpParameters.SuspendLayout()
        Me.grpRowsOrColumns.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDefaultValues
        '
        Me.lblDefaultValues.AutoSize = True
        Me.lblDefaultValues.Location = New System.Drawing.Point(6, 76)
        Me.lblDefaultValues.Name = "lblDefaultValues"
        Me.lblDefaultValues.Size = New System.Drawing.Size(71, 13)
        Me.lblDefaultValues.TabIndex = 2
        Me.lblDefaultValues.Text = "Default Value"
        '
        'lblNumberCols
        '
        Me.lblNumberCols.AutoSize = True
        Me.lblNumberCols.Location = New System.Drawing.Point(6, 19)
        Me.lblNumberCols.Name = "lblNumberCols"
        Me.lblNumberCols.Size = New System.Drawing.Size(140, 13)
        Me.lblNumberCols.TabIndex = 0
        Me.lblNumberCols.Text = "Number of Columns to Insert"
        '
        'lblStartPos
        '
        Me.lblStartPos.AutoSize = True
        Me.lblStartPos.Location = New System.Drawing.Point(6, 48)
        Me.lblStartPos.Name = "lblStartPos"
        Me.lblStartPos.Size = New System.Drawing.Size(85, 13)
        Me.lblStartPos.TabIndex = 4
        Me.lblStartPos.Text = "Insert at Position"
        '
        'nudPos
        '
        Me.nudPos.Location = New System.Drawing.Point(150, 43)
        Me.nudPos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPos.Name = "nudPos"
        Me.nudPos.Size = New System.Drawing.Size(36, 20)
        Me.nudPos.TabIndex = 7
        Me.nudPos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudNumCols
        '
        Me.nudNumCols.Location = New System.Drawing.Point(150, 17)
        Me.nudNumCols.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumCols.Name = "nudNumCols"
        Me.nudNumCols.Size = New System.Drawing.Size(36, 20)
        Me.nudNumCols.TabIndex = 1
        Me.nudNumCols.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 204)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 8
        '
        'ucrDataFramesList
        '
        Me.ucrDataFramesList.Location = New System.Drawing.Point(12, 8)
        Me.ucrDataFramesList.Name = "ucrDataFramesList"
        Me.ucrDataFramesList.Size = New System.Drawing.Size(127, 41)
        Me.ucrDataFramesList.TabIndex = 0
        '
        'ucrInputDefaultData
        '
        Me.ucrInputDefaultData.Location = New System.Drawing.Point(150, 69)
        Me.ucrInputDefaultData.Name = "ucrInputDefaultData"
        Me.ucrInputDefaultData.Size = New System.Drawing.Size(121, 21)
        Me.ucrInputDefaultData.TabIndex = 10
        '
        'rdoInsertRows
        '
        Me.rdoInsertRows.AutoSize = True
        Me.rdoInsertRows.Location = New System.Drawing.Point(144, 19)
        Me.rdoInsertRows.Name = "rdoInsertRows"
        Me.rdoInsertRows.Size = New System.Drawing.Size(81, 17)
        Me.rdoInsertRows.TabIndex = 11
        Me.rdoInsertRows.TabStop = True
        Me.rdoInsertRows.Text = "Insert Rows"
        Me.rdoInsertRows.UseVisualStyleBackColor = True
        '
        'rdoInsertColumns
        '
        Me.rdoInsertColumns.AutoSize = True
        Me.rdoInsertColumns.Location = New System.Drawing.Point(6, 19)
        Me.rdoInsertColumns.Name = "rdoInsertColumns"
        Me.rdoInsertColumns.Size = New System.Drawing.Size(94, 17)
        Me.rdoInsertColumns.TabIndex = 11
        Me.rdoInsertColumns.TabStop = True
        Me.rdoInsertColumns.Text = "Insert Columns"
        Me.rdoInsertColumns.UseVisualStyleBackColor = True
        '
        'grpParameters
        '
        Me.grpParameters.Controls.Add(Me.lblNumberOfRowsToInsert)
        Me.grpParameters.Controls.Add(Me.lblNumberCols)
        Me.grpParameters.Controls.Add(Me.nudNumCols)
        Me.grpParameters.Controls.Add(Me.lblStartPos)
        Me.grpParameters.Controls.Add(Me.lblDefaultValues)
        Me.grpParameters.Controls.Add(Me.ucrInputDefaultData)
        Me.grpParameters.Controls.Add(Me.nudPos)
        Me.grpParameters.Location = New System.Drawing.Point(12, 97)
        Me.grpParameters.Name = "grpParameters"
        Me.grpParameters.Size = New System.Drawing.Size(277, 101)
        Me.grpParameters.TabIndex = 12
        Me.grpParameters.TabStop = False
        '
        'lblNumberOfRowsToInsert
        '
        Me.lblNumberOfRowsToInsert.AutoSize = True
        Me.lblNumberOfRowsToInsert.Location = New System.Drawing.Point(6, 19)
        Me.lblNumberOfRowsToInsert.Name = "lblNumberOfRowsToInsert"
        Me.lblNumberOfRowsToInsert.Size = New System.Drawing.Size(127, 13)
        Me.lblNumberOfRowsToInsert.TabIndex = 14
        Me.lblNumberOfRowsToInsert.Text = "Number of Rows to Insert"
        '
        'grpRowsOrColumns
        '
        Me.grpRowsOrColumns.Controls.Add(Me.rdoInsertColumns)
        Me.grpRowsOrColumns.Controls.Add(Me.rdoInsertRows)
        Me.grpRowsOrColumns.Location = New System.Drawing.Point(12, 55)
        Me.grpRowsOrColumns.Name = "grpRowsOrColumns"
        Me.grpRowsOrColumns.Size = New System.Drawing.Size(277, 42)
        Me.grpRowsOrColumns.TabIndex = 13
        Me.grpRowsOrColumns.TabStop = False
        '
        'dlgInsertColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 265)
        Me.Controls.Add(Me.grpRowsOrColumns)
        Me.Controls.Add(Me.grpParameters)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrDataFramesList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgInsertColumn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Columns/Rows"
        CType(Me.nudPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumCols, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpParameters.ResumeLayout(False)
        Me.grpParameters.PerformLayout()
        Me.grpRowsOrColumns.ResumeLayout(False)
        Me.grpRowsOrColumns.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrDataFramesList As ucrDataFrame
    Friend WithEvents lblDefaultValues As Label
    Friend WithEvents lblNumberCols As Label
    Friend WithEvents lblStartPos As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents nudPos As NumericUpDown
    Friend WithEvents nudNumCols As NumericUpDown
    Friend WithEvents ucrInputDefaultData As ucrInputTextBox
    Friend WithEvents rdoInsertRows As RadioButton
    Friend WithEvents rdoInsertColumns As RadioButton
    Friend WithEvents grpParameters As GroupBox
    Friend WithEvents grpRowsOrColumns As GroupBox
    Friend WithEvents lblNumberOfRowsToInsert As Label
End Class
