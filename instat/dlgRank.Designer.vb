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
Partial Class dlgRank
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRank))
        Me.lblColumnsToRank = New System.Windows.Forms.Label()
        Me.grpTies = New System.Windows.Forms.GroupBox()
        Me.rdoRandom = New System.Windows.Forms.RadioButton()
        Me.rdoFirst = New System.Windows.Forms.RadioButton()
        Me.rdoMaximum = New System.Windows.Forms.RadioButton()
        Me.rdoMinimum = New System.Windows.Forms.RadioButton()
        Me.rdoAverage = New System.Windows.Forms.RadioButton()
        Me.ucrPnlTies = New instat.UcrPanel()
        Me.grpMissingValues = New System.Windows.Forms.GroupBox()
        Me.rdoKeptAsMissing = New System.Windows.Forms.RadioButton()
        Me.rdoLast = New System.Windows.Forms.RadioButton()
        Me.rdoFirstMissingValues = New System.Windows.Forms.RadioButton()
        Me.ucrPnlMissingValues = New instat.UcrPanel()
        Me.ucrSaveRank = New instat.ucrSave()
        Me.ucrSelectorForRank = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverRank = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpTies.SuspendLayout()
        Me.grpMissingValues.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumnsToRank
        '
        resources.ApplyResources(Me.lblColumnsToRank, "lblColumnsToRank")
        Me.lblColumnsToRank.Name = "lblColumnsToRank"
        Me.lblColumnsToRank.Tag = ""
        '
        'grpTies
        '
        Me.grpTies.Controls.Add(Me.rdoRandom)
        Me.grpTies.Controls.Add(Me.rdoFirst)
        Me.grpTies.Controls.Add(Me.rdoMaximum)
        Me.grpTies.Controls.Add(Me.rdoMinimum)
        Me.grpTies.Controls.Add(Me.rdoAverage)
        Me.grpTies.Controls.Add(Me.ucrPnlTies)
        resources.ApplyResources(Me.grpTies, "grpTies")
        Me.grpTies.Name = "grpTies"
        Me.grpTies.TabStop = False
        Me.grpTies.Tag = "Ties"
        '
        'rdoRandom
        '
        resources.ApplyResources(Me.rdoRandom, "rdoRandom")
        Me.rdoRandom.Name = "rdoRandom"
        Me.rdoRandom.TabStop = True
        Me.rdoRandom.Tag = "Random"
        Me.rdoRandom.UseVisualStyleBackColor = True
        '
        'rdoFirst
        '
        resources.ApplyResources(Me.rdoFirst, "rdoFirst")
        Me.rdoFirst.Name = "rdoFirst"
        Me.rdoFirst.TabStop = True
        Me.rdoFirst.Tag = "First"
        Me.rdoFirst.UseVisualStyleBackColor = True
        '
        'rdoMaximum
        '
        resources.ApplyResources(Me.rdoMaximum, "rdoMaximum")
        Me.rdoMaximum.Name = "rdoMaximum"
        Me.rdoMaximum.TabStop = True
        Me.rdoMaximum.Tag = "Maximum"
        Me.rdoMaximum.UseVisualStyleBackColor = True
        '
        'rdoMinimum
        '
        resources.ApplyResources(Me.rdoMinimum, "rdoMinimum")
        Me.rdoMinimum.Name = "rdoMinimum"
        Me.rdoMinimum.TabStop = True
        Me.rdoMinimum.Tag = "Minimum"
        Me.rdoMinimum.UseVisualStyleBackColor = True
        '
        'rdoAverage
        '
        resources.ApplyResources(Me.rdoAverage, "rdoAverage")
        Me.rdoAverage.Name = "rdoAverage"
        Me.rdoAverage.TabStop = True
        Me.rdoAverage.Tag = "Average"
        Me.rdoAverage.UseVisualStyleBackColor = True
        '
        'ucrPnlTies
        '
        resources.ApplyResources(Me.ucrPnlTies, "ucrPnlTies")
        Me.ucrPnlTies.Name = "ucrPnlTies"
        '
        'grpMissingValues
        '
        Me.grpMissingValues.Controls.Add(Me.rdoKeptAsMissing)
        Me.grpMissingValues.Controls.Add(Me.rdoLast)
        Me.grpMissingValues.Controls.Add(Me.rdoFirstMissingValues)
        Me.grpMissingValues.Controls.Add(Me.ucrPnlMissingValues)
        resources.ApplyResources(Me.grpMissingValues, "grpMissingValues")
        Me.grpMissingValues.Name = "grpMissingValues"
        Me.grpMissingValues.TabStop = False
        Me.grpMissingValues.Tag = "Misssing_Values"
        '
        'rdoKeptAsMissing
        '
        resources.ApplyResources(Me.rdoKeptAsMissing, "rdoKeptAsMissing")
        Me.rdoKeptAsMissing.Name = "rdoKeptAsMissing"
        Me.rdoKeptAsMissing.TabStop = True
        Me.rdoKeptAsMissing.Tag = "Kept_as_missing"
        Me.rdoKeptAsMissing.UseVisualStyleBackColor = True
        '
        'rdoLast
        '
        resources.ApplyResources(Me.rdoLast, "rdoLast")
        Me.rdoLast.Name = "rdoLast"
        Me.rdoLast.TabStop = True
        Me.rdoLast.Tag = "Last"
        Me.rdoLast.UseVisualStyleBackColor = True
        '
        'rdoFirstMissingValues
        '
        resources.ApplyResources(Me.rdoFirstMissingValues, "rdoFirstMissingValues")
        Me.rdoFirstMissingValues.Name = "rdoFirstMissingValues"
        Me.rdoFirstMissingValues.TabStop = True
        Me.rdoFirstMissingValues.Tag = "First"
        Me.rdoFirstMissingValues.UseVisualStyleBackColor = True
        '
        'ucrPnlMissingValues
        '
        resources.ApplyResources(Me.ucrPnlMissingValues, "ucrPnlMissingValues")
        Me.ucrPnlMissingValues.Name = "ucrPnlMissingValues"
        '
        'ucrSaveRank
        '
        resources.ApplyResources(Me.ucrSaveRank, "ucrSaveRank")
        Me.ucrSaveRank.Name = "ucrSaveRank"
        '
        'ucrSelectorForRank
        '
        Me.ucrSelectorForRank.bShowHiddenColumns = False
        Me.ucrSelectorForRank.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForRank, "ucrSelectorForRank")
        Me.ucrSelectorForRank.Name = "ucrSelectorForRank"
        '
        'ucrReceiverRank
        '
        Me.ucrReceiverRank.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverRank, "ucrReceiverRank")
        Me.ucrReceiverRank.Name = "ucrReceiverRank"
        Me.ucrReceiverRank.Selector = Nothing
        Me.ucrReceiverRank.strNcFilePath = ""
        Me.ucrReceiverRank.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgRank
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveRank)
        Me.Controls.Add(Me.grpMissingValues)
        Me.Controls.Add(Me.grpTies)
        Me.Controls.Add(Me.ucrSelectorForRank)
        Me.Controls.Add(Me.lblColumnsToRank)
        Me.Controls.Add(Me.ucrReceiverRank)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRank"
        Me.Tag = "Rank"
        Me.grpTies.ResumeLayout(False)
        Me.grpTies.PerformLayout()
        Me.grpMissingValues.ResumeLayout(False)
        Me.grpMissingValues.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverRank As ucrReceiverSingle
    Friend WithEvents lblColumnsToRank As Label
    Friend WithEvents grpMissingValues As GroupBox
    Friend WithEvents rdoKeptAsMissing As RadioButton
    Friend WithEvents rdoLast As RadioButton
    Friend WithEvents rdoFirstMissingValues As RadioButton
    Friend WithEvents ucrSelectorForRank As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpTies As GroupBox
    Friend WithEvents rdoRandom As RadioButton
    Friend WithEvents rdoFirst As RadioButton
    Friend WithEvents rdoMaximum As RadioButton
    Friend WithEvents rdoMinimum As RadioButton
    Friend WithEvents rdoAverage As RadioButton
    Friend WithEvents ucrPnlTies As UcrPanel
    Friend WithEvents ucrPnlMissingValues As UcrPanel
    Friend WithEvents ucrSaveRank As ucrSave
End Class
