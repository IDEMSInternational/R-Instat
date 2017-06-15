<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgShowModel
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
        Me.rdoProbabilities = New System.Windows.Forms.RadioButton()
        Me.rdoQuantiles = New System.Windows.Forms.RadioButton()
        Me.chkGraphResults = New System.Windows.Forms.CheckBox()
        Me.chkSaveResults = New System.Windows.Forms.CheckBox()
        Me.lblQuantValues = New System.Windows.Forms.Label()
        Me.lblProbValues = New System.Windows.Forms.Label()
        Me.chkSingleValues = New System.Windows.Forms.CheckBox()
        Me.ucrDistributionsFOrTablePlus = New instat.ucrDistributionsWithParameters()
        Me.ucrInputNewColNameforTablePlus = New instat.ucrInputComboBox()
        Me.ucrSelectorForDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverExpressionForTablePlus = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputProbabilities = New instat.ucrInputComboBox()
        Me.SuspendLayout()
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
        Me.rdoQuantiles.Location = New System.Drawing.Point(243, 12)
        Me.rdoQuantiles.Name = "rdoQuantiles"
        Me.rdoQuantiles.Size = New System.Drawing.Size(69, 17)
        Me.rdoQuantiles.TabIndex = 1
        Me.rdoQuantiles.TabStop = True
        Me.rdoQuantiles.Text = "Quantiles"
        Me.rdoQuantiles.UseVisualStyleBackColor = True
        '
        'chkGraphResults
        '
        Me.chkGraphResults.AutoSize = True
        Me.chkGraphResults.Location = New System.Drawing.Point(9, 224)
        Me.chkGraphResults.Name = "chkGraphResults"
        Me.chkGraphResults.Size = New System.Drawing.Size(130, 17)
        Me.chkGraphResults.TabIndex = 4
        Me.chkGraphResults.Text = "Display Graph Results"
        Me.chkGraphResults.UseVisualStyleBackColor = True
        '
        'chkSaveResults
        '
        Me.chkSaveResults.AutoSize = True
        Me.chkSaveResults.Location = New System.Drawing.Point(9, 270)
        Me.chkSaveResults.Name = "chkSaveResults"
        Me.chkSaveResults.Size = New System.Drawing.Size(89, 17)
        Me.chkSaveResults.TabIndex = 5
        Me.chkSaveResults.Text = "Save Results"
        Me.chkSaveResults.UseVisualStyleBackColor = True
        '
        'lblQuantValues
        '
        Me.lblQuantValues.AutoSize = True
        Me.lblQuantValues.Location = New System.Drawing.Point(243, 51)
        Me.lblQuantValues.Name = "lblQuantValues"
        Me.lblQuantValues.Size = New System.Drawing.Size(42, 13)
        Me.lblQuantValues.TabIndex = 8
        Me.lblQuantValues.Text = "Values:"
        '
        'lblProbValues
        '
        Me.lblProbValues.AutoSize = True
        Me.lblProbValues.Location = New System.Drawing.Point(243, 51)
        Me.lblProbValues.Name = "lblProbValues"
        Me.lblProbValues.Size = New System.Drawing.Size(66, 13)
        Me.lblProbValues.TabIndex = 9
        Me.lblProbValues.Text = "Probabilities:"
        '
        'chkSingleValues
        '
        Me.chkSingleValues.AutoSize = True
        Me.chkSingleValues.Location = New System.Drawing.Point(9, 247)
        Me.chkSingleValues.Name = "chkSingleValues"
        Me.chkSingleValues.Size = New System.Drawing.Size(92, 17)
        Me.chkSingleValues.TabIndex = 12
        Me.chkSingleValues.Text = "Enter Value(s)"
        Me.chkSingleValues.UseVisualStyleBackColor = True
        '
        'ucrDistributionsFOrTablePlus
        '
        Me.ucrDistributionsFOrTablePlus.Location = New System.Drawing.Point(255, 102)
        Me.ucrDistributionsFOrTablePlus.Name = "ucrDistributionsFOrTablePlus"
        Me.ucrDistributionsFOrTablePlus.Size = New System.Drawing.Size(254, 185)
        Me.ucrDistributionsFOrTablePlus.TabIndex = 11
        '
        'ucrInputNewColNameforTablePlus
        '
        Me.ucrInputNewColNameforTablePlus.AddQuotesIfUnrecognised = True
        Me.ucrInputNewColNameforTablePlus.IsReadOnly = False
        Me.ucrInputNewColNameforTablePlus.Location = New System.Drawing.Point(99, 268)
        Me.ucrInputNewColNameforTablePlus.Name = "ucrInputNewColNameforTablePlus"
        Me.ucrInputNewColNameforTablePlus.Size = New System.Drawing.Size(135, 21)
        Me.ucrInputNewColNameforTablePlus.TabIndex = 6
        '
        'ucrSelectorForDataFrame
        '
        Me.ucrSelectorForDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorForDataFrame.bUseCurrentFilter = True
        Me.ucrSelectorForDataFrame.Location = New System.Drawing.Point(9, 32)
        Me.ucrSelectorForDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDataFrame.Name = "ucrSelectorForDataFrame"
        Me.ucrSelectorForDataFrame.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForDataFrame.TabIndex = 3
        '
        'ucrReceiverExpressionForTablePlus
        '
        Me.ucrReceiverExpressionForTablePlus.frmParent = Me
        Me.ucrReceiverExpressionForTablePlus.Location = New System.Drawing.Point(243, 66)
        Me.ucrReceiverExpressionForTablePlus.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverExpressionForTablePlus.Name = "ucrReceiverExpressionForTablePlus"
        Me.ucrReceiverExpressionForTablePlus.Selector = Nothing
        Me.ucrReceiverExpressionForTablePlus.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverExpressionForTablePlus.strNcFilePath = ""
        Me.ucrReceiverExpressionForTablePlus.TabIndex = 2
        Me.ucrReceiverExpressionForTablePlus.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 293)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrInputProbabilities
        '
        Me.ucrInputProbabilities.AddQuotesIfUnrecognised = True
        Me.ucrInputProbabilities.IsReadOnly = False
        Me.ucrInputProbabilities.Location = New System.Drawing.Point(243, 66)
        Me.ucrInputProbabilities.Name = "ucrInputProbabilities"
        Me.ucrInputProbabilities.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputProbabilities.TabIndex = 13
        '
        'dlgShowModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 350)
        Me.Controls.Add(Me.ucrInputProbabilities)
        Me.Controls.Add(Me.chkSingleValues)
        Me.Controls.Add(Me.ucrDistributionsFOrTablePlus)
        Me.Controls.Add(Me.lblProbValues)
        Me.Controls.Add(Me.lblQuantValues)
        Me.Controls.Add(Me.ucrInputNewColNameforTablePlus)
        Me.Controls.Add(Me.chkSaveResults)
        Me.Controls.Add(Me.chkGraphResults)
        Me.Controls.Add(Me.ucrSelectorForDataFrame)
        Me.Controls.Add(Me.ucrReceiverExpressionForTablePlus)
        Me.Controls.Add(Me.rdoQuantiles)
        Me.Controls.Add(Me.rdoProbabilities)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgShowModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Show Model"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoProbabilities As RadioButton
    Friend WithEvents rdoQuantiles As RadioButton
    Friend WithEvents ucrReceiverExpressionForTablePlus As ucrReceiverSingle
    Friend WithEvents ucrSelectorForDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents chkGraphResults As CheckBox
    Friend WithEvents chkSaveResults As CheckBox
    Friend WithEvents ucrInputNewColNameforTablePlus As ucrInputComboBox
    Friend WithEvents lblQuantValues As Label
    Friend WithEvents lblProbValues As Label
    Friend WithEvents ucrDistributionsFOrTablePlus As ucrDistributionsWithParameters
    Friend WithEvents chkSingleValues As CheckBox
    Friend WithEvents ucrInputProbabilities As ucrInputComboBox
End Class