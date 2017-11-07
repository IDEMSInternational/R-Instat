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
Partial Class dlgPrincipalComponentAnalysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgPrincipalComponentAnalysis))
        Me.lblExplanatoryVariables = New System.Windows.Forms.Label()
        Me.cmdPCAOptions = New System.Windows.Forms.Button()
        Me.lblComponents = New System.Windows.Forms.Label()
        Me.ucrChkScaleData = New instat.ucrCheck()
        Me.ucrSaveResult = New instat.ucrSave()
        Me.ucrNudNumberOfComp = New instat.ucrNud()
        Me.ucrReceiverMultiplePCA = New instat.ucrReceiverMultiple()
        Me.ucrSelectorPCA = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblExplanatoryVariables
        '
        resources.ApplyResources(Me.lblExplanatoryVariables, "lblExplanatoryVariables")
        Me.lblExplanatoryVariables.Name = "lblExplanatoryVariables"
        Me.lblExplanatoryVariables.Tag = "Explanatory_Variables"
        '
        'cmdPCAOptions
        '
        resources.ApplyResources(Me.cmdPCAOptions, "cmdPCAOptions")
        Me.cmdPCAOptions.Name = "cmdPCAOptions"
        Me.cmdPCAOptions.Tag = "Options"
        Me.cmdPCAOptions.UseVisualStyleBackColor = True
        '
        'lblComponents
        '
        resources.ApplyResources(Me.lblComponents, "lblComponents")
        Me.lblComponents.Name = "lblComponents"
        Me.lblComponents.Tag = "Number_of_Components"
        '
        'ucrChkScaleData
        '
        Me.ucrChkScaleData.Checked = False
        resources.ApplyResources(Me.ucrChkScaleData, "ucrChkScaleData")
        Me.ucrChkScaleData.Name = "ucrChkScaleData"
        '
        'ucrSaveResult
        '
        resources.ApplyResources(Me.ucrSaveResult, "ucrSaveResult")
        Me.ucrSaveResult.Name = "ucrSaveResult"
        '
        'ucrNudNumberOfComp
        '
        Me.ucrNudNumberOfComp.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfComp.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudNumberOfComp, "ucrNudNumberOfComp")
        Me.ucrNudNumberOfComp.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfComp.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfComp.Name = "ucrNudNumberOfComp"
        Me.ucrNudNumberOfComp.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverMultiplePCA
        '
        Me.ucrReceiverMultiplePCA.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMultiplePCA, "ucrReceiverMultiplePCA")
        Me.ucrReceiverMultiplePCA.Name = "ucrReceiverMultiplePCA"
        Me.ucrReceiverMultiplePCA.Selector = Nothing
        Me.ucrReceiverMultiplePCA.strNcFilePath = ""
        Me.ucrReceiverMultiplePCA.ucrSelector = Nothing
        '
        'ucrSelectorPCA
        '
        Me.ucrSelectorPCA.bShowHiddenColumns = False
        Me.ucrSelectorPCA.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorPCA, "ucrSelectorPCA")
        Me.ucrSelectorPCA.Name = "ucrSelectorPCA"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgPrincipalComponentAnalysis
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkScaleData)
        Me.Controls.Add(Me.ucrSaveResult)
        Me.Controls.Add(Me.ucrNudNumberOfComp)
        Me.Controls.Add(Me.lblComponents)
        Me.Controls.Add(Me.cmdPCAOptions)
        Me.Controls.Add(Me.lblExplanatoryVariables)
        Me.Controls.Add(Me.ucrReceiverMultiplePCA)
        Me.Controls.Add(Me.ucrSelectorPCA)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPrincipalComponentAnalysis"
        Me.Tag = "Principal_Component_Analysis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorPCA As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverMultiplePCA As ucrReceiverMultiple
    Friend WithEvents lblExplanatoryVariables As Label
    Friend WithEvents cmdPCAOptions As Button
    Friend WithEvents lblComponents As Label
    Friend WithEvents ucrNudNumberOfComp As ucrNud
    Friend WithEvents ucrChkScaleData As ucrCheck
    Friend WithEvents ucrSaveResult As ucrSave
End Class