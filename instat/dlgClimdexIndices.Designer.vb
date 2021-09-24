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
Partial Class dlgClimdexIndices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgClimdexIndices))
        Me.lblTmax = New System.Windows.Forms.Label()
        Me.lblTmin = New System.Windows.Forms.Label()
        Me.lblPrec = New System.Windows.Forms.Label()
        Me.cmdIndices = New System.Windows.Forms.Button()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.rdoAnnual = New System.Windows.Forms.RadioButton()
        Me.rdoMonthly = New System.Windows.Forms.RadioButton()
        Me.lblIndicesSelectedOutOf = New System.Windows.Forms.Label()
        Me.lblSelectedIndices = New System.Windows.Forms.Label()
        Me.lblTotalIndices = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrPnlAnnualMonthly = New instat.UcrPanel()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrChkSave = New instat.ucrCheck()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverPrec = New instat.ucrReceiverSingle()
        Me.ucrReceiverTmin = New instat.ucrReceiverSingle()
        Me.ucrReceiverTmax = New instat.ucrReceiverSingle()
        Me.ucrSelectorClimdex = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblTmax
        '
        resources.ApplyResources(Me.lblTmax, "lblTmax")
        Me.lblTmax.Name = "lblTmax"
        Me.lblTmax.Tag = "Maximum Temperature:"
        '
        'lblTmin
        '
        resources.ApplyResources(Me.lblTmin, "lblTmin")
        Me.lblTmin.Name = "lblTmin"
        Me.lblTmin.Tag = "Minimum Temperature:"
        '
        'lblPrec
        '
        resources.ApplyResources(Me.lblPrec, "lblPrec")
        Me.lblPrec.Name = "lblPrec"
        Me.lblPrec.Tag = ""
        '
        'cmdIndices
        '
        resources.ApplyResources(Me.cmdIndices, "cmdIndices")
        Me.cmdIndices.Name = "cmdIndices"
        Me.cmdIndices.Tag = "Indices..."
        Me.cmdIndices.UseVisualStyleBackColor = True
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Tag = ""
        '
        'lblMonth
        '
        resources.ApplyResources(Me.lblMonth, "lblMonth")
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Tag = "Month:"
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Tag = "Year:"
        '
        'rdoAnnual
        '
        resources.ApplyResources(Me.rdoAnnual, "rdoAnnual")
        Me.rdoAnnual.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAnnual.FlatAppearance.BorderSize = 2
        Me.rdoAnnual.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAnnual.Name = "rdoAnnual"
        Me.rdoAnnual.TabStop = True
        Me.rdoAnnual.UseVisualStyleBackColor = True
        '
        'rdoMonthly
        '
        resources.ApplyResources(Me.rdoMonthly, "rdoMonthly")
        Me.rdoMonthly.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonthly.FlatAppearance.BorderSize = 2
        Me.rdoMonthly.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonthly.Name = "rdoMonthly"
        Me.rdoMonthly.TabStop = True
        Me.rdoMonthly.UseVisualStyleBackColor = True
        '
        'lblIndicesSelectedOutOf
        '
        resources.ApplyResources(Me.lblIndicesSelectedOutOf, "lblIndicesSelectedOutOf")
        Me.lblIndicesSelectedOutOf.Name = "lblIndicesSelectedOutOf"
        Me.lblIndicesSelectedOutOf.Tag = "Month:"
        '
        'lblSelectedIndices
        '
        resources.ApplyResources(Me.lblSelectedIndices, "lblSelectedIndices")
        Me.lblSelectedIndices.ForeColor = System.Drawing.Color.Green
        Me.lblSelectedIndices.Name = "lblSelectedIndices"
        Me.lblSelectedIndices.Tag = ""
        '
        'lblTotalIndices
        '
        resources.ApplyResources(Me.lblTotalIndices, "lblTotalIndices")
        Me.lblTotalIndices.ForeColor = System.Drawing.Color.Green
        Me.lblTotalIndices.Name = "lblTotalIndices"
        Me.lblTotalIndices.Tag = ""
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Tag = ""
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDate, "ucrReceiverDate")
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrPnlAnnualMonthly
        '
        resources.ApplyResources(Me.ucrPnlAnnualMonthly, "ucrPnlAnnualMonthly")
        Me.ucrPnlAnnualMonthly.Name = "ucrPnlAnnualMonthly"
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYear, "ucrReceiverYear")
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMonth, "ucrReceiverMonth")
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrChkSave
        '
        Me.ucrChkSave.Checked = False
        resources.ApplyResources(Me.ucrChkSave, "ucrChkSave")
        Me.ucrChkSave.Name = "ucrChkSave"
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStation, "ucrReceiverStation")
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverPrec
        '
        Me.ucrReceiverPrec.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverPrec, "ucrReceiverPrec")
        Me.ucrReceiverPrec.Name = "ucrReceiverPrec"
        Me.ucrReceiverPrec.Selector = Nothing
        Me.ucrReceiverPrec.strNcFilePath = ""
        Me.ucrReceiverPrec.ucrSelector = Nothing
        '
        'ucrReceiverTmin
        '
        Me.ucrReceiverTmin.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverTmin, "ucrReceiverTmin")
        Me.ucrReceiverTmin.Name = "ucrReceiverTmin"
        Me.ucrReceiverTmin.Selector = Nothing
        Me.ucrReceiverTmin.strNcFilePath = ""
        Me.ucrReceiverTmin.ucrSelector = Nothing
        '
        'ucrReceiverTmax
        '
        Me.ucrReceiverTmax.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverTmax, "ucrReceiverTmax")
        Me.ucrReceiverTmax.Name = "ucrReceiverTmax"
        Me.ucrReceiverTmax.Selector = Nothing
        Me.ucrReceiverTmax.strNcFilePath = ""
        Me.ucrReceiverTmax.ucrSelector = Nothing
        '
        'ucrSelectorClimdex
        '
        Me.ucrSelectorClimdex.bDropUnusedFilterLevels = False
        Me.ucrSelectorClimdex.bShowHiddenColumns = False
        Me.ucrSelectorClimdex.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorClimdex, "ucrSelectorClimdex")
        Me.ucrSelectorClimdex.Name = "ucrSelectorClimdex"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgClimdexIndices
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.lblTotalIndices)
        Me.Controls.Add(Me.lblSelectedIndices)
        Me.Controls.Add(Me.lblIndicesSelectedOutOf)
        Me.Controls.Add(Me.rdoAnnual)
        Me.Controls.Add(Me.rdoMonthly)
        Me.Controls.Add(Me.ucrPnlAnnualMonthly)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrChkSave)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.cmdIndices)
        Me.Controls.Add(Me.lblPrec)
        Me.Controls.Add(Me.lblTmin)
        Me.Controls.Add(Me.lblTmax)
        Me.Controls.Add(Me.ucrReceiverPrec)
        Me.Controls.Add(Me.ucrReceiverTmin)
        Me.Controls.Add(Me.ucrReceiverTmax)
        Me.Controls.Add(Me.ucrSelectorClimdex)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimdexIndices"
        Me.Tag = "Climdex Indices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons

    Friend WithEvents ucrSelectorClimdex As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverTmax As ucrReceiverSingle
    Friend WithEvents ucrReceiverTmin As ucrReceiverSingle
    Friend WithEvents ucrReceiverPrec As ucrReceiverSingle
    Friend WithEvents lblTmax As Label
    Friend WithEvents lblTmin As Label
    Friend WithEvents lblPrec As Label
    Friend WithEvents cmdIndices As Button
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrChkSave As ucrCheck
    Friend WithEvents lblYear As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents rdoAnnual As RadioButton
    Friend WithEvents rdoMonthly As RadioButton
    Friend WithEvents ucrPnlAnnualMonthly As UcrPanel
    Friend WithEvents lblTotalIndices As Label
    Friend WithEvents lblSelectedIndices As Label
    Friend WithEvents lblIndicesSelectedOutOf As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
End Class