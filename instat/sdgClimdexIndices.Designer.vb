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
        Me.panAnnualIndices = New System.Windows.Forms.Panel()
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
        Me.ucrChkSummerDays = New instat.ucrCheck()
        Me.ucrChkIcingDays = New instat.ucrCheck()
        Me.ucrChkTropicalNights = New instat.ucrCheck()
        Me.ucrChkGrowingSeasonLength = New instat.ucrCheck()
        Me.ucrChkFrostDays = New instat.ucrCheck()
        Me.lbl14 = New System.Windows.Forms.Label()
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
        Me.tbAnnualIndices = New System.Windows.Forms.TabPage()
        Me.ucrChkSave = New instat.ucrCheck()
        Me.ucrButtonsClimdexIndices = New instat.ucrButtonsSubdialogue()
        Me.tbAnnualMonthly = New System.Windows.Forms.TabPage()
        Me.panAnnualMonthlyIndices = New System.Windows.Forms.Panel()
        Me.ucrChkMonthlyMaxDailyTMax = New instat.ucrCheck()
        Me.ucrChkMonthlyMaxDailyTMin = New instat.ucrCheck()
        Me.ucrChkMonthlyMinDailyTMin = New instat.ucrCheck()
        Me.ucrChkMonthlyMinDailyTMax = New instat.ucrCheck()
        Me.ucrChkTmaxAbove90Percent = New instat.ucrCheck()
        Me.ucrChkTminAbove90Percent = New instat.ucrCheck()
        Me.ucrChkTmaxBelow10Percent = New instat.ucrCheck()
        Me.ucrChkTminBelow10Percent = New instat.ucrCheck()
        Me.ucrChkMeanDiurnalTempRange = New instat.ucrCheck()
        Me.ucrChkMonthlyMax5dayPrec = New instat.ucrCheck()
        Me.ucrChkMonthlyMax1dayPrec = New instat.ucrCheck()
        Me.panAnnualIndices.SuspendLayout()
        Me.tbClimdex.SuspendLayout()
        Me.TbSettings.SuspendLayout()
        Me.grpMaxMissingDays.SuspendLayout()
        Me.tbAnnualIndices.SuspendLayout()
        Me.tbAnnualMonthly.SuspendLayout()
        Me.panAnnualMonthlyIndices.SuspendLayout()
        Me.SuspendLayout()
        '
        'panAnnualIndices
        '
        Me.panAnnualIndices.AutoScroll = True
        Me.panAnnualIndices.Controls.Add(Me.ucrChkPrecExceed10mm)
        Me.panAnnualIndices.Controls.Add(Me.ucrChkMaxDrySpell)
        Me.panAnnualIndices.Controls.Add(Me.ucrChkPrecExceedSpecifiedA)
        Me.panAnnualIndices.Controls.Add(Me.ucrChkPrecExceed20mm)
        Me.panAnnualIndices.Controls.Add(Me.ucrChkTotalDailyPrec)
        Me.panAnnualIndices.Controls.Add(Me.ucrChkPrecExceed99Percent)
        Me.panAnnualIndices.Controls.Add(Me.ucrChkPrecExceed95Percent)
        Me.panAnnualIndices.Controls.Add(Me.ucrChkMaxWetSpell)
        Me.panAnnualIndices.Controls.Add(Me.ucrChkColdSpellDI)
        Me.panAnnualIndices.Controls.Add(Me.ucrChkSimplePrecII)
        Me.panAnnualIndices.Controls.Add(Me.ucrChkWarmSpellDI)
        Me.panAnnualIndices.Controls.Add(Me.ucrChkSummerDays)
        Me.panAnnualIndices.Controls.Add(Me.ucrChkIcingDays)
        Me.panAnnualIndices.Controls.Add(Me.ucrChkTropicalNights)
        Me.panAnnualIndices.Controls.Add(Me.ucrChkGrowingSeasonLength)
        Me.panAnnualIndices.Controls.Add(Me.ucrChkFrostDays)
        Me.panAnnualIndices.Controls.Add(Me.lbl14)
        Me.panAnnualIndices.Controls.Add(Me.lbl16)
        Me.panAnnualIndices.Controls.Add(Me.lbl15)
        Me.panAnnualIndices.Controls.Add(Me.lbl6)
        Me.panAnnualIndices.Controls.Add(Me.lbl8)
        Me.panAnnualIndices.Controls.Add(Me.lbl12)
        Me.panAnnualIndices.Controls.Add(Me.lbl9)
        Me.panAnnualIndices.Controls.Add(Me.lbl13)
        Me.panAnnualIndices.Controls.Add(Me.lbl7)
        Me.panAnnualIndices.Controls.Add(Me.lbl11)
        Me.panAnnualIndices.Controls.Add(Me.lbl10)
        Me.panAnnualIndices.Controls.Add(Me.lbl2)
        Me.panAnnualIndices.Controls.Add(Me.lbl3)
        Me.panAnnualIndices.Controls.Add(Me.lbl4)
        Me.panAnnualIndices.Controls.Add(Me.lbl5)
        Me.panAnnualIndices.Controls.Add(Me.lbl1)
        Me.panAnnualIndices.Location = New System.Drawing.Point(6, 6)
        Me.panAnnualIndices.Name = "panAnnualIndices"
        Me.panAnnualIndices.Size = New System.Drawing.Size(462, 262)
        Me.panAnnualIndices.TabIndex = 0
        '
        'ucrChkPrecExceed10mm
        '
        Me.ucrChkPrecExceed10mm.Checked = False
        Me.ucrChkPrecExceed10mm.Location = New System.Drawing.Point(27, 135)
        Me.ucrChkPrecExceed10mm.Name = "ucrChkPrecExceed10mm"
        Me.ucrChkPrecExceed10mm.Size = New System.Drawing.Size(264, 20)
        Me.ucrChkPrecExceed10mm.TabIndex = 83
        '
        'ucrChkMaxDrySpell
        '
        Me.ucrChkMaxDrySpell.Checked = False
        Me.ucrChkMaxDrySpell.Location = New System.Drawing.Point(27, 242)
        Me.ucrChkMaxDrySpell.Name = "ucrChkMaxDrySpell"
        Me.ucrChkMaxDrySpell.Size = New System.Drawing.Size(253, 20)
        Me.ucrChkMaxDrySpell.TabIndex = 82
        '
        'ucrChkPrecExceedSpecifiedA
        '
        Me.ucrChkPrecExceedSpecifiedA.Checked = False
        Me.ucrChkPrecExceedSpecifiedA.Location = New System.Drawing.Point(27, 225)
        Me.ucrChkPrecExceedSpecifiedA.Name = "ucrChkPrecExceedSpecifiedA"
        Me.ucrChkPrecExceedSpecifiedA.Size = New System.Drawing.Size(241, 20)
        Me.ucrChkPrecExceedSpecifiedA.TabIndex = 81
        '
        'ucrChkPrecExceed20mm
        '
        Me.ucrChkPrecExceed20mm.Checked = False
        Me.ucrChkPrecExceed20mm.Location = New System.Drawing.Point(27, 210)
        Me.ucrChkPrecExceed20mm.Name = "ucrChkPrecExceed20mm"
        Me.ucrChkPrecExceed20mm.Size = New System.Drawing.Size(229, 20)
        Me.ucrChkPrecExceed20mm.TabIndex = 80
        '
        'ucrChkTotalDailyPrec
        '
        Me.ucrChkTotalDailyPrec.Checked = False
        Me.ucrChkTotalDailyPrec.Location = New System.Drawing.Point(27, 117)
        Me.ucrChkTotalDailyPrec.Name = "ucrChkTotalDailyPrec"
        Me.ucrChkTotalDailyPrec.Size = New System.Drawing.Size(140, 20)
        Me.ucrChkTotalDailyPrec.TabIndex = 79
        '
        'ucrChkPrecExceed99Percent
        '
        Me.ucrChkPrecExceed99Percent.Checked = False
        Me.ucrChkPrecExceed99Percent.Location = New System.Drawing.Point(25, 96)
        Me.ucrChkPrecExceed99Percent.Name = "ucrChkPrecExceed99Percent"
        Me.ucrChkPrecExceed99Percent.Size = New System.Drawing.Size(241, 20)
        Me.ucrChkPrecExceed99Percent.TabIndex = 78
        '
        'ucrChkPrecExceed95Percent
        '
        Me.ucrChkPrecExceed95Percent.Checked = False
        Me.ucrChkPrecExceed95Percent.Location = New System.Drawing.Point(27, 279)
        Me.ucrChkPrecExceed95Percent.Name = "ucrChkPrecExceed95Percent"
        Me.ucrChkPrecExceed95Percent.Size = New System.Drawing.Size(279, 20)
        Me.ucrChkPrecExceed95Percent.TabIndex = 77
        '
        'ucrChkMaxWetSpell
        '
        Me.ucrChkMaxWetSpell.Checked = False
        Me.ucrChkMaxWetSpell.Location = New System.Drawing.Point(27, 261)
        Me.ucrChkMaxWetSpell.Name = "ucrChkMaxWetSpell"
        Me.ucrChkMaxWetSpell.Size = New System.Drawing.Size(241, 20)
        Me.ucrChkMaxWetSpell.TabIndex = 76
        '
        'ucrChkColdSpellDI
        '
        Me.ucrChkColdSpellDI.Checked = False
        Me.ucrChkColdSpellDI.Location = New System.Drawing.Point(27, 171)
        Me.ucrChkColdSpellDI.Name = "ucrChkColdSpellDI"
        Me.ucrChkColdSpellDI.Size = New System.Drawing.Size(241, 20)
        Me.ucrChkColdSpellDI.TabIndex = 75
        '
        'ucrChkSimplePrecII
        '
        Me.ucrChkSimplePrecII.Checked = False
        Me.ucrChkSimplePrecII.Location = New System.Drawing.Point(25, 188)
        Me.ucrChkSimplePrecII.Name = "ucrChkSimplePrecII"
        Me.ucrChkSimplePrecII.Size = New System.Drawing.Size(241, 20)
        Me.ucrChkSimplePrecII.TabIndex = 74
        '
        'ucrChkWarmSpellDI
        '
        Me.ucrChkWarmSpellDI.Checked = False
        Me.ucrChkWarmSpellDI.Location = New System.Drawing.Point(25, 151)
        Me.ucrChkWarmSpellDI.Name = "ucrChkWarmSpellDI"
        Me.ucrChkWarmSpellDI.Size = New System.Drawing.Size(255, 20)
        Me.ucrChkWarmSpellDI.TabIndex = 73
        '
        'ucrChkSummerDays
        '
        Me.ucrChkSummerDays.Checked = False
        Me.ucrChkSummerDays.Location = New System.Drawing.Point(27, 25)
        Me.ucrChkSummerDays.Name = "ucrChkSummerDays"
        Me.ucrChkSummerDays.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSummerDays.TabIndex = 69
        '
        'ucrChkIcingDays
        '
        Me.ucrChkIcingDays.Checked = False
        Me.ucrChkIcingDays.Location = New System.Drawing.Point(27, 43)
        Me.ucrChkIcingDays.Name = "ucrChkIcingDays"
        Me.ucrChkIcingDays.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkIcingDays.TabIndex = 68
        '
        'ucrChkTropicalNights
        '
        Me.ucrChkTropicalNights.Checked = False
        Me.ucrChkTropicalNights.Location = New System.Drawing.Point(27, 61)
        Me.ucrChkTropicalNights.Name = "ucrChkTropicalNights"
        Me.ucrChkTropicalNights.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkTropicalNights.TabIndex = 67
        '
        'ucrChkGrowingSeasonLength
        '
        Me.ucrChkGrowingSeasonLength.Checked = False
        Me.ucrChkGrowingSeasonLength.Location = New System.Drawing.Point(27, 79)
        Me.ucrChkGrowingSeasonLength.Name = "ucrChkGrowingSeasonLength"
        Me.ucrChkGrowingSeasonLength.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkGrowingSeasonLength.TabIndex = 66
        '
        'ucrChkFrostDays
        '
        Me.ucrChkFrostDays.Checked = False
        Me.ucrChkFrostDays.Location = New System.Drawing.Point(27, 8)
        Me.ucrChkFrostDays.Name = "ucrChkFrostDays"
        Me.ucrChkFrostDays.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFrostDays.TabIndex = 54
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
        Me.tbClimdex.Controls.Add(Me.tbAnnualIndices)
        Me.tbClimdex.Controls.Add(Me.tbAnnualMonthly)
        Me.tbClimdex.Location = New System.Drawing.Point(7, 6)
        Me.tbClimdex.Name = "tbClimdex"
        Me.tbClimdex.SelectedIndex = 0
        Me.tbClimdex.Size = New System.Drawing.Size(476, 320)
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
        Me.TbSettings.Size = New System.Drawing.Size(468, 250)
        Me.TbSettings.TabIndex = 0
        Me.TbSettings.Tag = ""
        Me.TbSettings.Text = "Settings"
        Me.TbSettings.UseVisualStyleBackColor = True
        '
        'ucrChkCenterMean
        '
        Me.ucrChkCenterMean.Checked = False
        Me.ucrChkCenterMean.Location = New System.Drawing.Point(284, 187)
        Me.ucrChkCenterMean.Name = "ucrChkCenterMean"
        Me.ucrChkCenterMean.Size = New System.Drawing.Size(171, 20)
        Me.ucrChkCenterMean.TabIndex = 49
        '
        'ucrChkSpellDISpanYear
        '
        Me.ucrChkSpellDISpanYear.Checked = False
        Me.ucrChkSpellDISpanYear.Location = New System.Drawing.Point(13, 218)
        Me.ucrChkSpellDISpanYear.Name = "ucrChkSpellDISpanYear"
        Me.ucrChkSpellDISpanYear.Size = New System.Drawing.Size(233, 20)
        Me.ucrChkSpellDISpanYear.TabIndex = 48
        '
        'ucrChkNHemisphere
        '
        Me.ucrChkNHemisphere.Checked = False
        Me.ucrChkNHemisphere.Location = New System.Drawing.Point(13, 107)
        Me.ucrChkNHemisphere.Name = "ucrChkNHemisphere"
        Me.ucrChkNHemisphere.Size = New System.Drawing.Size(212, 20)
        Me.ucrChkNHemisphere.TabIndex = 47
        '
        'ucrChkMaxSpellSpanYears
        '
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
        Me.ucrMultipleInputBaseRange.Location = New System.Drawing.Point(13, 23)
        Me.ucrMultipleInputBaseRange.Name = "ucrMultipleInputBaseRange"
        Me.ucrMultipleInputBaseRange.Size = New System.Drawing.Size(150, 29)
        Me.ucrMultipleInputBaseRange.TabIndex = 44
        '
        'ucrNudN
        '
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
        Me.ucrInputFreq.IsReadOnly = False
        Me.ucrInputFreq.Location = New System.Drawing.Point(284, 27)
        Me.ucrInputFreq.Name = "ucrInputFreq"
        Me.ucrInputFreq.Size = New System.Drawing.Size(145, 21)
        Me.ucrInputFreq.TabIndex = 24
        '
        'ucrMultipleInputTempQtiles
        '
        Me.ucrMultipleInputTempQtiles.Location = New System.Drawing.Point(284, 73)
        Me.ucrMultipleInputTempQtiles.Name = "ucrMultipleInputTempQtiles"
        Me.ucrMultipleInputTempQtiles.Size = New System.Drawing.Size(150, 29)
        Me.ucrMultipleInputTempQtiles.TabIndex = 30
        '
        'ucrMultipleInputPrecQtiles
        '
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
        'tbAnnualIndices
        '
        Me.tbAnnualIndices.Controls.Add(Me.panAnnualIndices)
        Me.tbAnnualIndices.Location = New System.Drawing.Point(4, 22)
        Me.tbAnnualIndices.Name = "tbAnnualIndices"
        Me.tbAnnualIndices.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAnnualIndices.Size = New System.Drawing.Size(468, 294)
        Me.tbAnnualIndices.TabIndex = 1
        Me.tbAnnualIndices.Text = "Annual Indices"
        Me.tbAnnualIndices.UseVisualStyleBackColor = True
        '
        'ucrChkSave
        '
        Me.ucrChkSave.Checked = False
        Me.ucrChkSave.Location = New System.Drawing.Point(39, 332)
        Me.ucrChkSave.Name = "ucrChkSave"
        Me.ucrChkSave.Size = New System.Drawing.Size(95, 20)
        Me.ucrChkSave.TabIndex = 51
        '
        'ucrButtonsClimdexIndices
        '
        Me.ucrButtonsClimdexIndices.Location = New System.Drawing.Point(178, 346)
        Me.ucrButtonsClimdexIndices.Name = "ucrButtonsClimdexIndices"
        Me.ucrButtonsClimdexIndices.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsClimdexIndices.TabIndex = 6
        '
        'tbAnnualMonthly
        '
        Me.tbAnnualMonthly.Controls.Add(Me.panAnnualMonthlyIndices)
        Me.tbAnnualMonthly.Location = New System.Drawing.Point(4, 22)
        Me.tbAnnualMonthly.Name = "tbAnnualMonthly"
        Me.tbAnnualMonthly.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAnnualMonthly.Size = New System.Drawing.Size(468, 271)
        Me.tbAnnualMonthly.TabIndex = 2
        Me.tbAnnualMonthly.Text = "Annual/Monthly indices"
        Me.tbAnnualMonthly.UseVisualStyleBackColor = True
        '
        'panAnnualMonthlyIndices
        '
        Me.panAnnualMonthlyIndices.AutoScroll = True
        Me.panAnnualMonthlyIndices.Controls.Add(Me.ucrChkMonthlyMax5dayPrec)
        Me.panAnnualMonthlyIndices.Controls.Add(Me.ucrChkMonthlyMax1dayPrec)
        Me.panAnnualMonthlyIndices.Controls.Add(Me.ucrChkMeanDiurnalTempRange)
        Me.panAnnualMonthlyIndices.Controls.Add(Me.ucrChkTmaxAbove90Percent)
        Me.panAnnualMonthlyIndices.Controls.Add(Me.ucrChkTminAbove90Percent)
        Me.panAnnualMonthlyIndices.Controls.Add(Me.ucrChkTmaxBelow10Percent)
        Me.panAnnualMonthlyIndices.Controls.Add(Me.ucrChkTminBelow10Percent)
        Me.panAnnualMonthlyIndices.Controls.Add(Me.ucrChkMonthlyMinDailyTMin)
        Me.panAnnualMonthlyIndices.Controls.Add(Me.ucrChkMonthlyMinDailyTMax)
        Me.panAnnualMonthlyIndices.Controls.Add(Me.ucrChkMonthlyMaxDailyTMin)
        Me.panAnnualMonthlyIndices.Controls.Add(Me.ucrChkMonthlyMaxDailyTMax)
        Me.panAnnualMonthlyIndices.Location = New System.Drawing.Point(3, 6)
        Me.panAnnualMonthlyIndices.Name = "panAnnualMonthlyIndices"
        Me.panAnnualMonthlyIndices.Size = New System.Drawing.Size(462, 239)
        Me.panAnnualMonthlyIndices.TabIndex = 1
        '
        'ucrChkMonthlyMaxDailyTMax
        '
        Me.ucrChkMonthlyMaxDailyTMax.Checked = False
        Me.ucrChkMonthlyMaxDailyTMax.Location = New System.Drawing.Point(27, 6)
        Me.ucrChkMonthlyMaxDailyTMax.Name = "ucrChkMonthlyMaxDailyTMax"
        Me.ucrChkMonthlyMaxDailyTMax.Size = New System.Drawing.Size(297, 20)
        Me.ucrChkMonthlyMaxDailyTMax.TabIndex = 66
        '
        'ucrChkMonthlyMaxDailyTMin
        '
        Me.ucrChkMonthlyMaxDailyTMin.Checked = False
        Me.ucrChkMonthlyMaxDailyTMin.Location = New System.Drawing.Point(27, 32)
        Me.ucrChkMonthlyMaxDailyTMin.Name = "ucrChkMonthlyMaxDailyTMin"
        Me.ucrChkMonthlyMaxDailyTMin.Size = New System.Drawing.Size(255, 20)
        Me.ucrChkMonthlyMaxDailyTMin.TabIndex = 67
        '
        'ucrChkMonthlyMinDailyTMin
        '
        Me.ucrChkMonthlyMinDailyTMin.Checked = False
        Me.ucrChkMonthlyMinDailyTMin.Location = New System.Drawing.Point(27, 75)
        Me.ucrChkMonthlyMinDailyTMin.Name = "ucrChkMonthlyMinDailyTMin"
        Me.ucrChkMonthlyMinDailyTMin.Size = New System.Drawing.Size(276, 20)
        Me.ucrChkMonthlyMinDailyTMin.TabIndex = 69
        '
        'ucrChkMonthlyMinDailyTMax
        '
        Me.ucrChkMonthlyMinDailyTMax.Checked = False
        Me.ucrChkMonthlyMinDailyTMax.Location = New System.Drawing.Point(27, 49)
        Me.ucrChkMonthlyMinDailyTMax.Name = "ucrChkMonthlyMinDailyTMax"
        Me.ucrChkMonthlyMinDailyTMax.Size = New System.Drawing.Size(255, 20)
        Me.ucrChkMonthlyMinDailyTMax.TabIndex = 68
        '
        'ucrChkTmaxAbove90Percent
        '
        Me.ucrChkTmaxAbove90Percent.Checked = False
        Me.ucrChkTmaxAbove90Percent.Location = New System.Drawing.Point(28, 161)
        Me.ucrChkTmaxAbove90Percent.Name = "ucrChkTmaxAbove90Percent"
        Me.ucrChkTmaxAbove90Percent.Size = New System.Drawing.Size(255, 20)
        Me.ucrChkTmaxAbove90Percent.TabIndex = 73
        '
        'ucrChkTminAbove90Percent
        '
        Me.ucrChkTminAbove90Percent.Checked = False
        Me.ucrChkTminAbove90Percent.Location = New System.Drawing.Point(28, 139)
        Me.ucrChkTminAbove90Percent.Name = "ucrChkTminAbove90Percent"
        Me.ucrChkTminAbove90Percent.Size = New System.Drawing.Size(297, 20)
        Me.ucrChkTminAbove90Percent.TabIndex = 72
        '
        'ucrChkTmaxBelow10Percent
        '
        Me.ucrChkTmaxBelow10Percent.Checked = False
        Me.ucrChkTmaxBelow10Percent.Location = New System.Drawing.Point(28, 120)
        Me.ucrChkTmaxBelow10Percent.Name = "ucrChkTmaxBelow10Percent"
        Me.ucrChkTmaxBelow10Percent.Size = New System.Drawing.Size(300, 20)
        Me.ucrChkTmaxBelow10Percent.TabIndex = 71
        '
        'ucrChkTminBelow10Percent
        '
        Me.ucrChkTminBelow10Percent.Checked = False
        Me.ucrChkTminBelow10Percent.Location = New System.Drawing.Point(28, 101)
        Me.ucrChkTminBelow10Percent.Name = "ucrChkTminBelow10Percent"
        Me.ucrChkTminBelow10Percent.Size = New System.Drawing.Size(302, 20)
        Me.ucrChkTminBelow10Percent.TabIndex = 70
        '
        'ucrChkMeanDiurnalTempRange
        '
        Me.ucrChkMeanDiurnalTempRange.Checked = False
        Me.ucrChkMeanDiurnalTempRange.Location = New System.Drawing.Point(29, 178)
        Me.ucrChkMeanDiurnalTempRange.Name = "ucrChkMeanDiurnalTempRange"
        Me.ucrChkMeanDiurnalTempRange.Size = New System.Drawing.Size(264, 20)
        Me.ucrChkMeanDiurnalTempRange.TabIndex = 74
        '
        'ucrChkMonthlyMax5dayPrec
        '
        Me.ucrChkMonthlyMax5dayPrec.Checked = False
        Me.ucrChkMonthlyMax5dayPrec.Location = New System.Drawing.Point(29, 216)
        Me.ucrChkMonthlyMax5dayPrec.Name = "ucrChkMonthlyMax5dayPrec"
        Me.ucrChkMonthlyMax5dayPrec.Size = New System.Drawing.Size(241, 20)
        Me.ucrChkMonthlyMax5dayPrec.TabIndex = 76
        '
        'ucrChkMonthlyMax1dayPrec
        '
        Me.ucrChkMonthlyMax1dayPrec.Checked = False
        Me.ucrChkMonthlyMax1dayPrec.Location = New System.Drawing.Point(29, 192)
        Me.ucrChkMonthlyMax1dayPrec.Name = "ucrChkMonthlyMax1dayPrec"
        Me.ucrChkMonthlyMax1dayPrec.Size = New System.Drawing.Size(264, 20)
        Me.ucrChkMonthlyMax1dayPrec.TabIndex = 75
        '
        'sdgClimdexIndices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 698)
        Me.Controls.Add(Me.ucrChkSave)
        Me.Controls.Add(Me.tbClimdex)
        Me.Controls.Add(Me.ucrButtonsClimdexIndices)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgClimdexIndices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Indices"
        Me.Text = "Indices"
        Me.panAnnualIndices.ResumeLayout(False)
        Me.panAnnualIndices.PerformLayout()
        Me.tbClimdex.ResumeLayout(False)
        Me.TbSettings.ResumeLayout(False)
        Me.TbSettings.PerformLayout()
        Me.grpMaxMissingDays.ResumeLayout(False)
        Me.grpMaxMissingDays.PerformLayout()
        Me.tbAnnualIndices.ResumeLayout(False)
        Me.tbAnnualMonthly.ResumeLayout(False)
        Me.panAnnualMonthlyIndices.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsClimdexIndices As ucrButtonsSubdialogue
    Friend WithEvents panAnnualIndices As Panel
    Friend WithEvents ttClimdexIndices As ToolTip
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lbl14 As Label
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
    Friend WithEvents tbAnnualIndices As TabPage
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
    Friend WithEvents ucrChkSummerDays As ucrCheck
    Friend WithEvents ucrChkIcingDays As ucrCheck
    Friend WithEvents ucrChkTropicalNights As ucrCheck
    Friend WithEvents ucrChkGrowingSeasonLength As ucrCheck
    Friend WithEvents ucrChkFrostDays As ucrCheck
    Friend WithEvents ucrChkSave As ucrCheck
    Friend WithEvents tbAnnualMonthly As TabPage

    Private Sub ucrChkColdSpellDI_Load(sender As Object, e As EventArgs) Handles ucrChkColdSpellDI.Load

    End Sub

    Friend WithEvents panAnnualMonthlyIndices As Panel
    Friend WithEvents ucrChkMonthlyMax5dayPrec As ucrCheck
    Friend WithEvents ucrChkMonthlyMax1dayPrec As ucrCheck
    Friend WithEvents ucrChkMeanDiurnalTempRange As ucrCheck
    Friend WithEvents ucrChkTmaxAbove90Percent As ucrCheck
    Friend WithEvents ucrChkTminAbove90Percent As ucrCheck
    Friend WithEvents ucrChkTmaxBelow10Percent As ucrCheck
    Friend WithEvents ucrChkTminBelow10Percent As ucrCheck
    Friend WithEvents ucrChkMonthlyMinDailyTMin As ucrCheck
    Friend WithEvents ucrChkMonthlyMinDailyTMax As ucrCheck
    Friend WithEvents ucrChkMonthlyMaxDailyTMin As ucrCheck
    Friend WithEvents ucrChkMonthlyMaxDailyTMax As ucrCheck
End Class