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
        Me.lblFactorReceiver.AutoSize = True
        Me.lblFactorReceiver.Location = New System.Drawing.Point(246, 48)
        Me.lblFactorReceiver.Name = "lblFactorReceiver"
        Me.lblFactorReceiver.Size = New System.Drawing.Size(93, 13)
        Me.lblFactorReceiver.TabIndex = 1
        Me.lblFactorReceiver.Text = "Selected Variable:"
        '
        'lblSelectContrastName
        '
        Me.lblSelectContrastName.AutoSize = True
        Me.lblSelectContrastName.Location = New System.Drawing.Point(246, 99)
        Me.lblSelectContrastName.Name = "lblSelectContrastName"
        Me.lblSelectContrastName.Size = New System.Drawing.Size(113, 13)
        Me.lblSelectContrastName.TabIndex = 3
        Me.lblSelectContrastName.Text = "Select Contrast Name:"
        '
        'lblDefineContrast
        '
        Me.lblDefineContrast.AutoSize = True
        Me.lblDefineContrast.Location = New System.Drawing.Point(445, 20)
        Me.lblDefineContrast.Name = "lblDefineContrast"
        Me.lblDefineContrast.Size = New System.Drawing.Size(92, 13)
        Me.lblDefineContrast.TabIndex = 5
        Me.lblDefineContrast.Text = "Define a Contrast:"
        '
        'grdLayoutForContrasts
        '
        Me.grdLayoutForContrasts.BackColor = System.Drawing.Color.White
        Me.grdLayoutForContrasts.ColumnHeaderContextMenuStrip = Nothing
        Me.grdLayoutForContrasts.LeadHeaderContextMenuStrip = Nothing
        Me.grdLayoutForContrasts.Location = New System.Drawing.Point(445, 36)
        Me.grdLayoutForContrasts.Name = "grdLayoutForContrasts"
        Me.grdLayoutForContrasts.RowHeaderContextMenuStrip = Nothing
        Me.grdLayoutForContrasts.Script = Nothing
        Me.grdLayoutForContrasts.SheetTabContextMenuStrip = Nothing
        Me.grdLayoutForContrasts.SheetTabNewButtonVisible = True
        Me.grdLayoutForContrasts.SheetTabVisible = True
        Me.grdLayoutForContrasts.SheetTabWidth = 60
        Me.grdLayoutForContrasts.ShowScrollEndSpacing = True
        Me.grdLayoutForContrasts.Size = New System.Drawing.Size(333, 207)
        Me.grdLayoutForContrasts.TabIndex = 6
        '
        'ucrInputContrastName
        '
        Me.ucrInputContrastName.AddQuotesIfUnrecognised = True
        Me.ucrInputContrastName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputContrastName.GetSetSelectedIndex = -1
        Me.ucrInputContrastName.IsReadOnly = False
        Me.ucrInputContrastName.Location = New System.Drawing.Point(246, 114)
        Me.ucrInputContrastName.Name = "ucrInputContrastName"
        Me.ucrInputContrastName.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputContrastName.TabIndex = 4
        '
        'ucrReceiverForContrasts
        '
        Me.ucrReceiverForContrasts.AutoSize = True
        Me.ucrReceiverForContrasts.frmParent = Me
        Me.ucrReceiverForContrasts.Location = New System.Drawing.Point(246, 63)
        Me.ucrReceiverForContrasts.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForContrasts.Name = "ucrReceiverForContrasts"
        Me.ucrReceiverForContrasts.Selector = Nothing
        Me.ucrReceiverForContrasts.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverForContrasts.strNcFilePath = ""
        Me.ucrReceiverForContrasts.TabIndex = 2
        Me.ucrReceiverForContrasts.ucrSelector = Nothing
        '
        'ucrSelectorForContrast
        '
        Me.ucrSelectorForContrast.AutoSize = True
        Me.ucrSelectorForContrast.bDropUnusedFilterLevels = False
        Me.ucrSelectorForContrast.bShowHiddenColumns = False
        Me.ucrSelectorForContrast.bUseCurrentFilter = True
        Me.ucrSelectorForContrast.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorForContrast.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForContrast.Name = "ucrSelectorForContrast"
        Me.ucrSelectorForContrast.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForContrast.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(13, 200)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 7
        '
        'dlgContrasts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(792, 255)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Contrasts"
        Me.Text = "Contrasts"
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
