<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgWordwrap
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
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.rdoUnWrapText = New System.Windows.Forms.RadioButton()
        Me.rdoWrapText = New System.Windows.Forms.RadioButton()
        Me.ucrPnlTextWrap = New instat.UcrPanel()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNudWidthWrap = New instat.ucrNud()
        Me.lblWidthWrap = New System.Windows.Forms.Label()
        Me.lblColumnToTransform = New System.Windows.Forms.Label()
        Me.ucrReceiverWrapText = New instat.ucrReceiverSingle()
        Me.ucrSelectorForWrapText = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.rdoUnWrapText)
        Me.grpOptions.Controls.Add(Me.rdoWrapText)
        Me.grpOptions.Controls.Add(Me.ucrPnlTextWrap)
        Me.grpOptions.Location = New System.Drawing.Point(387, 110)
        Me.grpOptions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpOptions.Size = New System.Drawing.Size(261, 88)
        Me.grpOptions.TabIndex = 13
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options:"
        '
        'rdoUnWrapText
        '
        Me.rdoUnWrapText.AutoSize = True
        Me.rdoUnWrapText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoUnWrapText.Location = New System.Drawing.Point(129, 37)
        Me.rdoUnWrapText.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoUnWrapText.Name = "rdoUnWrapText"
        Me.rdoUnWrapText.Size = New System.Drawing.Size(89, 24)
        Me.rdoUnWrapText.TabIndex = 2
        Me.rdoUnWrapText.TabStop = True
        Me.rdoUnWrapText.Text = "Unwrap"
        Me.rdoUnWrapText.UseVisualStyleBackColor = True
        '
        'rdoWrapText
        '
        Me.rdoWrapText.AutoSize = True
        Me.rdoWrapText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoWrapText.Location = New System.Drawing.Point(18, 35)
        Me.rdoWrapText.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoWrapText.Name = "rdoWrapText"
        Me.rdoWrapText.Size = New System.Drawing.Size(72, 24)
        Me.rdoWrapText.TabIndex = 1
        Me.rdoWrapText.TabStop = True
        Me.rdoWrapText.Text = "Wrap"
        Me.rdoWrapText.UseVisualStyleBackColor = True
        '
        'ucrPnlTextWrap
        '
        Me.ucrPnlTextWrap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlTextWrap.Location = New System.Drawing.Point(10, 28)
        Me.ucrPnlTextWrap.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlTextWrap.Name = "ucrPnlTextWrap"
        Me.ucrPnlTextWrap.Size = New System.Drawing.Size(234, 46)
        Me.ucrPnlTextWrap.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 303)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 16
        '
        'ucrNudWidthWrap
        '
        Me.ucrNudWidthWrap.AutoSize = True
        Me.ucrNudWidthWrap.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidthWrap.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWidthWrap.Location = New System.Drawing.Point(473, 207)
        Me.ucrNudWidthWrap.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudWidthWrap.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWidthWrap.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidthWrap.Name = "ucrNudWidthWrap"
        Me.ucrNudWidthWrap.Size = New System.Drawing.Size(75, 32)
        Me.ucrNudWidthWrap.TabIndex = 15
        Me.ucrNudWidthWrap.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblWidthWrap
        '
        Me.lblWidthWrap.AutoSize = True
        Me.lblWidthWrap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWidthWrap.Location = New System.Drawing.Point(387, 213)
        Me.lblWidthWrap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWidthWrap.Name = "lblWidthWrap"
        Me.lblWidthWrap.Size = New System.Drawing.Size(54, 20)
        Me.lblWidthWrap.TabIndex = 14
        Me.lblWidthWrap.Text = "Width:"
        '
        'lblColumnToTransform
        '
        Me.lblColumnToTransform.AutoSize = True
        Me.lblColumnToTransform.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumnToTransform.Location = New System.Drawing.Point(387, 30)
        Me.lblColumnToTransform.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColumnToTransform.Name = "lblColumnToTransform"
        Me.lblColumnToTransform.Size = New System.Drawing.Size(71, 20)
        Me.lblColumnToTransform.TabIndex = 11
        Me.lblColumnToTransform.Text = "Column :"
        '
        'ucrReceiverWrapText
        '
        Me.ucrReceiverWrapText.AutoSize = True
        Me.ucrReceiverWrapText.frmParent = Me
        Me.ucrReceiverWrapText.Location = New System.Drawing.Point(387, 58)
        Me.ucrReceiverWrapText.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWrapText.Name = "ucrReceiverWrapText"
        Me.ucrReceiverWrapText.Selector = Nothing
        Me.ucrReceiverWrapText.Size = New System.Drawing.Size(202, 40)
        Me.ucrReceiverWrapText.strNcFilePath = ""
        Me.ucrReceiverWrapText.TabIndex = 12
        Me.ucrReceiverWrapText.ucrSelector = Nothing
        '
        'ucrSelectorForWrapText
        '
        Me.ucrSelectorForWrapText.AutoSize = True
        Me.ucrSelectorForWrapText.bDropUnusedFilterLevels = False
        Me.ucrSelectorForWrapText.bShowHiddenColumns = False
        Me.ucrSelectorForWrapText.bUseCurrentFilter = True
        Me.ucrSelectorForWrapText.Location = New System.Drawing.Point(9, 12)
        Me.ucrSelectorForWrapText.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForWrapText.Name = "ucrSelectorForWrapText"
        Me.ucrSelectorForWrapText.Size = New System.Drawing.Size(363, 285)
        Me.ucrSelectorForWrapText.TabIndex = 10
        '
        'dlgWordwrap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 392)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrNudWidthWrap)
        Me.Controls.Add(Me.lblWidthWrap)
        Me.Controls.Add(Me.lblColumnToTransform)
        Me.Controls.Add(Me.ucrReceiverWrapText)
        Me.Controls.Add(Me.ucrSelectorForWrapText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgWordwrap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wrap"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents rdoUnWrapText As RadioButton
    Friend WithEvents rdoWrapText As RadioButton
    Friend WithEvents ucrPnlTextWrap As UcrPanel
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrNudWidthWrap As ucrNud
    Friend WithEvents lblWidthWrap As Label
    Friend WithEvents lblColumnToTransform As Label
    Friend WithEvents ucrReceiverWrapText As ucrReceiverSingle
    Friend WithEvents ucrSelectorForWrapText As ucrSelectorByDataFrameAddRemove
End Class
