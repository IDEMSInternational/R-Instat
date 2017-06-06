<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRecodeFactor
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
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrSaveNewColumn = New instat.ucrSave()
        Me.ucrFactorGrid = New instat.ucrFactor()
        Me.ucrSelectorForRecode = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 335)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 5
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(248, 60)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.TabIndex = 2
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(248, 45)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(85, 13)
        Me.lblFactor.TabIndex = 1
        Me.lblFactor.Text = "Factor Selected:"
        '
        'ucrSaveNewColumn
        '
        Me.ucrSaveNewColumn.Location = New System.Drawing.Point(10, 305)
        Me.ucrSaveNewColumn.Name = "ucrSaveNewColumn"
        Me.ucrSaveNewColumn.Size = New System.Drawing.Size(229, 24)
        Me.ucrSaveNewColumn.TabIndex = 4
        '
        'ucrFactorGrid
        '
        Me.ucrFactorGrid.AutoSize = True
        Me.ucrFactorGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrFactorGrid.clsReceiver = Nothing
        Me.ucrFactorGrid.Location = New System.Drawing.Point(248, 87)
        Me.ucrFactorGrid.Name = "ucrFactorGrid"
        Me.ucrFactorGrid.shtCurrSheet = Nothing
        Me.ucrFactorGrid.Size = New System.Drawing.Size(288, 221)
        Me.ucrFactorGrid.TabIndex = 3
        Me.ucrFactorGrid.ucrChkLevels = Nothing
        '
        'ucrSelectorForRecode
        '
        Me.ucrSelectorForRecode.bShowHiddenColumns = False
        Me.ucrSelectorForRecode.bUseCurrentFilter = True
        Me.ucrSelectorForRecode.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForRecode.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForRecode.Name = "ucrSelectorForRecode"
        Me.ucrSelectorForRecode.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForRecode.TabIndex = 0
        '
        'dlgRecodeFactor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 389)
        Me.Controls.Add(Me.ucrSaveNewColumn)
        Me.Controls.Add(Me.ucrFactorGrid)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrSelectorForRecode)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRecodeFactor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recode Factor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForRecode As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrFactorGrid As ucrFactor
    Friend WithEvents ucrSaveNewColumn As ucrSave
End Class
