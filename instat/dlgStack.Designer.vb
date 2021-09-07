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
        Me.lblStackDataInto = New System.Windows.Forms.Label()
        Me.lblNamesTo = New System.Windows.Forms.Label()
        Me.rdoPivotLonger = New System.Windows.Forms.RadioButton()
        Me.rdoUnnest = New System.Windows.Forms.RadioButton()
        Me.ucrPnlStack = New instat.UcrPanel()
        Me.ucrSaveNewDataName = New instat.ucrSave()
        Me.ucrChkCarryColumns = New instat.ucrCheck()
        Me.ucrStackDataInto = New instat.ucrInputTextBox()
        Me.ucrInputNamesTo = New instat.ucrInputTextBox()
        Me.ucrColumnsToCarryReceiver = New instat.ucrReceiverMultiple()
        Me.ucrSelectorStack = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverColumnsToBeStack = New instat.ucrReceiverMultiple()
        Me.ucrReceiverTextColumn = New instat.ucrReceiverSingle()
        Me.lblToken = New System.Windows.Forms.Label()
        Me.ucrInputToken = New instat.ucrInputComboBox()
        Me.lblFormat = New System.Windows.Forms.Label()
        Me.ucrInputFormat = New instat.ucrInputComboBox()
        Me.ucrChkToLowerCase = New instat.ucrCheck()
        Me.lblPattern = New System.Windows.Forms.Label()
        Me.ucrInputPattern = New instat.ucrInputTextBox()
        Me.ttPattern = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrChkPunctuation = New instat.ucrCheck()
        Me.ucrChkNonAlphanum = New instat.ucrCheck()
        Me.ucrChkNumeric = New instat.ucrCheck()
        Me.ucrChkUrl = New instat.ucrCheck()
        Me.ucrInputOutput = New instat.ucrInputTextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblColumnsTostack
        '
        resources.ApplyResources(Me.lblColumnsTostack, "lblColumnsTostack")
        Me.lblColumnsTostack.Name = "lblColumnsTostack"
        Me.lblColumnsTostack.Tag = "Columns_to_Stack:"
        '
        'lblStackDataInto
        '
        resources.ApplyResources(Me.lblStackDataInto, "lblStackDataInto")
        Me.lblStackDataInto.Name = "lblStackDataInto"
        Me.lblStackDataInto.Tag = "Stack_Data_Into"
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
        'ucrStackDataInto
        '
        Me.ucrStackDataInto.AddQuotesIfUnrecognised = True
        Me.ucrStackDataInto.IsMultiline = False
        Me.ucrStackDataInto.IsReadOnly = False
        resources.ApplyResources(Me.ucrStackDataInto, "ucrStackDataInto")
        Me.ucrStackDataInto.Name = "ucrStackDataInto"
        '
        'ucrInputNamesTo
        '
        Me.ucrInputNamesTo.AddQuotesIfUnrecognised = True
        Me.ucrInputNamesTo.IsMultiline = False
        Me.ucrInputNamesTo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNamesTo, "ucrInputNamesTo")
        Me.ucrInputNamesTo.Name = "ucrInputNamesTo"
        '
        'ucrColumnsToCarryReceiver
        '
        Me.ucrColumnsToCarryReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrColumnsToCarryReceiver, "ucrColumnsToCarryReceiver")
        Me.ucrColumnsToCarryReceiver.Name = "ucrColumnsToCarryReceiver"
        Me.ucrColumnsToCarryReceiver.Selector = Nothing
        Me.ucrColumnsToCarryReceiver.strNcFilePath = ""
        Me.ucrColumnsToCarryReceiver.ucrSelector = Nothing
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
        'lblToken
        '
        resources.ApplyResources(Me.lblToken, "lblToken")
        Me.lblToken.Name = "lblToken"
        '
        'ucrInputToken
        '
        Me.ucrInputToken.AddQuotesIfUnrecognised = True
        Me.ucrInputToken.GetSetSelectedIndex = -1
        Me.ucrInputToken.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputToken, "ucrInputToken")
        Me.ucrInputToken.Name = "ucrInputToken"
        '
        'lblFormat
        '
        resources.ApplyResources(Me.lblFormat, "lblFormat")
        Me.lblFormat.Name = "lblFormat"
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
        'lblPattern
        '
        resources.ApplyResources(Me.lblPattern, "lblPattern")
        Me.lblPattern.Name = "lblPattern"
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
        'ucrChkNonAlphanum
        '
        Me.ucrChkNonAlphanum.Checked = False
        resources.ApplyResources(Me.ucrChkNonAlphanum, "ucrChkNonAlphanum")
        Me.ucrChkNonAlphanum.Name = "ucrChkNonAlphanum"
        '
        'ucrChkNumeric
        '
        Me.ucrChkNumeric.Checked = False
        resources.ApplyResources(Me.ucrChkNumeric, "ucrChkNumeric")
        Me.ucrChkNumeric.Name = "ucrChkNumeric"
        '
        'ucrChkUrl
        '
        Me.ucrChkUrl.Checked = False
        resources.ApplyResources(Me.ucrChkUrl, "ucrChkUrl")
        Me.ucrChkUrl.Name = "ucrChkUrl"
        '
        'ucrInputOutput
        '
        Me.ucrInputOutput.AddQuotesIfUnrecognised = True
        Me.ucrInputOutput.IsMultiline = False
        Me.ucrInputOutput.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputOutput, "ucrInputOutput")
        Me.ucrInputOutput.Name = "ucrInputOutput"
        '
        'lblOutput
        '
        resources.ApplyResources(Me.lblOutput, "lblOutput")
        Me.lblOutput.Name = "lblOutput"
        '
        'dlgStack
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputOutput)
        Me.Controls.Add(Me.ucrChkUrl)
        Me.Controls.Add(Me.ucrReceiverColumnsToBeStack)
        Me.Controls.Add(Me.ucrReceiverTextColumn)
        Me.Controls.Add(Me.rdoUnnest)
        Me.Controls.Add(Me.rdoPivotLonger)
        Me.Controls.Add(Me.ucrPnlStack)
        Me.Controls.Add(Me.ucrSaveNewDataName)
        Me.Controls.Add(Me.ucrChkCarryColumns)
        Me.Controls.Add(Me.ucrStackDataInto)
        Me.Controls.Add(Me.ucrInputNamesTo)
        Me.Controls.Add(Me.ucrColumnsToCarryReceiver)
        Me.Controls.Add(Me.ucrSelectorStack)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblNamesTo)
        Me.Controls.Add(Me.lblStackDataInto)
        Me.Controls.Add(Me.lblColumnsTostack)
        Me.Controls.Add(Me.ucrInputToken)
        Me.Controls.Add(Me.lblToken)
        Me.Controls.Add(Me.ucrInputFormat)
        Me.Controls.Add(Me.lblFormat)
        Me.Controls.Add(Me.ucrChkToLowerCase)
        Me.Controls.Add(Me.lblPattern)
        Me.Controls.Add(Me.ucrInputPattern)
        Me.Controls.Add(Me.ucrChkPunctuation)
        Me.Controls.Add(Me.ucrChkNonAlphanum)
        Me.Controls.Add(Me.ucrChkNumeric)
        Me.Controls.Add(Me.lblOutput)
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
    Friend WithEvents lblStackDataInto As Label
    Friend WithEvents lblNamesTo As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorStack As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrColumnsToCarryReceiver As ucrReceiverMultiple
    Friend WithEvents ucrInputNamesTo As ucrInputTextBox
    Friend WithEvents ucrStackDataInto As ucrInputTextBox
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
    Friend WithEvents ucrChkNonAlphanum As ucrCheck
    Friend WithEvents ucrChkNumeric As ucrCheck
    Friend WithEvents ucrInputOutput As ucrInputTextBox
    Friend WithEvents lblOutput As Label
End Class
