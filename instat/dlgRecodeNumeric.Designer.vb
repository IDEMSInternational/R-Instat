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
Partial Class dlgRecodeNumeric
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRecodeNumeric))
        Me.chkAddLabels = New System.Windows.Forms.CheckBox()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.lblBreakPoints = New System.Windows.Forms.Label()
        Me.grpClosedOn = New System.Windows.Forms.GroupBox()
        Me.rdoLeft = New System.Windows.Forms.RadioButton()
        Me.rdoRight = New System.Windows.Forms.RadioButton()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.ucrInputRecode = New instat.ucrInputComboBox()
        Me.ucrReceiverRecode = New instat.ucrReceiverSingle()
        Me.ucrSelectorForRecode = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrMultipleLabels = New instat.ucrInputTextBox()
        Me.ucrMultipleNumericRecode = New instat.ucrInputTextBox()
        Me.grpClosedOn.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkAddLabels
        '
        resources.ApplyResources(Me.chkAddLabels, "chkAddLabels")
        Me.chkAddLabels.Name = "chkAddLabels"
        Me.chkAddLabels.Tag = "Add_Labels"
        Me.chkAddLabels.UseVisualStyleBackColor = True
        '
        'lblSelectedVariable
        '
        resources.ApplyResources(Me.lblSelectedVariable, "lblSelectedVariable")
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Tag = "Selected_Variable"
        '
        'lblBreakPoints
        '
        resources.ApplyResources(Me.lblBreakPoints, "lblBreakPoints")
        Me.lblBreakPoints.Name = "lblBreakPoints"
        Me.lblBreakPoints.Tag = "Break_Points"
        '
        'grpClosedOn
        '
        Me.grpClosedOn.Controls.Add(Me.rdoLeft)
        Me.grpClosedOn.Controls.Add(Me.rdoRight)
        resources.ApplyResources(Me.grpClosedOn, "grpClosedOn")
        Me.grpClosedOn.Name = "grpClosedOn"
        Me.grpClosedOn.TabStop = False
        Me.grpClosedOn.Tag = "Closed_On"
        '
        'rdoLeft
        '
        resources.ApplyResources(Me.rdoLeft, "rdoLeft")
        Me.rdoLeft.Name = "rdoLeft"
        Me.rdoLeft.Tag = "Left"
        Me.rdoLeft.UseVisualStyleBackColor = True
        '
        'rdoRight
        '
        resources.ApplyResources(Me.rdoRight, "rdoRight")
        Me.rdoRight.Name = "rdoRight"
        Me.rdoRight.Tag = "Right"
        Me.rdoRight.UseVisualStyleBackColor = True
        '
        'lblNewColumnName
        '
        resources.ApplyResources(Me.lblNewColumnName, "lblNewColumnName")
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Tag = "New_Column_Name:"
        '
        'ucrInputRecode
        '
        Me.ucrInputRecode.AddQuotesIfUnrecognised = True
        Me.ucrInputRecode.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputRecode, "ucrInputRecode")
        Me.ucrInputRecode.Name = "ucrInputRecode"
        '
        'ucrReceiverRecode
        '
        Me.ucrReceiverRecode.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverRecode, "ucrReceiverRecode")
        Me.ucrReceiverRecode.Name = "ucrReceiverRecode"
        Me.ucrReceiverRecode.Selector = Nothing
        Me.ucrReceiverRecode.strNcFilePath = ""
        Me.ucrReceiverRecode.ucrSelector = Nothing
        '
        'ucrSelectorForRecode
        '
        Me.ucrSelectorForRecode.bShowHiddenColumns = False
        Me.ucrSelectorForRecode.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForRecode, "ucrSelectorForRecode")
        Me.ucrSelectorForRecode.Name = "ucrSelectorForRecode"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrMultipleLabels
        '
        Me.ucrMultipleLabels.AddQuotesIfUnrecognised = True
        Me.ucrMultipleLabels.IsMultiline = False
        Me.ucrMultipleLabels.IsReadOnly = False
        resources.ApplyResources(Me.ucrMultipleLabels, "ucrMultipleLabels")
        Me.ucrMultipleLabels.Name = "ucrMultipleLabels"
        '
        'ucrMultipleNumericRecode
        '
        Me.ucrMultipleNumericRecode.AddQuotesIfUnrecognised = True
        Me.ucrMultipleNumericRecode.IsMultiline = False
        Me.ucrMultipleNumericRecode.IsReadOnly = False
        resources.ApplyResources(Me.ucrMultipleNumericRecode, "ucrMultipleNumericRecode")
        Me.ucrMultipleNumericRecode.Name = "ucrMultipleNumericRecode"
        '
        'dlgRecodeNumeric
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrMultipleNumericRecode)
        Me.Controls.Add(Me.ucrMultipleLabels)
        Me.Controls.Add(Me.ucrInputRecode)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.grpClosedOn)
        Me.Controls.Add(Me.lblBreakPoints)
        Me.Controls.Add(Me.ucrReceiverRecode)
        Me.Controls.Add(Me.ucrSelectorForRecode)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.chkAddLabels)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRecodeNumeric"
        Me.Tag = "Recode_Numeric"
        Me.grpClosedOn.ResumeLayout(False)
        Me.grpClosedOn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkAddLabels As CheckBox
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrSelectorForRecode As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRecode As ucrReceiverSingle
    Friend WithEvents lblBreakPoints As Label
    Friend WithEvents grpClosedOn As GroupBox
    Friend WithEvents rdoLeft As RadioButton
    Friend WithEvents rdoRight As RadioButton
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents ucrInputRecode As ucrInputComboBox
    Friend WithEvents ucrMultipleLabels As ucrInputTextBox
    Friend WithEvents ucrMultipleNumericRecode As ucrInputTextBox
End Class
