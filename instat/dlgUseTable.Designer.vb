<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgUseTable
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
        Me.UcrButtons1 = New instat.ucrButtons()
        Me.ucrTablesSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrTablesReceiver = New instat.ucrReceiverSingle()
        Me.lblTablesToUse = New System.Windows.Forms.Label()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrPnlExportOptions = New instat.UcrPanel()
        Me.rdoAsHTML = New System.Windows.Forms.RadioButton()
        Me.rdoAsRTF = New System.Windows.Forms.RadioButton()
        Me.rdoAsWord = New System.Windows.Forms.RadioButton()
        Me.rdoAsLaTex = New System.Windows.Forms.RadioButton()
        Me.ucrChkExportTable = New instat.ucrCheck()
        Me.cmdFormatOptions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UcrButtons1
        '
        Me.UcrButtons1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrButtons1.Location = New System.Drawing.Point(1, 397)
        Me.UcrButtons1.Name = "UcrButtons1"
        Me.UcrButtons1.Size = New System.Drawing.Size(410, 52)
        Me.UcrButtons1.TabIndex = 0
        '
        'ucrTablesSelector
        '
        Me.ucrTablesSelector.AutoSize = True
        Me.ucrTablesSelector.bDropUnusedFilterLevels = False
        Me.ucrTablesSelector.bShowHiddenColumns = False
        Me.ucrTablesSelector.bUseCurrentFilter = True
        Me.ucrTablesSelector.Location = New System.Drawing.Point(8, 23)
        Me.ucrTablesSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrTablesSelector.Name = "ucrTablesSelector"
        Me.ucrTablesSelector.Size = New System.Drawing.Size(213, 183)
        Me.ucrTablesSelector.TabIndex = 1
        '
        'ucrTablesReceiver
        '
        Me.ucrTablesReceiver.AutoSize = True
        Me.ucrTablesReceiver.frmParent = Me
        Me.ucrTablesReceiver.Location = New System.Drawing.Point(256, 59)
        Me.ucrTablesReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrTablesReceiver.Name = "ucrTablesReceiver"
        Me.ucrTablesReceiver.Selector = Nothing
        Me.ucrTablesReceiver.Size = New System.Drawing.Size(135, 20)
        Me.ucrTablesReceiver.strNcFilePath = ""
        Me.ucrTablesReceiver.TabIndex = 2
        Me.ucrTablesReceiver.ucrSelector = Nothing
        '
        'lblTablesToUse
        '
        Me.lblTablesToUse.AutoSize = True
        Me.lblTablesToUse.Location = New System.Drawing.Point(255, 43)
        Me.lblTablesToUse.Name = "lblTablesToUse"
        Me.lblTablesToUse.Size = New System.Drawing.Size(75, 13)
        Me.lblTablesToUse.TabIndex = 3
        Me.lblTablesToUse.Text = "Table To Use:"
        '
        'ucrSaveTable
        '
        Me.ucrSaveTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTable.Location = New System.Drawing.Point(1, 359)
        Me.ucrSaveTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveTable.Name = "ucrSaveTable"
        Me.ucrSaveTable.Size = New System.Drawing.Size(403, 34)
        Me.ucrSaveTable.TabIndex = 4
        '
        'ucrPnlExportOptions
        '
        Me.ucrPnlExportOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlExportOptions.Location = New System.Drawing.Point(8, 243)
        Me.ucrPnlExportOptions.Name = "ucrPnlExportOptions"
        Me.ucrPnlExportOptions.Size = New System.Drawing.Size(105, 118)
        Me.ucrPnlExportOptions.TabIndex = 5
        '
        'rdoAsHTML
        '
        Me.rdoAsHTML.AutoSize = True
        Me.rdoAsHTML.Location = New System.Drawing.Point(14, 250)
        Me.rdoAsHTML.Name = "rdoAsHTML"
        Me.rdoAsHTML.Size = New System.Drawing.Size(70, 17)
        Me.rdoAsHTML.TabIndex = 6
        Me.rdoAsHTML.TabStop = True
        Me.rdoAsHTML.Text = "As HTML"
        Me.rdoAsHTML.UseVisualStyleBackColor = True
        '
        'rdoAsRTF
        '
        Me.rdoAsRTF.AutoSize = True
        Me.rdoAsRTF.Location = New System.Drawing.Point(14, 275)
        Me.rdoAsRTF.Name = "rdoAsRTF"
        Me.rdoAsRTF.Size = New System.Drawing.Size(61, 17)
        Me.rdoAsRTF.TabIndex = 7
        Me.rdoAsRTF.TabStop = True
        Me.rdoAsRTF.Text = "As RTF"
        Me.rdoAsRTF.UseVisualStyleBackColor = True
        '
        'rdoAsWord
        '
        Me.rdoAsWord.AutoSize = True
        Me.rdoAsWord.Location = New System.Drawing.Point(14, 300)
        Me.rdoAsWord.Name = "rdoAsWord"
        Me.rdoAsWord.Size = New System.Drawing.Size(66, 17)
        Me.rdoAsWord.TabIndex = 8
        Me.rdoAsWord.TabStop = True
        Me.rdoAsWord.Text = "As Word"
        Me.rdoAsWord.UseVisualStyleBackColor = True
        '
        'rdoAsLaTex
        '
        Me.rdoAsLaTex.AutoSize = True
        Me.rdoAsLaTex.Location = New System.Drawing.Point(14, 325)
        Me.rdoAsLaTex.Name = "rdoAsLaTex"
        Me.rdoAsLaTex.Size = New System.Drawing.Size(70, 17)
        Me.rdoAsLaTex.TabIndex = 9
        Me.rdoAsLaTex.TabStop = True
        Me.rdoAsLaTex.Text = "As LaTex"
        Me.rdoAsLaTex.UseVisualStyleBackColor = True
        '
        'ucrChkExportTable
        '
        Me.ucrChkExportTable.AutoSize = True
        Me.ucrChkExportTable.Checked = False
        Me.ucrChkExportTable.Location = New System.Drawing.Point(10, 216)
        Me.ucrChkExportTable.Name = "ucrChkExportTable"
        Me.ucrChkExportTable.Size = New System.Drawing.Size(146, 23)
        Me.ucrChkExportTable.TabIndex = 10
        '
        'cmdFormatOptions
        '
        Me.cmdFormatOptions.Location = New System.Drawing.Point(256, 183)
        Me.cmdFormatOptions.Name = "cmdFormatOptions"
        Me.cmdFormatOptions.Size = New System.Drawing.Size(135, 23)
        Me.cmdFormatOptions.TabIndex = 11
        Me.cmdFormatOptions.Text = "Format Options"
        Me.cmdFormatOptions.UseVisualStyleBackColor = True
        '
        'dlgUseTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 450)
        Me.Controls.Add(Me.cmdFormatOptions)
        Me.Controls.Add(Me.ucrChkExportTable)
        Me.Controls.Add(Me.rdoAsLaTex)
        Me.Controls.Add(Me.rdoAsWord)
        Me.Controls.Add(Me.rdoAsRTF)
        Me.Controls.Add(Me.rdoAsHTML)
        Me.Controls.Add(Me.ucrPnlExportOptions)
        Me.Controls.Add(Me.ucrSaveTable)
        Me.Controls.Add(Me.lblTablesToUse)
        Me.Controls.Add(Me.ucrTablesReceiver)
        Me.Controls.Add(Me.ucrTablesSelector)
        Me.Controls.Add(Me.UcrButtons1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "dlgUseTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Use Table"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrButtons1 As ucrButtons
    Friend WithEvents ucrTablesSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrTablesReceiver As ucrReceiverSingle
    Friend WithEvents lblTablesToUse As Label
    Friend WithEvents ucrPnlExportOptions As UcrPanel
    Friend WithEvents ucrSaveTable As ucrSave
    Friend WithEvents rdoAsWord As RadioButton
    Friend WithEvents rdoAsRTF As RadioButton
    Friend WithEvents rdoAsHTML As RadioButton
    Friend WithEvents cmdFormatOptions As Button
    Friend WithEvents ucrChkExportTable As ucrCheck
    Friend WithEvents rdoAsLaTex As RadioButton
End Class
