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
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 178)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 1
        '
        'ucrSelectorForDataFrames
        '
        Me.ucrSelectorForDataFrames.AutoSize = True
        Me.ucrSelectorForDataFrames.bShowHiddenColumns = False
        Me.ucrSelectorForDataFrames.Location = New System.Drawing.Point(10, 28)
        Me.ucrSelectorForDataFrames.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDataFrames.Name = "ucrSelectorForDataFrames"
        Me.ucrSelectorForDataFrames.Size = New System.Drawing.Size(218, 147)
        Me.ucrSelectorForDataFrames.TabIndex = 2
        '
        'lblDataFrames
        '
        Me.lblDataFrames.AutoSize = True
        Me.lblDataFrames.Location = New System.Drawing.Point(10, 13)
        Me.lblDataFrames.Name = "lblDataFrames"
        Me.lblDataFrames.Size = New System.Drawing.Size(76, 13)
        Me.lblDataFrames.TabIndex = 3
        Me.lblDataFrames.Text = "Data Frame(s):"
        '
        'lblHiddenDataFrames
        '
        Me.lblHiddenDataFrames.AutoSize = True
        Me.lblHiddenDataFrames.Location = New System.Drawing.Point(248, 31)
        Me.lblHiddenDataFrames.Name = "lblHiddenDataFrames"
        Me.lblHiddenDataFrames.Size = New System.Drawing.Size(113, 13)
        Me.lblHiddenDataFrames.TabIndex = 4
        Me.lblHiddenDataFrames.Text = "Hidden Data Frame(s):"
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.AutoSize = True
        Me.ucrReceiverMultiple.frmParent = Me
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(248, 46)
        Me.ucrReceiverMultiple.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Selector = Nothing
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(120, 112)
        Me.ucrReceiverMultiple.strNcFilePath = ""
        Me.ucrReceiverMultiple.TabIndex = 5
        Me.ucrReceiverMultiple.ucrSelector = Nothing
        '
        'dlgHideDataframes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(422, 233)
        Me.Controls.Add(Me.lblHiddenDataFrames)
        Me.Controls.Add(Me.ucrReceiverMultiple)
        Me.Controls.Add(Me.lblDataFrames)
        Me.Controls.Add(Me.ucrSelectorForDataFrames)
        Me.Controls.Add(Me.ucrBase)
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
End Class
