<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgRecordQuarto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.lblFileLocation = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.ucrInputFileLocation = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkRenderDetails = New instat.ucrCheck()
        Me.ucrChkDocs = New instat.ucrCheck()
        Me.ucrChkPptx = New instat.ucrCheck()
        Me.ucrChkPdf = New instat.ucrCheck()
        Me.ucrChkHtml = New instat.ucrCheck()
        Me.ucrChkSaveReopen = New instat.ucrCheck()
        Me.grpFormat = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'lblFileLocation
        '
        Me.lblFileLocation.AutoSize = True
        Me.lblFileLocation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFileLocation.Location = New System.Drawing.Point(9, 30)
        Me.lblFileLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFileLocation.Name = "lblFileLocation"
        Me.lblFileLocation.Size = New System.Drawing.Size(103, 20)
        Me.lblFileLocation.TabIndex = 18
        Me.lblFileLocation.Text = "File Location:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrowse.Location = New System.Drawing.Point(484, 23)
        Me.cmdBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(120, 34)
        Me.cmdBrowse.TabIndex = 20
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'ucrInputFileLocation
        '
        Me.ucrInputFileLocation.AddQuotesIfUnrecognised = True
        Me.ucrInputFileLocation.AutoSize = True
        Me.ucrInputFileLocation.IsMultiline = False
        Me.ucrInputFileLocation.IsReadOnly = False
        Me.ucrInputFileLocation.Location = New System.Drawing.Point(208, 24)
        Me.ucrInputFileLocation.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrInputFileLocation.Name = "ucrInputFileLocation"
        Me.ucrInputFileLocation.Size = New System.Drawing.Size(273, 32)
        Me.ucrInputFileLocation.TabIndex = 19
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(19, 360)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 21
        '
        'ucrChkRenderDetails
        '
        Me.ucrChkRenderDetails.AutoSize = True
        Me.ucrChkRenderDetails.Checked = False
        Me.ucrChkRenderDetails.Location = New System.Drawing.Point(17, 274)
        Me.ucrChkRenderDetails.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkRenderDetails.Name = "ucrChkRenderDetails"
        Me.ucrChkRenderDetails.Size = New System.Drawing.Size(395, 34)
        Me.ucrChkRenderDetails.TabIndex = 22
        '
        'ucrChkDocs
        '
        Me.ucrChkDocs.AutoSize = True
        Me.ucrChkDocs.Checked = False
        Me.ucrChkDocs.Location = New System.Drawing.Point(17, 188)
        Me.ucrChkDocs.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkDocs.Name = "ucrChkDocs"
        Me.ucrChkDocs.Size = New System.Drawing.Size(367, 34)
        Me.ucrChkDocs.TabIndex = 23
        '
        'ucrChkPptx
        '
        Me.ucrChkPptx.AutoSize = True
        Me.ucrChkPptx.Checked = False
        Me.ucrChkPptx.Location = New System.Drawing.Point(17, 226)
        Me.ucrChkPptx.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkPptx.Name = "ucrChkPptx"
        Me.ucrChkPptx.Size = New System.Drawing.Size(304, 34)
        Me.ucrChkPptx.TabIndex = 24
        '
        'ucrChkPdf
        '
        Me.ucrChkPdf.AutoSize = True
        Me.ucrChkPdf.Checked = False
        Me.ucrChkPdf.Location = New System.Drawing.Point(17, 151)
        Me.ucrChkPdf.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkPdf.Name = "ucrChkPdf"
        Me.ucrChkPdf.Size = New System.Drawing.Size(326, 34)
        Me.ucrChkPdf.TabIndex = 25
        '
        'ucrChkHtml
        '
        Me.ucrChkHtml.AutoSize = True
        Me.ucrChkHtml.Checked = False
        Me.ucrChkHtml.Location = New System.Drawing.Point(17, 112)
        Me.ucrChkHtml.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkHtml.Name = "ucrChkHtml"
        Me.ucrChkHtml.Size = New System.Drawing.Size(263, 34)
        Me.ucrChkHtml.TabIndex = 26
        '
        'ucrChkSaveReopen
        '
        Me.ucrChkSaveReopen.AutoSize = True
        Me.ucrChkSaveReopen.Checked = False
        Me.ucrChkSaveReopen.Location = New System.Drawing.Point(17, 310)
        Me.ucrChkSaveReopen.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkSaveReopen.Name = "ucrChkSaveReopen"
        Me.ucrChkSaveReopen.Size = New System.Drawing.Size(395, 34)
        Me.ucrChkSaveReopen.TabIndex = 27
        '
        'grpFormat
        '
        Me.grpFormat.Location = New System.Drawing.Point(8, 91)
        Me.grpFormat.Name = "grpFormat"
        Me.grpFormat.Size = New System.Drawing.Size(361, 170)
        Me.grpFormat.TabIndex = 28
        Me.grpFormat.TabStop = False
        Me.grpFormat.Text = "Output Format"
        '
        'dlgRecordQuarto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 462)
        Me.Controls.Add(Me.ucrChkSaveReopen)
        Me.Controls.Add(Me.ucrChkHtml)
        Me.Controls.Add(Me.ucrChkPdf)
        Me.Controls.Add(Me.ucrChkPptx)
        Me.Controls.Add(Me.ucrChkDocs)
        Me.Controls.Add(Me.ucrChkRenderDetails)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblFileLocation)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.ucrInputFileLocation)
        Me.Controls.Add(Me.grpFormat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRecordQuarto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record Quarto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFileLocation As Label
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents ucrInputFileLocation As ucrInputTextBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkRenderDetails As ucrCheck
    Friend WithEvents ucrChkDocs As ucrCheck
    Friend WithEvents ucrChkPptx As ucrCheck
    Friend WithEvents ucrChkPdf As ucrCheck
    Friend WithEvents ucrChkHtml As ucrCheck
    Friend WithEvents ucrChkSaveReopen As ucrCheck
    Friend WithEvents grpFormat As GroupBox
End Class
