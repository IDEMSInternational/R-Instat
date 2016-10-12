<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRugPlot
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
        Me.ucrSaveRugPlot = New instat.ucrSaveGraph()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.cmdRugPlotOptions = New System.Windows.Forms.Button()
        Me.ucrRugPlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverFloorVariable = New instat.ucrReceiverSingle()
        Me.lblFloorVariable = New System.Windows.Forms.Label()
        Me.lblLeftSideVariable = New System.Windows.Forms.Label()
        Me.ucrReceiverLeftSideVariable = New instat.ucrReceiverSingle()
        Me.lblCeilingVariable = New System.Windows.Forms.Label()
        Me.ucrReceiverCeilingVariable = New instat.ucrReceiverSingle()
        Me.lblRightSideVariable = New System.Windows.Forms.Label()
        Me.ucrReceiverRightSideVariable = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'ucrSaveRugPlot
        '
        Me.ucrSaveRugPlot.Location = New System.Drawing.Point(18, 273)
        Me.ucrSaveRugPlot.Name = "ucrSaveRugPlot"
        Me.ucrSaveRugPlot.Size = New System.Drawing.Size(265, 20)
        Me.ucrSaveRugPlot.TabIndex = 18
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(18, 237)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdOptions.TabIndex = 16
        Me.cmdOptions.Tag = "Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'cmdRugPlotOptions
        '
        Me.cmdRugPlotOptions.Location = New System.Drawing.Point(18, 202)
        Me.cmdRugPlotOptions.Name = "cmdRugPlotOptions"
        Me.cmdRugPlotOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdRugPlotOptions.TabIndex = 15
        Me.cmdRugPlotOptions.Tag = "Rug_Plot_Options"
        Me.cmdRugPlotOptions.Text = "Rug Plot Options"
        Me.cmdRugPlotOptions.UseVisualStyleBackColor = True
        '
        'ucrRugPlotSelector
        '
        Me.ucrRugPlotSelector.bShowHiddenColumns = False
        Me.ucrRugPlotSelector.bUseCurrentFilter = False
        Me.ucrRugPlotSelector.Location = New System.Drawing.Point(18, 8)
        Me.ucrRugPlotSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrRugPlotSelector.Name = "ucrRugPlotSelector"
        Me.ucrRugPlotSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrRugPlotSelector.TabIndex = 12
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(18, 304)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 17
        '
        'ucrReceiverFloorVariable
        '
        Me.ucrReceiverFloorVariable.Location = New System.Drawing.Point(285, 62)
        Me.ucrReceiverFloorVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFloorVariable.Name = "ucrReceiverFloorVariable"
        Me.ucrReceiverFloorVariable.Selector = Nothing
        Me.ucrReceiverFloorVariable.Size = New System.Drawing.Size(143, 22)
        Me.ucrReceiverFloorVariable.TabIndex = 19
        '
        'lblFloorVariable
        '
        Me.lblFloorVariable.AutoSize = True
        Me.lblFloorVariable.Location = New System.Drawing.Point(282, 37)
        Me.lblFloorVariable.Name = "lblFloorVariable"
        Me.lblFloorVariable.Size = New System.Drawing.Size(85, 13)
        Me.lblFloorVariable.TabIndex = 20
        Me.lblFloorVariable.Tag = "Floor_Variable"
        Me.lblFloorVariable.Text = "Floor Variable (x)"
        '
        'lblLeftSideVariable
        '
        Me.lblLeftSideVariable.AutoSize = True
        Me.lblLeftSideVariable.Location = New System.Drawing.Point(282, 95)
        Me.lblLeftSideVariable.Name = "lblLeftSideVariable"
        Me.lblLeftSideVariable.Size = New System.Drawing.Size(104, 13)
        Me.lblLeftSideVariable.TabIndex = 22
        Me.lblLeftSideVariable.Tag = "Left_Side_Variable"
        Me.lblLeftSideVariable.Text = "Left Side Variable (y)"
        '
        'ucrReceiverLeftSideVariable
        '
        Me.ucrReceiverLeftSideVariable.Location = New System.Drawing.Point(285, 120)
        Me.ucrReceiverLeftSideVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLeftSideVariable.Name = "ucrReceiverLeftSideVariable"
        Me.ucrReceiverLeftSideVariable.Selector = Nothing
        Me.ucrReceiverLeftSideVariable.Size = New System.Drawing.Size(143, 22)
        Me.ucrReceiverLeftSideVariable.TabIndex = 21
        '
        'lblCeilingVariable
        '
        Me.lblCeilingVariable.AutoSize = True
        Me.lblCeilingVariable.Location = New System.Drawing.Point(282, 163)
        Me.lblCeilingVariable.Name = "lblCeilingVariable"
        Me.lblCeilingVariable.Size = New System.Drawing.Size(79, 13)
        Me.lblCeilingVariable.TabIndex = 24
        Me.lblCeilingVariable.Tag = "Ceiling_Variable"
        Me.lblCeilingVariable.Text = "Ceiling Variable"
        '
        'ucrReceiverCeilingVariable
        '
        Me.ucrReceiverCeilingVariable.Location = New System.Drawing.Point(285, 188)
        Me.ucrReceiverCeilingVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCeilingVariable.Name = "ucrReceiverCeilingVariable"
        Me.ucrReceiverCeilingVariable.Selector = Nothing
        Me.ucrReceiverCeilingVariable.Size = New System.Drawing.Size(143, 22)
        Me.ucrReceiverCeilingVariable.TabIndex = 23
        '
        'lblRightSideVariable
        '
        Me.lblRightSideVariable.AutoSize = True
        Me.lblRightSideVariable.Location = New System.Drawing.Point(282, 221)
        Me.lblRightSideVariable.Name = "lblRightSideVariable"
        Me.lblRightSideVariable.Size = New System.Drawing.Size(97, 13)
        Me.lblRightSideVariable.TabIndex = 26
        Me.lblRightSideVariable.Tag = "Right_Side_Variable"
        Me.lblRightSideVariable.Text = "Right Side Variable"
        '
        'ucrReceiverRightSideVariable
        '
        Me.ucrReceiverRightSideVariable.Location = New System.Drawing.Point(285, 246)
        Me.ucrReceiverRightSideVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverRightSideVariable.Name = "ucrReceiverRightSideVariable"
        Me.ucrReceiverRightSideVariable.Selector = Nothing
        Me.ucrReceiverRightSideVariable.Size = New System.Drawing.Size(143, 22)
        Me.ucrReceiverRightSideVariable.TabIndex = 25
        '
        'dlgRugPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 370)
        Me.Controls.Add(Me.lblRightSideVariable)
        Me.Controls.Add(Me.ucrReceiverRightSideVariable)
        Me.Controls.Add(Me.lblCeilingVariable)
        Me.Controls.Add(Me.ucrReceiverCeilingVariable)
        Me.Controls.Add(Me.lblLeftSideVariable)
        Me.Controls.Add(Me.ucrReceiverLeftSideVariable)
        Me.Controls.Add(Me.lblFloorVariable)
        Me.Controls.Add(Me.ucrReceiverFloorVariable)
        Me.Controls.Add(Me.ucrSaveRugPlot)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.cmdRugPlotOptions)
        Me.Controls.Add(Me.ucrRugPlotSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRugPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rug Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrSaveRugPlot As ucrSaveGraph
    Friend WithEvents cmdOptions As Button
    Friend WithEvents cmdRugPlotOptions As Button
    Friend WithEvents ucrRugPlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverFloorVariable As ucrReceiverSingle
    Friend WithEvents lblFloorVariable As Label
    Friend WithEvents lblLeftSideVariable As Label
    Friend WithEvents ucrReceiverLeftSideVariable As ucrReceiverSingle
    Friend WithEvents lblCeilingVariable As Label
    Friend WithEvents ucrReceiverCeilingVariable As ucrReceiverSingle
    Friend WithEvents lblRightSideVariable As Label
    Friend WithEvents ucrReceiverRightSideVariable As ucrReceiverSingle
End Class
