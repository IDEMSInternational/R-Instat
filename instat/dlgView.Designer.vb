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
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.rdoDispSepOutputWindow = New System.Windows.Forms.RadioButton()
        Me.rdoDispOutputWindow = New System.Windows.Forms.RadioButton()
        Me.rdoHTMLOutputWindow = New System.Windows.Forms.RadioButton()
        Me.cmdTableOptions = New System.Windows.Forms.Button()
        Me.ucrChkDisplayFromTop = New instat.ucrCheck()
        Me.ucrSaveData = New instat.ucrSave()
        Me.ucrReceiverSortCol = New instat.ucrReceiverSingle()
        Me.ucrChkSortColumn = New instat.ucrCheck()
        Me.ucrNudNumberRows = New instat.ucrNud()
        Me.ucrPnlDisplayWindow = New instat.UcrPanel()
        Me.ucrReceiverView = New instat.ucrReceiverMultiple()
        Me.ucrSelectorForView = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrViewChkPreview = New instat.ucrCheck()
        Me.ucrChkRowNumbers = New instat.ucrCheck()
        Me.ucrViewNudPreview = New instat.ucrNud()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelected.Location = New System.Drawing.Point(248, 41)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(97, 13)
        Me.lblSelected.TabIndex = 4
        Me.lblSelected.Tag = ""
        Me.lblSelected.Text = "Variable(s) to View:"
        '
        'rdoDispSepOutputWindow
        '
        Me.rdoDispSepOutputWindow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDispSepOutputWindow.Location = New System.Drawing.Point(10, 245)
        Me.rdoDispSepOutputWindow.Name = "rdoDispSepOutputWindow"
        Me.rdoDispSepOutputWindow.Size = New System.Drawing.Size(210, 17)
        Me.rdoDispSepOutputWindow.TabIndex = 6
        Me.rdoDispSepOutputWindow.TabStop = True
        Me.rdoDispSepOutputWindow.Text = "Display in R Viewer Window"
        Me.rdoDispSepOutputWindow.UseVisualStyleBackColor = True
        '
        'rdoDispOutputWindow
        '
        Me.rdoDispOutputWindow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDispOutputWindow.Location = New System.Drawing.Point(10, 222)
        Me.rdoDispOutputWindow.Name = "rdoDispOutputWindow"
        Me.rdoDispOutputWindow.Size = New System.Drawing.Size(210, 17)
        Me.rdoDispOutputWindow.TabIndex = 7
        Me.rdoDispOutputWindow.TabStop = True
        Me.rdoDispOutputWindow.Text = "Display in Output Window"
        Me.rdoDispOutputWindow.UseVisualStyleBackColor = True
        '
        'rdoHTMLOutputWindow
        '
        Me.rdoHTMLOutputWindow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHTMLOutputWindow.Location = New System.Drawing.Point(10, 199)
        Me.rdoHTMLOutputWindow.Name = "rdoHTMLOutputWindow"
        Me.rdoHTMLOutputWindow.Size = New System.Drawing.Size(210, 17)
        Me.rdoHTMLOutputWindow.TabIndex = 8
        Me.rdoHTMLOutputWindow.TabStop = True
        Me.rdoHTMLOutputWindow.Text = "Display HTML in Output Window"
        Me.rdoHTMLOutputWindow.UseVisualStyleBackColor = True
        '
        'cmdTableOptions
        '
        Me.cmdTableOptions.Location = New System.Drawing.Point(248, 199)
        Me.cmdTableOptions.Name = "cmdTableOptions"
        Me.cmdTableOptions.Size = New System.Drawing.Size(141, 23)
        Me.cmdTableOptions.TabIndex = 26
        Me.cmdTableOptions.Text = "Table Options"
        Me.cmdTableOptions.UseVisualStyleBackColor = True
        '
        'ucrChkDisplayFromTop
        '
        Me.ucrChkDisplayFromTop.AutoSize = True
        Me.ucrChkDisplayFromTop.Checked = False
        Me.ucrChkDisplayFromTop.Location = New System.Drawing.Point(248, 222)
        Me.ucrChkDisplayFromTop.Name = "ucrChkDisplayFromTop"
        Me.ucrChkDisplayFromTop.Size = New System.Drawing.Size(130, 23)
        Me.ucrChkDisplayFromTop.TabIndex = 20
        '
        'ucrSaveData
        '
        Me.ucrSaveData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveData.Location = New System.Drawing.Point(10, 270)
        Me.ucrSaveData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveData.Name = "ucrSaveData"
        Me.ucrSaveData.Size = New System.Drawing.Size(308, 27)
        Me.ucrSaveData.TabIndex = 18
        '
        'ucrReceiverSortCol
        '
        Me.ucrReceiverSortCol.AutoSize = True
        Me.ucrReceiverSortCol.frmParent = Me
        Me.ucrReceiverSortCol.Location = New System.Drawing.Point(274, 217)
        Me.ucrReceiverSortCol.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSortCol.Name = "ucrReceiverSortCol"
        Me.ucrReceiverSortCol.Selector = Nothing
        Me.ucrReceiverSortCol.Size = New System.Drawing.Size(119, 20)
        Me.ucrReceiverSortCol.strNcFilePath = ""
        Me.ucrReceiverSortCol.TabIndex = 12
        Me.ucrReceiverSortCol.ucrSelector = Nothing
        '
        'ucrChkSortColumn
        '
        Me.ucrChkSortColumn.AutoSize = True
        Me.ucrChkSortColumn.Checked = False
        Me.ucrChkSortColumn.Location = New System.Drawing.Point(248, 203)
        Me.ucrChkSortColumn.Name = "ucrChkSortColumn"
        Me.ucrChkSortColumn.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSortColumn.TabIndex = 9
        '
        'ucrNudNumberRows
        '
        Me.ucrNudNumberRows.AutoSize = True
        Me.ucrNudNumberRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberRows.Location = New System.Drawing.Point(343, 167)
        Me.ucrNudNumberRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberRows.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.ucrNudNumberRows.Name = "ucrNudNumberRows"
        Me.ucrNudNumberRows.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberRows.TabIndex = 13
        Me.ucrNudNumberRows.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'ucrPnlDisplayWindow
        '
        Me.ucrPnlDisplayWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDisplayWindow.Location = New System.Drawing.Point(10, 192)
        Me.ucrPnlDisplayWindow.Name = "ucrPnlDisplayWindow"
        Me.ucrPnlDisplayWindow.Size = New System.Drawing.Size(221, 83)
        Me.ucrPnlDisplayWindow.TabIndex = 7
        '
        'ucrReceiverView
        '
        Me.ucrReceiverView.AutoSize = True
        Me.ucrReceiverView.frmParent = Me
        Me.ucrReceiverView.Location = New System.Drawing.Point(248, 56)
        Me.ucrReceiverView.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverView.Name = "ucrReceiverView"
        Me.ucrReceiverView.Selector = Nothing
        Me.ucrReceiverView.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverView.strNcFilePath = ""
        Me.ucrReceiverView.TabIndex = 5
        Me.ucrReceiverView.ucrSelector = Nothing
        '
        'ucrSelectorForView
        '
        Me.ucrSelectorForView.AutoSize = True
        Me.ucrSelectorForView.bDropUnusedFilterLevels = False
        Me.ucrSelectorForView.bShowHiddenColumns = False
        Me.ucrSelectorForView.bUseCurrentFilter = True
        Me.ucrSelectorForView.Location = New System.Drawing.Point(10, 6)
        Me.ucrSelectorForView.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForView.Name = "ucrSelectorForView"
        Me.ucrSelectorForView.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForView.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 304)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 17
        '
        'ucrViewChkPreview
        '
        Me.ucrViewChkPreview.AutoSize = True
        Me.ucrViewChkPreview.Checked = False
        Me.ucrViewChkPreview.Location = New System.Drawing.Point(248, 167)
        Me.ucrViewChkPreview.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrViewChkPreview.Name = "ucrViewChkPreview"
        Me.ucrViewChkPreview.Size = New System.Drawing.Size(89, 23)
        Me.ucrViewChkPreview.TabIndex = 32
        '
        'ucrChkRowNumbers
        '
        Me.ucrChkRowNumbers.AutoSize = True
        Me.ucrChkRowNumbers.Checked = False
        Me.ucrChkRowNumbers.Location = New System.Drawing.Point(248, 167)
        Me.ucrChkRowNumbers.Name = "ucrChkRowNumbers"
        Me.ucrChkRowNumbers.Size = New System.Drawing.Size(89, 23)
        Me.ucrChkRowNumbers.TabIndex = 19
        '
        'ucrViewNudPreview
        '
        Me.ucrViewNudPreview.AutoSize = True
        Me.ucrViewNudPreview.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrViewNudPreview.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrViewNudPreview.Location = New System.Drawing.Point(343, 167)
        Me.ucrViewNudPreview.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrViewNudPreview.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrViewNudPreview.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrViewNudPreview.Name = "ucrViewNudPreview"
        Me.ucrViewNudPreview.Size = New System.Drawing.Size(50, 20)
        Me.ucrViewNudPreview.TabIndex = 33
        Me.ucrViewNudPreview.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'dlgView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(416, 357)
        Me.Controls.Add(Me.cmdTableOptions)
        Me.Controls.Add(Me.ucrChkDisplayFromTop)
        Me.Controls.Add(Me.ucrSaveData)
        Me.Controls.Add(Me.ucrReceiverSortCol)
        Me.Controls.Add(Me.ucrChkSortColumn)
        Me.Controls.Add(Me.rdoHTMLOutputWindow)
        Me.Controls.Add(Me.rdoDispOutputWindow)
        Me.Controls.Add(Me.rdoDispSepOutputWindow)
        Me.Controls.Add(Me.ucrPnlDisplayWindow)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrReceiverView)
        Me.Controls.Add(Me.ucrSelectorForView)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrViewChkPreview)
        Me.Controls.Add(Me.ucrChkRowNumbers)
        Me.Controls.Add(Me.ucrViewNudPreview)
        Me.Controls.Add(Me.ucrNudNumberRows)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "View Data"
        Me.Text = "View Data"
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
    Friend WithEvents ucrChkSortColumn As ucrCheck
    Friend WithEvents rdoHTMLOutputWindow As RadioButton
    Friend WithEvents ucrReceiverSortCol As ucrReceiverSingle
    Friend WithEvents ucrSaveData As ucrSave
    Friend WithEvents ucrChkRowNumbers As ucrCheck
    Friend WithEvents ucrChkDisplayFromTop As ucrCheck
    Friend WithEvents cmdTableOptions As Button
    Friend WithEvents ucrViewNudPreview As ucrNud
    Friend WithEvents ucrViewChkPreview As ucrCheck
End Class