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
Partial Class dlgDefineCorruptionOutputs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDefineCorruptionOutputs))
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverCorruptionOutputs = New instat.ucrReceiverMultiple()
        Me.ucrSelectorCorruptionOutputs = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblCorruptionOutputs = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverCorruptionOutputs
        '
        Me.ucrReceiverCorruptionOutputs.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverCorruptionOutputs, "ucrReceiverCorruptionOutputs")
        Me.ucrReceiverCorruptionOutputs.Name = "ucrReceiverCorruptionOutputs"
        Me.ucrReceiverCorruptionOutputs.Selector = Nothing
        Me.ucrReceiverCorruptionOutputs.strNcFilePath = ""
        Me.ucrReceiverCorruptionOutputs.ucrSelector = Nothing
        '
        'ucrSelectorCorruptionOutputs
        '
        Me.ucrSelectorCorruptionOutputs.bShowHiddenColumns = False
        Me.ucrSelectorCorruptionOutputs.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorCorruptionOutputs, "ucrSelectorCorruptionOutputs")
        Me.ucrSelectorCorruptionOutputs.Name = "ucrSelectorCorruptionOutputs"
        '
        'lblCorruptionOutputs
        '
        resources.ApplyResources(Me.lblCorruptionOutputs, "lblCorruptionOutputs")
        Me.lblCorruptionOutputs.Name = "lblCorruptionOutputs"
        '
        'dlgDefineCorruptionOutputs
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblCorruptionOutputs)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverCorruptionOutputs)
        Me.Controls.Add(Me.ucrSelectorCorruptionOutputs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDefineCorruptionOutputs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverCorruptionOutputs As ucrReceiverMultiple
    Friend WithEvents ucrSelectorCorruptionOutputs As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblCorruptionOutputs As Label
End Class
