<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgInfillMissingValues
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgInfillMissingValues))
        Me.rdoNaStructTS = New System.Windows.Forms.RadioButton()
        Me.rdoNaLocf = New System.Windows.Forms.RadioButton()
        Me.rdoNaSpline = New System.Windows.Forms.RadioButton()
        Me.rdoNaFill = New System.Windows.Forms.RadioButton()
        Me.rdoNaAggregate = New System.Windows.Forms.RadioButton()
        Me.rdoNaApproximate = New System.Windows.Forms.RadioButton()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.rdoSingle = New System.Windows.Forms.RadioButton()
        Me.rdoMultiple = New System.Windows.Forms.RadioButton()
        Me.rdoNeighbouring = New System.Windows.Forms.RadioButton()
        Me.grpMethods = New System.Windows.Forms.GroupBox()
        Me.ucrPnlMethods = New instat.UcrPanel()
        Me.ucrSaveNewColumn = New instat.ucrSave()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorInfillMissing = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.grpMethods.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoNaStructTS
        '
        resources.ApplyResources(Me.rdoNaStructTS, "rdoNaStructTS")
        Me.rdoNaStructTS.Name = "rdoNaStructTS"
        Me.rdoNaStructTS.TabStop = True
        Me.rdoNaStructTS.UseVisualStyleBackColor = True
        '
        'rdoNaLocf
        '
        resources.ApplyResources(Me.rdoNaLocf, "rdoNaLocf")
        Me.rdoNaLocf.Name = "rdoNaLocf"
        Me.rdoNaLocf.TabStop = True
        Me.rdoNaLocf.UseVisualStyleBackColor = True
        '
        'rdoNaSpline
        '
        resources.ApplyResources(Me.rdoNaSpline, "rdoNaSpline")
        Me.rdoNaSpline.Name = "rdoNaSpline"
        Me.rdoNaSpline.TabStop = True
        Me.rdoNaSpline.UseVisualStyleBackColor = True
        '
        'rdoNaFill
        '
        resources.ApplyResources(Me.rdoNaFill, "rdoNaFill")
        Me.rdoNaFill.Name = "rdoNaFill"
        Me.rdoNaFill.TabStop = True
        Me.rdoNaFill.UseVisualStyleBackColor = True
        '
        'rdoNaAggregate
        '
        resources.ApplyResources(Me.rdoNaAggregate, "rdoNaAggregate")
        Me.rdoNaAggregate.Name = "rdoNaAggregate"
        Me.rdoNaAggregate.TabStop = True
        Me.rdoNaAggregate.UseVisualStyleBackColor = True
        '
        'rdoNaApproximate
        '
        resources.ApplyResources(Me.rdoNaApproximate, "rdoNaApproximate")
        Me.rdoNaApproximate.Name = "rdoNaApproximate"
        Me.rdoNaApproximate.TabStop = True
        Me.rdoNaApproximate.UseVisualStyleBackColor = True
        '
        'lblElement
        '
        resources.ApplyResources(Me.lblElement, "lblElement")
        Me.lblElement.Name = "lblElement"
        '
        'rdoSingle
        '
        resources.ApplyResources(Me.rdoSingle, "rdoSingle")
        Me.rdoSingle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingle.FlatAppearance.BorderSize = 2
        Me.rdoSingle.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.UseVisualStyleBackColor = True
        '
        'rdoMultiple
        '
        resources.ApplyResources(Me.rdoMultiple, "rdoMultiple")
        Me.rdoMultiple.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatAppearance.BorderSize = 2
        Me.rdoMultiple.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.Name = "rdoMultiple"
        Me.rdoMultiple.TabStop = True
        Me.rdoMultiple.UseVisualStyleBackColor = True
        '
        'rdoNeighbouring
        '
        resources.ApplyResources(Me.rdoNeighbouring, "rdoNeighbouring")
        Me.rdoNeighbouring.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNeighbouring.FlatAppearance.BorderSize = 2
        Me.rdoNeighbouring.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNeighbouring.Name = "rdoNeighbouring"
        Me.rdoNeighbouring.TabStop = True
        Me.rdoNeighbouring.UseVisualStyleBackColor = True
        '
        'grpMethods
        '
        Me.grpMethods.Controls.Add(Me.rdoNaStructTS)
        Me.grpMethods.Controls.Add(Me.rdoNaLocf)
        Me.grpMethods.Controls.Add(Me.rdoNaSpline)
        Me.grpMethods.Controls.Add(Me.rdoNaApproximate)
        Me.grpMethods.Controls.Add(Me.rdoNaFill)
        Me.grpMethods.Controls.Add(Me.rdoNaAggregate)
        Me.grpMethods.Controls.Add(Me.ucrPnlMethods)
        resources.ApplyResources(Me.grpMethods, "grpMethods")
        Me.grpMethods.Name = "grpMethods"
        Me.grpMethods.TabStop = False
        '
        'ucrPnlMethods
        '
        resources.ApplyResources(Me.ucrPnlMethods, "ucrPnlMethods")
        Me.ucrPnlMethods.Name = "ucrPnlMethods"
        '
        'ucrSaveNewColumn
        '
        resources.ApplyResources(Me.ucrSaveNewColumn, "ucrSaveNewColumn")
        Me.ucrSaveNewColumn.Name = "ucrSaveNewColumn"
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
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorInfillMissing
        '
        Me.ucrSelectorInfillMissing.bDropUnusedFilterLevels = False
        Me.ucrSelectorInfillMissing.bShowHiddenColumns = False
        Me.ucrSelectorInfillMissing.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorInfillMissing, "ucrSelectorInfillMissing")
        Me.ucrSelectorInfillMissing.Name = "ucrSelectorInfillMissing"
        '
        'ucrPnlOptions
        '
        resources.ApplyResources(Me.ucrPnlOptions, "ucrPnlOptions")
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        '
        'dlgInfillMissingValues
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveNewColumn)
        Me.Controls.Add(Me.rdoNeighbouring)
        Me.Controls.Add(Me.rdoMultiple)
        Me.Controls.Add(Me.rdoSingle)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorInfillMissing)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.grpMethods)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInfillMissingValues"
        Me.grpMethods.ResumeLayout(False)
        Me.grpMethods.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorInfillMissing As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents rdoNaApproximate As RadioButton
    Friend WithEvents rdoNaAggregate As RadioButton
    Friend WithEvents rdoNaFill As RadioButton
    Friend WithEvents rdoNaSpline As RadioButton
    Friend WithEvents rdoNaLocf As RadioButton
    Friend WithEvents rdoNaStructTS As RadioButton
    Friend WithEvents lblElement As Label
    Friend WithEvents rdoNeighbouring As RadioButton
    Friend WithEvents rdoMultiple As RadioButton
    Friend WithEvents rdoSingle As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrPnlMethods As UcrPanel
    Friend WithEvents grpMethods As GroupBox
    Friend WithEvents ucrSaveNewColumn As ucrSave
End Class
