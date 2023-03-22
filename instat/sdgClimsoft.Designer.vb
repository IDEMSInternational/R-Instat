<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgClimsoft
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
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.tbpTitles = New System.Windows.Forms.TabPage()
        Me.grpMetadataToImport = New System.Windows.Forms.GroupBox()
        Me.ucrChkImportElementsMetadata = New instat.ucrCheck()
        Me.ucrChkImportStationsMetadata = New instat.ucrCheck()
        Me.tbColumns = New System.Windows.Forms.TabPage()
        Me.grpColumnsToInclude = New System.Windows.Forms.GroupBox()
        Me.ucrChkIncludeElementAbbrv = New instat.ucrCheck()
        Me.ucrChkIncludeStationName = New instat.ucrCheck()
        Me.ucrChkIncludeAquistion = New instat.ucrCheck()
        Me.ucrChkIncludeEntryForm = New instat.ucrCheck()
        Me.ucrChkIncludeFlag = New instat.ucrCheck()
        Me.ucrChkIncludeQCStatus = New instat.ucrCheck()
        Me.tbpMoreOptions = New System.Windows.Forms.TabControl()
        Me.tbpTitles.SuspendLayout()
        Me.grpMetadataToImport.SuspendLayout()
        Me.tbColumns.SuspendLayout()
        Me.grpColumnsToInclude.SuspendLayout()
        Me.tbpMoreOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(100, 251)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(224, 29)
        Me.ucrBaseSubdialog.TabIndex = 3
        '
        'tbpTitles
        '
        Me.tbpTitles.Controls.Add(Me.grpMetadataToImport)
        Me.tbpTitles.Location = New System.Drawing.Point(4, 22)
        Me.tbpTitles.Name = "tbpTitles"
        Me.tbpTitles.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTitles.Size = New System.Drawing.Size(409, 219)
        Me.tbpTitles.TabIndex = 2
        Me.tbpTitles.Tag = ""
        Me.tbpTitles.Text = "Metadata"
        Me.tbpTitles.UseVisualStyleBackColor = True
        '
        'grpMetadataToImport
        '
        Me.grpMetadataToImport.Controls.Add(Me.ucrChkImportElementsMetadata)
        Me.grpMetadataToImport.Controls.Add(Me.ucrChkImportStationsMetadata)
        Me.grpMetadataToImport.Location = New System.Drawing.Point(6, 6)
        Me.grpMetadataToImport.Name = "grpMetadataToImport"
        Me.grpMetadataToImport.Size = New System.Drawing.Size(384, 120)
        Me.grpMetadataToImport.TabIndex = 8
        Me.grpMetadataToImport.TabStop = False
        Me.grpMetadataToImport.Text = "Metadata to Import"
        '
        'ucrChkImportElementsMetadata
        '
        Me.ucrChkImportElementsMetadata.AutoSize = True
        Me.ucrChkImportElementsMetadata.Checked = True
        Me.ucrChkImportElementsMetadata.Location = New System.Drawing.Point(0, 46)
        Me.ucrChkImportElementsMetadata.Name = "ucrChkImportElementsMetadata"
        Me.ucrChkImportElementsMetadata.Size = New System.Drawing.Size(315, 23)
        Me.ucrChkImportElementsMetadata.TabIndex = 20
        '
        'ucrChkImportStationsMetadata
        '
        Me.ucrChkImportStationsMetadata.AutoSize = True
        Me.ucrChkImportStationsMetadata.Checked = True
        Me.ucrChkImportStationsMetadata.Location = New System.Drawing.Point(0, 22)
        Me.ucrChkImportStationsMetadata.Name = "ucrChkImportStationsMetadata"
        Me.ucrChkImportStationsMetadata.Size = New System.Drawing.Size(315, 23)
        Me.ucrChkImportStationsMetadata.TabIndex = 19
        '
        'tbColumns
        '
        Me.tbColumns.Controls.Add(Me.grpColumnsToInclude)
        Me.tbColumns.Location = New System.Drawing.Point(4, 22)
        Me.tbColumns.Name = "tbColumns"
        Me.tbColumns.Padding = New System.Windows.Forms.Padding(3)
        Me.tbColumns.Size = New System.Drawing.Size(409, 219)
        Me.tbColumns.TabIndex = 3
        Me.tbColumns.Tag = ""
        Me.tbColumns.Text = "Data"
        Me.tbColumns.UseVisualStyleBackColor = True
        '
        'grpColumnsToInclude
        '
        Me.grpColumnsToInclude.Controls.Add(Me.ucrChkIncludeElementAbbrv)
        Me.grpColumnsToInclude.Controls.Add(Me.ucrChkIncludeStationName)
        Me.grpColumnsToInclude.Controls.Add(Me.ucrChkIncludeAquistion)
        Me.grpColumnsToInclude.Controls.Add(Me.ucrChkIncludeEntryForm)
        Me.grpColumnsToInclude.Controls.Add(Me.ucrChkIncludeFlag)
        Me.grpColumnsToInclude.Controls.Add(Me.ucrChkIncludeQCStatus)
        Me.grpColumnsToInclude.Location = New System.Drawing.Point(8, 10)
        Me.grpColumnsToInclude.Name = "grpColumnsToInclude"
        Me.grpColumnsToInclude.Size = New System.Drawing.Size(368, 203)
        Me.grpColumnsToInclude.TabIndex = 32
        Me.grpColumnsToInclude.TabStop = False
        Me.grpColumnsToInclude.Text = "Columns to Include"
        '
        'ucrChkIncludeElementAbbrv
        '
        Me.ucrChkIncludeElementAbbrv.AutoSize = True
        Me.ucrChkIncludeElementAbbrv.Checked = True
        Me.ucrChkIncludeElementAbbrv.Location = New System.Drawing.Point(6, 42)
        Me.ucrChkIncludeElementAbbrv.Name = "ucrChkIncludeElementAbbrv"
        Me.ucrChkIncludeElementAbbrv.Size = New System.Drawing.Size(295, 23)
        Me.ucrChkIncludeElementAbbrv.TabIndex = 18
        '
        'ucrChkIncludeStationName
        '
        Me.ucrChkIncludeStationName.AutoSize = True
        Me.ucrChkIncludeStationName.Checked = True
        Me.ucrChkIncludeStationName.Location = New System.Drawing.Point(6, 19)
        Me.ucrChkIncludeStationName.Name = "ucrChkIncludeStationName"
        Me.ucrChkIncludeStationName.Size = New System.Drawing.Size(295, 23)
        Me.ucrChkIncludeStationName.TabIndex = 17
        '
        'ucrChkIncludeAquistion
        '
        Me.ucrChkIncludeAquistion.AutoSize = True
        Me.ucrChkIncludeAquistion.Checked = True
        Me.ucrChkIncludeAquistion.Location = New System.Drawing.Point(6, 90)
        Me.ucrChkIncludeAquistion.Name = "ucrChkIncludeAquistion"
        Me.ucrChkIncludeAquistion.Size = New System.Drawing.Size(295, 23)
        Me.ucrChkIncludeAquistion.TabIndex = 16
        '
        'ucrChkIncludeEntryForm
        '
        Me.ucrChkIncludeEntryForm.AutoSize = True
        Me.ucrChkIncludeEntryForm.Checked = False
        Me.ucrChkIncludeEntryForm.Location = New System.Drawing.Point(6, 139)
        Me.ucrChkIncludeEntryForm.Name = "ucrChkIncludeEntryForm"
        Me.ucrChkIncludeEntryForm.Size = New System.Drawing.Size(295, 23)
        Me.ucrChkIncludeEntryForm.TabIndex = 15
        '
        'ucrChkIncludeFlag
        '
        Me.ucrChkIncludeFlag.AutoSize = True
        Me.ucrChkIncludeFlag.Checked = True
        Me.ucrChkIncludeFlag.Location = New System.Drawing.Point(6, 113)
        Me.ucrChkIncludeFlag.Name = "ucrChkIncludeFlag"
        Me.ucrChkIncludeFlag.Size = New System.Drawing.Size(295, 23)
        Me.ucrChkIncludeFlag.TabIndex = 14
        '
        'ucrChkIncludeQCStatus
        '
        Me.ucrChkIncludeQCStatus.AutoSize = True
        Me.ucrChkIncludeQCStatus.Checked = True
        Me.ucrChkIncludeQCStatus.Location = New System.Drawing.Point(6, 66)
        Me.ucrChkIncludeQCStatus.Name = "ucrChkIncludeQCStatus"
        Me.ucrChkIncludeQCStatus.Size = New System.Drawing.Size(295, 23)
        Me.ucrChkIncludeQCStatus.TabIndex = 0
        '
        'tbpMoreOptions
        '
        Me.tbpMoreOptions.Controls.Add(Me.tbColumns)
        Me.tbpMoreOptions.Controls.Add(Me.tbpTitles)
        Me.tbpMoreOptions.Location = New System.Drawing.Point(-1, 4)
        Me.tbpMoreOptions.Name = "tbpMoreOptions"
        Me.tbpMoreOptions.SelectedIndex = 0
        Me.tbpMoreOptions.Size = New System.Drawing.Size(417, 245)
        Me.tbpMoreOptions.TabIndex = 2
        '
        'sdgClimsoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 284)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.tbpMoreOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgClimsoft"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "More Climsoft Options"
        Me.tbpTitles.ResumeLayout(False)
        Me.grpMetadataToImport.ResumeLayout(False)
        Me.grpMetadataToImport.PerformLayout()
        Me.tbColumns.ResumeLayout(False)
        Me.grpColumnsToInclude.ResumeLayout(False)
        Me.grpColumnsToInclude.PerformLayout()
        Me.tbpMoreOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents tbpTitles As TabPage
    Friend WithEvents grpMetadataToImport As GroupBox
    Friend WithEvents tbColumns As TabPage
    Friend WithEvents ucrChkIncludeQCStatus As ucrCheck
    Friend WithEvents tbpMoreOptions As TabControl
    Friend WithEvents grpColumnsToInclude As GroupBox
    Friend WithEvents ucrChkIncludeFlag As ucrCheck
    Friend WithEvents ucrChkIncludeAquistion As ucrCheck
    Friend WithEvents ucrChkIncludeEntryForm As ucrCheck
    Friend WithEvents ucrChkIncludeElementAbbrv As ucrCheck
    Friend WithEvents ucrChkIncludeStationName As ucrCheck
    Friend WithEvents ucrChkImportElementsMetadata As ucrCheck
    Friend WithEvents ucrChkImportStationsMetadata As ucrCheck
End Class
