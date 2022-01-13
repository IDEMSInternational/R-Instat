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
Partial Class dlgFourVariableModelling
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
        Me.cmdModelOptions = New System.Windows.Forms.Button()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.lblSecondExplanatoryVariable = New System.Windows.Forms.Label()
        Me.lblFirstExplanatoryVariable = New System.Windows.Forms.Label()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.lblThirdExplanatoryVariable = New System.Windows.Forms.Label()
        Me.lblFirstOperator = New System.Windows.Forms.Label()
        Me.lblSecondOperator = New System.Windows.Forms.Label()
        Me.ucrInputModelOperators2 = New instat.ucrInputComboBox()
        Me.ucrInputModelOperators1 = New instat.ucrInputComboBox()
        Me.ucrReceiverThirdExplanatory = New instat.ucrReceiverSingle()
        Me.ucrModelPreview = New instat.ucrInputTextBox()
        Me.ucrDistributionChoice = New instat.ucrDistributions()
        Me.ucrReceiverSecondExplanatory = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstExplanatory = New instat.ucrReceiverSingle()
        Me.ucrReceiverResponse = New instat.ucrReceiverSingle()
        Me.ucrSelectorFourVariableModelling = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseFourVariableModelling = New instat.ucrButtons()
        Me.ucrSaveModel = New instat.ucrSave()
        Me.ucrChkConvertToNumeric = New instat.ucrCheck()
        Me.cmdFirstExplanatoryFunction = New System.Windows.Forms.Button()
        Me.cmdSecondExplanatoryFunction = New System.Windows.Forms.Button()
        Me.cmdThirdExplanatoryFunction = New System.Windows.Forms.Button()
        Me.UcrDialogDisabled1 = New instat.ucrDialogDisabled()
        Me.SuspendLayout()
        '
        'cmdModelOptions
        '
        Me.cmdModelOptions.Location = New System.Drawing.Point(237, 298)
        Me.cmdModelOptions.Name = "cmdModelOptions"
        Me.cmdModelOptions.Size = New System.Drawing.Size(106, 23)
        Me.cmdModelOptions.TabIndex = 18
        Me.cmdModelOptions.Tag = "Model_Options"
        Me.cmdModelOptions.Text = "Model Options..."
        Me.cmdModelOptions.UseVisualStyleBackColor = True
        '
        'lblModelPreview
        '
        Me.lblModelPreview.AutoSize = True
        Me.lblModelPreview.Location = New System.Drawing.Point(11, 353)
        Me.lblModelPreview.Name = "lblModelPreview"
        Me.lblModelPreview.Size = New System.Drawing.Size(80, 13)
        Me.lblModelPreview.TabIndex = 20
        Me.lblModelPreview.Tag = "Model_Preview:"
        Me.lblModelPreview.Text = "Model Preview:"
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(349, 298)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(106, 23)
        Me.cmdDisplayOptions.TabIndex = 19
        Me.cmdDisplayOptions.Tag = "Display_Options"
        Me.cmdDisplayOptions.Text = "Display Options..."
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'lblSecondExplanatoryVariable
        '
        Me.lblSecondExplanatoryVariable.AutoSize = True
        Me.lblSecondExplanatoryVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondExplanatoryVariable.Location = New System.Drawing.Point(266, 158)
        Me.lblSecondExplanatoryVariable.Name = "lblSecondExplanatoryVariable"
        Me.lblSecondExplanatoryVariable.Size = New System.Drawing.Size(146, 13)
        Me.lblSecondExplanatoryVariable.TabIndex = 9
        Me.lblSecondExplanatoryVariable.Tag = "Second_Explanatory_Variable:"
        Me.lblSecondExplanatoryVariable.Text = "Second Explanatory Variable:"
        '
        'lblFirstExplanatoryVariable
        '
        Me.lblFirstExplanatoryVariable.AutoSize = True
        Me.lblFirstExplanatoryVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstExplanatoryVariable.Location = New System.Drawing.Point(266, 83)
        Me.lblFirstExplanatoryVariable.Name = "lblFirstExplanatoryVariable"
        Me.lblFirstExplanatoryVariable.Size = New System.Drawing.Size(128, 13)
        Me.lblFirstExplanatoryVariable.TabIndex = 4
        Me.lblFirstExplanatoryVariable.Tag = "First_Explanatory_Variable:"
        Me.lblFirstExplanatoryVariable.Text = "First Explanatory Variable:"
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResponse.Location = New System.Drawing.Point(266, 29)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(99, 13)
        Me.lblResponse.TabIndex = 1
        Me.lblResponse.Tag = "Response_Variable:"
        Me.lblResponse.Text = "Response Variable:"
        '
        'lblThirdExplanatoryVariable
        '
        Me.lblThirdExplanatoryVariable.AutoSize = True
        Me.lblThirdExplanatoryVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblThirdExplanatoryVariable.Location = New System.Drawing.Point(266, 233)
        Me.lblThirdExplanatoryVariable.Name = "lblThirdExplanatoryVariable"
        Me.lblThirdExplanatoryVariable.Size = New System.Drawing.Size(133, 13)
        Me.lblThirdExplanatoryVariable.TabIndex = 14
        Me.lblThirdExplanatoryVariable.Tag = "Third_Explanatory_Variable:"
        Me.lblThirdExplanatoryVariable.Text = "Third Explanatory Variable:"
        '
        'lblFirstOperator
        '
        Me.lblFirstOperator.AutoSize = True
        Me.lblFirstOperator.Location = New System.Drawing.Point(292, 127)
        Me.lblFirstOperator.Name = "lblFirstOperator"
        Me.lblFirstOperator.Size = New System.Drawing.Size(51, 13)
        Me.lblFirstOperator.TabIndex = 7
        Me.lblFirstOperator.Tag = "Operator:"
        Me.lblFirstOperator.Text = "Operator:"
        '
        'lblSecondOperator
        '
        Me.lblSecondOperator.AutoSize = True
        Me.lblSecondOperator.Location = New System.Drawing.Point(292, 205)
        Me.lblSecondOperator.Name = "lblSecondOperator"
        Me.lblSecondOperator.Size = New System.Drawing.Size(51, 13)
        Me.lblSecondOperator.TabIndex = 12
        Me.lblSecondOperator.Tag = "Operator:"
        Me.lblSecondOperator.Text = "Operator:"
        '
        'ucrInputModelOperators2
        '
        Me.ucrInputModelOperators2.AddQuotesIfUnrecognised = True
        Me.ucrInputModelOperators2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputModelOperators2.GetSetSelectedIndex = -1
        Me.ucrInputModelOperators2.IsReadOnly = False
        Me.ucrInputModelOperators2.Location = New System.Drawing.Point(355, 201)
        Me.ucrInputModelOperators2.Name = "ucrInputModelOperators2"
        Me.ucrInputModelOperators2.Size = New System.Drawing.Size(39, 21)
        Me.ucrInputModelOperators2.TabIndex = 13
        '
        'ucrInputModelOperators1
        '
        Me.ucrInputModelOperators1.AddQuotesIfUnrecognised = True
        Me.ucrInputModelOperators1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputModelOperators1.GetSetSelectedIndex = -1
        Me.ucrInputModelOperators1.IsReadOnly = False
        Me.ucrInputModelOperators1.Location = New System.Drawing.Point(355, 124)
        Me.ucrInputModelOperators1.Name = "ucrInputModelOperators1"
        Me.ucrInputModelOperators1.Size = New System.Drawing.Size(39, 21)
        Me.ucrInputModelOperators1.TabIndex = 8
        '
        'ucrReceiverThirdExplanatory
        '
        Me.ucrReceiverThirdExplanatory.AutoSize = True
        Me.ucrReceiverThirdExplanatory.frmParent = Me
        Me.ucrReceiverThirdExplanatory.Location = New System.Drawing.Point(266, 250)
        Me.ucrReceiverThirdExplanatory.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverThirdExplanatory.Name = "ucrReceiverThirdExplanatory"
        Me.ucrReceiverThirdExplanatory.Selector = Nothing
        Me.ucrReceiverThirdExplanatory.Size = New System.Drawing.Size(128, 26)
        Me.ucrReceiverThirdExplanatory.strNcFilePath = ""
        Me.ucrReceiverThirdExplanatory.TabIndex = 15
        Me.ucrReceiverThirdExplanatory.ucrSelector = Nothing
        '
        'ucrModelPreview
        '
        Me.ucrModelPreview.AddQuotesIfUnrecognised = True
        Me.ucrModelPreview.AutoSize = True
        Me.ucrModelPreview.IsMultiline = False
        Me.ucrModelPreview.IsReadOnly = False
        Me.ucrModelPreview.Location = New System.Drawing.Point(96, 349)
        Me.ucrModelPreview.Name = "ucrModelPreview"
        Me.ucrModelPreview.Size = New System.Drawing.Size(361, 21)
        Me.ucrModelPreview.TabIndex = 21
        '
        'ucrDistributionChoice
        '
        Me.ucrDistributionChoice.AutoSize = True
        Me.ucrDistributionChoice.Location = New System.Drawing.Point(14, 298)
        Me.ucrDistributionChoice.Name = "ucrDistributionChoice"
        Me.ucrDistributionChoice.Size = New System.Drawing.Size(225, 35)
        Me.ucrDistributionChoice.TabIndex = 17
        '
        'ucrReceiverSecondExplanatory
        '
        Me.ucrReceiverSecondExplanatory.AutoSize = True
        Me.ucrReceiverSecondExplanatory.frmParent = Me
        Me.ucrReceiverSecondExplanatory.Location = New System.Drawing.Point(266, 175)
        Me.ucrReceiverSecondExplanatory.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondExplanatory.Name = "ucrReceiverSecondExplanatory"
        Me.ucrReceiverSecondExplanatory.Selector = Nothing
        Me.ucrReceiverSecondExplanatory.Size = New System.Drawing.Size(128, 27)
        Me.ucrReceiverSecondExplanatory.strNcFilePath = ""
        Me.ucrReceiverSecondExplanatory.TabIndex = 10
        Me.ucrReceiverSecondExplanatory.ucrSelector = Nothing
        '
        'ucrReceiverFirstExplanatory
        '
        Me.ucrReceiverFirstExplanatory.AutoSize = True
        Me.ucrReceiverFirstExplanatory.frmParent = Me
        Me.ucrReceiverFirstExplanatory.Location = New System.Drawing.Point(266, 99)
        Me.ucrReceiverFirstExplanatory.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstExplanatory.Name = "ucrReceiverFirstExplanatory"
        Me.ucrReceiverFirstExplanatory.Selector = Nothing
        Me.ucrReceiverFirstExplanatory.Size = New System.Drawing.Size(128, 23)
        Me.ucrReceiverFirstExplanatory.strNcFilePath = ""
        Me.ucrReceiverFirstExplanatory.TabIndex = 5
        Me.ucrReceiverFirstExplanatory.ucrSelector = Nothing
        '
        'ucrReceiverResponse
        '
        Me.ucrReceiverResponse.AutoSize = True
        Me.ucrReceiverResponse.frmParent = Me
        Me.ucrReceiverResponse.Location = New System.Drawing.Point(266, 44)
        Me.ucrReceiverResponse.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverResponse.Name = "ucrReceiverResponse"
        Me.ucrReceiverResponse.Selector = Nothing
        Me.ucrReceiverResponse.Size = New System.Drawing.Size(128, 22)
        Me.ucrReceiverResponse.strNcFilePath = ""
        Me.ucrReceiverResponse.TabIndex = 2
        Me.ucrReceiverResponse.ucrSelector = Nothing
        '
        'ucrSelectorFourVariableModelling
        '
        Me.ucrSelectorFourVariableModelling.AutoSize = True
        Me.ucrSelectorFourVariableModelling.bDropUnusedFilterLevels = False
        Me.ucrSelectorFourVariableModelling.bShowHiddenColumns = False
        Me.ucrSelectorFourVariableModelling.bUseCurrentFilter = True
        Me.ucrSelectorFourVariableModelling.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorFourVariableModelling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFourVariableModelling.Name = "ucrSelectorFourVariableModelling"
        Me.ucrSelectorFourVariableModelling.Size = New System.Drawing.Size(225, 208)
        Me.ucrSelectorFourVariableModelling.TabIndex = 0
        '
        'ucrBaseFourVariableModelling
        '
        Me.ucrBaseFourVariableModelling.AutoSize = True
        Me.ucrBaseFourVariableModelling.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBaseFourVariableModelling.Location = New System.Drawing.Point(10, 406)
        Me.ucrBaseFourVariableModelling.Name = "ucrBaseFourVariableModelling"
        Me.ucrBaseFourVariableModelling.Size = New System.Drawing.Size(405, 52)
        Me.ucrBaseFourVariableModelling.TabIndex = 23
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveModel.Location = New System.Drawing.Point(10, 376)
        Me.ucrSaveModel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveModel.TabIndex = 22
        '
        'ucrChkConvertToNumeric
        '
        Me.ucrChkConvertToNumeric.AutoSize = True
        Me.ucrChkConvertToNumeric.Checked = False
        Me.ucrChkConvertToNumeric.Location = New System.Drawing.Point(397, 44)
        Me.ucrChkConvertToNumeric.Name = "ucrChkConvertToNumeric"
        Me.ucrChkConvertToNumeric.Size = New System.Drawing.Size(136, 23)
        Me.ucrChkConvertToNumeric.TabIndex = 3
        '
        'cmdFirstExplanatoryFunction
        '
        Me.cmdFirstExplanatoryFunction.Location = New System.Drawing.Point(400, 98)
        Me.cmdFirstExplanatoryFunction.Name = "cmdFirstExplanatoryFunction"
        Me.cmdFirstExplanatoryFunction.Size = New System.Drawing.Size(67, 20)
        Me.cmdFirstExplanatoryFunction.TabIndex = 6
        Me.cmdFirstExplanatoryFunction.Text = "Function..."
        Me.cmdFirstExplanatoryFunction.UseVisualStyleBackColor = True
        '
        'cmdSecondExplanatoryFunction
        '
        Me.cmdSecondExplanatoryFunction.Location = New System.Drawing.Point(400, 174)
        Me.cmdSecondExplanatoryFunction.Name = "cmdSecondExplanatoryFunction"
        Me.cmdSecondExplanatoryFunction.Size = New System.Drawing.Size(67, 20)
        Me.cmdSecondExplanatoryFunction.TabIndex = 11
        Me.cmdSecondExplanatoryFunction.Text = "Function..."
        Me.cmdSecondExplanatoryFunction.UseVisualStyleBackColor = True
        '
        'cmdThirdExplanatoryFunction
        '
        Me.cmdThirdExplanatoryFunction.Location = New System.Drawing.Point(400, 250)
        Me.cmdThirdExplanatoryFunction.Name = "cmdThirdExplanatoryFunction"
        Me.cmdThirdExplanatoryFunction.Size = New System.Drawing.Size(67, 20)
        Me.cmdThirdExplanatoryFunction.TabIndex = 16
        Me.cmdThirdExplanatoryFunction.Text = "Function..."
        Me.cmdThirdExplanatoryFunction.UseVisualStyleBackColor = True
        '
        'UcrDialogDisabled1
        '
        Me.UcrDialogDisabled1.AutoSize = True
        Me.UcrDialogDisabled1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcrDialogDisabled1.Location = New System.Drawing.Point(125, 143)
        Me.UcrDialogDisabled1.Name = "UcrDialogDisabled1"
        Me.UcrDialogDisabled1.Size = New System.Drawing.Size(218, 117)
        Me.UcrDialogDisabled1.TabIndex = 24
        '
        'dlgFourVariableModelling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(546, 460)
        Me.Controls.Add(Me.UcrDialogDisabled1)
        Me.Controls.Add(Me.cmdThirdExplanatoryFunction)
        Me.Controls.Add(Me.cmdSecondExplanatoryFunction)
        Me.Controls.Add(Me.cmdFirstExplanatoryFunction)
        Me.Controls.Add(Me.ucrChkConvertToNumeric)
        Me.Controls.Add(Me.ucrSaveModel)
        Me.Controls.Add(Me.ucrInputModelOperators2)
        Me.Controls.Add(Me.ucrInputModelOperators1)
        Me.Controls.Add(Me.lblSecondOperator)
        Me.Controls.Add(Me.lblFirstOperator)
        Me.Controls.Add(Me.lblThirdExplanatoryVariable)
        Me.Controls.Add(Me.ucrReceiverThirdExplanatory)
        Me.Controls.Add(Me.cmdModelOptions)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.ucrModelPreview)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrDistributionChoice)
        Me.Controls.Add(Me.lblSecondExplanatoryVariable)
        Me.Controls.Add(Me.ucrReceiverSecondExplanatory)
        Me.Controls.Add(Me.lblFirstExplanatoryVariable)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.ucrReceiverFirstExplanatory)
        Me.Controls.Add(Me.ucrReceiverResponse)
        Me.Controls.Add(Me.ucrSelectorFourVariableModelling)
        Me.Controls.Add(Me.ucrBaseFourVariableModelling)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFourVariableModelling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Four_Variable_Modelling"
        Me.Text = "Four Variable Modelling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseFourVariableModelling As ucrButtons
    Friend WithEvents cmdModelOptions As Button
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents ucrModelPreview As ucrInputTextBox
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents ucrDistributionChoice As ucrDistributions
    Friend WithEvents lblSecondExplanatoryVariable As Label
    Friend WithEvents ucrReceiverSecondExplanatory As ucrReceiverSingle
    Friend WithEvents lblFirstExplanatoryVariable As Label
    Friend WithEvents lblResponse As Label
    Friend WithEvents ucrReceiverFirstExplanatory As ucrReceiverSingle
    Friend WithEvents ucrReceiverResponse As ucrReceiverSingle
    Friend WithEvents ucrSelectorFourVariableModelling As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblThirdExplanatoryVariable As Label
    Friend WithEvents ucrReceiverThirdExplanatory As ucrReceiverSingle
    Friend WithEvents lblFirstOperator As Label
    Friend WithEvents lblSecondOperator As Label
    Friend WithEvents ucrInputModelOperators1 As ucrInputComboBox
    Friend WithEvents ucrInputModelOperators2 As ucrInputComboBox
    Friend WithEvents ucrSaveModel As ucrSave
    Friend WithEvents ucrChkConvertToNumeric As ucrCheck
    Friend WithEvents cmdFirstExplanatoryFunction As Button
    Friend WithEvents cmdThirdExplanatoryFunction As Button
    Friend WithEvents cmdSecondExplanatoryFunction As Button
    Friend WithEvents UcrDialogDisabled1 As ucrDialogDisabled
End Class
