<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgExportRObjects
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
        Me.grpSaveOptions = New System.Windows.Forms.GroupBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.lblExportFile = New System.Windows.Forms.Label()
        Me.lblObjects = New System.Windows.Forms.Label()
        Me.ucrInputExportFile = New instat.ucrInputTextBox()
        Me.ucrReceiverObjects = New instat.ucrReceiverMultiple()
        Me.ucrSelectorObjects = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpSaveOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSaveOptions
        '
        Me.grpSaveOptions.Controls.Add(Me.ucrInputExportFile)
        Me.grpSaveOptions.Controls.Add(Me.cmdBrowse)
        Me.grpSaveOptions.Controls.Add(Me.lblExportFile)
        Me.grpSaveOptions.Location = New System.Drawing.Point(10, 204)
        Me.grpSaveOptions.Name = "grpSaveOptions"
        Me.grpSaveOptions.Size = New System.Drawing.Size(398, 56)
        Me.grpSaveOptions.TabIndex = 3
        Me.grpSaveOptions.TabStop = False
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(327, 23)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(62, 23)
        Me.cmdBrowse.TabIndex = 2
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'lblExportFile
        '
        Me.lblExportFile.AutoSize = True
        Me.lblExportFile.Location = New System.Drawing.Point(11, 27)
        Me.lblExportFile.Name = "lblExportFile"
        Me.lblExportFile.Size = New System.Drawing.Size(59, 13)
        Me.lblExportFile.TabIndex = 0
        Me.lblExportFile.Text = "Export File:"
        '
        'lblObjects
        '
        Me.lblObjects.AutoSize = True
        Me.lblObjects.Location = New System.Drawing.Point(264, 42)
        Me.lblObjects.Name = "lblObjects"
        Me.lblObjects.Size = New System.Drawing.Size(91, 13)
        Me.lblObjects.TabIndex = 1
        Me.lblObjects.Text = "Selected Objects:"
        '
        'ucrInputExportFile
        '
        Me.ucrInputExportFile.AddQuotesIfUnrecognised = True
        Me.ucrInputExportFile.IsMultiline = False
        Me.ucrInputExportFile.IsReadOnly = False
        Me.ucrInputExportFile.Location = New System.Drawing.Point(71, 24)
        Me.ucrInputExportFile.Name = "ucrInputExportFile"
        Me.ucrInputExportFile.Size = New System.Drawing.Size(251, 21)
        Me.ucrInputExportFile.TabIndex = 1
        '
        'ucrReceiverObjects
        '
        Me.ucrReceiverObjects.frmParent = Me
        Me.ucrReceiverObjects.Location = New System.Drawing.Point(264, 60)
        Me.ucrReceiverObjects.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverObjects.Name = "ucrReceiverObjects"
        Me.ucrReceiverObjects.Selector = Nothing
        Me.ucrReceiverObjects.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverObjects.TabIndex = 2
        Me.ucrReceiverObjects.ucrSelector = Nothing
        '
        'ucrSelectorObjects
        '
        Me.ucrSelectorObjects.bShowHiddenColumns = False
        Me.ucrSelectorObjects.bUseCurrentFilter = True
        Me.ucrSelectorObjects.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorObjects.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorObjects.Name = "ucrSelectorObjects"
        Me.ucrSelectorObjects.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorObjects.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 272)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(398, 52)
        Me.ucrBase.TabIndex = 4
        '
        'dlgExportRObjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 328)
        Me.Controls.Add(Me.lblObjects)
        Me.Controls.Add(Me.grpSaveOptions)
        Me.Controls.Add(Me.ucrReceiverObjects)
        Me.Controls.Add(Me.ucrSelectorObjects)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportRObjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export R Objects"
        Me.grpSaveOptions.ResumeLayout(False)
        Me.grpSaveOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorObjects As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverObjects As ucrReceiverMultiple
    Friend WithEvents grpSaveOptions As GroupBox
    Friend WithEvents ucrInputExportFile As ucrInputTextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents lblExportFile As Label
    Friend WithEvents lblObjects As Label
End Class
