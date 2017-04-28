<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgExportGraphAsImage
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
        Me.lblSelectedGraph = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.grpImageFormats = New System.Windows.Forms.GroupBox()
        Me.rdoTex = New System.Windows.Forms.RadioButton()
        Me.rdoWmf = New System.Windows.Forms.RadioButton()
        Me.rdoSvg = New System.Windows.Forms.RadioButton()
        Me.rdoBmp = New System.Windows.Forms.RadioButton()
        Me.rdoJpeg = New System.Windows.Forms.RadioButton()
        Me.rdoPng = New System.Windows.Forms.RadioButton()
        Me.ucrInputFile = New instat.ucrInputTextBox()
        Me.ucrSelectedGraphReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorGraphAsImage = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlImageFormats = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'lblSelectedGraph
        '
        Me.lblSelectedGraph.AutoSize = True
        Me.lblSelectedGraph.Location = New System.Drawing.Point(265, 34)
        Me.lblSelectedGraph.Name = "lblSelectedGraph"
        Me.lblSelectedGraph.Size = New System.Drawing.Size(84, 13)
        Me.lblSelectedGraph.TabIndex = 1
        Me.lblSelectedGraph.Text = "Selected Graph:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(299, 212)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(75, 23)
        Me.cmdBrowse.TabIndex = 11
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'grpImageFormats
        '
        Me.grpImageFormats.Location = New System.Drawing.Point(264, 71)
        Me.grpImageFormats.Name = "grpImageFormats"
        Me.grpImageFormats.Size = New System.Drawing.Size(128, 93)
        Me.grpImageFormats.TabIndex = 3
        Me.grpImageFormats.TabStop = False
        Me.grpImageFormats.Text = "Image Formats"
        '
        'rdoTex
        '
        Me.rdoTex.AutoSize = True
        Me.rdoTex.Location = New System.Drawing.Point(340, 124)
        Me.rdoTex.Name = "rdoTex"
        Me.rdoTex.Size = New System.Drawing.Size(39, 17)
        Me.rdoTex.TabIndex = 9
        Me.rdoTex.TabStop = True
        Me.rdoTex.Text = "tex"
        Me.rdoTex.UseVisualStyleBackColor = True
        '
        'rdoWmf
        '
        Me.rdoWmf.AutoSize = True
        Me.rdoWmf.Location = New System.Drawing.Point(340, 104)
        Me.rdoWmf.Name = "rdoWmf"
        Me.rdoWmf.Size = New System.Drawing.Size(44, 17)
        Me.rdoWmf.TabIndex = 8
        Me.rdoWmf.TabStop = True
        Me.rdoWmf.Text = "wmf"
        Me.rdoWmf.UseVisualStyleBackColor = True
        '
        'rdoSvg
        '
        Me.rdoSvg.AutoSize = True
        Me.rdoSvg.Location = New System.Drawing.Point(340, 84)
        Me.rdoSvg.Name = "rdoSvg"
        Me.rdoSvg.Size = New System.Drawing.Size(42, 17)
        Me.rdoSvg.TabIndex = 7
        Me.rdoSvg.TabStop = True
        Me.rdoSvg.Text = "svg"
        Me.rdoSvg.UseVisualStyleBackColor = True
        '
        'rdoBmp
        '
        Me.rdoBmp.AutoSize = True
        Me.rdoBmp.Location = New System.Drawing.Point(279, 124)
        Me.rdoBmp.Name = "rdoBmp"
        Me.rdoBmp.Size = New System.Drawing.Size(45, 17)
        Me.rdoBmp.TabIndex = 6
        Me.rdoBmp.TabStop = True
        Me.rdoBmp.Text = "bmp"
        Me.rdoBmp.UseVisualStyleBackColor = True
        '
        'rdoJpeg
        '
        Me.rdoJpeg.AutoSize = True
        Me.rdoJpeg.Location = New System.Drawing.Point(279, 104)
        Me.rdoJpeg.Name = "rdoJpeg"
        Me.rdoJpeg.Size = New System.Drawing.Size(45, 17)
        Me.rdoJpeg.TabIndex = 5
        Me.rdoJpeg.TabStop = True
        Me.rdoJpeg.Text = "jpeg"
        Me.rdoJpeg.UseVisualStyleBackColor = True
        '
        'rdoPng
        '
        Me.rdoPng.AutoSize = True
        Me.rdoPng.Location = New System.Drawing.Point(279, 84)
        Me.rdoPng.Name = "rdoPng"
        Me.rdoPng.Size = New System.Drawing.Size(43, 17)
        Me.rdoPng.TabIndex = 4
        Me.rdoPng.TabStop = True
        Me.rdoPng.Text = "png"
        Me.rdoPng.UseVisualStyleBackColor = True
        '
        'ucrInputFile
        '
        Me.ucrInputFile.AddQuotesIfUnrecognised = True
        Me.ucrInputFile.IsMultiline = False
        Me.ucrInputFile.IsReadOnly = False
        Me.ucrInputFile.Location = New System.Drawing.Point(10, 214)
        Me.ucrInputFile.Name = "ucrInputFile"
        Me.ucrInputFile.Size = New System.Drawing.Size(287, 21)
        Me.ucrInputFile.TabIndex = 10
        '
        'ucrSelectedGraphReceiver
        '
        Me.ucrSelectedGraphReceiver.frmParent = Me
        Me.ucrSelectedGraphReceiver.Location = New System.Drawing.Point(265, 49)
        Me.ucrSelectedGraphReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectedGraphReceiver.Name = "ucrSelectedGraphReceiver"
        Me.ucrSelectedGraphReceiver.Selector = Nothing
        Me.ucrSelectedGraphReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrSelectedGraphReceiver.TabIndex = 2
        Me.ucrSelectedGraphReceiver.ucrSelector = Nothing
        '
        'ucrSelectorGraphAsImage
        '
        Me.ucrSelectorGraphAsImage.bShowHiddenColumns = False
        Me.ucrSelectorGraphAsImage.bUseCurrentFilter = True
        Me.ucrSelectorGraphAsImage.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorGraphAsImage.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorGraphAsImage.Name = "ucrSelectorGraphAsImage"
        Me.ucrSelectorGraphAsImage.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorGraphAsImage.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 241)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(404, 52)
        Me.ucrBase.TabIndex = 12
        '
        'ucrPnlImageFormats
        '
        Me.ucrPnlImageFormats.Location = New System.Drawing.Point(268, 84)
        Me.ucrPnlImageFormats.Name = "ucrPnlImageFormats"
        Me.ucrPnlImageFormats.Size = New System.Drawing.Size(116, 66)
        Me.ucrPnlImageFormats.TabIndex = 14
        '
        'dlgExportGraphAsImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 296)
        Me.Controls.Add(Me.rdoTex)
        Me.Controls.Add(Me.rdoWmf)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.rdoSvg)
        Me.Controls.Add(Me.ucrInputFile)
        Me.Controls.Add(Me.rdoBmp)
        Me.Controls.Add(Me.lblSelectedGraph)
        Me.Controls.Add(Me.rdoJpeg)
        Me.Controls.Add(Me.ucrSelectedGraphReceiver)
        Me.Controls.Add(Me.rdoPng)
        Me.Controls.Add(Me.ucrSelectorGraphAsImage)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlImageFormats)
        Me.Controls.Add(Me.grpImageFormats)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportGraphAsImage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Graph As Image"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorGraphAsImage As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectedGraphReceiver As ucrReceiverSingle
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents ucrInputFile As ucrInputTextBox
    Friend WithEvents lblSelectedGraph As Label
    Friend WithEvents grpImageFormats As GroupBox
    Friend WithEvents rdoTex As RadioButton
    Friend WithEvents rdoWmf As RadioButton
    Friend WithEvents rdoSvg As RadioButton
    Friend WithEvents rdoBmp As RadioButton
    Friend WithEvents rdoJpeg As RadioButton
    Friend WithEvents rdoPng As RadioButton
    Friend WithEvents ucrPnlImageFormats As UcrPanel
End Class
