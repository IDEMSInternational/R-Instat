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
Partial Class dlgTransformText
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgTransformText))
        Me.lblColumnToTransform = New System.Windows.Forms.Label()
        Me.ucrPnlOperation = New instat.UcrPanel()
        Me.lblToSubstring = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblLastWord = New System.Windows.Forms.Label()
        Me.lblFirstWord = New System.Windows.Forms.Label()
        Me.grpParameters = New System.Windows.Forms.GroupBox()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.ucrChkLastOr = New instat.ucrCheck()
        Me.ucrChkFirstOr = New instat.ucrCheck()
        Me.ucrReceiverLastWord = New instat.ucrReceiverSingle()
        Me.ucrNudLastWord = New instat.ucrNud()
        Me.ucrInputPad = New instat.ucrInputComboBox()
        Me.lblPad = New System.Windows.Forms.Label()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrReceiverFirstWord = New instat.ucrReceiverSingle()
        Me.rdoBothPad = New System.Windows.Forms.RadioButton()
        Me.ucrNudFirstWord = New instat.ucrNud()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.rdoRightPad = New System.Windows.Forms.RadioButton()
        Me.rdoLeftPad = New System.Windows.Forms.RadioButton()
        Me.ucrNudWidth = New instat.ucrNud()
        Me.ucrPnlPad = New instat.UcrPanel()
        Me.ucrInputTo = New instat.ucrInputComboBox()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.ucrReceiverTransformText = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNewColName = New instat.ucrSave()
        Me.ucrSelectorForTransformText = New instat.ucrSelectorByDataFrameAddRemove()
        Me.rdoConvertCase = New System.Windows.Forms.RadioButton()
        Me.rdoLength = New System.Windows.Forms.RadioButton()
        Me.rdoPad = New System.Windows.Forms.RadioButton()
        Me.rdoSubstring = New System.Windows.Forms.RadioButton()
        Me.rdoWords = New System.Windows.Forms.RadioButton()
        Me.rdoTrim = New System.Windows.Forms.RadioButton()
        Me.grpParameters.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumnToTransform
        '
        resources.ApplyResources(Me.lblColumnToTransform, "lblColumnToTransform")
        Me.lblColumnToTransform.Name = "lblColumnToTransform"
        '
        'ucrPnlOperation
        '
        resources.ApplyResources(Me.ucrPnlOperation, "ucrPnlOperation")
        Me.ucrPnlOperation.Name = "ucrPnlOperation"
        '
        'lblToSubstring
        '
        resources.ApplyResources(Me.lblToSubstring, "lblToSubstring")
        Me.lblToSubstring.Name = "lblToSubstring"
        '
        'lblFrom
        '
        resources.ApplyResources(Me.lblFrom, "lblFrom")
        Me.lblFrom.Name = "lblFrom"
        '
        'lblSeparator
        '
        resources.ApplyResources(Me.lblSeparator, "lblSeparator")
        Me.lblSeparator.Name = "lblSeparator"
        '
        'lblLastWord
        '
        resources.ApplyResources(Me.lblLastWord, "lblLastWord")
        Me.lblLastWord.Name = "lblLastWord"
        '
        'lblFirstWord
        '
        resources.ApplyResources(Me.lblFirstWord, "lblFirstWord")
        Me.lblFirstWord.Name = "lblFirstWord"
        '
        'grpParameters
        '
        Me.grpParameters.Controls.Add(Me.ucrInputSeparator)
        Me.grpParameters.Controls.Add(Me.ucrChkLastOr)
        Me.grpParameters.Controls.Add(Me.ucrChkFirstOr)
        Me.grpParameters.Controls.Add(Me.ucrReceiverLastWord)
        Me.grpParameters.Controls.Add(Me.ucrNudLastWord)
        Me.grpParameters.Controls.Add(Me.ucrInputPad)
        Me.grpParameters.Controls.Add(Me.lblToSubstring)
        Me.grpParameters.Controls.Add(Me.lblLastWord)
        Me.grpParameters.Controls.Add(Me.lblPad)
        Me.grpParameters.Controls.Add(Me.ucrNudTo)
        Me.grpParameters.Controls.Add(Me.ucrReceiverFirstWord)
        Me.grpParameters.Controls.Add(Me.rdoBothPad)
        Me.grpParameters.Controls.Add(Me.ucrNudFirstWord)
        Me.grpParameters.Controls.Add(Me.ucrNudFrom)
        Me.grpParameters.Controls.Add(Me.rdoRightPad)
        Me.grpParameters.Controls.Add(Me.rdoLeftPad)
        Me.grpParameters.Controls.Add(Me.lblFrom)
        Me.grpParameters.Controls.Add(Me.lblFirstWord)
        Me.grpParameters.Controls.Add(Me.ucrNudWidth)
        Me.grpParameters.Controls.Add(Me.ucrPnlPad)
        Me.grpParameters.Controls.Add(Me.ucrInputTo)
        Me.grpParameters.Controls.Add(Me.lblWidth)
        Me.grpParameters.Controls.Add(Me.lblTo)
        resources.ApplyResources(Me.grpParameters, "grpParameters")
        Me.grpParameters.Name = "grpParameters"
        Me.grpParameters.TabStop = False
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.AddQuotesIfUnrecognised = True
        Me.ucrInputSeparator.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSeparator, "ucrInputSeparator")
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        '
        'ucrChkLastOr
        '
        Me.ucrChkLastOr.Checked = False
        resources.ApplyResources(Me.ucrChkLastOr, "ucrChkLastOr")
        Me.ucrChkLastOr.Name = "ucrChkLastOr"
        '
        'ucrChkFirstOr
        '
        Me.ucrChkFirstOr.Checked = False
        resources.ApplyResources(Me.ucrChkFirstOr, "ucrChkFirstOr")
        Me.ucrChkFirstOr.Name = "ucrChkFirstOr"
        '
        'ucrReceiverLastWord
        '
        Me.ucrReceiverLastWord.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverLastWord, "ucrReceiverLastWord")
        Me.ucrReceiverLastWord.Name = "ucrReceiverLastWord"
        Me.ucrReceiverLastWord.Selector = Nothing
        Me.ucrReceiverLastWord.strNcFilePath = ""
        Me.ucrReceiverLastWord.ucrSelector = Nothing
        '
        'ucrNudLastWord
        '
        Me.ucrNudLastWord.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLastWord.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudLastWord, "ucrNudLastWord")
        Me.ucrNudLastWord.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLastWord.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLastWord.Name = "ucrNudLastWord"
        Me.ucrNudLastWord.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputPad
        '
        Me.ucrInputPad.AddQuotesIfUnrecognised = True
        Me.ucrInputPad.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPad, "ucrInputPad")
        Me.ucrInputPad.Name = "ucrInputPad"
        '
        'lblPad
        '
        resources.ApplyResources(Me.lblPad, "lblPad")
        Me.lblPad.Name = "lblPad"
        '
        'ucrNudTo
        '
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudTo, "ucrNudTo")
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverFirstWord
        '
        Me.ucrReceiverFirstWord.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFirstWord, "ucrReceiverFirstWord")
        Me.ucrReceiverFirstWord.Name = "ucrReceiverFirstWord"
        Me.ucrReceiverFirstWord.Selector = Nothing
        Me.ucrReceiverFirstWord.strNcFilePath = ""
        Me.ucrReceiverFirstWord.ucrSelector = Nothing
        '
        'rdoBothPad
        '
        resources.ApplyResources(Me.rdoBothPad, "rdoBothPad")
        Me.rdoBothPad.Name = "rdoBothPad"
        Me.rdoBothPad.TabStop = True
        Me.rdoBothPad.UseVisualStyleBackColor = True
        '
        'ucrNudFirstWord
        '
        Me.ucrNudFirstWord.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFirstWord.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudFirstWord, "ucrNudFirstWord")
        Me.ucrNudFirstWord.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFirstWord.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFirstWord.Name = "ucrNudFirstWord"
        Me.ucrNudFirstWord.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudFrom, "ucrNudFrom")
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoRightPad
        '
        resources.ApplyResources(Me.rdoRightPad, "rdoRightPad")
        Me.rdoRightPad.Name = "rdoRightPad"
        Me.rdoRightPad.TabStop = True
        Me.rdoRightPad.UseVisualStyleBackColor = True
        '
        'rdoLeftPad
        '
        resources.ApplyResources(Me.rdoLeftPad, "rdoLeftPad")
        Me.rdoLeftPad.Name = "rdoLeftPad"
        Me.rdoLeftPad.TabStop = True
        Me.rdoLeftPad.UseVisualStyleBackColor = True
        '
        'ucrNudWidth
        '
        Me.ucrNudWidth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudWidth, "ucrNudWidth")
        Me.ucrNudWidth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWidth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Name = "ucrNudWidth"
        Me.ucrNudWidth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlPad
        '
        resources.ApplyResources(Me.ucrPnlPad, "ucrPnlPad")
        Me.ucrPnlPad.Name = "ucrPnlPad"
        '
        'ucrInputTo
        '
        Me.ucrInputTo.AddQuotesIfUnrecognised = True
        Me.ucrInputTo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTo, "ucrInputTo")
        Me.ucrInputTo.Name = "ucrInputTo"
        '
        'lblWidth
        '
        resources.ApplyResources(Me.lblWidth, "lblWidth")
        Me.lblWidth.Name = "lblWidth"
        '
        'lblTo
        '
        resources.ApplyResources(Me.lblTo, "lblTo")
        Me.lblTo.Name = "lblTo"
        '
        'ucrReceiverTransformText
        '
        Me.ucrReceiverTransformText.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverTransformText, "ucrReceiverTransformText")
        Me.ucrReceiverTransformText.Name = "ucrReceiverTransformText"
        Me.ucrReceiverTransformText.Selector = Nothing
        Me.ucrReceiverTransformText.strNcFilePath = ""
        Me.ucrReceiverTransformText.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrNewColName
        '
        resources.ApplyResources(Me.ucrNewColName, "ucrNewColName")
        Me.ucrNewColName.Name = "ucrNewColName"
        '
        'ucrSelectorForTransformText
        '
        Me.ucrSelectorForTransformText.bShowHiddenColumns = False
        Me.ucrSelectorForTransformText.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForTransformText, "ucrSelectorForTransformText")
        Me.ucrSelectorForTransformText.Name = "ucrSelectorForTransformText"
        '
        'rdoConvertCase
        '
        resources.ApplyResources(Me.rdoConvertCase, "rdoConvertCase")
        Me.rdoConvertCase.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoConvertCase.FlatAppearance.BorderSize = 2
        Me.rdoConvertCase.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoConvertCase.Name = "rdoConvertCase"
        Me.rdoConvertCase.TabStop = True
        Me.rdoConvertCase.UseVisualStyleBackColor = True
        '
        'rdoLength
        '
        resources.ApplyResources(Me.rdoLength, "rdoLength")
        Me.rdoLength.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLength.FlatAppearance.BorderSize = 2
        Me.rdoLength.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLength.Name = "rdoLength"
        Me.rdoLength.TabStop = True
        Me.rdoLength.UseVisualStyleBackColor = True
        '
        'rdoPad
        '
        resources.ApplyResources(Me.rdoPad, "rdoPad")
        Me.rdoPad.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPad.FlatAppearance.BorderSize = 2
        Me.rdoPad.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPad.Name = "rdoPad"
        Me.rdoPad.TabStop = True
        Me.rdoPad.UseVisualStyleBackColor = True
        '
        'rdoSubstring
        '
        resources.ApplyResources(Me.rdoSubstring, "rdoSubstring")
        Me.rdoSubstring.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSubstring.FlatAppearance.BorderSize = 2
        Me.rdoSubstring.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSubstring.Name = "rdoSubstring"
        Me.rdoSubstring.TabStop = True
        Me.rdoSubstring.UseVisualStyleBackColor = True
        '
        'rdoWords
        '
        resources.ApplyResources(Me.rdoWords, "rdoWords")
        Me.rdoWords.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWords.FlatAppearance.BorderSize = 2
        Me.rdoWords.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWords.Name = "rdoWords"
        Me.rdoWords.TabStop = True
        Me.rdoWords.UseVisualStyleBackColor = True
        '
        'rdoTrim
        '
        resources.ApplyResources(Me.rdoTrim, "rdoTrim")
        Me.rdoTrim.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTrim.FlatAppearance.BorderSize = 2
        Me.rdoTrim.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTrim.Name = "rdoTrim"
        Me.rdoTrim.TabStop = True
        Me.rdoTrim.UseVisualStyleBackColor = True
        '
        'dlgTransformText
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.rdoTrim)
        Me.Controls.Add(Me.rdoWords)
        Me.Controls.Add(Me.rdoSubstring)
        Me.Controls.Add(Me.rdoPad)
        Me.Controls.Add(Me.rdoLength)
        Me.Controls.Add(Me.rdoConvertCase)
        Me.Controls.Add(Me.ucrNewColName)
        Me.Controls.Add(Me.grpParameters)
        Me.Controls.Add(Me.lblColumnToTransform)
        Me.Controls.Add(Me.ucrReceiverTransformText)
        Me.Controls.Add(Me.ucrSelectorForTransformText)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlOperation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTransformText"
        Me.grpParameters.ResumeLayout(False)
        Me.grpParameters.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForTransformText As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverTransformText As ucrReceiverSingle
    Friend WithEvents lblColumnToTransform As Label
    Friend WithEvents ucrReceiverFirstWord As ucrReceiverSingle
    Friend WithEvents lblLastWord As Label
    Friend WithEvents lblFirstWord As Label
    Friend WithEvents lblSeparator As Label
    Friend WithEvents ucrInputSeparator As ucrInputComboBox
    Friend WithEvents lblToSubstring As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents grpParameters As GroupBox
    Friend WithEvents lblPad As Label
    Friend WithEvents ucrInputPad As ucrInputComboBox
    Friend WithEvents lblWidth As Label
    Friend WithEvents ucrInputTo As ucrInputComboBox
    Friend WithEvents lblTo As Label
    Friend WithEvents ucrReceiverLastWord As ucrReceiverSingle
    Friend WithEvents rdoBothPad As RadioButton
    Friend WithEvents rdoRightPad As RadioButton
    Friend WithEvents rdoLeftPad As RadioButton
    Friend WithEvents ucrChkFirstOr As ucrCheck
    Friend WithEvents ucrChkLastOr As ucrCheck
    Friend WithEvents ucrNudLastWord As ucrNud
    Friend WithEvents ucrNudFirstWord As ucrNud
    Friend WithEvents ucrNudWidth As ucrNud
    Friend WithEvents ucrNudFrom As ucrNud
    Friend WithEvents ucrNudTo As ucrNud
    Friend WithEvents ucrPnlPad As UcrPanel
    Friend WithEvents ucrNewColName As ucrSave
    Friend WithEvents ucrPnlOperation As UcrPanel
    Friend WithEvents rdoConvertCase As RadioButton
    Friend WithEvents rdoTrim As RadioButton
    Friend WithEvents rdoWords As RadioButton
    Friend WithEvents rdoSubstring As RadioButton
    Friend WithEvents rdoPad As RadioButton
    Friend WithEvents rdoLength As RadioButton
End Class