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
        Me.rdoAsHTML = New System.Windows.Forms.RadioButton()
        Me.rdoAsRTF = New System.Windows.Forms.RadioButton()
        Me.rdoAsWord = New System.Windows.Forms.RadioButton()
        Me.rdoAsLaTex = New System.Windows.Forms.RadioButton()
        Me.cmdTableOptions = New System.Windows.Forms.Button()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.lblExportTables = New System.Windows.Forms.Label()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrTablesReceiver = New instat.ucrReceiverSingle()
        Me.ucrTablesSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'rdoAsHTML
        '
        Me.rdoAsHTML.AutoSize = True
        Me.rdoAsHTML.Location = New System.Drawing.Point(14, 269)
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
        Me.rdoAsRTF.Location = New System.Drawing.Point(14, 294)
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
        Me.rdoAsWord.Location = New System.Drawing.Point(14, 319)
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
        Me.rdoAsLaTex.Location = New System.Drawing.Point(14, 344)
        Me.rdoAsLaTex.Name = "rdoAsLaTex"
        Me.rdoAsLaTex.Size = New System.Drawing.Size(55, 17)
        Me.rdoAsLaTex.TabIndex = 9
        Me.rdoAsLaTex.TabStop = True
        Me.rdoAsLaTex.Text = "LaTex"
        Me.rdoAsLaTex.UseVisualStyleBackColor = True
        '
        'cmdTableOptions
        '
        Me.cmdTableOptions.Location = New System.Drawing.Point(8, 214)
        Me.cmdTableOptions.Name = "cmdTableOptions"
        Me.cmdTableOptions.Size = New System.Drawing.Size(135, 23)
        Me.cmdTableOptions.TabIndex = 11
        Me.cmdTableOptions.Text = "Table Options"
        Me.cmdTableOptions.UseVisualStyleBackColor = True
        '
        'lblTable
        '
        Me.lblTable.AutoSize = True
        Me.lblTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTable.Location = New System.Drawing.Point(258, 43)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(37, 13)
        Me.lblTable.TabIndex = 25
        Me.lblTable.Text = "Table:"
        '
        'lblExportTables
        '
        Me.lblExportTables.AutoSize = True
        Me.lblExportTables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExportTables.Location = New System.Drawing.Point(12, 248)
        Me.lblExportTables.Name = "lblExportTables"
        Me.lblExportTables.Size = New System.Drawing.Size(84, 13)
        Me.lblExportTables.TabIndex = 26
        Me.lblExportTables.Text = "Export Table as:"
        '
        'ucrSaveTable
        '
        Me.ucrSaveTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTable.Location = New System.Drawing.Point(10, 379)
        Me.ucrSaveTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveTable.Name = "ucrSaveTable"
        Me.ucrSaveTable.Size = New System.Drawing.Size(390, 34)
        Me.ucrSaveTable.TabIndex = 4
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
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(2, 417)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(407, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(8, 263)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(158, 106)
        Me.ucrPnlOptions.TabIndex = 27
        '
        'dlgUseTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 478)
        Me.Controls.Add(Me.lblExportTables)
        Me.Controls.Add(Me.lblTable)
        Me.Controls.Add(Me.cmdTableOptions)
        Me.Controls.Add(Me.rdoAsLaTex)
        Me.Controls.Add(Me.rdoAsWord)
        Me.Controls.Add(Me.rdoAsRTF)
        Me.Controls.Add(Me.rdoAsHTML)
        Me.Controls.Add(Me.ucrSaveTable)
        Me.Controls.Add(Me.ucrTablesReceiver)
        Me.Controls.Add(Me.ucrTablesSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlOptions)
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
    Friend WithEvents ucrSaveTable As ucrSave
    Friend WithEvents rdoAsWord As RadioButton
    Friend WithEvents rdoAsRTF As RadioButton
    Friend WithEvents rdoAsHTML As RadioButton
    Friend WithEvents cmdTableOptions As Button
    Friend WithEvents rdoAsLaTex As RadioButton
    Friend WithEvents lblTable As Label
    Friend WithEvents lblExportTables As Label
    Friend WithEvents ucrPnlOptions As UcrPanel
End Class
