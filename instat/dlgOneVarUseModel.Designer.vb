<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgOneVarUseModel
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
        Me.ucrBase = New instat.ucrButtons()
        Me.lblReceiver = New System.Windows.Forms.Label()
        Me.ucrReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.cmdFitModel = New System.Windows.Forms.Button()
        Me.cmdBootstrapOptions = New System.Windows.Forms.Button()
        Me.chkSaveBootstrap = New System.Windows.Forms.CheckBox()
        Me.chkProduceBootstrap = New System.Windows.Forms.CheckBox()
        Me.ucrSaveObjects = New instat.ucrInputComboBox()
        Me.ucrSaveModel = New instat.ucrInputComboBox()
        Me.chkSaveModel = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 239)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 19
        '
        'lblReceiver
        '
        Me.lblReceiver.AutoSize = True
        Me.lblReceiver.Location = New System.Drawing.Point(239, 42)
        Me.lblReceiver.Name = "lblReceiver"
        Me.lblReceiver.Size = New System.Drawing.Size(86, 13)
        Me.lblReceiver.TabIndex = 18
        Me.lblReceiver.Text = "Selected Object:"
        '
        'ucrReceiver
        '
        Me.ucrReceiver.Location = New System.Drawing.Point(239, 57)
        Me.ucrReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiver.Name = "ucrReceiver"
        Me.ucrReceiver.Selector = Nothing
        Me.ucrReceiver.Size = New System.Drawing.Size(138, 20)
        Me.ucrReceiver.TabIndex = 16
        '
        'ucrSelector
        '
        Me.ucrSelector.bShowHiddenColumns = False
        Me.ucrSelector.bUseCurrentFilter = False
        Me.ucrSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelector.Name = "ucrSelector"
        Me.ucrSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelector.TabIndex = 15
        '
        'cmdFitModel
        '
        Me.cmdFitModel.Location = New System.Drawing.Point(239, 209)
        Me.cmdFitModel.Name = "cmdFitModel"
        Me.cmdFitModel.Size = New System.Drawing.Size(101, 23)
        Me.cmdFitModel.TabIndex = 13
        Me.cmdFitModel.Text = "Fit Model"
        Me.cmdFitModel.UseVisualStyleBackColor = True
        '
        'cmdBootstrapOptions
        '
        Me.cmdBootstrapOptions.Location = New System.Drawing.Point(239, 167)
        Me.cmdBootstrapOptions.Name = "cmdBootstrapOptions"
        Me.cmdBootstrapOptions.Size = New System.Drawing.Size(101, 23)
        Me.cmdBootstrapOptions.TabIndex = 12
        Me.cmdBootstrapOptions.Text = "Bootstrap Options"
        Me.cmdBootstrapOptions.UseVisualStyleBackColor = True
        '
        'chkSaveBootstrap
        '
        Me.chkSaveBootstrap.AutoSize = True
        Me.chkSaveBootstrap.Location = New System.Drawing.Point(239, 112)
        Me.chkSaveBootstrap.Name = "chkSaveBootstrap"
        Me.chkSaveBootstrap.Size = New System.Drawing.Size(138, 17)
        Me.chkSaveBootstrap.TabIndex = 11
        Me.chkSaveBootstrap.Text = "Save Bootstrap Objects"
        Me.chkSaveBootstrap.UseVisualStyleBackColor = True
        '
        'chkProduceBootstrap
        '
        Me.chkProduceBootstrap.AutoSize = True
        Me.chkProduceBootstrap.Location = New System.Drawing.Point(239, 89)
        Me.chkProduceBootstrap.Name = "chkProduceBootstrap"
        Me.chkProduceBootstrap.Size = New System.Drawing.Size(114, 17)
        Me.chkProduceBootstrap.TabIndex = 10
        Me.chkProduceBootstrap.Text = "Produce Bootstrap"
        Me.chkProduceBootstrap.UseVisualStyleBackColor = True
        '
        'ucrSaveObjects
        '
        Me.ucrSaveObjects.IsReadOnly = False
        Me.ucrSaveObjects.Location = New System.Drawing.Point(239, 135)
        Me.ucrSaveObjects.Name = "ucrSaveObjects"
        Me.ucrSaveObjects.Size = New System.Drawing.Size(137, 21)
        Me.ucrSaveObjects.TabIndex = 33
        '
        'ucrSaveModel
        '
        Me.ucrSaveModel.IsReadOnly = False
        Me.ucrSaveModel.Location = New System.Drawing.Point(89, 212)
        Me.ucrSaveModel.Name = "ucrSaveModel"
        Me.ucrSaveModel.Size = New System.Drawing.Size(137, 21)
        Me.ucrSaveModel.TabIndex = 31
        '
        'chkSaveModel
        '
        Me.chkSaveModel.AutoSize = True
        Me.chkSaveModel.Location = New System.Drawing.Point(7, 214)
        Me.chkSaveModel.Name = "chkSaveModel"
        Me.chkSaveModel.Size = New System.Drawing.Size(86, 17)
        Me.chkSaveModel.TabIndex = 32
        Me.chkSaveModel.Text = "Save Model:"
        Me.chkSaveModel.UseVisualStyleBackColor = True
        '
        'dlgOneVarUseModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 302)
        Me.Controls.Add(Me.ucrSaveObjects)
        Me.Controls.Add(Me.ucrSaveModel)
        Me.Controls.Add(Me.chkSaveModel)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblReceiver)
        Me.Controls.Add(Me.ucrReceiver)
        Me.Controls.Add(Me.ucrSelector)
        Me.Controls.Add(Me.cmdFitModel)
        Me.Controls.Add(Me.cmdBootstrapOptions)
        Me.Controls.Add(Me.chkSaveBootstrap)
        Me.Controls.Add(Me.chkProduceBootstrap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneVarUseModel"
        Me.Text = "One Variable Use Model"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblReceiver As Label
    Friend WithEvents ucrReceiver As ucrReceiverSingle
    Friend WithEvents ucrSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdFitModel As Button
    Friend WithEvents cmdBootstrapOptions As Button
    Friend WithEvents chkSaveBootstrap As CheckBox
    Friend WithEvents chkProduceBootstrap As CheckBox
    Friend WithEvents ucrSaveObjects As ucrInputComboBox
    Friend WithEvents ucrSaveModel As ucrInputComboBox
    Friend WithEvents chkSaveModel As CheckBox
End Class
