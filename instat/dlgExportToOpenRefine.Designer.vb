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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgExportToOpenRefine))
        Me.lblNameDataSet = New System.Windows.Forms.Label()
        Me.ucrDataFrameOpenRefine = New instat.ucrDataFrame()
        Me.ucrChkOpenBrowser = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputDatasetName = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'lblNameDataSet
        '
        resources.ApplyResources(Me.lblNameDataSet, "lblNameDataSet")
        Me.lblNameDataSet.Name = "lblNameDataSet"
        '
        'ucrDataFrameOpenRefine
        '
        Me.ucrDataFrameOpenRefine.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrDataFrameOpenRefine, "ucrDataFrameOpenRefine")
        Me.ucrDataFrameOpenRefine.Name = "ucrDataFrameOpenRefine"
        '
        'ucrChkOpenBrowser
        '
        Me.ucrChkOpenBrowser.Checked = False
        resources.ApplyResources(Me.ucrChkOpenBrowser, "ucrChkOpenBrowser")
        Me.ucrChkOpenBrowser.Name = "ucrChkOpenBrowser"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrInputDatasetName
        '
        Me.ucrInputDatasetName.AddQuotesIfUnrecognised = True
        Me.ucrInputDatasetName.IsMultiline = False
        Me.ucrInputDatasetName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDatasetName, "ucrInputDatasetName")
        Me.ucrInputDatasetName.Name = "ucrInputDatasetName"
        '
        'dlgExportToOpenRefine
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrDataFrameOpenRefine)
        Me.Controls.Add(Me.ucrChkOpenBrowser)
        Me.Controls.Add(Me.lblNameDataSet)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrInputDatasetName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportToOpenRefine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrInputDatasetName As ucrInputTextBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblNameDataSet As Label
    Friend WithEvents ucrChkOpenBrowser As ucrCheck
    Friend WithEvents ucrDataFrameOpenRefine As ucrDataFrame
End Class
