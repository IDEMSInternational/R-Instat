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
Partial Class dlgJitter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgJitter))
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.grpMaximumAndMinimumValues = New System.Windows.Forms.GroupBox()
        Me.ucrInputMaximum = New instat.ucrInputTextBox()
        Me.ucrInputMinimum = New instat.ucrInputTextBox()
        Me.ucrInputMaximumDistanceFromZero = New instat.ucrInputTextBox()
        Me.rdoMinimumAndMaximum = New System.Windows.Forms.RadioButton()
        Me.rdoMaximumDistanceFromZero = New System.Windows.Forms.RadioButton()
        Me.ucrPnlDistance = New instat.UcrPanel()
        Me.ucrReceiverJitter = New instat.ucrReceiverSingle()
        Me.ucrSelectorForJitter = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputNewColName = New instat.ucrSave()
        Me.grpMaximumAndMinimumValues.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedVariable
        '
        resources.ApplyResources(Me.lblSelectedVariable, "lblSelectedVariable")
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        '
        'grpMaximumAndMinimumValues
        '
        Me.grpMaximumAndMinimumValues.Controls.Add(Me.ucrInputMaximum)
        Me.grpMaximumAndMinimumValues.Controls.Add(Me.ucrInputMinimum)
        Me.grpMaximumAndMinimumValues.Controls.Add(Me.ucrInputMaximumDistanceFromZero)
        Me.grpMaximumAndMinimumValues.Controls.Add(Me.rdoMinimumAndMaximum)
        Me.grpMaximumAndMinimumValues.Controls.Add(Me.rdoMaximumDistanceFromZero)
        Me.grpMaximumAndMinimumValues.Controls.Add(Me.ucrPnlDistance)
        resources.ApplyResources(Me.grpMaximumAndMinimumValues, "grpMaximumAndMinimumValues")
        Me.grpMaximumAndMinimumValues.Name = "grpMaximumAndMinimumValues"
        Me.grpMaximumAndMinimumValues.TabStop = False
        '
        'ucrInputMaximum
        '
        Me.ucrInputMaximum.AddQuotesIfUnrecognised = True
        Me.ucrInputMaximum.IsMultiline = False
        Me.ucrInputMaximum.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMaximum, "ucrInputMaximum")
        Me.ucrInputMaximum.Name = "ucrInputMaximum"
        '
        'ucrInputMinimum
        '
        Me.ucrInputMinimum.AddQuotesIfUnrecognised = True
        Me.ucrInputMinimum.IsMultiline = False
        Me.ucrInputMinimum.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinimum, "ucrInputMinimum")
        Me.ucrInputMinimum.Name = "ucrInputMinimum"
        '
        'ucrInputMaximumDistanceFromZero
        '
        Me.ucrInputMaximumDistanceFromZero.AddQuotesIfUnrecognised = True
        Me.ucrInputMaximumDistanceFromZero.IsMultiline = False
        Me.ucrInputMaximumDistanceFromZero.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMaximumDistanceFromZero, "ucrInputMaximumDistanceFromZero")
        Me.ucrInputMaximumDistanceFromZero.Name = "ucrInputMaximumDistanceFromZero"
        '
        'rdoMinimumAndMaximum
        '
        resources.ApplyResources(Me.rdoMinimumAndMaximum, "rdoMinimumAndMaximum")
        Me.rdoMinimumAndMaximum.Name = "rdoMinimumAndMaximum"
        Me.rdoMinimumAndMaximum.TabStop = True
        Me.rdoMinimumAndMaximum.UseVisualStyleBackColor = True
        '
        'rdoMaximumDistanceFromZero
        '
        resources.ApplyResources(Me.rdoMaximumDistanceFromZero, "rdoMaximumDistanceFromZero")
        Me.rdoMaximumDistanceFromZero.Name = "rdoMaximumDistanceFromZero"
        Me.rdoMaximumDistanceFromZero.TabStop = True
        Me.rdoMaximumDistanceFromZero.UseVisualStyleBackColor = True
        '
        'ucrPnlDistance
        '
        resources.ApplyResources(Me.ucrPnlDistance, "ucrPnlDistance")
        Me.ucrPnlDistance.Name = "ucrPnlDistance"
        '
        'ucrReceiverJitter
        '
        Me.ucrReceiverJitter.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverJitter, "ucrReceiverJitter")
        Me.ucrReceiverJitter.Name = "ucrReceiverJitter"
        Me.ucrReceiverJitter.Selector = Nothing
        Me.ucrReceiverJitter.strNcFilePath = ""
        Me.ucrReceiverJitter.ucrSelector = Nothing
        '
        'ucrSelectorForJitter
        '
        Me.ucrSelectorForJitter.bShowHiddenColumns = False
        Me.ucrSelectorForJitter.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForJitter, "ucrSelectorForJitter")
        Me.ucrSelectorForJitter.Name = "ucrSelectorForJitter"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrInputNewColName
        '
        resources.ApplyResources(Me.ucrInputNewColName, "ucrInputNewColName")
        Me.ucrInputNewColName.Name = "ucrInputNewColName"
        '
        'dlgJitter
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputNewColName)
        Me.Controls.Add(Me.grpMaximumAndMinimumValues)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.ucrReceiverJitter)
        Me.Controls.Add(Me.ucrSelectorForJitter)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgJitter"
        Me.Tag = "Jitter"
        Me.grpMaximumAndMinimumValues.ResumeLayout(False)
        Me.grpMaximumAndMinimumValues.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForJitter As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverJitter As ucrReceiverSingle
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents grpMaximumAndMinimumValues As GroupBox
    Friend WithEvents rdoMinimumAndMaximum As RadioButton
    Friend WithEvents rdoMaximumDistanceFromZero As RadioButton
    Friend WithEvents ucrInputMaximumDistanceFromZero As ucrInputTextBox
    Friend WithEvents ucrInputMinimum As ucrInputTextBox
    Friend WithEvents ucrInputMaximum As ucrInputTextBox
    Friend WithEvents ucrPnlDistance As UcrPanel
    Friend WithEvents ucrInputNewColName As ucrSave
End Class
