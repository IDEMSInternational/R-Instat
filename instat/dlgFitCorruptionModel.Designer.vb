﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFitCorruptionModel
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
        Me.ucrSelectorFitModel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverControlVariables = New instat.ucrReceiverMultiple()
        Me.ucrReceiverIndicators = New instat.ucrReceiverMultiple()
        Me.ucrReceiverOutput = New instat.ucrReceiverSingle()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.ucrInputModelPreview = New instat.ucrInputTextBox()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.ucrSaveCorruptionModel = New instat.ucrSave()
        Me.lblControlVariables = New System.Windows.Forms.Label()
        Me.lblCorruptionOutput = New System.Windows.Forms.Label()
        Me.lblIndicators = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrSelectorFitModel
        '
        Me.ucrSelectorFitModel.bShowHiddenColumns = False
        Me.ucrSelectorFitModel.bUseCurrentFilter = True
        Me.ucrSelectorFitModel.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorFitModel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFitModel.Name = "ucrSelectorFitModel"
        Me.ucrSelectorFitModel.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorFitModel.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 351)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 11
        '
        'ucrReceiverControlVariables
        '
        Me.ucrReceiverControlVariables.frmParent = Me
        Me.ucrReceiverControlVariables.Location = New System.Drawing.Point(265, 81)
        Me.ucrReceiverControlVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverControlVariables.Name = "ucrReceiverControlVariables"
        Me.ucrReceiverControlVariables.Selector = Nothing
        Me.ucrReceiverControlVariables.Size = New System.Drawing.Size(120, 85)
        Me.ucrReceiverControlVariables.TabIndex = 4
        '
        'ucrReceiverIndicators
        '
        Me.ucrReceiverIndicators.frmParent = Me
        Me.ucrReceiverIndicators.Location = New System.Drawing.Point(265, 191)
        Me.ucrReceiverIndicators.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverIndicators.Name = "ucrReceiverIndicators"
        Me.ucrReceiverIndicators.Selector = Nothing
        Me.ucrReceiverIndicators.Size = New System.Drawing.Size(120, 85)
        Me.ucrReceiverIndicators.TabIndex = 6
        '
        'ucrReceiverOutput
        '
        Me.ucrReceiverOutput.frmParent = Me
        Me.ucrReceiverOutput.Location = New System.Drawing.Point(265, 36)
        Me.ucrReceiverOutput.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOutput.Name = "ucrReceiverOutput"
        Me.ucrReceiverOutput.Selector = Nothing
        Me.ucrReceiverOutput.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverOutput.TabIndex = 2
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(305, 293)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(105, 23)
        Me.cmdDisplayOptions.TabIndex = 9
        Me.cmdDisplayOptions.Text = "Display Options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'ucrInputModelPreview
        '
        Me.ucrInputModelPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputModelPreview.IsMultiline = False
        Me.ucrInputModelPreview.IsReadOnly = False
        Me.ucrInputModelPreview.Location = New System.Drawing.Point(96, 294)
        Me.ucrInputModelPreview.Name = "ucrInputModelPreview"
        Me.ucrInputModelPreview.Size = New System.Drawing.Size(200, 21)
        Me.ucrInputModelPreview.TabIndex = 8
        '
        'lblModelPreview
        '
        Me.lblModelPreview.AutoSize = True
        Me.lblModelPreview.Location = New System.Drawing.Point(7, 297)
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Size = New System.Drawing.Size(80, 13)
        Me.lblModelPreview.TabIndex = 7
        Me.lblModelPreview.Text = "Model Preview:"
        '
        'ucrSaveCorruptionModel
        '
        Me.ucrSaveCorruptionModel.Location = New System.Drawing.Point(10, 323)
        Me.ucrSaveCorruptionModel.Name = "ucrSaveCorruptionModel"
        Me.ucrSaveCorruptionModel.Size = New System.Drawing.Size(288, 24)
        Me.ucrSaveCorruptionModel.TabIndex = 10
        '
        'lblControlVariables
        '
        Me.lblControlVariables.AutoSize = True
        Me.lblControlVariables.Location = New System.Drawing.Point(266, 66)
        Me.lblControlVariables.Name = "lblControlVariables"
        Me.lblControlVariables.Size = New System.Drawing.Size(89, 13)
        Me.lblControlVariables.TabIndex = 3
        Me.lblControlVariables.Text = "Control Variables:"
        '
        'lblCorruptionOutput
        '
        Me.lblCorruptionOutput.AutoSize = True
        Me.lblCorruptionOutput.Location = New System.Drawing.Point(266, 21)
        Me.lblCorruptionOutput.Name = "lblCorruptionOutput"
        Me.lblCorruptionOutput.Size = New System.Drawing.Size(93, 13)
        Me.lblCorruptionOutput.TabIndex = 1
        Me.lblCorruptionOutput.Text = "Corruption Output:"
        '
        'lblIndicators
        '
        Me.lblIndicators.AutoSize = True
        Me.lblIndicators.Location = New System.Drawing.Point(265, 176)
        Me.lblIndicators.Name = "lblIndicators"
        Me.lblIndicators.Size = New System.Drawing.Size(56, 13)
        Me.lblIndicators.TabIndex = 5
        Me.lblIndicators.Text = "Indicators:"
        '
        'dlgFitCorruptionModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 410)
        Me.Controls.Add(Me.lblIndicators)
        Me.Controls.Add(Me.lblCorruptionOutput)
        Me.Controls.Add(Me.lblControlVariables)
        Me.Controls.Add(Me.ucrSaveCorruptionModel)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrInputModelPreview)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.ucrReceiverOutput)
        Me.Controls.Add(Me.ucrReceiverIndicators)
        Me.Controls.Add(Me.ucrReceiverControlVariables)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorFitModel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFitCorruptionModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fit Model"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverControlVariables As ucrReceiverMultiple
    Friend WithEvents ucrReceiverOutput As ucrReceiverSingle
    Friend WithEvents ucrReceiverIndicators As ucrReceiverMultiple
    Friend WithEvents lblCorruptionOutput As Label
    Friend WithEvents lblControlVariables As Label
    Friend WithEvents ucrSaveCorruptionModel As ucrSave
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents ucrInputModelPreview As ucrInputTextBox
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents lblIndicators As Label
    Friend WithEvents ucrSelectorFitModel As ucrSelectorByDataFrameAddRemove
End Class
