<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgFactorDataFrame
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
        Me.chkReplaceFactorSheet = New System.Windows.Forms.CheckBox()
        Me.chkAddCurrentContrast = New System.Windows.Forms.CheckBox()
        Me.lblSelectedFactor = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverFactorDataFrame = New instat.ucrReceiverSingle()
        Me.ucrSelectorFactorDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblFactorNames = New System.Windows.Forms.Label()
        Me.ucrInputFactorNames = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'chkReplaceFactorSheet
        '
        Me.chkReplaceFactorSheet.AutoSize = True
        Me.chkReplaceFactorSheet.Location = New System.Drawing.Point(255, 49)
        Me.chkReplaceFactorSheet.Name = "chkReplaceFactorSheet"
        Me.chkReplaceFactorSheet.Size = New System.Drawing.Size(166, 17)
        Me.chkReplaceFactorSheet.TabIndex = 2
        Me.chkReplaceFactorSheet.Text = "Replace current Factor Sheet"
        Me.chkReplaceFactorSheet.UseVisualStyleBackColor = True
        '
        'chkAddCurrentContrast
        '
        Me.chkAddCurrentContrast.AutoSize = True
        Me.chkAddCurrentContrast.Location = New System.Drawing.Point(255, 15)
        Me.chkAddCurrentContrast.Name = "chkAddCurrentContrast"
        Me.chkAddCurrentContrast.Size = New System.Drawing.Size(129, 17)
        Me.chkAddCurrentContrast.TabIndex = 2
        Me.chkAddCurrentContrast.Text = "Add Current Contrasts"
        Me.chkAddCurrentContrast.UseVisualStyleBackColor = True
        '
        'lblSelectedFactor
        '
        Me.lblSelectedFactor.AutoSize = True
        Me.lblSelectedFactor.Location = New System.Drawing.Point(251, 79)
        Me.lblSelectedFactor.Name = "lblSelectedFactor"
        Me.lblSelectedFactor.Size = New System.Drawing.Size(120, 13)
        Me.lblSelectedFactor.TabIndex = 4
        Me.lblSelectedFactor.Text = "Selected Factor Column"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 192)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 3
        '
        'ucrReceiverFactorDataFrame
        '
        Me.ucrReceiverFactorDataFrame.Location = New System.Drawing.Point(254, 95)
        Me.ucrReceiverFactorDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactorDataFrame.Name = "ucrReceiverFactorDataFrame"
        Me.ucrReceiverFactorDataFrame.Selector = Nothing
        Me.ucrReceiverFactorDataFrame.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFactorDataFrame.TabIndex = 1
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
        'lblFactorNames
        '
        Me.lblFactorNames.AutoSize = True
        Me.lblFactorNames.Location = New System.Drawing.Point(254, 124)
        Me.lblFactorNames.Name = "lblFactorNames"
        Me.lblFactorNames.Size = New System.Drawing.Size(73, 13)
        Me.lblFactorNames.TabIndex = 6
        Me.lblFactorNames.Text = "Factor Names"
        '
        'ucrInputFactorNames
        '
        Me.ucrInputFactorNames.IsReadOnly = False
        Me.ucrInputFactorNames.Location = New System.Drawing.Point(255, 140)
        Me.ucrInputFactorNames.Name = "ucrInputFactorNames"
        Me.ucrInputFactorNames.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputFactorNames.TabIndex = 7
        '
        'dlgFactorDataFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 245)
        Me.Controls.Add(Me.ucrInputFactorNames)
        Me.Controls.Add(Me.lblFactorNames)
        Me.Controls.Add(Me.lblSelectedFactor)
        Me.Controls.Add(Me.ucrBase)
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
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblSelectedFactor As Label
    Friend WithEvents lblFactorNames As Label
    Friend WithEvents ucrInputFactorNames As ucrInputTextBox
End Class
