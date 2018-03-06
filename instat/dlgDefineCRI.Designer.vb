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
Partial Class dlgDefineCRI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDefineCRI))
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdAddComponent = New System.Windows.Forms.Button()
        Me.lblReceiverRedFlag = New System.Windows.Forms.Label()
        Me.lblWeights = New System.Windows.Forms.Label()
        Me.lblIndexComponentsList = New System.Windows.Forms.Label()
        Me.lstIndexComponents = New System.Windows.Forms.ListView()
        Me.lblModelPreview = New System.Windows.Forms.Label()
        Me.ucrSaveCRI = New instat.ucrSave()
        Me.ucrInputCRIPreview = New instat.ucrInputTextBox()
        Me.ucrNudWeights = New instat.ucrNud()
        Me.ucrGridWeights = New instat.ucrFactor()
        Me.ucrReceiverRedFlag = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorCRI = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkScaleNumeric = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'cmdEdit
        '
        resources.ApplyResources(Me.cmdEdit, "cmdEdit")
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        resources.ApplyResources(Me.cmdDelete, "cmdDelete")
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdAddComponent
        '
        resources.ApplyResources(Me.cmdAddComponent, "cmdAddComponent")
        Me.cmdAddComponent.Name = "cmdAddComponent"
        Me.cmdAddComponent.UseVisualStyleBackColor = True
        '
        'lblReceiverRedFlag
        '
        resources.ApplyResources(Me.lblReceiverRedFlag, "lblReceiverRedFlag")
        Me.lblReceiverRedFlag.Name = "lblReceiverRedFlag"
        '
        'lblWeights
        '
        resources.ApplyResources(Me.lblWeights, "lblWeights")
        Me.lblWeights.Name = "lblWeights"
        '
        'lblIndexComponentsList
        '
        resources.ApplyResources(Me.lblIndexComponentsList, "lblIndexComponentsList")
        Me.lblIndexComponentsList.Name = "lblIndexComponentsList"
        '
        'lstIndexComponents
        '
        Me.lstIndexComponents.FullRowSelect = True
        resources.ApplyResources(Me.lstIndexComponents, "lstIndexComponents")
        Me.lstIndexComponents.Name = "lstIndexComponents"
        Me.lstIndexComponents.UseCompatibleStateImageBehavior = False
        Me.lstIndexComponents.View = System.Windows.Forms.View.Details
        '
        'lblModelPreview
        '
        resources.ApplyResources(Me.lblModelPreview, "lblModelPreview")
        Me.lblModelPreview.Name = "lblModelPreview"
        '
        'ucrSaveCRI
        '
        resources.ApplyResources(Me.ucrSaveCRI, "ucrSaveCRI")
        Me.ucrSaveCRI.Name = "ucrSaveCRI"
        '
        'ucrInputCRIPreview
        '
        Me.ucrInputCRIPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputCRIPreview.IsMultiline = False
        Me.ucrInputCRIPreview.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputCRIPreview, "ucrInputCRIPreview")
        Me.ucrInputCRIPreview.Name = "ucrInputCRIPreview"
        '
        'ucrNudWeights
        '
        Me.ucrNudWeights.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWeights.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudWeights, "ucrNudWeights")
        Me.ucrNudWeights.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWeights.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWeights.Name = "ucrNudWeights"
        Me.ucrNudWeights.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrGridWeights
        '
        resources.ApplyResources(Me.ucrGridWeights, "ucrGridWeights")
        Me.ucrGridWeights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrGridWeights.clsReceiver = Nothing
        Me.ucrGridWeights.Name = "ucrGridWeights"
        Me.ucrGridWeights.shtCurrSheet = Nothing
        Me.ucrGridWeights.ucrChkLevels = Nothing
        '
        'ucrReceiverRedFlag
        '
        Me.ucrReceiverRedFlag.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverRedFlag, "ucrReceiverRedFlag")
        Me.ucrReceiverRedFlag.Name = "ucrReceiverRedFlag"
        Me.ucrReceiverRedFlag.Selector = Nothing
        Me.ucrReceiverRedFlag.strNcFilePath = ""
        Me.ucrReceiverRedFlag.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorCRI
        '
        Me.ucrSelectorCRI.bShowHiddenColumns = False
        Me.ucrSelectorCRI.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorCRI, "ucrSelectorCRI")
        Me.ucrSelectorCRI.Name = "ucrSelectorCRI"
        '
        'ucrChkScaleNumeric
        '
        Me.ucrChkScaleNumeric.Checked = False
        resources.ApplyResources(Me.ucrChkScaleNumeric, "ucrChkScaleNumeric")
        Me.ucrChkScaleNumeric.Name = "ucrChkScaleNumeric"
        '
        'dlgDefineCRI
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveCRI)
        Me.Controls.Add(Me.ucrInputCRIPreview)
        Me.Controls.Add(Me.lblModelPreview)
        Me.Controls.Add(Me.lstIndexComponents)
        Me.Controls.Add(Me.ucrNudWeights)
        Me.Controls.Add(Me.ucrGridWeights)
        Me.Controls.Add(Me.ucrReceiverRedFlag)
        Me.Controls.Add(Me.lblIndexComponentsList)
        Me.Controls.Add(Me.lblWeights)
        Me.Controls.Add(Me.lblReceiverRedFlag)
        Me.Controls.Add(Me.cmdAddComponent)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorCRI)
        Me.Controls.Add(Me.ucrChkScaleNumeric)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDefineCRI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrChkScaleNumeric As ucrCheck
    Friend WithEvents ucrSelectorCRI As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdAddComponent As Button
    Friend WithEvents lblReceiverRedFlag As Label
    Friend WithEvents lblWeights As Label
    Friend WithEvents lblIndexComponentsList As Label
    Friend WithEvents ucrReceiverRedFlag As ucrReceiverSingle
    Friend WithEvents ucrNudWeights As ucrNud
    Friend WithEvents ucrGridWeights As ucrFactor
    Friend WithEvents lstIndexComponents As ListView
    Friend WithEvents ucrInputCRIPreview As ucrInputTextBox
    Friend WithEvents lblModelPreview As Label
    Friend WithEvents ucrSaveCRI As ucrSave
End Class
