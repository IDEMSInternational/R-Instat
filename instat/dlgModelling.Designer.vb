<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgModelling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgModelling))
        Me.lblModel = New System.Windows.Forms.Label()
        Me.cmdspline = New System.Windows.Forms.Button()
        Me.cmdarima = New System.Windows.Forms.Button()
        Me.cmdloglin = New System.Windows.Forms.Button()
        Me.cmdloess = New System.Windows.Forms.Button()
        Me.cmdlowess = New System.Windows.Forms.Button()
        Me.cmdglm = New System.Windows.Forms.Button()
        Me.cmdar = New System.Windows.Forms.Button()
        Me.cmdaov = New System.Windows.Forms.Button()
        Me.cmdlm = New System.Windows.Forms.Button()
        Me.grpStats = New System.Windows.Forms.GroupBox()
        Me.cmdprincomp = New System.Windows.Forms.Button()
        Me.cmdppr = New System.Windows.Forms.Button()
        Me.cmdnls = New System.Windows.Forms.Button()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.cmdColon = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.cmdPower = New System.Windows.Forms.Button()
        Me.cmdClosingBracket = New System.Windows.Forms.Button()
        Me.cmdOpeningBracket = New System.Windows.Forms.Button()
        Me.cmdDiv = New System.Windows.Forms.Button()
        Me.cmdDoubleBracket = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdSquareBrackets = New System.Windows.Forms.Button()
        Me.cmdMinus = New System.Windows.Forms.Button()
        Me.grpFirstCalc = New System.Windows.Forms.GroupBox()
        Me.cmdTilda = New System.Windows.Forms.Button()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.cmdPredict = New System.Windows.Forms.Button()
        Me.grpextRemes = New System.Windows.Forms.GroupBox()
        Me.cmdfevd = New System.Windows.Forms.Button()
        Me.cmdlevd = New System.Windows.Forms.Button()
        Me.cmdnlmer = New System.Windows.Forms.Button()
        Me.cmdlmer = New System.Windows.Forms.Button()
        Me.cmdglmer = New System.Windows.Forms.Button()
        Me.grplme4 = New System.Windows.Forms.GroupBox()
        Me.cmdloglm = New System.Windows.Forms.Button()
        Me.cmdpolr = New System.Windows.Forms.Button()
        Me.cmdglmmPQL = New System.Windows.Forms.Button()
        Me.cmdglmnb = New System.Windows.Forms.Button()
        Me.cmdrlm = New System.Windows.Forms.Button()
        Me.grpMASS = New System.Windows.Forms.GroupBox()
        Me.cmdqda = New System.Windows.Forms.Button()
        Me.cmdmca = New System.Windows.Forms.Button()
        Me.cmdlqs = New System.Windows.Forms.Button()
        Me.cmdlda = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.lblRpackage = New System.Windows.Forms.Label()
        Me.ucrTryModelling = New instat.ucrTry()
        Me.ucrChkIncludeArguments = New instat.ucrCheck()
        Me.ucrSaveResult = New instat.ucrSave()
        Me.ucrInputComboRPackage = New instat.ucrInputComboBox()
        Me.ucrReceiverForTestColumn = New instat.ucrReceiverExpression()
        Me.ucrSelectorModelling = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpStats.SuspendLayout()
        Me.grpFirstCalc.SuspendLayout()
        Me.grpextRemes.SuspendLayout()
        Me.grplme4.SuspendLayout()
        Me.grpMASS.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblModel
        '
        resources.ApplyResources(Me.lblModel, "lblModel")
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Tag = "Test"
        '
        'cmdspline
        '
        resources.ApplyResources(Me.cmdspline, "cmdspline")
        Me.cmdspline.Name = "cmdspline"
        Me.cmdspline.UseVisualStyleBackColor = True
        '
        'cmdarima
        '
        resources.ApplyResources(Me.cmdarima, "cmdarima")
        Me.cmdarima.Name = "cmdarima"
        Me.cmdarima.UseVisualStyleBackColor = True
        '
        'cmdloglin
        '
        resources.ApplyResources(Me.cmdloglin, "cmdloglin")
        Me.cmdloglin.Name = "cmdloglin"
        Me.cmdloglin.UseVisualStyleBackColor = True
        '
        'cmdloess
        '
        resources.ApplyResources(Me.cmdloess, "cmdloess")
        Me.cmdloess.Name = "cmdloess"
        Me.cmdloess.UseVisualStyleBackColor = True
        '
        'cmdlowess
        '
        resources.ApplyResources(Me.cmdlowess, "cmdlowess")
        Me.cmdlowess.Name = "cmdlowess"
        Me.cmdlowess.UseVisualStyleBackColor = True
        '
        'cmdglm
        '
        resources.ApplyResources(Me.cmdglm, "cmdglm")
        Me.cmdglm.Name = "cmdglm"
        Me.cmdglm.UseVisualStyleBackColor = True
        '
        'cmdar
        '
        resources.ApplyResources(Me.cmdar, "cmdar")
        Me.cmdar.Name = "cmdar"
        Me.cmdar.UseVisualStyleBackColor = True
        '
        'cmdaov
        '
        resources.ApplyResources(Me.cmdaov, "cmdaov")
        Me.cmdaov.Name = "cmdaov"
        Me.cmdaov.UseVisualStyleBackColor = True
        '
        'cmdlm
        '
        resources.ApplyResources(Me.cmdlm, "cmdlm")
        Me.cmdlm.Name = "cmdlm"
        Me.cmdlm.UseVisualStyleBackColor = True
        '
        'grpStats
        '
        Me.grpStats.Controls.Add(Me.cmdprincomp)
        Me.grpStats.Controls.Add(Me.cmdppr)
        Me.grpStats.Controls.Add(Me.cmdnls)
        Me.grpStats.Controls.Add(Me.cmdspline)
        Me.grpStats.Controls.Add(Me.cmdarima)
        Me.grpStats.Controls.Add(Me.cmdloglin)
        Me.grpStats.Controls.Add(Me.cmdloess)
        Me.grpStats.Controls.Add(Me.cmdlowess)
        Me.grpStats.Controls.Add(Me.cmdglm)
        Me.grpStats.Controls.Add(Me.cmdlm)
        Me.grpStats.Controls.Add(Me.cmdaov)
        Me.grpStats.Controls.Add(Me.cmdar)
        resources.ApplyResources(Me.grpStats, "grpStats")
        Me.grpStats.Name = "grpStats"
        Me.grpStats.TabStop = False
        '
        'cmdprincomp
        '
        resources.ApplyResources(Me.cmdprincomp, "cmdprincomp")
        Me.cmdprincomp.Name = "cmdprincomp"
        Me.cmdprincomp.UseVisualStyleBackColor = True
        '
        'cmdppr
        '
        resources.ApplyResources(Me.cmdppr, "cmdppr")
        Me.cmdppr.Name = "cmdppr"
        Me.cmdppr.UseVisualStyleBackColor = True
        '
        'cmdnls
        '
        resources.ApplyResources(Me.cmdnls, "cmdnls")
        Me.cmdnls.Name = "cmdnls"
        Me.cmdnls.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        resources.ApplyResources(Me.cmdMultiply, "cmdMultiply")
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdColon
        '
        resources.ApplyResources(Me.cmdColon, "cmdColon")
        Me.cmdColon.Name = "cmdColon"
        Me.cmdColon.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        resources.ApplyResources(Me.cmdPlus, "cmdPlus")
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        resources.ApplyResources(Me.cmdPower, "cmdPower")
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdClosingBracket
        '
        resources.ApplyResources(Me.cmdClosingBracket, "cmdClosingBracket")
        Me.cmdClosingBracket.Name = "cmdClosingBracket"
        Me.cmdClosingBracket.UseVisualStyleBackColor = True
        '
        'cmdOpeningBracket
        '
        resources.ApplyResources(Me.cmdOpeningBracket, "cmdOpeningBracket")
        Me.cmdOpeningBracket.Name = "cmdOpeningBracket"
        Me.cmdOpeningBracket.UseVisualStyleBackColor = True
        '
        'cmdDiv
        '
        resources.ApplyResources(Me.cmdDiv, "cmdDiv")
        Me.cmdDiv.Name = "cmdDiv"
        Me.cmdDiv.UseVisualStyleBackColor = True
        '
        'cmdDoubleBracket
        '
        resources.ApplyResources(Me.cmdDoubleBracket, "cmdDoubleBracket")
        Me.cmdDoubleBracket.Name = "cmdDoubleBracket"
        Me.cmdDoubleBracket.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        resources.ApplyResources(Me.cmdClear, "cmdClear")
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdSquareBrackets
        '
        resources.ApplyResources(Me.cmdSquareBrackets, "cmdSquareBrackets")
        Me.cmdSquareBrackets.Name = "cmdSquareBrackets"
        Me.cmdSquareBrackets.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        resources.ApplyResources(Me.cmdMinus, "cmdMinus")
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'grpFirstCalc
        '
        Me.grpFirstCalc.Controls.Add(Me.cmdTilda)
        Me.grpFirstCalc.Controls.Add(Me.cmdMultiply)
        Me.grpFirstCalc.Controls.Add(Me.cmdColon)
        Me.grpFirstCalc.Controls.Add(Me.cmdPlus)
        Me.grpFirstCalc.Controls.Add(Me.cmdPower)
        Me.grpFirstCalc.Controls.Add(Me.cmdClosingBracket)
        Me.grpFirstCalc.Controls.Add(Me.cmdOpeningBracket)
        Me.grpFirstCalc.Controls.Add(Me.cmdDiv)
        Me.grpFirstCalc.Controls.Add(Me.cmdDoubleBracket)
        Me.grpFirstCalc.Controls.Add(Me.cmdSquareBrackets)
        Me.grpFirstCalc.Controls.Add(Me.cmdMinus)
        resources.ApplyResources(Me.grpFirstCalc, "grpFirstCalc")
        Me.grpFirstCalc.Name = "grpFirstCalc"
        Me.grpFirstCalc.TabStop = False
        '
        'cmdTilda
        '
        resources.ApplyResources(Me.cmdTilda, "cmdTilda")
        Me.cmdTilda.Name = "cmdTilda"
        Me.cmdTilda.UseVisualStyleBackColor = True
        '
        'cmdDisplayOptions
        '
        resources.ApplyResources(Me.cmdDisplayOptions, "cmdDisplayOptions")
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'cmdPredict
        '
        resources.ApplyResources(Me.cmdPredict, "cmdPredict")
        Me.cmdPredict.Name = "cmdPredict"
        Me.cmdPredict.UseVisualStyleBackColor = True
        '
        'grpextRemes
        '
        Me.grpextRemes.Controls.Add(Me.cmdfevd)
        Me.grpextRemes.Controls.Add(Me.cmdlevd)
        resources.ApplyResources(Me.grpextRemes, "grpextRemes")
        Me.grpextRemes.Name = "grpextRemes"
        Me.grpextRemes.TabStop = False
        '
        'cmdfevd
        '
        resources.ApplyResources(Me.cmdfevd, "cmdfevd")
        Me.cmdfevd.Name = "cmdfevd"
        Me.cmdfevd.UseVisualStyleBackColor = True
        '
        'cmdlevd
        '
        resources.ApplyResources(Me.cmdlevd, "cmdlevd")
        Me.cmdlevd.Name = "cmdlevd"
        Me.cmdlevd.UseVisualStyleBackColor = True
        '
        'cmdnlmer
        '
        resources.ApplyResources(Me.cmdnlmer, "cmdnlmer")
        Me.cmdnlmer.Name = "cmdnlmer"
        Me.cmdnlmer.UseVisualStyleBackColor = True
        '
        'cmdlmer
        '
        resources.ApplyResources(Me.cmdlmer, "cmdlmer")
        Me.cmdlmer.Name = "cmdlmer"
        Me.cmdlmer.UseVisualStyleBackColor = True
        '
        'cmdglmer
        '
        resources.ApplyResources(Me.cmdglmer, "cmdglmer")
        Me.cmdglmer.Name = "cmdglmer"
        Me.cmdglmer.UseVisualStyleBackColor = True
        '
        'grplme4
        '
        Me.grplme4.Controls.Add(Me.cmdlmer)
        Me.grplme4.Controls.Add(Me.cmdglmer)
        Me.grplme4.Controls.Add(Me.cmdnlmer)
        resources.ApplyResources(Me.grplme4, "grplme4")
        Me.grplme4.Name = "grplme4"
        Me.grplme4.TabStop = False
        '
        'cmdloglm
        '
        resources.ApplyResources(Me.cmdloglm, "cmdloglm")
        Me.cmdloglm.Name = "cmdloglm"
        Me.cmdloglm.UseVisualStyleBackColor = True
        '
        'cmdpolr
        '
        resources.ApplyResources(Me.cmdpolr, "cmdpolr")
        Me.cmdpolr.Name = "cmdpolr"
        Me.cmdpolr.UseVisualStyleBackColor = True
        '
        'cmdglmmPQL
        '
        resources.ApplyResources(Me.cmdglmmPQL, "cmdglmmPQL")
        Me.cmdglmmPQL.Name = "cmdglmmPQL"
        Me.cmdglmmPQL.UseVisualStyleBackColor = True
        '
        'cmdglmnb
        '
        resources.ApplyResources(Me.cmdglmnb, "cmdglmnb")
        Me.cmdglmnb.Name = "cmdglmnb"
        Me.cmdglmnb.UseVisualStyleBackColor = True
        '
        'cmdrlm
        '
        resources.ApplyResources(Me.cmdrlm, "cmdrlm")
        Me.cmdrlm.Name = "cmdrlm"
        Me.cmdrlm.UseVisualStyleBackColor = True
        '
        'grpMASS
        '
        Me.grpMASS.Controls.Add(Me.cmdqda)
        Me.grpMASS.Controls.Add(Me.cmdmca)
        Me.grpMASS.Controls.Add(Me.cmdlqs)
        Me.grpMASS.Controls.Add(Me.cmdlda)
        Me.grpMASS.Controls.Add(Me.cmdpolr)
        Me.grpMASS.Controls.Add(Me.cmdglmmPQL)
        Me.grpMASS.Controls.Add(Me.cmdglmnb)
        Me.grpMASS.Controls.Add(Me.cmdrlm)
        Me.grpMASS.Controls.Add(Me.cmdloglm)
        resources.ApplyResources(Me.grpMASS, "grpMASS")
        Me.grpMASS.Name = "grpMASS"
        Me.grpMASS.TabStop = False
        '
        'cmdqda
        '
        resources.ApplyResources(Me.cmdqda, "cmdqda")
        Me.cmdqda.Name = "cmdqda"
        Me.cmdqda.UseVisualStyleBackColor = True
        '
        'cmdmca
        '
        resources.ApplyResources(Me.cmdmca, "cmdmca")
        Me.cmdmca.Name = "cmdmca"
        Me.cmdmca.UseVisualStyleBackColor = True
        '
        'cmdlqs
        '
        resources.ApplyResources(Me.cmdlqs, "cmdlqs")
        Me.cmdlqs.Name = "cmdlqs"
        Me.cmdlqs.UseVisualStyleBackColor = True
        '
        'cmdlda
        '
        resources.ApplyResources(Me.cmdlda, "cmdlda")
        Me.cmdlda.Name = "cmdlda"
        Me.cmdlda.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        resources.ApplyResources(Me.cmdHelp, "cmdHelp")
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'lblRpackage
        '
        resources.ApplyResources(Me.lblRpackage, "lblRpackage")
        Me.lblRpackage.Name = "lblRpackage"
        '
        'ucrTryModelling
        '
        resources.ApplyResources(Me.ucrTryModelling, "ucrTryModelling")
        Me.ucrTryModelling.Name = "ucrTryModelling"
        '
        'ucrChkIncludeArguments
        '
        Me.ucrChkIncludeArguments.Checked = False
        resources.ApplyResources(Me.ucrChkIncludeArguments, "ucrChkIncludeArguments")
        Me.ucrChkIncludeArguments.Name = "ucrChkIncludeArguments"
        '
        'ucrSaveResult
        '
        resources.ApplyResources(Me.ucrSaveResult, "ucrSaveResult")
        Me.ucrSaveResult.Name = "ucrSaveResult"
        '
        'ucrInputComboRPackage
        '
        Me.ucrInputComboRPackage.AddQuotesIfUnrecognised = True
        Me.ucrInputComboRPackage.GetSetSelectedIndex = -1
        Me.ucrInputComboRPackage.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboRPackage, "ucrInputComboRPackage")
        Me.ucrInputComboRPackage.Name = "ucrInputComboRPackage"
        '
        'ucrReceiverForTestColumn
        '
        Me.ucrReceiverForTestColumn.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverForTestColumn, "ucrReceiverForTestColumn")
        Me.ucrReceiverForTestColumn.Name = "ucrReceiverForTestColumn"
        Me.ucrReceiverForTestColumn.Selector = Nothing
        Me.ucrReceiverForTestColumn.strNcFilePath = ""
        Me.ucrReceiverForTestColumn.ucrSelector = Nothing
        '
        'ucrSelectorModelling
        '
        Me.ucrSelectorModelling.bDropUnusedFilterLevels = False
        Me.ucrSelectorModelling.bShowHiddenColumns = False
        Me.ucrSelectorModelling.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorModelling, "ucrSelectorModelling")
        Me.ucrSelectorModelling.Name = "ucrSelectorModelling"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgModelling
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrTryModelling)
        Me.Controls.Add(Me.grplme4)
        Me.Controls.Add(Me.grpMASS)
        Me.Controls.Add(Me.grpextRemes)
        Me.Controls.Add(Me.ucrChkIncludeArguments)
        Me.Controls.Add(Me.lblRpackage)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.cmdPredict)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.ucrSaveResult)
        Me.Controls.Add(Me.grpFirstCalc)
        Me.Controls.Add(Me.ucrInputComboRPackage)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.ucrReceiverForTestColumn)
        Me.Controls.Add(Me.ucrSelectorModelling)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpStats)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgModelling"
        Me.grpStats.ResumeLayout(False)
        Me.grpFirstCalc.ResumeLayout(False)
        Me.grpextRemes.ResumeLayout(False)
        Me.grplme4.ResumeLayout(False)
        Me.grpMASS.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorModelling As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputComboRPackage As ucrInputComboBox
    Friend WithEvents lblModel As Label
    Friend WithEvents ucrReceiverForTestColumn As ucrReceiverExpression
    Friend WithEvents grpStats As GroupBox
    Friend WithEvents cmdspline As Button
    Friend WithEvents cmdarima As Button
    Friend WithEvents cmdloglin As Button
    Friend WithEvents cmdloess As Button
    Friend WithEvents cmdlowess As Button
    Friend WithEvents cmdglm As Button
    Friend WithEvents cmdar As Button
    Friend WithEvents cmdaov As Button
    Friend WithEvents cmdlm As Button
    Friend WithEvents grpFirstCalc As GroupBox
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdColon As Button
    Friend WithEvents cmdPlus As Button
    Friend WithEvents cmdPower As Button
    Friend WithEvents cmdClosingBracket As Button
    Friend WithEvents cmdOpeningBracket As Button
    Friend WithEvents cmdDiv As Button
    Friend WithEvents cmdDoubleBracket As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdSquareBrackets As Button
    Friend WithEvents cmdMinus As Button
    Friend WithEvents ucrSaveResult As ucrSave
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents cmdPredict As Button
    Friend WithEvents grpextRemes As GroupBox
    Friend WithEvents cmdfevd As Button
    Friend WithEvents cmdlevd As Button
    Friend WithEvents grplme4 As GroupBox
    Friend WithEvents cmdnlmer As Button
    Friend WithEvents cmdlmer As Button
    Friend WithEvents cmdglmer As Button
    Friend WithEvents grpMASS As GroupBox
    Friend WithEvents cmdloglm As Button
    Friend WithEvents cmdpolr As Button
    Friend WithEvents cmdglmmPQL As Button
    Friend WithEvents cmdglmnb As Button
    Friend WithEvents cmdrlm As Button
    Friend WithEvents cmdHelp As Button
    Friend WithEvents lblRpackage As Label
    Friend WithEvents ucrChkIncludeArguments As ucrCheck
    Friend WithEvents cmdTilda As Button
    Friend WithEvents cmdppr As Button
    Friend WithEvents cmdnls As Button
    Friend WithEvents cmdprincomp As Button
    Friend WithEvents cmdlda As Button
    Friend WithEvents cmdlqs As Button
    Friend WithEvents cmdmca As Button
    Friend WithEvents cmdqda As Button
    Friend WithEvents ucrTryModelling As ucrTry
End Class
