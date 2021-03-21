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
Partial Class dlgReferenceLevel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgReferenceLevel))
        Me.ucrBase = New instat.ucrButtons()
        Me.lblFactorSelected = New System.Windows.Forms.Label()
        Me.ucrSelectorForReferenceLevels = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverReferenceLevels = New instat.ucrReceiverSingle()
        Me.ucrFactorReferenceLevels = New instat.ucrFactor()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'lblFactorSelected
        '
        resources.ApplyResources(Me.lblFactorSelected, "lblFactorSelected")
        Me.lblFactorSelected.Name = "lblFactorSelected"
        Me.lblFactorSelected.Tag = "Factor_Selected:"
        '
        'ucrSelectorForReferenceLevels
        '
        Me.ucrSelectorForReferenceLevels.bShowHiddenColumns = False
        Me.ucrSelectorForReferenceLevels.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForReferenceLevels, "ucrSelectorForReferenceLevels")
        Me.ucrSelectorForReferenceLevels.Name = "ucrSelectorForReferenceLevels"
        '
        'ucrReceiverReferenceLevels
        '
        Me.ucrReceiverReferenceLevels.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverReferenceLevels, "ucrReceiverReferenceLevels")
        Me.ucrReceiverReferenceLevels.Name = "ucrReceiverReferenceLevels"
        Me.ucrReceiverReferenceLevels.Selector = Nothing
        Me.ucrReceiverReferenceLevels.strNcFilePath = ""
        Me.ucrReceiverReferenceLevels.ucrSelector = Nothing
        '
        'ucrFactorReferenceLevels
        '
        resources.ApplyResources(Me.ucrFactorReferenceLevels, "ucrFactorReferenceLevels")
        Me.ucrFactorReferenceLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrFactorReferenceLevels.clsReceiver = Nothing
        Me.ucrFactorReferenceLevels.Name = "ucrFactorReferenceLevels"
        Me.ucrFactorReferenceLevels.shtCurrSheet = Nothing
        Me.ucrFactorReferenceLevels.ucrChkLevels = Nothing
        '
        'dlgReferenceLevel
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrReceiverReferenceLevels)
        Me.Controls.Add(Me.ucrSelectorForReferenceLevels)
        Me.Controls.Add(Me.ucrFactorReferenceLevels)
        Me.Controls.Add(Me.lblFactorSelected)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReferenceLevel"
        Me.Tag = "Reference_Level"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblFactorSelected As Label
    Friend WithEvents ucrSelectorForReferenceLevels As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverReferenceLevels As ucrReceiverSingle
    Friend WithEvents ucrFactorReferenceLevels As ucrFactor
End Class