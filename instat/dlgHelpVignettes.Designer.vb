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
        Me.ucrInputComboPackage = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblPackage = New System.Windows.Forms.Label()
        Me.rdoHelp = New System.Windows.Forms.RadioButton()
        Me.rdoVignettes = New System.Windows.Forms.RadioButton()
        Me.ucrPnlHelpVignettes = New instat.UcrPanel()
        Me.ucrInputFunctionName = New instat.ucrInputTextBox()
        Me.ucrChkFunction = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'ucrInputComboPackage
        '
        Me.ucrInputComboPackage.AddQuotesIfUnrecognised = True
        Me.ucrInputComboPackage.IsReadOnly = False
        Me.ucrInputComboPackage.Location = New System.Drawing.Point(133, 58)
        Me.ucrInputComboPackage.Name = "ucrInputComboPackage"
        Me.ucrInputComboPackage.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputComboPackage.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 145)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 7
        '
        'lblPackage
        '
        Me.lblPackage.AutoSize = True
        Me.lblPackage.Location = New System.Drawing.Point(23, 62)
        Me.lblPackage.Name = "lblPackage"
        Me.lblPackage.Size = New System.Drawing.Size(84, 13)
        Me.lblPackage.TabIndex = 3
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
        Me.rdoHelp.Location = New System.Drawing.Point(132, 12)
        Me.rdoHelp.Name = "rdoHelp"
        Me.rdoHelp.Size = New System.Drawing.Size(91, 27)
        Me.rdoHelp.TabIndex = 1
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
        Me.rdoVignettes.Location = New System.Drawing.Point(221, 12)
        Me.rdoVignettes.Name = "rdoVignettes"
        Me.rdoVignettes.Size = New System.Drawing.Size(91, 27)
        Me.rdoVignettes.TabIndex = 2
        Me.rdoVignettes.TabStop = True
        Me.rdoVignettes.Text = "Vignettes"
        Me.rdoVignettes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVignettes.UseVisualStyleBackColor = True
        '
        'ucrPnlHelpVignettes
        '
        Me.ucrPnlHelpVignettes.Location = New System.Drawing.Point(103, 8)
        Me.ucrPnlHelpVignettes.Name = "ucrPnlHelpVignettes"
        Me.ucrPnlHelpVignettes.Size = New System.Drawing.Size(231, 36)
        Me.ucrPnlHelpVignettes.TabIndex = 0
        '
        'ucrInputFunctionName
        '
        Me.ucrInputFunctionName.AddQuotesIfUnrecognised = True
        Me.ucrInputFunctionName.IsMultiline = False
        Me.ucrInputFunctionName.IsReadOnly = False
        Me.ucrInputFunctionName.Location = New System.Drawing.Point(133, 99)
        Me.ucrInputFunctionName.Name = "ucrInputFunctionName"
        Me.ucrInputFunctionName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputFunctionName.TabIndex = 6
        '
        'ucrChkFunction
        '
        Me.ucrChkFunction.Checked = False
        Me.ucrChkFunction.Location = New System.Drawing.Point(23, 100)
        Me.ucrChkFunction.Name = "ucrChkFunction"
        Me.ucrChkFunction.Size = New System.Drawing.Size(107, 20)
        Me.ucrChkFunction.TabIndex = 5
        '
        'dlgHelpVignettes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 207)
        Me.Controls.Add(Me.ucrInputFunctionName)
        Me.Controls.Add(Me.ucrChkFunction)
        Me.Controls.Add(Me.rdoHelp)
        Me.Controls.Add(Me.rdoVignettes)
        Me.Controls.Add(Me.ucrPnlHelpVignettes)
        Me.Controls.Add(Me.lblPackage)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrInputComboPackage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgHelpVignettes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Packages Documenation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputComboPackage As ucrInputComboBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblPackage As Label
    Friend WithEvents rdoHelp As RadioButton
    Friend WithEvents rdoVignettes As RadioButton
    Friend WithEvents ucrPnlHelpVignettes As UcrPanel
    Friend WithEvents ucrInputFunctionName As ucrInputTextBox
    Friend WithEvents ucrChkFunction As ucrCheck
End Class
