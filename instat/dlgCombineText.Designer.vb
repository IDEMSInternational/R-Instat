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
Partial Class dlgCombineText
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCombineText))
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblColumnsToCobine = New System.Windows.Forms.Label()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.ucrReceiverCombineText = New instat.ucrReceiverMultiple()
        Me.ucrSelectorForCombineText = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblSeparator
        '
        resources.ApplyResources(Me.lblSeparator, "lblSeparator")
        Me.lblSeparator.Name = "lblSeparator"
        '
        'lblColumnsToCobine
        '
        resources.ApplyResources(Me.lblColumnsToCobine, "lblColumnsToCobine")
        Me.lblColumnsToCobine.Name = "lblColumnsToCobine"
        Me.lblColumnsToCobine.Tag = "Columns_to_Combine:"
        '
        'ucrSaveColumn
        '
        resources.ApplyResources(Me.ucrSaveColumn, "ucrSaveColumn")
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.AddQuotesIfUnrecognised = True
        Me.ucrInputSeparator.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSeparator, "ucrInputSeparator")
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        '
        'ucrReceiverCombineText
        '
        Me.ucrReceiverCombineText.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverCombineText, "ucrReceiverCombineText")
        Me.ucrReceiverCombineText.Name = "ucrReceiverCombineText"
        Me.ucrReceiverCombineText.Selector = Nothing
        Me.ucrReceiverCombineText.strNcFilePath = ""
        Me.ucrReceiverCombineText.ucrSelector = Nothing
        '
        'ucrSelectorForCombineText
        '
        Me.ucrSelectorForCombineText.bShowHiddenColumns = False
        Me.ucrSelectorForCombineText.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForCombineText, "ucrSelectorForCombineText")
        Me.ucrSelectorForCombineText.Name = "ucrSelectorForCombineText"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgCombineText
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveColumn)
        Me.Controls.Add(Me.ucrInputSeparator)
        Me.Controls.Add(Me.lblColumnsToCobine)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.ucrReceiverCombineText)
        Me.Controls.Add(Me.ucrSelectorForCombineText)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCombineText"
        Me.Tag = "Combine_Text_Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForCombineText As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverCombineText As ucrReceiverMultiple
    Friend WithEvents lblSeparator As Label
    Friend WithEvents lblColumnsToCobine As Label
    Friend WithEvents ucrInputSeparator As ucrInputComboBox
    Friend WithEvents ucrSaveColumn As ucrSave
End Class
