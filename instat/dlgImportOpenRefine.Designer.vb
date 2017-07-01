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
Partial Class dlgImportOpenRefine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNameDataSet = New System.Windows.Forms.Label()
        Me.ucrInputProjectName = New instat.ucrInputTextBox()
        Me.lblFormat = New System.Windows.Forms.Label()
        Me.ucrInputFormat = New instat.ucrInputComboBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNewDataFrameName = New instat.ucrSave()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrInputProjectID = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'lblNameDataSet
        '
        Me.lblNameDataSet.AutoSize = True
        Me.lblNameDataSet.Location = New System.Drawing.Point(12, 14)
        Me.lblNameDataSet.Name = "lblNameDataSet"
        Me.lblNameDataSet.Size = New System.Drawing.Size(74, 13)
        Me.lblNameDataSet.TabIndex = 0
        Me.lblNameDataSet.Text = "Project Name:"
        '
        'ucrInputProjectName
        '
        Me.ucrInputProjectName.AddQuotesIfUnrecognised = True
        Me.ucrInputProjectName.IsMultiline = False
        Me.ucrInputProjectName.IsReadOnly = False
        Me.ucrInputProjectName.Location = New System.Drawing.Point(93, 12)
        Me.ucrInputProjectName.Name = "ucrInputProjectName"
        Me.ucrInputProjectName.Size = New System.Drawing.Size(186, 21)
        Me.ucrInputProjectName.TabIndex = 1
        '
        'lblFormat
        '
        Me.lblFormat.AutoSize = True
        Me.lblFormat.Location = New System.Drawing.Point(12, 70)
        Me.lblFormat.Name = "lblFormat"
        Me.lblFormat.Size = New System.Drawing.Size(42, 13)
        Me.lblFormat.TabIndex = 4
        Me.lblFormat.Text = "Format:"
        '
        'ucrInputFormat
        '
        Me.ucrInputFormat.AddQuotesIfUnrecognised = True
        Me.ucrInputFormat.IsReadOnly = False
        Me.ucrInputFormat.Location = New System.Drawing.Point(93, 66)
        Me.ucrInputFormat.Name = "ucrInputFormat"
        Me.ucrInputFormat.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputFormat.TabIndex = 5
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 122)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 7
        '
        'ucrNewDataFrameName
        '
        Me.ucrNewDataFrameName.Location = New System.Drawing.Point(12, 95)
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        Me.ucrNewDataFrameName.Size = New System.Drawing.Size(301, 24)
        Me.ucrNewDataFrameName.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Project ID:"
        '
        'ucrInputProjectID
        '
        Me.ucrInputProjectID.AddQuotesIfUnrecognised = True
        Me.ucrInputProjectID.IsMultiline = False
        Me.ucrInputProjectID.IsReadOnly = False
        Me.ucrInputProjectID.Location = New System.Drawing.Point(93, 39)
        Me.ucrInputProjectID.Name = "ucrInputProjectID"
        Me.ucrInputProjectID.Size = New System.Drawing.Size(186, 21)
        Me.ucrInputProjectID.TabIndex = 3
        '
        'dlgImportOpenRefine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 178)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrInputProjectID)
        Me.Controls.Add(Me.ucrNewDataFrameName)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrInputFormat)
        Me.Controls.Add(Me.lblFormat)
        Me.Controls.Add(Me.lblNameDataSet)
        Me.Controls.Add(Me.ucrInputProjectName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportOpenRefine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import from OpenRefine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNameDataSet As Label
    Friend WithEvents ucrInputProjectName As ucrInputTextBox
    Friend WithEvents lblFormat As Label
    Friend WithEvents ucrInputFormat As ucrInputComboBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrNewDataFrameName As ucrSave
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrInputProjectID As ucrInputTextBox
End Class
