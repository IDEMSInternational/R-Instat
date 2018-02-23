﻿' R- Instat
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
Partial Class dlgSaveAs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgSaveAs))
        Me.ucrBase = New instat.ucrButtons()
        Me.lblSaveDataTo = New System.Windows.Forms.Label()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.cmdChooseFile = New System.Windows.Forms.Button()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'lblSaveDataTo
        '
        resources.ApplyResources(Me.lblSaveDataTo, "lblSaveDataTo")
        Me.lblSaveDataTo.Name = "lblSaveDataTo"
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFilePath, "ucrInputFilePath")
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        '
        'cmdChooseFile
        '
        resources.ApplyResources(Me.cmdChooseFile, "cmdChooseFile")
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.UseVisualStyleBackColor = True
        '
        'lblConfirm
        '
        resources.ApplyResources(Me.lblConfirm, "lblConfirm")
        Me.lblConfirm.Name = "lblConfirm"
        '
        'dlgSaveAs
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.lblSaveDataTo)
        Me.Controls.Add(Me.cmdChooseFile)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSaveAs"
        Me.Tag = "Save_Data_As"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblSaveDataTo As Label
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents cmdChooseFile As Button
    Friend WithEvents lblConfirm As Label
End Class
