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
        Me.ucrChkUnstackData = New instat.ucrCheck()
        Me.ucrChkFlagsData = New instat.ucrCheck()
        Me.ucrChkElements = New instat.ucrCheck()
        Me.ucrChkDateRange = New instat.ucrCheck()
        Me.ucrDtpEndDate = New instat.ucrDateTimePicker()
        Me.ucrDtpStartdate = New instat.ucrDateTimePicker()
        Me.ucrChkObservationData = New instat.ucrCheck()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.ucrComboBoxElements = New instat.ucrInputComboBox()
        Me.ucrComboBoxStations = New instat.ucrInputComboBox()
        Me.ucrSelectorForClimSoft = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverMultipleElements = New instat.ucrReceiverMultiple()
        Me.ucrReceiverMultipleStations = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
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
        'ucrChkUnstackData
        '
        Me.ucrChkUnstackData.Checked = True
        resources.ApplyResources(Me.ucrChkUnstackData, "ucrChkUnstackData")
        Me.ucrChkUnstackData.Name = "ucrChkUnstackData"
        Me.ttClimsoft.SetToolTip(Me.ucrChkUnstackData, resources.GetString("ucrChkUnstackData.ToolTip"))
        '
        'ucrChkFlagsData
        '
        Me.ucrChkFlagsData.Checked = False
        resources.ApplyResources(Me.ucrChkFlagsData, "ucrChkFlagsData")
        Me.ucrChkFlagsData.Name = "ucrChkFlagsData"
        Me.ttClimsoft.SetToolTip(Me.ucrChkFlagsData, resources.GetString("ucrChkFlagsData.ToolTip"))
        '
        'ucrChkElements
        '
        Me.ucrChkElements.Checked = False
        resources.ApplyResources(Me.ucrChkElements, "ucrChkElements")
        Me.ucrChkElements.Name = "ucrChkElements"
        Me.ttClimsoft.SetToolTip(Me.ucrChkElements, resources.GetString("ucrChkElements.ToolTip"))
        '
        'ucrChkDateRange
        '
        Me.ucrChkDateRange.Checked = False
        resources.ApplyResources(Me.ucrChkDateRange, "ucrChkDateRange")
        Me.ucrChkDateRange.Name = "ucrChkDateRange"
        Me.ttClimsoft.SetToolTip(Me.ucrChkDateRange, resources.GetString("ucrChkDateRange.ToolTip"))
        '
        'ucrDtpEndDate
        '
        Me.ucrDtpEndDate.DateValue = New Date(2021, 5, 18, 16, 45, 8, 379)
        Me.ucrDtpEndDate.Format = "dd MMM yyyy"
        resources.ApplyResources(Me.ucrDtpEndDate, "ucrDtpEndDate")
        Me.ucrDtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpEndDate.Name = "ucrDtpEndDate"
        Me.ttClimsoft.SetToolTip(Me.ucrDtpEndDate, resources.GetString("ucrDtpEndDate.ToolTip"))
        '
        'ucrDtpStartdate
        '
        Me.ucrDtpStartdate.DateValue = New Date(2021, 5, 18, 16, 45, 8, 408)
        Me.ucrDtpStartdate.Format = "dd MMM yyyy"
        resources.ApplyResources(Me.ucrDtpStartdate, "ucrDtpStartdate")
        Me.ucrDtpStartdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpStartdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpStartdate.Name = "ucrDtpStartdate"
        Me.ttClimsoft.SetToolTip(Me.ucrDtpStartdate, resources.GetString("ucrDtpStartdate.ToolTip"))
        '
        'ucrChkObservationData
        '
        Me.ucrChkObservationData.Checked = False
        resources.ApplyResources(Me.ucrChkObservationData, "ucrChkObservationData")
        Me.ucrChkObservationData.Name = "ucrChkObservationData"
        Me.ttClimsoft.SetToolTip(Me.ucrChkObservationData, resources.GetString("ucrChkObservationData.ToolTip"))
        '
        'lblConnection
        '
        resources.ApplyResources(Me.lblConnection, "lblConnection")
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.Name = "lblConnection"
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
        'dlgClimSoft
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkUnstackData)
        Me.Controls.Add(Me.ucrChkFlagsData)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.ucrChkElements)
        Me.Controls.Add(Me.ucrComboBoxElements)
        Me.Controls.Add(Me.ucrComboBoxStations)
        Me.Controls.Add(Me.ucrChkDateRange)
        Me.Controls.Add(Me.ucrDtpEndDate)
        Me.Controls.Add(Me.ucrDtpStartdate)
        Me.Controls.Add(Me.ucrChkObservationData)
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
    Friend WithEvents ucrDtpEndDate As ucrDateTimePicker
    Friend WithEvents ucrDtpStartdate As ucrDateTimePicker
    Friend WithEvents ucrChkObservationData As ucrCheck
    Friend WithEvents ucrChkDateRange As ucrCheck
    Friend WithEvents ucrComboBoxStations As ucrInputComboBox
    Friend WithEvents ucrComboBoxElements As ucrInputComboBox
    Friend WithEvents ucrChkElements As ucrCheck
    Friend WithEvents lblConnection As Label
    Friend WithEvents ucrChkFlagsData As ucrCheck
    Friend WithEvents ucrChkUnstackData As ucrCheck
End Class
