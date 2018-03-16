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
Partial Class dlgAddKey
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgAddKey))
        Me.cmdCheckUnique = New System.Windows.Forms.Button()
        Me.lblKeyColumns = New System.Windows.Forms.Label()
        Me.lblKeyName = New System.Windows.Forms.Label()
        Me.ucrInputKeyName = New instat.ucrInputTextBox()
        Me.ucrInputCheckInput = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorKeyColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverKeyColumns = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'cmdCheckUnique
        '
        resources.ApplyResources(Me.cmdCheckUnique, "cmdCheckUnique")
        Me.cmdCheckUnique.Name = "cmdCheckUnique"
        Me.cmdCheckUnique.UseVisualStyleBackColor = True
        '
        'lblKeyColumns
        '
        resources.ApplyResources(Me.lblKeyColumns, "lblKeyColumns")
        Me.lblKeyColumns.Name = "lblKeyColumns"
        '
        'lblKeyName
        '
        resources.ApplyResources(Me.lblKeyName, "lblKeyName")
        Me.lblKeyName.Name = "lblKeyName"
        '
        'ucrInputKeyName
        '
        Me.ucrInputKeyName.AddQuotesIfUnrecognised = True
        Me.ucrInputKeyName.IsMultiline = False
        Me.ucrInputKeyName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputKeyName, "ucrInputKeyName")
        Me.ucrInputKeyName.Name = "ucrInputKeyName"
        '
        'ucrInputCheckInput
        '
        Me.ucrInputCheckInput.AddQuotesIfUnrecognised = True
        Me.ucrInputCheckInput.IsMultiline = False
        Me.ucrInputCheckInput.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputCheckInput, "ucrInputCheckInput")
        Me.ucrInputCheckInput.Name = "ucrInputCheckInput"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorKeyColumns
        '
        Me.ucrSelectorKeyColumns.bShowHiddenColumns = False
        Me.ucrSelectorKeyColumns.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorKeyColumns, "ucrSelectorKeyColumns")
        Me.ucrSelectorKeyColumns.Name = "ucrSelectorKeyColumns"
        '
        'ucrReceiverKeyColumns
        '
        Me.ucrReceiverKeyColumns.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverKeyColumns, "ucrReceiverKeyColumns")
        Me.ucrReceiverKeyColumns.Name = "ucrReceiverKeyColumns"
        Me.ucrReceiverKeyColumns.Selector = Nothing
        Me.ucrReceiverKeyColumns.strNcFilePath = ""
        Me.ucrReceiverKeyColumns.ucrSelector = Nothing
        '
        'dlgAddKey
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputKeyName)
        Me.Controls.Add(Me.lblKeyColumns)
        Me.Controls.Add(Me.ucrInputCheckInput)
        Me.Controls.Add(Me.cmdCheckUnique)
        Me.Controls.Add(Me.lblKeyName)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorKeyColumns)
        Me.Controls.Add(Me.ucrReceiverKeyColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAddKey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverKeyColumns As instat.ucrReceiverMultiple
    Friend WithEvents ucrSelectorKeyColumns As instat.ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As instat.ucrButtons
    Friend WithEvents cmdCheckUnique As System.Windows.Forms.Button
    Friend WithEvents ucrInputCheckInput As instat.ucrInputTextBox
    Friend WithEvents lblKeyColumns As System.Windows.Forms.Label
    Friend WithEvents lblKeyName As Label
    Friend WithEvents ucrInputKeyName As ucrInputTextBox
End Class