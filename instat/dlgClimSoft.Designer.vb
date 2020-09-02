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
Partial Class dlgClimSoft
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgClimSoft))
        Me.btnEstablishConnection = New System.Windows.Forms.Button()
        Me.lblElements = New System.Windows.Forms.Label()
        Me.lblStations = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.ttClimsoft = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrChkElements = New instat.ucrCheck()
        Me.ucrComboBoxElements = New instat.ucrInputComboBox()
        Me.ucrComboBoxStations = New instat.ucrInputComboBox()
        Me.ucrChkDateRange = New instat.ucrCheck()
        Me.ucrChkUnstackData = New instat.ucrCheck()
        Me.UcrDtpEndDate = New instat.ucrDateTimePicker()
        Me.ucrDtpStartdate = New instat.ucrDateTimePicker()
        Me.ucrChkData = New instat.ucrCheck()
        Me.ucrSelectorForClimSoft = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverMultipleElements = New instat.ucrReceiverMultiple()
        Me.ucrReceiverMultipleStations = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEstablishConnection
        '
        resources.ApplyResources(Me.btnEstablishConnection, "btnEstablishConnection")
        Me.btnEstablishConnection.Name = "btnEstablishConnection"
        Me.btnEstablishConnection.UseVisualStyleBackColor = True
        '
        'lblElements
        '
        resources.ApplyResources(Me.lblElements, "lblElements")
        Me.lblElements.Name = "lblElements"
        '
        'lblStations
        '
        resources.ApplyResources(Me.lblStations, "lblStations")
        Me.lblStations.Name = "lblStations"
        '
        'lblStartDate
        '
        resources.ApplyResources(Me.lblStartDate, "lblStartDate")
        Me.lblStartDate.Name = "lblStartDate"
        '
        'lblEndDate
        '
        resources.ApplyResources(Me.lblEndDate, "lblEndDate")
        Me.lblEndDate.Name = "lblEndDate"
        '
        'ucrChkElements
        '
        Me.ucrChkElements.Checked = False
        resources.ApplyResources(Me.ucrChkElements, "ucrChkElements")
        Me.ucrChkElements.Name = "ucrChkElements"
        Me.ttClimsoft.SetToolTip(Me.ucrChkElements, resources.GetString("ucrChkElements.ToolTip"))
        '
        'ucrComboBoxElements
        '
        Me.ucrComboBoxElements.AddQuotesIfUnrecognised = True
        Me.ucrComboBoxElements.GetSetSelectedIndex = -1
        Me.ucrComboBoxElements.IsReadOnly = False
        resources.ApplyResources(Me.ucrComboBoxElements, "ucrComboBoxElements")
        Me.ucrComboBoxElements.Name = "ucrComboBoxElements"
        '
        'ucrComboBoxStations
        '
        Me.ucrComboBoxStations.AddQuotesIfUnrecognised = True
        Me.ucrComboBoxStations.GetSetSelectedIndex = -1
        Me.ucrComboBoxStations.IsReadOnly = False
        resources.ApplyResources(Me.ucrComboBoxStations, "ucrComboBoxStations")
        Me.ucrComboBoxStations.Name = "ucrComboBoxStations"
        '
        'ucrChkDateRange
        '
        Me.ucrChkDateRange.Checked = True
        resources.ApplyResources(Me.ucrChkDateRange, "ucrChkDateRange")
        Me.ucrChkDateRange.Name = "ucrChkDateRange"
        Me.ttClimsoft.SetToolTip(Me.ucrChkDateRange, resources.GetString("ucrChkDateRange.ToolTip"))
        '
        'ucrChkUnstackData
        '
        Me.ucrChkUnstackData.Checked = False
        resources.ApplyResources(Me.ucrChkUnstackData, "ucrChkUnstackData")
        Me.ucrChkUnstackData.Name = "ucrChkUnstackData"
        '
        'UcrDtpEndDate
        '
        resources.ApplyResources(Me.UcrDtpEndDate, "UcrDtpEndDate")
        Me.UcrDtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.UcrDtpEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.UcrDtpEndDate.Name = "UcrDtpEndDate"
        '
        'ucrDtpStartdate
        '
        resources.ApplyResources(Me.ucrDtpStartdate, "ucrDtpStartdate")
        Me.ucrDtpStartdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpStartdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpStartdate.Name = "ucrDtpStartdate"
        '
        'ucrChkData
        '
        Me.ucrChkData.Checked = False
        resources.ApplyResources(Me.ucrChkData, "ucrChkData")
        Me.ucrChkData.Name = "ucrChkData"
        Me.ttClimsoft.SetToolTip(Me.ucrChkData, resources.GetString("ucrChkData.ToolTip"))
        '
        'ucrSelectorForClimSoft
        '
        Me.ucrSelectorForClimSoft.bShowHiddenColumns = False
        resources.ApplyResources(Me.ucrSelectorForClimSoft, "ucrSelectorForClimSoft")
        Me.ucrSelectorForClimSoft.Name = "ucrSelectorForClimSoft"
        '
        'ucrReceiverMultipleElements
        '
        Me.ucrReceiverMultipleElements.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMultipleElements, "ucrReceiverMultipleElements")
        Me.ucrReceiverMultipleElements.Name = "ucrReceiverMultipleElements"
        Me.ucrReceiverMultipleElements.Selector = Nothing
        Me.ucrReceiverMultipleElements.strNcFilePath = ""
        Me.ucrReceiverMultipleElements.ucrSelector = Nothing
        '
        'ucrReceiverMultipleStations
        '
        Me.ucrReceiverMultipleStations.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMultipleStations, "ucrReceiverMultipleStations")
        Me.ucrReceiverMultipleStations.Name = "ucrReceiverMultipleStations"
        Me.ucrReceiverMultipleStations.Selector = Nothing
        Me.ucrReceiverMultipleStations.strNcFilePath = ""
        Me.ucrReceiverMultipleStations.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'lblConnection
        '
        resources.ApplyResources(Me.lblConnection, "lblConnection")
        Me.lblConnection.Name = "lblConnection"
        '
        'dlgClimSoft
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.ucrChkElements)
        Me.Controls.Add(Me.ucrComboBoxElements)
        Me.Controls.Add(Me.ucrComboBoxStations)
        Me.Controls.Add(Me.ucrChkDateRange)
        Me.Controls.Add(Me.ucrChkUnstackData)
        Me.Controls.Add(Me.UcrDtpEndDate)
        Me.Controls.Add(Me.ucrDtpStartdate)
        Me.Controls.Add(Me.ucrChkData)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.ucrSelectorForClimSoft)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.ucrReceiverMultipleElements)
        Me.Controls.Add(Me.lblStations)
        Me.Controls.Add(Me.lblElements)
        Me.Controls.Add(Me.ucrReceiverMultipleStations)
        Me.Controls.Add(Me.btnEstablishConnection)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimSoft"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents btnEstablishConnection As Button
    Friend WithEvents ucrReceiverMultipleStations As ucrReceiverMultiple
    Friend WithEvents ucrReceiverMultipleElements As ucrReceiverMultiple
    Friend WithEvents lblStations As Label
    Friend WithEvents lblElements As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents ucrSelectorForClimSoft As ucrSelectorAddRemove
    Friend WithEvents lblEndDate As Label
    Friend WithEvents ttClimsoft As ToolTip
    Friend WithEvents ucrChkUnstackData As ucrCheck
    Friend WithEvents UcrDtpEndDate As ucrDateTimePicker
    Friend WithEvents ucrDtpStartdate As ucrDateTimePicker
    Friend WithEvents ucrChkData As ucrCheck
    Friend WithEvents ucrChkDateRange As ucrCheck
    Friend WithEvents ucrComboBoxStations As ucrInputComboBox
    Friend WithEvents ucrComboBoxElements As ucrInputComboBox
    Friend WithEvents ucrChkElements As ucrCheck
    Friend WithEvents lblConnection As Label
End Class
