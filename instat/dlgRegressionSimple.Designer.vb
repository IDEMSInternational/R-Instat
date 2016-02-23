<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgRegressionSimple
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRegressionSimple))
        Me.lblResidualMsg = New System.Windows.Forms.Label()
        Me.lblDF = New System.Windows.Forms.Label()
        Me.txtResidualMsg = New System.Windows.Forms.TextBox()
        Me.txtdf = New System.Windows.Forms.TextBox()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.lblExplanatory = New System.Windows.Forms.Label()
        Me.lblFittedModel = New System.Windows.Forms.Label()
        Me.txtLastLM = New System.Windows.Forms.TextBox()
        Me.cmdRegressionOptions = New System.Windows.Forms.Button()
        Me.ucrExplanatory = New instat.ucrReceiverSingle()
        Me.ucrResponse = New instat.ucrReceiverSingle()
        Me.UcrSelectorByDataFrameAddRemoveSimpleReg = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblResidualMsg
        '
        resources.ApplyResources(Me.lblResidualMsg, "lblResidualMsg")
        Me.lblResidualMsg.Name = "lblResidualMsg"
        Me.lblResidualMsg.Tag = "Residual_Msg"
        '
        'lblDF
        '
        resources.ApplyResources(Me.lblDF, "lblDF")
        Me.lblDF.Name = "lblDF"
        Me.lblDF.Tag = "Degrees_of_freedom"
        '
        'txtResidualMsg
        '
        resources.ApplyResources(Me.txtResidualMsg, "txtResidualMsg")
        Me.txtResidualMsg.Name = "txtResidualMsg"
        '
        'txtdf
        '
        resources.ApplyResources(Me.txtdf, "txtdf")
        Me.txtdf.Name = "txtdf"
        '
        'lblResponse
        '
        resources.ApplyResources(Me.lblResponse, "lblResponse")
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Tag = "Response_Variable"
        '
        'lblExplanatory
        '
        resources.ApplyResources(Me.lblExplanatory, "lblExplanatory")
        Me.lblExplanatory.Name = "lblExplanatory"
        Me.lblExplanatory.Tag = "Explanatory_Variable"
        '
        'lblFittedModel
        '
        resources.ApplyResources(Me.lblFittedModel, "lblFittedModel")
        Me.lblFittedModel.Name = "lblFittedModel"
        Me.lblFittedModel.Tag = "Fitted_Model"
        '
        'txtLastLM
        '
        resources.ApplyResources(Me.txtLastLM, "txtLastLM")
        Me.txtLastLM.Name = "txtLastLM"
        '
        'cmdRegressionOptions
        '
        resources.ApplyResources(Me.cmdRegressionOptions, "cmdRegressionOptions")
        Me.cmdRegressionOptions.Name = "cmdRegressionOptions"
        Me.cmdRegressionOptions.Tag = "Options"
        Me.cmdRegressionOptions.UseVisualStyleBackColor = True
        '
        'ucrExplanatory
        '
        resources.ApplyResources(Me.ucrExplanatory, "ucrExplanatory")
        Me.ucrExplanatory.Name = "ucrExplanatory"
        Me.ucrExplanatory.Selector = Nothing
        '
        'ucrResponse
        '
        resources.ApplyResources(Me.ucrResponse, "ucrResponse")
        Me.ucrResponse.Name = "ucrResponse"
        Me.ucrResponse.Selector = Nothing
        '
        'UcrSelectorByDataFrameAddRemoveSimpleReg
        '
        resources.ApplyResources(Me.UcrSelectorByDataFrameAddRemoveSimpleReg, "UcrSelectorByDataFrameAddRemoveSimpleReg")
        Me.UcrSelectorByDataFrameAddRemoveSimpleReg.Name = "UcrSelectorByDataFrameAddRemoveSimpleReg"
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
        Me.Controls.Add(Me.cmdRegressionOptions)
        Me.Controls.Add(Me.txtLastLM)
        Me.Controls.Add(Me.lblFittedModel)
        Me.Controls.Add(Me.lblExplanatory)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.ucrExplanatory)
        Me.Controls.Add(Me.ucrResponse)
        Me.Controls.Add(Me.UcrSelectorByDataFrameAddRemoveSimpleReg)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.Name = "dlgRegressionSimple"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Tag = "Simple_Regression"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblResidualMsg As Label
    Friend WithEvents lblDF As Label
    Friend WithEvents txtResidualMsg As TextBox
    Friend WithEvents txtdf As TextBox
    Friend WithEvents UcrSelectorByDataFrameAddRemoveSimpleReg As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrResponse As ucrReceiverSingle
    Friend WithEvents ucrExplanatory As ucrReceiverSingle

    Private Sub UcrReceiverSingle1_Load(sender As Object, e As EventArgs) Handles ucrResponse.Load

    End Sub

    Friend WithEvents lblResponse As Label
    Friend WithEvents lblExplanatory As Label
    Friend WithEvents lblFittedModel As Label
    Friend WithEvents txtLastLM As TextBox
    Friend WithEvents cmdRegressionOptions As Button
End Class
