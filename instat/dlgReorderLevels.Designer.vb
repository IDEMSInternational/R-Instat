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
Partial Class dlgReorderLevels
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgReorderLevels))
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.ucrSelectorFactorLevelsToReorder = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReorderFactor = New instat.ucrReorder()
        Me.rdoByHand = New System.Windows.Forms.RadioButton()
        Me.rdoProperty = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.rdoVariable = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblFactor
        '
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Tag = "Factor_Selected:"
        '
        'ucrReceiverFactor
        '
        resources.ApplyResources(Me.ucrReceiverFactor, "ucrReceiverFactor")
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'ucrSelectorFactorLevelsToReorder
        '
        Me.ucrSelectorFactorLevelsToReorder.bDropUnusedFilterLevels = False
        Me.ucrSelectorFactorLevelsToReorder.bShowHiddenColumns = False
        Me.ucrSelectorFactorLevelsToReorder.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorFactorLevelsToReorder, "ucrSelectorFactorLevelsToReorder")
        Me.ucrSelectorFactorLevelsToReorder.Name = "ucrSelectorFactorLevelsToReorder"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReorderFactor
        '
        resources.ApplyResources(Me.ucrReorderFactor, "ucrReorderFactor")
        Me.ucrReorderFactor.Name = "ucrReorderFactor"
        Me.ucrReorderFactor.ucrDataFrameList = Nothing
        Me.ucrReorderFactor.ucrReceiver = Nothing
        '
        'rdoByHand
        '
        resources.ApplyResources(Me.rdoByHand, "rdoByHand")
        Me.rdoByHand.BackColor = System.Drawing.SystemColors.Control
        Me.rdoByHand.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByHand.FlatAppearance.BorderSize = 2
        Me.rdoByHand.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoByHand.Name = "rdoByHand"
        Me.rdoByHand.TabStop = True
        Me.rdoByHand.Tag = "By_Hand"
        Me.rdoByHand.UseVisualStyleBackColor = False
        '
        'rdoProperty
        '
        resources.ApplyResources(Me.rdoProperty, "rdoProperty")
        Me.rdoProperty.BackColor = System.Drawing.SystemColors.Control
        Me.rdoProperty.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoProperty.FlatAppearance.BorderSize = 2
        Me.rdoProperty.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoProperty.Name = "rdoProperty"
        Me.rdoProperty.TabStop = True
        Me.rdoProperty.Tag = "Property"
        Me.rdoProperty.UseVisualStyleBackColor = False
        '
        'ucrPnlOptions
        '
        resources.ApplyResources(Me.ucrPnlOptions, "ucrPnlOptions")
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        '
        'rdoVariable
        '
        resources.ApplyResources(Me.rdoVariable, "rdoVariable")
        Me.rdoVariable.BackColor = System.Drawing.SystemColors.Control
        Me.rdoVariable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVariable.FlatAppearance.BorderSize = 2
        Me.rdoVariable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVariable.Name = "rdoVariable"
        Me.rdoVariable.TabStop = True
        Me.rdoVariable.Tag = "Variable"
        Me.rdoVariable.UseVisualStyleBackColor = False
        '
        'dlgReorderLevels
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rdoVariable)
        Me.Controls.Add(Me.rdoByHand)
        Me.Controls.Add(Me.rdoProperty)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReorderFactor)
        Me.Controls.Add(Me.ucrSelectorFactorLevelsToReorder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReorderLevels"
        Me.Tag = "Reorder_Levels"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorFactorLevelsToReorder As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrReorderFactor As ucrReorder
    Friend WithEvents rdoVariable As RadioButton
    Friend WithEvents rdoByHand As RadioButton
    Friend WithEvents rdoProperty As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
End Class
