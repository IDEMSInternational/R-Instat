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
Partial Class dlgInfill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgInfill))
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblByFactors = New System.Windows.Forms.Label()
        Me.ucrChkResort = New instat.ucrCheck()
        Me.ucrReceiverFactors = New instat.ucrReceiverMultiple()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrInfillSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
        '
        'lblByFactors
        '
        resources.ApplyResources(Me.lblByFactors, "lblByFactors")
        Me.lblByFactors.Name = "lblByFactors"
        '
        'ucrChkResort
        '
        Me.ucrChkResort.Checked = False
        resources.ApplyResources(Me.ucrChkResort, "ucrChkResort")
        Me.ucrChkResort.Name = "ucrChkResort"
        '
        'ucrReceiverFactors
        '
        Me.ucrReceiverFactors.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFactors, "ucrReceiverFactors")
        Me.ucrReceiverFactors.Name = "ucrReceiverFactors"
        Me.ucrReceiverFactors.Selector = Nothing
        Me.ucrReceiverFactors.strNcFilePath = ""
        Me.ucrReceiverFactors.ucrSelector = Nothing
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
        'ucrInfillSelector
        '
        Me.ucrInfillSelector.bShowHiddenColumns = False
        Me.ucrInfillSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrInfillSelector, "ucrInfillSelector")
        Me.ucrInfillSelector.Name = "ucrInfillSelector"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgInfill
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkResort)
        Me.Controls.Add(Me.lblByFactors)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverFactors)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrInfillSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInfill"
        Me.Tag = "Infill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInfillSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverFactors As ucrReceiverMultiple
    Friend WithEvents lblDate As Label
    Friend WithEvents lblByFactors As Label
    Friend WithEvents ucrChkResort As ucrCheck
End Class
