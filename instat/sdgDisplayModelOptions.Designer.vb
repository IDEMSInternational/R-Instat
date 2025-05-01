<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgDisplayModelOptions
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblConfLevel = New System.Windows.Forms.Label()
        Me.tpGraphics = New System.Windows.Forms.TabPage()
        Me.ucrChkLogGraphic = New instat.ucrCheck()
        Me.ucrSavePlots = New instat.ucrSave()
        Me.ucrChkHeat = New instat.ucrCheck()
        Me.ucrChkBar = New instat.ucrCheck()
        Me.ucrChkPlot = New instat.ucrCheck()
        Me.tpDisplay = New System.Windows.Forms.TabPage()
        Me.ucrNudNumber = New instat.ucrNud()
        Me.ucrChkTopItem = New instat.ucrCheck()
        Me.ucrChkNodeLabel = New instat.ucrCheck()
        Me.ucrChkNodeRules = New instat.ucrCheck()
        Me.ucrChkRegret = New instat.ucrCheck()
        Me.ucrChkQuasiVa = New instat.ucrCheck()
        Me.ucrChkItemPara = New instat.ucrCheck()
        Me.ucrChkVaCoMa = New instat.ucrCheck()
        Me.ucrChkReability = New instat.ucrCheck()
        Me.ucrChkParProp = New instat.ucrCheck()
        Me.ucrChkSndEstimetes = New instat.ucrCheck()
        Me.ucrChkDeviance = New instat.ucrCheck()
        Me.ucrChkAIC = New instat.ucrCheck()
        Me.ucrChkLog = New instat.ucrCheck()
        Me.ucrNudConfLevel = New instat.ucrNud()
        Me.ucrChkEstimates = New instat.ucrCheck()
        Me.ucrChkConfLimits = New instat.ucrCheck()
        Me.ucrChkANOVA = New instat.ucrCheck()
        Me.ucrChkModel = New instat.ucrCheck()
        Me.tbpDisplayOptions = New System.Windows.Forms.TabControl()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.tpGraphics.SuspendLayout()
        Me.tpDisplay.SuspendLayout()
        Me.tbpDisplayOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(49, 497)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(100, 13)
        Me.lblNumber.TabIndex = 29
        Me.lblNumber.Tag = "Number To Display:"
        Me.lblNumber.Text = "Number To Display:"
        '
        'lblConfLevel
        '
        Me.lblConfLevel.AutoSize = True
        Me.lblConfLevel.Location = New System.Drawing.Point(49, 117)
        Me.lblConfLevel.Name = "lblConfLevel"
        Me.lblConfLevel.Size = New System.Drawing.Size(93, 13)
        Me.lblConfLevel.TabIndex = 13
        Me.lblConfLevel.Tag = "Confidence_Level:"
        Me.lblConfLevel.Text = "Confidence Level:"
        '
        'tpGraphics
        '
        Me.tpGraphics.Controls.Add(Me.ucrChkLogGraphic)
        Me.tpGraphics.Controls.Add(Me.ucrSavePlots)
        Me.tpGraphics.Controls.Add(Me.ucrChkHeat)
        Me.tpGraphics.Controls.Add(Me.ucrChkBar)
        Me.tpGraphics.Controls.Add(Me.ucrChkPlot)
        Me.tpGraphics.Location = New System.Drawing.Point(4, 22)
        Me.tpGraphics.Name = "tpGraphics"
        Me.tpGraphics.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGraphics.Size = New System.Drawing.Size(352, 516)
        Me.tpGraphics.TabIndex = 1
        Me.tpGraphics.Tag = "Graphics"
        Me.tpGraphics.Text = "Graphics"
        Me.tpGraphics.UseVisualStyleBackColor = True
        '
        'ucrChkLogGraphic
        '
        Me.ucrChkLogGraphic.AutoSize = True
        Me.ucrChkLogGraphic.Checked = False
        Me.ucrChkLogGraphic.Location = New System.Drawing.Point(184, 46)
        Me.ucrChkLogGraphic.Name = "ucrChkLogGraphic"
        Me.ucrChkLogGraphic.Size = New System.Drawing.Size(121, 23)
        Me.ucrChkLogGraphic.TabIndex = 10
        '
        'ucrSavePlots
        '
        Me.ucrSavePlots.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSavePlots.Location = New System.Drawing.Point(4, 106)
        Me.ucrSavePlots.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSavePlots.Name = "ucrSavePlots"
        Me.ucrSavePlots.Size = New System.Drawing.Size(261, 24)
        Me.ucrSavePlots.TabIndex = 11
        '
        'ucrChkHeat
        '
        Me.ucrChkHeat.AutoSize = True
        Me.ucrChkHeat.Checked = False
        Me.ucrChkHeat.Location = New System.Drawing.Point(6, 46)
        Me.ucrChkHeat.Name = "ucrChkHeat"
        Me.ucrChkHeat.Size = New System.Drawing.Size(213, 23)
        Me.ucrChkHeat.TabIndex = 2
        '
        'ucrChkBar
        '
        Me.ucrChkBar.AutoSize = True
        Me.ucrChkBar.Checked = False
        Me.ucrChkBar.Location = New System.Drawing.Point(6, 75)
        Me.ucrChkBar.Name = "ucrChkBar"
        Me.ucrChkBar.Size = New System.Drawing.Size(213, 23)
        Me.ucrChkBar.TabIndex = 1
        '
        'ucrChkPlot
        '
        Me.ucrChkPlot.AutoSize = True
        Me.ucrChkPlot.Checked = False
        Me.ucrChkPlot.Location = New System.Drawing.Point(6, 17)
        Me.ucrChkPlot.Name = "ucrChkPlot"
        Me.ucrChkPlot.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkPlot.TabIndex = 0
        '
        'tpDisplay
        '
        Me.tpDisplay.Controls.Add(Me.ucrNudNumber)
        Me.tpDisplay.Controls.Add(Me.lblNumber)
        Me.tpDisplay.Controls.Add(Me.ucrChkTopItem)
        Me.tpDisplay.Controls.Add(Me.ucrChkNodeLabel)
        Me.tpDisplay.Controls.Add(Me.ucrChkNodeRules)
        Me.tpDisplay.Controls.Add(Me.ucrChkRegret)
        Me.tpDisplay.Controls.Add(Me.ucrChkQuasiVa)
        Me.tpDisplay.Controls.Add(Me.ucrChkItemPara)
        Me.tpDisplay.Controls.Add(Me.ucrChkVaCoMa)
        Me.tpDisplay.Controls.Add(Me.ucrChkReability)
        Me.tpDisplay.Controls.Add(Me.ucrChkParProp)
        Me.tpDisplay.Controls.Add(Me.ucrChkSndEstimetes)
        Me.tpDisplay.Controls.Add(Me.ucrChkDeviance)
        Me.tpDisplay.Controls.Add(Me.ucrChkAIC)
        Me.tpDisplay.Controls.Add(Me.ucrChkLog)
        Me.tpDisplay.Controls.Add(Me.ucrNudConfLevel)
        Me.tpDisplay.Controls.Add(Me.ucrChkEstimates)
        Me.tpDisplay.Controls.Add(Me.ucrChkConfLimits)
        Me.tpDisplay.Controls.Add(Me.ucrChkANOVA)
        Me.tpDisplay.Controls.Add(Me.ucrChkModel)
        Me.tpDisplay.Controls.Add(Me.lblConfLevel)
        Me.tpDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tpDisplay.Name = "tpDisplay"
        Me.tpDisplay.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDisplay.Size = New System.Drawing.Size(352, 516)
        Me.tpDisplay.TabIndex = 0
        Me.tpDisplay.Tag = "Display"
        Me.tpDisplay.Text = "Display"
        Me.tpDisplay.UseVisualStyleBackColor = True
        '
        'ucrNudNumber
        '
        Me.ucrNudNumber.AutoSize = True
        Me.ucrNudNumber.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumber.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumber.Location = New System.Drawing.Point(167, 490)
        Me.ucrNudNumber.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumber.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumber.Name = "ucrNudNumber"
        Me.ucrNudNumber.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumber.TabIndex = 30
        Me.ucrNudNumber.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkTopItem
        '
        Me.ucrChkTopItem.AutoSize = True
        Me.ucrChkTopItem.Checked = False
        Me.ucrChkTopItem.Location = New System.Drawing.Point(12, 462)
        Me.ucrChkTopItem.Name = "ucrChkTopItem"
        Me.ucrChkTopItem.Size = New System.Drawing.Size(195, 23)
        Me.ucrChkTopItem.TabIndex = 28
        '
        'ucrChkNodeLabel
        '
        Me.ucrChkNodeLabel.AutoSize = True
        Me.ucrChkNodeLabel.Checked = False
        Me.ucrChkNodeLabel.Location = New System.Drawing.Point(12, 404)
        Me.ucrChkNodeLabel.Name = "ucrChkNodeLabel"
        Me.ucrChkNodeLabel.Size = New System.Drawing.Size(195, 23)
        Me.ucrChkNodeLabel.TabIndex = 27
        '
        'ucrChkNodeRules
        '
        Me.ucrChkNodeRules.AutoSize = True
        Me.ucrChkNodeRules.Checked = False
        Me.ucrChkNodeRules.Location = New System.Drawing.Point(12, 433)
        Me.ucrChkNodeRules.Name = "ucrChkNodeRules"
        Me.ucrChkNodeRules.Size = New System.Drawing.Size(195, 23)
        Me.ucrChkNodeRules.TabIndex = 26
        '
        'ucrChkRegret
        '
        Me.ucrChkRegret.AutoSize = True
        Me.ucrChkRegret.Checked = False
        Me.ucrChkRegret.Location = New System.Drawing.Point(12, 375)
        Me.ucrChkRegret.Name = "ucrChkRegret"
        Me.ucrChkRegret.Size = New System.Drawing.Size(195, 23)
        Me.ucrChkRegret.TabIndex = 25
        '
        'ucrChkQuasiVa
        '
        Me.ucrChkQuasiVa.AutoSize = True
        Me.ucrChkQuasiVa.Checked = False
        Me.ucrChkQuasiVa.Location = New System.Drawing.Point(12, 344)
        Me.ucrChkQuasiVa.Name = "ucrChkQuasiVa"
        Me.ucrChkQuasiVa.Size = New System.Drawing.Size(195, 23)
        Me.ucrChkQuasiVa.TabIndex = 24
        '
        'ucrChkItemPara
        '
        Me.ucrChkItemPara.AutoSize = True
        Me.ucrChkItemPara.Checked = False
        Me.ucrChkItemPara.Location = New System.Drawing.Point(12, 286)
        Me.ucrChkItemPara.Name = "ucrChkItemPara"
        Me.ucrChkItemPara.Size = New System.Drawing.Size(195, 23)
        Me.ucrChkItemPara.TabIndex = 23
        '
        'ucrChkVaCoMa
        '
        Me.ucrChkVaCoMa.AutoSize = True
        Me.ucrChkVaCoMa.Checked = False
        Me.ucrChkVaCoMa.Location = New System.Drawing.Point(12, 315)
        Me.ucrChkVaCoMa.Name = "ucrChkVaCoMa"
        Me.ucrChkVaCoMa.Size = New System.Drawing.Size(195, 23)
        Me.ucrChkVaCoMa.TabIndex = 22
        '
        'ucrChkReability
        '
        Me.ucrChkReability.AutoSize = True
        Me.ucrChkReability.Checked = False
        Me.ucrChkReability.Location = New System.Drawing.Point(12, 257)
        Me.ucrChkReability.Name = "ucrChkReability"
        Me.ucrChkReability.Size = New System.Drawing.Size(195, 23)
        Me.ucrChkReability.TabIndex = 21
        '
        'ucrChkParProp
        '
        Me.ucrChkParProp.AutoSize = True
        Me.ucrChkParProp.Checked = False
        Me.ucrChkParProp.Location = New System.Drawing.Point(12, 228)
        Me.ucrChkParProp.Name = "ucrChkParProp"
        Me.ucrChkParProp.Size = New System.Drawing.Size(195, 23)
        Me.ucrChkParProp.TabIndex = 20
        '
        'ucrChkSndEstimetes
        '
        Me.ucrChkSndEstimetes.AutoSize = True
        Me.ucrChkSndEstimetes.Checked = False
        Me.ucrChkSndEstimetes.Location = New System.Drawing.Point(12, 199)
        Me.ucrChkSndEstimetes.Name = "ucrChkSndEstimetes"
        Me.ucrChkSndEstimetes.Size = New System.Drawing.Size(195, 23)
        Me.ucrChkSndEstimetes.TabIndex = 19
        '
        'ucrChkDeviance
        '
        Me.ucrChkDeviance.AutoSize = True
        Me.ucrChkDeviance.Checked = False
        Me.ucrChkDeviance.Location = New System.Drawing.Point(12, 170)
        Me.ucrChkDeviance.Name = "ucrChkDeviance"
        Me.ucrChkDeviance.Size = New System.Drawing.Size(195, 23)
        Me.ucrChkDeviance.TabIndex = 18
        '
        'ucrChkAIC
        '
        Me.ucrChkAIC.AutoSize = True
        Me.ucrChkAIC.Checked = False
        Me.ucrChkAIC.Location = New System.Drawing.Point(12, 140)
        Me.ucrChkAIC.Name = "ucrChkAIC"
        Me.ucrChkAIC.Size = New System.Drawing.Size(195, 23)
        Me.ucrChkAIC.TabIndex = 17
        '
        'ucrChkLog
        '
        Me.ucrChkLog.AutoSize = True
        Me.ucrChkLog.Checked = False
        Me.ucrChkLog.Location = New System.Drawing.Point(149, 65)
        Me.ucrChkLog.Name = "ucrChkLog"
        Me.ucrChkLog.Size = New System.Drawing.Size(138, 23)
        Me.ucrChkLog.TabIndex = 15
        '
        'ucrNudConfLevel
        '
        Me.ucrNudConfLevel.AutoSize = True
        Me.ucrNudConfLevel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudConfLevel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudConfLevel.Location = New System.Drawing.Point(167, 110)
        Me.ucrNudConfLevel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudConfLevel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudConfLevel.Name = "ucrNudConfLevel"
        Me.ucrNudConfLevel.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudConfLevel.TabIndex = 14
        Me.ucrNudConfLevel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkEstimates
        '
        Me.ucrChkEstimates.AutoSize = True
        Me.ucrChkEstimates.Checked = False
        Me.ucrChkEstimates.Location = New System.Drawing.Point(12, 63)
        Me.ucrChkEstimates.Name = "ucrChkEstimates"
        Me.ucrChkEstimates.Size = New System.Drawing.Size(232, 23)
        Me.ucrChkEstimates.TabIndex = 11
        '
        'ucrChkConfLimits
        '
        Me.ucrChkConfLimits.AutoSize = True
        Me.ucrChkConfLimits.Checked = False
        Me.ucrChkConfLimits.Location = New System.Drawing.Point(12, 90)
        Me.ucrChkConfLimits.Name = "ucrChkConfLimits"
        Me.ucrChkConfLimits.Size = New System.Drawing.Size(232, 23)
        Me.ucrChkConfLimits.TabIndex = 12
        '
        'ucrChkANOVA
        '
        Me.ucrChkANOVA.AutoSize = True
        Me.ucrChkANOVA.Checked = False
        Me.ucrChkANOVA.Location = New System.Drawing.Point(12, 36)
        Me.ucrChkANOVA.Name = "ucrChkANOVA"
        Me.ucrChkANOVA.Size = New System.Drawing.Size(113, 23)
        Me.ucrChkANOVA.TabIndex = 8
        '
        'ucrChkModel
        '
        Me.ucrChkModel.AutoSize = True
        Me.ucrChkModel.Checked = False
        Me.ucrChkModel.Location = New System.Drawing.Point(12, 9)
        Me.ucrChkModel.Name = "ucrChkModel"
        Me.ucrChkModel.Size = New System.Drawing.Size(232, 23)
        Me.ucrChkModel.TabIndex = 7
        '
        'tbpDisplayOptions
        '
        Me.tbpDisplayOptions.Controls.Add(Me.tpDisplay)
        Me.tbpDisplayOptions.Controls.Add(Me.tpGraphics)
        Me.tbpDisplayOptions.Location = New System.Drawing.Point(11, 3)
        Me.tbpDisplayOptions.Name = "tbpDisplayOptions"
        Me.tbpDisplayOptions.SelectedIndex = 0
        Me.tbpDisplayOptions.Size = New System.Drawing.Size(360, 542)
        Me.tbpDisplayOptions.TabIndex = 10
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.AutoSize = True
        Me.ucrSdgButtons.Location = New System.Drawing.Point(78, 551)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(224, 30)
        Me.ucrSdgButtons.TabIndex = 11
        '
        'sdgDisplayModelOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 585)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.Controls.Add(Me.tbpDisplayOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDisplayModelOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Display and Graph Options"
        Me.tpGraphics.ResumeLayout(False)
        Me.tpGraphics.PerformLayout()
        Me.tpDisplay.ResumeLayout(False)
        Me.tpDisplay.PerformLayout()
        Me.tbpDisplayOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrNudNumber As ucrNud
    Friend WithEvents lblNumber As Label
    Friend WithEvents ucrChkTopItem As ucrCheck
    Friend WithEvents ucrChkNodeLabel As ucrCheck
    Friend WithEvents ucrChkNodeRules As ucrCheck
    Friend WithEvents ucrChkRegret As ucrCheck
    Friend WithEvents ucrChkQuasiVa As ucrCheck
    Friend WithEvents ucrChkItemPara As ucrCheck
    Friend WithEvents ucrChkVaCoMa As ucrCheck
    Friend WithEvents ucrChkReability As ucrCheck
    Friend WithEvents ucrChkParProp As ucrCheck
    Friend WithEvents ucrChkSndEstimetes As ucrCheck
    Friend WithEvents ucrChkDeviance As ucrCheck
    Friend WithEvents ucrChkAIC As ucrCheck
    Friend WithEvents ucrChkLog As ucrCheck
    Friend WithEvents ucrNudConfLevel As ucrNud
    Friend WithEvents ucrChkEstimates As ucrCheck
    Friend WithEvents ucrChkConfLimits As ucrCheck
    Friend WithEvents ucrChkANOVA As ucrCheck
    Friend WithEvents ucrChkModel As ucrCheck
    Friend WithEvents lblConfLevel As Label
    Friend WithEvents ucrChkHeat As ucrCheck
    Friend WithEvents ucrChkBar As ucrCheck
    Friend WithEvents ucrChkPlot As ucrCheck
    Friend WithEvents tpGraphics As TabPage
    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents tpDisplay As TabPage
    Friend WithEvents tbpDisplayOptions As TabControl
    Friend WithEvents ucrChkLogGraphic As ucrCheck
    Friend WithEvents ucrSavePlots As ucrSave
End Class
