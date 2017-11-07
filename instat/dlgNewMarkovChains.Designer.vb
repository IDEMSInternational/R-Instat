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
Partial Class dlgNewMarkovChains
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgNewMarkovChains))
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorMarkovChains = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblRainfall = New System.Windows.Forms.Label()
        Me.lblDOY = New System.Windows.Forms.Label()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverRainfall = New instat.ucrReceiverSingle()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrInputExcludeSep = New instat.ucrInputComboBox()
        Me.lblExcludeSep = New System.Windows.Forms.Label()
        Me.grpSeasonalityHarmonics = New System.Windows.Forms.GroupBox()
        Me.lblSeasonalityTo = New System.Windows.Forms.Label()
        Me.lblSeasonalityFrom = New System.Windows.Forms.Label()
        Me.nudSeasonalityTo = New System.Windows.Forms.NumericUpDown()
        Me.nudSeasonalityFrom = New System.Windows.Forms.NumericUpDown()
        Me.grpOrder = New System.Windows.Forms.GroupBox()
        Me.ucrInputMarkovType = New instat.ucrInputComboBox()
        Me.lblMarkovType = New System.Windows.Forms.Label()
        Me.lblOrderTo = New System.Windows.Forms.Label()
        Me.lblOrderFrom = New System.Windows.Forms.Label()
        Me.nudOrderTo = New System.Windows.Forms.NumericUpDown()
        Me.nudOrderFrom = New System.Windows.Forms.NumericUpDown()
        Me.ucrInputInteractions = New instat.ucrInputComboBox()
        Me.lblInteractions = New System.Windows.Forms.Label()
        Me.lblAdditionalVariables = New System.Windows.Forms.Label()
        Me.ucrReceiverAdditionalVariables = New instat.ucrReceiverMultiple()
        Me.ucrInputOptions = New instat.ucrInputComboBox()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.chkSaveModel = New System.Windows.Forms.CheckBox()
        Me.chkGraph = New System.Windows.Forms.CheckBox()
        Me.ucrInputSaveModel = New instat.ucrInputComboBox()
        Me.grpSeasonalityHarmonics.SuspendLayout()
        CType(Me.nudSeasonalityTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSeasonalityFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOrder.SuspendLayout()
        CType(Me.nudOrderTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudOrderFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorMarkovChains
        '
        Me.ucrSelectorMarkovChains.bShowHiddenColumns = False
        Me.ucrSelectorMarkovChains.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorMarkovChains, "ucrSelectorMarkovChains")
        Me.ucrSelectorMarkovChains.Name = "ucrSelectorMarkovChains"
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
        '
        'lblRainfall
        '
        resources.ApplyResources(Me.lblRainfall, "lblRainfall")
        Me.lblRainfall.Name = "lblRainfall"
        '
        'lblDOY
        '
        resources.ApplyResources(Me.lblDOY, "lblDOY")
        Me.lblDOY.Name = "lblDOY"
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStation, "ucrReceiverStation")
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverRainfall
        '
        Me.ucrReceiverRainfall.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverRainfall, "ucrReceiverRainfall")
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.strNcFilePath = ""
        Me.ucrReceiverRainfall.ucrSelector = Nothing
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDOY, "ucrReceiverDOY")
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDate, "ucrReceiverDate")
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrInputExcludeSep
        '
        Me.ucrInputExcludeSep.AddQuotesIfUnrecognised = True
        Me.ucrInputExcludeSep.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputExcludeSep, "ucrInputExcludeSep")
        Me.ucrInputExcludeSep.Name = "ucrInputExcludeSep"
        '
        'lblExcludeSep
        '
        resources.ApplyResources(Me.lblExcludeSep, "lblExcludeSep")
        Me.lblExcludeSep.Name = "lblExcludeSep"
        '
        'grpSeasonalityHarmonics
        '
        Me.grpSeasonalityHarmonics.Controls.Add(Me.lblSeasonalityTo)
        Me.grpSeasonalityHarmonics.Controls.Add(Me.lblSeasonalityFrom)
        Me.grpSeasonalityHarmonics.Controls.Add(Me.nudSeasonalityTo)
        Me.grpSeasonalityHarmonics.Controls.Add(Me.nudSeasonalityFrom)
        resources.ApplyResources(Me.grpSeasonalityHarmonics, "grpSeasonalityHarmonics")
        Me.grpSeasonalityHarmonics.Name = "grpSeasonalityHarmonics"
        Me.grpSeasonalityHarmonics.TabStop = False
        '
        'lblSeasonalityTo
        '
        resources.ApplyResources(Me.lblSeasonalityTo, "lblSeasonalityTo")
        Me.lblSeasonalityTo.Name = "lblSeasonalityTo"
        '
        'lblSeasonalityFrom
        '
        resources.ApplyResources(Me.lblSeasonalityFrom, "lblSeasonalityFrom")
        Me.lblSeasonalityFrom.Name = "lblSeasonalityFrom"
        '
        'nudSeasonalityTo
        '
        resources.ApplyResources(Me.nudSeasonalityTo, "nudSeasonalityTo")
        Me.nudSeasonalityTo.Name = "nudSeasonalityTo"
        '
        'nudSeasonalityFrom
        '
        resources.ApplyResources(Me.nudSeasonalityFrom, "nudSeasonalityFrom")
        Me.nudSeasonalityFrom.Name = "nudSeasonalityFrom"
        '
        'grpOrder
        '
        Me.grpOrder.Controls.Add(Me.ucrInputMarkovType)
        Me.grpOrder.Controls.Add(Me.lblMarkovType)
        Me.grpOrder.Controls.Add(Me.lblOrderTo)
        Me.grpOrder.Controls.Add(Me.lblOrderFrom)
        Me.grpOrder.Controls.Add(Me.nudOrderTo)
        Me.grpOrder.Controls.Add(Me.nudOrderFrom)
        resources.ApplyResources(Me.grpOrder, "grpOrder")
        Me.grpOrder.Name = "grpOrder"
        Me.grpOrder.TabStop = False
        '
        'ucrInputMarkovType
        '
        Me.ucrInputMarkovType.AddQuotesIfUnrecognised = True
        Me.ucrInputMarkovType.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMarkovType, "ucrInputMarkovType")
        Me.ucrInputMarkovType.Name = "ucrInputMarkovType"
        '
        'lblMarkovType
        '
        resources.ApplyResources(Me.lblMarkovType, "lblMarkovType")
        Me.lblMarkovType.Name = "lblMarkovType"
        '
        'lblOrderTo
        '
        resources.ApplyResources(Me.lblOrderTo, "lblOrderTo")
        Me.lblOrderTo.Name = "lblOrderTo"
        '
        'lblOrderFrom
        '
        resources.ApplyResources(Me.lblOrderFrom, "lblOrderFrom")
        Me.lblOrderFrom.Name = "lblOrderFrom"
        '
        'nudOrderTo
        '
        resources.ApplyResources(Me.nudOrderTo, "nudOrderTo")
        Me.nudOrderTo.Name = "nudOrderTo"
        '
        'nudOrderFrom
        '
        resources.ApplyResources(Me.nudOrderFrom, "nudOrderFrom")
        Me.nudOrderFrom.Name = "nudOrderFrom"
        '
        'ucrInputInteractions
        '
        Me.ucrInputInteractions.AddQuotesIfUnrecognised = True
        Me.ucrInputInteractions.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputInteractions, "ucrInputInteractions")
        Me.ucrInputInteractions.Name = "ucrInputInteractions"
        '
        'lblInteractions
        '
        resources.ApplyResources(Me.lblInteractions, "lblInteractions")
        Me.lblInteractions.Name = "lblInteractions"
        '
        'lblAdditionalVariables
        '
        resources.ApplyResources(Me.lblAdditionalVariables, "lblAdditionalVariables")
        Me.lblAdditionalVariables.Name = "lblAdditionalVariables"
        '
        'ucrReceiverAdditionalVariables
        '
        Me.ucrReceiverAdditionalVariables.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverAdditionalVariables, "ucrReceiverAdditionalVariables")
        Me.ucrReceiverAdditionalVariables.Name = "ucrReceiverAdditionalVariables"
        Me.ucrReceiverAdditionalVariables.Selector = Nothing
        Me.ucrReceiverAdditionalVariables.strNcFilePath = ""
        Me.ucrReceiverAdditionalVariables.ucrSelector = Nothing
        '
        'ucrInputOptions
        '
        Me.ucrInputOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputOptions.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputOptions, "ucrInputOptions")
        Me.ucrInputOptions.Name = "ucrInputOptions"
        '
        'lblOptions
        '
        resources.ApplyResources(Me.lblOptions, "lblOptions")
        Me.lblOptions.Name = "lblOptions"
        '
        'chkSaveModel
        '
        resources.ApplyResources(Me.chkSaveModel, "chkSaveModel")
        Me.chkSaveModel.Name = "chkSaveModel"
        Me.chkSaveModel.UseVisualStyleBackColor = True
        '
        'chkGraph
        '
        resources.ApplyResources(Me.chkGraph, "chkGraph")
        Me.chkGraph.Name = "chkGraph"
        Me.chkGraph.UseVisualStyleBackColor = True
        '
        'ucrInputSaveModel
        '
        Me.ucrInputSaveModel.AddQuotesIfUnrecognised = True
        Me.ucrInputSaveModel.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSaveModel, "ucrInputSaveModel")
        Me.ucrInputSaveModel.Name = "ucrInputSaveModel"
        '
        'dlgNewMarkovChains
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputSaveModel)
        Me.Controls.Add(Me.chkGraph)
        Me.Controls.Add(Me.chkSaveModel)
        Me.Controls.Add(Me.lblOptions)
        Me.Controls.Add(Me.ucrInputOptions)
        Me.Controls.Add(Me.ucrReceiverAdditionalVariables)
        Me.Controls.Add(Me.lblAdditionalVariables)
        Me.Controls.Add(Me.ucrInputInteractions)
        Me.Controls.Add(Me.lblInteractions)
        Me.Controls.Add(Me.grpOrder)
        Me.Controls.Add(Me.grpSeasonalityHarmonics)
        Me.Controls.Add(Me.lblExcludeSep)
        Me.Controls.Add(Me.ucrInputExcludeSep)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverDOY)
        Me.Controls.Add(Me.ucrReceiverRainfall)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.lblDOY)
        Me.Controls.Add(Me.lblRainfall)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrSelectorMarkovChains)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgNewMarkovChains"
        Me.grpSeasonalityHarmonics.ResumeLayout(False)
        Me.grpSeasonalityHarmonics.PerformLayout()
        CType(Me.nudSeasonalityTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSeasonalityFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOrder.ResumeLayout(False)
        Me.grpOrder.PerformLayout()
        CType(Me.nudOrderTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudOrderFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorMarkovChains As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblStation As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblRainfall As Label
    Friend WithEvents lblDOY As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents ucrReceiverRainfall As ucrReceiverSingle
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrInputExcludeSep As ucrInputComboBox
    Friend WithEvents lblExcludeSep As Label
    Friend WithEvents grpSeasonalityHarmonics As GroupBox
    Friend WithEvents grpOrder As GroupBox
    Friend WithEvents lblSeasonalityTo As Label
    Friend WithEvents lblSeasonalityFrom As Label
    Friend WithEvents nudSeasonalityTo As NumericUpDown
    Friend WithEvents nudSeasonalityFrom As NumericUpDown
    Friend WithEvents lblOrderTo As Label
    Friend WithEvents lblOrderFrom As Label
    Friend WithEvents nudOrderTo As NumericUpDown
    Friend WithEvents nudOrderFrom As NumericUpDown
    Friend WithEvents ucrInputMarkovType As ucrInputComboBox
    Friend WithEvents lblMarkovType As Label
    Friend WithEvents ucrInputInteractions As ucrInputComboBox
    Friend WithEvents lblInteractions As Label
    Friend WithEvents lblAdditionalVariables As Label
    Friend WithEvents ucrReceiverAdditionalVariables As ucrReceiverMultiple
    Friend WithEvents ucrInputOptions As ucrInputComboBox
    Friend WithEvents lblOptions As Label
    Friend WithEvents chkSaveModel As CheckBox
    Friend WithEvents chkGraph As CheckBox
    Friend WithEvents ucrInputSaveModel As ucrInputComboBox
End Class
