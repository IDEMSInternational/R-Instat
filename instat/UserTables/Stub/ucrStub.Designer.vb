<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrStub
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ucrStubOptions = New instat.ucrStubOptions()
        Me.rdoVariables = New System.Windows.Forms.RadioButton()
        Me.rdoStyles = New System.Windows.Forms.RadioButton()
        Me.ucrPnlStub = New instat.UcrPanel()
        Me.ucrStubStyle = New instat.ucrStubStyle()
        Me.SuspendLayout()
        '
        'ucrStubOptions
        '
        Me.ucrStubOptions.Location = New System.Drawing.Point(3, 40)
        Me.ucrStubOptions.Name = "ucrStubOptions"
        Me.ucrStubOptions.Size = New System.Drawing.Size(405, 187)
        Me.ucrStubOptions.TabIndex = 0
        '
        'rdoVariables
        '
        Me.rdoVariables.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoVariables.BackColor = System.Drawing.SystemColors.Control
        Me.rdoVariables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoVariables.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVariables.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVariables.FlatAppearance.BorderSize = 2
        Me.rdoVariables.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVariables.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoVariables.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoVariables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoVariables.Location = New System.Drawing.Point(106, 3)
        Me.rdoVariables.Name = "rdoVariables"
        Me.rdoVariables.Size = New System.Drawing.Size(91, 29)
        Me.rdoVariables.TabIndex = 283
        Me.rdoVariables.Text = "Contents"
        Me.rdoVariables.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVariables.UseVisualStyleBackColor = True
        '
        'rdoStyles
        '
        Me.rdoStyles.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStyles.BackColor = System.Drawing.SystemColors.Control
        Me.rdoStyles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoStyles.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStyles.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStyles.FlatAppearance.BorderSize = 2
        Me.rdoStyles.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStyles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStyles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoStyles.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStyles.Location = New System.Drawing.Point(195, 3)
        Me.rdoStyles.Name = "rdoStyles"
        Me.rdoStyles.Size = New System.Drawing.Size(91, 29)
        Me.rdoStyles.TabIndex = 284
        Me.rdoStyles.Text = "Styles"
        Me.rdoStyles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStyles.UseVisualStyleBackColor = True
        '
        'ucrPnlStub
        '
        Me.ucrPnlStub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlStub.Location = New System.Drawing.Point(81, 3)
        Me.ucrPnlStub.Name = "ucrPnlStub"
        Me.ucrPnlStub.Size = New System.Drawing.Size(232, 29)
        Me.ucrPnlStub.TabIndex = 282
        '
        'ucrStubStyle
        '
        Me.ucrStubStyle.Location = New System.Drawing.Point(3, 43)
        Me.ucrStubStyle.Name = "ucrStubStyle"
        Me.ucrStubStyle.Size = New System.Drawing.Size(372, 186)
        Me.ucrStubStyle.TabIndex = 285
        '
        'ucrStub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrStubStyle)
        Me.Controls.Add(Me.rdoVariables)
        Me.Controls.Add(Me.rdoStyles)
        Me.Controls.Add(Me.ucrPnlStub)
        Me.Controls.Add(Me.ucrStubOptions)
        Me.Name = "ucrStub"
        Me.Size = New System.Drawing.Size(420, 239)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrStubOptions As ucrStubOptions
    Friend WithEvents rdoVariables As RadioButton
    Friend WithEvents rdoStyles As RadioButton
    Friend WithEvents ucrPnlStub As UcrPanel
    Friend WithEvents ucrStubStyle As ucrStubStyle
End Class
