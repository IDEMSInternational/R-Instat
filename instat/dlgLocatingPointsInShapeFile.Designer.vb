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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgLocatingPointsInShapeFile))
        Me.grpShapeaFile = New System.Windows.Forms.GroupBox()
        Me.lblShapeFilePolygon = New System.Windows.Forms.Label()
        Me.lblGeometry = New System.Windows.Forms.Label()
        Me.grpStationFile = New System.Windows.Forms.GroupBox()
        Me.lblStationFilePolygon = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.ttStationFile = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverShapeFilePolygon = New instat.ucrReceiverSingle()
        Me.ucrSelectorShapeFile = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverGeometry = New instat.ucrReceiverSingle()
        Me.ucrReceiverStationFilePolygon = New instat.ucrReceiverSingle()
        Me.ucrReceiverLongitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrSelectorStationFile = New instat.ucrSelectorByDataFrameAddRemove()
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
        resources.ApplyResources(Me.grpShapeaFile, "grpShapeaFile")
        Me.grpShapeaFile.Name = "grpShapeaFile"
        Me.grpShapeaFile.TabStop = False
        '
        'lblShapeFilePolygon
        '
        resources.ApplyResources(Me.lblShapeFilePolygon, "lblShapeFilePolygon")
        Me.lblShapeFilePolygon.Name = "lblShapeFilePolygon"
        '
        'lblGeometry
        '
        resources.ApplyResources(Me.lblGeometry, "lblGeometry")
        Me.lblGeometry.Name = "lblGeometry"
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
        resources.ApplyResources(Me.grpStationFile, "grpStationFile")
        Me.grpStationFile.Name = "grpStationFile"
        Me.grpStationFile.TabStop = False
        '
        'lblStationFilePolygon
        '
        resources.ApplyResources(Me.lblStationFilePolygon, "lblStationFilePolygon")
        Me.lblStationFilePolygon.Name = "lblStationFilePolygon"
        '
        'lblLongitude
        '
        resources.ApplyResources(Me.lblLongitude, "lblLongitude")
        Me.lblLongitude.Name = "lblLongitude"
        '
        'lblLatitude
        '
        resources.ApplyResources(Me.lblLatitude, "lblLatitude")
        Me.lblLatitude.Name = "lblLatitude"
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.Checked = False
        resources.ApplyResources(Me.ucrChkOmitMissing, "ucrChkOmitMissing")
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverShapeFilePolygon
        '
        Me.ucrReceiverShapeFilePolygon.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverShapeFilePolygon, "ucrReceiverShapeFilePolygon")
        Me.ucrReceiverShapeFilePolygon.Name = "ucrReceiverShapeFilePolygon"
        Me.ucrReceiverShapeFilePolygon.Selector = Nothing
        Me.ucrReceiverShapeFilePolygon.strNcFilePath = ""
        Me.ucrReceiverShapeFilePolygon.ucrSelector = Nothing
        '
        'ucrSelectorShapeFile
        '
        Me.ucrSelectorShapeFile.bDropUnusedFilterLevels = False
        Me.ucrSelectorShapeFile.bShowHiddenColumns = False
        Me.ucrSelectorShapeFile.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorShapeFile, "ucrSelectorShapeFile")
        Me.ucrSelectorShapeFile.Name = "ucrSelectorShapeFile"
        '
        'ucrReceiverGeometry
        '
        Me.ucrReceiverGeometry.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverGeometry, "ucrReceiverGeometry")
        Me.ucrReceiverGeometry.Name = "ucrReceiverGeometry"
        Me.ucrReceiverGeometry.Selector = Nothing
        Me.ucrReceiverGeometry.strNcFilePath = ""
        Me.ucrReceiverGeometry.ucrSelector = Nothing
        '
        'ucrReceiverStationFilePolygon
        '
        Me.ucrReceiverStationFilePolygon.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverStationFilePolygon, "ucrReceiverStationFilePolygon")
        Me.ucrReceiverStationFilePolygon.Name = "ucrReceiverStationFilePolygon"
        Me.ucrReceiverStationFilePolygon.Selector = Nothing
        Me.ucrReceiverStationFilePolygon.strNcFilePath = ""
        Me.ucrReceiverStationFilePolygon.ucrSelector = Nothing
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverLongitude, "ucrReceiverLongitude")
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverLatitude, "ucrReceiverLatitude")
        Me.ucrReceiverLatitude.Name = "ucrReceiverLatitude"
        Me.ucrReceiverLatitude.Selector = Nothing
        Me.ucrReceiverLatitude.strNcFilePath = ""
        Me.ucrReceiverLatitude.ucrSelector = Nothing
        '
        'ucrSelectorStationFile
        '
        Me.ucrSelectorStationFile.bDropUnusedFilterLevels = False
        Me.ucrSelectorStationFile.bShowHiddenColumns = False
        Me.ucrSelectorStationFile.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorStationFile, "ucrSelectorStationFile")
        Me.ucrSelectorStationFile.Name = "ucrSelectorStationFile"
        '
        'ucrSaveNewColumnName
        '
        resources.ApplyResources(Me.ucrSaveNewColumnName, "ucrSaveNewColumnName")
        Me.ucrSaveNewColumnName.Name = "ucrSaveNewColumnName"
        '
        'dlgLocatingPointsInShapeFile
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpShapeaFile)
        Me.Controls.Add(Me.grpStationFile)
        Me.Controls.Add(Me.ucrSaveNewColumnName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgLocatingPointsInShapeFile"
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
