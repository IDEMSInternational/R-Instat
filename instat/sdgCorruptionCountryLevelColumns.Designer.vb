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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgCorruptionCountryLevelColumns))
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
        Me.ucrReceiverSmallState.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSmallState, "ucrReceiverSmallState")
        Me.ucrReceiverSmallState.Name = "ucrReceiverSmallState"
        Me.ucrReceiverSmallState.Selector = Nothing
        Me.ucrReceiverSmallState.strNcFilePath = ""
        Me.ucrReceiverSmallState.ucrSelector = Nothing
        '
        'lblSmallState
        '
        resources.ApplyResources(Me.lblSmallState, "lblSmallState")
        Me.lblSmallState.Name = "lblSmallState"
        '
        'lblCountryISO2
        '
        resources.ApplyResources(Me.lblCountryISO2, "lblCountryISO2")
        Me.lblCountryISO2.Name = "lblCountryISO2"
        '
        'ucrReceiverISO2
        '
        Me.ucrReceiverISO2.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverISO2, "ucrReceiverISO2")
        Me.ucrReceiverISO2.Name = "ucrReceiverISO2"
        Me.ucrReceiverISO2.Selector = Nothing
        Me.ucrReceiverISO2.strNcFilePath = ""
        Me.ucrReceiverISO2.ucrSelector = Nothing
        '
        'ucrCountryLevelSelector
        '
        Me.ucrCountryLevelSelector.bShowHiddenColumns = False
        Me.ucrCountryLevelSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrCountryLevelSelector, "ucrCountryLevelSelector")
        Me.ucrCountryLevelSelector.Name = "ucrCountryLevelSelector"
        '
        'lblCountry
        '
        resources.ApplyResources(Me.lblCountry, "lblCountry")
        Me.lblCountry.Name = "lblCountry"
        '
        'ucrReceiverCountry
        '
        Me.ucrReceiverCountry.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverCountry, "ucrReceiverCountry")
        Me.ucrReceiverCountry.Name = "ucrReceiverCountry"
        Me.ucrReceiverCountry.Selector = Nothing
        Me.ucrReceiverCountry.strNcFilePath = ""
        Me.ucrReceiverCountry.ucrSelector = Nothing
        '
        'ucrReceiverSS2015
        '
        Me.ucrReceiverSS2015.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSS2015, "ucrReceiverSS2015")
        Me.ucrReceiverSS2015.Name = "ucrReceiverSS2015"
        Me.ucrReceiverSS2015.Selector = Nothing
        Me.ucrReceiverSS2015.strNcFilePath = ""
        Me.ucrReceiverSS2015.ucrSelector = Nothing
        '
        'lblSS2015
        '
        resources.ApplyResources(Me.lblSS2015, "lblSS2015")
        Me.lblSS2015.Name = "lblSS2015"
        '
        'ucrReceiverISO3
        '
        Me.ucrReceiverISO3.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverISO3, "ucrReceiverISO3")
        Me.ucrReceiverISO3.Name = "ucrReceiverISO3"
        Me.ucrReceiverISO3.Selector = Nothing
        Me.ucrReceiverISO3.strNcFilePath = ""
        Me.ucrReceiverISO3.ucrSelector = Nothing
        '
        'lblCountryISO3
        '
        resources.ApplyResources(Me.lblCountryISO3, "lblCountryISO3")
        Me.lblCountryISO3.Name = "lblCountryISO3"
        '
        'ucrReceiverSS2011
        '
        Me.ucrReceiverSS2011.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSS2011, "ucrReceiverSS2011")
        Me.ucrReceiverSS2011.Name = "ucrReceiverSS2011"
        Me.ucrReceiverSS2011.Selector = Nothing
        Me.ucrReceiverSS2011.strNcFilePath = ""
        Me.ucrReceiverSS2011.ucrSelector = Nothing
        '
        'lblSS2013
        '
        resources.ApplyResources(Me.lblSS2013, "lblSS2013")
        Me.lblSS2013.Name = "lblSS2013"
        '
        'ucrReceiverWBPPP
        '
        Me.ucrReceiverWBPPP.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWBPPP, "ucrReceiverWBPPP")
        Me.ucrReceiverWBPPP.Name = "ucrReceiverWBPPP"
        Me.ucrReceiverWBPPP.Selector = Nothing
        Me.ucrReceiverWBPPP.strNcFilePath = ""
        Me.ucrReceiverWBPPP.ucrSelector = Nothing
        '
        'ucrReceiverSS2013
        '
        Me.ucrReceiverSS2013.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSS2013, "ucrReceiverSS2013")
        Me.ucrReceiverSS2013.Name = "ucrReceiverSS2013"
        Me.ucrReceiverSS2013.Selector = Nothing
        Me.ucrReceiverSS2013.strNcFilePath = ""
        Me.ucrReceiverSS2013.ucrSelector = Nothing
        '
        'lblWBPPP
        '
        resources.ApplyResources(Me.lblWBPPP, "lblWBPPP")
        Me.lblWBPPP.Name = "lblWBPPP"
        '
        'lblSS2011
        '
        resources.ApplyResources(Me.lblSS2011, "lblSS2011")
        Me.lblSS2011.Name = "lblSS2011"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'lblSS2009
        '
        resources.ApplyResources(Me.lblSS2009, "lblSS2009")
        Me.lblSS2009.Name = "lblSS2009"
        '
        'ucrReceiverSS2009
        '
        Me.ucrReceiverSS2009.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSS2009, "ucrReceiverSS2009")
        Me.ucrReceiverSS2009.Name = "ucrReceiverSS2009"
        Me.ucrReceiverSS2009.Selector = Nothing
        Me.ucrReceiverSS2009.strNcFilePath = ""
        Me.ucrReceiverSS2009.ucrSelector = Nothing
        '
        'sdgCorruptionCountryLevelColumns
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
