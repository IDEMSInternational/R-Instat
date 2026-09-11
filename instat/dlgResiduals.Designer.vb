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
Partial Class dlgResiduals
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
        Me.lblSelectedModel = New System.Windows.Forms.Label()
        Me.ucrReceiverModel = New instat.ucrReceiverSingle()
        Me.ucrChkShapiro = New instat.ucrCheck()
        Me.ucrChkModel = New instat.ucrCheck()
        Me.ucrNudCallSize = New instat.ucrNud()
        Me.ucrChkLabel = New instat.ucrCheck()
        Me.ucrNudLabelSize = New instat.ucrNud()
        Me.ucrChkAxes = New instat.ucrCheck()
        Me.ucrNudAxesSize = New instat.ucrNud()
        Me.ucrChkOnePage = New instat.ucrCheck()
        Me.ucrNudOnePageCols = New instat.ucrNud()
        Me.ucrSaveResiduals = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorResiduals = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblSelectedModel
        '
        Me.lblSelectedModel.AutoSize = True
        Me.lblSelectedModel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblSelectedModel.Location = New System.Drawing.Point(242, 63)
        Me.lblSelectedModel.Name = "lblSelectedModel"
        Me.lblSelectedModel.Size = New System.Drawing.Size(84, 13)
        Me.lblSelectedModel.TabIndex = 0
        Me.lblSelectedModel.Tag = "Selected_Model:"
        Me.lblSelectedModel.Text = "Selected Model:"
        '
        'ucrReceiverModel
        '
        Me.ucrReceiverModel.AutoSize = True
        Me.ucrReceiverModel.frmParent = Me
        Me.ucrReceiverModel.Location = New System.Drawing.Point(242, 78)
        Me.ucrReceiverModel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverModel.Name = "ucrReceiverModel"
        Me.ucrReceiverModel.Selector = Nothing
        Me.ucrReceiverModel.Size = New System.Drawing.Size(120, 22)
        Me.ucrReceiverModel.strNcFilePath = ""
        Me.ucrReceiverModel.TabIndex = 1
        Me.ucrReceiverModel.ucrSelector = Nothing
        '
        'ucrChkShapiro
        '
        Me.ucrChkShapiro.AutoSize = True
        Me.ucrChkShapiro.Checked = False
        Me.ucrChkShapiro.Location = New System.Drawing.Point(9, 201)
        Me.ucrChkShapiro.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkShapiro.Name = "ucrChkShapiro"
        Me.ucrChkShapiro.Size = New System.Drawing.Size(140, 24)
        Me.ucrChkShapiro.TabIndex = 2
        '
        'ucrChkModel
        '
        Me.ucrChkModel.AutoSize = True
        Me.ucrChkModel.Checked = False
        Me.ucrChkModel.Location = New System.Drawing.Point(9, 230)
        Me.ucrChkModel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkModel.Name = "ucrChkModel"
        Me.ucrChkModel.Size = New System.Drawing.Size(140, 24)
        Me.ucrChkModel.TabIndex = 3
        '
        'ucrNudCallSize
        '
        Me.ucrNudCallSize.AutoSize = True
        Me.ucrNudCallSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCallSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCallSize.Location = New System.Drawing.Point(154, 228)
        Me.ucrNudCallSize.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrNudCallSize.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ucrNudCallSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCallSize.Name = "ucrNudCallSize"
        Me.ucrNudCallSize.Size = New System.Drawing.Size(56, 24)
        Me.ucrNudCallSize.TabIndex = 4
        Me.ucrNudCallSize.Value = New Decimal(New Integer() {9, 0, 0, 0})
        '
        'ucrChkLabel
        '
        Me.ucrChkLabel.AutoSize = True
        Me.ucrChkLabel.Checked = False
        Me.ucrChkLabel.Location = New System.Drawing.Point(9, 259)
        Me.ucrChkLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkLabel.Name = "ucrChkLabel"
        Me.ucrChkLabel.Size = New System.Drawing.Size(140, 24)
        Me.ucrChkLabel.TabIndex = 5
        '
        'ucrNudLabelSize
        '
        Me.ucrNudLabelSize.AutoSize = True
        Me.ucrNudLabelSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLabelSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLabelSize.Location = New System.Drawing.Point(154, 258)
        Me.ucrNudLabelSize.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrNudLabelSize.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ucrNudLabelSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLabelSize.Name = "ucrNudLabelSize"
        Me.ucrNudLabelSize.Size = New System.Drawing.Size(56, 24)
        Me.ucrNudLabelSize.TabIndex = 6
        Me.ucrNudLabelSize.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'ucrChkAxes
        '
        Me.ucrChkAxes.AutoSize = True
        Me.ucrChkAxes.Checked = False
        Me.ucrChkAxes.Location = New System.Drawing.Point(9, 288)
        Me.ucrChkAxes.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkAxes.Name = "ucrChkAxes"
        Me.ucrChkAxes.Size = New System.Drawing.Size(140, 24)
        Me.ucrChkAxes.TabIndex = 7
        '
        'ucrNudAxesSize
        '
        Me.ucrNudAxesSize.AutoSize = True
        Me.ucrNudAxesSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAxesSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAxesSize.Location = New System.Drawing.Point(154, 286)
        Me.ucrNudAxesSize.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrNudAxesSize.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ucrNudAxesSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAxesSize.Name = "ucrNudAxesSize"
        Me.ucrNudAxesSize.Size = New System.Drawing.Size(56, 24)
        Me.ucrNudAxesSize.TabIndex = 8
        Me.ucrNudAxesSize.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'ucrChkOnePage
        '
        Me.ucrChkOnePage.AutoSize = True
        Me.ucrChkOnePage.Checked = False
        Me.ucrChkOnePage.Location = New System.Drawing.Point(9, 318)
        Me.ucrChkOnePage.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrChkOnePage.Name = "ucrChkOnePage"
        Me.ucrChkOnePage.Size = New System.Drawing.Size(140, 24)
        Me.ucrChkOnePage.TabIndex = 9
        '
        'ucrNudOnePageCols
        '
        Me.ucrNudOnePageCols.AutoSize = True
        Me.ucrNudOnePageCols.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOnePageCols.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudOnePageCols.Location = New System.Drawing.Point(154, 315)
        Me.ucrNudOnePageCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrNudOnePageCols.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ucrNudOnePageCols.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudOnePageCols.Name = "ucrNudOnePageCols"
        Me.ucrNudOnePageCols.Size = New System.Drawing.Size(56, 24)
        Me.ucrNudOnePageCols.TabIndex = 10
        Me.ucrNudOnePageCols.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'ucrSaveResiduals
        '
        Me.ucrSaveResiduals.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveResiduals.Location = New System.Drawing.Point(9, 362)
        Me.ucrSaveResiduals.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveResiduals.Name = "ucrSaveResiduals"
        Me.ucrSaveResiduals.Size = New System.Drawing.Size(306, 24)
        Me.ucrSaveResiduals.TabIndex = 11
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(6, 404)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 12
        '
        'ucrSelectorResiduals
        '
        Me.ucrSelectorResiduals.AutoSize = True
        Me.ucrSelectorResiduals.bDropUnusedFilterLevels = False
        Me.ucrSelectorResiduals.bShowHiddenColumns = False
        Me.ucrSelectorResiduals.bUseCurrentFilter = True
        Me.ucrSelectorResiduals.Location = New System.Drawing.Point(9, 10)
        Me.ucrSelectorResiduals.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorResiduals.Name = "ucrSelectorResiduals"
        Me.ucrSelectorResiduals.Size = New System.Drawing.Size(213, 184)
        Me.ucrSelectorResiduals.TabIndex = 13
        '
        'dlgResiduals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 459)
        Me.Controls.Add(Me.lblSelectedModel)
        Me.Controls.Add(Me.ucrReceiverModel)
        Me.Controls.Add(Me.ucrChkShapiro)
        Me.Controls.Add(Me.ucrChkModel)
        Me.Controls.Add(Me.ucrNudCallSize)
        Me.Controls.Add(Me.ucrChkLabel)
        Me.Controls.Add(Me.ucrNudLabelSize)
        Me.Controls.Add(Me.ucrChkAxes)
        Me.Controls.Add(Me.ucrNudAxesSize)
        Me.Controls.Add(Me.ucrChkOnePage)
        Me.Controls.Add(Me.ucrNudOnePageCols)
        Me.Controls.Add(Me.ucrSaveResiduals)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorResiduals)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "dlgResiduals"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Residuals"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSelectedModel As Label
    Friend WithEvents ucrReceiverModel As ucrReceiverSingle
    Friend WithEvents ucrChkShapiro As ucrCheck
    Friend WithEvents ucrChkModel As ucrCheck
    Friend WithEvents ucrNudCallSize As ucrNud
    Friend WithEvents ucrChkLabel As ucrCheck
    Friend WithEvents ucrNudLabelSize As ucrNud
    Friend WithEvents ucrChkAxes As ucrCheck
    Friend WithEvents ucrNudAxesSize As ucrNud
    Friend WithEvents ucrChkOnePage As ucrCheck
    Friend WithEvents ucrNudOnePageCols As ucrNud
    Friend WithEvents ucrSaveResiduals As ucrSave
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorResiduals As ucrSelectorByDataFrameAddRemove
End Class