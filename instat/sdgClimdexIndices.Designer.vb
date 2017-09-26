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
Partial Class sdgClimdexIndices
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
        Me.ttClimdexIndices = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.tbpPrecipitation = New System.Windows.Forms.TabPage()
        Me.grpPrecAnnual = New System.Windows.Forms.GroupBox()
        Me.ucrInputThreshold = New instat.ucrInputTextBox()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.ucrChkPrecExceedSpecifiedA = New instat.ucrCheck()
        Me.ucrChkMaxDrySpell = New instat.ucrCheck()
        Me.ucrChkPrecExceed95Percent = New instat.ucrCheck()
        Me.ucrChkPrecExceed10mm = New instat.ucrCheck()
        Me.ucrChkMaxWetSpell = New instat.ucrCheck()
        Me.ucrChkPrecExceed20mm = New instat.ucrCheck()
        Me.ucrChkPrecExceed99Percent = New instat.ucrCheck()
        Me.ucrChkTotalDailyPrec = New instat.ucrCheck()
        Me.ucrChkSimplePrecII = New instat.ucrCheck()
        Me.grpPrecAnnualMonthly = New System.Windows.Forms.GroupBox()
        Me.ucrChkCentreMean = New instat.ucrCheck()
        Me.ucrChkMonthlyMax5dayPrec = New instat.ucrCheck()
        Me.ucrChkMonthlyMax1dayPrec = New instat.ucrCheck()
        Me.tbpTemperature = New System.Windows.Forms.TabPage()
        Me.grpTmin = New System.Windows.Forms.GroupBox()
        Me.grpTminAnnualMonthly = New System.Windows.Forms.GroupBox()
        Me.ucrChkMonthlyMinDailyTMin = New instat.ucrCheck()
        Me.ucrChkMonthlyMaxDailyTMin = New instat.ucrCheck()
        Me.ucrChkTminBelow10Percent = New instat.ucrCheck()
        Me.ucrChkTminAbove90Percent = New instat.ucrCheck()
        Me.grpTminAnnual = New System.Windows.Forms.GroupBox()
        Me.ucrChkColdSpellDI = New instat.ucrCheck()
        Me.ucrChkTropicalNights = New instat.ucrCheck()
        Me.ucrChkFrostDays = New instat.ucrCheck()
        Me.grpTmaxTmin = New System.Windows.Forms.GroupBox()
        Me.grpTmaxTminAnnualMonthly = New System.Windows.Forms.GroupBox()
        Me.ucrChkMeanDiurnalTempRange = New instat.ucrCheck()
        Me.grpTmaxTminAnnual = New System.Windows.Forms.GroupBox()
        Me.lblGSLMode = New System.Windows.Forms.Label()
        Me.ucrChkGrowingSeasonLength = New instat.ucrCheck()
        Me.ucrInputGSLMode = New instat.ucrInputComboBox()
        Me.grpTmax = New System.Windows.Forms.GroupBox()
        Me.grpTmaxAnnualMonthly = New System.Windows.Forms.GroupBox()
        Me.ucrChkMonthlyMaxDailyTMax = New instat.ucrCheck()
        Me.ucrChkTmaxAbove90Percent = New instat.ucrCheck()
        Me.ucrChkTmaxBelow10Percent = New instat.ucrCheck()
        Me.ucrChkMonthlyMinDailyTMax = New instat.ucrCheck()
        Me.grpTmaxAnnual = New System.Windows.Forms.GroupBox()
        Me.ucrChkSummerDays = New instat.ucrCheck()
        Me.ucrChkWarmSpellDI = New instat.ucrCheck()
        Me.ucrChkIcingDays = New instat.ucrCheck()
        Me.tbpSettings = New System.Windows.Forms.TabPage()
        Me.ucrInputPrecQtiles = New instat.ucrInputTextBox()
        Me.ucrInputTempQtiles = New instat.ucrInputTextBox()
        Me.grpBaseRange = New System.Windows.Forms.GroupBox()
        Me.lblBaseTo = New System.Windows.Forms.Label()
        Me.ucrNudUpperBase = New instat.ucrNud()
        Me.lblBaseFrom = New System.Windows.Forms.Label()
        Me.ucrNudLowerBase = New instat.ucrNud()
        Me.ucrChkNHemisphere = New instat.ucrCheck()
        Me.ucrChkMaxSpellSpanYears = New instat.ucrCheck()
        Me.ucrNudN = New instat.ucrNud()
        Me.ucrNudMinBaseData = New instat.ucrNud()
        Me.lblFreq = New System.Windows.Forms.Label()
        Me.lblMinBaseData = New System.Windows.Forms.Label()
        Me.ucrInputFreq = New instat.ucrInputComboBox()
        Me.lblPrecQuantiles = New System.Windows.Forms.Label()
        Me.lblTempQuantiles = New System.Windows.Forms.Label()
        Me.grpMaxMissingDays = New System.Windows.Forms.GroupBox()
        Me.lblMonthly = New System.Windows.Forms.Label()
        Me.lblAnnual = New System.Windows.Forms.Label()
        Me.ucrNudMonthlyMissingDays = New instat.ucrNud()
        Me.ucrNudAnnualMissingDays = New instat.ucrNud()
        Me.lblN = New System.Windows.Forms.Label()
        Me.tbpClimdex = New System.Windows.Forms.TabControl()
        Me.ucrButtonsClimdexIndices = New instat.ucrButtonsSubdialogue()
        Me.tbpPrecipitation.SuspendLayout()
        Me.grpPrecAnnual.SuspendLayout()
        Me.grpPrecAnnualMonthly.SuspendLayout()
        Me.tbpTemperature.SuspendLayout()
        Me.grpTmin.SuspendLayout()
        Me.grpTminAnnualMonthly.SuspendLayout()
        Me.grpTminAnnual.SuspendLayout()
        Me.grpTmaxTmin.SuspendLayout()
        Me.grpTmaxTminAnnualMonthly.SuspendLayout()
        Me.grpTmaxTminAnnual.SuspendLayout()
        Me.grpTmax.SuspendLayout()
        Me.grpTmaxAnnualMonthly.SuspendLayout()
        Me.grpTmaxAnnual.SuspendLayout()
        Me.tbpSettings.SuspendLayout()
        Me.grpBaseRange.SuspendLayout()
        Me.grpMaxMissingDays.SuspendLayout()
        Me.tbpClimdex.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(347, 438)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdHelp.TabIndex = 1
        Me.cmdHelp.Text = "Indices Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'tbpPrecipitation
        '
        Me.tbpPrecipitation.Controls.Add(Me.grpPrecAnnual)
        Me.tbpPrecipitation.Controls.Add(Me.grpPrecAnnualMonthly)
        Me.tbpPrecipitation.Location = New System.Drawing.Point(4, 22)
        Me.tbpPrecipitation.Name = "tbpPrecipitation"
        Me.tbpPrecipitation.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpPrecipitation.Size = New System.Drawing.Size(575, 397)
        Me.tbpPrecipitation.TabIndex = 3
        Me.tbpPrecipitation.Text = "Precipitation"
        Me.tbpPrecipitation.UseVisualStyleBackColor = True
        '
        'grpPrecAnnual
        '
        Me.grpPrecAnnual.Controls.Add(Me.ucrInputThreshold)
        Me.grpPrecAnnual.Controls.Add(Me.lblThreshold)
        Me.grpPrecAnnual.Controls.Add(Me.ucrChkPrecExceedSpecifiedA)
        Me.grpPrecAnnual.Controls.Add(Me.ucrChkMaxDrySpell)
        Me.grpPrecAnnual.Controls.Add(Me.ucrChkPrecExceed95Percent)
        Me.grpPrecAnnual.Controls.Add(Me.ucrChkPrecExceed10mm)
        Me.grpPrecAnnual.Controls.Add(Me.ucrChkMaxWetSpell)
        Me.grpPrecAnnual.Controls.Add(Me.ucrChkPrecExceed20mm)
        Me.grpPrecAnnual.Controls.Add(Me.ucrChkPrecExceed99Percent)
        Me.grpPrecAnnual.Controls.Add(Me.ucrChkTotalDailyPrec)
        Me.grpPrecAnnual.Controls.Add(Me.ucrChkSimplePrecII)
        Me.grpPrecAnnual.Location = New System.Drawing.Point(11, 7)
        Me.grpPrecAnnual.Name = "grpPrecAnnual"
        Me.grpPrecAnnual.Size = New System.Drawing.Size(445, 238)
        Me.grpPrecAnnual.TabIndex = 1
        Me.grpPrecAnnual.TabStop = False
        Me.grpPrecAnnual.Text = "Annual"
        '
        'ucrInputThreshold
        '
        Me.ucrInputThreshold.AddQuotesIfUnrecognised = True
        Me.ucrInputThreshold.IsMultiline = False
        Me.ucrInputThreshold.IsReadOnly = False
        Me.ucrInputThreshold.Location = New System.Drawing.Point(371, 88)
        Me.ucrInputThreshold.Name = "ucrInputThreshold"
        Me.ucrInputThreshold.Size = New System.Drawing.Size(68, 21)
        Me.ucrInputThreshold.TabIndex = 12
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(312, 92)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(57, 13)
        Me.lblThreshold.TabIndex = 4
        Me.lblThreshold.Tag = "Threshold:"
        Me.lblThreshold.Text = "Threshold:"
        '
        'ucrChkPrecExceedSpecifiedA
        '
        Me.ucrChkPrecExceedSpecifiedA.Checked = False
        Me.ucrChkPrecExceedSpecifiedA.Location = New System.Drawing.Point(6, 91)
        Me.ucrChkPrecExceedSpecifiedA.Name = "ucrChkPrecExceedSpecifiedA"
        Me.ucrChkPrecExceedSpecifiedA.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkPrecExceedSpecifiedA.TabIndex = 3
        '
        'ucrChkMaxDrySpell
        '
        Me.ucrChkMaxDrySpell.Checked = False
        Me.ucrChkMaxDrySpell.Location = New System.Drawing.Point(6, 115)
        Me.ucrChkMaxDrySpell.Name = "ucrChkMaxDrySpell"
        Me.ucrChkMaxDrySpell.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkMaxDrySpell.TabIndex = 6
        '
        'ucrChkPrecExceed95Percent
        '
        Me.ucrChkPrecExceed95Percent.Checked = False
        Me.ucrChkPrecExceed95Percent.Location = New System.Drawing.Point(6, 163)
        Me.ucrChkPrecExceed95Percent.Name = "ucrChkPrecExceed95Percent"
        Me.ucrChkPrecExceed95Percent.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkPrecExceed95Percent.TabIndex = 8
        '
        'ucrChkPrecExceed10mm
        '
        Me.ucrChkPrecExceed10mm.Checked = False
        Me.ucrChkPrecExceed10mm.Location = New System.Drawing.Point(6, 43)
        Me.ucrChkPrecExceed10mm.Name = "ucrChkPrecExceed10mm"
        Me.ucrChkPrecExceed10mm.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkPrecExceed10mm.TabIndex = 1
        '
        'ucrChkMaxWetSpell
        '
        Me.ucrChkMaxWetSpell.Checked = False
        Me.ucrChkMaxWetSpell.Location = New System.Drawing.Point(6, 139)
        Me.ucrChkMaxWetSpell.Name = "ucrChkMaxWetSpell"
        Me.ucrChkMaxWetSpell.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkMaxWetSpell.TabIndex = 7
        '
        'ucrChkPrecExceed20mm
        '
        Me.ucrChkPrecExceed20mm.Checked = False
        Me.ucrChkPrecExceed20mm.Location = New System.Drawing.Point(6, 67)
        Me.ucrChkPrecExceed20mm.Name = "ucrChkPrecExceed20mm"
        Me.ucrChkPrecExceed20mm.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkPrecExceed20mm.TabIndex = 2
        '
        'ucrChkPrecExceed99Percent
        '
        Me.ucrChkPrecExceed99Percent.Checked = False
        Me.ucrChkPrecExceed99Percent.Location = New System.Drawing.Point(6, 187)
        Me.ucrChkPrecExceed99Percent.Name = "ucrChkPrecExceed99Percent"
        Me.ucrChkPrecExceed99Percent.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkPrecExceed99Percent.TabIndex = 9
        '
        'ucrChkTotalDailyPrec
        '
        Me.ucrChkTotalDailyPrec.Checked = False
        Me.ucrChkTotalDailyPrec.Location = New System.Drawing.Point(6, 211)
        Me.ucrChkTotalDailyPrec.Name = "ucrChkTotalDailyPrec"
        Me.ucrChkTotalDailyPrec.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkTotalDailyPrec.TabIndex = 10
        '
        'ucrChkSimplePrecII
        '
        Me.ucrChkSimplePrecII.Checked = False
        Me.ucrChkSimplePrecII.Location = New System.Drawing.Point(6, 19)
        Me.ucrChkSimplePrecII.Name = "ucrChkSimplePrecII"
        Me.ucrChkSimplePrecII.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkSimplePrecII.TabIndex = 0
        '
        'grpPrecAnnualMonthly
        '
        Me.grpPrecAnnualMonthly.Controls.Add(Me.ucrChkCentreMean)
        Me.grpPrecAnnualMonthly.Controls.Add(Me.ucrChkMonthlyMax5dayPrec)
        Me.grpPrecAnnualMonthly.Controls.Add(Me.ucrChkMonthlyMax1dayPrec)
        Me.grpPrecAnnualMonthly.Location = New System.Drawing.Point(11, 251)
        Me.grpPrecAnnualMonthly.Name = "grpPrecAnnualMonthly"
        Me.grpPrecAnnualMonthly.Size = New System.Drawing.Size(445, 93)
        Me.grpPrecAnnualMonthly.TabIndex = 0
        Me.grpPrecAnnualMonthly.TabStop = False
        Me.grpPrecAnnualMonthly.Text = "Annual/Monthly"
        '
        'ucrChkCentreMean
        '
        Me.ucrChkCentreMean.Checked = False
        Me.ucrChkCentreMean.Location = New System.Drawing.Point(83, 67)
        Me.ucrChkCentreMean.Name = "ucrChkCentreMean"
        Me.ucrChkCentreMean.Size = New System.Drawing.Size(212, 20)
        Me.ucrChkCentreMean.TabIndex = 2
        '
        'ucrChkMonthlyMax5dayPrec
        '
        Me.ucrChkMonthlyMax5dayPrec.Checked = False
        Me.ucrChkMonthlyMax5dayPrec.Location = New System.Drawing.Point(6, 43)
        Me.ucrChkMonthlyMax5dayPrec.Name = "ucrChkMonthlyMax5dayPrec"
        Me.ucrChkMonthlyMax5dayPrec.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkMonthlyMax5dayPrec.TabIndex = 1
        '
        'ucrChkMonthlyMax1dayPrec
        '
        Me.ucrChkMonthlyMax1dayPrec.Checked = False
        Me.ucrChkMonthlyMax1dayPrec.Location = New System.Drawing.Point(6, 19)
        Me.ucrChkMonthlyMax1dayPrec.Name = "ucrChkMonthlyMax1dayPrec"
        Me.ucrChkMonthlyMax1dayPrec.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkMonthlyMax1dayPrec.TabIndex = 0
        '
        'tbpTemperature
        '
        Me.tbpTemperature.Controls.Add(Me.grpTmin)
        Me.tbpTemperature.Controls.Add(Me.grpTmaxTmin)
        Me.tbpTemperature.Controls.Add(Me.grpTmax)
        Me.tbpTemperature.Location = New System.Drawing.Point(4, 22)
        Me.tbpTemperature.Name = "tbpTemperature"
        Me.tbpTemperature.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTemperature.Size = New System.Drawing.Size(575, 397)
        Me.tbpTemperature.TabIndex = 2
        Me.tbpTemperature.Text = "Temperature"
        Me.tbpTemperature.UseVisualStyleBackColor = True
        '
        'grpTmin
        '
        Me.grpTmin.Controls.Add(Me.grpTminAnnualMonthly)
        Me.grpTmin.Controls.Add(Me.grpTminAnnual)
        Me.grpTmin.Location = New System.Drawing.Point(6, 6)
        Me.grpTmin.Name = "grpTmin"
        Me.grpTmin.Size = New System.Drawing.Size(562, 138)
        Me.grpTmin.TabIndex = 0
        Me.grpTmin.TabStop = False
        Me.grpTmin.Text = "Minimum Temperatures"
        '
        'grpTminAnnualMonthly
        '
        Me.grpTminAnnualMonthly.Controls.Add(Me.ucrChkMonthlyMinDailyTMin)
        Me.grpTminAnnualMonthly.Controls.Add(Me.ucrChkMonthlyMaxDailyTMin)
        Me.grpTminAnnualMonthly.Controls.Add(Me.ucrChkTminBelow10Percent)
        Me.grpTminAnnualMonthly.Controls.Add(Me.ucrChkTminAbove90Percent)
        Me.grpTminAnnualMonthly.Location = New System.Drawing.Point(218, 15)
        Me.grpTminAnnualMonthly.Name = "grpTminAnnualMonthly"
        Me.grpTminAnnualMonthly.Size = New System.Drawing.Size(334, 114)
        Me.grpTminAnnualMonthly.TabIndex = 1
        Me.grpTminAnnualMonthly.TabStop = False
        Me.grpTminAnnualMonthly.Text = "Annual/Monthly"
        '
        'ucrChkMonthlyMinDailyTMin
        '
        Me.ucrChkMonthlyMinDailyTMin.Checked = False
        Me.ucrChkMonthlyMinDailyTMin.Location = New System.Drawing.Point(8, 43)
        Me.ucrChkMonthlyMinDailyTMin.Name = "ucrChkMonthlyMinDailyTMin"
        Me.ucrChkMonthlyMinDailyTMin.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkMonthlyMinDailyTMin.TabIndex = 1
        '
        'ucrChkMonthlyMaxDailyTMin
        '
        Me.ucrChkMonthlyMaxDailyTMin.Checked = False
        Me.ucrChkMonthlyMaxDailyTMin.Location = New System.Drawing.Point(8, 19)
        Me.ucrChkMonthlyMaxDailyTMin.Name = "ucrChkMonthlyMaxDailyTMin"
        Me.ucrChkMonthlyMaxDailyTMin.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkMonthlyMaxDailyTMin.TabIndex = 0
        '
        'ucrChkTminBelow10Percent
        '
        Me.ucrChkTminBelow10Percent.Checked = False
        Me.ucrChkTminBelow10Percent.Location = New System.Drawing.Point(8, 67)
        Me.ucrChkTminBelow10Percent.Name = "ucrChkTminBelow10Percent"
        Me.ucrChkTminBelow10Percent.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkTminBelow10Percent.TabIndex = 2
        '
        'ucrChkTminAbove90Percent
        '
        Me.ucrChkTminAbove90Percent.Checked = False
        Me.ucrChkTminAbove90Percent.Location = New System.Drawing.Point(8, 91)
        Me.ucrChkTminAbove90Percent.Name = "ucrChkTminAbove90Percent"
        Me.ucrChkTminAbove90Percent.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkTminAbove90Percent.TabIndex = 3
        '
        'grpTminAnnual
        '
        Me.grpTminAnnual.Controls.Add(Me.ucrChkColdSpellDI)
        Me.grpTminAnnual.Controls.Add(Me.ucrChkTropicalNights)
        Me.grpTminAnnual.Controls.Add(Me.ucrChkFrostDays)
        Me.grpTminAnnual.Location = New System.Drawing.Point(4, 15)
        Me.grpTminAnnual.Name = "grpTminAnnual"
        Me.grpTminAnnual.Size = New System.Drawing.Size(208, 114)
        Me.grpTminAnnual.TabIndex = 0
        Me.grpTminAnnual.TabStop = False
        Me.grpTminAnnual.Text = "Annual"
        '
        'ucrChkColdSpellDI
        '
        Me.ucrChkColdSpellDI.Checked = False
        Me.ucrChkColdSpellDI.Location = New System.Drawing.Point(8, 67)
        Me.ucrChkColdSpellDI.Name = "ucrChkColdSpellDI"
        Me.ucrChkColdSpellDI.Size = New System.Drawing.Size(200, 18)
        Me.ucrChkColdSpellDI.TabIndex = 2
        '
        'ucrChkTropicalNights
        '
        Me.ucrChkTropicalNights.Checked = False
        Me.ucrChkTropicalNights.Location = New System.Drawing.Point(8, 43)
        Me.ucrChkTropicalNights.Name = "ucrChkTropicalNights"
        Me.ucrChkTropicalNights.Size = New System.Drawing.Size(150, 18)
        Me.ucrChkTropicalNights.TabIndex = 1
        '
        'ucrChkFrostDays
        '
        Me.ucrChkFrostDays.Checked = False
        Me.ucrChkFrostDays.Location = New System.Drawing.Point(8, 19)
        Me.ucrChkFrostDays.Name = "ucrChkFrostDays"
        Me.ucrChkFrostDays.Size = New System.Drawing.Size(150, 18)
        Me.ucrChkFrostDays.TabIndex = 0
        '
        'grpTmaxTmin
        '
        Me.grpTmaxTmin.Controls.Add(Me.grpTmaxTminAnnualMonthly)
        Me.grpTmaxTmin.Controls.Add(Me.grpTmaxTminAnnual)
        Me.grpTmaxTmin.Location = New System.Drawing.Point(6, 297)
        Me.grpTmaxTmin.Name = "grpTmaxTmin"
        Me.grpTmaxTmin.Size = New System.Drawing.Size(562, 94)
        Me.grpTmaxTmin.TabIndex = 2
        Me.grpTmaxTmin.TabStop = False
        Me.grpTmaxTmin.Text = "Tmax/Tmin"
        '
        'grpTmaxTminAnnualMonthly
        '
        Me.grpTmaxTminAnnualMonthly.Controls.Add(Me.ucrChkMeanDiurnalTempRange)
        Me.grpTmaxTminAnnualMonthly.Location = New System.Drawing.Point(218, 14)
        Me.grpTmaxTminAnnualMonthly.Name = "grpTmaxTminAnnualMonthly"
        Me.grpTmaxTminAnnualMonthly.Size = New System.Drawing.Size(334, 74)
        Me.grpTmaxTminAnnualMonthly.TabIndex = 1
        Me.grpTmaxTminAnnualMonthly.TabStop = False
        Me.grpTmaxTminAnnualMonthly.Text = "Annual/Monthly"
        '
        'ucrChkMeanDiurnalTempRange
        '
        Me.ucrChkMeanDiurnalTempRange.Checked = False
        Me.ucrChkMeanDiurnalTempRange.Location = New System.Drawing.Point(8, 21)
        Me.ucrChkMeanDiurnalTempRange.Name = "ucrChkMeanDiurnalTempRange"
        Me.ucrChkMeanDiurnalTempRange.Size = New System.Drawing.Size(320, 18)
        Me.ucrChkMeanDiurnalTempRange.TabIndex = 0
        '
        'grpTmaxTminAnnual
        '
        Me.grpTmaxTminAnnual.Controls.Add(Me.lblGSLMode)
        Me.grpTmaxTminAnnual.Controls.Add(Me.ucrChkGrowingSeasonLength)
        Me.grpTmaxTminAnnual.Controls.Add(Me.ucrInputGSLMode)
        Me.grpTmaxTminAnnual.Location = New System.Drawing.Point(4, 14)
        Me.grpTmaxTminAnnual.Name = "grpTmaxTminAnnual"
        Me.grpTmaxTminAnnual.Size = New System.Drawing.Size(208, 74)
        Me.grpTmaxTminAnnual.TabIndex = 0
        Me.grpTmaxTminAnnual.TabStop = False
        Me.grpTmaxTminAnnual.Text = "Annual"
        '
        'lblGSLMode
        '
        Me.lblGSLMode.AutoSize = True
        Me.lblGSLMode.Location = New System.Drawing.Point(8, 48)
        Me.lblGSLMode.Name = "lblGSLMode"
        Me.lblGSLMode.Size = New System.Drawing.Size(61, 13)
        Me.lblGSLMode.TabIndex = 1
        Me.lblGSLMode.Tag = ""
        Me.lblGSLMode.Text = "GSL Mode:"
        '
        'ucrChkGrowingSeasonLength
        '
        Me.ucrChkGrowingSeasonLength.Checked = False
        Me.ucrChkGrowingSeasonLength.Location = New System.Drawing.Point(8, 21)
        Me.ucrChkGrowingSeasonLength.Name = "ucrChkGrowingSeasonLength"
        Me.ucrChkGrowingSeasonLength.Size = New System.Drawing.Size(194, 18)
        Me.ucrChkGrowingSeasonLength.TabIndex = 0
        '
        'ucrInputGSLMode
        '
        Me.ucrInputGSLMode.AddQuotesIfUnrecognised = True
        Me.ucrInputGSLMode.IsReadOnly = False
        Me.ucrInputGSLMode.Location = New System.Drawing.Point(69, 45)
        Me.ucrInputGSLMode.Margin = New System.Windows.Forms.Padding(21, 17, 21, 17)
        Me.ucrInputGSLMode.Name = "ucrInputGSLMode"
        Me.ucrInputGSLMode.Size = New System.Drawing.Size(133, 21)
        Me.ucrInputGSLMode.TabIndex = 2
        '
        'grpTmax
        '
        Me.grpTmax.Controls.Add(Me.grpTmaxAnnualMonthly)
        Me.grpTmax.Controls.Add(Me.grpTmaxAnnual)
        Me.grpTmax.Location = New System.Drawing.Point(6, 150)
        Me.grpTmax.Name = "grpTmax"
        Me.grpTmax.Size = New System.Drawing.Size(562, 141)
        Me.grpTmax.TabIndex = 1
        Me.grpTmax.TabStop = False
        Me.grpTmax.Text = "Maximum Temperatures"
        '
        'grpTmaxAnnualMonthly
        '
        Me.grpTmaxAnnualMonthly.Controls.Add(Me.ucrChkMonthlyMaxDailyTMax)
        Me.grpTmaxAnnualMonthly.Controls.Add(Me.ucrChkTmaxAbove90Percent)
        Me.grpTmaxAnnualMonthly.Controls.Add(Me.ucrChkTmaxBelow10Percent)
        Me.grpTmaxAnnualMonthly.Controls.Add(Me.ucrChkMonthlyMinDailyTMax)
        Me.grpTmaxAnnualMonthly.Location = New System.Drawing.Point(218, 16)
        Me.grpTmaxAnnualMonthly.Name = "grpTmaxAnnualMonthly"
        Me.grpTmaxAnnualMonthly.Size = New System.Drawing.Size(334, 114)
        Me.grpTmaxAnnualMonthly.TabIndex = 1
        Me.grpTmaxAnnualMonthly.TabStop = False
        Me.grpTmaxAnnualMonthly.Text = "Annual/Monthly"
        '
        'ucrChkMonthlyMaxDailyTMax
        '
        Me.ucrChkMonthlyMaxDailyTMax.Checked = False
        Me.ucrChkMonthlyMaxDailyTMax.Location = New System.Drawing.Point(8, 19)
        Me.ucrChkMonthlyMaxDailyTMax.Name = "ucrChkMonthlyMaxDailyTMax"
        Me.ucrChkMonthlyMaxDailyTMax.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkMonthlyMaxDailyTMax.TabIndex = 0
        '
        'ucrChkTmaxAbove90Percent
        '
        Me.ucrChkTmaxAbove90Percent.Checked = False
        Me.ucrChkTmaxAbove90Percent.Location = New System.Drawing.Point(8, 91)
        Me.ucrChkTmaxAbove90Percent.Name = "ucrChkTmaxAbove90Percent"
        Me.ucrChkTmaxAbove90Percent.Size = New System.Drawing.Size(320, 18)
        Me.ucrChkTmaxAbove90Percent.TabIndex = 3
        '
        'ucrChkTmaxBelow10Percent
        '
        Me.ucrChkTmaxBelow10Percent.Checked = False
        Me.ucrChkTmaxBelow10Percent.Location = New System.Drawing.Point(8, 67)
        Me.ucrChkTmaxBelow10Percent.Name = "ucrChkTmaxBelow10Percent"
        Me.ucrChkTmaxBelow10Percent.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkTmaxBelow10Percent.TabIndex = 2
        '
        'ucrChkMonthlyMinDailyTMax
        '
        Me.ucrChkMonthlyMinDailyTMax.Checked = False
        Me.ucrChkMonthlyMinDailyTMax.Location = New System.Drawing.Point(8, 43)
        Me.ucrChkMonthlyMinDailyTMax.Name = "ucrChkMonthlyMinDailyTMax"
        Me.ucrChkMonthlyMinDailyTMax.Size = New System.Drawing.Size(378, 18)
        Me.ucrChkMonthlyMinDailyTMax.TabIndex = 1
        '
        'grpTmaxAnnual
        '
        Me.grpTmaxAnnual.Controls.Add(Me.ucrChkSummerDays)
        Me.grpTmaxAnnual.Controls.Add(Me.ucrChkWarmSpellDI)
        Me.grpTmaxAnnual.Controls.Add(Me.ucrChkIcingDays)
        Me.grpTmaxAnnual.Location = New System.Drawing.Point(4, 16)
        Me.grpTmaxAnnual.Name = "grpTmaxAnnual"
        Me.grpTmaxAnnual.Size = New System.Drawing.Size(208, 114)
        Me.grpTmaxAnnual.TabIndex = 0
        Me.grpTmaxAnnual.TabStop = False
        Me.grpTmaxAnnual.Text = "Annual"
        '
        'ucrChkSummerDays
        '
        Me.ucrChkSummerDays.Checked = False
        Me.ucrChkSummerDays.Location = New System.Drawing.Point(8, 19)
        Me.ucrChkSummerDays.Name = "ucrChkSummerDays"
        Me.ucrChkSummerDays.Size = New System.Drawing.Size(150, 18)
        Me.ucrChkSummerDays.TabIndex = 0
        '
        'ucrChkWarmSpellDI
        '
        Me.ucrChkWarmSpellDI.Checked = False
        Me.ucrChkWarmSpellDI.Location = New System.Drawing.Point(8, 67)
        Me.ucrChkWarmSpellDI.Name = "ucrChkWarmSpellDI"
        Me.ucrChkWarmSpellDI.Size = New System.Drawing.Size(200, 18)
        Me.ucrChkWarmSpellDI.TabIndex = 2
        '
        'ucrChkIcingDays
        '
        Me.ucrChkIcingDays.Checked = False
        Me.ucrChkIcingDays.Location = New System.Drawing.Point(8, 43)
        Me.ucrChkIcingDays.Name = "ucrChkIcingDays"
        Me.ucrChkIcingDays.Size = New System.Drawing.Size(150, 18)
        Me.ucrChkIcingDays.TabIndex = 1
        '
        'tbpSettings
        '
        Me.tbpSettings.Controls.Add(Me.ucrInputPrecQtiles)
        Me.tbpSettings.Controls.Add(Me.ucrInputTempQtiles)
        Me.tbpSettings.Controls.Add(Me.grpBaseRange)
        Me.tbpSettings.Controls.Add(Me.ucrChkNHemisphere)
        Me.tbpSettings.Controls.Add(Me.ucrChkMaxSpellSpanYears)
        Me.tbpSettings.Controls.Add(Me.ucrNudN)
        Me.tbpSettings.Controls.Add(Me.ucrNudMinBaseData)
        Me.tbpSettings.Controls.Add(Me.lblFreq)
        Me.tbpSettings.Controls.Add(Me.lblMinBaseData)
        Me.tbpSettings.Controls.Add(Me.ucrInputFreq)
        Me.tbpSettings.Controls.Add(Me.lblPrecQuantiles)
        Me.tbpSettings.Controls.Add(Me.lblTempQuantiles)
        Me.tbpSettings.Controls.Add(Me.grpMaxMissingDays)
        Me.tbpSettings.Controls.Add(Me.lblN)
        Me.tbpSettings.Location = New System.Drawing.Point(4, 22)
        Me.tbpSettings.Name = "tbpSettings"
        Me.tbpSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpSettings.Size = New System.Drawing.Size(575, 397)
        Me.tbpSettings.TabIndex = 0
        Me.tbpSettings.Tag = ""
        Me.tbpSettings.Text = "Settings"
        Me.tbpSettings.UseVisualStyleBackColor = True
        '
        'ucrInputPrecQtiles
        '
        Me.ucrInputPrecQtiles.AddQuotesIfUnrecognised = True
        Me.ucrInputPrecQtiles.IsMultiline = False
        Me.ucrInputPrecQtiles.IsReadOnly = False
        Me.ucrInputPrecQtiles.Location = New System.Drawing.Point(236, 104)
        Me.ucrInputPrecQtiles.Name = "ucrInputPrecQtiles"
        Me.ucrInputPrecQtiles.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPrecQtiles.TabIndex = 13
        '
        'ucrInputTempQtiles
        '
        Me.ucrInputTempQtiles.AddQuotesIfUnrecognised = True
        Me.ucrInputTempQtiles.IsMultiline = False
        Me.ucrInputTempQtiles.IsReadOnly = False
        Me.ucrInputTempQtiles.Location = New System.Drawing.Point(236, 57)
        Me.ucrInputTempQtiles.Name = "ucrInputTempQtiles"
        Me.ucrInputTempQtiles.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTempQtiles.TabIndex = 11
        '
        'grpBaseRange
        '
        Me.grpBaseRange.Controls.Add(Me.lblBaseTo)
        Me.grpBaseRange.Controls.Add(Me.ucrNudUpperBase)
        Me.grpBaseRange.Controls.Add(Me.lblBaseFrom)
        Me.grpBaseRange.Controls.Add(Me.ucrNudLowerBase)
        Me.grpBaseRange.Location = New System.Drawing.Point(11, 146)
        Me.grpBaseRange.Name = "grpBaseRange"
        Me.grpBaseRange.Size = New System.Drawing.Size(190, 76)
        Me.grpBaseRange.TabIndex = 4
        Me.grpBaseRange.TabStop = False
        Me.grpBaseRange.Tag = ""
        Me.grpBaseRange.Text = "Base Range"
        '
        'lblBaseTo
        '
        Me.lblBaseTo.AutoSize = True
        Me.lblBaseTo.Location = New System.Drawing.Point(7, 47)
        Me.lblBaseTo.Name = "lblBaseTo"
        Me.lblBaseTo.Size = New System.Drawing.Size(23, 13)
        Me.lblBaseTo.TabIndex = 2
        Me.lblBaseTo.Tag = ""
        Me.lblBaseTo.Text = "To:"
        '
        'ucrNudUpperBase
        '
        Me.ucrNudUpperBase.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperBase.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudUpperBase.Location = New System.Drawing.Point(73, 45)
        Me.ucrNudUpperBase.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudUpperBase.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperBase.Name = "ucrNudUpperBase"
        Me.ucrNudUpperBase.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudUpperBase.TabIndex = 3
        Me.ucrNudUpperBase.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblBaseFrom
        '
        Me.lblBaseFrom.AutoSize = True
        Me.lblBaseFrom.Location = New System.Drawing.Point(7, 23)
        Me.lblBaseFrom.Name = "lblBaseFrom"
        Me.lblBaseFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblBaseFrom.TabIndex = 0
        Me.lblBaseFrom.Tag = ""
        Me.lblBaseFrom.Text = "From:"
        '
        'ucrNudLowerBase
        '
        Me.ucrNudLowerBase.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLowerBase.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLowerBase.Location = New System.Drawing.Point(73, 19)
        Me.ucrNudLowerBase.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLowerBase.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLowerBase.Name = "ucrNudLowerBase"
        Me.ucrNudLowerBase.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLowerBase.TabIndex = 1
        Me.ucrNudLowerBase.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkNHemisphere
        '
        Me.ucrChkNHemisphere.Checked = False
        Me.ucrChkNHemisphere.Location = New System.Drawing.Point(11, 231)
        Me.ucrChkNHemisphere.Name = "ucrChkNHemisphere"
        Me.ucrChkNHemisphere.Size = New System.Drawing.Size(212, 20)
        Me.ucrChkNHemisphere.TabIndex = 5
        '
        'ucrChkMaxSpellSpanYears
        '
        Me.ucrChkMaxSpellSpanYears.Checked = False
        Me.ucrChkMaxSpellSpanYears.Location = New System.Drawing.Point(236, 130)
        Me.ucrChkMaxSpellSpanYears.Name = "ucrChkMaxSpellSpanYears"
        Me.ucrChkMaxSpellSpanYears.Size = New System.Drawing.Size(212, 20)
        Me.ucrChkMaxSpellSpanYears.TabIndex = 14
        '
        'ucrNudN
        '
        Me.ucrNudN.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudN.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudN.Location = New System.Drawing.Point(151, 286)
        Me.ucrNudN.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudN.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudN.Name = "ucrNudN"
        Me.ucrNudN.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudN.TabIndex = 9
        Me.ucrNudN.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMinBaseData
        '
        Me.ucrNudMinBaseData.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinBaseData.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinBaseData.Location = New System.Drawing.Point(151, 260)
        Me.ucrNudMinBaseData.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinBaseData.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinBaseData.Name = "ucrNudMinBaseData"
        Me.ucrNudMinBaseData.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinBaseData.TabIndex = 7
        Me.ucrNudMinBaseData.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblFreq
        '
        Me.lblFreq.AutoSize = True
        Me.lblFreq.Location = New System.Drawing.Point(11, 9)
        Me.lblFreq.Name = "lblFreq"
        Me.lblFreq.Size = New System.Drawing.Size(60, 13)
        Me.lblFreq.TabIndex = 0
        Me.lblFreq.Tag = "Frequency:"
        Me.lblFreq.Text = "Frequency:"
        '
        'lblMinBaseData
        '
        Me.lblMinBaseData.AutoSize = True
        Me.lblMinBaseData.Location = New System.Drawing.Point(8, 264)
        Me.lblMinBaseData.Name = "lblMinBaseData"
        Me.lblMinBaseData.Size = New System.Drawing.Size(143, 13)
        Me.lblMinBaseData.TabIndex = 6
        Me.lblMinBaseData.Tag = "Minimum_Base_Data_ Present"
        Me.lblMinBaseData.Text = "Minimum Base Data Present:"
        '
        'ucrInputFreq
        '
        Me.ucrInputFreq.AddQuotesIfUnrecognised = True
        Me.ucrInputFreq.IsReadOnly = False
        Me.ucrInputFreq.Location = New System.Drawing.Point(11, 24)
        Me.ucrInputFreq.Name = "ucrInputFreq"
        Me.ucrInputFreq.Size = New System.Drawing.Size(145, 21)
        Me.ucrInputFreq.TabIndex = 1
        '
        'lblPrecQuantiles
        '
        Me.lblPrecQuantiles.AutoSize = True
        Me.lblPrecQuantiles.Location = New System.Drawing.Point(236, 89)
        Me.lblPrecQuantiles.Name = "lblPrecQuantiles"
        Me.lblPrecQuantiles.Size = New System.Drawing.Size(115, 13)
        Me.lblPrecQuantiles.TabIndex = 12
        Me.lblPrecQuantiles.Tag = "Precipitation_Quantiles:"
        Me.lblPrecQuantiles.Text = "Precipitation Quantiles:"
        '
        'lblTempQuantiles
        '
        Me.lblTempQuantiles.AutoSize = True
        Me.lblTempQuantiles.Location = New System.Drawing.Point(236, 42)
        Me.lblTempQuantiles.Name = "lblTempQuantiles"
        Me.lblTempQuantiles.Size = New System.Drawing.Size(117, 13)
        Me.lblTempQuantiles.TabIndex = 10
        Me.lblTempQuantiles.Tag = "Temperature_Quantiles:"
        Me.lblTempQuantiles.Text = "Temperature Quantiles:"
        '
        'grpMaxMissingDays
        '
        Me.grpMaxMissingDays.Controls.Add(Me.lblMonthly)
        Me.grpMaxMissingDays.Controls.Add(Me.lblAnnual)
        Me.grpMaxMissingDays.Controls.Add(Me.ucrNudMonthlyMissingDays)
        Me.grpMaxMissingDays.Controls.Add(Me.ucrNudAnnualMissingDays)
        Me.grpMaxMissingDays.Location = New System.Drawing.Point(11, 57)
        Me.grpMaxMissingDays.Name = "grpMaxMissingDays"
        Me.grpMaxMissingDays.Size = New System.Drawing.Size(190, 76)
        Me.grpMaxMissingDays.TabIndex = 3
        Me.grpMaxMissingDays.TabStop = False
        Me.grpMaxMissingDays.Tag = "Maximum_Missing_Days"
        Me.grpMaxMissingDays.Text = "Maximum Missing Days"
        '
        'lblMonthly
        '
        Me.lblMonthly.AutoSize = True
        Me.lblMonthly.Location = New System.Drawing.Point(7, 49)
        Me.lblMonthly.Name = "lblMonthly"
        Me.lblMonthly.Size = New System.Drawing.Size(47, 13)
        Me.lblMonthly.TabIndex = 2
        Me.lblMonthly.Tag = "Monthly:"
        Me.lblMonthly.Text = "Monthly:"
        '
        'lblAnnual
        '
        Me.lblAnnual.AutoSize = True
        Me.lblAnnual.Location = New System.Drawing.Point(7, 24)
        Me.lblAnnual.Name = "lblAnnual"
        Me.lblAnnual.Size = New System.Drawing.Size(43, 13)
        Me.lblAnnual.TabIndex = 0
        Me.lblAnnual.Tag = "Annual:"
        Me.lblAnnual.Text = "Annual:"
        '
        'ucrNudMonthlyMissingDays
        '
        Me.ucrNudMonthlyMissingDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMonthlyMissingDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMonthlyMissingDays.Location = New System.Drawing.Point(73, 46)
        Me.ucrNudMonthlyMissingDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMonthlyMissingDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMonthlyMissingDays.Name = "ucrNudMonthlyMissingDays"
        Me.ucrNudMonthlyMissingDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMonthlyMissingDays.TabIndex = 3
        Me.ucrNudMonthlyMissingDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudAnnualMissingDays
        '
        Me.ucrNudAnnualMissingDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAnnualMissingDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAnnualMissingDays.Location = New System.Drawing.Point(73, 20)
        Me.ucrNudAnnualMissingDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAnnualMissingDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAnnualMissingDays.Name = "ucrNudAnnualMissingDays"
        Me.ucrNudAnnualMissingDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAnnualMissingDays.TabIndex = 1
        Me.ucrNudAnnualMissingDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Location = New System.Drawing.Point(8, 293)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(96, 13)
        Me.lblN.TabIndex = 8
        Me.lblN.Tag = "Days_for_Quantiles:"
        Me.lblN.Text = "Days for Quantiles:"
        '
        'tbpClimdex
        '
        Me.tbpClimdex.Controls.Add(Me.tbpSettings)
        Me.tbpClimdex.Controls.Add(Me.tbpTemperature)
        Me.tbpClimdex.Controls.Add(Me.tbpPrecipitation)
        Me.tbpClimdex.Location = New System.Drawing.Point(8, 6)
        Me.tbpClimdex.Name = "tbpClimdex"
        Me.tbpClimdex.SelectedIndex = 0
        Me.tbpClimdex.Size = New System.Drawing.Size(583, 423)
        Me.tbpClimdex.TabIndex = 1
        '
        'ucrButtonsClimdexIndices
        '
        Me.ucrButtonsClimdexIndices.Location = New System.Drawing.Point(190, 435)
        Me.ucrButtonsClimdexIndices.Name = "ucrButtonsClimdexIndices"
        Me.ucrButtonsClimdexIndices.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsClimdexIndices.TabIndex = 2
        '
        'sdgClimdexIndices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 473)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.tbpClimdex)
        Me.Controls.Add(Me.ucrButtonsClimdexIndices)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgClimdexIndices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Indices"
        Me.Text = "Indices"
        Me.tbpPrecipitation.ResumeLayout(False)
        Me.grpPrecAnnual.ResumeLayout(False)
        Me.grpPrecAnnual.PerformLayout()
        Me.grpPrecAnnualMonthly.ResumeLayout(False)
        Me.tbpTemperature.ResumeLayout(False)
        Me.grpTmin.ResumeLayout(False)
        Me.grpTminAnnualMonthly.ResumeLayout(False)
        Me.grpTminAnnual.ResumeLayout(False)
        Me.grpTmaxTmin.ResumeLayout(False)
        Me.grpTmaxTminAnnualMonthly.ResumeLayout(False)
        Me.grpTmaxTminAnnual.ResumeLayout(False)
        Me.grpTmaxTminAnnual.PerformLayout()
        Me.grpTmax.ResumeLayout(False)
        Me.grpTmaxAnnualMonthly.ResumeLayout(False)
        Me.grpTmaxAnnual.ResumeLayout(False)
        Me.tbpSettings.ResumeLayout(False)
        Me.tbpSettings.PerformLayout()
        Me.grpBaseRange.ResumeLayout(False)
        Me.grpBaseRange.PerformLayout()
        Me.grpMaxMissingDays.ResumeLayout(False)
        Me.grpMaxMissingDays.PerformLayout()
        Me.tbpClimdex.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsClimdexIndices As ucrButtonsSubdialogue
    Friend WithEvents ttClimdexIndices As ToolTip

    Private Sub ucrChkColdSpellDI_Load(sender As Object, e As EventArgs) Handles ucrChkColdSpellDI.Load

    End Sub
    Friend WithEvents cmdHelp As Button
    Friend WithEvents tbpPrecipitation As TabPage
    Friend WithEvents grpPrecAnnual As GroupBox
    Friend WithEvents ucrChkPrecExceedSpecifiedA As ucrCheck
    Friend WithEvents ucrChkMaxDrySpell As ucrCheck
    Friend WithEvents ucrChkPrecExceed95Percent As ucrCheck
    Friend WithEvents ucrChkPrecExceed10mm As ucrCheck
    Friend WithEvents ucrChkMaxWetSpell As ucrCheck
    Friend WithEvents ucrChkPrecExceed20mm As ucrCheck
    Friend WithEvents ucrChkPrecExceed99Percent As ucrCheck
    Friend WithEvents ucrChkTotalDailyPrec As ucrCheck
    Friend WithEvents ucrChkSimplePrecII As ucrCheck
    Friend WithEvents grpPrecAnnualMonthly As GroupBox
    Friend WithEvents ucrChkMonthlyMax5dayPrec As ucrCheck
    Friend WithEvents ucrChkMonthlyMax1dayPrec As ucrCheck
    Friend WithEvents tbpTemperature As TabPage
    Friend WithEvents grpTmaxTmin As GroupBox
    Friend WithEvents grpTmaxTminAnnualMonthly As GroupBox
    Friend WithEvents ucrChkMeanDiurnalTempRange As ucrCheck
    Friend WithEvents grpTmaxTminAnnual As GroupBox
    Friend WithEvents ucrChkGrowingSeasonLength As ucrCheck
    Friend WithEvents grpTmax As GroupBox
    Friend WithEvents grpTmaxAnnualMonthly As GroupBox
    Friend WithEvents ucrChkMonthlyMaxDailyTMax As ucrCheck
    Friend WithEvents ucrChkTmaxAbove90Percent As ucrCheck
    Friend WithEvents ucrChkTmaxBelow10Percent As ucrCheck
    Friend WithEvents ucrChkMonthlyMinDailyTMax As ucrCheck
    Friend WithEvents grpTmaxAnnual As GroupBox
    Friend WithEvents ucrChkSummerDays As ucrCheck
    Friend WithEvents ucrChkWarmSpellDI As ucrCheck
    Friend WithEvents ucrChkIcingDays As ucrCheck
    Friend WithEvents tbpSettings As TabPage
    Friend WithEvents grpBaseRange As GroupBox
    Friend WithEvents lblBaseTo As Label
    Friend WithEvents ucrNudUpperBase As ucrNud
    Friend WithEvents lblBaseFrom As Label
    Friend WithEvents ucrNudLowerBase As ucrNud
    Friend WithEvents ucrChkNHemisphere As ucrCheck
    Friend WithEvents ucrChkMaxSpellSpanYears As ucrCheck
    Friend WithEvents ucrNudN As ucrNud
    Friend WithEvents ucrNudMinBaseData As ucrNud
    Friend WithEvents lblFreq As Label
    Friend WithEvents lblMinBaseData As Label
    Friend WithEvents ucrInputFreq As ucrInputComboBox
    Friend WithEvents lblPrecQuantiles As Label
    Friend WithEvents lblTempQuantiles As Label
    Friend WithEvents grpMaxMissingDays As GroupBox
    Friend WithEvents lblMonthly As Label
    Friend WithEvents lblAnnual As Label
    Friend WithEvents ucrNudMonthlyMissingDays As ucrNud
    Friend WithEvents ucrNudAnnualMissingDays As ucrNud
    Friend WithEvents lblN As Label
    Friend WithEvents tbpClimdex As TabControl
    Friend WithEvents ucrInputTempQtiles As ucrInputTextBox
    Friend WithEvents ucrInputPrecQtiles As ucrInputTextBox
    Friend WithEvents grpTmin As GroupBox
    Friend WithEvents grpTminAnnualMonthly As GroupBox
    Friend WithEvents ucrChkMonthlyMinDailyTMin As ucrCheck
    Friend WithEvents ucrChkMonthlyMaxDailyTMin As ucrCheck
    Friend WithEvents ucrChkTminBelow10Percent As ucrCheck
    Friend WithEvents ucrChkTminAbove90Percent As ucrCheck
    Friend WithEvents grpTminAnnual As GroupBox
    Friend WithEvents ucrChkColdSpellDI As ucrCheck
    Friend WithEvents ucrChkTropicalNights As ucrCheck
    Friend WithEvents ucrChkFrostDays As ucrCheck
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblGSLMode As Label
    Friend WithEvents ucrInputGSLMode As ucrInputComboBox
    Friend WithEvents ucrInputThreshold As ucrInputTextBox
    Friend WithEvents ucrChkCentreMean As ucrCheck
End Class