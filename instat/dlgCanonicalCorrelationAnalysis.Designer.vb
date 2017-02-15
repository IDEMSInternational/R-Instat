﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.ucrReceiverXvariables = New instat.ucrReceiverMultiple()
        Me.ucrReceiverYvariables = New instat.ucrReceiverMultiple()
        Me.ucrSelectorCCA = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveResult = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'lblYVariables
        '
        Me.lblYVariables.Location = New System.Drawing.Point(267, 168)
        Me.lblYVariables.Name = "lblYVariables"
        Me.lblYVariables.Size = New System.Drawing.Size(100, 19)
        Me.lblYVariables.TabIndex = 1
        Me.lblYVariables.Tag = "Y_Variables:"
        Me.lblYVariables.Text = "Y Variables:"
        '
        'lblXVariables
        '
        Me.lblXVariables.Location = New System.Drawing.Point(269, 45)
        Me.lblXVariables.Name = "lblXVariables"
        Me.lblXVariables.Size = New System.Drawing.Size(100, 23)
        Me.lblXVariables.TabIndex = 3
        Me.lblXVariables.Tag = "X_Variables:"
        Me.lblXVariables.Text = "X Variables:"
        '
        'cmdCCAOptions
        '
        Me.cmdCCAOptions.Location = New System.Drawing.Point(10, 204)
        Me.cmdCCAOptions.Name = "cmdCCAOptions"
        Me.cmdCCAOptions.Size = New System.Drawing.Size(120, 23)
        Me.cmdCCAOptions.TabIndex = 5
        Me.cmdCCAOptions.Tag = "CCA_Options..."
        Me.cmdCCAOptions.Text = "CCA Options.."
        Me.cmdCCAOptions.UseVisualStyleBackColor = True
        '
        'ucrReceiverXvariables
        '
        Me.ucrReceiverXvariables.frmParent = Me
        Me.ucrReceiverXvariables.Location = New System.Drawing.Point(266, 60)
        Me.ucrReceiverXvariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverXvariables.Name = "ucrReceiverXvariables"
        Me.ucrReceiverXvariables.Selector = Nothing
        Me.ucrReceiverXvariables.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverXvariables.TabIndex = 4
        '
        'ucrReceiverYvariables
        '
        Me.ucrReceiverYvariables.frmParent = Me
        Me.ucrReceiverYvariables.Location = New System.Drawing.Point(266, 183)
        Me.ucrReceiverYvariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYvariables.Name = "ucrReceiverYvariables"
        Me.ucrReceiverYvariables.Selector = Nothing
        Me.ucrReceiverYvariables.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverYvariables.TabIndex = 2
        '
        'ucrSelectorCCA
        '
        Me.ucrSelectorCCA.bShowHiddenColumns = False
        Me.ucrSelectorCCA.bUseCurrentFilter = True
        Me.ucrSelectorCCA.Location = New System.Drawing.Point(10, 9)
        Me.ucrSelectorCCA.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCCA.Name = "ucrSelectorCCA"
        Me.ucrSelectorCCA.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorCCA.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 299)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 7
        '
        'ucrSaveResult
        '
        Me.ucrSaveResult.Location = New System.Drawing.Point(10, 274)
        Me.ucrSaveResult.Name = "ucrSaveResult"
        Me.ucrSaveResult.Size = New System.Drawing.Size(253, 24)
        Me.ucrSaveResult.TabIndex = 6
        '
        'dlgCanonicalCorrelationAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 358)
        Me.Controls.Add(Me.ucrSaveResult)
        Me.Controls.Add(Me.ucrReceiverYvariables)
        Me.Controls.Add(Me.ucrReceiverXvariables)
        Me.Controls.Add(Me.lblYVariables)
        Me.Controls.Add(Me.cmdCCAOptions)
        Me.Controls.Add(Me.ucrSelectorCCA)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblXVariables)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCanonicalCorrelationAnalysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Canonical_Correlation_Analysis"
        Me.Text = "Canonical Correlations"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorCCA As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverYvariables As ucrReceiverMultiple
    Friend WithEvents ucrReceiverXvariables As ucrReceiverMultiple
    Friend WithEvents lblYVariables As Label
    Friend WithEvents lblXVariables As Label
    Friend WithEvents cmdCCAOptions As Button
    Friend WithEvents ucrSaveResult As ucrSave
End Class