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
        Me.rdoCopyRowNamesIntoFirstColumn = New System.Windows.Forms.RadioButton()
        Me.rdoSetRowNamesFromColumn = New System.Windows.Forms.RadioButton()
        Me.rdoResetintoPositiveIntegers = New System.Windows.Forms.RadioButton()
        Me.rdoSortbyRowNames = New System.Windows.Forms.RadioButton()
        Me.rdoSortDescending = New System.Windows.Forms.RadioButton()
        Me.rdoSortAscending = New System.Windows.Forms.RadioButton()
        Me.grpboxOptionsforRowNamesorNumbercols = New System.Windows.Forms.GroupBox()
        Me.ucrChkAsNumeric = New instat.ucrCheck()
        Me.ucrPnlSortOptions = New instat.UcrPanel()
        Me.ucrNewColumnName = New instat.ucrSave()
        Me.ucrReceiverRowNames = New instat.ucrReceiverSingle()
        Me.ucrPnlOverallOptions = New instat.UcrPanel()
        Me.ucrSelectorRowNames = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpboxOptionsforRowNamesorNumbercols.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoCopyRowNamesIntoFirstColumn
        '
        Me.rdoCopyRowNamesIntoFirstColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCopyRowNamesIntoFirstColumn.Location = New System.Drawing.Point(9, 19)
        Me.rdoCopyRowNamesIntoFirstColumn.Name = "rdoCopyRowNamesIntoFirstColumn"
        Me.rdoCopyRowNamesIntoFirstColumn.Size = New System.Drawing.Size(267, 17)
        Me.rdoCopyRowNamesIntoFirstColumn.TabIndex = 1
        Me.rdoCopyRowNamesIntoFirstColumn.TabStop = True
        Me.rdoCopyRowNamesIntoFirstColumn.Text = "Copy Row Names into Column"
        Me.rdoCopyRowNamesIntoFirstColumn.UseVisualStyleBackColor = True
        '
        'rdoSetRowNamesFromColumn
        '
        Me.rdoSetRowNamesFromColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSetRowNamesFromColumn.Location = New System.Drawing.Point(9, 72)
        Me.rdoSetRowNamesFromColumn.Name = "rdoSetRowNamesFromColumn"
        Me.rdoSetRowNamesFromColumn.Size = New System.Drawing.Size(267, 17)
        Me.rdoSetRowNamesFromColumn.TabIndex = 3
        Me.rdoSetRowNamesFromColumn.TabStop = True
        Me.rdoSetRowNamesFromColumn.Text = "Set Row Names from Column"
        Me.rdoSetRowNamesFromColumn.UseVisualStyleBackColor = True
        '
        'rdoResetintoPositiveIntegers
        '
        Me.rdoResetintoPositiveIntegers.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoResetintoPositiveIntegers.Location = New System.Drawing.Point(9, 127)
        Me.rdoResetintoPositiveIntegers.Name = "rdoResetintoPositiveIntegers"
        Me.rdoResetintoPositiveIntegers.Size = New System.Drawing.Size(267, 17)
        Me.rdoResetintoPositiveIntegers.TabIndex = 5
        Me.rdoResetintoPositiveIntegers.TabStop = True
        Me.rdoResetintoPositiveIntegers.Text = "Reset Row Names to Positive Integers"
        Me.rdoResetintoPositiveIntegers.UseVisualStyleBackColor = True
        '
        'rdoSortbyRowNames
        '
        Me.rdoSortbyRowNames.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSortbyRowNames.Location = New System.Drawing.Point(9, 156)
        Me.rdoSortbyRowNames.Name = "rdoSortbyRowNames"
        Me.rdoSortbyRowNames.Size = New System.Drawing.Size(267, 17)
        Me.rdoSortbyRowNames.TabIndex = 6
        Me.rdoSortbyRowNames.TabStop = True
        Me.rdoSortbyRowNames.Text = "Sort by Row Names"
        Me.rdoSortbyRowNames.UseVisualStyleBackColor = True
        '
        'rdoSortDescending
        '
        Me.rdoSortDescending.AutoSize = True
        Me.rdoSortDescending.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSortDescending.Location = New System.Drawing.Point(130, 186)
        Me.rdoSortDescending.Name = "rdoSortDescending"
        Me.rdoSortDescending.Size = New System.Drawing.Size(82, 17)
        Me.rdoSortDescending.TabIndex = 9
        Me.rdoSortDescending.TabStop = True
        Me.rdoSortDescending.Text = "Descending"
        Me.rdoSortDescending.UseVisualStyleBackColor = True
        '
        'rdoSortAscending
        '
        Me.rdoSortAscending.AutoSize = True
        Me.rdoSortAscending.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSortAscending.Location = New System.Drawing.Point(24, 186)
        Me.rdoSortAscending.Name = "rdoSortAscending"
        Me.rdoSortAscending.Size = New System.Drawing.Size(75, 17)
        Me.rdoSortAscending.TabIndex = 8
        Me.rdoSortAscending.TabStop = True
        Me.rdoSortAscending.Text = "Ascending"
        Me.rdoSortAscending.UseVisualStyleBackColor = True
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
        Me.grpboxOptionsforRowNamesorNumbercols.Location = New System.Drawing.Point(228, 34)
        Me.grpboxOptionsforRowNamesorNumbercols.Name = "grpboxOptionsforRowNamesorNumbercols"
        Me.grpboxOptionsforRowNamesorNumbercols.Size = New System.Drawing.Size(361, 241)
        Me.grpboxOptionsforRowNamesorNumbercols.TabIndex = 1
        Me.grpboxOptionsforRowNamesorNumbercols.TabStop = False
        Me.grpboxOptionsforRowNamesorNumbercols.Text = "Options"
        '
        'ucrChkAsNumeric
        '
        Me.ucrChkAsNumeric.AutoSize = True
        Me.ucrChkAsNumeric.Checked = False
        Me.ucrChkAsNumeric.Location = New System.Drawing.Point(24, 213)
        Me.ucrChkAsNumeric.Name = "ucrChkAsNumeric"
        Me.ucrChkAsNumeric.Size = New System.Drawing.Size(188, 23)
        Me.ucrChkAsNumeric.TabIndex = 9
        '
        'ucrPnlSortOptions
        '
        Me.ucrPnlSortOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSortOptions.Location = New System.Drawing.Point(7, 171)
        Me.ucrPnlSortOptions.Name = "ucrPnlSortOptions"
        Me.ucrPnlSortOptions.Size = New System.Drawing.Size(206, 36)
        Me.ucrPnlSortOptions.TabIndex = 7
        '
        'ucrNewColumnName
        '
        Me.ucrNewColumnName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrNewColumnName.Location = New System.Drawing.Point(9, 44)
        Me.ucrNewColumnName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        Me.ucrNewColumnName.Size = New System.Drawing.Size(343, 21)
        Me.ucrNewColumnName.TabIndex = 2
        '
        'ucrReceiverRowNames
        '
        Me.ucrReceiverRowNames.AutoSize = True
        Me.ucrReceiverRowNames.frmParent = Me
        Me.ucrReceiverRowNames.Location = New System.Drawing.Point(24, 92)
        Me.ucrReceiverRowNames.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRowNames.Name = "ucrReceiverRowNames"
        Me.ucrReceiverRowNames.Selector = Nothing
        Me.ucrReceiverRowNames.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRowNames.strNcFilePath = ""
        Me.ucrReceiverRowNames.TabIndex = 4
        Me.ucrReceiverRowNames.ucrSelector = Nothing
        '
        'ucrPnlOverallOptions
        '
        Me.ucrPnlOverallOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOverallOptions.Location = New System.Drawing.Point(3, 14)
        Me.ucrPnlOverallOptions.Name = "ucrPnlOverallOptions"
        Me.ucrPnlOverallOptions.Size = New System.Drawing.Size(352, 166)
        Me.ucrPnlOverallOptions.TabIndex = 0
        '
        'ucrSelectorRowNames
        '
        Me.ucrSelectorRowNames.AutoSize = True
        Me.ucrSelectorRowNames.bDropUnusedFilterLevels = False
        Me.ucrSelectorRowNames.bShowHiddenColumns = False
        Me.ucrSelectorRowNames.bUseCurrentFilter = True
        Me.ucrSelectorRowNames.Location = New System.Drawing.Point(9, 10)
        Me.ucrSelectorRowNames.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorRowNames.Name = "ucrSelectorRowNames"
        Me.ucrSelectorRowNames.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorRowNames.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 279)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 2
        '
        'dlgRowNamesOrNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(601, 336)
        Me.Controls.Add(Me.grpboxOptionsforRowNamesorNumbercols)
        Me.Controls.Add(Me.ucrSelectorRowNames)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRowNamesOrNumbers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Row Numbers or Names"
        Me.grpboxOptionsforRowNamesorNumbercols.ResumeLayout(False)
        Me.grpboxOptionsforRowNamesorNumbercols.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
