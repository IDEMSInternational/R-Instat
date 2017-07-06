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
Partial Class dlgExportToOpenRefine
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
        Me.lblNameDataSet = New System.Windows.Forms.Label()
        Me.ucrDataFrameOpenRefine = New instat.ucrDataFrame()
        Me.ucrChkOpenBrowser = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputDatasetName = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'lblNameDataSet
        '
        Me.lblNameDataSet.AutoSize = True
        Me.lblNameDataSet.Location = New System.Drawing.Point(10, 62)
        Me.lblNameDataSet.Name = "lblNameDataSet"
        Me.lblNameDataSet.Size = New System.Drawing.Size(78, 13)
        Me.lblNameDataSet.TabIndex = 1
        Me.lblNameDataSet.Text = "Dataset Name:"
        '
        'ucrDataFrameOpenRefine
        '
        Me.ucrDataFrameOpenRefine.bUseCurrentFilter = True
        Me.ucrDataFrameOpenRefine.Location = New System.Drawing.Point(10, 10)
        Me.ucrDataFrameOpenRefine.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameOpenRefine.Name = "ucrDataFrameOpenRefine"
        Me.ucrDataFrameOpenRefine.Size = New System.Drawing.Size(128, 41)
        Me.ucrDataFrameOpenRefine.TabIndex = 0
        '
        'ucrChkOpenBrowser
        '
        Me.ucrChkOpenBrowser.Checked = False
        Me.ucrChkOpenBrowser.Location = New System.Drawing.Point(10, 86)
        Me.ucrChkOpenBrowser.Name = "ucrChkOpenBrowser"
        Me.ucrChkOpenBrowser.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkOpenBrowser.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 112)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(407, 52)
        Me.ucrBase.TabIndex = 4
        '
        'ucrInputDatasetName
        '
        Me.ucrInputDatasetName.AddQuotesIfUnrecognised = True
        Me.ucrInputDatasetName.IsMultiline = False
        Me.ucrInputDatasetName.IsReadOnly = False
        Me.ucrInputDatasetName.Location = New System.Drawing.Point(91, 59)
        Me.ucrInputDatasetName.Name = "ucrInputDatasetName"
        Me.ucrInputDatasetName.Size = New System.Drawing.Size(149, 21)
        Me.ucrInputDatasetName.TabIndex = 2
        '
        'dlgExportToOpenRefine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 170)
        Me.Controls.Add(Me.ucrDataFrameOpenRefine)
        Me.Controls.Add(Me.ucrChkOpenBrowser)
        Me.Controls.Add(Me.lblNameDataSet)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrInputDatasetName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportToOpenRefine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export to OpenRefine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrInputDatasetName As ucrInputTextBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblNameDataSet As Label
    Friend WithEvents ucrChkOpenBrowser As ucrCheck
    Friend WithEvents ucrDataFrameOpenRefine As ucrDataFrame
End Class
