<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCountryColouredMap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCountryColouredMap))
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblColourBy = New System.Windows.Forms.Label()
        Me.ucrSaveMap = New instat.ucrSave()
        Me.ucrReceiverColourBy = New instat.ucrReceiverSingle()
        Me.ucrReceiverCountry = New instat.ucrReceiverSingle()
        Me.ucrSelectorCountryColouredMap = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.cmdPolygonOptions = New System.Windows.Forms.Button()
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.cmdMapOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCountry
        '
        resources.ApplyResources(Me.lblCountry, "lblCountry")
        Me.lblCountry.Name = "lblCountry"
        '
        'lblColourBy
        '
        resources.ApplyResources(Me.lblColourBy, "lblColourBy")
        Me.lblColourBy.Name = "lblColourBy"
        '
        'ucrSaveMap
        '
        resources.ApplyResources(Me.ucrSaveMap, "ucrSaveMap")
        Me.ucrSaveMap.Name = "ucrSaveMap"
        '
        'ucrReceiverColourBy
        '
        Me.ucrReceiverColourBy.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverColourBy, "ucrReceiverColourBy")
        Me.ucrReceiverColourBy.Name = "ucrReceiverColourBy"
        Me.ucrReceiverColourBy.Selector = Nothing
        Me.ucrReceiverColourBy.strNcFilePath = ""
        Me.ucrReceiverColourBy.ucrSelector = Nothing
        '
        'ucrReceiverCountry
        '
        Me.ucrReceiverCountry.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverCountry, "ucrReceiverCountry")
        Me.ucrReceiverCountry.Name = "ucrReceiverCountry"
        Me.ucrReceiverCountry.Selector = Nothing
        Me.ucrReceiverCountry.strNcFilePath = ""
        Me.ucrReceiverCountry.ucrSelector = Nothing
        '
        'ucrSelectorCountryColouredMap
        '
        Me.ucrSelectorCountryColouredMap.bShowHiddenColumns = False
        Me.ucrSelectorCountryColouredMap.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorCountryColouredMap, "ucrSelectorCountryColouredMap")
        Me.ucrSelectorCountryColouredMap.Name = "ucrSelectorCountryColouredMap"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'cmdPolygonOptions
        '
        resources.ApplyResources(Me.cmdPolygonOptions, "cmdPolygonOptions")
        Me.cmdPolygonOptions.Name = "cmdPolygonOptions"
        Me.cmdPolygonOptions.UseVisualStyleBackColor = True
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
        'dlgCountryColouredMap
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdMapOptions)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.cmdPolygonOptions)
        Me.Controls.Add(Me.ucrSaveMap)
        Me.Controls.Add(Me.lblColourBy)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.ucrReceiverColourBy)
        Me.Controls.Add(Me.ucrReceiverCountry)
        Me.Controls.Add(Me.ucrSelectorCountryColouredMap)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCountryColouredMap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorCountryColouredMap As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverCountry As ucrReceiverSingle
    Friend WithEvents ucrReceiverColourBy As ucrReceiverSingle
    Friend WithEvents lblColourBy As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents ucrSaveMap As ucrSave
    Friend WithEvents cmdPolygonOptions As Button
    Friend WithEvents cmdPlotOptions As Button
    Friend WithEvents cmdMapOptions As Button
End Class
