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
Partial Class dlgRowNamesOrNumbers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRowNamesOrNumbers))
        Me.ucrSelectorRowNames = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOverallOptions = New instat.UcrPanel()
        Me.ucrReceiverRowNames = New instat.ucrReceiverSingle()
        Me.rdoCopyRowNamesIntoFirstColumn = New System.Windows.Forms.RadioButton()
        Me.rdoSetRowNamesFromColumn = New System.Windows.Forms.RadioButton()
        Me.rdoResetintoPositiveIntegers = New System.Windows.Forms.RadioButton()
        Me.rdoSortbyRowNames = New System.Windows.Forms.RadioButton()
        Me.rdoSortDescending = New System.Windows.Forms.RadioButton()
        Me.rdoSortAscending = New System.Windows.Forms.RadioButton()
        Me.ucrNewColumnName = New instat.ucrSave()
        Me.ucrChkAsNumeric = New instat.ucrCheck()
        Me.grpboxOptionsforRowNamesorNumbercols = New System.Windows.Forms.GroupBox()
        Me.ucrPnlSortOptions = New instat.UcrPanel()
        Me.grpboxOptionsforRowNamesorNumbercols.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSelectorRowNames
        '
        Me.ucrSelectorRowNames.bShowHiddenColumns = False
        Me.ucrSelectorRowNames.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorRowNames, "ucrSelectorRowNames")
        Me.ucrSelectorRowNames.Name = "ucrSelectorRowNames"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrPnlOverallOptions
        '
        resources.ApplyResources(Me.ucrPnlOverallOptions, "ucrPnlOverallOptions")
        Me.ucrPnlOverallOptions.Name = "ucrPnlOverallOptions"
        '
        'ucrReceiverRowNames
        '
        Me.ucrReceiverRowNames.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverRowNames, "ucrReceiverRowNames")
        Me.ucrReceiverRowNames.Name = "ucrReceiverRowNames"
        Me.ucrReceiverRowNames.Selector = Nothing
        Me.ucrReceiverRowNames.strNcFilePath = ""
        Me.ucrReceiverRowNames.ucrSelector = Nothing
        '
        'rdoCopyRowNamesIntoFirstColumn
        '
        resources.ApplyResources(Me.rdoCopyRowNamesIntoFirstColumn, "rdoCopyRowNamesIntoFirstColumn")
        Me.rdoCopyRowNamesIntoFirstColumn.Name = "rdoCopyRowNamesIntoFirstColumn"
        Me.rdoCopyRowNamesIntoFirstColumn.TabStop = True
        Me.rdoCopyRowNamesIntoFirstColumn.UseVisualStyleBackColor = True
        '
        'rdoSetRowNamesFromColumn
        '
        resources.ApplyResources(Me.rdoSetRowNamesFromColumn, "rdoSetRowNamesFromColumn")
        Me.rdoSetRowNamesFromColumn.Name = "rdoSetRowNamesFromColumn"
        Me.rdoSetRowNamesFromColumn.TabStop = True
        Me.rdoSetRowNamesFromColumn.UseVisualStyleBackColor = True
        '
        'rdoResetintoPositiveIntegers
        '
        resources.ApplyResources(Me.rdoResetintoPositiveIntegers, "rdoResetintoPositiveIntegers")
        Me.rdoResetintoPositiveIntegers.Name = "rdoResetintoPositiveIntegers"
        Me.rdoResetintoPositiveIntegers.TabStop = True
        Me.rdoResetintoPositiveIntegers.UseVisualStyleBackColor = True
        '
        'rdoSortbyRowNames
        '
        resources.ApplyResources(Me.rdoSortbyRowNames, "rdoSortbyRowNames")
        Me.rdoSortbyRowNames.Name = "rdoSortbyRowNames"
        Me.rdoSortbyRowNames.TabStop = True
        Me.rdoSortbyRowNames.UseVisualStyleBackColor = True
        '
        'rdoSortDescending
        '
        resources.ApplyResources(Me.rdoSortDescending, "rdoSortDescending")
        Me.rdoSortDescending.Name = "rdoSortDescending"
        Me.rdoSortDescending.TabStop = True
        Me.rdoSortDescending.UseVisualStyleBackColor = True
        '
        'rdoSortAscending
        '
        resources.ApplyResources(Me.rdoSortAscending, "rdoSortAscending")
        Me.rdoSortAscending.Name = "rdoSortAscending"
        Me.rdoSortAscending.TabStop = True
        Me.rdoSortAscending.UseVisualStyleBackColor = True
        '
        'ucrNewColumnName
        '
        resources.ApplyResources(Me.ucrNewColumnName, "ucrNewColumnName")
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        '
        'ucrChkAsNumeric
        '
        Me.ucrChkAsNumeric.Checked = False
        resources.ApplyResources(Me.ucrChkAsNumeric, "ucrChkAsNumeric")
        Me.ucrChkAsNumeric.Name = "ucrChkAsNumeric"
        '
        'grpboxOptionsforRowNamesorNumbercols
        '
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.ucrChkAsNumeric)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoSortDescending)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoSortAscending)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.ucrPnlSortOptions)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.ucrNewColumnName)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoSortbyRowNames)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoResetintoPositiveIntegers)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoSetRowNamesFromColumn)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoCopyRowNamesIntoFirstColumn)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.ucrReceiverRowNames)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.ucrPnlOverallOptions)
        resources.ApplyResources(Me.grpboxOptionsforRowNamesorNumbercols, "grpboxOptionsforRowNamesorNumbercols")
        Me.grpboxOptionsforRowNamesorNumbercols.Name = "grpboxOptionsforRowNamesorNumbercols"
        Me.grpboxOptionsforRowNamesorNumbercols.TabStop = False
        '
        'ucrPnlSortOptions
        '
        resources.ApplyResources(Me.ucrPnlSortOptions, "ucrPnlSortOptions")
        Me.ucrPnlSortOptions.Name = "ucrPnlSortOptions"
        '
        'dlgRowNamesOrNumbers
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpboxOptionsforRowNamesorNumbercols)
        Me.Controls.Add(Me.ucrSelectorRowNames)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRowNamesOrNumbers"
        Me.grpboxOptionsforRowNamesorNumbercols.ResumeLayout(False)
        Me.grpboxOptionsforRowNamesorNumbercols.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorRowNames As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrPnlOverallOptions As UcrPanel
    Friend WithEvents ucrReceiverRowNames As ucrReceiverSingle
    Friend WithEvents grpboxOptionsforRowNamesorNumbercols As GroupBox
    Friend WithEvents ucrChkAsNumeric As ucrCheck
    Friend WithEvents ucrNewColumnName As ucrSave
    Friend WithEvents rdoSortAscending As RadioButton
    Friend WithEvents rdoSortDescending As RadioButton
    Friend WithEvents rdoSortbyRowNames As RadioButton
    Friend WithEvents rdoResetintoPositiveIntegers As RadioButton
    Friend WithEvents rdoSetRowNamesFromColumn As RadioButton
    Friend WithEvents rdoCopyRowNamesIntoFirstColumn As RadioButton
    Friend WithEvents ucrPnlSortOptions As UcrPanel
End Class
