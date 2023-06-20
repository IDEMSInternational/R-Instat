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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrTablesReceiver = New instat.ucrReceiverSingle()
        Me.lblTablesToUse = New System.Windows.Forms.Label()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrPnlExportOptions = New instat.UcrPanel()
        Me.rdoAsHTML = New System.Windows.Forms.RadioButton()
        Me.rdoAsRTF = New System.Windows.Forms.RadioButton()
        Me.rdoAsWord = New System.Windows.Forms.RadioButton()
        Me.rdoAsLaTex = New System.Windows.Forms.RadioButton()
        Me.cmdFormatOptions = New System.Windows.Forms.Button()
        Me.lblExportTable = New System.Windows.Forms.Label()
        Me.ucrTablesSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(2, 397)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(407, 52)
        Me.ucrBase.TabIndex = 0
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
        Me.ucrSaveTable.Location = New System.Drawing.Point(10, 360)
        Me.ucrSaveTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveTable.Name = "ucrSaveTable"
        Me.ucrSaveTable.Size = New System.Drawing.Size(390, 34)
        Me.ucrSaveTable.TabIndex = 4
        '
        'ucrPnlExportOptions
        '
        Me.ucrPnlExportOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlExportOptions.Enabled = False
        Me.ucrPnlExportOptions.Location = New System.Drawing.Point(8, 243)
        Me.ucrPnlExportOptions.Name = "ucrPnlExportOptions"
        Me.ucrPnlExportOptions.Size = New System.Drawing.Size(105, 110)
        Me.ucrPnlExportOptions.TabIndex = 5
        '
        'rdoAsHTML
        '
        Me.rdoAsHTML.AutoSize = True
        Me.rdoAsHTML.Location = New System.Drawing.Point(14, 250)
        Me.rdoAsHTML.Name = "rdoAsHTML"
        Me.rdoAsHTML.Size = New System.Drawing.Size(55, 17)
        Me.rdoAsHTML.TabIndex = 6
        Me.rdoAsHTML.TabStop = True
        Me.rdoAsHTML.Text = "HTML"
        Me.rdoAsHTML.UseVisualStyleBackColor = True
        '
        'rdoAsRTF
        '
        Me.rdoAsRTF.AutoSize = True
        Me.rdoAsRTF.Location = New System.Drawing.Point(14, 275)
        Me.rdoAsRTF.Name = "rdoAsRTF"
        Me.rdoAsRTF.Size = New System.Drawing.Size(46, 17)
        Me.rdoAsRTF.TabIndex = 7
        Me.rdoAsRTF.TabStop = True
        Me.rdoAsRTF.Text = "RTF"
        Me.rdoAsRTF.UseVisualStyleBackColor = True
        '
        'rdoAsWord
        '
        Me.rdoAsWord.AutoSize = True
        Me.rdoAsWord.Location = New System.Drawing.Point(14, 300)
        Me.rdoAsWord.Name = "rdoAsWord"
        Me.rdoAsWord.Size = New System.Drawing.Size(51, 17)
        Me.rdoAsWord.TabIndex = 8
        Me.rdoAsWord.TabStop = True
        Me.rdoAsWord.Text = "Word"
        Me.rdoAsWord.UseVisualStyleBackColor = True
        '
        'rdoAsLaTex
        '
        Me.rdoAsLaTex.AutoSize = True
        Me.rdoAsLaTex.Location = New System.Drawing.Point(14, 325)
        Me.rdoAsLaTex.Name = "rdoAsLaTex"
        Me.rdoAsLaTex.Size = New System.Drawing.Size(55, 17)
        Me.rdoAsLaTex.TabIndex = 9
        Me.rdoAsLaTex.TabStop = True
        Me.rdoAsLaTex.Text = "LaTex"
        Me.rdoAsLaTex.UseVisualStyleBackColor = True
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
        'lblExportTable
        '
        Me.lblExportTable.AutoSize = True
        Me.lblExportTable.Enabled = False
        Me.lblExportTable.Location = New System.Drawing.Point(5, 227)
        Me.lblExportTable.Name = "lblExportTable"
        Me.lblExportTable.Size = New System.Drawing.Size(119, 13)
        Me.lblExportTable.TabIndex = 12
        Me.lblExportTable.Text = "Export Table Object As:"
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
        'dlgUseTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 450)
        Me.Controls.Add(Me.lblExportTable)
        Me.Controls.Add(Me.cmdFormatOptions)
        Me.Controls.Add(Me.rdoAsLaTex)
        Me.Controls.Add(Me.rdoAsWord)
        Me.Controls.Add(Me.rdoAsRTF)
        Me.Controls.Add(Me.rdoAsHTML)
        Me.Controls.Add(Me.ucrPnlExportOptions)
        Me.Controls.Add(Me.ucrSaveTable)
        Me.Controls.Add(Me.lblTablesToUse)
        Me.Controls.Add(Me.ucrTablesReceiver)
        Me.Controls.Add(Me.ucrTablesSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUseTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Use Table"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrTablesSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrTablesReceiver As ucrReceiverSingle
    Friend WithEvents lblTablesToUse As Label
    Friend WithEvents ucrPnlExportOptions As UcrPanel
    Friend WithEvents ucrSaveTable As ucrSave
    Friend WithEvents rdoAsWord As RadioButton
    Friend WithEvents rdoAsRTF As RadioButton
    Friend WithEvents rdoAsHTML As RadioButton
    Friend WithEvents cmdFormatOptions As Button
    Friend WithEvents rdoAsLaTex As RadioButton
    Friend WithEvents lblExportTable As Label
End Class
