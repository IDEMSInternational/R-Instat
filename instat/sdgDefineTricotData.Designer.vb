<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgDefineTricotData
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
        Me.ucrSdgButtons = New instat.ucrButtonsSubdialogue()
        Me.lblID = New System.Windows.Forms.Label()
        Me.ucrReceiverTricotData = New instat.ucrReceiverSingle()
        Me.ucrSelectorTricotData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputGoodTrait = New instat.ucrInputComboBox()
        Me.ucrInputBadTrait = New instat.ucrInputComboBox()
        Me.ucrInputNAs = New instat.ucrInputComboBox()
        Me.lblGoodtrait = New System.Windows.Forms.Label()
        Me.lblBadTrait = New System.Windows.Forms.Label()
        Me.lblNAs = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrSdgButtons
        '
        Me.ucrSdgButtons.AutoSize = True
        Me.ucrSdgButtons.Location = New System.Drawing.Point(85, 402)
        Me.ucrSdgButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrSdgButtons.Name = "ucrSdgButtons"
        Me.ucrSdgButtons.Size = New System.Drawing.Size(335, 42)
        Me.ucrSdgButtons.TabIndex = 27
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(284, 43)
        Me.lblID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 26
        Me.lblID.Text = "ID:"
        '
        'ucrReceiverTricotData
        '
        Me.ucrReceiverTricotData.AutoSize = True
        Me.ucrReceiverTricotData.frmParent = Me
        Me.ucrReceiverTricotData.Location = New System.Drawing.Point(287, 67)
        Me.ucrReceiverTricotData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTricotData.Name = "ucrReceiverTricotData"
        Me.ucrReceiverTricotData.Selector = Nothing
        Me.ucrReceiverTricotData.Size = New System.Drawing.Size(167, 24)
        Me.ucrReceiverTricotData.strNcFilePath = ""
        Me.ucrReceiverTricotData.TabIndex = 25
        Me.ucrReceiverTricotData.ucrSelector = Nothing
        '
        'ucrSelectorTricotData
        '
        Me.ucrSelectorTricotData.AutoSize = True
        Me.ucrSelectorTricotData.bDropUnusedFilterLevels = False
        Me.ucrSelectorTricotData.bShowHiddenColumns = False
        Me.ucrSelectorTricotData.bUseCurrentFilter = True
        Me.ucrSelectorTricotData.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorTricotData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTricotData.Name = "ucrSelectorTricotData"
        Me.ucrSelectorTricotData.Size = New System.Drawing.Size(318, 274)
        Me.ucrSelectorTricotData.TabIndex = 24
        '
        'ucrInputGoodTrait
        '
        Me.ucrInputGoodTrait.AddQuotesIfUnrecognised = True
        Me.ucrInputGoodTrait.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputGoodTrait.GetSetSelectedIndex = -1
        Me.ucrInputGoodTrait.IsReadOnly = False
        Me.ucrInputGoodTrait.Location = New System.Drawing.Point(287, 121)
        Me.ucrInputGoodTrait.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputGoodTrait.Name = "ucrInputGoodTrait"
        Me.ucrInputGoodTrait.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputGoodTrait.TabIndex = 28
        '
        'ucrInputBadTrait
        '
        Me.ucrInputBadTrait.AddQuotesIfUnrecognised = True
        Me.ucrInputBadTrait.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBadTrait.GetSetSelectedIndex = -1
        Me.ucrInputBadTrait.IsReadOnly = False
        Me.ucrInputBadTrait.Location = New System.Drawing.Point(287, 179)
        Me.ucrInputBadTrait.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputBadTrait.Name = "ucrInputBadTrait"
        Me.ucrInputBadTrait.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputBadTrait.TabIndex = 29
        '
        'ucrInputNAs
        '
        Me.ucrInputNAs.AddQuotesIfUnrecognised = True
        Me.ucrInputNAs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputNAs.GetSetSelectedIndex = -1
        Me.ucrInputNAs.IsReadOnly = False
        Me.ucrInputNAs.Location = New System.Drawing.Point(287, 237)
        Me.ucrInputNAs.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputNAs.Name = "ucrInputNAs"
        Me.ucrInputNAs.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputNAs.TabIndex = 30
        '
        'lblGoodtrait
        '
        Me.lblGoodtrait.AutoSize = True
        Me.lblGoodtrait.Location = New System.Drawing.Point(284, 100)
        Me.lblGoodtrait.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGoodtrait.Name = "lblGoodtrait"
        Me.lblGoodtrait.Size = New System.Drawing.Size(89, 13)
        Me.lblGoodtrait.TabIndex = 31
        Me.lblGoodtrait.Text = "Good Trait Suffix:"
        '
        'lblBadTrait
        '
        Me.lblBadTrait.AutoSize = True
        Me.lblBadTrait.Location = New System.Drawing.Point(284, 158)
        Me.lblBadTrait.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBadTrait.Name = "lblBadTrait"
        Me.lblBadTrait.Size = New System.Drawing.Size(82, 13)
        Me.lblBadTrait.TabIndex = 32
        Me.lblBadTrait.Text = "Bad Trait Suffix:"
        '
        'lblNAs
        '
        Me.lblNAs.AutoSize = True
        Me.lblNAs.Location = New System.Drawing.Point(284, 216)
        Me.lblNAs.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNAs.Name = "lblNAs"
        Me.lblNAs.Size = New System.Drawing.Size(81, 13)
        Me.lblNAs.TabIndex = 33
        Me.lblNAs.Text = "NA denoted by:"
        '
        'sdgDefineTricotData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 450)
        Me.Controls.Add(Me.lblNAs)
        Me.Controls.Add(Me.lblBadTrait)
        Me.Controls.Add(Me.lblGoodtrait)
        Me.Controls.Add(Me.ucrInputNAs)
        Me.Controls.Add(Me.ucrInputBadTrait)
        Me.Controls.Add(Me.ucrInputGoodTrait)
        Me.Controls.Add(Me.ucrSdgButtons)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.ucrReceiverTricotData)
        Me.Controls.Add(Me.ucrSelectorTricotData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgDefineTricotData"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Define Tricot Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSdgButtons As ucrButtonsSubdialogue
    Friend WithEvents lblID As Label
    Friend WithEvents ucrReceiverTricotData As ucrReceiverSingle
    Friend WithEvents ucrSelectorTricotData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputNAs As ucrInputComboBox
    Friend WithEvents ucrInputBadTrait As ucrInputComboBox
    Friend WithEvents ucrInputGoodTrait As ucrInputComboBox
    Friend WithEvents lblNAs As Label
    Friend WithEvents lblBadTrait As Label
    Friend WithEvents lblGoodtrait As Label
End Class
