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
        Me.ucrBaseCCA = New instat.ucrButtons()
        Me.ucrSelectorCCA = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverYvariables = New instat.ucrReceiverMultiple()
        Me.ucrReceiverXvariables = New instat.ucrReceiverMultiple()
        Me.lblYVariables = New System.Windows.Forms.Label()
        Me.lblXVariables = New System.Windows.Forms.Label()
        Me.cmdCCAOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrBaseCCA
        '
        Me.ucrBaseCCA.Location = New System.Drawing.Point(9, 289)
        Me.ucrBaseCCA.Name = "ucrBaseCCA"
        Me.ucrBaseCCA.Size = New System.Drawing.Size(410, 53)
        Me.ucrBaseCCA.TabIndex = 0
        '
        'ucrSelectorCCA
        '
        Me.ucrSelectorCCA.Location = New System.Drawing.Point(9, 36)
        Me.ucrSelectorCCA.Name = "ucrSelectorCCA"
        Me.ucrSelectorCCA.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorCCA.TabIndex = 1
        '
        'ucrReceiverYvariables
        '
        Me.ucrReceiverYvariables.Location = New System.Drawing.Point(307, 21)
        Me.ucrReceiverYvariables.Name = "ucrReceiverYvariables"
        Me.ucrReceiverYvariables.Selector = Nothing
        Me.ucrReceiverYvariables.Size = New System.Drawing.Size(121, 104)
        Me.ucrReceiverYvariables.TabIndex = 2
        '
        'ucrReceiverXvariables
        '
        Me.ucrReceiverXvariables.Location = New System.Drawing.Point(307, 150)
        Me.ucrReceiverXvariables.Name = "ucrReceiverXvariables"
        Me.ucrReceiverXvariables.Selector = Nothing
        Me.ucrReceiverXvariables.Size = New System.Drawing.Size(121, 104)
        Me.ucrReceiverXvariables.TabIndex = 3
        '
        'lblYVariables
        '
        Me.lblYVariables.AutoSize = True
        Me.lblYVariables.Location = New System.Drawing.Point(334, 5)
        Me.lblYVariables.Name = "lblYVariables"
        Me.lblYVariables.Size = New System.Drawing.Size(60, 13)
        Me.lblYVariables.TabIndex = 4
        Me.lblYVariables.Tag = "Y_Variables"
        Me.lblYVariables.Text = "Y Variables"
        '
        'lblXVariables
        '
        Me.lblXVariables.AutoSize = True
        Me.lblXVariables.Location = New System.Drawing.Point(334, 134)
        Me.lblXVariables.Name = "lblXVariables"
        Me.lblXVariables.Size = New System.Drawing.Size(60, 13)
        Me.lblXVariables.TabIndex = 5
        Me.lblXVariables.Tag = "X_Variables"
        Me.lblXVariables.Text = "X Variables"
        '
        'cmdCCAOptions
        '
        Me.cmdCCAOptions.Location = New System.Drawing.Point(316, 260)
        Me.cmdCCAOptions.Name = "cmdCCAOptions"
        Me.cmdCCAOptions.Size = New System.Drawing.Size(94, 23)
        Me.cmdCCAOptions.TabIndex = 7
        Me.cmdCCAOptions.Tag = "CCA_Options..."
        Me.cmdCCAOptions.Text = "CCA Options..."
        Me.cmdCCAOptions.UseVisualStyleBackColor = True
        '
        'dlgCanonicalCorrelationAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 339)
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
End Class