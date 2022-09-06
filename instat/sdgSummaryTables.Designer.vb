<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgTableOptions
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
        Me.ucrBase = New instat.ucrButtons()
        Me.tbTableOptions = New System.Windows.Forms.TabControl()
        Me.tbCells = New System.Windows.Forms.TabPage()
        Me.tbColumnsRows = New System.Windows.Forms.TabPage()
        Me.tbFormatData = New System.Windows.Forms.TabPage()
        Me.tbSummary = New System.Windows.Forms.TabPage()
        Me.tbInfo = New System.Windows.Forms.TabPage()
        Me.grpText = New System.Windows.Forms.GroupBox()
        Me.tbTableOptions.SuspendLayout()
        Me.tbCells.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(24, 477)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(512, 65)
        Me.ucrBase.TabIndex = 0
        '
        'tbTableOptions
        '
        Me.tbTableOptions.Controls.Add(Me.tbCells)
        Me.tbTableOptions.Controls.Add(Me.tbColumnsRows)
        Me.tbTableOptions.Controls.Add(Me.tbFormatData)
        Me.tbTableOptions.Controls.Add(Me.tbSummary)
        Me.tbTableOptions.Controls.Add(Me.tbInfo)
        Me.tbTableOptions.Location = New System.Drawing.Point(24, 12)
        Me.tbTableOptions.Name = "tbTableOptions"
        Me.tbTableOptions.SelectedIndex = 0
        Me.tbTableOptions.Size = New System.Drawing.Size(444, 458)
        Me.tbTableOptions.TabIndex = 1
        '
        'tbCells
        '
        Me.tbCells.Controls.Add(Me.grpText)
        Me.tbCells.Location = New System.Drawing.Point(4, 25)
        Me.tbCells.Name = "tbCells"
        Me.tbCells.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCells.Size = New System.Drawing.Size(436, 429)
        Me.tbCells.TabIndex = 0
        Me.tbCells.Text = "Cells"
        Me.tbCells.UseVisualStyleBackColor = True
        '
        'tbColumnsRows
        '
        Me.tbColumnsRows.Location = New System.Drawing.Point(4, 25)
        Me.tbColumnsRows.Name = "tbColumnsRows"
        Me.tbColumnsRows.Padding = New System.Windows.Forms.Padding(3)
        Me.tbColumnsRows.Size = New System.Drawing.Size(436, 429)
        Me.tbColumnsRows.TabIndex = 1
        Me.tbColumnsRows.Text = "Columns & Rows"
        Me.tbColumnsRows.UseVisualStyleBackColor = True
        '
        'tbFormatData
        '
        Me.tbFormatData.Location = New System.Drawing.Point(4, 25)
        Me.tbFormatData.Name = "tbFormatData"
        Me.tbFormatData.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFormatData.Size = New System.Drawing.Size(436, 429)
        Me.tbFormatData.TabIndex = 2
        Me.tbFormatData.Text = "Format Data"
        Me.tbFormatData.UseVisualStyleBackColor = True
        '
        'tbSummary
        '
        Me.tbSummary.Location = New System.Drawing.Point(4, 25)
        Me.tbSummary.Name = "tbSummary"
        Me.tbSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSummary.Size = New System.Drawing.Size(436, 429)
        Me.tbSummary.TabIndex = 3
        Me.tbSummary.Text = "Summary"
        Me.tbSummary.UseVisualStyleBackColor = True
        '
        'tbInfo
        '
        Me.tbInfo.Location = New System.Drawing.Point(4, 25)
        Me.tbInfo.Name = "tbInfo"
        Me.tbInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tbInfo.Size = New System.Drawing.Size(436, 429)
        Me.tbInfo.TabIndex = 4
        Me.tbInfo.Text = "Info"
        Me.tbInfo.UseVisualStyleBackColor = True
        '
        'grpText
        '
        Me.grpText.Location = New System.Drawing.Point(13, 27)
        Me.grpText.Name = "grpText"
        Me.grpText.Size = New System.Drawing.Size(200, 100)
        Me.grpText.TabIndex = 0
        Me.grpText.TabStop = False
        Me.grpText.Text = "Text"
        '
        'sdgTableOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 553)
        Me.Controls.Add(Me.tbTableOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgTableOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Table Options"
        Me.tbTableOptions.ResumeLayout(False)
        Me.tbCells.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents tbTableOptions As TabControl
    Friend WithEvents tbCells As TabPage
    Friend WithEvents tbColumnsRows As TabPage
    Friend WithEvents tbFormatData As TabPage
    Friend WithEvents tbSummary As TabPage
    Friend WithEvents tbInfo As TabPage
    Friend WithEvents grpText As GroupBox
End Class
