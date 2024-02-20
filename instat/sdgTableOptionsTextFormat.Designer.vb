<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgTableOptionsTextFormat
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
        Me.lblFontFamily = New System.Windows.Forms.Label()
        Me.lblFontStyle = New System.Windows.Forms.Label()
        Me.lblFontSize = New System.Windows.Forms.Label()
        Me.lblUnderlineColor = New System.Windows.Forms.Label()
        Me.lblUnderlineStyle = New System.Windows.Forms.Label()
        Me.lblAlignHorizontal = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucrCboFontStyle = New instat.ucrInputComboBox()
        Me.ucrCboFontFamily = New instat.ucrInputComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ucrCboUnderlineStyle = New instat.ucrInputComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ucrCboAlignHorizontal = New instat.ucrInputComboBox()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.ucrCboFontWeight = New instat.ucrInputComboBox()
        Me.lblFontWeight = New System.Windows.Forms.Label()
        Me.ucrTxtFontSize = New instat.ucrInputTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ucrCboColorText = New instat.ucrColors()
        Me.ucrCboColorBackground = New instat.ucrColors()
        Me.ucrCboUnderLineColor = New instat.ucrColors()
        Me.lblUnderlineType = New System.Windows.Forms.Label()
        Me.ucrCboUnderlineType = New instat.ucrInputComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFontFamily
        '
        Me.lblFontFamily.AutoSize = True
        Me.lblFontFamily.Location = New System.Drawing.Point(6, 19)
        Me.lblFontFamily.Name = "lblFontFamily"
        Me.lblFontFamily.Size = New System.Drawing.Size(69, 13)
        Me.lblFontFamily.TabIndex = 6
        Me.lblFontFamily.Text = "Type (family):"
        '
        'lblFontStyle
        '
        Me.lblFontStyle.AutoSize = True
        Me.lblFontStyle.Location = New System.Drawing.Point(151, 19)
        Me.lblFontStyle.Name = "lblFontStyle"
        Me.lblFontStyle.Size = New System.Drawing.Size(33, 13)
        Me.lblFontStyle.TabIndex = 8
        Me.lblFontStyle.Text = "Style:"
        '
        'lblFontSize
        '
        Me.lblFontSize.AutoSize = True
        Me.lblFontSize.Location = New System.Drawing.Point(444, 19)
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(30, 13)
        Me.lblFontSize.TabIndex = 10
        Me.lblFontSize.Text = "Size:"
        '
        'lblUnderlineColor
        '
        Me.lblUnderlineColor.AutoSize = True
        Me.lblUnderlineColor.Location = New System.Drawing.Point(300, 16)
        Me.lblUnderlineColor.Name = "lblUnderlineColor"
        Me.lblUnderlineColor.Size = New System.Drawing.Size(34, 13)
        Me.lblUnderlineColor.TabIndex = 16
        Me.lblUnderlineColor.Text = "Color:"
        '
        'lblUnderlineStyle
        '
        Me.lblUnderlineStyle.AutoSize = True
        Me.lblUnderlineStyle.Location = New System.Drawing.Point(151, 16)
        Me.lblUnderlineStyle.Name = "lblUnderlineStyle"
        Me.lblUnderlineStyle.Size = New System.Drawing.Size(33, 13)
        Me.lblUnderlineStyle.TabIndex = 14
        Me.lblUnderlineStyle.Text = "Style:"
        '
        'lblAlignHorizontal
        '
        Me.lblAlignHorizontal.AutoSize = True
        Me.lblAlignHorizontal.Location = New System.Drawing.Point(6, 20)
        Me.lblAlignHorizontal.Name = "lblAlignHorizontal"
        Me.lblAlignHorizontal.Size = New System.Drawing.Size(57, 13)
        Me.lblAlignHorizontal.TabIndex = 18
        Me.lblAlignHorizontal.Text = "Horizontal:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucrTxtFontSize)
        Me.GroupBox1.Controls.Add(Me.ucrCboFontWeight)
        Me.GroupBox1.Controls.Add(Me.lblFontWeight)
        Me.GroupBox1.Controls.Add(Me.lblFontFamily)
        Me.GroupBox1.Controls.Add(Me.ucrCboFontStyle)
        Me.GroupBox1.Controls.Add(Me.ucrCboFontFamily)
        Me.GroupBox1.Controls.Add(Me.lblFontStyle)
        Me.GroupBox1.Controls.Add(Me.lblFontSize)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 68)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Font"
        '
        'ucrCboFontStyle
        '
        Me.ucrCboFontStyle.AddQuotesIfUnrecognised = True
        Me.ucrCboFontStyle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboFontStyle.GetSetSelectedIndex = -1
        Me.ucrCboFontStyle.IsReadOnly = False
        Me.ucrCboFontStyle.Location = New System.Drawing.Point(154, 35)
        Me.ucrCboFontStyle.Name = "ucrCboFontStyle"
        Me.ucrCboFontStyle.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboFontStyle.TabIndex = 7
        '
        'ucrCboFontFamily
        '
        Me.ucrCboFontFamily.AddQuotesIfUnrecognised = True
        Me.ucrCboFontFamily.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboFontFamily.GetSetSelectedIndex = -1
        Me.ucrCboFontFamily.IsReadOnly = False
        Me.ucrCboFontFamily.Location = New System.Drawing.Point(9, 35)
        Me.ucrCboFontFamily.Name = "ucrCboFontFamily"
        Me.ucrCboFontFamily.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboFontFamily.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblUnderlineType)
        Me.GroupBox2.Controls.Add(Me.ucrCboUnderlineType)
        Me.GroupBox2.Controls.Add(Me.ucrCboUnderLineColor)
        Me.GroupBox2.Controls.Add(Me.lblUnderlineStyle)
        Me.GroupBox2.Controls.Add(Me.ucrCboUnderlineStyle)
        Me.GroupBox2.Controls.Add(Me.lblUnderlineColor)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(594, 68)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Underline"
        '
        'ucrCboUnderlineStyle
        '
        Me.ucrCboUnderlineStyle.AddQuotesIfUnrecognised = True
        Me.ucrCboUnderlineStyle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboUnderlineStyle.GetSetSelectedIndex = -1
        Me.ucrCboUnderlineStyle.IsReadOnly = False
        Me.ucrCboUnderlineStyle.Location = New System.Drawing.Point(154, 32)
        Me.ucrCboUnderlineStyle.Name = "ucrCboUnderlineStyle"
        Me.ucrCboUnderlineStyle.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboUnderlineStyle.TabIndex = 13
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblAlignHorizontal)
        Me.GroupBox3.Controls.Add(Me.ucrCboAlignHorizontal)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 250)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(594, 65)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Alignment"
        '
        'ucrCboAlignHorizontal
        '
        Me.ucrCboAlignHorizontal.AddQuotesIfUnrecognised = True
        Me.ucrCboAlignHorizontal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboAlignHorizontal.GetSetSelectedIndex = -1
        Me.ucrCboAlignHorizontal.IsReadOnly = False
        Me.ucrCboAlignHorizontal.Location = New System.Drawing.Point(9, 36)
        Me.ucrCboAlignHorizontal.Name = "ucrCboAlignHorizontal"
        Me.ucrCboAlignHorizontal.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboAlignHorizontal.TabIndex = 17
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(220, 338)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(224, 29)
        Me.ucrBaseSubdialog.TabIndex = 4
        '
        'ucrCboFontWeight
        '
        Me.ucrCboFontWeight.AddQuotesIfUnrecognised = True
        Me.ucrCboFontWeight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboFontWeight.GetSetSelectedIndex = -1
        Me.ucrCboFontWeight.IsReadOnly = False
        Me.ucrCboFontWeight.Location = New System.Drawing.Point(300, 35)
        Me.ucrCboFontWeight.Name = "ucrCboFontWeight"
        Me.ucrCboFontWeight.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboFontWeight.TabIndex = 13
        '
        'lblFontWeight
        '
        Me.lblFontWeight.AutoSize = True
        Me.lblFontWeight.Location = New System.Drawing.Point(297, 19)
        Me.lblFontWeight.Name = "lblFontWeight"
        Me.lblFontWeight.Size = New System.Drawing.Size(44, 13)
        Me.lblFontWeight.TabIndex = 14
        Me.lblFontWeight.Text = "Weight:"
        '
        'ucrTxtFontSize
        '
        Me.ucrTxtFontSize.AddQuotesIfUnrecognised = True
        Me.ucrTxtFontSize.AutoSize = True
        Me.ucrTxtFontSize.IsMultiline = False
        Me.ucrTxtFontSize.IsReadOnly = False
        Me.ucrTxtFontSize.Location = New System.Drawing.Point(447, 35)
        Me.ucrTxtFontSize.Name = "ucrTxtFontSize"
        Me.ucrTxtFontSize.Size = New System.Drawing.Size(137, 21)
        Me.ucrTxtFontSize.TabIndex = 15
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ucrCboColorBackground)
        Me.GroupBox4.Controls.Add(Me.ucrCboColorText)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 85)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(594, 68)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Colour"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Text:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(155, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Background:"
        '
        'ucrCboColorText
        '
        Me.ucrCboColorText.AddQuotesIfUnrecognised = True
        Me.ucrCboColorText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboColorText.GetSetSelectedIndex = -1
        Me.ucrCboColorText.IsReadOnly = False
        Me.ucrCboColorText.Location = New System.Drawing.Point(9, 37)
        Me.ucrCboColorText.Name = "ucrCboColorText"
        Me.ucrCboColorText.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboColorText.TabIndex = 17
        '
        'ucrCboColorBackground
        '
        Me.ucrCboColorBackground.AddQuotesIfUnrecognised = True
        Me.ucrCboColorBackground.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboColorBackground.GetSetSelectedIndex = -1
        Me.ucrCboColorBackground.IsReadOnly = False
        Me.ucrCboColorBackground.Location = New System.Drawing.Point(157, 37)
        Me.ucrCboColorBackground.Name = "ucrCboColorBackground"
        Me.ucrCboColorBackground.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboColorBackground.TabIndex = 18
        '
        'ucrCboUnderLineColor
        '
        Me.ucrCboUnderLineColor.AddQuotesIfUnrecognised = True
        Me.ucrCboUnderLineColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboUnderLineColor.GetSetSelectedIndex = -1
        Me.ucrCboUnderLineColor.IsReadOnly = False
        Me.ucrCboUnderLineColor.Location = New System.Drawing.Point(302, 32)
        Me.ucrCboUnderLineColor.Name = "ucrCboUnderLineColor"
        Me.ucrCboUnderLineColor.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboUnderLineColor.TabIndex = 19
        '
        'lblUnderlineType
        '
        Me.lblUnderlineType.AutoSize = True
        Me.lblUnderlineType.Location = New System.Drawing.Point(6, 16)
        Me.lblUnderlineType.Name = "lblUnderlineType"
        Me.lblUnderlineType.Size = New System.Drawing.Size(34, 13)
        Me.lblUnderlineType.TabIndex = 21
        Me.lblUnderlineType.Text = "Type:"
        '
        'ucrCboUnderlineType
        '
        Me.ucrCboUnderlineType.AddQuotesIfUnrecognised = True
        Me.ucrCboUnderlineType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboUnderlineType.GetSetSelectedIndex = -1
        Me.ucrCboUnderlineType.IsReadOnly = False
        Me.ucrCboUnderlineType.Location = New System.Drawing.Point(9, 32)
        Me.ucrCboUnderlineType.Name = "ucrCboUnderlineType"
        Me.ucrCboUnderlineType.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboUnderlineType.TabIndex = 20
        '
        'sdgTableOptionsTextFormat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 372)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgTableOptionsTextFormat"
        Me.Text = "Text Format"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents ucrCboFontFamily As ucrInputComboBox
    Friend WithEvents lblFontFamily As Label
    Friend WithEvents lblFontStyle As Label
    Friend WithEvents ucrCboFontStyle As ucrInputComboBox
    Friend WithEvents lblFontSize As Label
    Friend WithEvents lblUnderlineColor As Label
    Friend WithEvents lblUnderlineStyle As Label
    Friend WithEvents ucrCboUnderlineStyle As ucrInputComboBox
    Friend WithEvents lblAlignHorizontal As Label
    Friend WithEvents ucrCboAlignHorizontal As ucrInputComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ucrCboFontWeight As ucrInputComboBox
    Friend WithEvents lblFontWeight As Label
    Friend WithEvents ucrTxtFontSize As ucrInputTextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ucrCboColorText As ucrColors
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ucrCboColorBackground As ucrColors
    Friend WithEvents ucrCboUnderLineColor As ucrColors
    Friend WithEvents lblUnderlineType As Label
    Friend WithEvents ucrCboUnderlineType As ucrInputComboBox
End Class
