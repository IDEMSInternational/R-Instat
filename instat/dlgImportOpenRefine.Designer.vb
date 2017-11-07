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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgImportOpenRefine))
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
        resources.ApplyResources(Me.lblNameDataSet, "lblNameDataSet")
        Me.lblNameDataSet.Name = "lblNameDataSet"
        '
        'ucrInputProjectName
        '
        Me.ucrInputProjectName.AddQuotesIfUnrecognised = True
        Me.ucrInputProjectName.IsMultiline = False
        Me.ucrInputProjectName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputProjectName, "ucrInputProjectName")
        Me.ucrInputProjectName.Name = "ucrInputProjectName"
        '
        'lblFormat
        '
        resources.ApplyResources(Me.lblFormat, "lblFormat")
        Me.lblFormat.Name = "lblFormat"
        '
        'ucrInputFormat
        '
        Me.ucrInputFormat.AddQuotesIfUnrecognised = True
        Me.ucrInputFormat.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFormat, "ucrInputFormat")
        Me.ucrInputFormat.Name = "ucrInputFormat"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrNewDataFrameName
        '
        resources.ApplyResources(Me.ucrNewDataFrameName, "ucrNewDataFrameName")
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'ucrInputProjectID
        '
        Me.ucrInputProjectID.AddQuotesIfUnrecognised = True
        Me.ucrInputProjectID.IsMultiline = False
        Me.ucrInputProjectID.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputProjectID, "ucrInputProjectID")
        Me.ucrInputProjectID.Name = "ucrInputProjectID"
        '
        'dlgImportOpenRefine
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
