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
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 279)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 10
        '
        'ucrSelectByMetadata
        '
        Me.ucrSelectByMetadata.AutoSize = True
        Me.ucrSelectByMetadata.bDropUnusedFilterLevels = False
        Me.ucrSelectByMetadata.bShowHiddenColumns = False
        Me.ucrSelectByMetadata.bUseCurrentFilter = True
        Me.ucrSelectByMetadata.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectByMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectByMetadata.Name = "ucrSelectByMetadata"
        Me.ucrSelectByMetadata.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectByMetadata.TabIndex = 9
        '
        'ucrReceiverChooseProperty
        '
        Me.ucrReceiverChooseProperty.AutoSize = True
        Me.ucrReceiverChooseProperty.frmParent = Me
        Me.ucrReceiverChooseProperty.Location = New System.Drawing.Point(254, 45)
        Me.ucrReceiverChooseProperty.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverChooseProperty.Name = "ucrReceiverChooseProperty"
        Me.ucrReceiverChooseProperty.Selector = Nothing
        Me.ucrReceiverChooseProperty.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverChooseProperty.strNcFilePath = ""
        Me.ucrReceiverChooseProperty.TabIndex = 8
        Me.ucrReceiverChooseProperty.ucrSelector = Nothing
        '
        'rdoChooseProperty
        '
        Me.rdoChooseProperty.Location = New System.Drawing.Point(9, 22)
        Me.rdoChooseProperty.Name = "rdoChooseProperty"
        Me.rdoChooseProperty.Size = New System.Drawing.Size(144, 24)
        Me.rdoChooseProperty.TabIndex = 0
        Me.rdoChooseProperty.TabStop = True
        Me.rdoChooseProperty.Text = "Choose Property"
        Me.rdoChooseProperty.UseVisualStyleBackColor = True
        '
        'rdoDefineNewProperty
        '
        Me.rdoDefineNewProperty.Location = New System.Drawing.Point(9, 49)
        Me.rdoDefineNewProperty.Name = "rdoDefineNewProperty"
        Me.rdoDefineNewProperty.Size = New System.Drawing.Size(167, 24)
        Me.rdoDefineNewProperty.TabIndex = 1
        Me.rdoDefineNewProperty.TabStop = True
        Me.rdoDefineNewProperty.Text = "Define New Property"
        Me.rdoDefineNewProperty.UseVisualStyleBackColor = True
        '
        'lblChooseColumns
        '
        Me.lblChooseColumns.Location = New System.Drawing.Point(254, 73)
        Me.lblChooseColumns.Name = "lblChooseColumns"
        Me.lblChooseColumns.Size = New System.Drawing.Size(166, 30)
        Me.lblChooseColumns.TabIndex = 7
        Me.lblChooseColumns.Text = "Choose Columns:"
        '
        'ucrReceiverChooseColumns
        '
        Me.ucrReceiverChooseColumns.AutoSize = True
        Me.ucrReceiverChooseColumns.frmParent = Me
        Me.ucrReceiverChooseColumns.Location = New System.Drawing.Point(254, 87)
        Me.ucrReceiverChooseColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverChooseColumns.Name = "ucrReceiverChooseColumns"
        Me.ucrReceiverChooseColumns.Selector = Nothing
        Me.ucrReceiverChooseColumns.Size = New System.Drawing.Size(120, 103)
        Me.ucrReceiverChooseColumns.strNcFilePath = ""
        Me.ucrReceiverChooseColumns.TabIndex = 6
        Me.ucrReceiverChooseColumns.ucrSelector = Nothing
        '
        'lblCurrentValue
        '
        Me.lblCurrentValue.Location = New System.Drawing.Point(10, 215)
        Me.lblCurrentValue.Name = "lblCurrentValue"
        Me.lblCurrentValue.Size = New System.Drawing.Size(84, 23)
        Me.lblCurrentValue.TabIndex = 5
        Me.lblCurrentValue.Text = "Current Value:"
        '
        'lblNewValue
        '
        Me.lblNewValue.Location = New System.Drawing.Point(10, 248)
        Me.lblNewValue.Name = "lblNewValue"
        Me.lblNewValue.Size = New System.Drawing.Size(76, 18)
        Me.lblNewValue.TabIndex = 4
        Me.lblNewValue.Text = "New Value:"
        '
        'ucrCurrentValue
        '
        Me.ucrCurrentValue.AddQuotesIfUnrecognised = True
        Me.ucrCurrentValue.AutoSize = True
        Me.ucrCurrentValue.IsMultiline = False
        Me.ucrCurrentValue.IsReadOnly = False
        Me.ucrCurrentValue.Location = New System.Drawing.Point(111, 213)
        Me.ucrCurrentValue.Name = "ucrCurrentValue"
        Me.ucrCurrentValue.Size = New System.Drawing.Size(118, 21)
        Me.ucrCurrentValue.TabIndex = 3
        '
        'ucrNewValue
        '
        Me.ucrNewValue.AutoSize = True
        Me.ucrNewValue.Location = New System.Drawing.Point(111, 244)
        Me.ucrNewValue.Name = "ucrNewValue"
        Me.ucrNewValue.Size = New System.Drawing.Size(121, 29)
        Me.ucrNewValue.TabIndex = 2
        '
        'grpProperty
        '
        Me.grpProperty.Controls.Add(Me.rdoChooseProperty)
        Me.grpProperty.Controls.Add(Me.rdoDefineNewProperty)
        Me.grpProperty.Location = New System.Drawing.Point(238, 193)
        Me.grpProperty.Name = "grpProperty"
        Me.grpProperty.Size = New System.Drawing.Size(182, 80)
        Me.grpProperty.TabIndex = 1
        Me.grpProperty.TabStop = False
        Me.grpProperty.Text = "Property"
        '
        'ucrInputDefineProperty
        '
        Me.ucrInputDefineProperty.AddQuotesIfUnrecognised = True
        Me.ucrInputDefineProperty.AutoSize = True
        Me.ucrInputDefineProperty.IsMultiline = False
        Me.ucrInputDefineProperty.IsReadOnly = False
        Me.ucrInputDefineProperty.Location = New System.Drawing.Point(254, 45)
        Me.ucrInputDefineProperty.Name = "ucrInputDefineProperty"
        Me.ucrInputDefineProperty.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputDefineProperty.TabIndex = 0
        '
        'UcrDialogDisabled1
        '
        Me.UcrDialogDisabled1.AutoSize = True
        Me.UcrDialogDisabled1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcrDialogDisabled1.Location = New System.Drawing.Point(92, 157)
        Me.UcrDialogDisabled1.Name = "UcrDialogDisabled1"
        Me.UcrDialogDisabled1.Size = New System.Drawing.Size(240, 50)
        Me.UcrDialogDisabled1.TabIndex = 11
        '
        'lblProperty
        '
        Me.lblProperty.Location = New System.Drawing.Point(252, 30)
        Me.lblProperty.Name = "lblProperty"
        Me.lblProperty.Size = New System.Drawing.Size(100, 15)
        Me.lblProperty.TabIndex = 12
        Me.lblProperty.Text = "Property:"
        '
        'dlgMetadata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(426, 338)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Metadata"
        Me.Text = "Metadata"
        Me.grpProperty.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
