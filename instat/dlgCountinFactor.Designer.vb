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
Partial Class dlgCountinFactor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCountinFactor))
        Me.lblSelectedFactor = New System.Windows.Forms.Label()
        Me.ucrNewColName = New instat.ucrSave()
        Me.ucrCountReceiver = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrCountSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblSelectedFactor
        '
        resources.ApplyResources(Me.lblSelectedFactor, "lblSelectedFactor")
        Me.lblSelectedFactor.Name = "lblSelectedFactor"
        '
        'ucrNewColName
        '
        resources.ApplyResources(Me.ucrNewColName, "ucrNewColName")
        Me.ucrNewColName.Name = "ucrNewColName"
        '
        'ucrCountReceiver
        '
        Me.ucrCountReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrCountReceiver, "ucrCountReceiver")
        Me.ucrCountReceiver.Name = "ucrCountReceiver"
        Me.ucrCountReceiver.Selector = Nothing
        Me.ucrCountReceiver.strNcFilePath = ""
        Me.ucrCountReceiver.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrCountSelector
        '
        Me.ucrCountSelector.bShowHiddenColumns = False
        Me.ucrCountSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrCountSelector, "ucrCountSelector")
        Me.ucrCountSelector.Name = "ucrCountSelector"
        '
        'dlgCountinFactor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrNewColName)
        Me.Controls.Add(Me.lblSelectedFactor)
        Me.Controls.Add(Me.ucrCountReceiver)
        Me.Controls.Add(Me.ucrCountSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCountinFactor"
        Me.Tag = "Count_in_Factor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrCountSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrCountReceiver As ucrReceiverSingle
    Friend WithEvents lblSelectedFactor As Label
    Friend WithEvents ucrNewColName As ucrSave
End Class
