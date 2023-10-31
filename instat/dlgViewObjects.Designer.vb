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
Partial Class dlgViewObjects
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
        Me.lblSelectedObject = New System.Windows.Forms.Label()
        Me.rdoStructure = New System.Windows.Forms.RadioButton()
        Me.rdoPrint = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverSelectedObject = New instat.ucrReceiverSingle()
        Me.ucrSelectorForViewObject = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlContentsToView = New instat.UcrPanel()
        Me.ucrInputObjectType = New instat.ucrInputComboBox()
        Me.lblObjectType = New System.Windows.Forms.Label()
        Me.rdoOutputObjects = New System.Windows.Forms.RadioButton()
        Me.rdoDataObjects = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'lblSelectedObject
        '
        Me.lblSelectedObject.AutoSize = True
        Me.lblSelectedObject.Location = New System.Drawing.Point(369, 144)
        Me.lblSelectedObject.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectedObject.Name = "lblSelectedObject"
        Me.lblSelectedObject.Size = New System.Drawing.Size(59, 20)
        Me.lblSelectedObject.TabIndex = 1
        Me.lblSelectedObject.Text = "Object:"
        '
        'rdoStructure
        '
        Me.rdoStructure.AutoSize = True
        Me.rdoStructure.Location = New System.Drawing.Point(378, 252)
        Me.rdoStructure.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoStructure.Name = "rdoStructure"
        Me.rdoStructure.Size = New System.Drawing.Size(100, 24)
        Me.rdoStructure.TabIndex = 5
        Me.rdoStructure.TabStop = True
        Me.rdoStructure.Tag = "Structure"
        Me.rdoStructure.Text = "Structure"
        Me.rdoStructure.UseVisualStyleBackColor = True
        '
        'rdoPrint
        '
        Me.rdoPrint.AutoSize = True
        Me.rdoPrint.Location = New System.Drawing.Point(378, 219)
        Me.rdoPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoPrint.Name = "rdoPrint"
        Me.rdoPrint.Size = New System.Drawing.Size(66, 24)
        Me.rdoPrint.TabIndex = 4
        Me.rdoPrint.TabStop = True
        Me.rdoPrint.Text = "Print"
        Me.rdoPrint.UseVisualStyleBackColor = True
        '
        'ucrReceiverSelectedObject
        '
        Me.ucrReceiverSelectedObject.AutoSize = True
        Me.ucrReceiverSelectedObject.frmParent = Me
        Me.ucrReceiverSelectedObject.Location = New System.Drawing.Point(369, 166)
        Me.ucrReceiverSelectedObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedObject.Name = "ucrReceiverSelectedObject"
        Me.ucrReceiverSelectedObject.Selector = Nothing
        Me.ucrReceiverSelectedObject.Size = New System.Drawing.Size(206, 30)
        Me.ucrReceiverSelectedObject.strNcFilePath = ""
        Me.ucrReceiverSelectedObject.TabIndex = 2
        Me.ucrReceiverSelectedObject.ucrSelector = Nothing
        '
        'ucrSelectorForViewObject
        '
        Me.ucrSelectorForViewObject.AutoSize = True
        Me.ucrSelectorForViewObject.bDropUnusedFilterLevels = False
        Me.ucrSelectorForViewObject.bShowHiddenColumns = False
        Me.ucrSelectorForViewObject.bUseCurrentFilter = True
        Me.ucrSelectorForViewObject.Location = New System.Drawing.Point(9, 51)
        Me.ucrSelectorForViewObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForViewObject.Name = "ucrSelectorForViewObject"
        Me.ucrSelectorForViewObject.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorForViewObject.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(6, 369)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 8
        '
        'ucrPnlContentsToView
        '
        Me.ucrPnlContentsToView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlContentsToView.Location = New System.Drawing.Point(369, 208)
        Me.ucrPnlContentsToView.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrPnlContentsToView.Name = "ucrPnlContentsToView"
        Me.ucrPnlContentsToView.Size = New System.Drawing.Size(180, 100)
        Me.ucrPnlContentsToView.TabIndex = 3
        '
        'ucrInputObjectType
        '
        Me.ucrInputObjectType.AddQuotesIfUnrecognised = True
        Me.ucrInputObjectType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputObjectType.GetSetSelectedIndex = -1
        Me.ucrInputObjectType.IsReadOnly = False
        Me.ucrInputObjectType.Location = New System.Drawing.Point(369, 106)
        Me.ucrInputObjectType.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputObjectType.Name = "ucrInputObjectType"
        Me.ucrInputObjectType.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputObjectType.TabIndex = 9
        '
        'lblObjectType
        '
        Me.lblObjectType.AutoSize = True
        Me.lblObjectType.Location = New System.Drawing.Point(369, 84)
        Me.lblObjectType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObjectType.Name = "lblObjectType"
        Me.lblObjectType.Size = New System.Drawing.Size(47, 20)
        Me.lblObjectType.TabIndex = 10
        Me.lblObjectType.Text = "Type:"
        '
        'rdoOutputObjects
        '
        Me.rdoOutputObjects.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoOutputObjects.BackColor = System.Drawing.SystemColors.Control
        Me.rdoOutputObjects.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOutputObjects.FlatAppearance.BorderSize = 2
        Me.rdoOutputObjects.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOutputObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoOutputObjects.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoOutputObjects.Location = New System.Drawing.Point(141, 3)
        Me.rdoOutputObjects.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoOutputObjects.Name = "rdoOutputObjects"
        Me.rdoOutputObjects.Size = New System.Drawing.Size(180, 42)
        Me.rdoOutputObjects.TabIndex = 15
        Me.rdoOutputObjects.TabStop = True
        Me.rdoOutputObjects.Tag = ""
        Me.rdoOutputObjects.Text = "Output Objects"
        Me.rdoOutputObjects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoOutputObjects.UseVisualStyleBackColor = False
        '
        'rdoDataObjects
        '
        Me.rdoDataObjects.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDataObjects.BackColor = System.Drawing.SystemColors.Control
        Me.rdoDataObjects.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataObjects.FlatAppearance.BorderSize = 2
        Me.rdoDataObjects.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDataObjects.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDataObjects.Location = New System.Drawing.Point(320, 3)
        Me.rdoDataObjects.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoDataObjects.Name = "rdoDataObjects"
        Me.rdoDataObjects.Size = New System.Drawing.Size(180, 42)
        Me.rdoDataObjects.TabIndex = 16
        Me.rdoDataObjects.TabStop = True
        Me.rdoDataObjects.Tag = ""
        Me.rdoDataObjects.Text = "Data Objects"
        Me.rdoDataObjects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDataObjects.UseVisualStyleBackColor = False
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(4, -2)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(602, 54)
        Me.ucrPnlOptions.TabIndex = 14
        '
        'dlgViewObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(624, 453)
        Me.Controls.Add(Me.rdoOutputObjects)
        Me.Controls.Add(Me.rdoDataObjects)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.lblObjectType)
        Me.Controls.Add(Me.ucrInputObjectType)
        Me.Controls.Add(Me.rdoPrint)
        Me.Controls.Add(Me.rdoStructure)
        Me.Controls.Add(Me.ucrReceiverSelectedObject)
        Me.Controls.Add(Me.lblSelectedObject)
        Me.Controls.Add(Me.ucrSelectorForViewObject)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlContentsToView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgViewObjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "View Object"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForViewObject As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSelectedObject As Label
    Friend WithEvents ucrReceiverSelectedObject As ucrReceiverSingle
    Friend WithEvents rdoStructure As RadioButton
    Friend WithEvents rdoPrint As RadioButton
    Friend WithEvents ucrPnlContentsToView As UcrPanel
    Friend WithEvents lblObjectType As Label
    Friend WithEvents ucrInputObjectType As ucrInputComboBox
    Friend WithEvents rdoOutputObjects As RadioButton
    Friend WithEvents rdoDataObjects As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
End Class
