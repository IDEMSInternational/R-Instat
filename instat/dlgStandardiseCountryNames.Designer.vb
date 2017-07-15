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
Partial Class dlgStandardiseCountryNames
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
        Me.lblCountryNames = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverCountryNames = New instat.ucrReceiverMultiple()
        Me.ucrSelectorStandardiseCountry = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblCountryNames
        '
        Me.lblCountryNames.AutoSize = True
        Me.lblCountryNames.Location = New System.Drawing.Point(267, 45)
        Me.lblCountryNames.Name = "lblCountryNames"
        Me.lblCountryNames.Size = New System.Drawing.Size(82, 13)
        Me.lblCountryNames.TabIndex = 1
        Me.lblCountryNames.Text = "Country Names:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 198)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 3
        '
        'ucrReceiverCountryNames
        '
        Me.ucrReceiverCountryNames.frmParent = Me
        Me.ucrReceiverCountryNames.Location = New System.Drawing.Point(267, 60)
        Me.ucrReceiverCountryNames.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCountryNames.Name = "ucrReceiverCountryNames"
        Me.ucrReceiverCountryNames.Selector = Nothing
        Me.ucrReceiverCountryNames.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverCountryNames.strNcFilePath = ""
        Me.ucrReceiverCountryNames.TabIndex = 2
        Me.ucrReceiverCountryNames.ucrSelector = Nothing
        '
        'ucrSelectorStandardiseCountry
        '
        Me.ucrSelectorStandardiseCountry.bShowHiddenColumns = False
        Me.ucrSelectorStandardiseCountry.bUseCurrentFilter = True
        Me.ucrSelectorStandardiseCountry.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorStandardiseCountry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStandardiseCountry.Name = "ucrSelectorStandardiseCountry"
        Me.ucrSelectorStandardiseCountry.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorStandardiseCountry.TabIndex = 0
        '
        'dlgStandardiseCountryNames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 253)
        Me.Controls.Add(Me.lblCountryNames)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverCountryNames)
        Me.Controls.Add(Me.ucrSelectorStandardiseCountry)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStandardiseCountryNames"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Standardise Country Names"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCountryNames As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverCountryNames As ucrReceiverMultiple
    Friend WithEvents ucrSelectorStandardiseCountry As ucrSelectorByDataFrameAddRemove
End Class
