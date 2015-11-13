<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRegressionSimple
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRegressionSimple))
        Me.tbctrlSimple = New System.Windows.Forms.TabControl()
        Me.tbRegress = New System.Windows.Forms.TabPage()
        Me.ucrReceiverSingleB = New instat.ucrReceiverSingle()
        Me.grpLackFit = New System.Windows.Forms.GroupBox()
        Me.txtdf = New System.Windows.Forms.TextBox()
        Me.txtResidualMsg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResidualMsg = New System.Windows.Forms.Label()
        Me.chkLackFit = New System.Windows.Forms.CheckBox()
        Me.chkAnovaTable = New System.Windows.Forms.CheckBox()
        Me.chkShowPlots = New System.Windows.Forms.CheckBox()
        Me.chkSiginificance = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblConfidence = New System.Windows.Forms.Label()
        Me.lblExplanatoryVariable = New System.Windows.Forms.Label()
        Me.lblResponseVariable = New System.Windows.Forms.Label()
        Me.ucrReceiverSingleA = New instat.ucrReceiverSingle()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.tbPlot = New System.Windows.Forms.TabPage()
        Me.tbSave = New System.Windows.Forms.TabPage()
        Me.ucrBase = New instat.ucrButtons()
        Me.tbctrlSimple.SuspendLayout()
        Me.tbRegress.SuspendLayout()
        Me.grpLackFit.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbctrlSimple
        '
        Me.tbctrlSimple.Controls.Add(Me.tbRegress)
        Me.tbctrlSimple.Controls.Add(Me.tbPlot)
        Me.tbctrlSimple.Controls.Add(Me.tbSave)
        resources.ApplyResources(Me.tbctrlSimple, "tbctrlSimple")
        Me.tbctrlSimple.Name = "tbctrlSimple"
        Me.tbctrlSimple.SelectedIndex = 0
        '
        'tbRegress
        '
        Me.tbRegress.Controls.Add(Me.ucrReceiverSingleB)
        Me.tbRegress.Controls.Add(Me.grpLackFit)
        Me.tbRegress.Controls.Add(Me.chkLackFit)
        Me.tbRegress.Controls.Add(Me.chkAnovaTable)
        Me.tbRegress.Controls.Add(Me.chkShowPlots)
        Me.tbRegress.Controls.Add(Me.chkSiginificance)
        Me.tbRegress.Controls.Add(Me.ComboBox1)
        Me.tbRegress.Controls.Add(Me.lblConfidence)
        Me.tbRegress.Controls.Add(Me.lblExplanatoryVariable)
        Me.tbRegress.Controls.Add(Me.lblResponseVariable)
        Me.tbRegress.Controls.Add(Me.ucrReceiverSingleA)
        Me.tbRegress.Controls.Add(Me.ucrAddRemove)
        resources.ApplyResources(Me.tbRegress, "tbRegress")
        Me.tbRegress.Name = "tbRegress"
        Me.tbRegress.UseVisualStyleBackColor = True
        '
        'ucrReceiverSingleB
        '
        resources.ApplyResources(Me.ucrReceiverSingleB, "ucrReceiverSingleB")
        Me.ucrReceiverSingleB.Name = "ucrReceiverSingleB"
        '
        'grpLackFit
        '
        Me.grpLackFit.Controls.Add(Me.txtdf)
        Me.grpLackFit.Controls.Add(Me.txtResidualMsg)
        Me.grpLackFit.Controls.Add(Me.Label1)
        Me.grpLackFit.Controls.Add(Me.lblResidualMsg)
        resources.ApplyResources(Me.grpLackFit, "grpLackFit")
        Me.grpLackFit.Name = "grpLackFit"
        Me.grpLackFit.TabStop = False
        '
        'txtdf
        '
        resources.ApplyResources(Me.txtdf, "txtdf")
        Me.txtdf.Name = "txtdf"
        '
        'txtResidualMsg
        '
        resources.ApplyResources(Me.txtResidualMsg, "txtResidualMsg")
        Me.txtResidualMsg.Name = "txtResidualMsg"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'lblResidualMsg
        '
        resources.ApplyResources(Me.lblResidualMsg, "lblResidualMsg")
        Me.lblResidualMsg.Name = "lblResidualMsg"
        Me.lblResidualMsg.Tag = "Residual_Msg"
        '
        'chkLackFit
        '
        resources.ApplyResources(Me.chkLackFit, "chkLackFit")
        Me.chkLackFit.Name = "chkLackFit"
        Me.chkLackFit.Tag = "Lack_Of_Fit"
        Me.chkLackFit.UseVisualStyleBackColor = True
        '
        'chkAnovaTable
        '
        resources.ApplyResources(Me.chkAnovaTable, "chkAnovaTable")
        Me.chkAnovaTable.Name = "chkAnovaTable"
        Me.chkAnovaTable.Tag = "Show_Anova_Table"
        Me.chkAnovaTable.UseVisualStyleBackColor = True
        '
        'chkShowPlots
        '
        resources.ApplyResources(Me.chkShowPlots, "chkShowPlots")
        Me.chkShowPlots.Name = "chkShowPlots"
        Me.chkShowPlots.Tag = "Show_Plot"
        Me.chkShowPlots.UseVisualStyleBackColor = True
        '
        'chkSiginificance
        '
        resources.ApplyResources(Me.chkSiginificance, "chkSiginificance")
        Me.chkSiginificance.Name = "chkSiginificance"
        Me.chkSiginificance.Tag = "Significance_Test"
        Me.chkSiginificance.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {resources.GetString("ComboBox1.Items"), resources.GetString("ComboBox1.Items1"), resources.GetString("ComboBox1.Items2"), resources.GetString("ComboBox1.Items3"), resources.GetString("ComboBox1.Items4"), resources.GetString("ComboBox1.Items5")})
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.Name = "ComboBox1"
        '
        'lblConfidence
        '
        resources.ApplyResources(Me.lblConfidence, "lblConfidence")
        Me.lblConfidence.Name = "lblConfidence"
        Me.lblConfidence.Tag = "Confidence_Limits"
        '
        'lblExplanatoryVariable
        '
        resources.ApplyResources(Me.lblExplanatoryVariable, "lblExplanatoryVariable")
        Me.lblExplanatoryVariable.Name = "lblExplanatoryVariable"
        Me.lblExplanatoryVariable.Tag = "Explanatory_Variable"
        '
        'lblResponseVariable
        '
        resources.ApplyResources(Me.lblResponseVariable, "lblResponseVariable")
        Me.lblResponseVariable.Name = "lblResponseVariable"
        Me.lblResponseVariable.Tag = "Response_Variable"
        '
        'ucrReceiverSingleA
        '
        resources.ApplyResources(Me.ucrReceiverSingleA, "ucrReceiverSingleA")
        Me.ucrReceiverSingleA.Name = "ucrReceiverSingleA"
        '
        'ucrAddRemove
        '
        resources.ApplyResources(Me.ucrAddRemove, "ucrAddRemove")
        Me.ucrAddRemove.Name = "ucrAddRemove"
        '
        'tbPlot
        '
        resources.ApplyResources(Me.tbPlot, "tbPlot")
        Me.tbPlot.Name = "tbPlot"
        Me.tbPlot.UseVisualStyleBackColor = True
        '
        'tbSave
        '
        resources.ApplyResources(Me.tbSave, "tbSave")
        Me.tbSave.Name = "tbSave"
        Me.tbSave.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgRegressionSimple
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.tbctrlSimple)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.Name = "dlgRegressionSimple"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Tag = "Simple_Regression"
        Me.tbctrlSimple.ResumeLayout(False)
        Me.tbRegress.ResumeLayout(False)
        Me.tbRegress.PerformLayout()
        Me.grpLackFit.ResumeLayout(False)
        Me.grpLackFit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbctrlSimple As TabControl
    Friend WithEvents tbRegress As TabPage
    Friend WithEvents grpLackFit As GroupBox
    Friend WithEvents txtdf As TextBox
    Friend WithEvents txtResidualMsg As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblResidualMsg As Label
    Friend WithEvents chkLackFit As CheckBox
    Friend WithEvents chkAnovaTable As CheckBox
    Friend WithEvents chkShowPlots As CheckBox
    Friend WithEvents chkSiginificance As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblConfidence As Label
    Friend WithEvents lblExplanatoryVariable As Label
    Friend WithEvents lblResponseVariable As Label
    Friend WithEvents ucrReceiverSingleA As ucrReceiverSingle
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents tbPlot As TabPage
    Friend WithEvents tbSave As TabPage
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverSingleB As ucrReceiverSingle
End Class
