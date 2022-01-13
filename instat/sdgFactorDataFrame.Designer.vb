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
        Me.ucrBaseFactorSubdlg.AutoSize = True
        Me.ucrBaseFactorSubdlg.Location = New System.Drawing.Point(120, 228)
        Me.ucrBaseFactorSubdlg.Name = "ucrBaseFactorSubdlg"
        Me.ucrBaseFactorSubdlg.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseFactorSubdlg.TabIndex = 0
        '
        'ucrSelectorSubDlgFactorDatafrme
        '
        Me.ucrSelectorSubDlgFactorDatafrme.AutoSize = True
        Me.ucrSelectorSubDlgFactorDatafrme.bDropUnusedFilterLevels = False
        Me.ucrSelectorSubDlgFactorDatafrme.bShowHiddenColumns = False
        Me.ucrSelectorSubDlgFactorDatafrme.bUseCurrentFilter = True
        Me.ucrSelectorSubDlgFactorDatafrme.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorSubDlgFactorDatafrme.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSubDlgFactorDatafrme.Name = "ucrSelectorSubDlgFactorDatafrme"
        Me.ucrSelectorSubDlgFactorDatafrme.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorSubDlgFactorDatafrme.TabIndex = 1
        '
        'ucrReceiverLabels
        '
        Me.ucrReceiverLabels.AutoSize = True
        Me.ucrReceiverLabels.frmParent = Me
        Me.ucrReceiverLabels.Location = New System.Drawing.Point(252, 110)
        Me.ucrReceiverLabels.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLabels.Name = "ucrReceiverLabels"
        Me.ucrReceiverLabels.Selector = Nothing
        Me.ucrReceiverLabels.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverLabels.strNcFilePath = ""
        Me.ucrReceiverLabels.TabIndex = 2
        Me.ucrReceiverLabels.ucrSelector = Nothing
        '
        'ucrReceiverMatchColumn
        '
        Me.ucrReceiverMatchColumn.AutoSize = True
        Me.ucrReceiverMatchColumn.frmParent = Me
        Me.ucrReceiverMatchColumn.Location = New System.Drawing.Point(252, 51)
        Me.ucrReceiverMatchColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMatchColumn.Name = "ucrReceiverMatchColumn"
        Me.ucrReceiverMatchColumn.Selector = Nothing
        Me.ucrReceiverMatchColumn.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMatchColumn.strNcFilePath = ""
        Me.ucrReceiverMatchColumn.TabIndex = 2
        Me.ucrReceiverMatchColumn.ucrSelector = Nothing
        '
        'lblMatchingColumn
        '
        Me.lblMatchingColumn.AutoSize = True
        Me.lblMatchingColumn.Location = New System.Drawing.Point(249, 36)
        Me.lblMatchingColumn.Name = "lblMatchingColumn"
        Me.lblMatchingColumn.Size = New System.Drawing.Size(137, 13)
        Me.lblMatchingColumn.TabIndex = 3
        Me.lblMatchingColumn.Text = "Matching Column (Optional)"
        '
        'lbllabel
        '
        Me.lbllabel.AutoSize = True
        Me.lbllabel.Location = New System.Drawing.Point(249, 95)
        Me.lbllabel.Name = "lbllabel"
        Me.lbllabel.Size = New System.Drawing.Size(122, 13)
        Me.lbllabel.TabIndex = 3
        Me.lbllabel.Text = "Levels/Labels (Optional)"
        '
        'sdgFactorDataFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(399, 261)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Use Factor Sheet"
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
