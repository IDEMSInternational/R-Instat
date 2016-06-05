<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMetadata
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
        Me.lblNewField = New System.Windows.Forms.Label()
        Me.chkOpenMetadataEditorAferAdding = New System.Windows.Forms.CheckBox()
        Me.cmdOpenMetdataEditor = New System.Windows.Forms.Button()
        Me.grdOpenMetadataEditor = New System.Windows.Forms.DataGridView()
        Me.ucrInputNewField = New instat.ucrInputTextBox()
        Me.ucrDFSelectorForMetadata = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.grdOpenMetadataEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNewField
        '
        Me.lblNewField.AutoSize = True
        Me.lblNewField.Location = New System.Drawing.Point(237, 13)
        Me.lblNewField.Name = "lblNewField"
        Me.lblNewField.Size = New System.Drawing.Size(54, 13)
        Me.lblNewField.TabIndex = 2
        Me.lblNewField.Tag = "New_Field"
        Me.lblNewField.Text = "New Field"
        '
        'chkOpenMetadataEditorAferAdding
        '
        Me.chkOpenMetadataEditorAferAdding.AutoSize = True
        Me.chkOpenMetadataEditorAferAdding.Location = New System.Drawing.Point(240, 60)
        Me.chkOpenMetadataEditorAferAdding.Name = "chkOpenMetadataEditorAferAdding"
        Me.chkOpenMetadataEditorAferAdding.Size = New System.Drawing.Size(190, 17)
        Me.chkOpenMetadataEditorAferAdding.TabIndex = 4
        Me.chkOpenMetadataEditorAferAdding.Tag = "Open_Metadata_Editor_after_adding"
        Me.chkOpenMetadataEditorAferAdding.Text = "Open Metadata Editor after Adding"
        Me.chkOpenMetadataEditorAferAdding.UseVisualStyleBackColor = True
        '
        'cmdOpenMetdataEditor
        '
        Me.cmdOpenMetdataEditor.Location = New System.Drawing.Point(13, 143)
        Me.cmdOpenMetdataEditor.Name = "cmdOpenMetdataEditor"
        Me.cmdOpenMetdataEditor.Size = New System.Drawing.Size(120, 23)
        Me.cmdOpenMetdataEditor.TabIndex = 5
        Me.cmdOpenMetdataEditor.Text = "Open Metadata Editor"
        Me.cmdOpenMetdataEditor.UseVisualStyleBackColor = True
        '
        'grdOpenMetadataEditor
        '
        Me.grdOpenMetadataEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdOpenMetadataEditor.Location = New System.Drawing.Point(13, 56)
        Me.grdOpenMetadataEditor.Name = "grdOpenMetadataEditor"
        Me.grdOpenMetadataEditor.Size = New System.Drawing.Size(221, 81)
        Me.grdOpenMetadataEditor.TabIndex = 6
        '
        'ucrInputNewField
        '
        Me.ucrInputNewField.Location = New System.Drawing.Point(240, 32)
        Me.ucrInputNewField.Name = "ucrInputNewField"
        Me.ucrInputNewField.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputNewField.TabIndex = 3
        '
        'ucrDFSelectorForMetadata
        '
        Me.ucrDFSelectorForMetadata.Location = New System.Drawing.Point(13, 13)
        Me.ucrDFSelectorForMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDFSelectorForMetadata.Name = "ucrDFSelectorForMetadata"
        Me.ucrDFSelectorForMetadata.Size = New System.Drawing.Size(120, 40)
        Me.ucrDFSelectorForMetadata.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 197)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgMetadata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 261)
        Me.Controls.Add(Me.grdOpenMetadataEditor)
        Me.Controls.Add(Me.cmdOpenMetdataEditor)
        Me.Controls.Add(Me.chkOpenMetadataEditorAferAdding)
        Me.Controls.Add(Me.ucrInputNewField)
        Me.Controls.Add(Me.lblNewField)
        Me.Controls.Add(Me.ucrDFSelectorForMetadata)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgMetadata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Metadata"
        Me.Text = "Metadata"
        CType(Me.grdOpenMetadataEditor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDFSelectorForMetadata As ucrDataFrame
    Friend WithEvents lblNewField As Label
    Friend WithEvents ucrInputNewField As ucrInputTextBox
    Friend WithEvents chkOpenMetadataEditorAferAdding As CheckBox
    Friend WithEvents cmdOpenMetdataEditor As Button
    Friend WithEvents grdOpenMetadataEditor As DataGridView
End Class
