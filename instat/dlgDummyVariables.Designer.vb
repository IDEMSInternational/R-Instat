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
        Me.lblSelected.AutoSize = True
        Me.lblSelected.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelected.Location = New System.Drawing.Point(284, 45)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(90, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Tag = "Selected"
        Me.lblSelected.Text = "Selected Column:"
        '
        'grpLevelOmitted
        '
        Me.grpLevelOmitted.Controls.Add(Me.rdoMostFrequent)
        Me.grpLevelOmitted.Controls.Add(Me.rdoFirst)
        Me.grpLevelOmitted.Controls.Add(Me.rdoNone)
        Me.grpLevelOmitted.Controls.Add(Me.ucrPnlLevelOmitted)
        Me.grpLevelOmitted.Location = New System.Drawing.Point(284, 86)
        Me.grpLevelOmitted.Name = "grpLevelOmitted"
        Me.grpLevelOmitted.Size = New System.Drawing.Size(120, 92)
        Me.grpLevelOmitted.TabIndex = 3
        Me.grpLevelOmitted.TabStop = False
        Me.grpLevelOmitted.Tag = "Level Omitted"
        Me.grpLevelOmitted.Text = "Level Omitted"
        '
        'rdoMostFrequent
        '
        Me.rdoMostFrequent.AutoSize = True
        Me.rdoMostFrequent.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMostFrequent.Location = New System.Drawing.Point(11, 66)
        Me.rdoMostFrequent.Name = "rdoMostFrequent"
        Me.rdoMostFrequent.Size = New System.Drawing.Size(93, 17)
        Me.rdoMostFrequent.TabIndex = 3
        Me.rdoMostFrequent.TabStop = True
        Me.rdoMostFrequent.Tag = "Most_Frequent"
        Me.rdoMostFrequent.Text = "Most Frequent"
        Me.rdoMostFrequent.UseVisualStyleBackColor = True
        '
        'rdoFirst
        '
        Me.rdoFirst.AutoSize = True
        Me.rdoFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFirst.Location = New System.Drawing.Point(11, 43)
        Me.rdoFirst.Name = "rdoFirst"
        Me.rdoFirst.Size = New System.Drawing.Size(44, 17)
        Me.rdoFirst.TabIndex = 2
        Me.rdoFirst.TabStop = True
        Me.rdoFirst.Tag = "First"
        Me.rdoFirst.Text = "First"
        Me.rdoFirst.UseVisualStyleBackColor = True
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNone.Location = New System.Drawing.Point(11, 20)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(51, 17)
        Me.rdoNone.TabIndex = 1
        Me.rdoNone.TabStop = True
        Me.rdoNone.Tag = "None"
        Me.rdoNone.Text = "None"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'ucrPnlLevelOmitted
        '
        Me.ucrPnlLevelOmitted.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlLevelOmitted.Location = New System.Drawing.Point(6, 16)
        Me.ucrPnlLevelOmitted.Name = "ucrPnlLevelOmitted"
        Me.ucrPnlLevelOmitted.Size = New System.Drawing.Size(108, 70)
        Me.ucrPnlLevelOmitted.TabIndex = 0
        '
        'ucrSelectorDummyVariable
        '
        Me.ucrSelectorDummyVariable.AutoSize = True
        Me.ucrSelectorDummyVariable.bDropUnusedFilterLevels = False
        Me.ucrSelectorDummyVariable.bShowHiddenColumns = False
        Me.ucrSelectorDummyVariable.bUseCurrentFilter = True
        Me.ucrSelectorDummyVariable.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorDummyVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDummyVariable.Name = "ucrSelectorDummyVariable"
        Me.ucrSelectorDummyVariable.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorDummyVariable.TabIndex = 0
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.AutoSize = True
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(284, 60)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.TabIndex = 2
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 205)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 4
        '
        'dlgDummyVariables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(419, 258)
        Me.Controls.Add(Me.grpLevelOmitted)
        Me.Controls.Add(Me.ucrSelectorDummyVariable)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDummyVariables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Dummy_Variables"
        Me.Text = "Dummy Variables"
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
