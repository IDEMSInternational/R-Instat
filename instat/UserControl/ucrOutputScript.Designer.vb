<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrOutputScript
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
        Me.rtbComment = New System.Windows.Forms.RichTextBox()
        Me.rtbScript = New System.Windows.Forms.RichTextBox()
        Me.rtbOutputComment = New System.Windows.Forms.RichTextBox()
        Me.rtbOutputText = New System.Windows.Forms.RichTextBox()
        Me.imagePanel = New System.Windows.Forms.Panel()
        Me.spbOutputImage = New instat.SizeablePictureBox()
        Me.imagePanel.SuspendLayout()
        CType(Me.spbOutputImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtbComment
        '
        Me.rtbComment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbComment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rtbComment.Dock = System.Windows.Forms.DockStyle.Top
        Me.rtbComment.Location = New System.Drawing.Point(0, 0)
        Me.rtbComment.MinimumSize = New System.Drawing.Size(4, 20)
        Me.rtbComment.Name = "rtbComment"
        Me.rtbComment.ReadOnly = True
        Me.rtbComment.Size = New System.Drawing.Size(346, 20)
        Me.rtbComment.TabIndex = 0
        Me.rtbComment.Text = " "
        '
        'rtbScript
        '
        Me.rtbScript.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbScript.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rtbScript.Dock = System.Windows.Forms.DockStyle.Top
        Me.rtbScript.Location = New System.Drawing.Point(0, 20)
        Me.rtbScript.MinimumSize = New System.Drawing.Size(4, 20)
        Me.rtbScript.Name = "rtbScript"
        Me.rtbScript.ReadOnly = True
        Me.rtbScript.Size = New System.Drawing.Size(346, 20)
        Me.rtbScript.TabIndex = 1
        Me.rtbScript.Text = " "
        '
        'rtbOutputComment
        '
        Me.rtbOutputComment.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rtbOutputComment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbOutputComment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rtbOutputComment.Dock = System.Windows.Forms.DockStyle.Top
        Me.rtbOutputComment.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbOutputComment.ForeColor = System.Drawing.Color.RoyalBlue
        Me.rtbOutputComment.Location = New System.Drawing.Point(0, 40)
        Me.rtbOutputComment.MinimumSize = New System.Drawing.Size(4, 20)
        Me.rtbOutputComment.Name = "rtbOutputComment"
        Me.rtbOutputComment.ReadOnly = True
        Me.rtbOutputComment.Size = New System.Drawing.Size(346, 20)
        Me.rtbOutputComment.TabIndex = 2
        Me.rtbOutputComment.Text = " ccvbxcvb"
        '
        'rtbOutputText
        '
        Me.rtbOutputText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbOutputText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rtbOutputText.Dock = System.Windows.Forms.DockStyle.Top
        Me.rtbOutputText.Location = New System.Drawing.Point(0, 60)
        Me.rtbOutputText.MinimumSize = New System.Drawing.Size(4, 20)
        Me.rtbOutputText.Name = "rtbOutputText"
        Me.rtbOutputText.ReadOnly = True
        Me.rtbOutputText.Size = New System.Drawing.Size(346, 20)
        Me.rtbOutputText.TabIndex = 3
        Me.rtbOutputText.Text = " "
        '
        'imagePanel
        '
        Me.imagePanel.AutoScroll = True
        Me.imagePanel.Controls.Add(Me.spbOutputImage)
        Me.imagePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.imagePanel.Location = New System.Drawing.Point(0, 80)
        Me.imagePanel.Name = "imagePanel"
        Me.imagePanel.Size = New System.Drawing.Size(346, 35)
        Me.imagePanel.TabIndex = 6
        '
        'spbOutputImage
        '
        Me.spbOutputImage.CanReSize = True
        Me.spbOutputImage.Location = New System.Drawing.Point(0, 0)
        Me.spbOutputImage.Name = "spbOutputImage"
        Me.spbOutputImage.Size = New System.Drawing.Size(0, 0)
        Me.spbOutputImage.TabIndex = 6
        Me.spbOutputImage.TabStop = False
        '
        'ucrOutputScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.imagePanel)
        Me.Controls.Add(Me.rtbOutputText)
        Me.Controls.Add(Me.rtbOutputComment)
        Me.Controls.Add(Me.rtbScript)
        Me.Controls.Add(Me.rtbComment)
        Me.MinimumSize = New System.Drawing.Size(0, 40)
        Me.Name = "ucrOutputScript"
        Me.Size = New System.Drawing.Size(346, 141)
        Me.imagePanel.ResumeLayout(False)
        CType(Me.spbOutputImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtbComment As RichTextBox
    Friend WithEvents rtbScript As RichTextBox
    Friend WithEvents rtbOutputComment As RichTextBox
    Friend WithEvents rtbOutputText As RichTextBox
    Friend WithEvents imagePanel As Panel
    Friend WithEvents spbOutputImage As SizeablePictureBox
End Class
