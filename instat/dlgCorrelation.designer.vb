<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCorrelation
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
        Me.rdoTwoColumns = New System.Windows.Forms.RadioButton()
        Me.rdoMultipleColumns = New System.Windows.Forms.RadioButton()
        Me.lblFirstColumn = New System.Windows.Forms.Label()
        Me.lblSecondColumn = New System.Windows.Forms.Label()
        Me.grpMethod = New System.Windows.Forms.GroupBox()
        Me.rdoKendall = New System.Windows.Forms.RadioButton()
        Me.rdoPearson = New System.Windows.Forms.RadioButton()
        Me.rdoSpearman = New System.Windows.Forms.RadioButton()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.grpMissing = New System.Windows.Forms.GroupBox()
        Me.rdoCompleteRowsOnly = New System.Windows.Forms.RadioButton()
        Me.rdoPairwise = New System.Windows.Forms.RadioButton()
        Me.lblConfInterval = New System.Windows.Forms.Label()
        Me.nudConfidenceInterval = New System.Windows.Forms.NumericUpDown()
        Me.ucrSaveModel = New instat.ucrSaveModel()
        Me.ucrReceiverMultipleColumns = New instat.ucrReceiverMultiple()
        Me.ucrReceiverSecondColumn = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstColumn = New instat.ucrReceiverSingle()
        Me.ucrSelectorCorrelation = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpMethod.SuspendLayout()
        Me.grpMissing.SuspendLayout()
        CType(Me.nudConfidenceInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdoTwoColumns
        '
        Me.rdoTwoColumns.AutoSize = True
        Me.rdoTwoColumns.Location = New System.Drawing.Point(10, 10)
        Me.rdoTwoColumns.Name = "rdoTwoColumns"
        Me.rdoTwoColumns.Size = New System.Drawing.Size(88, 17)
        Me.rdoTwoColumns.TabIndex = 0
        Me.rdoTwoColumns.Tag = "Two_columns"
        Me.rdoTwoColumns.Text = "Two columns"
        Me.rdoTwoColumns.UseVisualStyleBackColor = True
        '
        'rdoMultipleColumns
        '
        Me.rdoMultipleColumns.AutoSize = True
        Me.rdoMultipleColumns.Location = New System.Drawing.Point(255, 10)
        Me.rdoMultipleColumns.Name = "rdoMultipleColumns"
        Me.rdoMultipleColumns.Size = New System.Drawing.Size(103, 17)
        Me.rdoMultipleColumns.TabIndex = 1
        Me.rdoMultipleColumns.Tag = "Multiple_columns"
        Me.rdoMultipleColumns.Text = "Multiple columns"
        Me.rdoMultipleColumns.UseVisualStyleBackColor = True
        '
        'lblFirstColumn
        '
        Me.lblFirstColumn.AutoSize = True
        Me.lblFirstColumn.Location = New System.Drawing.Point(255, 55)
        Me.lblFirstColumn.Name = "lblFirstColumn"
        Me.lblFirstColumn.Size = New System.Drawing.Size(67, 13)
        Me.lblFirstColumn.TabIndex = 4
        Me.lblFirstColumn.Tag = "First_column"
        Me.lblFirstColumn.Text = "First Column:"
        '
        'lblSecondColumn
        '
        Me.lblSecondColumn.AutoSize = True
        Me.lblSecondColumn.Location = New System.Drawing.Point(255, 106)
        Me.lblSecondColumn.Name = "lblSecondColumn"
        Me.lblSecondColumn.Size = New System.Drawing.Size(85, 13)
        Me.lblSecondColumn.TabIndex = 5
        Me.lblSecondColumn.Tag = "Second_column"
        Me.lblSecondColumn.Text = "Second Column:"
        '
        'grpMethod
        '
        Me.grpMethod.Controls.Add(Me.rdoKendall)
        Me.grpMethod.Controls.Add(Me.rdoPearson)
        Me.grpMethod.Controls.Add(Me.rdoSpearman)
        Me.grpMethod.Location = New System.Drawing.Point(10, 230)
        Me.grpMethod.Name = "grpMethod"
        Me.grpMethod.Size = New System.Drawing.Size(205, 49)
        Me.grpMethod.TabIndex = 10
        Me.grpMethod.TabStop = False
        Me.grpMethod.Tag = "Method"
        Me.grpMethod.Text = "Method"
        '
        'rdoKendall
        '
        Me.rdoKendall.AutoSize = True
        Me.rdoKendall.Location = New System.Drawing.Point(68, 18)
        Me.rdoKendall.Name = "rdoKendall"
        Me.rdoKendall.Size = New System.Drawing.Size(60, 17)
        Me.rdoKendall.TabIndex = 1
        Me.rdoKendall.Tag = "Kendall"
        Me.rdoKendall.Text = "Kendall"
        Me.rdoKendall.UseVisualStyleBackColor = True
        '
        'rdoPearson
        '
        Me.rdoPearson.AutoSize = True
        Me.rdoPearson.Checked = True
        Me.rdoPearson.Location = New System.Drawing.Point(5, 18)
        Me.rdoPearson.Name = "rdoPearson"
        Me.rdoPearson.Size = New System.Drawing.Size(64, 17)
        Me.rdoPearson.TabIndex = 0
        Me.rdoPearson.TabStop = True
        Me.rdoPearson.Tag = "Pearson"
        Me.rdoPearson.Text = "Pearson"
        Me.rdoPearson.UseVisualStyleBackColor = True
        '
        'rdoSpearman
        '
        Me.rdoSpearman.AutoSize = True
        Me.rdoSpearman.Location = New System.Drawing.Point(128, 18)
        Me.rdoSpearman.Name = "rdoSpearman"
        Me.rdoSpearman.Size = New System.Drawing.Size(73, 17)
        Me.rdoSpearman.TabIndex = 2
        Me.rdoSpearman.Tag = "Spearman"
        Me.rdoSpearman.Text = "Spearman"
        Me.rdoSpearman.UseVisualStyleBackColor = True
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(255, 189)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdOptions.TabIndex = 9
        Me.cmdOptions.Tag = "Options..."
        Me.cmdOptions.Text = "Options..."
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'grpMissing
        '
        Me.grpMissing.Controls.Add(Me.rdoCompleteRowsOnly)
        Me.grpMissing.Controls.Add(Me.rdoPairwise)
        Me.grpMissing.Location = New System.Drawing.Point(217, 230)
        Me.grpMissing.Name = "grpMissing"
        Me.grpMissing.Size = New System.Drawing.Size(190, 49)
        Me.grpMissing.TabIndex = 11
        Me.grpMissing.TabStop = False
        Me.grpMissing.Tag = "Missing"
        Me.grpMissing.Text = "Missing"
        '
        'rdoCompleteRowsOnly
        '
        Me.rdoCompleteRowsOnly.AutoSize = True
        Me.rdoCompleteRowsOnly.Checked = True
        Me.rdoCompleteRowsOnly.Location = New System.Drawing.Point(6, 18)
        Me.rdoCompleteRowsOnly.Name = "rdoCompleteRowsOnly"
        Me.rdoCompleteRowsOnly.Size = New System.Drawing.Size(116, 17)
        Me.rdoCompleteRowsOnly.TabIndex = 0
        Me.rdoCompleteRowsOnly.TabStop = True
        Me.rdoCompleteRowsOnly.Tag = "Complete_rows_only"
        Me.rdoCompleteRowsOnly.Text = "Complete rows only"
        Me.rdoCompleteRowsOnly.UseVisualStyleBackColor = True
        '
        'rdoPairwise
        '
        Me.rdoPairwise.AutoSize = True
        Me.rdoPairwise.Location = New System.Drawing.Point(124, 18)
        Me.rdoPairwise.Name = "rdoPairwise"
        Me.rdoPairwise.Size = New System.Drawing.Size(64, 17)
        Me.rdoPairwise.TabIndex = 1
        Me.rdoPairwise.Tag = "Pairwise"
        Me.rdoPairwise.Text = "Pairwise"
        Me.rdoPairwise.UseVisualStyleBackColor = True
        '
        'lblConfInterval
        '
        Me.lblConfInterval.AutoSize = True
        Me.lblConfInterval.Location = New System.Drawing.Point(256, 167)
        Me.lblConfInterval.Name = "lblConfInterval"
        Me.lblConfInterval.Size = New System.Drawing.Size(102, 13)
        Me.lblConfInterval.TabIndex = 7
        Me.lblConfInterval.Text = "Confidence Interval:"
        '
        'nudConfidenceInterval
        '
        Me.nudConfidenceInterval.DecimalPlaces = 2
        Me.nudConfidenceInterval.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudConfidenceInterval.Location = New System.Drawing.Point(361, 164)
        Me.nudConfidenceInterval.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudConfidenceInterval.Name = "nudConfidenceInterval"
        Me.nudConfidenceInterval.Size = New System.Drawing.Size(43, 20)
        Me.nudConfidenceInterval.TabIndex = 8
        Me.nudConfidenceInterval.Value = New Decimal(New Integer() {95, 0, 0, 131072})
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.Location = New System.Drawing.Point(15, 285)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(265, 20)
        Me.ucrSaveModel.TabIndex = 15
        '
        'ucrReceiverMultipleColumns
        '
        Me.ucrReceiverMultipleColumns.Location = New System.Drawing.Point(255, 55)
        Me.ucrReceiverMultipleColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleColumns.Name = "ucrReceiverMultipleColumns"
        Me.ucrReceiverMultipleColumns.Selector = Nothing
        Me.ucrReceiverMultipleColumns.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleColumns.TabIndex = 3
        '
        'ucrReceiverSecondColumn
        '
        Me.ucrReceiverSecondColumn.Location = New System.Drawing.Point(255, 122)
        Me.ucrReceiverSecondColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondColumn.Name = "ucrReceiverSecondColumn"
        Me.ucrReceiverSecondColumn.Selector = Nothing
        Me.ucrReceiverSecondColumn.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSecondColumn.TabIndex = 6
        '
        'ucrReceiverFirstColumn
        '
        Me.ucrReceiverFirstColumn.Location = New System.Drawing.Point(255, 70)
        Me.ucrReceiverFirstColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstColumn.Name = "ucrReceiverFirstColumn"
        Me.ucrReceiverFirstColumn.Selector = Nothing
        Me.ucrReceiverFirstColumn.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFirstColumn.TabIndex = 4
        '
        'ucrSelectorCorrelation
        '
        Me.ucrSelectorCorrelation.bShowHiddenColumns = False
        Me.ucrSelectorCorrelation.bUseCurrentFilter = True
        Me.ucrSelectorCorrelation.Location = New System.Drawing.Point(10, 40)
        Me.ucrSelectorCorrelation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCorrelation.Name = "ucrSelectorCorrelation"
        Me.ucrSelectorCorrelation.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorCorrelation.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 320)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 12
        '
        'dlgCorrelation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 377)
        Me.Controls.Add(Me.ucrSaveModel)
        Me.Controls.Add(Me.grpMethod)
        Me.Controls.Add(Me.nudConfidenceInterval)
        Me.Controls.Add(Me.ucrReceiverMultipleColumns)
        Me.Controls.Add(Me.lblConfInterval)
        Me.Controls.Add(Me.grpMissing)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblSecondColumn)
        Me.Controls.Add(Me.lblFirstColumn)
        Me.Controls.Add(Me.ucrReceiverSecondColumn)
        Me.Controls.Add(Me.ucrReceiverFirstColumn)
        Me.Controls.Add(Me.ucrSelectorCorrelation)
        Me.Controls.Add(Me.rdoMultipleColumns)
        Me.Controls.Add(Me.rdoTwoColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCorrelation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Correlation"
        Me.Text = "Correlation"
        Me.grpMethod.ResumeLayout(False)
        Me.grpMethod.PerformLayout()
        Me.grpMissing.ResumeLayout(False)
        Me.grpMissing.PerformLayout()
        CType(Me.nudConfidenceInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoTwoColumns As RadioButton
    Friend WithEvents rdoMultipleColumns As RadioButton
    Friend WithEvents ucrSelectorCorrelation As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFirstColumn As ucrReceiverSingle
    Friend WithEvents ucrReceiverSecondColumn As ucrReceiverSingle
    Friend WithEvents lblFirstColumn As Label
    Friend WithEvents lblSecondColumn As Label
    Friend WithEvents grpMethod As GroupBox
    Friend WithEvents rdoSpearman As RadioButton
    Friend WithEvents rdoKendall As RadioButton
    Friend WithEvents rdoPearson As RadioButton
    Friend WithEvents cmdOptions As Button
    Friend WithEvents grpMissing As GroupBox
    Friend WithEvents rdoPairwise As RadioButton
    Friend WithEvents rdoCompleteRowsOnly As RadioButton
    Friend WithEvents lblConfInterval As Label
    Friend WithEvents ucrReceiverMultipleColumns As ucrReceiverMultiple
    Friend WithEvents nudConfidenceInterval As NumericUpDown
    Friend WithEvents ucrSaveModel As ucrSaveModel
End Class
