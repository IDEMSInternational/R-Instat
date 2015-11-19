<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFind
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
        Me.btnFindNext = New System.Windows.Forms.Button()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.chkSearchToEndOnly = New System.Windows.Forms.CheckBox()
        Me.chkMatchCase = New System.Windows.Forms.CheckBox()
        Me.chkFindWholeWordOnly = New System.Windows.Forms.CheckBox()
        Me.lblFindWhat = New System.Windows.Forms.Label()
        Me.txtFindWhat = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnFindNext
        '
        Me.btnFindNext.Location = New System.Drawing.Point(268, 39)
        Me.btnFindNext.Name = "btnFindNext"
        Me.btnFindNext.Size = New System.Drawing.Size(75, 23)
        Me.btnFindNext.TabIndex = 0
        Me.btnFindNext.Tag = "Find_next"
        Me.btnFindNext.Text = "Find next"
        Me.btnFindNext.UseVisualStyleBackColor = True
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(268, 68)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(75, 23)
        Me.btnReplace.TabIndex = 1
        Me.btnReplace.Tag = "Replace"
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(268, 140)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Tag = "Close"
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chkSearchToEndOnly
        '
        Me.chkSearchToEndOnly.AutoSize = True
        Me.chkSearchToEndOnly.Location = New System.Drawing.Point(13, 100)
        Me.chkSearchToEndOnly.Name = "chkSearchToEndOnly"
        Me.chkSearchToEndOnly.Size = New System.Drawing.Size(115, 17)
        Me.chkSearchToEndOnly.TabIndex = 3
        Me.chkSearchToEndOnly.Tag = "Search_to_end_only"
        Me.chkSearchToEndOnly.Text = "Search to end only"
        Me.chkSearchToEndOnly.UseVisualStyleBackColor = True
        '
        'chkMatchCase
        '
        Me.chkMatchCase.AutoSize = True
        Me.chkMatchCase.Location = New System.Drawing.Point(13, 123)
        Me.chkMatchCase.Name = "chkMatchCase"
        Me.chkMatchCase.Size = New System.Drawing.Size(83, 17)
        Me.chkMatchCase.TabIndex = 4
        Me.chkMatchCase.Tag = "Match_case"
        Me.chkMatchCase.Text = "Match Case"
        Me.chkMatchCase.UseVisualStyleBackColor = True
        '
        'chkFindWholeWordOnly
        '
        Me.chkFindWholeWordOnly.AutoSize = True
        Me.chkFindWholeWordOnly.Location = New System.Drawing.Point(13, 146)
        Me.chkFindWholeWordOnly.Name = "chkFindWholeWordOnly"
        Me.chkFindWholeWordOnly.Size = New System.Drawing.Size(125, 17)
        Me.chkFindWholeWordOnly.TabIndex = 5
        Me.chkFindWholeWordOnly.Tag = "Find_whole_word_only"
        Me.chkFindWholeWordOnly.Text = "Find whole word only"
        Me.chkFindWholeWordOnly.UseVisualStyleBackColor = True
        '
        'lblFindWhat
        '
        Me.lblFindWhat.AutoSize = True
        Me.lblFindWhat.Location = New System.Drawing.Point(13, 13)
        Me.lblFindWhat.Name = "lblFindWhat"
        Me.lblFindWhat.Size = New System.Drawing.Size(53, 13)
        Me.lblFindWhat.TabIndex = 6
        Me.lblFindWhat.Tag = "Find_what"
        Me.lblFindWhat.Text = "Find what"
        '
        'txtFindWhat
        '
        Me.txtFindWhat.Location = New System.Drawing.Point(83, 13)
        Me.txtFindWhat.Name = "txtFindWhat"
        Me.txtFindWhat.Size = New System.Drawing.Size(161, 20)
        Me.txtFindWhat.TabIndex = 7
        '
        'dlgFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 190)
        Me.Controls.Add(Me.txtFindWhat)
        Me.Controls.Add(Me.lblFindWhat)
        Me.Controls.Add(Me.chkFindWholeWordOnly)
        Me.Controls.Add(Me.chkMatchCase)
        Me.Controls.Add(Me.chkSearchToEndOnly)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.btnFindNext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgFind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Find"
        Me.Text = "Find"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFindNext As Button
    Friend WithEvents btnReplace As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents chkSearchToEndOnly As CheckBox
    Friend WithEvents chkMatchCase As CheckBox
    Friend WithEvents chkFindWholeWordOnly As CheckBox
    Friend WithEvents lblFindWhat As Label
    Friend WithEvents txtFindWhat As TextBox
End Class
