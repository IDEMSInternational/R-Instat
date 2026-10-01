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
        Me.components = New System.ComponentModel.Container()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblConfLevel = New System.Windows.Forms.Label()
        Me.tpGraphics = New System.Windows.Forms.TabPage()
        Me.rdoTree = New System.Windows.Forms.RadioButton()
        Me.ucrChkLogGraphic = New instat.ucrCheck()
        Me.rdoBar = New System.Windows.Forms.RadioButton()
        Me.rdoMap = New System.Windows.Forms.RadioButton()
        Me.rdoPlot = New System.Windows.Forms.RadioButton()
        Me.rdoNoPlot = New System.Windows.Forms.RadioButton()
        Me.ucrPnlPlots = New instat.UcrPanel()
        Me.ucrSavePlots = New instat.ucrSave()
        Me.tpDisplay = New System.Windows.Forms.TabPage()
        Me.grpTrees = New System.Windows.Forms.GroupBox()
        Me.ucrChkRegret = New instat.ucrCheck()
        Me.ucrNudNumber = New instat.ucrNud()
        Me.ucrChkNodeLabel = New instat.ucrCheck()
        Me.ucrChkNodeRules = New instat.ucrCheck()
        Me.ucrChkTopItem = New instat.ucrCheck()
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
        Me.ucrChkSave = New instat.ucrCheck()
        Me.tbpDisplayOptions = New System.Windows.Forms.TabControl()
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.ttModelDisplay = New System.Windows.Forms.ToolTip(Me.components)
        Me.tpGraphics.SuspendLayout()
        Me.tpDisplay.SuspendLayout()
        Me.grpTrees.SuspendLayout()
        Me.tbpDisplayOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(55, 210)
        Me.lblNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(146, 20)
        Me.lblNumber.TabIndex = 29
        Me.lblNumber.Tag = "Number To Display:"
        Me.lblNumber.Text = "Number To Display:"
        '
        'lblConfLevel
        '
        Me.lblConfLevel.AutoSize = True
        Me.lblConfLevel.Location = New System.Drawing.Point(106, 189)
        Me.lblConfLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConfLevel.Name = "lblConfLevel"
        Me.lblConfLevel.Size = New System.Drawing.Size(135, 20)
        Me.lblConfLevel.TabIndex = 13
        Me.lblConfLevel.Tag = "Confidence_Level:"
        Me.lblConfLevel.Text = "Confidence Level:"
        '
        'tpGraphics
        '
        Me.tpGraphics.Controls.Add(Me.rdoTree)
        Me.tpGraphics.Controls.Add(Me.ucrChkLogGraphic)
        Me.tpGraphics.Controls.Add(Me.rdoBar)
        Me.tpGraphics.Controls.Add(Me.rdoMap)
        Me.tpGraphics.Controls.Add(Me.rdoPlot)
        Me.tpGraphics.Controls.Add(Me.rdoNoPlot)
        Me.tpGraphics.Controls.Add(Me.ucrPnlPlots)
        Me.tpGraphics.Controls.Add(Me.ucrSavePlots)
        Me.tpGraphics.Location = New System.Drawing.Point(4, 29)
        Me.tpGraphics.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpGraphics.Name = "tpGraphics"
        Me.tpGraphics.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpGraphics.Size = New System.Drawing.Size(855, 475)
        Me.tpGraphics.TabIndex = 1
        Me.tpGraphics.Tag = "Graphics"
        Me.tpGraphics.Text = "Graphics"
        Me.tpGraphics.UseVisualStyleBackColor = True
        '
        'rdoTree
        '
        Me.rdoTree.AutoSize = True
        Me.rdoTree.Location = New System.Drawing.Point(15, 169)
        Me.rdoTree.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoTree.Name = "rdoTree"
        Me.rdoTree.Size = New System.Drawing.Size(97, 24)
        Me.rdoTree.TabIndex = 17
        Me.rdoTree.Text = "Tree Plot"
        Me.rdoTree.UseVisualStyleBackColor = True
        '
        'ucrChkLogGraphic
        '
        Me.ucrChkLogGraphic.AutoSize = True
        Me.ucrChkLogGraphic.Checked = False
        Me.ucrChkLogGraphic.Location = New System.Drawing.Point(214, 100)
        Me.ucrChkLogGraphic.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkLogGraphic.Name = "ucrChkLogGraphic"
        Me.ucrChkLogGraphic.Size = New System.Drawing.Size(182, 52)
        Me.ucrChkLogGraphic.TabIndex = 10
        '
        'rdoBar
        '
        Me.rdoBar.AutoSize = True
        Me.rdoBar.Location = New System.Drawing.Point(15, 135)
        Me.rdoBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoBar.Name = "rdoBar"
        Me.rdoBar.Size = New System.Drawing.Size(106, 24)
        Me.rdoBar.TabIndex = 16
        Me.rdoBar.Text = "Worth Bar"
        Me.rdoBar.UseVisualStyleBackColor = True
        '
        'rdoMap
        '
        Me.rdoMap.AutoSize = True
        Me.rdoMap.Location = New System.Drawing.Point(15, 100)
        Me.rdoMap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoMap.Name = "rdoMap"
        Me.rdoMap.Size = New System.Drawing.Size(112, 24)
        Me.rdoMap.TabIndex = 15
        Me.rdoMap.Text = "Worth Map"
        Me.rdoMap.UseVisualStyleBackColor = True
        '
        'rdoPlot
        '
        Me.rdoPlot.AutoSize = True
        Me.rdoPlot.Location = New System.Drawing.Point(15, 65)
        Me.rdoPlot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoPlot.Name = "rdoPlot"
        Me.rdoPlot.Size = New System.Drawing.Size(61, 24)
        Me.rdoPlot.TabIndex = 14
        Me.rdoPlot.Text = "Plot"
        Me.rdoPlot.UseVisualStyleBackColor = True
        '
        'rdoNoPlot
        '
        Me.rdoNoPlot.AutoSize = True
        Me.rdoNoPlot.Location = New System.Drawing.Point(15, 29)
        Me.rdoNoPlot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoNoPlot.Name = "rdoNoPlot"
        Me.rdoNoPlot.Size = New System.Drawing.Size(85, 24)
        Me.rdoNoPlot.TabIndex = 13
        Me.rdoNoPlot.Text = "No Plot"
        Me.rdoNoPlot.UseVisualStyleBackColor = True
        '
        'ucrPnlPlots
        '
        Me.ucrPnlPlots.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlPlots.Location = New System.Drawing.Point(9, 23)
        Me.ucrPnlPlots.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        Me.ucrPnlPlots.Size = New System.Drawing.Size(422, 185)
        Me.ucrPnlPlots.TabIndex = 12
        '
        'ucrSavePlots
        '
        Me.ucrSavePlots.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSavePlots.Location = New System.Drawing.Point(15, 225)
        Me.ucrSavePlots.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSavePlots.Name = "ucrSavePlots"
        Me.ucrSavePlots.Size = New System.Drawing.Size(392, 37)
        Me.ucrSavePlots.TabIndex = 11
        '
        'tpDisplay
        '
        Me.tpDisplay.Controls.Add(Me.grpTrees)
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
        Me.tpDisplay.Controls.Add(Me.ucrChkSave)
        Me.tpDisplay.Location = New System.Drawing.Point(4, 29)
        Me.tpDisplay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpDisplay.Name = "tpDisplay"
        Me.tpDisplay.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpDisplay.Size = New System.Drawing.Size(855, 475)
        Me.tpDisplay.TabIndex = 0
        Me.tpDisplay.Tag = "Display"
        Me.tpDisplay.Text = "Display"
        Me.tpDisplay.UseVisualStyleBackColor = True
        '
        'grpTrees
        '
        Me.grpTrees.Controls.Add(Me.ucrChkRegret)
        Me.grpTrees.Controls.Add(Me.ucrNudNumber)
        Me.grpTrees.Controls.Add(Me.ucrChkNodeLabel)
        Me.grpTrees.Controls.Add(Me.lblNumber)
        Me.grpTrees.Controls.Add(Me.ucrChkNodeRules)
        Me.grpTrees.Controls.Add(Me.ucrChkTopItem)
        Me.grpTrees.Location = New System.Drawing.Point(20, 215)
        Me.grpTrees.Name = "grpTrees"
        Me.grpTrees.Size = New System.Drawing.Size(360, 247)
        Me.grpTrees.TabIndex = 12
        Me.grpTrees.TabStop = False
        Me.grpTrees.Text = "Tree Options"
        '
        'ucrChkRegret
        '
        Me.ucrChkRegret.AutoSize = True
        Me.ucrChkRegret.Checked = False
        Me.ucrChkRegret.Location = New System.Drawing.Point(12, 40)
        Me.ucrChkRegret.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkRegret.Name = "ucrChkRegret"
        Me.ucrChkRegret.Size = New System.Drawing.Size(348, 34)
        Me.ucrChkRegret.TabIndex = 25
        '
        'ucrNudNumber
        '
        Me.ucrNudNumber.AutoSize = True
        Me.ucrNudNumber.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumber.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumber.Location = New System.Drawing.Point(208, 208)
        Me.ucrNudNumber.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudNumber.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumber.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumber.Name = "ucrNudNumber"
        Me.ucrNudNumber.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudNumber.TabIndex = 30
        Me.ucrNudNumber.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkNodeLabel
        '
        Me.ucrChkNodeLabel.AutoSize = True
        Me.ucrChkNodeLabel.Checked = False
        Me.ucrChkNodeLabel.Location = New System.Drawing.Point(12, 80)
        Me.ucrChkNodeLabel.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkNodeLabel.Name = "ucrChkNodeLabel"
        Me.ucrChkNodeLabel.Size = New System.Drawing.Size(348, 34)
        Me.ucrChkNodeLabel.TabIndex = 27
        '
        'ucrChkNodeRules
        '
        Me.ucrChkNodeRules.AutoSize = True
        Me.ucrChkNodeRules.Checked = False
        Me.ucrChkNodeRules.Location = New System.Drawing.Point(12, 123)
        Me.ucrChkNodeRules.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkNodeRules.Name = "ucrChkNodeRules"
        Me.ucrChkNodeRules.Size = New System.Drawing.Size(348, 34)
        Me.ucrChkNodeRules.TabIndex = 26
        '
        'ucrChkTopItem
        '
        Me.ucrChkTopItem.AutoSize = True
        Me.ucrChkTopItem.Checked = False
        Me.ucrChkTopItem.Location = New System.Drawing.Point(12, 167)
        Me.ucrChkTopItem.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkTopItem.Name = "ucrChkTopItem"
        Me.ucrChkTopItem.Size = New System.Drawing.Size(348, 34)
        Me.ucrChkTopItem.TabIndex = 28
        '
        'ucrChkQuasiVa
        '
        Me.ucrChkQuasiVa.AutoSize = True
        Me.ucrChkQuasiVa.Checked = False
        Me.ucrChkQuasiVa.Location = New System.Drawing.Point(536, 295)
        Me.ucrChkQuasiVa.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkQuasiVa.Name = "ucrChkQuasiVa"
        Me.ucrChkQuasiVa.Size = New System.Drawing.Size(348, 34)
        Me.ucrChkQuasiVa.TabIndex = 24
        '
        'ucrChkItemPara
        '
        Me.ucrChkItemPara.AutoSize = True
        Me.ucrChkItemPara.Checked = False
        Me.ucrChkItemPara.Location = New System.Drawing.Point(536, 215)
        Me.ucrChkItemPara.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkItemPara.Name = "ucrChkItemPara"
        Me.ucrChkItemPara.Size = New System.Drawing.Size(348, 34)
        Me.ucrChkItemPara.TabIndex = 23
        '
        'ucrChkVaCoMa
        '
        Me.ucrChkVaCoMa.AutoSize = True
        Me.ucrChkVaCoMa.Checked = False
        Me.ucrChkVaCoMa.Location = New System.Drawing.Point(536, 255)
        Me.ucrChkVaCoMa.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkVaCoMa.Name = "ucrChkVaCoMa"
        Me.ucrChkVaCoMa.Size = New System.Drawing.Size(348, 34)
        Me.ucrChkVaCoMa.TabIndex = 22
        '
        'ucrChkReability
        '
        Me.ucrChkReability.AutoSize = True
        Me.ucrChkReability.Checked = False
        Me.ucrChkReability.Location = New System.Drawing.Point(536, 175)
        Me.ucrChkReability.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkReability.Name = "ucrChkReability"
        Me.ucrChkReability.Size = New System.Drawing.Size(348, 34)
        Me.ucrChkReability.TabIndex = 21
        '
        'ucrChkParProp
        '
        Me.ucrChkParProp.AutoSize = True
        Me.ucrChkParProp.Checked = False
        Me.ucrChkParProp.Location = New System.Drawing.Point(536, 135)
        Me.ucrChkParProp.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkParProp.Name = "ucrChkParProp"
        Me.ucrChkParProp.Size = New System.Drawing.Size(348, 34)
        Me.ucrChkParProp.TabIndex = 20
        '
        'ucrChkSndEstimetes
        '
        Me.ucrChkSndEstimetes.AutoSize = True
        Me.ucrChkSndEstimetes.Checked = False
        Me.ucrChkSndEstimetes.Location = New System.Drawing.Point(536, 95)
        Me.ucrChkSndEstimetes.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkSndEstimetes.Name = "ucrChkSndEstimetes"
        Me.ucrChkSndEstimetes.Size = New System.Drawing.Size(348, 34)
        Me.ucrChkSndEstimetes.TabIndex = 19
        '
        'ucrChkDeviance
        '
        Me.ucrChkDeviance.AutoSize = True
        Me.ucrChkDeviance.Checked = False
        Me.ucrChkDeviance.Location = New System.Drawing.Point(536, 55)
        Me.ucrChkDeviance.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkDeviance.Name = "ucrChkDeviance"
        Me.ucrChkDeviance.Size = New System.Drawing.Size(348, 34)
        Me.ucrChkDeviance.TabIndex = 18
        '
        'ucrChkAIC
        '
        Me.ucrChkAIC.AutoSize = True
        Me.ucrChkAIC.Checked = False
        Me.ucrChkAIC.Location = New System.Drawing.Point(536, 15)
        Me.ucrChkAIC.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkAIC.Name = "ucrChkAIC"
        Me.ucrChkAIC.Size = New System.Drawing.Size(348, 34)
        Me.ucrChkAIC.TabIndex = 17
        '
        'ucrChkLog
        '
        Me.ucrChkLog.AutoSize = True
        Me.ucrChkLog.Checked = False
        Me.ucrChkLog.Location = New System.Drawing.Point(250, 95)
        Me.ucrChkLog.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkLog.Name = "ucrChkLog"
        Me.ucrChkLog.Size = New System.Drawing.Size(348, 34)
        Me.ucrChkLog.TabIndex = 15
        '
        'ucrNudConfLevel
        '
        Me.ucrNudConfLevel.AutoSize = True
        Me.ucrNudConfLevel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudConfLevel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudConfLevel.Location = New System.Drawing.Point(253, 187)
        Me.ucrNudConfLevel.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudConfLevel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudConfLevel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudConfLevel.Name = "ucrNudConfLevel"
        Me.ucrNudConfLevel.Size = New System.Drawing.Size(75, 31)
        Me.ucrNudConfLevel.TabIndex = 14
        Me.ucrNudConfLevel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkEstimates
        '
        Me.ucrChkEstimates.AutoSize = True
        Me.ucrChkEstimates.Checked = False
        Me.ucrChkEstimates.Location = New System.Drawing.Point(18, 95)
        Me.ucrChkEstimates.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkEstimates.Name = "ucrChkEstimates"
        Me.ucrChkEstimates.Size = New System.Drawing.Size(348, 34)
        Me.ucrChkEstimates.TabIndex = 11
        '
        'ucrChkConfLimits
        '
        Me.ucrChkConfLimits.AutoSize = True
        Me.ucrChkConfLimits.Checked = False
        Me.ucrChkConfLimits.Location = New System.Drawing.Point(18, 155)
        Me.ucrChkConfLimits.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkConfLimits.Name = "ucrChkConfLimits"
        Me.ucrChkConfLimits.Size = New System.Drawing.Size(348, 34)
        Me.ucrChkConfLimits.TabIndex = 12
        '
        'ucrChkANOVA
        '
        Me.ucrChkANOVA.AutoSize = True
        Me.ucrChkANOVA.Checked = False
        Me.ucrChkANOVA.Location = New System.Drawing.Point(18, 55)
        Me.ucrChkANOVA.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkANOVA.Name = "ucrChkANOVA"
        Me.ucrChkANOVA.Size = New System.Drawing.Size(348, 34)
        Me.ucrChkANOVA.TabIndex = 8
        '
        'ucrChkModel
        '
        Me.ucrChkModel.AutoSize = True
        Me.ucrChkModel.Checked = False
        Me.ucrChkModel.Location = New System.Drawing.Point(18, 15)
        Me.ucrChkModel.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkModel.Name = "ucrChkModel"
        Me.ucrChkModel.Size = New System.Drawing.Size(348, 34)
        Me.ucrChkModel.TabIndex = 7
        '
        'ucrChkSave
        '
        Me.ucrChkSave.AutoSize = True
        Me.ucrChkSave.Checked = False
        Me.ucrChkSave.Location = New System.Drawing.Point(250, 128)
        Me.ucrChkSave.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkSave.Name = "ucrChkSave"
        Me.ucrChkSave.Size = New System.Drawing.Size(348, 34)
        Me.ucrChkSave.TabIndex = 25
        '
        'tbpDisplayOptions
        '
        Me.tbpDisplayOptions.Controls.Add(Me.tpDisplay)
        Me.tbpDisplayOptions.Controls.Add(Me.tpGraphics)
        Me.tbpDisplayOptions.Location = New System.Drawing.Point(16, 5)
        Me.tbpDisplayOptions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpDisplayOptions.Name = "tbpDisplayOptions"
        Me.tbpDisplayOptions.SelectedIndex = 0
        Me.tbpDisplayOptions.Size = New System.Drawing.Size(863, 508)
        Me.tbpDisplayOptions.TabIndex = 10
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.AutoSize = True
        Me.ucrSdgButtons.Location = New System.Drawing.Point(270, 524)
        Me.ucrSdgButtons.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(336, 46)
        Me.ucrSdgButtons.TabIndex = 11
        '
        'sdgDisplayModelOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 571)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.Controls.Add(Me.tbpDisplayOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDisplayModelOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Display and Graph Options"
        Me.tpGraphics.ResumeLayout(False)
        Me.tpGraphics.PerformLayout()
        Me.tpDisplay.ResumeLayout(False)
        Me.tpDisplay.PerformLayout()
        Me.grpTrees.ResumeLayout(False)
        Me.grpTrees.PerformLayout()
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
    Friend WithEvents tpGraphics As TabPage
    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents tpDisplay As TabPage
    Friend WithEvents tbpDisplayOptions As TabControl
    Friend WithEvents ucrChkLogGraphic As ucrCheck
    Friend WithEvents ucrSavePlots As ucrSave
    Friend WithEvents rdoBar As RadioButton
    Friend WithEvents rdoMap As RadioButton
    Friend WithEvents rdoPlot As RadioButton
    Friend WithEvents rdoNoPlot As RadioButton
    Friend WithEvents ucrPnlPlots As UcrPanel
    Friend WithEvents rdoTree As RadioButton
    Friend WithEvents grpTrees As GroupBox
    Friend WithEvents ucrChkSave As ucrCheck
    Friend WithEvents ttModelDisplay As ToolTip
End Class
