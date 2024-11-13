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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgUseTable))
        Me.btnTableOptions = New System.Windows.Forms.Button()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrTablesReceiver = New instat.ucrReceiverSingle()
        Me.ucrTablesSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrFilePath = New instat.ucrFilePath()
        Me.lblFileType = New System.Windows.Forms.Label()
        Me.ucrChkExport = New instat.ucrCheck()
        Me.cboFileType = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnTableOptions
        '
        Me.btnTableOptions.Location = New System.Drawing.Point(8, 214)
        Me.btnTableOptions.Name = "btnTableOptions"
        Me.btnTableOptions.Size = New System.Drawing.Size(135, 23)
        Me.btnTableOptions.TabIndex = 11
        Me.btnTableOptions.Text = "Table Options"
        Me.btnTableOptions.UseVisualStyleBackColor = True
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
        'ucrSaveTable
        '
        Me.ucrSaveTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTable.Location = New System.Drawing.Point(11, 251)
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
        Me.ucrBase.Location = New System.Drawing.Point(2, 397)
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
        'ucrFilePath
        '
        Me.ucrFilePath.AutoSize = True
        Me.ucrFilePath.DefaultFileSuggestionName = ""
        Me.ucrFilePath.FilePath = ""
        Me.ucrFilePath.FilePathBrowseText = "Browse"
        Me.ucrFilePath.FilePathDialogFilter = resources.GetString("ucrFilePath.FilePathDialogFilter")
        Me.ucrFilePath.FilePathDialogTitle = "Export Data File"
        Me.ucrFilePath.FilePathLabel = "Save As:"
        Me.ucrFilePath.FolderBrowse = False
        Me.ucrFilePath.Location = New System.Drawing.Point(30, 346)
        Me.ucrFilePath.Name = "ucrFilePath"
        Me.ucrFilePath.SelectedFileFilterIndex = 1
        Me.ucrFilePath.Size = New System.Drawing.Size(365, 34)
        Me.ucrFilePath.TabIndex = 28
        '
        'lblFileType
        '
        Me.lblFileType.AutoSize = True
        Me.lblFileType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFileType.Location = New System.Drawing.Point(31, 320)
        Me.lblFileType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFileType.Name = "lblFileType"
        Me.lblFileType.Size = New System.Drawing.Size(86, 13)
        Me.lblFileType.TabIndex = 30
        Me.lblFileType.Text = "Select File Type:"
        '
        'ucrChkExport
        '
        Me.ucrChkExport.AutoSize = True
        Me.ucrChkExport.Checked = False
        Me.ucrChkExport.Location = New System.Drawing.Point(12, 290)
        Me.ucrChkExport.Name = "ucrChkExport"
        Me.ucrChkExport.Size = New System.Drawing.Size(253, 23)
        Me.ucrChkExport.TabIndex = 31
        '
        'cboFileType
        '
        Me.cboFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFileType.FormattingEnabled = True
        Me.cboFileType.Location = New System.Drawing.Point(164, 313)
        Me.cboFileType.Name = "cboFileType"
        Me.cboFileType.Size = New System.Drawing.Size(170, 21)
        Me.cboFileType.TabIndex = 32
        '
        'dlgUseTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 452)
        Me.Controls.Add(Me.cboFileType)
        Me.Controls.Add(Me.ucrChkExport)
        Me.Controls.Add(Me.lblFileType)
        Me.Controls.Add(Me.ucrFilePath)
        Me.Controls.Add(Me.lblTable)
        Me.Controls.Add(Me.btnTableOptions)
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
    Friend WithEvents btnTableOptions As Button
    Friend WithEvents lblTable As Label
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrFilePath As ucrFilePath
    Friend WithEvents lblFileType As Label
    Friend WithEvents ucrChkExport As ucrCheck
    Friend WithEvents cboFileType As ComboBox
End Class
