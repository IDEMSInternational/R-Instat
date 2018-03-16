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
Partial Class dlgLinePlot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgLinePlot))
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdLineOptions = New System.Windows.Forms.Button()
        Me.lblFactorOptional = New System.Windows.Forms.Label()
        Me.ucrChkWithSE = New instat.ucrCheck()
        Me.ucrChkLineofBestFit = New instat.ucrCheck()
        Me.ucrChkPoints = New instat.ucrCheck()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrVariablesAsFactorForLinePlot = New instat.ucrVariablesAsFactor()
        Me.ucrLinePlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrFactorOptionalReceiver = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'lblXVariable
        '
        resources.ApplyResources(Me.lblXVariable, "lblXVariable")
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Tag = "X_Variable:"
        '
        'lblAvailable
        '
        resources.ApplyResources(Me.lblAvailable, "lblAvailable")
        Me.lblAvailable.Name = "lblAvailable"
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdLineOptions
        '
        resources.ApplyResources(Me.cmdLineOptions, "cmdLineOptions")
        Me.cmdLineOptions.Name = "cmdLineOptions"
        Me.cmdLineOptions.Tag = "Line_Options"
        Me.cmdLineOptions.UseVisualStyleBackColor = True
        '
        'lblFactorOptional
        '
        resources.ApplyResources(Me.lblFactorOptional, "lblFactorOptional")
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Tag = "Factor_Optional:"
        '
        'ucrChkWithSE
        '
        Me.ucrChkWithSE.Checked = False
        resources.ApplyResources(Me.ucrChkWithSE, "ucrChkWithSE")
        Me.ucrChkWithSE.Name = "ucrChkWithSE"
        '
        'ucrChkLineofBestFit
        '
        Me.ucrChkLineofBestFit.Checked = False
        resources.ApplyResources(Me.ucrChkLineofBestFit, "ucrChkLineofBestFit")
        Me.ucrChkLineofBestFit.Name = "ucrChkLineofBestFit"
        '
        'ucrChkPoints
        '
        Me.ucrChkPoints.Checked = False
        resources.ApplyResources(Me.ucrChkPoints, "ucrChkPoints")
        Me.ucrChkPoints.Name = "ucrChkPoints"
        '
        'ucrSave
        '
        resources.ApplyResources(Me.ucrSave, "ucrSave")
        Me.ucrSave.Name = "ucrSave"
        '
        'ucrVariablesAsFactorForLinePlot
        '
        Me.ucrVariablesAsFactorForLinePlot.frmParent = Me
        resources.ApplyResources(Me.ucrVariablesAsFactorForLinePlot, "ucrVariablesAsFactorForLinePlot")
        Me.ucrVariablesAsFactorForLinePlot.Name = "ucrVariablesAsFactorForLinePlot"
        Me.ucrVariablesAsFactorForLinePlot.Selector = Nothing
        Me.ucrVariablesAsFactorForLinePlot.strNcFilePath = ""
        Me.ucrVariablesAsFactorForLinePlot.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForLinePlot.ucrVariableSelector = Nothing
        '
        'ucrLinePlotSelector
        '
        Me.ucrLinePlotSelector.bShowHiddenColumns = False
        Me.ucrLinePlotSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrLinePlotSelector, "ucrLinePlotSelector")
        Me.ucrLinePlotSelector.Name = "ucrLinePlotSelector"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrFactorOptionalReceiver
        '
        Me.ucrFactorOptionalReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrFactorOptionalReceiver, "ucrFactorOptionalReceiver")
        Me.ucrFactorOptionalReceiver.Name = "ucrFactorOptionalReceiver"
        Me.ucrFactorOptionalReceiver.Selector = Nothing
        Me.ucrFactorOptionalReceiver.strNcFilePath = ""
        Me.ucrFactorOptionalReceiver.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverX, "ucrReceiverX")
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'dlgLinePlot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkWithSE)
        Me.Controls.Add(Me.ucrChkLineofBestFit)
        Me.Controls.Add(Me.ucrChkPoints)
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.ucrVariablesAsFactorForLinePlot)
        Me.Controls.Add(Me.cmdLineOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrLinePlotSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrFactorOptionalReceiver)
        Me.Controls.Add(Me.lblFactorOptional)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.lblAvailable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgLinePlot"
        Me.Tag = "Line_Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblXVariable As Label
    Friend WithEvents lblAvailable As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrLinePlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdLineOptions As Button
    Friend WithEvents lblFactorOptional As Label
    Friend WithEvents ucrFactorOptionalReceiver As ucrReceiverSingle
    Friend WithEvents ucrVariablesAsFactorForLinePlot As ucrVariablesAsFactor
    Friend WithEvents ucrChkPoints As ucrCheck
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents ucrChkLineofBestFit As ucrCheck
    Friend WithEvents ucrChkWithSE As ucrCheck
End Class
