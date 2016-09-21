<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgOneWayANOVA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgOneWayANOVA))
        Me.lblYVariate = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrAddRemoveDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrYVariate = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrFactor = New instat.ucrReceiverSingle()
        Me.lblFittedModel = New System.Windows.Forms.Label()
        Me.UcrInputTextBox1 = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'lblYVariate
        '
        resources.ApplyResources(Me.lblYVariate, "lblYVariate")
        Me.lblYVariate.Name = "lblYVariate"
        Me.lblYVariate.Tag = "Y variate"
        '
        'lblFactor
        '
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Tag = "Factor"
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrAddRemoveDataFrame
        '
        Me.ucrAddRemoveDataFrame.bShowHiddenColumns = False
        Me.ucrAddRemoveDataFrame.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrAddRemoveDataFrame, "ucrAddRemoveDataFrame")
        Me.ucrAddRemoveDataFrame.Name = "ucrAddRemoveDataFrame"
        '
        'ucrYVariate
        '
        resources.ApplyResources(Me.ucrYVariate, "ucrYVariate")
        Me.ucrYVariate.Name = "ucrYVariate"
        Me.ucrYVariate.Selector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrFactor
        '
        resources.ApplyResources(Me.ucrFactor, "ucrFactor")
        Me.ucrFactor.Name = "ucrFactor"
        Me.ucrFactor.Selector = Nothing
        '
        'lblFittedModel
        '
        resources.ApplyResources(Me.lblFittedModel, "lblFittedModel")
        Me.lblFittedModel.Name = "lblFittedModel"
        Me.lblFittedModel.Tag = "Fitted_model"
        '
        'UcrInputTextBox1
        '
        Me.UcrInputTextBox1.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputTextBox1, "UcrInputTextBox1")
        Me.UcrInputTextBox1.Name = "UcrInputTextBox1"
        '
        'dlgOneWayANOVA
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcrInputTextBox1)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblFittedModel)
        Me.Controls.Add(Me.ucrAddRemoveDataFrame)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblYVariate)
        Me.Controls.Add(Me.ucrFactor)
        Me.Controls.Add(Me.ucrYVariate)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneWayANOVA"
        Me.Tag = "One_Way_ANOVAN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrYVariate As ucrReceiverSingle
    Friend WithEvents lblYVariate As Label
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrAddRemoveDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrFactor As ucrReceiverSingle
    Friend WithEvents lblFittedModel As Label
    Friend WithEvents UcrInputTextBox1 As ucrInputTextBox
End Class
