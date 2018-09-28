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
Partial Class dlgFromLibrary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgFromLibrary))
        Me.cmdLibraryCollection = New System.Windows.Forms.Button()
        Me.lstCollection = New System.Windows.Forms.ListView()
        Me.clmDatasets = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblFromPackage = New System.Windows.Forms.Label()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.rdoDefaultDatasets = New System.Windows.Forms.RadioButton()
        Me.rdoInstatCollection = New System.Windows.Forms.RadioButton()
        Me.ucrInputPackages = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrNewDataFrameName = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'cmdLibraryCollection
        '
        resources.ApplyResources(Me.cmdLibraryCollection, "cmdLibraryCollection")
        Me.cmdLibraryCollection.Name = "cmdLibraryCollection"
        Me.cmdLibraryCollection.UseVisualStyleBackColor = True
        '
        'lstCollection
        '
        Me.lstCollection.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmDatasets, Me.clmDesc})
        Me.lstCollection.FullRowSelect = True
        resources.ApplyResources(Me.lstCollection, "lstCollection")
        Me.lstCollection.MultiSelect = False
        Me.lstCollection.Name = "lstCollection"
        Me.lstCollection.ShowGroups = False
        Me.lstCollection.ShowItemToolTips = True
        Me.lstCollection.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstCollection.UseCompatibleStateImageBehavior = False
        Me.lstCollection.View = System.Windows.Forms.View.Details
        '
        'clmDatasets
        '
        resources.ApplyResources(Me.clmDatasets, "clmDatasets")
        '
        'clmDesc
        '
        resources.ApplyResources(Me.clmDesc, "clmDesc")
        '
        'lblFromPackage
        '
        resources.ApplyResources(Me.lblFromPackage, "lblFromPackage")
        Me.lblFromPackage.Name = "lblFromPackage"
        '
        'cmdHelp
        '
        resources.ApplyResources(Me.cmdHelp, "cmdHelp")
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'rdoDefaultDatasets
        '
        resources.ApplyResources(Me.rdoDefaultDatasets, "rdoDefaultDatasets")
        Me.rdoDefaultDatasets.BackColor = System.Drawing.SystemColors.Control
        Me.rdoDefaultDatasets.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDefaultDatasets.FlatAppearance.BorderSize = 2
        Me.rdoDefaultDatasets.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDefaultDatasets.Name = "rdoDefaultDatasets"
        Me.rdoDefaultDatasets.TabStop = True
        Me.rdoDefaultDatasets.Tag = ""
        Me.rdoDefaultDatasets.UseVisualStyleBackColor = False
        '
        'rdoInstatCollection
        '
        resources.ApplyResources(Me.rdoInstatCollection, "rdoInstatCollection")
        Me.rdoInstatCollection.BackColor = System.Drawing.SystemColors.Control
        Me.rdoInstatCollection.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInstatCollection.FlatAppearance.BorderSize = 2
        Me.rdoInstatCollection.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoInstatCollection.Name = "rdoInstatCollection"
        Me.rdoInstatCollection.TabStop = True
        Me.rdoInstatCollection.Tag = ""
        Me.rdoInstatCollection.UseVisualStyleBackColor = False
        '
        'ucrInputPackages
        '
        Me.ucrInputPackages.AddQuotesIfUnrecognised = True
        Me.ucrInputPackages.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPackages, "ucrInputPackages")
        Me.ucrInputPackages.Name = "ucrInputPackages"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrPnlOptions
        '
        resources.ApplyResources(Me.ucrPnlOptions, "ucrPnlOptions")
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        '
        'ucrNewDataFrameName
        '
        resources.ApplyResources(Me.ucrNewDataFrameName, "ucrNewDataFrameName")
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        '
        'dlgFromLibrary
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrNewDataFrameName)
        Me.Controls.Add(Me.rdoDefaultDatasets)
        Me.Controls.Add(Me.rdoInstatCollection)
        Me.Controls.Add(Me.cmdLibraryCollection)
        Me.Controls.Add(Me.ucrInputPackages)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.lblFromPackage)
        Me.Controls.Add(Me.lstCollection)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFromLibrary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdLibraryCollection As Button
    Friend WithEvents lstCollection As ListView
    Friend WithEvents clmDatasets As ColumnHeader
    Friend WithEvents clmDesc As ColumnHeader
    Friend WithEvents lblFromPackage As Label
    Friend WithEvents cmdHelp As Button
    Friend WithEvents ucrInputPackages As ucrInputComboBox
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents rdoDefaultDatasets As RadioButton
    Friend WithEvents rdoInstatCollection As RadioButton
    Friend WithEvents ucrNewDataFrameName As ucrSave
End Class