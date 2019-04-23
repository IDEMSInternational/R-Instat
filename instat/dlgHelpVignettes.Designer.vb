<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgHelpVignettes
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
        Me.UcrInputComboBox1 = New instat.ucrInputComboBox()
        Me.UcrButtons1 = New instat.ucrButtons()
        Me.lblPackage = New System.Windows.Forms.Label()
        Me.rdoHelp = New System.Windows.Forms.RadioButton()
        Me.rdoVignettes = New System.Windows.Forms.RadioButton()
        Me.ucrPnlHelpVignettes = New instat.UcrPanel()
        Me.ucrInputFunctionName = New instat.ucrInputTextBox()
        Me.lblFunctionName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UcrInputComboBox1
        '
        Me.UcrInputComboBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox1.IsReadOnly = False
        Me.UcrInputComboBox1.Location = New System.Drawing.Point(111, 58)
        Me.UcrInputComboBox1.Name = "UcrInputComboBox1"
        Me.UcrInputComboBox1.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox1.TabIndex = 0
        '
        'UcrButtons1
        '
        Me.UcrButtons1.Location = New System.Drawing.Point(2, 145)
        Me.UcrButtons1.Name = "UcrButtons1"
        Me.UcrButtons1.Size = New System.Drawing.Size(410, 52)
        Me.UcrButtons1.TabIndex = 1
        '
        'lblPackage
        '
        Me.lblPackage.AutoSize = True
        Me.lblPackage.Location = New System.Drawing.Point(23, 61)
        Me.lblPackage.Name = "lblPackage"
        Me.lblPackage.Size = New System.Drawing.Size(84, 13)
        Me.lblPackage.TabIndex = 2
        Me.lblPackage.Text = "Package Name:"
        '
        'rdoHelp
        '
        Me.rdoHelp.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoHelp.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHelp.FlatAppearance.BorderSize = 2
        Me.rdoHelp.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHelp.Location = New System.Drawing.Point(130, 12)
        Me.rdoHelp.Name = "rdoHelp"
        Me.rdoHelp.Size = New System.Drawing.Size(91, 27)
        Me.rdoHelp.TabIndex = 4
        Me.rdoHelp.TabStop = True
        Me.rdoHelp.Text = "Help"
        Me.rdoHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoHelp.UseVisualStyleBackColor = True
        '
        'rdoVignettes
        '
        Me.rdoVignettes.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoVignettes.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVignettes.FlatAppearance.BorderSize = 2
        Me.rdoVignettes.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVignettes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoVignettes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoVignettes.Location = New System.Drawing.Point(218, 12)
        Me.rdoVignettes.Name = "rdoVignettes"
        Me.rdoVignettes.Size = New System.Drawing.Size(91, 27)
        Me.rdoVignettes.TabIndex = 5
        Me.rdoVignettes.TabStop = True
        Me.rdoVignettes.Text = "Vignettes"
        Me.rdoVignettes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVignettes.UseVisualStyleBackColor = True
        '
        'ucrPnlHelpVignettes
        '
        Me.ucrPnlHelpVignettes.Location = New System.Drawing.Point(82, 8)
        Me.ucrPnlHelpVignettes.Name = "ucrPnlHelpVignettes"
        Me.ucrPnlHelpVignettes.Size = New System.Drawing.Size(250, 36)
        Me.ucrPnlHelpVignettes.TabIndex = 3
        '
        'ucrInputFunctionName
        '
        Me.ucrInputFunctionName.AddQuotesIfUnrecognised = True
        Me.ucrInputFunctionName.IsMultiline = False
        Me.ucrInputFunctionName.IsReadOnly = False
        Me.ucrInputFunctionName.Location = New System.Drawing.Point(111, 102)
        Me.ucrInputFunctionName.Name = "ucrInputFunctionName"
        Me.ucrInputFunctionName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputFunctionName.TabIndex = 6
        '
        'lblFunctionName
        '
        Me.lblFunctionName.AutoSize = True
        Me.lblFunctionName.Location = New System.Drawing.Point(24, 106)
        Me.lblFunctionName.Name = "lblFunctionName"
        Me.lblFunctionName.Size = New System.Drawing.Size(82, 13)
        Me.lblFunctionName.TabIndex = 7
        Me.lblFunctionName.Text = "Function Name:"
        '
        'dlgHelpVignettes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 202)
        Me.Controls.Add(Me.lblFunctionName)
        Me.Controls.Add(Me.ucrInputFunctionName)
        Me.Controls.Add(Me.rdoHelp)
        Me.Controls.Add(Me.rdoVignettes)
        Me.Controls.Add(Me.ucrPnlHelpVignettes)
        Me.Controls.Add(Me.lblPackage)
        Me.Controls.Add(Me.UcrButtons1)
        Me.Controls.Add(Me.UcrInputComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgHelpVignettes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Packages Documenation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrInputComboBox1 As ucrInputComboBox
    Friend WithEvents UcrButtons1 As ucrButtons
    Friend WithEvents lblPackage As Label
    Friend WithEvents rdoHelp As RadioButton
    Friend WithEvents rdoVignettes As RadioButton
    Friend WithEvents ucrPnlHelpVignettes As UcrPanel
    Friend WithEvents ucrInputFunctionName As ucrInputTextBox
    Friend WithEvents lblFunctionName As Label
End Class
