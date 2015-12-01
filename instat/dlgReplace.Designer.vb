<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgReplace
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
        Me.lblFindWhat = New System.Windows.Forms.Label()
        Me.lblReplaceWith = New System.Windows.Forms.Label()
        Me.txtFindwhat = New System.Windows.Forms.TextBox()
        Me.txtReplaceWith = New System.Windows.Forms.TextBox()
        Me.btnFindNext = New System.Windows.Forms.Button()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.btnReplaceAll = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.chkFindWholeWordOnly = New System.Windows.Forms.CheckBox()
        Me.chkMatchCase = New System.Windows.Forms.CheckBox()
        Me.chkSearchToEndOnly = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblFindWhat
        '
        Me.lblFindWhat.AutoSize = True
        Me.lblFindWhat.Location = New System.Drawing.Point(13, 13)
        Me.lblFindWhat.Name = "lblFindWhat"
        Me.lblFindWhat.Size = New System.Drawing.Size(53, 13)
        Me.lblFindWhat.TabIndex = 0
        Me.lblFindWhat.Tag = "Find_what"
        Me.lblFindWhat.Text = "Find what"
        '
        'lblReplaceWith
        '
        Me.lblReplaceWith.AutoSize = True
        Me.lblReplaceWith.Location = New System.Drawing.Point(13, 47)
        Me.lblReplaceWith.Name = "lblReplaceWith"
        Me.lblReplaceWith.Size = New System.Drawing.Size(69, 13)
        Me.lblReplaceWith.TabIndex = 0
        Me.lblReplaceWith.Tag = "Replace_with"
        Me.lblReplaceWith.Text = "Replace with"
        '
        'txtFindwhat
        '
        Me.txtFindwhat.Location = New System.Drawing.Point(109, 13)
        Me.txtFindwhat.Name = "txtFindwhat"
        Me.txtFindwhat.Size = New System.Drawing.Size(100, 20)
        Me.txtFindwhat.TabIndex = 1
        Me.txtFindwhat.Tag = "Find_What"
        '
        'txtReplaceWith
        '
        Me.txtReplaceWith.Location = New System.Drawing.Point(109, 56)
        Me.txtReplaceWith.Name = "txtReplaceWith"
        Me.txtReplaceWith.Size = New System.Drawing.Size(100, 20)
        Me.txtReplaceWith.TabIndex = 1
        '
        'btnFindNext
        '
        Me.btnFindNext.Location = New System.Drawing.Point(267, 66)
        Me.btnFindNext.Name = "btnFindNext"
        Me.btnFindNext.Size = New System.Drawing.Size(75, 23)
        Me.btnFindNext.TabIndex = 3
        Me.btnFindNext.Tag = "Find_next"
        Me.btnFindNext.Text = "Find next"
        Me.btnFindNext.UseVisualStyleBackColor = True
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(267, 95)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(75, 23)
        Me.btnReplace.TabIndex = 4
        Me.btnReplace.Tag = "Replace"
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'btnReplaceAll
        '
        Me.btnReplaceAll.Location = New System.Drawing.Point(267, 124)
        Me.btnReplaceAll.Name = "btnReplaceAll"
        Me.btnReplaceAll.Size = New System.Drawing.Size(75, 23)
        Me.btnReplaceAll.TabIndex = 5
        Me.btnReplaceAll.Tag = "Replace_all"
        Me.btnReplaceAll.Text = "Replace all"
        Me.btnReplaceAll.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(267, 153)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Tag = "Close"
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chkFindWholeWordOnly
        '
        Me.chkFindWholeWordOnly.AutoSize = True
        Me.chkFindWholeWordOnly.Location = New System.Drawing.Point(0, 99)
        Me.chkFindWholeWordOnly.Name = "chkFindWholeWordOnly"
        Me.chkFindWholeWordOnly.Size = New System.Drawing.Size(128, 17)
        Me.chkFindWholeWordOnly.TabIndex = 7
        Me.chkFindWholeWordOnly.Tag = "Find_whole_word_only"
        Me.chkFindWholeWordOnly.Text = "Find Whole word only"
        Me.chkFindWholeWordOnly.UseVisualStyleBackColor = True
        '
        'chkMatchCase
        '
        Me.chkMatchCase.AutoSize = True
        Me.chkMatchCase.Location = New System.Drawing.Point(0, 124)
        Me.chkMatchCase.Name = "chkMatchCase"
        Me.chkMatchCase.Size = New System.Drawing.Size(82, 17)
        Me.chkMatchCase.TabIndex = 7
        Me.chkMatchCase.Tag = "Match_case"
        Me.chkMatchCase.Text = "Match case"
        Me.chkMatchCase.UseVisualStyleBackColor = True
        '
        'chkSearchToEndOnly
        '
        Me.chkSearchToEndOnly.AutoSize = True
        Me.chkSearchToEndOnly.Location = New System.Drawing.Point(0, 153)
        Me.chkSearchToEndOnly.Name = "chkSearchToEndOnly"
        Me.chkSearchToEndOnly.Size = New System.Drawing.Size(115, 17)
        Me.chkSearchToEndOnly.TabIndex = 7
        Me.chkSearchToEndOnly.Tag = "Search_to_end_only"
        Me.chkSearchToEndOnly.Text = "Search to end only"
        Me.chkSearchToEndOnly.UseVisualStyleBackColor = True
        '
        'dlgReplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 194)
        Me.Controls.Add(Me.chkSearchToEndOnly)
        Me.Controls.Add(Me.chkMatchCase)
        Me.Controls.Add(Me.chkFindWholeWordOnly)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReplaceAll)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.btnFindNext)
        Me.Controls.Add(Me.txtReplaceWith)
        Me.Controls.Add(Me.txtFindwhat)
        Me.Controls.Add(Me.lblReplaceWith)
        Me.Controls.Add(Me.lblFindWhat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgReplace"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Replace"
        Me.Text = "Replace"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFindWhat As Label
    Friend WithEvents lblReplaceWith As Label
    Friend WithEvents txtFindwhat As TextBox
    Friend WithEvents txtReplaceWith As TextBox
    Friend WithEvents btnFindNext As Button
    Friend WithEvents btnReplace As Button
    Friend WithEvents btnReplaceAll As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents chkFindWholeWordOnly As CheckBox
    Friend WithEvents chkMatchCase As CheckBox
    Friend WithEvents chkSearchToEndOnly As CheckBox
End Class
