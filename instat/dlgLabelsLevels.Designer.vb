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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgLabelsLevels))
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.cmdAddLevel = New System.Windows.Forms.Button()
        Me.ucrChkIncludeLevelNumbers = New instat.ucrCheck()
        Me.ucrReceiverLabels = New instat.ucrReceiverSingle()
        Me.ucrFactorLabels = New instat.ucrFactor()
        Me.ucrSelectorForLabels = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblFactor
        '
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Tag = "Factor_Selected:"
        '
        'cmdAddLevel
        '
        resources.ApplyResources(Me.cmdAddLevel, "cmdAddLevel")
        Me.cmdAddLevel.Name = "cmdAddLevel"
        Me.cmdAddLevel.UseVisualStyleBackColor = True
        '
        'ucrChkIncludeLevelNumbers
        '
        Me.ucrChkIncludeLevelNumbers.Checked = False
        resources.ApplyResources(Me.ucrChkIncludeLevelNumbers, "ucrChkIncludeLevelNumbers")
        Me.ucrChkIncludeLevelNumbers.Name = "ucrChkIncludeLevelNumbers"
        '
        'ucrReceiverLabels
        '
        Me.ucrReceiverLabels.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverLabels, "ucrReceiverLabels")
        Me.ucrReceiverLabels.Name = "ucrReceiverLabels"
        Me.ucrReceiverLabels.Selector = Nothing
        Me.ucrReceiverLabels.strNcFilePath = ""
        Me.ucrReceiverLabels.ucrSelector = Nothing
        '
        'ucrFactorLabels
        '
        resources.ApplyResources(Me.ucrFactorLabels, "ucrFactorLabels")
        Me.ucrFactorLabels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrFactorLabels.clsReceiver = Nothing
        Me.ucrFactorLabels.Name = "ucrFactorLabels"
        Me.ucrFactorLabels.shtCurrSheet = Nothing
        Me.ucrFactorLabels.ucrChkLevels = Nothing
        '
        'ucrSelectorForLabels
        '
        Me.ucrSelectorForLabels.bShowHiddenColumns = False
        Me.ucrSelectorForLabels.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForLabels, "ucrSelectorForLabels")
        Me.ucrSelectorForLabels.Name = "ucrSelectorForLabels"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgLabelsLevels
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Tag = "Labels"
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
End Class
