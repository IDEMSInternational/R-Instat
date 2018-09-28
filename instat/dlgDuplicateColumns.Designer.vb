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
Partial Class dlgDuplicateColumns
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDuplicateColumns))
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrInputColumnName = New instat.ucrInputComboBox()
        Me.ucrReceiverDuplicateColumns = New instat.ucrReceiverSingle()
        Me.ucrSelectorForDuplicateColumn = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpDuplicatedColumn = New System.Windows.Forms.GroupBox()
        Me.rdoBefore = New System.Windows.Forms.RadioButton()
        Me.rdoEnd = New System.Windows.Forms.RadioButton()
        Me.rdoAfter = New System.Windows.Forms.RadioButton()
        Me.rdoBeginning = New System.Windows.Forms.RadioButton()
        Me.ucrPnlColPosition = New instat.UcrPanel()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpDuplicatedColumn.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumns
        '
        resources.ApplyResources(Me.lblColumns, "lblColumns")
        Me.lblColumns.Name = "lblColumns"
        '
        'lblNewColumnName
        '
        resources.ApplyResources(Me.lblNewColumnName, "lblNewColumnName")
        Me.lblNewColumnName.Name = "lblNewColumnName"
        '
        'ucrInputColumnName
        '
        Me.ucrInputColumnName.AddQuotesIfUnrecognised = True
        Me.ucrInputColumnName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputColumnName, "ucrInputColumnName")
        Me.ucrInputColumnName.Name = "ucrInputColumnName"
        '
        'ucrReceiverDuplicateColumns
        '
        Me.ucrReceiverDuplicateColumns.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDuplicateColumns, "ucrReceiverDuplicateColumns")
        Me.ucrReceiverDuplicateColumns.Name = "ucrReceiverDuplicateColumns"
        Me.ucrReceiverDuplicateColumns.Selector = Nothing
        Me.ucrReceiverDuplicateColumns.strNcFilePath = ""
        Me.ucrReceiverDuplicateColumns.ucrSelector = Nothing
        '
        'ucrSelectorForDuplicateColumn
        '
        Me.ucrSelectorForDuplicateColumn.bShowHiddenColumns = False
        Me.ucrSelectorForDuplicateColumn.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForDuplicateColumn, "ucrSelectorForDuplicateColumn")
        Me.ucrSelectorForDuplicateColumn.Name = "ucrSelectorForDuplicateColumn"
        '
        'grpDuplicatedColumn
        '
        Me.grpDuplicatedColumn.Controls.Add(Me.rdoBefore)
        Me.grpDuplicatedColumn.Controls.Add(Me.rdoEnd)
        Me.grpDuplicatedColumn.Controls.Add(Me.rdoAfter)
        Me.grpDuplicatedColumn.Controls.Add(Me.rdoBeginning)
        Me.grpDuplicatedColumn.Controls.Add(Me.ucrPnlColPosition)
        resources.ApplyResources(Me.grpDuplicatedColumn, "grpDuplicatedColumn")
        Me.grpDuplicatedColumn.Name = "grpDuplicatedColumn"
        Me.grpDuplicatedColumn.TabStop = False
        '
        'rdoBefore
        '
        resources.ApplyResources(Me.rdoBefore, "rdoBefore")
        Me.rdoBefore.Name = "rdoBefore"
        Me.rdoBefore.TabStop = True
        Me.rdoBefore.UseVisualStyleBackColor = True
        '
        'rdoEnd
        '
        resources.ApplyResources(Me.rdoEnd, "rdoEnd")
        Me.rdoEnd.Name = "rdoEnd"
        Me.rdoEnd.TabStop = True
        Me.rdoEnd.UseVisualStyleBackColor = True
        '
        'rdoAfter
        '
        resources.ApplyResources(Me.rdoAfter, "rdoAfter")
        Me.rdoAfter.Name = "rdoAfter"
        Me.rdoAfter.TabStop = True
        Me.rdoAfter.UseVisualStyleBackColor = True
        '
        'rdoBeginning
        '
        resources.ApplyResources(Me.rdoBeginning, "rdoBeginning")
        Me.rdoBeginning.Name = "rdoBeginning"
        Me.rdoBeginning.TabStop = True
        Me.rdoBeginning.UseVisualStyleBackColor = True
        '
        'ucrPnlColPosition
        '
        resources.ApplyResources(Me.ucrPnlColPosition, "ucrPnlColPosition")
        Me.ucrPnlColPosition.Name = "ucrPnlColPosition"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgDuplicateColumns
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrInputColumnName)
        Me.Controls.Add(Me.ucrReceiverDuplicateColumns)
        Me.Controls.Add(Me.ucrSelectorForDuplicateColumn)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpDuplicatedColumn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDuplicateColumns"
        Me.Tag = ""
        Me.grpDuplicatedColumn.ResumeLayout(False)
        Me.grpDuplicatedColumn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrSelectorForDuplicateColumn As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverDuplicateColumns As ucrReceiverSingle
    Friend WithEvents ucrInputColumnName As ucrInputComboBox
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents grpDuplicatedColumn As GroupBox
    Friend WithEvents rdoBefore As RadioButton
    Friend WithEvents rdoEnd As RadioButton
    Friend WithEvents rdoAfter As RadioButton
    Friend WithEvents rdoBeginning As RadioButton
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPnlColPosition As UcrPanel
End Class
