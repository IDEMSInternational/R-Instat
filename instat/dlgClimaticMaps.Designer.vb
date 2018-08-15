<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticMaps
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
        Me.lblFill = New System.Windows.Forms.Label()
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.cmdMapOptions = New System.Windows.Forms.Button()
        Me.cmdSFOptions = New System.Windows.Forms.Button()
        Me.ucrSaveMap = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverFill = New instat.ucrReceiverSingle()
        Me.ucrSelectorClimaticMaps = New instat.ucrSelectorByDataFrameAddRemove()
        Me.UcrReceiverLon = New instat.ucrReceiverSingle()
        Me.UcrReceiverLat = New instat.ucrReceiverSingle()
        Me.UcrReceiverColor = New instat.ucrReceiverSingle()
        Me.LabelLon = New System.Windows.Forms.Label()
        Me.UcrReceiverSingle1 = New instat.ucrReceiverSingle()
        Me.Labellat = New System.Windows.Forms.Label()
        Me.labelShape = New System.Windows.Forms.Label()
        Me.LabelColor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFill
        '
        Me.lblFill.AutoSize = True
        Me.lblFill.Location = New System.Drawing.Point(384, 72)
        Me.lblFill.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Size = New System.Drawing.Size(32, 20)
        Me.lblFill.TabIndex = 1
        Me.lblFill.Text = "Fill:"
        '
        'cmdPlotOptions
        '
        Me.cmdPlotOptions.Location = New System.Drawing.Point(14, 339)
        Me.cmdPlotOptions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Size = New System.Drawing.Size(154, 35)
        Me.cmdPlotOptions.TabIndex = 3
        Me.cmdPlotOptions.Text = "Plot Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdMapOptions
        '
        Me.cmdMapOptions.Location = New System.Drawing.Point(14, 430)
        Me.cmdMapOptions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdMapOptions.Name = "cmdMapOptions"
        Me.cmdMapOptions.Size = New System.Drawing.Size(154, 35)
        Me.cmdMapOptions.TabIndex = 6
        Me.cmdMapOptions.Text = "Map Options"
        Me.cmdMapOptions.UseVisualStyleBackColor = True
        '
        'cmdSFOptions
        '
        Me.cmdSFOptions.Location = New System.Drawing.Point(14, 384)
        Me.cmdSFOptions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdSFOptions.Name = "cmdSFOptions"
        Me.cmdSFOptions.Size = New System.Drawing.Size(154, 35)
        Me.cmdSFOptions.TabIndex = 7
        Me.cmdSFOptions.Text = "SF Options"
        Me.cmdSFOptions.UseVisualStyleBackColor = True
        '
        'ucrSaveMap
        '
        Me.ucrSaveMap.Location = New System.Drawing.Point(10, 482)
        Me.ucrSaveMap.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrSaveMap.Name = "ucrSaveMap"
        Me.ucrSaveMap.Size = New System.Drawing.Size(366, 37)
        Me.ucrSaveMap.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 529)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(615, 80)
        Me.ucrBase.TabIndex = 5
        '
        'ucrReceiverFill
        '
        Me.ucrReceiverFill.frmParent = Me
        Me.ucrReceiverFill.Location = New System.Drawing.Point(388, 92)
        Me.ucrReceiverFill.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFill.Name = "ucrReceiverFill"
        Me.ucrReceiverFill.Selector = Nothing
        Me.ucrReceiverFill.Size = New System.Drawing.Size(137, 31)
        Me.ucrReceiverFill.strNcFilePath = ""
        Me.ucrReceiverFill.TabIndex = 2
        Me.ucrReceiverFill.ucrSelector = Nothing
        '
        'ucrSelectorClimaticMaps
        '
        Me.ucrSelectorClimaticMaps.bDropUnusedFilterLevels = False
        Me.ucrSelectorClimaticMaps.bShowHiddenColumns = False
        Me.ucrSelectorClimaticMaps.bUseCurrentFilter = True
        Me.ucrSelectorClimaticMaps.Location = New System.Drawing.Point(9, 45)
        Me.ucrSelectorClimaticMaps.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClimaticMaps.Name = "ucrSelectorClimaticMaps"
        Me.ucrSelectorClimaticMaps.Size = New System.Drawing.Size(317, 277)
        Me.ucrSelectorClimaticMaps.TabIndex = 0
        '
        'UcrReceiverLon
        '
        Me.UcrReceiverLon.frmParent = Me
        Me.UcrReceiverLon.Location = New System.Drawing.Point(618, 92)
        Me.UcrReceiverLon.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverLon.Name = "UcrReceiverLon"
        Me.UcrReceiverLon.Selector = Nothing
        Me.UcrReceiverLon.Size = New System.Drawing.Size(111, 31)
        Me.UcrReceiverLon.strNcFilePath = ""
        Me.UcrReceiverLon.TabIndex = 9
        Me.UcrReceiverLon.ucrSelector = Nothing
        '
        'UcrReceiverLat
        '
        Me.UcrReceiverLat.frmParent = Me
        Me.UcrReceiverLat.Location = New System.Drawing.Point(618, 156)
        Me.UcrReceiverLat.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverLat.Name = "UcrReceiverLat"
        Me.UcrReceiverLat.Selector = Nothing
        Me.UcrReceiverLat.Size = New System.Drawing.Size(111, 31)
        Me.UcrReceiverLat.strNcFilePath = ""
        Me.UcrReceiverLat.TabIndex = 10
        Me.UcrReceiverLat.ucrSelector = Nothing
        '
        'UcrReceiverColor
        '
        Me.UcrReceiverColor.frmParent = Me
        Me.UcrReceiverColor.Location = New System.Drawing.Point(618, 223)
        Me.UcrReceiverColor.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverColor.Name = "UcrReceiverColor"
        Me.UcrReceiverColor.Selector = Nothing
        Me.UcrReceiverColor.Size = New System.Drawing.Size(111, 31)
        Me.UcrReceiverColor.strNcFilePath = ""
        Me.UcrReceiverColor.TabIndex = 11
        Me.UcrReceiverColor.ucrSelector = Nothing
        '
        'LabelLon
        '
        Me.LabelLon.AutoSize = True
        Me.LabelLon.Location = New System.Drawing.Point(624, 72)
        Me.LabelLon.Name = "LabelLon"
        Me.LabelLon.Size = New System.Drawing.Size(49, 20)
        Me.LabelLon.TabIndex = 12
        Me.LabelLon.Text = "Long:"
        '
        'UcrReceiverSingle1
        '
        Me.UcrReceiverSingle1.frmParent = Me
        Me.UcrReceiverSingle1.Location = New System.Drawing.Point(618, 282)
        Me.UcrReceiverSingle1.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle1.Name = "UcrReceiverSingle1"
        Me.UcrReceiverSingle1.Selector = Nothing
        Me.UcrReceiverSingle1.Size = New System.Drawing.Size(111, 31)
        Me.UcrReceiverSingle1.strNcFilePath = ""
        Me.UcrReceiverSingle1.TabIndex = 15
        Me.UcrReceiverSingle1.ucrSelector = Nothing
        '
        'Labellat
        '
        Me.Labellat.AutoSize = True
        Me.Labellat.Location = New System.Drawing.Point(624, 136)
        Me.Labellat.Name = "Labellat"
        Me.Labellat.Size = New System.Drawing.Size(36, 20)
        Me.Labellat.TabIndex = 16
        Me.Labellat.Text = "Lat:"
        '
        'labelShape
        '
        Me.labelShape.AutoSize = True
        Me.labelShape.Location = New System.Drawing.Point(624, 203)
        Me.labelShape.Name = "labelShape"
        Me.labelShape.Size = New System.Drawing.Size(60, 20)
        Me.labelShape.TabIndex = 17
        Me.labelShape.Text = "Shape:"
        '
        'LabelColor
        '
        Me.LabelColor.AutoSize = True
        Me.LabelColor.Location = New System.Drawing.Point(623, 262)
        Me.LabelColor.Name = "LabelColor"
        Me.LabelColor.Size = New System.Drawing.Size(50, 20)
        Me.LabelColor.TabIndex = 18
        Me.LabelColor.Text = "Color:"
        '
        'dlgClimaticMaps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 626)
        Me.Controls.Add(Me.LabelColor)
        Me.Controls.Add(Me.labelShape)
        Me.Controls.Add(Me.Labellat)
        Me.Controls.Add(Me.UcrReceiverSingle1)
        Me.Controls.Add(Me.LabelLon)
        Me.Controls.Add(Me.UcrReceiverColor)
        Me.Controls.Add(Me.UcrReceiverLat)
        Me.Controls.Add(Me.UcrReceiverLon)
        Me.Controls.Add(Me.cmdSFOptions)
        Me.Controls.Add(Me.cmdMapOptions)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.ucrSaveMap)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblFill)
        Me.Controls.Add(Me.ucrReceiverFill)
        Me.Controls.Add(Me.ucrSelectorClimaticMaps)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticMaps"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Climatic Maps"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorClimaticMaps As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblFill As Label
    Friend WithEvents ucrReceiverFill As ucrReceiverSingle
    Friend WithEvents cmdPlotOptions As Button
    Friend WithEvents ucrSaveMap As ucrSave
    Friend WithEvents cmdSFOptions As Button
    Friend WithEvents cmdMapOptions As Button
    Friend WithEvents LabelLon As Label
    Friend WithEvents UcrReceiverColor As ucrReceiverSingle
    Friend WithEvents UcrReceiverLat As ucrReceiverSingle
    Friend WithEvents UcrReceiverLon As ucrReceiverSingle
    Friend WithEvents UcrReceiverSingle1 As ucrReceiverSingle
    Friend WithEvents LabelColor As Label
    Friend WithEvents labelShape As Label
    Friend WithEvents Labellat As Label
End Class
