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
Partial Class dlgView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgView))
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.rdoDispSepOutputWindow = New System.Windows.Forms.RadioButton()
        Me.rdoDispOutputWindow = New System.Windows.Forms.RadioButton()
        Me.rdoBottom = New System.Windows.Forms.RadioButton()
        Me.rdoTop = New System.Windows.Forms.RadioButton()
        Me.lblDisplayFrom = New System.Windows.Forms.Label()
        Me.lblNumberofRows = New System.Windows.Forms.Label()
        Me.rdoHTMLOutputWindow = New System.Windows.Forms.RadioButton()
        Me.rdoViewAll = New System.Windows.Forms.RadioButton()
        Me.rdoViewSelectedColumnsRows = New System.Windows.Forms.RadioButton()
        Me.ucrPnlViewData = New instat.UcrPanel()
        Me.ucrReceiverSortCol = New instat.ucrReceiverSingle()
        Me.ucrChkSortColumn = New instat.ucrCheck()
        Me.ucrNudNumberRows = New instat.ucrNud()
        Me.ucrPnlDisplayFrom = New instat.UcrPanel()
        Me.ucrChkSpecifyRows = New instat.ucrCheck()
        Me.ucrPnlDisplayWindow = New instat.UcrPanel()
        Me.ucrReceiverView = New instat.ucrReceiverMultiple()
        Me.ucrSelectorForView = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        resources.ApplyResources(Me.lblSelected, "lblSelected")
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Tag = ""
        '
        'rdoDispSepOutputWindow
        '
        resources.ApplyResources(Me.rdoDispSepOutputWindow, "rdoDispSepOutputWindow")
        Me.rdoDispSepOutputWindow.Name = "rdoDispSepOutputWindow"
        Me.rdoDispSepOutputWindow.TabStop = True
        Me.rdoDispSepOutputWindow.UseVisualStyleBackColor = True
        '
        'rdoDispOutputWindow
        '
        resources.ApplyResources(Me.rdoDispOutputWindow, "rdoDispOutputWindow")
        Me.rdoDispOutputWindow.Name = "rdoDispOutputWindow"
        Me.rdoDispOutputWindow.TabStop = True
        Me.rdoDispOutputWindow.UseVisualStyleBackColor = True
        '
        'rdoBottom
        '
        resources.ApplyResources(Me.rdoBottom, "rdoBottom")
        Me.rdoBottom.Name = "rdoBottom"
        Me.rdoBottom.TabStop = True
        Me.rdoBottom.UseVisualStyleBackColor = True
        '
        'rdoTop
        '
        resources.ApplyResources(Me.rdoTop, "rdoTop")
        Me.rdoTop.Name = "rdoTop"
        Me.rdoTop.TabStop = True
        Me.rdoTop.UseVisualStyleBackColor = True
        '
        'lblDisplayFrom
        '
        resources.ApplyResources(Me.lblDisplayFrom, "lblDisplayFrom")
        Me.lblDisplayFrom.Name = "lblDisplayFrom"
        Me.lblDisplayFrom.Tag = ""
        '
        'lblNumberofRows
        '
        resources.ApplyResources(Me.lblNumberofRows, "lblNumberofRows")
        Me.lblNumberofRows.Name = "lblNumberofRows"
        Me.lblNumberofRows.Tag = "Number_of_rows"
        '
        'rdoHTMLOutputWindow
        '
        resources.ApplyResources(Me.rdoHTMLOutputWindow, "rdoHTMLOutputWindow")
        Me.rdoHTMLOutputWindow.Name = "rdoHTMLOutputWindow"
        Me.rdoHTMLOutputWindow.TabStop = True
        Me.rdoHTMLOutputWindow.UseVisualStyleBackColor = True
        '
        'rdoViewAll
        '
        resources.ApplyResources(Me.rdoViewAll, "rdoViewAll")
        Me.rdoViewAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoViewAll.FlatAppearance.BorderSize = 2
        Me.rdoViewAll.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoViewAll.Name = "rdoViewAll"
        Me.rdoViewAll.UseVisualStyleBackColor = True
        '
        'rdoViewSelectedColumnsRows
        '
        resources.ApplyResources(Me.rdoViewSelectedColumnsRows, "rdoViewSelectedColumnsRows")
        Me.rdoViewSelectedColumnsRows.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoViewSelectedColumnsRows.FlatAppearance.BorderSize = 2
        Me.rdoViewSelectedColumnsRows.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoViewSelectedColumnsRows.Name = "rdoViewSelectedColumnsRows"
        Me.rdoViewSelectedColumnsRows.UseVisualStyleBackColor = True
        '
        'ucrPnlViewData
        '
        resources.ApplyResources(Me.ucrPnlViewData, "ucrPnlViewData")
        Me.ucrPnlViewData.Name = "ucrPnlViewData"
        '
        'ucrReceiverSortCol
        '
        Me.ucrReceiverSortCol.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSortCol, "ucrReceiverSortCol")
        Me.ucrReceiverSortCol.Name = "ucrReceiverSortCol"
        Me.ucrReceiverSortCol.Selector = Nothing
        Me.ucrReceiverSortCol.strNcFilePath = ""
        Me.ucrReceiverSortCol.ucrSelector = Nothing
        '
        'ucrChkSortColumn
        '
        Me.ucrChkSortColumn.Checked = False
        resources.ApplyResources(Me.ucrChkSortColumn, "ucrChkSortColumn")
        Me.ucrChkSortColumn.Name = "ucrChkSortColumn"
        '
        'ucrNudNumberRows
        '
        Me.ucrNudNumberRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudNumberRows, "ucrNudNumberRows")
        Me.ucrNudNumberRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberRows.Name = "ucrNudNumberRows"
        Me.ucrNudNumberRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlDisplayFrom
        '
        resources.ApplyResources(Me.ucrPnlDisplayFrom, "ucrPnlDisplayFrom")
        Me.ucrPnlDisplayFrom.Name = "ucrPnlDisplayFrom"
        '
        'ucrChkSpecifyRows
        '
        Me.ucrChkSpecifyRows.Checked = False
        resources.ApplyResources(Me.ucrChkSpecifyRows, "ucrChkSpecifyRows")
        Me.ucrChkSpecifyRows.Name = "ucrChkSpecifyRows"
        '
        'ucrPnlDisplayWindow
        '
        resources.ApplyResources(Me.ucrPnlDisplayWindow, "ucrPnlDisplayWindow")
        Me.ucrPnlDisplayWindow.Name = "ucrPnlDisplayWindow"
        '
        'ucrReceiverView
        '
        Me.ucrReceiverView.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverView, "ucrReceiverView")
        Me.ucrReceiverView.Name = "ucrReceiverView"
        Me.ucrReceiverView.Selector = Nothing
        Me.ucrReceiverView.strNcFilePath = ""
        Me.ucrReceiverView.ucrSelector = Nothing
        '
        'ucrSelectorForView
        '
        Me.ucrSelectorForView.bShowHiddenColumns = False
        Me.ucrSelectorForView.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForView, "ucrSelectorForView")
        Me.ucrSelectorForView.Name = "ucrSelectorForView"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgView
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rdoViewAll)
        Me.Controls.Add(Me.rdoViewSelectedColumnsRows)
        Me.Controls.Add(Me.ucrPnlViewData)
        Me.Controls.Add(Me.ucrReceiverSortCol)
        Me.Controls.Add(Me.ucrChkSortColumn)
        Me.Controls.Add(Me.rdoHTMLOutputWindow)
        Me.Controls.Add(Me.ucrNudNumberRows)
        Me.Controls.Add(Me.rdoBottom)
        Me.Controls.Add(Me.rdoTop)
        Me.Controls.Add(Me.ucrPnlDisplayFrom)
        Me.Controls.Add(Me.ucrChkSpecifyRows)
        Me.Controls.Add(Me.lblDisplayFrom)
        Me.Controls.Add(Me.lblNumberofRows)
        Me.Controls.Add(Me.rdoDispOutputWindow)
        Me.Controls.Add(Me.rdoDispSepOutputWindow)
        Me.Controls.Add(Me.ucrPnlDisplayWindow)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrReceiverView)
        Me.Controls.Add(Me.ucrSelectorForView)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgView"
        Me.Tag = "View Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForView As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverView As ucrReceiverMultiple
    Friend WithEvents lblSelected As Label
    Friend WithEvents rdoDispSepOutputWindow As RadioButton
    Friend WithEvents rdoDispOutputWindow As RadioButton
    Friend WithEvents ucrPnlDisplayWindow As UcrPanel
    Friend WithEvents ucrNudNumberRows As ucrNud
    Friend WithEvents rdoBottom As RadioButton
    Friend WithEvents rdoTop As RadioButton
    Friend WithEvents ucrPnlDisplayFrom As UcrPanel
    Friend WithEvents ucrChkSpecifyRows As ucrCheck
    Friend WithEvents lblDisplayFrom As Label
    Friend WithEvents lblNumberofRows As Label
    Friend WithEvents ucrChkSortColumn As ucrCheck
    Friend WithEvents rdoHTMLOutputWindow As RadioButton
    Friend WithEvents ucrReceiverSortCol As ucrReceiverSingle
    Friend WithEvents rdoViewAll As RadioButton
    Friend WithEvents rdoViewSelectedColumnsRows As RadioButton
    Friend WithEvents ucrPnlViewData As UcrPanel
End Class