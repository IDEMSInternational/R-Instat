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
Partial Class dlgStringDistance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgStringDistance))
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.lblPattern = New System.Windows.Forms.Label()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.rdoColumn = New System.Windows.Forms.RadioButton()
        Me.rdoString = New System.Windows.Forms.RadioButton()
        Me.lblColumnString = New System.Windows.Forms.Label()
        Me.ucrReceiverColumn = New instat.ucrReceiverSingle()
        Me.ucrSelectorStringDistance = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputComboBoxMethod = New instat.ucrInputComboBox()
        Me.ucrSaveStringDistance = New instat.ucrSave()
        Me.ucrInputPatternStringDistance = New instat.ucrInputTextBox()
        Me.ucrReceiverStringDistance = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlStringDist = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'lblColumn
        '
        resources.ApplyResources(Me.lblColumn, "lblColumn")
        Me.lblColumn.Name = "lblColumn"
        '
        'lblPattern
        '
        resources.ApplyResources(Me.lblPattern, "lblPattern")
        Me.lblPattern.Name = "lblPattern"
        '
        'lblMethod
        '
        resources.ApplyResources(Me.lblMethod, "lblMethod")
        Me.lblMethod.Name = "lblMethod"
        '
        'rdoColumn
        '
        resources.ApplyResources(Me.rdoColumn, "rdoColumn")
        Me.rdoColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColumn.FlatAppearance.BorderSize = 2
        Me.rdoColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColumn.Name = "rdoColumn"
        Me.rdoColumn.TabStop = True
        Me.rdoColumn.UseVisualStyleBackColor = True
        '
        'rdoString
        '
        resources.ApplyResources(Me.rdoString, "rdoString")
        Me.rdoString.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoString.FlatAppearance.BorderSize = 2
        Me.rdoString.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoString.Name = "rdoString"
        Me.rdoString.TabStop = True
        Me.rdoString.UseVisualStyleBackColor = True
        '
        'lblColumnString
        '
        resources.ApplyResources(Me.lblColumnString, "lblColumnString")
        Me.lblColumnString.Name = "lblColumnString"
        '
        'ucrReceiverColumn
        '
        Me.ucrReceiverColumn.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverColumn, "ucrReceiverColumn")
        Me.ucrReceiverColumn.Name = "ucrReceiverColumn"
        Me.ucrReceiverColumn.Selector = Nothing
        Me.ucrReceiverColumn.strNcFilePath = ""
        Me.ucrReceiverColumn.ucrSelector = Nothing
        '
        'ucrSelectorStringDistance
        '
        Me.ucrSelectorStringDistance.bShowHiddenColumns = False
        Me.ucrSelectorStringDistance.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorStringDistance, "ucrSelectorStringDistance")
        Me.ucrSelectorStringDistance.Name = "ucrSelectorStringDistance"
        '
        'ucrInputComboBoxMethod
        '
        Me.ucrInputComboBoxMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxMethod.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboBoxMethod, "ucrInputComboBoxMethod")
        Me.ucrInputComboBoxMethod.Name = "ucrInputComboBoxMethod"
        '
        'ucrSaveStringDistance
        '
        resources.ApplyResources(Me.ucrSaveStringDistance, "ucrSaveStringDistance")
        Me.ucrSaveStringDistance.Name = "ucrSaveStringDistance"
        '
        'ucrInputPatternStringDistance
        '
        Me.ucrInputPatternStringDistance.AddQuotesIfUnrecognised = True
        Me.ucrInputPatternStringDistance.IsMultiline = False
        Me.ucrInputPatternStringDistance.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPatternStringDistance, "ucrInputPatternStringDistance")
        Me.ucrInputPatternStringDistance.Name = "ucrInputPatternStringDistance"
        '
        'ucrReceiverStringDistance
        '
        Me.ucrReceiverStringDistance.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStringDistance, "ucrReceiverStringDistance")
        Me.ucrReceiverStringDistance.Name = "ucrReceiverStringDistance"
        Me.ucrReceiverStringDistance.Selector = Nothing
        Me.ucrReceiverStringDistance.strNcFilePath = ""
        Me.ucrReceiverStringDistance.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrPnlStringDist
        '
        resources.ApplyResources(Me.ucrPnlStringDist, "ucrPnlStringDist")
        Me.ucrPnlStringDist.Name = "ucrPnlStringDist"
        '
        'dlgStringDistance
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblColumnString)
        Me.Controls.Add(Me.ucrReceiverColumn)
        Me.Controls.Add(Me.rdoString)
        Me.Controls.Add(Me.rdoColumn)
        Me.Controls.Add(Me.ucrSelectorStringDistance)
        Me.Controls.Add(Me.lblMethod)
        Me.Controls.Add(Me.ucrInputComboBoxMethod)
        Me.Controls.Add(Me.lblPattern)
        Me.Controls.Add(Me.lblColumn)
        Me.Controls.Add(Me.ucrSaveStringDistance)
        Me.Controls.Add(Me.ucrInputPatternStringDistance)
        Me.Controls.Add(Me.ucrReceiverStringDistance)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlStringDist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStringDistance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverStringDistance As ucrReceiverSingle
    Friend WithEvents lblMethod As Label
    Friend WithEvents ucrInputComboBoxMethod As ucrInputComboBox
    Friend WithEvents lblPattern As Label
    Friend WithEvents lblColumn As Label
    Friend WithEvents ucrSaveStringDistance As ucrSave
    Friend WithEvents ucrInputPatternStringDistance As ucrInputTextBox
    Friend WithEvents ucrSelectorStringDistance As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoString As RadioButton
    Friend WithEvents rdoColumn As RadioButton
    Friend WithEvents ucrPnlStringDist As UcrPanel
    Friend WithEvents lblColumnString As Label
    Friend WithEvents ucrReceiverColumn As ucrReceiverSingle
End Class
