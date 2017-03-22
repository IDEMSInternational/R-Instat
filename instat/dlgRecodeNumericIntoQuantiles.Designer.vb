<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRecodeNumericIntoQuantiles
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
        Me.ucrSelectorRecodeNumeric = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverSingle = New instat.ucrReceiverSingle()
        Me.lblNumberOfQuantiles = New System.Windows.Forms.Label()
        Me.ucrNudNumberOfQuantiles = New instat.ucrNud()
        Me.lblQuantileAlgorithm = New System.Windows.Forms.Label()
        Me.ucrNudQuantileAlgorithm = New instat.ucrNud()
        Me.ucrNewColumnName = New instat.ucrSave()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrSelectorRecodeNumeric
        '
        Me.ucrSelectorRecodeNumeric.bShowHiddenColumns = False
        Me.ucrSelectorRecodeNumeric.bUseCurrentFilter = True
        Me.ucrSelectorRecodeNumeric.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorRecodeNumeric.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorRecodeNumeric.Name = "ucrSelectorRecodeNumeric"
        Me.ucrSelectorRecodeNumeric.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorRecodeNumeric.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 248)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 4
        '
        'ucrReceiverSingle
        '
        Me.ucrReceiverSingle.frmParent = Me
        Me.ucrReceiverSingle.Location = New System.Drawing.Point(245, 60)
        Me.ucrReceiverSingle.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingle.Name = "ucrReceiverSingle"
        Me.ucrReceiverSingle.Selector = Nothing
        Me.ucrReceiverSingle.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSingle.TabIndex = 5
        '
        'lblNumberOfQuantiles
        '
        Me.lblNumberOfQuantiles.AutoSize = True
        Me.lblNumberOfQuantiles.Location = New System.Drawing.Point(242, 103)
        Me.lblNumberOfQuantiles.Name = "lblNumberOfQuantiles"
        Me.lblNumberOfQuantiles.Size = New System.Drawing.Size(108, 13)
        Me.lblNumberOfQuantiles.TabIndex = 6
        Me.lblNumberOfQuantiles.Tag = ""
        Me.lblNumberOfQuantiles.Text = "Number Of Quantiles:"
        '
        'ucrNudNumberOfQuantiles
        '
        Me.ucrNudNumberOfQuantiles.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfQuantiles.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberOfQuantiles.Location = New System.Drawing.Point(356, 103)
        Me.ucrNudNumberOfQuantiles.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfQuantiles.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfQuantiles.Name = "ucrNudNumberOfQuantiles"
        Me.ucrNudNumberOfQuantiles.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberOfQuantiles.TabIndex = 7
        Me.ucrNudNumberOfQuantiles.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblQuantileAlgorithm
        '
        Me.lblQuantileAlgorithm.AutoSize = True
        Me.lblQuantileAlgorithm.Location = New System.Drawing.Point(242, 133)
        Me.lblQuantileAlgorithm.Name = "lblQuantileAlgorithm"
        Me.lblQuantileAlgorithm.Size = New System.Drawing.Size(95, 13)
        Me.lblQuantileAlgorithm.TabIndex = 8
        Me.lblQuantileAlgorithm.Tag = ""
        Me.lblQuantileAlgorithm.Text = "Quantile Algorithm:"
        '
        'ucrNudQuantileAlgorithm
        '
        Me.ucrNudQuantileAlgorithm.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudQuantileAlgorithm.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudQuantileAlgorithm.Location = New System.Drawing.Point(356, 133)
        Me.ucrNudQuantileAlgorithm.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudQuantileAlgorithm.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudQuantileAlgorithm.Name = "ucrNudQuantileAlgorithm"
        Me.ucrNudQuantileAlgorithm.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudQuantileAlgorithm.TabIndex = 9
        Me.ucrNudQuantileAlgorithm.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNewColumnName
        '
        Me.ucrNewColumnName.Location = New System.Drawing.Point(10, 218)
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        Me.ucrNewColumnName.Size = New System.Drawing.Size(180, 24)
        Me.ucrNewColumnName.TabIndex = 10
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(242, 43)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(93, 13)
        Me.lblSelected.TabIndex = 11
        Me.lblSelected.Tag = "Selected_Variable:"
        Me.lblSelected.Text = "Selected Variable:"
        '
        'dlgRecodeNumericIntoQuantiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 313)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrNewColumnName)
        Me.Controls.Add(Me.ucrNudQuantileAlgorithm)
        Me.Controls.Add(Me.lblQuantileAlgorithm)
        Me.Controls.Add(Me.ucrNudNumberOfQuantiles)
        Me.Controls.Add(Me.lblNumberOfQuantiles)
        Me.Controls.Add(Me.ucrReceiverSingle)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorRecodeNumeric)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRecodeNumericIntoQuantiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recode Numeric Into Quantiles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorRecodeNumeric As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverSingle As ucrReceiverSingle
    Friend WithEvents lblNumberOfQuantiles As Label
    Friend WithEvents ucrNudQuantileAlgorithm As ucrNud
    Friend WithEvents lblQuantileAlgorithm As Label
    Friend WithEvents ucrNudNumberOfQuantiles As ucrNud
    Friend WithEvents ucrNewColumnName As ucrSave
    Friend WithEvents lblSelected As Label
End Class
