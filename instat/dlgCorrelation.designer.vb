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
Partial Class dlgCorrelation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCorrelation))
        Me.lblFirstColumn = New System.Windows.Forms.Label()
        Me.lblSecondColumn = New System.Windows.Forms.Label()
        Me.grpMethod = New System.Windows.Forms.GroupBox()
        Me.rdoKendall = New System.Windows.Forms.RadioButton()
        Me.rdoPearson = New System.Windows.Forms.RadioButton()
        Me.rdoSpearman = New System.Windows.Forms.RadioButton()
        Me.ucrPnlMethod = New instat.UcrPanel()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.grpMissing = New System.Windows.Forms.GroupBox()
        Me.rdoCompleteRowsOnly = New System.Windows.Forms.RadioButton()
        Me.rdoPairwise = New System.Windows.Forms.RadioButton()
        Me.ucrPnlCompletePairwise = New instat.UcrPanel()
        Me.lblConfInterval = New System.Windows.Forms.Label()
        Me.rdoTwoColumns = New System.Windows.Forms.RadioButton()
        Me.rdoMultipleColumns = New System.Windows.Forms.RadioButton()
        Me.ucrSaveModel = New instat.ucrSave()
        Me.ucrNudConfidenceInterval = New instat.ucrNud()
        Me.ucrChkCorrelationMatrix = New instat.ucrCheck()
        Me.ucrPnlColumns = New instat.UcrPanel()
        Me.ucrReceiverMultipleColumns = New instat.ucrReceiverMultiple()
        Me.ucrReceiverSecondColumn = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstColumn = New instat.ucrReceiverSingle()
        Me.ucrSelectorCorrelation = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.grpMethod.SuspendLayout()
        Me.grpMissing.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstColumn
        '
        resources.ApplyResources(Me.lblFirstColumn, "lblFirstColumn")
        Me.lblFirstColumn.Name = "lblFirstColumn"
        Me.lblFirstColumn.Tag = "First_column"
        '
        'lblSecondColumn
        '
        resources.ApplyResources(Me.lblSecondColumn, "lblSecondColumn")
        Me.lblSecondColumn.Name = "lblSecondColumn"
        Me.lblSecondColumn.Tag = "Second_column"
        '
        'grpMethod
        '
        Me.grpMethod.Controls.Add(Me.rdoKendall)
        Me.grpMethod.Controls.Add(Me.rdoPearson)
        Me.grpMethod.Controls.Add(Me.rdoSpearman)
        Me.grpMethod.Controls.Add(Me.ucrPnlMethod)
        resources.ApplyResources(Me.grpMethod, "grpMethod")
        Me.grpMethod.Name = "grpMethod"
        Me.grpMethod.TabStop = False
        Me.grpMethod.Tag = "Method"
        '
        'rdoKendall
        '
        resources.ApplyResources(Me.rdoKendall, "rdoKendall")
        Me.rdoKendall.Name = "rdoKendall"
        Me.rdoKendall.Tag = "Kendall"
        Me.rdoKendall.UseVisualStyleBackColor = True
        '
        'rdoPearson
        '
        resources.ApplyResources(Me.rdoPearson, "rdoPearson")
        Me.rdoPearson.Checked = True
        Me.rdoPearson.Name = "rdoPearson"
        Me.rdoPearson.TabStop = True
        Me.rdoPearson.Tag = "Pearson"
        Me.rdoPearson.UseVisualStyleBackColor = True
        '
        'rdoSpearman
        '
        resources.ApplyResources(Me.rdoSpearman, "rdoSpearman")
        Me.rdoSpearman.Name = "rdoSpearman"
        Me.rdoSpearman.Tag = "Spearman"
        Me.rdoSpearman.UseVisualStyleBackColor = True
        '
        'ucrPnlMethod
        '
        resources.ApplyResources(Me.ucrPnlMethod, "ucrPnlMethod")
        Me.ucrPnlMethod.Name = "ucrPnlMethod"
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'grpMissing
        '
        Me.grpMissing.Controls.Add(Me.rdoCompleteRowsOnly)
        Me.grpMissing.Controls.Add(Me.rdoPairwise)
        Me.grpMissing.Controls.Add(Me.ucrPnlCompletePairwise)
        resources.ApplyResources(Me.grpMissing, "grpMissing")
        Me.grpMissing.Name = "grpMissing"
        Me.grpMissing.TabStop = False
        Me.grpMissing.Tag = "Missing"
        '
        'rdoCompleteRowsOnly
        '
        resources.ApplyResources(Me.rdoCompleteRowsOnly, "rdoCompleteRowsOnly")
        Me.rdoCompleteRowsOnly.Checked = True
        Me.rdoCompleteRowsOnly.Name = "rdoCompleteRowsOnly"
        Me.rdoCompleteRowsOnly.TabStop = True
        Me.rdoCompleteRowsOnly.Tag = "Complete_rows_only"
        Me.rdoCompleteRowsOnly.UseVisualStyleBackColor = True
        '
        'rdoPairwise
        '
        resources.ApplyResources(Me.rdoPairwise, "rdoPairwise")
        Me.rdoPairwise.Name = "rdoPairwise"
        Me.rdoPairwise.Tag = "Pairwise"
        Me.rdoPairwise.UseVisualStyleBackColor = True
        '
        'ucrPnlCompletePairwise
        '
        resources.ApplyResources(Me.ucrPnlCompletePairwise, "ucrPnlCompletePairwise")
        Me.ucrPnlCompletePairwise.Name = "ucrPnlCompletePairwise"
        '
        'lblConfInterval
        '
        resources.ApplyResources(Me.lblConfInterval, "lblConfInterval")
        Me.lblConfInterval.Name = "lblConfInterval"
        '
        'rdoTwoColumns
        '
        resources.ApplyResources(Me.rdoTwoColumns, "rdoTwoColumns")
        Me.rdoTwoColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoColumns.FlatAppearance.BorderSize = 2
        Me.rdoTwoColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoColumns.Name = "rdoTwoColumns"
        Me.rdoTwoColumns.TabStop = True
        Me.rdoTwoColumns.UseVisualStyleBackColor = True
        '
        'rdoMultipleColumns
        '
        resources.ApplyResources(Me.rdoMultipleColumns, "rdoMultipleColumns")
        Me.rdoMultipleColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultipleColumns.FlatAppearance.BorderSize = 2
        Me.rdoMultipleColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultipleColumns.Name = "rdoMultipleColumns"
        Me.rdoMultipleColumns.TabStop = True
        Me.rdoMultipleColumns.UseVisualStyleBackColor = True
        '
        'ucrSaveModel
        '
        resources.ApplyResources(Me.ucrSaveModel, "ucrSaveModel")
        Me.ucrSaveModel.Name = "ucrSaveModel"
        '
        'ucrNudConfidenceInterval
        '
        Me.ucrNudConfidenceInterval.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudConfidenceInterval.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudConfidenceInterval, "ucrNudConfidenceInterval")
        Me.ucrNudConfidenceInterval.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudConfidenceInterval.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudConfidenceInterval.Name = "ucrNudConfidenceInterval"
        Me.ucrNudConfidenceInterval.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkCorrelationMatrix
        '
        Me.ucrChkCorrelationMatrix.Checked = False
        resources.ApplyResources(Me.ucrChkCorrelationMatrix, "ucrChkCorrelationMatrix")
        Me.ucrChkCorrelationMatrix.Name = "ucrChkCorrelationMatrix"
        '
        'ucrPnlColumns
        '
        resources.ApplyResources(Me.ucrPnlColumns, "ucrPnlColumns")
        Me.ucrPnlColumns.Name = "ucrPnlColumns"
        '
        'ucrReceiverMultipleColumns
        '
        Me.ucrReceiverMultipleColumns.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMultipleColumns, "ucrReceiverMultipleColumns")
        Me.ucrReceiverMultipleColumns.Name = "ucrReceiverMultipleColumns"
        Me.ucrReceiverMultipleColumns.Selector = Nothing
        Me.ucrReceiverMultipleColumns.strNcFilePath = ""
        Me.ucrReceiverMultipleColumns.ucrSelector = Nothing
        '
        'ucrReceiverSecondColumn
        '
        Me.ucrReceiverSecondColumn.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSecondColumn, "ucrReceiverSecondColumn")
        Me.ucrReceiverSecondColumn.Name = "ucrReceiverSecondColumn"
        Me.ucrReceiverSecondColumn.Selector = Nothing
        Me.ucrReceiverSecondColumn.strNcFilePath = ""
        Me.ucrReceiverSecondColumn.ucrSelector = Nothing
        '
        'ucrReceiverFirstColumn
        '
        Me.ucrReceiverFirstColumn.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFirstColumn, "ucrReceiverFirstColumn")
        Me.ucrReceiverFirstColumn.Name = "ucrReceiverFirstColumn"
        Me.ucrReceiverFirstColumn.Selector = Nothing
        Me.ucrReceiverFirstColumn.strNcFilePath = ""
        Me.ucrReceiverFirstColumn.ucrSelector = Nothing
        '
        'ucrSelectorCorrelation
        '
        Me.ucrSelectorCorrelation.bShowHiddenColumns = False
        Me.ucrSelectorCorrelation.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorCorrelation, "ucrSelectorCorrelation")
        Me.ucrSelectorCorrelation.Name = "ucrSelectorCorrelation"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'lblSelectedVariables
        '
        resources.ApplyResources(Me.lblSelectedVariables, "lblSelectedVariables")
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Tag = ""
        '
        'dlgCorrelation
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrSaveModel)
        Me.Controls.Add(Me.ucrNudConfidenceInterval)
        Me.Controls.Add(Me.ucrChkCorrelationMatrix)
        Me.Controls.Add(Me.rdoTwoColumns)
        Me.Controls.Add(Me.rdoMultipleColumns)
        Me.Controls.Add(Me.ucrPnlColumns)
        Me.Controls.Add(Me.grpMethod)
        Me.Controls.Add(Me.ucrReceiverMultipleColumns)
        Me.Controls.Add(Me.lblConfInterval)
        Me.Controls.Add(Me.grpMissing)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblSecondColumn)
        Me.Controls.Add(Me.lblFirstColumn)
        Me.Controls.Add(Me.ucrReceiverSecondColumn)
        Me.Controls.Add(Me.ucrReceiverFirstColumn)
        Me.Controls.Add(Me.ucrSelectorCorrelation)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCorrelation"
        Me.Tag = "Correlation"
        Me.grpMethod.ResumeLayout(False)
        Me.grpMethod.PerformLayout()
        Me.grpMissing.ResumeLayout(False)
        Me.grpMissing.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorCorrelation As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFirstColumn As ucrReceiverSingle
    Friend WithEvents ucrReceiverSecondColumn As ucrReceiverSingle
    Friend WithEvents lblFirstColumn As Label
    Friend WithEvents lblSecondColumn As Label
    Friend WithEvents grpMethod As GroupBox
    Friend WithEvents rdoSpearman As RadioButton
    Friend WithEvents rdoKendall As RadioButton
    Friend WithEvents rdoPearson As RadioButton
    Friend WithEvents cmdOptions As Button
    Friend WithEvents grpMissing As GroupBox
    Friend WithEvents rdoPairwise As RadioButton
    Friend WithEvents rdoCompleteRowsOnly As RadioButton
    Friend WithEvents lblConfInterval As Label
    Friend WithEvents ucrReceiverMultipleColumns As ucrReceiverMultiple
    Friend WithEvents rdoTwoColumns As RadioButton
    Friend WithEvents rdoMultipleColumns As RadioButton
    Friend WithEvents ucrPnlColumns As UcrPanel
    Friend WithEvents ucrChkCorrelationMatrix As ucrCheck
    Friend WithEvents ucrPnlMethod As UcrPanel
    Friend WithEvents ucrPnlCompletePairwise As UcrPanel
    Friend WithEvents ucrNudConfidenceInterval As ucrNud
    Friend WithEvents ucrSaveModel As ucrSave
    Friend WithEvents lblSelectedVariables As Label
End Class