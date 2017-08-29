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
        Me.lblAppendToDataframe = New System.Windows.Forms.Label()
        Me.lblDataframes = New System.Windows.Forms.Label()
        Me.lblIDColName = New System.Windows.Forms.Label()
        Me.ucrInputIDColName = New instat.ucrInputTextBox()
        Me.ucrSelectorDataframes = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrChkIncludeIDColumn = New instat.ucrCheck()
        Me.ucrReceiverAppendDataframe = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'lblAppendToDataframe
        '
        Me.lblAppendToDataframe.AutoSize = True
        Me.lblAppendToDataframe.Location = New System.Drawing.Point(252, 45)
        Me.lblAppendToDataframe.Name = "lblAppendToDataframe"
        Me.lblAppendToDataframe.Size = New System.Drawing.Size(115, 13)
        Me.lblAppendToDataframe.TabIndex = 2
        Me.lblAppendToDataframe.Text = "Selected Data Frames:"
        '
        'lblDataframes
        '
        Me.lblDataframes.AutoSize = True
        Me.lblDataframes.Location = New System.Drawing.Point(12, 17)
        Me.lblDataframes.Name = "lblDataframes"
        Me.lblDataframes.Size = New System.Drawing.Size(70, 13)
        Me.lblDataframes.TabIndex = 0
        Me.lblDataframes.Text = "Data Frames:"
        '
        'lblIDColName
        '
        Me.lblIDColName.AutoSize = True
        Me.lblIDColName.Location = New System.Drawing.Point(136, 180)
        Me.lblIDColName.Name = "lblIDColName"
        Me.lblIDColName.Size = New System.Drawing.Size(90, 13)
        Me.lblIDColName.TabIndex = 5
        Me.lblIDColName.Text = "ID Column Name:"
        '
        'ucrInputIDColName
        '
        Me.ucrInputIDColName.AddQuotesIfUnrecognised = True
        Me.ucrInputIDColName.IsMultiline = False
        Me.ucrInputIDColName.IsReadOnly = False
        Me.ucrInputIDColName.Location = New System.Drawing.Point(228, 176)
        Me.ucrInputIDColName.Name = "ucrInputIDColName"
        Me.ucrInputIDColName.Size = New System.Drawing.Size(180, 21)
        Me.ucrInputIDColName.TabIndex = 6
        '
        'ucrSelectorDataframes
        '
        Me.ucrSelectorDataframes.bShowHiddenColumns = False
        Me.ucrSelectorDataframes.Location = New System.Drawing.Point(10, 32)
        Me.ucrSelectorDataframes.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataframes.Name = "ucrSelectorDataframes"
        Me.ucrSelectorDataframes.Size = New System.Drawing.Size(216, 150)
        Me.ucrSelectorDataframes.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 228)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(400, 52)
        Me.ucrBase.TabIndex = 8
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 203)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(305, 24)
        Me.ucrSaveGraph.TabIndex = 7
        '
        'ucrChkIncludeIDColumn
        '
        Me.ucrChkIncludeIDColumn.Checked = False
        Me.ucrChkIncludeIDColumn.Location = New System.Drawing.Point(10, 177)
        Me.ucrChkIncludeIDColumn.Name = "ucrChkIncludeIDColumn"
        Me.ucrChkIncludeIDColumn.Size = New System.Drawing.Size(116, 20)
        Me.ucrChkIncludeIDColumn.TabIndex = 4
        '
        'ucrReceiverAppendDataframe
        '
        Me.ucrReceiverAppendDataframe.frmParent = Me
        Me.ucrReceiverAppendDataframe.Location = New System.Drawing.Point(255, 62)
        Me.ucrReceiverAppendDataframe.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAppendDataframe.Name = "ucrReceiverAppendDataframe"
        Me.ucrReceiverAppendDataframe.Selector = Nothing
        Me.ucrReceiverAppendDataframe.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverAppendDataframe.strNcFilePath = ""
        Me.ucrReceiverAppendDataframe.TabIndex = 9
        Me.ucrReceiverAppendDataframe.ucrSelector = Nothing
        '
        'dlgAppend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 288)
        Me.Controls.Add(Me.ucrReceiverAppendDataframe)
        Me.Controls.Add(Me.ucrChkIncludeIDColumn)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrInputIDColName)
        Me.Controls.Add(Me.lblDataframes)
        Me.Controls.Add(Me.lblIDColName)
        Me.Controls.Add(Me.lblAppendToDataframe)
        Me.Controls.Add(Me.ucrSelectorDataframes)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAppend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Append_Data_Frames"
        Me.Text = "Append Data Frames"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDataframes As ucrSelectorAddRemove
    Friend WithEvents lblAppendToDataframe As Label
    Friend WithEvents lblDataframes As Label
    Friend WithEvents lblIDColName As Label
    Friend WithEvents ucrInputIDColName As ucrInputTextBox
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrChkIncludeIDColumn As ucrCheck
    Friend WithEvents ucrReceiverAppendDataframe As ucrReceiverMultiple
End Class