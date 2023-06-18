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
Partial Class dlgHideDataframes
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorForDataFrames = New instat.ucrSelectorAddRemove()
        Me.lblDataFrames = New System.Windows.Forms.Label()
        Me.lblHiddenDataFrames = New System.Windows.Forms.Label()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.rdoUnhideDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoHideDataFrame = New System.Windows.Forms.RadioButton()
        Me.ucrPnlHideUnhide = New instat.UcrPanel()
        Me.ucrReceiverMultipleUnhide = New instat.ucrReceiverMultiple()
        Me.lblUnhideDataFrame = New System.Windows.Forms.Label()
        Me.lblHiddenNumber = New System.Windows.Forms.Label()
        Me.lblUnHiddenNumber = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(7, 199)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 1
        '
        'ucrSelectorForDataFrames
        '
        Me.ucrSelectorForDataFrames.AutoSize = True
        Me.ucrSelectorForDataFrames.bShowHiddenColumns = False
        Me.ucrSelectorForDataFrames.Location = New System.Drawing.Point(10, 53)
        Me.ucrSelectorForDataFrames.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDataFrames.Name = "ucrSelectorForDataFrames"
        Me.ucrSelectorForDataFrames.Size = New System.Drawing.Size(218, 147)
        Me.ucrSelectorForDataFrames.TabIndex = 2
        '
        'lblDataFrames
        '
        Me.lblDataFrames.AutoSize = True
        Me.lblDataFrames.Location = New System.Drawing.Point(10, 38)
        Me.lblDataFrames.Name = "lblDataFrames"
        Me.lblDataFrames.Size = New System.Drawing.Size(76, 13)
        Me.lblDataFrames.TabIndex = 3
        Me.lblDataFrames.Text = "Data Frame(s):"
        '
        'lblHiddenDataFrames
        '
        Me.lblHiddenDataFrames.AutoSize = True
        Me.lblHiddenDataFrames.Location = New System.Drawing.Point(236, 47)
        Me.lblHiddenDataFrames.Name = "lblHiddenDataFrames"
        Me.lblHiddenDataFrames.Size = New System.Drawing.Size(113, 13)
        Me.lblHiddenDataFrames.TabIndex = 4
        Me.lblHiddenDataFrames.Text = "Hidden Data Frame(s):"
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.AutoSize = True
        Me.ucrReceiverMultiple.frmParent = Me
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(232, 62)
        Me.ucrReceiverMultiple.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Selector = Nothing
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(120, 112)
        Me.ucrReceiverMultiple.strNcFilePath = ""
        Me.ucrReceiverMultiple.TabIndex = 5
        Me.ucrReceiverMultiple.ucrSelector = Nothing
        '
        'rdoUnhideDataFrame
        '
        Me.rdoUnhideDataFrame.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoUnhideDataFrame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUnhideDataFrame.FlatAppearance.BorderSize = 2
        Me.rdoUnhideDataFrame.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUnhideDataFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoUnhideDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoUnhideDataFrame.Location = New System.Drawing.Point(208, 7)
        Me.rdoUnhideDataFrame.Name = "rdoUnhideDataFrame"
        Me.rdoUnhideDataFrame.Size = New System.Drawing.Size(100, 28)
        Me.rdoUnhideDataFrame.TabIndex = 6
        Me.rdoUnhideDataFrame.Text = "Unhide"
        Me.rdoUnhideDataFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoUnhideDataFrame.UseVisualStyleBackColor = True
        '
        'rdoHideDataFrame
        '
        Me.rdoHideDataFrame.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoHideDataFrame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHideDataFrame.FlatAppearance.BorderSize = 2
        Me.rdoHideDataFrame.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHideDataFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoHideDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHideDataFrame.Location = New System.Drawing.Point(112, 7)
        Me.rdoHideDataFrame.Name = "rdoHideDataFrame"
        Me.rdoHideDataFrame.Size = New System.Drawing.Size(100, 28)
        Me.rdoHideDataFrame.TabIndex = 7
        Me.rdoHideDataFrame.Text = "Hide"
        Me.rdoHideDataFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoHideDataFrame.UseVisualStyleBackColor = True
        '
        'ucrPnlHideUnhide
        '
        Me.ucrPnlHideUnhide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlHideUnhide.Location = New System.Drawing.Point(92, 5)
        Me.ucrPnlHideUnhide.Name = "ucrPnlHideUnhide"
        Me.ucrPnlHideUnhide.Size = New System.Drawing.Size(241, 34)
        Me.ucrPnlHideUnhide.TabIndex = 8
        '
        'ucrReceiverMultipleUnhide
        '
        Me.ucrReceiverMultipleUnhide.AutoSize = True
        Me.ucrReceiverMultipleUnhide.frmParent = Me
        Me.ucrReceiverMultipleUnhide.Location = New System.Drawing.Point(233, 62)
        Me.ucrReceiverMultipleUnhide.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleUnhide.Name = "ucrReceiverMultipleUnhide"
        Me.ucrReceiverMultipleUnhide.Selector = Nothing
        Me.ucrReceiverMultipleUnhide.Size = New System.Drawing.Size(120, 112)
        Me.ucrReceiverMultipleUnhide.strNcFilePath = ""
        Me.ucrReceiverMultipleUnhide.TabIndex = 9
        Me.ucrReceiverMultipleUnhide.ucrSelector = Nothing
        '
        'lblUnhideDataFrame
        '
        Me.lblUnhideDataFrame.AutoSize = True
        Me.lblUnhideDataFrame.Location = New System.Drawing.Point(231, 47)
        Me.lblUnhideDataFrame.Name = "lblUnhideDataFrame"
        Me.lblUnhideDataFrame.Size = New System.Drawing.Size(125, 13)
        Me.lblUnhideDataFrame.TabIndex = 10
        Me.lblUnhideDataFrame.Text = "Unhidden Data Frame(s):"
        '
        'lblHiddenNumber
        '
        Me.lblHiddenNumber.AutoSize = True
        Me.lblHiddenNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHiddenNumber.Location = New System.Drawing.Point(349, 47)
        Me.lblHiddenNumber.Name = "lblHiddenNumber"
        Me.lblHiddenNumber.Size = New System.Drawing.Size(21, 13)
        Me.lblHiddenNumber.TabIndex = 11
        Me.lblHiddenNumber.Text = "DF"
        '
        'lblUnHiddenNumber
        '
        Me.lblUnHiddenNumber.AutoSize = True
        Me.lblUnHiddenNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUnHiddenNumber.Location = New System.Drawing.Point(349, 47)
        Me.lblUnHiddenNumber.Name = "lblUnHiddenNumber"
        Me.lblUnHiddenNumber.Size = New System.Drawing.Size(21, 13)
        Me.lblUnHiddenNumber.TabIndex = 12
        Me.lblUnHiddenNumber.Text = "DF"
        '
        'dlgHideDataframes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(417, 256)
        Me.Controls.Add(Me.lblUnHiddenNumber)
        Me.Controls.Add(Me.lblHiddenNumber)
        Me.Controls.Add(Me.rdoHideDataFrame)
        Me.Controls.Add(Me.rdoUnhideDataFrame)
        Me.Controls.Add(Me.lblHiddenDataFrames)
        Me.Controls.Add(Me.ucrReceiverMultiple)
        Me.Controls.Add(Me.lblDataFrames)
        Me.Controls.Add(Me.ucrSelectorForDataFrames)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlHideUnhide)
        Me.Controls.Add(Me.ucrReceiverMultipleUnhide)
        Me.Controls.Add(Me.lblUnhideDataFrame)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgHideDataframes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Hide_Dataframes"
        Me.Text = "Hide/Unhide Data Frame(s)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForDataFrames As ucrSelectorAddRemove
    Friend WithEvents lblDataFrames As Label
    Friend WithEvents lblHiddenDataFrames As Label
    Friend WithEvents ucrReceiverMultiple As ucrReceiverMultiple
    Friend WithEvents rdoHideDataFrame As RadioButton
    Friend WithEvents rdoUnhideDataFrame As RadioButton
    Friend WithEvents ucrPnlHideUnhide As UcrPanel
    Friend WithEvents ucrReceiverMultipleUnhide As ucrReceiverMultiple
    Friend WithEvents lblUnhideDataFrame As Label
    Friend WithEvents lblUnHiddenNumber As Label
    Friend WithEvents lblHiddenNumber As Label
End Class
