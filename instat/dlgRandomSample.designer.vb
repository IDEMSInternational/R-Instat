<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRandomSample
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
        Me.chkPlot = New System.Windows.Forms.CheckBox()
        Me.lblSeed = New System.Windows.Forms.Label()
        Me.txtSeed = New System.Windows.Forms.TextBox()
        Me.ucrDistWithParameters = New instat.ucrDistributionsWithParameters()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFrameSelector = New instat.ucrDataFrame()
        Me.ucrNewColumnNameSelector = New instat.ucrNewColumnName()
        Me.SuspendLayout()
        '
        'chkPlot
        '
        Me.chkPlot.AutoSize = True
        Me.chkPlot.Location = New System.Drawing.Point(190, 268)
        Me.chkPlot.Name = "chkPlot"
        Me.chkPlot.Size = New System.Drawing.Size(44, 17)
        Me.chkPlot.TabIndex = 4
        Me.chkPlot.Tag = "Plot"
        Me.chkPlot.Text = "Plot"
        Me.chkPlot.UseVisualStyleBackColor = True
        '
        'lblSeed
        '
        Me.lblSeed.AutoSize = True
        Me.lblSeed.Location = New System.Drawing.Point(276, 269)
        Me.lblSeed.Name = "lblSeed"
        Me.lblSeed.Size = New System.Drawing.Size(32, 13)
        Me.lblSeed.TabIndex = 5
        Me.lblSeed.Tag = "Seed"
        Me.lblSeed.Text = "Seed"
        '
        'txtSeed
        '
        Me.txtSeed.Location = New System.Drawing.Point(315, 262)
        Me.txtSeed.Name = "txtSeed"
        Me.txtSeed.Size = New System.Drawing.Size(47, 20)
        Me.txtSeed.TabIndex = 6
        '
        'ucrDistWithParameters
        '
        Me.ucrDistWithParameters.Location = New System.Drawing.Point(6, 45)
        Me.ucrDistWithParameters.Name = "ucrDistWithParameters"
        Me.ucrDistWithParameters.Size = New System.Drawing.Size(221, 156)
        Me.ucrDistWithParameters.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 286)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 55)
        Me.ucrBase.TabIndex = 0
        '
        'ucrDataFrameSelector
        '
        Me.ucrDataFrameSelector.Location = New System.Drawing.Point(3, 2)
        Me.ucrDataFrameSelector.Name = "ucrDataFrameSelector"
        Me.ucrDataFrameSelector.Size = New System.Drawing.Size(127, 41)
        Me.ucrDataFrameSelector.TabIndex = 8
        '
        'ucrNewColumnNameSelector
        '
        Me.ucrNewColumnNameSelector.Location = New System.Drawing.Point(3, 226)
        Me.ucrNewColumnNameSelector.Name = "ucrNewColumnNameSelector"
        Me.ucrNewColumnNameSelector.Size = New System.Drawing.Size(376, 35)
        Me.ucrNewColumnNameSelector.TabIndex = 9
        '
        'dlgRandomSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 342)
        Me.Controls.Add(Me.ucrNewColumnNameSelector)
        Me.Controls.Add(Me.ucrDataFrameSelector)
        Me.Controls.Add(Me.ucrDistWithParameters)
        Me.Controls.Add(Me.txtSeed)
        Me.Controls.Add(Me.lblSeed)
        Me.Controls.Add(Me.chkPlot)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRandomSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate Random Sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkPlot As CheckBox
    Friend WithEvents lblSeed As Label
    Friend WithEvents txtSeed As TextBox
    Friend WithEvents ucrDistWithParameters As ucrDistributionsWithParameters
    Friend WithEvents ucrDataFrameSelector As ucrDataFrame
    Friend WithEvents ucrNewColumnNameSelector As ucrNewColumnName
End Class
