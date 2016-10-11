<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFactorDataFrame
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
        Me.ucrSelectorFactorDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverFactorDataFrame = New instat.ucrReceiverSingle()
        Me.chkReplaceFactorSheet = New System.Windows.Forms.CheckBox()
        Me.chkAddCurrentContrast = New System.Windows.Forms.CheckBox()
        Me.ucrButtons = New instat.ucrButtons()
        Me.lblSelectedFactor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrSelectorFactorDataFrame
        '
        Me.ucrSelectorFactorDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorFactorDataFrame.bUseCurrentFilter = False
        Me.ucrSelectorFactorDataFrame.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorFactorDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFactorDataFrame.Name = "ucrSelectorFactorDataFrame"
        Me.ucrSelectorFactorDataFrame.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorFactorDataFrame.TabIndex = 0
        '
        'ucrReceiverFactorDataFrame
        '
        Me.ucrReceiverFactorDataFrame.Location = New System.Drawing.Point(256, 111)
        Me.ucrReceiverFactorDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactorDataFrame.Name = "ucrReceiverFactorDataFrame"
        Me.ucrReceiverFactorDataFrame.Selector = Nothing
        Me.ucrReceiverFactorDataFrame.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFactorDataFrame.TabIndex = 1
        '
        'chkReplaceFactorSheet
        '
        Me.chkReplaceFactorSheet.AutoSize = True
        Me.chkReplaceFactorSheet.Location = New System.Drawing.Point(247, 47)
        Me.chkReplaceFactorSheet.Name = "chkReplaceFactorSheet"
        Me.chkReplaceFactorSheet.Size = New System.Drawing.Size(166, 17)
        Me.chkReplaceFactorSheet.TabIndex = 2
        Me.chkReplaceFactorSheet.Text = "Replace current Factor Sheet"
        Me.chkReplaceFactorSheet.UseVisualStyleBackColor = True
        '
        'chkAddCurrentContrast
        '
        Me.chkAddCurrentContrast.AutoSize = True
        Me.chkAddCurrentContrast.Location = New System.Drawing.Point(247, 16)
        Me.chkAddCurrentContrast.Name = "chkAddCurrentContrast"
        Me.chkAddCurrentContrast.Size = New System.Drawing.Size(129, 17)
        Me.chkAddCurrentContrast.TabIndex = 2
        Me.chkAddCurrentContrast.Text = "Add Current Contrasts"
        Me.chkAddCurrentContrast.UseVisualStyleBackColor = True
        '
        'ucrButtons
        '
        Me.ucrButtons.Location = New System.Drawing.Point(9, 208)
        Me.ucrButtons.Name = "ucrButtons"
        Me.ucrButtons.Size = New System.Drawing.Size(410, 52)
        Me.ucrButtons.TabIndex = 3
        '
        'lblSelectedFactor
        '
        Me.lblSelectedFactor.AutoSize = True
        Me.lblSelectedFactor.Location = New System.Drawing.Point(253, 95)
        Me.lblSelectedFactor.Name = "lblSelectedFactor"
        Me.lblSelectedFactor.Size = New System.Drawing.Size(120, 13)
        Me.lblSelectedFactor.TabIndex = 4
        Me.lblSelectedFactor.Text = "Selected Factor Column"
        '
        'dlgFactorDataFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 268)
        Me.Controls.Add(Me.lblSelectedFactor)
        Me.Controls.Add(Me.ucrButtons)
        Me.Controls.Add(Me.chkAddCurrentContrast)
        Me.Controls.Add(Me.chkReplaceFactorSheet)
        Me.Controls.Add(Me.ucrReceiverFactorDataFrame)
        Me.Controls.Add(Me.ucrSelectorFactorDataFrame)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFactorDataFrame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factor Data Frame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorFactorDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverFactorDataFrame As ucrReceiverSingle
    Friend WithEvents chkReplaceFactorSheet As CheckBox
    Friend WithEvents chkAddCurrentContrast As CheckBox
    Friend WithEvents ucrButtons As ucrButtons
    Friend WithEvents lblSelectedFactor As Label
End Class
