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
        Me.ucrSubBase.AutoSize = True
        Me.ucrSubBase.Location = New System.Drawing.Point(249, 292)
        Me.ucrSubBase.Name = "ucrSubBase"
        Me.ucrSubBase.Size = New System.Drawing.Size(224, 30)
        Me.ucrSubBase.TabIndex = 4
        '
        'ucrSelectorSecondDF
        '
        Me.ucrSelectorSecondDF.AutoSize = True
        Me.ucrSelectorSecondDF.bDropUnusedFilterLevels = False
        Me.ucrSelectorSecondDF.bShowHiddenColumns = False
        Me.ucrSelectorSecondDF.bUseCurrentFilter = True
        Me.ucrSelectorSecondDF.Location = New System.Drawing.Point(226, 18)
        Me.ucrSelectorSecondDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSecondDF.Name = "ucrSelectorSecondDF"
        Me.ucrSelectorSecondDF.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorSecondDF.TabIndex = 1
        '
        'ucrSelectorFirstDF
        '
        Me.ucrSelectorFirstDF.AutoSize = True
        Me.ucrSelectorFirstDF.bDropUnusedFilterLevels = False
        Me.ucrSelectorFirstDF.bShowHiddenColumns = False
        Me.ucrSelectorFirstDF.bUseCurrentFilter = True
        Me.ucrSelectorFirstDF.Location = New System.Drawing.Point(10, 18)
        Me.ucrSelectorFirstDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFirstDF.Name = "ucrSelectorFirstDF"
        Me.ucrSelectorFirstDF.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorFirstDF.TabIndex = 0
        '
        'pnlKeyColumns
        '
        Me.pnlKeyColumns.Controls.Add(Me.cmdRemoveAll)
        Me.pnlKeyColumns.Controls.Add(Me.lstKeyColumns)
        Me.pnlKeyColumns.Controls.Add(Me.lblKeyColumns)
        Me.pnlKeyColumns.Controls.Add(Me.cmdRemoveSelectedPair)
        Me.pnlKeyColumns.Location = New System.Drawing.Point(443, 26)
        Me.pnlKeyColumns.Name = "pnlKeyColumns"
        Me.pnlKeyColumns.Size = New System.Drawing.Size(194, 256)
        Me.pnlKeyColumns.TabIndex = 2
        '
        'cmdRemoveAll
        '
        Me.cmdRemoveAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRemoveAll.Location = New System.Drawing.Point(6, 223)
        Me.cmdRemoveAll.Name = "cmdRemoveAll"
        Me.cmdRemoveAll.Size = New System.Drawing.Size(130, 23)
        Me.cmdRemoveAll.TabIndex = 3
        Me.cmdRemoveAll.Text = "Remove All Pairs"
        Me.cmdRemoveAll.UseVisualStyleBackColor = True
        '
        'lstKeyColumns
        '
        Me.lstKeyColumns.FullRowSelect = True
        Me.lstKeyColumns.HideSelection = False
        Me.lstKeyColumns.Location = New System.Drawing.Point(6, 21)
        Me.lstKeyColumns.Name = "lstKeyColumns"
        Me.lstKeyColumns.Size = New System.Drawing.Size(185, 167)
        Me.lstKeyColumns.TabIndex = 1
        Me.lstKeyColumns.UseCompatibleStateImageBehavior = False
        Me.lstKeyColumns.View = System.Windows.Forms.View.Details
        '
        'lblKeyColumns
        '
        Me.lblKeyColumns.AutoSize = True
        Me.lblKeyColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblKeyColumns.Location = New System.Drawing.Point(3, 5)
        Me.lblKeyColumns.Name = "lblKeyColumns"
        Me.lblKeyColumns.Size = New System.Drawing.Size(68, 13)
        Me.lblKeyColumns.TabIndex = 0
        Me.lblKeyColumns.Text = "Key Columns"
        '
        'cmdRemoveSelectedPair
        '
        Me.cmdRemoveSelectedPair.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRemoveSelectedPair.Location = New System.Drawing.Point(6, 194)
        Me.cmdRemoveSelectedPair.Name = "cmdRemoveSelectedPair"
        Me.cmdRemoveSelectedPair.Size = New System.Drawing.Size(130, 23)
        Me.cmdRemoveSelectedPair.TabIndex = 2
        Me.cmdRemoveSelectedPair.Text = "Remove Selected Pair"
        Me.cmdRemoveSelectedPair.UseVisualStyleBackColor = True
        '
        'grpKeys
        '
        Me.grpKeys.Controls.Add(Me.cmdAddPair)
        Me.grpKeys.Controls.Add(Me.lblFirstKeyMatch)
        Me.grpKeys.Controls.Add(Me.ucrReceiverSecondDF)
        Me.grpKeys.Controls.Add(Me.ucrReceiverFirstDF)
        Me.grpKeys.Location = New System.Drawing.Point(9, 204)
        Me.grpKeys.Name = "grpKeys"
        Me.grpKeys.Size = New System.Drawing.Size(335, 76)
        Me.grpKeys.TabIndex = 3
        Me.grpKeys.TabStop = False
        Me.grpKeys.Text = "Key Columns"
        '
        'cmdAddPair
        '
        Me.cmdAddPair.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAddPair.Location = New System.Drawing.Point(4, 46)
        Me.cmdAddPair.Name = "cmdAddPair"
        Me.cmdAddPair.Size = New System.Drawing.Size(118, 23)
        Me.cmdAddPair.TabIndex = 3
        Me.cmdAddPair.Text = "Add Pair"
        Me.cmdAddPair.UseVisualStyleBackColor = True
        '
        'lblFirstKeyMatch
        '
        Me.lblFirstKeyMatch.AutoSize = True
        Me.lblFirstKeyMatch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstKeyMatch.Location = New System.Drawing.Point(128, 22)
        Me.lblFirstKeyMatch.Name = "lblFirstKeyMatch"
        Me.lblFirstKeyMatch.Size = New System.Drawing.Size(74, 13)
        Me.lblFirstKeyMatch.TabIndex = 1
        Me.lblFirstKeyMatch.Text = "Matched With"
        '
        'ucrReceiverSecondDF
        '
        Me.ucrReceiverSecondDF.AutoSize = True
        Me.ucrReceiverSecondDF.frmParent = Me
        Me.ucrReceiverSecondDF.Location = New System.Drawing.Point(205, 20)
        Me.ucrReceiverSecondDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondDF.Name = "ucrReceiverSecondDF"
        Me.ucrReceiverSecondDF.Selector = Nothing
        Me.ucrReceiverSecondDF.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSecondDF.strNcFilePath = ""
        Me.ucrReceiverSecondDF.TabIndex = 2
        Me.ucrReceiverSecondDF.ucrSelector = Nothing
        '
        'ucrReceiverFirstDF
        '
        Me.ucrReceiverFirstDF.AutoSize = True
        Me.ucrReceiverFirstDF.frmParent = Me
        Me.ucrReceiverFirstDF.Location = New System.Drawing.Point(4, 20)
        Me.ucrReceiverFirstDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstDF.Name = "ucrReceiverFirstDF"
        Me.ucrReceiverFirstDF.Selector = Nothing
        Me.ucrReceiverFirstDF.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFirstDF.strNcFilePath = ""
        Me.ucrReceiverFirstDF.TabIndex = 0
        Me.ucrReceiverFirstDF.ucrSelector = Nothing
        '
        'sdgMerge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(644, 324)
        Me.Controls.Add(Me.ucrSelectorSecondDF)
        Me.Controls.Add(Me.ucrSelectorFirstDF)
        Me.Controls.Add(Me.pnlKeyColumns)
        Me.Controls.Add(Me.grpKeys)
        Me.Controls.Add(Me.ucrSubBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgMerge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Joining Columns"
        Me.pnlKeyColumns.ResumeLayout(False)
        Me.pnlKeyColumns.PerformLayout()
        Me.grpKeys.ResumeLayout(False)
        Me.grpKeys.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
