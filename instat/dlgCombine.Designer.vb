﻿' R- Instat
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
Partial Class dlgCombine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCombine))
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.ucrChkLexOrder = New instat.ucrCheck()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.ucrNewColName = New instat.ucrSave()
        Me.ucrChkDropUnusedLevels = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrFactorsReceiver = New instat.ucrReceiverMultiple()
        Me.ucrSelectorCombineFactors = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblFactors
        '
        resources.ApplyResources(Me.lblFactors, "lblFactors")
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Tag = "Factors_Selected:"
        '
        'lblSeparator
        '
        resources.ApplyResources(Me.lblSeparator, "lblSeparator")
        Me.lblSeparator.Name = "lblSeparator"
        '
        'ucrChkLexOrder
        '
        Me.ucrChkLexOrder.Checked = False
        resources.ApplyResources(Me.ucrChkLexOrder, "ucrChkLexOrder")
        Me.ucrChkLexOrder.Name = "ucrChkLexOrder"
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.AddQuotesIfUnrecognised = True
        Me.ucrInputSeparator.GetSetSelectedIndex = -1
        Me.ucrInputSeparator.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSeparator, "ucrInputSeparator")
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        '
        'ucrNewColName
        '
        resources.ApplyResources(Me.ucrNewColName, "ucrNewColName")
        Me.ucrNewColName.Name = "ucrNewColName"
        '
        'ucrChkDropUnusedLevels
        '
        Me.ucrChkDropUnusedLevels.Checked = False
        resources.ApplyResources(Me.ucrChkDropUnusedLevels, "ucrChkDropUnusedLevels")
        Me.ucrChkDropUnusedLevels.Name = "ucrChkDropUnusedLevels"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrFactorsReceiver
        '
        Me.ucrFactorsReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrFactorsReceiver, "ucrFactorsReceiver")
        Me.ucrFactorsReceiver.Name = "ucrFactorsReceiver"
        Me.ucrFactorsReceiver.Selector = Nothing
        Me.ucrFactorsReceiver.strNcFilePath = ""
        Me.ucrFactorsReceiver.ucrSelector = Nothing
        '
        'ucrSelectorCombineFactors
        '
        Me.ucrSelectorCombineFactors.bDropUnusedFilterLevels = False
        Me.ucrSelectorCombineFactors.bShowHiddenColumns = False
        Me.ucrSelectorCombineFactors.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorCombineFactors, "ucrSelectorCombineFactors")
        Me.ucrSelectorCombineFactors.Name = "ucrSelectorCombineFactors"
        '
        'dlgCombine
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.ucrChkLexOrder)
        Me.Controls.Add(Me.ucrInputSeparator)
        Me.Controls.Add(Me.ucrNewColName)
        Me.Controls.Add(Me.ucrChkDropUnusedLevels)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrFactorsReceiver)
        Me.Controls.Add(Me.ucrSelectorCombineFactors)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCombine"
        Me.Tag = "Combine_Factors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSelectorCombineFactors As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFactorsReceiver As ucrReceiverMultiple
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrNewColName As ucrSave
    Friend WithEvents ucrChkDropUnusedLevels As ucrCheck
    Friend WithEvents ucrChkLexOrder As ucrCheck
    Friend WithEvents ucrInputSeparator As ucrInputComboBox
    Friend WithEvents lblSeparator As Label
End Class
