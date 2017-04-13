<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgStringHandling
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
        Me.ucrSelectorStringHandling = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputPattern = New instat.ucrInputTextBox()
        Me.ucrSave = New instat.ucrSave()
        Me.ucrInputReplaceBy = New instat.ucrInputTextBox()
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.lblRepalceBy = New System.Windows.Forms.Label()
        Me.lblPattern = New System.Windows.Forms.Label()
        Me.ucrReceiverStringHandling = New instat.ucrReceiverSingle()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.rdoReplace = New System.Windows.Forms.RadioButton()
        Me.rdoLocate = New System.Windows.Forms.RadioButton()
        Me.rdoExtract = New System.Windows.Forms.RadioButton()
        Me.rdoDetect = New System.Windows.Forms.RadioButton()
        Me.ucrPnlStringHandling = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 295)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorStringHandling
        '
        Me.ucrSelectorStringHandling.bShowHiddenColumns = False
        Me.ucrSelectorStringHandling.bUseCurrentFilter = True
        Me.ucrSelectorStringHandling.Location = New System.Drawing.Point(10, 55)
        Me.ucrSelectorStringHandling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStringHandling.Name = "ucrSelectorStringHandling"
        Me.ucrSelectorStringHandling.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorStringHandling.TabIndex = 2
        '
        'ucrInputPattern
        '
        Me.ucrInputPattern.AddQuotesIfUnrecognised = True
        Me.ucrInputPattern.IsMultiline = False
        Me.ucrInputPattern.IsReadOnly = False
        Me.ucrInputPattern.Location = New System.Drawing.Point(240, 142)
        Me.ucrInputPattern.Name = "ucrInputPattern"
        Me.ucrInputPattern.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPattern.TabIndex = 4
        '
        'ucrSave
        '
        Me.ucrSave.Location = New System.Drawing.Point(10, 260)
        Me.ucrSave.Name = "ucrSave"
        Me.ucrSave.Size = New System.Drawing.Size(406, 24)
        Me.ucrSave.TabIndex = 5
        '
        'ucrInputReplaceBy
        '
        Me.ucrInputReplaceBy.AddQuotesIfUnrecognised = True
        Me.ucrInputReplaceBy.IsMultiline = False
        Me.ucrInputReplaceBy.IsReadOnly = False
        Me.ucrInputReplaceBy.Location = New System.Drawing.Point(241, 192)
        Me.ucrInputReplaceBy.Name = "ucrInputReplaceBy"
        Me.ucrInputReplaceBy.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputReplaceBy.TabIndex = 6
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.Location = New System.Drawing.Point(237, 78)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(42, 13)
        Me.lblColumn.TabIndex = 7
        Me.lblColumn.Text = "Column"
        '
        'lblRepalceBy
        '
        Me.lblRepalceBy.AutoSize = True
        Me.lblRepalceBy.Location = New System.Drawing.Point(238, 176)
        Me.lblRepalceBy.Name = "lblRepalceBy"
        Me.lblRepalceBy.Size = New System.Drawing.Size(59, 13)
        Me.lblRepalceBy.TabIndex = 8
        Me.lblRepalceBy.Text = "ReplaceBy"
        '
        'lblPattern
        '
        Me.lblPattern.AutoSize = True
        Me.lblPattern.Location = New System.Drawing.Point(238, 126)
        Me.lblPattern.Name = "lblPattern"
        Me.lblPattern.Size = New System.Drawing.Size(41, 13)
        Me.lblPattern.TabIndex = 9
        Me.lblPattern.Text = "Pattern"
        '
        'ucrReceiverStringHandling
        '
        Me.ucrReceiverStringHandling.frmParent = Me
        Me.ucrReceiverStringHandling.Location = New System.Drawing.Point(240, 91)
        Me.ucrReceiverStringHandling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStringHandling.Name = "ucrReceiverStringHandling"
        Me.ucrReceiverStringHandling.Selector = Nothing
        Me.ucrReceiverStringHandling.Size = New System.Drawing.Size(138, 20)
        Me.ucrReceiverStringHandling.TabIndex = 10
        '
        'rdoCount
        '
        Me.rdoCount.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCount.AutoSize = True
        Me.rdoCount.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCount.FlatAppearance.BorderSize = 2
        Me.rdoCount.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCount.Location = New System.Drawing.Point(102, 12)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(49, 27)
        Me.rdoCount.TabIndex = 11
        Me.rdoCount.TabStop = True
        Me.rdoCount.Text = "Count"
        Me.rdoCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'rdoReplace
        '
        Me.rdoReplace.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoReplace.AutoSize = True
        Me.rdoReplace.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplace.FlatAppearance.BorderSize = 2
        Me.rdoReplace.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoReplace.Location = New System.Drawing.Point(303, 12)
        Me.rdoReplace.Name = "rdoReplace"
        Me.rdoReplace.Size = New System.Drawing.Size(61, 27)
        Me.rdoReplace.TabIndex = 12
        Me.rdoReplace.TabStop = True
        Me.rdoReplace.Text = "Replace"
        Me.rdoReplace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoReplace.UseVisualStyleBackColor = True
        '
        'rdoLocate
        '
        Me.rdoLocate.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoLocate.AutoSize = True
        Me.rdoLocate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLocate.FlatAppearance.BorderSize = 2
        Me.rdoLocate.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLocate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoLocate.Location = New System.Drawing.Point(251, 12)
        Me.rdoLocate.Name = "rdoLocate"
        Me.rdoLocate.Size = New System.Drawing.Size(54, 27)
        Me.rdoLocate.TabIndex = 13
        Me.rdoLocate.TabStop = True
        Me.rdoLocate.Text = "Locate"
        Me.rdoLocate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoLocate.UseVisualStyleBackColor = True
        '
        'rdoExtract
        '
        Me.rdoExtract.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoExtract.AutoSize = True
        Me.rdoExtract.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoExtract.FlatAppearance.BorderSize = 2
        Me.rdoExtract.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoExtract.Location = New System.Drawing.Point(199, 12)
        Me.rdoExtract.Name = "rdoExtract"
        Me.rdoExtract.Size = New System.Drawing.Size(54, 27)
        Me.rdoExtract.TabIndex = 14
        Me.rdoExtract.TabStop = True
        Me.rdoExtract.Text = "Extract"
        Me.rdoExtract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoExtract.UseVisualStyleBackColor = True
        '
        'rdoDetect
        '
        Me.rdoDetect.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDetect.AutoSize = True
        Me.rdoDetect.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDetect.FlatAppearance.BorderSize = 2
        Me.rdoDetect.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDetect.Location = New System.Drawing.Point(148, 12)
        Me.rdoDetect.Name = "rdoDetect"
        Me.rdoDetect.Size = New System.Drawing.Size(53, 27)
        Me.rdoDetect.TabIndex = 15
        Me.rdoDetect.TabStop = True
        Me.rdoDetect.Text = "Detect"
        Me.rdoDetect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDetect.UseVisualStyleBackColor = True
        '
        'ucrPnlStringHandling
        '
        Me.ucrPnlStringHandling.Location = New System.Drawing.Point(83, 1)
        Me.ucrPnlStringHandling.Name = "ucrPnlStringHandling"
        Me.ucrPnlStringHandling.Size = New System.Drawing.Size(281, 51)
        Me.ucrPnlStringHandling.TabIndex = 16
        '
        'dlgStringHandling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 355)
        Me.Controls.Add(Me.rdoDetect)
        Me.Controls.Add(Me.rdoExtract)
        Me.Controls.Add(Me.rdoLocate)
        Me.Controls.Add(Me.rdoReplace)
        Me.Controls.Add(Me.rdoCount)
        Me.Controls.Add(Me.ucrReceiverStringHandling)
        Me.Controls.Add(Me.lblPattern)
        Me.Controls.Add(Me.lblRepalceBy)
        Me.Controls.Add(Me.lblColumn)
        Me.Controls.Add(Me.ucrInputReplaceBy)
        Me.Controls.Add(Me.ucrSave)
        Me.Controls.Add(Me.ucrInputPattern)
        Me.Controls.Add(Me.ucrSelectorStringHandling)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlStringHandling)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStringHandling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "String Handling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorStringHandling As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputPattern As ucrInputTextBox
    Friend WithEvents ucrSave As ucrSave
    Friend WithEvents ucrInputReplaceBy As ucrInputTextBox
    Friend WithEvents lblColumn As Label
    Friend WithEvents lblRepalceBy As Label
    Friend WithEvents lblPattern As Label
    Friend WithEvents ucrReceiverStringHandling As ucrReceiverSingle
    Friend WithEvents rdoDetect As RadioButton
    Friend WithEvents rdoExtract As RadioButton
    Friend WithEvents rdoLocate As RadioButton
    Friend WithEvents rdoReplace As RadioButton
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents ucrPnlStringHandling As UcrPanel
End Class
