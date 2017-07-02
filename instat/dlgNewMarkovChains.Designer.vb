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
        Me.ucrBase.Location = New System.Drawing.Point(12, 437)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorMarkovChains
        '
        Me.ucrSelectorMarkovChains.bShowHiddenColumns = False
        Me.ucrSelectorMarkovChains.bUseCurrentFilter = True
        Me.ucrSelectorMarkovChains.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorMarkovChains.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorMarkovChains.Name = "ucrSelectorMarkovChains"
        Me.ucrSelectorMarkovChains.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorMarkovChains.TabIndex = 1
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(226, 13)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 2
        Me.lblStation.Text = "Station:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(226, 59)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date"
        '
        'lblRainfall
        '
        Me.lblRainfall.AutoSize = True
        Me.lblRainfall.Location = New System.Drawing.Point(226, 149)
        Me.lblRainfall.Name = "lblRainfall"
        Me.lblRainfall.Size = New System.Drawing.Size(42, 13)
        Me.lblRainfall.TabIndex = 4
        Me.lblRainfall.Text = "Rainfall"
        '
        'lblDOY
        '
        Me.lblDOY.AutoSize = True
        Me.lblDOY.Location = New System.Drawing.Point(226, 105)
        Me.lblDOY.Name = "lblDOY"
        Me.lblDOY.Size = New System.Drawing.Size(63, 13)
        Me.lblDOY.TabIndex = 5
        Me.lblDOY.Text = "Day of Year"
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.Location = New System.Drawing.Point(227, 30)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.TabIndex = 6
        '
        'ucrReceiverRainfall
        '
        Me.ucrReceiverRainfall.Location = New System.Drawing.Point(229, 162)
        Me.ucrReceiverRainfall.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRainfall.Name = "ucrReceiverRainfall"
        Me.ucrReceiverRainfall.Selector = Nothing
        Me.ucrReceiverRainfall.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRainfall.TabIndex = 7
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(229, 118)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDOY.TabIndex = 8
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.Location = New System.Drawing.Point(227, 72)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.TabIndex = 9
        '
        'ucrInputExcludeSep
        '
        Me.ucrInputExcludeSep.IsReadOnly = False
        Me.ucrInputExcludeSep.Location = New System.Drawing.Point(351, 28)
        Me.ucrInputExcludeSep.Name = "ucrInputExcludeSep"
        Me.ucrInputExcludeSep.Size = New System.Drawing.Size(108, 21)
        Me.ucrInputExcludeSep.TabIndex = 10
        '
        'lblExcludeSep
        '
        Me.lblExcludeSep.AutoSize = True
        Me.lblExcludeSep.Location = New System.Drawing.Point(351, 12)
        Me.lblExcludeSep.Name = "lblExcludeSep"
        Me.lblExcludeSep.Size = New System.Drawing.Size(96, 13)
        Me.lblExcludeSep.TabIndex = 11
        Me.lblExcludeSep.Text = "Exclude/Separate:"
        '
        'grpSeasonalityHarmonics
        '
        Me.grpSeasonalityHarmonics.Controls.Add(Me.lblSeasonalityTo)
        Me.grpSeasonalityHarmonics.Controls.Add(Me.lblSeasonalityFrom)
        Me.grpSeasonalityHarmonics.Controls.Add(Me.nudSeasonalityTo)
        Me.grpSeasonalityHarmonics.Controls.Add(Me.nudSeasonalityFrom)
        Me.grpSeasonalityHarmonics.Location = New System.Drawing.Point(13, 197)
        Me.grpSeasonalityHarmonics.Name = "grpSeasonalityHarmonics"
        Me.grpSeasonalityHarmonics.Size = New System.Drawing.Size(200, 99)
        Me.grpSeasonalityHarmonics.TabIndex = 12
        Me.grpSeasonalityHarmonics.TabStop = False
        Me.grpSeasonalityHarmonics.Text = "Seasonality (Harmonics)"
        '
        'lblSeasonalityTo
        '
        Me.lblSeasonalityTo.AutoSize = True
        Me.lblSeasonalityTo.Location = New System.Drawing.Point(7, 52)
        Me.lblSeasonalityTo.Name = "lblSeasonalityTo"
        Me.lblSeasonalityTo.Size = New System.Drawing.Size(23, 13)
        Me.lblSeasonalityTo.TabIndex = 3
        Me.lblSeasonalityTo.Text = "To:"
        '
        'lblSeasonalityFrom
        '
        Me.lblSeasonalityFrom.AutoSize = True
        Me.lblSeasonalityFrom.Location = New System.Drawing.Point(7, 25)
        Me.lblSeasonalityFrom.Name = "lblSeasonalityFrom"
        Me.lblSeasonalityFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblSeasonalityFrom.TabIndex = 2
        Me.lblSeasonalityFrom.Text = "From:"
        '
        'nudSeasonalityTo
        '
        Me.nudSeasonalityTo.Location = New System.Drawing.Point(115, 45)
        Me.nudSeasonalityTo.Name = "nudSeasonalityTo"
        Me.nudSeasonalityTo.Size = New System.Drawing.Size(48, 20)
        Me.nudSeasonalityTo.TabIndex = 1
        '
        'nudSeasonalityFrom
        '
        Me.nudSeasonalityFrom.Location = New System.Drawing.Point(115, 19)
        Me.nudSeasonalityFrom.Name = "nudSeasonalityFrom"
        Me.nudSeasonalityFrom.Size = New System.Drawing.Size(48, 20)
        Me.nudSeasonalityFrom.TabIndex = 0
        '
        'grpOrder
        '
        Me.grpOrder.Controls.Add(Me.ucrInputMarkovType)
        Me.grpOrder.Controls.Add(Me.lblMarkovType)
        Me.grpOrder.Controls.Add(Me.lblOrderTo)
        Me.grpOrder.Controls.Add(Me.lblOrderFrom)
        Me.grpOrder.Controls.Add(Me.nudOrderTo)
        Me.grpOrder.Controls.Add(Me.nudOrderFrom)
        Me.grpOrder.Location = New System.Drawing.Point(219, 197)
        Me.grpOrder.Name = "grpOrder"
        Me.grpOrder.Size = New System.Drawing.Size(200, 99)
        Me.grpOrder.TabIndex = 13
        Me.grpOrder.TabStop = False
        Me.grpOrder.Text = "Order"
        '
        'ucrInputMarkovType
        '
        Me.ucrInputMarkovType.IsReadOnly = False
        Me.ucrInputMarkovType.Location = New System.Drawing.Point(84, 71)
        Me.ucrInputMarkovType.Name = "ucrInputMarkovType"
        Me.ucrInputMarkovType.Size = New System.Drawing.Size(96, 21)
        Me.ucrInputMarkovType.TabIndex = 6
        '
        'lblMarkovType
        '
        Me.lblMarkovType.AutoSize = True
        Me.lblMarkovType.Location = New System.Drawing.Point(5, 74)
        Me.lblMarkovType.Name = "lblMarkovType"
        Me.lblMarkovType.Size = New System.Drawing.Size(73, 13)
        Me.lblMarkovType.TabIndex = 5
        Me.lblMarkovType.Text = "Markov Type:"
        '
        'lblOrderTo
        '
        Me.lblOrderTo.AutoSize = True
        Me.lblOrderTo.Location = New System.Drawing.Point(5, 47)
        Me.lblOrderTo.Name = "lblOrderTo"
        Me.lblOrderTo.Size = New System.Drawing.Size(23, 13)
        Me.lblOrderTo.TabIndex = 4
        Me.lblOrderTo.Text = "To:"
        '
        'lblOrderFrom
        '
        Me.lblOrderFrom.AutoSize = True
        Me.lblOrderFrom.Location = New System.Drawing.Point(7, 26)
        Me.lblOrderFrom.Name = "lblOrderFrom"
        Me.lblOrderFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblOrderFrom.TabIndex = 3
        Me.lblOrderFrom.Text = "From:"
        '
        'nudOrderTo
        '
        Me.nudOrderTo.Location = New System.Drawing.Point(132, 45)
        Me.nudOrderTo.Name = "nudOrderTo"
        Me.nudOrderTo.Size = New System.Drawing.Size(48, 20)
        Me.nudOrderTo.TabIndex = 2
        '
        'nudOrderFrom
        '
        Me.nudOrderFrom.Location = New System.Drawing.Point(132, 19)
        Me.nudOrderFrom.Name = "nudOrderFrom"
        Me.nudOrderFrom.Size = New System.Drawing.Size(48, 20)
        Me.nudOrderFrom.TabIndex = 1
        '
        'ucrInputInteractions
        '
        Me.ucrInputInteractions.IsReadOnly = False
        Me.ucrInputInteractions.Location = New System.Drawing.Point(91, 299)
        Me.ucrInputInteractions.Name = "ucrInputInteractions"
        Me.ucrInputInteractions.Size = New System.Drawing.Size(67, 21)
        Me.ucrInputInteractions.TabIndex = 15
        '
        'lblInteractions
        '
        Me.lblInteractions.AutoSize = True
        Me.lblInteractions.Location = New System.Drawing.Point(12, 304)
        Me.lblInteractions.Name = "lblInteractions"
        Me.lblInteractions.Size = New System.Drawing.Size(65, 13)
        Me.lblInteractions.TabIndex = 14
        Me.lblInteractions.Text = "Interactions:"
        '
        'lblAdditionalVariables
        '
        Me.lblAdditionalVariables.AutoSize = True
        Me.lblAdditionalVariables.Location = New System.Drawing.Point(164, 299)
        Me.lblAdditionalVariables.Name = "lblAdditionalVariables"
        Me.lblAdditionalVariables.Size = New System.Drawing.Size(102, 13)
        Me.lblAdditionalVariables.TabIndex = 16
        Me.lblAdditionalVariables.Text = "Additional Variables:"
        '
        'ucrReceiverAdditionalVariables
        '
        Me.ucrReceiverAdditionalVariables.Location = New System.Drawing.Point(167, 316)
        Me.ucrReceiverAdditionalVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAdditionalVariables.Name = "ucrReceiverAdditionalVariables"
        Me.ucrReceiverAdditionalVariables.Selector = Nothing
        Me.ucrReceiverAdditionalVariables.Size = New System.Drawing.Size(120, 65)
        Me.ucrReceiverAdditionalVariables.TabIndex = 17
        '
        'ucrInputOptions
        '
        Me.ucrInputOptions.IsReadOnly = False
        Me.ucrInputOptions.Location = New System.Drawing.Point(303, 316)
        Me.ucrInputOptions.Name = "ucrInputOptions"
        Me.ucrInputOptions.Size = New System.Drawing.Size(116, 21)
        Me.ucrInputOptions.TabIndex = 18
        '
        'lblOptions
        '
        Me.lblOptions.AutoSize = True
        Me.lblOptions.Location = New System.Drawing.Point(300, 299)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(46, 13)
        Me.lblOptions.TabIndex = 19
        Me.lblOptions.Text = "Options:"
        '
        'chkSaveModel
        '
        Me.chkSaveModel.AutoSize = True
        Me.chkSaveModel.Location = New System.Drawing.Point(13, 391)
        Me.chkSaveModel.Name = "chkSaveModel"
        Me.chkSaveModel.Size = New System.Drawing.Size(83, 17)
        Me.chkSaveModel.TabIndex = 20
        Me.chkSaveModel.Text = "Save Model"
        Me.chkSaveModel.UseVisualStyleBackColor = True
        '
        'chkGraph
        '
        Me.chkGraph.AutoSize = True
        Me.chkGraph.Location = New System.Drawing.Point(13, 414)
        Me.chkGraph.Name = "chkGraph"
        Me.chkGraph.Size = New System.Drawing.Size(93, 17)
        Me.chkGraph.TabIndex = 21
        Me.chkGraph.Text = "Include Graph"
        Me.chkGraph.UseVisualStyleBackColor = True
        '
        'ucrInputSaveModel
        '
        Me.ucrInputSaveModel.IsReadOnly = False
        Me.ucrInputSaveModel.Location = New System.Drawing.Point(103, 391)
        Me.ucrInputSaveModel.Name = "ucrInputSaveModel"
        Me.ucrInputSaveModel.Size = New System.Drawing.Size(184, 21)
        Me.ucrInputSaveModel.TabIndex = 22
        '
        'dlgNewMarkovChains
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 492)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Markov Chains"
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
