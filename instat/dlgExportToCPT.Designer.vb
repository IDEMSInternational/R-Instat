<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgExportToCPT
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
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.txtExportFile = New System.Windows.Forms.TextBox()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.chkLong = New System.Windows.Forms.CheckBox()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.lblStations = New System.Windows.Forms.Label()
        Me.lblDataColumn = New System.Windows.Forms.Label()
        Me.lblDataColumns = New System.Windows.Forms.Label()
        Me.ucrBaseExportToCPT = New instat.ucrButtons()
        Me.ucrLocationDataFrame = New instat.ucrDataFrame()
        Me.ucrReceiverMultipleDataColumns = New instat.ucrReceiverMultiple()
        Me.ucrReceiverDataColumn = New instat.ucrReceiverSingle()
        Me.ucrReceiverStations = New instat.ucrReceiverSingle()
        Me.ucrReceiverYears = New instat.ucrReceiverSingle()
        Me.ucrSSTDataframe = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(347, 246)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(62, 23)
        Me.cmdBrowse.TabIndex = 13
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'txtExportFile
        '
        Me.txtExportFile.Location = New System.Drawing.Point(84, 247)
        Me.txtExportFile.Name = "txtExportFile"
        Me.txtExportFile.Size = New System.Drawing.Size(257, 20)
        Me.txtExportFile.TabIndex = 12
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.Location = New System.Drawing.Point(15, 251)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(56, 13)
        Me.lblExport.TabIndex = 11
        Me.lblExport.Text = "Export file:"
        '
        'chkLong
        '
        Me.chkLong.AutoSize = True
        Me.chkLong.Location = New System.Drawing.Point(289, 16)
        Me.chkLong.Name = "chkLong"
        Me.chkLong.Size = New System.Drawing.Size(111, 17)
        Me.chkLong.TabIndex = 0
        Me.chkLong.Tag = "Long_Data_Format"
        Me.chkLong.Text = "Long Data Format"
        Me.chkLong.UseVisualStyleBackColor = True
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Location = New System.Drawing.Point(289, 40)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(37, 13)
        Me.lblYears.TabIndex = 2
        Me.lblYears.Tag = "Years:"
        Me.lblYears.Text = "Years:"
        '
        'lblStations
        '
        Me.lblStations.AutoSize = True
        Me.lblStations.Location = New System.Drawing.Point(289, 93)
        Me.lblStations.Name = "lblStations"
        Me.lblStations.Size = New System.Drawing.Size(48, 13)
        Me.lblStations.TabIndex = 6
        Me.lblStations.Tag = "Stations:"
        Me.lblStations.Text = "Stations:"
        '
        'lblDataColumn
        '
        Me.lblDataColumn.AutoSize = True
        Me.lblDataColumn.Location = New System.Drawing.Point(289, 146)
        Me.lblDataColumn.Name = "lblDataColumn"
        Me.lblDataColumn.Size = New System.Drawing.Size(71, 13)
        Me.lblDataColumn.TabIndex = 8
        Me.lblDataColumn.Tag = "Data_Column:"
        Me.lblDataColumn.Text = "Data Column:"
        '
        'lblDataColumns
        '
        Me.lblDataColumns.AutoSize = True
        Me.lblDataColumns.Location = New System.Drawing.Point(289, 93)
        Me.lblDataColumns.Name = "lblDataColumns"
        Me.lblDataColumns.Size = New System.Drawing.Size(76, 13)
        Me.lblDataColumns.TabIndex = 4
        Me.lblDataColumns.Tag = "Data_Columns:"
        Me.lblDataColumns.Text = "Data Columns:"
        '
        'ucrBaseExportToCPT
        '
        Me.ucrBaseExportToCPT.Location = New System.Drawing.Point(15, 276)
        Me.ucrBaseExportToCPT.Name = "ucrBaseExportToCPT"
        Me.ucrBaseExportToCPT.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseExportToCPT.TabIndex = 14
        '
        'ucrLocationDataFrame
        '
        Me.ucrLocationDataFrame.bUseCurrentFilter = True
        Me.ucrLocationDataFrame.Location = New System.Drawing.Point(15, 194)
        Me.ucrLocationDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrLocationDataFrame.Name = "ucrLocationDataFrame"
        Me.ucrLocationDataFrame.Size = New System.Drawing.Size(120, 50)
        Me.ucrLocationDataFrame.TabIndex = 10
        '
        'ucrReceiverMultipleDataColumns
        '
        Me.ucrReceiverMultipleDataColumns.Location = New System.Drawing.Point(289, 116)
        Me.ucrReceiverMultipleDataColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleDataColumns.Name = "ucrReceiverMultipleDataColumns"
        Me.ucrReceiverMultipleDataColumns.Selector = Nothing
        Me.ucrReceiverMultipleDataColumns.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultipleDataColumns.TabIndex = 5
        '
        'ucrReceiverDataColumn
        '
        Me.ucrReceiverDataColumn.Location = New System.Drawing.Point(289, 169)
        Me.ucrReceiverDataColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataColumn.Name = "ucrReceiverDataColumn"
        Me.ucrReceiverDataColumn.Selector = Nothing
        Me.ucrReceiverDataColumn.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDataColumn.TabIndex = 9
        '
        'ucrReceiverStations
        '
        Me.ucrReceiverStations.Location = New System.Drawing.Point(289, 116)
        Me.ucrReceiverStations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStations.Name = "ucrReceiverStations"
        Me.ucrReceiverStations.Selector = Nothing
        Me.ucrReceiverStations.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStations.TabIndex = 7
        '
        'ucrReceiverYears
        '
        Me.ucrReceiverYears.Location = New System.Drawing.Point(289, 63)
        Me.ucrReceiverYears.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYears.Name = "ucrReceiverYears"
        Me.ucrReceiverYears.Selector = Nothing
        Me.ucrReceiverYears.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYears.TabIndex = 3
        '
        'ucrSSTDataframe
        '
        Me.ucrSSTDataframe.bShowHiddenColumns = False
        Me.ucrSSTDataframe.bUseCurrentFilter = True
        Me.ucrSSTDataframe.Location = New System.Drawing.Point(15, 5)
        Me.ucrSSTDataframe.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSSTDataframe.Name = "ucrSSTDataframe"
        Me.ucrSSTDataframe.Size = New System.Drawing.Size(210, 180)
        Me.ucrSSTDataframe.TabIndex = 0
        '
        'dlgExportToCPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 329)
        Me.Controls.Add(Me.chkLong)
        Me.Controls.Add(Me.ucrBaseExportToCPT)
        Me.Controls.Add(Me.ucrLocationDataFrame)
        Me.Controls.Add(Me.lblDataColumns)
        Me.Controls.Add(Me.ucrReceiverMultipleDataColumns)
        Me.Controls.Add(Me.lblDataColumn)
        Me.Controls.Add(Me.lblStations)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.ucrReceiverDataColumn)
        Me.Controls.Add(Me.ucrReceiverStations)
        Me.Controls.Add(Me.ucrReceiverYears)
        Me.Controls.Add(Me.ucrSSTDataframe)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtExportFile)
        Me.Controls.Add(Me.lblExport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportToCPT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Export_To_CPT"
        Me.Text = "Export to CPT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents txtExportFile As TextBox
    Friend WithEvents lblExport As Label
    Friend WithEvents ucrSSTDataframe As ucrSelectorByDataFrameAddRemove
    Friend WithEvents chkLong As CheckBox
    Friend WithEvents ucrReceiverYears As ucrReceiverSingle
    Friend WithEvents ucrReceiverStations As ucrReceiverSingle
    Friend WithEvents ucrReceiverDataColumn As ucrReceiverSingle
    Friend WithEvents lblYears As Label
    Friend WithEvents lblStations As Label
    Friend WithEvents lblDataColumn As Label
    Friend WithEvents ucrReceiverMultipleDataColumns As ucrReceiverMultiple
    Friend WithEvents lblDataColumns As Label
    Friend WithEvents ucrLocationDataFrame As ucrDataFrame
    Friend WithEvents ucrBaseExportToCPT As ucrButtons

End Class