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
        Me.lblTime = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.grpKernal = New System.Windows.Forms.GroupBox()
        Me.RdoRect = New System.Windows.Forms.RadioButton()
        Me.Rdocirc = New System.Windows.Forms.RadioButton()
        Me.RdoGaus = New System.Windows.Forms.RadioButton()
        Me.RdoTri = New System.Windows.Forms.RadioButton()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.grpKernType = New System.Windows.Forms.GroupBox()
        Me.ucrSaveIndex = New instat.ucrSave()
        Me.ucrPnlType = New instat.UcrPanel()
        Me.ucrKernShift = New instat.ucrNud()
        Me.ucrTimeScale = New instat.ucrNud()
        Me.ucrChkOmitMissingValues = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlInd = New instat.UcrPanel()
        Me.ucrReceiverData = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrSelectorVariable = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpIndex.SuspendLayout()
        Me.grpKernal.SuspendLayout()
        Me.grpKernType.SuspendLayout()
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
        Me.grpIndex.Controls.Add(Me.ucrPnlInd)
        Me.grpIndex.Controls.Add(Me.rdoSPEI)
        Me.grpIndex.Controls.Add(Me.rdoSPI)
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
        'lblTime
        '
        resources.ApplyResources(Me.lblTime, "lblTime")
        Me.lblTime.Name = "lblTime"
        '
        'grpKernal
        '
        Me.grpKernal.Controls.Add(Me.lblShift)
        Me.grpKernal.Controls.Add(Me.grpKernType)
        Me.grpKernal.Controls.Add(Me.ucrKernShift)
        resources.ApplyResources(Me.grpKernal, "grpKernal")
        Me.grpKernal.Name = "grpKernal"
        Me.grpKernal.TabStop = False
        '
        'RdoRect
        '
        resources.ApplyResources(Me.RdoRect, "RdoRect")
        Me.RdoRect.Name = "RdoRect"
        Me.RdoRect.TabStop = True
        Me.RdoRect.UseVisualStyleBackColor = True
        '
        'Rdocirc
        '
        resources.ApplyResources(Me.Rdocirc, "Rdocirc")
        Me.Rdocirc.Name = "Rdocirc"
        Me.Rdocirc.TabStop = True
        Me.Rdocirc.UseVisualStyleBackColor = True
        '
        'RdoGaus
        '
        resources.ApplyResources(Me.RdoGaus, "RdoGaus")
        Me.RdoGaus.Name = "RdoGaus"
        Me.RdoGaus.TabStop = True
        Me.RdoGaus.UseVisualStyleBackColor = True
        '
        'RdoTri
        '
        resources.ApplyResources(Me.RdoTri, "RdoTri")
        Me.RdoTri.Name = "RdoTri"
        Me.RdoTri.TabStop = True
        Me.RdoTri.UseVisualStyleBackColor = True
        '
        'lblShift
        '
        resources.ApplyResources(Me.lblShift, "lblShift")
        Me.lblShift.Name = "lblShift"
        '
        'grpKernType
        '
        Me.grpKernType.Controls.Add(Me.ucrPnlType)
        Me.grpKernType.Controls.Add(Me.RdoRect)
        Me.grpKernType.Controls.Add(Me.RdoGaus)
        Me.grpKernType.Controls.Add(Me.Rdocirc)
        Me.grpKernType.Controls.Add(Me.RdoTri)
        resources.ApplyResources(Me.grpKernType, "grpKernType")
        Me.grpKernType.Name = "grpKernType"
        Me.grpKernType.TabStop = False
        '
        'ucrSaveIndex
        '
        resources.ApplyResources(Me.ucrSaveIndex, "ucrSaveIndex")
        Me.ucrSaveIndex.Name = "ucrSaveIndex"
        '
        'ucrPnlType
        '
        resources.ApplyResources(Me.ucrPnlType, "ucrPnlType")
        Me.ucrPnlType.Name = "ucrPnlType"
        '
        'ucrKernShift
        '
        Me.ucrKernShift.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrKernShift.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrKernShift, "ucrKernShift")
        Me.ucrKernShift.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.ucrKernShift.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrKernShift.Name = "ucrKernShift"
        Me.ucrKernShift.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'ucrTimeScale
        '
        Me.ucrTimeScale.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrTimeScale.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrTimeScale, "ucrTimeScale")
        Me.ucrTimeScale.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.ucrTimeScale.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrTimeScale.Name = "ucrTimeScale"
        Me.ucrTimeScale.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        'ucrPnlInd
        '
        resources.ApplyResources(Me.ucrPnlInd, "ucrPnlInd")
        Me.ucrPnlInd.Name = "ucrPnlInd"
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
        Me.ucrSelectorVariable.bShowHiddenColumns = False
        Me.ucrSelectorVariable.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorVariable, "ucrSelectorVariable")
        Me.ucrSelectorVariable.Name = "ucrSelectorVariable"
        '
        'dlgSPI
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveIndex)
        Me.Controls.Add(Me.grpKernal)
        Me.Controls.Add(Me.ucrTimeScale)
        Me.Controls.Add(Me.ucrChkOmitMissingValues)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblTime)
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
        Me.grpKernal.ResumeLayout(False)
        Me.grpKernal.PerformLayout()
        Me.grpKernType.ResumeLayout(False)
        Me.grpKernType.PerformLayout()
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
    Friend WithEvents lblTime As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkOmitMissingValues As ucrCheck
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ucrTimeScale As ucrNud
    Friend WithEvents grpKernal As GroupBox
    Friend WithEvents RdoRect As RadioButton
    Friend WithEvents RdoTri As RadioButton
    Friend WithEvents ucrPnlType As UcrPanel
    Friend WithEvents Rdocirc As RadioButton
    Friend WithEvents RdoGaus As RadioButton
    Friend WithEvents lblShift As Label
    Friend WithEvents ucrKernShift As ucrNud
    Friend WithEvents ucrPnlInd As UcrPanel
    Friend WithEvents ucrSaveIndex As ucrSave
    Friend WithEvents grpKernType As GroupBox
End Class