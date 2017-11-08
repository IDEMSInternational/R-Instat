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
Partial Class dlgContrasts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgContrasts))
        Me.lblFactorReceiver = New System.Windows.Forms.Label()
        Me.lblSelectContrastName = New System.Windows.Forms.Label()
        Me.lblDefineContrast = New System.Windows.Forms.Label()
        Me.grdLayoutForContrasts = New unvell.ReoGrid.ReoGridControl()
        Me.ucrInputContrastName = New instat.ucrInputComboBox()
        Me.ucrReceiverForContrasts = New instat.ucrReceiverSingle()
        Me.ucrSelectorForContrast = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblFactorReceiver
        '
        resources.ApplyResources(Me.lblFactorReceiver, "lblFactorReceiver")
        Me.lblFactorReceiver.Name = "lblFactorReceiver"
        '
        'lblSelectContrastName
        '
        resources.ApplyResources(Me.lblSelectContrastName, "lblSelectContrastName")
        Me.lblSelectContrastName.Name = "lblSelectContrastName"
        '
        'lblDefineContrast
        '
        resources.ApplyResources(Me.lblDefineContrast, "lblDefineContrast")
        Me.lblDefineContrast.Name = "lblDefineContrast"
        '
        'grdLayoutForContrasts
        '
        Me.grdLayoutForContrasts.BackColor = System.Drawing.Color.White
        Me.grdLayoutForContrasts.ColumnHeaderContextMenuStrip = Nothing
        Me.grdLayoutForContrasts.LeadHeaderContextMenuStrip = Nothing
        resources.ApplyResources(Me.grdLayoutForContrasts, "grdLayoutForContrasts")
        Me.grdLayoutForContrasts.Name = "grdLayoutForContrasts"
        Me.grdLayoutForContrasts.RowHeaderContextMenuStrip = Nothing
        Me.grdLayoutForContrasts.Script = Nothing
        Me.grdLayoutForContrasts.SheetTabContextMenuStrip = Nothing
        Me.grdLayoutForContrasts.SheetTabNewButtonVisible = True
        Me.grdLayoutForContrasts.SheetTabVisible = True
        Me.grdLayoutForContrasts.SheetTabWidth = 60
        Me.grdLayoutForContrasts.ShowScrollEndSpacing = True
        '
        'ucrInputContrastName
        '
        Me.ucrInputContrastName.AddQuotesIfUnrecognised = True
        Me.ucrInputContrastName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputContrastName, "ucrInputContrastName")
        Me.ucrInputContrastName.Name = "ucrInputContrastName"
        '
        'ucrReceiverForContrasts
        '
        Me.ucrReceiverForContrasts.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverForContrasts, "ucrReceiverForContrasts")
        Me.ucrReceiverForContrasts.Name = "ucrReceiverForContrasts"
        Me.ucrReceiverForContrasts.Selector = Nothing
        Me.ucrReceiverForContrasts.strNcFilePath = ""
        Me.ucrReceiverForContrasts.ucrSelector = Nothing
        '
        'ucrSelectorForContrast
        '
        Me.ucrSelectorForContrast.bShowHiddenColumns = False
        Me.ucrSelectorForContrast.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForContrast, "ucrSelectorForContrast")
        Me.ucrSelectorForContrast.Name = "ucrSelectorForContrast"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgContrasts
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grdLayoutForContrasts)
        Me.Controls.Add(Me.lblDefineContrast)
        Me.Controls.Add(Me.lblSelectContrastName)
        Me.Controls.Add(Me.ucrInputContrastName)
        Me.Controls.Add(Me.lblFactorReceiver)
        Me.Controls.Add(Me.ucrReceiverForContrasts)
        Me.Controls.Add(Me.ucrSelectorForContrast)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgContrasts"
        Me.Tag = "Contrasts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForContrast As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverForContrasts As ucrReceiverSingle
    Friend WithEvents lblFactorReceiver As Label
    Friend WithEvents ucrInputContrastName As ucrInputComboBox
    Friend WithEvents lblSelectContrastName As Label
    Friend WithEvents lblDefineContrast As Label
    Friend WithEvents grdLayoutForContrasts As unvell.ReoGrid.ReoGridControl
End Class
