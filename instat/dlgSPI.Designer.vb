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
        Me.rdoSpiSpeiMain = New System.Windows.Forms.RadioButton()
        Me.rdoKernal = New System.Windows.Forms.RadioButton()
        Me.rdoPet = New System.Windows.Forms.RadioButton()
        Me.lblSpiDate = New System.Windows.Forms.Label()
        Me.lblSpiYear = New System.Windows.Forms.Label()
        Me.lblSpiMonth = New System.Windows.Forms.Label()
        Me.lblSpiData = New System.Windows.Forms.Label()
        Me.optSpi = New System.Windows.Forms.Button()
        Me.rdoSpiSpi = New System.Windows.Forms.RadioButton()
        Me.rdoSpiSpei = New System.Windows.Forms.RadioButton()
        Me.lblSpiTimeScale = New System.Windows.Forms.Label()
        Me.chkSpiOmitMis = New System.Windows.Forms.CheckBox()
        Me.lblSpiSaveIndex = New System.Windows.Forms.Label()
        Me.grpSpiIndex = New System.Windows.Forms.GroupBox()
        Me.lblKernalTimeScale = New System.Windows.Forms.Label()
        Me.ucrNudKernalTimeScale = New System.Windows.Forms.NumericUpDown()
        Me.grpKernalChk = New System.Windows.Forms.GroupBox()
        Me.chkKernalGauss = New System.Windows.Forms.CheckBox()
        Me.chkKernalCircular = New System.Windows.Forms.CheckBox()
        Me.chkKernalTriangular = New System.Windows.Forms.CheckBox()
        Me.chkKernalRectangular = New System.Windows.Forms.CheckBox()
        Me.lblKernalShift = New System.Windows.Forms.Label()
        Me.ucrNudKernalShift = New System.Windows.Forms.NumericUpDown()
        Me.chkKernalPlot = New System.Windows.Forms.CheckBox()
        Me.txtSpiSaveIndex = New instat.ucrInputTextBox()
        Me.ucrReceiverData = New instat.ucrReceiverSingle()
        Me.ucrReceiverSpiMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverSpiYear = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverSpiDate = New instat.ucrReceiverSingle()
        Me.ucrSelectorSpi = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrNudTimeScale = New instat.ucrNud()
        Me.grpSpiIndex.SuspendLayout()
        CType(Me.ucrNudKernalTimeScale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpKernalChk.SuspendLayout()
        CType(Me.ucrNudKernalShift, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdoSpiSpeiMain
        '
        Me.rdoSpiSpeiMain.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSpiSpeiMain.AutoSize = True
        Me.rdoSpiSpeiMain.Location = New System.Drawing.Point(182, 57)
        Me.rdoSpiSpeiMain.Name = "rdoSpiSpeiMain"
        Me.rdoSpiSpeiMain.Size = New System.Drawing.Size(73, 27)
        Me.rdoSpiSpeiMain.TabIndex = 2
        Me.rdoSpiSpeiMain.TabStop = True
        Me.rdoSpiSpeiMain.Text = "SPI/SPEI"
        Me.rdoSpiSpeiMain.UseVisualStyleBackColor = True
        '
        'rdoKernal
        '
        Me.rdoKernal.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoKernal.AutoSize = True
        Me.rdoKernal.Location = New System.Drawing.Point(257, 57)
        Me.rdoKernal.Name = "rdoKernal"
        Me.rdoKernal.Size = New System.Drawing.Size(59, 27)
        Me.rdoKernal.TabIndex = 3
        Me.rdoKernal.TabStop = True
        Me.rdoKernal.Text = "Kernal"
        Me.rdoKernal.UseVisualStyleBackColor = True
        '
        'rdoPet
        '
        Me.rdoPet.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPet.AutoSize = True
        Me.rdoPet.Enabled = False
        Me.rdoPet.Location = New System.Drawing.Point(318, 57)
        Me.rdoPet.Name = "rdoPet"
        Me.rdoPet.Size = New System.Drawing.Size(45, 27)
        Me.rdoPet.TabIndex = 4
        Me.rdoPet.TabStop = True
        Me.rdoPet.Text = "PET"
        Me.rdoPet.UseVisualStyleBackColor = True
        '
        'lblSpiDate
        '
        Me.lblSpiDate.AutoSize = True
        Me.lblSpiDate.Location = New System.Drawing.Point(372, 121)
        Me.lblSpiDate.Name = "lblSpiDate"
        Me.lblSpiDate.Size = New System.Drawing.Size(38, 17)
        Me.lblSpiDate.TabIndex = 7
        Me.lblSpiDate.Text = "Date"
        '
        'lblSpiYear
        '
        Me.lblSpiYear.AutoSize = True
        Me.lblSpiYear.Location = New System.Drawing.Point(372, 173)
        Me.lblSpiYear.Name = "lblSpiYear"
        Me.lblSpiYear.Size = New System.Drawing.Size(38, 17)
        Me.lblSpiYear.TabIndex = 10
        Me.lblSpiYear.Text = "Year"
        '
        'lblSpiMonth
        '
        Me.lblSpiMonth.AutoSize = True
        Me.lblSpiMonth.Location = New System.Drawing.Point(372, 226)
        Me.lblSpiMonth.Name = "lblSpiMonth"
        Me.lblSpiMonth.Size = New System.Drawing.Size(47, 17)
        Me.lblSpiMonth.TabIndex = 12
        Me.lblSpiMonth.Text = "Month"
        '
        'lblSpiData
        '
        Me.lblSpiData.AutoSize = True
        Me.lblSpiData.Location = New System.Drawing.Point(372, 282)
        Me.lblSpiData.Name = "lblSpiData"
        Me.lblSpiData.Size = New System.Drawing.Size(38, 17)
        Me.lblSpiData.TabIndex = 14
        Me.lblSpiData.Text = "Data"
        '
        'optSpi
        '
        Me.optSpi.Location = New System.Drawing.Point(378, 357)
        Me.optSpi.Name = "optSpi"
        Me.optSpi.Size = New System.Drawing.Size(120, 36)
        Me.optSpi.TabIndex = 15
        Me.optSpi.Text = "Options"
        Me.optSpi.UseVisualStyleBackColor = True
        '
        'rdoSpiSpi
        '
        Me.rdoSpiSpi.AutoSize = True
        Me.rdoSpiSpi.Location = New System.Drawing.Point(38, 28)
        Me.rdoSpiSpi.Name = "rdoSpiSpi"
        Me.rdoSpiSpi.Size = New System.Drawing.Size(50, 21)
        Me.rdoSpiSpi.TabIndex = 19
        Me.rdoSpiSpi.TabStop = True
        Me.rdoSpiSpi.Text = "SPI"
        Me.rdoSpiSpi.UseVisualStyleBackColor = True
        '
        'rdoSpiSpei
        '
        Me.rdoSpiSpei.AutoSize = True
        Me.rdoSpiSpei.Location = New System.Drawing.Point(94, 28)
        Me.rdoSpiSpei.Name = "rdoSpiSpei"
        Me.rdoSpiSpei.Size = New System.Drawing.Size(59, 21)
        Me.rdoSpiSpei.TabIndex = 20
        Me.rdoSpiSpei.TabStop = True
        Me.rdoSpiSpei.Text = "SPEI"
        Me.rdoSpiSpei.UseVisualStyleBackColor = True
        '
        'lblSpiTimeScale
        '
        Me.lblSpiTimeScale.AutoSize = True
        Me.lblSpiTimeScale.Location = New System.Drawing.Point(29, 439)
        Me.lblSpiTimeScale.Name = "lblSpiTimeScale"
        Me.lblSpiTimeScale.Size = New System.Drawing.Size(78, 17)
        Me.lblSpiTimeScale.TabIndex = 21
        Me.lblSpiTimeScale.Text = "Time Scale"
        '
        'chkSpiOmitMis
        '
        Me.chkSpiOmitMis.AutoSize = True
        Me.chkSpiOmitMis.Location = New System.Drawing.Point(32, 475)
        Me.chkSpiOmitMis.Name = "chkSpiOmitMis"
        Me.chkSpiOmitMis.Size = New System.Drawing.Size(110, 21)
        Me.chkSpiOmitMis.TabIndex = 23
        Me.chkSpiOmitMis.Text = "Omit Missing"
        Me.chkSpiOmitMis.UseVisualStyleBackColor = True
        '
        'lblSpiSaveIndex
        '
        Me.lblSpiSaveIndex.AutoSize = True
        Me.lblSpiSaveIndex.Location = New System.Drawing.Point(29, 511)
        Me.lblSpiSaveIndex.Name = "lblSpiSaveIndex"
        Me.lblSpiSaveIndex.Size = New System.Drawing.Size(104, 17)
        Me.lblSpiSaveIndex.TabIndex = 24
        Me.lblSpiSaveIndex.Text = "Save Index into"
        '
        'grpSpiIndex
        '
        Me.grpSpiIndex.Controls.Add(Me.rdoSpiSpei)
        Me.grpSpiIndex.Controls.Add(Me.rdoSpiSpi)
        Me.grpSpiIndex.Location = New System.Drawing.Point(21, 365)
        Me.grpSpiIndex.Name = "grpSpiIndex"
        Me.grpSpiIndex.Size = New System.Drawing.Size(162, 56)
        Me.grpSpiIndex.TabIndex = 28
        Me.grpSpiIndex.TabStop = False
        Me.grpSpiIndex.Text = "Index"
        '
        'lblKernalTimeScale
        '
        Me.lblKernalTimeScale.AutoSize = True
        Me.lblKernalTimeScale.Location = New System.Drawing.Point(21, 156)
        Me.lblKernalTimeScale.Name = "lblKernalTimeScale"
        Me.lblKernalTimeScale.Size = New System.Drawing.Size(78, 17)
        Me.lblKernalTimeScale.TabIndex = 29
        Me.lblKernalTimeScale.Text = "Time Scale"
        '
        'ucrNudKernalTimeScale
        '
        Me.ucrNudKernalTimeScale.Location = New System.Drawing.Point(113, 154)
        Me.ucrNudKernalTimeScale.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.ucrNudKernalTimeScale.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudKernalTimeScale.Name = "ucrNudKernalTimeScale"
        Me.ucrNudKernalTimeScale.Size = New System.Drawing.Size(44, 22)
        Me.ucrNudKernalTimeScale.TabIndex = 29
        Me.ucrNudKernalTimeScale.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'grpKernalChk
        '
        Me.grpKernalChk.Controls.Add(Me.chkKernalGauss)
        Me.grpKernalChk.Controls.Add(Me.chkKernalCircular)
        Me.grpKernalChk.Controls.Add(Me.chkKernalTriangular)
        Me.grpKernalChk.Controls.Add(Me.chkKernalRectangular)
        Me.grpKernalChk.Location = New System.Drawing.Point(24, 229)
        Me.grpKernalChk.Name = "grpKernalChk"
        Me.grpKernalChk.Size = New System.Drawing.Size(172, 103)
        Me.grpKernalChk.TabIndex = 29
        Me.grpKernalChk.TabStop = False
        Me.grpKernalChk.Text = "Type"
        '
        'chkKernalGauss
        '
        Me.chkKernalGauss.AutoSize = True
        Me.chkKernalGauss.Location = New System.Drawing.Point(13, 82)
        Me.chkKernalGauss.Name = "chkKernalGauss"
        Me.chkKernalGauss.Size = New System.Drawing.Size(149, 21)
        Me.chkKernalGauss.TabIndex = 3
        Me.chkKernalGauss.Text = "Gaussian (Normal)"
        Me.chkKernalGauss.UseVisualStyleBackColor = True
        '
        'chkKernalCircular
        '
        Me.chkKernalCircular.AutoSize = True
        Me.chkKernalCircular.Location = New System.Drawing.Point(13, 61)
        Me.chkKernalCircular.Name = "chkKernalCircular"
        Me.chkKernalCircular.Size = New System.Drawing.Size(78, 21)
        Me.chkKernalCircular.TabIndex = 2
        Me.chkKernalCircular.Text = "Circular"
        Me.chkKernalCircular.UseVisualStyleBackColor = True
        '
        'chkKernalTriangular
        '
        Me.chkKernalTriangular.AutoSize = True
        Me.chkKernalTriangular.Location = New System.Drawing.Point(13, 41)
        Me.chkKernalTriangular.Name = "chkKernalTriangular"
        Me.chkKernalTriangular.Size = New System.Drawing.Size(95, 21)
        Me.chkKernalTriangular.TabIndex = 1
        Me.chkKernalTriangular.Text = "Triangular"
        Me.chkKernalTriangular.UseVisualStyleBackColor = True
        '
        'chkKernalRectangular
        '
        Me.chkKernalRectangular.AutoSize = True
        Me.chkKernalRectangular.Location = New System.Drawing.Point(13, 21)
        Me.chkKernalRectangular.Name = "chkKernalRectangular"
        Me.chkKernalRectangular.Size = New System.Drawing.Size(107, 21)
        Me.chkKernalRectangular.TabIndex = 0
        Me.chkKernalRectangular.Text = "Rectangular"
        Me.chkKernalRectangular.UseVisualStyleBackColor = True
        '
        'lblKernalShift
        '
        Me.lblKernalShift.AutoSize = True
        Me.lblKernalShift.Location = New System.Drawing.Point(21, 193)
        Me.lblKernalShift.Name = "lblKernalShift"
        Me.lblKernalShift.Size = New System.Drawing.Size(36, 17)
        Me.lblKernalShift.TabIndex = 29
        Me.lblKernalShift.Text = "Shift"
        '
        'ucrNudKernalShift
        '
        Me.ucrNudKernalShift.Location = New System.Drawing.Point(75, 191)
        Me.ucrNudKernalShift.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.ucrNudKernalShift.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudKernalShift.Name = "ucrNudKernalShift"
        Me.ucrNudKernalShift.Size = New System.Drawing.Size(44, 22)
        Me.ucrNudKernalShift.TabIndex = 30
        Me.ucrNudKernalShift.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkKernalPlot
        '
        Me.chkKernalPlot.AutoSize = True
        Me.chkKernalPlot.Location = New System.Drawing.Point(24, 345)
        Me.chkKernalPlot.Name = "chkKernalPlot"
        Me.chkKernalPlot.Size = New System.Drawing.Size(54, 21)
        Me.chkKernalPlot.TabIndex = 31
        Me.chkKernalPlot.Text = "Plot"
        Me.chkKernalPlot.UseVisualStyleBackColor = True
        '
        'txtSpiSaveIndex
        '
        Me.txtSpiSaveIndex.AddQuotesIfUnrecognised = True
        Me.txtSpiSaveIndex.IsMultiline = False
        Me.txtSpiSaveIndex.IsReadOnly = False
        Me.txtSpiSaveIndex.Location = New System.Drawing.Point(141, 511)
        Me.txtSpiSaveIndex.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtSpiSaveIndex.Name = "txtSpiSaveIndex"
        Me.txtSpiSaveIndex.Size = New System.Drawing.Size(114, 26)
        Me.txtSpiSaveIndex.TabIndex = 27
        '
        'ucrReceiverData
        '
        Me.ucrReceiverData.frmParent = Me
        Me.ucrReceiverData.Location = New System.Drawing.Point(375, 303)
        Me.ucrReceiverData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverData.Name = "ucrReceiverData"
        Me.ucrReceiverData.Selector = Nothing
        Me.ucrReceiverData.Size = New System.Drawing.Size(124, 26)
        Me.ucrReceiverData.strNcFilePath = ""
        Me.ucrReceiverData.TabIndex = 13
        Me.ucrReceiverData.ucrSelector = Nothing
        '
        'ucrReceiverSpiMonth
        '
        Me.ucrReceiverSpiMonth.frmParent = Me
        Me.ucrReceiverSpiMonth.Location = New System.Drawing.Point(375, 247)
        Me.ucrReceiverSpiMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSpiMonth.Name = "ucrReceiverSpiMonth"
        Me.ucrReceiverSpiMonth.Selector = Nothing
        Me.ucrReceiverSpiMonth.Size = New System.Drawing.Size(124, 26)
        Me.ucrReceiverSpiMonth.strNcFilePath = ""
        Me.ucrReceiverSpiMonth.TabIndex = 11
        Me.ucrReceiverSpiMonth.ucrSelector = Nothing
        '
        'ucrReceiverSpiYear
        '
        Me.ucrReceiverSpiYear.frmParent = Me
        Me.ucrReceiverSpiYear.Location = New System.Drawing.Point(375, 193)
        Me.ucrReceiverSpiYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSpiYear.Name = "ucrReceiverSpiYear"
        Me.ucrReceiverSpiYear.Selector = Nothing
        Me.ucrReceiverSpiYear.Size = New System.Drawing.Size(124, 26)
        Me.ucrReceiverSpiYear.strNcFilePath = ""
        Me.ucrReceiverSpiYear.TabIndex = 9
        Me.ucrReceiverSpiYear.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(21, 568)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(561, 74)
        Me.ucrBase.TabIndex = 8
        '
        'ucrReceiverSpiDate
        '
        Me.ucrReceiverSpiDate.frmParent = Me
        Me.ucrReceiverSpiDate.Location = New System.Drawing.Point(375, 142)
        Me.ucrReceiverSpiDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSpiDate.Name = "ucrReceiverSpiDate"
        Me.ucrReceiverSpiDate.Selector = Nothing
        Me.ucrReceiverSpiDate.Size = New System.Drawing.Size(124, 31)
        Me.ucrReceiverSpiDate.strNcFilePath = ""
        Me.ucrReceiverSpiDate.TabIndex = 6
        Me.ucrReceiverSpiDate.ucrSelector = Nothing
        '
        'ucrSelectorSpi
        '
        Me.ucrSelectorSpi.bShowHiddenColumns = False
        Me.ucrSelectorSpi.bUseCurrentFilter = True
        Me.ucrSelectorSpi.Location = New System.Drawing.Point(24, 112)
        Me.ucrSelectorSpi.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSpi.Name = "ucrSelectorSpi"
        Me.ucrSelectorSpi.Size = New System.Drawing.Size(333, 254)
        Me.ucrSelectorSpi.TabIndex = 5
        '
        'ucrNudTimeScale
        '
        Me.ucrNudTimeScale.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTimeScale.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTimeScale.Location = New System.Drawing.Point(108, 439)
        Me.ucrNudTimeScale.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrNudTimeScale.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.ucrNudTimeScale.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTimeScale.Name = "ucrNudTimeScale"
        Me.ucrNudTimeScale.Size = New System.Drawing.Size(49, 29)
        Me.ucrNudTimeScale.TabIndex = 32
        Me.ucrNudTimeScale.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'dlgSPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 646)
        Me.Controls.Add(Me.ucrNudTimeScale)
        Me.Controls.Add(Me.grpSpiIndex)
        Me.Controls.Add(Me.txtSpiSaveIndex)
        Me.Controls.Add(Me.lblSpiSaveIndex)
        Me.Controls.Add(Me.chkSpiOmitMis)
        Me.Controls.Add(Me.lblSpiTimeScale)
        Me.Controls.Add(Me.optSpi)
        Me.Controls.Add(Me.lblSpiData)
        Me.Controls.Add(Me.ucrReceiverData)
        Me.Controls.Add(Me.lblSpiMonth)
        Me.Controls.Add(Me.ucrReceiverSpiMonth)
        Me.Controls.Add(Me.lblSpiYear)
        Me.Controls.Add(Me.ucrReceiverSpiYear)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblSpiDate)
        Me.Controls.Add(Me.ucrReceiverSpiDate)
        Me.Controls.Add(Me.ucrSelectorSpi)
        Me.Controls.Add(Me.rdoPet)
        Me.Controls.Add(Me.rdoKernal)
        Me.Controls.Add(Me.rdoSpiSpeiMain)
        Me.Controls.Add(Me.grpKernalChk)
        Me.Controls.Add(Me.chkKernalPlot)
        Me.Controls.Add(Me.lblKernalShift)
        Me.Controls.Add(Me.ucrNudKernalShift)
        Me.Controls.Add(Me.lblKernalTimeScale)
        Me.Controls.Add(Me.ucrNudKernalTimeScale)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSPI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Standardized Precipitation Index"
        Me.grpSpiIndex.ResumeLayout(False)
        Me.grpSpiIndex.PerformLayout()
        CType(Me.ucrNudKernalTimeScale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpKernalChk.ResumeLayout(False)
        Me.grpKernalChk.PerformLayout()
        CType(Me.ucrNudKernalShift, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdoSpiSpeiMain As RadioButton
    Friend WithEvents rdoKernal As RadioButton
    Friend WithEvents rdoPet As RadioButton
    Friend WithEvents ucrSelectorSpi As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverSpiDate As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblSpiDate As Label
    Friend WithEvents ucrReceiverSpiYear As ucrReceiverSingle
    Friend WithEvents lblSpiYear As Label
    Friend WithEvents lblSpiData As Label
    Friend WithEvents ucrReceiverData As ucrReceiverSingle
    Friend WithEvents lblSpiMonth As Label
    Friend WithEvents ucrReceiverSpiMonth As ucrReceiverSingle
    Friend WithEvents optSpi As Button
    Friend WithEvents lblSpiTimeScale As Label
    Friend WithEvents rdoSpiSpei As RadioButton
    Friend WithEvents rdoSpiSpi As RadioButton
    Friend WithEvents lblSpiSaveIndex As Label
    Friend WithEvents chkSpiOmitMis As CheckBox
    Friend WithEvents txtSpiSaveIndex As ucrInputTextBox
    Friend WithEvents grpSpiIndex As GroupBox
    Friend WithEvents ucrNudKernalTimeScale As NumericUpDown
    Friend WithEvents lblKernalTimeScale As Label
    Friend WithEvents grpKernalChk As GroupBox
    Friend WithEvents chkKernalGauss As CheckBox
    Friend WithEvents chkKernalCircular As CheckBox
    Friend WithEvents chkKernalTriangular As CheckBox
    Friend WithEvents chkKernalRectangular As CheckBox
    Friend WithEvents chkKernalPlot As CheckBox
    Friend WithEvents ucrNudKernalShift As NumericUpDown
    Friend WithEvents lblKernalShift As Label
    Friend WithEvents ucrNudTimeScale As ucrNud
End Class
