<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrHeader
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnHeaderSubTitleFormat = New System.Windows.Forms.Button()
        Me.btnHeaderTitleFormat = New System.Windows.Forms.Button()
        Me.ucrInputHeaderSubtitleFooter = New instat.ucrInputTextBox()
        Me.ucrInputHeaderTitleFooter = New instat.ucrInputTextBox()
        Me.lblHeaderSubtitle = New System.Windows.Forms.Label()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHeaderSubTitleFormat
        '
        Me.btnHeaderSubTitleFormat.Location = New System.Drawing.Point(153, 67)
        Me.btnHeaderSubTitleFormat.Name = "btnHeaderSubTitleFormat"
        Me.btnHeaderSubTitleFormat.Size = New System.Drawing.Size(75, 23)
        Me.btnHeaderSubTitleFormat.TabIndex = 25
        Me.btnHeaderSubTitleFormat.Text = "Format"
        Me.btnHeaderSubTitleFormat.UseVisualStyleBackColor = True
        '
        'btnHeaderTitleFormat
        '
        Me.btnHeaderTitleFormat.Location = New System.Drawing.Point(153, 23)
        Me.btnHeaderTitleFormat.Name = "btnHeaderTitleFormat"
        Me.btnHeaderTitleFormat.Size = New System.Drawing.Size(79, 23)
        Me.btnHeaderTitleFormat.TabIndex = 24
        Me.btnHeaderTitleFormat.Text = "Format"
        Me.btnHeaderTitleFormat.UseVisualStyleBackColor = True
        '
        'ucrInputHeaderSubtitleFooter
        '
        Me.ucrInputHeaderSubtitleFooter.AddQuotesIfUnrecognised = True
        Me.ucrInputHeaderSubtitleFooter.AutoSize = True
        Me.ucrInputHeaderSubtitleFooter.IsMultiline = False
        Me.ucrInputHeaderSubtitleFooter.IsReadOnly = False
        Me.ucrInputHeaderSubtitleFooter.Location = New System.Drawing.Point(9, 69)
        Me.ucrInputHeaderSubtitleFooter.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputHeaderSubtitleFooter.Name = "ucrInputHeaderSubtitleFooter"
        Me.ucrInputHeaderSubtitleFooter.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputHeaderSubtitleFooter.TabIndex = 23
        '
        'ucrInputHeaderTitleFooter
        '
        Me.ucrInputHeaderTitleFooter.AddQuotesIfUnrecognised = True
        Me.ucrInputHeaderTitleFooter.AutoSize = True
        Me.ucrInputHeaderTitleFooter.IsMultiline = False
        Me.ucrInputHeaderTitleFooter.IsReadOnly = False
        Me.ucrInputHeaderTitleFooter.Location = New System.Drawing.Point(9, 23)
        Me.ucrInputHeaderTitleFooter.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputHeaderTitleFooter.Name = "ucrInputHeaderTitleFooter"
        Me.ucrInputHeaderTitleFooter.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputHeaderTitleFooter.TabIndex = 22
        '
        'lblHeaderSubtitle
        '
        Me.lblHeaderSubtitle.AutoSize = True
        Me.lblHeaderSubtitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeaderSubtitle.Location = New System.Drawing.Point(6, 53)
        Me.lblHeaderSubtitle.Name = "lblHeaderSubtitle"
        Me.lblHeaderSubtitle.Size = New System.Drawing.Size(78, 13)
        Me.lblHeaderSubtitle.TabIndex = 21
        Me.lblHeaderSubtitle.Text = "Subtitle Footer:"
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeaderTitle.Location = New System.Drawing.Point(6, 6)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(63, 13)
        Me.lblHeaderTitle.TabIndex = 20
        Me.lblHeaderTitle.Text = "Title Footer:"
        '
        'ucrHeader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnHeaderSubTitleFormat)
        Me.Controls.Add(Me.btnHeaderTitleFormat)
        Me.Controls.Add(Me.ucrInputHeaderSubtitleFooter)
        Me.Controls.Add(Me.ucrInputHeaderTitleFooter)
        Me.Controls.Add(Me.lblHeaderSubtitle)
        Me.Controls.Add(Me.lblHeaderTitle)
        Me.Name = "ucrHeader"
        Me.Size = New System.Drawing.Size(233, 92)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHeaderSubTitleFormat As Button
    Friend WithEvents btnHeaderTitleFormat As Button
    Friend WithEvents ucrInputHeaderSubtitleFooter As ucrInputTextBox
    Friend WithEvents ucrInputHeaderTitleFooter As ucrInputTextBox
    Friend WithEvents lblHeaderSubtitle As Label
    Friend WithEvents lblHeaderTitle As Label
End Class
