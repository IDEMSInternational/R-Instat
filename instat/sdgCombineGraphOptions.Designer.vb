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
Partial Class sdgCombineGraphOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgCombineGraphOptions))
        Me.tbcLayout = New System.Windows.Forms.TabControl()
        Me.tbpLayout = New System.Windows.Forms.TabPage()
        Me.ucrChkSpecifyOrder = New instat.ucrCheck()
        Me.ucrNudColumns = New instat.ucrNud()
        Me.ucrNudRows = New instat.ucrNud()
        Me.txtLayoutMessage = New System.Windows.Forms.TextBox()
        Me.grdLayout = New unvell.ReoGrid.ReoGridControl()
        Me.lblSelectedgrpahs = New System.Windows.Forms.Label()
        Me.lstGraphs = New System.Windows.Forms.ListBox()
        Me.lblNumberofColumns = New System.Windows.Forms.Label()
        Me.lblNumberofRows = New System.Windows.Forms.Label()
        Me.tbpLabels = New System.Windows.Forms.TabPage()
        Me.ucrInputLeft = New instat.ucrInputTextBox()
        Me.ucrInputRight = New instat.ucrInputTextBox()
        Me.ucrInputBottom = New instat.ucrInputTextBox()
        Me.ucrInputTop = New instat.ucrInputTextBox()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.LblRight = New System.Windows.Forms.Label()
        Me.lblBottom = New System.Windows.Forms.Label()
        Me.lblTop = New System.Windows.Forms.Label()
        Me.ucrsdgLayoutBase = New instat.ucrButtonsSubdialogue()
        Me.tbcLayout.SuspendLayout()
        Me.tbpLayout.SuspendLayout()
        Me.tbpLabels.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcLayout
        '
        Me.tbcLayout.Controls.Add(Me.tbpLayout)
        Me.tbcLayout.Controls.Add(Me.tbpLabels)
        resources.ApplyResources(Me.tbcLayout, "tbcLayout")
        Me.tbcLayout.Name = "tbcLayout"
        Me.tbcLayout.SelectedIndex = 0
        '
        'tbpLayout
        '
        Me.tbpLayout.Controls.Add(Me.ucrChkSpecifyOrder)
        Me.tbpLayout.Controls.Add(Me.ucrNudColumns)
        Me.tbpLayout.Controls.Add(Me.ucrNudRows)
        Me.tbpLayout.Controls.Add(Me.txtLayoutMessage)
        Me.tbpLayout.Controls.Add(Me.grdLayout)
        Me.tbpLayout.Controls.Add(Me.lblSelectedgrpahs)
        Me.tbpLayout.Controls.Add(Me.lstGraphs)
        Me.tbpLayout.Controls.Add(Me.lblNumberofColumns)
        Me.tbpLayout.Controls.Add(Me.lblNumberofRows)
        resources.ApplyResources(Me.tbpLayout, "tbpLayout")
        Me.tbpLayout.Name = "tbpLayout"
        Me.tbpLayout.UseVisualStyleBackColor = True
        '
        'ucrChkSpecifyOrder
        '
        Me.ucrChkSpecifyOrder.Checked = False
        resources.ApplyResources(Me.ucrChkSpecifyOrder, "ucrChkSpecifyOrder")
        Me.ucrChkSpecifyOrder.Name = "ucrChkSpecifyOrder"
        '
        'ucrNudColumns
        '
        Me.ucrNudColumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudColumns, "ucrNudColumns")
        Me.ucrNudColumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumns.Name = "ucrNudColumns"
        Me.ucrNudColumns.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'ucrNudRows
        '
        Me.ucrNudRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudRows, "ucrNudRows")
        Me.ucrNudRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRows.Name = "ucrNudRows"
        Me.ucrNudRows.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'txtLayoutMessage
        '
        resources.ApplyResources(Me.txtLayoutMessage, "txtLayoutMessage")
        Me.txtLayoutMessage.Name = "txtLayoutMessage"
        Me.txtLayoutMessage.ReadOnly = True
        '
        'grdLayout
        '
        Me.grdLayout.BackColor = System.Drawing.Color.White
        Me.grdLayout.ColumnHeaderContextMenuStrip = Nothing
        Me.grdLayout.LeadHeaderContextMenuStrip = Nothing
        resources.ApplyResources(Me.grdLayout, "grdLayout")
        Me.grdLayout.Name = "grdLayout"
        Me.grdLayout.RowHeaderContextMenuStrip = Nothing
        Me.grdLayout.Script = Nothing
        Me.grdLayout.SheetTabContextMenuStrip = Nothing
        Me.grdLayout.SheetTabNewButtonVisible = True
        Me.grdLayout.SheetTabVisible = True
        Me.grdLayout.SheetTabWidth = 60
        Me.grdLayout.ShowScrollEndSpacing = True
        '
        'lblSelectedgrpahs
        '
        resources.ApplyResources(Me.lblSelectedgrpahs, "lblSelectedgrpahs")
        Me.lblSelectedgrpahs.Name = "lblSelectedgrpahs"
        '
        'lstGraphs
        '
        Me.lstGraphs.FormattingEnabled = True
        resources.ApplyResources(Me.lstGraphs, "lstGraphs")
        Me.lstGraphs.Name = "lstGraphs"
        '
        'lblNumberofColumns
        '
        resources.ApplyResources(Me.lblNumberofColumns, "lblNumberofColumns")
        Me.lblNumberofColumns.Name = "lblNumberofColumns"
        '
        'lblNumberofRows
        '
        resources.ApplyResources(Me.lblNumberofRows, "lblNumberofRows")
        Me.lblNumberofRows.Name = "lblNumberofRows"
        '
        'tbpLabels
        '
        Me.tbpLabels.Controls.Add(Me.ucrInputLeft)
        Me.tbpLabels.Controls.Add(Me.ucrInputRight)
        Me.tbpLabels.Controls.Add(Me.ucrInputBottom)
        Me.tbpLabels.Controls.Add(Me.ucrInputTop)
        Me.tbpLabels.Controls.Add(Me.lblLeft)
        Me.tbpLabels.Controls.Add(Me.LblRight)
        Me.tbpLabels.Controls.Add(Me.lblBottom)
        Me.tbpLabels.Controls.Add(Me.lblTop)
        resources.ApplyResources(Me.tbpLabels, "tbpLabels")
        Me.tbpLabels.Name = "tbpLabels"
        Me.tbpLabels.UseVisualStyleBackColor = True
        '
        'ucrInputLeft
        '
        Me.ucrInputLeft.AddQuotesIfUnrecognised = True
        Me.ucrInputLeft.IsMultiline = False
        Me.ucrInputLeft.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLeft, "ucrInputLeft")
        Me.ucrInputLeft.Name = "ucrInputLeft"
        '
        'ucrInputRight
        '
        Me.ucrInputRight.AddQuotesIfUnrecognised = True
        Me.ucrInputRight.IsMultiline = False
        Me.ucrInputRight.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputRight, "ucrInputRight")
        Me.ucrInputRight.Name = "ucrInputRight"
        '
        'ucrInputBottom
        '
        Me.ucrInputBottom.AddQuotesIfUnrecognised = True
        Me.ucrInputBottom.IsMultiline = False
        Me.ucrInputBottom.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputBottom, "ucrInputBottom")
        Me.ucrInputBottom.Name = "ucrInputBottom"
        '
        'ucrInputTop
        '
        Me.ucrInputTop.AddQuotesIfUnrecognised = True
        Me.ucrInputTop.IsMultiline = False
        Me.ucrInputTop.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTop, "ucrInputTop")
        Me.ucrInputTop.Name = "ucrInputTop"
        '
        'lblLeft
        '
        resources.ApplyResources(Me.lblLeft, "lblLeft")
        Me.lblLeft.Name = "lblLeft"
        '
        'LblRight
        '
        resources.ApplyResources(Me.LblRight, "LblRight")
        Me.LblRight.Name = "LblRight"
        '
        'lblBottom
        '
        resources.ApplyResources(Me.lblBottom, "lblBottom")
        Me.lblBottom.Name = "lblBottom"
        '
        'lblTop
        '
        resources.ApplyResources(Me.lblTop, "lblTop")
        Me.lblTop.Name = "lblTop"
        '
        'ucrsdgLayoutBase
        '
        resources.ApplyResources(Me.ucrsdgLayoutBase, "ucrsdgLayoutBase")
        Me.ucrsdgLayoutBase.Name = "ucrsdgLayoutBase"
        '
        'sdgCombineGraphOptions
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrsdgLayoutBase)
        Me.Controls.Add(Me.tbcLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCombineGraphOptions"
        Me.tbcLayout.ResumeLayout(False)
        Me.tbpLayout.ResumeLayout(False)
        Me.tbpLayout.PerformLayout()
        Me.tbpLabels.ResumeLayout(False)
        Me.tbpLabels.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcLayout As TabControl
    Friend WithEvents tbpLayout As TabPage
    Friend WithEvents lblNumberofColumns As Label
    Friend WithEvents lblNumberofRows As Label
    Friend WithEvents tbpLabels As TabPage
    Friend WithEvents ucrInputLeft As ucrInputTextBox
    Friend WithEvents ucrInputRight As ucrInputTextBox
    Friend WithEvents ucrInputBottom As ucrInputTextBox
    Friend WithEvents ucrInputTop As ucrInputTextBox
    Friend WithEvents lblLeft As Label
    Friend WithEvents LblRight As Label
    Friend WithEvents lblBottom As Label
    Friend WithEvents lblTop As Label
    Friend WithEvents ucrsdgLayoutBase As ucrButtonsSubdialogue
    Friend WithEvents lstGraphs As ListBox
    Friend WithEvents lblSelectedgrpahs As Label
    Friend WithEvents grdLayout As unvell.ReoGrid.ReoGridControl
    Friend WithEvents txtLayoutMessage As TextBox
    Friend WithEvents ucrNudColumns As ucrNud
    Friend WithEvents ucrNudRows As ucrNud
    Friend WithEvents ucrChkSpecifyOrder As ucrCheck
End Class