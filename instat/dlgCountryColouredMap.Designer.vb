﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(235, 44)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(54, 13)
        Me.lblCountry.TabIndex = 4
        Me.lblCountry.Text = "Countries:"
        '
        'lblColourBy
        '
        Me.lblColourBy.AutoSize = True
        Me.lblColourBy.Location = New System.Drawing.Point(235, 95)
        Me.lblColourBy.Name = "lblColourBy"
        Me.lblColourBy.Size = New System.Drawing.Size(55, 13)
        Me.lblColourBy.TabIndex = 5
        Me.lblColourBy.Text = "Colour By:"
        '
        'ucrSaveMap
        '
        Me.ucrSaveMap.Location = New System.Drawing.Point(10, 256)
        Me.ucrSaveMap.Name = "ucrSaveMap"
        Me.ucrSaveMap.Size = New System.Drawing.Size(271, 24)
        Me.ucrSaveMap.TabIndex = 6
        '
        'ucrReceiverColourBy
        '
        Me.ucrReceiverColourBy.frmParent = Me
        Me.ucrReceiverColourBy.Location = New System.Drawing.Point(238, 108)
        Me.ucrReceiverColourBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColourBy.Name = "ucrReceiverColourBy"
        Me.ucrReceiverColourBy.Selector = Nothing
        Me.ucrReceiverColourBy.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverColourBy.strNcFilePath = ""
        Me.ucrReceiverColourBy.TabIndex = 3
        Me.ucrReceiverColourBy.ucrSelector = Nothing
        '
        'ucrReceiverCountry
        '
        Me.ucrReceiverCountry.frmParent = Me
        Me.ucrReceiverCountry.Location = New System.Drawing.Point(238, 60)
        Me.ucrReceiverCountry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCountry.Name = "ucrReceiverCountry"
        Me.ucrReceiverCountry.Selector = Nothing
        Me.ucrReceiverCountry.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverCountry.strNcFilePath = ""
        Me.ucrReceiverCountry.TabIndex = 2
        Me.ucrReceiverCountry.ucrSelector = Nothing
        '
        'ucrSelectorCountryColouredMap
        '
        Me.ucrSelectorCountryColouredMap.bShowHiddenColumns = False
        Me.ucrSelectorCountryColouredMap.bUseCurrentFilter = True
        Me.ucrSelectorCountryColouredMap.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorCountryColouredMap.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCountryColouredMap.Name = "ucrSelectorCountryColouredMap"
        Me.ucrSelectorCountryColouredMap.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorCountryColouredMap.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 296)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'cmdPolygonOptions
        '
        Me.cmdPolygonOptions.Enabled = False
        Me.cmdPolygonOptions.Location = New System.Drawing.Point(10, 198)
        Me.cmdPolygonOptions.Name = "cmdPolygonOptions"
        Me.cmdPolygonOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdPolygonOptions.TabIndex = 7
        Me.cmdPolygonOptions.Text = "Polygon Options"
        Me.cmdPolygonOptions.UseVisualStyleBackColor = True
        '
        'cmdPlotOptions
        '
        Me.cmdPlotOptions.Enabled = False
        Me.cmdPlotOptions.Location = New System.Drawing.Point(10, 227)
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdPlotOptions.TabIndex = 8
        Me.cmdPlotOptions.Text = "Plot Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdMapOptions
        '
        Me.cmdMapOptions.Enabled = False
        Me.cmdMapOptions.Location = New System.Drawing.Point(238, 146)
        Me.cmdMapOptions.Name = "cmdMapOptions"
        Me.cmdMapOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdMapOptions.TabIndex = 8
        Me.cmdMapOptions.Text = "Map Options"
        Me.cmdMapOptions.UseVisualStyleBackColor = True
        '
        'dlgCountryColouredMap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 354)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Country Coloured Map"
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
