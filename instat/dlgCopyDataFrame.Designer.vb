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
Partial Class dlgCopyDataFrame
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
        Me.ucrDataFrameCopySheets = New instat.ucrDataFrame()
        Me.ucrInputLabel = New instat.ucrInputTextBox()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.ucrInputNewDataFrameName = New instat.ucrInputTextBox()
        Me.lblNewName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 117)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 5
        '
        'ucrDataFrameCopySheets
        '
        Me.ucrDataFrameCopySheets.bUseCurrentFilter = True
        Me.ucrDataFrameCopySheets.Location = New System.Drawing.Point(10, 10)
        Me.ucrDataFrameCopySheets.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameCopySheets.Name = "ucrDataFrameCopySheets"
        Me.ucrDataFrameCopySheets.Size = New System.Drawing.Size(120, 40)
        Me.ucrDataFrameCopySheets.TabIndex = 0
        '
        'ucrInputLabel
        '
        Me.ucrInputLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputLabel.IsMultiline = False
        Me.ucrInputLabel.IsReadOnly = False
        Me.ucrInputLabel.Location = New System.Drawing.Point(196, 79)
        Me.ucrInputLabel.Name = "ucrInputLabel"
        Me.ucrInputLabel.Size = New System.Drawing.Size(131, 22)
        Me.ucrInputLabel.TabIndex = 4
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Location = New System.Drawing.Point(196, 64)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(94, 13)
        Me.lblLabel.TabIndex = 3
        Me.lblLabel.Text = "Data Frame Label:"
        '
        'ucrInputNewDataFrameName
        '
        Me.ucrInputNewDataFrameName.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDataFrameName.IsMultiline = False
        Me.ucrInputNewDataFrameName.IsReadOnly = False
        Me.ucrInputNewDataFrameName.Location = New System.Drawing.Point(196, 29)
        Me.ucrInputNewDataFrameName.Name = "ucrInputNewDataFrameName"
        Me.ucrInputNewDataFrameName.Size = New System.Drawing.Size(131, 21)
        Me.ucrInputNewDataFrameName.TabIndex = 2
        '
        'lblNewName
        '
        Me.lblNewName.Location = New System.Drawing.Point(196, 14)
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.Size = New System.Drawing.Size(100, 26)
        Me.lblNewName.TabIndex = 1
        Me.lblNewName.Tag = "New_Name"
        Me.lblNewName.Text = "New Name:"
        '
        'dlgCopyDataFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 175)
        Me.Controls.Add(Me.ucrInputLabel)
        Me.Controls.Add(Me.lblLabel)
        Me.Controls.Add(Me.ucrInputNewDataFrameName)
        Me.Controls.Add(Me.lblNewName)
        Me.Controls.Add(Me.ucrDataFrameCopySheets)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCopyDataFrame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copy Data Frame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameCopySheets As ucrDataFrame
    Friend WithEvents ucrInputLabel As ucrInputTextBox
    Friend WithEvents lblLabel As Label
    Friend WithEvents ucrInputNewDataFrameName As ucrInputTextBox
    Friend WithEvents lblNewName As Label
End Class
