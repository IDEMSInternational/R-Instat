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
Partial Class dlgDescribeTwoVarGraph
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
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblSecondVariable = New System.Windows.Forms.Label()
        Me.lblFirstVariables = New System.Windows.Forms.Label()
        Me.ucrFlipCoordinates = New instat.ucrCheck()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrSecondVariableReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorTwoVarGraph = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverMultipleTwoVar = New instat.ucrVariablesAsFactor()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(10, 197)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(120, 23)
        Me.cmdOptions.TabIndex = 5
        Me.cmdOptions.Tag = "Options..."
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblSecondVariable
        '
        Me.lblSecondVariable.AutoSize = True
        Me.lblSecondVariable.Location = New System.Drawing.Point(261, 108)
        Me.lblSecondVariable.Name = "lblSecondVariable"
        Me.lblSecondVariable.Size = New System.Drawing.Size(99, 13)
        Me.lblSecondVariable.TabIndex = 3
        Me.lblSecondVariable.Text = "Second Variable(s):"
        '
        'lblFirstVariables
        '
        Me.lblFirstVariables.AutoSize = True
        Me.lblFirstVariables.Location = New System.Drawing.Point(261, 45)
        Me.lblFirstVariables.Name = "lblFirstVariables"
        Me.lblFirstVariables.Size = New System.Drawing.Size(81, 13)
        Me.lblFirstVariables.TabIndex = 2
        Me.lblFirstVariables.Tag = "First_Variable(s)"
        Me.lblFirstVariables.Text = "First Variable(s):"
        '
        'ucrFlipCoordinates
        '
        Me.ucrFlipCoordinates.Checked = False
        Me.ucrFlipCoordinates.Location = New System.Drawing.Point(10, 226)
        Me.ucrFlipCoordinates.Name = "ucrFlipCoordinates"
        Me.ucrFlipCoordinates.Size = New System.Drawing.Size(120, 20)
        Me.ucrFlipCoordinates.TabIndex = 6
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 252)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveGraph.TabIndex = 7
        '
        'ucrSecondVariableReceiver
        '
        Me.ucrSecondVariableReceiver.frmParent = Me
        Me.ucrSecondVariableReceiver.Location = New System.Drawing.Point(264, 60)
        Me.ucrSecondVariableReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondVariableReceiver.Name = "ucrSecondVariableReceiver"
        Me.ucrSecondVariableReceiver.Selector = Nothing
        Me.ucrSecondVariableReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrSecondVariableReceiver.strNcFilePath = ""
        Me.ucrSecondVariableReceiver.TabIndex = 4
        Me.ucrSecondVariableReceiver.ucrSelector = Nothing
        '
        'ucrSelectorTwoVarGraph
        '
        Me.ucrSelectorTwoVarGraph.bShowHiddenColumns = False
        Me.ucrSelectorTwoVarGraph.bUseCurrentFilter = True
        Me.ucrSelectorTwoVarGraph.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorTwoVarGraph.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTwoVarGraph.Name = "ucrSelectorTwoVarGraph"
        Me.ucrSelectorTwoVarGraph.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorTwoVarGraph.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 278)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 8
        '
        'ucrReceiverMultipleTwoVar
        '
        Me.ucrReceiverMultipleTwoVar.frmParent = Me
        Me.ucrReceiverMultipleTwoVar.Location = New System.Drawing.Point(264, 93)
        Me.ucrReceiverMultipleTwoVar.Name = "ucrReceiverMultipleTwoVar"
        Me.ucrReceiverMultipleTwoVar.Selector = Nothing
        Me.ucrReceiverMultipleTwoVar.Size = New System.Drawing.Size(120, 138)
        Me.ucrReceiverMultipleTwoVar.strNcFilePath = ""
        Me.ucrReceiverMultipleTwoVar.TabIndex = 1
        Me.ucrReceiverMultipleTwoVar.ucrSelector = Nothing
        Me.ucrReceiverMultipleTwoVar.ucrVariableSelector = Nothing
        '
        'dlgDescribeTwoVarGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 334)
        Me.Controls.Add(Me.ucrFlipCoordinates)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.lblFirstVariables)
        Me.Controls.Add(Me.lblSecondVariable)
        Me.Controls.Add(Me.ucrSecondVariableReceiver)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrSelectorTwoVarGraph)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverMultipleTwoVar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeTwoVarGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Two Variable Graph"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrSelectorTwoVarGraph As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSecondVariableReceiver As ucrReceiverSingle
    Friend WithEvents lblSecondVariable As Label
    Friend WithEvents ucrReceiverMultipleTwoVar As ucrVariablesAsFactor
    Friend WithEvents lblFirstVariables As Label
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrFlipCoordinates As ucrCheck
End Class