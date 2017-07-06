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
        Me.ucrSelectorRowNames = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOverallOptions = New instat.UcrPanel()
        Me.ucrReceiverRowNames = New instat.ucrReceiverSingle()
        Me.rdoCopytoFirstColumn = New System.Windows.Forms.RadioButton()
        Me.rdoCopyfromColumn = New System.Windows.Forms.RadioButton()
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
        Me.ucrSelectorRowNames.Location = New System.Drawing.Point(9, 10)
        Me.ucrSelectorRowNames.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorRowNames.Name = "ucrSelectorRowNames"
        Me.ucrSelectorRowNames.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorRowNames.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 281)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 2
        '
        'ucrPnlOverallOptions
        '
        Me.ucrPnlOverallOptions.Location = New System.Drawing.Point(3, 14)
        Me.ucrPnlOverallOptions.Name = "ucrPnlOverallOptions"
        Me.ucrPnlOverallOptions.Size = New System.Drawing.Size(227, 166)
        Me.ucrPnlOverallOptions.TabIndex = 0
        '
        'ucrReceiverRowNames
        '
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
        'rdoCopytoFirstColumn
        '
        Me.rdoCopytoFirstColumn.AutoSize = True
        Me.rdoCopytoFirstColumn.Location = New System.Drawing.Point(9, 19)
        Me.rdoCopytoFirstColumn.Name = "rdoCopytoFirstColumn"
        Me.rdoCopytoFirstColumn.Size = New System.Drawing.Size(190, 17)
        Me.rdoCopytoFirstColumn.TabIndex = 1
        Me.rdoCopytoFirstColumn.TabStop = True
        Me.rdoCopytoFirstColumn.Text = "Copy Row Names into First Column"
        Me.rdoCopytoFirstColumn.UseVisualStyleBackColor = True
        '
        'rdoCopyfromColumn
        '
        Me.rdoCopyfromColumn.AutoSize = True
        Me.rdoCopyfromColumn.Location = New System.Drawing.Point(9, 72)
        Me.rdoCopyfromColumn.Name = "rdoCopyfromColumn"
        Me.rdoCopyfromColumn.Size = New System.Drawing.Size(163, 17)
        Me.rdoCopyfromColumn.TabIndex = 3
        Me.rdoCopyfromColumn.TabStop = True
        Me.rdoCopyfromColumn.Text = "Set Row Names from Column"
        Me.rdoCopyfromColumn.UseVisualStyleBackColor = True
        '
        'rdoResetintoPositiveIntegers
        '
        Me.rdoResetintoPositiveIntegers.AutoSize = True
        Me.rdoResetintoPositiveIntegers.Location = New System.Drawing.Point(9, 127)
        Me.rdoResetintoPositiveIntegers.Name = "rdoResetintoPositiveIntegers"
        Me.rdoResetintoPositiveIntegers.Size = New System.Drawing.Size(207, 17)
        Me.rdoResetintoPositiveIntegers.TabIndex = 5
        Me.rdoResetintoPositiveIntegers.TabStop = True
        Me.rdoResetintoPositiveIntegers.Text = "Reset Row Names to Positive Integers"
        Me.rdoResetintoPositiveIntegers.UseVisualStyleBackColor = True
        '
        'rdoSortbyRowNames
        '
        Me.rdoSortbyRowNames.AutoSize = True
        Me.rdoSortbyRowNames.Location = New System.Drawing.Point(9, 156)
        Me.rdoSortbyRowNames.Name = "rdoSortbyRowNames"
        Me.rdoSortbyRowNames.Size = New System.Drawing.Size(119, 17)
        Me.rdoSortbyRowNames.TabIndex = 6
        Me.rdoSortbyRowNames.TabStop = True
        Me.rdoSortbyRowNames.Text = "Sort by Row Names"
        Me.rdoSortbyRowNames.UseVisualStyleBackColor = True
        '
        'rdoSortDescending
        '
        Me.rdoSortDescending.AutoSize = True
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
        Me.rdoSortAscending.Location = New System.Drawing.Point(24, 186)
        Me.rdoSortAscending.Name = "rdoSortAscending"
        Me.rdoSortAscending.Size = New System.Drawing.Size(75, 17)
        Me.rdoSortAscending.TabIndex = 8
        Me.rdoSortAscending.TabStop = True
        Me.rdoSortAscending.Text = "Ascending"
        Me.rdoSortAscending.UseVisualStyleBackColor = True
        '
        'ucrNewColumnName
        '
        Me.ucrNewColumnName.Location = New System.Drawing.Point(24, 42)
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        Me.ucrNewColumnName.Size = New System.Drawing.Size(206, 24)
        Me.ucrNewColumnName.TabIndex = 2
        '
        'ucrChkAsNumeric
        '
        Me.ucrChkAsNumeric.Checked = False
        Me.ucrChkAsNumeric.Location = New System.Drawing.Point(24, 213)
        Me.ucrChkAsNumeric.Name = "ucrChkAsNumeric"
        Me.ucrChkAsNumeric.Size = New System.Drawing.Size(188, 20)
        Me.ucrChkAsNumeric.TabIndex = 9
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
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoCopyfromColumn)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.rdoCopytoFirstColumn)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.ucrReceiverRowNames)
        Me.grpboxOptionsforRowNamesorNumbercols.Controls.Add(Me.ucrPnlOverallOptions)
        Me.grpboxOptionsforRowNamesorNumbercols.Location = New System.Drawing.Point(228, 34)
        Me.grpboxOptionsforRowNamesorNumbercols.Name = "grpboxOptionsforRowNamesorNumbercols"
        Me.grpboxOptionsforRowNamesorNumbercols.Size = New System.Drawing.Size(236, 241)
        Me.grpboxOptionsforRowNamesorNumbercols.TabIndex = 1
        Me.grpboxOptionsforRowNamesorNumbercols.TabStop = False
        Me.grpboxOptionsforRowNamesorNumbercols.Text = "Options"
        '
        'ucrPnlSortOptions
        '
        Me.ucrPnlSortOptions.Location = New System.Drawing.Point(7, 171)
        Me.ucrPnlSortOptions.Name = "ucrPnlSortOptions"
        Me.ucrPnlSortOptions.Size = New System.Drawing.Size(206, 36)
        Me.ucrPnlSortOptions.TabIndex = 7
        '
        'dlgRowNamesOrNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 336)
        Me.Controls.Add(Me.grpboxOptionsforRowNamesorNumbercols)
        Me.Controls.Add(Me.ucrSelectorRowNames)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRowNamesOrNumbers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Row Names Or Numbers"
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
    Friend WithEvents rdoCopyfromColumn As RadioButton
    Friend WithEvents rdoCopytoFirstColumn As RadioButton
    Friend WithEvents ucrPnlSortOptions As UcrPanel
End Class
