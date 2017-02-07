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
        Me.panIndices = New System.Windows.Forms.Panel()
        Me.ucrChkPrecExceed10mm = New instat.ucrCheck()
        Me.ucrChkMaxDrySpell = New instat.ucrCheck()
        Me.ucrChkPrecExceedSpecifiedA = New instat.ucrCheck()
        Me.ucrChkPrecExceed20mm = New instat.ucrCheck()
        Me.ucrChkTotalDailyPrec = New instat.ucrCheck()
        Me.ucrChkPrecExceed99Percent = New instat.ucrCheck()
        Me.ucrChkPrecExceed95Percent = New instat.ucrCheck()
        Me.ucrChkMaxWetSpell = New instat.ucrCheck()
        Me.ucrChkColdSpellDI = New instat.ucrCheck()
        Me.ucrChkSimplePrecII = New instat.ucrCheck()
        Me.ucrChkWarmSpellDI = New instat.ucrCheck()
        Me.ucrChkMonthlyMax5dayPrec = New instat.ucrCheck()
        Me.ucrChkMonthlyMax1dayPrec = New instat.ucrCheck()
        Me.ucrChkMeanDiurnalTempRange = New instat.ucrCheck()
        Me.ucrChkSummerDays = New instat.ucrCheck()
        Me.ucrChkIcingDays = New instat.ucrCheck()
        Me.ucrChkTropicalNights = New instat.ucrCheck()
        Me.ucrChkGrowingSeasonLength = New instat.ucrCheck()
        Me.ucrChkMonthlyMaxDailyTMax = New instat.ucrCheck()
        Me.ucrChkTmaxAbove90Percent = New instat.ucrCheck()
        Me.ucrChkTminAbove90Percent = New instat.ucrCheck()
        Me.ucrChkTmaxBelow10Percent = New instat.ucrCheck()
        Me.ucrChkTminBelow10Percent = New instat.ucrCheck()
        Me.ucrChkMonthlyMinDailyTMin = New instat.ucrCheck()
        Me.ucrChkMonthlyMinDailyTMax = New instat.ucrCheck()
        Me.ucrChkMonthlyMaxDailyTMin = New instat.ucrCheck()
        Me.ucrChkFrostDays = New instat.ucrCheck()
        Me.lbl26 = New System.Windows.Forms.Label()
        Me.lbl27 = New System.Windows.Forms.Label()
        Me.lbl24 = New System.Windows.Forms.Label()
        Me.lbl25 = New System.Windows.Forms.Label()
        Me.lbl21 = New System.Windows.Forms.Label()
        Me.lbl22 = New System.Windows.Forms.Label()
        Me.lbl23 = New System.Windows.Forms.Label()
        Me.lbl20 = New System.Windows.Forms.Label()
        Me.lbl14 = New System.Windows.Forms.Label()
        Me.lbl18 = New System.Windows.Forms.Label()
        Me.lbl19 = New System.Windows.Forms.Label()
        Me.lbl17 = New System.Windows.Forms.Label()
        Me.lbl16 = New System.Windows.Forms.Label()
        Me.lbl15 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.ttClimdexIndices = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.tbClimdex = New System.Windows.Forms.TabControl()
        Me.TbSettings = New System.Windows.Forms.TabPage()
        Me.ucrChkCenterMean = New instat.ucrCheck()
        Me.ucrChkSpellDISpanYear = New instat.ucrCheck()
        Me.ucrChkNHemisphere = New instat.ucrCheck()
        Me.ucrChkMaxSpellSpanYears = New instat.ucrCheck()
        Me.lblBaseRange = New System.Windows.Forms.Label()
        Me.ucrMultipleInputBaseRange = New instat.ucrMultipleInput()
        Me.ucrNudN = New instat.ucrNud()
        Me.ucrNudThreshold = New instat.ucrNud()
        Me.ucrNudMinBaseData = New instat.ucrNud()
        Me.lblFreq = New System.Windows.Forms.Label()
        Me.lblMinBaseData = New System.Windows.Forms.Label()
        Me.ucrInputFreq = New instat.ucrInputComboBox()
        Me.ucrMultipleInputTempQtiles = New instat.ucrMultipleInput()
        Me.ucrMultipleInputPrecQtiles = New instat.ucrMultipleInput()
        Me.lblPrecQuantiles = New System.Windows.Forms.Label()
        Me.lblTempQuantiles = New System.Windows.Forms.Label()
        Me.grpMaxMissingDays = New System.Windows.Forms.GroupBox()
        Me.lblMonthly = New System.Windows.Forms.Label()
        Me.lblAnnual = New System.Windows.Forms.Label()
        Me.ucrNudMothlyMissingDays = New instat.ucrNud()
        Me.ucrNudAnnualMissingDays = New instat.ucrNud()
        Me.lblN = New System.Windows.Forms.Label()
        Me.tbIndices = New System.Windows.Forms.TabPage()
        Me.ucrButtonsClimdexIndices = New instat.ucrButtonsSubdialogue()
        Me.ucrChkSave = New instat.ucrCheck()
        Me.panIndices.SuspendLayout()
        Me.tbClimdex.SuspendLayout()
        Me.TbSettings.SuspendLayout()
        Me.grpMaxMissingDays.SuspendLayout()
        Me.tbIndices.SuspendLayout()
        Me.SuspendLayout()
        '
        'panIndices
        '
        Me.panIndices.AutoScroll = True
        Me.panIndices.Controls.Add(Me.ucrChkPrecExceed10mm)
        Me.panIndices.Controls.Add(Me.ucrChkMaxDrySpell)
        Me.panIndices.Controls.Add(Me.ucrChkPrecExceedSpecifiedA)
        Me.panIndices.Controls.Add(Me.ucrChkPrecExceed20mm)
        Me.panIndices.Controls.Add(Me.ucrChkTotalDailyPrec)
        Me.panIndices.Controls.Add(Me.ucrChkPrecExceed99Percent)
        Me.panIndices.Controls.Add(Me.ucrChkPrecExceed95Percent)
        Me.panIndices.Controls.Add(Me.ucrChkMaxWetSpell)
        Me.panIndices.Controls.Add(Me.ucrChkColdSpellDI)
        Me.panIndices.Controls.Add(Me.ucrChkSimplePrecII)
        Me.panIndices.Controls.Add(Me.ucrChkWarmSpellDI)
        Me.panIndices.Controls.Add(Me.ucrChkMonthlyMax5dayPrec)
        Me.panIndices.Controls.Add(Me.ucrChkMonthlyMax1dayPrec)
        Me.panIndices.Controls.Add(Me.ucrChkMeanDiurnalTempRange)
        Me.panIndices.Controls.Add(Me.ucrChkSummerDays)
        Me.panIndices.Controls.Add(Me.ucrChkIcingDays)
        Me.panIndices.Controls.Add(Me.ucrChkTropicalNights)
        Me.panIndices.Controls.Add(Me.ucrChkGrowingSeasonLength)
        Me.panIndices.Controls.Add(Me.ucrChkMonthlyMaxDailyTMax)
        Me.panIndices.Controls.Add(Me.ucrChkTmaxAbove90Percent)
        Me.panIndices.Controls.Add(Me.ucrChkTminAbove90Percent)
        Me.panIndices.Controls.Add(Me.ucrChkTmaxBelow10Percent)
        Me.panIndices.Controls.Add(Me.ucrChkTminBelow10Percent)
        Me.panIndices.Controls.Add(Me.ucrChkMonthlyMinDailyTMin)
        Me.panIndices.Controls.Add(Me.ucrChkMonthlyMinDailyTMax)
        Me.panIndices.Controls.Add(Me.ucrChkMonthlyMaxDailyTMin)
        Me.panIndices.Controls.Add(Me.ucrChkFrostDays)
        Me.panIndices.Controls.Add(Me.lbl26)
        Me.panIndices.Controls.Add(Me.lbl27)
        Me.panIndices.Controls.Add(Me.lbl24)
        Me.panIndices.Controls.Add(Me.lbl25)
        Me.panIndices.Controls.Add(Me.lbl21)
        Me.panIndices.Controls.Add(Me.lbl22)
        Me.panIndices.Controls.Add(Me.lbl23)
        Me.panIndices.Controls.Add(Me.lbl20)
        Me.panIndices.Controls.Add(Me.lbl14)
        Me.panIndices.Controls.Add(Me.lbl18)
        Me.panIndices.Controls.Add(Me.lbl19)
        Me.panIndices.Controls.Add(Me.lbl17)
        Me.panIndices.Controls.Add(Me.lbl16)
        Me.panIndices.Controls.Add(Me.lbl15)
        Me.panIndices.Controls.Add(Me.lbl6)
        Me.panIndices.Controls.Add(Me.lbl8)
        Me.panIndices.Controls.Add(Me.lbl12)
        Me.panIndices.Controls.Add(Me.lbl9)
        Me.panIndices.Controls.Add(Me.lbl13)
        Me.panIndices.Controls.Add(Me.lbl7)
        Me.panIndices.Controls.Add(Me.lbl11)
        Me.panIndices.Controls.Add(Me.lbl10)
        Me.panIndices.Controls.Add(Me.lbl2)
        Me.panIndices.Controls.Add(Me.lbl3)
        Me.panIndices.Controls.Add(Me.lbl4)
        Me.panIndices.Controls.Add(Me.lbl5)
        Me.panIndices.Controls.Add(Me.lbl1)
        Me.panIndices.Location = New System.Drawing.Point(3, 37)
        Me.panIndices.Name = "panIndices"
        Me.panIndices.Size = New System.Drawing.Size(462, 239)
        Me.panIndices.TabIndex = 0
        '
        'ucrChkPrecExceed10mm
        '
        Me.ucrChkPrecExceed10mm.bAddRemoveParameter = True
        Me.ucrChkPrecExceed10mm.bChangeParameterValue = True
        Me.ucrChkPrecExceed10mm.Checked = False
        Me.ucrChkPrecExceed10mm.Location = New System.Drawing.Point(27, 347)
        Me.ucrChkPrecExceed10mm.Name = "ucrChkPrecExceed10mm"
        Me.ucrChkPrecExceed10mm.Size = New System.Drawing.Size(264, 20)
        Me.ucrChkPrecExceed10mm.TabIndex = 83
        '
        'ucrChkMaxDrySpell
        '
        Me.ucrChkMaxDrySpell.bAddRemoveParameter = True
        Me.ucrChkMaxDrySpell.bChangeParameterValue = True
        Me.ucrChkMaxDrySpell.Checked = False
        Me.ucrChkMaxDrySpell.Location = New System.Drawing.Point(27, 404)
        Me.ucrChkMaxDrySpell.Name = "ucrChkMaxDrySpell"
        Me.ucrChkMaxDrySpell.Size = New System.Drawing.Size(253, 20)
        Me.ucrChkMaxDrySpell.TabIndex = 82
        '
        'ucrChkPrecExceedSpecifiedA
        '
        Me.ucrChkPrecExceedSpecifiedA.bAddRemoveParameter = True
        Me.ucrChkPrecExceedSpecifiedA.bChangeParameterValue = True
        Me.ucrChkPrecExceedSpecifiedA.Checked = False
        Me.ucrChkPrecExceedSpecifiedA.Location = New System.Drawing.Point(27, 385)
        Me.ucrChkPrecExceedSpecifiedA.Name = "ucrChkPrecExceedSpecifiedA"
        Me.ucrChkPrecExceedSpecifiedA.Size = New System.Drawing.Size(241, 20)
        Me.ucrChkPrecExceedSpecifiedA.TabIndex = 81
        '
        'ucrChkPrecExceed20mm
        '
        Me.ucrChkPrecExceed20mm.bAddRemoveParameter = True
        Me.ucrChkPrecExceed20mm.bChangeParameterValue = True
        Me.ucrChkPrecExceed20mm.Checked = False
        Me.ucrChkPrecExceed20mm.Location = New System.Drawing.Point(27, 366)
        Me.ucrChkPrecExceed20mm.Name = "ucrChkPrecExceed20mm"
        Me.ucrChkPrecExceed20mm.Size = New System.Drawing.Size(229, 20)
        Me.ucrChkPrecExceed20mm.TabIndex = 80
        '
        'ucrChkTotalDailyPrec
        '
        Me.ucrChkTotalDailyPrec.bAddRemoveParameter = True
        Me.ucrChkTotalDailyPrec.bChangeParameterValue = True
        Me.ucrChkTotalDailyPrec.Checked = False
        Me.ucrChkTotalDailyPrec.Location = New System.Drawing.Point(27, 472)
        Me.ucrChkTotalDailyPrec.Name = "ucrChkTotalDailyPrec"
        Me.ucrChkTotalDailyPrec.Size = New System.Drawing.Size(140, 20)
        Me.ucrChkTotalDailyPrec.TabIndex = 79
        '
        'ucrChkPrecExceed99Percent
        '
        Me.ucrChkPrecExceed99Percent.bAddRemoveParameter = True
        Me.ucrChkPrecExceed99Percent.bChangeParameterValue = True
        Me.ucrChkPrecExceed99Percent.Checked = False
        Me.ucrChkPrecExceed99Percent.Location = New System.Drawing.Point(27, 455)
        Me.ucrChkPrecExceed99Percent.Name = "ucrChkPrecExceed99Percent"
        Me.ucrChkPrecExceed99Percent.Size = New System.Drawing.Size(241, 20)
        Me.ucrChkPrecExceed99Percent.TabIndex = 78
        '
        'ucrChkPrecExceed95Percent
        '
        Me.ucrChkPrecExceed95Percent.bAddRemoveParameter = True
        Me.ucrChkPrecExceed95Percent.bChangeParameterValue = True
        Me.ucrChkPrecExceed95Percent.Checked = False
        Me.ucrChkPrecExceed95Percent.Location = New System.Drawing.Point(27, 439)
        Me.ucrChkPrecExceed95Percent.Name = "ucrChkPrecExceed95Percent"
        Me.ucrChkPrecExceed95Percent.Size = New System.Drawing.Size(279, 20)
        Me.ucrChkPrecExceed95Percent.TabIndex = 77
        '
        'ucrChkMaxWetSpell
        '
        Me.ucrChkMaxWetSpell.bAddRemoveParameter = True
        Me.ucrChkMaxWetSpell.bChangeParameterValue = True
        Me.ucrChkMaxWetSpell.Checked = False
        Me.ucrChkMaxWetSpell.Location = New System.Drawing.Point(27, 422)
        Me.ucrChkMaxWetSpell.Name = "ucrChkMaxWetSpell"
        Me.ucrChkMaxWetSpell.Size = New System.Drawing.Size(241, 20)
        Me.ucrChkMaxWetSpell.TabIndex = 76
        '
        'ucrChkColdSpellDI
        '
        Me.ucrChkColdSpellDI.bAddRemoveParameter = True
        Me.ucrChkColdSpellDI.bChangeParameterValue = True
        Me.ucrChkColdSpellDI.Checked = False
        Me.ucrChkColdSpellDI.Location = New System.Drawing.Point(27, 258)
        Me.ucrChkColdSpellDI.Name = "ucrChkColdSpellDI"
        Me.ucrChkColdSpellDI.Size = New System.Drawing.Size(241, 20)
        Me.ucrChkColdSpellDI.TabIndex = 75
        '
        'ucrChkSimplePrecII
        '
        Me.ucrChkSimplePrecII.bAddRemoveParameter = True
        Me.ucrChkSimplePrecII.bChangeParameterValue = True
        Me.ucrChkSimplePrecII.Checked = False
        Me.ucrChkSimplePrecII.Location = New System.Drawing.Point(27, 330)
        Me.ucrChkSimplePrecII.Name = "ucrChkSimplePrecII"
        Me.ucrChkSimplePrecII.Size = New System.Drawing.Size(241, 20)
        Me.ucrChkSimplePrecII.TabIndex = 74
        '
        'ucrChkWarmSpellDI
        '
        Me.ucrChkWarmSpellDI.bAddRemoveParameter = True
        Me.ucrChkWarmSpellDI.bChangeParameterValue = True
        Me.ucrChkWarmSpellDI.Checked = False
        Me.ucrChkWarmSpellDI.Location = New System.Drawing.Point(27, 241)
        Me.ucrChkWarmSpellDI.Name = "ucrChkWarmSpellDI"
        Me.ucrChkWarmSpellDI.Size = New System.Drawing.Size(255, 20)
        Me.ucrChkWarmSpellDI.TabIndex = 73
        '
        'ucrChkMonthlyMax5dayPrec
        '
        Me.ucrChkMonthlyMax5dayPrec.bAddRemoveParameter = True
        Me.ucrChkMonthlyMax5dayPrec.bChangeParameterValue = True
        Me.ucrChkMonthlyMax5dayPrec.Checked = False
        Me.ucrChkMonthlyMax5dayPrec.Location = New System.Drawing.Point(27, 310)
        Me.ucrChkMonthlyMax5dayPrec.Name = "ucrChkMonthlyMax5dayPrec"
        Me.ucrChkMonthlyMax5dayPrec.Size = New System.Drawing.Size(241, 20)
        Me.ucrChkMonthlyMax5dayPrec.TabIndex = 72
        '
        'ucrChkMonthlyMax1dayPrec
        '
        Me.ucrChkMonthlyMax1dayPrec.bAddRemoveParameter = True
        Me.ucrChkMonthlyMax1dayPrec.bChangeParameterValue = True
        Me.ucrChkMonthlyMax1dayPrec.Checked = False
        Me.ucrChkMonthlyMax1dayPrec.Location = New System.Drawing.Point(27, 294)
        Me.ucrChkMonthlyMax1dayPrec.Name = "ucrChkMonthlyMax1dayPrec"
        Me.ucrChkMonthlyMax1dayPrec.Size = New System.Drawing.Size(264, 20)
        Me.ucrChkMonthlyMax1dayPrec.TabIndex = 71
        '
        'ucrChkMeanDiurnalTempRange
        '
        Me.ucrChkMeanDiurnalTempRange.bAddRemoveParameter = True
        Me.ucrChkMeanDiurnalTempRange.bChangeParameterValue = True
        Me.ucrChkMeanDiurnalTempRange.Checked = False
        Me.ucrChkMeanDiurnalTempRange.Location = New System.Drawing.Point(27, 276)
        Me.ucrChkMeanDiurnalTempRange.Name = "ucrChkMeanDiurnalTempRange"
        Me.ucrChkMeanDiurnalTempRange.Size = New System.Drawing.Size(264, 20)
        Me.ucrChkMeanDiurnalTempRange.TabIndex = 70
        '
        'ucrChkSummerDays
        '
        Me.ucrChkSummerDays.bAddRemoveParameter = True
        Me.ucrChkSummerDays.bChangeParameterValue = True
        Me.ucrChkSummerDays.Checked = False
        Me.ucrChkSummerDays.Location = New System.Drawing.Point(27, 25)
        Me.ucrChkSummerDays.Name = "ucrChkSummerDays"
        Me.ucrChkSummerDays.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSummerDays.TabIndex = 69
        '
        'ucrChkIcingDays
        '
        Me.ucrChkIcingDays.bAddRemoveParameter = True
        Me.ucrChkIcingDays.bChangeParameterValue = True
        Me.ucrChkIcingDays.Checked = False
        Me.ucrChkIcingDays.Location = New System.Drawing.Point(27, 43)
        Me.ucrChkIcingDays.Name = "ucrChkIcingDays"
        Me.ucrChkIcingDays.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkIcingDays.TabIndex = 68
        '
        'ucrChkTropicalNights
        '
        Me.ucrChkTropicalNights.bAddRemoveParameter = True
        Me.ucrChkTropicalNights.bChangeParameterValue = True
        Me.ucrChkTropicalNights.Checked = False
        Me.ucrChkTropicalNights.Location = New System.Drawing.Point(27, 61)
        Me.ucrChkTropicalNights.Name = "ucrChkTropicalNights"
        Me.ucrChkTropicalNights.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkTropicalNights.TabIndex = 67
        '
        'ucrChkGrowingSeasonLength
        '
        Me.ucrChkGrowingSeasonLength.bAddRemoveParameter = True
        Me.ucrChkGrowingSeasonLength.bChangeParameterValue = True
        Me.ucrChkGrowingSeasonLength.Checked = False
        Me.ucrChkGrowingSeasonLength.Location = New System.Drawing.Point(27, 79)
        Me.ucrChkGrowingSeasonLength.Name = "ucrChkGrowingSeasonLength"
        Me.ucrChkGrowingSeasonLength.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkGrowingSeasonLength.TabIndex = 66
        '
        'ucrChkMonthlyMaxDailyTMax
        '
        Me.ucrChkMonthlyMaxDailyTMax.bAddRemoveParameter = True
        Me.ucrChkMonthlyMaxDailyTMax.bChangeParameterValue = True
        Me.ucrChkMonthlyMaxDailyTMax.Checked = False
        Me.ucrChkMonthlyMaxDailyTMax.Location = New System.Drawing.Point(27, 98)
        Me.ucrChkMonthlyMaxDailyTMax.Name = "ucrChkMonthlyMaxDailyTMax"
        Me.ucrChkMonthlyMaxDailyTMax.Size = New System.Drawing.Size(297, 20)
        Me.ucrChkMonthlyMaxDailyTMax.TabIndex = 65
        '
        'ucrChkTmaxAbove90Percent
        '
        Me.ucrChkTmaxAbove90Percent.bAddRemoveParameter = True
        Me.ucrChkTmaxAbove90Percent.bChangeParameterValue = True
        Me.ucrChkTmaxAbove90Percent.Checked = False
        Me.ucrChkTmaxAbove90Percent.Location = New System.Drawing.Point(27, 223)
        Me.ucrChkTmaxAbove90Percent.Name = "ucrChkTmaxAbove90Percent"
        Me.ucrChkTmaxAbove90Percent.Size = New System.Drawing.Size(255, 20)
        Me.ucrChkTmaxAbove90Percent.TabIndex = 64
        '
        'ucrChkTminAbove90Percent
        '
        Me.ucrChkTminAbove90Percent.bAddRemoveParameter = True
        Me.ucrChkTminAbove90Percent.bChangeParameterValue = True
        Me.ucrChkTminAbove90Percent.Checked = False
        Me.ucrChkTminAbove90Percent.Location = New System.Drawing.Point(27, 204)
        Me.ucrChkTminAbove90Percent.Name = "ucrChkTminAbove90Percent"
        Me.ucrChkTminAbove90Percent.Size = New System.Drawing.Size(297, 20)
        Me.ucrChkTminAbove90Percent.TabIndex = 63
        '
        'ucrChkTmaxBelow10Percent
        '
        Me.ucrChkTmaxBelow10Percent.bAddRemoveParameter = True
        Me.ucrChkTmaxBelow10Percent.bChangeParameterValue = True
        Me.ucrChkTmaxBelow10Percent.Checked = False
        Me.ucrChkTmaxBelow10Percent.Location = New System.Drawing.Point(27, 187)
        Me.ucrChkTmaxBelow10Percent.Name = "ucrChkTmaxBelow10Percent"
        Me.ucrChkTmaxBelow10Percent.Size = New System.Drawing.Size(300, 20)
        Me.ucrChkTmaxBelow10Percent.TabIndex = 62
        '
        'ucrChkTminBelow10Percent
        '
        Me.ucrChkTminBelow10Percent.bAddRemoveParameter = True
        Me.ucrChkTminBelow10Percent.bChangeParameterValue = True
        Me.ucrChkTminBelow10Percent.Checked = False
        Me.ucrChkTminBelow10Percent.Location = New System.Drawing.Point(27, 170)
        Me.ucrChkTminBelow10Percent.Name = "ucrChkTminBelow10Percent"
        Me.ucrChkTminBelow10Percent.Size = New System.Drawing.Size(302, 20)
        Me.ucrChkTminBelow10Percent.TabIndex = 61
        '
        'ucrChkMonthlyMinDailyTMin
        '
        Me.ucrChkMonthlyMinDailyTMin.bAddRemoveParameter = True
        Me.ucrChkMonthlyMinDailyTMin.bChangeParameterValue = True
        Me.ucrChkMonthlyMinDailyTMin.Checked = False
        Me.ucrChkMonthlyMinDailyTMin.Location = New System.Drawing.Point(27, 151)
        Me.ucrChkMonthlyMinDailyTMin.Name = "ucrChkMonthlyMinDailyTMin"
        Me.ucrChkMonthlyMinDailyTMin.Size = New System.Drawing.Size(276, 20)
        Me.ucrChkMonthlyMinDailyTMin.TabIndex = 60
        '
        'ucrChkMonthlyMinDailyTMax
        '
        Me.ucrChkMonthlyMinDailyTMax.bAddRemoveParameter = True
        Me.ucrChkMonthlyMinDailyTMax.bChangeParameterValue = True
        Me.ucrChkMonthlyMinDailyTMax.Checked = False
        Me.ucrChkMonthlyMinDailyTMax.Location = New System.Drawing.Point(27, 133)
        Me.ucrChkMonthlyMinDailyTMax.Name = "ucrChkMonthlyMinDailyTMax"
        Me.ucrChkMonthlyMinDailyTMax.Size = New System.Drawing.Size(255, 20)
        Me.ucrChkMonthlyMinDailyTMax.TabIndex = 59
        '
        'ucrChkMonthlyMaxDailyTMin
        '
        Me.ucrChkMonthlyMaxDailyTMin.bAddRemoveParameter = True
        Me.ucrChkMonthlyMaxDailyTMin.bChangeParameterValue = True
        Me.ucrChkMonthlyMaxDailyTMin.Checked = False
        Me.ucrChkMonthlyMaxDailyTMin.Location = New System.Drawing.Point(27, 116)
        Me.ucrChkMonthlyMaxDailyTMin.Name = "ucrChkMonthlyMaxDailyTMin"
        Me.ucrChkMonthlyMaxDailyTMin.Size = New System.Drawing.Size(255, 20)
        Me.ucrChkMonthlyMaxDailyTMin.TabIndex = 58
        '
        'ucrChkFrostDays
        '
        Me.ucrChkFrostDays.bAddRemoveParameter = True
        Me.ucrChkFrostDays.bChangeParameterValue = True
        Me.ucrChkFrostDays.Checked = False
        Me.ucrChkFrostDays.Location = New System.Drawing.Point(27, 8)
        Me.ucrChkFrostDays.Name = "ucrChkFrostDays"
        Me.ucrChkFrostDays.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFrostDays.TabIndex = 54
        '
        'lbl26
        '
        Me.lbl26.AutoSize = True
        Me.lbl26.Location = New System.Drawing.Point(5, 456)
        Me.lbl26.Name = "lbl26"
        Me.lbl26.Size = New System.Drawing.Size(22, 13)
        Me.lbl26.TabIndex = 50
        Me.lbl26.Tag = "26."
        Me.lbl26.Text = "26."
        '
        'lbl27
        '
        Me.lbl27.AutoSize = True
        Me.lbl27.Location = New System.Drawing.Point(5, 473)
        Me.lbl27.Name = "lbl27"
        Me.lbl27.Size = New System.Drawing.Size(22, 13)
        Me.lbl27.TabIndex = 52
        Me.lbl27.Tag = "27."
        Me.lbl27.Text = "27."
        '
        'lbl24
        '
        Me.lbl24.AutoSize = True
        Me.lbl24.Location = New System.Drawing.Point(5, 422)
        Me.lbl24.Name = "lbl24"
        Me.lbl24.Size = New System.Drawing.Size(22, 13)
        Me.lbl24.TabIndex = 46
        Me.lbl24.Tag = "24."
        Me.lbl24.Text = "24."
        '
        'lbl25
        '
        Me.lbl25.AutoSize = True
        Me.lbl25.Location = New System.Drawing.Point(5, 439)
        Me.lbl25.Name = "lbl25"
        Me.lbl25.Size = New System.Drawing.Size(22, 13)
        Me.lbl25.TabIndex = 48
        Me.lbl25.Tag = "25."
        Me.lbl25.Text = "25."
        '
        'lbl21
        '
        Me.lbl21.AutoSize = True
        Me.lbl21.Location = New System.Drawing.Point(5, 370)
        Me.lbl21.Name = "lbl21"
        Me.lbl21.Size = New System.Drawing.Size(22, 13)
        Me.lbl21.TabIndex = 40
        Me.lbl21.Tag = "21."
        Me.lbl21.Text = "21."
        '
        'lbl22
        '
        Me.lbl22.AutoSize = True
        Me.lbl22.Location = New System.Drawing.Point(5, 389)
        Me.lbl22.Name = "lbl22"
        Me.lbl22.Size = New System.Drawing.Size(22, 13)
        Me.lbl22.TabIndex = 42
        Me.lbl22.Tag = "22."
        Me.lbl22.Text = "22."
        '
        'lbl23
        '
        Me.lbl23.AutoSize = True
        Me.lbl23.Location = New System.Drawing.Point(5, 405)
        Me.lbl23.Name = "lbl23"
        Me.lbl23.Size = New System.Drawing.Size(22, 13)
        Me.lbl23.TabIndex = 44
        Me.lbl23.Tag = "23."
        Me.lbl23.Text = "23."
        '
        'lbl20
        '
        Me.lbl20.AutoSize = True
        Me.lbl20.Location = New System.Drawing.Point(5, 350)
        Me.lbl20.Name = "lbl20"
        Me.lbl20.Size = New System.Drawing.Size(22, 13)
        Me.lbl20.TabIndex = 38
        Me.lbl20.Tag = "20."
        Me.lbl20.Text = "20."
        '
        'lbl14
        '
        Me.lbl14.AutoSize = True
        Me.lbl14.Location = New System.Drawing.Point(5, 242)
        Me.lbl14.Name = "lbl14"
        Me.lbl14.Size = New System.Drawing.Size(22, 13)
        Me.lbl14.TabIndex = 26
        Me.lbl14.Tag = "14."
        Me.lbl14.Text = "14."
        '
        'lbl18
        '
        Me.lbl18.AutoSize = True
        Me.lbl18.Location = New System.Drawing.Point(5, 314)
        Me.lbl18.Name = "lbl18"
        Me.lbl18.Size = New System.Drawing.Size(22, 13)
        Me.lbl18.TabIndex = 34
        Me.lbl18.Tag = "18."
        Me.lbl18.Text = "18."
        '
        'lbl19
        '
        Me.lbl19.AutoSize = True
        Me.lbl19.Location = New System.Drawing.Point(5, 333)
        Me.lbl19.Name = "lbl19"
        Me.lbl19.Size = New System.Drawing.Size(22, 13)
        Me.lbl19.TabIndex = 36
        Me.lbl19.Tag = "19."
        Me.lbl19.Text = "19."
        '
        'lbl17
        '
        Me.lbl17.AutoSize = True
        Me.lbl17.Location = New System.Drawing.Point(5, 296)
        Me.lbl17.Name = "lbl17"
        Me.lbl17.Size = New System.Drawing.Size(22, 13)
        Me.lbl17.TabIndex = 32
        Me.lbl17.Tag = "17."
        Me.lbl17.Text = "17."
        '
        'lbl16
        '
        Me.lbl16.AutoSize = True
        Me.lbl16.Location = New System.Drawing.Point(5, 279)
        Me.lbl16.Name = "lbl16"
        Me.lbl16.Size = New System.Drawing.Size(22, 13)
        Me.lbl16.TabIndex = 30
        Me.lbl16.Tag = "16."
        Me.lbl16.Text = "16."
        '
        'lbl15
        '
        Me.lbl15.AutoSize = True
        Me.lbl15.Location = New System.Drawing.Point(5, 261)
        Me.lbl15.Name = "lbl15"
        Me.lbl15.Size = New System.Drawing.Size(22, 13)
        Me.lbl15.TabIndex = 28
        Me.lbl15.Tag = "15."
        Me.lbl15.Text = "15."
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Location = New System.Drawing.Point(10, 99)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(16, 13)
        Me.lbl6.TabIndex = 10
        Me.lbl6.Tag = "6."
        Me.lbl6.Text = "6."
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.Location = New System.Drawing.Point(10, 135)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(16, 13)
        Me.lbl8.TabIndex = 14
        Me.lbl8.Tag = "8."
        Me.lbl8.Text = "8."
        '
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.Location = New System.Drawing.Point(5, 207)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(22, 13)
        Me.lbl12.TabIndex = 22
        Me.lbl12.Tag = "12."
        Me.lbl12.Text = "12."
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.Location = New System.Drawing.Point(10, 151)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(16, 13)
        Me.lbl9.TabIndex = 16
        Me.lbl9.Tag = "9."
        Me.lbl9.Text = "9."
        '
        'lbl13
        '
        Me.lbl13.AutoSize = True
        Me.lbl13.Location = New System.Drawing.Point(5, 225)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(22, 13)
        Me.lbl13.TabIndex = 24
        Me.lbl13.Tag = "13."
        Me.lbl13.Text = "13."
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Location = New System.Drawing.Point(10, 117)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(16, 13)
        Me.lbl7.TabIndex = 12
        Me.lbl7.Tag = "7."
        Me.lbl7.Text = "7."
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.Location = New System.Drawing.Point(5, 188)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(22, 13)
        Me.lbl11.TabIndex = 20
        Me.lbl11.Tag = "11."
        Me.lbl11.Text = "11."
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Location = New System.Drawing.Point(5, 171)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(22, 13)
        Me.lbl10.TabIndex = 18
        Me.lbl10.Tag = "10."
        Me.lbl10.Text = "10."
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(10, 26)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(16, 13)
        Me.lbl2.TabIndex = 2
        Me.lbl2.Tag = "2."
        Me.lbl2.Text = "2."
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(10, 44)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(16, 13)
        Me.lbl3.TabIndex = 4
        Me.lbl3.Tag = "3."
        Me.lbl3.Text = "3."
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(10, 62)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(16, 13)
        Me.lbl4.TabIndex = 6
        Me.lbl4.Tag = "4."
        Me.lbl4.Text = "4."
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(10, 80)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(16, 13)
        Me.lbl5.TabIndex = 8
        Me.lbl5.Tag = "5."
        Me.lbl5.Text = "5."
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(10, 9)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(16, 13)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Tag = "1."
        Me.lbl1.Text = "1."
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(13, 136)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(54, 13)
        Me.lblThreshold.TabIndex = 1
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Threshold"
        '
        'tbClimdex
        '
        Me.tbClimdex.Controls.Add(Me.TbSettings)
        Me.tbClimdex.Controls.Add(Me.tbIndices)
        Me.tbClimdex.Location = New System.Drawing.Point(7, 0)
        Me.tbClimdex.Name = "tbClimdex"
        Me.tbClimdex.SelectedIndex = 0
        Me.tbClimdex.Size = New System.Drawing.Size(476, 305)
        Me.tbClimdex.TabIndex = 7
        '
        'TbSettings
        '
        Me.TbSettings.Controls.Add(Me.ucrChkCenterMean)
        Me.TbSettings.Controls.Add(Me.ucrChkSpellDISpanYear)
        Me.TbSettings.Controls.Add(Me.ucrChkNHemisphere)
        Me.TbSettings.Controls.Add(Me.ucrChkMaxSpellSpanYears)
        Me.TbSettings.Controls.Add(Me.lblBaseRange)
        Me.TbSettings.Controls.Add(Me.ucrMultipleInputBaseRange)
        Me.TbSettings.Controls.Add(Me.ucrNudN)
        Me.TbSettings.Controls.Add(Me.ucrNudThreshold)
        Me.TbSettings.Controls.Add(Me.ucrNudMinBaseData)
        Me.TbSettings.Controls.Add(Me.lblFreq)
        Me.TbSettings.Controls.Add(Me.lblMinBaseData)
        Me.TbSettings.Controls.Add(Me.ucrInputFreq)
        Me.TbSettings.Controls.Add(Me.ucrMultipleInputTempQtiles)
        Me.TbSettings.Controls.Add(Me.ucrMultipleInputPrecQtiles)
        Me.TbSettings.Controls.Add(Me.lblPrecQuantiles)
        Me.TbSettings.Controls.Add(Me.lblTempQuantiles)
        Me.TbSettings.Controls.Add(Me.grpMaxMissingDays)
        Me.TbSettings.Controls.Add(Me.lblN)
        Me.TbSettings.Controls.Add(Me.lblThreshold)
        Me.TbSettings.Location = New System.Drawing.Point(4, 22)
        Me.TbSettings.Name = "TbSettings"
        Me.TbSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TbSettings.Size = New System.Drawing.Size(468, 279)
        Me.TbSettings.TabIndex = 0
        Me.TbSettings.Tag = ""
        Me.TbSettings.Text = "Settings"
        Me.TbSettings.UseVisualStyleBackColor = True
        '
        'ucrChkCenterMean
        '
        Me.ucrChkCenterMean.bAddRemoveParameter = True
        Me.ucrChkCenterMean.bChangeParameterValue = True
        Me.ucrChkCenterMean.Checked = False
        Me.ucrChkCenterMean.Location = New System.Drawing.Point(284, 187)
        Me.ucrChkCenterMean.Name = "ucrChkCenterMean"
        Me.ucrChkCenterMean.Size = New System.Drawing.Size(171, 20)
        Me.ucrChkCenterMean.TabIndex = 49
        '
        'ucrChkSpellDISpanYear
        '
        Me.ucrChkSpellDISpanYear.bAddRemoveParameter = True
        Me.ucrChkSpellDISpanYear.bChangeParameterValue = True
        Me.ucrChkSpellDISpanYear.Checked = False
        Me.ucrChkSpellDISpanYear.Location = New System.Drawing.Point(13, 218)
        Me.ucrChkSpellDISpanYear.Name = "ucrChkSpellDISpanYear"
        Me.ucrChkSpellDISpanYear.Size = New System.Drawing.Size(233, 20)
        Me.ucrChkSpellDISpanYear.TabIndex = 48
        '
        'ucrChkNHemisphere
        '
        Me.ucrChkNHemisphere.bAddRemoveParameter = True
        Me.ucrChkNHemisphere.bChangeParameterValue = True
        Me.ucrChkNHemisphere.Checked = False
        Me.ucrChkNHemisphere.Location = New System.Drawing.Point(13, 107)
        Me.ucrChkNHemisphere.Name = "ucrChkNHemisphere"
        Me.ucrChkNHemisphere.Size = New System.Drawing.Size(212, 20)
        Me.ucrChkNHemisphere.TabIndex = 47
        '
        'ucrChkMaxSpellSpanYears
        '
        Me.ucrChkMaxSpellSpanYears.bAddRemoveParameter = True
        Me.ucrChkMaxSpellSpanYears.bChangeParameterValue = True
        Me.ucrChkMaxSpellSpanYears.Checked = False
        Me.ucrChkMaxSpellSpanYears.Location = New System.Drawing.Point(13, 187)
        Me.ucrChkMaxSpellSpanYears.Name = "ucrChkMaxSpellSpanYears"
        Me.ucrChkMaxSpellSpanYears.Size = New System.Drawing.Size(233, 20)
        Me.ucrChkMaxSpellSpanYears.TabIndex = 46
        '
        'lblBaseRange
        '
        Me.lblBaseRange.AutoSize = True
        Me.lblBaseRange.Location = New System.Drawing.Point(13, 6)
        Me.lblBaseRange.Name = "lblBaseRange"
        Me.lblBaseRange.Size = New System.Drawing.Size(66, 13)
        Me.lblBaseRange.TabIndex = 45
        Me.lblBaseRange.Tag = ""
        Me.lblBaseRange.Text = "Base Range"
        '
        'ucrMultipleInputBaseRange
        '
        Me.ucrMultipleInputBaseRange.bAddRemoveParameter = True
        Me.ucrMultipleInputBaseRange.bChangeParameterValue = True
        Me.ucrMultipleInputBaseRange.Location = New System.Drawing.Point(13, 23)
        Me.ucrMultipleInputBaseRange.Name = "ucrMultipleInputBaseRange"
        Me.ucrMultipleInputBaseRange.Size = New System.Drawing.Size(150, 29)
        Me.ucrMultipleInputBaseRange.TabIndex = 44
        '
        'ucrNudN
        '
        Me.ucrNudN.bAddRemoveParameter = True
        Me.ucrNudN.bChangeParameterValue = True
        Me.ucrNudN.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudN.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudN.Location = New System.Drawing.Point(379, 158)
        Me.ucrNudN.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudN.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudN.Name = "ucrNudN"
        Me.ucrNudN.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudN.TabIndex = 43
        Me.ucrNudN.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudThreshold
        '
        Me.ucrNudThreshold.bAddRemoveParameter = True
        Me.ucrNudThreshold.bChangeParameterValue = True
        Me.ucrNudThreshold.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThreshold.Location = New System.Drawing.Point(93, 132)
        Me.ucrNudThreshold.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThreshold.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Name = "ucrNudThreshold"
        Me.ucrNudThreshold.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudThreshold.TabIndex = 42
        Me.ucrNudThreshold.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMinBaseData
        '
        Me.ucrNudMinBaseData.bAddRemoveParameter = True
        Me.ucrNudMinBaseData.bChangeParameterValue = True
        Me.ucrNudMinBaseData.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinBaseData.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinBaseData.Location = New System.Drawing.Point(210, 158)
        Me.ucrNudMinBaseData.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinBaseData.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinBaseData.Name = "ucrNudMinBaseData"
        Me.ucrNudMinBaseData.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinBaseData.TabIndex = 41
        Me.ucrNudMinBaseData.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblFreq
        '
        Me.lblFreq.AutoSize = True
        Me.lblFreq.Location = New System.Drawing.Point(284, 6)
        Me.lblFreq.Name = "lblFreq"
        Me.lblFreq.Size = New System.Drawing.Size(57, 13)
        Me.lblFreq.TabIndex = 36
        Me.lblFreq.Tag = "Frequency"
        Me.lblFreq.Text = "Frequency"
        '
        'lblMinBaseData
        '
        Me.lblMinBaseData.AutoSize = True
        Me.lblMinBaseData.Location = New System.Drawing.Point(13, 162)
        Me.lblMinBaseData.Name = "lblMinBaseData"
        Me.lblMinBaseData.Size = New System.Drawing.Size(193, 13)
        Me.lblMinBaseData.TabIndex = 34
        Me.lblMinBaseData.Tag = "Minimum_Fraction_of_Base_Data_ Present"
        Me.lblMinBaseData.Text = "Minimum Fraction of Base Data Present"
        '
        'ucrInputFreq
        '
        Me.ucrInputFreq.bAddRemoveParameter = True
        Me.ucrInputFreq.bChangeParameterValue = True
        Me.ucrInputFreq.IsReadOnly = False
        Me.ucrInputFreq.Location = New System.Drawing.Point(284, 27)
        Me.ucrInputFreq.Name = "ucrInputFreq"
        Me.ucrInputFreq.Size = New System.Drawing.Size(145, 21)
        Me.ucrInputFreq.TabIndex = 24
        '
        'ucrMultipleInputTempQtiles
        '
        Me.ucrMultipleInputTempQtiles.bAddRemoveParameter = True
        Me.ucrMultipleInputTempQtiles.bChangeParameterValue = True
        Me.ucrMultipleInputTempQtiles.Location = New System.Drawing.Point(284, 73)
        Me.ucrMultipleInputTempQtiles.Name = "ucrMultipleInputTempQtiles"
        Me.ucrMultipleInputTempQtiles.Size = New System.Drawing.Size(150, 29)
        Me.ucrMultipleInputTempQtiles.TabIndex = 30
        '
        'ucrMultipleInputPrecQtiles
        '
        Me.ucrMultipleInputPrecQtiles.bAddRemoveParameter = True
        Me.ucrMultipleInputPrecQtiles.bChangeParameterValue = True
        Me.ucrMultipleInputPrecQtiles.Location = New System.Drawing.Point(284, 128)
        Me.ucrMultipleInputPrecQtiles.Name = "ucrMultipleInputPrecQtiles"
        Me.ucrMultipleInputPrecQtiles.Size = New System.Drawing.Size(150, 29)
        Me.ucrMultipleInputPrecQtiles.TabIndex = 33
        '
        'lblPrecQuantiles
        '
        Me.lblPrecQuantiles.AutoSize = True
        Me.lblPrecQuantiles.Location = New System.Drawing.Point(284, 107)
        Me.lblPrecQuantiles.Name = "lblPrecQuantiles"
        Me.lblPrecQuantiles.Size = New System.Drawing.Size(112, 13)
        Me.lblPrecQuantiles.TabIndex = 32
        Me.lblPrecQuantiles.Tag = "Precipitation_Quantiles"
        Me.lblPrecQuantiles.Text = "Precipitation Quantiles"
        '
        'lblTempQuantiles
        '
        Me.lblTempQuantiles.AutoSize = True
        Me.lblTempQuantiles.Location = New System.Drawing.Point(284, 56)
        Me.lblTempQuantiles.Name = "lblTempQuantiles"
        Me.lblTempQuantiles.Size = New System.Drawing.Size(114, 13)
        Me.lblTempQuantiles.TabIndex = 28
        Me.lblTempQuantiles.Tag = "Temperature_Quantiles"
        Me.lblTempQuantiles.Text = "Temperature Quantiles"
        '
        'grpMaxMissingDays
        '
        Me.grpMaxMissingDays.Controls.Add(Me.lblMonthly)
        Me.grpMaxMissingDays.Controls.Add(Me.lblAnnual)
        Me.grpMaxMissingDays.Controls.Add(Me.ucrNudMothlyMissingDays)
        Me.grpMaxMissingDays.Controls.Add(Me.ucrNudAnnualMissingDays)
        Me.grpMaxMissingDays.Location = New System.Drawing.Point(13, 56)
        Me.grpMaxMissingDays.Name = "grpMaxMissingDays"
        Me.grpMaxMissingDays.Size = New System.Drawing.Size(216, 45)
        Me.grpMaxMissingDays.TabIndex = 29
        Me.grpMaxMissingDays.TabStop = False
        Me.grpMaxMissingDays.Tag = "Maximum_Missing_Days"
        Me.grpMaxMissingDays.Text = "Maximum Missing Days"
        '
        'lblMonthly
        '
        Me.lblMonthly.AutoSize = True
        Me.lblMonthly.Location = New System.Drawing.Point(106, 19)
        Me.lblMonthly.Name = "lblMonthly"
        Me.lblMonthly.Size = New System.Drawing.Size(44, 13)
        Me.lblMonthly.TabIndex = 2
        Me.lblMonthly.Tag = "Monthly"
        Me.lblMonthly.Text = "Monthly"
        '
        'lblAnnual
        '
        Me.lblAnnual.AutoSize = True
        Me.lblAnnual.Location = New System.Drawing.Point(7, 19)
        Me.lblAnnual.Name = "lblAnnual"
        Me.lblAnnual.Size = New System.Drawing.Size(40, 13)
        Me.lblAnnual.TabIndex = 0
        Me.lblAnnual.Tag = "Annual"
        Me.lblAnnual.Text = "Annual"
        '
        'ucrNudMothlyMissingDays
        '
        Me.ucrNudMothlyMissingDays.bAddRemoveParameter = True
        Me.ucrNudMothlyMissingDays.bChangeParameterValue = True
        Me.ucrNudMothlyMissingDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMothlyMissingDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMothlyMissingDays.Location = New System.Drawing.Point(160, 15)
        Me.ucrNudMothlyMissingDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMothlyMissingDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMothlyMissingDays.Name = "ucrNudMothlyMissingDays"
        Me.ucrNudMothlyMissingDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMothlyMissingDays.TabIndex = 39
        Me.ucrNudMothlyMissingDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudAnnualMissingDays
        '
        Me.ucrNudAnnualMissingDays.bAddRemoveParameter = True
        Me.ucrNudAnnualMissingDays.bChangeParameterValue = True
        Me.ucrNudAnnualMissingDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAnnualMissingDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAnnualMissingDays.Location = New System.Drawing.Point(53, 15)
        Me.ucrNudAnnualMissingDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAnnualMissingDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAnnualMissingDays.Name = "ucrNudAnnualMissingDays"
        Me.ucrNudAnnualMissingDays.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudAnnualMissingDays.TabIndex = 38
        Me.ucrNudAnnualMissingDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Location = New System.Drawing.Point(284, 162)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(93, 13)
        Me.lblN.TabIndex = 26
        Me.lblN.Tag = "Days_for_Quantiles"
        Me.lblN.Text = "Days for Quantiles"
        '
        'tbIndices
        '
        Me.tbIndices.Controls.Add(Me.ucrChkSave)
        Me.tbIndices.Controls.Add(Me.panIndices)
        Me.tbIndices.Location = New System.Drawing.Point(4, 22)
        Me.tbIndices.Name = "tbIndices"
        Me.tbIndices.Padding = New System.Windows.Forms.Padding(3)
        Me.tbIndices.Size = New System.Drawing.Size(468, 279)
        Me.tbIndices.TabIndex = 1
        Me.tbIndices.Text = "Indices"
        Me.tbIndices.UseVisualStyleBackColor = True
        '
        'ucrButtonsClimdexIndices
        '
        Me.ucrButtonsClimdexIndices.Location = New System.Drawing.Point(163, 311)
        Me.ucrButtonsClimdexIndices.Name = "ucrButtonsClimdexIndices"
        Me.ucrButtonsClimdexIndices.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsClimdexIndices.TabIndex = 6
        '
        'ucrChkSave
        '
        Me.ucrChkSave.bAddRemoveParameter = True
        Me.ucrChkSave.bChangeParameterValue = True
        Me.ucrChkSave.Checked = False
        Me.ucrChkSave.Location = New System.Drawing.Point(6, 11)
        Me.ucrChkSave.Name = "ucrChkSave"
        Me.ucrChkSave.Size = New System.Drawing.Size(95, 20)
        Me.ucrChkSave.TabIndex = 51
        '
        'sdgClimdexIndices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 348)
        Me.Controls.Add(Me.tbClimdex)
        Me.Controls.Add(Me.ucrButtonsClimdexIndices)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgClimdexIndices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Indices"
        Me.Text = "Indices"
        Me.panIndices.ResumeLayout(False)
        Me.panIndices.PerformLayout()
        Me.tbClimdex.ResumeLayout(False)
        Me.TbSettings.ResumeLayout(False)
        Me.TbSettings.PerformLayout()
        Me.grpMaxMissingDays.ResumeLayout(False)
        Me.grpMaxMissingDays.PerformLayout()
        Me.tbIndices.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsClimdexIndices As ucrButtonsSubdialogue
    Friend WithEvents panIndices As Panel
    Friend WithEvents ttClimdexIndices As ToolTip
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lbl26 As Label
    Friend WithEvents lbl27 As Label
    Friend WithEvents lbl24 As Label
    Friend WithEvents lbl25 As Label
    Friend WithEvents lbl21 As Label
    Friend WithEvents lbl22 As Label
    Friend WithEvents lbl23 As Label
    Friend WithEvents lbl20 As Label
    Friend WithEvents lbl14 As Label
    Friend WithEvents lbl18 As Label
    Friend WithEvents lbl19 As Label
    Friend WithEvents lbl17 As Label
    Friend WithEvents lbl16 As Label
    Friend WithEvents lbl15 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl8 As Label
    Friend WithEvents lbl12 As Label
    Friend WithEvents lbl9 As Label
    Friend WithEvents lbl13 As Label
    Friend WithEvents lbl7 As Label
    Friend WithEvents lbl11 As Label
    Friend WithEvents lbl10 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents tbClimdex As TabControl
    Friend WithEvents TbSettings As TabPage
    Friend WithEvents tbIndices As TabPage
    Friend WithEvents ucrInputFreq As ucrInputComboBox
    Friend WithEvents ucrMultipleInputTempQtiles As ucrMultipleInput
    Friend WithEvents ucrMultipleInputPrecQtiles As ucrMultipleInput
    Friend WithEvents lblPrecQuantiles As Label
    Friend WithEvents lblTempQuantiles As Label
    Friend WithEvents grpMaxMissingDays As GroupBox
    Friend WithEvents lblMonthly As Label
    Friend WithEvents lblAnnual As Label
    Friend WithEvents lblN As Label
    Friend WithEvents lblMinBaseData As Label
    Friend WithEvents lblFreq As Label
    Friend WithEvents ucrNudN As ucrNud
    Friend WithEvents ucrNudThreshold As ucrNud
    Friend WithEvents ucrNudMinBaseData As ucrNud
    Friend WithEvents ucrNudMothlyMissingDays As ucrNud
    Friend WithEvents ucrNudAnnualMissingDays As ucrNud
    Friend WithEvents ucrMultipleInputBaseRange As ucrMultipleInput
    Friend WithEvents lblBaseRange As Label
    Friend WithEvents ucrChkCenterMean As ucrCheck
    Friend WithEvents ucrChkSpellDISpanYear As ucrCheck
    Friend WithEvents ucrChkNHemisphere As ucrCheck
    Friend WithEvents ucrChkMaxSpellSpanYears As ucrCheck
    Friend WithEvents ucrChkPrecExceed10mm As ucrCheck
    Friend WithEvents ucrChkMaxDrySpell As ucrCheck
    Friend WithEvents ucrChkPrecExceedSpecifiedA As ucrCheck
    Friend WithEvents ucrChkPrecExceed20mm As ucrCheck
    Friend WithEvents ucrChkTotalDailyPrec As ucrCheck
    Friend WithEvents ucrChkPrecExceed99Percent As ucrCheck
    Friend WithEvents ucrChkPrecExceed95Percent As ucrCheck
    Friend WithEvents ucrChkMaxWetSpell As ucrCheck
    Friend WithEvents ucrChkColdSpellDI As ucrCheck
    Friend WithEvents ucrChkSimplePrecII As ucrCheck
    Friend WithEvents ucrChkWarmSpellDI As ucrCheck
    Friend WithEvents ucrChkMonthlyMax5dayPrec As ucrCheck
    Friend WithEvents ucrChkMonthlyMax1dayPrec As ucrCheck
    Friend WithEvents ucrChkMeanDiurnalTempRange As ucrCheck
    Friend WithEvents ucrChkSummerDays As ucrCheck
    Friend WithEvents ucrChkIcingDays As ucrCheck
    Friend WithEvents ucrChkTropicalNights As ucrCheck
    Friend WithEvents ucrChkGrowingSeasonLength As ucrCheck
    Friend WithEvents ucrChkMonthlyMaxDailyTMax As ucrCheck
    Friend WithEvents ucrChkTmaxAbove90Percent As ucrCheck
    Friend WithEvents ucrChkTminAbove90Percent As ucrCheck
    Friend WithEvents ucrChkTmaxBelow10Percent As ucrCheck
    Friend WithEvents ucrChkTminBelow10Percent As ucrCheck
    Friend WithEvents ucrChkMonthlyMinDailyTMin As ucrCheck
    Friend WithEvents ucrChkMonthlyMinDailyTMax As ucrCheck
    Friend WithEvents ucrChkMonthlyMaxDailyTMin As ucrCheck
    Friend WithEvents ucrChkFrostDays As ucrCheck
    Friend WithEvents ucrChkSave As ucrCheck
End Class