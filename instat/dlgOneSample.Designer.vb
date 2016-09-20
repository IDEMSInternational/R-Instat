<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgOneSample
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgOneSample))
        Me.grpAnalysis = New System.Windows.Forms.GroupBox()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.chkSignificanceTest = New System.Windows.Forms.CheckBox()
        Me.lblParameters = New System.Windows.Forms.Label()
        Me.cboParameters = New System.Windows.Forms.ComboBox()
        Me.lblModels = New System.Windows.Forms.Label()
        Me.cboModels = New System.Windows.Forms.ComboBox()
        Me.lblDataColumn = New System.Windows.Forms.Label()
        Me.grpGraphs = New System.Windows.Forms.GroupBox()
        Me.lblGraphs = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrReceiverDataColumn = New instat.ucrReceiverSingle()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpAnalysis.SuspendLayout()
        Me.grpGraphs.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAnalysis
        '
        Me.grpAnalysis.Controls.Add(Me.lblValue)
        Me.grpAnalysis.Controls.Add(Me.txtValue)
        Me.grpAnalysis.Controls.Add(Me.chkSignificanceTest)
        Me.grpAnalysis.Controls.Add(Me.lblParameters)
        Me.grpAnalysis.Controls.Add(Me.cboParameters)
        Me.grpAnalysis.Controls.Add(Me.lblModels)
        Me.grpAnalysis.Controls.Add(Me.cboModels)
        resources.ApplyResources(Me.grpAnalysis, "grpAnalysis")
        Me.grpAnalysis.Name = "grpAnalysis"
        Me.grpAnalysis.TabStop = False
        Me.grpAnalysis.Tag = "Analysis"
        '
        'lblValue
        '
        resources.ApplyResources(Me.lblValue, "lblValue")
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Tag = "Value"
        '
        'txtValue
        '
        resources.ApplyResources(Me.txtValue, "txtValue")
        Me.txtValue.Name = "txtValue"
        '
        'chkSignificanceTest
        '
        resources.ApplyResources(Me.chkSignificanceTest, "chkSignificanceTest")
        Me.chkSignificanceTest.Name = "chkSignificanceTest"
        Me.chkSignificanceTest.Tag = "Significance_test"
        Me.chkSignificanceTest.UseVisualStyleBackColor = True
        '
        'lblParameters
        '
        resources.ApplyResources(Me.lblParameters, "lblParameters")
        Me.lblParameters.Name = "lblParameters"
        Me.lblParameters.Tag = "Parameter"
        '
        'cboParameters
        '
        Me.cboParameters.FormattingEnabled = True
        Me.cboParameters.Items.AddRange(New Object() {resources.GetString("cboParameters.Items"), resources.GetString("cboParameters.Items1"), resources.GetString("cboParameters.Items2")})
        resources.ApplyResources(Me.cboParameters, "cboParameters")
        Me.cboParameters.Name = "cboParameters"
        '
        'lblModels
        '
        resources.ApplyResources(Me.lblModels, "lblModels")
        Me.lblModels.Name = "lblModels"
        Me.lblModels.Tag = "Models"
        '
        'cboModels
        '
        Me.cboModels.FormattingEnabled = True
        Me.cboModels.Items.AddRange(New Object() {resources.GetString("cboModels.Items"), resources.GetString("cboModels.Items1"), resources.GetString("cboModels.Items2")})
        resources.ApplyResources(Me.cboModels, "cboModels")
        Me.cboModels.Name = "cboModels"
        Me.cboModels.Tag = ""
        '
        'lblDataColumn
        '
        resources.ApplyResources(Me.lblDataColumn, "lblDataColumn")
        Me.lblDataColumn.Name = "lblDataColumn"
        Me.lblDataColumn.Tag = "Data_Column"
        '
        'grpGraphs
        '
        Me.grpGraphs.Controls.Add(Me.lblGraphs)
        resources.ApplyResources(Me.grpGraphs, "grpGraphs")
        Me.grpGraphs.Name = "grpGraphs"
        Me.grpGraphs.TabStop = False
        Me.grpGraphs.Tag = "Graphs"
        '
        'lblGraphs
        '
        resources.ApplyResources(Me.lblGraphs, "lblGraphs")
        Me.lblGraphs.Name = "lblGraphs"
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrReceiverDataColumn
        '
        resources.ApplyResources(Me.ucrReceiverDataColumn, "ucrReceiverDataColumn")
        Me.ucrReceiverDataColumn.Name = "ucrReceiverDataColumn"
        Me.ucrReceiverDataColumn.Selector = Nothing
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bShowHiddenColumns = False
        resources.ApplyResources(Me.ucrAddRemove, "ucrAddRemove")
        Me.ucrAddRemove.Name = "ucrAddRemove"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgOneSample
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrReceiverDataColumn)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.grpGraphs)
        Me.Controls.Add(Me.lblDataColumn)
        Me.Controls.Add(Me.grpAnalysis)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneSample"
        Me.Tag = "One_Sample"
        Me.grpAnalysis.ResumeLayout(False)
        Me.grpAnalysis.PerformLayout()
        Me.grpGraphs.ResumeLayout(False)
        Me.grpGraphs.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpAnalysis As GroupBox
    Friend WithEvents lblParameters As Label
    Friend WithEvents cboParameters As ComboBox
    Friend WithEvents lblModels As Label
    Friend WithEvents cboModels As ComboBox
    Friend WithEvents lblDataColumn As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents txtValue As TextBox
    Friend WithEvents chkSignificanceTest As CheckBox
    Friend WithEvents grpGraphs As GroupBox
    Friend WithEvents lblGraphs As Label
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverDataColumn As ucrReceiverSingle
End Class
