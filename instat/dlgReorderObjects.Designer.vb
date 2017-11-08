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
Partial Class dlgReorderObjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgReorderObjects))
        Me.ucrBase = New instat.ucrButtons()
        Me.lblObjectsToReoder = New System.Windows.Forms.Label()
        Me.ucrDataFrameReorder = New instat.ucrDataFrame()
        Me.ucrReorderObjects = New instat.ucrReorder()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'lblObjectsToReoder
        '
        resources.ApplyResources(Me.lblObjectsToReoder, "lblObjectsToReoder")
        Me.lblObjectsToReoder.Name = "lblObjectsToReoder"
        Me.lblObjectsToReoder.Tag = "Objects_to_Reorder"
        '
        'ucrDataFrameReorder
        '
        Me.ucrDataFrameReorder.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrDataFrameReorder, "ucrDataFrameReorder")
        Me.ucrDataFrameReorder.Name = "ucrDataFrameReorder"
        '
        'ucrReorderObjects
        '
        resources.ApplyResources(Me.ucrReorderObjects, "ucrReorderObjects")
        Me.ucrReorderObjects.Name = "ucrReorderObjects"
        Me.ucrReorderObjects.ucrDataFrameList = Nothing
        Me.ucrReorderObjects.ucrReceiver = Nothing
        '
        'dlgReorderObjects
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblObjectsToReoder)
        Me.Controls.Add(Me.ucrDataFrameReorder)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReorderObjects)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReorderObjects"
        Me.Tag = "Reorder_Objects"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblObjectsToReoder As Label
    Friend WithEvents ucrDataFrameReorder As ucrDataFrame
    Friend WithEvents ucrReorderObjects As ucrReorder
End Class
