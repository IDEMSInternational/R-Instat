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
Partial Class sdgCorruptionCountryLevelColumns
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
        Me.ucrReceiverSmallState = New instat.ucrReceiverSingle()
        Me.lblSmallState = New System.Windows.Forms.Label()
        Me.lblCountryISO2 = New System.Windows.Forms.Label()
        Me.ucrReceiverISO2 = New instat.ucrReceiverSingle()
        Me.ucrCountryLevelSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.ucrReceiverCountry = New instat.ucrReceiverSingle()
        Me.ucrReceiverSS2015 = New instat.ucrReceiverSingle()
        Me.lblSS2015 = New System.Windows.Forms.Label()
        Me.ucrReceiverISO3 = New instat.ucrReceiverSingle()
        Me.lblCountryISO3 = New System.Windows.Forms.Label()
        Me.ucrReceiverSS2011 = New instat.ucrReceiverSingle()
        Me.lblSS2013 = New System.Windows.Forms.Label()
        Me.ucrReceiverWBPPP = New instat.ucrReceiverSingle()
        Me.ucrReceiverSS2013 = New instat.ucrReceiverSingle()
        Me.lblWBPPP = New System.Windows.Forms.Label()
        Me.lblSS2011 = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.lblSS2009 = New System.Windows.Forms.Label()
        Me.ucrReceiverSS2009 = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'ucrReceiverSmallState
        '
        Me.ucrReceiverSmallState.AutoSize = True
        Me.ucrReceiverSmallState.frmParent = Me
        Me.ucrReceiverSmallState.Location = New System.Drawing.Point(251, 216)
        Me.ucrReceiverSmallState.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSmallState.Name = "ucrReceiverSmallState"
        Me.ucrReceiverSmallState.Selector = Nothing
        Me.ucrReceiverSmallState.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSmallState.strNcFilePath = ""
        Me.ucrReceiverSmallState.TabIndex = 10
        Me.ucrReceiverSmallState.ucrSelector = Nothing
        '
        'lblSmallState
        '
        Me.lblSmallState.AutoSize = True
        Me.lblSmallState.Location = New System.Drawing.Point(251, 201)
        Me.lblSmallState.Name = "lblSmallState"
        Me.lblSmallState.Size = New System.Drawing.Size(63, 13)
        Me.lblSmallState.TabIndex = 9
        Me.lblSmallState.Text = "Small State:"
        '
        'lblCountryISO2
        '
        Me.lblCountryISO2.AutoSize = True
        Me.lblCountryISO2.Location = New System.Drawing.Point(251, 70)
        Me.lblCountryISO2.Name = "lblCountryISO2"
        Me.lblCountryISO2.Size = New System.Drawing.Size(73, 13)
        Me.lblCountryISO2.TabIndex = 3
        Me.lblCountryISO2.Text = "Country ISO2:"
        '
        'ucrReceiverISO2
        '
        Me.ucrReceiverISO2.AutoSize = True
        Me.ucrReceiverISO2.frmParent = Me
        Me.ucrReceiverISO2.Location = New System.Drawing.Point(251, 85)
        Me.ucrReceiverISO2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverISO2.Name = "ucrReceiverISO2"
        Me.ucrReceiverISO2.Selector = Nothing
        Me.ucrReceiverISO2.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverISO2.strNcFilePath = ""
        Me.ucrReceiverISO2.TabIndex = 4
        Me.ucrReceiverISO2.ucrSelector = Nothing
        '
        'ucrCountryLevelSelector
        '
        Me.ucrCountryLevelSelector.AutoSize = True
        Me.ucrCountryLevelSelector.bDropUnusedFilterLevels = False
        Me.ucrCountryLevelSelector.bShowHiddenColumns = False
        Me.ucrCountryLevelSelector.bUseCurrentFilter = True
        Me.ucrCountryLevelSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrCountryLevelSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrCountryLevelSelector.Name = "ucrCountryLevelSelector"
        Me.ucrCountryLevelSelector.Size = New System.Drawing.Size(213, 183)
        Me.ucrCountryLevelSelector.TabIndex = 0
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(251, 27)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(46, 13)
        Me.lblCountry.TabIndex = 1
        Me.lblCountry.Text = "Country:"
        '
        'ucrReceiverCountry
        '
        Me.ucrReceiverCountry.AutoSize = True
        Me.ucrReceiverCountry.frmParent = Me
        Me.ucrReceiverCountry.Location = New System.Drawing.Point(251, 42)
        Me.ucrReceiverCountry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCountry.Name = "ucrReceiverCountry"
        Me.ucrReceiverCountry.Selector = Nothing
        Me.ucrReceiverCountry.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverCountry.strNcFilePath = ""
        Me.ucrReceiverCountry.TabIndex = 2
        Me.ucrReceiverCountry.ucrSelector = Nothing
        '
        'ucrReceiverSS2015
        '
        Me.ucrReceiverSS2015.AutoSize = True
        Me.ucrReceiverSS2015.frmParent = Me
        Me.ucrReceiverSS2015.Location = New System.Drawing.Point(395, 171)
        Me.ucrReceiverSS2015.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSS2015.Name = "ucrReceiverSS2015"
        Me.ucrReceiverSS2015.Selector = Nothing
        Me.ucrReceiverSS2015.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSS2015.strNcFilePath = ""
        Me.ucrReceiverSS2015.TabIndex = 18
        Me.ucrReceiverSS2015.ucrSelector = Nothing
        '
        'lblSS2015
        '
        Me.lblSS2015.AutoSize = True
        Me.lblSS2015.Location = New System.Drawing.Point(395, 156)
        Me.lblSS2015.Name = "lblSS2015"
        Me.lblSS2015.Size = New System.Drawing.Size(51, 13)
        Me.lblSS2015.TabIndex = 17
        Me.lblSS2015.Text = "SS 2015:"
        '
        'ucrReceiverISO3
        '
        Me.ucrReceiverISO3.AutoSize = True
        Me.ucrReceiverISO3.frmParent = Me
        Me.ucrReceiverISO3.Location = New System.Drawing.Point(251, 128)
        Me.ucrReceiverISO3.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverISO3.Name = "ucrReceiverISO3"
        Me.ucrReceiverISO3.Selector = Nothing
        Me.ucrReceiverISO3.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverISO3.strNcFilePath = ""
        Me.ucrReceiverISO3.TabIndex = 6
        Me.ucrReceiverISO3.ucrSelector = Nothing
        '
        'lblCountryISO3
        '
        Me.lblCountryISO3.AutoSize = True
        Me.lblCountryISO3.Location = New System.Drawing.Point(251, 113)
        Me.lblCountryISO3.Name = "lblCountryISO3"
        Me.lblCountryISO3.Size = New System.Drawing.Size(73, 13)
        Me.lblCountryISO3.TabIndex = 5
        Me.lblCountryISO3.Text = "Country ISO3:"
        '
        'ucrReceiverSS2011
        '
        Me.ucrReceiverSS2011.AutoSize = True
        Me.ucrReceiverSS2011.frmParent = Me
        Me.ucrReceiverSS2011.Location = New System.Drawing.Point(395, 85)
        Me.ucrReceiverSS2011.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSS2011.Name = "ucrReceiverSS2011"
        Me.ucrReceiverSS2011.Selector = Nothing
        Me.ucrReceiverSS2011.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSS2011.strNcFilePath = ""
        Me.ucrReceiverSS2011.TabIndex = 14
        Me.ucrReceiverSS2011.ucrSelector = Nothing
        '
        'lblSS2013
        '
        Me.lblSS2013.AutoSize = True
        Me.lblSS2013.Location = New System.Drawing.Point(395, 113)
        Me.lblSS2013.Name = "lblSS2013"
        Me.lblSS2013.Size = New System.Drawing.Size(48, 13)
        Me.lblSS2013.TabIndex = 15
        Me.lblSS2013.Text = "SS 2013"
        '
        'ucrReceiverWBPPP
        '
        Me.ucrReceiverWBPPP.AutoSize = True
        Me.ucrReceiverWBPPP.frmParent = Me
        Me.ucrReceiverWBPPP.Location = New System.Drawing.Point(251, 171)
        Me.ucrReceiverWBPPP.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWBPPP.Name = "ucrReceiverWBPPP"
        Me.ucrReceiverWBPPP.Selector = Nothing
        Me.ucrReceiverWBPPP.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWBPPP.strNcFilePath = ""
        Me.ucrReceiverWBPPP.TabIndex = 8
        Me.ucrReceiverWBPPP.ucrSelector = Nothing
        '
        'ucrReceiverSS2013
        '
        Me.ucrReceiverSS2013.AutoSize = True
        Me.ucrReceiverSS2013.frmParent = Me
        Me.ucrReceiverSS2013.Location = New System.Drawing.Point(395, 128)
        Me.ucrReceiverSS2013.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSS2013.Name = "ucrReceiverSS2013"
        Me.ucrReceiverSS2013.Selector = Nothing
        Me.ucrReceiverSS2013.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSS2013.strNcFilePath = ""
        Me.ucrReceiverSS2013.TabIndex = 16
        Me.ucrReceiverSS2013.ucrSelector = Nothing
        '
        'lblWBPPP
        '
        Me.lblWBPPP.AutoSize = True
        Me.lblWBPPP.Location = New System.Drawing.Point(251, 156)
        Me.lblWBPPP.Name = "lblWBPPP"
        Me.lblWBPPP.Size = New System.Drawing.Size(52, 13)
        Me.lblWBPPP.TabIndex = 7
        Me.lblWBPPP.Text = "WB PPP:"
        '
        'lblSS2011
        '
        Me.lblSS2011.AutoSize = True
        Me.lblSS2011.Location = New System.Drawing.Point(395, 70)
        Me.lblSS2011.Name = "lblSS2011"
        Me.lblSS2011.Size = New System.Drawing.Size(51, 13)
        Me.lblSS2011.TabIndex = 13
        Me.lblSS2011.Text = "SS 2011:"
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.Location = New System.Drawing.Point(186, 252)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(224, 30)
        Me.ucrBase.TabIndex = 19
        '
        'lblSS2009
        '
        Me.lblSS2009.AutoSize = True
        Me.lblSS2009.Location = New System.Drawing.Point(395, 27)
        Me.lblSS2009.Name = "lblSS2009"
        Me.lblSS2009.Size = New System.Drawing.Size(51, 13)
        Me.lblSS2009.TabIndex = 11
        Me.lblSS2009.Text = "SS 2009:"
        '
        'ucrReceiverSS2009
        '
        Me.ucrReceiverSS2009.AutoSize = True
        Me.ucrReceiverSS2009.frmParent = Me
        Me.ucrReceiverSS2009.Location = New System.Drawing.Point(395, 42)
        Me.ucrReceiverSS2009.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSS2009.Name = "ucrReceiverSS2009"
        Me.ucrReceiverSS2009.Selector = Nothing
        Me.ucrReceiverSS2009.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSS2009.strNcFilePath = ""
        Me.ucrReceiverSS2009.TabIndex = 12
        Me.ucrReceiverSS2009.ucrSelector = Nothing
        '
        'sdgCorruptionCountryLevelColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(523, 288)
        Me.Controls.Add(Me.lblSS2009)
        Me.Controls.Add(Me.ucrReceiverSS2009)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblCountryISO2)
        Me.Controls.Add(Me.ucrReceiverISO2)
        Me.Controls.Add(Me.ucrCountryLevelSelector)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.lblSS2011)
        Me.Controls.Add(Me.lblWBPPP)
        Me.Controls.Add(Me.ucrReceiverSS2013)
        Me.Controls.Add(Me.ucrReceiverWBPPP)
        Me.Controls.Add(Me.lblSS2013)
        Me.Controls.Add(Me.ucrReceiverSS2011)
        Me.Controls.Add(Me.ucrReceiverCountry)
        Me.Controls.Add(Me.lblCountryISO3)
        Me.Controls.Add(Me.ucrReceiverISO3)
        Me.Controls.Add(Me.lblSS2015)
        Me.Controls.Add(Me.ucrReceiverSS2015)
        Me.Controls.Add(Me.ucrReceiverSmallState)
        Me.Controls.Add(Me.lblSmallState)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCorruptionCountryLevelColumns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Country Level Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverSmallState As ucrReceiverSingle
    Friend WithEvents lblSmallState As Label
    Friend WithEvents lblCountryISO2 As Label
    Friend WithEvents ucrReceiverISO2 As ucrReceiverSingle
    Friend WithEvents ucrCountryLevelSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblCountry As Label
    Friend WithEvents lblSS2011 As Label
    Friend WithEvents lblWBPPP As Label
    Friend WithEvents ucrReceiverSS2013 As ucrReceiverSingle
    Friend WithEvents ucrReceiverWBPPP As ucrReceiverSingle
    Friend WithEvents lblSS2013 As Label
    Friend WithEvents ucrReceiverSS2011 As ucrReceiverSingle
    Friend WithEvents ucrReceiverCountry As ucrReceiverSingle
    Friend WithEvents lblCountryISO3 As Label
    Friend WithEvents ucrReceiverISO3 As ucrReceiverSingle
    Friend WithEvents lblSS2015 As Label
    Friend WithEvents ucrReceiverSS2015 As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents lblSS2009 As Label
    Friend WithEvents ucrReceiverSS2009 As ucrReceiverSingle
End Class
