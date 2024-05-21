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
        Me.btnHeaderSubTitleFooterFormat = New System.Windows.Forms.Button()
        Me.btnHeaderTitleFooterFormat = New System.Windows.Forms.Button()
        Me.ucrInputHeaderSubtitleFooter = New instat.ucrInputTextBox()
        Me.ucrInputHeaderTitleFooter = New instat.ucrInputTextBox()
        Me.lblHeaderSubtitle = New System.Windows.Forms.Label()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHeaderSubTitleFooterFormat
        '
        Me.btnHeaderSubTitleFooterFormat.Location = New System.Drawing.Point(283, 101)
        Me.btnHeaderSubTitleFooterFormat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHeaderSubTitleFooterFormat.Name = "btnHeaderSubTitleFooterFormat"
        Me.btnHeaderSubTitleFooterFormat.Size = New System.Drawing.Size(112, 35)
        Me.btnHeaderSubTitleFooterFormat.TabIndex = 25
        Me.btnHeaderSubTitleFooterFormat.Text = "Format"
        Me.btnHeaderSubTitleFooterFormat.UseVisualStyleBackColor = True
        '
        'btnHeaderTitleFooterFormat
        '
        Me.btnHeaderTitleFooterFormat.Location = New System.Drawing.Point(283, 31)
        Me.btnHeaderTitleFooterFormat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHeaderTitleFooterFormat.Name = "btnHeaderTitleFooterFormat"
        Me.btnHeaderTitleFooterFormat.Size = New System.Drawing.Size(116, 35)
        Me.btnHeaderTitleFooterFormat.TabIndex = 24
        Me.btnHeaderTitleFooterFormat.Text = "Format"
        Me.btnHeaderTitleFooterFormat.UseVisualStyleBackColor = True
        '
        'ucrInputHeaderSubtitleFooter
        '
        Me.ucrInputHeaderSubtitleFooter.AddQuotesIfUnrecognised = True
        Me.ucrInputHeaderSubtitleFooter.AutoSize = True
        Me.ucrInputHeaderSubtitleFooter.IsMultiline = False
        Me.ucrInputHeaderSubtitleFooter.IsReadOnly = False
        Me.ucrInputHeaderSubtitleFooter.Location = New System.Drawing.Point(6, 106)
        Me.ucrInputHeaderSubtitleFooter.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputHeaderSubtitleFooter.Name = "ucrInputHeaderSubtitleFooter"
        Me.ucrInputHeaderSubtitleFooter.Size = New System.Drawing.Size(271, 32)
        Me.ucrInputHeaderSubtitleFooter.TabIndex = 23
        '
        'ucrInputHeaderTitleFooter
        '
        Me.ucrInputHeaderTitleFooter.AddQuotesIfUnrecognised = True
        Me.ucrInputHeaderTitleFooter.AutoSize = True
        Me.ucrInputHeaderTitleFooter.IsMultiline = False
        Me.ucrInputHeaderTitleFooter.IsReadOnly = False
        Me.ucrInputHeaderTitleFooter.Location = New System.Drawing.Point(6, 35)
        Me.ucrInputHeaderTitleFooter.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputHeaderTitleFooter.Name = "ucrInputHeaderTitleFooter"
        Me.ucrInputHeaderTitleFooter.Size = New System.Drawing.Size(271, 32)
        Me.ucrInputHeaderTitleFooter.TabIndex = 22
        '
        'lblHeaderSubtitle
        '
        Me.lblHeaderSubtitle.AutoSize = True
        Me.lblHeaderSubtitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeaderSubtitle.Location = New System.Drawing.Point(1, 82)
        Me.lblHeaderSubtitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeaderSubtitle.Name = "lblHeaderSubtitle"
        Me.lblHeaderSubtitle.Size = New System.Drawing.Size(118, 20)
        Me.lblHeaderSubtitle.TabIndex = 21
        Me.lblHeaderSubtitle.Text = "Subtitle Footer:"
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeaderTitle.Location = New System.Drawing.Point(1, 9)
        Me.lblHeaderTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(93, 20)
        Me.lblHeaderTitle.TabIndex = 20
        Me.lblHeaderTitle.Text = "Title Footer:"
        '
        'ucrHeader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnHeaderSubTitleFooterFormat)
        Me.Controls.Add(Me.btnHeaderTitleFooterFormat)
        Me.Controls.Add(Me.ucrInputHeaderSubtitleFooter)
        Me.Controls.Add(Me.ucrInputHeaderTitleFooter)
        Me.Controls.Add(Me.lblHeaderSubtitle)
        Me.Controls.Add(Me.lblHeaderTitle)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ucrHeader"
        Me.Size = New System.Drawing.Size(403, 142)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHeaderSubTitleFooterFormat As Button
    Friend WithEvents btnHeaderTitleFooterFormat As Button
    Friend WithEvents ucrInputHeaderSubtitleFooter As ucrInputTextBox
    Friend WithEvents ucrInputHeaderTitleFooter As ucrInputTextBox
    Friend WithEvents lblHeaderSubtitle As Label
    Friend WithEvents lblHeaderTitle As Label
End Class
