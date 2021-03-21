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
Partial Class ucrGeomListWithParameters
    Inherits instat.ucrGeom

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrGeomListWithParameters))
        Me.ucrGeomWithAesSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblAesList = New System.Windows.Forms.Label()
        Me.ucrReceiverParam1 = New instat.ucrReceiverSingle()
        Me.ucrReceiverParam2 = New instat.ucrReceiverSingle()
        Me.ucrReceiverParam3 = New instat.ucrReceiverSingle()
        Me.ucrReceiverParam4 = New instat.ucrReceiverSingle()
        Me.ucrReceiverParam5 = New instat.ucrReceiverSingle()
        Me.grpAesList = New System.Windows.Forms.GroupBox()
        Me.lblGgParam13 = New System.Windows.Forms.Label()
        Me.ucrReceiverParam13 = New instat.ucrReceiverSingle()
        Me.lblGgParam12 = New System.Windows.Forms.Label()
        Me.ucrReceiverParam12 = New instat.ucrReceiverSingle()
        Me.lblGgParam11 = New System.Windows.Forms.Label()
        Me.ucrReceiverParam11 = New instat.ucrReceiverSingle()
        Me.lblGgParam6 = New System.Windows.Forms.Label()
        Me.lblGgParam10 = New System.Windows.Forms.Label()
        Me.lblGgParam9 = New System.Windows.Forms.Label()
        Me.lblGgParam8 = New System.Windows.Forms.Label()
        Me.lblGgParam7 = New System.Windows.Forms.Label()
        Me.lblGgParam5 = New System.Windows.Forms.Label()
        Me.lblGgParam4 = New System.Windows.Forms.Label()
        Me.lblGgParam3 = New System.Windows.Forms.Label()
        Me.lblGgParam2 = New System.Windows.Forms.Label()
        Me.lblGgParam1 = New System.Windows.Forms.Label()
        Me.ucrReceiverParam10 = New instat.ucrReceiverSingle()
        Me.ucrReceiverParam9 = New instat.ucrReceiverSingle()
        Me.ucrReceiverParam8 = New instat.ucrReceiverSingle()
        Me.ucrReceiverParam7 = New instat.ucrReceiverSingle()
        Me.ucrReceiverParam6 = New instat.ucrReceiverSingle()
        Me.ucrChkIgnoreGlobalAes = New instat.ucrCheck()
        Me.ucrChkApplyOnAllLayers = New instat.ucrCheck()
        Me.grpAesList.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrGeomWithAesSelector
        '
        Me.ucrGeomWithAesSelector.bShowHiddenColumns = False
        Me.ucrGeomWithAesSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrGeomWithAesSelector, "ucrGeomWithAesSelector")
        Me.ucrGeomWithAesSelector.Name = "ucrGeomWithAesSelector"
        '
        'lblAesList
        '
        resources.ApplyResources(Me.lblAesList, "lblAesList")
        Me.lblAesList.Name = "lblAesList"
        '
        'ucrReceiverParam1
        '
        Me.ucrReceiverParam1.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverParam1, "ucrReceiverParam1")
        Me.ucrReceiverParam1.Name = "ucrReceiverParam1"
        Me.ucrReceiverParam1.Selector = Nothing
        Me.ucrReceiverParam1.strNcFilePath = ""
        Me.ucrReceiverParam1.ucrSelector = Nothing
        '
        'ucrReceiverParam2
        '
        Me.ucrReceiverParam2.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverParam2, "ucrReceiverParam2")
        Me.ucrReceiverParam2.Name = "ucrReceiverParam2"
        Me.ucrReceiverParam2.Selector = Nothing
        Me.ucrReceiverParam2.strNcFilePath = ""
        Me.ucrReceiverParam2.ucrSelector = Nothing
        '
        'ucrReceiverParam3
        '
        Me.ucrReceiverParam3.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverParam3, "ucrReceiverParam3")
        Me.ucrReceiverParam3.Name = "ucrReceiverParam3"
        Me.ucrReceiverParam3.Selector = Nothing
        Me.ucrReceiverParam3.strNcFilePath = ""
        Me.ucrReceiverParam3.ucrSelector = Nothing
        '
        'ucrReceiverParam4
        '
        Me.ucrReceiverParam4.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverParam4, "ucrReceiverParam4")
        Me.ucrReceiverParam4.Name = "ucrReceiverParam4"
        Me.ucrReceiverParam4.Selector = Nothing
        Me.ucrReceiverParam4.strNcFilePath = ""
        Me.ucrReceiverParam4.ucrSelector = Nothing
        '
        'ucrReceiverParam5
        '
        Me.ucrReceiverParam5.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverParam5, "ucrReceiverParam5")
        Me.ucrReceiverParam5.Name = "ucrReceiverParam5"
        Me.ucrReceiverParam5.Selector = Nothing
        Me.ucrReceiverParam5.strNcFilePath = ""
        Me.ucrReceiverParam5.ucrSelector = Nothing
        '
        'grpAesList
        '
        Me.grpAesList.Controls.Add(Me.lblGgParam13)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam13)
        Me.grpAesList.Controls.Add(Me.lblGgParam12)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam12)
        Me.grpAesList.Controls.Add(Me.lblGgParam11)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam11)
        Me.grpAesList.Controls.Add(Me.lblGgParam6)
        Me.grpAesList.Controls.Add(Me.lblGgParam10)
        Me.grpAesList.Controls.Add(Me.lblGgParam9)
        Me.grpAesList.Controls.Add(Me.lblGgParam8)
        Me.grpAesList.Controls.Add(Me.lblGgParam7)
        Me.grpAesList.Controls.Add(Me.lblGgParam5)
        Me.grpAesList.Controls.Add(Me.lblGgParam4)
        Me.grpAesList.Controls.Add(Me.lblGgParam3)
        Me.grpAesList.Controls.Add(Me.lblGgParam2)
        Me.grpAesList.Controls.Add(Me.lblGgParam1)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam10)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam9)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam8)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam1)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam7)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam5)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam6)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam4)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam3)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam2)
        resources.ApplyResources(Me.grpAesList, "grpAesList")
        Me.grpAesList.Name = "grpAesList"
        Me.grpAesList.TabStop = False
        '
        'lblGgParam13
        '
        resources.ApplyResources(Me.lblGgParam13, "lblGgParam13")
        Me.lblGgParam13.Name = "lblGgParam13"
        '
        'ucrReceiverParam13
        '
        Me.ucrReceiverParam13.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverParam13, "ucrReceiverParam13")
        Me.ucrReceiverParam13.Name = "ucrReceiverParam13"
        Me.ucrReceiverParam13.Selector = Nothing
        Me.ucrReceiverParam13.strNcFilePath = ""
        Me.ucrReceiverParam13.ucrSelector = Nothing
        '
        'lblGgParam12
        '
        resources.ApplyResources(Me.lblGgParam12, "lblGgParam12")
        Me.lblGgParam12.Name = "lblGgParam12"
        '
        'ucrReceiverParam12
        '
        Me.ucrReceiverParam12.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverParam12, "ucrReceiverParam12")
        Me.ucrReceiverParam12.Name = "ucrReceiverParam12"
        Me.ucrReceiverParam12.Selector = Nothing
        Me.ucrReceiverParam12.strNcFilePath = ""
        Me.ucrReceiverParam12.ucrSelector = Nothing
        '
        'lblGgParam11
        '
        resources.ApplyResources(Me.lblGgParam11, "lblGgParam11")
        Me.lblGgParam11.Name = "lblGgParam11"
        '
        'ucrReceiverParam11
        '
        Me.ucrReceiverParam11.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverParam11, "ucrReceiverParam11")
        Me.ucrReceiverParam11.Name = "ucrReceiverParam11"
        Me.ucrReceiverParam11.Selector = Nothing
        Me.ucrReceiverParam11.strNcFilePath = ""
        Me.ucrReceiverParam11.ucrSelector = Nothing
        '
        'lblGgParam6
        '
        resources.ApplyResources(Me.lblGgParam6, "lblGgParam6")
        Me.lblGgParam6.Name = "lblGgParam6"
        '
        'lblGgParam10
        '
        resources.ApplyResources(Me.lblGgParam10, "lblGgParam10")
        Me.lblGgParam10.Name = "lblGgParam10"
        '
        'lblGgParam9
        '
        resources.ApplyResources(Me.lblGgParam9, "lblGgParam9")
        Me.lblGgParam9.Name = "lblGgParam9"
        '
        'lblGgParam8
        '
        resources.ApplyResources(Me.lblGgParam8, "lblGgParam8")
        Me.lblGgParam8.Name = "lblGgParam8"
        '
        'lblGgParam7
        '
        resources.ApplyResources(Me.lblGgParam7, "lblGgParam7")
        Me.lblGgParam7.Name = "lblGgParam7"
        '
        'lblGgParam5
        '
        resources.ApplyResources(Me.lblGgParam5, "lblGgParam5")
        Me.lblGgParam5.Name = "lblGgParam5"
        '
        'lblGgParam4
        '
        resources.ApplyResources(Me.lblGgParam4, "lblGgParam4")
        Me.lblGgParam4.Name = "lblGgParam4"
        '
        'lblGgParam3
        '
        resources.ApplyResources(Me.lblGgParam3, "lblGgParam3")
        Me.lblGgParam3.Name = "lblGgParam3"
        '
        'lblGgParam2
        '
        resources.ApplyResources(Me.lblGgParam2, "lblGgParam2")
        Me.lblGgParam2.Name = "lblGgParam2"
        '
        'lblGgParam1
        '
        resources.ApplyResources(Me.lblGgParam1, "lblGgParam1")
        Me.lblGgParam1.Name = "lblGgParam1"
        '
        'ucrReceiverParam10
        '
        Me.ucrReceiverParam10.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverParam10, "ucrReceiverParam10")
        Me.ucrReceiverParam10.Name = "ucrReceiverParam10"
        Me.ucrReceiverParam10.Selector = Nothing
        Me.ucrReceiverParam10.strNcFilePath = ""
        Me.ucrReceiverParam10.ucrSelector = Nothing
        '
        'ucrReceiverParam9
        '
        Me.ucrReceiverParam9.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverParam9, "ucrReceiverParam9")
        Me.ucrReceiverParam9.Name = "ucrReceiverParam9"
        Me.ucrReceiverParam9.Selector = Nothing
        Me.ucrReceiverParam9.strNcFilePath = ""
        Me.ucrReceiverParam9.ucrSelector = Nothing
        '
        'ucrReceiverParam8
        '
        Me.ucrReceiverParam8.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverParam8, "ucrReceiverParam8")
        Me.ucrReceiverParam8.Name = "ucrReceiverParam8"
        Me.ucrReceiverParam8.Selector = Nothing
        Me.ucrReceiverParam8.strNcFilePath = ""
        Me.ucrReceiverParam8.ucrSelector = Nothing
        '
        'ucrReceiverParam7
        '
        Me.ucrReceiverParam7.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverParam7, "ucrReceiverParam7")
        Me.ucrReceiverParam7.Name = "ucrReceiverParam7"
        Me.ucrReceiverParam7.Selector = Nothing
        Me.ucrReceiverParam7.strNcFilePath = ""
        Me.ucrReceiverParam7.ucrSelector = Nothing
        '
        'ucrReceiverParam6
        '
        Me.ucrReceiverParam6.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverParam6, "ucrReceiverParam6")
        Me.ucrReceiverParam6.Name = "ucrReceiverParam6"
        Me.ucrReceiverParam6.Selector = Nothing
        Me.ucrReceiverParam6.strNcFilePath = ""
        Me.ucrReceiverParam6.ucrSelector = Nothing
        '
        'ucrChkIgnoreGlobalAes
        '
        Me.ucrChkIgnoreGlobalAes.Checked = False
        resources.ApplyResources(Me.ucrChkIgnoreGlobalAes, "ucrChkIgnoreGlobalAes")
        Me.ucrChkIgnoreGlobalAes.Name = "ucrChkIgnoreGlobalAes"
        '
        'ucrChkApplyOnAllLayers
        '
        Me.ucrChkApplyOnAllLayers.Checked = False
        resources.ApplyResources(Me.ucrChkApplyOnAllLayers, "ucrChkApplyOnAllLayers")
        Me.ucrChkApplyOnAllLayers.Name = "ucrChkApplyOnAllLayers"
        '
        'ucrGeomListWithParameters
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.ucrChkApplyOnAllLayers)
        Me.Controls.Add(Me.ucrChkIgnoreGlobalAes)
        Me.Controls.Add(Me.grpAesList)
        Me.Controls.Add(Me.lblAesList)
        Me.Controls.Add(Me.ucrGeomWithAesSelector)
        Me.Name = "ucrGeomListWithParameters"
        Me.Controls.SetChildIndex(Me.ucrGeomWithAesSelector, 0)
        Me.Controls.SetChildIndex(Me.lblAesList, 0)
        Me.Controls.SetChildIndex(Me.grpAesList, 0)
        Me.Controls.SetChildIndex(Me.ucrChkIgnoreGlobalAes, 0)
        Me.Controls.SetChildIndex(Me.ucrChkApplyOnAllLayers, 0)
        Me.grpAesList.ResumeLayout(False)
        Me.grpAesList.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrGeomWithAesSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblAesList As Label
    Friend WithEvents ucrReceiverParam1 As ucrReceiverSingle
    Friend WithEvents ucrReceiverParam2 As ucrReceiverSingle
    Friend WithEvents ucrReceiverParam3 As ucrReceiverSingle
    Friend WithEvents ucrReceiverParam4 As ucrReceiverSingle
    Friend WithEvents ucrReceiverParam5 As ucrReceiverSingle
    Friend WithEvents grpAesList As GroupBox
    Friend WithEvents ucrReceiverParam7 As ucrReceiverSingle
    Friend WithEvents ucrReceiverParam6 As ucrReceiverSingle
    Friend WithEvents lblGgParam6 As Label
    Friend WithEvents lblGgParam7 As Label
    Friend WithEvents lblGgParam5 As Label
    Friend WithEvents lblGgParam4 As Label
    Friend WithEvents lblGgParam3 As Label
    Friend WithEvents lblGgParam2 As Label
    Friend WithEvents lblGgParam1 As Label
    Friend WithEvents lblGgParam9 As Label
    Friend WithEvents lblGgParam8 As Label
    Friend WithEvents ucrReceiverParam9 As ucrReceiverSingle
    Friend WithEvents ucrReceiverParam8 As ucrReceiverSingle
    Friend WithEvents lblGgParam10 As Label
    Friend WithEvents ucrReceiverParam10 As ucrReceiverSingle
    Friend WithEvents lblGgParam13 As Label
    Friend WithEvents ucrReceiverParam13 As ucrReceiverSingle
    Friend WithEvents lblGgParam12 As Label
    Friend WithEvents ucrReceiverParam12 As ucrReceiverSingle
    Friend WithEvents lblGgParam11 As Label
    Friend WithEvents ucrReceiverParam11 As ucrReceiverSingle
    Friend WithEvents ucrChkIgnoreGlobalAes As ucrCheck
    Friend WithEvents ucrChkApplyOnAllLayers As ucrCheck
End Class
