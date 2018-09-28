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
Partial Class dlgOpenSST
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgOpenSST))
        Me.cmdOpenDataSet = New System.Windows.Forms.Button()
        Me.lblFileOpenPath = New System.Windows.Forms.Label()
        Me.lblSSTName = New System.Windows.Forms.Label()
        Me.grpCSV = New System.Windows.Forms.GroupBox()
        Me.ucrInputNAStrings = New instat.ucrInputTextBox()
        Me.ucrInputDecimal = New instat.ucrInputComboBox()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.ucrInputEncoding = New instat.ucrInputComboBox()
        Me.lblEncoding = New System.Windows.Forms.Label()
        Me.nudSkip = New System.Windows.Forms.NumericUpDown()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblLinesToSkip = New System.Windows.Forms.Label()
        Me.lblDecimal = New System.Windows.Forms.Label()
        Me.lblNAStrings = New System.Windows.Forms.Label()
        Me.chkStringsAsFactors = New System.Windows.Forms.CheckBox()
        Me.nudDataFrom = New System.Windows.Forms.NumericUpDown()
        Me.lblDataFromRow = New System.Windows.Forms.Label()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrInputName = New instat.ucrInputTextBox()
        Me.ucrBaseOpenSST = New instat.ucrButtons()
        Me.lblLocationName = New System.Windows.Forms.Label()
        Me.ucrInputNameLocation = New instat.ucrInputTextBox()
        Me.grpCSV.SuspendLayout()
        CType(Me.nudSkip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDataFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOpenDataSet
        '
        resources.ApplyResources(Me.cmdOpenDataSet, "cmdOpenDataSet")
        Me.cmdOpenDataSet.Name = "cmdOpenDataSet"
        Me.cmdOpenDataSet.Tag = "Browse"
        Me.cmdOpenDataSet.UseVisualStyleBackColor = True
        '
        'lblFileOpenPath
        '
        resources.ApplyResources(Me.lblFileOpenPath, "lblFileOpenPath")
        Me.lblFileOpenPath.Name = "lblFileOpenPath"
        '
        'lblSSTName
        '
        resources.ApplyResources(Me.lblSSTName, "lblSSTName")
        Me.lblSSTName.Name = "lblSSTName"
        Me.lblSSTName.Tag = "SST_Data_Frame_Name:"
        '
        'grpCSV
        '
        resources.ApplyResources(Me.grpCSV, "grpCSV")
        Me.grpCSV.Controls.Add(Me.ucrInputNAStrings)
        Me.grpCSV.Controls.Add(Me.ucrInputDecimal)
        Me.grpCSV.Controls.Add(Me.ucrInputSeparator)
        Me.grpCSV.Controls.Add(Me.ucrInputEncoding)
        Me.grpCSV.Controls.Add(Me.lblEncoding)
        Me.grpCSV.Controls.Add(Me.nudSkip)
        Me.grpCSV.Controls.Add(Me.lblSeparator)
        Me.grpCSV.Controls.Add(Me.lblLinesToSkip)
        Me.grpCSV.Controls.Add(Me.lblDecimal)
        Me.grpCSV.Controls.Add(Me.lblNAStrings)
        Me.grpCSV.Controls.Add(Me.chkStringsAsFactors)
        Me.grpCSV.Name = "grpCSV"
        Me.grpCSV.TabStop = False
        '
        'ucrInputNAStrings
        '
        Me.ucrInputNAStrings.AddQuotesIfUnrecognised = True
        Me.ucrInputNAStrings.IsMultiline = False
        Me.ucrInputNAStrings.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNAStrings, "ucrInputNAStrings")
        Me.ucrInputNAStrings.Name = "ucrInputNAStrings"
        '
        'ucrInputDecimal
        '
        Me.ucrInputDecimal.AddQuotesIfUnrecognised = True
        Me.ucrInputDecimal.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDecimal, "ucrInputDecimal")
        Me.ucrInputDecimal.Name = "ucrInputDecimal"
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.AddQuotesIfUnrecognised = True
        Me.ucrInputSeparator.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSeparator, "ucrInputSeparator")
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        '
        'ucrInputEncoding
        '
        Me.ucrInputEncoding.AddQuotesIfUnrecognised = True
        Me.ucrInputEncoding.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputEncoding, "ucrInputEncoding")
        Me.ucrInputEncoding.Name = "ucrInputEncoding"
        '
        'lblEncoding
        '
        resources.ApplyResources(Me.lblEncoding, "lblEncoding")
        Me.lblEncoding.Name = "lblEncoding"
        Me.lblEncoding.Tag = "Encoding:"
        '
        'nudSkip
        '
        resources.ApplyResources(Me.nudSkip, "nudSkip")
        Me.nudSkip.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudSkip.Name = "nudSkip"
        '
        'lblSeparator
        '
        resources.ApplyResources(Me.lblSeparator, "lblSeparator")
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Tag = "Separator:"
        '
        'lblLinesToSkip
        '
        resources.ApplyResources(Me.lblLinesToSkip, "lblLinesToSkip")
        Me.lblLinesToSkip.Name = "lblLinesToSkip"
        '
        'lblDecimal
        '
        resources.ApplyResources(Me.lblDecimal, "lblDecimal")
        Me.lblDecimal.Name = "lblDecimal"
        Me.lblDecimal.Tag = "Decimal:"
        '
        'lblNAStrings
        '
        resources.ApplyResources(Me.lblNAStrings, "lblNAStrings")
        Me.lblNAStrings.Name = "lblNAStrings"
        '
        'chkStringsAsFactors
        '
        resources.ApplyResources(Me.chkStringsAsFactors, "chkStringsAsFactors")
        Me.chkStringsAsFactors.Name = "chkStringsAsFactors"
        Me.chkStringsAsFactors.Tag = "Strings_as_factors"
        Me.chkStringsAsFactors.UseVisualStyleBackColor = True
        '
        'nudDataFrom
        '
        resources.ApplyResources(Me.nudDataFrom, "nudDataFrom")
        Me.nudDataFrom.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudDataFrom.Name = "nudDataFrom"
        Me.nudDataFrom.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lblDataFromRow
        '
        resources.ApplyResources(Me.lblDataFromRow, "lblDataFromRow")
        Me.lblDataFromRow.Name = "lblDataFromRow"
        Me.lblDataFromRow.Tag = "Data_From_Row:"
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFilePath, "ucrInputFilePath")
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        '
        'ucrInputName
        '
        Me.ucrInputName.AddQuotesIfUnrecognised = True
        Me.ucrInputName.IsMultiline = False
        Me.ucrInputName.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputName, "ucrInputName")
        Me.ucrInputName.Name = "ucrInputName"
        '
        'ucrBaseOpenSST
        '
        resources.ApplyResources(Me.ucrBaseOpenSST, "ucrBaseOpenSST")
        Me.ucrBaseOpenSST.Name = "ucrBaseOpenSST"
        '
        'lblLocationName
        '
        resources.ApplyResources(Me.lblLocationName, "lblLocationName")
        Me.lblLocationName.Name = "lblLocationName"
        Me.lblLocationName.Tag = "Location_Data_Frame_Name:"
        '
        'ucrInputNameLocation
        '
        Me.ucrInputNameLocation.AddQuotesIfUnrecognised = True
        Me.ucrInputNameLocation.IsMultiline = False
        Me.ucrInputNameLocation.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNameLocation, "ucrInputNameLocation")
        Me.ucrInputNameLocation.Name = "ucrInputNameLocation"
        '
        'dlgOpenSST
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputNameLocation)
        Me.Controls.Add(Me.lblLocationName)
        Me.Controls.Add(Me.nudDataFrom)
        Me.Controls.Add(Me.lblDataFromRow)
        Me.Controls.Add(Me.grpCSV)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.ucrInputName)
        Me.Controls.Add(Me.cmdOpenDataSet)
        Me.Controls.Add(Me.lblFileOpenPath)
        Me.Controls.Add(Me.lblSSTName)
        Me.Controls.Add(Me.ucrBaseOpenSST)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOpenSST"
        Me.Tag = "Open_SST"
        Me.grpCSV.ResumeLayout(False)
        Me.grpCSV.PerformLayout()
        CType(Me.nudSkip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDataFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseOpenSST As ucrButtons
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents ucrInputName As ucrInputTextBox
    Friend WithEvents cmdOpenDataSet As Button
    Friend WithEvents lblFileOpenPath As Label
    Friend WithEvents lblSSTName As Label
    Friend WithEvents grpCSV As GroupBox
    Friend WithEvents ucrInputNAStrings As ucrInputTextBox
    Friend WithEvents ucrInputDecimal As ucrInputComboBox
    Friend WithEvents ucrInputSeparator As ucrInputComboBox
    Friend WithEvents ucrInputEncoding As ucrInputComboBox
    Friend WithEvents lblEncoding As Label
    Friend WithEvents nudSkip As NumericUpDown
    Friend WithEvents lblSeparator As Label
    Friend WithEvents lblLinesToSkip As Label
    Friend WithEvents lblDecimal As Label
    Friend WithEvents lblNAStrings As Label
    Friend WithEvents chkStringsAsFactors As CheckBox
    Friend WithEvents nudDataFrom As NumericUpDown
    Friend WithEvents lblDataFromRow As Label
    Friend WithEvents lblLocationName As Label
    Friend WithEvents ucrInputNameLocation As ucrInputTextBox
End Class
