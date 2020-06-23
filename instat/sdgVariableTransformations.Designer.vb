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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgVariableTransformations))
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
        resources.ApplyResources(Me.rdoLogBase10, "rdoLogBase10")
        Me.rdoLogBase10.Name = "rdoLogBase10"
        Me.rdoLogBase10.TabStop = True
        Me.rdoLogBase10.Tag = "Log_Base_10"
        Me.rdoLogBase10.UseVisualStyleBackColor = True
        '
        'rdoSquareRoot
        '
        resources.ApplyResources(Me.rdoSquareRoot, "rdoSquareRoot")
        Me.rdoSquareRoot.Name = "rdoSquareRoot"
        Me.rdoSquareRoot.TabStop = True
        Me.rdoSquareRoot.Tag = "Square_root"
        Me.rdoSquareRoot.UseVisualStyleBackColor = True
        '
        'rdoPolynomial
        '
        resources.ApplyResources(Me.rdoPolynomial, "rdoPolynomial")
        Me.rdoPolynomial.Name = "rdoPolynomial"
        Me.rdoPolynomial.TabStop = True
        Me.rdoPolynomial.Tag = "Polynomial"
        Me.rdoPolynomial.UseVisualStyleBackColor = True
        '
        'rdoNaturalLog
        '
        resources.ApplyResources(Me.rdoNaturalLog, "rdoNaturalLog")
        Me.rdoNaturalLog.Name = "rdoNaturalLog"
        Me.rdoNaturalLog.TabStop = True
        Me.rdoNaturalLog.Tag = "Natural_log"
        Me.rdoNaturalLog.UseVisualStyleBackColor = True
        '
        'rdoIdentity
        '
        resources.ApplyResources(Me.rdoIdentity, "rdoIdentity")
        Me.rdoIdentity.Name = "rdoIdentity"
        Me.rdoIdentity.TabStop = True
        Me.rdoIdentity.Tag = "Identity"
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
        resources.ApplyResources(Me.grpChooseFunction, "grpChooseFunction")
        Me.grpChooseFunction.Name = "grpChooseFunction"
        Me.grpChooseFunction.TabStop = False
        Me.grpChooseFunction.Tag = "General_Functions"
        '
        'ucrNudPolynomial
        '
        Me.ucrNudPolynomial.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPolynomial.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudPolynomial, "ucrNudPolynomial")
        Me.ucrNudPolynomial.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPolynomial.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPolynomial.Name = "ucrNudPolynomial"
        Me.ucrNudPolynomial.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrChkYearAsFactor
        '
        Me.ucrChkYearAsFactor.Checked = False
        resources.ApplyResources(Me.ucrChkYearAsFactor, "ucrChkYearAsFactor")
        Me.ucrChkYearAsFactor.Name = "ucrChkYearAsFactor"
        '
        'ucrChkMonthAsFactor
        '
        Me.ucrChkMonthAsFactor.Checked = False
        resources.ApplyResources(Me.ucrChkMonthAsFactor, "ucrChkMonthAsFactor")
        Me.ucrChkMonthAsFactor.Name = "ucrChkMonthAsFactor"
        '
        'rdoYear
        '
        resources.ApplyResources(Me.rdoYear, "rdoYear")
        Me.rdoYear.Name = "rdoYear"
        Me.rdoYear.TabStop = True
        Me.rdoYear.Tag = ""
        Me.rdoYear.UseVisualStyleBackColor = True
        '
        'rdoMonth
        '
        resources.ApplyResources(Me.rdoMonth, "rdoMonth")
        Me.rdoMonth.Name = "rdoMonth"
        Me.rdoMonth.TabStop = True
        Me.rdoMonth.Tag = ""
        Me.rdoMonth.UseVisualStyleBackColor = True
        '
        'ucrNudSplineDF
        '
        Me.ucrNudSplineDF.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSplineDF.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSplineDF, "ucrNudSplineDF")
        Me.ucrNudSplineDF.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSplineDF.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSplineDF.Name = "ucrNudSplineDF"
        Me.ucrNudSplineDF.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrInputTxtOwn
        '
        Me.ucrInputTxtOwn.AddQuotesIfUnrecognised = True
        Me.ucrInputTxtOwn.IsMultiline = False
        Me.ucrInputTxtOwn.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTxtOwn, "ucrInputTxtOwn")
        Me.ucrInputTxtOwn.Name = "ucrInputTxtOwn"
        '
        'rdoCustom
        '
        resources.ApplyResources(Me.rdoCustom, "rdoCustom")
        Me.rdoCustom.Name = "rdoCustom"
        Me.rdoCustom.TabStop = True
        Me.rdoCustom.Tag = ""
        Me.rdoCustom.UseVisualStyleBackColor = True
        '
        'ucrInputTxtBrokenStick
        '
        Me.ucrInputTxtBrokenStick.AddQuotesIfUnrecognised = True
        Me.ucrInputTxtBrokenStick.IsMultiline = False
        Me.ucrInputTxtBrokenStick.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTxtBrokenStick, "ucrInputTxtBrokenStick")
        Me.ucrInputTxtBrokenStick.Name = "ucrInputTxtBrokenStick"
        '
        'rdoBrokenStick
        '
        resources.ApplyResources(Me.rdoBrokenStick, "rdoBrokenStick")
        Me.rdoBrokenStick.Name = "rdoBrokenStick"
        Me.rdoBrokenStick.TabStop = True
        Me.rdoBrokenStick.Tag = ""
        Me.rdoBrokenStick.UseVisualStyleBackColor = True
        '
        'rdoSplineDf
        '
        resources.ApplyResources(Me.rdoSplineDf, "rdoSplineDf")
        Me.rdoSplineDf.Name = "rdoSplineDf"
        Me.rdoSplineDf.TabStop = True
        Me.rdoSplineDf.Tag = ""
        Me.rdoSplineDf.UseVisualStyleBackColor = True
        '
        'ucrPnlChooseFunction
        '
        resources.ApplyResources(Me.ucrPnlChooseFunction, "ucrPnlChooseFunction")
        Me.ucrPnlChooseFunction.Name = "ucrPnlChooseFunction"
        '
        'lblPreview
        '
        resources.ApplyResources(Me.lblPreview, "lblPreview")
        Me.lblPreview.Name = "lblPreview"
        '
        'ucrInputPreview
        '
        Me.ucrInputPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputPreview.IsMultiline = False
        Me.ucrInputPreview.IsReadOnly = True
        resources.ApplyResources(Me.ucrInputPreview, "ucrInputPreview")
        Me.ucrInputPreview.Name = "ucrInputPreview"
        '
        'ucrButtonsSDGVarTransform
        '
        resources.ApplyResources(Me.ucrButtonsSDGVarTransform, "ucrButtonsSDGVarTransform")
        Me.ucrButtonsSDGVarTransform.Name = "ucrButtonsSDGVarTransform"
        '
        'sdgVariableTransformations
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputPreview)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.ucrButtonsSDGVarTransform)
        Me.Controls.Add(Me.grpChooseFunction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgVariableTransformations"
        Me.Tag = "Variable _Transformations"
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
