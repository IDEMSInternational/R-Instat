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
Partial Class dlgClimdexIndices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgClimdexIndices))
        Me.lblTmax = New System.Windows.Forms.Label()
        Me.lblTmin = New System.Windows.Forms.Label()
        Me.lblPrec = New System.Windows.Forms.Label()
        Me.cmdIndices = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverPrec = New instat.ucrReceiverSingle()
        Me.ucrReceiverTmin = New instat.ucrReceiverSingle()
        Me.ucrReceiverTmax = New instat.ucrReceiverSingle()
        Me.ucrSelectorClimdex = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkSave = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblTmax
        '
        resources.ApplyResources(Me.lblTmax, "lblTmax")
        Me.lblTmax.Name = "lblTmax"
        Me.lblTmax.Tag = "Maximum Temperature:"
        '
        'lblTmin
        '
        resources.ApplyResources(Me.lblTmin, "lblTmin")
        Me.lblTmin.Name = "lblTmin"
        Me.lblTmin.Tag = "Minimum Temperature:"
        '
        'lblPrec
        '
        resources.ApplyResources(Me.lblPrec, "lblPrec")
        Me.lblPrec.Name = "lblPrec"
        Me.lblPrec.Tag = "Rainfall:"
        '
        'cmdIndices
        '
        resources.ApplyResources(Me.cmdIndices, "cmdIndices")
        Me.cmdIndices.Name = "cmdIndices"
        Me.cmdIndices.Tag = "Indices..."
        Me.cmdIndices.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Tag = "Date:"
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDate, "ucrReceiverDate")
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverPrec
        '
        Me.ucrReceiverPrec.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverPrec, "ucrReceiverPrec")
        Me.ucrReceiverPrec.Name = "ucrReceiverPrec"
        Me.ucrReceiverPrec.Selector = Nothing
        Me.ucrReceiverPrec.strNcFilePath = ""
        Me.ucrReceiverPrec.ucrSelector = Nothing
        '
        'ucrReceiverTmin
        '
        Me.ucrReceiverTmin.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverTmin, "ucrReceiverTmin")
        Me.ucrReceiverTmin.Name = "ucrReceiverTmin"
        Me.ucrReceiverTmin.Selector = Nothing
        Me.ucrReceiverTmin.strNcFilePath = ""
        Me.ucrReceiverTmin.ucrSelector = Nothing
        '
        'ucrReceiverTmax
        '
        Me.ucrReceiverTmax.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverTmax, "ucrReceiverTmax")
        Me.ucrReceiverTmax.Name = "ucrReceiverTmax"
        Me.ucrReceiverTmax.Selector = Nothing
        Me.ucrReceiverTmax.strNcFilePath = ""
        Me.ucrReceiverTmax.ucrSelector = Nothing
        '
        'ucrSelectorClimdex
        '
        Me.ucrSelectorClimdex.bShowHiddenColumns = False
        Me.ucrSelectorClimdex.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorClimdex, "ucrSelectorClimdex")
        Me.ucrSelectorClimdex.Name = "ucrSelectorClimdex"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrChkSave
        '
        Me.ucrChkSave.Checked = False
        resources.ApplyResources(Me.ucrChkSave, "ucrChkSave")
        Me.ucrChkSave.Name = "ucrChkSave"
        '
        'dlgClimdexIndices
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkSave)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.cmdIndices)
        Me.Controls.Add(Me.lblPrec)
        Me.Controls.Add(Me.lblTmin)
        Me.Controls.Add(Me.lblTmax)
        Me.Controls.Add(Me.ucrReceiverPrec)
        Me.Controls.Add(Me.ucrReceiverTmin)
        Me.Controls.Add(Me.ucrReceiverTmax)
        Me.Controls.Add(Me.ucrSelectorClimdex)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimdexIndices"
        Me.Tag = "Climdex Indices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons

    Friend WithEvents ucrSelectorClimdex As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverTmax As ucrReceiverSingle
    Friend WithEvents ucrReceiverTmin As ucrReceiverSingle
    Friend WithEvents ucrReceiverPrec As ucrReceiverSingle
    Friend WithEvents lblTmax As Label
    Friend WithEvents lblTmin As Label
    Friend WithEvents lblPrec As Label
    Friend WithEvents cmdIndices As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrChkSave As ucrCheck
End Class