<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticStationMaps
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgClimaticStationMaps))
        Me.lblFill = New System.Windows.Forms.Label()
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.cmdMapOptions = New System.Windows.Forms.Button()
        Me.cmdSFOptions = New System.Windows.Forms.Button()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lbllatitude = New System.Windows.Forms.Label()
        Me.labelShape = New System.Windows.Forms.Label()
        Me.LabelColor = New System.Windows.Forms.Label()
        Me.ucrSelectorStation = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverColor = New instat.ucrReceiverSingle()
        Me.ucrReceiverShape = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatitude = New instat.ucrReceiverSingle()
        Me.ucrReceiverLongitude = New instat.ucrReceiverSingle()
        Me.ucrSaveMap = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverFill = New instat.ucrReceiverSingle()
        Me.ucrSelectorOutline = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblFill
        '
        resources.ApplyResources(Me.lblFill, "lblFill")
        Me.lblFill.Name = "lblFill"
        '
        'cmdPlotOptions
        '
        resources.ApplyResources(Me.cmdPlotOptions, "cmdPlotOptions")
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdMapOptions
        '
        resources.ApplyResources(Me.cmdMapOptions, "cmdMapOptions")
        Me.cmdMapOptions.Name = "cmdMapOptions"
        Me.cmdMapOptions.UseVisualStyleBackColor = True
        '
        'cmdSFOptions
        '
        resources.ApplyResources(Me.cmdSFOptions, "cmdSFOptions")
        Me.cmdSFOptions.Name = "cmdSFOptions"
        Me.cmdSFOptions.UseVisualStyleBackColor = True
        '
        'lblLongitude
        '
        resources.ApplyResources(Me.lblLongitude, "lblLongitude")
        Me.lblLongitude.Name = "lblLongitude"
        '
        'lbllatitude
        '
        resources.ApplyResources(Me.lbllatitude, "lbllatitude")
        Me.lbllatitude.Name = "lbllatitude"
        '
        'labelShape
        '
        resources.ApplyResources(Me.labelShape, "labelShape")
        Me.labelShape.Name = "labelShape"
        '
        'LabelColor
        '
        resources.ApplyResources(Me.LabelColor, "LabelColor")
        Me.LabelColor.Name = "LabelColor"
        '
        'ucrSelectorStation
        '
        Me.ucrSelectorStation.bDropUnusedFilterLevels = False
        Me.ucrSelectorStation.bShowHiddenColumns = False
        Me.ucrSelectorStation.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorStation, "ucrSelectorStation")
        Me.ucrSelectorStation.Name = "ucrSelectorStation"
        '
        'ucrReceiverColor
        '
        Me.ucrReceiverColor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverColor, "ucrReceiverColor")
        Me.ucrReceiverColor.Name = "ucrReceiverColor"
        Me.ucrReceiverColor.Selector = Nothing
        Me.ucrReceiverColor.strNcFilePath = ""
        Me.ucrReceiverColor.ucrSelector = Nothing
        '
        'ucrReceiverShape
        '
        Me.ucrReceiverShape.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverShape, "ucrReceiverShape")
        Me.ucrReceiverShape.Name = "ucrReceiverShape"
        Me.ucrReceiverShape.Selector = Nothing
        Me.ucrReceiverShape.strNcFilePath = ""
        Me.ucrReceiverShape.ucrSelector = Nothing
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
        'ucrReceiverLongitude
        '
        Me.ucrReceiverLongitude.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverLongitude, "ucrReceiverLongitude")
        Me.ucrReceiverLongitude.Name = "ucrReceiverLongitude"
        Me.ucrReceiverLongitude.Selector = Nothing
        Me.ucrReceiverLongitude.strNcFilePath = ""
        Me.ucrReceiverLongitude.ucrSelector = Nothing
        '
        'ucrSaveMap
        '
        resources.ApplyResources(Me.ucrSaveMap, "ucrSaveMap")
        Me.ucrSaveMap.Name = "ucrSaveMap"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrReceiverFill
        '
        Me.ucrReceiverFill.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFill, "ucrReceiverFill")
        Me.ucrReceiverFill.Name = "ucrReceiverFill"
        Me.ucrReceiverFill.Selector = Nothing
        Me.ucrReceiverFill.strNcFilePath = ""
        Me.ucrReceiverFill.ucrSelector = Nothing
        '
        'ucrSelectorOutline
        '
        Me.ucrSelectorOutline.bDropUnusedFilterLevels = False
        Me.ucrSelectorOutline.bShowHiddenColumns = False
        Me.ucrSelectorOutline.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorOutline, "ucrSelectorOutline")
        Me.ucrSelectorOutline.Name = "ucrSelectorOutline"
        '
        'dlgClimaticStationMaps
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSelectorStation)
        Me.Controls.Add(Me.LabelColor)
        Me.Controls.Add(Me.labelShape)
        Me.Controls.Add(Me.lbllatitude)
        Me.Controls.Add(Me.ucrReceiverColor)
        Me.Controls.Add(Me.lblLongitude)
        Me.Controls.Add(Me.ucrReceiverShape)
        Me.Controls.Add(Me.ucrReceiverLatitude)
        Me.Controls.Add(Me.ucrReceiverLongitude)
        Me.Controls.Add(Me.cmdSFOptions)
        Me.Controls.Add(Me.cmdMapOptions)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.ucrSaveMap)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblFill)
        Me.Controls.Add(Me.ucrReceiverFill)
        Me.Controls.Add(Me.ucrSelectorOutline)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticStationMaps"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorOutline As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblFill As Label
    Friend WithEvents ucrReceiverFill As ucrReceiverSingle
    Friend WithEvents cmdPlotOptions As Button
    Friend WithEvents ucrSaveMap As ucrSave
    Friend WithEvents cmdSFOptions As Button
    Friend WithEvents cmdMapOptions As Button
    Friend WithEvents lblLongitude As Label
    Friend WithEvents ucrReceiverShape As ucrReceiverSingle
    Friend WithEvents ucrReceiverLatitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverLongitude As ucrReceiverSingle
    Friend WithEvents ucrReceiverColor As ucrReceiverSingle
    Friend WithEvents LabelColor As Label
    Friend WithEvents labelShape As Label
    Friend WithEvents lbllatitude As Label
    Friend WithEvents ucrSelectorStation As ucrSelectorByDataFrameAddRemove
End Class
