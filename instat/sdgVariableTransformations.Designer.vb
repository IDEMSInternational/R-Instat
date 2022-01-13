' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgVariableTransformations
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
        Me.rdoLogBase10 = New System.Windows.Forms.RadioButton()
        Me.rdoSquareRoot = New System.Windows.Forms.RadioButton()
        Me.rdoPolynomial = New System.Windows.Forms.RadioButton()
        Me.rdoNaturalLog = New System.Windows.Forms.RadioButton()
        Me.rdoIdentity = New System.Windows.Forms.RadioButton()
        Me.grpChooseFunction = New System.Windows.Forms.GroupBox()
        Me.ucrNudPolynomial = New instat.ucrNud()
        Me.ucrChkYearAsFactor = New instat.ucrCheck()
        Me.ucrChkMonthAsFactor = New instat.ucrCheck()
        Me.rdoYear = New System.Windows.Forms.RadioButton()
        Me.rdoMonth = New System.Windows.Forms.RadioButton()
        Me.ucrNudSplineDF = New instat.ucrNud()
        Me.ucrInputTxtOwn = New instat.ucrInputTextBox()
        Me.rdoCustom = New System.Windows.Forms.RadioButton()
        Me.ucrInputTxtBrokenStick = New instat.ucrInputTextBox()
        Me.rdoBrokenStick = New System.Windows.Forms.RadioButton()
        Me.rdoSplineDf = New System.Windows.Forms.RadioButton()
        Me.ucrPnlChooseFunction = New instat.UcrPanel()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.ucrInputPreview = New instat.ucrInputTextBox()
        Me.ucrButtonsSDGVarTransform = New instat.ucrButtonsSubdialogue()
        Me.grpChooseFunction.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoLogBase10
        '
        Me.rdoLogBase10.AutoSize = True
        Me.rdoLogBase10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLogBase10.Location = New System.Drawing.Point(23, 59)
        Me.rdoLogBase10.Name = "rdoLogBase10"
        Me.rdoLogBase10.Size = New System.Drawing.Size(85, 17)
        Me.rdoLogBase10.TabIndex = 13
        Me.rdoLogBase10.TabStop = True
        Me.rdoLogBase10.Tag = "Log_Base_10"
        Me.rdoLogBase10.Text = "Log Base 10"
        Me.rdoLogBase10.UseVisualStyleBackColor = True
        '
        'rdoSquareRoot
        '
        Me.rdoSquareRoot.AutoSize = True
        Me.rdoSquareRoot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSquareRoot.Location = New System.Drawing.Point(121, 59)
        Me.rdoSquareRoot.Name = "rdoSquareRoot"
        Me.rdoSquareRoot.Size = New System.Drawing.Size(85, 17)
        Me.rdoSquareRoot.TabIndex = 14
        Me.rdoSquareRoot.TabStop = True
        Me.rdoSquareRoot.Tag = "Square_root"
        Me.rdoSquareRoot.Text = "Square Root"
        Me.rdoSquareRoot.UseVisualStyleBackColor = True
        '
        'rdoPolynomial
        '
        Me.rdoPolynomial.AutoSize = True
        Me.rdoPolynomial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPolynomial.Location = New System.Drawing.Point(23, 87)
        Me.rdoPolynomial.Name = "rdoPolynomial"
        Me.rdoPolynomial.Size = New System.Drawing.Size(78, 17)
        Me.rdoPolynomial.TabIndex = 15
        Me.rdoPolynomial.TabStop = True
        Me.rdoPolynomial.Tag = "Polynomial"
        Me.rdoPolynomial.Text = "Polynomial:"
        Me.rdoPolynomial.UseVisualStyleBackColor = True
        '
        'rdoNaturalLog
        '
        Me.rdoNaturalLog.AutoSize = True
        Me.rdoNaturalLog.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNaturalLog.Location = New System.Drawing.Point(121, 31)
        Me.rdoNaturalLog.Name = "rdoNaturalLog"
        Me.rdoNaturalLog.Size = New System.Drawing.Size(80, 17)
        Me.rdoNaturalLog.TabIndex = 12
        Me.rdoNaturalLog.TabStop = True
        Me.rdoNaturalLog.Tag = "Natural_log"
        Me.rdoNaturalLog.Text = "Natural Log"
        Me.rdoNaturalLog.UseVisualStyleBackColor = True
        '
        'rdoIdentity
        '
        Me.rdoIdentity.AutoSize = True
        Me.rdoIdentity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoIdentity.Location = New System.Drawing.Point(23, 31)
        Me.rdoIdentity.Name = "rdoIdentity"
        Me.rdoIdentity.Size = New System.Drawing.Size(59, 17)
        Me.rdoIdentity.TabIndex = 17
        Me.rdoIdentity.TabStop = True
        Me.rdoIdentity.Tag = "Identity"
        Me.rdoIdentity.Text = "Identity"
        Me.rdoIdentity.UseVisualStyleBackColor = True
        '
        'grpChooseFunction
        '
        Me.grpChooseFunction.Controls.Add(Me.ucrNudPolynomial)
        Me.grpChooseFunction.Controls.Add(Me.ucrChkYearAsFactor)
        Me.grpChooseFunction.Controls.Add(Me.ucrChkMonthAsFactor)
        Me.grpChooseFunction.Controls.Add(Me.rdoYear)
        Me.grpChooseFunction.Controls.Add(Me.rdoMonth)
        Me.grpChooseFunction.Controls.Add(Me.ucrNudSplineDF)
        Me.grpChooseFunction.Controls.Add(Me.ucrInputTxtOwn)
        Me.grpChooseFunction.Controls.Add(Me.rdoCustom)
        Me.grpChooseFunction.Controls.Add(Me.ucrInputTxtBrokenStick)
        Me.grpChooseFunction.Controls.Add(Me.rdoBrokenStick)
        Me.grpChooseFunction.Controls.Add(Me.rdoSplineDf)
        Me.grpChooseFunction.Controls.Add(Me.rdoIdentity)
        Me.grpChooseFunction.Controls.Add(Me.rdoNaturalLog)
        Me.grpChooseFunction.Controls.Add(Me.rdoPolynomial)
        Me.grpChooseFunction.Controls.Add(Me.rdoSquareRoot)
        Me.grpChooseFunction.Controls.Add(Me.rdoLogBase10)
        Me.grpChooseFunction.Controls.Add(Me.ucrPnlChooseFunction)
        Me.grpChooseFunction.Location = New System.Drawing.Point(21, 12)
        Me.grpChooseFunction.Name = "grpChooseFunction"
        Me.grpChooseFunction.Size = New System.Drawing.Size(218, 251)
        Me.grpChooseFunction.TabIndex = 1
        Me.grpChooseFunction.TabStop = False
        Me.grpChooseFunction.Tag = "General_Functions"
        Me.grpChooseFunction.Text = "Choose Function"
        '
        'ucrNudPolynomial
        '
        Me.ucrNudPolynomial.AutoSize = True
        Me.ucrNudPolynomial.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPolynomial.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPolynomial.Location = New System.Drawing.Point(115, 88)
        Me.ucrNudPolynomial.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPolynomial.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPolynomial.Name = "ucrNudPolynomial"
        Me.ucrNudPolynomial.Size = New System.Drawing.Size(52, 21)
        Me.ucrNudPolynomial.TabIndex = 30
        Me.ucrNudPolynomial.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrChkYearAsFactor
        '
        Me.ucrChkYearAsFactor.AutoSize = True
        Me.ucrChkYearAsFactor.Checked = False
        Me.ucrChkYearAsFactor.Location = New System.Drawing.Point(115, 227)
        Me.ucrChkYearAsFactor.Name = "ucrChkYearAsFactor"
        Me.ucrChkYearAsFactor.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkYearAsFactor.TabIndex = 29
        '
        'ucrChkMonthAsFactor
        '
        Me.ucrChkMonthAsFactor.AutoSize = True
        Me.ucrChkMonthAsFactor.Checked = False
        Me.ucrChkMonthAsFactor.Location = New System.Drawing.Point(115, 199)
        Me.ucrChkMonthAsFactor.Name = "ucrChkMonthAsFactor"
        Me.ucrChkMonthAsFactor.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkMonthAsFactor.TabIndex = 28
        '
        'rdoYear
        '
        Me.rdoYear.AutoSize = True
        Me.rdoYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoYear.Location = New System.Drawing.Point(23, 227)
        Me.rdoYear.Name = "rdoYear"
        Me.rdoYear.Size = New System.Drawing.Size(47, 17)
        Me.rdoYear.TabIndex = 27
        Me.rdoYear.TabStop = True
        Me.rdoYear.Tag = ""
        Me.rdoYear.Text = "Year"
        Me.rdoYear.UseVisualStyleBackColor = True
        '
        'rdoMonth
        '
        Me.rdoMonth.AutoSize = True
        Me.rdoMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMonth.Location = New System.Drawing.Point(23, 199)
        Me.rdoMonth.Name = "rdoMonth"
        Me.rdoMonth.Size = New System.Drawing.Size(55, 17)
        Me.rdoMonth.TabIndex = 26
        Me.rdoMonth.TabStop = True
        Me.rdoMonth.Tag = ""
        Me.rdoMonth.Text = "Month"
        Me.rdoMonth.UseVisualStyleBackColor = True
        '
        'ucrNudSplineDF
        '
        Me.ucrNudSplineDF.AutoSize = True
        Me.ucrNudSplineDF.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSplineDF.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSplineDF.Location = New System.Drawing.Point(115, 115)
        Me.ucrNudSplineDF.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSplineDF.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSplineDF.Name = "ucrNudSplineDF"
        Me.ucrNudSplineDF.Size = New System.Drawing.Size(52, 21)
        Me.ucrNudSplineDF.TabIndex = 25
        Me.ucrNudSplineDF.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrInputTxtOwn
        '
        Me.ucrInputTxtOwn.AddQuotesIfUnrecognised = True
        Me.ucrInputTxtOwn.AutoSize = True
        Me.ucrInputTxtOwn.IsMultiline = False
        Me.ucrInputTxtOwn.IsReadOnly = False
        Me.ucrInputTxtOwn.Location = New System.Drawing.Point(115, 171)
        Me.ucrInputTxtOwn.Name = "ucrInputTxtOwn"
        Me.ucrInputTxtOwn.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputTxtOwn.TabIndex = 24
        '
        'rdoCustom
        '
        Me.rdoCustom.AutoSize = True
        Me.rdoCustom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCustom.Location = New System.Drawing.Point(23, 171)
        Me.rdoCustom.Name = "rdoCustom"
        Me.rdoCustom.Size = New System.Drawing.Size(60, 17)
        Me.rdoCustom.TabIndex = 23
        Me.rdoCustom.TabStop = True
        Me.rdoCustom.Tag = ""
        Me.rdoCustom.Text = "Custom"
        Me.rdoCustom.UseVisualStyleBackColor = True
        '
        'ucrInputTxtBrokenStick
        '
        Me.ucrInputTxtBrokenStick.AddQuotesIfUnrecognised = True
        Me.ucrInputTxtBrokenStick.AutoSize = True
        Me.ucrInputTxtBrokenStick.IsMultiline = False
        Me.ucrInputTxtBrokenStick.IsReadOnly = False
        Me.ucrInputTxtBrokenStick.Location = New System.Drawing.Point(115, 144)
        Me.ucrInputTxtBrokenStick.Name = "ucrInputTxtBrokenStick"
        Me.ucrInputTxtBrokenStick.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputTxtBrokenStick.TabIndex = 22
        '
        'rdoBrokenStick
        '
        Me.rdoBrokenStick.AutoSize = True
        Me.rdoBrokenStick.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBrokenStick.Location = New System.Drawing.Point(23, 143)
        Me.rdoBrokenStick.Name = "rdoBrokenStick"
        Me.rdoBrokenStick.Size = New System.Drawing.Size(86, 17)
        Me.rdoBrokenStick.TabIndex = 21
        Me.rdoBrokenStick.TabStop = True
        Me.rdoBrokenStick.Tag = ""
        Me.rdoBrokenStick.Text = "Broken Stick"
        Me.rdoBrokenStick.UseVisualStyleBackColor = True
        '
        'rdoSplineDf
        '
        Me.rdoSplineDf.AutoSize = True
        Me.rdoSplineDf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSplineDf.Location = New System.Drawing.Point(23, 115)
        Me.rdoSplineDf.Name = "rdoSplineDf"
        Me.rdoSplineDf.Size = New System.Drawing.Size(72, 17)
        Me.rdoSplineDf.TabIndex = 19
        Me.rdoSplineDf.TabStop = True
        Me.rdoSplineDf.Tag = ""
        Me.rdoSplineDf.Text = "Spline d.f."
        Me.rdoSplineDf.UseVisualStyleBackColor = True
        '
        'ucrPnlChooseFunction
        '
        Me.ucrPnlChooseFunction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlChooseFunction.Location = New System.Drawing.Point(7, 27)
        Me.ucrPnlChooseFunction.Name = "ucrPnlChooseFunction"
        Me.ucrPnlChooseFunction.Size = New System.Drawing.Size(204, 217)
        Me.ucrPnlChooseFunction.TabIndex = 3
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPreview.Location = New System.Drawing.Point(27, 282)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(48, 13)
        Me.lblPreview.TabIndex = 3
        Me.lblPreview.Text = "Preview:"
        '
        'ucrInputPreview
        '
        Me.ucrInputPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputPreview.AutoSize = True
        Me.ucrInputPreview.IsMultiline = False
        Me.ucrInputPreview.IsReadOnly = True
        Me.ucrInputPreview.Location = New System.Drawing.Point(81, 279)
        Me.ucrInputPreview.Name = "ucrInputPreview"
        Me.ucrInputPreview.Size = New System.Drawing.Size(158, 21)
        Me.ucrInputPreview.TabIndex = 4
        '
        'ucrButtonsSDGVarTransform
        '
        Me.ucrButtonsSDGVarTransform.AutoSize = True
        Me.ucrButtonsSDGVarTransform.Location = New System.Drawing.Point(56, 318)
        Me.ucrButtonsSDGVarTransform.Name = "ucrButtonsSDGVarTransform"
        Me.ucrButtonsSDGVarTransform.Size = New System.Drawing.Size(224, 30)
        Me.ucrButtonsSDGVarTransform.TabIndex = 2
        '
        'sdgVariableTransformations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(265, 348)
        Me.Controls.Add(Me.ucrInputPreview)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.ucrButtonsSDGVarTransform)
        Me.Controls.Add(Me.grpChooseFunction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgVariableTransformations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Variable _Transformations"
        Me.Text = "Variable Transformations"
        Me.grpChooseFunction.ResumeLayout(False)
        Me.grpChooseFunction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrButtonsSDGVarTransform As ucrButtonsSubdialogue
    Friend WithEvents rdoLogBase10 As RadioButton
    Friend WithEvents rdoSquareRoot As RadioButton
    Friend WithEvents rdoPolynomial As RadioButton
    Friend WithEvents rdoNaturalLog As RadioButton
    Friend WithEvents rdoIdentity As RadioButton
    Friend WithEvents grpChooseFunction As GroupBox
    Friend WithEvents ucrPnlChooseFunction As UcrPanel
    Friend WithEvents lblPreview As Label
    Friend WithEvents ucrInputPreview As ucrInputTextBox
    Friend WithEvents rdoSplineDf As RadioButton
    Friend WithEvents ucrInputTxtOwn As ucrInputTextBox
    Friend WithEvents rdoCustom As RadioButton
    Friend WithEvents ucrInputTxtBrokenStick As ucrInputTextBox
    Friend WithEvents rdoBrokenStick As RadioButton
    Friend WithEvents ucrNudSplineDF As ucrNud
    Friend WithEvents ucrChkYearAsFactor As ucrCheck
    Friend WithEvents ucrChkMonthAsFactor As ucrCheck
    Friend WithEvents rdoYear As RadioButton
    Friend WithEvents rdoMonth As RadioButton
    Friend WithEvents ucrNudPolynomial As ucrNud
End Class
