<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCorrelations
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
        Me.grpData = New System.Windows.Forms.GroupBox()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.chkDisplayPValues = New System.Windows.Forms.CheckBox()
        Me.chkDisplayPlot = New System.Windows.Forms.CheckBox()
        Me.grpData.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpData
        '
        Me.grpData.Controls.Add(Me.lblSelectedVariables)
        Me.grpData.Controls.Add(Me.ucrReceiverMultiple)
        Me.grpData.Controls.Add(Me.ucrAddRemove)
        Me.grpData.Location = New System.Drawing.Point(17, 15)
        Me.grpData.Name = "grpData"
        Me.grpData.Size = New System.Drawing.Size(395, 172)
        Me.grpData.TabIndex = 0
        Me.grpData.TabStop = False
        Me.grpData.Tag = "Data"
        Me.grpData.Text = "Data"
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(236, 22)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(95, 13)
        Me.lblSelectedVariables.TabIndex = 2
        Me.lblSelectedVariables.Tag = "Selected_Variables"
        Me.lblSelectedVariables.Text = "Selected Variables"
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(232, 36)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(114, 101)
        Me.ucrReceiverMultiple.TabIndex = 1
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(6, 19)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(182, 118)
        Me.ucrAddRemove.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(3, 297)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(409, 32)
        Me.ucrBase.TabIndex = 1
        '
        'chkDisplayPValues
        '
        Me.chkDisplayPValues.AutoSize = True
        Me.chkDisplayPValues.Location = New System.Drawing.Point(17, 215)
        Me.chkDisplayPValues.Name = "chkDisplayPValues"
        Me.chkDisplayPValues.Size = New System.Drawing.Size(104, 17)
        Me.chkDisplayPValues.TabIndex = 2
        Me.chkDisplayPValues.Tag = "Diplay_P_Values"
        Me.chkDisplayPValues.Text = "Display P-values"
        Me.chkDisplayPValues.UseVisualStyleBackColor = True
        '
        'chkDisplayPlot
        '
        Me.chkDisplayPlot.AutoSize = True
        Me.chkDisplayPlot.Location = New System.Drawing.Point(17, 257)
        Me.chkDisplayPlot.Name = "chkDisplayPlot"
        Me.chkDisplayPlot.Size = New System.Drawing.Size(81, 17)
        Me.chkDisplayPlot.TabIndex = 3
        Me.chkDisplayPlot.Tag = "Display_Plot"
        Me.chkDisplayPlot.Text = "Display Plot"
        Me.chkDisplayPlot.UseVisualStyleBackColor = True
        '
        'dlgCorrelations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 341)
        Me.Controls.Add(Me.chkDisplayPlot)
        Me.Controls.Add(Me.chkDisplayPValues)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpData)
        Me.Name = "dlgCorrelations"
        Me.Tag = "Correlations"
        Me.Text = "Correlations"
        Me.grpData.ResumeLayout(False)
        Me.grpData.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpData As GroupBox
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents ucrReceiverMultiple As ucrReceiverMultiple
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkDisplayPValues As CheckBox
    Friend WithEvents chkDisplayPlot As CheckBox
End Class
