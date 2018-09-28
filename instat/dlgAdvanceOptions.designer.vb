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
Partial Class dlgAdvanceOptions
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
        Me.chkMessages = New System.Windows.Forms.CheckBox()
        Me.chkConvert = New System.Windows.Forms.CheckBox()
        Me.chkCreate = New System.Windows.Forms.CheckBox()
        Me.txtDataTimePeriods = New System.Windows.Forms.TextBox()
        Me.txtImportedFrom = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblClimateObjectMetaData = New System.Windows.Forms.Label()
        Me.lblDataTimePeriods = New System.Windows.Forms.Label()
        Me.lblImportedFrom = New System.Windows.Forms.Label()
        Me.txtDataTablesMetaData = New System.Windows.Forms.TextBox()
        Me.txtDataTablesVariables = New System.Windows.Forms.TextBox()
        Me.lblDataTablesVariables = New System.Windows.Forms.Label()
        Me.lblDataTablesMetaData = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'chkMessages
        '
        Me.chkMessages.AutoSize = True
        Me.chkMessages.Location = New System.Drawing.Point(329, 161)
        Me.chkMessages.Name = "chkMessages"
        Me.chkMessages.Size = New System.Drawing.Size(81, 17)
        Me.chkMessages.TabIndex = 0
        Me.chkMessages.Tag = "Messages"
        Me.chkMessages.Text = "CheckBox1"
        Me.chkMessages.UseVisualStyleBackColor = True
        '
        'chkConvert
        '
        Me.chkConvert.AutoSize = True
        Me.chkConvert.Location = New System.Drawing.Point(191, 161)
        Me.chkConvert.Name = "chkConvert"
        Me.chkConvert.Size = New System.Drawing.Size(81, 17)
        Me.chkConvert.TabIndex = 1
        Me.chkConvert.Tag = "Convert"
        Me.chkConvert.Text = "CheckBox2"
        Me.chkConvert.UseVisualStyleBackColor = True
        '
        'chkCreate
        '
        Me.chkCreate.AutoSize = True
        Me.chkCreate.Location = New System.Drawing.Point(42, 161)
        Me.chkCreate.Name = "chkCreate"
        Me.chkCreate.Size = New System.Drawing.Size(81, 17)
        Me.chkCreate.TabIndex = 2
        Me.chkCreate.Tag = "Create"
        Me.chkCreate.Text = "CheckBox3"
        Me.chkCreate.UseVisualStyleBackColor = True
        '
        'txtDataTimePeriods
        '
        Me.txtDataTimePeriods.Location = New System.Drawing.Point(159, 64)
        Me.txtDataTimePeriods.Name = "txtDataTimePeriods"
        Me.txtDataTimePeriods.Size = New System.Drawing.Size(100, 20)
        Me.txtDataTimePeriods.TabIndex = 5
        Me.txtDataTimePeriods.Tag = "Data_Time_Periods"
        '
        'txtImportedFrom
        '
        Me.txtImportedFrom.Location = New System.Drawing.Point(159, 38)
        Me.txtImportedFrom.Name = "txtImportedFrom"
        Me.txtImportedFrom.Size = New System.Drawing.Size(100, 20)
        Me.txtImportedFrom.TabIndex = 6
        Me.txtImportedFrom.Tag = "Imported_From"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(159, 12)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 7
        '
        'lblClimateObjectMetaData
        '
        Me.lblClimateObjectMetaData.AutoSize = True
        Me.lblClimateObjectMetaData.Location = New System.Drawing.Point(39, 15)
        Me.lblClimateObjectMetaData.Name = "lblClimateObjectMetaData"
        Me.lblClimateObjectMetaData.Size = New System.Drawing.Size(39, 13)
        Me.lblClimateObjectMetaData.TabIndex = 8
        Me.lblClimateObjectMetaData.Tag = "Climate_Object_Meta_Data"
        Me.lblClimateObjectMetaData.Text = "Label1"
        '
        'lblDataTimePeriods
        '
        Me.lblDataTimePeriods.AutoSize = True
        Me.lblDataTimePeriods.Location = New System.Drawing.Point(39, 67)
        Me.lblDataTimePeriods.Name = "lblDataTimePeriods"
        Me.lblDataTimePeriods.Size = New System.Drawing.Size(39, 13)
        Me.lblDataTimePeriods.TabIndex = 9
        Me.lblDataTimePeriods.Tag = "Data_Time_Periods"
        Me.lblDataTimePeriods.Text = "Label2"
        '
        'lblImportedFrom
        '
        Me.lblImportedFrom.AutoSize = True
        Me.lblImportedFrom.Location = New System.Drawing.Point(39, 45)
        Me.lblImportedFrom.Name = "lblImportedFrom"
        Me.lblImportedFrom.Size = New System.Drawing.Size(39, 13)
        Me.lblImportedFrom.TabIndex = 10
        Me.lblImportedFrom.Tag = "Imported_From"
        Me.lblImportedFrom.Text = "Label3"
        '
        'txtDataTablesMetaData
        '
        Me.txtDataTablesMetaData.Location = New System.Drawing.Point(159, 116)
        Me.txtDataTablesMetaData.Name = "txtDataTablesMetaData"
        Me.txtDataTablesMetaData.Size = New System.Drawing.Size(100, 20)
        Me.txtDataTablesMetaData.TabIndex = 11
        Me.txtDataTablesMetaData.Tag = "Data_Tables_Meta_Data"
        '
        'txtDataTablesVariables
        '
        Me.txtDataTablesVariables.Location = New System.Drawing.Point(159, 90)
        Me.txtDataTablesVariables.Name = "txtDataTablesVariables"
        Me.txtDataTablesVariables.Size = New System.Drawing.Size(100, 20)
        Me.txtDataTablesVariables.TabIndex = 12
        Me.txtDataTablesVariables.Tag = "Data_Tables_Variables"
        '
        'lblDataTablesVariables
        '
        Me.lblDataTablesVariables.AutoSize = True
        Me.lblDataTablesVariables.Location = New System.Drawing.Point(39, 93)
        Me.lblDataTablesVariables.Name = "lblDataTablesVariables"
        Me.lblDataTablesVariables.Size = New System.Drawing.Size(39, 13)
        Me.lblDataTablesVariables.TabIndex = 13
        Me.lblDataTablesVariables.Tag = "Data_Tables_Variables"
        Me.lblDataTablesVariables.Text = "Label1"
        '
        'lblDataTablesMetaData
        '
        Me.lblDataTablesMetaData.AutoSize = True
        Me.lblDataTablesMetaData.Location = New System.Drawing.Point(39, 122)
        Me.lblDataTablesMetaData.Name = "lblDataTablesMetaData"
        Me.lblDataTablesMetaData.Size = New System.Drawing.Size(39, 13)
        Me.lblDataTablesMetaData.TabIndex = 14
        Me.lblDataTablesMetaData.Tag = "Data_Tables_Meta_Data"
        Me.lblDataTablesMetaData.Text = "Label2"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 211)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 15
        '
        'dlgAdvanceOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 262)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblDataTablesMetaData)
        Me.Controls.Add(Me.lblDataTablesVariables)
        Me.Controls.Add(Me.txtDataTablesVariables)
        Me.Controls.Add(Me.txtDataTablesMetaData)
        Me.Controls.Add(Me.lblImportedFrom)
        Me.Controls.Add(Me.lblDataTimePeriods)
        Me.Controls.Add(Me.lblClimateObjectMetaData)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.txtImportedFrom)
        Me.Controls.Add(Me.txtDataTimePeriods)
        Me.Controls.Add(Me.chkCreate)
        Me.Controls.Add(Me.chkConvert)
        Me.Controls.Add(Me.chkMessages)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAdvanceOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advance Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkMessages As CheckBox
    Friend WithEvents chkConvert As CheckBox
    Friend WithEvents chkCreate As CheckBox
    Friend WithEvents txtDataTimePeriods As TextBox
    Friend WithEvents txtImportedFrom As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents lblClimateObjectMetaData As Label
    Friend WithEvents lblDataTimePeriods As Label
    Friend WithEvents lblImportedFrom As Label
    Friend WithEvents txtDataTablesMetaData As TextBox
    Friend WithEvents txtDataTablesVariables As TextBox
    Friend WithEvents lblDataTablesVariables As Label
    Friend WithEvents lblDataTablesMetaData As Label
    Friend WithEvents ucrBase As ucrButtons
End Class
