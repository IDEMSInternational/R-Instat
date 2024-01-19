<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgExportForClimpact
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
        Me.lblTN = New System.Windows.Forms.Label()
        Me.lblTX = New System.Windows.Forms.Label()
        Me.lblRR = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMissingValues = New System.Windows.Forms.Label()
        Me.ucrInputCodeMissingValues = New instat.ucrInputTextBox()
        Me.ucrReceiverTN = New instat.ucrReceiverSingle()
        Me.ucrReceiverTX = New instat.ucrReceiverSingle()
        Me.ucrReceiverRR = New instat.ucrReceiverSingle()
        Me.ucrReceiverDay = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonth = New instat.ucrReceiverSingle()
        Me.ucrInputExportFile = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrSelectorImportToClimpact = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblTN
        '
        Me.lblTN.AutoSize = True
        Me.lblTN.Location = New System.Drawing.Point(278, 244)
        Me.lblTN.Name = "lblTN"
        Me.lblTN.Size = New System.Drawing.Size(93, 13)
        Me.lblTN.TabIndex = 11
        Me.lblTN.Text = "Min. Temperature:"
        '
        'lblTX
        '
        Me.lblTX.AutoSize = True
        Me.lblTX.Location = New System.Drawing.Point(278, 197)
        Me.lblTX.Name = "lblTX"
        Me.lblTX.Size = New System.Drawing.Size(96, 13)
        Me.lblTX.TabIndex = 9
        Me.lblTX.Text = "Max. Temperature:"
        '
        'lblRR
        '
        Me.lblRR.AutoSize = True
        Me.lblRR.Location = New System.Drawing.Point(278, 150)
        Me.lblRR.Name = "lblRR"
        Me.lblRR.Size = New System.Drawing.Size(45, 13)
        Me.lblRR.TabIndex = 7
        Me.lblRR.Text = "Rainfall:"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(278, 106)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(29, 13)
        Me.lblDay.TabIndex = 5
        Me.lblDay.Text = "Day:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(278, 59)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 3
        Me.lblMonth.Text = "Month:"
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExport.Location = New System.Drawing.Point(9, 297)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(59, 13)
        Me.lblExport.TabIndex = 16
        Me.lblExport.Text = "Export File:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrowse.Location = New System.Drawing.Point(293, 291)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(80, 23)
        Me.cmdBrowse.TabIndex = 18
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(278, 12)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 1
        Me.lblYear.Text = "Year:"
        '
        'lblMissingValues
        '
        Me.lblMissingValues.AutoSize = True
        Me.lblMissingValues.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMissingValues.Location = New System.Drawing.Point(4, 244)
        Me.lblMissingValues.Name = "lblMissingValues"
        Me.lblMissingValues.Size = New System.Drawing.Size(122, 13)
        Me.lblMissingValues.TabIndex = 33
        Me.lblMissingValues.Text = "Code Missing Values as:"
        '
        'ucrInputCodeMissingValues
        '
        Me.ucrInputCodeMissingValues.AddQuotesIfUnrecognised = True
        Me.ucrInputCodeMissingValues.AutoSize = True
        Me.ucrInputCodeMissingValues.IsMultiline = False
        Me.ucrInputCodeMissingValues.IsReadOnly = False
        Me.ucrInputCodeMissingValues.Location = New System.Drawing.Point(132, 242)
        Me.ucrInputCodeMissingValues.Name = "ucrInputCodeMissingValues"
        Me.ucrInputCodeMissingValues.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputCodeMissingValues.TabIndex = 32
        '
        'ucrReceiverTN
        '
        Me.ucrReceiverTN.AutoSize = True
        Me.ucrReceiverTN.frmParent = Me
        Me.ucrReceiverTN.Location = New System.Drawing.Point(278, 257)
        Me.ucrReceiverTN.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTN.Name = "ucrReceiverTN"
        Me.ucrReceiverTN.Selector = Nothing
        Me.ucrReceiverTN.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTN.strNcFilePath = ""
        Me.ucrReceiverTN.TabIndex = 12
        Me.ucrReceiverTN.ucrSelector = Nothing
        '
        'ucrReceiverTX
        '
        Me.ucrReceiverTX.AutoSize = True
        Me.ucrReceiverTX.frmParent = Me
        Me.ucrReceiverTX.Location = New System.Drawing.Point(278, 215)
        Me.ucrReceiverTX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTX.Name = "ucrReceiverTX"
        Me.ucrReceiverTX.Selector = Nothing
        Me.ucrReceiverTX.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTX.strNcFilePath = ""
        Me.ucrReceiverTX.TabIndex = 10
        Me.ucrReceiverTX.ucrSelector = Nothing
        '
        'ucrReceiverRR
        '
        Me.ucrReceiverRR.AutoSize = True
        Me.ucrReceiverRR.frmParent = Me
        Me.ucrReceiverRR.Location = New System.Drawing.Point(278, 168)
        Me.ucrReceiverRR.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRR.Name = "ucrReceiverRR"
        Me.ucrReceiverRR.Selector = Nothing
        Me.ucrReceiverRR.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverRR.strNcFilePath = ""
        Me.ucrReceiverRR.TabIndex = 8
        Me.ucrReceiverRR.ucrSelector = Nothing
        '
        'ucrReceiverDay
        '
        Me.ucrReceiverDay.AutoSize = True
        Me.ucrReceiverDay.frmParent = Me
        Me.ucrReceiverDay.Location = New System.Drawing.Point(278, 119)
        Me.ucrReceiverDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDay.Name = "ucrReceiverDay"
        Me.ucrReceiverDay.Selector = Nothing
        Me.ucrReceiverDay.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDay.strNcFilePath = ""
        Me.ucrReceiverDay.TabIndex = 6
        Me.ucrReceiverDay.ucrSelector = Nothing
        '
        'ucrReceiverMonth
        '
        Me.ucrReceiverMonth.AutoSize = True
        Me.ucrReceiverMonth.frmParent = Me
        Me.ucrReceiverMonth.Location = New System.Drawing.Point(278, 77)
        Me.ucrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonth.Name = "ucrReceiverMonth"
        Me.ucrReceiverMonth.Selector = Nothing
        Me.ucrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMonth.strNcFilePath = ""
        Me.ucrReceiverMonth.TabIndex = 4
        Me.ucrReceiverMonth.ucrSelector = Nothing
        '
        'ucrInputExportFile
        '
        Me.ucrInputExportFile.AddQuotesIfUnrecognised = True
        Me.ucrInputExportFile.AutoSize = True
        Me.ucrInputExportFile.IsMultiline = False
        Me.ucrInputExportFile.IsReadOnly = False
        Me.ucrInputExportFile.Location = New System.Drawing.Point(108, 293)
        Me.ucrInputExportFile.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputExportFile.Name = "ucrInputExportFile"
        Me.ucrInputExportFile.Size = New System.Drawing.Size(182, 21)
        Me.ucrInputExportFile.TabIndex = 17
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(7, 318)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 19
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(278, 30)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 2
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrSelectorImportToClimpact
        '
        Me.ucrSelectorImportToClimpact.AutoSize = True
        Me.ucrSelectorImportToClimpact.bDropUnusedFilterLevels = False
        Me.ucrSelectorImportToClimpact.bShowHiddenColumns = False
        Me.ucrSelectorImportToClimpact.bUseCurrentFilter = True
        Me.ucrSelectorImportToClimpact.Location = New System.Drawing.Point(9, 3)
        Me.ucrSelectorImportToClimpact.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorImportToClimpact.Name = "ucrSelectorImportToClimpact"
        Me.ucrSelectorImportToClimpact.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorImportToClimpact.TabIndex = 0
        '
        'dlgExportForClimpact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(422, 370)
        Me.Controls.Add(Me.lblMissingValues)
        Me.Controls.Add(Me.ucrInputCodeMissingValues)
        Me.Controls.Add(Me.lblTN)
        Me.Controls.Add(Me.ucrReceiverTN)
        Me.Controls.Add(Me.lblTX)
        Me.Controls.Add(Me.ucrReceiverTX)
        Me.Controls.Add(Me.lblRR)
        Me.Controls.Add(Me.ucrReceiverRR)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.ucrReceiverDay)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.ucrReceiverMonth)
        Me.Controls.Add(Me.lblExport)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.ucrInputExportFile)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrSelectorImportToClimpact)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgExportForClimpact"
        Me.Text = "Export For Climpact"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTN As Label
    Friend WithEvents ucrReceiverTN As ucrReceiverSingle
    Friend WithEvents lblTX As Label
    Friend WithEvents ucrReceiverTX As ucrReceiverSingle
    Friend WithEvents lblRR As Label
    Friend WithEvents ucrReceiverRR As ucrReceiverSingle
    Friend WithEvents lblDay As Label
    Friend WithEvents ucrReceiverDay As ucrReceiverSingle
    Friend WithEvents lblMonth As Label
    Friend WithEvents ucrReceiverMonth As ucrReceiverSingle
    Friend WithEvents lblExport As Label
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents ucrInputExportFile As ucrInputTextBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblYear As Label
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrSelectorImportToClimpact As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblMissingValues As Label
    Friend WithEvents ucrInputCodeMissingValues As ucrInputTextBox
End Class
