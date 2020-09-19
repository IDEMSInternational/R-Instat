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
        Me.grpSummaries = New System.Windows.Forms.GroupBox()
        Me.ucrChkKge = New instat.ucrCheck()
        Me.ucrChkRmse = New instat.ucrCheck()
        Me.ucrChkMae = New instat.ucrCheck()
        Me.ucrChkMe = New instat.ucrCheck()
        Me.ucrChkRSd = New instat.ucrCheck()
        Me.ucrChkPBias = New instat.ucrCheck()
        Me.ucrChkCor = New instat.ucrCheck()
        Me.ucrChkN = New instat.ucrCheck()
        Me.ucrInputSeparator = New System.Windows.Forms.TextBox()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblFontSize = New System.Windows.Forms.Label()
        Me.ucrInputPosition = New instat.ucrInputComboBox()
        Me.ucrInputFontSize = New System.Windows.Forms.TextBox()
        Me.ucrButtonsSummaries = New instat.ucrButtonsSubdialogue()
        Me.grpSummaries.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSummaries
        '
        Me.grpSummaries.Controls.Add(Me.ucrChkKge)
        Me.grpSummaries.Controls.Add(Me.ucrChkRmse)
        Me.grpSummaries.Controls.Add(Me.ucrChkMae)
        Me.grpSummaries.Controls.Add(Me.ucrChkMe)
        Me.grpSummaries.Controls.Add(Me.ucrChkRSd)
        Me.grpSummaries.Controls.Add(Me.ucrChkPBias)
        Me.grpSummaries.Controls.Add(Me.ucrChkCor)
        Me.grpSummaries.Controls.Add(Me.ucrChkN)
        Me.grpSummaries.Location = New System.Drawing.Point(11, 13)
        Me.grpSummaries.Name = "grpSummaries"
        Me.grpSummaries.Size = New System.Drawing.Size(294, 112)
        Me.grpSummaries.TabIndex = 0
        Me.grpSummaries.TabStop = False
        Me.grpSummaries.Text = "Annotated Summaries"
        '
        'ucrChkKge
        '
        Me.ucrChkKge.Checked = False
        Me.ucrChkKge.Location = New System.Drawing.Point(224, 67)
        Me.ucrChkKge.Name = "ucrChkKge"
        Me.ucrChkKge.Size = New System.Drawing.Size(60, 20)
        Me.ucrChkKge.TabIndex = 10
        '
        'ucrChkRmse
        '
        Me.ucrChkRmse.Checked = False
        Me.ucrChkRmse.Location = New System.Drawing.Point(153, 67)
        Me.ucrChkRmse.Name = "ucrChkRmse"
        Me.ucrChkRmse.Size = New System.Drawing.Size(60, 20)
        Me.ucrChkRmse.TabIndex = 9
        '
        'ucrChkMae
        '
        Me.ucrChkMae.Checked = False
        Me.ucrChkMae.Location = New System.Drawing.Point(82, 67)
        Me.ucrChkMae.Name = "ucrChkMae"
        Me.ucrChkMae.Size = New System.Drawing.Size(60, 20)
        Me.ucrChkMae.TabIndex = 8
        '
        'ucrChkMe
        '
        Me.ucrChkMe.Checked = False
        Me.ucrChkMe.Location = New System.Drawing.Point(11, 67)
        Me.ucrChkMe.Name = "ucrChkMe"
        Me.ucrChkMe.Size = New System.Drawing.Size(60, 20)
        Me.ucrChkMe.TabIndex = 7
        '
        'ucrChkRSd
        '
        Me.ucrChkRSd.Checked = False
        Me.ucrChkRSd.Location = New System.Drawing.Point(224, 29)
        Me.ucrChkRSd.Name = "ucrChkRSd"
        Me.ucrChkRSd.Size = New System.Drawing.Size(60, 20)
        Me.ucrChkRSd.TabIndex = 6
        '
        'ucrChkPBias
        '
        Me.ucrChkPBias.Checked = False
        Me.ucrChkPBias.Location = New System.Drawing.Point(153, 29)
        Me.ucrChkPBias.Name = "ucrChkPBias"
        Me.ucrChkPBias.Size = New System.Drawing.Size(60, 20)
        Me.ucrChkPBias.TabIndex = 2
        '
        'ucrChkCor
        '
        Me.ucrChkCor.Checked = False
        Me.ucrChkCor.Location = New System.Drawing.Point(82, 29)
        Me.ucrChkCor.Name = "ucrChkCor"
        Me.ucrChkCor.Size = New System.Drawing.Size(60, 20)
        Me.ucrChkCor.TabIndex = 1
        '
        'ucrChkN
        '
        Me.ucrChkN.Checked = False
        Me.ucrChkN.Location = New System.Drawing.Point(11, 29)
        Me.ucrChkN.Name = "ucrChkN"
        Me.ucrChkN.Size = New System.Drawing.Size(60, 20)
        Me.ucrChkN.TabIndex = 0
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.Location = New System.Drawing.Point(89, 136)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(43, 20)
        Me.ucrInputSeparator.TabIndex = 1
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(11, 140)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(56, 13)
        Me.lblSeparator.TabIndex = 2
        Me.lblSeparator.Text = "Separator:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(11, 171)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblPosition.TabIndex = 3
        Me.lblPosition.Text = "Position:"
        '
        'lblFontSize
        '
        Me.lblFontSize.AutoSize = True
        Me.lblFontSize.Location = New System.Drawing.Point(11, 203)
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
        Me.ucrInputPosition.Location = New System.Drawing.Point(89, 167)
        Me.ucrInputPosition.Name = "ucrInputPosition"
        Me.ucrInputPosition.Size = New System.Drawing.Size(100, 21)
        Me.ucrInputPosition.TabIndex = 5
        '
        'ucrInputFontSize
        '
        Me.ucrInputFontSize.Location = New System.Drawing.Point(89, 199)
        Me.ucrInputFontSize.Name = "ucrInputFontSize"
        Me.ucrInputFontSize.Size = New System.Drawing.Size(100, 20)
        Me.ucrInputFontSize.TabIndex = 6
        '
        'ucrButtonsSummaries
        '
        Me.ucrButtonsSummaries.Location = New System.Drawing.Point(82, 241)
        Me.ucrButtonsSummaries.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrButtonsSummaries.Name = "ucrButtonsSummaries"
        Me.ucrButtonsSummaries.Size = New System.Drawing.Size(150, 31)
        Me.ucrButtonsSummaries.TabIndex = 7
        '
        'sdgTimeSeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 276)
        Me.Controls.Add(Me.ucrButtonsSummaries)
        Me.Controls.Add(Me.ucrInputFontSize)
        Me.Controls.Add(Me.ucrInputPosition)
        Me.Controls.Add(Me.lblFontSize)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.ucrInputSeparator)
        Me.Controls.Add(Me.grpSummaries)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgTimeSeries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summaries"
        Me.grpSummaries.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSummaries As GroupBox
    Friend WithEvents ucrChkPBias As ucrCheck
    Friend WithEvents ucrChkCor As ucrCheck
    Friend WithEvents ucrChkN As ucrCheck
    Friend WithEvents ucrInputSeparator As TextBox
    Friend WithEvents lblSeparator As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblFontSize As Label
    Friend WithEvents ucrInputPosition As ucrInputComboBox
    Friend WithEvents ucrInputFontSize As TextBox
    Friend WithEvents ucrButtonsSummaries As ucrButtonsSubdialogue
    Friend WithEvents ucrChkKge As ucrCheck
    Friend WithEvents ucrChkRmse As ucrCheck
    Friend WithEvents ucrChkMae As ucrCheck
    Friend WithEvents ucrChkMe As ucrCheck
    Friend WithEvents ucrChkRSd As ucrCheck
End Class
