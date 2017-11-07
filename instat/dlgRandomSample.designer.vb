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
Partial Class dlgRandomSample
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRandomSample))
        Me.lblSampleSize = New System.Windows.Forms.Label()
        Me.lblNumberofSamples = New System.Windows.Forms.Label()
        Me.ucrSampleSize = New instat.ucrDataFrameLength()
        Me.ucrSelectorRandomSamples = New instat.ucrDataFrame()
        Me.ucrDistWithParameters = New instat.ucrDistributionsWithParameters()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkSetSeed = New instat.ucrCheck()
        Me.ucrNudSeed = New instat.ucrNud()
        Me.ucrNudNumberOfSamples = New instat.ucrNud()
        Me.ucrSaveRandomSamples = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'lblSampleSize
        '
        resources.ApplyResources(Me.lblSampleSize, "lblSampleSize")
        Me.lblSampleSize.Name = "lblSampleSize"
        Me.lblSampleSize.Tag = "Sample_Size:"
        '
        'lblNumberofSamples
        '
        resources.ApplyResources(Me.lblNumberofSamples, "lblNumberofSamples")
        Me.lblNumberofSamples.Name = "lblNumberofSamples"
        Me.lblNumberofSamples.Tag = "Number_of_Samples:"
        '
        'ucrSampleSize
        '
        resources.ApplyResources(Me.ucrSampleSize, "ucrSampleSize")
        Me.ucrSampleSize.Name = "ucrSampleSize"
        Me.ucrSampleSize.ucrDataFrameSelector = Nothing
        '
        'ucrSelectorRandomSamples
        '
        Me.ucrSelectorRandomSamples.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorRandomSamples, "ucrSelectorRandomSamples")
        Me.ucrSelectorRandomSamples.Name = "ucrSelectorRandomSamples"
        '
        'ucrDistWithParameters
        '
        resources.ApplyResources(Me.ucrDistWithParameters, "ucrDistWithParameters")
        Me.ucrDistWithParameters.Name = "ucrDistWithParameters"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrChkSetSeed
        '
        Me.ucrChkSetSeed.Checked = False
        resources.ApplyResources(Me.ucrChkSetSeed, "ucrChkSetSeed")
        Me.ucrChkSetSeed.Name = "ucrChkSetSeed"
        '
        'ucrNudSeed
        '
        Me.ucrNudSeed.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSeed.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSeed, "ucrNudSeed")
        Me.ucrNudSeed.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSeed.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSeed.Name = "ucrNudSeed"
        Me.ucrNudSeed.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNumberOfSamples
        '
        Me.ucrNudNumberOfSamples.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfSamples.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudNumberOfSamples, "ucrNudNumberOfSamples")
        Me.ucrNudNumberOfSamples.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfSamples.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfSamples.Name = "ucrNudNumberOfSamples"
        Me.ucrNudNumberOfSamples.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSaveRandomSamples
        '
        resources.ApplyResources(Me.ucrSaveRandomSamples, "ucrSaveRandomSamples")
        Me.ucrSaveRandomSamples.Name = "ucrSaveRandomSamples"
        '
        'dlgRandomSample
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveRandomSamples)
        Me.Controls.Add(Me.ucrNudNumberOfSamples)
        Me.Controls.Add(Me.ucrNudSeed)
        Me.Controls.Add(Me.ucrChkSetSeed)
        Me.Controls.Add(Me.ucrSampleSize)
        Me.Controls.Add(Me.lblNumberofSamples)
        Me.Controls.Add(Me.lblSampleSize)
        Me.Controls.Add(Me.ucrSelectorRandomSamples)
        Me.Controls.Add(Me.ucrDistWithParameters)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRandomSample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDistWithParameters As ucrDistributionsWithParameters
    Friend WithEvents ucrSelectorRandomSamples As ucrDataFrame
    Friend WithEvents lblSampleSize As Label
    Friend WithEvents lblNumberofSamples As Label
    Friend WithEvents ucrSampleSize As ucrDataFrameLength
    Friend WithEvents ucrChkSetSeed As ucrCheck
    Friend WithEvents ucrNudSeed As ucrNud
    Friend WithEvents ucrNudNumberOfSamples As ucrNud
    Friend WithEvents ucrSaveRandomSamples As ucrSave
End Class
