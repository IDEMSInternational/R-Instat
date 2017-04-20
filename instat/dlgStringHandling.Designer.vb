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
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.lblReplaceBy = New System.Windows.Forms.Label()
        Me.lblPattern = New System.Windows.Forms.Label()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.rdoReplace = New System.Windows.Forms.RadioButton()
        Me.rdoLocate = New System.Windows.Forms.RadioButton()
        Me.rdoExtract = New System.Windows.Forms.RadioButton()
        Me.rdoDetect = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverStringHandling = New instat.ucrReceiverSingle()
        Me.ucrInputReplaceBy = New instat.ucrInputTextBox()
        Me.ucrSaveStringHandling = New instat.ucrSave()
        Me.ucrInputPattern = New instat.ucrInputTextBox()
        Me.ucrSelectorStringHandling = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlStringHandling = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.Location = New System.Drawing.Point(259, 80)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(45, 13)
        Me.lblColumn.TabIndex = 7
        Me.lblColumn.Text = "Column:"
        '
        'lblReplaceBy
        '
        Me.lblReplaceBy.AutoSize = True
        Me.lblReplaceBy.Location = New System.Drawing.Point(259, 167)
        Me.lblReplaceBy.Name = "lblReplaceBy"
        Me.lblReplaceBy.Size = New System.Drawing.Size(65, 13)
        Me.lblReplaceBy.TabIndex = 11
        Me.lblReplaceBy.Text = "Replace By:"
        '
        'lblPattern
        '
        Me.lblPattern.AutoSize = True
        Me.lblPattern.Location = New System.Drawing.Point(259, 123)
        Me.lblPattern.Name = "lblPattern"
        Me.lblPattern.Size = New System.Drawing.Size(44, 13)
        Me.lblPattern.TabIndex = 9
        Me.lblPattern.Text = "Pattern:"
        '
        'rdoCount
        '
        Me.rdoCount.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCount.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCount.FlatAppearance.BorderSize = 2
        Me.rdoCount.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCount.Location = New System.Drawing.Point(58, 12)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(61, 27)
        Me.rdoCount.TabIndex = 1
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
        Me.rdoReplace.Location = New System.Drawing.Point(294, 12)
        Me.rdoReplace.Name = "rdoReplace"
        Me.rdoReplace.Size = New System.Drawing.Size(61, 27)
        Me.rdoReplace.TabIndex = 5
        Me.rdoReplace.TabStop = True
        Me.rdoReplace.Text = "Replace"
        Me.rdoReplace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoReplace.UseVisualStyleBackColor = True
        '
        'rdoLocate
        '
        Me.rdoLocate.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoLocate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLocate.FlatAppearance.BorderSize = 2
        Me.rdoLocate.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLocate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoLocate.Location = New System.Drawing.Point(235, 12)
        Me.rdoLocate.Name = "rdoLocate"
        Me.rdoLocate.Size = New System.Drawing.Size(61, 27)
        Me.rdoLocate.TabIndex = 4
        Me.rdoLocate.TabStop = True
        Me.rdoLocate.Text = "Locate"
        Me.rdoLocate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoLocate.UseVisualStyleBackColor = True
        '
        'rdoExtract
        '
        Me.rdoExtract.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoExtract.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoExtract.FlatAppearance.BorderSize = 2
        Me.rdoExtract.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoExtract.Location = New System.Drawing.Point(176, 12)
        Me.rdoExtract.Name = "rdoExtract"
        Me.rdoExtract.Size = New System.Drawing.Size(61, 27)
        Me.rdoExtract.TabIndex = 3
        Me.rdoExtract.TabStop = True
        Me.rdoExtract.Text = "Extract"
        Me.rdoExtract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoExtract.UseVisualStyleBackColor = True
        '
        'rdoDetect
        '
        Me.rdoDetect.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDetect.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDetect.FlatAppearance.BorderSize = 2
        Me.rdoDetect.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDetect.Location = New System.Drawing.Point(117, 12)
        Me.rdoDetect.Name = "rdoDetect"
        Me.rdoDetect.Size = New System.Drawing.Size(61, 27)
        Me.rdoDetect.TabIndex = 2
        Me.rdoDetect.TabStop = True
        Me.rdoDetect.Text = "Detect"
        Me.rdoDetect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDetect.UseVisualStyleBackColor = True
        '
        'ucrReceiverStringHandling
        '
        Me.ucrReceiverStringHandling.frmParent = Me
        Me.ucrReceiverStringHandling.Location = New System.Drawing.Point(259, 95)
        Me.ucrReceiverStringHandling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStringHandling.Name = "ucrReceiverStringHandling"
        Me.ucrReceiverStringHandling.Selector = Nothing
        Me.ucrReceiverStringHandling.Size = New System.Drawing.Size(138, 20)
        Me.ucrReceiverStringHandling.TabIndex = 8
        Me.ucrReceiverStringHandling.ucrSelector = Nothing
        '
        'ucrInputReplaceBy
        '
        Me.ucrInputReplaceBy.AddQuotesIfUnrecognised = True
        Me.ucrInputReplaceBy.IsMultiline = False
        Me.ucrInputReplaceBy.IsReadOnly = False
        Me.ucrInputReplaceBy.Location = New System.Drawing.Point(259, 182)
        Me.ucrInputReplaceBy.Name = "ucrInputReplaceBy"
        Me.ucrInputReplaceBy.Size = New System.Drawing.Size(138, 21)
        Me.ucrInputReplaceBy.TabIndex = 12
        '
        'ucrSaveStringHandling
        '
        Me.ucrSaveStringHandling.Location = New System.Drawing.Point(10, 234)
        Me.ucrSaveStringHandling.Name = "ucrSaveStringHandling"
        Me.ucrSaveStringHandling.Size = New System.Drawing.Size(279, 24)
        Me.ucrSaveStringHandling.TabIndex = 13
        '
        'ucrInputPattern
        '
        Me.ucrInputPattern.AddQuotesIfUnrecognised = True
        Me.ucrInputPattern.IsMultiline = False
        Me.ucrInputPattern.IsReadOnly = False
        Me.ucrInputPattern.Location = New System.Drawing.Point(259, 138)
        Me.ucrInputPattern.Name = "ucrInputPattern"
        Me.ucrInputPattern.Size = New System.Drawing.Size(138, 21)
        Me.ucrInputPattern.TabIndex = 10
        '
        'ucrSelectorStringHandling
        '
        Me.ucrSelectorStringHandling.bShowHiddenColumns = False
        Me.ucrSelectorStringHandling.bUseCurrentFilter = True
        Me.ucrSelectorStringHandling.Location = New System.Drawing.Point(10, 45)
        Me.ucrSelectorStringHandling.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStringHandling.Name = "ucrSelectorStringHandling"
        Me.ucrSelectorStringHandling.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorStringHandling.TabIndex = 6
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 263)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(406, 52)
        Me.ucrBase.TabIndex = 14
        '
        'ucrPnlStringHandling
        '
        Me.ucrPnlStringHandling.Location = New System.Drawing.Point(38, 1)
        Me.ucrPnlStringHandling.Name = "ucrPnlStringHandling"
        Me.ucrPnlStringHandling.Size = New System.Drawing.Size(338, 51)
        Me.ucrPnlStringHandling.TabIndex = 0
        '
        'dlgStringHandling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 323)
        Me.Controls.Add(Me.rdoDetect)
        Me.Controls.Add(Me.rdoExtract)
        Me.Controls.Add(Me.rdoLocate)
        Me.Controls.Add(Me.rdoReplace)
        Me.Controls.Add(Me.rdoCount)
        Me.Controls.Add(Me.ucrReceiverStringHandling)
        Me.Controls.Add(Me.lblPattern)
        Me.Controls.Add(Me.lblReplaceBy)
        Me.Controls.Add(Me.lblColumn)
        Me.Controls.Add(Me.ucrInputReplaceBy)
        Me.Controls.Add(Me.ucrSaveStringHandling)
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
    Friend WithEvents ucrSaveStringHandling As ucrSave
    Friend WithEvents ucrInputReplaceBy As ucrInputTextBox
    Friend WithEvents lblColumn As Label
    Friend WithEvents lblReplaceBy As Label
    Friend WithEvents lblPattern As Label
    Friend WithEvents ucrReceiverStringHandling As ucrReceiverSingle
    Friend WithEvents rdoDetect As RadioButton
    Friend WithEvents rdoExtract As RadioButton
    Friend WithEvents rdoLocate As RadioButton
    Friend WithEvents rdoReplace As RadioButton
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents ucrPnlStringHandling As UcrPanel
End Class
