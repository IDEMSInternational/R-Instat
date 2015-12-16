<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgBoxPlot
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
        Me.UcrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblYvarToPlot = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.chkVariableWidth = New System.Windows.Forms.CheckBox()
        Me.chkHorizontalBoxplot = New System.Windows.Forms.CheckBox()
        Me.chkNotchedBoxplot = New System.Windows.Forms.CheckBox()
        Me.ucrReceiverDataToPlot = New instat.ucrReceiverMultiple()
        Me.UcrReceiverSingle1 = New instat.ucrReceiverSingle()
        Me.lblByFactors = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UcrAddRemove
        '
        Me.UcrAddRemove.Location = New System.Drawing.Point(3, 9)
        Me.UcrAddRemove.Name = "UcrAddRemove"
        Me.UcrAddRemove.Size = New System.Drawing.Size(211, 129)
        Me.UcrAddRemove.TabIndex = 6
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(3, 282)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 4
        '
        'lblYvarToPlot
        '
        Me.lblYvarToPlot.AutoSize = True
        Me.lblYvarToPlot.Location = New System.Drawing.Point(238, 9)
        Me.lblYvarToPlot.Name = "lblYvarToPlot"
        Me.lblYvarToPlot.Size = New System.Drawing.Size(91, 13)
        Me.lblYvarToPlot.TabIndex = 11
        Me.lblYvarToPlot.Tag = "Y_variables_to_plot"
        Me.lblYvarToPlot.Text = "Y variables to plot"
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(328, 249)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 14
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'chkVariableWidth
        '
        Me.chkVariableWidth.AutoSize = True
        Me.chkVariableWidth.Location = New System.Drawing.Point(12, 165)
        Me.chkVariableWidth.Name = "chkVariableWidth"
        Me.chkVariableWidth.Size = New System.Drawing.Size(92, 17)
        Me.chkVariableWidth.TabIndex = 15
        Me.chkVariableWidth.Tag = "Variable_width"
        Me.chkVariableWidth.Text = "Variable width"
        Me.chkVariableWidth.UseVisualStyleBackColor = True
        '
        'chkHorizontalBoxplot
        '
        Me.chkHorizontalBoxplot.AutoSize = True
        Me.chkHorizontalBoxplot.Location = New System.Drawing.Point(12, 209)
        Me.chkHorizontalBoxplot.Name = "chkHorizontalBoxplot"
        Me.chkHorizontalBoxplot.Size = New System.Drawing.Size(110, 17)
        Me.chkHorizontalBoxplot.TabIndex = 16
        Me.chkHorizontalBoxplot.Tag = "Horizontal_boxplot"
        Me.chkHorizontalBoxplot.Text = "Horizontal boxplot"
        Me.chkHorizontalBoxplot.UseVisualStyleBackColor = True
        '
        'chkNotchedBoxplot
        '
        Me.chkNotchedBoxplot.AutoSize = True
        Me.chkNotchedBoxplot.Location = New System.Drawing.Point(12, 249)
        Me.chkNotchedBoxplot.Name = "chkNotchedBoxplot"
        Me.chkNotchedBoxplot.Size = New System.Drawing.Size(104, 17)
        Me.chkNotchedBoxplot.TabIndex = 17
        Me.chkNotchedBoxplot.Tag = "Notched_boxplot"
        Me.chkNotchedBoxplot.Text = "Notched boxplot"
        Me.chkNotchedBoxplot.UseVisualStyleBackColor = True
        '
        'ucrReceiverDataToPlot
        '
        Me.ucrReceiverDataToPlot.Location = New System.Drawing.Point(224, 25)
        Me.ucrReceiverDataToPlot.Name = "ucrReceiverDataToPlot"
        Me.ucrReceiverDataToPlot.Size = New System.Drawing.Size(121, 133)
        Me.ucrReceiverDataToPlot.TabIndex = 18
        '
        'UcrReceiverSingle1
        '
        Me.UcrReceiverSingle1.Location = New System.Drawing.Point(224, 185)
        Me.UcrReceiverSingle1.Name = "UcrReceiverSingle1"
        Me.UcrReceiverSingle1.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle1.TabIndex = 19
        '
        'lblByFactors
        '
        Me.lblByFactors.AutoSize = True
        Me.lblByFactors.Location = New System.Drawing.Point(226, 169)
        Me.lblByFactors.Name = "lblByFactors"
        Me.lblByFactors.Size = New System.Drawing.Size(60, 13)
        Me.lblByFactors.TabIndex = 20
        Me.lblByFactors.Text = "By factor(s)"
        '
        'dlgBoxPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 320)
        Me.Controls.Add(Me.lblByFactors)
        Me.Controls.Add(Me.UcrReceiverSingle1)
        Me.Controls.Add(Me.ucrReceiverDataToPlot)
        Me.Controls.Add(Me.chkNotchedBoxplot)
        Me.Controls.Add(Me.chkHorizontalBoxplot)
        Me.Controls.Add(Me.chkVariableWidth)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblYvarToPlot)
        Me.Controls.Add(Me.UcrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBoxPlot"
        Me.ShowIcon = False
        Me.Text = "Boxplot"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents UcrAddRemove As ucrSelectorAddRemove
    Friend WithEvents lblYvarToPlot As Label
    Friend WithEvents cmdOptions As Button
    Friend WithEvents chkVariableWidth As CheckBox
    Friend WithEvents chkHorizontalBoxplot As CheckBox
    Friend WithEvents chkNotchedBoxplot As CheckBox
    Friend WithEvents ucrReceiverDataToPlot As ucrReceiverMultiple
    Friend WithEvents UcrReceiverSingle1 As ucrReceiverSingle
    Friend WithEvents lblByFactors As Label
End Class
