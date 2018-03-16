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
        Me.rdoSPISPEI = New System.Windows.Forms.RadioButton()
        Me.rdoKernal = New System.Windows.Forms.RadioButton()
        Me.rdoPET = New System.Windows.Forms.RadioButton()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.GrpIndex = New System.Windows.Forms.GroupBox()
        Me.rdoSPEI = New System.Windows.Forms.RadioButton()
        Me.rdoSPI = New System.Windows.Forms.RadioButton()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblsaveindex = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.UcrtimeScale = New instat.ucrNud()
        Me.ucrChkOmitMissingValues = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputIndex = New instat.ucrInputTextBox()
        Me.ucrReceiverData = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrSelectorVariable = New instat.ucrSelectorByDataFrameAddRemove()
        Me.GrpIndex.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoSPISPEI
        '
        resources.ApplyResources(Me.rdoSPISPEI, "rdoSPISPEI")
        Me.rdoSPISPEI.Name = "rdoSPISPEI"
        Me.rdoSPISPEI.TabStop = True
        Me.rdoSPISPEI.UseVisualStyleBackColor = True
        '
        'rdoKernal
        '
        resources.ApplyResources(Me.rdoKernal, "rdoKernal")
        Me.rdoKernal.Name = "rdoKernal"
        Me.rdoKernal.TabStop = True
        Me.rdoKernal.UseVisualStyleBackColor = True
        '
        'rdoPET
        '
        resources.ApplyResources(Me.rdoPET, "rdoPET")
        Me.rdoPET.Name = "rdoPET"
        Me.rdoPET.TabStop = True
        Me.rdoPET.UseVisualStyleBackColor = True
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
        'GrpIndex
        '
        Me.GrpIndex.Controls.Add(Me.rdoSPEI)
        Me.GrpIndex.Controls.Add(Me.rdoSPI)
        resources.ApplyResources(Me.GrpIndex, "GrpIndex")
        Me.GrpIndex.Name = "GrpIndex"
        Me.GrpIndex.TabStop = False
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
        'lblsaveindex
        '
        resources.ApplyResources(Me.lblsaveindex, "lblsaveindex")
        Me.lblsaveindex.Name = "lblsaveindex"
        '
        'UcrtimeScale
        '
        Me.UcrtimeScale.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrtimeScale.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.UcrtimeScale, "UcrtimeScale")
        Me.UcrtimeScale.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.UcrtimeScale.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrtimeScale.Name = "UcrtimeScale"
        Me.UcrtimeScale.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        'ucrInputIndex
        '
        Me.ucrInputIndex.AddQuotesIfUnrecognised = True
        Me.ucrInputIndex.IsMultiline = False
        Me.ucrInputIndex.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputIndex, "ucrInputIndex")
        Me.ucrInputIndex.Name = "ucrInputIndex"
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
        Me.Controls.Add(Me.UcrtimeScale)
        Me.Controls.Add(Me.ucrChkOmitMissingValues)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrInputIndex)
        Me.Controls.Add(Me.lblsaveindex)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.GrpIndex)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverData)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrSelectorVariable)
        Me.Controls.Add(Me.rdoPET)
        Me.Controls.Add(Me.rdoKernal)
        Me.Controls.Add(Me.rdoSPISPEI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSPI"
        Me.GrpIndex.ResumeLayout(False)
        Me.GrpIndex.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents rdoSPISPEI As RadioButton
    Friend WithEvents rdoKernal As RadioButton
    Friend WithEvents rdoPET As RadioButton
    Friend WithEvents ucrSelectorVariable As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverData As ucrReceiverSingle
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents lblData As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents GrpIndex As GroupBox
    Friend WithEvents rdoSPEI As RadioButton
    Friend WithEvents rdoSPI As RadioButton
    Friend WithEvents lblsaveindex As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents ucrInputIndex As ucrInputTextBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkOmitMissingValues As ucrCheck
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents UcrtimeScale As ucrNud
End Class