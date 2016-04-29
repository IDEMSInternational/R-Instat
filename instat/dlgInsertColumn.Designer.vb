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
        Me.lblNumberOfRowsToInsert = New System.Windows.Forms.Label()
        CType(Me.nudPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumCols, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDefaultValues
        '
        Me.lblDefaultValues.AutoSize = True
        Me.lblDefaultValues.Location = New System.Drawing.Point(9, 137)
        Me.lblDefaultValues.Name = "lblDefaultValues"
        Me.lblDefaultValues.Size = New System.Drawing.Size(71, 13)
        Me.lblDefaultValues.TabIndex = 2
        Me.lblDefaultValues.Text = "Default Value"
        '
        'lblNumberCols
        '
        Me.lblNumberCols.AutoSize = True
        Me.lblNumberCols.Location = New System.Drawing.Point(9, 83)
        Me.lblNumberCols.Name = "lblNumberCols"
        Me.lblNumberCols.Size = New System.Drawing.Size(140, 13)
        Me.lblNumberCols.TabIndex = 0
        Me.lblNumberCols.Text = "Number of Columns to Insert"
        '
        'lblStartPos
        '
        Me.lblStartPos.AutoSize = True
        Me.lblStartPos.Location = New System.Drawing.Point(9, 109)
        Me.lblStartPos.Name = "lblStartPos"
        Me.lblStartPos.Size = New System.Drawing.Size(85, 13)
        Me.lblStartPos.TabIndex = 4
        Me.lblStartPos.Text = "Insert at Position"
        '
        'nudPos
        '
        Me.nudPos.Location = New System.Drawing.Point(157, 104)
        Me.nudPos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPos.Name = "nudPos"
        Me.nudPos.Size = New System.Drawing.Size(36, 20)
        Me.nudPos.TabIndex = 7
        Me.nudPos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudNumCols
        '
        Me.nudNumCols.Location = New System.Drawing.Point(157, 78)
        Me.nudNumCols.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumCols.Name = "nudNumCols"
        Me.nudNumCols.Size = New System.Drawing.Size(36, 20)
        Me.nudNumCols.TabIndex = 1
        Me.nudNumCols.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 157)
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
        Me.ucrInputDefaultData.Location = New System.Drawing.Point(157, 130)
        Me.ucrInputDefaultData.Name = "ucrInputDefaultData"
        Me.ucrInputDefaultData.Size = New System.Drawing.Size(121, 21)
        Me.ucrInputDefaultData.TabIndex = 10
        '
        'rdoInsertRows
        '
        Me.rdoInsertRows.AutoSize = True
        Me.rdoInsertRows.Location = New System.Drawing.Point(112, 55)
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
        Me.rdoInsertColumns.Location = New System.Drawing.Point(12, 55)
        Me.rdoInsertColumns.Name = "rdoInsertColumns"
        Me.rdoInsertColumns.Size = New System.Drawing.Size(94, 17)
        Me.rdoInsertColumns.TabIndex = 11
        Me.rdoInsertColumns.TabStop = True
        Me.rdoInsertColumns.Text = "Insert Columns"
        Me.rdoInsertColumns.UseVisualStyleBackColor = True
        '
        'lblNumberOfRowsToInsert
        '
        Me.lblNumberOfRowsToInsert.AutoSize = True
        Me.lblNumberOfRowsToInsert.Location = New System.Drawing.Point(9, 82)
        Me.lblNumberOfRowsToInsert.Name = "lblNumberOfRowsToInsert"
        Me.lblNumberOfRowsToInsert.Size = New System.Drawing.Size(127, 13)
        Me.lblNumberOfRowsToInsert.TabIndex = 14
        Me.lblNumberOfRowsToInsert.Text = "Number of Rows to Insert"
        '
        'dlgInsertColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 218)
        Me.Controls.Add(Me.ucrInputDefaultData)
        Me.Controls.Add(Me.lblDefaultValues)
        Me.Controls.Add(Me.lblStartPos)
        Me.Controls.Add(Me.nudNumCols)
        Me.Controls.Add(Me.nudPos)
        Me.Controls.Add(Me.lblNumberCols)
        Me.Controls.Add(Me.lblNumberOfRowsToInsert)
        Me.Controls.Add(Me.rdoInsertColumns)
        Me.Controls.Add(Me.rdoInsertRows)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrDataFramesList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgInsertColumn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Columns/Rows"
        CType(Me.nudPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumCols, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents lblNumberOfRowsToInsert As Label
End Class
