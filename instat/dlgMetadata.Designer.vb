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
Partial Class dlgMetadata
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgMetadata))
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectByMetadata = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverChooseProperty = New instat.ucrReceiverSingle()
        Me.rdoChooseProperty = New System.Windows.Forms.RadioButton()
        Me.rdoDefineNewProperty = New System.Windows.Forms.RadioButton()
        Me.lblChooseColumns = New System.Windows.Forms.Label()
        Me.ucrReceiverChooseColumns = New instat.ucrReceiverMultiple()
        Me.lblCurrentValue = New System.Windows.Forms.Label()
        Me.lblNewValue = New System.Windows.Forms.Label()
        Me.ucrCurrentValue = New instat.ucrInputTextBox()
        Me.ucrNewValue = New instat.ucrReceiverMetadataProperty()
        Me.grpProperty = New System.Windows.Forms.GroupBox()
        Me.ucrInputDefineProperty = New instat.ucrInputTextBox()
        Me.UcrDialogDisabled1 = New instat.ucrDialogDisabled()
        Me.lblProperty = New System.Windows.Forms.Label()
        Me.grpProperty.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectByMetadata
        '
        Me.ucrSelectByMetadata.bShowHiddenColumns = False
        Me.ucrSelectByMetadata.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectByMetadata, "ucrSelectByMetadata")
        Me.ucrSelectByMetadata.Name = "ucrSelectByMetadata"
        '
        'ucrReceiverChooseProperty
        '
        Me.ucrReceiverChooseProperty.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverChooseProperty, "ucrReceiverChooseProperty")
        Me.ucrReceiverChooseProperty.Name = "ucrReceiverChooseProperty"
        Me.ucrReceiverChooseProperty.Selector = Nothing
        Me.ucrReceiverChooseProperty.strNcFilePath = ""
        Me.ucrReceiverChooseProperty.ucrSelector = Nothing
        '
        'rdoChooseProperty
        '
        resources.ApplyResources(Me.rdoChooseProperty, "rdoChooseProperty")
        Me.rdoChooseProperty.Name = "rdoChooseProperty"
        Me.rdoChooseProperty.TabStop = True
        Me.rdoChooseProperty.UseVisualStyleBackColor = True
        '
        'rdoDefineNewProperty
        '
        resources.ApplyResources(Me.rdoDefineNewProperty, "rdoDefineNewProperty")
        Me.rdoDefineNewProperty.Name = "rdoDefineNewProperty"
        Me.rdoDefineNewProperty.TabStop = True
        Me.rdoDefineNewProperty.UseVisualStyleBackColor = True
        '
        'lblChooseColumns
        '
        resources.ApplyResources(Me.lblChooseColumns, "lblChooseColumns")
        Me.lblChooseColumns.Name = "lblChooseColumns"
        '
        'ucrReceiverChooseColumns
        '
        Me.ucrReceiverChooseColumns.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverChooseColumns, "ucrReceiverChooseColumns")
        Me.ucrReceiverChooseColumns.Name = "ucrReceiverChooseColumns"
        Me.ucrReceiverChooseColumns.Selector = Nothing
        Me.ucrReceiverChooseColumns.strNcFilePath = ""
        Me.ucrReceiverChooseColumns.ucrSelector = Nothing
        '
        'lblCurrentValue
        '
        resources.ApplyResources(Me.lblCurrentValue, "lblCurrentValue")
        Me.lblCurrentValue.Name = "lblCurrentValue"
        '
        'lblNewValue
        '
        resources.ApplyResources(Me.lblNewValue, "lblNewValue")
        Me.lblNewValue.Name = "lblNewValue"
        '
        'ucrCurrentValue
        '
        Me.ucrCurrentValue.AddQuotesIfUnrecognised = True
        Me.ucrCurrentValue.IsMultiline = False
        Me.ucrCurrentValue.IsReadOnly = False
        resources.ApplyResources(Me.ucrCurrentValue, "ucrCurrentValue")
        Me.ucrCurrentValue.Name = "ucrCurrentValue"
        '
        'ucrNewValue
        '
        resources.ApplyResources(Me.ucrNewValue, "ucrNewValue")
        Me.ucrNewValue.Name = "ucrNewValue"
        '
        'grpProperty
        '
        Me.grpProperty.Controls.Add(Me.rdoChooseProperty)
        Me.grpProperty.Controls.Add(Me.rdoDefineNewProperty)
        resources.ApplyResources(Me.grpProperty, "grpProperty")
        Me.grpProperty.Name = "grpProperty"
        Me.grpProperty.TabStop = False
        '
        'ucrInputDefineProperty
        '
        Me.ucrInputDefineProperty.AddQuotesIfUnrecognised = True
        Me.ucrInputDefineProperty.IsMultiline = False
        Me.ucrInputDefineProperty.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDefineProperty, "ucrInputDefineProperty")
        Me.ucrInputDefineProperty.Name = "ucrInputDefineProperty"
        '
        'UcrDialogDisabled1
        '
        Me.UcrDialogDisabled1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.UcrDialogDisabled1, "UcrDialogDisabled1")
        Me.UcrDialogDisabled1.Name = "UcrDialogDisabled1"
        '
        'lblProperty
        '
        resources.ApplyResources(Me.lblProperty, "lblProperty")
        Me.lblProperty.Name = "lblProperty"
        '
        'dlgMetadata
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblProperty)
        Me.Controls.Add(Me.UcrDialogDisabled1)
        Me.Controls.Add(Me.ucrInputDefineProperty)
        Me.Controls.Add(Me.grpProperty)
        Me.Controls.Add(Me.ucrNewValue)
        Me.Controls.Add(Me.ucrCurrentValue)
        Me.Controls.Add(Me.lblNewValue)
        Me.Controls.Add(Me.lblCurrentValue)
        Me.Controls.Add(Me.ucrReceiverChooseColumns)
        Me.Controls.Add(Me.lblChooseColumns)
        Me.Controls.Add(Me.ucrReceiverChooseProperty)
        Me.Controls.Add(Me.ucrSelectByMetadata)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMetadata"
        Me.Tag = "Metadata"
        Me.grpProperty.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectByMetadata As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverChooseProperty As ucrReceiverSingle
    Friend WithEvents rdoChooseProperty As RadioButton
    Friend WithEvents rdoDefineNewProperty As RadioButton
    Friend WithEvents lblChooseColumns As Label
    Friend WithEvents ucrReceiverChooseColumns As ucrReceiverMultiple
    Friend WithEvents lblCurrentValue As Label
    Friend WithEvents lblNewValue As Label
    Friend WithEvents ucrCurrentValue As ucrInputTextBox
    Friend WithEvents ucrNewValue As ucrReceiverMetadataProperty
    Friend WithEvents grpProperty As GroupBox
    Friend WithEvents ucrInputDefineProperty As ucrInputTextBox
    Friend WithEvents UcrDialogDisabled1 As ucrDialogDisabled
    Friend WithEvents lblProperty As Label
End Class
