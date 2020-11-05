<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCircularDensityPlot
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverDensity = New instat.ucrReceiverSingle()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.lblDensity = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(5, 287)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorDataFrame
        '
        Me.ucrSelectorDataFrame.bDropUnusedFilterLevels = False
        Me.ucrSelectorDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorDataFrame.bUseCurrentFilter = True
        Me.ucrSelectorDataFrame.Location = New System.Drawing.Point(5, 9)
        Me.ucrSelectorDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataFrame.Name = "ucrSelectorDataFrame"
        Me.ucrSelectorDataFrame.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDataFrame.TabIndex = 1
        '
        'ucrReceiverDensity
        '
        Me.ucrReceiverDensity.frmParent = Me
        Me.ucrReceiverDensity.Location = New System.Drawing.Point(295, 28)
        Me.ucrReceiverDensity.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDensity.Name = "ucrReceiverDensity"
        Me.ucrReceiverDensity.Selector = Nothing
        Me.ucrReceiverDensity.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDensity.strNcFilePath = ""
        Me.ucrReceiverDensity.TabIndex = 2
        Me.ucrReceiverDensity.ucrSelector = Nothing
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(295, 92)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.TabIndex = 3
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'lblDensity
        '
        Me.lblDensity.AutoSize = True
        Me.lblDensity.Location = New System.Drawing.Point(292, 9)
        Me.lblDensity.Name = "lblDensity"
        Me.lblDensity.Size = New System.Drawing.Size(45, 13)
        Me.lblDensity.TabIndex = 4
        Me.lblDensity.Text = "Density:"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(292, 69)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(40, 13)
        Me.lblFactor.TabIndex = 5
        Me.lblFactor.Text = "Factor:"
        '
        'dlgCircularDensityPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 346)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblDensity)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrReceiverDensity)
        Me.Controls.Add(Me.ucrSelectorDataFrame)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCircularDensityPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Density Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverDensity As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents lblDensity As Label
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
End Class
