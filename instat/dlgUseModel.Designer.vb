<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgUseModel
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
        Me.lblRpackage = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.cmdTry = New System.Windows.Forms.Button()
        Me.cmdsummary = New System.Windows.Forms.Button()
        Me.cmdanova = New System.Windows.Forms.Button()
        Me.cmdresiduals = New System.Windows.Forms.Button()
        Me.grpgeneral = New System.Windows.Forms.GroupBox()
        Me.ucrSelectorUseModel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputTryMessage = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverForTestColumn = New instat.ucrReceiverExpression()
        Me.ucrInputComboRPackage = New instat.ucrInputComboBox()
        Me.grpPrediction = New System.Windows.Forms.GroupBox()
        Me.cmdPredict = New System.Windows.Forms.Button()
        Me.grpgeneral.SuspendLayout()
        Me.grpPrediction.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRpackage
        '
        Me.lblRpackage.AutoSize = True
        Me.lblRpackage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRpackage.Location = New System.Drawing.Point(283, 80)
        Me.lblRpackage.Name = "lblRpackage"
        Me.lblRpackage.Size = New System.Drawing.Size(63, 13)
        Me.lblRpackage.TabIndex = 6
        Me.lblRpackage.Text = "R package:"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblModel.Location = New System.Drawing.Point(39, 21)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(39, 13)
        Me.lblModel.TabIndex = 11
        Me.lblModel.Tag = "Test"
        Me.lblModel.Text = "Model:"
        '
        'cmdTry
        '
        Me.cmdTry.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTry.Location = New System.Drawing.Point(9, 293)
        Me.cmdTry.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTry.Name = "cmdTry"
        Me.cmdTry.Size = New System.Drawing.Size(74, 23)
        Me.cmdTry.TabIndex = 15
        Me.cmdTry.Text = "Try"
        Me.cmdTry.UseVisualStyleBackColor = True
        '
        'cmdsummary
        '
        Me.cmdsummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdsummary.Location = New System.Drawing.Point(72, 12)
        Me.cmdsummary.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdsummary.Name = "cmdsummary"
        Me.cmdsummary.Size = New System.Drawing.Size(69, 30)
        Me.cmdsummary.TabIndex = 126
        Me.cmdsummary.Text = "summary"
        Me.cmdsummary.UseVisualStyleBackColor = True
        '
        'cmdanova
        '
        Me.cmdanova.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdanova.Location = New System.Drawing.Point(3, 12)
        Me.cmdanova.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdanova.Name = "cmdanova"
        Me.cmdanova.Size = New System.Drawing.Size(69, 30)
        Me.cmdanova.TabIndex = 124
        Me.cmdanova.Text = "anova"
        Me.cmdanova.UseVisualStyleBackColor = True
        '
        'cmdresiduals
        '
        Me.cmdresiduals.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdresiduals.Location = New System.Drawing.Point(140, 12)
        Me.cmdresiduals.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdresiduals.Name = "cmdresiduals"
        Me.cmdresiduals.Size = New System.Drawing.Size(69, 30)
        Me.cmdresiduals.TabIndex = 153
        Me.cmdresiduals.Text = "residuals"
        Me.cmdresiduals.UseVisualStyleBackColor = True
        '
        'grpgeneral
        '
        Me.grpgeneral.Controls.Add(Me.cmdsummary)
        Me.grpgeneral.Controls.Add(Me.cmdanova)
        Me.grpgeneral.Controls.Add(Me.cmdresiduals)
        Me.grpgeneral.Location = New System.Drawing.Point(284, 121)
        Me.grpgeneral.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpgeneral.Name = "grpgeneral"
        Me.grpgeneral.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpgeneral.Size = New System.Drawing.Size(213, 47)
        Me.grpgeneral.TabIndex = 25
        Me.grpgeneral.TabStop = False
        Me.grpgeneral.Text = "General"
        '
        'ucrSelectorUseModel
        '
        Me.ucrSelectorUseModel.bDropUnusedFilterLevels = False
        Me.ucrSelectorUseModel.bShowHiddenColumns = False
        Me.ucrSelectorUseModel.bUseCurrentFilter = True
        Me.ucrSelectorUseModel.Location = New System.Drawing.Point(10, 68)
        Me.ucrSelectorUseModel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorUseModel.Name = "ucrSelectorUseModel"
        Me.ucrSelectorUseModel.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorUseModel.TabIndex = 26
        '
        'ucrInputTryMessage
        '
        Me.ucrInputTryMessage.AddQuotesIfUnrecognised = True
        Me.ucrInputTryMessage.IsMultiline = False
        Me.ucrInputTryMessage.IsReadOnly = True
        Me.ucrInputTryMessage.Location = New System.Drawing.Point(87, 294)
        Me.ucrInputTryMessage.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrInputTryMessage.Name = "ucrInputTryMessage"
        Me.ucrInputTryMessage.Size = New System.Drawing.Size(321, 22)
        Me.ucrInputTryMessage.TabIndex = 16
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 315)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 20
        '
        'ucrReceiverForTestColumn
        '
        Me.ucrReceiverForTestColumn.frmParent = Me
        Me.ucrReceiverForTestColumn.Location = New System.Drawing.Point(82, 17)
        Me.ucrReceiverForTestColumn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrReceiverForTestColumn.Name = "ucrReceiverForTestColumn"
        Me.ucrReceiverForTestColumn.Selector = Nothing
        Me.ucrReceiverForTestColumn.Size = New System.Drawing.Size(378, 27)
        Me.ucrReceiverForTestColumn.strNcFilePath = ""
        Me.ucrReceiverForTestColumn.TabIndex = 12
        Me.ucrReceiverForTestColumn.ucrSelector = Nothing
        '
        'ucrInputComboRPackage
        '
        Me.ucrInputComboRPackage.AddQuotesIfUnrecognised = True
        Me.ucrInputComboRPackage.IsReadOnly = False
        Me.ucrInputComboRPackage.Location = New System.Drawing.Point(352, 77)
        Me.ucrInputComboRPackage.Name = "ucrInputComboRPackage"
        Me.ucrInputComboRPackage.Size = New System.Drawing.Size(123, 21)
        Me.ucrInputComboRPackage.TabIndex = 5
        '
        'grpPrediction
        '
        Me.grpPrediction.Controls.Add(Me.cmdPredict)
        Me.grpPrediction.Location = New System.Drawing.Point(284, 121)
        Me.grpPrediction.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpPrediction.Name = "grpPrediction"
        Me.grpPrediction.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpPrediction.Size = New System.Drawing.Size(75, 47)
        Me.grpPrediction.TabIndex = 27
        Me.grpPrediction.TabStop = False
        Me.grpPrediction.Text = "Prediction"
        '
        'cmdPredict
        '
        Me.cmdPredict.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPredict.Location = New System.Drawing.Point(3, 12)
        Me.cmdPredict.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPredict.Name = "cmdPredict"
        Me.cmdPredict.Size = New System.Drawing.Size(69, 30)
        Me.cmdPredict.TabIndex = 124
        Me.cmdPredict.Text = "Predict"
        Me.cmdPredict.UseVisualStyleBackColor = True
        '
        'dlgUseModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 381)
        Me.Controls.Add(Me.grpPrediction)
        Me.Controls.Add(Me.ucrSelectorUseModel)
        Me.Controls.Add(Me.grpgeneral)
        Me.Controls.Add(Me.ucrInputTryMessage)
        Me.Controls.Add(Me.cmdTry)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.ucrReceiverForTestColumn)
        Me.Controls.Add(Me.lblRpackage)
        Me.Controls.Add(Me.ucrInputComboRPackage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "dlgUseModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dlgUseModel"
        Me.grpgeneral.ResumeLayout(False)
        Me.grpPrediction.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputComboRPackage As ucrInputComboBox
    Friend WithEvents lblRpackage As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents ucrReceiverForTestColumn As ucrReceiverExpression
    Friend WithEvents ucrInputTryMessage As ucrInputTextBox
    Friend WithEvents cmdTry As Button
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpgeneral As GroupBox
    Friend WithEvents cmdsummary As Button
    Friend WithEvents cmdanova As Button
    Friend WithEvents cmdresiduals As Button
    Friend WithEvents ucrSelectorUseModel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpPrediction As GroupBox
    Friend WithEvents cmdPredict As Button
End Class
