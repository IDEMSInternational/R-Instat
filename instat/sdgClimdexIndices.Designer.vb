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
        Me.chkFrostDays = New System.Windows.Forms.CheckBox()
        Me.chkTropicalNights = New System.Windows.Forms.CheckBox()
        Me.chkIcingDays = New System.Windows.Forms.CheckBox()
        Me.chkSummerDays = New System.Windows.Forms.CheckBox()
        Me.panIndices = New System.Windows.Forms.Panel()
        Me.chkPrecExceed99Percent = New System.Windows.Forms.CheckBox()
        Me.chkMaxWetSpell = New System.Windows.Forms.CheckBox()
        Me.chkPrecExceedSpecifiedA = New System.Windows.Forms.CheckBox()
        Me.chkMonthlyMax5dayPrec = New System.Windows.Forms.CheckBox()
        Me.chkTmaxAbove90Percent = New System.Windows.Forms.CheckBox()
        Me.chkTminAbove90Percent = New System.Windows.Forms.CheckBox()
        Me.chkPrecExceed95Percent = New System.Windows.Forms.CheckBox()
        Me.chkMonthlyMinDailyTMin = New System.Windows.Forms.CheckBox()
        Me.chkMonthlyMaxDailyTMax = New System.Windows.Forms.CheckBox()
        Me.chkMaxDrySpell = New System.Windows.Forms.CheckBox()
        Me.chkPrecExceed20mm = New System.Windows.Forms.CheckBox()
        Me.chkSimplePrecII = New System.Windows.Forms.CheckBox()
        Me.chkTotalDailyPrec = New System.Windows.Forms.CheckBox()
        Me.chkColdSpellDI = New System.Windows.Forms.CheckBox()
        Me.chkTmaxBelow10Percent = New System.Windows.Forms.CheckBox()
        Me.chkTminBelow10Percent = New System.Windows.Forms.CheckBox()
        Me.chkMonthlyMinDailyTMax = New System.Windows.Forms.CheckBox()
        Me.chkPrecExceed10mm = New System.Windows.Forms.CheckBox()
        Me.chkMonthlyMax1dayPrec = New System.Windows.Forms.CheckBox()
        Me.chkMeanDiurnalTempRange = New System.Windows.Forms.CheckBox()
        Me.chkWarmSpellDI = New System.Windows.Forms.CheckBox()
        Me.chkMonthlyMaxDailyTMin = New System.Windows.Forms.CheckBox()
        Me.chkGrowingSeasonLength = New System.Windows.Forms.CheckBox()
        Me.ttClimdexIndices = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpClimdexIndices = New System.Windows.Forms.GroupBox()
        Me.ucrButtonsClimdexIndices = New instat.ucrButtonsSubdialogue()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.nudThreshold = New System.Windows.Forms.NumericUpDown()
        Me.chkCenterMean = New System.Windows.Forms.CheckBox()
        Me.chkMaxSpellSpanYears = New System.Windows.Forms.CheckBox()
        Me.chkSpellDISpanYear = New System.Windows.Forms.CheckBox()
        Me.panIndices.SuspendLayout()
        Me.grpClimdexIndices.SuspendLayout()
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkFrostDays
        '
        Me.chkFrostDays.AutoSize = True
        Me.chkFrostDays.Location = New System.Drawing.Point(18, 8)
        Me.chkFrostDays.Name = "chkFrostDays"
        Me.chkFrostDays.Size = New System.Drawing.Size(76, 17)
        Me.chkFrostDays.TabIndex = 0
        Me.chkFrostDays.Tag = "Frost_Days"
        Me.chkFrostDays.Text = "Frost Days"
        Me.chkFrostDays.UseVisualStyleBackColor = True
        '
        'chkTropicalNights
        '
        Me.chkTropicalNights.AutoSize = True
        Me.chkTropicalNights.Location = New System.Drawing.Point(18, 62)
        Me.chkTropicalNights.Name = "chkTropicalNights"
        Me.chkTropicalNights.Size = New System.Drawing.Size(97, 17)
        Me.chkTropicalNights.TabIndex = 3
        Me.chkTropicalNights.Tag = "Tropical_Nights"
        Me.chkTropicalNights.Text = "Tropical Nights"
        Me.chkTropicalNights.UseVisualStyleBackColor = True
        '
        'chkIcingDays
        '
        Me.chkIcingDays.AutoSize = True
        Me.chkIcingDays.Location = New System.Drawing.Point(18, 44)
        Me.chkIcingDays.Name = "chkIcingDays"
        Me.chkIcingDays.Size = New System.Drawing.Size(76, 17)
        Me.chkIcingDays.TabIndex = 2
        Me.chkIcingDays.Tag = "Icing_Days"
        Me.chkIcingDays.Text = "Icing Days"
        Me.chkIcingDays.UseVisualStyleBackColor = True
        '
        'chkSummerDays
        '
        Me.chkSummerDays.AutoSize = True
        Me.chkSummerDays.Location = New System.Drawing.Point(18, 26)
        Me.chkSummerDays.Name = "chkSummerDays"
        Me.chkSummerDays.Size = New System.Drawing.Size(91, 17)
        Me.chkSummerDays.TabIndex = 1
        Me.chkSummerDays.Tag = "Summer_Days"
        Me.chkSummerDays.Text = "Summer Days"
        Me.chkSummerDays.UseVisualStyleBackColor = True
        '
        'panIndices
        '
        Me.panIndices.AutoScroll = True
        Me.panIndices.Controls.Add(Me.chkPrecExceed99Percent)
        Me.panIndices.Controls.Add(Me.chkMaxWetSpell)
        Me.panIndices.Controls.Add(Me.chkPrecExceedSpecifiedA)
        Me.panIndices.Controls.Add(Me.chkMonthlyMax5dayPrec)
        Me.panIndices.Controls.Add(Me.chkTmaxAbove90Percent)
        Me.panIndices.Controls.Add(Me.chkTminAbove90Percent)
        Me.panIndices.Controls.Add(Me.chkPrecExceed95Percent)
        Me.panIndices.Controls.Add(Me.chkMonthlyMinDailyTMin)
        Me.panIndices.Controls.Add(Me.chkMonthlyMaxDailyTMax)
        Me.panIndices.Controls.Add(Me.chkMaxDrySpell)
        Me.panIndices.Controls.Add(Me.chkPrecExceed20mm)
        Me.panIndices.Controls.Add(Me.chkSimplePrecII)
        Me.panIndices.Controls.Add(Me.chkTotalDailyPrec)
        Me.panIndices.Controls.Add(Me.chkColdSpellDI)
        Me.panIndices.Controls.Add(Me.chkTmaxBelow10Percent)
        Me.panIndices.Controls.Add(Me.chkTminBelow10Percent)
        Me.panIndices.Controls.Add(Me.chkMonthlyMinDailyTMax)
        Me.panIndices.Controls.Add(Me.chkPrecExceed10mm)
        Me.panIndices.Controls.Add(Me.chkMonthlyMax1dayPrec)
        Me.panIndices.Controls.Add(Me.chkMeanDiurnalTempRange)
        Me.panIndices.Controls.Add(Me.chkWarmSpellDI)
        Me.panIndices.Controls.Add(Me.chkMonthlyMaxDailyTMin)
        Me.panIndices.Controls.Add(Me.chkGrowingSeasonLength)
        Me.panIndices.Controls.Add(Me.chkFrostDays)
        Me.panIndices.Controls.Add(Me.chkIcingDays)
        Me.panIndices.Controls.Add(Me.chkSummerDays)
        Me.panIndices.Controls.Add(Me.chkTropicalNights)
        Me.panIndices.Location = New System.Drawing.Point(8, 21)
        Me.panIndices.Name = "panIndices"
        Me.panIndices.Size = New System.Drawing.Size(354, 130)
        Me.panIndices.TabIndex = 0
        '
        'chkPrecExceed99Percent
        '
        Me.chkPrecExceed99Percent.AutoSize = True
        Me.chkPrecExceed99Percent.Location = New System.Drawing.Point(18, 456)
        Me.chkPrecExceed99Percent.Name = "chkPrecExceed99Percent"
        Me.chkPrecExceed99Percent.Size = New System.Drawing.Size(317, 17)
        Me.chkPrecExceed99Percent.TabIndex = 25
        Me.chkPrecExceed99Percent.Tag = "Total_Daily_Precipitation_Exceeding_99th_Percentile_Threshold "
        Me.chkPrecExceed99Percent.Text = "Total Daily Precipitation Exceeding 99th Percentile Threshold "
        Me.chkPrecExceed99Percent.UseVisualStyleBackColor = True
        '
        'chkMaxWetSpell
        '
        Me.chkMaxWetSpell.AutoSize = True
        Me.chkMaxWetSpell.Location = New System.Drawing.Point(18, 422)
        Me.chkMaxWetSpell.Name = "chkMaxWetSpell"
        Me.chkMaxWetSpell.Size = New System.Drawing.Size(170, 17)
        Me.chkMaxWetSpell.TabIndex = 23
        Me.chkMaxWetSpell.Tag = "Maximum_Length_of_Wet_Spell"
        Me.chkMaxWetSpell.Text = "Maximum Length of Wet Spell "
        Me.chkMaxWetSpell.UseVisualStyleBackColor = True
        '
        'chkPrecExceedSpecifiedA
        '
        Me.chkPrecExceedSpecifiedA.AutoSize = True
        Me.chkPrecExceedSpecifiedA.Location = New System.Drawing.Point(18, 388)
        Me.chkPrecExceedSpecifiedA.Name = "chkPrecExceedSpecifiedA"
        Me.chkPrecExceedSpecifiedA.Size = New System.Drawing.Size(276, 17)
        Me.chkPrecExceedSpecifiedA.TabIndex = 21
        Me.chkPrecExceedSpecifiedA.Tag = "Precipitation_Exceeding_a_Specified_Amount_Per_Day"
        Me.chkPrecExceedSpecifiedA.Text = "Precipitation Exceeding  a Specified Amount Per Day"
        Me.chkPrecExceedSpecifiedA.UseVisualStyleBackColor = True
        '
        'chkMonthlyMax5dayPrec
        '
        Me.chkMonthlyMax5dayPrec.AutoSize = True
        Me.chkMonthlyMax5dayPrec.Location = New System.Drawing.Point(18, 314)
        Me.chkMonthlyMax5dayPrec.Name = "chkMonthlyMax5dayPrec"
        Me.chkMonthlyMax5dayPrec.Size = New System.Drawing.Size(265, 17)
        Me.chkMonthlyMax5dayPrec.TabIndex = 17
        Me.chkMonthlyMax5dayPrec.Tag = "Monthly_Maximum_Consecutive_5-day_Precipitation"
        Me.chkMonthlyMax5dayPrec.Text = "Monthly Maximum Consecutive 5-day Precipitation "
        Me.chkMonthlyMax5dayPrec.UseVisualStyleBackColor = True
        '
        'chkTmaxAbove90Percent
        '
        Me.chkTmaxAbove90Percent.AutoSize = True
        Me.chkTmaxAbove90Percent.Location = New System.Drawing.Point(18, 225)
        Me.chkTmaxAbove90Percent.Name = "chkTmaxAbove90Percent"
        Me.chkTmaxAbove90Percent.Size = New System.Drawing.Size(302, 17)
        Me.chkTmaxAbove90Percent.TabIndex = 12
        Me.chkTmaxAbove90Percent.Tag = "Percentage_of_Days_When_Tmax_is_Above_90th_Percentile"
        Me.chkTmaxAbove90Percent.Text = "Percentage of Days When Tmax is Above 90th Percentile "
        Me.chkTmaxAbove90Percent.UseVisualStyleBackColor = True
        '
        'chkTminAbove90Percent
        '
        Me.chkTminAbove90Percent.AutoSize = True
        Me.chkTminAbove90Percent.Location = New System.Drawing.Point(18, 207)
        Me.chkTminAbove90Percent.Name = "chkTminAbove90Percent"
        Me.chkTminAbove90Percent.Size = New System.Drawing.Size(299, 17)
        Me.chkTminAbove90Percent.TabIndex = 11
        Me.chkTminAbove90Percent.Tag = "Percentage_of_Days_When_Tmin_is_above_90th_Percentile"
        Me.chkTminAbove90Percent.Text = "Percentage of Days When Tmin is Above 90th Percentile "
        Me.chkTminAbove90Percent.UseVisualStyleBackColor = True
        '
        'chkPrecExceed95Percent
        '
        Me.chkPrecExceed95Percent.AutoSize = True
        Me.chkPrecExceed95Percent.Location = New System.Drawing.Point(18, 438)
        Me.chkPrecExceed95Percent.Name = "chkPrecExceed95Percent"
        Me.chkPrecExceed95Percent.Size = New System.Drawing.Size(317, 17)
        Me.chkPrecExceed95Percent.TabIndex = 24
        Me.chkPrecExceed95Percent.Tag = "Total_Daily_Precipitation_Exceeding_95th_Percentile_Threshold "
        Me.chkPrecExceed95Percent.Text = "Total Daily Precipitation Exceeding 95th Percentile Threshold "
        Me.chkPrecExceed95Percent.UseVisualStyleBackColor = True
        '
        'chkMonthlyMinDailyTMin
        '
        Me.chkMonthlyMinDailyTMin.AutoSize = True
        Me.chkMonthlyMinDailyTMin.Location = New System.Drawing.Point(18, 152)
        Me.chkMonthlyMinDailyTMin.Name = "chkMonthlyMinDailyTMin"
        Me.chkMonthlyMinDailyTMin.Size = New System.Drawing.Size(255, 17)
        Me.chkMonthlyMinDailyTMin.TabIndex = 8
        Me.chkMonthlyMinDailyTMin.Tag = "Monthly_Minimum_of_Daily_Minimum_Temperature"
        Me.chkMonthlyMinDailyTMin.Text = "Monthly Minimum of Daily Minimum Temperature "
        Me.chkMonthlyMinDailyTMin.UseVisualStyleBackColor = True
        '
        'chkMonthlyMaxDailyTMax
        '
        Me.chkMonthlyMaxDailyTMax.AutoSize = True
        Me.chkMonthlyMaxDailyTMax.Location = New System.Drawing.Point(18, 98)
        Me.chkMonthlyMaxDailyTMax.Name = "chkMonthlyMaxDailyTMax"
        Me.chkMonthlyMaxDailyTMax.Size = New System.Drawing.Size(261, 17)
        Me.chkMonthlyMaxDailyTMax.TabIndex = 5
        Me.chkMonthlyMaxDailyTMax.Tag = "Monthly_Maximum_of_Daily_Maximum_Temperature "
        Me.chkMonthlyMaxDailyTMax.Text = "Monthly Maximum of Daily Maximum Temperature "
        Me.chkMonthlyMaxDailyTMax.UseVisualStyleBackColor = True
        '
        'chkMaxDrySpell
        '
        Me.chkMaxDrySpell.AutoSize = True
        Me.chkMaxDrySpell.Location = New System.Drawing.Point(18, 404)
        Me.chkMaxDrySpell.Name = "chkMaxDrySpell"
        Me.chkMaxDrySpell.Size = New System.Drawing.Size(166, 17)
        Me.chkMaxDrySpell.TabIndex = 22
        Me.chkMaxDrySpell.Tag = "Maximum_Length_of_Dry_Spell"
        Me.chkMaxDrySpell.Text = "Maximum Length of Dry Spell "
        Me.chkMaxDrySpell.UseVisualStyleBackColor = True
        '
        'chkPrecExceed20mm
        '
        Me.chkPrecExceed20mm.AutoSize = True
        Me.chkPrecExceed20mm.Location = New System.Drawing.Point(18, 370)
        Me.chkPrecExceed20mm.Name = "chkPrecExceed20mm"
        Me.chkPrecExceed20mm.Size = New System.Drawing.Size(212, 17)
        Me.chkPrecExceed20mm.TabIndex = 20
        Me.chkPrecExceed20mm.Tag = "Precipitation_Exceeding_20mm_Per_Day "
        Me.chkPrecExceed20mm.Text = "Precipitation Exceeding 20mm Per Day "
        Me.chkPrecExceed20mm.UseVisualStyleBackColor = True
        '
        'chkSimplePrecII
        '
        Me.chkSimplePrecII.AutoSize = True
        Me.chkSimplePrecII.Location = New System.Drawing.Point(18, 332)
        Me.chkSimplePrecII.Name = "chkSimplePrecII"
        Me.chkSimplePrecII.Size = New System.Drawing.Size(189, 17)
        Me.chkSimplePrecII.TabIndex = 18
        Me.chkSimplePrecII.Tag = "Simple_Precipitation_Intensity_Index"
        Me.chkSimplePrecII.Text = "Simple Precipitation Intensity Index"
        Me.chkSimplePrecII.UseVisualStyleBackColor = True
        '
        'chkTotalDailyPrec
        '
        Me.chkTotalDailyPrec.AutoSize = True
        Me.chkTotalDailyPrec.Location = New System.Drawing.Point(18, 472)
        Me.chkTotalDailyPrec.Name = "chkTotalDailyPrec"
        Me.chkTotalDailyPrec.Size = New System.Drawing.Size(137, 17)
        Me.chkTotalDailyPrec.TabIndex = 26
        Me.chkTotalDailyPrec.Tag = "Total_Daily_Precipitation"
        Me.chkTotalDailyPrec.Text = "Total Daily Precipitation"
        Me.chkTotalDailyPrec.UseVisualStyleBackColor = True
        '
        'chkColdSpellDI
        '
        Me.chkColdSpellDI.AutoSize = True
        Me.chkColdSpellDI.Location = New System.Drawing.Point(18, 260)
        Me.chkColdSpellDI.Name = "chkColdSpellDI"
        Me.chkColdSpellDI.Size = New System.Drawing.Size(148, 17)
        Me.chkColdSpellDI.TabIndex = 14
        Me.chkColdSpellDI.Tag = "Cold_Spell_Duration_Index "
        Me.chkColdSpellDI.Text = "Cold Spell Duration Index "
        Me.chkColdSpellDI.UseVisualStyleBackColor = True
        '
        'chkTmaxBelow10Percent
        '
        Me.chkTmaxBelow10Percent.AutoSize = True
        Me.chkTmaxBelow10Percent.Location = New System.Drawing.Point(18, 188)
        Me.chkTmaxBelow10Percent.Name = "chkTmaxBelow10Percent"
        Me.chkTmaxBelow10Percent.Size = New System.Drawing.Size(300, 17)
        Me.chkTmaxBelow10Percent.TabIndex = 10
        Me.chkTmaxBelow10Percent.Tag = "Percentage_of_Days_When_Tmax_is_Below_10th_Percentile"
        Me.chkTmaxBelow10Percent.Text = "Percentage of Days When Tmax is Below 10th Percentile "
        Me.chkTmaxBelow10Percent.UseVisualStyleBackColor = True
        '
        'chkTminBelow10Percent
        '
        Me.chkTminBelow10Percent.AutoSize = True
        Me.chkTminBelow10Percent.Location = New System.Drawing.Point(18, 170)
        Me.chkTminBelow10Percent.Name = "chkTminBelow10Percent"
        Me.chkTminBelow10Percent.Size = New System.Drawing.Size(297, 17)
        Me.chkTminBelow10Percent.TabIndex = 9
        Me.chkTminBelow10Percent.Tag = "Percentage_of_Days_When_Tmin_is_Below_10th_Percentile"
        Me.chkTminBelow10Percent.Text = "Percentage of Days When Tmin is Below 10th Percentile "
        Me.chkTminBelow10Percent.UseVisualStyleBackColor = True
        '
        'chkMonthlyMinDailyTMax
        '
        Me.chkMonthlyMinDailyTMax.AutoSize = True
        Me.chkMonthlyMinDailyTMax.Location = New System.Drawing.Point(18, 134)
        Me.chkMonthlyMinDailyTMax.Name = "chkMonthlyMinDailyTMax"
        Me.chkMonthlyMinDailyTMax.Size = New System.Drawing.Size(258, 17)
        Me.chkMonthlyMinDailyTMax.TabIndex = 7
        Me.chkMonthlyMinDailyTMax.Tag = "Monthly_Minimum_of_Daily_Maximum_Temperature "
        Me.chkMonthlyMinDailyTMax.Text = "Monthly Minimum of Daily Maximum Temperature "
        Me.chkMonthlyMinDailyTMax.UseVisualStyleBackColor = True
        '
        'chkPrecExceed10mm
        '
        Me.chkPrecExceed10mm.AutoSize = True
        Me.chkPrecExceed10mm.Location = New System.Drawing.Point(18, 350)
        Me.chkPrecExceed10mm.Name = "chkPrecExceed10mm"
        Me.chkPrecExceed10mm.Size = New System.Drawing.Size(212, 17)
        Me.chkPrecExceed10mm.TabIndex = 19
        Me.chkPrecExceed10mm.Tag = "Precipitation_Exceeding_10mm_Per_Day "
        Me.chkPrecExceed10mm.Text = "Precipitation Exceeding 10mm Per Day "
        Me.chkPrecExceed10mm.UseVisualStyleBackColor = True
        '
        'chkMonthlyMax1dayPrec
        '
        Me.chkMonthlyMax1dayPrec.AutoSize = True
        Me.chkMonthlyMax1dayPrec.Location = New System.Drawing.Point(18, 296)
        Me.chkMonthlyMax1dayPrec.Name = "chkMonthlyMax1dayPrec"
        Me.chkMonthlyMax1dayPrec.Size = New System.Drawing.Size(203, 17)
        Me.chkMonthlyMax1dayPrec.TabIndex = 16
        Me.chkMonthlyMax1dayPrec.Tag = "Monthly_Maximum_1-day_Precipitation"
        Me.chkMonthlyMax1dayPrec.Text = "Monthly Maximum 1-day Precipitation "
        Me.chkMonthlyMax1dayPrec.UseVisualStyleBackColor = True
        '
        'chkMeanDiurnalTempRange
        '
        Me.chkMeanDiurnalTempRange.AutoSize = True
        Me.chkMeanDiurnalTempRange.Location = New System.Drawing.Point(18, 278)
        Me.chkMeanDiurnalTempRange.Name = "chkMeanDiurnalTempRange"
        Me.chkMeanDiurnalTempRange.Size = New System.Drawing.Size(187, 17)
        Me.chkMeanDiurnalTempRange.TabIndex = 15
        Me.chkMeanDiurnalTempRange.Tag = "Mean_Diurnal_Temperature_Range"
        Me.chkMeanDiurnalTempRange.Text = "Mean Diurnal Temperature Range"
        Me.chkMeanDiurnalTempRange.UseVisualStyleBackColor = True
        '
        'chkWarmSpellDI
        '
        Me.chkWarmSpellDI.AutoSize = True
        Me.chkWarmSpellDI.Location = New System.Drawing.Point(18, 242)
        Me.chkWarmSpellDI.Name = "chkWarmSpellDI"
        Me.chkWarmSpellDI.Size = New System.Drawing.Size(155, 17)
        Me.chkWarmSpellDI.TabIndex = 13
        Me.chkWarmSpellDI.Tag = "Warm_Spell_Duration_Index "
        Me.chkWarmSpellDI.Text = "Warm Spell Duration Index "
        Me.chkWarmSpellDI.UseVisualStyleBackColor = True
        '
        'chkMonthlyMaxDailyTMin
        '
        Me.chkMonthlyMaxDailyTMin.AutoSize = True
        Me.chkMonthlyMaxDailyTMin.Location = New System.Drawing.Point(18, 116)
        Me.chkMonthlyMaxDailyTMin.Name = "chkMonthlyMaxDailyTMin"
        Me.chkMonthlyMaxDailyTMin.Size = New System.Drawing.Size(255, 17)
        Me.chkMonthlyMaxDailyTMin.TabIndex = 6
        Me.chkMonthlyMaxDailyTMin.Tag = "Monthly_Maximum_of_Daily_Minimum_Temperature"
        Me.chkMonthlyMaxDailyTMin.Text = "Monthly Maximum of Daily Minimum Temperature"
        Me.chkMonthlyMaxDailyTMin.UseVisualStyleBackColor = True
        '
        'chkGrowingSeasonLength
        '
        Me.chkGrowingSeasonLength.AutoSize = True
        Me.chkGrowingSeasonLength.Location = New System.Drawing.Point(18, 80)
        Me.chkGrowingSeasonLength.Name = "chkGrowingSeasonLength"
        Me.chkGrowingSeasonLength.Size = New System.Drawing.Size(140, 17)
        Me.chkGrowingSeasonLength.TabIndex = 4
        Me.chkGrowingSeasonLength.Tag = "Growing_Season_Length"
        Me.chkGrowingSeasonLength.Text = "Growing Season Length"
        Me.chkGrowingSeasonLength.UseVisualStyleBackColor = True
        '
        'grpClimdexIndices
        '
        Me.grpClimdexIndices.Controls.Add(Me.panIndices)
        Me.grpClimdexIndices.Location = New System.Drawing.Point(12, 11)
        Me.grpClimdexIndices.Name = "grpClimdexIndices"
        Me.grpClimdexIndices.Size = New System.Drawing.Size(377, 165)
        Me.grpClimdexIndices.TabIndex = 0
        Me.grpClimdexIndices.TabStop = False
        Me.grpClimdexIndices.Tag = "Climdex_Indices"
        Me.grpClimdexIndices.Text = "Climdex Indices"
        '
        'ucrButtonsClimdexIndices
        '
        Me.ucrButtonsClimdexIndices.Location = New System.Drawing.Point(119, 243)
        Me.ucrButtonsClimdexIndices.Name = "ucrButtonsClimdexIndices"
        Me.ucrButtonsClimdexIndices.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsClimdexIndices.TabIndex = 6
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(12, 187)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(54, 13)
        Me.lblThreshold.TabIndex = 1
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Threshold"
        '
        'nudThreshold
        '
        Me.nudThreshold.DecimalPlaces = 2
        Me.nudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudThreshold.Location = New System.Drawing.Point(80, 184)
        Me.nudThreshold.Name = "nudThreshold"
        Me.nudThreshold.Size = New System.Drawing.Size(42, 20)
        Me.nudThreshold.TabIndex = 2
        Me.nudThreshold.Value = New Decimal(New Integer() {100, 0, 0, 131072})
        '
        'chkCenterMean
        '
        Me.chkCenterMean.AutoSize = True
        Me.chkCenterMean.Location = New System.Drawing.Point(12, 216)
        Me.chkCenterMean.Name = "chkCenterMean"
        Me.chkCenterMean.Size = New System.Drawing.Size(147, 17)
        Me.chkCenterMean.TabIndex = 4
        Me.chkCenterMean.Tag = "Center_Mean_ on_Last_Day"
        Me.chkCenterMean.Text = "Center Mean on Last Day"
        Me.chkCenterMean.UseVisualStyleBackColor = True
        '
        'chkMaxSpellSpanYears
        '
        Me.chkMaxSpellSpanYears.AutoSize = True
        Me.chkMaxSpellSpanYears.Location = New System.Drawing.Point(199, 185)
        Me.chkMaxSpellSpanYears.Name = "chkMaxSpellSpanYears"
        Me.chkMaxSpellSpanYears.Size = New System.Drawing.Size(190, 17)
        Me.chkMaxSpellSpanYears.TabIndex = 3
        Me.chkMaxSpellSpanYears.Tag = "Maximum_Spell_Length_Span_Years"
        Me.chkMaxSpellSpanYears.Text = "Maximum Spell Length Span Years"
        Me.chkMaxSpellSpanYears.UseVisualStyleBackColor = True
        '
        'chkSpellDISpanYear
        '
        Me.chkSpellDISpanYear.AutoSize = True
        Me.chkSpellDISpanYear.Location = New System.Drawing.Point(199, 216)
        Me.chkSpellDISpanYear.Name = "chkSpellDISpanYear"
        Me.chkSpellDISpanYear.Size = New System.Drawing.Size(179, 17)
        Me.chkSpellDISpanYear.TabIndex = 5
        Me.chkSpellDISpanYear.Tag = "Spell_Duration_Index_Span_Years"
        Me.chkSpellDISpanYear.Text = "Spell Duration Index Span Years"
        Me.chkSpellDISpanYear.UseVisualStyleBackColor = True
        '
        'sdgClimdexIndices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 274)
        Me.Controls.Add(Me.chkSpellDISpanYear)
        Me.Controls.Add(Me.chkMaxSpellSpanYears)
        Me.Controls.Add(Me.chkCenterMean)
        Me.Controls.Add(Me.nudThreshold)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.grpClimdexIndices)
        Me.Controls.Add(Me.ucrButtonsClimdexIndices)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgClimdexIndices"
        Me.Tag = "Climdex_Options"
        Me.Text = "Climdex Options"
        Me.panIndices.ResumeLayout(False)
        Me.panIndices.PerformLayout()
        Me.grpClimdexIndices.ResumeLayout(False)
        CType(Me.nudThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrButtonsClimdexIndices As ucrButtonsSubdialogue
    Friend WithEvents chkFrostDays As CheckBox
    Friend WithEvents chkTropicalNights As CheckBox
    Friend WithEvents chkIcingDays As CheckBox
    Friend WithEvents chkSummerDays As CheckBox
    Friend WithEvents panIndices As Panel
    Friend WithEvents ttClimdexIndices As ToolTip
    Friend WithEvents chkPrecExceed95Percent As CheckBox
    Friend WithEvents chkMonthlyMinDailyTMin As CheckBox
    Friend WithEvents chkMonthlyMaxDailyTMax As CheckBox
    Friend WithEvents chkMaxDrySpell As CheckBox
    Friend WithEvents chkPrecExceed20mm As CheckBox
    Friend WithEvents chkSimplePrecII As CheckBox
    Friend WithEvents chkTotalDailyPrec As CheckBox
    Friend WithEvents chkColdSpellDI As CheckBox
    Friend WithEvents chkTmaxBelow10Percent As CheckBox
    Friend WithEvents chkTminBelow10Percent As CheckBox
    Friend WithEvents chkMonthlyMinDailyTMax As CheckBox
    Friend WithEvents chkPrecExceed10mm As CheckBox
    Friend WithEvents chkMonthlyMax1dayPrec As CheckBox
    Friend WithEvents chkMeanDiurnalTempRange As CheckBox
    Friend WithEvents chkWarmSpellDI As CheckBox
    Friend WithEvents chkMonthlyMaxDailyTMin As CheckBox
    Friend WithEvents chkGrowingSeasonLength As CheckBox
    Friend WithEvents chkTmaxAbove90Percent As CheckBox
    Friend WithEvents chkTminAbove90Percent As CheckBox
    Friend WithEvents chkMonthlyMax5dayPrec As CheckBox
    Friend WithEvents chkPrecExceedSpecifiedA As CheckBox
    Friend WithEvents chkMaxWetSpell As CheckBox
    Friend WithEvents chkPrecExceed99Percent As CheckBox
    Friend WithEvents grpClimdexIndices As GroupBox
    Friend WithEvents lblThreshold As Label
    Friend WithEvents nudThreshold As NumericUpDown
    Friend WithEvents chkCenterMean As CheckBox
    Friend WithEvents chkMaxSpellSpanYears As CheckBox
    Friend WithEvents chkSpellDISpanYear As CheckBox
End Class
