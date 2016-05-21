<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCanonicalCorrelationAnalysis
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
        Me.lblYVariables = New System.Windows.Forms.Label()
        Me.lblXVariables = New System.Windows.Forms.Label()
        Me.cmdCCAOptions = New System.Windows.Forms.Button()
        Me.chkSaveResult = New System.Windows.Forms.CheckBox()
        Me.ucrReceiverXvariables = New instat.ucrReceiverMultiple()
        Me.ucrReceiverYvariables = New instat.ucrReceiverMultiple()
        Me.ucrSelectorCCA = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseCCA = New instat.ucrButtons()
        Me.ucrResultName = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'lblYVariables
        '
        Me.lblYVariables.AutoSize = True
        Me.lblYVariables.Location = New System.Drawing.Point(255, 25)
        Me.lblYVariables.Name = "lblYVariables"
        Me.lblYVariables.Size = New System.Drawing.Size(60, 13)
        Me.lblYVariables.TabIndex = 4
        Me.lblYVariables.Tag = "Y_Variables"
        Me.lblYVariables.Text = "Y Variables"
        '
        'lblXVariables
        '
        Me.lblXVariables.AutoSize = True
        Me.lblXVariables.Location = New System.Drawing.Point(255, 154)
        Me.lblXVariables.Name = "lblXVariables"
        Me.lblXVariables.Size = New System.Drawing.Size(60, 13)
        Me.lblXVariables.TabIndex = 5
        Me.lblXVariables.Tag = "X_Variables"
        Me.lblXVariables.Text = "X Variables"
        '
        'cmdCCAOptions
        '
        Me.cmdCCAOptions.Location = New System.Drawing.Point(10, 246)
        Me.cmdCCAOptions.Name = "cmdCCAOptions"
        Me.cmdCCAOptions.Size = New System.Drawing.Size(94, 23)
        Me.cmdCCAOptions.TabIndex = 7
        Me.cmdCCAOptions.Tag = "CCA_Options..."
        Me.cmdCCAOptions.Text = "CCA Options..."
        Me.cmdCCAOptions.UseVisualStyleBackColor = True
        '
        'chkSaveResult
        '
        Me.chkSaveResult.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkSaveResult.Location = New System.Drawing.Point(10, 212)
        Me.chkSaveResult.Name = "chkSaveResult"
        Me.chkSaveResult.Size = New System.Drawing.Size(90, 24)
        Me.chkSaveResult.TabIndex = 8
        Me.chkSaveResult.Tag = "Save_Result"
        Me.chkSaveResult.Text = "Save Result"
        Me.chkSaveResult.UseVisualStyleBackColor = True
        '
        'ucrReceiverXvariables
        '
        Me.ucrReceiverXvariables.Location = New System.Drawing.Point(257, 167)
        Me.ucrReceiverXvariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverXvariables.Name = "ucrReceiverXvariables"
        Me.ucrReceiverXvariables.Selector = Nothing
        Me.ucrReceiverXvariables.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverXvariables.TabIndex = 3
        '
        'ucrReceiverYvariables
        '
        Me.ucrReceiverYvariables.Location = New System.Drawing.Point(255, 46)
        Me.ucrReceiverYvariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYvariables.Name = "ucrReceiverYvariables"
        Me.ucrReceiverYvariables.Selector = Nothing
        Me.ucrReceiverYvariables.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverYvariables.TabIndex = 2
        '
        'ucrSelectorCCA
        '
        Me.ucrSelectorCCA.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorCCA.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCCA.Name = "ucrSelectorCCA"
        Me.ucrSelectorCCA.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorCCA.TabIndex = 1
        '
        'ucrBaseCCA
        '
        Me.ucrBaseCCA.Location = New System.Drawing.Point(10, 281)
        Me.ucrBaseCCA.Name = "ucrBaseCCA"
        Me.ucrBaseCCA.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseCCA.TabIndex = 0
        '
        'ucrResultName
        '
        Me.ucrResultName.Location = New System.Drawing.Point(106, 211)
        Me.ucrResultName.Name = "ucrResultName"
        Me.ucrResultName.Size = New System.Drawing.Size(145, 21)
        Me.ucrResultName.TabIndex = 10
        '
        'dlgCanonicalCorrelationAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 334)
        Me.Controls.Add(Me.ucrResultName)
        Me.Controls.Add(Me.chkSaveResult)
        Me.Controls.Add(Me.cmdCCAOptions)
        Me.Controls.Add(Me.lblXVariables)
        Me.Controls.Add(Me.lblYVariables)
        Me.Controls.Add(Me.ucrReceiverXvariables)
        Me.Controls.Add(Me.ucrReceiverYvariables)
        Me.Controls.Add(Me.ucrSelectorCCA)
        Me.Controls.Add(Me.ucrBaseCCA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgCanonicalCorrelationAnalysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Canonical_Correlation_Analysis"
        Me.Text = "Canonical Correlation Analysis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseCCA As ucrButtons
    Friend WithEvents ucrSelectorCCA As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverYvariables As ucrReceiverMultiple
    Friend WithEvents ucrReceiverXvariables As ucrReceiverMultiple
    Friend WithEvents lblYVariables As Label
    Friend WithEvents lblXVariables As Label
    Friend WithEvents cmdCCAOptions As Button
    Friend WithEvents chkSaveResult As CheckBox
    Friend WithEvents ucrResultName As ucrInputComboBox
End Class