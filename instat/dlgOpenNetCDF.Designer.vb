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
Partial Class dlgOpenNetCDF
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
        Me.cmdOpenDataSet = New System.Windows.Forms.Button()
        Me.lblFileOpenPath = New System.Windows.Forms.Label()
        Me.lblMainDataName = New System.Windows.Forms.Label()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrInputDataName = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkIncludeMetadata = New instat.ucrCheck()
        Me.ucrChkKeepRawTime = New instat.ucrCheck()
        Me.ucrChkOnlyDataVariables = New instat.ucrCheck()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdDetails = New System.Windows.Forms.Button()
        Me.ucrInputFileDetails = New instat.ucrInputTextBox()
        Me.rdoShort = New System.Windows.Forms.RadioButton()
        Me.rdoMedium = New System.Windows.Forms.RadioButton()
        Me.rdoLong = New System.Windows.Forms.RadioButton()
        Me.ucrPnlFileDetails = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'cmdOpenDataSet
        '
        Me.cmdOpenDataSet.Location = New System.Drawing.Point(332, 19)
        Me.cmdOpenDataSet.Name = "cmdOpenDataSet"
        Me.cmdOpenDataSet.Size = New System.Drawing.Size(77, 23)
        Me.cmdOpenDataSet.TabIndex = 2
        Me.cmdOpenDataSet.Tag = "Browse"
        Me.cmdOpenDataSet.Text = "Browse"
        Me.cmdOpenDataSet.UseVisualStyleBackColor = True
        '
        'lblFileOpenPath
        '
        Me.lblFileOpenPath.AutoSize = True
        Me.lblFileOpenPath.Location = New System.Drawing.Point(10, 24)
        Me.lblFileOpenPath.Name = "lblFileOpenPath"
        Me.lblFileOpenPath.Size = New System.Drawing.Size(26, 13)
        Me.lblFileOpenPath.TabIndex = 0
        Me.lblFileOpenPath.Text = "File:"
        '
        'lblMainDataName
        '
        Me.lblMainDataName.AutoSize = True
        Me.lblMainDataName.Location = New System.Drawing.Point(10, 137)
        Me.lblMainDataName.Name = "lblMainDataName"
        Me.lblMainDataName.Size = New System.Drawing.Size(122, 13)
        Me.lblMainDataName.TabIndex = 6
        Me.lblMainDataName.Tag = "Main_Data_Frame_Name:"
        Me.lblMainDataName.Text = "Main Data Frame Name:"
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(52, 20)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(274, 21)
        Me.ucrInputFilePath.TabIndex = 1
        '
        'ucrInputDataName
        '
        Me.ucrInputDataName.AddQuotesIfUnrecognised = True
        Me.ucrInputDataName.IsMultiline = False
        Me.ucrInputDataName.IsReadOnly = False
        Me.ucrInputDataName.Location = New System.Drawing.Point(138, 134)
        Me.ucrInputDataName.Name = "ucrInputDataName"
        Me.ucrInputDataName.Size = New System.Drawing.Size(188, 21)
        Me.ucrInputDataName.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 161)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 15
        '
        'ucrChkIncludeMetadata
        '
        Me.ucrChkIncludeMetadata.Checked = False
        Me.ucrChkIncludeMetadata.Location = New System.Drawing.Point(10, 109)
        Me.ucrChkIncludeMetadata.Name = "ucrChkIncludeMetadata"
        Me.ucrChkIncludeMetadata.Size = New System.Drawing.Size(162, 20)
        Me.ucrChkIncludeMetadata.TabIndex = 5
        '
        'ucrChkKeepRawTime
        '
        Me.ucrChkKeepRawTime.Checked = False
        Me.ucrChkKeepRawTime.Location = New System.Drawing.Point(10, 83)
        Me.ucrChkKeepRawTime.Name = "ucrChkKeepRawTime"
        Me.ucrChkKeepRawTime.Size = New System.Drawing.Size(162, 20)
        Me.ucrChkKeepRawTime.TabIndex = 4
        '
        'ucrChkOnlyDataVariables
        '
        Me.ucrChkOnlyDataVariables.Checked = False
        Me.ucrChkOnlyDataVariables.Location = New System.Drawing.Point(10, 57)
        Me.ucrChkOnlyDataVariables.Name = "ucrChkOnlyDataVariables"
        Me.ucrChkOnlyDataVariables.Size = New System.Drawing.Size(162, 20)
        Me.ucrChkOnlyDataVariables.TabIndex = 3
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(332, 132)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(77, 23)
        Me.cmdOptions.TabIndex = 14
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdDetails
        '
        Me.cmdDetails.Location = New System.Drawing.Point(332, 103)
        Me.cmdDetails.Name = "cmdDetails"
        Me.cmdDetails.Size = New System.Drawing.Size(77, 23)
        Me.cmdDetails.TabIndex = 8
        Me.cmdDetails.Tag = "Show_Details"
        Me.cmdDetails.Text = "Show Details >>"
        Me.cmdDetails.UseVisualStyleBackColor = True
        '
        'ucrInputFileDetails
        '
        Me.ucrInputFileDetails.AddQuotesIfUnrecognised = True
        Me.ucrInputFileDetails.IsMultiline = True
        Me.ucrInputFileDetails.IsReadOnly = True
        Me.ucrInputFileDetails.Location = New System.Drawing.Point(429, 46)
        Me.ucrInputFileDetails.Name = "ucrInputFileDetails"
        Me.ucrInputFileDetails.Size = New System.Drawing.Size(320, 159)
        Me.ucrInputFileDetails.TabIndex = 13
        '
        'rdoShort
        '
        Me.rdoShort.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoShort.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoShort.FlatAppearance.BorderSize = 2
        Me.rdoShort.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoShort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoShort.Location = New System.Drawing.Point(477, 13)
        Me.rdoShort.Name = "rdoShort"
        Me.rdoShort.Size = New System.Drawing.Size(76, 27)
        Me.rdoShort.TabIndex = 10
        Me.rdoShort.TabStop = True
        Me.rdoShort.Text = "Short"
        Me.rdoShort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoShort.UseVisualStyleBackColor = True
        '
        'rdoMedium
        '
        Me.rdoMedium.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMedium.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMedium.FlatAppearance.BorderSize = 2
        Me.rdoMedium.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMedium.Location = New System.Drawing.Point(550, 13)
        Me.rdoMedium.Name = "rdoMedium"
        Me.rdoMedium.Size = New System.Drawing.Size(76, 27)
        Me.rdoMedium.TabIndex = 11
        Me.rdoMedium.TabStop = True
        Me.rdoMedium.Text = "Medium"
        Me.rdoMedium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMedium.UseVisualStyleBackColor = True
        '
        'rdoLong
        '
        Me.rdoLong.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoLong.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLong.FlatAppearance.BorderSize = 2
        Me.rdoLong.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoLong.Location = New System.Drawing.Point(624, 13)
        Me.rdoLong.Name = "rdoLong"
        Me.rdoLong.Size = New System.Drawing.Size(76, 27)
        Me.rdoLong.TabIndex = 12
        Me.rdoLong.TabStop = True
        Me.rdoLong.Text = "Long"
        Me.rdoLong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoLong.UseVisualStyleBackColor = True
        '
        'ucrPnlFileDetails
        '
        Me.ucrPnlFileDetails.Location = New System.Drawing.Point(462, 11)
        Me.ucrPnlFileDetails.Name = "ucrPnlFileDetails"
        Me.ucrPnlFileDetails.Size = New System.Drawing.Size(254, 30)
        Me.ucrPnlFileDetails.TabIndex = 9
        '
        'dlgOpenNetCDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 217)
        Me.Controls.Add(Me.rdoLong)
        Me.Controls.Add(Me.rdoMedium)
        Me.Controls.Add(Me.rdoShort)
        Me.Controls.Add(Me.ucrInputFileDetails)
        Me.Controls.Add(Me.cmdDetails)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrChkOnlyDataVariables)
        Me.Controls.Add(Me.ucrChkKeepRawTime)
        Me.Controls.Add(Me.ucrChkIncludeMetadata)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.ucrInputDataName)
        Me.Controls.Add(Me.cmdOpenDataSet)
        Me.Controls.Add(Me.lblFileOpenPath)
        Me.Controls.Add(Me.lblMainDataName)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlFileDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOpenNetCDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Open NetCDF"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents ucrInputDataName As ucrInputTextBox
    Friend WithEvents cmdOpenDataSet As Button
    Friend WithEvents lblFileOpenPath As Label
    Friend WithEvents lblMainDataName As Label
    Friend WithEvents ucrChkIncludeMetadata As ucrCheck
    Friend WithEvents ucrChkKeepRawTime As ucrCheck
    Friend WithEvents ucrChkOnlyDataVariables As ucrCheck
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdDetails As Button
    Friend WithEvents ucrInputFileDetails As ucrInputTextBox
    Friend WithEvents rdoShort As RadioButton
    Friend WithEvents rdoMedium As RadioButton
    Friend WithEvents rdoLong As RadioButton
    Friend WithEvents ucrPnlFileDetails As UcrPanel
End Class

