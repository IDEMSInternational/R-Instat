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
Partial Class ucrAxes
    Inherits instat.ucrCore

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrAxes))
        Me.grpAxisTitle = New System.Windows.Forms.GroupBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.rdoSpecifyTitle = New System.Windows.Forms.RadioButton()
        Me.rdoNoTitle = New System.Windows.Forms.RadioButton()
        Me.rdoTitleAuto = New System.Windows.Forms.RadioButton()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrPnlAxisTitle = New instat.UcrPanel()
        Me.grpMajorBreaks = New System.Windows.Forms.GroupBox()
        Me.ucrChkLabels = New instat.ucrCheck()
        Me.ucrInputMajorBreaksLabels = New instat.ucrInputTextBox()
        Me.rdoMajorBreaksSeq = New System.Windows.Forms.RadioButton()
        Me.rdoMajorBreaksCustom = New System.Windows.Forms.RadioButton()
        Me.ucrInputMajorBreaksInStepsOf = New instat.ucrInputTextBox()
        Me.rdoMajorBreaksNone = New System.Windows.Forms.RadioButton()
        Me.ucrInputMajorBreaksTo = New instat.ucrInputTextBox()
        Me.ucrInputMajorBreaksFrom = New instat.ucrInputTextBox()
        Me.rdoMajorBreaksAuto = New System.Windows.Forms.RadioButton()
        Me.lblMajorBreaksInStepsOf = New System.Windows.Forms.Label()
        Me.lblMajorBreaksFrom = New System.Windows.Forms.Label()
        Me.lblMajorBreaksTo = New System.Windows.Forms.Label()
        Me.ucrPnlMajorBreaks = New instat.UcrPanel()
        Me.ucrInputMajorBreaksCustom = New instat.ucrInputTextBox()
        Me.grpScales = New System.Windows.Forms.GroupBox()
        Me.ucrInputRelaceMissingvalues = New instat.ucrInputTextBox()
        Me.ucrInputExpand = New instat.ucrInputTextBox()
        Me.ucrInputTransformation = New instat.ucrInputComboBox()
        Me.ucrInputPosition = New instat.ucrInputComboBox()
        Me.ucrChkExpand = New instat.ucrCheck()
        Me.ucrChkTransformation = New instat.ucrCheck()
        Me.ucrChkPosition = New instat.ucrCheck()
        Me.ucrChkNaValue = New instat.ucrCheck()
        Me.ucrInputUpperLimit = New instat.ucrInputTextBox()
        Me.ucrInputLowerLimit = New instat.ucrInputTextBox()
        Me.lblUpperLimit = New System.Windows.Forms.Label()
        Me.lblLowerLimit = New System.Windows.Forms.Label()
        Me.rdoScalesCustom = New System.Windows.Forms.RadioButton()
        Me.rdoScalesAuto = New System.Windows.Forms.RadioButton()
        Me.ucrPnlScales = New instat.UcrPanel()
        Me.ucrInputAxisType = New instat.ucrInputComboBox()
        Me.rdoMinorBreaksSeq = New System.Windows.Forms.RadioButton()
        Me.rdoMinorBreaksCustom = New System.Windows.Forms.RadioButton()
        Me.ucrInputMinorBreaksInStepsOf = New instat.ucrInputTextBox()
        Me.ucrInputMinorBreaksTo = New instat.ucrInputTextBox()
        Me.ucrInputMinorBreaksFrom = New instat.ucrInputTextBox()
        Me.rdoMinorBreaksAuto = New System.Windows.Forms.RadioButton()
        Me.ucrInputMinorBreaksCustom = New instat.ucrInputTextBox()
        Me.lblMinorBreaksInStepsOf = New System.Windows.Forms.Label()
        Me.lblMinorBreaksTo = New System.Windows.Forms.Label()
        Me.ucrPnlMinorBreaks = New instat.UcrPanel()
        Me.grpMinorBreaks = New System.Windows.Forms.GroupBox()
        Me.lblMinorBreaksFrom = New System.Windows.Forms.Label()
        Me.rdoMinorBreaksNone = New System.Windows.Forms.RadioButton()
        Me.grpAxisTitle.SuspendLayout()
        Me.grpMajorBreaks.SuspendLayout()
        Me.grpScales.SuspendLayout()
        Me.grpMinorBreaks.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAxisTitle
        '
        Me.grpAxisTitle.Controls.Add(Me.lblTitle)
        Me.grpAxisTitle.Controls.Add(Me.rdoSpecifyTitle)
        Me.grpAxisTitle.Controls.Add(Me.rdoNoTitle)
        Me.grpAxisTitle.Controls.Add(Me.rdoTitleAuto)
        Me.grpAxisTitle.Controls.Add(Me.ucrInputTitle)
        Me.grpAxisTitle.Controls.Add(Me.ucrPnlAxisTitle)
        resources.ApplyResources(Me.grpAxisTitle, "grpAxisTitle")
        Me.grpAxisTitle.Name = "grpAxisTitle"
        Me.grpAxisTitle.TabStop = False
        '
        'lblTitle
        '
        resources.ApplyResources(Me.lblTitle, "lblTitle")
        Me.lblTitle.Name = "lblTitle"
        '
        'rdoSpecifyTitle
        '
        resources.ApplyResources(Me.rdoSpecifyTitle, "rdoSpecifyTitle")
        Me.rdoSpecifyTitle.Name = "rdoSpecifyTitle"
        Me.rdoSpecifyTitle.TabStop = True
        Me.rdoSpecifyTitle.UseVisualStyleBackColor = True
        '
        'rdoNoTitle
        '
        resources.ApplyResources(Me.rdoNoTitle, "rdoNoTitle")
        Me.rdoNoTitle.Name = "rdoNoTitle"
        Me.rdoNoTitle.TabStop = True
        Me.rdoNoTitle.UseVisualStyleBackColor = True
        '
        'rdoTitleAuto
        '
        resources.ApplyResources(Me.rdoTitleAuto, "rdoTitleAuto")
        Me.rdoTitleAuto.Name = "rdoTitleAuto"
        Me.rdoTitleAuto.TabStop = True
        Me.rdoTitleAuto.UseVisualStyleBackColor = True
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTitle, "ucrInputTitle")
        Me.ucrInputTitle.Name = "ucrInputTitle"
        '
        'ucrPnlAxisTitle
        '
        resources.ApplyResources(Me.ucrPnlAxisTitle, "ucrPnlAxisTitle")
        Me.ucrPnlAxisTitle.Name = "ucrPnlAxisTitle"
        '
        'grpMajorBreaks
        '
        Me.grpMajorBreaks.Controls.Add(Me.ucrChkLabels)
        Me.grpMajorBreaks.Controls.Add(Me.ucrInputMajorBreaksLabels)
        Me.grpMajorBreaks.Controls.Add(Me.rdoMajorBreaksSeq)
        Me.grpMajorBreaks.Controls.Add(Me.rdoMajorBreaksCustom)
        Me.grpMajorBreaks.Controls.Add(Me.ucrInputMajorBreaksInStepsOf)
        Me.grpMajorBreaks.Controls.Add(Me.rdoMajorBreaksNone)
        Me.grpMajorBreaks.Controls.Add(Me.ucrInputMajorBreaksTo)
        Me.grpMajorBreaks.Controls.Add(Me.ucrInputMajorBreaksFrom)
        Me.grpMajorBreaks.Controls.Add(Me.rdoMajorBreaksAuto)
        Me.grpMajorBreaks.Controls.Add(Me.lblMajorBreaksInStepsOf)
        Me.grpMajorBreaks.Controls.Add(Me.lblMajorBreaksFrom)
        Me.grpMajorBreaks.Controls.Add(Me.lblMajorBreaksTo)
        Me.grpMajorBreaks.Controls.Add(Me.ucrPnlMajorBreaks)
        Me.grpMajorBreaks.Controls.Add(Me.ucrInputMajorBreaksCustom)
        resources.ApplyResources(Me.grpMajorBreaks, "grpMajorBreaks")
        Me.grpMajorBreaks.Name = "grpMajorBreaks"
        Me.grpMajorBreaks.TabStop = False
        '
        'ucrChkLabels
        '
        Me.ucrChkLabels.Checked = False
        resources.ApplyResources(Me.ucrChkLabels, "ucrChkLabels")
        Me.ucrChkLabels.Name = "ucrChkLabels"
        '
        'ucrInputMajorBreaksLabels
        '
        Me.ucrInputMajorBreaksLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksLabels.IsMultiline = False
        Me.ucrInputMajorBreaksLabels.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMajorBreaksLabels, "ucrInputMajorBreaksLabels")
        Me.ucrInputMajorBreaksLabels.Name = "ucrInputMajorBreaksLabels"
        '
        'rdoMajorBreaksSeq
        '
        resources.ApplyResources(Me.rdoMajorBreaksSeq, "rdoMajorBreaksSeq")
        Me.rdoMajorBreaksSeq.Name = "rdoMajorBreaksSeq"
        Me.rdoMajorBreaksSeq.TabStop = True
        Me.rdoMajorBreaksSeq.UseVisualStyleBackColor = True
        '
        'rdoMajorBreaksCustom
        '
        resources.ApplyResources(Me.rdoMajorBreaksCustom, "rdoMajorBreaksCustom")
        Me.rdoMajorBreaksCustom.Name = "rdoMajorBreaksCustom"
        Me.rdoMajorBreaksCustom.TabStop = True
        Me.rdoMajorBreaksCustom.UseVisualStyleBackColor = True
        '
        'ucrInputMajorBreaksInStepsOf
        '
        Me.ucrInputMajorBreaksInStepsOf.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksInStepsOf.IsMultiline = False
        Me.ucrInputMajorBreaksInStepsOf.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMajorBreaksInStepsOf, "ucrInputMajorBreaksInStepsOf")
        Me.ucrInputMajorBreaksInStepsOf.Name = "ucrInputMajorBreaksInStepsOf"
        '
        'rdoMajorBreaksNone
        '
        resources.ApplyResources(Me.rdoMajorBreaksNone, "rdoMajorBreaksNone")
        Me.rdoMajorBreaksNone.Name = "rdoMajorBreaksNone"
        Me.rdoMajorBreaksNone.TabStop = True
        Me.rdoMajorBreaksNone.UseVisualStyleBackColor = True
        '
        'ucrInputMajorBreaksTo
        '
        Me.ucrInputMajorBreaksTo.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksTo.IsMultiline = False
        Me.ucrInputMajorBreaksTo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMajorBreaksTo, "ucrInputMajorBreaksTo")
        Me.ucrInputMajorBreaksTo.Name = "ucrInputMajorBreaksTo"
        '
        'ucrInputMajorBreaksFrom
        '
        Me.ucrInputMajorBreaksFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksFrom.IsMultiline = False
        Me.ucrInputMajorBreaksFrom.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMajorBreaksFrom, "ucrInputMajorBreaksFrom")
        Me.ucrInputMajorBreaksFrom.Name = "ucrInputMajorBreaksFrom"
        '
        'rdoMajorBreaksAuto
        '
        resources.ApplyResources(Me.rdoMajorBreaksAuto, "rdoMajorBreaksAuto")
        Me.rdoMajorBreaksAuto.Name = "rdoMajorBreaksAuto"
        Me.rdoMajorBreaksAuto.TabStop = True
        Me.rdoMajorBreaksAuto.UseVisualStyleBackColor = True
        '
        'lblMajorBreaksInStepsOf
        '
        resources.ApplyResources(Me.lblMajorBreaksInStepsOf, "lblMajorBreaksInStepsOf")
        Me.lblMajorBreaksInStepsOf.Name = "lblMajorBreaksInStepsOf"
        '
        'lblMajorBreaksFrom
        '
        resources.ApplyResources(Me.lblMajorBreaksFrom, "lblMajorBreaksFrom")
        Me.lblMajorBreaksFrom.Name = "lblMajorBreaksFrom"
        '
        'lblMajorBreaksTo
        '
        resources.ApplyResources(Me.lblMajorBreaksTo, "lblMajorBreaksTo")
        Me.lblMajorBreaksTo.Name = "lblMajorBreaksTo"
        '
        'ucrPnlMajorBreaks
        '
        resources.ApplyResources(Me.ucrPnlMajorBreaks, "ucrPnlMajorBreaks")
        Me.ucrPnlMajorBreaks.Name = "ucrPnlMajorBreaks"
        '
        'ucrInputMajorBreaksCustom
        '
        Me.ucrInputMajorBreaksCustom.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksCustom.IsMultiline = False
        Me.ucrInputMajorBreaksCustom.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMajorBreaksCustom, "ucrInputMajorBreaksCustom")
        Me.ucrInputMajorBreaksCustom.Name = "ucrInputMajorBreaksCustom"
        '
        'grpScales
        '
        Me.grpScales.Controls.Add(Me.ucrInputRelaceMissingvalues)
        Me.grpScales.Controls.Add(Me.ucrInputExpand)
        Me.grpScales.Controls.Add(Me.ucrInputTransformation)
        Me.grpScales.Controls.Add(Me.ucrInputPosition)
        Me.grpScales.Controls.Add(Me.ucrChkExpand)
        Me.grpScales.Controls.Add(Me.ucrChkTransformation)
        Me.grpScales.Controls.Add(Me.ucrChkPosition)
        Me.grpScales.Controls.Add(Me.ucrChkNaValue)
        Me.grpScales.Controls.Add(Me.ucrInputUpperLimit)
        Me.grpScales.Controls.Add(Me.ucrInputLowerLimit)
        Me.grpScales.Controls.Add(Me.lblUpperLimit)
        Me.grpScales.Controls.Add(Me.lblLowerLimit)
        Me.grpScales.Controls.Add(Me.rdoScalesCustom)
        Me.grpScales.Controls.Add(Me.rdoScalesAuto)
        Me.grpScales.Controls.Add(Me.ucrPnlScales)
        resources.ApplyResources(Me.grpScales, "grpScales")
        Me.grpScales.Name = "grpScales"
        Me.grpScales.TabStop = False
        '
        'ucrInputRelaceMissingvalues
        '
        Me.ucrInputRelaceMissingvalues.AddQuotesIfUnrecognised = True
        Me.ucrInputRelaceMissingvalues.IsMultiline = False
        Me.ucrInputRelaceMissingvalues.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputRelaceMissingvalues, "ucrInputRelaceMissingvalues")
        Me.ucrInputRelaceMissingvalues.Name = "ucrInputRelaceMissingvalues"
        '
        'ucrInputExpand
        '
        Me.ucrInputExpand.AddQuotesIfUnrecognised = True
        Me.ucrInputExpand.IsMultiline = False
        Me.ucrInputExpand.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputExpand, "ucrInputExpand")
        Me.ucrInputExpand.Name = "ucrInputExpand"
        '
        'ucrInputTransformation
        '
        Me.ucrInputTransformation.AddQuotesIfUnrecognised = True
        Me.ucrInputTransformation.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTransformation, "ucrInputTransformation")
        Me.ucrInputTransformation.Name = "ucrInputTransformation"
        '
        'ucrInputPosition
        '
        Me.ucrInputPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputPosition.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPosition, "ucrInputPosition")
        Me.ucrInputPosition.Name = "ucrInputPosition"
        '
        'ucrChkExpand
        '
        Me.ucrChkExpand.Checked = False
        resources.ApplyResources(Me.ucrChkExpand, "ucrChkExpand")
        Me.ucrChkExpand.Name = "ucrChkExpand"
        '
        'ucrChkTransformation
        '
        Me.ucrChkTransformation.Checked = False
        resources.ApplyResources(Me.ucrChkTransformation, "ucrChkTransformation")
        Me.ucrChkTransformation.Name = "ucrChkTransformation"
        '
        'ucrChkPosition
        '
        Me.ucrChkPosition.Checked = False
        resources.ApplyResources(Me.ucrChkPosition, "ucrChkPosition")
        Me.ucrChkPosition.Name = "ucrChkPosition"
        '
        'ucrChkNaValue
        '
        Me.ucrChkNaValue.Checked = False
        resources.ApplyResources(Me.ucrChkNaValue, "ucrChkNaValue")
        Me.ucrChkNaValue.Name = "ucrChkNaValue"
        '
        'ucrInputUpperLimit
        '
        Me.ucrInputUpperLimit.AddQuotesIfUnrecognised = True
        Me.ucrInputUpperLimit.IsMultiline = False
        Me.ucrInputUpperLimit.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputUpperLimit, "ucrInputUpperLimit")
        Me.ucrInputUpperLimit.Name = "ucrInputUpperLimit"
        '
        'ucrInputLowerLimit
        '
        Me.ucrInputLowerLimit.AddQuotesIfUnrecognised = True
        Me.ucrInputLowerLimit.IsMultiline = False
        Me.ucrInputLowerLimit.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLowerLimit, "ucrInputLowerLimit")
        Me.ucrInputLowerLimit.Name = "ucrInputLowerLimit"
        '
        'lblUpperLimit
        '
        resources.ApplyResources(Me.lblUpperLimit, "lblUpperLimit")
        Me.lblUpperLimit.Name = "lblUpperLimit"
        '
        'lblLowerLimit
        '
        resources.ApplyResources(Me.lblLowerLimit, "lblLowerLimit")
        Me.lblLowerLimit.Name = "lblLowerLimit"
        '
        'rdoScalesCustom
        '
        resources.ApplyResources(Me.rdoScalesCustom, "rdoScalesCustom")
        Me.rdoScalesCustom.Name = "rdoScalesCustom"
        Me.rdoScalesCustom.TabStop = True
        Me.rdoScalesCustom.UseVisualStyleBackColor = True
        '
        'rdoScalesAuto
        '
        resources.ApplyResources(Me.rdoScalesAuto, "rdoScalesAuto")
        Me.rdoScalesAuto.Name = "rdoScalesAuto"
        Me.rdoScalesAuto.TabStop = True
        Me.rdoScalesAuto.UseVisualStyleBackColor = True
        '
        'ucrPnlScales
        '
        resources.ApplyResources(Me.ucrPnlScales, "ucrPnlScales")
        Me.ucrPnlScales.Name = "ucrPnlScales"
        '
        'ucrInputAxisType
        '
        Me.ucrInputAxisType.AddQuotesIfUnrecognised = True
        Me.ucrInputAxisType.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputAxisType, "ucrInputAxisType")
        Me.ucrInputAxisType.Name = "ucrInputAxisType"
        '
        'rdoMinorBreaksSeq
        '
        resources.ApplyResources(Me.rdoMinorBreaksSeq, "rdoMinorBreaksSeq")
        Me.rdoMinorBreaksSeq.Name = "rdoMinorBreaksSeq"
        Me.rdoMinorBreaksSeq.TabStop = True
        Me.rdoMinorBreaksSeq.UseVisualStyleBackColor = True
        '
        'rdoMinorBreaksCustom
        '
        resources.ApplyResources(Me.rdoMinorBreaksCustom, "rdoMinorBreaksCustom")
        Me.rdoMinorBreaksCustom.Name = "rdoMinorBreaksCustom"
        Me.rdoMinorBreaksCustom.TabStop = True
        Me.rdoMinorBreaksCustom.UseVisualStyleBackColor = True
        '
        'ucrInputMinorBreaksInStepsOf
        '
        Me.ucrInputMinorBreaksInStepsOf.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorBreaksInStepsOf.IsMultiline = False
        Me.ucrInputMinorBreaksInStepsOf.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinorBreaksInStepsOf, "ucrInputMinorBreaksInStepsOf")
        Me.ucrInputMinorBreaksInStepsOf.Name = "ucrInputMinorBreaksInStepsOf"
        '
        'ucrInputMinorBreaksTo
        '
        Me.ucrInputMinorBreaksTo.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorBreaksTo.IsMultiline = False
        Me.ucrInputMinorBreaksTo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinorBreaksTo, "ucrInputMinorBreaksTo")
        Me.ucrInputMinorBreaksTo.Name = "ucrInputMinorBreaksTo"
        '
        'ucrInputMinorBreaksFrom
        '
        Me.ucrInputMinorBreaksFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorBreaksFrom.IsMultiline = False
        Me.ucrInputMinorBreaksFrom.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinorBreaksFrom, "ucrInputMinorBreaksFrom")
        Me.ucrInputMinorBreaksFrom.Name = "ucrInputMinorBreaksFrom"
        '
        'rdoMinorBreaksAuto
        '
        resources.ApplyResources(Me.rdoMinorBreaksAuto, "rdoMinorBreaksAuto")
        Me.rdoMinorBreaksAuto.Name = "rdoMinorBreaksAuto"
        Me.rdoMinorBreaksAuto.TabStop = True
        Me.rdoMinorBreaksAuto.UseVisualStyleBackColor = True
        '
        'ucrInputMinorBreaksCustom
        '
        Me.ucrInputMinorBreaksCustom.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorBreaksCustom.IsMultiline = False
        Me.ucrInputMinorBreaksCustom.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinorBreaksCustom, "ucrInputMinorBreaksCustom")
        Me.ucrInputMinorBreaksCustom.Name = "ucrInputMinorBreaksCustom"
        '
        'lblMinorBreaksInStepsOf
        '
        resources.ApplyResources(Me.lblMinorBreaksInStepsOf, "lblMinorBreaksInStepsOf")
        Me.lblMinorBreaksInStepsOf.Name = "lblMinorBreaksInStepsOf"
        '
        'lblMinorBreaksTo
        '
        resources.ApplyResources(Me.lblMinorBreaksTo, "lblMinorBreaksTo")
        Me.lblMinorBreaksTo.Name = "lblMinorBreaksTo"
        '
        'ucrPnlMinorBreaks
        '
        resources.ApplyResources(Me.ucrPnlMinorBreaks, "ucrPnlMinorBreaks")
        Me.ucrPnlMinorBreaks.Name = "ucrPnlMinorBreaks"
        '
        'grpMinorBreaks
        '
        Me.grpMinorBreaks.Controls.Add(Me.lblMinorBreaksFrom)
        Me.grpMinorBreaks.Controls.Add(Me.rdoMinorBreaksNone)
        Me.grpMinorBreaks.Controls.Add(Me.rdoMinorBreaksAuto)
        Me.grpMinorBreaks.Controls.Add(Me.lblMinorBreaksInStepsOf)
        Me.grpMinorBreaks.Controls.Add(Me.rdoMinorBreaksSeq)
        Me.grpMinorBreaks.Controls.Add(Me.lblMinorBreaksTo)
        Me.grpMinorBreaks.Controls.Add(Me.ucrInputMinorBreaksCustom)
        Me.grpMinorBreaks.Controls.Add(Me.rdoMinorBreaksCustom)
        Me.grpMinorBreaks.Controls.Add(Me.ucrPnlMinorBreaks)
        Me.grpMinorBreaks.Controls.Add(Me.ucrInputMinorBreaksFrom)
        Me.grpMinorBreaks.Controls.Add(Me.ucrInputMinorBreaksInStepsOf)
        Me.grpMinorBreaks.Controls.Add(Me.ucrInputMinorBreaksTo)
        resources.ApplyResources(Me.grpMinorBreaks, "grpMinorBreaks")
        Me.grpMinorBreaks.Name = "grpMinorBreaks"
        Me.grpMinorBreaks.TabStop = False
        '
        'lblMinorBreaksFrom
        '
        resources.ApplyResources(Me.lblMinorBreaksFrom, "lblMinorBreaksFrom")
        Me.lblMinorBreaksFrom.Name = "lblMinorBreaksFrom"
        '
        'rdoMinorBreaksNone
        '
        resources.ApplyResources(Me.rdoMinorBreaksNone, "rdoMinorBreaksNone")
        Me.rdoMinorBreaksNone.Name = "rdoMinorBreaksNone"
        Me.rdoMinorBreaksNone.TabStop = True
        Me.rdoMinorBreaksNone.UseVisualStyleBackColor = True
        '
        'ucrAxes
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpMinorBreaks)
        Me.Controls.Add(Me.ucrInputAxisType)
        Me.Controls.Add(Me.grpScales)
        Me.Controls.Add(Me.grpMajorBreaks)
        Me.Controls.Add(Me.grpAxisTitle)
        Me.Name = "ucrAxes"
        Me.grpAxisTitle.ResumeLayout(False)
        Me.grpAxisTitle.PerformLayout()
        Me.grpMajorBreaks.ResumeLayout(False)
        Me.grpMajorBreaks.PerformLayout()
        Me.grpScales.ResumeLayout(False)
        Me.grpScales.PerformLayout()
        Me.grpMinorBreaks.ResumeLayout(False)
        Me.grpMinorBreaks.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpAxisTitle As GroupBox
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents grpMajorBreaks As GroupBox
    Friend WithEvents lblMajorBreaksFrom As Label
    Friend WithEvents rdoMajorBreaksNone As RadioButton
    Friend WithEvents rdoMajorBreaksAuto As RadioButton
    Friend WithEvents lblMajorBreaksTo As Label
    Friend WithEvents lblMajorBreaksInStepsOf As Label
    Friend WithEvents ucrInputMajorBreaksCustom As ucrInputTextBox

    Friend WithEvents grpScales As GroupBox
    Friend WithEvents rdoScalesCustom As RadioButton
    Friend WithEvents rdoScalesAuto As RadioButton
    Friend WithEvents lblUpperLimit As Label
    Friend WithEvents lblLowerLimit As Label
    Friend WithEvents rdoNoTitle As RadioButton
    Friend WithEvents rdoTitleAuto As RadioButton
    Friend WithEvents ucrPnlAxisTitle As UcrPanel
    Friend WithEvents ucrPnlMajorBreaks As UcrPanel
    Friend WithEvents ucrPnlScales As UcrPanel
    Friend WithEvents ucrInputUpperLimit As ucrInputTextBox
    Friend WithEvents ucrInputLowerLimit As ucrInputTextBox
    Friend WithEvents rdoSpecifyTitle As RadioButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents ucrInputMajorBreaksInStepsOf As ucrInputTextBox
    Friend WithEvents ucrInputMajorBreaksTo As ucrInputTextBox
    Friend WithEvents ucrInputMajorBreaksFrom As ucrInputTextBox
    Friend WithEvents rdoMajorBreaksSeq As RadioButton
    Friend WithEvents rdoMajorBreaksCustom As RadioButton
    Friend WithEvents ucrInputAxisType As ucrInputComboBox
    Friend WithEvents ucrInputMajorBreaksLabels As ucrInputTextBox
    Friend WithEvents rdoMinorBreaksSeq As RadioButton
    Friend WithEvents rdoMinorBreaksCustom As RadioButton
    Friend WithEvents ucrInputMinorBreaksInStepsOf As ucrInputTextBox
    Friend WithEvents ucrInputMinorBreaksTo As ucrInputTextBox
    Friend WithEvents ucrInputMinorBreaksFrom As ucrInputTextBox
    Friend WithEvents rdoMinorBreaksAuto As RadioButton
    Friend WithEvents ucrInputMinorBreaksCustom As ucrInputTextBox
    Friend WithEvents lblMinorBreaksInStepsOf As Label
    Friend WithEvents lblMinorBreaksTo As Label
    Friend WithEvents ucrPnlMinorBreaks As UcrPanel
    Friend WithEvents grpMinorBreaks As GroupBox
    Friend WithEvents lblMinorBreaksFrom As Label
    Friend WithEvents rdoMinorBreaksNone As RadioButton
    Friend WithEvents ucrChkLabels As ucrCheck
    Friend WithEvents ucrInputTransformation As ucrInputComboBox
    Friend WithEvents ucrInputPosition As ucrInputComboBox
    Friend WithEvents ucrChkNaValue As ucrCheck
    Friend WithEvents ucrInputExpand As ucrInputTextBox
    Friend WithEvents ucrInputRelaceMissingvalues As ucrInputTextBox
    Friend WithEvents ucrChkPosition As ucrCheck
    Friend WithEvents ucrChkExpand As ucrCheck
    Friend WithEvents ucrChkTransformation As ucrCheck
End Class
