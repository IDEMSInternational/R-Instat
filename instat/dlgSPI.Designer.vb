<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSPI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgSPI))
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.rdoSPEI = New System.Windows.Forms.RadioButton()
        Me.rdoSPI = New System.Windows.Forms.RadioButton()
        Me.ucrPnlIndex = New instat.UcrPanel()
        Me.lblTimeScale = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.grpKernel = New System.Windows.Forms.GroupBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.ucrInputType = New instat.ucrInputComboBox()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.ucrNudKernelShift = New instat.ucrNud()
        Me.ucrSaveModel = New instat.ucrSave()
        Me.ucrSaveIndex = New instat.ucrSave()
        Me.ucrNudTimeScale = New instat.ucrNud()
        Me.ucrChkOmitMissingValues = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrSelectorVariable = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpKernel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStation
        '
        resources.ApplyResources(Me.lblStation, "lblStation")
        Me.lblStation.Name = "lblStation"
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        '
        'lblMonth
        '
        resources.ApplyResources(Me.lblMonth, "lblMonth")
        Me.lblMonth.Name = "lblMonth"
        '
        'lblData
        '
        resources.ApplyResources(Me.lblData, "lblData")
        Me.lblData.Name = "lblData"
        '
        'rdoSPEI
        '
        resources.ApplyResources(Me.rdoSPEI, "rdoSPEI")
        Me.rdoSPEI.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSPEI.FlatAppearance.BorderSize = 2
        Me.rdoSPEI.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSPEI.Name = "rdoSPEI"
        Me.rdoSPEI.TabStop = True
        Me.rdoSPEI.UseVisualStyleBackColor = True
        '
        'rdoSPI
        '
        resources.ApplyResources(Me.rdoSPI, "rdoSPI")
        Me.rdoSPI.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSPI.FlatAppearance.BorderSize = 2
        Me.rdoSPI.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSPI.Name = "rdoSPI"
        Me.rdoSPI.TabStop = True
        Me.rdoSPI.UseVisualStyleBackColor = True
        '
        'ucrPnlIndex
        '
        resources.ApplyResources(Me.ucrPnlIndex, "ucrPnlIndex")
        Me.ucrPnlIndex.Name = "ucrPnlIndex"
        '
        'lblTimeScale
        '
        resources.ApplyResources(Me.lblTimeScale, "lblTimeScale")
        Me.lblTimeScale.Name = "lblTimeScale"
        '
        'grpKernel
        '
        Me.grpKernel.Controls.Add(Me.lblType)
        Me.grpKernel.Controls.Add(Me.ucrInputType)
        Me.grpKernel.Controls.Add(Me.lblShift)
        Me.grpKernel.Controls.Add(Me.ucrNudKernelShift)
        resources.ApplyResources(Me.grpKernel, "grpKernel")
        Me.grpKernel.Name = "grpKernel"
        Me.grpKernel.TabStop = False
        '
        'lblType
        '
        resources.ApplyResources(Me.lblType, "lblType")
        Me.lblType.Name = "lblType"
        '
        'ucrInputType
        '
        Me.ucrInputType.AddQuotesIfUnrecognised = True
        Me.ucrInputType.GetSetSelectedIndex = -1
        Me.ucrInputType.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputType, "ucrInputType")
        Me.ucrInputType.Name = "ucrInputType"
        '
        'lblShift
        '
        resources.ApplyResources(Me.lblShift, "lblShift")
        Me.lblShift.Name = "lblShift"
        '
        'ucrNudKernelShift
        '
        Me.ucrNudKernelShift.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudKernelShift.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudKernelShift, "ucrNudKernelShift")
        Me.ucrNudKernelShift.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.ucrNudKernelShift.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudKernelShift.Name = "ucrNudKernelShift"
        Me.ucrNudKernelShift.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSaveModel
        '
        resources.ApplyResources(Me.ucrSaveModel, "ucrSaveModel")
        Me.ucrSaveModel.Name = "ucrSaveModel"
        '
        'ucrSaveIndex
        '
        resources.ApplyResources(Me.ucrSaveIndex, "ucrSaveIndex")
        Me.ucrSaveIndex.Name = "ucrSaveIndex"
        '
        'ucrNudTimeScale
        '
        Me.ucrNudTimeScale.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTimeScale.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudTimeScale, "ucrNudTimeScale")
        Me.ucrNudTimeScale.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.ucrNudTimeScale.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTimeScale.Name = "ucrNudTimeScale"
        Me.ucrNudTimeScale.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrChkOmitMissingValues
        '
        Me.ucrChkOmitMissingValues.Checked = False
        resources.ApplyResources(Me.ucrChkOmitMissingValues, "ucrChkOmitMissingValues")
        Me.ucrChkOmitMissingValues.Name = "ucrChkOmitMissingValues"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
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
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMonth, "ucrReceiverMonth")
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYear, "ucrReceiverYear")
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverStation, "ucrReceiverStation")
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrSelectorVariable
        '
        Me.ucrSelectorVariable.bDropUnusedFilterLevels = False
        Me.ucrSelectorVariable.bShowHiddenColumns = False
        Me.ucrSelectorVariable.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorVariable, "ucrSelectorVariable")
        Me.ucrSelectorVariable.Name = "ucrSelectorVariable"
        '
        'dlgSPI
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rdoSPEI)
        Me.Controls.Add(Me.rdoSPI)
        Me.Controls.Add(Me.ucrPnlIndex)
        Me.Controls.Add(Me.ucrSaveModel)
        Me.Controls.Add(Me.ucrSaveIndex)
        Me.Controls.Add(Me.grpKernel)
        Me.Controls.Add(Me.ucrNudTimeScale)
        Me.Controls.Add(Me.ucrChkOmitMissingValues)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblTimeScale)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrSelectorVariable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSPI"
        Me.grpKernel.ResumeLayout(False)
        Me.grpKernel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSelectorVariable As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblData As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents rdoSPEI As RadioButton
    Friend WithEvents rdoSPI As RadioButton
    Friend WithEvents lblTimeScale As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkOmitMissingValues As ucrCheck
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ucrNudTimeScale As ucrNud
    Friend WithEvents grpKernel As GroupBox
    Friend WithEvents lblShift As Label
    Friend WithEvents ucrNudKernelShift As ucrNud
    Friend WithEvents ucrPnlIndex As UcrPanel
    Friend WithEvents ucrSaveIndex As ucrSave
    Friend WithEvents ucrSaveModel As ucrSave
    Friend WithEvents lblType As Label
    Friend WithEvents ucrInputType As ucrInputComboBox
End Class