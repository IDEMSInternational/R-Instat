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
Partial Class sdgFactorDataFrame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgFactorDataFrame))
        Me.ucrBaseFactorSubdlg = New instat.ucrButtonsSubdialogue()
        Me.ucrSelectorSubDlgFactorDatafrme = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverLabels = New instat.ucrReceiverSingle()
        Me.ucrReceiverMatchColumn = New instat.ucrReceiverSingle()
        Me.lblMatchingColumn = New System.Windows.Forms.Label()
        Me.lbllabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBaseFactorSubdlg
        '
        resources.ApplyResources(Me.ucrBaseFactorSubdlg, "ucrBaseFactorSubdlg")
        Me.ucrBaseFactorSubdlg.Name = "ucrBaseFactorSubdlg"
        '
        'ucrSelectorSubDlgFactorDatafrme
        '
        Me.ucrSelectorSubDlgFactorDatafrme.bShowHiddenColumns = False
        Me.ucrSelectorSubDlgFactorDatafrme.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorSubDlgFactorDatafrme, "ucrSelectorSubDlgFactorDatafrme")
        Me.ucrSelectorSubDlgFactorDatafrme.Name = "ucrSelectorSubDlgFactorDatafrme"
        '
        'ucrReceiverLabels
        '
        Me.ucrReceiverLabels.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverLabels, "ucrReceiverLabels")
        Me.ucrReceiverLabels.Name = "ucrReceiverLabels"
        Me.ucrReceiverLabels.Selector = Nothing
        Me.ucrReceiverLabels.strNcFilePath = ""
        Me.ucrReceiverLabels.ucrSelector = Nothing
        '
        'ucrReceiverMatchColumn
        '
        Me.ucrReceiverMatchColumn.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMatchColumn, "ucrReceiverMatchColumn")
        Me.ucrReceiverMatchColumn.Name = "ucrReceiverMatchColumn"
        Me.ucrReceiverMatchColumn.Selector = Nothing
        Me.ucrReceiverMatchColumn.strNcFilePath = ""
        Me.ucrReceiverMatchColumn.ucrSelector = Nothing
        '
        'lblMatchingColumn
        '
        resources.ApplyResources(Me.lblMatchingColumn, "lblMatchingColumn")
        Me.lblMatchingColumn.Name = "lblMatchingColumn"
        '
        'lbllabel
        '
        resources.ApplyResources(Me.lbllabel, "lbllabel")
        Me.lbllabel.Name = "lbllabel"
        '
        'sdgFactorDataFrame
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbllabel)
        Me.Controls.Add(Me.lblMatchingColumn)
        Me.Controls.Add(Me.ucrReceiverMatchColumn)
        Me.Controls.Add(Me.ucrReceiverLabels)
        Me.Controls.Add(Me.ucrSelectorSubDlgFactorDatafrme)
        Me.Controls.Add(Me.ucrBaseFactorSubdlg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgFactorDataFrame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseFactorSubdlg As ucrButtonsSubdialogue
    Friend WithEvents ucrSelectorSubDlgFactorDatafrme As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverLabels As ucrReceiverSingle
    Friend WithEvents ucrReceiverMatchColumn As ucrReceiverSingle
    Friend WithEvents lblMatchingColumn As Label
    Friend WithEvents lbllabel As Label
End Class
