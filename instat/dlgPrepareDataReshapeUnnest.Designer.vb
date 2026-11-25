<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgPrepareDataReshapeUnnest
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
        Me.lblJSONCols = New System.Windows.Forms.Label()
        Me.ucrReceiverJSONCols = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorUnnest = New instat.ucrSelectorByDataFrameAddRemove()
        Me.rdoJSON = New System.Windows.Forms.RadioButton()
        Me.ucrPnlJSONOther = New instat.UcrPanel()
        Me.rdoOther = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverCarryCols = New instat.ucrReceiverMultiple()
        Me.lblCarryCols = New System.Windows.Forms.Label()
        Me.ucrReceiverKeyCols = New instat.ucrReceiverMultiple()
        Me.lblKeyCols = New System.Windows.Forms.Label()
        Me.ucrChkCarryCols = New instat.ucrCheck()
        Me.ucrInputCheckInput = New instat.ucrInputTextBox()
        Me.cmdCheckUniqueKeys = New System.Windows.Forms.Button()
        Me.ucrChkRemovePrefix = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblJSONCols
        '
        Me.lblJSONCols.AutoSize = True
        Me.lblJSONCols.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblJSONCols.Location = New System.Drawing.Point(424, 80)
        Me.lblJSONCols.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJSONCols.Name = "lblJSONCols"
        Me.lblJSONCols.Size = New System.Drawing.Size(131, 20)
        Me.lblJSONCols.TabIndex = 25
        Me.lblJSONCols.Tag = ""
        Me.lblJSONCols.Text = "JSON Column(s):"
        '
        'ucrReceiverJSONCols
        '
        Me.ucrReceiverJSONCols.AutoSize = True
        Me.ucrReceiverJSONCols.frmParent = Me
        Me.ucrReceiverJSONCols.Location = New System.Drawing.Point(424, 102)
        Me.ucrReceiverJSONCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverJSONCols.Name = "ucrReceiverJSONCols"
        Me.ucrReceiverJSONCols.Selector = Nothing
        Me.ucrReceiverJSONCols.Size = New System.Drawing.Size(201, 120)
        Me.ucrReceiverJSONCols.strNcFilePath = ""
        Me.ucrReceiverJSONCols.TabIndex = 26
        Me.ucrReceiverJSONCols.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(14, 609)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 24
        '
        'ucrSelectorUnnest
        '
        Me.ucrSelectorUnnest.AutoSize = True
        Me.ucrSelectorUnnest.bDropUnusedFilterLevels = False
        Me.ucrSelectorUnnest.bShowHiddenColumns = False
        Me.ucrSelectorUnnest.bUseCurrentFilter = True
        Me.ucrSelectorUnnest.Location = New System.Drawing.Point(14, 79)
        Me.ucrSelectorUnnest.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorUnnest.Name = "ucrSelectorUnnest"
        Me.ucrSelectorUnnest.Size = New System.Drawing.Size(320, 284)
        Me.ucrSelectorUnnest.TabIndex = 5
        '
        'rdoJSON
        '
        Me.rdoJSON.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoJSON.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoJSON.FlatAppearance.BorderSize = 2
        Me.rdoJSON.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoJSON.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoJSON.Location = New System.Drawing.Point(131, 13)
        Me.rdoJSON.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoJSON.Name = "rdoJSON"
        Me.rdoJSON.Size = New System.Drawing.Size(200, 40)
        Me.rdoJSON.TabIndex = 29
        Me.rdoJSON.TabStop = True
        Me.rdoJSON.Text = "JSON"
        Me.rdoJSON.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoJSON.UseVisualStyleBackColor = True
        '
        'ucrPnlJSONOther
        '
        Me.ucrPnlJSONOther.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlJSONOther.Location = New System.Drawing.Point(122, 11)
        Me.ucrPnlJSONOther.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlJSONOther.Name = "ucrPnlJSONOther"
        Me.ucrPnlJSONOther.Size = New System.Drawing.Size(407, 52)
        Me.ucrPnlJSONOther.TabIndex = 28
        '
        'rdoOther
        '
        Me.rdoOther.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoOther.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOther.FlatAppearance.BorderSize = 2
        Me.rdoOther.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoOther.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoOther.Location = New System.Drawing.Point(327, 13)
        Me.rdoOther.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoOther.Name = "rdoOther"
        Me.rdoOther.Size = New System.Drawing.Size(194, 40)
        Me.rdoOther.TabIndex = 30
        Me.rdoOther.TabStop = True
        Me.rdoOther.Text = "Other"
        Me.rdoOther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoOther.UseVisualStyleBackColor = True
        '
        'ucrReceiverCarryCols
        '
        Me.ucrReceiverCarryCols.AutoSize = True
        Me.ucrReceiverCarryCols.frmParent = Me
        Me.ucrReceiverCarryCols.Location = New System.Drawing.Point(424, 415)
        Me.ucrReceiverCarryCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCarryCols.Name = "ucrReceiverCarryCols"
        Me.ucrReceiverCarryCols.Selector = Nothing
        Me.ucrReceiverCarryCols.Size = New System.Drawing.Size(201, 120)
        Me.ucrReceiverCarryCols.strNcFilePath = ""
        Me.ucrReceiverCarryCols.TabIndex = 32
        Me.ucrReceiverCarryCols.ucrSelector = Nothing
        '
        'lblCarryCols
        '
        Me.lblCarryCols.AutoSize = True
        Me.lblCarryCols.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCarryCols.Location = New System.Drawing.Point(424, 393)
        Me.lblCarryCols.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCarryCols.Name = "lblCarryCols"
        Me.lblCarryCols.Size = New System.Drawing.Size(126, 20)
        Me.lblCarryCols.TabIndex = 31
        Me.lblCarryCols.Tag = ""
        Me.lblCarryCols.Text = "Carry Column(s):"
        '
        'ucrReceiverKeyCols
        '
        Me.ucrReceiverKeyCols.AutoSize = True
        Me.ucrReceiverKeyCols.frmParent = Me
        Me.ucrReceiverKeyCols.Location = New System.Drawing.Point(424, 258)
        Me.ucrReceiverKeyCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverKeyCols.Name = "ucrReceiverKeyCols"
        Me.ucrReceiverKeyCols.Selector = Nothing
        Me.ucrReceiverKeyCols.Size = New System.Drawing.Size(201, 120)
        Me.ucrReceiverKeyCols.strNcFilePath = ""
        Me.ucrReceiverKeyCols.TabIndex = 34
        Me.ucrReceiverKeyCols.ucrSelector = Nothing
        '
        'lblKeyCols
        '
        Me.lblKeyCols.AutoSize = True
        Me.lblKeyCols.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblKeyCols.Location = New System.Drawing.Point(424, 236)
        Me.lblKeyCols.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKeyCols.Name = "lblKeyCols"
        Me.lblKeyCols.Size = New System.Drawing.Size(115, 20)
        Me.lblKeyCols.TabIndex = 33
        Me.lblKeyCols.Tag = ""
        Me.lblKeyCols.Text = "Key Column(s):"
        '
        'ucrChkCarryCols
        '
        Me.ucrChkCarryCols.AutoSize = True
        Me.ucrChkCarryCols.Checked = False
        Me.ucrChkCarryCols.Location = New System.Drawing.Point(14, 393)
        Me.ucrChkCarryCols.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkCarryCols.Name = "ucrChkCarryCols"
        Me.ucrChkCarryCols.Size = New System.Drawing.Size(241, 34)
        Me.ucrChkCarryCols.TabIndex = 35
        '
        'ucrInputCheckInput
        '
        Me.ucrInputCheckInput.AddQuotesIfUnrecognised = True
        Me.ucrInputCheckInput.AutoSize = True
        Me.ucrInputCheckInput.IsMultiline = False
        Me.ucrInputCheckInput.IsReadOnly = False
        Me.ucrInputCheckInput.Location = New System.Drawing.Point(171, 563)
        Me.ucrInputCheckInput.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputCheckInput.Name = "ucrInputCheckInput"
        Me.ucrInputCheckInput.Size = New System.Drawing.Size(452, 32)
        Me.ucrInputCheckInput.TabIndex = 39
        '
        'cmdCheckUniqueKeys
        '
        Me.cmdCheckUniqueKeys.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCheckUniqueKeys.Location = New System.Drawing.Point(15, 560)
        Me.cmdCheckUniqueKeys.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCheckUniqueKeys.Name = "cmdCheckUniqueKeys"
        Me.cmdCheckUniqueKeys.Size = New System.Drawing.Size(147, 34)
        Me.cmdCheckUniqueKeys.TabIndex = 38
        Me.cmdCheckUniqueKeys.Text = "Check Unique"
        Me.cmdCheckUniqueKeys.UseVisualStyleBackColor = True
        '
        'ucrChkRemovePrefix
        '
        Me.ucrChkRemovePrefix.AutoSize = True
        Me.ucrChkRemovePrefix.Checked = False
        Me.ucrChkRemovePrefix.Location = New System.Drawing.Point(14, 445)
        Me.ucrChkRemovePrefix.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkRemovePrefix.Name = "ucrChkRemovePrefix"
        Me.ucrChkRemovePrefix.Size = New System.Drawing.Size(241, 34)
        Me.ucrChkRemovePrefix.TabIndex = 40
        '
        'dlgPrepareDataReshapeUnnest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 692)
        Me.Controls.Add(Me.ucrChkRemovePrefix)
        Me.Controls.Add(Me.ucrInputCheckInput)
        Me.Controls.Add(Me.cmdCheckUniqueKeys)
        Me.Controls.Add(Me.ucrChkCarryCols)
        Me.Controls.Add(Me.ucrReceiverKeyCols)
        Me.Controls.Add(Me.lblKeyCols)
        Me.Controls.Add(Me.ucrReceiverCarryCols)
        Me.Controls.Add(Me.lblCarryCols)
        Me.Controls.Add(Me.rdoOther)
        Me.Controls.Add(Me.rdoJSON)
        Me.Controls.Add(Me.ucrPnlJSONOther)
        Me.Controls.Add(Me.ucrReceiverJSONCols)
        Me.Controls.Add(Me.lblJSONCols)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorUnnest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPrepareDataReshapeUnnest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unnest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorUnnest As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverJSONCols As ucrReceiverMultiple
    Friend WithEvents lblJSONCols As Label
    Friend WithEvents rdoOther As RadioButton
    Friend WithEvents rdoJSON As RadioButton
    Friend WithEvents ucrPnlJSONOther As UcrPanel
    Friend WithEvents ucrReceiverKeyCols As ucrReceiverMultiple
    Friend WithEvents lblKeyCols As Label
    Friend WithEvents ucrReceiverCarryCols As ucrReceiverMultiple
    Friend WithEvents lblCarryCols As Label
    Friend WithEvents ucrChkCarryCols As ucrCheck
    Friend WithEvents ucrInputCheckInput As ucrInputTextBox
    Friend WithEvents cmdCheckUniqueKeys As Button
    Friend WithEvents ucrChkRemovePrefix As ucrCheck
End Class



