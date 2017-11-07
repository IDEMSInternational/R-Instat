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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgClimdexIndices))
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
        resources.ApplyResources(Me.cmdHelp, "cmdHelp")
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'tbpPrecipitation
        '
        Me.tbpPrecipitation.Controls.Add(Me.grpPrecAnnual)
        Me.tbpPrecipitation.Controls.Add(Me.grpPrecAnnualMonthly)
        resources.ApplyResources(Me.tbpPrecipitation, "tbpPrecipitation")
        Me.tbpPrecipitation.Name = "tbpPrecipitation"
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
        resources.ApplyResources(Me.grpPrecAnnual, "grpPrecAnnual")
        Me.grpPrecAnnual.Name = "grpPrecAnnual"
        Me.grpPrecAnnual.TabStop = False
        '
        'ucrInputThreshold
        '
        Me.ucrInputThreshold.AddQuotesIfUnrecognised = True
        Me.ucrInputThreshold.IsMultiline = False
        Me.ucrInputThreshold.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputThreshold, "ucrInputThreshold")
        Me.ucrInputThreshold.Name = "ucrInputThreshold"
        '
        'lblThreshold
        '
        resources.ApplyResources(Me.lblThreshold, "lblThreshold")
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Tag = "Threshold:"
        '
        'ucrChkPrecExceedSpecifiedA
        '
        Me.ucrChkPrecExceedSpecifiedA.Checked = False
        resources.ApplyResources(Me.ucrChkPrecExceedSpecifiedA, "ucrChkPrecExceedSpecifiedA")
        Me.ucrChkPrecExceedSpecifiedA.Name = "ucrChkPrecExceedSpecifiedA"
        '
        'ucrChkMaxDrySpell
        '
        Me.ucrChkMaxDrySpell.Checked = False
        resources.ApplyResources(Me.ucrChkMaxDrySpell, "ucrChkMaxDrySpell")
        Me.ucrChkMaxDrySpell.Name = "ucrChkMaxDrySpell"
        '
        'ucrChkPrecExceed95Percent
        '
        Me.ucrChkPrecExceed95Percent.Checked = False
        resources.ApplyResources(Me.ucrChkPrecExceed95Percent, "ucrChkPrecExceed95Percent")
        Me.ucrChkPrecExceed95Percent.Name = "ucrChkPrecExceed95Percent"
        '
        'ucrChkPrecExceed10mm
        '
        Me.ucrChkPrecExceed10mm.Checked = False
        resources.ApplyResources(Me.ucrChkPrecExceed10mm, "ucrChkPrecExceed10mm")
        Me.ucrChkPrecExceed10mm.Name = "ucrChkPrecExceed10mm"
        '
        'ucrChkMaxWetSpell
        '
        Me.ucrChkMaxWetSpell.Checked = False
        resources.ApplyResources(Me.ucrChkMaxWetSpell, "ucrChkMaxWetSpell")
        Me.ucrChkMaxWetSpell.Name = "ucrChkMaxWetSpell"
        '
        'ucrChkPrecExceed20mm
        '
        Me.ucrChkPrecExceed20mm.Checked = False
        resources.ApplyResources(Me.ucrChkPrecExceed20mm, "ucrChkPrecExceed20mm")
        Me.ucrChkPrecExceed20mm.Name = "ucrChkPrecExceed20mm"
        '
        'ucrChkPrecExceed99Percent
        '
        Me.ucrChkPrecExceed99Percent.Checked = False
        resources.ApplyResources(Me.ucrChkPrecExceed99Percent, "ucrChkPrecExceed99Percent")
        Me.ucrChkPrecExceed99Percent.Name = "ucrChkPrecExceed99Percent"
        '
        'ucrChkTotalDailyPrec
        '
        Me.ucrChkTotalDailyPrec.Checked = False
        resources.ApplyResources(Me.ucrChkTotalDailyPrec, "ucrChkTotalDailyPrec")
        Me.ucrChkTotalDailyPrec.Name = "ucrChkTotalDailyPrec"
        '
        'ucrChkSimplePrecII
        '
        Me.ucrChkSimplePrecII.Checked = False
        resources.ApplyResources(Me.ucrChkSimplePrecII, "ucrChkSimplePrecII")
        Me.ucrChkSimplePrecII.Name = "ucrChkSimplePrecII"
        '
        'grpPrecAnnualMonthly
        '
        Me.grpPrecAnnualMonthly.Controls.Add(Me.ucrChkCentreMean)
        Me.grpPrecAnnualMonthly.Controls.Add(Me.ucrChkMonthlyMax5dayPrec)
        Me.grpPrecAnnualMonthly.Controls.Add(Me.ucrChkMonthlyMax1dayPrec)
        resources.ApplyResources(Me.grpPrecAnnualMonthly, "grpPrecAnnualMonthly")
        Me.grpPrecAnnualMonthly.Name = "grpPrecAnnualMonthly"
        Me.grpPrecAnnualMonthly.TabStop = False
        '
        'ucrChkCentreMean
        '
        Me.ucrChkCentreMean.Checked = False
        resources.ApplyResources(Me.ucrChkCentreMean, "ucrChkCentreMean")
        Me.ucrChkCentreMean.Name = "ucrChkCentreMean"
        '
        'ucrChkMonthlyMax5dayPrec
        '
        Me.ucrChkMonthlyMax5dayPrec.Checked = False
        resources.ApplyResources(Me.ucrChkMonthlyMax5dayPrec, "ucrChkMonthlyMax5dayPrec")
        Me.ucrChkMonthlyMax5dayPrec.Name = "ucrChkMonthlyMax5dayPrec"
        '
        'ucrChkMonthlyMax1dayPrec
        '
        Me.ucrChkMonthlyMax1dayPrec.Checked = False
        resources.ApplyResources(Me.ucrChkMonthlyMax1dayPrec, "ucrChkMonthlyMax1dayPrec")
        Me.ucrChkMonthlyMax1dayPrec.Name = "ucrChkMonthlyMax1dayPrec"
        '
        'tbpTemperature
        '
        Me.tbpTemperature.Controls.Add(Me.grpTmin)
        Me.tbpTemperature.Controls.Add(Me.grpTmaxTmin)
        Me.tbpTemperature.Controls.Add(Me.grpTmax)
        resources.ApplyResources(Me.tbpTemperature, "tbpTemperature")
        Me.tbpTemperature.Name = "tbpTemperature"
        Me.tbpTemperature.UseVisualStyleBackColor = True
        '
        'grpTmin
        '
        Me.grpTmin.Controls.Add(Me.grpTminAnnualMonthly)
        Me.grpTmin.Controls.Add(Me.grpTminAnnual)
        resources.ApplyResources(Me.grpTmin, "grpTmin")
        Me.grpTmin.Name = "grpTmin"
        Me.grpTmin.TabStop = False
        '
        'grpTminAnnualMonthly
        '
        Me.grpTminAnnualMonthly.Controls.Add(Me.ucrChkMonthlyMinDailyTMin)
        Me.grpTminAnnualMonthly.Controls.Add(Me.ucrChkMonthlyMaxDailyTMin)
        Me.grpTminAnnualMonthly.Controls.Add(Me.ucrChkTminBelow10Percent)
        Me.grpTminAnnualMonthly.Controls.Add(Me.ucrChkTminAbove90Percent)
        resources.ApplyResources(Me.grpTminAnnualMonthly, "grpTminAnnualMonthly")
        Me.grpTminAnnualMonthly.Name = "grpTminAnnualMonthly"
        Me.grpTminAnnualMonthly.TabStop = False
        '
        'ucrChkMonthlyMinDailyTMin
        '
        Me.ucrChkMonthlyMinDailyTMin.Checked = False
        resources.ApplyResources(Me.ucrChkMonthlyMinDailyTMin, "ucrChkMonthlyMinDailyTMin")
        Me.ucrChkMonthlyMinDailyTMin.Name = "ucrChkMonthlyMinDailyTMin"
        '
        'ucrChkMonthlyMaxDailyTMin
        '
        Me.ucrChkMonthlyMaxDailyTMin.Checked = False
        resources.ApplyResources(Me.ucrChkMonthlyMaxDailyTMin, "ucrChkMonthlyMaxDailyTMin")
        Me.ucrChkMonthlyMaxDailyTMin.Name = "ucrChkMonthlyMaxDailyTMin"
        '
        'ucrChkTminBelow10Percent
        '
        Me.ucrChkTminBelow10Percent.Checked = False
        resources.ApplyResources(Me.ucrChkTminBelow10Percent, "ucrChkTminBelow10Percent")
        Me.ucrChkTminBelow10Percent.Name = "ucrChkTminBelow10Percent"
        '
        'ucrChkTminAbove90Percent
        '
        Me.ucrChkTminAbove90Percent.Checked = False
        resources.ApplyResources(Me.ucrChkTminAbove90Percent, "ucrChkTminAbove90Percent")
        Me.ucrChkTminAbove90Percent.Name = "ucrChkTminAbove90Percent"
        '
        'grpTminAnnual
        '
        Me.grpTminAnnual.Controls.Add(Me.ucrChkColdSpellDI)
        Me.grpTminAnnual.Controls.Add(Me.ucrChkTropicalNights)
        Me.grpTminAnnual.Controls.Add(Me.ucrChkFrostDays)
        resources.ApplyResources(Me.grpTminAnnual, "grpTminAnnual")
        Me.grpTminAnnual.Name = "grpTminAnnual"
        Me.grpTminAnnual.TabStop = False
        '
        'ucrChkColdSpellDI
        '
        Me.ucrChkColdSpellDI.Checked = False
        resources.ApplyResources(Me.ucrChkColdSpellDI, "ucrChkColdSpellDI")
        Me.ucrChkColdSpellDI.Name = "ucrChkColdSpellDI"
        '
        'ucrChkTropicalNights
        '
        Me.ucrChkTropicalNights.Checked = False
        resources.ApplyResources(Me.ucrChkTropicalNights, "ucrChkTropicalNights")
        Me.ucrChkTropicalNights.Name = "ucrChkTropicalNights"
        '
        'ucrChkFrostDays
        '
        Me.ucrChkFrostDays.Checked = False
        resources.ApplyResources(Me.ucrChkFrostDays, "ucrChkFrostDays")
        Me.ucrChkFrostDays.Name = "ucrChkFrostDays"
        '
        'grpTmaxTmin
        '
        Me.grpTmaxTmin.Controls.Add(Me.grpTmaxTminAnnualMonthly)
        Me.grpTmaxTmin.Controls.Add(Me.grpTmaxTminAnnual)
        resources.ApplyResources(Me.grpTmaxTmin, "grpTmaxTmin")
        Me.grpTmaxTmin.Name = "grpTmaxTmin"
        Me.grpTmaxTmin.TabStop = False
        '
        'grpTmaxTminAnnualMonthly
        '
        Me.grpTmaxTminAnnualMonthly.Controls.Add(Me.ucrChkMeanDiurnalTempRange)
        resources.ApplyResources(Me.grpTmaxTminAnnualMonthly, "grpTmaxTminAnnualMonthly")
        Me.grpTmaxTminAnnualMonthly.Name = "grpTmaxTminAnnualMonthly"
        Me.grpTmaxTminAnnualMonthly.TabStop = False
        '
        'ucrChkMeanDiurnalTempRange
        '
        Me.ucrChkMeanDiurnalTempRange.Checked = False
        resources.ApplyResources(Me.ucrChkMeanDiurnalTempRange, "ucrChkMeanDiurnalTempRange")
        Me.ucrChkMeanDiurnalTempRange.Name = "ucrChkMeanDiurnalTempRange"
        '
        'grpTmaxTminAnnual
        '
        Me.grpTmaxTminAnnual.Controls.Add(Me.lblGSLMode)
        Me.grpTmaxTminAnnual.Controls.Add(Me.ucrChkGrowingSeasonLength)
        Me.grpTmaxTminAnnual.Controls.Add(Me.ucrInputGSLMode)
        resources.ApplyResources(Me.grpTmaxTminAnnual, "grpTmaxTminAnnual")
        Me.grpTmaxTminAnnual.Name = "grpTmaxTminAnnual"
        Me.grpTmaxTminAnnual.TabStop = False
        '
        'lblGSLMode
        '
        resources.ApplyResources(Me.lblGSLMode, "lblGSLMode")
        Me.lblGSLMode.Name = "lblGSLMode"
        Me.lblGSLMode.Tag = ""
        '
        'ucrChkGrowingSeasonLength
        '
        Me.ucrChkGrowingSeasonLength.Checked = False
        resources.ApplyResources(Me.ucrChkGrowingSeasonLength, "ucrChkGrowingSeasonLength")
        Me.ucrChkGrowingSeasonLength.Name = "ucrChkGrowingSeasonLength"
        '
        'ucrInputGSLMode
        '
        Me.ucrInputGSLMode.AddQuotesIfUnrecognised = True
        Me.ucrInputGSLMode.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGSLMode, "ucrInputGSLMode")
        Me.ucrInputGSLMode.Name = "ucrInputGSLMode"
        '
        'grpTmax
        '
        Me.grpTmax.Controls.Add(Me.grpTmaxAnnualMonthly)
        Me.grpTmax.Controls.Add(Me.grpTmaxAnnual)
        resources.ApplyResources(Me.grpTmax, "grpTmax")
        Me.grpTmax.Name = "grpTmax"
        Me.grpTmax.TabStop = False
        '
        'grpTmaxAnnualMonthly
        '
        Me.grpTmaxAnnualMonthly.Controls.Add(Me.ucrChkMonthlyMaxDailyTMax)
        Me.grpTmaxAnnualMonthly.Controls.Add(Me.ucrChkTmaxAbove90Percent)
        Me.grpTmaxAnnualMonthly.Controls.Add(Me.ucrChkTmaxBelow10Percent)
        Me.grpTmaxAnnualMonthly.Controls.Add(Me.ucrChkMonthlyMinDailyTMax)
        resources.ApplyResources(Me.grpTmaxAnnualMonthly, "grpTmaxAnnualMonthly")
        Me.grpTmaxAnnualMonthly.Name = "grpTmaxAnnualMonthly"
        Me.grpTmaxAnnualMonthly.TabStop = False
        '
        'ucrChkMonthlyMaxDailyTMax
        '
        Me.ucrChkMonthlyMaxDailyTMax.Checked = False
        resources.ApplyResources(Me.ucrChkMonthlyMaxDailyTMax, "ucrChkMonthlyMaxDailyTMax")
        Me.ucrChkMonthlyMaxDailyTMax.Name = "ucrChkMonthlyMaxDailyTMax"
        '
        'ucrChkTmaxAbove90Percent
        '
        Me.ucrChkTmaxAbove90Percent.Checked = False
        resources.ApplyResources(Me.ucrChkTmaxAbove90Percent, "ucrChkTmaxAbove90Percent")
        Me.ucrChkTmaxAbove90Percent.Name = "ucrChkTmaxAbove90Percent"
        '
        'ucrChkTmaxBelow10Percent
        '
        Me.ucrChkTmaxBelow10Percent.Checked = False
        resources.ApplyResources(Me.ucrChkTmaxBelow10Percent, "ucrChkTmaxBelow10Percent")
        Me.ucrChkTmaxBelow10Percent.Name = "ucrChkTmaxBelow10Percent"
        '
        'ucrChkMonthlyMinDailyTMax
        '
        Me.ucrChkMonthlyMinDailyTMax.Checked = False
        resources.ApplyResources(Me.ucrChkMonthlyMinDailyTMax, "ucrChkMonthlyMinDailyTMax")
        Me.ucrChkMonthlyMinDailyTMax.Name = "ucrChkMonthlyMinDailyTMax"
        '
        'grpTmaxAnnual
        '
        Me.grpTmaxAnnual.Controls.Add(Me.ucrChkSummerDays)
        Me.grpTmaxAnnual.Controls.Add(Me.ucrChkWarmSpellDI)
        Me.grpTmaxAnnual.Controls.Add(Me.ucrChkIcingDays)
        resources.ApplyResources(Me.grpTmaxAnnual, "grpTmaxAnnual")
        Me.grpTmaxAnnual.Name = "grpTmaxAnnual"
        Me.grpTmaxAnnual.TabStop = False
        '
        'ucrChkSummerDays
        '
        Me.ucrChkSummerDays.Checked = False
        resources.ApplyResources(Me.ucrChkSummerDays, "ucrChkSummerDays")
        Me.ucrChkSummerDays.Name = "ucrChkSummerDays"
        '
        'ucrChkWarmSpellDI
        '
        Me.ucrChkWarmSpellDI.Checked = False
        resources.ApplyResources(Me.ucrChkWarmSpellDI, "ucrChkWarmSpellDI")
        Me.ucrChkWarmSpellDI.Name = "ucrChkWarmSpellDI"
        '
        'ucrChkIcingDays
        '
        Me.ucrChkIcingDays.Checked = False
        resources.ApplyResources(Me.ucrChkIcingDays, "ucrChkIcingDays")
        Me.ucrChkIcingDays.Name = "ucrChkIcingDays"
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
        resources.ApplyResources(Me.tbpSettings, "tbpSettings")
        Me.tbpSettings.Name = "tbpSettings"
        Me.tbpSettings.Tag = ""
        Me.tbpSettings.UseVisualStyleBackColor = True
        '
        'ucrInputPrecQtiles
        '
        Me.ucrInputPrecQtiles.AddQuotesIfUnrecognised = True
        Me.ucrInputPrecQtiles.IsMultiline = False
        Me.ucrInputPrecQtiles.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputPrecQtiles, "ucrInputPrecQtiles")
        Me.ucrInputPrecQtiles.Name = "ucrInputPrecQtiles"
        '
        'ucrInputTempQtiles
        '
        Me.ucrInputTempQtiles.AddQuotesIfUnrecognised = True
        Me.ucrInputTempQtiles.IsMultiline = False
        Me.ucrInputTempQtiles.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTempQtiles, "ucrInputTempQtiles")
        Me.ucrInputTempQtiles.Name = "ucrInputTempQtiles"
        '
        'grpBaseRange
        '
        Me.grpBaseRange.Controls.Add(Me.lblBaseTo)
        Me.grpBaseRange.Controls.Add(Me.ucrNudUpperBase)
        Me.grpBaseRange.Controls.Add(Me.lblBaseFrom)
        Me.grpBaseRange.Controls.Add(Me.ucrNudLowerBase)
        resources.ApplyResources(Me.grpBaseRange, "grpBaseRange")
        Me.grpBaseRange.Name = "grpBaseRange"
        Me.grpBaseRange.TabStop = False
        Me.grpBaseRange.Tag = ""
        '
        'lblBaseTo
        '
        resources.ApplyResources(Me.lblBaseTo, "lblBaseTo")
        Me.lblBaseTo.Name = "lblBaseTo"
        Me.lblBaseTo.Tag = ""
        '
        'ucrNudUpperBase
        '
        Me.ucrNudUpperBase.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperBase.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudUpperBase, "ucrNudUpperBase")
        Me.ucrNudUpperBase.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudUpperBase.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperBase.Name = "ucrNudUpperBase"
        Me.ucrNudUpperBase.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblBaseFrom
        '
        resources.ApplyResources(Me.lblBaseFrom, "lblBaseFrom")
        Me.lblBaseFrom.Name = "lblBaseFrom"
        Me.lblBaseFrom.Tag = ""
        '
        'ucrNudLowerBase
        '
        Me.ucrNudLowerBase.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLowerBase.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudLowerBase, "ucrNudLowerBase")
        Me.ucrNudLowerBase.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLowerBase.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLowerBase.Name = "ucrNudLowerBase"
        Me.ucrNudLowerBase.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkNHemisphere
        '
        Me.ucrChkNHemisphere.Checked = False
        resources.ApplyResources(Me.ucrChkNHemisphere, "ucrChkNHemisphere")
        Me.ucrChkNHemisphere.Name = "ucrChkNHemisphere"
        '
        'ucrChkMaxSpellSpanYears
        '
        Me.ucrChkMaxSpellSpanYears.Checked = False
        resources.ApplyResources(Me.ucrChkMaxSpellSpanYears, "ucrChkMaxSpellSpanYears")
        Me.ucrChkMaxSpellSpanYears.Name = "ucrChkMaxSpellSpanYears"
        '
        'ucrNudN
        '
        Me.ucrNudN.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudN.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudN, "ucrNudN")
        Me.ucrNudN.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudN.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudN.Name = "ucrNudN"
        Me.ucrNudN.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMinBaseData
        '
        Me.ucrNudMinBaseData.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinBaseData.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMinBaseData, "ucrNudMinBaseData")
        Me.ucrNudMinBaseData.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinBaseData.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinBaseData.Name = "ucrNudMinBaseData"
        Me.ucrNudMinBaseData.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblFreq
        '
        resources.ApplyResources(Me.lblFreq, "lblFreq")
        Me.lblFreq.Name = "lblFreq"
        Me.lblFreq.Tag = "Frequency:"
        '
        'lblMinBaseData
        '
        resources.ApplyResources(Me.lblMinBaseData, "lblMinBaseData")
        Me.lblMinBaseData.Name = "lblMinBaseData"
        Me.lblMinBaseData.Tag = "Minimum_Base_Data_ Present"
        '
        'ucrInputFreq
        '
        Me.ucrInputFreq.AddQuotesIfUnrecognised = True
        Me.ucrInputFreq.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFreq, "ucrInputFreq")
        Me.ucrInputFreq.Name = "ucrInputFreq"
        '
        'lblPrecQuantiles
        '
        resources.ApplyResources(Me.lblPrecQuantiles, "lblPrecQuantiles")
        Me.lblPrecQuantiles.Name = "lblPrecQuantiles"
        Me.lblPrecQuantiles.Tag = "Precipitation_Quantiles:"
        '
        'lblTempQuantiles
        '
        resources.ApplyResources(Me.lblTempQuantiles, "lblTempQuantiles")
        Me.lblTempQuantiles.Name = "lblTempQuantiles"
        Me.lblTempQuantiles.Tag = "Temperature_Quantiles:"
        '
        'grpMaxMissingDays
        '
        Me.grpMaxMissingDays.Controls.Add(Me.lblMonthly)
        Me.grpMaxMissingDays.Controls.Add(Me.lblAnnual)
        Me.grpMaxMissingDays.Controls.Add(Me.ucrNudMonthlyMissingDays)
        Me.grpMaxMissingDays.Controls.Add(Me.ucrNudAnnualMissingDays)
        resources.ApplyResources(Me.grpMaxMissingDays, "grpMaxMissingDays")
        Me.grpMaxMissingDays.Name = "grpMaxMissingDays"
        Me.grpMaxMissingDays.TabStop = False
        Me.grpMaxMissingDays.Tag = "Maximum_Missing_Days"
        '
        'lblMonthly
        '
        resources.ApplyResources(Me.lblMonthly, "lblMonthly")
        Me.lblMonthly.Name = "lblMonthly"
        Me.lblMonthly.Tag = "Monthly:"
        '
        'lblAnnual
        '
        resources.ApplyResources(Me.lblAnnual, "lblAnnual")
        Me.lblAnnual.Name = "lblAnnual"
        Me.lblAnnual.Tag = "Annual:"
        '
        'ucrNudMonthlyMissingDays
        '
        Me.ucrNudMonthlyMissingDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMonthlyMissingDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMonthlyMissingDays, "ucrNudMonthlyMissingDays")
        Me.ucrNudMonthlyMissingDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMonthlyMissingDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMonthlyMissingDays.Name = "ucrNudMonthlyMissingDays"
        Me.ucrNudMonthlyMissingDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudAnnualMissingDays
        '
        Me.ucrNudAnnualMissingDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAnnualMissingDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudAnnualMissingDays, "ucrNudAnnualMissingDays")
        Me.ucrNudAnnualMissingDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAnnualMissingDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAnnualMissingDays.Name = "ucrNudAnnualMissingDays"
        Me.ucrNudAnnualMissingDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblN
        '
        resources.ApplyResources(Me.lblN, "lblN")
        Me.lblN.Name = "lblN"
        Me.lblN.Tag = "Days_for_Quantiles:"
        '
        'tbpClimdex
        '
        Me.tbpClimdex.Controls.Add(Me.tbpSettings)
        Me.tbpClimdex.Controls.Add(Me.tbpTemperature)
        Me.tbpClimdex.Controls.Add(Me.tbpPrecipitation)
        resources.ApplyResources(Me.tbpClimdex, "tbpClimdex")
        Me.tbpClimdex.Name = "tbpClimdex"
        Me.tbpClimdex.SelectedIndex = 0
        '
        'ucrButtonsClimdexIndices
        '
        resources.ApplyResources(Me.ucrButtonsClimdexIndices, "ucrButtonsClimdexIndices")
        Me.ucrButtonsClimdexIndices.Name = "ucrButtonsClimdexIndices"
        '
        'sdgClimdexIndices
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.tbpClimdex)
        Me.Controls.Add(Me.ucrButtonsClimdexIndices)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgClimdexIndices"
        Me.Tag = "Indices"
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