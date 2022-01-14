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
Partial Class dlgPopulationPyramids
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPopulationPyramidselector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.ucrXVariableReceiver = New instat.ucrReceiverSingle()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.ucrYVariableReceiver = New instat.ucrReceiverSingle()
        Me.lblSecondFactor = New System.Windows.Forms.Label()
        Me.ucrSecondFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrSavePopulationPyramid = New instat.ucrSaveGraph()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 244)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrPopulationPyramidselector
        '
        Me.ucrPopulationPyramidselector.AutoSize = True
        Me.ucrPopulationPyramidselector.bDropUnusedFilterLevels = False
        Me.ucrPopulationPyramidselector.bShowHiddenColumns = False
        Me.ucrPopulationPyramidselector.bUseCurrentFilter = True
        Me.ucrPopulationPyramidselector.Location = New System.Drawing.Point(10, 10)
        Me.ucrPopulationPyramidselector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrPopulationPyramidselector.Name = "ucrPopulationPyramidselector"
        Me.ucrPopulationPyramidselector.Size = New System.Drawing.Size(213, 183)
        Me.ucrPopulationPyramidselector.TabIndex = 1
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.Location = New System.Drawing.Point(255, 25)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(55, 13)
        Me.lblXVariable.TabIndex = 2
        Me.lblXVariable.Text = "X Variable"
        '
        'ucrXVariableReceiver
        '
        Me.ucrXVariableReceiver.AutoSize = True
        Me.ucrXVariableReceiver.frmParent = Me
        Me.ucrXVariableReceiver.Location = New System.Drawing.Point(258, 42)
        Me.ucrXVariableReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrXVariableReceiver.Name = "ucrXVariableReceiver"
        Me.ucrXVariableReceiver.Selector = Nothing
        Me.ucrXVariableReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrXVariableReceiver.strNcFilePath = ""
        Me.ucrXVariableReceiver.TabIndex = 3
        Me.ucrXVariableReceiver.ucrSelector = Nothing
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.Location = New System.Drawing.Point(255, 76)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(55, 13)
        Me.lblYVariable.TabIndex = 2
        Me.lblYVariable.Text = "Y Variable"
        '
        'ucrYVariableReceiver
        '
        Me.ucrYVariableReceiver.AutoSize = True
        Me.ucrYVariableReceiver.frmParent = Me
        Me.ucrYVariableReceiver.Location = New System.Drawing.Point(258, 92)
        Me.ucrYVariableReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrYVariableReceiver.Name = "ucrYVariableReceiver"
        Me.ucrYVariableReceiver.Selector = Nothing
        Me.ucrYVariableReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrYVariableReceiver.strNcFilePath = ""
        Me.ucrYVariableReceiver.TabIndex = 3
        Me.ucrYVariableReceiver.ucrSelector = Nothing
        '
        'lblSecondFactor
        '
        Me.lblSecondFactor.AutoSize = True
        Me.lblSecondFactor.Location = New System.Drawing.Point(255, 125)
        Me.lblSecondFactor.Name = "lblSecondFactor"
        Me.lblSecondFactor.Size = New System.Drawing.Size(77, 13)
        Me.lblSecondFactor.TabIndex = 2
        Me.lblSecondFactor.Text = "Second Factor"
        '
        'ucrSecondFactorReceiver
        '
        Me.ucrSecondFactorReceiver.AutoSize = True
        Me.ucrSecondFactorReceiver.frmParent = Me
        Me.ucrSecondFactorReceiver.Location = New System.Drawing.Point(258, 142)
        Me.ucrSecondFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondFactorReceiver.Name = "ucrSecondFactorReceiver"
        Me.ucrSecondFactorReceiver.Selector = Nothing
        Me.ucrSecondFactorReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrSecondFactorReceiver.strNcFilePath = ""
        Me.ucrSecondFactorReceiver.TabIndex = 3
        Me.ucrSecondFactorReceiver.ucrSelector = Nothing
        '
        'ucrSavePopulationPyramid
        '
        Me.ucrSavePopulationPyramid.AutoSize = True
        Me.ucrSavePopulationPyramid.Location = New System.Drawing.Point(10, 209)
        Me.ucrSavePopulationPyramid.Name = "ucrSavePopulationPyramid"
        Me.ucrSavePopulationPyramid.Size = New System.Drawing.Size(265, 23)
        Me.ucrSavePopulationPyramid.TabIndex = 4
        '
        'dlgPopulationPyramids
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(421, 298)
        Me.Controls.Add(Me.ucrSavePopulationPyramid)
        Me.Controls.Add(Me.ucrSecondFactorReceiver)
        Me.Controls.Add(Me.lblSecondFactor)
        Me.Controls.Add(Me.ucrYVariableReceiver)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.ucrXVariableReceiver)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrPopulationPyramidselector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPopulationPyramids"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Population Pyramids"
        Me.Text = "Population Pyramids"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrPopulationPyramidselector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrXVariableReceiver As ucrReceiverSingle
    Friend WithEvents lblYVariable As Label
    Friend WithEvents ucrYVariableReceiver As ucrReceiverSingle
    Friend WithEvents lblSecondFactor As Label
    Friend WithEvents ucrSecondFactorReceiver As ucrReceiverSingle
    Friend WithEvents ucrSavePopulationPyramid As ucrSaveGraph
End Class
