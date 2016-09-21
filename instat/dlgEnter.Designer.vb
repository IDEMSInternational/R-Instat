<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgEnter
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
        Me.cmdBrackets = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdPower = New System.Windows.Forms.Button()
        Me.cmdDivide = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.cmdMinus = New System.Windows.Forms.Button()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.cmdDot = New System.Windows.Forms.Button()
        Me.cmd9 = New System.Windows.Forms.Button()
        Me.cmd8 = New System.Windows.Forms.Button()
        Me.cmd7 = New System.Windows.Forms.Button()
        Me.cmd6 = New System.Windows.Forms.Button()
        Me.cmd5 = New System.Windows.Forms.Button()
        Me.cmd4 = New System.Windows.Forms.Button()
        Me.chkShowEnterArguments = New System.Windows.Forms.CheckBox()
        Me.grpEnterBasic = New System.Windows.Forms.GroupBox()
        Me.cmdComma = New System.Windows.Forms.Button()
        Me.cmdColon = New System.Windows.Forms.Button()
        Me.cmdExponential = New System.Windows.Forms.Button()
        Me.cmdSquareBrackets = New System.Windows.Forms.Button()
        Me.cmdMissingValues = New System.Windows.Forms.Button()
        Me.cmd3 = New System.Windows.Forms.Button()
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.cmd0 = New System.Windows.Forms.Button()
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.lblData = New System.Windows.Forms.Label()
        Me.chkSaveEnterResultInto = New System.Windows.Forms.CheckBox()
        Me.ucrSaveEnterResultInto = New instat.ucrInputComboBox()
        Me.ucrDataFrameEnter = New instat.ucrDataFrame()
        Me.ucrReceiverForEnterCalculation = New instat.ucrReceiverExpression()
        Me.ucrEnterBase = New instat.ucrButtons()
        Me.grpEnterBasic.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdBrackets
        '
        Me.cmdBrackets.Location = New System.Drawing.Point(65, 109)
        Me.cmdBrackets.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBrackets.Name = "cmdBrackets"
        Me.cmdBrackets.Size = New System.Drawing.Size(29, 30)
        Me.cmdBrackets.TabIndex = 136
        Me.cmdBrackets.Text = "( )"
        Me.cmdBrackets.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(160, 45)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(35, 30)
        Me.cmdClear.TabIndex = 135
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(160, 77)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(35, 30)
        Me.cmdDelete.TabIndex = 132
        Me.cmdDelete.Tag = "Del"
        Me.cmdDelete.Text = "Del"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        Me.cmdPower.Location = New System.Drawing.Point(127, 45)
        Me.cmdPower.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.Size = New System.Drawing.Size(29, 30)
        Me.cmdPower.TabIndex = 133
        Me.cmdPower.Text = "^"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        Me.cmdDivide.Location = New System.Drawing.Point(96, 14)
        Me.cmdDivide.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.Size = New System.Drawing.Size(29, 30)
        Me.cmdDivide.TabIndex = 131
        Me.cmdDivide.Text = "/"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Location = New System.Drawing.Point(96, 109)
        Me.cmdPlus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(29, 30)
        Me.cmdPlus.TabIndex = 130
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        Me.cmdMinus.Location = New System.Drawing.Point(96, 78)
        Me.cmdMinus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.Size = New System.Drawing.Size(29, 30)
        Me.cmdMinus.TabIndex = 129
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Location = New System.Drawing.Point(96, 45)
        Me.cmdMultiply.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(29, 30)
        Me.cmdMultiply.TabIndex = 128
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdDot
        '
        Me.cmdDot.Location = New System.Drawing.Point(127, 14)
        Me.cmdDot.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDot.Name = "cmdDot"
        Me.cmdDot.Size = New System.Drawing.Size(29, 30)
        Me.cmdDot.TabIndex = 127
        Me.cmdDot.Text = "."
        Me.cmdDot.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        Me.cmd9.Location = New System.Drawing.Point(65, 14)
        Me.cmd9.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(29, 30)
        Me.cmd9.TabIndex = 126
        Me.cmd9.Text = "9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.Location = New System.Drawing.Point(34, 14)
        Me.cmd8.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(29, 30)
        Me.cmd8.TabIndex = 125
        Me.cmd8.Text = "8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        Me.cmd7.Location = New System.Drawing.Point(3, 14)
        Me.cmd7.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(29, 30)
        Me.cmd7.TabIndex = 124
        Me.cmd7.Text = "7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        Me.cmd6.Location = New System.Drawing.Point(65, 45)
        Me.cmd6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(29, 30)
        Me.cmd6.TabIndex = 123
        Me.cmd6.Text = "6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.Location = New System.Drawing.Point(34, 45)
        Me.cmd5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(29, 30)
        Me.cmd5.TabIndex = 122
        Me.cmd5.Text = "5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.Location = New System.Drawing.Point(3, 45)
        Me.cmd4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(29, 30)
        Me.cmd4.TabIndex = 121
        Me.cmd4.Text = "4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'chkShowEnterArguments
        '
        Me.chkShowEnterArguments.AutoSize = True
        Me.chkShowEnterArguments.Location = New System.Drawing.Point(342, 24)
        Me.chkShowEnterArguments.Name = "chkShowEnterArguments"
        Me.chkShowEnterArguments.Size = New System.Drawing.Size(106, 17)
        Me.chkShowEnterArguments.TabIndex = 155
        Me.chkShowEnterArguments.Text = "Show Arguments"
        Me.chkShowEnterArguments.UseVisualStyleBackColor = True
        '
        'grpEnterBasic
        '
        Me.grpEnterBasic.Controls.Add(Me.cmdBrackets)
        Me.grpEnterBasic.Controls.Add(Me.cmdClear)
        Me.grpEnterBasic.Controls.Add(Me.cmdDelete)
        Me.grpEnterBasic.Controls.Add(Me.cmdComma)
        Me.grpEnterBasic.Controls.Add(Me.cmdPower)
        Me.grpEnterBasic.Controls.Add(Me.cmdColon)
        Me.grpEnterBasic.Controls.Add(Me.cmdExponential)
        Me.grpEnterBasic.Controls.Add(Me.cmdDivide)
        Me.grpEnterBasic.Controls.Add(Me.cmdSquareBrackets)
        Me.grpEnterBasic.Controls.Add(Me.cmdMissingValues)
        Me.grpEnterBasic.Controls.Add(Me.cmdPlus)
        Me.grpEnterBasic.Controls.Add(Me.cmdMinus)
        Me.grpEnterBasic.Controls.Add(Me.cmdMultiply)
        Me.grpEnterBasic.Controls.Add(Me.cmdDot)
        Me.grpEnterBasic.Controls.Add(Me.cmd9)
        Me.grpEnterBasic.Controls.Add(Me.cmd8)
        Me.grpEnterBasic.Controls.Add(Me.cmd7)
        Me.grpEnterBasic.Controls.Add(Me.cmd6)
        Me.grpEnterBasic.Controls.Add(Me.cmd5)
        Me.grpEnterBasic.Controls.Add(Me.cmd4)
        Me.grpEnterBasic.Controls.Add(Me.cmd3)
        Me.grpEnterBasic.Controls.Add(Me.cmd2)
        Me.grpEnterBasic.Controls.Add(Me.cmd0)
        Me.grpEnterBasic.Controls.Add(Me.cmd1)
        Me.grpEnterBasic.Location = New System.Drawing.Point(190, 58)
        Me.grpEnterBasic.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpEnterBasic.Name = "grpEnterBasic"
        Me.grpEnterBasic.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpEnterBasic.Size = New System.Drawing.Size(204, 144)
        Me.grpEnterBasic.TabIndex = 154
        Me.grpEnterBasic.TabStop = False
        Me.grpEnterBasic.Text = "Basic"
        '
        'cmdComma
        '
        Me.cmdComma.Location = New System.Drawing.Point(127, 78)
        Me.cmdComma.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdComma.Name = "cmdComma"
        Me.cmdComma.Size = New System.Drawing.Size(29, 30)
        Me.cmdComma.TabIndex = 133
        Me.cmdComma.Text = ","
        Me.cmdComma.UseVisualStyleBackColor = True
        '
        'cmdColon
        '
        Me.cmdColon.Location = New System.Drawing.Point(127, 109)
        Me.cmdColon.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdColon.Name = "cmdColon"
        Me.cmdColon.Size = New System.Drawing.Size(29, 30)
        Me.cmdColon.TabIndex = 131
        Me.cmdColon.Text = ":"
        Me.cmdColon.UseVisualStyleBackColor = True
        '
        'cmdExponential
        '
        Me.cmdExponential.Location = New System.Drawing.Point(160, 109)
        Me.cmdExponential.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdExponential.Name = "cmdExponential"
        Me.cmdExponential.Size = New System.Drawing.Size(35, 30)
        Me.cmdExponential.TabIndex = 130
        Me.cmdExponential.Text = "E"
        Me.cmdExponential.UseVisualStyleBackColor = True
        '
        'cmdSquareBrackets
        '
        Me.cmdSquareBrackets.Location = New System.Drawing.Point(34, 108)
        Me.cmdSquareBrackets.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSquareBrackets.Name = "cmdSquareBrackets"
        Me.cmdSquareBrackets.Size = New System.Drawing.Size(30, 30)
        Me.cmdSquareBrackets.TabIndex = 128
        Me.cmdSquareBrackets.Text = "[ ]"
        Me.cmdSquareBrackets.UseVisualStyleBackColor = True
        '
        'cmdMissingValues
        '
        Me.cmdMissingValues.Location = New System.Drawing.Point(160, 14)
        Me.cmdMissingValues.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMissingValues.Name = "cmdMissingValues"
        Me.cmdMissingValues.Size = New System.Drawing.Size(35, 30)
        Me.cmdMissingValues.TabIndex = 129
        Me.cmdMissingValues.Text = "NA"
        Me.cmdMissingValues.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.Location = New System.Drawing.Point(65, 78)
        Me.cmd3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(29, 30)
        Me.cmd3.TabIndex = 120
        Me.cmd3.Text = "3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.Location = New System.Drawing.Point(34, 78)
        Me.cmd2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(29, 30)
        Me.cmd2.TabIndex = 119
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        Me.cmd0.Location = New System.Drawing.Point(3, 109)
        Me.cmd0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(29, 30)
        Me.cmd0.TabIndex = 118
        Me.cmd0.Text = "0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(3, 78)
        Me.cmd1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(29, 30)
        Me.cmd1.TabIndex = 117
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(21, 28)
        Me.lblData.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(30, 13)
        Me.lblData.TabIndex = 152
        Me.lblData.Tag = "Data"
        Me.lblData.Text = "Data"
        '
        'chkSaveEnterResultInto
        '
        Me.chkSaveEnterResultInto.AutoSize = True
        Me.chkSaveEnterResultInto.Location = New System.Drawing.Point(12, 223)
        Me.chkSaveEnterResultInto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkSaveEnterResultInto.Name = "chkSaveEnterResultInto"
        Me.chkSaveEnterResultInto.Size = New System.Drawing.Size(104, 17)
        Me.chkSaveEnterResultInto.TabIndex = 157
        Me.chkSaveEnterResultInto.Text = "Save Result into"
        Me.chkSaveEnterResultInto.UseVisualStyleBackColor = True
        '
        'ucrSaveEnterResultInto
        '
        Me.ucrSaveEnterResultInto.IsReadOnly = False
        Me.ucrSaveEnterResultInto.Location = New System.Drawing.Point(123, 220)
        Me.ucrSaveEnterResultInto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrSaveEnterResultInto.Name = "ucrSaveEnterResultInto"
        Me.ucrSaveEnterResultInto.Size = New System.Drawing.Size(256, 22)
        Me.ucrSaveEnterResultInto.TabIndex = 158
        '
        'ucrDataFrameEnter
        '
        Me.ucrDataFrameEnter.bUseCurrentFilter = False
        Me.ucrDataFrameEnter.Location = New System.Drawing.Point(9, 72)
        Me.ucrDataFrameEnter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameEnter.Name = "ucrDataFrameEnter"
        Me.ucrDataFrameEnter.Size = New System.Drawing.Size(120, 40)
        Me.ucrDataFrameEnter.TabIndex = 156
        '
        'ucrReceiverForEnterCalculation
        '
        Me.ucrReceiverForEnterCalculation.Location = New System.Drawing.Point(83, 24)
        Me.ucrReceiverForEnterCalculation.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrReceiverForEnterCalculation.Name = "ucrReceiverForEnterCalculation"
        Me.ucrReceiverForEnterCalculation.Selector = Nothing
        Me.ucrReceiverForEnterCalculation.Size = New System.Drawing.Size(254, 28)
        Me.ucrReceiverForEnterCalculation.TabIndex = 153
        '
        'ucrEnterBase
        '
        Me.ucrEnterBase.Location = New System.Drawing.Point(12, 246)
        Me.ucrEnterBase.Name = "ucrEnterBase"
        Me.ucrEnterBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrEnterBase.TabIndex = 0
        '
        'dlgEnter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 310)
        Me.Controls.Add(Me.ucrSaveEnterResultInto)
        Me.Controls.Add(Me.chkSaveEnterResultInto)
        Me.Controls.Add(Me.ucrDataFrameEnter)
        Me.Controls.Add(Me.chkShowEnterArguments)
        Me.Controls.Add(Me.grpEnterBasic)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.ucrReceiverForEnterCalculation)
        Me.Controls.Add(Me.ucrEnterBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgEnter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter"
        Me.grpEnterBasic.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrEnterBase As ucrButtons
    Friend WithEvents cmdBrackets As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdPower As Button
    Friend WithEvents cmdDivide As Button
    Friend WithEvents cmdPlus As Button
    Friend WithEvents cmdMinus As Button
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdDot As Button
    Friend WithEvents cmd9 As Button
    Friend WithEvents cmd8 As Button
    Friend WithEvents cmd7 As Button
    Friend WithEvents cmd6 As Button
    Friend WithEvents cmd5 As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents chkShowEnterArguments As CheckBox
    Friend WithEvents grpEnterBasic As GroupBox
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmd0 As Button
    Friend WithEvents cmd1 As Button
    Friend WithEvents lblData As Label
    Friend WithEvents ucrReceiverForEnterCalculation As ucrReceiverExpression
    Friend WithEvents ucrDataFrameEnter As ucrDataFrame
    Friend WithEvents ucrSaveEnterResultInto As ucrInputComboBox
    Friend WithEvents chkSaveEnterResultInto As CheckBox
    Friend WithEvents cmdComma As Button
    Friend WithEvents cmdColon As Button
    Friend WithEvents cmdExponential As Button
    Friend WithEvents cmdSquareBrackets As Button
    Friend WithEvents cmdMissingValues As Button
End Class
