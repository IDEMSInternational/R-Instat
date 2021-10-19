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
Partial Class dlgDummyVariables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDummyVariables))
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.grpLevelOmitted = New System.Windows.Forms.GroupBox()
        Me.rdoMostFrequent = New System.Windows.Forms.RadioButton()
        Me.rdoFirst = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.ucrPnlLevelOmitted = New instat.UcrPanel()
        Me.ucrSelectorDummyVariable = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpLevelOmitted.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        resources.ApplyResources(Me.lblSelected, "lblSelected")
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Tag = "Selected"
        '
        'grpLevelOmitted
        '
        Me.grpLevelOmitted.Controls.Add(Me.rdoMostFrequent)
        Me.grpLevelOmitted.Controls.Add(Me.rdoFirst)
        Me.grpLevelOmitted.Controls.Add(Me.rdoNone)
        Me.grpLevelOmitted.Controls.Add(Me.ucrPnlLevelOmitted)
        resources.ApplyResources(Me.grpLevelOmitted, "grpLevelOmitted")
        Me.grpLevelOmitted.Name = "grpLevelOmitted"
        Me.grpLevelOmitted.TabStop = False
        Me.grpLevelOmitted.Tag = "Level Omitted"
        '
        'rdoMostFrequent
        '
        resources.ApplyResources(Me.rdoMostFrequent, "rdoMostFrequent")
        Me.rdoMostFrequent.Name = "rdoMostFrequent"
        Me.rdoMostFrequent.TabStop = True
        Me.rdoMostFrequent.Tag = "Most_Frequent"
        Me.rdoMostFrequent.UseVisualStyleBackColor = True
        '
        'rdoFirst
        '
        resources.ApplyResources(Me.rdoFirst, "rdoFirst")
        Me.rdoFirst.Name = "rdoFirst"
        Me.rdoFirst.TabStop = True
        Me.rdoFirst.Tag = "First"
        Me.rdoFirst.UseVisualStyleBackColor = True
        '
        'rdoNone
        '
        resources.ApplyResources(Me.rdoNone, "rdoNone")
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.TabStop = True
        Me.rdoNone.Tag = "None"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'ucrPnlLevelOmitted
        '
        resources.ApplyResources(Me.ucrPnlLevelOmitted, "ucrPnlLevelOmitted")
        Me.ucrPnlLevelOmitted.Name = "ucrPnlLevelOmitted"
        '
        'ucrSelectorDummyVariable
        '
        Me.ucrSelectorDummyVariable.bDropUnusedFilterLevels = False
        Me.ucrSelectorDummyVariable.bShowHiddenColumns = False
        Me.ucrSelectorDummyVariable.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorDummyVariable, "ucrSelectorDummyVariable")
        Me.ucrSelectorDummyVariable.Name = "ucrSelectorDummyVariable"
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFactor, "ucrReceiverFactor")
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgDummyVariables
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpLevelOmitted)
        Me.Controls.Add(Me.ucrSelectorDummyVariable)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDummyVariables"
        Me.Tag = "Dummy_Variables"
        Me.grpLevelOmitted.ResumeLayout(False)
        Me.grpLevelOmitted.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblSelected As Label
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents ucrSelectorDummyVariable As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpLevelOmitted As GroupBox
    Friend WithEvents rdoMostFrequent As RadioButton
    Friend WithEvents rdoFirst As RadioButton
    Friend WithEvents rdoNone As RadioButton
    Friend WithEvents ucrPnlLevelOmitted As UcrPanel
End Class
