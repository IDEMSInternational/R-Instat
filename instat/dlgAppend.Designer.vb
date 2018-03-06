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
Partial Class dlgAppend
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgAppend))
        Me.lblAppendToDataframe = New System.Windows.Forms.Label()
        Me.lblDataframes = New System.Windows.Forms.Label()
        Me.lblIDColName = New System.Windows.Forms.Label()
        Me.ucrInputIDColName = New instat.ucrInputTextBox()
        Me.ucrReceiverAppendDataframe = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDataframes = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrChkIncludeIDColumn = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblAppendToDataframe
        '
        resources.ApplyResources(Me.lblAppendToDataframe, "lblAppendToDataframe")
        Me.lblAppendToDataframe.Name = "lblAppendToDataframe"
        '
        'lblDataframes
        '
        resources.ApplyResources(Me.lblDataframes, "lblDataframes")
        Me.lblDataframes.Name = "lblDataframes"
        '
        'lblIDColName
        '
        resources.ApplyResources(Me.lblIDColName, "lblIDColName")
        Me.lblIDColName.Name = "lblIDColName"
        '
        'ucrInputIDColName
        '
        Me.ucrInputIDColName.AddQuotesIfUnrecognised = True
        Me.ucrInputIDColName.IsMultiline = False
        Me.ucrInputIDColName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputIDColName, "ucrInputIDColName")
        Me.ucrInputIDColName.Name = "ucrInputIDColName"
        '
        'ucrReceiverAppendDataframe
        '
        Me.ucrReceiverAppendDataframe.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverAppendDataframe, "ucrReceiverAppendDataframe")
        Me.ucrReceiverAppendDataframe.Name = "ucrReceiverAppendDataframe"
        Me.ucrReceiverAppendDataframe.Selector = Nothing
        Me.ucrReceiverAppendDataframe.strNcFilePath = ""
        Me.ucrReceiverAppendDataframe.ucrSelector = Nothing
        '
        'ucrSelectorDataframes
        '
        Me.ucrSelectorDataframes.bShowHiddenColumns = False
        resources.ApplyResources(Me.ucrSelectorDataframes, "ucrSelectorDataframes")
        Me.ucrSelectorDataframes.Name = "ucrSelectorDataframes"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSaveGraph
        '
        resources.ApplyResources(Me.ucrSaveGraph, "ucrSaveGraph")
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        '
        'ucrChkIncludeIDColumn
        '
        Me.ucrChkIncludeIDColumn.Checked = False
        resources.ApplyResources(Me.ucrChkIncludeIDColumn, "ucrChkIncludeIDColumn")
        Me.ucrChkIncludeIDColumn.Name = "ucrChkIncludeIDColumn"
        '
        'dlgAppend
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkIncludeIDColumn)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrInputIDColName)
        Me.Controls.Add(Me.lblDataframes)
        Me.Controls.Add(Me.lblIDColName)
        Me.Controls.Add(Me.lblAppendToDataframe)
        Me.Controls.Add(Me.ucrReceiverAppendDataframe)
        Me.Controls.Add(Me.ucrSelectorDataframes)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAppend"
        Me.Tag = "Append_Data_Frames"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDataframes As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverAppendDataframe As ucrReceiverMultiple
    Friend WithEvents lblAppendToDataframe As Label
    Friend WithEvents lblDataframes As Label
    Friend WithEvents lblIDColName As Label
    Friend WithEvents ucrInputIDColName As ucrInputTextBox
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrChkIncludeIDColumn As ucrCheck
End Class