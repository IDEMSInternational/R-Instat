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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorObjects = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverObjects = New instat.ucrReceiverMultiple()
        Me.grpSaveOptions = New System.Windows.Forms.GroupBox()
        Me.ucrInputFile = New instat.ucrInputTextBox()
        Me.rdoBrowse = New System.Windows.Forms.Button()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.lblObjects = New System.Windows.Forms.Label()
        Me.grpSaveOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 272)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(398, 52)
        Me.ucrBase.TabIndex = 1
        '
        'ucrSelectorObjects
        '
        Me.ucrSelectorObjects.bShowHiddenColumns = False
        Me.ucrSelectorObjects.bUseCurrentFilter = True
        Me.ucrSelectorObjects.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorObjects.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorObjects.Name = "ucrSelectorObjects"
        Me.ucrSelectorObjects.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorObjects.TabIndex = 2
        '
        'ucrReceiverObjects
        '
        Me.ucrReceiverObjects.frmParent = Me
        Me.ucrReceiverObjects.Location = New System.Drawing.Point(264, 60)
        Me.ucrReceiverObjects.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverObjects.Name = "ucrReceiverObjects"
        Me.ucrReceiverObjects.Selector = Nothing
        Me.ucrReceiverObjects.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverObjects.TabIndex = 3
        Me.ucrReceiverObjects.ucrSelector = Nothing
        '
        'grpSaveOptions
        '
        Me.grpSaveOptions.Controls.Add(Me.ucrInputFile)
        Me.grpSaveOptions.Controls.Add(Me.rdoBrowse)
        Me.grpSaveOptions.Controls.Add(Me.lblFile)
        Me.grpSaveOptions.Location = New System.Drawing.Point(10, 204)
        Me.grpSaveOptions.Name = "grpSaveOptions"
        Me.grpSaveOptions.Size = New System.Drawing.Size(398, 56)
        Me.grpSaveOptions.TabIndex = 6
        Me.grpSaveOptions.TabStop = False
        '
        'ucrInputFile
        '
        Me.ucrInputFile.AddQuotesIfUnrecognised = True
        Me.ucrInputFile.IsMultiline = False
        Me.ucrInputFile.IsReadOnly = False
        Me.ucrInputFile.Location = New System.Drawing.Point(40, 24)
        Me.ucrInputFile.Name = "ucrInputFile"
        Me.ucrInputFile.Size = New System.Drawing.Size(251, 21)
        Me.ucrInputFile.TabIndex = 1
        '
        'rdoBrowse
        '
        Me.rdoBrowse.Location = New System.Drawing.Point(296, 23)
        Me.rdoBrowse.Name = "rdoBrowse"
        Me.rdoBrowse.Size = New System.Drawing.Size(62, 23)
        Me.rdoBrowse.TabIndex = 2
        Me.rdoBrowse.Text = "Browse"
        Me.rdoBrowse.UseVisualStyleBackColor = True
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(11, 27)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(26, 13)
        Me.lblFile.TabIndex = 0
        Me.lblFile.Text = "File:"
        '
        'lblObjects
        '
        Me.lblObjects.AutoSize = True
        Me.lblObjects.Location = New System.Drawing.Point(264, 42)
        Me.lblObjects.Name = "lblObjects"
        Me.lblObjects.Size = New System.Drawing.Size(91, 13)
        Me.lblObjects.TabIndex = 7
        Me.lblObjects.Text = "Selected Objects:"
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
    Friend WithEvents ucrInputFile As ucrInputTextBox
    Friend WithEvents rdoBrowse As Button
    Friend WithEvents lblFile As Label
    Friend WithEvents lblObjects As Label
End Class
