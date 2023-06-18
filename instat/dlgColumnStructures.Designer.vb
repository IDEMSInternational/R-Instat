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
Partial Class dlgColumnStructure
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
        Me.lblMeasurement = New System.Windows.Forms.Label()
        Me.lblTreatment = New System.Windows.Forms.Label()
        Me.lblLayout = New System.Windows.Forms.Label()
        Me.ucrChkColourColumnsByStructure = New instat.ucrCheck()
        Me.ucrReceiverMeasurement = New instat.ucrReceiverMultiple()
        Me.ucrReceiverTreatment = New instat.ucrReceiverMultiple()
        Me.ucrReceiverLayout = New instat.ucrReceiverMultiple()
        Me.ucrSelectorColumnStructure = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblMeasurement
        '
        Me.lblMeasurement.AutoSize = True
        Me.lblMeasurement.Location = New System.Drawing.Point(261, 231)
        Me.lblMeasurement.Name = "lblMeasurement"
        Me.lblMeasurement.Size = New System.Drawing.Size(74, 13)
        Me.lblMeasurement.TabIndex = 5
        Me.lblMeasurement.Text = "Measurement:"
        '
        'lblTreatment
        '
        Me.lblTreatment.AutoSize = True
        Me.lblTreatment.Location = New System.Drawing.Point(261, 138)
        Me.lblTreatment.Name = "lblTreatment"
        Me.lblTreatment.Size = New System.Drawing.Size(58, 13)
        Me.lblTreatment.TabIndex = 3
        Me.lblTreatment.Text = "Treatment:"
        '
        'lblLayout
        '
        Me.lblLayout.AutoSize = True
        Me.lblLayout.Location = New System.Drawing.Point(261, 45)
        Me.lblLayout.Name = "lblLayout"
        Me.lblLayout.Size = New System.Drawing.Size(42, 13)
        Me.lblLayout.TabIndex = 1
        Me.lblLayout.Text = "Layout:"
        '
        'ucrChkColourColumnsByStructure
        '
        Me.ucrChkColourColumnsByStructure.AutoSize = True
        Me.ucrChkColourColumnsByStructure.Checked = False
        Me.ucrChkColourColumnsByStructure.Location = New System.Drawing.Point(10, 206)
        Me.ucrChkColourColumnsByStructure.Name = "ucrChkColourColumnsByStructure"
        Me.ucrChkColourColumnsByStructure.Size = New System.Drawing.Size(210, 23)
        Me.ucrChkColourColumnsByStructure.TabIndex = 7
        '
        'ucrReceiverMeasurement
        '
        Me.ucrReceiverMeasurement.AutoSize = True
        Me.ucrReceiverMeasurement.frmParent = Me
        Me.ucrReceiverMeasurement.Location = New System.Drawing.Point(261, 246)
        Me.ucrReceiverMeasurement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeasurement.Name = "ucrReceiverMeasurement"
        Me.ucrReceiverMeasurement.Selector = Nothing
        Me.ucrReceiverMeasurement.Size = New System.Drawing.Size(120, 76)
        Me.ucrReceiverMeasurement.strNcFilePath = ""
        Me.ucrReceiverMeasurement.TabIndex = 6
        Me.ucrReceiverMeasurement.ucrSelector = Nothing
        '
        'ucrReceiverTreatment
        '
        Me.ucrReceiverTreatment.AutoSize = True
        Me.ucrReceiverTreatment.frmParent = Me
        Me.ucrReceiverTreatment.Location = New System.Drawing.Point(261, 153)
        Me.ucrReceiverTreatment.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTreatment.Name = "ucrReceiverTreatment"
        Me.ucrReceiverTreatment.Selector = Nothing
        Me.ucrReceiverTreatment.Size = New System.Drawing.Size(120, 73)
        Me.ucrReceiverTreatment.strNcFilePath = ""
        Me.ucrReceiverTreatment.TabIndex = 4
        Me.ucrReceiverTreatment.ucrSelector = Nothing
        '
        'ucrReceiverLayout
        '
        Me.ucrReceiverLayout.AutoSize = True
        Me.ucrReceiverLayout.frmParent = Me
        Me.ucrReceiverLayout.Location = New System.Drawing.Point(261, 60)
        Me.ucrReceiverLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLayout.Name = "ucrReceiverLayout"
        Me.ucrReceiverLayout.Selector = Nothing
        Me.ucrReceiverLayout.Size = New System.Drawing.Size(120, 74)
        Me.ucrReceiverLayout.strNcFilePath = ""
        Me.ucrReceiverLayout.TabIndex = 2
        Me.ucrReceiverLayout.ucrSelector = Nothing
        '
        'ucrSelectorColumnStructure
        '
        Me.ucrSelectorColumnStructure.AutoSize = True
        Me.ucrSelectorColumnStructure.bDropUnusedFilterLevels = False
        Me.ucrSelectorColumnStructure.bShowHiddenColumns = False
        Me.ucrSelectorColumnStructure.bUseCurrentFilter = True
        Me.ucrSelectorColumnStructure.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorColumnStructure.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorColumnStructure.Name = "ucrSelectorColumnStructure"
        Me.ucrSelectorColumnStructure.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorColumnStructure.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 334)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 8
        '
        'dlgColumnStructure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(415, 391)
        Me.Controls.Add(Me.ucrChkColourColumnsByStructure)
        Me.Controls.Add(Me.lblMeasurement)
        Me.Controls.Add(Me.lblTreatment)
        Me.Controls.Add(Me.lblLayout)
        Me.Controls.Add(Me.ucrReceiverMeasurement)
        Me.Controls.Add(Me.ucrReceiverTreatment)
        Me.Controls.Add(Me.ucrReceiverLayout)
        Me.Controls.Add(Me.ucrSelectorColumnStructure)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgColumnStructure"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Column_Structure"
        Me.Text = "Column Structure"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMeasurement As Label
    Friend WithEvents lblTreatment As Label
    Friend WithEvents lblLayout As Label
    Friend WithEvents ucrReceiverMeasurement As ucrReceiverMultiple
    Friend WithEvents ucrReceiverTreatment As ucrReceiverMultiple
    Friend WithEvents ucrReceiverLayout As ucrReceiverMultiple
    Friend WithEvents ucrSelectorColumnStructure As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkColourColumnsByStructure As ucrCheck
End Class
