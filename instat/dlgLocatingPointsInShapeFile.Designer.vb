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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgLocatingPointsInShapeFile))
        Me.grpShapeaFile = New System.Windows.Forms.GroupBox()
        Me.lblGeometry = New System.Windows.Forms.Label()
        Me.grpStationFile = New System.Windows.Forms.GroupBox()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverGeometry = New instat.ucrReceiverSingle()
        Me.ucrSelectorShapeFile = New instat.ucrSelectorByDataFrameAddRemove()
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
        Me.grpShapeaFile.Controls.Add(Me.lblGeometry)
        resources.ApplyResources(Me.grpShapeaFile, "grpShapeaFile")
        Me.grpShapeaFile.Name = "grpShapeaFile"
        Me.grpShapeaFile.TabStop = False
        '
        'lblGeometry
        '
        resources.ApplyResources(Me.lblGeometry, "lblGeometry")
        Me.lblGeometry.Name = "lblGeometry"
        '
        'grpStationFile
        '
        Me.grpStationFile.Controls.Add(Me.lblLongitude)
        Me.grpStationFile.Controls.Add(Me.lblLatitude)
        resources.ApplyResources(Me.grpStationFile, "grpStationFile")
        Me.grpStationFile.Name = "grpStationFile"
        Me.grpStationFile.TabStop = False
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
        'ucrReceiverGeometry
        '
        Me.ucrReceiverGeometry.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverGeometry, "ucrReceiverGeometry")
        Me.ucrReceiverGeometry.Name = "ucrReceiverGeometry"
        Me.ucrReceiverGeometry.Selector = Nothing
        Me.ucrReceiverGeometry.strNcFilePath = ""
        Me.ucrReceiverGeometry.ucrSelector = Nothing
        '
        'ucrSelectorShapeFile
        '
        Me.ucrSelectorShapeFile.bDropUnusedFilterLevels = False
        Me.ucrSelectorShapeFile.bShowHiddenColumns = False
        Me.ucrSelectorShapeFile.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorShapeFile, "ucrSelectorShapeFile")
        Me.ucrSelectorShapeFile.Name = "ucrSelectorShapeFile"
        '
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverLongitude, "ucrReceiverLongitude")
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrReceiverLatitude
        '
        Me.ucrReceiverLatitude.frmParent = Me
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
        Me.Controls.Add(Me.ucrReceiverGeometry)
        Me.Controls.Add(Me.ucrSelectorShapeFile)
        Me.Controls.Add(Me.grpShapeaFile)
        Me.Controls.Add(Me.ucrReceiverLongitude)
        Me.Controls.Add(Me.ucrReceiverLatitude)
        Me.Controls.Add(Me.ucrSelectorStationFile)
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
    Friend WithEvents ucrReceiverLongitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents ucrSelectorStationFile As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpStationFile As GroupBox
    Friend WithEvents lblLongitude As Label
    Friend WithEvents lblLatitude As Label
    Friend WithEvents ucrSaveNewColumnName As ucrSave
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkOmitMissing As ucrCheck
End Class
