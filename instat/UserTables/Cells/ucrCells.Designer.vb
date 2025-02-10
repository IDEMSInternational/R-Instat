<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrCells
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
        Me.rdoStyles = New System.Windows.Forms.RadioButton()
        Me.rdoFormat = New System.Windows.Forms.RadioButton()
        Me.rdoFootNotes = New System.Windows.Forms.RadioButton()
        Me.ucrCellsFootNotes = New instat.ucrCellsFootNotes()
        Me.ucrCellFormats = New instat.ucrCellFormats()
        Me.ucrPnlCells = New instat.UcrPanel()
        Me.ucrCellStyles = New instat.ucrCellStyles()
        Me.SuspendLayout()
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
        Me.rdoStyles.Location = New System.Drawing.Point(279, 3)
        Me.rdoStyles.Name = "rdoStyles"
        Me.rdoStyles.Size = New System.Drawing.Size(91, 29)
        Me.rdoStyles.TabIndex = 292
        Me.rdoStyles.Text = "Styles"
        Me.rdoStyles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStyles.UseVisualStyleBackColor = True
        '
        'rdoFormat
        '
        Me.rdoFormat.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFormat.BackColor = System.Drawing.SystemColors.Control
        Me.rdoFormat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoFormat.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFormat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFormat.FlatAppearance.BorderSize = 2
        Me.rdoFormat.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFormat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFormat.Location = New System.Drawing.Point(102, 3)
        Me.rdoFormat.Name = "rdoFormat"
        Me.rdoFormat.Size = New System.Drawing.Size(91, 29)
        Me.rdoFormat.TabIndex = 290
        Me.rdoFormat.Text = "Formats"
        Me.rdoFormat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFormat.UseVisualStyleBackColor = True
        '
        'rdoFootNotes
        '
        Me.rdoFootNotes.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFootNotes.BackColor = System.Drawing.SystemColors.Control
        Me.rdoFootNotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoFootNotes.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFootNotes.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFootNotes.FlatAppearance.BorderSize = 2
        Me.rdoFootNotes.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFootNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFootNotes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoFootNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFootNotes.Location = New System.Drawing.Point(191, 3)
        Me.rdoFootNotes.Name = "rdoFootNotes"
        Me.rdoFootNotes.Size = New System.Drawing.Size(91, 29)
        Me.rdoFootNotes.TabIndex = 291
        Me.rdoFootNotes.Text = "Footer Notes"
        Me.rdoFootNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFootNotes.UseVisualStyleBackColor = True
        '
        'ucrCellsFootNotes
        '
        Me.ucrCellsFootNotes.Location = New System.Drawing.Point(7, 38)
        Me.ucrCellsFootNotes.Name = "ucrCellsFootNotes"
        Me.ucrCellsFootNotes.Size = New System.Drawing.Size(604, 318)
        Me.ucrCellsFootNotes.TabIndex = 294
        '
        'ucrCellFormats
        '
        Me.ucrCellFormats.Location = New System.Drawing.Point(7, 37)
        Me.ucrCellFormats.Name = "ucrCellFormats"
        Me.ucrCellFormats.Size = New System.Drawing.Size(604, 319)
        Me.ucrCellFormats.TabIndex = 293
        '
        'ucrPnlCells
        '
        Me.ucrPnlCells.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlCells.Location = New System.Drawing.Point(85, 3)
        Me.ucrPnlCells.Name = "ucrPnlCells"
        Me.ucrPnlCells.Size = New System.Drawing.Size(309, 29)
        Me.ucrPnlCells.TabIndex = 289
        '
        'ucrCellStyles
        '
        Me.ucrCellStyles.Location = New System.Drawing.Point(7, 56)
        Me.ucrCellStyles.Name = "ucrCellStyles"
        Me.ucrCellStyles.Size = New System.Drawing.Size(609, 264)
        Me.ucrCellStyles.TabIndex = 295
        '
        'ucrCells
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrCellsFootNotes)
        Me.Controls.Add(Me.ucrCellStyles)
        Me.Controls.Add(Me.ucrCellFormats)
        Me.Controls.Add(Me.rdoStyles)
        Me.Controls.Add(Me.rdoFormat)
        Me.Controls.Add(Me.rdoFootNotes)
        Me.Controls.Add(Me.ucrPnlCells)
        Me.Name = "ucrCells"
        Me.Size = New System.Drawing.Size(629, 362)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rdoStyles As RadioButton
    Friend WithEvents rdoFormat As RadioButton
    Friend WithEvents rdoFootNotes As RadioButton
    Friend WithEvents ucrPnlCells As UcrPanel
    Friend WithEvents ucrCellFormats As ucrCellFormats
    Friend WithEvents ucrCellsFootNotes As ucrCellsFootNotes
    Friend WithEvents ucrCellStyles As ucrCellStyles
End Class
