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
Partial Class dlgDeleteDataFrames
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDeleteDataFrames))
        Me.lblDataframes = New System.Windows.Forms.Label()
        Me.lblAppendToDataframe = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverDataFrames = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDataFramesToDelete = New instat.ucrSelectorAddRemove()
        Me.SuspendLayout()
        '
        'lblDataframes
        '
        resources.ApplyResources(Me.lblDataframes, "lblDataframes")
        Me.lblDataframes.Name = "lblDataframes"
        '
        'lblAppendToDataframe
        '
        resources.ApplyResources(Me.lblAppendToDataframe, "lblAppendToDataframe")
        Me.lblAppendToDataframe.Name = "lblAppendToDataframe"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverDataFrames
        '
        Me.ucrReceiverDataFrames.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDataFrames, "ucrReceiverDataFrames")
        Me.ucrReceiverDataFrames.Name = "ucrReceiverDataFrames"
        Me.ucrReceiverDataFrames.Selector = Nothing
        Me.ucrReceiverDataFrames.strNcFilePath = ""
        Me.ucrReceiverDataFrames.ucrSelector = Nothing
        '
        'ucrSelectorDataFramesToDelete
        '
        Me.ucrSelectorDataFramesToDelete.bShowHiddenColumns = False
        resources.ApplyResources(Me.ucrSelectorDataFramesToDelete, "ucrSelectorDataFramesToDelete")
        Me.ucrSelectorDataFramesToDelete.Name = "ucrSelectorDataFramesToDelete"
        '
        'dlgDeleteDataFrames
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblDataframes)
        Me.Controls.Add(Me.lblAppendToDataframe)
        Me.Controls.Add(Me.ucrReceiverDataFrames)
        Me.Controls.Add(Me.ucrSelectorDataFramesToDelete)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDeleteDataFrames"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblDataframes As Label
    Friend WithEvents lblAppendToDataframe As Label
    Friend WithEvents ucrReceiverDataFrames As ucrReceiverMultiple
    Friend WithEvents ucrSelectorDataFramesToDelete As ucrSelectorAddRemove
End Class
