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
        Me.cmdPCAOptions.Location = New System.Drawing.Point(310, 254)
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
        Me.ucrChkScaleData.Checked = False
        Me.ucrChkScaleData.Location = New System.Drawing.Point(10, 228)
        Me.ucrChkScaleData.Name = "ucrChkScaleData"
        Me.ucrChkScaleData.Size = New System.Drawing.Size(156, 20)
        Me.ucrChkScaleData.TabIndex = 5
        '
        'ucrSaveResult
        '
        Me.ucrSaveResult.Location = New System.Drawing.Point(10, 254)
        Me.ucrSaveResult.Name = "ucrSaveResult"
        Me.ucrSaveResult.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveResult.TabIndex = 6
        '
        'ucrNudNumberOfComp
        '
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
        Me.ucrSelectorPCA.bShowHiddenColumns = False
        Me.ucrSelectorPCA.bUseCurrentFilter = True
        Me.ucrSelectorPCA.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorPCA.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPCA.Name = "ucrSelectorPCA"
        Me.ucrSelectorPCA.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorPCA.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 283)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 8
        '
        'dlgPrincipalComponentAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 341)
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
End Class