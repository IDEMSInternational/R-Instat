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
Partial Class dlgAddLink
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
        Me.cmdSpecifyLink = New System.Windows.Forms.Button()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblKeys = New System.Windows.Forms.Label()
        Me.lvwLinkViewBox = New System.Windows.Forms.ListView()
        Me.ucrDataSelectorTo = New instat.ucrDataFrame()
        Me.ucrDataSelectorFrom = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblSelectedKey = New System.Windows.Forms.Label()
        Me.ucrInputSelectedKey = New instat.ucrInputTextBox()
        Me.ucrSaveLink = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'cmdSpecifyLink
        '
        Me.cmdSpecifyLink.Location = New System.Drawing.Point(287, 171)
        Me.cmdSpecifyLink.Name = "cmdSpecifyLink"
        Me.cmdSpecifyLink.Size = New System.Drawing.Size(121, 23)
        Me.cmdSpecifyLink.TabIndex = 6
        Me.cmdSpecifyLink.Text = "Specify Link"
        Me.cmdSpecifyLink.UseVisualStyleBackColor = True
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(10, 11)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(10, 77)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Text = "To:"
        '
        'lblKeys
        '
        Me.lblKeys.AutoSize = True
        Me.lblKeys.Location = New System.Drawing.Point(168, 30)
        Me.lblKeys.Name = "lblKeys"
        Me.lblKeys.Size = New System.Drawing.Size(33, 13)
        Me.lblKeys.TabIndex = 4
        Me.lblKeys.Text = "Keys:"
        '
        'lvwLinkViewBox
        '
        Me.lvwLinkViewBox.FullRowSelect = True
        Me.lvwLinkViewBox.HideSelection = False
        Me.lvwLinkViewBox.Location = New System.Drawing.Point(168, 45)
        Me.lvwLinkViewBox.Name = "lvwLinkViewBox"
        Me.lvwLinkViewBox.Size = New System.Drawing.Size(240, 123)
        Me.lvwLinkViewBox.TabIndex = 5
        Me.lvwLinkViewBox.UseCompatibleStateImageBehavior = False
        Me.lvwLinkViewBox.View = System.Windows.Forms.View.Details
        '
        'ucrDataSelectorTo
        '
        Me.ucrDataSelectorTo.AutoSize = True
        Me.ucrDataSelectorTo.bDropUnusedFilterLevels = False
        Me.ucrDataSelectorTo.bUseCurrentFilter = True
        Me.ucrDataSelectorTo.Location = New System.Drawing.Point(15, 93)
        Me.ucrDataSelectorTo.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataSelectorTo.Name = "ucrDataSelectorTo"
        Me.ucrDataSelectorTo.Size = New System.Drawing.Size(151, 50)
        Me.ucrDataSelectorTo.TabIndex = 3
        '
        'ucrDataSelectorFrom
        '
        Me.ucrDataSelectorFrom.AutoSize = True
        Me.ucrDataSelectorFrom.bDropUnusedFilterLevels = False
        Me.ucrDataSelectorFrom.bUseCurrentFilter = True
        Me.ucrDataSelectorFrom.Location = New System.Drawing.Point(15, 27)
        Me.ucrDataSelectorFrom.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataSelectorFrom.Name = "ucrDataSelectorFrom"
        Me.ucrDataSelectorFrom.Size = New System.Drawing.Size(151, 50)
        Me.ucrDataSelectorFrom.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 262)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 11
        '
        'lblSelectedKey
        '
        Me.lblSelectedKey.AutoSize = True
        Me.lblSelectedKey.Location = New System.Drawing.Point(10, 211)
        Me.lblSelectedKey.Name = "lblSelectedKey"
        Me.lblSelectedKey.Size = New System.Drawing.Size(73, 13)
        Me.lblSelectedKey.TabIndex = 7
        Me.lblSelectedKey.Text = "Selected Key:"
        '
        'ucrInputSelectedKey
        '
        Me.ucrInputSelectedKey.AddQuotesIfUnrecognised = True
        Me.ucrInputSelectedKey.AutoSize = True
        Me.ucrInputSelectedKey.IsMultiline = False
        Me.ucrInputSelectedKey.IsReadOnly = True
        Me.ucrInputSelectedKey.Location = New System.Drawing.Point(92, 208)
        Me.ucrInputSelectedKey.Name = "ucrInputSelectedKey"
        Me.ucrInputSelectedKey.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSelectedKey.TabIndex = 8
        '
        'ucrSaveLink
        '
        Me.ucrSaveLink.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveLink.Location = New System.Drawing.Point(10, 232)
        Me.ucrSaveLink.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveLink.Name = "ucrSaveLink"
        Me.ucrSaveLink.Size = New System.Drawing.Size(267, 26)
        Me.ucrSaveLink.TabIndex = 12
        '
        'dlgAddLink
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(416, 320)
        Me.Controls.Add(Me.ucrSaveLink)
        Me.Controls.Add(Me.ucrInputSelectedKey)
        Me.Controls.Add(Me.lblSelectedKey)
        Me.Controls.Add(Me.lblKeys)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lvwLinkViewBox)
        Me.Controls.Add(Me.cmdSpecifyLink)
        Me.Controls.Add(Me.ucrDataSelectorTo)
        Me.Controls.Add(Me.ucrDataSelectorFrom)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAddLink"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Link"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataSelectorFrom As ucrDataFrame
    Friend WithEvents ucrDataSelectorTo As ucrDataFrame
    Friend WithEvents cmdSpecifyLink As Button
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblKeys As Label
    Friend WithEvents lvwLinkViewBox As ListView
    Friend WithEvents lblSelectedKey As Label
    Friend WithEvents ucrInputSelectedKey As ucrInputTextBox
    Friend WithEvents ucrSaveLink As ucrSave
End Class
