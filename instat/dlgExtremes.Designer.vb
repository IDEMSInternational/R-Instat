<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgExtremes
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
        Me.lblDataToFit = New System.Windows.Forms.Label()
        Me.grpDistributions = New System.Windows.Forms.GroupBox()
        Me.rdoGEV = New System.Windows.Forms.RadioButton()
        Me.rdoGumbel = New System.Windows.Forms.RadioButton()
        Me.grpEstimationMethods = New System.Windows.Forms.GroupBox()
        Me.lblSaveInMOM = New System.Windows.Forms.Label()
        Me.lblSaveInMLE = New System.Windows.Forms.Label()
        Me.lblBetween = New System.Windows.Forms.Label()
        Me.lblAnd = New System.Windows.Forms.Label()
        Me.ucrInputTo = New instat.ucrInputTextBox()
        Me.ucrInputFrom = New instat.ucrInputTextBox()
        Me.UcrDialogDisabled1 = New instat.ucrDialogDisabled()
        Me.ucrChkProbPlot = New instat.ucrCheck()
        Me.ucrChkRestrictDataValues = New instat.ucrCheck()
        Me.ucrInputMLE = New instat.ucrInputComboBox()
        Me.ucrInputMOM = New instat.ucrInputComboBox()
        Me.ucrChkMOM = New instat.ucrCheck()
        Me.ucrChkMLE = New instat.ucrCheck()
        Me.ucrReceiverDataToFit = New instat.ucrReceiverSingle()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlDistributions = New instat.UcrPanel()
        Me.grpDistributions.SuspendLayout()
        Me.grpEstimationMethods.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDataToFit
        '
        Me.lblDataToFit.AutoSize = True
        Me.lblDataToFit.Location = New System.Drawing.Point(224, 24)
        Me.lblDataToFit.Name = "lblDataToFit"
        Me.lblDataToFit.Size = New System.Drawing.Size(89, 13)
        Me.lblDataToFit.TabIndex = 1
        Me.lblDataToFit.Tag = "Data_to_be_fitted"
        Me.lblDataToFit.Text = "Data to be Fitted:"
        '
        'grpDistributions
        '
        Me.grpDistributions.Controls.Add(Me.rdoGEV)
        Me.grpDistributions.Controls.Add(Me.rdoGumbel)
        Me.grpDistributions.Location = New System.Drawing.Point(308, 192)
        Me.grpDistributions.Name = "grpDistributions"
        Me.grpDistributions.Size = New System.Drawing.Size(100, 91)
        Me.grpDistributions.TabIndex = 10
        Me.grpDistributions.TabStop = False
        Me.grpDistributions.Tag = "Distributions"
        Me.grpDistributions.Text = "Distributions"
        '
        'rdoGEV
        '
        Me.rdoGEV.AutoSize = True
        Me.rdoGEV.Location = New System.Drawing.Point(9, 49)
        Me.rdoGEV.Name = "rdoGEV"
        Me.rdoGEV.Size = New System.Drawing.Size(47, 17)
        Me.rdoGEV.TabIndex = 1
        Me.rdoGEV.TabStop = True
        Me.rdoGEV.Tag = "GEV"
        Me.rdoGEV.Text = "GEV"
        Me.rdoGEV.UseVisualStyleBackColor = True
        '
        'rdoGumbel
        '
        Me.rdoGumbel.AutoSize = True
        Me.rdoGumbel.Location = New System.Drawing.Point(30, 26)
        Me.rdoGumbel.Name = "rdoGumbel"
        Me.rdoGumbel.Size = New System.Drawing.Size(61, 17)
        Me.rdoGumbel.TabIndex = 0
        Me.rdoGumbel.TabStop = True
        Me.rdoGumbel.Tag = "Gumbel"
        Me.rdoGumbel.Text = "Gumbel"
        Me.rdoGumbel.UseVisualStyleBackColor = True
        '
        'grpEstimationMethods
        '
        Me.grpEstimationMethods.Controls.Add(Me.ucrInputMLE)
        Me.grpEstimationMethods.Controls.Add(Me.lblSaveInMOM)
        Me.grpEstimationMethods.Controls.Add(Me.ucrInputMOM)
        Me.grpEstimationMethods.Controls.Add(Me.ucrChkMOM)
        Me.grpEstimationMethods.Controls.Add(Me.ucrChkMLE)
        Me.grpEstimationMethods.Controls.Add(Me.lblSaveInMLE)
        Me.grpEstimationMethods.Location = New System.Drawing.Point(9, 193)
        Me.grpEstimationMethods.Name = "grpEstimationMethods"
        Me.grpEstimationMethods.Size = New System.Drawing.Size(290, 91)
        Me.grpEstimationMethods.TabIndex = 9
        Me.grpEstimationMethods.TabStop = False
        Me.grpEstimationMethods.Tag = "Estimation_Methods"
        Me.grpEstimationMethods.Text = "Estimation methods"
        '
        'lblSaveInMOM
        '
        Me.lblSaveInMOM.AutoSize = True
        Me.lblSaveInMOM.Location = New System.Drawing.Point(132, 62)
        Me.lblSaveInMOM.Name = "lblSaveInMOM"
        Me.lblSaveInMOM.Size = New System.Drawing.Size(46, 13)
        Me.lblSaveInMOM.TabIndex = 4
        Me.lblSaveInMOM.Tag = ""
        Me.lblSaveInMOM.Text = "Save in:"
        '
        'lblSaveInMLE
        '
        Me.lblSaveInMLE.AutoSize = True
        Me.lblSaveInMLE.Location = New System.Drawing.Point(132, 25)
        Me.lblSaveInMLE.Name = "lblSaveInMLE"
        Me.lblSaveInMLE.Size = New System.Drawing.Size(46, 13)
        Me.lblSaveInMLE.TabIndex = 1
        Me.lblSaveInMLE.Tag = ""
        Me.lblSaveInMLE.Text = "Save in:"
        '
        'lblBetween
        '
        Me.lblBetween.AutoSize = True
        Me.lblBetween.Location = New System.Drawing.Point(269, 101)
        Me.lblBetween.Name = "lblBetween"
        Me.lblBetween.Size = New System.Drawing.Size(33, 13)
        Me.lblBetween.TabIndex = 4
        Me.lblBetween.Tag = "between"
        Me.lblBetween.Text = "From:"
        Me.lblBetween.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAnd
        '
        Me.lblAnd.AutoSize = True
        Me.lblAnd.Location = New System.Drawing.Point(271, 124)
        Me.lblAnd.Name = "lblAnd"
        Me.lblAnd.Size = New System.Drawing.Size(23, 13)
        Me.lblAnd.TabIndex = 6
        Me.lblAnd.Tag = "and"
        Me.lblAnd.Text = "To:"
        '
        'ucrInputTo
        '
        Me.ucrInputTo.bAddRemoveParameter = True
        Me.ucrInputTo.bChangeParameterValue = True
        Me.ucrInputTo.IsMultiline = False
        Me.ucrInputTo.IsReadOnly = False
        Me.ucrInputTo.Location = New System.Drawing.Point(311, 121)
        Me.ucrInputTo.Name = "ucrInputTo"
        Me.ucrInputTo.Size = New System.Drawing.Size(56, 21)
        Me.ucrInputTo.TabIndex = 7
        '
        'ucrInputFrom
        '
        Me.ucrInputFrom.bAddRemoveParameter = True
        Me.ucrInputFrom.bChangeParameterValue = True
        Me.ucrInputFrom.IsMultiline = False
        Me.ucrInputFrom.IsReadOnly = False
        Me.ucrInputFrom.Location = New System.Drawing.Point(311, 98)
        Me.ucrInputFrom.Name = "ucrInputFrom"
        Me.ucrInputFrom.Size = New System.Drawing.Size(56, 21)
        Me.ucrInputFrom.TabIndex = 5
        '
        'UcrDialogDisabled1
        '
        Me.UcrDialogDisabled1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcrDialogDisabled1.Location = New System.Drawing.Point(59, 117)
        Me.UcrDialogDisabled1.Name = "UcrDialogDisabled1"
        Me.UcrDialogDisabled1.Size = New System.Drawing.Size(240, 89)
        Me.UcrDialogDisabled1.TabIndex = 14
        '
        'ucrChkProbPlot
        '
        Me.ucrChkProbPlot.bAddRemoveParameter = True
        Me.ucrChkProbPlot.bChangeParameterValue = True
        Me.ucrChkProbPlot.Checked = False
        Me.ucrChkProbPlot.Location = New System.Drawing.Point(15, 167)
        Me.ucrChkProbPlot.Name = "ucrChkProbPlot"
        Me.ucrChkProbPlot.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkProbPlot.TabIndex = 8
        '
        'ucrChkRestrictDataValues
        '
        Me.ucrChkRestrictDataValues.bAddRemoveParameter = True
        Me.ucrChkRestrictDataValues.bChangeParameterValue = True
        Me.ucrChkRestrictDataValues.Checked = False
        Me.ucrChkRestrictDataValues.Location = New System.Drawing.Point(224, 77)
        Me.ucrChkRestrictDataValues.Name = "ucrChkRestrictDataValues"
        Me.ucrChkRestrictDataValues.Size = New System.Drawing.Size(123, 20)
        Me.ucrChkRestrictDataValues.TabIndex = 3
        '
        'ucrInputMLE
        '
        Me.ucrInputMLE.bAddRemoveParameter = True
        Me.ucrInputMLE.bChangeParameterValue = True
        Me.ucrInputMLE.IsReadOnly = False
        Me.ucrInputMLE.Location = New System.Drawing.Point(204, 19)
        Me.ucrInputMLE.Name = "ucrInputMLE"
        Me.ucrInputMLE.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputMLE.TabIndex = 2
        '
        'ucrInputMOM
        '
        Me.ucrInputMOM.bAddRemoveParameter = True
        Me.ucrInputMOM.bChangeParameterValue = True
        Me.ucrInputMOM.IsReadOnly = False
        Me.ucrInputMOM.Location = New System.Drawing.Point(184, 58)
        Me.ucrInputMOM.Name = "ucrInputMOM"
        Me.ucrInputMOM.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputMOM.TabIndex = 5
        '
        'ucrChkMOM
        '
        Me.ucrChkMOM.bAddRemoveParameter = True
        Me.ucrChkMOM.bChangeParameterValue = True
        Me.ucrChkMOM.Checked = False
        Me.ucrChkMOM.Location = New System.Drawing.Point(6, 59)
        Me.ucrChkMOM.Name = "ucrChkMOM"
        Me.ucrChkMOM.Size = New System.Drawing.Size(121, 20)
        Me.ucrChkMOM.TabIndex = 3
        '
        'ucrChkMLE
        '
        Me.ucrChkMLE.bAddRemoveParameter = True
        Me.ucrChkMLE.bChangeParameterValue = True
        Me.ucrChkMLE.Checked = False
        Me.ucrChkMLE.Location = New System.Drawing.Point(6, 23)
        Me.ucrChkMLE.Name = "ucrChkMLE"
        Me.ucrChkMLE.Size = New System.Drawing.Size(121, 20)
        Me.ucrChkMLE.TabIndex = 0
        '
        'ucrReceiverDataToFit
        '
        Me.ucrReceiverDataToFit.bAddRemoveParameter = True
        Me.ucrReceiverDataToFit.bChangeParameterValue = True
        Me.ucrReceiverDataToFit.frmParent = Me
        Me.ucrReceiverDataToFit.Location = New System.Drawing.Point(224, 39)
        Me.ucrReceiverDataToFit.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataToFit.Name = "ucrReceiverDataToFit"
        Me.ucrReceiverDataToFit.Selector = Nothing
        Me.ucrReceiverDataToFit.Size = New System.Drawing.Size(143, 26)
        Me.ucrReceiverDataToFit.TabIndex = 2
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bAddRemoveParameter = True
        Me.ucrAddRemove.bChangeParameterValue = True
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.Location = New System.Drawing.Point(9, 24)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(206, 135)
        Me.ucrAddRemove.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 290)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 51)
        Me.ucrBase.TabIndex = 12
        '
        'ucrPnlDistributions
        '
        Me.ucrPnlDistributions.bAddRemoveParameter = True
        Me.ucrPnlDistributions.bChangeParameterValue = True
        Me.ucrPnlDistributions.Location = New System.Drawing.Point(311, 212)
        Me.ucrPnlDistributions.Name = "ucrPnlDistributions"
        Me.ucrPnlDistributions.Size = New System.Drawing.Size(88, 66)
        Me.ucrPnlDistributions.TabIndex = 11
        '
        'dlgExtremes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 353)
        Me.Controls.Add(Me.ucrInputTo)
        Me.Controls.Add(Me.ucrInputFrom)
        Me.Controls.Add(Me.UcrDialogDisabled1)
        Me.Controls.Add(Me.ucrChkProbPlot)
        Me.Controls.Add(Me.ucrChkRestrictDataValues)
        Me.Controls.Add(Me.lblAnd)
        Me.Controls.Add(Me.lblBetween)
        Me.Controls.Add(Me.grpEstimationMethods)
        Me.Controls.Add(Me.lblDataToFit)
        Me.Controls.Add(Me.ucrReceiverDataToFit)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpDistributions)
        Me.Controls.Add(Me.ucrPnlDistributions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExtremes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Fit_an_Extreme_distribution"
        Me.Text = "Fit an Extreme Distribution"
        Me.grpDistributions.ResumeLayout(False)
        Me.grpDistributions.PerformLayout()
        Me.grpEstimationMethods.ResumeLayout(False)
        Me.grpEstimationMethods.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverDataToFit As ucrReceiverSingle
    Friend WithEvents lblDataToFit As Label
    Friend WithEvents grpDistributions As GroupBox
    Friend WithEvents rdoGEV As RadioButton
    Friend WithEvents rdoGumbel As RadioButton
    Friend WithEvents grpEstimationMethods As GroupBox
    Friend WithEvents lblSaveInMLE As Label
    Friend WithEvents lblBetween As Label
    Friend WithEvents lblAnd As Label
    Friend WithEvents UcrDialogDisabled1 As ucrDialogDisabled
    Friend WithEvents ucrChkProbPlot As ucrCheck
    Friend WithEvents ucrChkMOM As ucrCheck
    Friend WithEvents ucrChkMLE As ucrCheck
    Friend WithEvents ucrChkRestrictDataValues As ucrCheck
    Friend WithEvents lblSaveInMOM As Label
    Friend WithEvents ucrInputTo As ucrInputTextBox
    Friend WithEvents ucrInputFrom As ucrInputTextBox
    Friend WithEvents ucrInputMLE As ucrInputComboBox
    Friend WithEvents ucrInputMOM As ucrInputComboBox
    Friend WithEvents ucrPnlDistributions As UcrPanel
End Class
