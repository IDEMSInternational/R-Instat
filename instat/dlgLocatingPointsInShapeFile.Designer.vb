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
        Me.grpShapeaFile = New System.Windows.Forms.GroupBox()
        Me.lblGeometry = New System.Windows.Forms.Label()
        Me.grpStationFile = New System.Windows.Forms.GroupBox()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverGeometry = New instat.ucrReceiverSingle()
        Me.ucrSelectorShapeFile = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverLongitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrSelectorStationFile = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrNewColumnName = New instat.ucrSave()
        Me.grpShapeaFile.SuspendLayout()
        Me.grpStationFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpShapeaFile
        '
        Me.grpShapeaFile.Controls.Add(Me.lblGeometry)
        Me.grpShapeaFile.Location = New System.Drawing.Point(6, 224)
        Me.grpShapeaFile.Name = "grpShapeaFile"
        Me.grpShapeaFile.Size = New System.Drawing.Size(397, 197)
        Me.grpShapeaFile.TabIndex = 18
        Me.grpShapeaFile.TabStop = False
        Me.grpShapeaFile.Text = "Shape File"
        '
        'lblGeometry
        '
        Me.lblGeometry.AutoSize = True
        Me.lblGeometry.Location = New System.Drawing.Point(255, 29)
        Me.lblGeometry.Name = "lblGeometry"
        Me.lblGeometry.Size = New System.Drawing.Size(55, 13)
        Me.lblGeometry.TabIndex = 6
        Me.lblGeometry.Text = "Geometry:"
        '
        'grpStationFile
        '
        Me.grpStationFile.Controls.Add(Me.lblLongitude)
        Me.grpStationFile.Controls.Add(Me.lblLatitude)
        Me.grpStationFile.Location = New System.Drawing.Point(6, 4)
        Me.grpStationFile.Name = "grpStationFile"
        Me.grpStationFile.Size = New System.Drawing.Size(397, 216)
        Me.grpStationFile.TabIndex = 15
        Me.grpStationFile.TabStop = False
        Me.grpStationFile.Text = "StationFile"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.Location = New System.Drawing.Point(255, 39)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(57, 13)
        Me.lblLongitude.TabIndex = 6
        Me.lblLongitude.Text = "Longitude:"
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.Location = New System.Drawing.Point(255, 104)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(48, 13)
        Me.lblLatitude.TabIndex = 7
        Me.lblLatitude.Text = "Latitude:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 463)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 20
        '
        'ucrReceiverGeometry
        '
        Me.ucrReceiverGeometry.frmParent = Me
        Me.ucrReceiverGeometry.Location = New System.Drawing.Point(261, 282)
        Me.ucrReceiverGeometry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGeometry.Name = "ucrReceiverGeometry"
        Me.ucrReceiverGeometry.Selector = Nothing
        Me.ucrReceiverGeometry.Size = New System.Drawing.Size(120, 36)
        Me.ucrReceiverGeometry.strNcFilePath = ""
        Me.ucrReceiverGeometry.TabIndex = 17
        Me.ucrReceiverGeometry.ucrSelector = Nothing
        '
        'ucrSelectorShapeFile
        '
        Me.ucrSelectorShapeFile.bDropUnusedFilterLevels = False
        Me.ucrSelectorShapeFile.bShowHiddenColumns = False
        Me.ucrSelectorShapeFile.bUseCurrentFilter = True
        Me.ucrSelectorShapeFile.Location = New System.Drawing.Point(19, 240)
        Me.ucrSelectorShapeFile.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorShapeFile.Name = "ucrSelectorShapeFile"
        Me.ucrSelectorShapeFile.Size = New System.Drawing.Size(210, 196)
        Me.ucrSelectorShapeFile.TabIndex = 16
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.frmParent = Me
        Me.ucrReceiverLongitude.Location = New System.Drawing.Point(259, 64)
        Me.ucrReceiverLongitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.Size = New System.Drawing.Size(120, 36)
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.TabIndex = 14
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.frmParent = Me
        Me.ucrReceiverLatitude.Location = New System.Drawing.Point(262, 125)
        Me.ucrReceiverLatitude.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.Size = New System.Drawing.Size(120, 36)
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.TabIndex = 13
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrSelectorStationFile
        '
        Me.ucrSelectorStationFile.bDropUnusedFilterLevels = False
        Me.ucrSelectorStationFile.bShowHiddenColumns = False
        Me.ucrSelectorStationFile.bUseCurrentFilter = True
        Me.ucrSelectorStationFile.Location = New System.Drawing.Point(17, 20)
        Me.ucrSelectorStationFile.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStationFile.Name = "ucrSelectorStationFile"
        Me.ucrSelectorStationFile.Size = New System.Drawing.Size(210, 196)
        Me.ucrSelectorStationFile.TabIndex = 12
        '
        'ucrNewColumnName
        '
        Me.ucrNewColumnName.Location = New System.Drawing.Point(19, 434)
        Me.ucrNewColumnName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        Me.ucrNewColumnName.Size = New System.Drawing.Size(383, 26)
        Me.ucrNewColumnName.TabIndex = 19
        '
        'dlgLocatingPointsInShapeFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 517)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverGeometry)
        Me.Controls.Add(Me.ucrSelectorShapeFile)
        Me.Controls.Add(Me.grpShapeaFile)
        Me.Controls.Add(Me.ucrReceiverLongitude)
        Me.Controls.Add(Me.ucrReceiverLatitude)
        Me.Controls.Add(Me.ucrSelectorStationFile)
        Me.Controls.Add(Me.grpStationFile)
        Me.Controls.Add(Me.ucrNewColumnName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
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

    End Sub
    Friend WithEvents ucrReceiverGeometry As ucrReceiverSingle
    Friend WithEvents ucrSelectorShapeFile As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpShapeaFile As GroupBox
    Friend WithEvents lblGeometry As Label
    Friend WithEvents ucrReceiverLongitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents ucrSelectorStationFile As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpStationFile As GroupBox
    Friend WithEvents lblLongitude As Label
    Friend WithEvents lblLatitude As Label
    Friend WithEvents ucrNewColumnName As ucrSave
    Friend WithEvents ucrBase As ucrButtons
End Class
