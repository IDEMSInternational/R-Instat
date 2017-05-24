<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgRemoveUnusedLevels
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
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrRemoveUnusedFactorLevels = New instat.ucrFactor()
        Me.ucrReceiverFactorColumn = New instat.ucrReceiverSingle()
        Me.ucrSelectorFactorColumn = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(239, 32)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(85, 13)
        Me.lblFactor.TabIndex = 1
        Me.lblFactor.Tag = "Factor_Selected:"
        Me.lblFactor.Text = "Factor Selected:"
        '
        'ucrRemoveUnusedFactorLevels
        '
        Me.ucrRemoveUnusedFactorLevels.AutoSize = True
        Me.ucrRemoveUnusedFactorLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrRemoveUnusedFactorLevels.clsReceiver = Nothing
        Me.ucrRemoveUnusedFactorLevels.Location = New System.Drawing.Point(239, 76)
        Me.ucrRemoveUnusedFactorLevels.Name = "ucrRemoveUnusedFactorLevels"
        Me.ucrRemoveUnusedFactorLevels.shtCurrSheet = Nothing
        Me.ucrRemoveUnusedFactorLevels.Size = New System.Drawing.Size(255, 175)
        Me.ucrRemoveUnusedFactorLevels.TabIndex = 3
        '
        'ucrReceiverFactorColumn
        '
        Me.ucrReceiverFactorColumn.frmParent = Me
        Me.ucrReceiverFactorColumn.Location = New System.Drawing.Point(239, 47)
        Me.ucrReceiverFactorColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactorColumn.Name = "ucrReceiverFactorColumn"
        Me.ucrReceiverFactorColumn.Selector = Nothing
        Me.ucrReceiverFactorColumn.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverFactorColumn.TabIndex = 2
        '
        'ucrSelectorFactorColumn
        '
        Me.ucrSelectorFactorColumn.bShowHiddenColumns = False
        Me.ucrSelectorFactorColumn.bUseCurrentFilter = True
        Me.ucrSelectorFactorColumn.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorFactorColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFactorColumn.Name = "ucrSelectorFactorColumn"
        Me.ucrSelectorFactorColumn.Size = New System.Drawing.Size(242, 200)
        Me.ucrSelectorFactorColumn.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 257)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 4
        '
        'dlgUnusedLevels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 313)
        Me.Controls.Add(Me.ucrRemoveUnusedFactorLevels)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrReceiverFactorColumn)
        Me.Controls.Add(Me.ucrSelectorFactorColumn)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUnusedLevels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Remove_Unused_Factor_Levels"
        Me.Text = "Remove Unused Levels"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorFactorColumn As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactorColumn As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrRemoveUnusedFactorLevels As ucrFactor
End Class