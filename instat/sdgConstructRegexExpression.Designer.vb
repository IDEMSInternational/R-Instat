<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgConstructRegexExpression
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
        Me.components = New System.ComponentModel.Container()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.ucrReceiverForRegex = New instat.ucrReceiverExpression()
        Me.lblExpression = New System.Windows.Forms.Label()
        Me.grpSymbols = New System.Windows.Forms.GroupBox()
        Me.cmdOr3 = New System.Windows.Forms.Button()
        Me.cmdEscape = New System.Windows.Forms.Button()
        Me.cmdPlusZero = New System.Windows.Forms.Button()
        Me.cmdZero = New System.Windows.Forms.Button()
        Me.cmdPlusOne = New System.Windows.Forms.Button()
        Me.cmdZeroOrOne = New System.Windows.Forms.Button()
        Me.cmdNumbers = New System.Windows.Forms.Button()
        Me.cmdNot1 = New System.Windows.Forms.Button()
        Me.cmdOr2 = New System.Windows.Forms.Button()
        Me.cmdOr1 = New System.Windows.Forms.Button()
        Me.cmdSpace = New System.Windows.Forms.Button()
        Me.cmdDigit = New System.Windows.Forms.Button()
        Me.cmdEnd1 = New System.Windows.Forms.Button()
        Me.cmdbegin = New System.Windows.Forms.Button()
        Me.cmdAny1 = New System.Windows.Forms.Button()
        Me.ttAddKeyboard = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpSymbols.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(55, 168)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseSubdialog.TabIndex = 8
        '
        'ucrReceiverForRegex
        '
        Me.ucrReceiverForRegex.AutoSize = True
        Me.ucrReceiverForRegex.frmParent = Me
        Me.ucrReceiverForRegex.Location = New System.Drawing.Point(69, 12)
        Me.ucrReceiverForRegex.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrReceiverForRegex.Name = "ucrReceiverForRegex"
        Me.ucrReceiverForRegex.Selector = Nothing
        Me.ucrReceiverForRegex.Size = New System.Drawing.Size(281, 29)
        Me.ucrReceiverForRegex.strNcFilePath = ""
        Me.ucrReceiverForRegex.TabIndex = 122
        Me.ucrReceiverForRegex.ucrSelector = Nothing
        '
        'lblExpression
        '
        Me.lblExpression.AutoSize = True
        Me.lblExpression.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExpression.Location = New System.Drawing.Point(5, 16)
        Me.lblExpression.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExpression.Name = "lblExpression"
        Me.lblExpression.Size = New System.Drawing.Size(61, 13)
        Me.lblExpression.TabIndex = 121
        Me.lblExpression.Tag = "Expression"
        Me.lblExpression.Text = "Expression:"
        '
        'grpSymbols
        '
        Me.grpSymbols.Controls.Add(Me.cmdOr3)
        Me.grpSymbols.Controls.Add(Me.cmdEscape)
        Me.grpSymbols.Controls.Add(Me.cmdPlusZero)
        Me.grpSymbols.Controls.Add(Me.cmdZero)
        Me.grpSymbols.Controls.Add(Me.cmdPlusOne)
        Me.grpSymbols.Controls.Add(Me.cmdZeroOrOne)
        Me.grpSymbols.Controls.Add(Me.cmdNumbers)
        Me.grpSymbols.Controls.Add(Me.cmdNot1)
        Me.grpSymbols.Controls.Add(Me.cmdOr2)
        Me.grpSymbols.Controls.Add(Me.cmdOr1)
        Me.grpSymbols.Controls.Add(Me.cmdSpace)
        Me.grpSymbols.Controls.Add(Me.cmdDigit)
        Me.grpSymbols.Controls.Add(Me.cmdEnd1)
        Me.grpSymbols.Controls.Add(Me.cmdbegin)
        Me.grpSymbols.Controls.Add(Me.cmdAny1)
        Me.grpSymbols.Location = New System.Drawing.Point(20, 46)
        Me.grpSymbols.Margin = New System.Windows.Forms.Padding(2)
        Me.grpSymbols.Name = "grpSymbols"
        Me.grpSymbols.Padding = New System.Windows.Forms.Padding(2)
        Me.grpSymbols.Size = New System.Drawing.Size(316, 112)
        Me.grpSymbols.TabIndex = 194
        Me.grpSymbols.TabStop = False
        Me.grpSymbols.Text = "Symbols"
        '
        'cmdOr3
        '
        Me.cmdOr3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOr3.Location = New System.Drawing.Point(127, 46)
        Me.cmdOr3.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdOr3.Name = "cmdOr3"
        Me.cmdOr3.Size = New System.Drawing.Size(63, 30)
        Me.cmdOr3.TabIndex = 16
        Me.cmdOr3.Text = "| or"
        Me.cmdOr3.UseVisualStyleBackColor = True
        '
        'cmdEscape
        '
        Me.cmdEscape.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEscape.Location = New System.Drawing.Point(189, 75)
        Me.cmdEscape.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdEscape.Name = "cmdEscape"
        Me.cmdEscape.Size = New System.Drawing.Size(63, 30)
        Me.cmdEscape.TabIndex = 14
        Me.cmdEscape.Text = "\\ escape"
        Me.cmdEscape.UseVisualStyleBackColor = True
        '
        'cmdPlusZero
        '
        Me.cmdPlusZero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlusZero.Location = New System.Drawing.Point(251, 75)
        Me.cmdPlusZero.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdPlusZero.Name = "cmdPlusZero"
        Me.cmdPlusZero.Size = New System.Drawing.Size(63, 30)
        Me.cmdPlusZero.TabIndex = 15
        Me.cmdPlusZero.Text = "- to"
        Me.cmdPlusZero.UseVisualStyleBackColor = True
        '
        'cmdZero
        '
        Me.cmdZero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdZero.Location = New System.Drawing.Point(127, 75)
        Me.cmdZero.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdZero.Name = "cmdZero"
        Me.cmdZero.Size = New System.Drawing.Size(63, 30)
        Me.cmdZero.TabIndex = 13
        Me.cmdZero.Text = "* 0+"
        Me.cmdZero.UseVisualStyleBackColor = True
        '
        'cmdPlusOne
        '
        Me.cmdPlusOne.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlusOne.Location = New System.Drawing.Point(64, 75)
        Me.cmdPlusOne.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdPlusOne.Name = "cmdPlusOne"
        Me.cmdPlusOne.Size = New System.Drawing.Size(63, 30)
        Me.cmdPlusOne.TabIndex = 12
        Me.cmdPlusOne.Text = "+ 1+"
        Me.cmdPlusOne.UseVisualStyleBackColor = True
        '
        'cmdZeroOrOne
        '
        Me.cmdZeroOrOne.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdZeroOrOne.Location = New System.Drawing.Point(2, 75)
        Me.cmdZeroOrOne.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdZeroOrOne.Name = "cmdZeroOrOne"
        Me.cmdZeroOrOne.Size = New System.Drawing.Size(63, 30)
        Me.cmdZeroOrOne.TabIndex = 11
        Me.cmdZeroOrOne.Text = "? 0 or 1"
        Me.cmdZeroOrOne.UseVisualStyleBackColor = True
        '
        'cmdNumbers
        '
        Me.cmdNumbers.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNumbers.Location = New System.Drawing.Point(251, 46)
        Me.cmdNumbers.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdNumbers.Name = "cmdNumbers"
        Me.cmdNumbers.Size = New System.Drawing.Size(63, 30)
        Me.cmdNumbers.TabIndex = 10
        Me.cmdNumbers.Text = "{ m,n } "
        Me.cmdNumbers.UseVisualStyleBackColor = True
        '
        'cmdNot1
        '
        Me.cmdNot1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNot1.Location = New System.Drawing.Point(64, 46)
        Me.cmdNot1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdNot1.Name = "cmdNot1"
        Me.cmdNot1.Size = New System.Drawing.Size(63, 30)
        Me.cmdNot1.TabIndex = 8
        Me.cmdNot1.Text = "[^ ] not"
        Me.cmdNot1.UseVisualStyleBackColor = True
        '
        'cmdOr2
        '
        Me.cmdOr2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOr2.Location = New System.Drawing.Point(189, 46)
        Me.cmdOr2.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdOr2.Name = "cmdOr2"
        Me.cmdOr2.Size = New System.Drawing.Size(63, 30)
        Me.cmdOr2.TabIndex = 9
        Me.cmdOr2.Text = "{ n} "
        Me.cmdOr2.UseVisualStyleBackColor = True
        '
        'cmdOr1
        '
        Me.cmdOr1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOr1.Location = New System.Drawing.Point(2, 46)
        Me.cmdOr1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdOr1.Name = "cmdOr1"
        Me.cmdOr1.Size = New System.Drawing.Size(63, 30)
        Me.cmdOr1.TabIndex = 7
        Me.cmdOr1.Text = "[ ] or"
        Me.cmdOr1.UseVisualStyleBackColor = True
        '
        'cmdSpace
        '
        Me.cmdSpace.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSpace.Location = New System.Drawing.Point(251, 16)
        Me.cmdSpace.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSpace.Name = "cmdSpace"
        Me.cmdSpace.Size = New System.Drawing.Size(63, 30)
        Me.cmdSpace.TabIndex = 6
        Me.cmdSpace.Text = "\\s space"
        Me.cmdSpace.UseVisualStyleBackColor = True
        '
        'cmdDigit
        '
        Me.cmdDigit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDigit.Location = New System.Drawing.Point(189, 16)
        Me.cmdDigit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdDigit.Name = "cmdDigit"
        Me.cmdDigit.Size = New System.Drawing.Size(63, 30)
        Me.cmdDigit.TabIndex = 5
        Me.cmdDigit.Text = "\\d digit"
        Me.cmdDigit.UseVisualStyleBackColor = True
        '
        'cmdEnd1
        '
        Me.cmdEnd1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEnd1.Location = New System.Drawing.Point(127, 16)
        Me.cmdEnd1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdEnd1.Name = "cmdEnd1"
        Me.cmdEnd1.Size = New System.Drawing.Size(63, 30)
        Me.cmdEnd1.TabIndex = 4
        Me.cmdEnd1.Text = "$ end"
        Me.cmdEnd1.UseVisualStyleBackColor = True
        '
        'cmdbegin
        '
        Me.cmdbegin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdbegin.Location = New System.Drawing.Point(64, 16)
        Me.cmdbegin.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdbegin.Name = "cmdbegin"
        Me.cmdbegin.Size = New System.Drawing.Size(63, 30)
        Me.cmdbegin.TabIndex = 3
        Me.cmdbegin.Text = "^ begin"
        Me.cmdbegin.UseVisualStyleBackColor = True
        '
        'cmdAny1
        '
        Me.cmdAny1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAny1.Location = New System.Drawing.Point(2, 16)
        Me.cmdAny1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdAny1.Name = "cmdAny1"
        Me.cmdAny1.Size = New System.Drawing.Size(63, 30)
        Me.cmdAny1.TabIndex = 2
        Me.cmdAny1.Text = ". any"
        Me.cmdAny1.UseVisualStyleBackColor = True
        '
        'ttAddKeyboard
        '
        Me.ttAddKeyboard.AutoPopDelay = 10000
        Me.ttAddKeyboard.InitialDelay = 500
        Me.ttAddKeyboard.ReshowDelay = 100
        '
        'sdgConstructRegexExpression
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(361, 215)
        Me.Controls.Add(Me.grpSymbols)
        Me.Controls.Add(Me.ucrReceiverForRegex)
        Me.Controls.Add(Me.lblExpression)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgConstructRegexExpression"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Construct regex expression"
        Me.grpSymbols.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents ucrReceiverForRegex As ucrReceiverExpression
    Friend WithEvents lblExpression As Label
    Friend WithEvents grpSymbols As GroupBox
    Friend WithEvents cmdOr3 As Button
    Friend WithEvents cmdEscape As Button
    Friend WithEvents cmdPlusZero As Button
    Friend WithEvents cmdZero As Button
    Friend WithEvents cmdPlusOne As Button
    Friend WithEvents cmdZeroOrOne As Button
    Friend WithEvents cmdNumbers As Button
    Friend WithEvents cmdNot1 As Button
    Friend WithEvents cmdOr2 As Button
    Friend WithEvents cmdOr1 As Button
    Friend WithEvents cmdSpace As Button
    Friend WithEvents cmdDigit As Button
    Friend WithEvents cmdEnd1 As Button
    Friend WithEvents cmdbegin As Button
    Friend WithEvents cmdAny1 As Button
    Friend WithEvents ttAddKeyboard As ToolTip
End Class
