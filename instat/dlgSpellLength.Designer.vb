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
Partial Class dlgSpellLengths
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
        Me.chkPrintTable = New System.Windows.Forms.CheckBox()
        Me.chkMonthAbbreviations = New System.Windows.Forms.CheckBox()
        Me.chkRemoveNA = New System.Windows.Forms.CheckBox()
        Me.chkSeparate = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Threshold = New System.Windows.Forms.Label()
        Me.lblYearList = New System.Windows.Forms.Label()
        Me.lblDOYearList = New System.Windows.Forms.Label()
        Me.nudThreshold = New System.Windows.Forms.NumericUpDown()
        Me.txtListYears = New System.Windows.Forms.TextBox()
        Me.txtDOYearList = New System.Windows.Forms.TextBox()
        Me.txtDataframeNames = New System.Windows.Forms.TextBox()
        Me.lblDataframeNames = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkPrintTable
        '
        Me.chkPrintTable.AutoSize = True
        Me.chkPrintTable.Location = New System.Drawing.Point(133, 184)
        Me.chkPrintTable.Name = "chkPrintTable"
        Me.chkPrintTable.Size = New System.Drawing.Size(81, 17)
        Me.chkPrintTable.TabIndex = 1
        Me.chkPrintTable.Tag = "Print_Table"
        Me.chkPrintTable.Text = "CheckBox1"
        Me.chkPrintTable.UseVisualStyleBackColor = True
        '
        'chkMonthAbbreviations
        '
        Me.chkMonthAbbreviations.AutoSize = True
        Me.chkMonthAbbreviations.Location = New System.Drawing.Point(334, 184)
        Me.chkMonthAbbreviations.Name = "chkMonthAbbreviations"
        Me.chkMonthAbbreviations.Size = New System.Drawing.Size(81, 17)
        Me.chkMonthAbbreviations.TabIndex = 2
        Me.chkMonthAbbreviations.Tag = "Month_Abbreviations"
        Me.chkMonthAbbreviations.Text = "CheckBox2"
        Me.chkMonthAbbreviations.UseVisualStyleBackColor = True
        '
        'chkRemoveNA
        '
        Me.chkRemoveNA.AutoSize = True
        Me.chkRemoveNA.Location = New System.Drawing.Point(133, 234)
        Me.chkRemoveNA.Name = "chkRemoveNA"
        Me.chkRemoveNA.Size = New System.Drawing.Size(81, 17)
        Me.chkRemoveNA.TabIndex = 3
        Me.chkRemoveNA.Tag = "Remove_NA"
        Me.chkRemoveNA.Text = "CheckBox3"
        Me.chkRemoveNA.UseVisualStyleBackColor = True
        '
        'chkSeparate
        '
        Me.chkSeparate.AutoSize = True
        Me.chkSeparate.Location = New System.Drawing.Point(334, 234)
        Me.chkSeparate.Name = "chkSeparate"
        Me.chkSeparate.Size = New System.Drawing.Size(81, 17)
        Me.chkSeparate.TabIndex = 4
        Me.chkSeparate.Tag = "Separate"
        Me.chkSeparate.Text = "CheckBox4"
        Me.chkSeparate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Data list not implemented"
        '
        'Threshold
        '
        Me.Threshold.AutoSize = True
        Me.Threshold.Location = New System.Drawing.Point(29, 45)
        Me.Threshold.Name = "Threshold"
        Me.Threshold.Size = New System.Drawing.Size(39, 13)
        Me.Threshold.TabIndex = 6
        Me.Threshold.Tag = "Threshold"
        Me.Threshold.Text = "Label2"
        '
        'lblYearList
        '
        Me.lblYearList.AutoSize = True
        Me.lblYearList.Location = New System.Drawing.Point(29, 107)
        Me.lblYearList.Name = "lblYearList"
        Me.lblYearList.Size = New System.Drawing.Size(39, 13)
        Me.lblYearList.TabIndex = 7
        Me.lblYearList.Tag = "Year_List"
        Me.lblYearList.Text = "Label3"
        '
        'lblDOYearList
        '
        Me.lblDOYearList.AutoSize = True
        Me.lblDOYearList.Location = New System.Drawing.Point(29, 78)
        Me.lblDOYearList.Name = "lblDOYearList"
        Me.lblDOYearList.Size = New System.Drawing.Size(39, 13)
        Me.lblDOYearList.TabIndex = 9
        Me.lblDOYearList.Tag = "DOY_List"
        Me.lblDOYearList.Text = "Label5"
        '
        'nudThreshold
        '
        Me.nudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudThreshold.Location = New System.Drawing.Point(133, 45)
        Me.nudThreshold.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(58, 20)
        Me.nudThreshold.TabIndex = 11
        '
        'txtListYears
        '
        Me.txtListYears.Location = New System.Drawing.Point(133, 104)
        Me.txtListYears.Name = "txtListYears"
        Me.txtListYears.Size = New System.Drawing.Size(100, 20)
        Me.txtListYears.TabIndex = 12
        '
        'txtDOYearList
        '
        Me.txtDOYearList.Location = New System.Drawing.Point(133, 78)
        Me.txtDOYearList.Name = "txtDOYearList"
        Me.txtDOYearList.Size = New System.Drawing.Size(100, 20)
        Me.txtDOYearList.TabIndex = 13
        '
        'txtDataframeNames
        '
        Me.txtDataframeNames.Location = New System.Drawing.Point(133, 130)
        Me.txtDataframeNames.Name = "txtDataframeNames"
        Me.txtDataframeNames.Size = New System.Drawing.Size(100, 20)
        Me.txtDataframeNames.TabIndex = 14
        '
        'lblDataframeNames
        '
        Me.lblDataframeNames.AutoSize = True
        Me.lblDataframeNames.Location = New System.Drawing.Point(29, 133)
        Me.lblDataframeNames.Name = "lblDataframeNames"
        Me.lblDataframeNames.Size = New System.Drawing.Size(39, 13)
        Me.lblDataframeNames.TabIndex = 15
        Me.lblDataframeNames.Tag = "Dataframe_Names"
        Me.lblDataframeNames.Text = "Label2"
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(53, 304)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgSpellLengths
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(511, 367)
        Me.Controls.Add(Me.lblDataframeNames)
        Me.Controls.Add(Me.txtDataframeNames)
        Me.Controls.Add(Me.txtDOYearList)
        Me.Controls.Add(Me.txtListYears)
        Me.Controls.Add(Me.nudThreshold)
        Me.Controls.Add(Me.lblDOYearList)
        Me.Controls.Add(Me.lblYearList)
        Me.Controls.Add(Me.Threshold)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkSeparate)
        Me.Controls.Add(Me.chkRemoveNA)
        Me.Controls.Add(Me.chkMonthAbbreviations)
        Me.Controls.Add(Me.chkPrintTable)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSpellLengths"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spell Length"
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkPrintTable As CheckBox
    Friend WithEvents chkMonthAbbreviations As CheckBox
    Friend WithEvents chkRemoveNA As CheckBox
    Friend WithEvents chkSeparate As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Threshold As Label
    Friend WithEvents lblYearList As Label
    Friend WithEvents lblDOYearList As Label
    Friend WithEvents nudThreshold As NumericUpDown
    Friend WithEvents txtListYears As TextBox
    Friend WithEvents txtDOYearList As TextBox
    Friend WithEvents txtDataframeNames As TextBox
    Friend WithEvents lblDataframeNames As Label
End Class
