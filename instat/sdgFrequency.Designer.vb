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
Partial Class sdgFrequency
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgFrequency))
        Me.ucrBaseSubDialog = New instat.ucrButtonsSubdialogue()
        Me.ucrPnlDisplayType = New instat.UcrPanel()
        Me.rdoHorizontally = New System.Windows.Forms.RadioButton()
        Me.rdoVertically = New System.Windows.Forms.RadioButton()
        Me.rdoSeparateTables = New System.Windows.Forms.RadioButton()
        Me.ucrchkMargins = New instat.ucrCheck()
        Me.ucrchkDisplay = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'ucrBaseSubDialog
        '
        resources.ApplyResources(Me.ucrBaseSubDialog, "ucrBaseSubDialog")
        Me.ucrBaseSubDialog.Name = "ucrBaseSubDialog"
        '
        'ucrPnlDisplayType
        '
        resources.ApplyResources(Me.ucrPnlDisplayType, "ucrPnlDisplayType")
        Me.ucrPnlDisplayType.Name = "ucrPnlDisplayType"
        '
        'rdoHorizontally
        '
        resources.ApplyResources(Me.rdoHorizontally, "rdoHorizontally")
        Me.rdoHorizontally.Name = "rdoHorizontally"
        Me.rdoHorizontally.TabStop = True
        Me.rdoHorizontally.UseVisualStyleBackColor = True
        '
        'rdoVertically
        '
        resources.ApplyResources(Me.rdoVertically, "rdoVertically")
        Me.rdoVertically.Name = "rdoVertically"
        Me.rdoVertically.TabStop = True
        Me.rdoVertically.UseVisualStyleBackColor = True
        '
        'rdoSeparateTables
        '
        resources.ApplyResources(Me.rdoSeparateTables, "rdoSeparateTables")
        Me.rdoSeparateTables.Name = "rdoSeparateTables"
        Me.rdoSeparateTables.TabStop = True
        Me.rdoSeparateTables.UseVisualStyleBackColor = True
        '
        'ucrchkMargins
        '
        Me.ucrchkMargins.Checked = False
        resources.ApplyResources(Me.ucrchkMargins, "ucrchkMargins")
        Me.ucrchkMargins.Name = "ucrchkMargins"
        '
        'ucrchkDisplay
        '
        Me.ucrchkDisplay.Checked = False
        resources.ApplyResources(Me.ucrchkDisplay, "ucrchkDisplay")
        Me.ucrchkDisplay.Name = "ucrchkDisplay"
        '
        'sdgFrequency
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrchkMargins)
        Me.Controls.Add(Me.ucrchkDisplay)
        Me.Controls.Add(Me.rdoHorizontally)
        Me.Controls.Add(Me.rdoVertically)
        Me.Controls.Add(Me.rdoSeparateTables)
        Me.Controls.Add(Me.ucrBaseSubDialog)
        Me.Controls.Add(Me.ucrPnlDisplayType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgFrequency"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSubDialog As ucrButtonsSubdialogue
    Friend WithEvents ucrPnlDisplayType As UcrPanel
    Friend WithEvents rdoHorizontally As RadioButton
    Friend WithEvents rdoVertically As RadioButton
    Friend WithEvents rdoSeparateTables As RadioButton
    Friend WithEvents ucrchkMargins As ucrCheck
    Friend WithEvents ucrchkDisplay As ucrCheck
End Class
