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
Partial Class sdgMerge
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgMerge))
        Me.ttJoinDetails = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrSubBase = New instat.ucrButtonsSubdialogue()
        Me.ucrSelectorSecondDF = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSelectorFirstDF = New instat.ucrSelectorByDataFrameAddRemove()
        Me.pnlKeyColumns = New System.Windows.Forms.Panel()
        Me.cmdRemoveAll = New System.Windows.Forms.Button()
        Me.lstKeyColumns = New System.Windows.Forms.ListView()
        Me.lblKeyColumns = New System.Windows.Forms.Label()
        Me.cmdRemoveSelectedPair = New System.Windows.Forms.Button()
        Me.grpKeys = New System.Windows.Forms.GroupBox()
        Me.cmdAddPair = New System.Windows.Forms.Button()
        Me.lblFirstKeyMatch = New System.Windows.Forms.Label()
        Me.ucrReceiverSecondDF = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstDF = New instat.ucrReceiverSingle()
        Me.pnlKeyColumns.SuspendLayout()
        Me.grpKeys.SuspendLayout()
        Me.SuspendLayout()
        '
        'ttJoinDetails
        '
        Me.ttJoinDetails.AutoPopDelay = 10000
        Me.ttJoinDetails.InitialDelay = 500
        Me.ttJoinDetails.ReshowDelay = 100
        '
        'ucrSubBase
        '
        resources.ApplyResources(Me.ucrSubBase, "ucrSubBase")
        Me.ucrSubBase.Name = "ucrSubBase"
        '
        'ucrSelectorSecondDF
        '
        Me.ucrSelectorSecondDF.bDropUnusedFilterLevels = False
        Me.ucrSelectorSecondDF.bShowHiddenColumns = False
        Me.ucrSelectorSecondDF.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorSecondDF, "ucrSelectorSecondDF")
        Me.ucrSelectorSecondDF.Name = "ucrSelectorSecondDF"
        '
        'ucrSelectorFirstDF
        '
        Me.ucrSelectorFirstDF.bDropUnusedFilterLevels = False
        Me.ucrSelectorFirstDF.bShowHiddenColumns = False
        Me.ucrSelectorFirstDF.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorFirstDF, "ucrSelectorFirstDF")
        Me.ucrSelectorFirstDF.Name = "ucrSelectorFirstDF"
        '
        'pnlKeyColumns
        '
        Me.pnlKeyColumns.Controls.Add(Me.cmdRemoveAll)
        Me.pnlKeyColumns.Controls.Add(Me.lstKeyColumns)
        Me.pnlKeyColumns.Controls.Add(Me.lblKeyColumns)
        Me.pnlKeyColumns.Controls.Add(Me.cmdRemoveSelectedPair)
        resources.ApplyResources(Me.pnlKeyColumns, "pnlKeyColumns")
        Me.pnlKeyColumns.Name = "pnlKeyColumns"
        '
        'cmdRemoveAll
        '
        resources.ApplyResources(Me.cmdRemoveAll, "cmdRemoveAll")
        Me.cmdRemoveAll.Name = "cmdRemoveAll"
        Me.cmdRemoveAll.UseVisualStyleBackColor = True
        '
        'lstKeyColumns
        '
        Me.lstKeyColumns.FullRowSelect = True
        Me.lstKeyColumns.HideSelection = False
        resources.ApplyResources(Me.lstKeyColumns, "lstKeyColumns")
        Me.lstKeyColumns.Name = "lstKeyColumns"
        Me.lstKeyColumns.UseCompatibleStateImageBehavior = False
        Me.lstKeyColumns.View = System.Windows.Forms.View.Details
        '
        'lblKeyColumns
        '
        resources.ApplyResources(Me.lblKeyColumns, "lblKeyColumns")
        Me.lblKeyColumns.Name = "lblKeyColumns"
        '
        'cmdRemoveSelectedPair
        '
        resources.ApplyResources(Me.cmdRemoveSelectedPair, "cmdRemoveSelectedPair")
        Me.cmdRemoveSelectedPair.Name = "cmdRemoveSelectedPair"
        Me.cmdRemoveSelectedPair.UseVisualStyleBackColor = True
        '
        'grpKeys
        '
        Me.grpKeys.Controls.Add(Me.cmdAddPair)
        Me.grpKeys.Controls.Add(Me.lblFirstKeyMatch)
        Me.grpKeys.Controls.Add(Me.ucrReceiverSecondDF)
        Me.grpKeys.Controls.Add(Me.ucrReceiverFirstDF)
        resources.ApplyResources(Me.grpKeys, "grpKeys")
        Me.grpKeys.Name = "grpKeys"
        Me.grpKeys.TabStop = False
        '
        'cmdAddPair
        '
        resources.ApplyResources(Me.cmdAddPair, "cmdAddPair")
        Me.cmdAddPair.Name = "cmdAddPair"
        Me.cmdAddPair.UseVisualStyleBackColor = True
        '
        'lblFirstKeyMatch
        '
        resources.ApplyResources(Me.lblFirstKeyMatch, "lblFirstKeyMatch")
        Me.lblFirstKeyMatch.Name = "lblFirstKeyMatch"
        '
        'ucrReceiverSecondDF
        '
        Me.ucrReceiverSecondDF.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSecondDF, "ucrReceiverSecondDF")
        Me.ucrReceiverSecondDF.Name = "ucrReceiverSecondDF"
        Me.ucrReceiverSecondDF.Selector = Nothing
        Me.ucrReceiverSecondDF.strNcFilePath = ""
        Me.ucrReceiverSecondDF.ucrSelector = Nothing
        '
        'ucrReceiverFirstDF
        '
        Me.ucrReceiverFirstDF.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFirstDF, "ucrReceiverFirstDF")
        Me.ucrReceiverFirstDF.Name = "ucrReceiverFirstDF"
        Me.ucrReceiverFirstDF.Selector = Nothing
        Me.ucrReceiverFirstDF.strNcFilePath = ""
        Me.ucrReceiverFirstDF.ucrSelector = Nothing
        '
        'sdgMerge
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSelectorSecondDF)
        Me.Controls.Add(Me.ucrSelectorFirstDF)
        Me.Controls.Add(Me.pnlKeyColumns)
        Me.Controls.Add(Me.grpKeys)
        Me.Controls.Add(Me.ucrSubBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgMerge"
        Me.pnlKeyColumns.ResumeLayout(False)
        Me.pnlKeyColumns.PerformLayout()
        Me.grpKeys.ResumeLayout(False)
        Me.grpKeys.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSubBase As ucrButtonsSubdialogue
    Friend WithEvents ttJoinDetails As ToolTip
    Friend WithEvents ucrSelectorSecondDF As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectorFirstDF As ucrSelectorByDataFrameAddRemove
    Friend WithEvents pnlKeyColumns As Panel
    Friend WithEvents cmdRemoveAll As Button
    Friend WithEvents lstKeyColumns As ListView
    Friend WithEvents lblKeyColumns As Label
    Friend WithEvents cmdRemoveSelectedPair As Button
    Friend WithEvents grpKeys As GroupBox
    Friend WithEvents cmdAddPair As Button
    Friend WithEvents lblFirstKeyMatch As Label
    Friend WithEvents ucrReceiverSecondDF As ucrReceiverSingle
    Friend WithEvents ucrReceiverFirstDF As ucrReceiverSingle
End Class
