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
Partial Class dlgDeleteSheet
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
        Me.lblDataframes = New System.Windows.Forms.Label()
        Me.lblAppendToDataframe = New System.Windows.Forms.Label()
        Me.ucrReceiverDataframes = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDataFramesToDelete = New instat.ucrSelectorAddRemove()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 178)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'lblDataframes
        '
        Me.lblDataframes.AutoSize = True
        Me.lblDataframes.Location = New System.Drawing.Point(14, 12)
        Me.lblDataframes.Name = "lblDataframes"
        Me.lblDataframes.Size = New System.Drawing.Size(70, 13)
        Me.lblDataframes.TabIndex = 4
        Me.lblDataframes.Text = "Data Frames:"
        '
        'lblAppendToDataframe
        '
        Me.lblAppendToDataframe.AutoSize = True
        Me.lblAppendToDataframe.Location = New System.Drawing.Point(254, 40)
        Me.lblAppendToDataframe.Name = "lblAppendToDataframe"
        Me.lblAppendToDataframe.Size = New System.Drawing.Size(115, 13)
        Me.lblAppendToDataframe.TabIndex = 6
        Me.lblAppendToDataframe.Text = "Selected Data Frames:"
        '
        'ucrReceiverDataframes
        '
        Me.ucrReceiverDataframes.frmParent = Me
        Me.ucrReceiverDataframes.Location = New System.Drawing.Point(254, 55)
        Me.ucrReceiverDataframes.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataframes.Name = "ucrReceiverDataframes"
        Me.ucrReceiverDataframes.Selector = Nothing
        Me.ucrReceiverDataframes.Size = New System.Drawing.Size(122, 104)
        Me.ucrReceiverDataframes.strNcFilePath = ""
        Me.ucrReceiverDataframes.TabIndex = 7
        Me.ucrReceiverDataframes.ucrSelector = Nothing
        '
        'ucrSelectorDataFramesToDelete
        '
        Me.ucrSelectorDataFramesToDelete.bShowHiddenColumns = False
        Me.ucrSelectorDataFramesToDelete.Location = New System.Drawing.Point(10, 27)
        Me.ucrSelectorDataFramesToDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataFramesToDelete.Name = "ucrSelectorDataFramesToDelete"
        Me.ucrSelectorDataFramesToDelete.Size = New System.Drawing.Size(216, 150)
        Me.ucrSelectorDataFramesToDelete.TabIndex = 5
        '
        'dlgDeleteSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 241)
        Me.Controls.Add(Me.lblDataframes)
        Me.Controls.Add(Me.lblAppendToDataframe)
        Me.Controls.Add(Me.ucrReceiverDataframes)
        Me.Controls.Add(Me.ucrSelectorDataFramesToDelete)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDeleteSheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Data Frame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblDataframes As Label
    Friend WithEvents lblAppendToDataframe As Label
    Friend WithEvents ucrReceiverDataframes As ucrReceiverMultiple
    Friend WithEvents ucrSelectorDataFramesToDelete As ucrSelectorAddRemove
End Class
