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
Partial Class dlgLabelsLevels
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
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.cmdAddLevel = New System.Windows.Forms.Button()
        Me.lblLevelNumber = New System.Windows.Forms.Label()
        Me.lblNaValue = New System.Windows.Forms.Label()
        Me.ucrChkIncludeLevelNumbers = New instat.ucrCheck()
        Me.ucrReceiverLabels = New instat.ucrReceiverSingle()
        Me.ucrFactorLabels = New instat.ucrFactor()
        Me.ucrSelectorForLabels = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactor.Location = New System.Drawing.Point(256, 22)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(85, 13)
        Me.lblFactor.TabIndex = 3
        Me.lblFactor.Tag = "Factor_Selected:"
        Me.lblFactor.Text = "Factor Selected:"
        '
        'cmdAddLevel
        '
        Me.cmdAddLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAddLevel.Location = New System.Drawing.Point(82, 287)
        Me.cmdAddLevel.Name = "cmdAddLevel"
        Me.cmdAddLevel.Size = New System.Drawing.Size(168, 23)
        Me.cmdAddLevel.TabIndex = 5
        Me.cmdAddLevel.Text = "Add Factor Level"
        Me.cmdAddLevel.UseVisualStyleBackColor = True
        '
        'lblLevelNumber
        '
        Me.lblLevelNumber.AutoSize = True
        Me.lblLevelNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLevelNumber.Location = New System.Drawing.Point(375, 40)
        Me.lblLevelNumber.Name = "lblLevelNumber"
        Me.lblLevelNumber.Size = New System.Drawing.Size(39, 13)
        Me.lblLevelNumber.TabIndex = 7
        Me.lblLevelNumber.Text = "Label1"
        '
        'lblNaValue
        '
        Me.lblNaValue.AutoSize = True
        Me.lblNaValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNaValue.Location = New System.Drawing.Point(458, 40)
        Me.lblNaValue.Name = "lblNaValue"
        Me.lblNaValue.Size = New System.Drawing.Size(39, 13)
        Me.lblNaValue.TabIndex = 8
        Me.lblNaValue.Text = "Label1"
        '
        'ucrChkIncludeLevelNumbers
        '
        Me.ucrChkIncludeLevelNumbers.AutoSize = True
        Me.ucrChkIncludeLevelNumbers.Checked = False
        Me.ucrChkIncludeLevelNumbers.Location = New System.Drawing.Point(82, 316)
        Me.ucrChkIncludeLevelNumbers.Name = "ucrChkIncludeLevelNumbers"
        Me.ucrChkIncludeLevelNumbers.Size = New System.Drawing.Size(168, 23)
        Me.ucrChkIncludeLevelNumbers.TabIndex = 6
        '
        'ucrReceiverLabels
        '
        Me.ucrReceiverLabels.AutoSize = True
        Me.ucrReceiverLabels.frmParent = Me
        Me.ucrReceiverLabels.Location = New System.Drawing.Point(256, 37)
        Me.ucrReceiverLabels.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLabels.Name = "ucrReceiverLabels"
        Me.ucrReceiverLabels.Selector = Nothing
        Me.ucrReceiverLabels.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverLabels.strNcFilePath = ""
        Me.ucrReceiverLabels.TabIndex = 4
        Me.ucrReceiverLabels.ucrSelector = Nothing
        '
        'ucrFactorLabels
        '
        Me.ucrFactorLabels.AutoSize = True
        Me.ucrFactorLabels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrFactorLabels.clsReceiver = Nothing
        Me.ucrFactorLabels.Location = New System.Drawing.Point(256, 66)
        Me.ucrFactorLabels.Name = "ucrFactorLabels"
        Me.ucrFactorLabels.shtCurrSheet = Nothing
        Me.ucrFactorLabels.Size = New System.Drawing.Size(336, 299)
        Me.ucrFactorLabels.TabIndex = 2
        Me.ucrFactorLabels.ucrChkLevels = Nothing
        '
        'ucrSelectorForLabels
        '
        Me.ucrSelectorForLabels.AutoSize = True
        Me.ucrSelectorForLabels.bDropUnusedFilterLevels = False
        Me.ucrSelectorForLabels.bShowHiddenColumns = False
        Me.ucrSelectorForLabels.bUseCurrentFilter = True
        Me.ucrSelectorForLabels.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForLabels.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForLabels.Name = "ucrSelectorForLabels"
        Me.ucrSelectorForLabels.Size = New System.Drawing.Size(242, 196)
        Me.ucrSelectorForLabels.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 376)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgLabelsLevels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(604, 431)
        Me.Controls.Add(Me.lblNaValue)
        Me.Controls.Add(Me.lblLevelNumber)
        Me.Controls.Add(Me.ucrChkIncludeLevelNumbers)
        Me.Controls.Add(Me.cmdAddLevel)
        Me.Controls.Add(Me.ucrReceiverLabels)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrFactorLabels)
        Me.Controls.Add(Me.ucrSelectorForLabels)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgLabelsLevels"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Labels"
        Me.Text = "Labels/Levels"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForLabels As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFactorLabels As ucrFactor
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrReceiverLabels As ucrReceiverSingle
    Friend WithEvents cmdAddLevel As Button
    Friend WithEvents ucrChkIncludeLevelNumbers As ucrCheck
    Friend WithEvents lblLevelNumber As Label
    Friend WithEvents lblNaValue As Label
End Class
