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
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.grpIndex = New System.Windows.Forms.GroupBox()
        Me.rdoSPEI = New System.Windows.Forms.RadioButton()
        Me.rdoSPI = New System.Windows.Forms.RadioButton()
        Me.lblTimeScale = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.grpKernel = New System.Windows.Forms.GroupBox()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.grpKernelType = New System.Windows.Forms.GroupBox()
        Me.rdoRectangular = New System.Windows.Forms.RadioButton()
        Me.rdoGaussian = New System.Windows.Forms.RadioButton()
        Me.rdoCircular = New System.Windows.Forms.RadioButton()
        Me.rdoTriangular = New System.Windows.Forms.RadioButton()
        Me.ucrSaveModel = New instat.ucrSave()
        Me.ucrSaveIndex = New instat.ucrSave()
        Me.ucrPnlKernelType = New instat.UcrPanel()
        Me.ucrNudKernelShift = New instat.ucrNud()
        Me.ucrNudTimeScale = New instat.ucrNud()
        Me.ucrChkOmitMissingValues = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlIndex = New instat.UcrPanel()
        Me.ucrReceiverData = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrSelectorVariable = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpIndex.SuspendLayout()
        Me.grpKernel.SuspendLayout()
        Me.grpKernelType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDate
        '
        resources.ApplyResources(Me.lblDate, "lblDate")
        Me.lblDate.Name = "lblDate"
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
        'grpIndex
        '
        Me.grpIndex.Controls.Add(Me.rdoSPEI)
        Me.grpIndex.Controls.Add(Me.rdoSPI)
        Me.grpIndex.Controls.Add(Me.ucrPnlIndex)
        resources.ApplyResources(Me.grpIndex, "grpIndex")
        Me.grpIndex.Name = "grpIndex"
        Me.grpIndex.TabStop = False
        '
        'rdoSPEI
        '
        resources.ApplyResources(Me.rdoSPEI, "rdoSPEI")
        Me.rdoSPEI.Name = "rdoSPEI"
        Me.rdoSPEI.TabStop = True
        Me.rdoSPEI.UseVisualStyleBackColor = True
        '
        'rdoSPI
        '
        resources.ApplyResources(Me.rdoSPI, "rdoSPI")
        Me.rdoSPI.Name = "rdoSPI"
        Me.rdoSPI.TabStop = True
        Me.rdoSPI.UseVisualStyleBackColor = True
        '
        'lblTimeScale
        '
        resources.ApplyResources(Me.lblTimeScale, "lblTimeScale")
        Me.lblTimeScale.Name = "lblTimeScale"
        '
        'grpKernel
        '
        Me.grpKernel.Controls.Add(Me.lblShift)
        Me.grpKernel.Controls.Add(Me.grpKernelType)
        Me.grpKernel.Controls.Add(Me.ucrNudKernelShift)
        resources.ApplyResources(Me.grpKernel, "grpKernel")
        Me.grpKernel.Name = "grpKernel"
        Me.grpKernel.TabStop = False
        '
        'lblShift
        '
        resources.ApplyResources(Me.lblShift, "lblShift")
        Me.lblShift.Name = "lblShift"
        '
        'grpKernelType
        '
        Me.grpKernelType.Controls.Add(Me.rdoRectangular)
        Me.grpKernelType.Controls.Add(Me.rdoGaussian)
        Me.grpKernelType.Controls.Add(Me.rdoCircular)
        Me.grpKernelType.Controls.Add(Me.rdoTriangular)
        Me.grpKernelType.Controls.Add(Me.ucrPnlKernelType)
        resources.ApplyResources(Me.grpKernelType, "grpKernelType")
        Me.grpKernelType.Name = "grpKernelType"
        Me.grpKernelType.TabStop = False
        '
        'rdoRectangular
        '
        resources.ApplyResources(Me.rdoRectangular, "rdoRectangular")
        Me.rdoRectangular.Name = "rdoRectangular"
        Me.rdoRectangular.TabStop = True
        Me.rdoRectangular.UseVisualStyleBackColor = True
        '
        'rdoGaussian
        '
        resources.ApplyResources(Me.rdoGaussian, "rdoGaussian")
        Me.rdoGaussian.Name = "rdoGaussian"
        Me.rdoGaussian.TabStop = True
        Me.rdoGaussian.UseVisualStyleBackColor = True
        '
        'rdoCircular
        '
        resources.ApplyResources(Me.rdoCircular, "rdoCircular")
        Me.rdoCircular.Name = "rdoCircular"
        Me.rdoCircular.TabStop = True
        Me.rdoCircular.UseVisualStyleBackColor = True
        '
        'rdoTriangular
        '
        resources.ApplyResources(Me.rdoTriangular, "rdoTriangular")
        Me.rdoTriangular.Name = "rdoTriangular"
        Me.rdoTriangular.TabStop = True
        Me.rdoTriangular.UseVisualStyleBackColor = True
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
        'ucrPnlKernelType
        '
        resources.ApplyResources(Me.ucrPnlKernelType, "ucrPnlKernelType")
        Me.ucrPnlKernelType.Name = "ucrPnlKernelType"
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
        'ucrPnlIndex
        '
        resources.ApplyResources(Me.ucrPnlIndex, "ucrPnlIndex")
        Me.ucrPnlIndex.Name = "ucrPnlIndex"
        '
        'ucrReceiverData
        '
        Me.ucrReceiverData.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverData, "ucrReceiverData")
        Me.ucrReceiverData.Name = "ucrReceiverData"
        Me.ucrReceiverData.Selector = Nothing
        Me.ucrReceiverData.strNcFilePath = ""
        Me.ucrReceiverData.ucrSelector = Nothing
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
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDate, "ucrReceiverDate")
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.ucrSelector = Nothing
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
        Me.Controls.Add(Me.ucrSaveModel)
        Me.Controls.Add(Me.ucrSaveIndex)
        Me.Controls.Add(Me.grpKernel)
        Me.Controls.Add(Me.ucrNudTimeScale)
        Me.Controls.Add(Me.ucrChkOmitMissingValues)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblTimeScale)
        Me.Controls.Add(Me.grpIndex)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverData)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrSelectorVariable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSPI"
        Me.grpIndex.ResumeLayout(False)
        Me.grpIndex.PerformLayout()
        Me.grpKernel.ResumeLayout(False)
        Me.grpKernel.PerformLayout()
        Me.grpKernelType.ResumeLayout(False)
        Me.grpKernelType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSelectorVariable As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverData As ucrReceiverSingle
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblData As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents grpIndex As GroupBox
    Friend WithEvents rdoSPEI As RadioButton
    Friend WithEvents rdoSPI As RadioButton
    Friend WithEvents lblTimeScale As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkOmitMissingValues As ucrCheck
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ucrNudTimeScale As ucrNud
    Friend WithEvents grpKernel As GroupBox
    Friend WithEvents rdoRectangular As RadioButton
    Friend WithEvents rdoTriangular As RadioButton
    Friend WithEvents ucrPnlKernelType As UcrPanel
    Friend WithEvents rdoCircular As RadioButton
    Friend WithEvents rdoGaussian As RadioButton
    Friend WithEvents lblShift As Label
    Friend WithEvents ucrNudKernelShift As ucrNud
    Friend WithEvents ucrPnlIndex As UcrPanel
    Friend WithEvents ucrSaveIndex As ucrSave
    Friend WithEvents grpKernelType As GroupBox
    Friend WithEvents ucrSaveModel As ucrSave
End Class