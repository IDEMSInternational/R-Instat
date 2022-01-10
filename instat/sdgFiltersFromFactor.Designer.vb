<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgFiltersFromFactor
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
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.ucrSelectorFiltersFromFactors = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.ucrFactorLevels = New instat.ucrFactor()
        Me.cmdSelectAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.Location = New System.Drawing.Point(201, 304)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(224, 30)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorFiltersFromFactors
        '
        Me.ucrSelectorFiltersFromFactors.AutoSize = True
        Me.ucrSelectorFiltersFromFactors.bDropUnusedFilterLevels = False
        Me.ucrSelectorFiltersFromFactors.bShowHiddenColumns = False
        Me.ucrSelectorFiltersFromFactors.bUseCurrentFilter = True
        Me.ucrSelectorFiltersFromFactors.Location = New System.Drawing.Point(9, 51)
        Me.ucrSelectorFiltersFromFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFiltersFromFactors.Name = "ucrSelectorFiltersFromFactors"
        Me.ucrSelectorFiltersFromFactors.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorFiltersFromFactors.TabIndex = 4
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.AutoSize = True
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(267, 32)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.TabIndex = 3
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'lblFactors
        '
        Me.lblFactors.Location = New System.Drawing.Point(267, 17)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(57, 13)
        Me.lblFactors.TabIndex = 2
        Me.lblFactors.Text = "Factor:"
        '
        'ucrFactorLevels
        '
        Me.ucrFactorLevels.AutoSize = True
        Me.ucrFactorLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrFactorLevels.clsReceiver = Nothing
        Me.ucrFactorLevels.Location = New System.Drawing.Point(267, 57)
        Me.ucrFactorLevels.Name = "ucrFactorLevels"
        Me.ucrFactorLevels.shtCurrSheet = Nothing
        Me.ucrFactorLevels.Size = New System.Drawing.Size(270, 208)
        Me.ucrFactorLevels.TabIndex = 1
        Me.ucrFactorLevels.ucrChkLevels = Nothing
        '
        'cmdSelectAll
        '
        Me.cmdSelectAll.Location = New System.Drawing.Point(462, 268)
        Me.cmdSelectAll.Name = "cmdSelectAll"
        Me.cmdSelectAll.Size = New System.Drawing.Size(75, 23)
        Me.cmdSelectAll.TabIndex = 0
        Me.cmdSelectAll.Text = "Select All"
        Me.cmdSelectAll.UseVisualStyleBackColor = True
        '
        'sdgFiltersFromFactor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(545, 337)
        Me.Controls.Add(Me.cmdSelectAll)
        Me.Controls.Add(Me.ucrFactorLevels)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrSelectorFiltersFromFactors)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgFiltersFromFactor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filters From Factor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents ucrSelectorFiltersFromFactors As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrFactorLevels As ucrFactor
    Friend WithEvents cmdSelectAll As Button
End Class
