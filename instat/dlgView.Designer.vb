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
        Me.lblDisplayFrom = New System.Windows.Forms.Label()
        Me.lblNumberofRows = New System.Windows.Forms.Label()
        Me.rdoHTMLOutputWindow = New System.Windows.Forms.RadioButton()
        Me.ucrSaveData = New instat.ucrSave()
        Me.ucrReceiverSortCol = New instat.ucrReceiverSingle()
        Me.ucrChkSortColumn = New instat.ucrCheck()
        Me.ucrNudNumberRows = New instat.ucrNud()
        Me.ucrChkSpecifyRows = New instat.ucrCheck()
        Me.ucrPnlDisplayWindow = New instat.UcrPanel()
        Me.ucrReceiverView = New instat.ucrReceiverMultiple()
        Me.ucrSelectorForView = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkDisplayPosition = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelected.Location = New System.Drawing.Point(248, 40)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(97, 13)
        Me.lblSelected.TabIndex = 4
        Me.lblSelected.Tag = ""
        Me.lblSelected.Text = "Variable(s) to View:"
        '
        'rdoDispSepOutputWindow
        '
        Me.rdoDispSepOutputWindow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDispSepOutputWindow.Location = New System.Drawing.Point(10, 240)
        Me.rdoDispSepOutputWindow.Name = "rdoDispSepOutputWindow"
        Me.rdoDispSepOutputWindow.Size = New System.Drawing.Size(210, 17)
        Me.rdoDispSepOutputWindow.TabIndex = 6
        Me.rdoDispSepOutputWindow.TabStop = True
        Me.rdoDispSepOutputWindow.Text = "Display in R Viewer"
        Me.rdoDispSepOutputWindow.UseVisualStyleBackColor = True
        '
        'rdoDispOutputWindow
        '
        Me.rdoDispOutputWindow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDispOutputWindow.Location = New System.Drawing.Point(10, 217)
        Me.rdoDispOutputWindow.Name = "rdoDispOutputWindow"
        Me.rdoDispOutputWindow.Size = New System.Drawing.Size(210, 17)
        Me.rdoDispOutputWindow.TabIndex = 7
        Me.rdoDispOutputWindow.TabStop = True
        Me.rdoDispOutputWindow.Text = "Display in Output Window"
        Me.rdoDispOutputWindow.UseVisualStyleBackColor = True
        '
        'lblDisplayFrom
        '
        Me.lblDisplayFrom.AutoSize = True
        Me.lblDisplayFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDisplayFrom.Location = New System.Drawing.Point(248, 235)
        Me.lblDisplayFrom.Name = "lblDisplayFrom"
        Me.lblDisplayFrom.Size = New System.Drawing.Size(70, 13)
        Me.lblDisplayFrom.TabIndex = 14
        Me.lblDisplayFrom.Tag = ""
        Me.lblDisplayFrom.Text = "Display From:"
        '
        'lblNumberofRows
        '
        Me.lblNumberofRows.AutoSize = True
        Me.lblNumberofRows.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumberofRows.Location = New System.Drawing.Point(248, 170)
        Me.lblNumberofRows.Name = "lblNumberofRows"
        Me.lblNumberofRows.Size = New System.Drawing.Size(89, 13)
        Me.lblNumberofRows.TabIndex = 10
        Me.lblNumberofRows.Tag = "Number_of_rows"
        Me.lblNumberofRows.Text = "Number of Rows:"
        '
        'rdoHTMLOutputWindow
        '
        Me.rdoHTMLOutputWindow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHTMLOutputWindow.Location = New System.Drawing.Point(10, 194)
        Me.rdoHTMLOutputWindow.Name = "rdoHTMLOutputWindow"
        Me.rdoHTMLOutputWindow.Size = New System.Drawing.Size(210, 17)
        Me.rdoHTMLOutputWindow.TabIndex = 8
        Me.rdoHTMLOutputWindow.TabStop = True
        Me.rdoHTMLOutputWindow.Text = "Display HTML in Output Window"
        Me.rdoHTMLOutputWindow.UseVisualStyleBackColor = True
        '
        'ucrSaveData
        '
        Me.ucrSaveData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveData.Location = New System.Drawing.Point(10, 265)
        Me.ucrSaveData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveData.Name = "ucrSaveData"
        Me.ucrSaveData.Size = New System.Drawing.Size(308, 27)
        Me.ucrSaveData.TabIndex = 18
        '
        'ucrReceiverSortCol
        '
        Me.ucrReceiverSortCol.AutoSize = True
        Me.ucrReceiverSortCol.frmParent = Me
        Me.ucrReceiverSortCol.Location = New System.Drawing.Point(274, 212)
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
        Me.ucrChkSortColumn.Location = New System.Drawing.Point(248, 191)
        Me.ucrChkSortColumn.Name = "ucrChkSortColumn"
        Me.ucrChkSortColumn.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSortColumn.TabIndex = 9
        '
        'ucrNudNumberRows
        '
        Me.ucrNudNumberRows.AutoSize = True
        Me.ucrNudNumberRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberRows.Location = New System.Drawing.Point(341, 168)
        Me.ucrNudNumberRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberRows.Name = "ucrNudNumberRows"
        Me.ucrNudNumberRows.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberRows.TabIndex = 13
        Me.ucrNudNumberRows.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'ucrChkSpecifyRows
        '
        Me.ucrChkSpecifyRows.AutoSize = True
        Me.ucrChkSpecifyRows.Checked = False
        Me.ucrChkSpecifyRows.Location = New System.Drawing.Point(248, 235)
        Me.ucrChkSpecifyRows.Name = "ucrChkSpecifyRows"
        Me.ucrChkSpecifyRows.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSpecifyRows.TabIndex = 5
        '
        'ucrPnlDisplayWindow
        '
        Me.ucrPnlDisplayWindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDisplayWindow.Location = New System.Drawing.Point(10, 191)
        Me.ucrPnlDisplayWindow.Name = "ucrPnlDisplayWindow"
        Me.ucrPnlDisplayWindow.Size = New System.Drawing.Size(221, 83)
        Me.ucrPnlDisplayWindow.TabIndex = 7
        '
        'ucrReceiverView
        '
        Me.ucrReceiverView.AutoSize = True
        Me.ucrReceiverView.frmParent = Me
        Me.ucrReceiverView.Location = New System.Drawing.Point(248, 55)
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
        Me.ucrSelectorForView.Location = New System.Drawing.Point(10, 5)
        Me.ucrSelectorForView.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForView.Name = "ucrSelectorForView"
        Me.ucrSelectorForView.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForView.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 299)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 17
        '
        'ucrChkDisplayPosition
        '
        Me.ucrChkDisplayPosition.AutoSize = True
        Me.ucrChkDisplayPosition.Checked = True
        Me.ucrChkDisplayPosition.Location = New System.Drawing.Point(273, 261)
        Me.ucrChkDisplayPosition.Name = "ucrChkDisplayPosition"
        Me.ucrChkDisplayPosition.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkDisplayPosition.TabIndex = 19
        '
        'dlgView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(416, 393)
        Me.Controls.Add(Me.ucrChkDisplayPosition)
        Me.Controls.Add(Me.ucrSaveData)
        Me.Controls.Add(Me.ucrReceiverSortCol)
        Me.Controls.Add(Me.ucrChkSortColumn)
        Me.Controls.Add(Me.rdoHTMLOutputWindow)
        Me.Controls.Add(Me.ucrNudNumberRows)
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
    Friend WithEvents ucrChkSpecifyRows As ucrCheck
    Friend WithEvents lblDisplayFrom As Label
    Friend WithEvents lblNumberofRows As Label
    Friend WithEvents ucrChkSortColumn As ucrCheck
    Friend WithEvents rdoHTMLOutputWindow As RadioButton
    Friend WithEvents ucrReceiverSortCol As ucrReceiverSingle
    Friend WithEvents ucrSaveData As ucrSave
    Friend WithEvents ucrChkDisplayPosition As ucrCheck
End Class