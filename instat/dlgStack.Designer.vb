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
Partial Class dlgStack
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgStack))
        Me.lblColumnsTostack = New System.Windows.Forms.Label()
        Me.lblValuesTo = New System.Windows.Forms.Label()
        Me.lblNamesTo = New System.Windows.Forms.Label()
        Me.rdoPivotLonger = New System.Windows.Forms.RadioButton()
        Me.rdoUnnest = New System.Windows.Forms.RadioButton()
        Me.lblToken = New System.Windows.Forms.Label()
        Me.lblFormat = New System.Windows.Forms.Label()
        Me.lblPattern = New System.Windows.Forms.Label()
        Me.ttPattern = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.ucrInputOutput = New instat.ucrInputTextBox()
        Me.ucrChkUrl = New instat.ucrCheck()
        Me.ucrReceiverColumnsToBeStack = New instat.ucrReceiverMultiple()
        Me.ucrReceiverTextColumn = New instat.ucrReceiverSingle()
        Me.ucrPnlStack = New instat.UcrPanel()
        Me.ucrSaveNewDataName = New instat.ucrSave()
        Me.ucrChkCarryColumns = New instat.ucrCheck()
        Me.ucrInputValuesTo = New instat.ucrInputTextBox()
        Me.ucrInputNamesTo = New instat.ucrInputTextBox()
        Me.ucrReceiverColumnsToCarry = New instat.ucrReceiverMultiple()
        Me.ucrSelectorStack = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputToken = New instat.ucrInputComboBox()
        Me.ucrInputFormat = New instat.ucrInputComboBox()
        Me.ucrChkToLowerCase = New instat.ucrCheck()
        Me.ucrInputPattern = New instat.ucrInputTextBox()
        Me.ucrChkPunctuation = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblColumnsTostack
        '
        resources.ApplyResources(Me.lblColumnsTostack, "lblColumnsTostack")
        Me.lblColumnsTostack.Name = "lblColumnsTostack"
        Me.lblColumnsTostack.Tag = "Columns_to_Stack:"
        '
        'lblValuesTo
        '
        resources.ApplyResources(Me.lblValuesTo, "lblValuesTo")
        Me.lblValuesTo.Name = "lblValuesTo"
        Me.lblValuesTo.Tag = "Stack_Data_Into"
        '
        'lblNamesTo
        '
        resources.ApplyResources(Me.lblNamesTo, "lblNamesTo")
        Me.lblNamesTo.Name = "lblNamesTo"
        Me.lblNamesTo.Tag = ""
        '
        'rdoPivotLonger
        '
        resources.ApplyResources(Me.rdoPivotLonger, "rdoPivotLonger")
        Me.rdoPivotLonger.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPivotLonger.FlatAppearance.BorderSize = 2
        Me.rdoPivotLonger.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPivotLonger.Name = "rdoPivotLonger"
        Me.rdoPivotLonger.UseVisualStyleBackColor = True
        '
        'rdoUnnest
        '
        resources.ApplyResources(Me.rdoUnnest, "rdoUnnest")
        Me.rdoUnnest.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUnnest.FlatAppearance.BorderSize = 2
        Me.rdoUnnest.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUnnest.Name = "rdoUnnest"
        Me.rdoUnnest.UseVisualStyleBackColor = True
        '
        'lblToken
        '
        resources.ApplyResources(Me.lblToken, "lblToken")
        Me.lblToken.Name = "lblToken"
        '
        'lblFormat
        '
        resources.ApplyResources(Me.lblFormat, "lblFormat")
        Me.lblFormat.Name = "lblFormat"
        '
        'lblPattern
        '
        resources.ApplyResources(Me.lblPattern, "lblPattern")
        Me.lblPattern.Name = "lblPattern"
        '
        'lblOutput
        '
        resources.ApplyResources(Me.lblOutput, "lblOutput")
        Me.lblOutput.Name = "lblOutput"
        '
        'lblVariable
        '
        resources.ApplyResources(Me.lblVariable, "lblVariable")
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Tag = "Columns_to_Stack:"
        '
        'ucrInputOutput
        '
        Me.ucrInputOutput.AddQuotesIfUnrecognised = True
        Me.ucrInputOutput.IsMultiline = False
        Me.ucrInputOutput.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputOutput, "ucrInputOutput")
        Me.ucrInputOutput.Name = "ucrInputOutput"
        '
        'ucrChkUrl
        '
        Me.ucrChkUrl.Checked = False
        resources.ApplyResources(Me.ucrChkUrl, "ucrChkUrl")
        Me.ucrChkUrl.Name = "ucrChkUrl"
        '
        'ucrReceiverColumnsToBeStack
        '
        Me.ucrReceiverColumnsToBeStack.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverColumnsToBeStack, "ucrReceiverColumnsToBeStack")
        Me.ucrReceiverColumnsToBeStack.Name = "ucrReceiverColumnsToBeStack"
        Me.ucrReceiverColumnsToBeStack.Selector = Nothing
        Me.ucrReceiverColumnsToBeStack.strNcFilePath = ""
        Me.ucrReceiverColumnsToBeStack.ucrSelector = Nothing
        '
        'ucrReceiverTextColumn
        '
        Me.ucrReceiverTextColumn.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverTextColumn, "ucrReceiverTextColumn")
        Me.ucrReceiverTextColumn.Name = "ucrReceiverTextColumn"
        Me.ucrReceiverTextColumn.Selector = Nothing
        Me.ucrReceiverTextColumn.strNcFilePath = ""
        Me.ucrReceiverTextColumn.ucrSelector = Nothing
        '
        'ucrPnlStack
        '
        resources.ApplyResources(Me.ucrPnlStack, "ucrPnlStack")
        Me.ucrPnlStack.Name = "ucrPnlStack"
        '
        'ucrSaveNewDataName
        '
        resources.ApplyResources(Me.ucrSaveNewDataName, "ucrSaveNewDataName")
        Me.ucrSaveNewDataName.Name = "ucrSaveNewDataName"
        '
        'ucrChkCarryColumns
        '
        Me.ucrChkCarryColumns.Checked = False
        resources.ApplyResources(Me.ucrChkCarryColumns, "ucrChkCarryColumns")
        Me.ucrChkCarryColumns.Name = "ucrChkCarryColumns"
        '
        'ucrInputValuesTo
        '
        Me.ucrInputValuesTo.AddQuotesIfUnrecognised = True
        Me.ucrInputValuesTo.IsMultiline = False
        Me.ucrInputValuesTo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputValuesTo, "ucrInputValuesTo")
        Me.ucrInputValuesTo.Name = "ucrInputValuesTo"
        '
        'ucrInputNamesTo
        '
        Me.ucrInputNamesTo.AddQuotesIfUnrecognised = True
        Me.ucrInputNamesTo.IsMultiline = False
        Me.ucrInputNamesTo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNamesTo, "ucrInputNamesTo")
        Me.ucrInputNamesTo.Name = "ucrInputNamesTo"
        '
        'ucrReceiverColumnsToCarry
        '
        Me.ucrReceiverColumnsToCarry.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverColumnsToCarry, "ucrReceiverColumnsToCarry")
        Me.ucrReceiverColumnsToCarry.Name = "ucrReceiverColumnsToCarry"
        Me.ucrReceiverColumnsToCarry.Selector = Nothing
        Me.ucrReceiverColumnsToCarry.strNcFilePath = ""
        Me.ucrReceiverColumnsToCarry.ucrSelector = Nothing
        '
        'ucrSelectorStack
        '
        Me.ucrSelectorStack.bDropUnusedFilterLevels = False
        Me.ucrSelectorStack.bShowHiddenColumns = False
        Me.ucrSelectorStack.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorStack, "ucrSelectorStack")
        Me.ucrSelectorStack.Name = "ucrSelectorStack"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrInputToken
        '
        Me.ucrInputToken.AddQuotesIfUnrecognised = True
        Me.ucrInputToken.GetSetSelectedIndex = -1
        Me.ucrInputToken.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputToken, "ucrInputToken")
        Me.ucrInputToken.Name = "ucrInputToken"
        '
        'ucrInputFormat
        '
        Me.ucrInputFormat.AddQuotesIfUnrecognised = True
        Me.ucrInputFormat.GetSetSelectedIndex = -1
        Me.ucrInputFormat.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFormat, "ucrInputFormat")
        Me.ucrInputFormat.Name = "ucrInputFormat"
        '
        'ucrChkToLowerCase
        '
        Me.ucrChkToLowerCase.Checked = False
        resources.ApplyResources(Me.ucrChkToLowerCase, "ucrChkToLowerCase")
        Me.ucrChkToLowerCase.Name = "ucrChkToLowerCase"
        '
        'ucrInputPattern
        '
        Me.ucrInputPattern.AddQuotesIfUnrecognised = True
        Me.ucrInputPattern.IsMultiline = False
        Me.ucrInputPattern.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPattern, "ucrInputPattern")
        Me.ucrInputPattern.Name = "ucrInputPattern"
        '
        'ucrChkPunctuation
        '
        Me.ucrChkPunctuation.Checked = False
        resources.ApplyResources(Me.ucrChkPunctuation, "ucrChkPunctuation")
        Me.ucrChkPunctuation.Name = "ucrChkPunctuation"
        '
        'dlgStack
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblColumnsTostack)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrInputOutput)
        Me.Controls.Add(Me.ucrChkUrl)
        Me.Controls.Add(Me.ucrReceiverColumnsToBeStack)
        Me.Controls.Add(Me.ucrReceiverTextColumn)
        Me.Controls.Add(Me.rdoUnnest)
        Me.Controls.Add(Me.rdoPivotLonger)
        Me.Controls.Add(Me.ucrPnlStack)
        Me.Controls.Add(Me.ucrSaveNewDataName)
        Me.Controls.Add(Me.ucrChkCarryColumns)
        Me.Controls.Add(Me.ucrInputValuesTo)
        Me.Controls.Add(Me.ucrInputNamesTo)
        Me.Controls.Add(Me.ucrReceiverColumnsToCarry)
        Me.Controls.Add(Me.ucrSelectorStack)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrInputToken)
        Me.Controls.Add(Me.lblToken)
        Me.Controls.Add(Me.ucrInputFormat)
        Me.Controls.Add(Me.lblFormat)
        Me.Controls.Add(Me.ucrChkToLowerCase)
        Me.Controls.Add(Me.lblPattern)
        Me.Controls.Add(Me.ucrInputPattern)
        Me.Controls.Add(Me.ucrChkPunctuation)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblNamesTo)
        Me.Controls.Add(Me.lblValuesTo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStack"
        Me.Tag = "Stack_join_columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverColumnsToBeStack As ucrReceiverMultiple
    Friend WithEvents lblColumnsTostack As Label
    Friend WithEvents lblValuesTo As Label
    Friend WithEvents lblNamesTo As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorStack As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverColumnsToCarry As ucrReceiverMultiple
    Friend WithEvents ucrInputNamesTo As ucrInputTextBox
    Friend WithEvents ucrInputValuesTo As ucrInputTextBox
    Friend WithEvents ucrChkCarryColumns As ucrCheck
    Friend WithEvents ucrSaveNewDataName As ucrSave
    Friend WithEvents ucrPnlStack As UcrPanel
    Friend WithEvents rdoUnnest As RadioButton
    Friend WithEvents rdoPivotLonger As RadioButton
    Friend WithEvents ucrReceiverTextColumn As ucrReceiverSingle
    Friend WithEvents ucrInputToken As ucrInputComboBox
    Friend WithEvents lblToken As Label
    Friend WithEvents ucrInputFormat As ucrInputComboBox
    Friend WithEvents lblFormat As Label
    Friend WithEvents ucrChkToLowerCase As ucrCheck
    Friend WithEvents lblPattern As Label
    Friend WithEvents ucrInputPattern As ucrInputTextBox
    Friend WithEvents ttPattern As ToolTip
    Friend WithEvents ucrChkUrl As ucrCheck
    Friend WithEvents ucrChkPunctuation As ucrCheck
    Friend WithEvents ucrInputOutput As ucrInputTextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblVariable As Label
End Class
