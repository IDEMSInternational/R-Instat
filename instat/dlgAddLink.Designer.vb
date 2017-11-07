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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgAddLink))
        Me.cmdSpecifyLink = New System.Windows.Forms.Button()
        Me.lblLinkName = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblKeys = New System.Windows.Forms.Label()
        Me.lvwLinkViewBox = New System.Windows.Forms.ListView()
        Me.ucrInputLinkName = New instat.ucrInputTextBox()
        Me.ucrDataSelectorTo = New instat.ucrDataFrame()
        Me.ucrDataSelectorFrom = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblSelectedKey = New System.Windows.Forms.Label()
        Me.ucrInputSelectedKey = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'cmdSpecifyLink
        '
        resources.ApplyResources(Me.cmdSpecifyLink, "cmdSpecifyLink")
        Me.cmdSpecifyLink.Name = "cmdSpecifyLink"
        Me.cmdSpecifyLink.UseVisualStyleBackColor = True
        '
        'lblLinkName
        '
        resources.ApplyResources(Me.lblLinkName, "lblLinkName")
        Me.lblLinkName.Name = "lblLinkName"
        '
        'lblFrom
        '
        resources.ApplyResources(Me.lblFrom, "lblFrom")
        Me.lblFrom.Name = "lblFrom"
        '
        'lblTo
        '
        resources.ApplyResources(Me.lblTo, "lblTo")
        Me.lblTo.Name = "lblTo"
        '
        'lblKeys
        '
        resources.ApplyResources(Me.lblKeys, "lblKeys")
        Me.lblKeys.Name = "lblKeys"
        '
        'lvwLinkViewBox
        '
        Me.lvwLinkViewBox.FullRowSelect = True
        resources.ApplyResources(Me.lvwLinkViewBox, "lvwLinkViewBox")
        Me.lvwLinkViewBox.Name = "lvwLinkViewBox"
        Me.lvwLinkViewBox.UseCompatibleStateImageBehavior = False
        Me.lvwLinkViewBox.View = System.Windows.Forms.View.Details
        '
        'ucrInputLinkName
        '
        Me.ucrInputLinkName.AddQuotesIfUnrecognised = True
        Me.ucrInputLinkName.IsMultiline = False
        Me.ucrInputLinkName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLinkName, "ucrInputLinkName")
        Me.ucrInputLinkName.Name = "ucrInputLinkName"
        '
        'ucrDataSelectorTo
        '
        Me.ucrDataSelectorTo.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrDataSelectorTo, "ucrDataSelectorTo")
        Me.ucrDataSelectorTo.Name = "ucrDataSelectorTo"
        '
        'ucrDataSelectorFrom
        '
        Me.ucrDataSelectorFrom.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrDataSelectorFrom, "ucrDataSelectorFrom")
        Me.ucrDataSelectorFrom.Name = "ucrDataSelectorFrom"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'lblSelectedKey
        '
        resources.ApplyResources(Me.lblSelectedKey, "lblSelectedKey")
        Me.lblSelectedKey.Name = "lblSelectedKey"
        '
        'ucrInputSelectedKey
        '
        Me.ucrInputSelectedKey.AddQuotesIfUnrecognised = True
        Me.ucrInputSelectedKey.IsMultiline = False
        Me.ucrInputSelectedKey.IsReadOnly = True
        resources.ApplyResources(Me.ucrInputSelectedKey, "ucrInputSelectedKey")
        Me.ucrInputSelectedKey.Name = "ucrInputSelectedKey"
        '
        'dlgAddLink
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputSelectedKey)
        Me.Controls.Add(Me.lblSelectedKey)
        Me.Controls.Add(Me.lblKeys)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lvwLinkViewBox)
        Me.Controls.Add(Me.lblLinkName)
        Me.Controls.Add(Me.ucrInputLinkName)
        Me.Controls.Add(Me.cmdSpecifyLink)
        Me.Controls.Add(Me.ucrDataSelectorTo)
        Me.Controls.Add(Me.ucrDataSelectorFrom)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAddLink"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataSelectorFrom As ucrDataFrame
    Friend WithEvents ucrDataSelectorTo As ucrDataFrame
    Friend WithEvents cmdSpecifyLink As Button
    Friend WithEvents ucrInputLinkName As ucrInputTextBox
    Friend WithEvents lblLinkName As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblKeys As Label
    Friend WithEvents lvwLinkViewBox As ListView
    Friend WithEvents lblSelectedKey As Label
    Friend WithEvents ucrInputSelectedKey As ucrInputTextBox
End Class
