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
Partial Class dlgRemoveUnusedLevels
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRemoveUnusedLevels))
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrRemoveUnusedFactorLevels = New instat.ucrFactor()
        Me.ucrReceiverFactorColumn = New instat.ucrReceiverSingle()
        Me.ucrSelectorFactorColumn = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputUnusedLevels = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'lblFactor
        '
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Tag = "Factor_Selected:"
        '
        'ucrRemoveUnusedFactorLevels
        '
        resources.ApplyResources(Me.ucrRemoveUnusedFactorLevels, "ucrRemoveUnusedFactorLevels")
        Me.ucrRemoveUnusedFactorLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrRemoveUnusedFactorLevels.clsReceiver = Nothing
        Me.ucrRemoveUnusedFactorLevels.Name = "ucrRemoveUnusedFactorLevels"
        Me.ucrRemoveUnusedFactorLevels.shtCurrSheet = Nothing
        Me.ucrRemoveUnusedFactorLevels.ucrChkLevels = Nothing
        '
        'ucrReceiverFactorColumn
        '
        Me.ucrReceiverFactorColumn.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFactorColumn, "ucrReceiverFactorColumn")
        Me.ucrReceiverFactorColumn.Name = "ucrReceiverFactorColumn"
        Me.ucrReceiverFactorColumn.Selector = Nothing
        Me.ucrReceiverFactorColumn.strNcFilePath = ""
        Me.ucrReceiverFactorColumn.ucrSelector = Nothing
        '
        'ucrSelectorFactorColumn
        '
        Me.ucrSelectorFactorColumn.bShowHiddenColumns = False
        Me.ucrSelectorFactorColumn.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorFactorColumn, "ucrSelectorFactorColumn")
        Me.ucrSelectorFactorColumn.Name = "ucrSelectorFactorColumn"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrInputUnusedLevels
        '
        Me.ucrInputUnusedLevels.AddQuotesIfUnrecognised = True
        Me.ucrInputUnusedLevels.IsMultiline = False
        Me.ucrInputUnusedLevels.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputUnusedLevels, "ucrInputUnusedLevels")
        Me.ucrInputUnusedLevels.Name = "ucrInputUnusedLevels"
        '
        'dlgRemoveUnusedLevels
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputUnusedLevels)
        Me.Controls.Add(Me.ucrRemoveUnusedFactorLevels)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrReceiverFactorColumn)
        Me.Controls.Add(Me.ucrSelectorFactorColumn)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRemoveUnusedLevels"
        Me.Tag = "Remove_Unused_Factor_Levels"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorFactorColumn As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactorColumn As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrRemoveUnusedFactorLevels As ucrFactor
    Friend WithEvents ucrInputUnusedLevels As ucrInputTextBox
End Class