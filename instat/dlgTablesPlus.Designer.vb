<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTablesPlus
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
        Me.rdoProbabilities = New System.Windows.Forms.RadioButton()
        Me.rdoQuantiles = New System.Windows.Forms.RadioButton()
        Me.ucrSelectorForDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblValues = New System.Windows.Forms.Label()
        Me.chkGraphResults = New System.Windows.Forms.CheckBox()
        Me.lblProbabilities = New System.Windows.Forms.Label()
        Me.chkSaveResults = New System.Windows.Forms.CheckBox()
        Me.ucrInputNewColName = New instat.ucrInputComboBox()
        Me.ucrDistributionForTablePlus = New instat.ucrDistributions()
        Me.ucrReceiverExpressionForTablePlus = New instat.ucrReceiverExpression()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 268)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'rdoProbabilities
        '
        Me.rdoProbabilities.AutoSize = True
        Me.rdoProbabilities.Location = New System.Drawing.Point(12, 12)
        Me.rdoProbabilities.Name = "rdoProbabilities"
        Me.rdoProbabilities.Size = New System.Drawing.Size(79, 17)
        Me.rdoProbabilities.TabIndex = 1
        Me.rdoProbabilities.TabStop = True
        Me.rdoProbabilities.Text = "Probablities"
        Me.rdoProbabilities.UseVisualStyleBackColor = True
        '
        'rdoQuantiles
        '
        Me.rdoQuantiles.AutoSize = True
        Me.rdoQuantiles.Location = New System.Drawing.Point(213, 12)
        Me.rdoQuantiles.Name = "rdoQuantiles"
        Me.rdoQuantiles.Size = New System.Drawing.Size(69, 17)
        Me.rdoQuantiles.TabIndex = 1
        Me.rdoQuantiles.TabStop = True
        Me.rdoQuantiles.Text = "Quantiles"
        Me.rdoQuantiles.UseVisualStyleBackColor = True
        '
        'ucrSelectorForDataFrame
        '
        Me.ucrSelectorForDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorForDataFrame.bUseCurrentFilter = False
        Me.ucrSelectorForDataFrame.Location = New System.Drawing.Point(13, 36)
        Me.ucrSelectorForDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDataFrame.Name = "ucrSelectorForDataFrame"
        Me.ucrSelectorForDataFrame.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForDataFrame.TabIndex = 2
        '
        'lblValues
        '
        Me.lblValues.AutoSize = True
        Me.lblValues.Location = New System.Drawing.Point(235, 40)
        Me.lblValues.Name = "lblValues"
        Me.lblValues.Size = New System.Drawing.Size(39, 13)
        Me.lblValues.TabIndex = 4
        Me.lblValues.Text = "Values"
        '
        'chkGraphResults
        '
        Me.chkGraphResults.AutoSize = True
        Me.chkGraphResults.Location = New System.Drawing.Point(13, 219)
        Me.chkGraphResults.Name = "chkGraphResults"
        Me.chkGraphResults.Size = New System.Drawing.Size(93, 17)
        Me.chkGraphResults.TabIndex = 6
        Me.chkGraphResults.Text = "Graph Results"
        Me.chkGraphResults.UseVisualStyleBackColor = True
        '
        'lblProbabilities
        '
        Me.lblProbabilities.AutoSize = True
        Me.lblProbabilities.Location = New System.Drawing.Point(235, 40)
        Me.lblProbabilities.Name = "lblProbabilities"
        Me.lblProbabilities.Size = New System.Drawing.Size(63, 13)
        Me.lblProbabilities.TabIndex = 7
        Me.lblProbabilities.Text = "Probabilities"
        '
        'chkSaveResults
        '
        Me.chkSaveResults.AutoSize = True
        Me.chkSaveResults.Location = New System.Drawing.Point(13, 242)
        Me.chkSaveResults.Name = "chkSaveResults"
        Me.chkSaveResults.Size = New System.Drawing.Size(89, 17)
        Me.chkSaveResults.TabIndex = 6
        Me.chkSaveResults.Text = "Save Results"
        Me.chkSaveResults.UseVisualStyleBackColor = True
        '
        'ucrInputNewColName
        '
        Me.ucrInputNewColName.IsReadOnly = False
        Me.ucrInputNewColName.Location = New System.Drawing.Point(109, 241)
        Me.ucrInputNewColName.Name = "ucrInputNewColName"
        Me.ucrInputNewColName.Size = New System.Drawing.Size(327, 21)
        Me.ucrInputNewColName.TabIndex = 8
        '
        'ucrDistributionForTablePlus
        '
        Me.ucrDistributionForTablePlus.Location = New System.Drawing.Point(238, 84)
        Me.ucrDistributionForTablePlus.Name = "ucrDistributionForTablePlus"
        Me.ucrDistributionForTablePlus.Size = New System.Drawing.Size(198, 43)
        Me.ucrDistributionForTablePlus.TabIndex = 9
        '
        'ucrReceiverExpressionForTablePlus
        '
        Me.ucrReceiverExpressionForTablePlus.Location = New System.Drawing.Point(238, 57)
        Me.ucrReceiverExpressionForTablePlus.Name = "ucrReceiverExpressionForTablePlus"
        Me.ucrReceiverExpressionForTablePlus.Selector = Nothing
        Me.ucrReceiverExpressionForTablePlus.Size = New System.Drawing.Size(184, 20)
        Me.ucrReceiverExpressionForTablePlus.TabIndex = 10
        '
        'dlgTablesPlus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 325)
        Me.Controls.Add(Me.ucrReceiverExpressionForTablePlus)
        Me.Controls.Add(Me.ucrDistributionForTablePlus)
        Me.Controls.Add(Me.ucrInputNewColName)
        Me.Controls.Add(Me.lblProbabilities)
        Me.Controls.Add(Me.chkSaveResults)
        Me.Controls.Add(Me.chkGraphResults)
        Me.Controls.Add(Me.lblValues)
        Me.Controls.Add(Me.ucrSelectorForDataFrame)
        Me.Controls.Add(Me.rdoQuantiles)
        Me.Controls.Add(Me.rdoProbabilities)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTablesPlus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tables Plus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoProbabilities As RadioButton
    Friend WithEvents rdoQuantiles As RadioButton
    Friend WithEvents ucrSelectorForDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblValues As Label
    Friend WithEvents chkGraphResults As CheckBox
    Friend WithEvents lblProbabilities As Label
    Friend WithEvents chkSaveResults As CheckBox
    Friend WithEvents ucrInputNewColName As ucrInputComboBox
    Friend WithEvents ucrDistributionForTablePlus As ucrDistributions
    Friend WithEvents ucrReceiverExpressionForTablePlus As ucrReceiverExpression
End Class
