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
Partial Class dlgSort
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgSort))
        Me.grpOrder = New System.Windows.Forms.GroupBox()
        Me.rdoDescending = New System.Windows.Forms.RadioButton()
        Me.rdoAscending = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOrder = New instat.UcrPanel()
        Me.lblColumnsToSort = New System.Windows.Forms.Label()
        Me.grpMissingValues = New System.Windows.Forms.GroupBox()
        Me.rdoLast = New System.Windows.Forms.RadioButton()
        Me.rdoFirst = New System.Windows.Forms.RadioButton()
        Me.ucrPnlMissingValues = New instat.UcrPanel()
        Me.ucrSelectForSort = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverSort = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpOrder.SuspendLayout()
        Me.grpMissingValues.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOrder
        '
        Me.grpOrder.Controls.Add(Me.rdoDescending)
        Me.grpOrder.Controls.Add(Me.rdoAscending)
        Me.grpOrder.Controls.Add(Me.ucrPnlOrder)
        resources.ApplyResources(Me.grpOrder, "grpOrder")
        Me.grpOrder.Name = "grpOrder"
        Me.grpOrder.TabStop = False
        Me.grpOrder.Tag = "Order"
        '
        'rdoDescending
        '
        resources.ApplyResources(Me.rdoDescending, "rdoDescending")
        Me.rdoDescending.Name = "rdoDescending"
        Me.rdoDescending.TabStop = True
        Me.rdoDescending.Tag = "Descending"
        Me.rdoDescending.UseVisualStyleBackColor = True
        '
        'rdoAscending
        '
        resources.ApplyResources(Me.rdoAscending, "rdoAscending")
        Me.rdoAscending.Name = "rdoAscending"
        Me.rdoAscending.TabStop = True
        Me.rdoAscending.Tag = "Ascending"
        Me.rdoAscending.UseVisualStyleBackColor = True
        '
        'ucrPnlOrder
        '
        resources.ApplyResources(Me.ucrPnlOrder, "ucrPnlOrder")
        Me.ucrPnlOrder.Name = "ucrPnlOrder"
        '
        'lblColumnsToSort
        '
        resources.ApplyResources(Me.lblColumnsToSort, "lblColumnsToSort")
        Me.lblColumnsToSort.Name = "lblColumnsToSort"
        Me.lblColumnsToSort.Tag = ""
        '
        'grpMissingValues
        '
        Me.grpMissingValues.Controls.Add(Me.rdoLast)
        Me.grpMissingValues.Controls.Add(Me.rdoFirst)
        Me.grpMissingValues.Controls.Add(Me.ucrPnlMissingValues)
        resources.ApplyResources(Me.grpMissingValues, "grpMissingValues")
        Me.grpMissingValues.Name = "grpMissingValues"
        Me.grpMissingValues.TabStop = False
        Me.grpMissingValues.Tag = "Missing_Values"
        '
        'rdoLast
        '
        resources.ApplyResources(Me.rdoLast, "rdoLast")
        Me.rdoLast.Name = "rdoLast"
        Me.rdoLast.TabStop = True
        Me.rdoLast.Tag = "Last"
        Me.rdoLast.UseVisualStyleBackColor = True
        '
        'rdoFirst
        '
        resources.ApplyResources(Me.rdoFirst, "rdoFirst")
        Me.rdoFirst.Name = "rdoFirst"
        Me.rdoFirst.TabStop = True
        Me.rdoFirst.Tag = "First"
        Me.rdoFirst.UseVisualStyleBackColor = True
        '
        'ucrPnlMissingValues
        '
        resources.ApplyResources(Me.ucrPnlMissingValues, "ucrPnlMissingValues")
        Me.ucrPnlMissingValues.Name = "ucrPnlMissingValues"
        '
        'ucrSelectForSort
        '
        Me.ucrSelectForSort.bShowHiddenColumns = False
        Me.ucrSelectForSort.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectForSort, "ucrSelectForSort")
        Me.ucrSelectForSort.Name = "ucrSelectForSort"
        '
        'ucrReceiverSort
        '
        Me.ucrReceiverSort.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSort, "ucrReceiverSort")
        Me.ucrReceiverSort.Name = "ucrReceiverSort"
        Me.ucrReceiverSort.Selector = Nothing
        Me.ucrReceiverSort.strNcFilePath = ""
        Me.ucrReceiverSort.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgSort
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSelectForSort)
        Me.Controls.Add(Me.grpMissingValues)
        Me.Controls.Add(Me.lblColumnsToSort)
        Me.Controls.Add(Me.ucrReceiverSort)
        Me.Controls.Add(Me.grpOrder)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSort"
        Me.ShowIcon = False
        Me.Tag = "Sort"
        Me.grpOrder.ResumeLayout(False)
        Me.grpOrder.PerformLayout()
        Me.grpMissingValues.ResumeLayout(False)
        Me.grpMissingValues.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpOrder As GroupBox
    Friend WithEvents rdoDescending As RadioButton
    Friend WithEvents rdoAscending As RadioButton
    Friend WithEvents ucrReceiverSort As ucrReceiverMultiple
    Friend WithEvents lblColumnsToSort As Label
    Friend WithEvents grpMissingValues As GroupBox
    Friend WithEvents ucrSelectForSort As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrPnlOrder As UcrPanel
    Friend WithEvents rdoLast As RadioButton
    Friend WithEvents rdoFirst As RadioButton
    Friend WithEvents ucrPnlMissingValues As UcrPanel
End Class
