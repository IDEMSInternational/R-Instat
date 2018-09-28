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
Partial Class dlgColumnStructure
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgColumnStructure))
        Me.lblMeasurement = New System.Windows.Forms.Label()
        Me.lblTreatment = New System.Windows.Forms.Label()
        Me.lblLayout = New System.Windows.Forms.Label()
        Me.ucrChkColourColumnsByStructure = New instat.ucrCheck()
        Me.ucrReceiverMeasurement = New instat.ucrReceiverMultiple()
        Me.ucrReceiverTreatment = New instat.ucrReceiverMultiple()
        Me.ucrReceiverLayout = New instat.ucrReceiverMultiple()
        Me.ucrSelectorColumnStructure = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblMeasurement
        '
        resources.ApplyResources(Me.lblMeasurement, "lblMeasurement")
        Me.lblMeasurement.Name = "lblMeasurement"
        '
        'lblTreatment
        '
        resources.ApplyResources(Me.lblTreatment, "lblTreatment")
        Me.lblTreatment.Name = "lblTreatment"
        '
        'lblLayout
        '
        resources.ApplyResources(Me.lblLayout, "lblLayout")
        Me.lblLayout.Name = "lblLayout"
        '
        'ucrChkColourColumnsByStructure
        '
        Me.ucrChkColourColumnsByStructure.Checked = False
        resources.ApplyResources(Me.ucrChkColourColumnsByStructure, "ucrChkColourColumnsByStructure")
        Me.ucrChkColourColumnsByStructure.Name = "ucrChkColourColumnsByStructure"
        '
        'ucrReceiverMeasurement
        '
        Me.ucrReceiverMeasurement.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMeasurement, "ucrReceiverMeasurement")
        Me.ucrReceiverMeasurement.Name = "ucrReceiverMeasurement"
        Me.ucrReceiverMeasurement.Selector = Nothing
        Me.ucrReceiverMeasurement.strNcFilePath = ""
        Me.ucrReceiverMeasurement.ucrSelector = Nothing
        '
        'ucrReceiverTreatment
        '
        Me.ucrReceiverTreatment.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverTreatment, "ucrReceiverTreatment")
        Me.ucrReceiverTreatment.Name = "ucrReceiverTreatment"
        Me.ucrReceiverTreatment.Selector = Nothing
        Me.ucrReceiverTreatment.strNcFilePath = ""
        Me.ucrReceiverTreatment.ucrSelector = Nothing
        '
        'ucrReceiverLayout
        '
        Me.ucrReceiverLayout.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverLayout, "ucrReceiverLayout")
        Me.ucrReceiverLayout.Name = "ucrReceiverLayout"
        Me.ucrReceiverLayout.Selector = Nothing
        Me.ucrReceiverLayout.strNcFilePath = ""
        Me.ucrReceiverLayout.ucrSelector = Nothing
        '
        'ucrSelectorColumnStructure
        '
        Me.ucrSelectorColumnStructure.bShowHiddenColumns = False
        Me.ucrSelectorColumnStructure.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorColumnStructure, "ucrSelectorColumnStructure")
        Me.ucrSelectorColumnStructure.Name = "ucrSelectorColumnStructure"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgColumnStructure
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkColourColumnsByStructure)
        Me.Controls.Add(Me.lblMeasurement)
        Me.Controls.Add(Me.lblTreatment)
        Me.Controls.Add(Me.lblLayout)
        Me.Controls.Add(Me.ucrReceiverMeasurement)
        Me.Controls.Add(Me.ucrReceiverTreatment)
        Me.Controls.Add(Me.ucrReceiverLayout)
        Me.Controls.Add(Me.ucrSelectorColumnStructure)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgColumnStructure"
        Me.Tag = "Column_Structure"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMeasurement As Label
    Friend WithEvents lblTreatment As Label
    Friend WithEvents lblLayout As Label
    Friend WithEvents ucrReceiverMeasurement As ucrReceiverMultiple
    Friend WithEvents ucrReceiverTreatment As ucrReceiverMultiple
    Friend WithEvents ucrReceiverLayout As ucrReceiverMultiple
    Friend WithEvents ucrSelectorColumnStructure As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkColourColumnsByStructure As ucrCheck
End Class
