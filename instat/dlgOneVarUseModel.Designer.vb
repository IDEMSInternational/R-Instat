<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgOneVarUseModel
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
        Me.lblReceiver = New System.Windows.Forms.Label()
        Me.cmdFitModel = New System.Windows.Forms.Button()
        Me.cmdBootstrapOptions = New System.Windows.Forms.Button()
        Me.ucrChkProduceBootstrap = New instat.ucrCheck()
        Me.ucrSaveToDataframe = New instat.ucrSave()
        Me.ucrSaveBootstrapObjects = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblReceiver
        '
        Me.lblReceiver.AutoSize = True
        Me.lblReceiver.Location = New System.Drawing.Point(239, 45)
        Me.lblReceiver.Name = "lblReceiver"
        Me.lblReceiver.Size = New System.Drawing.Size(86, 13)
        Me.lblReceiver.TabIndex = 1
        Me.lblReceiver.Text = "Selected Object:"
        '
        'cmdFitModel
        '
        Me.cmdFitModel.Location = New System.Drawing.Point(305, 237)
        Me.cmdFitModel.Name = "cmdFitModel"
        Me.cmdFitModel.Size = New System.Drawing.Size(101, 23)
        Me.cmdFitModel.TabIndex = 7
        Me.cmdFitModel.Text = "Fit Model"
        Me.cmdFitModel.UseVisualStyleBackColor = True
        '
        'cmdBootstrapOptions
        '
        Me.cmdBootstrapOptions.Location = New System.Drawing.Point(305, 207)
        Me.cmdBootstrapOptions.Name = "cmdBootstrapOptions"
        Me.cmdBootstrapOptions.Size = New System.Drawing.Size(101, 23)
        Me.cmdBootstrapOptions.TabIndex = 6
        Me.cmdBootstrapOptions.Text = "Bootstrap Options"
        Me.cmdBootstrapOptions.UseVisualStyleBackColor = True
        '
        'ucrChkProduceBootstrap
        '
        Me.ucrChkProduceBootstrap.Checked = False
        Me.ucrChkProduceBootstrap.Location = New System.Drawing.Point(239, 85)
        Me.ucrChkProduceBootstrap.Name = "ucrChkProduceBootstrap"
        Me.ucrChkProduceBootstrap.Size = New System.Drawing.Size(138, 20)
        Me.ucrChkProduceBootstrap.TabIndex = 3
        '
        'ucrSaveToDataframe
        '
        Me.ucrSaveToDataframe.Location = New System.Drawing.Point(10, 237)
        Me.ucrSaveToDataframe.Name = "ucrSaveToDataframe"
        Me.ucrSaveToDataframe.Size = New System.Drawing.Size(289, 24)
        Me.ucrSaveToDataframe.TabIndex = 5
        '
        'ucrSaveBootstrapObjects
        '
        Me.ucrSaveBootstrapObjects.Location = New System.Drawing.Point(10, 207)
        Me.ucrSaveBootstrapObjects.Name = "ucrSaveBootstrapObjects"
        Me.ucrSaveBootstrapObjects.Size = New System.Drawing.Size(289, 24)
        Me.ucrSaveBootstrapObjects.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 267)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 8
        '
        'ucrReceiver
        '
        Me.ucrReceiver.frmParent = Me
        Me.ucrReceiver.Location = New System.Drawing.Point(239, 60)
        Me.ucrReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiver.Name = "ucrReceiver"
        Me.ucrReceiver.Selector = Nothing
        Me.ucrReceiver.Size = New System.Drawing.Size(138, 20)
        Me.ucrReceiver.TabIndex = 2
        '
        'ucrSelector
        '
        Me.ucrSelector.bShowHiddenColumns = False
        Me.ucrSelector.bUseCurrentFilter = True
        Me.ucrSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelector.Name = "ucrSelector"
        Me.ucrSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelector.TabIndex = 0
        '
        'dlgOneVarUseModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 331)
        Me.Controls.Add(Me.ucrChkProduceBootstrap)
        Me.Controls.Add(Me.ucrSaveToDataframe)
        Me.Controls.Add(Me.ucrSaveBootstrapObjects)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblReceiver)
        Me.Controls.Add(Me.ucrReceiver)
        Me.Controls.Add(Me.ucrSelector)
        Me.Controls.Add(Me.cmdFitModel)
        Me.Controls.Add(Me.cmdBootstrapOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneVarUseModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents ucrChkProduceBootstrap As ucrCheck
    Friend WithEvents ucrSaveToDataframe As ucrSave
    Friend WithEvents ucrSaveBootstrapObjects As ucrSave
End Class
