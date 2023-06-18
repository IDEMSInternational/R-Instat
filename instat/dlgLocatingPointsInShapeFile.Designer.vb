<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgLocatingPointsInShapeFile
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
        Me.components = New System.ComponentModel.Container()
        Me.grpShapeaFile = New System.Windows.Forms.GroupBox()
        Me.lblShapeFilePolygon = New System.Windows.Forms.Label()
        Me.ucrReceiverShapeFilePolygon = New instat.ucrReceiverSingle()
        Me.ucrSelectorShapeFile = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverGeometry = New instat.ucrReceiverSingle()
        Me.lblGeometry = New System.Windows.Forms.Label()
        Me.grpStationFile = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverStationFilePolygon = New instat.ucrReceiverSingle()
        Me.lblStationFilePolygon = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.ucrReceiverLongitude = New instat.ucrReceiverSingle()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrSelectorStationFile = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ttStationFile = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveNewColumnName = New instat.ucrSave()
        Me.grpShapeaFile.SuspendLayout()
        Me.grpStationFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpShapeaFile
        '
        Me.grpShapeaFile.Controls.Add(Me.lblShapeFilePolygon)
        Me.grpShapeaFile.Controls.Add(Me.ucrReceiverShapeFilePolygon)
        Me.grpShapeaFile.Controls.Add(Me.ucrSelectorShapeFile)
        Me.grpShapeaFile.Controls.Add(Me.ucrReceiverGeometry)
        Me.grpShapeaFile.Controls.Add(Me.lblGeometry)
        Me.grpShapeaFile.Location = New System.Drawing.Point(7, 206)
        Me.grpShapeaFile.Name = "grpShapeaFile"
        Me.grpShapeaFile.Size = New System.Drawing.Size(397, 213)
        Me.grpShapeaFile.TabIndex = 1
        Me.grpShapeaFile.TabStop = False
        Me.grpShapeaFile.Text = "Shape File"
        '
        'lblShapeFilePolygon
        '
        Me.lblShapeFilePolygon.AutoSize = True
        Me.lblShapeFilePolygon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblShapeFilePolygon.Location = New System.Drawing.Point(245, 94)
        Me.lblShapeFilePolygon.Name = "lblShapeFilePolygon"
        Me.lblShapeFilePolygon.Size = New System.Drawing.Size(99, 13)
        Me.lblShapeFilePolygon.TabIndex = 3
        Me.lblShapeFilePolygon.Text = "Location (Optional):"
        '
        'ucrReceiverShapeFilePolygon
        '
        Me.ucrReceiverShapeFilePolygon.AutoSize = True
        Me.ucrReceiverShapeFilePolygon.frmParent = Me
        Me.ucrReceiverShapeFilePolygon.Location = New System.Drawing.Point(248, 116)
        Me.ucrReceiverShapeFilePolygon.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverShapeFilePolygon.Name = "ucrReceiverShapeFilePolygon"
        Me.ucrReceiverShapeFilePolygon.Selector = Nothing
        Me.ucrReceiverShapeFilePolygon.Size = New System.Drawing.Size(136, 20)
        Me.ucrReceiverShapeFilePolygon.strNcFilePath = ""
        Me.ucrReceiverShapeFilePolygon.TabIndex = 4
        Me.ucrReceiverShapeFilePolygon.ucrSelector = Nothing
        '
        'ucrSelectorShapeFile
        '
        Me.ucrSelectorShapeFile.AutoSize = True
        Me.ucrSelectorShapeFile.bDropUnusedFilterLevels = False
        Me.ucrSelectorShapeFile.bShowHiddenColumns = False
        Me.ucrSelectorShapeFile.bUseCurrentFilter = True
        Me.ucrSelectorShapeFile.Location = New System.Drawing.Point(6, 16)
        Me.ucrSelectorShapeFile.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorShapeFile.Name = "ucrSelectorShapeFile"
        Me.ucrSelectorShapeFile.Size = New System.Drawing.Size(213, 189)
        Me.ucrSelectorShapeFile.TabIndex = 0
        '
        'ucrReceiverGeometry
        '
        Me.ucrReceiverGeometry.AutoSize = True
        Me.ucrReceiverGeometry.frmParent = Me
        Me.ucrReceiverGeometry.Location = New System.Drawing.Point(248, 64)
        Me.ucrReceiverGeometry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGeometry.Name = "ucrReceiverGeometry"
        Me.ucrReceiverGeometry.Selector = Nothing
        Me.ucrReceiverGeometry.Size = New System.Drawing.Size(136, 21)
        Me.ucrReceiverGeometry.strNcFilePath = ""
        Me.ucrReceiverGeometry.TabIndex = 2
        Me.ucrReceiverGeometry.ucrSelector = Nothing
        '
        'lblGeometry
        '
        Me.lblGeometry.AutoSize = True
        Me.lblGeometry.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGeometry.Location = New System.Drawing.Point(245, 42)
        Me.lblGeometry.Name = "lblGeometry"
        Me.lblGeometry.Size = New System.Drawing.Size(55, 13)
        Me.lblGeometry.TabIndex = 1
        Me.lblGeometry.Text = "Geometry:"
        '
        'grpStationFile
        '
        Me.grpStationFile.Controls.Add(Me.ucrReceiverStationFilePolygon)
        Me.grpStationFile.Controls.Add(Me.lblStationFilePolygon)
        Me.grpStationFile.Controls.Add(Me.lblLongitude)
        Me.grpStationFile.Controls.Add(Me.ucrReceiverLongitude)
        Me.grpStationFile.Controls.Add(Me.lblLatitude)
        Me.grpStationFile.Controls.Add(Me.ucrReceiverLatitude)
        Me.grpStationFile.Controls.Add(Me.ucrSelectorStationFile)
        Me.grpStationFile.Location = New System.Drawing.Point(7, 4)
        Me.grpStationFile.Name = "grpStationFile"
        Me.grpStationFile.Size = New System.Drawing.Size(397, 201)
        Me.grpStationFile.TabIndex = 0
        Me.grpStationFile.TabStop = False
        Me.grpStationFile.Text = "StationFile"
        '
        'ucrReceiverStationFilePolygon
        '
        Me.ucrReceiverStationFilePolygon.AutoSize = True
        Me.ucrReceiverStationFilePolygon.frmParent = Me
        Me.ucrReceiverStationFilePolygon.Location = New System.Drawing.Point(249, 159)
        Me.ucrReceiverStationFilePolygon.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationFilePolygon.Name = "ucrReceiverStationFilePolygon"
        Me.ucrReceiverStationFilePolygon.Selector = Nothing
        Me.ucrReceiverStationFilePolygon.Size = New System.Drawing.Size(135, 20)
        Me.ucrReceiverStationFilePolygon.strNcFilePath = ""
        Me.ucrReceiverStationFilePolygon.TabIndex = 6
        Me.ucrReceiverStationFilePolygon.ucrSelector = Nothing
        '
        'lblStationFilePolygon
        '
        Me.lblStationFilePolygon.AutoSize = True
        Me.lblStationFilePolygon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStationFilePolygon.Location = New System.Drawing.Point(246, 139)
        Me.lblStationFilePolygon.Name = "lblStationFilePolygon"
        Me.lblStationFilePolygon.Size = New System.Drawing.Size(99, 13)
        Me.lblStationFilePolygon.TabIndex = 5
        Me.lblStationFilePolygon.Text = "Location (Optional):"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLongitude.Location = New System.Drawing.Point(245, 43)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(57, 13)
        Me.lblLongitude.TabIndex = 1
        Me.lblLongitude.Text = "Longitude:"
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.AutoSize = True
        Me.ucrReceiverLongitude.frmParent = Me
        Me.ucrReceiverLongitude.Location = New System.Drawing.Point(248, 63)
        Me.ucrReceiverLongitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.Size = New System.Drawing.Size(136, 21)
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.TabIndex = 2
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLatitude.Location = New System.Drawing.Point(245, 91)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(48, 13)
        Me.lblLatitude.TabIndex = 3
        Me.lblLatitude.Text = "Latitude:"
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.AutoSize = True
        Me.ucrReceiverLatitude.frmParent = Me
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(248, 111)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(136, 21)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 4
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrSelectorStationFile
        '
        Me.ucrSelectorStationFile.AutoSize = True
        Me.ucrSelectorStationFile.bDropUnusedFilterLevels = False
        Me.ucrSelectorStationFile.bShowHiddenColumns = False
        Me.ucrSelectorStationFile.bUseCurrentFilter = True
        Me.ucrSelectorStationFile.Location = New System.Drawing.Point(6, 16)
        Me.ucrSelectorStationFile.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStationFile.Name = "ucrSelectorStationFile"
        Me.ucrSelectorStationFile.Size = New System.Drawing.Size(213, 185)
        Me.ucrSelectorStationFile.TabIndex = 0
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.AutoSize = True
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(7, 430)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(322, 23)
        Me.ucrChkOmitMissing.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(7, 488)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 4
        '
        'ucrSaveNewColumnName
        '
        Me.ucrSaveNewColumnName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewColumnName.Location = New System.Drawing.Point(7, 460)
        Me.ucrSaveNewColumnName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveNewColumnName.Name = "ucrSaveNewColumnName"
        Me.ucrSaveNewColumnName.Size = New System.Drawing.Size(397, 21)
        Me.ucrSaveNewColumnName.TabIndex = 3
        '
        'dlgLocatingPointsInShapeFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(420, 540)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpShapeaFile)
        Me.Controls.Add(Me.grpStationFile)
        Me.Controls.Add(Me.ucrSaveNewColumnName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgLocatingPointsInShapeFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locating Points in Shape File"
        Me.grpShapeaFile.ResumeLayout(False)
        Me.grpShapeaFile.PerformLayout()
        Me.grpStationFile.ResumeLayout(False)
        Me.grpStationFile.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverGeometry As ucrReceiverSingle
    Friend WithEvents ucrSelectorShapeFile As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpShapeaFile As GroupBox
    Friend WithEvents lblGeometry As Label
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents ucrSelectorStationFile As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpStationFile As GroupBox
    Friend WithEvents lblLongitude As Label
    Friend WithEvents lblLatitude As Label
    Friend WithEvents ucrSaveNewColumnName As ucrSave
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents lblShapeFilePolygon As Label
    Friend WithEvents lblStationFilePolygon As Label
    Friend WithEvents ucrReceiverLongitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverShapeFilePolygon As ucrReceiverSingle
    Friend WithEvents ucrReceiverStationFilePolygon As ucrReceiverSingle
    Friend WithEvents ttStationFile As ToolTip
End Class
