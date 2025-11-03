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
        Me.lblTmax = New System.Windows.Forms.Label()
        Me.lblTmin = New System.Windows.Forms.Label()
        Me.lblPrec = New System.Windows.Forms.Label()
        Me.cmdIndices = New System.Windows.Forms.Button()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.rdoAnnual = New System.Windows.Forms.RadioButton()
        Me.rdoMonthly = New System.Windows.Forms.RadioButton()
        Me.lblSelectedIndices = New System.Windows.Forms.Label()
        Me.lblTotalIndices = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblOutof = New System.Windows.Forms.Label()
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
        Me.rdoStation = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblTmax
        '
        Me.lblTmax.AutoSize = True
        Me.lblTmax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTmax.Location = New System.Drawing.Point(378, 396)
        Me.lblTmax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTmax.Name = "lblTmax"
        Me.lblTmax.Size = New System.Drawing.Size(175, 20)
        Me.lblTmax.TabIndex = 12
        Me.lblTmax.Tag = "Maximum Temperature:"
        Me.lblTmax.Text = "Maximum Temperature:"
        '
        'lblTmin
        '
        Me.lblTmin.AutoSize = True
        Me.lblTmin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTmin.Location = New System.Drawing.Point(378, 454)
        Me.lblTmin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTmin.Name = "lblTmin"
        Me.lblTmin.Size = New System.Drawing.Size(171, 20)
        Me.lblTmin.TabIndex = 14
        Me.lblTmin.Tag = "Minimum Temperature:"
        Me.lblTmin.Text = "Minimum Temperature:"
        '
        'lblPrec
        '
        Me.lblPrec.AutoSize = True
        Me.lblPrec.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPrec.Location = New System.Drawing.Point(378, 334)
        Me.lblPrec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrec.Name = "lblPrec"
        Me.lblPrec.Size = New System.Drawing.Size(100, 20)
        Me.lblPrec.TabIndex = 10
        Me.lblPrec.Tag = ""
        Me.lblPrec.Text = "Precipitation:"
        '
        'cmdIndices
        '
        Me.cmdIndices.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIndices.Location = New System.Drawing.Point(496, 534)
        Me.cmdIndices.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdIndices.Name = "cmdIndices"
        Me.cmdIndices.Size = New System.Drawing.Size(111, 34)
        Me.cmdIndices.TabIndex = 19
        Me.cmdIndices.Tag = "Indices..."
        Me.cmdIndices.Text = "Indices..."
        Me.cmdIndices.UseVisualStyleBackColor = True
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStation.Location = New System.Drawing.Point(378, 94)
        Me.lblStation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(64, 20)
        Me.lblStation.TabIndex = 4
        Me.lblStation.Tag = ""
        Me.lblStation.Text = "Station:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonth.Location = New System.Drawing.Point(378, 270)
        Me.lblMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(58, 20)
        Me.lblMonth.TabIndex = 8
        Me.lblMonth.Tag = "Month:"
        Me.lblMonth.Text = "Month:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYear.Location = New System.Drawing.Point(378, 213)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(47, 20)
        Me.lblYear.TabIndex = 6
        Me.lblYear.Tag = "Year:"
        Me.lblYear.Text = "Year:"
        '
        'rdoAnnual
        '
        Me.rdoAnnual.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoAnnual.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAnnual.FlatAppearance.BorderSize = 2
        Me.rdoAnnual.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoAnnual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoAnnual.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAnnual.Location = New System.Drawing.Point(96, 20)
        Me.rdoAnnual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoAnnual.Name = "rdoAnnual"
        Me.rdoAnnual.Size = New System.Drawing.Size(136, 40)
        Me.rdoAnnual.TabIndex = 1
        Me.rdoAnnual.TabStop = True
        Me.rdoAnnual.Text = "Annual"
        Me.rdoAnnual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoAnnual.UseVisualStyleBackColor = True
        '
        'rdoMonthly
        '
        Me.rdoMonthly.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMonthly.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonthly.FlatAppearance.BorderSize = 2
        Me.rdoMonthly.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMonthly.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMonthly.Location = New System.Drawing.Point(230, 20)
        Me.rdoMonthly.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoMonthly.Name = "rdoMonthly"
        Me.rdoMonthly.Size = New System.Drawing.Size(136, 40)
        Me.rdoMonthly.TabIndex = 2
        Me.rdoMonthly.TabStop = True
        Me.rdoMonthly.Text = "Monthly"
        Me.rdoMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMonthly.UseVisualStyleBackColor = True
        '
        'lblSelectedIndices
        '
        Me.lblSelectedIndices.AutoSize = True
        Me.lblSelectedIndices.ForeColor = System.Drawing.Color.Green
        Me.lblSelectedIndices.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectedIndices.Location = New System.Drawing.Point(285, 540)
        Me.lblSelectedIndices.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectedIndices.Name = "lblSelectedIndices"
        Me.lblSelectedIndices.Size = New System.Drawing.Size(0, 20)
        Me.lblSelectedIndices.TabIndex = 16
        Me.lblSelectedIndices.Tag = ""
        '
        'lblTotalIndices
        '
        Me.lblTotalIndices.AutoSize = True
        Me.lblTotalIndices.ForeColor = System.Drawing.Color.Green
        Me.lblTotalIndices.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTotalIndices.Location = New System.Drawing.Point(446, 540)
        Me.lblTotalIndices.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalIndices.Name = "lblTotalIndices"
        Me.lblTotalIndices.Size = New System.Drawing.Size(0, 20)
        Me.lblTotalIndices.TabIndex = 18
        Me.lblTotalIndices.Tag = ""
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(378, 154)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 20)
        Me.lblDate.TabIndex = 21
        Me.lblDate.Tag = ""
        Me.lblDate.Text = "Date:"
        '
        'lblOutof
        '
        Me.lblOutof.AutoSize = True
        Me.lblOutof.Location = New System.Drawing.Point(218, 540)
        Me.lblOutof.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutof.Name = "lblOutof"
        Me.lblOutof.Size = New System.Drawing.Size(217, 20)
        Me.lblOutof.TabIndex = 23
        Me.lblOutof.Text = "Indices             selected out of"
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(378, 177)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 22
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrPnlAnnualMonthly
        '
        Me.ucrPnlAnnualMonthly.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlAnnualMonthly.Location = New System.Drawing.Point(77, 12)
        Me.ucrPnlAnnualMonthly.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrPnlAnnualMonthly.Name = "ucrPnlAnnualMonthly"
        Me.ucrPnlAnnualMonthly.Size = New System.Drawing.Size(454, 54)
        Me.ucrPnlAnnualMonthly.TabIndex = 0
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(378, 236)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 7
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.AutoSize = True
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(378, 296)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 9
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrChkSave
        '
        Me.ucrChkSave.AutoSize = True
        Me.ucrChkSave.Checked = False
        Me.ucrChkSave.Location = New System.Drawing.Point(15, 423)
        Me.ucrChkSave.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkSave.Name = "ucrChkSave"
        Me.ucrChkSave.Size = New System.Drawing.Size(358, 34)
        Me.ucrChkSave.TabIndex = 16
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(378, 117)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 5
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverPrec
        '
        Me.ucrReceiverPrec.AutoSize = True
        Me.ucrReceiverPrec.frmParent = Me
        Me.ucrReceiverPrec.Location = New System.Drawing.Point(378, 357)
        Me.ucrReceiverPrec.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPrec.Name = "ucrReceiverPrec"
        Me.ucrReceiverPrec.Selector = Nothing
        Me.ucrReceiverPrec.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverPrec.strNcFilePath = ""
        Me.ucrReceiverPrec.TabIndex = 11
        Me.ucrReceiverPrec.ucrSelector = Nothing
        '
        'ucrReceiverTmin
        '
        Me.ucrReceiverTmin.AutoSize = True
        Me.ucrReceiverTmin.frmParent = Me
        Me.ucrReceiverTmin.Location = New System.Drawing.Point(378, 480)
        Me.ucrReceiverTmin.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTmin.Name = "ucrReceiverTmin"
        Me.ucrReceiverTmin.Selector = Nothing
        Me.ucrReceiverTmin.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverTmin.strNcFilePath = ""
        Me.ucrReceiverTmin.TabIndex = 15
        Me.ucrReceiverTmin.ucrSelector = Nothing
        '
        'ucrReceiverTmax
        '
        Me.ucrReceiverTmax.AutoSize = True
        Me.ucrReceiverTmax.frmParent = Me
        Me.ucrReceiverTmax.Location = New System.Drawing.Point(378, 420)
        Me.ucrReceiverTmax.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTmax.Name = "ucrReceiverTmax"
        Me.ucrReceiverTmax.Selector = Nothing
        Me.ucrReceiverTmax.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverTmax.strNcFilePath = ""
        Me.ucrReceiverTmax.TabIndex = 13
        Me.ucrReceiverTmax.ucrSelector = Nothing
        '
        'ucrSelectorClimdex
        '
        Me.ucrSelectorClimdex.AutoSize = True
        Me.ucrSelectorClimdex.bDropUnusedFilterLevels = False
        Me.ucrSelectorClimdex.bShowHiddenColumns = False
        Me.ucrSelectorClimdex.bUseCurrentFilter = True
        Me.ucrSelectorClimdex.Location = New System.Drawing.Point(15, 96)
        Me.ucrSelectorClimdex.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClimdex.Name = "ucrSelectorClimdex"
        Me.ucrSelectorClimdex.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorClimdex.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 574)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 20
        '
        'rdoStation
        '
        Me.rdoStation.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStation.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStation.FlatAppearance.BorderSize = 2
        Me.rdoStation.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStation.Location = New System.Drawing.Point(364, 20)
        Me.rdoStation.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoStation.Name = "rdoStation"
        Me.rdoStation.Size = New System.Drawing.Size(136, 40)
        Me.rdoStation.TabIndex = 24
        Me.rdoStation.TabStop = True
        Me.rdoStation.Text = "Station"
        Me.rdoStation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStation.UseVisualStyleBackColor = True
        '
        'dlgClimdexIndices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(626, 660)
        Me.Controls.Add(Me.rdoStation)
        Me.Controls.Add(Me.lblSelectedIndices)
        Me.Controls.Add(Me.lblOutof)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.lblTotalIndices)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimdexIndices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Climdex Indices"
        Me.Text = "Climdex Indices"
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
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblOutof As Label
    Friend WithEvents rdoStation As RadioButton
End Class