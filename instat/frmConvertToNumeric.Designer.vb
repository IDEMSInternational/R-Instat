<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvertToNumeric
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConvertToNumeric))
        Me.lblPossibleSolutions = New System.Windows.Forms.Label()
        Me.cmdNormalConvert = New System.Windows.Forms.Button()
        Me.cmdLabelledConvert = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPossibleSolutions
        '
        Me.lblPossibleSolutions.Location = New System.Drawing.Point(13, 9)
        Me.lblPossibleSolutions.Name = "lblPossibleSolutions"
        Me.lblPossibleSolutions.Size = New System.Drawing.Size(425, 88)
        Me.lblPossibleSolutions.TabIndex = 3
        Me.lblPossibleSolutions.Text = resources.GetString("lblPossibleSolutions.Text")
        '
        'cmdNormalConvert
        '
        Me.cmdNormalConvert.Location = New System.Drawing.Point(109, 129)
        Me.cmdNormalConvert.Name = "cmdNormalConvert"
        Me.cmdNormalConvert.Size = New System.Drawing.Size(107, 23)
        Me.cmdNormalConvert.TabIndex = 6
        Me.cmdNormalConvert.Text = "Normal Convert"
        Me.cmdNormalConvert.UseVisualStyleBackColor = True
        '
        'cmdLabelledConvert
        '
        Me.cmdLabelledConvert.Location = New System.Drawing.Point(243, 129)
        Me.cmdLabelledConvert.Name = "cmdLabelledConvert"
        Me.cmdLabelledConvert.Size = New System.Drawing.Size(107, 23)
        Me.cmdLabelledConvert.TabIndex = 7
        Me.cmdLabelledConvert.Text = "Labelled Convert"
        Me.cmdLabelledConvert.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(16, 94)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(66, 23)
        Me.cmdHelp.TabIndex = 8
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'frmConvertToNumeric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 160)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdLabelledConvert)
        Me.Controls.Add(Me.cmdNormalConvert)
        Me.Controls.Add(Me.lblPossibleSolutions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConvertToNumeric"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convert To Numeric"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPossibleSolutions As Label
    Friend WithEvents cmdNormalConvert As Button
    Friend WithEvents cmdLabelledConvert As Button
    Friend WithEvents cmdHelp As Button
End Class
