<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SPI
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
        Me.ucrChkOmitMissingValues = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputIndex = New instat.ucrInputTextBox()
        Me.ucrReceiverData = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrSelectorVariable = New instat.ucrSelectorByDataFrameAddRemove()
        Me.UcrtimeScale = New instat.ucrNud()
        Me.GrpIndex.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoSPISPEI
        '
        Me.rdoSPISPEI.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSPISPEI.AutoSize = True
        Me.rdoSPISPEI.Location = New System.Drawing.Point(70, 17)
        Me.rdoSPISPEI.Name = "rdoSPISPEI"
        Me.rdoSPISPEI.Size = New System.Drawing.Size(63, 23)
        Me.rdoSPISPEI.TabIndex = 1
        Me.rdoSPISPEI.TabStop = True
        Me.rdoSPISPEI.Text = "SPI/SPEI"
        Me.rdoSPISPEI.UseVisualStyleBackColor = True
        '
        'rdoKernal
        '
        Me.rdoKernal.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoKernal.AutoSize = True
        Me.rdoKernal.Location = New System.Drawing.Point(130, 17)
        Me.rdoKernal.Name = "rdoKernal"
        Me.rdoKernal.Size = New System.Drawing.Size(47, 23)
        Me.rdoKernal.TabIndex = 2
        Me.rdoKernal.TabStop = True
        Me.rdoKernal.Text = "Kernal"
        Me.rdoKernal.UseVisualStyleBackColor = True
        '
        'rdoPET
        '
        Me.rdoPET.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPET.AutoSize = True
        Me.rdoPET.Location = New System.Drawing.Point(172, 17)
        Me.rdoPET.Name = "rdoPET"
        Me.rdoPET.Size = New System.Drawing.Size(38, 23)
        Me.rdoPET.TabIndex = 3
        Me.rdoPET.TabStop = True
        Me.rdoPET.Text = "PET"
        Me.rdoPET.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(258, 95)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 9
        Me.lblDate.Text = "Date"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(258, 138)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 10
        Me.lblYear.Text = "Year"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(258, 179)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(37, 13)
        Me.lblMonth.TabIndex = 11
        Me.lblMonth.Text = "Month"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(258, 225)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(30, 13)
        Me.lblData.TabIndex = 12
        Me.lblData.Text = "Data"
        '
        'GrpIndex
        '
        Me.GrpIndex.Controls.Add(Me.rdoSPEI)
        Me.GrpIndex.Controls.Add(Me.rdoSPI)
        Me.GrpIndex.Location = New System.Drawing.Point(9, 238)
        Me.GrpIndex.Name = "GrpIndex"
        Me.GrpIndex.Size = New System.Drawing.Size(149, 52)
        Me.GrpIndex.TabIndex = 13
        Me.GrpIndex.TabStop = False
        Me.GrpIndex.Text = "Index"
        '
        'rdoSPEI
        '
        Me.rdoSPEI.AutoSize = True
        Me.rdoSPEI.Location = New System.Drawing.Point(65, 20)
        Me.rdoSPEI.Name = "rdoSPEI"
        Me.rdoSPEI.Size = New System.Drawing.Size(49, 17)
        Me.rdoSPEI.TabIndex = 1
        Me.rdoSPEI.TabStop = True
        Me.rdoSPEI.Text = "SPEI"
        Me.rdoSPEI.UseVisualStyleBackColor = True
        '
        'rdoSPI
        '
        Me.rdoSPI.AutoSize = True
        Me.rdoSPI.Location = New System.Drawing.Point(7, 20)
        Me.rdoSPI.Name = "rdoSPI"
        Me.rdoSPI.Size = New System.Drawing.Size(42, 17)
        Me.rdoSPI.TabIndex = 0
        Me.rdoSPI.TabStop = True
        Me.rdoSPI.Text = "SPI"
        Me.rdoSPI.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(13, 293)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(60, 13)
        Me.lblTime.TabIndex = 15
        Me.lblTime.Text = "Time Scale"
        '
        'lblsaveindex
        '
        Me.lblsaveindex.AutoSize = True
        Me.lblsaveindex.Location = New System.Drawing.Point(12, 360)
        Me.lblsaveindex.Name = "lblsaveindex"
        Me.lblsaveindex.Size = New System.Drawing.Size(80, 13)
        Me.lblsaveindex.TabIndex = 17
        Me.lblsaveindex.Text = "Save index into"
        '
        'ucrChkOmitMissingValues
        '
        Me.ucrChkOmitMissingValues.Checked = False
        Me.ucrChkOmitMissingValues.Location = New System.Drawing.Point(12, 334)
        Me.ucrChkOmitMissingValues.Name = "ucrChkOmitMissingValues"
        Me.ucrChkOmitMissingValues.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkOmitMissingValues.TabIndex = 22
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 387)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 69)
        Me.ucrBase.TabIndex = 19
        '
        'ucrInputIndex
        '
        Me.ucrInputIndex.AddQuotesIfUnrecognised = True
        Me.ucrInputIndex.IsMultiline = False
        Me.ucrInputIndex.IsReadOnly = False
        Me.ucrInputIndex.Location = New System.Drawing.Point(98, 360)
        Me.ucrInputIndex.Name = "ucrInputIndex"
        Me.ucrInputIndex.Size = New System.Drawing.Size(79, 31)
        Me.ucrInputIndex.TabIndex = 18
        '
        'ucrReceiverData
        '
        Me.ucrReceiverData.frmParent = Me
        Me.ucrReceiverData.Location = New System.Drawing.Point(261, 238)
        Me.ucrReceiverData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverData.Name = "ucrReceiverData"
        Me.ucrReceiverData.Selector = Nothing
        Me.ucrReceiverData.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverData.strNcFilePath = ""
        Me.ucrReceiverData.TabIndex = 8
        Me.ucrReceiverData.ucrSelector = Nothing
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(261, 192)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 7
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(261, 151)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 6
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(261, 108)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 5
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrSelectorVariable
        '
        Me.ucrSelectorVariable.bShowHiddenColumns = False
        Me.ucrSelectorVariable.bUseCurrentFilter = True
        Me.ucrSelectorVariable.Location = New System.Drawing.Point(9, 43)
        Me.ucrSelectorVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVariable.Name = "ucrSelectorVariable"
        Me.ucrSelectorVariable.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorVariable.TabIndex = 4
        '
        'UcrtimeScale
        '
        Me.UcrtimeScale.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrtimeScale.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrtimeScale.Location = New System.Drawing.Point(74, 293)
        Me.UcrtimeScale.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.UcrtimeScale.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrtimeScale.Name = "ucrtimeScale"
        Me.UcrtimeScale.Size = New System.Drawing.Size(50, 20)
        Me.UcrtimeScale.TabIndex = 21
        Me.UcrtimeScale.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'SPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 451)
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
        Me.Name = "SPI"
        Me.Text = "SPI"
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
