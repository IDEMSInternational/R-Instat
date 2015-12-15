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
        Me.ucrReceiveBoxplotVariable = New instat.ucrReceiverSingle()
        Me.lblDataToPlot = New System.Windows.Forms.Label()
        Me.chkByFactors = New System.Windows.Forms.CheckBox()
        Me.cboByFactors = New System.Windows.Forms.ComboBox()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.chkVariableWidth = New System.Windows.Forms.CheckBox()
        Me.chkHorizontalBoxplot = New System.Windows.Forms.CheckBox()
        Me.chkNotchedBoxplot = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'UcrAddRemove
        '
        Me.UcrAddRemove.Location = New System.Drawing.Point(12, 5)
        Me.UcrAddRemove.Name = "UcrAddRemove"
        Me.UcrAddRemove.Size = New System.Drawing.Size(211, 129)
        Me.UcrAddRemove.TabIndex = 6
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 256)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 4
        '
        'ucrReceiveBoxplotVariable
        '
        Me.ucrReceiveBoxplotVariable.Location = New System.Drawing.Point(237, 42)
        Me.ucrReceiveBoxplotVariable.Name = "ucrReceiveBoxplotVariable"
        Me.ucrReceiveBoxplotVariable.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiveBoxplotVariable.TabIndex = 7
        '
        'lblDataToPlot
        '
        Me.lblDataToPlot.AutoSize = True
        Me.lblDataToPlot.Location = New System.Drawing.Point(240, 26)
        Me.lblDataToPlot.Name = "lblDataToPlot"
        Me.lblDataToPlot.Size = New System.Drawing.Size(92, 13)
        Me.lblDataToPlot.TabIndex = 11
        Me.lblDataToPlot.Tag = "Data_to_be_plotted"
        Me.lblDataToPlot.Text = "Data to be plotted"
        '
        'chkByFactors
        '
        Me.chkByFactors.AutoSize = True
        Me.chkByFactors.Location = New System.Drawing.Point(22, 141)
        Me.chkByFactors.Name = "chkByFactors"
        Me.chkByFactors.Size = New System.Drawing.Size(79, 17)
        Me.chkByFactors.TabIndex = 12
        Me.chkByFactors.Tag = "By_factors"
        Me.chkByFactors.Text = "By factor(s)"
        Me.chkByFactors.UseVisualStyleBackColor = True
        '
        'cboByFactors
        '
        Me.cboByFactors.FormattingEnabled = True
        Me.cboByFactors.Location = New System.Drawing.Point(107, 139)
        Me.cboByFactors.Name = "cboByFactors"
        Me.cboByFactors.Size = New System.Drawing.Size(116, 21)
        Me.cboByFactors.TabIndex = 13
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(333, 218)
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
        Me.chkVariableWidth.Location = New System.Drawing.Point(22, 185)
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
        Me.chkHorizontalBoxplot.Location = New System.Drawing.Point(22, 224)
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
        Me.chkNotchedBoxplot.Location = New System.Drawing.Point(166, 185)
        Me.chkNotchedBoxplot.Name = "chkNotchedBoxplot"
        Me.chkNotchedBoxplot.Size = New System.Drawing.Size(104, 17)
        Me.chkNotchedBoxplot.TabIndex = 17
        Me.chkNotchedBoxplot.Tag = "Notched_boxplot"
        Me.chkNotchedBoxplot.Text = "Notched boxplot"
        Me.chkNotchedBoxplot.UseVisualStyleBackColor = True
        '
        'dlgBoxPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 300)
        Me.Controls.Add(Me.chkNotchedBoxplot)
        Me.Controls.Add(Me.chkHorizontalBoxplot)
        Me.Controls.Add(Me.chkVariableWidth)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cboByFactors)
        Me.Controls.Add(Me.chkByFactors)
        Me.Controls.Add(Me.lblDataToPlot)
        Me.Controls.Add(Me.ucrReceiveBoxplotVariable)
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
    Friend WithEvents ucrReceiveBoxplotVariable As ucrReceiverSingle
    Friend WithEvents lblDataToPlot As Label
    Friend WithEvents chkByFactors As CheckBox
    Friend WithEvents cboByFactors As ComboBox
    Friend WithEvents cmdOptions As Button
    Friend WithEvents chkVariableWidth As CheckBox
    Friend WithEvents chkHorizontalBoxplot As CheckBox
    Friend WithEvents chkNotchedBoxplot As CheckBox
End Class
