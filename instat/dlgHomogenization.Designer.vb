<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgHomogenization
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgHomogenization))
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorHomogenization = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.grpMethods = New System.Windows.Forms.GroupBox()
        Me.grpCptOptions = New System.Windows.Forms.GroupBox()
        Me.ucrPnlMethods = New instat.UcrPanel()
        Me.rdoCptVariance = New System.Windows.Forms.RadioButton()
        Me.rdoMeanVariance = New System.Windows.Forms.RadioButton()
        Me.rdoCptMean = New System.Windows.Forms.RadioButton()
        Me.grpMethods.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorHomogenization
        '
        Me.ucrSelectorHomogenization.bDropUnusedFilterLevels = False
        Me.ucrSelectorHomogenization.bShowHiddenColumns = False
        Me.ucrSelectorHomogenization.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorHomogenization, "ucrSelectorHomogenization")
        Me.ucrSelectorHomogenization.Name = "ucrSelectorHomogenization"
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverElement, "ucrReceiverElement")
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'lblElement
        '
        resources.ApplyResources(Me.lblElement, "lblElement")
        Me.lblElement.Name = "lblElement"
        '
        'grpMethods
        '
        Me.grpMethods.Controls.Add(Me.rdoCptMean)
        Me.grpMethods.Controls.Add(Me.rdoMeanVariance)
        Me.grpMethods.Controls.Add(Me.rdoCptVariance)
        Me.grpMethods.Controls.Add(Me.ucrPnlMethods)
        resources.ApplyResources(Me.grpMethods, "grpMethods")
        Me.grpMethods.Name = "grpMethods"
        Me.grpMethods.TabStop = False
        '
        'grpCptOptions
        '
        resources.ApplyResources(Me.grpCptOptions, "grpCptOptions")
        Me.grpCptOptions.Name = "grpCptOptions"
        Me.grpCptOptions.TabStop = False
        '
        'ucrPnlMethods
        '
        resources.ApplyResources(Me.ucrPnlMethods, "ucrPnlMethods")
        Me.ucrPnlMethods.Name = "ucrPnlMethods"
        '
        'rdoCptVariance
        '
        resources.ApplyResources(Me.rdoCptVariance, "rdoCptVariance")
        Me.rdoCptVariance.Name = "rdoCptVariance"
        Me.rdoCptVariance.UseVisualStyleBackColor = True
        '
        'rdoMeanVariance
        '
        resources.ApplyResources(Me.rdoMeanVariance, "rdoMeanVariance")
        Me.rdoMeanVariance.Name = "rdoMeanVariance"
        Me.rdoMeanVariance.UseVisualStyleBackColor = True
        '
        'rdoCptMean
        '
        resources.ApplyResources(Me.rdoCptMean, "rdoCptMean")
        Me.rdoCptMean.Name = "rdoCptMean"
        Me.rdoCptMean.UseVisualStyleBackColor = True
        '
        'dlgHomogenization
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpCptOptions)
        Me.Controls.Add(Me.grpMethods)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrSelectorHomogenization)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgHomogenization"
        Me.grpMethods.ResumeLayout(False)
        Me.grpMethods.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorHomogenization As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents lblElement As Label
    Friend WithEvents grpCptOptions As GroupBox
    Friend WithEvents grpMethods As GroupBox
    Friend WithEvents ucrPnlMethods As UcrPanel
    Friend WithEvents rdoCptMean As RadioButton
    Friend WithEvents rdoMeanVariance As RadioButton
    Friend WithEvents rdoCptVariance As RadioButton
End Class
