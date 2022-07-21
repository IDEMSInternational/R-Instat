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
        Me.lblExplanatoryVariables = New System.Windows.Forms.Label()
        Me.cmdPCAOptions = New System.Windows.Forms.Button()
        Me.lblComponents = New System.Windows.Forms.Label()
        Me.ucrChkScaleData = New instat.ucrCheck()
        Me.ucrSaveResult = New instat.ucrSave()
        Me.ucrNudNumberOfComp = New instat.ucrNud()
        Me.ucrReceiverMultiplePCA = New instat.ucrReceiverMultiple()
        Me.ucrSelectorPCA = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverSupplFactors = New instat.ucrReceiverMultiple()
        Me.ucrChkExtraVariables = New instat.ucrCheck()
        Me.ucrReceiverSuppNumeric = New instat.ucrReceiverMultiple()
        Me.lblSupplFactors = New System.Windows.Forms.Label()
        Me.lblSupplNumeric = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblExplanatoryVariables
        '
        Me.lblExplanatoryVariables.AutoSize = True
        Me.lblExplanatoryVariables.Location = New System.Drawing.Point(254, 45)
        Me.lblExplanatoryVariables.Name = "lblExplanatoryVariables"
        Me.lblExplanatoryVariables.Size = New System.Drawing.Size(111, 13)
        Me.lblExplanatoryVariables.TabIndex = 1
        Me.lblExplanatoryVariables.Tag = "Explanatory_Variables"
        Me.lblExplanatoryVariables.Text = "Explanatory Variables:"
        '
        'cmdPCAOptions
        '
        Me.cmdPCAOptions.Location = New System.Drawing.Point(309, 407)
        Me.cmdPCAOptions.Name = "cmdPCAOptions"
        Me.cmdPCAOptions.Size = New System.Drawing.Size(96, 23)
        Me.cmdPCAOptions.TabIndex = 7
        Me.cmdPCAOptions.Tag = "Options"
        Me.cmdPCAOptions.Text = "Options"
        Me.cmdPCAOptions.UseVisualStyleBackColor = True
        '
        'lblComponents
        '
        Me.lblComponents.AutoSize = True
        Me.lblComponents.Location = New System.Drawing.Point(10, 204)
        Me.lblComponents.Name = "lblComponents"
        Me.lblComponents.Size = New System.Drawing.Size(121, 13)
        Me.lblComponents.TabIndex = 3
        Me.lblComponents.Tag = "Number_of_Components"
        Me.lblComponents.Text = "Number of Components:"
        '
        'ucrChkScaleData
        '
        Me.ucrChkScaleData.AutoSize = True
        Me.ucrChkScaleData.Checked = False
        Me.ucrChkScaleData.Location = New System.Drawing.Point(10, 228)
        Me.ucrChkScaleData.Name = "ucrChkScaleData"
        Me.ucrChkScaleData.Size = New System.Drawing.Size(156, 23)
        Me.ucrChkScaleData.TabIndex = 5
        '
        'ucrSaveResult
        '
        Me.ucrSaveResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveResult.Location = New System.Drawing.Point(10, 409)
        Me.ucrSaveResult.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveResult.Name = "ucrSaveResult"
        Me.ucrSaveResult.Size = New System.Drawing.Size(292, 24)
        Me.ucrSaveResult.TabIndex = 6
        '
        'ucrNudNumberOfComp
        '
        Me.ucrNudNumberOfComp.AutoSize = True
        Me.ucrNudNumberOfComp.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfComp.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberOfComp.Location = New System.Drawing.Point(137, 202)
        Me.ucrNudNumberOfComp.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfComp.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfComp.Name = "ucrNudNumberOfComp"
        Me.ucrNudNumberOfComp.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberOfComp.TabIndex = 4
        Me.ucrNudNumberOfComp.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverMultiplePCA
        '
        Me.ucrReceiverMultiplePCA.AutoSize = True
        Me.ucrReceiverMultiplePCA.frmParent = Me
        Me.ucrReceiverMultiplePCA.Location = New System.Drawing.Point(254, 60)
        Me.ucrReceiverMultiplePCA.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultiplePCA.Name = "ucrReceiverMultiplePCA"
        Me.ucrReceiverMultiplePCA.Selector = Nothing
        Me.ucrReceiverMultiplePCA.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultiplePCA.strNcFilePath = ""
        Me.ucrReceiverMultiplePCA.TabIndex = 2
        Me.ucrReceiverMultiplePCA.ucrSelector = Nothing
        '
        'ucrSelectorPCA
        '
        Me.ucrSelectorPCA.AutoSize = True
        Me.ucrSelectorPCA.bDropUnusedFilterLevels = False
        Me.ucrSelectorPCA.bShowHiddenColumns = False
        Me.ucrSelectorPCA.bUseCurrentFilter = True
        Me.ucrSelectorPCA.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorPCA.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPCA.Name = "ucrSelectorPCA"
        Me.ucrSelectorPCA.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorPCA.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 436)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 8
        '
        'ucrReceiverSupplFactors
        '
        Me.ucrReceiverSupplFactors.AutoSize = True
        Me.ucrReceiverSupplFactors.frmParent = Me
        Me.ucrReceiverSupplFactors.Location = New System.Drawing.Point(254, 301)
        Me.ucrReceiverSupplFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSupplFactors.Name = "ucrReceiverSupplFactors"
        Me.ucrReceiverSupplFactors.Selector = Nothing
        Me.ucrReceiverSupplFactors.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverSupplFactors.strNcFilePath = ""
        Me.ucrReceiverSupplFactors.TabIndex = 15
        Me.ucrReceiverSupplFactors.ucrSelector = Nothing
        '
        'ucrChkExtraVariables
        '
        Me.ucrChkExtraVariables.AutoSize = True
        Me.ucrChkExtraVariables.Checked = False
        Me.ucrChkExtraVariables.Location = New System.Drawing.Point(10, 275)
        Me.ucrChkExtraVariables.Name = "ucrChkExtraVariables"
        Me.ucrChkExtraVariables.Size = New System.Drawing.Size(156, 23)
        Me.ucrChkExtraVariables.TabIndex = 14
        '
        'ucrReceiverSuppNumeric
        '
        Me.ucrReceiverSuppNumeric.AutoSize = True
        Me.ucrReceiverSuppNumeric.frmParent = Me
        Me.ucrReceiverSuppNumeric.Location = New System.Drawing.Point(254, 180)
        Me.ucrReceiverSuppNumeric.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSuppNumeric.Name = "ucrReceiverSuppNumeric"
        Me.ucrReceiverSuppNumeric.Selector = Nothing
        Me.ucrReceiverSuppNumeric.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverSuppNumeric.strNcFilePath = ""
        Me.ucrReceiverSuppNumeric.TabIndex = 13
        Me.ucrReceiverSuppNumeric.ucrSelector = Nothing
        '
        'lblSupplFactors
        '
        Me.lblSupplFactors.AutoSize = True
        Me.lblSupplFactors.Location = New System.Drawing.Point(254, 285)
        Me.lblSupplFactors.Name = "lblSupplFactors"
        Me.lblSupplFactors.Size = New System.Drawing.Size(70, 13)
        Me.lblSupplFactors.TabIndex = 17
        Me.lblSupplFactors.Tag = "Explanatory_Variables"
        Me.lblSupplFactors.Text = "Suppl.Factor:"
        '
        'lblSupplNumeric
        '
        Me.lblSupplNumeric.AutoSize = True
        Me.lblSupplNumeric.Location = New System.Drawing.Point(254, 164)
        Me.lblSupplNumeric.Name = "lblSupplNumeric"
        Me.lblSupplNumeric.Size = New System.Drawing.Size(79, 13)
        Me.lblSupplNumeric.TabIndex = 16
        Me.lblSupplNumeric.Tag = "Explanatory_Variables"
        Me.lblSupplNumeric.Text = "Suppl.Numeric:"
        '
        'dlgPrincipalComponentAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(417, 494)
        Me.Controls.Add(Me.lblSupplFactors)
        Me.Controls.Add(Me.lblSupplNumeric)
        Me.Controls.Add(Me.ucrReceiverSupplFactors)
        Me.Controls.Add(Me.ucrChkExtraVariables)
        Me.Controls.Add(Me.ucrReceiverSuppNumeric)
        Me.Controls.Add(Me.ucrChkScaleData)
        Me.Controls.Add(Me.ucrNudNumberOfComp)
        Me.Controls.Add(Me.lblComponents)
        Me.Controls.Add(Me.cmdPCAOptions)
        Me.Controls.Add(Me.lblExplanatoryVariables)
        Me.Controls.Add(Me.ucrReceiverMultiplePCA)
        Me.Controls.Add(Me.ucrSelectorPCA)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSaveResult)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPrincipalComponentAnalysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Principal_Component_Analysis"
        Me.Text = "Principal Component Analysis"
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
    Friend WithEvents ucrReceiverSupplFactors As ucrReceiverMultiple
    Friend WithEvents ucrChkExtraVariables As ucrCheck
    Friend WithEvents ucrReceiverSuppNumeric As ucrReceiverMultiple
    Friend WithEvents lblSupplFactors As Label
    Friend WithEvents lblSupplNumeric As Label
End Class