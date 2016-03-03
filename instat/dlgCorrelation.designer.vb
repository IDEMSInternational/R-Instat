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
        Me.rdoSpearman = New System.Windows.Forms.RadioButton()
        Me.rdoKendall = New System.Windows.Forms.RadioButton()
        Me.rdoPearson = New System.Windows.Forms.RadioButton()
        Me.cmdPlot = New System.Windows.Forms.Button()
        Me.grpMissing = New System.Windows.Forms.GroupBox()
        Me.rdoPairwise = New System.Windows.Forms.RadioButton()
        Me.rdoCompleteRowsOnly = New System.Windows.Forms.RadioButton()
        Me.lblConfInterval = New System.Windows.Forms.Label()
        Me.txtConfidenceInterval = New System.Windows.Forms.TextBox()
        Me.ucrReceiverSecondColumn = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstColumn = New instat.ucrReceiverSingle()
        Me.ucrSelectorDataFrameVarAddRemove = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverMultipleColumns = New instat.ucrReceiverMultiple()
        Me.grpMethod.SuspendLayout()
        Me.grpMissing.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoTwoColumns
        '
        Me.rdoTwoColumns.AutoSize = True
        Me.rdoTwoColumns.Location = New System.Drawing.Point(3, 11)
        Me.rdoTwoColumns.Name = "rdoTwoColumns"
        Me.rdoTwoColumns.Size = New System.Drawing.Size(88, 17)
        Me.rdoTwoColumns.TabIndex = 2
        Me.rdoTwoColumns.Tag = "Two_columns"
        Me.rdoTwoColumns.Text = "Two columns"
        Me.rdoTwoColumns.UseVisualStyleBackColor = True
        '
        'rdoMultipleColumns
        '
        Me.rdoMultipleColumns.AutoSize = True
        Me.rdoMultipleColumns.Location = New System.Drawing.Point(278, 12)
        Me.rdoMultipleColumns.Name = "rdoMultipleColumns"
        Me.rdoMultipleColumns.Size = New System.Drawing.Size(103, 17)
        Me.rdoMultipleColumns.TabIndex = 3
        Me.rdoMultipleColumns.Tag = "Multiple_columns"
        Me.rdoMultipleColumns.Text = "Multiple columns"
        Me.rdoMultipleColumns.UseVisualStyleBackColor = True
        '
        'lblFirstColumn
        '
        Me.lblFirstColumn.AutoSize = True
        Me.lblFirstColumn.Location = New System.Drawing.Point(307, 118)
        Me.lblFirstColumn.Name = "lblFirstColumn"
        Me.lblFirstColumn.Size = New System.Drawing.Size(63, 13)
        Me.lblFirstColumn.TabIndex = 7
        Me.lblFirstColumn.Tag = "First_column"
        Me.lblFirstColumn.Text = "First column"
        '
        'lblSecondColumn
        '
        Me.lblSecondColumn.AutoSize = True
        Me.lblSecondColumn.Location = New System.Drawing.Point(308, 169)
        Me.lblSecondColumn.Name = "lblSecondColumn"
        Me.lblSecondColumn.Size = New System.Drawing.Size(81, 13)
        Me.lblSecondColumn.TabIndex = 8
        Me.lblSecondColumn.Tag = "Second_column"
        Me.lblSecondColumn.Text = "Second column"
        '
        'grpMethod
        '
        Me.grpMethod.Controls.Add(Me.rdoSpearman)
        Me.grpMethod.Controls.Add(Me.rdoKendall)
        Me.grpMethod.Controls.Add(Me.rdoPearson)
        Me.grpMethod.Location = New System.Drawing.Point(3, 233)
        Me.grpMethod.Name = "grpMethod"
        Me.grpMethod.Size = New System.Drawing.Size(423, 44)
        Me.grpMethod.TabIndex = 9
        Me.grpMethod.TabStop = False
        Me.grpMethod.Tag = "Method"
        Me.grpMethod.Text = "Method"
        '
        'rdoSpearman
        '
        Me.rdoSpearman.AutoSize = True
        Me.rdoSpearman.Location = New System.Drawing.Point(298, 20)
        Me.rdoSpearman.Name = "rdoSpearman"
        Me.rdoSpearman.Size = New System.Drawing.Size(73, 17)
        Me.rdoSpearman.TabIndex = 2
        Me.rdoSpearman.Tag = "Spearman"
        Me.rdoSpearman.Text = "Spearman"
        Me.rdoSpearman.UseVisualStyleBackColor = True
        '
        'rdoKendall
        '
        Me.rdoKendall.AutoSize = True
        Me.rdoKendall.Location = New System.Drawing.Point(129, 20)
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
        Me.rdoPearson.Location = New System.Drawing.Point(5, 20)
        Me.rdoPearson.Name = "rdoPearson"
        Me.rdoPearson.Size = New System.Drawing.Size(64, 17)
        Me.rdoPearson.TabIndex = 0
        Me.rdoPearson.TabStop = True
        Me.rdoPearson.Tag = "Pearson"
        Me.rdoPearson.Text = "Pearson"
        Me.rdoPearson.UseVisualStyleBackColor = True
        '
        'cmdPlot
        '
        Me.cmdPlot.Location = New System.Drawing.Point(332, 293)
        Me.cmdPlot.Name = "cmdPlot"
        Me.cmdPlot.Size = New System.Drawing.Size(75, 23)
        Me.cmdPlot.TabIndex = 11
        Me.cmdPlot.Tag = "Plot"
        Me.cmdPlot.Text = "Plot"
        Me.cmdPlot.UseVisualStyleBackColor = True
        '
        'grpMissing
        '
        Me.grpMissing.Controls.Add(Me.rdoPairwise)
        Me.grpMissing.Controls.Add(Me.rdoCompleteRowsOnly)
        Me.grpMissing.Location = New System.Drawing.Point(3, 283)
        Me.grpMissing.Name = "grpMissing"
        Me.grpMissing.Size = New System.Drawing.Size(309, 40)
        Me.grpMissing.TabIndex = 12
        Me.grpMissing.TabStop = False
        Me.grpMissing.Tag = "Missing"
        Me.grpMissing.Text = "Missing"
        '
        'rdoPairwise
        '
        Me.rdoPairwise.AutoSize = True
        Me.rdoPairwise.Location = New System.Drawing.Point(203, 16)
        Me.rdoPairwise.Name = "rdoPairwise"
        Me.rdoPairwise.Size = New System.Drawing.Size(64, 17)
        Me.rdoPairwise.TabIndex = 1
        Me.rdoPairwise.Tag = "Pairwise"
        Me.rdoPairwise.Text = "Pairwise"
        Me.rdoPairwise.UseVisualStyleBackColor = True
        '
        'rdoCompleteRowsOnly
        '
        Me.rdoCompleteRowsOnly.AutoSize = True
        Me.rdoCompleteRowsOnly.Checked = True
        Me.rdoCompleteRowsOnly.Location = New System.Drawing.Point(8, 16)
        Me.rdoCompleteRowsOnly.Name = "rdoCompleteRowsOnly"
        Me.rdoCompleteRowsOnly.Size = New System.Drawing.Size(116, 17)
        Me.rdoCompleteRowsOnly.TabIndex = 0
        Me.rdoCompleteRowsOnly.TabStop = True
        Me.rdoCompleteRowsOnly.Tag = "Complete_rows_only"
        Me.rdoCompleteRowsOnly.Text = "Complete rows only"
        Me.rdoCompleteRowsOnly.UseVisualStyleBackColor = True
        '
        'lblConfInterval
        '
        Me.lblConfInterval.AutoSize = True
        Me.lblConfInterval.Location = New System.Drawing.Point(12, 325)
        Me.lblConfInterval.Name = "lblConfInterval"
        Me.lblConfInterval.Size = New System.Drawing.Size(133, 13)
        Me.lblConfInterval.TabIndex = 13
        Me.lblConfInterval.Text = "T Test Confidence Interval"
        '
        'txtConfidenceInterval
        '
        Me.txtConfidenceInterval.Location = New System.Drawing.Point(156, 322)
        Me.txtConfidenceInterval.Name = "txtConfidenceInterval"
        Me.txtConfidenceInterval.Size = New System.Drawing.Size(100, 20)
        Me.txtConfidenceInterval.TabIndex = 14
        '
        'ucrReceiverSecondColumn
        '
        Me.ucrReceiverSecondColumn.Location = New System.Drawing.Point(301, 181)
        Me.ucrReceiverSecondColumn.Name = "ucrReceiverSecondColumn"
        Me.ucrReceiverSecondColumn.Selector = Nothing
        Me.ucrReceiverSecondColumn.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverSecondColumn.TabIndex = 6
        '
        'ucrReceiverFirstColumn
        '
        Me.ucrReceiverFirstColumn.Location = New System.Drawing.Point(301, 129)
        Me.ucrReceiverFirstColumn.Name = "ucrReceiverFirstColumn"
        Me.ucrReceiverFirstColumn.Selector = Nothing
        Me.ucrReceiverFirstColumn.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverFirstColumn.TabIndex = 5
        '
        'ucrSelectorDataFrameVarAddRemove
        '
        Me.ucrSelectorDataFrameVarAddRemove.Location = New System.Drawing.Point(3, 37)
        Me.ucrSelectorDataFrameVarAddRemove.Name = "ucrSelectorDataFrameVarAddRemove"
        Me.ucrSelectorDataFrameVarAddRemove.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorDataFrameVarAddRemove.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(11, 358)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(409, 57)
        Me.ucrBase.TabIndex = 1
        '
        'ucrReceiverMultipleColumns
        '
        Me.ucrReceiverMultipleColumns.Location = New System.Drawing.Point(278, 112)
        Me.ucrReceiverMultipleColumns.Name = "ucrReceiverMultipleColumns"
        Me.ucrReceiverMultipleColumns.Selector = Nothing
        Me.ucrReceiverMultipleColumns.Size = New System.Drawing.Size(121, 104)
        Me.ucrReceiverMultipleColumns.TabIndex = 15
        '
        'dlgCorrelation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 415)
        Me.Controls.Add(Me.ucrReceiverMultipleColumns)
        Me.Controls.Add(Me.lblConfInterval)
        Me.Controls.Add(Me.txtConfidenceInterval)
        Me.Controls.Add(Me.grpMissing)
        Me.Controls.Add(Me.cmdPlot)
        Me.Controls.Add(Me.grpMethod)
        Me.Controls.Add(Me.lblSecondColumn)
        Me.Controls.Add(Me.lblFirstColumn)
        Me.Controls.Add(Me.ucrReceiverSecondColumn)
        Me.Controls.Add(Me.ucrReceiverFirstColumn)
        Me.Controls.Add(Me.ucrSelectorDataFrameVarAddRemove)
        Me.Controls.Add(Me.rdoMultipleColumns)
        Me.Controls.Add(Me.rdoTwoColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgCorrelation"
        Me.Tag = "Correlation"
        Me.Text = "Correlation"
        Me.grpMethod.ResumeLayout(False)
        Me.grpMethod.PerformLayout()
        Me.grpMissing.ResumeLayout(False)
        Me.grpMissing.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoTwoColumns As RadioButton
    Friend WithEvents rdoMultipleColumns As RadioButton
    Friend WithEvents ucrSelectorDataFrameVarAddRemove As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFirstColumn As ucrReceiverSingle
    Friend WithEvents ucrReceiverSecondColumn As ucrReceiverSingle
    Friend WithEvents lblFirstColumn As Label
    Friend WithEvents lblSecondColumn As Label
    Friend WithEvents grpMethod As GroupBox
    Friend WithEvents rdoSpearman As RadioButton
    Friend WithEvents rdoKendall As RadioButton
    Friend WithEvents rdoPearson As RadioButton
    Friend WithEvents cmdPlot As Button
    Friend WithEvents grpMissing As GroupBox
    Friend WithEvents rdoPairwise As RadioButton
    Friend WithEvents rdoCompleteRowsOnly As RadioButton
    Friend WithEvents txtConfidenceInterval As TextBox
    Friend WithEvents lblConfInterval As Label
    Friend WithEvents ucrReceiverMultipleColumns As ucrReceiverMultiple
End Class
