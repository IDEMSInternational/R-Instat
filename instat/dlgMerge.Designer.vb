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
Partial Class dlgMerge
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
        Me.cmdJoinOptions = New System.Windows.Forms.Button()
        Me.lnlJoinType = New System.Windows.Forms.Label()
        Me.lblMergeBy = New System.Windows.Forms.Label()
        Me.ucrInputMergingBy = New instat.ucrInputTextBox()
        Me.ucrSaveMerge = New instat.ucrSave()
        Me.ucrInputJoinType = New instat.ucrInputComboBox()
        Me.ucrSecondDataFrame = New instat.ucrDataFrame()
        Me.ucrFirstDataFrame = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.cmdColumnOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdJoinOptions
        '
        Me.cmdJoinOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdJoinOptions.Location = New System.Drawing.Point(99, 149)
        Me.cmdJoinOptions.Name = "cmdJoinOptions"
        Me.cmdJoinOptions.Size = New System.Drawing.Size(129, 23)
        Me.cmdJoinOptions.TabIndex = 6
        Me.cmdJoinOptions.Text = "Join Options"
        Me.cmdJoinOptions.UseVisualStyleBackColor = True
        '
        'lnlJoinType
        '
        Me.lnlJoinType.AutoSize = True
        Me.lnlJoinType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lnlJoinType.Location = New System.Drawing.Point(9, 68)
        Me.lnlJoinType.Name = "lnlJoinType"
        Me.lnlJoinType.Size = New System.Drawing.Size(56, 13)
        Me.lnlJoinType.TabIndex = 2
        Me.lnlJoinType.Text = "Join Type:"
        '
        'lblMergeBy
        '
        Me.lblMergeBy.AutoSize = True
        Me.lblMergeBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMergeBy.Location = New System.Drawing.Point(9, 96)
        Me.lblMergeBy.Name = "lblMergeBy"
        Me.lblMergeBy.Size = New System.Drawing.Size(58, 13)
        Me.lblMergeBy.TabIndex = 4
        Me.lblMergeBy.Text = "Joining By:"
        '
        'ucrInputMergingBy
        '
        Me.ucrInputMergingBy.AddQuotesIfUnrecognised = True
        Me.ucrInputMergingBy.AutoSize = True
        Me.ucrInputMergingBy.IsMultiline = False
        Me.ucrInputMergingBy.IsReadOnly = False
        Me.ucrInputMergingBy.Location = New System.Drawing.Point(99, 93)
        Me.ucrInputMergingBy.Name = "ucrInputMergingBy"
        Me.ucrInputMergingBy.Size = New System.Drawing.Size(278, 52)
        Me.ucrInputMergingBy.TabIndex = 5
        '
        'ucrSaveMerge
        '
        Me.ucrSaveMerge.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveMerge.Location = New System.Drawing.Point(10, 180)
        Me.ucrSaveMerge.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveMerge.Name = "ucrSaveMerge"
        Me.ucrSaveMerge.Size = New System.Drawing.Size(301, 24)
        Me.ucrSaveMerge.TabIndex = 8
        '
        'ucrInputJoinType
        '
        Me.ucrInputJoinType.AddQuotesIfUnrecognised = True
        Me.ucrInputJoinType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputJoinType.GetSetSelectedIndex = -1
        Me.ucrInputJoinType.IsReadOnly = False
        Me.ucrInputJoinType.Location = New System.Drawing.Point(99, 65)
        Me.ucrInputJoinType.Name = "ucrInputJoinType"
        Me.ucrInputJoinType.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputJoinType.TabIndex = 3
        '
        'ucrSecondDataFrame
        '
        Me.ucrSecondDataFrame.AutoSize = True
        Me.ucrSecondDataFrame.bDropUnusedFilterLevels = False
        Me.ucrSecondDataFrame.bUseCurrentFilter = True
        Me.ucrSecondDataFrame.Location = New System.Drawing.Point(216, 12)
        Me.ucrSecondDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondDataFrame.Name = "ucrSecondDataFrame"
        Me.ucrSecondDataFrame.Size = New System.Drawing.Size(151, 50)
        Me.ucrSecondDataFrame.TabIndex = 1
        '
        'ucrFirstDataFrame
        '
        Me.ucrFirstDataFrame.AutoSize = True
        Me.ucrFirstDataFrame.bDropUnusedFilterLevels = False
        Me.ucrFirstDataFrame.bUseCurrentFilter = True
        Me.ucrFirstDataFrame.Location = New System.Drawing.Point(10, 12)
        Me.ucrFirstDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFirstDataFrame.Name = "ucrFirstDataFrame"
        Me.ucrFirstDataFrame.Size = New System.Drawing.Size(151, 50)
        Me.ucrFirstDataFrame.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 207)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 9
        '
        'cmdColumnOptions
        '
        Me.cmdColumnOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdColumnOptions.Location = New System.Drawing.Point(245, 150)
        Me.cmdColumnOptions.Name = "cmdColumnOptions"
        Me.cmdColumnOptions.Size = New System.Drawing.Size(132, 23)
        Me.cmdColumnOptions.TabIndex = 7
        Me.cmdColumnOptions.Text = "Column Selection"
        Me.cmdColumnOptions.UseVisualStyleBackColor = True
        '
        'dlgMerge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(413, 263)
        Me.Controls.Add(Me.cmdColumnOptions)
        Me.Controls.Add(Me.ucrInputMergingBy)
        Me.Controls.Add(Me.lblMergeBy)
        Me.Controls.Add(Me.ucrSaveMerge)
        Me.Controls.Add(Me.lnlJoinType)
        Me.Controls.Add(Me.ucrInputJoinType)
        Me.Controls.Add(Me.ucrSecondDataFrame)
        Me.Controls.Add(Me.ucrFirstDataFrame)
        Me.Controls.Add(Me.cmdJoinOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMerge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Merge"
        Me.Text = "Merge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdJoinOptions As Button
    Friend WithEvents ucrFirstDataFrame As ucrDataFrame
    Friend WithEvents ucrSecondDataFrame As ucrDataFrame
    Friend WithEvents ucrInputJoinType As ucrInputComboBox
    Friend WithEvents lnlJoinType As Label
    Friend WithEvents ucrSaveMerge As ucrSave
    Friend WithEvents lblMergeBy As Label
    Friend WithEvents ucrInputMergingBy As ucrInputTextBox
    Friend WithEvents cmdColumnOptions As Button
End Class
