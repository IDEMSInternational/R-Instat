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
        Me.ucrInputSubtitleFooter = New instat.ucrInputTextBox()
        Me.ucrInputTitleFooter = New instat.ucrInputTextBox()
        Me.lblHeaderSubtitle = New System.Windows.Forms.Label()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.btnSubTitleStyle = New System.Windows.Forms.Button()
        Me.btnTitleStyle = New System.Windows.Forms.Button()
        Me.ucrInputSubtitle = New instat.ucrInputTextBox()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpBoxTitle = New System.Windows.Forms.GroupBox()
        Me.grpBoxSubtitle = New System.Windows.Forms.GroupBox()
        Me.grpBoxTitle.SuspendLayout()
        Me.grpBoxSubtitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrInputSubtitleFooter
        '
        Me.ucrInputSubtitleFooter.AddQuotesIfUnrecognised = True
        Me.ucrInputSubtitleFooter.AutoSize = True
        Me.ucrInputSubtitleFooter.IsMultiline = False
        Me.ucrInputSubtitleFooter.IsReadOnly = False
        Me.ucrInputSubtitleFooter.Location = New System.Drawing.Point(9, 88)
        Me.ucrInputSubtitleFooter.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSubtitleFooter.Name = "ucrInputSubtitleFooter"
        Me.ucrInputSubtitleFooter.Size = New System.Drawing.Size(361, 21)
        Me.ucrInputSubtitleFooter.TabIndex = 23
        '
        'ucrInputTitleFooter
        '
        Me.ucrInputTitleFooter.AddQuotesIfUnrecognised = True
        Me.ucrInputTitleFooter.AutoSize = True
        Me.ucrInputTitleFooter.IsMultiline = False
        Me.ucrInputTitleFooter.IsReadOnly = False
        Me.ucrInputTitleFooter.Location = New System.Drawing.Point(11, 89)
        Me.ucrInputTitleFooter.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputTitleFooter.Name = "ucrInputTitleFooter"
        Me.ucrInputTitleFooter.Size = New System.Drawing.Size(359, 21)
        Me.ucrInputTitleFooter.TabIndex = 22
        '
        'lblHeaderSubtitle
        '
        Me.lblHeaderSubtitle.AutoSize = True
        Me.lblHeaderSubtitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeaderSubtitle.Location = New System.Drawing.Point(6, 72)
        Me.lblHeaderSubtitle.Name = "lblHeaderSubtitle"
        Me.lblHeaderSubtitle.Size = New System.Drawing.Size(78, 13)
        Me.lblHeaderSubtitle.TabIndex = 21
        Me.lblHeaderSubtitle.Text = "Subtitle Footer:"
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeaderTitle.Location = New System.Drawing.Point(8, 72)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(63, 13)
        Me.lblHeaderTitle.TabIndex = 20
        Me.lblHeaderTitle.Text = "Title Footer:"
        '
        'btnSubTitleStyle
        '
        Me.btnSubTitleStyle.Location = New System.Drawing.Point(372, 40)
        Me.btnSubTitleStyle.Name = "btnSubTitleStyle"
        Me.btnSubTitleStyle.Size = New System.Drawing.Size(75, 23)
        Me.btnSubTitleStyle.TabIndex = 31
        Me.btnSubTitleStyle.Text = "Style"
        Me.btnSubTitleStyle.UseVisualStyleBackColor = True
        '
        'btnTitleStyle
        '
        Me.btnTitleStyle.Location = New System.Drawing.Point(374, 42)
        Me.btnTitleStyle.Name = "btnTitleStyle"
        Me.btnTitleStyle.Size = New System.Drawing.Size(79, 23)
        Me.btnTitleStyle.TabIndex = 30
        Me.btnTitleStyle.Text = "Style"
        Me.btnTitleStyle.UseVisualStyleBackColor = True
        '
        'ucrInputSubtitle
        '
        Me.ucrInputSubtitle.AddQuotesIfUnrecognised = True
        Me.ucrInputSubtitle.AutoSize = True
        Me.ucrInputSubtitle.IsMultiline = False
        Me.ucrInputSubtitle.IsReadOnly = False
        Me.ucrInputSubtitle.Location = New System.Drawing.Point(9, 42)
        Me.ucrInputSubtitle.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSubtitle.Name = "ucrInputSubtitle"
        Me.ucrInputSubtitle.Size = New System.Drawing.Size(361, 21)
        Me.ucrInputSubtitle.TabIndex = 29
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.AutoSize = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        Me.ucrInputTitle.Location = New System.Drawing.Point(11, 42)
        Me.ucrInputTitle.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(359, 21)
        Me.ucrInputTitle.TabIndex = 28
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubtitle.Location = New System.Drawing.Point(6, 25)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(74, 13)
        Me.lblSubtitle.TabIndex = 27
        Me.lblSubtitle.Text = "Subtitle Label:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitle.Location = New System.Drawing.Point(8, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(59, 13)
        Me.lblTitle.TabIndex = 26
        Me.lblTitle.Text = "Title Label:"
        '
        'grpBoxTitle
        '
        Me.grpBoxTitle.Controls.Add(Me.lblTitle)
        Me.grpBoxTitle.Controls.Add(Me.ucrInputTitle)
        Me.grpBoxTitle.Controls.Add(Me.btnTitleStyle)
        Me.grpBoxTitle.Controls.Add(Me.lblHeaderTitle)
        Me.grpBoxTitle.Controls.Add(Me.ucrInputTitleFooter)
        Me.grpBoxTitle.Location = New System.Drawing.Point(4, 5)
        Me.grpBoxTitle.Name = "grpBoxTitle"
        Me.grpBoxTitle.Size = New System.Drawing.Size(463, 115)
        Me.grpBoxTitle.TabIndex = 32
        Me.grpBoxTitle.TabStop = False
        Me.grpBoxTitle.Text = "Title"
        '
        'grpBoxSubtitle
        '
        Me.grpBoxSubtitle.Controls.Add(Me.lblHeaderSubtitle)
        Me.grpBoxSubtitle.Controls.Add(Me.ucrInputSubtitleFooter)
        Me.grpBoxSubtitle.Controls.Add(Me.btnSubTitleStyle)
        Me.grpBoxSubtitle.Controls.Add(Me.ucrInputSubtitle)
        Me.grpBoxSubtitle.Controls.Add(Me.lblSubtitle)
        Me.grpBoxSubtitle.Location = New System.Drawing.Point(4, 125)
        Me.grpBoxSubtitle.Name = "grpBoxSubtitle"
        Me.grpBoxSubtitle.Size = New System.Drawing.Size(463, 116)
        Me.grpBoxSubtitle.TabIndex = 33
        Me.grpBoxSubtitle.TabStop = False
        Me.grpBoxSubtitle.Text = "Subtitle"
        '
        'ucrHeader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpBoxSubtitle)
        Me.Controls.Add(Me.grpBoxTitle)
        Me.Name = "ucrHeader"
        Me.Size = New System.Drawing.Size(470, 246)
        Me.grpBoxTitle.ResumeLayout(False)
        Me.grpBoxTitle.PerformLayout()
        Me.grpBoxSubtitle.ResumeLayout(False)
        Me.grpBoxSubtitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrInputSubtitleFooter As ucrInputTextBox
    Friend WithEvents ucrInputTitleFooter As ucrInputTextBox
    Friend WithEvents lblHeaderSubtitle As Label
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents btnSubTitleStyle As Button
    Friend WithEvents btnTitleStyle As Button
    Friend WithEvents ucrInputSubtitle As ucrInputTextBox
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpBoxTitle As GroupBox
    Friend WithEvents grpBoxSubtitle As GroupBox
End Class
