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
        Me.cmdEstablishConnection = New System.Windows.Forms.Button()
        Me.lblElements = New System.Windows.Forms.Label()
        Me.lblStations = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.ttClimsoft = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrInputEndDate = New instat.ucrInputTextBox()
        Me.ucrInputStartDate = New instat.ucrInputTextBox()
        Me.ucrChkObservationData = New instat.ucrCheck()
        Me.ucrSelectorForClimSoft = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverMultipleElements = New instat.ucrReceiverMultiple()
        Me.ucrReceiverMultipleStations = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'cmdEstablishConnection
        '
        Me.cmdEstablishConnection.Location = New System.Drawing.Point(10, 14)
        Me.cmdEstablishConnection.Name = "cmdEstablishConnection"
        Me.cmdEstablishConnection.Size = New System.Drawing.Size(121, 23)
        Me.cmdEstablishConnection.TabIndex = 0
        Me.cmdEstablishConnection.Text = "Establish Connection.."
        Me.cmdEstablishConnection.UseVisualStyleBackColor = True
        '
        'lblElements
        '
        Me.lblElements.AutoSize = True
        Me.lblElements.Location = New System.Drawing.Point(260, 178)
        Me.lblElements.Name = "lblElements"
        Me.lblElements.Size = New System.Drawing.Size(53, 13)
        Me.lblElements.TabIndex = 4
        Me.lblElements.Text = "Elements:"
        '
        'lblStations
        '
        Me.lblStations.AutoSize = True
        Me.lblStations.Location = New System.Drawing.Point(260, 42)
        Me.lblStations.Name = "lblStations"
        Me.lblStations.Size = New System.Drawing.Size(48, 13)
        Me.lblStations.TabIndex = 2
        Me.lblStations.Text = "Stations:"
        Me.lblStations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(10, 232)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(58, 13)
        Me.lblStartDate.TabIndex = 7
        Me.lblStartDate.Text = "Start Date:"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(10, 281)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(55, 13)
        Me.lblEndDate.TabIndex = 9
        Me.lblEndDate.Text = "End Date:"
        '
        'ucrInputEndDate
        '
        Me.ucrInputEndDate.AddQuotesIfUnrecognised = True
        Me.ucrInputEndDate.IsMultiline = False
        Me.ucrInputEndDate.IsReadOnly = False
        Me.ucrInputEndDate.Location = New System.Drawing.Point(10, 296)
        Me.ucrInputEndDate.Name = "ucrInputEndDate"
        Me.ucrInputEndDate.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputEndDate.TabIndex = 10
        '
        'ucrInputStartDate
        '
        Me.ucrInputStartDate.AddQuotesIfUnrecognised = True
        Me.ucrInputStartDate.IsMultiline = False
        Me.ucrInputStartDate.IsReadOnly = False
        Me.ucrInputStartDate.Location = New System.Drawing.Point(10, 247)
        Me.ucrInputStartDate.Name = "ucrInputStartDate"
        Me.ucrInputStartDate.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputStartDate.TabIndex = 8
        '
        'ucrChkObservationData
        '
        Me.ucrChkObservationData.Checked = False
        Me.ucrChkObservationData.Location = New System.Drawing.Point(10, 203)
        Me.ucrChkObservationData.Name = "ucrChkObservationData"
        Me.ucrChkObservationData.Size = New System.Drawing.Size(178, 20)
        Me.ucrChkObservationData.TabIndex = 6
        '
        'ucrSelectorForClimSoft
        '
        Me.ucrSelectorForClimSoft.bShowHiddenColumns = False
        Me.ucrSelectorForClimSoft.Location = New System.Drawing.Point(10, 57)
        Me.ucrSelectorForClimSoft.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForClimSoft.Name = "ucrSelectorForClimSoft"
        Me.ucrSelectorForClimSoft.Size = New System.Drawing.Size(201, 147)
        Me.ucrSelectorForClimSoft.TabIndex = 1
        '
        'ucrReceiverMultipleElements
        '
        Me.ucrReceiverMultipleElements.frmParent = Me
        Me.ucrReceiverMultipleElements.Location = New System.Drawing.Point(260, 193)
        Me.ucrReceiverMultipleElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleElements.Name = "ucrReceiverMultipleElements"
        Me.ucrReceiverMultipleElements.Selector = Nothing
        Me.ucrReceiverMultipleElements.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleElements.strNcFilePath = ""
        Me.ucrReceiverMultipleElements.TabIndex = 5
        Me.ucrReceiverMultipleElements.ucrSelector = Nothing
        '
        'ucrReceiverMultipleStations
        '
        Me.ucrReceiverMultipleStations.frmParent = Me
        Me.ucrReceiverMultipleStations.Location = New System.Drawing.Point(260, 57)
        Me.ucrReceiverMultipleStations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleStations.Name = "ucrReceiverMultipleStations"
        Me.ucrReceiverMultipleStations.Selector = Nothing
        Me.ucrReceiverMultipleStations.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleStations.strNcFilePath = ""
        Me.ucrReceiverMultipleStations.TabIndex = 3
        Me.ucrReceiverMultipleStations.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 325)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 11
        '
        'dlgClimSoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 382)
        Me.Controls.Add(Me.ucrInputEndDate)
        Me.Controls.Add(Me.ucrInputStartDate)
        Me.Controls.Add(Me.ucrChkObservationData)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.ucrSelectorForClimSoft)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.ucrReceiverMultipleElements)
        Me.Controls.Add(Me.lblStations)
        Me.Controls.Add(Me.lblElements)
        Me.Controls.Add(Me.ucrReceiverMultipleStations)
        Me.Controls.Add(Me.cmdEstablishConnection)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimSoft"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import From ClimSoft"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdEstablishConnection As Button
    Friend WithEvents ucrReceiverMultipleStations As ucrReceiverMultiple
    Friend WithEvents ucrReceiverMultipleElements As ucrReceiverMultiple
    Friend WithEvents lblStations As Label
    Friend WithEvents lblElements As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents ucrSelectorForClimSoft As ucrSelectorAddRemove
    Friend WithEvents ucrChkObservationData As ucrCheck
    Friend WithEvents ucrInputEndDate As ucrInputTextBox
    Friend WithEvents ucrInputStartDate As ucrInputTextBox
    Friend WithEvents lblEndDate As Label
    Friend WithEvents ttClimsoft As ToolTip
End Class
