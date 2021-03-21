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
Partial Class dlgCombineforGraphics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCombineforGraphics))
        Me.lblGraphsToCombine = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrCombineGraphReceiver = New instat.ucrReceiverMultiple()
        Me.ucrCombineGraphSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblGraphsToCombine
        '
        resources.ApplyResources(Me.lblGraphsToCombine, "lblGraphsToCombine")
        Me.lblGraphsToCombine.Name = "lblGraphsToCombine"
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrSave
        '
        resources.ApplyResources(Me.ucrSave, "ucrSave")
        Me.ucrSave.Name = "ucrSave"
        '
        'ucrCombineGraphReceiver
        '
        Me.ucrCombineGraphReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrCombineGraphReceiver, "ucrCombineGraphReceiver")
        Me.ucrCombineGraphReceiver.Name = "ucrCombineGraphReceiver"
        Me.ucrCombineGraphReceiver.Selector = Nothing
        Me.ucrCombineGraphReceiver.strNcFilePath = ""
        Me.ucrCombineGraphReceiver.ucrSelector = Nothing
        '
        'ucrCombineGraphSelector
        '
        Me.ucrCombineGraphSelector.bShowHiddenColumns = False
        Me.ucrCombineGraphSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrCombineGraphSelector, "ucrCombineGraphSelector")
        Me.ucrCombineGraphSelector.Name = "ucrCombineGraphSelector"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgCombineforGraphics
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblGraphsToCombine)
        Me.Controls.Add(Me.ucrCombineGraphReceiver)
        Me.Controls.Add(Me.ucrCombineGraphSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCombineforGraphics"
        Me.Tag = "Combine_Graphs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrCombineGraphSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrCombineGraphReceiver As ucrReceiverMultiple
    Friend WithEvents lblGraphsToCombine As Label
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrSave As ucrSave
End Class