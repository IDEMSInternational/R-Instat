<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgMerge
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
        Me.lblFirstDataFrame = New System.Windows.Forms.Label()
        Me.lblSecondDataFrame = New System.Windows.Forms.Label()
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.grpMergeOptions = New System.Windows.Forms.GroupBox()
        Me.rdoRightJoin = New System.Windows.Forms.RadioButton()
        Me.rdoFullJoin = New System.Windows.Forms.RadioButton()
        Me.rdoLeftJoin = New System.Windows.Forms.RadioButton()
        Me.rdoInnerJoin = New System.Windows.Forms.RadioButton()
        Me.ucrNewDataFrameName = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSecondDataFrame = New instat.ucrDataFrame()
        Me.ucrFirstDataFrame = New instat.ucrDataFrame()
        Me.cmdChooseMergeColumns = New System.Windows.Forms.Button()
        Me.ucrInputMergeColumnsOptions = New instat.ucrInputComboBox()
        Me.lblIdColumnOption = New System.Windows.Forms.Label()
        Me.grpMergeOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstDataFrame
        '
        Me.lblFirstDataFrame.AutoSize = True
        Me.lblFirstDataFrame.Location = New System.Drawing.Point(10, 10)
        Me.lblFirstDataFrame.Name = "lblFirstDataFrame"
        Me.lblFirstDataFrame.Size = New System.Drawing.Size(133, 13)
        Me.lblFirstDataFrame.TabIndex = 3
        Me.lblFirstDataFrame.Text = "First Data Frame To Merge"
        '
        'lblSecondDataFrame
        '
        Me.lblSecondDataFrame.AutoSize = True
        Me.lblSecondDataFrame.Location = New System.Drawing.Point(227, 10)
        Me.lblSecondDataFrame.Name = "lblSecondDataFrame"
        Me.lblSecondDataFrame.Size = New System.Drawing.Size(151, 13)
        Me.lblSecondDataFrame.TabIndex = 4
        Me.lblSecondDataFrame.Text = "Second Data Frame To Merge"
        '
        'lblNewDataFrameName
        '
        Me.lblNewDataFrameName.AutoSize = True
        Me.lblNewDataFrameName.Location = New System.Drawing.Point(6, 319)
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        Me.lblNewDataFrameName.Size = New System.Drawing.Size(121, 13)
        Me.lblNewDataFrameName.TabIndex = 9
        Me.lblNewDataFrameName.Text = "New Data Frame Name:"
        '
        'grpMergeOptions
        '
        Me.grpMergeOptions.Controls.Add(Me.rdoRightJoin)
        Me.grpMergeOptions.Controls.Add(Me.rdoFullJoin)
        Me.grpMergeOptions.Controls.Add(Me.rdoLeftJoin)
        Me.grpMergeOptions.Controls.Add(Me.rdoInnerJoin)
        Me.grpMergeOptions.Location = New System.Drawing.Point(10, 144)
        Me.grpMergeOptions.Name = "grpMergeOptions"
        Me.grpMergeOptions.Size = New System.Drawing.Size(422, 158)
        Me.grpMergeOptions.TabIndex = 11
        Me.grpMergeOptions.TabStop = False
        Me.grpMergeOptions.Text = "Merge Options"
        '
        'rdoRightJoin
        '
        Me.rdoRightJoin.Location = New System.Drawing.Point(6, 109)
        Me.rdoRightJoin.Name = "rdoRightJoin"
        Me.rdoRightJoin.Size = New System.Drawing.Size(403, 39)
        Me.rdoRightJoin.TabIndex = 15
        Me.rdoRightJoin.TabStop = True
        Me.rdoRightJoin.Text = "Include all observations in the second data frame and matching observations from " &
    "the first data frame (Right Join)"
        Me.rdoRightJoin.UseVisualStyleBackColor = True
        '
        'rdoFullJoin
        '
        Me.rdoFullJoin.AutoSize = True
        Me.rdoFullJoin.Location = New System.Drawing.Point(6, 58)
        Me.rdoFullJoin.Name = "rdoFullJoin"
        Me.rdoFullJoin.Size = New System.Drawing.Size(276, 17)
        Me.rdoFullJoin.TabIndex = 14
        Me.rdoFullJoin.TabStop = True
        Me.rdoFullJoin.Text = "Include all observations in both data frames (Full Join)"
        Me.rdoFullJoin.UseVisualStyleBackColor = True
        '
        'rdoLeftJoin
        '
        Me.rdoLeftJoin.Location = New System.Drawing.Point(6, 19)
        Me.rdoLeftJoin.Name = "rdoLeftJoin"
        Me.rdoLeftJoin.Size = New System.Drawing.Size(410, 39)
        Me.rdoLeftJoin.TabIndex = 13
        Me.rdoLeftJoin.TabStop = True
        Me.rdoLeftJoin.Text = "Include all observations in the first data frame and matching observations from t" &
    "he second data frame (Left Join)"
        Me.rdoLeftJoin.UseVisualStyleBackColor = True
        '
        'rdoInnerJoin
        '
        Me.rdoInnerJoin.AutoSize = True
        Me.rdoInnerJoin.Location = New System.Drawing.Point(6, 84)
        Me.rdoInnerJoin.Name = "rdoInnerJoin"
        Me.rdoInnerJoin.Size = New System.Drawing.Size(347, 17)
        Me.rdoInnerJoin.TabIndex = 12
        Me.rdoInnerJoin.TabStop = True
        Me.rdoInnerJoin.Text = "Only include observations that match in both data frames (Inner Join)"
        Me.rdoInnerJoin.UseVisualStyleBackColor = True
        '
        'ucrNewDataFrameName
        '
        Me.ucrNewDataFrameName.IsReadOnly = False
        Me.ucrNewDataFrameName.Location = New System.Drawing.Point(130, 316)
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        Me.ucrNewDataFrameName.Size = New System.Drawing.Size(277, 21)
        Me.ucrNewDataFrameName.TabIndex = 10
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(8, 351)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSecondDataFrame
        '
        Me.ucrSecondDataFrame.bUseCurrentFilter = True
        Me.ucrSecondDataFrame.Location = New System.Drawing.Point(230, 34)
        Me.ucrSecondDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondDataFrame.Name = "ucrSecondDataFrame"
        Me.ucrSecondDataFrame.Size = New System.Drawing.Size(120, 40)
        Me.ucrSecondDataFrame.TabIndex = 16
        '
        'ucrFirstDataFrame
        '
        Me.ucrFirstDataFrame.bUseCurrentFilter = True
        Me.ucrFirstDataFrame.Location = New System.Drawing.Point(13, 34)
        Me.ucrFirstDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFirstDataFrame.Name = "ucrFirstDataFrame"
        Me.ucrFirstDataFrame.Size = New System.Drawing.Size(120, 40)
        Me.ucrFirstDataFrame.TabIndex = 12
        '
        'cmdChooseMergeColumns
        '
        Me.cmdChooseMergeColumns.Location = New System.Drawing.Point(128, 113)
        Me.cmdChooseMergeColumns.Name = "cmdChooseMergeColumns"
        Me.cmdChooseMergeColumns.Size = New System.Drawing.Size(164, 23)
        Me.cmdChooseMergeColumns.TabIndex = 17
        Me.cmdChooseMergeColumns.Text = "Choose Merge Columns"
        Me.cmdChooseMergeColumns.UseVisualStyleBackColor = True
        '
        'ucrInputMergeColumnsOptions
        '
        Me.ucrInputMergeColumnsOptions.IsReadOnly = False
        Me.ucrInputMergeColumnsOptions.Location = New System.Drawing.Point(121, 86)
        Me.ucrInputMergeColumnsOptions.Name = "ucrInputMergeColumnsOptions"
        Me.ucrInputMergeColumnsOptions.Size = New System.Drawing.Size(229, 21)
        Me.ucrInputMergeColumnsOptions.TabIndex = 18
        '
        'lblIdColumnOption
        '
        Me.lblIdColumnOption.AutoSize = True
        Me.lblIdColumnOption.Location = New System.Drawing.Point(12, 90)
        Me.lblIdColumnOption.Name = "lblIdColumnOption"
        Me.lblIdColumnOption.Size = New System.Drawing.Size(103, 13)
        Me.lblIdColumnOption.TabIndex = 19
        Me.lblIdColumnOption.Text = "ID Columns Options:"
        '
        'dlgMerge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 405)
        Me.Controls.Add(Me.lblIdColumnOption)
        Me.Controls.Add(Me.ucrInputMergeColumnsOptions)
        Me.Controls.Add(Me.cmdChooseMergeColumns)
        Me.Controls.Add(Me.ucrSecondDataFrame)
        Me.Controls.Add(Me.ucrFirstDataFrame)
        Me.Controls.Add(Me.grpMergeOptions)
        Me.Controls.Add(Me.ucrNewDataFrameName)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.lblSecondDataFrame)
        Me.Controls.Add(Me.lblFirstDataFrame)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMerge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Merge"
        Me.Text = "Merge"
        Me.grpMergeOptions.ResumeLayout(False)
        Me.grpMergeOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblFirstDataFrame As Label
    Friend WithEvents lblSecondDataFrame As Label
    Friend WithEvents lblNewDataFrameName As Label
    Friend WithEvents ucrNewDataFrameName As ucrInputTextBox
    Friend WithEvents grpMergeOptions As GroupBox
    Friend WithEvents rdoFullJoin As RadioButton
    Friend WithEvents rdoLeftJoin As RadioButton
    Friend WithEvents rdoInnerJoin As RadioButton
    Friend WithEvents rdoRightJoin As RadioButton
    Friend WithEvents ucrSecondDataFrame As ucrDataFrame
    Friend WithEvents ucrFirstDataFrame As ucrDataFrame
    Friend WithEvents cmdChooseMergeColumns As Button
    Friend WithEvents ucrInputMergeColumnsOptions As ucrInputComboBox
    Friend WithEvents lblIdColumnOption As Label
End Class
