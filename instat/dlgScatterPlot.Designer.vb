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
Partial Class dlgScatterPlot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgScatterPlot))
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblFactorOptional = New System.Windows.Forms.Label()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.cmdScatterPlotOptions = New System.Windows.Forms.Button()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.rdoSegments = New System.Windows.Forms.RadioButton()
        Me.rdoPoints = New System.Windows.Forms.RadioButton()
        Me.lblXStart = New System.Windows.Forms.Label()
        Me.lblXEnd = New System.Windows.Forms.Label()
        Me.lblYEnd = New System.Windows.Forms.Label()
        Me.lblYStart = New System.Windows.Forms.Label()
        Me.grpLollipopType = New System.Windows.Forms.GroupBox()
        Me.rdoDiagonal = New System.Windows.Forms.RadioButton()
        Me.rdoDouble = New System.Windows.Forms.RadioButton()
        Me.rdoSimple = New System.Windows.Forms.RadioButton()
        Me.ucrChkAddPoints = New instat.ucrCheck()
        Me.ucrReceiverYEnd = New instat.ucrReceiverSingle()
        Me.ucrReceiverYStart = New instat.ucrReceiverSingle()
        Me.ucrReceiverXEnd = New instat.ucrReceiverSingle()
        Me.ucrReceiverXStart = New instat.ucrReceiverSingle()
        Me.ucrPnlType = New instat.UcrPanel()
        Me.ucrReceiverLabel = New instat.ucrReceiverSingle()
        Me.ucrChkWithSE = New instat.ucrCheck()
        Me.ucrChkLineofBestFit = New instat.ucrCheck()
        Me.ucrSaveScatterPlot = New instat.ucrSave()
        Me.ucrSelectorForScatter = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrVariablesAsFactorForScatter = New instat.ucrVariablesAsFactor()
        Me.ucrFactorOptionalReceiver = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkHorizontal = New instat.ucrCheck()
        Me.grpLollipopType.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblFactorOptional
        '
        resources.ApplyResources(Me.lblFactorOptional, "lblFactorOptional")
        Me.lblFactorOptional.Name = "lblFactorOptional"
        Me.lblFactorOptional.Tag = "By_Variable_Optional:"
        '
        'lblXVariable
        '
        resources.ApplyResources(Me.lblXVariable, "lblXVariable")
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Tag = "X_Variable:"
        '
        'cmdScatterPlotOptions
        '
        resources.ApplyResources(Me.cmdScatterPlotOptions, "cmdScatterPlotOptions")
        Me.cmdScatterPlotOptions.Name = "cmdScatterPlotOptions"
        Me.cmdScatterPlotOptions.Tag = "ScatterPlot_Options"
        Me.cmdScatterPlotOptions.UseVisualStyleBackColor = True
        '
        'lblVariable
        '
        resources.ApplyResources(Me.lblVariable, "lblVariable")
        Me.lblVariable.Name = "lblVariable"
        '
        'rdoSegments
        '
        resources.ApplyResources(Me.rdoSegments, "rdoSegments")
        Me.rdoSegments.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSegments.FlatAppearance.BorderSize = 2
        Me.rdoSegments.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSegments.Name = "rdoSegments"
        Me.rdoSegments.TabStop = True
        Me.rdoSegments.UseVisualStyleBackColor = True
        '
        'rdoPoints
        '
        resources.ApplyResources(Me.rdoPoints, "rdoPoints")
        Me.rdoPoints.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPoints.FlatAppearance.BorderSize = 2
        Me.rdoPoints.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPoints.Name = "rdoPoints"
        Me.rdoPoints.TabStop = True
        Me.rdoPoints.UseVisualStyleBackColor = True
        '
        'lblXStart
        '
        resources.ApplyResources(Me.lblXStart, "lblXStart")
        Me.lblXStart.Name = "lblXStart"
        Me.lblXStart.Tag = "X_Variable:"
        '
        'lblXEnd
        '
        resources.ApplyResources(Me.lblXEnd, "lblXEnd")
        Me.lblXEnd.Name = "lblXEnd"
        Me.lblXEnd.Tag = "X_Variable:"
        '
        'lblYEnd
        '
        resources.ApplyResources(Me.lblYEnd, "lblYEnd")
        Me.lblYEnd.Name = "lblYEnd"
        Me.lblYEnd.Tag = "X_Variable:"
        '
        'lblYStart
        '
        resources.ApplyResources(Me.lblYStart, "lblYStart")
        Me.lblYStart.Name = "lblYStart"
        Me.lblYStart.Tag = "X_Variable:"
        '
        'grpLollipopType
        '
        Me.grpLollipopType.Controls.Add(Me.rdoDiagonal)
        Me.grpLollipopType.Controls.Add(Me.rdoDouble)
        Me.grpLollipopType.Controls.Add(Me.rdoSimple)
        resources.ApplyResources(Me.grpLollipopType, "grpLollipopType")
        Me.grpLollipopType.Name = "grpLollipopType"
        Me.grpLollipopType.TabStop = False
        '
        'rdoDiagonal
        '
        resources.ApplyResources(Me.rdoDiagonal, "rdoDiagonal")
        Me.rdoDiagonal.Name = "rdoDiagonal"
        Me.rdoDiagonal.TabStop = True
        Me.rdoDiagonal.UseVisualStyleBackColor = True
        '
        'rdoDouble
        '
        resources.ApplyResources(Me.rdoDouble, "rdoDouble")
        Me.rdoDouble.Name = "rdoDouble"
        Me.rdoDouble.TabStop = True
        Me.rdoDouble.UseVisualStyleBackColor = True
        '
        'rdoSimple
        '
        resources.ApplyResources(Me.rdoSimple, "rdoSimple")
        Me.rdoSimple.Name = "rdoSimple"
        Me.rdoSimple.TabStop = True
        Me.rdoSimple.UseVisualStyleBackColor = True
        '
        'ucrChkAddPoints
        '
        Me.ucrChkAddPoints.Checked = False
        resources.ApplyResources(Me.ucrChkAddPoints, "ucrChkAddPoints")
        Me.ucrChkAddPoints.Name = "ucrChkAddPoints"
        '
        'ucrReceiverYEnd
        '
        Me.ucrReceiverYEnd.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYEnd, "ucrReceiverYEnd")
        Me.ucrReceiverYEnd.Name = "ucrReceiverYEnd"
        Me.ucrReceiverYEnd.Selector = Nothing
        Me.ucrReceiverYEnd.strNcFilePath = ""
        Me.ucrReceiverYEnd.ucrSelector = Nothing
        '
        'ucrReceiverYStart
        '
        Me.ucrReceiverYStart.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYStart, "ucrReceiverYStart")
        Me.ucrReceiverYStart.Name = "ucrReceiverYStart"
        Me.ucrReceiverYStart.Selector = Nothing
        Me.ucrReceiverYStart.strNcFilePath = ""
        Me.ucrReceiverYStart.ucrSelector = Nothing
        '
        'ucrReceiverXEnd
        '
        Me.ucrReceiverXEnd.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverXEnd, "ucrReceiverXEnd")
        Me.ucrReceiverXEnd.Name = "ucrReceiverXEnd"
        Me.ucrReceiverXEnd.Selector = Nothing
        Me.ucrReceiverXEnd.strNcFilePath = ""
        Me.ucrReceiverXEnd.ucrSelector = Nothing
        '
        'ucrReceiverXStart
        '
        Me.ucrReceiverXStart.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverXStart, "ucrReceiverXStart")
        Me.ucrReceiverXStart.Name = "ucrReceiverXStart"
        Me.ucrReceiverXStart.Selector = Nothing
        Me.ucrReceiverXStart.strNcFilePath = ""
        Me.ucrReceiverXStart.ucrSelector = Nothing
        '
        'ucrPnlType
        '
        resources.ApplyResources(Me.ucrPnlType, "ucrPnlType")
        Me.ucrPnlType.Name = "ucrPnlType"
        '
        'ucrReceiverLabel
        '
        Me.ucrReceiverLabel.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverLabel, "ucrReceiverLabel")
        Me.ucrReceiverLabel.Name = "ucrReceiverLabel"
        Me.ucrReceiverLabel.Selector = Nothing
        Me.ucrReceiverLabel.strNcFilePath = ""
        Me.ucrReceiverLabel.ucrSelector = Nothing
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
        'ucrSaveScatterPlot
        '
        resources.ApplyResources(Me.ucrSaveScatterPlot, "ucrSaveScatterPlot")
        Me.ucrSaveScatterPlot.Name = "ucrSaveScatterPlot"
        '
        'ucrSelectorForScatter
        '
        Me.ucrSelectorForScatter.bDropUnusedFilterLevels = False
        Me.ucrSelectorForScatter.bShowHiddenColumns = False
        Me.ucrSelectorForScatter.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForScatter, "ucrSelectorForScatter")
        Me.ucrSelectorForScatter.Name = "ucrSelectorForScatter"
        '
        'ucrVariablesAsFactorForScatter
        '
        Me.ucrVariablesAsFactorForScatter.frmParent = Me
        resources.ApplyResources(Me.ucrVariablesAsFactorForScatter, "ucrVariablesAsFactorForScatter")
        Me.ucrVariablesAsFactorForScatter.Name = "ucrVariablesAsFactorForScatter"
        Me.ucrVariablesAsFactorForScatter.Selector = Nothing
        Me.ucrVariablesAsFactorForScatter.strNcFilePath = ""
        Me.ucrVariablesAsFactorForScatter.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForScatter.ucrVariableSelector = Nothing
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
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrChkHorizontal
        '
        Me.ucrChkHorizontal.Checked = False
        resources.ApplyResources(Me.ucrChkHorizontal, "ucrChkHorizontal")
        Me.ucrChkHorizontal.Name = "ucrChkHorizontal"
        '
        'dlgScatterPlot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkHorizontal)
        Me.Controls.Add(Me.ucrChkAddPoints)
        Me.Controls.Add(Me.grpLollipopType)
        Me.Controls.Add(Me.ucrReceiverYEnd)
        Me.Controls.Add(Me.lblYEnd)
        Me.Controls.Add(Me.ucrReceiverYStart)
        Me.Controls.Add(Me.lblYStart)
        Me.Controls.Add(Me.ucrReceiverXEnd)
        Me.Controls.Add(Me.lblXEnd)
        Me.Controls.Add(Me.ucrReceiverXStart)
        Me.Controls.Add(Me.lblXStart)
        Me.Controls.Add(Me.rdoSegments)
        Me.Controls.Add(Me.rdoPoints)
        Me.Controls.Add(Me.ucrPnlType)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrReceiverLabel)
        Me.Controls.Add(Me.ucrChkWithSE)
        Me.Controls.Add(Me.ucrChkLineofBestFit)
        Me.Controls.Add(Me.ucrSaveScatterPlot)
        Me.Controls.Add(Me.ucrSelectorForScatter)
        Me.Controls.Add(Me.ucrVariablesAsFactorForScatter)
        Me.Controls.Add(Me.cmdScatterPlotOptions)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrFactorOptionalReceiver)
        Me.Controls.Add(Me.lblFactorOptional)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgScatterPlot"
        Me.grpLollipopType.ResumeLayout(False)
        Me.grpLollipopType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrFactorOptionalReceiver As ucrReceiverSingle
    Friend WithEvents lblFactorOptional As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents lblXVariable As Label
    Friend WithEvents cmdScatterPlotOptions As Button
    Friend WithEvents ucrVariablesAsFactorForScatter As ucrVariablesAsFactor
    Friend WithEvents ucrSelectorForScatter As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSaveScatterPlot As ucrSave
    Friend WithEvents ucrChkLineofBestFit As ucrCheck
    Friend WithEvents ucrChkWithSE As ucrCheck
    Friend WithEvents lblVariable As Label
    Friend WithEvents ucrReceiverLabel As ucrReceiverSingle
    Friend WithEvents rdoSegments As RadioButton
    Friend WithEvents rdoPoints As RadioButton
    Friend WithEvents ucrPnlType As UcrPanel
    Friend WithEvents ucrReceiverYEnd As ucrReceiverSingle
    Friend WithEvents lblYEnd As Label
    Friend WithEvents ucrReceiverYStart As ucrReceiverSingle
    Friend WithEvents lblYStart As Label
    Friend WithEvents ucrReceiverXEnd As ucrReceiverSingle
    Friend WithEvents lblXEnd As Label
    Friend WithEvents ucrReceiverXStart As ucrReceiverSingle
    Friend WithEvents lblXStart As Label
    Friend WithEvents grpLollipopType As GroupBox
    Friend WithEvents ucrChkAddPoints As ucrCheck
    Friend WithEvents rdoDiagonal As RadioButton
    Friend WithEvents rdoDouble As RadioButton
    Friend WithEvents rdoSimple As RadioButton
    Friend WithEvents ucrChkHorizontal As ucrCheck
End Class
