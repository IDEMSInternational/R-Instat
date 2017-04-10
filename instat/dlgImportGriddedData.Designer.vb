<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgImportGriddedData
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
        Me.lblMinLat = New System.Windows.Forms.Label()
        Me.lblMaxLat = New System.Windows.Forms.Label()
        Me.lblMinLon = New System.Windows.Forms.Label()
        Me.lblMaxLon = New System.Windows.Forms.Label()
        Me.lblMainDataName = New System.Windows.Forms.Label()
        Me.lblDownloadFrom = New System.Windows.Forms.Label()
        Me.lblDataFile = New System.Windows.Forms.Label()
        Me.ucrInputDataFile = New instat.ucrInputComboBox()
        Me.ucrInputDownloadFrom = New instat.ucrInputComboBox()
        Me.ucrInputMainDataName = New instat.ucrInputTextBox()
        Me.ucrNudMaxLat = New instat.ucrNud()
        Me.ucrNudMaxLon = New instat.ucrNud()
        Me.ucrNudMinLon = New instat.ucrNud()
        Me.ucrNudMinLat = New instat.ucrNud()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputExportFile = New instat.ucrInputTextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.ucrInputLocDataName = New instat.ucrInputTextBox()
        Me.lblLocationData = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMinLat
        '
        Me.lblMinLat.AutoSize = True
        Me.lblMinLat.Location = New System.Drawing.Point(11, 150)
        Me.lblMinLat.Name = "lblMinLat"
        Me.lblMinLat.Size = New System.Drawing.Size(89, 13)
        Me.lblMinLat.TabIndex = 10
        Me.lblMinLat.Text = "Minimum Latitude"
        '
        'lblMaxLat
        '
        Me.lblMaxLat.AutoSize = True
        Me.lblMaxLat.Location = New System.Drawing.Point(178, 150)
        Me.lblMaxLat.Name = "lblMaxLat"
        Me.lblMaxLat.Size = New System.Drawing.Size(92, 13)
        Me.lblMaxLat.TabIndex = 12
        Me.lblMaxLat.Text = "Maximum Latitude"
        '
        'lblMinLon
        '
        Me.lblMinLon.AutoSize = True
        Me.lblMinLon.Location = New System.Drawing.Point(11, 118)
        Me.lblMinLon.Name = "lblMinLon"
        Me.lblMinLon.Size = New System.Drawing.Size(98, 13)
        Me.lblMinLon.TabIndex = 6
        Me.lblMinLon.Text = "Minimum Longitude"
        '
        'lblMaxLon
        '
        Me.lblMaxLon.AutoSize = True
        Me.lblMaxLon.Location = New System.Drawing.Point(178, 118)
        Me.lblMaxLon.Name = "lblMaxLon"
        Me.lblMaxLon.Size = New System.Drawing.Size(101, 13)
        Me.lblMaxLon.TabIndex = 8
        Me.lblMaxLon.Text = "Maximum Longitude"
        '
        'lblMainDataName
        '
        Me.lblMainDataName.AutoSize = True
        Me.lblMainDataName.Location = New System.Drawing.Point(10, 66)
        Me.lblMainDataName.Name = "lblMainDataName"
        Me.lblMainDataName.Size = New System.Drawing.Size(90, 13)
        Me.lblMainDataName.TabIndex = 4
        Me.lblMainDataName.Text = "Main Data Name:"
        '
        'lblDownloadFrom
        '
        Me.lblDownloadFrom.AutoSize = True
        Me.lblDownloadFrom.Location = New System.Drawing.Point(10, 10)
        Me.lblDownloadFrom.Name = "lblDownloadFrom"
        Me.lblDownloadFrom.Size = New System.Drawing.Size(84, 13)
        Me.lblDownloadFrom.TabIndex = 0
        Me.lblDownloadFrom.Text = "Download From:"
        '
        'lblDataFile
        '
        Me.lblDataFile.AutoSize = True
        Me.lblDataFile.Location = New System.Drawing.Point(10, 39)
        Me.lblDataFile.Name = "lblDataFile"
        Me.lblDataFile.Size = New System.Drawing.Size(52, 13)
        Me.lblDataFile.TabIndex = 2
        Me.lblDataFile.Text = "Data File:"
        '
        'ucrInputDataFile
        '
        Me.ucrInputDataFile.AddQuotesIfUnrecognised = True
        Me.ucrInputDataFile.IsReadOnly = False
        Me.ucrInputDataFile.Location = New System.Drawing.Point(100, 35)
        Me.ucrInputDataFile.Name = "ucrInputDataFile"
        Me.ucrInputDataFile.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDataFile.TabIndex = 3
        '
        'ucrInputDownloadFrom
        '
        Me.ucrInputDownloadFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputDownloadFrom.IsReadOnly = False
        Me.ucrInputDownloadFrom.Location = New System.Drawing.Point(100, 6)
        Me.ucrInputDownloadFrom.Name = "ucrInputDownloadFrom"
        Me.ucrInputDownloadFrom.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDownloadFrom.TabIndex = 1
        '
        'ucrInputMainDataName
        '
        Me.ucrInputMainDataName.AddQuotesIfUnrecognised = True
        Me.ucrInputMainDataName.IsMultiline = False
        Me.ucrInputMainDataName.IsReadOnly = False
        Me.ucrInputMainDataName.Location = New System.Drawing.Point(100, 62)
        Me.ucrInputMainDataName.Name = "ucrInputMainDataName"
        Me.ucrInputMainDataName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMainDataName.TabIndex = 5
        '
        'ucrNudMaxLat
        '
        Me.ucrNudMaxLat.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLat.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxLat.Location = New System.Drawing.Point(285, 146)
        Me.ucrNudMaxLat.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxLat.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLat.Name = "ucrNudMaxLat"
        Me.ucrNudMaxLat.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxLat.TabIndex = 13
        Me.ucrNudMaxLat.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaxLon
        '
        Me.ucrNudMaxLon.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLon.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxLon.Location = New System.Drawing.Point(285, 114)
        Me.ucrNudMaxLon.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxLon.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxLon.Name = "ucrNudMaxLon"
        Me.ucrNudMaxLon.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxLon.TabIndex = 9
        Me.ucrNudMaxLon.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMinLon
        '
        Me.ucrNudMinLon.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLon.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinLon.Location = New System.Drawing.Point(116, 114)
        Me.ucrNudMinLon.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinLon.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLon.Name = "ucrNudMinLon"
        Me.ucrNudMinLon.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinLon.TabIndex = 7
        Me.ucrNudMinLon.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMinLat
        '
        Me.ucrNudMinLat.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLat.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinLat.Location = New System.Drawing.Point(116, 146)
        Me.ucrNudMinLat.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinLat.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinLat.Name = "ucrNudMinLat"
        Me.ucrNudMinLat.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinLat.TabIndex = 11
        Me.ucrNudMinLat.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(11, 206)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(416, 52)
        Me.ucrBase.TabIndex = 14
        '
        'ucrInputExportFile
        '
        Me.ucrInputExportFile.AddQuotesIfUnrecognised = True
        Me.ucrInputExportFile.IsMultiline = False
        Me.ucrInputExportFile.IsReadOnly = False
        Me.ucrInputExportFile.Location = New System.Drawing.Point(132, 171)
        Me.ucrInputExportFile.Name = "ucrInputExportFile"
        Me.ucrInputExportFile.Size = New System.Drawing.Size(227, 21)
        Me.ucrInputExportFile.TabIndex = 16
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(365, 169)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(62, 23)
        Me.cmdBrowse.TabIndex = 17
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.Location = New System.Drawing.Point(10, 175)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(116, 13)
        Me.lblExport.TabIndex = 15
        Me.lblExport.Text = "Temporary file location:"
        '
        'ucrInputLocDataName
        '
        Me.ucrInputLocDataName.AddQuotesIfUnrecognised = True
        Me.ucrInputLocDataName.IsMultiline = False
        Me.ucrInputLocDataName.IsReadOnly = False
        Me.ucrInputLocDataName.Location = New System.Drawing.Point(116, 88)
        Me.ucrInputLocDataName.Name = "ucrInputLocDataName"
        Me.ucrInputLocDataName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLocDataName.TabIndex = 19
        '
        'lblLocationData
        '
        Me.lblLocationData.AutoSize = True
        Me.lblLocationData.Location = New System.Drawing.Point(8, 96)
        Me.lblLocationData.Name = "lblLocationData"
        Me.lblLocationData.Size = New System.Drawing.Size(108, 13)
        Me.lblLocationData.TabIndex = 18
        Me.lblLocationData.Text = "Location Data Name:"
        '
        'dlgImportGriddedData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 270)
        Me.Controls.Add(Me.ucrInputLocDataName)
        Me.Controls.Add(Me.lblLocationData)
        Me.Controls.Add(Me.ucrInputExportFile)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.lblExport)
        Me.Controls.Add(Me.lblDataFile)
        Me.Controls.Add(Me.ucrInputDataFile)
        Me.Controls.Add(Me.lblDownloadFrom)
        Me.Controls.Add(Me.ucrInputDownloadFrom)
        Me.Controls.Add(Me.ucrInputMainDataName)
        Me.Controls.Add(Me.lblMainDataName)
        Me.Controls.Add(Me.lblMaxLon)
        Me.Controls.Add(Me.lblMinLon)
        Me.Controls.Add(Me.lblMaxLat)
        Me.Controls.Add(Me.lblMinLat)
        Me.Controls.Add(Me.ucrNudMaxLat)
        Me.Controls.Add(Me.ucrNudMaxLon)
        Me.Controls.Add(Me.ucrNudMinLon)
        Me.Controls.Add(Me.ucrNudMinLat)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportGriddedData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Gridded Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrNudMinLat As ucrNud
    Friend WithEvents ucrNudMinLon As ucrNud
    Friend WithEvents ucrNudMaxLon As ucrNud
    Friend WithEvents ucrNudMaxLat As ucrNud
    Friend WithEvents lblMinLat As Label
    Friend WithEvents lblMaxLat As Label
    Friend WithEvents lblMinLon As Label
    Friend WithEvents lblMaxLon As Label
    Friend WithEvents lblMainDataName As Label
    Friend WithEvents ucrInputMainDataName As ucrInputTextBox
    Friend WithEvents ucrInputDownloadFrom As ucrInputComboBox
    Friend WithEvents lblDownloadFrom As Label
    Friend WithEvents ucrInputDataFile As ucrInputComboBox
    Friend WithEvents lblDataFile As Label
    Friend WithEvents ucrInputExportFile As ucrInputTextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents lblExport As Label
    Friend WithEvents ucrInputLocDataName As ucrInputTextBox
    Friend WithEvents lblLocationData As Label
End Class
