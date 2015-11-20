<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDotPlot
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
        Me.lblPlotTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblVariableToPlot = New System.Windows.Forms.Label()
        Me.ucrAddRemove1 = New instat.ucrSelectorAddRemove()
        Me.crReciverSingle = New instat.ucrReciverSingleB()
        Me.SuspendLayout()
        '
        'lblPlotTitle
        '
        Me.lblPlotTitle.AutoSize = True
        Me.lblPlotTitle.Location = New System.Drawing.Point(12, 202)
        Me.lblPlotTitle.Name = "lblPlotTitle"
        Me.lblPlotTitle.Size = New System.Drawing.Size(51, 13)
        Me.lblPlotTitle.TabIndex = 1
        Me.lblPlotTitle.Text = "Plot Title "
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(82, 195)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(273, 20)
        Me.txtTitle.TabIndex = 2
        '
        'lblVariableToPlot
        '
        Me.lblVariableToPlot.AutoSize = True
        Me.lblVariableToPlot.Location = New System.Drawing.Point(250, 9)
        Me.lblVariableToPlot.Name = "lblVariableToPlot"
        Me.lblVariableToPlot.Size = New System.Drawing.Size(78, 13)
        Me.lblVariableToPlot.TabIndex = 5
        Me.lblVariableToPlot.Tag = "Variable_to_Plot"
        Me.lblVariableToPlot.Text = "Variable to Plot"
        '
        'ucrAddRemove1
        '
        Me.ucrAddRemove1.Location = New System.Drawing.Point(0, 26)
        Me.ucrAddRemove1.Name = "ucrAddRemove1"
        Me.ucrAddRemove1.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove1.TabIndex = 6
        '
        'crReciverSingle
        '
        Me.crReciverSingle.Location = New System.Drawing.Point(253, 26)
        Me.crReciverSingle.Name = "crReciverSingle"
        Me.crReciverSingle.Size = New System.Drawing.Size(106, 26)
        Me.crReciverSingle.TabIndex = 7
        '
        'dlgDotPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 250)
        Me.Controls.Add(Me.crReciverSingle)
        Me.Controls.Add(Me.ucrAddRemove1)
        Me.Controls.Add(Me.lblVariableToPlot)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblPlotTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDotPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dot_Plot"
        Me.Text = "Dox Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblPlotTitle As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverSingle As ucrReceiverSingle
    Friend WithEvents lblVariableToPlot As Label
    Friend WithEvents ucrAddRemove1 As ucrSelectorAddRemove
    Friend WithEvents crReciverSingle As ucrReciverSingleB
End Class
