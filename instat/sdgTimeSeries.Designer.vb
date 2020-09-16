<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgTimeSeries
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
        Me.Summaries = New System.Windows.Forms.GroupBox()
        Me.UcrCheck6 = New instat.ucrCheck()
        Me.UcrCheck5 = New instat.ucrCheck()
        Me.UcrCheck4 = New instat.ucrCheck()
        Me.UcrCheck3 = New instat.ucrCheck()
        Me.UcrCheck2 = New instat.ucrCheck()
        Me.UcrCheck1 = New instat.ucrCheck()
        Me.ucrInputSeparator = New System.Windows.Forms.TextBox()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblFontSize = New System.Windows.Forms.Label()
        Me.ucrInputPosition = New instat.ucrInputComboBox()
        Me.ucrInputFontSize = New System.Windows.Forms.TextBox()
        Me.ucrButtonsSummaries = New instat.ucrButtonsSubdialogue()
        Me.Summaries.SuspendLayout()
        Me.SuspendLayout()
        '
        'Summaries
        '
        Me.Summaries.Controls.Add(Me.UcrCheck6)
        Me.Summaries.Controls.Add(Me.UcrCheck5)
        Me.Summaries.Controls.Add(Me.UcrCheck4)
        Me.Summaries.Controls.Add(Me.UcrCheck3)
        Me.Summaries.Controls.Add(Me.UcrCheck2)
        Me.Summaries.Controls.Add(Me.UcrCheck1)
        Me.Summaries.Location = New System.Drawing.Point(11, 13)
        Me.Summaries.Name = "Summaries"
        Me.Summaries.Size = New System.Drawing.Size(332, 139)
        Me.Summaries.TabIndex = 0
        Me.Summaries.TabStop = False
        Me.Summaries.Text = "grpSummaries"
        '
        'UcrCheck6
        '
        Me.UcrCheck6.Checked = False
        Me.UcrCheck6.Location = New System.Drawing.Point(219, 65)
        Me.UcrCheck6.Name = "UcrCheck6"
        Me.UcrCheck6.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck6.TabIndex = 5
        '
        'UcrCheck5
        '
        Me.UcrCheck5.Checked = False
        Me.UcrCheck5.Location = New System.Drawing.Point(113, 65)
        Me.UcrCheck5.Name = "UcrCheck5"
        Me.UcrCheck5.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck5.TabIndex = 4
        '
        'UcrCheck4
        '
        Me.UcrCheck4.Checked = False
        Me.UcrCheck4.Location = New System.Drawing.Point(7, 65)
        Me.UcrCheck4.Name = "UcrCheck4"
        Me.UcrCheck4.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck4.TabIndex = 3
        '
        'UcrCheck3
        '
        Me.UcrCheck3.Checked = False
        Me.UcrCheck3.Location = New System.Drawing.Point(219, 29)
        Me.UcrCheck3.Name = "UcrCheck3"
        Me.UcrCheck3.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck3.TabIndex = 2
        '
        'UcrCheck2
        '
        Me.UcrCheck2.Checked = False
        Me.UcrCheck2.Location = New System.Drawing.Point(113, 29)
        Me.UcrCheck2.Name = "UcrCheck2"
        Me.UcrCheck2.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck2.TabIndex = 1
        '
        'UcrCheck1
        '
        Me.UcrCheck1.Checked = False
        Me.UcrCheck1.Location = New System.Drawing.Point(7, 29)
        Me.UcrCheck1.Name = "UcrCheck1"
        Me.UcrCheck1.Size = New System.Drawing.Size(100, 20)
        Me.UcrCheck1.TabIndex = 0
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.Location = New System.Drawing.Point(87, 167)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(100, 20)
        Me.ucrInputSeparator.TabIndex = 1
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(13, 170)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(56, 13)
        Me.lblSeparator.TabIndex = 2
        Me.lblSeparator.Text = "Separator:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(22, 203)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblPosition.TabIndex = 3
        Me.lblPosition.Text = "Position:"
        '
        'lblFontSize
        '
        Me.lblFontSize.AutoSize = True
        Me.lblFontSize.Location = New System.Drawing.Point(15, 238)
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(54, 13)
        Me.lblFontSize.TabIndex = 4
        Me.lblFontSize.Text = "Font Size:"
        '
        'ucrInputPosition
        '
        Me.ucrInputPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputPosition.GetSetSelectedIndex = -1
        Me.ucrInputPosition.IsReadOnly = False
        Me.ucrInputPosition.Location = New System.Drawing.Point(87, 200)
        Me.ucrInputPosition.Name = "ucrInputPosition"
        Me.ucrInputPosition.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputPosition.TabIndex = 5
        '
        'ucrInputFontSize
        '
        Me.ucrInputFontSize.Location = New System.Drawing.Point(87, 231)
        Me.ucrInputFontSize.Name = "ucrInputFontSize"
        Me.ucrInputFontSize.Size = New System.Drawing.Size(100, 20)
        Me.ucrInputFontSize.TabIndex = 6
        '
        'ucrButtonsSummaries
        '
        Me.ucrButtonsSummaries.Location = New System.Drawing.Point(96, 277)
        Me.ucrButtonsSummaries.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrButtonsSummaries.Name = "ucrButtonsSummaries"
        Me.ucrButtonsSummaries.Size = New System.Drawing.Size(150, 31)
        Me.ucrButtonsSummaries.TabIndex = 7
        '
        'sdgTimeSeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 321)
        Me.Controls.Add(Me.ucrButtonsSummaries)
        Me.Controls.Add(Me.ucrInputFontSize)
        Me.Controls.Add(Me.ucrInputPosition)
        Me.Controls.Add(Me.lblFontSize)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.ucrInputSeparator)
        Me.Controls.Add(Me.Summaries)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgTimeSeries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summaries"
        Me.Summaries.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Summaries As GroupBox
    Friend WithEvents UcrCheck6 As ucrCheck
    Friend WithEvents UcrCheck5 As ucrCheck
    Friend WithEvents UcrCheck4 As ucrCheck
    Friend WithEvents UcrCheck3 As ucrCheck
    Friend WithEvents UcrCheck2 As ucrCheck
    Friend WithEvents UcrCheck1 As ucrCheck
    Friend WithEvents ucrInputSeparator As TextBox
    Friend WithEvents lblSeparator As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblFontSize As Label
    Friend WithEvents ucrInputPosition As ucrInputComboBox
    Friend WithEvents ucrInputFontSize As TextBox
    Friend WithEvents ucrButtonsSummaries As ucrButtonsSubdialogue
End Class
