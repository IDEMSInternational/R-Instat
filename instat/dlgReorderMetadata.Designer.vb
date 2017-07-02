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
Partial Class dlgReorderMetadata
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFrameReoderMetadata = New instat.ucrDataFrame()
        Me.lblMetataDataColumns = New System.Windows.Forms.Label()
        Me.ucrReorderMetadata = New instat.ucrReorder()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 182)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 3
        '
        'ucrDataFrameReoderMetadata
        '
        Me.ucrDataFrameReoderMetadata.bAddRemoveParameter = True
        Me.ucrDataFrameReoderMetadata.bChangeParameterValue = True
        Me.ucrDataFrameReoderMetadata.bUseCurrentFilter = True
        Me.ucrDataFrameReoderMetadata.Location = New System.Drawing.Point(10, 10)
        Me.ucrDataFrameReoderMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameReoderMetadata.Name = "ucrDataFrameReoderMetadata"
        Me.ucrDataFrameReoderMetadata.Size = New System.Drawing.Size(120, 50)
        Me.ucrDataFrameReoderMetadata.TabIndex = 2
        '
        'lblMetataDataColumns
        '
        Me.lblMetataDataColumns.Location = New System.Drawing.Point(187, 24)
        Me.lblMetataDataColumns.Name = "lblMetataDataColumns"
        Me.lblMetataDataColumns.Size = New System.Drawing.Size(100, 23)
        Me.lblMetataDataColumns.TabIndex = 1
        Me.lblMetataDataColumns.Text = "Metadata Columns:"
        '
        'ucrReorderMetadata
        '
        Me.ucrReorderMetadata.Location = New System.Drawing.Point(181, 38)
        Me.ucrReorderMetadata.Name = "ucrReorderMetadata"
        Me.ucrReorderMetadata.Size = New System.Drawing.Size(154, 113)
        Me.ucrReorderMetadata.TabIndex = 0
        Me.ucrReorderMetadata.ucrDataFrameList = Nothing
        Me.ucrReorderMetadata.ucrReceiver = Nothing
        '
        'dlgReoderMetadata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 242)
        Me.Controls.Add(Me.ucrReorderMetadata)
        Me.Controls.Add(Me.lblMetataDataColumns)
        Me.Controls.Add(Me.ucrDataFrameReoderMetadata)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReoderMetadata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Reoder_Metadata"
        Me.Text = "Reoder Metadata"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameReoderMetadata As ucrDataFrame
    Friend WithEvents lblMetataDataColumns As Label
    Friend WithEvents ucrReorderMetadata As ucrReorder
End Class
