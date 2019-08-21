<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCategorizingMapsFromPoints
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
        Me.ucrSelectorStationAndShapeFile = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverLongitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lbllatitude = New System.Windows.Forms.Label()
        Me.grpStationFile = New System.Windows.Forms.GroupBox()
        Me.grpShapeFile = New System.Windows.Forms.GroupBox()
        Me.lblPolygon = New System.Windows.Forms.Label()
        Me.ucrReceiverPolygon = New instat.ucrReceiverSingle()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ucrReceiverName = New instat.ucrReceiverSingle()
        Me.ucrSaveColumn = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpStationFile.SuspendLayout()
        Me.grpShapeFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSelectorStationAndShapeFile
        '
        Me.ucrSelectorStationAndShapeFile.bDropUnusedFilterLevels = False
        Me.ucrSelectorStationAndShapeFile.bShowHiddenColumns = False
        Me.ucrSelectorStationAndShapeFile.bUseCurrentFilter = True
        Me.ucrSelectorStationAndShapeFile.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorStationAndShapeFile.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStationAndShapeFile.Name = "ucrSelectorStationAndShapeFile"
        Me.ucrSelectorStationAndShapeFile.Size = New System.Drawing.Size(220, 189)
        Me.ucrSelectorStationAndShapeFile.TabIndex = 4
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.frmParent = Me
        Me.ucrReceiverLongitude.Location = New System.Drawing.Point(13, 39)
        Me.ucrReceiverLongitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.TabIndex = 23
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.frmParent = Me
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(13, 80)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 25
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.Location = New System.Drawing.Point(13, 20)
        Me.lblLongitude.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(57, 13)
        Me.lblLongitude.TabIndex = 22
        Me.lblLongitude.Text = "Longitude:"
        '
        'lbllatitude
        '
        Me.lbllatitude.AutoSize = True
        Me.lbllatitude.Location = New System.Drawing.Point(13, 64)
        Me.lbllatitude.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbllatitude.Name = "lbllatitude"
        Me.lbllatitude.Size = New System.Drawing.Size(48, 13)
        Me.lbllatitude.TabIndex = 24
        Me.lbllatitude.Text = "Latitude:"
        '
        'grpStationFile
        '
        Me.grpStationFile.Controls.Add(Me.lbllatitude)
        Me.grpStationFile.Controls.Add(Me.lblLongitude)
        Me.grpStationFile.Controls.Add(Me.ucrReceiverLatitude)
        Me.grpStationFile.Controls.Add(Me.ucrReceiverLongitude)
        Me.grpStationFile.Location = New System.Drawing.Point(232, 24)
        Me.grpStationFile.Name = "grpStationFile"
        Me.grpStationFile.Size = New System.Drawing.Size(163, 108)
        Me.grpStationFile.TabIndex = 22
        Me.grpStationFile.TabStop = False
        Me.grpStationFile.Text = "Station File"
        '
        'grpShapeFile
        '
        Me.grpShapeFile.Controls.Add(Me.lblPolygon)
        Me.grpShapeFile.Controls.Add(Me.ucrReceiverPolygon)
        Me.grpShapeFile.Controls.Add(Me.lblName)
        Me.grpShapeFile.Controls.Add(Me.ucrReceiverName)
        Me.grpShapeFile.Location = New System.Drawing.Point(232, 138)
        Me.grpShapeFile.Name = "grpShapeFile"
        Me.grpShapeFile.Size = New System.Drawing.Size(163, 111)
        Me.grpShapeFile.TabIndex = 23
        Me.grpShapeFile.TabStop = False
        Me.grpShapeFile.Text = "Shape File"
        '
        'lblPolygon
        '
        Me.lblPolygon.AutoSize = True
        Me.lblPolygon.Location = New System.Drawing.Point(13, 19)
        Me.lblPolygon.Name = "lblPolygon"
        Me.lblPolygon.Size = New System.Drawing.Size(48, 13)
        Me.lblPolygon.TabIndex = 33
        Me.lblPolygon.Text = "Polygon:"
        '
        'ucrReceiverPolygon
        '
        Me.ucrReceiverPolygon.frmParent = Me
        Me.ucrReceiverPolygon.Location = New System.Drawing.Point(13, 38)
        Me.ucrReceiverPolygon.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPolygon.Name = "ucrReceiverPolygon"
        Me.ucrReceiverPolygon.Selector = Nothing
        Me.ucrReceiverPolygon.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPolygon.strNcFilePath = ""
        Me.ucrReceiverPolygon.TabIndex = 32
        Me.ucrReceiverPolygon.ucrSelector = Nothing
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 65)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 26
        Me.lblName.Text = "Name:"
        '
        'ucrReceiverName
        '
        Me.ucrReceiverName.frmParent = Me
        Me.ucrReceiverName.Location = New System.Drawing.Point(13, 83)
        Me.ucrReceiverName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverName.Name = "ucrReceiverName"
        Me.ucrReceiverName.Selector = Nothing
        Me.ucrReceiverName.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverName.strNcFilePath = ""
        Me.ucrReceiverName.TabIndex = 27
        Me.ucrReceiverName.ucrSelector = Nothing
        '
        'ucrSaveColumn
        '
        Me.ucrSaveColumn.Location = New System.Drawing.Point(9, 255)
        Me.ucrSaveColumn.Name = "ucrSaveColumn"
        Me.ucrSaveColumn.Size = New System.Drawing.Size(274, 24)
        Me.ucrSaveColumn.TabIndex = 24
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 287)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 25
        '
        'dlgCategorizingMapsFromPoints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 352)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSaveColumn)
        Me.Controls.Add(Me.grpShapeFile)
        Me.Controls.Add(Me.grpStationFile)
        Me.Controls.Add(Me.ucrSelectorStationAndShapeFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCategorizingMapsFromPoints"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categorizing Points From Maps"
        Me.grpStationFile.ResumeLayout(False)
        Me.grpStationFile.PerformLayout()
        Me.grpShapeFile.ResumeLayout(False)
        Me.grpShapeFile.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSelectorStationAndShapeFile As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverLongitude As ucrReceiverSingle
    Friend WithEvents grpStationFile As GroupBox
    Friend WithEvents lbllatitude As Label
    Friend WithEvents lblLongitude As Label
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents grpShapeFile As GroupBox
    Friend WithEvents lblPolygon As Label
    Friend WithEvents ucrReceiverPolygon As ucrReceiverSingle
    Friend WithEvents lblName As Label
    Friend WithEvents ucrReceiverName As ucrReceiverSingle
    Friend WithEvents ucrSaveColumn As ucrSave
    Friend WithEvents ucrBase As ucrButtons
End Class
