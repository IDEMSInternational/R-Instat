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
Partial Class dlgDefineRedFlags
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgDefineRedFlags))
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverRedFlag = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDefineRedFlag = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblRedFlags = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverRedFlag
        '
        Me.ucrReceiverRedFlag.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverRedFlag, "ucrReceiverRedFlag")
        Me.ucrReceiverRedFlag.Name = "ucrReceiverRedFlag"
        Me.ucrReceiverRedFlag.Selector = Nothing
        Me.ucrReceiverRedFlag.strNcFilePath = ""
        Me.ucrReceiverRedFlag.ucrSelector = Nothing
        '
        'ucrSelectorDefineRedFlag
        '
        Me.ucrSelectorDefineRedFlag.bShowHiddenColumns = False
        Me.ucrSelectorDefineRedFlag.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorDefineRedFlag, "ucrSelectorDefineRedFlag")
        Me.ucrSelectorDefineRedFlag.Name = "ucrSelectorDefineRedFlag"
        '
        'lblRedFlags
        '
        resources.ApplyResources(Me.lblRedFlags, "lblRedFlags")
        Me.lblRedFlags.Name = "lblRedFlags"
        '
        'dlgDefineRedFlags
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblRedFlags)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverRedFlag)
        Me.Controls.Add(Me.ucrSelectorDefineRedFlag)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDefineRedFlags"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorDefineRedFlag As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRedFlag As ucrReceiverMultiple
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblRedFlags As Label
End Class
