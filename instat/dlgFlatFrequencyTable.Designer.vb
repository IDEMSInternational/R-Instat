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
Partial Class dlgFlatFrequencyTable
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
        Me.lblRowVariable = New System.Windows.Forms.Label()
        Me.lblColumnVariable = New System.Windows.Forms.Label()
        Me.ucrChkAddMargins = New instat.ucrCheck()
        Me.ucrColumnVariable = New instat.ucrReceiverMultiple()
        Me.ucrRowVariable = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblRowVariable
        '
        Me.lblRowVariable.AutoSize = True
        Me.lblRowVariable.Location = New System.Drawing.Point(264, 150)
        Me.lblRowVariable.Name = "lblRowVariable"
        Me.lblRowVariable.Size = New System.Drawing.Size(84, 13)
        Me.lblRowVariable.TabIndex = 1
        Me.lblRowVariable.Text = "Row Variable(s):"
        '
        'lblColumnVariable
        '
        Me.lblColumnVariable.AutoSize = True
        Me.lblColumnVariable.Location = New System.Drawing.Point(264, 43)
        Me.lblColumnVariable.Name = "lblColumnVariable"
        Me.lblColumnVariable.Size = New System.Drawing.Size(136, 13)
        Me.lblColumnVariable.TabIndex = 3
        Me.lblColumnVariable.Text = "Column Variable(s) (Factor):"
        '
        'ucrChkAddMargins
        '
        Me.ucrChkAddMargins.AutoSize = True
        Me.ucrChkAddMargins.Checked = False
        Me.ucrChkAddMargins.Location = New System.Drawing.Point(10, 239)
        Me.ucrChkAddMargins.Name = "ucrChkAddMargins"
        Me.ucrChkAddMargins.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkAddMargins.TabIndex = 5
        '
        'ucrColumnVariable
        '
        Me.ucrColumnVariable.AutoSize = True
        Me.ucrColumnVariable.frmParent = Me
        Me.ucrColumnVariable.Location = New System.Drawing.Point(264, 58)
        Me.ucrColumnVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrColumnVariable.Name = "ucrColumnVariable"
        Me.ucrColumnVariable.Selector = Nothing
        Me.ucrColumnVariable.Size = New System.Drawing.Size(120, 85)
        Me.ucrColumnVariable.strNcFilePath = ""
        Me.ucrColumnVariable.TabIndex = 4
        Me.ucrColumnVariable.ucrSelector = Nothing
        '
        'ucrRowVariable
        '
        Me.ucrRowVariable.AutoSize = True
        Me.ucrRowVariable.frmParent = Me
        Me.ucrRowVariable.Location = New System.Drawing.Point(264, 165)
        Me.ucrRowVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrRowVariable.Name = "ucrRowVariable"
        Me.ucrRowVariable.Selector = Nothing
        Me.ucrRowVariable.Size = New System.Drawing.Size(120, 85)
        Me.ucrRowVariable.strNcFilePath = ""
        Me.ucrRowVariable.TabIndex = 2
        Me.ucrRowVariable.ucrSelector = Nothing
        '
        'ucrSelectorDataFrame
        '
        Me.ucrSelectorDataFrame.AutoSize = True
        Me.ucrSelectorDataFrame.bDropUnusedFilterLevels = False
        Me.ucrSelectorDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorDataFrame.bUseCurrentFilter = True
        Me.ucrSelectorDataFrame.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataFrame.Name = "ucrSelectorDataFrame"
        Me.ucrSelectorDataFrame.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorDataFrame.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 264)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 6
        '
        'dlgFlatFrequencyTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(418, 322)
        Me.Controls.Add(Me.ucrChkAddMargins)
        Me.Controls.Add(Me.lblColumnVariable)
        Me.Controls.Add(Me.lblRowVariable)
        Me.Controls.Add(Me.ucrColumnVariable)
        Me.Controls.Add(Me.ucrRowVariable)
        Me.Controls.Add(Me.ucrSelectorDataFrame)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFlatFrequencyTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flat Frequency Table"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrRowVariable As ucrReceiverMultiple
    Friend WithEvents ucrColumnVariable As ucrReceiverMultiple
    Friend WithEvents lblRowVariable As Label
    Friend WithEvents lblColumnVariable As Label
    Friend WithEvents ucrChkAddMargins As ucrCheck
End Class
