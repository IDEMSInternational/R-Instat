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
Partial Class dlgHideDataframes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgHideDataframes))
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorForDataFrames = New instat.ucrSelectorAddRemove()
        Me.lblDataFrames = New System.Windows.Forms.Label()
        Me.lblHiddenDataFrames = New System.Windows.Forms.Label()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorForDataFrames
        '
        Me.ucrSelectorForDataFrames.bShowHiddenColumns = False
        resources.ApplyResources(Me.ucrSelectorForDataFrames, "ucrSelectorForDataFrames")
        Me.ucrSelectorForDataFrames.Name = "ucrSelectorForDataFrames"
        '
        'lblDataFrames
        '
        resources.ApplyResources(Me.lblDataFrames, "lblDataFrames")
        Me.lblDataFrames.Name = "lblDataFrames"
        '
        'lblHiddenDataFrames
        '
        resources.ApplyResources(Me.lblHiddenDataFrames, "lblHiddenDataFrames")
        Me.lblHiddenDataFrames.Name = "lblHiddenDataFrames"
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMultiple, "ucrReceiverMultiple")
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Selector = Nothing
        Me.ucrReceiverMultiple.strNcFilePath = ""
        Me.ucrReceiverMultiple.ucrSelector = Nothing
        '
        'dlgHideDataframes
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblHiddenDataFrames)
        Me.Controls.Add(Me.ucrReceiverMultiple)
        Me.Controls.Add(Me.lblDataFrames)
        Me.Controls.Add(Me.ucrSelectorForDataFrames)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgHideDataframes"
        Me.Tag = "Hide_Dataframes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForDataFrames As ucrSelectorAddRemove
    Friend WithEvents lblDataFrames As Label
    Friend WithEvents lblHiddenDataFrames As Label
    Friend WithEvents ucrReceiverMultiple As ucrReceiverMultiple
End Class
