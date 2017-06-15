<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgExportGraphAsImage
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
        Me.lblSelectedGraph = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.ucrSelectedGraphReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorGraphAsImage = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.ucrInputFile = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'lblSelectedGraph
        '
        Me.lblSelectedGraph.AutoSize = True
        Me.lblSelectedGraph.Location = New System.Drawing.Point(265, 45)
        Me.lblSelectedGraph.Name = "lblSelectedGraph"
        Me.lblSelectedGraph.Size = New System.Drawing.Size(84, 13)
        Me.lblSelectedGraph.TabIndex = 1
        Me.lblSelectedGraph.Text = "Selected Graph:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(326, 194)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(75, 23)
        Me.cmdBrowse.TabIndex = 4
        Me.cmdBrowse.Text = "Browse..."
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'ucrSelectedGraphReceiver
        '
        Me.ucrSelectedGraphReceiver.frmParent = Me
        Me.ucrSelectedGraphReceiver.Location = New System.Drawing.Point(265, 60)
        Me.ucrSelectedGraphReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectedGraphReceiver.Name = "ucrSelectedGraphReceiver"
        Me.ucrSelectedGraphReceiver.Selector = Nothing
        Me.ucrSelectedGraphReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrSelectedGraphReceiver.TabIndex = 2
        Me.ucrSelectedGraphReceiver.ucrSelector = Nothing
        '
        'ucrSelectorGraphAsImage
        '
        Me.ucrSelectorGraphAsImage.bShowHiddenColumns = False
        Me.ucrSelectorGraphAsImage.bUseCurrentFilter = True
        Me.ucrSelectorGraphAsImage.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorGraphAsImage.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorGraphAsImage.Name = "ucrSelectorGraphAsImage"
        Me.ucrSelectorGraphAsImage.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorGraphAsImage.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 223)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(404, 52)
        Me.ucrBase.TabIndex = 5
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.Location = New System.Drawing.Point(10, 199)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(59, 13)
        Me.lblExport.TabIndex = 6
        Me.lblExport.Text = "Export File:"
        '
        'ucrInputFile
        '
        Me.ucrInputFile.AddQuotesIfUnrecognised = True
        Me.ucrInputFile.IsMultiline = False
        Me.ucrInputFile.IsReadOnly = False
        Me.ucrInputFile.Location = New System.Drawing.Point(70, 196)
        Me.ucrInputFile.Name = "ucrInputFile"
        Me.ucrInputFile.Size = New System.Drawing.Size(251, 21)
        Me.ucrInputFile.TabIndex = 7
        '
        'dlgExportGraphAsImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 288)
        Me.Controls.Add(Me.ucrInputFile)
        Me.Controls.Add(Me.lblExport)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.lblSelectedGraph)
        Me.Controls.Add(Me.ucrSelectedGraphReceiver)
        Me.Controls.Add(Me.ucrSelectorGraphAsImage)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportGraphAsImage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Graph As Image"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorGraphAsImage As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectedGraphReceiver As ucrReceiverSingle
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents lblSelectedGraph As Label
    Friend WithEvents lblExport As Label
    Friend WithEvents ucrInputFile As ucrInputTextBox
End Class
